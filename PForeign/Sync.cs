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

// #pragma warning disable 162, 219, 414
// namespace PImplementation {
//     public delegate void PeerSubscribedHandler(tEntry head);
//     public delegate void PeerUpdatedHandler()

//     public class tSync : IPtrValue {
//         public readonly string Address;
//         public readonly HashSet<string> Peers;
//         private readonly tOpLog Log;
//         private readonly Action<tEntry> OnSynced;

//         public tSync(tOpLog log, Action<tEntry> onSynced) {
//             Log = log;
//             Address = log.Id;
//             Peers = new HashSet<string>();
//             OnSynced = onSynced; // Might be sus. Who knows. Wonder if it has "this" context
//         }

//         private IEnumerable SendHeads(string source) {
//             var heads = Log.GetHeads();
//             foreach (var head in heads) {
//                 yield return head;
//             }
//         }

//         private void ReceiveHeads(tEntry[] source, string peerId) {
//             foreach (var value in source) {
//                 OnSynced(value);
//             }
//             // TODO: Maybe add onPeerJoined
//         }

//         private void HandleReceiveHeads(tEntry[] stream, tPeer peer) {
//             Peers.Add(peerId);
//             ReceiveHeads(stream, peerId);
//             SendHeads(peerId);
//             Peers.Remove(peerId);
//         }

//         private void HandlePeerSubscribed(tPeer peer) {
//             if (Peers.Contains(peerId)) {
//                 return;
//             }
//             Peers.Add(peerId);
//             SendHeads(peerId);
//             ReceiveHeads(peerHeads, peerId);
//             Peers.Remove(peerId);
//         }
//     }
// }

using System.Collections.Generic;

namespace PImplementation {
    public class Sync {
        public HashSet<Database> peers { get; }
        public bool Started { get; }

        public Sync()
    }
}