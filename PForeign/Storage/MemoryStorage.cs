using System.Collections.Generic;
using System.Linq;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    public class tMemoryStorage : IPrtValue {
        public readonly string Name;
        private Dictionary<string, IPrtValue> memory = new Dictionary<string, IPrtValue>();

        public tMemoryStorage(string name) {
            Name = name;
        }

        public Dictionary<string, IPrtValue> GetDictionary() {
            return memory;
        }

        public void Put(string hash, IPrtValue data) {
            if (!memory.TryAdd(hash, data)) {
                memory[hash] = data;
            } 
        }

        public bool Del(string hash) {
            return memory.Remove(hash);
        }
        
        #nullable enable
        public IPrtValue? Get(string hash) {
            if (memory.TryGetValue(hash, out IPrtValue? value))
            {
                return value;
            }
            else
            {
                return default;
            }
        }

        public void Clear() {
            memory.Clear();
        }

        public IPrtValue[] All() {
            return memory.Values.ToArray();
        }

        public void MergeEntries(tMemoryStorage storage) {
            memory = (Dictionary<string, IPrtValue>)memory.Concat(storage.memory);
        }

        public IPrtValue Clone() {
            tMemoryStorage clonedStorage = new tMemoryStorage(Name);
            foreach(var kvp in memory.ToArray()) {
                clonedStorage.Put(kvp.Key, kvp.Value);
            }
            return clonedStorage;
        }

        public bool Equals(IPrtValue? other) {
            if (other is tMemoryStorage otherMemoryStorage) {
                if (otherMemoryStorage.memory.Keys == memory.Keys && 
                    otherMemoryStorage.memory.Values == memory.Values && 
                    otherMemoryStorage.Name == Name
                ) {
                    return true;
                }
                return false;
            }
            return false;
        }
    }

    public static partial class GlobalFunctions {
        public static tMemoryStorage CreateMemoryStorage(string name, PMachine _) {
            return new tMemoryStorage(name);
        }
        
        public static tMemoryStorage PutValueInMemoryStorage(tMemoryStorage memoryStorage, string hash, IPrtValue element, PMachine _) {
            memoryStorage.Put(hash, element);
            return memoryStorage;
        }

        public static PrtNamedTuple DeleteValueFromMemoryStorage(tMemoryStorage memoryStorage, string hash, PMachine _) {
            bool couldDelete = memoryStorage.Del(hash);
            return new PrtNamedTuple(new string[]{ "couldDelete", "memoryStorage" }, (PrtBool)couldDelete, memoryStorage);
        }

        public static IPrtValue GetValueFromMemoryStorage(tMemoryStorage memoryStorage, string hash, PMachine _) {
            IPrtValue? value = memoryStorage.Get(hash);
            if (value == null) {
                return (PrtBool)false;
            }
            return value;
        }

        public static tMemoryStorage ClearMemoryStorage(tMemoryStorage memoryStorage, PMachine _) {
            memoryStorage.Clear();
            return memoryStorage;
        }

        public static PrtSeq GetAllValuesFromMemoryStorage(tMemoryStorage memoryStorage, PMachine machine) {
            IPrtValue[] values = memoryStorage.All();
            PrtSeq returnSet = new PrtSeq();
            foreach (var value in values) {
                returnSet.Add(value);
            }
            machine.TryAssert(values.Length == returnSet.ToArray().Length, "There should not be duplicate entries in storage");
            return returnSet;
        }

        public static PrtMap GetDictionaryFromMemoryStorage(tMemoryStorage memoryStorage, PMachine _) {
            PrtMap map = new PrtMap();
            foreach (var kvp in memoryStorage.GetDictionary()) {
                string key = kvp.Key;
                IPrtValue value = kvp.Value;
                map.Add(new KeyValuePair<IPrtValue, IPrtValue>((PrtString)key, value));
            }
            return map;
        }
    }
}