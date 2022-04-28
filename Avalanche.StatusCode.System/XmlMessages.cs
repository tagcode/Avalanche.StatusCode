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

/// <summary>System.Xml.*</summary>
public class XmlMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<XmlMessages> instance = new Lazy<XmlMessages>(() => new XmlMessages().Initialize().SetAllReadOnly<XmlMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static XmlMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000B;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _syntaxinvalidsyntaxinfile, _expectedclosebracket, _expectedslashorstring, _invalidsyntax, _invalidsyntaxsatassemtag, _invalidsyntaxsatassemtagbadattr, _invalidsyntaxsatassemtagnoattr, _syntaxerror, _syntaxerrorex, _unexpectedclosebracket;
    IMessageDescription? _unexpectedendoffile;
    
    /// <summary>Invalid XML in file &#39;{0}&#39; near element &#39;{1}&#39;.</summary>
    public IMessageDescription SyntaxInvalidSyntaxInFile { get => _syntaxinvalidsyntaxinfile!; set => this.AssertWritable()._syntaxinvalidsyntaxinfile = value; }
    /// <summary>Expected &gt; character.</summary>
    public IMessageDescription ExpectedCloseBracket { get => _expectedclosebracket!; set => this.AssertWritable()._expectedclosebracket = value; }
    /// <summary>Expected / character or string.</summary>
    public IMessageDescription ExpectedSlashOrString { get => _expectedslashorstring!; set => this.AssertWritable()._expectedslashorstring = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription InvalidSyntax { get => _invalidsyntax!; set => this.AssertWritable()._invalidsyntax = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription InvalidSyntaxSatAssemTag { get => _invalidsyntaxsatassemtag!; set => this.AssertWritable()._invalidsyntaxsatassemtag = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription InvalidSyntaxSatAssemTagBadAttr { get => _invalidsyntaxsatassemtagbadattr!; set => this.AssertWritable()._invalidsyntaxsatassemtagbadattr = value; }
    /// <summary>System.Resources</summary>
    public IMessageDescription InvalidSyntaxSatAssemTagNoAttr { get => _invalidsyntaxsatassemtagnoattr!; set => this.AssertWritable()._invalidsyntaxsatassemtagnoattr = value; }
    /// <summary>System.Security</summary>
    public IMessageDescription SyntaxError { get => _syntaxerror!; set => this.AssertWritable()._syntaxerror = value; }
    /// <summary>System.Security</summary>
    public IMessageDescription SyntaxErrorEx { get => _syntaxerrorex!; set => this.AssertWritable()._syntaxerrorex = value; }
    /// <summary>Unexpected &gt; character.</summary>
    public IMessageDescription UnexpectedCloseBracket { get => _unexpectedclosebracket!; set => this.AssertWritable()._unexpectedclosebracket = value; }
    /// <summary>Unexpected end of file.</summary>
    public IMessageDescription UnexpectedEndOfFile { get => _unexpectedendoffile!; set => this.AssertWritable()._unexpectedendoffile = value; }

    /// <summary>Initialize fields</summary>
    public override XmlMessages Initialize() 
    {
        base.Initialize();
        Add(_syntaxinvalidsyntaxinfile = new MessageDescription("mscorlib.XML_Syntax_InvalidSyntaxInFile", 0xA345060D, new FormatText("Invalid XML in file '{0}' near element '{1}'.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetException("System.Security.XmlSyntaxException"));
        Add(_expectedclosebracket = new MessageDescription("mscorlib.XMLSyntax_ExpectedCloseBracket", 0xA345060E, new ParameterlessText("Expected > character.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetException("System.Security.XmlSyntaxException"));
        Add(_expectedslashorstring = new MessageDescription("mscorlib.XMLSyntax_ExpectedSlashOrString", 0xA345060F, new ParameterlessText("Expected / character or string.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetException("System.Security.XmlSyntaxException"));
        Add(_invalidsyntax = new MessageDescription("mscorlib.XMLSyntax_InvalidSyntax", 0xA3450610, new ParameterlessText("Invalid syntax.")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ApplicationException)));
        Add(_invalidsyntaxsatassemtag = new MessageDescription("mscorlib.XMLSyntax_InvalidSyntaxSatAssemTag", 0xA3450611, new FormatText("Invalid XML in file \"{0}\" near element \"{1}\". The <satelliteassemblies> section only supports <assembly> tags.")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ApplicationException)));
        Add(_invalidsyntaxsatassemtagbadattr = new MessageDescription("mscorlib.XMLSyntax_InvalidSyntaxSatAssemTagBadAttr", 0xA3450612, new FormatText("Invalid XML in file \"{0}\" near \"{1}\" and \"{2}\". In the <satelliteassemblies> section, the <assembly> tag must have exactly 1 attribute called 'name', whose value is a fully-qualified assembly name.")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ApplicationException)));
        Add(_invalidsyntaxsatassemtagnoattr = new MessageDescription("mscorlib.XMLSyntax_InvalidSyntaxSatAssemTagNoAttr", 0xA3450613, new FormatText("Invalid XML in file \"{0}\". In the <satelliteassemblies> section, the <assembly> tag must have exactly 1 attribute called 'name', whose value is a fully-qualified assembly name.")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetDescription("System.Resources").SetException(typeof(System.ApplicationException)));
        Add(_syntaxerror = new MessageDescription("mscorlib.XMLSyntax_SyntaxError", 0xA3450614, new FormatText("Invalid syntax on line {0}.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException("System.Security.XmlSyntaxException"));
        Add(_syntaxerrorex = new MessageDescription("mscorlib.XMLSyntax_SyntaxErrorEx", 0xA3450615, new FormatText("Invalid syntax on line {0} - '{1}'.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetDescription("System.Security").SetException("System.Security.XmlSyntaxException"));
        Add(_unexpectedclosebracket = new MessageDescription("mscorlib.XMLSyntax_UnexpectedCloseBracket", 0xA3450616, new ParameterlessText("Unexpected > character.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetException("System.Security.XmlSyntaxException"));
        Add(_unexpectedendoffile = new MessageDescription("mscorlib.XMLSyntax_UnexpectedEndOfFile", 0xA3450617, new ParameterlessText("Unexpected end of file.")).SetHResult(0x80131418).SetSeverity(MessageLevel.Error).SetException("System.Security.XmlSyntaxException"));
        return this;
    }    

}
