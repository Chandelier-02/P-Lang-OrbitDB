type tAddEntryToSyncReq = (source: machine, entryToAdd: tEntry);
type tAddEntryToSyncResp = (status: tRequestStatus);

type tUpdateLogReq = (source: machine);
type tUpdateLogResp = (status: tRequestStatus);

event eAddEntryToSyncReq : tAddEntryToSyncReq;
event eAddEntryToSyncResp : tAddEntryToSyncResp;

event eUpdateLogReq : tUpdateLogReq;
event eUpdateLogResp : tUpdateLogResp;

// Everything is pass by value, so I need to somehow update the sync's log whenever the log gets modified. GROSS. Need to modify the log to update the sync upon changes.
machine Sync {
    var peers: set[string];
    var log: Log;

    start state Init {
        entry () {
            goto Starting;
        }
    }

    state Starting {

    }

    state Started {

    }

    state Stopping {

    }

    state Stopped {

    }

    fun SendHeads(log: Log) {

    }
}