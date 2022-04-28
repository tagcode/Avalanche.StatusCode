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

/// <summary>System.Reflection.*</summary>
public class ReflectionMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ReflectionMessages> instance = new Lazy<ReflectionMessages>(() => new ReflectionMessages().Initialize().SetAllReadOnly<ReflectionMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ReflectionMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0022;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _accessvoid, _customattributeformatexception, _ehclausenotclause, _ehclausenotfilter, _invalidfiltercriteriaexception, _targetinvocationexception, _targetparametercountexception, _badexceptioncodegen, _badlabel, _badlabelcontent;
    IMessageDescription? _emitwritelinetype, _emptyname, _invalidlabel, _missingdefaultconstructor, _notexceptiontype, _notinexceptionblock, _notmethodcallopcode, _redefinedlabel, _shouldnotspecifyexceptiontype, _toomanyfinallyclause;
    IMessageDescription? _unclosedexceptionblock, _unmatchedmethodforlocal, _unmatchingsymscope, _reflectiontypeloadloadfailed, _ambigcust, _ambiguous, _fltcritint, _fltcritstring, _invalidfieldfail, _invalidpropfail;
    IMessageDescription? _targitargmismatch, _targstatfldreqtarg, _targstatmethreqtarg, _invalidcaller;
    
    /// <summary>Cannot create an instance of void.</summary>
    public IMessageDescription AccessVoid { get => _accessvoid!; set => this.AssertWritable()._accessvoid = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription CustomAttributeFormatException { get => _customattributeformatexception!; set => this.AssertWritable()._customattributeformatexception = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription EHClauseNotClause { get => _ehclausenotclause!; set => this.AssertWritable()._ehclausenotclause = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription EHClauseNotFilter { get => _ehclausenotfilter!; set => this.AssertWritable()._ehclausenotfilter = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription InvalidFilterCriteriaException { get => _invalidfiltercriteriaexception!; set => this.AssertWritable()._invalidfiltercriteriaexception = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription TargetInvocationException { get => _targetinvocationexception!; set => this.AssertWritable()._targetinvocationexception = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription TargetParameterCountException { get => _targetparametercountexception!; set => this.AssertWritable()._targetparametercountexception = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription BadExceptionCodeGen { get => _badexceptioncodegen!; set => this.AssertWritable()._badexceptioncodegen = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription BadLabel { get => _badlabel!; set => this.AssertWritable()._badlabel = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription BadLabelContent { get => _badlabelcontent!; set => this.AssertWritable()._badlabelcontent = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription EmitWriteLineType { get => _emitwritelinetype!; set => this.AssertWritable()._emitwritelinetype = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription EmptyName { get => _emptyname!; set => this.AssertWritable()._emptyname = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription InvalidLabel { get => _invalidlabel!; set => this.AssertWritable()._invalidlabel = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription MissingDefaultConstructor { get => _missingdefaultconstructor!; set => this.AssertWritable()._missingdefaultconstructor = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription NotExceptionType { get => _notexceptiontype!; set => this.AssertWritable()._notexceptiontype = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription NotInExceptionBlock { get => _notinexceptionblock!; set => this.AssertWritable()._notinexceptionblock = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription NotMethodCallOpcode { get => _notmethodcallopcode!; set => this.AssertWritable()._notmethodcallopcode = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription RedefinedLabel { get => _redefinedlabel!; set => this.AssertWritable()._redefinedlabel = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription ShouldNotSpecifyExceptionType { get => _shouldnotspecifyexceptiontype!; set => this.AssertWritable()._shouldnotspecifyexceptiontype = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription TooManyFinallyClause { get => _toomanyfinallyclause!; set => this.AssertWritable()._toomanyfinallyclause = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription UnclosedExceptionBlock { get => _unclosedexceptionblock!; set => this.AssertWritable()._unclosedexceptionblock = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription UnmatchedMethodForLocal { get => _unmatchedmethodforlocal!; set => this.AssertWritable()._unmatchedmethodforlocal = value; }
    /// <summary>System.Reflection.Emit</summary>
    public IMessageDescription UnmatchingSymScope { get => _unmatchingsymscope!; set => this.AssertWritable()._unmatchingsymscope = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription ReflectionTypeLoadLoadFailed { get => _reflectiontypeloadloadfailed!; set => this.AssertWritable()._reflectiontypeloadloadfailed = value; }
    /// <summary>Multiple custom attributes of the same type found.</summary>
    public IMessageDescription AmbigCust { get => _ambigcust!; set => this.AssertWritable()._ambigcust = value; }
    /// <summary>System.Reflection</summary>
    public IMessageDescription Ambiguous { get => _ambiguous!; set => this.AssertWritable()._ambiguous = value; }
    /// <summary>An Int32 must be provided for the filter criteria.</summary>
    public IMessageDescription FltCritInt { get => _fltcritint!; set => this.AssertWritable()._fltcritint = value; }
    /// <summary>A String must be provided for the filter criteria.</summary>
    public IMessageDescription FltCritString { get => _fltcritstring!; set => this.AssertWritable()._fltcritstring = value; }
    /// <summary>&#39;{0}&#39; field specified was not found.</summary>
    public IMessageDescription InvalidFieldFail { get => _invalidfieldfail!; set => this.AssertWritable()._invalidfieldfail = value; }
    /// <summary>&#39;{0}&#39; property specified was not found.</summary>
    public IMessageDescription InvalidPropFail { get => _invalidpropfail!; set => this.AssertWritable()._invalidpropfail = value; }
    /// <summary>Object does not match target type.</summary>
    public IMessageDescription TargITargMismatch { get => _targitargmismatch!; set => this.AssertWritable()._targitargmismatch = value; }
    /// <summary>Non-static field requires a target.</summary>
    public IMessageDescription TargStatFldReqTarg { get => _targstatfldreqtarg!; set => this.AssertWritable()._targstatfldreqtarg = value; }
    /// <summary>Non-static method requires a target.</summary>
    public IMessageDescription TargStatMethReqTarg { get => _targstatmethreqtarg!; set => this.AssertWritable()._targstatmethreqtarg = value; }
    /// <summary>Caller is not a friend.</summary>
    public IMessageDescription InvalidCaller { get => _invalidcaller!; set => this.AssertWritable()._invalidcaller = value; }

    /// <summary>Initialize fields</summary>
    public override ReflectionMessages Initialize() 
    {
        base.Initialize();
        Add(_accessvoid = new MessageDescription("mscorlib.Access_Void", 0xA345000B, new ParameterlessText("Cannot create an instance of void.")).SetHResult(0x8013151A).SetException(typeof(System.MemberAccessException)));
        Add(_customattributeformatexception = new MessageDescription("mscorlib.Arg_CustomAttributeFormatException", 0xA345003D, new ParameterlessText("Binary format of the specified custom attribute was invalid.")).SetHResult(0x80131605).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.Reflection.CustomAttributeFormatException)));
        Add(_ehclausenotclause = new MessageDescription("mscorlib.Arg_EHClauseNotClause", 0xA345004B, new ParameterlessText("This ExceptionHandlingClause is not a clause.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.InvalidOperationException)));
        Add(_ehclausenotfilter = new MessageDescription("mscorlib.Arg_EHClauseNotFilter", 0xA345004C, new ParameterlessText("This ExceptionHandlingClause is not a filter.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.InvalidOperationException)));
        Add(_invalidfiltercriteriaexception = new MessageDescription("mscorlib.Arg_InvalidFilterCriteriaException", 0xA3450079, new ParameterlessText("Specified filter criteria was invalid.")).SetHResult(0x80131601).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.Reflection.InvalidFilterCriteriaException)));
        Add(_targetinvocationexception = new MessageDescription("mscorlib.Arg_TargetInvocationException", 0xA34500FA, new ParameterlessText("Exception has been thrown by the target of an invocation.")).SetHResult(0x80131604).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.Reflection.TargetInvocationException)));
        Add(_targetparametercountexception = new MessageDescription("mscorlib.Arg_TargetParameterCountException", 0xA34500FB, new ParameterlessText("Number of parameters specified does not match the expected number.")).SetHResult(0x8002000E).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.Reflection.TargetParameterCountException)));
        Add(_badexceptioncodegen = new MessageDescription("mscorlib.Argument_BadExceptionCodeGen", 0xA345011F, new ParameterlessText("Incorrect code generation for exception block.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.InvalidOperationException)));
        Add(_badlabel = new MessageDescription("mscorlib.Argument_BadLabel", 0xA3450124, new ParameterlessText("Bad label in ILGenerator.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_badlabelcontent = new MessageDescription("mscorlib.Argument_BadLabelContent", 0xA3450125, new ParameterlessText("Bad label content in ILGenerator.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_emitwritelinetype = new MessageDescription("mscorlib.Argument_EmitWriteLineType", 0xA3450158, new ParameterlessText("EmitWriteLine does not support this field or local type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_emptyname = new MessageDescription("mscorlib.Argument_EmptyName", 0xA345015C, new ParameterlessText("Empty name is not legal.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_invalidlabel = new MessageDescription("mscorlib.Argument_InvalidLabel", 0xA34501AA, new ParameterlessText("Invalid Label.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_missingdefaultconstructor = new MessageDescription("mscorlib.Argument_MissingDefaultConstructor", 0xA34501E1, new ParameterlessText("was missing default constructor.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_notexceptiontype = new MessageDescription("mscorlib.Argument_NotExceptionType", 0xA3450205, new ParameterlessText("Does not extend Exception.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_notinexceptionblock = new MessageDescription("mscorlib.Argument_NotInExceptionBlock", 0xA3450206, new ParameterlessText("Not currently in an exception block.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.NotSupportedException)));
        Add(_notmethodcallopcode = new MessageDescription("mscorlib.Argument_NotMethodCallOpcode", 0xA3450208, new ParameterlessText("The specified opcode cannot be passed to EmitCall.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_redefinedlabel = new MessageDescription("mscorlib.Argument_RedefinedLabel", 0xA3450221, new ParameterlessText("Label multiply defined.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_shouldnotspecifyexceptiontype = new MessageDescription("mscorlib.Argument_ShouldNotSpecifyExceptionType", 0xA345022E, new ParameterlessText("Should not specify exception type for catch clause for filter block.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_toomanyfinallyclause = new MessageDescription("mscorlib.Argument_TooManyFinallyClause", 0xA345023A, new ParameterlessText("Exception blocks may have at most one finally clause.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_unclosedexceptionblock = new MessageDescription("mscorlib.Argument_UnclosedExceptionBlock", 0xA3450246, new ParameterlessText("The IL Generator cannot be used while there are unclosed exceptions.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_unmatchedmethodforlocal = new MessageDescription("mscorlib.Argument_UnmatchedMethodForLocal", 0xA345024B, new ParameterlessText("Local passed in does not belong to this ILGenerator.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_unmatchingsymscope = new MessageDescription("mscorlib.Argument_UnmatchingSymScope", 0xA345024C, new ParameterlessText("Non-matching symbol scope.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection.Emit").SetException(typeof(System.ArgumentException)));
        Add(_reflectiontypeloadloadfailed = new MessageDescription("mscorlib.ReflectionTypeLoad_LoadFailed", 0xA34504EC, new ParameterlessText("Unable to load one or more of the requested types. Retrieve the LoaderExceptions property for more information.")).SetHResult(0x80131602).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.Reflection.ReflectionTypeLoadException)));
        Add(_ambigcust = new MessageDescription("mscorlib.RFLCT.AmbigCust", 0xA3450559, new ParameterlessText("Multiple custom attributes of the same type found.")).SetHResult(0x8000211D).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.AmbiguousMatchException)));
        Add(_ambiguous = new MessageDescription("mscorlib.RFLCT.Ambiguous", 0xA345055A, new ParameterlessText("Ambiguous match found.")).SetHResult(0x8000211D).SetSeverity(MessageLevel.Error).SetDescription("System.Reflection").SetException(typeof(System.Reflection.AmbiguousMatchException)));
        Add(_fltcritint = new MessageDescription("mscorlib.RFLCT.FltCritInt", 0xA345055B, new ParameterlessText("An Int32 must be provided for the filter criteria.")).SetHResult(0x80131601).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.InvalidFilterCriteriaException)));
        Add(_fltcritstring = new MessageDescription("mscorlib.RFLCT.FltCritString", 0xA345055C, new ParameterlessText("A String must be provided for the filter criteria.")).SetHResult(0x80131601).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.InvalidFilterCriteriaException)));
        Add(_invalidfieldfail = new MessageDescription("mscorlib.RFLCT.InvalidFieldFail", 0xA345055D, new FormatText("'{0}' field specified was not found.")).SetHResult(0x80131605).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.CustomAttributeFormatException)));
        Add(_invalidpropfail = new MessageDescription("mscorlib.RFLCT.InvalidPropFail", 0xA345055E, new FormatText("'{0}' property specified was not found.")).SetHResult(0x80131605).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.CustomAttributeFormatException)));
        Add(_targitargmismatch = new MessageDescription("mscorlib.RFLCT.Targ_ITargMismatch", 0xA345055F, new ParameterlessText("Object does not match target type.")).SetHResult(0x80131603).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetException)));
        Add(_targstatfldreqtarg = new MessageDescription("mscorlib.RFLCT.Targ_StatFldReqTarg", 0xA3450560, new ParameterlessText("Non-static field requires a target.")).SetHResult(0x80131603).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetException)));
        Add(_targstatmethreqtarg = new MessageDescription("mscorlib.RFLCT.Targ_StatMethReqTarg", 0xA3450561, new ParameterlessText("Non-static method requires a target.")).SetHResult(0x80131603).SetSeverity(MessageLevel.Error).SetException(typeof(System.Reflection.TargetException)));
        Add(_invalidcaller = new MessageDescription("mscorlib.RtType.InvalidCaller", 0xA3450727, new ParameterlessText("Caller is not a friend.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
