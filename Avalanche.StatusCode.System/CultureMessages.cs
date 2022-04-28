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

/// <summary>System.Globalization.Culture*</summary>
public class CultureMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<CultureMessages> instance = new Lazy<CultureMessages>(() => new CultureMessages().Initialize().SetAllReadOnly<CultureMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static CultureMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x0346;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? _legacymodifier, _globalizationci, _aa, _aadj, _aaer, _aaet, _af, _afna, _afza, _agq;
    IMessageDescription? _agqcm, _ak, _akgh, _am, _amet, _ar, _ar001, _arae, _arbh, _ardj;
    IMessageDescription? _ardz, _areg, _arer, _aril, _ariq, _arjo, _arkm, _arkw, _arlb, _arly;
    IMessageDescription? _arma, _armr, _arom, _arps, _arqa, _arsa, _arsd, _arso, _arss, _arsy;
    IMessageDescription? _artd, _artn, _arye, _arn, _arncl, _as, _asin, _asa, _asatz, _ast;
    IMessageDescription? _astes, _az, _azcyrl, _azcyrlaz, _azlatn, _azlatnaz, _ba, _baru, _bas, _bascm;
    IMessageDescription? _be, _beby, _bem, _bemzm, _bez, _beztz, _bg, _bgbg, _bin, _binng;
    IMessageDescription? _bm, _bmlatn, _bmlatnml, _bmml, _bn, _bnbd, _bnin, _bo, _bocn, _boin;
    IMessageDescription? _br, _brfr, _brx, _brxin, _bs, _bscyrl, _bscyrlba, _bslatn, _bslatnba, _byn;
    IMessageDescription? _byner, _ca, _caad, _caes, _caesvalencia, _cafr, _cait, _cgg, _cggug, _chr;
    IMessageDescription? _chrcher, _chrcherus, _co, _cofr, _cs, _cscz, _cy, _cygb, _da, _dadk;
    IMessageDescription? _dagl, _dav, _davke, _de, _deat, _debe, _dech, _dede, _dedephoneb, _deli;
    IMessageDescription? _delu, _dje, _djene, _dsb, _dsbde, _dua, _duacm, _dv, _dvmv, _dyo;
    IMessageDescription? _dyosn, _dz, _dzbt, _ebu, _ebuke, _ee, _eegh, _eetg, _el, _elcy;
    IMessageDescription? _elgr, _en, _en001, _en029, _en150, _enag, _enai, _enas, _enau, _enbb;
    IMessageDescription? _enbe, _enbm, _enbs, _enbw, _enbz, _enca, _encc, _enck, _encm, _encx;
    IMessageDescription? _endm, _ener, _enfj, _enfk, _enfm, _engb, _engd, _engg, _engh, _engi;
    IMessageDescription? _engm, _engu, _engy, _enhk, _enid, _enie, _enim, _enin, _enio, _enje;
    IMessageDescription? _enjm, _enke, _enki, _enkn, _enky, _enlc, _enlr, _enls, _enmg, _enmh;
    IMessageDescription? _enmo, _enmp, _enms, _enmt, _enmu, _enmw, _enmy, _enna, _ennf, _enng;
    IMessageDescription? _ennr, _ennu, _ennz, _enpg, _enph, _enpk, _enpn, _enpr, _enpw, _enrw;
    IMessageDescription? _ensb, _ensc, _ensd, _ensg, _ensh, _ensl, _enss, _ensx, _ensz, _entc;
    IMessageDescription? _entk, _ento, _entt, _entv, _entz, _enug, _enum, _enus, _envc, _envg;
    IMessageDescription? _envi, _envu, _enws, _enza, _enzm, _enzw, _eo, _eo001, _es, _es419;
    IMessageDescription? _esar, _esbo, _escl, _esco, _escr, _escu, _esdo, _esec, _eses, _esestradnl;
    IMessageDescription? _esgq, _esgt, _eshn, _esmx, _esni, _espa, _espe, _esph, _espr, _espy;
    IMessageDescription? _essv, _esus, _esuy, _esve, _et, _etee, _eu, _eues, _ewo, _ewocm;
    IMessageDescription? _fa, _faaf, _fair, _ff, _ffcm, _ffgn, _fflatn, _fflatnsn, _ffmr, _ffng;
    IMessageDescription? _fi, _fifi, _fil, _filph, _fo, _fofo, _fr, _fr029, _frbe, _frbf;
    IMessageDescription? _frbi, _frbj, _frbl, _frca, _frcd, _frcf, _frcg, _frch, _frci, _frcm;
    IMessageDescription? _frdj, _frdz, _frfr, _frga, _frgf, _frgn, _frgp, _frgq, _frht, _frkm;
    IMessageDescription? _frlu, _frma, _frmc, _frmf, _frmg, _frml, _frmq, _frmr, _frmu, _frnc;
    IMessageDescription? _frne, _frpf, _frpm, _frre, _frrw, _frsc, _frsn, _frsy, _frtd, _frtg;
    IMessageDescription? _frtn, _frvu, _frwf, _fryt, _fur, _furit, _fy, _fynl, _ga, _gaie;
    IMessageDescription? _gd, _gdgb, _gl, _gles, _gn, _gnpy, _gsw, _gswch, _gswfr, _gswli;
    IMessageDescription? _gu, _guin, _guz, _guzke, _gv, _gvim, _ha, _halatn, _halatngh, _halatnne;
    IMessageDescription? _halatnng, _haw, _hawus, _he, _heil, _hi, _hiin, _hr, _hrba, _hrhr;
    IMessageDescription? _hsb, _hsbde, _hu, _huhu, _huhutechnl, _hy, _hyam, _ia, _ia001, _iafr;
    IMessageDescription? _ibb, _ibbng, _id, _idid, _ig, _igng, _ii, _iicn, _is, _isis;
    IMessageDescription? _it, _itch, _itit, _itsm, _iu, _iucans, _iucansca, _iulatn, _iulatnca, _ja;
    IMessageDescription? _jajp, _jajpradstr, _jgo, _jgocm, _jmc, _jmctz, _jv, _jvjava, _jvjavaid, _jvlatn;
    IMessageDescription? _jvlatnid, _ka, _kage, _kagemodern, _kab, _kabdz, _kam, _kamke, _kde, _kdetz;
    IMessageDescription? _kea, _keacv, _khq, _khqml, _ki, _kike, _kk, _kkkz, _kkj, _kkjcm;
    IMessageDescription? _kl, _klgl, _kln, _klnke, _km, _kmkh, _kn, _knin, _ko, _kokr;
    IMessageDescription? _kok, _kokin, _kr, _krng, _ks, _ksarab, _ksarabin, _ksdeva, _ksdevain, _ksb;
    IMessageDescription? _ksbtz, _ksf, _ksfcm, _ksh, _kshde, _ku, _kuarab, _kuarabiq, _kw, _kwgb;
    IMessageDescription? _ky, _kykg, _la, _la001, _lag, _lagtz, _lb, _lblu, _lg, _lgug;
    IMessageDescription? _lkt, _lktus, _ln, _lnao, _lncd, _lncf, _lncg, _lo, _lola, _lt;
    IMessageDescription? _ltlt, _lu, _lucd, _luo, _luoke, _luy, _luyke, _lv, _lvlv, _mas;
    IMessageDescription? _maske, _mastz, _mer, _merke, _mfe, _mfemu, _mg, _mgmg, _mgh, _mghmz;
    IMessageDescription? _mgo, _mgocm, _mi, _minz, _mk, _mkmk, _ml, _mlin, _mn, _mncyrl;
    IMessageDescription? _mnmn, _mnmong, _mnmongcn, _mnmongmn, _mni, _mniin, _moh, _mohca, _mr, _mrin;
    IMessageDescription? _ms, _msbn, _msmy, _mssg, _mt, _mtmt, _mua, _muacm, _my, _mymm;
    IMessageDescription? _naq, _naqna, _nb, _nbno, _nbsj, _nd, _ndzw, _ne, _nein, _nenp;
    IMessageDescription? _nl, _nlaw, _nlbe, _nlbq, _nlcw, _nlnl, _nlsr, _nlsx, _nmg, _nmgcm;
    IMessageDescription? _nn, _nnno, _nnh, _nnhcm, _no, _nqo, _nqogn, _nr, _nrza, _nso;
    IMessageDescription? _nsoza, _nus, _nussd, _nusss, _nyn, _nynug, _oc, _ocfr, _om, _omet;
    IMessageDescription? _omke, _or, _orin, _os, _osge, _osru, _pa, _paarab, _paarabpk, _pain;
    IMessageDescription? _pap, _pap029, _pl, _plpl, _prs, _prsaf, _ps, _psaf, _pt, _ptao;
    IMessageDescription? _ptbr, _ptcv, _ptgw, _ptmo, _ptmz, _ptpt, _ptst, _pttl, _qpsploc, _qpsploca;
    IMessageDescription? _qpsplocm, _qu, _qubo, _quec, _qupe, _quc, _quclatn, _quclatngt, _qut, _qutgt;
    IMessageDescription? _quz, _quzbo, _quzec, _quzpe, _rm, _rmch, _rn, _rnbi, _ro, _romd;
    IMessageDescription? _roro, _rof, _roftz, _ru, _ruby, _rukg, _rukz, _rumd, _ruru, _ruua;
    IMessageDescription? _rw, _rwrw, _rwk, _rwktz, _sa, _sain, _sah, _sahru, _saq, _saqke;
    IMessageDescription? _sbp, _sbptz, _sd, _sdarab, _sdarabpk, _sddeva, _sddevain, _se, _sefi, _seno;
    IMessageDescription? _sese, _seh, _sehmz, _ses, _sesml, _sg, _sgcf, _shi, _shilatn, _shilatnma;
    IMessageDescription? _shitfng, _shitfngma, _si, _silk, _sk, _sksk, _sl, _slsi, _sma, _smano;
    IMessageDescription? _smase, _smj, _smjno, _smjse, _smn, _smnfi, _sms, _smsfi, _sn, _snlatn;
    IMessageDescription? _snlatnzw, _so, _sodj, _soet, _soke, _soso, _sq, _sqal, _sqmk, _sqxk;
    IMessageDescription? _sr, _srcyrl, _srcyrlba, _srcyrlcs, _srcyrlme, _srcyrlrs, _srcyrlxk, _srlatn, _srlatnba, _srlatncs;
    IMessageDescription? _srlatnme, _srlatnrs, _srlatnxk, _ss, _sssz, _ssza, _ssy, _ssyer, _st, _stls;
    IMessageDescription? _stza, _sv, _svax, _svfi, _svse, _sw, _swcd, _swke, _swtz, _swug;
    IMessageDescription? _swc, _swccd, _syr, _syrsy, _ta, _tain, _talk, _tamy, _tasg, _te;
    IMessageDescription? _tein, _teo, _teoke, _teoug, _tg, _tgcyrl, _tgcyrltj, _th, _thth, _ti;
    IMessageDescription? _tier, _tiet, _tig, _tiger, _tk, _tktm, _tn, _tnbw, _tnza, _to;
    IMessageDescription? _toto, _tr, _trcy, _trtr, _ts, _tsza, _tt, _ttru, _twq, _twqne;
    IMessageDescription? _tzm, _tzmarab, _tzmarabma, _tzmlatn, _tzmlatndz, _tzmlatnma, _tzmtfng, _tzmtfngma, _ug, _ugcn;
    IMessageDescription? _uk, _ukua, _ur, _urin, _urpk, _uz, _uzarab, _uzarabaf, _uzcyrl, _uzcyrluz;
    IMessageDescription? _uzlatn, _uzlatnuz, _vai, _vailatn, _vailatnlr, _vaivaii, _vaivaiilr, _ve, _veza, _vi;
    IMessageDescription? _vivn, _vo, _vo001, _vun, _vuntz, _wae, _waech, _wal, _walet, _wo;
    IMessageDescription? _wosn, _xiv, _xivmathan, _xh, _xhza, _xog, _xogug, _yav, _yavcm, _yi;
    IMessageDescription? _yi001, _yo, _yobj, _yong, _zgh, _zghtfng, _zghtfngma, _zh, _zhchs, _zhcht;
    IMessageDescription? _zhcn, _zhcnstroke, _zhhk, _zhhkradstr, _zhhans, _zhhanshk, _zhhansmo, _zhhant, _zhmo, _zhmoradstr;
    IMessageDescription? _zhmostroke, _zhsg, _zhsgstroke, _zhtw, _zhtwpronun, _zhtwradstr, _zu, _zuza;
    
    /// <summary>Legacy</summary>
    public IMessageDescription LegacyModifier { get => _legacymodifier!; set => this.AssertWritable()._legacymodifier = value; }
    /// <summary>Invariant Language (Invariant Country)</summary>
    public IMessageDescription Globalizationci { get => _globalizationci!; set => this.AssertWritable()._globalizationci = value; }
    /// <summary>Afar</summary>
    public IMessageDescription aa { get => _aa!; set => this.AssertWritable()._aa = value; }
    /// <summary>Afar (Djibouti)</summary>
    public IMessageDescription aaDJ { get => _aadj!; set => this.AssertWritable()._aadj = value; }
    /// <summary>Afar (Eritrea)</summary>
    public IMessageDescription aaER { get => _aaer!; set => this.AssertWritable()._aaer = value; }
    /// <summary>Afar (Ethiopia)</summary>
    public IMessageDescription aaET { get => _aaet!; set => this.AssertWritable()._aaet = value; }
    /// <summary>Afrikaans</summary>
    public IMessageDescription af { get => _af!; set => this.AssertWritable()._af = value; }
    /// <summary>Afrikaans (Namibia)</summary>
    public IMessageDescription afNA { get => _afna!; set => this.AssertWritable()._afna = value; }
    /// <summary>Afrikaans (South Africa)</summary>
    public IMessageDescription afZA { get => _afza!; set => this.AssertWritable()._afza = value; }
    /// <summary>Aghem</summary>
    public IMessageDescription agq { get => _agq!; set => this.AssertWritable()._agq = value; }
    /// <summary>Aghem (Cameroon)</summary>
    public IMessageDescription agqCM { get => _agqcm!; set => this.AssertWritable()._agqcm = value; }
    /// <summary>Akan</summary>
    public IMessageDescription ak { get => _ak!; set => this.AssertWritable()._ak = value; }
    /// <summary>Akan (Ghana)</summary>
    public IMessageDescription akGH { get => _akgh!; set => this.AssertWritable()._akgh = value; }
    /// <summary>Amharic</summary>
    public IMessageDescription am { get => _am!; set => this.AssertWritable()._am = value; }
    /// <summary>Amharic (Ethiopia)</summary>
    public IMessageDescription amET { get => _amet!; set => this.AssertWritable()._amet = value; }
    /// <summary>Arabic</summary>
    public IMessageDescription ar { get => _ar!; set => this.AssertWritable()._ar = value; }
    /// <summary>Arabic (World)</summary>
    public IMessageDescription ar001 { get => _ar001!; set => this.AssertWritable()._ar001 = value; }
    /// <summary>Arabic (U.A.E.)</summary>
    public IMessageDescription arAE { get => _arae!; set => this.AssertWritable()._arae = value; }
    /// <summary>Arabic (Bahrain)</summary>
    public IMessageDescription arBH { get => _arbh!; set => this.AssertWritable()._arbh = value; }
    /// <summary>Arabic (Djibouti)</summary>
    public IMessageDescription arDJ { get => _ardj!; set => this.AssertWritable()._ardj = value; }
    /// <summary>Arabic (Algeria)</summary>
    public IMessageDescription arDZ { get => _ardz!; set => this.AssertWritable()._ardz = value; }
    /// <summary>Arabic (Egypt)</summary>
    public IMessageDescription arEG { get => _areg!; set => this.AssertWritable()._areg = value; }
    /// <summary>Arabic (Eritrea)</summary>
    public IMessageDescription arER { get => _arer!; set => this.AssertWritable()._arer = value; }
    /// <summary>Arabic (Israel)</summary>
    public IMessageDescription arIL { get => _aril!; set => this.AssertWritable()._aril = value; }
    /// <summary>Arabic (Iraq)</summary>
    public IMessageDescription arIQ { get => _ariq!; set => this.AssertWritable()._ariq = value; }
    /// <summary>Arabic (Jordan)</summary>
    public IMessageDescription arJO { get => _arjo!; set => this.AssertWritable()._arjo = value; }
    /// <summary>Arabic (Comoros)</summary>
    public IMessageDescription arKM { get => _arkm!; set => this.AssertWritable()._arkm = value; }
    /// <summary>Arabic (Kuwait)</summary>
    public IMessageDescription arKW { get => _arkw!; set => this.AssertWritable()._arkw = value; }
    /// <summary>Arabic (Lebanon)</summary>
    public IMessageDescription arLB { get => _arlb!; set => this.AssertWritable()._arlb = value; }
    /// <summary>Arabic (Libya)</summary>
    public IMessageDescription arLY { get => _arly!; set => this.AssertWritable()._arly = value; }
    /// <summary>Arabic (Morocco)</summary>
    public IMessageDescription arMA { get => _arma!; set => this.AssertWritable()._arma = value; }
    /// <summary>Arabic (Mauritania)</summary>
    public IMessageDescription arMR { get => _armr!; set => this.AssertWritable()._armr = value; }
    /// <summary>Arabic (Oman)</summary>
    public IMessageDescription arOM { get => _arom!; set => this.AssertWritable()._arom = value; }
    /// <summary>Arabic (Palestinian Authority)</summary>
    public IMessageDescription arPS { get => _arps!; set => this.AssertWritable()._arps = value; }
    /// <summary>Arabic (Qatar)</summary>
    public IMessageDescription arQA { get => _arqa!; set => this.AssertWritable()._arqa = value; }
    /// <summary>Arabic (Saudi Arabia)</summary>
    public IMessageDescription arSA { get => _arsa!; set => this.AssertWritable()._arsa = value; }
    /// <summary>Arabic (Sudan)</summary>
    public IMessageDescription arSD { get => _arsd!; set => this.AssertWritable()._arsd = value; }
    /// <summary>Arabic (Somalia)</summary>
    public IMessageDescription arSO { get => _arso!; set => this.AssertWritable()._arso = value; }
    /// <summary>Arabic (South Sudan)</summary>
    public IMessageDescription arSS { get => _arss!; set => this.AssertWritable()._arss = value; }
    /// <summary>Arabic (Syria)</summary>
    public IMessageDescription arSY { get => _arsy!; set => this.AssertWritable()._arsy = value; }
    /// <summary>Arabic (Chad)</summary>
    public IMessageDescription arTD { get => _artd!; set => this.AssertWritable()._artd = value; }
    /// <summary>Arabic (Tunisia)</summary>
    public IMessageDescription arTN { get => _artn!; set => this.AssertWritable()._artn = value; }
    /// <summary>Arabic (Yemen)</summary>
    public IMessageDescription arYE { get => _arye!; set => this.AssertWritable()._arye = value; }
    /// <summary>Mapudungun</summary>
    public IMessageDescription arn { get => _arn!; set => this.AssertWritable()._arn = value; }
    /// <summary>Mapudungun (Chile)</summary>
    public IMessageDescription arnCL { get => _arncl!; set => this.AssertWritable()._arncl = value; }
    /// <summary>Assamese</summary>
    public IMessageDescription As { get => _as!; set => this.AssertWritable()._as = value; }
    /// <summary>Assamese (India)</summary>
    public IMessageDescription asIN { get => _asin!; set => this.AssertWritable()._asin = value; }
    /// <summary>Asu</summary>
    public IMessageDescription asa { get => _asa!; set => this.AssertWritable()._asa = value; }
    /// <summary>Asu (Tanzania)</summary>
    public IMessageDescription asaTZ { get => _asatz!; set => this.AssertWritable()._asatz = value; }
    /// <summary>Asturian</summary>
    public IMessageDescription ast { get => _ast!; set => this.AssertWritable()._ast = value; }
    /// <summary>Asturian (Spain)</summary>
    public IMessageDescription astES { get => _astes!; set => this.AssertWritable()._astes = value; }
    /// <summary>Azerbaijani</summary>
    public IMessageDescription az { get => _az!; set => this.AssertWritable()._az = value; }
    /// <summary>Azerbaijani (Cyrillic)</summary>
    public IMessageDescription azCyrl { get => _azcyrl!; set => this.AssertWritable()._azcyrl = value; }
    /// <summary>Azerbaijani (Cyrillic, Azerbaijan)</summary>
    public IMessageDescription azCyrlAZ { get => _azcyrlaz!; set => this.AssertWritable()._azcyrlaz = value; }
    /// <summary>Azerbaijani (Latin)</summary>
    public IMessageDescription azLatn { get => _azlatn!; set => this.AssertWritable()._azlatn = value; }
    /// <summary>Azerbaijani (Latin, Azerbaijan)</summary>
    public IMessageDescription azLatnAZ { get => _azlatnaz!; set => this.AssertWritable()._azlatnaz = value; }
    /// <summary>Bashkir</summary>
    public IMessageDescription ba { get => _ba!; set => this.AssertWritable()._ba = value; }
    /// <summary>Bashkir (Russia)</summary>
    public IMessageDescription baRU { get => _baru!; set => this.AssertWritable()._baru = value; }
    /// <summary>Basaa</summary>
    public IMessageDescription bas { get => _bas!; set => this.AssertWritable()._bas = value; }
    /// <summary>Basaa (Cameroon)</summary>
    public IMessageDescription basCM { get => _bascm!; set => this.AssertWritable()._bascm = value; }
    /// <summary>Belarusian</summary>
    public IMessageDescription be { get => _be!; set => this.AssertWritable()._be = value; }
    /// <summary>Belarusian (Belarus)</summary>
    public IMessageDescription beBY { get => _beby!; set => this.AssertWritable()._beby = value; }
    /// <summary>Bemba</summary>
    public IMessageDescription bem { get => _bem!; set => this.AssertWritable()._bem = value; }
    /// <summary>Bemba (Zambia)</summary>
    public IMessageDescription bemZM { get => _bemzm!; set => this.AssertWritable()._bemzm = value; }
    /// <summary>Bena</summary>
    public IMessageDescription bez { get => _bez!; set => this.AssertWritable()._bez = value; }
    /// <summary>Bena (Tanzania)</summary>
    public IMessageDescription bezTZ { get => _beztz!; set => this.AssertWritable()._beztz = value; }
    /// <summary>Bulgarian</summary>
    public IMessageDescription bg { get => _bg!; set => this.AssertWritable()._bg = value; }
    /// <summary>Bulgarian (Bulgaria)</summary>
    public IMessageDescription bgBG { get => _bgbg!; set => this.AssertWritable()._bgbg = value; }
    /// <summary>Edo</summary>
    public IMessageDescription bin { get => _bin!; set => this.AssertWritable()._bin = value; }
    /// <summary>Edo (Nigeria)</summary>
    public IMessageDescription binNG { get => _binng!; set => this.AssertWritable()._binng = value; }
    /// <summary>Bambara</summary>
    public IMessageDescription bm { get => _bm!; set => this.AssertWritable()._bm = value; }
    /// <summary>Bambara (Latin)</summary>
    public IMessageDescription bmLatn { get => _bmlatn!; set => this.AssertWritable()._bmlatn = value; }
    /// <summary>Bambara (Latin, Mali)</summary>
    public IMessageDescription bmLatnML { get => _bmlatnml!; set => this.AssertWritable()._bmlatnml = value; }
    /// <summary>Bamanankan (Latin, Mali)</summary>
    public IMessageDescription bmML { get => _bmml!; set => this.AssertWritable()._bmml = value; }
    /// <summary>Bangla</summary>
    public IMessageDescription bn { get => _bn!; set => this.AssertWritable()._bn = value; }
    /// <summary>Bangla (Bangladesh)</summary>
    public IMessageDescription bnBD { get => _bnbd!; set => this.AssertWritable()._bnbd = value; }
    /// <summary>Bangla (India)</summary>
    public IMessageDescription bnIN { get => _bnin!; set => this.AssertWritable()._bnin = value; }
    /// <summary>Tibetan</summary>
    public IMessageDescription bo { get => _bo!; set => this.AssertWritable()._bo = value; }
    /// <summary>Tibetan (PRC)</summary>
    public IMessageDescription boCN { get => _bocn!; set => this.AssertWritable()._bocn = value; }
    /// <summary>Tibetan (India)</summary>
    public IMessageDescription boIN { get => _boin!; set => this.AssertWritable()._boin = value; }
    /// <summary>Breton</summary>
    public IMessageDescription br { get => _br!; set => this.AssertWritable()._br = value; }
    /// <summary>Breton (France)</summary>
    public IMessageDescription brFR { get => _brfr!; set => this.AssertWritable()._brfr = value; }
    /// <summary>Bodo</summary>
    public IMessageDescription brx { get => _brx!; set => this.AssertWritable()._brx = value; }
    /// <summary>Bodo (India)</summary>
    public IMessageDescription brxIN { get => _brxin!; set => this.AssertWritable()._brxin = value; }
    /// <summary>Bosnian</summary>
    public IMessageDescription bs { get => _bs!; set => this.AssertWritable()._bs = value; }
    /// <summary>Bosnian (Cyrillic)</summary>
    public IMessageDescription bsCyrl { get => _bscyrl!; set => this.AssertWritable()._bscyrl = value; }
    /// <summary>Bosnian (Cyrillic, Bosnia and Herzegovina)</summary>
    public IMessageDescription bsCyrlBA { get => _bscyrlba!; set => this.AssertWritable()._bscyrlba = value; }
    /// <summary>Bosnian (Latin)</summary>
    public IMessageDescription bsLatn { get => _bslatn!; set => this.AssertWritable()._bslatn = value; }
    /// <summary>Bosnian (Latin, Bosnia and Herzegovina)</summary>
    public IMessageDescription bsLatnBA { get => _bslatnba!; set => this.AssertWritable()._bslatnba = value; }
    /// <summary>Blin</summary>
    public IMessageDescription byn { get => _byn!; set => this.AssertWritable()._byn = value; }
    /// <summary>Blin (Eritrea)</summary>
    public IMessageDescription bynER { get => _byner!; set => this.AssertWritable()._byner = value; }
    /// <summary>Catalan</summary>
    public IMessageDescription ca { get => _ca!; set => this.AssertWritable()._ca = value; }
    /// <summary>Catalan (Andorra)</summary>
    public IMessageDescription caAD { get => _caad!; set => this.AssertWritable()._caad = value; }
    /// <summary>Catalan (Catalan)</summary>
    public IMessageDescription caES { get => _caes!; set => this.AssertWritable()._caes = value; }
    /// <summary>Valencian (Spain)</summary>
    public IMessageDescription caESvalencia { get => _caesvalencia!; set => this.AssertWritable()._caesvalencia = value; }
    /// <summary>Catalan (France)</summary>
    public IMessageDescription caFR { get => _cafr!; set => this.AssertWritable()._cafr = value; }
    /// <summary>Catalan (Italy)</summary>
    public IMessageDescription caIT { get => _cait!; set => this.AssertWritable()._cait = value; }
    /// <summary>Chiga</summary>
    public IMessageDescription cgg { get => _cgg!; set => this.AssertWritable()._cgg = value; }
    /// <summary>Chiga (Uganda)</summary>
    public IMessageDescription cggUG { get => _cggug!; set => this.AssertWritable()._cggug = value; }
    /// <summary>Cherokee</summary>
    public IMessageDescription chr { get => _chr!; set => this.AssertWritable()._chr = value; }
    /// <summary>Cherokee (Cherokee)</summary>
    public IMessageDescription chrCher { get => _chrcher!; set => this.AssertWritable()._chrcher = value; }
    /// <summary>Cherokee (Cherokee)</summary>
    public IMessageDescription chrCherUS { get => _chrcherus!; set => this.AssertWritable()._chrcherus = value; }
    /// <summary>Corsican</summary>
    public IMessageDescription co { get => _co!; set => this.AssertWritable()._co = value; }
    /// <summary>Corsican (France)</summary>
    public IMessageDescription coFR { get => _cofr!; set => this.AssertWritable()._cofr = value; }
    /// <summary>Czech</summary>
    public IMessageDescription cs { get => _cs!; set => this.AssertWritable()._cs = value; }
    /// <summary>Czech (Czech Republic)</summary>
    public IMessageDescription csCZ { get => _cscz!; set => this.AssertWritable()._cscz = value; }
    /// <summary>Welsh</summary>
    public IMessageDescription cy { get => _cy!; set => this.AssertWritable()._cy = value; }
    /// <summary>Welsh (United Kingdom)</summary>
    public IMessageDescription cyGB { get => _cygb!; set => this.AssertWritable()._cygb = value; }
    /// <summary>Danish</summary>
    public IMessageDescription da { get => _da!; set => this.AssertWritable()._da = value; }
    /// <summary>Danish (Denmark)</summary>
    public IMessageDescription daDK { get => _dadk!; set => this.AssertWritable()._dadk = value; }
    /// <summary>Danish (Greenland)</summary>
    public IMessageDescription daGL { get => _dagl!; set => this.AssertWritable()._dagl = value; }
    /// <summary>Taita</summary>
    public IMessageDescription dav { get => _dav!; set => this.AssertWritable()._dav = value; }
    /// <summary>Taita (Kenya)</summary>
    public IMessageDescription davKE { get => _davke!; set => this.AssertWritable()._davke = value; }
    /// <summary>German</summary>
    public IMessageDescription de { get => _de!; set => this.AssertWritable()._de = value; }
    /// <summary>German (Austria)</summary>
    public IMessageDescription deAT { get => _deat!; set => this.AssertWritable()._deat = value; }
    /// <summary>German (Belgium)</summary>
    public IMessageDescription deBE { get => _debe!; set => this.AssertWritable()._debe = value; }
    /// <summary>German (Switzerland)</summary>
    public IMessageDescription deCH { get => _dech!; set => this.AssertWritable()._dech = value; }
    /// <summary>German (Germany)</summary>
    public IMessageDescription deDE { get => _dede!; set => this.AssertWritable()._dede = value; }
    /// <summary>German (Germany)</summary>
    public IMessageDescription deDEphoneb { get => _dedephoneb!; set => this.AssertWritable()._dedephoneb = value; }
    /// <summary>German (Liechtenstein)</summary>
    public IMessageDescription deLI { get => _deli!; set => this.AssertWritable()._deli = value; }
    /// <summary>German (Luxembourg)</summary>
    public IMessageDescription deLU { get => _delu!; set => this.AssertWritable()._delu = value; }
    /// <summary>Zarma</summary>
    public IMessageDescription dje { get => _dje!; set => this.AssertWritable()._dje = value; }
    /// <summary>Zarma (Niger)</summary>
    public IMessageDescription djeNE { get => _djene!; set => this.AssertWritable()._djene = value; }
    /// <summary>Lower Sorbian</summary>
    public IMessageDescription dsb { get => _dsb!; set => this.AssertWritable()._dsb = value; }
    /// <summary>Lower Sorbian (Germany)</summary>
    public IMessageDescription dsbDE { get => _dsbde!; set => this.AssertWritable()._dsbde = value; }
    /// <summary>Duala</summary>
    public IMessageDescription dua { get => _dua!; set => this.AssertWritable()._dua = value; }
    /// <summary>Duala (Cameroon)</summary>
    public IMessageDescription duaCM { get => _duacm!; set => this.AssertWritable()._duacm = value; }
    /// <summary>Divehi</summary>
    public IMessageDescription dv { get => _dv!; set => this.AssertWritable()._dv = value; }
    /// <summary>Divehi (Maldives)</summary>
    public IMessageDescription dvMV { get => _dvmv!; set => this.AssertWritable()._dvmv = value; }
    /// <summary>Jola-Fonyi</summary>
    public IMessageDescription dyo { get => _dyo!; set => this.AssertWritable()._dyo = value; }
    /// <summary>Jola-Fonyi (Senegal)</summary>
    public IMessageDescription dyoSN { get => _dyosn!; set => this.AssertWritable()._dyosn = value; }
    /// <summary>Dzongkha</summary>
    public IMessageDescription dz { get => _dz!; set => this.AssertWritable()._dz = value; }
    /// <summary>Dzongkha (Bhutan)</summary>
    public IMessageDescription dzBT { get => _dzbt!; set => this.AssertWritable()._dzbt = value; }
    /// <summary>Embu</summary>
    public IMessageDescription ebu { get => _ebu!; set => this.AssertWritable()._ebu = value; }
    /// <summary>Embu (Kenya)</summary>
    public IMessageDescription ebuKE { get => _ebuke!; set => this.AssertWritable()._ebuke = value; }
    /// <summary>Ewe</summary>
    public IMessageDescription ee { get => _ee!; set => this.AssertWritable()._ee = value; }
    /// <summary>Ewe (Ghana)</summary>
    public IMessageDescription eeGH { get => _eegh!; set => this.AssertWritable()._eegh = value; }
    /// <summary>Ewe (Togo)</summary>
    public IMessageDescription eeTG { get => _eetg!; set => this.AssertWritable()._eetg = value; }
    /// <summary>Greek</summary>
    public IMessageDescription el { get => _el!; set => this.AssertWritable()._el = value; }
    /// <summary>Greek (Cyprus)</summary>
    public IMessageDescription elCY { get => _elcy!; set => this.AssertWritable()._elcy = value; }
    /// <summary>Greek (Greece)</summary>
    public IMessageDescription elGR { get => _elgr!; set => this.AssertWritable()._elgr = value; }
    /// <summary>English</summary>
    public IMessageDescription en { get => _en!; set => this.AssertWritable()._en = value; }
    /// <summary>English (World)</summary>
    public IMessageDescription en001 { get => _en001!; set => this.AssertWritable()._en001 = value; }
    /// <summary>English (Caribbean)</summary>
    public IMessageDescription en029 { get => _en029!; set => this.AssertWritable()._en029 = value; }
    /// <summary>English (Europe)</summary>
    public IMessageDescription en150 { get => _en150!; set => this.AssertWritable()._en150 = value; }
    /// <summary>English (Antigua and Barbuda)</summary>
    public IMessageDescription enAG { get => _enag!; set => this.AssertWritable()._enag = value; }
    /// <summary>English (Anguilla)</summary>
    public IMessageDescription enAI { get => _enai!; set => this.AssertWritable()._enai = value; }
    /// <summary>English (American Samoa)</summary>
    public IMessageDescription enAS { get => _enas!; set => this.AssertWritable()._enas = value; }
    /// <summary>English (Australia)</summary>
    public IMessageDescription enAU { get => _enau!; set => this.AssertWritable()._enau = value; }
    /// <summary>English (Barbados)</summary>
    public IMessageDescription enBB { get => _enbb!; set => this.AssertWritable()._enbb = value; }
    /// <summary>English (Belgium)</summary>
    public IMessageDescription enBE { get => _enbe!; set => this.AssertWritable()._enbe = value; }
    /// <summary>English (Bermuda)</summary>
    public IMessageDescription enBM { get => _enbm!; set => this.AssertWritable()._enbm = value; }
    /// <summary>English (Bahamas)</summary>
    public IMessageDescription enBS { get => _enbs!; set => this.AssertWritable()._enbs = value; }
    /// <summary>English (Botswana)</summary>
    public IMessageDescription enBW { get => _enbw!; set => this.AssertWritable()._enbw = value; }
    /// <summary>English (Belize)</summary>
    public IMessageDescription enBZ { get => _enbz!; set => this.AssertWritable()._enbz = value; }
    /// <summary>English (Canada)</summary>
    public IMessageDescription enCA { get => _enca!; set => this.AssertWritable()._enca = value; }
    /// <summary>English (Cocos [Keeling] Islands)</summary>
    public IMessageDescription enCC { get => _encc!; set => this.AssertWritable()._encc = value; }
    /// <summary>English (Cook Islands)</summary>
    public IMessageDescription enCK { get => _enck!; set => this.AssertWritable()._enck = value; }
    /// <summary>English (Cameroon)</summary>
    public IMessageDescription enCM { get => _encm!; set => this.AssertWritable()._encm = value; }
    /// <summary>English (Christmas Island)</summary>
    public IMessageDescription enCX { get => _encx!; set => this.AssertWritable()._encx = value; }
    /// <summary>English (Dominica)</summary>
    public IMessageDescription enDM { get => _endm!; set => this.AssertWritable()._endm = value; }
    /// <summary>English (Eritrea)</summary>
    public IMessageDescription enER { get => _ener!; set => this.AssertWritable()._ener = value; }
    /// <summary>English (Fiji)</summary>
    public IMessageDescription enFJ { get => _enfj!; set => this.AssertWritable()._enfj = value; }
    /// <summary>English (Falkland Islands)</summary>
    public IMessageDescription enFK { get => _enfk!; set => this.AssertWritable()._enfk = value; }
    /// <summary>English (Micronesia)</summary>
    public IMessageDescription enFM { get => _enfm!; set => this.AssertWritable()._enfm = value; }
    /// <summary>English (United Kingdom)</summary>
    public IMessageDescription enGB { get => _engb!; set => this.AssertWritable()._engb = value; }
    /// <summary>English (Grenada)</summary>
    public IMessageDescription enGD { get => _engd!; set => this.AssertWritable()._engd = value; }
    /// <summary>English (Guernsey)</summary>
    public IMessageDescription enGG { get => _engg!; set => this.AssertWritable()._engg = value; }
    /// <summary>English (Ghana)</summary>
    public IMessageDescription enGH { get => _engh!; set => this.AssertWritable()._engh = value; }
    /// <summary>English (Gibraltar)</summary>
    public IMessageDescription enGI { get => _engi!; set => this.AssertWritable()._engi = value; }
    /// <summary>English (Gambia)</summary>
    public IMessageDescription enGM { get => _engm!; set => this.AssertWritable()._engm = value; }
    /// <summary>English (Guam)</summary>
    public IMessageDescription enGU { get => _engu!; set => this.AssertWritable()._engu = value; }
    /// <summary>English (Guyana)</summary>
    public IMessageDescription enGY { get => _engy!; set => this.AssertWritable()._engy = value; }
    /// <summary>English (Hong Kong SAR)</summary>
    public IMessageDescription enHK { get => _enhk!; set => this.AssertWritable()._enhk = value; }
    /// <summary>English (Indonesia)</summary>
    public IMessageDescription enID { get => _enid!; set => this.AssertWritable()._enid = value; }
    /// <summary>English (Ireland)</summary>
    public IMessageDescription enIE { get => _enie!; set => this.AssertWritable()._enie = value; }
    /// <summary>English (Isle of Man)</summary>
    public IMessageDescription enIM { get => _enim!; set => this.AssertWritable()._enim = value; }
    /// <summary>English (India)</summary>
    public IMessageDescription enIN { get => _enin!; set => this.AssertWritable()._enin = value; }
    /// <summary>English (British Indian Ocean Territory)</summary>
    public IMessageDescription enIO { get => _enio!; set => this.AssertWritable()._enio = value; }
    /// <summary>English (Jersey)</summary>
    public IMessageDescription enJE { get => _enje!; set => this.AssertWritable()._enje = value; }
    /// <summary>English (Jamaica)</summary>
    public IMessageDescription enJM { get => _enjm!; set => this.AssertWritable()._enjm = value; }
    /// <summary>English (Kenya)</summary>
    public IMessageDescription enKE { get => _enke!; set => this.AssertWritable()._enke = value; }
    /// <summary>English (Kiribati)</summary>
    public IMessageDescription enKI { get => _enki!; set => this.AssertWritable()._enki = value; }
    /// <summary>English (Saint Kitts and Nevis)</summary>
    public IMessageDescription enKN { get => _enkn!; set => this.AssertWritable()._enkn = value; }
    /// <summary>English (Cayman Islands)</summary>
    public IMessageDescription enKY { get => _enky!; set => this.AssertWritable()._enky = value; }
    /// <summary>English (Saint Lucia)</summary>
    public IMessageDescription enLC { get => _enlc!; set => this.AssertWritable()._enlc = value; }
    /// <summary>English (Liberia)</summary>
    public IMessageDescription enLR { get => _enlr!; set => this.AssertWritable()._enlr = value; }
    /// <summary>English (Lesotho)</summary>
    public IMessageDescription enLS { get => _enls!; set => this.AssertWritable()._enls = value; }
    /// <summary>English (Madagascar)</summary>
    public IMessageDescription enMG { get => _enmg!; set => this.AssertWritable()._enmg = value; }
    /// <summary>English (Marshall Islands)</summary>
    public IMessageDescription enMH { get => _enmh!; set => this.AssertWritable()._enmh = value; }
    /// <summary>English (Macao SAR)</summary>
    public IMessageDescription enMO { get => _enmo!; set => this.AssertWritable()._enmo = value; }
    /// <summary>English (Northern Mariana Islands)</summary>
    public IMessageDescription enMP { get => _enmp!; set => this.AssertWritable()._enmp = value; }
    /// <summary>English (Montserrat)</summary>
    public IMessageDescription enMS { get => _enms!; set => this.AssertWritable()._enms = value; }
    /// <summary>English (Malta)</summary>
    public IMessageDescription enMT { get => _enmt!; set => this.AssertWritable()._enmt = value; }
    /// <summary>English (Mauritius)</summary>
    public IMessageDescription enMU { get => _enmu!; set => this.AssertWritable()._enmu = value; }
    /// <summary>English (Malawi)</summary>
    public IMessageDescription enMW { get => _enmw!; set => this.AssertWritable()._enmw = value; }
    /// <summary>English (Malaysia)</summary>
    public IMessageDescription enMY { get => _enmy!; set => this.AssertWritable()._enmy = value; }
    /// <summary>English (Namibia)</summary>
    public IMessageDescription enNA { get => _enna!; set => this.AssertWritable()._enna = value; }
    /// <summary>English (Norfolk Island)</summary>
    public IMessageDescription enNF { get => _ennf!; set => this.AssertWritable()._ennf = value; }
    /// <summary>English (Nigeria)</summary>
    public IMessageDescription enNG { get => _enng!; set => this.AssertWritable()._enng = value; }
    /// <summary>English (Nauru)</summary>
    public IMessageDescription enNR { get => _ennr!; set => this.AssertWritable()._ennr = value; }
    /// <summary>English (Niue)</summary>
    public IMessageDescription enNU { get => _ennu!; set => this.AssertWritable()._ennu = value; }
    /// <summary>English (New Zealand)</summary>
    public IMessageDescription enNZ { get => _ennz!; set => this.AssertWritable()._ennz = value; }
    /// <summary>English (Papua New Guinea)</summary>
    public IMessageDescription enPG { get => _enpg!; set => this.AssertWritable()._enpg = value; }
    /// <summary>English (Republic of the Philippines)</summary>
    public IMessageDescription enPH { get => _enph!; set => this.AssertWritable()._enph = value; }
    /// <summary>English (Pakistan)</summary>
    public IMessageDescription enPK { get => _enpk!; set => this.AssertWritable()._enpk = value; }
    /// <summary>English (Pitcairn Islands)</summary>
    public IMessageDescription enPN { get => _enpn!; set => this.AssertWritable()._enpn = value; }
    /// <summary>English (Puerto Rico)</summary>
    public IMessageDescription enPR { get => _enpr!; set => this.AssertWritable()._enpr = value; }
    /// <summary>English (Palau)</summary>
    public IMessageDescription enPW { get => _enpw!; set => this.AssertWritable()._enpw = value; }
    /// <summary>English (Rwanda)</summary>
    public IMessageDescription enRW { get => _enrw!; set => this.AssertWritable()._enrw = value; }
    /// <summary>English (Solomon Islands)</summary>
    public IMessageDescription enSB { get => _ensb!; set => this.AssertWritable()._ensb = value; }
    /// <summary>English (Seychelles)</summary>
    public IMessageDescription enSC { get => _ensc!; set => this.AssertWritable()._ensc = value; }
    /// <summary>English (Sudan)</summary>
    public IMessageDescription enSD { get => _ensd!; set => this.AssertWritable()._ensd = value; }
    /// <summary>English (Singapore)</summary>
    public IMessageDescription enSG { get => _ensg!; set => this.AssertWritable()._ensg = value; }
    /// <summary>English (St Helena, Ascension, Tristan da Cunha)</summary>
    public IMessageDescription enSH { get => _ensh!; set => this.AssertWritable()._ensh = value; }
    /// <summary>English (Sierra Leone)</summary>
    public IMessageDescription enSL { get => _ensl!; set => this.AssertWritable()._ensl = value; }
    /// <summary>English (South Sudan)</summary>
    public IMessageDescription enSS { get => _enss!; set => this.AssertWritable()._enss = value; }
    /// <summary>English (Sint Maarten)</summary>
    public IMessageDescription enSX { get => _ensx!; set => this.AssertWritable()._ensx = value; }
    /// <summary>English (Swaziland)</summary>
    public IMessageDescription enSZ { get => _ensz!; set => this.AssertWritable()._ensz = value; }
    /// <summary>English (Turks and Caicos Islands)</summary>
    public IMessageDescription enTC { get => _entc!; set => this.AssertWritable()._entc = value; }
    /// <summary>English (Tokelau)</summary>
    public IMessageDescription enTK { get => _entk!; set => this.AssertWritable()._entk = value; }
    /// <summary>English (Tonga)</summary>
    public IMessageDescription enTO { get => _ento!; set => this.AssertWritable()._ento = value; }
    /// <summary>English (Trinidad and Tobago)</summary>
    public IMessageDescription enTT { get => _entt!; set => this.AssertWritable()._entt = value; }
    /// <summary>English (Tuvalu)</summary>
    public IMessageDescription enTV { get => _entv!; set => this.AssertWritable()._entv = value; }
    /// <summary>English (Tanzania)</summary>
    public IMessageDescription enTZ { get => _entz!; set => this.AssertWritable()._entz = value; }
    /// <summary>English (Uganda)</summary>
    public IMessageDescription enUG { get => _enug!; set => this.AssertWritable()._enug = value; }
    /// <summary>English (US Minor Outlying Islands)</summary>
    public IMessageDescription enUM { get => _enum!; set => this.AssertWritable()._enum = value; }
    /// <summary>English (United States)</summary>
    public IMessageDescription enUS { get => _enus!; set => this.AssertWritable()._enus = value; }
    /// <summary>English (Saint Vincent and the Grenadines)</summary>
    public IMessageDescription enVC { get => _envc!; set => this.AssertWritable()._envc = value; }
    /// <summary>English (British Virgin Islands)</summary>
    public IMessageDescription enVG { get => _envg!; set => this.AssertWritable()._envg = value; }
    /// <summary>English (US Virgin Islands)</summary>
    public IMessageDescription enVI { get => _envi!; set => this.AssertWritable()._envi = value; }
    /// <summary>English (Vanuatu)</summary>
    public IMessageDescription enVU { get => _envu!; set => this.AssertWritable()._envu = value; }
    /// <summary>English (Samoa)</summary>
    public IMessageDescription enWS { get => _enws!; set => this.AssertWritable()._enws = value; }
    /// <summary>English (South Africa)</summary>
    public IMessageDescription enZA { get => _enza!; set => this.AssertWritable()._enza = value; }
    /// <summary>English (Zambia)</summary>
    public IMessageDescription enZM { get => _enzm!; set => this.AssertWritable()._enzm = value; }
    /// <summary>English (Zimbabwe)</summary>
    public IMessageDescription enZW { get => _enzw!; set => this.AssertWritable()._enzw = value; }
    /// <summary>Esperanto</summary>
    public IMessageDescription eo { get => _eo!; set => this.AssertWritable()._eo = value; }
    /// <summary>Esperanto (World)</summary>
    public IMessageDescription eo001 { get => _eo001!; set => this.AssertWritable()._eo001 = value; }
    /// <summary>Spanish</summary>
    public IMessageDescription es { get => _es!; set => this.AssertWritable()._es = value; }
    /// <summary>Spanish (Latin America)</summary>
    public IMessageDescription es419 { get => _es419!; set => this.AssertWritable()._es419 = value; }
    /// <summary>Spanish (Argentina)</summary>
    public IMessageDescription esAR { get => _esar!; set => this.AssertWritable()._esar = value; }
    /// <summary>Spanish (Bolivia)</summary>
    public IMessageDescription esBO { get => _esbo!; set => this.AssertWritable()._esbo = value; }
    /// <summary>Spanish (Chile)</summary>
    public IMessageDescription esCL { get => _escl!; set => this.AssertWritable()._escl = value; }
    /// <summary>Spanish (Colombia)</summary>
    public IMessageDescription esCO { get => _esco!; set => this.AssertWritable()._esco = value; }
    /// <summary>Spanish (Costa Rica)</summary>
    public IMessageDescription esCR { get => _escr!; set => this.AssertWritable()._escr = value; }
    /// <summary>Spanish (Cuba)</summary>
    public IMessageDescription esCU { get => _escu!; set => this.AssertWritable()._escu = value; }
    /// <summary>Spanish (Dominican Republic)</summary>
    public IMessageDescription esDO { get => _esdo!; set => this.AssertWritable()._esdo = value; }
    /// <summary>Spanish (Ecuador)</summary>
    public IMessageDescription esEC { get => _esec!; set => this.AssertWritable()._esec = value; }
    /// <summary>Spanish (Spain)</summary>
    public IMessageDescription esES { get => _eses!; set => this.AssertWritable()._eses = value; }
    /// <summary>Spanish (Spain)</summary>
    public IMessageDescription esEStradnl { get => _esestradnl!; set => this.AssertWritable()._esestradnl = value; }
    /// <summary>Spanish (Equatorial Guinea)</summary>
    public IMessageDescription esGQ { get => _esgq!; set => this.AssertWritable()._esgq = value; }
    /// <summary>Spanish (Guatemala)</summary>
    public IMessageDescription esGT { get => _esgt!; set => this.AssertWritable()._esgt = value; }
    /// <summary>Spanish (Honduras)</summary>
    public IMessageDescription esHN { get => _eshn!; set => this.AssertWritable()._eshn = value; }
    /// <summary>Spanish (Mexico)</summary>
    public IMessageDescription esMX { get => _esmx!; set => this.AssertWritable()._esmx = value; }
    /// <summary>Spanish (Nicaragua)</summary>
    public IMessageDescription esNI { get => _esni!; set => this.AssertWritable()._esni = value; }
    /// <summary>Spanish (Panama)</summary>
    public IMessageDescription esPA { get => _espa!; set => this.AssertWritable()._espa = value; }
    /// <summary>Spanish (Peru)</summary>
    public IMessageDescription esPE { get => _espe!; set => this.AssertWritable()._espe = value; }
    /// <summary>Spanish (Philippines)</summary>
    public IMessageDescription esPH { get => _esph!; set => this.AssertWritable()._esph = value; }
    /// <summary>Spanish (Puerto Rico)</summary>
    public IMessageDescription esPR { get => _espr!; set => this.AssertWritable()._espr = value; }
    /// <summary>Spanish (Paraguay)</summary>
    public IMessageDescription esPY { get => _espy!; set => this.AssertWritable()._espy = value; }
    /// <summary>Spanish (El Salvador)</summary>
    public IMessageDescription esSV { get => _essv!; set => this.AssertWritable()._essv = value; }
    /// <summary>Spanish (United States)</summary>
    public IMessageDescription esUS { get => _esus!; set => this.AssertWritable()._esus = value; }
    /// <summary>Spanish (Uruguay)</summary>
    public IMessageDescription esUY { get => _esuy!; set => this.AssertWritable()._esuy = value; }
    /// <summary>Spanish (Bolivarian Republic of Venezuela)</summary>
    public IMessageDescription esVE { get => _esve!; set => this.AssertWritable()._esve = value; }
    /// <summary>Estonian</summary>
    public IMessageDescription et { get => _et!; set => this.AssertWritable()._et = value; }
    /// <summary>Estonian (Estonia)</summary>
    public IMessageDescription etEE { get => _etee!; set => this.AssertWritable()._etee = value; }
    /// <summary>Basque</summary>
    public IMessageDescription eu { get => _eu!; set => this.AssertWritable()._eu = value; }
    /// <summary>Basque (Basque)</summary>
    public IMessageDescription euES { get => _eues!; set => this.AssertWritable()._eues = value; }
    /// <summary>Ewondo</summary>
    public IMessageDescription ewo { get => _ewo!; set => this.AssertWritable()._ewo = value; }
    /// <summary>Ewondo (Cameroon)</summary>
    public IMessageDescription ewoCM { get => _ewocm!; set => this.AssertWritable()._ewocm = value; }
    /// <summary>Persian</summary>
    public IMessageDescription fa { get => _fa!; set => this.AssertWritable()._fa = value; }
    /// <summary>Persian (Afghanistan)</summary>
    public IMessageDescription faAF { get => _faaf!; set => this.AssertWritable()._faaf = value; }
    /// <summary>Persian (Iran)</summary>
    public IMessageDescription faIR { get => _fair!; set => this.AssertWritable()._fair = value; }
    /// <summary>Fulah</summary>
    public IMessageDescription ff { get => _ff!; set => this.AssertWritable()._ff = value; }
    /// <summary>Fulah (Cameroon)</summary>
    public IMessageDescription ffCM { get => _ffcm!; set => this.AssertWritable()._ffcm = value; }
    /// <summary>Fulah (Guinea)</summary>
    public IMessageDescription ffGN { get => _ffgn!; set => this.AssertWritable()._ffgn = value; }
    /// <summary>Fulah (Latin)</summary>
    public IMessageDescription ffLatn { get => _fflatn!; set => this.AssertWritable()._fflatn = value; }
    /// <summary>Fulah (Latin, Senegal)</summary>
    public IMessageDescription ffLatnSN { get => _fflatnsn!; set => this.AssertWritable()._fflatnsn = value; }
    /// <summary>Fulah (Mauritania)</summary>
    public IMessageDescription ffMR { get => _ffmr!; set => this.AssertWritable()._ffmr = value; }
    /// <summary>Fulah (Nigeria)</summary>
    public IMessageDescription ffNG { get => _ffng!; set => this.AssertWritable()._ffng = value; }
    /// <summary>Finnish</summary>
    public IMessageDescription fi { get => _fi!; set => this.AssertWritable()._fi = value; }
    /// <summary>Finnish (Finland)</summary>
    public IMessageDescription fiFI { get => _fifi!; set => this.AssertWritable()._fifi = value; }
    /// <summary>Filipino</summary>
    public IMessageDescription fil { get => _fil!; set => this.AssertWritable()._fil = value; }
    /// <summary>Filipino (Philippines)</summary>
    public IMessageDescription filPH { get => _filph!; set => this.AssertWritable()._filph = value; }
    /// <summary>Faroese</summary>
    public IMessageDescription fo { get => _fo!; set => this.AssertWritable()._fo = value; }
    /// <summary>Faroese (Faroe Islands)</summary>
    public IMessageDescription foFO { get => _fofo!; set => this.AssertWritable()._fofo = value; }
    /// <summary>French</summary>
    public IMessageDescription fr { get => _fr!; set => this.AssertWritable()._fr = value; }
    /// <summary>French (Caribbean)</summary>
    public IMessageDescription fr029 { get => _fr029!; set => this.AssertWritable()._fr029 = value; }
    /// <summary>French (Belgium)</summary>
    public IMessageDescription frBE { get => _frbe!; set => this.AssertWritable()._frbe = value; }
    /// <summary>French (Burkina Faso)</summary>
    public IMessageDescription frBF { get => _frbf!; set => this.AssertWritable()._frbf = value; }
    /// <summary>French (Burundi)</summary>
    public IMessageDescription frBI { get => _frbi!; set => this.AssertWritable()._frbi = value; }
    /// <summary>French (Benin)</summary>
    public IMessageDescription frBJ { get => _frbj!; set => this.AssertWritable()._frbj = value; }
    /// <summary>French (Saint Barth&#233;lemy)</summary>
    public IMessageDescription frBL { get => _frbl!; set => this.AssertWritable()._frbl = value; }
    /// <summary>French (Canada)</summary>
    public IMessageDescription frCA { get => _frca!; set => this.AssertWritable()._frca = value; }
    /// <summary>French (Congo DRC)</summary>
    public IMessageDescription frCD { get => _frcd!; set => this.AssertWritable()._frcd = value; }
    /// <summary>French (Central African Republic)</summary>
    public IMessageDescription frCF { get => _frcf!; set => this.AssertWritable()._frcf = value; }
    /// <summary>French (Congo)</summary>
    public IMessageDescription frCG { get => _frcg!; set => this.AssertWritable()._frcg = value; }
    /// <summary>French (Switzerland)</summary>
    public IMessageDescription frCH { get => _frch!; set => this.AssertWritable()._frch = value; }
    /// <summary>French (C&#244;te d’Ivoire)</summary>
    public IMessageDescription frCI { get => _frci!; set => this.AssertWritable()._frci = value; }
    /// <summary>French (Cameroon)</summary>
    public IMessageDescription frCM { get => _frcm!; set => this.AssertWritable()._frcm = value; }
    /// <summary>French (Djibouti)</summary>
    public IMessageDescription frDJ { get => _frdj!; set => this.AssertWritable()._frdj = value; }
    /// <summary>French (Algeria)</summary>
    public IMessageDescription frDZ { get => _frdz!; set => this.AssertWritable()._frdz = value; }
    /// <summary>French (France)</summary>
    public IMessageDescription frFR { get => _frfr!; set => this.AssertWritable()._frfr = value; }
    /// <summary>French (Gabon)</summary>
    public IMessageDescription frGA { get => _frga!; set => this.AssertWritable()._frga = value; }
    /// <summary>French (French Guiana)</summary>
    public IMessageDescription frGF { get => _frgf!; set => this.AssertWritable()._frgf = value; }
    /// <summary>French (Guinea)</summary>
    public IMessageDescription frGN { get => _frgn!; set => this.AssertWritable()._frgn = value; }
    /// <summary>French (Guadeloupe)</summary>
    public IMessageDescription frGP { get => _frgp!; set => this.AssertWritable()._frgp = value; }
    /// <summary>French (Equatorial Guinea)</summary>
    public IMessageDescription frGQ { get => _frgq!; set => this.AssertWritable()._frgq = value; }
    /// <summary>French (Haiti)</summary>
    public IMessageDescription frHT { get => _frht!; set => this.AssertWritable()._frht = value; }
    /// <summary>French (Comoros)</summary>
    public IMessageDescription frKM { get => _frkm!; set => this.AssertWritable()._frkm = value; }
    /// <summary>French (Luxembourg)</summary>
    public IMessageDescription frLU { get => _frlu!; set => this.AssertWritable()._frlu = value; }
    /// <summary>French (Morocco)</summary>
    public IMessageDescription frMA { get => _frma!; set => this.AssertWritable()._frma = value; }
    /// <summary>French (Monaco)</summary>
    public IMessageDescription frMC { get => _frmc!; set => this.AssertWritable()._frmc = value; }
    /// <summary>French (Saint Martin)</summary>
    public IMessageDescription frMF { get => _frmf!; set => this.AssertWritable()._frmf = value; }
    /// <summary>French (Madagascar)</summary>
    public IMessageDescription frMG { get => _frmg!; set => this.AssertWritable()._frmg = value; }
    /// <summary>French (Mali)</summary>
    public IMessageDescription frML { get => _frml!; set => this.AssertWritable()._frml = value; }
    /// <summary>French (Martinique)</summary>
    public IMessageDescription frMQ { get => _frmq!; set => this.AssertWritable()._frmq = value; }
    /// <summary>French (Mauritania)</summary>
    public IMessageDescription frMR { get => _frmr!; set => this.AssertWritable()._frmr = value; }
    /// <summary>French (Mauritius)</summary>
    public IMessageDescription frMU { get => _frmu!; set => this.AssertWritable()._frmu = value; }
    /// <summary>French (New Caledonia)</summary>
    public IMessageDescription frNC { get => _frnc!; set => this.AssertWritable()._frnc = value; }
    /// <summary>French (Niger)</summary>
    public IMessageDescription frNE { get => _frne!; set => this.AssertWritable()._frne = value; }
    /// <summary>French (French Polynesia)</summary>
    public IMessageDescription frPF { get => _frpf!; set => this.AssertWritable()._frpf = value; }
    /// <summary>French (Saint Pierre and Miquelon)</summary>
    public IMessageDescription frPM { get => _frpm!; set => this.AssertWritable()._frpm = value; }
    /// <summary>French (Reunion)</summary>
    public IMessageDescription frRE { get => _frre!; set => this.AssertWritable()._frre = value; }
    /// <summary>French (Rwanda)</summary>
    public IMessageDescription frRW { get => _frrw!; set => this.AssertWritable()._frrw = value; }
    /// <summary>French (Seychelles)</summary>
    public IMessageDescription frSC { get => _frsc!; set => this.AssertWritable()._frsc = value; }
    /// <summary>French (Senegal)</summary>
    public IMessageDescription frSN { get => _frsn!; set => this.AssertWritable()._frsn = value; }
    /// <summary>French (Syria)</summary>
    public IMessageDescription frSY { get => _frsy!; set => this.AssertWritable()._frsy = value; }
    /// <summary>French (Chad)</summary>
    public IMessageDescription frTD { get => _frtd!; set => this.AssertWritable()._frtd = value; }
    /// <summary>French (Togo)</summary>
    public IMessageDescription frTG { get => _frtg!; set => this.AssertWritable()._frtg = value; }
    /// <summary>French (Tunisia)</summary>
    public IMessageDescription frTN { get => _frtn!; set => this.AssertWritable()._frtn = value; }
    /// <summary>French (Vanuatu)</summary>
    public IMessageDescription frVU { get => _frvu!; set => this.AssertWritable()._frvu = value; }
    /// <summary>French (Wallis and Futuna)</summary>
    public IMessageDescription frWF { get => _frwf!; set => this.AssertWritable()._frwf = value; }
    /// <summary>French (Mayotte)</summary>
    public IMessageDescription frYT { get => _fryt!; set => this.AssertWritable()._fryt = value; }
    /// <summary>Friulian</summary>
    public IMessageDescription fur { get => _fur!; set => this.AssertWritable()._fur = value; }
    /// <summary>Friulian (Italy)</summary>
    public IMessageDescription furIT { get => _furit!; set => this.AssertWritable()._furit = value; }
    /// <summary>Frisian</summary>
    public IMessageDescription fy { get => _fy!; set => this.AssertWritable()._fy = value; }
    /// <summary>Frisian (Netherlands)</summary>
    public IMessageDescription fyNL { get => _fynl!; set => this.AssertWritable()._fynl = value; }
    /// <summary>Irish</summary>
    public IMessageDescription ga { get => _ga!; set => this.AssertWritable()._ga = value; }
    /// <summary>Irish (Ireland)</summary>
    public IMessageDescription gaIE { get => _gaie!; set => this.AssertWritable()._gaie = value; }
    /// <summary>Scottish Gaelic</summary>
    public IMessageDescription gd { get => _gd!; set => this.AssertWritable()._gd = value; }
    /// <summary>Scottish Gaelic (United Kingdom)</summary>
    public IMessageDescription gdGB { get => _gdgb!; set => this.AssertWritable()._gdgb = value; }
    /// <summary>Galician</summary>
    public IMessageDescription gl { get => _gl!; set => this.AssertWritable()._gl = value; }
    /// <summary>Galician (Galician)</summary>
    public IMessageDescription glES { get => _gles!; set => this.AssertWritable()._gles = value; }
    /// <summary>Guarani</summary>
    public IMessageDescription gn { get => _gn!; set => this.AssertWritable()._gn = value; }
    /// <summary>Guarani (Paraguay)</summary>
    public IMessageDescription gnPY { get => _gnpy!; set => this.AssertWritable()._gnpy = value; }
    /// <summary>Alsatian</summary>
    public IMessageDescription gsw { get => _gsw!; set => this.AssertWritable()._gsw = value; }
    /// <summary>Alsatian (Switzerland)</summary>
    public IMessageDescription gswCH { get => _gswch!; set => this.AssertWritable()._gswch = value; }
    /// <summary>Alsatian (France)</summary>
    public IMessageDescription gswFR { get => _gswfr!; set => this.AssertWritable()._gswfr = value; }
    /// <summary>Alsatian (Liechtenstein)</summary>
    public IMessageDescription gswLI { get => _gswli!; set => this.AssertWritable()._gswli = value; }
    /// <summary>Gujarati</summary>
    public IMessageDescription gu { get => _gu!; set => this.AssertWritable()._gu = value; }
    /// <summary>Gujarati (India)</summary>
    public IMessageDescription guIN { get => _guin!; set => this.AssertWritable()._guin = value; }
    /// <summary>Gusii</summary>
    public IMessageDescription guz { get => _guz!; set => this.AssertWritable()._guz = value; }
    /// <summary>Gusii (Kenya)</summary>
    public IMessageDescription guzKE { get => _guzke!; set => this.AssertWritable()._guzke = value; }
    /// <summary>Manx</summary>
    public IMessageDescription gv { get => _gv!; set => this.AssertWritable()._gv = value; }
    /// <summary>Manx (Isle of Man)</summary>
    public IMessageDescription gvIM { get => _gvim!; set => this.AssertWritable()._gvim = value; }
    /// <summary>Hausa</summary>
    public IMessageDescription ha { get => _ha!; set => this.AssertWritable()._ha = value; }
    /// <summary>Hausa (Latin)</summary>
    public IMessageDescription haLatn { get => _halatn!; set => this.AssertWritable()._halatn = value; }
    /// <summary>Hausa (Latin, Ghana)</summary>
    public IMessageDescription haLatnGH { get => _halatngh!; set => this.AssertWritable()._halatngh = value; }
    /// <summary>Hausa (Latin, Niger)</summary>
    public IMessageDescription haLatnNE { get => _halatnne!; set => this.AssertWritable()._halatnne = value; }
    /// <summary>Hausa (Latin, Nigeria)</summary>
    public IMessageDescription haLatnNG { get => _halatnng!; set => this.AssertWritable()._halatnng = value; }
    /// <summary>Hawaiian</summary>
    public IMessageDescription haw { get => _haw!; set => this.AssertWritable()._haw = value; }
    /// <summary>Hawaiian (United States)</summary>
    public IMessageDescription hawUS { get => _hawus!; set => this.AssertWritable()._hawus = value; }
    /// <summary>Hebrew</summary>
    public IMessageDescription he { get => _he!; set => this.AssertWritable()._he = value; }
    /// <summary>Hebrew (Israel)</summary>
    public IMessageDescription heIL { get => _heil!; set => this.AssertWritable()._heil = value; }
    /// <summary>Hindi</summary>
    public IMessageDescription hi { get => _hi!; set => this.AssertWritable()._hi = value; }
    /// <summary>Hindi (India)</summary>
    public IMessageDescription hiIN { get => _hiin!; set => this.AssertWritable()._hiin = value; }
    /// <summary>Croatian</summary>
    public IMessageDescription hr { get => _hr!; set => this.AssertWritable()._hr = value; }
    /// <summary>Croatian (Latin, Bosnia and Herzegovina)</summary>
    public IMessageDescription hrBA { get => _hrba!; set => this.AssertWritable()._hrba = value; }
    /// <summary>Croatian (Croatia)</summary>
    public IMessageDescription hrHR { get => _hrhr!; set => this.AssertWritable()._hrhr = value; }
    /// <summary>Upper Sorbian</summary>
    public IMessageDescription hsb { get => _hsb!; set => this.AssertWritable()._hsb = value; }
    /// <summary>Upper Sorbian (Germany)</summary>
    public IMessageDescription hsbDE { get => _hsbde!; set => this.AssertWritable()._hsbde = value; }
    /// <summary>Hungarian</summary>
    public IMessageDescription hu { get => _hu!; set => this.AssertWritable()._hu = value; }
    /// <summary>Hungarian (Hungary)</summary>
    public IMessageDescription huHU { get => _huhu!; set => this.AssertWritable()._huhu = value; }
    /// <summary>Hungarian (Hungary)</summary>
    public IMessageDescription huHUtechnl { get => _huhutechnl!; set => this.AssertWritable()._huhutechnl = value; }
    /// <summary>Armenian</summary>
    public IMessageDescription hy { get => _hy!; set => this.AssertWritable()._hy = value; }
    /// <summary>Armenian (Armenia)</summary>
    public IMessageDescription hyAM { get => _hyam!; set => this.AssertWritable()._hyam = value; }
    /// <summary>Interlingua</summary>
    public IMessageDescription ia { get => _ia!; set => this.AssertWritable()._ia = value; }
    /// <summary>Interlingua (World)</summary>
    public IMessageDescription ia001 { get => _ia001!; set => this.AssertWritable()._ia001 = value; }
    /// <summary>Interlingua (France)</summary>
    public IMessageDescription iaFR { get => _iafr!; set => this.AssertWritable()._iafr = value; }
    /// <summary>Ibibio</summary>
    public IMessageDescription ibb { get => _ibb!; set => this.AssertWritable()._ibb = value; }
    /// <summary>Ibibio (Nigeria)</summary>
    public IMessageDescription ibbNG { get => _ibbng!; set => this.AssertWritable()._ibbng = value; }
    /// <summary>Indonesian</summary>
    public IMessageDescription id { get => _id!; set => this.AssertWritable()._id = value; }
    /// <summary>Indonesian (Indonesia)</summary>
    public IMessageDescription idID { get => _idid!; set => this.AssertWritable()._idid = value; }
    /// <summary>Igbo</summary>
    public IMessageDescription ig { get => _ig!; set => this.AssertWritable()._ig = value; }
    /// <summary>Igbo (Nigeria)</summary>
    public IMessageDescription igNG { get => _igng!; set => this.AssertWritable()._igng = value; }
    /// <summary>Yi</summary>
    public IMessageDescription ii { get => _ii!; set => this.AssertWritable()._ii = value; }
    /// <summary>Yi (PRC)</summary>
    public IMessageDescription iiCN { get => _iicn!; set => this.AssertWritable()._iicn = value; }
    /// <summary>Icelandic</summary>
    public IMessageDescription Is { get => _is!; set => this.AssertWritable()._is = value; }
    /// <summary>Icelandic (Iceland)</summary>
    public IMessageDescription isIS { get => _isis!; set => this.AssertWritable()._isis = value; }
    /// <summary>Italian</summary>
    public IMessageDescription it { get => _it!; set => this.AssertWritable()._it = value; }
    /// <summary>Italian (Switzerland)</summary>
    public IMessageDescription itCH { get => _itch!; set => this.AssertWritable()._itch = value; }
    /// <summary>Italian (Italy)</summary>
    public IMessageDescription itIT { get => _itit!; set => this.AssertWritable()._itit = value; }
    /// <summary>Italian (San Marino)</summary>
    public IMessageDescription itSM { get => _itsm!; set => this.AssertWritable()._itsm = value; }
    /// <summary>Inuktitut</summary>
    public IMessageDescription iu { get => _iu!; set => this.AssertWritable()._iu = value; }
    /// <summary>Inuktitut (Syllabics)</summary>
    public IMessageDescription iuCans { get => _iucans!; set => this.AssertWritable()._iucans = value; }
    /// <summary>Inuktitut (Syllabics, Canada)</summary>
    public IMessageDescription iuCansCA { get => _iucansca!; set => this.AssertWritable()._iucansca = value; }
    /// <summary>Inuktitut (Latin)</summary>
    public IMessageDescription iuLatn { get => _iulatn!; set => this.AssertWritable()._iulatn = value; }
    /// <summary>Inuktitut (Latin, Canada)</summary>
    public IMessageDescription iuLatnCA { get => _iulatnca!; set => this.AssertWritable()._iulatnca = value; }
    /// <summary>Japanese</summary>
    public IMessageDescription ja { get => _ja!; set => this.AssertWritable()._ja = value; }
    /// <summary>Japanese (Japan)</summary>
    public IMessageDescription jaJP { get => _jajp!; set => this.AssertWritable()._jajp = value; }
    /// <summary>Japanese (Japan)</summary>
    public IMessageDescription jaJPradstr { get => _jajpradstr!; set => this.AssertWritable()._jajpradstr = value; }
    /// <summary>Ngomba</summary>
    public IMessageDescription jgo { get => _jgo!; set => this.AssertWritable()._jgo = value; }
    /// <summary>Ngomba (Cameroon)</summary>
    public IMessageDescription jgoCM { get => _jgocm!; set => this.AssertWritable()._jgocm = value; }
    /// <summary>Machame</summary>
    public IMessageDescription jmc { get => _jmc!; set => this.AssertWritable()._jmc = value; }
    /// <summary>Machame (Tanzania)</summary>
    public IMessageDescription jmcTZ { get => _jmctz!; set => this.AssertWritable()._jmctz = value; }
    /// <summary>Javanese</summary>
    public IMessageDescription jv { get => _jv!; set => this.AssertWritable()._jv = value; }
    /// <summary>Javanese (Javanese)</summary>
    public IMessageDescription jvJava { get => _jvjava!; set => this.AssertWritable()._jvjava = value; }
    /// <summary>Javanese (Javanese, Indonesia)</summary>
    public IMessageDescription jvJavaID { get => _jvjavaid!; set => this.AssertWritable()._jvjavaid = value; }
    /// <summary>Javanese</summary>
    public IMessageDescription jvLatn { get => _jvlatn!; set => this.AssertWritable()._jvlatn = value; }
    /// <summary>Javanese (Indonesia)</summary>
    public IMessageDescription jvLatnID { get => _jvlatnid!; set => this.AssertWritable()._jvlatnid = value; }
    /// <summary>Georgian</summary>
    public IMessageDescription ka { get => _ka!; set => this.AssertWritable()._ka = value; }
    /// <summary>Georgian (Georgia)</summary>
    public IMessageDescription kaGE { get => _kage!; set => this.AssertWritable()._kage = value; }
    /// <summary>Georgian (Georgia)</summary>
    public IMessageDescription kaGEmodern { get => _kagemodern!; set => this.AssertWritable()._kagemodern = value; }
    /// <summary>Kabyle</summary>
    public IMessageDescription kab { get => _kab!; set => this.AssertWritable()._kab = value; }
    /// <summary>Kabyle (Algeria)</summary>
    public IMessageDescription kabDZ { get => _kabdz!; set => this.AssertWritable()._kabdz = value; }
    /// <summary>Kamba</summary>
    public IMessageDescription kam { get => _kam!; set => this.AssertWritable()._kam = value; }
    /// <summary>Kamba (Kenya)</summary>
    public IMessageDescription kamKE { get => _kamke!; set => this.AssertWritable()._kamke = value; }
    /// <summary>Makonde</summary>
    public IMessageDescription kde { get => _kde!; set => this.AssertWritable()._kde = value; }
    /// <summary>Makonde (Tanzania)</summary>
    public IMessageDescription kdeTZ { get => _kdetz!; set => this.AssertWritable()._kdetz = value; }
    /// <summary>Kabuverdianu</summary>
    public IMessageDescription kea { get => _kea!; set => this.AssertWritable()._kea = value; }
    /// <summary>Kabuverdianu (Cabo Verde)</summary>
    public IMessageDescription keaCV { get => _keacv!; set => this.AssertWritable()._keacv = value; }
    /// <summary>Koyra Chiini</summary>
    public IMessageDescription khq { get => _khq!; set => this.AssertWritable()._khq = value; }
    /// <summary>Koyra Chiini (Mali)</summary>
    public IMessageDescription khqML { get => _khqml!; set => this.AssertWritable()._khqml = value; }
    /// <summary>Kikuyu</summary>
    public IMessageDescription ki { get => _ki!; set => this.AssertWritable()._ki = value; }
    /// <summary>Kikuyu (Kenya)</summary>
    public IMessageDescription kiKE { get => _kike!; set => this.AssertWritable()._kike = value; }
    /// <summary>Kazakh</summary>
    public IMessageDescription kk { get => _kk!; set => this.AssertWritable()._kk = value; }
    /// <summary>Kazakh (Kazakhstan)</summary>
    public IMessageDescription kkKZ { get => _kkkz!; set => this.AssertWritable()._kkkz = value; }
    /// <summary>Kako</summary>
    public IMessageDescription kkj { get => _kkj!; set => this.AssertWritable()._kkj = value; }
    /// <summary>Kako (Cameroon)</summary>
    public IMessageDescription kkjCM { get => _kkjcm!; set => this.AssertWritable()._kkjcm = value; }
    /// <summary>Greenlandic</summary>
    public IMessageDescription kl { get => _kl!; set => this.AssertWritable()._kl = value; }
    /// <summary>Greenlandic (Greenland)</summary>
    public IMessageDescription klGL { get => _klgl!; set => this.AssertWritable()._klgl = value; }
    /// <summary>Kalenjin</summary>
    public IMessageDescription kln { get => _kln!; set => this.AssertWritable()._kln = value; }
    /// <summary>Kalenjin (Kenya)</summary>
    public IMessageDescription klnKE { get => _klnke!; set => this.AssertWritable()._klnke = value; }
    /// <summary>Khmer</summary>
    public IMessageDescription km { get => _km!; set => this.AssertWritable()._km = value; }
    /// <summary>Khmer (Cambodia)</summary>
    public IMessageDescription kmKH { get => _kmkh!; set => this.AssertWritable()._kmkh = value; }
    /// <summary>Kannada</summary>
    public IMessageDescription kn { get => _kn!; set => this.AssertWritable()._kn = value; }
    /// <summary>Kannada (India)</summary>
    public IMessageDescription knIN { get => _knin!; set => this.AssertWritable()._knin = value; }
    /// <summary>Korean</summary>
    public IMessageDescription ko { get => _ko!; set => this.AssertWritable()._ko = value; }
    /// <summary>Korean (Korea)</summary>
    public IMessageDescription koKR { get => _kokr!; set => this.AssertWritable()._kokr = value; }
    /// <summary>Konkani</summary>
    public IMessageDescription kok { get => _kok!; set => this.AssertWritable()._kok = value; }
    /// <summary>Konkani (India)</summary>
    public IMessageDescription kokIN { get => _kokin!; set => this.AssertWritable()._kokin = value; }
    /// <summary>Kanuri</summary>
    public IMessageDescription kr { get => _kr!; set => this.AssertWritable()._kr = value; }
    /// <summary>Kanuri (Nigeria)</summary>
    public IMessageDescription krNG { get => _krng!; set => this.AssertWritable()._krng = value; }
    /// <summary>Kashmiri</summary>
    public IMessageDescription ks { get => _ks!; set => this.AssertWritable()._ks = value; }
    /// <summary>Kashmiri (Perso-Arabic)</summary>
    public IMessageDescription ksArab { get => _ksarab!; set => this.AssertWritable()._ksarab = value; }
    /// <summary>Kashmiri (Perso-Arabic)</summary>
    public IMessageDescription ksArabIN { get => _ksarabin!; set => this.AssertWritable()._ksarabin = value; }
    /// <summary>Kashmiri (Devanagari)</summary>
    public IMessageDescription ksDeva { get => _ksdeva!; set => this.AssertWritable()._ksdeva = value; }
    /// <summary>Kashmiri (Devanagari, India)</summary>
    public IMessageDescription ksDevaIN { get => _ksdevain!; set => this.AssertWritable()._ksdevain = value; }
    /// <summary>Shambala</summary>
    public IMessageDescription ksb { get => _ksb!; set => this.AssertWritable()._ksb = value; }
    /// <summary>Shambala (Tanzania)</summary>
    public IMessageDescription ksbTZ { get => _ksbtz!; set => this.AssertWritable()._ksbtz = value; }
    /// <summary>Bafia</summary>
    public IMessageDescription ksf { get => _ksf!; set => this.AssertWritable()._ksf = value; }
    /// <summary>Bafia (Cameroon)</summary>
    public IMessageDescription ksfCM { get => _ksfcm!; set => this.AssertWritable()._ksfcm = value; }
    /// <summary>Colognian</summary>
    public IMessageDescription ksh { get => _ksh!; set => this.AssertWritable()._ksh = value; }
    /// <summary>Ripuarian (Germany)</summary>
    public IMessageDescription kshDE { get => _kshde!; set => this.AssertWritable()._kshde = value; }
    /// <summary>Central Kurdish</summary>
    public IMessageDescription ku { get => _ku!; set => this.AssertWritable()._ku = value; }
    /// <summary>Central Kurdish (Arabic)</summary>
    public IMessageDescription kuArab { get => _kuarab!; set => this.AssertWritable()._kuarab = value; }
    /// <summary>Central Kurdish (Iraq)</summary>
    public IMessageDescription kuArabIQ { get => _kuarabiq!; set => this.AssertWritable()._kuarabiq = value; }
    /// <summary>Cornish</summary>
    public IMessageDescription kw { get => _kw!; set => this.AssertWritable()._kw = value; }
    /// <summary>Cornish (United Kingdom)</summary>
    public IMessageDescription kwGB { get => _kwgb!; set => this.AssertWritable()._kwgb = value; }
    /// <summary>Kyrgyz</summary>
    public IMessageDescription ky { get => _ky!; set => this.AssertWritable()._ky = value; }
    /// <summary>Kyrgyz (Kyrgyzstan)</summary>
    public IMessageDescription kyKG { get => _kykg!; set => this.AssertWritable()._kykg = value; }
    /// <summary>Latin</summary>
    public IMessageDescription la { get => _la!; set => this.AssertWritable()._la = value; }
    /// <summary>Latin (World)</summary>
    public IMessageDescription la001 { get => _la001!; set => this.AssertWritable()._la001 = value; }
    /// <summary>Langi</summary>
    public IMessageDescription lag { get => _lag!; set => this.AssertWritable()._lag = value; }
    /// <summary>Langi (Tanzania)</summary>
    public IMessageDescription lagTZ { get => _lagtz!; set => this.AssertWritable()._lagtz = value; }
    /// <summary>Luxembourgish</summary>
    public IMessageDescription lb { get => _lb!; set => this.AssertWritable()._lb = value; }
    /// <summary>Luxembourgish (Luxembourg)</summary>
    public IMessageDescription lbLU { get => _lblu!; set => this.AssertWritable()._lblu = value; }
    /// <summary>Ganda</summary>
    public IMessageDescription lg { get => _lg!; set => this.AssertWritable()._lg = value; }
    /// <summary>Ganda (Uganda)</summary>
    public IMessageDescription lgUG { get => _lgug!; set => this.AssertWritable()._lgug = value; }
    /// <summary>Lakota</summary>
    public IMessageDescription lkt { get => _lkt!; set => this.AssertWritable()._lkt = value; }
    /// <summary>Lakota (United States)</summary>
    public IMessageDescription lktUS { get => _lktus!; set => this.AssertWritable()._lktus = value; }
    /// <summary>Lingala</summary>
    public IMessageDescription ln { get => _ln!; set => this.AssertWritable()._ln = value; }
    /// <summary>Lingala (Angola)</summary>
    public IMessageDescription lnAO { get => _lnao!; set => this.AssertWritable()._lnao = value; }
    /// <summary>Lingala (Congo DRC)</summary>
    public IMessageDescription lnCD { get => _lncd!; set => this.AssertWritable()._lncd = value; }
    /// <summary>Lingala (Central African Republic)</summary>
    public IMessageDescription lnCF { get => _lncf!; set => this.AssertWritable()._lncf = value; }
    /// <summary>Lingala (Congo)</summary>
    public IMessageDescription lnCG { get => _lncg!; set => this.AssertWritable()._lncg = value; }
    /// <summary>Lao</summary>
    public IMessageDescription lo { get => _lo!; set => this.AssertWritable()._lo = value; }
    /// <summary>Lao (Lao P.D.R.)</summary>
    public IMessageDescription loLA { get => _lola!; set => this.AssertWritable()._lola = value; }
    /// <summary>Lithuanian</summary>
    public IMessageDescription lt { get => _lt!; set => this.AssertWritable()._lt = value; }
    /// <summary>Lithuanian (Lithuania)</summary>
    public IMessageDescription ltLT { get => _ltlt!; set => this.AssertWritable()._ltlt = value; }
    /// <summary>Luba-Katanga</summary>
    public IMessageDescription lu { get => _lu!; set => this.AssertWritable()._lu = value; }
    /// <summary>Luba-Katanga (Congo DRC)</summary>
    public IMessageDescription luCD { get => _lucd!; set => this.AssertWritable()._lucd = value; }
    /// <summary>Luo</summary>
    public IMessageDescription luo { get => _luo!; set => this.AssertWritable()._luo = value; }
    /// <summary>Luo (Kenya)</summary>
    public IMessageDescription luoKE { get => _luoke!; set => this.AssertWritable()._luoke = value; }
    /// <summary>Luyia</summary>
    public IMessageDescription luy { get => _luy!; set => this.AssertWritable()._luy = value; }
    /// <summary>Luyia (Kenya)</summary>
    public IMessageDescription luyKE { get => _luyke!; set => this.AssertWritable()._luyke = value; }
    /// <summary>Latvian</summary>
    public IMessageDescription lv { get => _lv!; set => this.AssertWritable()._lv = value; }
    /// <summary>Latvian (Latvia)</summary>
    public IMessageDescription lvLV { get => _lvlv!; set => this.AssertWritable()._lvlv = value; }
    /// <summary>Masai</summary>
    public IMessageDescription mas { get => _mas!; set => this.AssertWritable()._mas = value; }
    /// <summary>Masai (Kenya)</summary>
    public IMessageDescription masKE { get => _maske!; set => this.AssertWritable()._maske = value; }
    /// <summary>Masai (Tanzania)</summary>
    public IMessageDescription masTZ { get => _mastz!; set => this.AssertWritable()._mastz = value; }
    /// <summary>Meru</summary>
    public IMessageDescription mer { get => _mer!; set => this.AssertWritable()._mer = value; }
    /// <summary>Meru (Kenya)</summary>
    public IMessageDescription merKE { get => _merke!; set => this.AssertWritable()._merke = value; }
    /// <summary>Morisyen</summary>
    public IMessageDescription mfe { get => _mfe!; set => this.AssertWritable()._mfe = value; }
    /// <summary>Morisyen (Mauritius)</summary>
    public IMessageDescription mfeMU { get => _mfemu!; set => this.AssertWritable()._mfemu = value; }
    /// <summary>Malagasy</summary>
    public IMessageDescription mg { get => _mg!; set => this.AssertWritable()._mg = value; }
    /// <summary>Malagasy (Madagascar)</summary>
    public IMessageDescription mgMG { get => _mgmg!; set => this.AssertWritable()._mgmg = value; }
    /// <summary>Makhuwa-Meetto</summary>
    public IMessageDescription mgh { get => _mgh!; set => this.AssertWritable()._mgh = value; }
    /// <summary>Makhuwa-Meetto (Mozambique)</summary>
    public IMessageDescription mghMZ { get => _mghmz!; set => this.AssertWritable()._mghmz = value; }
    /// <summary>Meta&#39;</summary>
    public IMessageDescription mgo { get => _mgo!; set => this.AssertWritable()._mgo = value; }
    /// <summary>Meta&#39; (Cameroon)</summary>
    public IMessageDescription mgoCM { get => _mgocm!; set => this.AssertWritable()._mgocm = value; }
    /// <summary>Maori</summary>
    public IMessageDescription mi { get => _mi!; set => this.AssertWritable()._mi = value; }
    /// <summary>Maori (New Zealand)</summary>
    public IMessageDescription miNZ { get => _minz!; set => this.AssertWritable()._minz = value; }
    /// <summary>Macedonian</summary>
    public IMessageDescription mk { get => _mk!; set => this.AssertWritable()._mk = value; }
    /// <summary>Macedonian (North Macedonia)</summary>
    public IMessageDescription mkMK { get => _mkmk!; set => this.AssertWritable()._mkmk = value; }
    /// <summary>Malayalam</summary>
    public IMessageDescription ml { get => _ml!; set => this.AssertWritable()._ml = value; }
    /// <summary>Malayalam (India)</summary>
    public IMessageDescription mlIN { get => _mlin!; set => this.AssertWritable()._mlin = value; }
    /// <summary>Mongolian</summary>
    public IMessageDescription mn { get => _mn!; set => this.AssertWritable()._mn = value; }
    /// <summary>Mongolian (Cyrillic)</summary>
    public IMessageDescription mnCyrl { get => _mncyrl!; set => this.AssertWritable()._mncyrl = value; }
    /// <summary>Mongolian (Cyrillic, Mongolia)</summary>
    public IMessageDescription mnMN { get => _mnmn!; set => this.AssertWritable()._mnmn = value; }
    /// <summary>Mongolian (Traditional Mongolian)</summary>
    public IMessageDescription mnMong { get => _mnmong!; set => this.AssertWritable()._mnmong = value; }
    /// <summary>Mongolian (Traditional Mongolian, PRC)</summary>
    public IMessageDescription mnMongCN { get => _mnmongcn!; set => this.AssertWritable()._mnmongcn = value; }
    /// <summary>Mongolian (Traditional Mongolian, Mongolia)</summary>
    public IMessageDescription mnMongMN { get => _mnmongmn!; set => this.AssertWritable()._mnmongmn = value; }
    /// <summary>Manipuri</summary>
    public IMessageDescription mni { get => _mni!; set => this.AssertWritable()._mni = value; }
    /// <summary>Manipuri (India)</summary>
    public IMessageDescription mniIN { get => _mniin!; set => this.AssertWritable()._mniin = value; }
    /// <summary>Mohawk</summary>
    public IMessageDescription moh { get => _moh!; set => this.AssertWritable()._moh = value; }
    /// <summary>Mohawk (Mohawk)</summary>
    public IMessageDescription mohCA { get => _mohca!; set => this.AssertWritable()._mohca = value; }
    /// <summary>Marathi</summary>
    public IMessageDescription mr { get => _mr!; set => this.AssertWritable()._mr = value; }
    /// <summary>Marathi (India)</summary>
    public IMessageDescription mrIN { get => _mrin!; set => this.AssertWritable()._mrin = value; }
    /// <summary>Malay</summary>
    public IMessageDescription ms { get => _ms!; set => this.AssertWritable()._ms = value; }
    /// <summary>Malay (Brunei Darussalam)</summary>
    public IMessageDescription msBN { get => _msbn!; set => this.AssertWritable()._msbn = value; }
    /// <summary>Malay (Malaysia)</summary>
    public IMessageDescription msMY { get => _msmy!; set => this.AssertWritable()._msmy = value; }
    /// <summary>Malay (Latin, Singapore)</summary>
    public IMessageDescription msSG { get => _mssg!; set => this.AssertWritable()._mssg = value; }
    /// <summary>Maltese</summary>
    public IMessageDescription mt { get => _mt!; set => this.AssertWritable()._mt = value; }
    /// <summary>Maltese (Malta)</summary>
    public IMessageDescription mtMT { get => _mtmt!; set => this.AssertWritable()._mtmt = value; }
    /// <summary>Mundang</summary>
    public IMessageDescription mua { get => _mua!; set => this.AssertWritable()._mua = value; }
    /// <summary>Mundang (Cameroon)</summary>
    public IMessageDescription muaCM { get => _muacm!; set => this.AssertWritable()._muacm = value; }
    /// <summary>Burmese</summary>
    public IMessageDescription my { get => _my!; set => this.AssertWritable()._my = value; }
    /// <summary>Burmese (Myanmar)</summary>
    public IMessageDescription myMM { get => _mymm!; set => this.AssertWritable()._mymm = value; }
    /// <summary>Nama</summary>
    public IMessageDescription naq { get => _naq!; set => this.AssertWritable()._naq = value; }
    /// <summary>Nama (Namibia)</summary>
    public IMessageDescription naqNA { get => _naqna!; set => this.AssertWritable()._naqna = value; }
    /// <summary>Norwegian (Bokm&#229;l)</summary>
    public IMessageDescription nb { get => _nb!; set => this.AssertWritable()._nb = value; }
    /// <summary>Norwegian, Bokm&#229;l (Norway)</summary>
    public IMessageDescription nbNO { get => _nbno!; set => this.AssertWritable()._nbno = value; }
    /// <summary>Norwegian, Bokm&#229;l (Svalbard and Jan Mayen)</summary>
    public IMessageDescription nbSJ { get => _nbsj!; set => this.AssertWritable()._nbsj = value; }
    /// <summary>North Ndebele</summary>
    public IMessageDescription nd { get => _nd!; set => this.AssertWritable()._nd = value; }
    /// <summary>North Ndebele (Zimbabwe)</summary>
    public IMessageDescription ndZW { get => _ndzw!; set => this.AssertWritable()._ndzw = value; }
    /// <summary>Nepali</summary>
    public IMessageDescription ne { get => _ne!; set => this.AssertWritable()._ne = value; }
    /// <summary>Nepali (India)</summary>
    public IMessageDescription neIN { get => _nein!; set => this.AssertWritable()._nein = value; }
    /// <summary>Nepali (Nepal)</summary>
    public IMessageDescription neNP { get => _nenp!; set => this.AssertWritable()._nenp = value; }
    /// <summary>Dutch</summary>
    public IMessageDescription nl { get => _nl!; set => this.AssertWritable()._nl = value; }
    /// <summary>Dutch (Aruba)</summary>
    public IMessageDescription nlAW { get => _nlaw!; set => this.AssertWritable()._nlaw = value; }
    /// <summary>Dutch (Belgium)</summary>
    public IMessageDescription nlBE { get => _nlbe!; set => this.AssertWritable()._nlbe = value; }
    /// <summary>Dutch (Bonaire, Sint Eustatius and Saba)</summary>
    public IMessageDescription nlBQ { get => _nlbq!; set => this.AssertWritable()._nlbq = value; }
    /// <summary>Dutch (Cura&#231;ao)</summary>
    public IMessageDescription nlCW { get => _nlcw!; set => this.AssertWritable()._nlcw = value; }
    /// <summary>Dutch (Netherlands)</summary>
    public IMessageDescription nlNL { get => _nlnl!; set => this.AssertWritable()._nlnl = value; }
    /// <summary>Dutch (Suriname)</summary>
    public IMessageDescription nlSR { get => _nlsr!; set => this.AssertWritable()._nlsr = value; }
    /// <summary>Dutch (Sint Maarten)</summary>
    public IMessageDescription nlSX { get => _nlsx!; set => this.AssertWritable()._nlsx = value; }
    /// <summary>Kwasio</summary>
    public IMessageDescription nmg { get => _nmg!; set => this.AssertWritable()._nmg = value; }
    /// <summary>Kwasio (Cameroon)</summary>
    public IMessageDescription nmgCM { get => _nmgcm!; set => this.AssertWritable()._nmgcm = value; }
    /// <summary>Norwegian (Nynorsk)</summary>
    public IMessageDescription nn { get => _nn!; set => this.AssertWritable()._nn = value; }
    /// <summary>Norwegian, Nynorsk (Norway)</summary>
    public IMessageDescription nnNO { get => _nnno!; set => this.AssertWritable()._nnno = value; }
    /// <summary>Ngiemboon</summary>
    public IMessageDescription nnh { get => _nnh!; set => this.AssertWritable()._nnh = value; }
    /// <summary>Ngiemboon (Cameroon)</summary>
    public IMessageDescription nnhCM { get => _nnhcm!; set => this.AssertWritable()._nnhcm = value; }
    /// <summary>Norwegian</summary>
    public IMessageDescription no { get => _no!; set => this.AssertWritable()._no = value; }
    /// <summary>N&#39;ko</summary>
    public IMessageDescription nqo { get => _nqo!; set => this.AssertWritable()._nqo = value; }
    /// <summary>N&#39;ko (Guinea)</summary>
    public IMessageDescription nqoGN { get => _nqogn!; set => this.AssertWritable()._nqogn = value; }
    /// <summary>South Ndebele</summary>
    public IMessageDescription nr { get => _nr!; set => this.AssertWritable()._nr = value; }
    /// <summary>South Ndebele (South Africa)</summary>
    public IMessageDescription nrZA { get => _nrza!; set => this.AssertWritable()._nrza = value; }
    /// <summary>Sesotho sa Leboa</summary>
    public IMessageDescription nso { get => _nso!; set => this.AssertWritable()._nso = value; }
    /// <summary>Sesotho sa Leboa (South Africa)</summary>
    public IMessageDescription nsoZA { get => _nsoza!; set => this.AssertWritable()._nsoza = value; }
    /// <summary>Nuer</summary>
    public IMessageDescription nus { get => _nus!; set => this.AssertWritable()._nus = value; }
    /// <summary>Nuer (Sudan)</summary>
    public IMessageDescription nusSD { get => _nussd!; set => this.AssertWritable()._nussd = value; }
    /// <summary>Nuer (South Sudan)</summary>
    public IMessageDescription nusSS { get => _nusss!; set => this.AssertWritable()._nusss = value; }
    /// <summary>Nyankole</summary>
    public IMessageDescription nyn { get => _nyn!; set => this.AssertWritable()._nyn = value; }
    /// <summary>Nyankole (Uganda)</summary>
    public IMessageDescription nynUG { get => _nynug!; set => this.AssertWritable()._nynug = value; }
    /// <summary>Occitan</summary>
    public IMessageDescription oc { get => _oc!; set => this.AssertWritable()._oc = value; }
    /// <summary>Occitan (France)</summary>
    public IMessageDescription ocFR { get => _ocfr!; set => this.AssertWritable()._ocfr = value; }
    /// <summary>Oromo</summary>
    public IMessageDescription om { get => _om!; set => this.AssertWritable()._om = value; }
    /// <summary>Oromo (Ethiopia)</summary>
    public IMessageDescription omET { get => _omet!; set => this.AssertWritable()._omet = value; }
    /// <summary>Oromo (Kenya)</summary>
    public IMessageDescription omKE { get => _omke!; set => this.AssertWritable()._omke = value; }
    /// <summary>Odia</summary>
    public IMessageDescription or { get => _or!; set => this.AssertWritable()._or = value; }
    /// <summary>Odia (India)</summary>
    public IMessageDescription orIN { get => _orin!; set => this.AssertWritable()._orin = value; }
    /// <summary>Ossetic</summary>
    public IMessageDescription os { get => _os!; set => this.AssertWritable()._os = value; }
    /// <summary>Ossetian (Cyrillic, Georgia)</summary>
    public IMessageDescription osGE { get => _osge!; set => this.AssertWritable()._osge = value; }
    /// <summary>Ossetian (Cyrillic, Russia)</summary>
    public IMessageDescription osRU { get => _osru!; set => this.AssertWritable()._osru = value; }
    /// <summary>Punjabi</summary>
    public IMessageDescription pa { get => _pa!; set => this.AssertWritable()._pa = value; }
    /// <summary>Punjabi (Arabic)</summary>
    public IMessageDescription paArab { get => _paarab!; set => this.AssertWritable()._paarab = value; }
    /// <summary>Punjabi (Islamic Republic of Pakistan)</summary>
    public IMessageDescription paArabPK { get => _paarabpk!; set => this.AssertWritable()._paarabpk = value; }
    /// <summary>Punjabi (India)</summary>
    public IMessageDescription paIN { get => _pain!; set => this.AssertWritable()._pain = value; }
    /// <summary>Papiamento</summary>
    public IMessageDescription pap { get => _pap!; set => this.AssertWritable()._pap = value; }
    /// <summary>Papiamento (Caribbean)</summary>
    public IMessageDescription pap029 { get => _pap029!; set => this.AssertWritable()._pap029 = value; }
    /// <summary>Polish</summary>
    public IMessageDescription pl { get => _pl!; set => this.AssertWritable()._pl = value; }
    /// <summary>Polish (Poland)</summary>
    public IMessageDescription plPL { get => _plpl!; set => this.AssertWritable()._plpl = value; }
    /// <summary>Dari</summary>
    public IMessageDescription prs { get => _prs!; set => this.AssertWritable()._prs = value; }
    /// <summary>Dari (Afghanistan)</summary>
    public IMessageDescription prsAF { get => _prsaf!; set => this.AssertWritable()._prsaf = value; }
    /// <summary>Pashto</summary>
    public IMessageDescription ps { get => _ps!; set => this.AssertWritable()._ps = value; }
    /// <summary>Pashto (Afghanistan)</summary>
    public IMessageDescription psAF { get => _psaf!; set => this.AssertWritable()._psaf = value; }
    /// <summary>Portuguese</summary>
    public IMessageDescription pt { get => _pt!; set => this.AssertWritable()._pt = value; }
    /// <summary>Portuguese (Angola)</summary>
    public IMessageDescription ptAO { get => _ptao!; set => this.AssertWritable()._ptao = value; }
    /// <summary>Portuguese (Brazil)</summary>
    public IMessageDescription ptBR { get => _ptbr!; set => this.AssertWritable()._ptbr = value; }
    /// <summary>Portuguese (Cabo Verde)</summary>
    public IMessageDescription ptCV { get => _ptcv!; set => this.AssertWritable()._ptcv = value; }
    /// <summary>Portuguese (Guinea-Bissau)</summary>
    public IMessageDescription ptGW { get => _ptgw!; set => this.AssertWritable()._ptgw = value; }
    /// <summary>Portuguese (Macao SAR)</summary>
    public IMessageDescription ptMO { get => _ptmo!; set => this.AssertWritable()._ptmo = value; }
    /// <summary>Portuguese (Mozambique)</summary>
    public IMessageDescription ptMZ { get => _ptmz!; set => this.AssertWritable()._ptmz = value; }
    /// <summary>Portuguese (Portugal)</summary>
    public IMessageDescription ptPT { get => _ptpt!; set => this.AssertWritable()._ptpt = value; }
    /// <summary>Portuguese (S&#227;o Tom&#233; and Pr&#237;ncipe)</summary>
    public IMessageDescription ptST { get => _ptst!; set => this.AssertWritable()._ptst = value; }
    /// <summary>Portuguese (Timor-Leste)</summary>
    public IMessageDescription ptTL { get => _pttl!; set => this.AssertWritable()._pttl = value; }
    /// <summary>Pseudo Language (Pseudo)</summary>
    public IMessageDescription qpsploc { get => _qpsploc!; set => this.AssertWritable()._qpsploc = value; }
    /// <summary>Pseudo Language (Pseudo Asia)</summary>
    public IMessageDescription qpsploca { get => _qpsploca!; set => this.AssertWritable()._qpsploca = value; }
    /// <summary>Pseudo Language (Pseudo Mirrored)</summary>
    public IMessageDescription qpsplocm { get => _qpsplocm!; set => this.AssertWritable()._qpsplocm = value; }
    /// <summary>Quechua</summary>
    public IMessageDescription qu { get => _qu!; set => this.AssertWritable()._qu = value; }
    /// <summary>Quechua (Bolivia)</summary>
    public IMessageDescription quBO { get => _qubo!; set => this.AssertWritable()._qubo = value; }
    /// <summary>Quechua (Ecuador)</summary>
    public IMessageDescription quEC { get => _quec!; set => this.AssertWritable()._quec = value; }
    /// <summary>Quechua (Peru)</summary>
    public IMessageDescription quPE { get => _qupe!; set => this.AssertWritable()._qupe = value; }
    /// <summary>K&#39;iche&#39;</summary>
    public IMessageDescription quc { get => _quc!; set => this.AssertWritable()._quc = value; }
    /// <summary>K&#39;iche&#39;</summary>
    public IMessageDescription qucLatn { get => _quclatn!; set => this.AssertWritable()._quclatn = value; }
    /// <summary>K&#39;iche&#39; (Guatemala)</summary>
    public IMessageDescription qucLatnGT { get => _quclatngt!; set => this.AssertWritable()._quclatngt = value; }
    /// <summary>K&#39;iche</summary>
    public IMessageDescription qut { get => _qut!; set => this.AssertWritable()._qut = value; }
    /// <summary>K&#39;iche (Guatemala)</summary>
    public IMessageDescription qutGT { get => _qutgt!; set => this.AssertWritable()._qutgt = value; }
    /// <summary>Quechua</summary>
    public IMessageDescription quz { get => _quz!; set => this.AssertWritable()._quz = value; }
    /// <summary>Quechua (Bolivia)</summary>
    public IMessageDescription quzBO { get => _quzbo!; set => this.AssertWritable()._quzbo = value; }
    /// <summary>Quechua (Ecuador)</summary>
    public IMessageDescription quzEC { get => _quzec!; set => this.AssertWritable()._quzec = value; }
    /// <summary>Quechua (Peru)</summary>
    public IMessageDescription quzPE { get => _quzpe!; set => this.AssertWritable()._quzpe = value; }
    /// <summary>Romansh</summary>
    public IMessageDescription rm { get => _rm!; set => this.AssertWritable()._rm = value; }
    /// <summary>Romansh (Switzerland)</summary>
    public IMessageDescription rmCH { get => _rmch!; set => this.AssertWritable()._rmch = value; }
    /// <summary>Rundi</summary>
    public IMessageDescription rn { get => _rn!; set => this.AssertWritable()._rn = value; }
    /// <summary>Rundi (Burundi)</summary>
    public IMessageDescription rnBI { get => _rnbi!; set => this.AssertWritable()._rnbi = value; }
    /// <summary>Romanian</summary>
    public IMessageDescription ro { get => _ro!; set => this.AssertWritable()._ro = value; }
    /// <summary>Romanian (Moldova)</summary>
    public IMessageDescription roMD { get => _romd!; set => this.AssertWritable()._romd = value; }
    /// <summary>Romanian (Romania)</summary>
    public IMessageDescription roRO { get => _roro!; set => this.AssertWritable()._roro = value; }
    /// <summary>Rombo</summary>
    public IMessageDescription rof { get => _rof!; set => this.AssertWritable()._rof = value; }
    /// <summary>Rombo (Tanzania)</summary>
    public IMessageDescription rofTZ { get => _roftz!; set => this.AssertWritable()._roftz = value; }
    /// <summary>Russian</summary>
    public IMessageDescription ru { get => _ru!; set => this.AssertWritable()._ru = value; }
    /// <summary>Russian (Belarus)</summary>
    public IMessageDescription ruBY { get => _ruby!; set => this.AssertWritable()._ruby = value; }
    /// <summary>Russian (Kyrgyzstan)</summary>
    public IMessageDescription ruKG { get => _rukg!; set => this.AssertWritable()._rukg = value; }
    /// <summary>Russian (Kazakhstan)</summary>
    public IMessageDescription ruKZ { get => _rukz!; set => this.AssertWritable()._rukz = value; }
    /// <summary>Russian (Moldova)</summary>
    public IMessageDescription ruMD { get => _rumd!; set => this.AssertWritable()._rumd = value; }
    /// <summary>Russian (Russia)</summary>
    public IMessageDescription ruRU { get => _ruru!; set => this.AssertWritable()._ruru = value; }
    /// <summary>Russian (Ukraine)</summary>
    public IMessageDescription ruUA { get => _ruua!; set => this.AssertWritable()._ruua = value; }
    /// <summary>Kinyarwanda</summary>
    public IMessageDescription rw { get => _rw!; set => this.AssertWritable()._rw = value; }
    /// <summary>Kinyarwanda (Rwanda)</summary>
    public IMessageDescription rwRW { get => _rwrw!; set => this.AssertWritable()._rwrw = value; }
    /// <summary>Rwa</summary>
    public IMessageDescription rwk { get => _rwk!; set => this.AssertWritable()._rwk = value; }
    /// <summary>Rwa (Tanzania)</summary>
    public IMessageDescription rwkTZ { get => _rwktz!; set => this.AssertWritable()._rwktz = value; }
    /// <summary>Sanskrit</summary>
    public IMessageDescription sa { get => _sa!; set => this.AssertWritable()._sa = value; }
    /// <summary>Sanskrit (India)</summary>
    public IMessageDescription saIN { get => _sain!; set => this.AssertWritable()._sain = value; }
    /// <summary>Sakha</summary>
    public IMessageDescription sah { get => _sah!; set => this.AssertWritable()._sah = value; }
    /// <summary>Sakha (Russia)</summary>
    public IMessageDescription sahRU { get => _sahru!; set => this.AssertWritable()._sahru = value; }
    /// <summary>Samburu</summary>
    public IMessageDescription saq { get => _saq!; set => this.AssertWritable()._saq = value; }
    /// <summary>Samburu (Kenya)</summary>
    public IMessageDescription saqKE { get => _saqke!; set => this.AssertWritable()._saqke = value; }
    /// <summary>Sangu</summary>
    public IMessageDescription sbp { get => _sbp!; set => this.AssertWritable()._sbp = value; }
    /// <summary>Sangu (Tanzania)</summary>
    public IMessageDescription sbpTZ { get => _sbptz!; set => this.AssertWritable()._sbptz = value; }
    /// <summary>Sindhi</summary>
    public IMessageDescription sd { get => _sd!; set => this.AssertWritable()._sd = value; }
    /// <summary>Sindhi (Arabic)</summary>
    public IMessageDescription sdArab { get => _sdarab!; set => this.AssertWritable()._sdarab = value; }
    /// <summary>Sindhi (Islamic Republic of Pakistan)</summary>
    public IMessageDescription sdArabPK { get => _sdarabpk!; set => this.AssertWritable()._sdarabpk = value; }
    /// <summary>Sindhi (Devanagari)</summary>
    public IMessageDescription sdDeva { get => _sddeva!; set => this.AssertWritable()._sddeva = value; }
    /// <summary>Sindhi (Devanagari, India)</summary>
    public IMessageDescription sdDevaIN { get => _sddevain!; set => this.AssertWritable()._sddevain = value; }
    /// <summary>Sami (Northern)</summary>
    public IMessageDescription se { get => _se!; set => this.AssertWritable()._se = value; }
    /// <summary>Sami, Northern (Finland)</summary>
    public IMessageDescription seFI { get => _sefi!; set => this.AssertWritable()._sefi = value; }
    /// <summary>Sami, Northern (Norway)</summary>
    public IMessageDescription seNO { get => _seno!; set => this.AssertWritable()._seno = value; }
    /// <summary>Sami, Northern (Sweden)</summary>
    public IMessageDescription seSE { get => _sese!; set => this.AssertWritable()._sese = value; }
    /// <summary>Sena</summary>
    public IMessageDescription seh { get => _seh!; set => this.AssertWritable()._seh = value; }
    /// <summary>Sena (Mozambique)</summary>
    public IMessageDescription sehMZ { get => _sehmz!; set => this.AssertWritable()._sehmz = value; }
    /// <summary>Koyraboro Senni</summary>
    public IMessageDescription ses { get => _ses!; set => this.AssertWritable()._ses = value; }
    /// <summary>Koyraboro Senni (Mali)</summary>
    public IMessageDescription sesML { get => _sesml!; set => this.AssertWritable()._sesml = value; }
    /// <summary>Sango</summary>
    public IMessageDescription sg { get => _sg!; set => this.AssertWritable()._sg = value; }
    /// <summary>Sango (Central African Republic)</summary>
    public IMessageDescription sgCF { get => _sgcf!; set => this.AssertWritable()._sgcf = value; }
    /// <summary>Tachelhit</summary>
    public IMessageDescription shi { get => _shi!; set => this.AssertWritable()._shi = value; }
    /// <summary>Tachelhit (Latin)</summary>
    public IMessageDescription shiLatn { get => _shilatn!; set => this.AssertWritable()._shilatn = value; }
    /// <summary>Tachelhit (Latin, Morocco)</summary>
    public IMessageDescription shiLatnMA { get => _shilatnma!; set => this.AssertWritable()._shilatnma = value; }
    /// <summary>Tachelhit (Tifinagh)</summary>
    public IMessageDescription shiTfng { get => _shitfng!; set => this.AssertWritable()._shitfng = value; }
    /// <summary>Tachelhit (Tifinagh, Morocco)</summary>
    public IMessageDescription shiTfngMA { get => _shitfngma!; set => this.AssertWritable()._shitfngma = value; }
    /// <summary>Sinhala</summary>
    public IMessageDescription si { get => _si!; set => this.AssertWritable()._si = value; }
    /// <summary>Sinhala (Sri Lanka)</summary>
    public IMessageDescription siLK { get => _silk!; set => this.AssertWritable()._silk = value; }
    /// <summary>Slovak</summary>
    public IMessageDescription sk { get => _sk!; set => this.AssertWritable()._sk = value; }
    /// <summary>Slovak (Slovakia)</summary>
    public IMessageDescription skSK { get => _sksk!; set => this.AssertWritable()._sksk = value; }
    /// <summary>Slovenian</summary>
    public IMessageDescription sl { get => _sl!; set => this.AssertWritable()._sl = value; }
    /// <summary>Slovenian (Slovenia)</summary>
    public IMessageDescription slSI { get => _slsi!; set => this.AssertWritable()._slsi = value; }
    /// <summary>Sami (Southern)</summary>
    public IMessageDescription sma { get => _sma!; set => this.AssertWritable()._sma = value; }
    /// <summary>Sami, Southern (Norway)</summary>
    public IMessageDescription smaNO { get => _smano!; set => this.AssertWritable()._smano = value; }
    /// <summary>Sami, Southern (Sweden)</summary>
    public IMessageDescription smaSE { get => _smase!; set => this.AssertWritable()._smase = value; }
    /// <summary>Sami (Lule)</summary>
    public IMessageDescription smj { get => _smj!; set => this.AssertWritable()._smj = value; }
    /// <summary>Sami, Lule (Norway)</summary>
    public IMessageDescription smjNO { get => _smjno!; set => this.AssertWritable()._smjno = value; }
    /// <summary>Sami, Lule (Sweden)</summary>
    public IMessageDescription smjSE { get => _smjse!; set => this.AssertWritable()._smjse = value; }
    /// <summary>Sami (Inari)</summary>
    public IMessageDescription smn { get => _smn!; set => this.AssertWritable()._smn = value; }
    /// <summary>Sami, Inari (Finland)</summary>
    public IMessageDescription smnFI { get => _smnfi!; set => this.AssertWritable()._smnfi = value; }
    /// <summary>Sami (Skolt)</summary>
    public IMessageDescription sms { get => _sms!; set => this.AssertWritable()._sms = value; }
    /// <summary>Sami, Skolt (Finland)</summary>
    public IMessageDescription smsFI { get => _smsfi!; set => this.AssertWritable()._smsfi = value; }
    /// <summary>Shona</summary>
    public IMessageDescription sn { get => _sn!; set => this.AssertWritable()._sn = value; }
    /// <summary>Shona (Latin)</summary>
    public IMessageDescription snLatn { get => _snlatn!; set => this.AssertWritable()._snlatn = value; }
    /// <summary>Shona (Latin, Zimbabwe)</summary>
    public IMessageDescription snLatnZW { get => _snlatnzw!; set => this.AssertWritable()._snlatnzw = value; }
    /// <summary>Somali</summary>
    public IMessageDescription so { get => _so!; set => this.AssertWritable()._so = value; }
    /// <summary>Somali (Djibouti)</summary>
    public IMessageDescription soDJ { get => _sodj!; set => this.AssertWritable()._sodj = value; }
    /// <summary>Somali (Ethiopia)</summary>
    public IMessageDescription soET { get => _soet!; set => this.AssertWritable()._soet = value; }
    /// <summary>Somali (Kenya)</summary>
    public IMessageDescription soKE { get => _soke!; set => this.AssertWritable()._soke = value; }
    /// <summary>Somali (Somalia)</summary>
    public IMessageDescription soSO { get => _soso!; set => this.AssertWritable()._soso = value; }
    /// <summary>Albanian</summary>
    public IMessageDescription sq { get => _sq!; set => this.AssertWritable()._sq = value; }
    /// <summary>Albanian (Albania)</summary>
    public IMessageDescription sqAL { get => _sqal!; set => this.AssertWritable()._sqal = value; }
    /// <summary>Albanian (North Macedonia)</summary>
    public IMessageDescription sqMK { get => _sqmk!; set => this.AssertWritable()._sqmk = value; }
    /// <summary>Albanian (Kosovo)</summary>
    public IMessageDescription sqXK { get => _sqxk!; set => this.AssertWritable()._sqxk = value; }
    /// <summary>Serbian</summary>
    public IMessageDescription sr { get => _sr!; set => this.AssertWritable()._sr = value; }
    /// <summary>Serbian (Cyrillic)</summary>
    public IMessageDescription srCyrl { get => _srcyrl!; set => this.AssertWritable()._srcyrl = value; }
    /// <summary>Serbian (Cyrillic, Bosnia and Herzegovina)</summary>
    public IMessageDescription srCyrlBA { get => _srcyrlba!; set => this.AssertWritable()._srcyrlba = value; }
    /// <summary>Serbian (Cyrillic, Serbia and Montenegro (Former))</summary>
    public IMessageDescription srCyrlCS { get => _srcyrlcs!; set => this.AssertWritable()._srcyrlcs = value; }
    /// <summary>Serbian (Cyrillic, Montenegro)</summary>
    public IMessageDescription srCyrlME { get => _srcyrlme!; set => this.AssertWritable()._srcyrlme = value; }
    /// <summary>Serbian (Cyrillic, Serbia)</summary>
    public IMessageDescription srCyrlRS { get => _srcyrlrs!; set => this.AssertWritable()._srcyrlrs = value; }
    /// <summary>Serbian (Cyrillic, Kosovo)</summary>
    public IMessageDescription srCyrlXK { get => _srcyrlxk!; set => this.AssertWritable()._srcyrlxk = value; }
    /// <summary>Serbian (Latin)</summary>
    public IMessageDescription srLatn { get => _srlatn!; set => this.AssertWritable()._srlatn = value; }
    /// <summary>Serbian (Latin, Bosnia and Herzegovina)</summary>
    public IMessageDescription srLatnBA { get => _srlatnba!; set => this.AssertWritable()._srlatnba = value; }
    /// <summary>Serbian (Latin, Serbia and Montenegro (Former))</summary>
    public IMessageDescription srLatnCS { get => _srlatncs!; set => this.AssertWritable()._srlatncs = value; }
    /// <summary>Serbian (Latin, Montenegro)</summary>
    public IMessageDescription srLatnME { get => _srlatnme!; set => this.AssertWritable()._srlatnme = value; }
    /// <summary>Serbian (Latin, Serbia)</summary>
    public IMessageDescription srLatnRS { get => _srlatnrs!; set => this.AssertWritable()._srlatnrs = value; }
    /// <summary>Serbian (Latin, Kosovo)</summary>
    public IMessageDescription srLatnXK { get => _srlatnxk!; set => this.AssertWritable()._srlatnxk = value; }
    /// <summary>Swati</summary>
    public IMessageDescription ss { get => _ss!; set => this.AssertWritable()._ss = value; }
    /// <summary>Swati (Swaziland)</summary>
    public IMessageDescription ssSZ { get => _sssz!; set => this.AssertWritable()._sssz = value; }
    /// <summary>Swati (South Africa)</summary>
    public IMessageDescription ssZA { get => _ssza!; set => this.AssertWritable()._ssza = value; }
    /// <summary>Saho</summary>
    public IMessageDescription ssy { get => _ssy!; set => this.AssertWritable()._ssy = value; }
    /// <summary>Saho (Eritrea)</summary>
    public IMessageDescription ssyER { get => _ssyer!; set => this.AssertWritable()._ssyer = value; }
    /// <summary>Southern Sotho</summary>
    public IMessageDescription st { get => _st!; set => this.AssertWritable()._st = value; }
    /// <summary>Sesotho (Lesotho)</summary>
    public IMessageDescription stLS { get => _stls!; set => this.AssertWritable()._stls = value; }
    /// <summary>Southern Sotho (South Africa)</summary>
    public IMessageDescription stZA { get => _stza!; set => this.AssertWritable()._stza = value; }
    /// <summary>Swedish</summary>
    public IMessageDescription sv { get => _sv!; set => this.AssertWritable()._sv = value; }
    /// <summary>Swedish (&#197;land Islands)</summary>
    public IMessageDescription svAX { get => _svax!; set => this.AssertWritable()._svax = value; }
    /// <summary>Swedish (Finland)</summary>
    public IMessageDescription svFI { get => _svfi!; set => this.AssertWritable()._svfi = value; }
    /// <summary>Swedish (Sweden)</summary>
    public IMessageDescription svSE { get => _svse!; set => this.AssertWritable()._svse = value; }
    /// <summary>Kiswahili</summary>
    public IMessageDescription sw { get => _sw!; set => this.AssertWritable()._sw = value; }
    /// <summary>Kiswahili (Congo DRC)</summary>
    public IMessageDescription swCD { get => _swcd!; set => this.AssertWritable()._swcd = value; }
    /// <summary>Kiswahili (Kenya)</summary>
    public IMessageDescription swKE { get => _swke!; set => this.AssertWritable()._swke = value; }
    /// <summary>Kiswahili (Tanzania)</summary>
    public IMessageDescription swTZ { get => _swtz!; set => this.AssertWritable()._swtz = value; }
    /// <summary>Kiswahili (Uganda)</summary>
    public IMessageDescription swUG { get => _swug!; set => this.AssertWritable()._swug = value; }
    /// <summary>Congo Swahili</summary>
    public IMessageDescription swc { get => _swc!; set => this.AssertWritable()._swc = value; }
    /// <summary>Congo Swahili (Congo DRC)</summary>
    public IMessageDescription swcCD { get => _swccd!; set => this.AssertWritable()._swccd = value; }
    /// <summary>Syriac</summary>
    public IMessageDescription syr { get => _syr!; set => this.AssertWritable()._syr = value; }
    /// <summary>Syriac (Syria)</summary>
    public IMessageDescription syrSY { get => _syrsy!; set => this.AssertWritable()._syrsy = value; }
    /// <summary>Tamil</summary>
    public IMessageDescription ta { get => _ta!; set => this.AssertWritable()._ta = value; }
    /// <summary>Tamil (India)</summary>
    public IMessageDescription taIN { get => _tain!; set => this.AssertWritable()._tain = value; }
    /// <summary>Tamil (Sri Lanka)</summary>
    public IMessageDescription taLK { get => _talk!; set => this.AssertWritable()._talk = value; }
    /// <summary>Tamil (Malaysia)</summary>
    public IMessageDescription taMY { get => _tamy!; set => this.AssertWritable()._tamy = value; }
    /// <summary>Tamil (Singapore)</summary>
    public IMessageDescription taSG { get => _tasg!; set => this.AssertWritable()._tasg = value; }
    /// <summary>Telugu</summary>
    public IMessageDescription te { get => _te!; set => this.AssertWritable()._te = value; }
    /// <summary>Telugu (India)</summary>
    public IMessageDescription teIN { get => _tein!; set => this.AssertWritable()._tein = value; }
    /// <summary>Teso</summary>
    public IMessageDescription teo { get => _teo!; set => this.AssertWritable()._teo = value; }
    /// <summary>Teso (Kenya)</summary>
    public IMessageDescription teoKE { get => _teoke!; set => this.AssertWritable()._teoke = value; }
    /// <summary>Teso (Uganda)</summary>
    public IMessageDescription teoUG { get => _teoug!; set => this.AssertWritable()._teoug = value; }
    /// <summary>Tajik</summary>
    public IMessageDescription tg { get => _tg!; set => this.AssertWritable()._tg = value; }
    /// <summary>Tajik (Cyrillic)</summary>
    public IMessageDescription tgCyrl { get => _tgcyrl!; set => this.AssertWritable()._tgcyrl = value; }
    /// <summary>Tajik (Cyrillic, Tajikistan)</summary>
    public IMessageDescription tgCyrlTJ { get => _tgcyrltj!; set => this.AssertWritable()._tgcyrltj = value; }
    /// <summary>Thai</summary>
    public IMessageDescription th { get => _th!; set => this.AssertWritable()._th = value; }
    /// <summary>Thai (Thailand)</summary>
    public IMessageDescription thTH { get => _thth!; set => this.AssertWritable()._thth = value; }
    /// <summary>Tigrinya</summary>
    public IMessageDescription ti { get => _ti!; set => this.AssertWritable()._ti = value; }
    /// <summary>Tigrinya (Eritrea)</summary>
    public IMessageDescription tiER { get => _tier!; set => this.AssertWritable()._tier = value; }
    /// <summary>Tigrinya (Ethiopia)</summary>
    public IMessageDescription tiET { get => _tiet!; set => this.AssertWritable()._tiet = value; }
    /// <summary>Tigre</summary>
    public IMessageDescription tig { get => _tig!; set => this.AssertWritable()._tig = value; }
    /// <summary>Tigre (Eritrea)</summary>
    public IMessageDescription tigER { get => _tiger!; set => this.AssertWritable()._tiger = value; }
    /// <summary>Turkmen</summary>
    public IMessageDescription tk { get => _tk!; set => this.AssertWritable()._tk = value; }
    /// <summary>Turkmen (Turkmenistan)</summary>
    public IMessageDescription tkTM { get => _tktm!; set => this.AssertWritable()._tktm = value; }
    /// <summary>Setswana</summary>
    public IMessageDescription tn { get => _tn!; set => this.AssertWritable()._tn = value; }
    /// <summary>Setswana (Botswana)</summary>
    public IMessageDescription tnBW { get => _tnbw!; set => this.AssertWritable()._tnbw = value; }
    /// <summary>Setswana (South Africa)</summary>
    public IMessageDescription tnZA { get => _tnza!; set => this.AssertWritable()._tnza = value; }
    /// <summary>Tongan</summary>
    public IMessageDescription to { get => _to!; set => this.AssertWritable()._to = value; }
    /// <summary>Tongan (Tonga)</summary>
    public IMessageDescription toTO { get => _toto!; set => this.AssertWritable()._toto = value; }
    /// <summary>Turkish</summary>
    public IMessageDescription tr { get => _tr!; set => this.AssertWritable()._tr = value; }
    /// <summary>Turkish (Cyprus)</summary>
    public IMessageDescription trCY { get => _trcy!; set => this.AssertWritable()._trcy = value; }
    /// <summary>Turkish (Turkey)</summary>
    public IMessageDescription trTR { get => _trtr!; set => this.AssertWritable()._trtr = value; }
    /// <summary>Tsonga</summary>
    public IMessageDescription ts { get => _ts!; set => this.AssertWritable()._ts = value; }
    /// <summary>Tsonga (South Africa)</summary>
    public IMessageDescription tsZA { get => _tsza!; set => this.AssertWritable()._tsza = value; }
    /// <summary>Tatar</summary>
    public IMessageDescription tt { get => _tt!; set => this.AssertWritable()._tt = value; }
    /// <summary>Tatar (Russia)</summary>
    public IMessageDescription ttRU { get => _ttru!; set => this.AssertWritable()._ttru = value; }
    /// <summary>Tasawaq</summary>
    public IMessageDescription twq { get => _twq!; set => this.AssertWritable()._twq = value; }
    /// <summary>Tasawaq (Niger)</summary>
    public IMessageDescription twqNE { get => _twqne!; set => this.AssertWritable()._twqne = value; }
    /// <summary>Tamazight</summary>
    public IMessageDescription tzm { get => _tzm!; set => this.AssertWritable()._tzm = value; }
    /// <summary>Central Atlas Tamazight (Arabic)</summary>
    public IMessageDescription tzmArab { get => _tzmarab!; set => this.AssertWritable()._tzmarab = value; }
    /// <summary>Central Atlas Tamazight (Arabic, Morocco)</summary>
    public IMessageDescription tzmArabMA { get => _tzmarabma!; set => this.AssertWritable()._tzmarabma = value; }
    /// <summary>Tamazight (Latin)</summary>
    public IMessageDescription tzmLatn { get => _tzmlatn!; set => this.AssertWritable()._tzmlatn = value; }
    /// <summary>Tamazight (Latin, Algeria)</summary>
    public IMessageDescription tzmLatnDZ { get => _tzmlatndz!; set => this.AssertWritable()._tzmlatndz = value; }
    /// <summary>Central Atlas Tamazight (Latin, Morocco)</summary>
    public IMessageDescription tzmLatnMA { get => _tzmlatnma!; set => this.AssertWritable()._tzmlatnma = value; }
    /// <summary>Tamazight (Tifinagh)</summary>
    public IMessageDescription tzmTfng { get => _tzmtfng!; set => this.AssertWritable()._tzmtfng = value; }
    /// <summary>Central Atlas Tamazight (Tifinagh, Morocco)</summary>
    public IMessageDescription tzmTfngMA { get => _tzmtfngma!; set => this.AssertWritable()._tzmtfngma = value; }
    /// <summary>Uyghur</summary>
    public IMessageDescription ug { get => _ug!; set => this.AssertWritable()._ug = value; }
    /// <summary>Uyghur (PRC)</summary>
    public IMessageDescription ugCN { get => _ugcn!; set => this.AssertWritable()._ugcn = value; }
    /// <summary>Ukrainian</summary>
    public IMessageDescription uk { get => _uk!; set => this.AssertWritable()._uk = value; }
    /// <summary>Ukrainian (Ukraine)</summary>
    public IMessageDescription ukUA { get => _ukua!; set => this.AssertWritable()._ukua = value; }
    /// <summary>Urdu</summary>
    public IMessageDescription ur { get => _ur!; set => this.AssertWritable()._ur = value; }
    /// <summary>Urdu (India)</summary>
    public IMessageDescription urIN { get => _urin!; set => this.AssertWritable()._urin = value; }
    /// <summary>Urdu (Islamic Republic of Pakistan)</summary>
    public IMessageDescription urPK { get => _urpk!; set => this.AssertWritable()._urpk = value; }
    /// <summary>Uzbek</summary>
    public IMessageDescription uz { get => _uz!; set => this.AssertWritable()._uz = value; }
    /// <summary>Uzbek (Perso-Arabic)</summary>
    public IMessageDescription uzArab { get => _uzarab!; set => this.AssertWritable()._uzarab = value; }
    /// <summary>Uzbek (Perso-Arabic, Afghanistan)</summary>
    public IMessageDescription uzArabAF { get => _uzarabaf!; set => this.AssertWritable()._uzarabaf = value; }
    /// <summary>Uzbek (Cyrillic)</summary>
    public IMessageDescription uzCyrl { get => _uzcyrl!; set => this.AssertWritable()._uzcyrl = value; }
    /// <summary>Uzbek (Cyrillic, Uzbekistan)</summary>
    public IMessageDescription uzCyrlUZ { get => _uzcyrluz!; set => this.AssertWritable()._uzcyrluz = value; }
    /// <summary>Uzbek (Latin)</summary>
    public IMessageDescription uzLatn { get => _uzlatn!; set => this.AssertWritable()._uzlatn = value; }
    /// <summary>Uzbek (Latin, Uzbekistan)</summary>
    public IMessageDescription uzLatnUZ { get => _uzlatnuz!; set => this.AssertWritable()._uzlatnuz = value; }
    /// <summary>Vai</summary>
    public IMessageDescription vai { get => _vai!; set => this.AssertWritable()._vai = value; }
    /// <summary>Vai (Latin)</summary>
    public IMessageDescription vaiLatn { get => _vailatn!; set => this.AssertWritable()._vailatn = value; }
    /// <summary>Vai (Latin, Liberia)</summary>
    public IMessageDescription vaiLatnLR { get => _vailatnlr!; set => this.AssertWritable()._vailatnlr = value; }
    /// <summary>Vai (Vai)</summary>
    public IMessageDescription vaiVaii { get => _vaivaii!; set => this.AssertWritable()._vaivaii = value; }
    /// <summary>Vai (Vai, Liberia)</summary>
    public IMessageDescription vaiVaiiLR { get => _vaivaiilr!; set => this.AssertWritable()._vaivaiilr = value; }
    /// <summary>Venda</summary>
    public IMessageDescription ve { get => _ve!; set => this.AssertWritable()._ve = value; }
    /// <summary>Venda (South Africa)</summary>
    public IMessageDescription veZA { get => _veza!; set => this.AssertWritable()._veza = value; }
    /// <summary>Vietnamese</summary>
    public IMessageDescription vi { get => _vi!; set => this.AssertWritable()._vi = value; }
    /// <summary>Vietnamese (Vietnam)</summary>
    public IMessageDescription viVN { get => _vivn!; set => this.AssertWritable()._vivn = value; }
    /// <summary>Volap&#252;k</summary>
    public IMessageDescription vo { get => _vo!; set => this.AssertWritable()._vo = value; }
    /// <summary>Volap&#252;k (World)</summary>
    public IMessageDescription vo001 { get => _vo001!; set => this.AssertWritable()._vo001 = value; }
    /// <summary>Vunjo</summary>
    public IMessageDescription vun { get => _vun!; set => this.AssertWritable()._vun = value; }
    /// <summary>Vunjo (Tanzania)</summary>
    public IMessageDescription vunTZ { get => _vuntz!; set => this.AssertWritable()._vuntz = value; }
    /// <summary>Walser</summary>
    public IMessageDescription wae { get => _wae!; set => this.AssertWritable()._wae = value; }
    /// <summary>Walser (Switzerland)</summary>
    public IMessageDescription waeCH { get => _waech!; set => this.AssertWritable()._waech = value; }
    /// <summary>Wolaytta</summary>
    public IMessageDescription wal { get => _wal!; set => this.AssertWritable()._wal = value; }
    /// <summary>Wolaytta (Ethiopia)</summary>
    public IMessageDescription walET { get => _walet!; set => this.AssertWritable()._walet = value; }
    /// <summary>Wolof</summary>
    public IMessageDescription wo { get => _wo!; set => this.AssertWritable()._wo = value; }
    /// <summary>Wolof (Senegal)</summary>
    public IMessageDescription woSN { get => _wosn!; set => this.AssertWritable()._wosn = value; }
    /// <summary>Invariant Language (Invariant Country)</summary>
    public IMessageDescription xIV { get => _xiv!; set => this.AssertWritable()._xiv = value; }
    /// <summary>Invariant Language (Invariant Country)</summary>
    public IMessageDescription xIVmathan { get => _xivmathan!; set => this.AssertWritable()._xivmathan = value; }
    /// <summary>isiXhosa</summary>
    public IMessageDescription xh { get => _xh!; set => this.AssertWritable()._xh = value; }
    /// <summary>isiXhosa (South Africa)</summary>
    public IMessageDescription xhZA { get => _xhza!; set => this.AssertWritable()._xhza = value; }
    /// <summary>Soga</summary>
    public IMessageDescription xog { get => _xog!; set => this.AssertWritable()._xog = value; }
    /// <summary>Soga (Uganda)</summary>
    public IMessageDescription xogUG { get => _xogug!; set => this.AssertWritable()._xogug = value; }
    /// <summary>Yangben</summary>
    public IMessageDescription yav { get => _yav!; set => this.AssertWritable()._yav = value; }
    /// <summary>Yangben (Cameroon)</summary>
    public IMessageDescription yavCM { get => _yavcm!; set => this.AssertWritable()._yavcm = value; }
    /// <summary>Yiddish</summary>
    public IMessageDescription yi { get => _yi!; set => this.AssertWritable()._yi = value; }
    /// <summary>Yiddish (World)</summary>
    public IMessageDescription yi001 { get => _yi001!; set => this.AssertWritable()._yi001 = value; }
    /// <summary>Yoruba</summary>
    public IMessageDescription yo { get => _yo!; set => this.AssertWritable()._yo = value; }
    /// <summary>Yoruba (Benin)</summary>
    public IMessageDescription yoBJ { get => _yobj!; set => this.AssertWritable()._yobj = value; }
    /// <summary>Yoruba (Nigeria)</summary>
    public IMessageDescription yoNG { get => _yong!; set => this.AssertWritable()._yong = value; }
    /// <summary>Standard Moroccan Tamazight</summary>
    public IMessageDescription zgh { get => _zgh!; set => this.AssertWritable()._zgh = value; }
    /// <summary>Standard Moroccan Tamazight (Tifinagh)</summary>
    public IMessageDescription zghTfng { get => _zghtfng!; set => this.AssertWritable()._zghtfng = value; }
    /// <summary>Standard Moroccan Tamazight (Tifinagh, Morocco)</summary>
    public IMessageDescription zghTfngMA { get => _zghtfngma!; set => this.AssertWritable()._zghtfngma = value; }
    /// <summary>Chinese</summary>
    public IMessageDescription zh { get => _zh!; set => this.AssertWritable()._zh = value; }
    /// <summary>Chinese (Simplified) Legacy</summary>
    public IMessageDescription zhCHS { get => _zhchs!; set => this.AssertWritable()._zhchs = value; }
    /// <summary>Chinese (Traditional) Legacy</summary>
    public IMessageDescription zhCHT { get => _zhcht!; set => this.AssertWritable()._zhcht = value; }
    /// <summary>Chinese (Simplified, PRC)</summary>
    public IMessageDescription zhCN { get => _zhcn!; set => this.AssertWritable()._zhcn = value; }
    /// <summary>Chinese (Simplified, PRC)</summary>
    public IMessageDescription zhCNstroke { get => _zhcnstroke!; set => this.AssertWritable()._zhcnstroke = value; }
    /// <summary>Chinese (Traditional, Hong Kong S.A.R.)</summary>
    public IMessageDescription zhHK { get => _zhhk!; set => this.AssertWritable()._zhhk = value; }
    /// <summary>Chinese (Traditional, Hong Kong S.A.R.)</summary>
    public IMessageDescription zhHKradstr { get => _zhhkradstr!; set => this.AssertWritable()._zhhkradstr = value; }
    /// <summary>Chinese (Simplified)</summary>
    public IMessageDescription zhHans { get => _zhhans!; set => this.AssertWritable()._zhhans = value; }
    /// <summary>Chinese (Simplified Han, Hong Kong SAR)</summary>
    public IMessageDescription zhHansHK { get => _zhhanshk!; set => this.AssertWritable()._zhhanshk = value; }
    /// <summary>Chinese (Simplified Han, Macao SAR)</summary>
    public IMessageDescription zhHansMO { get => _zhhansmo!; set => this.AssertWritable()._zhhansmo = value; }
    /// <summary>Chinese (Traditional)</summary>
    public IMessageDescription zhHant { get => _zhhant!; set => this.AssertWritable()._zhhant = value; }
    /// <summary>Chinese (Traditional, Macao S.A.R.)</summary>
    public IMessageDescription zhMO { get => _zhmo!; set => this.AssertWritable()._zhmo = value; }
    /// <summary>Chinese (Traditional, Macao S.A.R.)</summary>
    public IMessageDescription zhMOradstr { get => _zhmoradstr!; set => this.AssertWritable()._zhmoradstr = value; }
    /// <summary>Chinese (Traditional, Macao S.A.R.)</summary>
    public IMessageDescription zhMOstroke { get => _zhmostroke!; set => this.AssertWritable()._zhmostroke = value; }
    /// <summary>Chinese (Simplified, Singapore)</summary>
    public IMessageDescription zhSG { get => _zhsg!; set => this.AssertWritable()._zhsg = value; }
    /// <summary>Chinese (Simplified, Singapore)</summary>
    public IMessageDescription zhSGstroke { get => _zhsgstroke!; set => this.AssertWritable()._zhsgstroke = value; }
    /// <summary>Chinese (Traditional, Taiwan)</summary>
    public IMessageDescription zhTW { get => _zhtw!; set => this.AssertWritable()._zhtw = value; }
    /// <summary>Chinese (Traditional, Taiwan)</summary>
    public IMessageDescription zhTWpronun { get => _zhtwpronun!; set => this.AssertWritable()._zhtwpronun = value; }
    /// <summary>Chinese (Traditional, Taiwan)</summary>
    public IMessageDescription zhTWradstr { get => _zhtwradstr!; set => this.AssertWritable()._zhtwradstr = value; }
    /// <summary>isiZulu</summary>
    public IMessageDescription zu { get => _zu!; set => this.AssertWritable()._zu = value; }
    /// <summary>isiZulu (South Africa)</summary>
    public IMessageDescription zuZA { get => _zuza!; set => this.AssertWritable()._zuza = value; }

    /// <summary>Initialize fields</summary>
    public override CultureMessages Initialize() 
    {
        base.Initialize();
        Add(_legacymodifier = new MessageDescription("mscorlib.Globalization.LegacyModifier", 0x2345061A, new ParameterlessText("Legacy")));
        Add(_globalizationci = new MessageDescription("mscorlib.Globalization.ci_", 0x23450619, new ParameterlessText("Invariant Language (Invariant Country)")).SetSeverity(MessageLevel.Information));
        Add(_aa = new MessageDescription("mscorlib.Globalization.ci_aa", 0x23450792, new ParameterlessText("Afar")).SetSeverity(MessageLevel.Information));
        Add(_aadj = new MessageDescription("mscorlib.Globalization.ci_aa-DJ", 0x23450793, new ParameterlessText("Afar (Djibouti)")).SetSeverity(MessageLevel.Information));
        Add(_aaer = new MessageDescription("mscorlib.Globalization.ci_aa-ER", 0x23450794, new ParameterlessText("Afar (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_aaet = new MessageDescription("mscorlib.Globalization.ci_aa-ET", 0x23450795, new ParameterlessText("Afar (Ethiopia)")).SetSeverity(MessageLevel.Information));
        Add(_af = new MessageDescription("mscorlib.Globalization.ci_af", 0x23450796, new ParameterlessText("Afrikaans")).SetSeverity(MessageLevel.Information));
        Add(_afna = new MessageDescription("mscorlib.Globalization.ci_af-NA", 0x23450797, new ParameterlessText("Afrikaans (Namibia)")).SetSeverity(MessageLevel.Information));
        Add(_afza = new MessageDescription("mscorlib.Globalization.ci_af-ZA", 0x23450798, new ParameterlessText("Afrikaans (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_agq = new MessageDescription("mscorlib.Globalization.ci_agq", 0x23450799, new ParameterlessText("Aghem")).SetSeverity(MessageLevel.Information));
        Add(_agqcm = new MessageDescription("mscorlib.Globalization.ci_agq-CM", 0x2345079A, new ParameterlessText("Aghem (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_ak = new MessageDescription("mscorlib.Globalization.ci_ak", 0x2345079B, new ParameterlessText("Akan")).SetSeverity(MessageLevel.Information));
        Add(_akgh = new MessageDescription("mscorlib.Globalization.ci_ak-GH", 0x2345079C, new ParameterlessText("Akan (Ghana)")).SetSeverity(MessageLevel.Information));
        Add(_am = new MessageDescription("mscorlib.Globalization.ci_am", 0x2345079D, new ParameterlessText("Amharic")).SetSeverity(MessageLevel.Information));
        Add(_amet = new MessageDescription("mscorlib.Globalization.ci_am-ET", 0x2345079E, new ParameterlessText("Amharic (Ethiopia)")).SetSeverity(MessageLevel.Information));
        Add(_ar = new MessageDescription("mscorlib.Globalization.ci_ar", 0x2345079F, new ParameterlessText("Arabic")).SetSeverity(MessageLevel.Information));
        Add(_ar001 = new MessageDescription("mscorlib.Globalization.ci_ar-001", 0x234507A0, new ParameterlessText("Arabic (World)")).SetSeverity(MessageLevel.Information));
        Add(_arae = new MessageDescription("mscorlib.Globalization.ci_ar-AE", 0x234507A1, new ParameterlessText("Arabic (U.A.E.)")).SetSeverity(MessageLevel.Information));
        Add(_arbh = new MessageDescription("mscorlib.Globalization.ci_ar-BH", 0x234507A2, new ParameterlessText("Arabic (Bahrain)")).SetSeverity(MessageLevel.Information));
        Add(_ardj = new MessageDescription("mscorlib.Globalization.ci_ar-DJ", 0x234507A3, new ParameterlessText("Arabic (Djibouti)")).SetSeverity(MessageLevel.Information));
        Add(_ardz = new MessageDescription("mscorlib.Globalization.ci_ar-DZ", 0x234507A4, new ParameterlessText("Arabic (Algeria)")).SetSeverity(MessageLevel.Information));
        Add(_areg = new MessageDescription("mscorlib.Globalization.ci_ar-EG", 0x234507A5, new ParameterlessText("Arabic (Egypt)")).SetSeverity(MessageLevel.Information));
        Add(_arer = new MessageDescription("mscorlib.Globalization.ci_ar-ER", 0x234507A6, new ParameterlessText("Arabic (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_aril = new MessageDescription("mscorlib.Globalization.ci_ar-IL", 0x234507A7, new ParameterlessText("Arabic (Israel)")).SetSeverity(MessageLevel.Information));
        Add(_ariq = new MessageDescription("mscorlib.Globalization.ci_ar-IQ", 0x234507A8, new ParameterlessText("Arabic (Iraq)")).SetSeverity(MessageLevel.Information));
        Add(_arjo = new MessageDescription("mscorlib.Globalization.ci_ar-JO", 0x234507A9, new ParameterlessText("Arabic (Jordan)")).SetSeverity(MessageLevel.Information));
        Add(_arkm = new MessageDescription("mscorlib.Globalization.ci_ar-KM", 0x234507AA, new ParameterlessText("Arabic (Comoros)")).SetSeverity(MessageLevel.Information));
        Add(_arkw = new MessageDescription("mscorlib.Globalization.ci_ar-KW", 0x234507AB, new ParameterlessText("Arabic (Kuwait)")).SetSeverity(MessageLevel.Information));
        Add(_arlb = new MessageDescription("mscorlib.Globalization.ci_ar-LB", 0x234507AC, new ParameterlessText("Arabic (Lebanon)")).SetSeverity(MessageLevel.Information));
        Add(_arly = new MessageDescription("mscorlib.Globalization.ci_ar-LY", 0x234507AD, new ParameterlessText("Arabic (Libya)")).SetSeverity(MessageLevel.Information));
        Add(_arma = new MessageDescription("mscorlib.Globalization.ci_ar-MA", 0x234507AE, new ParameterlessText("Arabic (Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_armr = new MessageDescription("mscorlib.Globalization.ci_ar-MR", 0x234507AF, new ParameterlessText("Arabic (Mauritania)")).SetSeverity(MessageLevel.Information));
        Add(_arom = new MessageDescription("mscorlib.Globalization.ci_ar-OM", 0x234507B0, new ParameterlessText("Arabic (Oman)")).SetSeverity(MessageLevel.Information));
        Add(_arps = new MessageDescription("mscorlib.Globalization.ci_ar-PS", 0x234507B1, new ParameterlessText("Arabic (Palestinian Authority)")).SetSeverity(MessageLevel.Information));
        Add(_arqa = new MessageDescription("mscorlib.Globalization.ci_ar-QA", 0x234507B2, new ParameterlessText("Arabic (Qatar)")).SetSeverity(MessageLevel.Information));
        Add(_arsa = new MessageDescription("mscorlib.Globalization.ci_ar-SA", 0x234507B3, new ParameterlessText("Arabic (Saudi Arabia)")).SetSeverity(MessageLevel.Information));
        Add(_arsd = new MessageDescription("mscorlib.Globalization.ci_ar-SD", 0x234507B4, new ParameterlessText("Arabic (Sudan)")).SetSeverity(MessageLevel.Information));
        Add(_arso = new MessageDescription("mscorlib.Globalization.ci_ar-SO", 0x234507B5, new ParameterlessText("Arabic (Somalia)")).SetSeverity(MessageLevel.Information));
        Add(_arss = new MessageDescription("mscorlib.Globalization.ci_ar-SS", 0x234507B6, new ParameterlessText("Arabic (South Sudan)")).SetSeverity(MessageLevel.Information));
        Add(_arsy = new MessageDescription("mscorlib.Globalization.ci_ar-SY", 0x234507B7, new ParameterlessText("Arabic (Syria)")).SetSeverity(MessageLevel.Information));
        Add(_artd = new MessageDescription("mscorlib.Globalization.ci_ar-TD", 0x234507B8, new ParameterlessText("Arabic (Chad)")).SetSeverity(MessageLevel.Information));
        Add(_artn = new MessageDescription("mscorlib.Globalization.ci_ar-TN", 0x234507B9, new ParameterlessText("Arabic (Tunisia)")).SetSeverity(MessageLevel.Information));
        Add(_arye = new MessageDescription("mscorlib.Globalization.ci_ar-YE", 0x234507BA, new ParameterlessText("Arabic (Yemen)")).SetSeverity(MessageLevel.Information));
        Add(_arn = new MessageDescription("mscorlib.Globalization.ci_arn", 0x234507BB, new ParameterlessText("Mapudungun")).SetSeverity(MessageLevel.Information));
        Add(_arncl = new MessageDescription("mscorlib.Globalization.ci_arn-CL", 0x234507BC, new ParameterlessText("Mapudungun (Chile)")).SetSeverity(MessageLevel.Information));
        Add(_as = new MessageDescription("mscorlib.Globalization.ci_as", 0x234507BD, new ParameterlessText("Assamese")).SetSeverity(MessageLevel.Information));
        Add(_asin = new MessageDescription("mscorlib.Globalization.ci_as-IN", 0x234507BE, new ParameterlessText("Assamese (India)")).SetSeverity(MessageLevel.Information));
        Add(_asa = new MessageDescription("mscorlib.Globalization.ci_asa", 0x234507BF, new ParameterlessText("Asu")).SetSeverity(MessageLevel.Information));
        Add(_asatz = new MessageDescription("mscorlib.Globalization.ci_asa-TZ", 0x234507C0, new ParameterlessText("Asu (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_ast = new MessageDescription("mscorlib.Globalization.ci_ast", 0x234507C1, new ParameterlessText("Asturian")).SetSeverity(MessageLevel.Information));
        Add(_astes = new MessageDescription("mscorlib.Globalization.ci_ast-ES", 0x234507C2, new ParameterlessText("Asturian (Spain)")).SetSeverity(MessageLevel.Information));
        Add(_az = new MessageDescription("mscorlib.Globalization.ci_az", 0x234507C3, new ParameterlessText("Azerbaijani")).SetSeverity(MessageLevel.Information));
        Add(_azcyrl = new MessageDescription("mscorlib.Globalization.ci_az-Cyrl", 0x234507C4, new ParameterlessText("Azerbaijani (Cyrillic)")).SetSeverity(MessageLevel.Information));
        Add(_azcyrlaz = new MessageDescription("mscorlib.Globalization.ci_az-Cyrl-AZ", 0x234507C5, new ParameterlessText("Azerbaijani (Cyrillic, Azerbaijan)")).SetSeverity(MessageLevel.Information));
        Add(_azlatn = new MessageDescription("mscorlib.Globalization.ci_az-Latn", 0x234507C6, new ParameterlessText("Azerbaijani (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_azlatnaz = new MessageDescription("mscorlib.Globalization.ci_az-Latn-AZ", 0x234507C7, new ParameterlessText("Azerbaijani (Latin, Azerbaijan)")).SetSeverity(MessageLevel.Information));
        Add(_ba = new MessageDescription("mscorlib.Globalization.ci_ba", 0x234507C8, new ParameterlessText("Bashkir")).SetSeverity(MessageLevel.Information));
        Add(_baru = new MessageDescription("mscorlib.Globalization.ci_ba-RU", 0x234507C9, new ParameterlessText("Bashkir (Russia)")).SetSeverity(MessageLevel.Information));
        Add(_bas = new MessageDescription("mscorlib.Globalization.ci_bas", 0x234507CA, new ParameterlessText("Basaa")).SetSeverity(MessageLevel.Information));
        Add(_bascm = new MessageDescription("mscorlib.Globalization.ci_bas-CM", 0x234507CB, new ParameterlessText("Basaa (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_be = new MessageDescription("mscorlib.Globalization.ci_be", 0x234507CC, new ParameterlessText("Belarusian")).SetSeverity(MessageLevel.Information));
        Add(_beby = new MessageDescription("mscorlib.Globalization.ci_be-BY", 0x234507CD, new ParameterlessText("Belarusian (Belarus)")).SetSeverity(MessageLevel.Information));
        Add(_bem = new MessageDescription("mscorlib.Globalization.ci_bem", 0x234507CE, new ParameterlessText("Bemba")).SetSeverity(MessageLevel.Information));
        Add(_bemzm = new MessageDescription("mscorlib.Globalization.ci_bem-ZM", 0x234507CF, new ParameterlessText("Bemba (Zambia)")).SetSeverity(MessageLevel.Information));
        Add(_bez = new MessageDescription("mscorlib.Globalization.ci_bez", 0x234507D0, new ParameterlessText("Bena")).SetSeverity(MessageLevel.Information));
        Add(_beztz = new MessageDescription("mscorlib.Globalization.ci_bez-TZ", 0x234507D1, new ParameterlessText("Bena (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_bg = new MessageDescription("mscorlib.Globalization.ci_bg", 0x234507D2, new ParameterlessText("Bulgarian")).SetSeverity(MessageLevel.Information));
        Add(_bgbg = new MessageDescription("mscorlib.Globalization.ci_bg-BG", 0x234507D3, new ParameterlessText("Bulgarian (Bulgaria)")).SetSeverity(MessageLevel.Information));
        Add(_bin = new MessageDescription("mscorlib.Globalization.ci_bin", 0x234507D4, new ParameterlessText("Edo")).SetSeverity(MessageLevel.Information));
        Add(_binng = new MessageDescription("mscorlib.Globalization.ci_bin-NG", 0x234507D5, new ParameterlessText("Edo (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_bm = new MessageDescription("mscorlib.Globalization.ci_bm", 0x234507D6, new ParameterlessText("Bambara")).SetSeverity(MessageLevel.Information));
        Add(_bmlatn = new MessageDescription("mscorlib.Globalization.ci_bm-Latn", 0x234507D7, new ParameterlessText("Bambara (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_bmlatnml = new MessageDescription("mscorlib.Globalization.ci_bm-Latn-ML", 0x234507D8, new ParameterlessText("Bambara (Latin, Mali)")).SetSeverity(MessageLevel.Information));
        Add(_bmml = new MessageDescription("mscorlib.Globalization.ci_bm-ML", 0x234507D9, new ParameterlessText("Bamanankan (Latin, Mali)")).SetSeverity(MessageLevel.Information));
        Add(_bn = new MessageDescription("mscorlib.Globalization.ci_bn", 0x234507DA, new ParameterlessText("Bangla")).SetSeverity(MessageLevel.Information));
        Add(_bnbd = new MessageDescription("mscorlib.Globalization.ci_bn-BD", 0x234507DB, new ParameterlessText("Bangla (Bangladesh)")).SetSeverity(MessageLevel.Information));
        Add(_bnin = new MessageDescription("mscorlib.Globalization.ci_bn-IN", 0x234507DC, new ParameterlessText("Bangla (India)")).SetSeverity(MessageLevel.Information));
        Add(_bo = new MessageDescription("mscorlib.Globalization.ci_bo", 0x234507DD, new ParameterlessText("Tibetan")).SetSeverity(MessageLevel.Information));
        Add(_bocn = new MessageDescription("mscorlib.Globalization.ci_bo-CN", 0x234507DE, new ParameterlessText("Tibetan (PRC)")).SetSeverity(MessageLevel.Information));
        Add(_boin = new MessageDescription("mscorlib.Globalization.ci_bo-IN", 0x234507DF, new ParameterlessText("Tibetan (India)")).SetSeverity(MessageLevel.Information));
        Add(_br = new MessageDescription("mscorlib.Globalization.ci_br", 0x234507E0, new ParameterlessText("Breton")).SetSeverity(MessageLevel.Information));
        Add(_brfr = new MessageDescription("mscorlib.Globalization.ci_br-FR", 0x234507E1, new ParameterlessText("Breton (France)")).SetSeverity(MessageLevel.Information));
        Add(_brx = new MessageDescription("mscorlib.Globalization.ci_brx", 0x234507E2, new ParameterlessText("Bodo")).SetSeverity(MessageLevel.Information));
        Add(_brxin = new MessageDescription("mscorlib.Globalization.ci_brx-IN", 0x234507E3, new ParameterlessText("Bodo (India)")).SetSeverity(MessageLevel.Information));
        Add(_bs = new MessageDescription("mscorlib.Globalization.ci_bs", 0x234507E4, new ParameterlessText("Bosnian")).SetSeverity(MessageLevel.Information));
        Add(_bscyrl = new MessageDescription("mscorlib.Globalization.ci_bs-Cyrl", 0x234507E5, new ParameterlessText("Bosnian (Cyrillic)")).SetSeverity(MessageLevel.Information));
        Add(_bscyrlba = new MessageDescription("mscorlib.Globalization.ci_bs-Cyrl-BA", 0x234507E6, new ParameterlessText("Bosnian (Cyrillic, Bosnia and Herzegovina)")).SetSeverity(MessageLevel.Information));
        Add(_bslatn = new MessageDescription("mscorlib.Globalization.ci_bs-Latn", 0x234507E7, new ParameterlessText("Bosnian (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_bslatnba = new MessageDescription("mscorlib.Globalization.ci_bs-Latn-BA", 0x234507E8, new ParameterlessText("Bosnian (Latin, Bosnia and Herzegovina)")).SetSeverity(MessageLevel.Information));
        Add(_byn = new MessageDescription("mscorlib.Globalization.ci_byn", 0x234507E9, new ParameterlessText("Blin")).SetSeverity(MessageLevel.Information));
        Add(_byner = new MessageDescription("mscorlib.Globalization.ci_byn-ER", 0x234507EA, new ParameterlessText("Blin (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_ca = new MessageDescription("mscorlib.Globalization.ci_ca", 0x234507EB, new ParameterlessText("Catalan")).SetSeverity(MessageLevel.Information));
        Add(_caad = new MessageDescription("mscorlib.Globalization.ci_ca-AD", 0x234507EC, new ParameterlessText("Catalan (Andorra)")).SetSeverity(MessageLevel.Information));
        Add(_caes = new MessageDescription("mscorlib.Globalization.ci_ca-ES", 0x234507ED, new ParameterlessText("Catalan (Catalan)")).SetSeverity(MessageLevel.Information));
        Add(_caesvalencia = new MessageDescription("mscorlib.Globalization.ci_ca-ES-valencia", 0x234507EE, new ParameterlessText("Valencian (Spain)")).SetSeverity(MessageLevel.Information));
        Add(_cafr = new MessageDescription("mscorlib.Globalization.ci_ca-FR", 0x234507EF, new ParameterlessText("Catalan (France)")).SetSeverity(MessageLevel.Information));
        Add(_cait = new MessageDescription("mscorlib.Globalization.ci_ca-IT", 0x234507F0, new ParameterlessText("Catalan (Italy)")).SetSeverity(MessageLevel.Information));
        Add(_cgg = new MessageDescription("mscorlib.Globalization.ci_cgg", 0x234507F1, new ParameterlessText("Chiga")).SetSeverity(MessageLevel.Information));
        Add(_cggug = new MessageDescription("mscorlib.Globalization.ci_cgg-UG", 0x234507F2, new ParameterlessText("Chiga (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_chr = new MessageDescription("mscorlib.Globalization.ci_chr", 0x234507F3, new ParameterlessText("Cherokee")).SetSeverity(MessageLevel.Information));
        Add(_chrcher = new MessageDescription("mscorlib.Globalization.ci_chr-Cher", 0x234507F4, new ParameterlessText("Cherokee (Cherokee)")).SetSeverity(MessageLevel.Information));
        Add(_chrcherus = new MessageDescription("mscorlib.Globalization.ci_chr-Cher-US", 0x234507F5, new ParameterlessText("Cherokee (Cherokee)")).SetSeverity(MessageLevel.Information));
        Add(_co = new MessageDescription("mscorlib.Globalization.ci_co", 0x234507F6, new ParameterlessText("Corsican")).SetSeverity(MessageLevel.Information));
        Add(_cofr = new MessageDescription("mscorlib.Globalization.ci_co-FR", 0x234507F7, new ParameterlessText("Corsican (France)")).SetSeverity(MessageLevel.Information));
        Add(_cs = new MessageDescription("mscorlib.Globalization.ci_cs", 0x234507F8, new ParameterlessText("Czech")).SetSeverity(MessageLevel.Information));
        Add(_cscz = new MessageDescription("mscorlib.Globalization.ci_cs-CZ", 0x234507F9, new ParameterlessText("Czech (Czech Republic)")).SetSeverity(MessageLevel.Information));
        Add(_cy = new MessageDescription("mscorlib.Globalization.ci_cy", 0x234507FA, new ParameterlessText("Welsh")).SetSeverity(MessageLevel.Information));
        Add(_cygb = new MessageDescription("mscorlib.Globalization.ci_cy-GB", 0x234507FB, new ParameterlessText("Welsh (United Kingdom)")).SetSeverity(MessageLevel.Information));
        Add(_da = new MessageDescription("mscorlib.Globalization.ci_da", 0x234507FC, new ParameterlessText("Danish")).SetSeverity(MessageLevel.Information));
        Add(_dadk = new MessageDescription("mscorlib.Globalization.ci_da-DK", 0x234507FD, new ParameterlessText("Danish (Denmark)")).SetSeverity(MessageLevel.Information));
        Add(_dagl = new MessageDescription("mscorlib.Globalization.ci_da-GL", 0x234507FE, new ParameterlessText("Danish (Greenland)")).SetSeverity(MessageLevel.Information));
        Add(_dav = new MessageDescription("mscorlib.Globalization.ci_dav", 0x234507FF, new ParameterlessText("Taita")).SetSeverity(MessageLevel.Information));
        Add(_davke = new MessageDescription("mscorlib.Globalization.ci_dav-KE", 0x23450800, new ParameterlessText("Taita (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_de = new MessageDescription("mscorlib.Globalization.ci_de", 0x23450801, new ParameterlessText("German")).SetSeverity(MessageLevel.Information));
        Add(_deat = new MessageDescription("mscorlib.Globalization.ci_de-AT", 0x23450802, new ParameterlessText("German (Austria)")).SetSeverity(MessageLevel.Information));
        Add(_debe = new MessageDescription("mscorlib.Globalization.ci_de-BE", 0x23450803, new ParameterlessText("German (Belgium)")).SetSeverity(MessageLevel.Information));
        Add(_dech = new MessageDescription("mscorlib.Globalization.ci_de-CH", 0x23450804, new ParameterlessText("German (Switzerland)")).SetSeverity(MessageLevel.Information));
        Add(_dede = new MessageDescription("mscorlib.Globalization.ci_de-DE", 0x23450805, new ParameterlessText("German (Germany)")).SetSeverity(MessageLevel.Information));
        Add(_dedephoneb = new MessageDescription("mscorlib.Globalization.ci_de-DE_phoneb", 0x23450806, new ParameterlessText("German (Germany)")).SetSeverity(MessageLevel.Information));
        Add(_deli = new MessageDescription("mscorlib.Globalization.ci_de-LI", 0x23450807, new ParameterlessText("German (Liechtenstein)")).SetSeverity(MessageLevel.Information));
        Add(_delu = new MessageDescription("mscorlib.Globalization.ci_de-LU", 0x23450808, new ParameterlessText("German (Luxembourg)")).SetSeverity(MessageLevel.Information));
        Add(_dje = new MessageDescription("mscorlib.Globalization.ci_dje", 0x23450809, new ParameterlessText("Zarma")).SetSeverity(MessageLevel.Information));
        Add(_djene = new MessageDescription("mscorlib.Globalization.ci_dje-NE", 0x2345080A, new ParameterlessText("Zarma (Niger)")).SetSeverity(MessageLevel.Information));
        Add(_dsb = new MessageDescription("mscorlib.Globalization.ci_dsb", 0x2345080B, new ParameterlessText("Lower Sorbian")).SetSeverity(MessageLevel.Information));
        Add(_dsbde = new MessageDescription("mscorlib.Globalization.ci_dsb-DE", 0x2345080C, new ParameterlessText("Lower Sorbian (Germany)")).SetSeverity(MessageLevel.Information));
        Add(_dua = new MessageDescription("mscorlib.Globalization.ci_dua", 0x2345080D, new ParameterlessText("Duala")).SetSeverity(MessageLevel.Information));
        Add(_duacm = new MessageDescription("mscorlib.Globalization.ci_dua-CM", 0x2345080E, new ParameterlessText("Duala (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_dv = new MessageDescription("mscorlib.Globalization.ci_dv", 0x2345080F, new ParameterlessText("Divehi")).SetSeverity(MessageLevel.Information));
        Add(_dvmv = new MessageDescription("mscorlib.Globalization.ci_dv-MV", 0x23450810, new ParameterlessText("Divehi (Maldives)")).SetSeverity(MessageLevel.Information));
        Add(_dyo = new MessageDescription("mscorlib.Globalization.ci_dyo", 0x23450811, new ParameterlessText("Jola-Fonyi")).SetSeverity(MessageLevel.Information));
        Add(_dyosn = new MessageDescription("mscorlib.Globalization.ci_dyo-SN", 0x23450812, new ParameterlessText("Jola-Fonyi (Senegal)")).SetSeverity(MessageLevel.Information));
        Add(_dz = new MessageDescription("mscorlib.Globalization.ci_dz", 0x23450813, new ParameterlessText("Dzongkha")).SetSeverity(MessageLevel.Information));
        Add(_dzbt = new MessageDescription("mscorlib.Globalization.ci_dz-BT", 0x23450814, new ParameterlessText("Dzongkha (Bhutan)")).SetSeverity(MessageLevel.Information));
        Add(_ebu = new MessageDescription("mscorlib.Globalization.ci_ebu", 0x23450815, new ParameterlessText("Embu")).SetSeverity(MessageLevel.Information));
        Add(_ebuke = new MessageDescription("mscorlib.Globalization.ci_ebu-KE", 0x23450816, new ParameterlessText("Embu (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_ee = new MessageDescription("mscorlib.Globalization.ci_ee", 0x23450817, new ParameterlessText("Ewe")).SetSeverity(MessageLevel.Information));
        Add(_eegh = new MessageDescription("mscorlib.Globalization.ci_ee-GH", 0x23450818, new ParameterlessText("Ewe (Ghana)")).SetSeverity(MessageLevel.Information));
        Add(_eetg = new MessageDescription("mscorlib.Globalization.ci_ee-TG", 0x23450819, new ParameterlessText("Ewe (Togo)")).SetSeverity(MessageLevel.Information));
        Add(_el = new MessageDescription("mscorlib.Globalization.ci_el", 0x2345081A, new ParameterlessText("Greek")).SetSeverity(MessageLevel.Information));
        Add(_elcy = new MessageDescription("mscorlib.Globalization.ci_el-CY", 0x2345081B, new ParameterlessText("Greek (Cyprus)")).SetSeverity(MessageLevel.Information));
        Add(_elgr = new MessageDescription("mscorlib.Globalization.ci_el-GR", 0x2345081C, new ParameterlessText("Greek (Greece)")).SetSeverity(MessageLevel.Information));
        Add(_en = new MessageDescription("mscorlib.Globalization.ci_en", 0x2345081D, new ParameterlessText("English")).SetSeverity(MessageLevel.Information));
        Add(_en001 = new MessageDescription("mscorlib.Globalization.ci_en-001", 0x2345081E, new ParameterlessText("English (World)")).SetSeverity(MessageLevel.Information));
        Add(_en029 = new MessageDescription("mscorlib.Globalization.ci_en-029", 0x2345081F, new ParameterlessText("English (Caribbean)")).SetSeverity(MessageLevel.Information));
        Add(_en150 = new MessageDescription("mscorlib.Globalization.ci_en-150", 0x23450820, new ParameterlessText("English (Europe)")).SetSeverity(MessageLevel.Information));
        Add(_enag = new MessageDescription("mscorlib.Globalization.ci_en-AG", 0x23450821, new ParameterlessText("English (Antigua and Barbuda)")).SetSeverity(MessageLevel.Information));
        Add(_enai = new MessageDescription("mscorlib.Globalization.ci_en-AI", 0x23450822, new ParameterlessText("English (Anguilla)")).SetSeverity(MessageLevel.Information));
        Add(_enas = new MessageDescription("mscorlib.Globalization.ci_en-AS", 0x23450823, new ParameterlessText("English (American Samoa)")).SetSeverity(MessageLevel.Information));
        Add(_enau = new MessageDescription("mscorlib.Globalization.ci_en-AU", 0x23450824, new ParameterlessText("English (Australia)")).SetSeverity(MessageLevel.Information));
        Add(_enbb = new MessageDescription("mscorlib.Globalization.ci_en-BB", 0x23450825, new ParameterlessText("English (Barbados)")).SetSeverity(MessageLevel.Information));
        Add(_enbe = new MessageDescription("mscorlib.Globalization.ci_en-BE", 0x23450826, new ParameterlessText("English (Belgium)")).SetSeverity(MessageLevel.Information));
        Add(_enbm = new MessageDescription("mscorlib.Globalization.ci_en-BM", 0x23450827, new ParameterlessText("English (Bermuda)")).SetSeverity(MessageLevel.Information));
        Add(_enbs = new MessageDescription("mscorlib.Globalization.ci_en-BS", 0x23450828, new ParameterlessText("English (Bahamas)")).SetSeverity(MessageLevel.Information));
        Add(_enbw = new MessageDescription("mscorlib.Globalization.ci_en-BW", 0x23450829, new ParameterlessText("English (Botswana)")).SetSeverity(MessageLevel.Information));
        Add(_enbz = new MessageDescription("mscorlib.Globalization.ci_en-BZ", 0x2345082A, new ParameterlessText("English (Belize)")).SetSeverity(MessageLevel.Information));
        Add(_enca = new MessageDescription("mscorlib.Globalization.ci_en-CA", 0x2345082B, new ParameterlessText("English (Canada)")).SetSeverity(MessageLevel.Information));
        Add(_encc = new MessageDescription("mscorlib.Globalization.ci_en-CC", 0x2345082C, new ParameterlessText("English (Cocos [Keeling] Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enck = new MessageDescription("mscorlib.Globalization.ci_en-CK", 0x2345082D, new ParameterlessText("English (Cook Islands)")).SetSeverity(MessageLevel.Information));
        Add(_encm = new MessageDescription("mscorlib.Globalization.ci_en-CM", 0x2345082E, new ParameterlessText("English (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_encx = new MessageDescription("mscorlib.Globalization.ci_en-CX", 0x2345082F, new ParameterlessText("English (Christmas Island)")).SetSeverity(MessageLevel.Information));
        Add(_endm = new MessageDescription("mscorlib.Globalization.ci_en-DM", 0x23450830, new ParameterlessText("English (Dominica)")).SetSeverity(MessageLevel.Information));
        Add(_ener = new MessageDescription("mscorlib.Globalization.ci_en-ER", 0x23450831, new ParameterlessText("English (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_enfj = new MessageDescription("mscorlib.Globalization.ci_en-FJ", 0x23450832, new ParameterlessText("English (Fiji)")).SetSeverity(MessageLevel.Information));
        Add(_enfk = new MessageDescription("mscorlib.Globalization.ci_en-FK", 0x23450833, new ParameterlessText("English (Falkland Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enfm = new MessageDescription("mscorlib.Globalization.ci_en-FM", 0x23450834, new ParameterlessText("English (Micronesia)")).SetSeverity(MessageLevel.Information));
        Add(_engb = new MessageDescription("mscorlib.Globalization.ci_en-GB", 0x23450835, new ParameterlessText("English (United Kingdom)")).SetSeverity(MessageLevel.Information));
        Add(_engd = new MessageDescription("mscorlib.Globalization.ci_en-GD", 0x23450836, new ParameterlessText("English (Grenada)")).SetSeverity(MessageLevel.Information));
        Add(_engg = new MessageDescription("mscorlib.Globalization.ci_en-GG", 0x23450837, new ParameterlessText("English (Guernsey)")).SetSeverity(MessageLevel.Information));
        Add(_engh = new MessageDescription("mscorlib.Globalization.ci_en-GH", 0x23450838, new ParameterlessText("English (Ghana)")).SetSeverity(MessageLevel.Information));
        Add(_engi = new MessageDescription("mscorlib.Globalization.ci_en-GI", 0x23450839, new ParameterlessText("English (Gibraltar)")).SetSeverity(MessageLevel.Information));
        Add(_engm = new MessageDescription("mscorlib.Globalization.ci_en-GM", 0x2345083A, new ParameterlessText("English (Gambia)")).SetSeverity(MessageLevel.Information));
        Add(_engu = new MessageDescription("mscorlib.Globalization.ci_en-GU", 0x2345083B, new ParameterlessText("English (Guam)")).SetSeverity(MessageLevel.Information));
        Add(_engy = new MessageDescription("mscorlib.Globalization.ci_en-GY", 0x2345083C, new ParameterlessText("English (Guyana)")).SetSeverity(MessageLevel.Information));
        Add(_enhk = new MessageDescription("mscorlib.Globalization.ci_en-HK", 0x2345083D, new ParameterlessText("English (Hong Kong SAR)")).SetSeverity(MessageLevel.Information));
        Add(_enid = new MessageDescription("mscorlib.Globalization.ci_en-ID", 0x2345083E, new ParameterlessText("English (Indonesia)")).SetSeverity(MessageLevel.Information));
        Add(_enie = new MessageDescription("mscorlib.Globalization.ci_en-IE", 0x2345083F, new ParameterlessText("English (Ireland)")).SetSeverity(MessageLevel.Information));
        Add(_enim = new MessageDescription("mscorlib.Globalization.ci_en-IM", 0x23450840, new ParameterlessText("English (Isle of Man)")).SetSeverity(MessageLevel.Information));
        Add(_enin = new MessageDescription("mscorlib.Globalization.ci_en-IN", 0x23450841, new ParameterlessText("English (India)")).SetSeverity(MessageLevel.Information));
        Add(_enio = new MessageDescription("mscorlib.Globalization.ci_en-IO", 0x23450842, new ParameterlessText("English (British Indian Ocean Territory)")).SetSeverity(MessageLevel.Information));
        Add(_enje = new MessageDescription("mscorlib.Globalization.ci_en-JE", 0x23450843, new ParameterlessText("English (Jersey)")).SetSeverity(MessageLevel.Information));
        Add(_enjm = new MessageDescription("mscorlib.Globalization.ci_en-JM", 0x23450844, new ParameterlessText("English (Jamaica)")).SetSeverity(MessageLevel.Information));
        Add(_enke = new MessageDescription("mscorlib.Globalization.ci_en-KE", 0x23450845, new ParameterlessText("English (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_enki = new MessageDescription("mscorlib.Globalization.ci_en-KI", 0x23450846, new ParameterlessText("English (Kiribati)")).SetSeverity(MessageLevel.Information));
        Add(_enkn = new MessageDescription("mscorlib.Globalization.ci_en-KN", 0x23450847, new ParameterlessText("English (Saint Kitts and Nevis)")).SetSeverity(MessageLevel.Information));
        Add(_enky = new MessageDescription("mscorlib.Globalization.ci_en-KY", 0x23450848, new ParameterlessText("English (Cayman Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enlc = new MessageDescription("mscorlib.Globalization.ci_en-LC", 0x23450849, new ParameterlessText("English (Saint Lucia)")).SetSeverity(MessageLevel.Information));
        Add(_enlr = new MessageDescription("mscorlib.Globalization.ci_en-LR", 0x2345084A, new ParameterlessText("English (Liberia)")).SetSeverity(MessageLevel.Information));
        Add(_enls = new MessageDescription("mscorlib.Globalization.ci_en-LS", 0x2345084B, new ParameterlessText("English (Lesotho)")).SetSeverity(MessageLevel.Information));
        Add(_enmg = new MessageDescription("mscorlib.Globalization.ci_en-MG", 0x2345084C, new ParameterlessText("English (Madagascar)")).SetSeverity(MessageLevel.Information));
        Add(_enmh = new MessageDescription("mscorlib.Globalization.ci_en-MH", 0x2345084D, new ParameterlessText("English (Marshall Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enmo = new MessageDescription("mscorlib.Globalization.ci_en-MO", 0x2345084E, new ParameterlessText("English (Macao SAR)")).SetSeverity(MessageLevel.Information));
        Add(_enmp = new MessageDescription("mscorlib.Globalization.ci_en-MP", 0x2345084F, new ParameterlessText("English (Northern Mariana Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enms = new MessageDescription("mscorlib.Globalization.ci_en-MS", 0x23450850, new ParameterlessText("English (Montserrat)")).SetSeverity(MessageLevel.Information));
        Add(_enmt = new MessageDescription("mscorlib.Globalization.ci_en-MT", 0x23450851, new ParameterlessText("English (Malta)")).SetSeverity(MessageLevel.Information));
        Add(_enmu = new MessageDescription("mscorlib.Globalization.ci_en-MU", 0x23450852, new ParameterlessText("English (Mauritius)")).SetSeverity(MessageLevel.Information));
        Add(_enmw = new MessageDescription("mscorlib.Globalization.ci_en-MW", 0x23450853, new ParameterlessText("English (Malawi)")).SetSeverity(MessageLevel.Information));
        Add(_enmy = new MessageDescription("mscorlib.Globalization.ci_en-MY", 0x23450854, new ParameterlessText("English (Malaysia)")).SetSeverity(MessageLevel.Information));
        Add(_enna = new MessageDescription("mscorlib.Globalization.ci_en-NA", 0x23450855, new ParameterlessText("English (Namibia)")).SetSeverity(MessageLevel.Information));
        Add(_ennf = new MessageDescription("mscorlib.Globalization.ci_en-NF", 0x23450856, new ParameterlessText("English (Norfolk Island)")).SetSeverity(MessageLevel.Information));
        Add(_enng = new MessageDescription("mscorlib.Globalization.ci_en-NG", 0x23450857, new ParameterlessText("English (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_ennr = new MessageDescription("mscorlib.Globalization.ci_en-NR", 0x23450858, new ParameterlessText("English (Nauru)")).SetSeverity(MessageLevel.Information));
        Add(_ennu = new MessageDescription("mscorlib.Globalization.ci_en-NU", 0x23450859, new ParameterlessText("English (Niue)")).SetSeverity(MessageLevel.Information));
        Add(_ennz = new MessageDescription("mscorlib.Globalization.ci_en-NZ", 0x2345085A, new ParameterlessText("English (New Zealand)")).SetSeverity(MessageLevel.Information));
        Add(_enpg = new MessageDescription("mscorlib.Globalization.ci_en-PG", 0x2345085B, new ParameterlessText("English (Papua New Guinea)")).SetSeverity(MessageLevel.Information));
        Add(_enph = new MessageDescription("mscorlib.Globalization.ci_en-PH", 0x2345085C, new ParameterlessText("English (Republic of the Philippines)")).SetSeverity(MessageLevel.Information));
        Add(_enpk = new MessageDescription("mscorlib.Globalization.ci_en-PK", 0x2345085D, new ParameterlessText("English (Pakistan)")).SetSeverity(MessageLevel.Information));
        Add(_enpn = new MessageDescription("mscorlib.Globalization.ci_en-PN", 0x2345085E, new ParameterlessText("English (Pitcairn Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enpr = new MessageDescription("mscorlib.Globalization.ci_en-PR", 0x2345085F, new ParameterlessText("English (Puerto Rico)")).SetSeverity(MessageLevel.Information));
        Add(_enpw = new MessageDescription("mscorlib.Globalization.ci_en-PW", 0x23450860, new ParameterlessText("English (Palau)")).SetSeverity(MessageLevel.Information));
        Add(_enrw = new MessageDescription("mscorlib.Globalization.ci_en-RW", 0x23450861, new ParameterlessText("English (Rwanda)")).SetSeverity(MessageLevel.Information));
        Add(_ensb = new MessageDescription("mscorlib.Globalization.ci_en-SB", 0x23450862, new ParameterlessText("English (Solomon Islands)")).SetSeverity(MessageLevel.Information));
        Add(_ensc = new MessageDescription("mscorlib.Globalization.ci_en-SC", 0x23450863, new ParameterlessText("English (Seychelles)")).SetSeverity(MessageLevel.Information));
        Add(_ensd = new MessageDescription("mscorlib.Globalization.ci_en-SD", 0x23450864, new ParameterlessText("English (Sudan)")).SetSeverity(MessageLevel.Information));
        Add(_ensg = new MessageDescription("mscorlib.Globalization.ci_en-SG", 0x23450865, new ParameterlessText("English (Singapore)")).SetSeverity(MessageLevel.Information));
        Add(_ensh = new MessageDescription("mscorlib.Globalization.ci_en-SH", 0x23450866, new ParameterlessText("English (St Helena, Ascension, Tristan da Cunha)")).SetSeverity(MessageLevel.Information));
        Add(_ensl = new MessageDescription("mscorlib.Globalization.ci_en-SL", 0x23450867, new ParameterlessText("English (Sierra Leone)")).SetSeverity(MessageLevel.Information));
        Add(_enss = new MessageDescription("mscorlib.Globalization.ci_en-SS", 0x23450868, new ParameterlessText("English (South Sudan)")).SetSeverity(MessageLevel.Information));
        Add(_ensx = new MessageDescription("mscorlib.Globalization.ci_en-SX", 0x23450869, new ParameterlessText("English (Sint Maarten)")).SetSeverity(MessageLevel.Information));
        Add(_ensz = new MessageDescription("mscorlib.Globalization.ci_en-SZ", 0x2345086A, new ParameterlessText("English (Swaziland)")).SetSeverity(MessageLevel.Information));
        Add(_entc = new MessageDescription("mscorlib.Globalization.ci_en-TC", 0x2345086B, new ParameterlessText("English (Turks and Caicos Islands)")).SetSeverity(MessageLevel.Information));
        Add(_entk = new MessageDescription("mscorlib.Globalization.ci_en-TK", 0x2345086C, new ParameterlessText("English (Tokelau)")).SetSeverity(MessageLevel.Information));
        Add(_ento = new MessageDescription("mscorlib.Globalization.ci_en-TO", 0x2345086D, new ParameterlessText("English (Tonga)")).SetSeverity(MessageLevel.Information));
        Add(_entt = new MessageDescription("mscorlib.Globalization.ci_en-TT", 0x2345086E, new ParameterlessText("English (Trinidad and Tobago)")).SetSeverity(MessageLevel.Information));
        Add(_entv = new MessageDescription("mscorlib.Globalization.ci_en-TV", 0x2345086F, new ParameterlessText("English (Tuvalu)")).SetSeverity(MessageLevel.Information));
        Add(_entz = new MessageDescription("mscorlib.Globalization.ci_en-TZ", 0x23450870, new ParameterlessText("English (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_enug = new MessageDescription("mscorlib.Globalization.ci_en-UG", 0x23450871, new ParameterlessText("English (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_enum = new MessageDescription("mscorlib.Globalization.ci_en-UM", 0x23450872, new ParameterlessText("English (US Minor Outlying Islands)")).SetSeverity(MessageLevel.Information));
        Add(_enus = new MessageDescription("mscorlib.Globalization.ci_en-US", 0x23450873, new ParameterlessText("English (United States)")).SetSeverity(MessageLevel.Information));
        Add(_envc = new MessageDescription("mscorlib.Globalization.ci_en-VC", 0x23450874, new ParameterlessText("English (Saint Vincent and the Grenadines)")).SetSeverity(MessageLevel.Information));
        Add(_envg = new MessageDescription("mscorlib.Globalization.ci_en-VG", 0x23450875, new ParameterlessText("English (British Virgin Islands)")).SetSeverity(MessageLevel.Information));
        Add(_envi = new MessageDescription("mscorlib.Globalization.ci_en-VI", 0x23450876, new ParameterlessText("English (US Virgin Islands)")).SetSeverity(MessageLevel.Information));
        Add(_envu = new MessageDescription("mscorlib.Globalization.ci_en-VU", 0x23450877, new ParameterlessText("English (Vanuatu)")).SetSeverity(MessageLevel.Information));
        Add(_enws = new MessageDescription("mscorlib.Globalization.ci_en-WS", 0x23450878, new ParameterlessText("English (Samoa)")).SetSeverity(MessageLevel.Information));
        Add(_enza = new MessageDescription("mscorlib.Globalization.ci_en-ZA", 0x23450879, new ParameterlessText("English (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_enzm = new MessageDescription("mscorlib.Globalization.ci_en-ZM", 0x2345087A, new ParameterlessText("English (Zambia)")).SetSeverity(MessageLevel.Information));
        Add(_enzw = new MessageDescription("mscorlib.Globalization.ci_en-ZW", 0x2345087B, new ParameterlessText("English (Zimbabwe)")).SetSeverity(MessageLevel.Information));
        Add(_eo = new MessageDescription("mscorlib.Globalization.ci_eo", 0x2345087C, new ParameterlessText("Esperanto")).SetSeverity(MessageLevel.Information));
        Add(_eo001 = new MessageDescription("mscorlib.Globalization.ci_eo-001", 0x2345087D, new ParameterlessText("Esperanto (World)")).SetSeverity(MessageLevel.Information));
        Add(_es = new MessageDescription("mscorlib.Globalization.ci_es", 0x2345087E, new ParameterlessText("Spanish")).SetSeverity(MessageLevel.Information));
        Add(_es419 = new MessageDescription("mscorlib.Globalization.ci_es-419", 0x2345087F, new ParameterlessText("Spanish (Latin America)")).SetSeverity(MessageLevel.Information));
        Add(_esar = new MessageDescription("mscorlib.Globalization.ci_es-AR", 0x23450880, new ParameterlessText("Spanish (Argentina)")).SetSeverity(MessageLevel.Information));
        Add(_esbo = new MessageDescription("mscorlib.Globalization.ci_es-BO", 0x23450881, new ParameterlessText("Spanish (Bolivia)")).SetSeverity(MessageLevel.Information));
        Add(_escl = new MessageDescription("mscorlib.Globalization.ci_es-CL", 0x23450882, new ParameterlessText("Spanish (Chile)")).SetSeverity(MessageLevel.Information));
        Add(_esco = new MessageDescription("mscorlib.Globalization.ci_es-CO", 0x23450883, new ParameterlessText("Spanish (Colombia)")).SetSeverity(MessageLevel.Information));
        Add(_escr = new MessageDescription("mscorlib.Globalization.ci_es-CR", 0x23450884, new ParameterlessText("Spanish (Costa Rica)")).SetSeverity(MessageLevel.Information));
        Add(_escu = new MessageDescription("mscorlib.Globalization.ci_es-CU", 0x23450885, new ParameterlessText("Spanish (Cuba)")).SetSeverity(MessageLevel.Information));
        Add(_esdo = new MessageDescription("mscorlib.Globalization.ci_es-DO", 0x23450886, new ParameterlessText("Spanish (Dominican Republic)")).SetSeverity(MessageLevel.Information));
        Add(_esec = new MessageDescription("mscorlib.Globalization.ci_es-EC", 0x23450887, new ParameterlessText("Spanish (Ecuador)")).SetSeverity(MessageLevel.Information));
        Add(_eses = new MessageDescription("mscorlib.Globalization.ci_es-ES", 0x23450888, new ParameterlessText("Spanish (Spain)")).SetSeverity(MessageLevel.Information));
        Add(_esestradnl = new MessageDescription("mscorlib.Globalization.ci_es-ES_tradnl", 0x23450889, new ParameterlessText("Spanish (Spain)")).SetSeverity(MessageLevel.Information));
        Add(_esgq = new MessageDescription("mscorlib.Globalization.ci_es-GQ", 0x2345088A, new ParameterlessText("Spanish (Equatorial Guinea)")).SetSeverity(MessageLevel.Information));
        Add(_esgt = new MessageDescription("mscorlib.Globalization.ci_es-GT", 0x2345088B, new ParameterlessText("Spanish (Guatemala)")).SetSeverity(MessageLevel.Information));
        Add(_eshn = new MessageDescription("mscorlib.Globalization.ci_es-HN", 0x2345088C, new ParameterlessText("Spanish (Honduras)")).SetSeverity(MessageLevel.Information));
        Add(_esmx = new MessageDescription("mscorlib.Globalization.ci_es-MX", 0x2345088D, new ParameterlessText("Spanish (Mexico)")).SetSeverity(MessageLevel.Information));
        Add(_esni = new MessageDescription("mscorlib.Globalization.ci_es-NI", 0x2345088E, new ParameterlessText("Spanish (Nicaragua)")).SetSeverity(MessageLevel.Information));
        Add(_espa = new MessageDescription("mscorlib.Globalization.ci_es-PA", 0x2345088F, new ParameterlessText("Spanish (Panama)")).SetSeverity(MessageLevel.Information));
        Add(_espe = new MessageDescription("mscorlib.Globalization.ci_es-PE", 0x23450890, new ParameterlessText("Spanish (Peru)")).SetSeverity(MessageLevel.Information));
        Add(_esph = new MessageDescription("mscorlib.Globalization.ci_es-PH", 0x23450891, new ParameterlessText("Spanish (Philippines)")).SetSeverity(MessageLevel.Information));
        Add(_espr = new MessageDescription("mscorlib.Globalization.ci_es-PR", 0x23450892, new ParameterlessText("Spanish (Puerto Rico)")).SetSeverity(MessageLevel.Information));
        Add(_espy = new MessageDescription("mscorlib.Globalization.ci_es-PY", 0x23450893, new ParameterlessText("Spanish (Paraguay)")).SetSeverity(MessageLevel.Information));
        Add(_essv = new MessageDescription("mscorlib.Globalization.ci_es-SV", 0x23450894, new ParameterlessText("Spanish (El Salvador)")).SetSeverity(MessageLevel.Information));
        Add(_esus = new MessageDescription("mscorlib.Globalization.ci_es-US", 0x23450895, new ParameterlessText("Spanish (United States)")).SetSeverity(MessageLevel.Information));
        Add(_esuy = new MessageDescription("mscorlib.Globalization.ci_es-UY", 0x23450896, new ParameterlessText("Spanish (Uruguay)")).SetSeverity(MessageLevel.Information));
        Add(_esve = new MessageDescription("mscorlib.Globalization.ci_es-VE", 0x23450897, new ParameterlessText("Spanish (Bolivarian Republic of Venezuela)")).SetSeverity(MessageLevel.Information));
        Add(_et = new MessageDescription("mscorlib.Globalization.ci_et", 0x23450898, new ParameterlessText("Estonian")).SetSeverity(MessageLevel.Information));
        Add(_etee = new MessageDescription("mscorlib.Globalization.ci_et-EE", 0x23450899, new ParameterlessText("Estonian (Estonia)")).SetSeverity(MessageLevel.Information));
        Add(_eu = new MessageDescription("mscorlib.Globalization.ci_eu", 0x2345089A, new ParameterlessText("Basque")).SetSeverity(MessageLevel.Information));
        Add(_eues = new MessageDescription("mscorlib.Globalization.ci_eu-ES", 0x2345089B, new ParameterlessText("Basque (Basque)")).SetSeverity(MessageLevel.Information));
        Add(_ewo = new MessageDescription("mscorlib.Globalization.ci_ewo", 0x2345089C, new ParameterlessText("Ewondo")).SetSeverity(MessageLevel.Information));
        Add(_ewocm = new MessageDescription("mscorlib.Globalization.ci_ewo-CM", 0x2345089D, new ParameterlessText("Ewondo (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_fa = new MessageDescription("mscorlib.Globalization.ci_fa", 0x2345089E, new ParameterlessText("Persian")).SetSeverity(MessageLevel.Information));
        Add(_faaf = new MessageDescription("mscorlib.Globalization.ci_fa-AF", 0x2345089F, new ParameterlessText("Persian (Afghanistan)")).SetSeverity(MessageLevel.Information));
        Add(_fair = new MessageDescription("mscorlib.Globalization.ci_fa-IR", 0x234508A0, new ParameterlessText("Persian (Iran)")).SetSeverity(MessageLevel.Information));
        Add(_ff = new MessageDescription("mscorlib.Globalization.ci_ff", 0x234508A1, new ParameterlessText("Fulah")).SetSeverity(MessageLevel.Information));
        Add(_ffcm = new MessageDescription("mscorlib.Globalization.ci_ff-CM", 0x234508A2, new ParameterlessText("Fulah (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_ffgn = new MessageDescription("mscorlib.Globalization.ci_ff-GN", 0x234508A3, new ParameterlessText("Fulah (Guinea)")).SetSeverity(MessageLevel.Information));
        Add(_fflatn = new MessageDescription("mscorlib.Globalization.ci_ff-Latn", 0x234508A4, new ParameterlessText("Fulah (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_fflatnsn = new MessageDescription("mscorlib.Globalization.ci_ff-Latn-SN", 0x234508A5, new ParameterlessText("Fulah (Latin, Senegal)")).SetSeverity(MessageLevel.Information));
        Add(_ffmr = new MessageDescription("mscorlib.Globalization.ci_ff-MR", 0x234508A6, new ParameterlessText("Fulah (Mauritania)")).SetSeverity(MessageLevel.Information));
        Add(_ffng = new MessageDescription("mscorlib.Globalization.ci_ff-NG", 0x234508A7, new ParameterlessText("Fulah (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_fi = new MessageDescription("mscorlib.Globalization.ci_fi", 0x234508A8, new ParameterlessText("Finnish")).SetSeverity(MessageLevel.Information));
        Add(_fifi = new MessageDescription("mscorlib.Globalization.ci_fi-FI", 0x234508A9, new ParameterlessText("Finnish (Finland)")).SetSeverity(MessageLevel.Information));
        Add(_fil = new MessageDescription("mscorlib.Globalization.ci_fil", 0x234508AA, new ParameterlessText("Filipino")).SetSeverity(MessageLevel.Information));
        Add(_filph = new MessageDescription("mscorlib.Globalization.ci_fil-PH", 0x234508AB, new ParameterlessText("Filipino (Philippines)")).SetSeverity(MessageLevel.Information));
        Add(_fo = new MessageDescription("mscorlib.Globalization.ci_fo", 0x234508AC, new ParameterlessText("Faroese")).SetSeverity(MessageLevel.Information));
        Add(_fofo = new MessageDescription("mscorlib.Globalization.ci_fo-FO", 0x234508AD, new ParameterlessText("Faroese (Faroe Islands)")).SetSeverity(MessageLevel.Information));
        Add(_fr = new MessageDescription("mscorlib.Globalization.ci_fr", 0x234508AE, new ParameterlessText("French")).SetSeverity(MessageLevel.Information));
        Add(_fr029 = new MessageDescription("mscorlib.Globalization.ci_fr-029", 0x234508AF, new ParameterlessText("French (Caribbean)")).SetSeverity(MessageLevel.Information));
        Add(_frbe = new MessageDescription("mscorlib.Globalization.ci_fr-BE", 0x234508B0, new ParameterlessText("French (Belgium)")).SetSeverity(MessageLevel.Information));
        Add(_frbf = new MessageDescription("mscorlib.Globalization.ci_fr-BF", 0x234508B1, new ParameterlessText("French (Burkina Faso)")).SetSeverity(MessageLevel.Information));
        Add(_frbi = new MessageDescription("mscorlib.Globalization.ci_fr-BI", 0x234508B2, new ParameterlessText("French (Burundi)")).SetSeverity(MessageLevel.Information));
        Add(_frbj = new MessageDescription("mscorlib.Globalization.ci_fr-BJ", 0x234508B3, new ParameterlessText("French (Benin)")).SetSeverity(MessageLevel.Information));
        Add(_frbl = new MessageDescription("mscorlib.Globalization.ci_fr-BL", 0x234508B4, new ParameterlessText("French (Saint Barthélemy)")).SetSeverity(MessageLevel.Information));
        Add(_frca = new MessageDescription("mscorlib.Globalization.ci_fr-CA", 0x234508B5, new ParameterlessText("French (Canada)")).SetSeverity(MessageLevel.Information));
        Add(_frcd = new MessageDescription("mscorlib.Globalization.ci_fr-CD", 0x234508B6, new ParameterlessText("French (Congo DRC)")).SetSeverity(MessageLevel.Information));
        Add(_frcf = new MessageDescription("mscorlib.Globalization.ci_fr-CF", 0x234508B7, new ParameterlessText("French (Central African Republic)")).SetSeverity(MessageLevel.Information));
        Add(_frcg = new MessageDescription("mscorlib.Globalization.ci_fr-CG", 0x234508B8, new ParameterlessText("French (Congo)")).SetSeverity(MessageLevel.Information));
        Add(_frch = new MessageDescription("mscorlib.Globalization.ci_fr-CH", 0x234508B9, new ParameterlessText("French (Switzerland)")).SetSeverity(MessageLevel.Information));
        Add(_frci = new MessageDescription("mscorlib.Globalization.ci_fr-CI", 0x234508BA, new ParameterlessText("French (Côte d’Ivoire)")).SetSeverity(MessageLevel.Information));
        Add(_frcm = new MessageDescription("mscorlib.Globalization.ci_fr-CM", 0x234508BB, new ParameterlessText("French (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_frdj = new MessageDescription("mscorlib.Globalization.ci_fr-DJ", 0x234508BC, new ParameterlessText("French (Djibouti)")).SetSeverity(MessageLevel.Information));
        Add(_frdz = new MessageDescription("mscorlib.Globalization.ci_fr-DZ", 0x234508BD, new ParameterlessText("French (Algeria)")).SetSeverity(MessageLevel.Information));
        Add(_frfr = new MessageDescription("mscorlib.Globalization.ci_fr-FR", 0x234508BE, new ParameterlessText("French (France)")).SetSeverity(MessageLevel.Information));
        Add(_frga = new MessageDescription("mscorlib.Globalization.ci_fr-GA", 0x234508BF, new ParameterlessText("French (Gabon)")).SetSeverity(MessageLevel.Information));
        Add(_frgf = new MessageDescription("mscorlib.Globalization.ci_fr-GF", 0x234508C0, new ParameterlessText("French (French Guiana)")).SetSeverity(MessageLevel.Information));
        Add(_frgn = new MessageDescription("mscorlib.Globalization.ci_fr-GN", 0x234508C1, new ParameterlessText("French (Guinea)")).SetSeverity(MessageLevel.Information));
        Add(_frgp = new MessageDescription("mscorlib.Globalization.ci_fr-GP", 0x234508C2, new ParameterlessText("French (Guadeloupe)")).SetSeverity(MessageLevel.Information));
        Add(_frgq = new MessageDescription("mscorlib.Globalization.ci_fr-GQ", 0x234508C3, new ParameterlessText("French (Equatorial Guinea)")).SetSeverity(MessageLevel.Information));
        Add(_frht = new MessageDescription("mscorlib.Globalization.ci_fr-HT", 0x234508C4, new ParameterlessText("French (Haiti)")).SetSeverity(MessageLevel.Information));
        Add(_frkm = new MessageDescription("mscorlib.Globalization.ci_fr-KM", 0x234508C5, new ParameterlessText("French (Comoros)")).SetSeverity(MessageLevel.Information));
        Add(_frlu = new MessageDescription("mscorlib.Globalization.ci_fr-LU", 0x234508C6, new ParameterlessText("French (Luxembourg)")).SetSeverity(MessageLevel.Information));
        Add(_frma = new MessageDescription("mscorlib.Globalization.ci_fr-MA", 0x234508C7, new ParameterlessText("French (Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_frmc = new MessageDescription("mscorlib.Globalization.ci_fr-MC", 0x234508C8, new ParameterlessText("French (Monaco)")).SetSeverity(MessageLevel.Information));
        Add(_frmf = new MessageDescription("mscorlib.Globalization.ci_fr-MF", 0x234508C9, new ParameterlessText("French (Saint Martin)")).SetSeverity(MessageLevel.Information));
        Add(_frmg = new MessageDescription("mscorlib.Globalization.ci_fr-MG", 0x234508CA, new ParameterlessText("French (Madagascar)")).SetSeverity(MessageLevel.Information));
        Add(_frml = new MessageDescription("mscorlib.Globalization.ci_fr-ML", 0x234508CB, new ParameterlessText("French (Mali)")).SetSeverity(MessageLevel.Information));
        Add(_frmq = new MessageDescription("mscorlib.Globalization.ci_fr-MQ", 0x234508CC, new ParameterlessText("French (Martinique)")).SetSeverity(MessageLevel.Information));
        Add(_frmr = new MessageDescription("mscorlib.Globalization.ci_fr-MR", 0x234508CD, new ParameterlessText("French (Mauritania)")).SetSeverity(MessageLevel.Information));
        Add(_frmu = new MessageDescription("mscorlib.Globalization.ci_fr-MU", 0x234508CE, new ParameterlessText("French (Mauritius)")).SetSeverity(MessageLevel.Information));
        Add(_frnc = new MessageDescription("mscorlib.Globalization.ci_fr-NC", 0x234508CF, new ParameterlessText("French (New Caledonia)")).SetSeverity(MessageLevel.Information));
        Add(_frne = new MessageDescription("mscorlib.Globalization.ci_fr-NE", 0x234508D0, new ParameterlessText("French (Niger)")).SetSeverity(MessageLevel.Information));
        Add(_frpf = new MessageDescription("mscorlib.Globalization.ci_fr-PF", 0x234508D1, new ParameterlessText("French (French Polynesia)")).SetSeverity(MessageLevel.Information));
        Add(_frpm = new MessageDescription("mscorlib.Globalization.ci_fr-PM", 0x234508D2, new ParameterlessText("French (Saint Pierre and Miquelon)")).SetSeverity(MessageLevel.Information));
        Add(_frre = new MessageDescription("mscorlib.Globalization.ci_fr-RE", 0x234508D3, new ParameterlessText("French (Reunion)")).SetSeverity(MessageLevel.Information));
        Add(_frrw = new MessageDescription("mscorlib.Globalization.ci_fr-RW", 0x234508D4, new ParameterlessText("French (Rwanda)")).SetSeverity(MessageLevel.Information));
        Add(_frsc = new MessageDescription("mscorlib.Globalization.ci_fr-SC", 0x234508D5, new ParameterlessText("French (Seychelles)")).SetSeverity(MessageLevel.Information));
        Add(_frsn = new MessageDescription("mscorlib.Globalization.ci_fr-SN", 0x234508D6, new ParameterlessText("French (Senegal)")).SetSeverity(MessageLevel.Information));
        Add(_frsy = new MessageDescription("mscorlib.Globalization.ci_fr-SY", 0x234508D7, new ParameterlessText("French (Syria)")).SetSeverity(MessageLevel.Information));
        Add(_frtd = new MessageDescription("mscorlib.Globalization.ci_fr-TD", 0x234508D8, new ParameterlessText("French (Chad)")).SetSeverity(MessageLevel.Information));
        Add(_frtg = new MessageDescription("mscorlib.Globalization.ci_fr-TG", 0x234508D9, new ParameterlessText("French (Togo)")).SetSeverity(MessageLevel.Information));
        Add(_frtn = new MessageDescription("mscorlib.Globalization.ci_fr-TN", 0x234508DA, new ParameterlessText("French (Tunisia)")).SetSeverity(MessageLevel.Information));
        Add(_frvu = new MessageDescription("mscorlib.Globalization.ci_fr-VU", 0x234508DB, new ParameterlessText("French (Vanuatu)")).SetSeverity(MessageLevel.Information));
        Add(_frwf = new MessageDescription("mscorlib.Globalization.ci_fr-WF", 0x234508DC, new ParameterlessText("French (Wallis and Futuna)")).SetSeverity(MessageLevel.Information));
        Add(_fryt = new MessageDescription("mscorlib.Globalization.ci_fr-YT", 0x234508DD, new ParameterlessText("French (Mayotte)")).SetSeverity(MessageLevel.Information));
        Add(_fur = new MessageDescription("mscorlib.Globalization.ci_fur", 0x234508DE, new ParameterlessText("Friulian")).SetSeverity(MessageLevel.Information));
        Add(_furit = new MessageDescription("mscorlib.Globalization.ci_fur-IT", 0x234508DF, new ParameterlessText("Friulian (Italy)")).SetSeverity(MessageLevel.Information));
        Add(_fy = new MessageDescription("mscorlib.Globalization.ci_fy", 0x234508E0, new ParameterlessText("Frisian")).SetSeverity(MessageLevel.Information));
        Add(_fynl = new MessageDescription("mscorlib.Globalization.ci_fy-NL", 0x234508E1, new ParameterlessText("Frisian (Netherlands)")).SetSeverity(MessageLevel.Information));
        Add(_ga = new MessageDescription("mscorlib.Globalization.ci_ga", 0x234508E2, new ParameterlessText("Irish")).SetSeverity(MessageLevel.Information));
        Add(_gaie = new MessageDescription("mscorlib.Globalization.ci_ga-IE", 0x234508E3, new ParameterlessText("Irish (Ireland)")).SetSeverity(MessageLevel.Information));
        Add(_gd = new MessageDescription("mscorlib.Globalization.ci_gd", 0x234508E4, new ParameterlessText("Scottish Gaelic")).SetSeverity(MessageLevel.Information));
        Add(_gdgb = new MessageDescription("mscorlib.Globalization.ci_gd-GB", 0x234508E5, new ParameterlessText("Scottish Gaelic (United Kingdom)")).SetSeverity(MessageLevel.Information));
        Add(_gl = new MessageDescription("mscorlib.Globalization.ci_gl", 0x234508E6, new ParameterlessText("Galician")).SetSeverity(MessageLevel.Information));
        Add(_gles = new MessageDescription("mscorlib.Globalization.ci_gl-ES", 0x234508E7, new ParameterlessText("Galician (Galician)")).SetSeverity(MessageLevel.Information));
        Add(_gn = new MessageDescription("mscorlib.Globalization.ci_gn", 0x234508E8, new ParameterlessText("Guarani")).SetSeverity(MessageLevel.Information));
        Add(_gnpy = new MessageDescription("mscorlib.Globalization.ci_gn-PY", 0x234508E9, new ParameterlessText("Guarani (Paraguay)")).SetSeverity(MessageLevel.Information));
        Add(_gsw = new MessageDescription("mscorlib.Globalization.ci_gsw", 0x234508EA, new ParameterlessText("Alsatian")).SetSeverity(MessageLevel.Information));
        Add(_gswch = new MessageDescription("mscorlib.Globalization.ci_gsw-CH", 0x234508EB, new ParameterlessText("Alsatian (Switzerland)")).SetSeverity(MessageLevel.Information));
        Add(_gswfr = new MessageDescription("mscorlib.Globalization.ci_gsw-FR", 0x234508EC, new ParameterlessText("Alsatian (France)")).SetSeverity(MessageLevel.Information));
        Add(_gswli = new MessageDescription("mscorlib.Globalization.ci_gsw-LI", 0x234508ED, new ParameterlessText("Alsatian (Liechtenstein)")).SetSeverity(MessageLevel.Information));
        Add(_gu = new MessageDescription("mscorlib.Globalization.ci_gu", 0x234508EE, new ParameterlessText("Gujarati")).SetSeverity(MessageLevel.Information));
        Add(_guin = new MessageDescription("mscorlib.Globalization.ci_gu-IN", 0x234508EF, new ParameterlessText("Gujarati (India)")).SetSeverity(MessageLevel.Information));
        Add(_guz = new MessageDescription("mscorlib.Globalization.ci_guz", 0x234508F0, new ParameterlessText("Gusii")).SetSeverity(MessageLevel.Information));
        Add(_guzke = new MessageDescription("mscorlib.Globalization.ci_guz-KE", 0x234508F1, new ParameterlessText("Gusii (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_gv = new MessageDescription("mscorlib.Globalization.ci_gv", 0x234508F2, new ParameterlessText("Manx")).SetSeverity(MessageLevel.Information));
        Add(_gvim = new MessageDescription("mscorlib.Globalization.ci_gv-IM", 0x234508F3, new ParameterlessText("Manx (Isle of Man)")).SetSeverity(MessageLevel.Information));
        Add(_ha = new MessageDescription("mscorlib.Globalization.ci_ha", 0x234508F4, new ParameterlessText("Hausa")).SetSeverity(MessageLevel.Information));
        Add(_halatn = new MessageDescription("mscorlib.Globalization.ci_ha-Latn", 0x234508F5, new ParameterlessText("Hausa (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_halatngh = new MessageDescription("mscorlib.Globalization.ci_ha-Latn-GH", 0x234508F6, new ParameterlessText("Hausa (Latin, Ghana)")).SetSeverity(MessageLevel.Information));
        Add(_halatnne = new MessageDescription("mscorlib.Globalization.ci_ha-Latn-NE", 0x234508F7, new ParameterlessText("Hausa (Latin, Niger)")).SetSeverity(MessageLevel.Information));
        Add(_halatnng = new MessageDescription("mscorlib.Globalization.ci_ha-Latn-NG", 0x234508F8, new ParameterlessText("Hausa (Latin, Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_haw = new MessageDescription("mscorlib.Globalization.ci_haw", 0x234508F9, new ParameterlessText("Hawaiian")).SetSeverity(MessageLevel.Information));
        Add(_hawus = new MessageDescription("mscorlib.Globalization.ci_haw-US", 0x234508FA, new ParameterlessText("Hawaiian (United States)")).SetSeverity(MessageLevel.Information));
        Add(_he = new MessageDescription("mscorlib.Globalization.ci_he", 0x234508FB, new ParameterlessText("Hebrew")).SetSeverity(MessageLevel.Information));
        Add(_heil = new MessageDescription("mscorlib.Globalization.ci_he-IL", 0x234508FC, new ParameterlessText("Hebrew (Israel)")).SetSeverity(MessageLevel.Information));
        Add(_hi = new MessageDescription("mscorlib.Globalization.ci_hi", 0x234508FD, new ParameterlessText("Hindi")).SetSeverity(MessageLevel.Information));
        Add(_hiin = new MessageDescription("mscorlib.Globalization.ci_hi-IN", 0x234508FE, new ParameterlessText("Hindi (India)")).SetSeverity(MessageLevel.Information));
        Add(_hr = new MessageDescription("mscorlib.Globalization.ci_hr", 0x234508FF, new ParameterlessText("Croatian")).SetSeverity(MessageLevel.Information));
        Add(_hrba = new MessageDescription("mscorlib.Globalization.ci_hr-BA", 0x23450900, new ParameterlessText("Croatian (Latin, Bosnia and Herzegovina)")).SetSeverity(MessageLevel.Information));
        Add(_hrhr = new MessageDescription("mscorlib.Globalization.ci_hr-HR", 0x23450901, new ParameterlessText("Croatian (Croatia)")).SetSeverity(MessageLevel.Information));
        Add(_hsb = new MessageDescription("mscorlib.Globalization.ci_hsb", 0x23450902, new ParameterlessText("Upper Sorbian")).SetSeverity(MessageLevel.Information));
        Add(_hsbde = new MessageDescription("mscorlib.Globalization.ci_hsb-DE", 0x23450903, new ParameterlessText("Upper Sorbian (Germany)")).SetSeverity(MessageLevel.Information));
        Add(_hu = new MessageDescription("mscorlib.Globalization.ci_hu", 0x23450904, new ParameterlessText("Hungarian")).SetSeverity(MessageLevel.Information));
        Add(_huhu = new MessageDescription("mscorlib.Globalization.ci_hu-HU", 0x23450905, new ParameterlessText("Hungarian (Hungary)")).SetSeverity(MessageLevel.Information));
        Add(_huhutechnl = new MessageDescription("mscorlib.Globalization.ci_hu-HU_technl", 0x23450906, new ParameterlessText("Hungarian (Hungary)")).SetSeverity(MessageLevel.Information));
        Add(_hy = new MessageDescription("mscorlib.Globalization.ci_hy", 0x23450907, new ParameterlessText("Armenian")).SetSeverity(MessageLevel.Information));
        Add(_hyam = new MessageDescription("mscorlib.Globalization.ci_hy-AM", 0x23450908, new ParameterlessText("Armenian (Armenia)")).SetSeverity(MessageLevel.Information));
        Add(_ia = new MessageDescription("mscorlib.Globalization.ci_ia", 0x23450909, new ParameterlessText("Interlingua")).SetSeverity(MessageLevel.Information));
        Add(_ia001 = new MessageDescription("mscorlib.Globalization.ci_ia-001", 0x2345090A, new ParameterlessText("Interlingua (World)")).SetSeverity(MessageLevel.Information));
        Add(_iafr = new MessageDescription("mscorlib.Globalization.ci_ia-FR", 0x2345090B, new ParameterlessText("Interlingua (France)")).SetSeverity(MessageLevel.Information));
        Add(_ibb = new MessageDescription("mscorlib.Globalization.ci_ibb", 0x2345090C, new ParameterlessText("Ibibio")).SetSeverity(MessageLevel.Information));
        Add(_ibbng = new MessageDescription("mscorlib.Globalization.ci_ibb-NG", 0x2345090D, new ParameterlessText("Ibibio (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_id = new MessageDescription("mscorlib.Globalization.ci_id", 0x2345090E, new ParameterlessText("Indonesian")).SetSeverity(MessageLevel.Information));
        Add(_idid = new MessageDescription("mscorlib.Globalization.ci_id-ID", 0x2345090F, new ParameterlessText("Indonesian (Indonesia)")).SetSeverity(MessageLevel.Information));
        Add(_ig = new MessageDescription("mscorlib.Globalization.ci_ig", 0x23450910, new ParameterlessText("Igbo")).SetSeverity(MessageLevel.Information));
        Add(_igng = new MessageDescription("mscorlib.Globalization.ci_ig-NG", 0x23450911, new ParameterlessText("Igbo (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_ii = new MessageDescription("mscorlib.Globalization.ci_ii", 0x23450912, new ParameterlessText("Yi")).SetSeverity(MessageLevel.Information));
        Add(_iicn = new MessageDescription("mscorlib.Globalization.ci_ii-CN", 0x23450913, new ParameterlessText("Yi (PRC)")).SetSeverity(MessageLevel.Information));
        Add(_is = new MessageDescription("mscorlib.Globalization.ci_is", 0x23450914, new ParameterlessText("Icelandic")).SetSeverity(MessageLevel.Information));
        Add(_isis = new MessageDescription("mscorlib.Globalization.ci_is-IS", 0x23450915, new ParameterlessText("Icelandic (Iceland)")).SetSeverity(MessageLevel.Information));
        Add(_it = new MessageDescription("mscorlib.Globalization.ci_it", 0x23450916, new ParameterlessText("Italian")).SetSeverity(MessageLevel.Information));
        Add(_itch = new MessageDescription("mscorlib.Globalization.ci_it-CH", 0x23450917, new ParameterlessText("Italian (Switzerland)")).SetSeverity(MessageLevel.Information));
        Add(_itit = new MessageDescription("mscorlib.Globalization.ci_it-IT", 0x23450918, new ParameterlessText("Italian (Italy)")).SetSeverity(MessageLevel.Information));
        Add(_itsm = new MessageDescription("mscorlib.Globalization.ci_it-SM", 0x23450919, new ParameterlessText("Italian (San Marino)")).SetSeverity(MessageLevel.Information));
        Add(_iu = new MessageDescription("mscorlib.Globalization.ci_iu", 0x2345091A, new ParameterlessText("Inuktitut")).SetSeverity(MessageLevel.Information));
        Add(_iucans = new MessageDescription("mscorlib.Globalization.ci_iu-Cans", 0x2345091B, new ParameterlessText("Inuktitut (Syllabics)")).SetSeverity(MessageLevel.Information));
        Add(_iucansca = new MessageDescription("mscorlib.Globalization.ci_iu-Cans-CA", 0x2345091C, new ParameterlessText("Inuktitut (Syllabics, Canada)")).SetSeverity(MessageLevel.Information));
        Add(_iulatn = new MessageDescription("mscorlib.Globalization.ci_iu-Latn", 0x2345091D, new ParameterlessText("Inuktitut (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_iulatnca = new MessageDescription("mscorlib.Globalization.ci_iu-Latn-CA", 0x2345091E, new ParameterlessText("Inuktitut (Latin, Canada)")).SetSeverity(MessageLevel.Information));
        Add(_ja = new MessageDescription("mscorlib.Globalization.ci_ja", 0x2345091F, new ParameterlessText("Japanese")).SetSeverity(MessageLevel.Information));
        Add(_jajp = new MessageDescription("mscorlib.Globalization.ci_ja-JP", 0x23450920, new ParameterlessText("Japanese (Japan)")).SetSeverity(MessageLevel.Information));
        Add(_jajpradstr = new MessageDescription("mscorlib.Globalization.ci_ja-JP_radstr", 0x23450921, new ParameterlessText("Japanese (Japan)")).SetSeverity(MessageLevel.Information));
        Add(_jgo = new MessageDescription("mscorlib.Globalization.ci_jgo", 0x23450922, new ParameterlessText("Ngomba")).SetSeverity(MessageLevel.Information));
        Add(_jgocm = new MessageDescription("mscorlib.Globalization.ci_jgo-CM", 0x23450923, new ParameterlessText("Ngomba (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_jmc = new MessageDescription("mscorlib.Globalization.ci_jmc", 0x23450924, new ParameterlessText("Machame")).SetSeverity(MessageLevel.Information));
        Add(_jmctz = new MessageDescription("mscorlib.Globalization.ci_jmc-TZ", 0x23450925, new ParameterlessText("Machame (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_jv = new MessageDescription("mscorlib.Globalization.ci_jv", 0x23450926, new ParameterlessText("Javanese")).SetSeverity(MessageLevel.Information));
        Add(_jvjava = new MessageDescription("mscorlib.Globalization.ci_jv-Java", 0x23450927, new ParameterlessText("Javanese (Javanese)")).SetSeverity(MessageLevel.Information));
        Add(_jvjavaid = new MessageDescription("mscorlib.Globalization.ci_jv-Java-ID", 0x23450928, new ParameterlessText("Javanese (Javanese, Indonesia)")).SetSeverity(MessageLevel.Information));
        Add(_jvlatn = new MessageDescription("mscorlib.Globalization.ci_jv-Latn", 0x23450929, new ParameterlessText("Javanese")).SetSeverity(MessageLevel.Information));
        Add(_jvlatnid = new MessageDescription("mscorlib.Globalization.ci_jv-Latn-ID", 0x2345092A, new ParameterlessText("Javanese (Indonesia)")).SetSeverity(MessageLevel.Information));
        Add(_ka = new MessageDescription("mscorlib.Globalization.ci_ka", 0x2345092B, new ParameterlessText("Georgian")).SetSeverity(MessageLevel.Information));
        Add(_kage = new MessageDescription("mscorlib.Globalization.ci_ka-GE", 0x2345092C, new ParameterlessText("Georgian (Georgia)")).SetSeverity(MessageLevel.Information));
        Add(_kagemodern = new MessageDescription("mscorlib.Globalization.ci_ka-GE_modern", 0x2345092D, new ParameterlessText("Georgian (Georgia)")).SetSeverity(MessageLevel.Information));
        Add(_kab = new MessageDescription("mscorlib.Globalization.ci_kab", 0x2345092E, new ParameterlessText("Kabyle")).SetSeverity(MessageLevel.Information));
        Add(_kabdz = new MessageDescription("mscorlib.Globalization.ci_kab-DZ", 0x2345092F, new ParameterlessText("Kabyle (Algeria)")).SetSeverity(MessageLevel.Information));
        Add(_kam = new MessageDescription("mscorlib.Globalization.ci_kam", 0x23450930, new ParameterlessText("Kamba")).SetSeverity(MessageLevel.Information));
        Add(_kamke = new MessageDescription("mscorlib.Globalization.ci_kam-KE", 0x23450931, new ParameterlessText("Kamba (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_kde = new MessageDescription("mscorlib.Globalization.ci_kde", 0x23450932, new ParameterlessText("Makonde")).SetSeverity(MessageLevel.Information));
        Add(_kdetz = new MessageDescription("mscorlib.Globalization.ci_kde-TZ", 0x23450933, new ParameterlessText("Makonde (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_kea = new MessageDescription("mscorlib.Globalization.ci_kea", 0x23450934, new ParameterlessText("Kabuverdianu")).SetSeverity(MessageLevel.Information));
        Add(_keacv = new MessageDescription("mscorlib.Globalization.ci_kea-CV", 0x23450935, new ParameterlessText("Kabuverdianu (Cabo Verde)")).SetSeverity(MessageLevel.Information));
        Add(_khq = new MessageDescription("mscorlib.Globalization.ci_khq", 0x23450936, new ParameterlessText("Koyra Chiini")).SetSeverity(MessageLevel.Information));
        Add(_khqml = new MessageDescription("mscorlib.Globalization.ci_khq-ML", 0x23450937, new ParameterlessText("Koyra Chiini (Mali)")).SetSeverity(MessageLevel.Information));
        Add(_ki = new MessageDescription("mscorlib.Globalization.ci_ki", 0x23450938, new ParameterlessText("Kikuyu")).SetSeverity(MessageLevel.Information));
        Add(_kike = new MessageDescription("mscorlib.Globalization.ci_ki-KE", 0x23450939, new ParameterlessText("Kikuyu (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_kk = new MessageDescription("mscorlib.Globalization.ci_kk", 0x2345093A, new ParameterlessText("Kazakh")).SetSeverity(MessageLevel.Information));
        Add(_kkkz = new MessageDescription("mscorlib.Globalization.ci_kk-KZ", 0x2345093B, new ParameterlessText("Kazakh (Kazakhstan)")).SetSeverity(MessageLevel.Information));
        Add(_kkj = new MessageDescription("mscorlib.Globalization.ci_kkj", 0x2345093C, new ParameterlessText("Kako")).SetSeverity(MessageLevel.Information));
        Add(_kkjcm = new MessageDescription("mscorlib.Globalization.ci_kkj-CM", 0x2345093D, new ParameterlessText("Kako (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_kl = new MessageDescription("mscorlib.Globalization.ci_kl", 0x2345093E, new ParameterlessText("Greenlandic")).SetSeverity(MessageLevel.Information));
        Add(_klgl = new MessageDescription("mscorlib.Globalization.ci_kl-GL", 0x2345093F, new ParameterlessText("Greenlandic (Greenland)")).SetSeverity(MessageLevel.Information));
        Add(_kln = new MessageDescription("mscorlib.Globalization.ci_kln", 0x23450940, new ParameterlessText("Kalenjin")).SetSeverity(MessageLevel.Information));
        Add(_klnke = new MessageDescription("mscorlib.Globalization.ci_kln-KE", 0x23450941, new ParameterlessText("Kalenjin (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_km = new MessageDescription("mscorlib.Globalization.ci_km", 0x23450942, new ParameterlessText("Khmer")).SetSeverity(MessageLevel.Information));
        Add(_kmkh = new MessageDescription("mscorlib.Globalization.ci_km-KH", 0x23450943, new ParameterlessText("Khmer (Cambodia)")).SetSeverity(MessageLevel.Information));
        Add(_kn = new MessageDescription("mscorlib.Globalization.ci_kn", 0x23450944, new ParameterlessText("Kannada")).SetSeverity(MessageLevel.Information));
        Add(_knin = new MessageDescription("mscorlib.Globalization.ci_kn-IN", 0x23450945, new ParameterlessText("Kannada (India)")).SetSeverity(MessageLevel.Information));
        Add(_ko = new MessageDescription("mscorlib.Globalization.ci_ko", 0x23450946, new ParameterlessText("Korean")).SetSeverity(MessageLevel.Information));
        Add(_kokr = new MessageDescription("mscorlib.Globalization.ci_ko-KR", 0x23450947, new ParameterlessText("Korean (Korea)")).SetSeverity(MessageLevel.Information));
        Add(_kok = new MessageDescription("mscorlib.Globalization.ci_kok", 0x23450948, new ParameterlessText("Konkani")).SetSeverity(MessageLevel.Information));
        Add(_kokin = new MessageDescription("mscorlib.Globalization.ci_kok-IN", 0x23450949, new ParameterlessText("Konkani (India)")).SetSeverity(MessageLevel.Information));
        Add(_kr = new MessageDescription("mscorlib.Globalization.ci_kr", 0x2345094A, new ParameterlessText("Kanuri")).SetSeverity(MessageLevel.Information));
        Add(_krng = new MessageDescription("mscorlib.Globalization.ci_kr-NG", 0x2345094B, new ParameterlessText("Kanuri (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_ks = new MessageDescription("mscorlib.Globalization.ci_ks", 0x2345094C, new ParameterlessText("Kashmiri")).SetSeverity(MessageLevel.Information));
        Add(_ksarab = new MessageDescription("mscorlib.Globalization.ci_ks-Arab", 0x2345094D, new ParameterlessText("Kashmiri (Perso-Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_ksarabin = new MessageDescription("mscorlib.Globalization.ci_ks-Arab-IN", 0x2345094E, new ParameterlessText("Kashmiri (Perso-Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_ksdeva = new MessageDescription("mscorlib.Globalization.ci_ks-Deva", 0x2345094F, new ParameterlessText("Kashmiri (Devanagari)")).SetSeverity(MessageLevel.Information));
        Add(_ksdevain = new MessageDescription("mscorlib.Globalization.ci_ks-Deva-IN", 0x23450950, new ParameterlessText("Kashmiri (Devanagari, India)")).SetSeverity(MessageLevel.Information));
        Add(_ksb = new MessageDescription("mscorlib.Globalization.ci_ksb", 0x23450951, new ParameterlessText("Shambala")).SetSeverity(MessageLevel.Information));
        Add(_ksbtz = new MessageDescription("mscorlib.Globalization.ci_ksb-TZ", 0x23450952, new ParameterlessText("Shambala (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_ksf = new MessageDescription("mscorlib.Globalization.ci_ksf", 0x23450953, new ParameterlessText("Bafia")).SetSeverity(MessageLevel.Information));
        Add(_ksfcm = new MessageDescription("mscorlib.Globalization.ci_ksf-CM", 0x23450954, new ParameterlessText("Bafia (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_ksh = new MessageDescription("mscorlib.Globalization.ci_ksh", 0x23450955, new ParameterlessText("Colognian")).SetSeverity(MessageLevel.Information));
        Add(_kshde = new MessageDescription("mscorlib.Globalization.ci_ksh-DE", 0x23450956, new ParameterlessText("Ripuarian (Germany)")).SetSeverity(MessageLevel.Information));
        Add(_ku = new MessageDescription("mscorlib.Globalization.ci_ku", 0x23450957, new ParameterlessText("Central Kurdish")).SetSeverity(MessageLevel.Information));
        Add(_kuarab = new MessageDescription("mscorlib.Globalization.ci_ku-Arab", 0x23450958, new ParameterlessText("Central Kurdish (Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_kuarabiq = new MessageDescription("mscorlib.Globalization.ci_ku-Arab-IQ", 0x23450959, new ParameterlessText("Central Kurdish (Iraq)")).SetSeverity(MessageLevel.Information));
        Add(_kw = new MessageDescription("mscorlib.Globalization.ci_kw", 0x2345095A, new ParameterlessText("Cornish")).SetSeverity(MessageLevel.Information));
        Add(_kwgb = new MessageDescription("mscorlib.Globalization.ci_kw-GB", 0x2345095B, new ParameterlessText("Cornish (United Kingdom)")).SetSeverity(MessageLevel.Information));
        Add(_ky = new MessageDescription("mscorlib.Globalization.ci_ky", 0x2345095C, new ParameterlessText("Kyrgyz")).SetSeverity(MessageLevel.Information));
        Add(_kykg = new MessageDescription("mscorlib.Globalization.ci_ky-KG", 0x2345095D, new ParameterlessText("Kyrgyz (Kyrgyzstan)")).SetSeverity(MessageLevel.Information));
        Add(_la = new MessageDescription("mscorlib.Globalization.ci_la", 0x2345095E, new ParameterlessText("Latin")).SetSeverity(MessageLevel.Information));
        Add(_la001 = new MessageDescription("mscorlib.Globalization.ci_la-001", 0x2345095F, new ParameterlessText("Latin (World)")).SetSeverity(MessageLevel.Information));
        Add(_lag = new MessageDescription("mscorlib.Globalization.ci_lag", 0x23450960, new ParameterlessText("Langi")).SetSeverity(MessageLevel.Information));
        Add(_lagtz = new MessageDescription("mscorlib.Globalization.ci_lag-TZ", 0x23450961, new ParameterlessText("Langi (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_lb = new MessageDescription("mscorlib.Globalization.ci_lb", 0x23450962, new ParameterlessText("Luxembourgish")).SetSeverity(MessageLevel.Information));
        Add(_lblu = new MessageDescription("mscorlib.Globalization.ci_lb-LU", 0x23450963, new ParameterlessText("Luxembourgish (Luxembourg)")).SetSeverity(MessageLevel.Information));
        Add(_lg = new MessageDescription("mscorlib.Globalization.ci_lg", 0x23450964, new ParameterlessText("Ganda")).SetSeverity(MessageLevel.Information));
        Add(_lgug = new MessageDescription("mscorlib.Globalization.ci_lg-UG", 0x23450965, new ParameterlessText("Ganda (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_lkt = new MessageDescription("mscorlib.Globalization.ci_lkt", 0x23450966, new ParameterlessText("Lakota")).SetSeverity(MessageLevel.Information));
        Add(_lktus = new MessageDescription("mscorlib.Globalization.ci_lkt-US", 0x23450967, new ParameterlessText("Lakota (United States)")).SetSeverity(MessageLevel.Information));
        Add(_ln = new MessageDescription("mscorlib.Globalization.ci_ln", 0x23450968, new ParameterlessText("Lingala")).SetSeverity(MessageLevel.Information));
        Add(_lnao = new MessageDescription("mscorlib.Globalization.ci_ln-AO", 0x23450969, new ParameterlessText("Lingala (Angola)")).SetSeverity(MessageLevel.Information));
        Add(_lncd = new MessageDescription("mscorlib.Globalization.ci_ln-CD", 0x2345096A, new ParameterlessText("Lingala (Congo DRC)")).SetSeverity(MessageLevel.Information));
        Add(_lncf = new MessageDescription("mscorlib.Globalization.ci_ln-CF", 0x2345096B, new ParameterlessText("Lingala (Central African Republic)")).SetSeverity(MessageLevel.Information));
        Add(_lncg = new MessageDescription("mscorlib.Globalization.ci_ln-CG", 0x2345096C, new ParameterlessText("Lingala (Congo)")).SetSeverity(MessageLevel.Information));
        Add(_lo = new MessageDescription("mscorlib.Globalization.ci_lo", 0x2345096D, new ParameterlessText("Lao")).SetSeverity(MessageLevel.Information));
        Add(_lola = new MessageDescription("mscorlib.Globalization.ci_lo-LA", 0x2345096E, new ParameterlessText("Lao (Lao P.D.R.)")).SetSeverity(MessageLevel.Information));
        Add(_lt = new MessageDescription("mscorlib.Globalization.ci_lt", 0x2345096F, new ParameterlessText("Lithuanian")).SetSeverity(MessageLevel.Information));
        Add(_ltlt = new MessageDescription("mscorlib.Globalization.ci_lt-LT", 0x23450970, new ParameterlessText("Lithuanian (Lithuania)")).SetSeverity(MessageLevel.Information));
        Add(_lu = new MessageDescription("mscorlib.Globalization.ci_lu", 0x23450971, new ParameterlessText("Luba-Katanga")).SetSeverity(MessageLevel.Information));
        Add(_lucd = new MessageDescription("mscorlib.Globalization.ci_lu-CD", 0x23450972, new ParameterlessText("Luba-Katanga (Congo DRC)")).SetSeverity(MessageLevel.Information));
        Add(_luo = new MessageDescription("mscorlib.Globalization.ci_luo", 0x23450973, new ParameterlessText("Luo")).SetSeverity(MessageLevel.Information));
        Add(_luoke = new MessageDescription("mscorlib.Globalization.ci_luo-KE", 0x23450974, new ParameterlessText("Luo (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_luy = new MessageDescription("mscorlib.Globalization.ci_luy", 0x23450975, new ParameterlessText("Luyia")).SetSeverity(MessageLevel.Information));
        Add(_luyke = new MessageDescription("mscorlib.Globalization.ci_luy-KE", 0x23450976, new ParameterlessText("Luyia (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_lv = new MessageDescription("mscorlib.Globalization.ci_lv", 0x23450977, new ParameterlessText("Latvian")).SetSeverity(MessageLevel.Information));
        Add(_lvlv = new MessageDescription("mscorlib.Globalization.ci_lv-LV", 0x23450978, new ParameterlessText("Latvian (Latvia)")).SetSeverity(MessageLevel.Information));
        Add(_mas = new MessageDescription("mscorlib.Globalization.ci_mas", 0x23450979, new ParameterlessText("Masai")).SetSeverity(MessageLevel.Information));
        Add(_maske = new MessageDescription("mscorlib.Globalization.ci_mas-KE", 0x2345097A, new ParameterlessText("Masai (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_mastz = new MessageDescription("mscorlib.Globalization.ci_mas-TZ", 0x2345097B, new ParameterlessText("Masai (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_mer = new MessageDescription("mscorlib.Globalization.ci_mer", 0x2345097C, new ParameterlessText("Meru")).SetSeverity(MessageLevel.Information));
        Add(_merke = new MessageDescription("mscorlib.Globalization.ci_mer-KE", 0x2345097D, new ParameterlessText("Meru (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_mfe = new MessageDescription("mscorlib.Globalization.ci_mfe", 0x2345097E, new ParameterlessText("Morisyen")).SetSeverity(MessageLevel.Information));
        Add(_mfemu = new MessageDescription("mscorlib.Globalization.ci_mfe-MU", 0x2345097F, new ParameterlessText("Morisyen (Mauritius)")).SetSeverity(MessageLevel.Information));
        Add(_mg = new MessageDescription("mscorlib.Globalization.ci_mg", 0x23450980, new ParameterlessText("Malagasy")).SetSeverity(MessageLevel.Information));
        Add(_mgmg = new MessageDescription("mscorlib.Globalization.ci_mg-MG", 0x23450981, new ParameterlessText("Malagasy (Madagascar)")).SetSeverity(MessageLevel.Information));
        Add(_mgh = new MessageDescription("mscorlib.Globalization.ci_mgh", 0x23450982, new ParameterlessText("Makhuwa-Meetto")).SetSeverity(MessageLevel.Information));
        Add(_mghmz = new MessageDescription("mscorlib.Globalization.ci_mgh-MZ", 0x23450983, new ParameterlessText("Makhuwa-Meetto (Mozambique)")).SetSeverity(MessageLevel.Information));
        Add(_mgo = new MessageDescription("mscorlib.Globalization.ci_mgo", 0x23450984, new ParameterlessText("Meta'")).SetSeverity(MessageLevel.Information));
        Add(_mgocm = new MessageDescription("mscorlib.Globalization.ci_mgo-CM", 0x23450985, new ParameterlessText("Meta' (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_mi = new MessageDescription("mscorlib.Globalization.ci_mi", 0x23450986, new ParameterlessText("Maori")).SetSeverity(MessageLevel.Information));
        Add(_minz = new MessageDescription("mscorlib.Globalization.ci_mi-NZ", 0x23450987, new ParameterlessText("Maori (New Zealand)")).SetSeverity(MessageLevel.Information));
        Add(_mk = new MessageDescription("mscorlib.Globalization.ci_mk", 0x23450988, new ParameterlessText("Macedonian")).SetSeverity(MessageLevel.Information));
        Add(_mkmk = new MessageDescription("mscorlib.Globalization.ci_mk-MK", 0x23450989, new ParameterlessText("Macedonian (North Macedonia)")).SetSeverity(MessageLevel.Information));
        Add(_ml = new MessageDescription("mscorlib.Globalization.ci_ml", 0x2345098A, new ParameterlessText("Malayalam")).SetSeverity(MessageLevel.Information));
        Add(_mlin = new MessageDescription("mscorlib.Globalization.ci_ml-IN", 0x2345098B, new ParameterlessText("Malayalam (India)")).SetSeverity(MessageLevel.Information));
        Add(_mn = new MessageDescription("mscorlib.Globalization.ci_mn", 0x2345098C, new ParameterlessText("Mongolian")).SetSeverity(MessageLevel.Information));
        Add(_mncyrl = new MessageDescription("mscorlib.Globalization.ci_mn-Cyrl", 0x2345098D, new ParameterlessText("Mongolian (Cyrillic)")).SetSeverity(MessageLevel.Information));
        Add(_mnmn = new MessageDescription("mscorlib.Globalization.ci_mn-MN", 0x2345098E, new ParameterlessText("Mongolian (Cyrillic, Mongolia)")).SetSeverity(MessageLevel.Information));
        Add(_mnmong = new MessageDescription("mscorlib.Globalization.ci_mn-Mong", 0x2345098F, new ParameterlessText("Mongolian (Traditional Mongolian)")).SetSeverity(MessageLevel.Information));
        Add(_mnmongcn = new MessageDescription("mscorlib.Globalization.ci_mn-Mong-CN", 0x23450990, new ParameterlessText("Mongolian (Traditional Mongolian, PRC)")).SetSeverity(MessageLevel.Information));
        Add(_mnmongmn = new MessageDescription("mscorlib.Globalization.ci_mn-Mong-MN", 0x23450991, new ParameterlessText("Mongolian (Traditional Mongolian, Mongolia)")).SetSeverity(MessageLevel.Information));
        Add(_mni = new MessageDescription("mscorlib.Globalization.ci_mni", 0x23450992, new ParameterlessText("Manipuri")).SetSeverity(MessageLevel.Information));
        Add(_mniin = new MessageDescription("mscorlib.Globalization.ci_mni-IN", 0x23450993, new ParameterlessText("Manipuri (India)")).SetSeverity(MessageLevel.Information));
        Add(_moh = new MessageDescription("mscorlib.Globalization.ci_moh", 0x23450994, new ParameterlessText("Mohawk")).SetSeverity(MessageLevel.Information));
        Add(_mohca = new MessageDescription("mscorlib.Globalization.ci_moh-CA", 0x23450995, new ParameterlessText("Mohawk (Mohawk)")).SetSeverity(MessageLevel.Information));
        Add(_mr = new MessageDescription("mscorlib.Globalization.ci_mr", 0x23450996, new ParameterlessText("Marathi")).SetSeverity(MessageLevel.Information));
        Add(_mrin = new MessageDescription("mscorlib.Globalization.ci_mr-IN", 0x23450997, new ParameterlessText("Marathi (India)")).SetSeverity(MessageLevel.Information));
        Add(_ms = new MessageDescription("mscorlib.Globalization.ci_ms", 0x23450998, new ParameterlessText("Malay")).SetSeverity(MessageLevel.Information));
        Add(_msbn = new MessageDescription("mscorlib.Globalization.ci_ms-BN", 0x23450999, new ParameterlessText("Malay (Brunei Darussalam)")).SetSeverity(MessageLevel.Information));
        Add(_msmy = new MessageDescription("mscorlib.Globalization.ci_ms-MY", 0x2345099A, new ParameterlessText("Malay (Malaysia)")).SetSeverity(MessageLevel.Information));
        Add(_mssg = new MessageDescription("mscorlib.Globalization.ci_ms-SG", 0x2345099B, new ParameterlessText("Malay (Latin, Singapore)")).SetSeverity(MessageLevel.Information));
        Add(_mt = new MessageDescription("mscorlib.Globalization.ci_mt", 0x2345099C, new ParameterlessText("Maltese")).SetSeverity(MessageLevel.Information));
        Add(_mtmt = new MessageDescription("mscorlib.Globalization.ci_mt-MT", 0x2345099D, new ParameterlessText("Maltese (Malta)")).SetSeverity(MessageLevel.Information));
        Add(_mua = new MessageDescription("mscorlib.Globalization.ci_mua", 0x2345099E, new ParameterlessText("Mundang")).SetSeverity(MessageLevel.Information));
        Add(_muacm = new MessageDescription("mscorlib.Globalization.ci_mua-CM", 0x2345099F, new ParameterlessText("Mundang (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_my = new MessageDescription("mscorlib.Globalization.ci_my", 0x234509A0, new ParameterlessText("Burmese")).SetSeverity(MessageLevel.Information));
        Add(_mymm = new MessageDescription("mscorlib.Globalization.ci_my-MM", 0x234509A1, new ParameterlessText("Burmese (Myanmar)")).SetSeverity(MessageLevel.Information));
        Add(_naq = new MessageDescription("mscorlib.Globalization.ci_naq", 0x234509A2, new ParameterlessText("Nama")).SetSeverity(MessageLevel.Information));
        Add(_naqna = new MessageDescription("mscorlib.Globalization.ci_naq-NA", 0x234509A3, new ParameterlessText("Nama (Namibia)")).SetSeverity(MessageLevel.Information));
        Add(_nb = new MessageDescription("mscorlib.Globalization.ci_nb", 0x234509A4, new ParameterlessText("Norwegian (Bokmål)")).SetSeverity(MessageLevel.Information));
        Add(_nbno = new MessageDescription("mscorlib.Globalization.ci_nb-NO", 0x234509A5, new ParameterlessText("Norwegian, Bokmål (Norway)")).SetSeverity(MessageLevel.Information));
        Add(_nbsj = new MessageDescription("mscorlib.Globalization.ci_nb-SJ", 0x234509A6, new ParameterlessText("Norwegian, Bokmål (Svalbard and Jan Mayen)")).SetSeverity(MessageLevel.Information));
        Add(_nd = new MessageDescription("mscorlib.Globalization.ci_nd", 0x234509A7, new ParameterlessText("North Ndebele")).SetSeverity(MessageLevel.Information));
        Add(_ndzw = new MessageDescription("mscorlib.Globalization.ci_nd-ZW", 0x234509A8, new ParameterlessText("North Ndebele (Zimbabwe)")).SetSeverity(MessageLevel.Information));
        Add(_ne = new MessageDescription("mscorlib.Globalization.ci_ne", 0x234509A9, new ParameterlessText("Nepali")).SetSeverity(MessageLevel.Information));
        Add(_nein = new MessageDescription("mscorlib.Globalization.ci_ne-IN", 0x234509AA, new ParameterlessText("Nepali (India)")).SetSeverity(MessageLevel.Information));
        Add(_nenp = new MessageDescription("mscorlib.Globalization.ci_ne-NP", 0x234509AB, new ParameterlessText("Nepali (Nepal)")).SetSeverity(MessageLevel.Information));
        Add(_nl = new MessageDescription("mscorlib.Globalization.ci_nl", 0x234509AC, new ParameterlessText("Dutch")).SetSeverity(MessageLevel.Information));
        Add(_nlaw = new MessageDescription("mscorlib.Globalization.ci_nl-AW", 0x234509AD, new ParameterlessText("Dutch (Aruba)")).SetSeverity(MessageLevel.Information));
        Add(_nlbe = new MessageDescription("mscorlib.Globalization.ci_nl-BE", 0x234509AE, new ParameterlessText("Dutch (Belgium)")).SetSeverity(MessageLevel.Information));
        Add(_nlbq = new MessageDescription("mscorlib.Globalization.ci_nl-BQ", 0x234509AF, new ParameterlessText("Dutch (Bonaire, Sint Eustatius and Saba)")).SetSeverity(MessageLevel.Information));
        Add(_nlcw = new MessageDescription("mscorlib.Globalization.ci_nl-CW", 0x234509B0, new ParameterlessText("Dutch (Curaçao)")).SetSeverity(MessageLevel.Information));
        Add(_nlnl = new MessageDescription("mscorlib.Globalization.ci_nl-NL", 0x234509B1, new ParameterlessText("Dutch (Netherlands)")).SetSeverity(MessageLevel.Information));
        Add(_nlsr = new MessageDescription("mscorlib.Globalization.ci_nl-SR", 0x234509B2, new ParameterlessText("Dutch (Suriname)")).SetSeverity(MessageLevel.Information));
        Add(_nlsx = new MessageDescription("mscorlib.Globalization.ci_nl-SX", 0x234509B3, new ParameterlessText("Dutch (Sint Maarten)")).SetSeverity(MessageLevel.Information));
        Add(_nmg = new MessageDescription("mscorlib.Globalization.ci_nmg", 0x234509B4, new ParameterlessText("Kwasio")).SetSeverity(MessageLevel.Information));
        Add(_nmgcm = new MessageDescription("mscorlib.Globalization.ci_nmg-CM", 0x234509B5, new ParameterlessText("Kwasio (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_nn = new MessageDescription("mscorlib.Globalization.ci_nn", 0x234509B6, new ParameterlessText("Norwegian (Nynorsk)")).SetSeverity(MessageLevel.Information));
        Add(_nnno = new MessageDescription("mscorlib.Globalization.ci_nn-NO", 0x234509B7, new ParameterlessText("Norwegian, Nynorsk (Norway)")).SetSeverity(MessageLevel.Information));
        Add(_nnh = new MessageDescription("mscorlib.Globalization.ci_nnh", 0x234509B8, new ParameterlessText("Ngiemboon")).SetSeverity(MessageLevel.Information));
        Add(_nnhcm = new MessageDescription("mscorlib.Globalization.ci_nnh-CM", 0x234509B9, new ParameterlessText("Ngiemboon (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_no = new MessageDescription("mscorlib.Globalization.ci_no", 0x234509BA, new ParameterlessText("Norwegian")).SetSeverity(MessageLevel.Information));
        Add(_nqo = new MessageDescription("mscorlib.Globalization.ci_nqo", 0x234509BB, new ParameterlessText("N'ko")).SetSeverity(MessageLevel.Information));
        Add(_nqogn = new MessageDescription("mscorlib.Globalization.ci_nqo-GN", 0x234509BC, new ParameterlessText("N'ko (Guinea)")).SetSeverity(MessageLevel.Information));
        Add(_nr = new MessageDescription("mscorlib.Globalization.ci_nr", 0x234509BD, new ParameterlessText("South Ndebele")).SetSeverity(MessageLevel.Information));
        Add(_nrza = new MessageDescription("mscorlib.Globalization.ci_nr-ZA", 0x234509BE, new ParameterlessText("South Ndebele (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_nso = new MessageDescription("mscorlib.Globalization.ci_nso", 0x234509BF, new ParameterlessText("Sesotho sa Leboa")).SetSeverity(MessageLevel.Information));
        Add(_nsoza = new MessageDescription("mscorlib.Globalization.ci_nso-ZA", 0x234509C0, new ParameterlessText("Sesotho sa Leboa (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_nus = new MessageDescription("mscorlib.Globalization.ci_nus", 0x234509C1, new ParameterlessText("Nuer")).SetSeverity(MessageLevel.Information));
        Add(_nussd = new MessageDescription("mscorlib.Globalization.ci_nus-SD", 0x234509C2, new ParameterlessText("Nuer (Sudan)")).SetSeverity(MessageLevel.Information));
        Add(_nusss = new MessageDescription("mscorlib.Globalization.ci_nus-SS", 0x234509C3, new ParameterlessText("Nuer (South Sudan)")).SetSeverity(MessageLevel.Information));
        Add(_nyn = new MessageDescription("mscorlib.Globalization.ci_nyn", 0x234509C4, new ParameterlessText("Nyankole")).SetSeverity(MessageLevel.Information));
        Add(_nynug = new MessageDescription("mscorlib.Globalization.ci_nyn-UG", 0x234509C5, new ParameterlessText("Nyankole (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_oc = new MessageDescription("mscorlib.Globalization.ci_oc", 0x234509C6, new ParameterlessText("Occitan")).SetSeverity(MessageLevel.Information));
        Add(_ocfr = new MessageDescription("mscorlib.Globalization.ci_oc-FR", 0x234509C7, new ParameterlessText("Occitan (France)")).SetSeverity(MessageLevel.Information));
        Add(_om = new MessageDescription("mscorlib.Globalization.ci_om", 0x234509C8, new ParameterlessText("Oromo")).SetSeverity(MessageLevel.Information));
        Add(_omet = new MessageDescription("mscorlib.Globalization.ci_om-ET", 0x234509C9, new ParameterlessText("Oromo (Ethiopia)")).SetSeverity(MessageLevel.Information));
        Add(_omke = new MessageDescription("mscorlib.Globalization.ci_om-KE", 0x234509CA, new ParameterlessText("Oromo (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_or = new MessageDescription("mscorlib.Globalization.ci_or", 0x234509CB, new ParameterlessText("Odia")).SetSeverity(MessageLevel.Information));
        Add(_orin = new MessageDescription("mscorlib.Globalization.ci_or-IN", 0x234509CC, new ParameterlessText("Odia (India)")).SetSeverity(MessageLevel.Information));
        Add(_os = new MessageDescription("mscorlib.Globalization.ci_os", 0x234509CD, new ParameterlessText("Ossetic")).SetSeverity(MessageLevel.Information));
        Add(_osge = new MessageDescription("mscorlib.Globalization.ci_os-GE", 0x234509CE, new ParameterlessText("Ossetian (Cyrillic, Georgia)")).SetSeverity(MessageLevel.Information));
        Add(_osru = new MessageDescription("mscorlib.Globalization.ci_os-RU", 0x234509CF, new ParameterlessText("Ossetian (Cyrillic, Russia)")).SetSeverity(MessageLevel.Information));
        Add(_pa = new MessageDescription("mscorlib.Globalization.ci_pa", 0x234509D0, new ParameterlessText("Punjabi")).SetSeverity(MessageLevel.Information));
        Add(_paarab = new MessageDescription("mscorlib.Globalization.ci_pa-Arab", 0x234509D1, new ParameterlessText("Punjabi (Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_paarabpk = new MessageDescription("mscorlib.Globalization.ci_pa-Arab-PK", 0x234509D2, new ParameterlessText("Punjabi (Islamic Republic of Pakistan)")).SetSeverity(MessageLevel.Information));
        Add(_pain = new MessageDescription("mscorlib.Globalization.ci_pa-IN", 0x234509D3, new ParameterlessText("Punjabi (India)")).SetSeverity(MessageLevel.Information));
        Add(_pap = new MessageDescription("mscorlib.Globalization.ci_pap", 0x234509D4, new ParameterlessText("Papiamento")).SetSeverity(MessageLevel.Information));
        Add(_pap029 = new MessageDescription("mscorlib.Globalization.ci_pap-029", 0x234509D5, new ParameterlessText("Papiamento (Caribbean)")).SetSeverity(MessageLevel.Information));
        Add(_pl = new MessageDescription("mscorlib.Globalization.ci_pl", 0x234509D6, new ParameterlessText("Polish")).SetSeverity(MessageLevel.Information));
        Add(_plpl = new MessageDescription("mscorlib.Globalization.ci_pl-PL", 0x234509D7, new ParameterlessText("Polish (Poland)")).SetSeverity(MessageLevel.Information));
        Add(_prs = new MessageDescription("mscorlib.Globalization.ci_prs", 0x234509D8, new ParameterlessText("Dari")).SetSeverity(MessageLevel.Information));
        Add(_prsaf = new MessageDescription("mscorlib.Globalization.ci_prs-AF", 0x234509D9, new ParameterlessText("Dari (Afghanistan)")).SetSeverity(MessageLevel.Information));
        Add(_ps = new MessageDescription("mscorlib.Globalization.ci_ps", 0x234509DA, new ParameterlessText("Pashto")).SetSeverity(MessageLevel.Information));
        Add(_psaf = new MessageDescription("mscorlib.Globalization.ci_ps-AF", 0x234509DB, new ParameterlessText("Pashto (Afghanistan)")).SetSeverity(MessageLevel.Information));
        Add(_pt = new MessageDescription("mscorlib.Globalization.ci_pt", 0x234509DC, new ParameterlessText("Portuguese")).SetSeverity(MessageLevel.Information));
        Add(_ptao = new MessageDescription("mscorlib.Globalization.ci_pt-AO", 0x234509DD, new ParameterlessText("Portuguese (Angola)")).SetSeverity(MessageLevel.Information));
        Add(_ptbr = new MessageDescription("mscorlib.Globalization.ci_pt-BR", 0x234509DE, new ParameterlessText("Portuguese (Brazil)")).SetSeverity(MessageLevel.Information));
        Add(_ptcv = new MessageDescription("mscorlib.Globalization.ci_pt-CV", 0x234509DF, new ParameterlessText("Portuguese (Cabo Verde)")).SetSeverity(MessageLevel.Information));
        Add(_ptgw = new MessageDescription("mscorlib.Globalization.ci_pt-GW", 0x234509E0, new ParameterlessText("Portuguese (Guinea-Bissau)")).SetSeverity(MessageLevel.Information));
        Add(_ptmo = new MessageDescription("mscorlib.Globalization.ci_pt-MO", 0x234509E1, new ParameterlessText("Portuguese (Macao SAR)")).SetSeverity(MessageLevel.Information));
        Add(_ptmz = new MessageDescription("mscorlib.Globalization.ci_pt-MZ", 0x234509E2, new ParameterlessText("Portuguese (Mozambique)")).SetSeverity(MessageLevel.Information));
        Add(_ptpt = new MessageDescription("mscorlib.Globalization.ci_pt-PT", 0x234509E3, new ParameterlessText("Portuguese (Portugal)")).SetSeverity(MessageLevel.Information));
        Add(_ptst = new MessageDescription("mscorlib.Globalization.ci_pt-ST", 0x234509E4, new ParameterlessText("Portuguese (São Tomé and Príncipe)")).SetSeverity(MessageLevel.Information));
        Add(_pttl = new MessageDescription("mscorlib.Globalization.ci_pt-TL", 0x234509E5, new ParameterlessText("Portuguese (Timor-Leste)")).SetSeverity(MessageLevel.Information));
        Add(_qpsploc = new MessageDescription("mscorlib.Globalization.ci_qps-ploc", 0x234509E6, new ParameterlessText("Pseudo Language (Pseudo)")).SetSeverity(MessageLevel.Information));
        Add(_qpsploca = new MessageDescription("mscorlib.Globalization.ci_qps-ploca", 0x234509E7, new ParameterlessText("Pseudo Language (Pseudo Asia)")).SetSeverity(MessageLevel.Information));
        Add(_qpsplocm = new MessageDescription("mscorlib.Globalization.ci_qps-plocm", 0x234509E8, new ParameterlessText("Pseudo Language (Pseudo Mirrored)")).SetSeverity(MessageLevel.Information));
        Add(_qu = new MessageDescription("mscorlib.Globalization.ci_qu", 0x234509E9, new ParameterlessText("Quechua")).SetSeverity(MessageLevel.Information));
        Add(_qubo = new MessageDescription("mscorlib.Globalization.ci_qu-BO", 0x234509EA, new ParameterlessText("Quechua (Bolivia)")).SetSeverity(MessageLevel.Information));
        Add(_quec = new MessageDescription("mscorlib.Globalization.ci_qu-EC", 0x234509EB, new ParameterlessText("Quechua (Ecuador)")).SetSeverity(MessageLevel.Information));
        Add(_qupe = new MessageDescription("mscorlib.Globalization.ci_qu-PE", 0x234509EC, new ParameterlessText("Quechua (Peru)")).SetSeverity(MessageLevel.Information));
        Add(_quc = new MessageDescription("mscorlib.Globalization.ci_quc", 0x234509ED, new ParameterlessText("K'iche'")).SetSeverity(MessageLevel.Information));
        Add(_quclatn = new MessageDescription("mscorlib.Globalization.ci_quc-Latn", 0x234509EE, new ParameterlessText("K'iche'")).SetSeverity(MessageLevel.Information));
        Add(_quclatngt = new MessageDescription("mscorlib.Globalization.ci_quc-Latn-GT", 0x234509EF, new ParameterlessText("K'iche' (Guatemala)")).SetSeverity(MessageLevel.Information));
        Add(_qut = new MessageDescription("mscorlib.Globalization.ci_qut", 0x234509F0, new ParameterlessText("K'iche")).SetSeverity(MessageLevel.Information));
        Add(_qutgt = new MessageDescription("mscorlib.Globalization.ci_qut-GT", 0x234509F1, new ParameterlessText("K'iche (Guatemala)")).SetSeverity(MessageLevel.Information));
        Add(_quz = new MessageDescription("mscorlib.Globalization.ci_quz", 0x234509F2, new ParameterlessText("Quechua")).SetSeverity(MessageLevel.Information));
        Add(_quzbo = new MessageDescription("mscorlib.Globalization.ci_quz-BO", 0x234509F3, new ParameterlessText("Quechua (Bolivia)")).SetSeverity(MessageLevel.Information));
        Add(_quzec = new MessageDescription("mscorlib.Globalization.ci_quz-EC", 0x234509F4, new ParameterlessText("Quechua (Ecuador)")).SetSeverity(MessageLevel.Information));
        Add(_quzpe = new MessageDescription("mscorlib.Globalization.ci_quz-PE", 0x234509F5, new ParameterlessText("Quechua (Peru)")).SetSeverity(MessageLevel.Information));
        Add(_rm = new MessageDescription("mscorlib.Globalization.ci_rm", 0x234509F6, new ParameterlessText("Romansh")).SetSeverity(MessageLevel.Information));
        Add(_rmch = new MessageDescription("mscorlib.Globalization.ci_rm-CH", 0x234509F7, new ParameterlessText("Romansh (Switzerland)")).SetSeverity(MessageLevel.Information));
        Add(_rn = new MessageDescription("mscorlib.Globalization.ci_rn", 0x234509F8, new ParameterlessText("Rundi")).SetSeverity(MessageLevel.Information));
        Add(_rnbi = new MessageDescription("mscorlib.Globalization.ci_rn-BI", 0x234509F9, new ParameterlessText("Rundi (Burundi)")).SetSeverity(MessageLevel.Information));
        Add(_ro = new MessageDescription("mscorlib.Globalization.ci_ro", 0x234509FA, new ParameterlessText("Romanian")).SetSeverity(MessageLevel.Information));
        Add(_romd = new MessageDescription("mscorlib.Globalization.ci_ro-MD", 0x234509FB, new ParameterlessText("Romanian (Moldova)")).SetSeverity(MessageLevel.Information));
        Add(_roro = new MessageDescription("mscorlib.Globalization.ci_ro-RO", 0x234509FC, new ParameterlessText("Romanian (Romania)")).SetSeverity(MessageLevel.Information));
        Add(_rof = new MessageDescription("mscorlib.Globalization.ci_rof", 0x234509FD, new ParameterlessText("Rombo")).SetSeverity(MessageLevel.Information));
        Add(_roftz = new MessageDescription("mscorlib.Globalization.ci_rof-TZ", 0x234509FE, new ParameterlessText("Rombo (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_ru = new MessageDescription("mscorlib.Globalization.ci_ru", 0x234509FF, new ParameterlessText("Russian")).SetSeverity(MessageLevel.Information));
        Add(_ruby = new MessageDescription("mscorlib.Globalization.ci_ru-BY", 0x23450A00, new ParameterlessText("Russian (Belarus)")).SetSeverity(MessageLevel.Information));
        Add(_rukg = new MessageDescription("mscorlib.Globalization.ci_ru-KG", 0x23450A01, new ParameterlessText("Russian (Kyrgyzstan)")).SetSeverity(MessageLevel.Information));
        Add(_rukz = new MessageDescription("mscorlib.Globalization.ci_ru-KZ", 0x23450A02, new ParameterlessText("Russian (Kazakhstan)")).SetSeverity(MessageLevel.Information));
        Add(_rumd = new MessageDescription("mscorlib.Globalization.ci_ru-MD", 0x23450A03, new ParameterlessText("Russian (Moldova)")).SetSeverity(MessageLevel.Information));
        Add(_ruru = new MessageDescription("mscorlib.Globalization.ci_ru-RU", 0x23450A04, new ParameterlessText("Russian (Russia)")).SetSeverity(MessageLevel.Information));
        Add(_ruua = new MessageDescription("mscorlib.Globalization.ci_ru-UA", 0x23450A05, new ParameterlessText("Russian (Ukraine)")).SetSeverity(MessageLevel.Information));
        Add(_rw = new MessageDescription("mscorlib.Globalization.ci_rw", 0x23450A06, new ParameterlessText("Kinyarwanda")).SetSeverity(MessageLevel.Information));
        Add(_rwrw = new MessageDescription("mscorlib.Globalization.ci_rw-RW", 0x23450A07, new ParameterlessText("Kinyarwanda (Rwanda)")).SetSeverity(MessageLevel.Information));
        Add(_rwk = new MessageDescription("mscorlib.Globalization.ci_rwk", 0x23450A08, new ParameterlessText("Rwa")).SetSeverity(MessageLevel.Information));
        Add(_rwktz = new MessageDescription("mscorlib.Globalization.ci_rwk-TZ", 0x23450A09, new ParameterlessText("Rwa (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_sa = new MessageDescription("mscorlib.Globalization.ci_sa", 0x23450A0A, new ParameterlessText("Sanskrit")).SetSeverity(MessageLevel.Information));
        Add(_sain = new MessageDescription("mscorlib.Globalization.ci_sa-IN", 0x23450A0B, new ParameterlessText("Sanskrit (India)")).SetSeverity(MessageLevel.Information));
        Add(_sah = new MessageDescription("mscorlib.Globalization.ci_sah", 0x23450A0C, new ParameterlessText("Sakha")).SetSeverity(MessageLevel.Information));
        Add(_sahru = new MessageDescription("mscorlib.Globalization.ci_sah-RU", 0x23450A0D, new ParameterlessText("Sakha (Russia)")).SetSeverity(MessageLevel.Information));
        Add(_saq = new MessageDescription("mscorlib.Globalization.ci_saq", 0x23450A0E, new ParameterlessText("Samburu")).SetSeverity(MessageLevel.Information));
        Add(_saqke = new MessageDescription("mscorlib.Globalization.ci_saq-KE", 0x23450A0F, new ParameterlessText("Samburu (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_sbp = new MessageDescription("mscorlib.Globalization.ci_sbp", 0x23450A10, new ParameterlessText("Sangu")).SetSeverity(MessageLevel.Information));
        Add(_sbptz = new MessageDescription("mscorlib.Globalization.ci_sbp-TZ", 0x23450A11, new ParameterlessText("Sangu (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_sd = new MessageDescription("mscorlib.Globalization.ci_sd", 0x23450A12, new ParameterlessText("Sindhi")).SetSeverity(MessageLevel.Information));
        Add(_sdarab = new MessageDescription("mscorlib.Globalization.ci_sd-Arab", 0x23450A13, new ParameterlessText("Sindhi (Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_sdarabpk = new MessageDescription("mscorlib.Globalization.ci_sd-Arab-PK", 0x23450A14, new ParameterlessText("Sindhi (Islamic Republic of Pakistan)")).SetSeverity(MessageLevel.Information));
        Add(_sddeva = new MessageDescription("mscorlib.Globalization.ci_sd-Deva", 0x23450A15, new ParameterlessText("Sindhi (Devanagari)")).SetSeverity(MessageLevel.Information));
        Add(_sddevain = new MessageDescription("mscorlib.Globalization.ci_sd-Deva-IN", 0x23450A16, new ParameterlessText("Sindhi (Devanagari, India)")).SetSeverity(MessageLevel.Information));
        Add(_se = new MessageDescription("mscorlib.Globalization.ci_se", 0x23450A17, new ParameterlessText("Sami (Northern)")).SetSeverity(MessageLevel.Information));
        Add(_sefi = new MessageDescription("mscorlib.Globalization.ci_se-FI", 0x23450A18, new ParameterlessText("Sami, Northern (Finland)")).SetSeverity(MessageLevel.Information));
        Add(_seno = new MessageDescription("mscorlib.Globalization.ci_se-NO", 0x23450A19, new ParameterlessText("Sami, Northern (Norway)")).SetSeverity(MessageLevel.Information));
        Add(_sese = new MessageDescription("mscorlib.Globalization.ci_se-SE", 0x23450A1A, new ParameterlessText("Sami, Northern (Sweden)")).SetSeverity(MessageLevel.Information));
        Add(_seh = new MessageDescription("mscorlib.Globalization.ci_seh", 0x23450A1B, new ParameterlessText("Sena")).SetSeverity(MessageLevel.Information));
        Add(_sehmz = new MessageDescription("mscorlib.Globalization.ci_seh-MZ", 0x23450A1C, new ParameterlessText("Sena (Mozambique)")).SetSeverity(MessageLevel.Information));
        Add(_ses = new MessageDescription("mscorlib.Globalization.ci_ses", 0x23450A1D, new ParameterlessText("Koyraboro Senni")).SetSeverity(MessageLevel.Information));
        Add(_sesml = new MessageDescription("mscorlib.Globalization.ci_ses-ML", 0x23450A1E, new ParameterlessText("Koyraboro Senni (Mali)")).SetSeverity(MessageLevel.Information));
        Add(_sg = new MessageDescription("mscorlib.Globalization.ci_sg", 0x23450A1F, new ParameterlessText("Sango")).SetSeverity(MessageLevel.Information));
        Add(_sgcf = new MessageDescription("mscorlib.Globalization.ci_sg-CF", 0x23450A20, new ParameterlessText("Sango (Central African Republic)")).SetSeverity(MessageLevel.Information));
        Add(_shi = new MessageDescription("mscorlib.Globalization.ci_shi", 0x23450A21, new ParameterlessText("Tachelhit")).SetSeverity(MessageLevel.Information));
        Add(_shilatn = new MessageDescription("mscorlib.Globalization.ci_shi-Latn", 0x23450A22, new ParameterlessText("Tachelhit (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_shilatnma = new MessageDescription("mscorlib.Globalization.ci_shi-Latn-MA", 0x23450A23, new ParameterlessText("Tachelhit (Latin, Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_shitfng = new MessageDescription("mscorlib.Globalization.ci_shi-Tfng", 0x23450A24, new ParameterlessText("Tachelhit (Tifinagh)")).SetSeverity(MessageLevel.Information));
        Add(_shitfngma = new MessageDescription("mscorlib.Globalization.ci_shi-Tfng-MA", 0x23450A25, new ParameterlessText("Tachelhit (Tifinagh, Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_si = new MessageDescription("mscorlib.Globalization.ci_si", 0x23450A26, new ParameterlessText("Sinhala")).SetSeverity(MessageLevel.Information));
        Add(_silk = new MessageDescription("mscorlib.Globalization.ci_si-LK", 0x23450A27, new ParameterlessText("Sinhala (Sri Lanka)")).SetSeverity(MessageLevel.Information));
        Add(_sk = new MessageDescription("mscorlib.Globalization.ci_sk", 0x23450A28, new ParameterlessText("Slovak")).SetSeverity(MessageLevel.Information));
        Add(_sksk = new MessageDescription("mscorlib.Globalization.ci_sk-SK", 0x23450A29, new ParameterlessText("Slovak (Slovakia)")).SetSeverity(MessageLevel.Information));
        Add(_sl = new MessageDescription("mscorlib.Globalization.ci_sl", 0x23450A2A, new ParameterlessText("Slovenian")).SetSeverity(MessageLevel.Information));
        Add(_slsi = new MessageDescription("mscorlib.Globalization.ci_sl-SI", 0x23450A2B, new ParameterlessText("Slovenian (Slovenia)")).SetSeverity(MessageLevel.Information));
        Add(_sma = new MessageDescription("mscorlib.Globalization.ci_sma", 0x23450A2C, new ParameterlessText("Sami (Southern)")).SetSeverity(MessageLevel.Information));
        Add(_smano = new MessageDescription("mscorlib.Globalization.ci_sma-NO", 0x23450A2D, new ParameterlessText("Sami, Southern (Norway)")).SetSeverity(MessageLevel.Information));
        Add(_smase = new MessageDescription("mscorlib.Globalization.ci_sma-SE", 0x23450A2E, new ParameterlessText("Sami, Southern (Sweden)")).SetSeverity(MessageLevel.Information));
        Add(_smj = new MessageDescription("mscorlib.Globalization.ci_smj", 0x23450A2F, new ParameterlessText("Sami (Lule)")).SetSeverity(MessageLevel.Information));
        Add(_smjno = new MessageDescription("mscorlib.Globalization.ci_smj-NO", 0x23450A30, new ParameterlessText("Sami, Lule (Norway)")).SetSeverity(MessageLevel.Information));
        Add(_smjse = new MessageDescription("mscorlib.Globalization.ci_smj-SE", 0x23450A31, new ParameterlessText("Sami, Lule (Sweden)")).SetSeverity(MessageLevel.Information));
        Add(_smn = new MessageDescription("mscorlib.Globalization.ci_smn", 0x23450A32, new ParameterlessText("Sami (Inari)")).SetSeverity(MessageLevel.Information));
        Add(_smnfi = new MessageDescription("mscorlib.Globalization.ci_smn-FI", 0x23450A33, new ParameterlessText("Sami, Inari (Finland)")).SetSeverity(MessageLevel.Information));
        Add(_sms = new MessageDescription("mscorlib.Globalization.ci_sms", 0x23450A34, new ParameterlessText("Sami (Skolt)")).SetSeverity(MessageLevel.Information));
        Add(_smsfi = new MessageDescription("mscorlib.Globalization.ci_sms-FI", 0x23450A35, new ParameterlessText("Sami, Skolt (Finland)")).SetSeverity(MessageLevel.Information));
        Add(_sn = new MessageDescription("mscorlib.Globalization.ci_sn", 0x23450A36, new ParameterlessText("Shona")).SetSeverity(MessageLevel.Information));
        Add(_snlatn = new MessageDescription("mscorlib.Globalization.ci_sn-Latn", 0x23450A37, new ParameterlessText("Shona (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_snlatnzw = new MessageDescription("mscorlib.Globalization.ci_sn-Latn-ZW", 0x23450A38, new ParameterlessText("Shona (Latin, Zimbabwe)")).SetSeverity(MessageLevel.Information));
        Add(_so = new MessageDescription("mscorlib.Globalization.ci_so", 0x23450A39, new ParameterlessText("Somali")).SetSeverity(MessageLevel.Information));
        Add(_sodj = new MessageDescription("mscorlib.Globalization.ci_so-DJ", 0x23450A3A, new ParameterlessText("Somali (Djibouti)")).SetSeverity(MessageLevel.Information));
        Add(_soet = new MessageDescription("mscorlib.Globalization.ci_so-ET", 0x23450A3B, new ParameterlessText("Somali (Ethiopia)")).SetSeverity(MessageLevel.Information));
        Add(_soke = new MessageDescription("mscorlib.Globalization.ci_so-KE", 0x23450A3C, new ParameterlessText("Somali (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_soso = new MessageDescription("mscorlib.Globalization.ci_so-SO", 0x23450A3D, new ParameterlessText("Somali (Somalia)")).SetSeverity(MessageLevel.Information));
        Add(_sq = new MessageDescription("mscorlib.Globalization.ci_sq", 0x23450A3E, new ParameterlessText("Albanian")).SetSeverity(MessageLevel.Information));
        Add(_sqal = new MessageDescription("mscorlib.Globalization.ci_sq-AL", 0x23450A3F, new ParameterlessText("Albanian (Albania)")).SetSeverity(MessageLevel.Information));
        Add(_sqmk = new MessageDescription("mscorlib.Globalization.ci_sq-MK", 0x23450A40, new ParameterlessText("Albanian (North Macedonia)")).SetSeverity(MessageLevel.Information));
        Add(_sqxk = new MessageDescription("mscorlib.Globalization.ci_sq-XK", 0x23450A41, new ParameterlessText("Albanian (Kosovo)")).SetSeverity(MessageLevel.Information));
        Add(_sr = new MessageDescription("mscorlib.Globalization.ci_sr", 0x23450A43, new ParameterlessText("Serbian")).SetSeverity(MessageLevel.Information));
        Add(_srcyrl = new MessageDescription("mscorlib.Globalization.ci_sr-Cyrl", 0x23450A44, new ParameterlessText("Serbian (Cyrillic)")).SetSeverity(MessageLevel.Information));
        Add(_srcyrlba = new MessageDescription("mscorlib.Globalization.ci_sr-Cyrl-BA", 0x23450A45, new ParameterlessText("Serbian (Cyrillic, Bosnia and Herzegovina)")).SetSeverity(MessageLevel.Information));
        Add(_srcyrlcs = new MessageDescription("mscorlib.Globalization.ci_sr-Cyrl-CS", 0x23450A46, new ParameterlessText("Serbian (Cyrillic, Serbia and Montenegro (Former))")).SetSeverity(MessageLevel.Information));
        Add(_srcyrlme = new MessageDescription("mscorlib.Globalization.ci_sr-Cyrl-ME", 0x23450A47, new ParameterlessText("Serbian (Cyrillic, Montenegro)")).SetSeverity(MessageLevel.Information));
        Add(_srcyrlrs = new MessageDescription("mscorlib.Globalization.ci_sr-Cyrl-RS", 0x23450A48, new ParameterlessText("Serbian (Cyrillic, Serbia)")).SetSeverity(MessageLevel.Information));
        Add(_srcyrlxk = new MessageDescription("mscorlib.Globalization.ci_sr-Cyrl-XK", 0x23450A42, new ParameterlessText("Serbian (Cyrillic, Kosovo)")).SetSeverity(MessageLevel.Information));
        Add(_srlatn = new MessageDescription("mscorlib.Globalization.ci_sr-Latn", 0x23450A49, new ParameterlessText("Serbian (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_srlatnba = new MessageDescription("mscorlib.Globalization.ci_sr-Latn-BA", 0x23450A4A, new ParameterlessText("Serbian (Latin, Bosnia and Herzegovina)")).SetSeverity(MessageLevel.Information));
        Add(_srlatncs = new MessageDescription("mscorlib.Globalization.ci_sr-Latn-CS", 0x23450A4B, new ParameterlessText("Serbian (Latin, Serbia and Montenegro (Former))")).SetSeverity(MessageLevel.Information));
        Add(_srlatnme = new MessageDescription("mscorlib.Globalization.ci_sr-Latn-ME", 0x23450A4C, new ParameterlessText("Serbian (Latin, Montenegro)")).SetSeverity(MessageLevel.Information));
        Add(_srlatnrs = new MessageDescription("mscorlib.Globalization.ci_sr-Latn-RS", 0x23450A4D, new ParameterlessText("Serbian (Latin, Serbia)")).SetSeverity(MessageLevel.Information));
        Add(_srlatnxk = new MessageDescription("mscorlib.Globalization.ci_sr-Latn-XK", 0x23450A4E, new ParameterlessText("Serbian (Latin, Kosovo)")).SetSeverity(MessageLevel.Information));
        Add(_ss = new MessageDescription("mscorlib.Globalization.ci_ss", 0x23450A4F, new ParameterlessText("Swati")).SetSeverity(MessageLevel.Information));
        Add(_sssz = new MessageDescription("mscorlib.Globalization.ci_ss-SZ", 0x23450A50, new ParameterlessText("Swati (Swaziland)")).SetSeverity(MessageLevel.Information));
        Add(_ssza = new MessageDescription("mscorlib.Globalization.ci_ss-ZA", 0x23450A51, new ParameterlessText("Swati (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_ssy = new MessageDescription("mscorlib.Globalization.ci_ssy", 0x23450A52, new ParameterlessText("Saho")).SetSeverity(MessageLevel.Information));
        Add(_ssyer = new MessageDescription("mscorlib.Globalization.ci_ssy-ER", 0x23450A53, new ParameterlessText("Saho (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_st = new MessageDescription("mscorlib.Globalization.ci_st", 0x23450A54, new ParameterlessText("Southern Sotho")).SetSeverity(MessageLevel.Information));
        Add(_stls = new MessageDescription("mscorlib.Globalization.ci_st-LS", 0x23450A55, new ParameterlessText("Sesotho (Lesotho)")).SetSeverity(MessageLevel.Information));
        Add(_stza = new MessageDescription("mscorlib.Globalization.ci_st-ZA", 0x23450A56, new ParameterlessText("Southern Sotho (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_sv = new MessageDescription("mscorlib.Globalization.ci_sv", 0x23450A57, new ParameterlessText("Swedish")).SetSeverity(MessageLevel.Information));
        Add(_svax = new MessageDescription("mscorlib.Globalization.ci_sv-AX", 0x23450A58, new ParameterlessText("Swedish (Åland Islands)")).SetSeverity(MessageLevel.Information));
        Add(_svfi = new MessageDescription("mscorlib.Globalization.ci_sv-FI", 0x23450A59, new ParameterlessText("Swedish (Finland)")).SetSeverity(MessageLevel.Information));
        Add(_svse = new MessageDescription("mscorlib.Globalization.ci_sv-SE", 0x23450A5A, new ParameterlessText("Swedish (Sweden)")).SetSeverity(MessageLevel.Information));
        Add(_sw = new MessageDescription("mscorlib.Globalization.ci_sw", 0x23450A5B, new ParameterlessText("Kiswahili")).SetSeverity(MessageLevel.Information));
        Add(_swcd = new MessageDescription("mscorlib.Globalization.ci_sw-CD", 0x23450A5C, new ParameterlessText("Kiswahili (Congo DRC)")).SetSeverity(MessageLevel.Information));
        Add(_swke = new MessageDescription("mscorlib.Globalization.ci_sw-KE", 0x23450A5D, new ParameterlessText("Kiswahili (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_swtz = new MessageDescription("mscorlib.Globalization.ci_sw-TZ", 0x23450A5E, new ParameterlessText("Kiswahili (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_swug = new MessageDescription("mscorlib.Globalization.ci_sw-UG", 0x23450A5F, new ParameterlessText("Kiswahili (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_swc = new MessageDescription("mscorlib.Globalization.ci_swc", 0x23450A60, new ParameterlessText("Congo Swahili")).SetSeverity(MessageLevel.Information));
        Add(_swccd = new MessageDescription("mscorlib.Globalization.ci_swc-CD", 0x23450A61, new ParameterlessText("Congo Swahili (Congo DRC)")).SetSeverity(MessageLevel.Information));
        Add(_syr = new MessageDescription("mscorlib.Globalization.ci_syr", 0x23450A62, new ParameterlessText("Syriac")).SetSeverity(MessageLevel.Information));
        Add(_syrsy = new MessageDescription("mscorlib.Globalization.ci_syr-SY", 0x23450A63, new ParameterlessText("Syriac (Syria)")).SetSeverity(MessageLevel.Information));
        Add(_ta = new MessageDescription("mscorlib.Globalization.ci_ta", 0x23450A64, new ParameterlessText("Tamil")).SetSeverity(MessageLevel.Information));
        Add(_tain = new MessageDescription("mscorlib.Globalization.ci_ta-IN", 0x23450A65, new ParameterlessText("Tamil (India)")).SetSeverity(MessageLevel.Information));
        Add(_talk = new MessageDescription("mscorlib.Globalization.ci_ta-LK", 0x23450A66, new ParameterlessText("Tamil (Sri Lanka)")).SetSeverity(MessageLevel.Information));
        Add(_tamy = new MessageDescription("mscorlib.Globalization.ci_ta-MY", 0x23450A67, new ParameterlessText("Tamil (Malaysia)")).SetSeverity(MessageLevel.Information));
        Add(_tasg = new MessageDescription("mscorlib.Globalization.ci_ta-SG", 0x23450A68, new ParameterlessText("Tamil (Singapore)")).SetSeverity(MessageLevel.Information));
        Add(_te = new MessageDescription("mscorlib.Globalization.ci_te", 0x23450A69, new ParameterlessText("Telugu")).SetSeverity(MessageLevel.Information));
        Add(_tein = new MessageDescription("mscorlib.Globalization.ci_te-IN", 0x23450A6A, new ParameterlessText("Telugu (India)")).SetSeverity(MessageLevel.Information));
        Add(_teo = new MessageDescription("mscorlib.Globalization.ci_teo", 0x23450A6B, new ParameterlessText("Teso")).SetSeverity(MessageLevel.Information));
        Add(_teoke = new MessageDescription("mscorlib.Globalization.ci_teo-KE", 0x23450A6C, new ParameterlessText("Teso (Kenya)")).SetSeverity(MessageLevel.Information));
        Add(_teoug = new MessageDescription("mscorlib.Globalization.ci_teo-UG", 0x23450A6D, new ParameterlessText("Teso (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_tg = new MessageDescription("mscorlib.Globalization.ci_tg", 0x23450A6E, new ParameterlessText("Tajik")).SetSeverity(MessageLevel.Information));
        Add(_tgcyrl = new MessageDescription("mscorlib.Globalization.ci_tg-Cyrl", 0x23450A6F, new ParameterlessText("Tajik (Cyrillic)")).SetSeverity(MessageLevel.Information));
        Add(_tgcyrltj = new MessageDescription("mscorlib.Globalization.ci_tg-Cyrl-TJ", 0x23450A70, new ParameterlessText("Tajik (Cyrillic, Tajikistan)")).SetSeverity(MessageLevel.Information));
        Add(_th = new MessageDescription("mscorlib.Globalization.ci_th", 0x23450A71, new ParameterlessText("Thai")).SetSeverity(MessageLevel.Information));
        Add(_thth = new MessageDescription("mscorlib.Globalization.ci_th-TH", 0x23450A72, new ParameterlessText("Thai (Thailand)")).SetSeverity(MessageLevel.Information));
        Add(_ti = new MessageDescription("mscorlib.Globalization.ci_ti", 0x23450A73, new ParameterlessText("Tigrinya")).SetSeverity(MessageLevel.Information));
        Add(_tier = new MessageDescription("mscorlib.Globalization.ci_ti-ER", 0x23450A74, new ParameterlessText("Tigrinya (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_tiet = new MessageDescription("mscorlib.Globalization.ci_ti-ET", 0x23450A75, new ParameterlessText("Tigrinya (Ethiopia)")).SetSeverity(MessageLevel.Information));
        Add(_tig = new MessageDescription("mscorlib.Globalization.ci_tig", 0x23450A76, new ParameterlessText("Tigre")).SetSeverity(MessageLevel.Information));
        Add(_tiger = new MessageDescription("mscorlib.Globalization.ci_tig-ER", 0x23450A77, new ParameterlessText("Tigre (Eritrea)")).SetSeverity(MessageLevel.Information));
        Add(_tk = new MessageDescription("mscorlib.Globalization.ci_tk", 0x23450A78, new ParameterlessText("Turkmen")).SetSeverity(MessageLevel.Information));
        Add(_tktm = new MessageDescription("mscorlib.Globalization.ci_tk-TM", 0x23450A79, new ParameterlessText("Turkmen (Turkmenistan)")).SetSeverity(MessageLevel.Information));
        Add(_tn = new MessageDescription("mscorlib.Globalization.ci_tn", 0x23450A7A, new ParameterlessText("Setswana")).SetSeverity(MessageLevel.Information));
        Add(_tnbw = new MessageDescription("mscorlib.Globalization.ci_tn-BW", 0x23450A7B, new ParameterlessText("Setswana (Botswana)")).SetSeverity(MessageLevel.Information));
        Add(_tnza = new MessageDescription("mscorlib.Globalization.ci_tn-ZA", 0x23450A7C, new ParameterlessText("Setswana (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_to = new MessageDescription("mscorlib.Globalization.ci_to", 0x23450A7D, new ParameterlessText("Tongan")).SetSeverity(MessageLevel.Information));
        Add(_toto = new MessageDescription("mscorlib.Globalization.ci_to-TO", 0x23450A7E, new ParameterlessText("Tongan (Tonga)")).SetSeverity(MessageLevel.Information));
        Add(_tr = new MessageDescription("mscorlib.Globalization.ci_tr", 0x23450A7F, new ParameterlessText("Turkish")).SetSeverity(MessageLevel.Information));
        Add(_trcy = new MessageDescription("mscorlib.Globalization.ci_tr-CY", 0x23450A80, new ParameterlessText("Turkish (Cyprus)")).SetSeverity(MessageLevel.Information));
        Add(_trtr = new MessageDescription("mscorlib.Globalization.ci_tr-TR", 0x23450A81, new ParameterlessText("Turkish (Turkey)")).SetSeverity(MessageLevel.Information));
        Add(_ts = new MessageDescription("mscorlib.Globalization.ci_ts", 0x23450A82, new ParameterlessText("Tsonga")).SetSeverity(MessageLevel.Information));
        Add(_tsza = new MessageDescription("mscorlib.Globalization.ci_ts-ZA", 0x23450A83, new ParameterlessText("Tsonga (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_tt = new MessageDescription("mscorlib.Globalization.ci_tt", 0x23450A84, new ParameterlessText("Tatar")).SetSeverity(MessageLevel.Information));
        Add(_ttru = new MessageDescription("mscorlib.Globalization.ci_tt-RU", 0x23450A85, new ParameterlessText("Tatar (Russia)")).SetSeverity(MessageLevel.Information));
        Add(_twq = new MessageDescription("mscorlib.Globalization.ci_twq", 0x23450A86, new ParameterlessText("Tasawaq")).SetSeverity(MessageLevel.Information));
        Add(_twqne = new MessageDescription("mscorlib.Globalization.ci_twq-NE", 0x23450A87, new ParameterlessText("Tasawaq (Niger)")).SetSeverity(MessageLevel.Information));
        Add(_tzm = new MessageDescription("mscorlib.Globalization.ci_tzm", 0x23450A88, new ParameterlessText("Tamazight")).SetSeverity(MessageLevel.Information));
        Add(_tzmarab = new MessageDescription("mscorlib.Globalization.ci_tzm-Arab", 0x23450A89, new ParameterlessText("Central Atlas Tamazight (Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_tzmarabma = new MessageDescription("mscorlib.Globalization.ci_tzm-Arab-MA", 0x23450A8A, new ParameterlessText("Central Atlas Tamazight (Arabic, Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_tzmlatn = new MessageDescription("mscorlib.Globalization.ci_tzm-Latn", 0x23450A8B, new ParameterlessText("Tamazight (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_tzmlatndz = new MessageDescription("mscorlib.Globalization.ci_tzm-Latn-DZ", 0x23450A8C, new ParameterlessText("Tamazight (Latin, Algeria)")).SetSeverity(MessageLevel.Information));
        Add(_tzmlatnma = new MessageDescription("mscorlib.Globalization.ci_tzm-Latn-MA", 0x23450A8D, new ParameterlessText("Central Atlas Tamazight (Latin, Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_tzmtfng = new MessageDescription("mscorlib.Globalization.ci_tzm-Tfng", 0x23450A8E, new ParameterlessText("Tamazight (Tifinagh)")).SetSeverity(MessageLevel.Information));
        Add(_tzmtfngma = new MessageDescription("mscorlib.Globalization.ci_tzm-Tfng-MA", 0x23450A8F, new ParameterlessText("Central Atlas Tamazight (Tifinagh, Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_ug = new MessageDescription("mscorlib.Globalization.ci_ug", 0x23450A90, new ParameterlessText("Uyghur")).SetSeverity(MessageLevel.Information));
        Add(_ugcn = new MessageDescription("mscorlib.Globalization.ci_ug-CN", 0x23450A91, new ParameterlessText("Uyghur (PRC)")).SetSeverity(MessageLevel.Information));
        Add(_uk = new MessageDescription("mscorlib.Globalization.ci_uk", 0x23450A92, new ParameterlessText("Ukrainian")).SetSeverity(MessageLevel.Information));
        Add(_ukua = new MessageDescription("mscorlib.Globalization.ci_uk-UA", 0x23450A93, new ParameterlessText("Ukrainian (Ukraine)")).SetSeverity(MessageLevel.Information));
        Add(_ur = new MessageDescription("mscorlib.Globalization.ci_ur", 0x23450A94, new ParameterlessText("Urdu")).SetSeverity(MessageLevel.Information));
        Add(_urin = new MessageDescription("mscorlib.Globalization.ci_ur-IN", 0x23450A95, new ParameterlessText("Urdu (India)")).SetSeverity(MessageLevel.Information));
        Add(_urpk = new MessageDescription("mscorlib.Globalization.ci_ur-PK", 0x23450A96, new ParameterlessText("Urdu (Islamic Republic of Pakistan)")).SetSeverity(MessageLevel.Information));
        Add(_uz = new MessageDescription("mscorlib.Globalization.ci_uz", 0x23450A97, new ParameterlessText("Uzbek")).SetSeverity(MessageLevel.Information));
        Add(_uzarab = new MessageDescription("mscorlib.Globalization.ci_uz-Arab", 0x23450A98, new ParameterlessText("Uzbek (Perso-Arabic)")).SetSeverity(MessageLevel.Information));
        Add(_uzarabaf = new MessageDescription("mscorlib.Globalization.ci_uz-Arab-AF", 0x23450A99, new ParameterlessText("Uzbek (Perso-Arabic, Afghanistan)")).SetSeverity(MessageLevel.Information));
        Add(_uzcyrl = new MessageDescription("mscorlib.Globalization.ci_uz-Cyrl", 0x23450A9A, new ParameterlessText("Uzbek (Cyrillic)")).SetSeverity(MessageLevel.Information));
        Add(_uzcyrluz = new MessageDescription("mscorlib.Globalization.ci_uz-Cyrl-UZ", 0x23450A9B, new ParameterlessText("Uzbek (Cyrillic, Uzbekistan)")).SetSeverity(MessageLevel.Information));
        Add(_uzlatn = new MessageDescription("mscorlib.Globalization.ci_uz-Latn", 0x23450A9C, new ParameterlessText("Uzbek (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_uzlatnuz = new MessageDescription("mscorlib.Globalization.ci_uz-Latn-UZ", 0x23450A9D, new ParameterlessText("Uzbek (Latin, Uzbekistan)")).SetSeverity(MessageLevel.Information));
        Add(_vai = new MessageDescription("mscorlib.Globalization.ci_vai", 0x23450A9E, new ParameterlessText("Vai")).SetSeverity(MessageLevel.Information));
        Add(_vailatn = new MessageDescription("mscorlib.Globalization.ci_vai-Latn", 0x23450A9F, new ParameterlessText("Vai (Latin)")).SetSeverity(MessageLevel.Information));
        Add(_vailatnlr = new MessageDescription("mscorlib.Globalization.ci_vai-Latn-LR", 0x23450AA0, new ParameterlessText("Vai (Latin, Liberia)")).SetSeverity(MessageLevel.Information));
        Add(_vaivaii = new MessageDescription("mscorlib.Globalization.ci_vai-Vaii", 0x23450AA1, new ParameterlessText("Vai (Vai)")).SetSeverity(MessageLevel.Information));
        Add(_vaivaiilr = new MessageDescription("mscorlib.Globalization.ci_vai-Vaii-LR", 0x23450AA2, new ParameterlessText("Vai (Vai, Liberia)")).SetSeverity(MessageLevel.Information));
        Add(_ve = new MessageDescription("mscorlib.Globalization.ci_ve", 0x23450AA3, new ParameterlessText("Venda")).SetSeverity(MessageLevel.Information));
        Add(_veza = new MessageDescription("mscorlib.Globalization.ci_ve-ZA", 0x23450AA4, new ParameterlessText("Venda (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_vi = new MessageDescription("mscorlib.Globalization.ci_vi", 0x23450AA5, new ParameterlessText("Vietnamese")).SetSeverity(MessageLevel.Information));
        Add(_vivn = new MessageDescription("mscorlib.Globalization.ci_vi-VN", 0x23450AA6, new ParameterlessText("Vietnamese (Vietnam)")).SetSeverity(MessageLevel.Information));
        Add(_vo = new MessageDescription("mscorlib.Globalization.ci_vo", 0x23450AA7, new ParameterlessText("Volapük")).SetSeverity(MessageLevel.Information));
        Add(_vo001 = new MessageDescription("mscorlib.Globalization.ci_vo-001", 0x23450AA8, new ParameterlessText("Volapük (World)")).SetSeverity(MessageLevel.Information));
        Add(_vun = new MessageDescription("mscorlib.Globalization.ci_vun", 0x23450AA9, new ParameterlessText("Vunjo")).SetSeverity(MessageLevel.Information));
        Add(_vuntz = new MessageDescription("mscorlib.Globalization.ci_vun-TZ", 0x23450AAA, new ParameterlessText("Vunjo (Tanzania)")).SetSeverity(MessageLevel.Information));
        Add(_wae = new MessageDescription("mscorlib.Globalization.ci_wae", 0x23450AAB, new ParameterlessText("Walser")).SetSeverity(MessageLevel.Information));
        Add(_waech = new MessageDescription("mscorlib.Globalization.ci_wae-CH", 0x23450AAC, new ParameterlessText("Walser (Switzerland)")).SetSeverity(MessageLevel.Information));
        Add(_wal = new MessageDescription("mscorlib.Globalization.ci_wal", 0x23450AAD, new ParameterlessText("Wolaytta")).SetSeverity(MessageLevel.Information));
        Add(_walet = new MessageDescription("mscorlib.Globalization.ci_wal-ET", 0x23450AAE, new ParameterlessText("Wolaytta (Ethiopia)")).SetSeverity(MessageLevel.Information));
        Add(_wo = new MessageDescription("mscorlib.Globalization.ci_wo", 0x23450AAF, new ParameterlessText("Wolof")).SetSeverity(MessageLevel.Information));
        Add(_wosn = new MessageDescription("mscorlib.Globalization.ci_wo-SN", 0x23450AB0, new ParameterlessText("Wolof (Senegal)")).SetSeverity(MessageLevel.Information));
        Add(_xiv = new MessageDescription("mscorlib.Globalization.ci_x-IV", 0x23450AB1, new ParameterlessText("Invariant Language (Invariant Country)")).SetSeverity(MessageLevel.Information));
        Add(_xivmathan = new MessageDescription("mscorlib.Globalization.ci_x-IV_mathan", 0x23450AB2, new ParameterlessText("Invariant Language (Invariant Country)")).SetSeverity(MessageLevel.Information));
        Add(_xh = new MessageDescription("mscorlib.Globalization.ci_xh", 0x23450AB3, new ParameterlessText("isiXhosa")).SetSeverity(MessageLevel.Information));
        Add(_xhza = new MessageDescription("mscorlib.Globalization.ci_xh-ZA", 0x23450AB4, new ParameterlessText("isiXhosa (South Africa)")).SetSeverity(MessageLevel.Information));
        Add(_xog = new MessageDescription("mscorlib.Globalization.ci_xog", 0x23450AB5, new ParameterlessText("Soga")).SetSeverity(MessageLevel.Information));
        Add(_xogug = new MessageDescription("mscorlib.Globalization.ci_xog-UG", 0x23450AB6, new ParameterlessText("Soga (Uganda)")).SetSeverity(MessageLevel.Information));
        Add(_yav = new MessageDescription("mscorlib.Globalization.ci_yav", 0x23450AB7, new ParameterlessText("Yangben")).SetSeverity(MessageLevel.Information));
        Add(_yavcm = new MessageDescription("mscorlib.Globalization.ci_yav-CM", 0x23450AB8, new ParameterlessText("Yangben (Cameroon)")).SetSeverity(MessageLevel.Information));
        Add(_yi = new MessageDescription("mscorlib.Globalization.ci_yi", 0x23450AB9, new ParameterlessText("Yiddish")).SetSeverity(MessageLevel.Information));
        Add(_yi001 = new MessageDescription("mscorlib.Globalization.ci_yi-001", 0x23450ABA, new ParameterlessText("Yiddish (World)")).SetSeverity(MessageLevel.Information));
        Add(_yo = new MessageDescription("mscorlib.Globalization.ci_yo", 0x23450ABB, new ParameterlessText("Yoruba")).SetSeverity(MessageLevel.Information));
        Add(_yobj = new MessageDescription("mscorlib.Globalization.ci_yo-BJ", 0x23450ABC, new ParameterlessText("Yoruba (Benin)")).SetSeverity(MessageLevel.Information));
        Add(_yong = new MessageDescription("mscorlib.Globalization.ci_yo-NG", 0x23450ABD, new ParameterlessText("Yoruba (Nigeria)")).SetSeverity(MessageLevel.Information));
        Add(_zgh = new MessageDescription("mscorlib.Globalization.ci_zgh", 0x23450ABE, new ParameterlessText("Standard Moroccan Tamazight")).SetSeverity(MessageLevel.Information));
        Add(_zghtfng = new MessageDescription("mscorlib.Globalization.ci_zgh-Tfng", 0x23450ABF, new ParameterlessText("Standard Moroccan Tamazight (Tifinagh)")).SetSeverity(MessageLevel.Information));
        Add(_zghtfngma = new MessageDescription("mscorlib.Globalization.ci_zgh-Tfng-MA", 0x23450AC0, new ParameterlessText("Standard Moroccan Tamazight (Tifinagh, Morocco)")).SetSeverity(MessageLevel.Information));
        Add(_zh = new MessageDescription("mscorlib.Globalization.ci_zh", 0x23450AC1, new ParameterlessText("Chinese")).SetSeverity(MessageLevel.Information));
        Add(_zhchs = new MessageDescription("mscorlib.Globalization.ci_zh-CHS", 0x23450AC2, new ParameterlessText("Chinese (Simplified) Legacy")).SetSeverity(MessageLevel.Information));
        Add(_zhcht = new MessageDescription("mscorlib.Globalization.ci_zh-CHT", 0x23450AC3, new ParameterlessText("Chinese (Traditional) Legacy")).SetSeverity(MessageLevel.Information));
        Add(_zhcn = new MessageDescription("mscorlib.Globalization.ci_zh-CN", 0x23450AC4, new ParameterlessText("Chinese (Simplified, PRC)")).SetSeverity(MessageLevel.Information));
        Add(_zhcnstroke = new MessageDescription("mscorlib.Globalization.ci_zh-CN_stroke", 0x23450AC5, new ParameterlessText("Chinese (Simplified, PRC)")).SetSeverity(MessageLevel.Information));
        Add(_zhhk = new MessageDescription("mscorlib.Globalization.ci_zh-HK", 0x23450ACA, new ParameterlessText("Chinese (Traditional, Hong Kong S.A.R.)")).SetSeverity(MessageLevel.Information));
        Add(_zhhkradstr = new MessageDescription("mscorlib.Globalization.ci_zh-HK_radstr", 0x23450ACB, new ParameterlessText("Chinese (Traditional, Hong Kong S.A.R.)")).SetSeverity(MessageLevel.Information));
        Add(_zhhans = new MessageDescription("mscorlib.Globalization.ci_zh-Hans", 0x23450AC6, new ParameterlessText("Chinese (Simplified)")).SetSeverity(MessageLevel.Information));
        Add(_zhhanshk = new MessageDescription("mscorlib.Globalization.ci_zh-Hans-HK", 0x23450AC7, new ParameterlessText("Chinese (Simplified Han, Hong Kong SAR)")).SetSeverity(MessageLevel.Information));
        Add(_zhhansmo = new MessageDescription("mscorlib.Globalization.ci_zh-Hans-MO", 0x23450AC8, new ParameterlessText("Chinese (Simplified Han, Macao SAR)")).SetSeverity(MessageLevel.Information));
        Add(_zhhant = new MessageDescription("mscorlib.Globalization.ci_zh-Hant", 0x23450AC9, new ParameterlessText("Chinese (Traditional)")).SetSeverity(MessageLevel.Information));
        Add(_zhmo = new MessageDescription("mscorlib.Globalization.ci_zh-MO", 0x23450ACC, new ParameterlessText("Chinese (Traditional, Macao S.A.R.)")).SetSeverity(MessageLevel.Information));
        Add(_zhmoradstr = new MessageDescription("mscorlib.Globalization.ci_zh-MO_radstr", 0x23450ACD, new ParameterlessText("Chinese (Traditional, Macao S.A.R.)")).SetSeverity(MessageLevel.Information));
        Add(_zhmostroke = new MessageDescription("mscorlib.Globalization.ci_zh-MO_stroke", 0x23450ACE, new ParameterlessText("Chinese (Traditional, Macao S.A.R.)")).SetSeverity(MessageLevel.Information));
        Add(_zhsg = new MessageDescription("mscorlib.Globalization.ci_zh-SG", 0x23450ACF, new ParameterlessText("Chinese (Simplified, Singapore)")).SetSeverity(MessageLevel.Information));
        Add(_zhsgstroke = new MessageDescription("mscorlib.Globalization.ci_zh-SG_stroke", 0x23450AD0, new ParameterlessText("Chinese (Simplified, Singapore)")).SetSeverity(MessageLevel.Information));
        Add(_zhtw = new MessageDescription("mscorlib.Globalization.ci_zh-TW", 0x23450AD1, new ParameterlessText("Chinese (Traditional, Taiwan)")).SetSeverity(MessageLevel.Information));
        Add(_zhtwpronun = new MessageDescription("mscorlib.Globalization.ci_zh-TW_pronun", 0x23450AD2, new ParameterlessText("Chinese (Traditional, Taiwan)")).SetSeverity(MessageLevel.Information));
        Add(_zhtwradstr = new MessageDescription("mscorlib.Globalization.ci_zh-TW_radstr", 0x23450AD3, new ParameterlessText("Chinese (Traditional, Taiwan)")).SetSeverity(MessageLevel.Information));
        Add(_zu = new MessageDescription("mscorlib.Globalization.ci_zu", 0x23450AD4, new ParameterlessText("isiZulu")).SetSeverity(MessageLevel.Information));
        Add(_zuza = new MessageDescription("mscorlib.Globalization.ci_zu-ZA", 0x23450AD5, new ParameterlessText("isiZulu (South Africa)")).SetSeverity(MessageLevel.Information));
        return this;
    }    

}
