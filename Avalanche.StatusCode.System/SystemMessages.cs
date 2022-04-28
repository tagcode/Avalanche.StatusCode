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
using Avalanche.Message;
using Avalanche.Template;
using Avalanche.Utilities;

/// <summary>Introduction</summary>
public static class SystemMessages
{
    /// <summary>All messages</summary>
    static Lazy<IMessageDescriptions> messages = new(() => new MessageDescriptions(AccessControlMessages.Instance, AggregateMessages.Instance, AppDomainMessages.Instance, ArgumentMessages.Instance, ArgumentNullMessages.Instance, ArgumentOutOfRangeMessages.Instance, ArithmeticMessages.Instance, ArrayMessages.Instance, AssemblyMessages.Instance, BadImageFormatMessages.Instance, CodeContractMessages.Instance, CodePageMessages.Instance, CollectionsMessages.Instance, CompilerServiceMessages.Instance, CryptographyMessages.Instance, CultureMessages.Instance, DiagnosticsMessages.Instance, EventSourceMessages.Instance, ExecutionEngineMessages.Instance, FormatMessages.Instance, HostProtectionMessages.Instance, IOMessages.Instance, IndexOutOfRangeMessages.Instance, InteropServiceMessages.Instance, InvalidCastMessages.Instance, InvalidOperationMessages.Instance, IsolatedStorageMessages.Instance, LazyMessages.Instance, MarshalerMessages.Instance, MemoryMessages.Instance, MiscellaneousMessages.Instance, NotImplementedMessages.Instance, NotSupportedMessages.Instance, ObjectDisposedMessages.Instance, OperationCanceledMessages.Instance, OverflowMessages.Instance, PlatformMessages.Instance, PolicyMessages.Instance, PrincipalMessages.Instance, ProgramMessages.Instance, ReferenceMessages.Instance, ReflectionMessages.Instance, RegionMessages.Instance, RemotingMessages.Instance, ResourcesMessages.Instance, SecurityMessages.Instance, SerializationMessages.Instance, StackMessages.Instance, TaskMessages.Instance, TextMessages.Instance, ThreadingMessages.Instance, TimeZoneMessages.Instance, TypeMessages.Instance, XmlMessages.Instance).SetReadOnly());
    /// <summary>All messages</summary>
    public static IMessageDescriptions Messages => messages.Value;
    
