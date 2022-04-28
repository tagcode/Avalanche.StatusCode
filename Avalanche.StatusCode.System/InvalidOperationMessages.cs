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

/// <summary>System.InvalidOperationException</summary>
public class InvalidOperationMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<InvalidOperationMessages> instance = new Lazy<InvalidOperationMessages>(() => new InvalidOperationMessages().Initialize().SetAllReadOnly<InvalidOperationMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static InvalidOperationMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0095;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _exception, _arugmentemitmixedcontext1, _arugmentemitmixedcontext2, _asyncmethodbuilderinstancenotinitialized, _countdowneventdecrementbelowzero, _countdowneventincrementalreadymax, _countdowneventincrementalreadyzero, _addcontextfrozen, _anonymouscannotimpersonate, _apartmentstateswitchfailed;
    IMessageDescription? _apiinvalidforcurrentcontext, _asmloadedforreflectiononly, _assemblyhasbeensaved, _asyncflowctrlctxmismatch, _asyncioinprogress, _bademptymethodbody, _badilgeneratorusage, _badinstructionorindexoutofbound, _badinterfacenotabstract, _badmethodbody;
    IMessageDescription? _badresourcecontainer, _badtypeattributesnotabstract, _calledtwice, _cannotalterassembly, _cannotcopyusedcontext, _cannotoverridesetwithoutrevert, _cannotremovelastfromemptycollection, _cannotrestoreunsupressedflow, _cannotsupressflowmultipletimes, _cannotuseafcmultiple;
    IMessageDescription? _cantsavetransientassembly, _claimcannotberemoved, _collectionbackingdictionarytoolarge, _collectionbackinglisttoolarge, _computername, _consolekeyavailableonfile, _consolereadkeyonfile, _constructornotallowedoninterface, _contextalreadyfrozen, _datetimeparsing;
    IMessageDescription? _debuggerlaunchfailed, _defaultconstructordefinebody, _defaultconstructorilgen, _duplicatepropertyname, _emptyqueue, _emptystack, _endinvokecalledmultiple, _endreadcalledmultiple, _endwritecalledmultiple, _entrymethodnotdefinedinassembly;
    IMessageDescription? _enumended, _enumfailedversion, _enumnotstarted, _enumopcanthappen, _eventinfonotavailable, _eventtokentablerequiresdelegate, _genericparametersalreadyset, _getversion, _globalshavebeencreated, _handleisnotinitialized;
    IMessageDescription? _handleisnotpinned, _hashinsertfailed, _icomparerfailed, _internalstate, _invalidcomregfunctionsig, _invalidcomunregfunctionsig, _method, _methodbaked, _methodbuilderbaked, _methodhasbody;
    IMessageDescription? _mismatchedasyncresult, _modificationofnoncanonicalacl, _modifyropermset, _multiplecomregfunctions, _multiplecomunregfunctions, _mustcallinitialize, _mustlockforreadorwrite, _mustlockforwrite, _mustrevertprivilege, _noasmcodebase;
    IMessageDescription? _noasmname, _nonstaticcomregfunction, _nonstaticcomunregfunction, _nopublicaddmethod, _nopublicremovemethod, _nosecuritydescriptor, _notallowedindynamicmethod, _notallowedinreflectiononly, _notavarargcallingconvention, _notgenerictype;
    IMessageDescription? _notnewcapturecontext, _notsupportedonwinrtevent, _notwithconcurrentgc, _nounderlyingtypeonenum, _novalue, _nullarray, _nullcontext, _onlyvalidfords, _openlocalvariablescope, _overlappedpack;
    IMessageDescription? _piamustbestrongnamed, _propertyinfonotavailable, _readonly, _regremovesubkey, _resmgrbadressettype, _resourcenotstreamname, _resourcenotstringname, _resourcenotstringtype, _resourcewritersaved, _setdata;
    IMessageDescription? _setdataonlylocationuri, _setdataonlyonce, _setvolumelabelfailed, _shouldnothavemethodbody, _slothasbeenfreed, _subclassedobject, _timeoutsnotsupported, _typehasbeencreated, _typenotcreated, _underlyingarraylistchanged;
    IMessageDescription? _unknownenumtype, _waitontransparentproxy, _withoutarm, _writeonce, _wrongasyncresultorendcalledmultiple, _wrongasyncresultorendreadcalledmultiple, _wrongasyncresultorendwritecalledmultiple, _exceptionactorgraphcircular, _resourcereaderisclosed, _unknownerror;
    IMessageDescription? _unknownerrornum, _activationargsapptrustmismatch, _asserttransparentcode, _cannotremovefromstackorqueue, _cantcancelctrlbreak, _cantinstantiateabstractclass, _cantinstantiatefunctionpointer, _collectioncorrupted, _criticaltransparentaremutuallyexclusive, _hostmodifiedsecuritystate;
    IMessageDescription? _metadataerror, _modifyronumfmtinfo, _nativeoverlappedreused, _notcurrentdomain, _strongnamekeypairrequired, _switcherctxmismatch, _typecannotbeboxed, _unexpectedwin32error, _userdomainname;
    
    /// <summary>System</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>Type &#39;{0}&#39; was loaded in the ReflectionOnly context but the AssemblyBuilder was not created as AssemblyBuilderAccess.ReflectionOnly.</summary>
    public IMessageDescription ArugmentEmitMixedContext1 { get => _arugmentemitmixedcontext1!; set => this.AssertWritable()._arugmentemitmixedcontext1 = value; }
    /// <summary>Type &#39;{0}&#39; was not loaded in the ReflectionOnly context but the AssemblyBuilder was created as AssemblyBuilderAccess.ReflectionOnly.</summary>
    public IMessageDescription ArugmentEmitMixedContext2 { get => _arugmentemitmixedcontext2!; set => this.AssertWritable()._arugmentemitmixedcontext2 = value; }
    /// <summary>The builder was not properly initialized.</summary>
    public IMessageDescription AsyncMethodBuilderInstanceNotInitialized { get => _asyncmethodbuilderinstancenotinitialized!; set => this.AssertWritable()._asyncmethodbuilderinstancenotinitialized = value; }
    /// <summary>Invalid attempt made to decrement the event&#39;s count below zero.</summary>
    public IMessageDescription CountdownEventDecrementBelowZero { get => _countdowneventdecrementbelowzero!; set => this.AssertWritable()._countdowneventdecrementbelowzero = value; }
    /// <summary>The increment operation would cause the CurrentCount to overflow.</summary>
    public IMessageDescription CountdownEventIncrementAlreadyMax { get => _countdowneventincrementalreadymax!; set => this.AssertWritable()._countdowneventincrementalreadymax = value; }
    /// <summary>The event is already signaled and cannot be incremented.</summary>
    public IMessageDescription CountdownEventIncrementAlreadyZero { get => _countdowneventincrementalreadyzero!; set => this.AssertWritable()._countdowneventincrementalreadyzero = value; }
    /// <summary>Attempted to add properties to a frozen context.</summary>
    public IMessageDescription AddContextFrozen { get => _addcontextfrozen!; set => this.AssertWritable()._addcontextfrozen = value; }
    /// <summary>An anonymous identity cannot perform an impersonation.</summary>
    public IMessageDescription AnonymousCannotImpersonate { get => _anonymouscannotimpersonate!; set => this.AssertWritable()._anonymouscannotimpersonate = value; }
    /// <summary>Failed to set the specified COM apartment state.</summary>
    public IMessageDescription ApartmentStateSwitchFailed { get => _apartmentstateswitchfailed!; set => this.AssertWritable()._apartmentstateswitchfailed = value; }
    /// <summary>The API &#39;{0}&#39; cannot be used on the current platform. See http://go.microsoft.com/fwlink/?LinkId=248273 for more information.</summary>
    public IMessageDescription APIInvalidForCurrentContext { get => _apiinvalidforcurrentcontext!; set => this.AssertWritable()._apiinvalidforcurrentcontext = value; }
    /// <summary>Assembly has been loaded as ReflectionOnly. This API requires an assembly capable of execution.</summary>
    public IMessageDescription AsmLoadedForReflectionOnly { get => _asmloadedforreflectiononly!; set => this.AssertWritable()._asmloadedforreflectiononly = value; }
    /// <summary>Assembly &#39;{0}&#39; has been saved.</summary>
    public IMessageDescription AssemblyHasBeenSaved { get => _assemblyhasbeensaved!; set => this.AssertWritable()._assemblyhasbeensaved = value; }
    /// <summary>AsyncFlowControl objects can be used to restore flow only on the Context that had its flow suppressed.</summary>
    public IMessageDescription AsyncFlowCtrlCtxMismatch { get => _asyncflowctrlctxmismatch!; set => this.AssertWritable()._asyncflowctrlctxmismatch = value; }
    /// <summary>The stream is currently in use by a previous operation on the stream.</summary>
    public IMessageDescription AsyncIOInProgress { get => _asyncioinprogress!; set => this.AssertWritable()._asyncioinprogress = value; }
    /// <summary>Method &#39;{0}&#39; does not have a method body.</summary>
    public IMessageDescription BadEmptyMethodBody { get => _bademptymethodbody!; set => this.AssertWritable()._bademptymethodbody = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription BadILGeneratorUsage { get => _badilgeneratorusage!; set => this.AssertWritable()._badilgeneratorusage = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription BadInstructionOrIndexOutOfBound { get => _badinstructionorindexoutofbound!; set => this.AssertWritable()._badinstructionorindexoutofbound = value; }
    /// <summary>Interface must be declared abstract.</summary>
    public IMessageDescription BadInterfaceNotAbstract { get => _badinterfacenotabstract!; set => this.AssertWritable()._badinterfacenotabstract = value; }
    /// <summary>Method &#39;{0}&#39; cannot have a method body.</summary>
    public IMessageDescription BadMethodBody { get => _badmethodbody!; set => this.AssertWritable()._badmethodbody = value; }
    /// <summary>Unable to add resource to transient module or transient assembly.</summary>
    public IMessageDescription BadResourceContainer { get => _badresourcecontainer!; set => this.AssertWritable()._badresourcecontainer = value; }
    /// <summary>Type must be declared abstract if any of its methods are abstract.</summary>
    public IMessageDescription BadTypeAttributesNotAbstract { get => _badtypeattributesnotabstract!; set => this.AssertWritable()._badtypeattributesnotabstract = value; }
    /// <summary>The method cannot be called twice on the same instance.</summary>
    public IMessageDescription CalledTwice { get => _calledtwice!; set => this.AssertWritable()._calledtwice = value; }
    /// <summary>Unable to alter assembly information.</summary>
    public IMessageDescription CannotAlterAssembly { get => _cannotalterassembly!; set => this.AssertWritable()._cannotalterassembly = value; }
    /// <summary>Only newly captured contexts can be copied</summary>
    public IMessageDescription CannotCopyUsedContext { get => _cannotcopyusedcontext!; set => this.AssertWritable()._cannotcopyusedcontext = value; }
    /// <summary>Must override both HostExecutionContextManager.SetHostExecutionContext and HostExecutionContextManager.Revert.</summary>
    public IMessageDescription CannotOverrideSetWithoutRevert { get => _cannotoverridesetwithoutrevert!; set => this.AssertWritable()._cannotoverridesetwithoutrevert = value; }
    /// <summary>Cannot remove the last element from an empty collection.</summary>
    public IMessageDescription CannotRemoveLastFromEmptyCollection { get => _cannotremovelastfromemptycollection!; set => this.AssertWritable()._cannotremovelastfromemptycollection = value; }
    /// <summary>Cannot restore context flow when it is not suppressed.</summary>
    public IMessageDescription CannotRestoreUnsupressedFlow { get => _cannotrestoreunsupressedflow!; set => this.AssertWritable()._cannotrestoreunsupressedflow = value; }
    /// <summary>Context flow is already suppressed.</summary>
    public IMessageDescription CannotSupressFlowMultipleTimes { get => _cannotsupressflowmultipletimes!; set => this.AssertWritable()._cannotsupressflowmultipletimes = value; }
    /// <summary>AsyncFlowControl object can be used only once to call Undo().</summary>
    public IMessageDescription CannotUseAFCMultiple { get => _cannotuseafcmultiple!; set => this.AssertWritable()._cannotuseafcmultiple = value; }
    /// <summary>Cannot save a transient assembly.</summary>
    public IMessageDescription CantSaveTransientAssembly { get => _cantsavetransientassembly!; set => this.AssertWritable()._cantsavetransientassembly = value; }
    /// <summary>The Claim &#39;{0}&#39; was not able to be removed. It is either not part of this Identity or it is a claim that is owned by the Principal that contains this Identity. For example, the Principal will own the claim when creating a GenericPrincipal with roles. The roles will be exposed through the Identity that is passed in the constructor, but not actually owned by the Identity. Similar logic exists for a RolePrincipal.</summary>
    public IMessageDescription ClaimCannotBeRemoved { get => _claimcannotberemoved!; set => this.AssertWritable()._claimcannotberemoved = value; }
    /// <summary>The collection backing this Dictionary contains too many elements.</summary>
    public IMessageDescription CollectionBackingDictionaryTooLarge { get => _collectionbackingdictionarytoolarge!; set => this.AssertWritable()._collectionbackingdictionarytoolarge = value; }
    /// <summary>The collection backing this List contains too many elements.</summary>
    public IMessageDescription CollectionBackingListTooLarge { get => _collectionbackinglisttoolarge!; set => this.AssertWritable()._collectionbackinglisttoolarge = value; }
    /// <summary>Computer name could not be obtained.</summary>
    public IMessageDescription ComputerName { get => _computername!; set => this.AssertWritable()._computername = value; }
    /// <summary>Cannot see if a key has been pressed when either application does not have a console or when console input has been redirected from a file. Try Console.In.Peek.</summary>
    public IMessageDescription ConsoleKeyAvailableOnFile { get => _consolekeyavailableonfile!; set => this.AssertWritable()._consolekeyavailableonfile = value; }
    /// <summary>Cannot read keys when either application does not have a console or when console input has been redirected from a file. Try Console.Read.</summary>
    public IMessageDescription ConsoleReadKeyOnFile { get => _consolereadkeyonfile!; set => this.AssertWritable()._consolereadkeyonfile = value; }
    /// <summary>Interface cannot have constructors.</summary>
    public IMessageDescription ConstructorNotAllowedOnInterface { get => _constructornotallowedoninterface!; set => this.AssertWritable()._constructornotallowedoninterface = value; }
    /// <summary>Context is already frozen.</summary>
    public IMessageDescription ContextAlreadyFrozen { get => _contextalreadyfrozen!; set => this.AssertWritable()._contextalreadyfrozen = value; }
    /// <summary>Internal Error in DateTime and Calendar operations.</summary>
    public IMessageDescription DateTimeParsing { get => _datetimeparsing!; set => this.AssertWritable()._datetimeparsing = value; }
    /// <summary>Debugger unable to launch.</summary>
    public IMessageDescription DebuggerLaunchFailed { get => _debuggerlaunchfailed!; set => this.AssertWritable()._debuggerlaunchfailed = value; }
    /// <summary>The method body of the default constructor cannot be changed.</summary>
    public IMessageDescription DefaultConstructorDefineBody { get => _defaultconstructordefinebody!; set => this.AssertWritable()._defaultconstructordefinebody = value; }
    /// <summary>Unable to access ILGenerator on a constructor created with DefineDefaultConstructor.</summary>
    public IMessageDescription DefaultConstructorILGen { get => _defaultconstructorilgen!; set => this.AssertWritable()._defaultconstructorilgen = value; }
    /// <summary>Another property by this name already exists.</summary>
    public IMessageDescription DuplicatePropertyName { get => _duplicatepropertyname!; set => this.AssertWritable()._duplicatepropertyname = value; }
    /// <summary>Queue empty.</summary>
    public IMessageDescription EmptyQueue { get => _emptyqueue!; set => this.AssertWritable()._emptyqueue = value; }
    /// <summary>Stack empty.</summary>
    public IMessageDescription EmptyStack { get => _emptystack!; set => this.AssertWritable()._emptystack = value; }
    /// <summary>EndInvoke can only be called once for each asynchronous operation.</summary>
    public IMessageDescription EndInvokeCalledMultiple { get => _endinvokecalledmultiple!; set => this.AssertWritable()._endinvokecalledmultiple = value; }
    /// <summary>EndRead can only be called once for each asynchronous operation.</summary>
    public IMessageDescription EndReadCalledMultiple { get => _endreadcalledmultiple!; set => this.AssertWritable()._endreadcalledmultiple = value; }
    /// <summary>EndWrite can only be called once for each asynchronous operation.</summary>
    public IMessageDescription EndWriteCalledMultiple { get => _endwritecalledmultiple!; set => this.AssertWritable()._endwritecalledmultiple = value; }
    /// <summary>Entry method is not defined in the same assembly.</summary>
    public IMessageDescription EntryMethodNotDefinedInAssembly { get => _entrymethodnotdefinedinassembly!; set => this.AssertWritable()._entrymethodnotdefinedinassembly = value; }
    /// <summary>Enumeration already finished.</summary>
    public IMessageDescription EnumEnded { get => _enumended!; set => this.AssertWritable()._enumended = value; }
    /// <summary>Collection was modified; enumeration operation may not execute.</summary>
    public IMessageDescription EnumFailedVersion { get => _enumfailedversion!; set => this.AssertWritable()._enumfailedversion = value; }
    /// <summary>Enumeration has not started. Call MoveNext.</summary>
    public IMessageDescription EnumNotStarted { get => _enumnotstarted!; set => this.AssertWritable()._enumnotstarted = value; }
    /// <summary>Enumeration has either not started or has already finished.</summary>
    public IMessageDescription EnumOpCantHappen { get => _enumopcanthappen!; set => this.AssertWritable()._enumopcanthappen = value; }
    /// <summary>This API does not support EventInfo tokens.</summary>
    public IMessageDescription EventInfoNotAvailable { get => _eventinfonotavailable!; set => this.AssertWritable()._eventinfonotavailable = value; }
    /// <summary>Type &#39;{0}&#39; is not a delegate type. EventTokenTable may only be used with delegate types.</summary>
    public IMessageDescription EventTokenTableRequiresDelegate { get => _eventtokentablerequiresdelegate!; set => this.AssertWritable()._eventtokentablerequiresdelegate = value; }
    /// <summary>The generic parameters are already defined on this MethodBuilder.</summary>
    public IMessageDescription GenericParametersAlreadySet { get => _genericparametersalreadyset!; set => this.AssertWritable()._genericparametersalreadyset = value; }
    /// <summary>OSVersion&#39;s call to GetVersionEx failed.</summary>
    public IMessageDescription GetVersion { get => _getversion!; set => this.AssertWritable()._getversion = value; }
    /// <summary>Type definition of the global function has been completed.</summary>
    public IMessageDescription GlobalsHaveBeenCreated { get => _globalshavebeencreated!; set => this.AssertWritable()._globalshavebeencreated = value; }
    /// <summary>Handle is not initialized.</summary>
    public IMessageDescription HandleIsNotInitialized { get => _handleisnotinitialized!; set => this.AssertWritable()._handleisnotinitialized = value; }
    /// <summary>Handle is not pinned.</summary>
    public IMessageDescription HandleIsNotPinned { get => _handleisnotpinned!; set => this.AssertWritable()._handleisnotpinned = value; }
    /// <summary>Hashtable insert failed. Load factor too high. The most common cause is multiple threads writing to the Hashtable simultaneously.</summary>
    public IMessageDescription HashInsertFailed { get => _hashinsertfailed!; set => this.AssertWritable()._hashinsertfailed = value; }
    /// <summary>Failed to compare two elements in the array.</summary>
    public IMessageDescription IComparerFailed { get => _icomparerfailed!; set => this.AssertWritable()._icomparerfailed = value; }
    /// <summary>Invalid internal state.</summary>
    public IMessageDescription InternalState { get => _internalstate!; set => this.AssertWritable()._internalstate = value; }
    /// <summary>COM register function must have a System.Type parameter and a void return type.</summary>
    public IMessageDescription InvalidComRegFunctionSig { get => _invalidcomregfunctionsig!; set => this.AssertWritable()._invalidcomregfunctionsig = value; }
    /// <summary>COM unregister function must have a System.Type parameter and a void return type.</summary>
    public IMessageDescription InvalidComUnRegFunctionSig { get => _invalidcomunregfunctionsig!; set => this.AssertWritable()._invalidcomunregfunctionsig = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription Method { get => _method!; set => this.AssertWritable()._method = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription MethodBaked { get => _methodbaked!; set => this.AssertWritable()._methodbaked = value; }
    /// <summary>The signature of the MethodBuilder can no longer be modified because an operation on the MethodBuilder caused the methodDef token to be created. For example, a call to SetCustomAttribute requires the methodDef token to emit the CustomAttribute token.</summary>
    public IMessageDescription MethodBuilderBaked { get => _methodbuilderbaked!; set => this.AssertWritable()._methodbuilderbaked = value; }
    /// <summary>Method already has a body.</summary>
    public IMessageDescription MethodHasBody { get => _methodhasbody!; set => this.AssertWritable()._methodhasbody = value; }
    /// <summary>The IAsyncResult object provided does not match this delegate.</summary>
    public IMessageDescription MismatchedAsyncResult { get => _mismatchedasyncresult!; set => this.AssertWritable()._mismatchedasyncresult = value; }
    /// <summary>This access control list is not in canonical form and therefore cannot be modified.</summary>
    public IMessageDescription ModificationOfNonCanonicalAcl { get => _modificationofnoncanonicalacl!; set => this.AssertWritable()._modificationofnoncanonicalacl = value; }
    /// <summary>ReadOnlyPermissionSet objects may not be modified.</summary>
    public IMessageDescription ModifyROPermSet { get => _modifyropermset!; set => this.AssertWritable()._modifyropermset = value; }
    /// <summary>Type &#39;{0}&#39; has more than one COM registration function.</summary>
    public IMessageDescription MultipleComRegFunctions { get => _multiplecomregfunctions!; set => this.AssertWritable()._multiplecomregfunctions = value; }
    /// <summary>Type &#39;{0}&#39; has more than one COM unregistration function.</summary>
    public IMessageDescription MultipleComUnRegFunctions { get => _multiplecomunregfunctions!; set => this.AssertWritable()._multiplecomunregfunctions = value; }
    /// <summary>You must call Initialize on this object instance before using it.</summary>
    public IMessageDescription MustCallInitialize { get => _mustcallinitialize!; set => this.AssertWritable()._mustcallinitialize = value; }
    /// <summary>Object must be locked for read or write.</summary>
    public IMessageDescription MustLockForReadOrWrite { get => _mustlockforreadorwrite!; set => this.AssertWritable()._mustlockforreadorwrite = value; }
    /// <summary>Object must be locked for read.</summary>
    public IMessageDescription MustLockForWrite { get => _mustlockforwrite!; set => this.AssertWritable()._mustlockforwrite = value; }
    /// <summary>Must revert the privilege prior to attempting this operation.</summary>
    public IMessageDescription MustRevertPrivilege { get => _mustrevertprivilege!; set => this.AssertWritable()._mustrevertprivilege = value; }
    /// <summary>Assembly does not have a code base.</summary>
    public IMessageDescription NoAsmCodeBase { get => _noasmcodebase!; set => this.AssertWritable()._noasmcodebase = value; }
    /// <summary>Assembly does not have an assembly name. In order to be registered for use by COM, an assembly must have a valid assembly name.</summary>
    public IMessageDescription NoAsmName { get => _noasmname!; set => this.AssertWritable()._noasmname = value; }
    /// <summary>COM register function must be static.</summary>
    public IMessageDescription NonStaticComRegFunction { get => _nonstaticcomregfunction!; set => this.AssertWritable()._nonstaticcomregfunction = value; }
    /// <summary>COM unregister function must be static.</summary>
    public IMessageDescription NonStaticComUnRegFunction { get => _nonstaticcomunregfunction!; set => this.AssertWritable()._nonstaticcomunregfunction = value; }
    /// <summary>Cannot add the event handler since no public add method exists for the event.</summary>
    public IMessageDescription NoPublicAddMethod { get => _nopublicaddmethod!; set => this.AssertWritable()._nopublicaddmethod = value; }
    /// <summary>Cannot remove the event handler since no public remove method exists for the event.</summary>
    public IMessageDescription NoPublicRemoveMethod { get => _nopublicremovemethod!; set => this.AssertWritable()._nopublicremovemethod = value; }
    /// <summary>The object does not contain a security descriptor.</summary>
    public IMessageDescription NoSecurityDescriptor { get => _nosecuritydescriptor!; set => this.AssertWritable()._nosecuritydescriptor = value; }
    /// <summary>The requested operation is invalid for DynamicMethod.</summary>
    public IMessageDescription NotAllowedInDynamicMethod { get => _notallowedindynamicmethod!; set => this.AssertWritable()._notallowedindynamicmethod = value; }
    /// <summary>The requested operation is invalid in the ReflectionOnly context.</summary>
    public IMessageDescription NotAllowedInReflectionOnly { get => _notallowedinreflectiononly!; set => this.AssertWritable()._notallowedinreflectiononly = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription NotAVarArgCallingConvention { get => _notavarargcallingconvention!; set => this.AssertWritable()._notavarargcallingconvention = value; }
    /// <summary>This operation is only valid on generic types.</summary>
    public IMessageDescription NotGenericType { get => _notgenerictype!; set => this.AssertWritable()._notgenerictype = value; }
    /// <summary>Cannot apply a context that has been marshaled across AppDomains, that was not acquired through a Capture operation or that has already been the argument to a Set call.</summary>
    public IMessageDescription NotNewCaptureContext { get => _notnewcapturecontext!; set => this.AssertWritable()._notnewcapturecontext = value; }
    /// <summary>Adding or removing event handlers dynamically is not supported on WinRT events.</summary>
    public IMessageDescription NotSupportedOnWinRTEvent { get => _notsupportedonwinrtevent!; set => this.AssertWritable()._notsupportedonwinrtevent = value; }
    /// <summary>This API is not available when the concurrent GC is enabled.</summary>
    public IMessageDescription NotWithConcurrentGC { get => _notwithconcurrentgc!; set => this.AssertWritable()._notwithconcurrentgc = value; }
    /// <summary>Underlying type information on enumeration is not specified.</summary>
    public IMessageDescription NoUnderlyingTypeOnEnum { get => _nounderlyingtypeonenum!; set => this.AssertWritable()._nounderlyingtypeonenum = value; }
    /// <summary>Nullable object must have a value.</summary>
    public IMessageDescription NoValue { get => _novalue!; set => this.AssertWritable()._novalue = value; }
    /// <summary>The underlying array is null.</summary>
    public IMessageDescription NullArray { get => _nullarray!; set => this.AssertWritable()._nullarray = value; }
    /// <summary>Cannot call Set on a null context</summary>
    public IMessageDescription NullContext { get => _nullcontext!; set => this.AssertWritable()._nullcontext = value; }
    /// <summary>Adding ACEs with Object Flags and Object GUIDs is only valid for directory-object ACLs.</summary>
    public IMessageDescription OnlyValidForDS { get => _onlyvalidfords!; set => this.AssertWritable()._onlyvalidfords = value; }
    /// <summary>Local variable scope was not properly closed.</summary>
    public IMessageDescription OpenLocalVariableScope { get => _openlocalvariablescope!; set => this.AssertWritable()._openlocalvariablescope = value; }
    /// <summary>Cannot pack a packed Overlapped again.</summary>
    public IMessageDescription OverlappedPack { get => _overlappedpack!; set => this.AssertWritable()._overlappedpack = value; }
    /// <summary>Primary interop assemblies must be strongly named.</summary>
    public IMessageDescription PIAMustBeStrongNamed { get => _piamustbestrongnamed!; set => this.AssertWritable()._piamustbestrongnamed = value; }
    /// <summary>This API does not support PropertyInfo tokens.</summary>
    public IMessageDescription PropertyInfoNotAvailable { get => _propertyinfonotavailable!; set => this.AssertWritable()._propertyinfonotavailable = value; }
    /// <summary>Instance is read-only.</summary>
    public IMessageDescription ReadOnly { get => _readonly!; set => this.AssertWritable()._readonly = value; }
    /// <summary>Registry key has subkeys and recursive removes are not supported by this method.</summary>
    public IMessageDescription RegRemoveSubKey { get => _regremovesubkey!; set => this.AssertWritable()._regremovesubkey = value; }
    /// <summary>&#39;{0}&#39;: ResourceSet derived classes must provide a constructor that takes a String file name and a constructor that takes a Stream.</summary>
    public IMessageDescription ResMgrBadResSetType { get => _resmgrbadressettype!; set => this.AssertWritable()._resmgrbadressettype = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription ResourceNotStreamName { get => _resourcenotstreamname!; set => this.AssertWritable()._resourcenotstreamname = value; }
    /// <summary>Resource &#39;{0}&#39; was not a String - call GetObject instead.</summary>
    public IMessageDescription ResourceNotStringName { get => _resourcenotstringname!; set => this.AssertWritable()._resourcenotstringname = value; }
    /// <summary>Resource was of type &#39;{0}&#39; instead of String - call GetObject instead.</summary>
    public IMessageDescription ResourceNotStringType { get => _resourcenotstringtype!; set => this.AssertWritable()._resourcenotstringtype = value; }
    /// <summary>The resource writer has already been closed and cannot be edited.</summary>
    public IMessageDescription ResourceWriterSaved { get => _resourcewritersaved!; set => this.AssertWritable()._resourcewritersaved = value; }
    /// <summary>An additional permission should not be supplied for setting loader information.</summary>
    public IMessageDescription SetData { get => _setdata!; set => this.AssertWritable()._setdata = value; }
    /// <summary>SetData cannot be used to set the value for &#39;{0}&#39;.</summary>
    public IMessageDescription SetDataOnlyLocationURI { get => _setdataonlylocationuri!; set => this.AssertWritable()._setdataonlylocationuri = value; }
    /// <summary>SetData can only be used to set the value of a given name once.</summary>
    public IMessageDescription SetDataOnlyOnce { get => _setdataonlyonce!; set => this.AssertWritable()._setdataonlyonce = value; }
    /// <summary>Volume labels can only be set for writable local volumes.</summary>
    public IMessageDescription SetVolumeLabelFailed { get => _setvolumelabelfailed!; set => this.AssertWritable()._setvolumelabelfailed = value; }
    /// <summary>Method body should not exist.</summary>
    public IMessageDescription ShouldNotHaveMethodBody { get => _shouldnothavemethodbody!; set => this.AssertWritable()._shouldnothavemethodbody = value; }
    /// <summary>LocalDataStoreSlot storage has been freed.</summary>
    public IMessageDescription SlotHasBeenFreed { get => _slothasbeenfreed!; set => this.AssertWritable()._slothasbeenfreed = value; }
    /// <summary>Cannot set sub-classed {0} object to {1} object.</summary>
    public IMessageDescription SubclassedObject { get => _subclassedobject!; set => this.AssertWritable()._subclassedobject = value; }
    /// <summary>Timeouts are not supported on this stream.</summary>
    public IMessageDescription TimeoutsNotSupported { get => _timeoutsnotsupported!; set => this.AssertWritable()._timeoutsnotsupported = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription TypeHasBeenCreated { get => _typehasbeencreated!; set => this.AssertWritable()._typehasbeencreated = value; }
    /// <summary>Type has not been created.</summary>
    public IMessageDescription TypeNotCreated { get => _typenotcreated!; set => this.AssertWritable()._typenotcreated = value; }
    /// <summary>This range in the underlying list is invalid. A possible cause is that elements were removed.</summary>
    public IMessageDescription UnderlyingArrayListChanged { get => _underlyingarraylistchanged!; set => this.AssertWritable()._underlyingarraylistchanged = value; }
    /// <summary>Unknown enum type.</summary>
    public IMessageDescription UnknownEnumType { get => _unknownenumtype!; set => this.AssertWritable()._unknownenumtype = value; }
    /// <summary>Cannot wait on a transparent proxy.</summary>
    public IMessageDescription WaitOnTransparentProxy { get => _waitontransparentproxy!; set => this.AssertWritable()._waitontransparentproxy = value; }
    /// <summary>This API is not available when AppDomain Resource Monitoring is not turned on.</summary>
    public IMessageDescription WithoutARM { get => _withoutarm!; set => this.AssertWritable()._withoutarm = value; }
    /// <summary>This property has already been set and cannot be modified.</summary>
    public IMessageDescription WriteOnce { get => _writeonce!; set => this.AssertWritable()._writeonce = value; }
    /// <summary>Either the IAsyncResult object did not come from the corresponding async method on this type, or the End method was called multiple times with the same IAsyncResult.</summary>
    public IMessageDescription WrongAsyncResultOrEndCalledMultiple { get => _wrongasyncresultorendcalledmultiple!; set => this.AssertWritable()._wrongasyncresultorendcalledmultiple = value; }
    /// <summary>Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.</summary>
    public IMessageDescription WrongAsyncResultOrEndReadCalledMultiple { get => _wrongasyncresultorendreadcalledmultiple!; set => this.AssertWritable()._wrongasyncresultorendreadcalledmultiple = value; }
    /// <summary>Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.</summary>
    public IMessageDescription WrongAsyncResultOrEndWriteCalledMultiple { get => _wrongasyncresultorendwritecalledmultiple!; set => this.AssertWritable()._wrongasyncresultorendwritecalledmultiple = value; }
    /// <summary>Actor cannot be set so that circular directed graph will exist chaining the subjects together.</summary>
    public IMessageDescription ExceptionActorGraphCircular { get => _exceptionactorgraphcircular!; set => this.AssertWritable()._exceptionactorgraphcircular = value; }
    /// <summary>ResourceReader is closed.</summary>
    public IMessageDescription ResourceReaderIsClosed { get => _resourcereaderisclosed!; set => this.AssertWritable()._resourcereaderisclosed = value; }
    /// <summary>System.Security.Cryptography</summary>
    public IMessageDescription UnknownError { get => _unknownerror!; set => this.AssertWritable()._unknownerror = value; }
    /// <summary>Unknown error &quot;{0}&quot;.</summary>
    public IMessageDescription UnknownErrorNum { get => _unknownerrornum!; set => this.AssertWritable()._unknownerrornum = value; }
    /// <summary>The activation arguments and application trust for the AppDomain must correspond to the same application identity.</summary>
    public IMessageDescription ActivationArgsAppTrustMismatch { get => _activationargsapptrustmismatch!; set => this.AssertWritable()._activationargsapptrustmismatch = value; }
    /// <summary>Cannot perform CAS Asserts in Security Transparent methods</summary>
    public IMessageDescription AssertTransparentCode { get => _asserttransparentcode!; set => this.AssertWritable()._asserttransparentcode = value; }
    /// <summary>Removal is an invalid operation for Stack or Queue.</summary>
    public IMessageDescription CannotRemoveFromStackOrQueue { get => _cannotremovefromstackorqueue!; set => this.AssertWritable()._cannotremovefromstackorqueue = value; }
    /// <summary>Applications may not prevent control-break from terminating their process.</summary>
    public IMessageDescription CantCancelCtrlBreak { get => _cantcancelctrlbreak!; set => this.AssertWritable()._cantcancelctrlbreak = value; }
    /// <summary>Instances of abstract classes cannot be created.</summary>
    public IMessageDescription CantInstantiateAbstractClass { get => _cantinstantiateabstractclass!; set => this.AssertWritable()._cantinstantiateabstractclass = value; }
    /// <summary>Instances of function pointers cannot be created.</summary>
    public IMessageDescription CantInstantiateFunctionPointer { get => _cantinstantiatefunctionpointer!; set => this.AssertWritable()._cantinstantiatefunctionpointer = value; }
    /// <summary>A prior operation on this collection was interrupted by an exception. Collection&#39;s state is no longer trusted.</summary>
    public IMessageDescription CollectionCorrupted { get => _collectioncorrupted!; set => this.AssertWritable()._collectioncorrupted = value; }
    /// <summary>SecurityTransparent and SecurityCritical attributes cannot be applied to the assembly scope at the same time.</summary>
    public IMessageDescription CriticalTransparentAreMutuallyExclusive { get => _criticaltransparentaremutuallyexclusive!; set => this.AssertWritable()._criticaltransparentaremutuallyexclusive = value; }
    /// <summary>The security state of an AppDomain was modified by an AppDomainManager configured with the NoSecurityChanges flag.</summary>
    public IMessageDescription HostModifiedSecurityState { get => _hostmodifiedsecuritystate!; set => this.AssertWritable()._hostmodifiedsecuritystate = value; }
    /// <summary>Metadata operation failed.</summary>
    public IMessageDescription MetaDataError { get => _metadataerror!; set => this.AssertWritable()._metadataerror = value; }
    /// <summary>Unable to modify a read-only NumberFormatInfo object.</summary>
    public IMessageDescription ModifyRONumFmtInfo { get => _modifyronumfmtinfo!; set => this.AssertWritable()._modifyronumfmtinfo = value; }
    /// <summary>NativeOverlapped cannot be reused for multiple operations.</summary>
    public IMessageDescription NativeOverlappedReused { get => _nativeoverlappedreused!; set => this.AssertWritable()._nativeoverlappedreused = value; }
    /// <summary>You can only define a dynamic assembly on the current AppDomain.</summary>
    public IMessageDescription NotCurrentDomain { get => _notcurrentdomain!; set => this.AssertWritable()._notcurrentdomain = value; }
    /// <summary>A strong name key pair is required to emit a strong-named dynamic assembly.</summary>
    public IMessageDescription StrongNameKeyPairRequired { get => _strongnamekeypairrequired!; set => this.AssertWritable()._strongnamekeypairrequired = value; }
    /// <summary>The Undo operation encountered a context that is different from what was applied in the corresponding Set operation. The possible cause is that a context was Set on the thread and not reverted(undone).</summary>
    public IMessageDescription SwitcherCtxMismatch { get => _switcherctxmismatch!; set => this.AssertWritable()._switcherctxmismatch = value; }
    /// <summary>The given type cannot be boxed.</summary>
    public IMessageDescription TypeCannotBeBoxed { get => _typecannotbeboxed!; set => this.AssertWritable()._typecannotbeboxed = value; }
    /// <summary>Unexpected error when calling an operating system function. The returned error code is 0x{0:x}.</summary>
    public IMessageDescription UnexpectedWin32Error { get => _unexpectedwin32error!; set => this.AssertWritable()._unexpectedwin32error = value; }
    /// <summary>UserDomainName native call failed.</summary>
    public IMessageDescription UserDomainName { get => _userdomainname!; set => this.AssertWritable()._userdomainname = value; }

    /// <summary>Initialize fields</summary>
    public override InvalidOperationMessages Initialize() 
    {
        base.Initialize();
        Add(_exception = new MessageDescription("mscorlib.Arg_InvalidOperationException", 0xA345007F, new ParameterlessText("Operation is not valid due to the current state of the object.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.InvalidOperationException)));
        Add(_arugmentemitmixedcontext1 = new MessageDescription("mscorlib.Arugment_EmitMixedContext1", 0xA34502D7, new FormatText("Type '{0}' was loaded in the ReflectionOnly context but the AssemblyBuilder was not created as AssemblyBuilderAccess.ReflectionOnly.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_arugmentemitmixedcontext2 = new MessageDescription("mscorlib.Arugment_EmitMixedContext2", 0xA34502D8, new FormatText("Type '{0}' was not loaded in the ReflectionOnly context but the AssemblyBuilder was created as AssemblyBuilderAccess.ReflectionOnly.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_asyncmethodbuilderinstancenotinitialized = new MessageDescription("mscorlib.AsyncMethodBuilder_InstanceNotInitialized", 0xA34502DB, new ParameterlessText("The builder was not properly initialized.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_countdowneventdecrementbelowzero = new MessageDescription("mscorlib.CountdownEvent_Decrement_BelowZero", 0xA34502FA, new ParameterlessText("Invalid attempt made to decrement the event's count below zero.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_countdowneventincrementalreadymax = new MessageDescription("mscorlib.CountdownEvent_Increment_AlreadyMax", 0xA34502FB, new ParameterlessText("The increment operation would cause the CurrentCount to overflow.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_countdowneventincrementalreadyzero = new MessageDescription("mscorlib.CountdownEvent_Increment_AlreadyZero", 0xA34502FC, new ParameterlessText("The event is already signaled and cannot be incremented.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_addcontextfrozen = new MessageDescription("mscorlib.InvalidOperation_AddContextFrozen", 0xA3450382, new ParameterlessText("Attempted to add properties to a frozen context.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_anonymouscannotimpersonate = new MessageDescription("mscorlib.InvalidOperation_AnonymousCannotImpersonate", 0xA3450383, new ParameterlessText("An anonymous identity cannot perform an impersonation.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_apartmentstateswitchfailed = new MessageDescription("mscorlib.InvalidOperation_ApartmentStateSwitchFailed", 0xA3450384, new ParameterlessText("Failed to set the specified COM apartment state.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_apiinvalidforcurrentcontext = new MessageDescription("mscorlib.InvalidOperation_APIInvalidForCurrentContext", 0xA3450385, new FormatText("The API '{0}' cannot be used on the current platform. See http://go.microsoft.com/fwlink/?LinkId=248273 for more information.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_asmloadedforreflectiononly = new MessageDescription("mscorlib.InvalidOperation_AsmLoadedForReflectionOnly", 0xA3450387, new ParameterlessText("Assembly has been loaded as ReflectionOnly. This API requires an assembly capable of execution.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_assemblyhasbeensaved = new MessageDescription("mscorlib.InvalidOperation_AssemblyHasBeenSaved", 0xA3450388, new FormatText("Assembly '{0}' has been saved.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_asyncflowctrlctxmismatch = new MessageDescription("mscorlib.InvalidOperation_AsyncFlowCtrlCtxMismatch", 0xA3450389, new ParameterlessText("AsyncFlowControl objects can be used to restore flow only on the Context that had its flow suppressed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_asyncioinprogress = new MessageDescription("mscorlib.InvalidOperation_AsyncIOInProgress", 0xA345038A, new ParameterlessText("The stream is currently in use by a previous operation on the stream.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_bademptymethodbody = new MessageDescription("mscorlib.InvalidOperation_BadEmptyMethodBody", 0xA345038B, new FormatText("Method '{0}' does not have a method body.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_badilgeneratorusage = new MessageDescription("mscorlib.InvalidOperation_BadILGeneratorUsage", 0xA345038C, new ParameterlessText("ILGenerator usage is invalid.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_badinstructionorindexoutofbound = new MessageDescription("mscorlib.InvalidOperation_BadInstructionOrIndexOutOfBound", 0xA345038D, new ParameterlessText("MSIL instruction is invalid or index is out of bounds.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_badinterfacenotabstract = new MessageDescription("mscorlib.InvalidOperation_BadInterfaceNotAbstract", 0xA345038E, new ParameterlessText("Interface must be declared abstract.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_badmethodbody = new MessageDescription("mscorlib.InvalidOperation_BadMethodBody", 0xA345038F, new FormatText("Method '{0}' cannot have a method body.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_badresourcecontainer = new MessageDescription("mscorlib.InvalidOperation_BadResourceContainer", 0xA3450390, new ParameterlessText("Unable to add resource to transient module or transient assembly.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_badtypeattributesnotabstract = new MessageDescription("mscorlib.InvalidOperation_BadTypeAttributesNotAbstract", 0xA3450392, new ParameterlessText("Type must be declared abstract if any of its methods are abstract.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_calledtwice = new MessageDescription("mscorlib.InvalidOperation_CalledTwice", 0xA3450393, new ParameterlessText("The method cannot be called twice on the same instance.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotalterassembly = new MessageDescription("mscorlib.InvalidOperation_CannotAlterAssembly", 0xA3450394, new ParameterlessText("Unable to alter assembly information.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotcopyusedcontext = new MessageDescription("mscorlib.InvalidOperation_CannotCopyUsedContext", 0xA3450395, new ParameterlessText("Only newly captured contexts can be copied")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotoverridesetwithoutrevert = new MessageDescription("mscorlib.InvalidOperation_CannotOverrideSetWithoutRevert", 0xA3450397, new ParameterlessText("Must override both HostExecutionContextManager.SetHostExecutionContext and HostExecutionContextManager.Revert.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotremovelastfromemptycollection = new MessageDescription("mscorlib.InvalidOperation_CannotRemoveLastFromEmptyCollection", 0xA3450398, new ParameterlessText("Cannot remove the last element from an empty collection.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotrestoreunsupressedflow = new MessageDescription("mscorlib.InvalidOperation_CannotRestoreUnsupressedFlow", 0xA3450399, new ParameterlessText("Cannot restore context flow when it is not suppressed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotsupressflowmultipletimes = new MessageDescription("mscorlib.InvalidOperation_CannotSupressFlowMultipleTimes", 0xA345039A, new ParameterlessText("Context flow is already suppressed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotuseafcmultiple = new MessageDescription("mscorlib.InvalidOperation_CannotUseAFCMultiple", 0xA345039B, new ParameterlessText("AsyncFlowControl object can be used only once to call Undo().")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cantsavetransientassembly = new MessageDescription("mscorlib.InvalidOperation_CantSaveTransientAssembly", 0xA345039E, new ParameterlessText("Cannot save a transient assembly.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_claimcannotberemoved = new MessageDescription("mscorlib.InvalidOperation_ClaimCannotBeRemoved", 0xA345039F, new FormatText("The Claim '{0}' was not able to be removed.  It is either not part of this Identity or it is a claim that is owned by the Principal that contains this Identity. For example, the Principal will own the claim when creating a GenericPrincipal with roles. The roles will be exposed through the Identity that is passed in the constructor, but not actually owned by the Identity.  Similar logic exists for a RolePrincipal.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_collectionbackingdictionarytoolarge = new MessageDescription("mscorlib.InvalidOperation_CollectionBackingDictionaryTooLarge", 0xA34503A0, new ParameterlessText("The collection backing this Dictionary contains too many elements.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_collectionbackinglisttoolarge = new MessageDescription("mscorlib.InvalidOperation_CollectionBackingListTooLarge", 0xA34503A1, new ParameterlessText("The collection backing this List contains too many elements.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_computername = new MessageDescription("mscorlib.InvalidOperation_ComputerName", 0xA34503A2, new ParameterlessText("Computer name could not be obtained.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_consolekeyavailableonfile = new MessageDescription("mscorlib.InvalidOperation_ConsoleKeyAvailableOnFile", 0xA34503A3, new ParameterlessText("Cannot see if a key has been pressed when either application does not have a console or when console input has been redirected from a file. Try Console.In.Peek.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_consolereadkeyonfile = new MessageDescription("mscorlib.InvalidOperation_ConsoleReadKeyOnFile", 0xA34503A4, new ParameterlessText("Cannot read keys when either application does not have a console or when console input has been redirected from a file. Try Console.Read.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_constructornotallowedoninterface = new MessageDescription("mscorlib.InvalidOperation_ConstructorNotAllowedOnInterface", 0xA34503A5, new ParameterlessText("Interface cannot have constructors.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_contextalreadyfrozen = new MessageDescription("mscorlib.InvalidOperation_ContextAlreadyFrozen", 0xA34503A6, new ParameterlessText("Context is already frozen.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_datetimeparsing = new MessageDescription("mscorlib.InvalidOperation_DateTimeParsing", 0xA34503A7, new ParameterlessText("Internal Error in DateTime and Calendar operations.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_debuggerlaunchfailed = new MessageDescription("mscorlib.InvalidOperation_DebuggerLaunchFailed", 0xA34503A8, new ParameterlessText("Debugger unable to launch.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_defaultconstructordefinebody = new MessageDescription("mscorlib.InvalidOperation_DefaultConstructorDefineBody", 0xA34503A9, new ParameterlessText("The method body of the default constructor cannot be changed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_defaultconstructorilgen = new MessageDescription("mscorlib.InvalidOperation_DefaultConstructorILGen", 0xA34503AA, new ParameterlessText("Unable to access ILGenerator on a constructor created with DefineDefaultConstructor.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_duplicatepropertyname = new MessageDescription("mscorlib.InvalidOperation_DuplicatePropertyName", 0xA34503AB, new ParameterlessText("Another property by this name already exists.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_emptyqueue = new MessageDescription("mscorlib.InvalidOperation_EmptyQueue", 0xA34503AC, new ParameterlessText("Queue empty.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_emptystack = new MessageDescription("mscorlib.InvalidOperation_EmptyStack", 0xA34503AD, new ParameterlessText("Stack empty.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_endinvokecalledmultiple = new MessageDescription("mscorlib.InvalidOperation_EndInvokeCalledMultiple", 0xA34503AE, new ParameterlessText("EndInvoke can only be called once for each asynchronous operation.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_endreadcalledmultiple = new MessageDescription("mscorlib.InvalidOperation_EndReadCalledMultiple", 0xA34503AF, new ParameterlessText("EndRead can only be called once for each asynchronous operation.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_endwritecalledmultiple = new MessageDescription("mscorlib.InvalidOperation_EndWriteCalledMultiple", 0xA34503B0, new ParameterlessText("EndWrite can only be called once for each asynchronous operation.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_entrymethodnotdefinedinassembly = new MessageDescription("mscorlib.InvalidOperation_EntryMethodNotDefinedInAssembly", 0xA34503B1, new ParameterlessText("Entry method is not defined in the same assembly.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_enumended = new MessageDescription("mscorlib.InvalidOperation_EnumEnded", 0xA34503B2, new ParameterlessText("Enumeration already finished.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_enumfailedversion = new MessageDescription("mscorlib.InvalidOperation_EnumFailedVersion", 0xA34503B3, new ParameterlessText("Collection was modified; enumeration operation may not execute.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_enumnotstarted = new MessageDescription("mscorlib.InvalidOperation_EnumNotStarted", 0xA34503B4, new ParameterlessText("Enumeration has not started. Call MoveNext.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_enumopcanthappen = new MessageDescription("mscorlib.InvalidOperation_EnumOpCantHappen", 0xA34503B5, new ParameterlessText("Enumeration has either not started or has already finished.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_eventinfonotavailable = new MessageDescription("mscorlib.InvalidOperation_EventInfoNotAvailable", 0xA34503B6, new ParameterlessText("This API does not support EventInfo tokens.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_eventtokentablerequiresdelegate = new MessageDescription("mscorlib.InvalidOperation_EventTokenTableRequiresDelegate", 0xA34503B7, new FormatText("Type '{0}' is not a delegate type.  EventTokenTable may only be used with delegate types.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_genericparametersalreadyset = new MessageDescription("mscorlib.InvalidOperation_GenericParametersAlreadySet", 0xA34503B9, new ParameterlessText("The generic parameters are already defined on this MethodBuilder.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_getversion = new MessageDescription("mscorlib.InvalidOperation_GetVersion", 0xA34503BA, new ParameterlessText("OSVersion's call to GetVersionEx failed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_globalshavebeencreated = new MessageDescription("mscorlib.InvalidOperation_GlobalsHaveBeenCreated", 0xA34503BB, new ParameterlessText("Type definition of the global function has been completed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_handleisnotinitialized = new MessageDescription("mscorlib.InvalidOperation_HandleIsNotInitialized", 0xA34503BC, new ParameterlessText("Handle is not initialized.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_handleisnotpinned = new MessageDescription("mscorlib.InvalidOperation_HandleIsNotPinned", 0xA34503BD, new ParameterlessText("Handle is not pinned.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_hashinsertfailed = new MessageDescription("mscorlib.InvalidOperation_HashInsertFailed", 0xA34503BE, new ParameterlessText("Hashtable insert failed. Load factor too high. The most common cause is multiple threads writing to the Hashtable simultaneously.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_icomparerfailed = new MessageDescription("mscorlib.InvalidOperation_IComparerFailed", 0xA34503BF, new ParameterlessText("Failed to compare two elements in the array.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_internalstate = new MessageDescription("mscorlib.InvalidOperation_InternalState", 0xA34503C0, new ParameterlessText("Invalid internal state.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidcomregfunctionsig = new MessageDescription("mscorlib.InvalidOperation_InvalidComRegFunctionSig", 0xA34503C1, new ParameterlessText("COM register function must have a System.Type parameter and a void return type.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidcomunregfunctionsig = new MessageDescription("mscorlib.InvalidOperation_InvalidComUnRegFunctionSig", 0xA34503C2, new ParameterlessText("COM unregister function must have a System.Type parameter and a void return type.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_method = new MessageDescription("mscorlib.InvalidOperation_Method", 0xA34503C3, new ParameterlessText("This method is not supported by the current object.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_methodbaked = new MessageDescription("mscorlib.InvalidOperation_MethodBaked", 0xA34503C4, new ParameterlessText("Type definition of the method is complete.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_methodbuilderbaked = new MessageDescription("mscorlib.InvalidOperation_MethodBuilderBaked", 0xA34503C5, new ParameterlessText("The signature of the MethodBuilder can no longer be modified because an operation on the MethodBuilder caused the methodDef token to be created. For example, a call to SetCustomAttribute requires the methodDef token to emit the CustomAttribute token.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_methodhasbody = new MessageDescription("mscorlib.InvalidOperation_MethodHasBody", 0xA34503C6, new ParameterlessText("Method already has a body.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_mismatchedasyncresult = new MessageDescription("mscorlib.InvalidOperation_MismatchedAsyncResult", 0xA34503C7, new ParameterlessText("The IAsyncResult object provided does not match this delegate.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_modificationofnoncanonicalacl = new MessageDescription("mscorlib.InvalidOperation_ModificationOfNonCanonicalAcl", 0xA34503C8, new ParameterlessText("This access control list is not in canonical form and therefore cannot be modified.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_modifyropermset = new MessageDescription("mscorlib.InvalidOperation_ModifyROPermSet", 0xA34503C9, new ParameterlessText("ReadOnlyPermissionSet objects may not be modified.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_multiplecomregfunctions = new MessageDescription("mscorlib.InvalidOperation_MultipleComRegFunctions", 0xA34503CB, new FormatText("Type '{0}' has more than one COM registration function.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_multiplecomunregfunctions = new MessageDescription("mscorlib.InvalidOperation_MultipleComUnRegFunctions", 0xA34503CC, new FormatText("Type '{0}' has more than one COM unregistration function.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_mustcallinitialize = new MessageDescription("mscorlib.InvalidOperation_MustCallInitialize", 0xA34503CE, new ParameterlessText("You must call Initialize on this object instance before using it.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_mustlockforreadorwrite = new MessageDescription("mscorlib.InvalidOperation_MustLockForReadOrWrite", 0xA34503CF, new ParameterlessText("Object must be locked for read or write.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_mustlockforwrite = new MessageDescription("mscorlib.InvalidOperation_MustLockForWrite", 0xA34503D0, new ParameterlessText("Object must be locked for read.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_mustrevertprivilege = new MessageDescription("mscorlib.InvalidOperation_MustRevertPrivilege", 0xA34503D1, new ParameterlessText("Must revert the privilege prior to attempting this operation.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_noasmcodebase = new MessageDescription("mscorlib.InvalidOperation_NoAsmCodeBase", 0xA34503D2, new ParameterlessText("Assembly does not have a code base.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_noasmname = new MessageDescription("mscorlib.InvalidOperation_NoAsmName", 0xA34503D3, new ParameterlessText("Assembly does not have an assembly name. In order to be registered for use by COM, an assembly must have a valid assembly name.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nonstaticcomregfunction = new MessageDescription("mscorlib.InvalidOperation_NonStaticComRegFunction", 0xA34503D5, new ParameterlessText("COM register function must be static.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nonstaticcomunregfunction = new MessageDescription("mscorlib.InvalidOperation_NonStaticComUnRegFunction", 0xA34503D6, new ParameterlessText("COM unregister function must be static.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nopublicaddmethod = new MessageDescription("mscorlib.InvalidOperation_NoPublicAddMethod", 0xA34503D7, new ParameterlessText("Cannot add the event handler since no public add method exists for the event.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nopublicremovemethod = new MessageDescription("mscorlib.InvalidOperation_NoPublicRemoveMethod", 0xA34503D8, new ParameterlessText("Cannot remove the event handler since no public remove method exists for the event.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nosecuritydescriptor = new MessageDescription("mscorlib.InvalidOperation_NoSecurityDescriptor", 0xA34503D9, new ParameterlessText("The object does not contain a security descriptor.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notallowedindynamicmethod = new MessageDescription("mscorlib.InvalidOperation_NotAllowedInDynamicMethod", 0xA34503DB, new ParameterlessText("The requested operation is invalid for DynamicMethod.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notallowedinreflectiononly = new MessageDescription("mscorlib.InvalidOperation_NotAllowedInReflectionOnly", 0xA34503DC, new ParameterlessText("The requested operation is invalid in the ReflectionOnly context.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notavarargcallingconvention = new MessageDescription("mscorlib.InvalidOperation_NotAVarArgCallingConvention", 0xA34503DD, new ParameterlessText("Calling convention must be VarArgs.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_notgenerictype = new MessageDescription("mscorlib.InvalidOperation_NotGenericType", 0xA34503DE, new ParameterlessText("This operation is only valid on generic types.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notnewcapturecontext = new MessageDescription("mscorlib.InvalidOperation_NotNewCaptureContext", 0xA34503DF, new ParameterlessText("Cannot apply a context that has been marshaled across AppDomains, that was not acquired through a Capture operation or that has already been the argument to a Set call.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notsupportedonwinrtevent = new MessageDescription("mscorlib.InvalidOperation_NotSupportedOnWinRTEvent", 0xA34503E0, new ParameterlessText("Adding or removing event handlers dynamically is not supported on WinRT events.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notwithconcurrentgc = new MessageDescription("mscorlib.InvalidOperation_NotWithConcurrentGC", 0xA34503E1, new ParameterlessText("This API is not available when the concurrent GC is enabled.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nounderlyingtypeonenum = new MessageDescription("mscorlib.InvalidOperation_NoUnderlyingTypeOnEnum", 0xA34503E2, new ParameterlessText("Underlying type information on enumeration is not specified.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_novalue = new MessageDescription("mscorlib.InvalidOperation_NoValue", 0xA34503E3, new ParameterlessText("Nullable object must have a value.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nullarray = new MessageDescription("mscorlib.InvalidOperation_NullArray", 0xA34503E4, new ParameterlessText("The underlying array is null.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nullcontext = new MessageDescription("mscorlib.InvalidOperation_NullContext", 0xA34503E5, new ParameterlessText("Cannot call Set on a null context")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_onlyvalidfords = new MessageDescription("mscorlib.InvalidOperation_OnlyValidForDS", 0xA34503E7, new ParameterlessText("Adding ACEs with Object Flags and Object GUIDs is only valid for directory-object ACLs.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_openlocalvariablescope = new MessageDescription("mscorlib.InvalidOperation_OpenLocalVariableScope", 0xA34503E8, new ParameterlessText("Local variable scope was not properly closed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_overlappedpack = new MessageDescription("mscorlib.InvalidOperation_Overlapped_Pack", 0xA34503E9, new ParameterlessText("Cannot pack a packed Overlapped again.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_piamustbestrongnamed = new MessageDescription("mscorlib.InvalidOperation_PIAMustBeStrongNamed", 0xA34503EA, new ParameterlessText("Primary interop assemblies must be strongly named.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_propertyinfonotavailable = new MessageDescription("mscorlib.InvalidOperation_PropertyInfoNotAvailable", 0xA34503EB, new ParameterlessText("This API does not support PropertyInfo tokens.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_readonly = new MessageDescription("mscorlib.InvalidOperation_ReadOnly", 0xA34503EC, new ParameterlessText("Instance is read-only.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_regremovesubkey = new MessageDescription("mscorlib.InvalidOperation_RegRemoveSubKey", 0xA34503ED, new ParameterlessText("Registry key has subkeys and recursive removes are not supported by this method.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_resmgrbadressettype = new MessageDescription("mscorlib.InvalidOperation_ResMgrBadResSet_Type", 0xA34503EE, new FormatText("'{0}': ResourceSet derived classes must provide a constructor that takes a String file name and a constructor that takes a Stream.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_resourcenotstreamname = new MessageDescription("mscorlib.InvalidOperation_ResourceNotStream_Name", 0xA34503EF, new FormatText("Resource '{0}' was not a Stream - call GetObject instead.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.InvalidOperationException)));
        Add(_resourcenotstringname = new MessageDescription("mscorlib.InvalidOperation_ResourceNotString_Name", 0xA34503F0, new FormatText("Resource '{0}' was not a String - call GetObject instead.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_resourcenotstringtype = new MessageDescription("mscorlib.InvalidOperation_ResourceNotString_Type", 0xA34503F1, new FormatText("Resource was of type '{0}' instead of String - call GetObject instead.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_resourcewritersaved = new MessageDescription("mscorlib.InvalidOperation_ResourceWriterSaved", 0xA34503F2, new ParameterlessText("The resource writer has already been closed and cannot be edited.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_setdata = new MessageDescription("mscorlib.InvalidOperation_SetData", 0xA34503F3, new ParameterlessText("An additional permission should not be supplied for setting loader information.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_setdataonlylocationuri = new MessageDescription("mscorlib.InvalidOperation_SetData_OnlyLocationURI", 0xA34503F4, new FormatText("SetData cannot be used to set the value for '{0}'.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_setdataonlyonce = new MessageDescription("mscorlib.InvalidOperation_SetData_OnlyOnce", 0xA34503F5, new ParameterlessText("SetData can only be used to set the value of a given name once.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_setvolumelabelfailed = new MessageDescription("mscorlib.InvalidOperation_SetVolumeLabelFailed", 0xA34503F6, new ParameterlessText("Volume labels can only be set for writable local volumes.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_shouldnothavemethodbody = new MessageDescription("mscorlib.InvalidOperation_ShouldNotHaveMethodBody", 0xA34503F7, new ParameterlessText("Method body should not exist.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_slothasbeenfreed = new MessageDescription("mscorlib.InvalidOperation_SlotHasBeenFreed", 0xA34503F8, new ParameterlessText("LocalDataStoreSlot storage has been freed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_subclassedobject = new MessageDescription("mscorlib.InvalidOperation_SubclassedObject", 0xA34503F9, new FormatText("Cannot set sub-classed {0} object to {1} object.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_timeoutsnotsupported = new MessageDescription("mscorlib.InvalidOperation_TimeoutsNotSupported", 0xA34503FC, new ParameterlessText("Timeouts are not supported on this stream.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_typehasbeencreated = new MessageDescription("mscorlib.InvalidOperation_TypeHasBeenCreated", 0xA34503FD, new ParameterlessText("Unable to change after type has been created.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_typenotcreated = new MessageDescription("mscorlib.InvalidOperation_TypeNotCreated", 0xA34503FE, new ParameterlessText("Type has not been created.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_underlyingarraylistchanged = new MessageDescription("mscorlib.InvalidOperation_UnderlyingArrayListChanged", 0xA34503FF, new ParameterlessText("This range in the underlying list is invalid. A possible cause is that elements were removed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_unknownenumtype = new MessageDescription("mscorlib.InvalidOperation_UnknownEnumType", 0xA3450400, new ParameterlessText("Unknown enum type.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_waitontransparentproxy = new MessageDescription("mscorlib.InvalidOperation_WaitOnTransparentProxy", 0xA3450401, new ParameterlessText("Cannot wait on a transparent proxy.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_withoutarm = new MessageDescription("mscorlib.InvalidOperation_WithoutARM", 0xA3450402, new ParameterlessText("This API is not available when AppDomain Resource Monitoring is not turned on.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_writeonce = new MessageDescription("mscorlib.InvalidOperation_WriteOnce", 0xA3450403, new ParameterlessText("This property has already been set and cannot be modified.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_wrongasyncresultorendcalledmultiple = new MessageDescription("mscorlib.InvalidOperation_WrongAsyncResultOrEndCalledMultiple", 0xA3450404, new ParameterlessText("Either the IAsyncResult object did not come from the corresponding async method on this type, or the End method was called multiple times with the same IAsyncResult.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_wrongasyncresultorendreadcalledmultiple = new MessageDescription("mscorlib.InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple", 0xA3450405, new ParameterlessText("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndRead was called multiple times with the same IAsyncResult.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_wrongasyncresultorendwritecalledmultiple = new MessageDescription("mscorlib.InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple", 0xA3450406, new ParameterlessText("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndWrite was called multiple times with the same IAsyncResult.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_exceptionactorgraphcircular = new MessageDescription("mscorlib.InvalidOperationException_ActorGraphCircular", 0xA3450407, new ParameterlessText("Actor cannot be set so that circular directed graph will exist chaining the subjects together.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_resourcereaderisclosed = new MessageDescription("mscorlib.ResourceReaderIsClosed", 0xA3450557, new ParameterlessText("ResourceReader is closed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_unknownerror = new MessageDescription("mscorlib.UnknownError", 0xA3450608, new ParameterlessText("Unknown error.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Security.Cryptography").SetException(typeof(System.InvalidOperationException)));
        Add(_unknownerrornum = new MessageDescription("mscorlib.UnknownError_Num", 0xA3450609, new FormatText("Unknown error \"{0}\".")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_activationargsapptrustmismatch = new MessageDescription("mscorlib.InvalidOperation_ActivationArgsAppTrustMismatch", 0xA34506CA, new ParameterlessText("The activation arguments and application trust for the AppDomain must correspond to the same application identity.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_asserttransparentcode = new MessageDescription("mscorlib.InvalidOperation_AssertTransparentCode", 0xA34506D7, new ParameterlessText("Cannot perform CAS Asserts in Security Transparent methods")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotremovefromstackorqueue = new MessageDescription("mscorlib.InvalidOperation_CannotRemoveFromStackOrQueue", 0xA34506CE, new ParameterlessText("Removal is an invalid operation for Stack or Queue.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cantcancelctrlbreak = new MessageDescription("mscorlib.InvalidOperation_CantCancelCtrlBreak", 0xA34506CB, new ParameterlessText("Applications may not prevent control-break from terminating their process.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cantinstantiateabstractclass = new MessageDescription("mscorlib.InvalidOperation_CantInstantiateAbstractClass", 0xA34506D1, new ParameterlessText("Instances of abstract classes cannot be created.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cantinstantiatefunctionpointer = new MessageDescription("mscorlib.InvalidOperation_CantInstantiateFunctionPointer", 0xA34506D2, new ParameterlessText("Instances of function pointers cannot be created.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_collectioncorrupted = new MessageDescription("mscorlib.InvalidOperation_CollectionCorrupted", 0xA34506CC, new ParameterlessText("A prior operation on this collection was interrupted by an exception. Collection's state is no longer trusted.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_criticaltransparentaremutuallyexclusive = new MessageDescription("mscorlib.InvalidOperation_CriticalTransparentAreMutuallyExclusive", 0xA34506CD, new ParameterlessText("SecurityTransparent and SecurityCritical attributes cannot be applied to the assembly scope at the same time.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_hostmodifiedsecuritystate = new MessageDescription("mscorlib.InvalidOperation_HostModifiedSecurityState", 0xA34506D9, new ParameterlessText("The security state of an AppDomain was modified by an AppDomainManager configured with the NoSecurityChanges flag.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_metadataerror = new MessageDescription("mscorlib.InvalidOperation_MetaDataError", 0xA34506D3, new ParameterlessText("Metadata operation failed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_modifyronumfmtinfo = new MessageDescription("mscorlib.InvalidOperation_ModifyRONumFmtInfo", 0xA34506CF, new ParameterlessText("Unable to modify a read-only NumberFormatInfo object.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nativeoverlappedreused = new MessageDescription("mscorlib.InvalidOperation_NativeOverlappedReused", 0xA3450C66, new ParameterlessText("NativeOverlapped cannot be reused for multiple operations.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notcurrentdomain = new MessageDescription("mscorlib.InvalidOperation_NotCurrentDomain", 0xA34506D0, new ParameterlessText("You can only define a dynamic assembly on the current AppDomain.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_strongnamekeypairrequired = new MessageDescription("mscorlib.InvalidOperation_StrongNameKeyPairRequired", 0xA34506DA, new ParameterlessText("A strong name key pair is required to emit a strong-named dynamic assembly.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_switcherctxmismatch = new MessageDescription("mscorlib.InvalidOperation_SwitcherCtxMismatch", 0xA34506D5, new ParameterlessText("The Undo operation encountered a context that is different from what was applied in the corresponding Set operation. The possible cause is that a context was Set on the thread and not reverted(undone).")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_typecannotbeboxed = new MessageDescription("mscorlib.InvalidOperation_TypeCannotBeBoxed", 0xA34506D8, new ParameterlessText("The given type cannot be boxed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_unexpectedwin32error = new MessageDescription("mscorlib.InvalidOperation_UnexpectedWin32Error", 0xA34506D6, new FormatText("Unexpected error when calling an operating system function.  The returned error code is 0x{0:x}.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_userdomainname = new MessageDescription("mscorlib.InvalidOperation_UserDomainName", 0xA34506D4, new ParameterlessText("UserDomainName native call failed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        return this;
    }    

}
