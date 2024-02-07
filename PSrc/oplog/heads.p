enum tRequestStatus {
    ERROR,
    SUCCESS
}

type tPutEntriesInHeadsReq = (source: machine, entries: set[tEntry]);
type tPutEntriesInHeadsResp = (status: tRequestStatus);

type tSetEntriesInHeadsReq = (source: machine, entries: set[tEntry]);
type tSetEntriesInHeadsResp = (status: tRequestStatus);

type tAddEntryToHeadsReq = (source: machine, headEntry: tEntry);
type tAddEntryToHeadsResp = (status: tRequestStatus, newHeads: set[tEntry]);

type tClearAllEntriesFromHeadsReq = (source: machine);
type tClearAllEntriesFromHeadsResp = (status: tRequestStatus);

type tGetAllEntriesFromHeadsReq = (source: machine);
type tGetAllEntriesFromHeadsResp = (status: tRequestStatus, retrivedValues: set[tEntry]);

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
        entry (heads: set[tEntry]) {
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
            var newHeads: set[tEntry];
            newHeads = AddHead(storage, req.headEntry);
            send req.source, eAddEntryToHeadsResp, (status = SUCCESS, newHeads = newHeads);
        }

        on eClearAllEntriesFromHeadsReq do (req: tClearAllEntriesFromHeadsReq) {
            ClearHeads(storage);
            send req.source, eClearAllEntriesFromHeadsResp, (status = SUCCESS, );
        }

        on eGetAllEntriesFromHeadsReq do (req: tGetAllEntriesFromHeadsReq) {
            var allHeads: set[tEntry];
            allHeads = GetAllHeads(storage);
            send req.source, eGetAllEntriesFromHeadsResp, (status = SUCCESS, retrivedValues = allHeads);
        }
    }

    fun PutHeads(storage: machine, entries: set[tEntry]) {
        var heads: set[tEntry];
        var head: tEntry;
        var numToPut: int;
        heads = FindHeads(entries);
        foreach (head in heads) {
            send storage, ePutValueInStorageReq, (source = this, key = GetHash(head), value = head);
            receive {
                case ePutEntriesInHeadsResp: (resp: tPutValueInStorageResp) {
                    assert resp.status == SUCCESS, "Failed to put head in storage."; 
                }
            }
        }
    }

    fun SetHeads(storage: machine, entries: set[tEntry]) {
        send storage, eClearAllValuesFromStorageReq, (source = this, );
        receive {
            case eClearAllValuesFromStorageResp: (resp: tClearAllValuesFromStorageResp) {
                assert resp.status == SUCCESS, "Failed to clear heads storage.";
            }
        }
        PutHeads(storage, entries);
    }

    fun GetAllHeads(storage: machine): set[tEntry] {
        var returnValues: set[tEntry];
        send storage, eGetAllValuesFromStorageReq, (source = this, );
        receive { 
            case eGetAllValuesFromStorageResp: (resp: tGetAllValuesFromStorageResp) {
                assert resp.status == SUCCESS, "Failed to retrieve all heads from storage.";
                returnValues = resp.retrivedValues as set[tEntry];
            }
        }
        return returnValues;
    }

    fun AddHead(storage: machine, head: tEntry): set[tEntry] {
        var retrievedHeads: set[tEntry];
        var newHeads: set[tEntry];
        var combinedHeadsToFind: set[tEntry];
        retrievedHeads = GetAllHeads(storage);
        combinedHeadsToFind = retrievedHeads;
        if (head in retrievedHeads) {
            return retrievedHeads;
        }
        combinedHeadsToFind = retrievedHeads;
        combinedHeadsToFind += (head);
        newHeads = FindHeads(combinedHeadsToFind);
        SetHeads(storage, newHeads);
        return newHeads;
    }

    fun ClearHeads(storage: machine) {
        send storage, eClearAllValuesFromStorageReq, (source = this, );
        receive {
            case eClearAllValuesFromStorageResp: (resp: tClearAllValuesFromStorageResp) {
                assert resp.status == SUCCESS, "Failed to clear heads storage.";
            }
        }
    }
}

fun FindHeads(entries: set[tEntry]): set[tEntry];
