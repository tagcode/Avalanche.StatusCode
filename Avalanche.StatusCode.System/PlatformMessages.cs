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

/// <summary>Platform</summary>
public class PlatformMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<PlatformMessages> instance = new Lazy<PlatformMessages>(() => new PlatformMessages().Initialize().SetAllReadOnly<PlatformMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static PlatformMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0004;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _notsupportedrequiresnt, _notsupportedrequiresw2ksp3, _notsupportedwinrt, _notsupportedrequireslonghorn;
    
    /// <summary>This operation is only supported on Windows 2000, Windows XP, and higher.</summary>
    public IMessageDescription NotSupportedRequiresNT { get => _notsupportedrequiresnt!; set => this.AssertWritable()._notsupportedrequiresnt = value; }
    /// <summary>This operation is only supported on Windows 2000 SP3 or later operating systems.</summary>
    public IMessageDescription NotSupportedRequiresW2kSP3 { get => _notsupportedrequiresw2ksp3!; set => this.AssertWritable()._notsupportedrequiresw2ksp3 = value; }
    /// <summary>System.StubHelpers</summary>
    public IMessageDescription NotSupportedWinRT { get => _notsupportedwinrt!; set => this.AssertWritable()._notsupportedwinrt = value; }
    /// <summary>This operation is only supported on Windows Vista and above.</summary>
    public IMessageDescription NotSupportedRequiresLonghorn { get => _notsupportedrequireslonghorn!; set => this.AssertWritable()._notsupportedrequireslonghorn = value; }

    /// <summary>Initialize fields</summary>
    public override PlatformMessages Initialize() 
    {
        base.Initialize();
        Add(_notsupportedrequiresnt = new MessageDescription("mscorlib.PlatformNotSupported_RequiresNT", 0xA34504CA, new ParameterlessText("This operation is only supported on Windows 2000, Windows XP, and higher.")).SetHResult(0x80131539).SetSeverity(MessageLevel.Error).SetException(typeof(System.PlatformNotSupportedException)));
        Add(_notsupportedrequiresw2ksp3 = new MessageDescription("mscorlib.PlatformNotSupported_RequiresW2kSP3", 0xA34504CB, new ParameterlessText("This operation is only supported on Windows 2000 SP3 or later operating systems.")).SetHResult(0x80131539).SetSeverity(MessageLevel.Error).SetException(typeof(System.PlatformNotSupportedException)));
        Add(_notsupportedwinrt = new MessageDescription("mscorlib.PlatformNotSupported_WinRT", 0xA34504CC, new ParameterlessText("Windows Runtime is not supported on this operating system.")).SetHResult(0x80131539).SetSeverity(MessageLevel.Error).SetDescription("System.StubHelpers").SetException(typeof(System.PlatformNotSupportedException)));
        Add(_notsupportedrequireslonghorn = new MessageDescription("mscorlib.PlatformNotSupported_RequiresLonghorn", 0xA3450702, new ParameterlessText("This operation is only supported on Windows Vista and above.")).SetHResult(0x80131539).SetSeverity(MessageLevel.Error).SetException(typeof(System.PlatformNotSupportedException)));
        return this;
    }    

}
