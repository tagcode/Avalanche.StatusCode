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

/// <summary>System.Collections.*</summary>
public class CollectionsMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<CollectionsMessages> instance = new Lazy<CollectionsMessages>(() => new CollectionsMessages().Initialize().SetAllReadOnly<CollectionsMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static CollectionsMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0019;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _keynotfound, _concurrentcollectionsyncrootnotsupported, _concurrentdictionaryarrayincorrecttype, _concurrentdictionaryarraynotlargeenough, _concurrentdictionarycapacitymustnotbenegative, _concurrentdictionaryconcurrencylevelmustbepositive, _concurrentdictionaryindexisnegative, _concurrentdictionaryitemkeyisnull, _concurrentdictionarykeyalreadyexisted, _concurrentdictionarysourcecontainsduplicatekeys;
    IMessageDescription? _concurrentdictionarytypeofkeyincorrect, _concurrentdictionarytypeofvalueincorrect, _concurrentstackpushpoprangecountoutofrange, _concurrentstackpushpoprangeinvalidcount, _concurrentstackpushpoprangestartoutofrange, _getpartitionswrongnumberofpartitions, _dynamicpartitionsnotsupported, _cannotcallgetenumeratoraftersourcehasbeendisposed, _currentcalledbeforemovenext, _concurrentstackqueueondeserializationnodata;
    IMessageDescription? _concurrentbagtrypeeksteals, _concurrentbagtrytakesteals, _concurrentdictionaryacquiringalllocks, _concurrentstackfastpopfailed, _concurrentstackfastpushfailed;
    
    /// <summary>System.Collections.Generic</summary>
    public IMessageDescription KeyNotFound { get => _keynotfound!; set => this.AssertWritable()._keynotfound = value; }
    /// <summary>The SyncRoot property may not be used for the synchronization of concurrent collections.</summary>
    public IMessageDescription ConcurrentCollectionSyncRootNotSupported { get => _concurrentcollectionsyncrootnotsupported!; set => this.AssertWritable()._concurrentcollectionsyncrootnotsupported = value; }
    /// <summary>The array is multidimensional, or the type parameter for the set cannot be cast automatically to the type of the destination array.</summary>
    public IMessageDescription ConcurrentDictionaryArrayIncorrectType { get => _concurrentdictionaryarrayincorrecttype!; set => this.AssertWritable()._concurrentdictionaryarrayincorrecttype = value; }
    /// <summary>The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.</summary>
    public IMessageDescription ConcurrentDictionaryArrayNotLargeEnough { get => _concurrentdictionaryarraynotlargeenough!; set => this.AssertWritable()._concurrentdictionaryarraynotlargeenough = value; }
    /// <summary>The capacity argument must be greater than or equal to zero.</summary>
    public IMessageDescription ConcurrentDictionaryCapacityMustNotBeNegative { get => _concurrentdictionarycapacitymustnotbenegative!; set => this.AssertWritable()._concurrentdictionarycapacitymustnotbenegative = value; }
    /// <summary>The concurrencyLevel argument must be positive.</summary>
    public IMessageDescription ConcurrentDictionaryConcurrencyLevelMustBePositive { get => _concurrentdictionaryconcurrencylevelmustbepositive!; set => this.AssertWritable()._concurrentdictionaryconcurrencylevelmustbepositive = value; }
    /// <summary>The index argument is less than zero.</summary>
    public IMessageDescription ConcurrentDictionaryIndexIsNegative { get => _concurrentdictionaryindexisnegative!; set => this.AssertWritable()._concurrentdictionaryindexisnegative = value; }
    /// <summary>TKey is a reference type and item.Key is null.</summary>
    public IMessageDescription ConcurrentDictionaryItemKeyIsNull { get => _concurrentdictionaryitemkeyisnull!; set => this.AssertWritable()._concurrentdictionaryitemkeyisnull = value; }
    /// <summary>The key already existed in the dictionary.</summary>
    public IMessageDescription ConcurrentDictionaryKeyAlreadyExisted { get => _concurrentdictionarykeyalreadyexisted!; set => this.AssertWritable()._concurrentdictionarykeyalreadyexisted = value; }
    /// <summary>The source argument contains duplicate keys.</summary>
    public IMessageDescription ConcurrentDictionarySourceContainsDuplicateKeys { get => _concurrentdictionarysourcecontainsduplicatekeys!; set => this.AssertWritable()._concurrentdictionarysourcecontainsduplicatekeys = value; }
    /// <summary>The key was of an incorrect type for this dictionary.</summary>
    public IMessageDescription ConcurrentDictionaryTypeOfKeyIncorrect { get => _concurrentdictionarytypeofkeyincorrect!; set => this.AssertWritable()._concurrentdictionarytypeofkeyincorrect = value; }
    /// <summary>The value was of an incorrect type for this dictionary.</summary>
    public IMessageDescription ConcurrentDictionaryTypeOfValueIncorrect { get => _concurrentdictionarytypeofvalueincorrect!; set => this.AssertWritable()._concurrentdictionarytypeofvalueincorrect = value; }
    /// <summary>The count argument must be greater than or equal to zero.</summary>
    public IMessageDescription ConcurrentStackPushPopRangeCountOutOfRange { get => _concurrentstackpushpoprangecountoutofrange!; set => this.AssertWritable()._concurrentstackpushpoprangecountoutofrange = value; }
    /// <summary>The sum of the startIndex and count arguments must be less than or equal to the collection&#39;s Count.</summary>
    public IMessageDescription ConcurrentStackPushPopRangeInvalidCount { get => _concurrentstackpushpoprangeinvalidcount!; set => this.AssertWritable()._concurrentstackpushpoprangeinvalidcount = value; }
    /// <summary>The startIndex argument must be greater than or equal to zero.</summary>
    public IMessageDescription ConcurrentStackPushPopRangeStartOutOfRange { get => _concurrentstackpushpoprangestartoutofrange!; set => this.AssertWritable()._concurrentstackpushpoprangestartoutofrange = value; }
    /// <summary>GetPartitions returned an incorrect number of partitions.</summary>
    public IMessageDescription GetPartitionsWrongNumberOfPartitions { get => _getpartitionswrongnumberofpartitions!; set => this.AssertWritable()._getpartitionswrongnumberofpartitions = value; }
    /// <summary>Dynamic partitions are not supported by this partitioner.</summary>
    public IMessageDescription DynamicPartitionsNotSupported { get => _dynamicpartitionsnotsupported!; set => this.AssertWritable()._dynamicpartitionsnotsupported = value; }
    /// <summary>Can not call GetEnumerator on partitions after the source enumerable is disposed</summary>
    public IMessageDescription CanNotCallGetEnumeratorAfterSourceHasBeenDisposed { get => _cannotcallgetenumeratoraftersourcehasbeendisposed!; set => this.AssertWritable()._cannotcallgetenumeratoraftersourcehasbeendisposed = value; }
    /// <summary>MoveNext must be called at least once before calling Current.</summary>
    public IMessageDescription CurrentCalledBeforeMoveNext { get => _currentcalledbeforemovenext!; set => this.AssertWritable()._currentcalledbeforemovenext = value; }
    /// <summary>The serialization stream contains no elements.</summary>
    public IMessageDescription ConcurrentStackQueueOnDeserializationNoData { get => _concurrentstackqueueondeserializationnodata!; set => this.AssertWritable()._concurrentstackqueueondeserializationnodata = value; }
    /// <summary>ConcurrentBag stealing in TryPeek.</summary>
    public IMessageDescription ConcurrentBagTryPeekSteals { get => _concurrentbagtrypeeksteals!; set => this.AssertWritable()._concurrentbagtrypeeksteals = value; }
    /// <summary>ConcurrentBag stealing in TryTake.</summary>
    public IMessageDescription ConcurrentBagTryTakeSteals { get => _concurrentbagtrytakesteals!; set => this.AssertWritable()._concurrentbagtrytakesteals = value; }
    /// <summary>ConcurrentDictionary acquiring all locks on {0} bucket(s).</summary>
    public IMessageDescription ConcurrentDictionaryAcquiringAllLocks { get => _concurrentdictionaryacquiringalllocks!; set => this.AssertWritable()._concurrentdictionaryacquiringalllocks = value; }
    /// <summary>Pop from ConcurrentStack spun {0} time(s).</summary>
    public IMessageDescription ConcurrentStackFastPopFailed { get => _concurrentstackfastpopfailed!; set => this.AssertWritable()._concurrentstackfastpopfailed = value; }
    /// <summary>Push to ConcurrentStack spun {0} time(s).</summary>
    public IMessageDescription ConcurrentStackFastPushFailed { get => _concurrentstackfastpushfailed!; set => this.AssertWritable()._concurrentstackfastpushfailed = value; }

    /// <summary>Initialize fields</summary>
    public override CollectionsMessages Initialize() 
    {
        base.Initialize();
        Add(_keynotfound = new MessageDescription("mscorlib.Arg_KeyNotFound", 0xA3450086, new ParameterlessText("The given key was not present in the dictionary.")).SetHResult(0x80131577).SetSeverity(MessageLevel.Error).SetDescription("System.Collections.Generic").SetException(typeof(System.Collections.Generic.KeyNotFoundException)));
        Add(_concurrentcollectionsyncrootnotsupported = new MessageDescription("mscorlib.ConcurrentCollection_SyncRoot_NotSupported", 0xA34502EC, new ParameterlessText("The SyncRoot property may not be used for the synchronization of concurrent collections.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_concurrentdictionaryarrayincorrecttype = new MessageDescription("mscorlib.ConcurrentDictionary_ArrayIncorrectType", 0xA34502ED, new ParameterlessText("The array is multidimensional, or the type parameter for the set cannot be cast automatically to the type of the destination array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentdictionaryarraynotlargeenough = new MessageDescription("mscorlib.ConcurrentDictionary_ArrayNotLargeEnough", 0xA34502EE, new ParameterlessText("The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentdictionarycapacitymustnotbenegative = new MessageDescription("mscorlib.ConcurrentDictionary_CapacityMustNotBeNegative", 0xA34502EF, new ParameterlessText("The capacity argument must be greater than or equal to zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_concurrentdictionaryconcurrencylevelmustbepositive = new MessageDescription("mscorlib.ConcurrentDictionary_ConcurrencyLevelMustBePositive", 0xA34502F0, new ParameterlessText("The concurrencyLevel argument must be positive.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_concurrentdictionaryindexisnegative = new MessageDescription("mscorlib.ConcurrentDictionary_IndexIsNegative", 0xA34502F1, new ParameterlessText("The index argument is less than zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_concurrentdictionaryitemkeyisnull = new MessageDescription("mscorlib.ConcurrentDictionary_ItemKeyIsNull", 0xA34502F2, new ParameterlessText("TKey is a reference type and item.Key is null.")).SetHResult(0x80004003).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentNullException)));
        Add(_concurrentdictionarykeyalreadyexisted = new MessageDescription("mscorlib.ConcurrentDictionary_KeyAlreadyExisted", 0xA34502F3, new ParameterlessText("The key already existed in the dictionary.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentdictionarysourcecontainsduplicatekeys = new MessageDescription("mscorlib.ConcurrentDictionary_SourceContainsDuplicateKeys", 0xA34502F4, new ParameterlessText("The source argument contains duplicate keys.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentdictionarytypeofkeyincorrect = new MessageDescription("mscorlib.ConcurrentDictionary_TypeOfKeyIncorrect", 0xA34502F5, new ParameterlessText("The key was of an incorrect type for this dictionary.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentdictionarytypeofvalueincorrect = new MessageDescription("mscorlib.ConcurrentDictionary_TypeOfValueIncorrect", 0xA34502F6, new ParameterlessText("The value was of an incorrect type for this dictionary.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentstackpushpoprangecountoutofrange = new MessageDescription("mscorlib.ConcurrentStack_PushPopRange_CountOutOfRange", 0xA34502F7, new ParameterlessText("The count argument must be greater than or equal to zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_concurrentstackpushpoprangeinvalidcount = new MessageDescription("mscorlib.ConcurrentStack_PushPopRange_InvalidCount", 0xA34502F8, new ParameterlessText("The sum of the startIndex and count arguments must be less than or equal to the collection's Count.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_concurrentstackpushpoprangestartoutofrange = new MessageDescription("mscorlib.ConcurrentStack_PushPopRange_StartOutOfRange", 0xA34502F9, new ParameterlessText("The startIndex argument must be greater than or equal to zero.")).SetHResult(0x80131502).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentOutOfRangeException)));
        Add(_getpartitionswrongnumberofpartitions = new MessageDescription("mscorlib.OrderablePartitioner_GetPartitions_WrongNumberOfPartitions", 0xA34504AE, new ParameterlessText("GetPartitions returned an incorrect number of partitions.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_dynamicpartitionsnotsupported = new MessageDescription("mscorlib.Partitioner_DynamicPartitionsNotSupported", 0xA34504C7, new ParameterlessText("Dynamic partitions are not supported by this partitioner.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_cannotcallgetenumeratoraftersourcehasbeendisposed = new MessageDescription("mscorlib.PartitionerStatic_CanNotCallGetEnumeratorAfterSourceHasBeenDisposed", 0xA34504C8, new ParameterlessText("Can not call GetEnumerator on partitions after the source enumerable is disposed")).SetHResult(0x80131622).SetSeverity(MessageLevel.Error).SetException(typeof(System.ObjectDisposedException)));
        Add(_currentcalledbeforemovenext = new MessageDescription("mscorlib.PartitionerStatic_CurrentCalledBeforeMoveNext", 0xA34504C9, new ParameterlessText("MoveNext must be called at least once before calling Current.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_concurrentstackqueueondeserializationnodata = new MessageDescription("mscorlib.ConcurrentStackQueue_OnDeserialization_NoData", 0xA345075B, new ParameterlessText("The serialization stream contains no elements.")).SetSeverity(MessageLevel.Error));
        Add(_concurrentbagtrypeeksteals = new MessageDescription("mscorlib.event_ConcurrentBag_TryPeekSteals", 0xA3450760, new ParameterlessText("ConcurrentBag stealing in TryPeek.")).SetSeverity(MessageLevel.Error));
        Add(_concurrentbagtrytakesteals = new MessageDescription("mscorlib.event_ConcurrentBag_TryTakeSteals", 0xA345075F, new ParameterlessText("ConcurrentBag stealing in TryTake.")).SetSeverity(MessageLevel.Error));
        Add(_concurrentdictionaryacquiringalllocks = new MessageDescription("mscorlib.event_ConcurrentDictionary_AcquiringAllLocks", 0xA345075E, new FormatText("ConcurrentDictionary acquiring all locks on {0} bucket(s).")).SetSeverity(MessageLevel.Error));
        Add(_concurrentstackfastpopfailed = new MessageDescription("mscorlib.event_ConcurrentStack_FastPopFailed", 0xA345075D, new FormatText("Pop from ConcurrentStack spun {0} time(s).")).SetSeverity(MessageLevel.Error));
        Add(_concurrentstackfastpushfailed = new MessageDescription("mscorlib.event_ConcurrentStack_FastPushFailed", 0xA345075C, new FormatText("Push to ConcurrentStack spun {0} time(s).")).SetSeverity(MessageLevel.Error));
        return this;
    }    

}
