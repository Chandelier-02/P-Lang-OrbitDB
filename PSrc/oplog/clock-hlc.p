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
            physicalTime = CreatePhysicalTime(0);
            physicalTimeNow = GetPhysicalTimeNow(physicalTime);
            timestamp = CreateNewTimestamp(physicalTimeNow, 0, id);
            hlc = CreateHybridLogicalClock(id, physicalTime, timestamp);
        }

        on eGetLastTimestampReq do (req: tGetLastTimestampReq) {
            send req.source, eGetLastTimestampResp, (status = SUCCESS, lastTimestamp = GetLastTimestamp(hlc));
        }

        on eGetNowReq do (req: tGetNowReq) {
            var previousTimestamp: tTimestamp;
            var nowResponse: (newHlc: tHybridLogicalClock, timestamp: tTimestamp);
            var extractedTimestamp: tTimestamp;
            var comparisonToPrevious: int;
            previousTimestamp = GetLastTimestamp(hlc);
            nowResponse = GetHlcNow(hlc);
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
            updateResponse = UpdateHlc(hlc, req.remoteTs);
            hlc = updateResponse.newHlc;
            timestamp = updateResponse.updatedTimestamp;
            comparisonToPrevious = CompareTimestamps(timestamp, previousTimestamp);
            send req.source, eUpdateHlcResp, (status = SUCCESS, updatedTimestamp = timestamp, comparisonToPrevious = comparisonToPrevious);
        }
    }
}

fun CreatePhysicalTime(offset: int): tPhysicalTime;
fun GetPhysicalTimeNow(physicalTime: tPhysicalTime): int;

fun CreateNewTimestamp(time: int, counter: int, id: string): tTimestamp;

fun CreateHybridLogicalClock(id: string, physicalTime: tPhysicalTime, timestamp: tTimestamp): tHybridLogicalClock;
fun GetLastTimestamp(hlc: tHybridLogicalClock): tTimestamp;
fun GetHlcNow(hlc: tHybridLogicalClock): (newHlc: tHybridLogicalClock, timestamp: tTimestamp);
fun UpdateHlc(hlc: tHybridLogicalClock, remoteTs: tTimestamp): (newHlc: tHybridLogicalClock, updatedTimestamp: tTimestamp);
fun CompareTimestamps(ts1: tTimestamp, ts2: tTimestamp): int;