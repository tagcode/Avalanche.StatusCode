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

/// <summary>Reference</summary>
public class ReferenceMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ReferenceMessages> instance = new Lazy<ReferenceMessages>(() => new ReferenceMessages().Initialize().SetAllReadOnly<ReferenceMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ReferenceMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0007;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _exception, _mustbeidentityreferencetype, _nullreferenceexception, _typedreferencenull, _cannotcreatetypedreference, _null, _weakreferencenolongervalid;
    
    /// <summary>System</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>Type must be an IdentityReference, such as NTAccount or SecurityIdentifier.</summary>
    public IMessageDescription MustBeIdentityReferenceType { get => _mustbeidentityreferencetype!; set => this.AssertWritable()._mustbeidentityreferencetype = value; }
    /// <summary>System</summary>
    public IMessageDescription NullReferenceException { get => _nullreferenceexception!; set => this.AssertWritable()._nullreferenceexception = value; }
    /// <summary>The TypedReference must be initialized.</summary>
    public IMessageDescription TypedReferenceNull { get => _typedreferencenull!; set => this.AssertWritable()._typedreferencenull = value; }
    /// <summary>Cannot use function evaluation to create a TypedReference object.</summary>
    public IMessageDescription CannotCreateTypedReference { get => _cannotcreatetypedreference!; set => this.AssertWritable()._cannotcreatetypedreference = value; }
    /// <summary>The pointer for this method was null.</summary>
    public IMessageDescription Null { get => _null!; set => this.AssertWritable()._null = value; }
    /// <summary>The weak reference is no longer valid.</summary>
    public IMessageDescription WeakReferenceNoLongerValid { get => _weakreferencenolongervalid!; set => this.AssertWritable()._weakreferencenolongervalid = value; }

    /// <summary>Initialize fields</summary>
    public override ReferenceMessages Initialize() 
    {
        base.Initialize();
        Add(_exception = new MessageDescription("mscorlib.Arg_AccessViolationException", 0xA3450023, new ParameterlessText("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.AccessViolationException)));
        Add(_mustbeidentityreferencetype = new MessageDescription("mscorlib.Arg_MustBeIdentityReferenceType", 0xA34500A0, new ParameterlessText("Type must be an IdentityReference, such as NTAccount or SecurityIdentifier.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_nullreferenceexception = new MessageDescription("mscorlib.Arg_NullReferenceException", 0xA34500C5, new ParameterlessText("Object reference not set to an instance of an object.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.NullReferenceException)));
        Add(_typedreferencenull = new MessageDescription("mscorlib.Arg_TypedReference_Null", 0xA3450100, new ParameterlessText("The TypedReference must be initialized.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cannotcreatetypedreference = new MessageDescription("mscorlib.Argument_CannotCreateTypedReference", 0xA3450647, new ParameterlessText("Cannot use function evaluation to create a TypedReference object.")).SetSeverity(MessageLevel.Error));
        Add(_null = new MessageDescription("mscorlib.NullReference_This", 0xA345061E, new ParameterlessText("The pointer for this method was null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.NullReferenceException)));
        Add(_weakreferencenolongervalid = new MessageDescription("mscorlib.WeakReference_NoLongerValid", 0xA345077A, new ParameterlessText("The weak reference is no longer valid.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
