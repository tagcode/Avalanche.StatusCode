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

/// <summary>System.Text.*</summary>
public class TextMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<TextMessages> instance = new Lazy<TextMessages>(() => new TextMessages().Initialize().SetAllReadOnly<TextMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static TextMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0004;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _argumentexception, _invalidcodepagebytesindex, _invalidcodepageconversionindex, _range;
    
    /// <summary>System.Text</summary>
    public IMessageDescription ArgumentException { get => _argumentexception!; set => this.AssertWritable()._argumentexception = value; }
    /// <summary>System.Text</summary>
    public IMessageDescription InvalidCodePageBytesIndex { get => _invalidcodepagebytesindex!; set => this.AssertWritable()._invalidcodepagebytesindex = value; }
    /// <summary>System.Text</summary>
    public IMessageDescription InvalidCodePageConversionIndex { get => _invalidcodepageconversionindex!; set => this.AssertWritable()._invalidcodepageconversionindex = value; }
    /// <summary>System.Text</summary>
    public IMessageDescription Range { get => _range!; set => this.AssertWritable()._range = value; }

    /// <summary>Initialize fields</summary>
    public override TextMessages Initialize() 
    {
        base.Initialize();
        Add(_argumentexception = new MessageDescription("mscorlib.Arg_ArgumentException", 0xA3450027, new ParameterlessText("Value does not fall within the expected range.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Text").SetException(typeof(System.ArgumentException)));
        Add(_invalidcodepagebytesindex = new MessageDescription("mscorlib.Argument_InvalidCodePageBytesIndex", 0xA345018A, new FormatText("Unable to translate bytes {0} at index {1} from specified code page to Unicode.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Text").SetException(typeof(System.Text.DecoderFallbackException)));
        Add(_invalidcodepageconversionindex = new MessageDescription("mscorlib.Argument_InvalidCodePageConversionIndex", 0xA345018B, new FormatText("Unable to translate Unicode character \\u{0:X4} at index {1} to specified code page.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Text").SetException(typeof(System.Text.EncoderFallbackException)));
        Add(_range = new MessageDescription("mscorlib.ArgumentOutOfRange_Range", 0xA34502C5, new FormatText("Valid values are between {0} and {1}, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetDescription("System.Text").SetException(typeof(System.ArgumentOutOfRangeException)));
        return this;
    }    

}
