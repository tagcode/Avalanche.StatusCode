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

/// <summary>COM Dispatch</summary>
public class DispatchMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<DispatchMessages> instance = new Lazy<DispatchMessages>(() => new DispatchMessages().Initialize().SetAllReadOnly<DispatchMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static DispatchMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0004;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _cor_e_dividebyzero, _cor_e_targetparamcount, _disp_e_overflow, _type_e_typemismatch;
    
    /// <summary>Division by zero.</summary>
    public IMessageDescription COR_E_DIVIDEBYZERO { get => _cor_e_dividebyzero!; set => this.AssertWritable()._cor_e_dividebyzero = value; }
    /// <summary>Invalid number of parameters.</summary>
    public IMessageDescription COR_E_TARGETPARAMCOUNT { get => _cor_e_targetparamcount!; set => this.AssertWritable()._cor_e_targetparamcount = value; }
    /// <summary>Out of present range.</summary>
    public IMessageDescription DISP_E_OVERFLOW { get => _disp_e_overflow!; set => this.AssertWritable()._disp_e_overflow = value; }
    /// <summary>Type mismatch.</summary>
    public IMessageDescription TYPE_E_TYPEMISMATCH { get => _type_e_typemismatch!; set => this.AssertWritable()._type_e_typemismatch = value; }

    /// <summary>Initialize fields</summary>
    public override DispatchMessages Initialize() 
    {
        base.Initialize();
        Add(_cor_e_dividebyzero = new MessageDescription("DISPATCH.COR_E_DIVIDEBYZERO", 0x80020012, new ParameterlessText("Division by zero.")).SetHResult(0x80020012).SetSeverity(MessageLevel.Error).SetException(typeof(System.DivideByZeroException)));
        Add(_cor_e_targetparamcount = new MessageDescription("DISPATCH.COR_E_TARGETPARAMCOUNT", 0x8002000E, new ParameterlessText("Invalid number of parameters.")).SetHResult(0x8002000E).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetParameterCountException)));
        Add(_disp_e_overflow = new MessageDescription("DISPATCH.DISP_E_OVERFLOW", 0x8002000A, new ParameterlessText("Out of present range.")).SetHResult(0x8002000A).SetSeverity(MessageLevel.Error));
        Add(_type_e_typemismatch = new MessageDescription("DISPATCH.TYPE_E_TYPEMISMATCH", 0x80028CA0, new ParameterlessText("Type mismatch.")).SetHResult(0x80028CA0).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
