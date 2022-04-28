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

/// <summary>System.Security.Cryptography.*</summary>
public class CryptographyMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<CryptographyMessages> instance = new Lazy<CryptographyMessages>(() => new CryptographyMessages().Initialize().SetAllReadOnly<CryptographyMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static CryptographyMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x003C;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _argcryptographyexception, _addnulloremptyname, _algorithmtypesmustbevisible, _configencodedoiderror, _cryptostreamflushfinalblocktwice, _cspalgkeysizenotavailable, _cspalgorithmnotavailable, _cspcfbsizenotsupported, _cspnoprivatekey, _cspnotfound;
    IMessageDescription? _cspofbnotsupported, _cspwrongkeyspec, _hashalgorithmnamenullorempty, _hashkeyset, _hashnameset, _hashnotyetfinalized, _insufficientbuffer, _invalidblocksize, _invalidciphermode, _invalidfeedbacksize;
    IMessageDescription? _invalidfromxmlstring, _invalidhandle, _invalidhashsize, _invalidivsize, _invalidkeysemiweak, _invalidkeyweak, _invalidkeyparameter, _invalidkeysize, _invalidoid, _invalidoperation;
    IMessageDescription? _invalidpaddingmode, _legacynetcfcspcouldnotacquire, _legacynetcfunknownerror, _missingkey, _missingoid, _noncompliantfipsalgorithm, _notinteractive, _oaepdecoding, _paddingdecdatatoobig, _paddingencdatatoobig;
    IMessageDescription? _passwordderivedbytesfewbytessalt, _passwordderivedbytesinvalidalgorithm, _passwordderivedbytesinvalidiv, _passwordderivedbytestoomanybytes, _passwordderivedbytesvaluesfixed, _pkcs1decoding, _pkcs7invalidpadding, _rc2eks40, _rc2eksks, _rc2eksks2;
    IMessageDescription? _ssdinvaliddatasize, _sseinvaliddatasize, _unknownhashalgorithm, _x509exportfailed, _x509invalidcontenttype, _x509invalidflagcombination, _cssmerror, _cssmerrorunknown, _invaliddsasignaturesize, _paddingwin2kenhonly;
    
    /// <summary>System.Security.Cryptography</summary>
    public IMessageDescription ArgCryptographyException { get => _argcryptographyexception!; set => this.AssertWritable()._argcryptographyexception = value; }
    /// <summary>CryptoConfig cannot add a mapping for a null or empty name.</summary>
    public IMessageDescription AddNullOrEmptyName { get => _addnulloremptyname!; set => this.AssertWritable()._addnulloremptyname = value; }
    /// <summary>Algorithms added to CryptoConfig must be accessable from outside their assembly.</summary>
    public IMessageDescription AlgorithmTypesMustBeVisible { get => _algorithmtypesmustbevisible!; set => this.AssertWritable()._algorithmtypesmustbevisible = value; }
    /// <summary>Encoded OID length is too large (greater than 0x7f bytes).</summary>
    public IMessageDescription ConfigEncodedOIDError { get => _configencodedoiderror!; set => this.AssertWritable()._configencodedoiderror = value; }
    /// <summary>FlushFinalBlock() method was called twice on a CryptoStream. It can only be called once.</summary>
    public IMessageDescription CryptoStreamFlushFinalBlockTwice { get => _cryptostreamflushfinalblocktwice!; set => this.AssertWritable()._cryptostreamflushfinalblocktwice = value; }
    /// <summary>Algorithm implementation does not support a key size of {0}.</summary>
    public IMessageDescription CSPAlgKeySizeNotAvailable { get => _cspalgkeysizenotavailable!; set => this.AssertWritable()._cspalgkeysizenotavailable = value; }
    /// <summary>Cryptographic service provider (CSP) could not be found for this algorithm.</summary>
    public IMessageDescription CSPAlgorithmNotAvailable { get => _cspalgorithmnotavailable!; set => this.AssertWritable()._cspalgorithmnotavailable = value; }
    /// <summary>Feedback size for the cipher feedback mode (CFB) must be 8 bits.</summary>
    public IMessageDescription CSPCFBSizeNotSupported { get => _cspcfbsizenotsupported!; set => this.AssertWritable()._cspcfbsizenotsupported = value; }
    /// <summary>Object contains only the public half of a key pair. A private key must also be provided.</summary>
    public IMessageDescription CSPNoPrivateKey { get => _cspnoprivatekey!; set => this.AssertWritable()._cspnoprivatekey = value; }
    /// <summary>The requested key container was not found.</summary>
    public IMessageDescription CSPNotFound { get => _cspnotfound!; set => this.AssertWritable()._cspnotfound = value; }
    /// <summary>Output feedback mode (OFB) is not supported by this implementation.</summary>
    public IMessageDescription CSPOFBNotSupported { get => _cspofbnotsupported!; set => this.AssertWritable()._cspofbnotsupported = value; }
    /// <summary>The specified cryptographic service provider (CSP) does not support this key algorithm.</summary>
    public IMessageDescription CSPWrongKeySpec { get => _cspwrongkeyspec!; set => this.AssertWritable()._cspwrongkeyspec = value; }
    /// <summary>The hash algorithm name cannot be null or empty.</summary>
    public IMessageDescription HashAlgorithmNameNullOrEmpty { get => _hashalgorithmnamenullorempty!; set => this.AssertWritable()._hashalgorithmnamenullorempty = value; }
    /// <summary>Hash key cannot be changed after the first write to the stream.</summary>
    public IMessageDescription HashKeySet { get => _hashkeyset!; set => this.AssertWritable()._hashkeyset = value; }
    /// <summary>Hash name cannot be changed after the first write to the stream.</summary>
    public IMessageDescription HashNameSet { get => _hashnameset!; set => this.AssertWritable()._hashnameset = value; }
    /// <summary>Hash must be finalized before the hash value is retrieved.</summary>
    public IMessageDescription HashNotYetFinalized { get => _hashnotyetfinalized!; set => this.AssertWritable()._hashnotyetfinalized = value; }
    /// <summary>Input buffer contains insufficient data.</summary>
    public IMessageDescription InsufficientBuffer { get => _insufficientbuffer!; set => this.AssertWritable()._insufficientbuffer = value; }
    /// <summary>Specified block size is not valid for this algorithm.</summary>
    public IMessageDescription InvalidBlockSize { get => _invalidblocksize!; set => this.AssertWritable()._invalidblocksize = value; }
    /// <summary>Specified cipher mode is not valid for this algorithm.</summary>
    public IMessageDescription InvalidCipherMode { get => _invalidciphermode!; set => this.AssertWritable()._invalidciphermode = value; }
    /// <summary>Specified feedback size is invalid.</summary>
    public IMessageDescription InvalidFeedbackSize { get => _invalidfeedbacksize!; set => this.AssertWritable()._invalidfeedbacksize = value; }
    /// <summary>Input string does not contain a valid encoding of the &#39;{0}&#39; &#39;{1}&#39; parameter.</summary>
    public IMessageDescription InvalidFromXmlString { get => _invalidfromxmlstring!; set => this.AssertWritable()._invalidfromxmlstring = value; }
    /// <summary>{0} is an invalid handle.</summary>
    public IMessageDescription InvalidHandle { get => _invalidhandle!; set => this.AssertWritable()._invalidhandle = value; }
    /// <summary>{0} algorithm hash size is {1} bytes.</summary>
    public IMessageDescription InvalidHashSize { get => _invalidhashsize!; set => this.AssertWritable()._invalidhashsize = value; }
    /// <summary>Specified initialization vector (IV) does not match the block size for this algorithm.</summary>
    public IMessageDescription InvalidIVSize { get => _invalidivsize!; set => this.AssertWritable()._invalidivsize = value; }
    /// <summary>Specified key is a known semi-weak key for &#39;{0}&#39; and cannot be used.</summary>
    public IMessageDescription InvalidKeySemiWeak { get => _invalidkeysemiweak!; set => this.AssertWritable()._invalidkeysemiweak = value; }
    /// <summary>Specified key is a known weak key for &#39;{0}&#39; and cannot be used.</summary>
    public IMessageDescription InvalidKeyWeak { get => _invalidkeyweak!; set => this.AssertWritable()._invalidkeyweak = value; }
    /// <summary>Parameter &#39;{0}&#39; is not a valid key parameter.</summary>
    public IMessageDescription InvalidKeyParameter { get => _invalidkeyparameter!; set => this.AssertWritable()._invalidkeyparameter = value; }
    /// <summary>Specified key is not a valid size for this algorithm.</summary>
    public IMessageDescription InvalidKeySize { get => _invalidkeysize!; set => this.AssertWritable()._invalidkeysize = value; }
    /// <summary>Object identifier (OID) is unknown.</summary>
    public IMessageDescription InvalidOID { get => _invalidoid!; set => this.AssertWritable()._invalidoid = value; }
    /// <summary>This operation is not supported for this class.</summary>
    public IMessageDescription InvalidOperation { get => _invalidoperation!; set => this.AssertWritable()._invalidoperation = value; }
    /// <summary>Specified padding mode is not valid for this algorithm.</summary>
    public IMessageDescription InvalidPaddingMode { get => _invalidpaddingmode!; set => this.AssertWritable()._invalidpaddingmode = value; }
    /// <summary>System.Security.Cryptography</summary>
    public IMessageDescription LegacyNetCFCSPCouldNotAcquire { get => _legacynetcfcspcouldnotacquire!; set => this.AssertWritable()._legacynetcfcspcouldnotacquire = value; }
    /// <summary>System.Security.Cryptography</summary>
    public IMessageDescription LegacyNetCFUnknownError { get => _legacynetcfunknownerror!; set => this.AssertWritable()._legacynetcfunknownerror = value; }
    /// <summary>No asymmetric key object has been associated with this formatter object.</summary>
    public IMessageDescription MissingKey { get => _missingkey!; set => this.AssertWritable()._missingkey = value; }
    /// <summary>Required object identifier (OID) cannot be found.</summary>
    public IMessageDescription MissingOID { get => _missingoid!; set => this.AssertWritable()._missingoid = value; }
    /// <summary>This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms.</summary>
    public IMessageDescription NonCompliantFIPSAlgorithm { get => _noncompliantfipsalgorithm!; set => this.AssertWritable()._noncompliantfipsalgorithm = value; }
    /// <summary>The current session is not interactive.</summary>
    public IMessageDescription NotInteractive { get => _notinteractive!; set => this.AssertWritable()._notinteractive = value; }
    /// <summary>Error occurred while decoding OAEP padding.</summary>
    public IMessageDescription OAEPDecoding { get => _oaepdecoding!; set => this.AssertWritable()._oaepdecoding = value; }
    /// <summary>The data to be decrypted exceeds the maximum for this modulus of {0} bytes.</summary>
    public IMessageDescription PaddingDecDataTooBig { get => _paddingdecdatatoobig!; set => this.AssertWritable()._paddingdecdatatoobig = value; }
    /// <summary>The data to be encrypted exceeds the maximum for this modulus of {0} bytes.</summary>
    public IMessageDescription PaddingEncDataTooBig { get => _paddingencdatatoobig!; set => this.AssertWritable()._paddingencdatatoobig = value; }
    /// <summary>Salt is not at least eight bytes.</summary>
    public IMessageDescription PasswordDerivedBytesFewBytesSalt { get => _passwordderivedbytesfewbytessalt!; set => this.AssertWritable()._passwordderivedbytesfewbytessalt = value; }
    /// <summary>Algorithm is unavailable or is not supported for this operation.</summary>
    public IMessageDescription PasswordDerivedBytesInvalidAlgorithm { get => _passwordderivedbytesinvalidalgorithm!; set => this.AssertWritable()._passwordderivedbytesinvalidalgorithm = value; }
    /// <summary>The Initialization vector should have the same length as the algorithm block size in bytes.</summary>
    public IMessageDescription PasswordDerivedBytesInvalidIV { get => _passwordderivedbytesinvalidiv!; set => this.AssertWritable()._passwordderivedbytesinvalidiv = value; }
    /// <summary>Requested number of bytes exceeds the maximum.</summary>
    public IMessageDescription PasswordDerivedBytesTooManyBytes { get => _passwordderivedbytestoomanybytes!; set => this.AssertWritable()._passwordderivedbytestoomanybytes = value; }
    /// <summary>Value of &#39;{0}&#39; cannot be changed after the bytes have been retrieved.</summary>
    public IMessageDescription PasswordDerivedBytesValuesFixed { get => _passwordderivedbytesvaluesfixed!; set => this.AssertWritable()._passwordderivedbytesvaluesfixed = value; }
    /// <summary>Error occurred while decoding PKCS1 padding.</summary>
    public IMessageDescription PKCS1Decoding { get => _pkcs1decoding!; set => this.AssertWritable()._pkcs1decoding = value; }
    /// <summary>Padding is invalid and cannot be removed.</summary>
    public IMessageDescription PKCS7InvalidPadding { get => _pkcs7invalidpadding!; set => this.AssertWritable()._pkcs7invalidpadding = value; }
    /// <summary>EffectiveKeySize value must be at least 40 bits.</summary>
    public IMessageDescription RC2EKS40 { get => _rc2eks40!; set => this.AssertWritable()._rc2eks40 = value; }
    /// <summary>EffectiveKeySize value must be at least as large as the KeySize value.</summary>
    public IMessageDescription RC2EKSKS { get => _rc2eksks!; set => this.AssertWritable()._rc2eksks = value; }
    /// <summary>EffectiveKeySize must be the same as KeySize in this implementation.</summary>
    public IMessageDescription RC2EKSKS2 { get => _rc2eksks2!; set => this.AssertWritable()._rc2eksks2 = value; }
    /// <summary>Length of the data to decrypt is invalid.</summary>
    public IMessageDescription SSDInvalidDataSize { get => _ssdinvaliddatasize!; set => this.AssertWritable()._ssdinvaliddatasize = value; }
    /// <summary>Length of the data to encrypt is invalid.</summary>
    public IMessageDescription SSEInvalidDataSize { get => _sseinvaliddatasize!; set => this.AssertWritable()._sseinvaliddatasize = value; }
    /// <summary>&#39;{0}&#39; is not a known hash algorithm.</summary>
    public IMessageDescription UnknownHashAlgorithm { get => _unknownhashalgorithm!; set => this.AssertWritable()._unknownhashalgorithm = value; }
    /// <summary>The certificate export operation failed.</summary>
    public IMessageDescription X509ExportFailed { get => _x509exportfailed!; set => this.AssertWritable()._x509exportfailed = value; }
    /// <summary>Invalid content type.</summary>
    public IMessageDescription X509InvalidContentType { get => _x509invalidcontenttype!; set => this.AssertWritable()._x509invalidcontenttype = value; }
    /// <summary>The flags &#39;{0}&#39; may not be specified together.</summary>
    public IMessageDescription X509InvalidFlagCombination { get => _x509invalidflagcombination!; set => this.AssertWritable()._x509invalidflagcombination = value; }
    /// <summary>Error 0x{0} from the operating system security framework: &#39;{1}&#39;.</summary>
    public IMessageDescription CSSMError { get => _cssmerror!; set => this.AssertWritable()._cssmerror = value; }
    /// <summary>Error 0x{0} from the operating system security framework.</summary>
    public IMessageDescription CSSMErrorUnknown { get => _cssmerrorunknown!; set => this.AssertWritable()._cssmerrorunknown = value; }
    /// <summary>Length of the DSA signature was not 40 bytes.</summary>
    public IMessageDescription InvalidDSASignatureSize { get => _invaliddsasignaturesize!; set => this.AssertWritable()._invaliddsasignaturesize = value; }
    /// <summary>Direct Encryption and decryption using RSA are not available on this platform.</summary>
    public IMessageDescription PaddingWin2KEnhOnly { get => _paddingwin2kenhonly!; set => this.AssertWritable()._paddingwin2kenhonly = value; }

    /// <summary>Initialize fields</summary>
    public override CryptographyMessages Initialize() 
    {
        base.Initialize();
        Add(_argcryptographyexception = new MessageDescription("mscorlib.Arg_CryptographyException", 0xA345003C, new ParameterlessText("Error occurred during a cryptographic operation.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetDescription("System.Security.Cryptography").SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_addnulloremptyname = new MessageDescription("mscorlib.Cryptography_AddNullOrEmptyName", 0xA34502FD, new ParameterlessText("CryptoConfig cannot add a mapping for a null or empty name.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_algorithmtypesmustbevisible = new MessageDescription("mscorlib.Cryptography_AlgorithmTypesMustBeVisible", 0xA34502FE, new ParameterlessText("Algorithms added to CryptoConfig must be accessable from outside their assembly.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_configencodedoiderror = new MessageDescription("mscorlib.Cryptography_Config_EncodedOIDError", 0xA34502FF, new ParameterlessText("Encoded OID length is too large (greater than 0x7f bytes).")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_cryptostreamflushfinalblocktwice = new MessageDescription("mscorlib.Cryptography_CryptoStream_FlushFinalBlockTwice", 0xA3450300, new ParameterlessText("FlushFinalBlock() method was called twice on a CryptoStream. It can only be called once.")).SetHResult(0x80131515).SetSeverity(MessageLevel.Error).SetException(typeof(System.NotSupportedException)));
        Add(_cspalgkeysizenotavailable = new MessageDescription("mscorlib.Cryptography_CSP_AlgKeySizeNotAvailable", 0xA3450301, new FormatText("Algorithm implementation does not support a key size of {0}.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cspalgorithmnotavailable = new MessageDescription("mscorlib.Cryptography_CSP_AlgorithmNotAvailable", 0xA3450302, new ParameterlessText("Cryptographic service provider (CSP) could not be found for this algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cspcfbsizenotsupported = new MessageDescription("mscorlib.Cryptography_CSP_CFBSizeNotSupported", 0xA3450303, new ParameterlessText("Feedback size for the cipher feedback mode (CFB) must be 8 bits.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cspnoprivatekey = new MessageDescription("mscorlib.Cryptography_CSP_NoPrivateKey", 0xA3450304, new ParameterlessText("Object contains only the public half of a key pair. A private key must also be provided.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cspnotfound = new MessageDescription("mscorlib.Cryptography_CSP_NotFound", 0xA3450305, new ParameterlessText("The requested key container was not found.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cspofbnotsupported = new MessageDescription("mscorlib.Cryptography_CSP_OFBNotSupported", 0xA3450306, new ParameterlessText("Output feedback mode (OFB) is not supported by this implementation.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cspwrongkeyspec = new MessageDescription("mscorlib.Cryptography_CSP_WrongKeySpec", 0xA3450307, new ParameterlessText("The specified cryptographic service provider (CSP) does not support this key algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_hashalgorithmnamenullorempty = new MessageDescription("mscorlib.Cryptography_HashAlgorithmNameNullOrEmpty", 0xA3450308, new ParameterlessText("The hash algorithm name cannot be null or empty.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_hashkeyset = new MessageDescription("mscorlib.Cryptography_HashKeySet", 0xA3450309, new ParameterlessText("Hash key cannot be changed after the first write to the stream.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_hashnameset = new MessageDescription("mscorlib.Cryptography_HashNameSet", 0xA345030A, new ParameterlessText("Hash name cannot be changed after the first write to the stream.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_hashnotyetfinalized = new MessageDescription("mscorlib.Cryptography_HashNotYetFinalized", 0xA345030B, new ParameterlessText("Hash must be finalized before the hash value is retrieved.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_insufficientbuffer = new MessageDescription("mscorlib.Cryptography_InsufficientBuffer", 0xA345030C, new ParameterlessText("Input buffer contains insufficient data.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidblocksize = new MessageDescription("mscorlib.Cryptography_InvalidBlockSize", 0xA345030D, new ParameterlessText("Specified block size is not valid for this algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidciphermode = new MessageDescription("mscorlib.Cryptography_InvalidCipherMode", 0xA345030E, new ParameterlessText("Specified cipher mode is not valid for this algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidfeedbacksize = new MessageDescription("mscorlib.Cryptography_InvalidFeedbackSize", 0xA345030F, new ParameterlessText("Specified feedback size is invalid.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidfromxmlstring = new MessageDescription("mscorlib.Cryptography_InvalidFromXmlString", 0xA3450310, new FormatText("Input string does not contain a valid encoding of the '{0}' '{1}' parameter.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidhandle = new MessageDescription("mscorlib.Cryptography_InvalidHandle", 0xA3450311, new FormatText("{0} is an invalid handle.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidhashsize = new MessageDescription("mscorlib.Cryptography_InvalidHashSize", 0xA3450312, new FormatText("{0} algorithm hash size is {1} bytes.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidivsize = new MessageDescription("mscorlib.Cryptography_InvalidIVSize", 0xA3450313, new ParameterlessText("Specified initialization vector (IV) does not match the block size for this algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidkeysemiweak = new MessageDescription("mscorlib.Cryptography_InvalidKey_SemiWeak", 0xA3450314, new FormatText("Specified key is a known semi-weak key for '{0}' and cannot be used.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidkeyweak = new MessageDescription("mscorlib.Cryptography_InvalidKey_Weak", 0xA3450315, new FormatText("Specified key is a known weak key for '{0}' and cannot be used.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidkeyparameter = new MessageDescription("mscorlib.Cryptography_InvalidKeyParameter", 0xA3450316, new FormatText("Parameter '{0}' is not a valid key parameter.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidkeysize = new MessageDescription("mscorlib.Cryptography_InvalidKeySize", 0xA3450317, new ParameterlessText("Specified key is not a valid size for this algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invalidoid = new MessageDescription("mscorlib.Cryptography_InvalidOID", 0xA3450318, new ParameterlessText("Object identifier (OID) is unknown.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_invalidoperation = new MessageDescription("mscorlib.Cryptography_InvalidOperation", 0xA3450319, new ParameterlessText("This operation is not supported for this class.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_invalidpaddingmode = new MessageDescription("mscorlib.Cryptography_InvalidPaddingMode", 0xA345031A, new ParameterlessText("Specified padding mode is not valid for this algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_legacynetcfcspcouldnotacquire = new MessageDescription("mscorlib.Cryptography_LegacyNetCF_CSP_CouldNotAcquire", 0xA345031B, new ParameterlessText("CryptoAPI cryptographic service provider (CSP) for this implementation could not be acquired.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetDescription("System.Security.Cryptography").SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_legacynetcfunknownerror = new MessageDescription("mscorlib.Cryptography_LegacyNetCF_UnknownError", 0xA345031C, new FormatText("Unknown Error '{0}'.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetDescription("System.Security.Cryptography").SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_missingkey = new MessageDescription("mscorlib.Cryptography_MissingKey", 0xA345031D, new ParameterlessText("No asymmetric key object has been associated with this formatter object.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_missingoid = new MessageDescription("mscorlib.Cryptography_MissingOID", 0xA345031E, new ParameterlessText("Required object identifier (OID) cannot be found.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_noncompliantfipsalgorithm = new MessageDescription("mscorlib.Cryptography_NonCompliantFIPSAlgorithm", 0xA345031F, new ParameterlessText("This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_notinteractive = new MessageDescription("mscorlib.Cryptography_NotInteractive", 0xA3450320, new ParameterlessText("The current session is not interactive.")).SetHResult(0x80131509).SetSeverity(MessageLevel.Error).SetException(typeof(System.InvalidOperationException)));
        Add(_oaepdecoding = new MessageDescription("mscorlib.Cryptography_OAEPDecoding", 0xA3450321, new ParameterlessText("Error occurred while decoding OAEP padding.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_paddingdecdatatoobig = new MessageDescription("mscorlib.Cryptography_Padding_DecDataTooBig", 0xA3450322, new FormatText("The data to be decrypted exceeds the maximum for this modulus of {0} bytes.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_paddingencdatatoobig = new MessageDescription("mscorlib.Cryptography_Padding_EncDataTooBig", 0xA3450323, new FormatText("The data to be encrypted exceeds the maximum for this modulus of {0} bytes.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_passwordderivedbytesfewbytessalt = new MessageDescription("mscorlib.Cryptography_PasswordDerivedBytes_FewBytesSalt", 0xA3450324, new ParameterlessText("Salt is not at least eight bytes.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_passwordderivedbytesinvalidalgorithm = new MessageDescription("mscorlib.Cryptography_PasswordDerivedBytes_InvalidAlgorithm", 0xA3450325, new ParameterlessText("Algorithm is unavailable or is not supported for this operation.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_passwordderivedbytesinvalidiv = new MessageDescription("mscorlib.Cryptography_PasswordDerivedBytes_InvalidIV", 0xA3450326, new ParameterlessText("The Initialization vector should have the same length as the algorithm block size in bytes.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_passwordderivedbytestoomanybytes = new MessageDescription("mscorlib.Cryptography_PasswordDerivedBytes_TooManyBytes", 0xA3450327, new ParameterlessText("Requested number of bytes exceeds the maximum.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_passwordderivedbytesvaluesfixed = new MessageDescription("mscorlib.Cryptography_PasswordDerivedBytes_ValuesFixed", 0xA3450328, new FormatText("Value of '{0}' cannot be changed after the bytes have been retrieved.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_pkcs1decoding = new MessageDescription("mscorlib.Cryptography_PKCS1Decoding", 0xA3450329, new ParameterlessText("Error occurred while decoding PKCS1 padding.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_pkcs7invalidpadding = new MessageDescription("mscorlib.Cryptography_PKCS7_InvalidPadding", 0xA345032A, new ParameterlessText("Padding is invalid and cannot be removed.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_rc2eks40 = new MessageDescription("mscorlib.Cryptography_RC2_EKS40", 0xA345032B, new ParameterlessText("EffectiveKeySize value must be at least 40 bits.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_rc2eksks = new MessageDescription("mscorlib.Cryptography_RC2_EKSKS", 0xA345032C, new ParameterlessText("EffectiveKeySize value must be at least as large as the KeySize value.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_rc2eksks2 = new MessageDescription("mscorlib.Cryptography_RC2_EKSKS2", 0xA345032D, new ParameterlessText("EffectiveKeySize must be the same as KeySize in this implementation.")).SetHResult(0x80131431).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicUnexpectedOperationException)));
        Add(_ssdinvaliddatasize = new MessageDescription("mscorlib.Cryptography_SSD_InvalidDataSize", 0xA345032E, new ParameterlessText("Length of the data to decrypt is invalid.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_sseinvaliddatasize = new MessageDescription("mscorlib.Cryptography_SSE_InvalidDataSize", 0xA345032F, new ParameterlessText("Length of the data to encrypt is invalid.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_unknownhashalgorithm = new MessageDescription("mscorlib.Cryptography_UnknownHashAlgorithm", 0xA3450330, new FormatText("'{0}' is not a known hash algorithm.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_x509exportfailed = new MessageDescription("mscorlib.Cryptography_X509_ExportFailed", 0xA3450331, new ParameterlessText("The certificate export operation failed.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_x509invalidcontenttype = new MessageDescription("mscorlib.Cryptography_X509_InvalidContentType", 0xA3450332, new ParameterlessText("Invalid content type.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_x509invalidflagcombination = new MessageDescription("mscorlib.Cryptography_X509_InvalidFlagCombination", 0xA3450333, new FormatText("The flags '{0}' may not be specified together.")).SetHResult(0x80070057).SetSeverity(MessageLevel.Error).SetException(typeof(System.ArgumentException)));
        Add(_cssmerror = new MessageDescription("mscorlib.Cryptography_CSSM_Error", 0xA3450624, new FormatText("Error 0x{0} from the operating system security framework: '{1}'.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_cssmerrorunknown = new MessageDescription("mscorlib.Cryptography_CSSM_Error_Unknown", 0xA3450625, new FormatText("Error 0x{0} from the operating system security framework.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_invaliddsasignaturesize = new MessageDescription("mscorlib.Cryptography_InvalidDSASignatureSize", 0xA3450626, new ParameterlessText("Length of the DSA signature was not 40 bytes.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        Add(_paddingwin2kenhonly = new MessageDescription("mscorlib.Cryptography_Padding_Win2KEnhOnly", 0xA3450627, new ParameterlessText("Direct Encryption and decryption using RSA are not available on this platform.")).SetHResult(0x80131430).SetSeverity(MessageLevel.Error).SetException(typeof(System.Security.Cryptography.CryptographicException)));
        return this;
    }    

}
