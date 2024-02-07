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

        public bool Put(string hash, IPrtValue data) {
            return memory.TryAdd(hash, data);
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
        public static tMemoryStorage CreateMemoryStorage(string name, PMachine machine) {
            machine.LogLine($"Created {name}  of type {typeof(IPrtValue).Name}");
            return new tMemoryStorage(name);
        }
        
        public static tMemoryStorage PutValueInMemoryStorage(tMemoryStorage memoryStorage, string hash, IPrtValue element, PMachine machine) {
            machine.TryAssert(memoryStorage.Put(hash, element), $"Failed to add element to {memoryStorage.Name} ");
            machine.LogLine($"Put {element} in {memoryStorage.Name} ");
            return memoryStorage;
        }

        public static tMemoryStorage DeleteValueFromMemoryStorage(tMemoryStorage memoryStorage, string hash, PMachine machine) {
            machine.TryAssert(memoryStorage.Del(hash), $"Failed to delete element with key {hash} from {memoryStorage.Name} ");
            machine.LogLine($"Deleted element with key {hash} from {memoryStorage.Name} ");
            return memoryStorage;
        }

        public static IPrtValue GetValueFromMemoryStorage(tMemoryStorage memoryStorage, string hash, PMachine machine) {
            IPrtValue? value = memoryStorage.Get(hash);
            machine.TryAssert(value != null, $"{memoryStorage.Name} does not have a value for key {hash}");
            machine.LogLine($"Got value {value} from {memoryStorage.Name}");
            return value!;
        }

        public static tMemoryStorage ClearMemoryStorage(tMemoryStorage memoryStorage, PMachine machine) {
            memoryStorage.Clear();
            machine.LogLine($"Cleared all values from {memoryStorage.Name}");
            return memoryStorage;
        }

        public static PrtSet GetAllValuesFromMemoryStorage(tMemoryStorage memoryStorage, PMachine machine) {
            IPrtValue[] values = memoryStorage.All();
            PrtSet returnSet = new PrtSet();
            foreach (var value in values) {
                returnSet.Add(value);
            }
            machine.TryAssert(values.Length == returnSet.ToArray().Length, "There should not be duplicate entries in storage");
            machine.LogLine($"Got {values.Length} values from {memoryStorage.Name}");
            return returnSet;
        }
    }
}