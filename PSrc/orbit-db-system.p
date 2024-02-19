type tAddOperationReq = (source: machine, opData: string, identity: string);
type tAddOperationResp = (status: tRequestStatus, hash: string);

type tApplyOperationReq = (source: machine, opEntry: tEntry, identity: string);
type tApplyOperationResp = (status: tRequestStatus);

type tAddEntryToSyncReq = (source: machine, entryToAdd: tEntry, identity: string);
type tAddEntryToSyncResp = (status: tRequestStatus);

type tStartSyncReq = (source: machine, identity: string);
type tStartSyncResp = (status: tRequestStatus);

type tStopSyncReq = (source: machine, identity: string);
type tStopSyncResp = (status: tRequestStatus);

// type tSubscribePeerReq = (source: machine, identity: string);
// type tSubscribePeerResp = (status: tRequestStatus);

// type tUnsubscribePeerReq = (source: machine, identity: string);
// type tUnsubscribePeerResp = (status: tRequestStatus);

event eAddOperationReq : tAddOperationReq;
event eAddOperationResp : tAddOperationResp;

event eApplyOperationReq : tApplyOperationReq;
event eApplyOperationResp : tApplyOperationResp;

event eStartSyncReq : tStartSyncReq;
event eStartSyncResp : tStartSyncResp;

event eStopSyncReq : tStopSyncReq;
event eStopSyncResp : tStopSyncResp;

// event eSubscribePeerReq : tSubscribePeerReq;
// event eSubscribePeerResp : tSubscribePeerResp;

// event eUnsubscribePeerReq : tUnsubscribePeerReq;
// event eUnsubscribePeerResp : tUnsubscribePeerResp;

// I need to do all of the sync logic in this machine, and simply send the results to the correct machine.
// Need to have one state for this machine. Need to have some sort of state management within the Sync itself.
// Assumption: log received and sends updated heads on startup in an iterative manner
// StartSync and StopSync also handle subscribe and unsubscribe stuff
machine OrbitDbSystem {
    var logs: map[string, Log];
    var allSyncs: set[string];
    var activeSyncs: set[string];
    var numReferences: int;

    start state Init {
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

            numReferences = 16;

            while (numInstancesCreated < sizeof(init.identities)) {
                identity = init.identities[sizeof(init.identities) - 1];
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

                allSyncs += (identity);
            }
        }

        on eAddOperationReq do (req: tAddOperationReq) {
            AddOperation(req.opData, req.identity, req.source);
        }

        on eApplyOperationReq do (req: tApplyOperationReq) {
            ApplyOperation(req.opEntry, req.identity);
        }

        on eStartSyncReq do (req: tStartSyncReq) {
            if (req.identity in activeSyncs) {
                print format("Sync {0} already started!", req.identity);
                return;
            }
            StartSync(req);
            activeSyncs += (req.identity);
        }
        
        on eStopSyncReq do (req: tStopSyncReq) {
            if (!(req.identity in activeSyncs)) {
                print format("Sync {0} already stopped!", req.identity);
                return;
            }
            // StopSync(req);
            activeSyncs -= (req.identity);
        }
    }

    fun StartSync(req: tStartSyncReq) {
        var headsFromOtherPeersToReceive: map[string, seq[tEntry]];
        var dialingPeersKeyItr: map[string, seq[tEntry]];
        var updatedHeads: seq[tEntry];

        // send syncs[req.identity], eGotoSyncStartingReq, (source = this, );

        headsFromOtherPeersToReceive = getSubscribedPeersHeads(req.identity);

        updateSubscribingPeerHeads(headsFromOtherPeersToReceive);

        send logs[req.identity], eGetHeadsFromLogReq, (source = this, );
        receive { 
            case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                updatedHeads = resp.heads;
            }
        }

        sendHeadsToSubscribedLogs(req.identity, updatedHeads);
    }

    fun AddOperation(opData: string, identity: string, source: machine) {
        var createdEntry: tEntry;
        var activeSyncItr: string;

        send logs[identity], eAppendNewEntryToLogReq, (source = this, entryData = opData, numReferences = numReferences);
        receive { 
            case eAppendNewEntryToLogResp: (resp: tAppendNewEntryToLogResp) {
                createdEntry = resp.newEntry;
            }   
        }
        send source, eAddOperationResp, (status = SUCCESS, hash = GetHash(createdEntry));

        // Propogate the newly created entry to subscibed logs
        foreach (activeSyncItr in activeSyncs) {
            if (activeSyncItr != identity) {
                ApplyOperation(createdEntry, activeSyncItr);
            }
        }
    }

    fun ApplyOperation(opEntry: tEntry, identity: string) {
        send logs[identity], eJoinEntryReq, (source = this, entryToJoin = opEntry);
            receive { 
                case eJoinEntryResp: (resp: tJoinEntryResp) {
                    print format("Applied operation with entry {0}", opEntry);
                }
            }
    }

    fun getSubscribedPeersHeads(identity: string): map[string, seq[tEntry]] {
        var headsFromOtherPeersToReceive: map[string, seq[tEntry]];
        var logKeysItr: string;
        foreach (logKeysItr in keys(logs)) {
            if (identity == logKeysItr) {
                continue;
            } else {
                send logs[logKeysItr], eGetHeadsFromLogReq, (source = this, );
                receive { 
                    case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                        headsFromOtherPeersToReceive += (logKeysItr, resp.heads);
                    }
                }
            }
        }
        return headsFromOtherPeersToReceive;
    }

    fun updateSubscribingPeerHeads(otherPeerHeads: map[string, seq[tEntry]]) {
        var keysItr: string;
        var entryItr: tEntry;
        var otherLogHeads: seq[tEntry];

        foreach (keysItr in keys(otherPeerHeads)) {
            send logs[keysItr], eGetHeadsFromLogReq, (source = this, );
            receive { 
                case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                    otherLogHeads = resp.heads;
                }
            }
            foreach (entryItr in otherLogHeads) {
                ApplyOperation(entryItr, keysItr);
            }
            
        }
    }

    fun receiveUpdatedHeadsFromSubscribingPeer(subscribingPeerId: string, subscribingPeerHeads: seq[tEntry]) {
        var entryItr: tEntry;

        foreach (entryItr in subscribingPeerHeads) {
            ApplyOperation(entryItr, subscribingPeerId);
        }
    }

    fun sendHeadsToSubscribedLogs(peerIdentity: string, heads: seq[tEntry]) {
        var keyItr: string;
        var entryItr: tEntry;

        foreach (keyItr in keys(logs)) {
            if (keyItr == peerIdentity) {
                continue;
            } else {
                foreach (entryItr in heads) {
                    ApplyOperation(entryItr, peerIdentity);
                }
            }
        }
    }
}