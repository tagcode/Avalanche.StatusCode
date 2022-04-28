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

/// <summary>System.ObjectDisposedException</summary>
public class ObjectDisposedMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ObjectDisposedMessages> instance = new Lazy<ObjectDisposedMessages>(() => new ObjectDisposedMessages().Initialize().SetAllReadOnly<ObjectDisposedMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ObjectDisposedMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0009;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _fileclosed, _generic, _objectnamename, _readerclosed, _regkeyclosed, _resourceset, _streamclosed, _viewaccessorclosed, _writerclosed;
    
    /// <summary>Cannot access a closed file.</summary>
    public IMessageDescription FileClosed { get => _fileclosed!; set => this.AssertWritable()._fileclosed = value; }
    /// <summary>System</summary>
    public IMessageDescription Generic { get => _generic!; set => this.AssertWritable()._generic = value; }
    /// <summary>System</summary>
    public IMessageDescription ObjectNameName { get => _objectnamename!; set => this.AssertWritable()._objectnamename = value; }
    /// <summary>Cannot read from a closed TextReader.</summary>
    public IMessageDescription ReaderClosed { get => _readerclosed!; set => this.AssertWritable()._readerclosed = value; }
    /// <summary>Cannot access a closed registry key.</summary>
    public IMessageDescription RegKeyClosed { get => _regkeyclosed!; set => this.AssertWritable()._regkeyclosed = value; }
    /// <summary>Cannot access a closed resource set.</summary>
    public IMessageDescription ResourceSet { get => _resourceset!; set => this.AssertWritable()._resourceset = value; }
    /// <summary>Cannot access a closed Stream.</summary>
    public IMessageDescription StreamClosed { get => _streamclosed!; set => this.AssertWritable()._streamclosed = value; }
    /// <summary>Cannot access a closed accessor.</summary>
    public IMessageDescription ViewAccessorClosed { get => _viewaccessorclosed!; set => this.AssertWritable()._viewaccessorclosed = value; }
    /// <summary>Cannot write to a closed TextWriter.</summary>
    public IMessageDescription WriterClosed { get => _writerclosed!; set => this.AssertWritable()._writerclosed = value; }

    /// <summary>Initialize fields</summary>
    public override ObjectDisposedMessages Initialize() 
    {
        base.Initialize();
        Add(_fileclosed = new MessageDescription("mscorlib.ObjectDisposed_FileClosed", 0xA34504A4, new ParameterlessText("Cannot access a closed file.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_generic = new MessageDescription("mscorlib.ObjectDisposed_Generic", 0xA34504A5, new ParameterlessText("Cannot access a disposed object.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ObjectDisposedException)));
        Add(_objectnamename = new MessageDescription("mscorlib.ObjectDisposed_ObjectName_Name", 0xA34504A6, new FormatText("Object name: '{0}'.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ObjectDisposedException)));
        Add(_readerclosed = new MessageDescription("mscorlib.ObjectDisposed_ReaderClosed", 0xA34504A7, new ParameterlessText("Cannot read from a closed TextReader.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_regkeyclosed = new MessageDescription("mscorlib.ObjectDisposed_RegKeyClosed", 0xA34504A8, new ParameterlessText("Cannot access a closed registry key.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_resourceset = new MessageDescription("mscorlib.ObjectDisposed_ResourceSet", 0xA34504A9, new ParameterlessText("Cannot access a closed resource set.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_streamclosed = new MessageDescription("mscorlib.ObjectDisposed_StreamClosed", 0xA34504AA, new ParameterlessText("Cannot access a closed Stream.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_viewaccessorclosed = new MessageDescription("mscorlib.ObjectDisposed_ViewAccessorClosed", 0xA34504AB, new ParameterlessText("Cannot access a closed accessor.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_writerclosed = new MessageDescription("mscorlib.ObjectDisposed_WriterClosed", 0xA34504AC, new ParameterlessText("Cannot write to a closed TextWriter.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        return this;
    }    

}
