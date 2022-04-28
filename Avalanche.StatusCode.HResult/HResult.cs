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
using Avalanche.Message;
using Avalanche.Template;
using Avalanche.Utilities;

/// <summary>Introduction</summary>
public static class HResult
{
    /// <summary>All messages</summary>
    static readonly Lazy<IMessageDescriptions> messages = new(() => new MessageDescriptions(BasicMessages.Instance, RpcMessages.Instance, DispatchMessages.Instance, ItfMessages.Instance, Win32Messages.Instance, ClrMessages.Instance).SetReadOnly());
    /// <summary>All messages</summary>
    public static IMessageDescriptions Messages => messages.Value;
    /// <summary>All facilities</summary>
    public static FacilityMessages Facilities => FacilityMessages.Instance;
    
    /// <summary>Basic status codes</summary>
    public static BasicMessages NULL => BasicMessages.Instance;
    /// <summary>Remote Procedure Call</summary>
    public static RpcMessages RPC => RpcMessages.Instance;
    /// <summary>COM Dispatch</summary>
    public static DispatchMessages DISPATCH => DispatchMessages.Instance;
    /// <summary>COM/OLE Interface management</summary>
    public static ItfMessages ITF => ItfMessages.Instance;
    /// <summary>Win32</summary>
    public static Win32Messages WIN32 => Win32Messages.Instance;
    /// <summary>.NET CLR (Common Language Runtime)</summary>
    public static ClrMessages URT => ClrMessages.Instance;
    
