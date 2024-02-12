// test testAppendEntriesToLog [main=TestAppendingEntryToLog]:
//     assert TimestampsAreMonotonicallyIncreasing in
//     (union Log, Heads, HybridLogicalClock, MemoryStorage, { TestAppendingEntryToLog });