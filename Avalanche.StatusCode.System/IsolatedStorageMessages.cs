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

/// <summary>System.IO.IsolatedStorage.*</summary>
public class IsolatedStorageMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<IsolatedStorageMessages> instance = new Lazy<IsolatedStorageMessages>(() => new IsolatedStorageMessages().Initialize().SetAllReadOnly<IsolatedStorageMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static IsolatedStorageMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0020;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _applicationmissingidentity, _applicationnoevidence, _applicationundefined, _assemblygrantset, _assemblymissingidentity, _assemblynoevidence, _assemblyundefined, _createdirectory, _currentsizeundefined, _deletedirectories;
    IMessageDescription? _deletedirectory, _deletefile, _domaingrantset, _domainmissingidentity, _domainnoevidence, _domainundefined, _exception, _fileopenmode, _init, _notvalidondesktop;
    IMessageDescription? _oldquotalarger, _onlyincreaseuserapplicationstore, _operation, _operationisfs, _path, _quotaisundefined, _scopeinvalid, _scopeurm, _seekorigin, _storenotopen;
    IMessageDescription? _applicationgrantset, _usagewillexceedquota;
    
    /// <summary>Unable to determine application identity of the caller.</summary>
    public IMessageDescription ApplicationMissingIdentity { get => _applicationmissingidentity!; set => this.AssertWritable()._applicationmissingidentity = value; }
    /// <summary>Unable to determine identity of application.</summary>
    public IMessageDescription ApplicationNoEvidence { get => _applicationnoevidence!; set => this.AssertWritable()._applicationnoevidence = value; }
    /// <summary>Application cannot be determined on an Assembly or Domain store.</summary>
    public IMessageDescription ApplicationUndefined { get => _applicationundefined!; set => this.AssertWritable()._applicationundefined = value; }
    /// <summary>Unable to determine granted permission for assembly.</summary>
    public IMessageDescription AssemblyGrantSet { get => _assemblygrantset!; set => this.AssertWritable()._assemblygrantset = value; }
    /// <summary>Unable to determine assembly of the caller.</summary>
    public IMessageDescription AssemblyMissingIdentity { get => _assemblymissingidentity!; set => this.AssertWritable()._assemblymissingidentity = value; }
    /// <summary>Unable to determine identity of assembly.</summary>
    public IMessageDescription AssemblyNoEvidence { get => _assemblynoevidence!; set => this.AssertWritable()._assemblynoevidence = value; }
    /// <summary>Assembly cannot be determined for an Application store.</summary>
    public IMessageDescription AssemblyUndefined { get => _assemblyundefined!; set => this.AssertWritable()._assemblyundefined = value; }
    /// <summary>Unable to create directory.</summary>
    public IMessageDescription CreateDirectory { get => _createdirectory!; set => this.AssertWritable()._createdirectory = value; }
    /// <summary>Current size cannot be determined for this store.</summary>
    public IMessageDescription CurrentSizeUndefined { get => _currentsizeundefined!; set => this.AssertWritable()._currentsizeundefined = value; }
    /// <summary>Unable to delete; directory or files in the directory could be in use.</summary>
    public IMessageDescription DeleteDirectories { get => _deletedirectories!; set => this.AssertWritable()._deletedirectories = value; }
    /// <summary>Unable to delete, directory not empty or does not exist.</summary>
    public IMessageDescription DeleteDirectory { get => _deletedirectory!; set => this.AssertWritable()._deletedirectory = value; }
    /// <summary>Unable to delete file.</summary>
    public IMessageDescription DeleteFile { get => _deletefile!; set => this.AssertWritable()._deletefile = value; }
    /// <summary>Unable to determine granted permission for domain.</summary>
    public IMessageDescription DomainGrantSet { get => _domaingrantset!; set => this.AssertWritable()._domaingrantset = value; }
    /// <summary>Unable to determine domain of the caller.</summary>
    public IMessageDescription DomainMissingIdentity { get => _domainmissingidentity!; set => this.AssertWritable()._domainmissingidentity = value; }
    /// <summary>Unable to determine the identity of domain.</summary>
    public IMessageDescription DomainNoEvidence { get => _domainnoevidence!; set => this.AssertWritable()._domainnoevidence = value; }
    /// <summary>Domain cannot be determined on an Assembly or Application store.</summary>
    public IMessageDescription DomainUndefined { get => _domainundefined!; set => this.AssertWritable()._domainundefined = value; }
    /// <summary>System.IO.IsolatedStorage</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>Invalid mode, see System.IO.FileMode.</summary>
    public IMessageDescription FileOpenMode { get => _fileopenmode!; set => this.AssertWritable()._fileopenmode = value; }
    /// <summary>Initialization failed.</summary>
    public IMessageDescription Init { get => _init!; set => this.AssertWritable()._init = value; }
    /// <summary>The Site scope is currently not supported.</summary>
    public IMessageDescription NotValidOnDesktop { get => _notvalidondesktop!; set => this.AssertWritable()._notvalidondesktop = value; }
    /// <summary>The new quota must be larger than the old quota.</summary>
    public IMessageDescription OldQuotaLarger { get => _oldquotalarger!; set => this.AssertWritable()._oldquotalarger = value; }
    /// <summary>Increasing the quota of this scope is not supported. Only the user application scope’s quota can be increased.</summary>
    public IMessageDescription OnlyIncreaseUserApplicationStore { get => _onlyincreaseuserapplicationstore!; set => this.AssertWritable()._onlyincreaseuserapplicationstore = value; }
    /// <summary>Operation not permitted.</summary>
    public IMessageDescription Operation { get => _operation!; set => this.AssertWritable()._operation = value; }
    /// <summary>Operation not permitted on IsolatedStorageFileStream.</summary>
    public IMessageDescription OperationISFS { get => _operationisfs!; set => this.AssertWritable()._operationisfs = value; }
    /// <summary>Path must be a valid file name.</summary>
    public IMessageDescription Path { get => _path!; set => this.AssertWritable()._path = value; }
    /// <summary>{0} is not defined for this store. An operation was performed that requires access to {0}. Stores obtained using enumeration APIs do not have a well-defined {0}, since partial evidence is used to open the store.</summary>
    public IMessageDescription QuotaIsUndefined { get => _quotaisundefined!; set => this.AssertWritable()._quotaisundefined = value; }
    /// <summary>Invalid scope.</summary>
    public IMessageDescription ScopeInvalid { get => _scopeinvalid!; set => this.AssertWritable()._scopeinvalid = value; }
    /// <summary>Invalid scope, expected User, User|Roaming or Machine.</summary>
    public IMessageDescription ScopeURM { get => _scopeurm!; set => this.AssertWritable()._scopeurm = value; }
    /// <summary>Invalid origin, see System.IO.SeekOrigin.</summary>
    public IMessageDescription SeekOrigin { get => _seekorigin!; set => this.AssertWritable()._seekorigin = value; }
    /// <summary>Store must be open for this operation.</summary>
    public IMessageDescription StoreNotOpen { get => _storenotopen!; set => this.AssertWritable()._storenotopen = value; }
    /// <summary>Unable to determine granted permission for application.</summary>
    public IMessageDescription ApplicationGrantSet { get => _applicationgrantset!; set => this.AssertWritable()._applicationgrantset = value; }
    /// <summary>There is not enough free space to perform the operation.</summary>
    public IMessageDescription UsageWillExceedQuota { get => _usagewillexceedquota!; set => this.AssertWritable()._usagewillexceedquota = value; }

    /// <summary>Initialize fields</summary>
    public override IsolatedStorageMessages Initialize() 
    {
        base.Initialize();
        Add(_applicationmissingidentity = new MessageDescription("mscorlib.IsolatedStorage_ApplicationMissingIdentity", 0xA3450425, new ParameterlessText("Unable to determine application identity of the caller.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_applicationnoevidence = new MessageDescription("mscorlib.IsolatedStorage_ApplicationNoEvidence", 0xA3450426, new ParameterlessText("Unable to determine identity of application.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_applicationundefined = new MessageDescription("mscorlib.IsolatedStorage_ApplicationUndefined", 0xA3450427, new ParameterlessText("Application cannot be determined on an Assembly or Domain store.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_assemblygrantset = new MessageDescription("mscorlib.IsolatedStorage_AssemblyGrantSet", 0xA3450428, new ParameterlessText("Unable to determine granted permission for assembly.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_assemblymissingidentity = new MessageDescription("mscorlib.IsolatedStorage_AssemblyMissingIdentity", 0xA3450429, new ParameterlessText("Unable to determine assembly of the caller.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_assemblynoevidence = new MessageDescription("mscorlib.IsolatedStorage_AssemblyNoEvidence", 0xA345042A, new ParameterlessText("Unable to determine identity of assembly.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_assemblyundefined = new MessageDescription("mscorlib.IsolatedStorage_AssemblyUndefined", 0xA345042B, new ParameterlessText("Assembly cannot be determined for an Application store.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_createdirectory = new MessageDescription("mscorlib.IsolatedStorage_CreateDirectory", 0xA345042C, new ParameterlessText("Unable to create directory.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_currentsizeundefined = new MessageDescription("mscorlib.IsolatedStorage_CurrentSizeUndefined", 0xA345042D, new ParameterlessText("Current size cannot be determined for this store.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_deletedirectories = new MessageDescription("mscorlib.IsolatedStorage_DeleteDirectories", 0xA345042E, new ParameterlessText("Unable to delete; directory or files in the directory could be in use.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_deletedirectory = new MessageDescription("mscorlib.IsolatedStorage_DeleteDirectory", 0xA345042F, new ParameterlessText("Unable to delete, directory not empty or does not exist.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_deletefile = new MessageDescription("mscorlib.IsolatedStorage_DeleteFile", 0xA3450430, new ParameterlessText("Unable to delete file.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_domaingrantset = new MessageDescription("mscorlib.IsolatedStorage_DomainGrantSet", 0xA3450431, new ParameterlessText("Unable to determine granted permission for domain.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_domainmissingidentity = new MessageDescription("mscorlib.IsolatedStorage_DomainMissingIdentity", 0xA3450432, new ParameterlessText("Unable to determine domain of the caller.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_domainnoevidence = new MessageDescription("mscorlib.IsolatedStorage_DomainNoEvidence", 0xA3450433, new ParameterlessText("Unable to determine the identity of domain.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_domainundefined = new MessageDescription("mscorlib.IsolatedStorage_DomainUndefined", 0xA3450434, new ParameterlessText("Domain cannot be determined on an Assembly or Application store.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_exception = new MessageDescription("mscorlib.IsolatedStorage_Exception", 0xA3450435, new ParameterlessText("An error occurred while accessing IsolatedStorage.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetDescription("System.IO.IsolatedStorage").SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_fileopenmode = new MessageDescription("mscorlib.IsolatedStorage_FileOpenMode", 0xA3450436, new ParameterlessText("Invalid mode, see System.IO.FileMode.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_init = new MessageDescription("mscorlib.IsolatedStorage_Init", 0xA3450437, new ParameterlessText("Initialization failed.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_notvalidondesktop = new MessageDescription("mscorlib.IsolatedStorage_NotValidOnDesktop", 0xA3450438, new ParameterlessText("The Site scope is currently not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_oldquotalarger = new MessageDescription("mscorlib.IsolatedStorage_OldQuotaLarger", 0xA3450439, new ParameterlessText("The new quota must be larger than the old quota.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_onlyincreaseuserapplicationstore = new MessageDescription("mscorlib.IsolatedStorage_OnlyIncreaseUserApplicationStore", 0xA345043A, new ParameterlessText("Increasing the quota of this scope is not supported.  Only the user application scope’s quota can be increased.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_operation = new MessageDescription("mscorlib.IsolatedStorage_Operation", 0xA345043B, new ParameterlessText("Operation not permitted.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_operationisfs = new MessageDescription("mscorlib.IsolatedStorage_Operation_ISFS", 0xA345043C, new ParameterlessText("Operation not permitted on IsolatedStorageFileStream.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_path = new MessageDescription("mscorlib.IsolatedStorage_Path", 0xA345043D, new ParameterlessText("Path must be a valid file name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_quotaisundefined = new MessageDescription("mscorlib.IsolatedStorage_QuotaIsUndefined", 0xA345043E, new FormatText("{0} is not defined for this store. An operation was performed that requires access to {0}. Stores obtained using enumeration APIs do not have a well-defined {0}, since partial evidence is used to open the store.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_scopeinvalid = new MessageDescription("mscorlib.IsolatedStorage_Scope_Invalid", 0xA345043F, new ParameterlessText("Invalid scope.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_scopeurm = new MessageDescription("mscorlib.IsolatedStorage_Scope_U_R_M", 0xA3450440, new ParameterlessText("Invalid scope, expected User, User|Roaming or Machine.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_seekorigin = new MessageDescription("mscorlib.IsolatedStorage_SeekOrigin", 0xA3450441, new ParameterlessText("Invalid origin, see System.IO.SeekOrigin.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_storenotopen = new MessageDescription("mscorlib.IsolatedStorage_StoreNotOpen", 0xA3450442, new ParameterlessText("Store must be open for this operation.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_applicationgrantset = new MessageDescription("mscorlib.IsolatedStorage_ApplicationGrantSet", 0xA34506DB, new ParameterlessText("Unable to determine granted permission for application.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        Add(_usagewillexceedquota = new MessageDescription("mscorlib.IsolatedStorage_UsageWillExceedQuota", 0xA34506DC, new ParameterlessText("There is not enough free space to perform the operation.")).SetHResult(0x80131450).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IsolatedStorage.IsolatedStorageException)));
        return this;
    }    

}
