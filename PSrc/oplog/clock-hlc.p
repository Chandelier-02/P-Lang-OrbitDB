// Safety Properties:
// - Monoticity
// **************************************************/

type tPhysicalTime;
type tHybridLogicalClock;
type tTimestamp;

type tGetLastTimestampReq = (source: machine);
type tGetLastTimestampResp = (status: tRequestStatus, lastTimestamp: tTimestamp);

type tGetNowReq = (source: machine);
type tGetNowResp = (status: tRequestStatus, now: tTimestamp, comparisonToPrevious: int);

type tUpdateHlcReq = (source: machine, remoteTs: tTimestamp);
type tUpdateHlcResp = (status: tRequestStatus, updatedTimestamp: tTimestamp, comparisonToPrevious: int);

event eGetLastTimestampReq : tGetLastTimestampReq;
event eGetLastTimestampResp : tGetLastTimestampResp;

event eGetNowReq : tGetNowReq;
event eGetNowResp : tGetNowResp;

event eUpdateHlcReq : tUpdateHlcReq;
event eUpdateHlcResp : tUpdateHlcResp;

machine HybridLogicalClock {
    var id: string;
    var hlc: tHybridLogicalClock;

    start state Active {
        entry (id: string) {
            var physicalTime: tPhysicalTime;
            var physicalTimeNow: int;
            var timestamp: tTimestamp;

            id = id;

            physicalTime = CreatePhysicalTime(0, id);
            print format("Created new Physical Time for Hybrid Logical Clock with id {0}", id);

            physicalTimeNow = GetPhysicalTimeNow(physicalTime);
            print format("Now for Hybrid Logical Clock with id {0} is {1}", id, physicalTimeNow);

            timestamp = CreateTimestamp(physicalTimeNow, 0, id);
            print format("Created timestamp {0} for Hybrid Logical Clock with id {1}", timestamp, id);

            hlc = CreateHybridLogicalClock(id, physicalTime, timestamp);
            print format("Created new Hybrid Logical Clock {0}", hlc);
        }

        on eGetLastTimestampReq do (req: tGetLastTimestampReq) {
            var lastTimestamp: tTimestamp;
            print format("Got last timestamp {0} from Hybrid Logical Clock with id {1}", lastTimestamp, id);
            send req.source, eGetLastTimestampResp, (status = SUCCESS, lastTimestamp = lastTimestamp);
        }

        on eGetNowReq do (req: tGetNowReq) {
            var previousTimestamp: tTimestamp;
            var nowResponse: (newHlc: tHybridLogicalClock, timestamp: tTimestamp);
            var extractedTimestamp: tTimestamp;
            var comparisonToPrevious: int;

            previousTimestamp = GetLastTimestamp(hlc);
            print format("Got last timestamp {0} from Hybrid Logical Clock with id {1}", previousTimestamp, id);

            nowResponse = GetHlcNow(hlc);
            print format("Now for Hybrid Logical Clock with id {0} is {1}", id, nowResponse);

            hlc = nowResponse.newHlc;
            extractedTimestamp = nowResponse.timestamp;
            comparisonToPrevious = CompareTimestamps(extractedTimestamp, previousTimestamp);
            send req.source, eGetNowResp, (status = SUCCESS, now = extractedTimestamp, comparisonToPrevious = comparisonToPrevious);
        }

        on eUpdateHlcReq do (req: tUpdateHlcReq) {
            var previousTimestamp: tTimestamp;
            var comparisonToPrevious: int;
            var updateResponse: (newHlc: tHybridLogicalClock, updatedTimestamp: tTimestamp);
            var timestamp: tTimestamp;

            previousTimestamp = GetLastTimestamp(hlc);
            print format("Got last timestamp {0} from Hybrid Logical Clock with id {1}", previousTimestamp, id);

            updateResponse = UpdateHlc(hlc, req.remoteTs);
            print format("Updated HLC with id {0} to have last timestamp: {1}", id, updateResponse.updatedTimestamp);

            hlc = updateResponse.newHlc;
            timestamp = updateResponse.updatedTimestamp;
            comparisonToPrevious = CompareTimestamps(timestamp, previousTimestamp);
            send req.source, eUpdateHlcResp, (status = SUCCESS, updatedTimestamp = timestamp, comparisonToPrevious = comparisonToPrevious);
        }
    }
}

fun CreatePhysicalTime(offset: int, id: string): tPhysicalTime;
fun GetPhysicalTimeNow(physicalTime: tPhysicalTime): int;

fun CreateTimestamp(time: int, counter: int, id: string): tTimestamp;

fun CreateHybridLogicalClock(id: string, physicalTime: tPhysicalTime, timestamp: tTimestamp): tHybridLogicalClock;
fun GetLastTimestamp(hlc: tHybridLogicalClock): tTimestamp;
fun GetHlcNow(hlc: tHybridLogicalClock): (newHlc: tHybridLogicalClock, timestamp: tTimestamp);
fun UpdateHlc(hlc: tHybridLogicalClock, remoteTs: tTimestamp): (newHlc: tHybridLogicalClock, updatedTimestamp: tTimestamp);
fun CompareTimestamps(ts1: tTimestamp, ts2: tTimestamp): int;