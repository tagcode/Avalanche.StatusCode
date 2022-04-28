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

/// <summary>System.Security.AccessControl.*</summary>
public class AccessControlMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<AccessControlMessages> instance = new Lazy<AccessControlMessages>(() => new AccessControlMessages().Initialize().SetAllReadOnly<AccessControlMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static AccessControlMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0017;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _acltoolong, _invalidaccessruletype, _invalidauditruletype, _invalidgroup, _invalidhandle, _invalidowner, _invalidsecuritydescriptorrevision, _invalidsecuritydescriptorselfrelativeform, _invalidsidinsddlstring, _mustspecifycontaineracl;
    IMessageDescription? _mustspecifydirectoryobjectacl, _mustspecifyleafobjectacl, _mustspecifynondirectoryobjectacl, _noassociatedsecurity, _unexpectederror, _nothelddefault, _notheldnamed, _iodeniednopathname, _iodeniedpath, _memstreambuffer;
    IMessageDescription? _registrykeygenerickey, _registrynowrite, _systemdomain;
    
    /// <summary>Length of the access control list exceed the allowed maximum.</summary>
    public IMessageDescription AclTooLong { get => _acltoolong!; set => this.AssertWritable()._acltoolong = value; }
    /// <summary>The access rule is not the correct type.</summary>
    public IMessageDescription InvalidAccessRuleType { get => _invalidaccessruletype!; set => this.AssertWritable()._invalidaccessruletype = value; }
    /// <summary>The audit rule is not the correct type.</summary>
    public IMessageDescription InvalidAuditRuleType { get => _invalidauditruletype!; set => this.AssertWritable()._invalidauditruletype = value; }
    /// <summary>The security identifier is not allowed to be the primary group of this object.</summary>
    public IMessageDescription InvalidGroup { get => _invalidgroup!; set => this.AssertWritable()._invalidgroup = value; }
    /// <summary>The supplied handle is invalid. This can happen when trying to set an ACL on an anonymous kernel object.</summary>
    public IMessageDescription InvalidHandle { get => _invalidhandle!; set => this.AssertWritable()._invalidhandle = value; }
    /// <summary>The security identifier is not allowed to be the owner of this object.</summary>
    public IMessageDescription InvalidOwner { get => _invalidowner!; set => this.AssertWritable()._invalidowner = value; }
    /// <summary>Security descriptor with revision other than &#39;1&#39; are not legal.</summary>
    public IMessageDescription InvalidSecurityDescriptorRevision { get => _invalidsecuritydescriptorrevision!; set => this.AssertWritable()._invalidsecuritydescriptorrevision = value; }
    /// <summary>Security descriptor must be in the self-relative form.</summary>
    public IMessageDescription InvalidSecurityDescriptorSelfRelativeForm { get => _invalidsecuritydescriptorselfrelativeform!; set => this.AssertWritable()._invalidsecuritydescriptorselfrelativeform = value; }
    /// <summary>The SDDL string contains an invalid sid or a sid that cannot be translated.</summary>
    public IMessageDescription InvalidSidInSDDLString { get => _invalidsidinsddlstring!; set => this.AssertWritable()._invalidsidinsddlstring = value; }
    /// <summary>The named parameter must be a container ACL.</summary>
    public IMessageDescription MustSpecifyContainerAcl { get => _mustspecifycontaineracl!; set => this.AssertWritable()._mustspecifycontaineracl = value; }
    /// <summary>The named parameter must be a directory-object ACL.</summary>
    public IMessageDescription MustSpecifyDirectoryObjectAcl { get => _mustspecifydirectoryobjectacl!; set => this.AssertWritable()._mustspecifydirectoryobjectacl = value; }
    /// <summary>The named parameter must be a non-container ACL.</summary>
    public IMessageDescription MustSpecifyLeafObjectAcl { get => _mustspecifyleafobjectacl!; set => this.AssertWritable()._mustspecifyleafobjectacl = value; }
    /// <summary>The named parameter must be a non-directory-object ACL.</summary>
    public IMessageDescription MustSpecifyNonDirectoryObjectAcl { get => _mustspecifynondirectoryobjectacl!; set => this.AssertWritable()._mustspecifynondirectoryobjectacl = value; }
    /// <summary>Unable to perform a security operation on an object that has no associated security. This can happen when trying to get an ACL of an anonymous kernel object.</summary>
    public IMessageDescription NoAssociatedSecurity { get => _noassociatedsecurity!; set => this.AssertWritable()._noassociatedsecurity = value; }
    /// <summary>Method failed with unexpected error code {0}.</summary>
    public IMessageDescription UnexpectedError { get => _unexpectederror!; set => this.AssertWritable()._unexpectederror = value; }
    /// <summary>System.Security.AccessControl</summary>
    public IMessageDescription NotHeldDefault { get => _nothelddefault!; set => this.AssertWritable()._nothelddefault = value; }
    /// <summary>System.Security.AccessControl</summary>
    public IMessageDescription NotHeldNamed { get => _notheldnamed!; set => this.AssertWritable()._notheldnamed = value; }
    /// <summary>Access to the path is denied.</summary>
    public IMessageDescription IODeniedNoPathName { get => _iodeniednopathname!; set => this.AssertWritable()._iodeniednopathname = value; }
    /// <summary>Access to the path &#39;{0}&#39; is denied.</summary>
    public IMessageDescription IODeniedPath { get => _iodeniedpath!; set => this.AssertWritable()._iodeniedpath = value; }
    /// <summary>MemoryStream&#39;s internal buffer cannot be accessed.</summary>
    public IMessageDescription MemStreamBuffer { get => _memstreambuffer!; set => this.AssertWritable()._memstreambuffer = value; }
    /// <summary>Access to the registry key &#39;{0}&#39; is denied.</summary>
    public IMessageDescription RegistryKeyGenericKey { get => _registrykeygenerickey!; set => this.AssertWritable()._registrykeygenerickey = value; }
    /// <summary>Cannot write to the registry key.</summary>
    public IMessageDescription RegistryNoWrite { get => _registrynowrite!; set => this.AssertWritable()._registrynowrite = value; }
    /// <summary>Cannot execute an assembly in the system domain.</summary>
    public IMessageDescription SystemDomain { get => _systemdomain!; set => this.AssertWritable()._systemdomain = value; }

    /// <summary>Initialize fields</summary>
    public override AccessControlMessages Initialize() 
    {
        base.Initialize();
        Add(_acltoolong = new MessageDescription("mscorlib.AccessControl_AclTooLong", 0xA345000C, new ParameterlessText("Length of the access control list exceed the allowed maximum.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_invalidaccessruletype = new MessageDescription("mscorlib.AccessControl_InvalidAccessRuleType", 0xA345000D, new ParameterlessText("The access rule is not the correct type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidauditruletype = new MessageDescription("mscorlib.AccessControl_InvalidAuditRuleType", 0xA345000E, new ParameterlessText("The audit rule is not the correct type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidgroup = new MessageDescription("mscorlib.AccessControl_InvalidGroup", 0xA345000F, new ParameterlessText("The security identifier is not allowed to be the primary group of this object.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidhandle = new MessageDescription("mscorlib.AccessControl_InvalidHandle", 0xA3450010, new ParameterlessText("The supplied handle is invalid. This can happen when trying to set an ACL on an anonymous kernel object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidowner = new MessageDescription("mscorlib.AccessControl_InvalidOwner", 0xA3450011, new ParameterlessText("The security identifier is not allowed to be the owner of this object.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidsecuritydescriptorrevision = new MessageDescription("mscorlib.AccessControl_InvalidSecurityDescriptorRevision", 0xA3450012, new ParameterlessText("Security descriptor with revision other than '1' are not legal.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalidsecuritydescriptorselfrelativeform = new MessageDescription("mscorlib.AccessControl_InvalidSecurityDescriptorSelfRelativeForm", 0xA3450013, new ParameterlessText("Security descriptor must be in the self-relative form.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsidinsddlstring = new MessageDescription("mscorlib.AccessControl_InvalidSidInSDDLString", 0xA3450014, new ParameterlessText("The SDDL string contains an invalid sid or a sid that cannot be translated.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustspecifycontaineracl = new MessageDescription("mscorlib.AccessControl_MustSpecifyContainerAcl", 0xA3450015, new ParameterlessText("The named parameter must be a container ACL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustspecifydirectoryobjectacl = new MessageDescription("mscorlib.AccessControl_MustSpecifyDirectoryObjectAcl", 0xA3450016, new ParameterlessText("The named parameter must be a directory-object ACL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustspecifyleafobjectacl = new MessageDescription("mscorlib.AccessControl_MustSpecifyLeafObjectAcl", 0xA3450017, new ParameterlessText("The named parameter must be a non-container ACL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustspecifynondirectoryobjectacl = new MessageDescription("mscorlib.AccessControl_MustSpecifyNonDirectoryObjectAcl", 0xA3450018, new ParameterlessText("The named parameter must be a non-directory-object ACL.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_noassociatedsecurity = new MessageDescription("mscorlib.AccessControl_NoAssociatedSecurity", 0xA3450019, new ParameterlessText("Unable to perform a security operation on an object that has no associated security. This can happen when trying to get an ACL of an anonymous kernel object.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_unexpectederror = new MessageDescription("mscorlib.AccessControl_UnexpectedError", 0xA345001A, new FormatText("Method failed with unexpected error code {0}.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nothelddefault = new MessageDescription("mscorlib.PrivilegeNotHeld_Default", 0xA34504E7, new ParameterlessText("The process does not possess some privilege required for this operation.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetDescription("System.Security.AccessControl").SetException(typeof(System.Security.AccessControl.PrivilegeNotHeldException)));
        Add(_notheldnamed = new MessageDescription("mscorlib.PrivilegeNotHeld_Named", 0xA34504E8, new FormatText("The process does not possess the '{0}' privilege which is required for this operation.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetDescription("System.Security.AccessControl").SetException(typeof(System.Security.AccessControl.PrivilegeNotHeldException)));
        Add(_iodeniednopathname = new MessageDescription("mscorlib.UnauthorizedAccess_IODenied_NoPathName", 0xA3450603, new ParameterlessText("Access to the path is denied.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_iodeniedpath = new MessageDescription("mscorlib.UnauthorizedAccess_IODenied_Path", 0xA3450604, new FormatText("Access to the path '{0}' is denied.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_memstreambuffer = new MessageDescription("mscorlib.UnauthorizedAccess_MemStreamBuffer", 0xA3450605, new ParameterlessText("MemoryStream's internal buffer cannot be accessed.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_registrykeygenerickey = new MessageDescription("mscorlib.UnauthorizedAccess_RegistryKeyGeneric_Key", 0xA3450606, new FormatText("Access to the registry key '{0}' is denied.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_registrynowrite = new MessageDescription("mscorlib.UnauthorizedAccess_RegistryNoWrite", 0xA3450607, new ParameterlessText("Cannot write to the registry key.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_systemdomain = new MessageDescription("mscorlib.UnauthorizedAccess_SystemDomain", 0xA345073D, new ParameterlessText("Cannot execute an assembly in the system domain.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
