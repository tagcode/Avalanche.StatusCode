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

/// <summary>System.Threading.Lazy</summary>
public class LazyMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<LazyMessages> instance = new Lazy<LazyMessages>(() => new LazyMessages().Initialize().SetAllReadOnly<LazyMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static LazyMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0008;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _createvaluenoparameterlessctorfort, _ctormodeinvalid, _staticinitinvalidoperation, _tostringvaluenotcreated, _valuerecursivecallstovalue, _ctorinfonull, _ctorvalueselectornull, _ctordeserializationvalueinvalid;
    
    /// <summary>System</summary>
    public IMessageDescription CreateValueNoParameterlessCtorForT { get => _createvaluenoparameterlessctorfort!; set => this.AssertWritable()._createvaluenoparameterlessctorfort = value; }
    /// <summary>System</summary>
    public IMessageDescription ctorModeInvalid { get => _ctormodeinvalid!; set => this.AssertWritable()._ctormodeinvalid = value; }
    /// <summary>ValueFactory returned null.</summary>
    public IMessageDescription StaticInitInvalidOperation { get => _staticinitinvalidoperation!; set => this.AssertWritable()._staticinitinvalidoperation = value; }
    /// <summary>System</summary>
    public IMessageDescription ToStringValueNotCreated { get => _tostringvaluenotcreated!; set => this.AssertWritable()._tostringvaluenotcreated = value; }
    /// <summary>System</summary>
    public IMessageDescription ValueRecursiveCallsToValue { get => _valuerecursivecallstovalue!; set => this.AssertWritable()._valuerecursivecallstovalue = value; }
    /// <summary>The info argument is null.</summary>
    public IMessageDescription ctorInfoNull { get => _ctorinfonull!; set => this.AssertWritable()._ctorinfonull = value; }
    /// <summary>The valueSelector argument is null.</summary>
    public IMessageDescription ctorValueSelectorNull { get => _ctorvalueselectornull!; set => this.AssertWritable()._ctorvalueselectornull = value; }
    /// <summary>The Value cannot be null.</summary>
    public IMessageDescription ctordeserializationValueInvalid { get => _ctordeserializationvalueinvalid!; set => this.AssertWritable()._ctordeserializationvalueinvalid = value; }

    /// <summary>Initialize fields</summary>
    public override LazyMessages Initialize() 
    {
        base.Initialize();
        Add(_createvaluenoparameterlessctorfort = new MessageDescription("mscorlib.Lazy_CreateValue_NoParameterlessCtorForT", 0xA3450443, new ParameterlessText("The lazily-initialized type does not have a public, parameterless constructor.")).SetHResult(0x80131512).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingMemberException)));
        Add(_ctormodeinvalid = new MessageDescription("mscorlib.Lazy_ctor_ModeInvalid", 0xA3450444, new ParameterlessText("The mode argument specifies an invalid value.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_staticinitinvalidoperation = new MessageDescription("mscorlib.Lazy_StaticInit_InvalidOperation", 0xA3450445, new ParameterlessText("ValueFactory returned null.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_tostringvaluenotcreated = new MessageDescription("mscorlib.Lazy_ToString_ValueNotCreated", 0xA3450446, new ParameterlessText("Value is not created.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_valuerecursivecallstovalue = new MessageDescription("mscorlib.Lazy_Value_RecursiveCallsToValue", 0xA3450447, new ParameterlessText("ValueFactory attempted to access the Value property of this instance.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.InvalidOperationException)));
        Add(_ctorinfonull = new MessageDescription("mscorlib.Lazy_ctor_InfoNull", 0xA3450762, new ParameterlessText("The info argument is null.")).SetSeverity(MessageLevel.Error));
        Add(_ctorvalueselectornull = new MessageDescription("mscorlib.Lazy_ctor_ValueSelectorNull", 0xA3450761, new ParameterlessText("The valueSelector argument is null.")).SetSeverity(MessageLevel.Error));
        Add(_ctordeserializationvalueinvalid = new MessageDescription("mscorlib.Lazy_ctor_deserialization_ValueInvalid", 0xA3450763, new ParameterlessText("The Value cannot be null.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
