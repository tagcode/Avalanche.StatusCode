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

/// <summary>System.Runtime.InteropServices.*</summary>
public class InteropServiceMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<InteropServiceMessages> instance = new Lazy<InteropServiceMessages>(() => new InteropServiceMessages().Initialize().SetAllReadOnly<InteropServiceMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static InteropServiceMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0007;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _comexception, _externalexception, _invalidcomobjectexception, _invalidolevarianttypeexception, _marshaldirectiveexception, _marshalunmappablechar, _comtypemismatch;
    
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription COMException { get => _comexception!; set => this.AssertWritable()._comexception = value; }
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription ExternalException { get => _externalexception!; set => this.AssertWritable()._externalexception = value; }
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription InvalidComObjectException { get => _invalidcomobjectexception!; set => this.AssertWritable()._invalidcomobjectexception = value; }
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription InvalidOleVariantTypeException { get => _invalidolevarianttypeexception!; set => this.AssertWritable()._invalidolevarianttypeexception = value; }
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription MarshalDirectiveException { get => _marshaldirectiveexception!; set => this.AssertWritable()._marshaldirectiveexception = value; }
    /// <summary>Cannot marshal: Encountered unmappable character.</summary>
    public IMessageDescription MarshalUnmappableChar { get => _marshalunmappablechar!; set => this.AssertWritable()._marshalunmappablechar = value; }
    /// <summary>Type mismatch between source and destination types.</summary>
    public IMessageDescription COMTypeMismatch { get => _comtypemismatch!; set => this.AssertWritable()._comtypemismatch = value; }

    /// <summary>Initialize fields</summary>
    public override InteropServiceMessages Initialize() 
    {
        base.Initialize();
        Add(_comexception = new MessageDescription("mscorlib.Arg_COMException", 0xA3450038, new ParameterlessText("Error HRESULT E_FAIL has been returned from a call to a COM component.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.COMException)));
        Add(_externalexception = new MessageDescription("mscorlib.Arg_ExternalException", 0xA345005C, new ParameterlessText("External component has thrown an exception.")).SetHResult(0x80004005).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.ExternalException)));
        Add(_invalidcomobjectexception = new MessageDescription("mscorlib.Arg_InvalidComObjectException", 0xA3450074, new ParameterlessText("Attempt has been made to use a COM object that does not have a backing class factory.")).SetHResult(0x80131527).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.InvalidComObjectException)));
        Add(_invalidolevarianttypeexception = new MessageDescription("mscorlib.Arg_InvalidOleVariantTypeException", 0xA345007E, new ParameterlessText("Specified OLE variant was invalid.")).SetHResult(0x80131531).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.InvalidOleVariantTypeException)));
        Add(_marshaldirectiveexception = new MessageDescription("mscorlib.Arg_MarshalDirectiveException", 0xA345008A, new ParameterlessText("Marshaling directives are invalid.")).SetHResult(0x80131535).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.MarshalDirectiveException)));
        Add(_marshalunmappablechar = new MessageDescription("mscorlib.Interop_Marshal_Unmappable_Char", 0xA3450376, new ParameterlessText("Cannot marshal: Encountered unmappable character.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_comtypemismatch = new MessageDescription("mscorlib.Interop.COM_TypeMismatch", 0xA3450377, new ParameterlessText("Type mismatch between source and destination types.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.InteropServices.COMException)));
        return this;
    }    

}
