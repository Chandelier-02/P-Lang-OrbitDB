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
type tTraversalStopper;

type tGetClockLastStateReq = (source: machine);
type tGetClockLastStateResp = (status: tRequestStatus, lastTimestamp: tTimestamp);

type tGetHeadsFromLogReq = (source: machine);
type tGetHeadsFromLogResp = (status: tRequestStatus, heads: seq[tEntry]);

type tGetAllEntriesFromLogReq = (source: machine); // values in OrbitDB.cs
type tGetAllEntriesFromLogResp = (status: tRequestStatus, entries: seq[tEntry]);

type tGetEntryFromLogReq = (source: machine, hash: string);
type tGetEntryFromLogResp = (status: tRequestStatus, foundValue: any);

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
            entries = GetAllEntriesFromLog();
            send req.source, eGetAllEntriesFromLogResp, (status = SUCCESS, entries = entries);
        }
    
        on eGetEntryFromLogReq do (req: tGetEntryFromLogReq) {
            var value: any;
            value = GetEntryFromLog(req.hash);
            if (value == false) {
                send req.source, eGetEntryFromLogResp, (status = ERROR, foundValue = value);
                goto WaitForRequest;
            }
            send req.source, eGetEntryFromLogResp, (status = SUCCESS, foundValue = value);
            goto WaitForRequest;
        }
    
        on eDoesLogHaveEntryReq do (req: tDoesLogHaveEntryReq) {
            var hasEntry: bool;
            hasEntry = LogHasEntry(req.hash);
            if (hasEntry == true) {
                send req.source, eDoesLogHaveEntryResp, (status = SUCCESS, hasEntry = true);
                goto WaitForRequest;
            }
            send req.source, eDoesLogHaveEntryResp, (status = SUCCESS, hasEntry = false);
            goto WaitForRequest;
        }
    
        on eAppendNewEntryToLogReq do (req: tAppendNewEntryToLogReq) {
            var appendedEntry: tEntry;
            appendedEntry = AppendEntry(req.entryData, req.numReferences);
            send req.source, eAppendNewEntryToLogResp, (status = SUCCESS, newEntry = appendedEntry);
        }
    
        on eJoinLogReq do (req: tJoinLogReq) {
            JoinLog(req.log);
            send req.source, eJoinLogResp, (status = SUCCESS, );
        }
    
        on eJoinEntryReq do (req: tJoinEntryReq) {
            var didJoinEntry: bool;
            didJoinEntry = JoinEntry(req.entryToJoin);
            send req.source, eJoinEntryResp, (status = SUCCESS, couldJoin = didJoinEntry);
        }
    
        on eTraverseLogReq do (req: tTraverseLogReq) {
            var traversedEntries: seq[tEntry];
            var dictionary: map[string, tEntry];

            dictionary = GetDictionaryFromMemoryStorage() as map[string, tEntry];

            traversedEntries = Traverse(req.rootEntries, dictionary, req.stopper, req.useRefs);
            print format("Traversed over {0} entries in log", sizeof(traversedEntries));
            
            send req.source, eTraverseLogResp, (status = SUCCESS, traversedEntries = traversedEntries);
        }
    }

    fun GetClockLastState(): tTimestamp {
        var lastTimestamp: tTimestamp;

        print format("GETTING CLOCK LAST STATE");

        send clock, eGetLastTimestampReq, (source = this, );
        receive { 
            case eGetLastTimestampResp: (resp: tGetLastTimestampResp) {
                lastTimestamp = resp.lastTimestamp;
                print format("Clock last state is {0}", lastTimestamp);
            }
        }
        return lastTimestamp;
    }

    fun GetHeadsFromLog(): seq[tEntry] {
        var headsToReturn: seq[tEntry];

        print format("GETTING LOG HEADS");

        send heads, eGetAllEntriesFromHeadsReq, (source = this, );
        receive {
            case eGetAllEntriesFromHeadsResp: (resp: tGetAllEntriesFromHeadsResp) {
                print format("Received {0} heads from Heads", sizeof(resp.retrievedValues));
                headsToReturn = Sorted(resp.retrievedValues, true);
                print format("Received {0} heads from Heads", sizeof(headsToReturn));
            }
        }
        return headsToReturn;
    }

    fun GetAllEntriesFromLog(): seq[tEntry] {
        var entries: seq[tEntry];
        var traversedEntries: seq[tEntry];
        var rootEntries: seq[tEntry];
        var dictionary: map[string, tEntry];
        var stopper: tTraversalStopper;
        var traversedEntry: tEntry;

        print format("GETTING ALL ENTRIES IN LOG");

        stopper = CreateDefaultTraversalStopper();
        rootEntries = GetHeadsFromLog();
        dictionary = GetDictionaryFromMemoryStorage();

        traversedEntries = Traverse(rootEntries, dictionary, stopper, true);
        foreach (traversedEntry in traversedEntries) {
            entries += (0, traversedEntry);
        }

        print format("Got {0} entries from log", sizeof(entries));
        return entries;
    }

    fun GetEntryFromLog(hash: string): any {
        var value: any;

        print format("GETTING ENTRY WITH HASH {0} FROM LOG", hash);

        send entries, eGetValueFromStorageReq, (source = this, key = hash);
        receive { 
            case eGetValueFromStorageResp: (resp: tGetValueFromStorageResp) {
                if (resp.status == SUCCESS) {
                    value = resp.value as tEntry;
                    print format("Found entry {0} with hash {1} in log", value, hash);
                }
                value = resp.value as bool;
                print format("Could not find entry with hash {0} in log", hash);
            }
        }

        return value;
    }

    fun LogHasEntry(hash: string): bool {
        var value: any;

        print format("CHECKING IF LOG HAS ENTRY WITH HASH {0}", hash);

        value = GetEntryFromLog(hash);
        if (value == false) {
            print format("Log does not have entry with hash {0}", hash);
            return false;
        }
        print format("Log does have entry with hash {0}", hash);
        return true;
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

        print format("APPENDING ENTRY WITH DATA {0} TO LOG", entryData);

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
                now = resp.now;
            }
        }

        createdEntry = CreateEntry(identity, logId, entryData, now, nexts, refs);
        print format("Created entry to append: {0}", createdEntry);

        entrySet += (0, createdEntry);
        send heads, eSetEntriesInHeadsReq, (source = this, entries = entrySet);
        receive {
            case eSetEntriesInHeadsResp: (resp: tSetEntriesInHeadsResp) {
                print format("Set new entries in Heads");
            }
        }

        send entries, ePutValueInStorageReq, (source = this, key = GetHash(createdEntry), value = createdEntry);
        receive { 
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                print format("Put new entry in entries storage");
            }
        }

        send index, ePutValueInStorageReq, (source = this, key = GetHash(createdEntry), value = true);
        receive {
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                print format("Put new entry in index storage");
            }
        }

        print format("SUCCESSFULLY APPENDED ENTRY TO LOG");

        return createdEntry;
    }

    fun JoinLog(log: Log) {
        var otherLogHeads: seq[tEntry];
        var otherLogEntry: tEntry;
        var couldJoinEntry: bool;

        print format("JOINING OTHER LOG TO LOG");

        send log, eGetHeadsFromLogReq, (source = this, );
        receive { 
            case eGetHeadsFromLogResp: (resp: tGetHeadsFromLogResp) {
                otherLogHeads = resp.heads;
                print format("Received {0} heads from other log", sizeof(otherLogHeads));
            }
        } 

        foreach (otherLogEntry in otherLogHeads) {
            JoinEntry(otherLogEntry);
        }

        print format("SUCCESSFULLY JOINED OTHER LOG TO LOG");
    }

    fun JoinEntry(entryToJoin: tEntry): bool {
        var returnBool: bool;
        var headsBeforeJoin: seq[tEntry];

        print format("JOINING ENTRY {0} TO LOG", entryToJoin);

        if (LogHasEntry(GetHash(entryToJoin)) == true) {
            print format("Log already has entry");
            return false;
        }

        send clock, eUpdateHlcReq, (source = this, remoteTs = GetClock(entryToJoin));
        receive {
            case eUpdateHlcResp: (resp: tUpdateHlcResp) {
                print format("Updated clock timestamp to {0}", resp.updatedTimestamp);
            }
        }

        headsBeforeJoin = GetHeadsFromLog();
        send heads, eAddEntryToHeadsReq, (source = this, headEntry = entryToJoin);
        receive { 
            case eAddEntryToHeadsResp: (resp: tAddEntryToHeadsResp) {
                if (Sorted(resp.newHeads, true) == headsBeforeJoin) {
                    returnBool = false;
                }
            }
        }

        if (returnBool == false) {
            print format("Log already has entry {0}", entryToJoin);
            return false;
        }

        send entries, ePutValueInStorageReq, (source = this, key = GetHash(entryToJoin), value = entryToJoin);
        receive { 
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                print format("Added entry {0} to entries storage", entryToJoin);
            }
        }

        send index, ePutValueInStorageReq, (source = this, key = GetHash(entryToJoin), value = true);
        receive {
            case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                print format("Added entry {0} to index storage", entryToJoin);
            }
        }

        print format("SUCCESSFULLY JOINED ENTRY TO LOG");
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