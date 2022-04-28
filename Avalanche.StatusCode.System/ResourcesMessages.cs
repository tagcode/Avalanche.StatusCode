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

/// <summary>System.Resources.*</summary>
public class ResourcesMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ResourcesMessages> instance = new Lazy<ResourcesMessages>(() => new ResourcesMessages().Initialize().SetAllReadOnly<ResourcesMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ResourcesMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0011;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _invalidsatellitecontractasmver, _argmissingmanifestresourceexception, _resmgrnotresset, _mustberuntimeassembly, _mustberuntimetype, _assembly, _looselylinked, _multipleblobs, _noneutralasm, _noneutraldisk;
    IMessageDescription? _nopriresources, _reswfilenotloaded, _culturename, _default, _argumentmanifestfiledoesnotexist, _argumentunabletoparsemanifest, _nodebugresources;
    
    /// <summary>System.Resources</summary>
    public IMessageDescription InvalidSatelliteContractAsmVer { get => _invalidsatellitecontractasmver!; set => this.AssertWritable()._invalidsatellitecontractasmver = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription ArgMissingManifestResourceException { get => _argmissingmanifestresourceexception!; set => this.AssertWritable()._argmissingmanifestresourceexception = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription ResMgrNotResSet { get => _resmgrnotresset!; set => this.AssertWritable()._resmgrnotresset = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription MustBeRuntimeAssembly { get => _mustberuntimeassembly!; set => this.AssertWritable()._mustberuntimeassembly = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription MustBeRuntimeType { get => _mustberuntimetype!; set => this.AssertWritable()._mustberuntimetype = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription Assembly { get => _assembly!; set => this.AssertWritable()._assembly = value; }
    /// <summary>Could not find a manifest resource entry called &quot;{0}&quot; in assembly &quot;{1}&quot;. Please check spelling, capitalization, and build rules to ensure &quot;{0}&quot; is being linked into the assembly.</summary>
    public IMessageDescription LooselyLinked { get => _looselylinked!; set => this.AssertWritable()._looselylinked = value; }
    /// <summary>A case-insensitive lookup for resource file &quot;{0}&quot; in assembly &quot;{1}&quot; found multiple entries. Remove the duplicates or specify the exact case.</summary>
    public IMessageDescription MultipleBlobs { get => _multipleblobs!; set => this.AssertWritable()._multipleblobs = value; }
    /// <summary>Could not find any resources appropriate for the specified culture or the neutral culture. Make sure &quot;{0}&quot; was correctly embedded or linked into assembly &quot;{1}&quot; at compile time, or that all the satellite assemblies required are loadable and fully signed.</summary>
    public IMessageDescription NoNeutralAsm { get => _noneutralasm!; set => this.AssertWritable()._noneutralasm = value; }
    /// <summary>Could not find any resources appropriate for the specified culture (or the neutral culture) on disk.</summary>
    public IMessageDescription NoNeutralDisk { get => _noneutraldisk!; set => this.AssertWritable()._noneutraldisk = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription NoPRIresources { get => _nopriresources!; set => this.AssertWritable()._nopriresources = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription ResWFileNotLoaded { get => _reswfilenotloaded!; set => this.AssertWritable()._reswfilenotloaded = value; }
    /// <summary>The satellite assembly named &quot;{1}&quot; for fallback culture &quot;{0}&quot; either could not be found or could not be loaded. This is generally a setup problem. Please consider reinstalling or repairing the application.</summary>
    public IMessageDescription CultureName { get => _culturename!; set => this.AssertWritable()._culturename = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription Default { get => _default!; set => this.AssertWritable()._default = value; }
    /// <summary>The specified manifest file does not exist.</summary>
    public IMessageDescription ArgumentManifestFileDoesNotExist { get => _argumentmanifestfiledoesnotexist!; set => this.AssertWritable()._argumentmanifestfiledoesnotexist = value; }
    /// <summary>Unexpected error while parsing the specified manifest.</summary>
    public IMessageDescription ArgumentUnableToParseManifest { get => _argumentunabletoparsemanifest!; set => this.AssertWritable()._argumentunabletoparsemanifest = value; }
    /// <summary>[{0}] Arguments: {1} Debugging resource strings are unavailable. Often the key and arguments provide sufficient information to diagnose the problem. See http://go.microsoft.com/fwlink/?linkid=106663&amp;Version={2}&amp;File={3}&amp;Key={4}</summary>
    public IMessageDescription NoDebugResources { get => _nodebugresources!; set => this.AssertWritable()._nodebugresources = value; }

    /// <summary>Initialize fields</summary>
    public override ResourcesMessages Initialize() 
    {
        base.Initialize();
        Add(_invalidsatellitecontractasmver = new MessageDescription("mscorlib.Arg_InvalidSatelliteContract_Asm_Ver", 0xA3450080, new FormatText("Satellite contract version attribute on the assembly '{0}' specifies an invalid version: {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ArgumentException)));
        Add(_argmissingmanifestresourceexception = new MessageDescription("mscorlib.Arg_MissingManifestResourceException", 0xA3450090, new ParameterlessText("Unable to find manifest resource.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_resmgrnotresset = new MessageDescription("mscorlib.Arg_ResMgrNotResSet", 0xA34500EE, new ParameterlessText("Type parameter must refer to a subclass of ResourceSet.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ArgumentException)));
        Add(_mustberuntimeassembly = new MessageDescription("mscorlib.Argument_MustBeRuntimeAssembly", 0xA34501E4, new ParameterlessText("Assembly must be a runtime Assembly object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ArgumentException)));
        Add(_mustberuntimetype = new MessageDescription("mscorlib.Argument_MustBeRuntimeType", 0xA34501E9, new ParameterlessText("Type must be a runtime Type object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ArgumentException)));
        Add(_assembly = new MessageDescription("mscorlib.ArgumentNull_Assembly", 0xA3450261, new ParameterlessText("Assembly cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ArgumentNullException)));
        Add(_looselylinked = new MessageDescription("mscorlib.MissingManifestResource_LooselyLinked", 0xA345044F, new FormatText("Could not find a manifest resource entry called \"{0}\" in assembly \"{1}\". Please check spelling, capitalization, and build rules to ensure \"{0}\" is being linked into the assembly.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_multipleblobs = new MessageDescription("mscorlib.MissingManifestResource_MultipleBlobs", 0xA3450450, new FormatText("A case-insensitive lookup for resource file \"{0}\" in assembly \"{1}\" found multiple entries. Remove the duplicates or specify the exact case.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_noneutralasm = new MessageDescription("mscorlib.MissingManifestResource_NoNeutralAsm", 0xA3450451, new FormatText("Could not find any resources appropriate for the specified culture or the neutral culture.  Make sure \"{0}\" was correctly embedded or linked into assembly \"{1}\" at compile time, or that all the satellite assemblies required are loadable and fully signed.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_noneutraldisk = new MessageDescription("mscorlib.MissingManifestResource_NoNeutralDisk", 0xA3450452, new ParameterlessText("Could not find any resources appropriate for the specified culture (or the neutral culture) on disk.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_nopriresources = new MessageDescription("mscorlib.MissingManifestResource_NoPRIresources", 0xA3450453, new ParameterlessText("Unable to open Package Resource Index.")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_reswfilenotloaded = new MessageDescription("mscorlib.MissingManifestResource_ResWFileNotLoaded", 0xA3450454, new FormatText("Unable to load resources for resource file \"{0}\" in package \"{1}\".")).SetHResult(0x80131532).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.Resources.MissingManifestResourceException)));
        Add(_culturename = new MessageDescription("mscorlib.MissingSatelliteAssembly_Culture_Name", 0xA345045A, new FormatText("The satellite assembly named \"{1}\" for fallback culture \"{0}\" either could not be found or could not be loaded. This is generally a setup problem. Please consider reinstalling or repairing the application.")).SetHResult(0x80131536).SetSeverity(MessageLevel.Error).SetException(typeof(System.Resources.MissingSatelliteAssemblyException)));
        Add(_default = new MessageDescription("mscorlib.MissingSatelliteAssembly_Default", 0xA345045B, new ParameterlessText("Resource lookup fell back to the ultimate fallback resources in a satellite assembly, but that satellite either was not found or could not be loaded. Please consider reinstalling or repairing the application.")).SetHResult(0x80131536).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.Resources.MissingSatelliteAssemblyException)));
        Add(_argumentmanifestfiledoesnotexist = new MessageDescription("mscorlib.Argument_ManifestFileDoesNotExist", 0xA3450678, new ParameterlessText("The specified manifest file does not exist.")).SetSeverity(MessageLevel.Error));
        Add(_argumentunabletoparsemanifest = new MessageDescription("mscorlib.Argument_UnableToParseManifest", 0xA345063D, new ParameterlessText("Unexpected error while parsing the specified manifest.")).SetSeverity(MessageLevel.Error));
        Add(_nodebugresources = new MessageDescription("mscorlib.NoDebugResources", 0xA345062E, new FormatText("[{0}]\r\nArguments: {1}\r\nDebugging resource strings are unavailable. Often the key and arguments provide sufficient information to diagnose the problem. See http://go.microsoft.com/fwlink/?linkid=106663&Version={2}&File={3}&Key={4}")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
