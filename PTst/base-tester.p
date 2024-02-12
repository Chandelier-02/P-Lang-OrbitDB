machine TestAppendingEntryToLog {
    var log: Log;
    var orderedResponses: seq[tEntry];
    var orderedEntriesResp: seq[tEntry];
    var numberOfEntriesToCreate: int;
    var numberOfEntriesCreated: int;
    start state Init {
        entry {
            var logHeads: seq[tEntry];
            numberOfEntriesToCreate = 100;
            numberOfEntriesCreated = 0;
            log = new Log((identityIn = "test1", logIdIn = "test1", logHeads = logHeads));
            while (numberOfEntriesCreated <= numberOfEntriesToCreate) {
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