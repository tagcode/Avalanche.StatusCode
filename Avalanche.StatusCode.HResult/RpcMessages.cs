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

/// <summary>Remote Procedure Call</summary>
public class RpcMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<RpcMessages> instance = new Lazy<RpcMessages>(() => new RpcMessages().Initialize().SetAllReadOnly<RpcMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static RpcMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0001;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _rpc_e_changed_mode;
    
    /// <summary>Cannot change thread mode after it is set.</summary>
    public IMessageDescription RPC_E_CHANGED_MODE { get => _rpc_e_changed_mode!; set => this.AssertWritable()._rpc_e_changed_mode = value; }

    /// <summary>Initialize fields</summary>
    public override RpcMessages Initialize() 
    {
        base.Initialize();
        Add(_rpc_e_changed_mode = new MessageDescription("RPC.RPC_E_CHANGED_MODE", 0x80010106, new ParameterlessText("Cannot change thread mode after it is set.")).SetHResult(0x80010106).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
