type tAddEntryToSyncReq = (source: machine, entryToAdd: tEntry);
type tAddEntryToSyncResp = (status: tRequestStatus);

type tUpdateSyncLogFromDatabaseReq = (source: machine);
type tUpdateSyncLogFromDatabaseResp = (status: tRequestStatus);

type tUpdateDatabaseLogFromSyncReq = (source: machine, updatedLog: Log);
type tUpdateDatabaseLogFromSyncResp = (status: tRequestStatus);

type tGetOtherSyncStreamReq = (source: machine);
type tGetOtherSyncStreamResp = (status: tRequestStatus, otherSyncStream: seq[tEntry]);

type tStartSyncReq = (source: machine);
type tStartSyncResp = (status: tRequestStatus);

type tStopSyncReq = (source: machine);
type tStopSyncResp = (status: tRequestStatus);

type tReceiveHeadsFromSelfReq = (source: machine, headsToReceive: seq[tEntry]);
type tReceiveHeadsFromSelfResp = (status: tRequestStatus);

event eAddEntryToSyncReq : tAddEntryToSyncReq;
event eAddEntryToSyncResp : tAddEntryToSyncResp;

event eUpdateSyncLogFromDatabaseReq : tUpdateSyncLogFromDatabaseReq;
event eUpdateSyncLogFromDatabaseResp : tUpdateSyncLogFromDatabaseResp;

event eUpdateDatabaseLogFromSyncReq : tUpdateDatabaseLogFromSyncReq;
event eUpdateDatabaseLogFromSyncResp : tUpdateDatabaseLogFromSyncResp;

event eGetOtherSyncStreamReq : tGetOtherSyncStreamReq;
event eGetOtherSyncStreamResp : tGetOtherSyncStreamResp;

event eStartSyncReq : tStartSyncReq;
event eStartSyncResp : tStartSyncResp;

event eStopSyncReq : tStopSyncReq;
event eStopSyncResp : tStopSyncResp;

event eReceiveHeadsFromSelfReq : tReceiveHeadsFromSelfReq;
event eReceiveHeadsFromSelfResp : tReceiveHeadsFromSelfResp;

type tQueue;

// Everything is pass by value, so I need to somehow update the sync's log whenever the log gets modified. GROSS. Need to modify the log to update the sync upon changes.
// The sync's view of the log can also get changed, so that is rather gross.
machine Sync {
    var peers: map[string, Sync];
    var log: Log;
    var ipfsStreamMock: seq[tEntry];
    var name: string;
    var eventQueue: tQueue;

    start state Stopped {
        on eStartSyncReq do (req: tStartSyncReq) {
            goto Starting, req;
        }
    }

    state Starting {
        entry (req: tStartSyncReq) {
            handleReceiveHeads(req.source);
            goto Started;
        }
    }

    state Started {
        on eNewPeerSubscribedReq do (req: tNewPeerSubscribedReq) {

        }

        on eHandlePeerUpdateReq do (req: tHandlePeerUpdateReq) {

        }

        on eStopSyncReq do (req: tStopSyncReq) {

        }

        on eUpdateSyncLogFromDatabaseReq do (req: tUpdateDatabaseLogFromSyncReq) {
            
        }
    }

    state Stopping {

    }

    fun sendHeads(): seq[tEntry] {
        var heads: seq[tEntry];

        send log, eGetHeadsFromLogReq, (source = this, );
        receive { 
            case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                heads = resp.heads;
            }
        }
        return heads;
    }

    fun receiveHeads(peerId: string, source: seq[tEntry], database: machine) {
        var sourceItr: tEntry;

        foreach (sourceItr in source) {
            send database, eApplyOperationReq, (source = this, opEntry = sourceItr);
            receive {
                case eApplyOperationResp: (resp: tApplyOperationResp) {
                    print format("Successfully received head {0} from peer {1}", sourceItr, peerId);
                }
            }
        }

        send database, eUpdateDatabaseLogFromSyncReq, (source = this, updatedLog = log);
        receive {
            case eUpdateDatabaseLogFromSyncResp: (resp: tUpdateDatabaseLogFromSyncResp) {
                print format("Updated database log to be consistent with sync log");
            }
        }
    }

    fun handleReceiveHeads(database: machine) {
        var peerKeyItr: string;
        var otherPeerStream: seq[tEntry];
        var updatedStream: seq[tEntry];

        foreach (peerKeyItr in keys(peers)) {
            send peers[peerKeyItr], eGetOtherSyncStreamReq, (source = this, );
            receive {
                case eGetOtherSyncStreamResp: (resp: tGetOtherSyncStreamResp) {
                    otherPeerStream = resp.otherSyncStream;
                }
            }
            receiveHeads(peerKeyItr, otherPeerStream, database);
            updatedStream = sendHeads();

            send peers[peerKeyItr], eReceiveHeadsFromSelfReq, (source = this, headsToReceive = updatedStream);
            receive { 
                case eReceiveHeadsFromSelfResp: (resp: tReceiveHeadsFromSelfResp) {
                    print format("Peer {0} received heads from peer {1}", name, peerKeyItr);
                }
            }
        }
    }
}