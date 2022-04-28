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

/// <summary>System.ArgumentException</summary>
public class ArgumentMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ArgumentMessages> instance = new Lazy<ArgumentMessages>(() => new ArgumentMessages().Initialize().SetAllReadOnly<ArgumentMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ArgumentMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x020B;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _applicationdirectorytostring, _accessexception, _ambiguousmatchexception, _applicationexception, _argumentoutofrangeexception, _badimageformatexception, _badliteralformat, _bogusicomparer, _buffertoosmall, _cannotbenan;
    IMessageDescription? _cannotmixcomparisoninfrastructure, _catyperesolutionfailed, _comaccess, _compropsetput, _contextmarshalexception, _creatinstaccess, _datamisalignedexception, _datetimerange, _decbitctor, _dividebyzero;
    IMessageDescription? _dlgtnullinst, _dlgttargmeth, _dlgttypemis, _dllinitfailure, _dllnotfoundexception, _duplicatewaitobjectexception, _emptycollection, _emptyornullstring, _entrypointnotfoundexception, _enumandobjectmustbesametype;
    IMessageDescription? _enumatleastoneflag, _enumformatunderlyingtypeandobjectmustbesametype, _enumlitvaluenotfound, _enumnotsingleflag, _enumunderlyingtypeandobjectmustbesametype, _enumvaluenotfound, _fieldaccessexception, _fielddecltarget, _fileisdirectoryname, _fldgetargerr;
    IMessageDescription? _fldgetpropset, _fldsetargerr, _fldsetget, _fldsetinvoke, _fldsetpropget, _formatexception, _genericparameter, _getmethnotfnd, _handlenotasync, _handlenotsync;
    IMessageDescription? _htcapacityoverflow, _indexmustbeint, _indexoutofrangeexception, _invalidaccessentry, _invalidbase, _invalidcastexception, _invalidconsolecolor, _invalidfileattrs, _invalidfileextension, _invalidfilename;
    IMessageDescription? _invalidhandle, _invalidhexstyle, _invalidneutralresourceslanguageasmculture, _invalidneutralresourceslanguagefallbackloc, _invalidsearchpattern, _invalidtypeinrettype, _invalidtypeinsignature, _invokemember, _longerthansrcstring, _lowerboundsmustmatch;
    IMessageDescription? _marshalasanyrestriction, _methodaccessexception, _methodaccessexceptionwithcaller, _methodaccessexceptionwithmethodname, _missingactivationarguments, _missingfieldexception, _missingmemberexception, _missingmethodexception, _mustbeboolean, _mustbebyte;
    IMessageDescription? _mustbechar, _mustbedatetime, _mustbedatetimeoffset, _mustbedecimal, _mustbedelegate, _mustbedouble, _mustbedriveletterorrootdir, _mustbeenum, _mustbeenumbasetypeorenum, _mustbeguid;
    IMessageDescription? _mustbeint16, _mustbeint32, _mustbeint64, _mustbepointer, _mustbesbyte, _mustbesingle, _mustbestatic, _mustbestring, _mustbestringptrnotatom, _mustbetimespan;
    IMessageDescription? _mustbetrue, _mustbetype, _mustbeuint16, _mustbeuint32, _mustbeuint64, _mustbeversion, _mustcontainenuminfo, _namedparamnull, _namedparamtoobig, _ndirectbadobject;
    IMessageDescription? _needatleast1rank, _negativeargcount, _noaccessspec, _nodefctor, _nonzerolowerbound, _nostaticvirtual, _notfinitenumberexception, _notgenericmethoddefinition, _notgenericparameter, _notgenerictypedefinition;
    IMessageDescription? _objobj, _objobjex, _oleautdateinvalid, _oleautdatescale, _overflowexception, _paramnamename, _parmcnt, _path2isrooted, _pathglobalroot, _pathillegal;
    IMessageDescription? _pathillegalunc, _pathisvolume, _platformsecurestring, _propnotfound, _propsetget, _propsetinvoke, _rankexception, _rankindices, _ranksandbounds, _reflectiononlyca;
    IMessageDescription? _reflectiononlyfield, _reflectiononlyinvoke, _regbadkeykind, _reggetoverflowbug, _reginvalidkeyname, _regkeydelhive, _regkeynoremoteconnect, _regkeynotfound, _regkeyoutofrange, _regkeystrlenbug;
    IMessageDescription? _regsetbadarrtype, _regsetmismatchedkind, _regsetstrarrnull, _regsubkeyabsent, _regsubkeyvalueabsent, _regvalstrlenbug, _removeargnotfound, _resourcefileunsupportedversion, _resourcenamenotexist, _setmethnotfnd;
    IMessageDescription? _surrogatesnotallowedassinglechar, _systemexception, _timeoutexception, _typeaccessexception, _typeloadexception, _typeloadnullstr, _typerefprimitve, _typeunloadedexception, _unauthorizedaccessexception, _unboundgenfield;
    IMessageDescription? _unboundgenparam, _unknowntypecode, _varmissnull, _versionstring, _wrongasyncresult, _wrongtype, _absolutepathrequired, _addingduplicate, _addingduplicate2, _adjustmentrulesnonulls;
    IMessageDescription? _adjustmentrulesoutoforder, _alsinvalidslot, _applicationtrustshouldhaveidentity, _argumentzero, _assemblyalreadyfulltrust, _assemblynotfulltrust, _attributenamesmustbeunique, _badattributeoninterfacemethod, _badcaforunmngrsc, _badconstructor;
    IMessageDescription? _badconstructorcallconv, _badfieldforconstructorbuilder, _badfieldsig, _badfieldtype, _badimageformatexceptionresolve, _badnestedtypeflags, _badobjref, _badparametercountsforconstructor, _badparametertypeforcab, _badparametertypeforconstructor;
    IMessageDescription? _badpinvokemethod, _badpinvokeoninterface, _badpropertyforconstructorbuilder, _badresourcescopetypebits, _badresourcescopevisibilitybits, _badsigformat, _badsizefordata, _badtypeattrinvalidlayout, _badtypeattrnestedvisibilityonnonnestedtype, _badtypeattrnonnestedvisibilitynestedtype;
    IMessageDescription? _badtypeattrreservedbitsset, _badtypeincustomattribute, _blobcannotbenull, _cannotgettypetokenforbyref, _cannotsetparenttointerface, _codegroupchildrenmustbecodegroups, _compareoptionordinal, _conflictingdatetimeroundtripstyles, _conflictingdatetimestyles, _constantdoesntmatch;
    IMessageDescription? _constantnull, _constructorneedgenericdeclaringtype, _conversionoverflow, _convertmismatch, _cultureisneutral, _customculturecannotbepassedbynumber, _datalengthdifferent, _datetimebadbinarydata, _datetimehasticks, _datetimehastimeofday;
    IMessageDescription? _datetimeisinvalid, _datetimeisnotambiguous, _datetimekindmustbeunspecified, _datetimeoffsetinvaliddatetimestyles, _datetimeoffsetisnotambiguous, _duplicatedfilename, _duplicatename, _duplicateresourcename, _duplicatetypename, _emptyapplicationname;
    IMessageDescription? _emptydecstring, _emptyfilename, _emptypath, _emptystrongname, _encoderfallbacknotempty, _encodingconversionoverflowbytes, _encodingconversionoverflowchars, _enumtypedoesnotmatch, _failedcodegroup, _fallbackbuffernotempty;
    IMessageDescription? _frameworknameinvalid, _frameworknamemissingversion, _frameworknametooshort, _genconstraintviolation, _genericargscount, _genericsinvalid, _globalfunctionhastobestatic, _idnbadbidi, _idnbadlabelsize, _idnbadnamesize;
    IMessageDescription? _idnbadpunycode, _idnbadstd3, _idnillegalname, _illegalappid, _illegalappidmismatch, _illegalenvvarname, _illegalname, _illegalzone, _impersonateuser, _implementicomparable;
    IMessageDescription? _impropertype, _insufficientspacetocopycollection, _invalidanyflag, _invalidappendmode, _invalidappid, _invalidargumentforcomparison, _invalidcalendar, _invalidcharsequence, _invalidcharsequencenoindex, _invalidconstructordeclaringtype;
    IMessageDescription? _invalidconstructorinfo, _invalidculturename, _invaliddatetimekind, _invaliddatetimestyles, _invaliddigitsubstitution, _invaliddirectory, _invaliddirectoryonurl, _invalidelementname, _invalidelementtag, _invalidelementtext;
    IMessageDescription? _invalidelementvalue, _invalidenum, _invalidenumvalue, _invalidfielddeclaringtype, _invalidfieldinfo, _invalidfilemodeaccesscombo, _invalidfilemoderightscombo, _invalidfilemodetruncaterightscombo, _invalidflag, _invalidgroupsize;
    IMessageDescription? _invalidhandle2, _invalidhexformat, _invalidhighsurrogate, _invalidid, _invalidimpersonationtoken, _invalidkey, _invalidkeystore, _invalidkindoftypeforca, _invalidlowsurrogate, _invalidmarshalbyrefobject;
    IMessageDescription? _invalidmemberfornamedargument, _invalidmethoddeclaringtype, _invalidname, _invalidnativedigitcount, _invalidnativedigitvalue, _invalidneutralregionname, _invalidnormalizationform, _invalidnumberstyles, _invalidofflen, _invalidopcodeondynamicmethod;
    IMessageDescription? _invalidparameterinfo, _invalidparaminfo, _invalidpathchars, _invalidpermissionstate, _invalidregtziformat, _invalidregistrykeypermissioncheck, _invalidregistryoptionscheck, _invalidregistryviewcheck, _invalidresourceculturename, _invalidsafebufferofflen;
    IMessageDescription? _invalidsafehandle, _invalidseekorigin, _invalidsite, _invalidsubpath, _invalidtimespanstyles, _invalidtoken, _invalidtype, _invalidtypeforca, _invalidtypefordynamicmethod, _invalidtypename;
    IMessageDescription? _invalidtypetoken, _invalidunity, _invalidurl, _invalidvalue, _invalidxml, _invalidxmlbadversion, _invalidxmlelement, _invalidxmlmissingattr, _itemnotexist, _largeinteger;
    IMessageDescription? _longenvvarname, _longenvvarvalue, _minmaxvalue, _mustbefalse, _mustbeinterfacemethod, _mustberuntimefieldinfo, _mustberuntimemethodinfo, _mustberuntimereflectionobject, _mustbetypebuilder, _musthaveattributebaseclass;
    IMessageDescription? _mustsupplycontainer, _mustsupplyparent, _nativeresourcealreadydefined, _needgenericmethoddefinition, _neednongenerictype, _nevervalidgenericargument, _noclass, _nodomainmanager, _noera, _nomain;
    IMessageDescription? _nonestedmarshal, _nonnullobjandctx, _nonpms, _noregioninvariantculture, _notacodegrouptype, _notacustommarshaler, _notamembershipcondition, _notapermissionelement, _notapermissiontype, _notasimplenativetype;
    IMessageDescription? _notawritableproperty, _notenoughbytestoread, _notenoughbytestowrite, _notenoughgenarguments, _notsimplefilename, _nounmanagedelementcount, _npmsinuse, _npmsinvalidname, _nullfulltrustassembly, _objiswinrtobject;
    IMessageDescription? _objnotcomobject, _offsetandcapacityoutofbounds, _offsetandlengthoutofbounds, _offsetlocalmismatch, _offsetoffieldnotfound, _offsetoutofrange, _offsetprecision, _offsetutcmismatch, _onlymscorlib, _outoforderdatetimes;
    IMessageDescription? _pathempty, _policyfiledoesnotexist, _recursivefallback, _recursivefallbackbytes, _relativeurlmembershipcondition, _reservednpms, _resolvefield, _resolvefieldhandle, _resolvemember, _resolvemethod;
    IMessageDescription? _resolvemethodhandle, _resolvestring, _resolvetype, _resourcescopewrongdirection, _resultcalendarrange, _shouldonlysetvisibilityflags, _sigisfinalized, _sitecannotbenull, _streamnotreadable, _streamnotwritable;
    IMessageDescription? _stringfirstchariszero, _stringzerolength, _strongnamegetpublickey, _timespanhasseconds, _toexclusivelessthanfromexclusive, _tokenzero, _transitiontimesareidentical, _unabletogeneratepermissionset, _unexpectedtypesource, _uninitializedcertificate;
    IMessageDescription? _unknownunmanagedcallconv, _unmanagedmemaccessorwraparound, _unrecognizedloaderoptimization, _urlcannotbenull, _utcoutofrange, _waithandlenametoolong, _winrtsystemruntimetype, _wrongelementtype, _wrongtype2, _zonecannotbenull;
    IMessageDescription? _exceptionbadmethodimplbody, _exceptioninvalidacebinaryform, _exceptioninvalidaclbinaryform, _exceptioninvalidsdsddlform, _exceptionminsortingversion, _exceptionnotallcustomsortingfuncsdefined, _exceptiontupleincorrecttype, _exceptiontuplelastargumentnotatuple, _gactostring, _resourcesstreamnotvalid;
    IMessageDescription? _strongnamename, _strongnametostring, _strongnameversion, _urltostring, _urltostringarg, _cannothavenegativevalue, _corruptedcustomculturefile, _enummusthaveunderlyingvaluefield, _importerloadfailure, _invalidansistring;
    IMessageDescription? _invalidutf8string, _mustallberuntimetype, _mustbeinterface, _noitypeinfo, _noimportercallback, _notfoundiface, _nullindex, _parameterinfonullmember, _primwiden, _rwlockrestoreexception;
    IMessageDescription? _exceptiontuplenonicomparableelement, _exceptionvaluetupleincorrecttype, _exceptionvaluetuplelastargumentnotavaluetuple, _alsinvalidcapacity, _adjustmentrulesambiguousoverlap, _adjustmentrulesinvalidoverlap, _adjustmentrulesrdaylightsavingtimeoverlap, _adjustmentrulesrdaylightsavingtimeoverlapnonrulerange, _alreadyaccw, _alreadyboundorsynchandle;
    IMessageDescription? _assemblywinmd, _badconstantvalue, _badcurrentlocalvariable, _badformatspecifier, _badtypeattrabstractnfinal, _cordbbadmethod, _cordbbadvarargcallconv, _cannotprepareabstract, _cantcallsecobjfunc, _cultureinvalidformat;
    IMessageDescription? _cultureinvalididentifier, _customassemblyloadcontextrequestednamemismatch, _emptyvalue, _enumisnotintorshort, _handleleak, _illegalappbase, _interfacemap, _invalidassemblyname, _invalidgenericarg, _invalidgenericinstantiation;
    IMessageDescription? _invalidnumberofmembers, _invalidregionname, _mustberuntimeparameterinfo, _mustbestring2, _musthavelayoutorbeblittable, _namecontainsinvalidcharacters, _nametoolong, _nativeoverlappedalreadyfree, _nativeoverlappedwrongboundhandle, _neednongenericobject;
    IMessageDescription? _needstructwithnorefs, _nospecificculture, _nounderlyingccw, _nouninitializedstrings, _notatp, _preallocatedalreadyallocated, _resultislamiccalendarrange, _seekoverflow, _structmustnotbevalueclass, _unequalmembers;
    IMessageDescription? _unrestrictedidentitypermission, _verstringtoolong, _cvtresnotfound;
    
    /// <summary>ApplicationDirectory</summary>
    public IMessageDescription ApplicationDirectoryToString { get => _applicationdirectorytostring!; set => this.AssertWritable()._applicationdirectorytostring = value; }
    /// <summary>System</summary>
    public IMessageDescription AccessException { get => _accessexception!; set => this.AssertWritable()._accessexception = value; }
    /// <summary>Ambiguous match found.</summary>
    public IMessageDescription AmbiguousMatchException { get => _ambiguousmatchexception!; set => this.AssertWritable()._ambiguousmatchexception = value; }
    /// <summary>System</summary>
    public IMessageDescription ApplicationException { get => _applicationexception!; set => this.AssertWritable()._applicationexception = value; }
    /// <summary>System</summary>
    public IMessageDescription ArgumentOutOfRangeException { get => _argumentoutofrangeexception!; set => this.AssertWritable()._argumentoutofrangeexception = value; }
    /// <summary>System</summary>
    public IMessageDescription BadImageFormatException { get => _badimageformatexception!; set => this.AssertWritable()._badimageformatexception = value; }
    /// <summary>Encountered an invalid type for a default value.</summary>
    public IMessageDescription BadLiteralFormat { get => _badliteralformat!; set => this.AssertWritable()._badliteralformat = value; }
    /// <summary>Unable to sort because the IComparer.Compare() method returns inconsistent results. Either a value does not compare equal to itself, or one value repeatedly compared to another value yields different results. IComparer: &#39;{0}&#39;.</summary>
    public IMessageDescription BogusIComparer { get => _bogusicomparer!; set => this.AssertWritable()._bogusicomparer = value; }
    /// <summary>Not enough space available in the buffer.</summary>
    public IMessageDescription BufferTooSmall { get => _buffertoosmall!; set => this.AssertWritable()._buffertoosmall = value; }
    /// <summary>TimeSpan does not accept floating point Not-a-Number values.</summary>
    public IMessageDescription CannotBeNaN { get => _cannotbenan!; set => this.AssertWritable()._cannotbenan = value; }
    /// <summary>The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.</summary>
    public IMessageDescription CannotMixComparisonInfrastructure { get => _cannotmixcomparisoninfrastructure!; set => this.AssertWritable()._cannotmixcomparisoninfrastructure = value; }
    /// <summary>Failed to resolve type from string &quot;{0}&quot; which was embedded in custom attribute blob.</summary>
    public IMessageDescription CATypeResolutionFailed { get => _catyperesolutionfailed!; set => this.AssertWritable()._catyperesolutionfailed = value; }
    /// <summary>Must specify property Set or Get or method call for a COM Object.</summary>
    public IMessageDescription COMAccess { get => _comaccess!; set => this.AssertWritable()._comaccess = value; }
    /// <summary>Only one of the following binding flags can be set: BindingFlags.SetProperty, BindingFlags.PutDispProperty, BindingFlags.PutRefDispProperty.</summary>
    public IMessageDescription COMPropSetPut { get => _compropsetput!; set => this.AssertWritable()._compropsetput = value; }
    /// <summary>System</summary>
    public IMessageDescription ContextMarshalException { get => _contextmarshalexception!; set => this.AssertWritable()._contextmarshalexception = value; }
    /// <summary>Cannot specify both CreateInstance and another access type.</summary>
    public IMessageDescription CreatInstAccess { get => _creatinstaccess!; set => this.AssertWritable()._creatinstaccess = value; }
    /// <summary>System</summary>
    public IMessageDescription DataMisalignedException { get => _datamisalignedexception!; set => this.AssertWritable()._datamisalignedexception = value; }
    /// <summary>Combination of arguments to the DateTime constructor is out of the legal range.</summary>
    public IMessageDescription DateTimeRange { get => _datetimerange!; set => this.AssertWritable()._datetimerange = value; }
    /// <summary>Decimal byte array constructor requires an array of length four containing valid decimal bytes.</summary>
    public IMessageDescription DecBitCtor { get => _decbitctor!; set => this.AssertWritable()._decbitctor = value; }
    /// <summary>System</summary>
    public IMessageDescription DivideByZero { get => _dividebyzero!; set => this.AssertWritable()._dividebyzero = value; }
    /// <summary>Delegate to an instance method cannot have null &#39;this&#39;.</summary>
    public IMessageDescription DlgtNullInst { get => _dlgtnullinst!; set => this.AssertWritable()._dlgtnullinst = value; }
    /// <summary>Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.</summary>
    public IMessageDescription DlgtTargMeth { get => _dlgttargmeth!; set => this.AssertWritable()._dlgttargmeth = value; }
    /// <summary>Delegates must be of the same type.</summary>
    public IMessageDescription DlgtTypeMis { get => _dlgttypemis!; set => this.AssertWritable()._dlgttypemis = value; }
    /// <summary>One machine may not have remote administration enabled, or both machines may not be running the remote registry service.</summary>
    public IMessageDescription DllInitFailure { get => _dllinitfailure!; set => this.AssertWritable()._dllinitfailure = value; }
    /// <summary>System</summary>
    public IMessageDescription DllNotFoundException { get => _dllnotfoundexception!; set => this.AssertWritable()._dllnotfoundexception = value; }
    /// <summary>System</summary>
    public IMessageDescription DuplicateWaitObjectException { get => _duplicatewaitobjectexception!; set => this.AssertWritable()._duplicatewaitobjectexception = value; }
    /// <summary>Collection must not be empty.</summary>
    public IMessageDescription EmptyCollection { get => _emptycollection!; set => this.AssertWritable()._emptycollection = value; }
    /// <summary>String may not be empty or null.</summary>
    public IMessageDescription EmptyOrNullString { get => _emptyornullstring!; set => this.AssertWritable()._emptyornullstring = value; }
    /// <summary>System</summary>
    public IMessageDescription EntryPointNotFoundException { get => _entrypointnotfoundexception!; set => this.AssertWritable()._entrypointnotfoundexception = value; }
    /// <summary>Object must be the same type as the enum. The type passed in was &#39;{0}&#39;; the enum type was &#39;{1}&#39;.</summary>
    public IMessageDescription EnumAndObjectMustBeSameType { get => _enumandobjectmustbesametype!; set => this.AssertWritable()._enumandobjectmustbesametype = value; }
    /// <summary>Must set at least one flag.</summary>
    public IMessageDescription EnumAtLeastOneFlag { get => _enumatleastoneflag!; set => this.AssertWritable()._enumatleastoneflag = value; }
    /// <summary>Enum underlying type and the object must be same type or object. Type passed in was &#39;{0}&#39;; the enum underlying type was &#39;{1}&#39;.</summary>
    public IMessageDescription EnumFormatUnderlyingTypeAndObjectMustBeSameType { get => _enumformatunderlyingtypeandobjectmustbesametype!; set => this.AssertWritable()._enumformatunderlyingtypeandobjectmustbesametype = value; }
    /// <summary>Literal value was not found.</summary>
    public IMessageDescription EnumLitValueNotFound { get => _enumlitvaluenotfound!; set => this.AssertWritable()._enumlitvaluenotfound = value; }
    /// <summary>Must set exactly one flag.</summary>
    public IMessageDescription EnumNotSingleFlag { get => _enumnotsingleflag!; set => this.AssertWritable()._enumnotsingleflag = value; }
    /// <summary>Enum underlying type and the object must be same type or object must be a String. Type passed in was &#39;{0}&#39;; the enum underlying type was &#39;{1}&#39;.</summary>
    public IMessageDescription EnumUnderlyingTypeAndObjectMustBeSameType { get => _enumunderlyingtypeandobjectmustbesametype!; set => this.AssertWritable()._enumunderlyingtypeandobjectmustbesametype = value; }
    /// <summary>Requested value &#39;{0}&#39; was not found.</summary>
    public IMessageDescription EnumValueNotFound { get => _enumvaluenotfound!; set => this.AssertWritable()._enumvaluenotfound = value; }
    /// <summary>System</summary>
    public IMessageDescription FieldAccessException { get => _fieldaccessexception!; set => this.AssertWritable()._fieldaccessexception = value; }
    /// <summary>Field &#39;{0}&#39; defined on type &#39;{1}&#39; is not a field on the target object which is of type &#39;{2}&#39;.</summary>
    public IMessageDescription FieldDeclTarget { get => _fielddecltarget!; set => this.AssertWritable()._fielddecltarget = value; }
    /// <summary>The target file &quot;{0}&quot; is a directory, not a file.</summary>
    public IMessageDescription FileIsDirectoryName { get => _fileisdirectoryname!; set => this.AssertWritable()._fileisdirectoryname = value; }
    /// <summary>No arguments can be provided to Get a field value.</summary>
    public IMessageDescription FldGetArgErr { get => _fldgetargerr!; set => this.AssertWritable()._fldgetargerr = value; }
    /// <summary>Cannot specify both GetField and SetProperty.</summary>
    public IMessageDescription FldGetPropSet { get => _fldgetpropset!; set => this.AssertWritable()._fldgetpropset = value; }
    /// <summary>Only the field value can be specified to set a field value.</summary>
    public IMessageDescription FldSetArgErr { get => _fldsetargerr!; set => this.AssertWritable()._fldsetargerr = value; }
    /// <summary>Cannot specify both Get and Set on a field.</summary>
    public IMessageDescription FldSetGet { get => _fldsetget!; set => this.AssertWritable()._fldsetget = value; }
    /// <summary>Cannot specify Set on a Field and Invoke on a method.</summary>
    public IMessageDescription FldSetInvoke { get => _fldsetinvoke!; set => this.AssertWritable()._fldsetinvoke = value; }
    /// <summary>Cannot specify both SetField and GetProperty.</summary>
    public IMessageDescription FldSetPropGet { get => _fldsetpropget!; set => this.AssertWritable()._fldsetpropget = value; }
    /// <summary>System</summary>
    public IMessageDescription FormatException { get => _formatexception!; set => this.AssertWritable()._formatexception = value; }
    /// <summary>Method must be called on a Type for which Type.IsGenericParameter is false.</summary>
    public IMessageDescription GenericParameter { get => _genericparameter!; set => this.AssertWritable()._genericparameter = value; }
    /// <summary>Property Get method was not found.</summary>
    public IMessageDescription GetMethNotFnd { get => _getmethnotfnd!; set => this.AssertWritable()._getmethnotfnd = value; }
    /// <summary>Handle does not support asynchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened synchronously (that is, it was not opened for overlapped I/O).</summary>
    public IMessageDescription HandleNotAsync { get => _handlenotasync!; set => this.AssertWritable()._handlenotasync = value; }
    /// <summary>Handle does not support synchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened asynchronously (that is, it was opened explicitly for overlapped I/O).</summary>
    public IMessageDescription HandleNotSync { get => _handlenotsync!; set => this.AssertWritable()._handlenotsync = value; }
    /// <summary>Hashtable&#39;s capacity overflowed and went negative. Check load factor, capacity and the current size of the table.</summary>
    public IMessageDescription HTCapacityOverflow { get => _htcapacityoverflow!; set => this.AssertWritable()._htcapacityoverflow = value; }
    /// <summary>All indexes must be of type Int32.</summary>
    public IMessageDescription IndexMustBeInt { get => _indexmustbeint!; set => this.AssertWritable()._indexmustbeint = value; }
    /// <summary>System</summary>
    public IMessageDescription IndexOutOfRangeException { get => _indexoutofrangeexception!; set => this.AssertWritable()._indexoutofrangeexception = value; }
    /// <summary>Specified access entry is invalid because it is unrestricted. The global flags should be specified instead.</summary>
    public IMessageDescription InvalidAccessEntry { get => _invalidaccessentry!; set => this.AssertWritable()._invalidaccessentry = value; }
    /// <summary>Invalid Base.</summary>
    public IMessageDescription InvalidBase { get => _invalidbase!; set => this.AssertWritable()._invalidbase = value; }
    /// <summary>System</summary>
    public IMessageDescription InvalidCastException { get => _invalidcastexception!; set => this.AssertWritable()._invalidcastexception = value; }
    /// <summary>The ConsoleColor enum value was not defined on that enum. Please use a defined color from the enum.</summary>
    public IMessageDescription InvalidConsoleColor { get => _invalidconsolecolor!; set => this.AssertWritable()._invalidconsolecolor = value; }
    /// <summary>Invalid File or Directory attributes value.</summary>
    public IMessageDescription InvalidFileAttrs { get => _invalidfileattrs!; set => this.AssertWritable()._invalidfileattrs = value; }
    /// <summary>Specified file extension was not a valid extension.</summary>
    public IMessageDescription InvalidFileExtension { get => _invalidfileextension!; set => this.AssertWritable()._invalidfileextension = value; }
    /// <summary>Specified file name was invalid.</summary>
    public IMessageDescription InvalidFileName { get => _invalidfilename!; set => this.AssertWritable()._invalidfilename = value; }
    /// <summary>Invalid handle.</summary>
    public IMessageDescription InvalidHandle { get => _invalidhandle!; set => this.AssertWritable()._invalidhandle = value; }
    /// <summary>With the AllowHexSpecifier bit set in the enum bit field, the only other valid bits that can be combined into the enum value must be a subset of those in HexNumber.</summary>
    public IMessageDescription InvalidHexStyle { get => _invalidhexstyle!; set => this.AssertWritable()._invalidhexstyle = value; }
    /// <summary>The NeutralResourcesLanguageAttribute on the assembly &quot;{0}&quot; specifies an invalid culture name: &quot;{1}&quot;.</summary>
    public IMessageDescription InvalidNeutralResourcesLanguageAsmCulture { get => _invalidneutralresourceslanguageasmculture!; set => this.AssertWritable()._invalidneutralresourceslanguageasmculture = value; }
    /// <summary>The NeutralResourcesLanguageAttribute specifies an invalid or unrecognized ultimate resource fallback location: &quot;{0}&quot;.</summary>
    public IMessageDescription InvalidNeutralResourcesLanguageFallbackLoc { get => _invalidneutralresourceslanguagefallbackloc!; set => this.AssertWritable()._invalidneutralresourceslanguagefallbackloc = value; }
    /// <summary>Search pattern cannot contain &quot;..&quot; to move up directories and can be contained only internally in file/directory names, as in &quot;a..b&quot;.</summary>
    public IMessageDescription InvalidSearchPattern { get => _invalidsearchpattern!; set => this.AssertWritable()._invalidsearchpattern = value; }
    /// <summary>The return Type contains some invalid type (i.e. null, ByRef)</summary>
    public IMessageDescription InvalidTypeInRetType { get => _invalidtypeinrettype!; set => this.AssertWritable()._invalidtypeinrettype = value; }
    /// <summary>The signature Type array contains some invalid type (i.e. null, void)</summary>
    public IMessageDescription InvalidTypeInSignature { get => _invalidtypeinsignature!; set => this.AssertWritable()._invalidtypeinsignature = value; }
    /// <summary>InvokeMember can be used only for COM objects.</summary>
    public IMessageDescription InvokeMember { get => _invokemember!; set => this.AssertWritable()._invokemember = value; }
    /// <summary>Source string was not long enough. Check sourceIndex and count.</summary>
    public IMessageDescription LongerThanSrcString { get => _longerthansrcstring!; set => this.AssertWritable()._longerthansrcstring = value; }
    /// <summary>The arrays&#39; lower bounds must be identical.</summary>
    public IMessageDescription LowerBoundsMustMatch { get => _lowerboundsmustmatch!; set => this.AssertWritable()._lowerboundsmustmatch = value; }
    /// <summary>System.StubHelpers</summary>
    public IMessageDescription MarshalAsAnyRestriction { get => _marshalasanyrestriction!; set => this.AssertWritable()._marshalasanyrestriction = value; }
    /// <summary>System</summary>
    public IMessageDescription MethodAccessException { get => _methodaccessexception!; set => this.AssertWritable()._methodaccessexception = value; }
    /// <summary>Attempt by security transparent method &#39;{0}&#39; to access security critical method &#39;{1}&#39; failed.</summary>
    public IMessageDescription MethodAccessExceptionWithCaller { get => _methodaccessexceptionwithcaller!; set => this.AssertWritable()._methodaccessexceptionwithcaller = value; }
    /// <summary>Attempt to access the method &quot;{0}&quot; on type &quot;{1}&quot; failed.</summary>
    public IMessageDescription MethodAccessExceptionWithMethodName { get => _methodaccessexceptionwithmethodname!; set => this.AssertWritable()._methodaccessexceptionwithmethodname = value; }
    /// <summary>The AppDomainSetup must specify the activation arguments for this call.</summary>
    public IMessageDescription MissingActivationArguments { get => _missingactivationarguments!; set => this.AssertWritable()._missingactivationarguments = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingFieldException { get => _missingfieldexception!; set => this.AssertWritable()._missingfieldexception = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingMemberException { get => _missingmemberexception!; set => this.AssertWritable()._missingmemberexception = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingMethodException { get => _missingmethodexception!; set => this.AssertWritable()._missingmethodexception = value; }
    /// <summary>Object must be of type Boolean.</summary>
    public IMessageDescription MustBeBoolean { get => _mustbeboolean!; set => this.AssertWritable()._mustbeboolean = value; }
    /// <summary>Object must be of type Byte.</summary>
    public IMessageDescription MustBeByte { get => _mustbebyte!; set => this.AssertWritable()._mustbebyte = value; }
    /// <summary>Object must be of type Char.</summary>
    public IMessageDescription MustBeChar { get => _mustbechar!; set => this.AssertWritable()._mustbechar = value; }
    /// <summary>Object must be of type DateTime.</summary>
    public IMessageDescription MustBeDateTime { get => _mustbedatetime!; set => this.AssertWritable()._mustbedatetime = value; }
    /// <summary>Object must be of type DateTimeOffset.</summary>
    public IMessageDescription MustBeDateTimeOffset { get => _mustbedatetimeoffset!; set => this.AssertWritable()._mustbedatetimeoffset = value; }
    /// <summary>Object must be of type Decimal.</summary>
    public IMessageDescription MustBeDecimal { get => _mustbedecimal!; set => this.AssertWritable()._mustbedecimal = value; }
    /// <summary>Type must derive from Delegate.</summary>
    public IMessageDescription MustBeDelegate { get => _mustbedelegate!; set => this.AssertWritable()._mustbedelegate = value; }
    /// <summary>Object must be of type Double.</summary>
    public IMessageDescription MustBeDouble { get => _mustbedouble!; set => this.AssertWritable()._mustbedouble = value; }
    /// <summary>Object must be a root directory (&quot;C:\&quot;) or a drive letter (&quot;C&quot;).</summary>
    public IMessageDescription MustBeDriveLetterOrRootDir { get => _mustbedriveletterorrootdir!; set => this.AssertWritable()._mustbedriveletterorrootdir = value; }
    /// <summary>Type provided must be an Enum.</summary>
    public IMessageDescription MustBeEnum { get => _mustbeenum!; set => this.AssertWritable()._mustbeenum = value; }
    /// <summary>The value passed in must be an enum base or an underlying type for an enum, such as an Int32.</summary>
    public IMessageDescription MustBeEnumBaseTypeOrEnum { get => _mustbeenumbasetypeorenum!; set => this.AssertWritable()._mustbeenumbasetypeorenum = value; }
    /// <summary>Object must be of type GUID.</summary>
    public IMessageDescription MustBeGuid { get => _mustbeguid!; set => this.AssertWritable()._mustbeguid = value; }
    /// <summary>Object must be of type Int16.</summary>
    public IMessageDescription MustBeInt16 { get => _mustbeint16!; set => this.AssertWritable()._mustbeint16 = value; }
    /// <summary>Object must be of type Int32.</summary>
    public IMessageDescription MustBeInt32 { get => _mustbeint32!; set => this.AssertWritable()._mustbeint32 = value; }
    /// <summary>Object must be of type Int64.</summary>
    public IMessageDescription MustBeInt64 { get => _mustbeint64!; set => this.AssertWritable()._mustbeint64 = value; }
    /// <summary>Type must be a Pointer.</summary>
    public IMessageDescription MustBePointer { get => _mustbepointer!; set => this.AssertWritable()._mustbepointer = value; }
    /// <summary>Object must be of type SByte.</summary>
    public IMessageDescription MustBeSByte { get => _mustbesbyte!; set => this.AssertWritable()._mustbesbyte = value; }
    /// <summary>Object must be of type Single.</summary>
    public IMessageDescription MustBeSingle { get => _mustbesingle!; set => this.AssertWritable()._mustbesingle = value; }
    /// <summary>Method must be a static method.</summary>
    public IMessageDescription MustBeStatic { get => _mustbestatic!; set => this.AssertWritable()._mustbestatic = value; }
    /// <summary>Object must be of type String.</summary>
    public IMessageDescription MustBeString { get => _mustbestring!; set => this.AssertWritable()._mustbestring = value; }
    /// <summary>The pointer passed in as a String must not be in the bottom 64K of the process&#39;s address space.</summary>
    public IMessageDescription MustBeStringPtrNotAtom { get => _mustbestringptrnotatom!; set => this.AssertWritable()._mustbestringptrnotatom = value; }
    /// <summary>Object must be of type TimeSpan.</summary>
    public IMessageDescription MustBeTimeSpan { get => _mustbetimespan!; set => this.AssertWritable()._mustbetimespan = value; }
    /// <summary>Argument must be true.</summary>
    public IMessageDescription MustBeTrue { get => _mustbetrue!; set => this.AssertWritable()._mustbetrue = value; }
    /// <summary>Type must be a type provided by the runtime.</summary>
    public IMessageDescription MustBeType { get => _mustbetype!; set => this.AssertWritable()._mustbetype = value; }
    /// <summary>Object must be of type UInt16.</summary>
    public IMessageDescription MustBeUInt16 { get => _mustbeuint16!; set => this.AssertWritable()._mustbeuint16 = value; }
    /// <summary>Object must be of type UInt32.</summary>
    public IMessageDescription MustBeUInt32 { get => _mustbeuint32!; set => this.AssertWritable()._mustbeuint32 = value; }
    /// <summary>Object must be of type UInt64.</summary>
    public IMessageDescription MustBeUInt64 { get => _mustbeuint64!; set => this.AssertWritable()._mustbeuint64 = value; }
    /// <summary>Object must be of type Version.</summary>
    public IMessageDescription MustBeVersion { get => _mustbeversion!; set => this.AssertWritable()._mustbeversion = value; }
    /// <summary>Must specify valid information for parsing in the string.</summary>
    public IMessageDescription MustContainEnumInfo { get => _mustcontainenuminfo!; set => this.AssertWritable()._mustcontainenuminfo = value; }
    /// <summary>Named parameter value must not be null.</summary>
    public IMessageDescription NamedParamNull { get => _namedparamnull!; set => this.AssertWritable()._namedparamnull = value; }
    /// <summary>Named parameter array cannot be bigger than argument array.</summary>
    public IMessageDescription NamedParamTooBig { get => _namedparamtoobig!; set => this.AssertWritable()._namedparamtoobig = value; }
    /// <summary>System.StubHelpers</summary>
    public IMessageDescription NDirectBadObject { get => _ndirectbadobject!; set => this.AssertWritable()._ndirectbadobject = value; }
    /// <summary>Must provide at least one rank.</summary>
    public IMessageDescription NeedAtLeast1Rank { get => _needatleast1rank!; set => this.AssertWritable()._needatleast1rank = value; }
    /// <summary>Argument count must not be negative.</summary>
    public IMessageDescription NegativeArgCount { get => _negativeargcount!; set => this.AssertWritable()._negativeargcount = value; }
    /// <summary>Must specify binding flags describing the invoke operation required (BindingFlags.InvokeMethod CreateInstance GetField SetField GetProperty SetProperty).</summary>
    public IMessageDescription NoAccessSpec { get => _noaccessspec!; set => this.AssertWritable()._noaccessspec = value; }
    /// <summary>No parameterless constructor defined for this object.</summary>
    public IMessageDescription NoDefCTor { get => _nodefctor!; set => this.AssertWritable()._nodefctor = value; }
    /// <summary>The lower bound of target array must be zero.</summary>
    public IMessageDescription NonZeroLowerBound { get => _nonzerolowerbound!; set => this.AssertWritable()._nonzerolowerbound = value; }
    /// <summary>Method cannot be both static and virtual.</summary>
    public IMessageDescription NoStaticVirtual { get => _nostaticvirtual!; set => this.AssertWritable()._nostaticvirtual = value; }
    /// <summary>System</summary>
    public IMessageDescription NotFiniteNumberException { get => _notfinitenumberexception!; set => this.AssertWritable()._notfinitenumberexception = value; }
    /// <summary>{0} is not a GenericMethodDefinition. MakeGenericMethod may only be called on a method for which MethodBase.IsGenericMethodDefinition is true.</summary>
    public IMessageDescription NotGenericMethodDefinition { get => _notgenericmethoddefinition!; set => this.AssertWritable()._notgenericmethoddefinition = value; }
    /// <summary>Method may only be called on a Type for which Type.IsGenericParameter is true.</summary>
    public IMessageDescription NotGenericParameter { get => _notgenericparameter!; set => this.AssertWritable()._notgenericparameter = value; }
    /// <summary>{0} is not a GenericTypeDefinition. MakeGenericType may only be called on a type for which Type.IsGenericTypeDefinition is true.</summary>
    public IMessageDescription NotGenericTypeDefinition { get => _notgenerictypedefinition!; set => this.AssertWritable()._notgenerictypedefinition = value; }
    /// <summary>Object type cannot be converted to target type.</summary>
    public IMessageDescription ObjObj { get => _objobj!; set => this.AssertWritable()._objobj = value; }
    /// <summary>Object of type &#39;{0}&#39; cannot be converted to type &#39;{1}&#39;.</summary>
    public IMessageDescription ObjObjEx { get => _objobjex!; set => this.AssertWritable()._objobjex = value; }
    /// <summary>Not a legal OleAut date.</summary>
    public IMessageDescription OleAutDateInvalid { get => _oleautdateinvalid!; set => this.AssertWritable()._oleautdateinvalid = value; }
    /// <summary>OleAut date did not convert to a DateTime correctly.</summary>
    public IMessageDescription OleAutDateScale { get => _oleautdatescale!; set => this.AssertWritable()._oleautdatescale = value; }
    /// <summary>System</summary>
    public IMessageDescription OverflowException { get => _overflowexception!; set => this.AssertWritable()._overflowexception = value; }
    /// <summary>System</summary>
    public IMessageDescription ParamNameName { get => _paramnamename!; set => this.AssertWritable()._paramnamename = value; }
    /// <summary>Parameter count mismatch.</summary>
    public IMessageDescription ParmCnt { get => _parmcnt!; set => this.AssertWritable()._parmcnt = value; }
    /// <summary>Second path fragment must not be a drive or UNC name.</summary>
    public IMessageDescription Path2IsRooted { get => _path2isrooted!; set => this.AssertWritable()._path2isrooted = value; }
    /// <summary>Paths that begin with \\?\GlobalRoot are internal to the kernel and should not be opened by managed applications.</summary>
    public IMessageDescription PathGlobalRoot { get => _pathglobalroot!; set => this.AssertWritable()._pathglobalroot = value; }
    /// <summary>The path is not of a legal form.</summary>
    public IMessageDescription PathIllegal { get => _pathillegal!; set => this.AssertWritable()._pathillegal = value; }
    /// <summary>The UNC path should be of the form \\server\share.</summary>
    public IMessageDescription PathIllegalUNC { get => _pathillegalunc!; set => this.AssertWritable()._pathillegalunc = value; }
    /// <summary>Path must not be a drive.</summary>
    public IMessageDescription PathIsVolume { get => _pathisvolume!; set => this.AssertWritable()._pathisvolume = value; }
    /// <summary>SecureString is only supported on Windows 2000 SP3 and higher platforms.</summary>
    public IMessageDescription PlatformSecureString { get => _platformsecurestring!; set => this.AssertWritable()._platformsecurestring = value; }
    /// <summary>Could not find the specified property.</summary>
    public IMessageDescription PropNotFound { get => _propnotfound!; set => this.AssertWritable()._propnotfound = value; }
    /// <summary>Cannot specify both Get and Set on a property.</summary>
    public IMessageDescription PropSetGet { get => _propsetget!; set => this.AssertWritable()._propsetget = value; }
    /// <summary>Cannot specify Set on a property and Invoke on a method.</summary>
    public IMessageDescription PropSetInvoke { get => _propsetinvoke!; set => this.AssertWritable()._propsetinvoke = value; }
    /// <summary>System</summary>
    public IMessageDescription RankException { get => _rankexception!; set => this.AssertWritable()._rankexception = value; }
    /// <summary>Indices length does not match the array rank.</summary>
    public IMessageDescription RankIndices { get => _rankindices!; set => this.AssertWritable()._rankindices = value; }
    /// <summary>Number of lengths and lowerBounds must match.</summary>
    public IMessageDescription RanksAndBounds { get => _ranksandbounds!; set => this.AssertWritable()._ranksandbounds = value; }
    /// <summary>It is illegal to reflect on the custom attributes of a Type loaded via ReflectionOnlyGetType (see Assembly.ReflectionOnly) -- use CustomAttributeData instead.</summary>
    public IMessageDescription ReflectionOnlyCA { get => _reflectiononlyca!; set => this.AssertWritable()._reflectiononlyca = value; }
    /// <summary>It is illegal to get or set the value on a field on a Type loaded via ReflectionOnlyGetType.</summary>
    public IMessageDescription ReflectionOnlyField { get => _reflectiononlyfield!; set => this.AssertWritable()._reflectiononlyfield = value; }
    /// <summary>It is illegal to invoke a method on a Type loaded via ReflectionOnlyGetType.</summary>
    public IMessageDescription ReflectionOnlyInvoke { get => _reflectiononlyinvoke!; set => this.AssertWritable()._reflectiononlyinvoke = value; }
    /// <summary>The specified RegistryValueKind is an invalid value.</summary>
    public IMessageDescription RegBadKeyKind { get => _regbadkeykind!; set => this.AssertWritable()._regbadkeykind = value; }
    /// <summary>RegistryKey.GetValue does not allow a String that has a length greater than Int32.MaxValue.</summary>
    public IMessageDescription RegGetOverflowBug { get => _reggetoverflowbug!; set => this.AssertWritable()._reggetoverflowbug = value; }
    /// <summary>Registry key name must start with a valid base key name.</summary>
    public IMessageDescription RegInvalidKeyName { get => _reginvalidkeyname!; set => this.AssertWritable()._reginvalidkeyname = value; }
    /// <summary>Cannot delete a registry hive&#39;s subtree.</summary>
    public IMessageDescription RegKeyDelHive { get => _regkeydelhive!; set => this.AssertWritable()._regkeydelhive = value; }
    /// <summary>No remote connection to &#39;{0}&#39; while trying to read the registry.</summary>
    public IMessageDescription RegKeyNoRemoteConnect { get => _regkeynoremoteconnect!; set => this.AssertWritable()._regkeynoremoteconnect = value; }
    /// <summary>The specified registry key does not exist.</summary>
    public IMessageDescription RegKeyNotFound { get => _regkeynotfound!; set => this.AssertWritable()._regkeynotfound = value; }
    /// <summary>Registry HKEY was out of the legal range.</summary>
    public IMessageDescription RegKeyOutOfRange { get => _regkeyoutofrange!; set => this.AssertWritable()._regkeyoutofrange = value; }
    /// <summary>Registry key names should not be greater than 255 characters.</summary>
    public IMessageDescription RegKeyStrLenBug { get => _regkeystrlenbug!; set => this.AssertWritable()._regkeystrlenbug = value; }
    /// <summary>RegistryKey.SetValue does not support arrays of type &#39;{0}&#39;. Only Byte[] and String[] are supported.</summary>
    public IMessageDescription RegSetBadArrType { get => _regsetbadarrtype!; set => this.AssertWritable()._regsetbadarrtype = value; }
    /// <summary>The type of the value object did not match the specified RegistryValueKind or the object could not be properly converted.</summary>
    public IMessageDescription RegSetMismatchedKind { get => _regsetmismatchedkind!; set => this.AssertWritable()._regsetmismatchedkind = value; }
    /// <summary>RegistryKey.SetValue does not allow a String[] that contains a null String reference.</summary>
    public IMessageDescription RegSetStrArrNull { get => _regsetstrarrnull!; set => this.AssertWritable()._regsetstrarrnull = value; }
    /// <summary>Cannot delete a subkey tree because the subkey does not exist.</summary>
    public IMessageDescription RegSubKeyAbsent { get => _regsubkeyabsent!; set => this.AssertWritable()._regsubkeyabsent = value; }
    /// <summary>No value exists with that name.</summary>
    public IMessageDescription RegSubKeyValueAbsent { get => _regsubkeyvalueabsent!; set => this.AssertWritable()._regsubkeyvalueabsent = value; }
    /// <summary>Registry value names should not be greater than 16,383 characters.</summary>
    public IMessageDescription RegValStrLenBug { get => _regvalstrlenbug!; set => this.AssertWritable()._regvalstrlenbug = value; }
    /// <summary>Cannot remove the specified item because it was not found in the specified Collection.</summary>
    public IMessageDescription RemoveArgNotFound { get => _removeargnotfound!; set => this.AssertWritable()._removeargnotfound = value; }
    /// <summary>The ResourceReader class does not know how to read this version of .resources files. Expected version: {0} This file: {1}</summary>
    public IMessageDescription ResourceFileUnsupportedVersion { get => _resourcefileunsupportedversion!; set => this.AssertWritable()._resourcefileunsupportedversion = value; }
    /// <summary>The specified resource name &quot;{0}&quot; does not exist in the resource file.</summary>
    public IMessageDescription ResourceNameNotExist { get => _resourcenamenotexist!; set => this.AssertWritable()._resourcenamenotexist = value; }
    /// <summary>Property set method not found.</summary>
    public IMessageDescription SetMethNotFnd { get => _setmethnotfnd!; set => this.AssertWritable()._setmethnotfnd = value; }
    /// <summary>Unicode surrogate characters must be written out as pairs together in the same call, not individually. Consider passing in a character array instead.</summary>
    public IMessageDescription SurrogatesNotAllowedAsSingleChar { get => _surrogatesnotallowedassinglechar!; set => this.AssertWritable()._surrogatesnotallowedassinglechar = value; }
    /// <summary>System</summary>
    public IMessageDescription SystemException { get => _systemexception!; set => this.AssertWritable()._systemexception = value; }
    /// <summary>System</summary>
    public IMessageDescription TimeoutException { get => _timeoutexception!; set => this.AssertWritable()._timeoutexception = value; }
    /// <summary>System</summary>
    public IMessageDescription TypeAccessException { get => _typeaccessexception!; set => this.AssertWritable()._typeaccessexception = value; }
    /// <summary>System</summary>
    public IMessageDescription TypeLoadException { get => _typeloadexception!; set => this.AssertWritable()._typeloadexception = value; }
    /// <summary>A null or zero length string does not represent a valid Type.</summary>
    public IMessageDescription TypeLoadNullStr { get => _typeloadnullstr!; set => this.AssertWritable()._typeloadnullstr = value; }
    /// <summary>TypedReferences cannot be redefined as primitives.</summary>
    public IMessageDescription TypeRefPrimitve { get => _typerefprimitve!; set => this.AssertWritable()._typerefprimitve = value; }
    /// <summary>System</summary>
    public IMessageDescription TypeUnloadedException { get => _typeunloadedexception!; set => this.AssertWritable()._typeunloadedexception = value; }
    /// <summary>System</summary>
    public IMessageDescription UnauthorizedAccessException { get => _unauthorizedaccessexception!; set => this.AssertWritable()._unauthorizedaccessexception = value; }
    /// <summary>Late bound operations cannot be performed on fields with types for which Type.ContainsGenericParameters is true.</summary>
    public IMessageDescription UnboundGenField { get => _unboundgenfield!; set => this.AssertWritable()._unboundgenfield = value; }
    /// <summary>Late bound operations cannot be performed on types or methods for which ContainsGenericParameters is true.</summary>
    public IMessageDescription UnboundGenParam { get => _unboundgenparam!; set => this.AssertWritable()._unboundgenparam = value; }
    /// <summary>Unknown TypeCode value.</summary>
    public IMessageDescription UnknownTypeCode { get => _unknowntypecode!; set => this.AssertWritable()._unknowntypecode = value; }
    /// <summary>Missing parameter does not have a default value.</summary>
    public IMessageDescription VarMissNull { get => _varmissnull!; set => this.AssertWritable()._varmissnull = value; }
    /// <summary>Version string portion was too short or too long.</summary>
    public IMessageDescription VersionString { get => _versionstring!; set => this.AssertWritable()._versionstring = value; }
    /// <summary>IAsyncResult object did not come from the corresponding async method on this type.</summary>
    public IMessageDescription WrongAsyncResult { get => _wrongasyncresult!; set => this.AssertWritable()._wrongasyncresult = value; }
    /// <summary>The value &quot;{0}&quot; is not of type &quot;{1}&quot; and cannot be used in this generic collection.</summary>
    public IMessageDescription WrongType { get => _wrongtype!; set => this.AssertWritable()._wrongtype = value; }
    /// <summary>Absolute path information is required.</summary>
    public IMessageDescription AbsolutePathRequired { get => _absolutepathrequired!; set => this.AssertWritable()._absolutepathrequired = value; }
    /// <summary>An item with the same key has already been added.</summary>
    public IMessageDescription AddingDuplicate { get => _addingduplicate!; set => this.AssertWritable()._addingduplicate = value; }
    /// <summary>Item has already been added. Key in dictionary: &#39;{0}&#39; Key being added: &#39;{1}&#39;</summary>
    public IMessageDescription AddingDuplicate2 { get => _addingduplicate2!; set => this.AssertWritable()._addingduplicate2 = value; }
    /// <summary>The AdjustmentRule array cannot contain null elements.</summary>
    public IMessageDescription AdjustmentRulesNoNulls { get => _adjustmentrulesnonulls!; set => this.AssertWritable()._adjustmentrulesnonulls = value; }
    /// <summary>The elements of the AdjustmentRule array must be in chronological order and must not overlap.</summary>
    public IMessageDescription AdjustmentRulesOutOfOrder { get => _adjustmentrulesoutoforder!; set => this.AssertWritable()._adjustmentrulesoutoforder = value; }
    /// <summary>Specified slot number was invalid.</summary>
    public IMessageDescription ALSInvalidSlot { get => _alsinvalidslot!; set => this.AssertWritable()._alsinvalidslot = value; }
    /// <summary>An ApplicationTrust must have an application identity before it can be persisted.</summary>
    public IMessageDescription ApplicationTrustShouldHaveIdentity { get => _applicationtrustshouldhaveidentity!; set => this.AssertWritable()._applicationtrustshouldhaveidentity = value; }
    /// <summary>Argument cannot be zero.</summary>
    public IMessageDescription ArgumentZero { get => _argumentzero!; set => this.AssertWritable()._argumentzero = value; }
    /// <summary>Assembly was already fully trusted.</summary>
    public IMessageDescription AssemblyAlreadyFullTrust { get => _assemblyalreadyfulltrust!; set => this.AssertWritable()._assemblyalreadyfulltrust = value; }
    /// <summary>Assembly was not fully trusted.</summary>
    public IMessageDescription AssemblyNotFullTrust { get => _assemblynotfulltrust!; set => this.AssertWritable()._assemblynotfulltrust = value; }
    /// <summary>Attribute names must be unique.</summary>
    public IMessageDescription AttributeNamesMustBeUnique { get => _attributenamesmustbeunique!; set => this.AssertWritable()._attributenamesmustbeunique = value; }
    /// <summary>Interface method must be abstract and virtual.</summary>
    public IMessageDescription BadAttributeOnInterfaceMethod { get => _badattributeoninterfacemethod!; set => this.AssertWritable()._badattributeoninterfacemethod = value; }
    /// <summary>Bad &#39;{0}&#39; while generating unmanaged resource information.</summary>
    public IMessageDescription BadCAForUnmngRSC { get => _badcaforunmngrsc!; set => this.AssertWritable()._badcaforunmngrsc = value; }
    /// <summary>Cannot have private or static constructor.</summary>
    public IMessageDescription BadConstructor { get => _badconstructor!; set => this.AssertWritable()._badconstructor = value; }
    /// <summary>Constructor must have standard calling convention.</summary>
    public IMessageDescription BadConstructorCallConv { get => _badconstructorcallconv!; set => this.AssertWritable()._badconstructorcallconv = value; }
    /// <summary>Field must be on the same type of the given ConstructorInfo.</summary>
    public IMessageDescription BadFieldForConstructorBuilder { get => _badfieldforconstructorbuilder!; set => this.AssertWritable()._badfieldforconstructorbuilder = value; }
    /// <summary>Field signatures do not have return types.</summary>
    public IMessageDescription BadFieldSig { get => _badfieldsig!; set => this.AssertWritable()._badfieldsig = value; }
    /// <summary>Bad field type in defining field.</summary>
    public IMessageDescription BadFieldType { get => _badfieldtype!; set => this.AssertWritable()._badfieldtype = value; }
    /// <summary>A BadImageFormatException has been thrown while parsing the signature. This is likely due to lack of a generic context. Ensure genericTypeArguments and genericMethodArguments are provided and contain enough context.</summary>
    public IMessageDescription BadImageFormatExceptionResolve { get => _badimageformatexceptionresolve!; set => this.AssertWritable()._badimageformatexceptionresolve = value; }
    /// <summary>Visibility of interfaces must be one of the following: NestedAssembly, NestedFamANDAssem, NestedFamily, NestedFamORAssem, NestedPrivate or NestedPublic.</summary>
    public IMessageDescription BadNestedTypeFlags { get => _badnestedtypeflags!; set => this.AssertWritable()._badnestedtypeflags = value; }
    /// <summary>Invalid ObjRef provided to &#39;{0}&#39;.</summary>
    public IMessageDescription BadObjRef { get => _badobjref!; set => this.AssertWritable()._badobjref = value; }
    /// <summary>Parameter count does not match passed in argument value count.</summary>
    public IMessageDescription BadParameterCountsForConstructor { get => _badparametercountsforconstructor!; set => this.AssertWritable()._badparametercountsforconstructor = value; }
    /// <summary>Cannot emit a CustomAttribute with argument of type {0}.</summary>
    public IMessageDescription BadParameterTypeForCAB { get => _badparametertypeforcab!; set => this.AssertWritable()._badparametertypeforcab = value; }
    /// <summary>Passed in argument value at index {0} does not match the parameter type.</summary>
    public IMessageDescription BadParameterTypeForConstructor { get => _badparametertypeforconstructor!; set => this.AssertWritable()._badparametertypeforconstructor = value; }
    /// <summary>PInvoke methods must be static and native and cannot be abstract.</summary>
    public IMessageDescription BadPInvokeMethod { get => _badpinvokemethod!; set => this.AssertWritable()._badpinvokemethod = value; }
    /// <summary>PInvoke methods cannot exist on interfaces.</summary>
    public IMessageDescription BadPInvokeOnInterface { get => _badpinvokeoninterface!; set => this.AssertWritable()._badpinvokeoninterface = value; }
    /// <summary>Property must be on the same type of the given ConstructorInfo.</summary>
    public IMessageDescription BadPropertyForConstructorBuilder { get => _badpropertyforconstructorbuilder!; set => this.AssertWritable()._badpropertyforconstructorbuilder = value; }
    /// <summary>Unknown value for the ResourceScope: {0} Too many resource type bits may be set.</summary>
    public IMessageDescription BadResourceScopeTypeBits { get => _badresourcescopetypebits!; set => this.AssertWritable()._badresourcescopetypebits = value; }
    /// <summary>Unknown value for the ResourceScope: {0} Too many resource visibility bits may be set.</summary>
    public IMessageDescription BadResourceScopeVisibilityBits { get => _badresourcescopevisibilitybits!; set => this.AssertWritable()._badresourcescopevisibilitybits = value; }
    /// <summary>Incorrect signature format.</summary>
    public IMessageDescription BadSigFormat { get => _badsigformat!; set => this.AssertWritable()._badsigformat = value; }
    /// <summary>Data size must be &gt; 0 and &lt; 0x3f0000</summary>
    public IMessageDescription BadSizeForData { get => _badsizefordata!; set => this.AssertWritable()._badsizefordata = value; }
    /// <summary>Bad type attributes. Invalid layout attribute specified.</summary>
    public IMessageDescription BadTypeAttrInvalidLayout { get => _badtypeattrinvalidlayout!; set => this.AssertWritable()._badtypeattrinvalidlayout = value; }
    /// <summary>Bad type attributes. Nested visibility flag set on a non-nested type.</summary>
    public IMessageDescription BadTypeAttrNestedVisibilityOnNonNestedType { get => _badtypeattrnestedvisibilityonnonnestedtype!; set => this.AssertWritable()._badtypeattrnestedvisibilityonnonnestedtype = value; }
    /// <summary>Bad type attributes. Non-nested visibility flag set on a nested type.</summary>
    public IMessageDescription BadTypeAttrNonNestedVisibilityNestedType { get => _badtypeattrnonnestedvisibilitynestedtype!; set => this.AssertWritable()._badtypeattrnonnestedvisibilitynestedtype = value; }
    /// <summary>Bad type attributes. Reserved bits set on the type.</summary>
    public IMessageDescription BadTypeAttrReservedBitsSet { get => _badtypeattrreservedbitsset!; set => this.AssertWritable()._badtypeattrreservedbitsset = value; }
    /// <summary>An invalid type was used as a custom attribute constructor argument, field or property.</summary>
    public IMessageDescription BadTypeInCustomAttribute { get => _badtypeincustomattribute!; set => this.AssertWritable()._badtypeincustomattribute = value; }
    /// <summary>Public key must be specified.</summary>
    public IMessageDescription BlobCannotBeNull { get => _blobcannotbenull!; set => this.AssertWritable()._blobcannotbenull = value; }
    /// <summary>Cannot get TypeToken for a ByRef type.</summary>
    public IMessageDescription CannotGetTypeTokenForByRef { get => _cannotgettypetokenforbyref!; set => this.AssertWritable()._cannotgettypetokenforbyref = value; }
    /// <summary>Cannot set parent to an interface.</summary>
    public IMessageDescription CannotSetParentToInterface { get => _cannotsetparenttointerface!; set => this.AssertWritable()._cannotsetparenttointerface = value; }
    /// <summary>All objects in the input list must have a parent type of &#39;CodeGroup&#39;.</summary>
    public IMessageDescription CodeGroupChildrenMustBeCodeGroups { get => _codegroupchildrenmustbecodegroups!; set => this.AssertWritable()._codegroupchildrenmustbecodegroups = value; }
    /// <summary>CompareOption.Ordinal cannot be used with other options.</summary>
    public IMessageDescription CompareOptionOrdinal { get => _compareoptionordinal!; set => this.AssertWritable()._compareoptionordinal = value; }
    /// <summary>The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal.</summary>
    public IMessageDescription ConflictingDateTimeRoundtripStyles { get => _conflictingdatetimeroundtripstyles!; set => this.AssertWritable()._conflictingdatetimeroundtripstyles = value; }
    /// <summary>The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.</summary>
    public IMessageDescription ConflictingDateTimeStyles { get => _conflictingdatetimestyles!; set => this.AssertWritable()._conflictingdatetimestyles = value; }
    /// <summary>Constant does not match the defined type.</summary>
    public IMessageDescription ConstantDoesntMatch { get => _constantdoesntmatch!; set => this.AssertWritable()._constantdoesntmatch = value; }
    /// <summary>Null is not a valid constant value for this type.</summary>
    public IMessageDescription ConstantNull { get => _constantnull!; set => this.AssertWritable()._constantnull = value; }
    /// <summary>The specified constructor must be declared on a generic type definition.</summary>
    public IMessageDescription ConstructorNeedGenericDeclaringType { get => _constructorneedgenericdeclaringtype!; set => this.AssertWritable()._constructorneedgenericdeclaringtype = value; }
    /// <summary>Conversion buffer overflow.</summary>
    public IMessageDescription ConversionOverflow { get => _conversionoverflow!; set => this.AssertWritable()._conversionoverflow = value; }
    /// <summary>The conversion could not be completed because the supplied DateTime did not have the Kind property set correctly. For example, when the Kind property is DateTimeKind.Local, the source time zone must be TimeZoneInfo.Local.</summary>
    public IMessageDescription ConvertMismatch { get => _convertmismatch!; set => this.AssertWritable()._convertmismatch = value; }
    /// <summary>Culture ID {0} (0x{0:X4}) is a neutral culture; a region cannot be created from it.</summary>
    public IMessageDescription CultureIsNeutral { get => _cultureisneutral!; set => this.AssertWritable()._cultureisneutral = value; }
    /// <summary>Customized cultures cannot be passed by LCID, only by name.</summary>
    public IMessageDescription CustomCultureCannotBePassedByNumber { get => _customculturecannotbepassedbynumber!; set => this.AssertWritable()._customculturecannotbepassedbynumber = value; }
    /// <summary>Parameters &#39;members&#39; and &#39;data&#39; must have the same length.</summary>
    public IMessageDescription DataLengthDifferent { get => _datalengthdifferent!; set => this.AssertWritable()._datalengthdifferent = value; }
    /// <summary>The binary data must result in a DateTime with ticks between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</summary>
    public IMessageDescription DateTimeBadBinaryData { get => _datetimebadbinarydata!; set => this.AssertWritable()._datetimebadbinarydata = value; }
    /// <summary>The supplied DateTime must have the Year, Month, and Day properties set to 1. The time cannot be specified more precisely than whole milliseconds.</summary>
    public IMessageDescription DateTimeHasTicks { get => _datetimehasticks!; set => this.AssertWritable()._datetimehasticks = value; }
    /// <summary>The supplied DateTime includes a TimeOfDay setting. This is not supported.</summary>
    public IMessageDescription DateTimeHasTimeOfDay { get => _datetimehastimeofday!; set => this.AssertWritable()._datetimehastimeofday = value; }
    /// <summary>The supplied DateTime represents an invalid time. For example, when the clock is adjusted forward, any time in the period that is skipped is invalid.</summary>
    public IMessageDescription DateTimeIsInvalid { get => _datetimeisinvalid!; set => this.AssertWritable()._datetimeisinvalid = value; }
    /// <summary>The supplied DateTime is not in an ambiguous time range.</summary>
    public IMessageDescription DateTimeIsNotAmbiguous { get => _datetimeisnotambiguous!; set => this.AssertWritable()._datetimeisnotambiguous = value; }
    /// <summary>The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified.</summary>
    public IMessageDescription DateTimeKindMustBeUnspecified { get => _datetimekindmustbeunspecified!; set => this.AssertWritable()._datetimekindmustbeunspecified = value; }
    /// <summary>The DateTimeStyles value &#39;NoCurrentDateDefault&#39; is not allowed when parsing DateTimeOffset.</summary>
    public IMessageDescription DateTimeOffsetInvalidDateTimeStyles { get => _datetimeoffsetinvaliddatetimestyles!; set => this.AssertWritable()._datetimeoffsetinvaliddatetimestyles = value; }
    /// <summary>The supplied DateTimeOffset is not in an ambiguous time range.</summary>
    public IMessageDescription DateTimeOffsetIsNotAmbiguous { get => _datetimeoffsetisnotambiguous!; set => this.AssertWritable()._datetimeoffsetisnotambiguous = value; }
    /// <summary>Duplicate file names.</summary>
    public IMessageDescription DuplicatedFileName { get => _duplicatedfilename!; set => this.AssertWritable()._duplicatedfilename = value; }
    /// <summary>Tried to add NamedPermissionSet with non-unique name.</summary>
    public IMessageDescription DuplicateName { get => _duplicatename!; set => this.AssertWritable()._duplicatename = value; }
    /// <summary>Duplicate resource name within an assembly.</summary>
    public IMessageDescription DuplicateResourceName { get => _duplicateresourcename!; set => this.AssertWritable()._duplicateresourcename = value; }
    /// <summary>Duplicate type name within an assembly.</summary>
    public IMessageDescription DuplicateTypeName { get => _duplicatetypename!; set => this.AssertWritable()._duplicatetypename = value; }
    /// <summary>ApplicationId cannot have an empty string for the name.</summary>
    public IMessageDescription EmptyApplicationName { get => _emptyapplicationname!; set => this.AssertWritable()._emptyapplicationname = value; }
    /// <summary>Decimal separator cannot be the empty string.</summary>
    public IMessageDescription EmptyDecString { get => _emptydecstring!; set => this.AssertWritable()._emptydecstring = value; }
    /// <summary>Empty file name is not legal.</summary>
    public IMessageDescription EmptyFileName { get => _emptyfilename!; set => this.AssertWritable()._emptyfilename = value; }
    /// <summary>Empty path name is not legal.</summary>
    public IMessageDescription EmptyPath { get => _emptypath!; set => this.AssertWritable()._emptypath = value; }
    /// <summary>StrongName cannot have an empty string for the assembly name.</summary>
    public IMessageDescription EmptyStrongName { get => _emptystrongname!; set => this.AssertWritable()._emptystrongname = value; }
    /// <summary>Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder &#39;{0}&#39; fallback &#39;{1}&#39;.</summary>
    public IMessageDescription EncoderFallbackNotEmpty { get => _encoderfallbacknotempty!; set => this.AssertWritable()._encoderfallbacknotempty = value; }
    /// <summary>The output byte buffer is too small to contain the encoded data, encoding &#39;{0}&#39; fallback &#39;{1}&#39;.</summary>
    public IMessageDescription EncodingConversionOverflowBytes { get => _encodingconversionoverflowbytes!; set => this.AssertWritable()._encodingconversionoverflowbytes = value; }
    /// <summary>The output char buffer is too small to contain the decoded characters, encoding &#39;{0}&#39; fallback &#39;{1}&#39;.</summary>
    public IMessageDescription EncodingConversionOverflowChars { get => _encodingconversionoverflowchars!; set => this.AssertWritable()._encodingconversionoverflowchars = value; }
    /// <summary>The argument type, &#39;{0}&#39;, is not the same as the enum type &#39;{1}&#39;.</summary>
    public IMessageDescription EnumTypeDoesNotMatch { get => _enumtypedoesnotmatch!; set => this.AssertWritable()._enumtypedoesnotmatch = value; }
    /// <summary>Failed to create a code group of type &#39;{0}&#39;.</summary>
    public IMessageDescription FailedCodeGroup { get => _failedcodegroup!; set => this.AssertWritable()._failedcodegroup = value; }
    /// <summary>Cannot change fallback when buffer is not empty. Previous Convert() call left data in the fallback buffer.</summary>
    public IMessageDescription FallbackBufferNotEmpty { get => _fallbackbuffernotempty!; set => this.AssertWritable()._fallbackbuffernotempty = value; }
    /// <summary>FrameworkName is invalid.</summary>
    public IMessageDescription FrameworkNameInvalid { get => _frameworknameinvalid!; set => this.AssertWritable()._frameworknameinvalid = value; }
    /// <summary>FrameworkName version component is missing.</summary>
    public IMessageDescription FrameworkNameMissingVersion { get => _frameworknamemissingversion!; set => this.AssertWritable()._frameworknamemissingversion = value; }
    /// <summary>FrameworkName cannot have less than two components or more than three components.</summary>
    public IMessageDescription FrameworkNameTooShort { get => _frameworknametooshort!; set => this.AssertWritable()._frameworknametooshort = value; }
    /// <summary>GenericArguments[{0}], &#39;{1}&#39;, on &#39;{2}&#39; violates the constraint of type &#39;{3}&#39;.</summary>
    public IMessageDescription GenConstraintViolation { get => _genconstraintviolation!; set => this.AssertWritable()._genconstraintviolation = value; }
    /// <summary>The number of generic arguments provided doesn&#39;t equal the arity of the generic type definition.</summary>
    public IMessageDescription GenericArgsCount { get => _genericargscount!; set => this.AssertWritable()._genericargscount = value; }
    /// <summary>Generic types are not valid.</summary>
    public IMessageDescription GenericsInvalid { get => _genericsinvalid!; set => this.AssertWritable()._genericsinvalid = value; }
    /// <summary>Global members must be static.</summary>
    public IMessageDescription GlobalFunctionHasToBeStatic { get => _globalfunctionhastobestatic!; set => this.AssertWritable()._globalfunctionhastobestatic = value; }
    /// <summary>Left to right characters may not be mixed with right to left characters in IDN labels.</summary>
    public IMessageDescription IdnBadBidi { get => _idnbadbidi!; set => this.AssertWritable()._idnbadbidi = value; }
    /// <summary>IDN labels must be between 1 and 63 characters long.</summary>
    public IMessageDescription IdnBadLabelSize { get => _idnbadlabelsize!; set => this.AssertWritable()._idnbadlabelsize = value; }
    /// <summary>IDN names must be between 1 and {0} characters long.</summary>
    public IMessageDescription IdnBadNameSize { get => _idnbadnamesize!; set => this.AssertWritable()._idnbadnamesize = value; }
    /// <summary>Invalid IDN encoded string.</summary>
    public IMessageDescription IdnBadPunycode { get => _idnbadpunycode!; set => this.AssertWritable()._idnbadpunycode = value; }
    /// <summary>Label contains character &#39;{0}&#39; not allowed with UseStd3AsciiRules</summary>
    public IMessageDescription IdnBadStd3 { get => _idnbadstd3!; set => this.AssertWritable()._idnbadstd3 = value; }
    /// <summary>Decoded string is not a valid IDN name.</summary>
    public IMessageDescription IdnIllegalName { get => _idnillegalname!; set => this.AssertWritable()._idnillegalname = value; }
    /// <summary>Application identity does not have same number of components as manifest paths.</summary>
    public IMessageDescription IllegalAppId { get => _illegalappid!; set => this.AssertWritable()._illegalappid = value; }
    /// <summary>Application identity does not match identities in manifests.</summary>
    public IMessageDescription IllegalAppIdMismatch { get => _illegalappidmismatch!; set => this.AssertWritable()._illegalappidmismatch = value; }
    /// <summary>Environment variable name cannot contain equal character.</summary>
    public IMessageDescription IllegalEnvVarName { get => _illegalenvvarname!; set => this.AssertWritable()._illegalenvvarname = value; }
    /// <summary>Illegal name.</summary>
    public IMessageDescription IllegalName { get => _illegalname!; set => this.AssertWritable()._illegalname = value; }
    /// <summary>Illegal security permission zone specified.</summary>
    public IMessageDescription IllegalZone { get => _illegalzone!; set => this.AssertWritable()._illegalzone = value; }
    /// <summary>Unable to impersonate user.</summary>
    public IMessageDescription ImpersonateUser { get => _impersonateuser!; set => this.AssertWritable()._impersonateuser = value; }
    /// <summary>At least one object must implement IComparable.</summary>
    public IMessageDescription ImplementIComparable { get => _implementicomparable!; set => this.AssertWritable()._implementicomparable = value; }
    /// <summary>Improper types in collection.</summary>
    public IMessageDescription ImproperType { get => _impropertype!; set => this.AssertWritable()._impropertype = value; }
    /// <summary>The specified space is not sufficient to copy the elements from this Collection.</summary>
    public IMessageDescription InsufficientSpaceToCopyCollection { get => _insufficientspacetocopycollection!; set => this.AssertWritable()._insufficientspacetocopycollection = value; }
    /// <summary>No flags can be set.</summary>
    public IMessageDescription InvalidAnyFlag { get => _invalidanyflag!; set => this.AssertWritable()._invalidanyflag = value; }
    /// <summary>Append access can be requested only in write-only mode.</summary>
    public IMessageDescription InvalidAppendMode { get => _invalidappendmode!; set => this.AssertWritable()._invalidappendmode = value; }
    /// <summary>Invalid identity: no deployment or application identity specified.</summary>
    public IMessageDescription InvalidAppId { get => _invalidappid!; set => this.AssertWritable()._invalidappid = value; }
    /// <summary>Type of argument is not compatible with the generic comparer.</summary>
    public IMessageDescription InvalidArgumentForComparison { get => _invalidargumentforcomparison!; set => this.AssertWritable()._invalidargumentforcomparison = value; }
    /// <summary>Not a valid calendar for the given culture.</summary>
    public IMessageDescription InvalidCalendar { get => _invalidcalendar!; set => this.AssertWritable()._invalidcalendar = value; }
    /// <summary>Invalid Unicode code point found at index {0}.</summary>
    public IMessageDescription InvalidCharSequence { get => _invalidcharsequence!; set => this.AssertWritable()._invalidcharsequence = value; }
    /// <summary>String contains invalid Unicode code points.</summary>
    public IMessageDescription InvalidCharSequenceNoIndex { get => _invalidcharsequencenoindex!; set => this.AssertWritable()._invalidcharsequencenoindex = value; }
    /// <summary>The specified constructor must be declared on the generic type definition of the specified type.</summary>
    public IMessageDescription InvalidConstructorDeclaringType { get => _invalidconstructordeclaringtype!; set => this.AssertWritable()._invalidconstructordeclaringtype = value; }
    /// <summary>The ConstructorInfo object is not valid.</summary>
    public IMessageDescription InvalidConstructorInfo { get => _invalidconstructorinfo!; set => this.AssertWritable()._invalidconstructorinfo = value; }
    /// <summary>Culture name &#39;{0}&#39; is not supported.</summary>
    public IMessageDescription InvalidCultureName { get => _invalidculturename!; set => this.AssertWritable()._invalidculturename = value; }
    /// <summary>Invalid DateTimeKind value.</summary>
    public IMessageDescription InvalidDateTimeKind { get => _invaliddatetimekind!; set => this.AssertWritable()._invaliddatetimekind = value; }
    /// <summary>An undefined DateTimeStyles value is being used.</summary>
    public IMessageDescription InvalidDateTimeStyles { get => _invaliddatetimestyles!; set => this.AssertWritable()._invaliddatetimestyles = value; }
    /// <summary>The DigitSubstitution property must be of a valid member of the DigitShapes enumeration. Valid entries include Context, NativeNational or None.</summary>
    public IMessageDescription InvalidDigitSubstitution { get => _invaliddigitsubstitution!; set => this.AssertWritable()._invaliddigitsubstitution = value; }
    /// <summary>Invalid directory, &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidDirectory { get => _invaliddirectory!; set => this.AssertWritable()._invaliddirectory = value; }
    /// <summary>Invalid directory on URL.</summary>
    public IMessageDescription InvalidDirectoryOnUrl { get => _invaliddirectoryonurl!; set => this.AssertWritable()._invaliddirectoryonurl = value; }
    /// <summary>Invalid element name &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidElementName { get => _invalidelementname!; set => this.AssertWritable()._invalidelementname = value; }
    /// <summary>Invalid element tag &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidElementTag { get => _invalidelementtag!; set => this.AssertWritable()._invalidelementtag = value; }
    /// <summary>Invalid element text &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidElementText { get => _invalidelementtext!; set => this.AssertWritable()._invalidelementtext = value; }
    /// <summary>Invalid element value &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidElementValue { get => _invalidelementvalue!; set => this.AssertWritable()._invalidelementvalue = value; }
    /// <summary>The Enum type should contain one and only one instance field.</summary>
    public IMessageDescription InvalidEnum { get => _invalidenum!; set => this.AssertWritable()._invalidenum = value; }
    /// <summary>The value &#39;{0}&#39; is not valid for this usage of the type {1}.</summary>
    public IMessageDescription InvalidEnumValue { get => _invalidenumvalue!; set => this.AssertWritable()._invalidenumvalue = value; }
    /// <summary>The specified field must be declared on the generic type definition of the specified type.</summary>
    public IMessageDescription InvalidFieldDeclaringType { get => _invalidfielddeclaringtype!; set => this.AssertWritable()._invalidfielddeclaringtype = value; }
    /// <summary>The FieldInfo object is not valid.</summary>
    public IMessageDescription InvalidFieldInfo { get => _invalidfieldinfo!; set => this.AssertWritable()._invalidfieldinfo = value; }
    /// <summary>Combining FileMode: {0} with FileAccess: {1} is invalid.</summary>
    public IMessageDescription InvalidFileModeAccessCombo { get => _invalidfilemodeaccesscombo!; set => this.AssertWritable()._invalidfilemodeaccesscombo = value; }
    /// <summary>Combining FileMode: {0} with FileSystemRights: {1} is invalid.</summary>
    public IMessageDescription InvalidFileModeRightsCombo { get => _invalidfilemoderightscombo!; set => this.AssertWritable()._invalidfilemoderightscombo = value; }
    /// <summary>Combining FileMode: {0} with FileSystemRights: {1} is invalid. FileMode.Truncate is valid only when used with FileSystemRights.Write.</summary>
    public IMessageDescription InvalidFileModeTruncateRightsCombo { get => _invalidfilemodetruncaterightscombo!; set => this.AssertWritable()._invalidfilemodetruncaterightscombo = value; }
    /// <summary>Value of flags is invalid.</summary>
    public IMessageDescription InvalidFlag { get => _invalidflag!; set => this.AssertWritable()._invalidflag = value; }
    /// <summary>Every element in the value array should be between one and nine, except for the last element, which can be zero.</summary>
    public IMessageDescription InvalidGroupSize { get => _invalidgroupsize!; set => this.AssertWritable()._invalidgroupsize = value; }
    /// <summary>The handle is invalid.</summary>
    public IMessageDescription InvalidHandle2 { get => _invalidhandle2!; set => this.AssertWritable()._invalidhandle2 = value; }
    /// <summary>Improperly formatted hex string.</summary>
    public IMessageDescription InvalidHexFormat { get => _invalidhexformat!; set => this.AssertWritable()._invalidhexformat = value; }
    /// <summary>Found a high surrogate char without a following low surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.</summary>
    public IMessageDescription InvalidHighSurrogate { get => _invalidhighsurrogate!; set => this.AssertWritable()._invalidhighsurrogate = value; }
    /// <summary>The specified ID parameter &#39;{0}&#39; is not supported.</summary>
    public IMessageDescription InvalidId { get => _invalidid!; set => this.AssertWritable()._invalidid = value; }
    /// <summary>Invalid token for impersonation - it cannot be duplicated.</summary>
    public IMessageDescription InvalidImpersonationToken { get => _invalidimpersonationtoken!; set => this.AssertWritable()._invalidimpersonationtoken = value; }
    /// <summary>Key was invalid.</summary>
    public IMessageDescription InvalidKey { get => _invalidkey!; set => this.AssertWritable()._invalidkey = value; }
    /// <summary>&#39;{0}&#39; is not a valid KeyStore name.</summary>
    public IMessageDescription InvalidKeyStore { get => _invalidkeystore!; set => this.AssertWritable()._invalidkeystore = value; }
    /// <summary>This type cannot be represented as a custom attribute.</summary>
    public IMessageDescription InvalidKindOfTypeForCA { get => _invalidkindoftypeforca!; set => this.AssertWritable()._invalidkindoftypeforca = value; }
    /// <summary>Found a low surrogate char without a preceding high surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.</summary>
    public IMessageDescription InvalidLowSurrogate { get => _invalidlowsurrogate!; set => this.AssertWritable()._invalidlowsurrogate = value; }
    /// <summary>The MarshalByRefObject is not valid.</summary>
    public IMessageDescription InvalidMarshalByRefObject { get => _invalidmarshalbyrefobject!; set => this.AssertWritable()._invalidmarshalbyrefobject = value; }
    /// <summary>The member must be either a field or a property.</summary>
    public IMessageDescription InvalidMemberForNamedArgument { get => _invalidmemberfornamedargument!; set => this.AssertWritable()._invalidmemberfornamedargument = value; }
    /// <summary>The specified method must be declared on the generic type definition of the specified type.</summary>
    public IMessageDescription InvalidMethodDeclaringType { get => _invalidmethoddeclaringtype!; set => this.AssertWritable()._invalidmethoddeclaringtype = value; }
    /// <summary>Invalid name.</summary>
    public IMessageDescription InvalidName { get => _invalidname!; set => this.AssertWritable()._invalidname = value; }
    /// <summary>The NativeDigits array must contain exactly ten members.</summary>
    public IMessageDescription InvalidNativeDigitCount { get => _invalidnativedigitcount!; set => this.AssertWritable()._invalidnativedigitcount = value; }
    /// <summary>Each member of the NativeDigits array must be a single text element (one or more UTF16 code points) with a Unicode Nd (Number, Decimal Digit) property indicating it is a digit.</summary>
    public IMessageDescription InvalidNativeDigitValue { get => _invalidnativedigitvalue!; set => this.AssertWritable()._invalidnativedigitvalue = value; }
    /// <summary>The region name {0} should not correspond to neutral culture; a specific culture name is required.</summary>
    public IMessageDescription InvalidNeutralRegionName { get => _invalidneutralregionname!; set => this.AssertWritable()._invalidneutralregionname = value; }
    /// <summary>Invalid or unsupported normalization form.</summary>
    public IMessageDescription InvalidNormalizationForm { get => _invalidnormalizationform!; set => this.AssertWritable()._invalidnormalizationform = value; }
    /// <summary>An undefined NumberStyles value is being used.</summary>
    public IMessageDescription InvalidNumberStyles { get => _invalidnumberstyles!; set => this.AssertWritable()._invalidnumberstyles = value; }
    /// <summary>Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.</summary>
    public IMessageDescription InvalidOffLen { get => _invalidofflen!; set => this.AssertWritable()._invalidofflen = value; }
    /// <summary>Ldtoken, Ldftn and Ldvirtftn OpCodes cannot target DynamicMethods.</summary>
    public IMessageDescription InvalidOpCodeOnDynamicMethod { get => _invalidopcodeondynamicmethod!; set => this.AssertWritable()._invalidopcodeondynamicmethod = value; }
    /// <summary>The ParameterInfo object is not valid.</summary>
    public IMessageDescription InvalidParameterInfo { get => _invalidparameterinfo!; set => this.AssertWritable()._invalidparameterinfo = value; }
    /// <summary>Invalid type for ParameterInfo member in Attribute class.</summary>
    public IMessageDescription InvalidParamInfo { get => _invalidparaminfo!; set => this.AssertWritable()._invalidparaminfo = value; }
    /// <summary>Illegal characters in path.</summary>
    public IMessageDescription InvalidPathChars { get => _invalidpathchars!; set => this.AssertWritable()._invalidpathchars = value; }
    /// <summary>Invalid permission state.</summary>
    public IMessageDescription InvalidPermissionState { get => _invalidpermissionstate!; set => this.AssertWritable()._invalidpermissionstate = value; }
    /// <summary>The REG_TZI_FORMAT structure is corrupt.</summary>
    public IMessageDescription InvalidREGTZIFORMAT { get => _invalidregtziformat!; set => this.AssertWritable()._invalidregtziformat = value; }
    /// <summary>The specified RegistryKeyPermissionCheck value is invalid.</summary>
    public IMessageDescription InvalidRegistryKeyPermissionCheck { get => _invalidregistrykeypermissioncheck!; set => this.AssertWritable()._invalidregistrykeypermissioncheck = value; }
    /// <summary>The specified RegistryOptions value is invalid.</summary>
    public IMessageDescription InvalidRegistryOptionsCheck { get => _invalidregistryoptionscheck!; set => this.AssertWritable()._invalidregistryoptionscheck = value; }
    /// <summary>The specified RegistryView value is invalid.</summary>
    public IMessageDescription InvalidRegistryViewCheck { get => _invalidregistryviewcheck!; set => this.AssertWritable()._invalidregistryviewcheck = value; }
    /// <summary>The given culture name &#39;{0}&#39; cannot be used to locate a resource file. Resource filenames must consist of only letters, numbers, hyphens or underscores.</summary>
    public IMessageDescription InvalidResourceCultureName { get => _invalidresourceculturename!; set => this.AssertWritable()._invalidresourceculturename = value; }
    /// <summary>Offset and length were greater than the size of the SafeBuffer.</summary>
    public IMessageDescription InvalidSafeBufferOffLen { get => _invalidsafebufferofflen!; set => this.AssertWritable()._invalidsafebufferofflen = value; }
    /// <summary>The SafeHandle is invalid.</summary>
    public IMessageDescription InvalidSafeHandle { get => _invalidsafehandle!; set => this.AssertWritable()._invalidsafehandle = value; }
    /// <summary>Invalid seek origin.</summary>
    public IMessageDescription InvalidSeekOrigin { get => _invalidseekorigin!; set => this.AssertWritable()._invalidseekorigin = value; }
    /// <summary>Invalid site.</summary>
    public IMessageDescription InvalidSite { get => _invalidsite!; set => this.AssertWritable()._invalidsite = value; }
    /// <summary>The directory specified, &#39;{0}&#39;, is not a subdirectory of &#39;{1}&#39;.</summary>
    public IMessageDescription InvalidSubPath { get => _invalidsubpath!; set => this.AssertWritable()._invalidsubpath = value; }
    /// <summary>An undefined TimeSpanStyles value is being used.</summary>
    public IMessageDescription InvalidTimeSpanStyles { get => _invalidtimespanstyles!; set => this.AssertWritable()._invalidtimespanstyles = value; }
    /// <summary>Token {0:x} is not valid in the scope of module {1}.</summary>
    public IMessageDescription InvalidToken { get => _invalidtoken!; set => this.AssertWritable()._invalidtoken = value; }
    /// <summary>The type of arguments passed into generic comparer methods is invalid.</summary>
    public IMessageDescription InvalidType { get => _invalidtype!; set => this.AssertWritable()._invalidtype = value; }
    /// <summary>Cannot build type parameter for custom attribute with a type that does not support the AssemblyQualifiedName property. The type instance supplied was of type &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidTypeForCA { get => _invalidtypeforca!; set => this.AssertWritable()._invalidtypeforca = value; }
    /// <summary>Invalid type owner for DynamicMethod.</summary>
    public IMessageDescription InvalidTypeForDynamicMethod { get => _invalidtypefordynamicmethod!; set => this.AssertWritable()._invalidtypefordynamicmethod = value; }
    /// <summary>The name of the type is invalid.</summary>
    public IMessageDescription InvalidTypeName { get => _invalidtypename!; set => this.AssertWritable()._invalidtypename = value; }
    /// <summary>Token {0:x} is not a valid Type token.</summary>
    public IMessageDescription InvalidTypeToken { get => _invalidtypetoken!; set => this.AssertWritable()._invalidtypetoken = value; }
    /// <summary>Invalid Unity type.</summary>
    public IMessageDescription InvalidUnity { get => _invalidunity!; set => this.AssertWritable()._invalidunity = value; }
    /// <summary>Invalid URL.</summary>
    public IMessageDescription InvalidUrl { get => _invalidurl!; set => this.AssertWritable()._invalidurl = value; }
    /// <summary>Value was invalid.</summary>
    public IMessageDescription InvalidValue { get => _invalidvalue!; set => this.AssertWritable()._invalidvalue = value; }
    /// <summary>Invalid Xml.</summary>
    public IMessageDescription InvalidXML { get => _invalidxml!; set => this.AssertWritable()._invalidxml = value; }
    /// <summary>Invalid Xml - can only parse elements of version one.</summary>
    public IMessageDescription InvalidXMLBadVersion { get => _invalidxmlbadversion!; set => this.AssertWritable()._invalidxmlbadversion = value; }
    /// <summary>Invalid XML. Missing required tag &lt;{0}&gt; for type &#39;{1}&#39;.</summary>
    public IMessageDescription InvalidXMLElement { get => _invalidxmlelement!; set => this.AssertWritable()._invalidxmlelement = value; }
    /// <summary>Invalid XML. Missing required attribute &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidXMLMissingAttr { get => _invalidxmlmissingattr!; set => this.AssertWritable()._invalidxmlmissingattr = value; }
    /// <summary>The specified item does not exist in this KeyedCollection.</summary>
    public IMessageDescription ItemNotExist { get => _itemnotexist!; set => this.AssertWritable()._itemnotexist = value; }
    /// <summary>Integer or token was too large to be encoded.</summary>
    public IMessageDescription LargeInteger { get => _largeinteger!; set => this.AssertWritable()._largeinteger = value; }
    /// <summary>Environment variable name cannot contain 1024 or more characters.</summary>
    public IMessageDescription LongEnvVarName { get => _longenvvarname!; set => this.AssertWritable()._longenvvarname = value; }
    /// <summary>Environment variable name or value is too long.</summary>
    public IMessageDescription LongEnvVarValue { get => _longenvvarvalue!; set => this.AssertWritable()._longenvvarvalue = value; }
    /// <summary>&#39;{0}&#39; cannot be greater than {1}.</summary>
    public IMessageDescription MinMaxValue { get => _minmaxvalue!; set => this.AssertWritable()._minmaxvalue = value; }
    /// <summary>Argument must be initialized to false</summary>
    public IMessageDescription MustBeFalse { get => _mustbefalse!; set => this.AssertWritable()._mustbefalse = value; }
    /// <summary>The MemberInfo must be an interface method.</summary>
    public IMessageDescription MustBeInterfaceMethod { get => _mustbeinterfacemethod!; set => this.AssertWritable()._mustbeinterfacemethod = value; }
    /// <summary>FieldInfo must be a runtime FieldInfo object.</summary>
    public IMessageDescription MustBeRuntimeFieldInfo { get => _mustberuntimefieldinfo!; set => this.AssertWritable()._mustberuntimefieldinfo = value; }
    /// <summary>MethodInfo must be a runtime MethodInfo object.</summary>
    public IMessageDescription MustBeRuntimeMethodInfo { get => _mustberuntimemethodinfo!; set => this.AssertWritable()._mustberuntimemethodinfo = value; }
    /// <summary>System</summary>
    public IMessageDescription MustBeRuntimeReflectionObject { get => _mustberuntimereflectionobject!; set => this.AssertWritable()._mustberuntimereflectionobject = value; }
    /// <summary>&#39;type&#39; must contain a TypeBuilder as a generic argument.</summary>
    public IMessageDescription MustBeTypeBuilder { get => _mustbetypebuilder!; set => this.AssertWritable()._mustbetypebuilder = value; }
    /// <summary>Type passed in must be derived from System.Attribute or System.Attribute itself.</summary>
    public IMessageDescription MustHaveAttributeBaseClass { get => _musthaveattributebaseclass!; set => this.AssertWritable()._musthaveattributebaseclass = value; }
    /// <summary>When supplying a FieldInfo for fixing up a nested type, a valid ID for that containing object must also be supplied.</summary>
    public IMessageDescription MustSupplyContainer { get => _mustsupplycontainer!; set => this.AssertWritable()._mustsupplycontainer = value; }
    /// <summary>When supplying the ID of a containing object, the FieldInfo that identifies the current field within that object must also be supplied.</summary>
    public IMessageDescription MustSupplyParent { get => _mustsupplyparent!; set => this.AssertWritable()._mustsupplyparent = value; }
    /// <summary>Native resource has already been defined.</summary>
    public IMessageDescription NativeResourceAlreadyDefined { get => _nativeresourcealreadydefined!; set => this.AssertWritable()._nativeresourcealreadydefined = value; }
    /// <summary>Method must represent a generic method definition on a generic type definition.</summary>
    public IMessageDescription NeedGenericMethodDefinition { get => _needgenericmethoddefinition!; set => this.AssertWritable()._needgenericmethoddefinition = value; }
    /// <summary>The specified Type must not be a generic type definition.</summary>
    public IMessageDescription NeedNonGenericType { get => _neednongenerictype!; set => this.AssertWritable()._neednongenerictype = value; }
    /// <summary>The type &#39;{0}&#39; may not be used as a type argument.</summary>
    public IMessageDescription NeverValidGenericArgument { get => _nevervalidgenericargument!; set => this.AssertWritable()._nevervalidgenericargument = value; }
    /// <summary>Element does not specify a class.</summary>
    public IMessageDescription NoClass { get => _noclass!; set => this.AssertWritable()._noclass = value; }
    /// <summary>The domain manager specified by the host could not be instantiated.</summary>
    public IMessageDescription NoDomainManager { get => _nodomainmanager!; set => this.AssertWritable()._nodomainmanager = value; }
    /// <summary>No Era was supplied.</summary>
    public IMessageDescription NoEra { get => _noera!; set => this.AssertWritable()._noera = value; }
    /// <summary>Main entry point not defined.</summary>
    public IMessageDescription NoMain { get => _nomain!; set => this.AssertWritable()._nomain = value; }
    /// <summary>Only LPArray or SafeArray has nested unmanaged marshal.</summary>
    public IMessageDescription NoNestedMarshal { get => _nonestedmarshal!; set => this.AssertWritable()._nonestedmarshal = value; }
    /// <summary>Either obj or ctx must be null.</summary>
    public IMessageDescription NonNullObjAndCtx { get => _nonnullobjandctx!; set => this.AssertWritable()._nonnullobjandctx = value; }
    /// <summary>Unable to find a permission set with the provided name.</summary>
    public IMessageDescription NoNPMS { get => _nonpms!; set => this.AssertWritable()._nonpms = value; }
    /// <summary>There is no region associated with the Invariant Culture (Culture ID: 0x7F).</summary>
    public IMessageDescription NoRegionInvariantCulture { get => _noregioninvariantculture!; set => this.AssertWritable()._noregioninvariantculture = value; }
    /// <summary>The type does not inherit from CodeGroup</summary>
    public IMessageDescription NotACodeGroupType { get => _notacodegrouptype!; set => this.AssertWritable()._notacodegrouptype = value; }
    /// <summary>Not a custom marshal.</summary>
    public IMessageDescription NotACustomMarshaler { get => _notacustommarshaler!; set => this.AssertWritable()._notacustommarshaler = value; }
    /// <summary>The type does not implement IMembershipCondition</summary>
    public IMessageDescription NotAMembershipCondition { get => _notamembershipcondition!; set => this.AssertWritable()._notamembershipcondition = value; }
    /// <summary>&#39;elem&#39; was not a permission element.</summary>
    public IMessageDescription NotAPermissionElement { get => _notapermissionelement!; set => this.AssertWritable()._notapermissionelement = value; }
    /// <summary>The type does not implement IPermission</summary>
    public IMessageDescription NotAPermissionType { get => _notapermissiontype!; set => this.AssertWritable()._notapermissiontype = value; }
    /// <summary>The UnmanagedType passed to DefineUnmanagedMarshal is not a simple type. None of the following values may be used: UnmanagedType.ByValTStr, UnmanagedType.SafeArray, UnmanagedType.ByValArray, UnmanagedType.LPArray, UnmanagedType.CustomMarshaler.</summary>
    public IMessageDescription NotASimpleNativeType { get => _notasimplenativetype!; set => this.AssertWritable()._notasimplenativetype = value; }
    /// <summary>Not a writable property.</summary>
    public IMessageDescription NotAWritableProperty { get => _notawritableproperty!; set => this.AssertWritable()._notawritableproperty = value; }
    /// <summary>There are not enough bytes remaining in the accessor to read at this position.</summary>
    public IMessageDescription NotEnoughBytesToRead { get => _notenoughbytestoread!; set => this.AssertWritable()._notenoughbytestoread = value; }
    /// <summary>There are not enough bytes remaining in the accessor to write at this position.</summary>
    public IMessageDescription NotEnoughBytesToWrite { get => _notenoughbytestowrite!; set => this.AssertWritable()._notenoughbytestowrite = value; }
    /// <summary>The type or method has {1} generic parameter(s), but {0} generic argument(s) were provided. A generic argument must be provided for each generic parameter.</summary>
    public IMessageDescription NotEnoughGenArguments { get => _notenoughgenarguments!; set => this.AssertWritable()._notenoughgenarguments = value; }
    /// <summary>The filename must not include a path specification.</summary>
    public IMessageDescription NotSimpleFileName { get => _notsimplefilename!; set => this.AssertWritable()._notsimplefilename = value; }
    /// <summary>Unmanaged marshal does not have ElementCount.</summary>
    public IMessageDescription NoUnmanagedElementCount { get => _nounmanagedelementcount!; set => this.AssertWritable()._nounmanagedelementcount = value; }
    /// <summary>Permission set &#39;{0}&#39; was in use and could not be deleted.</summary>
    public IMessageDescription NPMSInUse { get => _npmsinuse!; set => this.AssertWritable()._npmsinuse = value; }
    /// <summary>Name can be neither null nor empty.</summary>
    public IMessageDescription NPMSInvalidName { get => _npmsinvalidname!; set => this.AssertWritable()._npmsinvalidname = value; }
    /// <summary>A null StrongName was found in the full trust assembly list.</summary>
    public IMessageDescription NullFullTrustAssembly { get => _nullfulltrustassembly!; set => this.AssertWritable()._nullfulltrustassembly = value; }
    /// <summary>The object&#39;s type must not be a Windows Runtime type.</summary>
    public IMessageDescription ObjIsWinRTObject { get => _objiswinrtobject!; set => this.AssertWritable()._objiswinrtobject = value; }
    /// <summary>The object&#39;s type must be __ComObject or derived from __ComObject.</summary>
    public IMessageDescription ObjNotComObject { get => _objnotcomobject!; set => this.AssertWritable()._objnotcomobject = value; }
    /// <summary>Offset and capacity were greater than the size of the view.</summary>
    public IMessageDescription OffsetAndCapacityOutOfBounds { get => _offsetandcapacityoutofbounds!; set => this.AssertWritable()._offsetandcapacityoutofbounds = value; }
    /// <summary>Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.</summary>
    public IMessageDescription OffsetAndLengthOutOfBounds { get => _offsetandlengthoutofbounds!; set => this.AssertWritable()._offsetandlengthoutofbounds = value; }
    /// <summary>The UTC Offset of the local dateTime parameter does not match the offset argument.</summary>
    public IMessageDescription OffsetLocalMismatch { get => _offsetlocalmismatch!; set => this.AssertWritable()._offsetlocalmismatch = value; }
    /// <summary>Field passed in is not a marshaled member of the type &#39;{0}&#39;.</summary>
    public IMessageDescription OffsetOfFieldNotFound { get => _offsetoffieldnotfound!; set => this.AssertWritable()._offsetoffieldnotfound = value; }
    /// <summary>Offset must be within plus or minus 14 hours.</summary>
    public IMessageDescription OffsetOutOfRange { get => _offsetoutofrange!; set => this.AssertWritable()._offsetoutofrange = value; }
    /// <summary>Offset must be specified in whole minutes.</summary>
    public IMessageDescription OffsetPrecision { get => _offsetprecision!; set => this.AssertWritable()._offsetprecision = value; }
    /// <summary>The UTC Offset for Utc DateTime instances must be 0.</summary>
    public IMessageDescription OffsetUtcMismatch { get => _offsetutcmismatch!; set => this.AssertWritable()._offsetutcmismatch = value; }
    /// <summary>Only mscorlib&#39;s assembly is valid.</summary>
    public IMessageDescription OnlyMscorlib { get => _onlymscorlib!; set => this.AssertWritable()._onlymscorlib = value; }
    /// <summary>The DateStart property must come before the DateEnd property.</summary>
    public IMessageDescription OutOfOrderDateTimes { get => _outoforderdatetimes!; set => this.AssertWritable()._outoforderdatetimes = value; }
    /// <summary>Path cannot be the empty string or all whitespace.</summary>
    public IMessageDescription PathEmpty { get => _pathempty!; set => this.AssertWritable()._pathempty = value; }
    /// <summary>The requested policy file does not exist.</summary>
    public IMessageDescription PolicyFileDoesNotExist { get => _policyfiledoesnotexist!; set => this.AssertWritable()._policyfiledoesnotexist = value; }
    /// <summary>Recursive fallback not allowed for character \u{0:X4}.</summary>
    public IMessageDescription RecursiveFallback { get => _recursivefallback!; set => this.AssertWritable()._recursivefallback = value; }
    /// <summary>Recursive fallback not allowed for bytes {0}.</summary>
    public IMessageDescription RecursiveFallbackBytes { get => _recursivefallbackbytes!; set => this.AssertWritable()._recursivefallbackbytes = value; }
    /// <summary>UrlMembershipCondition requires an absolute URL.</summary>
    public IMessageDescription RelativeUrlMembershipCondition { get => _relativeurlmembershipcondition!; set => this.AssertWritable()._relativeurlmembershipcondition = value; }
    /// <summary>Cannot remove or modify reserved permissions set &#39;{0}&#39;.</summary>
    public IMessageDescription ReservedNPMS { get => _reservednpms!; set => this.AssertWritable()._reservednpms = value; }
    /// <summary>Token {0:x} is not a valid FieldInfo token in the scope of module {1}.</summary>
    public IMessageDescription ResolveField { get => _resolvefield!; set => this.AssertWritable()._resolvefield = value; }
    /// <summary>Type handle &#39;{0}&#39; and field handle with declaring type &#39;{1}&#39; are incompatible. Get RuntimeFieldHandle and declaring RuntimeTypeHandle off the same FieldInfo.</summary>
    public IMessageDescription ResolveFieldHandle { get => _resolvefieldhandle!; set => this.AssertWritable()._resolvefieldhandle = value; }
    /// <summary>Token {0:x} is not a valid MemberInfo token in the scope of module {1}.</summary>
    public IMessageDescription ResolveMember { get => _resolvemember!; set => this.AssertWritable()._resolvemember = value; }
    /// <summary>Token {0:x} is not a valid MethodBase token in the scope of module {1}.</summary>
    public IMessageDescription ResolveMethod { get => _resolvemethod!; set => this.AssertWritable()._resolvemethod = value; }
    /// <summary>Type handle &#39;{0}&#39; and method handle with declaring type &#39;{1}&#39; are incompatible. Get RuntimeMethodHandle and declaring RuntimeTypeHandle off the same MethodBase.</summary>
    public IMessageDescription ResolveMethodHandle { get => _resolvemethodhandle!; set => this.AssertWritable()._resolvemethodhandle = value; }
    /// <summary>Token {0:x} is not a valid string token in the scope of module {1}.</summary>
    public IMessageDescription ResolveString { get => _resolvestring!; set => this.AssertWritable()._resolvestring = value; }
    /// <summary>Token {0:x} is not a valid Type token in the scope of module {1}.</summary>
    public IMessageDescription ResolveType { get => _resolvetype!; set => this.AssertWritable()._resolvetype = value; }
    /// <summary>Resource type in the ResourceScope enum is going from a more restrictive resource type to a more general one. From: &quot;{0}&quot; To: &quot;{1}&quot;</summary>
    public IMessageDescription ResourceScopeWrongDirection { get => _resourcescopewrongdirection!; set => this.AssertWritable()._resourcescopewrongdirection = value; }
    /// <summary>The result is out of the supported range for this calendar. The result should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive.</summary>
    public IMessageDescription ResultCalendarRange { get => _resultcalendarrange!; set => this.AssertWritable()._resultcalendarrange = value; }
    /// <summary>Should only set visibility flags when creating EnumBuilder.</summary>
    public IMessageDescription ShouldOnlySetVisibilityFlags { get => _shouldonlysetvisibilityflags!; set => this.AssertWritable()._shouldonlysetvisibilityflags = value; }
    /// <summary>Completed signature cannot be modified.</summary>
    public IMessageDescription SigIsFinalized { get => _sigisfinalized!; set => this.AssertWritable()._sigisfinalized = value; }
    /// <summary>Site name must be specified.</summary>
    public IMessageDescription SiteCannotBeNull { get => _sitecannotbenull!; set => this.AssertWritable()._sitecannotbenull = value; }
    /// <summary>Stream was not readable.</summary>
    public IMessageDescription StreamNotReadable { get => _streamnotreadable!; set => this.AssertWritable()._streamnotreadable = value; }
    /// <summary>Stream was not writable.</summary>
    public IMessageDescription StreamNotWritable { get => _streamnotwritable!; set => this.AssertWritable()._streamnotwritable = value; }
    /// <summary>The first char in the string is the null character.</summary>
    public IMessageDescription StringFirstCharIsZero { get => _stringfirstchariszero!; set => this.AssertWritable()._stringfirstchariszero = value; }
    /// <summary>String cannot be of zero length.</summary>
    public IMessageDescription StringZeroLength { get => _stringzerolength!; set => this.AssertWritable()._stringzerolength = value; }
    /// <summary>Unable to obtain public key for StrongNameKeyPair.</summary>
    public IMessageDescription StrongNameGetPublicKey { get => _strongnamegetpublickey!; set => this.AssertWritable()._strongnamegetpublickey = value; }
    /// <summary>The TimeSpan parameter cannot be specified more precisely than whole minutes.</summary>
    public IMessageDescription TimeSpanHasSeconds { get => _timespanhasseconds!; set => this.AssertWritable()._timespanhasseconds = value; }
    /// <summary>fromInclusive must be less than or equal to toExclusive.</summary>
    public IMessageDescription ToExclusiveLessThanFromExclusive { get => _toexclusivelessthanfromexclusive!; set => this.AssertWritable()._toexclusivelessthanfromexclusive = value; }
    /// <summary>Token cannot be zero.</summary>
    public IMessageDescription TokenZero { get => _tokenzero!; set => this.AssertWritable()._tokenzero = value; }
    /// <summary>The DaylightTransitionStart property must not equal the DaylightTransitionEnd property.</summary>
    public IMessageDescription TransitionTimesAreIdentical { get => _transitiontimesareidentical!; set => this.AssertWritable()._transitiontimesareidentical = value; }
    /// <summary>Unable to generate permission set; input XML may be malformed.</summary>
    public IMessageDescription UnableToGeneratePermissionSet { get => _unabletogeneratepermissionset!; set => this.AssertWritable()._unabletogeneratepermissionset = value; }
    /// <summary>System.StubHelpers</summary>
    public IMessageDescription UnexpectedTypeSource { get => _unexpectedtypesource!; set => this.AssertWritable()._unexpectedtypesource = value; }
    /// <summary>Uninitialized certificate object.</summary>
    public IMessageDescription UninitializedCertificate { get => _uninitializedcertificate!; set => this.AssertWritable()._uninitializedcertificate = value; }
    /// <summary>Unknown unmanaged calling convention for function signature.</summary>
    public IMessageDescription UnknownUnmanagedCallConv { get => _unknownunmanagedcallconv!; set => this.AssertWritable()._unknownunmanagedcallconv = value; }
    /// <summary>The UnmanagedMemoryAccessor capacity and offset would wrap around the high end of the address space.</summary>
    public IMessageDescription UnmanagedMemAccessorWrapAround { get => _unmanagedmemaccessorwraparound!; set => this.AssertWritable()._unmanagedmemaccessorwraparound = value; }
    /// <summary>Unrecognized LOADER_OPTIMIZATION property value. Supported values may include &quot;SingleDomain&quot;, &quot;MultiDomain&quot;, &quot;MultiDomainHost&quot;, and &quot;NotSpecified&quot;.</summary>
    public IMessageDescription UnrecognizedLoaderOptimization { get => _unrecognizedloaderoptimization!; set => this.AssertWritable()._unrecognizedloaderoptimization = value; }
    /// <summary>URL must be specified.</summary>
    public IMessageDescription UrlCannotBeNull { get => _urlcannotbenull!; set => this.AssertWritable()._urlcannotbenull = value; }
    /// <summary>The UTC time represented when the offset is applied must be between year 0 and 10,000.</summary>
    public IMessageDescription UTCOutOfRange { get => _utcoutofrange!; set => this.AssertWritable()._utcoutofrange = value; }
    /// <summary>The name can be no more than 260 characters in length.</summary>
    public IMessageDescription WaitHandleNameTooLong { get => _waithandlenametoolong!; set => this.AssertWritable()._waithandlenametoolong = value; }
    /// <summary>System.StubHelpers</summary>
    public IMessageDescription WinRTSystemRuntimeType { get => _winrtsystemruntimetype!; set => this.AssertWritable()._winrtsystemruntimetype = value; }
    /// <summary>&#39;{0}&#39; element required.</summary>
    public IMessageDescription WrongElementType { get => _wrongelementtype!; set => this.AssertWritable()._wrongelementtype = value; }
    /// <summary>Operation on type &#39;{0}&#39; attempted with target of incorrect type.</summary>
    public IMessageDescription WrongType2 { get => _wrongtype2!; set => this.AssertWritable()._wrongtype2 = value; }
    /// <summary>Zone must be specified.</summary>
    public IMessageDescription ZoneCannotBeNull { get => _zonecannotbenull!; set => this.AssertWritable()._zonecannotbenull = value; }
    /// <summary>MethodOverride&#39;s body must be from this type.</summary>
    public IMessageDescription ExceptionBadMethodImplBody { get => _exceptionbadmethodimplbody!; set => this.AssertWritable()._exceptionbadmethodimplbody = value; }
    /// <summary>The binary form of an ACE object is invalid.</summary>
    public IMessageDescription ExceptionInvalidAceBinaryForm { get => _exceptioninvalidacebinaryform!; set => this.AssertWritable()._exceptioninvalidacebinaryform = value; }
    /// <summary>The binary form of an ACL object is invalid.</summary>
    public IMessageDescription ExceptionInvalidAclBinaryForm { get => _exceptioninvalidaclbinaryform!; set => this.AssertWritable()._exceptioninvalidaclbinaryform = value; }
    /// <summary>The SDDL form of a security descriptor object is invalid.</summary>
    public IMessageDescription ExceptionInvalidSDSddlForm { get => _exceptioninvalidsdsddlform!; set => this.AssertWritable()._exceptioninvalidsdsddlform = value; }
    /// <summary>The runtime does not support a version of &quot;{0}&quot; less than {1}.</summary>
    public IMessageDescription ExceptionMinSortingVersion { get => _exceptionminsortingversion!; set => this.AssertWritable()._exceptionminsortingversion = value; }
    /// <summary>Implementations of all the NLS functions must be provided.</summary>
    public IMessageDescription ExceptionNotAllCustomSortingFuncsDefined { get => _exceptionnotallcustomsortingfuncsdefined!; set => this.AssertWritable()._exceptionnotallcustomsortingfuncsdefined = value; }
    /// <summary>Argument must be of type {0}.</summary>
    public IMessageDescription ExceptionTupleIncorrectType { get => _exceptiontupleincorrecttype!; set => this.AssertWritable()._exceptiontupleincorrecttype = value; }
    /// <summary>The last element of an eight element Tuple must be a Tuple.</summary>
    public IMessageDescription ExceptionTupleLastArgumentNotATuple { get => _exceptiontuplelastargumentnotatuple!; set => this.AssertWritable()._exceptiontuplelastargumentnotatuple = value; }
    /// <summary>GAC</summary>
    public IMessageDescription GACToString { get => _gactostring!; set => this.AssertWritable()._gactostring = value; }
    /// <summary>Stream is not a valid resource file.</summary>
    public IMessageDescription ResourcesStreamNotValid { get => _resourcesstreamnotvalid!; set => this.AssertWritable()._resourcesstreamnotvalid = value; }
    /// <summary>name = {0}</summary>
    public IMessageDescription StrongNameName { get => _strongnamename!; set => this.AssertWritable()._strongnamename = value; }
    /// <summary>StrongName - {0}{1}{2}</summary>
    public IMessageDescription StrongNameToString { get => _strongnametostring!; set => this.AssertWritable()._strongnametostring = value; }
    /// <summary>version = {0}</summary>
    public IMessageDescription StrongNameVersion { get => _strongnameversion!; set => this.AssertWritable()._strongnameversion = value; }
    /// <summary>Url</summary>
    public IMessageDescription UrlToString { get => _urltostring!; set => this.AssertWritable()._urltostring = value; }
    /// <summary>Url - {0}</summary>
    public IMessageDescription UrlToStringArg { get => _urltostringarg!; set => this.AssertWritable()._urltostringarg = value; }
    /// <summary>String cannot contain a minus sign if the base is not 10.</summary>
    public IMessageDescription CannotHaveNegativeValue { get => _cannothavenegativevalue!; set => this.AssertWritable()._cannothavenegativevalue = value; }
    /// <summary>The file of the custom culture {0} is corrupt. Try to unregister this culture.</summary>
    public IMessageDescription CorruptedCustomCultureFile { get => _corruptedcustomculturefile!; set => this.AssertWritable()._corruptedcustomculturefile = value; }
    /// <summary>All enums must have an underlying value__ field.</summary>
    public IMessageDescription EnumMustHaveUnderlyingValueField { get => _enummusthaveunderlyingvaluefield!; set => this.AssertWritable()._enummusthaveunderlyingvaluefield = value; }
    /// <summary>The type library importer encountered an error during type verification. Try importing without class members.</summary>
    public IMessageDescription ImporterLoadFailure { get => _importerloadfailure!; set => this.AssertWritable()._importerloadfailure = value; }
    /// <summary>The ANSI string passed in could not be converted from the default ANSI code page to Unicode.</summary>
    public IMessageDescription InvalidANSIString { get => _invalidansistring!; set => this.AssertWritable()._invalidansistring = value; }
    /// <summary>The UTF8 string passed in could not be converted to Unicode.</summary>
    public IMessageDescription InvalidUTF8String { get => _invalidutf8string!; set => this.AssertWritable()._invalidutf8string = value; }
    /// <summary>At least one type argument is not a runtime type.</summary>
    public IMessageDescription MustAllBeRuntimeType { get => _mustallberuntimetype!; set => this.AssertWritable()._mustallberuntimetype = value; }
    /// <summary>Type passed must be an interface.</summary>
    public IMessageDescription MustBeInterface { get => _mustbeinterface!; set => this.AssertWritable()._mustbeinterface = value; }
    /// <summary>Specified TypeInfo was invalid because it did not support the ITypeInfo interface.</summary>
    public IMessageDescription NoITypeInfo { get => _noitypeinfo!; set => this.AssertWritable()._noitypeinfo = value; }
    /// <summary>Specified type library importer callback was invalid because it did not support the ITypeLibImporterNotifySink interface.</summary>
    public IMessageDescription NoImporterCallback { get => _noimportercallback!; set => this.AssertWritable()._noimportercallback = value; }
    /// <summary>Interface not found.</summary>
    public IMessageDescription NotFoundIFace { get => _notfoundiface!; set => this.AssertWritable()._notfoundiface = value; }
    /// <summary>Arrays indexes must be set to an object instance.</summary>
    public IMessageDescription NullIndex { get => _nullindex!; set => this.AssertWritable()._nullindex = value; }
    /// <summary>The MemberInfo object defining the parameter cannot be null.</summary>
    public IMessageDescription ParameterInfoNullMember { get => _parameterinfonullmember!; set => this.AssertWritable()._parameterinfonullmember = value; }
    /// <summary>Cannot widen from source type to target type either because the source type is a not a primitive type or the conversion cannot be accomplished.</summary>
    public IMessageDescription PrimWiden { get => _primwiden!; set => this.AssertWritable()._primwiden = value; }
    /// <summary>ReaderWriterLock.RestoreLock was called without releasing all locks acquired since the call to ReleaseLock.</summary>
    public IMessageDescription RWLockRestoreException { get => _rwlockrestoreexception!; set => this.AssertWritable()._rwlockrestoreexception = value; }
    /// <summary>The tuple contains an element of type {0} which does not implement the IComparable interface.</summary>
    public IMessageDescription ExceptionTupleNonIComparableElement { get => _exceptiontuplenonicomparableelement!; set => this.AssertWritable()._exceptiontuplenonicomparableelement = value; }
    /// <summary>Argument must be of type {0}.</summary>
    public IMessageDescription ExceptionValueTupleIncorrectType { get => _exceptionvaluetupleincorrecttype!; set => this.AssertWritable()._exceptionvaluetupleincorrecttype = value; }
    /// <summary>The last element of an eight element ValueTuple must be a ValueTuple.</summary>
    public IMessageDescription ExceptionValueTupleLastArgumentNotAValueTuple { get => _exceptionvaluetuplelastargumentnotavaluetuple!; set => this.AssertWritable()._exceptionvaluetuplelastargumentnotavaluetuple = value; }
    /// <summary>Specified capacity must not be less than the current capacity.</summary>
    public IMessageDescription ALSInvalidCapacity { get => _alsinvalidcapacity!; set => this.AssertWritable()._alsinvalidcapacity = value; }
    /// <summary>The elements of the AdjustmentRule array must not contain ambiguous time periods that extend beyond the DateStart or DateEnd properties of the element.</summary>
    public IMessageDescription AdjustmentRulesAmbiguousOverlap { get => _adjustmentrulesambiguousoverlap!; set => this.AssertWritable()._adjustmentrulesambiguousoverlap = value; }
    /// <summary>The elements of the AdjustmentRule array must not contain invalid time periods that extend beyond the DateStart or DateEnd properties of the element.</summary>
    public IMessageDescription AdjustmentRulesInvalidOverlap { get => _adjustmentrulesinvalidoverlap!; set => this.AssertWritable()._adjustmentrulesinvalidoverlap = value; }
    /// <summary>The elements of the AdjustmentRule array must not contain Daylight Saving Time periods that overlap adjacent elements in such a way as to cause invalid or ambiguous time periods.</summary>
    public IMessageDescription AdjustmentRulesrDaylightSavingTimeOverlap { get => _adjustmentrulesrdaylightsavingtimeoverlap!; set => this.AssertWritable()._adjustmentrulesrdaylightsavingtimeoverlap = value; }
    /// <summary>The elements of the AdjustmentRule array must not contain Daylight Saving Time periods that overlap the DateStart or DateEnd properties in such a way as to cause invalid or ambiguous time periods.</summary>
    public IMessageDescription AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange { get => _adjustmentrulesrdaylightsavingtimeoverlapnonrulerange!; set => this.AssertWritable()._adjustmentrulesrdaylightsavingtimeoverlapnonrulerange = value; }
    /// <summary>The object already has a CCW associated with it.</summary>
    public IMessageDescription AlreadyACCW { get => _alreadyaccw!; set => this.AssertWritable()._alreadyaccw = value; }
    /// <summary>&#39;handle&#39; has already been bound to the thread pool, or was not opened for asynchronous I/O.</summary>
    public IMessageDescription AlreadyBoundOrSyncHandle { get => _alreadyboundorsynchandle!; set => this.AssertWritable()._alreadyboundorsynchandle = value; }
    /// <summary>Assembly must not be a Windows Runtime assembly.</summary>
    public IMessageDescription AssemblyWinMD { get => _assemblywinmd!; set => this.AssertWritable()._assemblywinmd = value; }
    /// <summary>Bad default value.</summary>
    public IMessageDescription BadConstantValue { get => _badconstantvalue!; set => this.AssertWritable()._badconstantvalue = value; }
    /// <summary>Bad current local variable for setting symbol information.</summary>
    public IMessageDescription BadCurrentLocalVariable { get => _badcurrentlocalvariable!; set => this.AssertWritable()._badcurrentlocalvariable = value; }
    /// <summary>Format specifier was invalid.</summary>
    public IMessageDescription BadFormatSpecifier { get => _badformatspecifier!; set => this.AssertWritable()._badformatspecifier = value; }
    /// <summary>Bad type attributes. A type cannot be both abstract and final.</summary>
    public IMessageDescription BadTypeAttrAbstractNFinal { get => _badtypeattrabstractnfinal!; set => this.AssertWritable()._badtypeattrabstractnfinal = value; }
    /// <summary>Cannot find the method on the object instance.</summary>
    public IMessageDescription CORDBBadMethod { get => _cordbbadmethod!; set => this.AssertWritable()._cordbbadmethod = value; }
    /// <summary>Cannot evaluate a VarArgs function.</summary>
    public IMessageDescription CORDBBadVarArgCallConv { get => _cordbbadvarargcallconv!; set => this.AssertWritable()._cordbbadvarargcallconv = value; }
    /// <summary>Abstract methods cannot be prepared.</summary>
    public IMessageDescription CannotPrepareAbstract { get => _cannotprepareabstract!; set => this.AssertWritable()._cannotprepareabstract = value; }
    /// <summary>Cannot evaluate a security function.</summary>
    public IMessageDescription CantCallSecObjFunc { get => _cantcallsecobjfunc!; set => this.AssertWritable()._cantcallsecobjfunc = value; }
    /// <summary>Culture &#39;{0}&#39; is a neutral culture. It cannot be used in formatting and parsing and therefore cannot be set as the thread&#39;s current culture.</summary>
    public IMessageDescription CultureInvalidFormat { get => _cultureinvalidformat!; set => this.AssertWritable()._cultureinvalidformat = value; }
    /// <summary>{0} is an invalid culture identifier.</summary>
    public IMessageDescription CultureInvalidIdentifier { get => _cultureinvalididentifier!; set => this.AssertWritable()._cultureinvalididentifier = value; }
    /// <summary>Resolved assembly&#39;s simple name should be the same as of the requested assembly.</summary>
    public IMessageDescription CustomAssemblyLoadContextRequestedNameMismatch { get => _customassemblyloadcontextrequestednamemismatch!; set => this.AssertWritable()._customassemblyloadcontextrequestednamemismatch = value; }
    /// <summary>Value cannot be empty.</summary>
    public IMessageDescription EmptyValue { get => _emptyvalue!; set => this.AssertWritable()._emptyvalue = value; }
    /// <summary>The underlying type of enum argument must be Int32 or Int16.</summary>
    public IMessageDescription EnumIsNotIntOrShort { get => _enumisnotintorshort!; set => this.AssertWritable()._enumisnotintorshort = value; }
    /// <summary>Cannot pass a GCHandle across AppDomains.</summary>
    public IMessageDescription HandleLeak { get => _handleleak!; set => this.AssertWritable()._handleleak = value; }
    /// <summary>The application base specified is not valid.</summary>
    public IMessageDescription IllegalAppBase { get => _illegalappbase!; set => this.AssertWritable()._illegalappbase = value; }
    /// <summary>&#39;this&#39; type cannot be an interface itself.</summary>
    public IMessageDescription InterfaceMap { get => _interfacemap!; set => this.AssertWritable()._interfacemap = value; }
    /// <summary>Assembly names may not begin with whitespace or contain the characters &#39;/&#39;, or &#39;\&#39; or &#39;:&#39;.</summary>
    public IMessageDescription InvalidAssemblyName { get => _invalidassemblyname!; set => this.AssertWritable()._invalidassemblyname = value; }
    /// <summary>The generic type parameter was not valid</summary>
    public IMessageDescription InvalidGenericArg { get => _invalidgenericarg!; set => this.AssertWritable()._invalidgenericarg = value; }
    /// <summary>The given generic instantiation was invalid.</summary>
    public IMessageDescription InvalidGenericInstantiation { get => _invalidgenericinstantiation!; set => this.AssertWritable()._invalidgenericinstantiation = value; }
    /// <summary>MemberData contains an invalid number of members.</summary>
    public IMessageDescription InvalidNumberOfMembers { get => _invalidnumberofmembers!; set => this.AssertWritable()._invalidnumberofmembers = value; }
    /// <summary>Region name &#39;{0}&#39; is not supported.</summary>
    public IMessageDescription InvalidRegionName { get => _invalidregionname!; set => this.AssertWritable()._invalidregionname = value; }
    /// <summary>ParameterInfo must be a runtime ParameterInfo object.</summary>
    public IMessageDescription MustBeRuntimeParameterInfo { get => _mustberuntimeparameterinfo!; set => this.AssertWritable()._mustberuntimeparameterinfo = value; }
    /// <summary>String is too long or has invalid contents.</summary>
    public IMessageDescription MustBeString2 { get => _mustbestring2!; set => this.AssertWritable()._mustbestring2 = value; }
    /// <summary>The specified structure must be blittable or have layout information.</summary>
    public IMessageDescription MustHaveLayoutOrBeBlittable { get => _musthavelayoutorbeblittable!; set => this.AssertWritable()._musthavelayoutorbeblittable = value; }
    /// <summary>The name &#39;{0}&#39; contains characters that are not valid for a Culture or Region.</summary>
    public IMessageDescription NameContainsInvalidCharacters { get => _namecontainsinvalidcharacters!; set => this.AssertWritable()._namecontainsinvalidcharacters = value; }
    /// <summary>The name &#39;{0}&#39; is too long to be a Culture or Region name, which is limited to {1} characters.</summary>
    public IMessageDescription NameTooLong { get => _nametoolong!; set => this.AssertWritable()._nametoolong = value; }
    /// <summary>&#39;overlapped&#39; has already been freed.</summary>
    public IMessageDescription NativeOverlappedAlreadyFree { get => _nativeoverlappedalreadyfree!; set => this.AssertWritable()._nativeoverlappedalreadyfree = value; }
    /// <summary>&#39;overlapped&#39; was not allocated by this ThreadPoolBoundHandle instance.</summary>
    public IMessageDescription NativeOverlappedWrongBoundHandle { get => _nativeoverlappedwrongboundhandle!; set => this.AssertWritable()._nativeoverlappedwrongboundhandle = value; }
    /// <summary>The specified object must not be an instance of a generic type.</summary>
    public IMessageDescription NeedNonGenericObject { get => _neednongenericobject!; set => this.AssertWritable()._neednongenericobject = value; }
    /// <summary>The specified Type must be a struct containing no references.</summary>
    public IMessageDescription NeedStructWithNoRefs { get => _needstructwithnorefs!; set => this.AssertWritable()._needstructwithnorefs = value; }
    /// <summary>Please select a specific culture, such as zh-CN, zh-HK, zh-TW, zh-MO, zh-SG.</summary>
    public IMessageDescription NoSpecificCulture { get => _nospecificculture!; set => this.AssertWritable()._nospecificculture = value; }
    /// <summary>The object has no underlying COM data associated with it.</summary>
    public IMessageDescription NoUnderlyingCCW { get => _nounderlyingccw!; set => this.AssertWritable()._nounderlyingccw = value; }
    /// <summary>Uninitialized Strings cannot be created.</summary>
    public IMessageDescription NoUninitializedStrings { get => _nouninitializedstrings!; set => this.AssertWritable()._nouninitializedstrings = value; }
    /// <summary>Type must be a TransparentProxy</summary>
    public IMessageDescription NotATP { get => _notatp!; set => this.AssertWritable()._notatp = value; }
    /// <summary>&#39;preAllocated&#39; is already in use.</summary>
    public IMessageDescription PreAllocatedAlreadyAllocated { get => _preallocatedalreadyallocated!; set => this.AssertWritable()._preallocatedalreadyallocated = value; }
    /// <summary>The date is out of the supported range for the Islamic calendar. The date should be greater than July 18th, 622 AD (Gregorian date).</summary>
    public IMessageDescription ResultIslamicCalendarRange { get => _resultislamiccalendarrange!; set => this.AssertWritable()._resultislamiccalendarrange = value; }
    /// <summary>The specified seek offset &#39;{0}&#39; would result in a negative Stream position.</summary>
    public IMessageDescription SeekOverflow { get => _seekoverflow!; set => this.AssertWritable()._seekoverflow = value; }
    /// <summary>The structure must not be a value class.</summary>
    public IMessageDescription StructMustNotBeValueClass { get => _structmustnotbevalueclass!; set => this.AssertWritable()._structmustnotbevalueclass = value; }
    /// <summary>Supplied MemberInfo does not match the expected type.</summary>
    public IMessageDescription UnequalMembers { get => _unequalmembers!; set => this.AssertWritable()._unequalmembers = value; }
    /// <summary>Identity permissions cannot be unrestricted.</summary>
    public IMessageDescription UnrestrictedIdentityPermission { get => _unrestrictedidentitypermission!; set => this.AssertWritable()._unrestrictedidentitypermission = value; }
    /// <summary>The unmanaged Version information is too large to persist.</summary>
    public IMessageDescription VerStringTooLong { get => _verstringtoolong!; set => this.AssertWritable()._verstringtoolong = value; }
    /// <summary>Cannot find cvtres.exe</summary>
    public IMessageDescription cvtresNotFound { get => _cvtresnotfound!; set => this.AssertWritable()._cvtresnotfound = value; }

    /// <summary>Initialize fields</summary>
    public override ArgumentMessages Initialize() 
    {
        base.Initialize();
        Add(_applicationdirectorytostring = new MessageDescription("mscorlib.ApplicationDirectory_ToString", 0xA3450021, new ParameterlessText("ApplicationDirectory")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_accessexception = new MessageDescription("mscorlib.Arg_AccessException", 0xA3450022, new ParameterlessText("Cannot access member.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MemberAccessException)));
        Add(_ambiguousmatchexception = new MessageDescription("mscorlib.Arg_AmbiguousMatchException", 0xA3450024, new ParameterlessText("Ambiguous match found.")).SetHResult(0x8000211D).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.AmbiguousMatchException)));
        Add(_applicationexception = new MessageDescription("mscorlib.Arg_ApplicationException", 0xA3450026, new ParameterlessText("Error in the application.")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ApplicationException)));
        Add(_argumentoutofrangeexception = new MessageDescription("mscorlib.Arg_ArgumentOutOfRangeException", 0xA3450028, new ParameterlessText("Specified argument was out of the range of valid values.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_badimageformatexception = new MessageDescription("mscorlib.Arg_BadImageFormatException", 0xA345002E, new ParameterlessText("Format of the executable (.exe) or library (.dll) is invalid.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.BadImageFormatException)));
        Add(_badliteralformat = new MessageDescription("mscorlib.Arg_BadLiteralFormat", 0xA345002F, new ParameterlessText("Encountered an invalid type for a default value.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_bogusicomparer = new MessageDescription("mscorlib.Arg_BogusIComparer", 0xA3450031, new FormatText("Unable to sort because the IComparer.Compare() method returns inconsistent results. Either a value does not compare equal to itself, or one value repeatedly compared to another value yields different results. IComparer: '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_buffertoosmall = new MessageDescription("mscorlib.Arg_BufferTooSmall", 0xA3450032, new ParameterlessText("Not enough space available in the buffer.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannotbenan = new MessageDescription("mscorlib.Arg_CannotBeNaN", 0xA3450033, new ParameterlessText("TimeSpan does not accept floating point Not-a-Number values.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannotmixcomparisoninfrastructure = new MessageDescription("mscorlib.Arg_CannotMixComparisonInfrastructure", 0xA3450034, new ParameterlessText("The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_catyperesolutionfailed = new MessageDescription("mscorlib.Arg_CATypeResolutionFailed", 0xA3450036, new FormatText("Failed to resolve type from string \"{0}\" which was embedded in custom attribute blob.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_comaccess = new MessageDescription("mscorlib.Arg_COMAccess", 0xA3450037, new ParameterlessText("Must specify property Set or Get or method call for a COM Object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_compropsetput = new MessageDescription("mscorlib.Arg_COMPropSetPut", 0xA3450039, new ParameterlessText("Only one of the following binding flags can be set: BindingFlags.SetProperty, BindingFlags.PutDispProperty,  BindingFlags.PutRefDispProperty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_contextmarshalexception = new MessageDescription("mscorlib.Arg_ContextMarshalException", 0xA345003A, new ParameterlessText("Attempted to marshal an object across a context boundary.")).SetHResult(0x80131504).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ContextMarshalException)));
        Add(_creatinstaccess = new MessageDescription("mscorlib.Arg_CreatInstAccess", 0xA345003B, new ParameterlessText("Cannot specify both CreateInstance and another access type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datamisalignedexception = new MessageDescription("mscorlib.Arg_DataMisalignedException", 0xA345003E, new ParameterlessText("A datatype misalignment was detected in a load or store instruction.")).SetHResult(0x80131541).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.DataMisalignedException)));
        Add(_datetimerange = new MessageDescription("mscorlib.Arg_DateTimeRange", 0xA345003F, new ParameterlessText("Combination of arguments to the DateTime constructor is out of the legal range.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_decbitctor = new MessageDescription("mscorlib.Arg_DecBitCtor", 0xA3450040, new ParameterlessText("Decimal byte array constructor requires an array of length four containing valid decimal bytes.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_dividebyzero = new MessageDescription("mscorlib.Arg_DivideByZero", 0xA3450043, new ParameterlessText("Attempted to divide by zero.")).SetHResult(0x80020012).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.DivideByZeroException)));
        Add(_dlgtnullinst = new MessageDescription("mscorlib.Arg_DlgtNullInst", 0xA3450044, new ParameterlessText("Delegate to an instance method cannot have null 'this'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_dlgttargmeth = new MessageDescription("mscorlib.Arg_DlgtTargMeth", 0xA3450045, new ParameterlessText("Cannot bind to the target method because its signature or security transparency is not compatible with that of the delegate type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_dlgttypemis = new MessageDescription("mscorlib.Arg_DlgtTypeMis", 0xA3450046, new ParameterlessText("Delegates must be of the same type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_dllinitfailure = new MessageDescription("mscorlib.Arg_DllInitFailure", 0xA3450047, new ParameterlessText("One machine may not have remote administration enabled, or both machines may not be running the remote registry service.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_dllnotfoundexception = new MessageDescription("mscorlib.Arg_DllNotFoundException", 0xA3450048, new ParameterlessText("Dll was not found.")).SetHResult(0x80131524).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.DllNotFoundException)));
        Add(_duplicatewaitobjectexception = new MessageDescription("mscorlib.Arg_DuplicateWaitObjectException", 0xA345004A, new ParameterlessText("Duplicate objects in argument.")).SetHResult(0x80131529).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.DuplicateWaitObjectException)));
        Add(_emptycollection = new MessageDescription("mscorlib.Arg_EmptyCollection", 0xA345004E, new ParameterlessText("Collection must not be empty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptyornullstring = new MessageDescription("mscorlib.Arg_EmptyOrNullString", 0xA3450050, new ParameterlessText("String may not be empty or null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_entrypointnotfoundexception = new MessageDescription("mscorlib.Arg_EntryPointNotFoundException", 0xA3450052, new ParameterlessText("Entry point was not found.")).SetHResult(0x80131523).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.EntryPointNotFoundException)));
        Add(_enumandobjectmustbesametype = new MessageDescription("mscorlib.Arg_EnumAndObjectMustBeSameType", 0xA3450053, new FormatText("Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_enumatleastoneflag = new MessageDescription("mscorlib.Arg_EnumAtLeastOneFlag", 0xA3450054, new ParameterlessText("Must set at least one flag.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_enumformatunderlyingtypeandobjectmustbesametype = new MessageDescription("mscorlib.Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType", 0xA3450055, new FormatText("Enum underlying type and the object must be same type or object. Type passed in was '{0}'; the enum underlying type was '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_enumlitvaluenotfound = new MessageDescription("mscorlib.Arg_EnumLitValueNotFound", 0xA3450057, new ParameterlessText("Literal value was not found.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_enumnotsingleflag = new MessageDescription("mscorlib.Arg_EnumNotSingleFlag", 0xA3450058, new ParameterlessText("Must set exactly one flag.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_enumunderlyingtypeandobjectmustbesametype = new MessageDescription("mscorlib.Arg_EnumUnderlyingTypeAndObjectMustBeSameType", 0xA3450059, new FormatText("Enum underlying type and the object must be same type or object must be a String. Type passed in was '{0}'; the enum underlying type was '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_enumvaluenotfound = new MessageDescription("mscorlib.Arg_EnumValueNotFound", 0xA345005A, new FormatText("Requested value '{0}' was not found.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fieldaccessexception = new MessageDescription("mscorlib.Arg_FieldAccessException", 0xA345005D, new ParameterlessText("Attempted to access a field that is not accessible by the caller.")).SetHResult(0x80131507).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.FieldAccessException)));
        Add(_fielddecltarget = new MessageDescription("mscorlib.Arg_FieldDeclTarget", 0xA345005E, new FormatText("Field '{0}' defined on type '{1}' is not a field on the target object which is of type '{2}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fileisdirectoryname = new MessageDescription("mscorlib.Arg_FileIsDirectory_Name", 0xA345005F, new FormatText("The target file \"{0}\" is a directory, not a file.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_fldgetargerr = new MessageDescription("mscorlib.Arg_FldGetArgErr", 0xA3450060, new ParameterlessText("No arguments can be provided to Get a field value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fldgetpropset = new MessageDescription("mscorlib.Arg_FldGetPropSet", 0xA3450061, new ParameterlessText("Cannot specify both GetField and SetProperty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fldsetargerr = new MessageDescription("mscorlib.Arg_FldSetArgErr", 0xA3450062, new ParameterlessText("Only the field value can be specified to set a field value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fldsetget = new MessageDescription("mscorlib.Arg_FldSetGet", 0xA3450063, new ParameterlessText("Cannot specify both Get and Set on a field.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fldsetinvoke = new MessageDescription("mscorlib.Arg_FldSetInvoke", 0xA3450064, new ParameterlessText("Cannot specify Set on a Field and Invoke on a method.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fldsetpropget = new MessageDescription("mscorlib.Arg_FldSetPropGet", 0xA3450065, new ParameterlessText("Cannot specify both SetField and GetProperty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_formatexception = new MessageDescription("mscorlib.Arg_FormatException", 0xA3450066, new ParameterlessText("One of the identified items was in an invalid format.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.FormatException)));
        Add(_genericparameter = new MessageDescription("mscorlib.Arg_GenericParameter", 0xA3450067, new ParameterlessText("Method must be called on a Type for which Type.IsGenericParameter is false.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_getmethnotfnd = new MessageDescription("mscorlib.Arg_GetMethNotFnd", 0xA3450068, new ParameterlessText("Property Get method was not found.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_handlenotasync = new MessageDescription("mscorlib.Arg_HandleNotAsync", 0xA345006A, new ParameterlessText("Handle does not support asynchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened synchronously (that is, it was not opened for overlapped I/O).")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_handlenotsync = new MessageDescription("mscorlib.Arg_HandleNotSync", 0xA345006B, new ParameterlessText("Handle does not support synchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened asynchronously (that is, it was opened explicitly for overlapped I/O).")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_htcapacityoverflow = new MessageDescription("mscorlib.Arg_HTCapacityOverflow", 0xA345006D, new ParameterlessText("Hashtable's capacity overflowed and went negative. Check load factor, capacity and the current size of the table.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_indexmustbeint = new MessageDescription("mscorlib.Arg_IndexMustBeInt", 0xA345006E, new ParameterlessText("All indexes must be of type Int32.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_indexoutofrangeexception = new MessageDescription("mscorlib.Arg_IndexOutOfRangeException", 0xA345006F, new ParameterlessText("Index was outside the bounds of the array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_invalidaccessentry = new MessageDescription("mscorlib.Arg_InvalidAccessEntry", 0xA3450071, new ParameterlessText("Specified access entry is invalid because it is unrestricted. The global flags should be specified instead.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidbase = new MessageDescription("mscorlib.Arg_InvalidBase", 0xA3450072, new ParameterlessText("Invalid Base.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidcastexception = new MessageDescription("mscorlib.Arg_InvalidCastException", 0xA3450073, new ParameterlessText("Specified cast is not valid.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.InvalidCastException)));
        Add(_invalidconsolecolor = new MessageDescription("mscorlib.Arg_InvalidConsoleColor", 0xA3450075, new ParameterlessText("The ConsoleColor enum value was not defined on that enum. Please use a defined color from the enum.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfileattrs = new MessageDescription("mscorlib.Arg_InvalidFileAttrs", 0xA3450076, new ParameterlessText("Invalid File or Directory attributes value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfileextension = new MessageDescription("mscorlib.Arg_InvalidFileExtension", 0xA3450077, new ParameterlessText("Specified file extension was not a valid extension.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfilename = new MessageDescription("mscorlib.Arg_InvalidFileName", 0xA3450078, new ParameterlessText("Specified file name was invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidhandle = new MessageDescription("mscorlib.Arg_InvalidHandle", 0xA345007A, new ParameterlessText("Invalid handle.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidhexstyle = new MessageDescription("mscorlib.Arg_InvalidHexStyle", 0xA345007B, new ParameterlessText("With the AllowHexSpecifier bit set in the enum bit field, the only other valid bits that can be combined into the enum value must be a subset of those in HexNumber.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidneutralresourceslanguageasmculture = new MessageDescription("mscorlib.Arg_InvalidNeutralResourcesLanguage_Asm_Culture", 0xA345007C, new FormatText("The NeutralResourcesLanguageAttribute on the assembly \"{0}\" specifies an invalid culture name: \"{1}\".")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidneutralresourceslanguagefallbackloc = new MessageDescription("mscorlib.Arg_InvalidNeutralResourcesLanguage_FallbackLoc", 0xA345007D, new FormatText("The NeutralResourcesLanguageAttribute specifies an invalid or unrecognized ultimate resource fallback location: \"{0}\".")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsearchpattern = new MessageDescription("mscorlib.Arg_InvalidSearchPattern", 0xA3450081, new ParameterlessText("Search pattern cannot contain \"..\" to move up directories and can be contained only internally in file/directory names, as in \"a..b\".")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtypeinrettype = new MessageDescription("mscorlib.Arg_InvalidTypeInRetType", 0xA3450082, new ParameterlessText("The return Type contains some invalid type (i.e. null, ByRef)")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_invalidtypeinsignature = new MessageDescription("mscorlib.Arg_InvalidTypeInSignature", 0xA3450083, new ParameterlessText("The signature Type array contains some invalid type (i.e. null, void)")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invokemember = new MessageDescription("mscorlib.Arg_InvokeMember", 0xA3450084, new ParameterlessText("InvokeMember can be used only for COM objects.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_longerthansrcstring = new MessageDescription("mscorlib.Arg_LongerThanSrcString", 0xA3450087, new ParameterlessText("Source string was not long enough. Check sourceIndex and count.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_lowerboundsmustmatch = new MessageDescription("mscorlib.Arg_LowerBoundsMustMatch", 0xA3450088, new ParameterlessText("The arrays' lower bounds must be identical.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_marshalasanyrestriction = new MessageDescription("mscorlib.Arg_MarshalAsAnyRestriction", 0xA3450089, new ParameterlessText("AsAny cannot be used on return types, ByRef parameters, ArrayWithOffset, or parameters passed from unmanaged to managed.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.StubHelpers").SetException(typeof(System.ArgumentException)));
        Add(_methodaccessexception = new MessageDescription("mscorlib.Arg_MethodAccessException", 0xA345008B, new ParameterlessText("Attempt to access the method failed.")).SetHResult(0x80131510).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MethodAccessException)));
        Add(_methodaccessexceptionwithcaller = new MessageDescription("mscorlib.Arg_MethodAccessException_WithCaller", 0xA345008C, new FormatText("Attempt by security transparent method '{0}' to access security critical method '{1}' failed.")).SetHResult(0x80131510).SetSeverity(MessageLevel.Error).SetException(typeof(System.MethodAccessException)));
        Add(_methodaccessexceptionwithmethodname = new MessageDescription("mscorlib.Arg_MethodAccessException_WithMethodName", 0xA345008D, new FormatText("Attempt to access the method \"{0}\" on type \"{1}\" failed.")).SetHResult(0x80131510).SetSeverity(MessageLevel.Error).SetException(typeof(System.MethodAccessException)));
        Add(_missingactivationarguments = new MessageDescription("mscorlib.Arg_MissingActivationArguments", 0xA345008E, new ParameterlessText("The AppDomainSetup must specify the activation arguments for this call.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_missingfieldexception = new MessageDescription("mscorlib.Arg_MissingFieldException", 0xA345008F, new ParameterlessText("Attempted to access a non-existing field.")).SetHResult(0x80131511).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingFieldException)));
        Add(_missingmemberexception = new MessageDescription("mscorlib.Arg_MissingMemberException", 0xA3450091, new ParameterlessText("Attempted to access a missing member.")).SetHResult(0x80131512).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingMemberException)));
        Add(_missingmethodexception = new MessageDescription("mscorlib.Arg_MissingMethodException", 0xA3450092, new ParameterlessText("Attempted to access a missing method.")).SetHResult(0x80131513).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingMethodException)));
        Add(_mustbeboolean = new MessageDescription("mscorlib.Arg_MustBeBoolean", 0xA3450094, new ParameterlessText("Object must be of type Boolean.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbebyte = new MessageDescription("mscorlib.Arg_MustBeByte", 0xA3450095, new ParameterlessText("Object must be of type Byte.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbechar = new MessageDescription("mscorlib.Arg_MustBeChar", 0xA3450096, new ParameterlessText("Object must be of type Char.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbedatetime = new MessageDescription("mscorlib.Arg_MustBeDateTime", 0xA3450097, new ParameterlessText("Object must be of type DateTime.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbedatetimeoffset = new MessageDescription("mscorlib.Arg_MustBeDateTimeOffset", 0xA3450098, new ParameterlessText("Object must be of type DateTimeOffset.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbedecimal = new MessageDescription("mscorlib.Arg_MustBeDecimal", 0xA3450099, new ParameterlessText("Object must be of type Decimal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbedelegate = new MessageDescription("mscorlib.Arg_MustBeDelegate", 0xA345009A, new ParameterlessText("Type must derive from Delegate.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbedouble = new MessageDescription("mscorlib.Arg_MustBeDouble", 0xA345009B, new ParameterlessText("Object must be of type Double.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbedriveletterorrootdir = new MessageDescription("mscorlib.Arg_MustBeDriveLetterOrRootDir", 0xA345009C, new ParameterlessText("Object must be a root directory (\"C:\\\") or a drive letter (\"C\").")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeenum = new MessageDescription("mscorlib.Arg_MustBeEnum", 0xA345009D, new ParameterlessText("Type provided must be an Enum.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeenumbasetypeorenum = new MessageDescription("mscorlib.Arg_MustBeEnumBaseTypeOrEnum", 0xA345009E, new ParameterlessText("The value passed in must be an enum base or an underlying type for an enum, such as an Int32.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeguid = new MessageDescription("mscorlib.Arg_MustBeGuid", 0xA345009F, new ParameterlessText("Object must be of type GUID.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeint16 = new MessageDescription("mscorlib.Arg_MustBeInt16", 0xA34500A1, new ParameterlessText("Object must be of type Int16.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeint32 = new MessageDescription("mscorlib.Arg_MustBeInt32", 0xA34500A2, new ParameterlessText("Object must be of type Int32.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeint64 = new MessageDescription("mscorlib.Arg_MustBeInt64", 0xA34500A3, new ParameterlessText("Object must be of type Int64.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbepointer = new MessageDescription("mscorlib.Arg_MustBePointer", 0xA34500A4, new ParameterlessText("Type must be a Pointer.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbesbyte = new MessageDescription("mscorlib.Arg_MustBeSByte", 0xA34500A6, new ParameterlessText("Object must be of type SByte.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbesingle = new MessageDescription("mscorlib.Arg_MustBeSingle", 0xA34500A7, new ParameterlessText("Object must be of type Single.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbestatic = new MessageDescription("mscorlib.Arg_MustBeStatic", 0xA34500A8, new ParameterlessText("Method must be a static method.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbestring = new MessageDescription("mscorlib.Arg_MustBeString", 0xA34500A9, new ParameterlessText("Object must be of type String.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbestringptrnotatom = new MessageDescription("mscorlib.Arg_MustBeStringPtrNotAtom", 0xA34500AA, new ParameterlessText("The pointer passed in as a String must not be in the bottom 64K of the process's address space.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbetimespan = new MessageDescription("mscorlib.Arg_MustBeTimeSpan", 0xA34500AB, new ParameterlessText("Object must be of type TimeSpan.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbetrue = new MessageDescription("mscorlib.Arg_MustBeTrue", 0xA34500AC, new ParameterlessText("Argument must be true.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbetype = new MessageDescription("mscorlib.Arg_MustBeType", 0xA34500AD, new ParameterlessText("Type must be a type provided by the runtime.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeuint16 = new MessageDescription("mscorlib.Arg_MustBeUInt16", 0xA34500AE, new ParameterlessText("Object must be of type UInt16.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeuint32 = new MessageDescription("mscorlib.Arg_MustBeUInt32", 0xA34500AF, new ParameterlessText("Object must be of type UInt32.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeuint64 = new MessageDescription("mscorlib.Arg_MustBeUInt64", 0xA34500B0, new ParameterlessText("Object must be of type UInt64.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeversion = new MessageDescription("mscorlib.Arg_MustBeVersion", 0xA34500B1, new ParameterlessText("Object must be of type Version.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustcontainenuminfo = new MessageDescription("mscorlib.Arg_MustContainEnumInfo", 0xA34500B2, new ParameterlessText("Must specify valid information for parsing in the string.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_namedparamnull = new MessageDescription("mscorlib.Arg_NamedParamNull", 0xA34500B3, new ParameterlessText("Named parameter value must not be null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_namedparamtoobig = new MessageDescription("mscorlib.Arg_NamedParamTooBig", 0xA34500B4, new ParameterlessText("Named parameter array cannot be bigger than argument array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_ndirectbadobject = new MessageDescription("mscorlib.Arg_NDirectBadObject", 0xA34500B5, new ParameterlessText("No PInvoke conversion exists for value passed to Object-typed parameter.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.StubHelpers").SetException(typeof(System.ArgumentException)));
        Add(_needatleast1rank = new MessageDescription("mscorlib.Arg_NeedAtLeast1Rank", 0xA34500B9, new ParameterlessText("Must provide at least one rank.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_negativeargcount = new MessageDescription("mscorlib.Arg_NegativeArgCount", 0xA34500BA, new ParameterlessText("Argument count must not be negative.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_noaccessspec = new MessageDescription("mscorlib.Arg_NoAccessSpec", 0xA34500BB, new ParameterlessText("Must specify binding flags describing the invoke operation required (BindingFlags.InvokeMethod CreateInstance GetField SetField GetProperty SetProperty).")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nodefctor = new MessageDescription("mscorlib.Arg_NoDefCTor", 0xA34500BC, new ParameterlessText("No parameterless constructor defined for this object.")).SetHResult(0x80131513).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingMethodException)));
        Add(_nonzerolowerbound = new MessageDescription("mscorlib.Arg_NonZeroLowerBound", 0xA34500BD, new ParameterlessText("The lower bound of target array must be zero.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nostaticvirtual = new MessageDescription("mscorlib.Arg_NoStaticVirtual", 0xA34500BE, new ParameterlessText("Method cannot be both static and virtual.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notfinitenumberexception = new MessageDescription("mscorlib.Arg_NotFiniteNumberException", 0xA34500BF, new ParameterlessText("Number encountered was not a finite quantity.")).SetHResult(0x80131528).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.NotFiniteNumberException)));
        Add(_notgenericmethoddefinition = new MessageDescription("mscorlib.Arg_NotGenericMethodDefinition", 0xA34500C0, new FormatText("{0} is not a GenericMethodDefinition. MakeGenericMethod may only be called on a method for which MethodBase.IsGenericMethodDefinition is true.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notgenericparameter = new MessageDescription("mscorlib.Arg_NotGenericParameter", 0xA34500C1, new ParameterlessText("Method may only be called on a Type for which Type.IsGenericParameter is true.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notgenerictypedefinition = new MessageDescription("mscorlib.Arg_NotGenericTypeDefinition", 0xA34500C2, new FormatText("{0} is not a GenericTypeDefinition. MakeGenericType may only be called on a type for which Type.IsGenericTypeDefinition is true.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_objobj = new MessageDescription("mscorlib.Arg_ObjObj", 0xA34500C6, new ParameterlessText("Object type cannot be converted to target type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_objobjex = new MessageDescription("mscorlib.Arg_ObjObjEx", 0xA34500C7, new FormatText("Object of type '{0}' cannot be converted to type '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_oleautdateinvalid = new MessageDescription("mscorlib.Arg_OleAutDateInvalid", 0xA34500C8, new ParameterlessText("Not a legal OleAut date.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_oleautdatescale = new MessageDescription("mscorlib.Arg_OleAutDateScale", 0xA34500C9, new ParameterlessText("OleAut date did not convert to a DateTime correctly.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_overflowexception = new MessageDescription("mscorlib.Arg_OverflowException", 0xA34500CA, new ParameterlessText("Arithmetic operation resulted in an overflow.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.OverflowException)));
        Add(_paramnamename = new MessageDescription("mscorlib.Arg_ParamName_Name", 0xA34500CB, new FormatText("Parameter name: {0}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_parmcnt = new MessageDescription("mscorlib.Arg_ParmCnt", 0xA34500CD, new ParameterlessText("Parameter count mismatch.")).SetHResult(0x8002000E).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetParameterCountException)));
        Add(_path2isrooted = new MessageDescription("mscorlib.Arg_Path2IsRooted", 0xA34500CE, new ParameterlessText("Second path fragment must not be a drive or UNC name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_pathglobalroot = new MessageDescription("mscorlib.Arg_PathGlobalRoot", 0xA34500CF, new ParameterlessText("Paths that begin with \\\\?\\GlobalRoot are internal to the kernel and should not be opened by managed applications.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_pathillegal = new MessageDescription("mscorlib.Arg_PathIllegal", 0xA34500D0, new ParameterlessText("The path is not of a legal form.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_pathillegalunc = new MessageDescription("mscorlib.Arg_PathIllegalUNC", 0xA34500D1, new ParameterlessText("The UNC path should be of the form \\\\server\\share.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_pathisvolume = new MessageDescription("mscorlib.Arg_PathIsVolume", 0xA34500D2, new ParameterlessText("Path must not be a drive.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_platformsecurestring = new MessageDescription("mscorlib.Arg_PlatformSecureString", 0xA34500D4, new ParameterlessText("SecureString is only supported on Windows 2000 SP3 and higher platforms.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_propnotfound = new MessageDescription("mscorlib.Arg_PropNotFound", 0xA34500D5, new ParameterlessText("Could not find the specified property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_propsetget = new MessageDescription("mscorlib.Arg_PropSetGet", 0xA34500D6, new ParameterlessText("Cannot specify both Get and Set on a property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_propsetinvoke = new MessageDescription("mscorlib.Arg_PropSetInvoke", 0xA34500D7, new ParameterlessText("Cannot specify Set on a property and Invoke on a method.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_rankexception = new MessageDescription("mscorlib.Arg_RankException", 0xA34500D8, new ParameterlessText("Attempted to operate on an array with the incorrect number of dimensions.")).SetHResult(0x80131517).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.RankException)));
        Add(_rankindices = new MessageDescription("mscorlib.Arg_RankIndices", 0xA34500D9, new ParameterlessText("Indices length does not match the array rank.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_ranksandbounds = new MessageDescription("mscorlib.Arg_RanksAndBounds", 0xA34500DB, new ParameterlessText("Number of lengths and lowerBounds must match.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_reflectiononlyca = new MessageDescription("mscorlib.Arg_ReflectionOnlyCA", 0xA34500DC, new ParameterlessText("It is illegal to reflect on the custom attributes of a Type loaded via ReflectionOnlyGetType (see Assembly.ReflectionOnly) -- use CustomAttributeData instead.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_reflectiononlyfield = new MessageDescription("mscorlib.Arg_ReflectionOnlyField", 0xA34500DD, new ParameterlessText("It is illegal to get or set the value on a field on a Type loaded via ReflectionOnlyGetType.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_reflectiononlyinvoke = new MessageDescription("mscorlib.Arg_ReflectionOnlyInvoke", 0xA34500DE, new ParameterlessText("It is illegal to invoke a method on a Type loaded via ReflectionOnlyGetType.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regbadkeykind = new MessageDescription("mscorlib.Arg_RegBadKeyKind", 0xA34500DF, new ParameterlessText("The specified RegistryValueKind is an invalid value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_reggetoverflowbug = new MessageDescription("mscorlib.Arg_RegGetOverflowBug", 0xA34500E0, new ParameterlessText("RegistryKey.GetValue does not allow a String that has a length greater than Int32.MaxValue.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_reginvalidkeyname = new MessageDescription("mscorlib.Arg_RegInvalidKeyName", 0xA34500E1, new ParameterlessText("Registry key name must start with a valid base key name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regkeydelhive = new MessageDescription("mscorlib.Arg_RegKeyDelHive", 0xA34500E2, new ParameterlessText("Cannot delete a registry hive's subtree.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regkeynoremoteconnect = new MessageDescription("mscorlib.Arg_RegKeyNoRemoteConnect", 0xA34500E3, new FormatText("No remote connection to '{0}' while trying to read the registry.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regkeynotfound = new MessageDescription("mscorlib.Arg_RegKeyNotFound", 0xA34500E4, new ParameterlessText("The specified registry key does not exist.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_regkeyoutofrange = new MessageDescription("mscorlib.Arg_RegKeyOutOfRange", 0xA34500E5, new ParameterlessText("Registry HKEY was out of the legal range.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regkeystrlenbug = new MessageDescription("mscorlib.Arg_RegKeyStrLenBug", 0xA34500E6, new ParameterlessText("Registry key names should not be greater than 255 characters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regsetbadarrtype = new MessageDescription("mscorlib.Arg_RegSetBadArrType", 0xA34500E7, new FormatText("RegistryKey.SetValue does not support arrays of type '{0}'. Only Byte[] and String[] are supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regsetmismatchedkind = new MessageDescription("mscorlib.Arg_RegSetMismatchedKind", 0xA34500E8, new ParameterlessText("The type of the value object did not match the specified RegistryValueKind or the object could not be properly converted.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regsetstrarrnull = new MessageDescription("mscorlib.Arg_RegSetStrArrNull", 0xA34500E9, new ParameterlessText("RegistryKey.SetValue does not allow a String[] that contains a null String reference.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regsubkeyabsent = new MessageDescription("mscorlib.Arg_RegSubKeyAbsent", 0xA34500EA, new ParameterlessText("Cannot delete a subkey tree because the subkey does not exist.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regsubkeyvalueabsent = new MessageDescription("mscorlib.Arg_RegSubKeyValueAbsent", 0xA34500EB, new ParameterlessText("No value exists with that name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_regvalstrlenbug = new MessageDescription("mscorlib.Arg_RegValStrLenBug", 0xA34500EC, new ParameterlessText("Registry value names should not be greater than 16,383 characters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_removeargnotfound = new MessageDescription("mscorlib.Arg_RemoveArgNotFound", 0xA34500ED, new ParameterlessText("Cannot remove the specified item because it was not found in the specified Collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resourcefileunsupportedversion = new MessageDescription("mscorlib.Arg_ResourceFileUnsupportedVersion", 0xA34500EF, new FormatText("The ResourceReader class does not know how to read this version of .resources files. Expected version: {0}  This file: {1}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resourcenamenotexist = new MessageDescription("mscorlib.Arg_ResourceNameNotExist", 0xA34500F0, new FormatText("The specified resource name \"{0}\" does not exist in the resource file.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_setmethnotfnd = new MessageDescription("mscorlib.Arg_SetMethNotFnd", 0xA34500F5, new ParameterlessText("Property set method not found.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_surrogatesnotallowedassinglechar = new MessageDescription("mscorlib.Arg_SurrogatesNotAllowedAsSingleChar", 0xA34500F7, new ParameterlessText("Unicode surrogate characters must be written out as pairs together in the same call, not individually. Consider passing in a character array instead.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_systemexception = new MessageDescription("mscorlib.Arg_SystemException", 0xA34500F9, new ParameterlessText("System error.")).SetHResult(0x80131501).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.SystemException)));
        Add(_timeoutexception = new MessageDescription("mscorlib.Arg_TimeoutException", 0xA34500FE, new ParameterlessText("The operation has timed out.")).SetHResult(0x80131505).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TimeoutException)));
        Add(_typeaccessexception = new MessageDescription("mscorlib.Arg_TypeAccessException", 0xA34500FF, new ParameterlessText("Attempt to access the type failed.")).SetHResult(0x80131543).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TypeAccessException)));
        Add(_typeloadexception = new MessageDescription("mscorlib.Arg_TypeLoadException", 0xA3450101, new ParameterlessText("Failure has occurred while loading a type.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TypeLoadException)));
        Add(_typeloadnullstr = new MessageDescription("mscorlib.Arg_TypeLoadNullStr", 0xA3450102, new ParameterlessText("A null or zero length string does not represent a valid Type.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeLoadException)));
        Add(_typerefprimitve = new MessageDescription("mscorlib.Arg_TypeRefPrimitve", 0xA3450103, new ParameterlessText("TypedReferences cannot be redefined as primitives.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typeunloadedexception = new MessageDescription("mscorlib.Arg_TypeUnloadedException", 0xA3450104, new ParameterlessText("Type had been unloaded.")).SetHResult(0x80131013).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TypeUnloadedException)));
        Add(_unauthorizedaccessexception = new MessageDescription("mscorlib.Arg_UnauthorizedAccessException", 0xA3450105, new ParameterlessText("Attempted to perform an unauthorized operation.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.UnauthorizedAccessException)));
        Add(_unboundgenfield = new MessageDescription("mscorlib.Arg_UnboundGenField", 0xA3450106, new ParameterlessText("Late bound operations cannot be performed on fields with types for which Type.ContainsGenericParameters is true.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_unboundgenparam = new MessageDescription("mscorlib.Arg_UnboundGenParam", 0xA3450107, new ParameterlessText("Late bound operations cannot be performed on types or methods for which ContainsGenericParameters is true.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_unknowntypecode = new MessageDescription("mscorlib.Arg_UnknownTypeCode", 0xA3450108, new ParameterlessText("Unknown TypeCode value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_varmissnull = new MessageDescription("mscorlib.Arg_VarMissNull", 0xA3450109, new ParameterlessText("Missing parameter does not have a default value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_versionstring = new MessageDescription("mscorlib.Arg_VersionString", 0xA345010A, new ParameterlessText("Version string portion was too short or too long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_wrongasyncresult = new MessageDescription("mscorlib.Arg_WrongAsyncResult", 0xA345010B, new ParameterlessText("IAsyncResult object did not come from the corresponding async method on this type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_wrongtype = new MessageDescription("mscorlib.Arg_WrongType", 0xA345010C, new FormatText("The value \"{0}\" is not of type \"{1}\" and cannot be used in this generic collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_absolutepathrequired = new MessageDescription("mscorlib.Argument_AbsolutePathRequired", 0xA345010D, new ParameterlessText("Absolute path information is required.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_addingduplicate = new MessageDescription("mscorlib.Argument_AddingDuplicate", 0xA345010E, new ParameterlessText("An item with the same key has already been added.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_addingduplicate2 = new MessageDescription("mscorlib.Argument_AddingDuplicate__", 0xA345010F, new FormatText("Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_adjustmentrulesnonulls = new MessageDescription("mscorlib.Argument_AdjustmentRulesNoNulls", 0xA3450110, new ParameterlessText("The AdjustmentRule array cannot contain null elements.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidTimeZoneException)));
        Add(_adjustmentrulesoutoforder = new MessageDescription("mscorlib.Argument_AdjustmentRulesOutOfOrder", 0xA3450111, new ParameterlessText("The elements of the AdjustmentRule array must be in chronological order and must not overlap.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidTimeZoneException)));
        Add(_alsinvalidslot = new MessageDescription("mscorlib.Argument_ALSInvalidSlot", 0xA3450112, new ParameterlessText("Specified slot number was invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_applicationtrustshouldhaveidentity = new MessageDescription("mscorlib.Argument_ApplicationTrustShouldHaveIdentity", 0xA3450113, new ParameterlessText("An ApplicationTrust must have an application identity before it can be persisted.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_argumentzero = new MessageDescription("mscorlib.Argument_ArgumentZero", 0xA3450114, new ParameterlessText("Argument cannot be zero.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_assemblyalreadyfulltrust = new MessageDescription("mscorlib.Argument_AssemblyAlreadyFullTrust", 0xA3450118, new ParameterlessText("Assembly was already fully trusted.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_assemblynotfulltrust = new MessageDescription("mscorlib.Argument_AssemblyNotFullTrust", 0xA3450119, new ParameterlessText("Assembly was not fully trusted.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_attributenamesmustbeunique = new MessageDescription("mscorlib.Argument_AttributeNamesMustBeUnique", 0xA345011A, new ParameterlessText("Attribute names must be unique.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badattributeoninterfacemethod = new MessageDescription("mscorlib.Argument_BadAttributeOnInterfaceMethod", 0xA345011B, new ParameterlessText("Interface method must be abstract and virtual.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badcaforunmngrsc = new MessageDescription("mscorlib.Argument_BadCAForUnmngRSC", 0xA345011C, new FormatText("Bad '{0}' while generating unmanaged resource information.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badconstructor = new MessageDescription("mscorlib.Argument_BadConstructor", 0xA345011D, new ParameterlessText("Cannot have private or static constructor.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badconstructorcallconv = new MessageDescription("mscorlib.Argument_BadConstructorCallConv", 0xA345011E, new ParameterlessText("Constructor must have standard calling convention.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badfieldforconstructorbuilder = new MessageDescription("mscorlib.Argument_BadFieldForConstructorBuilder", 0xA3450120, new ParameterlessText("Field must be on the same type of the given ConstructorInfo.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badfieldsig = new MessageDescription("mscorlib.Argument_BadFieldSig", 0xA3450121, new ParameterlessText("Field signatures do not have return types.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badfieldtype = new MessageDescription("mscorlib.Argument_BadFieldType", 0xA3450122, new ParameterlessText("Bad field type in defining field.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badimageformatexceptionresolve = new MessageDescription("mscorlib.Argument_BadImageFormatExceptionResolve", 0xA3450123, new ParameterlessText("A BadImageFormatException has been thrown while parsing the signature. This is likely due to lack of a generic context. Ensure genericTypeArguments and genericMethodArguments are provided and contain enough context.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badnestedtypeflags = new MessageDescription("mscorlib.Argument_BadNestedTypeFlags", 0xA3450126, new ParameterlessText("Visibility of interfaces must be one of the following: NestedAssembly, NestedFamANDAssem, NestedFamily, NestedFamORAssem, NestedPrivate or NestedPublic.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badobjref = new MessageDescription("mscorlib.Argument_BadObjRef", 0xA3450127, new FormatText("Invalid ObjRef provided to '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badparametercountsforconstructor = new MessageDescription("mscorlib.Argument_BadParameterCountsForConstructor", 0xA3450128, new ParameterlessText("Parameter count does not match passed in argument value count.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badparametertypeforcab = new MessageDescription("mscorlib.Argument_BadParameterTypeForCAB", 0xA3450129, new FormatText("Cannot emit a CustomAttribute with argument of type {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badparametertypeforconstructor = new MessageDescription("mscorlib.Argument_BadParameterTypeForConstructor", 0xA345012A, new FormatText("Passed in argument value at index {0} does not match the parameter type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badpinvokemethod = new MessageDescription("mscorlib.Argument_BadPInvokeMethod", 0xA345012C, new ParameterlessText("PInvoke methods must be static and native and cannot be abstract.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badpinvokeoninterface = new MessageDescription("mscorlib.Argument_BadPInvokeOnInterface", 0xA345012D, new ParameterlessText("PInvoke methods cannot exist on interfaces.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badpropertyforconstructorbuilder = new MessageDescription("mscorlib.Argument_BadPropertyForConstructorBuilder", 0xA345012E, new ParameterlessText("Property must be on the same type of the given ConstructorInfo.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badresourcescopetypebits = new MessageDescription("mscorlib.Argument_BadResourceScopeTypeBits", 0xA345012F, new FormatText("Unknown value for the ResourceScope: {0}  Too many resource type bits may be set.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badresourcescopevisibilitybits = new MessageDescription("mscorlib.Argument_BadResourceScopeVisibilityBits", 0xA3450130, new FormatText("Unknown value for the ResourceScope: {0}  Too many resource visibility bits may be set.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badsigformat = new MessageDescription("mscorlib.Argument_BadSigFormat", 0xA3450131, new ParameterlessText("Incorrect signature format.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badsizefordata = new MessageDescription("mscorlib.Argument_BadSizeForData", 0xA3450132, new ParameterlessText("Data size must be > 0 and < 0x3f0000")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badtypeattrinvalidlayout = new MessageDescription("mscorlib.Argument_BadTypeAttrInvalidLayout", 0xA3450133, new ParameterlessText("Bad type attributes. Invalid layout attribute specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badtypeattrnestedvisibilityonnonnestedtype = new MessageDescription("mscorlib.Argument_BadTypeAttrNestedVisibilityOnNonNestedType", 0xA3450134, new ParameterlessText("Bad type attributes. Nested visibility flag set on a non-nested type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badtypeattrnonnestedvisibilitynestedtype = new MessageDescription("mscorlib.Argument_BadTypeAttrNonNestedVisibilityNestedType", 0xA3450135, new ParameterlessText("Bad type attributes. Non-nested visibility flag set on a nested type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badtypeattrreservedbitsset = new MessageDescription("mscorlib.Argument_BadTypeAttrReservedBitsSet", 0xA3450136, new ParameterlessText("Bad type attributes. Reserved bits set on the type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badtypeincustomattribute = new MessageDescription("mscorlib.Argument_BadTypeInCustomAttribute", 0xA3450137, new ParameterlessText("An invalid type was used as a custom attribute constructor argument, field or property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_blobcannotbenull = new MessageDescription("mscorlib.Argument_BlobCannotBeNull", 0xA3450138, new ParameterlessText("Public key must be specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannotgettypetokenforbyref = new MessageDescription("mscorlib.Argument_CannotGetTypeTokenForByRef", 0xA3450139, new ParameterlessText("Cannot get TypeToken for a ByRef type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannotsetparenttointerface = new MessageDescription("mscorlib.Argument_CannotSetParentToInterface", 0xA345013A, new ParameterlessText("Cannot set parent to an interface.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_codegroupchildrenmustbecodegroups = new MessageDescription("mscorlib.Argument_CodeGroupChildrenMustBeCodeGroups", 0xA345013B, new ParameterlessText("All objects in the input list must have a parent type of 'CodeGroup'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_compareoptionordinal = new MessageDescription("mscorlib.Argument_CompareOptionOrdinal", 0xA345013D, new ParameterlessText("CompareOption.Ordinal cannot be used with other options.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_conflictingdatetimeroundtripstyles = new MessageDescription("mscorlib.Argument_ConflictingDateTimeRoundtripStyles", 0xA345013E, new ParameterlessText("The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_conflictingdatetimestyles = new MessageDescription("mscorlib.Argument_ConflictingDateTimeStyles", 0xA345013F, new ParameterlessText("The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_constantdoesntmatch = new MessageDescription("mscorlib.Argument_ConstantDoesntMatch", 0xA3450140, new ParameterlessText("Constant does not match the defined type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_constantnull = new MessageDescription("mscorlib.Argument_ConstantNull", 0xA3450142, new ParameterlessText("Null is not a valid constant value for this type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_constructorneedgenericdeclaringtype = new MessageDescription("mscorlib.Argument_ConstructorNeedGenericDeclaringType", 0xA3450143, new ParameterlessText("The specified constructor must be declared on a generic type definition.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_conversionoverflow = new MessageDescription("mscorlib.Argument_ConversionOverflow", 0xA3450144, new ParameterlessText("Conversion buffer overflow.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_convertmismatch = new MessageDescription("mscorlib.Argument_ConvertMismatch", 0xA3450145, new ParameterlessText("The conversion could not be completed because the supplied DateTime did not have the Kind property set correctly.  For example, when the Kind property is DateTimeKind.Local, the source time zone must be TimeZoneInfo.Local.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cultureisneutral = new MessageDescription("mscorlib.Argument_CultureIsNeutral", 0xA3450147, new FormatText("Culture ID {0} (0x{0:X4}) is a neutral culture; a region cannot be created from it.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_customculturecannotbepassedbynumber = new MessageDescription("mscorlib.Argument_CustomCultureCannotBePassedByNumber", 0xA3450149, new ParameterlessText("Customized cultures cannot be passed by LCID, only by name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datalengthdifferent = new MessageDescription("mscorlib.Argument_DataLengthDifferent", 0xA345014A, new ParameterlessText("Parameters 'members' and 'data' must have the same length.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimebadbinarydata = new MessageDescription("mscorlib.Argument_DateTimeBadBinaryData", 0xA345014B, new ParameterlessText("The binary data must result in a DateTime with ticks between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimehasticks = new MessageDescription("mscorlib.Argument_DateTimeHasTicks", 0xA345014C, new ParameterlessText("The supplied DateTime must have the Year, Month, and Day properties set to 1.  The time cannot be specified more precisely than whole milliseconds.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimehastimeofday = new MessageDescription("mscorlib.Argument_DateTimeHasTimeOfDay", 0xA345014D, new ParameterlessText("The supplied DateTime includes a TimeOfDay setting.   This is not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimeisinvalid = new MessageDescription("mscorlib.Argument_DateTimeIsInvalid", 0xA345014E, new ParameterlessText("The supplied DateTime represents an invalid time.  For example, when the clock is adjusted forward, any time in the period that is skipped is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimeisnotambiguous = new MessageDescription("mscorlib.Argument_DateTimeIsNotAmbiguous", 0xA345014F, new ParameterlessText("The supplied DateTime is not in an ambiguous time range.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimekindmustbeunspecified = new MessageDescription("mscorlib.Argument_DateTimeKindMustBeUnspecified", 0xA3450150, new ParameterlessText("The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimeoffsetinvaliddatetimestyles = new MessageDescription("mscorlib.Argument_DateTimeOffsetInvalidDateTimeStyles", 0xA3450151, new ParameterlessText("The DateTimeStyles value 'NoCurrentDateDefault' is not allowed when parsing DateTimeOffset.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_datetimeoffsetisnotambiguous = new MessageDescription("mscorlib.Argument_DateTimeOffsetIsNotAmbiguous", 0xA3450152, new ParameterlessText("The supplied DateTimeOffset is not in an ambiguous time range.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_duplicatedfilename = new MessageDescription("mscorlib.Argument_DuplicatedFileName", 0xA3450153, new ParameterlessText("Duplicate file names.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_duplicatename = new MessageDescription("mscorlib.Argument_DuplicateName", 0xA3450155, new ParameterlessText("Tried to add NamedPermissionSet with non-unique name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_duplicateresourcename = new MessageDescription("mscorlib.Argument_DuplicateResourceName", 0xA3450156, new ParameterlessText("Duplicate resource name within an assembly.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_duplicatetypename = new MessageDescription("mscorlib.Argument_DuplicateTypeName", 0xA3450157, new ParameterlessText("Duplicate type name within an assembly.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptyapplicationname = new MessageDescription("mscorlib.Argument_EmptyApplicationName", 0xA3450159, new ParameterlessText("ApplicationId cannot have an empty string for the name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptydecstring = new MessageDescription("mscorlib.Argument_EmptyDecString", 0xA345015A, new ParameterlessText("Decimal separator cannot be the empty string.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptyfilename = new MessageDescription("mscorlib.Argument_EmptyFileName", 0xA345015B, new ParameterlessText("Empty file name is not legal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptypath = new MessageDescription("mscorlib.Argument_EmptyPath", 0xA345015D, new ParameterlessText("Empty path name is not legal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptystrongname = new MessageDescription("mscorlib.Argument_EmptyStrongName", 0xA345015E, new ParameterlessText("StrongName cannot have an empty string for the assembly name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_encoderfallbacknotempty = new MessageDescription("mscorlib.Argument_EncoderFallbackNotEmpty", 0xA3450160, new FormatText("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_encodingconversionoverflowbytes = new MessageDescription("mscorlib.Argument_EncodingConversionOverflowBytes", 0xA3450161, new FormatText("The output byte buffer is too small to contain the encoded data, encoding '{0}' fallback '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_encodingconversionoverflowchars = new MessageDescription("mscorlib.Argument_EncodingConversionOverflowChars", 0xA3450162, new FormatText("The output char buffer is too small to contain the decoded characters, encoding '{0}' fallback '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_enumtypedoesnotmatch = new MessageDescription("mscorlib.Argument_EnumTypeDoesNotMatch", 0xA3450164, new FormatText("The argument type, '{0}', is not the same as the enum type '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_failedcodegroup = new MessageDescription("mscorlib.Argument_FailedCodeGroup", 0xA3450165, new FormatText("Failed to create a code group of type '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fallbackbuffernotempty = new MessageDescription("mscorlib.Argument_FallbackBufferNotEmpty", 0xA3450166, new ParameterlessText("Cannot change fallback when buffer is not empty. Previous Convert() call left data in the fallback buffer.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_frameworknameinvalid = new MessageDescription("mscorlib.Argument_FrameworkNameInvalid", 0xA3450169, new ParameterlessText("FrameworkName is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_frameworknamemissingversion = new MessageDescription("mscorlib.Argument_FrameworkNameMissingVersion", 0xA345016A, new ParameterlessText("FrameworkName version component is missing.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_frameworknametooshort = new MessageDescription("mscorlib.Argument_FrameworkNameTooShort", 0xA345016B, new ParameterlessText("FrameworkName cannot have less than two components or more than three components.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_genconstraintviolation = new MessageDescription("mscorlib.Argument_GenConstraintViolation", 0xA345016C, new FormatText("GenericArguments[{0}], '{1}', on '{2}' violates the constraint of type '{3}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_genericargscount = new MessageDescription("mscorlib.Argument_GenericArgsCount", 0xA345016D, new ParameterlessText("The number of generic arguments provided doesn't equal the arity of the generic type definition.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_genericsinvalid = new MessageDescription("mscorlib.Argument_GenericsInvalid", 0xA345016E, new ParameterlessText("Generic types are not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_globalfunctionhastobestatic = new MessageDescription("mscorlib.Argument_GlobalFunctionHasToBeStatic", 0xA345016F, new ParameterlessText("Global members must be static.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_idnbadbidi = new MessageDescription("mscorlib.Argument_IdnBadBidi", 0xA3450171, new ParameterlessText("Left to right characters may not be mixed with right to left characters in IDN labels.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_idnbadlabelsize = new MessageDescription("mscorlib.Argument_IdnBadLabelSize", 0xA3450172, new ParameterlessText("IDN labels must be between 1 and 63 characters long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_idnbadnamesize = new MessageDescription("mscorlib.Argument_IdnBadNameSize", 0xA3450173, new FormatText("IDN names must be between 1 and {0} characters long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_idnbadpunycode = new MessageDescription("mscorlib.Argument_IdnBadPunycode", 0xA3450174, new ParameterlessText("Invalid IDN encoded string.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_idnbadstd3 = new MessageDescription("mscorlib.Argument_IdnBadStd3", 0xA3450175, new FormatText("Label contains character '{0}' not allowed with UseStd3AsciiRules")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_idnillegalname = new MessageDescription("mscorlib.Argument_IdnIllegalName", 0xA3450176, new ParameterlessText("Decoded string is not a valid IDN name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_illegalappid = new MessageDescription("mscorlib.Argument_IllegalAppId", 0xA3450177, new ParameterlessText("Application identity does not have same number of components as manifest paths.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_illegalappidmismatch = new MessageDescription("mscorlib.Argument_IllegalAppIdMismatch", 0xA3450178, new ParameterlessText("Application identity does not match identities in manifests.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_illegalenvvarname = new MessageDescription("mscorlib.Argument_IllegalEnvVarName", 0xA3450179, new ParameterlessText("Environment variable name cannot contain equal character.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_illegalname = new MessageDescription("mscorlib.Argument_IllegalName", 0xA345017A, new ParameterlessText("Illegal name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_illegalzone = new MessageDescription("mscorlib.Argument_IllegalZone", 0xA345017B, new ParameterlessText("Illegal security permission zone specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_impersonateuser = new MessageDescription("mscorlib.Argument_ImpersonateUser", 0xA345017C, new ParameterlessText("Unable to impersonate user.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_implementicomparable = new MessageDescription("mscorlib.Argument_ImplementIComparable", 0xA345017D, new ParameterlessText("At least one object must implement IComparable.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_impropertype = new MessageDescription("mscorlib.Argument_ImproperType", 0xA345017E, new ParameterlessText("Improper types in collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_insufficientspacetocopycollection = new MessageDescription("mscorlib.Argument_InsufficientSpaceToCopyCollection", 0xA3450180, new ParameterlessText("The specified space is not sufficient to copy the elements from this Collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidanyflag = new MessageDescription("mscorlib.Argument_InvalidAnyFlag", 0xA3450181, new ParameterlessText("No flags can be set.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidappendmode = new MessageDescription("mscorlib.Argument_InvalidAppendMode", 0xA3450182, new ParameterlessText("Append access can be requested only in write-only mode.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidappid = new MessageDescription("mscorlib.Argument_InvalidAppId", 0xA3450183, new ParameterlessText("Invalid identity: no deployment or application identity specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidargumentforcomparison = new MessageDescription("mscorlib.Argument_InvalidArgumentForComparison", 0xA3450184, new ParameterlessText("Type of argument is not compatible with the generic comparer.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidcalendar = new MessageDescription("mscorlib.Argument_InvalidCalendar", 0xA3450187, new ParameterlessText("Not a valid calendar for the given culture.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalidcharsequence = new MessageDescription("mscorlib.Argument_InvalidCharSequence", 0xA3450188, new FormatText("Invalid Unicode code point found at index {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidcharsequencenoindex = new MessageDescription("mscorlib.Argument_InvalidCharSequenceNoIndex", 0xA3450189, new ParameterlessText("String contains invalid Unicode code points.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidconstructordeclaringtype = new MessageDescription("mscorlib.Argument_InvalidConstructorDeclaringType", 0xA345018C, new ParameterlessText("The specified constructor must be declared on the generic type definition of the specified type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidconstructorinfo = new MessageDescription("mscorlib.Argument_InvalidConstructorInfo", 0xA345018D, new ParameterlessText("The ConstructorInfo object is not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidculturename = new MessageDescription("mscorlib.Argument_InvalidCultureName", 0xA345018E, new FormatText("Culture name '{0}' is not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invaliddatetimekind = new MessageDescription("mscorlib.Argument_InvalidDateTimeKind", 0xA345018F, new ParameterlessText("Invalid DateTimeKind value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invaliddatetimestyles = new MessageDescription("mscorlib.Argument_InvalidDateTimeStyles", 0xA3450190, new ParameterlessText("An undefined DateTimeStyles value is being used.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invaliddigitsubstitution = new MessageDescription("mscorlib.Argument_InvalidDigitSubstitution", 0xA3450191, new ParameterlessText("The DigitSubstitution property must be of a valid member of the DigitShapes enumeration. Valid entries include Context, NativeNational or None.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invaliddirectory = new MessageDescription("mscorlib.Argument_InvalidDirectory", 0xA3450192, new FormatText("Invalid directory, '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invaliddirectoryonurl = new MessageDescription("mscorlib.Argument_InvalidDirectoryOnUrl", 0xA3450193, new ParameterlessText("Invalid directory on URL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidelementname = new MessageDescription("mscorlib.Argument_InvalidElementName", 0xA3450194, new FormatText("Invalid element name '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidelementtag = new MessageDescription("mscorlib.Argument_InvalidElementTag", 0xA3450195, new FormatText("Invalid element tag '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidelementtext = new MessageDescription("mscorlib.Argument_InvalidElementText", 0xA3450196, new FormatText("Invalid element text '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidelementvalue = new MessageDescription("mscorlib.Argument_InvalidElementValue", 0xA3450197, new FormatText("Invalid element value '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidenum = new MessageDescription("mscorlib.Argument_InvalidEnum", 0xA3450198, new ParameterlessText("The Enum type should contain one and only one instance field.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidenumvalue = new MessageDescription("mscorlib.Argument_InvalidEnumValue", 0xA3450199, new FormatText("The value '{0}' is not valid for this usage of the type {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfielddeclaringtype = new MessageDescription("mscorlib.Argument_InvalidFieldDeclaringType", 0xA345019A, new ParameterlessText("The specified field must be declared on the generic type definition of the specified type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfieldinfo = new MessageDescription("mscorlib.Argument_InvalidFieldInfo", 0xA345019B, new ParameterlessText("The FieldInfo object is not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfilemodeaccesscombo = new MessageDescription("mscorlib.Argument_InvalidFileMode&AccessCombo", 0xA345019C, new FormatText("Combining FileMode: {0} with FileAccess: {1} is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfilemoderightscombo = new MessageDescription("mscorlib.Argument_InvalidFileMode&RightsCombo", 0xA345019D, new FormatText("Combining FileMode: {0} with FileSystemRights: {1} is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidfilemodetruncaterightscombo = new MessageDescription("mscorlib.Argument_InvalidFileModeTruncate&RightsCombo", 0xA345019E, new FormatText("Combining FileMode: {0} with FileSystemRights: {1} is invalid. FileMode.Truncate is valid only when used with FileSystemRights.Write.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidflag = new MessageDescription("mscorlib.Argument_InvalidFlag", 0xA345019F, new ParameterlessText("Value of flags is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidgroupsize = new MessageDescription("mscorlib.Argument_InvalidGroupSize", 0xA34501A1, new ParameterlessText("Every element in the value array should be between one and nine, except for the last element, which can be zero.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidhandle2 = new MessageDescription("mscorlib.Argument_InvalidHandle", 0xA34501A2, new ParameterlessText("The handle is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidhexformat = new MessageDescription("mscorlib.Argument_InvalidHexFormat", 0xA34501A3, new ParameterlessText("Improperly formatted hex string.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidhighsurrogate = new MessageDescription("mscorlib.Argument_InvalidHighSurrogate", 0xA34501A4, new FormatText("Found a high surrogate char without a following low surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidid = new MessageDescription("mscorlib.Argument_InvalidId", 0xA34501A5, new FormatText("The specified ID parameter '{0}' is not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidimpersonationtoken = new MessageDescription("mscorlib.Argument_InvalidImpersonationToken", 0xA34501A6, new ParameterlessText("Invalid token for impersonation - it cannot be duplicated.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidkey = new MessageDescription("mscorlib.Argument_InvalidKey", 0xA34501A7, new ParameterlessText("Key was invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidkeystore = new MessageDescription("mscorlib.Argument_InvalidKeyStore", 0xA34501A8, new FormatText("'{0}' is not a valid KeyStore name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidkindoftypeforca = new MessageDescription("mscorlib.Argument_InvalidKindOfTypeForCA", 0xA34501A9, new ParameterlessText("This type cannot be represented as a custom attribute.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidlowsurrogate = new MessageDescription("mscorlib.Argument_InvalidLowSurrogate", 0xA34501AB, new FormatText("Found a low surrogate char without a preceding high surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidmarshalbyrefobject = new MessageDescription("mscorlib.Argument_InvalidMarshalByRefObject", 0xA34501AC, new ParameterlessText("The MarshalByRefObject is not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidmemberfornamedargument = new MessageDescription("mscorlib.Argument_InvalidMemberForNamedArgument", 0xA34501AD, new ParameterlessText("The member must be either a field or a property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidmethoddeclaringtype = new MessageDescription("mscorlib.Argument_InvalidMethodDeclaringType", 0xA34501AE, new ParameterlessText("The specified method must be declared on the generic type definition of the specified type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidname = new MessageDescription("mscorlib.Argument_InvalidName", 0xA34501AF, new ParameterlessText("Invalid name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidnativedigitcount = new MessageDescription("mscorlib.Argument_InvalidNativeDigitCount", 0xA34501B0, new ParameterlessText("The NativeDigits array must contain exactly ten members.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidnativedigitvalue = new MessageDescription("mscorlib.Argument_InvalidNativeDigitValue", 0xA34501B1, new ParameterlessText("Each member of the NativeDigits array must be a single text element (one or more UTF16 code points) with a Unicode Nd (Number, Decimal Digit) property indicating it is a digit.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidneutralregionname = new MessageDescription("mscorlib.Argument_InvalidNeutralRegionName", 0xA34501B2, new FormatText("The region name {0} should not correspond to neutral culture; a specific culture name is required.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidnormalizationform = new MessageDescription("mscorlib.Argument_InvalidNormalizationForm", 0xA34501B3, new ParameterlessText("Invalid or unsupported normalization form.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidnumberstyles = new MessageDescription("mscorlib.Argument_InvalidNumberStyles", 0xA34501B4, new ParameterlessText("An undefined NumberStyles value is being used.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidofflen = new MessageDescription("mscorlib.Argument_InvalidOffLen", 0xA34501B5, new ParameterlessText("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidopcodeondynamicmethod = new MessageDescription("mscorlib.Argument_InvalidOpCodeOnDynamicMethod", 0xA34501B6, new ParameterlessText("Ldtoken, Ldftn and Ldvirtftn OpCodes cannot target DynamicMethods.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidparameterinfo = new MessageDescription("mscorlib.Argument_InvalidParameterInfo", 0xA34501B7, new ParameterlessText("The ParameterInfo object is not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidparaminfo = new MessageDescription("mscorlib.Argument_InvalidParamInfo", 0xA34501B8, new ParameterlessText("Invalid type for ParameterInfo member in Attribute class.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidpathchars = new MessageDescription("mscorlib.Argument_InvalidPathChars", 0xA34501B9, new ParameterlessText("Illegal characters in path.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidpermissionstate = new MessageDescription("mscorlib.Argument_InvalidPermissionState", 0xA34501BA, new ParameterlessText("Invalid permission state.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidregtziformat = new MessageDescription("mscorlib.Argument_InvalidREG_TZI_FORMAT", 0xA34501BC, new ParameterlessText("The REG_TZI_FORMAT structure is corrupt.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidregistrykeypermissioncheck = new MessageDescription("mscorlib.Argument_InvalidRegistryKeyPermissionCheck", 0xA34501BD, new ParameterlessText("The specified RegistryKeyPermissionCheck value is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidregistryoptionscheck = new MessageDescription("mscorlib.Argument_InvalidRegistryOptionsCheck", 0xA34501BE, new ParameterlessText("The specified RegistryOptions value is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidregistryviewcheck = new MessageDescription("mscorlib.Argument_InvalidRegistryViewCheck", 0xA34501BF, new ParameterlessText("The specified RegistryView value is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidresourceculturename = new MessageDescription("mscorlib.Argument_InvalidResourceCultureName", 0xA34501C0, new FormatText("The given culture name '{0}' cannot be used to locate a resource file. Resource filenames must consist of only letters, numbers, hyphens or underscores.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsafebufferofflen = new MessageDescription("mscorlib.Argument_InvalidSafeBufferOffLen", 0xA34501C1, new ParameterlessText("Offset and length were greater than the size of the SafeBuffer.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsafehandle = new MessageDescription("mscorlib.Argument_InvalidSafeHandle", 0xA34501C2, new ParameterlessText("The SafeHandle is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidseekorigin = new MessageDescription("mscorlib.Argument_InvalidSeekOrigin", 0xA34501C3, new ParameterlessText("Invalid seek origin.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsite = new MessageDescription("mscorlib.Argument_InvalidSite", 0xA34501C5, new ParameterlessText("Invalid site.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsubpath = new MessageDescription("mscorlib.Argument_InvalidSubPath", 0xA34501C6, new FormatText("The directory specified, '{0}', is not a subdirectory of '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtimespanstyles = new MessageDescription("mscorlib.Argument_InvalidTimeSpanStyles", 0xA34501C7, new ParameterlessText("An undefined TimeSpanStyles value is being used.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtoken = new MessageDescription("mscorlib.Argument_InvalidToken", 0xA34501C8, new FormatText("Token {0:x} is not valid in the scope of module {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtype = new MessageDescription("mscorlib.Argument_InvalidType", 0xA34501C9, new ParameterlessText("The type of arguments passed into generic comparer methods is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtypeforca = new MessageDescription("mscorlib.Argument_InvalidTypeForCA", 0xA34501CA, new FormatText("Cannot build type parameter for custom attribute with a type that does not support the AssemblyQualifiedName property. The type instance supplied was of type '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtypefordynamicmethod = new MessageDescription("mscorlib.Argument_InvalidTypeForDynamicMethod", 0xA34501CB, new ParameterlessText("Invalid type owner for DynamicMethod.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtypename = new MessageDescription("mscorlib.Argument_InvalidTypeName", 0xA34501CC, new ParameterlessText("The name of the type is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidtypetoken = new MessageDescription("mscorlib.Argument_InvalidTypeToken", 0xA34501CD, new FormatText("Token {0:x} is not a valid Type token.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidunity = new MessageDescription("mscorlib.Argument_InvalidUnity", 0xA34501CE, new ParameterlessText("Invalid Unity type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidurl = new MessageDescription("mscorlib.Argument_InvalidUrl", 0xA34501CF, new ParameterlessText("Invalid URL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidvalue = new MessageDescription("mscorlib.Argument_InvalidValue", 0xA34501D0, new ParameterlessText("Value was invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidxml = new MessageDescription("mscorlib.Argument_InvalidXML", 0xA34501D1, new ParameterlessText("Invalid Xml.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidxmlbadversion = new MessageDescription("mscorlib.Argument_InvalidXMLBadVersion", 0xA34501D2, new ParameterlessText("Invalid Xml - can only parse elements of version one.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidxmlelement = new MessageDescription("mscorlib.Argument_InvalidXMLElement", 0xA34501D3, new FormatText("Invalid XML. Missing required tag <{0}> for type '{1}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidxmlmissingattr = new MessageDescription("mscorlib.Argument_InvalidXMLMissingAttr", 0xA34501D4, new FormatText("Invalid XML. Missing required attribute '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_itemnotexist = new MessageDescription("mscorlib.Argument_ItemNotExist", 0xA34501D5, new ParameterlessText("The specified item does not exist in this KeyedCollection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_largeinteger = new MessageDescription("mscorlib.Argument_LargeInteger", 0xA34501D6, new ParameterlessText("Integer or token was too large to be encoded.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_longenvvarname = new MessageDescription("mscorlib.Argument_LongEnvVarName", 0xA34501D7, new ParameterlessText("Environment variable name cannot contain 1024 or more characters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_longenvvarvalue = new MessageDescription("mscorlib.Argument_LongEnvVarValue", 0xA34501D8, new ParameterlessText("Environment variable name or value is too long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_minmaxvalue = new MessageDescription("mscorlib.Argument_MinMaxValue", 0xA34501DF, new FormatText("'{0}' cannot be greater than {1}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_mustbefalse = new MessageDescription("mscorlib.Argument_MustBeFalse", 0xA34501E2, new ParameterlessText("Argument must be initialized to false")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeinterfacemethod = new MessageDescription("mscorlib.Argument_MustBeInterfaceMethod", 0xA34501E3, new ParameterlessText("The MemberInfo must be an interface method.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustberuntimefieldinfo = new MessageDescription("mscorlib.Argument_MustBeRuntimeFieldInfo", 0xA34501E5, new ParameterlessText("FieldInfo must be a runtime FieldInfo object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustberuntimemethodinfo = new MessageDescription("mscorlib.Argument_MustBeRuntimeMethodInfo", 0xA34501E6, new ParameterlessText("MethodInfo must be a runtime MethodInfo object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustberuntimereflectionobject = new MessageDescription("mscorlib.Argument_MustBeRuntimeReflectionObject", 0xA34501E8, new ParameterlessText("The object must be a runtime Reflection object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_mustbetypebuilder = new MessageDescription("mscorlib.Argument_MustBeTypeBuilder", 0xA34501EA, new ParameterlessText("'type' must contain a TypeBuilder as a generic argument.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_musthaveattributebaseclass = new MessageDescription("mscorlib.Argument_MustHaveAttributeBaseClass", 0xA34501EB, new ParameterlessText("Type passed in must be derived from System.Attribute or System.Attribute itself.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustsupplycontainer = new MessageDescription("mscorlib.Argument_MustSupplyContainer", 0xA34501EC, new ParameterlessText("When supplying a FieldInfo for fixing up a nested type, a valid ID for that containing object must also be supplied.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustsupplyparent = new MessageDescription("mscorlib.Argument_MustSupplyParent", 0xA34501ED, new ParameterlessText("When supplying the ID of a containing object, the FieldInfo that identifies the current field within that object must also be supplied.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nativeresourcealreadydefined = new MessageDescription("mscorlib.Argument_NativeResourceAlreadyDefined", 0xA34501EE, new ParameterlessText("Native resource has already been defined.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_needgenericmethoddefinition = new MessageDescription("mscorlib.Argument_NeedGenericMethodDefinition", 0xA34501EF, new ParameterlessText("Method must represent a generic method definition on a generic type definition.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_neednongenerictype = new MessageDescription("mscorlib.Argument_NeedNonGenericType", 0xA34501F0, new ParameterlessText("The specified Type must not be a generic type definition.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nevervalidgenericargument = new MessageDescription("mscorlib.Argument_NeverValidGenericArgument", 0xA34501F1, new FormatText("The type '{0}' may not be used as a type argument.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_noclass = new MessageDescription("mscorlib.Argument_NoClass", 0xA34501F2, new ParameterlessText("Element does not specify a class.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nodomainmanager = new MessageDescription("mscorlib.Argument_NoDomainManager", 0xA34501F3, new ParameterlessText("The domain manager specified by the host could not be instantiated.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeLoadException)));
        Add(_noera = new MessageDescription("mscorlib.Argument_NoEra", 0xA34501F4, new ParameterlessText("No Era was supplied.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nomain = new MessageDescription("mscorlib.Argument_NoMain", 0xA34501F5, new ParameterlessText("Main entry point not defined.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nonestedmarshal = new MessageDescription("mscorlib.Argument_NoNestedMarshal", 0xA34501F7, new ParameterlessText("Only LPArray or SafeArray has nested unmanaged marshal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nonnullobjandctx = new MessageDescription("mscorlib.Argument_NonNullObjAndCtx", 0xA34501F8, new ParameterlessText("Either obj or ctx must be null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nonpms = new MessageDescription("mscorlib.Argument_NoNPMS", 0xA34501F9, new ParameterlessText("Unable to find a permission set with the provided name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_noregioninvariantculture = new MessageDescription("mscorlib.Argument_NoRegionInvariantCulture", 0xA34501FA, new ParameterlessText("There is no region associated with the Invariant Culture (Culture ID: 0x7F).")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notacodegrouptype = new MessageDescription("mscorlib.Argument_NotACodeGroupType", 0xA34501FB, new ParameterlessText("The type does not inherit from CodeGroup")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notacustommarshaler = new MessageDescription("mscorlib.Argument_NotACustomMarshaler", 0xA34501FC, new ParameterlessText("Not a custom marshal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notamembershipcondition = new MessageDescription("mscorlib.Argument_NotAMembershipCondition", 0xA34501FD, new ParameterlessText("The type does not implement IMembershipCondition")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notapermissionelement = new MessageDescription("mscorlib.Argument_NotAPermissionElement", 0xA34501FE, new ParameterlessText("'elem' was not a permission element.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notapermissiontype = new MessageDescription("mscorlib.Argument_NotAPermissionType", 0xA34501FF, new ParameterlessText("The type does not implement IPermission")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notasimplenativetype = new MessageDescription("mscorlib.Argument_NotASimpleNativeType", 0xA3450200, new ParameterlessText("The UnmanagedType passed to DefineUnmanagedMarshal is not a simple type. None of the following values may be used: UnmanagedType.ByValTStr, UnmanagedType.SafeArray, UnmanagedType.ByValArray, UnmanagedType.LPArray, UnmanagedType.CustomMarshaler.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notawritableproperty = new MessageDescription("mscorlib.Argument_NotAWritableProperty", 0xA3450201, new ParameterlessText("Not a writable property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notenoughbytestoread = new MessageDescription("mscorlib.Argument_NotEnoughBytesToRead", 0xA3450202, new ParameterlessText("There are not enough bytes remaining in the accessor to read at this position.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notenoughbytestowrite = new MessageDescription("mscorlib.Argument_NotEnoughBytesToWrite", 0xA3450203, new ParameterlessText("There are not enough bytes remaining in the accessor to write at this position.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notenoughgenarguments = new MessageDescription("mscorlib.Argument_NotEnoughGenArguments", 0xA3450204, new FormatText("The type or method has {1} generic parameter(s), but {0} generic argument(s) were provided. A generic argument must be provided for each generic parameter.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notsimplefilename = new MessageDescription("mscorlib.Argument_NotSimpleFileName", 0xA345020A, new ParameterlessText("The filename must not include a path specification.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nounmanagedelementcount = new MessageDescription("mscorlib.Argument_NoUnmanagedElementCount", 0xA345020B, new ParameterlessText("Unmanaged marshal does not have ElementCount.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_npmsinuse = new MessageDescription("mscorlib.Argument_NPMSInUse", 0xA345020C, new FormatText("Permission set '{0}' was in use and could not be deleted.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_npmsinvalidname = new MessageDescription("mscorlib.Argument_NPMSInvalidName", 0xA345020D, new ParameterlessText("Name can be neither null nor empty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nullfulltrustassembly = new MessageDescription("mscorlib.Argument_NullFullTrustAssembly", 0xA345020E, new ParameterlessText("A null StrongName was found in the full trust assembly list.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_objiswinrtobject = new MessageDescription("mscorlib.Argument_ObjIsWinRTObject", 0xA345020F, new ParameterlessText("The object's type must not be a Windows Runtime type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_objnotcomobject = new MessageDescription("mscorlib.Argument_ObjNotComObject", 0xA3450210, new ParameterlessText("The object's type must be __ComObject or derived from __ComObject.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_offsetandcapacityoutofbounds = new MessageDescription("mscorlib.Argument_OffsetAndCapacityOutOfBounds", 0xA3450211, new ParameterlessText("Offset and capacity were greater than the size of the view.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_offsetandlengthoutofbounds = new MessageDescription("mscorlib.Argument_OffsetAndLengthOutOfBounds", 0xA3450212, new ParameterlessText("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_offsetlocalmismatch = new MessageDescription("mscorlib.Argument_OffsetLocalMismatch", 0xA3450213, new ParameterlessText("The UTC Offset of the local dateTime parameter does not match the offset argument.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_offsetoffieldnotfound = new MessageDescription("mscorlib.Argument_OffsetOfFieldNotFound", 0xA3450214, new FormatText("Field passed in is not a marshaled member of the type '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_offsetoutofrange = new MessageDescription("mscorlib.Argument_OffsetOutOfRange", 0xA3450215, new ParameterlessText("Offset must be within plus or minus 14 hours.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_offsetprecision = new MessageDescription("mscorlib.Argument_OffsetPrecision", 0xA3450216, new ParameterlessText("Offset must be specified in whole minutes.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_offsetutcmismatch = new MessageDescription("mscorlib.Argument_OffsetUtcMismatch", 0xA3450217, new ParameterlessText("The UTC Offset for Utc DateTime instances must be 0.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_onlymscorlib = new MessageDescription("mscorlib.Argument_OnlyMscorlib", 0xA3450219, new ParameterlessText("Only mscorlib's assembly is valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_outoforderdatetimes = new MessageDescription("mscorlib.Argument_OutOfOrderDateTimes", 0xA345021A, new ParameterlessText("The DateStart property must come before the DateEnd property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_pathempty = new MessageDescription("mscorlib.Argument_PathEmpty", 0xA345021B, new ParameterlessText("Path cannot be the empty string or all whitespace.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_policyfiledoesnotexist = new MessageDescription("mscorlib.Argument_PolicyFileDoesNotExist", 0xA345021E, new ParameterlessText("The requested policy file does not exist.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_recursivefallback = new MessageDescription("mscorlib.Argument_RecursiveFallback", 0xA345021F, new FormatText("Recursive fallback not allowed for character \\u{0:X4}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_recursivefallbackbytes = new MessageDescription("mscorlib.Argument_RecursiveFallbackBytes", 0xA3450220, new FormatText("Recursive fallback not allowed for bytes {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_relativeurlmembershipcondition = new MessageDescription("mscorlib.Argument_RelativeUrlMembershipCondition", 0xA3450222, new ParameterlessText("UrlMembershipCondition requires an absolute URL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_reservednpms = new MessageDescription("mscorlib.Argument_ReservedNPMS", 0xA3450223, new FormatText("Cannot remove or modify reserved permissions set '{0}'.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvefield = new MessageDescription("mscorlib.Argument_ResolveField", 0xA3450224, new FormatText("Token {0:x} is not a valid FieldInfo token in the scope of module {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvefieldhandle = new MessageDescription("mscorlib.Argument_ResolveFieldHandle", 0xA3450225, new FormatText("Type handle '{0}' and field handle with declaring type '{1}' are incompatible. Get RuntimeFieldHandle and declaring RuntimeTypeHandle off the same FieldInfo.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvemember = new MessageDescription("mscorlib.Argument_ResolveMember", 0xA3450226, new FormatText("Token {0:x} is not a valid MemberInfo token in the scope of module {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvemethod = new MessageDescription("mscorlib.Argument_ResolveMethod", 0xA3450227, new FormatText("Token {0:x} is not a valid MethodBase token in the scope of module {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvemethodhandle = new MessageDescription("mscorlib.Argument_ResolveMethodHandle", 0xA3450228, new FormatText("Type handle '{0}' and method handle with declaring type '{1}' are incompatible. Get RuntimeMethodHandle and declaring RuntimeTypeHandle off the same MethodBase.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvestring = new MessageDescription("mscorlib.Argument_ResolveString", 0xA345022A, new FormatText("Token {0:x} is not a valid string token in the scope of module {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resolvetype = new MessageDescription("mscorlib.Argument_ResolveType", 0xA345022B, new FormatText("Token {0:x} is not a valid Type token in the scope of module {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resourcescopewrongdirection = new MessageDescription("mscorlib.Argument_ResourceScopeWrongDirection", 0xA345022C, new FormatText("Resource type in the ResourceScope enum is going from a more restrictive resource type to a more general one.  From: \"{0}\"  To: \"{1}\"")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resultcalendarrange = new MessageDescription("mscorlib.Argument_ResultCalendarRange", 0xA345022D, new FormatText("The result is out of the supported range for this calendar. The result should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_shouldonlysetvisibilityflags = new MessageDescription("mscorlib.Argument_ShouldOnlySetVisibilityFlags", 0xA345022F, new ParameterlessText("Should only set visibility flags when creating EnumBuilder.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_sigisfinalized = new MessageDescription("mscorlib.Argument_SigIsFinalized", 0xA3450230, new ParameterlessText("Completed signature cannot be modified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_sitecannotbenull = new MessageDescription("mscorlib.Argument_SiteCannotBeNull", 0xA3450231, new ParameterlessText("Site name must be specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_streamnotreadable = new MessageDescription("mscorlib.Argument_StreamNotReadable", 0xA3450232, new ParameterlessText("Stream was not readable.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_streamnotwritable = new MessageDescription("mscorlib.Argument_StreamNotWritable", 0xA3450233, new ParameterlessText("Stream was not writable.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_stringfirstchariszero = new MessageDescription("mscorlib.Argument_StringFirstCharIsZero", 0xA3450234, new ParameterlessText("The first char in the string is the null character.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_stringzerolength = new MessageDescription("mscorlib.Argument_StringZeroLength", 0xA3450235, new ParameterlessText("String cannot be of zero length.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_strongnamegetpublickey = new MessageDescription("mscorlib.Argument_StrongNameGetPublicKey", 0xA3450236, new ParameterlessText("Unable to obtain public key for StrongNameKeyPair.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_timespanhasseconds = new MessageDescription("mscorlib.Argument_TimeSpanHasSeconds", 0xA3450237, new ParameterlessText("The TimeSpan parameter cannot be specified more precisely than whole minutes.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_toexclusivelessthanfromexclusive = new MessageDescription("mscorlib.Argument_ToExclusiveLessThanFromExclusive", 0xA3450238, new ParameterlessText("fromInclusive must be less than or equal to toExclusive.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_tokenzero = new MessageDescription("mscorlib.Argument_TokenZero", 0xA3450239, new ParameterlessText("Token cannot be zero.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_transitiontimesareidentical = new MessageDescription("mscorlib.Argument_TransitionTimesAreIdentical", 0xA345023B, new ParameterlessText("The DaylightTransitionStart property must not equal the DaylightTransitionEnd property.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_unabletogeneratepermissionset = new MessageDescription("mscorlib.Argument_UnableToGeneratePermissionSet", 0xA3450245, new ParameterlessText("Unable to generate permission set; input XML may be malformed.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_unexpectedtypesource = new MessageDescription("mscorlib.Argument_Unexpected_TypeSource", 0xA3450247, new ParameterlessText("Unexpected TypeKind when marshaling Windows.Foundation.TypeName.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.StubHelpers").SetException(typeof(System.ArgumentException)));
        Add(_uninitializedcertificate = new MessageDescription("mscorlib.Argument_UninitializedCertificate", 0xA3450248, new ParameterlessText("Uninitialized certificate object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_unknownunmanagedcallconv = new MessageDescription("mscorlib.Argument_UnknownUnmanagedCallConv", 0xA3450249, new ParameterlessText("Unknown unmanaged calling convention for function signature.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_unmanagedmemaccessorwraparound = new MessageDescription("mscorlib.Argument_UnmanagedMemAccessorWrapAround", 0xA345024A, new ParameterlessText("The UnmanagedMemoryAccessor capacity and offset would wrap around the high end of the address space.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_unrecognizedloaderoptimization = new MessageDescription("mscorlib.Argument_UnrecognizedLoaderOptimization", 0xA345024D, new ParameterlessText("Unrecognized LOADER_OPTIMIZATION property value.  Supported values may include \"SingleDomain\", \"MultiDomain\", \"MultiDomainHost\", and \"NotSpecified\".")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_urlcannotbenull = new MessageDescription("mscorlib.Argument_UrlCannotBeNull", 0xA345024E, new ParameterlessText("URL must be specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_utcoutofrange = new MessageDescription("mscorlib.Argument_UTCOutOfRange", 0xA345024F, new ParameterlessText("The UTC time represented when the offset is applied must be between year 0 and 10,000.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_waithandlenametoolong = new MessageDescription("mscorlib.Argument_WaitHandleNameTooLong", 0xA3450250, new ParameterlessText("The name can be no more than 260 characters in length.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_winrtsystemruntimetype = new MessageDescription("mscorlib.Argument_WinRTSystemRuntimeType", 0xA3450251, new FormatText("Cannot marshal type '{0}' to Windows Runtime. Only 'System.RuntimeType' is supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.StubHelpers").SetException(typeof(System.ArgumentException)));
        Add(_wrongelementtype = new MessageDescription("mscorlib.Argument_WrongElementType", 0xA3450252, new FormatText("'{0}' element required.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_wrongtype2 = new MessageDescription("mscorlib.Argument_WrongType", 0xA3450253, new FormatText("Operation on type '{0}' attempted with target of incorrect type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_zonecannotbenull = new MessageDescription("mscorlib.Argument_ZoneCannotBeNull", 0xA3450254, new ParameterlessText("Zone must be specified.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptionbadmethodimplbody = new MessageDescription("mscorlib.ArgumentException_BadMethodImplBody", 0xA3450255, new ParameterlessText("MethodOverride's body must be from this type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptioninvalidacebinaryform = new MessageDescription("mscorlib.ArgumentException_InvalidAceBinaryForm", 0xA3450256, new ParameterlessText("The binary form of an ACE object is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptioninvalidaclbinaryform = new MessageDescription("mscorlib.ArgumentException_InvalidAclBinaryForm", 0xA3450257, new ParameterlessText("The binary form of an ACL object is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptioninvalidsdsddlform = new MessageDescription("mscorlib.ArgumentException_InvalidSDSddlForm", 0xA3450258, new ParameterlessText("The SDDL form of a security descriptor object is invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptionminsortingversion = new MessageDescription("mscorlib.ArgumentException_MinSortingVersion", 0xA3450259, new FormatText("The runtime does not support a version of \"{0}\" less than {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptionnotallcustomsortingfuncsdefined = new MessageDescription("mscorlib.ArgumentException_NotAllCustomSortingFuncsDefined", 0xA345025A, new ParameterlessText("Implementations of all the NLS functions must be provided.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptiontupleincorrecttype = new MessageDescription("mscorlib.ArgumentException_TupleIncorrectType", 0xA345025C, new FormatText("Argument must be of type {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_exceptiontuplelastargumentnotatuple = new MessageDescription("mscorlib.ArgumentException_TupleLastArgumentNotATuple", 0xA345025D, new ParameterlessText("The last element of an eight element Tuple must be a Tuple.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_gactostring = new MessageDescription("mscorlib.GAC_ToString", 0xA3450365, new ParameterlessText("GAC")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_resourcesstreamnotvalid = new MessageDescription("mscorlib.Resources_StreamNotValid", 0xA3450558, new ParameterlessText("Stream is not a valid resource file.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_strongnamename = new MessageDescription("mscorlib.StrongName_Name", 0xA34505D0, new FormatText("name = {0}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_strongnametostring = new MessageDescription("mscorlib.StrongName_ToString", 0xA34505D1, new FormatText("StrongName - {0}{1}{2}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_strongnameversion = new MessageDescription("mscorlib.StrongName_Version", 0xA34505D2, new FormatText("version = {0}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_urltostring = new MessageDescription("mscorlib.Url_ToString", 0xA345060A, new ParameterlessText("Url")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_urltostringarg = new MessageDescription("mscorlib.Url_ToStringArg", 0xA345060B, new FormatText("Url - {0}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannothavenegativevalue = new MessageDescription("mscorlib.Arg_CannotHaveNegativeValue", 0xA3450641, new ParameterlessText("String cannot contain a minus sign if the base is not 10.")).SetSeverity(MessageLevel.Error));
        Add(_corruptedcustomculturefile = new MessageDescription("mscorlib.Arg_CorruptedCustomCultureFile", 0xA3450642, new FormatText("The file of the custom culture {0} is corrupt. Try to unregister this culture.")).SetSeverity(MessageLevel.Error));
        Add(_enummusthaveunderlyingvaluefield = new MessageDescription("mscorlib.Arg_EnumMustHaveUnderlyingValueField", 0xA3450648, new ParameterlessText("All enums must have an underlying value__ field.")).SetSeverity(MessageLevel.Error));
        Add(_importerloadfailure = new MessageDescription("mscorlib.Arg_ImporterLoadFailure", 0xA3450657, new ParameterlessText("The type library importer encountered an error during type verification. Try importing without class members.")).SetSeverity(MessageLevel.Error));
        Add(_invalidansistring = new MessageDescription("mscorlib.Arg_InvalidANSIString", 0xA345065A, new ParameterlessText("The ANSI string passed in could not be converted from the default ANSI code page to Unicode.")).SetSeverity(MessageLevel.Error));
        Add(_invalidutf8string = new MessageDescription("mscorlib.Arg_InvalidUTF8String", 0xA345065B, new ParameterlessText("The UTF8 string passed in could not be converted to Unicode.")).SetSeverity(MessageLevel.Error));
        Add(_mustallberuntimetype = new MessageDescription("mscorlib.Arg_MustAllBeRuntimeType", 0xA3450650, new ParameterlessText("At least one type argument is not a runtime type.")).SetSeverity(MessageLevel.Error));
        Add(_mustbeinterface = new MessageDescription("mscorlib.Arg_MustBeInterface", 0xA345064F, new ParameterlessText("Type passed must be an interface.")).SetSeverity(MessageLevel.Error));
        Add(_noitypeinfo = new MessageDescription("mscorlib.Arg_NoITypeInfo", 0xA3450654, new ParameterlessText("Specified TypeInfo was invalid because it did not support the ITypeInfo interface.")).SetSeverity(MessageLevel.Error));
        Add(_noimportercallback = new MessageDescription("mscorlib.Arg_NoImporterCallback", 0xA3450656, new ParameterlessText("Specified type library importer callback was invalid because it did not support the ITypeLibImporterNotifySink interface.")).SetSeverity(MessageLevel.Error));
        Add(_notfoundiface = new MessageDescription("mscorlib.Arg_NotFoundIFace", 0xA3450651, new ParameterlessText("Interface not found.")).SetSeverity(MessageLevel.Error));
        Add(_nullindex = new MessageDescription("mscorlib.Arg_NullIndex", 0xA3450653, new ParameterlessText("Arrays indexes must be set to an object instance.")).SetSeverity(MessageLevel.Error));
        Add(_parameterinfonullmember = new MessageDescription("mscorlib.Arg_ParameterInfoNullMember", 0xA345064A, new ParameterlessText("The MemberInfo object defining the parameter cannot be null.")).SetSeverity(MessageLevel.Error));
        Add(_primwiden = new MessageDescription("mscorlib.Arg_PrimWiden", 0xA3450652, new ParameterlessText("Cannot widen from source type to target type either because the source type is a not a primitive type or the conversion cannot be accomplished.")).SetSeverity(MessageLevel.Error));
        Add(_rwlockrestoreexception = new MessageDescription("mscorlib.Arg_RWLockRestoreException", 0xA3450643, new ParameterlessText("ReaderWriterLock.RestoreLock was called without releasing all locks acquired since the call to ReleaseLock.")).SetSeverity(MessageLevel.Error));
        Add(_exceptiontuplenonicomparableelement = new MessageDescription("mscorlib.ArgumentException_TupleNonIComparableElement", 0xA3450791, new FormatText("The tuple contains an element of type {0} which does not implement the IComparable interface.")).SetSeverity(MessageLevel.Error));
        Add(_exceptionvaluetupleincorrecttype = new MessageDescription("mscorlib.ArgumentException_ValueTupleIncorrectType", 0xA3450C63, new FormatText("Argument must be of type {0}.")).SetSeverity(MessageLevel.Error));
        Add(_exceptionvaluetuplelastargumentnotavaluetuple = new MessageDescription("mscorlib.ArgumentException_ValueTupleLastArgumentNotAValueTuple", 0xA3450C64, new ParameterlessText("The last element of an eight element ValueTuple must be a ValueTuple.")).SetSeverity(MessageLevel.Error));
        Add(_alsinvalidcapacity = new MessageDescription("mscorlib.Argument_ALSInvalidCapacity", 0xA3450659, new ParameterlessText("Specified capacity must not be less than the current capacity.")).SetSeverity(MessageLevel.Error));
        Add(_adjustmentrulesambiguousoverlap = new MessageDescription("mscorlib.Argument_AdjustmentRulesAmbiguousOverlap", 0xA345078B, new ParameterlessText("The elements of the AdjustmentRule array must not contain ambiguous time periods that extend beyond the DateStart or DateEnd properties of the element.")).SetSeverity(MessageLevel.Error));
        Add(_adjustmentrulesinvalidoverlap = new MessageDescription("mscorlib.Argument_AdjustmentRulesInvalidOverlap", 0xA345078E, new ParameterlessText("The elements of the AdjustmentRule array must not contain invalid time periods that extend beyond the DateStart or DateEnd properties of the element.")).SetSeverity(MessageLevel.Error));
        Add(_adjustmentrulesrdaylightsavingtimeoverlap = new MessageDescription("mscorlib.Argument_AdjustmentRulesrDaylightSavingTimeOverlap", 0xA345078C, new ParameterlessText("The elements of the AdjustmentRule array must not contain Daylight Saving Time periods that overlap adjacent elements in such a way as to cause invalid or ambiguous time periods.")).SetSeverity(MessageLevel.Error));
        Add(_adjustmentrulesrdaylightsavingtimeoverlapnonrulerange = new MessageDescription("mscorlib.Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange", 0xA345078D, new ParameterlessText("The elements of the AdjustmentRule array must not contain Daylight Saving Time periods that overlap the DateStart or DateEnd properties in such a way as to cause invalid or ambiguous time periods.")).SetSeverity(MessageLevel.Error));
        Add(_alreadyaccw = new MessageDescription("mscorlib.Argument_AlreadyACCW", 0xA345067C, new ParameterlessText("The object already has a CCW associated with it.")).SetSeverity(MessageLevel.Error));
        Add(_alreadyboundorsynchandle = new MessageDescription("mscorlib.Argument_AlreadyBoundOrSyncHandle", 0xA3450C68, new ParameterlessText("'handle' has already been bound to the thread pool, or was not opened for asynchronous I/O.")).SetSeverity(MessageLevel.Error));
        Add(_assemblywinmd = new MessageDescription("mscorlib.Argument_AssemblyWinMD", 0xA3450664, new ParameterlessText("Assembly must not be a Windows Runtime assembly.")).SetSeverity(MessageLevel.Error));
        Add(_badconstantvalue = new MessageDescription("mscorlib.Argument_BadConstantValue", 0xA345066E, new ParameterlessText("Bad default value.")).SetSeverity(MessageLevel.Error));
        Add(_badcurrentlocalvariable = new MessageDescription("mscorlib.Argument_BadCurrentLocalVariable", 0xA3450669, new ParameterlessText("Bad current local variable for setting symbol information.")).SetSeverity(MessageLevel.Error));
        Add(_badformatspecifier = new MessageDescription("mscorlib.Argument_BadFormatSpecifier", 0xA3450660, new ParameterlessText("Format specifier was invalid.")).SetSeverity(MessageLevel.Error));
        Add(_badtypeattrabstractnfinal = new MessageDescription("mscorlib.Argument_BadTypeAttrAbstractNFinal", 0xA345066C, new ParameterlessText("Bad type attributes. A type cannot be both abstract and final.")).SetSeverity(MessageLevel.Error));
        Add(_cordbbadmethod = new MessageDescription("mscorlib.Argument_CORDBBadMethod", 0xA3450671, new ParameterlessText("Cannot find the method on the object instance.")).SetSeverity(MessageLevel.Error));
        Add(_cordbbadvarargcallconv = new MessageDescription("mscorlib.Argument_CORDBBadVarArgCallConv", 0xA3450670, new ParameterlessText("Cannot evaluate a VarArgs function.")).SetSeverity(MessageLevel.Error));
        Add(_cannotprepareabstract = new MessageDescription("mscorlib.Argument_CannotPrepareAbstract", 0xA3450668, new ParameterlessText("Abstract methods cannot be prepared.")).SetSeverity(MessageLevel.Error));
        Add(_cantcallsecobjfunc = new MessageDescription("mscorlib.Argument_CantCallSecObjFunc", 0xA3450665, new ParameterlessText("Cannot evaluate a security function.")).SetSeverity(MessageLevel.Error));
        Add(_cultureinvalidformat = new MessageDescription("mscorlib.Argument_CultureInvalidFormat", 0xA345063B, new FormatText("Culture '{0}' is a neutral culture. It cannot be used in formatting and parsing and therefore cannot be set as the thread's current culture.")).SetSeverity(MessageLevel.Error));
        Add(_cultureinvalididentifier = new MessageDescription("mscorlib.Argument_CultureInvalidIdentifier", 0xA345063A, new FormatText("{0} is an invalid culture identifier.")).SetSeverity(MessageLevel.Error));
        Add(_customassemblyloadcontextrequestednamemismatch = new MessageDescription("mscorlib.Argument_CustomAssemblyLoadContextRequestedNameMismatch", 0xA3450781, new ParameterlessText("Resolved assembly's simple name should be the same as of the requested assembly.")).SetSeverity(MessageLevel.Error));
        Add(_emptyvalue = new MessageDescription("mscorlib.Argument_EmptyValue", 0xA3450C6A, new ParameterlessText("Value cannot be empty.")).SetSeverity(MessageLevel.Error));
        Add(_enumisnotintorshort = new MessageDescription("mscorlib.Argument_EnumIsNotIntOrShort", 0xA345063F, new ParameterlessText("The underlying type of enum argument must be Int32 or Int16.")).SetSeverity(MessageLevel.Error));
        Add(_handleleak = new MessageDescription("mscorlib.Argument_HandleLeak", 0xA345067A, new ParameterlessText("Cannot pass a GCHandle across AppDomains.")).SetSeverity(MessageLevel.Error));
        Add(_illegalappbase = new MessageDescription("mscorlib.Argument_IllegalAppBase", 0xA345063C, new ParameterlessText("The application base specified is not valid.")).SetSeverity(MessageLevel.Error));
        Add(_interfacemap = new MessageDescription("mscorlib.Argument_InterfaceMap", 0xA3450663, new ParameterlessText("'this' type cannot be an interface itself.")).SetSeverity(MessageLevel.Error));
        Add(_invalidassemblyname = new MessageDescription("mscorlib.Argument_InvalidAssemblyName", 0xA345066A, new ParameterlessText("Assembly names may not begin with whitespace or contain the characters '/', or '\\' or ':'.")).SetSeverity(MessageLevel.Error));
        Add(_invalidgenericarg = new MessageDescription("mscorlib.Argument_InvalidGenericArg", 0xA345063E, new ParameterlessText("The generic type parameter was not valid")).SetSeverity(MessageLevel.Error));
        Add(_invalidgenericinstantiation = new MessageDescription("mscorlib.Argument_InvalidGenericInstantiation", 0xA345066B, new ParameterlessText("The given generic instantiation was invalid.")).SetSeverity(MessageLevel.Error));
        Add(_invalidnumberofmembers = new MessageDescription("mscorlib.Argument_InvalidNumberOfMembers", 0xA345065D, new ParameterlessText("MemberData contains an invalid number of members.")).SetSeverity(MessageLevel.Error));
        Add(_invalidregionname = new MessageDescription("mscorlib.Argument_InvalidRegionName", 0xA3450646, new FormatText("Region name '{0}' is not supported.")).SetSeverity(MessageLevel.Error));
        Add(_mustberuntimeparameterinfo = new MessageDescription("mscorlib.Argument_MustBeRuntimeParameterInfo", 0xA3450679, new ParameterlessText("ParameterInfo must be a runtime ParameterInfo object.")).SetSeverity(MessageLevel.Error));
        Add(_mustbestring2 = new MessageDescription("mscorlib.Argument_MustBeString", 0xA3450677, new ParameterlessText("String is too long or has invalid contents.")).SetSeverity(MessageLevel.Error));
        Add(_musthavelayoutorbeblittable = new MessageDescription("mscorlib.Argument_MustHaveLayoutOrBeBlittable", 0xA3450675, new ParameterlessText("The specified structure must be blittable or have layout information.")).SetSeverity(MessageLevel.Error));
        Add(_namecontainsinvalidcharacters = new MessageDescription("mscorlib.Argument_NameContainsInvalidCharacters", 0xA3450645, new FormatText("The name '{0}' contains characters that are not valid for a Culture or Region.")).SetSeverity(MessageLevel.Error));
        Add(_nametoolong = new MessageDescription("mscorlib.Argument_NameTooLong", 0xA3450644, new FormatText("The name '{0}' is too long to be a Culture or Region name, which is limited to {1} characters.")).SetSeverity(MessageLevel.Error));
        Add(_nativeoverlappedalreadyfree = new MessageDescription("mscorlib.Argument_NativeOverlappedAlreadyFree", 0xA3450C67, new ParameterlessText("'overlapped' has already been freed.")).SetSeverity(MessageLevel.Error));
        Add(_nativeoverlappedwrongboundhandle = new MessageDescription("mscorlib.Argument_NativeOverlappedWrongBoundHandle", 0xA3450C69, new ParameterlessText("'overlapped' was not allocated by this ThreadPoolBoundHandle instance.")).SetSeverity(MessageLevel.Error));
        Add(_neednongenericobject = new MessageDescription("mscorlib.Argument_NeedNonGenericObject", 0xA3450672, new ParameterlessText("The specified object must not be an instance of a generic type.")).SetSeverity(MessageLevel.Error));
        Add(_needstructwithnorefs = new MessageDescription("mscorlib.Argument_NeedStructWithNoRefs", 0xA3450673, new ParameterlessText("The specified Type must be a struct containing no references.")).SetSeverity(MessageLevel.Error));
        Add(_nospecificculture = new MessageDescription("mscorlib.Argument_NoSpecificCulture", 0xA3450667, new ParameterlessText("Please select a specific culture, such as zh-CN, zh-HK, zh-TW, zh-MO, zh-SG.")).SetSeverity(MessageLevel.Error));
        Add(_nounderlyingccw = new MessageDescription("mscorlib.Argument_NoUnderlyingCCW", 0xA3450662, new ParameterlessText("The object has no underlying COM data associated with it.")).SetSeverity(MessageLevel.Error));
        Add(_nouninitializedstrings = new MessageDescription("mscorlib.Argument_NoUninitializedStrings", 0xA345065E, new ParameterlessText("Uninitialized Strings cannot be created.")).SetSeverity(MessageLevel.Error));
        Add(_notatp = new MessageDescription("mscorlib.Argument_NotATP", 0xA345067B, new ParameterlessText("Type must be a TransparentProxy")).SetSeverity(MessageLevel.Error));
        Add(_preallocatedalreadyallocated = new MessageDescription("mscorlib.Argument_PreAllocatedAlreadyAllocated", 0xA3450C65, new ParameterlessText("'preAllocated' is already in use.")).SetSeverity(MessageLevel.Error));
        Add(_resultislamiccalendarrange = new MessageDescription("mscorlib.Argument_ResultIslamicCalendarRange", 0xA3450640, new ParameterlessText("The date is out of the supported range for the Islamic calendar. The date should be greater than July 18th, 622 AD (Gregorian date).")).SetSeverity(MessageLevel.Error));
        Add(_seekoverflow = new MessageDescription("mscorlib.Argument_SeekOverflow", 0xA345065C, new FormatText("The specified seek offset '{0}' would result in a negative Stream position.")).SetSeverity(MessageLevel.Error));
        Add(_structmustnotbevalueclass = new MessageDescription("mscorlib.Argument_StructMustNotBeValueClass", 0xA3450666, new ParameterlessText("The structure must not be a value class.")).SetSeverity(MessageLevel.Error));
        Add(_unequalmembers = new MessageDescription("mscorlib.Argument_UnequalMembers", 0xA345065F, new ParameterlessText("Supplied MemberInfo does not match the expected type.")).SetSeverity(MessageLevel.Error));
        Add(_unrestrictedidentitypermission = new MessageDescription("mscorlib.Argument_UnrestrictedIdentityPermission", 0xA3450661, new ParameterlessText("Identity permissions cannot be unrestricted.")).SetSeverity(MessageLevel.Error));
        Add(_verstringtoolong = new MessageDescription("mscorlib.Argument_VerStringTooLong", 0xA345066D, new ParameterlessText("The unmanaged Version information is too large to persist.")).SetSeverity(MessageLevel.Error));
        Add(_cvtresnotfound = new MessageDescription("mscorlib.Argument_cvtres_NotFound", 0xA345066F, new ParameterlessText("Cannot find cvtres.exe")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
