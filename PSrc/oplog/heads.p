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
type tGetAllEntriesFromHeadsResp = (status: tRequestStatus, retrievedValues: seq[tEntry]);

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
        entry (init: (headsStorage: MemoryStorage, heads: seq[tEntry])) {
            storage = init.headsStorage;
            PutHeads(init.heads);
            goto Active;
        }
    }

    state Active {
        on ePutEntriesInHeadsReq do (req: tPutEntriesInHeadsReq) {
            PutHeads(req.entries);
            send req.source, ePutEntriesInHeadsResp, (status = SUCCESS, );
        }

        on eSetEntriesInHeadsReq do (req: tSetEntriesInHeadsReq) {
            SetHeads(req.entries);
            send req.source, eSetEntriesInHeadsResp, (status = SUCCESS, );
        }

        on eAddEntryToHeadsReq do (req: tAddEntryToHeadsReq) {
            var newHeads: seq[tEntry];
            newHeads = AddHead(req.headEntry);
            send req.source, eAddEntryToHeadsResp, (status = SUCCESS, newHeads = newHeads);
        }

        on eClearAllEntriesFromHeadsReq do (req: tClearAllEntriesFromHeadsReq) {
            ClearHeads();
            send req.source, eClearAllEntriesFromHeadsResp, (status = SUCCESS, );
        }

        on eGetAllEntriesFromHeadsReq do (req: tGetAllEntriesFromHeadsReq) {
            var allHeads: seq[tEntry];
            allHeads = GetAllHeads();
            send req.source, eGetAllEntriesFromHeadsResp, (status = SUCCESS, retrievedValues = allHeads);
        }
    }

    fun PutHeads(entries: seq[tEntry]) {
        var heads: seq[tEntry];
        var head: tEntry;
        var numToPut: int;

        print format("PUTTING {0} ENTRIES IN HEADS", sizeof(entries));

        heads = FindHeads(entries);
        print format("Found {0} heads from the entries", sizeof(heads));

        foreach (head in heads) {
            send storage, ePutValueInStorageReq, (source = this, key = GetHash(head), value = head);
            receive {
                case ePutValueInStorageResp: (resp: tPutValueInStorageResp) {
                    print format("Head {0} put in heads storage", head);
                }
            }
        }
    }

    fun SetHeads(entries: seq[tEntry]) {
        print format("SETTING {0} ENTRIES IN HEADS", sizeof(entries));

        send storage, eClearAllValuesFromStorageReq, (source = this, );
        receive {
            case eClearAllValuesFromStorageResp: (resp: tClearAllValuesFromStorageResp) {
                print format("Cleared all heads from heads storage");
            }
        }
        PutHeads(entries);
    }

    fun GetAllHeads(): seq[tEntry] {
        var returnValues: seq[tEntry];
        send storage, eGetAllValuesFromStorageReq, (source = this, );
        receive { 
            case eGetAllValuesFromStorageResp: (resp: tGetAllValuesFromStorageResp) {
                print format("Got {0} heads from heads storage", sizeof(resp.retrievedValues));
                returnValues = resp.retrievedValues as seq[tEntry];
            }
        }
        return returnValues;
    }

    fun AddHead(head: tEntry): seq[tEntry] {
        var retrievedHeads: seq[tEntry];
        var newHeads: seq[tEntry];
        var combinedHeadsToFind: seq[tEntry];
        retrievedHeads = GetAllHeads();
        combinedHeadsToFind = retrievedHeads;
        if (head in retrievedHeads) {
            print format("Head {0} already in head storage", head);
            return retrievedHeads;
        }
        combinedHeadsToFind = retrievedHeads;
        combinedHeadsToFind += (0, head);
        newHeads = FindHeads(combinedHeadsToFind);
        SetHeads(newHeads);
        print format("Successfully added head {0} to heads storage", head);
        return newHeads;
    }

    fun ClearHeads() {
        send storage, eClearAllValuesFromStorageReq, (source = this, );
        receive {
            case eClearAllValuesFromStorageResp: (resp: tClearAllValuesFromStorageResp) {
                print format("Cleared all heads from heads storage");
            }
        }
    }
}

fun FindHeads(entries: seq[tEntry]): seq[tEntry];
