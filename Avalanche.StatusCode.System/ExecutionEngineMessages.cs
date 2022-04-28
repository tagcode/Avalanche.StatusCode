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

/// <summary>ExecutionEngine</summary>
public class ExecutionEngineMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ExecutionEngineMessages> instance = new Lazy<ExecutionEngineMessages>(() => new ExecutionEngineMessages().Initialize().SetAllReadOnly<ExecutionEngineMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ExecutionEngineMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0005;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _exception, _enginemissingsecuritydescriptor, _contextexceptioninasynclocalnotification, _contextundofailed, _engineinvalidattribute;
    
    /// <summary>System</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>Unable to retrieve security descriptor for this frame.</summary>
    public IMessageDescription EngineMissingSecurityDescriptor { get => _enginemissingsecuritydescriptor!; set => this.AssertWritable()._enginemissingsecuritydescriptor = value; }
    /// <summary>An exception was not handled in an AsyncLocal&lt;T&gt; notification callback.</summary>
    public IMessageDescription ContextExceptionInAsyncLocalNotification { get => _contextexceptioninasynclocalnotification!; set => this.AssertWritable()._contextexceptioninasynclocalnotification = value; }
    /// <summary>Undo operation on a component context threw an exception</summary>
    public IMessageDescription ContextUndoFailed { get => _contextundofailed!; set => this.AssertWritable()._contextundofailed = value; }
    /// <summary>Attribute cannot have multiple definitions.</summary>
    public IMessageDescription EngineInvalidAttribute { get => _engineinvalidattribute!; set => this.AssertWritable()._engineinvalidattribute = value; }

    /// <summary>Initialize fields</summary>
    public override ExecutionEngineMessages Initialize() 
    {
        base.Initialize();
        Add(_exception = new MessageDescription("mscorlib.Arg_ExecutionEngineException", 0xA345005B, new ParameterlessText("Internal error in the runtime.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_enginemissingsecuritydescriptor = new MessageDescription("mscorlib.ExecutionEngine_MissingSecurityDescriptor", 0xA3450352, new ParameterlessText("Unable to retrieve security descriptor for this frame.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_contextexceptioninasynclocalnotification = new MessageDescription("mscorlib.ExecutionContext_ExceptionInAsyncLocalNotification", 0xA34506AF, new ParameterlessText("An exception was not handled in an AsyncLocal<T> notification callback.")).SetSeverity(MessageLevel.Error));
        Add(_contextundofailed = new MessageDescription("mscorlib.ExecutionContext_UndoFailed", 0xA34506AE, new ParameterlessText("Undo operation on a component context threw an exception")).SetSeverity(MessageLevel.Error));
        Add(_engineinvalidattribute = new MessageDescription("mscorlib.ExecutionEngine_InvalidAttribute", 0xA34506AD, new ParameterlessText("Attribute cannot have multiple definitions.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
