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

/// <summary>CodeContract</summary>
public class CodeContractMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<CodeContractMessages> instance = new Lazy<CodeContractMessages>(() => new CodeContractMessages().Initialize().SetAllReadOnly<CodeContractMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static CodeContractMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x000D;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _assertionfailed, _assumptionfailed, _postconditionfailed, _preconditionfailed, _assertionfailedcnd, _assumptionfailedcnd, _invariantfailed, _invariantfailedcnd, _mustuseccrewrite, _postconditionfailedcnd;
    IMessageDescription? _postconditiononexceptionfailed, _postconditiononexceptionfailedcnd, _preconditionfailedcnd;
    
    /// <summary>System.Diagnostics.Contracts</summary>
    public IMessageDescription AssertionFailed { get => _assertionfailed!; set => this.AssertWritable()._assertionfailed = value; }
    /// <summary>System.Diagnostics.Contracts</summary>
    public IMessageDescription AssumptionFailed { get => _assumptionfailed!; set => this.AssertWritable()._assumptionfailed = value; }
    /// <summary>System.Diagnostics.Contracts</summary>
    public IMessageDescription PostconditionFailed { get => _postconditionfailed!; set => this.AssertWritable()._postconditionfailed = value; }
    /// <summary>System.Diagnostics.Contracts</summary>
    public IMessageDescription PreconditionFailed { get => _preconditionfailed!; set => this.AssertWritable()._preconditionfailed = value; }
    /// <summary>Assertion failed: {0}</summary>
    public IMessageDescription AssertionFailedCnd { get => _assertionfailedcnd!; set => this.AssertWritable()._assertionfailedcnd = value; }
    /// <summary>Assumption failed: {0}</summary>
    public IMessageDescription AssumptionFailedCnd { get => _assumptionfailedcnd!; set => this.AssertWritable()._assumptionfailedcnd = value; }
    /// <summary>Invariant failed.</summary>
    public IMessageDescription InvariantFailed { get => _invariantfailed!; set => this.AssertWritable()._invariantfailed = value; }
    /// <summary>Invariant failed: {0}</summary>
    public IMessageDescription InvariantFailedCnd { get => _invariantfailedcnd!; set => this.AssertWritable()._invariantfailedcnd = value; }
    /// <summary>An assembly (probably &quot;{1}&quot;) must be rewritten using the code contracts binary rewriter (CCRewrite) because it is calling Contract.{0} and the CONTRACTS_FULL symbol is defined. Remove any explicit definitions of the CONTRACTS_FULL symbol from your project and rebuild. CCRewrite can be downloaded from http://go.microsoft.com/fwlink/?LinkID=169180. After the rewriter is installed, it can be enabled in Visual Studio from the project&#39;s Properties page on the Code Contracts pane. Ensure that &quot;Perform Runtime Contract Checking&quot; is enabled, which will define CONTRACTS_FULL.</summary>
    public IMessageDescription MustUseCCRewrite { get => _mustuseccrewrite!; set => this.AssertWritable()._mustuseccrewrite = value; }
    /// <summary>Postcondition failed: {0}</summary>
    public IMessageDescription PostconditionFailedCnd { get => _postconditionfailedcnd!; set => this.AssertWritable()._postconditionfailedcnd = value; }
    /// <summary>Postcondition failed after throwing an exception.</summary>
    public IMessageDescription PostconditionOnExceptionFailed { get => _postconditiononexceptionfailed!; set => this.AssertWritable()._postconditiononexceptionfailed = value; }
    /// <summary>Postcondition failed after throwing an exception: {0}</summary>
    public IMessageDescription PostconditionOnExceptionFailedCnd { get => _postconditiononexceptionfailedcnd!; set => this.AssertWritable()._postconditiononexceptionfailedcnd = value; }
    /// <summary>Precondition failed: {0}</summary>
    public IMessageDescription PreconditionFailedCnd { get => _preconditionfailedcnd!; set => this.AssertWritable()._preconditionfailedcnd = value; }

    /// <summary>Initialize fields</summary>
    public override CodeContractMessages Initialize() 
    {
        base.Initialize();
        Add(_assertionfailed = new MessageDescription("mscorlib.AssertionFailed", 0xA34502D9, new ParameterlessText("Assertion failed.")).SetHResult(0x80131542).SetSeverity(MessageLevel.Error).SetDescription("System.Diagnostics.Contracts").SetException("System.Diagnostics.Contracts.ContractException"));
        Add(_assumptionfailed = new MessageDescription("mscorlib.AssumptionFailed", 0xA34502DA, new ParameterlessText("Assumption failed.")).SetHResult(0x80131542).SetSeverity(MessageLevel.Error).SetDescription("System.Diagnostics.Contracts").SetException("System.Diagnostics.Contracts.ContractException"));
        Add(_postconditionfailed = new MessageDescription("mscorlib.PostconditionFailed", 0xA34504E5, new ParameterlessText("Postcondition failed.")).SetHResult(0x80131542).SetSeverity(MessageLevel.Error).SetDescription("System.Diagnostics.Contracts").SetException("System.Diagnostics.Contracts.ContractException"));
        Add(_preconditionfailed = new MessageDescription("mscorlib.PreconditionFailed", 0xA34504E6, new ParameterlessText("Precondition failed.")).SetHResult(0x80131542).SetSeverity(MessageLevel.Error).SetDescription("System.Diagnostics.Contracts").SetException("System.Diagnostics.Contracts.ContractException"));
        Add(_assertionfailedcnd = new MessageDescription("mscorlib.AssertionFailed_Cnd", 0xA3450630, new FormatText("Assertion failed: {0}")).SetSeverity(MessageLevel.Error));
        Add(_assumptionfailedcnd = new MessageDescription("mscorlib.AssumptionFailed_Cnd", 0xA345062F, new FormatText("Assumption failed: {0}")).SetSeverity(MessageLevel.Error));
        Add(_invariantfailed = new MessageDescription("mscorlib.InvariantFailed", 0xA3450635, new ParameterlessText("Invariant failed.")).SetSeverity(MessageLevel.Error));
        Add(_invariantfailedcnd = new MessageDescription("mscorlib.InvariantFailed_Cnd", 0xA3450636, new FormatText("Invariant failed: {0}")).SetSeverity(MessageLevel.Error));
        Add(_mustuseccrewrite = new MessageDescription("mscorlib.MustUseCCRewrite", 0xA3450638, new FormatText("An assembly (probably \"{1}\") must be rewritten using the code contracts binary rewriter (CCRewrite) because it is calling Contract.{0} and the CONTRACTS_FULL symbol is defined.  Remove any explicit definitions of the CONTRACTS_FULL symbol from your project and rebuild.  CCRewrite can be downloaded from http://go.microsoft.com/fwlink/?LinkID=169180. \r\nAfter the rewriter is installed, it can be enabled in Visual Studio from the project's Properties page on the Code Contracts pane.  Ensure that \"Perform Runtime Contract Checking\" is enabled, which will define CONTRACTS_FULL.")).SetSeverity(MessageLevel.Error));
        Add(_postconditionfailedcnd = new MessageDescription("mscorlib.PostconditionFailed_Cnd", 0xA3450632, new FormatText("Postcondition failed: {0}")).SetSeverity(MessageLevel.Error));
        Add(_postconditiononexceptionfailed = new MessageDescription("mscorlib.PostconditionOnExceptionFailed", 0xA3450633, new ParameterlessText("Postcondition failed after throwing an exception.")).SetSeverity(MessageLevel.Error));
        Add(_postconditiononexceptionfailedcnd = new MessageDescription("mscorlib.PostconditionOnExceptionFailed_Cnd", 0xA3450634, new FormatText("Postcondition failed after throwing an exception: {0}")).SetSeverity(MessageLevel.Error));
        Add(_preconditionfailedcnd = new MessageDescription("mscorlib.PreconditionFailed_Cnd", 0xA3450631, new FormatText("Precondition failed: {0}")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
