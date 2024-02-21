using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PImplementation {
    public readonly struct Entry {
        public readonly string Id { get; }
        public readonly string Payload { get; }
        public readonly List<string> Next { get; }
        public readonly List<string> Refs { get; }
        public readonly Timestamp Clock { get; }
        public readonly string Identity { get; }
        public readonly string Hash { get; }

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

        private string GenerateHash() {
            string toBeHashed = $"{Identity}{Id}{Payload}{string.Join("", Next.OrderBy(n => n))}{string.Join("", Refs.OrderBy(r => r))}";

            using (SHA256 sha256Hash = SHA256.Create()) {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(toBeHashed));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public override bool Equals(object? obj) {
            if (obj is Entry other) {
                return Hash == other.Hash;
            }
            return false;
        }

        public override int GetHashCode() {
            return Hash.GetHashCode();
        }

        public static bool operator ==(Entry a, Entry b) => a.Hash == b.Hash; 
        public static bool operator !=(Entry a, Entry b) => a.Hash != b.Hash;
    }
}