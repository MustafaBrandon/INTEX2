﻿
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using NJsonSchema.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX.Models
{
    public static class Generatoor
    {
        public static async Task FireMisslesAsync()
        {

            var text = @"{
   ""geocoded_waypoints"" : [
      {
                ""geocoder_status"" : ""OK"",
         ""place_id"" : ""ChIJP3Sa8ziYEmsRUKgyFmh9AQM"",
         ""types"" : [ ""colloquial_area"", ""locality"", ""political"" ]
      },
      {
                ""geocoder_status"" : ""OK"",
         ""place_id"" : ""ChIJPXNH22yWMioR0FXfNbXwBAM"",
         ""types"" : [ ""colloquial_area"", ""locality"", ""political"" ]
      }
   ],
   ""routes"" : [
      {
                ""bounds"" : {
                    ""northeast"" : {
                        ""lat"" : -30.9546012,
               ""lng"" : 151.2092664
                    },
            ""southwest"" : {
                        ""lat"" : -35.2130897,
               ""lng"" : 115.8613432
            }
                },
         ""copyrights"" : ""Map data ©2022 Google"",
         ""legs"" : [
            {
                    ""distance"" : {
                        ""text"" : ""3,933 km"",
                  ""value"" : 3932537
                    },
               ""duration"" : {
                        ""text"" : ""1 day 17 hours"",
                  ""value"" : 148453
               },
               ""end_address"" : ""Perth WA, Australia"",
               ""end_location"" : {
                        ""lat"" : -31.9523238,
                  ""lng"" : 115.8613432
               },
               ""start_address"" : ""Sydney NSW, Australia"",
               ""start_location"" : {
                        ""lat"" : -33.868969,
                  ""lng"" : 151.2092664
               },
               ""steps"" : [
                  {
                        ""distance"" : {
                            ""text"" : ""0.1 km"",
                        ""value"" : 107
                        },
                     ""duration"" : {
                            ""text"" : ""1 min"",
                        ""value"" : 27
                     },
                     ""end_location"" : {
                            ""lat"" : -33.869127,
                        ""lng"" : 151.2104059
                     },
                     ""html_instructions"" : ""Head \u003cb\u003eeast\u003c/b\u003e on \u003cb\u003eKing St\u003c/b\u003e toward \u003cb\u003eCastlereagh St\u003c/b\u003e"",
                     ""polyline"" : {
                            ""points"" : ""``vmE}`|y[HkAHaAFm@Bg@""
                     },
                     ""start_location"" : {
                            ""lat"" : -33.868969,
                        ""lng"" : 151.2092664
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""0.3 km"",
                        ""value"" : 319
                        },
                     ""duration"" : {
                            ""text"" : ""1 min"",
                        ""value"" : 72
                     },
                     ""end_location"" : {
                            ""lat"" : -33.866273,
                        ""lng"" : 151.210736
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eleft\u003c/b\u003e at the 2nd cross street onto \u003cb\u003eElizabeth St\u003c/b\u003e"",
                     ""maneuver"" : ""turn-left"",
                     ""polyline"" : {
                            ""points"" : ""`avmEah|y[a@CSA_AE_ACc@C}@Ie@CWA]CgAGyAKe@E""
                     },
                     ""start_location"" : {
                            ""lat"" : -33.869127,
                        ""lng"" : 151.2104059
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  
                  {
                        ""distance"" : {
                            ""text"" : ""4.0 km"",
                        ""value"" : 3955
                        },
                     ""duration"" : {
                            ""text"" : ""3 mins"",
                        ""value"" : 208
                     },
                     ""end_location"" : {
                            ""lat"" : -33.3263714,
                        ""lng"" : 138.1845907
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eleft\u003c/b\u003e at the 3rd cross street onto \u003cb\u003eEyre Rd\u003c/b\u003e/\u003cwbr/\u003e\u003cb\u003eGoyder Hwy\u003c/b\u003e/\u003cwbr/\u003e\u003cb\u003eB64\u003c/b\u003e\u003cdiv style=\""font-size:0.9em\""\u003eContinue to follow Goyder Hwy/\u003cwbr/\u003eB64\u003c/div\u003e"",
                     ""maneuver"" : ""turn-left"",
                     ""polyline"" : {
                            ""points"" : ""jfqjEgcqjYsA~AqBdC{AlBKL_BnB_BlBgBrBY`@aAjA}@fAa@f@q@t@ONSPWRWN_@P]L]JWHG@_@HWDE?WBK@O@w@@K?W@gABcABk@B[Ba@Dm@No@PWLWJWLqAx@oBnAyA`A[RSN]Tk@^q@`@]Tm@^OJ_@TaBbAwA|@OJm@^_CxAoCdBe@XsChB}@j@oAx@SL_C|AcCzA{CpBgKrGkKxG{A~@cAl@kAv@o@b@q@j@a@^a@b@e@j@_@h@GJQVSZYj@Wh@KVEJUh@Y|@Ol@S|@[dB]jB[jB]pBUpAGXMv@Kf@AHYbBWrAa@zBe@pCQdA""
                     },
                     ""start_location"" : {
                            ""lat"" : -33.3528565,
                        ""lng"" : 138.2099606
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""17.9 km"",
                        ""value"" : 17882
                        },
                     ""duration"" : {
                            ""text"" : ""11 mins"",
                        ""value"" : 663
                     },
                     ""end_location"" : {
                            ""lat"" : -33.1979224,
                        ""lng"" : 138.0789383
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eNational Highway A1\u003c/b\u003e"",
                     ""maneuver"" : ""turn-right"",
                     ""polyline"" : {
                            ""points"" : ""x`ljEudljYGVCLKj@q@SsC{@WG]KgBi@y@Um@KgAUcBUwAMyBMgBEoB?eADWBK?c@BgAHeBRkARsAXiBb@{Ad@{Af@sAj@mAh@e@Rc@TeB~@qBrAYNuChBiBjAcFbDgMxHo@`@]T{ClBiBjAwA|@kD|BWP]TMJkBrAoA~@_BpAsB~A_CnBu@p@m@h@sBjBmAlAqAnAcAhA[Zu@v@GHoBtBaBdBWZeBhBk@j@}AbBgBhBuArAYXA@iB`BqBhByCjCw@l@u@l@yAfASPaBlAeC~A]TiC`BuCfBsBjA_Ah@yBlA}@d@aBt@mAj@qD|Ac@R}@^aDlAmC`AqBr@kBj@ODa@LcAZa@L{DfAQDcAXgBf@i@NiD~@kAZmFzAeBf@ODs@R_Cn@mGfBsBl@cAXiElA}ErAaPpE}Bn@k@PkEnAwAf@oCbAeBv@g@Vo@Z}At@m@^eAn@KFyBzAg@\\{ApAcBzAwBtBmBrBeBxBQTq@z@qBpCgGjJeD`FwG|JW^i@x@i@x@aG~IcEjGqE|GeA~AW`@W^aMdRcQvWmF`I}CxEQX_BvBq@x@w@t@i@b@]Te@Vi@X{@`@_EdBaBr@eBt@}Ar@iHzDKFsAr@kCxAyBlAOHUN[Ro@`@g@ZML_@\\UTi@n@KNQVOXqAvBg@t@e@v@Y`@MNUZSRSRWTgA`A}@x@uBlBQNsAnAkFvEsDfDoMlL[TWVwArAwCjC}AvAwClCaBvAmE|DkSxQqBhBeA`AkAdAa@\\_BvA_DtCuEfEe@b@sd@ta@_Av@iErD]\\wHbHcEtDmTxRwApACBiD|CcA~@m@h@EDa@`@[Za@`@EF{@`Ag@l@c@h@IJ[^Y`@[`@SXoCdESX[b@a@t@m@nAm@pAABKTYr@MZQb@]x@e@~A]jAOd@?Bc@bB{@nD}@fEC\\G^YvA""
                     },
                     ""start_location"" : {
                            ""lat"" : -33.3263714,
                        ""lng"" : 138.1845907
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""90.1 km"",
                        ""value"" : 90055
                        },
                     ""duration"" : {
                            ""text"" : ""58 mins"",
                        ""value"" : 3467
                     },
                     ""end_location"" : {
                            ""lat"" : -32.4834362,
                        ""lng"" : 137.7588413
                     },
                     ""html_instructions"" : ""Slight \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eNational Highway A1\u003c/b\u003e"",
                     ""maneuver"" : ""turn-slight-right"",
                     ""polyline"" : {
                            ""points"" : ""~}riEkpwiYUd@UbAi@dCw@fCa@dAiA~BOPoD|GmAlCGLCBEDmEjJuArCEDYd@u@dA_AlAoAjAm@h@w@j@k@\\{@d@k@Vu@Xs@Vc@Lq@N}@Pe@HsALe@Bq@Be@?g@@mzACkZB_@@_@@]BaAHeAPa@He@L]J_@J_@L{C~@{A`@s@PqB`@_@F_@Do@Bm@Dg@?a@?o@?eF@c@?_A?k@?iA?_A?SAs@E}AGmAOeAMw@OaCi@g@OQGy@UgCm@oCa@c@G}@K{CS[C{DIwB?Y?cH?_E@yJAO?wC?{AAuQAe@?aO?{F?}D?wA@mEA_N?_@?{C@eF?M?qB?aB?oX@uF?uCAg@?c@?qN?uC?knA?mE?sD?cEBy@@w@BcAFo@D}ALaALqCb@iATSDqAZeAXcAZuAf@cAb@WJeAd@{Az@uAv@qAz@e@ZsCzByBpBs@n@c@`@sCfC{CrCmCfC}CvCyArAmCdCwArAiBdBeA`AoCfCeB~A[Xk@j@oCdC}AvA[XA@eB~AyCdCMLeBrAmBtAyCnB}@j@eAn@}C`BkB`AuKpF}HzDcEtBeJnEuBfAmCpAqFlCiFhCgGxCaD`B_Bz@aCtA}\\tReB`AcCtA{CdBcExB{EdCiB~@iEzBwDlBaEtBC@_@PmB`A}BfAUJqAj@}Bz@qC|@}@XgBb@wAZkBZa@Fa@HqC^cCTyBPiD\\gAJqBPmBPuD`@oBXk@Jg@HsAXmAXi@LMD_Bb@wBp@kA`@m@T[N_A\\aBv@sCvA{A|@g@\\mAv@}DfCsBrA{@j@yBvAq@d@oGdEqD~ByGlEq@b@}I|FgOxJaDtBkHvEmPtKwA~@{A~@gDxBkFhDiC|AkB`AkB`AyAp@cDpAoFnBm@P{Bl@iAX{@To@NiCh@s@NyCl@sBd@aOhDwGxAWDsAXoAT}A\\sAXiB`@]HqDt@kFfAyBd@kAXiCp@c@Ny@VmA`@OFw@X_A`@sAj@kDdBqBjAkBlA{AfAsAbA]VIHiB|AaB|AcBhBoAtAgC`DkA~AcBlCc@t@}@~Ak@dAq@rAc@`Aa@`Aw@lBIRGPc@hAe@xA[dA[bAe@zAk@nBc@~As@`Ca@rAK\\K\\u@`CaA`D]lAYz@GPOd@ADWp@Sl@Uj@a@bAa@~@iAzB_AdBq@bAk@z@GFm@x@cAnA_AfAsAtAgA`Ay@n@_@X{@n@iAr@iAp@qB`AoAf@iBp@uAb@u@PaATiDn@mCh@UDm@La@H_Dn@uAV}Cj@iCh@QDqM`CoEv@sBVyFl@{F^kENoEDiE@i@?cA?uE?kQ@{D?S?i[DkJA}LBkA?kv@Bc@@gJ?e^Bko@Bss@Da\\@gF@_Q?e`ABuO?OAqm@JoJ?uV?S?ua@?gk@FuB@q@@iAAc@?k@?oNAgg@HcN?}@?uK@m^DoA?wCB_HJsDDq@BeA@kADm@?{BH_FJo@@gHNsABc@B{FJgADcA@eCFQ@eCDsCFsDHuBDsEJuGNc@@{FNkBDaHb@qBNi@FyCV{En@oDh@oB\\gB\\aCf@qA\\cATqBf@ODoA^w@TqBl@{Af@oAb@uBv@q@TuAh@uB~@oBz@uAt@}BlAa@RoCvAeEfCmBlAgAp@yCjBoFnDmErCeF`Da@V]T_@TyH`FkEpCcDtBqFjDgMdIcDtBg@\\{KfHgAt@gAl@_@RuC~AsBdAqAn@c@Ra@PWJ_DpAeBp@kC|@yBt@cD~@eDz@yJbC{LxCuMdDyJhCeKjCi@L_@JiEfAcDx@i@NuBh@kDz@kCj@gDr@sCd@eDd@eCZmD\\O@kBL[B_DRmCHgEH}C@iC?qDEi@AKAcFEa@?{C@eJPwCLsGd@kAL[Dk@Da@DI@cJtAuAVi@Je@JeB^eB`@sA\\eBf@eAZyAb@]LcAZQF_AZgMrEqBx@kA^sBt@kC`Au@XsAd@mCbA_Bl@gC~@mAb@E@[LqE`ByBx@cCz@qCdAkC~@wCfAuCdAsAf@q@V_A\\iBr@eNfF}GpBe@Ja@JyEjAWFkHpAwFx@eLbA{AJgAHgAHc@DiU~AyFb@yBNqDX{O`A}Of@_@@kR?}BEwDIQA}CKgCMm@EsDSYAIAi@EaQ_BSC_@GgFq@aGy@cAMmBWoC_@mD_@qIs@uEWeCKe@CG?[AaBEoAEkAAmGC}B?qDDyDHgCHoCLkBHsE\\i@D[DsD^kCXq@HmBVaBVkFz@QD}@PmFdAyBj@aKbCkCr@oD|@cGzAoCp@sFvAoEnA{Bp@{Ad@{Br@eAZcAZi@PkCx@qBp@cOzEa@LsQzF_LnDKDkErAqC|@{V`IoBn@}EvAyF~AgAZqA\\mCp@uBf@qBf@uCp@wBd@A?c@J_B\\}FjAuB^aCb@]FoAT_BX_C^aEr@}B`@uZlFy@NqEt@mGfA}GlAcBXaBXqAVyG|AcBd@oCx@sBr@gBn@oFtB}IfEkAl@_CrAg@ZsAx@sCfBaAj@_LdHiAt@eAp@q@b@k@\\[Pe@XkCdBGDaAl@cF~CMJ}BxAwA|@kCbB{H~EkBlAgC|AgDxBuFlDsCdBqBrAyFhDmEtCiElCoDxBiF~CsFrDuIfFeG`EkCdBkFjDwA~@wLvHsErC}@j@aIdFoBnAsThN{O|JuA|@s\\~SuNbJ{GjEkG~DUNcXvPkYrQy@j@_CvAm@^eGtDyCjB{x@`f@cZjQiEdCcCzAaIfFqLzHsCnBaZxRoAz@mPxKsAbA}@p@gA~@g@b@ONe@d@kAhAg@j@]d@Y\\cApAu@dAg@t@kB~CqKpSy@|AqBzDuB~DmElI{AtCg@bAq@dAKPsCpFaSt_@}EfJ{K`TWf@QZqAdC{EhJIZ]p@iEbI{GfMi@`AkBnDq@fAuEbIoAnBiBxCeCxEyArC_AhBCDKN_AjBEJcAlBk@`A}AfC}@hAaAjAqCtCyArAuAxASRq@x@YZu@dA}@~AEHa@v@a@z@Sb@Uf@k@rAw@`CITM`@w@jD_@pB_@lCa@bEQjBeA|I[fCQ`BOzAsBbQsA`LiArEaArDiAhE[lAcCjJyCnLIT_@vAYdAQp@a@~AYhAQn@wAnFe@bBaAlD[tAYjAGPc@`B[lAIXSp@Sx@[`A_@v@c@v@g@t@e@h@]ZYVKHYRc@\\e@Z{DrCMRe@`@eAx@SPgAbAc@d@KLc@h@y@dAORGJcA~AqAzBi@~@o@bAa@x@cDrFyBrDIJQJgAjBm@`AgB|CGHWd@qAxBGJENs@xAo@hAu@bAOPMNc@d@s@j@SNYRSJ_@RqAh@]N_Bn@a@PYNqAt@s@`@CB_@Tg@`@URMH]TKHKHWNIFEBMHCBGD]TQLSLMHYRSNEBA?c@ZUNA@SNC@QLUNA?]Xa@TKHYRGDUNOJC@OJc@ZGFEBKHEBKBKJKHQNMN[\\MLKNEFGHGHMRMREFCFYh@ABEHQb@IPUj@KT_@bAITUj@IR?@O`@EJKVKVEJO`@?@ITGLO^ABIRENO\\ADIPIVQ^ELGJAFA@Q^GJKTA?S^GJORMP_@b@?@A@QPWXQPMJEFYVGD_@\\c@ZML]VMLUR""
                     },
                     ""start_location"" : {
                            ""lat"" : -33.1979224,
                        ""lng"" : 138.0789383
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""17.2 km"",
                        ""value"" : 17178
                        },
                     ""duration"" : {
                            ""text"" : ""13 mins"",
                        ""value"" : 770
                     },
                     ""end_location"" : {
                            ""lat"" : -32.5800314,
                        ""lng"" : 137.6215067
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eCaroona Rd\u003c/b\u003e"",
                     ""maneuver"" : ""turn-left"",
                     ""polyline"" : {
                            ""points"" : ""nlgeEw_ygYn@rAP^LTXr@~@bC|A~D`AbC`@z@NVPTJNHHfApAjCfDlAvAfCbDx@jA?@~GtJv@|@xAdBbB|AxAtAVPZVxAhAZV\\VvDtCfDvBB@xBfAh@PND|@ZjA`@hC`ApBt@`KrDbBh@dLbEl@Vf@Xv@`@FDzDzBjBbAf@VlDbBhGjCxCnAhEfBbAd@`@X^Vj@^JHjAlAv@nAFHv@`BtAtD~Nx`@|EnMjBhEzExKz@lBtKpVtEhKRb@Rb@rBvEnD~HrBvEbEhJtB|EN^Nd@HTbAjDv@lBR^Zp@xArB^t@l@rAhDxHtCtGRb@Pb@hFlLfCzFRb@Rb@lD`IxDxId@fAlAnCxC~GRb@pBvErBvE|CjHdD~HvC`H|DhJBDL\\Rb@bC|FRb@Pb@Rb@jApCv@jBnH`QxDnJtCvGxCdHPd@~ArDN`@@@fCxGFLT`@P\\p@dAV^|A`CV^T^tB`DV^nHbLV^dA`BlBvCV`@T^jC`EzA|BpCbEfA~AV`@T^fCrDDHn@`An@~@?@pAhClElIXn@@B`@fAt@lCNd@Lf@FT\\p@N\\BDb@p@d@h@p@h@hExBf@^\\T\\\\d@j@NTLNx@tA~BpDhBjCjBrCnChEbAzAV^hAdBpE|GhAbB~CzE|A`Cl@|@fBnCp@hAlC~DlDjFBBrChEbBjCtCpEbD`FvBzC|@|Af@x@TZ`@h@VXd@`@^Vb@Vj@ZlAb@vClAlEjB~An@`@Pz@h@j@b@h@h@\\b@d@r@FLVf@`@dAf@zAn@dBd@nAd@pAZz@Tn@Jf@RrAj@rEVzBDf@N|@XjAXz@LXZh@d@r@`ArA~@xAzBhD|A~BJR`@j@v@jANTnAnBn@`AHVH\\?DFp@@VEl@?DKf@""
                     },
                     ""start_location"" : {
                            ""lat"" : -32.4834362,
                        ""lng"" : 137.7588413
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""6.5 km"",
                        ""value"" : 6512
                        },
                     ""duration"" : {
                            ""text"" : ""4 mins"",
                        ""value"" : 245
                     },
                     ""end_location"" : {
                            ""lat"" : -32.6188951,
                        ""lng"" : 137.5696248
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eNational Highway A1\u003c/b\u003e"",
                     ""maneuver"" : ""turn-left"",
                     ""polyline"" : {
                            ""points"" : ""dhzeEme~fYDBj@ZNJf@\\~@r@hB~An@p@fAlA~@fAnDlEPRx@dAFFzBtCxAnBz@hAtBzCz@lAPXnGpJV`@LPV`@bA|AlDpFtJ|NxAvB|]ri@zOfVV^~g@hw@bGfJbD`FdDfF|IxMNTJTrEbHnDpF`FvHhHxK^j@`AzAnE|Gl@|@|@tAj@r@nCjEpCfEJNd@x@""
                     },
                     ""start_location"" : {
                            ""lat"" : -32.5800314,
                        ""lng"" : 137.6215067
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""130 km"",
                        ""value"" : 129578
                        },
                     ""duration"" : {
                            ""text"" : ""1 hour 21 mins"",
                        ""value"" : 4842
                     },
                     ""end_location"" : {
                            ""lat"" : -33.141383,
                        ""lng"" : 136.4198573
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eNational Highway A1\u003c/b\u003e"",
                     ""maneuver"" : ""turn-right"",
                     ""polyline"" : {
                            ""points"" : ""b{afEcatfYUt@{@pDYlAI\\]pAa@vBQhAUzC[hMQ~JE~Bg@rY]~RMpIiAvm@Ah@g@tYIvDB~BJnDDxAFxARbJ`@bQT~IFrC~@`_@^~Nr@tYF|ALhBpGzz@bDnb@b@zFtAlQb@zF|Cfa@P|B`Dnb@j@fH|Djh@t@nJfDzc@rB~WJrAlF`s@hBjU@RfAlN@JlBtV`AhMNnBTtCBd@DbAD`BAzBUdVCdBQdROtOAbAA~AAfAAXAlB@h@Br@Br@HdCRlFTnG@h@@V\\dJdAj[rD`eAHjCR|FR~FZ|IrAn`@@F~@fXJpC`@hLf@|NH|BdAlZ\\bKLdD@h@v@bUL~D^dKLlELnDBj@rAz^Bh@XzHRjFBj@Bh@\\xIHrBRhCB^DXRrAlEdUtBrKJf@b@|BHb@Jf@zFrZFVdElTnArGjClNJf@jBzJNn@hFvX`A|Ez@nETnAbEnTJd@?@vClO@HpBjKhCbNH^Nv@Nh@\\nAnApDBJfFxNt@vBPd@j@`BlBnF~@hCTp@DNL`@H\\Pt@RdAVnA^fBLf@J`@h@`B|EvLbG~NlAzC|IhTlFnMn@rBZ~AR~@PvANpBTpFdAdXJdCHrBLjBTjCjBbP`ApI\\jC`@pBV~@Ld@p@fBVj@Tb@DHv@pAr@dA@?zA`BxB|Br@|@JLf@p@|@fBdAjCx@tCfDtL`DlLLd@`Qnn@pDpM`Jf\\|EfQtBvHxCvKJXvAhFdAvDRr@vAhFzBdIzJh^`DhLLd@\\lAhG|TLd@nCvJrBxHLd@Pn@`IlYzLpc@hSpt@nDrM@DL`@H\\FNFLFVjLbb@b@~ALZJXHR\\t@p@nApCvE|ClFlHfM`A~AvHtMpDjGT`@~EnIp[~i@fElHnKzQpDjGdEhHfEnHZf@bMfTt_@hp@xAdC|F~Jx@~Ad@fAn@xA^bA^bAVx@Vz@Pr@Pr@Ll@XpATlAPhAL`AJ|@Hn@LzAHrAHfBFbB@fB?zAA|AGvBQbEUxEKfCKzBu@`P]rGC|@MlCQ~DGbBCbB?@?pA@|ABx@Bv@FpAJdAJhALbALv@PfAP|@DRH`@Pr@XfAd@zAj@xA`@`An@pAVj@f@|@f@x@`@j@X`@n@t@l@r@n@p@`@^`@^t@n@r@h@`@ZVNr@b@d@Vx@b@z@`@x@Zh@RxBn@bD`AnCz@pAd@RFbBn@n@Vr@XbBr@hCjAfCnAtAt@d@Xz@d@~@h@`@V^RFDjAt@pBrAlA|@tB|AlEhD\\XRN`KhIpRpOjBzA\\XnFjEbF`EZXLHpEnD~DbDlCxBLJdBtAXR~HnGJHpRtOhXlTlAbA\\Z^`@v@|@|@pArFvInB~CtBfDxHxLzBtDnElHpHzL^l@jEhHfHnLdCbEn@dAdKlPT`@V^bCzDhCfEjC~DjA~A@@tBhCfEbFlArAt@x@xBtBdCvBnCzBPNbXdTZXdS`PZVdS`PtBbBrFlEjBxAlBzApG`FZVdBrApWjS~VzRtUxQnJhHhDhCrG|Ez@n@~LhJzGdFjQzMzUjQhAx@\\VjSbOb@\\\\TpK|H~G`FfGpE|AjAvN|Kx@p@`WvRjInGbGtEnB|ApCvBpBzAvAhA\\VxErDtAdAr[pVpDpCp[nVtFlEfA~@p@t@HHr@v@tDrEPPrIhKtQrTdBtBx@`AfRjUpFtGLPlWf[zNrQpAzApLvNJJLPlEnFrDnEbMlO~HtJfFjGbJ~KhBzBX\\tAbBlXr\\X\\hVbZlEnFhZx^X\\zSjWX\\`K`MxK|MX\\xCrDzGhIX\\xGhINN~EzG`FtHjFzGf@n@zMdPb[n_@rV~YvLxN|h@~n@dIzIrOvQfDzDvBfCt@|@rLvN~OpRbCxCvRtUjJxKtBdCxDpEnB|BbAjAbLtMr@x@nFlGrChD`GfHZ^nI`KnLjNfLfNX\\h@n@zHjJVX\\b@zCnDhArAdHfIlAvAvDlEXZjXh[VZVX~@dA`@d@rI|J~@fAvKdMd@h@j@j@LJ~DhDJHn@p@|@dAvA`BX\\XZtFvGjLlNxDtEl@t@V^X\\rEzFtJxL`a@~f@tGlIlAzAjAzAV\\X\\X\\lA|AfBpBXZTVBD`CnCxBhCxAbBXZz@~@zBlCX\\XZrA`BhE`Ft@z@dJrKtA`BXZ|G|Hv@`AjAxAV\\~ArBbC|C|HzJ`@j@B@Zd@Xf@f@|@NZVf@nCnFz@dBtAlCfBnDnMfWtDpHTb@bDpGlVhf@Tb@nT`c@rE~Id@`ALX`AlBr@bB~AlEt@zAxBlEdFdKR`@`HjNd@|@|CjG~Tpc@Tb@vF|Kj@hAjEvIdF~Jh@dA|Oj[T`@Rb@jLjU|CdGf@dAT`@zDzHR`@xAvC|LnVnGjMrC~FR`@hW|h@|FrLP`@rAjCh@fARb@h@dA|@pAp@v@|UzV`AlA|A`CtAvBjHhM|DdH|@hBpJ|TdFrLPd@x@jBx@lBjChGzYbr@Pb@rA`DhBhElCnGfAzBbClE~GjMpLjTT`@tGtLrCjFzIbPbErHvClFT`@zBbEr@vALZ^`A^tAVdAX|AFZ@Jr@xFFh@|@bHlBvOXbCHf@TrB|@xIFh@tCfYDh@Fh@l@bGr@dHtChYn@lGZfDRpBRfADTJf@DP^zA~DvMNf@zEzONd@|BtHLd@zBlHxCbKzBtHLf@xC`K|AlF`@nAZdAlA`El@rBBJ~@zCv@jCbAbDXdAd@zAf@`Bv@jCn@vBFTz@pCr@dCX|@j@jBl@pBp@xBh@lBf@|A\\jA`@dApO`h@xE|OfInXfIjXNf@xDnMNd@hEvNNd@|@zCNd@zCbKlA~DNf@tJ~[Lf@jAxDj@|BLb@\\`BXlBFh@nFt`@Fh@vBzOb@dDvF`b@Hh@zGdg@rE|\\jBhNT|AzAbLXtBHh@j@fExAxK~AnLd@hDFl@Jn@NdAJx@NbATjBDd@F`@Dh@DdABf@Bz@@bA@xAApF@vD?jH?vA?~V?z@?xA?`A?b@?`C?bG?`CArB@lD?xAAF@`B?tB?`I?xA?P?V?fJ?jC?xA?bC?zA?R?X?dH?z@A|P?~C?nD?xC@fHApL?tB?dD@pFApA?nA?h@?dB@bBApA?bA?hC?X?h@?J?`C?\\?L?dAAbB@nCAz@@~AAjA?P?V@h@?l@?rD?hA?vE?j@?zOAzD@vHAvB@b@AjA?n@?~B?p@?hC?~B?`@?nA?vA?xC?rA?lA@`BA~A?L?xU?lT?r[Afc@?lK?hE@bO?pKAjH?vE?lP?~B?j@?xCA|H?xU?j@?@CjBI|AOzAq@dFKvBGjA?`D@bQ@zC?tA?pA?bC?j@?~H?`@@~E?hB@|@Dz@@^LdA\\jCPvADl@@PFhABvA@|A?ZAxH?nT?nXAho@?nTCbS?j@AlPArA?|DNzBT|B^lBn@|BbAfCfAtBnA|A~A|AZZDDFHf@\\|JfHxEhDdLfI`IzFhCdBn@b@LFx@b@fChArCnAfCzAfJ|GXRjIzFZR`EtCUn@[p@c@`A{@nB""
                     },
                     ""start_location"" : {
                            ""lat"" : -32.6188951,
                        ""lng"" : 137.5696248
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""312 km"",
                        ""value"" : 311891
                        },
                     ""duration"" : {
                            ""text"" : ""3 hours 15 mins"",
                        ""value"" : 11711
                     },
                     ""end_location"" : {
                            ""lat"" : -32.1212415,
                        ""lng"" : 133.6738511
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eNational Highway A1\u003c/b\u003e"",
                     ""maneuver"" : ""turn-left"",
                     ""polyline"" : {
                            ""points"" : ""r|giEcos_YjA|@pBtAvAv@zA^h@Tj@T|@h@NJf@b@VZ`ArAlAnBXb@r@jAFHzAbCT`@T^fC`EtBhDjEdHdC`E~PzXnQpYdB|BvA~AlAnARTrBbBlBxAzAbA`D`BdFxBvF~B`@N`@PdEdB`A`@^N`_@lO^NfAd@dDxAVLdDhBtBrAfBrAfBrAbJ`H`E`DnF`Er@j@\\V`GrExGhFzC~BzAlAf@`@\\VzAlA`BrAdA~@rBhBZXHFbAz@~AvAjC|BNNvBpBh@j@~@fAd@n@d@r@b@t@d@v@l@jAXj@N^LTb@x@Xj@v@lAbArAh@n@f@h@t@p@n@j@`Ap@~@l@bAj@`CrAb@VPHLH~@f@vAv@dB`A@@\\P`@T|BlA~CdBzAz@^RFBpAt@pAr@p@b@x@l@x@r@j@d@l@l@r@t@f@j@r@|@bAnA~@jAHHNRp@x@fAtAx@`AHLLPd@j@r@x@f@p@p@z@fAtA\\`@JJp@r@z@x@^\\n@j@n@d@^Xj@`@`@Vd@Xn@^d@Vn@Xb@Rj@XTH~@`@dAf@lAf@z@^r@\\j@Tv@\\b@P^Pr@\\nAj@tAt@~A`Ar@f@nA~@hAhA\\\\fAdAlAzA`ApA~@xAd@v@jAxBb@~@DHJXZv@Tf@b@rAt@`C`AbDV|@h@fBjAhE`A~CFRdAbDbAnCpBjEtBdEh@dAr@xAnDdHrAlCh@dAbGzLzErJnAbCbC`F~A~CdArBtEhJxCbGBDNZ~@`BhB~ClCvEr@jArBpDnAvBbB~C~@xBl@`Bt@fCj@bC`@`C^tC?@NnBLrCBnA@j@?h@AjBAnAKxBOpBsB~TEh@uGvs@U|BEh@w@pIMrAEh@gBxRGh@S|BgBxR{AbPyAbPEj@eClXMrAS`Ci@xFw@nI_AzJ_Erc@Gh@Eh@kCjYEh@i@zFEj@Mv@SjAe@vBaA`EuAbGaAfEWvAM|@Gd@Gj@OxAIzAG~AElAClHCfE?h@CxD?\\AfFCdEEvO?jCC`BC`AIxAKjA]vCUfBStBIjACv@ARA~@AB?fABhAHhBL|AR|AN`A@H^|A^tAp@jBDJh@jAn@nAz@tADHjAlB|@xAd@x@l@lA\\v@f@|AZpA`@vBTnBH|AD~A?X?l@Ax@E~@EfAg@rFm@jFkEbb@_CpTOhAQjAWjAe@zAc@lAe@dAGJe@~@CDk@`A}n@dfA_C`Eo@jA_@v@a@hA_@jAYhAUlAM~@q@pGaEx_@mBhQGh@ALKfBEljAEpD]tMwAvk@Ah@i@vTSjEq@rGGh@yAvNsAlMGh@sAnMkAbLQ~D@pA@h@@pAzCfs@h@tMtAz\\Bj@j@tMPtE`AtU~@tUn@jJ\\nIl@`OBh@^tIBj@b@~JBh@PtEBj@v@tQD|@P`EN~Dz@~Rl@`OBd@f@rLTtFTxFBdHFlFPlPF|EV`WDrE@h@LhP@n@TjWNfP@J?^JdJ?dAFpFJpN@h@JxMHlCDdGDbEB~A@j@DlDFzE?lCMpCSvBQjAYtAQp@W`Aw@nBiBbEu@hB]v@GNqG~NiDzHUh@mAvCc@`Bi@pCMhAkApNqBxV}BtX?V?j@AxCNjC\\lCb@xBh@pBZdAJb@^hA^~APjALr@Hv@Bv@DzBCzEcA|XsAb_@OtESpFKtAGp@k@lD{@tD_AhE_@|AObAGh@kAjIm@nE_D~T}@xGoEz[Gf@e@dDiAjIIh@iCjRGl@_AnICh@E^Y|B]`Dm@bGEb@{@nIGh@aAxJGh@OrAyAzNGd@U`Ba@dBy@rCWn@Qb@Qd@kDzIkAbDQn@Mf@Y`AW~Ao@~DSfCMtC?^B|H?nB?h@BxM?h@Jxx@BjM@bK@h@@lL?j@DxU@j@?tABjL?j@F|a@@h@DpX?h@DdS?h@BxQ@zABrBC|AAb@Cr@c@bFU`BeAtE}@dDmAhCw@|AgAdBmAtBMRgCrEiBbDq@hAsDnGW`@eBxCoGdLm@bA}EpIU`@cDvFeBzCW`@_CbEiCpEU`@U`@iFfJu@nAuAbCqBjDU`@wAfCgCrEyCbFoBfDyCfFcAdBwBtDkA|Byb@_@b@MNUZ_@j@[j@}AnCoFvJwB|D_@p@yBxDS`@U`@oAxBu@tAu@hAm@z@QRW^CBUXk@r@eAvAkAxAc@j@W\\KLMNk@v@{@hAkAvAqDxEgFvG_FjGgEtFGFQTW\\{FnHW^Y\\yBrCqDxE_JhLqKfNcMbPiWn\\s@|@W\\{FpHq@z@qKdNq@|@iLdOm@t@i@r@g@z@_@t@a@~@}@pCyJfZkArCgAnBcAtAc@f@[ZED_HtGu@~@g@r@e@t@CBwHrOeChFS`@Ub@cGbMkA`COVWd@g@x@]d@u@z@w@t@qCbCeBdBwLtLgChC[Z[XcRrQiCdCw@t@gJ~IQPIH}@jAy@pAW^oKfQiCtEQZkNfVU^yDxGmAxBW^aAdBmAtBaBtC_JxOaAbBaNzUoBjDwCfFk@`AU`@cCfEoBtCc@d@Y\\GFqAfAgAv@kAn@}Ap@mEdBaA`@iGbCiHrCgBr@}@XeAR]HE?s@JgAJsI^_T`AI@c@@E@kMj@c@BeJ`@c@BgADa@BiAL_AN_APeAXs@Xq@Zo@ZSN_@T[Vo@d@yA~AA@wPhP{A|AkBhB}@`Ag@p@g@x@e@|@a@`Aq@bBeEbLcF`NwGrQQb@cFbNs@lBeGlPc@hAgB|EaExK{@zB}@zB]dAU|@i@tCCPOvAIhAE`BAF@dBBbBf@pLRfFNzJD`ABh@Bl@h@jLH`BTnFB|@fAnWD|@LdC`@rJBh@^zI?DDdB@fA@d@@rF?j@@|J@|FBrD?lD@`FBxI@nG@F?pB@zDGtBMnBU`BWrAQx@s@~Ba@dA_@z@wGlPw@lBk@xAuIbTcM~Z_G|Nw@lBcCbGeGhOuIdTsEbLQb@aG|N}AvDQb@gEjKuChHQb@k@zAi@xA_@nA[|AYpBaAjH{B`Qk@`EgB|MSbBcAvHIh@_BtLmCpSIf@k@lEIh@_Fd_@a@bDyAzKQpAIf@aBdMGf@UvAUlAYpA_@lAm@bBeOfc@q@nBaUhp@uBhG{BtGM^Q\\O\\Yv@sDrKa@hAiPxe@Ob@eClHkFlOi@zAk@bBW|@M`@UlAEXANCREf@q@bFIf@wDzYAD}@~Gi@dE_BrLo@tEGf@q@`Fu@`GS|AGf@gChRADgAvIyCzTqA`KAB}@|GyCbUkEr\\gAbIc@hDM|@sCjTS~AYpBiAxIUfBGf@cEh[i@zDUbBeBvMM~@YzBEZwJlu@}B`Qa@zC{@tGg@vDYtB_AhHy@hGm@rEgDbWYxBYpBiAvIqBpOGh@OjA}DdZwAlKGh@s@pFe@hDw@`Gs@tFO|@Gh@CL_EzZGh@ADG`@_@rCiAxIa@|C{A`LiBlNGh@qBfOqA`KQpAGf@Ih@wC~Tk@hEGf@i@|DgAhIANIj@OfAE^If@{@pGyAxKQpAIh@oApJ}@rG}ChUkBpN_CbQwD~XIf@gChRALEXIl@OjAQpAI`@Mr@Kd@GXYbA_@hAKVWn@Uf@Wf@Wb@g@r@aArAwAnBiBfCa@f@ILg@r@eGlIiA~Ay@dA[\\QNIHe@`@A@e@^IDmIxFqBrAIDeEnC]VYTYTa@\\_@^o@r@iA|Ak@`ASb@Uf@Yn@g@~AYdASbASjA{@hGaAjHa@pCkA|IUzAmA|I_@rC_DjU{BnPuAtJQ|AE\\Ef@Ej@Cp@CnA?|@@x@?B@h@Bj@?Bb@lGFz@rApSB`@TrDB\\FhAJpARzCVxDPpCV~DB`@N~BZrEfAnPRfDZ~ExAtTz@`N\\lFBXLlBF~@JpAz@pMF`Ap@hKxB`]J`BBf@Jx@hA|PBP@Vb@~G~@nNl@hKxAfTH|ABhA@zA?b@Cn@EjAE`Am@dLo@vLa@|HCh@Ev@k@vKa@dIMhCK|BQdEUtDuAlXg@zJItAWxFCh@ANGbAUpECZ_@~HaAlRM|B}AtZCh@oDjr@Cj@GlAEtA]nGGr@i@jKu@lN[fGa@`I]fHAJa@`IYjGKjBE|@IrACh@GtASxDKjBUtEa@zH]bHg@vJWfF?@QdDi@bKSlEOzCQzC[xGEx@M~BAJKrBWpEE~@ObDUjFKxBGhAStDCt@GjASnFG~Ck@jRAt@Ah@AZ]dPEdB?v@AF?hA@~@Dr@@n@@T?V?b@C^Cn@Cb@ANCZ?BAb@GvBAj@?@QhHOzEGnBGhAAJ?N?JAVCX@@?B@@?@?@@B?@?B?@?@?BA@?@A@?BA@?@A@A@A@A@A@A?C@A?C?A?C?A?C?KTGPGPGXCHMt@Kp@Ef@Eh@?z@?bAD`C@vB?L?LCpB?l@?|A""
                     },
                     ""start_location"" : {
                            ""lat"" : -33.141383,
                        ""lng"" : 136.4198573
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""479 km"",
                        ""value"" : 478763
                        },
                     ""duration"" : {
                            ""text"" : ""4 hours 57 mins"",
                        ""value"" : 17811
                     },
                     ""end_location"" : {
                            ""lat"" : -31.6388518,
                        ""lng"" : 129.0013964
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eNational Highway A1\u003c/b\u003e\u003cdiv style=\""font-size:0.9em\""\u003eEntering Western Australia\u003c/div\u003e"",
                     ""maneuver"" : ""turn-right"",
                     ""polyline"" : {
                            ""points"" : ""vt`cEqd{nX?ZQ@M?CAC?CAC?i@@cBD{@@}CPiADM?aBFc@BkGTqADy@@kBHG?_ADc@@uEPcCLqBNk@FyAL{@FwKv@uCRkCToAJsJt@y@FuCRkAHeBLg@BG@kA@uACkAEmDO}@EOASA{FWs@EmEUI?oFYc@CwMo@wG[}Jk@{CGiE@cGC_D?cBBw@B{@Fu@Hu@Nw@P{@Xm@T}Ax@iA|@MJw@v@s@v@A@e@l@STmAdBcCvDqElHwHxLm@`A?@oApBcO|UaEnGaJtNyH~LU^m@`AaIhMwDbGW`@cA`B_DbFU\\y@rAo@pAk@lAg@tAUt@CHKf@WbAMn@UxAKv@KvAGpACj@EzDEfDAj@EvCKnGUpPAJCpBC~BAp@QhMEdBOrKAh@?j@SzNGhAMzAOxAUtAAHQ|@a@|Ac@pAi@tAaBpDiBdE]n@mCfGoCbGS`@{@jBEJMT{DzI_ArB_Rna@oAnCmAlCSb@Sb@gCvFSb@g@fA_J~RSb@Sb@_HjO_ArBSb@Sb@wPf_@S`@e@fAuBtESb@iFhLsGtNGLe@dAkOt\\sAxCS`@}DvIYn@Sb@Sb@mIzQYl@Yn@}DxIg@fAqIhRgF`Lw@dBg@fAiFhLuGxNqBlEwCrGcE`JaDfHmAlCeAzBuBvEgG|MkIlQSl@yA`DcGtMSb@cGxMs@~AiCvFSb@cMpXoD~HiCvFg@fA_J|RWh@O\\qGpNYj@_Rha@qGpNqTxe@Qb@Sb@wMrYSb@_Oz[gIjQuOz\\Qb@Sb@cGlMuHvPaPd^sLtWGLgGzMqDbIg@dA{@jBeCtFgA|BeAzBu@fBQ\\Wl@e@bAuBrEoEvJuDfIcEbJS`@qD~HUf@qBnEcCpFgBxDy@hBIN]v@gA`CiEfJkDvHqCdGcA|B_CfFkDtHmC~FMVCJS`@sBnECDsBpEeBtDaAvB]t@g@fACFkAbCGPmAhCqC`GkK`UyI`RwCnG{@hBSb@CDaGlMmHrOMVS`@Wj@c@|@eBtDiFbLcClFEHQb@Sb@g@fA{B~EuCnGaArBk@rAe@bA}G~NmErJmDxHmBfEoCbG[n@cClFeGzMsHhPGJ_BlD_HjOKTaAvB]v@i@pAc@tAa@bBG^Gd@OdAG~@G|@CbAAhE?nU?h@AvQ?vb@?le@?zY?d@?fG?V?jSAnQ@tE?lIA~M?tN?vH@dA?fFAtE?rPAvEAtAApY?n\\Avf@?dK?`@K`]InPApP?xSAle@?nYAh@?fH?j@?la@?h@?h@Ala@?rA?pQ?rE@bOB~M?j@DpMD~J?bE?v@Aj`@?|J?~C?dOArE?tA?xA?~[?h@?\\Cfj@@XBrBA|T?pF?dX?nBA~JCfe@?j@?lD@pf@Al[?dT?~BArZ?xAAzR?pM?pM@bKC~WA`C?xN?rAAzC@rHAbd@?h@At^?^?ve@?|F?h@?j@Ap[?nAAjEKxDItAKhAKpAMhAQfASlAO~@Qt@UdAg@lBw@zCi@tBMf@Sx@}G~W[lAMf@mGrV[fAsAnFo@`Cs@fD}AxH{DrSQ~@ENiAjGg@pC[zB_@bDQtBMdBIdBCj@Cl@SxF_Bdd@Cd@}@tWy@`U_@hJYfI_AxW?DeAtZCjB?zC?ZBb@BlAHbBbBpWx@rL`AfKtAfLNvAd@tDXlCTtDJvD@~DKxDc@`IeA~MoDng@uBdZk@|HyBv[KtAEh@mApPwAhSEh@Eh@iA~OuBlZEh@eBpVKrAEh@UfDQjCIbAKrA[bEs@zJWtD{@xLU~CIzAABAh@Ch@ARCp@ChAChA?r@?vADxDv@n_@PrIF|B@h@HrER|IBhABrA\\dP@t@@D?VJhDRtELbCB^ThDjA|OpAxPZ|E@B?Hz@zKdAtNJzAF~@Dl@BxABnACvEAr@?p@AtAAV?h@?tAArD?x@?dE?`@@bBAn@Cb@Cd@EXQ`AkA|FEVUrBG~@Ev@Ej@YvF]tHg@lKWdEGrACh@KnBq@rNW|EUlDSlCo@`Fq@~Da@fBYtA{AvFc@tAw@zBu@dByEbKqB~DqJrRsDnHaCzE{BrE}EnKk@u@fa@GhDAh@QtIExBMdHK|FAh@cApi@g@fWa@xNAh@GbB_@nLALk@|LANEh@c@lIQvDwAdWw@`OCb@cAdRW~EeC|d@gCpe@}@tPCh@YbF}A|Y_@bHEh@_@dHi@vJQfDeBv[K|BmA|TWzE_@bHq@lM_@`H{@bP{AzX?F{@vO[tGQnCMzBUbEEjA[dGMfDA|AA~@AV?P?~@?rA?fBDnBDbB@h@HfB@TDfAH|@HhAzAnRbAzMHhAVxCrB`XDh@Dh@xB~XRjCtBpXBVbBjTxAlRNjBd@jGDh@nAzODh@d@fGpAvPXtDf@rGJrAjAxNx@vKn@lIDh@Dh@VdDDh@JjA?Dt@vJDf@VfDDf@JrAlA|O~Cra@dAxMh@`HBf@T|BJ`A@PNjCJxCJjEDxDAtCGdDEpCOfE?RAT}Axb@_@xJElAIrBOxDaBte@ShFCh@ShFMtCK`DQpEWdHm@lP]xKCh@QhFm@nQWfFEjAAh@}Alb@c@lMCh@KtCSrGiAv[OtE_AjWc@vLQpDu@|SI`CKdEW`LKbKC`LAzAF~IFtB@TFrEV|Rl@rd@LxG`Afx@XxTf@|_@D~BFzEr@lj@X|SDlDZvVBrAH|F@h@ZrWVzQVvR@h@?h@@h@ZbVV`RB|BJfHRbPFrEJhHR|P\\`XLzJLbITzQZvV@h@@h@VbSXvSh@jc@H~Fz@~p@HzFF|FlAl`A?Lp@di@B~BV`RjAn`ALrJBtAz@tq@RxP@h@L~KJlHVnUBzAx@ro@FnEJ|GLfKBrAB|BXxT\\pWFbFD|B?p@LfEXpGXlEZpDZ`Dj@pEtAhLdEh]\\xCzDx[l@zEv@bGjCjTrDnZBTFh@`CxRpGdi@fAbJPpArA|K|BdRNpA`BdN|Er`@\\xCbDxW~CjWFh@PpA|ApMbC`Sh@lEdDtXNpA`@bD`AfIz@~GFh@|BfRtC`V~CjWFh@h@lEvDd[`@dDFf@dDtXPpAFh@TfBjEj^x@~GPpAvEj`@PpAhCfTfA~IdCnSrB~Px@|GPrAnD|YNpAFh@jBtO`@bDzAbMvDf[zA`M`@dDrB|PFh@z@~GNpANpAbBjNh@lEp@tFHh@p@tFNpAp@tFlCzTFf@z@~GnAjKvBlQLz@BT\\bDz@`IVdDLrCNzE@xB@bCCbGAl@]vVE|BC|BOzJ_@jYAh@CrAYxTK|FOdLCrAw@di@GrEAh@MnIYfSe@~[Ah@a@jYuAfbAo@fe@g@h]Ah@QzL[lUc@~[CrAe@r\\e@~[C|Bk@~_@c@|Zc@tYGfEKvJA`E?vFDlMBdAFbCHtDJfDJhCb@|IFhALrB@Ph@`HDp@h@pHp@`JpB|XjAzOJrA`Cp[?BDf@bAdNh@pH~@jMDf@jAbPl@fIDh@bCr[TdDdA~MtD`h@TdDx@`LPzBVdDlBvWP|BvCz`@b@xF\\nEBh@nBvWfEfk@xCja@\\|EvH~cAr@vJt@fK|AzSDf@zDth@PrBxBtZ`Cr[Dh@rBfYJjAlBvWdC~\\n@lIxBhZDh@dArNDh@lBlWfErl@P|Bt@fKdGry@Dh@zAxSVfDjA|OHpAh@bHTfDDf@bBdU~@hMl@lITbDDd@ZfERdCDh@tApRDh@~@hMf@bH\\nE`Dnc@Dh@dC|\\Bh@`Hd`AZdEJ|Ap@tJfBlWXtHFzBR~IJbMA|ECvK?j@KtZ?h@?h@K~_@C|FGlU?h@EpMKtZA|FEdPCbEKzY?rAGnQCfDCfLEdHG|S?p@K~[ArE?h@EdL?f@?@?h@CdIAtH@xEJfGRfEBp@NfCP~BTfCz@nHhB`PzBhRFf@bEz]PxAD`@zDp\\Fh@vJbz@fHrm@~BpS`DvXFf@nCdV`@bDNrAfApJf@nEHh@\\~CBPb@|DV`C`@pFHdBFrADh@Bh@Bf@RnIBfIEtDA|BAh@?VYrYClBOdPAh@?h@CrA?h@MfL?h@IpICrA?HU`]?`@?FAh@MlPQfJBnD@tBPtKPnGZhGFlAXpEvAvUd@|HDh@Bh@N|BPnEBh@PlEP~J@hA@t@@rABvE?dJB~U?h@?rA@rEF`j@CjSFtC@`@RzE`@nE`@fDn@zDlBrI`@fBXlAnGxXtBbJJf@zCxMhBbIxBlJj@hCJd@b@lBhBrI`AbF`@`DFh@T~An@|FVhETjDPnIDxIZdq@?h@BrCRfO`@xLBZXnE|@tNDh@hArQ~@|NvAvUz@|MJbB@Vb@rK?fCE`CGnAI`BKx@Gn@i@pDUtA[|AAHWbAgBdHAB}BxIMd@gDpMOf@aAtDuBdI_FlR[lAoBvH{CjLeA`EMf@gDpMMf@wGhW[lAMd@{J|_@_CbJeCpJiErPsBbIsDnN_CxIU|@sCxKeDlMgAnEq@rCg@dCQ~@s@dEq@vE_@`DCJa@bEWzC]fGWlEo@~Km@dKK`BGdAYpEuEdw@SfDEh@eFb{@SfD]xFwBj^Ch@O|BSfD{Bt_@sB`]_BxWM|BcB~XqAzRk@tKCjD?p@?nAHxCNvBZxDh@nCVtAR`AH^FRt@`CfA|CjAzChDvIN\\fAnCPb@`@fAbApC`@fA`AjCJ`@b@r@Z|@x@xB\\~@hB~E""
                     },
                     ""start_location"" : {
                            ""lat"" : -32.1212415,
                        ""lng"" : 133.6738511
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""720 km"",
                        ""value"" : 719510
                        },
                     ""duration"" : {
                            ""text"" : ""7 hours 20 mins"",
                        ""value"" : 26408
                     },
                     ""end_location"" : {
                            ""lat"" : -32.1852868,
                        ""lng"" : 121.7784478
                     },
                     ""html_instructions"" : ""Continue onto \u003cb\u003eNational Highway 1\u003c/b\u003e"",
                     ""polyline"" : {
                            ""points"" : ""xmb`EwqjrWXp@|C`IjArChDtITl@BLDL?@?@zIhU`Oz_@~M~]pNb_@lMx\\Pd@bBlEzMb]xAtDBDdJdWfH~RlGhQHRFNxJnXPd@pJzWfDtJh@xBNx@H\\RtATtAZrBr@lI\\hDDh@l@pGvBnUTjCPlBpAhNzA`PB^bBlQ?D|@nJpApNlBvSt@`INtCRhFH`CFhBXhKFl@PnBj@nD\\fBHb@^~A\\vA@FR~@Hb@Jp@f@~Dl@|GFp@Ff@n@bH@JBZ@LPlB\\dDl@jGr@xHFf@BZHv@`AzJ?DRzBpAfNNzAFh@l@hGX|D@H@P\\|CFrAFdB@l@?vAYjMKlDEzDDjAHrBJpAD`@^dCd@hCb@xA^jABFv@bBd@z@Zf@bBbCV^PV\\d@z@lAHJp@|@RXj@j@rAlAPLp@h@pDjCfAr@\\Tt@f@xAbAt@h@zAdAdFnDfAt@~@n@B@XTtA`A\\VHFd@^t@r@vAvA`AfApAhBtAdCHPR`@Rb@r@vAbDdHVf@Pb@xSjd@fHrOtRjb@HPdKbUhEbJx@lB~BfF`B|DPh@^bAh@~AZfAVjA\\`BVfBPlAPjBbAdRlAbR~D`n@HrA~AvVv@dMJfBvDvn@HrAbEpr@fDzk@dAhQXzE~Hf`A`Ipv@~B~T|F|j@rGxn@Fh@fF`g@hHpr@xLphAxD|]bBxO|@hIrCnW`J`z@lF`h@^fCx@nER|@Tx@vAtEnQjk@lIhVdA|Ch@fBd@lBh@jCTjBTpBLvBf@hIlH~sA`@dHhBb]tBf`@j@jG\\jFRfDPbD@PBTP~CTbEVxEJ`BFdA?LVpERhDf@xFl@fFrAhKnG`f@`Lx{@T|AjBtL`Nrs@dApFHf@vD`SrCfObEhTJf@TnApC~NvD`SnCrNhLzm@jExTh@~C@HzAxJ|@nE~ArIfAzF~RxdAjSlfAx@hElOrx@jDxQHf@vB`LdCrMf@bCtCdOxs@bxDhOzw@nEtU~Px}@z@fErCxMnE|UdDtPjBzJHf@~Lbp@fHr_@TpAxFpZdBhJxA`ITnAJf@TnArGb]bAnFrChOJf@TnAfEzT`@vBJf@dGz[Jf@VtAhNtt@hPt{@vTnkAJf@j@|CrBxKrC`OvBfLrAhHjArGd@fDTjBTfC^~Ed@zGx@jMfAjPdHreA`F|u@vMvpBh@nIBZFv@Fz@VdE`@|Fd@~GXjEF`Ab@`H`ArNLhBh@lIzBb]Dh@RbDLfBjBxXx@xLd@bHf@pHh@bIp@bKDh@^zFpAnRDj@z@~M@TVvDZxEf@tHf@tHF`ALjBb@nGT~Ch@vHNzBd@dIXlEZlEVxDl@nIRbDZhFFfC@zDIvCKfBc@dEwDr]yBtSEh@Gh@Kz@sB`UiAhKA?e@lEUvBu@dHeBpPgC`Tq@xGMlA}CzZq@dIG~AEbC?dA@zABfAFhAPtBlCvWNzAjAzKrDh]hBbQLpA`BxOnG|m@|@vH`BpP`CbVrErb@p@rFTtAVhAVt@\\lA|@hCvG|NtG`Ox@hBjQv`@fAbCnGvNrGzNfA|Bx@nBf@rAb@jAj@pBb@lBZnBHl@TxANfBj@nI^hGX`EjBbYz@`NbE~m@pFxy@@JvDll@lApRJtA~@vNDh@tBv[fAvP|GleAl@dIh@lJXzFBbD?tCSfFYzG{C|v@w@rSCp@y@lScCtm@k@lNAJmEjgAM|CKlCGdBAzA?pAF`CJvBLvALtAjBrOrBxP~@rHn@pFzCrVzAxLhCbThEz]TtB~@|HrD~YbG`g@`En\\hEr]|AtMj@vEf@bEhClTxF~d@f@xDNbARdATbAPn@r@|Bj@zAhBfE|@nBjB|DhDrHjBzDlB~DvEfKr@bBTp@d@vATv@Pn@Nr@R~@b@nCZ|CLtA^bG\\vFzBb]`NbvBbCt_@`Dtf@dMxnBFbAz@tM`BpW|Bd^n@`K`Elo@nArR`IznAx@jMnI`sAR~CxDzl@b@fHj@vIn@zJz@xMx@`MdCba@Dj@RnCV~DP`Dd@jHf@rHf@nIf@pH|@dNp@tKfAhQZdFT~CdBxXpBx[vBl]dNxwBlIxrA`Gr_A|GfgAfH~hAvC~d@Bh@fC`a@Dh@RfDxAfUnFf{@Bh@Ft@dA|PJrA|AvV^fGN|CHlB@bBCfBIpBMvBYtC_@`Ce@lCsAbHeB`J{BhLyArHMp@Kf@y@fEIf@EPw@xDYpB?DOpACVAPK`BQrF@tCFrBRhFRzDvAz\\Bh@j@nMFrABh@v@lQFrATvFf@hLBh@hBnb@Bh@d@`LrAvZBh@J|BBh@|Gh_BvCpq@`Bx`@lBtc@Bh@FhAH|BTxE\\~FLdBRtCDf@JjADn@x@rJdAlMpBtVdAbMFh@xCd^xA`Qx@dKt@vIh@rGz@hKNjBFd@JdAX~Bd@pDlBfMFZHf@fBdL~B~N|B|NzBrNvBbNpBrMz@lFp@hEdBtK^xBRpAPfAr@pEHj@RbAT`ATx@VbAt@zBf@tAxD`JjGrN^x@Xp@`DjHp@`Bp@jBTn@Pp@T|@Rz@Pt@P~@T~ANjAJnAxChf@Dh@bK`bBxChf@jCbc@pA~SBh@rEru@LjCHfCBjA?rA?dF{@ljAc@pj@KvMEpEEvEAzBIvIK|NCvBMvRAl@Q`Wc@zi@g@~q@SxWgA`uA[b`@{Dj}E]vb@}@vgA{CxsDWv[i@`o@S|UYv[Q~ROnSAv@Q|QSlWMnPO~OUzUKfOAbAAtAAb@AxA?h@G|GAt@ErEEnEObROhPMhOC|AY~`@[jZEtDEtEIpI?h@ExCClCC|BGhHAh@?h@A^OdS?t@A\\[b\\?h@A`@A|A[ja@?f@AB_@tb@EjFQzRArAI|JCrA?h@IrIMzNi@rn@Ah@CrEAh@ChDs@|w@a@tf@_@vb@Yb\\s@xw@?h@E~CCbBAvBCzDGvFE|EEvFGvFAjAIfIUrXYt[SlTAh@GrGMrNCpBMbLKvLIhJM|MEbD?h@E~DEjFI`IIfLU~TQnOM|PG~EI`KOxNAdBCjCAbAA`AA~@Al@CfA@`A?|@BrADr@Bh@@^JzA@DVdCXjBVnA?@^dBd@fBp@pCd@nB`A|DdAbEr@zC`AtD^zAZnATdAXjADVN~@Jz@NpADf@Fz@HlABx@DzA@v@?xBGpEArBC~ACnCAbAEvFKhKClA?h@E~C?HSxVa@je@E|FmA~xAAj@U~YoBxxBMdL_@za@SjVAtAAh@e@vk@InHg@fm@Aj@_@n`@ArCMpBMnAKlAWnB]lB]zAi@lBi@~Ac@hAQ`@Uf@_AvBqBnEMVSb@y@hBo@vAuChGSb@}@jBe@bAe@fAcBpD{CxGg@fAg@dASb@uBtEQ`@Uf@EJ{@hBy@hBSb@gA~B[x@]`Ac@xAa@`BWz@Qr@YjAI\\[xAG\\AHKf@Ih@AJGZMfAOzAIrAKzBI`CEjA?DAxA?tB@f@?bA?N?~B@rA?LCzBB~AFxAFv@Bh@Bh@?BPlAHh@F^@Ff@xC@FJf@fAvFH^VnAJf@BNz@hE^nCT`BLnBJrB?p@BtAG`CEx@Ex@Gt@SdBMr@Kn@U`AQt@EL[hA{@lCSp@Of@k@pBu@dCWx@aAzDa@bBYxAWxAW~BI`AEh@Ej@kAvMI`AGh@g@`GiAhMEh@cBrRkBhTC|@KjBExBAxBFpDT|KPnHBh@@n@|@r^@hAAxBKzCS|C]pCYlBc@tBg@pBk@zBcCpJ{BdJGTEPUfAYnAg@rCUfBq@dFqA`KGf@OfAoArKGd@It@_@vEOtEAh@?rA@|ADh@PtGLrEPzEHxD\\pJJhDLhE@Z@LP~FXxI`@~MZbJPrGP~ERzFJlD@x@BXVtFZrCp@vDJf@Lf@XnA~@rChB~Dv@xATb@`D|F^p@fAnBrBvDhB`EbAzCFZjAhEh@lCr@|Dl@pD`BpJTpA`AnFF^xAnIlAlHb@jCx@vEjBlKtAhJnBrNjAzInB|NHl@|@xG~ArKr@xFzBzPn@nEPrA`AtG@DdBvMnA`Jv@nFJj@v@rEn@|DHh@Hd@dB~Kv@vE`CnNb@jDVfDRpD@jB?jBC~BKnB{@jQ?@_BnZiCbe@Eh@UjEe@xH_@pHIbBa@zIOpCOlCUbFK~ACrA@pE?HB|BBj@Dz@JlABb@XnCVbB`CrN`B|J`@zBv@nFfA`GfA|Gt@lEhBvKzAxI|@~FdAbGv@tEHf@Hf@t@hEzApJh@xCh@zBzArEVp@Nb@Vp@jA|BxAlCPZ|@fBLTdAjBx@pBN^nAxDh@~BRnAN|@\\hCLtBLvBHfBXbFNzBP~Av@pEfA~DbBrEvB`EbBbDR`@HNbB`DlAdCvBfEpAnCdCtF`BdDxBfEvAlCfAvBR`@zAtCzArCdAzBdB`Dr@tApAfCzAtCtAnCjBtEz@dDv@dEb@lE`@bE^~DfArLjBnSnAfI~@xFhA~GxAxInBxLPbA~@rFhArGVpAf@lB|@vCbAnCd@jA`AlB`ClEvCtFzBdEd@x@j@dAbDfGrBvDtB|DrAdC^t@f@fAZt@^bA`@jAh@dBlAzEd@xB\\~AdAbFz@bEr@bDVfAj@lCbAvEFTtB|J^fBlBzIn@tCj@lCv@hDH`@d@vBf@~BlAvF\\`BXpA~@fEj@nC^dBXtAv@jDd@zBd@vBJl@^hBXxAZbBJp@PtA\\|BPzAPrAb@`D^pCJz@Hh@NnA`@zC`@~C\\hCHf@n@|En@`Fj@jE`@bD@Db@hD^jC`ArHd@`D~@|Gr@`F|ArLdBtMjAfJfApIbBtM`AzHh@pDHh@h@lC~@bDn@xBbB`GlBvGv@lCxCfKjBrGzAbG`F|S|DrPf@nBbAhEbEdQnBvJt@|GZxEXdEBh@@J~@nOf@pJVtDBh@bA|OfBjYHpA\\jGf@jJDf@tAnUx@pM`@zG?HB^h@xIjA|RXlFFnAXjFLnB\\bGF~@P~CLvAJfALz@Hb@F^d@zBb@vA`AbC~@nBtCbGpF|KzCnGf@`ARf@dD`H`BdDR`@bBjDxDzHVf@N\\Tb@nAjC|BvErDpHvDzHfA|Bx@dB~@tBfAlCr@|Bz@nC^|AZ|AF\\RbAr@pEPfApI|k@d@bDlC|Q\\~BNjAbK~q@bBjLDj@Bh@?b@?f@?Z@`@`BrKlBjM`BzKnAtIDTv@nFXvBRxANxAJhANlBPbDHrA@PnAlS\\vF|@hOl@nJV~Dt@hMv@~LDn@XbFRrDDnA@nA?bBCbAAx@MxBQzBQ~BKxAu@dKMdBEh@u@~JIlAEf@ANCXqAjQm@lIEh@Eh@QbCc@vFYlDQnB]~B]rBA@Kf@Ib@ABU~@U|@YdA_AnCwA~DO`@mAhD}@rCm@bCg@fCOlAGf@StAMpBIpBEnCKvKMzLA`AKdJAh@GfGOlOMvLGhHSjRSnSEzCMrM?zA@jABv@BbAHxAR`CVvBF`@`@xCbAjH`AxGjB~MJt@Hh@xApKtAvJN|@tBlOhBtMn@rEl@hEn@nEx@xF~@xGFh@v@xFxBtOlAvI^pCvA`KHh@`@vCdAhHJz@zAlKpHfi@~Ln|@PpApFf`@hAfILx@dBlMp@zEp@rExBrLP|@hCxRj@dEt@|FzFhd@NhAfCxSdAjItArKPxAbDjWdAjIPdCBr@BfA?hAAvBG`BEdAI`AIbAMbAMx@Qv@WjAIZSt@qAdEcH|RiA~C_GnPaGnP{EbNyCpIcApCsEjMcAfDw@dDs@bEWvBUpEElDAj@Az@KrO?`AKlLu@hdAA`AQjWSbYO~QCtCOtSMhQA~@QfWU`YGzJQdXGpIIvK?z@DrA@\\H~APrBPfBlAhKl@~FrAbMrCfWZhCtBpRbBtOh@vEzBjSj@nFfA|JdBxO^jDfBzOz@`IpAvLdC`UnAfLjAfKZtCfBdPtAdMNtAt@jHTpBvAhMz@zHtAbNhBlQtA~MjHjs@ZpD`BhPj@nFh@jFJ~@rDb^Dh@`@vDd@jFbDj[Df@?@^dDDZb@|C`@tCd@xCHh@L~@VbBpHrg@f@jDdFn]zCzSjEjZbDvTvAzJxClSHf@`DvTZxBnIvk@RpAZxBdFt]Hf@rAjJnAdM`AfMnAbOj@zGDh@hBdUrA|Oj@dHvAfQDh@h@pG~AdSDf@Dh@xAhQDh@LzAHhAvBxW|BbYRzBnGbw@Fh@B^p@dIb@hFVpCbAzIRvA~BhRFh@tAzKxDf[bH`k@fCrSbBnNHf@NrAfEr]T`CNtBFpBFjCHjIBhCFpFLnKBjB@rAA~BOfCcBjRyBfUU|BGh@mB`Sm@nGGh@MpAeA~K_AjJSfCGh@[lDK~AEzAIpCObHKbEq@lZa@`QCh@E|A[dOEhBKfEGrBAh@O`GQnIEdBMfGAlG?xA?xBDtQBdQ@nL@h@BfR@pNBbE?ZBx\\D~RBfRBrR@rHDz^BpJB|P@`ZH|X@`Q?nADdYAjKDf[@vC@zD?pEDjDF|BRtCBVRvBj@pG\\lDl@zGDh@TdCp@dHD\\Df@LdAxA`Pn@lHRvBl@vG~AhQx@dJ|@xJpApNDh@^dExBhVfCzXnBzTDZz@nJVbCNpANbA^rB^zAn@rBr@jBdCfGbBbE`C|FzBtF`CbG`C|FfBlELXf@dAXh@f@z@dAxA\\b@^`@jDfDTT|DrD|@z@ZXt@r@`GtFnDlDvBrBt@t@zAbBh@v@d@t@Zl@d@~@vAxCjM|WvYlm@nAjCR`@pR~`@lOp[hClFxAzC`C`F|AbDt@|Av@`Bv@bB\\z@Pj@ZdAPn@R`ALp@Lv@Fn@@BLjAFx@LfANlAVlCp@lGd@rEb@lETpBl@tGbAzI`@bEXzC`@rDZzCPdBNxAl@zFt@dHLrAFh@TzBLpA^nD^vDf@zE@@Dh@b@dERfB`@xDj@nF`@rDTzBZxC`@tDF|@NvAJdAJdAR|BTxBLvARtBLfAHx@HbAVfCJfAD^Jj@NdAPt@Rx@^nAZz@|@|B`C~FbCdGfCnG|BxFr@pBhCrGdAfCv@hBz@nBv@lBfBnE^dAd@nArCfHlAxCzApDp@bB`@fAv@nBhAlC`A`Cp@fBhAlCfAnClAxCjAxCt@lB~@|B|@xBx@rBdAfCbA~BdAxBz@jB^x@n@tA~@rBd@bAd@dAt@`BrArCdA`CbAvBfA`C|@nBf@fABDv@fBlAdC~@tB`AtBpArCHPdA~BnApCrAtCrAvCjAhCz@jBlAlC^v@Th@b@`A|@nB~@nBXn@n@rA`AxBj@pAd@~@Zt@p@vAx@hB`@|@DHR`@Tl@Zl@`@|@\\r@Rd@Xl@Zp@Zl@NXP\\R\\V^vArBdLnP~PvVtEvGpg@pt@~DxFjKhOzIfMbClD|B~CjBnCv@rAp@pABDp@xA|@xBb@pAv@dCZpA^bBP`Ap@~Dv@tEt@pEz@jFv@xEv@`F`AtFr@hEp@|Dn@bEd@pC?@\\nB`@`CZlBr@fEjAhH~@vFnBtLTvAbBhKlAfHn@tDvAbJHf@v@|EzCjRrB~LjAfHLx@rAdIvC~QfBtKXjBb@~Bd@nC\\xBN~@Lz@ZhBb@lCTvATtARhAT`AJh@HVJ\\Nf@\\~@Zv@t@zAzB~D`@t@tAbC@BT`@vBxDrCdFzD`HxD~GxD~GvAfCl@fAbD|FtDxG@BbChEpCdFdClEf@|@jDlGbF~IjFlJrA~Bz@~AtAbCvBzDhBbDxB|DbChEdCnEpCbF|ApClAzBrAzBr@jAtAzBrBdD|AhClB|CbBlClB~Cd@t@bBnCnB`DpBdDdDpFxBnDHLhBtCrBhDdBrCjAlBNV~BxDrAvBt@nAzBrDXb@T^nApBhCfExC|EfC~D~B|DpApC@DfAbCp@xAdAbCj@pAvDzIx@jBnCjGbDpHXp@`ClFbB|DvAbDnDhI`CpFvB~EzAjDlDfI|BhFN\\hC~FlEbKdA~Bl@nAvAzBfBxBvBdCVXX\\bExEnBxBrB~BrAzAj@n@JLr@z@LNZ^p@bAr@jAr@zAv@vBHXh@jBrAhGpAbGf@|BbBzHzBdKl@pC^~ALj@t@hDl@nCl@rCz@|D|@bEt@fDj@bCJd@@@x@bDp@lCfAbENl@jApEnAzE`AxDtBfIJ`@fB~GhAnExBlIf@|Ah@rA@B`@z@BDv@tAb@r@fAjBpAzBfBzC~AlCdAjB|AhCjB`D|AlCpAvBjB`D~ApCfCfEnBfDfClEnBfD~ChFnEzHRZf@|@xChFtBlDvA~BdCdEdAbBjBvCDdJB~CHlP?fG@vB@j@?h@BnFHrNHtK?h@@h@BdEPjNNpN@d@?BHhHHpI@j@LfKLrJAbDEbBCh@?PEV[dDiA~KIp@_@fEGh@Ef@{A`Pe@|JKlEYpMAh@KrEWdLG~BM|FAh@QhHAh@SpIAh@Ah@U|Jq@xZIfDCj@Ah@Ah@CrACj@y@v^aBfu@Ch@iAtg@s@b\\QfHAh@_@fPc@xRAh@KrECtACh@CrAAh@YpMEtAAh@Ah@KrEAh@Ch@KrEAh@Ah@Aj@[pMM|FAh@S~IQrIyA|s@Ah@w@~_@a@dNUfLG~B{@`b@KlGc@jR_@zPANs@rYAh@c@nQShIAJOpIYtNYxMAh@}@va@YpMCrAo@nYCrAO|F]|OSrIYpMAh@]dPS|JIhDC`BAZcAje@OrGmA~k@Ch@OjHQpIAh@ErAAj@OfHAh@ErAK|EU|KSpIM~FErAg@nUs@f[s@~\\E|BAh@EtAy@ja@Aj@UzJQlIe@tUCh@IrEG|Bg@nUAj@M|FAh@y@``@IhDUfLi@|VUzJCh@Aj@Cx@EhG?vBF`Bd@bKLlClApS@PvAjWVxEJvBDh@fAvR~@jQNfCh@hJhDno@|@bPfAtRPfD^lGhCrd@d@nIDh@L|BBh@f@nIRfDBh@FbAx@hOPfD^dHVrE^dHBh@HrABh@L|BHrAZ|FL|BL|B\\xGh@xJ\\zFFtAh@xJRfD^dH`@fHTpERfD^dHDh@FrARhDl@bLh@xJDh@L~BBd@RjDZzFRfDBh@p@bLPzCh@fKBh@Dh@lBp^hA`TL|BrBz_@l@dL?Df@rJ@TF~@bAdRr@dMb@~HBh@PrC@Rb@pId@nIHrABV?P\\~F^`HDj@PfDbAjQVnF~@bPh@vJn@dLHrABh@HtAHvAFd@NvAV~ARfAZzAR|@ZdAPj@L^BHJXPd@x@jBb@|@n@hAPZBDPXT^X^t@bA@@RTBDXZNPJJtAvAzCfD|CfDt@x@nArAZZX\\`CfCzDjEJJHHHJHHHJHHHJHHHJHHHJHHHJHJFJHHHJHJFJHJHJFJHJFJHLFJFJHJFLFJFJFLHJFLFJFLFLDJFLFLFLFJ@D`@`ADLb@nAf@|Af@jBNr@\\bBRnABTBLJbA?BDd@@JBP?H?@BT@RBh@?@D|@B|@?j@@Z?N?P?FAnAA|@?@Af@Ct@Ev@Cl@Ef@Gp@ADGh@Gh@Gf@EZMz@UhAI`@Ml@UbAOr@Mf@CLc@fBMd@Mf@kB~HK`@YnAcF|SYlA_BzGy@nDCLaCxJe@lBk@bC]xAENELCNELCNCJA@CNELAJABCLENAJA@CNCNCH?BCNCNCH?DCLCNAHADANCLAHADANCN?FAFCNAL?FAFANCN?DAHANAN?DAHANAN?BAJANAN?B?FG~AA~@?Z?h@@x@@|@@v@HbBDj@L|BZ|FZzFNfCt@nNB\\N`EZjF`@hHFrAzBda@Dh@v@nN^pGJpBHrAXlFd@rIv@dN~@~PpAbVn@lLj@`KNxBHnAF|@V`Db@tEPzAxA|Nl@rGh@xF~AzODh@Fh@Df@T|BlBnRb@nE\\dDLpApC`Yv@jIj@xFZdDlAhMFh@D`@@FLpAb@nENzAl@zFtBbT~Cl[t@zH`@xDf@lFlApLLxA~@hJFf@v@vHxAjOl@lGt@pHPtAHt@Hl@Lt@RpAt@xDVjAv@|CbAjDnB|Gf@dBTt@zAfFRp@`@rAtDhMrApEb@vAT`A@BDNDLBF@DDNDL@FBDBNDLBD@FDNDL@D@HDLDN?BBHBJ@BBL@BBHBNDN?@BJ?@DLBL?@BLDNBNBLBLDNBNBLBNBNBLBNBNBNBJ?@BNBNBJ?BBLBN@J@B@NBN@H@BBN@N@H@DBN@N@F@D@N`@bDd@jDbAnI~@vHf@|DFh@L|@`@hDd@rDVxBpAbKn@fFBXBNfAzI\\pCXzBBRBTHh@\\vCb@nDNlAn@dFf@|DL`Ap@vFdAvINnAVrBXtBX|BT~A@JVzBl@zE\\rCn@bFf@`Ej@xErAtK\\nC^bDNdAP~AHl@BNNlAJ~@p@hF@N\\lC?BBJ@LBN?BBJ@NBN?@ZbCVrBbAhInB|OPxAv@nGb@pDHf@Fh@ThB\\tCd@vDhAfJv@fGj@xEX`Cp@pFJz@hAfJt@fG`BrMdBpN@F^tD@LDZ?@ZlDBPDn@@JhArR\\zFv@pMHnAB^JdAJdA@NBTDh@LnAHz@L`ABZJv@RbB^xCPtAd@pDLlAh@jER~ArAzKXzBPtAbAnIb@lDnAdKl@zENpANhAP|ABJ?B@NBLVnBvDj[hCxSr@xE\\zBDRb@dCt@xDp@`DBHH\\hArEbApD|AfFz@fCbAtCPd@Nb@xBpFZn@f@fAR`@xA~CpD~GhEhHBBT^dDpF`GtJ\\j@bA`BdCfEV^fBxCdE|GDHV`@T^lB`DbBtCxA`CrAvBT`@T^RZfHnLDHXd@NX@@Vb@@@LV`@r@FJFLFLFJFLFLLXFLFLDJDH@BFLDL@BDHDLNZZv@JV@BPd@@BLZDLLZVx@FLVx@\\fADNPh@DNDLFPPh@jClIxChJtAjEpAfEjA|D^rANf@Nf@t@vC?@Lf@h@zBbAnE|@`EtAhG?@Jd@`@jB`BhHH^Jf@Ld@Jf@VfAt@hD^~Ab@fBJ^Nf@Pl@b@lAd@pATd@nAlCb@v@r@hARXtAhBHJn@r@HJJJBBDDHHHH@@FHJHFFJJJHHHr@n@`@Z@@TRFDBBHF|AlAZX~CdCXTFFbEdD~HnG\\X\\VZVrMjK\\XjEjDjDpCxJbI\\VnKtI~DdDhBtA|B~AbCvArBdAtAn@bCbAxEhBxAh@jAd@v@ZfFlB~GjCrFtB^NbE~AlFpBvIdDNHvMdFfA`@dBt@`@PVLPHhAr@bAl@h@^j@`@VT^Zn@h@bB`Bt@r@fA`AbFzEzCtCVVfAdAvAxAtBpBd@d@t@v@h@l@@@f@j@b@j@V\\@@JNV^RZNXLVTf@DFd@fADH`@fA\\~@J\\FVPt@Lj@Nv@Fj@Hl@RlBPpBDh@HdADh@Bd@Dh@Dh@""
                     },
                     ""start_location"" : {
                            ""lat"" : -31.6388518,
                        ""lng"" : 129.0013964
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  {
                        ""distance"" : {
                            ""text"" : ""700 km"",
                        ""value"" : 699598
                        },
                     ""duration"" : {
                            ""text"" : ""7 hours 24 mins"",
                        ""value"" : 26668
                     },
                     ""end_location"" : {
                            ""lat"" : -31.8945321,
                        ""lng"" : 116.0285348
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eNational Highway 94\u003c/b\u003e"",
                     ""maneuver"" : ""turn-right"",
                     ""polyline"" : {
                            ""points"" : ""`emcEizgfVu@Ju@Le@H_@H]JKB[Hg@Pa@LeBh@q@Rm@RiAZcBh@uEvAu@Ta@LiDbAA@eD`AiBh@yBn@{@Te@LsAV}@N_@F}@Jo@FaAHkAH_@@A?[?gA@iA?mB@c@?c@?cB?G@uG@_FBuFBcD@U?mAB}@D_BJOB]BC@c@F[DG@a@Fw@JgAVy@Rm@NgAZ{@VsA^G@[JcAXq@T_@J]Ny@Zw@b@]RYPKDQNw@h@e@b@_@\\UTMLOPi@l@q@|@SZGF[h@s@lAaAdBsAdCQZ_DzF_C`E{@zAi@|@k@|@mAfB}@lAw@fAe@l@W\\Y\\[b@cB|B_BvBi@v@Yb@u@jAc@z@[n@[p@Wj@Wr@_@hAUr@_@tASv@Qr@Ot@Kn@AJG\\EXALGb@OlAEn@Eh@E`@Cr@ElACxA?FExJ?j@CbFGlNAbECzD?`DCnHAf@?bBCpB?h@?^?t@?bACxD?F?L?B?NErGAtC?h@?h@C`FC|CArEAh@AnCC|D?N?NAN?N?N?N?N?P?B?J@L?@?L?@?N?L?@@F?F?H?D@J?D@^?H@D?N@N@F?F@N@N?F@F@N@N@D?HBN@N?D@HBN@N?BBJ@NBPBL@NBNBLBNBNBNBLBLTxAF^Nz@xA|If@~Ch@`D\\rB?@J^Nj@ZrBFz@FrA?P@h@@@?|@?TA\\E~ACh@Cx@IhCOtDEhAEz@KtAGx@EVKr@AHADCNCLAHCHAJENAFAFCNENADAHENENADAHENENABCHENEN?@ELELENGNCJA@ENGLENEJ?@GNGLCJABGLGLCHCBGNELEFADEHABGLCDCDGLGJCDCFGJGLCBEFGLGJCBEFGJILA@EHIJGJA@GHIJIJGHIJIJIHIJIJIHIJGFA@IHIJGFA@KHCBEFKJKHw@p@c@\\UNKHYRMHg@\\KFqAv@QJ}@h@{A`AsFdDg@X}CnBs@b@_@RsErCWPi@Z_@T]RoC`BeF|C_@TEBWPEBKFA@IDKFKFA@GDKFMHIDMFKFKFKFIDMFKFIFA?KFKFIDA?KF}@d@c@TcBz@g@VGDMFKDA@IDMFcErB{BhAuAp@cFfCo@ZiFjC_@RmAn@KDg@Vm@Zo@ZMFKFKFMDKFKDIDA@MDKDIDA@KDMDGBC@MDKDGBE@KBMDEBE@MBKDE@G@A@IBMBE@G@KDMBC@G@iE~@a@J{InBE@[FqBd@}A\\{AZaH|Aa@JgB^mDx@gB`@uDz@_B\\uGvAc@J_E~@u@NcAPcANy@Js@Du@BsA@s@AQAa@Cs@Gy@GaAMaEa@e@COAK?MAMAK?MAM?M?MAK?M@M?I?C?M@M?G@E?M?M@E@G?K@M@G?E@M@M@C?I@M@KBC?I@MBM@A?KBK@OBKBK@MBMBKBMBMBKBKB[HI@C@KBcCh@E@UFKBC@c@HA@KBKBG@E@KBOD}Cn@_Cj@[FmAX_Cj@eAVgB`@IBsBd@}FrAc@HWHkAVmBd@}Bj@k@JyA^wBf@mA^C@GBMDKDA?IDMDIDA@KDKDMDKFKDKFKFKDKDA@cBx@kB|@y@b@u@^{BdAoDdBkB|@UJ_KzEeEpBiHjDmGzCoFhCWLi@V_@RaAd@_HdDeBx@aLrFUL_@P{At@eAf@u@\\kCnA_@RcElBcClAcBx@qAp@wBbAoAl@iAd@{@Za@LQFODg@Lo@PuATMBwAPw@Hw@DE@c@BuA@cCEyBIuJOA?gH[_BImAGa@AyDOKAMAeAEK?IAC?M?MAG?EAM?MAE?G?KAM?E?GAM?UAwAAMAM?K?M?M?M?MAM?M?M?I?A?M?M?K?A?M?M?I?C?K?M?I?C?M?M@G?E?_@?q@?M@M?sBBg@@oA@iADkBFqEPoBFcCJA?eADw@BeFTc@Bc@@O@uAFeBDK@A?M?M@I?A@M?M@I?C?{BJmAD_HZ}BHgCJA?A@W@M?A?K@O@Y@M@K?M@E?G@M?qAF_BHuAF[@oADgADoAFmERc@@{BL_CJA?gBHK?Y@O@K@C?I@M@M?A@K?K@O@K@MBM@K@MBM@K@MBMBM@KBK@A@MBKBI@C@MBKBG@E@AmGwF}BuB_GoF[YyGgG[YOMKKmC}BAA[YaCwBeBoAECYM_@S_@Q]QC?_@OiBk@gD}@y@UmA_@_@M{@a@ECyCoBQMgAu@_IqFMIyAeA]U]U{@m@iFqDGE]WuDiC]W{@m@CAiHaFs@g@e@]eMuIeEsCwLiIoGiE]UwDgC]UcO_KyByAyByAq@e@w@k@sCkBq@c@wByAqBwAcBiA{@k@oA_AcBmAKGuA_AwAaAUOy@i@aAi@aAe@_@QOG[Me@Q_A[aAWcAWc@IoASaAMuAKi@EqCE]AQ?i@@}@B_AFs@Fo@Fm@Hm@Js@NWDeAVcBh@iAd@o@XA?_@Pa@R}@f@iAr@gAz@{@p@_@ZOLs@x@aAdA_AdAMNo@t@kApA{@`AQRa@d@]`@o@r@cAhAaAhAaAjA{@`As@v@o@t@m@l@e@h@]`@QRk@p@aAfAm@p@gAnA}@dAiAnA_AdAgAjAiAtAiApAY\\i@l@qAxAoArAGHcAlAc@f@i@l@iAnAcAhAON}@dA_AhA_AfA}@fAk@n@ST_AdAa@d@c@b@QPeA~@o@d@q@b@i@Zg@ZkAj@_@R[NiDdBkAl@o@\\o@Z]Pa@RcAf@}@b@_@Rs@\\w@^SJk@XmAj@mAn@w@`@UJaAf@gAj@k@Vk@ToA\\c@JcAPmBViALqANkBRw@Jo@H_AJy@HmBT_@DI@c@FwC\\o@HkBZq@No@Pu@RoAd@OF[Nc@RUJsAt@SLeAv@aAt@q@h@y@t@QP]XAB_Ax@cAx@w@p@cA~@aA|@_Av@_Av@_@\\YV{@t@GF_A|@KHo@h@i@d@gB~A{@v@{@r@{@v@c@^SRu@p@w@p@A@YVo@h@a@\\cAz@u@r@w@n@}@v@SRC@YVm@h@iBbBeBzAo@j@e@^[Xi@d@OLEDUR[Xm@h@c@^cCvBMJ{ApAoAhAg@b@gAbA]Xe@`@{ClCo@j@yArAwBnB[XyAnAoAhAy@t@QNsAhA]XwBnBs@n@eCvBaCtB]ZOLsDbDyEdEwBjBgA~@q@l@aCtBwF~ECBiCzBeCxBmBbBwBlBa@^UPCBq@l@i@f@yHzGkAbAu@n@oBfBQNiB`Bo@h@s@n@wG|FkEzDsBjB[Xi@b@k@f@cBzA{ArAuAlAc@\\mAfAEDEBIHKHCDEBKHIHCBQNIHCBGDeB|Ag@f@cBzAw@r@uAnAy@t@mC`Cu@p@iC|ByAnAyApAo@j@}@t@ONm@h@m@h@cAx@q@d@m@`@sBjASLmBbA{Ax@uAr@m@Xq@\\aAh@aB|@uBdAgDhBc@T_Bx@mBbAwBjAA@_Bx@u@^_CpAeCnAiAj@qAr@{BjAiB`AWNGB_@PKFqCzA_@R_Bx@mAn@{@d@KFMDKFKFc@ROFOHULSJMFaAh@aAf@MFWNc@Ty@b@WLq@^q@^_Af@QJ}@d@oAp@[N}@d@{@d@gCrAIDuBfA}@d@_Ad@_@ROFIDu@ZKDC@IB[LKDYL{@ZKDMDKDKBMDMDIBA?_AXC@E@E@?@IBMDE@E@g@NKDMBCBG@MDKBC@I@KDKBE@IBK@a@JSDMBKBMBMBMBQBSBg@HIBE?cDh@s@Js@LKBMBM@KBM@K@A?yBVu@Ha@DaAJ}@LQ@q@HQBgBPSBo@Fg@Fc@FI@q@HaALs@HeANu@HeALUBQBQ@aAL[DqCZs@H[DM@wAPa@D?@aALu@JUB[D_Eb@cD^mANq@JuATaATmA\\aBl@g@ROFaBp@g@Tg@R{@^cA`@_@NeDvASHKDwAn@kAh@WNYN}A|@{CfBoAr@g@Vq@`@OJy@b@k@XKHWPeAj@MHMFq@\\q@d@c@\\u@n@QRA?UVABQRCBEDIJGHCBEFIJIJA@GFGJIJA@SXu@`AwElG[`@UZa@h@GHA@GJIJEFCBGJIJEFcAtAaApACDCDGFABIJCBEFA@EFIJABGFGJIJA@GCq@vFCNUfBIf@?@Ih@yArKIf@ADSdBCLEp@C\\GrAAJA^C|B?X@ZBdABj@?JFzAPdB?@BJP~@BNHd@ZpAx@nC`@hAdBfD`@j@JLf@p@|@bA`Az@bAt@bAp@l@\\b@TXLx@^lBz@JDLH`Ab@`Bv@d@XVNDBHFLHz@j@hAbAz@z@XXf@n@X\\DDHLX^HLl@dAt@xAl@vAb@nA\\lA\\vAZfBDPJ|@JbANrBHdCD|FF~P?r@?h@BrI@h@BfI?HFnI?@Br@HpALxAJv@Hp@XzAZtAh@rBj@fBf@`BNf@Pl@Jh@Nl@TvARrAJnADz@B`@HtAHpD?@BpB?\\?JDbB@^LtDR|BL~@Fb@Jn@RfALj@T|@Vt@JZ`@hA|@rBVf@tBtDHNd@z@x@xA~@bB^t@FNp@nAnBfD?@jBjDbAnBPZr@rAdAnB~@dBTb@Zj@lAxB|@dBVn@\\`AZ~@V|@FPVjADPJf@DLLx@Nz@NfANjAN`BFb@`@jERdBVpCDd@RnBJfABPTnAVlAh@bBPd@Vl@d@`Af@x@Zd@FJd@l@`B~A@?l@l@JJjAnAtBrBt@v@VZLN^j@\\r@b@fARt@Ll@DZJ`AJtADj@Dj@F`A@HF~@RhD@RFfALjB?FLrBFt@ZhF\\dFTdDJrABb@BRLpBHnABl@HpA?LDt@VfEBf@PnCZvER~CDh@LlBLbBn@zJPxB@PLlCD`B@`B?fBClDAj@ArAAh@AhBA~@A`@?FCfBC~@Cf@Cp@C^E\\I`AQjAGn@Q~@CPERe@dBUz@ELABKXEJa@nAUr@KZOd@[`A]fAm@rBUz@Wz@o@hDA?Il@Oz@Ix@ETAPAFUdDGhAOpCARSxDCX[nGG`BQ`EARGlACZEz@Ch@QrDAXAb@MfCObDAT]|H?@MxCAP?lC?|B@b@AF?~AAfAIzACf@En@Gd@UxBK`AEh@Cd@CnBDhD@VBtCAlA?@AhAIpBCR?@MtBMzBElAMzEE`AA|@EpAKrEEdAU~GATIxBEvA?D?DChAK|B?D?B?@IlAEr@UrBYxACJu@rDm@lCi@fC_@dBGZ_@|BKpAItA?@ApBFlA@d@VlB@HHd@BH@Jx@lDVdARfAPlAJnAFdAZnE\\nEf@`HHbA?LHdB@xAEfAI|@M|@Mz@YpAIZWrA[lBYlBa@pC_@hCK`ACXKvACh@Ev@C~A@rCAjB@pCAjD?rDBbA@v@HdAH|@LbAN`Ad@vBfCrK^zA`@fBZrAF^@FVrAXhCFhA@jA@nDDlE?LBfAHfA^|Bf@hBp@dB^t@j@lAFLTh@\\x@Tv@H\\Np@DXD^BRB`@DdBAxACj@ARGn@OjASlAG\\m@tDO`@]jBKd@Kh@UdBOrAYrAShBEd@El@CbBAnBK`IEdAGhACd@KzAOhBMpAK|AQhBOjBAJUjCOtBQlBGdAAf@Af@@`A@DJdC^bDd@vDBn@?XNvBBjBAvBElEEtAEhCC`AAj@IjDKtDALIjDA`B?P@h@Bp@@ZD^LfAdBrJBd@@p@@n@Ap@Gz@ARYzAa@rAGPa@bA_ArCM\\Qp@Ot@Kt@APEd@MdBM|BIv@CTEVG^Sr@Wx@K\\[jAOx@G`@Eb@Cf@MvCQpCInBAp@@d@Dz@Dd@Hf@ZpBRx@`@zAbBbGRr@DLNf@Pz@NfAB~AAt@A\\Iv@SfBIt@Eh@Cj@?\\?d@Dp@NvBDlABh@?FBrA?pAAbABdBB`@?H@NB|@@TLhAJp@@FRv@X~@\\hANf@^lAd@zAjApD\\pALf@R`ADX@DD\\Bf@@dAAtACb@APE^Mz@In@I`@a@~AOd@]lAs@zBK`@qAzFUfAOr@cAfDQd@EJcBxDuBvEYp@u@zA]t@GJEJEF]n@e@|@CFeAlBMV[l@MV[j@EFYh@GJA@C@G@IL_@j@Q^QZKPOVGHU^GJEFk@x@U^]f@?FAD?BCHSZOXOZIPGNs@rBOf@Kj@EVEV?BIl@Eh@_@pD?@OzAGd@SdBCXGj@Ix@EZEd@YzC""
                     },
                     ""start_location"" : {
                            ""lat"" : -32.1852868,
                        ""lng"" : 121.7784478
                     },
                     ""travel_mode"" : ""DRIVING""
                  },
                  
                  {
                        ""distance"" : {
                            ""text"" : ""0.2 km"",
                        ""value"" : 235
                        },
                     ""duration"" : {
                            ""text"" : ""1 min"",
                        ""value"" : 64
                     },
                     ""end_location"" : {
                            ""lat"" : -31.9523238,
                        ""lng"" : 115.8613432
                     },
                     ""html_instructions"" : ""Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eBeaufort St\u003c/b\u003e/\u003cwbr/\u003e\u003cb\u003eState Route 53\u003c/b\u003e\u003cdiv style=\""font-size:0.9em\""\u003eContinue to follow State Route 53\u003c/div\u003e"",
                     ""maneuver"" : ""turn-left"",
                     ""polyline"" : {
                            ""points"" : ""th_bEeidbUXNt@b@TJ`@NVFN@P?X?N?P@VFl@RVHb@PHD""
                     },
                     ""start_location"" : {
                            ""lat"" : -31.9503465,
                        ""lng"" : 115.862115
                     },
                     ""travel_mode"" : ""DRIVING""
                  }
               ],
               ""traffic_speed_entry"" : [],
               ""via_waypoint"" : []
            }
         ],
         ""overview_polyline"" : {
                    ""points"" : ""``vmE}`|y[ldLx|@zXxlUnrA|jg@huTrtQ`h^xpTrrXxeXpsKlcK~iC|oMzmDt`NtgNptJzqNfiMxlGbsXl_Mdma@kjAhgKxaGh}LjuEdjl@pr@xtc@}dDlc^dlGrbY}{Czz\\svFzkYj_GlsWtrC|q}@j|KxmSdeXhzPppMjfG|bGraTbhBtjKjgIpuOgmHhrOkVnr\\gzF`vd@u}Azfb@ykRzc{@iq@`wYc}NbaVowZleO}oFxaNitLv|x@qbNn|j@zlAfrTapGtcPivNjlf@el@pt`@bkFj|Vkj@~e^~|Adia@rs@rtZdzLbbZtoJz|tAhqOv_{A_cNx`a@izEpsQiiLvrjAkvFtsg@bhHrpZyqKtk\\quL|`V_dOfhIulMrhZ_hQlyFzwA~}K|lEdzHqiAxlQhrGnje@pcBfgb@_Cz~w@cHxraAy|H~fd@ogGf~Du[~jFznJtzRjSfpMorEprLe_I|lZ{iJbykAeuL~tWuoBj`[htBvuD{hJ~xGuwJrdZmhW|yy@y{Ytrt@qsGrdJsrBpxQqUt|Mw}HtaGweKxvNpDf}OitFjc]ajPtnUmyU`jQqx_@p`MiiKhrGku_@prAsne@x}Jm|Yzc\\bgLdvTv~JzjObjC~vl@|}Uzql@``u@ns{@zsPlrs@xkElbWzqH`lF|Kzhw@eoJdnr@muBpsq@qgr@hsiAq_Yznv@wd\\ls`@_kYdpVusFriS_sBdoWwtXrb_@oyHbxP{|Ilxa@qmE|pn@slPxbVytPr{^e]tdn@ww@d|\\svMxw^{}Cnty@sCldi@axGfxUsm`@tp`@qnT|qi@srU`f|@yeA|zfAhx_@hj|AzjE~{`B`nE~diBdyHbtxAwdBf{^xmGjlWnyXpm{B|jOltzBb]tqmBlLdbf@z`Nxio@vmDbteAn|Bfen@hgG`oVl{Rzhe@zhSzqs@hfI~jqAvdFtgz@~eQtgdDcrw@zhkBwlUrlt@ajGfoa@vyIf|[ql@f|x@jjErwnAjfGnd[v~GzlGmkElmCucAb{HmlKjgDy`TxqEw}NxQi}XsnKy|Yn`OeaSrnDcdYduJ_xVf~He_g@ps\\skRdo^rgIvxx@dsR|sZ~lFnrXxxErqUxv@p`R|hDvp^txBpfPlbF`bn@ft@|p~@k{Gtyp@~`Zrw|A`Nl|\\d|E|tp@|bMbxZfgIdai@tfKly_@`sElcn@xgB`rnAoaFtpk@b{EhpI_qAvyR|Ch|TfUtqVhnU|xe@vjNlqUdkGju@vR~dGpzC`pQvfAn``@f~Eds\\""
         },
         ""summary"" : ""National Highway A1"",
         ""warnings"" : [],
         ""waypoint_order"" : []
      }
   ],
   ""status"" : ""OK""
}
";

            var schemaz = JsonSchema.FromSampleJson(text);
            var schema = schemaz.ToJson();
            await WriteAllText.writeJSON(schema, "filez.txt");
            var generator = new CSharpGenerator(schema);
            var file = generator.GenerateFile();
            
        }
    }
}
