// OPLOG MACHINE
/**************************************************
Events:
- clock
- heads
- values
- get
- has
- append
- join
- joinEntry
- traverse
- getReferences

States:
- WaitForRequest

Invariants:
- No duplicate entries
- Past entries aren't modified in any way
- Log should not be modified while reading
- Log should not be read while being modified
**************************************************/
enum ShouldStopFnName {
    DEFAULT
} 

type tTraversalStopper;

type tGetClockLastStateReq = (source: machine);
type tGetClockLastStateResp = (status: tRequestStatus, lastTimestamp: tTimestamp);

type tGetHeadsFromLogReq = (source: machine);
type tGetHeadsFromLogResp = (status: tRequestStatus, heads: seq[tEntry]);

type tGetAllEntriesFromLogReq = (source: machine); // values in OrbitDB.cs
type tGetAllEntriesFromLogResp = (status: tRequestStatus, entries: seq[tEntry]);

type tGetEntryFromLogReq = (source: machine, hash: string);
type tGetEntryFromLogResp = (status: tRequestStatus, foundEntry: tEntry);

type tDoesLogHaveEntryReq = (source: machine, hash: string);
type tDoesLogHaveEntryResp = (status: tRequestStatus, hasEntry: bool);

type tAppendNewEntryToLogReq = (source: machine, entryData: string, numReferences: int);
type tAppendNewEntryToLogResp = (status: tRequestStatus, newEntry: tEntry);

type tJoinLogReq = (source: machine, log: Log);
type tJoinLogResp = (status: tRequestStatus);

type tJoinEntryReq = (source: machine, entryToJoin: tEntry);
type tJoinEntryResp = (status: tRequestStatus, couldJoin: bool);

type tTraverseLogReq = (source: machine, rootEntries: seq[tEntry], stopper: tTraversalStopper, useRefs: bool);
type tTraverseLogResp = (status: tRequestStatus, traversedEntries: seq[tEntry]);

event eGetClockLastStateReq : tGetClockLastStateReq;
event eGetClockLastStateResp : tGetClockLastStateResp;

event eGetHeadsFromLogReq : tGetHeadsFromLogReq;
event eGetHeadsFromLogResp : tGetHeadsFromLogResp;

event eGetAllEntriesFromLogReq : tGetAllEntriesFromLogReq;
event eGetAllEntriesFromLogResp : tGetAllEntriesFromLogResp;

event eGetEntryFromLogReq : tGetEntryFromLogReq;
event eGetEntryFromLogResp : tGetEntryFromLogResp;

event eDoesLogHaveEntryReq : tDoesLogHaveEntryReq;
event eDoesLogHaveEntryResp : tDoesLogHaveEntryResp;

event eAppendNewEntryToLogReq : tAppendNewEntryToLogReq;
event eAppendNewEntryToLogResp : tAppendNewEntryToLogResp;

event eJoinLogReq : tJoinLogReq;
event eJoinLogResp : tJoinLogResp;

event eJoinEntryReq : tJoinEntryReq;
event eJoinEntryResp : tJoinEntryResp;

event eTraverseLogReq : tTraverseLogReq;
event eTraverseLogResp : tTraverseLogResp;

// TODO: wherever there is an async await in JS, use the send/receive commands in this to model blocking on a single thread

