// test testAppendEntriesToLog [main=TestAppendingEntryToLog]:
//     assert TimestampsAreMonotonicallyIncreasing in
//     (union Log, Heads, HybridLogicalClock, MemoryStorage, { TestAppendingEntryToLog });

// // test testFullyConnectedPeers [main=TestFullyConnectedPeers]:
// //     assert TimestampsAreMonotonicallyIncreasing in 
// //     (union OrbitDbSystem, Log, Heads, HybridLogicalClock, MemoryStorage, { TestFullyConnectedPeers });