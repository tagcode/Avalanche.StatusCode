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

/// <summary>System.Diagnostics.*</summary>
public class DiagnosticsMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<DiagnosticsMessages> instance = new Lazy<DiagnosticsMessages>(() => new DiagnosticsMessages().Initialize().SetAllReadOnly<DiagnosticsMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static DiagnosticsMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0007;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _enumillegalval, _endofinnerexceptionstack, _endstacktracefrompreviousthrow, _wasthrown, _infilelinenumber, _stack, _at;
    
    /// <summary>System.Diagnostics.Contracts</summary>
    public IMessageDescription EnumIllegalVal { get => _enumillegalval!; set => this.AssertWritable()._enumillegalval = value; }
    /// <summary>System</summary>
    public IMessageDescription EndOfInnerExceptionStack { get => _endofinnerexceptionstack!; set => this.AssertWritable()._endofinnerexceptionstack = value; }
    /// <summary>--- End of stack trace from previous location where exception was thrown ---</summary>
    public IMessageDescription EndStackTraceFromPreviousThrow { get => _endstacktracefrompreviousthrow!; set => this.AssertWritable()._endstacktracefrompreviousthrow = value; }
    /// <summary>Exception of type &#39;{0}&#39; was thrown.</summary>
    public IMessageDescription WasThrown { get => _wasthrown!; set => this.AssertWritable()._wasthrown = value; }
    /// <summary>in {0}:line {1}</summary>
    public IMessageDescription InFileLineNumber { get => _infilelinenumber!; set => this.AssertWritable()._infilelinenumber = value; }
    /// <summary>Stack trace: {0}</summary>
    public IMessageDescription Stack { get => _stack!; set => this.AssertWritable()._stack = value; }
    /// <summary>at</summary>
    public IMessageDescription At { get => _at!; set => this.AssertWritable()._at = value; }

    /// <summary>Initialize fields</summary>
    public override DiagnosticsMessages Initialize() 
    {
        base.Initialize();
        Add(_enumillegalval = new MessageDescription("mscorlib.Arg_EnumIllegalVal", 0xA3450056, new FormatText("Illegal enum value: {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Diagnostics.Contracts").SetException(typeof(System.ArgumentException)));
        Add(_endofinnerexceptionstack = new MessageDescription("mscorlib.Exception_EndOfInnerExceptionStack", 0xA3450351, new ParameterlessText("--- End of inner exception stack trace ---")).SetHResult(0x80070057).SetSeverity(MessageLevel.Debug).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_endstacktracefrompreviousthrow = new MessageDescription("mscorlib.Exception_EndStackTraceFromPreviousThrow", 0x2345062C, new ParameterlessText("--- End of stack trace from previous location where exception was thrown ---")).SetSeverity(MessageLevel.Debug));
        Add(_wasthrown = new MessageDescription("mscorlib.Exception_WasThrown", 0x2345062B, new FormatText("Exception of type '{0}' was thrown.")).SetSeverity(MessageLevel.Debug));
        Add(_infilelinenumber = new MessageDescription("mscorlib.StackTrace_InFileLineNumber", 0x2345062A, new FormatText("in {0}:line {1}")).SetSeverity(MessageLevel.Debug));
        Add(_stack = new MessageDescription("mscorlib.StackTrace_Stack", 0x23450637, new FormatText("Stack trace: \r\n{0}")).SetSeverity(MessageLevel.Debug));
        Add(_at = new MessageDescription("mscorlib.Word_At", 0x23450629, new ParameterlessText("at")).SetSeverity(MessageLevel.Debug));
        return this;
    }    

}
