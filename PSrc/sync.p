type tQueue;

type tGotoSyncStartingReq = (source: machine);
type tGotoSyncStartingResp = (status: tRequestStatus);

type tGotoSyncStartedReq = (source: machine);
type tGotoSyncStartedResp = (status: tRequestStatus);

machine Sync {
    var identity: string;

    start state Stopped {
        entry (identity: string) {
            identity = identity;
        }

        on eGotoSyncStartingReq do (req: tGotoSyncStartingReq) {
            goto Starting;
        }
    }

    state Starting {
        on eGotoSyncStartedReq do (req: tGotoSyncStartedReq) {
            goto Started;
        }
    }

    state Started {
        on eSubscribePeerFromSystemReq do (req: tSubscribePeerFromSystemReq) {
            handlePeerSubscribed();
        }

        on ePeerUnsubscribedReq do (req: tPeerUnsubscribedReq) {

        }

        on eHandleUpdateFromPeerReq do (req: tHandleUpdateFromPeerReq) {

        }

        on eStopSyncReq do (req: tStopSyncReq) {

        }

        on eUpdateSyncLogFromDatabaseReq do (req: tUpdateDatabaseLogFromSyncReq) {

        }
    }
}