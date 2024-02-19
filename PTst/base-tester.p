// machine TestAppendingEntryToLog {
//     var log: Log;
//     var orderedResponses: seq[tEntry];
//     var orderedEntriesResp: seq[tEntry];
//     var numberOfEntriesToCreate: int;
//     var numberOfEntriesCreated: int;
//     start state Init {
//         entry {
//             var logHeads: seq[tEntry];
//             numberOfEntriesToCreate = 100;
//             numberOfEntriesCreated = 0;
//             log = new Log((identityIn = "test1", logIdIn = "test1", logHeads = logHeads));
//             while (numberOfEntriesCreated <= numberOfEntriesToCreate) {
//                 send log, eAppendNewEntryToLogReq, (source = this, entryData = GetRandomString(), numReferences = 0);
//                 numberOfEntriesCreated = numberOfEntriesCreated + 1;
//             }
//         }

//         on eAppendNewEntryToLogResp do (resp: tAppendNewEntryToLogResp) {
//             var rootEntries: seq[tEntry];
//             var traversalStopper: tTraversalStopper;
//             var entryItr: tEntry;
//             var index: int;

//             index = 0;
//             traversalStopper = CreateDefaultTraversalStopper() as tTraversalStopper;
//             if (sizeof(orderedResponses) == 0) {
//                 orderedResponses += (0, resp.newEntry);
//             } else {
//                 orderedResponses += (sizeof(orderedResponses) - 1, resp.newEntry);
//             }

//             if (sizeof(orderedResponses) == numberOfEntriesToCreate) {
//                 send log, eTraverseLogReq, (source = this, rootEntries = rootEntries, stopper = traversalStopper, useRefs = false) as tTraverseLogReq;
//                 receive {
//                     case eTraverseLogResp: (resp: tTraverseLogResp) {
//                         foreach (entryItr in resp.traversedEntries) {
//                             assert entryItr == orderedResponses[index], "Entries not ordered correctly!";
//                             print "Entries equal!";
//                             index = index + 1;
//                         }
//                         assert false == true, "Needed to exit execution with a log";
//                     }
//                 }
//             }
//         }
//     }
// }

// Need to randomly call AddOperation for certain peers. Can also call AddOperation with different entry data but concurrently for the same head

// Need to simulate syncs going offline and network partitions

// Need to simulate a new sync joining after being offline for a while

// Need to simulate things running in the wost conditions

machine TestFullyConnectedPeers {
    var numberOfPeersToCreate: int;
    var identities: seq[string];
    var system: OrbitDbSystem;
    
    start state Active {
        entry {
            var numCreatedIdentities: int;
            var identity: string;
            var itr: int;

            numCreatedIdentities = 0;
            numberOfPeersToCreate = 10;
            while (numCreatedIdentities < numberOfPeersToCreate) {
                identity = GetRandomString();
                identities += (0, identity);
                numCreatedIdentities = numCreatedIdentities + 1;
            }
            system = new OrbitDbSystem((identities = identities, ));

            while (itr < 100) {
                send system, eAddOperationReq, (source = this, opData = GetRandomString(), identity = choose(identities));
                itr = itr + 1;
            }

            assert false == true;
        }
    }
}