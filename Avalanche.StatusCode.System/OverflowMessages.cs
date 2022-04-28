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

/// <summary>System.OverflowException</summary>
public class OverflowMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<OverflowMessages> instance = new Lazy<OverflowMessages>(() => new OverflowMessages().Initialize().SetAllReadOnly<OverflowMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static OverflowMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0012;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _byte, _char, _decimal, _double, _duration, _int16, _int32, _int64, _negatetwoscompnum, _sbyte;
    IMessageDescription? _single, _timespantoolong, _uint16, _uint32, _uint64, _currency, _negativeunsigned, _timespanelementtoolarge;
    
    /// <summary>Value was either too large or too small for an unsigned byte.</summary>
    public IMessageDescription Byte { get => _byte!; set => this.AssertWritable()._byte = value; }
    /// <summary>Value was either too large or too small for a character.</summary>
    public IMessageDescription Char { get => _char!; set => this.AssertWritable()._char = value; }
    /// <summary>Value was either too large or too small for a Decimal.</summary>
    public IMessageDescription Decimal { get => _decimal!; set => this.AssertWritable()._decimal = value; }
    /// <summary>Value was either too large or too small for a Double.</summary>
    public IMessageDescription Double { get => _double!; set => this.AssertWritable()._double = value; }
    /// <summary>The duration cannot be returned for TimeSpan.MinValue because the absolute value of TimeSpan.MinValue exceeds the value of TimeSpan.MaxValue.</summary>
    public IMessageDescription Duration { get => _duration!; set => this.AssertWritable()._duration = value; }
    /// <summary>Value was either too large or too small for an Int16.</summary>
    public IMessageDescription Int16 { get => _int16!; set => this.AssertWritable()._int16 = value; }
    /// <summary>Value was either too large or too small for an Int32.</summary>
    public IMessageDescription Int32 { get => _int32!; set => this.AssertWritable()._int32 = value; }
    /// <summary>Value was either too large or too small for an Int64.</summary>
    public IMessageDescription Int64 { get => _int64!; set => this.AssertWritable()._int64 = value; }
    /// <summary>Negating the minimum value of a twos complement number is invalid.</summary>
    public IMessageDescription NegateTwosCompNum { get => _negatetwoscompnum!; set => this.AssertWritable()._negatetwoscompnum = value; }
    /// <summary>Value was either too large or too small for a signed byte.</summary>
    public IMessageDescription SByte { get => _sbyte!; set => this.AssertWritable()._sbyte = value; }
    /// <summary>Value was either too large or too small for a Single.</summary>
    public IMessageDescription Single { get => _single!; set => this.AssertWritable()._single = value; }
    /// <summary>TimeSpan overflowed because the duration is too long.</summary>
    public IMessageDescription TimeSpanTooLong { get => _timespantoolong!; set => this.AssertWritable()._timespantoolong = value; }
    /// <summary>Value was either too large or too small for a UInt16.</summary>
    public IMessageDescription UInt16 { get => _uint16!; set => this.AssertWritable()._uint16 = value; }
    /// <summary>Value was either too large or too small for a UInt32.</summary>
    public IMessageDescription UInt32 { get => _uint32!; set => this.AssertWritable()._uint32 = value; }
    /// <summary>Value was either too large or too small for a UInt64.</summary>
    public IMessageDescription UInt64 { get => _uint64!; set => this.AssertWritable()._uint64 = value; }
    /// <summary>Value was either too large or too small for a Currency.</summary>
    public IMessageDescription Currency { get => _currency!; set => this.AssertWritable()._currency = value; }
    /// <summary>The string was being parsed as an unsigned number and could not have a negative sign.</summary>
    public IMessageDescription NegativeUnsigned { get => _negativeunsigned!; set => this.AssertWritable()._negativeunsigned = value; }
    /// <summary>The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.</summary>
    public IMessageDescription TimeSpanElementTooLarge { get => _timespanelementtoolarge!; set => this.AssertWritable()._timespanelementtoolarge = value; }

    /// <summary>Initialize fields</summary>
    public override OverflowMessages Initialize() 
    {
        base.Initialize();
        Add(_byte = new MessageDescription("mscorlib.Overflow_Byte", 0xA34504B0, new ParameterlessText("Value was either too large or too small for an unsigned byte.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_char = new MessageDescription("mscorlib.Overflow_Char", 0xA34504B1, new ParameterlessText("Value was either too large or too small for a character.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_decimal = new MessageDescription("mscorlib.Overflow_Decimal", 0xA34504B2, new ParameterlessText("Value was either too large or too small for a Decimal.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_double = new MessageDescription("mscorlib.Overflow_Double", 0xA34504B3, new ParameterlessText("Value was either too large or too small for a Double.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_duration = new MessageDescription("mscorlib.Overflow_Duration", 0xA34504B4, new ParameterlessText("The duration cannot be returned for TimeSpan.MinValue because the absolute value of TimeSpan.MinValue exceeds the value of TimeSpan.MaxValue.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_int16 = new MessageDescription("mscorlib.Overflow_Int16", 0xA34504B5, new ParameterlessText("Value was either too large or too small for an Int16.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_int32 = new MessageDescription("mscorlib.Overflow_Int32", 0xA34504B6, new ParameterlessText("Value was either too large or too small for an Int32.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_int64 = new MessageDescription("mscorlib.Overflow_Int64", 0xA34504B7, new ParameterlessText("Value was either too large or too small for an Int64.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_negatetwoscompnum = new MessageDescription("mscorlib.Overflow_NegateTwosCompNum", 0xA34504B8, new ParameterlessText("Negating the minimum value of a twos complement number is invalid.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_sbyte = new MessageDescription("mscorlib.Overflow_SByte", 0xA34504B9, new ParameterlessText("Value was either too large or too small for a signed byte.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_single = new MessageDescription("mscorlib.Overflow_Single", 0xA34504BA, new ParameterlessText("Value was either too large or too small for a Single.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_timespantoolong = new MessageDescription("mscorlib.Overflow_TimeSpanTooLong", 0xA34504BB, new ParameterlessText("TimeSpan overflowed because the duration is too long.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_uint16 = new MessageDescription("mscorlib.Overflow_UInt16", 0xA34504BC, new ParameterlessText("Value was either too large or too small for a UInt16.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_uint32 = new MessageDescription("mscorlib.Overflow_UInt32", 0xA34504BD, new ParameterlessText("Value was either too large or too small for a UInt32.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_uint64 = new MessageDescription("mscorlib.Overflow_UInt64", 0xA34504BE, new ParameterlessText("Value was either too large or too small for a UInt64.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_currency = new MessageDescription("mscorlib.Overflow_Currency", 0xA34506FF, new ParameterlessText("Value was either too large or too small for a Currency.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_negativeunsigned = new MessageDescription("mscorlib.Overflow_NegativeUnsigned", 0xA3450700, new ParameterlessText("The string was being parsed as an unsigned number and could not have a negative sign.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        Add(_timespanelementtoolarge = new MessageDescription("mscorlib.Overflow_TimeSpanElementTooLarge", 0xA3450701, new ParameterlessText("The TimeSpan could not be parsed because at least one of the numeric components is out of range or contains too many digits.")).SetHResult(0x80131516).SetSeverity(MessageLevel.Error).SetException(typeof(System.OverflowException)));
        return this;
    }    

}
