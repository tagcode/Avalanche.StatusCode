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

/// <summary>System.Threading.*</summary>
public class ThreadingMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<ThreadingMessages> instance = new Lazy<ThreadingMessages>(() => new ThreadingMessages().Initialize().SetAllReadOnly<ThreadingMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static ThreadingMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0037;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _synchronizationlockexception, _threadstartexception, _threadstateexception, _cancellationtokencreatelinkedtokentokensisempty, _cancellationtokensourcedisposed, _cancellationtokensourcedisposed2, _invalidoperationcannotuseafcotherthread, _invalidoperationcannotuseswitcherotherthread, _invalidoperationmustbesamethread, _invalidoperationthreadapisnotsupported;
    IMessageDescription? _invalidoperationthreadwrongthreadstart, _manualreseteventslimctorspincountoutofrange, _manualreseteventslimctortoomanywaiters, _manualreseteventslimdisposed, _parallelforeachnullenumerator, _parallelforeachorderedpartitionerkeysnotnormalized, _parallelforeachpartitionernotdynamic, _parallelforeachpartitionerreturnednull, _parallelinvokeactionnull, _parallelstatebreakinvalidoperationexceptionbreakafterstop;
    IMessageDescription? _parallelstatenotsupportedexceptionunsupportedmethod, _parallelstatestopinvalidoperationexceptionstopafterbreak, _semaphoreslimctorinitialcountwrong, _semaphoreslimctormaxcountwrong, _semaphoreslimdisposed, _semaphoreslimreleasecountwrong, _semaphoreslimwaittimeoutwrong, _spinlockisheldbycurrentthread, _spinlocktryenterargumentoutofrange, _spinlocktryenterlockrecursionexception;
    IMessageDescription? _spinwaitspinuntilargumentnull, _spinwaitspinuntiltimeoutwrong, _threadingsemaphorefullexception, _threadingabandonedmutexexception, _threadingwaithandlecannotbeopenedexception, _threadingwaithandlecannotbeopenedexceptioninvalidhandle, _threadingwaithandletoomanyposts, _threadlocaldisposed, _threadlocalvaluerecursivecallstovalue, _threadlocalvaluesnotavailable;
    IMessageDescription? _threadstatenoabortrequested, _awaitableawaiterinstancenotinitialized, _notsupportedsignalandwaitstathread, _notsupportedwaitallstathread, _synchronizationlockexception2, _spinlocktryreliableenterargumentexception, _barrierphasefinished, _parallelfork, _parallelinvokebegin, _parallelinvokeend;
    IMessageDescription? _paralleljoin, _parallelloopbegin, _parallelloopend, _spinlockfastpathfailed, _spinwaitnextspinwillyield;
    
    /// <summary>System.Threading</summary>
    public IMessageDescription SynchronizationLockException { get => _synchronizationlockexception!; set => this.AssertWritable()._synchronizationlockexception = value; }
    /// <summary>System.Threading</summary>
    public IMessageDescription ThreadStartException { get => _threadstartexception!; set => this.AssertWritable()._threadstartexception = value; }
    /// <summary>System.Threading</summary>
    public IMessageDescription ThreadStateException { get => _threadstateexception!; set => this.AssertWritable()._threadstateexception = value; }
    /// <summary>No tokens were supplied.</summary>
    public IMessageDescription CancellationTokenCreateLinkedTokenTokensIsEmpty { get => _cancellationtokencreatelinkedtokentokensisempty!; set => this.AssertWritable()._cancellationtokencreatelinkedtokentokensisempty = value; }
    /// <summary>The CancellationTokenSource associated with this CancellationToken has been disposed.</summary>
    public IMessageDescription CancellationTokenSourceDisposed { get => _cancellationtokensourcedisposed!; set => this.AssertWritable()._cancellationtokensourcedisposed = value; }
    /// <summary>The CancellationTokenSource has been disposed.</summary>
    public IMessageDescription CancellationTokenSourceDisposed2 { get => _cancellationtokensourcedisposed2!; set => this.AssertWritable()._cancellationtokensourcedisposed2 = value; }
    /// <summary>AsyncFlowControl object must be used on the thread where it was created.</summary>
    public IMessageDescription InvalidOperationCannotUseAFCOtherThread { get => _invalidoperationcannotuseafcotherthread!; set => this.AssertWritable()._invalidoperationcannotuseafcotherthread = value; }
    /// <summary>Undo operation must be performed on the thread where the corresponding context was Set.</summary>
    public IMessageDescription InvalidOperationCannotUseSwitcherOtherThread { get => _invalidoperationcannotuseswitcherotherthread!; set => this.AssertWritable()._invalidoperationcannotuseswitcherotherthread = value; }
    /// <summary>This operation must take place on the same thread on which the object was created.</summary>
    public IMessageDescription InvalidOperationMustBeSameThread { get => _invalidoperationmustbesamethread!; set => this.AssertWritable()._invalidoperationmustbesamethread = value; }
    /// <summary>Use CompressedStack.(Capture/Run) or ExecutionContext.(Capture/Run) APIs instead.</summary>
    public IMessageDescription InvalidOperationThreadAPIsNotSupported { get => _invalidoperationthreadapisnotsupported!; set => this.AssertWritable()._invalidoperationthreadapisnotsupported = value; }
    /// <summary>The thread was created with a ThreadStart delegate that does not accept a parameter.</summary>
    public IMessageDescription InvalidOperationThreadWrongThreadStart { get => _invalidoperationthreadwrongthreadstart!; set => this.AssertWritable()._invalidoperationthreadwrongthreadstart = value; }
    /// <summary>The spinCount argument must be in the range 0 to {0}, inclusive.</summary>
    public IMessageDescription ManualResetEventSlimctorSpinCountOutOfRange { get => _manualreseteventslimctorspincountoutofrange!; set => this.AssertWritable()._manualreseteventslimctorspincountoutofrange = value; }
    /// <summary>There are too many threads currently waiting on the event. A maximum of {0} waiting threads are supported.</summary>
    public IMessageDescription ManualResetEventSlimctorTooManyWaiters { get => _manualreseteventslimctortoomanywaiters!; set => this.AssertWritable()._manualreseteventslimctortoomanywaiters = value; }
    /// <summary>The event has been disposed.</summary>
    public IMessageDescription ManualResetEventSlimDisposed { get => _manualreseteventslimdisposed!; set => this.AssertWritable()._manualreseteventslimdisposed = value; }
    /// <summary>The Partitioner source returned a null enumerator.</summary>
    public IMessageDescription ParallelForEachNullEnumerator { get => _parallelforeachnullenumerator!; set => this.AssertWritable()._parallelforeachnullenumerator = value; }
    /// <summary>This method requires the use of an OrderedPartitioner with the KeysNormalized property set to true.</summary>
    public IMessageDescription ParallelForEachOrderedPartitionerKeysNotNormalized { get => _parallelforeachorderedpartitionerkeysnotnormalized!; set => this.AssertWritable()._parallelforeachorderedpartitionerkeysnotnormalized = value; }
    /// <summary>The Partitioner used here must support dynamic partitioning.</summary>
    public IMessageDescription ParallelForEachPartitionerNotDynamic { get => _parallelforeachpartitionernotdynamic!; set => this.AssertWritable()._parallelforeachpartitionernotdynamic = value; }
    /// <summary>The Partitioner used here returned a null partitioner source.</summary>
    public IMessageDescription ParallelForEachPartitionerReturnedNull { get => _parallelforeachpartitionerreturnednull!; set => this.AssertWritable()._parallelforeachpartitionerreturnednull = value; }
    /// <summary>One of the actions was null.</summary>
    public IMessageDescription ParallelInvokeActionNull { get => _parallelinvokeactionnull!; set => this.AssertWritable()._parallelinvokeactionnull = value; }
    /// <summary>Break was called after Stop was called.</summary>
    public IMessageDescription ParallelStateBreakInvalidOperationExceptionBreakAfterStop { get => _parallelstatebreakinvalidoperationexceptionbreakafterstop!; set => this.AssertWritable()._parallelstatebreakinvalidoperationexceptionbreakafterstop = value; }
    /// <summary>This method is not supported.</summary>
    public IMessageDescription ParallelStateNotSupportedExceptionUnsupportedMethod { get => _parallelstatenotsupportedexceptionunsupportedmethod!; set => this.AssertWritable()._parallelstatenotsupportedexceptionunsupportedmethod = value; }
    /// <summary>Stop was called after Break was called.</summary>
    public IMessageDescription ParallelStateStopInvalidOperationExceptionStopAfterBreak { get => _parallelstatestopinvalidoperationexceptionstopafterbreak!; set => this.AssertWritable()._parallelstatestopinvalidoperationexceptionstopafterbreak = value; }
    /// <summary>The initialCount argument must be non-negative and less than or equal to the maximumCount.</summary>
    public IMessageDescription SemaphoreSlimctorInitialCountWrong { get => _semaphoreslimctorinitialcountwrong!; set => this.AssertWritable()._semaphoreslimctorinitialcountwrong = value; }
    /// <summary>The maximumCount argument must be a positive number. If a maximum is not required, use the constructor without a maxCount parameter.</summary>
    public IMessageDescription SemaphoreSlimctorMaxCountWrong { get => _semaphoreslimctormaxcountwrong!; set => this.AssertWritable()._semaphoreslimctormaxcountwrong = value; }
    /// <summary>The semaphore has been disposed.</summary>
    public IMessageDescription SemaphoreSlimDisposed { get => _semaphoreslimdisposed!; set => this.AssertWritable()._semaphoreslimdisposed = value; }
    /// <summary>The releaseCount argument must be greater than zero.</summary>
    public IMessageDescription SemaphoreSlimReleaseCountWrong { get => _semaphoreslimreleasecountwrong!; set => this.AssertWritable()._semaphoreslimreleasecountwrong = value; }
    /// <summary>The timeout must represent a value between -1 and Int32.MaxValue, inclusive.</summary>
    public IMessageDescription SemaphoreSlimWaitTimeoutWrong { get => _semaphoreslimwaittimeoutwrong!; set => this.AssertWritable()._semaphoreslimwaittimeoutwrong = value; }
    /// <summary>Thread tracking is disabled.</summary>
    public IMessageDescription SpinLockIsHeldByCurrentThread { get => _spinlockisheldbycurrentthread!; set => this.AssertWritable()._spinlockisheldbycurrentthread = value; }
    /// <summary>The timeout must be a value between -1 and Int32.MaxValue, inclusive.</summary>
    public IMessageDescription SpinLockTryEnterArgumentOutOfRange { get => _spinlocktryenterargumentoutofrange!; set => this.AssertWritable()._spinlocktryenterargumentoutofrange = value; }
    /// <summary>The calling thread already holds the lock.</summary>
    public IMessageDescription SpinLockTryEnterLockRecursionException { get => _spinlocktryenterlockrecursionexception!; set => this.AssertWritable()._spinlocktryenterlockrecursionexception = value; }
    /// <summary>The condition argument is null.</summary>
    public IMessageDescription SpinWaitSpinUntilArgumentNull { get => _spinwaitspinuntilargumentnull!; set => this.AssertWritable()._spinwaitspinuntilargumentnull = value; }
    /// <summary>The timeout must represent a value between -1 and Int32.MaxValue, inclusive.</summary>
    public IMessageDescription SpinWaitSpinUntilTimeoutWrong { get => _spinwaitspinuntiltimeoutwrong!; set => this.AssertWritable()._spinwaitspinuntiltimeoutwrong = value; }
    /// <summary>System.Threading</summary>
    public IMessageDescription ThreadingSemaphoreFullException { get => _threadingsemaphorefullexception!; set => this.AssertWritable()._threadingsemaphorefullexception = value; }
    /// <summary>System.Threading</summary>
    public IMessageDescription ThreadingAbandonedMutexException { get => _threadingabandonedmutexexception!; set => this.AssertWritable()._threadingabandonedmutexexception = value; }
    /// <summary>System.Threading</summary>
    public IMessageDescription ThreadingWaitHandleCannotBeOpenedException { get => _threadingwaithandlecannotbeopenedexception!; set => this.AssertWritable()._threadingwaithandlecannotbeopenedexception = value; }
    /// <summary>A WaitHandle with system-wide name &#39;{0}&#39; cannot be created. A WaitHandle of a different type might have the same name.</summary>
    public IMessageDescription ThreadingWaitHandleCannotBeOpenedExceptionInvalidHandle { get => _threadingwaithandlecannotbeopenedexceptioninvalidhandle!; set => this.AssertWritable()._threadingwaithandlecannotbeopenedexceptioninvalidhandle = value; }
    /// <summary>The WaitHandle cannot be signaled because it would exceed its maximum count.</summary>
    public IMessageDescription ThreadingWaitHandleTooManyPosts { get => _threadingwaithandletoomanyposts!; set => this.AssertWritable()._threadingwaithandletoomanyposts = value; }
    /// <summary>The ThreadLocal object has been disposed.</summary>
    public IMessageDescription ThreadLocalDisposed { get => _threadlocaldisposed!; set => this.AssertWritable()._threadlocaldisposed = value; }
    /// <summary>ValueFactory attempted to access the Value property of this instance.</summary>
    public IMessageDescription ThreadLocalValueRecursiveCallsToValue { get => _threadlocalvaluerecursivecallstovalue!; set => this.AssertWritable()._threadlocalvaluerecursivecallstovalue = value; }
    /// <summary>The ThreadLocal object is not tracking values. To use the Values property, use a ThreadLocal constructor that accepts the trackAllValues parameter and set the parameter to true.</summary>
    public IMessageDescription ThreadLocalValuesNotAvailable { get => _threadlocalvaluesnotavailable!; set => this.AssertWritable()._threadlocalvaluesnotavailable = value; }
    /// <summary>Unable to reset abort because no abort was requested.</summary>
    public IMessageDescription ThreadStateNoAbortRequested { get => _threadstatenoabortrequested!; set => this.AssertWritable()._threadstatenoabortrequested = value; }
    /// <summary>The awaitable or awaiter was not properly initialized.</summary>
    public IMessageDescription AwaitableAwaiterInstanceNotInitialized { get => _awaitableawaiterinstancenotinitialized!; set => this.AssertWritable()._awaitableawaiterinstancenotinitialized = value; }
    /// <summary>SignalAndWait on a STA thread is not supported.</summary>
    public IMessageDescription NotSupportedSignalAndWaitSTAThread { get => _notsupportedsignalandwaitstathread!; set => this.AssertWritable()._notsupportedsignalandwaitstathread = value; }
    /// <summary>WaitAll for multiple handles on a STA thread is not supported.</summary>
    public IMessageDescription NotSupportedWaitAllSTAThread { get => _notsupportedwaitallstathread!; set => this.AssertWritable()._notsupportedwaitallstathread = value; }
    /// <summary>The calling thread does not hold the lock.</summary>
    public IMessageDescription SynchronizationLockException2 { get => _synchronizationlockexception2!; set => this.AssertWritable()._synchronizationlockexception2 = value; }
    /// <summary>The tookLock argument must be set to false before calling this method.</summary>
    public IMessageDescription SpinLockTryReliableEnterArgumentException { get => _spinlocktryreliableenterargumentexception!; set => this.AssertWritable()._spinlocktryreliableenterargumentexception = value; }
    /// <summary>Barrier finishing phase {1}.</summary>
    public IMessageDescription BarrierPhaseFinished { get => _barrierphasefinished!; set => this.AssertWritable()._barrierphasefinished = value; }
    /// <summary>Task {1} entering fork/join {2}.</summary>
    public IMessageDescription ParallelFork { get => _parallelfork!; set => this.AssertWritable()._parallelfork = value; }
    /// <summary>Beginning ParallelInvoke {2} from Task {1} for {4} actions.</summary>
    public IMessageDescription ParallelInvokeBegin { get => _parallelinvokebegin!; set => this.AssertWritable()._parallelinvokebegin = value; }
    /// <summary>Ending ParallelInvoke {2}.</summary>
    public IMessageDescription ParallelInvokeEnd { get => _parallelinvokeend!; set => this.AssertWritable()._parallelinvokeend = value; }
    /// <summary>Task {1} leaving fork/join {2}.</summary>
    public IMessageDescription ParallelJoin { get => _paralleljoin!; set => this.AssertWritable()._paralleljoin = value; }
    /// <summary>Beginning {3} loop {2} from Task {1}.</summary>
    public IMessageDescription ParallelLoopBegin { get => _parallelloopbegin!; set => this.AssertWritable()._parallelloopbegin = value; }
    /// <summary>Ending loop {2} after {3} iterations.</summary>
    public IMessageDescription ParallelLoopEnd { get => _parallelloopend!; set => this.AssertWritable()._parallelloopend = value; }
    /// <summary>SpinLock beginning to spin.</summary>
    public IMessageDescription SpinLockFastPathFailed { get => _spinlockfastpathfailed!; set => this.AssertWritable()._spinlockfastpathfailed = value; }
    /// <summary>Next spin will yield.</summary>
    public IMessageDescription SpinWaitNextSpinWillYield { get => _spinwaitnextspinwillyield!; set => this.AssertWritable()._spinwaitnextspinwillyield = value; }

    /// <summary>Initialize fields</summary>
    public override ThreadingMessages Initialize() 
    {
        base.Initialize();
        Add(_synchronizationlockexception = new MessageDescription("mscorlib.Arg_SynchronizationLockException", 0xA34500F8, new ParameterlessText("Object synchronization method was called from an unsynchronized block of code.")).SetHResult(0x80131600).SetSeverity(MessageLevel.Error).SetDescription("System.Threading").SetException(typeof(System.ApplicationException)));
        Add(_threadstartexception = new MessageDescription("mscorlib.Arg_ThreadStartException", 0xA34500FC, new ParameterlessText("Thread failed to start.")).SetHResult(0x80131525).SetSeverity(MessageLevel.Error).SetDescription("System.Threading").SetException(typeof(System.Threading.ThreadStartException)));
        Add(_threadstateexception = new MessageDescription("mscorlib.Arg_ThreadStateException", 0xA34500FD, new ParameterlessText("Thread was in an invalid state for the operation being executed.")).SetHResult(0x80131520).SetSeverity(MessageLevel.Error).SetDescription("System.Threading").SetException(typeof(System.Threading.ThreadStateException)));
        Add(_cancellationtokencreatelinkedtokentokensisempty = new MessageDescription("mscorlib.CancellationToken_CreateLinkedToken_TokensIsEmpty", 0xA34502E9, new ParameterlessText("No tokens were supplied.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cancellationtokensourcedisposed = new MessageDescription("mscorlib.CancellationToken_SourceDisposed", 0xA34502EA, new ParameterlessText("The CancellationTokenSource associated with this CancellationToken has been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_cancellationtokensourcedisposed2 = new MessageDescription("mscorlib.CancellationTokenSource_Disposed", 0xA34502EB, new ParameterlessText("The CancellationTokenSource has been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_invalidoperationcannotuseafcotherthread = new MessageDescription("mscorlib.InvalidOperation_CannotUseAFCOtherThread", 0xA345039C, new ParameterlessText("AsyncFlowControl object must be used on the thread where it was created.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationcannotuseswitcherotherthread = new MessageDescription("mscorlib.InvalidOperation_CannotUseSwitcherOtherThread", 0xA345039D, new ParameterlessText("Undo operation must be performed on the thread where the corresponding context was Set.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationmustbesamethread = new MessageDescription("mscorlib.InvalidOperation_MustBeSameThread", 0xA34503CD, new ParameterlessText("This operation must take place on the same thread on which the object was created.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationthreadapisnotsupported = new MessageDescription("mscorlib.InvalidOperation_ThreadAPIsNotSupported", 0xA34503FA, new ParameterlessText("Use CompressedStack.(Capture/Run) or ExecutionContext.(Capture/Run) APIs instead.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_invalidoperationthreadwrongthreadstart = new MessageDescription("mscorlib.InvalidOperation_ThreadWrongThreadStart", 0xA34503FB, new ParameterlessText("The thread was created with a ThreadStart delegate that does not accept a parameter.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_manualreseteventslimctorspincountoutofrange = new MessageDescription("mscorlib.ManualResetEventSlim_ctor_SpinCountOutOfRange", 0xA3450448, new FormatText("The spinCount argument must be in the range 0 to {0}, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_manualreseteventslimctortoomanywaiters = new MessageDescription("mscorlib.ManualResetEventSlim_ctor_TooManyWaiters", 0xA3450449, new FormatText("There are too many threads currently waiting on the event. A maximum of {0} waiting threads are supported.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_manualreseteventslimdisposed = new MessageDescription("mscorlib.ManualResetEventSlim_Disposed", 0xA345044A, new ParameterlessText("The event has been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_parallelforeachnullenumerator = new MessageDescription("mscorlib.Parallel_ForEach_NullEnumerator", 0xA34504BF, new ParameterlessText("The Partitioner source returned a null enumerator.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_parallelforeachorderedpartitionerkeysnotnormalized = new MessageDescription("mscorlib.Parallel_ForEach_OrderedPartitionerKeysNotNormalized", 0xA34504C0, new ParameterlessText("This method requires the use of an OrderedPartitioner with the KeysNormalized property set to true.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_parallelforeachpartitionernotdynamic = new MessageDescription("mscorlib.Parallel_ForEach_PartitionerNotDynamic", 0xA34504C1, new ParameterlessText("The Partitioner used here must support dynamic partitioning.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_parallelforeachpartitionerreturnednull = new MessageDescription("mscorlib.Parallel_ForEach_PartitionerReturnedNull", 0xA34504C2, new ParameterlessText("The Partitioner used here returned a null partitioner source.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_parallelinvokeactionnull = new MessageDescription("mscorlib.Parallel_Invoke_ActionNull", 0xA34504C3, new ParameterlessText("One of the actions was null.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_parallelstatebreakinvalidoperationexceptionbreakafterstop = new MessageDescription("mscorlib.ParallelState_Break_InvalidOperationException_BreakAfterStop", 0xA34504C4, new ParameterlessText("Break was called after Stop was called.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_parallelstatenotsupportedexceptionunsupportedmethod = new MessageDescription("mscorlib.ParallelState_NotSupportedException_UnsupportedMethod", 0xA34504C5, new ParameterlessText("This method is not supported.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_parallelstatestopinvalidoperationexceptionstopafterbreak = new MessageDescription("mscorlib.ParallelState_Stop_InvalidOperationException_StopAfterBreak", 0xA34504C6, new ParameterlessText("Stop was called after Break was called.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_semaphoreslimctorinitialcountwrong = new MessageDescription("mscorlib.SemaphoreSlim_ctor_InitialCountWrong", 0xA345056C, new ParameterlessText("The initialCount argument must be non-negative and less than or equal to the maximumCount.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_semaphoreslimctormaxcountwrong = new MessageDescription("mscorlib.SemaphoreSlim_ctor_MaxCountWrong", 0xA345056D, new ParameterlessText("The maximumCount argument must be a positive number. If a maximum is not required, use the constructor without a maxCount parameter.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_semaphoreslimdisposed = new MessageDescription("mscorlib.SemaphoreSlim_Disposed", 0xA345056E, new ParameterlessText("The semaphore has been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_semaphoreslimreleasecountwrong = new MessageDescription("mscorlib.SemaphoreSlim_Release_CountWrong", 0xA345056F, new ParameterlessText("The releaseCount argument must be greater than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_semaphoreslimwaittimeoutwrong = new MessageDescription("mscorlib.SemaphoreSlim_Wait_TimeoutWrong", 0xA3450570, new ParameterlessText("The timeout must represent a value between -1 and Int32.MaxValue, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_spinlockisheldbycurrentthread = new MessageDescription("mscorlib.SpinLock_IsHeldByCurrentThread", 0xA34505CB, new ParameterlessText("Thread tracking is disabled.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_spinlocktryenterargumentoutofrange = new MessageDescription("mscorlib.SpinLock_TryEnter_ArgumentOutOfRange", 0xA34505CC, new ParameterlessText("The timeout must be a value between -1 and Int32.MaxValue, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_spinlocktryenterlockrecursionexception = new MessageDescription("mscorlib.SpinLock_TryEnter_LockRecursionException", 0xA34505CD, new ParameterlessText("The calling thread already holds the lock.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.LockRecursionException)));
        Add(_spinwaitspinuntilargumentnull = new MessageDescription("mscorlib.SpinWait_SpinUntil_ArgumentNull", 0xA34505CE, new ParameterlessText("The condition argument is null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_spinwaitspinuntiltimeoutwrong = new MessageDescription("mscorlib.SpinWait_SpinUntil_TimeoutWrong", 0xA34505CF, new ParameterlessText("The timeout must represent a value between -1 and Int32.MaxValue, inclusive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_threadingsemaphorefullexception = new MessageDescription("mscorlib.Threading_SemaphoreFullException", 0xA34505F4, new ParameterlessText("Adding the specified count to the semaphore would cause it to exceed its maximum count.")).SetHResult(0x80131501).SetSeverity(MessageLevel.Error).SetDescription("System.Threading").SetException(typeof(System.Threading.SemaphoreFullException)));
        Add(_threadingabandonedmutexexception = new MessageDescription("mscorlib.Threading.AbandonedMutexException", 0xA34505F5, new ParameterlessText("The wait completed due to an abandoned mutex.")).SetHResult(0x8013152D).SetSeverity(MessageLevel.Error).SetDescription("System.Threading").SetException(typeof(System.Threading.AbandonedMutexException)));
        Add(_threadingwaithandlecannotbeopenedexception = new MessageDescription("mscorlib.Threading.WaitHandleCannotBeOpenedException", 0xA34505F6, new ParameterlessText("No handle of the given name exists.")).SetHResult(0x8013152C).SetSeverity(MessageLevel.Error).SetDescription("System.Threading").SetException(typeof(System.Threading.WaitHandleCannotBeOpenedException)));
        Add(_threadingwaithandlecannotbeopenedexceptioninvalidhandle = new MessageDescription("mscorlib.Threading.WaitHandleCannotBeOpenedException_InvalidHandle", 0xA34505F7, new FormatText("A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.")).SetHResult(0x8013152C).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.WaitHandleCannotBeOpenedException)));
        Add(_threadingwaithandletoomanyposts = new MessageDescription("mscorlib.Threading.WaitHandleTooManyPosts", 0xA34505F8, new ParameterlessText("The WaitHandle cannot be signaled because it would exceed its maximum count.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_threadlocaldisposed = new MessageDescription("mscorlib.ThreadLocal_Disposed", 0xA34505F9, new ParameterlessText("The ThreadLocal object has been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_threadlocalvaluerecursivecallstovalue = new MessageDescription("mscorlib.ThreadLocal_Value_RecursiveCallsToValue", 0xA34505FA, new ParameterlessText("ValueFactory attempted to access the Value property of this instance.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_threadlocalvaluesnotavailable = new MessageDescription("mscorlib.ThreadLocal_ValuesNotAvailable", 0xA34505FB, new ParameterlessText("The ThreadLocal object is not tracking values. To use the Values property, use a ThreadLocal constructor that accepts the trackAllValues parameter and set the parameter to true.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_threadstatenoabortrequested = new MessageDescription("mscorlib.ThreadState_NoAbortRequested", 0xA34505FC, new ParameterlessText("Unable to reset abort because no abort was requested.")).SetHResult(0x80131520).SetSeverity(MessageLevel.Error).SetException(typeof(System.Threading.ThreadStateException)));
        Add(_awaitableawaiterinstancenotinitialized = new MessageDescription("mscorlib.AwaitableAwaiter_InstanceNotInitialized", 0xA3450769, new ParameterlessText("The awaitable or awaiter was not properly initialized.")).SetSeverity(MessageLevel.Error));
        Add(_notsupportedsignalandwaitstathread = new MessageDescription("mscorlib.NotSupported_SignalAndWaitSTAThread", 0xA34506E6, new ParameterlessText("SignalAndWait on a STA thread is not supported.")).SetSeverity(MessageLevel.Error));
        Add(_notsupportedwaitallstathread = new MessageDescription("mscorlib.NotSupported_WaitAllSTAThread", 0xA34506E5, new ParameterlessText("WaitAll for multiple handles on a STA thread is not supported.")).SetSeverity(MessageLevel.Error));
        Add(_synchronizationlockexception2 = new MessageDescription("mscorlib.SpinLock_Exit_SynchronizationLockException", 0xA3450765, new ParameterlessText("The calling thread does not hold the lock.")).SetSeverity(MessageLevel.Error));
        Add(_spinlocktryreliableenterargumentexception = new MessageDescription("mscorlib.SpinLock_TryReliableEnter_ArgumentException", 0xA3450764, new ParameterlessText("The tookLock argument must be set to false before calling this method.")).SetSeverity(MessageLevel.Error));
        Add(_barrierphasefinished = new MessageDescription("mscorlib.event_Barrier_PhaseFinished", 0xA3450768, new FormatText("Barrier finishing phase {1}.")).SetSeverity(MessageLevel.Error));
        Add(_parallelfork = new MessageDescription("mscorlib.event_ParallelFork", 0xA3450773, new FormatText("Task {1} entering fork/join {2}.")).SetSeverity(MessageLevel.Error));
        Add(_parallelinvokebegin = new MessageDescription("mscorlib.event_ParallelInvokeBegin", 0xA3450771, new FormatText("Beginning ParallelInvoke {2} from Task {1} for {4} actions.")).SetSeverity(MessageLevel.Error));
        Add(_parallelinvokeend = new MessageDescription("mscorlib.event_ParallelInvokeEnd", 0xA3450772, new FormatText("Ending ParallelInvoke {2}.")).SetSeverity(MessageLevel.Error));
        Add(_paralleljoin = new MessageDescription("mscorlib.event_ParallelJoin", 0xA3450774, new FormatText("Task {1} leaving fork/join {2}.")).SetSeverity(MessageLevel.Error));
        Add(_parallelloopbegin = new MessageDescription("mscorlib.event_ParallelLoopBegin", 0xA345076F, new FormatText("Beginning {3} loop {2} from Task {1}.")).SetSeverity(MessageLevel.Error));
        Add(_parallelloopend = new MessageDescription("mscorlib.event_ParallelLoopEnd", 0xA3450770, new FormatText("Ending loop {2} after {3} iterations.")).SetSeverity(MessageLevel.Error));
        Add(_spinlockfastpathfailed = new MessageDescription("mscorlib.event_SpinLock_FastPathFailed", 0xA3450766, new ParameterlessText("SpinLock beginning to spin.")).SetSeverity(MessageLevel.Error));
        Add(_spinwaitnextspinwillyield = new MessageDescription("mscorlib.event_SpinWait_NextSpinWillYield", 0xA3450767, new ParameterlessText("Next spin will yield.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
