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
type tGetAllValuesFromStorageResp = (status: tRequestStatus, retrivedValues: set[any]);

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

    start state Init {
        entry (name: string) {
            memoryStorage = CreateMemoryStorage(name);
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
            send req.source, ePutValueInStorageResp, (status = SUCCESS, );
            goto WaitForRequest;
        }
    }

    state DeletingValueFromStorage {
        entry (req: tDeleteValueFromStorageReq) {
            memoryStorage = DeleteValueFromMemoryStorage(memoryStorage, req.key);
            send req.source, eDeleteValueFromStorageResp, (status = SUCCESS, );
            goto WaitForRequest;
        }
    }

    state GettingValueFromStorage {
        entry (req: tGetValueFromStorageReq) {
            var value: any;
            value = GetValueFromMemoryStorage(memoryStorage, req.key);
            send req.source, eGetValueFromStorageResp, (status = SUCCESS, value = value);
            goto WaitForRequest;
        }
    }

    state ClearingAllDataFromStorage {
        entry (req: tClearAllValuesFromStorageReq) {
            memoryStorage = ClearMemoryStorage(memoryStorage);
            send req.source, eClearAllValuesFromStorageResp, (status = SUCCESS, );
            goto WaitForRequest;
        }
    }

    state GettingAllDataFromStorage {
        entry (req: tGetAllValuesFromStorageReq) {
            var retrivedValues: set[any];
            retrivedValues = GetAllValuesFromMemoryStorage(memoryStorage) as set[any];
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
fun DeleteValueFromMemoryStorage(memoryStorage: tMemoryStorage, key: string): tMemoryStorage;
fun GetValueFromMemoryStorage(memoryStorage: tMemoryStorage, key: string): any;
fun ClearMemoryStorage(memoryStorage: tMemoryStorage): tMemoryStorage;
fun GetAllValuesFromMemoryStorage(memoryStorage: tMemoryStorage): set[any];
fun GetDictionaryFromMemoryStorage(memoryStorage: tMemoryStorage): map[string, any];