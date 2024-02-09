machine TestAppendingEntryToLog {
    var log: Log;
    var orderedResponses: seq[tEntry];
    var orderedEntriesResp: seq[tEntry];
    var numberOfEntriesToCreate: int;
    start state Init {
        entry {
            var logHeads: set[tEntry];
            numberOfEntriesToCreate = 10;
            log = new Log((identityIn = "test1", logIdIn = "test1", logHeads = logHeads));
            while (numberOfEntriesToCreate > 0) {
                send log, eAppendNewEntryToLogReq, (source = this, entryData = GetRandomString(), numReferences = 0);
            }
            goto WaitForResponses;
        }
    }

    state WaitForResponses {
        on eAppendNewEntryToLogResp do (resp: tAppendNewEntryToLogResp) {
            var rootEntries: set[tEntry];
            var traversalStopper: tDefaultTraversalStopper;
            traversalStopper = CreateDefaultTraversalStopper() as tDefaultTraversalStopper;
            orderedResponses += (sizeof(orderedResponses) - 1, resp.newEntry);
            if (sizeof(orderedResponses) == numberOfEntriesToCreate) {
                send log, eTraverseLogReq, (source = this, rootEntries = rootEntries, stopper = traversalStopper, useRefs = false) as tTraverseLogReq;
                goto TryTraverseLog;
            }
        }
    }

    state TryTraverseLog {
        on eTraverseLogResp do (resp: tTraverseLogResp) {
            var entryItr: tEntry;
            var index: int;
            index = 0;
            foreach (entryItr in resp.traversedEntries) {
                assert entryItr == orderedResponses[index], "Entries not ordered correctly!";
                print "Entries equal!";
                index = index + 1;
            }
            assert false == true, "Needed to exit execution with a log";
        }
    }
}