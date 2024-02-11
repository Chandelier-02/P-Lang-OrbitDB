// using System;
// using System.Runtime;
// using System.Collections.Generic;
// using System.Linq;
// using System.IO;
// using Plang.CSharpRuntime;
// using Plang.CSharpRuntime.Values;
// using Plang.CSharpRuntime.Exceptions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Security.Principal;
// using System.Dynamic;
// using System.Runtime.InteropServices;
// using System.Collections;
// using System.Net.WebSockets;

// namespace PImplementation {
//     public class tOpLog : IPrtValue {
//         public readonly string Identity;
//         public readonly string Id;
//         private readonly tMemoryStorage<tEntry> Entries;
//         private readonly tMemoryStorage<bool> Index;
//         private readonly tHeads Heads;
//         private readonly Func<tEntry, tEntry, int> SortFn;
//         private readonly tHybridLogicalClock Clock;

//         #nullable enable
//         public tOpLog(
//             string identity, 
//             string? logId, 
//             tEntry[]? logHeads, 
//             tHybridLogicalClock? logClock, 
//             tMemoryStorage<tEntry>? entryStorage, 
//             tMemoryStorage<tEntry>? headsStorageIn, 
//             tMemoryStorage<bool>? indexStorage,
//             Func<tEntry, tEntry, int>? sortFn
//         ) {
//             Identity = identity;
//             Id = logId ?? Guid.NewGuid().ToString();
//             tEntry[] LogHeads = logHeads ?? new tEntry[]{};
//             Clock = logClock ?? new tHybridLogicalClock(identity, null, null);
//             Entries = entryStorage ?? new tMemoryStorage<tEntry>();
//             Index = indexStorage ?? new tMemoryStorage<bool>();
//             tMemoryStorage<tEntry> headsStorage = headsStorageIn ?? new tMemoryStorage<tEntry>();
//             Heads = new tHeads(headsStorage, logHeads);
//             SortFn = sortFn ?? ((entryA, entryB) => Clock.CompareTimestamps(entryA.Clock, entryB.Clock));
//         }   

//         public tTimestamp GetClockLastState() {
//             return Clock.Last();
//         }

//         public tEntry[] GetHeads() {
//             tEntry[] heads = Heads.All();
//             Array.Sort(heads, new Comparison<tEntry>(SortFn));
//             heads.Reverse();
//             return heads;
//         }

//         public tEntry[] GetAllEntries() {
//             return new tEntry[]{};
//         }

//         public tEntry? GetEntry(string hash) {
//             tEntry? foundEntry = Entries.Get(hash);
//             if (foundEntry != null) {
//                 Index.Put(hash, true);
//                 return foundEntry;
//             }
//             return null;
//         }

//         public bool HasEntry(string hash) {
//             return Index.Get(hash);
//         }

//         public tEntry AppendEntry(string data, int referencesCount = 0) {
//             tEntry[] heads = GetHeads();
//             string[] nexts = (string[])heads.Select(head => head.Hash);
//             string[] refs = GetReferences(heads, referencesCount + heads.Length);
//             tEntry entry = tEntry.Create(Identity, Id, data, Clock.Now(), nexts, refs);
//             Heads.Set(new tEntry[]{entry});
//             Entries.Put(entry.Hash, entry);
//             Index.Put(entry.Hash, true);
//             return entry;
//         }

//         public IEnumerable<tEntry> Traverse(tEntry[] rootEntriesIn, Func<tEntry?, bool> shouldStopFnIn, bool useRefs = true) {
//             Func<tEntry, bool> defaultStopFn = (entry) => false;
//             Func<tEntry, bool> shouldStopFn = shouldStopFnIn ?? defaultStopFn;

//             tEntry[] rootEntries = rootEntriesIn ?? GetHeads();
//             Array.Sort(rootEntries);

//             tEntry[] stack = (tEntry[])rootEntries.Clone();

//             Dictionary<string, bool> traversed = new Dictionary<string, bool>();
//             string[] toFetch = new string[]{};
//             Dictionary<string, bool> fetched = new Dictionary<string, bool>();

//             Func<string, bool> notIndexed = (hash) => !(traversed.ContainsKey(hash) || fetched.ContainsKey(hash));

