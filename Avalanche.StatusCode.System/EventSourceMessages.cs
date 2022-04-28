/*This file is a derivate of a source file that has following license (below). 

========================================================================
The MIT License (MIT)

Copyright (c) Microsoft Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions: 

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software. 

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
======================================================================*/
namespace Avalanche.StatusCode;
using Avalanche.Utilities;
using Avalanche.Message;
using Avalanche.Template;

/// <summary>System.Diagnostics.Tracing.EventSourceException</summary>
public class EventSourceMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<EventSourceMessages> instance = new Lazy<EventSourceMessages>(() => new EventSourceMessages().Initialize().SetAllReadOnly<EventSourceMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static EventSourceMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0042;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _addscalaroutofrange, _datadescriptorsoutofrange, _eventnamedoesnotequaltaskplusopcode, _eventnamereused, _eventsourceguidinuse, _incorrentlyauthoredtypeinfo, _invalidcommand, _invalideventformat, _listenercreatedinsidecallback, _listenernotfound;
    IMessageDescription? _listenerwritefailure, _needguid, _needname, _nofreebuffers, _noncomplianttypeerror, _norelatedactivityid, _notsupportedarrayofbinary, _notsupportedarrayofnil, _notsupportedarrayofnullterminatedstring, _notsupportedcustomserializeddata;
    IMessageDescription? _notsupportedenumtype, _notsupportednestedarraysenums, _nullinput, _pinarrayoutofrange, _recursivetypedefinition, _sessioniderror, _stopsfollowstarts, _toomanyargs, _toomanyfields, _abstractmustnotdeclareeventmethods;
    IMessageDescription? _abstractmustnotdeclarektoc, _attributeonnonvoid, _channeltypedoesnotmatcheventchannelvalue, _duplicatestringkey, _enumkindmismatch, _etwalreadyregistered, _eventchanneloutofrange, _eventidreused, _eventmusthavetaskifnondefaultopcode, _eventmustnotbeexplicitimplementation;
    IMessageDescription? _eventparametersmismatch, _eventwithadminchannelmusthavemessage, _illegalkeywordsvalue, _illegalopcodevalue, _illegaltaskvalue, _keywordcollision, _keywordneedpoweroftwo, _maxchannelexceeded, _mismatchidtowriteevent, _needpositiveid;
    IMessageDescription? _opcodecollision, _payloadtoobig, _periodillegalinprovidername, _reservedkeywords, _reservedopcode, _taskcollision, _taskopcodepairreused, _tostring, _typemustbesealedorabstract, _typemustderivefromeventsource;
    IMessageDescription? _undefinedchannel, _undefinedkeyword, _undefinedopcode, _unsupportedeventtypeinmanifest, _unsupportedmessageproperty, _varargsparametermismatch;
    
    /// <summary>Getting out of bounds during scalar addition.</summary>
    public IMessageDescription AddScalarOutOfRange { get => _addscalaroutofrange!; set => this.AssertWritable()._addscalaroutofrange = value; }
    /// <summary>Data descriptors are out of range.</summary>
    public IMessageDescription DataDescriptorsOutOfRange { get => _datadescriptorsoutofrange!; set => this.AssertWritable()._datadescriptorsoutofrange = value; }
    /// <summary>Event {0} (with ID {1}) has a name that is not the concatenation of its task name and opcode.</summary>
    public IMessageDescription EventNameDoesNotEqualTaskPlusOpcode { get => _eventnamedoesnotequaltaskplusopcode!; set => this.AssertWritable()._eventnamedoesnotequaltaskplusopcode = value; }
    /// <summary>Event name {0} used more than once. If you wish to overload a method, the overloaded method should have a NonEvent attribute.</summary>
    public IMessageDescription EventNameReused { get => _eventnamereused!; set => this.AssertWritable()._eventnamereused = value; }
    /// <summary>An instance of EventSource with Guid {0} already exists.</summary>
    public IMessageDescription EventSourceGuidInUse { get => _eventsourceguidinuse!; set => this.AssertWritable()._eventsourceguidinuse = value; }
    /// <summary>Incorrectly-authored TypeInfo - a type should be serialized as one field or as one group</summary>
    public IMessageDescription IncorrentlyAuthoredTypeInfo { get => _incorrentlyauthoredtypeinfo!; set => this.AssertWritable()._incorrentlyauthoredtypeinfo = value; }
    /// <summary>Invalid command value.</summary>
    public IMessageDescription InvalidCommand { get => _invalidcommand!; set => this.AssertWritable()._invalidcommand = value; }
    /// <summary>Can&#39;t specify both etw event format flags.</summary>
    public IMessageDescription InvalidEventFormat { get => _invalideventformat!; set => this.AssertWritable()._invalideventformat = value; }
    /// <summary>Creating an EventListener inside a EventListener callback.</summary>
    public IMessageDescription ListenerCreatedInsideCallback { get => _listenercreatedinsidecallback!; set => this.AssertWritable()._listenercreatedinsidecallback = value; }
    /// <summary>Listener not found.</summary>
    public IMessageDescription ListenerNotFound { get => _listenernotfound!; set => this.AssertWritable()._listenernotfound = value; }
    /// <summary>Microsoft.Diagnostics.Tracing</summary>
    public IMessageDescription ListenerWriteFailure { get => _listenerwritefailure!; set => this.AssertWritable()._listenerwritefailure = value; }
    /// <summary>The Guid of an EventSource must be non zero.</summary>
    public IMessageDescription NeedGuid { get => _needguid!; set => this.AssertWritable()._needguid = value; }
    /// <summary>The name of an EventSource must not be null.</summary>
    public IMessageDescription NeedName { get => _needname!; set => this.AssertWritable()._needname = value; }
    /// <summary>No Free Buffers available from the operating system (e.g. event rate too fast).</summary>
    public IMessageDescription NoFreeBuffers { get => _nofreebuffers!; set => this.AssertWritable()._nofreebuffers = value; }
    /// <summary>The API supports only anonymous types or types decorated with the EventDataAttribute. Non-compliant type: {0} dataType.</summary>
    public IMessageDescription NonCompliantTypeError { get => _noncomplianttypeerror!; set => this.AssertWritable()._noncomplianttypeerror = value; }
    /// <summary>EventSource expects the first parameter of the Event method to be of type Guid and to be named &quot;relatedActivityId&quot; when calling WriteEventWithRelatedActivityId.</summary>
    public IMessageDescription NoRelatedActivityId { get => _norelatedactivityid!; set => this.AssertWritable()._norelatedactivityid = value; }
    /// <summary>Arrays of Binary are not supported.</summary>
    public IMessageDescription NotSupportedArrayOfBinary { get => _notsupportedarrayofbinary!; set => this.AssertWritable()._notsupportedarrayofbinary = value; }
    /// <summary>Arrays of Nil are not supported.</summary>
    public IMessageDescription NotSupportedArrayOfNil { get => _notsupportedarrayofnil!; set => this.AssertWritable()._notsupportedarrayofnil = value; }
    /// <summary>Arrays of null-terminated string are not supported.</summary>
    public IMessageDescription NotSupportedArrayOfNullTerminatedString { get => _notsupportedarrayofnullterminatedstring!; set => this.AssertWritable()._notsupportedarrayofnullterminatedstring = value; }
    /// <summary>Enumerables of custom-serialized data are not supported</summary>
    public IMessageDescription NotSupportedCustomSerializedData { get => _notsupportedcustomserializeddata!; set => this.AssertWritable()._notsupportedcustomserializeddata = value; }
    /// <summary>Enum type {0} underlying type {1} is not supported for serialization.</summary>
    public IMessageDescription NotSupportedEnumType { get => _notsupportedenumtype!; set => this.AssertWritable()._notsupportedenumtype = value; }
    /// <summary>Nested arrays/enumerables are not supported.</summary>
    public IMessageDescription NotSupportedNestedArraysEnums { get => _notsupportednestedarraysenums!; set => this.AssertWritable()._notsupportednestedarraysenums = value; }
    /// <summary>Null passed as a event argument.</summary>
    public IMessageDescription NullInput { get => _nullinput!; set => this.AssertWritable()._nullinput = value; }
    /// <summary>Pins are out of range.</summary>
    public IMessageDescription PinArrayOutOfRange { get => _pinarrayoutofrange!; set => this.AssertWritable()._pinarrayoutofrange = value; }
    /// <summary>Recursive type definition is not supported.</summary>
    public IMessageDescription RecursiveTypeDefinition { get => _recursivetypedefinition!; set => this.AssertWritable()._recursivetypedefinition = value; }
    /// <summary>Bit position in AllKeywords ({0}) must equal the command argument named &quot;EtwSessionKeyword&quot; ({1}).</summary>
    public IMessageDescription SessionIdError { get => _sessioniderror!; set => this.AssertWritable()._sessioniderror = value; }
    /// <summary>An event with stop suffix must follow a corresponding event with a start suffix.</summary>
    public IMessageDescription StopsFollowStarts { get => _stopsfollowstarts!; set => this.AssertWritable()._stopsfollowstarts = value; }
    /// <summary>Too many arguments.</summary>
    public IMessageDescription TooManyArgs { get => _toomanyargs!; set => this.AssertWritable()._toomanyargs = value; }
    /// <summary>Too many fields in structure.</summary>
    public IMessageDescription TooManyFields { get => _toomanyfields!; set => this.AssertWritable()._toomanyfields = value; }
    /// <summary>Abstract event source must not declare event methods ({0} with ID {1}).</summary>
    public IMessageDescription AbstractMustNotDeclareEventMethods { get => _abstractmustnotdeclareeventmethods!; set => this.AssertWritable()._abstractmustnotdeclareeventmethods = value; }
    /// <summary>Abstract event source must not declare {0} nested type.</summary>
    public IMessageDescription AbstractMustNotDeclareKTOC { get => _abstractmustnotdeclarektoc!; set => this.AssertWritable()._abstractmustnotdeclarektoc = value; }
    /// <summary>Event attribute placed on method {0} which does not return &#39;void&#39;.</summary>
    public IMessageDescription AttributeOnNonVoid { get => _attributeonnonvoid!; set => this.AssertWritable()._attributeonnonvoid = value; }
    /// <summary>Channel {0} does not match event channel value {1}.</summary>
    public IMessageDescription ChannelTypeDoesNotMatchEventChannelValue { get => _channeltypedoesnotmatcheventchannelvalue!; set => this.AssertWritable()._channeltypedoesnotmatcheventchannelvalue = value; }
    /// <summary>Multiple definitions for string &quot;{0}&quot;.</summary>
    public IMessageDescription DuplicateStringKey { get => _duplicatestringkey!; set => this.AssertWritable()._duplicatestringkey = value; }
    /// <summary>The type of {0} is not expected in {1}.</summary>
    public IMessageDescription EnumKindMismatch { get => _enumkindmismatch!; set => this.AssertWritable()._enumkindmismatch = value; }
    /// <summary>The provider has already been registered with the operating system.</summary>
    public IMessageDescription EtwAlreadyRegistered { get => _etwalreadyregistered!; set => this.AssertWritable()._etwalreadyregistered = value; }
    /// <summary>Channel {0} has a value of {1} which is outside the legal range (16-254).</summary>
    public IMessageDescription EventChannelOutOfRange { get => _eventchanneloutofrange!; set => this.AssertWritable()._eventchanneloutofrange = value; }
    /// <summary>Event {0} has ID {1} which is already in use.</summary>
    public IMessageDescription EventIdReused { get => _eventidreused!; set => this.AssertWritable()._eventidreused = value; }
    /// <summary>Event {0} (with ID {1}) has a non-default opcode but not a task.</summary>
    public IMessageDescription EventMustHaveTaskIfNonDefaultOpcode { get => _eventmusthavetaskifnondefaultopcode!; set => this.AssertWritable()._eventmusthavetaskifnondefaultopcode = value; }
    /// <summary>Event method {0} (with ID {1}) is an explicit interface method implementation. Re-write method as implicit implementation.</summary>
    public IMessageDescription EventMustNotBeExplicitImplementation { get => _eventmustnotbeexplicitimplementation!; set => this.AssertWritable()._eventmustnotbeexplicitimplementation = value; }
    /// <summary>Event {0} was called with {1} argument(s) , but it is defined with {2} paramenter(s).</summary>
    public IMessageDescription EventParametersMismatch { get => _eventparametersmismatch!; set => this.AssertWritable()._eventparametersmismatch = value; }
    /// <summary>Event {0} specifies an Admin channel {1}. It must specify a Message property.</summary>
    public IMessageDescription EventWithAdminChannelMustHaveMessage { get => _eventwithadminchannelmusthavemessage!; set => this.AssertWritable()._eventwithadminchannelmusthavemessage = value; }
    /// <summary>Keyword {0} has a value of {1} which is outside the legal range (0-0x0000080000000000).</summary>
    public IMessageDescription IllegalKeywordsValue { get => _illegalkeywordsvalue!; set => this.AssertWritable()._illegalkeywordsvalue = value; }
    /// <summary>Opcode {0} has a value of {1} which is outside the legal range (11-238).</summary>
    public IMessageDescription IllegalOpcodeValue { get => _illegalopcodevalue!; set => this.AssertWritable()._illegalopcodevalue = value; }
    /// <summary>Task {0} has a value of {1} which is outside the legal range (1-65535).</summary>
    public IMessageDescription IllegalTaskValue { get => _illegaltaskvalue!; set => this.AssertWritable()._illegaltaskvalue = value; }
    /// <summary>Keywords {0} and {1} are defined with the same value ({2}).</summary>
    public IMessageDescription KeywordCollision { get => _keywordcollision!; set => this.AssertWritable()._keywordcollision = value; }
    /// <summary>Value {0} for keyword {1} needs to be a power of 2.</summary>
    public IMessageDescription KeywordNeedPowerOfTwo { get => _keywordneedpoweroftwo!; set => this.AssertWritable()._keywordneedpoweroftwo = value; }
    /// <summary>Attempt to define more than the maximum limit of 8 channels for a provider.</summary>
    public IMessageDescription MaxChannelExceeded { get => _maxchannelexceeded!; set => this.AssertWritable()._maxchannelexceeded = value; }
    /// <summary>Event {0} is givien event ID {1} but {2} was passed to WriteEvent.</summary>
    public IMessageDescription MismatchIdToWriteEvent { get => _mismatchidtowriteevent!; set => this.AssertWritable()._mismatchidtowriteevent = value; }
    /// <summary>Event IDs must be positive integers.</summary>
    public IMessageDescription NeedPositiveId { get => _needpositiveid!; set => this.AssertWritable()._needpositiveid = value; }
    /// <summary>Opcodes {0} and {1} are defined with the same value ({2}).</summary>
    public IMessageDescription OpcodeCollision { get => _opcodecollision!; set => this.AssertWritable()._opcodecollision = value; }
    /// <summary>The payload for a single event is too large.</summary>
    public IMessageDescription PayloadTooBig { get => _payloadtoobig!; set => this.AssertWritable()._payloadtoobig = value; }
    /// <summary>Period character (&#39;.&#39;) is illegal in an ETW provider name ({0}).</summary>
    public IMessageDescription PeriodIllegalInProviderName { get => _periodillegalinprovidername!; set => this.AssertWritable()._periodillegalinprovidername = value; }
    /// <summary>Keywords values larger than 0x0000100000000000 are reserved for system use</summary>
    public IMessageDescription ReservedKeywords { get => _reservedkeywords!; set => this.AssertWritable()._reservedkeywords = value; }
    /// <summary>Opcode values less than 11 are reserved for system use.</summary>
    public IMessageDescription ReservedOpcode { get => _reservedopcode!; set => this.AssertWritable()._reservedopcode = value; }
    /// <summary>Tasks {0} and {1} are defined with the same value ({2}).</summary>
    public IMessageDescription TaskCollision { get => _taskcollision!; set => this.AssertWritable()._taskcollision = value; }
    /// <summary>Event {0} (with ID {1}) has the same task/opcode pair as event {2} (with ID {3}).</summary>
    public IMessageDescription TaskOpcodePairReused { get => _taskopcodepairreused!; set => this.AssertWritable()._taskopcodepairreused = value; }
    /// <summary>EventSource({0}, {1})</summary>
    public new IMessageDescription ToString { get => _tostring!; set => this.AssertWritable()._tostring = value; }
    /// <summary>Event source types must be sealed or abstract.</summary>
    public IMessageDescription TypeMustBeSealedOrAbstract { get => _typemustbesealedorabstract!; set => this.AssertWritable()._typemustbesealedorabstract = value; }
    /// <summary>Event source types must derive from EventSource.</summary>
    public IMessageDescription TypeMustDeriveFromEventSource { get => _typemustderivefromeventsource!; set => this.AssertWritable()._typemustderivefromeventsource = value; }
    /// <summary>Use of undefined channel value {0} for event {1}.</summary>
    public IMessageDescription UndefinedChannel { get => _undefinedchannel!; set => this.AssertWritable()._undefinedchannel = value; }
    /// <summary>Use of undefined keyword value {0} for event {1}.</summary>
    public IMessageDescription UndefinedKeyword { get => _undefinedkeyword!; set => this.AssertWritable()._undefinedkeyword = value; }
    /// <summary>Use of undefined opcode value {0} for event {1}.</summary>
    public IMessageDescription UndefinedOpcode { get => _undefinedopcode!; set => this.AssertWritable()._undefinedopcode = value; }
    /// <summary>Unsupported type {0} in event source.</summary>
    public IMessageDescription UnsupportedEventTypeInManifest { get => _unsupportedeventtypeinmanifest!; set => this.AssertWritable()._unsupportedeventtypeinmanifest = value; }
    /// <summary>Event {0} specifies an illegal or unsupported formatting message (&quot;{1}&quot;).</summary>
    public IMessageDescription UnsupportedMessageProperty { get => _unsupportedmessageproperty!; set => this.AssertWritable()._unsupportedmessageproperty = value; }
    /// <summary>The parameters to the Event method do not match the parameters to the WriteEvent method. This may cause the event to be displayed incorrectly.</summary>
    public IMessageDescription VarArgsParameterMismatch { get => _varargsparametermismatch!; set => this.AssertWritable()._varargsparametermismatch = value; }

    /// <summary>Initialize fields</summary>
    public override EventSourceMessages Initialize() 
    {
        base.Initialize();
        Add(_addscalaroutofrange = new MessageDescription("mscorlib.EventSource_AddScalarOutOfRange", 0xA3450334, new ParameterlessText("Getting out of bounds during scalar addition.")).SetHResult(0x80131508).SetSeverity(MessageLevel.Error).SetException(typeof(System.IndexOutOfRangeException)));
        Add(_datadescriptorsoutofrange = new MessageDescription("mscorlib.EventSource_DataDescriptorsOutOfRange", 0xA3450335, new ParameterlessText("Data descriptors are out of range.")).SetHResult(0x80131508).SetSeverity(MessageLevel.Error).SetException(typeof(System.IndexOutOfRangeException)));
        Add(_eventnamedoesnotequaltaskplusopcode = new MessageDescription("mscorlib.EventSource_EventNameDoesNotEqualTaskPlusOpcode", 0xA3450336, new FormatText("Event {0} (with ID {1}) has a name that is not the concatenation of its task name and opcode.")).SetHResult(0x80131501).SetSeverity(MessageLevel.Error).SetException(typeof(System.ComponentModel.WarningException)));
        Add(_eventnamereused = new MessageDescription("mscorlib.EventSource_EventNameReused", 0xA3450337, new FormatText("Event name {0} used more than once.  If you wish to overload a method, the overloaded method should have a NonEvent attribute.")).SetHResult(0x80131501).SetSeverity(MessageLevel.Error).SetException(typeof(System.ComponentModel.WarningException)));
        Add(_eventsourceguidinuse = new MessageDescription("mscorlib.EventSource_EventSourceGuidInUse", 0xA3450338, new FormatText("An instance of EventSource with Guid {0} already exists.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_incorrentlyauthoredtypeinfo = new MessageDescription("mscorlib.EventSource_IncorrentlyAuthoredTypeInfo", 0xA3450339, new ParameterlessText("Incorrectly-authored TypeInfo - a type should be serialized as one field or as one group")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidcommand = new MessageDescription("mscorlib.EventSource_InvalidCommand", 0xA345033A, new ParameterlessText("Invalid command value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalideventformat = new MessageDescription("mscorlib.EventSource_InvalidEventFormat", 0xA345033B, new ParameterlessText("Can't specify both etw event format flags.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_listenercreatedinsidecallback = new MessageDescription("mscorlib.EventSource_ListenerCreatedInsideCallback", 0xA345033C, new ParameterlessText("Creating an EventListener inside a EventListener callback.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_listenernotfound = new MessageDescription("mscorlib.EventSource_ListenerNotFound", 0xA345033D, new ParameterlessText("Listener not found.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_listenerwritefailure = new MessageDescription("mscorlib.EventSource_ListenerWriteFailure", 0xA345033E, new ParameterlessText("An error occurred when writing to a listener.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetDescription("Microsoft.Diagnostics.Tracing").SetException(typeof(System.Diagnostics.Tracing.EventSourceException)));
        Add(_needguid = new MessageDescription("mscorlib.EventSource_NeedGuid", 0xA345033F, new ParameterlessText("The Guid of an EventSource must be non zero.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_needname = new MessageDescription("mscorlib.EventSource_NeedName", 0xA3450340, new ParameterlessText("The name of an EventSource must not be null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nofreebuffers = new MessageDescription("mscorlib.EventSource_NoFreeBuffers", 0xA3450341, new ParameterlessText("No Free Buffers available from the operating system (e.g. event rate too fast).")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.Diagnostics.Tracing.EventSourceException)));
        Add(_noncomplianttypeerror = new MessageDescription("mscorlib.EventSource_NonCompliantTypeError", 0xA3450342, new FormatText("The API supports only anonymous types or types decorated with the EventDataAttribute. Non-compliant type: {0} dataType.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_norelatedactivityid = new MessageDescription("mscorlib.EventSource_NoRelatedActivityId", 0xA3450343, new ParameterlessText("EventSource expects the first parameter of the Event method to be of type Guid and to be named \"relatedActivityId\" when calling WriteEventWithRelatedActivityId.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notsupportedarrayofbinary = new MessageDescription("mscorlib.EventSource_NotSupportedArrayOfBinary", 0xA3450344, new ParameterlessText("Arrays of Binary are not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notsupportedarrayofnil = new MessageDescription("mscorlib.EventSource_NotSupportedArrayOfNil", 0xA3450345, new ParameterlessText("Arrays of Nil are not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notsupportedarrayofnullterminatedstring = new MessageDescription("mscorlib.EventSource_NotSupportedArrayOfNullTerminatedString", 0xA3450346, new ParameterlessText("Arrays of null-terminated string are not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notsupportedcustomserializeddata = new MessageDescription("mscorlib.EventSource_NotSupportedCustomSerializedData", 0xA3450347, new ParameterlessText("Enumerables of custom-serialized data are not supported")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notsupportedenumtype = new MessageDescription("mscorlib.EventSource_NotSupportedEnumType", 0xA3450348, new FormatText("Enum type {0} underlying type {1} is not supported for serialization.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notsupportednestedarraysenums = new MessageDescription("mscorlib.EventSource_NotSupportedNestedArraysEnums", 0xA3450349, new ParameterlessText("Nested arrays/enumerables are not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_nullinput = new MessageDescription("mscorlib.EventSource_NullInput", 0xA345034A, new ParameterlessText("Null passed as a event argument.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.Diagnostics.Tracing.EventSourceException)));
        Add(_pinarrayoutofrange = new MessageDescription("mscorlib.EventSource_PinArrayOutOfRange", 0xA345034B, new ParameterlessText("Pins are out of range.")).SetHResult(0x80131508).SetSeverity(MessageLevel.Error).SetException(typeof(System.IndexOutOfRangeException)));
        Add(_recursivetypedefinition = new MessageDescription("mscorlib.EventSource_RecursiveTypeDefinition", 0xA345034C, new ParameterlessText("Recursive type definition is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_sessioniderror = new MessageDescription("mscorlib.EventSource_SessionIdError", 0xA345034D, new FormatText("Bit position in AllKeywords ({0}) must equal the command argument named \"EtwSessionKeyword\" ({1}).")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_stopsfollowstarts = new MessageDescription("mscorlib.EventSource_StopsFollowStarts", 0xA345034E, new ParameterlessText("An event with stop suffix must follow a corresponding event with a start suffix.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_toomanyargs = new MessageDescription("mscorlib.EventSource_TooManyArgs", 0xA345034F, new ParameterlessText("Too many arguments.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.Diagnostics.Tracing.EventSourceException)));
        Add(_toomanyfields = new MessageDescription("mscorlib.EventSource_TooManyFields", 0xA3450350, new ParameterlessText("Too many fields in structure.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_abstractmustnotdeclareeventmethods = new MessageDescription("mscorlib.EventSource_AbstractMustNotDeclareEventMethods", 0xA34506A9, new FormatText("Abstract event source must not declare event methods ({0} with ID {1}).")).SetSeverity(MessageLevel.Error));
        Add(_abstractmustnotdeclarektoc = new MessageDescription("mscorlib.EventSource_AbstractMustNotDeclareKTOC", 0xA34506A8, new FormatText("Abstract event source must not declare {0} nested type.")).SetSeverity(MessageLevel.Error));
        Add(_attributeonnonvoid = new MessageDescription("mscorlib.EventSource_AttributeOnNonVoid", 0xA345068A, new FormatText("Event attribute placed on method {0} which does not return 'void'.")).SetSeverity(MessageLevel.Error));
        Add(_channeltypedoesnotmatcheventchannelvalue = new MessageDescription("mscorlib.EventSource_ChannelTypeDoesNotMatchEventChannelValue", 0xA34506A3, new FormatText("Channel {0} does not match event channel value {1}.")).SetSeverity(MessageLevel.Error));
        Add(_duplicatestringkey = new MessageDescription("mscorlib.EventSource_DuplicateStringKey", 0xA34506A5, new FormatText("Multiple definitions for string \"{0}\".")).SetSeverity(MessageLevel.Error));
        Add(_enumkindmismatch = new MessageDescription("mscorlib.EventSource_EnumKindMismatch", 0xA345068F, new FormatText("The type of {0} is not expected in {1}.")).SetSeverity(MessageLevel.Error));
        Add(_etwalreadyregistered = new MessageDescription("mscorlib.EventSource_EtwAlreadyRegistered", 0xA3450696, new ParameterlessText("The provider has already been registered with the operating system.")).SetSeverity(MessageLevel.Error));
        Add(_eventchanneloutofrange = new MessageDescription("mscorlib.EventSource_EventChannelOutOfRange", 0xA34506A2, new FormatText("Channel {0} has a value of {1} which is outside the legal range (16-254).")).SetSeverity(MessageLevel.Error));
        Add(_eventidreused = new MessageDescription("mscorlib.EventSource_EventIdReused", 0xA3450691, new FormatText("Event {0} has ID {1} which is already in use.")).SetSeverity(MessageLevel.Error));
        Add(_eventmusthavetaskifnondefaultopcode = new MessageDescription("mscorlib.EventSource_EventMustHaveTaskIfNonDefaultOpcode", 0xA345069A, new FormatText("Event {0} (with ID {1}) has a non-default opcode but not a task.")).SetSeverity(MessageLevel.Error));
        Add(_eventmustnotbeexplicitimplementation = new MessageDescription("mscorlib.EventSource_EventMustNotBeExplicitImplementation", 0xA34506AA, new FormatText("Event method {0} (with ID {1}) is an explicit interface method implementation. Re-write method as implicit implementation.")).SetSeverity(MessageLevel.Error));
        Add(_eventparametersmismatch = new MessageDescription("mscorlib.EventSource_EventParametersMismatch", 0xA34506AB, new FormatText("Event {0} was called with {1} argument(s) , but it is defined with {2} paramenter(s).")).SetSeverity(MessageLevel.Error));
        Add(_eventwithadminchannelmusthavemessage = new MessageDescription("mscorlib.EventSource_EventWithAdminChannelMustHaveMessage", 0xA34506A6, new FormatText("Event {0} specifies an Admin channel {1}. It must specify a Message property.")).SetSeverity(MessageLevel.Error));
        Add(_illegalkeywordsvalue = new MessageDescription("mscorlib.EventSource_IllegalKeywordsValue", 0xA34506A0, new FormatText("Keyword {0} has a value of {1} which is outside the legal range (0-0x0000080000000000).")).SetSeverity(MessageLevel.Error));
        Add(_illegalopcodevalue = new MessageDescription("mscorlib.EventSource_IllegalOpcodeValue", 0xA345069C, new FormatText("Opcode {0} has a value of {1} which is outside the legal range (11-238).")).SetSeverity(MessageLevel.Error));
        Add(_illegaltaskvalue = new MessageDescription("mscorlib.EventSource_IllegalTaskValue", 0xA345069E, new FormatText("Task {0} has a value of {1} which is outside the legal range (1-65535).")).SetSeverity(MessageLevel.Error));
        Add(_keywordcollision = new MessageDescription("mscorlib.EventSource_KeywordCollision", 0xA34506A1, new FormatText("Keywords {0} and {1} are defined with the same value ({2}).")).SetSeverity(MessageLevel.Error));
        Add(_keywordneedpoweroftwo = new MessageDescription("mscorlib.EventSource_KeywordNeedPowerOfTwo", 0xA3450687, new FormatText("Value {0} for keyword {1} needs to be a power of 2.")).SetSeverity(MessageLevel.Error));
        Add(_maxchannelexceeded = new MessageDescription("mscorlib.EventSource_MaxChannelExceeded", 0xA34506A4, new ParameterlessText("Attempt to define more than the maximum limit of 8 channels for a provider.")).SetSeverity(MessageLevel.Error));
        Add(_mismatchidtowriteevent = new MessageDescription("mscorlib.EventSource_MismatchIdToWriteEvent", 0xA3450690, new FormatText("Event {0} is givien event ID {1} but {2} was passed to WriteEvent.")).SetSeverity(MessageLevel.Error));
        Add(_needpositiveid = new MessageDescription("mscorlib.EventSource_NeedPositiveId", 0xA345068B, new ParameterlessText("Event IDs must be positive integers.")).SetSeverity(MessageLevel.Error));
        Add(_opcodecollision = new MessageDescription("mscorlib.EventSource_OpcodeCollision", 0xA345069D, new FormatText("Opcodes {0} and {1} are defined with the same value ({2}).")).SetSeverity(MessageLevel.Error));
        Add(_payloadtoobig = new MessageDescription("mscorlib.EventSource_PayloadTooBig", 0xA345068E, new ParameterlessText("The payload for a single event is too large.")).SetSeverity(MessageLevel.Error));
        Add(_periodillegalinprovidername = new MessageDescription("mscorlib.EventSource_PeriodIllegalInProviderName", 0xA345069B, new FormatText("Period character ('.') is illegal in an ETW provider name ({0}).")).SetSeverity(MessageLevel.Error));
        Add(_reservedkeywords = new MessageDescription("mscorlib.EventSource_ReservedKeywords", 0xA345068D, new ParameterlessText("Keywords values larger than 0x0000100000000000 are reserved for system use")).SetSeverity(MessageLevel.Error));
        Add(_reservedopcode = new MessageDescription("mscorlib.EventSource_ReservedOpcode", 0xA345068C, new ParameterlessText("Opcode values less than 11 are reserved for system use.")).SetSeverity(MessageLevel.Error));
        Add(_taskcollision = new MessageDescription("mscorlib.EventSource_TaskCollision", 0xA345069F, new FormatText("Tasks {0} and {1} are defined with the same value ({2}).")).SetSeverity(MessageLevel.Error));
        Add(_taskopcodepairreused = new MessageDescription("mscorlib.EventSource_TaskOpcodePairReused", 0xA3450699, new FormatText("Event {0} (with ID {1}) has the same task/opcode pair as event {2} (with ID {3}).")).SetSeverity(MessageLevel.Error));
        Add(_tostring = new MessageDescription("mscorlib.EventSource_ToString", 0xA3450686, new FormatText("EventSource({0}, {1})")).SetSeverity(MessageLevel.Error));
        Add(_typemustbesealedorabstract = new MessageDescription("mscorlib.EventSource_TypeMustBeSealedOrAbstract", 0xA3450698, new ParameterlessText("Event source types must be sealed or abstract.")).SetSeverity(MessageLevel.Error));
        Add(_typemustderivefromeventsource = new MessageDescription("mscorlib.EventSource_TypeMustDeriveFromEventSource", 0xA3450697, new ParameterlessText("Event source types must derive from EventSource.")).SetSeverity(MessageLevel.Error));
        Add(_undefinedchannel = new MessageDescription("mscorlib.EventSource_UndefinedChannel", 0xA3450692, new FormatText("Use of undefined channel value {0} for event {1}.")).SetSeverity(MessageLevel.Error));
        Add(_undefinedkeyword = new MessageDescription("mscorlib.EventSource_UndefinedKeyword", 0xA3450688, new FormatText("Use of undefined keyword value {0} for event {1}.")).SetSeverity(MessageLevel.Error));
        Add(_undefinedopcode = new MessageDescription("mscorlib.EventSource_UndefinedOpcode", 0xA3450693, new FormatText("Use of undefined opcode value {0} for event {1}.")).SetSeverity(MessageLevel.Error));
        Add(_unsupportedeventtypeinmanifest = new MessageDescription("mscorlib.EventSource_UnsupportedEventTypeInManifest", 0xA3450689, new FormatText("Unsupported type {0} in event source.")).SetSeverity(MessageLevel.Error));
        Add(_unsupportedmessageproperty = new MessageDescription("mscorlib.EventSource_UnsupportedMessageProperty", 0xA34506A7, new FormatText("Event {0} specifies an illegal or unsupported formatting message (\"{1}\").")).SetSeverity(MessageLevel.Error));
        Add(_varargsparametermismatch = new MessageDescription("mscorlib.EventSource_VarArgsParameterMismatch", 0xA34506AC, new ParameterlessText("The parameters to the Event method do not match the parameters to the WriteEvent method. This may cause the event to be displayed incorrectly.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
