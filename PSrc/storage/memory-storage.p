type tMemoryStorage;

type tPutValueInStorageReq = (source: machine, key: string, value: any);
type tPutValueInStorageResp = (status: tRequestStatus);

type tDeleteValueFromStorageReq = (source: machine, key: string);
type tDeleteValueFromStorageResp = (status: tRequestStatus);

type tGetValueFromStorageReq = (source: machine, key: string);
type tGetValueFromStorageResp = (status: tRequestStatus, value: any);

type tClearAllValuesFromStorageReq = (source: machine);
type tClearAllValuesFromStorageResp = (status: tRequestStatus);

type tGetAllValuesFromStorageReq = (source: machine);
type tGetAllValuesFromStorageResp = (status: tRequestStatus, retrivedValues: seq[any]);

type tGetDictionaryFromMemoryStorageReq = (source: machine);
type tGetDictionaryFromMemoryStorageResp = (status: tRequestStatus, dictionary: map[string, any]);

event ePutValueInStorageReq : tPutValueInStorageReq;
event ePutValueInStorageResp : tPutValueInStorageResp;

event eDeleteValueFromStorageReq : tDeleteValueFromStorageReq;
event eDeleteValueFromStorageResp : tDeleteValueFromStorageResp;

event eGetValueFromStorageReq : tGetValueFromStorageReq;
event eGetValueFromStorageResp : tGetValueFromStorageResp;

event eClearAllValuesFromStorageReq : tClearAllValuesFromStorageReq;
event eClearAllValuesFromStorageResp : tClearAllValuesFromStorageResp;

event eGetAllValuesFromStorageReq : tGetAllValuesFromStorageReq;
event eGetAllValuesFromStorageResp : tGetAllValuesFromStorageResp;

event eGetDictionaryFromMemoryStorageReq : tGetDictionaryFromMemoryStorageReq;
event eGetDictionaryFromMemoryStorageResp : tGetDictionaryFromMemoryStorageResp;

machine MemoryStorage {
    var memoryStorage: tMemoryStorage;
    var name: string;

    start state Init {
        entry (name: string) {
            memoryStorage = CreateMemoryStorage(name);
            name = name;
            goto WaitForRequest;
        }
    }

    state WaitForRequest {
        on ePutValueInStorageReq do (req: tPutValueInStorageReq) {
            goto PuttingValueInStorage, req;
        } 

        on eDeleteValueFromStorageReq do (req: tDeleteValueFromStorageReq) {
            goto DeletingValueFromStorage, req;
        }

        on eGetValueFromStorageReq do (req: tGetValueFromStorageReq) {
            goto GettingValueFromStorage, req;
        }

        on eClearAllValuesFromStorageReq do (req: tClearAllValuesFromStorageReq) {
            goto ClearingAllDataFromStorage, req;
        }

        on eGetAllValuesFromStorageReq do (req: tGetAllValuesFromStorageReq) {
            goto GettingAllDataFromStorage, req;
        }

        on eGetDictionaryFromMemoryStorageReq do (req: tGetDictionaryFromMemoryStorageReq) {
            goto GettingDictionayFromMemoryStorage, req;
        }
    }

    state PuttingValueInStorage {
        entry (req: tPutValueInStorageReq) {
            memoryStorage = PutValueInMemoryStorage(memoryStorage, req.key, req.value);
            print format("Put key {0} with value {1} in {2}", req.key, req.value, name);
            send req.source, ePutValueInStorageResp, (status = SUCCESS, );
            goto WaitForRequest;
        }
    }

    state DeletingValueFromStorage {
        entry (req: tDeleteValueFromStorageReq) {
            var deleteResp: ( couldDelete: bool, memoryStorage: tMemoryStorage );
            deleteResp = DeleteValueFromMemoryStorage(memoryStorage, req.key);
            if (deleteResp.couldDelete) {
                print format("Deleted {0} from {1}", req.key, name);
                send req.source, eDeleteValueFromStorageResp, (status = SUCCESS, );
                goto WaitForRequest;
            }
            print format("{0} not in {1}", req.key, name);
            send req.source, eDeleteValueFromStorageResp, (status = ERROR, );
            goto WaitForRequest;
        }
    }

    state GettingValueFromStorage {
        entry (req: tGetValueFromStorageReq) {
            var value: any;
            value = GetValueFromMemoryStorage(memoryStorage, req.key);
            if (value == false) {
                print format("No value associated with key {0} in {1}", req.key, name);
                send req.source, eGetValueFromStorageResp, (status = ERROR, value = value);
                goto WaitForRequest;
            }
            print format("Got value {0} for key {1} in {2}", value, req.key, name);
            send req.source, eGetValueFromStorageResp, (status = SUCCESS, value = value);
            goto WaitForRequest;
        }
    }

    state ClearingAllDataFromStorage {
        entry (req: tClearAllValuesFromStorageReq) {
            memoryStorage = ClearMemoryStorage(memoryStorage);
            print format("Cleared all data from {0}", name);
            send req.source, eClearAllValuesFromStorageResp, (status = SUCCESS, );
            goto WaitForRequest;
        }
    }

    state GettingAllDataFromStorage {
        entry (req: tGetAllValuesFromStorageReq) {
            var retrivedValues: seq[any];
            retrivedValues = GetAllValuesFromMemoryStorage(memoryStorage) as seq[any];
            print format("Retrieved {0} values from {1}", sizeof(retrivedValues), name);
            send req.source, eGetAllValuesFromStorageResp, (status = SUCCESS, retrivedValues = retrivedValues);
            goto WaitForRequest;
        }
    }

    state GettingDictionayFromMemoryStorage {
        entry (req: tGetDictionaryFromMemoryStorageReq) {
            var dictionary: map[string, any];
            dictionary = GetDictionaryFromMemoryStorage(memoryStorage);
            send req.source, eGetDictionaryFromMemoryStorageResp, (status = SUCCESS, dictionary = dictionary);
        }
    }
}

fun CreateMemoryStorage(name: string): tMemoryStorage;
fun PutValueInMemoryStorage(memoryStorage: tMemoryStorage, key: string, value: any): tMemoryStorage;
fun DeleteValueFromMemoryStorage(memoryStorage: tMemoryStorage, key: string): ( couldDelete: bool, memoryStorage: tMemoryStorage );
fun GetValueFromMemoryStorage(memoryStorage: tMemoryStorage, key: string): any;
fun ClearMemoryStorage(memoryStorage: tMemoryStorage): tMemoryStorage;
fun GetAllValuesFromMemoryStorage(memoryStorage: tMemoryStorage): seq[any];
fun GetDictionaryFromMemoryStorage(memoryStorage: tMemoryStorage): map[string, any];