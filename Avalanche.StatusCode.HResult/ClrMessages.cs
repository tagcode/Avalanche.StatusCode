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

/// <summary>.NET CLR (Common Language Runtime)</summary>
public class ClrMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ClrMessages> instance = new Lazy<ClrMessages>(() => new ClrMessages().Initialize().SetAllReadOnly<ClrMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ClrMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0042;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _cor_e_abandonedmutex, _cor_e_ambiguousimplementation, _cor_e_appdomainunloaded, _cor_e_application, _cor_e_argumentoutofrange, _cor_e_arraytypemismatch, _cor_e_cannotunloadappdomain, _cor_e_codecontractfailed, _cor_e_contextmarshal, _cor_e_customattributeformat;
    IMessageDescription? _cor_e_datamisaligned, _cor_e_dllnotfound, _cor_e_duplicatewaitobject, _cor_e_entrypointnotfound, _cor_e_exception, _cor_e_executionengine, _cor_e_fieldaccess, _cor_e_fileload, _cor_e_format, _cor_e_indexoutofrange;
    IMessageDescription? _cor_e_insufficientexecutionstack, _cor_e_insufficientmemory, _cor_e_invalidcomobject, _cor_e_invalidfiltercriteria, _cor_e_invalidolevarianttype, _cor_e_invalidoperation, _cor_e_invalidprogram, _cor_e_io, _cor_e_keynotfound, _cor_e_marshaldirective;
    IMessageDescription? _cor_e_memberaccess, _cor_e_methodaccess, _cor_e_missingfield, _cor_e_missingmanifestresource, _cor_e_missingmember, _cor_e_missingmethod, _cor_e_missingsatelliteassembly, _cor_e_multicastnotsupported, _cor_e_notfinitenumber, _cor_e_notsupported;
    IMessageDescription? _cor_e_objectdisposed, _cor_e_operationcanceled, _cor_e_overflow, _cor_e_platformnotsupported, _cor_e_rank, _cor_e_reflectiontypeload, _cor_e_runtimewrapped, _cor_e_safearrayrankmismatch, _cor_e_safearraytypemismatch, _cor_e_security;
    IMessageDescription? _cor_e_serialization, _cor_e_synchronizationlock, _cor_e_system, _cor_e_target, _cor_e_targetinvocation, _cor_e_threadaborted, _cor_e_threadinterrupted, _cor_e_threadstart, _cor_e_threadstate, _cor_e_timeout;
    IMessageDescription? _cor_e_typeaccess, _cor_e_typeinitialization, _cor_e_typeload, _cor_e_typeunloaded, _cor_e_verification, _cor_e_waithandlecannotbeopened;
    
    /// <summary>The wait completed due to an abandoned mutex</summary>
    public IMessageDescription COR_E_ABANDONEDMUTEX { get => _cor_e_abandonedmutex!; set => this.AssertWritable()._cor_e_abandonedmutex = value; }
    /// <summary>There are multiple incompatible interface methods overriding another method.</summary>
    public IMessageDescription COR_E_AMBIGUOUSIMPLEMENTATION { get => _cor_e_ambiguousimplementation!; set => this.AssertWritable()._cor_e_ambiguousimplementation = value; }
    /// <summary>Attempted to access an unloaded appdomain.</summary>
    public IMessageDescription COR_E_APPDOMAINUNLOADED { get => _cor_e_appdomainunloaded!; set => this.AssertWritable()._cor_e_appdomainunloaded = value; }
    /// <summary>Application exception</summary>
    public IMessageDescription COR_E_APPLICATION { get => _cor_e_application!; set => this.AssertWritable()._cor_e_application = value; }
    /// <summary>An argument was out of its legal range.</summary>
    public IMessageDescription COR_E_ARGUMENTOUTOFRANGE { get => _cor_e_argumentoutofrange!; set => this.AssertWritable()._cor_e_argumentoutofrange = value; }
    /// <summary>Attempted to store an object of the wrong type in an array.</summary>
    public IMessageDescription COR_E_ARRAYTYPEMISMATCH { get => _cor_e_arraytypemismatch!; set => this.AssertWritable()._cor_e_arraytypemismatch = value; }
    /// <summary>Error while unloading appdomain.</summary>
    public IMessageDescription COR_E_CANNOTUNLOADAPPDOMAIN { get => _cor_e_cannotunloadappdomain!; set => this.AssertWritable()._cor_e_cannotunloadappdomain = value; }
    /// <summary>URT.COR_E_CODECONTRACTFAILED</summary>
    public IMessageDescription COR_E_CODECONTRACTFAILED { get => _cor_e_codecontractfailed!; set => this.AssertWritable()._cor_e_codecontractfailed = value; }
    /// <summary>Attempted to marshal an object across a context boundary.</summary>
    public IMessageDescription COR_E_CONTEXTMARSHAL { get => _cor_e_contextmarshal!; set => this.AssertWritable()._cor_e_contextmarshal = value; }
    /// <summary>Custom attribute has invalid format.</summary>
    public IMessageDescription COR_E_CUSTOMATTRIBUTEFORMAT { get => _cor_e_customattributeformat!; set => this.AssertWritable()._cor_e_customattributeformat = value; }
    /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
    public IMessageDescription COR_E_DATAMISALIGNED { get => _cor_e_datamisaligned!; set => this.AssertWritable()._cor_e_datamisaligned = value; }
    /// <summary>Could not find the specified DllImport Dll.</summary>
    public IMessageDescription COR_E_DLLNOTFOUND { get => _cor_e_dllnotfound!; set => this.AssertWritable()._cor_e_dllnotfound = value; }
    /// <summary>An object appears more than once in the wait objects array.</summary>
    public IMessageDescription COR_E_DUPLICATEWAITOBJECT { get => _cor_e_duplicatewaitobject!; set => this.AssertWritable()._cor_e_duplicatewaitobject = value; }
    /// <summary>Could not find the specified DllImport entrypoint.</summary>
    public IMessageDescription COR_E_ENTRYPOINTNOTFOUND { get => _cor_e_entrypointnotfound!; set => this.AssertWritable()._cor_e_entrypointnotfound = value; }
    /// <summary>General Exception</summary>
    public IMessageDescription COR_E_EXCEPTION { get => _cor_e_exception!; set => this.AssertWritable()._cor_e_exception = value; }
    /// <summary>Internal CLR error.</summary>
    public IMessageDescription COR_E_EXECUTIONENGINE { get => _cor_e_executionengine!; set => this.AssertWritable()._cor_e_executionengine = value; }
    /// <summary>Access to this field is denied.</summary>
    public IMessageDescription COR_E_FIELDACCESS { get => _cor_e_fieldaccess!; set => this.AssertWritable()._cor_e_fieldaccess = value; }
    /// <summary>Could not find or load a specific file.</summary>
    public IMessageDescription COR_E_FILELOAD { get => _cor_e_fileload!; set => this.AssertWritable()._cor_e_fileload = value; }
    /// <summary>One of the identified items was in an invalid format.</summary>
    public IMessageDescription COR_E_FORMAT { get => _cor_e_format!; set => this.AssertWritable()._cor_e_format = value; }
    /// <summary>Array subscript out of range.</summary>
    public IMessageDescription COR_E_INDEXOUTOFRANGE { get => _cor_e_indexoutofrange!; set => this.AssertWritable()._cor_e_indexoutofrange = value; }
    /// <summary>Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.</summary>
    public IMessageDescription COR_E_INSUFFICIENTEXECUTIONSTACK { get => _cor_e_insufficientexecutionstack!; set => this.AssertWritable()._cor_e_insufficientexecutionstack = value; }
    /// <summary>Not enough memory was available for an operation.</summary>
    public IMessageDescription COR_E_INSUFFICIENTMEMORY { get => _cor_e_insufficientmemory!; set => this.AssertWritable()._cor_e_insufficientmemory = value; }
    /// <summary>An invalid __ComObject has been used.</summary>
    public IMessageDescription COR_E_INVALIDCOMOBJECT { get => _cor_e_invalidcomobject!; set => this.AssertWritable()._cor_e_invalidcomobject = value; }
    /// <summary>The given filter criteria does not match the filter content.</summary>
    public IMessageDescription COR_E_INVALIDFILTERCRITERIA { get => _cor_e_invalidfiltercriteria!; set => this.AssertWritable()._cor_e_invalidfiltercriteria = value; }
    /// <summary>OLE Variant has an invalid type.</summary>
    public IMessageDescription COR_E_INVALIDOLEVARIANTTYPE { get => _cor_e_invalidolevarianttype!; set => this.AssertWritable()._cor_e_invalidolevarianttype = value; }
    /// <summary>An operation is not legal in the current state.</summary>
    public IMessageDescription COR_E_INVALIDOPERATION { get => _cor_e_invalidoperation!; set => this.AssertWritable()._cor_e_invalidoperation = value; }
    /// <summary>Invalid IL or CLR metadata. A program contained invalid IL or bad metadata. Usually this is a compiler bug.</summary>
    public IMessageDescription COR_E_INVALIDPROGRAM { get => _cor_e_invalidprogram!; set => this.AssertWritable()._cor_e_invalidprogram = value; }
    /// <summary>Error during managed I/O.</summary>
    public IMessageDescription COR_E_IO { get => _cor_e_io!; set => this.AssertWritable()._cor_e_io = value; }
    /// <summary>The given key was not present in the dictionary.</summary>
    public IMessageDescription COR_E_KEYNOTFOUND { get => _cor_e_keynotfound!; set => this.AssertWritable()._cor_e_keynotfound = value; }
    /// <summary>Invalid marshaling directives.</summary>
    public IMessageDescription COR_E_MARSHALDIRECTIVE { get => _cor_e_marshaldirective!; set => this.AssertWritable()._cor_e_marshaldirective = value; }
    /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
    public IMessageDescription COR_E_MEMBERACCESS { get => _cor_e_memberaccess!; set => this.AssertWritable()._cor_e_memberaccess = value; }
    /// <summary>Access to this method is denied.</summary>
    public IMessageDescription COR_E_METHODACCESS { get => _cor_e_methodaccess!; set => this.AssertWritable()._cor_e_methodaccess = value; }
    /// <summary>Field does not exist.</summary>
    public IMessageDescription COR_E_MISSINGFIELD { get => _cor_e_missingfield!; set => this.AssertWritable()._cor_e_missingfield = value; }
    /// <summary>An expected resource in the assembly manifest was missing.</summary>
    public IMessageDescription COR_E_MISSINGMANIFESTRESOURCE { get => _cor_e_missingmanifestresource!; set => this.AssertWritable()._cor_e_missingmanifestresource = value; }
    /// <summary>Member does not exist.</summary>
    public IMessageDescription COR_E_MISSINGMEMBER { get => _cor_e_missingmember!; set => this.AssertWritable()._cor_e_missingmember = value; }
    /// <summary>Method does not exist.</summary>
    public IMessageDescription COR_E_MISSINGMETHOD { get => _cor_e_missingmethod!; set => this.AssertWritable()._cor_e_missingmethod = value; }
    /// <summary>An expected satellite assembly containing the ultimate fallback resources for a given culture was not found or could not be loaded.</summary>
    public IMessageDescription COR_E_MISSINGSATELLITEASSEMBLY { get => _cor_e_missingsatelliteassembly!; set => this.AssertWritable()._cor_e_missingsatelliteassembly = value; }
    /// <summary>Attempt to combine delegates that are not multicast.</summary>
    public IMessageDescription COR_E_MULTICASTNOTSUPPORTED { get => _cor_e_multicastnotsupported!; set => this.AssertWritable()._cor_e_multicastnotsupported = value; }
    /// <summary>Not a Number.</summary>
    public IMessageDescription COR_E_NOTFINITENUMBER { get => _cor_e_notfinitenumber!; set => this.AssertWritable()._cor_e_notfinitenumber = value; }
    /// <summary>Operation is not supported.</summary>
    public IMessageDescription COR_E_NOTSUPPORTED { get => _cor_e_notsupported!; set => this.AssertWritable()._cor_e_notsupported = value; }
    /// <summary>The object has already been disposed.</summary>
    public IMessageDescription COR_E_OBJECTDISPOSED { get => _cor_e_objectdisposed!; set => this.AssertWritable()._cor_e_objectdisposed = value; }
    /// <summary>The operation was cancelle</summary>
    public IMessageDescription COR_E_OPERATIONCANCELED { get => _cor_e_operationcanceled!; set => this.AssertWritable()._cor_e_operationcanceled = value; }
    /// <summary>Arithmetic, casting or conversion operation overflowed or underflowed.</summary>
    public IMessageDescription COR_E_OVERFLOW { get => _cor_e_overflow!; set => this.AssertWritable()._cor_e_overflow = value; }
    /// <summary>Operation is not supported on this platform.</summary>
    public IMessageDescription COR_E_PLATFORMNOTSUPPORTED { get => _cor_e_platformnotsupported!; set => this.AssertWritable()._cor_e_platformnotsupported = value; }
    /// <summary>An array has the wrong number of dimensions for a particular operation.</summary>
    public IMessageDescription COR_E_RANK { get => _cor_e_rank!; set => this.AssertWritable()._cor_e_rank = value; }
    /// <summary>Could not find or load a specific class that was requested through Reflection.</summary>
    public IMessageDescription COR_E_REFLECTIONTYPELOAD { get => _cor_e_reflectiontypeload!; set => this.AssertWritable()._cor_e_reflectiontypeload = value; }
    /// <summary>An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.</summary>
    public IMessageDescription COR_E_RUNTIMEWRAPPED { get => _cor_e_runtimewrapped!; set => this.AssertWritable()._cor_e_runtimewrapped = value; }
    /// <summary>A mismatch has occurred between the runtime rank of the array and the rank recorded in the metadata.</summary>
    public IMessageDescription COR_E_SAFEARRAYRANKMISMATCH { get => _cor_e_safearrayrankmismatch!; set => this.AssertWritable()._cor_e_safearrayrankmismatch = value; }
    /// <summary>A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.</summary>
    public IMessageDescription COR_E_SAFEARRAYTYPEMISMATCH { get => _cor_e_safearraytypemismatch!; set => this.AssertWritable()._cor_e_safearraytypemismatch = value; }
    /// <summary>OLE Variant has an invalid type.</summary>
    public IMessageDescription COR_E_SECURITY { get => _cor_e_security!; set => this.AssertWritable()._cor_e_security = value; }
    /// <summary>A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.</summary>
    public IMessageDescription COR_E_SERIALIZATION { get => _cor_e_serialization!; set => this.AssertWritable()._cor_e_serialization = value; }
    /// <summary>This operation must be called from a synchronized block.</summary>
    public IMessageDescription COR_E_SYNCHRONIZATIONLOCK { get => _cor_e_synchronizationlock!; set => this.AssertWritable()._cor_e_synchronizationlock = value; }
    /// <summary>System error.</summary>
    public IMessageDescription COR_E_SYSTEM { get => _cor_e_system!; set => this.AssertWritable()._cor_e_system = value; }
    /// <summary>Attempt to invoke non-static method with a null Object.</summary>
    public IMessageDescription COR_E_TARGET { get => _cor_e_target!; set => this.AssertWritable()._cor_e_target = value; }
    /// <summary>Uncaught exception thrown by method called through Reflection.</summary>
    public IMessageDescription COR_E_TARGETINVOCATION { get => _cor_e_targetinvocation!; set => this.AssertWritable()._cor_e_targetinvocation = value; }
    /// <summary>Thread has aborted.</summary>
    public IMessageDescription COR_E_THREADABORTED { get => _cor_e_threadaborted!; set => this.AssertWritable()._cor_e_threadaborted = value; }
    /// <summary>Thread was interrupted from a waiting state.</summary>
    public IMessageDescription COR_E_THREADINTERRUPTED { get => _cor_e_threadinterrupted!; set => this.AssertWritable()._cor_e_threadinterrupted = value; }
    /// <summary>Indicate that a user thread fails to start</summary>
    public IMessageDescription COR_E_THREADSTART { get => _cor_e_threadstart!; set => this.AssertWritable()._cor_e_threadstart = value; }
    /// <summary>Thread is in an invalid state for this operation.</summary>
    public IMessageDescription COR_E_THREADSTATE { get => _cor_e_threadstate!; set => this.AssertWritable()._cor_e_threadstate = value; }
    /// <summary>Operation timed out.</summary>
    public IMessageDescription COR_E_TIMEOUT { get => _cor_e_timeout!; set => this.AssertWritable()._cor_e_timeout = value; }
    /// <summary>Access to this type is denied.</summary>
    public IMessageDescription COR_E_TYPEACCESS { get => _cor_e_typeaccess!; set => this.AssertWritable()._cor_e_typeaccess = value; }
    /// <summary>Uncaught exception during type initialization.</summary>
    public IMessageDescription COR_E_TYPEINITIALIZATION { get => _cor_e_typeinitialization!; set => this.AssertWritable()._cor_e_typeinitialization = value; }
    /// <summary>Could not find or load a type.</summary>
    public IMessageDescription COR_E_TYPELOAD { get => _cor_e_typeload!; set => this.AssertWritable()._cor_e_typeload = value; }
    /// <summary>Type has been unloaded.</summary>
    public IMessageDescription COR_E_TYPEUNLOADED { get => _cor_e_typeunloaded!; set => this.AssertWritable()._cor_e_typeunloaded = value; }
    /// <summary>Uncaught exception during type initialization.</summary>
    public IMessageDescription COR_E_VERIFICATION { get => _cor_e_verification!; set => this.AssertWritable()._cor_e_verification = value; }
    /// <summary>No Semaphore of the given name exists</summary>
    public IMessageDescription COR_E_WAITHANDLECANNOTBEOPENED { get => _cor_e_waithandlecannotbeopened!; set => this.AssertWritable()._cor_e_waithandlecannotbeopened = value; }

    /// <summary>Initialize fields</summary>
    public override ClrMessages Initialize() 
    {
        base.Initialize();
        Add(_cor_e_abandonedmutex = new MessageDescription("URT.COR_E_ABANDONEDMUTEX", 0x8013152D, new ParameterlessText("The wait completed due to an abandoned mutex")).SetHResult(0x8013152D).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.AbandonedMutexException)));
        Add(_cor_e_ambiguousimplementation = new MessageDescription("URT.COR_E_AMBIGUOUSIMPLEMENTATION", 0x8013106A, new ParameterlessText("There are multiple incompatible interface methods overriding another method.")).SetHResult(0x8013106A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.AmbiguousImplementationException)));
        Add(_cor_e_appdomainunloaded = new MessageDescription("URT.COR_E_APPDOMAINUNLOADED", 0x80131014, new ParameterlessText("Attempted to access an unloaded appdomain.")).SetHResult(0x80131014).SetSeverity(MessageLevel.Error).SetException(typeof(System.AppDomainUnloadedException)));
        Add(_cor_e_application = new MessageDescription("URT.COR_E_APPLICATION", 0x80131600, new ParameterlessText("Application exception")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetException(typeof(System.ApplicationException)));
        Add(_cor_e_argumentoutofrange = new MessageDescription("URT.COR_E_ARGUMENTOUTOFRANGE", 0x80131502, new ParameterlessText("An argument was out of its legal range.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_cor_e_arraytypemismatch = new MessageDescription("URT.COR_E_ARRAYTYPEMISMATCH", 0x80131503, new ParameterlessText("Attempted to store an object of the wrong type in an array.")).SetHResult(0x80131503).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArrayTypeMismatchException)));
        Add(_cor_e_cannotunloadappdomain = new MessageDescription("URT.COR_E_CANNOTUNLOADAPPDOMAIN", 0x80131015, new ParameterlessText("Error while unloading appdomain.")).SetHResult(0x80131015).SetSeverity(MessageLevel.Error).SetException(typeof(System.CannotUnloadAppDomainException)));
        Add(_cor_e_codecontractfailed = new MessageDescription("URT.COR_E_CODECONTRACTFAILED", 0x80131542, new ParameterlessText("")).SetHResult(0x80131542).SetSeverity(MessageLevel.Error));
        Add(_cor_e_contextmarshal = new MessageDescription("URT.COR_E_CONTEXTMARSHAL", 0x80131504, new ParameterlessText("Attempted to marshal an object across a context boundary.")).SetHResult(0x80131504).SetSeverity(MessageLevel.Error).SetException(typeof(System.ContextMarshalException)));
        Add(_cor_e_customattributeformat = new MessageDescription("URT.COR_E_CUSTOMATTRIBUTEFORMAT", 0x80131605, new ParameterlessText("Custom attribute has invalid format.")).SetHResult(0x80131605).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.CustomAttributeFormatException)));
        Add(_cor_e_datamisaligned = new MessageDescription("URT.COR_E_DATAMISALIGNED", 0x80131541, new ParameterlessText("A datatype misalignment was detected in a load or store instruction.")).SetHResult(0x80131541).SetSeverity(MessageLevel.Error).SetException(typeof(System.DataMisalignedException)));
        Add(_cor_e_dllnotfound = new MessageDescription("URT.COR_E_DLLNOTFOUND", 0x80131524, new ParameterlessText("Could not find the specified DllImport Dll.")).SetHResult(0x80131524).SetSeverity(MessageLevel.Error).SetException(typeof(System.DllNotFoundException)));
        Add(_cor_e_duplicatewaitobject = new MessageDescription("URT.COR_E_DUPLICATEWAITOBJECT", 0x80131529, new ParameterlessText("An object appears more than once in the wait objects array.")).SetHResult(0x80131529).SetSeverity(MessageLevel.Error).SetException(typeof(System.DuplicateWaitObjectException)));
        Add(_cor_e_entrypointnotfound = new MessageDescription("URT.COR_E_ENTRYPOINTNOTFOUND", 0x80131523, new ParameterlessText("Could not find the specified DllImport entrypoint.")).SetHResult(0x80131523).SetSeverity(MessageLevel.Error).SetException(typeof(System.EntryPointNotFoundException)));
        Add(_cor_e_exception = new MessageDescription("URT.COR_E_EXCEPTION", 0x80131500, new ParameterlessText("General Exception")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.Exception)));
        Add(_cor_e_executionengine = new MessageDescription("URT.COR_E_EXECUTIONENGINE", 0x80131506, new ParameterlessText("Internal CLR error.")).SetHResult(0x80131506).SetSeverity(MessageLevel.Critical).SetException("System.ExecutionEngineException"));
        Add(_cor_e_fieldaccess = new MessageDescription("URT.COR_E_FIELDACCESS", 0x80131507, new ParameterlessText("Access to this field is denied.")).SetHResult(0x80131507).SetSeverity(MessageLevel.Error).SetException(typeof(System.FieldAccessException)));
        Add(_cor_e_fileload = new MessageDescription("URT.COR_E_FILELOAD", 0x80131621, new ParameterlessText("Could not find or load a specific file.")).SetHResult(0x80131621).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_cor_e_format = new MessageDescription("URT.COR_E_FORMAT", 0x80131537, new ParameterlessText("One of the identified items was in an invalid format.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_cor_e_indexoutofrange = new MessageDescription("URT.COR_E_INDEXOUTOFRANGE", 0x80131508, new ParameterlessText("Array subscript out of range.")).SetHResult(0x80131508).SetSeverity(MessageLevel.Error).SetException(typeof(System.IndexOutOfRangeException)));
        Add(_cor_e_insufficientexecutionstack = new MessageDescription("URT.COR_E_INSUFFICIENTEXECUTIONSTACK", 0x80131578, new ParameterlessText("Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.")).SetHResult(0x80131578).SetSeverity(MessageLevel.Error).SetException(typeof(System.InsufficientExecutionStackException)));
        Add(_cor_e_insufficientmemory = new MessageDescription("URT.COR_E_INSUFFICIENTMEMORY", 0x8013153D, new ParameterlessText("Not enough memory was available for an operation.")).SetHResult(0x8013153D).SetSeverity(MessageLevel.Error).SetException(typeof(System.InsufficientMemoryException)));
        Add(_cor_e_invalidcomobject = new MessageDescription("URT.COR_E_INVALIDCOMOBJECT", 0x80131527, new ParameterlessText("An invalid __ComObject has been used.")).SetHResult(0x80131527).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.InteropServices.InvalidComObjectException)));
        Add(_cor_e_invalidfiltercriteria = new MessageDescription("URT.COR_E_INVALIDFILTERCRITERIA", 0x80131601, new ParameterlessText("The given filter criteria does not match the filter content.")).SetHResult(0x80131601).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.InvalidFilterCriteriaException)));
        Add(_cor_e_invalidolevarianttype = new MessageDescription("URT.COR_E_INVALIDOLEVARIANTTYPE", 0x80131531, new ParameterlessText("OLE Variant has an invalid type.")).SetHResult(0x80131531).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.InteropServices.InvalidOleVariantTypeException)));
        Add(_cor_e_invalidoperation = new MessageDescription("URT.COR_E_INVALIDOPERATION", 0x80131509, new ParameterlessText("An operation is not legal in the current state.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cor_e_invalidprogram = new MessageDescription("URT.COR_E_INVALIDPROGRAM", 0x8013153A, new ParameterlessText("Invalid IL or CLR metadata. A program contained invalid IL or bad metadata. Usually this is a compiler bug.")).SetHResult(0x8013153A).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidProgramException)));
        Add(_cor_e_io = new MessageDescription("URT.COR_E_IO", 0x80131620, new ParameterlessText("Error during managed I/O.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_cor_e_keynotfound = new MessageDescription("URT.COR_E_KEYNOTFOUND", 0x80131577, new ParameterlessText("The given key was not present in the dictionary.")).SetHResult(0x80131577).SetSeverity(MessageLevel.Error).SetException(typeof(System.Collections.Generic.KeyNotFoundException)));
        Add(_cor_e_marshaldirective = new MessageDescription("URT.COR_E_MARSHALDIRECTIVE", 0x80131535, new ParameterlessText("Invalid marshaling directives.")).SetHResult(0x80131535).SetSeverity(MessageLevel.Error));
        Add(_cor_e_memberaccess = new MessageDescription("URT.COR_E_MEMBERACCESS", 0x8013151A, new ParameterlessText("A datatype misalignment was detected in a load or store instruction.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Error).SetException(typeof(System.MemberAccessException)));
        Add(_cor_e_methodaccess = new MessageDescription("URT.COR_E_METHODACCESS", 0x80131510, new ParameterlessText("Access to this method is denied.")).SetHResult(0x80131510).SetSeverity(MessageLevel.Error).SetException(typeof(System.MethodAccessException)));
        Add(_cor_e_missingfield = new MessageDescription("URT.COR_E_MISSINGFIELD", 0x80131511, new ParameterlessText("Field does not exist.")).SetHResult(0x80131511).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingFieldException)));
        Add(_cor_e_missingmanifestresource = new MessageDescription("URT.COR_E_MISSINGMANIFESTRESOURCE", 0x80131532, new ParameterlessText("An expected resource in the assembly manifest was missing.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_cor_e_missingmember = new MessageDescription("URT.COR_E_MISSINGMEMBER", 0x80131512, new ParameterlessText("Member does not exist.")).SetHResult(0x80131512).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingMemberException)));
        Add(_cor_e_missingmethod = new MessageDescription("URT.COR_E_MISSINGMETHOD", 0x80131513, new ParameterlessText("Method does not exist.")).SetHResult(0x80131513).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingMethodException)));
        Add(_cor_e_missingsatelliteassembly = new MessageDescription("URT.COR_E_MISSINGSATELLITEASSEMBLY", 0x80131536, new ParameterlessText("An expected satellite assembly containing the ultimate fallback resources for a given culture was not found or could not be loaded.")).SetHResult(0x80131536).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingSatelliteAssemblyException)));
        Add(_cor_e_multicastnotsupported = new MessageDescription("URT.COR_E_MULTICASTNOTSUPPORTED", 0x80131514, new ParameterlessText("Attempt to combine delegates that are not multicast.")).SetHResult(0x80131514).SetSeverity(MessageLevel.Error).SetException(typeof(System.MulticastNotSupportedException)));
        Add(_cor_e_notfinitenumber = new MessageDescription("URT.COR_E_NOTFINITENUMBER", 0x80131528, new ParameterlessText("Not a Number.")).SetHResult(0x80131528).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotFiniteNumberException)));
        Add(_cor_e_notsupported = new MessageDescription("URT.COR_E_NOTSUPPORTED", 0x80131515, new ParameterlessText("Operation is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_cor_e_objectdisposed = new MessageDescription("URT.COR_E_OBJECTDISPOSED", 0x80131622, new ParameterlessText("The object has already been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_cor_e_operationcanceled = new MessageDescription("URT.COR_E_OPERATIONCANCELED", 0x8013153B, new ParameterlessText("The operation was cancelle")).SetHResult(0x8013153B).SetSeverity(MessageLevel.Error).SetException(typeof(System.OperationCanceledException)));
        Add(_cor_e_overflow = new MessageDescription("URT.COR_E_OVERFLOW", 0x80131516, new ParameterlessText("Arithmetic, casting or conversion operation overflowed or underflowed.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_cor_e_platformnotsupported = new MessageDescription("URT.COR_E_PLATFORMNOTSUPPORTED", 0x80131539, new ParameterlessText("Operation is not supported on this platform.")).SetHResult(0x80131539).SetSeverity(MessageLevel.Error).SetException(typeof(System.PlatformNotSupportedException)));
        Add(_cor_e_rank = new MessageDescription("URT.COR_E_RANK", 0x80131517, new ParameterlessText("An array has the wrong number of dimensions for a particular operation.")).SetHResult(0x80131517).SetSeverity(MessageLevel.Error).SetException(typeof(System.RankException)));
        Add(_cor_e_reflectiontypeload = new MessageDescription("URT.COR_E_REFLECTIONTYPELOAD", 0x80131602, new ParameterlessText("Could not find or load a specific class that was requested through Reflection.")).SetHResult(0x80131602).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.ReflectionTypeLoadException)));
        Add(_cor_e_runtimewrapped = new MessageDescription("URT.COR_E_RUNTIMEWRAPPED", 0x8013153E, new ParameterlessText("An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.")).SetHResult(0x8013153E).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.CompilerServices.RuntimeWrappedException)));
        Add(_cor_e_safearrayrankmismatch = new MessageDescription("URT.COR_E_SAFEARRAYRANKMISMATCH", 0x80131538, new ParameterlessText("A mismatch has occurred between the runtime rank of the array and the rank recorded in the metadata.")).SetHResult(0x80131538).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.InteropServices.SafeArrayTypeMismatchException)));
        Add(_cor_e_safearraytypemismatch = new MessageDescription("URT.COR_E_SAFEARRAYTYPEMISMATCH", 0x80131533, new ParameterlessText("A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.")).SetHResult(0x80131533).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.InteropServices.SafeArrayRankMismatchException)));
        Add(_cor_e_security = new MessageDescription("URT.COR_E_SECURITY", 0x8013150A, new ParameterlessText("OLE Variant has an invalid type.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_cor_e_serialization = new MessageDescription("URT.COR_E_SERIALIZATION", 0x8013150C, new ParameterlessText("A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_cor_e_synchronizationlock = new MessageDescription("URT.COR_E_SYNCHRONIZATIONLOCK", 0x80131518, new ParameterlessText("This operation must be called from a synchronized block.")).SetHResult(0x80131518).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.SynchronizationLockException)));
        Add(_cor_e_system = new MessageDescription("URT.COR_E_SYSTEM", 0x80131501, new ParameterlessText("System error.")).SetHResult(0x80131501).SetSeverity(MessageLevel.Error).SetException(typeof(System.SystemException)));
        Add(_cor_e_target = new MessageDescription("URT.COR_E_TARGET", 0x80131603, new ParameterlessText("Attempt to invoke non-static method with a null Object.")).SetHResult(0x80131603).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetException)));
        Add(_cor_e_targetinvocation = new MessageDescription("URT.COR_E_TARGETINVOCATION", 0x80131604, new ParameterlessText("Uncaught exception thrown by method called through Reflection.")).SetHResult(0x80131604).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetInvocationException)));
        Add(_cor_e_threadaborted = new MessageDescription("URT.COR_E_THREADABORTED", 0x80131530, new ParameterlessText("Thread has aborted.")).SetHResult(0x80131530).SetSeverity(MessageLevel.Critical).SetException(typeof(System.Threading.ThreadAbortException)));
        Add(_cor_e_threadinterrupted = new MessageDescription("URT.COR_E_THREADINTERRUPTED", 0x80131519, new ParameterlessText("Thread was interrupted from a waiting state.")).SetHResult(0x80131519).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.ThreadInterruptedException)));
        Add(_cor_e_threadstart = new MessageDescription("URT.COR_E_THREADSTART", 0x80131525, new ParameterlessText("Indicate that a user thread fails to start")).SetHResult(0x80131525).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.ThreadStartException)));
        Add(_cor_e_threadstate = new MessageDescription("URT.COR_E_THREADSTATE", 0x80131520, new ParameterlessText("Thread is in an invalid state for this operation.")).SetHResult(0x80131520).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.ThreadStateException)));
        Add(_cor_e_timeout = new MessageDescription("URT.COR_E_TIMEOUT", 0x80131505, new ParameterlessText("Operation timed out.")).SetHResult(0x80131505).SetSeverity(MessageLevel.Error).SetException(typeof(System.TimeoutException)));
        Add(_cor_e_typeaccess = new MessageDescription("URT.COR_E_TYPEACCESS", 0x80131543, new ParameterlessText("Access to this type is denied.")).SetHResult(0x80131543).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeAccessException)));
        Add(_cor_e_typeinitialization = new MessageDescription("URT.COR_E_TYPEINITIALIZATION", 0x80131534, new ParameterlessText("Uncaught exception during type initialization.")).SetHResult(0x80131534).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeInitializationException)));
        Add(_cor_e_typeload = new MessageDescription("URT.COR_E_TYPELOAD", 0x80131522, new ParameterlessText("Could not find or load a type.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeLoadException)));
        Add(_cor_e_typeunloaded = new MessageDescription("URT.COR_E_TYPEUNLOADED", 0x80131013, new ParameterlessText("Type has been unloaded.")).SetHResult(0x80131013).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeUnloadedException)));
        Add(_cor_e_verification = new MessageDescription("URT.COR_E_VERIFICATION", 0x8013150D, new ParameterlessText("Uncaught exception during type initialization.")).SetHResult(0x8013150D).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.VerificationException)));
        Add(_cor_e_waithandlecannotbeopened = new MessageDescription("URT.COR_E_WAITHANDLECANNOTBEOPENED", 0x8013152C, new ParameterlessText("No Semaphore of the given name exists")).SetHResult(0x8013152C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.WaitHandleCannotBeOpenedException)));
        return this;
    }    

}
