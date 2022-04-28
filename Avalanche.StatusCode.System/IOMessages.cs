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

/// <summary>System.IO.*</summary>
public class IOMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<IOMessages> instance = new Lazy<IOMessages>(() => new IOMessages().Initialize().SetAllReadOnly<IOMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static IOMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0027;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _directorynotfoundexception, _drivenotfoundexception, _endofstreamexception, _ioexception, _filenotfoundresolveassembly, _indexoutofrangeioracecondition, _unknownfilename, _drivenotfounddrive, _eofreadbeyondeof, _fileload;
    IMessageDescription? _filenotfound, _filenotfoundfilename, _alreadyexistsname, _bindhandlefailed, _cannotcreatedirectory, _fileexistsname, _filestreamhandleposition, _filetoolong2gb, _filetoolongorhandlenotsync, _fixedcapacity;
    IMessageDescription? _invalidstringlenlen, _noconsole, _seekappendoverwrite, _seekbeforebegin, _setlengthappendtruncate, _sharingviolationfile, _sharingviolationnofilename, _sourcedestmustbedifferent, _sourcedestmusthavesameroot, _streamtoolong;
    IMessageDescription? _pathnotfoundnopathname, _pathnotfoundpath, _pathtoolong, _allocatedfrom, _operationnotpermitted, _filename, _nopermissiontodirectoryname, _streamwriterbuffereddatalost, _streamwriterbuffereddatalostcaptureallocatedfromcallstacknotenabled;
    
    /// <summary>System.IO</summary>
    public IMessageDescription DirectoryNotFoundException { get => _directorynotfoundexception!; set => this.AssertWritable()._directorynotfoundexception = value; }
    /// <summary>System.IO</summary>
    public IMessageDescription DriveNotFoundException { get => _drivenotfoundexception!; set => this.AssertWritable()._drivenotfoundexception = value; }
    /// <summary>System.IO</summary>
    public IMessageDescription EndOfStreamException { get => _endofstreamexception!; set => this.AssertWritable()._endofstreamexception = value; }
    /// <summary>System.IO</summary>
    public IMessageDescription IOException { get => _ioexception!; set => this.AssertWritable()._ioexception = value; }
    /// <summary>Could not resolve assembly &#39;{0}&#39;.</summary>
    public IMessageDescription FileNotFoundResolveAssembly { get => _filenotfoundresolveassembly!; set => this.AssertWritable()._filenotfoundresolveassembly = value; }
    /// <summary>Probable I/O race condition detected while copying memory. The I/O package is not thread safe by default. In multithreaded applications, a stream must be accessed in a thread-safe way, such as a thread-safe wrapper returned by TextReader&#39;s or TextWriter&#39;s Synchronized methods. This also applies to classes like StreamWriter and StreamReader.</summary>
    public IMessageDescription IndexOutOfRangeIORaceCondition { get => _indexoutofrangeioracecondition!; set => this.AssertWritable()._indexoutofrangeioracecondition = value; }
    /// <summary>System</summary>
    public IMessageDescription UnknownFileName { get => _unknownfilename!; set => this.AssertWritable()._unknownfilename = value; }
    /// <summary>Could not find the drive &#39;{0}&#39;. The drive might not be ready or might not be mapped.</summary>
    public IMessageDescription DriveNotFoundDrive { get => _drivenotfounddrive!; set => this.AssertWritable()._drivenotfounddrive = value; }
    /// <summary>Unable to read beyond the end of the stream.</summary>
    public IMessageDescription EOFReadBeyondEOF { get => _eofreadbeyondeof!; set => this.AssertWritable()._eofreadbeyondeof = value; }
    /// <summary>System.IO</summary>
    public IMessageDescription FileLoad { get => _fileload!; set => this.AssertWritable()._fileload = value; }
    /// <summary>System.IO</summary>
    public IMessageDescription FileNotFound { get => _filenotfound!; set => this.AssertWritable()._filenotfound = value; }
    /// <summary>Could not find file &#39;{0}&#39;.</summary>
    public IMessageDescription FileNotFoundFileName { get => _filenotfoundfilename!; set => this.AssertWritable()._filenotfoundfilename = value; }
    /// <summary>Cannot create &quot;{0}&quot; because a file or directory with the same name already exists.</summary>
    public IMessageDescription AlreadyExistsName { get => _alreadyexistsname!; set => this.AssertWritable()._alreadyexistsname = value; }
    /// <summary>BindHandle for ThreadPool failed on this handle.</summary>
    public IMessageDescription BindHandleFailed { get => _bindhandlefailed!; set => this.AssertWritable()._bindhandlefailed = value; }
    /// <summary>The specified directory &#39;{0}&#39; cannot be created.</summary>
    public IMessageDescription CannotCreateDirectory { get => _cannotcreatedirectory!; set => this.AssertWritable()._cannotcreatedirectory = value; }
    /// <summary>The file &#39;{0}&#39; already exists.</summary>
    public IMessageDescription FileExistsName { get => _fileexistsname!; set => this.AssertWritable()._fileexistsname = value; }
    /// <summary>The OS handle&#39;s position is not what FileStream expected. Do not use a handle simultaneously in one FileStream and in Win32 code or another FileStream. This may cause data loss.</summary>
    public IMessageDescription FileStreamHandlePosition { get => _filestreamhandleposition!; set => this.AssertWritable()._filestreamhandleposition = value; }
    /// <summary>The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size.</summary>
    public IMessageDescription FileTooLong2GB { get => _filetoolong2gb!; set => this.AssertWritable()._filetoolong2gb = value; }
    /// <summary>IO operation will not work. Most likely the file will become too long or the handle was not opened to support synchronous IO operations.</summary>
    public IMessageDescription FileTooLongOrHandleNotSync { get => _filetoolongorhandlenotsync!; set => this.AssertWritable()._filetoolongorhandlenotsync = value; }
    /// <summary>Unable to expand length of this stream beyond its capacity.</summary>
    public IMessageDescription FixedCapacity { get => _fixedcapacity!; set => this.AssertWritable()._fixedcapacity = value; }
    /// <summary>BinaryReader encountered an invalid string length of {0} characters.</summary>
    public IMessageDescription InvalidStringLenLen { get => _invalidstringlenlen!; set => this.AssertWritable()._invalidstringlenlen = value; }
    /// <summary>There is no console.</summary>
    public IMessageDescription NoConsole { get => _noconsole!; set => this.AssertWritable()._noconsole = value; }
    /// <summary>Unable seek backward to overwrite data that previously existed in a file opened in Append mode.</summary>
    public IMessageDescription SeekAppendOverwrite { get => _seekappendoverwrite!; set => this.AssertWritable()._seekappendoverwrite = value; }
    /// <summary>An attempt was made to move the position before the beginning of the stream.</summary>
    public IMessageDescription SeekBeforeBegin { get => _seekbeforebegin!; set => this.AssertWritable()._seekbeforebegin = value; }
    /// <summary>Unable to truncate data that previously existed in a file opened in Append mode.</summary>
    public IMessageDescription SetLengthAppendTruncate { get => _setlengthappendtruncate!; set => this.AssertWritable()._setlengthappendtruncate = value; }
    /// <summary>The process cannot access the file &#39;{0}&#39; because it is being used by another process.</summary>
    public IMessageDescription SharingViolationFile { get => _sharingviolationfile!; set => this.AssertWritable()._sharingviolationfile = value; }
    /// <summary>The process cannot access the file because it is being used by another process.</summary>
    public IMessageDescription SharingViolationNoFileName { get => _sharingviolationnofilename!; set => this.AssertWritable()._sharingviolationnofilename = value; }
    /// <summary>Source and destination path must be different.</summary>
    public IMessageDescription SourceDestMustBeDifferent { get => _sourcedestmustbedifferent!; set => this.AssertWritable()._sourcedestmustbedifferent = value; }
    /// <summary>Source and destination path must have identical roots. Move will not work across volumes.</summary>
    public IMessageDescription SourceDestMustHaveSameRoot { get => _sourcedestmusthavesameroot!; set => this.AssertWritable()._sourcedestmusthavesameroot = value; }
    /// <summary>Stream was too long.</summary>
    public IMessageDescription StreamTooLong { get => _streamtoolong!; set => this.AssertWritable()._streamtoolong = value; }
    /// <summary>Could not find a part of the path.</summary>
    public IMessageDescription PathNotFoundNoPathName { get => _pathnotfoundnopathname!; set => this.AssertWritable()._pathnotfoundnopathname = value; }
    /// <summary>Could not find a part of the path &#39;{0}&#39;.</summary>
    public IMessageDescription PathNotFoundPath { get => _pathnotfoundpath!; set => this.AssertWritable()._pathnotfoundpath = value; }
    /// <summary>System.IO</summary>
    public IMessageDescription PathTooLong { get => _pathtoolong!; set => this.AssertWritable()._pathtoolong = value; }
    /// <summary>Allocated from:</summary>
    public IMessageDescription AllocatedFrom { get => _allocatedfrom!; set => this.AssertWritable()._allocatedfrom = value; }
    /// <summary>File operation not permitted. Access to path &#39;{0}&#39; is denied.</summary>
    public IMessageDescription OperationNotPermitted { get => _operationnotpermitted!; set => this.AssertWritable()._operationnotpermitted = value; }
    /// <summary>File name: &#39;{0}&#39;</summary>
    public IMessageDescription FileName { get => _filename!; set => this.AssertWritable()._filename = value; }
    /// <summary>&lt;Path discovery permission to the specified directory was denied.&gt;</summary>
    public IMessageDescription NoPermissionToDirectoryName { get => _nopermissiontodirectoryname!; set => this.AssertWritable()._nopermissiontodirectoryname = value; }
    /// <summary>A StreamWriter was not closed and all buffered data within that StreamWriter was not flushed to the underlying stream. (This was detected when the StreamWriter was finalized with data in its buffer.) A portion of the data was lost. Consider one of calling Close(), Flush(), setting the StreamWriter&#39;s AutoFlush property to true, or allocating the StreamWriter with a &quot;using&quot; statement. Stream type: {0} File name: {1} Allocated from: {2}</summary>
    public IMessageDescription StreamWriterBufferedDataLost { get => _streamwriterbuffereddatalost!; set => this.AssertWritable()._streamwriterbuffereddatalost = value; }
    /// <summary>callstack information is not captured by default for performance reasons. Please enable captureAllocatedCallStack config switch for streamWriterBufferedDataLost MDA (refer to MSDN MDA documentation for how to do this).</summary>
    public IMessageDescription StreamWriterBufferedDataLostCaptureAllocatedFromCallstackNotEnabled { get => _streamwriterbuffereddatalostcaptureallocatedfromcallstacknotenabled!; set => this.AssertWritable()._streamwriterbuffereddatalostcaptureallocatedfromcallstacknotenabled = value; }

    /// <summary>Initialize fields</summary>
    public override IOMessages Initialize() 
    {
        base.Initialize();
        Add(_directorynotfoundexception = new MessageDescription("mscorlib.Arg_DirectoryNotFoundException", 0xA3450042, new ParameterlessText("Attempted to access a path that is not on the disk.")).SetHResult(0x80030003).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.DirectoryNotFoundException)));
        Add(_drivenotfoundexception = new MessageDescription("mscorlib.Arg_DriveNotFoundException", 0xA3450049, new ParameterlessText("Attempted to access a drive that is not available.")).SetHResult(0x80070003).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.DriveNotFoundException)));
        Add(_endofstreamexception = new MessageDescription("mscorlib.Arg_EndOfStreamException", 0xA3450051, new ParameterlessText("Attempted to read past the end of the stream.")).SetHResult(0x80070026).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.EndOfStreamException)));
        Add(_ioexception = new MessageDescription("mscorlib.Arg_IOException", 0xA3450085, new ParameterlessText("I/O error occurred.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.IOException)));
        Add(_filenotfoundresolveassembly = new MessageDescription("mscorlib.FileNotFound_ResolveAssembly", 0xA3450354, new FormatText("Could not resolve assembly '{0}'.")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_indexoutofrangeioracecondition = new MessageDescription("mscorlib.IndexOutOfRange_IORaceCondition", 0xA3450371, new ParameterlessText("Probable I/O race condition detected while copying memory. The I/O package is not thread safe by default. In multithreaded applications, a stream must be accessed in a thread-safe way, such as a thread-safe wrapper returned by TextReader's or TextWriter's Synchronized methods. This also applies to classes like StreamWriter and StreamReader.")).SetHResult(0x80131508).SetException(typeof(System.IndexOutOfRangeException)));
        Add(_unknownfilename = new MessageDescription("mscorlib.IO_UnknownFileName", 0xA345040A, new ParameterlessText("[Unknown]")).SetHResult(0x80131522).SetSeverity(MessageLevel.Error).SetDescription("System").SetException(typeof(System.TypeLoadException)));
        Add(_drivenotfounddrive = new MessageDescription("mscorlib.IO.DriveNotFound_Drive", 0xA345040B, new FormatText("Could not find the drive '{0}'. The drive might not be ready or might not be mapped.")).SetHResult(0x80070003).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.DriveNotFoundException)));
        Add(_eofreadbeyondeof = new MessageDescription("mscorlib.IO.EOF_ReadBeyondEOF", 0xA345040C, new ParameterlessText("Unable to read beyond the end of the stream.")).SetHResult(0x80070026).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.EndOfStreamException)));
        Add(_fileload = new MessageDescription("mscorlib.IO.FileLoad", 0xA345040D, new ParameterlessText("Could not load the specified file.")).SetHResult(0x80131621).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.FileLoadException)));
        Add(_filenotfound = new MessageDescription("mscorlib.IO.FileNotFound", 0xA345040E, new ParameterlessText("Unable to find the specified file.")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.FileNotFoundException)));
        Add(_filenotfoundfilename = new MessageDescription("mscorlib.IO.FileNotFound_FileName", 0xA345040F, new FormatText("Could not find file '{0}'.")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_alreadyexistsname = new MessageDescription("mscorlib.IO.IO_AlreadyExists_Name", 0xA3450410, new FormatText("Cannot create \"{0}\" because a file or directory with the same name already exists.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_bindhandlefailed = new MessageDescription("mscorlib.IO.IO_BindHandleFailed", 0xA3450411, new ParameterlessText("BindHandle for ThreadPool failed on this handle.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_cannotcreatedirectory = new MessageDescription("mscorlib.IO.IO_CannotCreateDirectory", 0xA3450412, new FormatText("The specified directory '{0}' cannot be created.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_fileexistsname = new MessageDescription("mscorlib.IO.IO_FileExists_Name", 0xA3450413, new FormatText("The file '{0}' already exists.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_filestreamhandleposition = new MessageDescription("mscorlib.IO.IO_FileStreamHandlePosition", 0xA3450414, new ParameterlessText("The OS handle's position is not what FileStream expected. Do not use a handle simultaneously in one FileStream and in Win32 code or another FileStream. This may cause data loss.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_filetoolong2gb = new MessageDescription("mscorlib.IO.IO_FileTooLong2GB", 0xA3450415, new ParameterlessText("The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_filetoolongorhandlenotsync = new MessageDescription("mscorlib.IO.IO_FileTooLongOrHandleNotSync", 0xA3450416, new ParameterlessText("IO operation will not work. Most likely the file will become too long or the handle was not opened to support synchronous IO operations.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_fixedcapacity = new MessageDescription("mscorlib.IO.IO_FixedCapacity", 0xA3450417, new ParameterlessText("Unable to expand length of this stream beyond its capacity.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_invalidstringlenlen = new MessageDescription("mscorlib.IO.IO_InvalidStringLen_Len", 0xA3450418, new FormatText("BinaryReader encountered an invalid string length of {0} characters.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_noconsole = new MessageDescription("mscorlib.IO.IO_NoConsole", 0xA3450419, new ParameterlessText("There is no console.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_seekappendoverwrite = new MessageDescription("mscorlib.IO.IO_SeekAppendOverwrite", 0xA345041A, new ParameterlessText("Unable seek backward to overwrite data that previously existed in a file opened in Append mode.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_seekbeforebegin = new MessageDescription("mscorlib.IO.IO_SeekBeforeBegin", 0xA345041B, new ParameterlessText("An attempt was made to move the position before the beginning of the stream.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_setlengthappendtruncate = new MessageDescription("mscorlib.IO.IO_SetLengthAppendTruncate", 0xA345041C, new ParameterlessText("Unable to truncate data that previously existed in a file opened in Append mode.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_sharingviolationfile = new MessageDescription("mscorlib.IO.IO_SharingViolation_File", 0xA345041D, new FormatText("The process cannot access the file '{0}' because it is being used by another process.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_sharingviolationnofilename = new MessageDescription("mscorlib.IO.IO_SharingViolation_NoFileName", 0xA345041E, new ParameterlessText("The process cannot access the file because it is being used by another process.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_sourcedestmustbedifferent = new MessageDescription("mscorlib.IO.IO_SourceDestMustBeDifferent", 0xA345041F, new ParameterlessText("Source and destination path must be different.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_sourcedestmusthavesameroot = new MessageDescription("mscorlib.IO.IO_SourceDestMustHaveSameRoot", 0xA3450420, new ParameterlessText("Source and destination path must have identical roots. Move will not work across volumes.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_streamtoolong = new MessageDescription("mscorlib.IO.IO_StreamTooLong", 0xA3450421, new ParameterlessText("Stream was too long.")).SetHResult(0x80131620).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.IOException)));
        Add(_pathnotfoundnopathname = new MessageDescription("mscorlib.IO.PathNotFound_NoPathName", 0xA3450422, new ParameterlessText("Could not find a part of the path.")).SetHResult(0x80030003).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.DirectoryNotFoundException)));
        Add(_pathnotfoundpath = new MessageDescription("mscorlib.IO.PathNotFound_Path", 0xA3450423, new FormatText("Could not find a part of the path '{0}'.")).SetHResult(0x80030003).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.DirectoryNotFoundException)));
        Add(_pathtoolong = new MessageDescription("mscorlib.IO.PathTooLong", 0xA3450424, new ParameterlessText("The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.")).SetHResult(0x800700CE).SetSeverity(MessageLevel.Error).SetDescription("System.IO").SetException(typeof(System.IO.PathTooLongException)));
        Add(_allocatedfrom = new MessageDescription("mscorlib.AllocatedFrom", 0xA345061B, new ParameterlessText("Allocated from:")).SetHResult(0x80131620).SetException(typeof(System.IO.IOException)));
        Add(_operationnotpermitted = new MessageDescription("mscorlib.FileSecurityState_OperationNotPermitted", 0xA345074E, new FormatText("File operation not permitted. Access to path '{0}' is denied.")).SetSeverity(MessageLevel.Error));
        Add(_filename = new MessageDescription("mscorlib.IO.FileName_Name", 0xA3450628, new FormatText("File name: '{0}'")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_nopermissiontodirectoryname = new MessageDescription("mscorlib.IO.IO_NoPermissionToDirectoryName", 0xA345074D, new ParameterlessText("<Path discovery permission to the specified directory was denied.>")).SetSeverity(MessageLevel.Error));
        Add(_streamwriterbuffereddatalost = new MessageDescription("mscorlib.IO_StreamWriterBufferedDataLost", 0xA345074F, new FormatText("A StreamWriter was not closed and all buffered data within that StreamWriter was not flushed to the underlying stream.  (This was detected when the StreamWriter was finalized with data in its buffer.)  A portion of the data was lost.  Consider one of calling Close(), Flush(), setting the StreamWriter's AutoFlush property to true, or allocating the StreamWriter with a \"using\" statement.  Stream type: {0}\r\nFile name: {1}\r\nAllocated from:\r\n {2}")).SetSeverity(MessageLevel.Error));
        Add(_streamwriterbuffereddatalostcaptureallocatedfromcallstacknotenabled = new MessageDescription("mscorlib.IO_StreamWriterBufferedDataLostCaptureAllocatedFromCallstackNotEnabled", 0xA3450750, new ParameterlessText("callstack information is not captured by default for performance reasons. Please enable captureAllocatedCallStack config switch for streamWriterBufferedDataLost MDA (refer to MSDN MDA documentation for how to do this).")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
