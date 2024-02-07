// using System;
// using System.Runtime;
// using System.Collections.Generic;
// using System.Linq;
// using System.IO;
// using Plang.CSharpRuntime;
// using Plang.CSharpRuntime.Values;
// using Plang.CSharpRuntime.Exceptions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Security.Principal;
// using System.Dynamic;
// using System.Runtime.InteropServices;
// using System.Collections;
// using System.Security;
// using System.Text.Json;
// using System.Security.Cryptography;
// using System.Text;
// using System.Reflection.Metadata;
// using System.Runtime.CompilerServices;

// #pragma warning disable 162, 219, 414
// namespace PImplementation {
//     public class tDatabase : IPrtValue {
//         private readonly int defaultReferencesCount = 16;
//         public readonly int ReferencesCount;
//         public readonly tMemoryStorage<tEntry> EntryStorage;
//         public readonly tMemoryStorage<bool> IndexStorage;
//         public readonly tHeads HeadsStorage;
//         public readonly string Name;
//         public readonly string Identity;
//         public readonly string Address;
//         public readonly bool SyncAutomatically;
//         public readonly tHybridLogicalClock Clock;
//         public readonly tOpLog Log;
//         private readonly TaskQueue Queue;

//         #nullable enable
//         public tDatabase(
//             string identity, 
//             string address, 
//             string name, 
//             tHybridLogicalClock? clock,
//             tMemoryStorage<tEntry>? headsStorage,
//             tMemoryStorage<tEntry>? entryStorage,
//             tMemoryStorage<bool>? indexStorage,
//             int? referencesCount,
//             bool syncAutomatically = true
//         ) {
//             Identity = identity;
//             Address = address;
//             Name = name;
//             SyncAutomatically = syncAutomatically;
//             ReferencesCount = referencesCount ?? defaultReferencesCount;
//             EntryStorage = entryStorage ?? new tMemoryStorage<tEntry>();
//             IndexStorage = indexStorage ?? new tMemoryStorage<bool>();
//             Clock = clock ?? new tHybridLogicalClock(identity, null, null);
//             Log = new tOpLog(identity, address, null, logClock: Clock, entryStorage, headsStorage, indexStorage, null);
//         }
        
//         public string AddOperation(string op) {
//             tEntry entry = Log.AppendEntry(op, ReferencesCount);
//         }
//     }
// }