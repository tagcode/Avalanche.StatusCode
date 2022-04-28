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

/// <summary>CodePage</summary>
public class CodePageMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<CodePageMessages> instance = new Lazy<CodePageMessages>(() => new CodePageMessages().Initialize().SetAllReadOnly<CodePageMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static CodePageMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0095;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? __10000, __10001, __10002, __10003, __10004, __10005, __10006, __10007, __10008, __10010;
    IMessageDescription? __10017, __10021, __10029, __10079, __10081, __10082, __1026, __1047, __1140, __1141;
    IMessageDescription? __1142, __1143, __1144, __1145, __1146, __1147, __1148, __1149, __1200, __12000;
    IMessageDescription? __12001, __1201, __1250, __1251, __1252, __1253, __1254, __1255, __1256, __1257;
    IMessageDescription? __1258, __1361, __20000, __20001, __20002, __20003, __20004, __20005, __20105, __20106;
    IMessageDescription? __20107, __20108, __20127, __20261, __20269, __20273, __20277, __20278, __20280, __20284;
    IMessageDescription? __20285, __20290, __20297, __20420, __20423, __20424, __20833, __20838, __20866, __20871;
    IMessageDescription? __20880, __20905, __20924, __20932, __20936, __20949, __21025, __21027, __21866, __28591;
    IMessageDescription? __28592, __28593, __28594, __28595, __28596, __28597, __28598, __28599, __28603, __28605;
    IMessageDescription? __29001, __37, __38598, __437, __500, __50000, __50220, __50221, __50222, __50225;
    IMessageDescription? __50227, __50229, __50930, __50931, __50933, __50935, __50937, __50939, __51932, __51936;
    IMessageDescription? __51949, __52936, __54936, __57002, __57003, __57004, __57005, __57006, __57007, __57008;
    IMessageDescription? __57009, __57010, __57011, __65000, __65001, __708, __720, __737, __775, __850;
    IMessageDescription? __852, __855, __857, __858, __860, __861, __862, __863, __864, __865;
    IMessageDescription? __866, __869, __870, __874, __875, __932, __936, __949, __950;
    
    /// <summary>Western European (Mac)</summary>
    public IMessageDescription _10000 { get => __10000!; set => this.AssertWritable().__10000 = value; }
    /// <summary>Japanese (Mac)</summary>
    public IMessageDescription _10001 { get => __10001!; set => this.AssertWritable().__10001 = value; }
    /// <summary>Chinese Traditional (Mac)</summary>
    public IMessageDescription _10002 { get => __10002!; set => this.AssertWritable().__10002 = value; }
    /// <summary>Korean (Mac)</summary>
    public IMessageDescription _10003 { get => __10003!; set => this.AssertWritable().__10003 = value; }
    /// <summary>Arabic (Mac)</summary>
    public IMessageDescription _10004 { get => __10004!; set => this.AssertWritable().__10004 = value; }
    /// <summary>Hebrew (Mac)</summary>
    public IMessageDescription _10005 { get => __10005!; set => this.AssertWritable().__10005 = value; }
    /// <summary>Greek (Mac)</summary>
    public IMessageDescription _10006 { get => __10006!; set => this.AssertWritable().__10006 = value; }
    /// <summary>Cyrillic (Mac)</summary>
    public IMessageDescription _10007 { get => __10007!; set => this.AssertWritable().__10007 = value; }
    /// <summary>Chinese Simplified (Mac)</summary>
    public IMessageDescription _10008 { get => __10008!; set => this.AssertWritable().__10008 = value; }
    /// <summary>Romanian (Mac)</summary>
    public IMessageDescription _10010 { get => __10010!; set => this.AssertWritable().__10010 = value; }
    /// <summary>Ukrainian (Mac)</summary>
    public IMessageDescription _10017 { get => __10017!; set => this.AssertWritable().__10017 = value; }
    /// <summary>Thai (Mac)</summary>
    public IMessageDescription _10021 { get => __10021!; set => this.AssertWritable().__10021 = value; }
    /// <summary>Central European (Mac)</summary>
    public IMessageDescription _10029 { get => __10029!; set => this.AssertWritable().__10029 = value; }
    /// <summary>Icelandic (Mac)</summary>
    public IMessageDescription _10079 { get => __10079!; set => this.AssertWritable().__10079 = value; }
    /// <summary>Turkish (Mac)</summary>
    public IMessageDescription _10081 { get => __10081!; set => this.AssertWritable().__10081 = value; }
    /// <summary>Croatian (Mac)</summary>
    public IMessageDescription _10082 { get => __10082!; set => this.AssertWritable().__10082 = value; }
    /// <summary>IBM EBCDIC (Turkish Latin-5)</summary>
    public IMessageDescription _1026 { get => __1026!; set => this.AssertWritable().__1026 = value; }
    /// <summary>IBM Latin-1</summary>
    public IMessageDescription _1047 { get => __1047!; set => this.AssertWritable().__1047 = value; }
    /// <summary>IBM EBCDIC (US-Canada-Euro)</summary>
    public IMessageDescription _1140 { get => __1140!; set => this.AssertWritable().__1140 = value; }
    /// <summary>IBM EBCDIC (Germany-Euro)</summary>
    public IMessageDescription _1141 { get => __1141!; set => this.AssertWritable().__1141 = value; }
    /// <summary>IBM EBCDIC (Denmark-Norway-Euro)</summary>
    public IMessageDescription _1142 { get => __1142!; set => this.AssertWritable().__1142 = value; }
    /// <summary>IBM EBCDIC (Finland-Sweden-Euro)</summary>
    public IMessageDescription _1143 { get => __1143!; set => this.AssertWritable().__1143 = value; }
    /// <summary>IBM EBCDIC (Italy-Euro)</summary>
    public IMessageDescription _1144 { get => __1144!; set => this.AssertWritable().__1144 = value; }
    /// <summary>IBM EBCDIC (Spain-Euro)</summary>
    public IMessageDescription _1145 { get => __1145!; set => this.AssertWritable().__1145 = value; }
    /// <summary>IBM EBCDIC (UK-Euro)</summary>
    public IMessageDescription _1146 { get => __1146!; set => this.AssertWritable().__1146 = value; }
    /// <summary>IBM EBCDIC (France-Euro)</summary>
    public IMessageDescription _1147 { get => __1147!; set => this.AssertWritable().__1147 = value; }
    /// <summary>IBM EBCDIC (International-Euro)</summary>
    public IMessageDescription _1148 { get => __1148!; set => this.AssertWritable().__1148 = value; }
    /// <summary>IBM EBCDIC (Icelandic-Euro)</summary>
    public IMessageDescription _1149 { get => __1149!; set => this.AssertWritable().__1149 = value; }
    /// <summary>Unicode</summary>
    public IMessageDescription _1200 { get => __1200!; set => this.AssertWritable().__1200 = value; }
    /// <summary>Unicode (UTF-32)</summary>
    public IMessageDescription _12000 { get => __12000!; set => this.AssertWritable().__12000 = value; }
    /// <summary>Unicode (UTF-32 Big-Endian)</summary>
    public IMessageDescription _12001 { get => __12001!; set => this.AssertWritable().__12001 = value; }
    /// <summary>Unicode (Big-Endian)</summary>
    public IMessageDescription _1201 { get => __1201!; set => this.AssertWritable().__1201 = value; }
    /// <summary>Central European (Windows)</summary>
    public IMessageDescription _1250 { get => __1250!; set => this.AssertWritable().__1250 = value; }
    /// <summary>Cyrillic (Windows)</summary>
    public IMessageDescription _1251 { get => __1251!; set => this.AssertWritable().__1251 = value; }
    /// <summary>Western European (Windows)</summary>
    public IMessageDescription _1252 { get => __1252!; set => this.AssertWritable().__1252 = value; }
    /// <summary>Greek (Windows)</summary>
    public IMessageDescription _1253 { get => __1253!; set => this.AssertWritable().__1253 = value; }
    /// <summary>Turkish (Windows)</summary>
    public IMessageDescription _1254 { get => __1254!; set => this.AssertWritable().__1254 = value; }
    /// <summary>Hebrew (Windows)</summary>
    public IMessageDescription _1255 { get => __1255!; set => this.AssertWritable().__1255 = value; }
    /// <summary>Arabic (Windows)</summary>
    public IMessageDescription _1256 { get => __1256!; set => this.AssertWritable().__1256 = value; }
    /// <summary>Baltic (Windows)</summary>
    public IMessageDescription _1257 { get => __1257!; set => this.AssertWritable().__1257 = value; }
    /// <summary>Vietnamese (Windows)</summary>
    public IMessageDescription _1258 { get => __1258!; set => this.AssertWritable().__1258 = value; }
    /// <summary>Korean (Johab)</summary>
    public IMessageDescription _1361 { get => __1361!; set => this.AssertWritable().__1361 = value; }
    /// <summary>Chinese Traditional (CNS)</summary>
    public IMessageDescription _20000 { get => __20000!; set => this.AssertWritable().__20000 = value; }
    /// <summary>TCA Taiwan</summary>
    public IMessageDescription _20001 { get => __20001!; set => this.AssertWritable().__20001 = value; }
    /// <summary>Chinese Traditional (Eten)</summary>
    public IMessageDescription _20002 { get => __20002!; set => this.AssertWritable().__20002 = value; }
    /// <summary>IBM5550 Taiwan</summary>
    public IMessageDescription _20003 { get => __20003!; set => this.AssertWritable().__20003 = value; }
    /// <summary>TeleText Taiwan</summary>
    public IMessageDescription _20004 { get => __20004!; set => this.AssertWritable().__20004 = value; }
    /// <summary>Wang Taiwan</summary>
    public IMessageDescription _20005 { get => __20005!; set => this.AssertWritable().__20005 = value; }
    /// <summary>Western European (IA5)</summary>
    public IMessageDescription _20105 { get => __20105!; set => this.AssertWritable().__20105 = value; }
    /// <summary>German (IA5)</summary>
    public IMessageDescription _20106 { get => __20106!; set => this.AssertWritable().__20106 = value; }
    /// <summary>Swedish (IA5)</summary>
    public IMessageDescription _20107 { get => __20107!; set => this.AssertWritable().__20107 = value; }
    /// <summary>Norwegian (IA5)</summary>
    public IMessageDescription _20108 { get => __20108!; set => this.AssertWritable().__20108 = value; }
    /// <summary>US-ASCII</summary>
    public IMessageDescription _20127 { get => __20127!; set => this.AssertWritable().__20127 = value; }
    /// <summary>T.61</summary>
    public IMessageDescription _20261 { get => __20261!; set => this.AssertWritable().__20261 = value; }
    /// <summary>ISO-6937</summary>
    public IMessageDescription _20269 { get => __20269!; set => this.AssertWritable().__20269 = value; }
    /// <summary>IBM EBCDIC (Germany)</summary>
    public IMessageDescription _20273 { get => __20273!; set => this.AssertWritable().__20273 = value; }
    /// <summary>IBM EBCDIC (Denmark-Norway)</summary>
    public IMessageDescription _20277 { get => __20277!; set => this.AssertWritable().__20277 = value; }
    /// <summary>IBM EBCDIC (Finland-Sweden)</summary>
    public IMessageDescription _20278 { get => __20278!; set => this.AssertWritable().__20278 = value; }
    /// <summary>IBM EBCDIC (Italy)</summary>
    public IMessageDescription _20280 { get => __20280!; set => this.AssertWritable().__20280 = value; }
    /// <summary>IBM EBCDIC (Spain)</summary>
    public IMessageDescription _20284 { get => __20284!; set => this.AssertWritable().__20284 = value; }
    /// <summary>IBM EBCDIC (UK)</summary>
    public IMessageDescription _20285 { get => __20285!; set => this.AssertWritable().__20285 = value; }
    /// <summary>IBM EBCDIC (Japanese katakana)</summary>
    public IMessageDescription _20290 { get => __20290!; set => this.AssertWritable().__20290 = value; }
    /// <summary>IBM EBCDIC (France)</summary>
    public IMessageDescription _20297 { get => __20297!; set => this.AssertWritable().__20297 = value; }
    /// <summary>IBM EBCDIC (Arabic)</summary>
    public IMessageDescription _20420 { get => __20420!; set => this.AssertWritable().__20420 = value; }
    /// <summary>IBM EBCDIC (Greek)</summary>
    public IMessageDescription _20423 { get => __20423!; set => this.AssertWritable().__20423 = value; }
    /// <summary>IBM EBCDIC (Hebrew)</summary>
    public IMessageDescription _20424 { get => __20424!; set => this.AssertWritable().__20424 = value; }
    /// <summary>IBM EBCDIC (Korean Extended)</summary>
    public IMessageDescription _20833 { get => __20833!; set => this.AssertWritable().__20833 = value; }
    /// <summary>IBM EBCDIC (Thai)</summary>
    public IMessageDescription _20838 { get => __20838!; set => this.AssertWritable().__20838 = value; }
    /// <summary>Cyrillic (KOI8-R)</summary>
    public IMessageDescription _20866 { get => __20866!; set => this.AssertWritable().__20866 = value; }
    /// <summary>IBM EBCDIC (Icelandic)</summary>
    public IMessageDescription _20871 { get => __20871!; set => this.AssertWritable().__20871 = value; }
    /// <summary>IBM EBCDIC (Cyrillic Russian)</summary>
    public IMessageDescription _20880 { get => __20880!; set => this.AssertWritable().__20880 = value; }
    /// <summary>IBM EBCDIC (Turkish)</summary>
    public IMessageDescription _20905 { get => __20905!; set => this.AssertWritable().__20905 = value; }
    /// <summary>IBM Latin-1</summary>
    public IMessageDescription _20924 { get => __20924!; set => this.AssertWritable().__20924 = value; }
    /// <summary>Japanese (JIS 0208-1990 and 0212-1990)</summary>
    public IMessageDescription _20932 { get => __20932!; set => this.AssertWritable().__20932 = value; }
    /// <summary>Chinese Simplified (GB2312-80)</summary>
    public IMessageDescription _20936 { get => __20936!; set => this.AssertWritable().__20936 = value; }
    /// <summary>Korean Wansung</summary>
    public IMessageDescription _20949 { get => __20949!; set => this.AssertWritable().__20949 = value; }
    /// <summary>IBM EBCDIC (Cyrillic Serbian-Bulgarian)</summary>
    public IMessageDescription _21025 { get => __21025!; set => this.AssertWritable().__21025 = value; }
    /// <summary>Ext Alpha Lowercase</summary>
    public IMessageDescription _21027 { get => __21027!; set => this.AssertWritable().__21027 = value; }
    /// <summary>Cyrillic (KOI8-U)</summary>
    public IMessageDescription _21866 { get => __21866!; set => this.AssertWritable().__21866 = value; }
    /// <summary>Western European (ISO)</summary>
    public IMessageDescription _28591 { get => __28591!; set => this.AssertWritable().__28591 = value; }
    /// <summary>Central European (ISO)</summary>
    public IMessageDescription _28592 { get => __28592!; set => this.AssertWritable().__28592 = value; }
    /// <summary>Latin 3 (ISO)</summary>
    public IMessageDescription _28593 { get => __28593!; set => this.AssertWritable().__28593 = value; }
    /// <summary>Baltic (ISO)</summary>
    public IMessageDescription _28594 { get => __28594!; set => this.AssertWritable().__28594 = value; }
    /// <summary>Cyrillic (ISO)</summary>
    public IMessageDescription _28595 { get => __28595!; set => this.AssertWritable().__28595 = value; }
    /// <summary>Arabic (ISO)</summary>
    public IMessageDescription _28596 { get => __28596!; set => this.AssertWritable().__28596 = value; }
    /// <summary>Greek (ISO)</summary>
    public IMessageDescription _28597 { get => __28597!; set => this.AssertWritable().__28597 = value; }
    /// <summary>Hebrew (ISO-Visual)</summary>
    public IMessageDescription _28598 { get => __28598!; set => this.AssertWritable().__28598 = value; }
    /// <summary>Turkish (ISO)</summary>
    public IMessageDescription _28599 { get => __28599!; set => this.AssertWritable().__28599 = value; }
    /// <summary>Estonian (ISO)</summary>
    public IMessageDescription _28603 { get => __28603!; set => this.AssertWritable().__28603 = value; }
    /// <summary>Latin 9 (ISO)</summary>
    public IMessageDescription _28605 { get => __28605!; set => this.AssertWritable().__28605 = value; }
    /// <summary>Europa</summary>
    public IMessageDescription _29001 { get => __29001!; set => this.AssertWritable().__29001 = value; }
    /// <summary>IBM EBCDIC (US-Canada)</summary>
    public IMessageDescription _37 { get => __37!; set => this.AssertWritable().__37 = value; }
    /// <summary>Hebrew (ISO-Logical)</summary>
    public IMessageDescription _38598 { get => __38598!; set => this.AssertWritable().__38598 = value; }
    /// <summary>OEM United States</summary>
    public IMessageDescription _437 { get => __437!; set => this.AssertWritable().__437 = value; }
    /// <summary>IBM EBCDIC (International)</summary>
    public IMessageDescription _500 { get => __500!; set => this.AssertWritable().__500 = value; }
    /// <summary>User Defined</summary>
    public IMessageDescription _50000 { get => __50000!; set => this.AssertWritable().__50000 = value; }
    /// <summary>Japanese (JIS)</summary>
    public IMessageDescription _50220 { get => __50220!; set => this.AssertWritable().__50220 = value; }
    /// <summary>Japanese (JIS-Allow 1 byte Kana)</summary>
    public IMessageDescription _50221 { get => __50221!; set => this.AssertWritable().__50221 = value; }
    /// <summary>Japanese (JIS-Allow 1 byte Kana - SO/SI)</summary>
    public IMessageDescription _50222 { get => __50222!; set => this.AssertWritable().__50222 = value; }
    /// <summary>Korean (ISO)</summary>
    public IMessageDescription _50225 { get => __50225!; set => this.AssertWritable().__50225 = value; }
    /// <summary>Chinese Simplified (ISO-2022)</summary>
    public IMessageDescription _50227 { get => __50227!; set => this.AssertWritable().__50227 = value; }
    /// <summary>Chinese Traditional (ISO-2022)</summary>
    public IMessageDescription _50229 { get => __50229!; set => this.AssertWritable().__50229 = value; }
    /// <summary>IBM EBCDIC (Japanese and Japanese Katakana)</summary>
    public IMessageDescription _50930 { get => __50930!; set => this.AssertWritable().__50930 = value; }
    /// <summary>IBM EBCDIC (Japanese and US-Canada)</summary>
    public IMessageDescription _50931 { get => __50931!; set => this.AssertWritable().__50931 = value; }
    /// <summary>IBM EBCDIC (Korean and Korean Extended)</summary>
    public IMessageDescription _50933 { get => __50933!; set => this.AssertWritable().__50933 = value; }
    /// <summary>IBM EBCDIC (Simplified Chinese)</summary>
    public IMessageDescription _50935 { get => __50935!; set => this.AssertWritable().__50935 = value; }
    /// <summary>IBM EBCDIC (Traditional Chinese)</summary>
    public IMessageDescription _50937 { get => __50937!; set => this.AssertWritable().__50937 = value; }
    /// <summary>IBM EBCDIC (Japanese and Japanese-Latin)</summary>
    public IMessageDescription _50939 { get => __50939!; set => this.AssertWritable().__50939 = value; }
    /// <summary>Japanese (EUC)</summary>
    public IMessageDescription _51932 { get => __51932!; set => this.AssertWritable().__51932 = value; }
    /// <summary>Chinese Simplified (EUC)</summary>
    public IMessageDescription _51936 { get => __51936!; set => this.AssertWritable().__51936 = value; }
    /// <summary>Korean (EUC)</summary>
    public IMessageDescription _51949 { get => __51949!; set => this.AssertWritable().__51949 = value; }
    /// <summary>Chinese Simplified (HZ)</summary>
    public IMessageDescription _52936 { get => __52936!; set => this.AssertWritable().__52936 = value; }
    /// <summary>Chinese Simplified (GB18030)</summary>
    public IMessageDescription _54936 { get => __54936!; set => this.AssertWritable().__54936 = value; }
    /// <summary>ISCII Devanagari</summary>
    public IMessageDescription _57002 { get => __57002!; set => this.AssertWritable().__57002 = value; }
    /// <summary>ISCII Bengali</summary>
    public IMessageDescription _57003 { get => __57003!; set => this.AssertWritable().__57003 = value; }
    /// <summary>ISCII Tamil</summary>
    public IMessageDescription _57004 { get => __57004!; set => this.AssertWritable().__57004 = value; }
    /// <summary>ISCII Telugu</summary>
    public IMessageDescription _57005 { get => __57005!; set => this.AssertWritable().__57005 = value; }
    /// <summary>ISCII Assamese</summary>
    public IMessageDescription _57006 { get => __57006!; set => this.AssertWritable().__57006 = value; }
    /// <summary>ISCII Oriya</summary>
    public IMessageDescription _57007 { get => __57007!; set => this.AssertWritable().__57007 = value; }
    /// <summary>ISCII Kannada</summary>
    public IMessageDescription _57008 { get => __57008!; set => this.AssertWritable().__57008 = value; }
    /// <summary>ISCII Malayalam</summary>
    public IMessageDescription _57009 { get => __57009!; set => this.AssertWritable().__57009 = value; }
    /// <summary>ISCII Gujarati</summary>
    public IMessageDescription _57010 { get => __57010!; set => this.AssertWritable().__57010 = value; }
    /// <summary>ISCII Punjabi</summary>
    public IMessageDescription _57011 { get => __57011!; set => this.AssertWritable().__57011 = value; }
    /// <summary>Unicode (UTF-7)</summary>
    public IMessageDescription _65000 { get => __65000!; set => this.AssertWritable().__65000 = value; }
    /// <summary>Unicode (UTF-8)</summary>
    public IMessageDescription _65001 { get => __65001!; set => this.AssertWritable().__65001 = value; }
    /// <summary>Arabic (ASMO 708)</summary>
    public IMessageDescription _708 { get => __708!; set => this.AssertWritable().__708 = value; }
    /// <summary>Arabic (DOS)</summary>
    public IMessageDescription _720 { get => __720!; set => this.AssertWritable().__720 = value; }
    /// <summary>Greek (DOS)</summary>
    public IMessageDescription _737 { get => __737!; set => this.AssertWritable().__737 = value; }
    /// <summary>Baltic (DOS)</summary>
    public IMessageDescription _775 { get => __775!; set => this.AssertWritable().__775 = value; }
    /// <summary>Western European (DOS)</summary>
    public IMessageDescription _850 { get => __850!; set => this.AssertWritable().__850 = value; }
    /// <summary>Central European (DOS)</summary>
    public IMessageDescription _852 { get => __852!; set => this.AssertWritable().__852 = value; }
    /// <summary>OEM Cyrillic</summary>
    public IMessageDescription _855 { get => __855!; set => this.AssertWritable().__855 = value; }
    /// <summary>Turkish (DOS)</summary>
    public IMessageDescription _857 { get => __857!; set => this.AssertWritable().__857 = value; }
    /// <summary>OEM Multilingual Latin I</summary>
    public IMessageDescription _858 { get => __858!; set => this.AssertWritable().__858 = value; }
    /// <summary>Portuguese (DOS)</summary>
    public IMessageDescription _860 { get => __860!; set => this.AssertWritable().__860 = value; }
    /// <summary>Icelandic (DOS)</summary>
    public IMessageDescription _861 { get => __861!; set => this.AssertWritable().__861 = value; }
    /// <summary>Hebrew (DOS)</summary>
    public IMessageDescription _862 { get => __862!; set => this.AssertWritable().__862 = value; }
    /// <summary>French Canadian (DOS)</summary>
    public IMessageDescription _863 { get => __863!; set => this.AssertWritable().__863 = value; }
    /// <summary>Arabic (864)</summary>
    public IMessageDescription _864 { get => __864!; set => this.AssertWritable().__864 = value; }
    /// <summary>Nordic (DOS)</summary>
    public IMessageDescription _865 { get => __865!; set => this.AssertWritable().__865 = value; }
    /// <summary>Cyrillic (DOS)</summary>
    public IMessageDescription _866 { get => __866!; set => this.AssertWritable().__866 = value; }
    /// <summary>Greek, Modern (DOS)</summary>
    public IMessageDescription _869 { get => __869!; set => this.AssertWritable().__869 = value; }
    /// <summary>IBM EBCDIC (Multilingual Latin-2)</summary>
    public IMessageDescription _870 { get => __870!; set => this.AssertWritable().__870 = value; }
    /// <summary>Thai (Windows)</summary>
    public IMessageDescription _874 { get => __874!; set => this.AssertWritable().__874 = value; }
    /// <summary>IBM EBCDIC (Greek Modern)</summary>
    public IMessageDescription _875 { get => __875!; set => this.AssertWritable().__875 = value; }
    /// <summary>Japanese (Shift-JIS)</summary>
    public IMessageDescription _932 { get => __932!; set => this.AssertWritable().__932 = value; }
    /// <summary>Chinese Simplified (GB2312)</summary>
    public IMessageDescription _936 { get => __936!; set => this.AssertWritable().__936 = value; }
    /// <summary>Korean</summary>
    public IMessageDescription _949 { get => __949!; set => this.AssertWritable().__949 = value; }
    /// <summary>Chinese Traditional (Big5)</summary>
    public IMessageDescription _950 { get => __950!; set => this.AssertWritable().__950 = value; }

    /// <summary>Initialize fields</summary>
    public override CodePageMessages Initialize() 
    {
        base.Initialize();
        Add(__10000 = new MessageDescription("mscorlib.Globalization.cp_10000", 0x23450C07, new ParameterlessText("Western European (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10001 = new MessageDescription("mscorlib.Globalization.cp_10001", 0x23450C08, new ParameterlessText("Japanese (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10002 = new MessageDescription("mscorlib.Globalization.cp_10002", 0x23450C09, new ParameterlessText("Chinese Traditional (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10003 = new MessageDescription("mscorlib.Globalization.cp_10003", 0x23450C0A, new ParameterlessText("Korean (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10004 = new MessageDescription("mscorlib.Globalization.cp_10004", 0x23450C0B, new ParameterlessText("Arabic (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10005 = new MessageDescription("mscorlib.Globalization.cp_10005", 0x23450C0C, new ParameterlessText("Hebrew (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10006 = new MessageDescription("mscorlib.Globalization.cp_10006", 0x23450C0D, new ParameterlessText("Greek (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10007 = new MessageDescription("mscorlib.Globalization.cp_10007", 0x23450C0E, new ParameterlessText("Cyrillic (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10008 = new MessageDescription("mscorlib.Globalization.cp_10008", 0x23450C0F, new ParameterlessText("Chinese Simplified (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10010 = new MessageDescription("mscorlib.Globalization.cp_10010", 0x23450C10, new ParameterlessText("Romanian (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10017 = new MessageDescription("mscorlib.Globalization.cp_10017", 0x23450C11, new ParameterlessText("Ukrainian (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10021 = new MessageDescription("mscorlib.Globalization.cp_10021", 0x23450C12, new ParameterlessText("Thai (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10029 = new MessageDescription("mscorlib.Globalization.cp_10029", 0x23450C13, new ParameterlessText("Central European (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10079 = new MessageDescription("mscorlib.Globalization.cp_10079", 0x23450C14, new ParameterlessText("Icelandic (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10081 = new MessageDescription("mscorlib.Globalization.cp_10081", 0x23450C15, new ParameterlessText("Turkish (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__10082 = new MessageDescription("mscorlib.Globalization.cp_10082", 0x23450C16, new ParameterlessText("Croatian (Mac)")).SetSeverity(MessageLevel.Information));
        Add(__1026 = new MessageDescription("mscorlib.Globalization.cp_1026", 0x23450BF1, new ParameterlessText("IBM EBCDIC (Turkish Latin-5)")).SetSeverity(MessageLevel.Information));
        Add(__1047 = new MessageDescription("mscorlib.Globalization.cp_1047", 0x23450BF2, new ParameterlessText("IBM Latin-1")).SetSeverity(MessageLevel.Information));
        Add(__1140 = new MessageDescription("mscorlib.Globalization.cp_1140", 0x23450BF3, new ParameterlessText("IBM EBCDIC (US-Canada-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1141 = new MessageDescription("mscorlib.Globalization.cp_1141", 0x23450BF4, new ParameterlessText("IBM EBCDIC (Germany-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1142 = new MessageDescription("mscorlib.Globalization.cp_1142", 0x23450BF5, new ParameterlessText("IBM EBCDIC (Denmark-Norway-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1143 = new MessageDescription("mscorlib.Globalization.cp_1143", 0x23450BF6, new ParameterlessText("IBM EBCDIC (Finland-Sweden-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1144 = new MessageDescription("mscorlib.Globalization.cp_1144", 0x23450BF7, new ParameterlessText("IBM EBCDIC (Italy-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1145 = new MessageDescription("mscorlib.Globalization.cp_1145", 0x23450BF8, new ParameterlessText("IBM EBCDIC (Spain-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1146 = new MessageDescription("mscorlib.Globalization.cp_1146", 0x23450BF9, new ParameterlessText("IBM EBCDIC (UK-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1147 = new MessageDescription("mscorlib.Globalization.cp_1147", 0x23450BFA, new ParameterlessText("IBM EBCDIC (France-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1148 = new MessageDescription("mscorlib.Globalization.cp_1148", 0x23450BFB, new ParameterlessText("IBM EBCDIC (International-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1149 = new MessageDescription("mscorlib.Globalization.cp_1149", 0x23450BFC, new ParameterlessText("IBM EBCDIC (Icelandic-Euro)")).SetSeverity(MessageLevel.Information));
        Add(__1200 = new MessageDescription("mscorlib.Globalization.cp_1200", 0x23450BCE, new ParameterlessText("Unicode")).SetSeverity(MessageLevel.Information));
        Add(__12000 = new MessageDescription("mscorlib.Globalization.cp_12000", 0x23450BD2, new ParameterlessText("Unicode (UTF-32)")).SetSeverity(MessageLevel.Information));
        Add(__12001 = new MessageDescription("mscorlib.Globalization.cp_12001", 0x23450BD3, new ParameterlessText("Unicode (UTF-32 Big-Endian)")).SetSeverity(MessageLevel.Information));
        Add(__1201 = new MessageDescription("mscorlib.Globalization.cp_1201", 0x23450BCF, new ParameterlessText("Unicode (Big-Endian)")).SetSeverity(MessageLevel.Information));
        Add(__1250 = new MessageDescription("mscorlib.Globalization.cp_1250", 0x23450BFD, new ParameterlessText("Central European (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1251 = new MessageDescription("mscorlib.Globalization.cp_1251", 0x23450BFE, new ParameterlessText("Cyrillic (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1252 = new MessageDescription("mscorlib.Globalization.cp_1252", 0x23450BFF, new ParameterlessText("Western European (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1253 = new MessageDescription("mscorlib.Globalization.cp_1253", 0x23450C00, new ParameterlessText("Greek (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1254 = new MessageDescription("mscorlib.Globalization.cp_1254", 0x23450C01, new ParameterlessText("Turkish (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1255 = new MessageDescription("mscorlib.Globalization.cp_1255", 0x23450C02, new ParameterlessText("Hebrew (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1256 = new MessageDescription("mscorlib.Globalization.cp_1256", 0x23450C03, new ParameterlessText("Arabic (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1257 = new MessageDescription("mscorlib.Globalization.cp_1257", 0x23450C04, new ParameterlessText("Baltic (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1258 = new MessageDescription("mscorlib.Globalization.cp_1258", 0x23450C05, new ParameterlessText("Vietnamese (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__1361 = new MessageDescription("mscorlib.Globalization.cp_1361", 0x23450C06, new ParameterlessText("Korean (Johab)")).SetSeverity(MessageLevel.Information));
        Add(__20000 = new MessageDescription("mscorlib.Globalization.cp_20000", 0x23450C17, new ParameterlessText("Chinese Traditional (CNS)")).SetSeverity(MessageLevel.Information));
        Add(__20001 = new MessageDescription("mscorlib.Globalization.cp_20001", 0x23450C18, new ParameterlessText("TCA Taiwan")).SetSeverity(MessageLevel.Information));
        Add(__20002 = new MessageDescription("mscorlib.Globalization.cp_20002", 0x23450C19, new ParameterlessText("Chinese Traditional (Eten)")).SetSeverity(MessageLevel.Information));
        Add(__20003 = new MessageDescription("mscorlib.Globalization.cp_20003", 0x23450C1A, new ParameterlessText("IBM5550 Taiwan")).SetSeverity(MessageLevel.Information));
        Add(__20004 = new MessageDescription("mscorlib.Globalization.cp_20004", 0x23450C1B, new ParameterlessText("TeleText Taiwan")).SetSeverity(MessageLevel.Information));
        Add(__20005 = new MessageDescription("mscorlib.Globalization.cp_20005", 0x23450C1C, new ParameterlessText("Wang Taiwan")).SetSeverity(MessageLevel.Information));
        Add(__20105 = new MessageDescription("mscorlib.Globalization.cp_20105", 0x23450C1D, new ParameterlessText("Western European (IA5)")).SetSeverity(MessageLevel.Information));
        Add(__20106 = new MessageDescription("mscorlib.Globalization.cp_20106", 0x23450C1E, new ParameterlessText("German (IA5)")).SetSeverity(MessageLevel.Information));
        Add(__20107 = new MessageDescription("mscorlib.Globalization.cp_20107", 0x23450C1F, new ParameterlessText("Swedish (IA5)")).SetSeverity(MessageLevel.Information));
        Add(__20108 = new MessageDescription("mscorlib.Globalization.cp_20108", 0x23450C20, new ParameterlessText("Norwegian (IA5)")).SetSeverity(MessageLevel.Information));
        Add(__20127 = new MessageDescription("mscorlib.Globalization.cp_20127", 0x23450BD4, new ParameterlessText("US-ASCII")).SetSeverity(MessageLevel.Information));
        Add(__20261 = new MessageDescription("mscorlib.Globalization.cp_20261", 0x23450C21, new ParameterlessText("T.61")).SetSeverity(MessageLevel.Information));
        Add(__20269 = new MessageDescription("mscorlib.Globalization.cp_20269", 0x23450C22, new ParameterlessText("ISO-6937")).SetSeverity(MessageLevel.Information));
        Add(__20273 = new MessageDescription("mscorlib.Globalization.cp_20273", 0x23450C23, new ParameterlessText("IBM EBCDIC (Germany)")).SetSeverity(MessageLevel.Information));
        Add(__20277 = new MessageDescription("mscorlib.Globalization.cp_20277", 0x23450C24, new ParameterlessText("IBM EBCDIC (Denmark-Norway)")).SetSeverity(MessageLevel.Information));
        Add(__20278 = new MessageDescription("mscorlib.Globalization.cp_20278", 0x23450C25, new ParameterlessText("IBM EBCDIC (Finland-Sweden)")).SetSeverity(MessageLevel.Information));
        Add(__20280 = new MessageDescription("mscorlib.Globalization.cp_20280", 0x23450C26, new ParameterlessText("IBM EBCDIC (Italy)")).SetSeverity(MessageLevel.Information));
        Add(__20284 = new MessageDescription("mscorlib.Globalization.cp_20284", 0x23450C27, new ParameterlessText("IBM EBCDIC (Spain)")).SetSeverity(MessageLevel.Information));
        Add(__20285 = new MessageDescription("mscorlib.Globalization.cp_20285", 0x23450C28, new ParameterlessText("IBM EBCDIC (UK)")).SetSeverity(MessageLevel.Information));
        Add(__20290 = new MessageDescription("mscorlib.Globalization.cp_20290", 0x23450C29, new ParameterlessText("IBM EBCDIC (Japanese katakana)")).SetSeverity(MessageLevel.Information));
        Add(__20297 = new MessageDescription("mscorlib.Globalization.cp_20297", 0x23450C2A, new ParameterlessText("IBM EBCDIC (France)")).SetSeverity(MessageLevel.Information));
        Add(__20420 = new MessageDescription("mscorlib.Globalization.cp_20420", 0x23450C2B, new ParameterlessText("IBM EBCDIC (Arabic)")).SetSeverity(MessageLevel.Information));
        Add(__20423 = new MessageDescription("mscorlib.Globalization.cp_20423", 0x23450C2C, new ParameterlessText("IBM EBCDIC (Greek)")).SetSeverity(MessageLevel.Information));
        Add(__20424 = new MessageDescription("mscorlib.Globalization.cp_20424", 0x23450C2D, new ParameterlessText("IBM EBCDIC (Hebrew)")).SetSeverity(MessageLevel.Information));
        Add(__20833 = new MessageDescription("mscorlib.Globalization.cp_20833", 0x23450C2E, new ParameterlessText("IBM EBCDIC (Korean Extended)")).SetSeverity(MessageLevel.Information));
        Add(__20838 = new MessageDescription("mscorlib.Globalization.cp_20838", 0x23450C2F, new ParameterlessText("IBM EBCDIC (Thai)")).SetSeverity(MessageLevel.Information));
        Add(__20866 = new MessageDescription("mscorlib.Globalization.cp_20866", 0x23450C30, new ParameterlessText("Cyrillic (KOI8-R)")).SetSeverity(MessageLevel.Information));
        Add(__20871 = new MessageDescription("mscorlib.Globalization.cp_20871", 0x23450C31, new ParameterlessText("IBM EBCDIC (Icelandic)")).SetSeverity(MessageLevel.Information));
        Add(__20880 = new MessageDescription("mscorlib.Globalization.cp_20880", 0x23450C32, new ParameterlessText("IBM EBCDIC (Cyrillic Russian)")).SetSeverity(MessageLevel.Information));
        Add(__20905 = new MessageDescription("mscorlib.Globalization.cp_20905", 0x23450C33, new ParameterlessText("IBM EBCDIC (Turkish)")).SetSeverity(MessageLevel.Information));
        Add(__20924 = new MessageDescription("mscorlib.Globalization.cp_20924", 0x23450C34, new ParameterlessText("IBM Latin-1")).SetSeverity(MessageLevel.Information));
        Add(__20932 = new MessageDescription("mscorlib.Globalization.cp_20932", 0x23450C35, new ParameterlessText("Japanese (JIS 0208-1990 and 0212-1990)")).SetSeverity(MessageLevel.Information));
        Add(__20936 = new MessageDescription("mscorlib.Globalization.cp_20936", 0x23450C36, new ParameterlessText("Chinese Simplified (GB2312-80)")).SetSeverity(MessageLevel.Information));
        Add(__20949 = new MessageDescription("mscorlib.Globalization.cp_20949", 0x23450C37, new ParameterlessText("Korean Wansung")).SetSeverity(MessageLevel.Information));
        Add(__21025 = new MessageDescription("mscorlib.Globalization.cp_21025", 0x23450C38, new ParameterlessText("IBM EBCDIC (Cyrillic Serbian-Bulgarian)")).SetSeverity(MessageLevel.Information));
        Add(__21027 = new MessageDescription("mscorlib.Globalization.cp_21027", 0x23450C39, new ParameterlessText("Ext Alpha Lowercase")).SetSeverity(MessageLevel.Information));
        Add(__21866 = new MessageDescription("mscorlib.Globalization.cp_21866", 0x23450C3A, new ParameterlessText("Cyrillic (KOI8-U)")).SetSeverity(MessageLevel.Information));
        Add(__28591 = new MessageDescription("mscorlib.Globalization.cp_28591", 0x23450BD5, new ParameterlessText("Western European (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28592 = new MessageDescription("mscorlib.Globalization.cp_28592", 0x23450C3B, new ParameterlessText("Central European (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28593 = new MessageDescription("mscorlib.Globalization.cp_28593", 0x23450C3C, new ParameterlessText("Latin 3 (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28594 = new MessageDescription("mscorlib.Globalization.cp_28594", 0x23450C3D, new ParameterlessText("Baltic (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28595 = new MessageDescription("mscorlib.Globalization.cp_28595", 0x23450C3E, new ParameterlessText("Cyrillic (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28596 = new MessageDescription("mscorlib.Globalization.cp_28596", 0x23450C3F, new ParameterlessText("Arabic (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28597 = new MessageDescription("mscorlib.Globalization.cp_28597", 0x23450C40, new ParameterlessText("Greek (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28598 = new MessageDescription("mscorlib.Globalization.cp_28598", 0x23450C41, new ParameterlessText("Hebrew (ISO-Visual)")).SetSeverity(MessageLevel.Information));
        Add(__28599 = new MessageDescription("mscorlib.Globalization.cp_28599", 0x23450C42, new ParameterlessText("Turkish (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28603 = new MessageDescription("mscorlib.Globalization.cp_28603", 0x23450C43, new ParameterlessText("Estonian (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__28605 = new MessageDescription("mscorlib.Globalization.cp_28605", 0x23450C44, new ParameterlessText("Latin 9 (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__29001 = new MessageDescription("mscorlib.Globalization.cp_29001", 0x23450C45, new ParameterlessText("Europa")).SetSeverity(MessageLevel.Information));
        Add(__37 = new MessageDescription("mscorlib.Globalization.cp_37", 0x23450BD6, new ParameterlessText("IBM EBCDIC (US-Canada)")).SetSeverity(MessageLevel.Information));
        Add(__38598 = new MessageDescription("mscorlib.Globalization.cp_38598", 0x23450C46, new ParameterlessText("Hebrew (ISO-Logical)")).SetSeverity(MessageLevel.Information));
        Add(__437 = new MessageDescription("mscorlib.Globalization.cp_437", 0x23450BD7, new ParameterlessText("OEM United States")).SetSeverity(MessageLevel.Information));
        Add(__500 = new MessageDescription("mscorlib.Globalization.cp_500", 0x23450BD8, new ParameterlessText("IBM EBCDIC (International)")).SetSeverity(MessageLevel.Information));
        Add(__50000 = new MessageDescription("mscorlib.Globalization.cp_50000", 0x23450C47, new ParameterlessText("User Defined")).SetSeverity(MessageLevel.Information));
        Add(__50220 = new MessageDescription("mscorlib.Globalization.cp_50220", 0x23450C48, new ParameterlessText("Japanese (JIS)")).SetSeverity(MessageLevel.Information));
        Add(__50221 = new MessageDescription("mscorlib.Globalization.cp_50221", 0x23450C49, new ParameterlessText("Japanese (JIS-Allow 1 byte Kana)")).SetSeverity(MessageLevel.Information));
        Add(__50222 = new MessageDescription("mscorlib.Globalization.cp_50222", 0x23450C4A, new ParameterlessText("Japanese (JIS-Allow 1 byte Kana - SO/SI)")).SetSeverity(MessageLevel.Information));
        Add(__50225 = new MessageDescription("mscorlib.Globalization.cp_50225", 0x23450C4B, new ParameterlessText("Korean (ISO)")).SetSeverity(MessageLevel.Information));
        Add(__50227 = new MessageDescription("mscorlib.Globalization.cp_50227", 0x23450C4C, new ParameterlessText("Chinese Simplified (ISO-2022)")).SetSeverity(MessageLevel.Information));
        Add(__50229 = new MessageDescription("mscorlib.Globalization.cp_50229", 0x23450C4D, new ParameterlessText("Chinese Traditional (ISO-2022)")).SetSeverity(MessageLevel.Information));
        Add(__50930 = new MessageDescription("mscorlib.Globalization.cp_50930", 0x23450C4E, new ParameterlessText("IBM EBCDIC (Japanese and Japanese Katakana)")).SetSeverity(MessageLevel.Information));
        Add(__50931 = new MessageDescription("mscorlib.Globalization.cp_50931", 0x23450C4F, new ParameterlessText("IBM EBCDIC (Japanese and US-Canada)")).SetSeverity(MessageLevel.Information));
        Add(__50933 = new MessageDescription("mscorlib.Globalization.cp_50933", 0x23450C50, new ParameterlessText("IBM EBCDIC (Korean and Korean Extended)")).SetSeverity(MessageLevel.Information));
        Add(__50935 = new MessageDescription("mscorlib.Globalization.cp_50935", 0x23450C51, new ParameterlessText("IBM EBCDIC (Simplified Chinese)")).SetSeverity(MessageLevel.Information));
        Add(__50937 = new MessageDescription("mscorlib.Globalization.cp_50937", 0x23450C52, new ParameterlessText("IBM EBCDIC (Traditional Chinese)")).SetSeverity(MessageLevel.Information));
        Add(__50939 = new MessageDescription("mscorlib.Globalization.cp_50939", 0x23450C53, new ParameterlessText("IBM EBCDIC (Japanese and Japanese-Latin)")).SetSeverity(MessageLevel.Information));
        Add(__51932 = new MessageDescription("mscorlib.Globalization.cp_51932", 0x23450C54, new ParameterlessText("Japanese (EUC)")).SetSeverity(MessageLevel.Information));
        Add(__51936 = new MessageDescription("mscorlib.Globalization.cp_51936", 0x23450C55, new ParameterlessText("Chinese Simplified (EUC)")).SetSeverity(MessageLevel.Information));
        Add(__51949 = new MessageDescription("mscorlib.Globalization.cp_51949", 0x23450C56, new ParameterlessText("Korean (EUC)")).SetSeverity(MessageLevel.Information));
        Add(__52936 = new MessageDescription("mscorlib.Globalization.cp_52936", 0x23450C57, new ParameterlessText("Chinese Simplified (HZ)")).SetSeverity(MessageLevel.Information));
        Add(__54936 = new MessageDescription("mscorlib.Globalization.cp_54936", 0x23450C58, new ParameterlessText("Chinese Simplified (GB18030)")).SetSeverity(MessageLevel.Information));
        Add(__57002 = new MessageDescription("mscorlib.Globalization.cp_57002", 0x23450C59, new ParameterlessText("ISCII Devanagari")).SetSeverity(MessageLevel.Information));
        Add(__57003 = new MessageDescription("mscorlib.Globalization.cp_57003", 0x23450C5A, new ParameterlessText("ISCII Bengali")).SetSeverity(MessageLevel.Information));
        Add(__57004 = new MessageDescription("mscorlib.Globalization.cp_57004", 0x23450C5B, new ParameterlessText("ISCII Tamil")).SetSeverity(MessageLevel.Information));
        Add(__57005 = new MessageDescription("mscorlib.Globalization.cp_57005", 0x23450C5C, new ParameterlessText("ISCII Telugu")).SetSeverity(MessageLevel.Information));
        Add(__57006 = new MessageDescription("mscorlib.Globalization.cp_57006", 0x23450C5D, new ParameterlessText("ISCII Assamese")).SetSeverity(MessageLevel.Information));
        Add(__57007 = new MessageDescription("mscorlib.Globalization.cp_57007", 0x23450C5E, new ParameterlessText("ISCII Oriya")).SetSeverity(MessageLevel.Information));
        Add(__57008 = new MessageDescription("mscorlib.Globalization.cp_57008", 0x23450C5F, new ParameterlessText("ISCII Kannada")).SetSeverity(MessageLevel.Information));
        Add(__57009 = new MessageDescription("mscorlib.Globalization.cp_57009", 0x23450C60, new ParameterlessText("ISCII Malayalam")).SetSeverity(MessageLevel.Information));
        Add(__57010 = new MessageDescription("mscorlib.Globalization.cp_57010", 0x23450C61, new ParameterlessText("ISCII Gujarati")).SetSeverity(MessageLevel.Information));
        Add(__57011 = new MessageDescription("mscorlib.Globalization.cp_57011", 0x23450C62, new ParameterlessText("ISCII Punjabi")).SetSeverity(MessageLevel.Information));
        Add(__65000 = new MessageDescription("mscorlib.Globalization.cp_65000", 0x23450BD1, new ParameterlessText("Unicode (UTF-7)")).SetSeverity(MessageLevel.Information));
        Add(__65001 = new MessageDescription("mscorlib.Globalization.cp_65001", 0x23450BD0, new ParameterlessText("Unicode (UTF-8)")).SetSeverity(MessageLevel.Information));
        Add(__708 = new MessageDescription("mscorlib.Globalization.cp_708", 0x23450BD9, new ParameterlessText("Arabic (ASMO 708)")).SetSeverity(MessageLevel.Information));
        Add(__720 = new MessageDescription("mscorlib.Globalization.cp_720", 0x23450BDA, new ParameterlessText("Arabic (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__737 = new MessageDescription("mscorlib.Globalization.cp_737", 0x23450BDB, new ParameterlessText("Greek (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__775 = new MessageDescription("mscorlib.Globalization.cp_775", 0x23450BDC, new ParameterlessText("Baltic (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__850 = new MessageDescription("mscorlib.Globalization.cp_850", 0x23450BDD, new ParameterlessText("Western European (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__852 = new MessageDescription("mscorlib.Globalization.cp_852", 0x23450BDE, new ParameterlessText("Central European (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__855 = new MessageDescription("mscorlib.Globalization.cp_855", 0x23450BDF, new ParameterlessText("OEM Cyrillic")).SetSeverity(MessageLevel.Information));
        Add(__857 = new MessageDescription("mscorlib.Globalization.cp_857", 0x23450BE0, new ParameterlessText("Turkish (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__858 = new MessageDescription("mscorlib.Globalization.cp_858", 0x23450BE1, new ParameterlessText("OEM Multilingual Latin I")).SetSeverity(MessageLevel.Information));
        Add(__860 = new MessageDescription("mscorlib.Globalization.cp_860", 0x23450BE2, new ParameterlessText("Portuguese (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__861 = new MessageDescription("mscorlib.Globalization.cp_861", 0x23450BE3, new ParameterlessText("Icelandic (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__862 = new MessageDescription("mscorlib.Globalization.cp_862", 0x23450BE4, new ParameterlessText("Hebrew (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__863 = new MessageDescription("mscorlib.Globalization.cp_863", 0x23450BE5, new ParameterlessText("French Canadian (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__864 = new MessageDescription("mscorlib.Globalization.cp_864", 0x23450BE6, new ParameterlessText("Arabic (864)")).SetSeverity(MessageLevel.Information));
        Add(__865 = new MessageDescription("mscorlib.Globalization.cp_865", 0x23450BE7, new ParameterlessText("Nordic (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__866 = new MessageDescription("mscorlib.Globalization.cp_866", 0x23450BE8, new ParameterlessText("Cyrillic (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__869 = new MessageDescription("mscorlib.Globalization.cp_869", 0x23450BE9, new ParameterlessText("Greek, Modern (DOS)")).SetSeverity(MessageLevel.Information));
        Add(__870 = new MessageDescription("mscorlib.Globalization.cp_870", 0x23450BEA, new ParameterlessText("IBM EBCDIC (Multilingual Latin-2)")).SetSeverity(MessageLevel.Information));
        Add(__874 = new MessageDescription("mscorlib.Globalization.cp_874", 0x23450BEB, new ParameterlessText("Thai (Windows)")).SetSeverity(MessageLevel.Information));
        Add(__875 = new MessageDescription("mscorlib.Globalization.cp_875", 0x23450BEC, new ParameterlessText("IBM EBCDIC (Greek Modern)")).SetSeverity(MessageLevel.Information));
        Add(__932 = new MessageDescription("mscorlib.Globalization.cp_932", 0x23450BED, new ParameterlessText("Japanese (Shift-JIS)")).SetSeverity(MessageLevel.Information));
        Add(__936 = new MessageDescription("mscorlib.Globalization.cp_936", 0x23450BEE, new ParameterlessText("Chinese Simplified (GB2312)")).SetSeverity(MessageLevel.Information));
        Add(__949 = new MessageDescription("mscorlib.Globalization.cp_949", 0x23450BEF, new ParameterlessText("Korean")).SetSeverity(MessageLevel.Information));
        Add(__950 = new MessageDescription("mscorlib.Globalization.cp_950", 0x23450BF0, new ParameterlessText("Chinese Traditional (Big5)")).SetSeverity(MessageLevel.Information));
        return this;
    }    

}
