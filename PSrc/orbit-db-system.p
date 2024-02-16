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

type tPeerSubscribedReq = (source: machine, identity: string);
type tPeerSubscribedResp = (status: tRequestStatus);

type tPeerUnsubscribedReq = (source: machine, identity: string);
type tPeerUnsubscribedResp = (status: tRequestStatus);

event eAddOperationReq : tAddOperationReq;
event eAddOperationResp : tAddOperationResp;

event eApplyOperationReq : tApplyOperationReq;
event eApplyOperationResp : tApplyOperationResp;

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

                syncs += (identity);
            }

            goto NotSyncing;
        }
    }

    state NotSyncing {
        on eAddOperationReq do (req: tAddOperationReq) {
            AddOperation(req.opData, req.identity);
        }

        on eApplyOperationReq do (req: tApplyOperationReq) {
            ApplyOperation(req.opEntry, req.identity);
        }
        
        on eStartSyncReq do (req: tStartSyncReq) {
            goto StartingSync, req;
        }
        
        on eStopSyncReq do (req: tStopSyncReq) {
            
        }
        
        on eSubscribePeerReq do (req: tSubscribePeerReq) {
            
        }
        
        on eUnsubscribePeerReq do (req: tUnsubscribePeerReq) {
            
        }
    }

    state StartingSync {
        entry (req: tStartSyncReq) {
            var headsFromOtherPeersToReceive: map[string, seq[tEntry]];
            var dialingPeersKeyItr: map[string, seq[tEntry]];
            var updatedHeads: seq[tEntry];

            // Tell the sync to go to the Starting state
            send syncs[req.identity], eGotoSyncStartingReq, (source = this, );

            // Gather the heads from all peers already subscribed to the topic
            headsFromOtherPeersToReceive = getSubscribedPeersHeads();

            // Updated the peers heads using the heads from all the other already subscribed peers
            updateSubscribingPeerHeads(headsFromOtherPeersToReceive);

            // Get the subscribing peers's heads after update
            send logs[req.identity], eGetHeadsFromLogReq, (source = this, );
            receive { 
                case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                    updatedHeads = resp.heads;
                }
            }

            // Send the subscribing peer's heads to the other peers
            sendHeadsToSubscribedLogs(updatedHeads);

            goto Syncing;
        }
    }

    state Syncing {
        on eAddOperationReq do (req: tAddOperationReq) {
            AddOperation(req.opData, req.identity);
        }

        on eApplyOperationReq do (req: tApplyOperationReq) {
            ApplyOperation(req.opEntry, req.identity);
        }

        on eStopSyncReq do (req: tStopSyncReq) {
            
        }

        on ePeerSubscribedReq do (req: tPeerSubscribedReq) {
            
        }
        
        on ePeerUnsubscribedReq do (req: tPeerUnsubscribedReq) {
            
        }
    }

    fun AddOperation(opData: string, identity: string) {
        var createdEntry: tEntry;

        send logs[req.identity], eAppendNewEntryToLogReq, (source = this, entryData = req.opData, numReferences = numReferences);
        receive { 
            case eAppendNewEntryToLogResp: (resp: tAppendNewEntryToLogResp) {
                send syncs[req.identity], eAddEntryToSyncReq, (source = this, entryToAdd = resp.newEntry);
                createdEntry = resp.newEntry;
            }   
        }
        send req.source, eAddOperationResp, (source = this, hash = GetHash(createdEntry));
    }

    fun ApplyOperation(opEntry: tEntry, identity: string) {
        send logs[identity], eJoinEntryReq, (source = this, entryToJoin = opEntry);
            receive { 
                case eJoinEntryResp: (resp: tJoinEntryResp) {
                    print format("Applied operation with entry {0}", opEntry);
                }
            }
    }

    fun getSubscribedPeersHeads(): map[string, seq[tEntry]] {
        var headsFromOtherPeersToReceive: map[string, seq[tEntry]];
        var logKeysItr: string;
        foreach (logKeysItr in keys(logs)) {
            if (req.identity == logKeysItr) {
                continue;
            } else {
                send logs[logKeysItr], eGetHeadsFromLogReq, (source = this, );
                receive { 
                    case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                        headsFromOtherPeersToReceive += (logKeysItr, req.heads);
                    }
                }
            }
        }
    }

    fun updatedSubscribingPeerHeads(otherPeerHeads: map[string, seq[tEntry]]) {
        var keysItr: string;
        var entryItr: tEntry;

        foreach (keysItr in keys(otherPeerHeads)) {
            foreach (entryItr in otherLogHeads[keysItr]) {
                ApplyOperation(entryItr, keysItr);
            }

            send logs[keysItr], eGetHeadsFromLogReq, (source = this, );
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