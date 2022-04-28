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

/// <summary>System.Runtime.Remoting.*</summary>
public class RemotingMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<RemotingMessages> instance = new Lazy<RemotingMessages>(() => new RemotingMessages().Initialize().SetAllReadOnly<RemotingMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static RemotingMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x007F;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _activationasyncunsupported, _activationbadattribute, _activationbadobject, _activationconnectfailed, _activationfailed, _activationinconsistentstate, _activationmbrproxyattribute, _activationmissingremoteappentry, _activationnullfrominternalunmarshal, _activationnullreturnvalue;
    IMessageDescription? _activationpermissiondenied, _activationpropertyunhappy, _activationwellknownctor, _ambiguousctor, _ambiguousmethod, _appdomainsnyi, _appdomainscantbecalledremotely, _assemblyloadfailed, _attributeuseattributenotsettable, _badfield;
    IMessageDescription? _badinternalstateactivationfailure, _badinternalstatefailenvoysink, _badinternalstateproxysameappdomain, _badtype, _cantdisconnectclientproxy, _cantinvokeiremotedispatch, _channelcannotbesecured, _channelcantcallaprwhenstackempty, _channelcantcallfrswhenstackemtpy, _channelcantcallgetresponsestreamwhenstackempty;
    IMessageDescription? _channeldispatchsinkmessagemissing, _channeldispatchsinkwantsnullrequeststream, _channelpopfromsinkstackwithoutpush, _channelpoponemptysinkstack, _channelstoreonemptysinkstack, _channelstoreonsinkstackwithoutpush, _channelnamealreadyregistered, _channelnotregistered, _configappnameset, _configcantredirectactivationofwellknownservice;
    IMessageDescription? _configcantuseredirectedtypeforwellknownservice, _configchannelmissingctor, _configconfigurationfailure, _configerrorsmodeset, _configinvalidchanneltype, _configinvalidsinkprovidertype, _confignoappname, _confignodemustbeunique, _configreadfailure, _configsinkprovidermissingctor;
    IMessageDescription? _configsinkprovidernotformatter, _configtypealreadyredirected, _configunknownvalue, _connectcantcreatechannelsink, _contextsbadproperty, _contextscontextnotfrozenforcallback, _contextsnoproperty, _default, _disconnected, _handlernotregistered;
    IMessageDescription? _internalerror, _invalidcallingtype, _invalidmsg, _invalidrequestedtype, _lifetimeileasereturn, _lifetimeinitialstateinitialleasetime, _lifetimeinitialstaterenewoncall, _lifetimeinitialstatesponsorshiptimeout, _lifetimesetonce, _messageargmismatch;
    IMessageDescription? _messagebadasyncresult, _messagebadserialization, _messagebadtype, _messagecoercionfailed, _messagemethodmissing, _messagemissingargvalue, _noidentityentry, _nonpublicorstaticcantbecalledremotely, _notremotablebyreference, _nullmessage;
    IMessageDescription? _proxybadreturntype, _proxybadreturntypeforactivation, _proxybadtype, _proxybadtypeforactivation, _proxyexpectedoriginalmessage, _proxyinvalidcall, _proxyinvalidcalltype, _proxyinvalidstate, _proxynochannelsink, _proxyproxytypeisnotmbr;
    IMessageDescription? _proxyreturnvaluetypecannotbenull, _proxywrongcontext, _reseturi, _serverobjectnotfound, _setobjecturiformarshalobjectneedstobelocal, _setobjecturiformarshaluriexists, _soapinteropxsdinvalid, _soapqnamenamespace, _trackinghandleralreadyregistered, _unexpectednulltp;
    IMessageDescription? _uriclash, _uriexists, _uritoproxy, _wellknowncantdirectlyconnect, _wellknownctorcantmarshal, _wellknownmustbembr, _appdomainunloaded, _appdomainunloadedthreadunwound, _cantremotepointertype, _configinvalidtimeformat;
    IMessageDescription? _configmissingtypeattribute, _configmissingwellknownmodeattribute, _configmissingxmltypeattribute, _confignontemplateidattribute, _configpreloadrequirestypeorassembly, _configproviderneedselementname, _configrequiredxmlattribute, _configtemplatecannotreferencetemplate, _configunabletoresolvetemplate, _configversionpresent;
    IMessageDescription? _delegatetoomanytargets, _invalidcontext, _invalidvaluetypefieldaccess, _messagebadretvaloroutarg, _tpnonnull, _threadaffinityinvalidflag, _typecantberemoted;
    
    /// <summary>Async Activation not supported.</summary>
    public IMessageDescription ActivationAsyncUnsupported { get => _activationasyncunsupported!; set => this.AssertWritable()._activationasyncunsupported = value; }
    /// <summary>Activation attribute does not implement the IContextAttribute interface.</summary>
    public IMessageDescription ActivationBadAttribute { get => _activationbadattribute!; set => this.AssertWritable()._activationbadattribute = value; }
    /// <summary>Proxy Attribute returned an incompatible object when constructing an instance of type {0}.</summary>
    public IMessageDescription ActivationBadObject { get => _activationbadobject!; set => this.AssertWritable()._activationbadobject = value; }
    /// <summary>An attempt to connect to the remote activator failed with exception &#39;{0}&#39;.</summary>
    public IMessageDescription ActivationConnectFailed { get => _activationconnectfailed!; set => this.AssertWritable()._activationconnectfailed = value; }
    /// <summary>Activation failed due to an unknown reason.</summary>
    public IMessageDescription ActivationFailed { get => _activationfailed!; set => this.AssertWritable()._activationfailed = value; }
    /// <summary>Inconsistent state during activation; there may be two proxies for the same object.</summary>
    public IMessageDescription ActivationInconsistentState { get => _activationinconsistentstate!; set => this.AssertWritable()._activationinconsistentstate = value; }
    /// <summary>Proxy Attributes are supported on ContextBound types only.</summary>
    public IMessageDescription ActivationMBRProxyAttribute { get => _activationmbrproxyattribute!; set => this.AssertWritable()._activationmbrproxyattribute = value; }
    /// <summary>Cannot find an entry for remote application &#39;{0}&#39;.</summary>
    public IMessageDescription ActivationMissingRemoteAppEntry { get => _activationmissingremoteappentry!; set => this.AssertWritable()._activationmissingremoteappentry = value; }
    /// <summary>InternalUnmarshal of returned ObjRef from activation call returned null.</summary>
    public IMessageDescription ActivationNullFromInternalUnmarshal { get => _activationnullfrominternalunmarshal!; set => this.AssertWritable()._activationnullfrominternalunmarshal = value; }
    /// <summary>Return value of construction call was null.</summary>
    public IMessageDescription ActivationNullReturnValue { get => _activationnullreturnvalue!; set => this.AssertWritable()._activationnullreturnvalue = value; }
    /// <summary>Type &#39;{0}&#39; is not registered for activation.</summary>
    public IMessageDescription ActivationPermissionDenied { get => _activationpermissiondenied!; set => this.AssertWritable()._activationpermissiondenied = value; }
    /// <summary>A context property did not approve the candidate context for activating the object.</summary>
    public IMessageDescription ActivationPropertyUnhappy { get => _activationpropertyunhappy!; set => this.AssertWritable()._activationpropertyunhappy = value; }
    /// <summary>Cannot run a non-default constructor when connecting to well-known objects.</summary>
    public IMessageDescription ActivationWellKnownCTOR { get => _activationwellknownctor!; set => this.AssertWritable()._activationwellknownctor = value; }
    /// <summary>Cannot resolve the invocation to the correct constructor.</summary>
    public IMessageDescription AmbiguousCTOR { get => _ambiguousctor!; set => this.AssertWritable()._ambiguousctor = value; }
    /// <summary>Cannot resolve the invocation to the correct method.</summary>
    public IMessageDescription AmbiguousMethod { get => _ambiguousmethod!; set => this.AssertWritable()._ambiguousmethod = value; }
    /// <summary>This feature is not yet supported for cross-application domain.</summary>
    public IMessageDescription AppDomainsNYI { get => _appdomainsnyi!; set => this.AssertWritable()._appdomainsnyi = value; }
    /// <summary>Permission denied: cannot call methods on the AppDomain class remotely.</summary>
    public IMessageDescription AppDomainsCantBeCalledRemotely { get => _appdomainscantbecalledremotely!; set => this.AssertWritable()._appdomainscantbecalledremotely = value; }
    /// <summary>Cannot load assembly &#39;{0}&#39;.</summary>
    public IMessageDescription AssemblyLoadFailed { get => _assemblyloadfailed!; set => this.AssertWritable()._assemblyloadfailed = value; }
    /// <summary>UseAttribute not allowed in SoapTypeAttribute.</summary>
    public IMessageDescription AttributeUseAttributeNotsettable { get => _attributeuseattributenotsettable!; set => this.AssertWritable()._attributeuseattributenotsettable = value; }
    /// <summary>Remoting cannot find field &#39;{0}&#39; on type &#39;{1}&#39;.</summary>
    public IMessageDescription BadField { get => _badfield!; set => this.AssertWritable()._badfield = value; }
    /// <summary>Invalid internal state: Activation service failed to initialize.</summary>
    public IMessageDescription BadInternalStateActivationFailure { get => _badinternalstateactivationfailure!; set => this.AssertWritable()._badinternalstateactivationfailure = value; }
    /// <summary>Invalid internal state: Failed to create an envoy sink for the object.</summary>
    public IMessageDescription BadInternalStateFailEnvoySink { get => _badinternalstatefailenvoysink!; set => this.AssertWritable()._badinternalstatefailenvoysink = value; }
    /// <summary>Invalid internal state: A marshal by ref object should not have a proxy in its own AppDomain.</summary>
    public IMessageDescription BadInternalStateProxySameAppDomain { get => _badinternalstateproxysameappdomain!; set => this.AssertWritable()._badinternalstateproxysameappdomain = value; }
    /// <summary>Cannot load type &#39;{0}&#39;.</summary>
    public IMessageDescription BadType { get => _badtype!; set => this.AssertWritable()._badtype = value; }
    /// <summary>Cannot call disconnect on a proxy.</summary>
    public IMessageDescription CantDisconnectClientProxy { get => _cantdisconnectclientproxy!; set => this.AssertWritable()._cantdisconnectclientproxy = value; }
    /// <summary>Cannot invoke methods on IRemoteDispatch.</summary>
    public IMessageDescription CantInvokeIRemoteDispatch { get => _cantinvokeiremotedispatch!; set => this.AssertWritable()._cantinvokeiremotedispatch = value; }
    /// <summary>Channel {0} cannot be secured. Please consider using a channel that implements ISecurableChannel</summary>
    public IMessageDescription ChannelCannotBeSecured { get => _channelcannotbesecured!; set => this.AssertWritable()._channelcannotbesecured = value; }
    /// <summary>Cannot call the AsyncProcessResponse method on the previous channel sink because the stack is empty.</summary>
    public IMessageDescription ChannelCantCallAPRWhenStackEmpty { get => _channelcantcallaprwhenstackempty!; set => this.AssertWritable()._channelcantcallaprwhenstackempty = value; }
    /// <summary>Called FlipRememberedStack() when stack was not null.</summary>
    public IMessageDescription ChannelCantCallFRSWhenStackEmtpy { get => _channelcantcallfrswhenstackemtpy!; set => this.AssertWritable()._channelcantcallfrswhenstackemtpy = value; }
    /// <summary>Cannot call the GetResponseStream method on the previous channel sink because the stack is empty.</summary>
    public IMessageDescription ChannelCantCallGetResponseStreamWhenStackEmpty { get => _channelcantcallgetresponsestreamwhenstackempty!; set => this.AssertWritable()._channelcantcallgetresponsestreamwhenstackempty = value; }
    /// <summary>No message was deserialized prior to calling the DispatchChannelSink.</summary>
    public IMessageDescription ChannelDispatchSinkMessageMissing { get => _channeldispatchsinkmessagemissing!; set => this.AssertWritable()._channeldispatchsinkmessagemissing = value; }
    /// <summary>The request stream should be null when the DispatchChannelSink is called.</summary>
    public IMessageDescription ChannelDispatchSinkWantsNullRequestStream { get => _channeldispatchsinkwantsnullrequeststream!; set => this.AssertWritable()._channeldispatchsinkwantsnullrequeststream = value; }
    /// <summary>A channel sink tried to pop data from the stack without first pushing data onto the stack.</summary>
    public IMessageDescription ChannelPopFromSinkStackWithoutPush { get => _channelpopfromsinkstackwithoutpush!; set => this.AssertWritable()._channelpopfromsinkstackwithoutpush = value; }
    /// <summary>Tried to pop data from an empty channel sink stack.</summary>
    public IMessageDescription ChannelPopOnEmptySinkStack { get => _channelpoponemptysinkstack!; set => this.AssertWritable()._channelpoponemptysinkstack = value; }
    /// <summary>A channel sink called the Store method when the sink stack was empty.</summary>
    public IMessageDescription ChannelStoreOnEmptySinkStack { get => _channelstoreonemptysinkstack!; set => this.AssertWritable()._channelstoreonemptysinkstack = value; }
    /// <summary>A channel sink called the Store method on the sink stack without first pushing data onto the stack.</summary>
    public IMessageDescription ChannelStoreOnSinkStackWithoutPush { get => _channelstoreonsinkstackwithoutpush!; set => this.AssertWritable()._channelstoreonsinkstackwithoutpush = value; }
    /// <summary>The channel &#39;{0}&#39; is already registered.</summary>
    public IMessageDescription ChannelNameAlreadyRegistered { get => _channelnamealreadyregistered!; set => this.AssertWritable()._channelnamealreadyregistered = value; }
    /// <summary>The channel &#39;{0}&#39; is not registered with remoting services.</summary>
    public IMessageDescription ChannelNotRegistered { get => _channelnotregistered!; set => this.AssertWritable()._channelnotregistered = value; }
    /// <summary>The remoting application name, &#39;{0}&#39;, had already been set.</summary>
    public IMessageDescription ConfigAppNameSet { get => _configappnameset!; set => this.AssertWritable()._configappnameset = value; }
    /// <summary>Attempt to redirect activation for type &#39;{0}, {1}&#39;. This is not allowed since either a well-known service type has already been registered with that type or that type has been registered has a activated service type.</summary>
    public IMessageDescription ConfigCantRedirectActivationOfWellKnownService { get => _configcantredirectactivationofwellknownservice!; set => this.AssertWritable()._configcantredirectactivationofwellknownservice = value; }
    /// <summary>Attempt to register a well-known or activated service type of type &#39;{0}, {1}&#39;. This is not allowed since the type has already been redirected to activate elsewhere.</summary>
    public IMessageDescription ConfigCantUseRedirectedTypeForWellKnownService { get => _configcantuseredirectedtypeforwellknownservice!; set => this.AssertWritable()._configcantuseredirectedtypeforwellknownservice = value; }
    /// <summary>To be used from a .config file, the channel type &#39;{0}&#39; must have a constructor of the form &#39;{1}&#39;</summary>
    public IMessageDescription ConfigChannelMissingCtor { get => _configchannelmissingctor!; set => this.AssertWritable()._configchannelmissingctor = value; }
    /// <summary>Remoting configuration failed with the exception &#39;{0}&#39;.</summary>
    public IMessageDescription ConfigConfigurationFailure { get => _configconfigurationfailure!; set => this.AssertWritable()._configconfigurationfailure = value; }
    /// <summary>The remoting custom errors mode had already been set.</summary>
    public IMessageDescription ConfigErrorsModeSet { get => _configerrorsmodeset!; set => this.AssertWritable()._configerrorsmodeset = value; }
    /// <summary>&#39;{0}&#39; does not implement IChannelReceiver or IChannelSender. All channels must implement one of these interfaces.</summary>
    public IMessageDescription ConfigInvalidChannelType { get => _configinvalidchanneltype!; set => this.AssertWritable()._configinvalidchanneltype = value; }
    /// <summary>Unable to use &#39;{0}&#39; as a channel sink provider. It does not implement &#39;{1}&#39;.</summary>
    public IMessageDescription ConfigInvalidSinkProviderType { get => _configinvalidsinkprovidertype!; set => this.AssertWritable()._configinvalidsinkprovidertype = value; }
    /// <summary>Improper remoting configuration: missing ApplicationName property.</summary>
    public IMessageDescription ConfigNoAppName { get => _confignoappname!; set => this.AssertWritable()._confignoappname = value; }
    /// <summary>There can be only one &#39;{0}&#39; node in the &#39;{1}&#39; section of a config file.</summary>
    public IMessageDescription ConfigNodeMustBeUnique { get => _confignodemustbeunique!; set => this.AssertWritable()._confignodemustbeunique = value; }
    /// <summary>.Config file &#39;{0}&#39; cannot be read successfully due to exception &#39;{1}&#39;.</summary>
    public IMessageDescription ConfigReadFailure { get => _configreadfailure!; set => this.AssertWritable()._configreadfailure = value; }
    /// <summary>To be used from a .config file, the sink provider type &#39;{0}&#39; must have a constructor of the form &#39;{1}&#39;</summary>
    public IMessageDescription ConfigSinkProviderMissingCtor { get => _configsinkprovidermissingctor!; set => this.AssertWritable()._configsinkprovidermissingctor = value; }
    /// <summary>A sink provider of type &#39;{0}&#39; is incorrectly labeled as a &#39;formatter&#39;.</summary>
    public IMessageDescription ConfigSinkProviderNotFormatter { get => _configsinkprovidernotformatter!; set => this.AssertWritable()._configsinkprovidernotformatter = value; }
    /// <summary>Attempt to redirect activation of type &#39;{0}, {1}&#39; which is already redirected.</summary>
    public IMessageDescription ConfigTypeAlreadyRedirected { get => _configtypealreadyredirected!; set => this.AssertWritable()._configtypealreadyredirected = value; }
    /// <summary>Unknown value {1} was found on the {0} node.</summary>
    public IMessageDescription ConfigUnknownValue { get => _configunknownvalue!; set => this.AssertWritable()._configunknownvalue = value; }
    /// <summary>Cannot create channel sink to connect to URL &#39;{0}&#39;. An appropriate channel has probably not been registered.</summary>
    public IMessageDescription ConnectCantCreateChannelSink { get => _connectcantcreatechannelsink!; set => this.AssertWritable()._connectcantcreatechannelsink = value; }
    /// <summary>A property that contributed a bad sink to the chain was found.</summary>
    public IMessageDescription ContextsBadProperty { get => _contextsbadproperty!; set => this.AssertWritable()._contextsbadproperty = value; }
    /// <summary>Context should be frozen before calling the DoCallBack method.</summary>
    public IMessageDescription ContextsContextNotFrozenForCallBack { get => _contextscontextnotfrozenforcallback!; set => this.AssertWritable()._contextscontextnotfrozenforcallback = value; }
    /// <summary>A property with the name &#39;{0}&#39; was not found.</summary>
    public IMessageDescription ContextsNoProperty { get => _contextsnoproperty!; set => this.AssertWritable()._contextsnoproperty = value; }
    /// <summary>System.Runtime.Remoting</summary>
    public IMessageDescription Default { get => _default!; set => this.AssertWritable()._default = value; }
    /// <summary>Object &#39;{0}&#39; has been disconnected or does not exist at the server.</summary>
    public IMessageDescription Disconnected { get => _disconnected!; set => this.AssertWritable()._disconnected = value; }
    /// <summary>The tracking handler of type &#39;{0}&#39; is not registered with Remoting Services.</summary>
    public IMessageDescription HandlerNotRegistered { get => _handlernotregistered!; set => this.AssertWritable()._handlernotregistered = value; }
    /// <summary>Server encountered an internal error. For more information, turn off customErrors in the server&#39;s .config file.</summary>
    public IMessageDescription InternalError { get => _internalerror!; set => this.AssertWritable()._internalerror = value; }
    /// <summary>Attempted to call a method declared on type &#39;{0}&#39; on an object which exposes &#39;{1}&#39;.</summary>
    public IMessageDescription InvalidCallingType { get => _invalidcallingtype!; set => this.AssertWritable()._invalidcallingtype = value; }
    /// <summary>Invalid Message Object.</summary>
    public IMessageDescription InvalidMsg { get => _invalidmsg!; set => this.AssertWritable()._invalidmsg = value; }
    /// <summary>The server object type cannot be cast to the requested type &#39;{0}&#39;.</summary>
    public IMessageDescription InvalidRequestedType { get => _invalidrequestedtype!; set => this.AssertWritable()._invalidrequestedtype = value; }
    /// <summary>Expected a return object of type ILease, but received &#39;{0}&#39;.</summary>
    public IMessageDescription LifetimeILeaseReturn { get => _lifetimeileasereturn!; set => this.AssertWritable()._lifetimeileasereturn = value; }
    /// <summary>InitialLeaseTime property can only be set when the lease is in initial state. The state is &#39;{0}&#39;.</summary>
    public IMessageDescription LifetimeInitialStateInitialLeaseTime { get => _lifetimeinitialstateinitialleasetime!; set => this.AssertWritable()._lifetimeinitialstateinitialleasetime = value; }
    /// <summary>RenewOnCallTime property can only be set when the lease is in initial state. The state is &#39;{0}&#39;.</summary>
    public IMessageDescription LifetimeInitialStateRenewOnCall { get => _lifetimeinitialstaterenewoncall!; set => this.AssertWritable()._lifetimeinitialstaterenewoncall = value; }
    /// <summary>SponsorshipTimeout property can only be set when the lease is in initial state. State is &#39;{0}&#39;.</summary>
    public IMessageDescription LifetimeInitialStateSponsorshipTimeout { get => _lifetimeinitialstatesponsorshiptimeout!; set => this.AssertWritable()._lifetimeinitialstatesponsorshiptimeout = value; }
    /// <summary>&#39;{0}&#39; can only be set once within an AppDomain.</summary>
    public IMessageDescription LifetimeSetOnce { get => _lifetimesetonce!; set => this.AssertWritable()._lifetimesetonce = value; }
    /// <summary>{2} arguments were passed to &#39;{0}::{1}&#39;. {3} arguments were expected by this method.</summary>
    public IMessageDescription MessageArgMismatch { get => _messageargmismatch!; set => this.AssertWritable()._messageargmismatch = value; }
    /// <summary>The async result object is null or of an unexpected type.</summary>
    public IMessageDescription MessageBadAsyncResult { get => _messagebadasyncresult!; set => this.AssertWritable()._messagebadasyncresult = value; }
    /// <summary>Invalid or malformed serialization information for the message object.</summary>
    public IMessageDescription MessageBadSerialization { get => _messagebadserialization!; set => this.AssertWritable()._messagebadserialization = value; }
    /// <summary>The method was called with a Message of an unexpected type.</summary>
    public IMessageDescription MessageBadType { get => _messagebadtype!; set => this.AssertWritable()._messagebadtype = value; }
    /// <summary>The argument type &#39;{0}&#39; cannot be converted into parameter type &#39;{1}&#39;.</summary>
    public IMessageDescription MessageCoercionFailed { get => _messagecoercionfailed!; set => this.AssertWritable()._messagecoercionfailed = value; }
    /// <summary>The method &#39;{0}&#39; was not found on the interface/type &#39;{1}&#39;.</summary>
    public IMessageDescription MessageMethodMissing { get => _messagemethodmissing!; set => this.AssertWritable()._messagemethodmissing = value; }
    /// <summary>Expecting an instance of type &#39;{0}&#39; at pos {1} in the args array.</summary>
    public IMessageDescription MessageMissingArgValue { get => _messagemissingargvalue!; set => this.AssertWritable()._messagemissingargvalue = value; }
    /// <summary>No remoting information was found for this object.</summary>
    public IMessageDescription NoIdentityEntry { get => _noidentityentry!; set => this.AssertWritable()._noidentityentry = value; }
    /// <summary>Permission denied: cannot call non-public or static methods remotely.</summary>
    public IMessageDescription NonPublicOrStaticCantBeCalledRemotely { get => _nonpublicorstaticcantbecalledremotely!; set => this.AssertWritable()._nonpublicorstaticcantbecalledremotely = value; }
    /// <summary>Trying to create a proxy to an unbound type.</summary>
    public IMessageDescription NotRemotableByReference { get => _notremotablebyreference!; set => this.AssertWritable()._notremotablebyreference = value; }
    /// <summary>The method was called with a null message.</summary>
    public IMessageDescription NullMessage { get => _nullmessage!; set => this.AssertWritable()._nullmessage = value; }
    /// <summary>Return argument has an invalid type.</summary>
    public IMessageDescription ProxyBadReturnType { get => _proxybadreturntype!; set => this.AssertWritable()._proxybadreturntype = value; }
    /// <summary>Bad return type for activation call via Invoke: must be of type IConstructionReturnMessage.</summary>
    public IMessageDescription ProxyBadReturnTypeForActivation { get => _proxybadreturntypeforactivation!; set => this.AssertWritable()._proxybadreturntypeforactivation = value; }
    /// <summary>The proxy is of an unsupported type.</summary>
    public IMessageDescription ProxyBadType { get => _proxybadtype!; set => this.AssertWritable()._proxybadtype = value; }
    /// <summary>Type mismatch between proxy type &#39;{0}&#39; and activation type &#39;{1}&#39;.</summary>
    public IMessageDescription ProxyBadTypeForActivation { get => _proxybadtypeforactivation!; set => this.AssertWritable()._proxybadtypeforactivation = value; }
    /// <summary>The message passed to Invoke should be passed to PropagateOutParameters.</summary>
    public IMessageDescription ProxyExpectedOriginalMessage { get => _proxyexpectedoriginalmessage!; set => this.AssertWritable()._proxyexpectedoriginalmessage = value; }
    /// <summary>Trying to call proxy while constructor call is in progress.</summary>
    public IMessageDescription ProxyInvalidCall { get => _proxyinvalidcall!; set => this.AssertWritable()._proxyinvalidcall = value; }
    /// <summary>Only the synchronous call type is supported for messages that are not of type Message.</summary>
    public IMessageDescription ProxyInvalidCallType { get => _proxyinvalidcalltype!; set => this.AssertWritable()._proxyinvalidcalltype = value; }
    /// <summary>Channel sink does not exist. Failed to dispatch async call.</summary>
    public IMessageDescription ProxyInvalidState { get => _proxyinvalidstate!; set => this.AssertWritable()._proxyinvalidstate = value; }
    /// <summary>This remoting proxy has no channel sink which means either the server has no registered server channels that are listening, or this application has no suitable client channel to talk to the server.</summary>
    public IMessageDescription ProxyNoChannelSink { get => _proxynochannelsink!; set => this.AssertWritable()._proxynochannelsink = value; }
    /// <summary>classToProxy argument must derive from MarshalByRef type.</summary>
    public IMessageDescription ProxyProxyTypeIsNotMBR { get => _proxyproxytypeisnotmbr!; set => this.AssertWritable()._proxyproxytypeisnotmbr = value; }
    /// <summary>ByRef value type parameter cannot be null.</summary>
    public IMessageDescription ProxyReturnValueTypeCannotBeNull { get => _proxyreturnvaluetypecannotbenull!; set => this.AssertWritable()._proxyreturnvaluetypecannotbenull = value; }
    /// <summary>ExecuteMessage can be called only from the native context of the object.</summary>
    public IMessageDescription ProxyWrongContext { get => _proxywrongcontext!; set => this.AssertWritable()._proxywrongcontext = value; }
    /// <summary>Attempt to reset the URI for an object from &#39;{0}&#39; to &#39;{1}&#39;.</summary>
    public IMessageDescription ResetURI { get => _reseturi!; set => this.AssertWritable()._reseturi = value; }
    /// <summary>The server object for URI &#39;{0}&#39; is not registered with the remoting infrastructure (it may have been disconnected).</summary>
    public IMessageDescription ServerObjectNotFound { get => _serverobjectnotfound!; set => this.AssertWritable()._serverobjectnotfound = value; }
    /// <summary>SetObjectUriForMarshal method should only be called for MarshalByRefObjects that exist in the current AppDomain.</summary>
    public IMessageDescription SetObjectUriForMarshalObjectNeedsToBeLocal { get => _setobjecturiformarshalobjectneedstobelocal!; set => this.AssertWritable()._setobjecturiformarshalobjectneedstobelocal = value; }
    /// <summary>SetObjectUriForMarshal method has already been called on this object or the object has already been marshaled.</summary>
    public IMessageDescription SetObjectUriForMarshalUriExists { get => _setobjecturiformarshaluriexists!; set => this.AssertWritable()._setobjecturiformarshaluriexists = value; }
    /// <summary>Soap Parse error, xsd:type &#39;{0}&#39; invalid {1}</summary>
    public IMessageDescription SOAPInteropxsdInvalid { get => _soapinteropxsdinvalid!; set => this.AssertWritable()._soapinteropxsdinvalid = value; }
    /// <summary>SoapQName missing a Namespace value &#39;{0}&#39;.</summary>
    public IMessageDescription SOAPQNameNamespace { get => _soapqnamenamespace!; set => this.AssertWritable()._soapqnamenamespace = value; }
    /// <summary>The handler has already been registered with TrackingServices.</summary>
    public IMessageDescription TrackingHandlerAlreadyRegistered { get => _trackinghandleralreadyregistered!; set => this.AssertWritable()._trackinghandleralreadyregistered = value; }
    /// <summary>Failed to create a transparent proxy. If a custom RealProxy is being used ensure it sets the proxy type.</summary>
    public IMessageDescription UnexpectedNullTP { get => _unexpectednulltp!; set => this.AssertWritable()._unexpectednulltp = value; }
    /// <summary>Found two different objects associated with the same URI, &#39;{0}&#39;.</summary>
    public IMessageDescription URIClash { get => _uriclash!; set => this.AssertWritable()._uriclash = value; }
    /// <summary>The remoted object already has an associated URI.</summary>
    public IMessageDescription URIExists { get => _uriexists!; set => this.AssertWritable()._uriexists = value; }
    /// <summary>Trying to associate the URI with a proxy.</summary>
    public IMessageDescription URIToProxy { get => _uritoproxy!; set => this.AssertWritable()._uritoproxy = value; }
    /// <summary>Attempt to connect to a server using its object URI: &#39;{0}&#39;. A valid, complete URL must be used.</summary>
    public IMessageDescription WellKnownCantDirectlyConnect { get => _wellknowncantdirectlyconnect!; set => this.AssertWritable()._wellknowncantdirectlyconnect = value; }
    /// <summary>&#39;{0}&#39;: A well-known object cannot marshal itself in its constructor, or perform any action that would cause it to be marshaled (such as passing the &#39;this&#39; pointer as a parameter to a remote method).</summary>
    public IMessageDescription WellKnownCtorCantMarshal { get => _wellknownctorcantmarshal!; set => this.AssertWritable()._wellknownctorcantmarshal = value; }
    /// <summary>Attempted to create well-known object of type &#39;{0}&#39;. Well-known objects must derive from the MarshalByRefObject class.</summary>
    public IMessageDescription WellKnownMustBeMBR { get => _wellknownmustbembr!; set => this.AssertWritable()._wellknownmustbembr = value; }
    /// <summary>The target application domain has been unloaded.</summary>
    public IMessageDescription AppDomainUnloaded { get => _appdomainunloaded!; set => this.AssertWritable()._appdomainunloaded = value; }
    /// <summary>The application domain in which the thread was running has been unloaded.</summary>
    public IMessageDescription AppDomainUnloadedThreadUnwound { get => _appdomainunloadedthreadunwound!; set => this.AssertWritable()._appdomainunloadedthreadunwound = value; }
    /// <summary>Pointer types cannot be passed in a remote call.</summary>
    public IMessageDescription CantRemotePointerType { get => _cantremotepointertype!; set => this.AssertWritable()._cantremotepointertype = value; }
    /// <summary>Invalid time format &#39;{0}&#39;. Examples of valid time formats include 7D, 10H, 5M, 30S, or 20MS.</summary>
    public IMessageDescription ConfigInvalidTimeFormat { get => _configinvalidtimeformat!; set => this.AssertWritable()._configinvalidtimeformat = value; }
    /// <summary>&#39;{0}&#39; entries must contain a &#39;{1}&#39; attribute of the form &#39;typeName, assemblyName&#39;.</summary>
    public IMessageDescription ConfigMissingTypeAttribute { get => _configmissingtypeattribute!; set => this.AssertWritable()._configmissingtypeattribute = value; }
    /// <summary>Well-known service entries must contain a &#39;mode&#39; attribute with a value of &#39;Singleton&#39; or &#39;SingleCall&#39;.</summary>
    public IMessageDescription ConfigMissingWellKnownModeAttribute { get => _configmissingwellknownmodeattribute!; set => this.AssertWritable()._configmissingwellknownmodeattribute = value; }
    /// <summary>&#39;{0}&#39; entries must contain a &#39;{1}&#39; attribute of the form &#39;xmlTypeName, xmlTypeNamespace&#39;.</summary>
    public IMessageDescription ConfigMissingXmlTypeAttribute { get => _configmissingxmltypeattribute!; set => this.AssertWritable()._configmissingxmltypeattribute = value; }
    /// <summary>Only &#39;{0}&#39; templates can have an &#39;id&#39; attribute.</summary>
    public IMessageDescription ConfigNonTemplateIdAttribute { get => _confignontemplateidattribute!; set => this.AssertWritable()._confignontemplateidattribute = value; }
    /// <summary>Preload entries require a type or assembly attribute.</summary>
    public IMessageDescription ConfigPreloadRequiresTypeOrAssembly { get => _configpreloadrequirestypeorassembly!; set => this.AssertWritable()._configpreloadrequirestypeorassembly = value; }
    /// <summary>Sink providers must have an element name of &#39;formatter&#39; or &#39;provider&#39;.</summary>
    public IMessageDescription ConfigProviderNeedsElementName { get => _configproviderneedselementname!; set => this.AssertWritable()._configproviderneedselementname = value; }
    /// <summary>&#39;{0}&#39; entries require a &#39;{1}&#39; attribute.</summary>
    public IMessageDescription ConfigRequiredXmlAttribute { get => _configrequiredxmlattribute!; set => this.AssertWritable()._configrequiredxmlattribute = value; }
    /// <summary>A &#39;{0}&#39; template cannot reference another &#39;{0}&#39; template.</summary>
    public IMessageDescription ConfigTemplateCannotReferenceTemplate { get => _configtemplatecannotreferencetemplate!; set => this.AssertWritable()._configtemplatecannotreferencetemplate = value; }
    /// <summary>Cannot resolve &#39;{0}&#39; template reference: &#39;{1}&#39;.</summary>
    public IMessageDescription ConfigUnableToResolveTemplate { get => _configunabletoresolvetemplate!; set => this.AssertWritable()._configunabletoresolvetemplate = value; }
    /// <summary>Version information is present in the assembly name &#39;{0}&#39; which is not allowed for &#39;{1}&#39; entries.</summary>
    public IMessageDescription ConfigVersionPresent { get => _configversionpresent!; set => this.AssertWritable()._configversionpresent = value; }
    /// <summary>The delegate must have only one target.</summary>
    public IMessageDescription DelegateTooManyTargets { get => _delegatetoomanytargets!; set => this.AssertWritable()._delegatetoomanytargets = value; }
    /// <summary>The context is not valid.</summary>
    public IMessageDescription InvalidContext { get => _invalidcontext!; set => this.AssertWritable()._invalidcontext = value; }
    /// <summary>An attempt was made to calculate the address of a value type field on a remote object. This was likely caused by an attempt to directly get or set the value of a field within this embedded value type. Avoid this and instead provide and use access methods for each field in the object that will be accessed remotely.</summary>
    public IMessageDescription InvalidValueTypeFieldAccess { get => _invalidvaluetypefieldaccess!; set => this.AssertWritable()._invalidvaluetypefieldaccess = value; }
    /// <summary>Bad return value or out-argument inside the return message.</summary>
    public IMessageDescription MessageBadRetValOrOutArg { get => _messagebadretvaloroutarg!; set => this.AssertWritable()._messagebadretvaloroutarg = value; }
    /// <summary>The transparent proxy field of a real proxy must be null.</summary>
    public IMessageDescription TPNonNull { get => _tpnonnull!; set => this.AssertWritable()._tpnonnull = value; }
    /// <summary>The specified flag &#39;{0}&#39; does not have one of the valid values.</summary>
    public IMessageDescription ThreadAffinityInvalidFlag { get => _threadaffinityinvalidflag!; set => this.AssertWritable()._threadaffinityinvalidflag = value; }
    /// <summary>The given type cannot be passed in a remote call.</summary>
    public IMessageDescription TypeCantBeRemoted { get => _typecantberemoted!; set => this.AssertWritable()._typecantberemoted = value; }

    /// <summary>Initialize fields</summary>
    public override RemotingMessages Initialize() 
    {
        base.Initialize();
        Add(_activationasyncunsupported = new MessageDescription("mscorlib.Remoting_Activation_AsyncUnsupported", 0xA34504ED, new ParameterlessText("Async Activation not supported.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationbadattribute = new MessageDescription("mscorlib.Remoting_Activation_BadAttribute", 0xA34504EE, new ParameterlessText("Activation attribute does not implement the IContextAttribute interface.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationbadobject = new MessageDescription("mscorlib.Remoting_Activation_BadObject", 0xA34504EF, new FormatText("Proxy Attribute returned an incompatible object when constructing an instance of type {0}.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationconnectfailed = new MessageDescription("mscorlib.Remoting_Activation_ConnectFailed", 0xA34504F0, new FormatText("An attempt to connect to the remote activator failed with exception '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationfailed = new MessageDescription("mscorlib.Remoting_Activation_Failed", 0xA34504F1, new ParameterlessText("Activation failed due to an unknown reason.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationinconsistentstate = new MessageDescription("mscorlib.Remoting_Activation_InconsistentState", 0xA34504F2, new ParameterlessText("Inconsistent state during activation; there may be two proxies for the same object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationmbrproxyattribute = new MessageDescription("mscorlib.Remoting_Activation_MBR_ProxyAttribute", 0xA34504F3, new ParameterlessText("Proxy Attributes are supported on ContextBound types only.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationmissingremoteappentry = new MessageDescription("mscorlib.Remoting_Activation_MissingRemoteAppEntry", 0xA34504F4, new FormatText("Cannot find an entry for remote application '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationnullfrominternalunmarshal = new MessageDescription("mscorlib.Remoting_Activation_NullFromInternalUnmarshal", 0xA34504F5, new ParameterlessText("InternalUnmarshal of returned ObjRef from activation call returned null.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationnullreturnvalue = new MessageDescription("mscorlib.Remoting_Activation_NullReturnValue", 0xA34504F6, new ParameterlessText("Return value of construction call was null.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationpermissiondenied = new MessageDescription("mscorlib.Remoting_Activation_PermissionDenied", 0xA34504F7, new FormatText("Type '{0}' is not registered for activation.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationpropertyunhappy = new MessageDescription("mscorlib.Remoting_Activation_PropertyUnhappy", 0xA34504F8, new ParameterlessText("A context property did not approve the candidate context for activating the object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_activationwellknownctor = new MessageDescription("mscorlib.Remoting_Activation_WellKnownCTOR", 0xA34504F9, new ParameterlessText("Cannot run a non-default constructor when connecting to well-known objects.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_ambiguousctor = new MessageDescription("mscorlib.Remoting_AmbiguousCTOR", 0xA34504FA, new ParameterlessText("Cannot resolve the invocation to the correct constructor.")).SetHResult(0x8000211D).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.AmbiguousMatchException)));
        Add(_ambiguousmethod = new MessageDescription("mscorlib.Remoting_AmbiguousMethod", 0xA34504FB, new ParameterlessText("Cannot resolve the invocation to the correct method.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_appdomainsnyi = new MessageDescription("mscorlib.Remoting_AppDomains_NYI", 0xA34504FC, new ParameterlessText("This feature is not yet supported for cross-application domain.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_appdomainscantbecalledremotely = new MessageDescription("mscorlib.Remoting_AppDomainsCantBeCalledRemotely", 0xA34504FD, new ParameterlessText("Permission denied: cannot call methods on the AppDomain class remotely.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_assemblyloadfailed = new MessageDescription("mscorlib.Remoting_AssemblyLoadFailed", 0xA34504FE, new FormatText("Cannot load assembly '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_attributeuseattributenotsettable = new MessageDescription("mscorlib.Remoting_Attribute_UseAttributeNotsettable", 0xA34504FF, new ParameterlessText("UseAttribute not allowed in SoapTypeAttribute.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_badfield = new MessageDescription("mscorlib.Remoting_BadField", 0xA3450500, new FormatText("Remoting cannot find field '{0}' on type '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_badinternalstateactivationfailure = new MessageDescription("mscorlib.Remoting_BadInternalState_ActivationFailure", 0xA3450501, new ParameterlessText("Invalid internal state: Activation service failed to initialize.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_badinternalstatefailenvoysink = new MessageDescription("mscorlib.Remoting_BadInternalState_FailEnvoySink", 0xA3450502, new ParameterlessText("Invalid internal state: Failed to create an envoy sink for the object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_badinternalstateproxysameappdomain = new MessageDescription("mscorlib.Remoting_BadInternalState_ProxySameAppDomain", 0xA3450503, new ParameterlessText("Invalid internal state: A marshal by ref object should not have a proxy in its own AppDomain.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badtype = new MessageDescription("mscorlib.Remoting_BadType", 0xA3450504, new FormatText("Cannot load type '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_cantdisconnectclientproxy = new MessageDescription("mscorlib.Remoting_CantDisconnectClientProxy", 0xA3450505, new ParameterlessText("Cannot call disconnect on a proxy.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_cantinvokeiremotedispatch = new MessageDescription("mscorlib.Remoting_CantInvokeIRemoteDispatch", 0xA3450506, new ParameterlessText("Cannot invoke methods on IRemoteDispatch.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelcannotbesecured = new MessageDescription("mscorlib.Remoting_Channel_CannotBeSecured", 0xA3450507, new FormatText("Channel {0} cannot be secured. Please consider using a channel that implements ISecurableChannel")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelcantcallaprwhenstackempty = new MessageDescription("mscorlib.Remoting_Channel_CantCallAPRWhenStackEmpty", 0xA3450508, new ParameterlessText("Cannot call the AsyncProcessResponse method on the previous channel sink because the stack is empty.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelcantcallfrswhenstackemtpy = new MessageDescription("mscorlib.Remoting_Channel_CantCallFRSWhenStackEmtpy", 0xA3450509, new ParameterlessText("Called FlipRememberedStack() when stack was not null.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelcantcallgetresponsestreamwhenstackempty = new MessageDescription("mscorlib.Remoting_Channel_CantCallGetResponseStreamWhenStackEmpty", 0xA345050A, new ParameterlessText("Cannot call the GetResponseStream method on the previous channel sink because the stack is empty.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channeldispatchsinkmessagemissing = new MessageDescription("mscorlib.Remoting_Channel_DispatchSinkMessageMissing", 0xA345050B, new ParameterlessText("No message was deserialized prior to calling the DispatchChannelSink.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_channeldispatchsinkwantsnullrequeststream = new MessageDescription("mscorlib.Remoting_Channel_DispatchSinkWantsNullRequestStream", 0xA345050C, new ParameterlessText("The request stream should be null when the DispatchChannelSink is called.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelpopfromsinkstackwithoutpush = new MessageDescription("mscorlib.Remoting_Channel_PopFromSinkStackWithoutPush", 0xA345050D, new ParameterlessText("A channel sink tried to pop data from the stack without first pushing data onto the stack.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelpoponemptysinkstack = new MessageDescription("mscorlib.Remoting_Channel_PopOnEmptySinkStack", 0xA345050E, new ParameterlessText("Tried to pop data from an empty channel sink stack.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelstoreonemptysinkstack = new MessageDescription("mscorlib.Remoting_Channel_StoreOnEmptySinkStack", 0xA345050F, new ParameterlessText("A channel sink called the Store method when the sink stack was empty.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelstoreonsinkstackwithoutpush = new MessageDescription("mscorlib.Remoting_Channel_StoreOnSinkStackWithoutPush", 0xA3450510, new ParameterlessText("A channel sink called the Store method on the sink stack without first pushing data onto the stack.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelnamealreadyregistered = new MessageDescription("mscorlib.Remoting_ChannelNameAlreadyRegistered", 0xA3450511, new FormatText("The channel '{0}' is already registered.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_channelnotregistered = new MessageDescription("mscorlib.Remoting_ChannelNotRegistered", 0xA3450512, new FormatText("The channel '{0}' is not registered with remoting services.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configappnameset = new MessageDescription("mscorlib.Remoting_Config_AppNameSet", 0xA3450513, new FormatText("The remoting application name, '{0}', had already been set.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configcantredirectactivationofwellknownservice = new MessageDescription("mscorlib.Remoting_Config_CantRedirectActivationOfWellKnownService", 0xA3450514, new FormatText("Attempt to redirect activation for type '{0}, {1}'. This is not allowed since either a well-known service type has already been registered with that type or that type has been registered has a activated service type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configcantuseredirectedtypeforwellknownservice = new MessageDescription("mscorlib.Remoting_Config_CantUseRedirectedTypeForWellKnownService", 0xA3450515, new FormatText("Attempt to register a well-known or activated service type of type '{0}, {1}'. This is not allowed since the type has already been redirected to activate elsewhere.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configchannelmissingctor = new MessageDescription("mscorlib.Remoting_Config_ChannelMissingCtor", 0xA3450516, new FormatText("To be used from a .config file, the channel type '{0}' must have a constructor of the form '{1}'")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configconfigurationfailure = new MessageDescription("mscorlib.Remoting_Config_ConfigurationFailure", 0xA3450517, new FormatText("Remoting configuration failed with the exception '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configerrorsmodeset = new MessageDescription("mscorlib.Remoting_Config_ErrorsModeSet", 0xA3450518, new ParameterlessText("The remoting custom errors mode had already been set.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configinvalidchanneltype = new MessageDescription("mscorlib.Remoting_Config_InvalidChannelType", 0xA3450519, new FormatText("'{0}' does not implement IChannelReceiver or IChannelSender. All channels must implement one of these interfaces.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configinvalidsinkprovidertype = new MessageDescription("mscorlib.Remoting_Config_InvalidSinkProviderType", 0xA345051A, new FormatText("Unable to use '{0}' as a channel sink provider. It does not implement '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_confignoappname = new MessageDescription("mscorlib.Remoting_Config_NoAppName", 0xA345051B, new ParameterlessText("Improper remoting configuration: missing ApplicationName property.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_confignodemustbeunique = new MessageDescription("mscorlib.Remoting_Config_NodeMustBeUnique", 0xA345051C, new FormatText("There can be only one '{0}' node in the '{1}' section of a config file.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configreadfailure = new MessageDescription("mscorlib.Remoting_Config_ReadFailure", 0xA345051D, new FormatText(".Config file '{0}' cannot be read successfully due to exception '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configsinkprovidermissingctor = new MessageDescription("mscorlib.Remoting_Config_SinkProviderMissingCtor", 0xA345051E, new FormatText("To be used from a .config file, the sink provider type '{0}' must have a constructor of the form '{1}'")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configsinkprovidernotformatter = new MessageDescription("mscorlib.Remoting_Config_SinkProviderNotFormatter", 0xA345051F, new FormatText("A sink provider of type '{0}' is incorrectly labeled as a 'formatter'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configtypealreadyredirected = new MessageDescription("mscorlib.Remoting_Config_TypeAlreadyRedirected", 0xA3450520, new FormatText("Attempt to redirect activation of type '{0}, {1}' which is already redirected.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configunknownvalue = new MessageDescription("mscorlib.Remoting_Config_UnknownValue", 0xA3450521, new FormatText("Unknown value {1} was found on the {0} node.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_connectcantcreatechannelsink = new MessageDescription("mscorlib.Remoting_Connect_CantCreateChannelSink", 0xA3450522, new FormatText("Cannot create channel sink to connect to URL '{0}'. An appropriate channel has probably not been registered.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_contextsbadproperty = new MessageDescription("mscorlib.Remoting_Contexts_BadProperty", 0xA3450523, new ParameterlessText("A property that contributed a bad sink to the chain was found.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_contextscontextnotfrozenforcallback = new MessageDescription("mscorlib.Remoting_Contexts_ContextNotFrozenForCallBack", 0xA3450524, new ParameterlessText("Context should be frozen before calling the DoCallBack method.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_contextsnoproperty = new MessageDescription("mscorlib.Remoting_Contexts_NoProperty", 0xA3450525, new FormatText("A property with the name '{0}' was not found.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_default = new MessageDescription("mscorlib.Remoting_Default", 0xA3450526, new ParameterlessText("Unknown remoting error.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.Remoting").SetException("System.Runtime.Remoting.RemotingException"));
        Add(_disconnected = new MessageDescription("mscorlib.Remoting_Disconnected", 0xA3450527, new FormatText("Object '{0}' has been disconnected or does not exist at the server.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_handlernotregistered = new MessageDescription("mscorlib.Remoting_HandlerNotRegistered", 0xA3450528, new FormatText("The tracking handler of type '{0}' is not registered with Remoting Services.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_internalerror = new MessageDescription("mscorlib.Remoting_InternalError", 0xA3450529, new ParameterlessText("Server encountered an internal error. For more information, turn off customErrors in the server's .config file.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_invalidcallingtype = new MessageDescription("mscorlib.Remoting_InvalidCallingType", 0xA345052A, new FormatText("Attempted to call a method declared on type '{0}' on an object which exposes '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_invalidmsg = new MessageDescription("mscorlib.Remoting_InvalidMsg", 0xA345052B, new ParameterlessText("Invalid Message Object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_invalidrequestedtype = new MessageDescription("mscorlib.Remoting_InvalidRequestedType", 0xA345052C, new FormatText("The server object type cannot be cast to the requested type '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_lifetimeileasereturn = new MessageDescription("mscorlib.Remoting_Lifetime_ILeaseReturn", 0xA345052D, new FormatText("Expected a return object of type ILease, but received '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_lifetimeinitialstateinitialleasetime = new MessageDescription("mscorlib.Remoting_Lifetime_InitialStateInitialLeaseTime", 0xA345052E, new FormatText("InitialLeaseTime property can only be set when the lease is in initial state. The state is '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_lifetimeinitialstaterenewoncall = new MessageDescription("mscorlib.Remoting_Lifetime_InitialStateRenewOnCall", 0xA345052F, new FormatText("RenewOnCallTime property can only be set when the lease is in initial state. The state is '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_lifetimeinitialstatesponsorshiptimeout = new MessageDescription("mscorlib.Remoting_Lifetime_InitialStateSponsorshipTimeout", 0xA3450530, new FormatText("SponsorshipTimeout property can only be set when the lease is in initial state. State is '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_lifetimesetonce = new MessageDescription("mscorlib.Remoting_Lifetime_SetOnce", 0xA3450531, new FormatText("'{0}' can only be set once within an AppDomain.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messageargmismatch = new MessageDescription("mscorlib.Remoting_Message_ArgMismatch", 0xA3450532, new FormatText("{2} arguments were passed to '{0}::{1}'. {3} arguments were expected by this method.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagebadasyncresult = new MessageDescription("mscorlib.Remoting_Message_BadAsyncResult", 0xA3450533, new ParameterlessText("The async result object is null or of an unexpected type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagebadserialization = new MessageDescription("mscorlib.Remoting_Message_BadSerialization", 0xA3450534, new ParameterlessText("Invalid or malformed serialization information for the message object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagebadtype = new MessageDescription("mscorlib.Remoting_Message_BadType", 0xA3450535, new ParameterlessText("The method was called with a Message of an unexpected type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagecoercionfailed = new MessageDescription("mscorlib.Remoting_Message_CoercionFailed", 0xA3450536, new FormatText("The argument type '{0}' cannot be converted into parameter type '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagemethodmissing = new MessageDescription("mscorlib.Remoting_Message_MethodMissing", 0xA3450537, new FormatText("The method '{0}' was not found on the interface/type '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagemissingargvalue = new MessageDescription("mscorlib.Remoting_Message_MissingArgValue", 0xA3450538, new FormatText("Expecting an instance of type '{0}' at pos {1} in the args array.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_noidentityentry = new MessageDescription("mscorlib.Remoting_NoIdentityEntry", 0xA3450539, new ParameterlessText("No remoting information was found for this object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_nonpublicorstaticcantbecalledremotely = new MessageDescription("mscorlib.Remoting_NonPublicOrStaticCantBeCalledRemotely", 0xA345053A, new ParameterlessText("Permission denied: cannot call non-public or static methods remotely.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_notremotablebyreference = new MessageDescription("mscorlib.Remoting_NotRemotableByReference", 0xA345053B, new ParameterlessText("Trying to create a proxy to an unbound type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_nullmessage = new MessageDescription("mscorlib.Remoting_NullMessage", 0xA345053C, new ParameterlessText("The method was called with a null message.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxybadreturntype = new MessageDescription("mscorlib.Remoting_Proxy_BadReturnType", 0xA345053D, new ParameterlessText("Return argument has an invalid type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxybadreturntypeforactivation = new MessageDescription("mscorlib.Remoting_Proxy_BadReturnTypeForActivation", 0xA345053E, new ParameterlessText("Bad return type for activation call via Invoke: must be of type IConstructionReturnMessage.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxybadtype = new MessageDescription("mscorlib.Remoting_Proxy_BadType", 0xA345053F, new ParameterlessText("The proxy is of an unsupported type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxybadtypeforactivation = new MessageDescription("mscorlib.Remoting_Proxy_BadTypeForActivation", 0xA3450540, new FormatText("Type mismatch between proxy type '{0}' and activation type '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxyexpectedoriginalmessage = new MessageDescription("mscorlib.Remoting_Proxy_ExpectedOriginalMessage", 0xA3450541, new ParameterlessText("The message passed to Invoke should be passed to PropagateOutParameters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_proxyinvalidcall = new MessageDescription("mscorlib.Remoting_Proxy_InvalidCall", 0xA3450542, new ParameterlessText("Trying to call proxy while constructor call is in progress.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxyinvalidcalltype = new MessageDescription("mscorlib.Remoting_Proxy_InvalidCallType", 0xA3450543, new ParameterlessText("Only the synchronous call type is supported for messages that are not of type Message.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxyinvalidstate = new MessageDescription("mscorlib.Remoting_Proxy_InvalidState", 0xA3450544, new ParameterlessText("Channel sink does not exist. Failed to dispatch async call.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_proxynochannelsink = new MessageDescription("mscorlib.Remoting_Proxy_NoChannelSink", 0xA3450545, new ParameterlessText("This remoting proxy has no channel sink which means either the server has no registered server channels that are listening, or this application has no suitable client channel to talk to the server.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxyproxytypeisnotmbr = new MessageDescription("mscorlib.Remoting_Proxy_ProxyTypeIsNotMBR", 0xA3450546, new ParameterlessText("classToProxy argument must derive from MarshalByRef type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_proxyreturnvaluetypecannotbenull = new MessageDescription("mscorlib.Remoting_Proxy_ReturnValueTypeCannotBeNull", 0xA3450547, new ParameterlessText("ByRef value type parameter cannot be null.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_proxywrongcontext = new MessageDescription("mscorlib.Remoting_Proxy_WrongContext", 0xA3450548, new ParameterlessText("ExecuteMessage can be called only from the native context of the object.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_reseturi = new MessageDescription("mscorlib.Remoting_ResetURI", 0xA3450549, new FormatText("Attempt to reset the URI for an object from '{0}' to '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_serverobjectnotfound = new MessageDescription("mscorlib.Remoting_ServerObjectNotFound", 0xA345054A, new FormatText("The server object for URI '{0}' is not registered with the remoting infrastructure (it may have been disconnected).")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_setobjecturiformarshalobjectneedstobelocal = new MessageDescription("mscorlib.Remoting_SetObjectUriForMarshal__ObjectNeedsToBeLocal", 0xA345054B, new ParameterlessText("SetObjectUriForMarshal method should only be called for MarshalByRefObjects that exist in the current AppDomain.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_setobjecturiformarshaluriexists = new MessageDescription("mscorlib.Remoting_SetObjectUriForMarshal__UriExists", 0xA345054C, new ParameterlessText("SetObjectUriForMarshal method has already been called on this object or the object has already been marshaled.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_soapinteropxsdinvalid = new MessageDescription("mscorlib.Remoting_SOAPInteropxsdInvalid", 0xA345054D, new FormatText("Soap Parse error, xsd:type '{0}' invalid {1}")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_soapqnamenamespace = new MessageDescription("mscorlib.Remoting_SOAPQNameNamespace", 0xA345054E, new FormatText("SoapQName missing a Namespace value '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_trackinghandleralreadyregistered = new MessageDescription("mscorlib.Remoting_TrackingHandlerAlreadyRegistered", 0xA345054F, new ParameterlessText("The handler has already been registered with TrackingServices.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_unexpectednulltp = new MessageDescription("mscorlib.Remoting_UnexpectedNullTP", 0xA3450550, new ParameterlessText("Failed to create a transparent proxy. If a custom RealProxy is being used ensure it sets the proxy type.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_uriclash = new MessageDescription("mscorlib.Remoting_URIClash", 0xA3450551, new FormatText("Found two different objects associated with the same URI, '{0}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_uriexists = new MessageDescription("mscorlib.Remoting_URIExists", 0xA3450552, new ParameterlessText("The remoted object already has an associated URI.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_uritoproxy = new MessageDescription("mscorlib.Remoting_URIToProxy", 0xA3450553, new ParameterlessText("Trying to associate the URI with a proxy.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_wellknowncantdirectlyconnect = new MessageDescription("mscorlib.Remoting_WellKnown_CantDirectlyConnect", 0xA3450554, new FormatText("Attempt to connect to a server using its object URI: '{0}'. A valid, complete URL must be used.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_wellknownctorcantmarshal = new MessageDescription("mscorlib.Remoting_WellKnown_CtorCantMarshal", 0xA3450555, new FormatText("'{0}': A well-known object cannot marshal itself in its constructor, or perform any action that would cause it to be marshaled (such as passing the 'this' pointer as a parameter to a remote method).")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_wellknownmustbembr = new MessageDescription("mscorlib.Remoting_WellKnown_MustBeMBR", 0xA3450556, new FormatText("Attempted to create well-known object of type '{0}'. Well-known objects must derive from the MarshalByRefObject class.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_appdomainunloaded = new MessageDescription("mscorlib.Remoting_AppDomainUnloaded", 0xA3450729, new ParameterlessText("The target application domain has been unloaded.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_appdomainunloadedthreadunwound = new MessageDescription("mscorlib.Remoting_AppDomainUnloaded_ThreadUnwound", 0xA3450728, new ParameterlessText("The application domain in which the thread was running has been unloaded.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_cantremotepointertype = new MessageDescription("mscorlib.Remoting_CantRemotePointerType", 0xA345072A, new ParameterlessText("Pointer types cannot be passed in a remote call.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configinvalidtimeformat = new MessageDescription("mscorlib.Remoting_Config_InvalidTimeFormat", 0xA3450731, new FormatText("Invalid time format '{0}'. Examples of valid time formats include 7D, 10H, 5M, 30S, or 20MS.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configmissingtypeattribute = new MessageDescription("mscorlib.Remoting_Config_MissingTypeAttribute", 0xA3450733, new FormatText("'{0}' entries must contain a '{1}' attribute of the form 'typeName, assemblyName'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configmissingwellknownmodeattribute = new MessageDescription("mscorlib.Remoting_Config_MissingWellKnownModeAttribute", 0xA3450732, new ParameterlessText("Well-known service entries must contain a 'mode' attribute with a value of 'Singleton' or 'SingleCall'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configmissingxmltypeattribute = new MessageDescription("mscorlib.Remoting_Config_MissingXmlTypeAttribute", 0xA3450734, new FormatText("'{0}' entries must contain a '{1}' attribute of the form 'xmlTypeName, xmlTypeNamespace'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_confignontemplateidattribute = new MessageDescription("mscorlib.Remoting_Config_NonTemplateIdAttribute", 0xA3450735, new FormatText("Only '{0}' templates can have an 'id' attribute.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configpreloadrequirestypeorassembly = new MessageDescription("mscorlib.Remoting_Config_PreloadRequiresTypeOrAssembly", 0xA3450736, new ParameterlessText("Preload entries require a type or assembly attribute.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configproviderneedselementname = new MessageDescription("mscorlib.Remoting_Config_ProviderNeedsElementName", 0xA3450737, new ParameterlessText("Sink providers must have an element name of 'formatter' or 'provider'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configrequiredxmlattribute = new MessageDescription("mscorlib.Remoting_Config_RequiredXmlAttribute", 0xA3450738, new FormatText("'{0}' entries require a '{1}' attribute.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configtemplatecannotreferencetemplate = new MessageDescription("mscorlib.Remoting_Config_TemplateCannotReferenceTemplate", 0xA3450739, new FormatText("A '{0}' template cannot reference another '{0}' template.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configunabletoresolvetemplate = new MessageDescription("mscorlib.Remoting_Config_UnableToResolveTemplate", 0xA345073A, new FormatText("Cannot resolve '{0}' template reference: '{1}'.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_configversionpresent = new MessageDescription("mscorlib.Remoting_Config_VersionPresent", 0xA345073B, new FormatText("Version information is present in the assembly name '{0}' which is not allowed for '{1}' entries.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_delegatetoomanytargets = new MessageDescription("mscorlib.Remoting_Delegate_TooManyTargets", 0xA345072C, new ParameterlessText("The delegate must have only one target.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_invalidcontext = new MessageDescription("mscorlib.Remoting_InvalidContext", 0xA345072D, new ParameterlessText("The context is not valid.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_invalidvaluetypefieldaccess = new MessageDescription("mscorlib.Remoting_InvalidValueTypeFieldAccess", 0xA345072E, new ParameterlessText("An attempt was made to calculate the address of a value type field on a remote object. This was likely caused by an attempt to directly get or set the value of a field within this embedded value type. Avoid this and instead provide and use access methods for each field in the object that will be accessed remotely.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_messagebadretvaloroutarg = new MessageDescription("mscorlib.Remoting_Message_BadRetValOrOutArg", 0xA345072F, new ParameterlessText("Bad return value or out-argument inside the return message.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_tpnonnull = new MessageDescription("mscorlib.Remoting_TP_NonNull", 0xA3450730, new ParameterlessText("The transparent proxy field of a real proxy must be null.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_threadaffinityinvalidflag = new MessageDescription("mscorlib.Remoting_ThreadAffinity_InvalidFlag", 0xA345073C, new FormatText("The specified flag '{0}' does not have one of the valid values.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_typecantberemoted = new MessageDescription("mscorlib.Remoting_TypeCantBeRemoted", 0xA345072B, new ParameterlessText("The given type cannot be passed in a remote call.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        return this;
    }    

}
