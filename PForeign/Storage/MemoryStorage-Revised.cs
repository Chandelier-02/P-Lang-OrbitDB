using System.Collections.Generic;
using System.Linq;

namespace PImplementation {
    # nullable enable
    public class MemoryStorage<T> {
        public Dictionary<string, T> memory = new Dictionary<string, T>();

        public void Put(string hash, T data) {
            if (!memory.TryAdd(hash, data)) {
                memory[hash] = data;
            } 
        }

        public bool Del(string hash) {
            return memory.Remove(hash);
        }
        
        public T? Get(string hash) {
            if (memory.TryGetValue(hash, out T? value)) {
                return value;
            }
            else {
                return default;
            }
        }

        public void Clear() {
            memory.Clear();
        }

        public IEnumerable<KeyValuePair<string, T>> Iterator() {
            foreach (var kvp in memory.ToList()) {
                yield return kvp;
            }
        }

        public void Merge(MemoryStorage<T> storage) {
            foreach (var kvp in storage.Iterator()) {
                Put(kvp.Key, kvp.Value);
            }
        }
    }
}