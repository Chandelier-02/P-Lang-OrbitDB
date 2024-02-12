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
}