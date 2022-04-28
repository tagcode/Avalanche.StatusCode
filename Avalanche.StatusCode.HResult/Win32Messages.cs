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

/// <summary>Win32</summary>
public class Win32Messages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<Win32Messages> instance = new Lazy<Win32Messages>(() => new Win32Messages().Initialize().SetAllReadOnly<Win32Messages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static Win32Messages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000E;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _cor_e_argument, _cor_e_arithmetic, _cor_e_badexeformat, _cor_e_badimageformat, _cor_e_directorynotfound, _cor_e_endofstream, _cor_e_filenotfound, _cor_e_outofmemory, _cor_e_pathtoolong, _cor_e_stackoverflow;
    IMessageDescription? _cor_e_unauthorizedaccess, _e_handle, _error_mrm_map_not_found, _error_timeout;
    
    /// <summary>The parameter is incorrect.</summary>
    public IMessageDescription COR_E_ARGUMENT { get => _cor_e_argument!; set => this.AssertWritable()._cor_e_argument = value; }
    /// <summary>Arithmetic result exceeded 32 bits.</summary>
    public IMessageDescription COR_E_ARITHMETIC { get => _cor_e_arithmetic!; set => this.AssertWritable()._cor_e_arithmetic = value; }
    /// <summary>WIN32.COR_E_BADEXEFORMAT</summary>
    public IMessageDescription COR_E_BADEXEFORMAT { get => _cor_e_badexeformat!; set => this.AssertWritable()._cor_e_badexeformat = value; }
    /// <summary>An attempt was made to load a program with an incorrect format.</summary>
    public IMessageDescription COR_E_BADIMAGEFORMAT { get => _cor_e_badimageformat!; set => this.AssertWritable()._cor_e_badimageformat = value; }
    /// <summary>The system cannot find the path specified.</summary>
    public IMessageDescription COR_E_DIRECTORYNOTFOUND { get => _cor_e_directorynotfound!; set => this.AssertWritable()._cor_e_directorynotfound = value; }
    /// <summary>Reached the end of the file.</summary>
    public IMessageDescription COR_E_ENDOFSTREAM { get => _cor_e_endofstream!; set => this.AssertWritable()._cor_e_endofstream = value; }
    /// <summary>The system cannot find the file specified.</summary>
    public IMessageDescription COR_E_FILENOTFOUND { get => _cor_e_filenotfound!; set => this.AssertWritable()._cor_e_filenotfound = value; }
    /// <summary>Ran out of memory</summary>
    public IMessageDescription COR_E_OUTOFMEMORY { get => _cor_e_outofmemory!; set => this.AssertWritable()._cor_e_outofmemory = value; }
    /// <summary>The filename or extension is too long.</summary>
    public IMessageDescription COR_E_PATHTOOLONG { get => _cor_e_pathtoolong!; set => this.AssertWritable()._cor_e_pathtoolong = value; }
    /// <summary>Recursion too deep</summary>
    public IMessageDescription COR_E_STACKOVERFLOW { get => _cor_e_stackoverflow!; set => this.AssertWritable()._cor_e_stackoverflow = value; }
    /// <summary>Access is denied.</summary>
    public IMessageDescription COR_E_UNAUTHORIZEDACCESS { get => _cor_e_unauthorizedaccess!; set => this.AssertWritable()._cor_e_unauthorizedaccess = value; }
    /// <summary>WIN32.E_HANDLE</summary>
    public IMessageDescription E_HANDLE { get => _e_handle!; set => this.AssertWritable()._e_handle = value; }
    /// <summary>WIN32.ERROR_MRM_MAP_NOT_FOUND</summary>
    public IMessageDescription ERROR_MRM_MAP_NOT_FOUND { get => _error_mrm_map_not_found!; set => this.AssertWritable()._error_mrm_map_not_found = value; }
    /// <summary>WIN32.ERROR_TIMEOUT</summary>
    public IMessageDescription ERROR_TIMEOUT { get => _error_timeout!; set => this.AssertWritable()._error_timeout = value; }

    /// <summary>Initialize fields</summary>
    public override Win32Messages Initialize() 
    {
        base.Initialize();
        Add(_cor_e_argument = new MessageDescription("WIN32.COR_E_ARGUMENT", 0x80070057, new ParameterlessText("The parameter is incorrect.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cor_e_arithmetic = new MessageDescription("WIN32.COR_E_ARITHMETIC", 0x80070216, new ParameterlessText("Arithmetic result exceeded 32 bits.")).SetHResult(0x80070216).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArithmeticException)));
        Add(_cor_e_badexeformat = new MessageDescription("WIN32.COR_E_BADEXEFORMAT", 0x800700C1, new ParameterlessText("")).SetHResult(0x800700C1).SetSeverity(MessageLevel.Error));
        Add(_cor_e_badimageformat = new MessageDescription("WIN32.COR_E_BADIMAGEFORMAT", 0x8007000B, new ParameterlessText("An attempt was made to load a program with an incorrect format.")).SetHResult(0x8007000B).SetSeverity(MessageLevel.Error).SetException(typeof(System.BadImageFormatException)));
        Add(_cor_e_directorynotfound = new MessageDescription("WIN32.COR_E_DIRECTORYNOTFOUND", 0x80070003, new ParameterlessText("The system cannot find the path specified.")).SetHResult(0x80070003).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.DirectoryNotFoundException)));
        Add(_cor_e_endofstream = new MessageDescription("WIN32.COR_E_ENDOFSTREAM", 0x80070026, new ParameterlessText("Reached the end of the file.")).SetHResult(0x80070026).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.EndOfStreamException)));
        Add(_cor_e_filenotfound = new MessageDescription("WIN32.COR_E_FILENOTFOUND", 0x80070002, new ParameterlessText("The system cannot find the file specified.")).SetHResult(0x80070002).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.FileNotFoundException)));
        Add(_cor_e_outofmemory = new MessageDescription("WIN32.COR_E_OUTOFMEMORY", 0x8007000E, new ParameterlessText("Ran out of memory")).SetHResult(0x8007000E).SetSeverity(MessageLevel.Critical).SetException(typeof(System.OutOfMemoryException)));
        Add(_cor_e_pathtoolong = new MessageDescription("WIN32.COR_E_PATHTOOLONG", 0x800700CE, new ParameterlessText("The filename or extension is too long.")).SetHResult(0x800700CE).SetSeverity(MessageLevel.Error).SetException(typeof(System.IO.PathTooLongException)));
        Add(_cor_e_stackoverflow = new MessageDescription("WIN32.COR_E_STACKOVERFLOW", 0x800703E9, new ParameterlessText("Recursion too deep")).SetHResult(0x800703E9).SetSeverity(MessageLevel.Critical).SetException(typeof(StackOverflowException)));
        Add(_cor_e_unauthorizedaccess = new MessageDescription("WIN32.COR_E_UNAUTHORIZEDACCESS", 0x80070005, new ParameterlessText("Access is denied.")).SetHResult(0x80070005).SetSeverity(MessageLevel.Error).SetException(typeof(System.UnauthorizedAccessException)));
        Add(_e_handle = new MessageDescription("WIN32.E_HANDLE", 0x80070006, new ParameterlessText("")).SetHResult(0x80070006).SetSeverity(MessageLevel.Error));
        Add(_error_mrm_map_not_found = new MessageDescription("WIN32.ERROR_MRM_MAP_NOT_FOUND", 0x80073B1F, new ParameterlessText("")).SetHResult(0x80073B1F).SetSeverity(MessageLevel.Error));
        Add(_error_timeout = new MessageDescription("WIN32.ERROR_TIMEOUT", 0x800705B4, new ParameterlessText("")).SetHResult(0x800705B4).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
