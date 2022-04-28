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

/// <summary>System.ArgumentOutOfRangeException</summary>
public class ArgumentOutOfRangeMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ArgumentOutOfRangeMessages> instance = new Lazy<ArgumentOutOfRangeMessages>(() => new ArgumentOutOfRangeMessages().Initialize().SetAllReadOnly<ArgumentOutOfRangeMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ArgumentOutOfRangeMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x005D;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _addressspace, _addvalue, _badhourminutesecond, _badyearmonthday, _beepfrequency, _biggerthancollection, _binaryreaderfillbuffer, _boundslowerupper, _calendarrange, _capacity;
    IMessageDescription? _consolebufferboundaries, _consolebufferlessthanwindowsize, _consolekey, _consoletitletoolong, _consolewindowbuffersize, _consolewindowpos, _consolewindowsizesize, _count, _cursorsize, _datetimebadmonths;
    IMessageDescription? _datetimebadticks, _datetimebadyears, _day, _dayofweek, _dayparam, _decimalround, _decimalscale, _endindexstartindex, _enum, _era;
    IMessageDescription? _filelengthtoobig, _filetimeinvalid, _genericpositive, _getbytecountoverflow, _getcharcountoverflow, _hashtableloadfactor, _index, _indexcount, _indexcountbuffer, _indexlargerthanmaxvalue;
    IMessageDescription? _indexlength, _indexoutofrange, _indexstring, _invalideravalue, _invalidhighsurrogate, _invalidlowsurrogate, _invalidthreshold, _invaliduserdefinedacetype, _invalidutf32, _length;
    IMessageDescription? _lengthgreaterthancapacity, _lengthtoolarge, _lessequaltointegermaxval, _listinsert, _month, _monthparam, _mustbenonnegint32, _mustbenonnegnum, _mustbepositive, _neednonnegnum;
    IMessageDescription? _neednonnegornegative1, _needposnum, _needvalidid, _negativecapacity, _negativecount, _negativelength, _negfilesize, _offsetlength, _offsetout, _paramsequence;
    IMessageDescription? _partialwchar, _periodtoolarge, _positionlessthancapacityrequired, _queuegrowfactor, _roundingdigits, _smallcapacity, _smallmaxcapacity, _startindex, _startindexlargerthanlength, _startindexlessthanlength;
    IMessageDescription? _streamlength, _timeouttoolarge, _uintptrmax1, _unmanagedmemstreamlength, _unmanagedmemstreamwraparound, _utcoffset, _utcoffsetanddaylightdelta, _version, _week, _year;
    IMessageDescription? _actualvalue, _maxargexceeded, _maxstringsexceeded;
    
    /// <summary>The number of bytes cannot exceed the virtual address space on a 32 bit machine.</summary>
    public IMessageDescription AddressSpace { get => _addressspace!; set => this.AssertWritable()._addressspace = value; }
    /// <summary>Value to add was out of range.</summary>
    public IMessageDescription AddValue { get => _addvalue!; set => this.AssertWritable()._addvalue = value; }
    /// <summary>Hour, Minute, and Second parameters describe an un-representable DateTime.</summary>
    public IMessageDescription BadHourMinuteSecond { get => _badhourminutesecond!; set => this.AssertWritable()._badhourminutesecond = value; }
    /// <summary>Year, Month, and Day parameters describe an un-representable DateTime.</summary>
    public IMessageDescription BadYearMonthDay { get => _badyearmonthday!; set => this.AssertWritable()._badyearmonthday = value; }
    /// <summary>Console.Beep&#39;s frequency must be between {0} and {1}.</summary>
    public IMessageDescription BeepFrequency { get => _beepfrequency!; set => this.AssertWritable()._beepfrequency = value; }
    /// <summary>Larger than collection size.</summary>
    public IMessageDescription BiggerThanCollection { get => _biggerthancollection!; set => this.AssertWritable()._biggerthancollection = value; }
    /// <summary>The number of bytes requested does not fit into BinaryReader&#39;s internal buffer.</summary>
    public IMessageDescription BinaryReaderFillBuffer { get => _binaryreaderfillbuffer!; set => this.AssertWritable()._binaryreaderfillbuffer = value; }
    /// <summary>Argument must be between {0} and {1}.</summary>
    public IMessageDescription BoundsLowerUpper { get => _boundslowerupper!; set => this.AssertWritable()._boundslowerupper = value; }
    /// <summary>Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive.</summary>
    public IMessageDescription CalendarRange { get => _calendarrange!; set => this.AssertWritable()._calendarrange = value; }
    /// <summary>Capacity exceeds maximum capacity.</summary>
    public IMessageDescription Capacity { get => _capacity!; set => this.AssertWritable()._capacity = value; }
    /// <summary>The value must be greater than or equal to zero and less than the console&#39;s buffer size in that dimension.</summary>
    public IMessageDescription ConsoleBufferBoundaries { get => _consolebufferboundaries!; set => this.AssertWritable()._consolebufferboundaries = value; }
    /// <summary>The console buffer size must not be less than the current size and position of the console window, nor greater than or equal to Int16.MaxValue.</summary>
    public IMessageDescription ConsoleBufferLessThanWindowSize { get => _consolebufferlessthanwindowsize!; set => this.AssertWritable()._consolebufferlessthanwindowsize = value; }
    /// <summary>Console key values must be between 0 and 255.</summary>
    public IMessageDescription ConsoleKey { get => _consolekey!; set => this.AssertWritable()._consolekey = value; }
    /// <summary>The console title is too long.</summary>
    public IMessageDescription ConsoleTitleTooLong { get => _consoletitletoolong!; set => this.AssertWritable()._consoletitletoolong = value; }
    /// <summary>The new console window size would force the console buffer size to be too large.</summary>
    public IMessageDescription ConsoleWindowBufferSize { get => _consolewindowbuffersize!; set => this.AssertWritable()._consolewindowbuffersize = value; }
    /// <summary>The window position must be set such that the current window size fits within the console&#39;s buffer, and the numbers must not be negative.</summary>
    public IMessageDescription ConsoleWindowPos { get => _consolewindowpos!; set => this.AssertWritable()._consolewindowpos = value; }
    /// <summary>The value must be less than the console&#39;s current maximum window size of {0} in that dimension. Note that this value depends on screen resolution and the console font.</summary>
    public IMessageDescription ConsoleWindowSizeSize { get => _consolewindowsizesize!; set => this.AssertWritable()._consolewindowsizesize = value; }
    /// <summary>Count must be positive and count must refer to a location within the string/array/collection.</summary>
    public IMessageDescription Count { get => _count!; set => this.AssertWritable()._count = value; }
    /// <summary>The cursor size is invalid. It must be a percentage between 1 and 100.</summary>
    public IMessageDescription CursorSize { get => _cursorsize!; set => this.AssertWritable()._cursorsize = value; }
    /// <summary>Months value must be between +/-120000.</summary>
    public IMessageDescription DateTimeBadMonths { get => _datetimebadmonths!; set => this.AssertWritable()._datetimebadmonths = value; }
    /// <summary>Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</summary>
    public IMessageDescription DateTimeBadTicks { get => _datetimebadticks!; set => this.AssertWritable()._datetimebadticks = value; }
    /// <summary>Years value must be between +/-10000.</summary>
    public IMessageDescription DateTimeBadYears { get => _datetimebadyears!; set => this.AssertWritable()._datetimebadyears = value; }
    /// <summary>Day must be between 1 and {0} for month {1}.</summary>
    public IMessageDescription Day { get => _day!; set => this.AssertWritable()._day = value; }
    /// <summary>The DayOfWeek enumeration must be in the range 0 through 6.</summary>
    public IMessageDescription DayOfWeek { get => _dayofweek!; set => this.AssertWritable()._dayofweek = value; }
    /// <summary>The Day parameter must be in the range 1 through 31.</summary>
    public IMessageDescription DayParam { get => _dayparam!; set => this.AssertWritable()._dayparam = value; }
    /// <summary>Decimal can only round to between 0 and 28 digits of precision.</summary>
    public IMessageDescription DecimalRound { get => _decimalround!; set => this.AssertWritable()._decimalround = value; }
    /// <summary>Decimal&#39;s scale value must be between 0 and 28, inclusive.</summary>
    public IMessageDescription DecimalScale { get => _decimalscale!; set => this.AssertWritable()._decimalscale = value; }
    /// <summary>endIndex cannot be greater than startIndex.</summary>
    public IMessageDescription EndIndexStartIndex { get => _endindexstartindex!; set => this.AssertWritable()._endindexstartindex = value; }
    /// <summary>Enum value was out of legal range.</summary>
    public IMessageDescription Enum { get => _enum!; set => this.AssertWritable()._enum = value; }
    /// <summary>Time value was out of era range.</summary>
    public IMessageDescription Era { get => _era!; set => this.AssertWritable()._era = value; }
    /// <summary>Specified file length was too large for the file system.</summary>
    public IMessageDescription FileLengthTooBig { get => _filelengthtoobig!; set => this.AssertWritable()._filelengthtoobig = value; }
    /// <summary>Not a valid Win32 FileTime.</summary>
    public IMessageDescription FileTimeInvalid { get => _filetimeinvalid!; set => this.AssertWritable()._filetimeinvalid = value; }
    /// <summary>Value must be positive.</summary>
    public IMessageDescription GenericPositive { get => _genericpositive!; set => this.AssertWritable()._genericpositive = value; }
    /// <summary>Too many characters. The resulting number of bytes is larger than what can be returned as an int.</summary>
    public IMessageDescription GetByteCountOverflow { get => _getbytecountoverflow!; set => this.AssertWritable()._getbytecountoverflow = value; }
    /// <summary>Too many bytes. The resulting number of chars is larger than what can be returned as an int.</summary>
    public IMessageDescription GetCharCountOverflow { get => _getcharcountoverflow!; set => this.AssertWritable()._getcharcountoverflow = value; }
    /// <summary>Load factor needs to be between 0.1 and 1.0.</summary>
    public IMessageDescription HashtableLoadFactor { get => _hashtableloadfactor!; set => this.AssertWritable()._hashtableloadfactor = value; }
    /// <summary>Index was out of range. Must be non-negative and less than the size of the collection.</summary>
    public IMessageDescription Index { get => _index!; set => this.AssertWritable()._index = value; }
    /// <summary>Index and count must refer to a location within the string.</summary>
    public IMessageDescription IndexCount { get => _indexcount!; set => this.AssertWritable()._indexcount = value; }
    /// <summary>Index and count must refer to a location within the buffer.</summary>
    public IMessageDescription IndexCountBuffer { get => _indexcountbuffer!; set => this.AssertWritable()._indexcountbuffer = value; }
    /// <summary>This collection cannot work with indices larger than Int32.MaxValue - 1 (0x7FFFFFFF - 1).</summary>
    public IMessageDescription IndexLargerThanMaxValue { get => _indexlargerthanmaxvalue!; set => this.AssertWritable()._indexlargerthanmaxvalue = value; }
    /// <summary>Index and length must refer to a location within the string.</summary>
    public IMessageDescription IndexLength { get => _indexlength!; set => this.AssertWritable()._indexlength = value; }
    /// <summary>The specified index is outside the current index range of this collection.</summary>
    public IMessageDescription IndexOutOfRange { get => _indexoutofrange!; set => this.AssertWritable()._indexoutofrange = value; }
    /// <summary>Index was out of range. Must be non-negative and less than the length of the string.</summary>
    public IMessageDescription IndexString { get => _indexstring!; set => this.AssertWritable()._indexstring = value; }
    /// <summary>Era value was not valid.</summary>
    public IMessageDescription InvalidEraValue { get => _invalideravalue!; set => this.AssertWritable()._invalideravalue = value; }
    /// <summary>A valid high surrogate character is between 0xd800 and 0xdbff, inclusive.</summary>
    public IMessageDescription InvalidHighSurrogate { get => _invalidhighsurrogate!; set => this.AssertWritable()._invalidhighsurrogate = value; }
    /// <summary>A valid low surrogate character is between 0xdc00 and 0xdfff, inclusive.</summary>
    public IMessageDescription InvalidLowSurrogate { get => _invalidlowsurrogate!; set => this.AssertWritable()._invalidlowsurrogate = value; }
    /// <summary>The specified threshold for creating dictionary is out of range.</summary>
    public IMessageDescription InvalidThreshold { get => _invalidthreshold!; set => this.AssertWritable()._invalidthreshold = value; }
    /// <summary>User-defined ACEs must not have a well-known ACE type.</summary>
    public IMessageDescription InvalidUserDefinedAceType { get => _invaliduserdefinedacetype!; set => this.AssertWritable()._invaliduserdefinedacetype = value; }
    /// <summary>A valid UTF32 value is between 0x000000 and 0x10ffff, inclusive, and should not include surrogate codepoint values (0x00d800 ~ 0x00dfff).</summary>
    public IMessageDescription InvalidUTF32 { get => _invalidutf32!; set => this.AssertWritable()._invalidutf32 = value; }
    /// <summary>The specified length exceeds maximum capacity of SecureString.</summary>
    public IMessageDescription Length { get => _length!; set => this.AssertWritable()._length = value; }
    /// <summary>The length cannot be greater than the capacity.</summary>
    public IMessageDescription LengthGreaterThanCapacity { get => _lengthgreaterthancapacity!; set => this.AssertWritable()._lengthgreaterthancapacity = value; }
    /// <summary>The specified length exceeds the maximum value of {0}.</summary>
    public IMessageDescription LengthTooLarge { get => _lengthtoolarge!; set => this.AssertWritable()._lengthtoolarge = value; }
    /// <summary>Argument must be less than or equal to 2^31 - 1 milliseconds.</summary>
    public IMessageDescription LessEqualToIntegerMaxVal { get => _lessequaltointegermaxval!; set => this.AssertWritable()._lessequaltointegermaxval = value; }
    /// <summary>Index must be within the bounds of the List.</summary>
    public IMessageDescription ListInsert { get => _listinsert!; set => this.AssertWritable()._listinsert = value; }
    /// <summary>Month must be between one and twelve.</summary>
    public IMessageDescription Month { get => _month!; set => this.AssertWritable()._month = value; }
    /// <summary>The Month parameter must be in the range 1 through 12.</summary>
    public IMessageDescription MonthParam { get => _monthparam!; set => this.AssertWritable()._monthparam = value; }
    /// <summary>Value must be non-negative and less than or equal to Int32.MaxValue.</summary>
    public IMessageDescription MustBeNonNegInt32 { get => _mustbenonnegint32!; set => this.AssertWritable()._mustbenonnegint32 = value; }
    /// <summary>&#39;{0}&#39; must be non-negative.</summary>
    public IMessageDescription MustBeNonNegNum { get => _mustbenonnegnum!; set => this.AssertWritable()._mustbenonnegnum = value; }
    /// <summary>&#39;{0}&#39; must be greater than zero.</summary>
    public IMessageDescription MustBePositive { get => _mustbepositive!; set => this.AssertWritable()._mustbepositive = value; }
    /// <summary>Non-negative number required.</summary>
    public IMessageDescription NeedNonNegNum { get => _neednonnegnum!; set => this.AssertWritable()._neednonnegnum = value; }
    /// <summary>Number must be either non-negative and less than or equal to Int32.MaxValue or -1.</summary>
    public IMessageDescription NeedNonNegOrNegative1 { get => _neednonnegornegative1!; set => this.AssertWritable()._neednonnegornegative1 = value; }
    /// <summary>Positive number required.</summary>
    public IMessageDescription NeedPosNum { get => _needposnum!; set => this.AssertWritable()._needposnum = value; }
    /// <summary>The ID parameter must be in the range {0} through {1}.</summary>
    public IMessageDescription NeedValidId { get => _needvalidid!; set => this.AssertWritable()._needvalidid = value; }
    /// <summary>Capacity must be positive.</summary>
    public IMessageDescription NegativeCapacity { get => _negativecapacity!; set => this.AssertWritable()._negativecapacity = value; }
    /// <summary>Count cannot be less than zero.</summary>
    public IMessageDescription NegativeCount { get => _negativecount!; set => this.AssertWritable()._negativecount = value; }
    /// <summary>Length cannot be less than zero.</summary>
    public IMessageDescription NegativeLength { get => _negativelength!; set => this.AssertWritable()._negativelength = value; }
    /// <summary>Length must be non-negative.</summary>
    public IMessageDescription NegFileSize { get => _negfilesize!; set => this.AssertWritable()._negfilesize = value; }
    /// <summary>Offset and length must refer to a position in the string.</summary>
    public IMessageDescription OffsetLength { get => _offsetlength!; set => this.AssertWritable()._offsetlength = value; }
    /// <summary>Either offset did not refer to a position in the string, or there is an insufficient length of destination character array.</summary>
    public IMessageDescription OffsetOut { get => _offsetout!; set => this.AssertWritable()._offsetout = value; }
    /// <summary>The specified parameter index is not in range.</summary>
    public IMessageDescription ParamSequence { get => _paramsequence!; set => this.AssertWritable()._paramsequence = value; }
    /// <summary>Pointer startIndex and length do not refer to a valid string.</summary>
    public IMessageDescription PartialWCHAR { get => _partialwchar!; set => this.AssertWritable()._partialwchar = value; }
    /// <summary>Period must be less than 2^32-2.</summary>
    public IMessageDescription PeriodTooLarge { get => _periodtoolarge!; set => this.AssertWritable()._periodtoolarge = value; }
    /// <summary>The position may not be greater or equal to the capacity of the accessor.</summary>
    public IMessageDescription PositionLessThanCapacityRequired { get => _positionlessthancapacityrequired!; set => this.AssertWritable()._positionlessthancapacityrequired = value; }
    /// <summary>Queue grow factor must be between {0} and {1}.</summary>
    public IMessageDescription QueueGrowFactor { get => _queuegrowfactor!; set => this.AssertWritable()._queuegrowfactor = value; }
    /// <summary>Rounding digits must be between 0 and 15, inclusive.</summary>
    public IMessageDescription RoundingDigits { get => _roundingdigits!; set => this.AssertWritable()._roundingdigits = value; }
    /// <summary>capacity was less than the current size.</summary>
    public IMessageDescription SmallCapacity { get => _smallcapacity!; set => this.AssertWritable()._smallcapacity = value; }
    /// <summary>MaxCapacity must be one or greater.</summary>
    public IMessageDescription SmallMaxCapacity { get => _smallmaxcapacity!; set => this.AssertWritable()._smallmaxcapacity = value; }
    /// <summary>StartIndex cannot be less than zero.</summary>
    public IMessageDescription StartIndex { get => _startindex!; set => this.AssertWritable()._startindex = value; }
    /// <summary>startIndex cannot be larger than length of string.</summary>
    public IMessageDescription StartIndexLargerThanLength { get => _startindexlargerthanlength!; set => this.AssertWritable()._startindexlargerthanlength = value; }
    /// <summary>startIndex must be less than length of string.</summary>
    public IMessageDescription StartIndexLessThanLength { get => _startindexlessthanlength!; set => this.AssertWritable()._startindexlessthanlength = value; }
    /// <summary>Stream length must be non-negative and less than 2^31 - 1 - origin.</summary>
    public IMessageDescription StreamLength { get => _streamlength!; set => this.AssertWritable()._streamlength = value; }
    /// <summary>Time-out interval must be less than 2^32-2.</summary>
    public IMessageDescription TimeoutTooLarge { get => _timeouttoolarge!; set => this.AssertWritable()._timeouttoolarge = value; }
    /// <summary>The length of the buffer must be less than the maximum UIntPtr value for your platform.</summary>
    public IMessageDescription UIntPtrMax1 { get => _uintptrmax1!; set => this.AssertWritable()._uintptrmax1 = value; }
    /// <summary>UnmanagedMemoryStream length must be non-negative and less than 2^63 - 1 - baseAddress.</summary>
    public IMessageDescription UnmanagedMemStreamLength { get => _unmanagedmemstreamlength!; set => this.AssertWritable()._unmanagedmemstreamlength = value; }
    /// <summary>The UnmanagedMemoryStream capacity would wrap around the high end of the address space.</summary>
    public IMessageDescription UnmanagedMemStreamWrapAround { get => _unmanagedmemstreamwraparound!; set => this.AssertWritable()._unmanagedmemstreamwraparound = value; }
    /// <summary>The TimeSpan parameter must be within plus or minus 14.0 hours.</summary>
    public IMessageDescription UtcOffset { get => _utcoffset!; set => this.AssertWritable()._utcoffset = value; }
    /// <summary>The sum of the BaseUtcOffset and DaylightDelta properties must within plus or minus 14.0 hours.</summary>
    public IMessageDescription UtcOffsetAndDaylightDelta { get => _utcoffsetanddaylightdelta!; set => this.AssertWritable()._utcoffsetanddaylightdelta = value; }
    /// <summary>Version&#39;s parameters must be greater than or equal to zero.</summary>
    public IMessageDescription Version { get => _version!; set => this.AssertWritable()._version = value; }
    /// <summary>The Week parameter must be in the range 1 through 5.</summary>
    public IMessageDescription Week { get => _week!; set => this.AssertWritable()._week = value; }
    /// <summary>Year must be between 1 and 9999.</summary>
    public IMessageDescription Year { get => _year!; set => this.AssertWritable()._year = value; }
    /// <summary>Actual value was {0}.</summary>
    public IMessageDescription ActualValue { get => _actualvalue!; set => this.AssertWritable()._actualvalue = value; }
    /// <summary>The total number of parameters must not exceed {0}.</summary>
    public IMessageDescription MaxArgExceeded { get => _maxargexceeded!; set => this.AssertWritable()._maxargexceeded = value; }
    /// <summary>The number of String parameters must not exceed {0}.</summary>
    public IMessageDescription MaxStringsExceeded { get => _maxstringsexceeded!; set => this.AssertWritable()._maxstringsexceeded = value; }

    /// <summary>Initialize fields</summary>
    public override ArgumentOutOfRangeMessages Initialize() 
    {
        base.Initialize();
        Add(_addressspace = new MessageDescription("mscorlib.ArgumentOutOfRange_AddressSpace", 0xA3450274, new ParameterlessText("The number of bytes cannot exceed the virtual address space on a 32 bit machine.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_addvalue = new MessageDescription("mscorlib.ArgumentOutOfRange_AddValue", 0xA3450275, new ParameterlessText("Value to add was out of range.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_badhourminutesecond = new MessageDescription("mscorlib.ArgumentOutOfRange_BadHourMinuteSecond", 0xA345027A, new ParameterlessText("Hour, Minute, and Second parameters describe an un-representable DateTime.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_badyearmonthday = new MessageDescription("mscorlib.ArgumentOutOfRange_BadYearMonthDay", 0xA345027B, new ParameterlessText("Year, Month, and Day parameters describe an un-representable DateTime.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_beepfrequency = new MessageDescription("mscorlib.ArgumentOutOfRange_BeepFrequency", 0xA345027C, new FormatText("Console.Beep's frequency must be between {0} and {1}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_biggerthancollection = new MessageDescription("mscorlib.ArgumentOutOfRange_BiggerThanCollection", 0xA345027D, new ParameterlessText("Larger than collection size.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_binaryreaderfillbuffer = new MessageDescription("mscorlib.ArgumentOutOfRange_BinaryReaderFillBuffer", 0xA345027E, new ParameterlessText("The number of bytes requested does not fit into BinaryReader's internal buffer.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_boundslowerupper = new MessageDescription("mscorlib.ArgumentOutOfRange_Bounds_Lower_Upper", 0xA345027F, new FormatText("Argument must be between {0} and {1}.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_calendarrange = new MessageDescription("mscorlib.ArgumentOutOfRange_CalendarRange", 0xA3450280, new FormatText("Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_capacity = new MessageDescription("mscorlib.ArgumentOutOfRange_Capacity", 0xA3450281, new ParameterlessText("Capacity exceeds maximum capacity.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consolebufferboundaries = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleBufferBoundaries", 0xA3450282, new ParameterlessText("The value must be greater than or equal to zero and less than the console's buffer size in that dimension.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consolebufferlessthanwindowsize = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleBufferLessThanWindowSize", 0xA3450283, new ParameterlessText("The console buffer size must not be less than the current size and position of the console window, nor greater than or equal to Int16.MaxValue.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consolekey = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleKey", 0xA3450284, new ParameterlessText("Console key values must be between 0 and 255.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consoletitletoolong = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleTitleTooLong", 0xA3450285, new ParameterlessText("The console title is too long.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consolewindowbuffersize = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleWindowBufferSize", 0xA3450286, new ParameterlessText("The new console window size would force the console buffer size to be too large.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consolewindowpos = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleWindowPos", 0xA3450287, new ParameterlessText("The window position must be set such that the current window size fits within the console's buffer, and the numbers must not be negative.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_consolewindowsizesize = new MessageDescription("mscorlib.ArgumentOutOfRange_ConsoleWindowSize_Size", 0xA3450288, new FormatText("The value must be less than the console's current maximum window size of {0} in that dimension. Note that this value depends on screen resolution and the console font.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_count = new MessageDescription("mscorlib.ArgumentOutOfRange_Count", 0xA3450289, new ParameterlessText("Count must be positive and count must refer to a location within the string/array/collection.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_cursorsize = new MessageDescription("mscorlib.ArgumentOutOfRange_CursorSize", 0xA345028A, new ParameterlessText("The cursor size is invalid. It must be a percentage between 1 and 100.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_datetimebadmonths = new MessageDescription("mscorlib.ArgumentOutOfRange_DateTimeBadMonths", 0xA345028C, new ParameterlessText("Months value must be between +/-120000.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_datetimebadticks = new MessageDescription("mscorlib.ArgumentOutOfRange_DateTimeBadTicks", 0xA345028D, new ParameterlessText("Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_datetimebadyears = new MessageDescription("mscorlib.ArgumentOutOfRange_DateTimeBadYears", 0xA345028E, new ParameterlessText("Years value must be between +/-10000.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_day = new MessageDescription("mscorlib.ArgumentOutOfRange_Day", 0xA345028F, new FormatText("Day must be between 1 and {0} for month {1}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_dayofweek = new MessageDescription("mscorlib.ArgumentOutOfRange_DayOfWeek", 0xA3450290, new ParameterlessText("The DayOfWeek enumeration must be in the range 0 through 6.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_dayparam = new MessageDescription("mscorlib.ArgumentOutOfRange_DayParam", 0xA3450291, new ParameterlessText("The Day parameter must be in the range 1 through 31.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_decimalround = new MessageDescription("mscorlib.ArgumentOutOfRange_DecimalRound", 0xA3450292, new ParameterlessText("Decimal can only round to between 0 and 28 digits of precision.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_decimalscale = new MessageDescription("mscorlib.ArgumentOutOfRange_DecimalScale", 0xA3450293, new ParameterlessText("Decimal's scale value must be between 0 and 28, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_endindexstartindex = new MessageDescription("mscorlib.ArgumentOutOfRange_EndIndexStartIndex", 0xA3450294, new ParameterlessText("endIndex cannot be greater than startIndex.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_enum = new MessageDescription("mscorlib.ArgumentOutOfRange_Enum", 0xA3450295, new ParameterlessText("Enum value was out of legal range.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_era = new MessageDescription("mscorlib.ArgumentOutOfRange_Era", 0xA3450296, new ParameterlessText("Time value was out of era range.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_filelengthtoobig = new MessageDescription("mscorlib.ArgumentOutOfRange_FileLengthTooBig", 0xA3450297, new ParameterlessText("Specified file length was too large for the file system.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_filetimeinvalid = new MessageDescription("mscorlib.ArgumentOutOfRange_FileTimeInvalid", 0xA3450298, new ParameterlessText("Not a valid Win32 FileTime.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_genericpositive = new MessageDescription("mscorlib.ArgumentOutOfRange_GenericPositive", 0xA3450299, new ParameterlessText("Value must be positive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_getbytecountoverflow = new MessageDescription("mscorlib.ArgumentOutOfRange_GetByteCountOverflow", 0xA345029A, new ParameterlessText("Too many characters. The resulting number of bytes is larger than what can be returned as an int.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_getcharcountoverflow = new MessageDescription("mscorlib.ArgumentOutOfRange_GetCharCountOverflow", 0xA345029B, new ParameterlessText("Too many bytes. The resulting number of chars is larger than what can be returned as an int.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_hashtableloadfactor = new MessageDescription("mscorlib.ArgumentOutOfRange_HashtableLoadFactor", 0xA345029C, new ParameterlessText("Load factor needs to be between 0.1 and 1.0.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_index = new MessageDescription("mscorlib.ArgumentOutOfRange_Index", 0xA345029E, new ParameterlessText("Index was out of range. Must be non-negative and less than the size of the collection.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_indexcount = new MessageDescription("mscorlib.ArgumentOutOfRange_IndexCount", 0xA345029F, new ParameterlessText("Index and count must refer to a location within the string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_indexcountbuffer = new MessageDescription("mscorlib.ArgumentOutOfRange_IndexCountBuffer", 0xA34502A0, new ParameterlessText("Index and count must refer to a location within the buffer.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_indexlargerthanmaxvalue = new MessageDescription("mscorlib.ArgumentOutOfRange_IndexLargerThanMaxValue", 0xA34502A1, new ParameterlessText("This collection cannot work with indices larger than Int32.MaxValue - 1 (0x7FFFFFFF - 1).")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_indexlength = new MessageDescription("mscorlib.ArgumentOutOfRange_IndexLength", 0xA34502A2, new ParameterlessText("Index and length must refer to a location within the string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_indexoutofrange = new MessageDescription("mscorlib.ArgumentOutOfRange_IndexOutOfRange", 0xA34502A3, new ParameterlessText("The specified index is outside the current index range of this collection.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_indexstring = new MessageDescription("mscorlib.ArgumentOutOfRange_IndexString", 0xA34502A4, new ParameterlessText("Index was out of range. Must be non-negative and less than the length of the string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalideravalue = new MessageDescription("mscorlib.ArgumentOutOfRange_InvalidEraValue", 0xA34502A5, new ParameterlessText("Era value was not valid.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalidhighsurrogate = new MessageDescription("mscorlib.ArgumentOutOfRange_InvalidHighSurrogate", 0xA34502A6, new ParameterlessText("A valid high surrogate character is between 0xd800 and 0xdbff, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalidlowsurrogate = new MessageDescription("mscorlib.ArgumentOutOfRange_InvalidLowSurrogate", 0xA34502A7, new ParameterlessText("A valid low surrogate character is between 0xdc00 and 0xdfff, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalidthreshold = new MessageDescription("mscorlib.ArgumentOutOfRange_InvalidThreshold", 0xA34502A8, new ParameterlessText("The specified threshold for creating dictionary is out of range.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invaliduserdefinedacetype = new MessageDescription("mscorlib.ArgumentOutOfRange_InvalidUserDefinedAceType", 0xA34502A9, new ParameterlessText("User-defined ACEs must not have a well-known ACE type.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_invalidutf32 = new MessageDescription("mscorlib.ArgumentOutOfRange_InvalidUTF32", 0xA34502AA, new ParameterlessText("A valid UTF32 value is between 0x000000 and 0x10ffff, inclusive, and should not include surrogate codepoint values (0x00d800 ~ 0x00dfff).")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_length = new MessageDescription("mscorlib.ArgumentOutOfRange_Length", 0xA34502AB, new ParameterlessText("The specified length exceeds maximum capacity of SecureString.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_lengthgreaterthancapacity = new MessageDescription("mscorlib.ArgumentOutOfRange_LengthGreaterThanCapacity", 0xA34502AC, new ParameterlessText("The length cannot be greater than the capacity.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_lengthtoolarge = new MessageDescription("mscorlib.ArgumentOutOfRange_LengthTooLarge", 0xA34502AD, new FormatText("The specified length exceeds the maximum value of {0}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_lessequaltointegermaxval = new MessageDescription("mscorlib.ArgumentOutOfRange_LessEqualToIntegerMaxVal", 0xA34502AE, new ParameterlessText("Argument must be less than or equal to 2^31 - 1 milliseconds.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_listinsert = new MessageDescription("mscorlib.ArgumentOutOfRange_ListInsert", 0xA34502AF, new ParameterlessText("Index must be within the bounds of the List.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_month = new MessageDescription("mscorlib.ArgumentOutOfRange_Month", 0xA34502B0, new ParameterlessText("Month must be between one and twelve.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_monthparam = new MessageDescription("mscorlib.ArgumentOutOfRange_MonthParam", 0xA34502B1, new ParameterlessText("The Month parameter must be in the range 1 through 12.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_mustbenonnegint32 = new MessageDescription("mscorlib.ArgumentOutOfRange_MustBeNonNegInt32", 0xA34502B2, new ParameterlessText("Value must be non-negative and less than or equal to Int32.MaxValue.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_mustbenonnegnum = new MessageDescription("mscorlib.ArgumentOutOfRange_MustBeNonNegNum", 0xA34502B3, new FormatText("'{0}' must be non-negative.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_mustbepositive = new MessageDescription("mscorlib.ArgumentOutOfRange_MustBePositive", 0xA34502B4, new FormatText("'{0}' must be greater than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_neednonnegnum = new MessageDescription("mscorlib.ArgumentOutOfRange_NeedNonNegNum", 0xA34502B5, new ParameterlessText("Non-negative number required.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_neednonnegornegative1 = new MessageDescription("mscorlib.ArgumentOutOfRange_NeedNonNegOrNegative1", 0xA34502B6, new ParameterlessText("Number must be either non-negative and less than or equal to Int32.MaxValue or -1.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_needposnum = new MessageDescription("mscorlib.ArgumentOutOfRange_NeedPosNum", 0xA34502B7, new ParameterlessText("Positive number required.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_needvalidid = new MessageDescription("mscorlib.ArgumentOutOfRange_NeedValidId", 0xA34502B8, new FormatText("The ID parameter must be in the range {0} through {1}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_negativecapacity = new MessageDescription("mscorlib.ArgumentOutOfRange_NegativeCapacity", 0xA34502B9, new ParameterlessText("Capacity must be positive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_negativecount = new MessageDescription("mscorlib.ArgumentOutOfRange_NegativeCount", 0xA34502BA, new ParameterlessText("Count cannot be less than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_negativelength = new MessageDescription("mscorlib.ArgumentOutOfRange_NegativeLength", 0xA34502BB, new ParameterlessText("Length cannot be less than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_negfilesize = new MessageDescription("mscorlib.ArgumentOutOfRange_NegFileSize", 0xA34502BC, new ParameterlessText("Length must be non-negative.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_offsetlength = new MessageDescription("mscorlib.ArgumentOutOfRange_OffsetLength", 0xA34502BE, new ParameterlessText("Offset and length must refer to a position in the string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_offsetout = new MessageDescription("mscorlib.ArgumentOutOfRange_OffsetOut", 0xA34502BF, new ParameterlessText("Either offset did not refer to a position in the string, or there is an insufficient length of destination character array.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_paramsequence = new MessageDescription("mscorlib.ArgumentOutOfRange_ParamSequence", 0xA34502C0, new ParameterlessText("The specified parameter index is not in range.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_partialwchar = new MessageDescription("mscorlib.ArgumentOutOfRange_PartialWCHAR", 0xA34502C1, new ParameterlessText("Pointer startIndex and length do not refer to a valid string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_periodtoolarge = new MessageDescription("mscorlib.ArgumentOutOfRange_PeriodTooLarge", 0xA34502C2, new ParameterlessText("Period must be less than 2^32-2.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_positionlessthancapacityrequired = new MessageDescription("mscorlib.ArgumentOutOfRange_PositionLessThanCapacityRequired", 0xA34502C3, new ParameterlessText("The position may not be greater or equal to the capacity of the accessor.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_queuegrowfactor = new MessageDescription("mscorlib.ArgumentOutOfRange_QueueGrowFactor", 0xA34502C4, new FormatText("Queue grow factor must be between {0} and {1}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_roundingdigits = new MessageDescription("mscorlib.ArgumentOutOfRange_RoundingDigits", 0xA34502C6, new ParameterlessText("Rounding digits must be between 0 and 15, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_smallcapacity = new MessageDescription("mscorlib.ArgumentOutOfRange_SmallCapacity", 0xA34502C7, new ParameterlessText("capacity was less than the current size.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_smallmaxcapacity = new MessageDescription("mscorlib.ArgumentOutOfRange_SmallMaxCapacity", 0xA34502C8, new ParameterlessText("MaxCapacity must be one or greater.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_startindex = new MessageDescription("mscorlib.ArgumentOutOfRange_StartIndex", 0xA34502C9, new ParameterlessText("StartIndex cannot be less than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_startindexlargerthanlength = new MessageDescription("mscorlib.ArgumentOutOfRange_StartIndexLargerThanLength", 0xA34502CA, new ParameterlessText("startIndex cannot be larger than length of string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_startindexlessthanlength = new MessageDescription("mscorlib.ArgumentOutOfRange_StartIndexLessThanLength", 0xA34502CB, new ParameterlessText("startIndex must be less than length of string.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_streamlength = new MessageDescription("mscorlib.ArgumentOutOfRange_StreamLength", 0xA34502CC, new ParameterlessText("Stream length must be non-negative and less than 2^31 - 1 - origin.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_timeouttoolarge = new MessageDescription("mscorlib.ArgumentOutOfRange_TimeoutTooLarge", 0xA34502CD, new ParameterlessText("Time-out interval must be less than 2^32-2.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_uintptrmax1 = new MessageDescription("mscorlib.ArgumentOutOfRange_UIntPtrMax-1", 0xA34502CE, new ParameterlessText("The length of the buffer must be less than the maximum UIntPtr value for your platform.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_unmanagedmemstreamlength = new MessageDescription("mscorlib.ArgumentOutOfRange_UnmanagedMemStreamLength", 0xA34502CF, new ParameterlessText("UnmanagedMemoryStream length must be non-negative and less than 2^63 - 1 - baseAddress.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_unmanagedmemstreamwraparound = new MessageDescription("mscorlib.ArgumentOutOfRange_UnmanagedMemStreamWrapAround", 0xA34502D0, new ParameterlessText("The UnmanagedMemoryStream capacity would wrap around the high end of the address space.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_utcoffset = new MessageDescription("mscorlib.ArgumentOutOfRange_UtcOffset", 0xA34502D1, new ParameterlessText("The TimeSpan parameter must be within plus or minus 14.0 hours.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_utcoffsetanddaylightdelta = new MessageDescription("mscorlib.ArgumentOutOfRange_UtcOffsetAndDaylightDelta", 0xA34502D2, new ParameterlessText("The sum of the BaseUtcOffset and DaylightDelta properties must within plus or minus 14.0 hours.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidTimeZoneException)));
        Add(_version = new MessageDescription("mscorlib.ArgumentOutOfRange_Version", 0xA34502D3, new ParameterlessText("Version's parameters must be greater than or equal to zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_week = new MessageDescription("mscorlib.ArgumentOutOfRange_Week", 0xA34502D4, new ParameterlessText("The Week parameter must be in the range 1 through 5.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_year = new MessageDescription("mscorlib.ArgumentOutOfRange_Year", 0xA34502D5, new ParameterlessText("Year must be between 1 and 9999.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_actualvalue = new MessageDescription("mscorlib.ArgumentOutOfRange_ActualValue", 0xA345062D, new FormatText("Actual value was {0}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_maxargexceeded = new MessageDescription("mscorlib.ArgumentOutOfRange_MaxArgExceeded", 0xA3450694, new FormatText("The total number of parameters must not exceed {0}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_maxstringsexceeded = new MessageDescription("mscorlib.ArgumentOutOfRange_MaxStringsExceeded", 0xA3450695, new FormatText("The number of String parameters must not exceed {0}.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        return this;
    }    

}
