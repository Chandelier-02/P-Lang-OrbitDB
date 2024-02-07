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
using System.Threading.Tasks;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    public static partial class GlobalFunctions {
        # nullable enable
        public static async Task<PrtSeq> TraverseAsync(tEntry[] rootEntriesIn, Func<tEntry?, bool> shouldStopFn, bool useRefs, PMachine storageMachine, PMachine machine) {
            PrtSeq traversedEntries = new PrtSeq();

            Func<tEntry, tEntry, int> SortFn = (entryA, entryB) => CompareTimestamps(entryA.Clock, entryB.Clock, machine);
            tEntry[] rootEntries = rootEntriesIn;
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
                    bool done = shouldStopFn(entry);
                    if (done) {
                        break;
                    }

                    traversed[hash] = true;
                    fetched[hash] = true;

                    toFetch = (string[])toFetch.Concat(next).Concat(useRefs ? refs : Array.Empty<string>()).Where(notIndexed);

                    # nullable enable
                    Func<string, Task<tEntry?>> fetchEntries = async (hash) => {
                        if (!traversed.ContainsKey(hash) && !fetched.ContainsKey(hash)) {
                            fetched[hash] = true;
                            PrtNamedTuple payload = new PrtNamedTuple(new string[]{ "source", "key" }, (IPrtValue)machine, (PrtString)hash);
                            machine.TrySendEvent(storageMachine.self, new eGetValueFromStorageReq(), payload);
                            var receivedEvent = await machine.TryReceiveEvent(typeof(eGetValueFromStorageResp), typeof(PHalt));
                            tEntry? gotEntry = null;
                            while (gotEntry == null) {
                                switch (receivedEvent) {
                                    case PHalt _hv: { machine.TryRaiseEvent(_hv); break; }
                                    case eGetValueFromStorageResp respEvnt: {
                                        PrtNamedTuple resp = (PrtNamedTuple)(respEvnt.Payload);
                                        gotEntry = (tEntry)resp["value"];
                                    } break;
                                }
                                if (gotEntry == null) {
                                    receivedEvent = await machine.TryReceiveEvent(typeof(eGetValueFromStorageResp), typeof(PHalt));
                                }
                            }
                            return gotEntry;
                        } else {
                            return null;
                        }
                    };

                    IEnumerable<Task<tEntry?>> fetchTasks = toFetch.Select(fetchEntries);
                    tEntry?[] nexts = await Task.WhenAll(fetchTasks);

                    HashSet<tEntry> uniqueEntries = new HashSet<tEntry>();
                    var toFetchEntries = nexts
                        .Where(e => e != null)
                        .SelectMany(acc => {
                            var combined = new List<string>(acc!.Next);
                            if (useRefs)
                                combined.AddRange(acc.Refs);
                            return combined;
                        })
                        .Where(entry => uniqueEntries.Add((tEntry)GetValueFromMemoryStorage(memoryStorage, hash, machine)))
                        .Where(notIndexed)
                        .ToArray();

                    stack = stack.Concat(nexts).ToArray();
                }
            }

            return traversedEntries;
        }

        public static PrtSet GetReferences(tEntry[] heads, int referencesCount, tMemoryStorage memoryStorage, PMachine machine) {
            PrtSet returnRefs = new PrtSet();
            string[] refs = new string[]{};
            TraversalStopper stopper = new GetReferencesTraversalStopper(refs, referencesCount);

            foreach (tEntry entry in Traverse(heads, stopper.ShouldStop, false, memoryStorage, machine)) {
                refs.Append(entry.Hash);
            }
            Span<string> span = new Span<string>(refs);
            refs = span.Slice(heads.Length + 1, referencesCount).ToArray();
            foreach (var reference in refs) {
                returnRefs.Add((PrtString)reference);
            }
            return returnRefs;
        }
    }

    public interface TraversalStopper {
        bool ShouldStop(tEntry? entry);
    }

    public class DefaultTraversalStopper {
        public bool ShouldStop(tEntry? entry) {
            return false;
        }
    }

    public class GetReferencesTraversalStopper : TraversalStopper {
        private string[] refs;
        private int referencesCount;

        public GetReferencesTraversalStopper(string[] refs, int referencesCount) {
            this.refs = refs;
            this.referencesCount = referencesCount;
        }

        public bool ShouldStop(tEntry? entry) {
            return referencesCount != -1 && refs.Length >= referencesCount;
        }
    }

    internal partial class eGetValueFromStorageReq : PEvent
    {
        public eGetValueFromStorageReq() : base() {}
        public eGetValueFromStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetValueFromStorageReq();}
    }

    internal partial class eGetValueFromStorageResp : PEvent
    {
        public eGetValueFromStorageResp() : base() {}
        public eGetValueFromStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetValueFromStorageResp();}
    }
}