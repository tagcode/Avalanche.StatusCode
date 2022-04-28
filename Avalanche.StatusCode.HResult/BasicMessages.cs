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

/// <summary>Basic status codes</summary>
public class BasicMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<BasicMessages> instance = new Lazy<BasicMessages>(() => new BasicMessages().Initialize().SetAllReadOnly<BasicMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static BasicMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000D;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _s_ok, _s_false, _cor_e_ambiguousmatch, _cor_e_invalidcast, _e_bounds, _e_changed_state, _e_fail, _e_notimpl, _e_pointer, _ro_e_closed;
    IMessageDescription? _e_unexpected, _e_abort, _e_pending;
    
    /// <summary>Operation successful</summary>
    public IMessageDescription S_OK { get => _s_ok!; set => this.AssertWritable()._s_ok = value; }
    /// <summary>Operation failed</summary>
    public IMessageDescription S_FALSE { get => _s_false!; set => this.AssertWritable()._s_false = value; }
    /// <summary>Ambiguous match found.</summary>
    public IMessageDescription COR_E_AMBIGUOUSMATCH { get => _cor_e_ambiguousmatch!; set => this.AssertWritable()._cor_e_ambiguousmatch = value; }
    /// <summary>No such interface supported</summary>
    public IMessageDescription COR_E_INVALIDCAST { get => _cor_e_invalidcast!; set => this.AssertWritable()._cor_e_invalidcast = value; }
    /// <summary>The operation attempted to access data outside the valid range</summary>
    public IMessageDescription E_BOUNDS { get => _e_bounds!; set => this.AssertWritable()._e_bounds = value; }
    /// <summary>A concurrent or interleaved operation changed the state of the object, invalidating this operation.</summary>
    public IMessageDescription E_CHANGED_STATE { get => _e_changed_state!; set => this.AssertWritable()._e_changed_state = value; }
    /// <summary>Unspecified error</summary>
    public IMessageDescription E_FAIL { get => _e_fail!; set => this.AssertWritable()._e_fail = value; }
    /// <summary>Not implemented</summary>
    public IMessageDescription E_NOTIMPL { get => _e_notimpl!; set => this.AssertWritable()._e_notimpl = value; }
    /// <summary>Invalid pointer</summary>
    public IMessageDescription E_POINTER { get => _e_pointer!; set => this.AssertWritable()._e_pointer = value; }
    /// <summary>NULL.RO_E_CLOSED</summary>
    public IMessageDescription RO_E_CLOSED { get => _ro_e_closed!; set => this.AssertWritable()._ro_e_closed = value; }
    /// <summary>Catastrophic failure.</summary>
    public IMessageDescription E_UNEXPECTED { get => _e_unexpected!; set => this.AssertWritable()._e_unexpected = value; }
    /// <summary>Operation aborted.</summary>
    public IMessageDescription E_ABORT { get => _e_abort!; set => this.AssertWritable()._e_abort = value; }
    /// <summary>The data necessary to complete this operation is not yet available.</summary>
    public IMessageDescription E_PENDING { get => _e_pending!; set => this.AssertWritable()._e_pending = value; }

    /// <summary>Initialize fields</summary>
    public override BasicMessages Initialize() 
    {
        base.Initialize();
        Add(_s_ok = new MessageDescription("NULL.S_OK", 0x00000000, new ParameterlessText("Operation successful")).SetHResult(0x00000000).SetSeverity(MessageLevel.Debug));
        Add(_s_false = new MessageDescription("NULL.S_FALSE", 0x00000001, new ParameterlessText("Operation failed")).SetHResult(0x00000001).SetSeverity(MessageLevel.Debug));
        Add(_cor_e_ambiguousmatch = new MessageDescription("NULL.COR_E_AMBIGUOUSMATCH", 0x8000211D, new ParameterlessText("Ambiguous match found.")).SetHResult(0x8000211D).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.AmbiguousMatchException)));
        Add(_cor_e_invalidcast = new MessageDescription("NULL.COR_E_INVALIDCAST", 0x80004002, new ParameterlessText("No such interface supported")).SetHResult(0x80004002).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidCastException)));
        Add(_e_bounds = new MessageDescription("NULL.E_BOUNDS", 0x8000000B, new ParameterlessText("The operation attempted to access data outside the valid range")).SetHResult(0x8000000B).SetSeverity(MessageLevel.Error));
        Add(_e_changed_state = new MessageDescription("NULL.E_CHANGED_STATE", 0x8000000C, new ParameterlessText("A concurrent or interleaved operation changed the state of the object, invalidating this operation.")).SetHResult(0x8000000C).SetSeverity(MessageLevel.Error));
        Add(_e_fail = new MessageDescription("NULL.E_FAIL", 0x80004005, new ParameterlessText("Unspecified error")).SetHResult(0x80004005).SetSeverity(MessageLevel.Error).SetException(typeof(System.Runtime.InteropServices.ExternalException)));
        Add(_e_notimpl = new MessageDescription("NULL.E_NOTIMPL", 0x80004001, new ParameterlessText("Not implemented")).SetHResult(0x80004001).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotImplementedException)));
        Add(_e_pointer = new MessageDescription("NULL.E_POINTER", 0x80004003, new ParameterlessText("Invalid pointer")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_ro_e_closed = new MessageDescription("NULL.RO_E_CLOSED", 0x80000013, new ParameterlessText("")).SetHResult(0x80000013).SetSeverity(MessageLevel.Error));
        Add(_e_unexpected = new MessageDescription("NULL.E_UNEXPECTED", 0x8000FFFF, new ParameterlessText("Catastrophic failure.")).SetHResult(0x8000FFFF).SetSeverity(MessageLevel.Critical));
        Add(_e_abort = new MessageDescription("NULL.E_ABORT", 0x80004004, new ParameterlessText("Operation aborted.")).SetHResult(0x80004004).SetSeverity(MessageLevel.Error));
        Add(_e_pending = new MessageDescription("NULL.E_PENDING", 0x8000000A, new ParameterlessText("The data necessary to complete this operation is not yet available.")).SetHResult(0x8000000A).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
