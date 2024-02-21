// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Plang.CSharpRuntime;
// using Plang.CSharpRuntime.Values;

// namespace PImplementation {
//     public static partial class GlobalFunctions {
//         # nullable enable
//         public static PrtSeq Traverse(PrtSeq rootEntriesIn, PrtMap dictionary, tTraversalStopper stopper, bool useRefs, PMachine machine) {
//             PrtSeq traversedEntries = new PrtSeq();

//             Comparison<tEntry> sortFn = (entryA, entryB) => CompareTimestamps(entryA.Clock, entryB.Clock, machine);

//             List<tEntry> stack = rootEntriesIn.Cast<tEntry>().ToList();
//             stack.Sort(sortFn);

//             Dictionary<string, bool> traversed = new Dictionary<string, bool>();
//             List<string> toFetch = new List<string>();
//             Dictionary<string, bool> fetched = new Dictionary<string, bool>();

//             while (stack.Any()) {
//                 var entry = stack.Last();
//                 stack.RemoveAt(stack.Count - 1);
//                 if (!traversed.ContainsKey(entry.Hash)) {
//                     traversedEntries.Add(entry);
//                     if (stopper.ShouldStopFn(entry)) {
//                         break;
//                     }

//                     traversed[entry.Hash] = true;
//                     fetched[entry.Hash] = true;
//                     toFetch.AddRange(entry.Next);
//                     if (useRefs) {
//                         toFetch.AddRange(entry.Refs);
//                     }
//                     toFetch = toFetch.Distinct().Where(hash => !traversed.ContainsKey(hash) && !fetched.ContainsKey(hash)).ToList();

//                     List<tEntry> nexts = toFetch.Select(hash => {
//                         if (!fetched.ContainsKey(hash)) {
//                             fetched[hash] = true;
//                             return dictionary.TryGetValue((PrtString)hash, out var value) ? value as tEntry : null;
//                         }
//                         return null;
//                     }).Where(e => e != null).ToList()!;

//                     toFetch.Clear();

//                     stack.AddRange(nexts);
//                     stack.Sort(sortFn);
//                 }
//             }

//             machine.LogLine($"Traversed over {traversedEntries.Count} entries");

//             return traversedEntries;
//         }

//         public static PrtSet GetReferences(PrtSeq heads, PrtMap dictionary, int referencesCount, PMachine machine) {
//             PrtSet returnRefs = new PrtSet();
//             string[] refs = new string[]{};
//             tTraversalStopper stopper = new tTraversalStopper(refs, referencesCount);

//             foreach (tEntry entry in Traverse(heads, dictionary, stopper, false, machine)) {
//                 refs.Append(entry.Hash);
//             }
//             int startIndex = Math.Min(refs.Length, heads.Count + 1);
//             int sliceLength = Math.Min(refs.Length - startIndex, referencesCount);
//             refs = new Span<string>(refs).Slice(startIndex, sliceLength).ToArray();
//             foreach (var reference in refs) {
//                 returnRefs.Add((PrtString)reference);
//             }
//             return returnRefs;
//         }

//         public static tTraversalStopper CreateDefaultTraversalStopper(PMachine machine) {
//             return new tTraversalStopper();
//         }

//         public static tTraversalStopper CreateGetReferencesTraversalStopper(PrtSet refs, int referenceCount) {
//             return new tTraversalStopper(refs.Cast<string>().ToArray(), referenceCount);
//         }

//         public static PrtSeq Sorted(PrtSeq entries, bool reverse, PMachine machine) {
//             PrtSeq sortedValues = new PrtSeq();
//             Func<tEntry, tEntry, int> SortFn = (entryA, entryB) => CompareTimestamps(entryA.Clock, entryB.Clock, machine);
//             tEntry[] entriesArray = entries.Cast<tEntry>().ToArray();

//             if (reverse) {
//                 Array.Sort(entriesArray, new Comparison<tEntry>(SortFn));
//                 entriesArray = entriesArray.Reverse().ToArray();
//             } else {
//                 Array.Sort(entriesArray, new Comparison<tEntry>(SortFn));
//             }

//             foreach (var entry in entriesArray) {
//                 sortedValues.Add(entry);
//             }

//             machine.LogLine($"GOT {sortedValues.Count} SORTED VALUES");
//             return sortedValues;
//         }
//     }

//     public interface TraversalStopper : IPrtValue{
//         bool ShouldStopFn(tEntry? entry);
//     }

//     public class tTraversalStopper : TraversalStopper {
//     public string[]? refs { get; set; }
//     public PrtInt? referencesCount { get; set; }

//     public tTraversalStopper() {}

//     public tTraversalStopper(string[]? refs = null, PrtInt? referencesCount = null) {
//         this.refs = refs;
//         this.referencesCount = referencesCount;
//     }

//     public bool ShouldStopFn(tEntry? entry) {
//         return referencesCount.HasValue && refs != null && refs?.Length >= referencesCount.Value;
//     }

//     public IPrtValue Clone() {
//         return new tTraversalStopper(refs?.Clone() as string[], referencesCount);
//     }

//     public bool Equals(IPrtValue? other) {
//         if (other is tTraversalStopper otherTraversalStopper) {
//             bool refsEqual = (refs == null && otherTraversalStopper.refs == null) ||
//                              (refs != null && otherTraversalStopper.refs != null && refs.SequenceEqual(otherTraversalStopper.refs));
//             bool countEqual = referencesCount == otherTraversalStopper.referencesCount;
//             return refsEqual && countEqual;
//         } else {
//             return false;
//         }
//     }
// }
// }