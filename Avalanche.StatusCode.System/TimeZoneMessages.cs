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

/// <summary>TimeZone</summary>
public class TimeZoneMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<TimeZoneMessages> instance = new Lazy<TimeZoneMessages>(() => new TimeZoneMessages().Initialize().SetAllReadOnly<TimeZoneMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static TimeZoneMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0005;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _invalidregistrydata, _timezonenotfoundmissingregistrydata, _timezoneinfobadtzif, _timezoneinfoinvalidtzif, _invalidwin32apidata;
    
    /// <summary>The time zone ID &#39;{0}&#39; was found on the local computer, but the registry information was corrupt.</summary>
    public IMessageDescription InvalidRegistryData { get => _invalidregistrydata!; set => this.AssertWritable()._invalidregistrydata = value; }
    /// <summary>The time zone ID &#39;{0}&#39; was not found on the local computer.</summary>
    public IMessageDescription TimeZoneNotFoundMissingRegistryData { get => _timezonenotfoundmissingregistrydata!; set => this.AssertWritable()._timezonenotfoundmissingregistrydata = value; }
    /// <summary>The tzfile does not begin with the magic characters &#39;TZif&#39;. Please verify that the file is not corrupt.</summary>
    public IMessageDescription TimeZoneInfoBadTZif { get => _timezoneinfobadtzif!; set => this.AssertWritable()._timezoneinfobadtzif = value; }
    /// <summary>The TZif data structure is corrupt.</summary>
    public IMessageDescription TimeZoneInfoInvalidTZif { get => _timezoneinfoinvalidtzif!; set => this.AssertWritable()._timezoneinfoinvalidtzif = value; }
    /// <summary>The Local time zone was found on the local computer, but the data was corrupt.</summary>
    public IMessageDescription InvalidWin32APIData { get => _invalidwin32apidata!; set => this.AssertWritable()._invalidwin32apidata = value; }

    /// <summary>Initialize fields</summary>
    public override TimeZoneMessages Initialize() 
    {
        base.Initialize();
        Add(_invalidregistrydata = new MessageDescription("mscorlib.InvalidTimeZone_InvalidRegistryData", 0xA3450409, new FormatText("The time zone ID '{0}' was found on the local computer, but the registry information was corrupt.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidTimeZoneException)));
        Add(_timezonenotfoundmissingregistrydata = new MessageDescription("mscorlib.TimeZoneNotFound_MissingRegistryData", 0xA34505FD, new FormatText("The time zone ID '{0}' was not found on the local computer.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.TimeZoneNotFoundException)));
        Add(_timezoneinfobadtzif = new MessageDescription("mscorlib.Argument_TimeZoneInfoBadTZif", 0xA345078F, new ParameterlessText("The tzfile does not begin with the magic characters 'TZif'.  Please verify that the file is not corrupt.")).SetSeverity(MessageLevel.Error));
        Add(_timezoneinfoinvalidtzif = new MessageDescription("mscorlib.Argument_TimeZoneInfoInvalidTZif", 0xA3450790, new ParameterlessText("The TZif data structure is corrupt.")).SetSeverity(MessageLevel.Error));
        Add(_invalidwin32apidata = new MessageDescription("mscorlib.InvalidTimeZone_InvalidWin32APIData", 0xA345061C, new ParameterlessText("The Local time zone was found on the local computer, but the data was corrupt.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidTimeZoneException)));
        return this;
    }    

}
