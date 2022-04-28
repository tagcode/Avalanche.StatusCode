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

/// <summary>System.IndexOutOfRangeException</summary>
public class IndexOutOfRangeMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<IndexOutOfRangeMessages> instance = new Lazy<IndexOutOfRangeMessages>(() => new IndexOutOfRangeMessages().Initialize().SetAllReadOnly<IndexOutOfRangeMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static IndexOutOfRangeMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0002;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _umsposition, _arrayrankindex;
    
    /// <summary>Unmanaged memory stream position was beyond the capacity of the stream.</summary>
    public IMessageDescription UMSPosition { get => _umsposition!; set => this.AssertWritable()._umsposition = value; }
    /// <summary>Array does not have that many dimensions.</summary>
    public IMessageDescription ArrayRankIndex { get => _arrayrankindex!; set => this.AssertWritable()._arrayrankindex = value; }

    /// <summary>Initialize fields</summary>
    public override IndexOutOfRangeMessages Initialize() 
    {
        base.Initialize();
        Add(_umsposition = new MessageDescription("mscorlib.IndexOutOfRange_UMSPosition", 0xA3450372, new ParameterlessText("Unmanaged memory stream position was beyond the capacity of the stream.")).SetHResult(0x80131508).SetSeverity(MessageLevel.Error).SetException(typeof(System.IndexOutOfRangeException)));
        Add(_arrayrankindex = new MessageDescription("mscorlib.IndexOutOfRange_ArrayRankIndex", 0xA34506C6, new ParameterlessText("Array does not have that many dimensions.")).SetHResult(0x80131508).SetSeverity(MessageLevel.Error).SetException(typeof(System.IndexOutOfRangeException)));
        return this;
    }    

}
