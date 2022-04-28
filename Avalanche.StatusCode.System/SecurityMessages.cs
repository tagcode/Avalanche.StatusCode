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

/// <summary>System.Security.*</summary>
public class SecurityMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<SecurityMessages> instance = new Lazy<SecurityMessages>(() => new SecurityMessages().Initialize().SetAllReadOnly<SecurityMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static SecurityMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x001A;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _securityexception, _invalidprivilegename, _anonymouslyhosteddynamicmethodcheckfailed, _cannotgeneratehash, _cannotreadregistrydata, _generic, _genericnotype, _mustrevertoverride, _noaptca, _principalpermission;
    IMessageDescription? _registrypermission, _verificationexception, _zonetostring, _action, _assembly, _cannotgetrawdata, _demanded, _denied, _firstpermthatfailed, _grantedset;
    IMessageDescription? _method, _permitonly, _refusedset, _typefirstpermthatfailed, _url, _zone;
    
    /// <summary>System.Security</summary>
    public IMessageDescription SecurityException { get => _securityexception!; set => this.AssertWritable()._securityexception = value; }
    /// <summary>Privilege &#39;{0}&#39; is not valid on this system.</summary>
    public IMessageDescription InvalidPrivilegeName { get => _invalidprivilegename!; set => this.AssertWritable()._invalidprivilegename = value; }
    /// <summary>The demand failed due to the code access security information captured during the creation of an anonymously hosted dynamic method. In order for this operation to succeed, ensure that the demand would have succeeded at the time the method was created. See http://go.microsoft.com/fwlink/?LinkId=288746 for more information.</summary>
    public IMessageDescription AnonymouslyHostedDynamicMethodCheckFailed { get => _anonymouslyhosteddynamicmethodcheckfailed!; set => this.AssertWritable()._anonymouslyhosteddynamicmethodcheckfailed = value; }
    /// <summary>Hash for the assembly cannot be generated.</summary>
    public IMessageDescription CannotGenerateHash { get => _cannotgeneratehash!; set => this.AssertWritable()._cannotgeneratehash = value; }
    /// <summary>The time zone ID &#39;{0}&#39; was found on the local computer, but the application does not have permission to read the registry information.</summary>
    public IMessageDescription CannotReadRegistryData { get => _cannotreadregistrydata!; set => this.AssertWritable()._cannotreadregistrydata = value; }
    /// <summary>System.Security</summary>
    public IMessageDescription Generic { get => _generic!; set => this.AssertWritable()._generic = value; }
    /// <summary>System.Security</summary>
    public IMessageDescription GenericNoType { get => _genericnotype!; set => this.AssertWritable()._genericnotype = value; }
    /// <summary>Stack walk modifier must be reverted before another modification of the same type can be performed.</summary>
    public IMessageDescription MustRevertOverride { get => _mustrevertoverride!; set => this.AssertWritable()._mustrevertoverride = value; }
    /// <summary>System.Security</summary>
    public IMessageDescription NoAPTCA { get => _noaptca!; set => this.AssertWritable()._noaptca = value; }
    /// <summary>Request for principal permission failed.</summary>
    public IMessageDescription PrincipalPermission { get => _principalpermission!; set => this.AssertWritable()._principalpermission = value; }
    /// <summary>Requested registry access is not allowed.</summary>
    public IMessageDescription RegistryPermission { get => _registrypermission!; set => this.AssertWritable()._registrypermission = value; }
    /// <summary>System.Security</summary>
    public IMessageDescription VerificationException { get => _verificationexception!; set => this.AssertWritable()._verificationexception = value; }
    /// <summary>Zone - {0}</summary>
    public IMessageDescription ZoneToString { get => _zonetostring!; set => this.AssertWritable()._zonetostring = value; }
    /// <summary>The action that failed was:</summary>
    public IMessageDescription Action { get => _action!; set => this.AssertWritable()._action = value; }
    /// <summary>The assembly or AppDomain that failed was:</summary>
    public IMessageDescription Assembly { get => _assembly!; set => this.AssertWritable()._assembly = value; }
    /// <summary>Assembly bytes could not be retrieved.</summary>
    public IMessageDescription CannotGetRawData { get => _cannotgetrawdata!; set => this.AssertWritable()._cannotgetrawdata = value; }
    /// <summary>The demand was for:</summary>
    public IMessageDescription Demanded { get => _demanded!; set => this.AssertWritable()._demanded = value; }
    /// <summary>The denied permissions were:</summary>
    public IMessageDescription Denied { get => _denied!; set => this.AssertWritable()._denied = value; }
    /// <summary>The first permission that failed was:</summary>
    public IMessageDescription FirstPermThatFailed { get => _firstpermthatfailed!; set => this.AssertWritable()._firstpermthatfailed = value; }
    /// <summary>The granted set of the failing assembly was:</summary>
    public IMessageDescription GrantedSet { get => _grantedset!; set => this.AssertWritable()._grantedset = value; }
    /// <summary>The method that caused the failure was:</summary>
    public IMessageDescription Method { get => _method!; set => this.AssertWritable()._method = value; }
    /// <summary>The only permitted permissions were:</summary>
    public IMessageDescription PermitOnly { get => _permitonly!; set => this.AssertWritable()._permitonly = value; }
    /// <summary>The refused set of the failing assembly was:</summary>
    public IMessageDescription RefusedSet { get => _refusedset!; set => this.AssertWritable()._refusedset = value; }
    /// <summary>The type of the first permission that failed was:</summary>
    public IMessageDescription TypeFirstPermThatFailed { get => _typefirstpermthatfailed!; set => this.AssertWritable()._typefirstpermthatfailed = value; }
    /// <summary>The Url of the assembly that failed was:</summary>
    public IMessageDescription Url { get => _url!; set => this.AssertWritable()._url = value; }
    /// <summary>The Zone of the assembly that failed was:</summary>
    public IMessageDescription Zone { get => _zone!; set => this.AssertWritable()._zone = value; }

    /// <summary>Initialize fields</summary>
    public override SecurityMessages Initialize() 
    {
        base.Initialize();
        Add(_securityexception = new MessageDescription("mscorlib.Arg_SecurityException", 0xA34500F3, new ParameterlessText("Security error.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException(typeof(System.Security.SecurityException)));
        Add(_invalidprivilegename = new MessageDescription("mscorlib.Argument_InvalidPrivilegeName", 0xA34501BB, new FormatText("Privilege '{0}' is not valid on this system.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_anonymouslyhosteddynamicmethodcheckfailed = new MessageDescription("mscorlib.Security_AnonymouslyHostedDynamicMethodCheckFailed", 0xA3450563, new ParameterlessText("The demand failed due to the code access security information captured during the creation of an anonymously hosted dynamic method. In order for this operation to succeed, ensure that the demand would have succeeded at the time the method was created. See http://go.microsoft.com/fwlink/?LinkId=288746 for more information.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_cannotgeneratehash = new MessageDescription("mscorlib.Security_CannotGenerateHash", 0xA3450564, new ParameterlessText("Hash for the assembly cannot be generated.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_cannotreadregistrydata = new MessageDescription("mscorlib.Security_CannotReadRegistryData", 0xA3450565, new FormatText("The time zone ID '{0}' was found on the local computer, but the application does not have permission to read the registry information.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_generic = new MessageDescription("mscorlib.Security_Generic", 0xA3450566, new FormatText("Request for the permission of type '{0}' failed.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException(typeof(System.Security.SecurityException)));
        Add(_genericnotype = new MessageDescription("mscorlib.Security_GenericNoType", 0xA3450567, new ParameterlessText("Request failed.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException(typeof(System.Security.SecurityException)));
        Add(_mustrevertoverride = new MessageDescription("mscorlib.Security_MustRevertOverride", 0xA3450568, new ParameterlessText("Stack walk modifier must be reverted before another modification of the same type can be performed.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_noaptca = new MessageDescription("mscorlib.Security_NoAPTCA", 0xA3450569, new ParameterlessText("That assembly does not allow partially trusted callers.")).SetHResult(0x80131640).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException("System.Security.HostProtectionException"));
        Add(_principalpermission = new MessageDescription("mscorlib.Security_PrincipalPermission", 0xA345056A, new ParameterlessText("Request for principal permission failed.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_registrypermission = new MessageDescription("mscorlib.Security_RegistryPermission", 0xA345056B, new ParameterlessText("Requested registry access is not allowed.")).SetHResult(0x8013150A).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.SecurityException)));
        Add(_verificationexception = new MessageDescription("mscorlib.Verification_Exception", 0xA345060C, new ParameterlessText("Operation could destabilize the runtime.")).SetHResult(0x8013150D).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException(typeof(System.Security.VerificationException)));
        Add(_zonetostring = new MessageDescription("mscorlib.Zone_ToString", 0xA3450618, new FormatText("Zone - {0}")).SetHResult(0x80070057).SetSeverity(MessageLevel.Information).SetException(typeof(System.ArgumentException)));
        Add(_action = new MessageDescription("mscorlib.Security_Action", 0xA345073F, new ParameterlessText("The action that failed was:")).SetSeverity(MessageLevel.Error));
        Add(_assembly = new MessageDescription("mscorlib.Security_Assembly", 0xA3450747, new ParameterlessText("The assembly or AppDomain that failed was:")).SetSeverity(MessageLevel.Error));
        Add(_cannotgetrawdata = new MessageDescription("mscorlib.Security_CannotGetRawData", 0xA345073E, new ParameterlessText("Assembly bytes could not be retrieved.")).SetSeverity(MessageLevel.Error));
        Add(_demanded = new MessageDescription("mscorlib.Security_Demanded", 0xA3450742, new ParameterlessText("The demand was for:")).SetSeverity(MessageLevel.Error));
        Add(_denied = new MessageDescription("mscorlib.Security_Denied", 0xA3450745, new ParameterlessText("The denied permissions were:")).SetSeverity(MessageLevel.Error));
        Add(_firstpermthatfailed = new MessageDescription("mscorlib.Security_FirstPermThatFailed", 0xA3450741, new ParameterlessText("The first permission that failed was:")).SetSeverity(MessageLevel.Error));
        Add(_grantedset = new MessageDescription("mscorlib.Security_GrantedSet", 0xA3450743, new ParameterlessText("The granted set of the failing assembly was:")).SetSeverity(MessageLevel.Error));
        Add(_method = new MessageDescription("mscorlib.Security_Method", 0xA3450748, new ParameterlessText("The method that caused the failure was:")).SetSeverity(MessageLevel.Error));
        Add(_permitonly = new MessageDescription("mscorlib.Security_PermitOnly", 0xA3450746, new ParameterlessText("The only permitted permissions were:")).SetSeverity(MessageLevel.Error));
        Add(_refusedset = new MessageDescription("mscorlib.Security_RefusedSet", 0xA3450744, new ParameterlessText("The refused set of the failing assembly was:")).SetSeverity(MessageLevel.Error));
        Add(_typefirstpermthatfailed = new MessageDescription("mscorlib.Security_TypeFirstPermThatFailed", 0xA3450740, new ParameterlessText("The type of the first permission that failed was:")).SetSeverity(MessageLevel.Error));
        Add(_url = new MessageDescription("mscorlib.Security_Url", 0xA345074A, new ParameterlessText("The Url of the assembly that failed was:")).SetSeverity(MessageLevel.Error));
        Add(_zone = new MessageDescription("mscorlib.Security_Zone", 0xA3450749, new ParameterlessText("The Zone of the assembly that failed was:")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
