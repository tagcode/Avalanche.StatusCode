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

/// <summary>System.AggregateException</summary>
public class AggregateMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<AggregateMessages> instance = new Lazy<AggregateMessages>(() => new AggregateMessages().Initialize().SetAllReadOnly<AggregateMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static AggregateMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0004;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _defaultmessage, _innerexceptionnull, _deserializationfailure, _tostring;
    
    /// <summary>System</summary>
    public IMessageDescription DefaultMessage { get => _defaultmessage!; set => this.AssertWritable()._defaultmessage = value; }
    /// <summary>System</summary>
    public IMessageDescription InnerExceptionNull { get => _innerexceptionnull!; set => this.AssertWritable()._innerexceptionnull = value; }
    /// <summary>System</summary>
    public IMessageDescription DeserializationFailure { get => _deserializationfailure!; set => this.AssertWritable()._deserializationfailure = value; }
    /// <summary>System</summary>
    public new IMessageDescription ToString { get => _tostring!; set => this.AssertWritable()._tostring = value; }

    /// <summary>Initialize fields</summary>
    public override AggregateMessages Initialize() 
    {
        base.Initialize();
        Add(_defaultmessage = new MessageDescription("mscorlib.AggregateException_ctor_DefaultMessage", 0xA345001B, new ParameterlessText("One or more errors occurred.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.AggregateException)));
        Add(_innerexceptionnull = new MessageDescription("mscorlib.AggregateException_ctor_InnerExceptionNull", 0xA345001C, new ParameterlessText("An element of innerExceptions was null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_deserializationfailure = new MessageDescription("mscorlib.AggregateException_DeserializationFailure", 0xA345001D, new ParameterlessText("The serialization stream contains no inner exceptions.")).SetHResult(0x8013150C).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.Runtime.Serialization.SerializationException)));
        Add(_tostring = new MessageDescription("mscorlib.AggregateException_ToString", 0xA345001E, new FormatText("{0}{1}---> (Inner Exception #{2}) {3}{4}{5}")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.AggregateException)));
        return this;
    }    

}
