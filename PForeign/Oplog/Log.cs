using System;
using System.Collections.Generic;
using System.Linq;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    public static partial class GlobalFunctions {
        # nullable enable
        public static PrtSeq Traverse(PrtSeq rootEntriesIn, PrtMap dictionary, tTraversalStopper stopper, bool useRefs, PMachine machine) {
            PrtSeq traversedEntries = new PrtSeq();

            Func<tEntry, tEntry, int> SortFn = (entryA, entryB) => CompareTimestamps(entryA.Clock, entryB.Clock, machine);
            tEntry[] rootEntries = (tEntry[])rootEntriesIn.ToArray().Cast<tEntry>().ToArray();
            Array.Sort(rootEntries);

            tEntry[] stack = (tEntry[])rootEntries.Clone();

            Dictionary<string, bool> traversed = new Dictionary<string, bool>();
            string[] toFetch = new string[]{};
            Dictionary<string, bool> fetched = new Dictionary<string, bool>();

            Func<string, bool> notIndexed = (hash) => !(traversed.ContainsKey(hash) || fetched.ContainsKey(hash));

            tEntry entry;
            while (stack.Length > 0) {
                Array.Sort(stack, new Comparison<tEntry>(SortFn));
                entry = stack.Last();
                Array.Resize(ref stack, stack.Length - 1);
                var (hash, next, refs) = entry;
                if (!traversed.ContainsKey(hash)) {
                    traversedEntries.Append(entry);
                    bool done = stopper.ShouldStopFn(entry);
                    if (done) {
                        break;
                    }

                    traversed[hash] = true;
                    fetched[hash] = true;

                    toFetch = (string[])toFetch.Concat(next).Concat(useRefs ? refs : Array.Empty<string>()).Where(notIndexed);

                    # nullable enable
                    Func<string, tEntry?> getEntry = (hash) => {
                        if (dictionary.TryGetValue((PrtString)hash, out IPrtValue? value)) {
                            return (tEntry)value;
                        } else {
                            return null;
                        }
                    };

                    # nullable enable
                    Func<string, tEntry?> fetchEntries = (hash) => {
                        if (!traversed.ContainsKey(hash) && !fetched.ContainsKey(hash)) {
                            fetched[hash] = true;
                            return getEntry(hash);
                        } else {
                            return null;
                        }
                    };

                    tEntry[] nexts = (tEntry[])toFetch.Select(fetchEntries);

                    HashSet<tEntry> uniqueEntries = new HashSet<tEntry>();
                    var toFetchEntries = nexts
                        .Where(e => e != null)
                        .SelectMany(acc => {
                            var combined = new List<string>(acc!.Next);
                            if (useRefs)
                                combined.AddRange(acc.Refs);
                            return combined;
                        })
                        .Where(entry => uniqueEntries.Add((tEntry)dictionary[(PrtString)hash]))
                        .Where(notIndexed)
                        .ToArray();

                    stack = stack.Concat(nexts).ToArray();
                }
            }

            return traversedEntries;
        }

        public static PrtSet GetReferences(PrtSeq heads, PrtMap dictionary, int referencesCount, PMachine machine) {
            PrtSet returnRefs = new PrtSet();
            string[] refs = new string[]{};
            tTraversalStopper stopper = new tTraversalStopper(refs, referencesCount);

            foreach (tEntry entry in Traverse(heads, dictionary, stopper, false, machine)) {
                refs.Append(entry.Hash);
            }
            int startIndex = Math.Min(refs.Length, heads.Count + 1);
            int sliceLength = Math.Min(refs.Length - startIndex, referencesCount);
            refs = new Span<string>(refs).Slice(startIndex, sliceLength).ToArray();
            foreach (var reference in refs) {
                returnRefs.Add((PrtString)reference);
            }
            return returnRefs;
        }

        public static tTraversalStopper CreateDefaultTraversalStopper(PMachine machine) {
            return new tTraversalStopper();
        }

        public static tTraversalStopper CreateGetReferencesTraversalStopper(PrtSet refs, int referenceCount) {
            return new tTraversalStopper(refs.Cast<string>().ToArray(), referenceCount);
        }

        public static PrtSeq Sorted(PrtSeq entries, bool reverse, PMachine machine) {
            PrtSeq sortedValues = new PrtSeq();
            Func<tEntry, tEntry, int> SortFn = (entryA, entryB) => CompareTimestamps(entryA.Clock, entryB.Clock, machine);
            tEntry[] entriesArray = new tEntry[]{};
            foreach (var entry in entries) {
                entriesArray.Append((tEntry)entry);
            }

            if (reverse) {
                Array.Sort(entriesArray, new Comparison<tEntry>(SortFn));
                entriesArray = entriesArray.Reverse().ToArray();
            } else {
                Array.Sort(entriesArray, new Comparison<tEntry>(SortFn));
            }

            foreach (var entry in entriesArray) {
                sortedValues.Add(entry);
            }

            return sortedValues;
        }
    }

    public interface TraversalStopper : IPrtValue{
        bool ShouldStopFn(tEntry? entry);
    }

    public class tTraversalStopper : TraversalStopper {
    public string[]? refs { get; set; }
    public PrtInt? referencesCount { get; set; }

    public tTraversalStopper() {}

    public tTraversalStopper(string[]? refs = null, PrtInt? referencesCount = null) {
        this.refs = refs;
        this.referencesCount = referencesCount;
    }

    public bool ShouldStopFn(tEntry? entry) {
        return referencesCount.HasValue && refs != null && refs?.Length >= referencesCount.Value;
    }

    public IPrtValue Clone() {
        return new tTraversalStopper(refs?.Clone() as string[], referencesCount);
    }

    public bool Equals(IPrtValue? other) {
        if (other is tTraversalStopper otherTraversalStopper) {
            bool refsEqual = (refs == null && otherTraversalStopper.refs == null) ||
                             (refs != null && otherTraversalStopper.refs != null && refs.SequenceEqual(otherTraversalStopper.refs));
            bool countEqual = referencesCount == otherTraversalStopper.referencesCount;
            return refsEqual && countEqual;
        } else {
            return false;
        }
    }
}
}