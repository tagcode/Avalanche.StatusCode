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

/// <summary>System.Runtime.Serialization.*</summary>
public class SerializationMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<SerializationMessages> instance = new Lazy<SerializationMessages>(() => new SerializationMessages().Initialize().SetAllReadOnly<SerializationMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static SerializationMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0068;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _serializationexception, _invalidserializedstring, _notserializable, _objectid, _arraytype, _arraytypeobject, _assembly, _assemblyid, _assemblynotfound, _badparameterinfo;
    IMessageDescription? _binaryheader, _constructornotfound, _corruptedstream, _corruptfield, _crossappdomainerror, _datetimeticksoutofrange, _duplicateselector, _headerreflection, _idtoosmall, _incorrectnumberoffixups;
    IMessageDescription? _insufficientdeserializationstate, _insufficientstate, _invaliddata, _invaliddelegatetype, _invalidescapesequence, _invalidfieldstate, _invalidfixupdiscovered, _invalidfixuptype, _invalidformat, _invalidondeser;
    IMessageDescription? _invalidptrvalue, _invalidtype, _iorincomplete, _iserializablememberinfo, _iserializabletypes, _keyvaluedifferentsizes, _map, _mbrasmbv, _memberinfo, _memberoutofrange;
    IMessageDescription? _membertypenotrecognized, _method, _missfield, _missingdatetimedata, _missingkeys, _missingmember, _missingobject, _missingvalues, _neverseen, _noid;
    IMessageDescription? _nomemberinfo, _nonsertype, _noparameterinfo, _notcyclicallyreferenceablesurrogate, _notfound, _notiser, _nullkey, _nullsignature, _objectnotsupplied, _objecttypeenum;
    IMessageDescription? _objnoid, _optionalfieldversionvalue, _parentchildidentical, _parseerror, _partialvaluetypefixup, _registertwice, _requirefulltrust, _samenametwice, _security, _sermemberinfo;
    IMessageDescription? _stream, _streamend, _stringbuildercapacity, _stringbuildermaxcapacity, _surrogatecycle, _surrogatecycleinargument, _toomanyelements, _toomanyreferences, _topobject, _topobjectinstantiate;
    IMessageDescription? _typecode, _typeexpected, _typeloadfailure, _typemissing, _typeread, _typeresolved, _typesecurity, _typewrite, _unabletofindmodule, _unabletofixup;
    IMessageDescription? _unknownmember, _unknownmemberinfo, _valuetypefixup, _xmlelement, _arrayinvalidlength, _arraynolength, _cannotgettype, _invalidid, _malformedarray, _missingkeyvaluepairs;
    IMessageDescription? _multiplemembers, _nobasetype, _notype, _objectusedbeforedesercallback;
    
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription SerializationException { get => _serializationexception!; set => this.AssertWritable()._serializationexception = value; }
    /// <summary>The specified serialized string &#39;{0}&#39; is not supported.</summary>
    public IMessageDescription InvalidSerializedString { get => _invalidserializedstring!; set => this.AssertWritable()._invalidserializedstring = value; }
    /// <summary>Argument passed in is not serializable.</summary>
    public IMessageDescription NotSerializable { get => _notserializable!; set => this.AssertWritable()._notserializable = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription ObjectID { get => _objectid!; set => this.AssertWritable()._objectid = value; }
    /// <summary>Invalid array type &#39;{0}&#39;.</summary>
    public IMessageDescription ArrayType { get => _arraytype!; set => this.AssertWritable()._arraytype = value; }
    /// <summary>Array element type is Object, &#39;dt&#39; attribute is null.</summary>
    public IMessageDescription ArrayTypeObject { get => _arraytypeobject!; set => this.AssertWritable()._arraytypeobject = value; }
    /// <summary>No assembly information is available for object on the wire, &#39;{0}&#39;.</summary>
    public IMessageDescription Assembly { get => _assembly!; set => this.AssertWritable()._assembly = value; }
    /// <summary>No assembly ID for object type &#39;{0}&#39;.</summary>
    public IMessageDescription AssemblyId { get => _assemblyid!; set => this.AssertWritable()._assemblyid = value; }
    /// <summary>Unable to find assembly &#39;{0}&#39;.</summary>
    public IMessageDescription AssemblyNotFound { get => _assemblynotfound!; set => this.AssertWritable()._assemblynotfound = value; }
    /// <summary>Non existent ParameterInfo. Position bigger than member&#39;s parameters length.</summary>
    public IMessageDescription BadParameterInfo { get => _badparameterinfo!; set => this.AssertWritable()._badparameterinfo = value; }
    /// <summary>Binary stream &#39;{0}&#39; does not contain a valid BinaryHeader. Possible causes are invalid stream or object version change between serialization and deserialization.</summary>
    public IMessageDescription BinaryHeader { get => _binaryheader!; set => this.AssertWritable()._binaryheader = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription ConstructorNotFound { get => _constructornotfound!; set => this.AssertWritable()._constructornotfound = value; }
    /// <summary>Invalid BinaryFormatter stream.</summary>
    public IMessageDescription CorruptedStream { get => _corruptedstream!; set => this.AssertWritable()._corruptedstream = value; }
    /// <summary>The value of the field &#39;{0}&#39; is invalid. The serialized data is corrupt.</summary>
    public IMessageDescription CorruptField { get => _corruptfield!; set => this.AssertWritable()._corruptfield = value; }
    /// <summary>Cross-AppDomain BinaryFormatter error; expected &#39;{0}&#39; but received &#39;{1}&#39;.</summary>
    public IMessageDescription CrossAppDomainError { get => _crossappdomainerror!; set => this.AssertWritable()._crossappdomainerror = value; }
    /// <summary>Invalid serialized DateTime data. Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</summary>
    public IMessageDescription DateTimeTicksOutOfRange { get => _datetimeticksoutofrange!; set => this.AssertWritable()._datetimeticksoutofrange = value; }
    /// <summary>Selector is already on the list of checked selectors.</summary>
    public IMessageDescription DuplicateSelector { get => _duplicateselector!; set => this.AssertWritable()._duplicateselector = value; }
    /// <summary>Header reflection error: number of value members: {0}.</summary>
    public IMessageDescription HeaderReflection { get => _headerreflection!; set => this.AssertWritable()._headerreflection = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription IdTooSmall { get => _idtoosmall!; set => this.AssertWritable()._idtoosmall = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription IncorrectNumberOfFixups { get => _incorrectnumberoffixups!; set => this.AssertWritable()._incorrectnumberoffixups = value; }
    /// <summary>Insufficient state to deserialize the object. Missing field &#39;{0}&#39;. More information is needed.</summary>
    public IMessageDescription InsufficientDeserializationState { get => _insufficientdeserializationstate!; set => this.AssertWritable()._insufficientdeserializationstate = value; }
    /// <summary>System</summary>
    public IMessageDescription InsufficientState { get => _insufficientstate!; set => this.AssertWritable()._insufficientstate = value; }
    /// <summary>An error occurred while deserializing the object. The serialized data is corrupt.</summary>
    public IMessageDescription InvalidData { get => _invaliddata!; set => this.AssertWritable()._invaliddata = value; }
    /// <summary>Cannot serialize delegates over unmanaged function pointers, dynamic methods or methods outside the delegate creator&#39;s assembly.</summary>
    public IMessageDescription InvalidDelegateType { get => _invaliddelegatetype!; set => this.AssertWritable()._invaliddelegatetype = value; }
    /// <summary>The serialized data contained an invalid escape sequence &#39;\{0}&#39;.</summary>
    public IMessageDescription InvalidEscapeSequence { get => _invalidescapesequence!; set => this.AssertWritable()._invalidescapesequence = value; }
    /// <summary>Object fields may not be properly initialized.</summary>
    public IMessageDescription InvalidFieldState { get => _invalidfieldstate!; set => this.AssertWritable()._invalidfieldstate = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription InvalidFixupDiscovered { get => _invalidfixupdiscovered!; set => this.AssertWritable()._invalidfixupdiscovered = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription InvalidFixupType { get => _invalidfixuptype!; set => this.AssertWritable()._invalidfixuptype = value; }
    /// <summary>The input stream is not a valid binary format. The starting contents (in bytes) are: {0} ...</summary>
    public IMessageDescription InvalidFormat { get => _invalidformat!; set => this.AssertWritable()._invalidformat = value; }
    /// <summary>OnDeserialization method was called while the object was not being deserialized.</summary>
    public IMessageDescription InvalidOnDeser { get => _invalidondeser!; set => this.AssertWritable()._invalidondeser = value; }
    /// <summary>An IntPtr or UIntPtr with an eight byte value cannot be deserialized on a machine with a four byte word size.</summary>
    public IMessageDescription InvalidPtrValue { get => _invalidptrvalue!; set => this.AssertWritable()._invalidptrvalue = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription InvalidType { get => _invalidtype!; set => this.AssertWritable()._invalidtype = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription IORIncomplete { get => _iorincomplete!; set => this.AssertWritable()._iorincomplete = value; }
    /// <summary>MemberInfo requested for ISerializable type.</summary>
    public IMessageDescription ISerializableMemberInfo { get => _iserializablememberinfo!; set => this.AssertWritable()._iserializablememberinfo = value; }
    /// <summary>Types not available for ISerializable object &#39;{0}&#39;.</summary>
    public IMessageDescription ISerializableTypes { get => _iserializabletypes!; set => this.AssertWritable()._iserializabletypes = value; }
    /// <summary>The keys and values arrays have different sizes.</summary>
    public IMessageDescription KeyValueDifferentSizes { get => _keyvaluedifferentsizes!; set => this.AssertWritable()._keyvaluedifferentsizes = value; }
    /// <summary>No map for object &#39;{0}&#39;.</summary>
    public IMessageDescription Map { get => _map!; set => this.AssertWritable()._map = value; }
    /// <summary>Type {0} must be marshaled by reference in this context.</summary>
    public IMessageDescription MBRAsMBV { get => _mbrasmbv!; set => this.AssertWritable()._mbrasmbv = value; }
    /// <summary>MemberInfo cannot be obtained for ISerialized Object &#39;{0}&#39;.</summary>
    public IMessageDescription MemberInfo { get => _memberinfo!; set => this.AssertWritable()._memberinfo = value; }
    /// <summary>The deserialized value of the member &quot;{0}&quot; in the class &quot;{1}&quot; is out of range.</summary>
    public IMessageDescription MemberOutOfRange { get => _memberoutofrange!; set => this.AssertWritable()._memberoutofrange = value; }
    /// <summary>Unknown member type.</summary>
    public IMessageDescription MemberTypeNotRecognized { get => _membertypenotrecognized!; set => this.AssertWritable()._membertypenotrecognized = value; }
    /// <summary>Invalid MethodCall or MethodReturn stream format.</summary>
    public IMessageDescription Method { get => _method!; set => this.AssertWritable()._method = value; }
    /// <summary>Field {0} is missing.</summary>
    public IMessageDescription MissField { get => _missfield!; set => this.AssertWritable()._missfield = value; }
    /// <summary>Invalid serialized DateTime data. Unable to find &#39;ticks&#39; or &#39;dateData&#39;.</summary>
    public IMessageDescription MissingDateTimeData { get => _missingdatetimedata!; set => this.AssertWritable()._missingdatetimedata = value; }
    /// <summary>The Keys for this Hashtable are missing.</summary>
    public IMessageDescription MissingKeys { get => _missingkeys!; set => this.AssertWritable()._missingkeys = value; }
    /// <summary>Member &#39;{0}&#39; in class &#39;{1}&#39; is not present in the serialized stream and is not marked with {2}.</summary>
    public IMessageDescription MissingMember { get => _missingmember!; set => this.AssertWritable()._missingmember = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription MissingObject { get => _missingobject!; set => this.AssertWritable()._missingobject = value; }
    /// <summary>The values for this dictionary are missing.</summary>
    public IMessageDescription MissingValues { get => _missingvalues!; set => this.AssertWritable()._missingvalues = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription NeverSeen { get => _neverseen!; set => this.AssertWritable()._neverseen = value; }
    /// <summary>Object has never been assigned an objectID.</summary>
    public IMessageDescription NoID { get => _noid!; set => this.AssertWritable()._noid = value; }
    /// <summary>No MemberInfo for Object {0}.</summary>
    public IMessageDescription NoMemberInfo { get => _nomemberinfo!; set => this.AssertWritable()._nomemberinfo = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription NonSerType { get => _nonsertype!; set => this.AssertWritable()._nonsertype = value; }
    /// <summary>Serialized member does not have a ParameterInfo.</summary>
    public IMessageDescription NoParameterInfo { get => _noparameterinfo!; set => this.AssertWritable()._noparameterinfo = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription NotCyclicallyReferenceableSurrogate { get => _notcyclicallyreferenceablesurrogate!; set => this.AssertWritable()._notcyclicallyreferenceablesurrogate = value; }
    /// <summary>Member &#39;{0}&#39; was not found.</summary>
    public IMessageDescription NotFound { get => _notfound!; set => this.AssertWritable()._notfound = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription NotISer { get => _notiser!; set => this.AssertWritable()._notiser = value; }
    /// <summary>One of the serialized keys is null.</summary>
    public IMessageDescription NullKey { get => _nullkey!; set => this.AssertWritable()._nullkey = value; }
    /// <summary>The method signature cannot be null.</summary>
    public IMessageDescription NullSignature { get => _nullsignature!; set => this.AssertWritable()._nullsignature = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription ObjectNotSupplied { get => _objectnotsupplied!; set => this.AssertWritable()._objectnotsupplied = value; }
    /// <summary>Invalid ObjectTypeEnum {0}.</summary>
    public IMessageDescription ObjectTypeEnum { get => _objecttypeenum!; set => this.AssertWritable()._objecttypeenum = value; }
    /// <summary>Object {0} has never been assigned an objectID.</summary>
    public IMessageDescription ObjNoID { get => _objnoid!; set => this.AssertWritable()._objnoid = value; }
    /// <summary>Version value must be positive.</summary>
    public IMessageDescription OptionalFieldVersionValue { get => _optionalfieldversionvalue!; set => this.AssertWritable()._optionalfieldversionvalue = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription ParentChildIdentical { get => _parentchildidentical!; set => this.AssertWritable()._parentchildidentical = value; }
    /// <summary>Parse error. Current element is not compatible with the next element, {0}.</summary>
    public IMessageDescription ParseError { get => _parseerror!; set => this.AssertWritable()._parseerror = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription PartialValueTypeFixup { get => _partialvaluetypefixup!; set => this.AssertWritable()._partialvaluetypefixup = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription RegisterTwice { get => _registertwice!; set => this.AssertWritable()._registertwice = value; }
    /// <summary>A type &#39;{0}&#39; that is defined in a partially trusted assembly cannot be type forwarded from an assembly with a different Public Key Token or without a public key token. To fix this, please either turn on unsafeTypeForwarding flag in the configuration file or remove the TypeForwardedFrom attribute.</summary>
    public IMessageDescription RequireFullTrust { get => _requirefulltrust!; set => this.AssertWritable()._requirefulltrust = value; }
    /// <summary>Cannot add the same member twice to a SerializationInfo object.</summary>
    public IMessageDescription SameNameTwice { get => _samenametwice!; set => this.AssertWritable()._samenametwice = value; }
    /// <summary>Because of security restrictions, the type {0} cannot be accessed.</summary>
    public IMessageDescription Security { get => _security!; set => this.AssertWritable()._security = value; }
    /// <summary>MemberInfo type {0} cannot be serialized.</summary>
    public IMessageDescription SerMemberInfo { get => _sermemberinfo!; set => this.AssertWritable()._sermemberinfo = value; }
    /// <summary>Attempting to deserialize an empty stream.</summary>
    public IMessageDescription Stream { get => _stream!; set => this.AssertWritable()._stream = value; }
    /// <summary>End of Stream encountered before parsing was completed.</summary>
    public IMessageDescription StreamEnd { get => _streamend!; set => this.AssertWritable()._streamend = value; }
    /// <summary>The serialized Capacity property of StringBuilder must be positive, less than or equal to MaxCapacity and greater than or equal to the String length.</summary>
    public IMessageDescription StringBuilderCapacity { get => _stringbuildercapacity!; set => this.AssertWritable()._stringbuildercapacity = value; }
    /// <summary>The serialized MaxCapacity property of StringBuilder must be positive and greater than or equal to the String length.</summary>
    public IMessageDescription StringBuilderMaxCapacity { get => _stringbuildermaxcapacity!; set => this.AssertWritable()._stringbuildermaxcapacity = value; }
    /// <summary>Adding selector will introduce a cycle.</summary>
    public IMessageDescription SurrogateCycle { get => _surrogatecycle!; set => this.AssertWritable()._surrogatecycle = value; }
    /// <summary>Selector contained a cycle.</summary>
    public IMessageDescription SurrogateCycleInArgument { get => _surrogatecycleinargument!; set => this.AssertWritable()._surrogatecycleinargument = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription TooManyElements { get => _toomanyelements!; set => this.AssertWritable()._toomanyelements = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription TooManyReferences { get => _toomanyreferences!; set => this.AssertWritable()._toomanyreferences = value; }
    /// <summary>No top object.</summary>
    public IMessageDescription TopObject { get => _topobject!; set => this.AssertWritable()._topobject = value; }
    /// <summary>Top object cannot be instantiated for element &#39;{0}&#39;.</summary>
    public IMessageDescription TopObjectInstantiate { get => _topobjectinstantiate!; set => this.AssertWritable()._topobjectinstantiate = value; }
    /// <summary>Invalid type code in stream &#39;{0}&#39;.</summary>
    public IMessageDescription TypeCode { get => _typecode!; set => this.AssertWritable()._typecode = value; }
    /// <summary>Invalid expected type.</summary>
    public IMessageDescription TypeExpected { get => _typeexpected!; set => this.AssertWritable()._typeexpected = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription TypeLoadFailure { get => _typeloadfailure!; set => this.AssertWritable()._typeloadfailure = value; }
    /// <summary>Type is missing for member of type Object &#39;{0}&#39;.</summary>
    public IMessageDescription TypeMissing { get => _typemissing!; set => this.AssertWritable()._typemissing = value; }
    /// <summary>Invalid read type request &#39;{0}&#39;.</summary>
    public IMessageDescription TypeRead { get => _typeread!; set => this.AssertWritable()._typeread = value; }
    /// <summary>Type is not resolved for member &#39;{0}&#39;.</summary>
    public IMessageDescription TypeResolved { get => _typeresolved!; set => this.AssertWritable()._typeresolved = value; }
    /// <summary>Type {0} and the types derived from it (such as {1}) are not permitted to be deserialized at this security level.</summary>
    public IMessageDescription TypeSecurity { get => _typesecurity!; set => this.AssertWritable()._typesecurity = value; }
    /// <summary>Invalid write type request &#39;{0}&#39;.</summary>
    public IMessageDescription TypeWrite { get => _typewrite!; set => this.AssertWritable()._typewrite = value; }
    /// <summary>The given module {0} cannot be found within the assembly {1}.</summary>
    public IMessageDescription UnableToFindModule { get => _unabletofindmodule!; set => this.AssertWritable()._unabletofindmodule = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription UnableToFixup { get => _unabletofixup!; set => this.AssertWritable()._unabletofixup = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription UnknownMember { get => _unknownmember!; set => this.AssertWritable()._unknownmember = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription UnknownMemberInfo { get => _unknownmemberinfo!; set => this.AssertWritable()._unknownmemberinfo = value; }
    /// <summary>System.Runtime.Serialization</summary>
    public IMessageDescription ValueTypeFixup { get => _valuetypefixup!; set => this.AssertWritable()._valuetypefixup = value; }
    /// <summary>Invalid element &#39;{0}&#39;.</summary>
    public IMessageDescription XMLElement { get => _xmlelement!; set => this.AssertWritable()._xmlelement = value; }
    /// <summary>Array specifies an invalid length.</summary>
    public IMessageDescription ArrayInvalidLength { get => _arrayinvalidlength!; set => this.AssertWritable()._arrayinvalidlength = value; }
    /// <summary>Array does not specify a length.</summary>
    public IMessageDescription ArrayNoLength { get => _arraynolength!; set => this.AssertWritable()._arraynolength = value; }
    /// <summary>Cannot get the type &#39;{0}&#39;.</summary>
    public IMessageDescription CannotGetType { get => _cannotgettype!; set => this.AssertWritable()._cannotgettype = value; }
    /// <summary>Object specifies an invalid ID.</summary>
    public IMessageDescription InvalidID { get => _invalidid!; set => this.AssertWritable()._invalidid = value; }
    /// <summary>The array information in the stream is invalid.</summary>
    public IMessageDescription MalformedArray { get => _malformedarray!; set => this.AssertWritable()._malformedarray = value; }
    /// <summary>The KeyValuePairs for this Dictionary are missing.</summary>
    public IMessageDescription MissingKeyValuePairs { get => _missingkeyvaluepairs!; set => this.AssertWritable()._missingkeyvaluepairs = value; }
    /// <summary>Cannot resolve multiple members with the same name.</summary>
    public IMessageDescription MultipleMembers { get => _multiplemembers!; set => this.AssertWritable()._multiplemembers = value; }
    /// <summary>Object does not specify a base type.</summary>
    public IMessageDescription NoBaseType { get => _nobasetype!; set => this.AssertWritable()._nobasetype = value; }
    /// <summary>Object does not specify a type.</summary>
    public IMessageDescription NoType { get => _notype!; set => this.AssertWritable()._notype = value; }
    /// <summary>An object was used before its deserialization callback ran, which may break higher-level consistency guarantees in the application.</summary>
    public IMessageDescription ObjectUsedBeforeDeserCallback { get => _objectusedbeforedesercallback!; set => this.AssertWritable()._objectusedbeforedesercallback = value; }

    /// <summary>Initialize fields</summary>
    public override SerializationMessages Initialize() 
    {
        base.Initialize();
        Add(_serializationexception = new MessageDescription("mscorlib.Arg_SerializationException", 0xA34500F4, new ParameterlessText("Serialization error.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.ArgumentException)));
        Add(_invalidserializedstring = new MessageDescription("mscorlib.Argument_InvalidSerializedString", 0xA34501C4, new FormatText("The specified serialized string '{0}' is not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notserializable = new MessageDescription("mscorlib.Argument_NotSerializable", 0xA3450209, new ParameterlessText("Argument passed in is not serializable.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_objectid = new MessageDescription("mscorlib.ArgumentOutOfRange_ObjectID", 0xA34502BD, new ParameterlessText("objectID cannot be less than or equal to zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_arraytype = new MessageDescription("mscorlib.Serialization_ArrayType", 0xA3450571, new FormatText("Invalid array type '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_arraytypeobject = new MessageDescription("mscorlib.Serialization_ArrayTypeObject", 0xA3450572, new ParameterlessText("Array element type is Object, 'dt' attribute is null.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_assembly = new MessageDescription("mscorlib.Serialization_Assembly", 0xA3450573, new FormatText("No assembly information is available for object on the wire, '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_assemblyid = new MessageDescription("mscorlib.Serialization_AssemblyId", 0xA3450574, new FormatText("No assembly ID for object type '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_assemblynotfound = new MessageDescription("mscorlib.Serialization_AssemblyNotFound", 0xA3450575, new FormatText("Unable to find assembly '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_badparameterinfo = new MessageDescription("mscorlib.Serialization_BadParameterInfo", 0xA3450576, new ParameterlessText("Non existent ParameterInfo. Position bigger than member's parameters length.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_binaryheader = new MessageDescription("mscorlib.Serialization_BinaryHeader", 0xA3450577, new FormatText("Binary stream '{0}' does not contain a valid BinaryHeader. Possible causes are invalid stream or object version change between serialization and deserialization.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_constructornotfound = new MessageDescription("mscorlib.Serialization_ConstructorNotFound", 0xA3450578, new FormatText("The constructor to deserialize an object of type '{0}' was not found.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_corruptedstream = new MessageDescription("mscorlib.Serialization_CorruptedStream", 0xA3450579, new ParameterlessText("Invalid BinaryFormatter stream.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_corruptfield = new MessageDescription("mscorlib.Serialization_CorruptField", 0xA345057A, new FormatText("The value of the field '{0}' is invalid.  The serialized data is corrupt.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_crossappdomainerror = new MessageDescription("mscorlib.Serialization_CrossAppDomainError", 0xA345057B, new FormatText("Cross-AppDomain BinaryFormatter error; expected '{0}' but received '{1}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_datetimeticksoutofrange = new MessageDescription("mscorlib.Serialization_DateTimeTicksOutOfRange", 0xA345057C, new ParameterlessText("Invalid serialized DateTime data. Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_duplicateselector = new MessageDescription("mscorlib.Serialization_DuplicateSelector", 0xA345057D, new ParameterlessText("Selector is already on the list of checked selectors.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_headerreflection = new MessageDescription("mscorlib.Serialization_HeaderReflection", 0xA345057E, new FormatText("Header reflection error: number of value members: {0}.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_idtoosmall = new MessageDescription("mscorlib.Serialization_IdTooSmall", 0xA345057F, new ParameterlessText("Object IDs must be greater than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_incorrectnumberoffixups = new MessageDescription("mscorlib.Serialization_IncorrectNumberOfFixups", 0xA3450580, new ParameterlessText("The ObjectManager found an invalid number of fixups. This usually indicates a problem in the Formatter.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_insufficientdeserializationstate = new MessageDescription("mscorlib.Serialization_InsufficientDeserializationState", 0xA3450581, new FormatText("Insufficient state to deserialize the object. Missing field '{0}'. More information is needed.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_insufficientstate = new MessageDescription("mscorlib.Serialization_InsufficientState", 0xA3450582, new ParameterlessText("Insufficient state to return the real object.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invaliddata = new MessageDescription("mscorlib.Serialization_InvalidData", 0xA3450583, new ParameterlessText("An error occurred while deserializing the object.  The serialized data is corrupt.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invaliddelegatetype = new MessageDescription("mscorlib.Serialization_InvalidDelegateType", 0xA3450584, new ParameterlessText("Cannot serialize delegates over unmanaged function pointers, dynamic methods or methods outside the delegate creator's assembly.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidescapesequence = new MessageDescription("mscorlib.Serialization_InvalidEscapeSequence", 0xA3450585, new FormatText("The serialized data contained an invalid escape sequence '\\{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidfieldstate = new MessageDescription("mscorlib.Serialization_InvalidFieldState", 0xA3450586, new ParameterlessText("Object fields may not be properly initialized.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidfixupdiscovered = new MessageDescription("mscorlib.Serialization_InvalidFixupDiscovered", 0xA3450587, new ParameterlessText("A fixup on an object implementing ISerializable or having a surrogate was discovered for an object which does not have a SerializationInfo available.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidfixuptype = new MessageDescription("mscorlib.Serialization_InvalidFixupType", 0xA3450588, new ParameterlessText("A member fixup was registered for an object which implements ISerializable or has a surrogate. In this situation, a delayed fixup must be used.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidformat = new MessageDescription("mscorlib.Serialization_InvalidFormat", 0xA3450589, new FormatText("The input stream is not a valid binary format. The starting contents (in bytes) are: {0} ...")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidondeser = new MessageDescription("mscorlib.Serialization_InvalidOnDeser", 0xA345058A, new ParameterlessText("OnDeserialization method was called while the object was not being deserialized.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidptrvalue = new MessageDescription("mscorlib.Serialization_InvalidPtrValue", 0xA345058B, new ParameterlessText("An IntPtr or UIntPtr with an eight byte value cannot be deserialized on a machine with a four byte word size.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtype = new MessageDescription("mscorlib.Serialization_InvalidType", 0xA345058C, new FormatText("Only system-provided types can be passed to the GetUninitializedObject method. '{0}' is not a valid instance of a type.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_iorincomplete = new MessageDescription("mscorlib.Serialization_IORIncomplete", 0xA345058D, new FormatText("The object with ID {0} implements the IObjectReference interface for which all dependencies cannot be resolved. The likely cause is two instances of IObjectReference that have a mutual dependency on each other.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_iserializablememberinfo = new MessageDescription("mscorlib.Serialization_ISerializableMemberInfo", 0xA345058E, new ParameterlessText("MemberInfo requested for ISerializable type.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_iserializabletypes = new MessageDescription("mscorlib.Serialization_ISerializableTypes", 0xA345058F, new FormatText("Types not available for ISerializable object '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_keyvaluedifferentsizes = new MessageDescription("mscorlib.Serialization_KeyValueDifferentSizes", 0xA3450590, new ParameterlessText("The keys and values arrays have different sizes.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_map = new MessageDescription("mscorlib.Serialization_Map", 0xA3450591, new FormatText("No map for object '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_mbrasmbv = new MessageDescription("mscorlib.Serialization_MBRAsMBV", 0xA3450592, new FormatText("Type {0} must be marshaled by reference in this context.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_memberinfo = new MessageDescription("mscorlib.Serialization_MemberInfo", 0xA3450593, new FormatText("MemberInfo cannot be obtained for ISerialized Object '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_memberoutofrange = new MessageDescription("mscorlib.Serialization_MemberOutOfRange", 0xA3450594, new FormatText("The deserialized value of the member \"{0}\" in the class \"{1}\" is out of range.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_membertypenotrecognized = new MessageDescription("mscorlib.Serialization_MemberTypeNotRecognized", 0xA3450595, new ParameterlessText("Unknown member type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_method = new MessageDescription("mscorlib.Serialization_Method", 0xA3450596, new ParameterlessText("Invalid MethodCall or MethodReturn stream format.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missfield = new MessageDescription("mscorlib.Serialization_MissField", 0xA3450597, new FormatText("Field {0} is missing.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missingdatetimedata = new MessageDescription("mscorlib.Serialization_MissingDateTimeData", 0xA3450598, new ParameterlessText("Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missingkeys = new MessageDescription("mscorlib.Serialization_MissingKeys", 0xA3450599, new ParameterlessText("The Keys for this Hashtable are missing.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missingmember = new MessageDescription("mscorlib.Serialization_MissingMember", 0xA345059A, new FormatText("Member '{0}' in class '{1}' is not present in the serialized stream and is not marked with {2}.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missingobject = new MessageDescription("mscorlib.Serialization_MissingObject", 0xA345059B, new FormatText("The object with ID {0} was referenced in a fixup but has not been registered.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missingvalues = new MessageDescription("mscorlib.Serialization_MissingValues", 0xA345059C, new ParameterlessText("The values for this dictionary are missing.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_neverseen = new MessageDescription("mscorlib.Serialization_NeverSeen", 0xA345059D, new FormatText("A fixup is registered to the object with ID {0}, but the object does not appear in the graph.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_noid = new MessageDescription("mscorlib.Serialization_NoID", 0xA345059E, new ParameterlessText("Object has never been assigned an objectID.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_nomemberinfo = new MessageDescription("mscorlib.Serialization_NoMemberInfo", 0xA345059F, new FormatText("No MemberInfo for Object {0}.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_nonsertype = new MessageDescription("mscorlib.Serialization_NonSerType", 0xA34505A0, new FormatText("Type '{0}' in Assembly '{1}' is not marked as serializable.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_noparameterinfo = new MessageDescription("mscorlib.Serialization_NoParameterInfo", 0xA34505A1, new ParameterlessText("Serialized member does not have a ParameterInfo.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_notcyclicallyreferenceablesurrogate = new MessageDescription("mscorlib.Serialization_NotCyclicallyReferenceableSurrogate", 0xA34505A2, new FormatText("{0}.SetObjectData returns a value that is neither null nor equal to the first parameter. Such Surrogates cannot be part of cyclical reference.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_notfound = new MessageDescription("mscorlib.Serialization_NotFound", 0xA34505A3, new FormatText("Member '{0}' was not found.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_notiser = new MessageDescription("mscorlib.Serialization_NotISer", 0xA34505A4, new ParameterlessText("The given object does not implement the ISerializable interface.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.ArgumentException)));
        Add(_nullkey = new MessageDescription("mscorlib.Serialization_NullKey", 0xA34505A5, new ParameterlessText("One of the serialized keys is null.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_nullsignature = new MessageDescription("mscorlib.Serialization_NullSignature", 0xA34505A6, new ParameterlessText("The method signature cannot be null.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_objectnotsupplied = new MessageDescription("mscorlib.Serialization_ObjectNotSupplied", 0xA34505A7, new FormatText("The object with ID {0} was referenced in a fixup but does not exist.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_objecttypeenum = new MessageDescription("mscorlib.Serialization_ObjectTypeEnum", 0xA34505A8, new FormatText("Invalid ObjectTypeEnum {0}.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_objnoid = new MessageDescription("mscorlib.Serialization_ObjNoID", 0xA34505A9, new FormatText("Object {0} has never been assigned an objectID.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_optionalfieldversionvalue = new MessageDescription("mscorlib.Serialization_OptionalFieldVersionValue", 0xA34505AA, new ParameterlessText("Version value must be positive.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_parentchildidentical = new MessageDescription("mscorlib.Serialization_ParentChildIdentical", 0xA34505AB, new ParameterlessText("The ID of the containing object cannot be the same as the object ID.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_parseerror = new MessageDescription("mscorlib.Serialization_ParseError", 0xA34505AC, new FormatText("Parse error. Current element is not compatible with the next element, {0}.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_partialvaluetypefixup = new MessageDescription("mscorlib.Serialization_PartialValueTypeFixup", 0xA34505AD, new ParameterlessText("Fixing up a partially available ValueType chain is not implemented.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_registertwice = new MessageDescription("mscorlib.Serialization_RegisterTwice", 0xA34505AE, new ParameterlessText("An object cannot be registered twice.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_requirefulltrust = new MessageDescription("mscorlib.Serialization_RequireFullTrust", 0xA34505AF, new FormatText("A type '{0}' that is defined in a partially trusted assembly cannot be type forwarded from an assembly with a different Public Key Token or without a public key token. To fix this, please either turn on unsafeTypeForwarding flag in the configuration file or remove the TypeForwardedFrom attribute.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_samenametwice = new MessageDescription("mscorlib.Serialization_SameNameTwice", 0xA34505B0, new ParameterlessText("Cannot add the same member twice to a SerializationInfo object.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_security = new MessageDescription("mscorlib.Serialization_Security", 0xA34505B1, new FormatText("Because of security restrictions, the type {0} cannot be accessed.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_sermemberinfo = new MessageDescription("mscorlib.Serialization_SerMemberInfo", 0xA34505B2, new FormatText("MemberInfo type {0} cannot be serialized.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_stream = new MessageDescription("mscorlib.Serialization_Stream", 0xA34505B3, new ParameterlessText("Attempting to deserialize an empty stream.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_streamend = new MessageDescription("mscorlib.Serialization_StreamEnd", 0xA34505B4, new ParameterlessText("End of Stream encountered before parsing was completed.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_stringbuildercapacity = new MessageDescription("mscorlib.Serialization_StringBuilderCapacity", 0xA34505B5, new ParameterlessText("The serialized Capacity property of StringBuilder must be positive, less than or equal to MaxCapacity and greater than or equal to the String length.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_stringbuildermaxcapacity = new MessageDescription("mscorlib.Serialization_StringBuilderMaxCapacity", 0xA34505B6, new ParameterlessText("The serialized MaxCapacity property of StringBuilder must be positive and greater than or equal to the String length.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_surrogatecycle = new MessageDescription("mscorlib.Serialization_SurrogateCycle", 0xA34505B7, new ParameterlessText("Adding selector will introduce a cycle.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_surrogatecycleinargument = new MessageDescription("mscorlib.Serialization_SurrogateCycleInArgument", 0xA34505B8, new ParameterlessText("Selector contained a cycle.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_toomanyelements = new MessageDescription("mscorlib.Serialization_TooManyElements", 0xA34505B9, new ParameterlessText("The internal array cannot expand to greater than Int32.MaxValue elements.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_toomanyreferences = new MessageDescription("mscorlib.Serialization_TooManyReferences", 0xA34505BA, new ParameterlessText("The implementation of the IObjectReference interface returns too many nested references to other objects that implement IObjectReference.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_topobject = new MessageDescription("mscorlib.Serialization_TopObject", 0xA34505BB, new ParameterlessText("No top object.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_topobjectinstantiate = new MessageDescription("mscorlib.Serialization_TopObjectInstantiate", 0xA34505BC, new FormatText("Top object cannot be instantiated for element '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typecode = new MessageDescription("mscorlib.Serialization_TypeCode", 0xA34505BD, new FormatText("Invalid type code in stream '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typeexpected = new MessageDescription("mscorlib.Serialization_TypeExpected", 0xA34505BE, new ParameterlessText("Invalid expected type.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typeloadfailure = new MessageDescription("mscorlib.Serialization_TypeLoadFailure", 0xA34505BF, new FormatText("Unable to load type {0} required for deserialization.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typemissing = new MessageDescription("mscorlib.Serialization_TypeMissing", 0xA34505C0, new FormatText("Type is missing for member of type Object '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typeread = new MessageDescription("mscorlib.Serialization_TypeRead", 0xA34505C1, new FormatText("Invalid read type request '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typeresolved = new MessageDescription("mscorlib.Serialization_TypeResolved", 0xA34505C2, new FormatText("Type is not resolved for member '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_typesecurity = new MessageDescription("mscorlib.Serialization_TypeSecurity", 0xA34505C3, new FormatText("Type {0} and the types derived from it (such as {1}) are not permitted to be deserialized at this security level.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_typewrite = new MessageDescription("mscorlib.Serialization_TypeWrite", 0xA34505C4, new FormatText("Invalid write type request '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_unabletofindmodule = new MessageDescription("mscorlib.Serialization_UnableToFindModule", 0xA34505C5, new FormatText("The given module {0} cannot be found within the assembly {1}.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_unabletofixup = new MessageDescription("mscorlib.Serialization_UnableToFixup", 0xA34505C6, new ParameterlessText("Cannot perform fixup.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_unknownmember = new MessageDescription("mscorlib.Serialization_UnknownMember", 0xA34505C7, new FormatText("Cannot get the member '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_unknownmemberinfo = new MessageDescription("mscorlib.Serialization_UnknownMemberInfo", 0xA34505C8, new ParameterlessText("Only FieldInfo, PropertyInfo, and SerializationMemberInfo are recognized.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_valuetypefixup = new MessageDescription("mscorlib.Serialization_ValueTypeFixup", 0xA34505C9, new ParameterlessText("ValueType fixup on Arrays is not implemented.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Serialization").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_xmlelement = new MessageDescription("mscorlib.Serialization_XMLElement", 0xA34505CA, new FormatText("Invalid element '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_arrayinvalidlength = new MessageDescription("mscorlib.Serialization_ArrayInvalidLength", 0xA3450756, new ParameterlessText("Array specifies an invalid length.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_arraynolength = new MessageDescription("mscorlib.Serialization_ArrayNoLength", 0xA3450754, new ParameterlessText("Array does not specify a length.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_cannotgettype = new MessageDescription("mscorlib.Serialization_CannotGetType", 0xA3450755, new FormatText("Cannot get the type '{0}'.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_invalidid = new MessageDescription("mscorlib.Serialization_InvalidID", 0xA3450752, new ParameterlessText("Object specifies an invalid ID.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_malformedarray = new MessageDescription("mscorlib.Serialization_MalformedArray", 0xA3450757, new ParameterlessText("The array information in the stream is invalid.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_missingkeyvaluepairs = new MessageDescription("mscorlib.Serialization_MissingKeyValuePairs", 0xA345075A, new ParameterlessText("The KeyValuePairs for this Dictionary are missing.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_multiplemembers = new MessageDescription("mscorlib.Serialization_MultipleMembers", 0xA3450758, new ParameterlessText("Cannot resolve multiple members with the same name.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_nobasetype = new MessageDescription("mscorlib.Serialization_NoBaseType", 0xA3450753, new ParameterlessText("Object does not specify a base type.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_notype = new MessageDescription("mscorlib.Serialization_NoType", 0xA3450751, new ParameterlessText("Object does not specify a type.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_objectusedbeforedesercallback = new MessageDescription("mscorlib.Serialization_ObjectUsedBeforeDeserCallback", 0xA3450759, new ParameterlessText("An object was used before its deserialization callback ran, which may break higher-level consistency guarantees in the application.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        return this;
    }    

}
