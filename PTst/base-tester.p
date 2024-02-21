machine TestAppendingEntryToLog {
    var log: Log;
    var orderedResponses: seq[tEntry];
    var orderedEntriesResp: seq[tEntry];
    var numberOfEntriesToCreate: int;
    var numberOfEntriesCreated: int;
    start state Init {
        entry {
            var logHeads: seq[tEntry];
            var clock: HybridLogicalClock;
            var entryStorage: MemoryStorage;
            var indexStorage: MemoryStorage;
            var headsStorage: MemoryStorage;

            clock = new HybridLogicalClock("test1");
            entryStorage = new MemoryStorage("Entries Storage");
            indexStorage = new MemoryStorage("Index Storage");
            headsStorage = new MemoryStorage("Heads Storage");

            numberOfEntriesToCreate = 10;
            numberOfEntriesCreated = 0;

            log = new Log((identity = "test1", 
                logId = "test1", 
                logHeads = logHeads,
                clock = clock, 
                entryStorage = entryStorage, 
                headsStorage = headsStorage, 
                indexStorage = indexStorage
            ));

            while (numberOfEntriesCreated < numberOfEntriesToCreate) {
                send log, eAppendNewEntryToLogReq, (source = this, entryData = GetRandomString(), numReferences = 0);
                numberOfEntriesCreated = numberOfEntriesCreated + 1;
            }
        }

        on eAppendNewEntryToLogResp do (resp: tAppendNewEntryToLogResp) {
            var rootEntries: seq[tEntry];
            var traversalStopper: tTraversalStopper;
            var entryItr: tEntry;
            var index: int;

            index = 0;
            traversalStopper = CreateDefaultTraversalStopper() as tTraversalStopper;
            if (sizeof(orderedResponses) == 0) {
                orderedResponses += (0, resp.newEntry);
            } else {
                orderedResponses += (sizeof(orderedResponses) - 1, resp.newEntry);
            }

            if (sizeof(orderedResponses) == numberOfEntriesToCreate) {
                send log, eTraverseLogReq, (source = this, rootEntries = rootEntries, stopper = traversalStopper, useRefs = false) as tTraverseLogReq;
                receive {
                    case eTraverseLogResp: (resp: tTraverseLogResp) {
                        foreach (entryItr in resp.traversedEntries) {
                            assert entryItr == orderedResponses[index], "Entries not ordered correctly!";
                            print "Entries equal!";
                            index = index + 1;
                        }
                        assert false == true, "Needed to exit execution with a log";
                    }
                }
            }
        }
    }
}

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
            var rootEntries: seq[tEntry];
            var stopper: tTraversalStopper;
            var useRefs: bool;

            numCreatedIdentities = 0;
            numberOfPeersToCreate = 10;
            while (numCreatedIdentities < numberOfPeersToCreate) {
                identity = GetRandomString();
                identities += (0, identity);
                print format("Identity created: {0}", identity);
                numCreatedIdentities = numCreatedIdentities + 1;
            }
            system = new OrbitDbSystem((identities = identities, ));

            itr = 0;
            while (itr < sizeof(identities)) {
                send system, eStartSyncReq, (source = this, identity = identities[itr]);
                receive { 
                    case eStartSyncResp: (resp: tStartSyncResp) {
                        if (resp.status == SUCCESS) {
                            print format("Started sync for peer with identity {0}", identities[itr]);
                        } else {
                            print format("Sync for peer with identity {0} is already started!", identities[itr]);
                        }
                        itr = itr + 1;
                    }
                }
            }

            itr = 0;
            while (itr < 100) {
                send system, eAddOperationReq, (source = this, opData = GetRandomString(), identity = choose(identities));
                receive { 
                    case eAddOperationResp: (resp: tAddOperationResp) {
                        print format("ADDED OPERATION. HASH IS {0}", resp.hash);
                    }
                }
                itr = itr + 1;
            }

            itr = 0;
            while (itr < sizeof(identities)) {
                send system, eTraverseLogFromSystemReq, (source = this, identity = identities[itr], rootEntries = rootEntries, stopper = CreateDefaultTraversalStopper(), useRefs = false);
                receive { 
                    case eTraverseLogFromSystemResp: (resp: tTraverseLogFromSystemResp) {
                        print format("After addition of entries, peer with identity {0} had {1} entries", identities[itr], sizeof(resp.traversedEntries));
                        itr = itr + 1;
                    }
                }
            }

            assert false == true;
        }
    }
}