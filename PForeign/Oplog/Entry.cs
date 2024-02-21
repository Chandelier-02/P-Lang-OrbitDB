using System;
using System.Linq;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;

namespace PImplementation {
    public class tEntry : IPrtValue {
        public readonly string Identity;
        public readonly string Id;
        public readonly string Payload;
        public readonly List<string> Next;
        public readonly List<string> Refs;
        public readonly tTimestamp Clock;
        public readonly string Hash;

        #nullable enable
        public tEntry(string identity, string id, string payload, tTimestamp clock, List<string> next, List<string> refs) {
            Identity = identity;
            Id = id;
            Payload = payload;
            Clock = clock;
            Next = next;
            Refs = refs;
            Hash = HashPayload(payload); // Hashing the payload only due to weird hashing issues
        }

        #nullable enable
        public static tEntry Create(string identity, string id, string payload, tTimestamp clock, List<string> next, List<string> refs) {
            tEntry entry = new tEntry(identity, id, payload, clock, next, refs);
            return entry;
        }

        public IPrtValue Clone() {
            return new tEntry(Identity, Id, Payload, (tTimestamp)Clock.Clone(), Next.ToList(), Refs.ToList());
        }

        public bool Equals(IPrtValue? other) {
            if (other != null && other is tEntry entry) {
                var otherEntryHash = entry.Hash;
                return Hash == otherEntryHash;
            } else {
                return false;
            }
        }

        public static string HashPayload(string stringToHash) {
            string ComputeSha256Hash(string rawData)
            {
                using SHA256 sha256Hash = SHA256.Create();
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
            return ComputeSha256Hash(stringToHash);
        }

        internal void Deconstruct(out string hash, out List<string> next, out List<string> refs) {
            hash = Hash;
            next = Next;
            refs = Refs;
        }

        public override string ToString() {
            return $@"
                Identity: {Identity}
                Id: {Id}
                Payload: {Payload}

                Clock: {Clock}

                Nexts: {String.Join("\n\t", Next)}
                Refs: {String.Join("\n\t", Refs)}
                Hash: {Hash}
            ";
        }
    }

    public static partial class GlobalFunctions {
        public static tEntry CreateEntry(string identity, string id, string entryData, tTimestamp clock, PrtSet next, PrtSet refs, PMachine _) {
            List<string> nextArray = new List<string>(next.Select(i => i.ToString())!);
            List<string> refsArray = new List<string>(refs.Select(i => i.ToString())!);
  
            var createdEntry = tEntry.Create(
                identity,
                id, 
                entryData,
                clock,
                nextArray,
                refsArray
            );

            return createdEntry;
        }

        public static PrtString GetHash(tEntry entry, PMachine _) {
            return (PrtString)entry.Hash;
        }

        public static tTimestamp GetClock(tEntry entry, PMachine _) {
            return entry.Clock;
        }

        public static PrtString GetRandomString(PMachine _) {
            return (PrtString)Guid.NewGuid().ToString();
        }
    }

    public struct PhysicalTime {
        public int Offset { set; get; }
        public long Now { get => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + Offset; }

        public PhysicalTime(int offset) {
            Offset = offset;
        }
    }

    public class Timestamp {
        public long Time { get; }
        public string Id { get; }
        public int Counter { set; get; }

        public Timestamp(long time, int counter, string id) {
            Time = time;
            Counter = counter;
            Id = id;
        }
    }

    public class HybridLogicalClock {
        public string Id { get; }
        public PhysicalTime PhysicalTime { get; }
        public Timestamp LastTimestamp { set; get; }
        public HybridLogicalClock(string id, PhysicalTime? physicalTime = null) {
            Id = id;
            PhysicalTime = physicalTime ?? new PhysicalTime(0);
            LastTimestamp = new Timestamp(PhysicalTime.Now, 0, Id);
        }

        public Timestamp Now() {
            long physNow = PhysicalTime.Now;
            if (physNow > LastTimestamp.Time) {
                LastTimestamp = new Timestamp(physNow, 0, Id);
            } else {
                LastTimestamp.Counter += 1;
            }

            return LastTimestamp;
        }

        public Timestamp New() {
            return new Timestamp(PhysicalTime.Now, 0, Id);
        }

        public Timestamp Update(Timestamp remoteTimestamp) {
            Timestamp newTimestamp = New();
            Timestamp[] timestampsToSort = new Timestamp[] { remoteTimestamp, newTimestamp, LastTimestamp };
            Array.Sort(timestampsToSort, CompareTimestamps);
            Timestamp winningTimestamp = timestampsToSort[^1];
            LastTimestamp = new Timestamp(winningTimestamp.Time, winningTimestamp.Counter, Id);
            return LastTimestamp;
        }
    }

    public readonly struct Entry {
        readonly string Id { get; }
        readonly string Payload { get; }
        readonly List<string> Next { get; }
        readonly List<string> Refs { get; }
        readonly Timestamp Clock { get; }
        readonly string Identity { get; }

        public Entry(string identity, string id, string payload, Timestamp? clock = null, List<string>? next = null, List<string>? refs = null) {
            clock = clock || new HybridLogicalClock(identity).
        }
    }
}