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

/// <summary>Miscellaneous</summary>
public class MiscellaneousMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<MiscellaneousMessages> instance = new Lazy<MiscellaneousMessages>(() => new MiscellaneousMessages().Initialize().SetAllReadOnly<MiscellaneousMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static MiscellaneousMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000A;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _alltostring, _filecodegrouppermissionset, _hashtostring, _loadoffxassemblynotsupportedappx, _mergelogicfirstmatch, _mergelogicunion, _netcodegrouppermissionset, _sitetostring, _sitetostringarg, _winrthostdomainname;
    
    /// <summary>All code</summary>
    public IMessageDescription AllToString { get => _alltostring!; set => this.AssertWritable()._alltostring = value; }
    /// <summary>Same directory FileIO - &#39;{0}&#39;</summary>
    public IMessageDescription FileCodeGroupPermissionSet { get => _filecodegrouppermissionset!; set => this.AssertWritable()._filecodegrouppermissionset = value; }
    /// <summary>Hash - {0} = {1}</summary>
    public IMessageDescription HashToString { get => _hashtostring!; set => this.AssertWritable()._hashtostring = value; }
    /// <summary>{0} of .NET Framework assemblies is not supported in AppX.</summary>
    public IMessageDescription LoadOfFxAssemblyNotSupportedAppX { get => _loadoffxassemblynotsupportedappx!; set => this.AssertWritable()._loadoffxassemblynotsupportedappx = value; }
    /// <summary>First Match</summary>
    public IMessageDescription MergeLogicFirstMatch { get => _mergelogicfirstmatch!; set => this.AssertWritable()._mergelogicfirstmatch = value; }
    /// <summary>Union</summary>
    public IMessageDescription MergeLogicUnion { get => _mergelogicunion!; set => this.AssertWritable()._mergelogicunion = value; }
    /// <summary>Same site Web</summary>
    public IMessageDescription NetCodeGroupPermissionSet { get => _netcodegrouppermissionset!; set => this.AssertWritable()._netcodegrouppermissionset = value; }
    /// <summary>Site</summary>
    public IMessageDescription SiteToString { get => _sitetostring!; set => this.AssertWritable()._sitetostring = value; }
    /// <summary>Site - {0}</summary>
    public IMessageDescription SiteToStringArg { get => _sitetostringarg!; set => this.AssertWritable()._sitetostringarg = value; }
    /// <summary>Windows Runtime Object Host Domain for &#39;{0}&#39;</summary>
    public IMessageDescription WinRTHostDomainName { get => _winrthostdomainname!; set => this.AssertWritable()._winrthostdomainname = value; }

    /// <summary>Initialize fields</summary>
    public override MiscellaneousMessages Initialize() 
    {
        base.Initialize();
        Add(_alltostring = new MessageDescription("mscorlib.All_ToString", 0xA3450788, new ParameterlessText("All code")).SetSeverity(MessageLevel.Error));
        Add(_filecodegrouppermissionset = new MessageDescription("mscorlib.FileCodeGroup_PermissionSet", 0xA3450785, new FormatText("Same directory FileIO - '{0}'")).SetSeverity(MessageLevel.Error));
        Add(_hashtostring = new MessageDescription("mscorlib.Hash_ToString", 0xA3450787, new FormatText("Hash - {0} = {1}")).SetSeverity(MessageLevel.Error));
        Add(_loadoffxassemblynotsupportedappx = new MessageDescription("mscorlib.LoadOfFxAssemblyNotSupported_AppX", 0xA34506FC, new FormatText("{0} of .NET Framework assemblies is not supported in AppX.")).SetSeverity(MessageLevel.Error));
        Add(_mergelogicfirstmatch = new MessageDescription("mscorlib.MergeLogic_FirstMatch", 0xA3450784, new ParameterlessText("First Match")).SetSeverity(MessageLevel.Error));
        Add(_mergelogicunion = new MessageDescription("mscorlib.MergeLogic_Union", 0xA3450783, new ParameterlessText("Union")).SetSeverity(MessageLevel.Error));
        Add(_netcodegrouppermissionset = new MessageDescription("mscorlib.NetCodeGroup_PermissionSet", 0xA3450782, new ParameterlessText("Same site Web")).SetSeverity(MessageLevel.Error));
        Add(_sitetostring = new MessageDescription("mscorlib.Site_ToString", 0xA3450786, new ParameterlessText("Site")).SetSeverity(MessageLevel.Error));
        Add(_sitetostringarg = new MessageDescription("mscorlib.Site_ToStringArg", 0xA3450789, new FormatText("Site - {0}")).SetSeverity(MessageLevel.Error));
        Add(_winrthostdomainname = new MessageDescription("mscorlib.WinRTHostDomainName", 0xA345077B, new FormatText("Windows Runtime Object Host Domain for '{0}'")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