machine Log {
    var identity: string;
    var logId: string;
    var clock: HybridLogicalClock;
    var entries: MemoryStorage;
    var index: MemoryStorage;
    var heads: Heads;

    start state Init {
        entry (init: (identityIn: string, logIdIn: string, logHeads: seq[tEntry])) {
            identity = init.identityIn;
            logId = init.logIdIn;
            clock = new HybridLogicalClock(identity);
            entries = new MemoryStorage("Entry Storage");
            index = new MemoryStorage("Index Storage");
            heads = new Heads(init.logHeads);
            goto WaitForRequest;
        }
    }

    state WaitForRequest {
        on eGetClockLastStateReq do (req: tGetClockLastStateReq) {
            var lastTimestamp: tTimestamp;
            lastTimestamp = GetClockLastState();
            send req.source, eGetClockLastStateResp, (status = SUCCESS, lastTimestamp = lastTimestamp);
        }
    
        on eGetHeadsFromLogReq do (req: tGetHeadsFromLogReq) {
            var heads: seq[tEntry];
            heads = GetHeadsFromLog();
            send req.source, eGetHeadsFromLogResp, (status = SUCCESS, heads = heads);
        }
    
        on eGetAllEntriesFromLogReq do (req: tGetAllEntriesFromLogReq) {
            var entries: seq[tEntry];
            var traversedEntries: seq[tEntry];
            var rootEntries: seq[tEntry];
            var dictionary: map[string, tEntry];
            var stopper: tTraversalStopper;
            var traversedEntry: tEntry;
            stopper = CreateDefaultTraversalStopper();
            rootEntries = GetHeadsFromLog();
            traversedEntries = Traverse(rootEntries, dictionary, stopper, true);
            foreach (traversedEntry in traversedEntries) {
                entries += (0, traversedEntry);
            }
            send req.source, eGetAllEntriesFromLogResp, (status = SUCCESS, entries = entries);
        }
    
        on eGetEntryFromLogReq do (req: tGetEntryFromLogReq) {
            var foundEntry: tEntry;
            send entries, eGetValueFromStorageReq, (source = this, key = req.hash);
            receive { 
                case eGetValueFromStorageResp: (resp: tGetValueFromStorageResp) {
                    if (resp.status == SUCCESS) {
                        foundEntry = resp.value as tEntry;
                        send req.source, eGetEntryFromLogResp, (status = SUCCESS, foundEntry = foundEntry);
                        goto WaitForRequest;
                    }
                    send req.source, eGetEntryFromLogResp, (status = ERROR, foundEntry = foundEntry);
                    goto WaitForRequest;
                }
            }
        }
    
        on eDoesLogHaveEntryReq do (req: tDoesLogHaveEntryReq) {
        }
    
        on eAppendNewEntryToLogReq do (req: tAppendNewEntryToLogReq) {
        }
    
        on eJoinLogReq do (req: tJoinLogReq) {
        }
    
        on eJoinEntryReq do (req: tJoinEntryReq) {
        }
    
        on eTraverseLogReq do (req: tTraverseLogReq) {
            
        }
    }

    fun GetClockLastState(): tTimestamp {
        var lastTimestamp: tTimestamp;
        send clock, eGetLastTimestampReq, (source = this, );
        receive { 
            case eGetLastTimestampResp: (resp: tGetLastTimestampResp) {
                assert resp.status == SUCCESS, "Failed to get last timestamp from clock.";
                lastTimestamp = resp.lastTimestamp;
            }
        }
        return lastTimestamp;
    }

    fun GetHeadsFromLog(): seq[tEntry] {
        var headsToReturn: seq[tEntry];
        send heads, eGetAllEntriesFromHeadsReq, (source = this, );
        receive {
            case eGetAllEntriesFromHeadsResp: (resp: tGetAllEntriesFromHeadsResp) {
                assert resp.status == SUCCESS, "Failed to get heads from log.";
                headsToReturn = Sorted(resp.retrivedValues, true);
            }
        }
        return headsToReturn;
    }

    fun GetAllEntriesFromLog() {}

    fun GetEntryFromLog(hash: string): tEntry {
        var entryToReturn: tEntry;
        send entries, eGetValueFromStorageReq, (source = this, key = hash);
        receive {
            case eGetValueFromStorageResp: (resp: tGetValueFromStorageResp) {
                assert resp.status == SUCCESS, 
                format("Failed to retrive entry with hash {0}", hash);
                entryToReturn = resp.value as tEntry;
            }
        }
        return entryToReturn;
    }

    fun LogHasEntry(hash: string): bool {
        var logHasEntry: bool;
        send index, eGetValueFromStorageReq, (source = this, key = hash);
        receive {
            case eGetValueFromStorageResp: (resp: tGetValueFromStorageResp) {
                assert resp.status == SUCCESS, 
                format("Failed to retrive entry with hash {0}", hash);
                logHasEntry = resp.value as bool;
            }
        }
        return logHasEntry;
    }

    fun AppendEntry(entryData: string, numReferences: int): tEntry {
        var logHeads: seq[tEntry];
        var itrEntry: tEntry;
        var nexts: set[string];
        var refs: set[string];
        var createdEntry: tEntry;
        var totalNumReferences: int;
        var now: tTimestamp;
        var entrySet: seq[tEntry];
        var dictionary: map[string, tEntry];

        logHeads = GetHeadsFromLog() as seq[tEntry];
        dictionary = GetDictionaryFromMemoryStorage();

        foreach (itrEntry in logHeads) {
            nexts += (GetHash(itrEntry));
        }

        totalNumReferences = numReferences + sizeof(logHeads);
        refs = GetReferences(logHeads, dictionary, totalNumReferences);

        send clock, eGetNowReq, (source = this, );
        receive {
            case eGetNowResp: (resp: tGetNowResp) {
                assert resp.status == SUCCESS, "Failed to get now from clock.";
                now = resp.now;
            }
        }
        createdEntry = CreateEntry(identity, logId, entryData, now, nexts, refs);

        entrySet += (0, createdEntry);
        send heads, eSetEntriesInHeadsReq, (source = this, entries = entrySet);
        receive {
            case eSetEntriesInHeadsResp: (resp: tSetEntriesInHeadsResp) {
                assert resp.status == SUCCESS, "Could not set entries in Heads";
            }
        }
        send entries, ePutValueInStorageReq, (source = this, key = GetHash(createdEntry), value = createdEntry);
        receive { 
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                assert resp.status == SUCCESS, "Could not put entry in Entries Storage";
            }
        }
        send index, ePutValueInStorageReq, (source = this, key = GetHash(createdEntry), value = true);
        receive {
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                assert resp.status == SUCCESS, "Could not put entry in Index Storage";
            }
        }

        return createdEntry;
    }

    fun JoinLog(log: Log) {
        var otherLogHeads: seq[tEntry];
        var otherLogEntry: tEntry;
    }

    fun JoinEntry(entryToJoin: tEntry): bool {
        var returnBool: bool;
        if (LogHasEntry(GetHash(entryToJoin)) == true) {
            return false;
        }

        send clock, eUpdateHlcReq, (source = this, remoteTs = GetClock(entryToJoin));
        receive {
            case eUpdateHlcResp: (resp: tUpdateHlcResp) {
                assert resp.status == SUCCESS, "Failed to update clock with other entry's clock";
            }
        }
        send heads, eAddEntryToHeadsReq, (source = this, headEntry = entryToJoin);
        receive { 
            case eAddEntryToHeadsResp: (resp: tAddEntryToHeadsResp) {
                assert resp.status == SUCCESS, "Failed to add entry to Heads";
                if (Sorted(resp.newHeads, true) == GetHeadsFromLog()) {
                    returnBool = false;
                }
            }
        }
        if (returnBool == false) {
            return false;
        }

        send entries, ePutValueInStorageReq, (source = this, key = GetHash(entryToJoin), value = entryToJoin);
        receive { 
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                assert resp.status == SUCCESS, "Could not put entry in Entries Storage";
            }
        }
        send index, ePutValueInStorageReq, (source = this, key = GetHash(entryToJoin), value = true);
        receive {
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                assert resp.status == SUCCESS, "Could not put entry in Index Storage";
            }
        }

        return true;
    }

    fun GetDictionaryFromMemoryStorage(): map[string, tEntry] {
        var dictionary: map[string, tEntry];
        send entries, eGetDictionaryFromMemoryStorageReq, (source = this, );
        receive {
            case eGetDictionaryFromMemoryStorageResp: (resp: tGetDictionaryFromMemoryStorageResp) {
                dictionary = resp.dictionary as map[string, tEntry];
            }
        }
        return dictionary;
    }
}

fun GetReferences(heads: seq[tEntry], entryMap: map[string, tEntry], amount: int): set[string];
fun Traverse(rootEntries: seq[tEntry], entryMap: map[string, tEntry], stopper: tTraversalStopper, useRefs: bool): seq[tEntry];
fun Sorted(entriesToSort: seq[tEntry], reverse: bool): seq[tEntry];

fun CreateDefaultTraversalStopper(): tTraversalStopper;
fun CreateGetReferencesTraversalStopper(refs: set[string], referenceCount: int): tTraversalStopper;