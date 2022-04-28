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

/// <summary>System.NotImplementedException</summary>
public class NotImplementedMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<NotImplementedMessages> instance = new Lazy<NotImplementedMessages>(() => new NotImplementedMessages().Initialize().SetAllReadOnly<NotImplementedMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static NotImplementedMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0002;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _exception, _resourceslongerthan263;
    
    /// <summary>System</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>Resource files longer than 2^63 bytes are not currently implemented.</summary>
    public IMessageDescription ResourcesLongerThan263 { get => _resourceslongerthan263!; set => this.AssertWritable()._resourceslongerthan263 = value; }

    /// <summary>Initialize fields</summary>
    public override NotImplementedMessages Initialize() 
    {
        base.Initialize();
        Add(_exception = new MessageDescription("mscorlib.Arg_NotImplementedException", 0xA34500C3, new ParameterlessText("The method or operation is not implemented.")).SetHResult(0x80004001).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.NotImplementedException)));
        Add(_resourceslongerthan263 = new MessageDescription("mscorlib.NotImplemented_ResourcesLongerThan2^63", 0xA345045E, new ParameterlessText("Resource files longer than 2^63 bytes are not currently implemented.")).SetHResult(0x80004001).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotImplementedException)));
        return this;
    }    

}