    /// <summary>System.Security.AccessControl.*</summary>
    public static AccessControlMessages AccessControl => AccessControlMessages.Instance;
    /// <summary>System.AggregateException</summary>
    public static AggregateMessages Aggregate => AggregateMessages.Instance;
    /// <summary>System.AppDomain.*</summary>
    public static AppDomainMessages AppDomain => AppDomainMessages.Instance;
    /// <summary>System.ArgumentException</summary>
    public static ArgumentMessages Argument => ArgumentMessages.Instance;
    /// <summary>System.ArgumentNullException</summary>
    public static ArgumentNullMessages ArgumentNull => ArgumentNullMessages.Instance;
    /// <summary>System.ArgumentOutOfRangeException</summary>
    public static ArgumentOutOfRangeMessages ArgumentOutOfRange => ArgumentOutOfRangeMessages.Instance;
    /// <summary>Arithmetic</summary>
    public static ArithmeticMessages Arithmetic => ArithmeticMessages.Instance;
    /// <summary>Array</summary>
    public static ArrayMessages Array => ArrayMessages.Instance;
    /// <summary>Assembly</summary>
    public static AssemblyMessages Assembly => AssemblyMessages.Instance;
    /// <summary>System.BadImageFormatException</summary>
    public static BadImageFormatMessages BadImageFormat => BadImageFormatMessages.Instance;
    /// <summary>CodeContract</summary>
    public static CodeContractMessages CodeContract => CodeContractMessages.Instance;
    /// <summary>CodePage</summary>
    public static CodePageMessages CodePage => CodePageMessages.Instance;
    /// <summary>System.Collections.*</summary>
    public static CollectionsMessages Collections => CollectionsMessages.Instance;
    /// <summary>System.Runtime.CompilerServices.*</summary>
    public static CompilerServiceMessages CompilerService => CompilerServiceMessages.Instance;
    /// <summary>System.Security.Cryptography.*</summary>
    public static CryptographyMessages Cryptography => CryptographyMessages.Instance;
    /// <summary>System.Globalization.Culture*</summary>
    public static CultureMessages Culture => CultureMessages.Instance;
    /// <summary>System.Diagnostics.*</summary>
    public static DiagnosticsMessages Diagnostics => DiagnosticsMessages.Instance;
    /// <summary>System.Diagnostics.Tracing.EventSourceException</summary>
    public static EventSourceMessages EventSource => EventSourceMessages.Instance;
    /// <summary>ExecutionEngine</summary>
    public static ExecutionEngineMessages ExecutionEngine => ExecutionEngineMessages.Instance;
    /// <summary>System.FormatException</summary>
    public static FormatMessages Format => FormatMessages.Instance;
    /// <summary>System.Security.HostProtectionException</summary>
    public static HostProtectionMessages HostProtection => HostProtectionMessages.Instance;
    /// <summary>System.IO.*</summary>
    public static IOMessages IO => IOMessages.Instance;
    /// <summary>System.IndexOutOfRangeException</summary>
    public static IndexOutOfRangeMessages IndexOutOfRange => IndexOutOfRangeMessages.Instance;
    /// <summary>System.Runtime.InteropServices.*</summary>
    public static InteropServiceMessages InteropService => InteropServiceMessages.Instance;
    /// <summary>System.InvalidCastException</summary>
    public static InvalidCastMessages InvalidCast => InvalidCastMessages.Instance;
    /// <summary>System.InvalidOperationException</summary>
    public static InvalidOperationMessages InvalidOperation => InvalidOperationMessages.Instance;
    /// <summary>System.IO.IsolatedStorage.*</summary>
    public static IsolatedStorageMessages IsolatedStorage => IsolatedStorageMessages.Instance;
    /// <summary>System.Threading.Lazy</summary>
    public static LazyMessages Lazy => LazyMessages.Instance;
    /// <summary>Marshaler</summary>
    public static MarshalerMessages Marshaler => MarshalerMessages.Instance;
    /// <summary>Memory</summary>
    public static MemoryMessages Memory => MemoryMessages.Instance;
    /// <summary>Miscellaneous</summary>
    public static MiscellaneousMessages Miscellaneous => MiscellaneousMessages.Instance;
    /// <summary>System.NotImplementedException</summary>
    public static NotImplementedMessages NotImplemented => NotImplementedMessages.Instance;
    /// <summary>System.NotSupportedException</summary>
    public static NotSupportedMessages NotSupported => NotSupportedMessages.Instance;
    /// <summary>System.ObjectDisposedException</summary>
    public static ObjectDisposedMessages ObjectDisposed => ObjectDisposedMessages.Instance;
    /// <summary>System.OperationCanceledException</summary>
    public static OperationCanceledMessages OperationCanceled => OperationCanceledMessages.Instance;
    /// <summary>System.OverflowException</summary>
    public static OverflowMessages Overflow => OverflowMessages.Instance;
    /// <summary>Platform</summary>
    public static PlatformMessages Platform => PlatformMessages.Instance;
    /// <summary>System.Security.Policy.*</summary>
    public static PolicyMessages Policy => PolicyMessages.Instance;
    /// <summary>System.Security.Principal.*</summary>
    public static PrincipalMessages Principal => PrincipalMessages.Instance;
    /// <summary>System.InvalidProgramException</summary>
    public static ProgramMessages Program => ProgramMessages.Instance;
    /// <summary>Reference</summary>
    public static ReferenceMessages Reference => ReferenceMessages.Instance;
    /// <summary>System.Reflection.*</summary>
    public static ReflectionMessages Reflection => ReflectionMessages.Instance;
    /// <summary>Region</summary>
    public static RegionMessages Region => RegionMessages.Instance;
    /// <summary>System.Runtime.Remoting.*</summary>
    public static RemotingMessages Remoting => RemotingMessages.Instance;
    /// <summary>System.Resources.*</summary>
    public static ResourcesMessages Resources => ResourcesMessages.Instance;
    /// <summary>System.Security.*</summary>
    public static SecurityMessages Security => SecurityMessages.Instance;
    /// <summary>System.Runtime.Serialization.*</summary>
    public static SerializationMessages Serialization => SerializationMessages.Instance;
    /// <summary>Stack</summary>
    public static StackMessages Stack => StackMessages.Instance;
    /// <summary>System.Threading.Tasks.*</summary>
    public static TaskMessages Task => TaskMessages.Instance;
    /// <summary>System.Text.*</summary>
    public static TextMessages Text => TextMessages.Instance;
    /// <summary>System.Threading.*</summary>
    public static ThreadingMessages Threading => ThreadingMessages.Instance;
    /// <summary>TimeZone</summary>
    public static TimeZoneMessages TimeZone => TimeZoneMessages.Instance;
    /// <summary>Type</summary>
    public static TypeMessages Type => TypeMessages.Instance;
    /// <summary>System.Xml.*</summary>
    public static XmlMessages Xml => XmlMessages.Instance;
}
