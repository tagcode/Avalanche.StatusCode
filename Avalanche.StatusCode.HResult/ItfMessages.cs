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

/// <summary>COM/OLE Interface management</summary>
public class ItfMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ItfMessages> instance = new Lazy<ItfMessages>(() => new ItfMessages().Initialize().SetAllReadOnly<ItfMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ItfMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0001;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _co_e_notinitialized;
    
    /// <summary>CoInitialize has not been called.</summary>
    public IMessageDescription CO_E_NOTINITIALIZED { get => _co_e_notinitialized!; set => this.AssertWritable()._co_e_notinitialized = value; }

    /// <summary>Initialize fields</summary>
    public override ItfMessages Initialize() 
    {
        base.Initialize();
        Add(_co_e_notinitialized = new MessageDescription("ITF.CO_E_NOTINITIALIZED", 0x800401F0, new ParameterlessText("CoInitialize has not been called.")).SetHResult(0x800401F0).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
