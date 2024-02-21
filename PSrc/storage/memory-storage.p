// type tMemoryStorage;

// type tPutValueInStorageReq = (source: machine, key: string, value: any);
// type tPutValueInStorageResp = (status: tRequestStatus);

// type tDeleteValueFromStorageReq = (source: machine, key: string);
// type tDeleteValueFromStorageResp = (status: tRequestStatus);

// type tGetValueFromStorageReq = (source: machine, key: string);
// type tGetValueFromStorageResp = (status: tRequestStatus, value: any);

// type tClearAllValuesFromStorageReq = (source: machine);
// type tClearAllValuesFromStorageResp = (status: tRequestStatus);

// type tGetAllValuesFromStorageReq = (source: machine);
// type tGetAllValuesFromStorageResp = (status: tRequestStatus, retrievedValues: seq[any]);

// type tGetDictionaryFromMemoryStorageReq = (source: machine);
// type tGetDictionaryFromMemoryStorageResp = (status: tRequestStatus, dictionary: map[string, any]);

// event ePutValueInStorageReq : tPutValueInStorageReq;
// event ePutValueInStorageResp : tPutValueInStorageResp;

// event eDeleteValueFromStorageReq : tDeleteValueFromStorageReq;
// event eDeleteValueFromStorageResp : tDeleteValueFromStorageResp;

// event eGetValueFromStorageReq : tGetValueFromStorageReq;
// event eGetValueFromStorageResp : tGetValueFromStorageResp;

// event eClearAllValuesFromStorageReq : tClearAllValuesFromStorageReq;
// event eClearAllValuesFromStorageResp : tClearAllValuesFromStorageResp;

// event eGetAllValuesFromStorageReq : tGetAllValuesFromStorageReq;
// event eGetAllValuesFromStorageResp : tGetAllValuesFromStorageResp;

// event eGetDictionaryFromMemoryStorageReq : tGetDictionaryFromMemoryStorageReq;
// event eGetDictionaryFromMemoryStorageResp : tGetDictionaryFromMemoryStorageResp;

// machine MemoryStorage {
//     var memoryStorage: tMemoryStorage;
//     var name: string;

//     start state Init {
//         entry (nameIn: string) {
//             memoryStorage = CreateMemoryStorage(nameIn);
//             name = nameIn;
//             goto WaitForRequest;
//         }
//     }

//     state WaitForRequest {
//         on ePutValueInStorageReq do (req: tPutValueInStorageReq) {
//             goto PuttingValueInStorage, req;
//         } 

//         on eDeleteValueFromStorageReq do (req: tDeleteValueFromStorageReq) {
//             goto DeletingValueFromStorage, req;
//         }

//         on eGetValueFromStorageReq do (req: tGetValueFromStorageReq) {
//             goto GettingValueFromStorage, req;
//         }

//         on eClearAllValuesFromStorageReq do (req: tClearAllValuesFromStorageReq) {
//             goto ClearingAllDataFromStorage, req;
//         }

//         on eGetAllValuesFromStorageReq do (req: tGetAllValuesFromStorageReq) {
//             goto GettingAllDataFromStorage, req;
//         }

//         on eGetDictionaryFromMemoryStorageReq do (req: tGetDictionaryFromMemoryStorageReq) {
//             goto GettingDictionayFromMemoryStorage, req;
//         }
//     }

//     state PuttingValueInStorage {
//         entry (req: tPutValueInStorageReq) {
//             print format("PUTTING KEY {0} WITH VALUE {1}, IN {2}", req.key, req.value, name);
//             memoryStorage = PutValueInMemoryStorage(memoryStorage, req.key, req.value);
//             print format("PUT KEY {0} WITH VALUE {1} IN {2}", req.key, req.value, name);
//             send req.source, ePutValueInStorageResp, (status = SUCCESS, );
//             goto WaitForRequest;
//         }
//     }

//     state DeletingValueFromStorage {
//         entry (req: tDeleteValueFromStorageReq) {
//             var deleteResp: ( couldDelete: bool, memoryStorage: tMemoryStorage );
//             print format("TRYING TO DELETE KEY {0} FROM {1}", req.key, name);
//             deleteResp = DeleteValueFromMemoryStorage(memoryStorage, req.key);
//             if (deleteResp.couldDelete) {
//                 memoryStorage = deleteResp.memoryStorage;
//                 print format("DELETED KEY-VALUE-PAIR WITH KEY {0} FROM {1}", req.key, name);
//                 send req.source, eDeleteValueFromStorageResp, (status = SUCCESS, );
//                 goto WaitForRequest;
//             }
//             print format("COULD NOT DELETE KEY {0} FROM {1} BECAUSE IT IS NOT STORED", req.key, name);
//             send req.source, eDeleteValueFromStorageResp, (status = ERROR, );
//             goto WaitForRequest;
//         }
//     }

//     state GettingValueFromStorage {
//         entry (req: tGetValueFromStorageReq) {
//             var value: any;
//             print format("ATTEMPTING TO KEY VALUE FOR KEY {0} IN {1}", req.key, name);
//             value = GetValueFromMemoryStorage(memoryStorage, req.key);
//             if (value == false) {
//                 print format("NO VALUE ASSOCIATED WITH KEY {0} IN {1}", req.key, name);
//                 send req.source, eGetValueFromStorageResp, (status = ERROR, value = value);
//                 goto WaitForRequest;
//             }
//             print format("GOT VALUE {0} FOR KEY {1} IN {2}", value, req.key, name);
//             send req.source, eGetValueFromStorageResp, (status = SUCCESS, value = value);
//             goto WaitForRequest;
//         }
//     }

//     state ClearingAllDataFromStorage {
//         entry (req: tClearAllValuesFromStorageReq) {
//             memoryStorage = ClearMemoryStorage(memoryStorage);
//             print format("Cleared all data from {0}", name);
//             send req.source, eClearAllValuesFromStorageResp, (status = SUCCESS, );
//             goto WaitForRequest;
//         }
//     }

//     state GettingAllDataFromStorage {
//         entry (req: tGetAllValuesFromStorageReq) {
//             var retrievedValues: seq[any];
//             retrievedValues = GetAllValuesFromMemoryStorage(memoryStorage) as seq[any];
//             print format("Retrieved {0} values from {1}", sizeof(retrievedValues), name);
//             send req.source, eGetAllValuesFromStorageResp, (status = SUCCESS, retrievedValues = retrievedValues);
//             goto WaitForRequest;
//         }
//     }

//     state GettingDictionayFromMemoryStorage {
//         entry (req: tGetDictionaryFromMemoryStorageReq) {
//             var dictionary: map[string, any];
//             dictionary = GetDictionaryFromMemoryStorage(memoryStorage);
//             send req.source, eGetDictionaryFromMemoryStorageResp, (status = SUCCESS, dictionary = dictionary);
//             goto WaitForRequest;
//         }
//     }
// }

// fun CreateMemoryStorage(name: string): tMemoryStorage;
// fun PutValueInMemoryStorage(memoryStorage: tMemoryStorage, key: string, value: any): tMemoryStorage;
// fun DeleteValueFromMemoryStorage(memoryStorage: tMemoryStorage, key: string): ( couldDelete: bool, memoryStorage: tMemoryStorage );
// fun GetValueFromMemoryStorage(memoryStorage: tMemoryStorage, key: string): any;
// fun ClearMemoryStorage(memoryStorage: tMemoryStorage): tMemoryStorage;
// fun GetAllValuesFromMemoryStorage(memoryStorage: tMemoryStorage): seq[any];
// fun GetDictionaryFromMemoryStorage(memoryStorage: tMemoryStorage): map[string, any];