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

/// <summary>Assembly</summary>
public class AssemblyMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<AssemblyMessages> instance = new Lazy<AssemblyMessages>(() => new AssemblyMessages().Initialize().SetAllReadOnly<AssemblyMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static AssemblyMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0017;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _argumentbadpersistablemoduleintransientassembly, _argumentduplicatemodulename, _argumentmustberuntimemodule, _argumentnomodulefileextension, _argumentnotinthesamemodulebuilder, _argumentresolvemoduletype, _invalidoperationbadtransientmodulereference, _invalidoperationcannotimportglobalfromdifferentmodule, _invalidoperationmodulehasbeensaved, _invalidoperationnomultimoduleassembly;
    IMessageDescription? _invalidoperationnotadebugmodule, _invalidoperationnullmodulehandle, _notsupporteddynamicmodule, _notsupportedmustbemodulebuilder, _notsupportednotdynamicmodule, _argassemblynullmodule, _argmemberinfonullmodule, _argnoitypelib, _argparameterinfonullmodule, _argumentmodulealreadyloaded;
    IMessageDescription? _missingmodule, _notsupportedcannotsavemoduleindividually, _typelibconverterimportedtypelibproductname;
    
    /// <summary>Cannot have a persistable module in a transient assembly.</summary>
    public IMessageDescription ArgumentBadPersistableModuleInTransientAssembly { get => _argumentbadpersistablemoduleintransientassembly!; set => this.AssertWritable()._argumentbadpersistablemoduleintransientassembly = value; }
    /// <summary>Duplicate dynamic module name within an assembly.</summary>
    public IMessageDescription ArgumentDuplicateModuleName { get => _argumentduplicatemodulename!; set => this.AssertWritable()._argumentduplicatemodulename = value; }
    /// <summary>Module must be a runtime Module object.</summary>
    public IMessageDescription ArgumentMustBeRuntimeModule { get => _argumentmustberuntimemodule!; set => this.AssertWritable()._argumentmustberuntimemodule = value; }
    /// <summary>Module file name &#39;{0}&#39; must have file extension.</summary>
    public IMessageDescription ArgumentNoModuleFileExtension { get => _argumentnomodulefileextension!; set => this.AssertWritable()._argumentnomodulefileextension = value; }
    /// <summary>The argument passed in was not from the same ModuleBuilder.</summary>
    public IMessageDescription ArgumentNotInTheSameModuleBuilder { get => _argumentnotinthesamemodulebuilder!; set => this.AssertWritable()._argumentnotinthesamemodulebuilder = value; }
    /// <summary>Token {0} resolves to the special module type representing this module.</summary>
    public IMessageDescription ArgumentResolveModuleType { get => _argumentresolvemoduletype!; set => this.AssertWritable()._argumentresolvemoduletype = value; }
    /// <summary>Unable to make a reference to a transient module from a non-transient module.</summary>
    public IMessageDescription InvalidOperationBadTransientModuleReference { get => _invalidoperationbadtransientmodulereference!; set => this.AssertWritable()._invalidoperationbadtransientmodulereference = value; }
    /// <summary>Unable to import a global method or field from a different module.</summary>
    public IMessageDescription InvalidOperationCannotImportGlobalFromDifferentModule { get => _invalidoperationcannotimportglobalfromdifferentmodule!; set => this.AssertWritable()._invalidoperationcannotimportglobalfromdifferentmodule = value; }
    /// <summary>Module &#39;{0}&#39; has been saved.</summary>
    public IMessageDescription InvalidOperationModuleHasBeenSaved { get => _invalidoperationmodulehasbeensaved!; set => this.AssertWritable()._invalidoperationmodulehasbeensaved = value; }
    /// <summary>You cannot have more than one dynamic module in each dynamic assembly in this version of the runtime.</summary>
    public IMessageDescription InvalidOperationNoMultiModuleAssembly { get => _invalidoperationnomultimoduleassembly!; set => this.AssertWritable()._invalidoperationnomultimoduleassembly = value; }
    /// <summary>Not a debug ModuleBuilder.</summary>
    public IMessageDescription InvalidOperationNotADebugModule { get => _invalidoperationnotadebugmodule!; set => this.AssertWritable()._invalidoperationnotadebugmodule = value; }
    /// <summary>The requested operation is invalid when called on a null ModuleHandle.</summary>
    public IMessageDescription InvalidOperationNullModuleHandle { get => _invalidoperationnullmodulehandle!; set => this.AssertWritable()._invalidoperationnullmodulehandle = value; }
    /// <summary>The invoked member is not supported in a dynamic module.</summary>
    public IMessageDescription NotSupportedDynamicModule { get => _notsupporteddynamicmodule!; set => this.AssertWritable()._notsupporteddynamicmodule = value; }
    /// <summary>Module argument must be a ModuleBuilder.</summary>
    public IMessageDescription NotSupportedMustBeModuleBuilder { get => _notsupportedmustbemodulebuilder!; set => this.AssertWritable()._notsupportedmustbemodulebuilder = value; }
    /// <summary>The MethodRental.SwapMethodBody method can only be called to swap the method body of a method in a dynamic module.</summary>
    public IMessageDescription NotSupportedNotDynamicModule { get => _notsupportednotdynamicmodule!; set => this.AssertWritable()._notsupportednotdynamicmodule = value; }
    /// <summary>The manifest module of the assembly cannot be null.</summary>
    public IMessageDescription ArgAssemblyNullModule { get => _argassemblynullmodule!; set => this.AssertWritable()._argassemblynullmodule = value; }
    /// <summary>The Module object containing the member cannot be null.</summary>
    public IMessageDescription ArgMemberInfoNullModule { get => _argmemberinfonullmodule!; set => this.AssertWritable()._argmemberinfonullmodule = value; }
    /// <summary>Specified TypeLib was invalid because it did not support the ITypeLib interface.</summary>
    public IMessageDescription ArgNoITypeLib { get => _argnoitypelib!; set => this.AssertWritable()._argnoitypelib = value; }
    /// <summary>The Module object containing the parameter cannot be null.</summary>
    public IMessageDescription ArgParameterInfoNullModule { get => _argparameterinfonullmodule!; set => this.AssertWritable()._argparameterinfonullmodule = value; }
    /// <summary>The specified module has already been loaded.</summary>
    public IMessageDescription ArgumentModuleAlreadyLoaded { get => _argumentmodulealreadyloaded!; set => this.AssertWritable()._argumentmodulealreadyloaded = value; }
    /// <summary>Module &#39;{0}&#39; not found.</summary>
    public IMessageDescription MissingModule { get => _missingmodule!; set => this.AssertWritable()._missingmodule = value; }
    /// <summary>Unable to save a ModuleBuilder if it was created underneath an AssemblyBuilder. Call Save on the AssemblyBuilder instead.</summary>
    public IMessageDescription NotSupportedCannotSaveModuleIndividually { get => _notsupportedcannotsavemoduleindividually!; set => this.AssertWritable()._notsupportedcannotsavemoduleindividually = value; }
    /// <summary>Assembly imported from type library &#39;{0}&#39;.</summary>
    public IMessageDescription TypeLibConverterImportedTypeLibProductName { get => _typelibconverterimportedtypelibproductname!; set => this.AssertWritable()._typelibconverterimportedtypelibproductname = value; }

    /// <summary>Initialize fields</summary>
    public override AssemblyMessages Initialize() 
    {
        base.Initialize();
        Add(_argumentbadpersistablemoduleintransientassembly = new MessageDescription("mscorlib.Argument_BadPersistableModuleInTransientAssembly", 0xA345012B, new ParameterlessText("Cannot have a persistable module in a transient assembly.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_argumentduplicatemodulename = new MessageDescription("mscorlib.Argument_DuplicateModuleName", 0xA3450154, new ParameterlessText("Duplicate dynamic module name within an assembly.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_argumentmustberuntimemodule = new MessageDescription("mscorlib.Argument_MustBeRuntimeModule", 0xA34501E7, new ParameterlessText("Module must be a runtime Module object.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_argumentnomodulefileextension = new MessageDescription("mscorlib.Argument_NoModuleFileExtension", 0xA34501F6, new FormatText("Module file name '{0}' must have file extension.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_argumentnotinthesamemodulebuilder = new MessageDescription("mscorlib.Argument_NotInTheSameModuleBuilder", 0xA3450207, new ParameterlessText("The argument passed in was not from the same ModuleBuilder.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_argumentresolvemoduletype = new MessageDescription("mscorlib.Argument_ResolveModuleType", 0xA3450229, new FormatText("Token {0} resolves to the special module type representing this module.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidoperationbadtransientmodulereference = new MessageDescription("mscorlib.InvalidOperation_BadTransientModuleReference", 0xA3450391, new ParameterlessText("Unable to make a reference to a transient module from a non-transient module.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationcannotimportglobalfromdifferentmodule = new MessageDescription("mscorlib.InvalidOperation_CannotImportGlobalFromDifferentModule", 0xA3450396, new ParameterlessText("Unable to import a global method or field from a different module.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationmodulehasbeensaved = new MessageDescription("mscorlib.InvalidOperation_ModuleHasBeenSaved", 0xA34503CA, new FormatText("Module '{0}' has been saved.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationnomultimoduleassembly = new MessageDescription("mscorlib.InvalidOperation_NoMultiModuleAssembly", 0xA34503D4, new ParameterlessText("You cannot have more than one dynamic module in each dynamic assembly in this version of the runtime.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationnotadebugmodule = new MessageDescription("mscorlib.InvalidOperation_NotADebugModule", 0xA34503DA, new ParameterlessText("Not a debug ModuleBuilder.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationnullmodulehandle = new MessageDescription("mscorlib.InvalidOperation_NullModuleHandle", 0xA34503E6, new ParameterlessText("The requested operation is invalid when called on a null ModuleHandle.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notsupporteddynamicmodule = new MessageDescription("mscorlib.NotSupported_DynamicModule", 0xA3450473, new ParameterlessText("The invoked member is not supported in a dynamic module.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_notsupportedmustbemodulebuilder = new MessageDescription("mscorlib.NotSupported_MustBeModuleBuilder", 0xA345047F, new ParameterlessText("Module argument must be a ModuleBuilder.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_notsupportednotdynamicmodule = new MessageDescription("mscorlib.NotSupported_NotDynamicModule", 0xA3450485, new ParameterlessText("The MethodRental.SwapMethodBody method can only be called to swap the method body of a method in a dynamic module.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_argassemblynullmodule = new MessageDescription("mscorlib.Arg_AssemblyNullModule", 0xA345064C, new ParameterlessText("The manifest module of the assembly cannot be null.")).SetSeverity(MessageLevel.Error));
        Add(_argmemberinfonullmodule = new MessageDescription("mscorlib.Arg_MemberInfoNullModule", 0xA3450649, new ParameterlessText("The Module object containing the member cannot be null.")).SetSeverity(MessageLevel.Error));
        Add(_argnoitypelib = new MessageDescription("mscorlib.Arg_NoITypeLib", 0xA3450655, new ParameterlessText("Specified TypeLib was invalid because it did not support the ITypeLib interface.")).SetSeverity(MessageLevel.Error));
        Add(_argparameterinfonullmodule = new MessageDescription("mscorlib.Arg_ParameterInfoNullModule", 0xA345064B, new ParameterlessText("The Module object containing the parameter cannot be null.")).SetSeverity(MessageLevel.Error));
        Add(_argumentmodulealreadyloaded = new MessageDescription("mscorlib.Argument_ModuleAlreadyLoaded", 0xA3450674, new ParameterlessText("The specified module has already been loaded.")).SetSeverity(MessageLevel.Error));
        Add(_missingmodule = new MessageDescription("mscorlib.MissingModule", 0xA34506DD, new FormatText("Module '{0}' not found.")).SetSeverity(MessageLevel.Error));
        Add(_notsupportedcannotsavemoduleindividually = new MessageDescription("mscorlib.NotSupported_CannotSaveModuleIndividually", 0xA34506E2, new ParameterlessText("Unable to save a ModuleBuilder if it was created underneath an AssemblyBuilder. Call Save on the AssemblyBuilder instead.")).SetSeverity(MessageLevel.Error));
        Add(_typelibconverterimportedtypelibproductname = new MessageDescription("mscorlib.TypeLibConverter_ImportedTypeLibProductName", 0xA345078A, new FormatText("Assembly imported from type library '{0}'.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
