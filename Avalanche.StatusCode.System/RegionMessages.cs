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

/// <summary>Region</summary>
public class RegionMessages : MessageDescriptions
{
    /// <summary>Singleton</summary>
    static readonly Lazy<RegionMessages> instance = new Lazy<RegionMessages>(() => new RegionMessages().Initialize().SetAllReadOnly<RegionMessages>().SetReadOnly());
    /// <summary>Singleton</summary>
    public static RegionMessages Instance => instance.Value;

    /// <summary>MessageDescription count</summary>
    public const int MessageDescriptionCount = 0x00F8;
    
    /// <summary>Message description fields</summary>
    IMessageDescription? __001, __029, __150, __419, _ad, _ae, _af, _ag, _ai, _al;
    IMessageDescription? _am, _ao, _ar, _as, _at, _au, _aw, _ax, _az, _ba;
    IMessageDescription? _bb, _bd, _be, _bf, _bg, _bh, _bi, _bj, _bl, _bm;
    IMessageDescription? _bn, _bo, _bq, _br, _bs, _bt, _bw, _by, _bz, _ca;
    IMessageDescription? _cc, _cd, _cf, _cg, _ch, _ci, _ck, _cl, _cm, _cn;
    IMessageDescription? _co, _cr, _cs, _cu, _cv, _cw, _cx, _cy, _cz, _de;
    IMessageDescription? _dj, _dk, _dm, _do, _dz, _ec, _ee, _eg, _er, _es;
    IMessageDescription? _et, _fi, _fj, _fk, _fm, _fo, _fr, _ga, _gb, _gd;
    IMessageDescription? _ge, _gf, _gg, _gh, _gi, _gl, _gm, _gn, _gp, _gq;
    IMessageDescription? _gr, _gt, _gu, _gw, _gy, _hk, _hn, _hr, _ht, _hu;
    IMessageDescription? _id, _ie, _il, _im, _in, _io, _iq, _ir, _is, _it;
    IMessageDescription? _iv, _je, _jm, _jo, _jp, _ke, _kg, _kh, _ki, _km;
    IMessageDescription? _kn, _kr, _kw, _ky, _kz, _la, _lb, _lc, _li, _lk;
    IMessageDescription? _lr, _ls, _lt, _lu, _lv, _ly, _ma, _mc, _md, _me;
    IMessageDescription? _mf, _mg, _mh, _mk, _ml, _mm, _mn, _mo, _mp, _mq;
    IMessageDescription? _mr, _ms, _mt, _mu, _mv, _mw, _mx, _my, _mz, _na;
    IMessageDescription? _nc, _ne, _nf, _ng, _ni, _nl, _no, _np, _nr, _nu;
    IMessageDescription? _nz, _om, _pa, _pe, _pf, _pg, _ph, _pk, _pl, _pm;
    IMessageDescription? _pn, _pr, _ps, _pt, _pw, _py, _qa, _re, _ro, _rs;
    IMessageDescription? _ru, _rw, _sa, _sb, _sc, _sd, _se, _sg, _sh, _si;
    IMessageDescription? _sj, _sk, _sl, _sm, _sn, _so, _sr, _ss, _st, _sv;
    IMessageDescription? _sx, _sy, _sz, _tc, _td, _tg, _th, _tj, _tk, _tl;
    IMessageDescription? _tm, _tn, _to, _tr, _tt, _tv, _tw, _tz, _ua, _ug;
    IMessageDescription? _um, _us, _uy, _uz, _vc, _ve, _vg, _vi, _vn, _vu;
    IMessageDescription? _wf, _ws, _xk, _ye, _yt, _za, _zm, _zw;
    
