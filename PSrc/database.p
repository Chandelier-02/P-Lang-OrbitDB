// type tAddOperationReq = (source: machine, opData: string);
// type tAddOperationResp = (status: tRequestStatus, hash: string);

// type tApplyOperationReq = (source: machine, opEntry: tEntry);
// type tApplyOperationResp = (status: tRequestStatus);

// event eAddOperationReq : tAddOperationReq;
// event eAddOperationResp : tAddOperationResp;

// event eApplyOperationReq : tApplyOperationReq;
// event eApplyOperationResp : tApplyOperationResp;

// machine Database {
//     var log: Log;
//     var sync: Sync;
//     var identity: string;
//     var address: string;
//     var name: string;
//     var referenceCount: int;

//     start state Init {
//         entry (init: (
//             identity: string, 
//             address: string, 
//             name: string, 
//             clock: HybridLogicalClock, 
//             entryStorage: MemoryStorage, 
//             headsStorage: MemoryStorage, 
//             indexStorage: MemoryStorage,
//             referenceCount: int
//         )) {
//             var logHeads: seq[tEntry];

//             identity = init.identity;
//             address = init.address;
//             name = init.name;
//             referenceCount = referenceCount;
//             log = new Log((
//                 identity = identity, 
//                 logId = address, 
//                 logHeads = logHeads,
//                 clock = init.clock, 
//                 entryStorage = init.entryStorage, 
//                 headsStorage = init.headsStorage, 
//                 indexStorage = init.indexStorage
//             ));
//             sync = new Sync();

//             goto WaitForRequest;
//         }
//     }

//     state WaitForRequest {
//         on eAddOperationReq do (req: tAddOperationReq) {
//             goto AddingOperation, req;
//         }

//         on eApplyOperationReq do (req: tApplyOperationReq) {
//             goto ApplyingOperation, req;
//         }
//     }

//     state AddingOperation {
//         entry (req: tAddOperationReq) {
//             var appendedEntry: tEntry;
//             send log, eAppendNewEntryToLogReq, (source = this, entryData = req.opData, numReferences = referenceCount);
//             receive { 
//                 case eAppendNewEntryToLogResp: (resp: tAppendNewEntryToLogResp) {
//                     appendedEntry = resp.newEntry;
//                 }
//             }
//             send sync, eAddEntryToSyncReq, (source = this, entryToAdd = appendedEntry);
//             receive { 
//                 case eAddEntryToSyncResp: (resp: tAddEntryToSyncResp) {
//                     print format("Added entry {0} to the Sync", appendedEntry);
//                 }
//             }
//             send req.source, eAddOperationResp, (status = SUCCESS, hash = GetHash(appendedEntry));
//         }
//     }

//     state ApplyingOperation {
//         entry (req: tApplyOperationReq) {
//             send log, eJoinEntryReq, (source = this, entryToJoin = req.opEntry);
//             receive {
//                 case eJoinEntryResp: (resp: tJoinEntryResp) {
//                     print format("Joined entry {0} to the log", req.opEntry);
//                 }
//             }
//             send req.source, eApplyOperationResp, (status = SUCCESS, );
//         }
//     }
// }