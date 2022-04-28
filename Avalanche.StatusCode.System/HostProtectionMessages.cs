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

/// <summary>System.Security.HostProtectionException</summary>
public class HostProtectionMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<HostProtectionMessages> instance = new Lazy<HostProtectionMessages>(() => new HostProtectionMessages().Initialize().SetAllReadOnly<HostProtectionMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static HostProtectionMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0003;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _hostprotection, _demandedresources, _protectedresources;
    
    /// <summary>System.Security</summary>
    public IMessageDescription HostProtection { get => _hostprotection!; set => this.AssertWritable()._hostprotection = value; }
    /// <summary>The demanded resources were:</summary>
    public IMessageDescription DemandedResources { get => _demandedresources!; set => this.AssertWritable()._demandedresources = value; }
    /// <summary>The protected resources (only available with full trust) were:</summary>
    public IMessageDescription ProtectedResources { get => _protectedresources!; set => this.AssertWritable()._protectedresources = value; }

    /// <summary>Initialize fields</summary>
    public override HostProtectionMessages Initialize() 
    {
        base.Initialize();
        Add(_hostprotection = new MessageDescription("mscorlib.HostProtection_HostProtection", 0xA3450366, new ParameterlessText("Attempted to perform an operation that was forbidden by the CLR host.")).SetHResult(0x80131640).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException("System.Security.HostProtectionException"));
        Add(_demandedresources = new MessageDescription("mscorlib.HostProtection_DemandedResources", 0xA345074C, new ParameterlessText("The demanded resources were:")).SetHResult(0x80131640).SetSeverity(MessageLevel.Error).SetException("System.Security.HostProtectionException"));
        Add(_protectedresources = new MessageDescription("mscorlib.HostProtection_ProtectedResources", 0xA345074B, new ParameterlessText("The protected resources (only available with full trust) were:")).SetHResult(0x80131640).SetSeverity(MessageLevel.Error).SetException("System.Security.HostProtectionException"));
        return this;
    }    

}
