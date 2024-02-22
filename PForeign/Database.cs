using Plang.CSharpRuntime.Values;

namespace PImplementation {
    # nullable enable
    public class Database : IPrtValue {
        public Log Log { get; }
        public int ReferencesCount { get; }

        public Database(
            string identity,
            string address,
            HybridLogicalClock? clock,
            MemoryStorage<Entry>? headsStorage,
            MemoryStorage<Entry>? entryStorage,
            MemoryStorage<bool>? indexStorage,
            int referencesCount = 16
        ) {
            Log = new Log(identity, address, null, clock, entryStorage, headsStorage, indexStorage);
            ReferencesCount = referencesCount;
        }

        public Entry AddOperation(string data) {
            return Log.Append(data, ReferencesCount);
        }

        public bool ApplyOperation(Entry entry) {
            return Log.JoinEntry(entry);
        }

        public bool Equals(IPrtValue? other) {
            if (other is Database otherDatabase) {
                return otherDatabase.Log.Equals(Log);
            }
            return false;
        }

        // TODO: Verify that this is correctly cloning everything.
        public IPrtValue Clone() {
            return new Database(Log.Identity, Log.Id, Log._Clock, Log._Heads.memoryStorage, Log._Entries, Log._Index, ReferencesCount);
        }
    }
}