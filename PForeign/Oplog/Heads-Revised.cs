using System.Collections.Generic;

namespace PImplementation {
    # nullable enable
    public class Heads {
        private readonly MemoryStorage<Entry> memoryStorage;

        public Heads(MemoryStorage<Entry>? memoryStorage = null, List<Entry>? heads = null) {
            this.memoryStorage = memoryStorage ?? new MemoryStorage<Entry>();
            Put(heads ?? new List<Entry>());
        }

        public void Put(List<Entry> heads) {
            heads = FindHeads(heads);
            foreach (var head in heads) {
                memoryStorage.Put(head.Hash, head);
            }
        }

        public void Set(List<Entry> heads) {
            memoryStorage.Clear();
            Put(heads);
        }

        public List<Entry>? Add(Entry head) {
            List<Entry> currentHeads = All();
            if (currentHeads.Contains(head)) {
                return null;
            }
            currentHeads.Add(head);
            List<Entry> newHeads = FindHeads(currentHeads);
            Set(newHeads);

            return newHeads;
        }

        public IEnumerable<Entry> Iterator() {
            IEnumerable<KeyValuePair<string, Entry>> storageIterator = memoryStorage.Iterator();
            foreach (var kvp in storageIterator) {
                Entry head = kvp.Value;
                yield return head;
            }
        }

        public List<Entry> All() {
            List<Entry> values = new List<Entry>(Iterator());
            return values;
        }

        public void Clear() {
            memoryStorage.Clear();
        }

        private static List<Entry> FindHeads(List<Entry> entries) {
            HashSet<Entry> entriesSet = new HashSet<Entry>(entries);
            Dictionary<string, Entry> items = new Dictionary<string, Entry>();

            foreach (Entry entry in entriesSet) {
                foreach (string next in entry.Next) {
                    if (!items.TryAdd(next, entry)) {
                        items[next] = entry;
                    } 
                }
            }

            List<Entry> res = new List<Entry>();
            foreach (Entry entry in entriesSet) {
                if (!items.ContainsKey(entry.Hash)) {
                    res.Add(entry);
                }
            }

            return res;
        }
    }
}