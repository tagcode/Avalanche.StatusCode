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

/// <summary>System.Runtime.CompilerServices.*</summary>
public class CompilerServiceMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<CompilerServiceMessages> instance = new Lazy<CompilerServiceMessages>(() => new CompilerServiceMessages().Initialize().SetAllReadOnly<CompilerServiceMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static CompilerServiceMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0001;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _runtimewrappedexception;
    
    /// <summary>System.Runtime.CompilerServices</summary>
    public IMessageDescription RuntimeWrappedException { get => _runtimewrappedexception!; set => this.AssertWritable()._runtimewrappedexception = value; }

    /// <summary>Initialize fields</summary>
    public override CompilerServiceMessages Initialize() 
    {
        base.Initialize();
        Add(_runtimewrappedexception = new MessageDescription("mscorlib.RuntimeWrappedException", 0xA3450562, new ParameterlessText("An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.")).SetHResult(0x8013153E).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.CompilerServices").SetException(typeof(System.Runtime.CompilerServices.RuntimeWrappedException)));
        return this;
    }    

}
