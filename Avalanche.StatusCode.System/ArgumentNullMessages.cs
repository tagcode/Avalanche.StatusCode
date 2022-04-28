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

/// <summary>System.ArgumentNullException</summary>
public class ArgumentNullMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ArgumentNullMessages> instance = new Lazy<ArgumentNullMessages>(() => new ArgumentNullMessages().Initialize().SetAllReadOnly<ArgumentNullMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ArgumentNullMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x001B;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _buffer, _child, _collection, _dictionary, _filename, _generic, _graph, _key, _nullmember, _obj;
    IMessageDescription? _path, _safehandle, _stream, _string, _type, _typerequiredbyresourcescope, _waithandles, _withparamname, _publishertostring, _publishertostringarg;
    IMessageDescription? _applicationtrust, _assemblyname, _assemblynamename, _criticalhandle, _cultureinfo, _guid, _typedreftype;
    
    /// <summary>Buffer cannot be null.</summary>
    public IMessageDescription Buffer { get => _buffer!; set => this.AssertWritable()._buffer = value; }
    /// <summary>Cannot have a null child.</summary>
    public IMessageDescription Child { get => _child!; set => this.AssertWritable()._child = value; }
    /// <summary>Collection cannot be null.</summary>
    public IMessageDescription Collection { get => _collection!; set => this.AssertWritable()._collection = value; }
    /// <summary>Dictionary cannot be null.</summary>
    public IMessageDescription Dictionary { get => _dictionary!; set => this.AssertWritable()._dictionary = value; }
    /// <summary>File name cannot be null.</summary>
    public IMessageDescription FileName { get => _filename!; set => this.AssertWritable()._filename = value; }
    /// <summary>System</summary>
    public IMessageDescription Generic { get => _generic!; set => this.AssertWritable()._generic = value; }
    /// <summary>Object Graph cannot be null.</summary>
    public IMessageDescription Graph { get => _graph!; set => this.AssertWritable()._graph = value; }
    /// <summary>Key cannot be null.</summary>
    public IMessageDescription Key { get => _key!; set => this.AssertWritable()._key = value; }
    /// <summary>Member at position {0} was null.</summary>
    public IMessageDescription NullMember { get => _nullmember!; set => this.AssertWritable()._nullmember = value; }
    /// <summary>System.Runtime.ExceptionServices</summary>
    public IMessageDescription Obj { get => _obj!; set => this.AssertWritable()._obj = value; }
    /// <summary>Path cannot be null.</summary>
    public IMessageDescription Path { get => _path!; set => this.AssertWritable()._path = value; }
    /// <summary>System.StubHelpers</summary>
    public IMessageDescription SafeHandle { get => _safehandle!; set => this.AssertWritable()._safehandle = value; }
    /// <summary>Stream cannot be null.</summary>
    public IMessageDescription Stream { get => _stream!; set => this.AssertWritable()._stream = value; }
    /// <summary>String reference not set to an instance of a String.</summary>
    public IMessageDescription String { get => _string!; set => this.AssertWritable()._string = value; }
    /// <summary>Type cannot be null.</summary>
    public IMessageDescription Type { get => _type!; set => this.AssertWritable()._type = value; }
    /// <summary>The type parameter cannot be null when scoping the resource&#39;s visibility to Private or Assembly.</summary>
    public IMessageDescription TypeRequiredByResourceScope { get => _typerequiredbyresourcescope!; set => this.AssertWritable()._typerequiredbyresourcescope = value; }
    /// <summary>The waitHandles parameter cannot be null.</summary>
    public IMessageDescription Waithandles { get => _waithandles!; set => this.AssertWritable()._waithandles = value; }
    /// <summary>Parameter &#39;{0}&#39; cannot be null.</summary>
    public IMessageDescription WithParamName { get => _withparamname!; set => this.AssertWritable()._withparamname = value; }
    /// <summary>Publisher</summary>
    public IMessageDescription PublisherToString { get => _publishertostring!; set => this.AssertWritable()._publishertostring = value; }
    /// <summary>Publisher - {0}</summary>
    public IMessageDescription PublisherToStringArg { get => _publishertostringarg!; set => this.AssertWritable()._publishertostringarg = value; }
    /// <summary>The application trust cannot be null.</summary>
    public IMessageDescription ApplicationTrust { get => _applicationtrust!; set => this.AssertWritable()._applicationtrust = value; }
    /// <summary>AssemblyName cannot be null.</summary>
    public IMessageDescription AssemblyName { get => _assemblyname!; set => this.AssertWritable()._assemblyname = value; }
    /// <summary>AssemblyName.Name cannot be null or an empty string.</summary>
    public IMessageDescription AssemblyNameName { get => _assemblynamename!; set => this.AssertWritable()._assemblynamename = value; }
    /// <summary>CriticalHandle cannot be null.</summary>
    public IMessageDescription CriticalHandle { get => _criticalhandle!; set => this.AssertWritable()._criticalhandle = value; }
    /// <summary>CultureInfo cannot be null.</summary>
    public IMessageDescription CultureInfo { get => _cultureinfo!; set => this.AssertWritable()._cultureinfo = value; }
    /// <summary>GUID cannot be null.</summary>
    public IMessageDescription GUID { get => _guid!; set => this.AssertWritable()._guid = value; }
    /// <summary>Type in TypedReference cannot be null.</summary>
    public IMessageDescription TypedRefType { get => _typedreftype!; set => this.AssertWritable()._typedreftype = value; }

    /// <summary>Initialize fields</summary>
    public override ArgumentNullMessages Initialize() 
    {
        base.Initialize();
        Add(_buffer = new MessageDescription("mscorlib.ArgumentNull_Buffer", 0xA3450262, new ParameterlessText("Buffer cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_child = new MessageDescription("mscorlib.ArgumentNull_Child", 0xA3450263, new ParameterlessText("Cannot have a null child.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_collection = new MessageDescription("mscorlib.ArgumentNull_Collection", 0xA3450264, new ParameterlessText("Collection cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_dictionary = new MessageDescription("mscorlib.ArgumentNull_Dictionary", 0xA3450265, new ParameterlessText("Dictionary cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_filename = new MessageDescription("mscorlib.ArgumentNull_FileName", 0xA3450266, new ParameterlessText("File name cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_generic = new MessageDescription("mscorlib.ArgumentNull_Generic", 0xA3450267, new ParameterlessText("Value cannot be null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentException)));
        Add(_graph = new MessageDescription("mscorlib.ArgumentNull_Graph", 0xA3450268, new ParameterlessText("Object Graph cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_key = new MessageDescription("mscorlib.ArgumentNull_Key", 0xA3450269, new ParameterlessText("Key cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_nullmember = new MessageDescription("mscorlib.ArgumentNull_NullMember", 0xA345026A, new FormatText("Member at position {0} was null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_obj = new MessageDescription("mscorlib.ArgumentNull_Obj", 0xA345026B, new ParameterlessText("Object cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.ExceptionServices").SetException(typeof(System.ArgumentNullException)));
        Add(_path = new MessageDescription("mscorlib.ArgumentNull_Path", 0xA345026C, new ParameterlessText("Path cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_safehandle = new MessageDescription("mscorlib.ArgumentNull_SafeHandle", 0xA345026D, new ParameterlessText("SafeHandle cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetDescription("System.StubHelpers").SetException(typeof(System.ArgumentNullException)));
        Add(_stream = new MessageDescription("mscorlib.ArgumentNull_Stream", 0xA345026E, new ParameterlessText("Stream cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_string = new MessageDescription("mscorlib.ArgumentNull_String", 0xA345026F, new ParameterlessText("String reference not set to an instance of a String.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_type = new MessageDescription("mscorlib.ArgumentNull_Type", 0xA3450270, new ParameterlessText("Type cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_typerequiredbyresourcescope = new MessageDescription("mscorlib.ArgumentNull_TypeRequiredByResourceScope", 0xA3450271, new ParameterlessText("The type parameter cannot be null when scoping the resource's visibility to Private or Assembly.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_waithandles = new MessageDescription("mscorlib.ArgumentNull_Waithandles", 0xA3450272, new ParameterlessText("The waitHandles parameter cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_withparamname = new MessageDescription("mscorlib.ArgumentNull_WithParamName", 0xA3450273, new FormatText("Parameter '{0}' cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_publishertostring = new MessageDescription("mscorlib.Publisher_ToString", 0xA34504E9, new ParameterlessText("Publisher")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_publishertostringarg = new MessageDescription("mscorlib.Publisher_ToStringArg", 0xA34504EA, new FormatText("Publisher - {0}")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_applicationtrust = new MessageDescription("mscorlib.ArgumentNull_ApplicationTrust", 0xA3450623, new ParameterlessText("The application trust cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_assemblyname = new MessageDescription("mscorlib.ArgumentNull_AssemblyName", 0xA345067E, new ParameterlessText("AssemblyName cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_assemblynamename = new MessageDescription("mscorlib.ArgumentNull_AssemblyNameName", 0xA345067F, new ParameterlessText("AssemblyName.Name cannot be null or an empty string.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_criticalhandle = new MessageDescription("mscorlib.ArgumentNull_CriticalHandle", 0xA3450621, new ParameterlessText("CriticalHandle cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_cultureinfo = new MessageDescription("mscorlib.ArgumentNull_CultureInfo", 0xA345061F, new ParameterlessText("CultureInfo cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_guid = new MessageDescription("mscorlib.ArgumentNull_GUID", 0xA3450620, new ParameterlessText("GUID cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_typedreftype = new MessageDescription("mscorlib.ArgumentNull_TypedRefType", 0xA3450622, new ParameterlessText("Type in TypedReference cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        return this;
    }    

}
