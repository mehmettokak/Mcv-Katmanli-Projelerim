(function (root, factory) {
    if (typeof define === 'function' && define.amd) {
        // AMD. Register as an anonymous module.
        define(['exports', 'echarts'], factory);
    } else if (typeof exports === 'object' && typeof exports.nodeName !== 'string') {
        // CommonJS
        factory(exports, require('echarts'));
    } else {
        // Browser globals
        factory({}, root.echarts);
    }
}(this, function (exports, echarts) {
    var log = function (msg) {
        if (typeof console !== 'undefined') {
            console && console.error && console.error(msg);
        }
    }
    if (!echarts) {
        log('ECharts is not Loaded');
        return;
    }
    if (!echarts.registerMap) {
        log('ECharts Map is not loaded')
        return;
    }
    echarts.registerMap('安徽', {"type":"FeatureCollection","features":[{"id":"340100","geometry":{"type":"Polygon","coordinates":["@@DKJOHGCmDcCC@CHGDEHC`ATCnQ`QP@FBVNDBD@JENKPAJB^ZNNTLHFAHCBCNI@AAC__SeBaAICMEI_QCCACHCNATDZH\\YVG\\CFAH@JCFU@YECWCGCEE[gCICKO[CMR]HALATIBE@G@KBIBCFEJEbGFC\\OJGRMbQJAZJrJFBF@PFl^ZLF@FDFBPARXR@TNAQ\\TPFTATBBUN@T@NCVIJMD@LDDFNHLDN@`M\\CHADCJGTWFCJ@LD^VF@VQ\\IRQDILOHa@OFY@MFMAGYYIICIACBEBCFGAM@EBGPKDEDSFIFEVGSQWOkKIEEEAC@KDMEKQGYQNIXEFKDCBEACDEHEB@BBBCBAAECBACFAFMNA@EHC@ADAFBHC@ACABCAABAF@BECA@ACCBAB@DBBCBDBA@AEABIE@FAAAACF@FCDDDA@BBBDCDBHCDBHAPD^MZAlUFIGEDMI]CQMcOM]MEGEICOGSAEDKFKLODIOSAGBEHGJCNCHECCMIAE@KFEDO@KCIKOBWDINKLOLGPC@CAGIMCIEIAO@KJKHC@E@KGQAAFKGEACFOBOAGIBACBGDAF@@CCEECCKG@EAC@IAAIKGBIAEBEPHFARUDAD@TFRABA@CMOIG@ADCHANADCDCBKBENG@IMEYOM@IBa\\YDI@SEGEE@QISE]MEAWFO@WKI@_HS@IACCKYACG@EHEBIBICKIEASBYHGAQIEIIgGOASEUQWQUOYWuAQMgUiEEIAEDIAEACCEMKOIGYAWEMAHaAGakC[IGUK_ITUPGZQHQ@SIGBKEGIEI@WIEKA[CEO@ECCG@CBCFGPKDEFYIYGIIUAECAcASICCBGJEJE\\uMEKIEAQCoGMGEACACKCMCCIBED]JMBaQUGAC@QACIAM@GDENHFBBEPS\\@FOHEBKCEEYBGFMPKBC@GMGOYGQFMNid[NGHEDAHAPCFMPGTCFULUNGFELKJGDG@ECKMIGIBE@OCIBYNKJ@BDVFLANAJEFAJ@FJJCJ@FDFDF@FKPO`CNEFADAPEDGJatAH@FENGDaAC@IHO^CBKBFJVR@HARFFHDXDDDHLBHAjBHFTPV@HOVAHBNFNPTTjPXP\\RZ\\\\TXNVNHVHdDd@RCd@Z@JBJJFFCHOHABELANDLMDGFGP@HGBQCMBWNI_PQQ[GwPWJGBEAUQ_KSFWHQHIEQXIBKAKKBKDG@GMEGHG@MCOKKJUACDMEG@KAUGICG@eH[CIAG@WCKEOGEACDE@IPE@AHE@CBCAA@ABBFEFIBEDGBENILOHGNKJ@FEL@HFLAR@TBJCLGHAJGHCJATDRZb@FAHGNAJBbAHQZAF@FBFHNDN@XAHKFcAGBBJFJ@FCFGDMGC@CDADEBBBAB@F@DB@@BA@AFABABC@BDC@ADEBAFE@@DE@@DEB@DOPDDHAFPFD`RPFNJHDLNDFGBQAE@EHCFBNIHCH@DDFTJRDfTVFXZRHJDjAHBXRDFHDTXLJXPFLHF\\JXB~LdTFJ@VA^DJF\\HLHFDFHPZHRDRBVCFCDIFOJIJCJIpGVILGDI@KDKFGNGVAJCHAHBLBFFB`ARBPHHFLR@JANBD[NMJAT@DJLJFl@L@NDJFPNDFDJF\\HLBHCTEHCFGDEAWOC@E@EJCRAJFPNPDTHDLNDFADKDCAECG@KTJFBF@TDXBHAVEBOCUAKB[FFF@HBJAHDFLBJHHDFDHBH@FBD@DH@DBBBAFH@FDDAHDDCFBBDDDFDBBFFDRTHRCB@JA@@PFHBDDBBD@NBBFFBREHEBBJBDRL@DH@LDDEF@BBDCB@DDLEJKLFL@DCH@FCFADBD@PLFJDFDBRAFBTB@ED@H@"],"encodeOffsets":[[120014,33315]]},"properties":{"cp":[117.283042,31.86119],"name":"合肥市","childNum":1}},{"id":"340200","geometry":{"type":"Polygon","coordinates":["@@AMEIID@EHUDQLUNeD[RJHDH@FALIJCT@@HLPTFV@FCBCTA@MAG@IAGBELINGFEHCBAAGBCPCBCDIFGMQAEBELKCG@ETSBKBAHADADQRA\\JJALDTCLFT@RDLHDBN@BADEDSCUBQCEKICI@KCA@ECA@CbQBMDEFENGNK@EFKDADMHIBGNMNITER[BIHEDECCG@UG_OY[EEEOBQFC@CCEOMCEBILIBCMQYWMSMOQISQGCMAGCGAKFKP@PFN@DCFEBE@IWMUQGEE@EDSNWBO@IEGQKQAI@KAKAaOeUAA@CNM@CAASBABQBCBJKXQFK@GCECEWIOM@EHK@A@KGGGEE@EHE@IAAABGDCBAHBJEAKGECGJBHJBBHADGHADB@AAEIE@CB@@AGAAGDC@AIAGCGI@GHOR@LGHK@AFC@CCIFD@DFBCEBAEAAC@BE@GIABAEQIGSA]EDULI@KFGDHXCHEFGH]IMLGNCJV@NHBBALCFU\\IHSHM@KCQAuAUCompanyWebqO@AGEAGCA@CGAACBC@AJI@GGFGFEAACBIHABCFAFADK@@ABE@EHG@@CAG@C@ADADCGA@ACAEAA@CGAUCECEaU@EHGPGROFKFEPCJIDAIKCAEAWDOJGNEBMDG@GA[MOEG@KFGFMBGAYMWEmOOSS_KIUSQEYESII@CL@HDJJNV^T\\@L@PAHEHMLKTQPIFiLgVIFINGFSJSF_DGBK@IFGREDCDKBQ@ED@DJNLPLLNR@HAFQRJHRNJDRJLBDCDEBIHKDCPAFAJDDCBFALH@FFABG@CBCB@BFDHBBHBDJFHDZGTCFBRXPLpZPFHBXBVCJDFHANKPEDCRDPHNBFBLCRCDIFOBE@G@YC_DGBILEREHUHQTGPKDoDQDKHBHCLOBGFIRBHBFPTFJMHADMFCJIBIASBYJ]SQG]EW@[JWLOPIX@VIZUXSJQDgAqSscMKOS]cEgFsmE@DyJDOCEDEBEGKE@@DCAEDCOBACEACEEIAGEBHSVBFADABBBAB@BE@CACD@DCBADA@KHMFKBGAUJ[BEAKKGCUAEDEFCBI@C@EIGCMBKDCHDRHN@BCB[FYPEB[vIFIFAHDDHFLDdBDBBFJVHJJZEZCFOLEHAD@DDHFDP@DFB\\FLXJJ@JFFHALJH@TGRYROHSV`JVLJHD\\blBHGbNBXFZBJHLPFNDDFBJBFCJBFFVjNhBRXvPZRVRXFVBTHPDVHXJHLFHBZGTAFBLJJDJAFAFGH@BDLZDDJBT@`GJ@XLP@XEFB^NTFRJF@HFTFJ@ZCb[JAN@ZPNFCI@MDERCHCRKDCCCMEcEBAFKJGFO@IhGLCvURCHEV@`GP@DCJBL@|OMVAL@FF@DGJCJRbIBCDK@SHIAMBI@EDAFBNCJ@FBFABBDTLFHDAACHC@FJC@DAB@DB@@BKFENARIPC\\BFHFDCL@NDFDNNHF\\LH@ZEDCFKBANBRAH@\\FXJBIFBBGFCBAD@BA@CD@@AB@@CDB@AF@DCBEEA@ADABBD@JGRERKL@F@BFAPFABBDCBE@AECD@BEBCLEHMGQE_@OBGBKL@RDRPJNRdL^TlNfVcNQRIRCHCLeNEHE"],"encodeOffsets":[[121276,32224]]},"properties":{"cp":[118.376451,31.326319],"name":"芜湖市","childNum":1}},{"id":"340300","geometry":{"type":"Polygon","coordinates":["@@RELEZYbQHAP@HDHBXEXADBLPDDBDJLPEIP@lGHpGLGDiFKDAXVBDFFNBBZFFFBHYXKDMFQFA@CEQBTjHBHFDFBABBDFPJF@DENKHBLCDDDBBCCIBCFCFEJCJ@DEB@DFBBHDP\\FRSTOFFZBBJ@JLRAFCBADBJf
L|J@DHD@@FRPRVNZBVR@ZIE@HXMV]l@pIbQRKJUBWJSZWTYJUJS^WdUZMlDTQTAREVW\\HVD\\ORAFAVPTP\\LRCNSzKHULMZIF[VENKdDTSPJANCLCHALDJHBFBFAPDDHBT@^INBHDHN@NBPDHDDLFLDT@\\BJFANVHFEDGFG@G^BjClDDDHD\\CBAEECGCCAEEoMUCKGE}]LKDGAMOWAC@CHIHAP@fDJ@PGRUBE@CAAOAIIBGHCBGDUJAJBHADEDIDETEPQVGBAAEBKBMF@LFANJ@BMHB^BEIMBQCKECGFEF@\\NTH@GBQ@ICG@CCGIKAC@ENUBKCCQGUAQDSCSKIMEAUIGQCK@EDGJCNDLBXENIDC@EIKSKYQG@GBUNMDEBMQKAULIHMDGCKGMKKGWUIASHMJGFQH@DBBHBPLFDFFCPC@ENFFMXA@ECEE_IaCaIcCM@IDCBOVIHQDOAQKEIYsKOGAE@_JUGCCEIGUG_MQQaEYIY[O[FMFURoEYXOFKHSXqnGFOFCQAID[A]CAGAG@MGIQ@ECK@MGKCIFGLIHEDMAGCGEEU@KGOUIUOKI@WJm@SHC@CG@OEE[DKFGBo@IFC@MGGMsGMBEDC@GECMOACAG@GBK@AAEOKIICIAKDGFECMMAE@EEIYc]aWMKMAGODKAEH@BEBSEKBADAPEDS@QHWFQGaK[EEGCMBCRIaUC@KNC@OCQKC@GF@BBBXL@BADWDCBAD@FKTI@BH@NKCIBEF@FGLMLEHKB@DIDPsdMAMBDPudFF@FCFEFEBE@ME¡DBBHFH@DADEB[BIDYRICE@EFGBALGDAJaHCGAACACBCDAJmJNh@HCPBHL`NTAJDFADBHLBHFD@DAAGBAD@FHHAAIA@DCNBLCRABBCHDBB@FCBCJAFFF^ARILOJiP{ZAJEFANDPFHFDLLFFBFBZCRSfADDHFHJHFHNLVXF@FAPUHEF@FBFHDHD^AHFZVbDXERMRKVIZ@FET@XE`@FJBVEpgRE\\BHBDDJXDBPDL@N@PAZHFF"],"encodeOffsets":[[119730,34107]]},"properties":{"cp":[117.363228,32.939667],"name":"蚌埠市","childNum":1}},{"id":"340400","geometry":{"type":"Polygon","coordinates":["@@nIBIDCDADBBBDHbGBIHCBKHAFEF@JDZQJC\\AFABC@CEGAGCA¢NFF@FAFEDE@EEEvcCONANBtcOJC@CLAFGNKHK@EFEJALD@MAGJ@LS@EBCDAXCBC@AWKAA@AHED@RLPDD@LMD@bVQJADDNFH\\FbLRHXERGT@FCBOBCLATFFA@AFGLBPC@CTIBAEA[QGY@KCCQCKIMECE@CBETUH]jDsR_POBMEIACOGEQg@C@@FSAEAQBCACEEIOKC@CAEBEDG@CDK@KEILKFCCA@CDAAE@CFKCG@@CQKACAIFAFGAQEEAA@MACCAACEG@OB@@IDAGOQUKKCECCAADECCBGIQABAA@CCGC@EAG@GAGCECIGKACGBEAQGGBeB}@KFOPOXAP@zBJJL^RABGDQDSFCFBFNHJJFL@L@JEFWRINCFMHAHBNAFCBM@KFGJURKICAE@ABCLCFAFBRCDCBYDEBCP@FNABHHF@DCJOREDIBCJGJBLCLIFSDCF@LE@MFIJC@AECCWKNeAIISUMQGYIUOKMQ[OKQGQKlGHIHkLO@UCsCB^IDKBIA@B@NELHDBFADEBCDCTMXATCFgHABAHBRCHQBG@CCAC]DMCC@WVADBFADCBE@ABDHEF@DHNJABLDXODEBANBFCH@DFNDL@XAJFRGNIN@FDLDDHFKFEF@DJTBP@HKLUNKDIAEAUEUDGDEHAF@JLRDNBF@H@DCRBRGHINghAH@DJRDTLJAD@XDFCPDHDBDJÄgƲ CEvO"],"encodeOffsets":[[119538,33719]]},"properties":{"cp":[117.018329,32.647574],"name":"淮南市","childNum":1}},{"id":"340500","geometry":{"type":"MultiPolygon","coordinates":[["@@EeuLNTJJ","@@FRCNHFFETAriXIbK^KZI\\@HANMHANFH@BN@JFLCH@DVNLDJFR^JDXCJ@JFJD^ILEHAHDFDHHJXTLLBBDJ@VEVRTTbV`ZfZ^L@F@F@LJXLFBPXNLJ^HLHFLZL@D^JFGHADIACIE@ACQ@EJIPCDCBEACC@M@CG@MAIDMAOEGUAAABEHK@GOMGIBYIMAIBCVILMJGTAHBFAJGPOrQFGLCHEhIBC@CKMAABIAIBAJEFG`MPCL@U}O_GaLCJATFHSHEJAJCHATJFAFILBDEAAM@CEBKQAKECED@L@@IBCLFLIDCB@DJB@DAFMDADDJPTRBAFIH@\\HPTLFNEJGFBBFFDDFV@HABIBAHA@EMIBAHCFADBBAAMFER@ZATGDG@IHANKACG@WUM@ECACBIQOOICDEFE@GQBCFGDEAEGSBENALI`A\\GD@LHTCNHLE@GDOL@@FBBDFB@BAFBBC@BFBADBB@DFFAJFDABA@@BJH@DAH@DBD@D@DHJ@DFDJBHDPELJLCJIHEJAJEBCMMSGBGJEBCCIJMCILCNQDATBLHAJ\\DPCNGL@H@LSJEDYOGACHATADAAGEO@GDGNKKOAI@OCM@KLBJADG@QcDFDAFIBC@KEQSEIAGDCDAH@FDBDvKKkM_IeDkDCIM]mADC@USYGGIQGUESBKA]KCBABFLBLAFEJCHUEQYUwQ[EMACOAAAEKMOUDIEKCI@IDQCW@GAKGEAOAO@KESDKCIB[II@GBCRCBGBABALST@FDHKLAFBFNREHCJADODADBHABGDEFMHKJAFBH@JBH@NSBADEDU@SEKO@GS@IDKJEBG@GCQIC\\MfKVCRGV@FJCFJBNAJGFMFKfGDQDQJMRUdMeSkK]KYOWMKOGE@K@ALAHDjDLFLGNKFADAFC@FD@BAFCDAAEBBO@CCAI@IBMJQFIHC@AACB@BFBAFCDE@@BCA@DA@@BC@@DABC@ABEDAHEAAJWI[EG@QBMAABELCDYFG@[KGEMMECMCK@CDGEAED[JOBQFMLE@AA@@CBA@CID@EGDBDCBEGSKACBAAE@EDIAMBEFCJ@NAJBTGL@DCJAQaDIHI@CEEaB
N{PK@IACDO@_HU@GFQDuVKDgH@JEPIHELABdFNFDDCDQLGDQDCF@NDJ@JMHAFALCDCDMBGBCD@BJHLNDBADABQBSEC@CBQVEBOGAFBFAJLHBJJBD@FBH@DLFDDF@DE@CBAHBDJABHAPEPBDHFELBBHR@L@FGDIL@LBPFJDJJNBH@DODKHKPMLCJAXLPDJ@LCPEF@LBFNJDDGFMDIDGHAFBHPTCJKPIXBFHTDPFJFH^NPNNdDRDL"]],"encodeOffsets":[[[121740,32276],[120778,32653]]]},"properties":{"cp":[118.507906,31.689362],"name":"马鞍山市","childNum":2}},{"id":"340600","geometry":{"type":"MultiPolygon","coordinates":[["@@AC@GDIA@MLC@QQCGCBEDEACCAMK@[IKPITH^NC@KCKDAB@HPHDFHWHGJHBCd`VA@KALdNFHHHFBCAEACBKHEB@j^ENAHLHLDFAHI@G@AGCAE@OHAFC@AIOBOCCICGQKMAECSEKF@","@@@FDDAHFLBHC\\GN@JFN@PFXHHKR\\TGO@EBEX[HDBJZHDNEFLFTEHCLAHE^RVVJNDAlOHIEKT@bEJFTAFAW]OKIICG@KFKCMX@RCFECWF@POKOFICGCCBCIGECAAGKECAGREJEL@NHNEBA@CDEEGBADEJGBIEOKMDEBIFCBAAGEIMKAAIBCCGCYECKAaAMCaCOCGAI@WCS@iCG@KAAGEACDaHGFKI@O@GDCEB]HWDO@KMA@AGA@@AED_@YAAGBMFGCMCuNMAEIASDUAMEMGGEIAGJiHODEVUJETEBCBADCDFF@FBHCBBBDDDHCNBF@HFH@@GAGABACIaAAABCIHAAKGB@CGBEIC@EIAOMgBENCBCDA@CHGIEGIIECEBCNADETALA@QDCVONATBDEAE@ANE@SBAHA@EKQBGFCEQCIBCPIBEOCOOAE@EMBODCAACCKIOAAICEWEAIBEC@CDEJCBCAECGHAJEDG@GKSKGYGOBM@K@OCCAIWCCQCQ@QFohUFIAKHIJCJANDPEJ@N@BF@BBFN@DEBADFNFJDNFLAFCJAPAB@DFBDPADCDLJRDG@OBROFKFINKHUFYACBEDOZSPYHkEoFKNYBUGaCE@GGE@GIUGGA]@KDEDQVETBNJP@RGL@JIDIH@DDB@LBBBHEF@HFXD@BF`HB@@FADGB@HC@AF@LF@P@@POD@dGDMDgDMFYbGJAHAVBPFNBLCBAF@JIBANI@@VGBAHCDQHAVABAFeJQBFZ@TYAaBBPAFABEHOB@FABBFABLLHPDAFLLCJIFEHDLCDFDBBHGV@LBNHX@JAF`BBDFBDDDPH@BDRAPJFHVGLAHPNBREFHBLH@BDD@BDHA@KBCDA@BBAJDBLXA@DBFCB@BC@DJBRHHDDF@^BJAVG^Q`MP@LDDD@JI\\@NDJHHDHANEFCRJLJJDF@FGPEBCFCBOABHE@@BC@BDOB@DA@BF_TAFBJGBBBEBBBCBBBABDACB@BF@BLT@ZGNHD@FEL@F@DF\\ENENGJAD@BHLD\\MPJT@VDDA@EXJH@FGC@AAEJAPEDIAGJA"]],"encodeOffsets":[[[119841,34987],[119607,34810]]]},"properties":{"cp":[116.794664,33.971707],"name":"淮北市","childNum":2}},{"id":"340700","geometry":{"type":"MultiPolygon","coordinates":[["@@egCGGGCBU`IDE@KEUWSIUE[AWGQOcWEGAE@OEEoUCBMEAAE@AGCDCA@GCCYBCB@DHR@DCBUC[AEB@DHLAHE@MHAB@B@DNHBFALGRM@CHA@QOSOsAFNBRb`LPLXF^DJHx@X@LFHAVEnB^G\\CbATFhd^PTNLtdrThBRCTIVWJY@UJWPOXK\\IX@VDZJ^TZITAJBJADINEBCNGEIOSAEAGJQHEPADKAGLGRCpCLCHORSVGFGFQJKHA`CZDH@F@PAJEDCDQAKAEGMCODQFCLOBMEGICUDWAGAOEoYOKQWEASDYHGCIEACAGGAEC@ADADAH@BAEEG@BKAECDICEBOBCDGLAJCFCDKAQIICQM","@@E@WBUFGDEJON@LDDXPL@XKRFFBHEJQDCFEOGCIGG","@@BJHDH@FFPDBHFDH@PJHLHNLJFBP@JCFCDEDY@ICEEIMACAKYCCQCEEAGBGLK@CeUE@SLGBI@OACB@DDHBDNBDDBB@HJJ@DCFMBCFAF"]],"encodeOffsets":[[[120812,31585],[119768,31364],[120070,31185]]]},"properties":{"cp":[117.816576,30.929935],"name":"铜陵市","childNum":3}},{"id":"340800","geometry":{"type":"MultiPolygon","coordinates":[["@@M]IEAS@I@AIGACAIHW@ECEGGOAE@YNY@IEBkAEMKIICO@KLTTµAEeAILG@CACEIWEEKCgAMLGDA@DOCMAACCCEMAGECEGQ@EBCFADAP@@AAGACAEOAIICEAIQAAC@KGAAKEA@GCAIAAEAEFMICWLK@WOCG@GPMFIHCVEXAF@B[DAHCDS@MDKDEA[OMKLEHACECE@WRE@MA@DEA@ICMECOBAEISCCMB@GAGII@CBGAGWYLKBEAEWCIEAGLM@CSC{WGCAABSFEXCAEDAF@BLJ@FFJND@BEBAFBBD@FADVD@KTK@CKKEKKYAKB_HQLQHCJ_PgR{TeNaDMAMAUM]wcUS]cOc}sqaYEQAKBKDy^WHOD]@Q@mGSCMGOMS[QaK_C_BSKKsM]IGKGMEQA@MAKAsaoWuWYaOi_UUcY[OgMOBEFMRanSNQHkB[@QEr@lDXCZMVkvQXSXIJEBGN@NLNDNAdCR@HFHPRBFBNAHCJQXAJBHJTC^BJHPBNEbGFMHOVGPKdAXPZDVOVEBMLCD]FEHCRCDYPUBGDEFEJCFARADCVANGHWJUJIB]BaKGF[LCHBDVRDF@NELYVGLERQ\\@FFHRNHJH@JBDBJLJVFDNDNELHDHgHEAEDEZCBKBMJKBCDANDHHDBD@FEN@JLZLXTRDDABM@EBKLCNELGDOFCB@FER@HOVFLBFEHSLSBADGRGDiHEGAKC@EDOVENBFLLAP@HAFEFMHIH@LAFKHE@KHOD@JEJEFMJ@FJLAHARBFLRHTNnJLJDd@PMJCJDNHF@NANB@NBDDDTHNLBD@DCDIAIDABAD@FPRBHGLBPOLMNCNDLFFXXDPFDHBHDRR\\JNBNHF@JARDFBH\\DBFAHDNJFF`PDD@JHHPFNBFDNNLFHF^HTEDDFJDBP@HAV@PACZIRCXEJ@NCNBJYBDbFXAJBD^jHD^LPJDDALBBNFDBLGDAPGDBjNbJF@LCTMFEDGBGCIBGFKJGJCTATBRFl\\dNJN@JDFBFJ@@F@BF@FDAD@BFALH@DJ@BBCDBBH@BBABHB@BFDHNAJBFFDPJJBP@TJFFDD@NBFLDPNNCZMR@JEFAZDJ@XUJKFKDUJENANCLBHLNHRBPFHHFJDBB@DIFED@H@BBJTHJFHJFJLPHBDBFBDFDD@REDGBCGM@M@GFEDIAI@G@IDG@EEI@CHEFG@EGMUWEQGGEOAGBEIQBI@MGQDKCM@CJAJ@JBJLHBLLHXLLZ@LCDCB@FNFFLDFJJDDLBDDBF@HAJGNELGNGDCBEBCF@LDNLVAHCDALORELCJ@HDHNHLFDRBJFLGF@J@DBPNNBLDRCJGHBHDJPJDFLDBNBV\\FDRBJDAVDJBFDDRDLHH@TEPBPFRLbXFDDRB@b@HBBBBLAFDTBFHFFFTtVhNVdXJRFFJ@JAbULADAP]JGD@bBHCFM@EBGbsHIFCBOBCFEDMP_LO@ECECE@EDIII@EBIFEBIBMEKCULK^OF@PDJ@","@@FAZO\\EDA@AGMCQDGFALCL@DDFJD@J@DAFEFCVBHDLLFB\\AVIHBLANELGB@BCDA@CDCDBF@@ABAAABABCAETUAGHFJBFFBDDFABDPFCDB@CF@HLAFCFDFCPzI@CnFH]A]FmBUEG@K@WGwCIE]KWKOWWyqIÍiYaAEEAEYKWIMGIECWKi@yHUFUHMJMBiCoI
W_OiYUKiBSFI^[XYJ[@WCUM]GoEUU_][OKWEMBkPYN_TWFBµA_IoeWYSO]O]EOG[UOTKBICGEAIBWGOBSGDKRGRA`FTHRFLLL@DSL@LUCBC@EACEAABAFC@IMEEI@AKE@CBBFWDEFATBBHD|XTD@DKNBHJFXDBFAFKLXZBHAH@DJJBH@HNADDJTBFPAFDDN@JFB@CNBF@XQF@FDBDFGLKPNB\\CFCL@NCTGDCBA\\NLDJPHEFCDIRGFMCENDLJBDB@HFBBLHB@LBDRBBJNPPBBFBDBH@BO@CBEBAD@FHRDFHFNBDFDDBBDNCPB@HCNKhBLDFFJXDFDBH@KBJFfBS¶SK@LDPJJNLBFAlJFZ@ZMF@PBHHDF@FGXBJBDJH@B@\\BBJFN^JHLNFDD@LCLIFKHEVMVKDEHSNODEBOBGFCHG\\MjcNMREZHHPHND@LANOHEZAFFLDFALEDA@ET[FOAAGEFMHCXBBD@RBDVHbRNA^IFCJADDDNDLDBFBNHpHRDFBRL"]],"encodeOffsets":[[[119969,31819],[120328,31748]]]},"properties":{"cp":[117.043551,30.50883],"name":"安庆市","childNum":2}},{"id":"341000","geometry":{"type":"Polygon","coordinates":["@@BABALBDED@XHFG@GPGD@HFLACABECCBCEIDEDBDAHGGOA@@CAAFK@IDIDEHA@Q@CCAGBEAEIGCDA@CNAJED@DEHBJ@MKGCIAYAICaWCGCK@WBIBEFE^IDGBS@]BIJGTALC`cTKFGJYFeHOLI@CCOJEVQTEH@FDHNH@LEHELCNA\\HJ@LDP@FCJOXUHCJGbIHEJWFEFKBGHKBECIIMOCCG@WBGHGDMD@DNDBN@DADAFI@CEMAQFKBC\\[TQV@LFJNJRHFJDRBJALDFBPRDVFNGD@FFLFFHDHF`NNDfAhJHHDH@XFRFDF@VHJHVFJJDLLXRIFMNENAR@PDJ@PFRVJDTR^J^F^IHIHM@MBKDE@MFMNAFCLMFE@EIICELQLABEIWKGCEHGBE@IEG@CJKFICIGKCOAGDCASFSA@SBKLKDGEAGGEKBSFMACCACDKDCBODI@aGOUQMGIGCAQKKMGCQMCKGEIAIFOHWG@KEM@CDANAJEBEMKC@WBIEEUA_DGLIDKBCCIHKAUCGCOICCCGIMGCGAKGKCAcECCKKAIQKAMAAKIAA@ICCKGSQEKMKGAC@GFGH[JcSM@kKIEACAMMKIMCAEBOSCIIQGAWG]OICCO@MGQFOAOCIBU@EKAUKQGQCEBSNKGCAADEIMCIBIHKBSCW@QFA@CICEKKGKMMEKKEMACDCHIDCDGJELADG@MAM@EACE@EBGAKDEDMDEDQDE@CAUBgAAKAMBECI@EBCHEDUEIHEBYCKJE@MGGEE@K@QGEE@IOUEMECE@KDBHAHGFA@ICG@EBEFSH_HWFGHCFAH@FRLBN@LAHMTEHAHFHRPJL@LAHQROJIDKHKFMROFGBQAOF[FUHCDAF@NIVOJ]HKFKBIAIAGGSUGAMNIDG@UISUKIK@EDSF[CaM[BGBCFMHWBMFSFKFMPKDI@I@WGqYG@[FKAWOKAmAUFKHOXAhALCDSDCF@JCFGHIDQBKA[Og]_KGAE@YN_AGHO@EKA@EJ@HCBE@@DCFCDI@FHCHBB@FGDHFCFAB@DADBBAHDF@LJHBD@FADQNEDEBO@MEGAG@MDKHMFCDEFQVMHAHAHBRDJF`@TC^IJOJCBG@CBkvGPANTdJXDFCXCFEBQ@MAOEI@KECCE_EOWGKAEBORCFCPCLGRCDE@EAIIICSCO@EAEECEAICKK@QDMLSAEDIFEHAF@JJVDFLjE`KZMNQFGFaLU@EvAXDJDHFDHBVBVFZBZFNC`L^HXNJ@VCJBJDNJRFjFJ@JEHBFHDTDHFFNDVAPGHEHCLAF@VDDDNPLJJBVA`E\\BPFz^CB@PI^RP@DQE@JCAEDEHBLBDHBDDHD@HABF@FG@GBAHBFAFA@CAECCAEBAHDCEDABBDAAEDCHFDBFBBFAJDJABSD@BRD@HABDBFFJBF@F@BBFJPJ@@HADDC@BBL@FBDB@@DE@IBC@CBE@IJCLKJABGHBDDDCDDADFDDLBFJBJ@DGFCTABDJE@ADFKHFFDBGF@DVBFF@BADED@DD@HFPFDD@DPBH@FDbH\\HFNBRHRJ`ZFFV@`TL@JZFJ@JEFQDUHQDEDCHALBJXVNPHD`HbBXHBBEHAH@NCNDDH@TAH@LHBBGHCH@DNDJLDFR@@D@DFB@BIFCDBBH@BDJFJACB@FGJENGLGDOPJHNHTHZVFF@LALGBORAHAPH^F^@XBLJbJVFJHHNHFAPSJE\\@dDdCfJLJTJND\\DLAnMTIFKQKESYYEIDMJK@GCS@GBEAEDAFANELALNNAJJB@Z@HJDL@BBBLDFAR@BB@FAAGDAAABA@ABI@BB@FDFNDHFDFBLF@CSFDHCHHT@DFBAFABCBMVKBCLMAGCACCWA@GDADEAEDCFACI@IBAHGNIJGFAF@DAJGCILBDACEECFABC"],"encodeOffsets":[[121093,31110]]},"properties":{"cp":[118.317325,29.709239],"name":"黄山市","childNum":1}},{"id":"341100","geometry":{"type":"Polygon","coordinates":["@@BaAGFIE_Cu_CACPDAIOA@@PB@EXDDM@QCEC@[HEElIFSDG[BEQjCN[He@_B[PaNMTKNATBfAJCDIACOIQOOE[CiKUIIGCEAC@KN
JOBOFID[ZPHBV@N@DAAK@ABCFCJBJBFAGO@KJGCGBEFIBK@GGEMCACBKJUDEJCV@JAFEBEAIBGBAHAF@NRDDHBD@XCHADCBKHI@SBG@CKM@MDENKTAPFL@JCJED@ZDNHPRNRLHD@ACFOJODCPCRBLCLFTAL@PFNELFP@VFTBL@NILIHALFL@DFdDTXDDNBH@DCDBFFDB^GHIREL@FEfE\\MNATFDBDHRJJBF@XHBL@BCFBBA@BDADCB@DABADCAADCBITGHBRAD@DBHCHLLHB@JAFAlCLCTBLBDA@D@@BDBFHBAD@@ABBDABB@ABBBCB@@ADBHEDBBEHDDCH@HEP@F@NJV@FDBTML@DBDHBBXFFCNDLKJ@JFHNHF@LEDEPEBB@RBBFBHCFLALGJCLFDH@ATBBJDJ@FEHAFFHBTCBB@DBBJ@NEACGG@KDIV@@HD@`IVCDBPNJBTCJBZ`BAEHAHAJBDIFGBE@CAABGECAANKACI@ACEBAAAGBC@ECCCC@GHEfHPF@gJIJQ@GNMJAJCPOr}RGNAFBH]DmFQLwBAJKFI@[BE@GAIFMEÉDERIBC@IEM@CBKDCVECGKCAECK@_CEKAEBOHMBKRAFFHGLSK@EAABGAADGACBEICDG]GMIAIDCXQDI@EACUOECCMBCAICEOUJIBC[AMIMMmWCCMUGEE@QFKNCDAJBJCD@LAFYPILCHCZCBSASFIECAK@AIECKGc@IFMPAREHojELAHE@AACBCAGBCAABA@B@KAAMA@QF@LC@CC@CEAO@ED@DLJFCD@CRARD@DHTJ@FCFKEKCO@EACEBEECE@GHA@BIAAcCGE@AGEIAAB@JCBEAACSD@FBLCBI@CDBDBBD@DDBLANCDC@GCEAIKGCBGAEECOAKAG@EDGFG@FNAHYLK@OII@AA@KAACCEAC@SPAZCHGDCKK@OAKCAEHKBKAEG@CF@LCFCBCHC@@AHIBK@ECCGB[JC@CBACEBC@E@CHG@EEBEA@CAE@AEC@AAAABA@CEA@CC@CAA@AAKVGFkJAFEBQKGBGCYQCIEaHIVMLENCPENGFG@EIUFCPAFOCGOMYBEC@eBEHCVABKZ@FCHALHRADHFDHBB@BAhKXFH@DADMCMBKCCEiDS@CG]MUDGPIFMDBBHDDFAFG@CIEBALA@GCAGBCAHKFC@AECI@CE@CDCJ@EGBGDANCBABCCGEGI@QDCAGC@A@EFAPADA@C@AEAOBOAGEGGSIEG@CDEFAHBDADG@IUg@CDEFEFCNADCCCBCO_aaMOMEQIC@MFG@MGUCIIAD@FABICK@EBCFKAQISFCA@EAAQCOFIIIEGBOJCAAGBICCSGAABIAMFIPgBC@AA@MHCGDEAAGCDKHG@CA@IBMCKEKBCAACBGACEAKMK@IGGBCGKCGGGD@EAAYAIFEMCAK@@IAAA@EFIA@CDECKCEEAABC@CC@E]I@CYKEKKG]GKIWMAOKEIW@K@E@E]KeY_YaUSSUQUFI@ACKASKIWGGECGCGBKF]JICIEI@WDICQ]IEKCUM@CDGEK@IAMG@MEGBMNGB[@±lqjSBKPkVYB]NOCGBCAGDCACDAA@ACBCCEDE@BDBBEBF@AJFB@BABACADCAA@ABDD@BDBAFE@ABBBADDB@BGDEACB@BGD@FMBENEBBDDABFABADAAA@GFCFBDAFCDELWFMJZRRHFLCN@LBDFFJFlLXPTRUHEFEJCTCFOLAH@FBNEHADAFBDDJJJZZBHEN@NEZ@PGbKPCJQR[JURE@]UKCI@EDSXIHCDGB[D_NM@KCMGCEKCC@INUJMDS@M@AVSASBOE[SBRSMQ@QWOBEAECE@YKk]OEE@EAqIYIE@CBaRQNIH[PEDaHOLCN@L@HAFSJKBGBQ^DNP\\DLDJ\\hFFHDXDFD@ZEVIDG@EB[DUH[ZYGSCMBGDBDDD`RFJDNBJAbTf``BD@BMJADGDEBKGMSSKYYGOBMLIFGAUMEAO@_RmRSD_BGDCFGH@DDDCdDnGHIPCLFRPHFJBFALOPQ`CtiG^SVAJDFNFLJRDDD@LHZ\\RFBABSJ@BBJLNXNPRTVT^FJ@FFJJJDBBBHELCJBJDLJFPBBL@HAH@DBPBDNJFFABANAtHHNNHD@JEp@HALE\\CFF@PDHD@TGn@XIJ@LHDDJVPVLHV@FFDHBHCNGFKJEHDJHL@NDL@FJRNHH@HBDBB^C\\BJDRPEHErmTWLGPEZWpFVQNE\\E\\PJZFZRbNRH`HVFJDDVH`IF@HBLPZtFJLJJDL@RCJGPUDAJCN@dDbJbD`JFFFDB@NWEEFMD@DOEEECOKGAAA@CRGHENITGJBXVLHNLLHHDNCJGVKLBNRFANCVMHAH@ZRTLJL@FCDMJWFKAMCIDCH@FDLHRVJFBJNTLTDRCVBRHDDALMV@FBDJLDH@DDH@JAR@HSG[ME@EFDJFBNDJBNAFJNFVN~V~RPJFH@FEX@FFPRTTJbMbYLMHS"],"encodeOffsets":[[121059,33978]]},"properties":{"cp":[118.316264,32.303627],"name":"滁州市","childNum":1}},{"id":"341200","geometry":{"type":"MultiPolygon","coordinates":[["@@NqCCBC@AFAFWVa`iFARBRFNA^FjOJEHABEBARCREBGFCNANEFILK@CNAJ@LEFENGPKNBXCHGDIROLMTQFID@LEDC@IJEDG@MGMDEBC@IAOBQJMHEHI@CBGDEBIHADCBCACBICELCBACKDCDICBWGCA@EFCBC@OKIAIDCBCIKAGFCAGBIREFOHKBCCACEGACMojMNGFIFUD[RMDOBAEIEAA@ICG@]L]BKP[BGAECIECKCKGIKACFgLLTATCBG@QAIG@MA@CFC@IDAP@\\@DET@@QE@AKA@AIIA@OnAHBFAF@DAH@HGL@OSFEVGPGVCJCBC@EIAEEAGFCF@RH\\DHBNCDCHSG[@CFCJ@@GBSOOFIzGXGlGREfCN@FBNGJC@CD@DE@AIIDCAEDA@CAGBCCEFCJQBCDGRMNIFODIDOHCTC`@JBTEFCBSDEXGDABCHC\\IJANB|XvPJHFJLJJFHJbCJEDCBGAIOeBIFGNERATFFBJBLCVMLK@GAOIS@CFELEGECCCK@EJMHMEQBI@WCKEM@CDGAEBMFAPCCWAKIBGM@CFEAE@AJCBCAEBCXUD@ND^CBDDDH@RADGAQBGBAhGDEBSNWDSDCFABCAEGCFK@M@AJBLAJCA]tDVDP@lKJGHGLkMC]O@@]AOKSMa_JGaKSYA
ZOYJbS`a~YVq@oBE]IYcUJgCQIAQXYMSHS_YN]{ILGRg@KjiPM\\ARYS`CAYLiDeNMjQdsXSDg@][_gQGGDGHIFaDIAEAGQoyCCSEKEIGAEAG@ODW@AIAUFC@IM]S_aGEC@CBLRBHALAHINQRCBCAAA@WIQIG[GC@KFaNKFQLEBQKAI@GROBCCCECiACAN[BMCIKQE]IMECI@ED@FD^@DCBCAOWgYCBGLSPCLCBC@YGKEi_CAOHEBAB@FDBLCHBJFDLEBIB[BCBKXGFE@I@KDABBLCBMDADALGPHHCC@BEAK^ITMHCDBLGAABADFH@BCBIACBADBJADGBECI@aPIFIDAD@DHBBDBHAFCDC@CCCAAB@FCFMCKDEBEGEACBDNDJ@D@JAF@HABGDGACEMCCKC@A@BHEBµSMFA@A@@AHKAC[EKDOP@BJLJAJDABQDGB@FJDFJAFEDC@AIAAGCEF@JADQBAAFEACECYKEDQL@DL@DDADCDIDIEIBEACGMGCIGACBADLHBFCDO@EEC@GBCHA@Q@A@AD@FMJ@DBBB@HFF@FCDFFBBDCDOJBFDF@NABCBEECB@VDFLBBCAGDCHCLF@DI@AP@BLDDBFLKBC@@GCAKA@DDL@XGHSLE@ACDCLIBEACECG@ECEBDXADADIB@BHJ@FBFGNBJFLBPAFGFALBPFFLhDF@FAJCBGFADAFBLFDJBPGRAJ@BFGLCFSJCDIL@JDLHL@DML@LBBV@DBAHEPCDCBGBUCG@SFMFGFADBPAFEFKBGF@FDLADEFqDKCIEGAEBEBUPcA[DMBaBEBCDBFVHDD@FKRoTWBe@aAC@QKK@CBCFK^IHMDCDKVc@IDGBGJEJ@NDDbP@BCJQVBFpGRBB@BFD@DHFBHBEHGBADEBABCBAH@ROXBDBDFJAHABAJEHIDEFQA@NBHLRFV@FCJCB@B@FJHFFbFDJD@DDDHCB@FlEHA@ABCHDFC@GCBDAAAFABI@E@AFCN@DADGHEJAAeBADCbCZOfGDBPJF@BADODAHBNF`ARCbABfHBBBH@NBHFJNLdPHCHAHCBEFHPNHDZ@FBDDHNB@H@TGJ@DBFJ\\EHEF@BFBPF@FEDBBBDPEB@DCBDRGNCJ@HFN@DCB@DC@DPBHD@FFZDDDPBFD@F@BUF@B@FDFNFHJDDBDCT@HJLLJBDARGVEDD\\DABDJDLAJCL@DD@BAHCF@FLtABCBSAGDBPInEDsACDAD@FNVNNDFBDAHILMR@DAJ@LFP@H@DED@DFAJBBFCDDHJELMVDBB@\\DN@PID@DB@@DFABHB@BFEB@LAB@BA@AFDDHJVPHJ@@BDLG@GN@TK@E@@@ABFHCBA@EDALNFPGNJFBDAJBDHBDDFZLLpJN@D@JJH@D@JODADAVDRHNDBADIJIFAJHDBJBLHN@NFR@LGD@HFBFBRDbHhD","@@@AACAD"]],"encodeOffsets":[[[118416,34392],[118283,33249]]]},"properties":{"cp":[115.819729,32.896969],"name":"阜阳市","childNum":2}},{"id":"341300","geometry":{"type":"Polygon","coordinates":["@@DALARHhTVDJ@FADGBEAUBEBCJGTKREPARBHEDKAIHIJGJKCO@IBEHIVQVKLIRGX@JCZSDGRMbUPAHUCIICI@IBKFE@GAAE@AHENAp@FAJBRAHBXEVMbK¼@lI`K\\QJKHSAMBAHAFCHMXOfcJKh@bDDBPLRJvLVCXI\\K\\EDADCLAOc@OXCPGDG@KAKU[CK@IDGLEAKMW@SFIZQPI^OFARADWNGFFBGFMi]A@GFALBDBFADGEGGMEKcLBB@_UDcGAHIXGEGGCGOA@CBDL@LMDG]JSLO\\JL@BNDDFBFCDADHRRD@NKB@CJ@HBDNBNQDMPFTEFEJCHA\\@LILMHGLCX@HEFOBUAC@EH@ZGHDNAK_TBFANGVGVM^@@LJ@ZUD@@BLP@HFFBBDFBFBPABGJGNCRAD@HXFHDBL@\\H\\BRGNKNGDGCIECAC@CDEHAP@FCLKJKHSFGJEJA^BRDlRbTdFFBFBJTJ@JARK\\ULKDEE[BGBIJEFCHADCDEHUJMFAHANDLFDDFJJDXFLFDL@RELGHADFDJ@LELGHIR@@GhYFEDA@CHCBC@KCMC@EICMBKHKJGBCA_FGDCNKLOVmFIPMHCLB\\RPFJBLCFCDGBUEOAGE@F[CCEgGC@CLU@GGcG[E]CIKMQCCEBCAGDENEBAFKCGB@AAB@@CBA@DNCAAHCAKJABBD@BB@@@AB@@FF@BFJ@JJT@LHHDFFBD\\FNABAHBJDHBVGJBFBH@VCZGF@LCN@BKD@JENBCNCD@HFB@DJ@@AJBADLBBEB@BCVEPCLDNFFHDV@FBDFJNJDAHIDOJCJ@XF@ED@@APC@DJABFF@@EL@ACB@@EB@@CD@BBHA@BHBCLDBABZD@EDB@EF@@DA@AFF@ABTL@AJDDB@BBB@DBFD@CJFJ@DANKLMVKPA^HnK@AIEEIGCE@UDM_@A^IEOC_DO@SFS¡QIHOD]O³@KA@@CS@@EB@@GJA@CF@@CD@E[B{`WBMcEAKQGECECI@QACEEAeI]@GRQDGCQ@EHGACGEKMYUQGCA[DU@AAACBGJMHAGCCCkCiD]A@HEHCHEFUGBMIE[AS@KCKECCCGAO@MGMGCMA]JS@GACCBOAEAEIGKCGBKDMDIBOSTcCMLUFE\\YJKNGVyLMTQD[KSOUOEBQB[PUC[GUXQFSBSRkCYNcV]XITIVSZYXITAXIVQLaRoJk@U^WN@G
FYJQ@AUMYQUQO@EC@CGI@K{IeCAABEDQBIKI@AAEYPETSEQO[GCAACEA@CFI@IDEFEDADDJADCACCKDGAMLCFE@OICEAAABCEGEGASiRADFB@RENELCZWAGEEYEAAEMCEUABWLCjEHCHKGokHO@JOFIKACCCKOCAWBWFGAGCO@GBaRYZKFQFLT@HCHIFGBDHBFADIDCHDDL@FBFXJDBBJPDLBDDBPCNA@FBFPPPDAFOJADDJFREDAHJPBDADEBAB@TMF@BBFCFSAIBGBSPATKBSBCFMBADDFJFHJJFGH@DCBADMDAFNhBPFJD@FJHA@DHABLGBDJBABBJbBDBADLADG@GEE@MAGDCCACAAGDEAE@CECDABADSFYTINGTIfBHFJHHFNBNCVBTFJNBvMNDHDNEHABB@ZC`BF@@HB@BNB@LCPGXA^DFHCP@J@ELGHCbBDHFBB@LDH@jDT@XBJDHDPDbBN@\\DLBFZFHDDDJABBJHJN@HEFAJCFLNFPAJIHCFABFHCF@DOHMGK@IFQFBHFDHLBBFDJHADDDDHEJLPOPE@DXEFQDW@DLEP@JBFLLPLX^EBSBIEaFS@FLGJ[LSFIMUU]QGFKBGDSFKEFECMYGAIGCW\\AF@FHNABYSLQGGEW@OEM@IHMD[AGEKBGEIIBBHCJOFIBBF@BDEHG@WI@FCBUCS@OI[NKCAGC@IBMHMF[FCEE@K@EFC@MGYHS@@DEHIZQLAJIH@HILBDF@@DEA@BABADE@@BC@@AEJBPCHGLIJKF_DEDEDER@JBVNb@FFHNLZHPJ@HIJAPK@EDAHGFBJGHHFGJ@FALBHFDBDEHBHCHDDR@FDFJRFTVBFFB@J@HEDABKFGFCB]FOBMFkJY@[KUQIGGGGESCAJMNHLCDG@OE@AAA@AA@@B@CCAB@CAABCEDOA@ADGC@DKE@BA@@A@@ABA@@AAA@D@CA@ADC@AH@CC@@DA@@D@@ACC@AFIA@GA@@FKA@DaGGGACOFAHAFPZFLI`CHEF_NeLSLKBYLQRERIL]PODMB_CG@UFWJGJ@FPL@FAJILKLMFOLWLG^UTEJJLBFAFBDH@DDFNFDAXXBRRJF@VIF@DOXBRHPBT@JADBDAHFFFBJAVENMFMFEHENEJNDLDNNRXHN@DDDP@PDJJD`ANGFEN@HFBDD^DDHDXD^FHFTJBB"],"encodeOffsets":[[119168,35472]]},"properties":{"cp":[116.984084,33.633891],"name":"宿州市","childNum":1}},{"id":"341500","geometry":{"type":"Polygon","coordinates":["@@RRHPLR\\LNVPZJRHVNJTBJMfXLDDBFD@JINEF@@KDETCJEDKAKHIDIJAJGLMBEBGGEAGMB@EDOFAZCDADCAQBEDEDKBAF@DBLJVQHILEN@DABEAMBGNGDEJMXQFE@I@KEKIIMGAEDETERCHCBA]QIKAI@yBOPWPOLE~@fACFBBB\\ELAVBPDD@BGBOAGCW@SAEIELSH@FDDBLCBCCEKMGCCSMOEOBIDQFIF@D@XPFBHCDEFGDSAGGKE[CICEOMIEMCK@k@IEIK@CBSNI\\MACBM@IKQGEOGQA_BEAAEAKBGDGBIHUHMLELCJ@HCJKHUJoDIJIPIJEDCDEAUCQGQUaECKG[GIE]CUBI@EcS}KWAMCMEGEEKWOKISWGCCEWQGAiBICQGWYUEeSQCGAKGCE@CDGJGAMDEFGF@RBHACEKMGCMIOE_QECEOGBCCPO@CFA@CF@@CF@BEFABCD@ACD@BABABEB@@AA@@C@EBAAAFABCDCD@NHHCDE@EEIAIHAdBLEBG@WCMGMAE@EBERYBGAaBIHMBG@EYaCQBSDIHGBIHGDKAI@SBQEK@CFO@ELIHMPGJKFMHAFCJAFEAEBAB@DBDAF@BGF@FGBEDAD@DCFBPHLFXDH@JBNBNBfGH@JDVHLBH@NFDCVBLIPLNDH@HGNF@HCHALLLLBJARWJFRGXGTE`LVRFBHAXIxO\\HRR`OJXMNARDHA@GHOHENCCKBMFKBAPGBABEEEIIIA}@QDc@cCUGMGMUSW[[QYO[OWSiS[CM@EBGPU@GOUESAGBiAGGKCCWCGCEEBQ@GUQEIaVIBC@E@EEIQcWMUQ_W{EEGEAECSBEAKAAGAa@A@CQECaWQKOEOASFG@KGQCCCAECIBUICQAECU[MACAEKICIOGCGAIHQDKCMAOMCAI@E@KHIEQAECGKGMECK@KDQFKPCBGDUBMKKCE@ADAFCDMHKHMFIHGBE@CAACCKICEIKCEEEMA@CDKDY@KKGWKKGAIKIAI@IB@DDNCLHR@NAJJRAFBHFPHHFRVXHN@FEHGF@DFJ@FCH@J@HBJCJEFALBJFLBDEJQFC@ECACAEACOGIKIEEGGIISAAG@C@EFCJA@CAEIGGOEQAMGGKKAMDMBIFCVELILWVI@YCEBIFQ@YNMDOMKCAE@MCCEESIO@IAOIECAEBIGMEC@AGABAAAG@AADCAAI@@CKGEB@ABCECE@@A@EI@AECE@IIMcMaWICQEYAMBIDIHELAHDJAHCHEFSNKDE@aImOOHCBGFG@OGBKCCGEmS]iACBIEWCaMBeGKBGDAFCZCJEBGAK@SNeJGB_IIBCHDLBPAPCF[JMLQRGAACA@EHKJOXAfGRCLMJGBEASGQMGIMGCAK@aJ]GKECCAEOKKCKBKLALOdEDGHOJMTGRCFKJWXSTmNoHQCIEIMGUEGIGMEWECCCK@GCOEKEEECKAGBeZEFIRGJQZCH@TAF@LATDTAFSdEHUTWLMBSEGAOAE@CDIRQLAB@FFPBXHJAJAFA@GEGAC@CDEPC`CJADIFE@E@ECG@CH@@YOEKA@A@KLWD_HBDTLBB@HOR@DPFNPFNCFGD[VDJPPDFAJBN@TJNYjAHERBHEJ@FHNDDXHHFHJVJTNJPLZBLFJGJ@FJTJHDRJH^JHFRLTDFBFFFN@JQ\\IL@DNHDD@TJDFJDLBBfRJPTNHB^GJ@FHBHPNTBNDFHBJRHNNPDVJZTJNPF`F^`FDF@NCD@DIJEFAF@HDHBLGFAVEL@BB@DIBADFBAHBDL@DLBBLANBP@JJRGPEF@POPCJD@EAABAFGHCPPHDJLD@FGD@HHDJLHD@DG@IFGF@RFRCPBFDHNHFFHHBLADBBJBNDH@HAPMLEHMBEDAB@JBDBNB`ADBFFJAN@BLFNXN^FVCJCFAFBJONAHBRFFJ^JJDL@DCHBDDHFBHCFHABB@@DC@ABC@BFEDBJDAADDBGD@BABDDABBDEB@CA@AD@BGFBD@DD@ADF@@BD@ADF@ABADBBEFBBCDBBBDE@FLABBBZLDFHRAFUNKjDDFDBF@NHRHd@DCJ@DHXO^EHKHCH@XGNMd@VD`HTDFBHKPGH@RCNABQDABBFNJ@DCRDLC\\KJANBPAF@VBV@PEJGR@DELAJBLILID@FBDADBBDAB@CHBBB@@XABIDY@CDDDRPHDH@@VDLCLMFANOBYAMEABADFJLNHDZLFDFL@R@Dr\\VVDBD@NELBTL`h^\\h@TCtWRcNifMjCZKDBT_ZBQN[jOLih@HQJK^|ZMT`TGZNRWJBDRIhdVJZF^pAr@ZUb}T_aZIPYZBLTHb`INbLTBP@^ @^P"],"encodeOffsets":[[119435,33336]]},"properties":{"cp":[116.507676,31.752889],"name":"六安市","childNum":1}},{"id":"341600","geometry":{"type":"Polygon","coordinates":["@@BA@EPAFGBABEAObAZB@SEYRAfIBEBABURGDCBGHA@UJ@BMJA@IBEDAAKEMAOBUBGHIZaNEhCNCHC@cPC@OO@E@@KBED@@GHABC@EA@_GAEC@EW@GFEAGAA@KCA@CJGJC@IHK@QIOAMFSRUFCLC^@HBVHHJF@HHF@bDVHZALMpElFZGTOPYFCDAZBVELGJMLEPEQPAH@QCKIDCBCCOEA@CBABODIBEEKCMEIEMBCFA@CEMAAE@AIBEFICUBGBC@CLKLG@EF_@WFS@EBCHULUNQFQCWUaEYBGC]CGEGEAE@GFOVEBE@UWMKEGIGEGCGBCTeDQAYAEEEKKECEGCOBMFEBI|YjOPIJKBQE]EEIBADEDA@CADGAAQBKDMACDB@BJGBEGC@ABBHCBC@GEKAAGBCCEBIMSK_AGDO@GMg}RFDƱÃhAEEECGDOCE@WBCKICSIQ@CBGhgJMHGAQDQ@C@@EHEDeFGIIEKIEIIGuO{WMAIB[JGDADCBWHCFATEDSFIA_@SDGDCPCJEPMJQNCHADIREDDFADBH@DCBBFCDJJ@BCFC@@DIDMHEAM@eDQFkHWHyHEJPPAT@HI@ED@DH\\GTCDMDGA[CQGE@EDBHFFJB@FADIDUDOHUHEFTPK@GHG@CBE@EBGAmB@PJBBJB@BLF@@RS@CF[@O@CB@JED@DNBH@BJ@RAHSDSBKKE`BLJLLHLDFDDJBFAHO\\ALK^@^DH@JBBJFBFPANC\\QVCJEHENMpiDNHBDFDBADGLEPQFAJBHEDBHJLADCDBJLJ@PADED@FDBXHDACJCDDLABKDDFAJBDADCDGBAJCFAH@DGJGFINARBP@JADCFHN@NCHIF@JCDKFC@EJSRKNQPCJGHWDKAA@MLMHGFKFI@MB@DKLEJMFMBEDAHQFQDABAFGBIFgP_EMBQEU@ED[fUbEXEBAFDDQzYOPOVQ^BXELAF@HBJPBGFAFCBGL@LLTAFGNCLKLKRKFIHEN@HMNFRNBDDBFJDD@PIPC`KFJDNFRATBHDDMJADDDPDB\\TJBBANCFEZDB@DGHG@CFA@CDAACGM@KI[DGDEHIFOAOIG@CB@HA@UAAJBPDDNCBBDDBH@BIFBFDDDBP@BDBFGDIF@BBABBABB@AB@DDPDFJFAZFFLBBBCPD^RFDNDFMFAJBBFBJ\\\\DBFGNCFFHHFNFHABCDALF^@PFCVLN@NFBF@JGFAJDTPXAHBNC@EBARHBFTHPJFBNGVITALBNHDDFAHGNEFGdEHKPOJEHGZOBCAaFKDCFAHBRALBLAAd@PLHJ@PGDIDQDEHCNAPDNEnCRBTIVQbeHIDIAIGYEGG[CEGWAKJQJ@PBVCDEBA@UVAJALE@MHDH@LMBEHAF@FAAOCGBAPGBACOAK@KCCQD@HG@CCAI@AZABIFA@AAECEE@AGVI@E@ARE@CEG@EFEFANDb@BE@CEEFMDIJInKDCFEFKHEAGDG@EDGHOLMLAZBFBPLHHNHJDHBHAHBnHN@HCdBNJDJRRPF`HHDLRBHDBLGLADPRFTDFCRAHFJAFDJAF@DBBFFADB"],"encodeOffsets":[[119188,34594]]},"properties":{"cp":[115.782939,33.869338],"name":"亳州市","childNum":1}},{"id":"341700","geometry":{"type":"MultiPolygon","coordinates":[["@@BC@CFE@KB@BB@BB@B@AIBACA@AqOEHGFMCS@CDAH@FHFVFFFFL","@@EIGKOIG@ECAGOCEEG@GCAIpZXV`Jf","@@DENADE@CII@GAACCMAACCG@CDAPBJ@HATKF@fV@DKLAHBHFFRDDDHTHHNBJP@JAPAJCFEDIDO@EAKIAC±D`N^BLBZAPGTCFST]\\EJATjVLjZ`PXpJjDNANIVGVEzGj@XLFDHJJNLXFZFBBFbZÎjrJrAQCKAABArDTPRPDABEN@HQBKAEMG@EPIF@BGGK@CFA\\BVDDA@CGQ@CDAZADD@HDBDCBHF@BBNFDApVFF@PBFFHdXRPXH\\BVFTJVXLFF@JCV_DAHHDHfhRQBE@GMQKKKOIM@CFCR@LADCFCHQJEL@HA`CPCXKHEJMjWTG^GJEROLSNKFGBGBGASS[U]MW@GDKMMaUEQKYEC]AICOMMQQKUE_CGCGEGI@IFSAQCKGKGGMSMGMQIUIaAK@WE]G]@EBIBGPQHABK@KEEYUSGMGIGPOHCHKFMHI@EDAIBIEACG@AADCJE@AEA@C@CQ@CEIKMC@CDGHGAAKGG@SBG@CCDM@MBGFGAAWGaA_GGCMOWUAIBKDGFCRCVGRCFE@IEIIYK@_SU@EE_YQIQGMA
E[GaGECG@OA@CCCOEGEC@@CFCBC@AEEUA@CHECAEELGCE@BIFACSBEDCHI@IAAECKECBCCCCDCCGAAHIBKLID@JAF@DAD@JCF@@CAEAK@AAD@CCGB@@OIEIAAE@E@IAEECABA@GQC@ATCBACIBIAEEACAGECDBFCBAACBDFGCABBFDDBF@DEBEBGAAB@HEHE@BA@GGCCCGAACAKFGFCDB@IRF@CQOJ]@ODAaWCM@_FUBIAKIMOCCIAQAKBGDGFOHUBMCEECGCSEGGAIFI@iEQEMIICIAUDI@WM]G_KMDYEYAUEUAMECGCSHUEMEI@MBKCIGMAUGKGQGIIAE@SJWAOCEECaMKGCGEGSOIAO@GCAGFKFEVKFIPEnMLGHMFOBKAEMKOGWSAG@GRKHKDGEQMO[Q[M]EGCWOGAQCwJU@QEMGGIKWIIECYGSAQEWKSOw]SGGEGGCGIKSUOWUMgIoDMFCAE@ED@DAD@FJVDFCBE@KFKEMLEBECGIGEKAGESaEEKAADBDABBLADC@DHAFCDA@ABBF_NWNEPKLSP_REFAHBHJPNL\\VFFBHAJrPBADBF@ADJEFH@DAHM@EAA@@JAD@DAB@BAFGA@CqDN\\LX`NFDPXLJBFPJLBLJLbNNLJH@RENKFARFTPTJFHR`T\\RLJJRNPRLPXXHLTv@PJTFR@HKZKNgXMCMISISBAMDGCCCBGJ@JAFBJCBBD@DDF@JCPFJ@FADI@gQIAADCLS`GVCBKAKJCRGJC@IAGBKPrbtd~P^dVTxdHPFNBVBNCNMbSfQ|OhI`ATHPAXBJHFJDLAPS\\VPH^F^PTPXZpf`J¶BAXE`SZMlONAXFTPo@@"]],"encodeOffsets":[[[119500,30421],[120113,31219],[120071,31182]]]},"properties":{"cp":[117.489157,30.656037],"name":"池州市","childNum":3}},{"id":"341800","geometry":{"type":"Polygon","coordinates":["@@ADEBFDDFCBKADJIHCBE@EBIHMJGHAB@JDJEBCDBFCFCB@HXBDDDBBHKNADULANADEBABCES@GGGDECDTE@AKCEGEMCCE@EAAJ@BAB@BABBHCBB@EIAOBKCAA@ACKGIY@A@IIMBAAIKC@GBMFEBCBBFAF@HDT@HILCNFJZZFTRLELSJmNKB[CMCSIKIeIcDcC[@IFOTEBNTLLHTBRET@JHJHFHD`DVFRLNRPNJD^BFDHPJ\\bVNNJ@TJZFRFVTLJT`PTnPXFZNHBNAHELEH@PFTLPDPALCHMPIXCFBDBJLCBIJODEFELQPOHGH@FbVDFDFBVDHB@FBDB@BHBCDCB@B@DBH@DH@FGF@BA@@CLEBEBADGBAJBDFBHEHE@HIJ@BADBDHB@DDBBHHF@BrPPTVNvBRBLDN@TGJGV[DEBKAAMGU@DIHMNK^JHGFEDGGWHCLEJ@VKFCB^HTRJBFBAHJF@@ABDFBABDFEA@CECDJ@DED@BGLKHQ@GP@HHJHDJB@BCDBHHB@BA@@DJFBF@BCAGBCHGBAAGIIADHHFBLIFGAABCDAHBBJBF@FGF@HFHH@L@BGL@FPNXJDFDF@HELWRILDARABATABB@DMN@DBBfVbPLBLBJ@RBRLFH@JAPMXCT@FFFRHNVJXF@FADE@CEM@OLOLEHBHDNBHDTRRJNPNTZXNRADKJAJDFPNDF@DEDARFPFFZ\\`PVHH@DDCFGFAJQ\\SFMJMNAHGJCNCBEL@FMLMHEFCFANaR@DDB@FDB@LDJLJDFARDVEVCFN@RDJCJ@LDJFVCNPFLBBNBCy]REACCPGh[DAJ@lCLCTSJGHIBICQFKHGPGDEL@DAHDDHLBHBLKNAJF@DHDF@PHF@`FFEfCN@LBXLJADCFCZ@RGD@HDH@X@RAJDDAFMJAXHXPH@HGLBLCD@FDFENCL@HFFDLALIFAHFFJDBDCJCZCD`NNLHH@RDJHHRRBDPLTTCPBBBBFHFJAJENADCAC@ICYDGHGD@BDFFNF@EAEHEdKFID@J@HFBDAFXAFQFCNFLJHBJAHDDFP@LDFABBHBLAHAP@HIJFHNALJL@jNDBCBGRO@IFMBKPEBMKG@IAGEMMGAGDCCM@OEKFSFMHFDA@IFEJAHFLF@EFDBJDBHANG@CU@KI@KDOHADBHJNAJGFAFBFFADFFJ@FCAER@RMNK@EFGFA`DNKDBBPFFLAZKNCTHP@FCVS^MHIPMD_FGJAVBPAFFVdDBP@COFMVK\\I@CEEGAOIGKAEDUHUGc@UFaEIGKGEMEOOAESGAEQKIKCGAC@EAC@GFUEM@E@EDE@CSMOGCE@QKQ@CFI@ECSBIBENQHKHGAQDKDE@GACEAI@MBCAIEMQK[KOQaCEKEK@KEM@IFGHOAGE@CBG@ICI@GJKBEIMAEFIBsaiOKKMG_GIUMK@GASACBGDINGNGhINEBECGGCAMBEAGIGAKKEAGBKESYAGMWAGCCUQYCOGM@KDE@cEE@KLGCMSBGJGTKBACC@ENCJIAIBEACGAIISKAC@EAGKEAEBEBEBOFEV@FCJCB@AOVON@JBHBhZFHHDZDBABCAC@GLUFKEUEQFGBK@]DGBICOBANEJCDCAMHMAIGI@KFATDLGDMCWBEHAVBXCLIFGAGCEGAG@KEIKKEgKM@GJANCDKHOJC@uOEKOOWQC@IBKGGAG@IFIBIMEMBCFADEOiGOIGGAAFANABEDA@ICE@IDCCCO[@QHIAGBIHC@EAC@CBCHGBmBE@KJQBKHEFGBEDCDEBOCQKMOGEEAE@KDCJCDSAQBGBEDGJKBILeJAPBLAFA@YCA@EHE@EAIEEJANABIA[OBCCKMEKKICOASQKGICQCAA@CDO@KAGEG@KDKLUBOHKOCAA@EFCLCFC@EFIHWFIDCNAP@LCDCFOACSGGEEKCCK@CGUEwUWEIGACCIBARKL@JFJAHENAT@HDDA@GCOCEIK@IAIEAE@E@ICCCEK@KGJ]J]EICSESQICQUOEI@OCQ@MBMFENQJKWCKIIUEIGUGE@ECEQ@WCGGGgIeBMC_MGEGCEEEK@EHCEMCUOQEAKCIBQAICGEIQIMKEIAKBSR[\\GPBRFN@DEJCBCBM@CACMC@CNGHAH@XDHPDJNDJAFGLAHELEFIXGFaJIHGDWVIPEDO@KCI@[GMBKDGFKFG@GMECG@SFURIFDP@DKJGPEfIZEHSL_dKDSBIHAJ@^ATCH]JEFAFAJ@XDLDHbXJDZBJBHDNLI@GACFC@IFMB@DCBHDFJFBHADB@D@RGBCFCJ@JELBB@DB@HPGHCBCACFFJADDDAFDBKBGEE@MH@HEHWGC@CFKACBBF"],"encodeOffsets":[[121094,31112]]},"properties":{"cp":[118.757995,30.945667],"name":"宣城市","childNum":1}}],"UTF8Encoding":true});
}));