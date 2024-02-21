// type tEntry;

// type tCreateEntryReq = (source: machine, identity: string, id: string, entryData: string, clock: tTimestamp, next: set[string], refs: set[string]);
// type tCreateEntryResp = (status: tRequestStatus, createdEntry: tEntry);

// event eCreateEntryReq : tCreateEntryReq;
// event eCreateEntryResp : tCreateEntryResp;

// machine EntryMachine {
//     start state Active {
//         on eCreateEntryReq do (req: tCreateEntryReq) {
//             var createdEntry: tEntry;
//             createdEntry = CreateEntry(req.identity, req.id, req.entryData, req.clock, req.next, req.refs);
//             print format("Created new entry {0}", createdEntry);
//             send req.source, eCreateEntryResp, (status= SUCCESS, createdEntry = createdEntry);
//         }
//     }
// }

// fun CreateEntry(identity: string, id: string, entryData: string, clock: tTimestamp, next: set[string], refs: set[string]): tEntry;
// fun GetHash(entryToHash: tEntry): string;
// fun GetClock(entryToGetClock: tEntry): tTimestamp;
// fun GetRandomString(): string;