//             tEntry entry;
//             while (stack.Length > 0) {
//                 Array.Sort(stack, new Comparison<tEntry>(SortFn));
//                 entry = stack.Last();
//                 Array.Resize(ref stack, stack.Length - 1);
//                 var (hash, next, refs) = entry;
//                 if (!traversed.ContainsKey(hash)) {
//                     yield return entry;
//                     bool done = shouldStopFn(entry);
//                     if (done) {
//                         break;
//                     }

//                     traversed[hash] = true;
//                     fetched[hash] = true;

//                     toFetch = (string[])toFetch.Concat(next).Concat(useRefs ? refs : Array.Empty<string>()).Where(notIndexed);

//                     Func<string, tEntry?> fetchEntries = (hash) => {
//                         if (!traversed.ContainsKey(hash) && !fetched.ContainsKey(hash)) {
//                             fetched[hash] = true;
//                             return GetEntry(hash);
//                         } else {
//                             return null;
//                         }
//                     };

//                     tEntry[] nexts = (tEntry[])toFetch.Select(fetchEntries);

//                     HashSet<tEntry> uniqueEntries = new HashSet<tEntry>();
//                     var toFetchEntries = nexts
//                         .Where(e => e != null)
//                         .SelectMany(acc => {
//                             var combined = new List<string>(acc.Next);
//                             if (useRefs)
//                                 combined.AddRange(acc.Refs);
//                             return combined;
//                         })
//                         .Where(e => uniqueEntries.Add(Entries.Get(hash)!))
//                         .Where(notIndexed)
//                         .ToArray();

//                     stack = stack.Concat(nexts).ToArray();
//                 }
//             }
//         }

//         public void JoinLog(tOpLog? log) {
//             if (log == null) {
//                 throw new Exception("Log to join cannot be null.");
//             }

//             tEntry[] heads = log.GetHeads();
//             foreach (var head in heads) {
//                 JoinEntryToLog(head);
//             }
//             Entries.MergeEntries(log.Entries);
//         }

//         public bool JoinEntryToLog(tEntry entry) {
//             var (hash, next, refs) = entry;
//             if (entry.Id != Id) {
//                 throw new Exception("Entry's Id must be equal to log Id.");
//             }

//             Func<string, bool> isAlreadyInTheLog = (hash) => HasEntry(hash);
//             if (isAlreadyInTheLog(hash)) {
//                 return false;
//             }

//             Clock.Update(entry.Clock);

//             tEntry[]? newHeads = Heads.Add(entry);
//             if (newHeads == null) {
//                 return false;
//             }

//             Entries.Put(hash, entry);
//             Index.Put(hash, true);

//             return true;
//         } 

//         public string[] GetReferences(tEntry[] heads, int referencesCount = 0) {
//             string[] refs = new string[]{};
//             Func<tEntry?, bool> shouldStopTraversal = (entry) => {
//                 return refs.Length >= referencesCount && referencesCount == -1;
//             };
//             foreach (tEntry entry in Traverse(heads, shouldStopTraversal, false)) {
//                 refs.Append(entry.Hash);
//             }
//             Span<string> span = new Span<string>(refs);
//             refs = span.Slice(heads.Length + 1, referencesCount).ToArray();
//             return refs;
//         }

//         public IPrtValue Clone() {
//             return new tOpLog(Identity,
//                               Id, 
//                               GetHeads(), 
//                               (tHybridLogicalClock)Clock.Clone(), 
//                               (tMemoryStorage<tEntry>)Entries.Clone(), 
//                               new tMemoryStorage<tEntry>(), 
//                               (tMemoryStorage<bool>)Index.Clone(), 
//                               SortFn
//                             );
//         }

//         public bool Equals(IPrtValue? other) {
//             if (other is tOpLog otherOplog) {
//                 return Id == otherOplog.Id;
//             }
//             return false;
//         }
//     }
// }

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
            tEntry[] rootEntries = (tEntry[])rootEntriesIn.ToArray();
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
            Span<string> span = new Span<string>(refs);
            refs = span.Slice(heads.Count + 1, referencesCount).ToArray();
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
                entriesArray = (tEntry[])entriesArray.Reverse();
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