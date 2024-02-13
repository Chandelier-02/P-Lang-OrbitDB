type tAddEntryToSyncReq = (source: machine, entryToAdd: tEntry);
type tAddEntryToSyncResp = (status: tRequestStatus);

event eAddEntryToSyncReq : tAddEntryToSyncReq;
event eAddEntryToSyncResp : tAddEntryToSyncResp;

machine Sync {
    var peers: set[string];

    start state Init {
        entry {
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
}