    /// <summary>Operation successful</summary>
    public static IMessageDescription S_OK => NULL.S_OK;
    /// <summary>Operation failed</summary>
    public static IMessageDescription S_FALSE => NULL.S_FALSE;
    /// <summary>Ambiguous match found.</summary>
    public static IMessageDescription COR_E_AMBIGUOUSMATCH => NULL.COR_E_AMBIGUOUSMATCH;
    /// <summary>No such interface supported</summary>
    public static IMessageDescription COR_E_INVALIDCAST => NULL.COR_E_INVALIDCAST;
    /// <summary>The operation attempted to access data outside the valid range</summary>
    public static IMessageDescription E_BOUNDS => NULL.E_BOUNDS;
    /// <summary>A concurrent or interleaved operation changed the state of the object, invalidating this operation.</summary>
    public static IMessageDescription E_CHANGED_STATE => NULL.E_CHANGED_STATE;
    /// <summary>Unspecified error</summary>
    public static IMessageDescription E_FAIL => NULL.E_FAIL;
    /// <summary>Not implemented</summary>
    public static IMessageDescription E_NOTIMPL => NULL.E_NOTIMPL;
    /// <summary>Invalid pointer</summary>
    public static IMessageDescription E_POINTER => NULL.E_POINTER;
    /// <summary>NULL.RO_E_CLOSED</summary>
    public static IMessageDescription RO_E_CLOSED => NULL.RO_E_CLOSED;
    /// <summary>Catastrophic failure.</summary>
    public static IMessageDescription E_UNEXPECTED => NULL.E_UNEXPECTED;
    /// <summary>Operation aborted.</summary>
    public static IMessageDescription E_ABORT => NULL.E_ABORT;
    /// <summary>The data necessary to complete this operation is not yet available.</summary>
    public static IMessageDescription E_PENDING => NULL.E_PENDING;
    /// <summary>Cannot change thread mode after it is set.</summary>
    public static IMessageDescription RPC_E_CHANGED_MODE => RPC.RPC_E_CHANGED_MODE;
    /// <summary>Division by zero.</summary>
    public static IMessageDescription COR_E_DIVIDEBYZERO => DISPATCH.COR_E_DIVIDEBYZERO;
    /// <summary>Invalid number of parameters.</summary>
    public static IMessageDescription COR_E_TARGETPARAMCOUNT => DISPATCH.COR_E_TARGETPARAMCOUNT;
    /// <summary>Out of present range.</summary>
    public static IMessageDescription DISP_E_OVERFLOW => DISPATCH.DISP_E_OVERFLOW;
    /// <summary>Type mismatch.</summary>
    public static IMessageDescription TYPE_E_TYPEMISMATCH => DISPATCH.TYPE_E_TYPEMISMATCH;
    /// <summary>CoInitialize has not been called.</summary>
    public static IMessageDescription CO_E_NOTINITIALIZED => ITF.CO_E_NOTINITIALIZED;
    /// <summary>The parameter is incorrect.</summary>
    public static IMessageDescription COR_E_ARGUMENT => WIN32.COR_E_ARGUMENT;
    /// <summary>Arithmetic result exceeded 32 bits.</summary>
    public static IMessageDescription COR_E_ARITHMETIC => WIN32.COR_E_ARITHMETIC;
    /// <summary>WIN32.COR_E_BADEXEFORMAT</summary>
    public static IMessageDescription COR_E_BADEXEFORMAT => WIN32.COR_E_BADEXEFORMAT;
    /// <summary>An attempt was made to load a program with an incorrect format.</summary>
    public static IMessageDescription COR_E_BADIMAGEFORMAT => WIN32.COR_E_BADIMAGEFORMAT;
    /// <summary>The system cannot find the path specified.</summary>
    public static IMessageDescription COR_E_DIRECTORYNOTFOUND => WIN32.COR_E_DIRECTORYNOTFOUND;
    /// <summary>Reached the end of the file.</summary>
    public static IMessageDescription COR_E_ENDOFSTREAM => WIN32.COR_E_ENDOFSTREAM;
    /// <summary>The system cannot find the file specified.</summary>
    public static IMessageDescription COR_E_FILENOTFOUND => WIN32.COR_E_FILENOTFOUND;
    /// <summary>Ran out of memory</summary>
    public static IMessageDescription COR_E_OUTOFMEMORY => WIN32.COR_E_OUTOFMEMORY;
    /// <summary>The filename or extension is too long.</summary>
    public static IMessageDescription COR_E_PATHTOOLONG => WIN32.COR_E_PATHTOOLONG;
    /// <summary>Recursion too deep</summary>
    public static IMessageDescription COR_E_STACKOVERFLOW => WIN32.COR_E_STACKOVERFLOW;
    /// <summary>Access is denied.</summary>
    public static IMessageDescription COR_E_UNAUTHORIZEDACCESS => WIN32.COR_E_UNAUTHORIZEDACCESS;
    /// <summary>WIN32.E_HANDLE</summary>
    public static IMessageDescription E_HANDLE => WIN32.E_HANDLE;
    /// <summary>WIN32.ERROR_MRM_MAP_NOT_FOUND</summary>
    public static IMessageDescription ERROR_MRM_MAP_NOT_FOUND => WIN32.ERROR_MRM_MAP_NOT_FOUND;
    /// <summary>WIN32.ERROR_TIMEOUT</summary>
    public static IMessageDescription ERROR_TIMEOUT => WIN32.ERROR_TIMEOUT;
    /// <summary>The wait completed due to an abandoned mutex</summary>
    public static IMessageDescription COR_E_ABANDONEDMUTEX => URT.COR_E_ABANDONEDMUTEX;
    /// <summary>There are multiple incompatible interface methods overriding another method.</summary>
    public static IMessageDescription COR_E_AMBIGUOUSIMPLEMENTATION => URT.COR_E_AMBIGUOUSIMPLEMENTATION;
    /// <summary>Attempted to access an unloaded appdomain.</summary>
    public static IMessageDescription COR_E_APPDOMAINUNLOADED => URT.COR_E_APPDOMAINUNLOADED;
    /// <summary>Application exception</summary>
    public static IMessageDescription COR_E_APPLICATION => URT.COR_E_APPLICATION;
    /// <summary>An argument was out of its legal range.</summary>
    public static IMessageDescription COR_E_ARGUMENTOUTOFRANGE => URT.COR_E_ARGUMENTOUTOFRANGE;
    /// <summary>Attempted to store an object of the wrong type in an array.</summary>
    public static IMessageDescription COR_E_ARRAYTYPEMISMATCH => URT.COR_E_ARRAYTYPEMISMATCH;
    /// <summary>Error while unloading appdomain.</summary>
    public static IMessageDescription COR_E_CANNOTUNLOADAPPDOMAIN => URT.COR_E_CANNOTUNLOADAPPDOMAIN;
    /// <summary>URT.COR_E_CODECONTRACTFAILED</summary>
    public static IMessageDescription COR_E_CODECONTRACTFAILED => URT.COR_E_CODECONTRACTFAILED;
    /// <summary>Attempted to marshal an object across a context boundary.</summary>
    public static IMessageDescription COR_E_CONTEXTMARSHAL => URT.COR_E_CONTEXTMARSHAL;
    /// <summary>Custom attribute has invalid format.</summary>
    public static IMessageDescription COR_E_CUSTOMATTRIBUTEFORMAT => URT.COR_E_CUSTOMATTRIBUTEFORMAT;
    /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
    public static IMessageDescription COR_E_DATAMISALIGNED => URT.COR_E_DATAMISALIGNED;
    /// <summary>Could not find the specified DllImport Dll.</summary>
    public static IMessageDescription COR_E_DLLNOTFOUND => URT.COR_E_DLLNOTFOUND;
    /// <summary>An object appears more than once in the wait objects array.</summary>
    public static IMessageDescription COR_E_DUPLICATEWAITOBJECT => URT.COR_E_DUPLICATEWAITOBJECT;
    /// <summary>Could not find the specified DllImport entrypoint.</summary>
    public static IMessageDescription COR_E_ENTRYPOINTNOTFOUND => URT.COR_E_ENTRYPOINTNOTFOUND;
    /// <summary>General Exception</summary>
    public static IMessageDescription COR_E_EXCEPTION => URT.COR_E_EXCEPTION;
    /// <summary>Internal CLR error.</summary>
    public static IMessageDescription COR_E_EXECUTIONENGINE => URT.COR_E_EXECUTIONENGINE;
    /// <summary>Access to this field is denied.</summary>
    public static IMessageDescription COR_E_FIELDACCESS => URT.COR_E_FIELDACCESS;
    /// <summary>Could not find or load a specific file.</summary>
    public static IMessageDescription COR_E_FILELOAD => URT.COR_E_FILELOAD;
    /// <summary>One of the identified items was in an invalid format.</summary>
    public static IMessageDescription COR_E_FORMAT => URT.COR_E_FORMAT;
    /// <summary>Array subscript out of range.</summary>
    public static IMessageDescription COR_E_INDEXOUTOFRANGE => URT.COR_E_INDEXOUTOFRANGE;
    /// <summary>Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.</summary>
    public static IMessageDescription COR_E_INSUFFICIENTEXECUTIONSTACK => URT.COR_E_INSUFFICIENTEXECUTIONSTACK;
    /// <summary>Not enough memory was available for an operation.</summary>
    public static IMessageDescription COR_E_INSUFFICIENTMEMORY => URT.COR_E_INSUFFICIENTMEMORY;
    /// <summary>An invalid __ComObject has been used.</summary>
    public static IMessageDescription COR_E_INVALIDCOMOBJECT => URT.COR_E_INVALIDCOMOBJECT;
    /// <summary>The given filter criteria does not match the filter content.</summary>
    public static IMessageDescription COR_E_INVALIDFILTERCRITERIA => URT.COR_E_INVALIDFILTERCRITERIA;
    /// <summary>OLE Variant has an invalid type.</summary>
    public static IMessageDescription COR_E_INVALIDOLEVARIANTTYPE => URT.COR_E_INVALIDOLEVARIANTTYPE;
    /// <summary>An operation is not legal in the current state.</summary>
    public static IMessageDescription COR_E_INVALIDOPERATION => URT.COR_E_INVALIDOPERATION;
    /// <summary>Invalid IL or CLR metadata. A program contained invalid IL or bad metadata. Usually this is a compiler bug.</summary>
    public static IMessageDescription COR_E_INVALIDPROGRAM => URT.COR_E_INVALIDPROGRAM;
    /// <summary>Error during managed I/O.</summary>
    public static IMessageDescription COR_E_IO => URT.COR_E_IO;
    /// <summary>The given key was not present in the dictionary.</summary>
    public static IMessageDescription COR_E_KEYNOTFOUND => URT.COR_E_KEYNOTFOUND;
    /// <summary>Invalid marshaling directives.</summary>
    public static IMessageDescription COR_E_MARSHALDIRECTIVE => URT.COR_E_MARSHALDIRECTIVE;
    /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
    public static IMessageDescription COR_E_MEMBERACCESS => URT.COR_E_MEMBERACCESS;
    /// <summary>Access to this method is denied.</summary>
    public static IMessageDescription COR_E_METHODACCESS => URT.COR_E_METHODACCESS;
    /// <summary>Field does not exist.</summary>
    public static IMessageDescription COR_E_MISSINGFIELD => URT.COR_E_MISSINGFIELD;
    /// <summary>An expected resource in the assembly manifest was missing.</summary>
    public static IMessageDescription COR_E_MISSINGMANIFESTRESOURCE => URT.COR_E_MISSINGMANIFESTRESOURCE;
    /// <summary>Member does not exist.</summary>
    public static IMessageDescription COR_E_MISSINGMEMBER => URT.COR_E_MISSINGMEMBER;
    /// <summary>Method does not exist.</summary>
    public static IMessageDescription COR_E_MISSINGMETHOD => URT.COR_E_MISSINGMETHOD;
    /// <summary>An expected satellite assembly containing the ultimate fallback resources for a given culture was not found or could not be loaded.</summary>
    public static IMessageDescription COR_E_MISSINGSATELLITEASSEMBLY => URT.COR_E_MISSINGSATELLITEASSEMBLY;
    /// <summary>Attempt to combine delegates that are not multicast.</summary>
    public static IMessageDescription COR_E_MULTICASTNOTSUPPORTED => URT.COR_E_MULTICASTNOTSUPPORTED;
    /// <summary>Not a Number.</summary>
    public static IMessageDescription COR_E_NOTFINITENUMBER => URT.COR_E_NOTFINITENUMBER;
    /// <summary>Operation is not supported.</summary>
    public static IMessageDescription COR_E_NOTSUPPORTED => URT.COR_E_NOTSUPPORTED;
    /// <summary>The object has already been disposed.</summary>
    public static IMessageDescription COR_E_OBJECTDISPOSED => URT.COR_E_OBJECTDISPOSED;
    /// <summary>The operation was cancelle</summary>
    public static IMessageDescription COR_E_OPERATIONCANCELED => URT.COR_E_OPERATIONCANCELED;
    /// <summary>Arithmetic, casting or conversion operation overflowed or underflowed.</summary>
    public static IMessageDescription COR_E_OVERFLOW => URT.COR_E_OVERFLOW;
    /// <summary>Operation is not supported on this platform.</summary>
    public static IMessageDescription COR_E_PLATFORMNOTSUPPORTED => URT.COR_E_PLATFORMNOTSUPPORTED;
    /// <summary>An array has the wrong number of dimensions for a particular operation.</summary>
    public static IMessageDescription COR_E_RANK => URT.COR_E_RANK;
    /// <summary>Could not find or load a specific class that was requested through Reflection.</summary>
    public static IMessageDescription COR_E_REFLECTIONTYPELOAD => URT.COR_E_REFLECTIONTYPELOAD;
    /// <summary>An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.</summary>
    public static IMessageDescription COR_E_RUNTIMEWRAPPED => URT.COR_E_RUNTIMEWRAPPED;
    /// <summary>A mismatch has occurred between the runtime rank of the array and the rank recorded in the metadata.</summary>
    public static IMessageDescription COR_E_SAFEARRAYRANKMISMATCH => URT.COR_E_SAFEARRAYRANKMISMATCH;
    /// <summary>A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.</summary>
    public static IMessageDescription COR_E_SAFEARRAYTYPEMISMATCH => URT.COR_E_SAFEARRAYTYPEMISMATCH;
    /// <summary>OLE Variant has an invalid type.</summary>
    public static IMessageDescription COR_E_SECURITY => URT.COR_E_SECURITY;
    /// <summary>A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.</summary>
    public static IMessageDescription COR_E_SERIALIZATION => URT.COR_E_SERIALIZATION;
    /// <summary>This operation must be called from a synchronized block.</summary>
    public static IMessageDescription COR_E_SYNCHRONIZATIONLOCK => URT.COR_E_SYNCHRONIZATIONLOCK;
    /// <summary>System error.</summary>
    public static IMessageDescription COR_E_SYSTEM => URT.COR_E_SYSTEM;
    /// <summary>Attempt to invoke non-static method with a null Object.</summary>
    public static IMessageDescription COR_E_TARGET => URT.COR_E_TARGET;
    /// <summary>Uncaught exception thrown by method called through Reflection.</summary>
    public static IMessageDescription COR_E_TARGETINVOCATION => URT.COR_E_TARGETINVOCATION;
    /// <summary>Thread has aborted.</summary>
    public static IMessageDescription COR_E_THREADABORTED => URT.COR_E_THREADABORTED;
    /// <summary>Thread was interrupted from a waiting state.</summary>
    public static IMessageDescription COR_E_THREADINTERRUPTED => URT.COR_E_THREADINTERRUPTED;
    /// <summary>Indicate that a user thread fails to start</summary>
    public static IMessageDescription COR_E_THREADSTART => URT.COR_E_THREADSTART;
    /// <summary>Thread is in an invalid state for this operation.</summary>
    public static IMessageDescription COR_E_THREADSTATE => URT.COR_E_THREADSTATE;
    /// <summary>Operation timed out.</summary>
    public static IMessageDescription COR_E_TIMEOUT => URT.COR_E_TIMEOUT;
    /// <summary>Access to this type is denied.</summary>
    public static IMessageDescription COR_E_TYPEACCESS => URT.COR_E_TYPEACCESS;
    /// <summary>Uncaught exception during type initialization.</summary>
    public static IMessageDescription COR_E_TYPEINITIALIZATION => URT.COR_E_TYPEINITIALIZATION;
    /// <summary>Could not find or load a type.</summary>
    public static IMessageDescription COR_E_TYPELOAD => URT.COR_E_TYPELOAD;
    /// <summary>Type has been unloaded.</summary>
    public static IMessageDescription COR_E_TYPEUNLOADED => URT.COR_E_TYPEUNLOADED;
    /// <summary>Uncaught exception during type initialization.</summary>
    public static IMessageDescription COR_E_VERIFICATION => URT.COR_E_VERIFICATION;
    /// <summary>No Semaphore of the given name exists</summary>
    public static IMessageDescription COR_E_WAITHANDLECANNOTBEOPENED => URT.COR_E_WAITHANDLECANNOTBEOPENED;
}
