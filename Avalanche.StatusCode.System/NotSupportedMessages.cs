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

/// <summary>System.NotSupportedException</summary>
public class NotSupportedMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<NotSupportedMessages> instance = new Lazy<NotSupportedMessages>(() => new NotSupportedMessages().Initialize().SetAllReadOnly<NotSupportedMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static NotSupportedMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x006F;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _devicesnotsupported, _hexstylenotsupported, _multicastnotsupportedexception, _notsupportedexception, _platformnotsupported, _rankmultidimnotsupported, _codepagenotsupported, _constantnotsupported, _cultureietfnotsupported, _culturenotsupported;
    IMessageDescription? _encodingnotsupported, _oneofculturesnotsupported, _pathformatnotsupported, _pathuriformatnotsupported, _hugearraynotsupported, _abstractnoncls, _activattronnonmbr, _activforcom, _ambiguousidentity, _appx;
    IMessageDescription? _assemblyloadcodebase, _byrefreturn, _calltovararg, _cannotwritetobufferedstreamifreadbuffercannotbeflushed, _casdeny, _changetype, _codepage50229, _constructor, _createinstancewithtypebuilder, _dbnullserial;
    IMessageDescription? _declarativeunion, _delegatecreationfrompt, _delegateserholderserial, _dynamicassembly, _dynamicmethodflags, _encryptionneedsntfs, _filestreamonnonfiles, _fixedsizecollection, _getmethod, _globalfunctionnotbaked;
    IMessageDescription? _globalmethodserialization, _illegalonebytebranch, _keycollectionset, _maxwaithandles, _memstreamnotexpandable, _method, _nocodepagedata, _nonreflectedtype, _nonurlattronmbr, _noparentdefaultconstructor;
    IMessageDescription? _notalltypesarebaked, _notypeinfo, _nyi, _obsoleteresourcesfile, _outputstreamusingtypebuilder, _populatedata, _rangecollection, _reading, _readonlycollection, _requirescaspolicyexplicit;
    IMessageDescription? _requirescaspolicyimplicit, _resourceobjectserialization, _securitypermissionunion, _setmethod, _sortedlistnestedwrite, _stringcomparison, _subclassoverride, _symbolmethod, _type, _typecannotdeserialized;
    IMessageDescription? _typenotyetcreated, _umssafebuffer, _unityserholder, _unknowntypecode, _unreadablestream, _unseekablestream, _unwritablestream, _valuecollectionset, _windowsphone, _writing;
    IMessageDescription? _wrongresourcereadertype, _vtablecallsnotsupportedexception, _flagnotsupported, _collectibleassemblyresolve, _collectibleboundnoncollectible, _collectiblecom, _collectibledelegatemarshal, _containsstackptr, _containsstackptr2, _declsecvararg;
    IMessageDescription? _delegatemarshaltowrongdomain, _dynamicassemblynorunaccess, _idispinvokedefaultmemberwithnamedargs, _incomparabletype, _managedactivation, _maxvalue, _minvalue, _negativeinfinity, _oleautbadvartype, _one;
    IMessageDescription? _opentype, _piainappxprocess, _positiveinfinity, _toomanyargs, _unsafepointer, _usercom, _userdllimport, _valueclasscm, _void, _winrtpartialtrust;
    IMessageDescription? _zero;
    
    /// <summary>FileStream will not open Win32 devices such as disk partitions and tape drives. Avoid use of &quot;\\.\&quot; in the path.</summary>
    public IMessageDescription DevicesNotSupported { get => _devicesnotsupported!; set => this.AssertWritable()._devicesnotsupported = value; }
    /// <summary>The number style AllowHexSpecifier is not supported on floating point data types.</summary>
    public IMessageDescription HexStyleNotSupported { get => _hexstylenotsupported!; set => this.AssertWritable()._hexstylenotsupported = value; }
    /// <summary>System</summary>
    public IMessageDescription MulticastNotSupportedException { get => _multicastnotsupportedexception!; set => this.AssertWritable()._multicastnotsupportedexception = value; }
    /// <summary>System</summary>
    public IMessageDescription NotSupportedException { get => _notsupportedexception!; set => this.AssertWritable()._notsupportedexception = value; }
    /// <summary>System</summary>
    public IMessageDescription PlatformNotSupported { get => _platformnotsupported!; set => this.AssertWritable()._platformnotsupported = value; }
    /// <summary>Only single dimensional arrays are supported for the requested action.</summary>
    public IMessageDescription RankMultiDimNotSupported { get => _rankmultidimnotsupported!; set => this.AssertWritable()._rankmultidimnotsupported = value; }
    /// <summary>{0} is not a supported code page.</summary>
    public IMessageDescription CodepageNotSupported { get => _codepagenotsupported!; set => this.AssertWritable()._codepagenotsupported = value; }
    /// <summary>{0} is not a supported constant type.</summary>
    public IMessageDescription ConstantNotSupported { get => _constantnotsupported!; set => this.AssertWritable()._constantnotsupported = value; }
    /// <summary>Culture IETF Name {0} is not a recognized IETF name.</summary>
    public IMessageDescription CultureIetfNotSupported { get => _cultureietfnotsupported!; set => this.AssertWritable()._cultureietfnotsupported = value; }
    /// <summary>System.Globalization</summary>
    public IMessageDescription CultureNotSupported { get => _culturenotsupported!; set => this.AssertWritable()._culturenotsupported = value; }
    /// <summary>&#39;{0}&#39; is not a supported encoding name. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.</summary>
    public IMessageDescription EncodingNotSupported { get => _encodingnotsupported!; set => this.AssertWritable()._encodingnotsupported = value; }
    /// <summary>Culture name {0} or {1} is not supported.</summary>
    public IMessageDescription OneOfCulturesNotSupported { get => _oneofculturesnotsupported!; set => this.AssertWritable()._oneofculturesnotsupported = value; }
    /// <summary>The given path&#39;s format is not supported.</summary>
    public IMessageDescription PathFormatNotSupported { get => _pathformatnotsupported!; set => this.AssertWritable()._pathformatnotsupported = value; }
    /// <summary>URI formats are not supported.</summary>
    public IMessageDescription PathUriFormatNotSupported { get => _pathuriformatnotsupported!; set => this.AssertWritable()._pathuriformatnotsupported = value; }
    /// <summary>Arrays larger than 2GB are not supported.</summary>
    public IMessageDescription HugeArrayNotSupported { get => _hugearraynotsupported!; set => this.AssertWritable()._hugearraynotsupported = value; }
    /// <summary>This non-CLS method is not implemented.</summary>
    public IMessageDescription AbstractNonCLS { get => _abstractnoncls!; set => this.AssertWritable()._abstractnoncls = value; }
    /// <summary>Activation Attributes are not supported for types not deriving from MarshalByRefObject.</summary>
    public IMessageDescription ActivAttrOnNonMBR { get => _activattronnonmbr!; set => this.AssertWritable()._activattronnonmbr = value; }
    /// <summary>Activation Attributes not supported for COM Objects.</summary>
    public IMessageDescription ActivForCom { get => _activforcom!; set => this.AssertWritable()._activforcom = value; }
    /// <summary>The operation is ambiguous because the permission represents multiple identities.</summary>
    public IMessageDescription AmbiguousIdentity { get => _ambiguousidentity!; set => this.AssertWritable()._ambiguousidentity = value; }
    /// <summary>{0} is not supported in AppX.</summary>
    public IMessageDescription AppX { get => _appx!; set => this.AssertWritable()._appx = value; }
    /// <summary>Assembly.Load with a Codebase is not supported on Windows Phone.</summary>
    public IMessageDescription AssemblyLoadCodeBase { get => _assemblyloadcodebase!; set => this.AssertWritable()._assemblyloadcodebase = value; }
    /// <summary>ByRef return value not supported in reflection invocation.</summary>
    public IMessageDescription ByRefReturn { get => _byrefreturn!; set => this.AssertWritable()._byrefreturn = value; }
    /// <summary>Vararg calling convention not supported.</summary>
    public IMessageDescription CallToVarArg { get => _calltovararg!; set => this.AssertWritable()._calltovararg = value; }
    /// <summary>Cannot write to a BufferedStream while the read buffer is not empty if the underlying stream is not seekable. Ensure that the stream underlying this BufferedStream can seek or avoid interleaving read and write operations on this BufferedStream.</summary>
    public IMessageDescription CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed { get => _cannotwritetobufferedstreamifreadbuffercannotbeflushed!; set => this.AssertWritable()._cannotwritetobufferedstreamifreadbuffercannotbeflushed = value; }
    /// <summary>The Deny stack modifier has been obsoleted by the .NET Framework. Please see http://go.microsoft.com/fwlink/?LinkId=155571 for more information.</summary>
    public IMessageDescription CasDeny { get => _casdeny!; set => this.AssertWritable()._casdeny = value; }
    /// <summary>ChangeType operation is not supported.</summary>
    public IMessageDescription ChangeType { get => _changetype!; set => this.AssertWritable()._changetype = value; }
    /// <summary>The ISO-2022-CN Encoding (Code page 50229) is not supported.</summary>
    public IMessageDescription CodePage50229 { get => _codepage50229!; set => this.AssertWritable()._codepage50229 = value; }
    /// <summary>Object cannot be created through this constructor.</summary>
    public IMessageDescription Constructor { get => _constructor!; set => this.AssertWritable()._constructor = value; }
    /// <summary>CreateInstance cannot be used with an object of type TypeBuilder.</summary>
    public IMessageDescription CreateInstanceWithTypeBuilder { get => _createinstancewithtypebuilder!; set => this.AssertWritable()._createinstancewithtypebuilder = value; }
    /// <summary>Only one DBNull instance may exist, and calls to DBNull deserialization methods are not allowed.</summary>
    public IMessageDescription DBNullSerial { get => _dbnullserial!; set => this.AssertWritable()._dbnullserial = value; }
    /// <summary>Declarative unionizing of these permissions is not supported.</summary>
    public IMessageDescription DeclarativeUnion { get => _declarativeunion!; set => this.AssertWritable()._declarativeunion = value; }
    /// <summary>Application code cannot use Activator.CreateInstance to create types that derive from System.Delegate. Delegate.CreateDelegate can be used instead.</summary>
    public IMessageDescription DelegateCreationFromPT { get => _delegatecreationfrompt!; set => this.AssertWritable()._delegatecreationfrompt = value; }
    /// <summary>DelegateSerializationHolder objects are designed to represent a delegate during serialization and are not serializable themselves.</summary>
    public IMessageDescription DelegateSerHolderSerial { get => _delegateserholderserial!; set => this.AssertWritable()._delegateserholderserial = value; }
    /// <summary>The invoked member is not supported in a dynamic assembly.</summary>
    public IMessageDescription DynamicAssembly { get => _dynamicassembly!; set => this.AssertWritable()._dynamicassembly = value; }
    /// <summary>Wrong MethodAttributes or CallingConventions for DynamicMethod. Only public, static, standard supported</summary>
    public IMessageDescription DynamicMethodFlags { get => _dynamicmethodflags!; set => this.AssertWritable()._dynamicmethodflags = value; }
    /// <summary>File encryption support only works on NTFS partitions.</summary>
    public IMessageDescription EncryptionNeedsNTFS { get => _encryptionneedsntfs!; set => this.AssertWritable()._encryptionneedsntfs = value; }
    /// <summary>FileStream was asked to open a device that was not a file. For support for devices like &#39;com1:&#39; or &#39;lpt1:&#39;, call CreateFile, then use the FileStream constructors that take an OS handle as an IntPtr.</summary>
    public IMessageDescription FileStreamOnNonFiles { get => _filestreamonnonfiles!; set => this.AssertWritable()._filestreamonnonfiles = value; }
    /// <summary>Collection was of a fixed size.</summary>
    public IMessageDescription FixedSizeCollection { get => _fixedsizecollection!; set => this.AssertWritable()._fixedsizecollection = value; }
    /// <summary>The &#39;get&#39; method is not supported on this property.</summary>
    public IMessageDescription GetMethod { get => _getmethod!; set => this.AssertWritable()._getmethod = value; }
    /// <summary>The type definition of the global function is not completed.</summary>
    public IMessageDescription GlobalFunctionNotBaked { get => _globalfunctionnotbaked!; set => this.AssertWritable()._globalfunctionnotbaked = value; }
    /// <summary>Serialization of global methods (including implicit serialization via the use of asynchronous delegates) is not supported.</summary>
    public IMessageDescription GlobalMethodSerialization { get => _globalmethodserialization!; set => this.AssertWritable()._globalmethodserialization = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription IllegalOneByteBranch { get => _illegalonebytebranch!; set => this.AssertWritable()._illegalonebytebranch = value; }
    /// <summary>Mutating a key collection derived from a dictionary is not allowed.</summary>
    public IMessageDescription KeyCollectionSet { get => _keycollectionset!; set => this.AssertWritable()._keycollectionset = value; }
    /// <summary>The number of WaitHandles must be less than or equal to 64.</summary>
    public IMessageDescription MaxWaitHandles { get => _maxwaithandles!; set => this.AssertWritable()._maxwaithandles = value; }
    /// <summary>Memory stream is not expandable.</summary>
    public IMessageDescription MemStreamNotExpandable { get => _memstreamnotexpandable!; set => this.AssertWritable()._memstreamnotexpandable = value; }
    /// <summary>Method is not supported.</summary>
    public IMessageDescription Method { get => _method!; set => this.AssertWritable()._method = value; }
    /// <summary>No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.</summary>
    public IMessageDescription NoCodepageData { get => _nocodepagedata!; set => this.AssertWritable()._nocodepagedata = value; }
    /// <summary>Not supported in a non-reflected type.</summary>
    public IMessageDescription NonReflectedType { get => _nonreflectedtype!; set => this.AssertWritable()._nonreflectedtype = value; }
    /// <summary>UrlAttribute is the only attribute supported for MarshalByRefObject.</summary>
    public IMessageDescription NonUrlAttrOnMBR { get => _nonurlattronmbr!; set => this.AssertWritable()._nonurlattronmbr = value; }
    /// <summary>Parent does not have a default constructor. The default constructor must be explicitly defined.</summary>
    public IMessageDescription NoParentDefaultConstructor { get => _noparentdefaultconstructor!; set => this.AssertWritable()._noparentdefaultconstructor = value; }
    /// <summary>Type &#39;{0}&#39; was not completed.</summary>
    public IMessageDescription NotAllTypesAreBaked { get => _notalltypesarebaked!; set => this.AssertWritable()._notalltypesarebaked = value; }
    /// <summary>Cannot resolve {0} to a TypeInfo object.</summary>
    public IMessageDescription NoTypeInfo { get => _notypeinfo!; set => this.AssertWritable()._notypeinfo = value; }
    /// <summary>This feature is not currently implemented.</summary>
    public IMessageDescription NYI { get => _nyi!; set => this.AssertWritable()._nyi = value; }
    /// <summary>Found an obsolete .resources file in assembly &#39;{0}&#39;. Rebuild that .resources file then rebuild that assembly.</summary>
    public IMessageDescription ObsoleteResourcesFile { get => _obsoleteresourcesfile!; set => this.AssertWritable()._obsoleteresourcesfile = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription OutputStreamUsingTypeBuilder { get => _outputstreamusingtypebuilder!; set => this.AssertWritable()._outputstreamusingtypebuilder = value; }
    /// <summary>This Surrogate does not support PopulateData().</summary>
    public IMessageDescription PopulateData { get => _populatedata!; set => this.AssertWritable()._populatedata = value; }
    /// <summary>The specified operation is not supported on Ranges.</summary>
    public IMessageDescription RangeCollection { get => _rangecollection!; set => this.AssertWritable()._rangecollection = value; }
    /// <summary>Accessor does not support reading.</summary>
    public IMessageDescription Reading { get => _reading!; set => this.AssertWritable()._reading = value; }
    /// <summary>Collection is read-only.</summary>
    public IMessageDescription ReadOnlyCollection { get => _readonlycollection!; set => this.AssertWritable()._readonlycollection = value; }
    /// <summary>This method explicitly uses CAS policy, which has been obsoleted by the .NET Framework. In order to enable CAS policy for compatibility reasons, please use the NetFx40_LegacySecurityPolicy configuration switch. Please see http://go.microsoft.com/fwlink/?LinkID=155570 for more information.</summary>
    public IMessageDescription RequiresCasPolicyExplicit { get => _requirescaspolicyexplicit!; set => this.AssertWritable()._requirescaspolicyexplicit = value; }
    /// <summary>This method implicitly uses CAS policy, which has been obsoleted by the .NET Framework. In order to enable CAS policy for compatibility reasons, please use the NetFx40_LegacySecurityPolicy configuration switch. Please see http://go.microsoft.com/fwlink/?LinkID=155570 for more information.</summary>
    public IMessageDescription RequiresCasPolicyImplicit { get => _requirescaspolicyimplicit!; set => this.AssertWritable()._requirescaspolicyimplicit = value; }
    /// <summary>Cannot read resources that depend on serialization.</summary>
    public IMessageDescription ResourceObjectSerialization { get => _resourceobjectserialization!; set => this.AssertWritable()._resourceobjectserialization = value; }
    /// <summary>Union is not implemented.</summary>
    public IMessageDescription SecurityPermissionUnion { get => _securitypermissionunion!; set => this.AssertWritable()._securitypermissionunion = value; }
    /// <summary>The &#39;set&#39; method is not supported on this property.</summary>
    public IMessageDescription SetMethod { get => _setmethod!; set => this.AssertWritable()._setmethod = value; }
    /// <summary>This operation is not supported on SortedList nested types because they require modifying the original SortedList.</summary>
    public IMessageDescription SortedListNestedWrite { get => _sortedlistnestedwrite!; set => this.AssertWritable()._sortedlistnestedwrite = value; }
    /// <summary>The string comparison type passed in is currently not supported.</summary>
    public IMessageDescription StringComparison { get => _stringcomparison!; set => this.AssertWritable()._stringcomparison = value; }
    /// <summary>Derived classes must provide an implementation.</summary>
    public IMessageDescription SubclassOverride { get => _subclassoverride!; set => this.AssertWritable()._subclassoverride = value; }
    /// <summary>Not supported in an array method of a type definition that is not complete.</summary>
    public IMessageDescription SymbolMethod { get => _symbolmethod!; set => this.AssertWritable()._symbolmethod = value; }
    /// <summary>Type is not supported.</summary>
    public IMessageDescription Type { get => _type!; set => this.AssertWritable()._type = value; }
    /// <summary>Direct deserialization of type &#39;{0}&#39; is not supported.</summary>
    public IMessageDescription TypeCannotDeserialized { get => _typecannotdeserialized!; set => this.AssertWritable()._typecannotdeserialized = value; }
    /// <summary>The invoked member is not supported before the type is created.</summary>
    public IMessageDescription TypeNotYetCreated { get => _typenotyetcreated!; set => this.AssertWritable()._typenotyetcreated = value; }
    /// <summary>This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer.</summary>
    public IMessageDescription UmsSafeBuffer { get => _umssafebuffer!; set => this.AssertWritable()._umssafebuffer = value; }
    /// <summary>The UnitySerializationHolder object is designed to transmit information about other types and is not serializable itself.</summary>
    public IMessageDescription UnitySerHolder { get => _unityserholder!; set => this.AssertWritable()._unityserholder = value; }
    /// <summary>TypeCode &#39;{0}&#39; was not valid.</summary>
    public IMessageDescription UnknownTypeCode { get => _unknowntypecode!; set => this.AssertWritable()._unknowntypecode = value; }
    /// <summary>Stream does not support reading.</summary>
    public IMessageDescription UnreadableStream { get => _unreadablestream!; set => this.AssertWritable()._unreadablestream = value; }
    /// <summary>Stream does not support seeking.</summary>
    public IMessageDescription UnseekableStream { get => _unseekablestream!; set => this.AssertWritable()._unseekablestream = value; }
    /// <summary>Stream does not support writing.</summary>
    public IMessageDescription UnwritableStream { get => _unwritablestream!; set => this.AssertWritable()._unwritablestream = value; }
    /// <summary>Mutating a value collection derived from a dictionary is not allowed.</summary>
    public IMessageDescription ValueCollectionSet { get => _valuecollectionset!; set => this.AssertWritable()._valuecollectionset = value; }
    /// <summary>{0} is not supported on Windows Phone.</summary>
    public IMessageDescription WindowsPhone { get => _windowsphone!; set => this.AssertWritable()._windowsphone = value; }
    /// <summary>Accessor does not support writing.</summary>
    public IMessageDescription Writing { get => _writing!; set => this.AssertWritable()._writing = value; }
    /// <summary>This .resources file should not be read with this reader. The resource reader type is &quot;{0}&quot;.</summary>
    public IMessageDescription WrongResourceReaderType { get => _wrongresourcereadertype!; set => this.AssertWritable()._wrongresourcereadertype = value; }
    /// <summary>Attempted to make an early bound call on a COM dispatch-only interface.</summary>
    public IMessageDescription VTableCallsNotSupportedException { get => _vtablecallsnotsupportedexception!; set => this.AssertWritable()._vtablecallsnotsupportedexception = value; }
    /// <summary>One or more flags are not supported.</summary>
    public IMessageDescription FlagNotSupported { get => _flagnotsupported!; set => this.AssertWritable()._flagnotsupported = value; }
    /// <summary>Resolving to a collectible assembly is not supported.</summary>
    public IMessageDescription CollectibleAssemblyResolve { get => _collectibleassemblyresolve!; set => this.AssertWritable()._collectibleassemblyresolve = value; }
    /// <summary>A non-collectible assembly may not reference a collectible assembly.</summary>
    public IMessageDescription CollectibleBoundNonCollectible { get => _collectibleboundnoncollectible!; set => this.AssertWritable()._collectibleboundnoncollectible = value; }
    /// <summary>COM Interop is not supported for collectible types.</summary>
    public IMessageDescription CollectibleCOM { get => _collectiblecom!; set => this.AssertWritable()._collectiblecom = value; }
    /// <summary>Delegate marshaling for types within collectible assemblies is not supported.</summary>
    public IMessageDescription CollectibleDelegateMarshal { get => _collectibledelegatemarshal!; set => this.AssertWritable()._collectibledelegatemarshal = value; }
    /// <summary>Cannot create boxed TypedReference, ArgIterator, or RuntimeArgumentHandle Objects.</summary>
    public IMessageDescription ContainsStackPtr { get => _containsstackptr!; set => this.AssertWritable()._containsstackptr = value; }
    /// <summary>Cannot create arrays of TypedReference, ArgIterator, ByRef, or RuntimeArgumentHandle Objects.</summary>
    public IMessageDescription ContainsStackPtr2 { get => _containsstackptr2!; set => this.AssertWritable()._containsstackptr2 = value; }
    /// <summary>Assert, Deny, and PermitOnly are not supported on methods with a Vararg calling convention.</summary>
    public IMessageDescription DeclSecVarArg { get => _declsecvararg!; set => this.AssertWritable()._declsecvararg = value; }
    /// <summary>Delegates cannot be marshaled from native code into a domain other than their home domain.</summary>
    public IMessageDescription DelegateMarshalToWrongDomain { get => _delegatemarshaltowrongdomain!; set => this.AssertWritable()._delegatemarshaltowrongdomain = value; }
    /// <summary>Cannot execute code on a dynamic assembly without run access.</summary>
    public IMessageDescription DynamicAssemblyNoRunAccess { get => _dynamicassemblynorunaccess!; set => this.AssertWritable()._dynamicassemblynorunaccess = value; }
    /// <summary>Invoking default method with named arguments is not supported.</summary>
    public IMessageDescription IDispInvokeDefaultMemberWithNamedArgs { get => _idispinvokedefaultmemberwithnamedargs!; set => this.AssertWritable()._idispinvokedefaultmemberwithnamedargs = value; }
    /// <summary>A type must implement IComparable&lt;T&gt; or IComparable to support comparison.</summary>
    public IMessageDescription InComparableType { get => _incomparabletype!; set => this.AssertWritable()._incomparabletype = value; }
    /// <summary>Cannot create uninitialized instances of types requiring managed activation.</summary>
    public IMessageDescription ManagedActivation { get => _managedactivation!; set => this.AssertWritable()._managedactivation = value; }
    /// <summary>The arithmetic type &#39;{0}&#39; does not have a maximum value.</summary>
    public IMessageDescription MaxValue { get => _maxvalue!; set => this.AssertWritable()._maxvalue = value; }
    /// <summary>The arithmetic type &#39;{0}&#39; does not have a minimum value.</summary>
    public IMessageDescription MinValue { get => _minvalue!; set => this.AssertWritable()._minvalue = value; }
    /// <summary>The arithmetic type &#39;{0}&#39; cannot represent negative infinity.</summary>
    public IMessageDescription NegativeInfinity { get => _negativeinfinity!; set => this.AssertWritable()._negativeinfinity = value; }
    /// <summary>The given Variant type is not supported by this OleAut function.</summary>
    public IMessageDescription OleAutBadVarType { get => _oleautbadvartype!; set => this.AssertWritable()._oleautbadvartype = value; }
    /// <summary>The arithmetic type &#39;{0}&#39; cannot represent the number one.</summary>
    public IMessageDescription One { get => _one!; set => this.AssertWritable()._one = value; }
    /// <summary>Cannot create arrays of open type.</summary>
    public IMessageDescription OpenType { get => _opentype!; set => this.AssertWritable()._opentype = value; }
    /// <summary>A Primary Interop Assembly is not supported in AppX.</summary>
    public IMessageDescription PIAInAppxProcess { get => _piainappxprocess!; set => this.AssertWritable()._piainappxprocess = value; }
    /// <summary>The arithmetic type &#39;{0}&#39; cannot represent positive infinity.</summary>
    public IMessageDescription PositiveInfinity { get => _positiveinfinity!; set => this.AssertWritable()._positiveinfinity = value; }
    /// <summary>Stack size too deep. Possibly too many arguments.</summary>
    public IMessageDescription TooManyArgs { get => _toomanyargs!; set => this.AssertWritable()._toomanyargs = value; }
    /// <summary>This accessor was created with a SafeBuffer; use the SafeBuffer to gain access to the pointer.</summary>
    public IMessageDescription UnsafePointer { get => _unsafepointer!; set => this.AssertWritable()._unsafepointer = value; }
    /// <summary>COM Interop is not supported for user-defined types.</summary>
    public IMessageDescription UserCOM { get => _usercom!; set => this.AssertWritable()._usercom = value; }
    /// <summary>DllImport cannot be used on user-defined methods.</summary>
    public IMessageDescription UserDllImport { get => _userdllimport!; set => this.AssertWritable()._userdllimport = value; }
    /// <summary>Custom marshalers for value types are not currently supported.</summary>
    public IMessageDescription ValueClassCM { get => _valueclasscm!; set => this.AssertWritable()._valueclasscm = value; }
    /// <summary>Arrays of System.Void are not supported.</summary>
    public IMessageDescription Void { get => _void!; set => this.AssertWritable()._void = value; }
    /// <summary>Windows Runtime is not supported in partial trust.</summary>
    public IMessageDescription WinRTPartialTrust { get => _winrtpartialtrust!; set => this.AssertWritable()._winrtpartialtrust = value; }
    /// <summary>The arithmetic type &#39;{0}&#39; cannot represent the number zero.</summary>
    public IMessageDescription Zero { get => _zero!; set => this.AssertWritable()._zero = value; }

    /// <summary>Initialize fields</summary>
    public override NotSupportedMessages Initialize() 
    {
        base.Initialize();
        Add(_devicesnotsupported = new MessageDescription("mscorlib.Arg_DevicesNotSupported", 0xA3450041, new ParameterlessText("FileStream will not open Win32 devices such as disk partitions and tape drives. Avoid use of \"\\\\.\\\" in the path.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_hexstylenotsupported = new MessageDescription("mscorlib.Arg_HexStyleNotSupported", 0xA345006C, new ParameterlessText("The number style AllowHexSpecifier is not supported on floating point data types.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_multicastnotsupportedexception = new MessageDescription("mscorlib.Arg_MulticastNotSupportedException", 0xA3450093, new ParameterlessText("Attempted to add multiple callbacks to a delegate that does not support multicast.")).SetHResult(0x80131514).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MulticastNotSupportedException)));
        Add(_notsupportedexception = new MessageDescription("mscorlib.Arg_NotSupportedException", 0xA34500C4, new ParameterlessText("Specified method is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.NotSupportedException)));
        Add(_platformnotsupported = new MessageDescription("mscorlib.Arg_PlatformNotSupported", 0xA34500D3, new ParameterlessText("Operation is not supported on this platform.")).SetHResult(0x80131539).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.PlatformNotSupportedException)));
        Add(_rankmultidimnotsupported = new MessageDescription("mscorlib.Arg_RankMultiDimNotSupported", 0xA34500DA, new ParameterlessText("Only single dimensional arrays are supported for the requested action.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_codepagenotsupported = new MessageDescription("mscorlib.Argument_CodepageNotSupported", 0xA345013C, new FormatText("{0} is not a supported code page.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_constantnotsupported = new MessageDescription("mscorlib.Argument_ConstantNotSupported", 0xA3450141, new FormatText("{0} is not a supported constant type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cultureietfnotsupported = new MessageDescription("mscorlib.Argument_CultureIetfNotSupported", 0xA3450146, new FormatText("Culture IETF Name {0} is not a recognized IETF name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.Globalization.CultureNotFoundException)));
        Add(_culturenotsupported = new MessageDescription("mscorlib.Argument_CultureNotSupported", 0xA3450148, new ParameterlessText("Culture is not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Globalization").SetException(typeof(System.ArgumentException)));
        Add(_encodingnotsupported = new MessageDescription("mscorlib.Argument_EncodingNotSupported", 0xA3450163, new FormatText("'{0}' is not a supported encoding name. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_oneofculturesnotsupported = new MessageDescription("mscorlib.Argument_OneOfCulturesNotSupported", 0xA3450218, new FormatText("Culture name {0} or {1} is not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.Globalization.CultureNotFoundException)));
        Add(_pathformatnotsupported = new MessageDescription("mscorlib.Argument_PathFormatNotSupported", 0xA345021C, new ParameterlessText("The given path's format is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_pathuriformatnotsupported = new MessageDescription("mscorlib.Argument_PathUriFormatNotSupported", 0xA345021D, new ParameterlessText("URI formats are not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_hugearraynotsupported = new MessageDescription("mscorlib.ArgumentOutOfRange_HugeArrayNotSupported", 0xA345029D, new ParameterlessText("Arrays larger than 2GB are not supported.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_abstractnoncls = new MessageDescription("mscorlib.NotSupported_AbstractNonCLS", 0xA345045F, new ParameterlessText("This non-CLS method is not implemented.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_activattronnonmbr = new MessageDescription("mscorlib.NotSupported_ActivAttrOnNonMBR", 0xA3450460, new ParameterlessText("Activation Attributes are not supported for types not deriving from MarshalByRefObject.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_activforcom = new MessageDescription("mscorlib.NotSupported_ActivForCom", 0xA3450461, new ParameterlessText("Activation Attributes not supported for COM Objects.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_ambiguousidentity = new MessageDescription("mscorlib.NotSupported_AmbiguousIdentity", 0xA3450462, new ParameterlessText("The operation is ambiguous because the permission represents multiple identities.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_appx = new MessageDescription("mscorlib.NotSupported_AppX", 0xA3450463, new FormatText("{0} is not supported in AppX.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_assemblyloadcodebase = new MessageDescription("mscorlib.NotSupported_AssemblyLoadCodeBase", 0xA3450464, new ParameterlessText("Assembly.Load with a Codebase is not supported on Windows Phone.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_byrefreturn = new MessageDescription("mscorlib.NotSupported_ByRefReturn", 0xA3450465, new ParameterlessText("ByRef return value not supported in reflection invocation.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_calltovararg = new MessageDescription("mscorlib.NotSupported_CallToVarArg", 0xA3450466, new ParameterlessText("Vararg calling convention not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_cannotwritetobufferedstreamifreadbuffercannotbeflushed = new MessageDescription("mscorlib.NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed", 0xA3450467, new ParameterlessText("Cannot write to a BufferedStream while the read buffer is not empty if the underlying stream is not seekable. Ensure that the stream underlying this BufferedStream can seek or avoid interleaving read and write operations on this BufferedStream.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_casdeny = new MessageDescription("mscorlib.NotSupported_CasDeny", 0xA3450468, new ParameterlessText("The Deny stack modifier has been obsoleted by the .NET Framework.  Please see http://go.microsoft.com/fwlink/?LinkId=155571 for more information.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_changetype = new MessageDescription("mscorlib.NotSupported_ChangeType", 0xA3450469, new ParameterlessText("ChangeType operation is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_codepage50229 = new MessageDescription("mscorlib.NotSupported_CodePage50229", 0xA345046A, new ParameterlessText("The ISO-2022-CN Encoding (Code page 50229) is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_constructor = new MessageDescription("mscorlib.NotSupported_Constructor", 0xA345046B, new ParameterlessText("Object cannot be created through this constructor.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_createinstancewithtypebuilder = new MessageDescription("mscorlib.NotSupported_CreateInstanceWithTypeBuilder", 0xA345046C, new ParameterlessText("CreateInstance cannot be used with an object of type TypeBuilder.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_dbnullserial = new MessageDescription("mscorlib.NotSupported_DBNullSerial", 0xA345046D, new ParameterlessText("Only one DBNull instance may exist, and calls to DBNull deserialization methods are not allowed.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_declarativeunion = new MessageDescription("mscorlib.NotSupported_DeclarativeUnion", 0xA345046E, new ParameterlessText("Declarative unionizing of these permissions is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_delegatecreationfrompt = new MessageDescription("mscorlib.NotSupported_DelegateCreationFromPT", 0xA345046F, new ParameterlessText("Application code cannot use Activator.CreateInstance to create types that derive from System.Delegate. Delegate.CreateDelegate can be used instead.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_delegateserholderserial = new MessageDescription("mscorlib.NotSupported_DelegateSerHolderSerial", 0xA3450470, new ParameterlessText("DelegateSerializationHolder objects are designed to represent a delegate during serialization and are not serializable themselves.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_dynamicassembly = new MessageDescription("mscorlib.NotSupported_DynamicAssembly", 0xA3450471, new ParameterlessText("The invoked member is not supported in a dynamic assembly.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_dynamicmethodflags = new MessageDescription("mscorlib.NotSupported_DynamicMethodFlags", 0xA3450472, new ParameterlessText("Wrong MethodAttributes or CallingConventions for DynamicMethod. Only public, static, standard supported")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_encryptionneedsntfs = new MessageDescription("mscorlib.NotSupported_EncryptionNeedsNTFS", 0xA3450474, new ParameterlessText("File encryption support only works on NTFS partitions.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_filestreamonnonfiles = new MessageDescription("mscorlib.NotSupported_FileStreamOnNonFiles", 0xA3450475, new ParameterlessText("FileStream was asked to open a device that was not a file. For support for devices like 'com1:' or 'lpt1:', call CreateFile, then use the FileStream constructors that take an OS handle as an IntPtr.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_fixedsizecollection = new MessageDescription("mscorlib.NotSupported_FixedSizeCollection", 0xA3450476, new ParameterlessText("Collection was of a fixed size.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_getmethod = new MessageDescription("mscorlib.NotSupported_GetMethod", 0xA3450477, new ParameterlessText("The 'get' method is not supported on this property.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_globalfunctionnotbaked = new MessageDescription("mscorlib.NotSupported_GlobalFunctionNotBaked", 0xA3450478, new ParameterlessText("The type definition of the global function is not completed.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_globalmethodserialization = new MessageDescription("mscorlib.NotSupported_GlobalMethodSerialization", 0xA3450479, new ParameterlessText("Serialization of global methods (including implicit serialization via the use of asynchronous delegates) is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_illegalonebytebranch = new MessageDescription("mscorlib.NotSupported_IllegalOneByteBranch", 0xA345047A, new FormatText("Illegal one-byte branch at position: {0}. Requested branch was: {1}.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.NotSupportedException)));
        Add(_keycollectionset = new MessageDescription("mscorlib.NotSupported_KeyCollectionSet", 0xA345047B, new ParameterlessText("Mutating a key collection derived from a dictionary is not allowed.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_maxwaithandles = new MessageDescription("mscorlib.NotSupported_MaxWaitHandles", 0xA345047C, new ParameterlessText("The number of WaitHandles must be less than or equal to 64.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_memstreamnotexpandable = new MessageDescription("mscorlib.NotSupported_MemStreamNotExpandable", 0xA345047D, new ParameterlessText("Memory stream is not expandable.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_method = new MessageDescription("mscorlib.NotSupported_Method", 0xA345047E, new ParameterlessText("Method is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_nocodepagedata = new MessageDescription("mscorlib.NotSupported_NoCodepageData", 0xA3450480, new FormatText("No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_nonreflectedtype = new MessageDescription("mscorlib.NotSupported_NonReflectedType", 0xA3450481, new ParameterlessText("Not supported in a non-reflected type.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_nonurlattronmbr = new MessageDescription("mscorlib.NotSupported_NonUrlAttrOnMBR", 0xA3450482, new ParameterlessText("UrlAttribute is the only attribute supported for MarshalByRefObject.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_noparentdefaultconstructor = new MessageDescription("mscorlib.NotSupported_NoParentDefaultConstructor", 0xA3450483, new ParameterlessText("Parent does not have a default constructor. The default constructor must be explicitly defined.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notalltypesarebaked = new MessageDescription("mscorlib.NotSupported_NotAllTypesAreBaked", 0xA3450484, new FormatText("Type '{0}' was not completed.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notypeinfo = new MessageDescription("mscorlib.NotSupported_NoTypeInfo", 0xA3450486, new FormatText("Cannot resolve {0} to a TypeInfo object.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_nyi = new MessageDescription("mscorlib.NotSupported_NYI", 0xA3450487, new ParameterlessText("This feature is not currently implemented.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_obsoleteresourcesfile = new MessageDescription("mscorlib.NotSupported_ObsoleteResourcesFile", 0xA3450488, new FormatText("Found an obsolete .resources file in assembly '{0}'. Rebuild that .resources file then rebuild that assembly.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_outputstreamusingtypebuilder = new MessageDescription("mscorlib.NotSupported_OutputStreamUsingTypeBuilder", 0xA3450489, new ParameterlessText("Output streams do not support TypeBuilders.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.NotSupportedException)));
        Add(_populatedata = new MessageDescription("mscorlib.NotSupported_PopulateData", 0xA345048A, new ParameterlessText("This Surrogate does not support PopulateData().")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_rangecollection = new MessageDescription("mscorlib.NotSupported_RangeCollection", 0xA345048B, new ParameterlessText("The specified operation is not supported on Ranges.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_reading = new MessageDescription("mscorlib.NotSupported_Reading", 0xA345048C, new ParameterlessText("Accessor does not support reading.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_readonlycollection = new MessageDescription("mscorlib.NotSupported_ReadOnlyCollection", 0xA345048D, new ParameterlessText("Collection is read-only.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_requirescaspolicyexplicit = new MessageDescription("mscorlib.NotSupported_RequiresCasPolicyExplicit", 0xA345048E, new ParameterlessText("This method explicitly uses CAS policy, which has been obsoleted by the .NET Framework. In order to enable CAS policy for compatibility reasons, please use the NetFx40_LegacySecurityPolicy configuration switch. Please see http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_requirescaspolicyimplicit = new MessageDescription("mscorlib.NotSupported_RequiresCasPolicyImplicit", 0xA345048F, new ParameterlessText("This method implicitly uses CAS policy, which has been obsoleted by the .NET Framework. In order to enable CAS policy for compatibility reasons, please use the NetFx40_LegacySecurityPolicy configuration switch. Please see http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_resourceobjectserialization = new MessageDescription("mscorlib.NotSupported_ResourceObjectSerialization", 0xA3450490, new ParameterlessText("Cannot read resources that depend on serialization.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_securitypermissionunion = new MessageDescription("mscorlib.NotSupported_SecurityPermissionUnion", 0xA3450491, new ParameterlessText("Union is not implemented.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_setmethod = new MessageDescription("mscorlib.NotSupported_SetMethod", 0xA3450492, new ParameterlessText("The 'set' method is not supported on this property.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_sortedlistnestedwrite = new MessageDescription("mscorlib.NotSupported_SortedListNestedWrite", 0xA3450493, new ParameterlessText("This operation is not supported on SortedList nested types because they require modifying the original SortedList.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_stringcomparison = new MessageDescription("mscorlib.NotSupported_StringComparison", 0xA3450494, new ParameterlessText("The string comparison type passed in is currently not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_subclassoverride = new MessageDescription("mscorlib.NotSupported_SubclassOverride", 0xA3450495, new ParameterlessText("Derived classes must provide an implementation.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_symbolmethod = new MessageDescription("mscorlib.NotSupported_SymbolMethod", 0xA3450496, new ParameterlessText("Not supported in an array method of a type definition that is not complete.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_type = new MessageDescription("mscorlib.NotSupported_Type", 0xA3450497, new ParameterlessText("Type is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_typecannotdeserialized = new MessageDescription("mscorlib.NotSupported_TypeCannotDeserialized", 0xA3450498, new FormatText("Direct deserialization of type '{0}' is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_typenotyetcreated = new MessageDescription("mscorlib.NotSupported_TypeNotYetCreated", 0xA3450499, new ParameterlessText("The invoked member is not supported before the type is created.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_umssafebuffer = new MessageDescription("mscorlib.NotSupported_UmsSafeBuffer", 0xA345049A, new ParameterlessText("This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unityserholder = new MessageDescription("mscorlib.NotSupported_UnitySerHolder", 0xA345049B, new ParameterlessText("The UnitySerializationHolder object is designed to transmit information about other types and is not serializable itself.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unknowntypecode = new MessageDescription("mscorlib.NotSupported_UnknownTypeCode", 0xA345049C, new FormatText("TypeCode '{0}' was not valid.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unreadablestream = new MessageDescription("mscorlib.NotSupported_UnreadableStream", 0xA345049D, new ParameterlessText("Stream does not support reading.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unseekablestream = new MessageDescription("mscorlib.NotSupported_UnseekableStream", 0xA345049E, new ParameterlessText("Stream does not support seeking.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unwritablestream = new MessageDescription("mscorlib.NotSupported_UnwritableStream", 0xA345049F, new ParameterlessText("Stream does not support writing.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_valuecollectionset = new MessageDescription("mscorlib.NotSupported_ValueCollectionSet", 0xA34504A0, new ParameterlessText("Mutating a value collection derived from a dictionary is not allowed.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_windowsphone = new MessageDescription("mscorlib.NotSupported_WindowsPhone", 0xA34504A1, new FormatText("{0} is not supported on Windows Phone.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_writing = new MessageDescription("mscorlib.NotSupported_Writing", 0xA34504A2, new ParameterlessText("Accessor does not support writing.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_wrongresourcereadertype = new MessageDescription("mscorlib.NotSupported_WrongResourceReader_Type", 0xA34504A3, new FormatText("This .resources file should not be read with this reader. The resource reader type is \"{0}\".")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_vtablecallsnotsupportedexception = new MessageDescription("mscorlib.Arg_VTableCallsNotSupportedException", 0xA3450658, new ParameterlessText("Attempted to make an early bound call on a COM dispatch-only interface.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_flagnotsupported = new MessageDescription("mscorlib.Argument_FlagNotSupported", 0xA345067D, new ParameterlessText("One or more flags are not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_collectibleassemblyresolve = new MessageDescription("mscorlib.NotSupported_CollectibleAssemblyResolve", 0xA34506F6, new ParameterlessText("Resolving to a collectible assembly is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_collectibleboundnoncollectible = new MessageDescription("mscorlib.NotSupported_CollectibleBoundNonCollectible", 0xA34506F7, new ParameterlessText("A non-collectible assembly may not reference a collectible assembly.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_collectiblecom = new MessageDescription("mscorlib.NotSupported_CollectibleCOM", 0xA34506F5, new ParameterlessText("COM Interop is not supported for collectible types.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_collectibledelegatemarshal = new MessageDescription("mscorlib.NotSupported_CollectibleDelegateMarshal", 0xA34506F8, new ParameterlessText("Delegate marshaling for types within collectible assemblies is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_containsstackptr = new MessageDescription("mscorlib.NotSupported_ContainsStackPtr", 0xA34506DE, new ParameterlessText("Cannot create boxed TypedReference, ArgIterator, or RuntimeArgumentHandle Objects.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_containsstackptr2 = new MessageDescription("mscorlib.NotSupported_ContainsStackPtr[]", 0xA34506DF, new ParameterlessText("Cannot create arrays of TypedReference, ArgIterator, ByRef, or RuntimeArgumentHandle Objects.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_declsecvararg = new MessageDescription("mscorlib.NotSupported_DeclSecVarArg", 0xA34506EA, new ParameterlessText("Assert, Deny, and PermitOnly are not supported on methods with a Vararg calling convention.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_delegatemarshaltowrongdomain = new MessageDescription("mscorlib.NotSupported_DelegateMarshalToWrongDomain", 0xA34506ED, new ParameterlessText("Delegates cannot be marshaled from native code into a domain other than their home domain.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_dynamicassemblynorunaccess = new MessageDescription("mscorlib.NotSupported_DynamicAssemblyNoRunAccess", 0xA34506E7, new ParameterlessText("Cannot execute code on a dynamic assembly without run access.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_idispinvokedefaultmemberwithnamedargs = new MessageDescription("mscorlib.NotSupported_IDispInvokeDefaultMemberWithNamedArgs", 0xA34506E8, new ParameterlessText("Invoking default method with named arguments is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_incomparabletype = new MessageDescription("mscorlib.NotSupported_InComparableType", 0xA34506EB, new ParameterlessText("A type must implement IComparable<T> or IComparable to support comparison.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_managedactivation = new MessageDescription("mscorlib.NotSupported_ManagedActivation", 0xA34506EC, new ParameterlessText("Cannot create uninitialized instances of types requiring managed activation.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_maxvalue = new MessageDescription("mscorlib.NotSupported_MaxValue", 0xA34506F0, new FormatText("The arithmetic type '{0}' does not have a maximum value.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_minvalue = new MessageDescription("mscorlib.NotSupported_MinValue", 0xA34506F1, new FormatText("The arithmetic type '{0}' does not have a minimum value.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_negativeinfinity = new MessageDescription("mscorlib.NotSupported_NegativeInfinity", 0xA34506F3, new FormatText("The arithmetic type '{0}' cannot represent negative infinity.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_oleautbadvartype = new MessageDescription("mscorlib.NotSupported_OleAutBadVarType", 0xA34506E1, new ParameterlessText("The given Variant type is not supported by this OleAut function.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_one = new MessageDescription("mscorlib.NotSupported_One", 0xA34506EE, new FormatText("The arithmetic type '{0}' cannot represent the number one.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_opentype = new MessageDescription("mscorlib.NotSupported_OpenType", 0xA34506E0, new ParameterlessText("Cannot create arrays of open type.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_piainappxprocess = new MessageDescription("mscorlib.NotSupported_PIAInAppxProcess", 0xA34506FE, new ParameterlessText("A Primary Interop Assembly is not supported in AppX.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_positiveinfinity = new MessageDescription("mscorlib.NotSupported_PositiveInfinity", 0xA34506F2, new FormatText("The arithmetic type '{0}' cannot represent positive infinity.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_toomanyargs = new MessageDescription("mscorlib.NotSupported_TooManyArgs", 0xA34506E9, new ParameterlessText("Stack size too deep. Possibly too many arguments.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unsafepointer = new MessageDescription("mscorlib.NotSupported_UnsafePointer", 0xA34506F4, new ParameterlessText("This accessor was created with a SafeBuffer; use the SafeBuffer to gain access to the pointer.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_usercom = new MessageDescription("mscorlib.NotSupported_UserCOM", 0xA34506FA, new ParameterlessText("COM Interop is not supported for user-defined types.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_userdllimport = new MessageDescription("mscorlib.NotSupported_UserDllImport", 0xA34506F9, new ParameterlessText("DllImport cannot be used on user-defined methods.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_valueclasscm = new MessageDescription("mscorlib.NotSupported_ValueClassCM", 0xA34506E3, new ParameterlessText("Custom marshalers for value types are not currently supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_void = new MessageDescription("mscorlib.NotSupported_Void[]", 0xA34506E4, new ParameterlessText("Arrays of System.Void are not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_winrtpartialtrust = new MessageDescription("mscorlib.NotSupported_WinRT_PartialTrust", 0xA34506FD, new ParameterlessText("Windows Runtime is not supported in partial trust.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_zero = new MessageDescription("mscorlib.NotSupported_Zero", 0xA34506EF, new FormatText("The arithmetic type '{0}' cannot represent the number zero.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        return this;
    }    

}
