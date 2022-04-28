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

/// <summary>Stack</summary>
public class StackMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<StackMessages> instance = new Lazy<StackMessages>(() => new StackMessages().Initialize().SetAllReadOnly<StackMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static StackMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0002;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _arginsufficientexecution, _stackoverflow;
    
    /// <summary>System</summary>
    public IMessageDescription ArgInsufficientExecution { get => _arginsufficientexecution!; set => this.AssertWritable()._arginsufficientexecution = value; }
    /// <summary>System</summary>
    public IMessageDescription StackOverflow { get => _stackoverflow!; set => this.AssertWritable()._stackoverflow = value; }

    /// <summary>Initialize fields</summary>
    public override StackMessages Initialize() 
    {
        base.Initialize();
        Add(_arginsufficientexecution = new MessageDescription("mscorlib.Arg_InsufficientExecutionStackException", 0xA3450070, new ParameterlessText("Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.")).SetHResult(0x80131578).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.InsufficientExecutionStackException)));
        Add(_stackoverflow = new MessageDescription("mscorlib.Arg_StackOverflowException", 0xA34500F6, new ParameterlessText("Operation caused a stack overflow.")).SetHResult(0x800703E9).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.StackOverflowException)));
        return this;
    }    

}
