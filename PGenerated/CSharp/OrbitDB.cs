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
    internal partial class MemoryStorage : PMachine
    {
        private tMemoryStorage memoryStorage = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtString val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtString)value); }
        public MemoryStorage() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
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
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
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
        
        public void Anon(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtString name = (PrtString)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtString TMP_tmp0 = ((PrtString)"");
            tMemoryStorage TMP_tmp1 = null;
            TMP_tmp0 = (PrtString)(((PrtString)((IPrtValue)name)?.Clone()));
            TMP_tmp1 = (tMemoryStorage)(GlobalFunctions.CreateMemoryStorage(TMP_tmp0, currentMachine));
            memoryStorage = TMP_tmp1;
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_1(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_1 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            TMP_tmp0_1 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req)?.Clone()));
            currentMachine.TryGotoState<PuttingValueInStorage>(TMP_tmp0_1);
            return;
        }
        public void Anon_2(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_1 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_2 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            TMP_tmp0_2 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_1)?.Clone()));
            currentMachine.TryGotoState<DeletingValueFromStorage>(TMP_tmp0_2);
            return;
        }
        public void Anon_3(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_2 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_3 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            TMP_tmp0_3 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_2)?.Clone()));
            currentMachine.TryGotoState<GettingValueFromStorage>(TMP_tmp0_3);
            return;
        }
        public void Anon_4(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_3 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_4 = (new PrtNamedTuple(new string[]{"source"},null));
            TMP_tmp0_4 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_3)?.Clone()));
            currentMachine.TryGotoState<ClearingAllDataFromStorage>(TMP_tmp0_4);
            return;
        }
        public void Anon_5(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_4 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtNamedTuple TMP_tmp0_5 = (new PrtNamedTuple(new string[]{"source"},null));
            TMP_tmp0_5 = (PrtNamedTuple)(((PrtNamedTuple)((IPrtValue)req_4)?.Clone()));
            currentMachine.TryGotoState<GettingAllDataFromStorage>(TMP_tmp0_5);
            return;
        }
        public void Anon_6(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_5 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tMemoryStorage TMP_tmp0_6 = null;
            PrtString TMP_tmp1_1 = ((PrtString)"");
            IPrtValue TMP_tmp2 = null;
            tMemoryStorage TMP_tmp3 = null;
            PMachineValue TMP_tmp4 = null;
            PMachineValue TMP_tmp5 = null;
            PEvent TMP_tmp6 = null;
            PrtInt TMP_tmp7 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp8 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_6 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_1 = (PrtString)(((PrtNamedTuple)req_5)["key"]);
            TMP_tmp2 = (IPrtValue)(((PrtNamedTuple)req_5)["value"]);
            TMP_tmp3 = (tMemoryStorage)(GlobalFunctions.PutValueInMemoryStorage(TMP_tmp0_6, TMP_tmp1_1, TMP_tmp2, currentMachine));
            memoryStorage = TMP_tmp3;
            TMP_tmp4 = (PMachineValue)(((PrtNamedTuple)req_5)["source"]);
            TMP_tmp5 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp4)?.Clone()));
            TMP_tmp6 = (PEvent)(new ePutValueInStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp7 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp8 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp7)));
            currentMachine.TrySendEvent(TMP_tmp5, (Event)TMP_tmp6, TMP_tmp8);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_7(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_6 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tMemoryStorage TMP_tmp0_7 = null;
            PrtString TMP_tmp1_2 = ((PrtString)"");
            tMemoryStorage TMP_tmp2_1 = null;
            PMachineValue TMP_tmp3_1 = null;
            PMachineValue TMP_tmp4_1 = null;
            PEvent TMP_tmp5_1 = null;
            PrtInt TMP_tmp6_1 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp7_1 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_7 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_2 = (PrtString)(((PrtNamedTuple)req_6)["key"]);
            TMP_tmp2_1 = (tMemoryStorage)(GlobalFunctions.DeleteValueFromMemoryStorage(TMP_tmp0_7, TMP_tmp1_2, currentMachine));
            memoryStorage = TMP_tmp2_1;
            TMP_tmp3_1 = (PMachineValue)(((PrtNamedTuple)req_6)["source"]);
            TMP_tmp4_1 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_1)?.Clone()));
            TMP_tmp5_1 = (PEvent)(new eDeleteValueFromStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp6_1 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp7_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp6_1)));
            currentMachine.TrySendEvent(TMP_tmp4_1, (Event)TMP_tmp5_1, TMP_tmp7_1);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_8(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_7 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            IPrtValue value = null;
            tMemoryStorage TMP_tmp0_8 = null;
            PrtString TMP_tmp1_3 = ((PrtString)"");
            IPrtValue TMP_tmp2_2 = null;
            PMachineValue TMP_tmp3_2 = null;
            PMachineValue TMP_tmp4_2 = null;
            PEvent TMP_tmp5_2 = null;
            PrtInt TMP_tmp6_2 = ((PrtInt)0);
            IPrtValue TMP_tmp7_2 = null;
            PrtNamedTuple TMP_tmp8_1 = (new PrtNamedTuple(new string[]{"status","value"},((PrtInt)0), null));
            TMP_tmp0_8 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_3 = (PrtString)(((PrtNamedTuple)req_7)["key"]);
            TMP_tmp2_2 = (IPrtValue)(GlobalFunctions.GetValueFromMemoryStorage(TMP_tmp0_8, TMP_tmp1_3, currentMachine));
            value = TMP_tmp2_2;
            TMP_tmp3_2 = (PMachineValue)(((PrtNamedTuple)req_7)["source"]);
            TMP_tmp4_2 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_2)?.Clone()));
            TMP_tmp5_2 = (PEvent)(new eGetValueFromStorageResp((new PrtNamedTuple(new string[]{"status","value"},((PrtInt)0), null))));
            TMP_tmp6_2 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp7_2 = (IPrtValue)(((IPrtValue)((IPrtValue)value)?.Clone()));
            TMP_tmp8_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","value"}, TMP_tmp6_2, TMP_tmp7_2)));
            currentMachine.TrySendEvent(TMP_tmp4_2, (Event)TMP_tmp5_2, TMP_tmp8_1);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_9(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_8 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tMemoryStorage TMP_tmp0_9 = null;
            tMemoryStorage TMP_tmp1_4 = null;
            PMachineValue TMP_tmp2_3 = null;
            PMachineValue TMP_tmp3_3 = null;
            PEvent TMP_tmp4_3 = null;
            PrtInt TMP_tmp5_3 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp6_3 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_9 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_4 = (tMemoryStorage)(GlobalFunctions.ClearMemoryStorage(TMP_tmp0_9, currentMachine));
            memoryStorage = TMP_tmp1_4;
            TMP_tmp2_3 = (PMachineValue)(((PrtNamedTuple)req_8)["source"]);
            TMP_tmp3_3 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_3)?.Clone()));
            TMP_tmp4_3 = (PEvent)(new eClearAllValuesFromStorageResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp5_3 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_3 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp5_3)));
            currentMachine.TrySendEvent(TMP_tmp3_3, (Event)TMP_tmp4_3, TMP_tmp6_3);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public void Anon_10(Event currentMachine_dequeuedEvent)
        {
            MemoryStorage currentMachine = this;
            PrtNamedTuple req_9 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSet retrivedValues = new PrtSet();
            tMemoryStorage TMP_tmp0_10 = null;
            PrtSet TMP_tmp1_5 = new PrtSet();
            PrtSet TMP_tmp2_4 = new PrtSet();
            PMachineValue TMP_tmp3_4 = null;
            PMachineValue TMP_tmp4_4 = null;
            PEvent TMP_tmp5_4 = null;
            PrtInt TMP_tmp6_4 = ((PrtInt)0);
            PrtSet TMP_tmp7_3 = new PrtSet();
            PrtNamedTuple TMP_tmp8_2 = (new PrtNamedTuple(new string[]{"status","retrivedValues"},((PrtInt)0), new PrtSet()));
            TMP_tmp0_10 = (tMemoryStorage)(((tMemoryStorage)((IPrtValue)memoryStorage)?.Clone()));
            TMP_tmp1_5 = (PrtSet)(GlobalFunctions.GetAllValuesFromMemoryStorage(TMP_tmp0_10, currentMachine));
            TMP_tmp2_4 = (PrtSet)(((PrtSet)((PrtSet)((IPrtValue)TMP_tmp1_5)?.Clone())));
            retrivedValues = TMP_tmp2_4;
            TMP_tmp3_4 = (PMachineValue)(((PrtNamedTuple)req_9)["source"]);
            TMP_tmp4_4 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_4)?.Clone()));
            TMP_tmp5_4 = (PEvent)(new eGetAllValuesFromStorageResp((new PrtNamedTuple(new string[]{"status","retrivedValues"},((PrtInt)0), new PrtSet()))));
            TMP_tmp6_4 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp7_3 = (PrtSet)(((PrtSet)((IPrtValue)retrivedValues)?.Clone()));
            TMP_tmp8_2 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","retrivedValues"}, TMP_tmp6_4, TMP_tmp7_3)));
            currentMachine.TrySendEvent(TMP_tmp4_4, (Event)TMP_tmp5_4, TMP_tmp8_2);
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(ePutValueInStorageReq), nameof(Anon_1))]
        [OnEventDoAction(typeof(eDeleteValueFromStorageReq), nameof(Anon_2))]
        [OnEventDoAction(typeof(eGetValueFromStorageReq), nameof(Anon_3))]
        [OnEventDoAction(typeof(eClearAllValuesFromStorageReq), nameof(Anon_4))]
        [OnEventDoAction(typeof(eGetAllValuesFromStorageReq), nameof(Anon_5))]
        class WaitForRequest : State
        {
        }
        [OnEntry(nameof(Anon_6))]
        class PuttingValueInStorage : State
        {
        }
        [OnEntry(nameof(Anon_7))]
        class DeletingValueFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_8))]
        class GettingValueFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_9))]
        class ClearingAllDataFromStorage : State
        {
        }
        [OnEntry(nameof(Anon_10))]
        class GettingAllDataFromStorage : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class Heads : PMachine
    {
        private PMachineValue storage = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtSet val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtSet)value); }
        public Heads() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
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
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
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
            this.creates.Add(nameof(I_MemoryStorage));
        }
        
        public async Task Anon_11(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtSet heads = (PrtSet)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtString TMP_tmp0_11 = ((PrtString)"");
            PMachineValue TMP_tmp1_6 = null;
            PMachineValue TMP_tmp2_5 = null;
            PrtSet TMP_tmp3_5 = new PrtSet();
            TMP_tmp0_11 = (PrtString)(((PrtString) String.Format("Heads")));
            TMP_tmp1_6 = (PMachineValue)(currentMachine.CreateInterface<I_MemoryStorage>( currentMachine, TMP_tmp0_11));
            storage = TMP_tmp1_6;
            TMP_tmp2_5 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp3_5 = (PrtSet)(((PrtSet)((IPrtValue)heads)?.Clone()));
            await PutHeads(TMP_tmp2_5, TMP_tmp3_5);
            currentMachine.TryGotoState<Active>();
            return;
        }
        public async Task Anon_12(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_10 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_12 = null;
            PrtSet TMP_tmp1_7 = new PrtSet();
            PMachineValue TMP_tmp2_6 = null;
            PMachineValue TMP_tmp3_6 = null;
            PEvent TMP_tmp4_5 = null;
            PrtInt TMP_tmp5_5 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp6_5 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_12 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp1_7 = (PrtSet)(((PrtNamedTuple)req_10)["entries"]);
            await PutHeads(TMP_tmp0_12, TMP_tmp1_7);
            TMP_tmp2_6 = (PMachineValue)(((PrtNamedTuple)req_10)["source"]);
            TMP_tmp3_6 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_6)?.Clone()));
            TMP_tmp4_5 = (PEvent)(new ePutEntriesInHeadsResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp5_5 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_5 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp5_5)));
            currentMachine.TrySendEvent(TMP_tmp3_6, (Event)TMP_tmp4_5, TMP_tmp6_5);
        }
        public async Task Anon_13(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_11 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_13 = null;
            PrtSet TMP_tmp1_8 = new PrtSet();
            PMachineValue TMP_tmp2_7 = null;
            PMachineValue TMP_tmp3_7 = null;
            PEvent TMP_tmp4_6 = null;
            PrtInt TMP_tmp5_6 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp6_6 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_13 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp1_8 = (PrtSet)(((PrtNamedTuple)req_11)["entries"]);
            await SetHeads(TMP_tmp0_13, TMP_tmp1_8);
            TMP_tmp2_7 = (PMachineValue)(((PrtNamedTuple)req_11)["source"]);
            TMP_tmp3_7 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_7)?.Clone()));
            TMP_tmp4_6 = (PEvent)(new eSetEntriesInHeadsResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp5_6 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_6 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp5_6)));
            currentMachine.TrySendEvent(TMP_tmp3_7, (Event)TMP_tmp4_6, TMP_tmp6_6);
        }
        public async Task Anon_14(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_12 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSet newHeads = new PrtSet();
            PMachineValue TMP_tmp0_14 = null;
            tEntry TMP_tmp1_9 = null;
            PrtSet TMP_tmp2_8 = new PrtSet();
            PMachineValue TMP_tmp3_8 = null;
            PMachineValue TMP_tmp4_7 = null;
            PEvent TMP_tmp5_7 = null;
            PrtInt TMP_tmp6_7 = ((PrtInt)0);
            PrtSet TMP_tmp7_4 = new PrtSet();
            PrtNamedTuple TMP_tmp8_3 = (new PrtNamedTuple(new string[]{"status","newHeads"},((PrtInt)0), new PrtSet()));
            TMP_tmp0_14 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp1_9 = (tEntry)(((PrtNamedTuple)req_12)["headEntry"]);
            TMP_tmp2_8 = (PrtSet)(await AddHead(TMP_tmp0_14, TMP_tmp1_9));
            newHeads = TMP_tmp2_8;
            TMP_tmp3_8 = (PMachineValue)(((PrtNamedTuple)req_12)["source"]);
            TMP_tmp4_7 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp3_8)?.Clone()));
            TMP_tmp5_7 = (PEvent)(new eAddEntryToHeadsResp((new PrtNamedTuple(new string[]{"status","newHeads"},((PrtInt)0), new PrtSet()))));
            TMP_tmp6_7 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp7_4 = (PrtSet)(((PrtSet)((IPrtValue)newHeads)?.Clone()));
            TMP_tmp8_3 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","newHeads"}, TMP_tmp6_7, TMP_tmp7_4)));
            currentMachine.TrySendEvent(TMP_tmp4_7, (Event)TMP_tmp5_7, TMP_tmp8_3);
        }
        public async Task Anon_15(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_13 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_15 = null;
            PMachineValue TMP_tmp1_10 = null;
            PMachineValue TMP_tmp2_9 = null;
            PEvent TMP_tmp3_9 = null;
            PrtInt TMP_tmp4_8 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp5_8 = (new PrtNamedTuple(new string[]{"status"},((PrtInt)0)));
            TMP_tmp0_15 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            await ClearHeads(TMP_tmp0_15);
            TMP_tmp1_10 = (PMachineValue)(((PrtNamedTuple)req_13)["source"]);
            TMP_tmp2_9 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_10)?.Clone()));
            TMP_tmp3_9 = (PEvent)(new eClearAllEntriesFromHeadsResp((new PrtNamedTuple(new string[]{"status"},((PrtInt)0)))));
            TMP_tmp4_8 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_8 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status"}, TMP_tmp4_8)));
            currentMachine.TrySendEvent(TMP_tmp2_9, (Event)TMP_tmp3_9, TMP_tmp5_8);
        }
        public async Task Anon_16(Event currentMachine_dequeuedEvent)
        {
            Heads currentMachine = this;
            PrtNamedTuple req_14 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtSet allHeads = new PrtSet();
            PMachineValue TMP_tmp0_16 = null;
            PrtSet TMP_tmp1_11 = new PrtSet();
            PMachineValue TMP_tmp2_10 = null;
            PMachineValue TMP_tmp3_10 = null;
            PEvent TMP_tmp4_9 = null;
            PrtInt TMP_tmp5_9 = ((PrtInt)0);
            PrtSet TMP_tmp6_8 = new PrtSet();
            PrtNamedTuple TMP_tmp7_5 = (new PrtNamedTuple(new string[]{"status","retrivedValues"},((PrtInt)0), new PrtSet()));
            TMP_tmp0_16 = (PMachineValue)(((PMachineValue)((IPrtValue)storage)?.Clone()));
            TMP_tmp1_11 = (PrtSet)(await GetAllHeads(TMP_tmp0_16));
            allHeads = TMP_tmp1_11;
            TMP_tmp2_10 = (PMachineValue)(((PrtNamedTuple)req_14)["source"]);
            TMP_tmp3_10 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp2_10)?.Clone()));
            TMP_tmp4_9 = (PEvent)(new eGetAllEntriesFromHeadsResp((new PrtNamedTuple(new string[]{"status","retrivedValues"},((PrtInt)0), new PrtSet()))));
            TMP_tmp5_9 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp6_8 = (PrtSet)(((PrtSet)((IPrtValue)allHeads)?.Clone()));
            TMP_tmp7_5 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","retrivedValues"}, TMP_tmp5_9, TMP_tmp6_8)));
            currentMachine.TrySendEvent(TMP_tmp3_10, (Event)TMP_tmp4_9, TMP_tmp7_5);
        }
        public async Task PutHeads(PMachineValue storage_1, PrtSet entries)
        {
            Heads currentMachine = this;
            PrtSet heads_1 = new PrtSet();
            tEntry head = null;
            PrtInt numToPut = ((PrtInt)0);
            PrtSet TMP_tmp0_17 = new PrtSet();
            PrtSet TMP_tmp1_12 = new PrtSet();
            PrtSet TMP_tmp2_11 = new PrtSet();
            PrtInt TMP_i_head_tmp3 = ((PrtInt)0);
            PrtInt sizeof_head_tmp4 = ((PrtInt)0);
            PrtInt TMP_tmp5_10 = ((PrtInt)0);
            PrtInt TMP_tmp6_9 = ((PrtInt)0);
            PrtBool TMP_tmp7_6 = ((PrtBool)false);
            PrtBool TMP_tmp8_4 = ((PrtBool)false);
            PrtInt TMP_tmp9 = ((PrtInt)0);
            tEntry TMP_tmp10 = null;
            tEntry TMP_tmp11 = null;
            PMachineValue TMP_tmp12 = null;
            PEvent TMP_tmp13 = null;
            PMachineValue TMP_tmp14 = null;
            tEntry TMP_tmp15 = null;
            PrtString TMP_tmp16 = ((PrtString)"");
            tEntry TMP_tmp17 = null;
            PrtNamedTuple TMP_tmp18 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            PrtInt TMP_tmp19 = ((PrtInt)0);
            PrtBool TMP_tmp20 = ((PrtBool)false);
            PrtString TMP_tmp21 = ((PrtString)"");
            PrtString TMP_tmp22 = ((PrtString)"");
            PrtString TMP_tmp23 = ((PrtString)"");
            TMP_tmp0_17 = (PrtSet)(((PrtSet)((IPrtValue)entries)?.Clone()));
            TMP_tmp1_12 = (PrtSet)(GlobalFunctions.FindHeads(TMP_tmp0_17, currentMachine));
            heads_1 = TMP_tmp1_12;
            TMP_tmp2_11 = (PrtSet)(((PrtSet)((IPrtValue)heads_1)?.Clone()));
            TMP_i_head_tmp3 = (PrtInt)(((PrtInt)(-1)));
            TMP_tmp5_10 = (PrtInt)(((PrtInt)(TMP_tmp2_11).Count));
            sizeof_head_tmp4 = TMP_tmp5_10;
            while (((PrtBool)true))
            {
                TMP_tmp6_9 = (PrtInt)((sizeof_head_tmp4) - (((PrtInt)(1))));
                TMP_tmp7_6 = (PrtBool)((TMP_i_head_tmp3) < (TMP_tmp6_9));
                TMP_tmp8_4 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp7_6)?.Clone()));
                if (TMP_tmp8_4)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp9 = (PrtInt)((TMP_i_head_tmp3) + (((PrtInt)(1))));
                TMP_i_head_tmp3 = TMP_tmp9;
                TMP_tmp10 = (tEntry)(((PrtSet)TMP_tmp2_11)[TMP_i_head_tmp3]);
                TMP_tmp11 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp10)?.Clone()));
                head = TMP_tmp11;
                TMP_tmp12 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_1)?.Clone()));
                TMP_tmp13 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
                TMP_tmp14 = (PMachineValue)(currentMachine.self);
                TMP_tmp15 = (tEntry)(((tEntry)((IPrtValue)head)?.Clone()));
                TMP_tmp16 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp15, currentMachine));
                TMP_tmp17 = (tEntry)(((tEntry)((IPrtValue)head)?.Clone()));
                TMP_tmp18 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp14, TMP_tmp16, TMP_tmp17)));
                currentMachine.TrySendEvent(TMP_tmp12, (Event)TMP_tmp13, TMP_tmp18);
                var PGEN_recvEvent = await currentMachine.TryReceiveEvent(typeof(ePutEntriesInHeadsResp), typeof(PHalt));
                switch (PGEN_recvEvent) {
                    case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                    case ePutEntriesInHeadsResp PGEN_evt: {
                        PrtNamedTuple resp = (PrtNamedTuple)(PGEN_evt.Payload);
                        TMP_tmp19 = (PrtInt)(((PrtNamedTuple)resp)["status"]);
                        TMP_tmp20 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp19),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                        TMP_tmp21 = (PrtString)(((PrtString) String.Format("PSrc/oplog/heads.p:85:21")));
                        TMP_tmp22 = (PrtString)(((PrtString) String.Format("Failed to put head in storage.")));
                        TMP_tmp23 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp21,TMP_tmp22)));
                        currentMachine.TryAssert(TMP_tmp20,"Assertion Failed: " + TMP_tmp23);
                    } break;
                }
            }
        }
        public async Task SetHeads(PMachineValue storage_2, PrtSet entries_1)
        {
            Heads currentMachine = this;
            PMachineValue TMP_tmp0_18 = null;
            PEvent TMP_tmp1_13 = null;
            PMachineValue TMP_tmp2_12 = null;
            PrtNamedTuple TMP_tmp3_11 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtInt TMP_tmp4_10 = ((PrtInt)0);
            PrtBool TMP_tmp5_11 = ((PrtBool)false);
            PrtString TMP_tmp6_10 = ((PrtString)"");
            PrtString TMP_tmp7_7 = ((PrtString)"");
            PrtString TMP_tmp8_5 = ((PrtString)"");
            PMachineValue TMP_tmp9_1 = null;
            PrtSet TMP_tmp10_1 = new PrtSet();
            TMP_tmp0_18 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_2)?.Clone()));
            TMP_tmp1_13 = (PEvent)(new eClearAllValuesFromStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_12 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_11 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_12)));
            currentMachine.TrySendEvent(TMP_tmp0_18, (Event)TMP_tmp1_13, TMP_tmp3_11);
            var PGEN_recvEvent_1 = await currentMachine.TryReceiveEvent(typeof(eClearAllValuesFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_1) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eClearAllValuesFromStorageResp PGEN_evt_1: {
                    PrtNamedTuple resp_1 = (PrtNamedTuple)(PGEN_evt_1.Payload);
                    TMP_tmp4_10 = (PrtInt)(((PrtNamedTuple)resp_1)["status"]);
                    TMP_tmp5_11 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp4_10),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp6_10 = (PrtString)(((PrtString) String.Format("PSrc/oplog/heads.p:95:17")));
                    TMP_tmp7_7 = (PrtString)(((PrtString) String.Format("Failed to clear heads storage.")));
                    TMP_tmp8_5 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp6_10,TMP_tmp7_7)));
                    currentMachine.TryAssert(TMP_tmp5_11,"Assertion Failed: " + TMP_tmp8_5);
                } break;
            }
            TMP_tmp9_1 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_2)?.Clone()));
            TMP_tmp10_1 = (PrtSet)(((PrtSet)((IPrtValue)entries_1)?.Clone()));
            await PutHeads(TMP_tmp9_1, TMP_tmp10_1);
        }
        public async Task<PrtSet> GetAllHeads(PMachineValue storage_3)
        {
            Heads currentMachine = this;
            PrtSet returnValues = new PrtSet();
            PMachineValue TMP_tmp0_19 = null;
            PEvent TMP_tmp1_14 = null;
            PMachineValue TMP_tmp2_13 = null;
            PrtNamedTuple TMP_tmp3_12 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtInt TMP_tmp4_11 = ((PrtInt)0);
            PrtBool TMP_tmp5_12 = ((PrtBool)false);
            PrtString TMP_tmp6_11 = ((PrtString)"");
            PrtString TMP_tmp7_8 = ((PrtString)"");
            PrtString TMP_tmp8_6 = ((PrtString)"");
            PrtSet TMP_tmp9_2 = new PrtSet();
            PrtSet TMP_tmp10_2 = new PrtSet();
            TMP_tmp0_19 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_3)?.Clone()));
            TMP_tmp1_14 = (PEvent)(new eGetAllValuesFromStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_13 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_12 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_13)));
            currentMachine.TrySendEvent(TMP_tmp0_19, (Event)TMP_tmp1_14, TMP_tmp3_12);
            var PGEN_recvEvent_2 = await currentMachine.TryReceiveEvent(typeof(eGetAllValuesFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_2) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetAllValuesFromStorageResp PGEN_evt_2: {
                    PrtNamedTuple resp_2 = (PrtNamedTuple)(PGEN_evt_2.Payload);
                    TMP_tmp4_11 = (PrtInt)(((PrtNamedTuple)resp_2)["status"]);
                    TMP_tmp5_12 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp4_11),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp6_11 = (PrtString)(((PrtString) String.Format("PSrc/oplog/heads.p:106:17")));
                    TMP_tmp7_8 = (PrtString)(((PrtString) String.Format("Failed to retrieve all heads from storage.")));
                    TMP_tmp8_6 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp6_11,TMP_tmp7_8)));
                    currentMachine.TryAssert(TMP_tmp5_12,"Assertion Failed: " + TMP_tmp8_6);
                    TMP_tmp9_2 = (PrtSet)(((PrtNamedTuple)resp_2)["retrivedValues"]);
                    TMP_tmp10_2 = (PrtSet)(((PrtSet)((PrtSet)((IPrtValue)TMP_tmp9_2)?.Clone())));
                    returnValues = TMP_tmp10_2;
                } break;
            }
            return ((PrtSet)((IPrtValue)returnValues)?.Clone());
        }
        public async Task<PrtSet> AddHead(PMachineValue storage_4, tEntry head_1)
        {
            Heads currentMachine = this;
            PrtSet retrievedHeads = new PrtSet();
            PrtSet newHeads_1 = new PrtSet();
            PrtSet combinedHeadsToFind = new PrtSet();
            PMachineValue TMP_tmp0_20 = null;
            PrtSet TMP_tmp1_15 = new PrtSet();
            PrtBool TMP_tmp2_14 = ((PrtBool)false);
            tEntry TMP_tmp3_13 = null;
            PrtSet TMP_tmp4_12 = new PrtSet();
            PrtSet TMP_tmp5_13 = new PrtSet();
            PMachineValue TMP_tmp6_12 = null;
            PrtSet TMP_tmp7_9 = new PrtSet();
            TMP_tmp0_20 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_4)?.Clone()));
            TMP_tmp1_15 = (PrtSet)(await GetAllHeads(TMP_tmp0_20));
            retrievedHeads = TMP_tmp1_15;
            combinedHeadsToFind = (PrtSet)(((PrtSet)((IPrtValue)retrievedHeads)?.Clone()));
            TMP_tmp2_14 = (PrtBool)(((PrtBool)(((PrtSet)retrievedHeads).Contains(head_1))));
            if (TMP_tmp2_14)
            {
                return ((PrtSet)((IPrtValue)retrievedHeads)?.Clone());
            }
            combinedHeadsToFind = (PrtSet)(((PrtSet)((IPrtValue)retrievedHeads)?.Clone()));
            TMP_tmp3_13 = (tEntry)(((tEntry)((IPrtValue)head_1)?.Clone()));
            ((PrtSet)combinedHeadsToFind).Add(TMP_tmp3_13);
            TMP_tmp4_12 = (PrtSet)(((PrtSet)((IPrtValue)combinedHeadsToFind)?.Clone()));
            TMP_tmp5_13 = (PrtSet)(GlobalFunctions.FindHeads(TMP_tmp4_12, currentMachine));
            newHeads_1 = TMP_tmp5_13;
            TMP_tmp6_12 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_4)?.Clone()));
            TMP_tmp7_9 = (PrtSet)(((PrtSet)((IPrtValue)newHeads_1)?.Clone()));
            await SetHeads(TMP_tmp6_12, TMP_tmp7_9);
            return ((PrtSet)((IPrtValue)newHeads_1)?.Clone());
        }
        public async Task ClearHeads(PMachineValue storage_5)
        {
            Heads currentMachine = this;
            PMachineValue TMP_tmp0_21 = null;
            PEvent TMP_tmp1_16 = null;
            PMachineValue TMP_tmp2_15 = null;
            PrtNamedTuple TMP_tmp3_14 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtInt TMP_tmp4_13 = ((PrtInt)0);
            PrtBool TMP_tmp5_14 = ((PrtBool)false);
            PrtString TMP_tmp6_13 = ((PrtString)"");
            PrtString TMP_tmp7_10 = ((PrtString)"");
            PrtString TMP_tmp8_7 = ((PrtString)"");
            TMP_tmp0_21 = (PMachineValue)(((PMachineValue)((IPrtValue)storage_5)?.Clone()));
            TMP_tmp1_16 = (PEvent)(new eClearAllValuesFromStorageReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_15 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_14 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_15)));
            currentMachine.TrySendEvent(TMP_tmp0_21, (Event)TMP_tmp1_16, TMP_tmp3_14);
            var PGEN_recvEvent_3 = await currentMachine.TryReceiveEvent(typeof(eClearAllValuesFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_3) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eClearAllValuesFromStorageResp PGEN_evt_3: {
                    PrtNamedTuple resp_3 = (PrtNamedTuple)(PGEN_evt_3.Payload);
                    TMP_tmp4_13 = (PrtInt)(((PrtNamedTuple)resp_3)["status"]);
                    TMP_tmp5_14 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp4_13),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp6_13 = (PrtString)(((PrtString) String.Format("PSrc/oplog/heads.p:133:17")));
                    TMP_tmp7_10 = (PrtString)(((PrtString) String.Format("Failed to clear heads storage.")));
                    TMP_tmp8_7 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp6_13,TMP_tmp7_10)));
                    currentMachine.TryAssert(TMP_tmp5_14,"Assertion Failed: " + TMP_tmp8_7);
                } break;
            }
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_11))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(ePutEntriesInHeadsReq), nameof(Anon_12))]
        [OnEventDoAction(typeof(eSetEntriesInHeadsReq), nameof(Anon_13))]
        [OnEventDoAction(typeof(eAddEntryToHeadsReq), nameof(Anon_14))]
        [OnEventDoAction(typeof(eClearAllEntriesFromHeadsReq), nameof(Anon_15))]
        [OnEventDoAction(typeof(eGetAllEntriesFromHeadsReq), nameof(Anon_16))]
        class Active : State
        {
        }
    }
}
namespace PImplementation
{
    internal partial class Log : PMachine
    {
        private PrtString identity = ((PrtString)"");
        private PrtString logId = ((PrtString)"");
        private PMachineValue clock = null;
        private PMachineValue entries_2 = null;
        private PMachineValue index = null;
        private PMachineValue heads_2 = null;
        public class ConstructorEvent : PEvent{public ConstructorEvent(PrtNamedTuple val) : base(val) { }}
        
