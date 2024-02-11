enum tRequestStatus {
    ERROR,
    SUCCESS
}

type tPutEntriesInHeadsReq = (source: machine, entries: seq[tEntry]);
type tPutEntriesInHeadsResp = (status: tRequestStatus);

type tSetEntriesInHeadsReq = (source: machine, entries: seq[tEntry]);
type tSetEntriesInHeadsResp = (status: tRequestStatus);

type tAddEntryToHeadsReq = (source: machine, headEntry: tEntry);
type tAddEntryToHeadsResp = (status: tRequestStatus, newHeads: seq[tEntry]);

type tClearAllEntriesFromHeadsReq = (source: machine);
type tClearAllEntriesFromHeadsResp = (status: tRequestStatus);

type tGetAllEntriesFromHeadsReq = (source: machine);
type tGetAllEntriesFromHeadsResp = (status: tRequestStatus, retrivedValues: seq[tEntry]);

event ePutEntriesInHeadsReq : tPutEntriesInHeadsReq;
event ePutEntriesInHeadsResp : tPutEntriesInHeadsResp;

event eSetEntriesInHeadsReq : tSetEntriesInHeadsReq;
event eSetEntriesInHeadsResp: tSetEntriesInHeadsResp;

event eAddEntryToHeadsReq : tAddEntryToHeadsReq;
event eAddEntryToHeadsResp : tAddEntryToHeadsResp;

event eClearAllEntriesFromHeadsReq : tClearAllEntriesFromHeadsReq;
event eClearAllEntriesFromHeadsResp : tClearAllEntriesFromHeadsResp;

event eGetAllEntriesFromHeadsReq : tGetAllEntriesFromHeadsReq;
event eGetAllEntriesFromHeadsResp : tGetAllEntriesFromHeadsResp;

machine Heads {
    var storage: MemoryStorage;

    start state Init {
        entry (heads: seq[tEntry]) {
            storage = new MemoryStorage("Heads");
            PutHeads(storage, heads);
            goto Active;
        }
    }

    state Active {
        on ePutEntriesInHeadsReq do (req: tPutEntriesInHeadsReq) {
            PutHeads(storage, req.entries);
            send req.source, ePutEntriesInHeadsResp, (status = SUCCESS, );
        }

        on eSetEntriesInHeadsReq do (req: tSetEntriesInHeadsReq) {
            SetHeads(storage, req.entries);
            send req.source, eSetEntriesInHeadsResp, (status = SUCCESS, );
        }

        on eAddEntryToHeadsReq do (req: tAddEntryToHeadsReq) {
            var newHeads: seq[tEntry];
            newHeads = AddHead(storage, req.headEntry);
            send req.source, eAddEntryToHeadsResp, (status = SUCCESS, newHeads = newHeads);
        }

        on eClearAllEntriesFromHeadsReq do (req: tClearAllEntriesFromHeadsReq) {
            ClearHeads(storage);
            send req.source, eClearAllEntriesFromHeadsResp, (status = SUCCESS, );
        }

        on eGetAllEntriesFromHeadsReq do (req: tGetAllEntriesFromHeadsReq) {
            var allHeads: seq[tEntry];
            allHeads = GetAllHeads(storage);
            send req.source, eGetAllEntriesFromHeadsResp, (status = SUCCESS, retrivedValues = allHeads);
        }
    }

    fun PutHeads(storage: machine, entries: seq[tEntry]) {
        var heads: seq[tEntry];
        var head: tEntry;
        var numToPut: int;
        heads = FindHeads(entries);
        foreach (head in heads) {
            send storage, ePutValueInStorageReq, (source = this, key = GetHash(head), value = head);
            receive {
                case ePutEntriesInHeadsResp: (resp: tPutValueInStorageResp) {
                    print format("Head {0} put in heads storage", head);
                }
            }
        }
    }

    fun SetHeads(storage: machine, entries: seq[tEntry]) {
        send storage, eClearAllValuesFromStorageReq, (source = this, );
        receive {
            case eClearAllValuesFromStorageResp: (resp: tClearAllValuesFromStorageResp) {
                print format("Cleared all heads from heads storage");
            }
        }
        PutHeads(storage, entries);
    }

    fun GetAllHeads(storage: machine): seq[tEntry] {
        var returnValues: seq[tEntry];
        send storage, eGetAllValuesFromStorageReq, (source = this, );
        receive { 
            case eGetAllValuesFromStorageResp: (resp: tGetAllValuesFromStorageResp) {
                print format("Got {0} heads from heads storage", sizeof(resp.retrivedValues));
                returnValues = resp.retrivedValues as seq[tEntry];
            }
        }
        return returnValues;
    }

    fun AddHead(storage: machine, head: tEntry): seq[tEntry] {
        var retrievedHeads: seq[tEntry];
        var newHeads: seq[tEntry];
        var combinedHeadsToFind: seq[tEntry];
        retrievedHeads = GetAllHeads(storage);
        combinedHeadsToFind = retrievedHeads;
        if (head in retrievedHeads) {
            print format("Head {0} already in head storage", head);
            return retrievedHeads;
        }
        combinedHeadsToFind = retrievedHeads;
        combinedHeadsToFind += (0, head);
        newHeads = FindHeads(combinedHeadsToFind);
        SetHeads(storage, newHeads);
        print format("Successfully added head {0} to heads storage", head);
        return newHeads;
    }

    fun ClearHeads(storage: machine) {
        send storage, eClearAllValuesFromStorageReq, (source = this, );
        receive {
            case eClearAllValuesFromStorageResp: (resp: tClearAllValuesFromStorageResp) {
                print format("Cleared all heads from heads storage");
            }
        }
    }
}

fun FindHeads(entries: seq[tEntry]): seq[tEntry];
