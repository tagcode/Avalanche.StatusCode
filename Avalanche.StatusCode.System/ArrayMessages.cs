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

/// <summary>Array</summary>
public class ArrayMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ArrayMessages> instance = new Lazy<ArrayMessages>(() => new ArrayMessages().Initialize().SetAllReadOnly<ArrayMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ArrayMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0029;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _arraylengthsdiffer, _arrayplusofftoosmall, _arraytypemismatchexception, _arrayzeroerror, _bitarraytypeunsupported, _emptyarray, _emptyornullarray, _guidarrayctor, _mustbeprimarray, _need1darray;
    IMessageDescription? _need2darray, _need3darray, _parmarraysize, _safearrayrankmismatchexception, _safearraytypemismatchexception, _arraygetinterfacemap, _arraysinvalid, _arraytoolarge, _emptywaithandlearray, _hastobearrayclass;
    IMessageDescription? _indexoutofarraybounds, _invalidarraylength, _invalidarraytype, _invalidgenericinstarray, _mismatchedarrays, _othernotarrayofcorrectlength, _array, _arrayelement, _arrayvalue, _arraylength;
    IMessageDescription? _arraylengthmultiple, _arraylistinsert, _arraytoosmall, _rankmultidimnotsupported, _longerthandestarray, _longerthansrcarray, _arraylb, _arraylbandlength, _typemismatchcantassigntype, _typemismatchconstrainedcopy;
    IMessageDescription? _rankmustmatch;
    
    /// <summary>Array lengths must be the same.</summary>
    public IMessageDescription ArrayLengthsDiffer { get => _arraylengthsdiffer!; set => this.AssertWritable()._arraylengthsdiffer = value; }
    /// <summary>Destination array is not long enough to copy all the items in the collection. Check array index and length.</summary>
    public IMessageDescription ArrayPlusOffTooSmall { get => _arrayplusofftoosmall!; set => this.AssertWritable()._arrayplusofftoosmall = value; }
    /// <summary>System</summary>
    public IMessageDescription ArrayTypeMismatchException { get => _arraytypemismatchexception!; set => this.AssertWritable()._arraytypemismatchexception = value; }
    /// <summary>Array must not be of length zero.</summary>
    public IMessageDescription ArrayZeroError { get => _arrayzeroerror!; set => this.AssertWritable()._arrayzeroerror = value; }
    /// <summary>Only supported array types for CopyTo on BitArrays are Boolean[], Int32[] and Byte[].</summary>
    public IMessageDescription BitArrayTypeUnsupported { get => _bitarraytypeunsupported!; set => this.AssertWritable()._bitarraytypeunsupported = value; }
    /// <summary>Array may not be empty.</summary>
    public IMessageDescription EmptyArray { get => _emptyarray!; set => this.AssertWritable()._emptyarray = value; }
    /// <summary>Array may not be empty or null.</summary>
    public IMessageDescription EmptyOrNullArray { get => _emptyornullarray!; set => this.AssertWritable()._emptyornullarray = value; }
    /// <summary>Byte array for GUID must be exactly {0} bytes long.</summary>
    public IMessageDescription GuidArrayCtor { get => _guidarrayctor!; set => this.AssertWritable()._guidarrayctor = value; }
    /// <summary>Object must be an array of primitives.</summary>
    public IMessageDescription MustBePrimArray { get => _mustbeprimarray!; set => this.AssertWritable()._mustbeprimarray = value; }
    /// <summary>Array was not a one-dimensional array.</summary>
    public IMessageDescription Need1DArray { get => _need1darray!; set => this.AssertWritable()._need1darray = value; }
    /// <summary>Array was not a two-dimensional array.</summary>
    public IMessageDescription Need2DArray { get => _need2darray!; set => this.AssertWritable()._need2darray = value; }
    /// <summary>Array was not a three-dimensional array.</summary>
    public IMessageDescription Need3DArray { get => _need3darray!; set => this.AssertWritable()._need3darray = value; }
    /// <summary>Must specify one or more parameters.</summary>
    public IMessageDescription ParmArraySize { get => _parmarraysize!; set => this.AssertWritable()._parmarraysize = value; }
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription SafeArrayRankMismatchException { get => _safearrayrankmismatchexception!; set => this.AssertWritable()._safearrayrankmismatchexception = value; }
    /// <summary>System.Runtime.InteropServices</summary>
    public IMessageDescription SafeArrayTypeMismatchException { get => _safearraytypemismatchexception!; set => this.AssertWritable()._safearraytypemismatchexception = value; }
    /// <summary>Interface maps for generic interfaces on arrays cannot be retrived.</summary>
    public IMessageDescription ArrayGetInterfaceMap { get => _arraygetinterfacemap!; set => this.AssertWritable()._arraygetinterfacemap = value; }
    /// <summary>Array or pointer types are not valid.</summary>
    public IMessageDescription ArraysInvalid { get => _arraysinvalid!; set => this.AssertWritable()._arraysinvalid = value; }
    /// <summary>The input array length must not exceed Int32.MaxValue / {0}. Otherwise BitArray.Length would exceed Int32.MaxValue.</summary>
    public IMessageDescription ArrayTooLarge { get => _arraytoolarge!; set => this.AssertWritable()._arraytoolarge = value; }
    /// <summary>Waithandle array may not be empty.</summary>
    public IMessageDescription EmptyWaithandleArray { get => _emptywaithandlearray!; set => this.AssertWritable()._emptywaithandlearray = value; }
    /// <summary>Must be an array type.</summary>
    public IMessageDescription HasToBeArrayClass { get => _hastobearrayclass!; set => this.AssertWritable()._hastobearrayclass = value; }
    /// <summary>The specified index is out of bounds of the specified array.</summary>
    public IMessageDescription IndexOutOfArrayBounds { get => _indexoutofarraybounds!; set => this.AssertWritable()._indexoutofarraybounds = value; }
    /// <summary>Length of the array must be {0}.</summary>
    public IMessageDescription InvalidArrayLength { get => _invalidarraylength!; set => this.AssertWritable()._invalidarraylength = value; }
    /// <summary>Target array type is not compatible with the type of items in the collection.</summary>
    public IMessageDescription InvalidArrayType { get => _invalidarraytype!; set => this.AssertWritable()._invalidarraytype = value; }
    /// <summary>Generic arguments must be provided for each generic parameter and each generic argument must be a RuntimeType.</summary>
    public IMessageDescription InvalidGenericInstArray { get => _invalidgenericinstarray!; set => this.AssertWritable()._invalidgenericinstarray = value; }
    /// <summary>Two arrays, {0} and {1}, must be of the same size.</summary>
    public IMessageDescription MismatchedArrays { get => _mismatchedarrays!; set => this.AssertWritable()._mismatchedarrays = value; }
    /// <summary>Object is not a array with the same number of elements as the array to compare it to.</summary>
    public IMessageDescription OtherNotArrayOfCorrectLength { get => _othernotarrayofcorrectlength!; set => this.AssertWritable()._othernotarrayofcorrectlength = value; }
    /// <summary>Array cannot be null.</summary>
    public IMessageDescription Array { get => _array!; set => this.AssertWritable()._array = value; }
    /// <summary>At least one element in the specified array was null.</summary>
    public IMessageDescription ArrayElement { get => _arrayelement!; set => this.AssertWritable()._arrayelement = value; }
    /// <summary>Found a null value within an array.</summary>
    public IMessageDescription ArrayValue { get => _arrayvalue!; set => this.AssertWritable()._arrayvalue = value; }
    /// <summary>The length of the array must be between {0} and {1}, inclusive.</summary>
    public IMessageDescription ArrayLength { get => _arraylength!; set => this.AssertWritable()._arraylength = value; }
    /// <summary>The length of the array must be a multiple of {0}.</summary>
    public IMessageDescription ArrayLengthMultiple { get => _arraylengthmultiple!; set => this.AssertWritable()._arraylengthmultiple = value; }
    /// <summary>Insertion index was out of range. Must be non-negative and less than or equal to size.</summary>
    public IMessageDescription ArrayListInsert { get => _arraylistinsert!; set => this.AssertWritable()._arraylistinsert = value; }
    /// <summary>Destination array is not long enough to copy all the required data. Check array length and offset.</summary>
    public IMessageDescription ArrayTooSmall { get => _arraytoosmall!; set => this.AssertWritable()._arraytoosmall = value; }
    /// <summary>Only single dimension arrays are supported here.</summary>
    public IMessageDescription RankMultiDimNotSupported { get => _rankmultidimnotsupported!; set => this.AssertWritable()._rankmultidimnotsupported = value; }
    /// <summary>Destination array was not long enough. Check destIndex and length, and the array&#39;s lower bounds.</summary>
    public IMessageDescription LongerThanDestArray { get => _longerthandestarray!; set => this.AssertWritable()._longerthandestarray = value; }
    /// <summary>Source array was not long enough. Check srcIndex and length, and the array&#39;s lower bounds.</summary>
    public IMessageDescription LongerThanSrcArray { get => _longerthansrcarray!; set => this.AssertWritable()._longerthansrcarray = value; }
    /// <summary>Number was less than the array&#39;s lower bound in the first dimension.</summary>
    public IMessageDescription ArrayLB { get => _arraylb!; set => this.AssertWritable()._arraylb = value; }
    /// <summary>Higher indices will exceed Int32.MaxValue because of large lower bound and/or length.</summary>
    public IMessageDescription ArrayLBAndLength { get => _arraylbandlength!; set => this.AssertWritable()._arraylbandlength = value; }
    /// <summary>Source array type cannot be assigned to destination array type.</summary>
    public IMessageDescription TypeMismatchCantAssignType { get => _typemismatchcantassigntype!; set => this.AssertWritable()._typemismatchcantassigntype = value; }
    /// <summary>Array.ConstrainedCopy will only work on array types that are provably compatible, without any form of boxing, unboxing, widening, or casting of each array element. Change the array types (i.e., copy a Derived[] to a Base[]), or use a mitigation strategy in the CER for Array.Copy&#39;s less powerful reliability contract, such as cloning the array or throwing away the potentially corrupt destination array.</summary>
    public IMessageDescription TypeMismatchConstrainedCopy { get => _typemismatchconstrainedcopy!; set => this.AssertWritable()._typemismatchconstrainedcopy = value; }
    /// <summary>The specified arrays must have the same number of dimensions.</summary>
    public IMessageDescription RankMustMatch { get => _rankmustmatch!; set => this.AssertWritable()._rankmustmatch = value; }

    /// <summary>Initialize fields</summary>
    public override ArrayMessages Initialize() 
    {
        base.Initialize();
        Add(_arraylengthsdiffer = new MessageDescription("mscorlib.Arg_ArrayLengthsDiffer", 0xA345002A, new ParameterlessText("Array lengths must be the same.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_arrayplusofftoosmall = new MessageDescription("mscorlib.Arg_ArrayPlusOffTooSmall", 0xA345002B, new ParameterlessText("Destination array is not long enough to copy all the items in the collection. Check array index and length.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_arraytypemismatchexception = new MessageDescription("mscorlib.Arg_ArrayTypeMismatchException", 0xA345002C, new ParameterlessText("Attempted to access an element as a type incompatible with the array.")).SetHResult(0x80131503).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.ArrayTypeMismatchException)));
        Add(_arrayzeroerror = new MessageDescription("mscorlib.Arg_ArrayZeroError", 0xA345002D, new ParameterlessText("Array must not be of length zero.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_bitarraytypeunsupported = new MessageDescription("mscorlib.Arg_BitArrayTypeUnsupported", 0xA3450030, new ParameterlessText("Only supported array types for CopyTo on BitArrays are Boolean[], Int32[] and Byte[].")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptyarray = new MessageDescription("mscorlib.Arg_EmptyArray", 0xA345004D, new ParameterlessText("Array may not be empty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptyornullarray = new MessageDescription("mscorlib.Arg_EmptyOrNullArray", 0xA345004F, new ParameterlessText("Array may not be empty or null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_guidarrayctor = new MessageDescription("mscorlib.Arg_GuidArrayCtor", 0xA3450069, new FormatText("Byte array for GUID must be exactly {0} bytes long.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mustbeprimarray = new MessageDescription("mscorlib.Arg_MustBePrimArray", 0xA34500A5, new ParameterlessText("Object must be an array of primitives.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_need1darray = new MessageDescription("mscorlib.Arg_Need1DArray", 0xA34500B6, new ParameterlessText("Array was not a one-dimensional array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_need2darray = new MessageDescription("mscorlib.Arg_Need2DArray", 0xA34500B7, new ParameterlessText("Array was not a two-dimensional array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_need3darray = new MessageDescription("mscorlib.Arg_Need3DArray", 0xA34500B8, new ParameterlessText("Array was not a three-dimensional array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_parmarraysize = new MessageDescription("mscorlib.Arg_ParmArraySize", 0xA34500CC, new ParameterlessText("Must specify one or more parameters.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_safearrayrankmismatchexception = new MessageDescription("mscorlib.Arg_SafeArrayRankMismatchException", 0xA34500F1, new ParameterlessText("Specified array was not of the expected rank.")).SetHResult(0x80131533).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.SafeArrayRankMismatchException)));
        Add(_safearraytypemismatchexception = new MessageDescription("mscorlib.Arg_SafeArrayTypeMismatchException", 0xA34500F2, new ParameterlessText("Specified array was not of the expected type.")).SetHResult(0x80131538).SetSeverity(MessageLevel.Error).SetDescription("System.Runtime.InteropServices").SetException(typeof(System.Runtime.InteropServices.SafeArrayTypeMismatchException)));
        Add(_arraygetinterfacemap = new MessageDescription("mscorlib.Argument_ArrayGetInterfaceMap", 0xA3450115, new ParameterlessText("Interface maps for generic interfaces on arrays cannot be retrived.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_arraysinvalid = new MessageDescription("mscorlib.Argument_ArraysInvalid", 0xA3450116, new ParameterlessText("Array or pointer types are not valid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_arraytoolarge = new MessageDescription("mscorlib.Argument_ArrayTooLarge", 0xA3450117, new FormatText("The input array length must not exceed Int32.MaxValue / {0}. Otherwise BitArray.Length would exceed Int32.MaxValue.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_emptywaithandlearray = new MessageDescription("mscorlib.Argument_EmptyWaithandleArray", 0xA345015F, new ParameterlessText("Waithandle array may not be empty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_hastobearrayclass = new MessageDescription("mscorlib.Argument_HasToBeArrayClass", 0xA3450170, new ParameterlessText("Must be an array type.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_indexoutofarraybounds = new MessageDescription("mscorlib.Argument_IndexOutOfArrayBounds", 0xA345017F, new ParameterlessText("The specified index is out of bounds of the specified array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidarraylength = new MessageDescription("mscorlib.Argument_InvalidArrayLength", 0xA3450185, new FormatText("Length of the array must be {0}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidarraytype = new MessageDescription("mscorlib.Argument_InvalidArrayType", 0xA3450186, new ParameterlessText("Target array type is not compatible with the type of items in the collection.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_invalidgenericinstarray = new MessageDescription("mscorlib.Argument_InvalidGenericInstArray", 0xA34501A0, new ParameterlessText("Generic arguments must be provided for each generic parameter and each generic argument must be a RuntimeType.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_mismatchedarrays = new MessageDescription("mscorlib.Argument_MismatchedArrays", 0xA34501E0, new FormatText("Two arrays, {0} and {1}, must be of  the same size.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_othernotarrayofcorrectlength = new MessageDescription("mscorlib.ArgumentException_OtherNotArrayOfCorrectLength", 0xA345025B, new ParameterlessText("Object is not a array with the same number of elements as the array to compare it to.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_array = new MessageDescription("mscorlib.ArgumentNull_Array", 0xA345025E, new ParameterlessText("Array cannot be null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_arrayelement = new MessageDescription("mscorlib.ArgumentNull_ArrayElement", 0xA345025F, new ParameterlessText("At least one element in the specified array was null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_arrayvalue = new MessageDescription("mscorlib.ArgumentNull_ArrayValue", 0xA3450260, new ParameterlessText("Found a null value within an array.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_arraylength = new MessageDescription("mscorlib.ArgumentOutOfRange_ArrayLength", 0xA3450276, new FormatText("The length of the array must be between {0} and {1}, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_arraylengthmultiple = new MessageDescription("mscorlib.ArgumentOutOfRange_ArrayLengthMultiple", 0xA3450277, new FormatText("The length of the array must be a multiple of {0}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_arraylistinsert = new MessageDescription("mscorlib.ArgumentOutOfRange_ArrayListInsert", 0xA3450278, new ParameterlessText("Insertion index was out of range. Must be non-negative and less than or equal to size.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_arraytoosmall = new MessageDescription("mscorlib.ArgumentOutOfRange_ArrayTooSmall", 0xA3450279, new ParameterlessText("Destination array is not long enough to copy all the required data. Check array length and offset.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_rankmultidimnotsupported = new MessageDescription("mscorlib.Rank_MultiDimNotSupported", 0xA34504EB, new ParameterlessText("Only single dimension arrays are supported here.")).SetHResult(0x80131517).SetSeverity(MessageLevel.Error).SetException(typeof(System.RankException)));
        Add(_longerthandestarray = new MessageDescription("mscorlib.Arg_LongerThanDestArray", 0xA345064E, new ParameterlessText("Destination array was not long enough. Check destIndex and length, and the array's lower bounds.")).SetSeverity(MessageLevel.Error));
        Add(_longerthansrcarray = new MessageDescription("mscorlib.Arg_LongerThanSrcArray", 0xA345064D, new ParameterlessText("Source array was not long enough. Check srcIndex and length, and the array's lower bounds.")).SetSeverity(MessageLevel.Error));
        Add(_arraylb = new MessageDescription("mscorlib.ArgumentOutOfRange_ArrayLB", 0xA3450680, new ParameterlessText("Number was less than the array's lower bound in the first dimension.")).SetSeverity(MessageLevel.Error));
        Add(_arraylbandlength = new MessageDescription("mscorlib.ArgumentOutOfRange_ArrayLBAndLength", 0xA3450681, new ParameterlessText("Higher indices will exceed Int32.MaxValue because of large lower bound and/or length.")).SetSeverity(MessageLevel.Error));
        Add(_typemismatchcantassigntype = new MessageDescription("mscorlib.ArrayTypeMismatch_CantAssignType", 0xA3450682, new ParameterlessText("Source array type cannot be assigned to destination array type.")).SetSeverity(MessageLevel.Error));
        Add(_typemismatchconstrainedcopy = new MessageDescription("mscorlib.ArrayTypeMismatch_ConstrainedCopy", 0xA3450683, new ParameterlessText("Array.ConstrainedCopy will only work on array types that are provably compatible, without any form of boxing, unboxing, widening, or casting of each array element.  Change the array types (i.e., copy a Derived[] to a Base[]), or use a mitigation strategy in the CER for Array.Copy's less powerful reliability contract, such as cloning the array or throwing away the potentially corrupt destination array.")).SetSeverity(MessageLevel.Error));
        Add(_rankmustmatch = new MessageDescription("mscorlib.Rank_MustMatch", 0xA345061D, new ParameterlessText("The specified arrays must have the same number of dimensions.")).SetHResult(0x80131517).SetSeverity(MessageLevel.Error).SetException(typeof(System.RankException)));
        return this;
    }    

}
