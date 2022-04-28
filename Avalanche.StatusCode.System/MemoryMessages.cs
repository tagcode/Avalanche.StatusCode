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

/// <summary>Memory</summary>
public class MemoryMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<MemoryMessages> instance = new Lazy<MemoryMessages>(() => new MemoryMessages().Initialize().SetAllReadOnly<MemoryMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static MemoryMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0004;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _memfailpoint, _memfailpointtoobig, _memfailpointvafrag, _outofmemorygchandlemda;
    
    /// <summary>Insufficient available memory to meet the expected demands of an operation at this time. Please try again later.</summary>
    public IMessageDescription MemFailPoint { get => _memfailpoint!; set => this.AssertWritable()._memfailpoint = value; }
    /// <summary>Insufficient memory to meet the expected demands of an operation, and this system is likely to never satisfy this request. If this is a 32 bit system, consider booting in 3 GB mode.</summary>
    public IMessageDescription MemFailPointTooBig { get => _memfailpointtoobig!; set => this.AssertWritable()._memfailpointtoobig = value; }
    /// <summary>Insufficient available memory to meet the expected demands of an operation at this time, possibly due to virtual address space fragmentation. Please try again later.</summary>
    public IMessageDescription MemFailPointVAFrag { get => _memfailpointvafrag!; set => this.AssertWritable()._memfailpointvafrag = value; }
    /// <summary>The GCHandle MDA has run out of available cookies.</summary>
    public IMessageDescription OutOfMemoryGCHandleMDA { get => _outofmemorygchandlemda!; set => this.AssertWritable()._outofmemorygchandlemda = value; }

    /// <summary>Initialize fields</summary>
    public override MemoryMessages Initialize() 
    {
        base.Initialize();
        Add(_memfailpoint = new MessageDescription("mscorlib.InsufficientMemory_MemFailPoint", 0xA3450373, new ParameterlessText("Insufficient available memory to meet the expected demands of an operation at this time.  Please try again later.")).SetHResult(0x8013153D).SetSeverity(MessageLevel.Critical).SetException(typeof(System.InsufficientMemoryException)));
        Add(_memfailpointtoobig = new MessageDescription("mscorlib.InsufficientMemory_MemFailPoint_TooBig", 0xA3450374, new ParameterlessText("Insufficient memory to meet the expected demands of an operation, and this system is likely to never satisfy this request.  If this is a 32 bit system, consider booting in 3 GB mode.")).SetHResult(0x8013153D).SetSeverity(MessageLevel.Critical).SetException(typeof(System.InsufficientMemoryException)));
        Add(_memfailpointvafrag = new MessageDescription("mscorlib.InsufficientMemory_MemFailPoint_VAFrag", 0xA3450375, new ParameterlessText("Insufficient available memory to meet the expected demands of an operation at this time, possibly due to virtual address space fragmentation.  Please try again later.")).SetHResult(0x8013153D).SetSeverity(MessageLevel.Critical).SetException(typeof(System.InsufficientMemoryException)));
        Add(_outofmemorygchandlemda = new MessageDescription("mscorlib.OutOfMemory_GCHandleMDA", 0xA34504AF, new ParameterlessText("The GCHandle MDA has run out of available cookies.")).SetHResult(0x8007000E).SetSeverity(MessageLevel.Critical).SetException(typeof(System.OutOfMemoryException)));
        return this;
    }    

}
