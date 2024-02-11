using System;
using System.Linq;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace PImplementation {
    public class tEntry : IPrtValue {
        public readonly string Identity;
        public readonly string Id;
        public readonly string Payload;
        public readonly List<string> Next;
        public readonly List<string> Refs;
        public readonly tTimestamp Clock;
        public string Hash;

        #nullable enable
        public tEntry(string identity, string id, string payload, tTimestamp clock, List<string> next, List<string> refs) {
            Identity = identity;
            Id = id;
            Payload = payload;
            Clock = clock;
            Next = next;
            Refs = refs;
            Hash = String.Empty;
        }

        #nullable enable
        public static tEntry Create(string identity, string id, string payload, tTimestamp clock, List<string> next, List<string> refs) {
            tEntry entry = new tEntry(identity, id, payload, clock, next, refs);
            entry.Hash = ToHash(entry);
            return entry;
        }

        public IPrtValue Clone() {
            return new tEntry(Identity, Id, Payload, (tTimestamp)Clock.Clone(), Next.ToList(), Refs.ToList());
        }

        public bool Equals(IPrtValue? other) {
            if (other != null && other is tEntry entry) {
                var otherEntryHash = (string)tEntry.ToHash(entry);
                return Hash == otherEntryHash;
            } else {
                return false;
            }
        }

        public static string ToHash(tEntry entry) {
            static string ComputeSha256Hash(string rawData)
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
            string serializedEntry = JsonSerializer.Serialize(entry);
            return ComputeSha256Hash(serializedEntry);
        }

        internal void Deconstruct(out string hash, out List<string> next, out List<string> refs) {
            hash = Hash;
            next = Next;
            refs = Refs;
        }

        public static string ToString(tEntry entry) {
            return $@"
                {entry.Identity}
                {entry.Id}
                {entry.Payload}
                {entry.Clock}
                {entry.Next}
                {entry.Refs}
                {entry.Hash}
            ";
        }
    }

    public static partial class GlobalFunctions {
        public static tEntry CreateEntry(string identity, string id, string entryData, tTimestamp clock, PrtSet next, PrtSet refs, PMachine _) {
            List<string> nextArray = new List<string>(next.Cast<string>());
            List<string> refsArray = new List<string>(refs.Cast<string>());
  
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
            return (PrtString)tEntry.ToHash(entry);
        }

        public static tTimestamp GetClock(tEntry entry, PMachine _) {
            return entry.Clock;
        }

        public static PrtString GetRandomString(PMachine _) {
            return (PrtString)Guid.NewGuid().ToString();
        }
    }
}