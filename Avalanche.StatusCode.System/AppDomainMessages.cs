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

/// <summary>System.AppDomain.*</summary>
public class AppDomainMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<AppDomainMessages> instance = new Lazy<AppDomainMessages>(() => new AppDomainMessages().Initialize().SetAllReadOnly<AppDomainMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static AppDomainMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000C;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _appbasenotset, _requireapplicationname, _unloadedexception, _exception, _sandboxapineedsexplicitappbase, _invalidoperationexceptionstatecrossappdomain, _bindingmodelislocked, _loadercontextpolicies, _loaderinvalidpath, _loadername;
    IMessageDescription? _loadernocontextpolicies, _inheterogenous;
    
    /// <summary>The ApplicationBase must be set before retrieving this property.</summary>
    public IMessageDescription AppBaseNotSet { get => _appbasenotset!; set => this.AssertWritable()._appbasenotset = value; }
    /// <summary>ApplicationName must be set before the DynamicBase can be set.</summary>
    public IMessageDescription RequireApplicationName { get => _requireapplicationname!; set => this.AssertWritable()._requireapplicationname = value; }
    /// <summary>System</summary>
    public IMessageDescription UnloadedException { get => _unloadedexception!; set => this.AssertWritable()._unloadedexception = value; }
    /// <summary>System</summary>
    public IMessageDescription Exception { get => _exception!; set => this.AssertWritable()._exception = value; }
    /// <summary>This API requires the ApplicationBase to be specified explicitly in the AppDomainSetup parameter.</summary>
    public IMessageDescription SandboxAPINeedsExplicitAppBase { get => _sandboxapineedsexplicitappbase!; set => this.AssertWritable()._sandboxapineedsexplicitappbase = value; }
    /// <summary>Thread.ExceptionState cannot access an ExceptionState from a different AppDomain.</summary>
    public IMessageDescription InvalidOperationExceptionStateCrossAppDomain { get => _invalidoperationexceptionstatecrossappdomain!; set => this.AssertWritable()._invalidoperationexceptionstatecrossappdomain = value; }
    /// <summary>Binding model is already locked for the AppDomain and cannot be reset.</summary>
    public IMessageDescription BindingModelIsLocked { get => _bindingmodelislocked!; set => this.AssertWritable()._bindingmodelislocked = value; }
    /// <summary>Context Policies:</summary>
    public IMessageDescription LoaderContextPolicies { get => _loadercontextpolicies!; set => this.AssertWritable()._loadercontextpolicies = value; }
    /// <summary>Relative path must be a string that contains the substring, &quot;..&quot;, or does not contain a root directory.</summary>
    public IMessageDescription LoaderInvalidPath { get => _loaderinvalidpath!; set => this.AssertWritable()._loaderinvalidpath = value; }
    /// <summary>Name:</summary>
    public IMessageDescription LoaderName { get => _loadername!; set => this.AssertWritable()._loadername = value; }
    /// <summary>There are no context policies.</summary>
    public IMessageDescription LoaderNoContextPolicies { get => _loadernocontextpolicies!; set => this.AssertWritable()._loadernocontextpolicies = value; }
    /// <summary>SecurityContextSource.CurrentAppDomain is not supported in heterogenous AppDomains.</summary>
    public IMessageDescription InHeterogenous { get => _inheterogenous!; set => this.AssertWritable()._inheterogenous = value; }

    /// <summary>Initialize fields</summary>
    public override AppDomainMessages Initialize() 
    {
        base.Initialize();
        Add(_appbasenotset = new MessageDescription("mscorlib.AppDomain_AppBaseNotSet", 0xA345001F, new ParameterlessText("The ApplicationBase must be set before retrieving this property.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Critical).SetException(typeof(System.MemberAccessException)));
        Add(_requireapplicationname = new MessageDescription("mscorlib.AppDomain_RequireApplicationName", 0xA3450020, new ParameterlessText("ApplicationName must be set before the DynamicBase can be set.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Critical).SetException(typeof(System.MemberAccessException)));
        Add(_unloadedexception = new MessageDescription("mscorlib.Arg_AppDomainUnloadedException", 0xA3450025, new ParameterlessText("Attempted to access an unloaded AppDomain.")).SetHResult(0x80131014).SetSeverity(MessageLevel.Critical).SetDescription("System").SetException(typeof(System.AppDomainUnloadedException)));
        Add(_exception = new MessageDescription("mscorlib.Arg_CannotUnloadAppDomainException", 0xA3450035, new ParameterlessText("Attempt to unload the AppDomain failed.")).SetHResult(0x80131015).SetSeverity(MessageLevel.Critical).SetDescription("System").SetException(typeof(System.CannotUnloadAppDomainException)));
        Add(_sandboxapineedsexplicitappbase = new MessageDescription("mscorlib.InvalidOperation_AppDomainSandboxAPINeedsExplicitAppBase", 0xA3450386, new ParameterlessText("This API requires the ApplicationBase to be specified explicitly in the AppDomainSetup parameter.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Critical).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationexceptionstatecrossappdomain = new MessageDescription("mscorlib.InvalidOperation_ExceptionStateCrossAppDomain", 0xA34503B8, new ParameterlessText("Thread.ExceptionState cannot access an ExceptionState from a different AppDomain.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Critical).SetException(typeof(System.InvalidOperationException)));
        Add(_bindingmodelislocked = new MessageDescription("mscorlib.AppDomain_BindingModelIsLocked", 0xA3450780, new ParameterlessText("Binding model is already locked for the AppDomain and cannot be reset.")).SetSeverity(MessageLevel.Critical));
        Add(_loadercontextpolicies = new MessageDescription("mscorlib.Loader_ContextPolicies", 0xA345077F, new ParameterlessText("Context Policies:")).SetSeverity(MessageLevel.Critical));
        Add(_loaderinvalidpath = new MessageDescription("mscorlib.Loader_InvalidPath", 0xA345077C, new ParameterlessText("Relative path must be a string that contains the substring, \"..\", or does not contain a root directory.")).SetSeverity(MessageLevel.Critical));
        Add(_loadername = new MessageDescription("mscorlib.Loader_Name", 0xA345077D, new ParameterlessText("Name:")).SetSeverity(MessageLevel.Critical));
        Add(_loadernocontextpolicies = new MessageDescription("mscorlib.Loader_NoContextPolicies", 0xA345077E, new ParameterlessText("There are no context policies.")).SetSeverity(MessageLevel.Critical));
        Add(_inheterogenous = new MessageDescription("mscorlib.NotSupported_SecurityContextSourceAppDomainInHeterogenous", 0xA34506FB, new ParameterlessText("SecurityContextSource.CurrentAppDomain is not supported in heterogenous AppDomains.")).SetSeverity(MessageLevel.Critical));
        return this;
    }    

}