    /// <summary>World</summary>
    public IMessageDescription _001 { get => __001!; set => this.AssertWritable().__001 = value; }
    /// <summary>Caribbean</summary>
    public IMessageDescription _029 { get => __029!; set => this.AssertWritable().__029 = value; }
    /// <summary>Europe</summary>
    public IMessageDescription _150 { get => __150!; set => this.AssertWritable().__150 = value; }
    /// <summary>Latin America</summary>
    public IMessageDescription _419 { get => __419!; set => this.AssertWritable().__419 = value; }
    /// <summary>Andorra</summary>
    public IMessageDescription AD { get => _ad!; set => this.AssertWritable()._ad = value; }
    /// <summary>U.A.E.</summary>
    public IMessageDescription AE { get => _ae!; set => this.AssertWritable()._ae = value; }
    /// <summary>Afghanistan</summary>
    public IMessageDescription AF { get => _af!; set => this.AssertWritable()._af = value; }
    /// <summary>Antigua and Barbuda</summary>
    public IMessageDescription AG { get => _ag!; set => this.AssertWritable()._ag = value; }
    /// <summary>Anguilla</summary>
    public IMessageDescription AI { get => _ai!; set => this.AssertWritable()._ai = value; }
    /// <summary>Albania</summary>
    public IMessageDescription AL { get => _al!; set => this.AssertWritable()._al = value; }
    /// <summary>Armenia</summary>
    public IMessageDescription AM { get => _am!; set => this.AssertWritable()._am = value; }
    /// <summary>Angola</summary>
    public IMessageDescription AO { get => _ao!; set => this.AssertWritable()._ao = value; }
    /// <summary>Argentina</summary>
    public IMessageDescription AR { get => _ar!; set => this.AssertWritable()._ar = value; }
    /// <summary>American Samoa</summary>
    public IMessageDescription AS { get => _as!; set => this.AssertWritable()._as = value; }
    /// <summary>Austria</summary>
    public IMessageDescription AT { get => _at!; set => this.AssertWritable()._at = value; }
    /// <summary>Australia</summary>
    public IMessageDescription AU { get => _au!; set => this.AssertWritable()._au = value; }
    /// <summary>Aruba</summary>
    public IMessageDescription AW { get => _aw!; set => this.AssertWritable()._aw = value; }
    /// <summary>&#197;land Islands</summary>
    public IMessageDescription AX { get => _ax!; set => this.AssertWritable()._ax = value; }
    /// <summary>Azerbaijan</summary>
    public IMessageDescription AZ { get => _az!; set => this.AssertWritable()._az = value; }
    /// <summary>Bosnia and Herzegovina</summary>
    public IMessageDescription BA { get => _ba!; set => this.AssertWritable()._ba = value; }
    /// <summary>Barbados</summary>
    public IMessageDescription BB { get => _bb!; set => this.AssertWritable()._bb = value; }
    /// <summary>Bangladesh</summary>
    public IMessageDescription BD { get => _bd!; set => this.AssertWritable()._bd = value; }
    /// <summary>Belgium</summary>
    public IMessageDescription BE { get => _be!; set => this.AssertWritable()._be = value; }
    /// <summary>Burkina Faso</summary>
    public IMessageDescription BF { get => _bf!; set => this.AssertWritable()._bf = value; }
    /// <summary>Bulgaria</summary>
    public IMessageDescription BG { get => _bg!; set => this.AssertWritable()._bg = value; }
    /// <summary>Bahrain</summary>
    public IMessageDescription BH { get => _bh!; set => this.AssertWritable()._bh = value; }
    /// <summary>Burundi</summary>
    public IMessageDescription BI { get => _bi!; set => this.AssertWritable()._bi = value; }
    /// <summary>Benin</summary>
    public IMessageDescription BJ { get => _bj!; set => this.AssertWritable()._bj = value; }
    /// <summary>Saint Barth&#233;lemy</summary>
    public IMessageDescription BL { get => _bl!; set => this.AssertWritable()._bl = value; }
    /// <summary>Bermuda</summary>
    public IMessageDescription BM { get => _bm!; set => this.AssertWritable()._bm = value; }
    /// <summary>Brunei Darussalam</summary>
    public IMessageDescription BN { get => _bn!; set => this.AssertWritable()._bn = value; }
    /// <summary>Bolivia</summary>
    public IMessageDescription BO { get => _bo!; set => this.AssertWritable()._bo = value; }
    /// <summary>Bonaire, Sint Eustatius and Saba</summary>
    public IMessageDescription BQ { get => _bq!; set => this.AssertWritable()._bq = value; }
    /// <summary>Brazil</summary>
    public IMessageDescription BR { get => _br!; set => this.AssertWritable()._br = value; }
    /// <summary>Bahamas</summary>
    public IMessageDescription BS { get => _bs!; set => this.AssertWritable()._bs = value; }
    /// <summary>Bhutan</summary>
    public IMessageDescription BT { get => _bt!; set => this.AssertWritable()._bt = value; }
    /// <summary>Botswana</summary>
    public IMessageDescription BW { get => _bw!; set => this.AssertWritable()._bw = value; }
    /// <summary>Belarus</summary>
    public IMessageDescription BY { get => _by!; set => this.AssertWritable()._by = value; }
    /// <summary>Belize</summary>
    public IMessageDescription BZ { get => _bz!; set => this.AssertWritable()._bz = value; }
    /// <summary>Canada</summary>
    public IMessageDescription CA { get => _ca!; set => this.AssertWritable()._ca = value; }
    /// <summary>Cocos (Keeling) Islands</summary>
    public IMessageDescription CC { get => _cc!; set => this.AssertWritable()._cc = value; }
    /// <summary>Congo (DRC)</summary>
    public IMessageDescription CD { get => _cd!; set => this.AssertWritable()._cd = value; }
    /// <summary>Central African Republic</summary>
    public IMessageDescription CF { get => _cf!; set => this.AssertWritable()._cf = value; }
    /// <summary>Congo</summary>
    public IMessageDescription CG { get => _cg!; set => this.AssertWritable()._cg = value; }
    /// <summary>Switzerland</summary>
    public IMessageDescription CH { get => _ch!; set => this.AssertWritable()._ch = value; }
    /// <summary>C&#244;te d’Ivoire</summary>
    public IMessageDescription CI { get => _ci!; set => this.AssertWritable()._ci = value; }
    /// <summary>Cook Islands</summary>
    public IMessageDescription CK { get => _ck!; set => this.AssertWritable()._ck = value; }
    /// <summary>Chile</summary>
    public IMessageDescription CL { get => _cl!; set => this.AssertWritable()._cl = value; }
    /// <summary>Cameroon</summary>
    public IMessageDescription CM { get => _cm!; set => this.AssertWritable()._cm = value; }
    /// <summary>People&#39;s Republic of China</summary>
    public IMessageDescription CN { get => _cn!; set => this.AssertWritable()._cn = value; }
    /// <summary>Colombia</summary>
    public IMessageDescription CO { get => _co!; set => this.AssertWritable()._co = value; }
    /// <summary>Costa Rica</summary>
    public IMessageDescription CR { get => _cr!; set => this.AssertWritable()._cr = value; }
    /// <summary>Serbia and Montenegro (Former)</summary>
    public IMessageDescription CS { get => _cs!; set => this.AssertWritable()._cs = value; }
    /// <summary>Cuba</summary>
    public IMessageDescription CU { get => _cu!; set => this.AssertWritable()._cu = value; }
    /// <summary>Cabo Verde</summary>
    public IMessageDescription CV { get => _cv!; set => this.AssertWritable()._cv = value; }
    /// <summary>Cura&#231;ao</summary>
    public IMessageDescription CW { get => _cw!; set => this.AssertWritable()._cw = value; }
    /// <summary>Christmas Island</summary>
    public IMessageDescription CX { get => _cx!; set => this.AssertWritable()._cx = value; }
    /// <summary>Cyprus</summary>
    public IMessageDescription CY { get => _cy!; set => this.AssertWritable()._cy = value; }
    /// <summary>Czech Republic</summary>
    public IMessageDescription CZ { get => _cz!; set => this.AssertWritable()._cz = value; }
    /// <summary>Germany</summary>
    public IMessageDescription DE { get => _de!; set => this.AssertWritable()._de = value; }
    /// <summary>Djibouti</summary>
    public IMessageDescription DJ { get => _dj!; set => this.AssertWritable()._dj = value; }
    /// <summary>Denmark</summary>
    public IMessageDescription DK { get => _dk!; set => this.AssertWritable()._dk = value; }
    /// <summary>Dominica</summary>
    public IMessageDescription DM { get => _dm!; set => this.AssertWritable()._dm = value; }
    /// <summary>Dominican Republic</summary>
    public IMessageDescription DO { get => _do!; set => this.AssertWritable()._do = value; }
    /// <summary>Algeria</summary>
    public IMessageDescription DZ { get => _dz!; set => this.AssertWritable()._dz = value; }
    /// <summary>Ecuador</summary>
    public IMessageDescription EC { get => _ec!; set => this.AssertWritable()._ec = value; }
    /// <summary>Estonia</summary>
    public IMessageDescription EE { get => _ee!; set => this.AssertWritable()._ee = value; }
    /// <summary>Egypt</summary>
    public IMessageDescription EG { get => _eg!; set => this.AssertWritable()._eg = value; }
    /// <summary>Eritrea</summary>
    public IMessageDescription ER { get => _er!; set => this.AssertWritable()._er = value; }
    /// <summary>Spain</summary>
    public IMessageDescription ES { get => _es!; set => this.AssertWritable()._es = value; }
    /// <summary>Ethiopia</summary>
    public IMessageDescription ET { get => _et!; set => this.AssertWritable()._et = value; }
    /// <summary>Finland</summary>
    public IMessageDescription FI { get => _fi!; set => this.AssertWritable()._fi = value; }
    /// <summary>Fiji</summary>
    public IMessageDescription FJ { get => _fj!; set => this.AssertWritable()._fj = value; }
    /// <summary>Falkland Islands</summary>
    public IMessageDescription FK { get => _fk!; set => this.AssertWritable()._fk = value; }
    /// <summary>Micronesia</summary>
    public IMessageDescription FM { get => _fm!; set => this.AssertWritable()._fm = value; }
    /// <summary>Faroe Islands</summary>
    public IMessageDescription FO { get => _fo!; set => this.AssertWritable()._fo = value; }
    /// <summary>France</summary>
    public IMessageDescription FR { get => _fr!; set => this.AssertWritable()._fr = value; }
    /// <summary>Gabon</summary>
    public IMessageDescription GA { get => _ga!; set => this.AssertWritable()._ga = value; }
    /// <summary>United Kingdom</summary>
    public IMessageDescription GB { get => _gb!; set => this.AssertWritable()._gb = value; }
    /// <summary>Grenada</summary>
    public IMessageDescription GD { get => _gd!; set => this.AssertWritable()._gd = value; }
    /// <summary>Georgia</summary>
    public IMessageDescription GE { get => _ge!; set => this.AssertWritable()._ge = value; }
    /// <summary>French Guiana</summary>
    public IMessageDescription GF { get => _gf!; set => this.AssertWritable()._gf = value; }
    /// <summary>Guernsey</summary>
    public IMessageDescription GG { get => _gg!; set => this.AssertWritable()._gg = value; }
    /// <summary>Ghana</summary>
    public IMessageDescription GH { get => _gh!; set => this.AssertWritable()._gh = value; }
    /// <summary>Gibraltar</summary>
    public IMessageDescription GI { get => _gi!; set => this.AssertWritable()._gi = value; }
    /// <summary>Greenland</summary>
    public IMessageDescription GL { get => _gl!; set => this.AssertWritable()._gl = value; }
    /// <summary>Gambia</summary>
    public IMessageDescription GM { get => _gm!; set => this.AssertWritable()._gm = value; }
    /// <summary>Guinea</summary>
    public IMessageDescription GN { get => _gn!; set => this.AssertWritable()._gn = value; }
    /// <summary>Guadeloupe</summary>
    public IMessageDescription GP { get => _gp!; set => this.AssertWritable()._gp = value; }
    /// <summary>Equatorial Guinea</summary>
    public IMessageDescription GQ { get => _gq!; set => this.AssertWritable()._gq = value; }
    /// <summary>Greece</summary>
    public IMessageDescription GR { get => _gr!; set => this.AssertWritable()._gr = value; }
    /// <summary>Guatemala</summary>
    public IMessageDescription GT { get => _gt!; set => this.AssertWritable()._gt = value; }
    /// <summary>Guam</summary>
    public IMessageDescription GU { get => _gu!; set => this.AssertWritable()._gu = value; }
    /// <summary>Guinea-Bissau</summary>
    public IMessageDescription GW { get => _gw!; set => this.AssertWritable()._gw = value; }
    /// <summary>Guyana</summary>
    public IMessageDescription GY { get => _gy!; set => this.AssertWritable()._gy = value; }
    /// <summary>Hong Kong S.A.R.</summary>
    public IMessageDescription HK { get => _hk!; set => this.AssertWritable()._hk = value; }
    /// <summary>Honduras</summary>
    public IMessageDescription HN { get => _hn!; set => this.AssertWritable()._hn = value; }
    /// <summary>Croatia</summary>
    public IMessageDescription HR { get => _hr!; set => this.AssertWritable()._hr = value; }
    /// <summary>Haiti</summary>
    public IMessageDescription HT { get => _ht!; set => this.AssertWritable()._ht = value; }
    /// <summary>Hungary</summary>
    public IMessageDescription HU { get => _hu!; set => this.AssertWritable()._hu = value; }
    /// <summary>Indonesia</summary>
    public IMessageDescription ID { get => _id!; set => this.AssertWritable()._id = value; }
    /// <summary>Ireland</summary>
    public IMessageDescription IE { get => _ie!; set => this.AssertWritable()._ie = value; }
    /// <summary>Israel</summary>
    public IMessageDescription IL { get => _il!; set => this.AssertWritable()._il = value; }
    /// <summary>Isle of Man</summary>
    public IMessageDescription IM { get => _im!; set => this.AssertWritable()._im = value; }
    /// <summary>India</summary>
    public IMessageDescription IN { get => _in!; set => this.AssertWritable()._in = value; }
    /// <summary>British Indian Ocean Territory</summary>
    public IMessageDescription IO { get => _io!; set => this.AssertWritable()._io = value; }
    /// <summary>Iraq</summary>
    public IMessageDescription IQ { get => _iq!; set => this.AssertWritable()._iq = value; }
    /// <summary>Iran</summary>
    public IMessageDescription IR { get => _ir!; set => this.AssertWritable()._ir = value; }
    /// <summary>Iceland</summary>
    public IMessageDescription IS { get => _is!; set => this.AssertWritable()._is = value; }
    /// <summary>Italy</summary>
    public IMessageDescription IT { get => _it!; set => this.AssertWritable()._it = value; }
    /// <summary>Invariant Country</summary>
    public IMessageDescription IV { get => _iv!; set => this.AssertWritable()._iv = value; }
    /// <summary>Jersey</summary>
    public IMessageDescription JE { get => _je!; set => this.AssertWritable()._je = value; }
    /// <summary>Jamaica</summary>
    public IMessageDescription JM { get => _jm!; set => this.AssertWritable()._jm = value; }
    /// <summary>Jordan</summary>
    public IMessageDescription JO { get => _jo!; set => this.AssertWritable()._jo = value; }
    /// <summary>Japan</summary>
    public IMessageDescription JP { get => _jp!; set => this.AssertWritable()._jp = value; }
    /// <summary>Kenya</summary>
    public IMessageDescription KE { get => _ke!; set => this.AssertWritable()._ke = value; }
    /// <summary>Kyrgyzstan</summary>
    public IMessageDescription KG { get => _kg!; set => this.AssertWritable()._kg = value; }
    /// <summary>Cambodia</summary>
    public IMessageDescription KH { get => _kh!; set => this.AssertWritable()._kh = value; }
    /// <summary>Kiribati</summary>
    public IMessageDescription KI { get => _ki!; set => this.AssertWritable()._ki = value; }
    /// <summary>Comoros</summary>
    public IMessageDescription KM { get => _km!; set => this.AssertWritable()._km = value; }
    /// <summary>Saint Kitts and Nevis</summary>
    public IMessageDescription KN { get => _kn!; set => this.AssertWritable()._kn = value; }
    /// <summary>Korea</summary>
    public IMessageDescription KR { get => _kr!; set => this.AssertWritable()._kr = value; }
    /// <summary>Kuwait</summary>
    public IMessageDescription KW { get => _kw!; set => this.AssertWritable()._kw = value; }
    /// <summary>Cayman Islands</summary>
    public IMessageDescription KY { get => _ky!; set => this.AssertWritable()._ky = value; }
    /// <summary>Kazakhstan</summary>
    public IMessageDescription KZ { get => _kz!; set => this.AssertWritable()._kz = value; }
    /// <summary>Lao P.D.R.</summary>
    public IMessageDescription LA { get => _la!; set => this.AssertWritable()._la = value; }
    /// <summary>Lebanon</summary>
    public IMessageDescription LB { get => _lb!; set => this.AssertWritable()._lb = value; }
    /// <summary>Saint Lucia</summary>
    public IMessageDescription LC { get => _lc!; set => this.AssertWritable()._lc = value; }
    /// <summary>Liechtenstein</summary>
    public IMessageDescription LI { get => _li!; set => this.AssertWritable()._li = value; }
    /// <summary>Sri Lanka</summary>
    public IMessageDescription LK { get => _lk!; set => this.AssertWritable()._lk = value; }
    /// <summary>Liberia</summary>
    public IMessageDescription LR { get => _lr!; set => this.AssertWritable()._lr = value; }
    /// <summary>Lesotho</summary>
    public IMessageDescription LS { get => _ls!; set => this.AssertWritable()._ls = value; }
    /// <summary>Lithuania</summary>
    public IMessageDescription LT { get => _lt!; set => this.AssertWritable()._lt = value; }
    /// <summary>Luxembourg</summary>
    public IMessageDescription LU { get => _lu!; set => this.AssertWritable()._lu = value; }
    /// <summary>Latvia</summary>
    public IMessageDescription LV { get => _lv!; set => this.AssertWritable()._lv = value; }
    /// <summary>Libya</summary>
    public IMessageDescription LY { get => _ly!; set => this.AssertWritable()._ly = value; }
    /// <summary>Morocco</summary>
    public IMessageDescription MA { get => _ma!; set => this.AssertWritable()._ma = value; }
    /// <summary>Principality of Monaco</summary>
    public IMessageDescription MC { get => _mc!; set => this.AssertWritable()._mc = value; }
    /// <summary>Moldova</summary>
    public IMessageDescription MD { get => _md!; set => this.AssertWritable()._md = value; }
    /// <summary>Montenegro</summary>
    public IMessageDescription ME { get => _me!; set => this.AssertWritable()._me = value; }
    /// <summary>Saint Martin</summary>
    public IMessageDescription MF { get => _mf!; set => this.AssertWritable()._mf = value; }
    /// <summary>Madagascar</summary>
    public IMessageDescription MG { get => _mg!; set => this.AssertWritable()._mg = value; }
    /// <summary>Marshall Islands</summary>
    public IMessageDescription MH { get => _mh!; set => this.AssertWritable()._mh = value; }
    /// <summary>North Macedonia</summary>
    public IMessageDescription MK { get => _mk!; set => this.AssertWritable()._mk = value; }
    /// <summary>Mali</summary>
    public IMessageDescription ML { get => _ml!; set => this.AssertWritable()._ml = value; }
    /// <summary>Myanmar</summary>
    public IMessageDescription MM { get => _mm!; set => this.AssertWritable()._mm = value; }
    /// <summary>Mongolia</summary>
    public IMessageDescription MN { get => _mn!; set => this.AssertWritable()._mn = value; }
    /// <summary>Macao S.A.R.</summary>
    public IMessageDescription MO { get => _mo!; set => this.AssertWritable()._mo = value; }
    /// <summary>Northern Mariana Islands</summary>
    public IMessageDescription MP { get => _mp!; set => this.AssertWritable()._mp = value; }
    /// <summary>Martinique</summary>
    public IMessageDescription MQ { get => _mq!; set => this.AssertWritable()._mq = value; }
    /// <summary>Mauritania</summary>
    public IMessageDescription MR { get => _mr!; set => this.AssertWritable()._mr = value; }
    /// <summary>Montserrat</summary>
    public IMessageDescription MS { get => _ms!; set => this.AssertWritable()._ms = value; }
    /// <summary>Malta</summary>
    public IMessageDescription MT { get => _mt!; set => this.AssertWritable()._mt = value; }
    /// <summary>Mauritius</summary>
    public IMessageDescription MU { get => _mu!; set => this.AssertWritable()._mu = value; }
    /// <summary>Maldives</summary>
    public IMessageDescription MV { get => _mv!; set => this.AssertWritable()._mv = value; }
    /// <summary>Malawi</summary>
    public IMessageDescription MW { get => _mw!; set => this.AssertWritable()._mw = value; }
    /// <summary>Mexico</summary>
    public IMessageDescription MX { get => _mx!; set => this.AssertWritable()._mx = value; }
    /// <summary>Malaysia</summary>
    public IMessageDescription MY { get => _my!; set => this.AssertWritable()._my = value; }
    /// <summary>Mozambique</summary>
    public IMessageDescription MZ { get => _mz!; set => this.AssertWritable()._mz = value; }
    /// <summary>Namibia</summary>
    public IMessageDescription NA { get => _na!; set => this.AssertWritable()._na = value; }
    /// <summary>New Caledonia</summary>
    public IMessageDescription NC { get => _nc!; set => this.AssertWritable()._nc = value; }
    /// <summary>Niger</summary>
    public IMessageDescription NE { get => _ne!; set => this.AssertWritable()._ne = value; }
    /// <summary>Norfolk Island</summary>
    public IMessageDescription NF { get => _nf!; set => this.AssertWritable()._nf = value; }
    /// <summary>Nigeria</summary>
    public IMessageDescription NG { get => _ng!; set => this.AssertWritable()._ng = value; }
    /// <summary>Nicaragua</summary>
    public IMessageDescription NI { get => _ni!; set => this.AssertWritable()._ni = value; }
    /// <summary>Netherlands</summary>
    public IMessageDescription NL { get => _nl!; set => this.AssertWritable()._nl = value; }
    /// <summary>Norway</summary>
    public IMessageDescription NO { get => _no!; set => this.AssertWritable()._no = value; }
    /// <summary>Nepal</summary>
    public IMessageDescription NP { get => _np!; set => this.AssertWritable()._np = value; }
    /// <summary>Nauru</summary>
    public IMessageDescription NR { get => _nr!; set => this.AssertWritable()._nr = value; }
    /// <summary>Niue</summary>
    public IMessageDescription NU { get => _nu!; set => this.AssertWritable()._nu = value; }
    /// <summary>New Zealand</summary>
    public IMessageDescription NZ { get => _nz!; set => this.AssertWritable()._nz = value; }
    /// <summary>Oman</summary>
    public IMessageDescription OM { get => _om!; set => this.AssertWritable()._om = value; }
    /// <summary>Panama</summary>
    public IMessageDescription PA { get => _pa!; set => this.AssertWritable()._pa = value; }
    /// <summary>Peru</summary>
    public IMessageDescription PE { get => _pe!; set => this.AssertWritable()._pe = value; }
    /// <summary>French Polynesia</summary>
    public IMessageDescription PF { get => _pf!; set => this.AssertWritable()._pf = value; }
    /// <summary>Papua New Guinea</summary>
    public IMessageDescription PG { get => _pg!; set => this.AssertWritable()._pg = value; }
    /// <summary>Philippines</summary>
    public IMessageDescription PH { get => _ph!; set => this.AssertWritable()._ph = value; }
    /// <summary>Islamic Republic of Pakistan</summary>
    public IMessageDescription PK { get => _pk!; set => this.AssertWritable()._pk = value; }
    /// <summary>Poland</summary>
    public IMessageDescription PL { get => _pl!; set => this.AssertWritable()._pl = value; }
    /// <summary>Saint Pierre and Miquelon</summary>
    public IMessageDescription PM { get => _pm!; set => this.AssertWritable()._pm = value; }
    /// <summary>Pitcairn Islands</summary>
    public IMessageDescription PN { get => _pn!; set => this.AssertWritable()._pn = value; }
    /// <summary>Puerto Rico</summary>
    public IMessageDescription PR { get => _pr!; set => this.AssertWritable()._pr = value; }
    /// <summary>Palestinian Authority</summary>
    public IMessageDescription PS { get => _ps!; set => this.AssertWritable()._ps = value; }
    /// <summary>Portugal</summary>
    public IMessageDescription PT { get => _pt!; set => this.AssertWritable()._pt = value; }
    /// <summary>Palau</summary>
    public IMessageDescription PW { get => _pw!; set => this.AssertWritable()._pw = value; }
    /// <summary>Paraguay</summary>
    public IMessageDescription PY { get => _py!; set => this.AssertWritable()._py = value; }
    /// <summary>Qatar</summary>
    public IMessageDescription QA { get => _qa!; set => this.AssertWritable()._qa = value; }
    /// <summary>R&#233;union</summary>
    public IMessageDescription RE { get => _re!; set => this.AssertWritable()._re = value; }
    /// <summary>Romania</summary>
    public IMessageDescription RO { get => _ro!; set => this.AssertWritable()._ro = value; }
    /// <summary>Serbia</summary>
    public IMessageDescription RS { get => _rs!; set => this.AssertWritable()._rs = value; }
    /// <summary>Russia</summary>
    public IMessageDescription RU { get => _ru!; set => this.AssertWritable()._ru = value; }
    /// <summary>Rwanda</summary>
    public IMessageDescription RW { get => _rw!; set => this.AssertWritable()._rw = value; }
    /// <summary>Saudi Arabia</summary>
    public IMessageDescription SA { get => _sa!; set => this.AssertWritable()._sa = value; }
    /// <summary>Solomon Islands</summary>
    public IMessageDescription SB { get => _sb!; set => this.AssertWritable()._sb = value; }
    /// <summary>Seychelles</summary>
    public IMessageDescription SC { get => _sc!; set => this.AssertWritable()._sc = value; }
    /// <summary>Sudan</summary>
    public IMessageDescription SD { get => _sd!; set => this.AssertWritable()._sd = value; }
    /// <summary>Sweden</summary>
    public IMessageDescription SE { get => _se!; set => this.AssertWritable()._se = value; }
    /// <summary>Singapore</summary>
    public IMessageDescription SG { get => _sg!; set => this.AssertWritable()._sg = value; }
    /// <summary>St Helena, Ascension, Tristan da Cunha</summary>
    public IMessageDescription SH { get => _sh!; set => this.AssertWritable()._sh = value; }
    /// <summary>Slovenia</summary>
    public IMessageDescription SI { get => _si!; set => this.AssertWritable()._si = value; }
    /// <summary>Svalbard and Jan Mayen</summary>
    public IMessageDescription SJ { get => _sj!; set => this.AssertWritable()._sj = value; }
    /// <summary>Slovakia</summary>
    public IMessageDescription SK { get => _sk!; set => this.AssertWritable()._sk = value; }
    /// <summary>Sierra Leone</summary>
    public IMessageDescription SL { get => _sl!; set => this.AssertWritable()._sl = value; }
    /// <summary>San Marino</summary>
    public IMessageDescription SM { get => _sm!; set => this.AssertWritable()._sm = value; }
    /// <summary>Senegal</summary>
    public IMessageDescription SN { get => _sn!; set => this.AssertWritable()._sn = value; }
    /// <summary>Somalia</summary>
    public IMessageDescription SO { get => _so!; set => this.AssertWritable()._so = value; }
    /// <summary>Suriname</summary>
    public IMessageDescription SR { get => _sr!; set => this.AssertWritable()._sr = value; }
    /// <summary>South Sudan</summary>
    public IMessageDescription SS { get => _ss!; set => this.AssertWritable()._ss = value; }
    /// <summary>S&#227;o Tom&#233; and Pr&#237;ncipe</summary>
    public IMessageDescription ST { get => _st!; set => this.AssertWritable()._st = value; }
    /// <summary>El Salvador</summary>
    public IMessageDescription SV { get => _sv!; set => this.AssertWritable()._sv = value; }
    /// <summary>Sint Maarten</summary>
    public IMessageDescription SX { get => _sx!; set => this.AssertWritable()._sx = value; }
    /// <summary>Syria</summary>
    public IMessageDescription SY { get => _sy!; set => this.AssertWritable()._sy = value; }
    /// <summary>Swaziland</summary>
    public IMessageDescription SZ { get => _sz!; set => this.AssertWritable()._sz = value; }
    /// <summary>Turks and Caicos Islands</summary>
    public IMessageDescription TC { get => _tc!; set => this.AssertWritable()._tc = value; }
    /// <summary>Chad</summary>
    public IMessageDescription TD { get => _td!; set => this.AssertWritable()._td = value; }
    /// <summary>Togo</summary>
    public IMessageDescription TG { get => _tg!; set => this.AssertWritable()._tg = value; }
    /// <summary>Thailand</summary>
    public IMessageDescription TH { get => _th!; set => this.AssertWritable()._th = value; }
    /// <summary>Tajikistan</summary>
    public IMessageDescription TJ { get => _tj!; set => this.AssertWritable()._tj = value; }
    /// <summary>Tokelau</summary>
    public IMessageDescription TK { get => _tk!; set => this.AssertWritable()._tk = value; }
    /// <summary>Timor-Leste</summary>
    public IMessageDescription TL { get => _tl!; set => this.AssertWritable()._tl = value; }
    /// <summary>Turkmenistan</summary>
    public IMessageDescription TM { get => _tm!; set => this.AssertWritable()._tm = value; }
    /// <summary>Tunisia</summary>
    public IMessageDescription TN { get => _tn!; set => this.AssertWritable()._tn = value; }
    /// <summary>Tonga</summary>
    public IMessageDescription TO { get => _to!; set => this.AssertWritable()._to = value; }
    /// <summary>Turkey</summary>
    public IMessageDescription TR { get => _tr!; set => this.AssertWritable()._tr = value; }
    /// <summary>Trinidad and Tobago</summary>
    public IMessageDescription TT { get => _tt!; set => this.AssertWritable()._tt = value; }
    /// <summary>Tuvalu</summary>
    public IMessageDescription TV { get => _tv!; set => this.AssertWritable()._tv = value; }
    /// <summary>Taiwan</summary>
    public IMessageDescription TW { get => _tw!; set => this.AssertWritable()._tw = value; }
    /// <summary>Tanzania</summary>
    public IMessageDescription TZ { get => _tz!; set => this.AssertWritable()._tz = value; }
    /// <summary>Ukraine</summary>
    public IMessageDescription UA { get => _ua!; set => this.AssertWritable()._ua = value; }
    /// <summary>Uganda</summary>
    public IMessageDescription UG { get => _ug!; set => this.AssertWritable()._ug = value; }
    /// <summary>U.S. Outlying Islands</summary>
    public IMessageDescription UM { get => _um!; set => this.AssertWritable()._um = value; }
    /// <summary>United States</summary>
    public IMessageDescription US { get => _us!; set => this.AssertWritable()._us = value; }
    /// <summary>Uruguay</summary>
    public IMessageDescription UY { get => _uy!; set => this.AssertWritable()._uy = value; }
    /// <summary>Uzbekistan</summary>
    public IMessageDescription UZ { get => _uz!; set => this.AssertWritable()._uz = value; }
    /// <summary>Saint Vincent and the Grenadines</summary>
    public IMessageDescription VC { get => _vc!; set => this.AssertWritable()._vc = value; }
    /// <summary>Bolivarian Republic of Venezuela</summary>
    public IMessageDescription VE { get => _ve!; set => this.AssertWritable()._ve = value; }
    /// <summary>British Virgin Islands</summary>
    public IMessageDescription VG { get => _vg!; set => this.AssertWritable()._vg = value; }
    /// <summary>U.S. Virgin Islands</summary>
    public IMessageDescription VI { get => _vi!; set => this.AssertWritable()._vi = value; }
    /// <summary>Vietnam</summary>
    public IMessageDescription VN { get => _vn!; set => this.AssertWritable()._vn = value; }
    /// <summary>Vanuatu</summary>
    public IMessageDescription VU { get => _vu!; set => this.AssertWritable()._vu = value; }
    /// <summary>Wallis and Futuna</summary>
    public IMessageDescription WF { get => _wf!; set => this.AssertWritable()._wf = value; }
    /// <summary>Samoa</summary>
    public IMessageDescription WS { get => _ws!; set => this.AssertWritable()._ws = value; }
    /// <summary>Kosovo</summary>
    public IMessageDescription XK { get => _xk!; set => this.AssertWritable()._xk = value; }
    /// <summary>Yemen</summary>
    public IMessageDescription YE { get => _ye!; set => this.AssertWritable()._ye = value; }
    /// <summary>Mayotte</summary>
    public IMessageDescription YT { get => _yt!; set => this.AssertWritable()._yt = value; }
    /// <summary>South Africa</summary>
    public IMessageDescription ZA { get => _za!; set => this.AssertWritable()._za = value; }
    /// <summary>Zambia</summary>
    public IMessageDescription ZM { get => _zm!; set => this.AssertWritable()._zm = value; }
    /// <summary>Zimbabwe</summary>
    public IMessageDescription ZW { get => _zw!; set => this.AssertWritable()._zw = value; }

