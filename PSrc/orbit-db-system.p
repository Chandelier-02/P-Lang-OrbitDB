type tAddOperationReq = (source: machine, opData: string, dbIdentity: string);
type tAddOperationResp = (status: tRequestStatus, hash: string);

type tApplyOperationReq = (source: machine, opEntry: tEntry, dbIdentity: string);
type tApplyOperationResp = (status: tRequestStatus);

type tAddEntryToSyncReq = (source: machine, entryToAdd: tEntry, syncIdentity: string);
type tAddEntryToSyncResp = (status: tRequestStatus);

type tStartSyncReq = (source: machine, syncIdentity: string);
type tStartSyncResp = (status: tRequestStatus);

type tStopSyncReq = (source: machine, syncIdentity: string);
type tStopSyncResp = (status: tRequestStatus);

type tPeerSubscribedReq = (source: machine, syncIdentity: string);
type tPeerSubscribedResp = (status: tRequestStatus);

type tPeerUnsubscribedReq = (source: machine, syncIdentity: string);
type tPeerUnsubscribedResp = (status: tRequestStatus);

event eAddOperationReq : tAddOperationReq;
event eAddOperationResp : tAddOperationResp;

event eApplyOperationReq : tApplyOperationReq;
event eApplyOperationResp : tApplyOperationResp;

event eAddEntryToSyncReq : tAddEntryToSyncReq;
event eAddEntryToSyncResp : tAddEntryToSyncResp;

event eStartSyncReq : tStartSyncReq;
event eStartSyncResp : tStartSyncResp;

event eStopSyncReq : tStopSyncReq;
event eStopSyncResp : tStopSyncResp;

event ePeerSubscribedReq : tPeerSubscribedReq;
event ePeerSubscribedResp : tPeerSubscribedResp;

event ePeerUnsubscribedReq : tPeerUnsubscribedReq;
event ePeerUnsubscribedResp : tPeerUnsubscribedResp;

// I need to do all of the sync logic in this machine, and simply send the results to the correct machine.
machine OrbitDbSystem {
    var logs: map[string, Log];
    var syncs: map[string, Sync];

    start state Active {
        entry (init: (identities: seq[string])) {
            var numInstancesCreated: int;
            var identity: string;
            var address: string;
            var name: string;
            var clock: HybridLogicalClock;
            var entryStorage: MemoryStorage;
            var headsStorage: MemoryStorage;
            var indexStorage: MemoryStorage;
            var logHeads: seq[tEntry];

            while (numInstancesCreated < sizeof(identities)) {
                identity = identities[sizeof(identities) - 1];
                address = GetRandomString();
                name = GetRandomString();
                name = format("Database_{0}", numInstancesCreated);
                clock = new HybridLogicalClock(identity);
                entryStorage = new MemoryStorage(format("EntryStorage_{0}", numInstancesCreated));
                headsStorage = new MemoryStorage(format("HeadsStorage_{0}", numInstancesCreated));
                indexStorage = new MemoryStorage(format("IndexStorage_{0}", numInstancesCreated));

                logs += (identity, new Log((
                    identity = identity, 
                    logId = address, 
                    logHeads = logHeads,
                    clock = clock, 
                    entryStorage = entryStorage, 
                    headsStorage = headsStorage, 
                    indexStorage = indexStorage
                )));

                syncs += (identity, new Sync());
            }
        }


    }
}