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

/// <summary>System.Security.Policy.*</summary>
public class PolicyMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<PolicyMessages> instance = new Lazy<PolicyMessages>(() => new PolicyMessages().Initialize().SetAllReadOnly<PolicyMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static PolicyMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x003C;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _apptrustmustgrantapprequest, _badxml, _default, _duplicateevidence, _evidencemustbeserializable, _grantsetdoesnotmatchdomain, _incorrecthostevidence, _missingactivationcontextinappevidence, _multipleexclusive, _noexecutionpermission;
    IMessageDescription? _nonfulltrustassembly, _norequiredpermission, _notrustmanager, _nullhostevidence, _nullhostgrantset, _plappdomain, _plenterprise, _plmachine, _pluser, _policyalreadyset;
    IMessageDescription? _principaltwice, _recovernoconfigfile, _recovernotfilebased, _unabletosave, _fileparse, _fileparseex, _allcodedescriptionfulltrust, _allcodedescriptionnothing, _allcodename, _cannotloadsemitrustassembliesduringinit;
    IMessageDescription? _ecmadescription, _ecmaname, _internetnetdescription, _internetnetname, _internetdescription, _internetname, _intranetfiledescription, _intranetfilename, _intranetnetdescription, _intranetnetname;
    IMessageDescription? _intranetdescription, _intranetname, _microsoftdescription, _microsoftname, _mycomputerdescription, _mycomputername, _pseverything, _psexecution, _psfulltrust, _psinternet;
    IMessageDescription? _pslocalintranet, _psnothing, _psskipverification, _savenotfilebased, _trustednetdescription, _trustednetname, _trusteddescription, _trustedname, _untrusteddescription, _untrustedname;
    
    /// <summary>ApplicationTrust grant set does not contain ActivationContext&#39;s minimum request set.</summary>
    public IMessageDescription AppTrustMustGrantAppRequest { get => _apptrustmustgrantapprequest!; set => this.AssertWritable()._apptrustmustgrantapprequest = value; }
    /// <summary>Policy configuration XML is invalid. The required tag &#39;{0}&#39; is missing.</summary>
    public IMessageDescription BadXml { get => _badxml!; set => this.AssertWritable()._badxml = value; }
    /// <summary>System.Security.Policy</summary>
    public IMessageDescription Default { get => _default!; set => this.AssertWritable()._default = value; }
    /// <summary>The evidence collection already contains evidence of type &#39;{0}&#39;. Multiple pieces of the same type of evidence are not allowed.</summary>
    public IMessageDescription DuplicateEvidence { get => _duplicateevidence!; set => this.AssertWritable()._duplicateevidence = value; }
    /// <summary>Objects used as evidence must be serializable.</summary>
    public IMessageDescription EvidenceMustBeSerializable { get => _evidencemustbeserializable!; set => this.AssertWritable()._evidencemustbeserializable = value; }
    /// <summary>An assembly was provided an invalid grant set by runtime host &#39;{0}&#39;. In a homogenous AppDomain, the only valid grant sets are FullTrust and the AppDomain&#39;s sandbox grant set.</summary>
    public IMessageDescription GrantSetDoesNotMatchDomain { get => _grantsetdoesnotmatchdomain!; set => this.AssertWritable()._grantsetdoesnotmatchdomain = value; }
    /// <summary>Runtime host &#39;{0}&#39; returned evidence of type &#39;{1}&#39; from a request for evidence of type &#39;{2}&#39;.</summary>
    public IMessageDescription IncorrectHostEvidence { get => _incorrecthostevidence!; set => this.AssertWritable()._incorrecthostevidence = value; }
    /// <summary>The application evidence does not contain a Fusion activation context.</summary>
    public IMessageDescription MissingActivationContextInAppEvidence { get => _missingactivationcontextinappevidence!; set => this.AssertWritable()._missingactivationcontextinappevidence = value; }
    /// <summary>More than one exclusive group is not allowed.</summary>
    public IMessageDescription MultipleExclusive { get => _multipleexclusive!; set => this.AssertWritable()._multipleexclusive = value; }
    /// <summary>Execution permission cannot be acquired.</summary>
    public IMessageDescription NoExecutionPermission { get => _noexecutionpermission!; set => this.AssertWritable()._noexecutionpermission = value; }
    /// <summary>Policy references an assembly not in the full trust assemblies list.</summary>
    public IMessageDescription NonFullTrustAssembly { get => _nonfulltrustassembly!; set => this.AssertWritable()._nonfulltrustassembly = value; }
    /// <summary>Required permissions cannot be acquired.</summary>
    public IMessageDescription NoRequiredPermission { get => _norequiredpermission!; set => this.AssertWritable()._norequiredpermission = value; }
    /// <summary>A trust manager could not be loaded for this application.</summary>
    public IMessageDescription NoTrustManager { get => _notrustmanager!; set => this.AssertWritable()._notrustmanager = value; }
    /// <summary>Runtime host &#39;{0}&#39; returned null when asked for assembly evidence for assembly &#39;{1}&#39;.</summary>
    public IMessageDescription NullHostEvidence { get => _nullhostevidence!; set => this.AssertWritable()._nullhostevidence = value; }
    /// <summary>Runtime host &#39;{0}&#39; returned a null grant set from ResolvePolicy.</summary>
    public IMessageDescription NullHostGrantSet { get => _nullhostgrantset!; set => this.AssertWritable()._nullhostgrantset = value; }
    /// <summary>AppDomain</summary>
    public IMessageDescription PLAppDomain { get => _plappdomain!; set => this.AssertWritable()._plappdomain = value; }
    /// <summary>Enterprise</summary>
    public IMessageDescription PLEnterprise { get => _plenterprise!; set => this.AssertWritable()._plenterprise = value; }
    /// <summary>Machine</summary>
    public IMessageDescription PLMachine { get => _plmachine!; set => this.AssertWritable()._plmachine = value; }
    /// <summary>User</summary>
    public IMessageDescription PLUser { get => _pluser!; set => this.AssertWritable()._pluser = value; }
    /// <summary>Policy for this domain cannot be set twice.</summary>
    public IMessageDescription PolicyAlreadySet { get => _policyalreadyset!; set => this.AssertWritable()._policyalreadyset = value; }
    /// <summary>Default principal object cannot be set twice.</summary>
    public IMessageDescription PrincipalTwice { get => _principaltwice!; set => this.AssertWritable()._principaltwice = value; }
    /// <summary>No old configuration file exists to recover.</summary>
    public IMessageDescription RecoverNoConfigFile { get => _recovernoconfigfile!; set => this.AssertWritable()._recovernoconfigfile = value; }
    /// <summary>PolicyLevel object not based on a file cannot be recovered.</summary>
    public IMessageDescription RecoverNotFileBased { get => _recovernotfilebased!; set => this.AssertWritable()._recovernotfilebased = value; }
    /// <summary>Policy level &#39;{0}&#39; could not be saved: {1}.</summary>
    public IMessageDescription UnableToSave { get => _unabletosave!; set => this.AssertWritable()._unabletosave = value; }
    /// <summary>Error occurred while parsing the &#39;{0}&#39; policy level. The default policy level was used instead.</summary>
    public IMessageDescription FileParse { get => _fileparse!; set => this.AssertWritable()._fileparse = value; }
    /// <summary>Error &#39;{1}&#39; occurred while parsing the &#39;{0}&#39; policy level. The default policy level was used instead.</summary>
    public IMessageDescription FileParseEx { get => _fileparseex!; set => this.AssertWritable()._fileparseex = value; }
    /// <summary>Code group grants all code full trust and forms the root of the code group tree.</summary>
    public IMessageDescription AllCodeDescriptionFullTrust { get => _allcodedescriptionfulltrust!; set => this.AssertWritable()._allcodedescriptionfulltrust = value; }
    /// <summary>Code group grants no permissions and forms the root of the code group tree.</summary>
    public IMessageDescription AllCodeDescriptionNothing { get => _allcodedescriptionnothing!; set => this.AssertWritable()._allcodedescriptionnothing = value; }
    /// <summary>All_Code</summary>
    public IMessageDescription AllCodeName { get => _allcodename!; set => this.AssertWritable()._allcodename = value; }
    /// <summary>All assemblies loaded as part of AppDomain initialization must be fully trusted.</summary>
    public IMessageDescription CannotLoadSemiTrustAssembliesDuringInit { get => _cannotloadsemitrustassembliesduringinit!; set => this.AssertWritable()._cannotloadsemitrustassembliesduringinit = value; }
    /// <summary>Code group grants full trust to code signed with the ECMA strong name.</summary>
    public IMessageDescription EcmaDescription { get => _ecmadescription!; set => this.AssertWritable()._ecmadescription = value; }
    /// <summary>ECMA_Strong_Name</summary>
    public IMessageDescription EcmaName { get => _ecmaname!; set => this.AssertWritable()._ecmaname = value; }
    /// <summary>All Internet code gets the right to connect back to the site of its origin.</summary>
    public IMessageDescription InternetNetDescription { get => _internetnetdescription!; set => this.AssertWritable()._internetnetdescription = value; }
    /// <summary>Internet_Same_Site_Access</summary>
    public IMessageDescription InternetNetName { get => _internetnetname!; set => this.AssertWritable()._internetnetname = value; }
    /// <summary>Code group grants code from the Internet zone the Internet permission set. This permission set grants Internet code the right to use isolated storage and limited UI access.</summary>
    public IMessageDescription InternetDescription { get => _internetdescription!; set => this.AssertWritable()._internetdescription = value; }
    /// <summary>Internet_Zone</summary>
    public IMessageDescription InternetName { get => _internetname!; set => this.AssertWritable()._internetname = value; }
    /// <summary>All intranet code gets the right to read from its install directory.</summary>
    public IMessageDescription IntranetFileDescription { get => _intranetfiledescription!; set => this.AssertWritable()._intranetfiledescription = value; }
    /// <summary>Intranet_Same_Directory_Access</summary>
    public IMessageDescription IntranetFileName { get => _intranetfilename!; set => this.AssertWritable()._intranetfilename = value; }
    /// <summary>All intranet code gets the right to connect back to the site of its origin.</summary>
    public IMessageDescription IntranetNetDescription { get => _intranetnetdescription!; set => this.AssertWritable()._intranetnetdescription = value; }
    /// <summary>Intranet_Same_Site_Access</summary>
    public IMessageDescription IntranetNetName { get => _intranetnetname!; set => this.AssertWritable()._intranetnetname = value; }
    /// <summary>Code group grants the intranet permission set to code from the intranet zone. This permission set grants intranet code the right to use isolated storage, full UI access, some capability to do reflection, and limited access to environment variables.</summary>
    public IMessageDescription IntranetDescription { get => _intranetdescription!; set => this.AssertWritable()._intranetdescription = value; }
    /// <summary>LocalIntranet_Zone</summary>
    public IMessageDescription IntranetName { get => _intranetname!; set => this.AssertWritable()._intranetname = value; }
    /// <summary>Code group grants full trust to code signed with the Microsoft strong name.</summary>
    public IMessageDescription MicrosoftDescription { get => _microsoftdescription!; set => this.AssertWritable()._microsoftdescription = value; }
    /// <summary>Microsoft_Strong_Name</summary>
    public IMessageDescription MicrosoftName { get => _microsoftname!; set => this.AssertWritable()._microsoftname = value; }
    /// <summary>Code group grants full trust to all code originating on the local computer</summary>
    public IMessageDescription MyComputerDescription { get => _mycomputerdescription!; set => this.AssertWritable()._mycomputerdescription = value; }
    /// <summary>My_Computer_Zone</summary>
    public IMessageDescription MyComputerName { get => _mycomputername!; set => this.AssertWritable()._mycomputername = value; }
    /// <summary>Allows unrestricted access to all resources covered by built-in permissions</summary>
    public IMessageDescription PSEverything { get => _pseverything!; set => this.AssertWritable()._pseverything = value; }
    /// <summary>Permits execution</summary>
    public IMessageDescription PSExecution { get => _psexecution!; set => this.AssertWritable()._psexecution = value; }
    /// <summary>Allows full access to all resources</summary>
    public IMessageDescription PSFullTrust { get => _psfulltrust!; set => this.AssertWritable()._psfulltrust = value; }
    /// <summary>Default rights given to Internet applications</summary>
    public IMessageDescription PSInternet { get => _psinternet!; set => this.AssertWritable()._psinternet = value; }
    /// <summary>Default rights given to applications on the local intranet</summary>
    public IMessageDescription PSLocalIntranet { get => _pslocalintranet!; set => this.AssertWritable()._pslocalintranet = value; }
    /// <summary>Denies all resources, including the right to execute</summary>
    public IMessageDescription PSNothing { get => _psnothing!; set => this.AssertWritable()._psnothing = value; }
    /// <summary>Grants right to bypass the verification</summary>
    public IMessageDescription PSSkipVerification { get => _psskipverification!; set => this.AssertWritable()._psskipverification = value; }
    /// <summary>PolicyLevel object not based on a file cannot be saved.</summary>
    public IMessageDescription SaveNotFileBased { get => _savenotfilebased!; set => this.AssertWritable()._savenotfilebased = value; }
    /// <summary>All Trusted Code gets the right to connect back to the site of its origin.</summary>
    public IMessageDescription TrustedNetDescription { get => _trustednetdescription!; set => this.AssertWritable()._trustednetdescription = value; }
    /// <summary>Trusted_Same_Site_Access</summary>
    public IMessageDescription TrustedNetName { get => _trustednetname!; set => this.AssertWritable()._trustednetname = value; }
    /// <summary>Code from a trusted zone is granted the Internet permission set. This permission set grants the right to use isolated storage and limited UI access.</summary>
    public IMessageDescription TrustedDescription { get => _trusteddescription!; set => this.AssertWritable()._trusteddescription = value; }
    /// <summary>Trusted_Zone</summary>
    public IMessageDescription TrustedName { get => _trustedname!; set => this.AssertWritable()._trustedname = value; }
    /// <summary>Code coming from a restricted zone does not receive any permissions.</summary>
    public IMessageDescription UntrustedDescription { get => _untrusteddescription!; set => this.AssertWritable()._untrusteddescription = value; }
    /// <summary>Restricted_Zone</summary>
    public IMessageDescription UntrustedName { get => _untrustedname!; set => this.AssertWritable()._untrustedname = value; }

    /// <summary>Initialize fields</summary>
    public override PolicyMessages Initialize() 
    {
        base.Initialize();
        Add(_apptrustmustgrantapprequest = new MessageDescription("mscorlib.Policy_AppTrustMustGrantAppRequest", 0xA34504CD, new ParameterlessText("ApplicationTrust grant set does not contain ActivationContext's minimum request set.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_badxml = new MessageDescription("mscorlib.Policy_BadXml", 0xA34504CE, new FormatText("Policy configuration XML is invalid. The required tag '{0}' is missing.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_default = new MessageDescription("mscorlib.Policy_Default", 0xA34504CF, new ParameterlessText("Error occurred while performing a policy operation.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Security.Policy").SetException(typeof(System.ArgumentException)));
        Add(_duplicateevidence = new MessageDescription("mscorlib.Policy_DuplicateEvidence", 0xA34504D0, new FormatText("The evidence collection already contains evidence of type '{0}'. Multiple pieces of the same type of evidence are not allowed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_evidencemustbeserializable = new MessageDescription("mscorlib.Policy_EvidenceMustBeSerializable", 0xA34504D1, new ParameterlessText("Objects used as evidence must be serializable.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_grantsetdoesnotmatchdomain = new MessageDescription("mscorlib.Policy_GrantSetDoesNotMatchDomain", 0xA34504D2, new FormatText("An assembly was provided an invalid grant set by runtime host '{0}'. In a homogenous AppDomain, the only valid grant sets are FullTrust and the AppDomain's sandbox grant set.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_incorrecthostevidence = new MessageDescription("mscorlib.Policy_IncorrectHostEvidence", 0xA34504D3, new FormatText("Runtime host '{0}' returned evidence of type '{1}' from a request for evidence of type '{2}'.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_missingactivationcontextinappevidence = new MessageDescription("mscorlib.Policy_MissingActivationContextInAppEvidence", 0xA34504D4, new ParameterlessText("The application evidence does not contain a Fusion activation context.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_multipleexclusive = new MessageDescription("mscorlib.Policy_MultipleExclusive", 0xA34504D5, new ParameterlessText("More than one exclusive group is not allowed.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_noexecutionpermission = new MessageDescription("mscorlib.Policy_NoExecutionPermission", 0xA34504D6, new ParameterlessText("Execution permission cannot be acquired.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_nonfulltrustassembly = new MessageDescription("mscorlib.Policy_NonFullTrustAssembly", 0xA34504D7, new ParameterlessText("Policy references an assembly not in the full trust assemblies list.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_norequiredpermission = new MessageDescription("mscorlib.Policy_NoRequiredPermission", 0xA34504D8, new ParameterlessText("Required permissions cannot be acquired.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_notrustmanager = new MessageDescription("mscorlib.Policy_NoTrustManager", 0xA34504D9, new ParameterlessText("A trust manager could not be loaded for this application.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_nullhostevidence = new MessageDescription("mscorlib.Policy_NullHostEvidence", 0xA34504DA, new FormatText("Runtime host '{0}' returned null when asked for assembly evidence for assembly '{1}'.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_nullhostgrantset = new MessageDescription("mscorlib.Policy_NullHostGrantSet", 0xA34504DB, new FormatText("Runtime host '{0}' returned a null grant set from ResolvePolicy.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_plappdomain = new MessageDescription("mscorlib.Policy_PL_AppDomain", 0xA34504DC, new ParameterlessText("AppDomain")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_plenterprise = new MessageDescription("mscorlib.Policy_PL_Enterprise", 0xA34504DD, new ParameterlessText("Enterprise")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_plmachine = new MessageDescription("mscorlib.Policy_PL_Machine", 0xA34504DE, new ParameterlessText("Machine")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_pluser = new MessageDescription("mscorlib.Policy_PL_User", 0xA34504DF, new ParameterlessText("User")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_policyalreadyset = new MessageDescription("mscorlib.Policy_PolicyAlreadySet", 0xA34504E0, new ParameterlessText("Policy for this domain cannot be set twice.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_principaltwice = new MessageDescription("mscorlib.Policy_PrincipalTwice", 0xA34504E1, new ParameterlessText("Default principal object cannot be set twice.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_recovernoconfigfile = new MessageDescription("mscorlib.Policy_RecoverNoConfigFile", 0xA34504E2, new ParameterlessText("No old configuration file exists to recover.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_recovernotfilebased = new MessageDescription("mscorlib.Policy_RecoverNotFileBased", 0xA34504E3, new ParameterlessText("PolicyLevel object not based on a file cannot be recovered.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_unabletosave = new MessageDescription("mscorlib.Policy_UnableToSave", 0xA34504E4, new FormatText("Policy level '{0}' could not be saved: {1}.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_fileparse = new MessageDescription("mscorlib.Error_SecurityPolicyFileParse", 0xA3450705, new FormatText("Error occurred while parsing the '{0}' policy level. The default policy level was used instead.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_fileparseex = new MessageDescription("mscorlib.Error_SecurityPolicyFileParseEx", 0xA3450706, new FormatText("Error '{1}' occurred while parsing the '{0}' policy level. The default policy level was used instead.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_allcodedescriptionfulltrust = new MessageDescription("mscorlib.Policy_AllCode_DescriptionFullTrust", 0xA3450708, new ParameterlessText("Code group grants all code full trust and forms the root of the code group tree.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_allcodedescriptionnothing = new MessageDescription("mscorlib.Policy_AllCode_DescriptionNothing", 0xA3450709, new ParameterlessText("Code group grants no permissions and forms the root of the code group tree.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_allcodename = new MessageDescription("mscorlib.Policy_AllCode_Name", 0xA3450707, new ParameterlessText("All_Code")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_cannotloadsemitrustassembliesduringinit = new MessageDescription("mscorlib.Policy_CannotLoadSemiTrustAssembliesDuringInit", 0xA3450703, new ParameterlessText("All assemblies loaded as part of AppDomain initialization must be fully trusted.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_ecmadescription = new MessageDescription("mscorlib.Policy_Ecma_Description", 0xA345071F, new ParameterlessText("Code group grants full trust to code signed with the ECMA strong name.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_ecmaname = new MessageDescription("mscorlib.Policy_Ecma_Name", 0xA345071E, new ParameterlessText("ECMA_Strong_Name")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_internetnetdescription = new MessageDescription("mscorlib.Policy_InternetNet_Description", 0xA3450715, new ParameterlessText("All Internet code gets the right to connect back to the site of its origin.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_internetnetname = new MessageDescription("mscorlib.Policy_InternetNet_Name", 0xA3450714, new ParameterlessText("Internet_Same_Site_Access")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_internetdescription = new MessageDescription("mscorlib.Policy_Internet_Description", 0xA3450713, new ParameterlessText("Code group grants code from the Internet zone the Internet permission set. This permission set grants Internet code the right to use isolated storage and limited UI access.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_internetname = new MessageDescription("mscorlib.Policy_Internet_Name", 0xA3450712, new ParameterlessText("Internet_Zone")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_intranetfiledescription = new MessageDescription("mscorlib.Policy_IntranetFile_Description", 0xA3450711, new ParameterlessText("All intranet code gets the right to read from its install directory.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_intranetfilename = new MessageDescription("mscorlib.Policy_IntranetFile_Name", 0xA3450710, new ParameterlessText("Intranet_Same_Directory_Access")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_intranetnetdescription = new MessageDescription("mscorlib.Policy_IntranetNet_Description", 0xA345070F, new ParameterlessText("All intranet code gets the right to connect back to the site of its origin.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_intranetnetname = new MessageDescription("mscorlib.Policy_IntranetNet_Name", 0xA345070E, new ParameterlessText("Intranet_Same_Site_Access")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_intranetdescription = new MessageDescription("mscorlib.Policy_Intranet_Description", 0xA345070D, new ParameterlessText("Code group grants the intranet permission set to code from the intranet zone. This permission set grants intranet code the right to use isolated storage, full UI access, some capability to do reflection, and limited access to environment variables.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_intranetname = new MessageDescription("mscorlib.Policy_Intranet_Name", 0xA345070C, new ParameterlessText("LocalIntranet_Zone")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_microsoftdescription = new MessageDescription("mscorlib.Policy_Microsoft_Description", 0xA345071D, new ParameterlessText("Code group grants full trust to code signed with the Microsoft strong name.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_microsoftname = new MessageDescription("mscorlib.Policy_Microsoft_Name", 0xA345071C, new ParameterlessText("Microsoft_Strong_Name")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_mycomputerdescription = new MessageDescription("mscorlib.Policy_MyComputer_Description", 0xA345070B, new ParameterlessText("Code group grants full trust to all code originating on the local computer")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_mycomputername = new MessageDescription("mscorlib.Policy_MyComputer_Name", 0xA345070A, new ParameterlessText("My_Computer_Zone")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_pseverything = new MessageDescription("mscorlib.Policy_PS_Everything", 0xA3450721, new ParameterlessText("Allows unrestricted access to all resources covered by built-in permissions")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_psexecution = new MessageDescription("mscorlib.Policy_PS_Execution", 0xA3450723, new ParameterlessText("Permits execution")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_psfulltrust = new MessageDescription("mscorlib.Policy_PS_FullTrust", 0xA3450720, new ParameterlessText("Allows full access to all resources")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_psinternet = new MessageDescription("mscorlib.Policy_PS_Internet", 0xA3450725, new ParameterlessText("Default rights given to Internet applications")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_pslocalintranet = new MessageDescription("mscorlib.Policy_PS_LocalIntranet", 0xA3450726, new ParameterlessText("Default rights given to applications on the local intranet")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_psnothing = new MessageDescription("mscorlib.Policy_PS_Nothing", 0xA3450722, new ParameterlessText("Denies all resources, including the right to execute")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_psskipverification = new MessageDescription("mscorlib.Policy_PS_SkipVerification", 0xA3450724, new ParameterlessText("Grants right to bypass the verification")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_savenotfilebased = new MessageDescription("mscorlib.Policy_SaveNotFileBased", 0xA3450704, new ParameterlessText("PolicyLevel object not based on a file cannot be saved.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_trustednetdescription = new MessageDescription("mscorlib.Policy_TrustedNet_Description", 0xA3450719, new ParameterlessText("All Trusted Code gets the right to connect back to the site of its origin.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_trustednetname = new MessageDescription("mscorlib.Policy_TrustedNet_Name", 0xA3450718, new ParameterlessText("Trusted_Same_Site_Access")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_trusteddescription = new MessageDescription("mscorlib.Policy_Trusted_Description", 0xA3450717, new ParameterlessText("Code from a trusted zone is granted the Internet permission set. This permission set grants the right to use isolated storage and limited UI access.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_trustedname = new MessageDescription("mscorlib.Policy_Trusted_Name", 0xA3450716, new ParameterlessText("Trusted_Zone")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_untrusteddescription = new MessageDescription("mscorlib.Policy_Untrusted_Description", 0xA345071B, new ParameterlessText("Code coming from a restricted zone does not receive any permissions.")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        Add(_untrustedname = new MessageDescription("mscorlib.Policy_Untrusted_Name", 0xA345071A, new ParameterlessText("Restricted_Zone")).SetHResult(0x80131416).SetSeverity(MessageLevel.Error).SetException("System.Security.Policy.PolicyException"));
        return this;
    }    

}
