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

/// <summary>System.FormatException</summary>
public class FormatMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<FormatMessages> instance = new Lazy<FormatMessages>(() => new FormatMessages().Initialize().SetAllReadOnly<FormatMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static FormatMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0026;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _attributeusage, _bad7bitint32, _badbase, _badbase64char, _badbase64chararraylength, _badboolean, _badformatspecifier, _badquote, _guidinvalidchar, _guidunrecognized;
    IMessageDescription? _indexoutofrange, _invalidenumformatspecification, _invalidguidformatspecification, _invalidstring, _needsinglechar, _stringzerolength, _baddatepattern, _baddatetime, _baddatetimecalendar, _baddayofweek;
    IMessageDescription? _badtimespan, _dateoutofrange, _emptyinputstring, _extrajunkatend, _guidbrace, _guidbraceafterlastnumber, _guidcomma, _guiddashes, _guidendbrace, _guidhexprefix;
    IMessageDescription? _guidinvlen, _missingincompletedate, _noparsibledigits, _offsetoutofrange, _repeatdatetimepattern, _twotimezonespecifiers, _utcoutofrange, _unknowdatetimeword;
    
    /// <summary>Duplicate AttributeUsageAttribute found on attribute type {0}.</summary>
    public IMessageDescription AttributeUsage { get => _attributeusage!; set => this.AssertWritable()._attributeusage = value; }
    /// <summary>Too many bytes in what should have been a 7 bit encoded Int32.</summary>
    public IMessageDescription Bad7BitInt32 { get => _bad7bitint32!; set => this.AssertWritable()._bad7bitint32 = value; }
    /// <summary>Invalid digits for the specified base.</summary>
    public IMessageDescription BadBase { get => _badbase!; set => this.AssertWritable()._badbase = value; }
    /// <summary>The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.</summary>
    public IMessageDescription BadBase64Char { get => _badbase64char!; set => this.AssertWritable()._badbase64char = value; }
    /// <summary>Invalid length for a Base-64 char array or string.</summary>
    public IMessageDescription BadBase64CharArrayLength { get => _badbase64chararraylength!; set => this.AssertWritable()._badbase64chararraylength = value; }
    /// <summary>String was not recognized as a valid Boolean.</summary>
    public IMessageDescription BadBoolean { get => _badboolean!; set => this.AssertWritable()._badboolean = value; }
    /// <summary>Format specifier was invalid.</summary>
    public IMessageDescription BadFormatSpecifier { get => _badformatspecifier!; set => this.AssertWritable()._badformatspecifier = value; }
    /// <summary>Cannot find a matching quote character for the character &#39;{0}&#39;.</summary>
    public IMessageDescription BadQuote { get => _badquote!; set => this.AssertWritable()._badquote = value; }
    /// <summary>Guid string should only contain hexadecimal characters.</summary>
    public IMessageDescription GuidInvalidChar { get => _guidinvalidchar!; set => this.AssertWritable()._guidinvalidchar = value; }
    /// <summary>Unrecognized Guid format.</summary>
    public IMessageDescription GuidUnrecognized { get => _guidunrecognized!; set => this.AssertWritable()._guidunrecognized = value; }
    /// <summary>Index (zero based) must be greater than or equal to zero and less than the size of the argument list.</summary>
    public IMessageDescription IndexOutOfRange { get => _indexoutofrange!; set => this.AssertWritable()._indexoutofrange = value; }
    /// <summary>Format String can be only &quot;G&quot;, &quot;g&quot;, &quot;X&quot;, &quot;x&quot;, &quot;F&quot;, &quot;f&quot;, &quot;D&quot; or &quot;d&quot;.</summary>
    public IMessageDescription InvalidEnumFormatSpecification { get => _invalidenumformatspecification!; set => this.AssertWritable()._invalidenumformatspecification = value; }
    /// <summary>Format String can be only &quot;D&quot;, &quot;d&quot;, &quot;N&quot;, &quot;n&quot;, &quot;P&quot;, &quot;p&quot;, &quot;B&quot;, &quot;b&quot;, &quot;X&quot; or &quot;x&quot;.</summary>
    public IMessageDescription InvalidGuidFormatSpecification { get => _invalidguidformatspecification!; set => this.AssertWritable()._invalidguidformatspecification = value; }
    /// <summary>Input string was not in a correct format.</summary>
    public IMessageDescription InvalidString { get => _invalidstring!; set => this.AssertWritable()._invalidstring = value; }
    /// <summary>String must be exactly one character long.</summary>
    public IMessageDescription NeedSingleChar { get => _needsinglechar!; set => this.AssertWritable()._needsinglechar = value; }
    /// <summary>String cannot have zero length.</summary>
    public IMessageDescription StringZeroLength { get => _stringzerolength!; set => this.AssertWritable()._stringzerolength = value; }
    /// <summary>Could not determine the order of year, month, and date from &#39;{0}&#39;.</summary>
    public IMessageDescription BadDatePattern { get => _baddatepattern!; set => this.AssertWritable()._baddatepattern = value; }
    /// <summary>String was not recognized as a valid DateTime.</summary>
    public IMessageDescription BadDateTime { get => _baddatetime!; set => this.AssertWritable()._baddatetime = value; }
    /// <summary>The DateTime represented by the string is not supported in calendar {0}.</summary>
    public IMessageDescription BadDateTimeCalendar { get => _baddatetimecalendar!; set => this.AssertWritable()._baddatetimecalendar = value; }
    /// <summary>String was not recognized as a valid DateTime because the day of week was incorrect.</summary>
    public IMessageDescription BadDayOfWeek { get => _baddayofweek!; set => this.AssertWritable()._baddayofweek = value; }
    /// <summary>String was not recognized as a valid TimeSpan.</summary>
    public IMessageDescription BadTimeSpan { get => _badtimespan!; set => this.AssertWritable()._badtimespan = value; }
    /// <summary>The DateTime represented by the string is out of range.</summary>
    public IMessageDescription DateOutOfRange { get => _dateoutofrange!; set => this.AssertWritable()._dateoutofrange = value; }
    /// <summary>Input string was either empty or contained only whitespace.</summary>
    public IMessageDescription EmptyInputString { get => _emptyinputstring!; set => this.AssertWritable()._emptyinputstring = value; }
    /// <summary>Additional non-parsable characters are at the end of the string.</summary>
    public IMessageDescription ExtraJunkAtEnd { get => _extrajunkatend!; set => this.AssertWritable()._extrajunkatend = value; }
    /// <summary>Expected {0xdddddddd, etc}.</summary>
    public IMessageDescription GuidBrace { get => _guidbrace!; set => this.AssertWritable()._guidbrace = value; }
    /// <summary>Could not find a brace, or the length between the previous token and the brace was zero (i.e., &#39;0x,&#39;etc.).</summary>
    public IMessageDescription GuidBraceAfterLastNumber { get => _guidbraceafterlastnumber!; set => this.AssertWritable()._guidbraceafterlastnumber = value; }
    /// <summary>Could not find a comma, or the length between the previous token and the comma was zero (i.e., &#39;0x,&#39;etc.).</summary>
    public IMessageDescription GuidComma { get => _guidcomma!; set => this.AssertWritable()._guidcomma = value; }
    /// <summary>Dashes are in the wrong position for GUID parsing.</summary>
    public IMessageDescription GuidDashes { get => _guiddashes!; set => this.AssertWritable()._guiddashes = value; }
    /// <summary>Could not find the ending brace.</summary>
    public IMessageDescription GuidEndBrace { get => _guidendbrace!; set => this.AssertWritable()._guidendbrace = value; }
    /// <summary>Expected hex 0x in &#39;{0}&#39;.</summary>
    public IMessageDescription GuidHexPrefix { get => _guidhexprefix!; set => this.AssertWritable()._guidhexprefix = value; }
    /// <summary>Guid should contain 32 digits with 4 dashes (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).</summary>
    public IMessageDescription GuidInvLen { get => _guidinvlen!; set => this.AssertWritable()._guidinvlen = value; }
    /// <summary>There must be at least a partial date with a year present in the input.</summary>
    public IMessageDescription MissingIncompleteDate { get => _missingincompletedate!; set => this.AssertWritable()._missingincompletedate = value; }
    /// <summary>Could not find any recognizable digits.</summary>
    public IMessageDescription NoParsibleDigits { get => _noparsibledigits!; set => this.AssertWritable()._noparsibledigits = value; }
    /// <summary>The time zone offset must be within plus or minus 14 hours.</summary>
    public IMessageDescription OffsetOutOfRange { get => _offsetoutofrange!; set => this.AssertWritable()._offsetoutofrange = value; }
    /// <summary>DateTime pattern &#39;{0}&#39; appears more than once with different values.</summary>
    public IMessageDescription RepeatDateTimePattern { get => _repeatdatetimepattern!; set => this.AssertWritable()._repeatdatetimepattern = value; }
    /// <summary>The String being parsed cannot contain two TimeZone specifiers.</summary>
    public IMessageDescription TwoTimeZoneSpecifiers { get => _twotimezonespecifiers!; set => this.AssertWritable()._twotimezonespecifiers = value; }
    /// <summary>The UTC representation of the date falls outside the year range 1-9999.</summary>
    public IMessageDescription UTCOutOfRange { get => _utcoutofrange!; set => this.AssertWritable()._utcoutofrange = value; }
    /// <summary>The string was not recognized as a valid DateTime. There is an unknown word starting at index {0}.</summary>
    public IMessageDescription UnknowDateTimeWord { get => _unknowdatetimeword!; set => this.AssertWritable()._unknowdatetimeword = value; }

    /// <summary>Initialize fields</summary>
    public override FormatMessages Initialize() 
    {
        base.Initialize();
        Add(_attributeusage = new MessageDescription("mscorlib.Format_AttributeUsage", 0xA3450355, new FormatText("Duplicate AttributeUsageAttribute found on attribute type {0}.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_bad7bitint32 = new MessageDescription("mscorlib.Format_Bad7BitInt32", 0xA3450356, new ParameterlessText("Too many bytes in what should have been a 7 bit encoded Int32.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_badbase = new MessageDescription("mscorlib.Format_BadBase", 0xA3450357, new ParameterlessText("Invalid digits for the specified base.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_badbase64char = new MessageDescription("mscorlib.Format_BadBase64Char", 0xA3450358, new ParameterlessText("The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_badbase64chararraylength = new MessageDescription("mscorlib.Format_BadBase64CharArrayLength", 0xA3450359, new ParameterlessText("Invalid length for a Base-64 char array or string.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_badboolean = new MessageDescription("mscorlib.Format_BadBoolean", 0xA345035A, new ParameterlessText("String was not recognized as a valid Boolean.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_badformatspecifier = new MessageDescription("mscorlib.Format_BadFormatSpecifier", 0xA345035B, new ParameterlessText("Format specifier was invalid.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_badquote = new MessageDescription("mscorlib.Format_BadQuote", 0xA345035C, new FormatText("Cannot find a matching quote character for the character '{0}'.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidinvalidchar = new MessageDescription("mscorlib.Format_GuidInvalidChar", 0xA345035D, new ParameterlessText("Guid string should only contain hexadecimal characters.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidunrecognized = new MessageDescription("mscorlib.Format_GuidUnrecognized", 0xA345035E, new ParameterlessText("Unrecognized Guid format.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_indexoutofrange = new MessageDescription("mscorlib.Format_IndexOutOfRange", 0xA345035F, new ParameterlessText("Index (zero based) must be greater than or equal to zero and less than the size of the argument list.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_invalidenumformatspecification = new MessageDescription("mscorlib.Format_InvalidEnumFormatSpecification", 0xA3450360, new ParameterlessText("Format String can be only \"G\", \"g\", \"X\", \"x\", \"F\", \"f\", \"D\" or \"d\".")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_invalidguidformatspecification = new MessageDescription("mscorlib.Format_InvalidGuidFormatSpecification", 0xA3450361, new ParameterlessText("Format String can be only \"D\", \"d\", \"N\", \"n\", \"P\", \"p\", \"B\", \"b\", \"X\" or \"x\".")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_invalidstring = new MessageDescription("mscorlib.Format_InvalidString", 0xA3450362, new ParameterlessText("Input string was not in a correct format.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_needsinglechar = new MessageDescription("mscorlib.Format_NeedSingleChar", 0xA3450363, new ParameterlessText("String must be exactly one character long.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_stringzerolength = new MessageDescription("mscorlib.Format_StringZeroLength", 0xA3450364, new ParameterlessText("String cannot have zero length.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_baddatepattern = new MessageDescription("mscorlib.Format_BadDatePattern", 0xA34506B4, new FormatText("Could not determine the order of year, month, and date from '{0}'.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_baddatetime = new MessageDescription("mscorlib.Format_BadDateTime", 0xA34506B0, new ParameterlessText("String was not recognized as a valid DateTime.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_baddatetimecalendar = new MessageDescription("mscorlib.Format_BadDateTimeCalendar", 0xA34506B1, new FormatText("The DateTime represented by the string is not supported in calendar {0}.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_baddayofweek = new MessageDescription("mscorlib.Format_BadDayOfWeek", 0xA34506B2, new ParameterlessText("String was not recognized as a valid DateTime because the day of week was incorrect.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_badtimespan = new MessageDescription("mscorlib.Format_BadTimeSpan", 0xA34506B5, new ParameterlessText("String was not recognized as a valid TimeSpan.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_dateoutofrange = new MessageDescription("mscorlib.Format_DateOutOfRange", 0xA34506B3, new ParameterlessText("The DateTime represented by the string is out of range.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_emptyinputstring = new MessageDescription("mscorlib.Format_EmptyInputString", 0xA34506B6, new ParameterlessText("Input string was either empty or contained only whitespace.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_extrajunkatend = new MessageDescription("mscorlib.Format_ExtraJunkAtEnd", 0xA34506B7, new ParameterlessText("Additional non-parsable characters are at the end of the string.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidbrace = new MessageDescription("mscorlib.Format_GuidBrace", 0xA34506B8, new ParameterlessText("Expected {0xdddddddd, etc}.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidbraceafterlastnumber = new MessageDescription("mscorlib.Format_GuidBraceAfterLastNumber", 0xA34506BA, new ParameterlessText("Could not find a brace, or the length between the previous token and the brace was zero (i.e., '0x,'etc.).")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidcomma = new MessageDescription("mscorlib.Format_GuidComma", 0xA34506B9, new ParameterlessText("Could not find a comma, or the length between the previous token and the comma was zero (i.e., '0x,'etc.).")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guiddashes = new MessageDescription("mscorlib.Format_GuidDashes", 0xA34506BB, new ParameterlessText("Dashes are in the wrong position for GUID parsing.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidendbrace = new MessageDescription("mscorlib.Format_GuidEndBrace", 0xA34506BC, new ParameterlessText("Could not find the ending brace.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidhexprefix = new MessageDescription("mscorlib.Format_GuidHexPrefix", 0xA34506BD, new FormatText("Expected hex 0x in '{0}'.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_guidinvlen = new MessageDescription("mscorlib.Format_GuidInvLen", 0xA34506BE, new ParameterlessText("Guid should contain 32 digits with 4 dashes (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_missingincompletedate = new MessageDescription("mscorlib.Format_MissingIncompleteDate", 0xA34506C5, new ParameterlessText("There must be at least a partial date with a year present in the input.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_noparsibledigits = new MessageDescription("mscorlib.Format_NoParsibleDigits", 0xA34506C0, new ParameterlessText("Could not find any recognizable digits.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_offsetoutofrange = new MessageDescription("mscorlib.Format_OffsetOutOfRange", 0xA34506C4, new ParameterlessText("The time zone offset must be within plus or minus 14 hours.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_repeatdatetimepattern = new MessageDescription("mscorlib.Format_RepeatDateTimePattern", 0xA34506C1, new FormatText("DateTime pattern '{0}' appears more than once with different values.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_twotimezonespecifiers = new MessageDescription("mscorlib.Format_TwoTimeZoneSpecifiers", 0xA34506C2, new ParameterlessText("The String being parsed cannot contain two TimeZone specifiers.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_utcoutofrange = new MessageDescription("mscorlib.Format_UTCOutOfRange", 0xA34506C3, new ParameterlessText("The UTC representation of the date falls outside the year range 1-9999.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        Add(_unknowdatetimeword = new MessageDescription("mscorlib.Format_UnknowDateTimeWord", 0xA34506BF, new FormatText("The string was not recognized as a valid DateTime. There is an unknown word starting at index {0}.")).SetHResult(0x80131537).SetSeverity(MessageLevel.Error).SetException(typeof(System.FormatException)));
        return this;
    }    

}