    /// <summary>Initialize fields</summary>
    public override RegionMessages Initialize() 
    {
        base.Initialize();
        Add(__001 = new MessageDescription("mscorlib.Globalization.ri_001", 0x23450AD6, new ParameterlessText("World")).SetSeverity(MessageLevel.Information));
        Add(__029 = new MessageDescription("mscorlib.Globalization.ri_029", 0x23450AD7, new ParameterlessText("Caribbean")).SetSeverity(MessageLevel.Information));
        Add(__150 = new MessageDescription("mscorlib.Globalization.ri_150", 0x23450AD8, new ParameterlessText("Europe")).SetSeverity(MessageLevel.Information));
        Add(__419 = new MessageDescription("mscorlib.Globalization.ri_419", 0x23450AD9, new ParameterlessText("Latin America")).SetSeverity(MessageLevel.Information));
        Add(_ad = new MessageDescription("mscorlib.Globalization.ri_AD", 0x23450ADA, new ParameterlessText("Andorra")).SetSeverity(MessageLevel.Information));
        Add(_ae = new MessageDescription("mscorlib.Globalization.ri_AE", 0x23450ADB, new ParameterlessText("U.A.E.")).SetSeverity(MessageLevel.Information));
        Add(_af = new MessageDescription("mscorlib.Globalization.ri_AF", 0x23450ADC, new ParameterlessText("Afghanistan")).SetSeverity(MessageLevel.Information));
        Add(_ag = new MessageDescription("mscorlib.Globalization.ri_AG", 0x23450ADD, new ParameterlessText("Antigua and Barbuda")).SetSeverity(MessageLevel.Information));
        Add(_ai = new MessageDescription("mscorlib.Globalization.ri_AI", 0x23450ADE, new ParameterlessText("Anguilla")).SetSeverity(MessageLevel.Information));
        Add(_al = new MessageDescription("mscorlib.Globalization.ri_AL", 0x23450ADF, new ParameterlessText("Albania")).SetSeverity(MessageLevel.Information));
        Add(_am = new MessageDescription("mscorlib.Globalization.ri_AM", 0x23450AE0, new ParameterlessText("Armenia")).SetSeverity(MessageLevel.Information));
        Add(_ao = new MessageDescription("mscorlib.Globalization.ri_AO", 0x23450AE1, new ParameterlessText("Angola")).SetSeverity(MessageLevel.Information));
        Add(_ar = new MessageDescription("mscorlib.Globalization.ri_AR", 0x23450AE2, new ParameterlessText("Argentina")).SetSeverity(MessageLevel.Information));
        Add(_as = new MessageDescription("mscorlib.Globalization.ri_AS", 0x23450AE3, new ParameterlessText("American Samoa")).SetSeverity(MessageLevel.Information));
        Add(_at = new MessageDescription("mscorlib.Globalization.ri_AT", 0x23450AE4, new ParameterlessText("Austria")).SetSeverity(MessageLevel.Information));
        Add(_au = new MessageDescription("mscorlib.Globalization.ri_AU", 0x23450AE5, new ParameterlessText("Australia")).SetSeverity(MessageLevel.Information));
        Add(_aw = new MessageDescription("mscorlib.Globalization.ri_AW", 0x23450AE6, new ParameterlessText("Aruba")).SetSeverity(MessageLevel.Information));
        Add(_ax = new MessageDescription("mscorlib.Globalization.ri_AX", 0x23450AE7, new ParameterlessText("Åland Islands")).SetSeverity(MessageLevel.Information));
        Add(_az = new MessageDescription("mscorlib.Globalization.ri_AZ", 0x23450AE8, new ParameterlessText("Azerbaijan")).SetSeverity(MessageLevel.Information));
        Add(_ba = new MessageDescription("mscorlib.Globalization.ri_BA", 0x23450AE9, new ParameterlessText("Bosnia and Herzegovina")).SetSeverity(MessageLevel.Information));
        Add(_bb = new MessageDescription("mscorlib.Globalization.ri_BB", 0x23450AEA, new ParameterlessText("Barbados")).SetSeverity(MessageLevel.Information));
        Add(_bd = new MessageDescription("mscorlib.Globalization.ri_BD", 0x23450AEB, new ParameterlessText("Bangladesh")).SetSeverity(MessageLevel.Information));
        Add(_be = new MessageDescription("mscorlib.Globalization.ri_BE", 0x23450AEC, new ParameterlessText("Belgium")).SetSeverity(MessageLevel.Information));
        Add(_bf = new MessageDescription("mscorlib.Globalization.ri_BF", 0x23450AED, new ParameterlessText("Burkina Faso")).SetSeverity(MessageLevel.Information));
        Add(_bg = new MessageDescription("mscorlib.Globalization.ri_BG", 0x23450AEE, new ParameterlessText("Bulgaria")).SetSeverity(MessageLevel.Information));
        Add(_bh = new MessageDescription("mscorlib.Globalization.ri_BH", 0x23450AEF, new ParameterlessText("Bahrain")).SetSeverity(MessageLevel.Information));
        Add(_bi = new MessageDescription("mscorlib.Globalization.ri_BI", 0x23450AF0, new ParameterlessText("Burundi")).SetSeverity(MessageLevel.Information));
        Add(_bj = new MessageDescription("mscorlib.Globalization.ri_BJ", 0x23450AF1, new ParameterlessText("Benin")).SetSeverity(MessageLevel.Information));
        Add(_bl = new MessageDescription("mscorlib.Globalization.ri_BL", 0x23450AF2, new ParameterlessText("Saint Barthélemy")).SetSeverity(MessageLevel.Information));
        Add(_bm = new MessageDescription("mscorlib.Globalization.ri_BM", 0x23450AF3, new ParameterlessText("Bermuda")).SetSeverity(MessageLevel.Information));
        Add(_bn = new MessageDescription("mscorlib.Globalization.ri_BN", 0x23450AF4, new ParameterlessText("Brunei Darussalam")).SetSeverity(MessageLevel.Information));
        Add(_bo = new MessageDescription("mscorlib.Globalization.ri_BO", 0x23450AF5, new ParameterlessText("Bolivia")).SetSeverity(MessageLevel.Information));
        Add(_bq = new MessageDescription("mscorlib.Globalization.ri_BQ", 0x23450AF6, new ParameterlessText("Bonaire, Sint Eustatius and Saba")).SetSeverity(MessageLevel.Information));
        Add(_br = new MessageDescription("mscorlib.Globalization.ri_BR", 0x23450AF7, new ParameterlessText("Brazil")).SetSeverity(MessageLevel.Information));
        Add(_bs = new MessageDescription("mscorlib.Globalization.ri_BS", 0x23450AF8, new ParameterlessText("Bahamas")).SetSeverity(MessageLevel.Information));
        Add(_bt = new MessageDescription("mscorlib.Globalization.ri_BT", 0x23450AF9, new ParameterlessText("Bhutan")).SetSeverity(MessageLevel.Information));
        Add(_bw = new MessageDescription("mscorlib.Globalization.ri_BW", 0x23450AFA, new ParameterlessText("Botswana")).SetSeverity(MessageLevel.Information));
        Add(_by = new MessageDescription("mscorlib.Globalization.ri_BY", 0x23450AFB, new ParameterlessText("Belarus")).SetSeverity(MessageLevel.Information));
        Add(_bz = new MessageDescription("mscorlib.Globalization.ri_BZ", 0x23450AFC, new ParameterlessText("Belize")).SetSeverity(MessageLevel.Information));
        Add(_ca = new MessageDescription("mscorlib.Globalization.ri_CA", 0x23450AFD, new ParameterlessText("Canada")).SetSeverity(MessageLevel.Information));
        Add(_cc = new MessageDescription("mscorlib.Globalization.ri_CC", 0x23450AFE, new ParameterlessText("Cocos (Keeling) Islands")).SetSeverity(MessageLevel.Information));
        Add(_cd = new MessageDescription("mscorlib.Globalization.ri_CD", 0x23450AFF, new ParameterlessText("Congo (DRC)")).SetSeverity(MessageLevel.Information));
        Add(_cf = new MessageDescription("mscorlib.Globalization.ri_CF", 0x23450B00, new ParameterlessText("Central African Republic")).SetSeverity(MessageLevel.Information));
        Add(_cg = new MessageDescription("mscorlib.Globalization.ri_CG", 0x23450B01, new ParameterlessText("Congo")).SetSeverity(MessageLevel.Information));
        Add(_ch = new MessageDescription("mscorlib.Globalization.ri_CH", 0x23450B02, new ParameterlessText("Switzerland")).SetSeverity(MessageLevel.Information));
        Add(_ci = new MessageDescription("mscorlib.Globalization.ri_CI", 0x23450B03, new ParameterlessText("Côte d’Ivoire")).SetSeverity(MessageLevel.Information));
        Add(_ck = new MessageDescription("mscorlib.Globalization.ri_CK", 0x23450B04, new ParameterlessText("Cook Islands")).SetSeverity(MessageLevel.Information));
        Add(_cl = new MessageDescription("mscorlib.Globalization.ri_CL", 0x23450B05, new ParameterlessText("Chile")).SetSeverity(MessageLevel.Information));
        Add(_cm = new MessageDescription("mscorlib.Globalization.ri_CM", 0x23450B06, new ParameterlessText("Cameroon")).SetSeverity(MessageLevel.Information));
        Add(_cn = new MessageDescription("mscorlib.Globalization.ri_CN", 0x23450B07, new ParameterlessText("People's Republic of China")).SetSeverity(MessageLevel.Information));
        Add(_co = new MessageDescription("mscorlib.Globalization.ri_CO", 0x23450B08, new ParameterlessText("Colombia")).SetSeverity(MessageLevel.Information));
        Add(_cr = new MessageDescription("mscorlib.Globalization.ri_CR", 0x23450B09, new ParameterlessText("Costa Rica")).SetSeverity(MessageLevel.Information));
        Add(_cs = new MessageDescription("mscorlib.Globalization.ri_CS", 0x23450B0A, new ParameterlessText("Serbia and Montenegro (Former)")).SetSeverity(MessageLevel.Information));
        Add(_cu = new MessageDescription("mscorlib.Globalization.ri_CU", 0x23450B0B, new ParameterlessText("Cuba")).SetSeverity(MessageLevel.Information));
        Add(_cv = new MessageDescription("mscorlib.Globalization.ri_CV", 0x23450B0C, new ParameterlessText("Cabo Verde")).SetSeverity(MessageLevel.Information));
        Add(_cw = new MessageDescription("mscorlib.Globalization.ri_CW", 0x23450B0D, new ParameterlessText("Curaçao")).SetSeverity(MessageLevel.Information));
        Add(_cx = new MessageDescription("mscorlib.Globalization.ri_CX", 0x23450B0E, new ParameterlessText("Christmas Island")).SetSeverity(MessageLevel.Information));
        Add(_cy = new MessageDescription("mscorlib.Globalization.ri_CY", 0x23450B0F, new ParameterlessText("Cyprus")).SetSeverity(MessageLevel.Information));
        Add(_cz = new MessageDescription("mscorlib.Globalization.ri_CZ", 0x23450B10, new ParameterlessText("Czech Republic")).SetSeverity(MessageLevel.Information));
        Add(_de = new MessageDescription("mscorlib.Globalization.ri_DE", 0x23450B11, new ParameterlessText("Germany")).SetSeverity(MessageLevel.Information));
        Add(_dj = new MessageDescription("mscorlib.Globalization.ri_DJ", 0x23450B12, new ParameterlessText("Djibouti")).SetSeverity(MessageLevel.Information));
        Add(_dk = new MessageDescription("mscorlib.Globalization.ri_DK", 0x23450B13, new ParameterlessText("Denmark")).SetSeverity(MessageLevel.Information));
        Add(_dm = new MessageDescription("mscorlib.Globalization.ri_DM", 0x23450B14, new ParameterlessText("Dominica")).SetSeverity(MessageLevel.Information));
        Add(_do = new MessageDescription("mscorlib.Globalization.ri_DO", 0x23450B15, new ParameterlessText("Dominican Republic")).SetSeverity(MessageLevel.Information));
        Add(_dz = new MessageDescription("mscorlib.Globalization.ri_DZ", 0x23450B16, new ParameterlessText("Algeria")).SetSeverity(MessageLevel.Information));
        Add(_ec = new MessageDescription("mscorlib.Globalization.ri_EC", 0x23450B17, new ParameterlessText("Ecuador")).SetSeverity(MessageLevel.Information));
        Add(_ee = new MessageDescription("mscorlib.Globalization.ri_EE", 0x23450B18, new ParameterlessText("Estonia")).SetSeverity(MessageLevel.Information));
        Add(_eg = new MessageDescription("mscorlib.Globalization.ri_EG", 0x23450B19, new ParameterlessText("Egypt")).SetSeverity(MessageLevel.Information));
        Add(_er = new MessageDescription("mscorlib.Globalization.ri_ER", 0x23450B1A, new ParameterlessText("Eritrea")).SetSeverity(MessageLevel.Information));
        Add(_es = new MessageDescription("mscorlib.Globalization.ri_ES", 0x23450B1B, new ParameterlessText("Spain")).SetSeverity(MessageLevel.Information));
        Add(_et = new MessageDescription("mscorlib.Globalization.ri_ET", 0x23450B1C, new ParameterlessText("Ethiopia")).SetSeverity(MessageLevel.Information));
        Add(_fi = new MessageDescription("mscorlib.Globalization.ri_FI", 0x23450B1D, new ParameterlessText("Finland")).SetSeverity(MessageLevel.Information));
        Add(_fj = new MessageDescription("mscorlib.Globalization.ri_FJ", 0x23450B1E, new ParameterlessText("Fiji")).SetSeverity(MessageLevel.Information));
        Add(_fk = new MessageDescription("mscorlib.Globalization.ri_FK", 0x23450B1F, new ParameterlessText("Falkland Islands")).SetSeverity(MessageLevel.Information));
        Add(_fm = new MessageDescription("mscorlib.Globalization.ri_FM", 0x23450B20, new ParameterlessText("Micronesia")).SetSeverity(MessageLevel.Information));
        Add(_fo = new MessageDescription("mscorlib.Globalization.ri_FO", 0x23450B21, new ParameterlessText("Faroe Islands")).SetSeverity(MessageLevel.Information));
        Add(_fr = new MessageDescription("mscorlib.Globalization.ri_FR", 0x23450B22, new ParameterlessText("France")).SetSeverity(MessageLevel.Information));
        Add(_ga = new MessageDescription("mscorlib.Globalization.ri_GA", 0x23450B23, new ParameterlessText("Gabon")).SetSeverity(MessageLevel.Information));
        Add(_gb = new MessageDescription("mscorlib.Globalization.ri_GB", 0x23450B24, new ParameterlessText("United Kingdom")).SetSeverity(MessageLevel.Information));
        Add(_gd = new MessageDescription("mscorlib.Globalization.ri_GD", 0x23450B25, new ParameterlessText("Grenada")).SetSeverity(MessageLevel.Information));
        Add(_ge = new MessageDescription("mscorlib.Globalization.ri_GE", 0x23450B26, new ParameterlessText("Georgia")).SetSeverity(MessageLevel.Information));
        Add(_gf = new MessageDescription("mscorlib.Globalization.ri_GF", 0x23450B27, new ParameterlessText("French Guiana")).SetSeverity(MessageLevel.Information));
        Add(_gg = new MessageDescription("mscorlib.Globalization.ri_GG", 0x23450B28, new ParameterlessText("Guernsey")).SetSeverity(MessageLevel.Information));
        Add(_gh = new MessageDescription("mscorlib.Globalization.ri_GH", 0x23450B29, new ParameterlessText("Ghana")).SetSeverity(MessageLevel.Information));
        Add(_gi = new MessageDescription("mscorlib.Globalization.ri_GI", 0x23450B2A, new ParameterlessText("Gibraltar")).SetSeverity(MessageLevel.Information));
        Add(_gl = new MessageDescription("mscorlib.Globalization.ri_GL", 0x23450B2B, new ParameterlessText("Greenland")).SetSeverity(MessageLevel.Information));
        Add(_gm = new MessageDescription("mscorlib.Globalization.ri_GM", 0x23450B2C, new ParameterlessText("Gambia")).SetSeverity(MessageLevel.Information));
        Add(_gn = new MessageDescription("mscorlib.Globalization.ri_GN", 0x23450B2D, new ParameterlessText("Guinea")).SetSeverity(MessageLevel.Information));
        Add(_gp = new MessageDescription("mscorlib.Globalization.ri_GP", 0x23450B2E, new ParameterlessText("Guadeloupe")).SetSeverity(MessageLevel.Information));
        Add(_gq = new MessageDescription("mscorlib.Globalization.ri_GQ", 0x23450B2F, new ParameterlessText("Equatorial Guinea")).SetSeverity(MessageLevel.Information));
        Add(_gr = new MessageDescription("mscorlib.Globalization.ri_GR", 0x23450B30, new ParameterlessText("Greece")).SetSeverity(MessageLevel.Information));
        Add(_gt = new MessageDescription("mscorlib.Globalization.ri_GT", 0x23450B31, new ParameterlessText("Guatemala")).SetSeverity(MessageLevel.Information));
        Add(_gu = new MessageDescription("mscorlib.Globalization.ri_GU", 0x23450B32, new ParameterlessText("Guam")).SetSeverity(MessageLevel.Information));
        Add(_gw = new MessageDescription("mscorlib.Globalization.ri_GW", 0x23450B33, new ParameterlessText("Guinea-Bissau")).SetSeverity(MessageLevel.Information));
        Add(_gy = new MessageDescription("mscorlib.Globalization.ri_GY", 0x23450B34, new ParameterlessText("Guyana")).SetSeverity(MessageLevel.Information));
        Add(_hk = new MessageDescription("mscorlib.Globalization.ri_HK", 0x23450B35, new ParameterlessText("Hong Kong S.A.R.")).SetSeverity(MessageLevel.Information));
        Add(_hn = new MessageDescription("mscorlib.Globalization.ri_HN", 0x23450B36, new ParameterlessText("Honduras")).SetSeverity(MessageLevel.Information));
        Add(_hr = new MessageDescription("mscorlib.Globalization.ri_HR", 0x23450B37, new ParameterlessText("Croatia")).SetSeverity(MessageLevel.Information));
        Add(_ht = new MessageDescription("mscorlib.Globalization.ri_HT", 0x23450B38, new ParameterlessText("Haiti")).SetSeverity(MessageLevel.Information));
        Add(_hu = new MessageDescription("mscorlib.Globalization.ri_HU", 0x23450B39, new ParameterlessText("Hungary")).SetSeverity(MessageLevel.Information));
        Add(_id = new MessageDescription("mscorlib.Globalization.ri_ID", 0x23450B3A, new ParameterlessText("Indonesia")).SetSeverity(MessageLevel.Information));
        Add(_ie = new MessageDescription("mscorlib.Globalization.ri_IE", 0x23450B3B, new ParameterlessText("Ireland")).SetSeverity(MessageLevel.Information));
        Add(_il = new MessageDescription("mscorlib.Globalization.ri_IL", 0x23450B3C, new ParameterlessText("Israel")).SetSeverity(MessageLevel.Information));
        Add(_im = new MessageDescription("mscorlib.Globalization.ri_IM", 0x23450B3E, new ParameterlessText("Isle of Man")).SetSeverity(MessageLevel.Information));
        Add(_in = new MessageDescription("mscorlib.Globalization.ri_IN", 0x23450B3D, new ParameterlessText("India")).SetSeverity(MessageLevel.Information));
        Add(_io = new MessageDescription("mscorlib.Globalization.ri_IO", 0x23450B3F, new ParameterlessText("British Indian Ocean Territory")).SetSeverity(MessageLevel.Information));
        Add(_iq = new MessageDescription("mscorlib.Globalization.ri_IQ", 0x23450B40, new ParameterlessText("Iraq")).SetSeverity(MessageLevel.Information));
        Add(_ir = new MessageDescription("mscorlib.Globalization.ri_IR", 0x23450B41, new ParameterlessText("Iran")).SetSeverity(MessageLevel.Information));
        Add(_is = new MessageDescription("mscorlib.Globalization.ri_IS", 0x23450B42, new ParameterlessText("Iceland")).SetSeverity(MessageLevel.Information));
        Add(_it = new MessageDescription("mscorlib.Globalization.ri_IT", 0x23450B43, new ParameterlessText("Italy")).SetSeverity(MessageLevel.Information));
        Add(_iv = new MessageDescription("mscorlib.Globalization.ri_IV", 0x23450B44, new ParameterlessText("Invariant Country")).SetSeverity(MessageLevel.Information));
        Add(_je = new MessageDescription("mscorlib.Globalization.ri_JE", 0x23450B45, new ParameterlessText("Jersey")).SetSeverity(MessageLevel.Information));
        Add(_jm = new MessageDescription("mscorlib.Globalization.ri_JM", 0x23450B46, new ParameterlessText("Jamaica")).SetSeverity(MessageLevel.Information));
        Add(_jo = new MessageDescription("mscorlib.Globalization.ri_JO", 0x23450B47, new ParameterlessText("Jordan")).SetSeverity(MessageLevel.Information));
        Add(_jp = new MessageDescription("mscorlib.Globalization.ri_JP", 0x23450B48, new ParameterlessText("Japan")).SetSeverity(MessageLevel.Information));
        Add(_ke = new MessageDescription("mscorlib.Globalization.ri_KE", 0x23450B49, new ParameterlessText("Kenya")).SetSeverity(MessageLevel.Information));
        Add(_kg = new MessageDescription("mscorlib.Globalization.ri_KG", 0x23450B4A, new ParameterlessText("Kyrgyzstan")).SetSeverity(MessageLevel.Information));
        Add(_kh = new MessageDescription("mscorlib.Globalization.ri_KH", 0x23450B4B, new ParameterlessText("Cambodia")).SetSeverity(MessageLevel.Information));
        Add(_ki = new MessageDescription("mscorlib.Globalization.ri_KI", 0x23450B4C, new ParameterlessText("Kiribati")).SetSeverity(MessageLevel.Information));
        Add(_km = new MessageDescription("mscorlib.Globalization.ri_KM", 0x23450B4D, new ParameterlessText("Comoros")).SetSeverity(MessageLevel.Information));
        Add(_kn = new MessageDescription("mscorlib.Globalization.ri_KN", 0x23450B4E, new ParameterlessText("Saint Kitts and Nevis")).SetSeverity(MessageLevel.Information));
        Add(_kr = new MessageDescription("mscorlib.Globalization.ri_KR", 0x23450B4F, new ParameterlessText("Korea")).SetSeverity(MessageLevel.Information));
        Add(_kw = new MessageDescription("mscorlib.Globalization.ri_KW", 0x23450B50, new ParameterlessText("Kuwait")).SetSeverity(MessageLevel.Information));
        Add(_ky = new MessageDescription("mscorlib.Globalization.ri_KY", 0x23450B51, new ParameterlessText("Cayman Islands")).SetSeverity(MessageLevel.Information));
        Add(_kz = new MessageDescription("mscorlib.Globalization.ri_KZ", 0x23450B52, new ParameterlessText("Kazakhstan")).SetSeverity(MessageLevel.Information));
        Add(_la = new MessageDescription("mscorlib.Globalization.ri_LA", 0x23450B53, new ParameterlessText("Lao P.D.R.")).SetSeverity(MessageLevel.Information));
        Add(_lb = new MessageDescription("mscorlib.Globalization.ri_LB", 0x23450B54, new ParameterlessText("Lebanon")).SetSeverity(MessageLevel.Information));
        Add(_lc = new MessageDescription("mscorlib.Globalization.ri_LC", 0x23450B55, new ParameterlessText("Saint Lucia")).SetSeverity(MessageLevel.Information));
        Add(_li = new MessageDescription("mscorlib.Globalization.ri_LI", 0x23450B56, new ParameterlessText("Liechtenstein")).SetSeverity(MessageLevel.Information));
        Add(_lk = new MessageDescription("mscorlib.Globalization.ri_LK", 0x23450B57, new ParameterlessText("Sri Lanka")).SetSeverity(MessageLevel.Information));
        Add(_lr = new MessageDescription("mscorlib.Globalization.ri_LR", 0x23450B58, new ParameterlessText("Liberia")).SetSeverity(MessageLevel.Information));
        Add(_ls = new MessageDescription("mscorlib.Globalization.ri_LS", 0x23450B59, new ParameterlessText("Lesotho")).SetSeverity(MessageLevel.Information));
        Add(_lt = new MessageDescription("mscorlib.Globalization.ri_LT", 0x23450B5A, new ParameterlessText("Lithuania")).SetSeverity(MessageLevel.Information));
        Add(_lu = new MessageDescription("mscorlib.Globalization.ri_LU", 0x23450B5B, new ParameterlessText("Luxembourg")).SetSeverity(MessageLevel.Information));
        Add(_lv = new MessageDescription("mscorlib.Globalization.ri_LV", 0x23450B5C, new ParameterlessText("Latvia")).SetSeverity(MessageLevel.Information));
        Add(_ly = new MessageDescription("mscorlib.Globalization.ri_LY", 0x23450B5D, new ParameterlessText("Libya")).SetSeverity(MessageLevel.Information));
        Add(_ma = new MessageDescription("mscorlib.Globalization.ri_MA", 0x23450B5E, new ParameterlessText("Morocco")).SetSeverity(MessageLevel.Information));
        Add(_mc = new MessageDescription("mscorlib.Globalization.ri_MC", 0x23450B5F, new ParameterlessText("Principality of Monaco")).SetSeverity(MessageLevel.Information));
        Add(_md = new MessageDescription("mscorlib.Globalization.ri_MD", 0x23450B60, new ParameterlessText("Moldova")).SetSeverity(MessageLevel.Information));
        Add(_me = new MessageDescription("mscorlib.Globalization.ri_ME", 0x23450B61, new ParameterlessText("Montenegro")).SetSeverity(MessageLevel.Information));
        Add(_mf = new MessageDescription("mscorlib.Globalization.ri_MF", 0x23450B62, new ParameterlessText("Saint Martin")).SetSeverity(MessageLevel.Information));
        Add(_mg = new MessageDescription("mscorlib.Globalization.ri_MG", 0x23450B63, new ParameterlessText("Madagascar")).SetSeverity(MessageLevel.Information));
        Add(_mh = new MessageDescription("mscorlib.Globalization.ri_MH", 0x23450B64, new ParameterlessText("Marshall Islands")).SetSeverity(MessageLevel.Information));
        Add(_mk = new MessageDescription("mscorlib.Globalization.ri_MK", 0x23450B65, new ParameterlessText("North Macedonia")).SetSeverity(MessageLevel.Information));
        Add(_ml = new MessageDescription("mscorlib.Globalization.ri_ML", 0x23450B66, new ParameterlessText("Mali")).SetSeverity(MessageLevel.Information));
        Add(_mm = new MessageDescription("mscorlib.Globalization.ri_MM", 0x23450B67, new ParameterlessText("Myanmar")).SetSeverity(MessageLevel.Information));
        Add(_mn = new MessageDescription("mscorlib.Globalization.ri_MN", 0x23450B68, new ParameterlessText("Mongolia")).SetSeverity(MessageLevel.Information));
        Add(_mo = new MessageDescription("mscorlib.Globalization.ri_MO", 0x23450B69, new ParameterlessText("Macao S.A.R.")).SetSeverity(MessageLevel.Information));
        Add(_mp = new MessageDescription("mscorlib.Globalization.ri_MP", 0x23450B6A, new ParameterlessText("Northern Mariana Islands")).SetSeverity(MessageLevel.Information));
        Add(_mq = new MessageDescription("mscorlib.Globalization.ri_MQ", 0x23450B6B, new ParameterlessText("Martinique")).SetSeverity(MessageLevel.Information));
        Add(_mr = new MessageDescription("mscorlib.Globalization.ri_MR", 0x23450B6C, new ParameterlessText("Mauritania")).SetSeverity(MessageLevel.Information));
        Add(_ms = new MessageDescription("mscorlib.Globalization.ri_MS", 0x23450B6D, new ParameterlessText("Montserrat")).SetSeverity(MessageLevel.Information));
        Add(_mt = new MessageDescription("mscorlib.Globalization.ri_MT", 0x23450B6E, new ParameterlessText("Malta")).SetSeverity(MessageLevel.Information));
        Add(_mu = new MessageDescription("mscorlib.Globalization.ri_MU", 0x23450B6F, new ParameterlessText("Mauritius")).SetSeverity(MessageLevel.Information));
        Add(_mv = new MessageDescription("mscorlib.Globalization.ri_MV", 0x23450B70, new ParameterlessText("Maldives")).SetSeverity(MessageLevel.Information));
        Add(_mw = new MessageDescription("mscorlib.Globalization.ri_MW", 0x23450B71, new ParameterlessText("Malawi")).SetSeverity(MessageLevel.Information));
        Add(_mx = new MessageDescription("mscorlib.Globalization.ri_MX", 0x23450B72, new ParameterlessText("Mexico")).SetSeverity(MessageLevel.Information));
        Add(_my = new MessageDescription("mscorlib.Globalization.ri_MY", 0x23450B73, new ParameterlessText("Malaysia")).SetSeverity(MessageLevel.Information));
        Add(_mz = new MessageDescription("mscorlib.Globalization.ri_MZ", 0x23450B74, new ParameterlessText("Mozambique")).SetSeverity(MessageLevel.Information));
        Add(_na = new MessageDescription("mscorlib.Globalization.ri_NA", 0x23450B75, new ParameterlessText("Namibia")).SetSeverity(MessageLevel.Information));
        Add(_nc = new MessageDescription("mscorlib.Globalization.ri_NC", 0x23450B76, new ParameterlessText("New Caledonia")).SetSeverity(MessageLevel.Information));
        Add(_ne = new MessageDescription("mscorlib.Globalization.ri_NE", 0x23450B77, new ParameterlessText("Niger")).SetSeverity(MessageLevel.Information));
        Add(_nf = new MessageDescription("mscorlib.Globalization.ri_NF", 0x23450B78, new ParameterlessText("Norfolk Island")).SetSeverity(MessageLevel.Information));
        Add(_ng = new MessageDescription("mscorlib.Globalization.ri_NG", 0x23450B79, new ParameterlessText("Nigeria")).SetSeverity(MessageLevel.Information));
        Add(_ni = new MessageDescription("mscorlib.Globalization.ri_NI", 0x23450B7A, new ParameterlessText("Nicaragua")).SetSeverity(MessageLevel.Information));
        Add(_nl = new MessageDescription("mscorlib.Globalization.ri_NL", 0x23450B7B, new ParameterlessText("Netherlands")).SetSeverity(MessageLevel.Information));
        Add(_no = new MessageDescription("mscorlib.Globalization.ri_NO", 0x23450B7C, new ParameterlessText("Norway")).SetSeverity(MessageLevel.Information));
        Add(_np = new MessageDescription("mscorlib.Globalization.ri_NP", 0x23450B7D, new ParameterlessText("Nepal")).SetSeverity(MessageLevel.Information));
        Add(_nr = new MessageDescription("mscorlib.Globalization.ri_NR", 0x23450B7E, new ParameterlessText("Nauru")).SetSeverity(MessageLevel.Information));
        Add(_nu = new MessageDescription("mscorlib.Globalization.ri_NU", 0x23450B7F, new ParameterlessText("Niue")).SetSeverity(MessageLevel.Information));
        Add(_nz = new MessageDescription("mscorlib.Globalization.ri_NZ", 0x23450B80, new ParameterlessText("New Zealand")).SetSeverity(MessageLevel.Information));
        Add(_om = new MessageDescription("mscorlib.Globalization.ri_OM", 0x23450B81, new ParameterlessText("Oman")).SetSeverity(MessageLevel.Information));
        Add(_pa = new MessageDescription("mscorlib.Globalization.ri_PA", 0x23450B82, new ParameterlessText("Panama")).SetSeverity(MessageLevel.Information));
        Add(_pe = new MessageDescription("mscorlib.Globalization.ri_PE", 0x23450B83, new ParameterlessText("Peru")).SetSeverity(MessageLevel.Information));
        Add(_pf = new MessageDescription("mscorlib.Globalization.ri_PF", 0x23450B84, new ParameterlessText("French Polynesia")).SetSeverity(MessageLevel.Information));
        Add(_pg = new MessageDescription("mscorlib.Globalization.ri_PG", 0x23450B85, new ParameterlessText("Papua New Guinea")).SetSeverity(MessageLevel.Information));
        Add(_ph = new MessageDescription("mscorlib.Globalization.ri_PH", 0x23450B86, new ParameterlessText("Philippines")).SetSeverity(MessageLevel.Information));
        Add(_pk = new MessageDescription("mscorlib.Globalization.ri_PK", 0x23450B87, new ParameterlessText("Islamic Republic of Pakistan")).SetSeverity(MessageLevel.Information));
        Add(_pl = new MessageDescription("mscorlib.Globalization.ri_PL", 0x23450B88, new ParameterlessText("Poland")).SetSeverity(MessageLevel.Information));
        Add(_pm = new MessageDescription("mscorlib.Globalization.ri_PM", 0x23450B89, new ParameterlessText("Saint Pierre and Miquelon")).SetSeverity(MessageLevel.Information));
        Add(_pn = new MessageDescription("mscorlib.Globalization.ri_PN", 0x23450B8A, new ParameterlessText("Pitcairn Islands")).SetSeverity(MessageLevel.Information));
        Add(_pr = new MessageDescription("mscorlib.Globalization.ri_PR", 0x23450B8B, new ParameterlessText("Puerto Rico")).SetSeverity(MessageLevel.Information));
        Add(_ps = new MessageDescription("mscorlib.Globalization.ri_PS", 0x23450B8C, new ParameterlessText("Palestinian Authority")).SetSeverity(MessageLevel.Information));
        Add(_pt = new MessageDescription("mscorlib.Globalization.ri_PT", 0x23450B8D, new ParameterlessText("Portugal")).SetSeverity(MessageLevel.Information));
        Add(_pw = new MessageDescription("mscorlib.Globalization.ri_PW", 0x23450B8E, new ParameterlessText("Palau")).SetSeverity(MessageLevel.Information));
        Add(_py = new MessageDescription("mscorlib.Globalization.ri_PY", 0x23450B8F, new ParameterlessText("Paraguay")).SetSeverity(MessageLevel.Information));
        Add(_qa = new MessageDescription("mscorlib.Globalization.ri_QA", 0x23450B90, new ParameterlessText("Qatar")).SetSeverity(MessageLevel.Information));
        Add(_re = new MessageDescription("mscorlib.Globalization.ri_RE", 0x23450B91, new ParameterlessText("Réunion")).SetSeverity(MessageLevel.Information));
        Add(_ro = new MessageDescription("mscorlib.Globalization.ri_RO", 0x23450B92, new ParameterlessText("Romania")).SetSeverity(MessageLevel.Information));
        Add(_rs = new MessageDescription("mscorlib.Globalization.ri_RS", 0x23450B93, new ParameterlessText("Serbia")).SetSeverity(MessageLevel.Information));
        Add(_ru = new MessageDescription("mscorlib.Globalization.ri_RU", 0x23450B94, new ParameterlessText("Russia")).SetSeverity(MessageLevel.Information));
        Add(_rw = new MessageDescription("mscorlib.Globalization.ri_RW", 0x23450B95, new ParameterlessText("Rwanda")).SetSeverity(MessageLevel.Information));
        Add(_sa = new MessageDescription("mscorlib.Globalization.ri_SA", 0x23450B96, new ParameterlessText("Saudi Arabia")).SetSeverity(MessageLevel.Information));
        Add(_sb = new MessageDescription("mscorlib.Globalization.ri_SB", 0x23450B97, new ParameterlessText("Solomon Islands")).SetSeverity(MessageLevel.Information));
        Add(_sc = new MessageDescription("mscorlib.Globalization.ri_SC", 0x23450B98, new ParameterlessText("Seychelles")).SetSeverity(MessageLevel.Information));
        Add(_sd = new MessageDescription("mscorlib.Globalization.ri_SD", 0x23450B99, new ParameterlessText("Sudan")).SetSeverity(MessageLevel.Information));
        Add(_se = new MessageDescription("mscorlib.Globalization.ri_SE", 0x23450B9A, new ParameterlessText("Sweden")).SetSeverity(MessageLevel.Information));
        Add(_sg = new MessageDescription("mscorlib.Globalization.ri_SG", 0x23450B9B, new ParameterlessText("Singapore")).SetSeverity(MessageLevel.Information));
        Add(_sh = new MessageDescription("mscorlib.Globalization.ri_SH", 0x23450B9C, new ParameterlessText("St Helena, Ascension, Tristan da Cunha")).SetSeverity(MessageLevel.Information));
        Add(_si = new MessageDescription("mscorlib.Globalization.ri_SI", 0x23450B9D, new ParameterlessText("Slovenia")).SetSeverity(MessageLevel.Information));
        Add(_sj = new MessageDescription("mscorlib.Globalization.ri_SJ", 0x23450B9E, new ParameterlessText("Svalbard and Jan Mayen")).SetSeverity(MessageLevel.Information));
        Add(_sk = new MessageDescription("mscorlib.Globalization.ri_SK", 0x23450B9F, new ParameterlessText("Slovakia")).SetSeverity(MessageLevel.Information));
        Add(_sl = new MessageDescription("mscorlib.Globalization.ri_SL", 0x23450BA0, new ParameterlessText("Sierra Leone")).SetSeverity(MessageLevel.Information));
        Add(_sm = new MessageDescription("mscorlib.Globalization.ri_SM", 0x23450BA1, new ParameterlessText("San Marino")).SetSeverity(MessageLevel.Information));
        Add(_sn = new MessageDescription("mscorlib.Globalization.ri_SN", 0x23450BA2, new ParameterlessText("Senegal")).SetSeverity(MessageLevel.Information));
        Add(_so = new MessageDescription("mscorlib.Globalization.ri_SO", 0x23450BA3, new ParameterlessText("Somalia")).SetSeverity(MessageLevel.Information));
        Add(_sr = new MessageDescription("mscorlib.Globalization.ri_SR", 0x23450BA4, new ParameterlessText("Suriname")).SetSeverity(MessageLevel.Information));
        Add(_ss = new MessageDescription("mscorlib.Globalization.ri_SS", 0x23450BA5, new ParameterlessText("South Sudan")).SetSeverity(MessageLevel.Information));
        Add(_st = new MessageDescription("mscorlib.Globalization.ri_ST", 0x23450BA6, new ParameterlessText("São Tomé and Príncipe")).SetSeverity(MessageLevel.Information));
        Add(_sv = new MessageDescription("mscorlib.Globalization.ri_SV", 0x23450BA7, new ParameterlessText("El Salvador")).SetSeverity(MessageLevel.Information));
        Add(_sx = new MessageDescription("mscorlib.Globalization.ri_SX", 0x23450BA8, new ParameterlessText("Sint Maarten")).SetSeverity(MessageLevel.Information));
        Add(_sy = new MessageDescription("mscorlib.Globalization.ri_SY", 0x23450BA9, new ParameterlessText("Syria")).SetSeverity(MessageLevel.Information));
        Add(_sz = new MessageDescription("mscorlib.Globalization.ri_SZ", 0x23450BAA, new ParameterlessText("Swaziland")).SetSeverity(MessageLevel.Information));
        Add(_tc = new MessageDescription("mscorlib.Globalization.ri_TC", 0x23450BAB, new ParameterlessText("Turks and Caicos Islands")).SetSeverity(MessageLevel.Information));
        Add(_td = new MessageDescription("mscorlib.Globalization.ri_TD", 0x23450BAC, new ParameterlessText("Chad")).SetSeverity(MessageLevel.Information));
        Add(_tg = new MessageDescription("mscorlib.Globalization.ri_TG", 0x23450BAD, new ParameterlessText("Togo")).SetSeverity(MessageLevel.Information));
        Add(_th = new MessageDescription("mscorlib.Globalization.ri_TH", 0x23450BAE, new ParameterlessText("Thailand")).SetSeverity(MessageLevel.Information));
        Add(_tj = new MessageDescription("mscorlib.Globalization.ri_TJ", 0x23450BAF, new ParameterlessText("Tajikistan")).SetSeverity(MessageLevel.Information));
        Add(_tk = new MessageDescription("mscorlib.Globalization.ri_TK", 0x23450BB0, new ParameterlessText("Tokelau")).SetSeverity(MessageLevel.Information));
        Add(_tl = new MessageDescription("mscorlib.Globalization.ri_TL", 0x23450BB1, new ParameterlessText("Timor-Leste")).SetSeverity(MessageLevel.Information));
        Add(_tm = new MessageDescription("mscorlib.Globalization.ri_TM", 0x23450BB2, new ParameterlessText("Turkmenistan")).SetSeverity(MessageLevel.Information));
        Add(_tn = new MessageDescription("mscorlib.Globalization.ri_TN", 0x23450BB3, new ParameterlessText("Tunisia")).SetSeverity(MessageLevel.Information));
        Add(_to = new MessageDescription("mscorlib.Globalization.ri_TO", 0x23450BB4, new ParameterlessText("Tonga")).SetSeverity(MessageLevel.Information));
        Add(_tr = new MessageDescription("mscorlib.Globalization.ri_TR", 0x23450BB5, new ParameterlessText("Turkey")).SetSeverity(MessageLevel.Information));
        Add(_tt = new MessageDescription("mscorlib.Globalization.ri_TT", 0x23450BB6, new ParameterlessText("Trinidad and Tobago")).SetSeverity(MessageLevel.Information));
        Add(_tv = new MessageDescription("mscorlib.Globalization.ri_TV", 0x23450BB7, new ParameterlessText("Tuvalu")).SetSeverity(MessageLevel.Information));
        Add(_tw = new MessageDescription("mscorlib.Globalization.ri_TW", 0x23450BB8, new ParameterlessText("Taiwan")).SetSeverity(MessageLevel.Information));
        Add(_tz = new MessageDescription("mscorlib.Globalization.ri_TZ", 0x23450BB9, new ParameterlessText("Tanzania")).SetSeverity(MessageLevel.Information));
        Add(_ua = new MessageDescription("mscorlib.Globalization.ri_UA", 0x23450BBA, new ParameterlessText("Ukraine")).SetSeverity(MessageLevel.Information));
        Add(_ug = new MessageDescription("mscorlib.Globalization.ri_UG", 0x23450BBB, new ParameterlessText("Uganda")).SetSeverity(MessageLevel.Information));
        Add(_um = new MessageDescription("mscorlib.Globalization.ri_UM", 0x23450BBC, new ParameterlessText("U.S. Outlying Islands")).SetSeverity(MessageLevel.Information));
        Add(_us = new MessageDescription("mscorlib.Globalization.ri_US", 0x23450BBD, new ParameterlessText("United States")).SetSeverity(MessageLevel.Information));
        Add(_uy = new MessageDescription("mscorlib.Globalization.ri_UY", 0x23450BBE, new ParameterlessText("Uruguay")).SetSeverity(MessageLevel.Information));
        Add(_uz = new MessageDescription("mscorlib.Globalization.ri_UZ", 0x23450BBF, new ParameterlessText("Uzbekistan")).SetSeverity(MessageLevel.Information));
        Add(_vc = new MessageDescription("mscorlib.Globalization.ri_VC", 0x23450BC0, new ParameterlessText("Saint Vincent and the Grenadines")).SetSeverity(MessageLevel.Information));
        Add(_ve = new MessageDescription("mscorlib.Globalization.ri_VE", 0x23450BC1, new ParameterlessText("Bolivarian Republic of Venezuela")).SetSeverity(MessageLevel.Information));
        Add(_vg = new MessageDescription("mscorlib.Globalization.ri_VG", 0x23450BC2, new ParameterlessText("British Virgin Islands")).SetSeverity(MessageLevel.Information));
        Add(_vi = new MessageDescription("mscorlib.Globalization.ri_VI", 0x23450BC3, new ParameterlessText("U.S. Virgin Islands")).SetSeverity(MessageLevel.Information));
        Add(_vn = new MessageDescription("mscorlib.Globalization.ri_VN", 0x23450BC4, new ParameterlessText("Vietnam")).SetSeverity(MessageLevel.Information));
        Add(_vu = new MessageDescription("mscorlib.Globalization.ri_VU", 0x23450BC5, new ParameterlessText("Vanuatu")).SetSeverity(MessageLevel.Information));
        Add(_wf = new MessageDescription("mscorlib.Globalization.ri_WF", 0x23450BC6, new ParameterlessText("Wallis and Futuna")).SetSeverity(MessageLevel.Information));
        Add(_ws = new MessageDescription("mscorlib.Globalization.ri_WS", 0x23450BC7, new ParameterlessText("Samoa")).SetSeverity(MessageLevel.Information));
        Add(_xk = new MessageDescription("mscorlib.Globalization.ri_XK", 0x23450BC8, new ParameterlessText("Kosovo")).SetSeverity(MessageLevel.Information));
        Add(_ye = new MessageDescription("mscorlib.Globalization.ri_YE", 0x23450BC9, new ParameterlessText("Yemen")).SetSeverity(MessageLevel.Information));
        Add(_yt = new MessageDescription("mscorlib.Globalization.ri_YT", 0x23450BCA, new ParameterlessText("Mayotte")).SetSeverity(MessageLevel.Information));
        Add(_za = new MessageDescription("mscorlib.Globalization.ri_ZA", 0x23450BCB, new ParameterlessText("South Africa")).SetSeverity(MessageLevel.Information));
        Add(_zm = new MessageDescription("mscorlib.Globalization.ri_ZM", 0x23450BCC, new ParameterlessText("Zambia")).SetSeverity(MessageLevel.Information));
        Add(_zw = new MessageDescription("mscorlib.Globalization.ri_ZW", 0x23450BCD, new ParameterlessText("Zimbabwe")).SetSeverity(MessageLevel.Information));
        return this;
    }    

}