        protected override Event GetConstructorEvent(IPrtValue value) { return new ConstructorEvent((PrtNamedTuple)value); }
        public Log() {
            this.sends.Add(nameof(eAddEntryToHeadsReq));
            this.sends.Add(nameof(eAddEntryToHeadsResp));
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
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
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
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
            this.creates.Add(nameof(I_HybridLogicalClock));
            this.creates.Add(nameof(I_MemoryStorage));
        }
        
        public void Anon_17(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple init = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtString TMP_tmp0_22 = ((PrtString)"");
            PrtString TMP_tmp1_17 = ((PrtString)"");
            PrtString TMP_tmp2_16 = ((PrtString)"");
            PrtString TMP_tmp3_15 = ((PrtString)"");
            PrtString TMP_tmp4_14 = ((PrtString)"");
            PMachineValue TMP_tmp5_15 = null;
            PrtString TMP_tmp6_14 = ((PrtString)"");
            PMachineValue TMP_tmp7_11 = null;
            PrtString TMP_tmp8_8 = ((PrtString)"");
            PMachineValue TMP_tmp9_3 = null;
            PrtSet TMP_tmp10_3 = new PrtSet();
            PMachineValue TMP_tmp11_1 = null;
            TMP_tmp0_22 = (PrtString)(((PrtNamedTuple)init)["identityIn"]);
            TMP_tmp1_17 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp0_22)?.Clone()));
            identity = TMP_tmp1_17;
            TMP_tmp2_16 = (PrtString)(((PrtNamedTuple)init)["logIdIn"]);
            TMP_tmp3_15 = (PrtString)(((PrtString)((IPrtValue)TMP_tmp2_16)?.Clone()));
            logId = TMP_tmp3_15;
            TMP_tmp4_14 = (PrtString)(((PrtString)((IPrtValue)identity)?.Clone()));
            TMP_tmp5_15 = (PMachineValue)(currentMachine.CreateInterface<I_HybridLogicalClock>( currentMachine, TMP_tmp4_14));
            clock = TMP_tmp5_15;
            TMP_tmp6_14 = (PrtString)(((PrtString) String.Format("Entry Storage")));
            TMP_tmp7_11 = (PMachineValue)(currentMachine.CreateInterface<I_MemoryStorage>( currentMachine, TMP_tmp6_14));
            entries_2 = TMP_tmp7_11;
            TMP_tmp8_8 = (PrtString)(((PrtString) String.Format("Index Storage")));
            TMP_tmp9_3 = (PMachineValue)(currentMachine.CreateInterface<I_MemoryStorage>( currentMachine, TMP_tmp8_8));
            index = TMP_tmp9_3;
            TMP_tmp10_3 = (PrtSet)(((PrtNamedTuple)init)["logHeads"]);
            TMP_tmp11_1 = (PMachineValue)(currentMachine.CreateInterface<I_Heads>( currentMachine, TMP_tmp10_3));
            heads_2 = TMP_tmp11_1;
            currentMachine.TryGotoState<WaitForRequest>();
            return;
        }
        public async Task Anon_18(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_15 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp lastTimestamp = null;
            tTimestamp TMP_tmp0_23 = null;
            PMachineValue TMP_tmp1_18 = null;
            PMachineValue TMP_tmp2_17 = null;
            PEvent TMP_tmp3_16 = null;
            PrtInt TMP_tmp4_15 = ((PrtInt)0);
            tTimestamp TMP_tmp5_16 = null;
            PrtNamedTuple TMP_tmp6_15 = (new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null));
            TMP_tmp0_23 = (tTimestamp)(await GetClockLastState());
            lastTimestamp = TMP_tmp0_23;
            TMP_tmp1_18 = (PMachineValue)(((PrtNamedTuple)req_15)["source"]);
            TMP_tmp2_17 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp1_18)?.Clone()));
            TMP_tmp3_16 = (PEvent)(new eGetClockLastStateResp((new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null))));
            TMP_tmp4_15 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp5_16 = (tTimestamp)(((tTimestamp)((IPrtValue)lastTimestamp)?.Clone()));
            TMP_tmp6_15 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","lastTimestamp"}, TMP_tmp4_15, TMP_tmp5_16)));
            currentMachine.TrySendEvent(TMP_tmp2_17, (Event)TMP_tmp3_16, TMP_tmp6_15);
        }
        public async Task Anon_19(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_16 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            await GetHeadsFromLog();
        }
        public void Anon_20(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_17 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public void Anon_21(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_18 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public void Anon_22(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_19 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public void Anon_23(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_20 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public void Anon_24(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_21 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public void Anon_25(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_22 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public void Anon_26(Event currentMachine_dequeuedEvent)
        {
            Log currentMachine = this;
            PrtNamedTuple req_23 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
        }
        public async Task<tTimestamp> GetClockLastState()
        {
            Log currentMachine = this;
            tTimestamp lastTimestamp_1 = null;
            PMachineValue TMP_tmp0_24 = null;
            PEvent TMP_tmp1_19 = null;
            PMachineValue TMP_tmp2_18 = null;
            PrtNamedTuple TMP_tmp3_17 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtInt TMP_tmp4_16 = ((PrtInt)0);
            PrtBool TMP_tmp5_17 = ((PrtBool)false);
            PrtString TMP_tmp6_16 = ((PrtString)"");
            PrtString TMP_tmp7_12 = ((PrtString)"");
            PrtString TMP_tmp8_9 = ((PrtString)"");
            tTimestamp TMP_tmp9_4 = null;
            tTimestamp TMP_tmp10_4 = null;
            TMP_tmp0_24 = (PMachineValue)(((PMachineValue)((IPrtValue)clock)?.Clone()));
            TMP_tmp1_19 = (PEvent)(new eGetLastTimestampReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_18 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_17 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_18)));
            currentMachine.TrySendEvent(TMP_tmp0_24, (Event)TMP_tmp1_19, TMP_tmp3_17);
            var PGEN_recvEvent_4 = await currentMachine.TryReceiveEvent(typeof(eGetLastTimestampResp), typeof(PHalt));
            switch (PGEN_recvEvent_4) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetLastTimestampResp PGEN_evt_4: {
                    PrtNamedTuple resp_4 = (PrtNamedTuple)(PGEN_evt_4.Payload);
                    TMP_tmp4_16 = (PrtInt)(((PrtNamedTuple)resp_4)["status"]);
                    TMP_tmp5_17 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp4_16),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp6_16 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:142:17")));
                    TMP_tmp7_12 = (PrtString)(((PrtString) String.Format("Failed to get last timestamp from clock.")));
                    TMP_tmp8_9 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp6_16,TMP_tmp7_12)));
                    currentMachine.TryAssert(TMP_tmp5_17,"Assertion Failed: " + TMP_tmp8_9);
                    TMP_tmp9_4 = (tTimestamp)(((PrtNamedTuple)resp_4)["lastTimestamp"]);
                    TMP_tmp10_4 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp9_4)?.Clone()));
                    lastTimestamp_1 = TMP_tmp10_4;
                } break;
            }
            return ((tTimestamp)((IPrtValue)lastTimestamp_1)?.Clone());
        }
        public async Task<PrtSet> GetHeadsFromLog()
        {
            Log currentMachine = this;
            PrtSet headsToReturn = new PrtSet();
            PMachineValue TMP_tmp0_25 = null;
            PEvent TMP_tmp1_20 = null;
            PMachineValue TMP_tmp2_19 = null;
            PrtNamedTuple TMP_tmp3_18 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtInt TMP_tmp4_17 = ((PrtInt)0);
            PrtBool TMP_tmp5_18 = ((PrtBool)false);
            PrtString TMP_tmp6_17 = ((PrtString)"");
            PrtString TMP_tmp7_13 = ((PrtString)"");
            PrtString TMP_tmp8_10 = ((PrtString)"");
            PrtSet TMP_tmp9_5 = new PrtSet();
            PrtSet TMP_tmp10_5 = new PrtSet();
            TMP_tmp0_25 = (PMachineValue)(((PMachineValue)((IPrtValue)heads_2)?.Clone()));
            TMP_tmp1_20 = (PEvent)(new eGetAllEntriesFromHeadsReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp2_19 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_18 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp2_19)));
            currentMachine.TrySendEvent(TMP_tmp0_25, (Event)TMP_tmp1_20, TMP_tmp3_18);
            var PGEN_recvEvent_5 = await currentMachine.TryReceiveEvent(typeof(eGetAllEntriesFromHeadsResp), typeof(PHalt));
            switch (PGEN_recvEvent_5) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetAllEntriesFromHeadsResp PGEN_evt_5: {
                    PrtNamedTuple resp_5 = (PrtNamedTuple)(PGEN_evt_5.Payload);
                    TMP_tmp4_17 = (PrtInt)(((PrtNamedTuple)resp_5)["status"]);
                    TMP_tmp5_18 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp4_17),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp6_17 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:154:17")));
                    TMP_tmp7_13 = (PrtString)(((PrtString) String.Format("Failed to get heads from log.")));
                    TMP_tmp8_10 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp6_17,TMP_tmp7_13)));
                    currentMachine.TryAssert(TMP_tmp5_18,"Assertion Failed: " + TMP_tmp8_10);
                    TMP_tmp9_5 = (PrtSet)(((PrtNamedTuple)resp_5)["retrivedValues"]);
                    TMP_tmp10_5 = (PrtSet)(((PrtSet)((IPrtValue)TMP_tmp9_5)?.Clone()));
                    headsToReturn = TMP_tmp10_5;
                } break;
            }
            return ((PrtSet)((IPrtValue)headsToReturn)?.Clone());
        }
        public void GetAllEntriesFromLog()
        {
            Log currentMachine = this;
        }
        public async Task<tEntry> GetEntryFromLog(PrtString hash)
        {
            Log currentMachine = this;
            tEntry entryToReturn = null;
            PMachineValue TMP_tmp0_26 = null;
            PEvent TMP_tmp1_21 = null;
            PMachineValue TMP_tmp2_20 = null;
            PrtString TMP_tmp3_19 = ((PrtString)"");
            PrtNamedTuple TMP_tmp4_18 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            PrtInt TMP_tmp5_19 = ((PrtInt)0);
            PrtBool TMP_tmp6_18 = ((PrtBool)false);
            PrtString TMP_tmp7_14 = ((PrtString)"");
            PrtString TMP_tmp8_11 = ((PrtString)"");
            PrtString TMP_tmp9_6 = ((PrtString)"");
            PrtString TMP_tmp10_6 = ((PrtString)"");
            IPrtValue TMP_tmp11_2 = null;
            tEntry TMP_tmp12_1 = null;
            TMP_tmp0_26 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp1_21 = (PEvent)(new eGetValueFromStorageReq((new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")))));
            TMP_tmp2_20 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_19 = (PrtString)(((PrtString)((IPrtValue)hash)?.Clone()));
            TMP_tmp4_18 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key"}, TMP_tmp2_20, TMP_tmp3_19)));
            currentMachine.TrySendEvent(TMP_tmp0_26, (Event)TMP_tmp1_21, TMP_tmp4_18);
            var PGEN_recvEvent_6 = await currentMachine.TryReceiveEvent(typeof(eGetValueFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_6) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetValueFromStorageResp PGEN_evt_6: {
                    PrtNamedTuple resp_6 = (PrtNamedTuple)(PGEN_evt_6.Payload);
                    TMP_tmp5_19 = (PrtInt)(((PrtNamedTuple)resp_6)["status"]);
                    TMP_tmp6_18 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp5_19),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp7_14 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:168:17")));
                    TMP_tmp8_11 = (PrtString)(((PrtString)((IPrtValue)hash)?.Clone()));
                    TMP_tmp9_6 = (PrtString)(((PrtString) String.Format("Failed to retrive entry with hash {0}",TMP_tmp8_11)));
                    TMP_tmp10_6 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp7_14,TMP_tmp9_6)));
                    currentMachine.TryAssert(TMP_tmp6_18,"Assertion Failed: " + TMP_tmp10_6);
                    TMP_tmp11_2 = (IPrtValue)(((PrtNamedTuple)resp_6)["value"]);
                    TMP_tmp12_1 = (tEntry)(((tEntry)((IPrtValue)((IPrtValue)TMP_tmp11_2)?.Clone())));
                    entryToReturn = TMP_tmp12_1;
                } break;
            }
            return ((tEntry)((IPrtValue)entryToReturn)?.Clone());
        }
        public async Task<PrtBool> LogHasEntry(PrtString hash_1)
        {
            Log currentMachine = this;
            PrtBool logHasEntry = ((PrtBool)false);
            PMachineValue TMP_tmp0_27 = null;
            PEvent TMP_tmp1_22 = null;
            PMachineValue TMP_tmp2_21 = null;
            PrtString TMP_tmp3_20 = ((PrtString)"");
            PrtNamedTuple TMP_tmp4_19 = (new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")));
            PrtInt TMP_tmp5_20 = ((PrtInt)0);
            PrtBool TMP_tmp6_19 = ((PrtBool)false);
            PrtString TMP_tmp7_15 = ((PrtString)"");
            PrtString TMP_tmp8_12 = ((PrtString)"");
            PrtString TMP_tmp9_7 = ((PrtString)"");
            PrtString TMP_tmp10_7 = ((PrtString)"");
            IPrtValue TMP_tmp11_3 = null;
            PrtBool TMP_tmp12_2 = ((PrtBool)false);
            TMP_tmp0_27 = (PMachineValue)(((PMachineValue)((IPrtValue)index)?.Clone()));
            TMP_tmp1_22 = (PEvent)(new eGetValueFromStorageReq((new PrtNamedTuple(new string[]{"source","key"},null, ((PrtString)"")))));
            TMP_tmp2_21 = (PMachineValue)(currentMachine.self);
            TMP_tmp3_20 = (PrtString)(((PrtString)((IPrtValue)hash_1)?.Clone()));
            TMP_tmp4_19 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key"}, TMP_tmp2_21, TMP_tmp3_20)));
            currentMachine.TrySendEvent(TMP_tmp0_27, (Event)TMP_tmp1_22, TMP_tmp4_19);
            var PGEN_recvEvent_7 = await currentMachine.TryReceiveEvent(typeof(eGetValueFromStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_7) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetValueFromStorageResp PGEN_evt_7: {
                    PrtNamedTuple resp_7 = (PrtNamedTuple)(PGEN_evt_7.Payload);
                    TMP_tmp5_20 = (PrtInt)(((PrtNamedTuple)resp_7)["status"]);
                    TMP_tmp6_19 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp5_20),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp7_15 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:181:17")));
                    TMP_tmp8_12 = (PrtString)(((PrtString)((IPrtValue)hash_1)?.Clone()));
                    TMP_tmp9_7 = (PrtString)(((PrtString) String.Format("Failed to retrive entry with hash {0}",TMP_tmp8_12)));
                    TMP_tmp10_7 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp7_15,TMP_tmp9_7)));
                    currentMachine.TryAssert(TMP_tmp6_19,"Assertion Failed: " + TMP_tmp10_7);
                    TMP_tmp11_3 = (IPrtValue)(((PrtNamedTuple)resp_7)["value"]);
                    TMP_tmp12_2 = (PrtBool)(((PrtBool)((IPrtValue)((IPrtValue)TMP_tmp11_3)?.Clone())));
                    logHasEntry = TMP_tmp12_2;
                } break;
            }
            return ((PrtBool)((IPrtValue)logHasEntry)?.Clone());
        }
        public async Task<tEntry> AppendEntry(PrtString entryData, PrtInt numReferences)
        {
            Log currentMachine = this;
            PrtSet logHeads = new PrtSet();
            tEntry itrEntry = null;
            PrtSet nexts = new PrtSet();
            PrtSet refs = new PrtSet();
            tEntry createdEntry = null;
            PrtInt totalNumReferences = ((PrtInt)0);
            tTimestamp now = null;
            PrtSet entrySet = new PrtSet();
            PrtSet TMP_tmp0_28 = new PrtSet();
            PrtSet TMP_tmp1_23 = new PrtSet();
            PrtInt TMP_i_itrEntry_tmp2 = ((PrtInt)0);
            PrtInt sizeof_itrEntry_tmp3 = ((PrtInt)0);
            PrtInt TMP_tmp4_20 = ((PrtInt)0);
            PrtInt TMP_tmp5_21 = ((PrtInt)0);
            PrtBool TMP_tmp6_20 = ((PrtBool)false);
            PrtBool TMP_tmp7_16 = ((PrtBool)false);
            PrtInt TMP_tmp8_13 = ((PrtInt)0);
            tEntry TMP_tmp9_8 = null;
            tEntry TMP_tmp10_8 = null;
            tEntry TMP_tmp11_4 = null;
            PrtString TMP_tmp12_3 = ((PrtString)"");
            PrtInt TMP_tmp13_1 = ((PrtInt)0);
            PrtInt TMP_tmp14_1 = ((PrtInt)0);
            PrtSet TMP_tmp15_1 = new PrtSet();
            PrtInt TMP_tmp16_1 = ((PrtInt)0);
            PrtSet TMP_tmp17_1 = new PrtSet();
            PMachineValue TMP_tmp18_1 = null;
            PEvent TMP_tmp19_1 = null;
            PMachineValue TMP_tmp20_1 = null;
            PrtNamedTuple TMP_tmp21_1 = (new PrtNamedTuple(new string[]{"source"},null));
            PrtInt TMP_tmp22_1 = ((PrtInt)0);
            PrtBool TMP_tmp23_1 = ((PrtBool)false);
            PrtString TMP_tmp24 = ((PrtString)"");
            PrtString TMP_tmp25 = ((PrtString)"");
            PrtString TMP_tmp26 = ((PrtString)"");
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
            PMachineValue TMP_tmp37 = null;
            PEvent TMP_tmp38 = null;
            PMachineValue TMP_tmp39 = null;
            PrtSet TMP_tmp40 = new PrtSet();
            PrtNamedTuple TMP_tmp41 = (new PrtNamedTuple(new string[]{"source","entries"},null, new PrtSet()));
            PrtInt TMP_tmp42 = ((PrtInt)0);
            PrtBool TMP_tmp43 = ((PrtBool)false);
            PrtString TMP_tmp44 = ((PrtString)"");
            PrtString TMP_tmp45 = ((PrtString)"");
            PrtString TMP_tmp46 = ((PrtString)"");
            PMachineValue TMP_tmp47 = null;
            PEvent TMP_tmp48 = null;
            PMachineValue TMP_tmp49 = null;
            tEntry TMP_tmp50 = null;
            PrtString TMP_tmp51 = ((PrtString)"");
            tEntry TMP_tmp52 = null;
            PrtNamedTuple TMP_tmp53 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            PrtInt TMP_tmp54 = ((PrtInt)0);
            PrtBool TMP_tmp55 = ((PrtBool)false);
            PrtString TMP_tmp56 = ((PrtString)"");
            PrtString TMP_tmp57 = ((PrtString)"");
            PrtString TMP_tmp58 = ((PrtString)"");
            PMachineValue TMP_tmp59 = null;
            PEvent TMP_tmp60 = null;
            PMachineValue TMP_tmp61 = null;
            tEntry TMP_tmp62 = null;
            PrtString TMP_tmp63 = ((PrtString)"");
            PrtBool TMP_tmp64 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp65 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), ((PrtBool)false)));
            PrtInt TMP_tmp66 = ((PrtInt)0);
            PrtBool TMP_tmp67 = ((PrtBool)false);
            PrtString TMP_tmp68 = ((PrtString)"");
            PrtString TMP_tmp69 = ((PrtString)"");
            PrtString TMP_tmp70 = ((PrtString)"");
            TMP_tmp0_28 = (PrtSet)(await GetHeadsFromLog());
            logHeads = TMP_tmp0_28;
            TMP_tmp1_23 = (PrtSet)(((PrtSet)((IPrtValue)logHeads)?.Clone()));
            TMP_i_itrEntry_tmp2 = (PrtInt)(((PrtInt)(-1)));
            TMP_tmp4_20 = (PrtInt)(((PrtInt)(TMP_tmp1_23).Count));
            sizeof_itrEntry_tmp3 = TMP_tmp4_20;
            while (((PrtBool)true))
            {
                TMP_tmp5_21 = (PrtInt)((sizeof_itrEntry_tmp3) - (((PrtInt)(1))));
                TMP_tmp6_20 = (PrtBool)((TMP_i_itrEntry_tmp2) < (TMP_tmp5_21));
                TMP_tmp7_16 = (PrtBool)(((PrtBool)((IPrtValue)TMP_tmp6_20)?.Clone()));
                if (TMP_tmp7_16)
                {
                }
                else
                {
                    break;
                }
                TMP_tmp8_13 = (PrtInt)((TMP_i_itrEntry_tmp2) + (((PrtInt)(1))));
                TMP_i_itrEntry_tmp2 = TMP_tmp8_13;
                TMP_tmp9_8 = (tEntry)(((PrtSet)TMP_tmp1_23)[TMP_i_itrEntry_tmp2]);
                TMP_tmp10_8 = (tEntry)(((tEntry)((IPrtValue)TMP_tmp9_8)?.Clone()));
                itrEntry = TMP_tmp10_8;
                TMP_tmp11_4 = (tEntry)(((tEntry)((IPrtValue)itrEntry)?.Clone()));
                TMP_tmp12_3 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp11_4, currentMachine));
                ((PrtSet)nexts).Add(TMP_tmp12_3);
            }
            TMP_tmp13_1 = (PrtInt)(((PrtInt)(logHeads).Count));
            TMP_tmp14_1 = (PrtInt)((numReferences) + (TMP_tmp13_1));
            totalNumReferences = TMP_tmp14_1;
            TMP_tmp15_1 = (PrtSet)(((PrtSet)((IPrtValue)logHeads)?.Clone()));
            TMP_tmp16_1 = (PrtInt)(((PrtInt)((IPrtValue)totalNumReferences)?.Clone()));
            TMP_tmp17_1 = (PrtSet)(GlobalFunctions.GetReferences(TMP_tmp15_1, TMP_tmp16_1, currentMachine));
            refs = TMP_tmp17_1;
            TMP_tmp18_1 = (PMachineValue)(((PMachineValue)((IPrtValue)clock)?.Clone()));
            TMP_tmp19_1 = (PEvent)(new eGetNowReq((new PrtNamedTuple(new string[]{"source"},null))));
            TMP_tmp20_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp21_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source"}, TMP_tmp20_1)));
            currentMachine.TrySendEvent(TMP_tmp18_1, (Event)TMP_tmp19_1, TMP_tmp21_1);
            var PGEN_recvEvent_8 = await currentMachine.TryReceiveEvent(typeof(eGetNowResp), typeof(PHalt));
            switch (PGEN_recvEvent_8) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eGetNowResp PGEN_evt_8: {
                    PrtNamedTuple resp_8 = (PrtNamedTuple)(PGEN_evt_8.Payload);
                    TMP_tmp22_1 = (PrtInt)(((PrtNamedTuple)resp_8)["status"]);
                    TMP_tmp23_1 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp22_1),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp24 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:210:17")));
                    TMP_tmp25 = (PrtString)(((PrtString) String.Format("Failed to get now from clock.")));
                    TMP_tmp26 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp24,TMP_tmp25)));
                    currentMachine.TryAssert(TMP_tmp23_1,"Assertion Failed: " + TMP_tmp26);
                    TMP_tmp27 = (tTimestamp)(((PrtNamedTuple)resp_8)["now"]);
                    TMP_tmp28 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp27)?.Clone()));
                    now = TMP_tmp28;
                } break;
            }
            TMP_tmp29 = (PrtString)(((PrtString)((IPrtValue)identity)?.Clone()));
            TMP_tmp30 = (PrtString)(((PrtString)((IPrtValue)logId)?.Clone()));
            TMP_tmp31 = (PrtString)(((PrtString)((IPrtValue)entryData)?.Clone()));
            TMP_tmp32 = (tTimestamp)(((tTimestamp)((IPrtValue)now)?.Clone()));
            TMP_tmp33 = (PrtSet)(((PrtSet)((IPrtValue)nexts)?.Clone()));
            TMP_tmp34 = (PrtSet)(((PrtSet)((IPrtValue)refs)?.Clone()));
            TMP_tmp35 = (tEntry)(GlobalFunctions.CreateEntry(TMP_tmp29, TMP_tmp30, TMP_tmp31, TMP_tmp32, TMP_tmp33, TMP_tmp34, currentMachine));
            createdEntry = TMP_tmp35;
            TMP_tmp36 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            ((PrtSet)entrySet).Add(TMP_tmp36);
            TMP_tmp37 = (PMachineValue)(((PMachineValue)((IPrtValue)heads_2)?.Clone()));
            TMP_tmp38 = (PEvent)(new eSetEntriesInHeadsReq((new PrtNamedTuple(new string[]{"source","entries"},null, new PrtSet()))));
            TMP_tmp39 = (PMachineValue)(currentMachine.self);
            TMP_tmp40 = (PrtSet)(((PrtSet)((IPrtValue)entrySet)?.Clone()));
            TMP_tmp41 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","entries"}, TMP_tmp39, TMP_tmp40)));
            currentMachine.TrySendEvent(TMP_tmp37, (Event)TMP_tmp38, TMP_tmp41);
            var PGEN_recvEvent_9 = await currentMachine.TryReceiveEvent(typeof(eSetEntriesInHeadsResp), typeof(PHalt));
            switch (PGEN_recvEvent_9) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eSetEntriesInHeadsResp PGEN_evt_9: {
                    PrtNamedTuple resp_9 = (PrtNamedTuple)(PGEN_evt_9.Payload);
                    TMP_tmp42 = (PrtInt)(((PrtNamedTuple)resp_9)["status"]);
                    TMP_tmp43 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp42),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp44 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:220:17")));
                    TMP_tmp45 = (PrtString)(((PrtString) String.Format("Could not set entries in Heads")));
                    TMP_tmp46 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp44,TMP_tmp45)));
                    currentMachine.TryAssert(TMP_tmp43,"Assertion Failed: " + TMP_tmp46);
                } break;
            }
            TMP_tmp47 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp48 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp49 = (PMachineValue)(currentMachine.self);
            TMP_tmp50 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp51 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp50, currentMachine));
            TMP_tmp52 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp53 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp49, TMP_tmp51, TMP_tmp52)));
            currentMachine.TrySendEvent(TMP_tmp47, (Event)TMP_tmp48, TMP_tmp53);
            var PGEN_recvEvent_10 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_10) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_10: {
                    PrtNamedTuple resp_10 = (PrtNamedTuple)(PGEN_evt_10.Payload);
                    TMP_tmp54 = (PrtInt)(((PrtNamedTuple)resp_10)["status"]);
                    TMP_tmp55 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp54),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp56 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:226:17")));
                    TMP_tmp57 = (PrtString)(((PrtString) String.Format("Could not put entry in Entries Storage")));
                    TMP_tmp58 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp56,TMP_tmp57)));
                    currentMachine.TryAssert(TMP_tmp55,"Assertion Failed: " + TMP_tmp58);
                } break;
            }
            TMP_tmp59 = (PMachineValue)(((PMachineValue)((IPrtValue)index)?.Clone()));
            TMP_tmp60 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp61 = (PMachineValue)(currentMachine.self);
            TMP_tmp62 = (tEntry)(((tEntry)((IPrtValue)createdEntry)?.Clone()));
            TMP_tmp63 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp62, currentMachine));
            TMP_tmp64 = (PrtBool)(((PrtBool)true));
            TMP_tmp65 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp61, TMP_tmp63, TMP_tmp64)));
            currentMachine.TrySendEvent(TMP_tmp59, (Event)TMP_tmp60, TMP_tmp65);
            var PGEN_recvEvent_11 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_11) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_11: {
                    PrtNamedTuple resp_11 = (PrtNamedTuple)(PGEN_evt_11.Payload);
                    TMP_tmp66 = (PrtInt)(((PrtNamedTuple)resp_11)["status"]);
                    TMP_tmp67 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp66),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp68 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:232:17")));
                    TMP_tmp69 = (PrtString)(((PrtString) String.Format("Could not put entry in Index Storage")));
                    TMP_tmp70 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp68,TMP_tmp69)));
                    currentMachine.TryAssert(TMP_tmp67,"Assertion Failed: " + TMP_tmp70);
                } break;
            }
            return ((tEntry)((IPrtValue)createdEntry)?.Clone());
        }
        public void JoinLog(PMachineValue log)
        {
            Log currentMachine = this;
            PrtSet otherLogHeads = new PrtSet();
            tEntry otherLogEntry = null;
        }
        public async Task<PrtBool> JoinEntry(tEntry entryToJoin)
        {
            Log currentMachine = this;
            PrtBool returnBool = ((PrtBool)false);
            tEntry TMP_tmp0_29 = null;
            PrtString TMP_tmp1_24 = ((PrtString)"");
            PrtBool TMP_tmp2_22 = ((PrtBool)false);
            PrtBool TMP_tmp3_21 = ((PrtBool)false);
            PMachineValue TMP_tmp4_21 = null;
            PEvent TMP_tmp5_22 = null;
            PMachineValue TMP_tmp6_21 = null;
            tEntry TMP_tmp7_17 = null;
            tTimestamp TMP_tmp8_14 = null;
            PrtNamedTuple TMP_tmp9_9 = (new PrtNamedTuple(new string[]{"source","remoteTs"},null, null));
            PrtInt TMP_tmp10_9 = ((PrtInt)0);
            PrtBool TMP_tmp11_5 = ((PrtBool)false);
            PrtString TMP_tmp12_4 = ((PrtString)"");
            PrtString TMP_tmp13_2 = ((PrtString)"");
            PrtString TMP_tmp14_2 = ((PrtString)"");
            PMachineValue TMP_tmp15_2 = null;
            PEvent TMP_tmp16_2 = null;
            PMachineValue TMP_tmp17_2 = null;
            tEntry TMP_tmp18_2 = null;
            PrtNamedTuple TMP_tmp19_2 = (new PrtNamedTuple(new string[]{"source","headEntry"},null, null));
            PrtInt TMP_tmp20_2 = ((PrtInt)0);
            PrtBool TMP_tmp21_2 = ((PrtBool)false);
            PrtString TMP_tmp22_2 = ((PrtString)"");
            PrtString TMP_tmp23_2 = ((PrtString)"");
            PrtString TMP_tmp24_1 = ((PrtString)"");
            PrtSet TMP_tmp25_1 = new PrtSet();
            PrtSet TMP_tmp26_1 = new PrtSet();
            PrtBool TMP_tmp27_1 = ((PrtBool)false);
            PrtBool TMP_tmp28_1 = ((PrtBool)false);
            PMachineValue TMP_tmp29_1 = null;
            PEvent TMP_tmp30_1 = null;
            PMachineValue TMP_tmp31_1 = null;
            tEntry TMP_tmp32_1 = null;
            PrtString TMP_tmp33_1 = ((PrtString)"");
            tEntry TMP_tmp34_1 = null;
            PrtNamedTuple TMP_tmp35_1 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null));
            PrtInt TMP_tmp36_1 = ((PrtInt)0);
            PrtBool TMP_tmp37_1 = ((PrtBool)false);
            PrtString TMP_tmp38_1 = ((PrtString)"");
            PrtString TMP_tmp39_1 = ((PrtString)"");
            PrtString TMP_tmp40_1 = ((PrtString)"");
            PMachineValue TMP_tmp41_1 = null;
            PEvent TMP_tmp42_1 = null;
            PMachineValue TMP_tmp43_1 = null;
            tEntry TMP_tmp44_1 = null;
            PrtString TMP_tmp45_1 = ((PrtString)"");
            PrtBool TMP_tmp46_1 = ((PrtBool)false);
            PrtNamedTuple TMP_tmp47_1 = (new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), ((PrtBool)false)));
            PrtInt TMP_tmp48_1 = ((PrtInt)0);
            PrtBool TMP_tmp49_1 = ((PrtBool)false);
            PrtString TMP_tmp50_1 = ((PrtString)"");
            PrtString TMP_tmp51_1 = ((PrtString)"");
            PrtString TMP_tmp52_1 = ((PrtString)"");
            TMP_tmp0_29 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp1_24 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp0_29, currentMachine));
            TMP_tmp2_22 = (PrtBool)(await LogHasEntry(TMP_tmp1_24));
            TMP_tmp3_21 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp2_22,((PrtBool)true))));
            if (TMP_tmp3_21)
            {
                return ((PrtBool)false);
            }
            TMP_tmp4_21 = (PMachineValue)(((PMachineValue)((IPrtValue)clock)?.Clone()));
            TMP_tmp5_22 = (PEvent)(new eUpdateHlcReq((new PrtNamedTuple(new string[]{"source","remoteTs"},null, null))));
            TMP_tmp6_21 = (PMachineValue)(currentMachine.self);
            TMP_tmp7_17 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp8_14 = (tTimestamp)(GlobalFunctions.GetClock(TMP_tmp7_17, currentMachine));
            TMP_tmp9_9 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","remoteTs"}, TMP_tmp6_21, TMP_tmp8_14)));
            currentMachine.TrySendEvent(TMP_tmp4_21, (Event)TMP_tmp5_22, TMP_tmp9_9);
            var PGEN_recvEvent_12 = await currentMachine.TryReceiveEvent(typeof(eUpdateHlcResp), typeof(PHalt));
            switch (PGEN_recvEvent_12) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eUpdateHlcResp PGEN_evt_12: {
                    PrtNamedTuple resp_12 = (PrtNamedTuple)(PGEN_evt_12.Payload);
                    TMP_tmp10_9 = (PrtInt)(((PrtNamedTuple)resp_12)["status"]);
                    TMP_tmp11_5 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp10_9),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp12_4 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:253:17")));
                    TMP_tmp13_2 = (PrtString)(((PrtString) String.Format("Failed to update clock with other entry's clock")));
                    TMP_tmp14_2 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp12_4,TMP_tmp13_2)));
                    currentMachine.TryAssert(TMP_tmp11_5,"Assertion Failed: " + TMP_tmp14_2);
                } break;
            }
            TMP_tmp15_2 = (PMachineValue)(((PMachineValue)((IPrtValue)heads_2)?.Clone()));
            TMP_tmp16_2 = (PEvent)(new eAddEntryToHeadsReq((new PrtNamedTuple(new string[]{"source","headEntry"},null, null))));
            TMP_tmp17_2 = (PMachineValue)(currentMachine.self);
            TMP_tmp18_2 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp19_2 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","headEntry"}, TMP_tmp17_2, TMP_tmp18_2)));
            currentMachine.TrySendEvent(TMP_tmp15_2, (Event)TMP_tmp16_2, TMP_tmp19_2);
            var PGEN_recvEvent_13 = await currentMachine.TryReceiveEvent(typeof(eAddEntryToHeadsResp), typeof(PHalt));
            switch (PGEN_recvEvent_13) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case eAddEntryToHeadsResp PGEN_evt_13: {
                    PrtNamedTuple resp_13 = (PrtNamedTuple)(PGEN_evt_13.Payload);
                    TMP_tmp20_2 = (PrtInt)(((PrtNamedTuple)resp_13)["status"]);
                    TMP_tmp21_2 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp20_2),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp22_2 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:259:17")));
                    TMP_tmp23_2 = (PrtString)(((PrtString) String.Format("Failed to add entry to Heads")));
                    TMP_tmp24_1 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp22_2,TMP_tmp23_2)));
                    currentMachine.TryAssert(TMP_tmp21_2,"Assertion Failed: " + TMP_tmp24_1);
                    TMP_tmp25_1 = (PrtSet)(((PrtNamedTuple)resp_13)["newHeads"]);
                    TMP_tmp26_1 = (PrtSet)(await GetHeadsFromLog());
                    TMP_tmp27_1 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp25_1,TMP_tmp26_1)));
                    if (TMP_tmp27_1)
                    {
                        returnBool = (PrtBool)(((PrtBool)false));
                    }
                } break;
            }
            TMP_tmp28_1 = (PrtBool)((PrtValues.SafeEquals(returnBool,((PrtBool)false))));
            if (TMP_tmp28_1)
            {
                return ((PrtBool)false);
            }
            TMP_tmp29_1 = (PMachineValue)(((PMachineValue)((IPrtValue)entries_2)?.Clone()));
            TMP_tmp30_1 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp31_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp32_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp33_1 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp32_1, currentMachine));
            TMP_tmp34_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp35_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp31_1, TMP_tmp33_1, TMP_tmp34_1)));
            currentMachine.TrySendEvent(TMP_tmp29_1, (Event)TMP_tmp30_1, TMP_tmp35_1);
            var PGEN_recvEvent_14 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_14) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_14: {
                    PrtNamedTuple resp_14 = (PrtNamedTuple)(PGEN_evt_14.Payload);
                    TMP_tmp36_1 = (PrtInt)(((PrtNamedTuple)resp_14)["status"]);
                    TMP_tmp37_1 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp36_1),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp38_1 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:272:17")));
                    TMP_tmp39_1 = (PrtString)(((PrtString) String.Format("Could not put entry in Entries Storage")));
                    TMP_tmp40_1 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp38_1,TMP_tmp39_1)));
                    currentMachine.TryAssert(TMP_tmp37_1,"Assertion Failed: " + TMP_tmp40_1);
                } break;
            }
            TMP_tmp41_1 = (PMachineValue)(((PMachineValue)((IPrtValue)index)?.Clone()));
            TMP_tmp42_1 = (PEvent)(new ePutValueInStorageReq((new PrtNamedTuple(new string[]{"source","key","value"},null, ((PrtString)""), null))));
            TMP_tmp43_1 = (PMachineValue)(currentMachine.self);
            TMP_tmp44_1 = (tEntry)(((tEntry)((IPrtValue)entryToJoin)?.Clone()));
            TMP_tmp45_1 = (PrtString)(GlobalFunctions.GetHash(TMP_tmp44_1, currentMachine));
            TMP_tmp46_1 = (PrtBool)(((PrtBool)true));
            TMP_tmp47_1 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"source","key","value"}, TMP_tmp43_1, TMP_tmp45_1, TMP_tmp46_1)));
            currentMachine.TrySendEvent(TMP_tmp41_1, (Event)TMP_tmp42_1, TMP_tmp47_1);
            var PGEN_recvEvent_15 = await currentMachine.TryReceiveEvent(typeof(ePutValueInStorageResp), typeof(PHalt));
            switch (PGEN_recvEvent_15) {
                case PHalt _hv: { currentMachine.TryRaiseEvent(_hv); break;} 
                case ePutValueInStorageResp PGEN_evt_15: {
                    PrtNamedTuple resp_15 = (PrtNamedTuple)(PGEN_evt_15.Payload);
                    TMP_tmp48_1 = (PrtInt)(((PrtNamedTuple)resp_15)["status"]);
                    TMP_tmp49_1 = (PrtBool)((PrtValues.SafeEquals(PrtValues.Box((long) TMP_tmp48_1),PrtValues.Box((long) (PrtEnum.Get("SUCCESS"))))));
                    TMP_tmp50_1 = (PrtString)(((PrtString) String.Format("PSrc/oplog/log.p:278:17")));
                    TMP_tmp51_1 = (PrtString)(((PrtString) String.Format("Could not put entry in Index Storage")));
                    TMP_tmp52_1 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp50_1,TMP_tmp51_1)));
                    currentMachine.TryAssert(TMP_tmp49_1,"Assertion Failed: " + TMP_tmp52_1);
                } break;
            }
            return ((PrtBool)true);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Init))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_17))]
        class Init : State
        {
        }
        [OnEventDoAction(typeof(eGetClockLastStateReq), nameof(Anon_18))]
        [OnEventDoAction(typeof(eGetHeadsFromLogReq), nameof(Anon_19))]
        [OnEventDoAction(typeof(eGetAllEntriesFromLogReq), nameof(Anon_20))]
        [OnEventDoAction(typeof(eGetEntryFromLogReq), nameof(Anon_21))]
        [OnEventDoAction(typeof(eDoesLogHaveEntryReq), nameof(Anon_22))]
        [OnEventDoAction(typeof(eAppendNewEntryToLogReq), nameof(Anon_23))]
        [OnEventDoAction(typeof(eJoinLogReq), nameof(Anon_24))]
        [OnEventDoAction(typeof(eJoinEntryReq), nameof(Anon_25))]
        [OnEventDoAction(typeof(eTraverseLogReq), nameof(Anon_26))]
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
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
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
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
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
        
        public void Anon_27(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtString id_1 = (PrtString)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tPhysicalTime physicalTime = null;
            PrtInt physicalTimeNow = ((PrtInt)0);
            tTimestamp timestamp = null;
            PrtInt TMP_tmp0_30 = ((PrtInt)0);
            tPhysicalTime TMP_tmp1_25 = null;
            tPhysicalTime TMP_tmp2_23 = null;
            PrtInt TMP_tmp3_22 = ((PrtInt)0);
            PrtInt TMP_tmp4_22 = ((PrtInt)0);
            PrtInt TMP_tmp5_23 = ((PrtInt)0);
            PrtString TMP_tmp6_22 = ((PrtString)"");
            tTimestamp TMP_tmp7_18 = null;
            PrtString TMP_tmp8_15 = ((PrtString)"");
            tPhysicalTime TMP_tmp9_10 = null;
            tTimestamp TMP_tmp10_10 = null;
            tHybridLogicalClock TMP_tmp11_6 = null;
            id_1 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp0_30 = (PrtInt)(((PrtInt)(0)));
            TMP_tmp1_25 = (tPhysicalTime)(GlobalFunctions.CreatePhysicalTime(TMP_tmp0_30, currentMachine));
            physicalTime = TMP_tmp1_25;
            TMP_tmp2_23 = (tPhysicalTime)(((tPhysicalTime)((IPrtValue)physicalTime)?.Clone()));
            TMP_tmp3_22 = (PrtInt)(GlobalFunctions.GetPhysicalTimeNow(TMP_tmp2_23, currentMachine));
            physicalTimeNow = TMP_tmp3_22;
            TMP_tmp4_22 = (PrtInt)(((PrtInt)((IPrtValue)physicalTimeNow)?.Clone()));
            TMP_tmp5_23 = (PrtInt)(((PrtInt)(0)));
            TMP_tmp6_22 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp7_18 = (tTimestamp)(GlobalFunctions.CreateNewTimestamp(TMP_tmp4_22, TMP_tmp5_23, TMP_tmp6_22, currentMachine));
            timestamp = TMP_tmp7_18;
            TMP_tmp8_15 = (PrtString)(((PrtString)((IPrtValue)id_1)?.Clone()));
            TMP_tmp9_10 = (tPhysicalTime)(((tPhysicalTime)((IPrtValue)physicalTime)?.Clone()));
            TMP_tmp10_10 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp)?.Clone()));
            TMP_tmp11_6 = (tHybridLogicalClock)(GlobalFunctions.CreateHybridLogicalClock(TMP_tmp8_15, TMP_tmp9_10, TMP_tmp10_10, currentMachine));
            hlc = TMP_tmp11_6;
        }
        public void Anon_28(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtNamedTuple req_24 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PMachineValue TMP_tmp0_31 = null;
            PMachineValue TMP_tmp1_26 = null;
            PEvent TMP_tmp2_24 = null;
            PrtInt TMP_tmp3_23 = ((PrtInt)0);
            tHybridLogicalClock TMP_tmp4_23 = null;
            tTimestamp TMP_tmp5_24 = null;
            PrtNamedTuple TMP_tmp6_23 = (new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null));
            TMP_tmp0_31 = (PMachineValue)(((PrtNamedTuple)req_24)["source"]);
            TMP_tmp1_26 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp0_31)?.Clone()));
            TMP_tmp2_24 = (PEvent)(new eGetLastTimestampResp((new PrtNamedTuple(new string[]{"status","lastTimestamp"},((PrtInt)0), null))));
            TMP_tmp3_23 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp4_23 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp5_24 = (tTimestamp)(GlobalFunctions.GetLastTimestamp(TMP_tmp4_23, currentMachine));
            TMP_tmp6_23 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","lastTimestamp"}, TMP_tmp3_23, TMP_tmp5_24)));
            currentMachine.TrySendEvent(TMP_tmp1_26, (Event)TMP_tmp2_24, TMP_tmp6_23);
        }
        public void Anon_29(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtNamedTuple req_25 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp previousTimestamp = null;
            PrtNamedTuple nowResponse = (new PrtNamedTuple(new string[]{"newHlc","timestamp"},null, null));
            tTimestamp extractedTimestamp = null;
            PrtInt comparisonToPrevious = ((PrtInt)0);
            tHybridLogicalClock TMP_tmp0_32 = null;
            tTimestamp TMP_tmp1_27 = null;
            tHybridLogicalClock TMP_tmp2_25 = null;
            PrtNamedTuple TMP_tmp3_24 = (new PrtNamedTuple(new string[]{"newHlc","timestamp"},null, null));
            tHybridLogicalClock TMP_tmp4_24 = null;
            tHybridLogicalClock TMP_tmp5_25 = null;
            tTimestamp TMP_tmp6_24 = null;
            tTimestamp TMP_tmp7_19 = null;
            tTimestamp TMP_tmp8_16 = null;
            tTimestamp TMP_tmp9_11 = null;
            PrtInt TMP_tmp10_11 = ((PrtInt)0);
            PMachineValue TMP_tmp11_7 = null;
            PMachineValue TMP_tmp12_5 = null;
            PEvent TMP_tmp13_3 = null;
            PrtInt TMP_tmp14_3 = ((PrtInt)0);
            tTimestamp TMP_tmp15_3 = null;
            PrtInt TMP_tmp16_3 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp17_3 = (new PrtNamedTuple(new string[]{"status","now","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)));
            TMP_tmp0_32 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp1_27 = (tTimestamp)(GlobalFunctions.GetLastTimestamp(TMP_tmp0_32, currentMachine));
            previousTimestamp = TMP_tmp1_27;
            TMP_tmp2_25 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp3_24 = (PrtNamedTuple)(GlobalFunctions.GetHlcNow(TMP_tmp2_25, currentMachine));
            nowResponse = TMP_tmp3_24;
            TMP_tmp4_24 = (tHybridLogicalClock)(((PrtNamedTuple)nowResponse)["newHlc"]);
            TMP_tmp5_25 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)TMP_tmp4_24)?.Clone()));
            hlc = TMP_tmp5_25;
            TMP_tmp6_24 = (tTimestamp)(((PrtNamedTuple)nowResponse)["timestamp"]);
            TMP_tmp7_19 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp6_24)?.Clone()));
            extractedTimestamp = TMP_tmp7_19;
            TMP_tmp8_16 = (tTimestamp)(((tTimestamp)((IPrtValue)extractedTimestamp)?.Clone()));
            TMP_tmp9_11 = (tTimestamp)(((tTimestamp)((IPrtValue)previousTimestamp)?.Clone()));
            TMP_tmp10_11 = (PrtInt)(GlobalFunctions.CompareTimestamps(TMP_tmp8_16, TMP_tmp9_11, currentMachine));
            comparisonToPrevious = TMP_tmp10_11;
            TMP_tmp11_7 = (PMachineValue)(((PrtNamedTuple)req_25)["source"]);
            TMP_tmp12_5 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp11_7)?.Clone()));
            TMP_tmp13_3 = (PEvent)(new eGetNowResp((new PrtNamedTuple(new string[]{"status","now","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)))));
            TMP_tmp14_3 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp15_3 = (tTimestamp)(((tTimestamp)((IPrtValue)extractedTimestamp)?.Clone()));
            TMP_tmp16_3 = (PrtInt)(((PrtInt)((IPrtValue)comparisonToPrevious)?.Clone()));
            TMP_tmp17_3 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","now","comparisonToPrevious"}, TMP_tmp14_3, TMP_tmp15_3, TMP_tmp16_3)));
            currentMachine.TrySendEvent(TMP_tmp12_5, (Event)TMP_tmp13_3, TMP_tmp17_3);
        }
        public void Anon_30(Event currentMachine_dequeuedEvent)
        {
            HybridLogicalClock currentMachine = this;
            PrtNamedTuple req_26 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tTimestamp previousTimestamp_1 = null;
            PrtInt comparisonToPrevious_1 = ((PrtInt)0);
            PrtNamedTuple updateResponse = (new PrtNamedTuple(new string[]{"newHlc","updatedTimestamp"},null, null));
            tTimestamp timestamp_1 = null;
            tHybridLogicalClock TMP_tmp0_33 = null;
            tTimestamp TMP_tmp1_28 = null;
            tHybridLogicalClock TMP_tmp2_26 = null;
            tTimestamp TMP_tmp3_25 = null;
            PrtNamedTuple TMP_tmp4_25 = (new PrtNamedTuple(new string[]{"newHlc","updatedTimestamp"},null, null));
            tHybridLogicalClock TMP_tmp5_26 = null;
            tHybridLogicalClock TMP_tmp6_25 = null;
            tTimestamp TMP_tmp7_20 = null;
            tTimestamp TMP_tmp8_17 = null;
            tTimestamp TMP_tmp9_12 = null;
            tTimestamp TMP_tmp10_12 = null;
            PrtInt TMP_tmp11_8 = ((PrtInt)0);
            PMachineValue TMP_tmp12_6 = null;
            PMachineValue TMP_tmp13_4 = null;
            PEvent TMP_tmp14_4 = null;
            PrtInt TMP_tmp15_4 = ((PrtInt)0);
            tTimestamp TMP_tmp16_4 = null;
            PrtInt TMP_tmp17_4 = ((PrtInt)0);
            PrtNamedTuple TMP_tmp18_3 = (new PrtNamedTuple(new string[]{"status","updatedTimestamp","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)));
            TMP_tmp0_33 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp1_28 = (tTimestamp)(GlobalFunctions.GetLastTimestamp(TMP_tmp0_33, currentMachine));
            previousTimestamp_1 = TMP_tmp1_28;
            TMP_tmp2_26 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)hlc)?.Clone()));
            TMP_tmp3_25 = (tTimestamp)(((PrtNamedTuple)req_26)["remoteTs"]);
            TMP_tmp4_25 = (PrtNamedTuple)(GlobalFunctions.UpdateHlc(TMP_tmp2_26, TMP_tmp3_25, currentMachine));
            updateResponse = TMP_tmp4_25;
            TMP_tmp5_26 = (tHybridLogicalClock)(((PrtNamedTuple)updateResponse)["newHlc"]);
            TMP_tmp6_25 = (tHybridLogicalClock)(((tHybridLogicalClock)((IPrtValue)TMP_tmp5_26)?.Clone()));
            hlc = TMP_tmp6_25;
            TMP_tmp7_20 = (tTimestamp)(((PrtNamedTuple)updateResponse)["updatedTimestamp"]);
            TMP_tmp8_17 = (tTimestamp)(((tTimestamp)((IPrtValue)TMP_tmp7_20)?.Clone()));
            timestamp_1 = TMP_tmp8_17;
            TMP_tmp9_12 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp_1)?.Clone()));
            TMP_tmp10_12 = (tTimestamp)(((tTimestamp)((IPrtValue)previousTimestamp_1)?.Clone()));
            TMP_tmp11_8 = (PrtInt)(GlobalFunctions.CompareTimestamps(TMP_tmp9_12, TMP_tmp10_12, currentMachine));
            comparisonToPrevious_1 = TMP_tmp11_8;
            TMP_tmp12_6 = (PMachineValue)(((PrtNamedTuple)req_26)["source"]);
            TMP_tmp13_4 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp12_6)?.Clone()));
            TMP_tmp14_4 = (PEvent)(new eUpdateHlcResp((new PrtNamedTuple(new string[]{"status","updatedTimestamp","comparisonToPrevious"},((PrtInt)0), null, ((PrtInt)0)))));
            TMP_tmp15_4 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp16_4 = (tTimestamp)(((tTimestamp)((IPrtValue)timestamp_1)?.Clone()));
            TMP_tmp17_4 = (PrtInt)(((PrtInt)((IPrtValue)comparisonToPrevious_1)?.Clone()));
            TMP_tmp18_3 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","updatedTimestamp","comparisonToPrevious"}, TMP_tmp15_4, TMP_tmp16_4, TMP_tmp17_4)));
            currentMachine.TrySendEvent(TMP_tmp13_4, (Event)TMP_tmp14_4, TMP_tmp18_3);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Active))]
        class __InitState__ : State { }
        
        [OnEntry(nameof(Anon_27))]
        [OnEventDoAction(typeof(eGetLastTimestampReq), nameof(Anon_28))]
        [OnEventDoAction(typeof(eGetNowReq), nameof(Anon_29))]
        [OnEventDoAction(typeof(eUpdateHlcReq), nameof(Anon_30))]
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
            this.sends.Add(nameof(eAppendNewEntryToLogReq));
            this.sends.Add(nameof(eAppendNewEntryToLogResp));
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
            this.receives.Add(nameof(eAppendNewEntryToLogReq));
            this.receives.Add(nameof(eAppendNewEntryToLogResp));
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
        
        public void Anon_31(Event currentMachine_dequeuedEvent)
        {
            EntryMachine currentMachine = this;
            PrtNamedTuple req_27 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            tEntry createdEntry_1 = null;
            PrtString TMP_tmp0_34 = ((PrtString)"");
            PrtString TMP_tmp1_29 = ((PrtString)"");
            PrtString TMP_tmp2_27 = ((PrtString)"");
            tTimestamp TMP_tmp3_26 = null;
            PrtSet TMP_tmp4_26 = new PrtSet();
            PrtSet TMP_tmp5_27 = new PrtSet();
            tEntry TMP_tmp6_26 = null;
            PMachineValue TMP_tmp7_21 = null;
            PMachineValue TMP_tmp8_18 = null;
            PEvent TMP_tmp9_13 = null;
            PrtInt TMP_tmp10_13 = ((PrtInt)0);
            tEntry TMP_tmp11_9 = null;
            PrtNamedTuple TMP_tmp12_7 = (new PrtNamedTuple(new string[]{"status","createdEntry"},((PrtInt)0), null));
            TMP_tmp0_34 = (PrtString)(((PrtNamedTuple)req_27)["identity"]);
            TMP_tmp1_29 = (PrtString)(((PrtNamedTuple)req_27)["id"]);
            TMP_tmp2_27 = (PrtString)(((PrtNamedTuple)req_27)["entryData"]);
            TMP_tmp3_26 = (tTimestamp)(((PrtNamedTuple)req_27)["clock"]);
            TMP_tmp4_26 = (PrtSet)(((PrtNamedTuple)req_27)["next"]);
            TMP_tmp5_27 = (PrtSet)(((PrtNamedTuple)req_27)["refs"]);
            TMP_tmp6_26 = (tEntry)(GlobalFunctions.CreateEntry(TMP_tmp0_34, TMP_tmp1_29, TMP_tmp2_27, TMP_tmp3_26, TMP_tmp4_26, TMP_tmp5_27, currentMachine));
            createdEntry_1 = TMP_tmp6_26;
            TMP_tmp7_21 = (PMachineValue)(((PrtNamedTuple)req_27)["source"]);
            TMP_tmp8_18 = (PMachineValue)(((PMachineValue)((IPrtValue)TMP_tmp7_21)?.Clone()));
            TMP_tmp9_13 = (PEvent)(new eCreateEntryResp((new PrtNamedTuple(new string[]{"status","createdEntry"},((PrtInt)0), null))));
            TMP_tmp10_13 = (PrtInt)((PrtEnum.Get("SUCCESS")));
            TMP_tmp11_9 = (tEntry)(((tEntry)((IPrtValue)createdEntry_1)?.Clone()));
            TMP_tmp12_7 = (PrtNamedTuple)((new PrtNamedTuple(new string[]{"status","createdEntry"}, TMP_tmp10_13, TMP_tmp11_9)));
            currentMachine.TrySendEvent(TMP_tmp8_18, (Event)TMP_tmp9_13, TMP_tmp12_7);
        }
        [Start]
        [OnEntry(nameof(InitializeParametersFunction))]
        [OnEventGotoState(typeof(ConstructorEvent), typeof(Active))]
        class __InitState__ : State { }
        
        [OnEventDoAction(typeof(eCreateEntryReq), nameof(Anon_31))]
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
        
        public void Anon_32(Event currentMachine_dequeuedEvent)
        {
            TimestampsAreMonotonicallyIncreasing currentMachine = this;
            PrtNamedTuple resp_16 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_35 = ((PrtInt)0);
            PrtBool TMP_tmp1_30 = ((PrtBool)false);
            PrtString TMP_tmp2_28 = ((PrtString)"");
            PrtString TMP_tmp3_27 = ((PrtString)"");
            PrtString TMP_tmp4_27 = ((PrtString)"");
            TMP_tmp0_35 = (PrtInt)(((PrtNamedTuple)resp_16)["comparisonToPrevious"]);
            TMP_tmp1_30 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp0_35,((PrtInt)(1)))));
            TMP_tmp2_28 = (PrtString)(((PrtString) String.Format("PSpec/HybridLogicalClockSpec.p:4:13")));
            TMP_tmp3_27 = (PrtString)(((PrtString) String.Format("Timestamps are not monotonically increasing.")));
            TMP_tmp4_27 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp2_28,TMP_tmp3_27)));
            currentMachine.TryAssert(TMP_tmp1_30,"Assertion Failed: " + TMP_tmp4_27);
        }
        public void Anon_33(Event currentMachine_dequeuedEvent)
        {
            TimestampsAreMonotonicallyIncreasing currentMachine = this;
            PrtNamedTuple resp_17 = (PrtNamedTuple)(gotoPayload ?? ((PEvent)currentMachine_dequeuedEvent).Payload);
            this.gotoPayload = null;
            PrtInt TMP_tmp0_36 = ((PrtInt)0);
            PrtBool TMP_tmp1_31 = ((PrtBool)false);
            PrtString TMP_tmp2_29 = ((PrtString)"");
            PrtString TMP_tmp3_28 = ((PrtString)"");
            PrtString TMP_tmp4_28 = ((PrtString)"");
            TMP_tmp0_36 = (PrtInt)(((PrtNamedTuple)resp_17)["comparisonToPrevious"]);
            TMP_tmp1_31 = (PrtBool)((PrtValues.SafeEquals(TMP_tmp0_36,((PrtInt)(1)))));
            TMP_tmp2_29 = (PrtString)(((PrtString) String.Format("PSpec/HybridLogicalClockSpec.p:9:13")));
            TMP_tmp3_28 = (PrtString)(((PrtString) String.Format("Timestamps are not monotonically increasing.")));
            TMP_tmp4_28 = (PrtString)(((PrtString) String.Format("{0} {1}",TMP_tmp2_29,TMP_tmp3_28)));
            currentMachine.TryAssert(TMP_tmp1_31,"Assertion Failed: " + TMP_tmp4_28);
        }
        [Start]
        [OnEventDoAction(typeof(eGetNowResp), nameof(Anon_32))]
        [OnEventDoAction(typeof(eUpdateHlcResp), nameof(Anon_33))]
        class Init : State
        {
        }
    }
}
// TODO: Implement the Foreign Type tMemoryStorage
// TODO: Implement the Foreign Type tPhysicalTime
// TODO: Implement the Foreign Type tHybridLogicalClock
// TODO: Implement the Foreign Type tTimestamp
// TODO: Implement the Foreign Type tEntry
namespace PImplementation
{
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
            PInterfaces.AddInterface(nameof(I_MemoryStorage), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_Heads), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_Log), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_HybridLogicalClock), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
            PInterfaces.AddInterface(nameof(I_EntryMachine), nameof(eAddEntryToHeadsReq), nameof(eAddEntryToHeadsResp), nameof(eAppendNewEntryToLogReq), nameof(eAppendNewEntryToLogResp), nameof(eClearAllEntriesFromHeadsReq), nameof(eClearAllEntriesFromHeadsResp), nameof(eClearAllValuesFromStorageReq), nameof(eClearAllValuesFromStorageResp), nameof(eCreateEntryReq), nameof(eCreateEntryResp), nameof(eDeleteValueFromStorageReq), nameof(eDeleteValueFromStorageResp), nameof(eDoesLogHaveEntryReq), nameof(eDoesLogHaveEntryResp), nameof(eGetAllEntriesFromHeadsReq), nameof(eGetAllEntriesFromHeadsResp), nameof(eGetAllEntriesFromLogReq), nameof(eGetAllEntriesFromLogResp), nameof(eGetAllValuesFromStorageReq), nameof(eGetAllValuesFromStorageResp), nameof(eGetClockLastStateReq), nameof(eGetClockLastStateResp), nameof(eGetEntryFromLogReq), nameof(eGetEntryFromLogResp), nameof(eGetHeadsFromLogReq), nameof(eGetHeadsFromLogResp), nameof(eGetLastTimestampReq), nameof(eGetLastTimestampResp), nameof(eGetNowReq), nameof(eGetNowResp), nameof(eGetValueFromStorageReq), nameof(eGetValueFromStorageResp), nameof(eJoinEntryReq), nameof(eJoinEntryResp), nameof(eJoinLogReq), nameof(eJoinLogResp), nameof(ePutEntriesInHeadsReq), nameof(ePutEntriesInHeadsResp), nameof(ePutValueInStorageReq), nameof(ePutValueInStorageResp), nameof(eSetEntriesInHeadsReq), nameof(eSetEntriesInHeadsResp), nameof(eTraverseLogReq), nameof(eTraverseLogResp), nameof(eUpdateHlcReq), nameof(eUpdateHlcResp), nameof(PHalt));
        }
    }
    
}
namespace PImplementation
{
    public partial class PHelper {
        public static void InitializeEnums() {
            PrtEnum.Clear();
            PrtEnum.AddEnumElements(new [] {"ERROR","SUCCESS"}, new [] {0,1});
            PrtEnum.AddEnumElements(new [] {"DEFAULT"}, new [] {0});
        }
    }
    
}
#pragma warning restore 162, 219, 414
