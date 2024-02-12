using System;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    public class tPhysicalTime : IPrtValue {
        public int Offset { set; get; }

        public tPhysicalTime(int offset) {
            Offset = offset;
        }

        public long Now() {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + Offset;
        }

        public IPrtValue Clone() {
            return new tPhysicalTime(Offset);
        }

        public bool Equals(IPrtValue other) {
            if (other is tPhysicalTime otherPhysicalTime) {
                return otherPhysicalTime.Offset == Offset;
            } else {
                return false;
            }
        }
    }

    public class tTimestamp : IPrtValue {
        public readonly long Time;
        public int Counter;
        public readonly string Id;

        public tTimestamp(long time, int counter, string id) {
            Time = time;
            Counter = counter;
            Id = id;
        }

        public IPrtValue Clone() {
            return new tTimestamp(Time, Counter, Id);
        } 

        public bool Equals(IPrtValue other) {
            if (other is tTimestamp otherTimestamp) {
                return otherTimestamp.Time == Time && otherTimestamp.Counter == Counter && otherTimestamp.Id == Id;
            } else {
                return false;
            }
        }

        public override string ToString()
        {
            return 
            $@"
                Id: {Id}
                Time: {Time}
                Counter: {Counter}
            ";
        }
    }

    public class tHybridLogicalClock: IPrtValue {
        // private readonly float WARNoffset = 3e4f;
        // private readonly float ERRORoffset = 6e4f;
        // private readonly float WARN_JUMP = 5e3f;
        // private readonly float ERROR_JUMP = 1e4f;

        public readonly string Id;
        public readonly tPhysicalTime PhysicalTime;
        public tTimestamp LastTimestamp;

        #nullable enable
        public tHybridLogicalClock(string id, tPhysicalTime? physicalTime, tTimestamp? pTimestamp) {
            Id = id;
            PhysicalTime = physicalTime ?? new tPhysicalTime(0);
            LastTimestamp = pTimestamp ?? new tTimestamp(PhysicalTime.Now(), 0, id);
        }

        public tTimestamp Last() {
            return LastTimestamp;
        }

        public tTimestamp Now() {
            long physNow = PhysicalTime.Now();
            if (physNow > LastTimestamp.Time) {
                LastTimestamp = new tTimestamp(physNow, 0, Id);
            } else {
                LastTimestamp.Counter += 1;
            }

            return LastTimestamp;
        }

        public tTimestamp New() {
            return new tTimestamp(PhysicalTime.Now(), 0, Id);
        }

        // TODO: Add error handling here.
        public tTimestamp Update(tTimestamp remoteTimestamp) {
            tTimestamp newTimestamp = New();
            tTimestamp[] timestampsToSort = new tTimestamp[] { remoteTimestamp, newTimestamp, LastTimestamp };
            Array.Sort(timestampsToSort, CompareTimestamps);
            tTimestamp winningTimestamp = timestampsToSort[^1];
            LastTimestamp = new tTimestamp(winningTimestamp.Time, winningTimestamp.Counter, Id);
            return LastTimestamp;
        }

        public IPrtValue Clone() {
            return new tHybridLogicalClock(Id, (tPhysicalTime)PhysicalTime.Clone(), (tTimestamp)LastTimestamp.Clone());
        }

        public bool Equals(IPrtValue? other) {
            if (other is tHybridLogicalClock otherHybridLogicalClock) {
                return Id == otherHybridLogicalClock.Id && PhysicalTime.Equals(otherHybridLogicalClock.PhysicalTime)
                                                        && LastTimestamp.Equals(otherHybridLogicalClock.LastTimestamp); 
            } else {
                return false;
            }
        }

        public static int CompareTimestamps(tTimestamp timestamp1, tTimestamp timestamp2) {
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

        public override string ToString()
        {
            return $@"
                Id: {Id}
                Last Timestamp: {LastTimestamp}
            ";
        }
    }

    public static partial class GlobalFunctions {
        public static tPhysicalTime CreatePhysicalTime(int offset, string id, PMachine _) {
            return new tPhysicalTime(offset);
        }

        public static long GetPhysicalTimeNow(tPhysicalTime physicalTime, PMachine _) {
            long now = physicalTime.Now();
            return now;
        }

        public static tTimestamp CreateTimestamp(long time, int counter, string id, PMachine _) {
            tTimestamp newTimestamp = new tTimestamp(time, counter, id);
            return newTimestamp;
        }

        public static tHybridLogicalClock CreateHybridLogicalClock(string id, tPhysicalTime physicalTime, tTimestamp timestamp, PMachine _) {
            tHybridLogicalClock hlc = new tHybridLogicalClock(id, physicalTime, timestamp);
            return hlc;
        }

        public static tTimestamp GetLastTimestamp(tHybridLogicalClock hlc, PMachine _) {
            tTimestamp last = hlc.Last();
            return hlc.Last();
        }

        public static PrtNamedTuple GetHlcNow(tHybridLogicalClock hlc, PMachine _) {
            tTimestamp now = hlc.Now();
            return new PrtNamedTuple(new string[]{ "newHlc", "timestamp" }, hlc, now);
        }

        public static PrtNamedTuple UpdateHlc(tHybridLogicalClock hlc, tTimestamp remoteTs, PMachine _) {
            tTimestamp updatedTimestamp = hlc.Update(remoteTs);
            return new PrtNamedTuple(new string[]{ "newHlc", "updatedTimestamp" }, hlc, updatedTimestamp);
        }

        public static int CompareTimestamps(tTimestamp ts1, tTimestamp ts2, PMachine _) {
            return tHybridLogicalClock.CompareTimestamps(ts1, ts2);
        }
    }
}