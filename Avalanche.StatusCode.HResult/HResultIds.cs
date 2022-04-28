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

/// <summary>HResult constants.</summary>
public static class HResultIds
{
    /// <summary>(0-15) Code mask</summary>
    public const int CodeMask = 0x0000FFFF;
    /// <summary>(16-26) Facility/Namespace mask, bits 16-27</summary>
    public const int FacilityMask = 0x27FF0000;
    /// <summary>(27) Is display text, 0=StatusCode, 1=Display text</summary>
    public const int DisplayTextMask = 0x08000000;
    /// <summary>(28) Reserved</summary>
    public const int Reserved28 = 0x10000000;
    /// <summary>(29) Bit that indicates whether status code is 0=standard code, 1=3rd party defined</summary>
    public const int ThirdPartyMask = 0x20000000;
    /// <summary>(30) ??</summary>
    public const int Reserved30 = unchecked((int)0x40000000U);
    /// <summary>(31) Severity mask</summary>
    public const int SeverityMask = unchecked((int)0x80000000U);
    /// <summary>(31) Severity bad (mask)</summary>
    public const int SeverityBad = unchecked((int)0x80000000U);

    /// <summary>Basic status codes</summary>
    public const int FACILITY_NULL = 0x00000000;
    /// <summary>Remote Procedure Call</summary>
    public const int FACILITY_RPC = 0x00010000;
    /// <summary>COM Dispatch</summary>
    public const int FACILITY_DISPATCH = 0x00020000;
    /// <summary>OLE Storage</summary>
    public const int FACILITY_STORAGE = 0x00030000;
    /// <summary>COM/OLE Interface management</summary>
    public const int FACILITY_ITF = 0x00040000;
    /// <summary>Win32</summary>
    public const int FACILITY_WIN32 = 0x00070000;
    /// <summary>Windows subsystem</summary>
    public const int FACILITY_WINDOWS = 0x00080000;
    /// <summary>Security API layer</summary>
    public const int FACILITY_SSPI = 0x00090000;
    /// <summary>Control mechanism</summary>
    public const int FACILITY_CONTROL = 0x000A0000;
    /// <summary>Certificate client or server</summary>
    public const int FACILITY_CERT = 0x000B0000;
    /// <summary>Wininet related</summary>
    public const int FACILITY_INTERNET = 0x000C0000;
    /// <summary>Windows Media Server</summary>
    public const int FACILITY_MEDIASERVER = 0x000D0000;
    /// <summary>Microsoft Message Queue</summary>
    public const int FACILITY_MSMQ = 0x000E0000;
    /// <summary>Setup API</summary>
    public const int FACILITY_SETUPAPI = 0x000F0000;
    /// <summary>Smart-card subsystem</summary>
    public const int FACILITY_SCARD = 0x00100000;
    /// <summary>COM+</summary>
    public const int FACILITY_COMPLUS = 0x00110000;
    /// <summary>Microsoft agent</summary>
    public const int FACILITY_AAF = 0x00120000;
    /// <summary>.NET CLR (Common Language Runtime)</summary>
    public const int FACILITY_URT = 0x00130000;
    /// <summary>Audit collection service</summary>
    public const int FACILITY_ACS = 0x00140000;
    /// <summary>Direct Play</summary>
    public const int FACILITY_DPLAY = 0x00150000;
    /// <summary>Ubiquitous memoryintrospection service</summary>
    public const int FACILITY_UMI = 0x00160000;
    /// <summary>Side-by-side servicing</summary>
    public const int FACILITY_SXS = 0x00170000;
    /// <summary>Windows CE</summary>
    public const int FACILITY_WINDOWS_CE = 0x00180000;
    /// <summary>HTTP support</summary>
    public const int FACILITY_HTTP = 0x00190000;
    /// <summary>Common Logging</summary>
    public const int FACILITY_USERMODE_COMMONLOG = 0x001A0000;
    /// <summary>User mode filter manager</summary>
    public const int FACILITY_USERMODE_FILTER_MANAGER = 0x001F0000;
    /// <summary>Background copy control</summary>
    public const int FACILITY_BACKGROUNDCOPY = 0x00200000;
    /// <summary>Configuration services</summary>
    public const int FACILITY_CONFIGURATION = 0x00210000;
    /// <summary>State management services</summary>
    public const int FACILITY_STATE_MANAGEMENT = 0x00220000;
    /// <summary>Microsoft Identity Server</summary>
    public const int FACILITY_METADIRECTORY = 0x00230000;
    /// <summary>Windows update</summary>
    public const int FACILITY_WINDOWSUPDATE = 0x00240000;
    /// <summary>Active Directory</summary>
    public const int FACILITY_DIRECTORYSERVICE = 0x00250000;
    /// <summary>Graphics drivers</summary>
    public const int FACILITY_GRAPHICS = 0x00260000;
    /// <summary>User Shell</summary>
    public const int FACILITY_SHELL = 0x00270000;
    /// <summary>Trusted Platform Module services</summary>
    public const int FACILITY_TPM_SERVICES = 0x00280000;
    /// <summary>Trusted Platform Module applications</summary>
    public const int FACILITY_TPM_SOFTWARE = 0x00290000;
    /// <summary>Performance Logs and Alerts</summary>
    public const int FACILITY_PLA = 0x00300000;
    /// <summary>Full volume encryption</summary>
    public const int FACILITY_FVE = 0x00310000;
    /// <summary>Firewall Platform</summary>
    public const int FACILITY_FWP = 0x00320000;
    /// <summary>Windows Resource Manager</summary>
    public const int FACILITY_WINRM = 0x00330000;
    /// <summary>Network Driver Interface</summary>
    public const int FACILITY_NDIS = 0x00340000;
    /// <summary>Usermode Hypervisor components</summary>
    public const int FACILITY_USERMODE_HYPERVISOR = 0x00350000;
    /// <summary>Configuration Management Infrastructure</summary>
    public const int FACILITY_CMI = 0x00360000;
    /// <summary>User mode virtualization subsystem</summary>
    public const int FACILITY_USERMODE_VIRTUALIZATION = 0x00370000;
    /// <summary>User mode volume manager</summary>
    public const int FACILITY_USERMODE_VOLMGR = 0x00380000;
    /// <summary>Boot Configuration Database</summary>
    public const int FACILITY_BCD = 0x00390000;
    /// <summary>User mode virtual hard disk support</summary>
    public const int FACILITY_USERMODE_VHD = 0x003A0000;
    /// <summary>System Diagnostics</summary>
    public const int FACILITY_SDIAG = 0x003C0000;
    /// <summary>Web Services</summary>
    public const int FACILITY_WEBSERVICES = 0x003D0000;
    /// <summary>Windows Defender component</summary>
    public const int FACILITY_WINDOWS_DEFENDER = 0x00500000;
    /// <summary>Open connectivity service</summary>
    public const int FACILITY_OPC = 0x00510000;
    /// <summary>Distributed Link Tracking</summary>
    public const int FACILITY_DLT = 0x05EA0000;
    /// <summary>Wired Equivalent Privacy Encryption</summary>
    public const int FACILITY_WER = 0x001B0000;
    /// <summary>User Interface</summary>
    public const int FACILITY_UI = 0x002A0000;
    /// <summary>eXtended Application Markup Language</summary>
    public const int FACILITY_XAML = 0x002B0000;
    /// <summary>ACTION_QUEUE</summary>
    public const int FACILITY_ACTION_QUEUE = 0x002C0000;
    /// <summary>Notification Platform</summary>
    public const int FACILITY_WPN = 0x003E0000;
    /// <summary>Windows Store</summary>
    public const int FACILITY_WINDOWS_STORE = 0x003F0000;
    /// <summary>Input</summary>
    public const int FACILITY_INPUT = 0x00400000;
    /// <summary>Extensible Authentication Protocol</summary>
    public const int FACILITY_EAP = 0x00420000;
    /// <summary>XPS (XML Paper Specification) Document</summary>
    public const int FACILITY_XPS = 0x00520000;
    /// <summary>RAS</summary>
    public const int FACILITY_RAS = 0x00530000;
    /// <summary>MBN</summary>
    public const int FACILITY_MBN = 0x00540000;
    /// <summary>Exchange Active Synchronization</summary>
    public const int FACILITY_EAS = 0x00550000;
    /// <summary>P2P_INT</summary>
    public const int FACILITY_P2P_INT = 0x00620000;
    /// <summary>Peer Graphing API</summary>
    public const int FACILITY_P2P = 0x00630000;
    /// <summary>DAF</summary>
    public const int FACILITY_DAF = 0x00640000;
    /// <summary>Bluetooth ATT (Attribute Protocol)</summary>
    public const int FACILITY_BLUETOOTH_ATT = 0x00650000;
    /// <summary>Audio</summary>
    public const int FACILITY_AUDIO = 0x00660000;
    /// <summary>VISUALCPP</summary>
    public const int FACILITY_VISUALCPP = 0x006D0000;
    /// <summary>SCRIPT</summary>
    public const int FACILITY_SCRIPT = 0x00700000;
    /// <summary>PARSE</summary>
    public const int FACILITY_PARSE = 0x00710000;
    /// <summary>BLB</summary>
    public const int FACILITY_BLB = 0x00780000;
    /// <summary>BLB_CLI</summary>
    public const int FACILITY_BLB_CLI = 0x00790000;
    /// <summary>WSBAPP</summary>
    public const int FACILITY_WSBAPP = 0x007A0000;
    /// <summary>BLBUI</summary>
    public const int FACILITY_BLBUI = 0x00800000;
    /// <summary>USN</summary>
    public const int FACILITY_USN = 0x00810000;
    /// <summary>USERMODE_VOLSNAP</summary>
    public const int FACILITY_USERMODE_VOLSNAP = 0x00820000;
    /// <summary>TIERING</summary>
    public const int FACILITY_TIERING = 0x00830000;
    /// <summary>WSB_ONLINE</summary>
    public const int FACILITY_WSB_ONLINE = 0x00850000;
    /// <summary>ONLINE_ID</summary>
    public const int FACILITY_ONLINE_ID = 0x00860000;
    /// <summary>DLS</summary>
    public const int FACILITY_DLS = 0x00990000;
    /// <summary>SOS</summary>
    public const int FACILITY_SOS = 0x00A00000;
    /// <summary>Debugger</summary>
    public const int FACILITY_DEBUGGERS = 0x00B00000;
    /// <summary>Storage Spaces - Group physicial drives in virtual drives storage pools</summary>
    public const int FACILITY_USERMODE_SPACES = 0x00E70000;
    /// <summary>DMSERVER</summary>
    public const int FACILITY_DMSERVER = 0x01000000;
    /// <summary>Windows Deployment Services (WDS) Server</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_SERVER = 0x01010000;
    /// <summary>Windows Deployment Services (WDS) Imaging</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_IMAGING = 0x01020000;
    /// <summary>Windows Deployment Services (WDS) Management</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT = 0x01030000;
    /// <summary>Windows Deployment Services (WDS) Util</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_UTIL = 0x01040000;
    /// <summary>Windows Deployment Services (WDS) Binlsvc</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_BINLSVC = 0x01050000;
    /// <summary>Windows Deployment Services (WDS) Pxe</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_PXE = 0x01070000;
    /// <summary>Windows Deployment Services (WDS) TFP</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_TFTP = 0x01080000;
    /// <summary>Windows Deployment Services (WDS) Transport Manager</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT = 0x01100000;
    /// <summary>Windows Deployment Services (WDS) Driver Provisioning</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING = 0x01160000;
    /// <summary>Windows Deployment Services (WDS) Multicast Server</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER = 0x01210000;
    /// <summary>Windows Deployment Services (WDS) Multicast Client</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT = 0x01220000;
    /// <summary>Windows Deployment Services (WDS) Content Provider</summary>
    public const int FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER = 0x01250000;
    /// <summary>LINGUISTIC_SERVICES</summary>
    public const int FACILITY_LINGUISTIC_SERVICES = 0x01310000;
    /// <summary>WEB</summary>
    public const int FACILITY_WEB = 0x03750000;
    /// <summary>WEB_SOCKET</summary>
    public const int FACILITY_WEB_SOCKET = 0x03760000;
    /// <summary>AUDIOSTREAMING</summary>
    public const int FACILITY_AUDIOSTREAMING = 0x04460000;
    /// <summary>ACCELERATOR</summary>
    public const int FACILITY_ACCELERATOR = 0x06000000;
    /// <summary>MOBILE</summary>
    public const int FACILITY_MOBILE = 0x07010000;
    /// <summary>WMAAECMA</summary>
    public const int FACILITY_WMAAECMA = 0x07CC0000;
    /// <summary>WEP Encryption (Wired Equivalent Privacy)</summary>
    public const int FACILITY_WEP = 0x08010000;
    /// <summary>SYNCENGINE</summary>
    public const int FACILITY_SYNCENGINE = 0x08020000;
    /// <summary>Direct Music (part of DirectX) - Audio</summary>
    public const int FACILITY_DIRECTMUSIC = 0x08780000;
    /// <summary>Direct3D 10</summary>
    public const int FACILITY_DIRECT3D10 = 0x08790000;
    /// <summary>DirectX Graphics Infrastructure</summary>
    public const int FACILITY_DXGI = 0x087A0000;
    /// <summary>DirectX Graphics Infrastructure Device Driver Interface</summary>
    public const int FACILITY_DXGI_DDI = 0x087B0000;
    /// <summary>Direct3D 11</summary>
    public const int FACILITY_DIRECT3D11 = 0x087C0000;
    /// <summary>XAudio2 Internal Errors</summary>
    public const int FACILITY_LEAP = 0x08880000;
    /// <summary>Audio Client</summary>
    public const int FACILITY_AUDCLNT = 0x08890000;
    /// <summary>DirectWrite (part of DirectX) - Text layout and glyph rendering</summary>
    public const int FACILITY_WINCODEC_DWRITE_DWM = 0x08980000;
    /// <summary>Direct 2D (hardware accelerated GUI rendering)</summary>
    public const int FACILITY_DIRECT2D = 0x08990000;
    /// <summary>Defragging</summary>
    public const int FACILITY_DEFRAG = 0x09000000;
    /// <summary>SD (Secure Digital) Bus - SD Card</summary>
    public const int FACILITY_USERMODE_SDBUS = 0x09010000;
    /// <summary>Javascript</summary>
    public const int FACILITY_JSCRIPT = 0x09020000;
    /// <summary>PIDGENX</summary>
    public const int FACILITY_PIDGENX = 0x0A010000;
    /// <summary>Avalanche.*</summary>
    public const int FACILITY_AVALANCHE = 0x20AA0000;
    /// <summary>mscorlib.dll resource codes</summary>
    public const int FACILITY_MSCORLIB = 0x23450000;
    /// <summary>Operation successful</summary>
    public const int S_OK = 0x00000000;
    /// <summary>Operation failed</summary>
    public const int S_FALSE = 0x00000001;
    /// <summary>The data necessary to complete this operation is not yet available.</summary>
    public const int E_PENDING = unchecked((int)0x8000000A);
    /// <summary>The operation attempted to access data outside the valid range</summary>
    public const int E_BOUNDS = unchecked((int)0x8000000B);
    /// <summary>A concurrent or interleaved operation changed the state of the object, invalidating this operation.</summary>
    public const int E_CHANGED_STATE = unchecked((int)0x8000000C);
    /// <summary>NULL.RO_E_CLOSED</summary>
    public const int RO_E_CLOSED = unchecked((int)0x80000013);
    /// <summary>Operation aborted.</summary>
    public const int E_ABORT = unchecked((int)0x80004004);
    /// <summary>Catastrophic failure.</summary>
    public const int E_UNEXPECTED = unchecked((int)0x8000FFFF);
    /// <summary>Ambiguous match found.</summary>
    public const int COR_E_AMBIGUOUSMATCH = unchecked((int)0x8000211D);
    /// <summary>Not implemented</summary>
    public const int E_NOTIMPL = unchecked((int)0x80004001);
    /// <summary>No such interface supported</summary>
    public const int COR_E_INVALIDCAST = unchecked((int)0x80004002);
    /// <summary>Invalid pointer</summary>
    public const int E_POINTER = unchecked((int)0x80004003);
    /// <summary>Unspecified error</summary>
    public const int E_FAIL = unchecked((int)0x80004005);
    /// <summary>Invalid marshaling directives.</summary>
    public const int COR_E_MARSHALDIRECTIVE = unchecked((int)0x80131535);
    /// <summary>URT.COR_E_CODECONTRACTFAILED</summary>
    public const int COR_E_CODECONTRACTFAILED = unchecked((int)0x80131542);
    /// <summary>Type has been unloaded.</summary>
    public const int COR_E_TYPEUNLOADED = unchecked((int)0x80131013);
    /// <summary>Attempted to access an unloaded appdomain.</summary>
    public const int COR_E_APPDOMAINUNLOADED = unchecked((int)0x80131014);
    /// <summary>Error while unloading appdomain.</summary>
    public const int COR_E_CANNOTUNLOADAPPDOMAIN = unchecked((int)0x80131015);
    /// <summary>There are multiple incompatible interface methods overriding another method.</summary>
    public const int COR_E_AMBIGUOUSIMPLEMENTATION = unchecked((int)0x8013106A);
    /// <summary>General Exception</summary>
    public const int COR_E_EXCEPTION = unchecked((int)0x80131500);
    /// <summary>System error.</summary>
    public const int COR_E_SYSTEM = unchecked((int)0x80131501);
    /// <summary>An argument was out of its legal range.</summary>
    public const int COR_E_ARGUMENTOUTOFRANGE = unchecked((int)0x80131502);
    /// <summary>Attempted to store an object of the wrong type in an array.</summary>
    public const int COR_E_ARRAYTYPEMISMATCH = unchecked((int)0x80131503);
    /// <summary>Attempted to marshal an object across a context boundary.</summary>
    public const int COR_E_CONTEXTMARSHAL = unchecked((int)0x80131504);
    /// <summary>Operation timed out.</summary>
    public const int COR_E_TIMEOUT = unchecked((int)0x80131505);
    /// <summary>Internal CLR error.</summary>
    public const int COR_E_EXECUTIONENGINE = unchecked((int)0x80131506);
    /// <summary>Access to this field is denied.</summary>
    public const int COR_E_FIELDACCESS = unchecked((int)0x80131507);
    /// <summary>Array subscript out of range.</summary>
    public const int COR_E_INDEXOUTOFRANGE = unchecked((int)0x80131508);
    /// <summary>An operation is not legal in the current state.</summary>
    public const int COR_E_INVALIDOPERATION = unchecked((int)0x80131509);
    /// <summary>OLE Variant has an invalid type.</summary>
    public const int COR_E_SECURITY = unchecked((int)0x8013150A);
    /// <summary>A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.</summary>
    public const int COR_E_SERIALIZATION = unchecked((int)0x8013150C);
    /// <summary>Uncaught exception during type initialization.</summary>
    public const int COR_E_VERIFICATION = unchecked((int)0x8013150D);
    /// <summary>Access to this method is denied.</summary>
    public const int COR_E_METHODACCESS = unchecked((int)0x80131510);
    /// <summary>Field does not exist.</summary>
    public const int COR_E_MISSINGFIELD = unchecked((int)0x80131511);
    /// <summary>Member does not exist.</summary>
    public const int COR_E_MISSINGMEMBER = unchecked((int)0x80131512);
    /// <summary>Method does not exist.</summary>
    public const int COR_E_MISSINGMETHOD = unchecked((int)0x80131513);
    /// <summary>Attempt to combine delegates that are not multicast.</summary>
    public const int COR_E_MULTICASTNOTSUPPORTED = unchecked((int)0x80131514);
    /// <summary>Operation is not supported.</summary>
    public const int COR_E_NOTSUPPORTED = unchecked((int)0x80131515);
    /// <summary>Arithmetic, casting or conversion operation overflowed or underflowed.</summary>
    public const int COR_E_OVERFLOW = unchecked((int)0x80131516);
    /// <summary>An array has the wrong number of dimensions for a particular operation.</summary>
    public const int COR_E_RANK = unchecked((int)0x80131517);
    /// <summary>This operation must be called from a synchronized block.</summary>
    public const int COR_E_SYNCHRONIZATIONLOCK = unchecked((int)0x80131518);
    /// <summary>Thread was interrupted from a waiting state.</summary>
    public const int COR_E_THREADINTERRUPTED = unchecked((int)0x80131519);
    /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
    public const int COR_E_MEMBERACCESS = unchecked((int)0x8013151A);
    /// <summary>Thread is in an invalid state for this operation.</summary>
    public const int COR_E_THREADSTATE = unchecked((int)0x80131520);
    /// <summary>Could not find or load a type.</summary>
    public const int COR_E_TYPELOAD = unchecked((int)0x80131522);
    /// <summary>Could not find the specified DllImport entrypoint.</summary>
    public const int COR_E_ENTRYPOINTNOTFOUND = unchecked((int)0x80131523);
    /// <summary>Could not find the specified DllImport Dll.</summary>
    public const int COR_E_DLLNOTFOUND = unchecked((int)0x80131524);
    /// <summary>Indicate that a user thread fails to start</summary>
    public const int COR_E_THREADSTART = unchecked((int)0x80131525);
    /// <summary>An invalid __ComObject has been used.</summary>
    public const int COR_E_INVALIDCOMOBJECT = unchecked((int)0x80131527);
    /// <summary>Not a Number.</summary>
    public const int COR_E_NOTFINITENUMBER = unchecked((int)0x80131528);
    /// <summary>An object appears more than once in the wait objects array.</summary>
    public const int COR_E_DUPLICATEWAITOBJECT = unchecked((int)0x80131529);
    /// <summary>No Semaphore of the given name exists</summary>
    public const int COR_E_WAITHANDLECANNOTBEOPENED = unchecked((int)0x8013152C);
    /// <summary>The wait completed due to an abandoned mutex</summary>
    public const int COR_E_ABANDONEDMUTEX = unchecked((int)0x8013152D);
    /// <summary>Thread has aborted.</summary>
    public const int COR_E_THREADABORTED = unchecked((int)0x80131530);
    /// <summary>OLE Variant has an invalid type.</summary>
    public const int COR_E_INVALIDOLEVARIANTTYPE = unchecked((int)0x80131531);
    /// <summary>An expected resource in the assembly manifest was missing.</summary>
    public const int COR_E_MISSINGMANIFESTRESOURCE = unchecked((int)0x80131532);
    /// <summary>A mismatch has occurred between the runtime type of the array and the sub type recorded in the metadata.</summary>
    public const int COR_E_SAFEARRAYTYPEMISMATCH = unchecked((int)0x80131533);
    /// <summary>Uncaught exception during type initialization.</summary>
    public const int COR_E_TYPEINITIALIZATION = unchecked((int)0x80131534);
    /// <summary>An expected satellite assembly containing the ultimate fallback resources for a given culture was not found or could not be loaded.</summary>
    public const int COR_E_MISSINGSATELLITEASSEMBLY = unchecked((int)0x80131536);
    /// <summary>One of the identified items was in an invalid format.</summary>
    public const int COR_E_FORMAT = unchecked((int)0x80131537);
    /// <summary>A mismatch has occurred between the runtime rank of the array and the rank recorded in the metadata.</summary>
    public const int COR_E_SAFEARRAYRANKMISMATCH = unchecked((int)0x80131538);
    /// <summary>Operation is not supported on this platform.</summary>
    public const int COR_E_PLATFORMNOTSUPPORTED = unchecked((int)0x80131539);
    /// <summary>Invalid IL or CLR metadata. A program contained invalid IL or bad metadata. Usually this is a compiler bug.</summary>
    public const int COR_E_INVALIDPROGRAM = unchecked((int)0x8013153A);
    /// <summary>The operation was cancelle</summary>
    public const int COR_E_OPERATIONCANCELED = unchecked((int)0x8013153B);
    /// <summary>Not enough memory was available for an operation.</summary>
    public const int COR_E_INSUFFICIENTMEMORY = unchecked((int)0x8013153D);
    /// <summary>An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.</summary>
    public const int COR_E_RUNTIMEWRAPPED = unchecked((int)0x8013153E);
    /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
    public const int COR_E_DATAMISALIGNED = unchecked((int)0x80131541);
    /// <summary>Access to this type is denied.</summary>
    public const int COR_E_TYPEACCESS = unchecked((int)0x80131543);
    /// <summary>The given key was not present in the dictionary.</summary>
    public const int COR_E_KEYNOTFOUND = unchecked((int)0x80131577);
    /// <summary>Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.</summary>
    public const int COR_E_INSUFFICIENTEXECUTIONSTACK = unchecked((int)0x80131578);
    /// <summary>Application exception</summary>
    public const int COR_E_APPLICATION = unchecked((int)0x80131600);
    /// <summary>The given filter criteria does not match the filter content.</summary>
    public const int COR_E_INVALIDFILTERCRITERIA = unchecked((int)0x80131601);
    /// <summary>Could not find or load a specific class that was requested through Reflection.</summary>
    public const int COR_E_REFLECTIONTYPELOAD = unchecked((int)0x80131602);
    /// <summary>Attempt to invoke non-static method with a null Object.</summary>
    public const int COR_E_TARGET = unchecked((int)0x80131603);
    /// <summary>Uncaught exception thrown by method called through Reflection.</summary>
    public const int COR_E_TARGETINVOCATION = unchecked((int)0x80131604);
    /// <summary>Custom attribute has invalid format.</summary>
    public const int COR_E_CUSTOMATTRIBUTEFORMAT = unchecked((int)0x80131605);
    /// <summary>Error during managed I/O.</summary>
    public const int COR_E_IO = unchecked((int)0x80131620);
    /// <summary>Could not find or load a specific file.</summary>
    public const int COR_E_FILELOAD = unchecked((int)0x80131621);
    /// <summary>The object has already been disposed.</summary>
    public const int COR_E_OBJECTDISPOSED = unchecked((int)0x80131622);
    /// <summary>WIN32.E_HANDLE</summary>
    public const int E_HANDLE = unchecked((int)0x80070006);
    /// <summary>WIN32.COR_E_BADEXEFORMAT</summary>
    public const int COR_E_BADEXEFORMAT = unchecked((int)0x800700C1);
    /// <summary>WIN32.ERROR_TIMEOUT</summary>
    public const int ERROR_TIMEOUT = unchecked((int)0x800705B4);
    /// <summary>WIN32.ERROR_MRM_MAP_NOT_FOUND</summary>
    public const int ERROR_MRM_MAP_NOT_FOUND = unchecked((int)0x80073B1F);
    /// <summary>The system cannot find the file specified.</summary>
    public const int COR_E_FILENOTFOUND = unchecked((int)0x80070002);
    /// <summary>The system cannot find the path specified.</summary>
    public const int COR_E_DIRECTORYNOTFOUND = unchecked((int)0x80070003);
    /// <summary>Access is denied.</summary>
    public const int COR_E_UNAUTHORIZEDACCESS = unchecked((int)0x80070005);
    /// <summary>An attempt was made to load a program with an incorrect format.</summary>
    public const int COR_E_BADIMAGEFORMAT = unchecked((int)0x8007000B);
    /// <summary>Ran out of memory</summary>
    public const int COR_E_OUTOFMEMORY = unchecked((int)0x8007000E);
    /// <summary>Reached the end of the file.</summary>
    public const int COR_E_ENDOFSTREAM = unchecked((int)0x80070026);
    /// <summary>The parameter is incorrect.</summary>
    public const int COR_E_ARGUMENT = unchecked((int)0x80070057);
    /// <summary>The filename or extension is too long.</summary>
    public const int COR_E_PATHTOOLONG = unchecked((int)0x800700CE);
    /// <summary>Arithmetic result exceeded 32 bits.</summary>
    public const int COR_E_ARITHMETIC = unchecked((int)0x80070216);
    /// <summary>Recursion too deep</summary>
    public const int COR_E_STACKOVERFLOW = unchecked((int)0x800703E9);
    /// <summary>Out of present range.</summary>
    public const int DISP_E_OVERFLOW = unchecked((int)0x8002000A);
    /// <summary>Type mismatch.</summary>
    public const int TYPE_E_TYPEMISMATCH = unchecked((int)0x80028CA0);
    /// <summary>Invalid number of parameters.</summary>
    public const int COR_E_TARGETPARAMCOUNT = unchecked((int)0x8002000E);
    /// <summary>Division by zero.</summary>
    public const int COR_E_DIVIDEBYZERO = unchecked((int)0x80020012);
    /// <summary>CoInitialize has not been called.</summary>
    public const int CO_E_NOTINITIALIZED = unchecked((int)0x800401F0);
    /// <summary>Cannot change thread mode after it is set.</summary>
    public const int RPC_E_CHANGED_MODE = unchecked((int)0x80010106);
    
}
