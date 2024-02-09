using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;

namespace PImplementation {
    public static partial class GlobalFunctions {
        public static PrtSet FindHeads(PrtSet entries, PMachine machine) {
            tEntry[] entriesArray = new tEntry[]{};
            foreach (var entry in entries) {
                entriesArray.Append((tEntry)entry);
            }
            HashSet<tEntry> entriesSet = new HashSet<tEntry>(entriesArray);
            Dictionary<string, string> items = new Dictionary<string, string>();
            foreach (var entry in entriesSet) {
                foreach (var next in entry.Next) {
                    if (entry.Hash != null) {
                        items.Add(next, entry.Hash);
                    }
                }
            }

            PrtSet res = new PrtSet();
            foreach(var entry in entriesArray) {
                if (entry.Hash != null) {
                    if (!items.ContainsKey(entry.Hash)) {
                        res.Add(entry);
                    }
                }
            }
            return res;
        }
    }
}