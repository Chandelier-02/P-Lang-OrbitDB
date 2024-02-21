using System;
using System.Collections.Generic;
using System.Linq;

namespace PImplementation {
    # nullable enable
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
            List<Timestamp> timestampsToSort = new List<Timestamp> { remoteTimestamp, newTimestamp, LastTimestamp };
            timestampsToSort.Sort(new TimestampComparer());
            Timestamp winningTimestamp = timestampsToSort.Last();
            LastTimestamp = new Timestamp(winningTimestamp.Time, winningTimestamp.Counter, Id);
            return LastTimestamp;
        }
    }

    public class TimestampComparer : Comparer<Timestamp> {
        public override int Compare(Timestamp? timestamp1, Timestamp? timestamp2) {
            if (timestamp1 == null || timestamp2 == null) {
                throw new ArgumentException("Timestamps to compare cannot be null!");
            }

            if (timestamp1.Time > timestamp2.Time) {
                return 1;
            }
            if (timestamp1.Time < timestamp2.Time) {
                return -1;
            }
            if (timestamp1.Counter > timestamp2.Counter) {
                return 1;
            }
            if (timestamp1.Counter < timestamp2.Counter) {
                return -1;
            }
            return string.Compare(timestamp1.Id, timestamp2.Id);
        }
    }
}