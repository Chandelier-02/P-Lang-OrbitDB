## System Design:
There will be multiple OrbitDB instances that communicate with one another through events they raise and subscribe to.
The C# code cannot have these modules nested within it. Rather its code should simply take in as arguments the

### OrbitDB State Machine (Basically just the Database part of it):
- EntryStorage (__MemoryStorage Machine__)
- IndexStorage (__MemoryStorage Machine__)
- HeadsStorage (__MemoryStorage Machine__)
- HybridLogicalClock (__HybirdLogicalClock Machine__)
- OpLog (__Log Machine__)
- Sync (__Sync Machine__)

### OpLog State Machine:
- EntryStorage (__MemoryStorage Machine__)
- IndexStorage (__MemoryStorage Machine__)
- Heads
    - HeadsStorage (__MemoryStorage Machine__)


Example call:
LogMachine:
- Gets event to append an entry:
- Calls a function that sends an event to Heads
- Heads then handles some preprocessing.
- Heads then sends an event to its headsStorage.
- Heads storgage responds with an event to Heads.
- Heads responds with an event to the Log.
- The log can do any checks and preprocessing necessary and then respond to sender of event

Basically, we have to send events to objects that would be considered dependencies of parent objects. 
So, they can be a flat map with their own functions. They are a class. Very simple commands though. They do not take
any arguments related to other objects as that forces a grouping and thus is difficult to enforce them 
as separate entities. So, all C# objects are flattened as much as possible, and the state machines defined in P designate
the way that they depend on one another and their organization. All functions that are called from within P have to take in 
the C# object and then __must__ return that C# object if it is modified. So, I need to define an interface for each P object as 
well as for each 