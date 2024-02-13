using PChecker;
using PChecker.Actors;
using PChecker.Actors.Events;
using PChecker.Runtime;
using PChecker.Specifications;
using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Plang.CSharpRuntime;
using Plang.CSharpRuntime.Values;
using Plang.CSharpRuntime.Exceptions;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 162, 219, 414, 1998
namespace PImplementation
{
}
namespace PImplementation
{
    internal partial class eAddOperationReq : PEvent
    {
        public eAddOperationReq() : base() {}
        public eAddOperationReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAddOperationReq();}
    }
}
namespace PImplementation
{
    internal partial class eAddOperationResp : PEvent
    {
        public eAddOperationResp() : base() {}
        public eAddOperationResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAddOperationResp();}
    }
}
namespace PImplementation
{
    internal partial class eApplyOperationReq : PEvent
    {
        public eApplyOperationReq() : base() {}
        public eApplyOperationReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eApplyOperationReq();}
    }
}
namespace PImplementation
{
    internal partial class eApplyOperationResp : PEvent
    {
        public eApplyOperationResp() : base() {}
        public eApplyOperationResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eApplyOperationResp();}
    }
}
namespace PImplementation
{
    internal partial class eAddEntryToSyncReq : PEvent
    {
        public eAddEntryToSyncReq() : base() {}
        public eAddEntryToSyncReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAddEntryToSyncReq();}
    }
}
namespace PImplementation
{
    internal partial class eAddEntryToSyncResp : PEvent
    {
        public eAddEntryToSyncResp() : base() {}
        public eAddEntryToSyncResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAddEntryToSyncResp();}
    }
}
namespace PImplementation
{
    internal partial class ePutValueInStorageReq : PEvent
    {
        public ePutValueInStorageReq() : base() {}
        public ePutValueInStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new ePutValueInStorageReq();}
    }
}
namespace PImplementation
{
    internal partial class ePutValueInStorageResp : PEvent
    {
        public ePutValueInStorageResp() : base() {}
        public ePutValueInStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new ePutValueInStorageResp();}
    }
}
namespace PImplementation
{
    internal partial class eDeleteValueFromStorageReq : PEvent
    {
        public eDeleteValueFromStorageReq() : base() {}
        public eDeleteValueFromStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eDeleteValueFromStorageReq();}
    }
}
namespace PImplementation
{
    internal partial class eDeleteValueFromStorageResp : PEvent
    {
        public eDeleteValueFromStorageResp() : base() {}
        public eDeleteValueFromStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eDeleteValueFromStorageResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetValueFromStorageReq : PEvent
    {
        public eGetValueFromStorageReq() : base() {}
        public eGetValueFromStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetValueFromStorageReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetValueFromStorageResp : PEvent
    {
        public eGetValueFromStorageResp() : base() {}
        public eGetValueFromStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetValueFromStorageResp();}
    }
}
namespace PImplementation
{
    internal partial class eClearAllValuesFromStorageReq : PEvent
    {
        public eClearAllValuesFromStorageReq() : base() {}
        public eClearAllValuesFromStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eClearAllValuesFromStorageReq();}
    }
}
namespace PImplementation
{
    internal partial class eClearAllValuesFromStorageResp : PEvent
    {
        public eClearAllValuesFromStorageResp() : base() {}
        public eClearAllValuesFromStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eClearAllValuesFromStorageResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetAllValuesFromStorageReq : PEvent
    {
        public eGetAllValuesFromStorageReq() : base() {}
        public eGetAllValuesFromStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetAllValuesFromStorageReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetAllValuesFromStorageResp : PEvent
    {
        public eGetAllValuesFromStorageResp() : base() {}
        public eGetAllValuesFromStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetAllValuesFromStorageResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetDictionaryFromMemoryStorageReq : PEvent
    {
        public eGetDictionaryFromMemoryStorageReq() : base() {}
        public eGetDictionaryFromMemoryStorageReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetDictionaryFromMemoryStorageReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetDictionaryFromMemoryStorageResp : PEvent
    {
        public eGetDictionaryFromMemoryStorageResp() : base() {}
        public eGetDictionaryFromMemoryStorageResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetDictionaryFromMemoryStorageResp();}
    }
}
namespace PImplementation
{
    internal partial class ePutEntriesInHeadsReq : PEvent
    {
        public ePutEntriesInHeadsReq() : base() {}
        public ePutEntriesInHeadsReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new ePutEntriesInHeadsReq();}
    }
}
namespace PImplementation
{
    internal partial class ePutEntriesInHeadsResp : PEvent
    {
        public ePutEntriesInHeadsResp() : base() {}
        public ePutEntriesInHeadsResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new ePutEntriesInHeadsResp();}
    }
}
namespace PImplementation
{
    internal partial class eSetEntriesInHeadsReq : PEvent
    {
        public eSetEntriesInHeadsReq() : base() {}
        public eSetEntriesInHeadsReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eSetEntriesInHeadsReq();}
    }
}
namespace PImplementation
{
    internal partial class eSetEntriesInHeadsResp : PEvent
    {
        public eSetEntriesInHeadsResp() : base() {}
        public eSetEntriesInHeadsResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eSetEntriesInHeadsResp();}
    }
}
namespace PImplementation
{
    internal partial class eAddEntryToHeadsReq : PEvent
    {
        public eAddEntryToHeadsReq() : base() {}
        public eAddEntryToHeadsReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAddEntryToHeadsReq();}
    }
}
namespace PImplementation
{
    internal partial class eAddEntryToHeadsResp : PEvent
    {
        public eAddEntryToHeadsResp() : base() {}
        public eAddEntryToHeadsResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAddEntryToHeadsResp();}
    }
}
namespace PImplementation
{
    internal partial class eClearAllEntriesFromHeadsReq : PEvent
    {
        public eClearAllEntriesFromHeadsReq() : base() {}
        public eClearAllEntriesFromHeadsReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eClearAllEntriesFromHeadsReq();}
    }
}
namespace PImplementation
{
    internal partial class eClearAllEntriesFromHeadsResp : PEvent
    {
        public eClearAllEntriesFromHeadsResp() : base() {}
        public eClearAllEntriesFromHeadsResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eClearAllEntriesFromHeadsResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetAllEntriesFromHeadsReq : PEvent
    {
        public eGetAllEntriesFromHeadsReq() : base() {}
        public eGetAllEntriesFromHeadsReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetAllEntriesFromHeadsReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetAllEntriesFromHeadsResp : PEvent
    {
        public eGetAllEntriesFromHeadsResp() : base() {}
        public eGetAllEntriesFromHeadsResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetAllEntriesFromHeadsResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetClockLastStateReq : PEvent
    {
        public eGetClockLastStateReq() : base() {}
        public eGetClockLastStateReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetClockLastStateReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetClockLastStateResp : PEvent
    {
        public eGetClockLastStateResp() : base() {}
        public eGetClockLastStateResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetClockLastStateResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetHeadsFromLogReq : PEvent
    {
        public eGetHeadsFromLogReq() : base() {}
        public eGetHeadsFromLogReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetHeadsFromLogReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetHeadsFromLogResp : PEvent
    {
        public eGetHeadsFromLogResp() : base() {}
        public eGetHeadsFromLogResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetHeadsFromLogResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetAllEntriesFromLogReq : PEvent
    {
        public eGetAllEntriesFromLogReq() : base() {}
        public eGetAllEntriesFromLogReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetAllEntriesFromLogReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetAllEntriesFromLogResp : PEvent
    {
        public eGetAllEntriesFromLogResp() : base() {}
        public eGetAllEntriesFromLogResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetAllEntriesFromLogResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetEntryFromLogReq : PEvent
    {
        public eGetEntryFromLogReq() : base() {}
        public eGetEntryFromLogReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetEntryFromLogReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetEntryFromLogResp : PEvent
    {
        public eGetEntryFromLogResp() : base() {}
        public eGetEntryFromLogResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetEntryFromLogResp();}
    }
}
namespace PImplementation
{
    internal partial class eDoesLogHaveEntryReq : PEvent
    {
        public eDoesLogHaveEntryReq() : base() {}
        public eDoesLogHaveEntryReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eDoesLogHaveEntryReq();}
    }
}
namespace PImplementation
{
    internal partial class eDoesLogHaveEntryResp : PEvent
    {
        public eDoesLogHaveEntryResp() : base() {}
        public eDoesLogHaveEntryResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eDoesLogHaveEntryResp();}
    }
}
namespace PImplementation
{
    internal partial class eAppendNewEntryToLogReq : PEvent
    {
        public eAppendNewEntryToLogReq() : base() {}
        public eAppendNewEntryToLogReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAppendNewEntryToLogReq();}
    }
}
namespace PImplementation
{
    internal partial class eAppendNewEntryToLogResp : PEvent
    {
        public eAppendNewEntryToLogResp() : base() {}
        public eAppendNewEntryToLogResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eAppendNewEntryToLogResp();}
    }
}
namespace PImplementation
{
    internal partial class eJoinLogReq : PEvent
    {
        public eJoinLogReq() : base() {}
        public eJoinLogReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eJoinLogReq();}
    }
}
namespace PImplementation
{
    internal partial class eJoinLogResp : PEvent
    {
        public eJoinLogResp() : base() {}
        public eJoinLogResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eJoinLogResp();}
    }
}
namespace PImplementation
{
    internal partial class eJoinEntryReq : PEvent
    {
        public eJoinEntryReq() : base() {}
        public eJoinEntryReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eJoinEntryReq();}
    }
}
namespace PImplementation
{
    internal partial class eJoinEntryResp : PEvent
    {
        public eJoinEntryResp() : base() {}
        public eJoinEntryResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eJoinEntryResp();}
    }
}
namespace PImplementation
{
    internal partial class eTraverseLogReq : PEvent
    {
        public eTraverseLogReq() : base() {}
        public eTraverseLogReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eTraverseLogReq();}
    }
}
namespace PImplementation
{
    internal partial class eTraverseLogResp : PEvent
    {
        public eTraverseLogResp() : base() {}
        public eTraverseLogResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eTraverseLogResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetLastTimestampReq : PEvent
    {
        public eGetLastTimestampReq() : base() {}
        public eGetLastTimestampReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetLastTimestampReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetLastTimestampResp : PEvent
    {
        public eGetLastTimestampResp() : base() {}
        public eGetLastTimestampResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetLastTimestampResp();}
    }
}
namespace PImplementation
{
    internal partial class eGetNowReq : PEvent
    {
        public eGetNowReq() : base() {}
        public eGetNowReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetNowReq();}
    }
}
namespace PImplementation
{
    internal partial class eGetNowResp : PEvent
    {
        public eGetNowResp() : base() {}
        public eGetNowResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eGetNowResp();}
    }
}
namespace PImplementation
{
    internal partial class eUpdateHlcReq : PEvent
    {
        public eUpdateHlcReq() : base() {}
        public eUpdateHlcReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eUpdateHlcReq();}
    }
}
namespace PImplementation
{
    internal partial class eUpdateHlcResp : PEvent
    {
        public eUpdateHlcResp() : base() {}
        public eUpdateHlcResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eUpdateHlcResp();}
    }
}
namespace PImplementation
{
    internal partial class eCreateEntryReq : PEvent
    {
        public eCreateEntryReq() : base() {}
        public eCreateEntryReq (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eCreateEntryReq();}
    }
}
namespace PImplementation
{
    internal partial class eCreateEntryResp : PEvent
    {
        public eCreateEntryResp() : base() {}
        public eCreateEntryResp (PrtNamedTuple payload): base(payload){ }
        public override IPrtValue Clone() { return new eCreateEntryResp();}
    }
}
namespace PImplementation
{
    internal partial class Database : PMachine
    {
        private PMachineValue log = null;
        private PMachineValue sync = null;
        private PrtString identity = ((PrtString)"");
        private PrtString address = ((PrtString)"");
        private PrtString name = ((PrtString)"");
        private PrtInt referenceCount = ((PrtInt)0);
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtNamedTuple val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtNamedTuple)value); }
        public Database() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_Log));
            this.creates.Add(nameof(I_Sync));
        }
        
        public void Anon(Event currentMachine_dequeuedEvent)
        {
            Database currentMachine = this;
            PrtNamedTuple init = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq logHeads = new PrtSeq();
            PrtString TMP_tmp0 = ((PrtString)"");
            PrtString TMP_tmp1 = ((PrtString)"");
            PrtString TMP_tmp2 = ((PrtString)"");
            PrtString TMP_tmp3 = ((PrtString)"");
            PrtString TMP_tmp4 = ((PrtString)"");
            PrtString TMP_tmp5 = ((PrtString)"");
            PrtString TMP_tmp6 = ((PrtString)"");
            PrtString TMP_tmp7 = ((PrtString)"");
            PrtSeq TMP_tmp8 = new PrtSeq();
            PMachineValue TMP_tmp9 = null;
            PMachineValue TMP_tmp10 = null;
            PMachineValue TMP_tmp11 = null;
            PMachineValue TMP_tmp12 = null;
            PrtNamedTuple TMP_tmp13 = (new PrtNamedTuple(new string[]{"identity","logId","logHeads","clock","entryStorage","headsStorage","indexStorage"},((PrtString)""), ((PrtString)""), new PrtSeq(), null, null, null, null));
            PMachineValue TMP_tmp14 = null;
            PMachineValue TMP_tmp15 = null;
            TMP_tmp0 = (PrtString)(((PrtNamedTuple)init)["identity"]);
            TMP_tmp1 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp0)?.Clone()));
            identity = TMP_tmp1;
            TMP_tmp2 = (PrtString)(((PrtNamedTuple)init)["address"]);
            TMP_tmp3 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp2)?.Clone()));
            address = TMP_tmp3;
            TMP_tmp4 = (PrtString)(((PrtNamedTuple)init)["name"]);
            TMP_tmp5 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp4)?.Clone()));
            name = TMP_tmp5;
            referenceCount = (PrtInt)(((PrtInt)((IPrtValue)referenceCount)?.Clone()));
            TMP_tmp6 = (PrtString)(((PrtString)((IPrtValue)identity)?.Clone()));
            TMP_tmp7 = (PrtString)(((PrtString)((IPrtValue)address)?.Clone()));
            TMP_tmp8 = (PrtSeq)(((PrtSeq)((IPrtValue)logHeads)?.Clone()));
            TMP_tmp9 = (PMachineValue)(((PrtNamedTuple)init)["clock"]);
            TMP_tmp10 = (PMachineValue)(((PrtNamedTuple)init)["entryStorage"]);
            TMP_tmp11 = (PMachineValue)(((PrtNamedTuple)init)["headsStorage"]);
            TMP_tmp12 = (PMachineValue)(((PrtNamedTuple)init)["indexStorage"]);
            TMP_tmp13 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"identity","logId","logHeads","clock","entryStorage","headsStorage","indexStorage"}, TMP_tmp6, TMP_tmp7, TMP_tmp8, TMP_tmp9, TMP_tmp10, TMP_tmp11, TMP_tmp12)));
            TMP_tmp14 = (PMachineValue)(currentMachine.CreateInterface<I_Log>( currentMachine, TMP_tmp13));
            log = TMP_tmp14;
            TMP_tmp15 = (PMachineValue)(currentMachine.CreateInterface<I_Sync>( currentMachine));
            sync = TMP_tmp15;
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_1(Event currentMachine_dequeuedEvent)
        {
            Database currentMachine = this;
            PrtNamedTuple req = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_1 = (new PrtNamedTuple(new string[]{"source","opData"},null, ((PrtString)"")));
            TMP_tmp0_1 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req)?.Clone()));
            currentMachine.TryGotoState<AddingOperation>(TMP_tmp0_1);
            return;
        }
        public void Anon_2(Event currentMachine_dequeuedEvent)
        {
            Database currentMachine = this;
            PrtNamedTuple req_1 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_2 = (new PrtNamedTuple(new string[]{"source","opEntry"},null, null));
            TMP_tmp0_2 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_1)?.Clone()));
            currentMachine.TryGotoState<ApplyingOperation>(TMP_tmp0_2);
            return;
        }
        public async Task Anon_3(Event currentMachine_dequeuedEvent)
        {
            Database currentMachine = this;
            PrtNamedTuple req_2 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tEntry appendedEntry = null;
            PMachineValue TMP_tmp0_3 = null;
            PEvent TMP_tmp1_1 = null;
            PMachineValue TMP_tmp2_1 = null;
            PrtString TMP_tmp3_1 = ((PrtString)"");
            PrtInt TMP_tmp4_1 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp5_1 = (new PrtNamedTuple(new string[]{"source","entryData","numReferences"},null, ((PrtString)""), ((PrtInt)0)));
            tEntry TMP_tmp6_1 = null;
            tEntry TMP_tmp7_1 = null;
            PMachineValue TMP_tmp8_1 = null;
            PEvent TMP_tmp9_1 = null;
            PMachineValue TMP_tmp10_1 = null;
            tEntry TMP_tmp11_1 = null;
            PrtNamedTuple TMP_tmp12_1 = (new PrtNamedTuple(new string[]{"source","entryToAdd"},null, null));
            tEntry TMP_tmp13_1 = null;
            PrtString TMP_tmp14_1 = ((PrtString)"");
            PMachineValue TMP_tmp15_1 = null;
            PMachineValue TMP_tmp16 = null;
            PEvent TMP_tmp17 = null;
            PrtInt TMP_tmp18 = ((PrtInt)0);
            tEntry TMP_tmp19 = null;
            PrtString TMP_tmp20 = ((PrtString)"");
            PrtNamedTuple TMP_tmp21 = (new PrtNamedTuple(new string[]{"status","hash"},((PrtInt)0), ((PrtString)"")));
            TMP_tmp0_3 = (PMachineValue)(((PMachineValue)((IPrtValue)log)?.Clone()));
            TMP_tmp1_1 = (PEvent)(new eAppendNewEntryToLogReq((new PrtNamedTuple(new string[]{"source","entryData","numReferences"},null, ((PrtString)""), ((PrtInt)0)))));
            TMP_tmp2_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_1 = (PrtString)(((PrtNamedTuple)req_2)["opData"]);
            TMP_tmp4_1 = (PrtInt)(((PrtInt)((IPrtValue)referenceCount)?.Clone()));
            TMP_tmp5_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","entryData","numReferences"}, TMP_tmp2_1, TMP_tmp3_1, TMP_tmp4_1)));
            currentMachine.TrySendEvent(TMP_tmp0_3, (Event)TMP_tmp1_1, TMP_tmp5_1);
            var PGEN_recvEvent = await currentMachine.TryReceiveEvent(typeof(eAppendNewEntryToLogResp), typeof(PHalt));
            switch (PGEN_recvEvent) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eAppendNewEntryToLogResp PGEN_evt: {
                    PrtNamedTuple resp = (PrtNamedTuple)(PGEN_evt.Payload);
                    TMP_tmp6_1 = (tEntry)(((PrtNamedTuple)resp)["newEntry"]);
                    TMP_tmp7_1 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp6_1)?.Clone()));
                    appendedEntry = TMP_tmp7_1;
                } break;
            }
            TMP_tmp8_1 = (PMachineValue)(((PMachineValue)((IPrtValue)sync)?.Clone()));
            TMP_tmp9_1 = (PEvent)(new eAddEntryToSyncReq((new PrtNamedTuple(new string[]{"source","entryToAdd"},null, null))));
            TMP_tmp10_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp11_1 = (tEntry)(((tEntry)((IPrtValue)appendedEntry)?.Clone()));
            TMP_tmp12_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","entryToAdd"}, TMP_tmp10_1, TMP_tmp11_1)));
            currentMachine.TrySendEvent(TMP_tmp8_1, (Event)TMP_tmp9_1, TMP_tmp12_1);
            var PGEN_recvEvent_1 = await currentMachine.TryReceiveEvent(typeof(eAddEntryToSyncResp), typeof(PHalt));
            switch (PGEN_recvEvent_1) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eAddEntryToSyncResp PGEN_evt_1: {
                    PrtNamedTuple resp_1 = (PrtNamedTuple)(PGEN_evt_1.Payload);
                    TMP_tmp13_1 = (tEntry)(((tEntry)((IPrtValue)appendedEntry)?.Clone()));
                    TMP_tmp14_1 = (PrtString)(((PrtString) String.Format("Added entry {0} to the Sync",TMP_tmp13_1)));
                    currentMachine.LogLine("" + TMP_tmp14_1);
                } break;
            }
            TMP_tmp15_1 = (PMachineValue)(((PrtNamedTuple)req_2)["source"]);
            TMP_tmp16 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp15_1)?.Clone()));
            TMP_tmp17 = (PEvent)(new eAddOperationResp((new PrtNamedTuple(new string[]{"status","hash"},((PrtInt)0), ((PrtString)"")))));
            TMP_tmp18 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp19 = (tEntry)(((tEntry)((IPrtValue)appendedEntry)?.Clone()));
            TMP_tmp20 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp19, currentMachine));
            TMP_tmp21 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","hash"}, TMP_tmp18, TMP_tmp20)));
            currentMachine.TrySendEvent(TMP_tmp16, (Event)TMP_tmp17, TMP_tmp21);
        }
        public async Task Anon_4(Event currentMachine_dequeuedEvent)
        {
            Database currentMachine = this;
            PrtNamedTuple req_3 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_4 = null;
            PEvent TMP_tmp1_2 = null;
            PMachineValue TMP_tmp2_2 = null;
            tEntry TMP_tmp3_2 = null;
            PrtNamedTuple TMP_tmp4_2 = (new PrtNamedTuple(new string[]{"source","entryToJoin"},null, null));
            tEntry TMP_tmp5_2 = null;
            PrtString TMP_tmp6_2 = ((PrtString)"");
            PMachineValue TMP_tmp7_2 = null;
            PMachineValue TMP_tmp8_2 = null;
            PEvent TMP_tmp9_2 = null;
            PrtInt TMP_tmp10_2 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp11_2 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_4 = (PMachineValue)(((PMachineValue)((IPrtValue)log)?.Clone()));
            TMP_tmp1_2 = (PEvent)(new eJoinEntryReq((new PrtNamedTuple(new string[]{"source","entryToJoin"},null, null))));
            TMP_tmp2_2 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_2 = (tEntry)(((PrtNamedTuple)req_3)["opEntry"]);
            TMP_tmp4_2 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","entryToJoin"}, TMP_tmp2_2, TMP_tmp3_2)));
            currentMachine.TrySendEvent(TMP_tmp0_4, (Event)TMP_tmp1_2, TMP_tmp4_2);
            var PGEN_recvEvent_2 = await currentMachine.TryReceiveEvent(typeof(eJoinEntryResp), typeof(PHalt));
            switch (PGEN_recvEvent_2) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eJoinEntryResp PGEN_evt_2: {
                    PrtNamedTuple resp_2 = (PrtNamedTuple)(PGEN_evt_2.Payload);
                    TMP_tmp5_2 = (tEntry)(((PrtNamedTuple)req_3)["opEntry"]);
                    TMP_tmp6_2 = (PrtString)(((PrtString) String.Format("Joined entry {0} to the log",TMP_tmp5_2)));
                    currentMachine.LogLine("" + TMP_tmp6_2);
                } break;
            }
            TMP_tmp7_2 = (PMachineValue)(((PrtNamedTuple)req_3)["source"]);
            TMP_tmp8_2 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp7_2)?.Clone()));
            TMP_tmp9_2 = (PEvent)(new eApplyOperationResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp10_2 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp11_2 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp10_2)));
            currentMachine.TrySendEvent(TMP_tmp8_2, (Event)TMP_tmp9_2, TMP_tmp11_2);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eAddOperationReq), nameof(Anon_1))]
        [OnEventDoAction(typeof(eApplyOperationReq), nameof(Anon_2))]
        class WaitForRequest : State
        {
        }
        [OnEntry(nameof(Anon_3))]
        class AddingOperation : State
        {
        }
        [OnEntry(nameof(Anon_4))]
        class ApplyingOperation : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class Sync : PMachine
    {
        private PrtSet peers = new PrtSet();
        public class ConstructorEvent : PEvent{public ConstructorEvent(IPrtValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((IPrtValue)value); }
        public Sync() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_5(Event currentMachine_dequeuedEvent)
        {
            Sync currentMachine = this;
            currentMachine.TryGotoState<Starting>();
            return;
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_5))]
        class Init : State
        {
        }
        class Starting : State
        {
        }
        class Started : State
        {
        }
        class Stopping : State
        {
        }
        class Stopped : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class MemoryStorage : PMachine
    {
        private tMemoryStorage memoryStorage = null;
        private PrtString name_1 = ((PrtString)"");
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtString val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtString)value); }
        public MemoryStorage() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_6(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtString name_2 = (PrtString)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtString TMP_tmp0_5 = ((PrtString)"");
            tMemoryStorage TMP_tmp1_3 = null;
            TMP_tmp0_5 = (PrtString)(((PrtString)((IPrtValue)name_2)?.Clone()));
            TMP_tmp1_3 = (tMemoryStorage)(GlobalFunctions.CreateMemoryStorage(TMP_tmp0_5, currentMachine));
            memoryStorage = TMP_tmp1_3;
            name_2 = (PrtString)(((PrtString)((IPrtValue)name_2)?.Clone()));
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_7(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_4 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_6 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            TMP_tmp0_6 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_4)?.Clone()));
            currentMachine.TryGotoState<PuttingValueInStorage>(TMP_tmp0_6);
            return;
        }
        public void Anon_8(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_5 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_7 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            TMP_tmp0_7 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_5)?.Clone()));
            currentMachine.TryGotoState<DeletingValueFromStorage>(TMP_tmp0_7);
            return;
        }
        public void Anon_9(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_6 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_8 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            TMP_tmp0_8 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_6)?.Clone()));
            currentMachine.TryGotoState<GettingValueFromStorage>(TMP_tmp0_8);
            return;
        }
        public void Anon_10(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_7 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_9 = (new PrtNamedTuple(new string[]{"source"},null));
            TMP_tmp0_9 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_7)?.Clone()));
            currentMachine.TryGotoState<ClearingAllDataFromStorage>(TMP_tmp0_9);
            return;
        }
        public void Anon_11(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_8 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_10 = (new PrtNamedTuple(new string[]{"source"},null));
            TMP_tmp0_10 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_8)?.Clone()));
            currentMachine.TryGotoState<GettingAllDataFromStorage>(TMP_tmp0_10);
            return;
        }
        public void Anon_12(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_9 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_11 = (new PrtNamedTuple(new string[]{"source"},null));
            TMP_tmp0_11 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_9)?.Clone()));
            currentMachine.TryGotoState<GettingDictionayFromMemoryStorage>(TMP_tmp0_11);
            return;
        }
        public void Anon_13(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_10 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tMemoryStorage TMP_tmp0_12 = null;
            PrtString TMP_tmp1_4 = ((PrtString)"");
            IPrtValue TMP_tmp2_3 = null;
            tMemoryStorage TMP_tmp3_3 = null;
            PrtString TMP_tmp4_3 = ((PrtString)"");
            IPrtValue TMP_tmp5_3 = null;
            PrtString TMP_tmp6_3 = ((PrtString)"");
            PrtString TMP_tmp7_3 = ((PrtString)"");
            PMachineValue TMP_tmp8_3 = null;
            PMachineValue TMP_tmp9_3 = null;
            PEvent TMP_tmp10_3 = null;
            PrtInt TMP_tmp11_3 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp12_2 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_12 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_4 = (PrtString)(((PrtNamedTuple)req_10)["key"]);
            TMP_tmp2_3 = (IPrtValue)(((PrtNamedTuple)req_10)["value"]);
            TMP_tmp3_3 = (tMemoryStorage)(GlobalFunctions.PutValueInMemoryStorage(TMP_tmp0_12, TMP_tmp1_4, TMP_tmp2_3, currentMachine));
            memoryStorage = TMP_tmp3_3;
            TMP_tmp4_3 = (PrtString)(((PrtNamedTuple)req_10)["key"]);
            TMP_tmp5_3 = (IPrtValue)(((PrtNamedTuple)req_10)["value"]);
            TMP_tmp6_3 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
            TMP_tmp7_3 = (PrtString)(((PrtString) String.Format("Put key {0} with value {1} in {2}",TMP_tmp4_3,TMP_tmp5_3,TMP_tmp6_3)));
            currentMachine.LogLine("" + TMP_tmp7_3);
            TMP_tmp8_3 = (PMachineValue)(((PrtNamedTuple)req_10)["source"]);
            TMP_tmp9_3 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp8_3)?.Clone()));
            TMP_tmp10_3 = (PEvent)(new ePutValueInStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp11_3 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp12_2 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp11_3)));
            currentMachine.TrySendEvent(TMP_tmp9_3, (Event)TMP_tmp10_3, TMP_tmp12_2);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_14(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_11 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple deleteResp = (new PrtNamedTuple(new string[]{"couldDelete","memoryStorage"},((PrtBool)false), null));
            tMemoryStorage TMP_tmp0_13 = null;
            PrtString TMP_tmp1_5 = ((PrtString)"");
            PrtNamedTuple TMP_tmp2_4 = (new PrtNamedTuple(new string[]{"couldDelete","memoryStorage"},((PrtBool)false), null));
            PrtBool TMP_tmp3_4 = ((PrtBool)false);
            tMemoryStorage TMP_tmp4_4 = null;
            tMemoryStorage TMP_tmp5_4 = null;
            PrtString TMP_tmp6_4 = ((PrtString)"");
            PrtString TMP_tmp7_4 = ((PrtString)"");
            PrtString TMP_tmp8_4 = ((PrtString)"");
            PMachineValue TMP_tmp9_4 = null;
            PMachineValue TMP_tmp10_4 = null;
            PEvent TMP_tmp11_4 = null;
            PrtInt TMP_tmp12_3 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp13_2 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            PrtString TMP_tmp14_2 = ((PrtString)"");
            PrtString TMP_tmp15_2 = ((PrtString)"");
            PrtString TMP_tmp16_1 = ((PrtString)"");
            PMachineValue TMP_tmp17_1 = null;
            PMachineValue TMP_tmp18_1 = null;
            PEvent TMP_tmp19_1 = null;
            PrtInt TMP_tmp20_1 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp21_1 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_13 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_5 = (PrtString)(((PrtNamedTuple)req_11)["key"]);
            TMP_tmp2_4 = (PrtNamedTuple)(GlobalFunctions.DeleteValueFromMemoryStorage(TMP_tmp0_13, TMP_tmp1_5, currentMachine));
            deleteResp = TMP_tmp2_4;
            TMP_tmp3_4 = (PrtBool)(((PrtNamedTuple)deleteResp)["couldDelete"]);
            if (TMP_tmp3_4)
            {
                TMP_tmp4_4 = (tMemoryStorage)(((PrtNamedTuple)deleteResp)["memoryStorage"]);
                TMP_tmp5_4 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)TMP_tmp4_4)?.Clone()));
                memoryStorage = TMP_tmp5_4;
                TMP_tmp6_4 = (PrtString)(((PrtNamedTuple)req_11)["key"]);
                TMP_tmp7_4 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
                TMP_tmp8_4 = (PrtString)(((PrtString) String.Format("Deleted {0} from {1}",TMP_tmp6_4,TMP_tmp7_4)));
                currentMachine.LogLine("" + TMP_tmp8_4);
                TMP_tmp9_4 = (PMachineValue)(((PrtNamedTuple)req_11)["source"]);
                TMP_tmp10_4 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp9_4)?.Clone()));
                TMP_tmp11_4 = (PEvent)(new eDeleteValueFromStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
                TMP_tmp12_3 = (PrtInt)((PrtEnum.Get("SUCCESS")));
                TMP_tmp13_2 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp12_3)));
                currentMachine.TrySendEvent(TMP_tmp10_4, (Event)TMP_tmp11_4, TMP_tmp13_2);
                currentMachine.TryGotoState<WaitForRequest>();
                return;
            }
            TMP_tmp14_2 = (PrtString)(((PrtNamedTuple)req_11)["key"]);
            TMP_tmp15_2 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
            TMP_tmp16_1 = (PrtString)(((PrtString) String.Format("{0} not in {1}",TMP_tmp14_2,TMP_tmp15_2)));
            currentMachine.LogLine("" + TMP_tmp16_1);
            TMP_tmp17_1 = (PMachineValue)(((PrtNamedTuple)req_11)["source"]);
            TMP_tmp18_1 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp17_1)?.Clone()));
            TMP_tmp19_1 = (PEvent)(new eDeleteValueFromStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp20_1 = (PrtInt)((PrtEnum.Get("ERROR")));
            TMP_tmp21_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp20_1)));
            currentMachine.TrySendEvent(TMP_tmp18_1, (Event)TMP_tmp19_1, TMP_tmp21_1);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_15(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_12 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            IPrtValue value = null;
            tMemoryStorage TMP_tmp0_14 = null;
            PrtString TMP_tmp1_6 = ((PrtString)"");
            IPrtValue TMP_tmp2_5 = null;
            PrtBool TMP_tmp3_5 = ((PrtBool)false);
            PrtString TMP_tmp4_5 = ((PrtString)"");
            PrtString TMP_tmp5_5 = ((PrtString)"");
            PrtString TMP_tmp6_5 = ((PrtString)"");
            PMachineValue TMP_tmp7_5 = null;
            PMachineValue TMP_tmp8_5 = null;
            PEvent TMP_tmp9_5 = null;
            PrtInt TMP_tmp10_5 = ((PrtInt)0);
            IPrtValue TMP_tmp11_5 = null;
            PrtNamedTuple TMP_tmp12_4 = (new PrtNamedTuple(new string[]{"status","value"},((PrtInt)0), null));
            IPrtValue TMP_tmp13_3 = null;
            PrtString TMP_tmp14_3 = ((PrtString)"");
            PrtString TMP_tmp15_3 = ((PrtString)"");
            PrtString TMP_tmp16_2 = ((PrtString)"");
            PMachineValue TMP_tmp17_2 = null;
            PMachineValue TMP_tmp18_2 = null;
            PEvent TMP_tmp19_2 = null;
            PrtInt TMP_tmp20_2 = ((PrtInt)0);
            IPrtValue TMP_tmp21_2 = null;
            PrtNamedTuple TMP_tmp22 = (new PrtNamedTuple(new string[]{"status","value"},((PrtInt)0), null));
            TMP_tmp0_14 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_6 = (PrtString)(((PrtNamedTuple)req_12)["key"]);
            TMP_tmp2_5 = (IPrtValue)(GlobalFunctions.GetValueFromMemoryStorage(TMP_tmp0_14, TMP_tmp1_6, currentMachine));
            value = TMP_tmp2_5;
            TMP_tmp3_5 = (PrtBool)((PrtValues.SafeEquals(value,((PrtBool)false))));
            if (TMP_tmp3_5)
            {
                TMP_tmp4_5 = (PrtString)(((PrtNamedTuple)req_12)["key"]);
                TMP_tmp5_5 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
                TMP_tmp6_5 = (PrtString)(((PrtString) String.Format("No value associated with key {0} in {1}",TMP_tmp4_5,TMP_tmp5_5)));
                currentMachine.LogLine("" + TMP_tmp6_5);
                TMP_tmp7_5 = (PMachineValue)(((PrtNamedTuple)req_12)["source"]);
                TMP_tmp8_5 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp7_5)?.Clone()));
                TMP_tmp9_5 = (PEvent)(new eGetValueFromStorageResp((new PrtNamedTuple(new string[]{"status","value"},((PrtInt)0), null))));
                TMP_tmp10_5 = (PrtInt)((PrtEnum.Get("ERROR")));
                TMP_tmp11_5 = (IPrtValue)(((IPrtValue)((IPrtValue)value)?.Clone()));
                TMP_tmp12_4 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","value"}, TMP_tmp10_5, TMP_tmp11_5)));
                currentMachine.TrySendEvent(TMP_tmp8_5, (Event)TMP_tmp9_5, TMP_tmp12_4);
                currentMachine.TryGotoState<WaitForRequest>();
                return;
            }
            TMP_tmp13_3 = (IPrtValue)(((IPrtValue)((IPrtValue)value)?.Clone()));
            TMP_tmp14_3 = (PrtString)(((PrtNamedTuple)req_12)["key"]);
            TMP_tmp15_3 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
            TMP_tmp16_2 = (PrtString)(((PrtString) String.Format("Got value {0} for key {1} in {2}",TMP_tmp13_3,TMP_tmp14_3,TMP_tmp15_3)));
            currentMachine.LogLine("" + TMP_tmp16_2);
            TMP_tmp17_2 = (PMachineValue)(((PrtNamedTuple)req_12)["source"]);
            TMP_tmp18_2 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp17_2)?.Clone()));
            TMP_tmp19_2 = (PEvent)(new eGetValueFromStorageResp((new PrtNamedTuple(new string[]{"status","value"},((PrtInt)0), null))));
            TMP_tmp20_2 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp21_2 = (IPrtValue)(((IPrtValue)((IPrtValue)value)?.Clone()));
            TMP_tmp22 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","value"}, TMP_tmp20_2, TMP_tmp21_2)));
            currentMachine.TrySendEvent(TMP_tmp18_2, (Event)TMP_tmp19_2, TMP_tmp22);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_16(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_13 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tMemoryStorage TMP_tmp0_15 = null;
            tMemoryStorage TMP_tmp1_7 = null;
            PrtString TMP_tmp2_6 = ((PrtString)"");
            PrtString TMP_tmp3_6 = ((PrtString)"");
            PMachineValue TMP_tmp4_6 = null;
            PMachineValue TMP_tmp5_6 = null;
            PEvent TMP_tmp6_6 = null;
            PrtInt TMP_tmp7_6 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp8_6 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_15 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_7 = (tMemoryStorage)(GlobalFunctions.ClearMemoryStorage(TMP_tmp0_15, currentMachine));
            memoryStorage = TMP_tmp1_7;
            TMP_tmp2_6 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
            TMP_tmp3_6 = (PrtString)(((PrtString) String.Format("Cleared all data from {0}",TMP_tmp2_6)));
            currentMachine.LogLine("" + TMP_tmp3_6);
            TMP_tmp4_6 = (PMachineValue)(((PrtNamedTuple)req_13)["source"]);
            TMP_tmp5_6 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp4_6)?.Clone()));
            TMP_tmp6_6 = (PEvent)(new eClearAllValuesFromStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp7_6 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp8_6 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp7_6)));
            currentMachine.TrySendEvent(TMP_tmp5_6, (Event)TMP_tmp6_6, TMP_tmp8_6);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_17(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_14 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq retrievedValues = new PrtSeq();
            tMemoryStorage TMP_tmp0_16 = null;
            PrtSeq TMP_tmp1_8 = new PrtSeq();
            PrtSeq TMP_tmp2_7 = new PrtSeq();
            PrtInt TMP_tmp3_7 = ((PrtInt)0);
            PrtString TMP_tmp4_7 = ((PrtString)"");
            PrtString TMP_tmp5_7 = ((PrtString)"");
            PMachineValue TMP_tmp6_7 = null;
            PMachineValue TMP_tmp7_7 = null;
            PEvent TMP_tmp8_7 = null;
            PrtInt TMP_tmp9_6 = ((PrtInt)0);
            PrtSeq TMP_tmp10_6 = new PrtSeq();
            PrtNamedTuple TMP_tmp11_6 = (new PrtNamedTuple(new string[]{"status","retrievedValues"},((PrtInt)0), new PrtSeq()));
            TMP_tmp0_16 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_8 = (PrtSeq)(GlobalFunctions.GetAllValuesFromMemoryStorage(TMP_tmp0_16, currentMachine));
            TMP_tmp2_7 = (PrtSeq)(((PrtSeq)((PrtSeq)((IPrtValue)TMP_tmp1_8)?.Clone())));
            retrievedValues = TMP_tmp2_7;
            TMP_tmp3_7 = (PrtInt)(((PrtInt)(retrievedValues).Count));
            TMP_tmp4_7 = (PrtString)(((PrtString)((IPrtValue)name_1)?.Clone()));
            TMP_tmp5_7 = (PrtString)(((PrtString) String.Format("Retrieved {0} values from {1}",TMP_tmp3_7,TMP_tmp4_7)));
            currentMachine.LogLine("" + TMP_tmp5_7);
            TMP_tmp6_7 = (PMachineValue)(((PrtNamedTuple)req_14)["source"]);
            TMP_tmp7_7 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp6_7)?.Clone()));
            TMP_tmp8_7 = (PEvent)(new eGetAllValuesFromStorageResp((new PrtNamedTuple(new string[]{"status","retrievedValues"},((PrtInt)0), new PrtSeq()))));
            TMP_tmp9_6 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp10_6 = (PrtSeq)(((PrtSeq)((IPrtValue)retrievedValues)?.Clone()));
            TMP_tmp11_6 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","retrievedValues"}, TMP_tmp9_6, TMP_tmp10_6)));
            currentMachine.TrySendEvent(TMP_tmp7_7, (Event)TMP_tmp8_7, TMP_tmp11_6);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_18(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_15 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtMap dictionary = new PrtMap();
            tMemoryStorage TMP_tmp0_17 = null;
            PrtMap TMP_tmp1_9 = new PrtMap();
            PMachineValue TMP_tmp2_8 = null;
            PMachineValue TMP_tmp3_8 = null;
            PEvent TMP_tmp4_8 = null;
            PrtInt TMP_tmp5_8 = ((PrtInt)0);
            PrtMap TMP_tmp6_8 = new PrtMap();
            PrtNamedTuple TMP_tmp7_8 = (new PrtNamedTuple(new string[]{"status","dictionary"},((PrtInt)0), new PrtMap()));
            TMP_tmp0_17 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_9 = (PrtMap)(GlobalFunctions.GetDictionaryFromMemoryStorage(TMP_tmp0_17, currentMachine));
            dictionary = TMP_tmp1_9;
            TMP_tmp2_8 = (PMachineValue)(((PrtNamedTuple)req_15)["source"]);
            TMP_tmp3_8 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_8)?.Clone()));
            TMP_tmp4_8 = (PEvent)(new eGetDictionaryFromMemoryStorageResp((new PrtNamedTuple(new string[]{"status","dictionary"},((PrtInt)0), new PrtMap()))));
            TMP_tmp5_8 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_8 = (PrtMap)(((PrtMap)((IPrtValue)dictionary)?.Clone()));
            TMP_tmp7_8 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","dictionary"}, TMP_tmp5_8, TMP_tmp6_8)));
            currentMachine.TrySendEvent(TMP_tmp3_8, (Event)TMP_tmp4_8, TMP_tmp7_8);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_6))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(ePutValueInStorageReq), nameof(Anon_7))]
        [OnEventDoAction(typeof(eDeleteValueFromStorageReq), nameof(Anon_8))]
        [OnEventDoAction(typeof(eGetValueFromStorageReq), nameof(Anon_9))]
        [OnEventDoAction(typeof(eClearAllValuesFromStorageReq), nameof(Anon_10))]
        [OnEventDoAction(typeof(eGetAllValuesFromStorageReq), nameof(Anon_11))]
        [OnEventDoAction(typeof(eGetDictionaryFromMemoryStorageReq), nameof(Anon_12))]
        class WaitForRequest : State
        {
        }
        [OnEntry(nameof(Anon_13))]
        class PuttingValueInStorage : State
        {
        }
        [OnEntry(nameof(Anon_14))]
        class DeletingValueFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_15))]
        class GettingValueFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_16))]
        class ClearingAllDataFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_17))]
        class GettingAllDataFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_18))]
        class GettingDictionayFromMemoryStorage : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class Heads : PMachine
    {
        private PMachineValue storage = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtNamedTuple val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtNamedTuple)value); }
        public Heads() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
        }
        
        public async Task Anon_19(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple init_1 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_18 = null;
            PMachineValue TMP_tmp1_10 = null;
            PrtSeq TMP_tmp2_9 = new PrtSeq();
            TMP_tmp0_18 = (PMachineValue)(((PrtNamedTuple)init_1)["headsStorage"]);
            TMP_tmp1_10 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp0_18)?.Clone()));
            storage = TMP_tmp1_10;
            TMP_tmp2_9 = (PrtSeq)(((PrtNamedTuple)init_1)["heads"]);
            await PutHeads(TMP_tmp2_9);
            currentMachine.TryGotoState<Active>();
            return;
        }
        public async Task Anon_20(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_16 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq TMP_tmp0_19 = new PrtSeq();
            PMachineValue TMP_tmp1_11 = null;
            PMachineValue TMP_tmp2_10 = null;
            PEvent TMP_tmp3_9 = null;
            PrtInt TMP_tmp4_9 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp5_9 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_19 = (PrtSeq)(((PrtNamedTuple)req_16)["entries"]);
            await PutHeads(TMP_tmp0_19);
            TMP_tmp1_11 = (PMachineValue)(((PrtNamedTuple)req_16)["source"]);
            TMP_tmp2_10 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_11)?.Clone()));
            TMP_tmp3_9 = (PEvent)(new ePutEntriesInHeadsResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp4_9 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_9 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp4_9)));
            currentMachine.TrySendEvent(TMP_tmp2_10, (Event)TMP_tmp3_9, TMP_tmp5_9);
        }
        public async Task Anon_21(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_17 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq TMP_tmp0_20 = new PrtSeq();
            PMachineValue TMP_tmp1_12 = null;
            PMachineValue TMP_tmp2_11 = null;
            PEvent TMP_tmp3_10 = null;
            PrtInt TMP_tmp4_10 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp5_10 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_20 = (PrtSeq)(((PrtNamedTuple)req_17)["entries"]);
            await SetHeads(TMP_tmp0_20);
            TMP_tmp1_12 = (PMachineValue)(((PrtNamedTuple)req_17)["source"]);
            TMP_tmp2_11 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_12)?.Clone()));
            TMP_tmp3_10 = (PEvent)(new eSetEntriesInHeadsResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp4_10 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_10 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp4_10)));
            currentMachine.TrySendEvent(TMP_tmp2_11, (Event)TMP_tmp3_10, TMP_tmp5_10);
        }
        public async Task Anon_22(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_18 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq newHeads = new PrtSeq();
            tEntry TMP_tmp0_21 = null;
            PrtSeq TMP_tmp1_13 = new PrtSeq();
            PMachineValue TMP_tmp2_12 = null;
            PMachineValue TMP_tmp3_11 = null;
            PEvent TMP_tmp4_11 = null;
            PrtInt TMP_tmp5_11 = ((PrtInt)0);
            PrtSeq TMP_tmp6_9 = new PrtSeq();
            PrtNamedTuple TMP_tmp7_9 = (new PrtNamedTuple(new string[]{"status","newHeads"},((PrtInt)0), new PrtSeq()));
            TMP_tmp0_21 = (tEntry)(((PrtNamedTuple)req_18)["headEntry"]);
            TMP_tmp1_13 = (PrtSeq)(await AddHead(TMP_tmp0_21));
            newHeads = TMP_tmp1_13;
            TMP_tmp2_12 = (PMachineValue)(((PrtNamedTuple)req_18)["source"]);
            TMP_tmp3_11 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_12)?.Clone()));
            TMP_tmp4_11 = (PEvent)(new eAddEntryToHeadsResp((new PrtNamedTuple(new string[]{"status","newHeads"},((PrtInt)0), new PrtSeq()))));
            TMP_tmp5_11 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_9 = (PrtSeq)(((PrtSeq)((IPrtValue)newHeads)?.Clone()));
            TMP_tmp7_9 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","newHeads"}, TMP_tmp5_11, TMP_tmp6_9)));
            currentMachine.TrySendEvent(TMP_tmp3_11, (Event)TMP_tmp4_11, TMP_tmp7_9);
        }
        public async Task Anon_23(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_19 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_22 = null;
            PMachineValue TMP_tmp1_14 = null;
            PEvent TMP_tmp2_13 = null;
            PrtInt TMP_tmp3_12 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp4_12 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            await ClearHeads();
            TMP_tmp0_22 = (PMachineValue)(((PrtNamedTuple)req_19)["source"]);
            TMP_tmp1_14 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp0_22)?.Clone()));
            TMP_tmp2_13 = (PEvent)(new eClearAllEntriesFromHeadsResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp3_12 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp4_12 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp3_12)));
            currentMachine.TrySendEvent(TMP_tmp1_14, (Event)TMP_tmp2_13, TMP_tmp4_12);
        }
        public async Task Anon_24(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_20 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq allHeads = new PrtSeq();
            PrtSeq TMP_tmp0_23 = new PrtSeq();
            PMachineValue TMP_tmp1_15 = null;
            PMachineValue TMP_tmp2_14 = null;
            PEvent TMP_tmp3_13 = null;
            PrtInt TMP_tmp4_13 = ((PrtInt)0);
            PrtSeq TMP_tmp5_12 = new PrtSeq();
            PrtNamedTuple TMP_tmp6_10 = (new PrtNamedTuple(new string[]{"status","retrievedValues"},((PrtInt)0), new PrtSeq()));
            TMP_tmp0_23 = (PrtSeq)(await GetAllHeads());
            allHeads = TMP_tmp0_23;
            TMP_tmp1_15 = (PMachineValue)(((PrtNamedTuple)req_20)["source"]);
            TMP_tmp2_14 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_15)?.Clone()));
            TMP_tmp3_13 = (PEvent)(new eGetAllEntriesFromHeadsResp((new PrtNamedTuple(new string[]{"status","retrievedValues"},((PrtInt)0), new PrtSeq()))));
            TMP_tmp4_13 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_12 = (PrtSeq)(((PrtSeq)((IPrtValue)allHeads)?.Clone()));
            TMP_tmp6_10 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","retrievedValues"}, TMP_tmp4_13, TMP_tmp5_12)));
            currentMachine.TrySendEvent(TMP_tmp2_14, (Event)TMP_tmp3_13, TMP_tmp6_10);
        }
        public async Task PutHeads(PrtSeq entries)
        {
            Heads currentMachine = this;
            PrtSeq heads = new PrtSeq();
            tEntry head = null;
            PrtInt numToPut = ((PrtInt)0);
            PrtInt TMP_tmp0_24 = ((PrtInt)0);
            PrtString TMP_tmp1_16 = ((PrtString)"");
            PrtSeq TMP_tmp2_15 = new PrtSeq();
            PrtSeq TMP_tmp3_14 = new PrtSeq();
            PrtInt TMP_tmp4_14 = ((PrtInt)0);
            PrtString TMP_tmp5_13 = ((PrtString)"");
            PrtSeq TMP_tmp6_11 = new PrtSeq();
            PrtInt TMP_i_head_tmp7 = ((PrtInt)0);
            PrtInt sizeof_head_tmp8 = ((PrtInt)0);
            PrtInt TMP_tmp9_7 = ((PrtInt)0);
            PrtInt TMP_tmp10_7 = ((PrtInt)0);
            PrtBool TMP_tmp11_7 = ((PrtBool)false);
            PrtBool TMP_tmp12_5 = ((PrtBool)false);
            PrtInt TMP_tmp13_4 = ((PrtInt)0);
            tEntry TMP_tmp14_4 = null;
            tEntry TMP_tmp15_4 = null;
            PMachineValue TMP_tmp16_3 = null;
            PEvent TMP_tmp17_3 = null;
            PMachineValue TMP_tmp18_3 = null;
            tEntry TMP_tmp19_3 = null;
            PrtString TMP_tmp20_3 = ((PrtString)"");
            tEntry TMP_tmp21_3 = null;
            PrtNamedTuple TMP_tmp22_1 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            tEntry TMP_tmp23 = null;
            PrtString TMP_tmp24 = ((PrtString)"");
            TMP_tmp0_24 = (PrtInt)(((PrtInt)(entries).Count));
            TMP_tmp1_16 = (PrtString)(((PrtString) String.Format("PUTTING {0} ENTRIES IN HEADS",TMP_tmp0_24)));
            currentMachine.LogLine("" + TMP_tmp1_16);
            TMP_tmp2_15 = (PrtSeq)(((PrtSeq)((IPrtValue)entries)?.Clone()));
            TMP_tmp3_14 = (PrtSeq)(GlobalFunctions.FindHeads(TMP_tmp2_15, currentMachine));
            heads = TMP_tmp3_14;
            TMP_tmp4_14 = (PrtInt)(((PrtInt)(heads).Count));
            TMP_tmp5_13 = (PrtString)(((PrtString) String.Format("Found {0} heads from the entries",TMP_tmp4_14)));
            currentMachine.LogLine("" + TMP_tmp5_13);
            TMP_tmp6_11 = (PrtSeq)(((PrtSeq)((IPrtValue)heads)?.Clone()));
            TMP_i_head_tmp7 = (PrtInt)(((PrtInt)(-1)));
            TMP_tmp9_7 = (PrtInt)(((PrtInt)(TMP_tmp6_11).Count));
            sizeof_head_tmp8 = TMP_tmp9_7;
            while (((PrtBool)true))
            {
                TMP_tmp10_7 = (PrtInt)((sizeof_head_tmp8) - (((PrtInt)(1))));
                TMP_tmp11_7 = (PrtBool)((TMP_i_head_tmp7) < (TMP_tmp10_7));
                TMP_tmp12_5 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp11_7)?.Clone()));
                if (TMP_tmp12_5)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp13_4 = (PrtInt)((TMP_i_head_tmp7) + (((PrtInt)(1))));
                TMP_i_head_tmp7 = TMP_tmp13_4;
                TMP_tmp14_4 = (tEntry)(((PrtSeq)TMP_tmp6_11)[TMP_i_head_tmp7]);
                TMP_tmp15_4 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp14_4)?.Clone()));
                head = TMP_tmp15_4;
                TMP_tmp16_3 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
                TMP_tmp17_3 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
                TMP_tmp18_3 = (PMachineValue)(currentMachine.self);
                TMP_tmp19_3 = (tEntry)(((tEntry)((IPrtValue)head)?.Clone()));
                TMP_tmp20_3 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp19_3, currentMachine));
                TMP_tmp21_3 = (tEntry)(((tEntry)((IPrtValue)head)?.Clone()));
                TMP_tmp22_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp18_3, TMP_tmp20_3, TMP_tmp21_3)));
                currentMachine.TrySendEvent(TMP_tmp16_3, (Event)TMP_tmp17_3, TMP_tmp22_1);
                var PGEN_recvEvent_3 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
                switch (PGEN_recvEvent_3) {
                    case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                    case ePutValueInStorageResp PGEN_evt_3: {
                        PrtNamedTuple resp_3 = (PrtNamedTuple)(PGEN_evt_3.Payload);
                        TMP_tmp23 = (tEntry)(((tEntry)((IPrtValue)head)?.Clone()));
                        TMP_tmp24 = (PrtString)(((PrtString) String.Format("Head {0} put in heads storage",TMP_tmp23)));
                        currentMachine.LogLine("" + TMP_tmp24);
                    } break;
                }
            }
        }
        public async Task SetHeads(PrtSeq entries_1)
        {
            Heads currentMachine = this;
            PrtInt TMP_tmp0_25 = ((PrtInt)0);
            PrtString TMP_tmp1_17 = ((PrtString)"");
            PMachineValue TMP_tmp2_16 = null;
            PEvent TMP_tmp3_15 = null;
            PMachineValue TMP_tmp4_15 = null;
            PrtNamedTuple TMP_tmp5_14 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtString TMP_tmp6_12 = ((PrtString)"");
            PrtSeq TMP_tmp7_10 = new PrtSeq();
            TMP_tmp0_25 = (PrtInt)(((PrtInt)(entries_1).Count));
            TMP_tmp1_17 = (PrtString)(((PrtString) String.Format("SETTING {0} ENTRIES IN HEADS",TMP_tmp0_25)));
            currentMachine.LogLine("" + TMP_tmp1_17);
            TMP_tmp2_16 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp3_15 = (PEvent)(new eClearAllValuesFromStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp4_15 = (PMachineValue)(currentMachine.self);
            TMP_tmp5_14 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp4_15)));
            currentMachine.TrySendEvent(TMP_tmp2_16, (Event)TMP_tmp3_15, TMP_tmp5_14);
            var PGEN_recvEvent_4 = await currentMachine.TryReceiveEvent(typeof(eClearAllValuesFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_4) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eClearAllValuesFromStorageResp PGEN_evt_4: {
                    PrtNamedTuple resp_4 = (PrtNamedTuple)(PGEN_evt_4.Payload);
                    TMP_tmp6_12 = (PrtString)(((PrtString) String.Format("Cleared all heads from heads storage")));
                    currentMachine.LogLine("" + TMP_tmp6_12);
                } break;
            }
            TMP_tmp7_10 = (PrtSeq)(((PrtSeq)((IPrtValue)entries_1)?.Clone()));
            await PutHeads(TMP_tmp7_10);
        }
        public async Task<PrtSeq> GetAllHeads()
        {
            Heads currentMachine = this;
            PrtSeq returnValues = new PrtSeq();
            PMachineValue TMP_tmp0_26 = null;
            PEvent TMP_tmp1_18 = null;
            PMachineValue TMP_tmp2_17 = null;
            PrtNamedTuple TMP_tmp3_16 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtSeq TMP_tmp4_16 = new PrtSeq();
            PrtInt TMP_tmp5_15 = ((PrtInt)0);
            PrtString TMP_tmp6_13 = ((PrtString)"");
            PrtSeq TMP_tmp7_11 = new PrtSeq();
            PrtSeq TMP_tmp8_8 = new PrtSeq();
            TMP_tmp0_26 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp1_18 = (PEvent)(new eGetAllValuesFromStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_17 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_16 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_17)));
            currentMachine.TrySendEvent(TMP_tmp0_26, (Event)TMP_tmp1_18, TMP_tmp3_16);
            var PGEN_recvEvent_5 = await currentMachine.TryReceiveEvent(typeof(eGetAllValuesFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_5) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetAllValuesFromStorageResp PGEN_evt_5: {
                    PrtNamedTuple resp_5 = (PrtNamedTuple)(PGEN_evt_5.Payload);
                    TMP_tmp4_16 = (PrtSeq)(((PrtNamedTuple)resp_5)["retrievedValues"]);
                    TMP_tmp5_15 = (PrtInt)(((PrtInt)(TMP_tmp4_16).Count));
                    TMP_tmp6_13 = (PrtString)(((PrtString) String.Format("Got {0} heads from heads storage",TMP_tmp5_15)));
                    currentMachine.LogLine("" + TMP_tmp6_13);
                    TMP_tmp7_11 = (PrtSeq)(((PrtNamedTuple)resp_5)["retrievedValues"]);
                    TMP_tmp8_8 = (PrtSeq)(((PrtSeq)((PrtSeq)((IPrtValue)TMP_tmp7_11)?.Clone())));
                    returnValues = TMP_tmp8_8;
                } break;
            }
            return ((PrtSeq)((IPrtValue)returnValues)?.Clone());
        }
        public async Task<PrtSeq> AddHead(tEntry head_1)
        {
            Heads currentMachine = this;
            PrtSeq retrievedHeads = new PrtSeq();
            PrtSeq newHeads_1 = new PrtSeq();
            PrtSeq combinedHeadsToFind = new PrtSeq();
            PrtSeq TMP_tmp0_27 = new PrtSeq();
            PrtBool TMP_tmp1_19 = ((PrtBool)false);
            tEntry TMP_tmp2_18 = null;
            PrtString TMP_tmp3_17 = ((PrtString)"");
            tEntry TMP_tmp4_17 = null;
            PrtSeq TMP_tmp5_16 = new PrtSeq();
            PrtSeq TMP_tmp6_14 = new PrtSeq();
            PrtSeq TMP_tmp7_12 = new PrtSeq();
            tEntry TMP_tmp8_9 = null;
            PrtString TMP_tmp9_8 = ((PrtString)"");
            TMP_tmp0_27 = (PrtSeq)(await GetAllHeads());
            retrievedHeads = TMP_tmp0_27;
            combinedHeadsToFind = (PrtSeq)(((PrtSeq)((IPrtValue)retrievedHeads)?.Clone()));
            TMP_tmp1_19 = (PrtBool)(((PrtBool)(((PrtSeq)retrievedHeads).Contains(head_1))));
            if (TMP_tmp1_19)
            {
                TMP_tmp2_18 = (tEntry)(((tEntry)((IPrtValue)head_1)?.Clone()));
                TMP_tmp3_17 = (PrtString)(((PrtString) String.Format("Head {0} already in head storage",TMP_tmp2_18)));
                currentMachine.LogLine("" + TMP_tmp3_17);
                return ((PrtSeq)((IPrtValue)retrievedHeads)?.Clone());
            }
            combinedHeadsToFind = (PrtSeq)(((PrtSeq)((IPrtValue)retrievedHeads)?.Clone()));
            TMP_tmp4_17 = (tEntry)(((tEntry)((IPrtValue)head_1)?.Clone()));
            ((PrtSeq)combinedHeadsToFind).Insert(((PrtInt)(0)), TMP_tmp4_17);
            TMP_tmp5_16 = (PrtSeq)(((PrtSeq)((IPrtValue)combinedHeadsToFind)?.Clone()));
            TMP_tmp6_14 = (PrtSeq)(GlobalFunctions.FindHeads(TMP_tmp5_16, currentMachine));
            newHeads_1 = TMP_tmp6_14;
            TMP_tmp7_12 = (PrtSeq)(((PrtSeq)((IPrtValue)newHeads_1)?.Clone()));
            await SetHeads(TMP_tmp7_12);
            TMP_tmp8_9 = (tEntry)(((tEntry)((IPrtValue)head_1)?.Clone()));
            TMP_tmp9_8 = (PrtString)(((PrtString) String.Format("Successfully added head {0} to heads storage",TMP_tmp8_9)));
            currentMachine.LogLine("" + TMP_tmp9_8);
            return ((PrtSeq)((IPrtValue)newHeads_1)?.Clone());
        }
        public async Task ClearHeads()
        {
            Heads currentMachine = this;
            PMachineValue TMP_tmp0_28 = null;
            PEvent TMP_tmp1_20 = null;
            PMachineValue TMP_tmp2_19 = null;
            PrtNamedTuple TMP_tmp3_18 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtString TMP_tmp4_18 = ((PrtString)"");
            TMP_tmp0_28 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp1_20 = (PEvent)(new eClearAllValuesFromStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_19 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_18 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_19)));
            currentMachine.TrySendEvent(TMP_tmp0_28, (Event)TMP_tmp1_20, TMP_tmp3_18);
            var PGEN_recvEvent_6 = await currentMachine.TryReceiveEvent(typeof(eClearAllValuesFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_6) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eClearAllValuesFromStorageResp PGEN_evt_6: {
                    PrtNamedTuple resp_6 = (PrtNamedTuple)(PGEN_evt_6.Payload);
                    TMP_tmp4_18 = (PrtString)(((PrtString) String.Format("Cleared all heads from heads storage")));
                    currentMachine.LogLine("" + TMP_tmp4_18);
                } break;
            }
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_19))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(ePutEntriesInHeadsReq), nameof(Anon_20))]
        [OnEventDoAction(typeof(eSetEntriesInHeadsReq), nameof(Anon_21))]
        [OnEventDoAction(typeof(eAddEntryToHeadsReq), nameof(Anon_22))]
        [OnEventDoAction(typeof(eClearAllEntriesFromHeadsReq), nameof(Anon_23))]
        [OnEventDoAction(typeof(eGetAllEntriesFromHeadsReq), nameof(Anon_24))]
        class Active : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class Log : PMachine
    {
        private PrtString identity_1 = ((PrtString)"");
        private PrtString logId = ((PrtString)"");
        private PMachineValue clock = null;
        private PMachineValue entries_2 = null;
        private PMachineValue index = null;
        private PMachineValue heads_1 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtNamedTuple val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtNamedTuple)value); }
        public Log() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
            this.creates.Add(nameof(I_Heads));
        }
        
        public void Anon_25(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple init_2 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtString TMP_tmp0_29 = ((PrtString)"");
            PrtString TMP_tmp1_21 = ((PrtString)"");
            PrtString TMP_tmp2_20 = ((PrtString)"");
            PrtString TMP_tmp3_19 = ((PrtString)"");
            PMachineValue TMP_tmp4_19 = null;
            PMachineValue TMP_tmp5_17 = null;
            PMachineValue TMP_tmp6_15 = null;
            PMachineValue TMP_tmp7_13 = null;
            PMachineValue TMP_tmp8_10 = null;
            PrtSeq TMP_tmp9_9 = new PrtSeq();
            PrtNamedTuple TMP_tmp10_8 = (new PrtNamedTuple(new string[]{"headsStorage","heads"},null, new PrtSeq()));
            PMachineValue TMP_tmp11_8 = null;
            PMachineValue TMP_tmp12_6 = null;
            PMachineValue TMP_tmp13_5 = null;
            TMP_tmp0_29 = (PrtString)(((PrtNamedTuple)init_2)["identity"]);
            TMP_tmp1_21 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp0_29)?.Clone()));
            identity_1 = TMP_tmp1_21;
            TMP_tmp2_20 = (PrtString)(((PrtNamedTuple)init_2)["logId"]);
            TMP_tmp3_19 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp2_20)?.Clone()));
            logId = TMP_tmp3_19;
            TMP_tmp4_19 = (PMachineValue)(((PrtNamedTuple)init_2)["clock"]);
            TMP_tmp5_17 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp4_19)?.Clone()));
            clock = TMP_tmp5_17;
            TMP_tmp6_15 = (PMachineValue)(((PrtNamedTuple)init_2)["entryStorage"]);
            TMP_tmp7_13 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp6_15)?.Clone()));
            entries_2 = TMP_tmp7_13;
            TMP_tmp8_10 = (PMachineValue)(((PrtNamedTuple)init_2)["headsStorage"]);
            TMP_tmp9_9 = (PrtSeq)(((PrtNamedTuple)init_2)["logHeads"]);
            TMP_tmp10_8 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"headsStorage","heads"}, TMP_tmp8_10, TMP_tmp9_9)));
            TMP_tmp11_8 = (PMachineValue)(currentMachine.CreateInterface<I_Heads>( currentMachine, TMP_tmp10_8));
            heads_1 = TMP_tmp11_8;
            TMP_tmp12_6 = (PMachineValue)(((PrtNamedTuple)init_2)["indexStorage"]);
            TMP_tmp13_5 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp12_6)?.Clone()));
            index = TMP_tmp13_5;
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public async Task Anon_26(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_21 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp lastTimestamp = null;
            tTimestamp TMP_tmp0_30 = null;
            PMachineValue TMP_tmp1_22 = null;
            PMachineValue TMP_tmp2_21 = null;
            PEvent TMP_tmp3_20 = null;
            PrtInt TMP_tmp4_20 = ((PrtInt)0);
            tTimestamp TMP_tmp5_18 = null;
            PrtNamedTuple TMP_tmp6_16 = (new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null));
            TMP_tmp0_30 = (tTimestamp)(await GetClockLastState());
            lastTimestamp = TMP_tmp0_30;
            TMP_tmp1_22 = (PMachineValue)(((PrtNamedTuple)req_21)["source"]);
            TMP_tmp2_21 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_22)?.Clone()));
            TMP_tmp3_20 = (PEvent)(new eGetClockLastStateResp((new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null))));
            TMP_tmp4_20 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_18 = (tTimestamp)(((tTimestamp)((IPrtValue)lastTimestamp)?.Clone()));
            TMP_tmp6_16 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","lastTimestamp"}, TMP_tmp4_20, TMP_tmp5_18)));
            currentMachine.TrySendEvent(TMP_tmp2_21, (Event)TMP_tmp3_20, TMP_tmp6_16);
        }
        public async Task Anon_27(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_22 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq heads_2 = new PrtSeq();
            PrtSeq TMP_tmp0_31 = new PrtSeq();
            PMachineValue TMP_tmp1_23 = null;
            PMachineValue TMP_tmp2_22 = null;
            PEvent TMP_tmp3_21 = null;
            PrtInt TMP_tmp4_21 = ((PrtInt)0);
            PrtSeq TMP_tmp5_19 = new PrtSeq();
            PrtNamedTuple TMP_tmp6_17 = (new PrtNamedTuple(new string[]{"status","heads"},((PrtInt)0), new PrtSeq()));
            TMP_tmp0_31 = (PrtSeq)(await GetHeadsFromLog());
            heads_2 = TMP_tmp0_31;
            TMP_tmp1_23 = (PMachineValue)(((PrtNamedTuple)req_22)["source"]);
            TMP_tmp2_22 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_23)?.Clone()));
            TMP_tmp3_21 = (PEvent)(new eGetHeadsFromLogResp((new PrtNamedTuple(new string[]{"status","heads"},((PrtInt)0), new PrtSeq()))));
            TMP_tmp4_21 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_19 = (PrtSeq)(((PrtSeq)((IPrtValue)heads_2)?.Clone()));
            TMP_tmp6_17 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","heads"}, TMP_tmp4_21, TMP_tmp5_19)));
            currentMachine.TrySendEvent(TMP_tmp2_22, (Event)TMP_tmp3_21, TMP_tmp6_17);
        }
        public async Task Anon_28(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_23 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq entries_3 = new PrtSeq();
            PrtSeq TMP_tmp0_32 = new PrtSeq();
            PMachineValue TMP_tmp1_24 = null;
            PMachineValue TMP_tmp2_23 = null;
            PEvent TMP_tmp3_22 = null;
            PrtInt TMP_tmp4_22 = ((PrtInt)0);
            PrtSeq TMP_tmp5_20 = new PrtSeq();
            PrtNamedTuple TMP_tmp6_18 = (new PrtNamedTuple(new string[]{"status","entries"},((PrtInt)0), new PrtSeq()));
            TMP_tmp0_32 = (PrtSeq)(await GetAllEntriesFromLog());
            entries_3 = TMP_tmp0_32;
            TMP_tmp1_24 = (PMachineValue)(((PrtNamedTuple)req_23)["source"]);
            TMP_tmp2_23 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_24)?.Clone()));
            TMP_tmp3_22 = (PEvent)(new eGetAllEntriesFromLogResp((new PrtNamedTuple(new string[]{"status","entries"},((PrtInt)0), new PrtSeq()))));
            TMP_tmp4_22 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_20 = (PrtSeq)(((PrtSeq)((IPrtValue)entries_3)?.Clone()));
            TMP_tmp6_18 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","entries"}, TMP_tmp4_22, TMP_tmp5_20)));
            currentMachine.TrySendEvent(TMP_tmp2_23, (Event)TMP_tmp3_22, TMP_tmp6_18);
        }
        public async Task Anon_29(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_24 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            IPrtValue value_1 = null;
            PrtString TMP_tmp0_33 = ((PrtString)"");
            IPrtValue TMP_tmp1_25 = null;
            PrtBool TMP_tmp2_24 = ((PrtBool)false);
            PMachineValue TMP_tmp3_23 = null;
            PMachineValue TMP_tmp4_23 = null;
            PEvent TMP_tmp5_21 = null;
            PrtInt TMP_tmp6_19 = ((PrtInt)0);
            IPrtValue TMP_tmp7_14 = null;
            PrtNamedTuple TMP_tmp8_11 = (new PrtNamedTuple(new string[]{"status","foundValue"},((PrtInt)0), null));
            PMachineValue TMP_tmp9_10 = null;
            PMachineValue TMP_tmp10_9 = null;
            PEvent TMP_tmp11_9 = null;
            PrtInt TMP_tmp12_7 = ((PrtInt)0);
            IPrtValue TMP_tmp13_6 = null;
            PrtNamedTuple TMP_tmp14_5 = (new PrtNamedTuple(new string[]{"status","foundValue"},((PrtInt)0), null));
            TMP_tmp0_33 = (PrtString)(((PrtNamedTuple)req_24)["hash"]);
            TMP_tmp1_25 = (IPrtValue)(await GetEntryFromLog(TMP_tmp0_33));
            value_1 = TMP_tmp1_25;
            TMP_tmp2_24 = (PrtBool)((PrtValues.SafeEquals(value_1,((PrtBool)false))));
            if (TMP_tmp2_24)
            {
                TMP_tmp3_23 = (PMachineValue)(((PrtNamedTuple)req_24)["source"]);
                TMP_tmp4_23 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_23)?.Clone()));
                TMP_tmp5_21 = (PEvent)(new eGetEntryFromLogResp((new PrtNamedTuple(new string[]{"status","foundValue"},((PrtInt)0), null))));
                TMP_tmp6_19 = (PrtInt)((PrtEnum.Get("ERROR")));
                TMP_tmp7_14 = (IPrtValue)(((IPrtValue)((IPrtValue)value_1)?.Clone()));
                TMP_tmp8_11 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","foundValue"}, TMP_tmp6_19, TMP_tmp7_14)));
                currentMachine.TrySendEvent(TMP_tmp4_23, (Event)TMP_tmp5_21, TMP_tmp8_11);
                currentMachine.TryGotoState<WaitForRequest>();
                return;
            }
            TMP_tmp9_10 = (PMachineValue)(((PrtNamedTuple)req_24)["source"]);
            TMP_tmp10_9 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp9_10)?.Clone()));
            TMP_tmp11_9 = (PEvent)(new eGetEntryFromLogResp((new PrtNamedTuple(new string[]{"status","foundValue"},((PrtInt)0), null))));
            TMP_tmp12_7 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp13_6 = (IPrtValue)(((IPrtValue)((IPrtValue)value_1)?.Clone()));
            TMP_tmp14_5 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","foundValue"}, TMP_tmp12_7, TMP_tmp13_6)));
            currentMachine.TrySendEvent(TMP_tmp10_9, (Event)TMP_tmp11_9, TMP_tmp14_5);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public async Task Anon_30(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_25 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool hasEntry = ((PrtBool)false);
            PrtString TMP_tmp0_34 = ((PrtString)"");
            PrtBool TMP_tmp1_26 = ((PrtBool)false);
            PrtBool TMP_tmp2_25 = ((PrtBool)false);
            PMachineValue TMP_tmp3_24 = null;
            PMachineValue TMP_tmp4_24 = null;
            PEvent TMP_tmp5_22 = null;
            PrtInt TMP_tmp6_20 = ((PrtInt)0);
            PrtBool TMP_tmp7_15 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp8_12 = (new PrtNamedTuple(new string[]{"status","hasEntry"},((PrtInt)0), ((PrtBool)false)));
            PMachineValue TMP_tmp9_11 = null;
            PMachineValue TMP_tmp10_10 = null;
            PEvent TMP_tmp11_10 = null;
            PrtInt TMP_tmp12_8 = ((PrtInt)0);
            PrtBool TMP_tmp13_7 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp14_6 = (new PrtNamedTuple(new string[]{"status","hasEntry"},((PrtInt)0), ((PrtBool)false)));
            TMP_tmp0_34 = (PrtString)(((PrtNamedTuple)req_25)["hash"]);
            TMP_tmp1_26 = (PrtBool)(await LogHasEntry(TMP_tmp0_34));
            hasEntry = TMP_tmp1_26;
            TMP_tmp2_25 = (PrtBool)((PrtValues.SafeEquals(hasEntry,((PrtBool)true))));
            if (TMP_tmp2_25)
            {
                TMP_tmp3_24 = (PMachineValue)(((PrtNamedTuple)req_25)["source"]);
                TMP_tmp4_24 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_24)?.Clone()));
                TMP_tmp5_22 = (PEvent)(new eDoesLogHaveEntryResp((new PrtNamedTuple(new string[]{"status","hasEntry"},((PrtInt)0), ((PrtBool)false)))));
                TMP_tmp6_20 = (PrtInt)((PrtEnum.Get("SUCCESS")));
                TMP_tmp7_15 = (PrtBool)(((PrtBool)true));
                TMP_tmp8_12 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","hasEntry"}, TMP_tmp6_20, TMP_tmp7_15)));
                currentMachine.TrySendEvent(TMP_tmp4_24, (Event)TMP_tmp5_22, TMP_tmp8_12);
                currentMachine.TryGotoState<WaitForRequest>();
                return;
            }
            TMP_tmp9_11 = (PMachineValue)(((PrtNamedTuple)req_25)["source"]);
            TMP_tmp10_10 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp9_11)?.Clone()));
            TMP_tmp11_10 = (PEvent)(new eDoesLogHaveEntryResp((new PrtNamedTuple(new string[]{"status","hasEntry"},((PrtInt)0), ((PrtBool)false)))));
            TMP_tmp12_8 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp13_7 = (PrtBool)(((PrtBool)false));
            TMP_tmp14_6 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","hasEntry"}, TMP_tmp12_8, TMP_tmp13_7)));
            currentMachine.TrySendEvent(TMP_tmp10_10, (Event)TMP_tmp11_10, TMP_tmp14_6);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public async Task Anon_31(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_26 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tEntry appendedEntry_1 = null;
            PrtString TMP_tmp0_35 = ((PrtString)"");
            PrtInt TMP_tmp1_27 = ((PrtInt)0);
            tEntry TMP_tmp2_26 = null;
            PMachineValue TMP_tmp3_25 = null;
            PMachineValue TMP_tmp4_25 = null;
            PEvent TMP_tmp5_23 = null;
            PrtInt TMP_tmp6_21 = ((PrtInt)0);
            tEntry TMP_tmp7_16 = null;
            PrtNamedTuple TMP_tmp8_13 = (new PrtNamedTuple(new string[]{"status","newEntry"},((PrtInt)0), null));
            TMP_tmp0_35 = (PrtString)(((PrtNamedTuple)req_26)["entryData"]);
            TMP_tmp1_27 = (PrtInt)(((PrtNamedTuple)req_26)["numReferences"]);
            TMP_tmp2_26 = (tEntry)(await AppendEntry(TMP_tmp0_35, TMP_tmp1_27));
            appendedEntry_1 = TMP_tmp2_26;
            TMP_tmp3_25 = (PMachineValue)(((PrtNamedTuple)req_26)["source"]);
            TMP_tmp4_25 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_25)?.Clone()));
            TMP_tmp5_23 = (PEvent)(new eAppendNewEntryToLogResp((new PrtNamedTuple(new string[]{"status","newEntry"},((PrtInt)0), null))));
            TMP_tmp6_21 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp7_16 = (tEntry)(((tEntry)((IPrtValue)appendedEntry_1)?.Clone()));
            TMP_tmp8_13 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","newEntry"}, TMP_tmp6_21, TMP_tmp7_16)));
            currentMachine.TrySendEvent(TMP_tmp4_25, (Event)TMP_tmp5_23, TMP_tmp8_13);
        }
        public async Task Anon_32(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_27 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_36 = null;
            PMachineValue TMP_tmp1_28 = null;
            PMachineValue TMP_tmp2_27 = null;
            PEvent TMP_tmp3_26 = null;
            PrtInt TMP_tmp4_26 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp5_24 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_36 = (PMachineValue)(((PrtNamedTuple)req_27)["log"]);
            await JoinLog(TMP_tmp0_36);
            TMP_tmp1_28 = (PMachineValue)(((PrtNamedTuple)req_27)["source"]);
            TMP_tmp2_27 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_28)?.Clone()));
            TMP_tmp3_26 = (PEvent)(new eJoinLogResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp4_26 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_24 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp4_26)));
            currentMachine.TrySendEvent(TMP_tmp2_27, (Event)TMP_tmp3_26, TMP_tmp5_24);
        }
        public async Task Anon_33(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_28 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtBool didJoinEntry = ((PrtBool)false);
            tEntry TMP_tmp0_37 = null;
            PrtBool TMP_tmp1_29 = ((PrtBool)false);
            PMachineValue TMP_tmp2_28 = null;
            PMachineValue TMP_tmp3_27 = null;
            PEvent TMP_tmp4_27 = null;
            PrtInt TMP_tmp5_25 = ((PrtInt)0);
            PrtBool TMP_tmp6_22 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp7_17 = (new PrtNamedTuple(new string[]{"status","couldJoin"},((PrtInt)0), ((PrtBool)false)));
            TMP_tmp0_37 = (tEntry)(((PrtNamedTuple)req_28)["entryToJoin"]);
            TMP_tmp1_29 = (PrtBool)(await JoinEntry(TMP_tmp0_37));
            didJoinEntry = TMP_tmp1_29;
            TMP_tmp2_28 = (PMachineValue)(((PrtNamedTuple)req_28)["source"]);
            TMP_tmp3_27 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_28)?.Clone()));
            TMP_tmp4_27 = (PEvent)(new eJoinEntryResp((new PrtNamedTuple(new string[]{"status","couldJoin"},((PrtInt)0), ((PrtBool)false)))));
            TMP_tmp5_25 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_22 = (PrtBool)(((PrtBool)((IPrtValue)didJoinEntry)?.Clone()));
            TMP_tmp7_17 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","couldJoin"}, TMP_tmp5_25, TMP_tmp6_22)));
            currentMachine.TrySendEvent(TMP_tmp3_27, (Event)TMP_tmp4_27, TMP_tmp7_17);
        }
        public async Task Anon_34(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_29 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSeq traversedEntries = new PrtSeq();
            PrtMap dictionary_1 = new PrtMap();
            PrtMap TMP_tmp0_38 = new PrtMap();
            PrtMap TMP_tmp1_30 = new PrtMap();
            PrtSeq TMP_tmp2_29 = new PrtSeq();
            PrtMap TMP_tmp3_28 = new PrtMap();
            tTraversalStopper TMP_tmp4_28 = null;
            PrtBool TMP_tmp5_26 = ((PrtBool)false);
            PrtSeq TMP_tmp6_23 = new PrtSeq();
            PrtInt TMP_tmp7_18 = ((PrtInt)0);
            PrtString TMP_tmp8_14 = ((PrtString)"");
            PMachineValue TMP_tmp9_12 = null;
            PMachineValue TMP_tmp10_11 = null;
            PEvent TMP_tmp11_11 = null;
            PrtInt TMP_tmp12_9 = ((PrtInt)0);
            PrtSeq TMP_tmp13_8 = new PrtSeq();
            PrtNamedTuple TMP_tmp14_7 = (new PrtNamedTuple(new string[]{"status","traversedEntries"},((PrtInt)0), new PrtSeq()));
            TMP_tmp0_38 = (PrtMap)(await GetDictionaryFromMemoryStorage_1());
            TMP_tmp1_30 = (PrtMap)(((PrtMap)((PrtMap)((IPrtValue)TMP_tmp0_38)?.Clone())));
            dictionary_1 = TMP_tmp1_30;
            TMP_tmp2_29 = (PrtSeq)(((PrtNamedTuple)req_29)["rootEntries"]);
            TMP_tmp3_28 = (PrtMap)(((PrtMap)((IPrtValue)dictionary_1)?.Clone()));
            TMP_tmp4_28 = (tTraversalStopper)(((PrtNamedTuple)req_29)["stopper"]);
            TMP_tmp5_26 = (PrtBool)(((PrtNamedTuple)req_29)["useRefs"]);
            TMP_tmp6_23 = (PrtSeq)(GlobalFunctions.Traverse(TMP_tmp2_29, TMP_tmp3_28, TMP_tmp4_28, TMP_tmp5_26, currentMachine));
            traversedEntries = TMP_tmp6_23;
            TMP_tmp7_18 = (PrtInt)(((PrtInt)(traversedEntries).Count));
            TMP_tmp8_14 = (PrtString)(((PrtString) String.Format("Traversed over {0} entries in log",TMP_tmp7_18)));
            currentMachine.LogLine("" + TMP_tmp8_14);
            TMP_tmp9_12 = (PMachineValue)(((PrtNamedTuple)req_29)["source"]);
            TMP_tmp10_11 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp9_12)?.Clone()));
            TMP_tmp11_11 = (PEvent)(new eTraverseLogResp((new PrtNamedTuple(new string[]{"status","traversedEntries"},((PrtInt)0), new PrtSeq()))));
            TMP_tmp12_9 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp13_8 = (PrtSeq)(((PrtSeq)((IPrtValue)traversedEntries)?.Clone()));
            TMP_tmp14_7 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","traversedEntries"}, TMP_tmp12_9, TMP_tmp13_8)));
            currentMachine.TrySendEvent(TMP_tmp10_11, (Event)TMP_tmp11_11, TMP_tmp14_7);
        }
        public async Task<tTimestamp> GetClockLastState()
        {
            Log currentMachine = this;
            tTimestamp lastTimestamp_1 = null;
            PrtString TMP_tmp0_39 = ((PrtString)"");
            PMachineValue TMP_tmp1_31 = null;
            PEvent TMP_tmp2_30 = null;
            PMachineValue TMP_tmp3_29 = null;
            PrtNamedTuple TMP_tmp4_29 = (new PrtNamedTuple(new string[]{"source"},null));
            tTimestamp TMP_tmp5_27 = null;
            tTimestamp TMP_tmp6_24 = null;
            tTimestamp TMP_tmp7_19 = null;
            PrtString TMP_tmp8_15 = ((PrtString)"");
            TMP_tmp0_39 = (PrtString)(((PrtString) String.Format("GETTING CLOCK LAST STATE")));
            currentMachine.LogLine("" + TMP_tmp0_39);
            TMP_tmp1_31 = (PMachineValue)(((PMachineValue)((IPrtValue)clock)?.Clone()));
            TMP_tmp2_30 = (PEvent)(new eGetLastTimestampReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp3_29 = (PMachineValue)(currentMachine.self);
            TMP_tmp4_29 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp3_29)));
            currentMachine.TrySendEvent(TMP_tmp1_31, (Event)TMP_tmp2_30, TMP_tmp4_29);
            var PGEN_recvEvent_7 = await currentMachine.TryReceiveEvent(typeof(eGetLastTimestampResp), typeof(PHalt));
            switch (PGEN_recvEvent_7) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetLastTimestampResp PGEN_evt_7: {
                    PrtNamedTuple resp_7 = (PrtNamedTuple)(PGEN_evt_7.Payload);
                    TMP_tmp5_27 = (tTimestamp)(((PrtNamedTuple)resp_7)["lastTimestamp"]);
                    TMP_tmp6_24 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp5_27)?.Clone()));
                    lastTimestamp_1 = TMP_tmp6_24;
                    TMP_tmp7_19 = (tTimestamp)(((tTimestamp)((IPrtValue)lastTimestamp_1)?.Clone()));
                    TMP_tmp8_15 = (PrtString)(((PrtString) String.Format("Clock last state is {0}",TMP_tmp7_19)));
                    currentMachine.LogLine("" + TMP_tmp8_15);
                } break;
            }
            return ((tTimestamp)((IPrtValue)lastTimestamp_1)?.Clone());
        }
        public async Task<PrtSeq> GetHeadsFromLog()
        {
            Log currentMachine = this;
            PrtSeq headsToReturn = new PrtSeq();
            PrtString TMP_tmp0_40 = ((PrtString)"");
            PMachineValue TMP_tmp1_32 = null;
            PEvent TMP_tmp2_31 = null;
            PMachineValue TMP_tmp3_30 = null;
            PrtNamedTuple TMP_tmp4_30 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtSeq TMP_tmp5_28 = new PrtSeq();
            PrtInt TMP_tmp6_25 = ((PrtInt)0);
            PrtString TMP_tmp7_20 = ((PrtString)"");
            PrtSeq TMP_tmp8_16 = new PrtSeq();
            PrtBool TMP_tmp9_13 = ((PrtBool)false);
            PrtSeq TMP_tmp10_12 = new PrtSeq();
            PrtInt TMP_tmp11_12 = ((PrtInt)0);
            PrtString TMP_tmp12_10 = ((PrtString)"");
            TMP_tmp0_40 = (PrtString)(((PrtString) String.Format("GETTING LOG HEADS")));
            currentMachine.LogLine("" + TMP_tmp0_40);
            TMP_tmp1_32 = (PMachineValue)(((PMachineValue)((IPrtValue)heads_1)?.Clone()));
            TMP_tmp2_31 = (PEvent)(new eGetAllEntriesFromHeadsReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp3_30 = (PMachineValue)(currentMachine.self);
            TMP_tmp4_30 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp3_30)));
            currentMachine.TrySendEvent(TMP_tmp1_32, (Event)TMP_tmp2_31, TMP_tmp4_30);
            var PGEN_recvEvent_8 = await currentMachine.TryReceiveEvent(typeof(eGetAllEntriesFromHeadsResp), typeof(PHalt));
            switch (PGEN_recvEvent_8) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetAllEntriesFromHeadsResp PGEN_evt_8: {
                    PrtNamedTuple resp_8 = (PrtNamedTuple)(PGEN_evt_8.Payload);
                    TMP_tmp5_28 = (PrtSeq)(((PrtNamedTuple)resp_8)["retrievedValues"]);
                    TMP_tmp6_25 = (PrtInt)(((PrtInt)(TMP_tmp5_28).Count));
                    TMP_tmp7_20 = (PrtString)(((PrtString) String.Format("Received {0} heads from Heads",TMP_tmp6_25)));
                    currentMachine.LogLine("" + TMP_tmp7_20);
                    TMP_tmp8_16 = (PrtSeq)(((PrtNamedTuple)resp_8)["retrievedValues"]);
                    TMP_tmp9_13 = (PrtBool)(((PrtBool)true));
                    TMP_tmp10_12 = (PrtSeq)(GlobalFunctions.Sorted(TMP_tmp8_16, TMP_tmp9_13, currentMachine));
                    headsToReturn = TMP_tmp10_12;
                    TMP_tmp11_12 = (PrtInt)(((PrtInt)(headsToReturn).Count));
                    TMP_tmp12_10 = (PrtString)(((PrtString) String.Format("Received {0} heads from Heads",TMP_tmp11_12)));
                    currentMachine.LogLine("" + TMP_tmp12_10);
                } break;
            }
            return ((PrtSeq)((IPrtValue)headsToReturn)?.Clone());
        }
        public async Task<PrtSeq> GetAllEntriesFromLog()
        {
            Log currentMachine = this;
            PrtSeq entries_4 = new PrtSeq();
            PrtSeq traversedEntries_1 = new PrtSeq();
            PrtSeq rootEntries = new PrtSeq();
            PrtMap dictionary_2 = new PrtMap();
            tTraversalStopper stopper = null;
            tEntry traversedEntry = null;
            PrtString TMP_tmp0_41 = ((PrtString)"");
            tTraversalStopper TMP_tmp1_33 = null;
            PrtSeq TMP_tmp2_32 = new PrtSeq();
            PrtMap TMP_tmp3_31 = new PrtMap();
            PrtSeq TMP_tmp4_31 = new PrtSeq();
            PrtMap TMP_tmp5_29 = new PrtMap();
            tTraversalStopper TMP_tmp6_26 = null;
            PrtBool TMP_tmp7_21 = ((PrtBool)false);
            PrtSeq TMP_tmp8_17 = new PrtSeq();
            PrtSeq TMP_tmp9_14 = new PrtSeq();
            PrtInt TMP_i_traversedEntry_tmp10 = ((PrtInt)0);
            PrtInt sizeof_traversedEntry_tmp11 = ((PrtInt)0);
            PrtInt TMP_tmp12_11 = ((PrtInt)0);
            PrtInt TMP_tmp13_9 = ((PrtInt)0);
            PrtBool TMP_tmp14_8 = ((PrtBool)false);
            PrtBool TMP_tmp15_5 = ((PrtBool)false);
            PrtInt TMP_tmp16_4 = ((PrtInt)0);
            tEntry TMP_tmp17_4 = null;
            tEntry TMP_tmp18_4 = null;
            tEntry TMP_tmp19_4 = null;
            PrtInt TMP_tmp20_4 = ((PrtInt)0);
            PrtString TMP_tmp21_4 = ((PrtString)"");
            TMP_tmp0_41 = (PrtString)(((PrtString) String.Format("GETTING ALL ENTRIES IN LOG")));
            currentMachine.LogLine("" + TMP_tmp0_41);
            TMP_tmp1_33 = (tTraversalStopper)(GlobalFunctions.CreateDefaultTraversalStopper(currentMachine));
            stopper = TMP_tmp1_33;
            TMP_tmp2_32 = (PrtSeq)(await GetHeadsFromLog());
            rootEntries = TMP_tmp2_32;
            TMP_tmp3_31 = (PrtMap)(await GetDictionaryFromMemoryStorage_1());
            dictionary_2 = TMP_tmp3_31;
            TMP_tmp4_31 = (PrtSeq)(((PrtSeq)((IPrtValue)rootEntries)?.Clone()));
            TMP_tmp5_29 = (PrtMap)(((PrtMap)((IPrtValue)dictionary_2)?.Clone()));
            TMP_tmp6_26 = (tTraversalStopper)(((tTraversalStopper)((IPrtValue)stopper)?.Clone()));
            TMP_tmp7_21 = (PrtBool)(((PrtBool)true));
            TMP_tmp8_17 = (PrtSeq)(GlobalFunctions.Traverse(TMP_tmp4_31, TMP_tmp5_29, TMP_tmp6_26, TMP_tmp7_21, currentMachine));
            traversedEntries_1 = TMP_tmp8_17;
            TMP_tmp9_14 = (PrtSeq)(((PrtSeq)((IPrtValue)traversedEntries_1)?.Clone()));
            TMP_i_traversedEntry_tmp10 = (PrtInt)(((PrtInt)(-1)));
            TMP_tmp12_11 = (PrtInt)(((PrtInt)(TMP_tmp9_14).Count));
            sizeof_traversedEntry_tmp11 = TMP_tmp12_11;
            while (((PrtBool)true))
            {
                TMP_tmp13_9 = (PrtInt)((sizeof_traversedEntry_tmp11) - (((PrtInt)(1))));
                TMP_tmp14_8 = (PrtBool)((TMP_i_traversedEntry_tmp10) < (TMP_tmp13_9));
                TMP_tmp15_5 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp14_8)?.Clone()));
                if (TMP_tmp15_5)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp16_4 = (PrtInt)((TMP_i_traversedEntry_tmp10) + (((PrtInt)(1))));
                TMP_i_traversedEntry_tmp10 = TMP_tmp16_4;
                TMP_tmp17_4 = (tEntry)(((PrtSeq)TMP_tmp9_14)[TMP_i_traversedEntry_tmp10]);
                TMP_tmp18_4 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp17_4)?.Clone()));
                traversedEntry = TMP_tmp18_4;
                TMP_tmp19_4 = (tEntry)(((tEntry)((IPrtValue)traversedEntry)?.Clone()));
                ((PrtSeq)entries_4).Insert(((PrtInt)(0)), TMP_tmp19_4);
            }
            TMP_tmp20_4 = (PrtInt)(((PrtInt)(entries_4).Count));
            TMP_tmp21_4 = (PrtString)(((PrtString) String.Format("Got {0} entries from log",TMP_tmp20_4)));
            currentMachine.LogLine("" + TMP_tmp21_4);
            return ((PrtSeq)((IPrtValue)entries_4)?.Clone());
        }
        public async Task<IPrtValue> GetEntryFromLog(PrtString hash)
        {
            Log currentMachine = this;
            IPrtValue value_2 = null;
            PrtString TMP_tmp0_42 = ((PrtString)"");
            PrtString TMP_tmp1_34 = ((PrtString)"");
            PMachineValue TMP_tmp2_33 = null;
            PEvent TMP_tmp3_32 = null;
            PMachineValue TMP_tmp4_32 = null;
            PrtString TMP_tmp5_30 = ((PrtString)"");
            PrtNamedTuple TMP_tmp6_27 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            PrtInt TMP_tmp7_22 = ((PrtInt)0);
            PrtBool TMP_tmp8_18 = ((PrtBool)false);
            IPrtValue TMP_tmp9_15 = null;
            tEntry TMP_tmp10_13 = null;
            IPrtValue TMP_tmp11_13 = null;
            PrtString TMP_tmp12_12 = ((PrtString)"");
            PrtString TMP_tmp13_10 = ((PrtString)"");
            IPrtValue TMP_tmp14_9 = null;
            PrtBool TMP_tmp15_6 = ((PrtBool)false);
            PrtString TMP_tmp16_5 = ((PrtString)"");
            PrtString TMP_tmp17_5 = ((PrtString)"");
            TMP_tmp0_42 = (PrtString)(((PrtString)((IPrtValue)hash)?.Clone()));
            TMP_tmp1_34 = (PrtString)(((PrtString) String.Format("GETTING ENTRY WITH HASH {0} FROM LOG",TMP_tmp0_42)));
            currentMachine.LogLine("" + TMP_tmp1_34);
            TMP_tmp2_33 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp3_32 = (PEvent)(new eGetValueFromStorageReq((new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")))));
            TMP_tmp4_32 = (PMachineValue)(currentMachine.self);
            TMP_tmp5_30 = (PrtString)(((PrtString)((IPrtValue)hash)?.Clone()));
            TMP_tmp6_27 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key"}, TMP_tmp4_32, TMP_tmp5_30)));
            currentMachine.TrySendEvent(TMP_tmp2_33, (Event)TMP_tmp3_32, TMP_tmp6_27);
            var PGEN_recvEvent_9 = await currentMachine.TryReceiveEvent(typeof(eGetValueFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_9) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetValueFromStorageResp PGEN_evt_9: {
                    PrtNamedTuple resp_9 = (PrtNamedTuple)(PGEN_evt_9.Payload);
                    TMP_tmp7_22 = (PrtInt)(((PrtNamedTuple)resp_9)["status"]);
                    TMP_tmp8_18 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp7_22),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    if (TMP_tmp8_18)
                    {
                        TMP_tmp9_15 = (IPrtValue)(((PrtNamedTuple)resp_9)["value"]);
                        TMP_tmp10_13 = (tEntry)(((tEntry)((IPrtValue)((IPrtValue)TMP_tmp9_15)?.Clone())));
                        value_2 = (IPrtValue)TMP_tmp10_13;
                        TMP_tmp11_13 = (IPrtValue)(((IPrtValue)((IPrtValue)value_2)?.Clone()));
                        TMP_tmp12_12 = (PrtString)(((PrtString)((IPrtValue)hash)?.Clone()));
                        TMP_tmp13_10 = (PrtString)(((PrtString) String.Format("Found entry {0} with hash {1} in log",TMP_tmp11_13,TMP_tmp12_12)));
                        currentMachine.LogLine("" + TMP_tmp13_10);
                    }
                    TMP_tmp14_9 = (IPrtValue)(((PrtNamedTuple)resp_9)["value"]);
                    TMP_tmp15_6 = (PrtBool)(((PrtBool)((IPrtValue)((IPrtValue)TMP_tmp14_9)?.Clone())));
                    value_2 = (IPrtValue)TMP_tmp15_6;
                    TMP_tmp16_5 = (PrtString)(((PrtString)((IPrtValue)hash)?.Clone()));
                    TMP_tmp17_5 = (PrtString)(((PrtString) String.Format("Could not find entry with hash {0} in log",TMP_tmp16_5)));
                    currentMachine.LogLine("" + TMP_tmp17_5);
                } break;
            }
            return ((IPrtValue)((IPrtValue)value_2)?.Clone());
        }
        public async Task<PrtBool> LogHasEntry(PrtString hash_1)
        {
            Log currentMachine = this;
            IPrtValue value_3 = null;
            PrtString TMP_tmp0_43 = ((PrtString)"");
            PrtString TMP_tmp1_35 = ((PrtString)"");
            PrtString TMP_tmp2_34 = ((PrtString)"");
            IPrtValue TMP_tmp3_33 = null;
            PrtBool TMP_tmp4_33 = ((PrtBool)false);
            PrtString TMP_tmp5_31 = ((PrtString)"");
            PrtString TMP_tmp6_28 = ((PrtString)"");
            PrtString TMP_tmp7_23 = ((PrtString)"");
            PrtString TMP_tmp8_19 = ((PrtString)"");
            TMP_tmp0_43 = (PrtString)(((PrtString)((IPrtValue)hash_1)?.Clone()));
            TMP_tmp1_35 = (PrtString)(((PrtString) String.Format("CHECKING IF LOG HAS ENTRY WITH HASH {0}",TMP_tmp0_43)));
            currentMachine.LogLine("" + TMP_tmp1_35);
            TMP_tmp2_34 = (PrtString)(((PrtString)((IPrtValue)hash_1)?.Clone()));
            TMP_tmp3_33 = (IPrtValue)(await GetEntryFromLog(TMP_tmp2_34));
            value_3 = TMP_tmp3_33;
            TMP_tmp4_33 = (PrtBool)((PrtValues.SafeEquals(value_3,((PrtBool)false))));
            if (TMP_tmp4_33)
            {
                TMP_tmp5_31 = (PrtString)(((PrtString)((IPrtValue)hash_1)?.Clone()));
                TMP_tmp6_28 = (PrtString)(((PrtString) String.Format("Log does not have entry with hash {0}",TMP_tmp5_31)));
                currentMachine.LogLine("" + TMP_tmp6_28);
                return ((PrtBool)false);
            }
            TMP_tmp7_23 = (PrtString)(((PrtString)((IPrtValue)hash_1)?.Clone()));
            TMP_tmp8_19 = (PrtString)(((PrtString) String.Format("Log does have entry with hash {0}",TMP_tmp7_23)));
            currentMachine.LogLine("" + TMP_tmp8_19);
            return ((PrtBool)true);
        }
        public async Task<tEntry> AppendEntry(PrtString entryData, PrtInt numReferences)
        {
            Log currentMachine = this;
            PrtSeq logHeads_1 = new PrtSeq();
            tEntry itrEntry = null;
            PrtSet nexts = new PrtSet();
            PrtSet refs = new PrtSet();
            tEntry createdEntry = null;
            PrtInt totalNumReferences = ((PrtInt)0);
            tTimestamp now = null;
            PrtSeq entrySet = new PrtSeq();
            PrtMap dictionary_3 = new PrtMap();
            PrtString TMP_tmp0_44 = ((PrtString)"");
            PrtString TMP_tmp1_36 = ((PrtString)"");
            PrtSeq TMP_tmp2_35 = new PrtSeq();
            PrtSeq TMP_tmp3_34 = new PrtSeq();
            PrtMap TMP_tmp4_34 = new PrtMap();
            PrtSeq TMP_tmp5_32 = new PrtSeq();
            PrtInt TMP_i_itrEntry_tmp6 = ((PrtInt)0);
            PrtInt sizeof_itrEntry_tmp7 = ((PrtInt)0);
            PrtInt TMP_tmp8_20 = ((PrtInt)0);
            PrtInt TMP_tmp9_16 = ((PrtInt)0);
            PrtBool TMP_tmp10_14 = ((PrtBool)false);
            PrtBool TMP_tmp11_14 = ((PrtBool)false);
            PrtInt TMP_tmp12_13 = ((PrtInt)0);
            tEntry TMP_tmp13_11 = null;
            tEntry TMP_tmp14_10 = null;
            tEntry TMP_tmp15_7 = null;
            PrtString TMP_tmp16_6 = ((PrtString)"");
            PrtInt TMP_tmp17_6 = ((PrtInt)0);
            PrtInt TMP_tmp18_5 = ((PrtInt)0);
            PrtSeq TMP_tmp19_5 = new PrtSeq();
            PrtMap TMP_tmp20_5 = new PrtMap();
            PrtInt TMP_tmp21_5 = ((PrtInt)0);
            PrtSet TMP_tmp22_2 = new PrtSet();
            PMachineValue TMP_tmp23_1 = null;
            PEvent TMP_tmp24_1 = null;
            PMachineValue TMP_tmp25 = null;
            PrtNamedTuple TMP_tmp26 = (new PrtNamedTuple(new string[]{"source"},null));
            tTimestamp TMP_tmp27 = null;
            tTimestamp TMP_tmp28 = null;
            PrtString TMP_tmp29 = ((PrtString)"");
            PrtString TMP_tmp30 = ((PrtString)"");
            PrtString TMP_tmp31 = ((PrtString)"");
            tTimestamp TMP_tmp32 = null;
            PrtSet TMP_tmp33 = new PrtSet();
            PrtSet TMP_tmp34 = new PrtSet();
            tEntry TMP_tmp35 = null;
            tEntry TMP_tmp36 = null;
            PrtString TMP_tmp37 = ((PrtString)"");
            tEntry TMP_tmp38 = null;
            PMachineValue TMP_tmp39 = null;
            PEvent TMP_tmp40 = null;
            PMachineValue TMP_tmp41 = null;
            PrtSeq TMP_tmp42 = new PrtSeq();
            PrtNamedTuple TMP_tmp43 = (new PrtNamedTuple(new string[]{"source","entries"},null, new PrtSeq()));
            PrtString TMP_tmp44 = ((PrtString)"");
            PMachineValue TMP_tmp45 = null;
            PEvent TMP_tmp46 = null;
            PMachineValue TMP_tmp47 = null;
            tEntry TMP_tmp48 = null;
            PrtString TMP_tmp49 = ((PrtString)"");
            tEntry TMP_tmp50 = null;
            PrtNamedTuple TMP_tmp51 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            PrtString TMP_tmp52 = ((PrtString)"");
            PMachineValue TMP_tmp53 = null;
            PEvent TMP_tmp54 = null;
            PMachineValue TMP_tmp55 = null;
            tEntry TMP_tmp56 = null;
            PrtString TMP_tmp57 = ((PrtString)"");
            PrtBool TMP_tmp58 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp59 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), ((PrtBool)false)));
            PrtString TMP_tmp60 = ((PrtString)"");
            PrtString TMP_tmp61 = ((PrtString)"");
            TMP_tmp0_44 = (PrtString)(((PrtString)((IPrtValue)entryData)?.Clone()));
            TMP_tmp1_36 = (PrtString)(((PrtString) String.Format("APPENDING ENTRY WITH DATA {0} TO LOG",TMP_tmp0_44)));
            currentMachine.LogLine("" + TMP_tmp1_36);
            TMP_tmp2_35 = (PrtSeq)(await GetHeadsFromLog());
            TMP_tmp3_34 = (PrtSeq)(((PrtSeq)((PrtSeq)((IPrtValue)TMP_tmp2_35)?.Clone())));
            logHeads_1 = TMP_tmp3_34;
            TMP_tmp4_34 = (PrtMap)(await GetDictionaryFromMemoryStorage_1());
            dictionary_3 = TMP_tmp4_34;
            TMP_tmp5_32 = (PrtSeq)(((PrtSeq)((IPrtValue)logHeads_1)?.Clone()));
            TMP_i_itrEntry_tmp6 = (PrtInt)(((PrtInt)(-1)));
            TMP_tmp8_20 = (PrtInt)(((PrtInt)(TMP_tmp5_32).Count));
            sizeof_itrEntry_tmp7 = TMP_tmp8_20;
            while (((PrtBool)true))
            {
                TMP_tmp9_16 = (PrtInt)((sizeof_itrEntry_tmp7) - (((PrtInt)(1))));
                TMP_tmp10_14 = (PrtBool)((TMP_i_itrEntry_tmp6) < (TMP_tmp9_16));
                TMP_tmp11_14 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp10_14)?.Clone()));
                if (TMP_tmp11_14)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp12_13 = (PrtInt)((TMP_i_itrEntry_tmp6) + (((PrtInt)(1))));
                TMP_i_itrEntry_tmp6 = TMP_tmp12_13;
                TMP_tmp13_11 = (tEntry)(((PrtSeq)TMP_tmp5_32)[TMP_i_itrEntry_tmp6]);
                TMP_tmp14_10 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp13_11)?.Clone()));
                itrEntry = TMP_tmp14_10;
                TMP_tmp15_7 = (tEntry)(((tEntry)((IPrtValue)itrEntry)?.Clone()));
                TMP_tmp16_6 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp15_7, currentMachine));
                ((PrtSet)nexts).Add(TMP_tmp16_6);
            }
            TMP_tmp17_6 = (PrtInt)(((PrtInt)(logHeads_1).Count));
            TMP_tmp18_5 = (PrtInt)((numReferences) + (TMP_tmp17_6));
            totalNumReferences = TMP_tmp18_5;
            TMP_tmp19_5 = (PrtSeq)(((PrtSeq)((IPrtValue)logHeads_1)?.Clone()));
            TMP_tmp20_5 = (PrtMap)(((PrtMap)((IPrtValue)dictionary_3)?.Clone()));
            TMP_tmp21_5 = (PrtInt)(((PrtInt)((IPrtValue)totalNumReferences)?.Clone()));
            TMP_tmp22_2 = (PrtSet)(GlobalFunctions.GetReferences(TMP_tmp19_5, TMP_tmp20_5, TMP_tmp21_5, currentMachine));
            refs = TMP_tmp22_2;
            TMP_tmp23_1 = (PMachineValue)(((PMachineValue)((IPrtValue)clock)?.Clone()));
            TMP_tmp24_1 = (PEvent)(new eGetNowReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp25 = (PMachineValue)(currentMachine.self);
            TMP_tmp26 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp25)));
            currentMachine.TrySendEvent(TMP_tmp23_1, (Event)TMP_tmp24_1, TMP_tmp26);
            var PGEN_recvEvent_10 = await currentMachine.TryReceiveEvent(typeof(eGetNowResp), typeof(PHalt));
            switch (PGEN_recvEvent_10) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetNowResp PGEN_evt_10: {
                    PrtNamedTuple resp_10 = (PrtNamedTuple)(PGEN_evt_10.Payload);
                    TMP_tmp27 = (tTimestamp)(((PrtNamedTuple)resp_10)["now"]);
                    TMP_tmp28 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp27)?.Clone()));
                    now = TMP_tmp28;
                } break;
            }
            TMP_tmp29 = (PrtString)(((PrtString)((IPrtValue)identity_1)?.Clone()));
            TMP_tmp30 = (PrtString)(((PrtString)((IPrtValue)logId)?.Clone()));
            TMP_tmp31 = (PrtString)(((PrtString)((IPrtValue)entryData)?.Clone()));
            TMP_tmp32 = (tTimestamp)(((tTimestamp)((IPrtValue)now)?.Clone()));
            TMP_tmp33 = (PrtSet)(((PrtSet)((IPrtValue)nexts)?.Clone()));
            TMP_tmp34 = (PrtSet)(((PrtSet)((IPrtValue)refs)?.Clone()));
            TMP_tmp35 = (tEntry)(GlobalFunctions.CreateEntry(TMP_tmp29, TMP_tmp30, TMP_tmp31, TMP_tmp32, TMP_tmp33, TMP_tmp34, currentMachine));
            createdEntry = TMP_tmp35;
            TMP_tmp36 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp37 = (PrtString)(((PrtString) String.Format("Created entry to append: {0}",TMP_tmp36)));
            currentMachine.LogLine("" + TMP_tmp37);
            TMP_tmp38 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            ((PrtSeq)entrySet).Insert(((PrtInt)(0)), TMP_tmp38);
            TMP_tmp39 = (PMachineValue)(((PMachineValue)((IPrtValue)heads_1)?.Clone()));
            TMP_tmp40 = (PEvent)(new eSetEntriesInHeadsReq((new PrtNamedTuple(new string[]{"source","entries"},null, new PrtSeq()))));
            TMP_tmp41 = (PMachineValue)(currentMachine.self);
            TMP_tmp42 = (PrtSeq)(((PrtSeq)((IPrtValue)entrySet)?.Clone()));
            TMP_tmp43 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","entries"}, TMP_tmp41, TMP_tmp42)));
            currentMachine.TrySendEvent(TMP_tmp39, (Event)TMP_tmp40, TMP_tmp43);
            var PGEN_recvEvent_11 = await currentMachine.TryReceiveEvent(typeof(eSetEntriesInHeadsResp), typeof(PHalt));
            switch (PGEN_recvEvent_11) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eSetEntriesInHeadsResp PGEN_evt_11: {
                    PrtNamedTuple resp_11 = (PrtNamedTuple)(PGEN_evt_11.Payload);
                    TMP_tmp44 = (PrtString)(((PrtString) String.Format("Set new entries in Heads")));
                    currentMachine.LogLine("" + TMP_tmp44);
                } break;
            }
            TMP_tmp45 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp46 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp47 = (PMachineValue)(currentMachine.self);
            TMP_tmp48 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp49 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp48, currentMachine));
            TMP_tmp50 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp51 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp47, TMP_tmp49, TMP_tmp50)));
            currentMachine.TrySendEvent(TMP_tmp45, (Event)TMP_tmp46, TMP_tmp51);
            var PGEN_recvEvent_12 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_12) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_12: {
                    PrtNamedTuple resp_12 = (PrtNamedTuple)(PGEN_evt_12.Payload);
                    TMP_tmp52 = (PrtString)(((PrtString) String.Format("Put new entry in entries storage")));
                    currentMachine.LogLine("" + TMP_tmp52);
                } break;
            }
            TMP_tmp53 = (PMachineValue)(((PMachineValue)((IPrtValue)index)?.Clone()));
            TMP_tmp54 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp55 = (PMachineValue)(currentMachine.self);
            TMP_tmp56 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp57 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp56, currentMachine));
            TMP_tmp58 = (PrtBool)(((PrtBool)true));
            TMP_tmp59 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp55, TMP_tmp57, TMP_tmp58)));
            currentMachine.TrySendEvent(TMP_tmp53, (Event)TMP_tmp54, TMP_tmp59);
            var PGEN_recvEvent_13 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_13) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_13: {
                    PrtNamedTuple resp_13 = (PrtNamedTuple)(PGEN_evt_13.Payload);
                    TMP_tmp60 = (PrtString)(((PrtString) String.Format("Put new entry in index storage")));
                    currentMachine.LogLine("" + TMP_tmp60);
                } break;
            }
            TMP_tmp61 = (PrtString)(((PrtString) String.Format("SUCCESSFULLY APPENDED ENTRY TO LOG")));
            currentMachine.LogLine("" + TMP_tmp61);
            return ((tEntry)((IPrtValue)createdEntry)?.Clone());
        }
        public async Task JoinLog(PMachineValue log_1)
        {
            Log currentMachine = this;
            PrtSeq otherLogHeads = new PrtSeq();
            tEntry otherLogEntry = null;
            PrtBool couldJoinEntry = ((PrtBool)false);
            PrtString TMP_tmp0_45 = ((PrtString)"");
            PMachineValue TMP_tmp1_37 = null;
            PEvent TMP_tmp2_36 = null;
            PMachineValue TMP_tmp3_35 = null;
            PrtNamedTuple TMP_tmp4_35 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtSeq TMP_tmp5_33 = new PrtSeq();
            PrtSeq TMP_tmp6_29 = new PrtSeq();
            PrtInt TMP_tmp7_24 = ((PrtInt)0);
            PrtString TMP_tmp8_21 = ((PrtString)"");
            PrtSeq TMP_tmp9_17 = new PrtSeq();
            PrtInt TMP_i_otherLogEntry_tmp10 = ((PrtInt)0);
            PrtInt sizeof_otherLogEntry_tmp11 = ((PrtInt)0);
            PrtInt TMP_tmp12_14 = ((PrtInt)0);
            PrtInt TMP_tmp13_12 = ((PrtInt)0);
            PrtBool TMP_tmp14_11 = ((PrtBool)false);
            PrtBool TMP_tmp15_8 = ((PrtBool)false);
            PrtInt TMP_tmp16_7 = ((PrtInt)0);
            tEntry TMP_tmp17_7 = null;
            tEntry TMP_tmp18_6 = null;
            tEntry TMP_tmp19_6 = null;
            PrtString TMP_tmp20_6 = ((PrtString)"");
            TMP_tmp0_45 = (PrtString)(((PrtString) String.Format("JOINING OTHER LOG TO LOG")));
            currentMachine.LogLine("" + TMP_tmp0_45);
            TMP_tmp1_37 = (PMachineValue)(((PMachineValue)((IPrtValue)log_1)?.Clone()));
            TMP_tmp2_36 = (PEvent)(new eGetHeadsFromLogReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp3_35 = (PMachineValue)(currentMachine.self);
            TMP_tmp4_35 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp3_35)));
            currentMachine.TrySendEvent(TMP_tmp1_37, (Event)TMP_tmp2_36, TMP_tmp4_35);
            var PGEN_recvEvent_14 = await currentMachine.TryReceiveEvent(typeof(eGetHeadsFromLogResp), typeof(PHalt));
            switch (PGEN_recvEvent_14) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetHeadsFromLogResp PGEN_evt_14: {
                    PrtNamedTuple resp_14 = (PrtNamedTuple)(PGEN_evt_14.Payload);
                    TMP_tmp5_33 = (PrtSeq)(((PrtNamedTuple)resp_14)["heads"]);
                    TMP_tmp6_29 = (PrtSeq)(((PrtSeq)((IPrtValue)TMP_tmp5_33)?.Clone()));
                    otherLogHeads = TMP_tmp6_29;
                    TMP_tmp7_24 = (PrtInt)(((PrtInt)(otherLogHeads).Count));
                    TMP_tmp8_21 = (PrtString)(((PrtString) String.Format("Received {0} heads from other log",TMP_tmp7_24)));
                    currentMachine.LogLine("" + TMP_tmp8_21);
                } break;
            }
            TMP_tmp9_17 = (PrtSeq)(((PrtSeq)((IPrtValue)otherLogHeads)?.Clone()));
            TMP_i_otherLogEntry_tmp10 = (PrtInt)(((PrtInt)(-1)));
            TMP_tmp12_14 = (PrtInt)(((PrtInt)(TMP_tmp9_17).Count));
            sizeof_otherLogEntry_tmp11 = TMP_tmp12_14;
            while (((PrtBool)true))
            {
                TMP_tmp13_12 = (PrtInt)((sizeof_otherLogEntry_tmp11) - (((PrtInt)(1))));
                TMP_tmp14_11 = (PrtBool)((TMP_i_otherLogEntry_tmp10) < (TMP_tmp13_12));
                TMP_tmp15_8 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp14_11)?.Clone()));
                if (TMP_tmp15_8)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp16_7 = (PrtInt)((TMP_i_otherLogEntry_tmp10) + (((PrtInt)(1))));
                TMP_i_otherLogEntry_tmp10 = TMP_tmp16_7;
                TMP_tmp17_7 = (tEntry)(((PrtSeq)TMP_tmp9_17)[TMP_i_otherLogEntry_tmp10]);
                TMP_tmp18_6 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp17_7)?.Clone()));
                otherLogEntry = TMP_tmp18_6;
                TMP_tmp19_6 = (tEntry)(((tEntry)((IPrtValue)otherLogEntry)?.Clone()));
                await JoinEntry(TMP_tmp19_6);
            }
            TMP_tmp20_6 = (PrtString)(((PrtString) String.Format("SUCCESSFULLY JOINED OTHER LOG TO LOG")));
            currentMachine.LogLine("" + TMP_tmp20_6);
        }
        public async Task<PrtBool> JoinEntry(tEntry entryToJoin)
        {
            Log currentMachine = this;
            PrtBool returnBool = ((PrtBool)false);
            PrtSeq headsBeforeJoin = new PrtSeq();
            tEntry TMP_tmp0_46 = null;
            PrtString TMP_tmp1_38 = ((PrtString)"");
            tEntry TMP_tmp2_37 = null;
            PrtString TMP_tmp3_36 = ((PrtString)"");
            PrtBool TMP_tmp4_36 = ((PrtBool)false);
            PrtBool TMP_tmp5_34 = ((PrtBool)false);
            PrtString TMP_tmp6_30 = ((PrtString)"");
            PMachineValue TMP_tmp7_25 = null;
            PEvent TMP_tmp8_22 = null;
            PMachineValue TMP_tmp9_18 = null;
            tEntry TMP_tmp10_15 = null;
            tTimestamp TMP_tmp11_15 = null;
            PrtNamedTuple TMP_tmp12_15 = (new PrtNamedTuple(new string[]{"source","remoteTs"},null, null));
            tTimestamp TMP_tmp13_13 = null;
            PrtString TMP_tmp14_12 = ((PrtString)"");
            PrtSeq TMP_tmp15_9 = new PrtSeq();
            PMachineValue TMP_tmp16_8 = null;
            PEvent TMP_tmp17_8 = null;
            PMachineValue TMP_tmp18_7 = null;
            tEntry TMP_tmp19_7 = null;
            PrtNamedTuple TMP_tmp20_7 = (new PrtNamedTuple(new string[]{"source","headEntry"},null, null));
            PrtSeq TMP_tmp21_6 = new PrtSeq();
            PrtBool TMP_tmp22_3 = ((PrtBool)false);
            PrtSeq TMP_tmp23_2 = new PrtSeq();
            PrtBool TMP_tmp24_2 = ((PrtBool)false);
            PrtBool TMP_tmp25_1 = ((PrtBool)false);
            tEntry TMP_tmp26_1 = null;
            PrtString TMP_tmp27_1 = ((PrtString)"");
            PMachineValue TMP_tmp28_1 = null;
            PEvent TMP_tmp29_1 = null;
            PMachineValue TMP_tmp30_1 = null;
            tEntry TMP_tmp31_1 = null;
            PrtString TMP_tmp32_1 = ((PrtString)"");
            tEntry TMP_tmp33_1 = null;
            PrtNamedTuple TMP_tmp34_1 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            tEntry TMP_tmp35_1 = null;
            PrtString TMP_tmp36_1 = ((PrtString)"");
            PMachineValue TMP_tmp37_1 = null;
            PEvent TMP_tmp38_1 = null;
            PMachineValue TMP_tmp39_1 = null;
            tEntry TMP_tmp40_1 = null;
            PrtString TMP_tmp41_1 = ((PrtString)"");
            PrtBool TMP_tmp42_1 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp43_1 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), ((PrtBool)false)));
            tEntry TMP_tmp44_1 = null;
            PrtString TMP_tmp45_1 = ((PrtString)"");
            PrtString TMP_tmp46_1 = ((PrtString)"");
            TMP_tmp0_46 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp1_38 = (PrtString)(((PrtString) String.Format("JOINING ENTRY {0} TO LOG",TMP_tmp0_46)));
            currentMachine.LogLine("" + TMP_tmp1_38);
            TMP_tmp2_37 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp3_36 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp2_37, currentMachine));
            TMP_tmp4_36 = (PrtBool)(await LogHasEntry(TMP_tmp3_36));
            TMP_tmp5_34 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp4_36,((PrtBool)true))));
            if (TMP_tmp5_34)
            {
                TMP_tmp6_30 = (PrtString)(((PrtString) String.Format("Log already has entry")));
                currentMachine.LogLine("" + TMP_tmp6_30);
                return ((PrtBool)false);
            }
            TMP_tmp7_25 = (PMachineValue)(((PMachineValue)((IPrtValue)clock)?.Clone()));
            TMP_tmp8_22 = (PEvent)(new eUpdateHlcReq((new PrtNamedTuple(new string[]{"source","remoteTs"},null, null))));
            TMP_tmp9_18 = (PMachineValue)(currentMachine.self);
            TMP_tmp10_15 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp11_15 = (tTimestamp)(GlobalFunctions.GetClock(TMP_tmp10_15, currentMachine));
            TMP_tmp12_15 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","remoteTs"}, TMP_tmp9_18, TMP_tmp11_15)));
            currentMachine.TrySendEvent(TMP_tmp7_25, (Event)TMP_tmp8_22, TMP_tmp12_15);
            var PGEN_recvEvent_15 = await currentMachine.TryReceiveEvent(typeof(eUpdateHlcResp), typeof(PHalt));
            switch (PGEN_recvEvent_15) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eUpdateHlcResp PGEN_evt_15: {
                    PrtNamedTuple resp_15 = (PrtNamedTuple)(PGEN_evt_15.Payload);
                    TMP_tmp13_13 = (tTimestamp)(((PrtNamedTuple)resp_15)["updatedTimestamp"]);
                    TMP_tmp14_12 = (PrtString)(((PrtString) String.Format("Updated clock timestamp to {0}",TMP_tmp13_13)));
                    currentMachine.LogLine("" + TMP_tmp14_12);
                } break;
            }
            TMP_tmp15_9 = (PrtSeq)(await GetHeadsFromLog());
            headsBeforeJoin = TMP_tmp15_9;
            TMP_tmp16_8 = (PMachineValue)(((PMachineValue)((IPrtValue)heads_1)?.Clone()));
            TMP_tmp17_8 = (PEvent)(new eAddEntryToHeadsReq((new PrtNamedTuple(new string[]{"source","headEntry"},null, null))));
            TMP_tmp18_7 = (PMachineValue)(currentMachine.self);
            TMP_tmp19_7 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp20_7 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","headEntry"}, TMP_tmp18_7, TMP_tmp19_7)));
            currentMachine.TrySendEvent(TMP_tmp16_8, (Event)TMP_tmp17_8, TMP_tmp20_7);
            var PGEN_recvEvent_16 = await currentMachine.TryReceiveEvent(typeof(eAddEntryToHeadsResp), typeof(PHalt));
            switch (PGEN_recvEvent_16) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eAddEntryToHeadsResp PGEN_evt_16: {
                    PrtNamedTuple resp_16 = (PrtNamedTuple)(PGEN_evt_16.Payload);
                    TMP_tmp21_6 = (PrtSeq)(((PrtNamedTuple)resp_16)["newHeads"]);
                    TMP_tmp22_3 = (PrtBool)(((PrtBool)true));
                    TMP_tmp23_2 = (PrtSeq)(GlobalFunctions.Sorted(TMP_tmp21_6, TMP_tmp22_3, currentMachine));
                    TMP_tmp24_2 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp23_2,headsBeforeJoin)));
                    if (TMP_tmp24_2)
                    {
                        returnBool = (PrtBool)(((PrtBool)false));
                    }
                } break;
            }
            TMP_tmp25_1 = (PrtBool)((PrtValues.SafeEquals(returnBool,((PrtBool)false))));
            if (TMP_tmp25_1)
            {
                TMP_tmp26_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
                TMP_tmp27_1 = (PrtString)(((PrtString) String.Format("Log already has entry {0}",TMP_tmp26_1)));
                currentMachine.LogLine("" + TMP_tmp27_1);
                return ((PrtBool)false);
            }
            TMP_tmp28_1 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp29_1 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp30_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp31_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp32_1 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp31_1, currentMachine));
            TMP_tmp33_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp34_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp30_1, TMP_tmp32_1, TMP_tmp33_1)));
            currentMachine.TrySendEvent(TMP_tmp28_1, (Event)TMP_tmp29_1, TMP_tmp34_1);
            var PGEN_recvEvent_17 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_17) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_17: {
                    PrtNamedTuple resp_17 = (PrtNamedTuple)(PGEN_evt_17.Payload);
                    TMP_tmp35_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
                    TMP_tmp36_1 = (PrtString)(((PrtString) String.Format("Added entry {0} to entries storage",TMP_tmp35_1)));
                    currentMachine.LogLine("" + TMP_tmp36_1);
                } break;
            }
            TMP_tmp37_1 = (PMachineValue)(((PMachineValue)((IPrtValue)index)?.Clone()));
            TMP_tmp38_1 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp39_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp40_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp41_1 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp40_1, currentMachine));
            TMP_tmp42_1 = (PrtBool)(((PrtBool)true));
            TMP_tmp43_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp39_1, TMP_tmp41_1, TMP_tmp42_1)));
            currentMachine.TrySendEvent(TMP_tmp37_1, (Event)TMP_tmp38_1, TMP_tmp43_1);
            var PGEN_recvEvent_18 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_18) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_18: {
                    PrtNamedTuple resp_18 = (PrtNamedTuple)(PGEN_evt_18.Payload);
                    TMP_tmp44_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
                    TMP_tmp45_1 = (PrtString)(((PrtString) String.Format("Added entry {0} to index storage",TMP_tmp44_1)));
                    currentMachine.LogLine("" + TMP_tmp45_1);
                } break;
            }
            TMP_tmp46_1 = (PrtString)(((PrtString) String.Format("SUCCESSFULLY JOINED ENTRY TO LOG")));
            currentMachine.LogLine("" + TMP_tmp46_1);
            return ((PrtBool)true);
        }
        public async Task<PrtMap> GetDictionaryFromMemoryStorage_1()
        {
            Log currentMachine = this;
            PrtMap dictionary_4 = new PrtMap();
            PMachineValue TMP_tmp0_47 = null;
            PEvent TMP_tmp1_39 = null;
            PMachineValue TMP_tmp2_38 = null;
            PrtNamedTuple TMP_tmp3_37 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtMap TMP_tmp4_37 = new PrtMap();
            PrtMap TMP_tmp5_35 = new PrtMap();
            TMP_tmp0_47 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp1_39 = (PEvent)(new eGetDictionaryFromMemoryStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_38 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_37 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_38)));
            currentMachine.TrySendEvent(TMP_tmp0_47, (Event)TMP_tmp1_39, TMP_tmp3_37);
            var PGEN_recvEvent_19 = await currentMachine.TryReceiveEvent(typeof(eGetDictionaryFromMemoryStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_19) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetDictionaryFromMemoryStorageResp PGEN_evt_19: {
                    PrtNamedTuple resp_19 = (PrtNamedTuple)(PGEN_evt_19.Payload);
                    TMP_tmp4_37 = (PrtMap)(((PrtNamedTuple)resp_19)["dictionary"]);
                    TMP_tmp5_35 = (PrtMap)(((PrtMap)((PrtMap)((IPrtValue)TMP_tmp4_37)?.Clone())));
                    dictionary_4 = TMP_tmp5_35;
                } break;
            }
            return ((PrtMap)((IPrtValue)dictionary_4)?.Clone());
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_25))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eGetClockLastStateReq), nameof(Anon_26))]
        [OnEventDoAction(typeof(eGetHeadsFromLogReq), nameof(Anon_27))]
        [OnEventDoAction(typeof(eGetAllEntriesFromLogReq), nameof(Anon_28))]
        [OnEventDoAction(typeof(eGetEntryFromLogReq), nameof(Anon_29))]
        [OnEventDoAction(typeof(eDoesLogHaveEntryReq), nameof(Anon_30))]
        [OnEventDoAction(typeof(eAppendNewEntryToLogReq), nameof(Anon_31))]
        [OnEventDoAction(typeof(eJoinLogReq), nameof(Anon_32))]
        [OnEventDoAction(typeof(eJoinEntryReq), nameof(Anon_33))]
        [OnEventDoAction(typeof(eTraverseLogReq), nameof(Anon_34))]
        class WaitForRequest : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class HybridLogicalClock : PMachine
    {
        private PrtString id = ((PrtString)"");
        private tHybridLogicalClock hlc = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtString val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtString)value); }
        public HybridLogicalClock() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_35(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtString id_1 = (PrtString)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tPhysicalTime physicalTime = null;
            PrtInt physicalTimeNow = ((PrtInt)0);
            tTimestamp timestamp = null;
            PrtInt TMP_tmp0_48 = ((PrtInt)0);
            PrtString TMP_tmp1_40 = ((PrtString)"");
            tPhysicalTime TMP_tmp2_39 = null;
            PrtString TMP_tmp3_38 = ((PrtString)"");
            PrtString TMP_tmp4_38 = ((PrtString)"");
            tPhysicalTime TMP_tmp5_36 = null;
            PrtInt TMP_tmp6_31 = ((PrtInt)0);
            PrtString TMP_tmp7_26 = ((PrtString)"");
            PrtInt TMP_tmp8_23 = ((PrtInt)0);
            PrtString TMP_tmp9_19 = ((PrtString)"");
            PrtInt TMP_tmp10_16 = ((PrtInt)0);
            PrtInt TMP_tmp11_16 = ((PrtInt)0);
            PrtString TMP_tmp12_16 = ((PrtString)"");
            tTimestamp TMP_tmp13_14 = null;
            tTimestamp TMP_tmp14_13 = null;
            PrtString TMP_tmp15_10 = ((PrtString)"");
            PrtString TMP_tmp16_9 = ((PrtString)"");
            PrtString TMP_tmp17_9 = ((PrtString)"");
            tPhysicalTime TMP_tmp18_8 = null;
            tTimestamp TMP_tmp19_8 = null;
            tHybridLogicalClock TMP_tmp20_8 = null;
            tHybridLogicalClock TMP_tmp21_7 = null;
            PrtString TMP_tmp22_4 = ((PrtString)"");
            id_1 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp0_48 = (PrtInt)(((PrtInt)(0)));
            TMP_tmp1_40 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp2_39 = (tPhysicalTime)(GlobalFunctions.CreatePhysicalTime(TMP_tmp0_48, TMP_tmp1_40, currentMachine));
            physicalTime = TMP_tmp2_39;
            TMP_tmp3_38 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp4_38 = (PrtString)(((PrtString) String.Format("Created new Physical Time for Hybrid Logical Clock with id {0}",TMP_tmp3_38)));
            currentMachine.LogLine("" + TMP_tmp4_38);
            TMP_tmp5_36 = (tPhysicalTime)(((tPhysicalTime)((IPrtValue)physicalTime)?.Clone()));
            TMP_tmp6_31 = (PrtInt)(GlobalFunctions.GetPhysicalTimeNow(TMP_tmp5_36, currentMachine));
            physicalTimeNow = TMP_tmp6_31;
            TMP_tmp7_26 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp8_23 = (PrtInt)(((PrtInt)((IPrtValue)physicalTimeNow)?.Clone()));
            TMP_tmp9_19 = (PrtString)(((PrtString) String.Format("Now for Hybrid Logical Clock with id {0} is {1}",TMP_tmp7_26,TMP_tmp8_23)));
            currentMachine.LogLine("" + TMP_tmp9_19);
            TMP_tmp10_16 = (PrtInt)(((PrtInt)((IPrtValue)physicalTimeNow)?.Clone()));
            TMP_tmp11_16 = (PrtInt)(((PrtInt)(0)));
            TMP_tmp12_16 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp13_14 = (tTimestamp)(GlobalFunctions.CreateTimestamp(TMP_tmp10_16, TMP_tmp11_16, TMP_tmp12_16, currentMachine));
            timestamp = TMP_tmp13_14;
            TMP_tmp14_13 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp)?.Clone()));
            TMP_tmp15_10 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp16_9 = (PrtString)(((PrtString) String.Format("Created timestamp {0} for Hybrid Logical Clock with id {1}",TMP_tmp14_13,TMP_tmp15_10)));
            currentMachine.LogLine("" + TMP_tmp16_9);
            TMP_tmp17_9 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp18_8 = (tPhysicalTime)(((tPhysicalTime)((IPrtValue)physicalTime)?.Clone()));
            TMP_tmp19_8 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp)?.Clone()));
            TMP_tmp20_8 = (tHybridLogicalClock)(GlobalFunctions.CreateHybridLogicalClock(TMP_tmp17_9, TMP_tmp18_8, TMP_tmp19_8, currentMachine));
            hlc = TMP_tmp20_8;
            TMP_tmp21_7 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp22_4 = (PrtString)(((PrtString) String.Format("Created new Hybrid Logical Clock {0}",TMP_tmp21_7)));
            currentMachine.LogLine("" + TMP_tmp22_4);
        }
        public void Anon_36(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtNamedTuple req_30 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp lastTimestamp_2 = null;
            tTimestamp TMP_tmp0_49 = null;
            PrtString TMP_tmp1_41 = ((PrtString)"");
            PrtString TMP_tmp2_40 = ((PrtString)"");
            PMachineValue TMP_tmp3_39 = null;
            PMachineValue TMP_tmp4_39 = null;
            PEvent TMP_tmp5_37 = null;
            PrtInt TMP_tmp6_32 = ((PrtInt)0);
            tTimestamp TMP_tmp7_27 = null;
            PrtNamedTuple TMP_tmp8_24 = (new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null));
            TMP_tmp0_49 = (tTimestamp)(((tTimestamp)((IPrtValue)lastTimestamp_2)?.Clone()));
            TMP_tmp1_41 = (PrtString)(((PrtString)((IPrtValue)id)?.Clone()));
            TMP_tmp2_40 = (PrtString)(((PrtString) String.Format("Got last timestamp {0} from Hybrid Logical Clock with id {1}",TMP_tmp0_49,TMP_tmp1_41)));
            currentMachine.LogLine("" + TMP_tmp2_40);
            TMP_tmp3_39 = (PMachineValue)(((PrtNamedTuple)req_30)["source"]);
            TMP_tmp4_39 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_39)?.Clone()));
            TMP_tmp5_37 = (PEvent)(new eGetLastTimestampResp((new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null))));
            TMP_tmp6_32 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp7_27 = (tTimestamp)(((tTimestamp)((IPrtValue)lastTimestamp_2)?.Clone()));
            TMP_tmp8_24 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","lastTimestamp"}, TMP_tmp6_32, TMP_tmp7_27)));
            currentMachine.TrySendEvent(TMP_tmp4_39, (Event)TMP_tmp5_37, TMP_tmp8_24);
        }
        public void Anon_37(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtNamedTuple req_31 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp previousTimestamp = null;
            PrtNamedTuple nowResponse = (new PrtNamedTuple(new string[]{"newHlc","timestamp"},null, null));
            tTimestamp extractedTimestamp = null;
            PrtInt comparisonToPrevious = ((PrtInt)0);
            tHybridLogicalClock TMP_tmp0_50 = null;
            tTimestamp TMP_tmp1_42 = null;
            tTimestamp TMP_tmp2_41 = null;
            PrtString TMP_tmp3_40 = ((PrtString)"");
            PrtString TMP_tmp4_40 = ((PrtString)"");
            tHybridLogicalClock TMP_tmp5_38 = null;
            PrtNamedTuple TMP_tmp6_33 = (new PrtNamedTuple(new string[]{"newHlc","timestamp"},null, null));
            PrtString TMP_tmp7_28 = ((PrtString)"");
            PrtNamedTuple TMP_tmp8_25 = (new PrtNamedTuple(new string[]{"newHlc","timestamp"},null, null));
            PrtString TMP_tmp9_20 = ((PrtString)"");
            tHybridLogicalClock TMP_tmp10_17 = null;
            tHybridLogicalClock TMP_tmp11_17 = null;
            tTimestamp TMP_tmp12_17 = null;
            tTimestamp TMP_tmp13_15 = null;
            tTimestamp TMP_tmp14_14 = null;
            tTimestamp TMP_tmp15_11 = null;
            PrtInt TMP_tmp16_10 = ((PrtInt)0);
            PMachineValue TMP_tmp17_10 = null;
            PMachineValue TMP_tmp18_9 = null;
            PEvent TMP_tmp19_9 = null;
            PrtInt TMP_tmp20_9 = ((PrtInt)0);
            tTimestamp TMP_tmp21_8 = null;
            PrtInt TMP_tmp22_5 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp23_3 = (new PrtNamedTuple(new string[]{"status","now","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)));
            TMP_tmp0_50 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp1_42 = (tTimestamp)(GlobalFunctions.GetLastTimestamp(TMP_tmp0_50, currentMachine));
            previousTimestamp = TMP_tmp1_42;
            TMP_tmp2_41 = (tTimestamp)(((tTimestamp)((IPrtValue)previousTimestamp)?.Clone()));
            TMP_tmp3_40 = (PrtString)(((PrtString)((IPrtValue)id)?.Clone()));
            TMP_tmp4_40 = (PrtString)(((PrtString) String.Format("Got last timestamp {0} from Hybrid Logical Clock with id {1}",TMP_tmp2_41,TMP_tmp3_40)));
            currentMachine.LogLine("" + TMP_tmp4_40);
            TMP_tmp5_38 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp6_33 = (PrtNamedTuple)(GlobalFunctions.GetHlcNow(TMP_tmp5_38, currentMachine));
            nowResponse = TMP_tmp6_33;
            TMP_tmp7_28 = (PrtString)(((PrtString)((IPrtValue)id)?.Clone()));
            TMP_tmp8_25 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)nowResponse)?.Clone()));
            TMP_tmp9_20 = (PrtString)(((PrtString) String.Format("Now for Hybrid Logical Clock with id {0} is {1}",TMP_tmp7_28,TMP_tmp8_25)));
            currentMachine.LogLine("" + TMP_tmp9_20);
            TMP_tmp10_17 = (tHybridLogicalClock)(((PrtNamedTuple)nowResponse)["newHlc"]);
            TMP_tmp11_17 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)TMP_tmp10_17)?.Clone()));
            hlc = TMP_tmp11_17;
            TMP_tmp12_17 = (tTimestamp)(((PrtNamedTuple)nowResponse)["timestamp"]);
            TMP_tmp13_15 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp12_17)?.Clone()));
            extractedTimestamp = TMP_tmp13_15;
            TMP_tmp14_14 = (tTimestamp)(((tTimestamp)((IPrtValue)extractedTimestamp)?.Clone()));
            TMP_tmp15_11 = (tTimestamp)(((tTimestamp)((IPrtValue)previousTimestamp)?.Clone()));
            TMP_tmp16_10 = (PrtInt)(GlobalFunctions.CompareTimestamps(TMP_tmp14_14, TMP_tmp15_11, currentMachine));
            comparisonToPrevious = TMP_tmp16_10;
            TMP_tmp17_10 = (PMachineValue)(((PrtNamedTuple)req_31)["source"]);
            TMP_tmp18_9 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp17_10)?.Clone()));
            TMP_tmp19_9 = (PEvent)(new eGetNowResp((new PrtNamedTuple(new string[]{"status","now","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)))));
            TMP_tmp20_9 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp21_8 = (tTimestamp)(((tTimestamp)((IPrtValue)extractedTimestamp)?.Clone()));
            TMP_tmp22_5 = (PrtInt)(((PrtInt)((IPrtValue)comparisonToPrevious)?.Clone()));
            TMP_tmp23_3 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","now","comparisonToPrevious"}, TMP_tmp20_9, TMP_tmp21_8, TMP_tmp22_5)));
            currentMachine.TrySendEvent(TMP_tmp18_9, (Event)TMP_tmp19_9, TMP_tmp23_3);
        }
        public void Anon_38(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtNamedTuple req_32 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp previousTimestamp_1 = null;
            PrtInt comparisonToPrevious_1 = ((PrtInt)0);
            PrtNamedTuple updateResponse = (new PrtNamedTuple(new string[]{"newHlc","updatedTimestamp"},null, null));
            tTimestamp timestamp_1 = null;
            tHybridLogicalClock TMP_tmp0_51 = null;
            tTimestamp TMP_tmp1_43 = null;
            tTimestamp TMP_tmp2_42 = null;
            PrtString TMP_tmp3_41 = ((PrtString)"");
            PrtString TMP_tmp4_41 = ((PrtString)"");
            tHybridLogicalClock TMP_tmp5_39 = null;
            tTimestamp TMP_tmp6_34 = null;
            PrtNamedTuple TMP_tmp7_29 = (new PrtNamedTuple(new string[]{"newHlc","updatedTimestamp"},null, null));
            PrtString TMP_tmp8_26 = ((PrtString)"");
            tTimestamp TMP_tmp9_21 = null;
            PrtString TMP_tmp10_18 = ((PrtString)"");
            tHybridLogicalClock TMP_tmp11_18 = null;
            tHybridLogicalClock TMP_tmp12_18 = null;
            tTimestamp TMP_tmp13_16 = null;
            tTimestamp TMP_tmp14_15 = null;
            tTimestamp TMP_tmp15_12 = null;
            tTimestamp TMP_tmp16_11 = null;
            PrtInt TMP_tmp17_11 = ((PrtInt)0);
            PMachineValue TMP_tmp18_10 = null;
            PMachineValue TMP_tmp19_10 = null;
            PEvent TMP_tmp20_10 = null;
            PrtInt TMP_tmp21_9 = ((PrtInt)0);
            tTimestamp TMP_tmp22_6 = null;
            PrtInt TMP_tmp23_4 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp24_3 = (new PrtNamedTuple(new string[]{"status","updatedTimestamp","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)));
            TMP_tmp0_51 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp1_43 = (tTimestamp)(GlobalFunctions.GetLastTimestamp(TMP_tmp0_51, currentMachine));
            previousTimestamp_1 = TMP_tmp1_43;
            TMP_tmp2_42 = (tTimestamp)(((tTimestamp)((IPrtValue)previousTimestamp_1)?.Clone()));
            TMP_tmp3_41 = (PrtString)(((PrtString)((IPrtValue)id)?.Clone()));
            TMP_tmp4_41 = (PrtString)(((PrtString) String.Format("Got last timestamp {0} from Hybrid Logical Clock with id {1}",TMP_tmp2_42,TMP_tmp3_41)));
            currentMachine.LogLine("" + TMP_tmp4_41);
            TMP_tmp5_39 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp6_34 = (tTimestamp)(((PrtNamedTuple)req_32)["remoteTs"]);
            TMP_tmp7_29 = (PrtNamedTuple)(GlobalFunctions.UpdateHlc(TMP_tmp5_39, TMP_tmp6_34, currentMachine));
            updateResponse = TMP_tmp7_29;
            TMP_tmp8_26 = (PrtString)(((PrtString)((IPrtValue)id)?.Clone()));
            TMP_tmp9_21 = (tTimestamp)(((PrtNamedTuple)updateResponse)["updatedTimestamp"]);
            TMP_tmp10_18 = (PrtString)(((PrtString) String.Format("Updated HLC with id {0} to have last timestamp: {1}",TMP_tmp8_26,TMP_tmp9_21)));
            currentMachine.LogLine("" + TMP_tmp10_18);
            TMP_tmp11_18 = (tHybridLogicalClock)(((PrtNamedTuple)updateResponse)["newHlc"]);
            TMP_tmp12_18 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)TMP_tmp11_18)?.Clone()));
            hlc = TMP_tmp12_18;
            TMP_tmp13_16 = (tTimestamp)(((PrtNamedTuple)updateResponse)["updatedTimestamp"]);
            TMP_tmp14_15 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp13_16)?.Clone()));
            timestamp_1 = TMP_tmp14_15;
            TMP_tmp15_12 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp_1)?.Clone()));
            TMP_tmp16_11 = (tTimestamp)(((tTimestamp)((IPrtValue)previousTimestamp_1)?.Clone()));
            TMP_tmp17_11 = (PrtInt)(GlobalFunctions.CompareTimestamps(TMP_tmp15_12, TMP_tmp16_11, currentMachine));
            comparisonToPrevious_1 = TMP_tmp17_11;
            TMP_tmp18_10 = (PMachineValue)(((PrtNamedTuple)req_32)["source"]);
            TMP_tmp19_10 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp18_10)?.Clone()));
            TMP_tmp20_10 = (PEvent)(new eUpdateHlcResp((new PrtNamedTuple(new string[]{"status","updatedTimestamp","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)))));
            TMP_tmp21_9 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp22_6 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp_1)?.Clone()));
            TMP_tmp23_4 = (PrtInt)(((PrtInt)((IPrtValue)comparisonToPrevious_1)?.Clone()));
            TMP_tmp24_3 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","updatedTimestamp","comparisonToPrevious"}, TMP_tmp21_9, TMP_tmp22_6, TMP_tmp23_4)));
            currentMachine.TrySendEvent(TMP_tmp19_10, (Event)TMP_tmp20_10, TMP_tmp24_3);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Active))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_35))]
        [OnEventDoAction(typeof(eGetLastTimestampReq), nameof(Anon_36))]
        [OnEventDoAction(typeof(eGetNowReq), nameof(Anon_37))]
        [OnEventDoAction(typeof(eUpdateHlcReq), nameof(Anon_38))]
        class Active : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class EntryMachine : PMachine
    {
        public class ConstructorEvent : PEvent{public ConstructorEvent(IPrtValue val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((IPrtValue)value); }
        public EntryMachine() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAddEntryToSyncReq));
            this.sends.Add(nameof(eAddEntryToSyncResp));
            this.sends.Add(nameof(eAddOperationReq));
            this.sends.Add(nameof(eAddOperationResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
            this.sends.Add(nameof(eApplyOperationReq));
            this.sends.Add(nameof(eApplyOperationResp));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eClearAllValuesFromStorageReq));
            this.sends.Add(nameof(eClearAllValuesFromStorageResp));
            this.sends.Add(nameof(eCreateEntryReq));
            this.sends.Add(nameof(eCreateEntryResp));
            this.sends.Add(nameof(eDeleteValueFromStorageReq));
            this.sends.Add(nameof(eDeleteValueFromStorageResp));
            this.sends.Add(nameof(eDoesLogHaveEntryReq));
            this.sends.Add(nameof(eDoesLogHaveEntryResp));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.sends.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.sends.Add(nameof(eGetAllEntriesFromLogReq));
            this.sends.Add(nameof(eGetAllEntriesFromLogResp));
            this.sends.Add(nameof(eGetAllValuesFromStorageReq));
            this.sends.Add(nameof(eGetAllValuesFromStorageResp));
            this.sends.Add(nameof(eGetClockLastStateReq));
            this.sends.Add(nameof(eGetClockLastStateResp));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.sends.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.sends.Add(nameof(eGetEntryFromLogReq));
            this.sends.Add(nameof(eGetEntryFromLogResp));
            this.sends.Add(nameof(eGetHeadsFromLogReq));
            this.sends.Add(nameof(eGetHeadsFromLogResp));
            this.sends.Add(nameof(eGetLastTimestampReq));
            this.sends.Add(nameof(eGetLastTimestampResp));
            this.sends.Add(nameof(eGetNowReq));
            this.sends.Add(nameof(eGetNowResp));
            this.sends.Add(nameof(eGetValueFromStorageReq));
            this.sends.Add(nameof(eGetValueFromStorageResp));
            this.sends.Add(nameof(eJoinEntryReq));
            this.sends.Add(nameof(eJoinEntryResp));
            this.sends.Add(nameof(eJoinLogReq));
            this.sends.Add(nameof(eJoinLogResp));
            this.sends.Add(nameof(ePutEntriesInHeadsReq));
            this.sends.Add(nameof(ePutEntriesInHeadsResp));
            this.sends.Add(nameof(ePutValueInStorageReq));
            this.sends.Add(nameof(ePutValueInStorageResp));
            this.sends.Add(nameof(eSetEntriesInHeadsReq));
            this.sends.Add(nameof(eSetEntriesInHeadsResp));
            this.sends.Add(nameof(eTraverseLogReq));
            this.sends.Add(nameof(eTraverseLogResp));
            this.sends.Add(nameof(eUpdateHlcReq));
            this.sends.Add(nameof(eUpdateHlcResp));
            this.sends.Add(nameof(PHalt));
            this.receives.Add(nameof(eAddEntryToHeadsReq));
            this.receives.Add(nameof(eAddEntryToHeadsResp));
            this.receives.Add(nameof(eAddEntryToSyncReq));
            this.receives.Add(nameof(eAddEntryToSyncResp));
            this.receives.Add(nameof(eAddOperationReq));
            this.receives.Add(nameof(eAddOperationResp));
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
            this.receives.Add(nameof(eApplyOperationReq));
            this.receives.Add(nameof(eApplyOperationResp));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eClearAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eClearAllValuesFromStorageReq));
            this.receives.Add(nameof(eClearAllValuesFromStorageResp));
            this.receives.Add(nameof(eCreateEntryReq));
            this.receives.Add(nameof(eCreateEntryResp));
            this.receives.Add(nameof(eDeleteValueFromStorageReq));
            this.receives.Add(nameof(eDeleteValueFromStorageResp));
            this.receives.Add(nameof(eDoesLogHaveEntryReq));
            this.receives.Add(nameof(eDoesLogHaveEntryResp));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsReq));
            this.receives.Add(nameof(eGetAllEntriesFromHeadsResp));
            this.receives.Add(nameof(eGetAllEntriesFromLogReq));
            this.receives.Add(nameof(eGetAllEntriesFromLogResp));
            this.receives.Add(nameof(eGetAllValuesFromStorageReq));
            this.receives.Add(nameof(eGetAllValuesFromStorageResp));
            this.receives.Add(nameof(eGetClockLastStateReq));
            this.receives.Add(nameof(eGetClockLastStateResp));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageReq));
            this.receives.Add(nameof(eGetDictionaryFromMemoryStorageResp));
            this.receives.Add(nameof(eGetEntryFromLogReq));
            this.receives.Add(nameof(eGetEntryFromLogResp));
            this.receives.Add(nameof(eGetHeadsFromLogReq));
            this.receives.Add(nameof(eGetHeadsFromLogResp));
            this.receives.Add(nameof(eGetLastTimestampReq));
            this.receives.Add(nameof(eGetLastTimestampResp));
            this.receives.Add(nameof(eGetNowReq));
            this.receives.Add(nameof(eGetNowResp));
            this.receives.Add(nameof(eGetValueFromStorageReq));
            this.receives.Add(nameof(eGetValueFromStorageResp));
            this.receives.Add(nameof(eJoinEntryReq));
            this.receives.Add(nameof(eJoinEntryResp));
            this.receives.Add(nameof(eJoinLogReq));
            this.receives.Add(nameof(eJoinLogResp));
            this.receives.Add(nameof(ePutEntriesInHeadsReq));
            this.receives.Add(nameof(ePutEntriesInHeadsResp));
            this.receives.Add(nameof(ePutValueInStorageReq));
            this.receives.Add(nameof(ePutValueInStorageResp));
            this.receives.Add(nameof(eSetEntriesInHeadsReq));
            this.receives.Add(nameof(eSetEntriesInHeadsResp));
            this.receives.Add(nameof(eTraverseLogReq));
            this.receives.Add(nameof(eTraverseLogResp));
            this.receives.Add(nameof(eUpdateHlcReq));
            this.receives.Add(nameof(eUpdateHlcResp));
            this.receives.Add(nameof(PHalt));
        }
        
        public void Anon_39(Event currentMachine_dequeuedEvent)
        {
            EntryMachine currentMachine = this;
            PrtNamedTuple req_33 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tEntry createdEntry_1 = null;
            PrtString TMP_tmp0_52 = ((PrtString)"");
            PrtString TMP_tmp1_44 = ((PrtString)"");
            PrtString TMP_tmp2_43 = ((PrtString)"");
            tTimestamp TMP_tmp3_42 = null;
            PrtSet TMP_tmp4_42 = new PrtSet();
            PrtSet TMP_tmp5_40 = new PrtSet();
            tEntry TMP_tmp6_35 = null;
            tEntry TMP_tmp7_30 = null;
            PrtString TMP_tmp8_27 = ((PrtString)"");
            PMachineValue TMP_tmp9_22 = null;
            PMachineValue TMP_tmp10_19 = null;
            PEvent TMP_tmp11_19 = null;
            PrtInt TMP_tmp12_19 = ((PrtInt)0);
            tEntry TMP_tmp13_17 = null;
            PrtNamedTuple TMP_tmp14_16 = (new PrtNamedTuple(new string[]{"status","createdEntry"},((PrtInt)0), null));
            TMP_tmp0_52 = (PrtString)(((PrtNamedTuple)req_33)["identity"]);
            TMP_tmp1_44 = (PrtString)(((PrtNamedTuple)req_33)["id"]);
            TMP_tmp2_43 = (PrtString)(((PrtNamedTuple)req_33)["entryData"]);
            TMP_tmp3_42 = (tTimestamp)(((PrtNamedTuple)req_33)["clock"]);
            TMP_tmp4_42 = (PrtSet)(((PrtNamedTuple)req_33)["next"]);
            TMP_tmp5_40 = (PrtSet)(((PrtNamedTuple)req_33)["refs"]);
            TMP_tmp6_35 = (tEntry)(GlobalFunctions.CreateEntry(TMP_tmp0_52, TMP_tmp1_44, TMP_tmp2_43, TMP_tmp3_42, TMP_tmp4_42, TMP_tmp5_40, currentMachine));
            createdEntry_1 = TMP_tmp6_35;
            TMP_tmp7_30 = (tEntry)(((tEntry)((IPrtValue)createdEntry_1)?.Clone()));
            TMP_tmp8_27 = (PrtString)(((PrtString) String.Format("Created new entry {0}",TMP_tmp7_30)));
            currentMachine.LogLine("" + TMP_tmp8_27);
            TMP_tmp9_22 = (PMachineValue)(((PrtNamedTuple)req_33)["source"]);
            TMP_tmp10_19 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp9_22)?.Clone()));
            TMP_tmp11_19 = (PEvent)(new eCreateEntryResp((new PrtNamedTuple(new string[]{"status","createdEntry"},((PrtInt)0), null))));
            TMP_tmp12_19 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp13_17 = (tEntry)(((tEntry)((IPrtValue)createdEntry_1)?.Clone()));
            TMP_tmp14_16 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","createdEntry"}, TMP_tmp12_19, TMP_tmp13_17)));
            currentMachine.TrySendEvent(TMP_tmp10_19, (Event)TMP_tmp11_19, TMP_tmp14_16);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Active))]
        class __InitState__ : State { }
        
        [OnEventDoAction(typeof(eCreateEntryReq), nameof(Anon_39))]
        class Active : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class TimestampsAreMonotonicallyIncreasing : PMonitor
    {
        static TimestampsAreMonotonicallyIncreasing() {
            observes.Add(nameof(eGetNowResp));
            observes.Add(nameof(eUpdateHlcResp));
        }
        
        public void Anon_40(Event currentMachine_dequeuedEvent)
        {
            TimestampsAreMonotonicallyIncreasing currentMachine = this;
            PrtNamedTuple resp_20 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_53 = ((PrtInt)0);
            PrtBool TMP_tmp1_45 = ((PrtBool)false);
            PrtString TMP_tmp2_44 = ((PrtString)"");
            PrtString TMP_tmp3_43 = ((PrtString)"");
            PrtString TMP_tmp4_43 = ((PrtString)"");
            TMP_tmp0_53 = (PrtInt)(((PrtNamedTuple)resp_20)["comparisonToPrevious"]);
            TMP_tmp1_45 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp0_53,((PrtInt)(1)))));
            TMP_tmp2_44 = (PrtString)(((PrtString) String.Format("PSpec/HybridLogicalClockSpec.p:4:13")));
            TMP_tmp3_43 = (PrtString)(((PrtString) String.Format("Timestamps are not monotonically increasing.")));
            TMP_tmp4_43 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp2_44,TMP_tmp3_43)));
            currentMachine.TryAssert(TMP_tmp1_45,"Assertion Failed: " + TMP_tmp4_43);
        }
        public void Anon_41(Event currentMachine_dequeuedEvent)
        {
            TimestampsAreMonotonicallyIncreasing currentMachine = this;
            PrtNamedTuple resp_21 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_54 = ((PrtInt)0);
            PrtBool TMP_tmp1_46 = ((PrtBool)false);
            PrtString TMP_tmp2_45 = ((PrtString)"");
            PrtString TMP_tmp3_44 = ((PrtString)"");
            PrtString TMP_tmp4_44 = ((PrtString)"");
            TMP_tmp0_54 = (PrtInt)(((PrtNamedTuple)resp_21)["comparisonToPrevious"]);
            TMP_tmp1_46 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp0_54,((PrtInt)(1)))));
            TMP_tmp2_45 = (PrtString)(((PrtString) String.Format("PSpec/HybridLogicalClockSpec.p:9:13")));
            TMP_tmp3_44 = (PrtString)(((PrtString) String.Format("Timestamps are not monotonically increasing.")));
            TMP_tmp4_44 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp2_45,TMP_tmp3_44)));
            currentMachine.TryAssert(TMP_tmp1_46,"Assertion Failed: " + TMP_tmp4_44);
        }
        [Start]
        [OnEventDoAction(typeof(eGetNowResp), nameof(Anon_40))]
        [OnEventDoAction(typeof(eUpdateHlcResp), nameof(Anon_41))]
        class Init : State
        {
        }
    }
}
// TODO: Implement the Foreign Type tMemoryStorage
// TODO: Implement the Foreign Type tTraversalStopper
// TODO: Implement the Foreign Type tPhysicalTime
// TODO: Implement the Foreign Type tHybridLogicalClock
// TODO: Implement the Foreign Type tTimestamp
// TODO: Implement the Foreign Type tEntry
// TODO: NamedModule Log_1
// TODO: NamedModule HybridLogicalClock_1
// TODO: NamedModule Heads_1
// TODO: NamedModule MemoryStorage_1
namespace PImplementation
{
    public class I_Database : PMachineValue {
        public I_Database (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_Sync : PMachineValue {
        public I_Sync (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_MemoryStorage : PMachineValue {
        public I_MemoryStorage (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_Heads : PMachineValue {
        public I_Heads (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_Log : PMachineValue {
        public I_Log (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_HybridLogicalClock : PMachineValue {
        public I_HybridLogicalClock (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public class I_EntryMachine : PMachineValue {
        public I_EntryMachine (ActorId machine, List<string> permissions) : base(machine, permissions) { }
    }
    
    public partial class PHelper {
        public static void InitializeInterfaces() {
            PInterfaces.Clear();
            PInterfaces.AddInterface(nameof(I_Database), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_Sync), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_MemoryStorage), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_Heads), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_Log), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_HybridLogicalClock), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_EntryMachine), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAddEntryToSyncReq), nameof(eAddEntryToSyncResp), nameof(eAddOperationReq), nameof(eAddOperationResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eApplyOperationReq), nameof(eApplyOperationResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetDictionaryFromMemoryStorageReq), nameof(eGetDictionaryFromMemoryStorageResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
        }
    }
    
}
namespace PImplementation
{
    public partial class PHelper {
        public static void InitializeEnums() {
            PrtEnum.Clear();
            PrtEnum.AddEnumElements(new [] {"ERROR","SUCCESS"}, new [] {0,1});
        }
    }
    
}
#pragma warning restore 162, 219, 414
