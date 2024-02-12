type tAddOperationReq = (source: machine, opData: string);
type tAddOperationResp = (status: tRequestStatus, hash: string);

type tApplyOperationReq = (source: machine, opEntry: tEntry);
type tApplyOperationResp = (status: tRequestStatus);

machine Database {
    var log: Log;
    var sync: Sync;
    var identity: string;
    var address: string;
    var name: string;
    var referenceCount: int;

    start state Init {
        entry (init: (
            identity: string, 
            address: string, 
            name: string, 
            clock: HybridLogicalClock, 
            entryStorage: MemoryStorage, 
            headsStorage: MemoryStorage, 
            indexStorage: MemoryStorage,
            referenceCount: int
        )) {
            var logHeads: seq[tEntry];

            identity = init.identity;
            address = init.address;
            name = init.name;
            referenceCount = referenceCount;
            log = new Log((
                identity = identity, 
                logId = address, 
                logHeads = logHeads,
                clock = init.clock, 
                entryStorage = init.entryStorage, 
                headsStorage = init.headsStorage, 
                indexStorage = init.indexStorage
            ));
            sync = new Sync();
        }
    }

    state AddingOperation {

    }

    state ApplyingOperation {

    }
}