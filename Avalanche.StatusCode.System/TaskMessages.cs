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

/// <summary>System.Threading.Tasks.*</summary>
public class TaskMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<TaskMessages> instance = new Lazy<TaskMessages>(() => new TaskMessages().Initialize().SetAllReadOnly<TaskMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static TaskMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x002B;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _taskcontinuewithesandlr, _taskcontinuewithnotonanything, _taskctorlrandsr, _taskdelayinvaliddelay, _taskdelayinvalidmillisecondsdelay, _taskdisposenotcompleted, _taskfromasynclongrunning, _taskfromasyncpreferfairness, _taskmultitaskcontinuationemptytasklist, _taskmultitaskcontinuationfireoptions;
    IMessageDescription? _taskmultitaskcontinuationnulltask, _taskrunsynchronouslyalreadystarted, _taskrunsynchronouslycontinuation, _taskrunsynchronouslypromise, _taskrunsynchronouslytaskcompleted, _taskstartalreadystarted, _taskstartcontinuationtask, _taskstartpromise, _taskstarttaskcompleted, _taskthrowifdisposed;
    IMessageDescription? _taskwaitmultinulltask, _taskcanceledexceptionctordefaultmessage, _taskcompletionsourcettrysetexceptionnoexceptions, _taskcompletionsourcettrysetexceptionnullexception, _taskexceptionholderunhandledexception, _taskexceptionholderunknownexceptiontype, _taskschedulerexecutetaskwrongtaskscheduler, _taskschedulerfromcurrentsynchronizationcontextnocurrent, _taskschedulerinconsistentstateaftertryexecutetaskinline, _taskschedulerexceptionctordefaultmessage;
    IMessageDescription? _tasktctorselfreplicating, _tasktdebuggernoresult, _taskttransitiontofinalalreadycompleted, _taskawaitertasknotcompleted, _taskschedulerexecutetasktaskalreadyexecuted, _tasktsetexceptionhasaninitializer, _taskfromasyncselfreplicating, _taskfromasynctaskmanagershutdown, _taskcompleted, _taskscheduled;
    IMessageDescription? _taskstarted, _taskwaitbegin, _taskwaitend;
    
    /// <summary>The specified TaskContinuationOptions combined LongRunning and ExecuteSynchronously. Synchronous continuations should not be long running.</summary>
    public IMessageDescription TaskContinueWithESandLR { get => _taskcontinuewithesandlr!; set => this.AssertWritable()._taskcontinuewithesandlr = value; }
    /// <summary>The specified TaskContinuationOptions excluded all continuation kinds.</summary>
    public IMessageDescription TaskContinueWithNotOnAnything { get => _taskcontinuewithnotonanything!; set => this.AssertWritable()._taskcontinuewithnotonanything = value; }
    /// <summary>(Internal)An attempt was made to create a LongRunning SelfReplicating task.</summary>
    public IMessageDescription TaskctorLRandSR { get => _taskctorlrandsr!; set => this.AssertWritable()._taskctorlrandsr = value; }
    /// <summary>The value needs to translate in milliseconds to -1 (signifying an infinite timeout), 0 or a positive integer less than or equal to Int32.MaxValue.</summary>
    public IMessageDescription TaskDelayInvalidDelay { get => _taskdelayinvaliddelay!; set => this.AssertWritable()._taskdelayinvaliddelay = value; }
    /// <summary>The value needs to be either -1 (signifying an infinite timeout), 0 or a positive integer.</summary>
    public IMessageDescription TaskDelayInvalidMillisecondsDelay { get => _taskdelayinvalidmillisecondsdelay!; set => this.AssertWritable()._taskdelayinvalidmillisecondsdelay = value; }
    /// <summary>A task may only be disposed if it is in a completion state (RanToCompletion, Faulted or Canceled).</summary>
    public IMessageDescription TaskDisposeNotCompleted { get => _taskdisposenotcompleted!; set => this.AssertWritable()._taskdisposenotcompleted = value; }
    /// <summary>It is invalid to specify TaskCreationOptions.LongRunning in calls to FromAsync.</summary>
    public IMessageDescription TaskFromAsyncLongRunning { get => _taskfromasynclongrunning!; set => this.AssertWritable()._taskfromasynclongrunning = value; }
    /// <summary>It is invalid to specify TaskCreationOptions.PreferFairness in calls to FromAsync.</summary>
    public IMessageDescription TaskFromAsyncPreferFairness { get => _taskfromasyncpreferfairness!; set => this.AssertWritable()._taskfromasyncpreferfairness = value; }
    /// <summary>The tasks argument contains no tasks.</summary>
    public IMessageDescription TaskMultiTaskContinuationEmptyTaskList { get => _taskmultitaskcontinuationemptytasklist!; set => this.AssertWritable()._taskmultitaskcontinuationemptytasklist = value; }
    /// <summary>It is invalid to exclude specific continuation kinds for continuations off of multiple tasks.</summary>
    public IMessageDescription TaskMultiTaskContinuationFireOptions { get => _taskmultitaskcontinuationfireoptions!; set => this.AssertWritable()._taskmultitaskcontinuationfireoptions = value; }
    /// <summary>The tasks argument included a null value.</summary>
    public IMessageDescription TaskMultiTaskContinuationNullTask { get => _taskmultitaskcontinuationnulltask!; set => this.AssertWritable()._taskmultitaskcontinuationnulltask = value; }
    /// <summary>RunSynchronously may not be called on a task that was already started.</summary>
    public IMessageDescription TaskRunSynchronouslyAlreadyStarted { get => _taskrunsynchronouslyalreadystarted!; set => this.AssertWritable()._taskrunsynchronouslyalreadystarted = value; }
    /// <summary>RunSynchronously may not be called on a continuation task.</summary>
    public IMessageDescription TaskRunSynchronouslyContinuation { get => _taskrunsynchronouslycontinuation!; set => this.AssertWritable()._taskrunsynchronouslycontinuation = value; }
    /// <summary>RunSynchronously may not be called on a task not bound to a delegate, such as the task returned from an asynchronous method.</summary>
    public IMessageDescription TaskRunSynchronouslyPromise { get => _taskrunsynchronouslypromise!; set => this.AssertWritable()._taskrunsynchronouslypromise = value; }
    /// <summary>RunSynchronously may not be called on a task that has already completed.</summary>
    public IMessageDescription TaskRunSynchronouslyTaskCompleted { get => _taskrunsynchronouslytaskcompleted!; set => this.AssertWritable()._taskrunsynchronouslytaskcompleted = value; }
    /// <summary>Start may not be called on a task that was already started.</summary>
    public IMessageDescription TaskStartAlreadyStarted { get => _taskstartalreadystarted!; set => this.AssertWritable()._taskstartalreadystarted = value; }
    /// <summary>Start may not be called on a continuation task.</summary>
    public IMessageDescription TaskStartContinuationTask { get => _taskstartcontinuationtask!; set => this.AssertWritable()._taskstartcontinuationtask = value; }
    /// <summary>Start may not be called on a promise-style task.</summary>
    public IMessageDescription TaskStartPromise { get => _taskstartpromise!; set => this.AssertWritable()._taskstartpromise = value; }
    /// <summary>Start may not be called on a task that has completed.</summary>
    public IMessageDescription TaskStartTaskCompleted { get => _taskstarttaskcompleted!; set => this.AssertWritable()._taskstarttaskcompleted = value; }
    /// <summary>The task has been disposed.</summary>
    public IMessageDescription TaskThrowIfDisposed { get => _taskthrowifdisposed!; set => this.AssertWritable()._taskthrowifdisposed = value; }
    /// <summary>The tasks array included at least one null element.</summary>
    public IMessageDescription TaskWaitMultiNullTask { get => _taskwaitmultinulltask!; set => this.AssertWritable()._taskwaitmultinulltask = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskCanceledExceptionctorDefaultMessage { get => _taskcanceledexceptionctordefaultmessage!; set => this.AssertWritable()._taskcanceledexceptionctordefaultmessage = value; }
    /// <summary>The exceptions collection was empty.</summary>
    public IMessageDescription TaskCompletionSourceTTrySetExceptionNoExceptions { get => _taskcompletionsourcettrysetexceptionnoexceptions!; set => this.AssertWritable()._taskcompletionsourcettrysetexceptionnoexceptions = value; }
    /// <summary>The exceptions collection included at least one null element.</summary>
    public IMessageDescription TaskCompletionSourceTTrySetExceptionNullException { get => _taskcompletionsourcettrysetexceptionnullexception!; set => this.AssertWritable()._taskcompletionsourcettrysetexceptionnullexception = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskExceptionHolderUnhandledException { get => _taskexceptionholderunhandledexception!; set => this.AssertWritable()._taskexceptionholderunhandledexception = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskExceptionHolderUnknownExceptionType { get => _taskexceptionholderunknownexceptiontype!; set => this.AssertWritable()._taskexceptionholderunknownexceptiontype = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskSchedulerExecuteTaskWrongTaskScheduler { get => _taskschedulerexecutetaskwrongtaskscheduler!; set => this.AssertWritable()._taskschedulerexecutetaskwrongtaskscheduler = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskSchedulerFromCurrentSynchronizationContextNoCurrent { get => _taskschedulerfromcurrentsynchronizationcontextnocurrent!; set => this.AssertWritable()._taskschedulerfromcurrentsynchronizationcontextnocurrent = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskSchedulerInconsistentStateAfterTryExecuteTaskInline { get => _taskschedulerinconsistentstateaftertryexecutetaskinline!; set => this.AssertWritable()._taskschedulerinconsistentstateaftertryexecutetaskinline = value; }
    /// <summary>System.Threading.Tasks</summary>
    public IMessageDescription TaskSchedulerExceptionctorDefaultMessage { get => _taskschedulerexceptionctordefaultmessage!; set => this.AssertWritable()._taskschedulerexceptionctordefaultmessage = value; }
    /// <summary>It is invalid to specify TaskCreationOptions.SelfReplicating for a Task&lt;TResult&gt;.</summary>
    public IMessageDescription TaskTctorSelfReplicating { get => _tasktctorselfreplicating!; set => this.AssertWritable()._tasktctorselfreplicating = value; }
    /// <summary>{Not yet computed}</summary>
    public IMessageDescription TaskTDebuggerNoResult { get => _tasktdebuggernoresult!; set => this.AssertWritable()._tasktdebuggernoresult = value; }
    /// <summary>An attempt was made to transition a task to a final state when it had already completed.</summary>
    public IMessageDescription TaskTTransitionToFinalAlreadyCompleted { get => _taskttransitiontofinalalreadycompleted!; set => this.AssertWritable()._taskttransitiontofinalalreadycompleted = value; }
    /// <summary>The awaited task has not yet completed.</summary>
    public IMessageDescription TaskAwaiterTaskNotCompleted { get => _taskawaitertasknotcompleted!; set => this.AssertWritable()._taskawaitertasknotcompleted = value; }
    /// <summary>ExecuteTask may not be called for a task which was already executed.</summary>
    public IMessageDescription TaskSchedulerExecuteTaskTaskAlreadyExecuted { get => _taskschedulerexecutetasktaskalreadyexecuted!; set => this.AssertWritable()._taskschedulerexecutetasktaskalreadyexecuted = value; }
    /// <summary>A task&#39;s Exception may only be set directly if the task was created without a function.</summary>
    public IMessageDescription TaskTSetExceptionHasAnInitializer { get => _tasktsetexceptionhasaninitializer!; set => this.AssertWritable()._tasktsetexceptionhasaninitializer = value; }
    /// <summary>It is invalid to specify TaskCreationOptions.SelfReplicating in calls to FromAsync.</summary>
    public IMessageDescription TaskFromAsyncSelfReplicating { get => _taskfromasyncselfreplicating!; set => this.AssertWritable()._taskfromasyncselfreplicating = value; }
    /// <summary>FromAsync was called with a TaskManager that had already shut down.</summary>
    public IMessageDescription TaskFromAsyncTaskManagerShutDown { get => _taskfromasynctaskmanagershutdown!; set => this.AssertWritable()._taskfromasynctaskmanagershutdown = value; }
    /// <summary>Task {2} completed.</summary>
    public IMessageDescription TaskCompleted { get => _taskcompleted!; set => this.AssertWritable()._taskcompleted = value; }
    /// <summary>Task {2} scheduled to TaskScheduler {0}.</summary>
    public IMessageDescription TaskScheduled { get => _taskscheduled!; set => this.AssertWritable()._taskscheduled = value; }
    /// <summary>Task {2} executing.</summary>
    public IMessageDescription TaskStarted { get => _taskstarted!; set => this.AssertWritable()._taskstarted = value; }
    /// <summary>Beginning wait ({3}) on Task {2}.</summary>
    public IMessageDescription TaskWaitBegin { get => _taskwaitbegin!; set => this.AssertWritable()._taskwaitbegin = value; }
    /// <summary>Ending wait on Task {2}.</summary>
    public IMessageDescription TaskWaitEnd { get => _taskwaitend!; set => this.AssertWritable()._taskwaitend = value; }

    /// <summary>Initialize fields</summary>
    public override TaskMessages Initialize() 
    {
        base.Initialize();
        Add(_taskcontinuewithesandlr = new MessageDescription("mscorlib.Task_ContinueWith_ESandLR", 0xA34505D3, new ParameterlessText("The specified TaskContinuationOptions combined LongRunning and ExecuteSynchronously.  Synchronous continuations should not be long running.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskcontinuewithnotonanything = new MessageDescription("mscorlib.Task_ContinueWith_NotOnAnything", 0xA34505D4, new ParameterlessText("The specified TaskContinuationOptions excluded all continuation kinds.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskctorlrandsr = new MessageDescription("mscorlib.Task_ctor_LRandSR", 0xA34505D5, new ParameterlessText("(Internal)An attempt was made to create a LongRunning SelfReplicating task.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskdelayinvaliddelay = new MessageDescription("mscorlib.Task_Delay_InvalidDelay", 0xA34505D6, new ParameterlessText("The value needs to translate in milliseconds to -1 (signifying an infinite timeout), 0 or a positive integer less than or equal to Int32.MaxValue.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskdelayinvalidmillisecondsdelay = new MessageDescription("mscorlib.Task_Delay_InvalidMillisecondsDelay", 0xA34505D7, new ParameterlessText("The value needs to be either -1 (signifying an infinite timeout), 0 or a positive integer.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskdisposenotcompleted = new MessageDescription("mscorlib.Task_Dispose_NotCompleted", 0xA34505D8, new ParameterlessText("A task may only be disposed if it is in a completion state (RanToCompletion, Faulted or Canceled).")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskfromasynclongrunning = new MessageDescription("mscorlib.Task_FromAsync_LongRunning", 0xA34505D9, new ParameterlessText("It is invalid to specify TaskCreationOptions.LongRunning in calls to FromAsync.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskfromasyncpreferfairness = new MessageDescription("mscorlib.Task_FromAsync_PreferFairness", 0xA34505DA, new ParameterlessText("It is invalid to specify TaskCreationOptions.PreferFairness in calls to FromAsync.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskmultitaskcontinuationemptytasklist = new MessageDescription("mscorlib.Task_MultiTaskContinuation_EmptyTaskList", 0xA34505DB, new ParameterlessText("The tasks argument contains no tasks.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_taskmultitaskcontinuationfireoptions = new MessageDescription("mscorlib.Task_MultiTaskContinuation_FireOptions", 0xA34505DC, new ParameterlessText("It is invalid to exclude specific continuation kinds for continuations off of multiple tasks.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskmultitaskcontinuationnulltask = new MessageDescription("mscorlib.Task_MultiTaskContinuation_NullTask", 0xA34505DD, new ParameterlessText("The tasks argument included a null value.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_taskrunsynchronouslyalreadystarted = new MessageDescription("mscorlib.Task_RunSynchronously_AlreadyStarted", 0xA34505DE, new ParameterlessText("RunSynchronously may not be called on a task that was already started.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskrunsynchronouslycontinuation = new MessageDescription("mscorlib.Task_RunSynchronously_Continuation", 0xA34505DF, new ParameterlessText("RunSynchronously may not be called on a continuation task.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskrunsynchronouslypromise = new MessageDescription("mscorlib.Task_RunSynchronously_Promise", 0xA34505E0, new ParameterlessText("RunSynchronously may not be called on a task not bound to a delegate, such as the task returned from an asynchronous method.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskrunsynchronouslytaskcompleted = new MessageDescription("mscorlib.Task_RunSynchronously_TaskCompleted", 0xA34505E1, new ParameterlessText("RunSynchronously may not be called on a task that has already completed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskstartalreadystarted = new MessageDescription("mscorlib.Task_Start_AlreadyStarted", 0xA34505E2, new ParameterlessText("Start may not be called on a task that was already started.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskstartcontinuationtask = new MessageDescription("mscorlib.Task_Start_ContinuationTask", 0xA34505E3, new ParameterlessText("Start may not be called on a continuation task.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskstartpromise = new MessageDescription("mscorlib.Task_Start_Promise", 0xA34505E4, new ParameterlessText("Start may not be called on a promise-style task.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskstarttaskcompleted = new MessageDescription("mscorlib.Task_Start_TaskCompleted", 0xA34505E5, new ParameterlessText("Start may not be called on a task that has completed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskthrowifdisposed = new MessageDescription("mscorlib.Task_ThrowIfDisposed", 0xA34505E6, new ParameterlessText("The task has been disposed.")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_taskwaitmultinulltask = new MessageDescription("mscorlib.Task_WaitMulti_NullTask", 0xA34505E7, new ParameterlessText("The tasks array included at least one null element.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_taskcanceledexceptionctordefaultmessage = new MessageDescription("mscorlib.TaskCanceledException_ctor_DefaultMessage", 0xA34505E8, new ParameterlessText("A task was canceled.")).SetHResult(0x8013153B).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.Threading.Tasks.TaskCanceledException)));
        Add(_taskcompletionsourcettrysetexceptionnoexceptions = new MessageDescription("mscorlib.TaskCompletionSourceT_TrySetException_NoExceptions", 0xA34505E9, new ParameterlessText("The exceptions collection was empty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_taskcompletionsourcettrysetexceptionnullexception = new MessageDescription("mscorlib.TaskCompletionSourceT_TrySetException_NullException", 0xA34505EA, new ParameterlessText("The exceptions collection included at least one null element.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_taskexceptionholderunhandledexception = new MessageDescription("mscorlib.TaskExceptionHolder_UnhandledException", 0xA34505EB, new ParameterlessText("A Task's exception(s) were not observed either by Waiting on the Task or accessing its Exception property. As a result, the unobserved exception was rethrown by the finalizer thread.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.AggregateException)));
        Add(_taskexceptionholderunknownexceptiontype = new MessageDescription("mscorlib.TaskExceptionHolder_UnknownExceptionType", 0xA34505EC, new ParameterlessText("(Internal)Expected an Exception or an IEnumerable<Exception>")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.ArgumentException)));
        Add(_taskschedulerexecutetaskwrongtaskscheduler = new MessageDescription("mscorlib.TaskScheduler_ExecuteTask_WrongTaskScheduler", 0xA34505ED, new ParameterlessText("ExecuteTask may not be called for a task which was previously queued to a different TaskScheduler.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.InvalidOperationException)));
        Add(_taskschedulerfromcurrentsynchronizationcontextnocurrent = new MessageDescription("mscorlib.TaskScheduler_FromCurrentSynchronizationContext_NoCurrent", 0xA34505EE, new ParameterlessText("The current SynchronizationContext may not be used as a TaskScheduler.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.InvalidOperationException)));
        Add(_taskschedulerinconsistentstateaftertryexecutetaskinline = new MessageDescription("mscorlib.TaskScheduler_InconsistentStateAfterTryExecuteTaskInline", 0xA34505EF, new ParameterlessText("The TryExecuteTaskInline call to the underlying scheduler succeeded, but the task body was not invoked.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.InvalidOperationException)));
        Add(_taskschedulerexceptionctordefaultmessage = new MessageDescription("mscorlib.TaskSchedulerException_ctor_DefaultMessage", 0xA34505F0, new ParameterlessText("An exception was thrown by a TaskScheduler.")).SetHResult(0x80131500).SetSeverity(MessageLevel.Error).SetDescription("System.Threading.Tasks").SetException(typeof(System.Threading.Tasks.TaskSchedulerException)));
        Add(_tasktctorselfreplicating = new MessageDescription("mscorlib.TaskT_ctor_SelfReplicating", 0xA34505F1, new ParameterlessText("It is invalid to specify TaskCreationOptions.SelfReplicating for a Task<TResult>.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_tasktdebuggernoresult = new MessageDescription("mscorlib.TaskT_DebuggerNoResult", 0xA34505F2, new ParameterlessText("{Not yet computed}")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_taskttransitiontofinalalreadycompleted = new MessageDescription("mscorlib.TaskT_TransitionToFinal_AlreadyCompleted", 0xA34505F3, new ParameterlessText("An attempt was made to transition a task to a final state when it had already completed.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_taskawaitertasknotcompleted = new MessageDescription("mscorlib.TaskAwaiter_TaskNotCompleted", 0xA345076A, new ParameterlessText("The awaited task has not yet completed.")).SetSeverity(MessageLevel.Error));
        Add(_taskschedulerexecutetasktaskalreadyexecuted = new MessageDescription("mscorlib.TaskScheduler_ExecuteTask_TaskAlreadyExecuted", 0xA345076E, new ParameterlessText("ExecuteTask may not be called for a task which was already executed.")).SetSeverity(MessageLevel.Error));
        Add(_tasktsetexceptionhasaninitializer = new MessageDescription("mscorlib.TaskT_SetException_HasAnInitializer", 0xA345076B, new ParameterlessText("A task's Exception may only be set directly if the task was created without a function.")).SetSeverity(MessageLevel.Error));
        Add(_taskfromasyncselfreplicating = new MessageDescription("mscorlib.Task_FromAsync_SelfReplicating", 0xA345076D, new ParameterlessText("It is invalid to specify TaskCreationOptions.SelfReplicating in calls to FromAsync.")).SetSeverity(MessageLevel.Error));
        Add(_taskfromasynctaskmanagershutdown = new MessageDescription("mscorlib.Task_FromAsync_TaskManagerShutDown", 0xA345076C, new ParameterlessText("FromAsync was called with a TaskManager that had already shut down.")).SetSeverity(MessageLevel.Error));
        Add(_taskcompleted = new MessageDescription("mscorlib.event_TaskCompleted", 0xA3450777, new FormatText("Task {2} completed.")).SetSeverity(MessageLevel.Error));
        Add(_taskscheduled = new MessageDescription("mscorlib.event_TaskScheduled", 0xA3450775, new FormatText("Task {2} scheduled to TaskScheduler {0}.")).SetSeverity(MessageLevel.Error));
        Add(_taskstarted = new MessageDescription("mscorlib.event_TaskStarted", 0xA3450776, new FormatText("Task {2} executing.")).SetSeverity(MessageLevel.Error));
        Add(_taskwaitbegin = new MessageDescription("mscorlib.event_TaskWaitBegin", 0xA3450778, new FormatText("Beginning wait ({3}) on Task {2}.")).SetSeverity(MessageLevel.Error));
        Add(_taskwaitend = new MessageDescription("mscorlib.event_TaskWaitEnd", 0xA3450779, new FormatText("Ending wait on Task {2}.")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
