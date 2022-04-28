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

/// <summary>System.BadImageFormatException</summary>
public class BadImageFormatMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<BadImageFormatMessages> instance = new Lazy<BadImageFormatMessages>(() => new BadImageFormatMessages().Initialize().SetAllReadOnly<BadImageFormatMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static BadImageFormatMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000F;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _invalidtype, _negativestringlength, _parametersignaturemismatch, _resourcedatalengthinvalid, _resourcenamecorrupted, _resourcenamecorruptednameindex, _resourcesdatainvalidoffset, _resourcesheadercorrupted, _resourcesindextoolong, _resourcesnameinvalidoffset;
    IMessageDescription? _resourcesnametoolong, _restypeserblobmismatch, _typemismatch, _resourcesindexinvalid, _streampositioninvalid;
    
    /// <summary>Corrupt .resources file. The specified type doesn&#39;t exist.</summary>
    public IMessageDescription InvalidType { get => _invalidtype!; set => this.AssertWritable()._invalidtype = value; }
    /// <summary>Corrupt .resources file. String length must be non-negative.</summary>
    public IMessageDescription NegativeStringLength { get => _negativestringlength!; set => this.AssertWritable()._negativestringlength = value; }
    /// <summary>The parameters and the signature of the method don&#39;t match.</summary>
    public IMessageDescription ParameterSignatureMismatch { get => _parametersignaturemismatch!; set => this.AssertWritable()._parametersignaturemismatch = value; }
    /// <summary>Corrupt .resources file. The specified data length &#39;{0}&#39; is not a valid position in the stream.</summary>
    public IMessageDescription ResourceDataLengthInvalid { get => _resourcedatalengthinvalid!; set => this.AssertWritable()._resourcedatalengthinvalid = value; }
    /// <summary>Corrupt .resources file. A resource name extends past the end of the stream.</summary>
    public IMessageDescription ResourceNameCorrupted { get => _resourcenamecorrupted!; set => this.AssertWritable()._resourcenamecorrupted = value; }
    /// <summary>Corrupt .resources file. The resource name for name index {0} extends past the end of the stream.</summary>
    public IMessageDescription ResourceNameCorruptedNameIndex { get => _resourcenamecorruptednameindex!; set => this.AssertWritable()._resourcenamecorruptednameindex = value; }
    /// <summary>Corrupt .resources file. Invalid offset &#39;{0}&#39; into data section.</summary>
    public IMessageDescription ResourcesDataInvalidOffset { get => _resourcesdatainvalidoffset!; set => this.AssertWritable()._resourcesdatainvalidoffset = value; }
    /// <summary>Corrupt .resources file. Unable to read resources from this file because of invalid header information. Try regenerating the .resources file.</summary>
    public IMessageDescription ResourcesHeaderCorrupted { get => _resourcesheadercorrupted!; set => this.AssertWritable()._resourcesheadercorrupted = value; }
    /// <summary>Corrupt .resources file. String for name index &#39;{0}&#39; extends past the end of the file.</summary>
    public IMessageDescription ResourcesIndexTooLong { get => _resourcesindextoolong!; set => this.AssertWritable()._resourcesindextoolong = value; }
    /// <summary>Corrupt .resources file. Invalid offset &#39;{0}&#39; into name section.</summary>
    public IMessageDescription ResourcesNameInvalidOffset { get => _resourcesnameinvalidoffset!; set => this.AssertWritable()._resourcesnameinvalidoffset = value; }
    /// <summary>Corrupt .resources file. Resource name extends past the end of the file.</summary>
    public IMessageDescription ResourcesNameTooLong { get => _resourcesnametoolong!; set => this.AssertWritable()._resourcesnametoolong = value; }
    /// <summary>The type serialized in the .resources file was not the same type that the .resources file said it contained. Expected &#39;{0}&#39; but read &#39;{1}&#39;.</summary>
    public IMessageDescription ResTypeSerBlobMismatch { get => _restypeserblobmismatch!; set => this.AssertWritable()._restypeserblobmismatch = value; }
    /// <summary>Corrupt .resources file. The specified type doesn&#39;t match the available data in the stream.</summary>
    public IMessageDescription TypeMismatch { get => _typemismatch!; set => this.AssertWritable()._typemismatch = value; }
    /// <summary>Corrupt .resources file. The resource index &#39;{0}&#39; is outside the valid range.</summary>
    public IMessageDescription ResourcesIndexInvalid { get => _resourcesindexinvalid!; set => this.AssertWritable()._resourcesindexinvalid = value; }
    /// <summary>Corrupt .resources file. The specified position &#39;{0}&#39; is not a valid position in the stream.</summary>
    public IMessageDescription StreamPositionInvalid { get => _streampositioninvalid!; set => this.AssertWritable()._streampositioninvalid = value; }

    /// <summary>Initialize fields</summary>
    public override BadImageFormatMessages Initialize() 
    {
        base.Initialize();
        Add(_invalidtype = new MessageDescription("mscorlib.BadImageFormat_InvalidType", 0xA34502DC, new ParameterlessText("Corrupt .resources file.  The specified type doesn't exist.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_negativestringlength = new MessageDescription("mscorlib.BadImageFormat_NegativeStringLength", 0xA34502DD, new ParameterlessText("Corrupt .resources file. String length must be non-negative.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_parametersignaturemismatch = new MessageDescription("mscorlib.BadImageFormat_ParameterSignatureMismatch", 0xA34502DE, new ParameterlessText("The parameters and the signature of the method don't match.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcedatalengthinvalid = new MessageDescription("mscorlib.BadImageFormat_ResourceDataLengthInvalid", 0xA34502DF, new FormatText("Corrupt .resources file.  The specified data length '{0}' is not a valid position in the stream.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcenamecorrupted = new MessageDescription("mscorlib.BadImageFormat_ResourceNameCorrupted", 0xA34502E0, new ParameterlessText("Corrupt .resources file. A resource name extends past the end of the stream.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcenamecorruptednameindex = new MessageDescription("mscorlib.BadImageFormat_ResourceNameCorrupted_NameIndex", 0xA34502E1, new FormatText("Corrupt .resources file. The resource name for name index {0} extends past the end of the stream.")).SetHResult(0x80070026).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.EndOfStreamException)));
        Add(_resourcesdatainvalidoffset = new MessageDescription("mscorlib.BadImageFormat_ResourcesDataInvalidOffset", 0xA34502E2, new FormatText("Corrupt .resources file. Invalid offset '{0}' into data section.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcesheadercorrupted = new MessageDescription("mscorlib.BadImageFormat_ResourcesHeaderCorrupted", 0xA34502E3, new ParameterlessText("Corrupt .resources file. Unable to read resources from this file because of invalid header information. Try regenerating the .resources file.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcesindextoolong = new MessageDescription("mscorlib.BadImageFormat_ResourcesIndexTooLong", 0xA34502E4, new FormatText("Corrupt .resources file. String for name index '{0}' extends past the end of the file.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcesnameinvalidoffset = new MessageDescription("mscorlib.BadImageFormat_ResourcesNameInvalidOffset", 0xA34502E5, new FormatText("Corrupt .resources file. Invalid offset '{0}' into name section.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcesnametoolong = new MessageDescription("mscorlib.BadImageFormat_ResourcesNameTooLong", 0xA34502E6, new ParameterlessText("Corrupt .resources file. Resource name extends past the end of the file.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_restypeserblobmismatch = new MessageDescription("mscorlib.BadImageFormat_ResType&SerBlobMismatch", 0xA34502E7, new FormatText("The type serialized in the .resources file was not the same type that the .resources file said it contained. Expected '{0}' but read '{1}'.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_typemismatch = new MessageDescription("mscorlib.BadImageFormat_TypeMismatch", 0xA34502E8, new ParameterlessText("Corrupt .resources file.  The specified type doesn't match the available data in the stream.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_resourcesindexinvalid = new MessageDescription("mscorlib.BadImageFormat_ResourcesIndexInvalid", 0xA3450684, new FormatText("Corrupt .resources file. The resource index '{0}' is outside the valid range.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_streampositioninvalid = new MessageDescription("mscorlib.BadImageFormat_StreamPositionInvalid", 0xA3450685, new FormatText("Corrupt .resources file.  The specified position '{0}' is not a valid position in the stream.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        return this;
    }    

}
