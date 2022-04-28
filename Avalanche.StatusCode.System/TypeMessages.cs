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

/// <summary>Type</summary>
public class TypeMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<TypeMessages> instance = new Lazy<TypeMessages>(() => new TypeMessages().Initialize().SetAllReadOnly<TypeMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static TypeMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x002C;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _acccreateabst, _acccreateabstex, _acccreateargiterator, _acccreategeneric, _acccreategenericex, _acccreateinterface, _acccreateinterfaceex, _acccreatevoid, _accnotclassinit, _accreadonly;
    IMessageDescription? _fielddeclaringtypegeneric, _fieldneedgenericdeclaringtype, _memberandarray, _membershipconditionelement, _methoddeclaringtypegeneric, _methoddeclaringtypegenericlcg, _methodneedgenericdeclaringtype, _methodredefined, _typedreferenceinvalidfield, _typeiswinrttype;
    IMessageDescription? _typemustbecomcreatable, _typemustbevisiblefromcom, _typemustnotbecomimport, _typenametoolong, _typenotactivatableviawindowsruntime, _typenotcomobject, _typenotvalid, _fieldaccessinitonly, _missingconstructorname, _missingfield;
    IMessageDescription? _missingfieldname, _missingmember, _missingmembername, _missingmembernesterr, _missingmembertyperef, _missingmethodname, _missingtype, _initializationdefault, _initializationtype, _resolvenestedtype;
    IMessageDescription? _resolvetype, _resolvetypefromassembly, _accrvastatic, _typedoesnotcontainmethod;
    
    /// <summary>Cannot create an abstract class.</summary>
    public IMessageDescription AccCreateAbst { get => _acccreateabst!; set => this.AssertWritable()._acccreateabst = value; }
    /// <summary>Cannot create an instance of {0} because it is an abstract class.</summary>
    public IMessageDescription AccCreateAbstEx { get => _acccreateabstex!; set => this.AssertWritable()._acccreateabstex = value; }
    /// <summary>Cannot dynamically create an instance of ArgIterator.</summary>
    public IMessageDescription AccCreateArgIterator { get => _acccreateargiterator!; set => this.AssertWritable()._acccreateargiterator = value; }
    /// <summary>Cannot create a type for which Type.ContainsGenericParameters is true.</summary>
    public IMessageDescription AccCreateGeneric { get => _acccreategeneric!; set => this.AssertWritable()._acccreategeneric = value; }
    /// <summary>Cannot create an instance of {0} because Type.ContainsGenericParameters is true.</summary>
    public IMessageDescription AccCreateGenericEx { get => _acccreategenericex!; set => this.AssertWritable()._acccreategenericex = value; }
    /// <summary>Cannot create an instance of an interface.</summary>
    public IMessageDescription AccCreateInterface { get => _acccreateinterface!; set => this.AssertWritable()._acccreateinterface = value; }
    /// <summary>Cannot create an instance of {0} because it is an interface.</summary>
    public IMessageDescription AccCreateInterfaceEx { get => _acccreateinterfaceex!; set => this.AssertWritable()._acccreateinterfaceex = value; }
    /// <summary>Cannot dynamically create an instance of System.Void.</summary>
    public IMessageDescription AccCreateVoid { get => _acccreatevoid!; set => this.AssertWritable()._acccreatevoid = value; }
    /// <summary>Type initializer was not callable.</summary>
    public IMessageDescription AccNotClassInit { get => _accnotclassinit!; set => this.AssertWritable()._accnotclassinit = value; }
    /// <summary>Cannot set a constant field.</summary>
    public IMessageDescription AccReadOnly { get => _accreadonly!; set => this.AssertWritable()._accreadonly = value; }
    /// <summary>Cannot resolve field {0} because the declaring type of the field handle {1} is generic. Explicitly provide the declaring type to GetFieldFromHandle.</summary>
    public IMessageDescription FieldDeclaringTypeGeneric { get => _fielddeclaringtypegeneric!; set => this.AssertWritable()._fielddeclaringtypegeneric = value; }
    /// <summary>The specified field must be declared on a generic type definition.</summary>
    public IMessageDescription FieldNeedGenericDeclaringType { get => _fieldneedgenericdeclaringtype!; set => this.AssertWritable()._fieldneedgenericdeclaringtype = value; }
    /// <summary>Cannot supply both a MemberInfo and an Array to indicate the parent of a value type.</summary>
    public IMessageDescription MemberAndArray { get => _memberandarray!; set => this.AssertWritable()._memberandarray = value; }
    /// <summary>Element must be a &lt;IMembershipCondition&gt; element.</summary>
    public IMessageDescription MembershipConditionElement { get => _membershipconditionelement!; set => this.AssertWritable()._membershipconditionelement = value; }
    /// <summary>Cannot resolve method {0} because the declaring type of the method handle {1} is generic. Explicitly provide the declaring type to GetMethodFromHandle.</summary>
    public IMessageDescription MethodDeclaringTypeGeneric { get => _methoddeclaringtypegeneric!; set => this.AssertWritable()._methoddeclaringtypegeneric = value; }
    /// <summary>Method &#39;{0}&#39; has a generic declaring type &#39;{1}&#39;. Explicitly provide the declaring type to GetTokenFor.</summary>
    public IMessageDescription MethodDeclaringTypeGenericLcg { get => _methoddeclaringtypegenericlcg!; set => this.AssertWritable()._methoddeclaringtypegenericlcg = value; }
    /// <summary>The specified method cannot be dynamic or global and must be declared on a generic type definition.</summary>
    public IMessageDescription MethodNeedGenericDeclaringType { get => _methodneedgenericdeclaringtype!; set => this.AssertWritable()._methodneedgenericdeclaringtype = value; }
    /// <summary>Method has been already defined.</summary>
    public IMessageDescription MethodRedefined { get => _methodredefined!; set => this.AssertWritable()._methodredefined = value; }
    /// <summary>Field in TypedReferences cannot be static or init only.</summary>
    public IMessageDescription TypedReferenceInvalidField { get => _typedreferenceinvalidfield!; set => this.AssertWritable()._typedreferenceinvalidfield = value; }
    /// <summary>The type must not be a Windows Runtime type.</summary>
    public IMessageDescription TypeIsWinRTType { get => _typeiswinrttype!; set => this.AssertWritable()._typeiswinrttype = value; }
    /// <summary>The type must be creatable from COM.</summary>
    public IMessageDescription TypeMustBeComCreatable { get => _typemustbecomcreatable!; set => this.AssertWritable()._typemustbecomcreatable = value; }
    /// <summary>The specified type must be visible from COM.</summary>
    public IMessageDescription TypeMustBeVisibleFromCom { get => _typemustbevisiblefromcom!; set => this.AssertWritable()._typemustbevisiblefromcom = value; }
    /// <summary>The type must not be imported from COM.</summary>
    public IMessageDescription TypeMustNotBeComImport { get => _typemustnotbecomimport!; set => this.AssertWritable()._typemustnotbecomimport = value; }
    /// <summary>Type name was too long. The fully qualified type name must be less than 1,024 characters.</summary>
    public IMessageDescription TypeNameTooLong { get => _typenametoolong!; set => this.AssertWritable()._typenametoolong = value; }
    /// <summary>Type &#39;{0}&#39; does not have an activation factory because it is not activatable by Windows Runtime.</summary>
    public IMessageDescription TypeNotActivatableViaWindowsRuntime { get => _typenotactivatableviawindowsruntime!; set => this.AssertWritable()._typenotactivatableviawindowsruntime = value; }
    /// <summary>The type must be __ComObject or be derived from __ComObject.</summary>
    public IMessageDescription TypeNotComObject { get => _typenotcomobject!; set => this.AssertWritable()._typenotcomobject = value; }
    /// <summary>The Type object is not valid.</summary>
    public IMessageDescription TypeNotValid { get => _typenotvalid!; set => this.AssertWritable()._typenotvalid = value; }
    /// <summary>InitOnly (aka ReadOnly) fields can only be initialized in the type/instance constructor.</summary>
    public IMessageDescription FieldAccessInitOnly { get => _fieldaccessinitonly!; set => this.AssertWritable()._fieldaccessinitonly = value; }
    /// <summary>Constructor on type &#39;{0}&#39; not found.</summary>
    public IMessageDescription MissingConstructorName { get => _missingconstructorname!; set => this.AssertWritable()._missingconstructorname = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingField { get => _missingfield!; set => this.AssertWritable()._missingfield = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingFieldName { get => _missingfieldname!; set => this.AssertWritable()._missingfieldname = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingMember { get => _missingmember!; set => this.AssertWritable()._missingmember = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingMemberName { get => _missingmembername!; set => this.AssertWritable()._missingmembername = value; }
    /// <summary>TypedReference can only be made on nested value Types.</summary>
    public IMessageDescription MissingMemberNestErr { get => _missingmembernesterr!; set => this.AssertWritable()._missingmembernesterr = value; }
    /// <summary>FieldInfo does not match the target Type.</summary>
    public IMessageDescription MissingMemberTypeRef { get => _missingmembertyperef!; set => this.AssertWritable()._missingmembertyperef = value; }
    /// <summary>System</summary>
    public IMessageDescription MissingMethodName { get => _missingmethodname!; set => this.AssertWritable()._missingmethodname = value; }
    /// <summary>Type &#39;{0}&#39; not found.</summary>
    public IMessageDescription MissingType { get => _missingtype!; set => this.AssertWritable()._missingtype = value; }
    /// <summary>System</summary>
    public IMessageDescription InitializationDefault { get => _initializationdefault!; set => this.AssertWritable()._initializationdefault = value; }
    /// <summary>System</summary>
    public IMessageDescription InitializationType { get => _initializationtype!; set => this.AssertWritable()._initializationtype = value; }
    /// <summary>Could not resolve nested type &#39;{0}&#39; in type &quot;{1}&#39;.</summary>
    public IMessageDescription ResolveNestedType { get => _resolvenestedtype!; set => this.AssertWritable()._resolvenestedtype = value; }
    /// <summary>Could not resolve type &#39;{0}&#39;.</summary>
    public IMessageDescription ResolveType { get => _resolvetype!; set => this.AssertWritable()._resolvetype = value; }
    /// <summary>Could not resolve type &#39;{0}&#39; in assembly &#39;{1}&#39;.</summary>
    public IMessageDescription ResolveTypeFromAssembly { get => _resolvetypefromassembly!; set => this.AssertWritable()._resolvetypefromassembly = value; }
    /// <summary>SkipVerification permission is needed to modify an image-based (RVA) static field.</summary>
    public IMessageDescription AccRvaStatic { get => _accrvastatic!; set => this.AssertWritable()._accrvastatic = value; }
    /// <summary>Type does not contain the given method.</summary>
    public IMessageDescription TypeDoesNotContainMethod { get => _typedoesnotcontainmethod!; set => this.AssertWritable()._typedoesnotcontainmethod = value; }

    /// <summary>Initialize fields</summary>
    public override TypeMessages Initialize() 
    {
        base.Initialize();
        Add(_acccreateabst = new MessageDescription("mscorlib.Acc_CreateAbst", 0xA3450001, new ParameterlessText("Cannot create an abstract class.")).SetHResult(0x8013150B).SetSeverity(MessageLevel.Error).SetException("System.Runtime.Remoting.RemotingException"));
        Add(_acccreateabstex = new MessageDescription("mscorlib.Acc_CreateAbstEx", 0xA3450002, new FormatText("Cannot create an instance of {0} because it is an abstract class.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Error).SetException(typeof(System.MemberAccessException)));
        Add(_acccreateargiterator = new MessageDescription("mscorlib.Acc_CreateArgIterator", 0xA3450003, new ParameterlessText("Cannot dynamically create an instance of ArgIterator.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_acccreategeneric = new MessageDescription("mscorlib.Acc_CreateGeneric", 0xA3450004, new ParameterlessText("Cannot create a type for which Type.ContainsGenericParameters is true.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_acccreategenericex = new MessageDescription("mscorlib.Acc_CreateGenericEx", 0xA3450005, new FormatText("Cannot create an instance of {0} because Type.ContainsGenericParameters is true.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_acccreateinterface = new MessageDescription("mscorlib.Acc_CreateInterface", 0xA3450006, new ParameterlessText("Cannot create an instance of an interface.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Error).SetException(typeof(System.MemberAccessException)));
        Add(_acccreateinterfaceex = new MessageDescription("mscorlib.Acc_CreateInterfaceEx", 0xA3450007, new FormatText("Cannot create an instance of {0} because it is an interface.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Error).SetException(typeof(System.MemberAccessException)));
        Add(_acccreatevoid = new MessageDescription("mscorlib.Acc_CreateVoid", 0xA3450008, new ParameterlessText("Cannot dynamically create an instance of System.Void.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_accnotclassinit = new MessageDescription("mscorlib.Acc_NotClassInit", 0xA3450009, new ParameterlessText("Type initializer was not callable.")).SetHResult(0x8013151A).SetSeverity(MessageLevel.Error).SetException(typeof(System.MemberAccessException)));
        Add(_accreadonly = new MessageDescription("mscorlib.Acc_ReadOnly", 0xA345000A, new ParameterlessText("Cannot set a constant field.")).SetHResult(0x80131507).SetSeverity(MessageLevel.Error).SetException(typeof(System.FieldAccessException)));
        Add(_fielddeclaringtypegeneric = new MessageDescription("mscorlib.Argument_FieldDeclaringTypeGeneric", 0xA3450167, new FormatText("Cannot resolve field {0} because the declaring type of the field handle {1} is generic. Explicitly provide the declaring type to GetFieldFromHandle.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fieldneedgenericdeclaringtype = new MessageDescription("mscorlib.Argument_FieldNeedGenericDeclaringType", 0xA3450168, new ParameterlessText("The specified field must be declared on a generic type definition.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_memberandarray = new MessageDescription("mscorlib.Argument_MemberAndArray", 0xA34501D9, new ParameterlessText("Cannot supply both a MemberInfo and an Array to indicate the parent of a value type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_membershipconditionelement = new MessageDescription("mscorlib.Argument_MembershipConditionElement", 0xA34501DA, new ParameterlessText("Element must be a <IMembershipCondition> element.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_methoddeclaringtypegeneric = new MessageDescription("mscorlib.Argument_MethodDeclaringTypeGeneric", 0xA34501DB, new FormatText("Cannot resolve method {0} because the declaring type of the method handle {1} is generic. Explicitly provide the declaring type to GetMethodFromHandle.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_methoddeclaringtypegenericlcg = new MessageDescription("mscorlib.Argument_MethodDeclaringTypeGenericLcg", 0xA34501DC, new FormatText("Method '{0}' has a generic declaring type '{1}'. Explicitly provide the declaring type to GetTokenFor.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_methodneedgenericdeclaringtype = new MessageDescription("mscorlib.Argument_MethodNeedGenericDeclaringType", 0xA34501DD, new ParameterlessText("The specified method cannot be dynamic or global and must be declared on a generic type definition.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_methodredefined = new MessageDescription("mscorlib.Argument_MethodRedefined", 0xA34501DE, new ParameterlessText("Method has been already defined.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typedreferenceinvalidfield = new MessageDescription("mscorlib.Argument_TypedReferenceInvalidField", 0xA345023C, new ParameterlessText("Field in TypedReferences cannot be static or init only.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typeiswinrttype = new MessageDescription("mscorlib.Argument_TypeIsWinRTType", 0xA345023D, new ParameterlessText("The type must not be a Windows Runtime type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typemustbecomcreatable = new MessageDescription("mscorlib.Argument_TypeMustBeComCreatable", 0xA345023E, new ParameterlessText("The type must be creatable from COM.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typemustbevisiblefromcom = new MessageDescription("mscorlib.Argument_TypeMustBeVisibleFromCom", 0xA345023F, new ParameterlessText("The specified type must be visible from COM.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeLoadException)));
        Add(_typemustnotbecomimport = new MessageDescription("mscorlib.Argument_TypeMustNotBeComImport", 0xA3450240, new ParameterlessText("The type must not be imported from COM.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typenametoolong = new MessageDescription("mscorlib.Argument_TypeNameTooLong", 0xA3450241, new ParameterlessText("Type name was too long. The fully qualified type name must be less than 1,024 characters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typenotactivatableviawindowsruntime = new MessageDescription("mscorlib.Argument_TypeNotActivatableViaWindowsRuntime", 0xA3450242, new FormatText("Type '{0}' does not have an activation factory because it is not activatable by Windows Runtime.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typenotcomobject = new MessageDescription("mscorlib.Argument_TypeNotComObject", 0xA3450243, new ParameterlessText("The type must be __ComObject or be derived from __ComObject.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_typenotvalid = new MessageDescription("mscorlib.Argument_TypeNotValid", 0xA3450244, new ParameterlessText("The Type object is not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_fieldaccessinitonly = new MessageDescription("mscorlib.FieldAccess_InitOnly", 0xA3450353, new ParameterlessText("InitOnly (aka ReadOnly) fields can only be initialized in the type/instance constructor.")).SetHResult(0x80131507).SetSeverity(MessageLevel.Error).SetException(typeof(System.FieldAccessException)));
        Add(_missingconstructorname = new MessageDescription("mscorlib.MissingConstructor_Name", 0xA345044C, new FormatText("Constructor on type '{0}' not found.")).SetHResult(0x80131513).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingMethodException)));
        Add(_missingfield = new MessageDescription("mscorlib.MissingField", 0xA345044D, new ParameterlessText("Field not found.")).SetHResult(0x80131511).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingFieldException)));
        Add(_missingfieldname = new MessageDescription("mscorlib.MissingField_Name", 0xA345044E, new FormatText("Field '{0}' not found.")).SetHResult(0x80131511).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingFieldException)));
        Add(_missingmember = new MessageDescription("mscorlib.MissingMember", 0xA3450455, new ParameterlessText("Member not found.")).SetHResult(0x80131513).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingMethodException)));
        Add(_missingmembername = new MessageDescription("mscorlib.MissingMember_Name", 0xA3450456, new FormatText("Member '{0}' not found.")).SetHResult(0x80131512).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingMemberException)));
        Add(_missingmembernesterr = new MessageDescription("mscorlib.MissingMemberNestErr", 0xA3450457, new ParameterlessText("TypedReference can only be made on nested value Types.")).SetHResult(0x80131512).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingMemberException)));
        Add(_missingmembertyperef = new MessageDescription("mscorlib.MissingMemberTypeRef", 0xA3450458, new ParameterlessText("FieldInfo does not match the target Type.")).SetHResult(0x80131512).SetSeverity(MessageLevel.Error).SetException(typeof(System.MissingMemberException)));
        Add(_missingmethodname = new MessageDescription("mscorlib.MissingMethod_Name", 0xA3450459, new FormatText("Method '{0}' not found.")).SetHResult(0x80131513).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.MissingMethodException)));
        Add(_missingtype = new MessageDescription("mscorlib.MissingType", 0xA345045C, new FormatText("Type '{0}' not found.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeLoadException)));
        Add(_initializationdefault = new MessageDescription("mscorlib.TypeInitialization_Default", 0xA34505FE, new ParameterlessText("Type constructor threw an exception.")).SetHResult(0x80131534).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TypeInitializationException)));
        Add(_initializationtype = new MessageDescription("mscorlib.TypeInitialization_Type", 0xA34505FF, new FormatText("The type initializer for '{0}' threw an exception.")).SetHResult(0x80131534).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TypeInitializationException)));
        Add(_resolvenestedtype = new MessageDescription("mscorlib.TypeLoad_ResolveNestedType", 0xA3450600, new FormatText("Could not resolve nested type '{0}' in type \"{1}'.")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetException(typeof(System.TypeLoadException)));
        Add(_resolvetype = new MessageDescription("mscorlib.TypeLoad_ResolveType", 0xA3450601, new FormatText("Could not resolve type '{0}'.")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_resolvetypefromassembly = new MessageDescription("mscorlib.TypeLoad_ResolveTypeFromAssembly", 0xA3450602, new FormatText("Could not resolve type '{0}' in assembly '{1}'.")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_accrvastatic = new MessageDescription("mscorlib.Acc_RvaStatic", 0xA3450639, new ParameterlessText("SkipVerification permission is needed to modify an image-based (RVA) static field.")).SetSeverity(MessageLevel.Error));
        Add(_typedoesnotcontainmethod = new MessageDescription("mscorlib.Argument_TypeDoesNotContainMethod", 0xA3450676, new ParameterlessText("Type does not contain the given method.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
