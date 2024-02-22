using System;
using System.Collections.Generic;
using System.Linq;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    #nullable enable
    public class Log : IPrtValue {
        public string Identity { get; }
        public string Id { get; }
        public HybridLogicalClock _Clock { get; }
        public MemoryStorage<Entry> _Entries { get; }
        public MemoryStorage<bool> _Index { get; }
        public Heads _Heads { get; } 
        public TimestampComparer SortFnComparer { get; }

        public Log(
            string identity, 
            string logId, 
            List<Entry>? logHeads = null, 
            HybridLogicalClock? clock = null, 
            MemoryStorage<Entry>? entryStorage = null,
            MemoryStorage<Entry>? headsStorage = null,
            MemoryStorage<bool>? indexStorage = null,
            TimestampComparer? sortFnComparer = null
        ) {
            Identity = identity;
            Id = logId;
            _Clock = clock ?? new HybridLogicalClock(identity);
            _Entries = entryStorage ?? new MemoryStorage<Entry>();
            _Index = indexStorage ?? new MemoryStorage<bool>();
            _Heads = new Heads(headsStorage ?? new MemoryStorage<Entry>(), logHeads);
            SortFnComparer = sortFnComparer ?? new TimestampComparer();
        }

        public Timestamp Clock() {
            return _Clock.LastTimestamp;
        }

        public List<Entry> Heads() {
            List<Entry> res = _Heads.All();
            res.Sort((IComparer<Entry>?)SortFnComparer);
            res.Reverse();
            return res;
        }

        public List<Entry> Values() {
            List<Entry> traversed = Traverse();
            traversed.Reverse();
            return traversed;
        }

        public Entry? Get(string hash) {
            Entry? foundEntry = _Entries.Get(hash);
            if (foundEntry != null) {
                _Index.Put(hash, true);
                return foundEntry;
            }
            return null;
        }

        public bool Has(string hash) {
            bool hasEntry = _Index.Get(hash);
            return hasEntry;
        }

        public Entry Append(string data, int referencesCount = 0) {
            List<Entry> heads_ = Heads();
            List<string> nexts = heads_.Select(entry => entry.Hash).ToList();
            List<string> refs = GetReferences(heads_, referencesCount + heads_.Count);

            Entry entry = new Entry(Identity, Id, data, _Clock.Now(), nexts, refs);

            _Heads.Set(new List<Entry>() { entry });
            _Entries.Put(entry.Hash, entry);
            _Index.Put(entry.Hash, true);

            return entry;
        }

        public void Join(Log log) {
            List<Entry> otherLogHeads = log.Heads();
            foreach (Entry head in otherLogHeads) {
                JoinEntry(head);
            }
            _Entries.Merge(log._Entries);
        }

        public bool JoinEntry(Entry entry) {
            if (entry.Id != Id) {
                throw new Exception();
            }

            if (Has(entry.Hash)) {
                return false;
            }

            _Clock.Update(entry.Clock);

            List<Entry>? newHeads = _Heads.Add(entry);
            if (newHeads == null) {
                return false;
            }

            _Entries.Put(entry.Hash, entry);
            _Index.Put(entry.Hash, true);

            return true;
        }

        public List<Entry> Traverse(List<Entry>? rootEntries = null, Func<Entry, bool>? shouldStopFn = null, bool useRefs = true) {
            shouldStopFn ??= _ => false;
            List<Entry> stack = new List<Entry>(rootEntries ?? Heads());
            stack.Sort((IComparer<Entry>?)SortFnComparer);

            HashSet<string> traversed = new HashSet<string>();
            List<string> toFetch = new List<string>();
            HashSet<string> fetched = new HashSet<string>();

            List<Entry> result = new List<Entry>();

            Entry? entry = null;
            while (stack.Count > 0) {
                stack.Sort((IComparer<Entry>?)SortFnComparer);
                entry = stack.Last();
                stack.RemoveAt(stack.Count - 1);

                if (entry is Entry notNullEntry) {
                    if (!traversed.Contains(notNullEntry.Hash)) {
                        result.Add(notNullEntry);
                        if (shouldStopFn(notNullEntry)) break;

                        traversed.Add(notNullEntry.Hash);
                        fetched.Add(notNullEntry.Hash);

                        toFetch.AddRange(notNullEntry.Next.Concat(useRefs ? notNullEntry.Refs : new List<string>()));

                        Func<string, Entry?> fetchEntries = (hash) => {
                            if (!traversed.Contains(hash) && !fetched.Contains(hash)) {
                                fetched.Add(hash);
                                return Get(hash);
                            }
                            return null;
                        };

                        List<Entry> nexts = (List<Entry>)toFetch.Select(fetchEntries).Where(e => e != null);

                        List<Entry> combined = (List<Entry>)nexts.SelectMany(e => e.Next.Concat(useRefs ? e.Refs : new List<string>())).Distinct();

                        toFetch = (List<string>)combined.Where(e => !(traversed.Contains(e.Hash) || fetched.Contains(e.Hash)));

                        stack.AddRange(nexts);
                    }
                }
            }
            return result;
        }

        public List<string> GetReferences(List<Entry> heads, int amount = 0) {
            List<string> refs = new List<string>();
            Func<Entry, bool> shouldStopTraversal = (entry) => {
                return refs.Count >= amount && amount != -1;
            };

            refs = (List<string>)Traverse(heads, shouldStopTraversal, false).Select(e => e.Hash);
            refs = refs.GetRange(heads.Count + 1, amount);
            return refs;
        }

        public bool Equals(IPrtValue? other) {
            if (other is Log otherLog) {
                return otherLog.Id == Id;
            }
            return false;
        }

        public IPrtValue Clone() {
            return new Log(Identity, Id, Heads(), _Clock, _Entries, null, _Index, SortFnComparer);
        }
    }
}