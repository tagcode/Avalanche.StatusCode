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

/// <summary>System.InvalidCastException</summary>
public class InvalidCastMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<InvalidCastMessages> instance = new Lazy<InvalidCastMessages>(() => new InvalidCastMessages().Initialize().SetAllReadOnly<InvalidCastMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static InvalidCastMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000E;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _cannotcastnulltovaluetype, _cannotcoercebyrefvariant, _dbnull, _empty, _fromdbnull, _fromto, _iconvertible, _winrtipropertyvaluearraycoersion, _winrtipropertyvaluecoersion, _winrtipropertyvalueelement;
    IMessageDescription? _multicastcombine, _downcastarrayelement, _oatypemismatch, _storearrayelement;
    
    /// <summary>Null object cannot be converted to a value type.</summary>
    public IMessageDescription CannotCastNullToValueType { get => _cannotcastnulltovaluetype!; set => this.AssertWritable()._cannotcastnulltovaluetype = value; }
    /// <summary>Object cannot be coerced to the original type of the ByRef VARIANT it was obtained from.</summary>
    public IMessageDescription CannotCoerceByRefVariant { get => _cannotcoercebyrefvariant!; set => this.AssertWritable()._cannotcoercebyrefvariant = value; }
    /// <summary>Object cannot be cast to DBNull.</summary>
    public IMessageDescription DBNull { get => _dbnull!; set => this.AssertWritable()._dbnull = value; }
    /// <summary>Object cannot be cast to Empty.</summary>
    public IMessageDescription Empty { get => _empty!; set => this.AssertWritable()._empty = value; }
    /// <summary>Object cannot be cast from DBNull to other types.</summary>
    public IMessageDescription FromDBNull { get => _fromdbnull!; set => this.AssertWritable()._fromdbnull = value; }
    /// <summary>Invalid cast from &#39;{0}&#39; to &#39;{1}&#39;.</summary>
    public IMessageDescription FromTo { get => _fromto!; set => this.AssertWritable()._fromto = value; }
    /// <summary>Object must implement IConvertible.</summary>
    public IMessageDescription IConvertible { get => _iconvertible!; set => this.AssertWritable()._iconvertible = value; }
    /// <summary>Object in an IPropertyValue is of type &#39;{0}&#39; which cannot be convereted to a &#39;{1}&#39; due to array element &#39;{2}&#39;: {3}.</summary>
    public IMessageDescription WinRTIPropertyValueArrayCoersion { get => _winrtipropertyvaluearraycoersion!; set => this.AssertWritable()._winrtipropertyvaluearraycoersion = value; }
    /// <summary>Object in an IPropertyValue is of type &#39;{0}&#39; with value &#39;{1}&#39;, which cannot be converted to a &#39;{2}&#39;.</summary>
    public IMessageDescription WinRTIPropertyValueCoersion { get => _winrtipropertyvaluecoersion!; set => this.AssertWritable()._winrtipropertyvaluecoersion = value; }
    /// <summary>Object in an IPropertyValue is of type &#39;{0}&#39;, which cannot be converted to a &#39;{1}&#39;.</summary>
    public IMessageDescription WinRTIPropertyValueElement { get => _winrtipropertyvalueelement!; set => this.AssertWritable()._winrtipropertyvalueelement = value; }
    /// <summary>Delegates that are not of type MulticastDelegate may not be combined.</summary>
    public IMessageDescription MulticastCombine { get => _multicastcombine!; set => this.AssertWritable()._multicastcombine = value; }
    /// <summary>At least one element in the source array could not be cast down to the destination array type.</summary>
    public IMessageDescription DownCastArrayElement { get => _downcastarrayelement!; set => this.AssertWritable()._downcastarrayelement = value; }
    /// <summary>OleAut reported a type mismatch.</summary>
    public IMessageDescription OATypeMismatch { get => _oatypemismatch!; set => this.AssertWritable()._oatypemismatch = value; }
    /// <summary>Object cannot be stored in an array of this type.</summary>
    public IMessageDescription StoreArrayElement { get => _storearrayelement!; set => this.AssertWritable()._storearrayelement = value; }

    /// <summary>Initialize fields</summary>
    public override InvalidCastMessages Initialize() 
    {
        base.Initialize();
        Add(_cannotcastnulltovaluetype = new MessageDescription("mscorlib.InvalidCast_CannotCastNullToValueType", 0xA3450378, new ParameterlessText("Null object cannot be converted to a value type.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_cannotcoercebyrefvariant = new MessageDescription("mscorlib.InvalidCast_CannotCoerceByRefVariant", 0xA3450379, new ParameterlessText("Object cannot be coerced to the original type of the ByRef VARIANT it was obtained from.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_dbnull = new MessageDescription("mscorlib.InvalidCast_DBNull", 0xA345037A, new ParameterlessText("Object cannot be cast to DBNull.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_empty = new MessageDescription("mscorlib.InvalidCast_Empty", 0xA345037B, new ParameterlessText("Object cannot be cast to Empty.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_fromdbnull = new MessageDescription("mscorlib.InvalidCast_FromDBNull", 0xA345037C, new ParameterlessText("Object cannot be cast from DBNull to other types.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_fromto = new MessageDescription("mscorlib.InvalidCast_FromTo", 0xA345037D, new FormatText("Invalid cast from '{0}' to '{1}'.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_iconvertible = new MessageDescription("mscorlib.InvalidCast_IConvertible", 0xA345037E, new ParameterlessText("Object must implement IConvertible.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_winrtipropertyvaluearraycoersion = new MessageDescription("mscorlib.InvalidCast_WinRTIPropertyValueArrayCoersion", 0xA345037F, new FormatText("Object in an IPropertyValue is of type '{0}' which cannot be convereted to a '{1}' due to array element '{2}': {3}.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_winrtipropertyvaluecoersion = new MessageDescription("mscorlib.InvalidCast_WinRTIPropertyValueCoersion", 0xA3450380, new FormatText("Object in an IPropertyValue is of type '{0}' with value '{1}', which cannot be converted to a '{2}'.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_winrtipropertyvalueelement = new MessageDescription("mscorlib.InvalidCast_WinRTIPropertyValueElement", 0xA3450381, new FormatText("Object in an IPropertyValue is of type '{0}', which cannot be converted to a '{1}'.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_multicastcombine = new MessageDescription("mscorlib.Multicast_Combine", 0xA345045D, new ParameterlessText("Delegates that are not of type MulticastDelegate may not be combined.")).SetHResult(0x80131514).SetSeverity(MessageLevel.Error).SetException(typeof(System.MulticastNotSupportedException)));
        Add(_downcastarrayelement = new MessageDescription("mscorlib.InvalidCast_DownCastArrayElement", 0xA34506C7, new ParameterlessText("At least one element in the source array could not be cast down to the destination array type.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_oatypemismatch = new MessageDescription("mscorlib.InvalidCast_OATypeMismatch", 0xA34506C8, new ParameterlessText("OleAut reported a type mismatch.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_storearrayelement = new MessageDescription("mscorlib.InvalidCast_StoreArrayElement", 0xA34506C9, new ParameterlessText("Object cannot be stored in an array of this type.")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        return this;
    }    

}
