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

/// <summary>Arithmetic</summary>
public class ArithmeticMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ArithmeticMessages> instance = new Lazy<ArithmeticMessages>(() => new ArithmeticMessages().Initialize().SetAllReadOnly<ArithmeticMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ArithmeticMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0003;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _exception, _argumentoutofrangedatearithmetic, _nan;
    
    /// <summary>System</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>The added or subtracted value results in an un-representable DateTime.</summary>
    public IMessageDescription ArgumentOutOfRangeDateArithmetic { get => _argumentoutofrangedatearithmetic!; set => this.AssertWritable()._argumentoutofrangedatearithmetic = value; }
    /// <summary>Function does not accept floating point Not-a-Number values.</summary>
    public IMessageDescription NaN { get => _nan!; set => this.AssertWritable()._nan = value; }

    /// <summary>Initialize fields</summary>
    public override ArithmeticMessages Initialize() 
    {
        base.Initialize();
        Add(_exception = new MessageDescription("mscorlib.Arg_ArithmeticException", 0xA3450029, new ParameterlessText("Overflow or underflow in the arithmetic operation.")).SetHResult(0x80070216).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArithmeticException)));
        Add(_argumentoutofrangedatearithmetic = new MessageDescription("mscorlib.ArgumentOutOfRange_DateArithmetic", 0xA345028B, new ParameterlessText("The added or subtracted value results in an un-representable DateTime.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_nan = new MessageDescription("mscorlib.Arithmetic_NaN", 0xA34502D6, new ParameterlessText("Function does not accept floating point Not-a-Number values.")).SetHResult(0x80070216).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArithmeticException)));
        return this;
    }    

}
