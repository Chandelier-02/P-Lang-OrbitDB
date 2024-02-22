using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    public class Entry : IPrtValue {
        public string Id { get; }
        public string Payload { get; }
        public List<string> Next { get; }
        public List<string> Refs { get; }
        public Timestamp Clock { get; }
        public string Identity { get; }
        public string Hash { get; }

        # nullable enable
        public Entry(string identity, string id, string payload, Timestamp? clock = null, List<string>? next = null, List<string>? refs = null) {
            Identity = identity;
            Id = id;
            Payload = payload;
            Clock = clock ?? new HybridLogicalClock(identity).Now();
            Next = next ?? new List<string>();
            Refs = refs ?? new List<string>();
            Hash = GenerateHash();
        }

        public bool Equals(IPrtValue? other) {
            if (other is Entry otherEntry) {
                return otherEntry.Hash == Hash;
            }
            return false;
        }

        public IPrtValue Clone() {
            return new Entry(Identity, Id, Payload, Clock, Next, Refs);
        }

        public override string ToString()
        {
            return @$"
            Identity: {Identity}
            Id: {Id}
            Payload: {Payload}
            Clock: {Clock}
            Next: {Next}
            Refs: {Refs}
            ";
        }

        private string GenerateHash() {
            string toBeHashed = $"{Identity}{Id}{Payload}{string.Join("", Next.OrderBy(n => n))}{string.Join("", Refs.OrderBy(r => r))}{Clock}";

            using (SHA256 sha256Hash = SHA256.Create()) {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(toBeHashed));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}