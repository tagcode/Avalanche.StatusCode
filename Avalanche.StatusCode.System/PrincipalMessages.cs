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

/// <summary>System.Security.Principal.*</summary>
public class PrincipalMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<PrincipalMessages> instance = new Lazy<PrincipalMessages>(() => new PrincipalMessages().Initialize().SetAllReadOnly<PrincipalMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static PrincipalMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000A;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _accountnametoolong, _cannotcreatelogonidssid, _domainnametoolong, _domainsidrequired, _identifierauthoritytoolarge, _notmapped, _invalidnumberofsubauthorities, _invalidsidrevision, _mustbeidentityreference, _notawindowsdomain;
    
    /// <summary>Account name is too long.</summary>
    public IMessageDescription AccountNameTooLong { get => _accountnametoolong!; set => this.AssertWritable()._accountnametoolong = value; }
    /// <summary>Well-known SIDs of type LogonIdsSid cannot be created.</summary>
    public IMessageDescription CannotCreateLogonIdsSid { get => _cannotcreatelogonidssid!; set => this.AssertWritable()._cannotcreatelogonidssid = value; }
    /// <summary>Domain name is too long.</summary>
    public IMessageDescription DomainNameTooLong { get => _domainnametoolong!; set => this.AssertWritable()._domainnametoolong = value; }
    /// <summary>The domainSid parameter must be specified for creating well-known SID of type {0}.</summary>
    public IMessageDescription DomainSidRequired { get => _domainsidrequired!; set => this.AssertWritable()._domainsidrequired = value; }
    /// <summary>The size of the identifier authority must not exceed 6 bytes.</summary>
    public IMessageDescription IdentifierAuthorityTooLarge { get => _identifierauthoritytoolarge!; set => this.AssertWritable()._identifierauthoritytoolarge = value; }
    /// <summary>System.Security.Principal</summary>
    public IMessageDescription NotMapped { get => _notmapped!; set => this.AssertWritable()._notmapped = value; }
    /// <summary>The number of sub-authorities must not exceed {0}.</summary>
    public IMessageDescription InvalidNumberOfSubauthorities { get => _invalidnumberofsubauthorities!; set => this.AssertWritable()._invalidnumberofsubauthorities = value; }
    /// <summary>SIDs with revision other than &#39;1&#39; are not supported.</summary>
    public IMessageDescription InvalidSidRevision { get => _invalidsidrevision!; set => this.AssertWritable()._invalidsidrevision = value; }
    /// <summary>The targetType parameter must be of IdentityReference type.</summary>
    public IMessageDescription MustBeIdentityReference { get => _mustbeidentityreference!; set => this.AssertWritable()._mustbeidentityreference = value; }
    /// <summary>The domainSid parameter is not a valid Windows domain SID.</summary>
    public IMessageDescription NotAWindowsDomain { get => _notawindowsdomain!; set => this.AssertWritable()._notawindowsdomain = value; }

    /// <summary>Initialize fields</summary>
    public override PrincipalMessages Initialize() 
    {
        base.Initialize();
        Add(_accountnametoolong = new MessageDescription("mscorlib.IdentityReference_AccountNameTooLong", 0xA3450367, new ParameterlessText("Account name is too long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannotcreatelogonidssid = new MessageDescription("mscorlib.IdentityReference_CannotCreateLogonIdsSid", 0xA3450368, new ParameterlessText("Well-known SIDs of type LogonIdsSid cannot be created.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_domainnametoolong = new MessageDescription("mscorlib.IdentityReference_DomainNameTooLong", 0xA3450369, new ParameterlessText("Domain name is too long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_domainsidrequired = new MessageDescription("mscorlib.IdentityReference_DomainSidRequired", 0xA345036A, new FormatText("The domainSid parameter must be specified for creating well-known SID of type {0}.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_identifierauthoritytoolarge = new MessageDescription("mscorlib.IdentityReference_IdentifierAuthorityTooLarge", 0xA345036B, new ParameterlessText("The size of the identifier authority must not exceed 6 bytes.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_notmapped = new MessageDescription("mscorlib.IdentityReference_IdentityNotMapped", 0xA345036C, new ParameterlessText("Some or all identity references could not be translated.")).SetHResult(0x80131621).SetSeverity(MessageLevel.Error).SetDescription("System.Security.Principal").SetException(typeof(System.Security.Principal.IdentityNotMappedException)));
        Add(_invalidnumberofsubauthorities = new MessageDescription("mscorlib.IdentityReference_InvalidNumberOfSubauthorities", 0xA345036D, new FormatText("The number of sub-authorities must not exceed {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidsidrevision = new MessageDescription("mscorlib.IdentityReference_InvalidSidRevision", 0xA345036E, new ParameterlessText("SIDs with revision other than '1' are not supported.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeidentityreference = new MessageDescription("mscorlib.IdentityReference_MustBeIdentityReference", 0xA345036F, new ParameterlessText("The targetType parameter must be of IdentityReference type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notawindowsdomain = new MessageDescription("mscorlib.IdentityReference_NotAWindowsDomain", 0xA3450370, new ParameterlessText("The domainSid parameter is not a valid Windows domain SID.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        return this;
    }    

}
