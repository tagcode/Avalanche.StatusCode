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

/// <summary>HResult.Facilities</summary>
public class FacilityMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<FacilityMessages> instance = new Lazy<FacilityMessages>(() => new FacilityMessages().Initialize().SetAllReadOnly<FacilityMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static FacilityMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x007A;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _basic, _rpc, _dispatch, _storage, _itf, _win32, _windows, _sspi, _control, _cert;
    IMessageDescription? _internet, _mediaserver, _msmq, _setupapi, _scard, _complus, _aaf, _clr, _acs, _dplay;
    IMessageDescription? _umi, _sxs, _windowsce, _http, _usermodecommonlog, _usermodefiltermanager, _backgroundcopy, _configuration, _statemanagement, _metadirectory;
    IMessageDescription? _windowsupdate, _directoryservice, _graphics, _shell, _tpmservices, _tpmsoftware, _pla, _fve, _fwp, _winrm;
    IMessageDescription? _ndis, _usermodehypervisor, _cmi, _usermodevirtualization, _usermodevolmgr, _bcd, _usermodevhd, _sdiag, _webservices, _windowsdefender;
    IMessageDescription? _opc, _dlt, _wer, _ui, _xaml, _actionqueue, _wpn, _windowsstore, _input, _eap;
    IMessageDescription? _xps, _ras, _mbn, _eas, _p2pint, _p2p, _daf, _bluetootatt, _audio, _visualcpp;
    IMessageDescription? _script, _parse, _blb, _blbcli, _wsbapp, _blbui, _usn, _usermode_volsnap, _tiering, _wsb_online;
    IMessageDescription? _online_id, _dls, _sos, _debugger, _usermode_spaces, _dmserver, _deploymentservicesserver, _deploymentservicesimaging, _deploymentservicesmanagement, _deploymentservicesutil;
    IMessageDescription? _deploymentservicesbinlsvc, _deploymentservicespxe, _deploymentservicestftp, _deploymentservicestransportmanagement, _deploymentservicesdriverprovisioning, _deploymentservicesmulticastserver, _deploymentservicesmulticastclient, _deploymentservicescontentprovider, _linguistic_services, _web;
    IMessageDescription? _websocket, _audiostreaming, _accelerator, _mobile, _wmaaecma, _wep, _syncengine, _directmusic, _direct3d10, _dxgi;
    IMessageDescription? _dxgi_ddi, _direct3d11, _leap, _audclnt, _wincodecdwritedwm, _direct2d, _defrag, _usermode_sdbus, _jscript, _pidgenx;
    IMessageDescription? _avalanche, _mscorlib;
    
    /// <summary>Basic status codes</summary>
    public IMessageDescription Basic { get => _basic!; set => this.AssertWritable()._basic = value; }
    /// <summary>Remote Procedure Call</summary>
    public IMessageDescription Rpc { get => _rpc!; set => this.AssertWritable()._rpc = value; }
    /// <summary>COM Dispatch</summary>
    public IMessageDescription Dispatch { get => _dispatch!; set => this.AssertWritable()._dispatch = value; }
    /// <summary>OLE Storage</summary>
    public IMessageDescription Storage { get => _storage!; set => this.AssertWritable()._storage = value; }
    /// <summary>COM/OLE Interface management</summary>
    public IMessageDescription Itf { get => _itf!; set => this.AssertWritable()._itf = value; }
    /// <summary>Win32</summary>
    public IMessageDescription Win32 { get => _win32!; set => this.AssertWritable()._win32 = value; }
    /// <summary>Windows subsystem</summary>
    public IMessageDescription Windows { get => _windows!; set => this.AssertWritable()._windows = value; }
    /// <summary>Security API layer</summary>
    public IMessageDescription Sspi { get => _sspi!; set => this.AssertWritable()._sspi = value; }
    /// <summary>Control mechanism</summary>
    public IMessageDescription Control { get => _control!; set => this.AssertWritable()._control = value; }
    /// <summary>Certificate client or server</summary>
    public IMessageDescription Cert { get => _cert!; set => this.AssertWritable()._cert = value; }
    /// <summary>Wininet related</summary>
    public IMessageDescription Internet { get => _internet!; set => this.AssertWritable()._internet = value; }
    /// <summary>Windows Media Server</summary>
    public IMessageDescription MediaServer { get => _mediaserver!; set => this.AssertWritable()._mediaserver = value; }
    /// <summary>Microsoft Message Queue</summary>
    public IMessageDescription Msmq { get => _msmq!; set => this.AssertWritable()._msmq = value; }
    /// <summary>Setup API</summary>
    public IMessageDescription SetupApi { get => _setupapi!; set => this.AssertWritable()._setupapi = value; }
    /// <summary>Smart-card subsystem</summary>
    public IMessageDescription Scard { get => _scard!; set => this.AssertWritable()._scard = value; }
    /// <summary>COM+</summary>
    public IMessageDescription ComPlus { get => _complus!; set => this.AssertWritable()._complus = value; }
    /// <summary>Microsoft agent</summary>
    public IMessageDescription AAF { get => _aaf!; set => this.AssertWritable()._aaf = value; }
    /// <summary>.NET CLR (Common Language Runtime)</summary>
    public IMessageDescription Clr { get => _clr!; set => this.AssertWritable()._clr = value; }
    /// <summary>Audit collection service</summary>
    public IMessageDescription Acs { get => _acs!; set => this.AssertWritable()._acs = value; }
    /// <summary>Direct Play</summary>
    public IMessageDescription Dplay { get => _dplay!; set => this.AssertWritable()._dplay = value; }
    /// <summary>Ubiquitous memoryintrospection service</summary>
    public IMessageDescription Umi { get => _umi!; set => this.AssertWritable()._umi = value; }
    /// <summary>Side-by-side servicing</summary>
    public IMessageDescription Sxs { get => _sxs!; set => this.AssertWritable()._sxs = value; }
    /// <summary>Windows CE</summary>
    public IMessageDescription WindowsCE { get => _windowsce!; set => this.AssertWritable()._windowsce = value; }
    /// <summary>HTTP support</summary>
    public IMessageDescription Http { get => _http!; set => this.AssertWritable()._http = value; }
    /// <summary>Common Logging</summary>
    public IMessageDescription UserModeCommonLog { get => _usermodecommonlog!; set => this.AssertWritable()._usermodecommonlog = value; }
    /// <summary>User mode filter manager</summary>
    public IMessageDescription UserModeFilterManager { get => _usermodefiltermanager!; set => this.AssertWritable()._usermodefiltermanager = value; }
    /// <summary>Background copy control</summary>
    public IMessageDescription BackgroundCopy { get => _backgroundcopy!; set => this.AssertWritable()._backgroundcopy = value; }
    /// <summary>Configuration services</summary>
    public IMessageDescription Configuration { get => _configuration!; set => this.AssertWritable()._configuration = value; }
    /// <summary>State management services</summary>
    public IMessageDescription StateManagement { get => _statemanagement!; set => this.AssertWritable()._statemanagement = value; }
    /// <summary>Microsoft Identity Server</summary>
    public IMessageDescription MetaDirectory { get => _metadirectory!; set => this.AssertWritable()._metadirectory = value; }
    /// <summary>Windows update</summary>
    public IMessageDescription WindowsUpdate { get => _windowsupdate!; set => this.AssertWritable()._windowsupdate = value; }
    /// <summary>Active Directory</summary>
    public IMessageDescription DirectoryService { get => _directoryservice!; set => this.AssertWritable()._directoryservice = value; }
    /// <summary>Graphics drivers</summary>
    public IMessageDescription Graphics { get => _graphics!; set => this.AssertWritable()._graphics = value; }
    /// <summary>User Shell</summary>
    public IMessageDescription Shell { get => _shell!; set => this.AssertWritable()._shell = value; }
    /// <summary>Trusted Platform Module services</summary>
    public IMessageDescription TpmServices { get => _tpmservices!; set => this.AssertWritable()._tpmservices = value; }
    /// <summary>Trusted Platform Module applications</summary>
    public IMessageDescription TpmSoftware { get => _tpmsoftware!; set => this.AssertWritable()._tpmsoftware = value; }
    /// <summary>Performance Logs and Alerts</summary>
    public IMessageDescription Pla { get => _pla!; set => this.AssertWritable()._pla = value; }
    /// <summary>Full volume encryption</summary>
    public IMessageDescription Fve { get => _fve!; set => this.AssertWritable()._fve = value; }
    /// <summary>Firewall Platform</summary>
    public IMessageDescription Fwp { get => _fwp!; set => this.AssertWritable()._fwp = value; }
    /// <summary>Windows Resource Manager</summary>
    public IMessageDescription WinRm { get => _winrm!; set => this.AssertWritable()._winrm = value; }
    /// <summary>Network Driver Interface</summary>
    public IMessageDescription Ndis { get => _ndis!; set => this.AssertWritable()._ndis = value; }
    /// <summary>Usermode Hypervisor components</summary>
    public IMessageDescription UserModeHypervisor { get => _usermodehypervisor!; set => this.AssertWritable()._usermodehypervisor = value; }
    /// <summary>Configuration Management Infrastructure</summary>
    public IMessageDescription CMI { get => _cmi!; set => this.AssertWritable()._cmi = value; }
    /// <summary>User mode virtualization subsystem</summary>
    public IMessageDescription UserModeVirtualization { get => _usermodevirtualization!; set => this.AssertWritable()._usermodevirtualization = value; }
    /// <summary>User mode volume manager</summary>
    public IMessageDescription UserModeVolMgr { get => _usermodevolmgr!; set => this.AssertWritable()._usermodevolmgr = value; }
    /// <summary>Boot Configuration Database</summary>
    public IMessageDescription BCD { get => _bcd!; set => this.AssertWritable()._bcd = value; }
    /// <summary>User mode virtual hard disk support</summary>
    public IMessageDescription UserModeVhd { get => _usermodevhd!; set => this.AssertWritable()._usermodevhd = value; }
    /// <summary>System Diagnostics</summary>
    public IMessageDescription SDiag { get => _sdiag!; set => this.AssertWritable()._sdiag = value; }
    /// <summary>Web Services</summary>
    public IMessageDescription WebServices { get => _webservices!; set => this.AssertWritable()._webservices = value; }
    /// <summary>Windows Defender component</summary>
    public IMessageDescription WindowsDefender { get => _windowsdefender!; set => this.AssertWritable()._windowsdefender = value; }
    /// <summary>Open connectivity service</summary>
    public IMessageDescription Opc { get => _opc!; set => this.AssertWritable()._opc = value; }
    /// <summary>Distributed Link Tracking</summary>
    public IMessageDescription Dlt { get => _dlt!; set => this.AssertWritable()._dlt = value; }
    /// <summary>Wired Equivalent Privacy Encryption</summary>
    public IMessageDescription Wer { get => _wer!; set => this.AssertWritable()._wer = value; }
    /// <summary>User Interface</summary>
    public IMessageDescription Ui { get => _ui!; set => this.AssertWritable()._ui = value; }
    /// <summary>eXtended Application Markup Language</summary>
    public IMessageDescription Xaml { get => _xaml!; set => this.AssertWritable()._xaml = value; }
    /// <summary>ACTION_QUEUE</summary>
    public IMessageDescription ActionQueue { get => _actionqueue!; set => this.AssertWritable()._actionqueue = value; }
    /// <summary>Notification Platform</summary>
    public IMessageDescription Wpn { get => _wpn!; set => this.AssertWritable()._wpn = value; }
    /// <summary>Windows Store</summary>
    public IMessageDescription WindowsStore { get => _windowsstore!; set => this.AssertWritable()._windowsstore = value; }
    /// <summary>Input</summary>
    public IMessageDescription Input { get => _input!; set => this.AssertWritable()._input = value; }
    /// <summary>Extensible Authentication Protocol</summary>
    public IMessageDescription Eap { get => _eap!; set => this.AssertWritable()._eap = value; }
    /// <summary>XPS (XML Paper Specification) Document</summary>
    public IMessageDescription Xps { get => _xps!; set => this.AssertWritable()._xps = value; }
    /// <summary>RAS</summary>
    public IMessageDescription Ras { get => _ras!; set => this.AssertWritable()._ras = value; }
    /// <summary>MBN</summary>
    public IMessageDescription Mbn { get => _mbn!; set => this.AssertWritable()._mbn = value; }
    /// <summary>Exchange Active Synchronization</summary>
    public IMessageDescription Eas { get => _eas!; set => this.AssertWritable()._eas = value; }
    /// <summary>P2P_INT</summary>
    public IMessageDescription P2PInt { get => _p2pint!; set => this.AssertWritable()._p2pint = value; }
    /// <summary>Peer Graphing API</summary>
    public IMessageDescription P2p { get => _p2p!; set => this.AssertWritable()._p2p = value; }
    /// <summary>DAF</summary>
    public IMessageDescription Daf { get => _daf!; set => this.AssertWritable()._daf = value; }
    /// <summary>Bluetooth ATT (Attribute Protocol)</summary>
    public IMessageDescription BluetootAtt { get => _bluetootatt!; set => this.AssertWritable()._bluetootatt = value; }
    /// <summary>Audio</summary>
    public IMessageDescription Audio { get => _audio!; set => this.AssertWritable()._audio = value; }
    /// <summary>VISUALCPP</summary>
    public IMessageDescription VisualCpp { get => _visualcpp!; set => this.AssertWritable()._visualcpp = value; }
    /// <summary>SCRIPT</summary>
    public IMessageDescription Script { get => _script!; set => this.AssertWritable()._script = value; }
    /// <summary>PARSE</summary>
    public IMessageDescription Parse { get => _parse!; set => this.AssertWritable()._parse = value; }
    /// <summary>BLB</summary>
    public IMessageDescription Blb { get => _blb!; set => this.AssertWritable()._blb = value; }
    /// <summary>BLB_CLI</summary>
    public IMessageDescription BlbCli { get => _blbcli!; set => this.AssertWritable()._blbcli = value; }
    /// <summary>WSBAPP</summary>
    public IMessageDescription Wsbapp { get => _wsbapp!; set => this.AssertWritable()._wsbapp = value; }
    /// <summary>BLBUI</summary>
    public IMessageDescription Blbui { get => _blbui!; set => this.AssertWritable()._blbui = value; }
    /// <summary>USN</summary>
    public IMessageDescription Usn { get => _usn!; set => this.AssertWritable()._usn = value; }
    /// <summary>USERMODE_VOLSNAP</summary>
    public IMessageDescription Usermode_volsnap { get => _usermode_volsnap!; set => this.AssertWritable()._usermode_volsnap = value; }
    /// <summary>TIERING</summary>
    public IMessageDescription Tiering { get => _tiering!; set => this.AssertWritable()._tiering = value; }
    /// <summary>WSB_ONLINE</summary>
    public IMessageDescription Wsb_online { get => _wsb_online!; set => this.AssertWritable()._wsb_online = value; }
    /// <summary>ONLINE_ID</summary>
    public IMessageDescription Online_id { get => _online_id!; set => this.AssertWritable()._online_id = value; }
    /// <summary>DLS</summary>
    public IMessageDescription Dls { get => _dls!; set => this.AssertWritable()._dls = value; }
    /// <summary>SOS</summary>
    public IMessageDescription Sos { get => _sos!; set => this.AssertWritable()._sos = value; }
    /// <summary>Debugger</summary>
    public IMessageDescription Debugger { get => _debugger!; set => this.AssertWritable()._debugger = value; }
    /// <summary>Storage Spaces - Group physicial drives in virtual drives storage pools</summary>
    public IMessageDescription Usermode_spaces { get => _usermode_spaces!; set => this.AssertWritable()._usermode_spaces = value; }
    /// <summary>DMSERVER</summary>
    public IMessageDescription Dmserver { get => _dmserver!; set => this.AssertWritable()._dmserver = value; }
    /// <summary>Windows Deployment Services (WDS) Server</summary>
    public IMessageDescription DeploymentServicesServer { get => _deploymentservicesserver!; set => this.AssertWritable()._deploymentservicesserver = value; }
    /// <summary>Windows Deployment Services (WDS) Imaging</summary>
    public IMessageDescription DeploymentServicesImaging { get => _deploymentservicesimaging!; set => this.AssertWritable()._deploymentservicesimaging = value; }
    /// <summary>Windows Deployment Services (WDS) Management</summary>
    public IMessageDescription DeploymentServicesManagement { get => _deploymentservicesmanagement!; set => this.AssertWritable()._deploymentservicesmanagement = value; }
    /// <summary>Windows Deployment Services (WDS) Util</summary>
    public IMessageDescription DeploymentServicesUtil { get => _deploymentservicesutil!; set => this.AssertWritable()._deploymentservicesutil = value; }
    /// <summary>Windows Deployment Services (WDS) Binlsvc</summary>
    public IMessageDescription DeploymentServicesBinlsvc { get => _deploymentservicesbinlsvc!; set => this.AssertWritable()._deploymentservicesbinlsvc = value; }
    /// <summary>Windows Deployment Services (WDS) Pxe</summary>
    public IMessageDescription DeploymentServicesPxe { get => _deploymentservicespxe!; set => this.AssertWritable()._deploymentservicespxe = value; }
    /// <summary>Windows Deployment Services (WDS) TFP</summary>
    public IMessageDescription DeploymentServicesTftp { get => _deploymentservicestftp!; set => this.AssertWritable()._deploymentservicestftp = value; }
    /// <summary>Windows Deployment Services (WDS) Transport Manager</summary>
    public IMessageDescription DeploymentServicesTransportManagement { get => _deploymentservicestransportmanagement!; set => this.AssertWritable()._deploymentservicestransportmanagement = value; }
    /// <summary>Windows Deployment Services (WDS) Driver Provisioning</summary>
    public IMessageDescription DeploymentServicesDriverProvisioning { get => _deploymentservicesdriverprovisioning!; set => this.AssertWritable()._deploymentservicesdriverprovisioning = value; }
    /// <summary>Windows Deployment Services (WDS) Multicast Server</summary>
    public IMessageDescription DeploymentServicesMulticastServer { get => _deploymentservicesmulticastserver!; set => this.AssertWritable()._deploymentservicesmulticastserver = value; }
    /// <summary>Windows Deployment Services (WDS) Multicast Client</summary>
    public IMessageDescription DeploymentServicesMulticastClient { get => _deploymentservicesmulticastclient!; set => this.AssertWritable()._deploymentservicesmulticastclient = value; }
    /// <summary>Windows Deployment Services (WDS) Content Provider</summary>
    public IMessageDescription DeploymentServicesContentProvider { get => _deploymentservicescontentprovider!; set => this.AssertWritable()._deploymentservicescontentprovider = value; }
    /// <summary>LINGUISTIC_SERVICES</summary>
    public IMessageDescription Linguistic_services { get => _linguistic_services!; set => this.AssertWritable()._linguistic_services = value; }
    /// <summary>WEB</summary>
    public IMessageDescription Web { get => _web!; set => this.AssertWritable()._web = value; }
    /// <summary>WEB_SOCKET</summary>
    public IMessageDescription WebSocket { get => _websocket!; set => this.AssertWritable()._websocket = value; }
    /// <summary>AUDIOSTREAMING</summary>
    public IMessageDescription AudioStreaming { get => _audiostreaming!; set => this.AssertWritable()._audiostreaming = value; }
    /// <summary>ACCELERATOR</summary>
    public IMessageDescription Accelerator { get => _accelerator!; set => this.AssertWritable()._accelerator = value; }
    /// <summary>MOBILE</summary>
    public IMessageDescription Mobile { get => _mobile!; set => this.AssertWritable()._mobile = value; }
    /// <summary>WMAAECMA</summary>
    public IMessageDescription Wmaaecma { get => _wmaaecma!; set => this.AssertWritable()._wmaaecma = value; }
    /// <summary>WEP Encryption (Wired Equivalent Privacy)</summary>
    public IMessageDescription Wep { get => _wep!; set => this.AssertWritable()._wep = value; }
    /// <summary>SYNCENGINE</summary>
    public IMessageDescription SyncEngine { get => _syncengine!; set => this.AssertWritable()._syncengine = value; }
    /// <summary>Direct Music (part of DirectX) - Audio</summary>
    public IMessageDescription DirectMusic { get => _directmusic!; set => this.AssertWritable()._directmusic = value; }
    /// <summary>Direct3D 10</summary>
    public IMessageDescription Direct3d10 { get => _direct3d10!; set => this.AssertWritable()._direct3d10 = value; }
    /// <summary>DirectX Graphics Infrastructure</summary>
    public IMessageDescription Dxgi { get => _dxgi!; set => this.AssertWritable()._dxgi = value; }
    /// <summary>DirectX Graphics Infrastructure Device Driver Interface</summary>
    public IMessageDescription Dxgi_ddi { get => _dxgi_ddi!; set => this.AssertWritable()._dxgi_ddi = value; }
    /// <summary>Direct3D 11</summary>
    public IMessageDescription Direct3d11 { get => _direct3d11!; set => this.AssertWritable()._direct3d11 = value; }
    /// <summary>XAudio2 Internal Errors</summary>
    public IMessageDescription Leap { get => _leap!; set => this.AssertWritable()._leap = value; }
    /// <summary>Audio Client</summary>
    public IMessageDescription Audclnt { get => _audclnt!; set => this.AssertWritable()._audclnt = value; }
    /// <summary>DirectWrite (part of DirectX) - Text layout and glyph rendering</summary>
    public IMessageDescription WincodecDwriteDwm { get => _wincodecdwritedwm!; set => this.AssertWritable()._wincodecdwritedwm = value; }
    /// <summary>Direct 2D (hardware accelerated GUI rendering)</summary>
    public IMessageDescription Direct2d { get => _direct2d!; set => this.AssertWritable()._direct2d = value; }
    /// <summary>Defragging</summary>
    public IMessageDescription Defrag { get => _defrag!; set => this.AssertWritable()._defrag = value; }
    /// <summary>SD (Secure Digital) Bus - SD Card</summary>
    public IMessageDescription Usermode_sdbus { get => _usermode_sdbus!; set => this.AssertWritable()._usermode_sdbus = value; }
    /// <summary>Javascript</summary>
    public IMessageDescription Jscript { get => _jscript!; set => this.AssertWritable()._jscript = value; }
    /// <summary>PIDGENX</summary>
    public IMessageDescription Pidgenx { get => _pidgenx!; set => this.AssertWritable()._pidgenx = value; }
    /// <summary>Avalanche.*</summary>
    public IMessageDescription Avalanche { get => _avalanche!; set => this.AssertWritable()._avalanche = value; }
    /// <summary>mscorlib.dll resource codes</summary>
    public IMessageDescription Mscorlib { get => _mscorlib!; set => this.AssertWritable()._mscorlib = value; }

    /// <summary>Initialize fields</summary>
    public override FacilityMessages Initialize() 
    {
        base.Initialize();
        Add(_basic = new MessageDescription("NULL", 0x00000000, new ParameterlessText("Basic status codes")).SetHResult(0x00000000));
        Add(_rpc = new MessageDescription("RPC", 0x00010000, new ParameterlessText("Remote Procedure Call")).SetHResult(0x00010000));
        Add(_dispatch = new MessageDescription("DISPATCH", 0x00020000, new ParameterlessText("COM Dispatch")).SetHResult(0x00020000));
        Add(_storage = new MessageDescription("STORAGE", 0x00030000, new ParameterlessText("OLE Storage")).SetHResult(0x00030000));
        Add(_itf = new MessageDescription("ITF", 0x00040000, new ParameterlessText("COM/OLE Interface management")).SetHResult(0x00040000));
        Add(_win32 = new MessageDescription("WIN32", 0x00070000, new ParameterlessText("Win32")).SetHResult(0x00070000));
        Add(_windows = new MessageDescription("WINDOWS", 0x00080000, new ParameterlessText("Windows subsystem")).SetHResult(0x00080000));
        Add(_sspi = new MessageDescription("SSPI", 0x00090000, new ParameterlessText("Security API layer")).SetHResult(0x00090000));
        Add(_control = new MessageDescription("CONTROL", 0x000A0000, new ParameterlessText("Control mechanism")).SetHResult(0x000A0000));
        Add(_cert = new MessageDescription("CERT", 0x000B0000, new ParameterlessText("Certificate client or server")).SetHResult(0x000B0000));
        Add(_internet = new MessageDescription("INTERNET", 0x000C0000, new ParameterlessText("Wininet related")).SetHResult(0x000C0000));
        Add(_mediaserver = new MessageDescription("MEDIASERVER", 0x000D0000, new ParameterlessText("Windows Media Server")).SetHResult(0x000D0000));
        Add(_msmq = new MessageDescription("MSMQ", 0x000E0000, new ParameterlessText("Microsoft Message Queue")).SetHResult(0x000E0000));
        Add(_setupapi = new MessageDescription("SETUPAPI", 0x000F0000, new ParameterlessText("Setup API")).SetHResult(0x000F0000));
        Add(_scard = new MessageDescription("SCARD", 0x00100000, new ParameterlessText("Smart-card subsystem")).SetHResult(0x00100000));
        Add(_complus = new MessageDescription("COMPLUS", 0x00110000, new ParameterlessText("COM+")).SetHResult(0x00110000));
        Add(_aaf = new MessageDescription("AAF", 0x00120000, new ParameterlessText("Microsoft agent")).SetHResult(0x00120000));
        Add(_clr = new MessageDescription("URT", 0x00130000, new ParameterlessText(".NET CLR (Common Language Runtime)")).SetHResult(0x00130000));
        Add(_acs = new MessageDescription("ACS", 0x00140000, new ParameterlessText("Audit collection service")).SetHResult(0x00140000));
        Add(_dplay = new MessageDescription("DPLAY", 0x00150000, new ParameterlessText("Direct Play")).SetHResult(0x00150000));
        Add(_umi = new MessageDescription("UMI", 0x00160000, new ParameterlessText("Ubiquitous memoryintrospection service")).SetHResult(0x00160000));
        Add(_sxs = new MessageDescription("SXS", 0x00170000, new ParameterlessText("Side-by-side servicing")).SetHResult(0x00170000));
        Add(_windowsce = new MessageDescription("WINDOWS_CE", 0x00180000, new ParameterlessText("Windows CE")).SetHResult(0x00180000));
        Add(_http = new MessageDescription("HTTP", 0x00190000, new ParameterlessText("HTTP support")).SetHResult(0x00190000));
        Add(_usermodecommonlog = new MessageDescription("USERMODE_COMMONLOG", 0x001A0000, new ParameterlessText("Common Logging")).SetHResult(0x001A0000));
        Add(_usermodefiltermanager = new MessageDescription("USERMODE_FILTER_MANAGER", 0x001F0000, new ParameterlessText("User mode filter manager")).SetHResult(0x001F0000));
        Add(_backgroundcopy = new MessageDescription("BACKGROUNDCOPY", 0x00200000, new ParameterlessText("Background copy control")).SetHResult(0x00200000));
        Add(_configuration = new MessageDescription("CONFIGURATION", 0x00210000, new ParameterlessText("Configuration services")).SetHResult(0x00210000));
        Add(_statemanagement = new MessageDescription("STATE_MANAGEMENT", 0x00220000, new ParameterlessText("State management services")).SetHResult(0x00220000));
        Add(_metadirectory = new MessageDescription("METADIRECTORY", 0x00230000, new ParameterlessText("Microsoft Identity Server")).SetHResult(0x00230000));
        Add(_windowsupdate = new MessageDescription("WINDOWSUPDATE", 0x00240000, new ParameterlessText("Windows update")).SetHResult(0x00240000));
        Add(_directoryservice = new MessageDescription("DIRECTORYSERVICE", 0x00250000, new ParameterlessText("Active Directory")).SetHResult(0x00250000));
        Add(_graphics = new MessageDescription("GRAPHICS", 0x00260000, new ParameterlessText("Graphics drivers")).SetHResult(0x00260000));
        Add(_shell = new MessageDescription("SHELL", 0x00270000, new ParameterlessText("User Shell")).SetHResult(0x00270000));
        Add(_tpmservices = new MessageDescription("TPM_SERVICES", 0x00280000, new ParameterlessText("Trusted Platform Module services")).SetHResult(0x00280000));
        Add(_tpmsoftware = new MessageDescription("TPM_SOFTWARE", 0x00290000, new ParameterlessText("Trusted Platform Module applications")).SetHResult(0x00290000));
        Add(_pla = new MessageDescription("PLA", 0x00300000, new ParameterlessText("Performance Logs and Alerts")).SetHResult(0x00300000));
        Add(_fve = new MessageDescription("FVE", 0x00310000, new ParameterlessText("Full volume encryption")).SetHResult(0x00310000));
        Add(_fwp = new MessageDescription("FWP", 0x00320000, new ParameterlessText("Firewall Platform")).SetHResult(0x00320000));
        Add(_winrm = new MessageDescription("WINRM", 0x00330000, new ParameterlessText("Windows Resource Manager")).SetHResult(0x00330000));
        Add(_ndis = new MessageDescription("NDIS", 0x00340000, new ParameterlessText("Network Driver Interface")).SetHResult(0x00340000));
        Add(_usermodehypervisor = new MessageDescription("USERMODE_HYPERVISOR", 0x00350000, new ParameterlessText("Usermode Hypervisor components")).SetHResult(0x00350000));
        Add(_cmi = new MessageDescription("CMI", 0x00360000, new ParameterlessText("Configuration Management Infrastructure")).SetHResult(0x00360000));
        Add(_usermodevirtualization = new MessageDescription("USERMODE_VIRTUALIZATION", 0x00370000, new ParameterlessText("User mode virtualization subsystem")).SetHResult(0x00370000));
        Add(_usermodevolmgr = new MessageDescription("USERMODE_VOLMGR", 0x00380000, new ParameterlessText("User mode volume manager")).SetHResult(0x00380000));
        Add(_bcd = new MessageDescription("BCD", 0x00390000, new ParameterlessText("Boot Configuration Database")).SetHResult(0x00390000));
        Add(_usermodevhd = new MessageDescription("USERMODE_VHD", 0x003A0000, new ParameterlessText("User mode virtual hard disk support")).SetHResult(0x003A0000));
        Add(_sdiag = new MessageDescription("SDIAG", 0x003C0000, new ParameterlessText("System Diagnostics")).SetHResult(0x003C0000));
        Add(_webservices = new MessageDescription("WEBSERVICES", 0x003D0000, new ParameterlessText("Web Services")).SetHResult(0x003D0000));
        Add(_windowsdefender = new MessageDescription("WINDOWS_DEFENDER", 0x00500000, new ParameterlessText("Windows Defender component")).SetHResult(0x00500000));
        Add(_opc = new MessageDescription("OPC", 0x00510000, new ParameterlessText("Open connectivity service")).SetHResult(0x00510000));
        Add(_dlt = new MessageDescription("DLT", 0x05EA0000, new ParameterlessText("Distributed Link Tracking")).SetHResult(0x05EA0000));
        Add(_wer = new MessageDescription("WER", 0x001B0000, new ParameterlessText("Wired Equivalent Privacy Encryption")).SetHResult(0x001B0000));
        Add(_ui = new MessageDescription("UI", 0x002A0000, new ParameterlessText("User Interface")).SetHResult(0x002A0000));
        Add(_xaml = new MessageDescription("XAML", 0x002B0000, new ParameterlessText("eXtended Application Markup Language")).SetHResult(0x002B0000));
        Add(_actionqueue = new MessageDescription("ACTION_QUEUE", 0x002C0000, new ParameterlessText("")).SetHResult(0x002C0000));
        Add(_wpn = new MessageDescription("WPN", 0x003E0000, new ParameterlessText("Notification Platform")).SetHResult(0x003E0000));
        Add(_windowsstore = new MessageDescription("WINDOWS_STORE", 0x003F0000, new ParameterlessText("Windows Store")).SetHResult(0x003F0000));
        Add(_input = new MessageDescription("INPUT", 0x00400000, new ParameterlessText("Input")).SetHResult(0x00400000));
        Add(_eap = new MessageDescription("EAP", 0x00420000, new ParameterlessText("Extensible Authentication Protocol")).SetHResult(0x00420000));
        Add(_xps = new MessageDescription("XPS", 0x00520000, new ParameterlessText("XPS (XML Paper Specification) Document")).SetHResult(0x00520000));
        Add(_ras = new MessageDescription("RAS", 0x00530000, new ParameterlessText("")).SetHResult(0x00530000));
        Add(_mbn = new MessageDescription("MBN", 0x00540000, new ParameterlessText("")).SetHResult(0x00540000));
        Add(_eas = new MessageDescription("EAS", 0x00550000, new ParameterlessText("Exchange Active Synchronization")).SetHResult(0x00550000));
        Add(_p2pint = new MessageDescription("P2P_INT", 0x00620000, new ParameterlessText("")).SetHResult(0x00620000));
        Add(_p2p = new MessageDescription("P2P", 0x00630000, new ParameterlessText("Peer Graphing API")).SetHResult(0x00630000));
        Add(_daf = new MessageDescription("DAF", 0x00640000, new ParameterlessText("")).SetHResult(0x00640000));
        Add(_bluetootatt = new MessageDescription("BLUETOOTH_ATT", 0x00650000, new ParameterlessText("Bluetooth ATT (Attribute Protocol)")).SetHResult(0x00650000));
        Add(_audio = new MessageDescription("AUDIO", 0x00660000, new ParameterlessText("Audio")).SetHResult(0x00660000));
        Add(_visualcpp = new MessageDescription("VISUALCPP", 0x006D0000, new ParameterlessText("")).SetHResult(0x006D0000));
        Add(_script = new MessageDescription("SCRIPT", 0x00700000, new ParameterlessText("")).SetHResult(0x00700000));
        Add(_parse = new MessageDescription("PARSE", 0x00710000, new ParameterlessText("")).SetHResult(0x00710000));
        Add(_blb = new MessageDescription("BLB", 0x00780000, new ParameterlessText("")).SetHResult(0x00780000));
        Add(_blbcli = new MessageDescription("BLB_CLI", 0x00790000, new ParameterlessText("")).SetHResult(0x00790000));
        Add(_wsbapp = new MessageDescription("WSBAPP", 0x007A0000, new ParameterlessText("")).SetHResult(0x007A0000));
        Add(_blbui = new MessageDescription("BLBUI", 0x00800000, new ParameterlessText("")).SetHResult(0x00800000));
        Add(_usn = new MessageDescription("USN", 0x00810000, new ParameterlessText("")).SetHResult(0x00810000));
        Add(_usermode_volsnap = new MessageDescription("USERMODE_VOLSNAP", 0x00820000, new ParameterlessText("")).SetHResult(0x00820000));
        Add(_tiering = new MessageDescription("TIERING", 0x00830000, new ParameterlessText("")).SetHResult(0x00830000));
        Add(_wsb_online = new MessageDescription("WSB_ONLINE", 0x00850000, new ParameterlessText("")).SetHResult(0x00850000));
        Add(_online_id = new MessageDescription("ONLINE_ID", 0x00860000, new ParameterlessText("")).SetHResult(0x00860000));
        Add(_dls = new MessageDescription("DLS", 0x00990000, new ParameterlessText("")).SetHResult(0x00990000));
        Add(_sos = new MessageDescription("SOS", 0x00A00000, new ParameterlessText("")).SetHResult(0x00A00000));
        Add(_debugger = new MessageDescription("DEBUGGERS", 0x00B00000, new ParameterlessText("Debugger")).SetHResult(0x00B00000));
        Add(_usermode_spaces = new MessageDescription("USERMODE_SPACES", 0x00E70000, new ParameterlessText("Storage Spaces - Group physicial drives in virtual drives storage pools")).SetHResult(0x00E70000));
        Add(_dmserver = new MessageDescription("DMSERVER", 0x01000000, new ParameterlessText("")).SetHResult(0x01000000));
        Add(_deploymentservicesserver = new MessageDescription("DEPLOYMENT_SERVICES_SERVER", 0x01010000, new ParameterlessText("Windows Deployment Services (WDS) Server")).SetHResult(0x01010000));
        Add(_deploymentservicesimaging = new MessageDescription("DEPLOYMENT_SERVICES_IMAGING", 0x01020000, new ParameterlessText("Windows Deployment Services (WDS) Imaging")).SetHResult(0x01020000));
        Add(_deploymentservicesmanagement = new MessageDescription("DEPLOYMENT_SERVICES_MANAGEMENT", 0x01030000, new ParameterlessText("Windows Deployment Services (WDS) Management")).SetHResult(0x01030000));
        Add(_deploymentservicesutil = new MessageDescription("DEPLOYMENT_SERVICES_UTIL", 0x01040000, new ParameterlessText("Windows Deployment Services (WDS) Util")).SetHResult(0x01040000));
        Add(_deploymentservicesbinlsvc = new MessageDescription("DEPLOYMENT_SERVICES_BINLSVC", 0x01050000, new ParameterlessText("Windows Deployment Services (WDS) Binlsvc")).SetHResult(0x01050000));
        Add(_deploymentservicespxe = new MessageDescription("DEPLOYMENT_SERVICES_PXE", 0x01070000, new ParameterlessText("Windows Deployment Services (WDS) Pxe")).SetHResult(0x01070000));
        Add(_deploymentservicestftp = new MessageDescription("DEPLOYMENT_SERVICES_TFTP", 0x01080000, new ParameterlessText("Windows Deployment Services (WDS) TFP")).SetHResult(0x01080000));
        Add(_deploymentservicestransportmanagement = new MessageDescription("DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT", 0x01100000, new ParameterlessText("Windows Deployment Services (WDS) Transport Manager")).SetHResult(0x01100000));
        Add(_deploymentservicesdriverprovisioning = new MessageDescription("DEPLOYMENT_SERVICES_DRIVER_PROVISIONING", 0x01160000, new ParameterlessText("Windows Deployment Services (WDS) Driver Provisioning")).SetHResult(0x01160000));
        Add(_deploymentservicesmulticastserver = new MessageDescription("DEPLOYMENT_SERVICES_MULTICAST_SERVER", 0x01210000, new ParameterlessText("Windows Deployment Services (WDS) Multicast Server")).SetHResult(0x01210000));
        Add(_deploymentservicesmulticastclient = new MessageDescription("DEPLOYMENT_SERVICES_MULTICAST_CLIENT", 0x01220000, new ParameterlessText("Windows Deployment Services (WDS) Multicast Client")).SetHResult(0x01220000));
        Add(_deploymentservicescontentprovider = new MessageDescription("DEPLOYMENT_SERVICES_CONTENT_PROVIDER", 0x01250000, new ParameterlessText("Windows Deployment Services (WDS) Content Provider")).SetHResult(0x01250000));
        Add(_linguistic_services = new MessageDescription("LINGUISTIC_SERVICES", 0x01310000, new ParameterlessText("")).SetHResult(0x01310000));
        Add(_web = new MessageDescription("WEB", 0x03750000, new ParameterlessText("")).SetHResult(0x03750000));
        Add(_websocket = new MessageDescription("WEB_SOCKET", 0x03760000, new ParameterlessText("")).SetHResult(0x03760000));
        Add(_audiostreaming = new MessageDescription("AUDIOSTREAMING", 0x04460000, new ParameterlessText("")).SetHResult(0x04460000));
        Add(_accelerator = new MessageDescription("ACCELERATOR", 0x06000000, new ParameterlessText("")).SetHResult(0x06000000));
        Add(_mobile = new MessageDescription("MOBILE", 0x07010000, new ParameterlessText("")).SetHResult(0x07010000));
        Add(_wmaaecma = new MessageDescription("WMAAECMA", 0x07CC0000, new ParameterlessText("")).SetHResult(0x07CC0000));
        Add(_wep = new MessageDescription("WEP", 0x08010000, new ParameterlessText("WEP Encryption (Wired Equivalent Privacy)")).SetHResult(0x08010000));
        Add(_syncengine = new MessageDescription("SYNCENGINE", 0x08020000, new ParameterlessText("")).SetHResult(0x08020000));
        Add(_directmusic = new MessageDescription("DIRECTMUSIC", 0x08780000, new ParameterlessText("Direct Music (part of DirectX) - Audio")).SetHResult(0x08780000));
        Add(_direct3d10 = new MessageDescription("DIRECT3D10", 0x08790000, new ParameterlessText("Direct3D 10")).SetHResult(0x08790000));
        Add(_dxgi = new MessageDescription("DXGI", 0x087A0000, new ParameterlessText("DirectX Graphics Infrastructure")).SetHResult(0x087A0000));
        Add(_dxgi_ddi = new MessageDescription("DXGI_DDI", 0x087B0000, new ParameterlessText("DirectX Graphics Infrastructure Device Driver Interface")).SetHResult(0x087B0000));
        Add(_direct3d11 = new MessageDescription("DIRECT3D11", 0x087C0000, new ParameterlessText("Direct3D 11")).SetHResult(0x087C0000));
        Add(_leap = new MessageDescription("LEAP", 0x08880000, new ParameterlessText("XAudio2 Internal Errors")).SetHResult(0x08880000));
        Add(_audclnt = new MessageDescription("AUDCLNT", 0x08890000, new ParameterlessText("Audio Client")).SetHResult(0x08890000));
        Add(_wincodecdwritedwm = new MessageDescription("WINCODEC_DWRITE_DWM", 0x08980000, new ParameterlessText("DirectWrite (part of DirectX) - Text layout and glyph rendering")).SetHResult(0x08980000));
        Add(_direct2d = new MessageDescription("DIRECT2D", 0x08990000, new ParameterlessText("Direct 2D (hardware accelerated GUI rendering)")).SetHResult(0x08990000));
        Add(_defrag = new MessageDescription("DEFRAG", 0x09000000, new ParameterlessText("Defragging")).SetHResult(0x09000000));
        Add(_usermode_sdbus = new MessageDescription("USERMODE_SDBUS", 0x09010000, new ParameterlessText("SD (Secure Digital) Bus - SD Card")).SetHResult(0x09010000));
        Add(_jscript = new MessageDescription("JSCRIPT", 0x09020000, new ParameterlessText("Javascript")).SetHResult(0x09020000));
        Add(_pidgenx = new MessageDescription("PIDGENX", 0x0A010000, new ParameterlessText("")).SetHResult(0x0A010000));
        Add(_avalanche = new MessageDescription("AVALANCHE", 0x20AA0000, new ParameterlessText("Avalanche.*")).SetHResult(0x20AA0000));
        Add(_mscorlib = new MessageDescription("MSCORLIB", 0x23450000, new ParameterlessText("mscorlib.dll resource codes")).SetHResult(0x23450000));
        return this;
    }    

}
