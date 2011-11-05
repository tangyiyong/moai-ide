using System;
using System.Collections.Generic;
using System.Text;

namespace ScintillaNet
{
	public class Constants
	{
		public const int INVALID_POSITION = -1;
		public const uint SCI_START = 2000;
		public const uint SCI_OPTIONAL_START = 3000;
		public const uint SCI_LEXER_START = 4000;
		public const uint SCI_ADDTEXT = 2001;
		public const uint SCI_ADDSTYLEDTEXT = 2002;
		public const uint SCI_INSERTTEXT = 2003;
		public const uint SCI_CLEARALL = 2004;
		public const uint SCI_CLEARDOCUMENTSTYLE = 2005;
		public const uint SCI_GETLENGTH = 2006;
		public const uint SCI_GETCHARAT = 2007;
		public const uint SCI_GETCURRENTPOS = 2008;
		public const uint SCI_GETANCHOR = 2009;
		public const uint SCI_GETSTYLEAT = 2010;
		public const uint SCI_REDO = 2011;
		public const uint SCI_SETUNDOCOLLECTION = 2012;
		public const uint SCI_SELECTALL = 2013;
		public const uint SCI_SETSAVEPOINT = 2014;
		public const uint SCI_GETSTYLEDTEXT = 2015;
		public const uint SCI_CANREDO = 2016;
		public const uint SCI_MARKERLINEFROMHANDLE = 2017;
		public const uint SCI_MARKERDELETEHANDLE = 2018;
		public const uint SCI_GETUNDOCOLLECTION = 2019;
		public const uint SCWS_INVISIBLE = 0;
		public const uint SCWS_VISIBLEALWAYS = 1;
		public const uint SCWS_VISIBLEAFTERINDENT = 2;
		public const uint SCI_GETVIEWWS = 2020;
		public const uint SCI_SETVIEWWS = 2021;
		public const uint SCI_POSITIONFROMPOINT = 2022;
		public const uint SCI_POSITIONFROMPOINTCLOSE = 2023;
		public const uint SCI_GOTOLINE = 2024;
		public const uint SCI_GOTOPOS = 2025;
		public const uint SCI_SETANCHOR = 2026;
		public const uint SCI_GETCURLINE = 2027;
		public const uint SCI_GETENDSTYLED = 2028;
		public const uint SC_EOL_CRLF = 0;
		public const uint SC_EOL_CR = 1;
		public const uint SC_EOL_LF = 2;
		public const uint SCI_CONVERTEOLS = 2029;
		public const uint SCI_GETEOLMODE = 2030;
		public const uint SCI_SETEOLMODE = 2031;
		public const uint SCI_STARTSTYLING = 2032;
		public const uint SCI_SETSTYLING = 2033;
		public const uint SCI_GETBUFFEREDDRAW = 2034;
		public const uint SCI_SETBUFFEREDDRAW = 2035;
		public const uint SCI_SETTABWIDTH = 2036;
		public const uint SCI_GETTABWIDTH = 2121;
		public const uint SC_CP_UTF8 = 65001;
		public const uint SC_CP_DBCS = 1;
		public const uint SCI_SETCODEPAGE = 2037;
		public const uint SCI_SETUSEPALETTE = 2039;
		public const uint MARKER_MAX = 31;
		public const uint SC_MARK_CIRCLE = 0;
		public const uint SC_MARK_ROUNDRECT = 1;
		public const uint SC_MARK_ARROW = 2;
		public const uint SC_MARK_SMALLRECT = 3;
		public const uint SC_MARK_SHORTARROW = 4;
		public const uint SC_MARK_EMPTY = 5;
		public const uint SC_MARK_ARROWDOWN = 6;
		public const uint SC_MARK_MINUS = 7;
		public const uint SC_MARK_PLUS = 8;
		public const uint SC_MARK_VLINE = 9;
		public const uint SC_MARK_LCORNER = 10;
		public const uint SC_MARK_TCORNER = 11;
		public const uint SC_MARK_BOXPLUS = 12;
		public const uint SC_MARK_BOXPLUSCONNECTED = 13;
		public const uint SC_MARK_BOXMINUS = 14;
		public const uint SC_MARK_BOXMINUSCONNECTED = 15;
		public const uint SC_MARK_LCORNERCURVE = 16;
		public const uint SC_MARK_TCORNERCURVE = 17;
		public const uint SC_MARK_CIRCLEPLUS = 18;
		public const uint SC_MARK_CIRCLEPLUSCONNECTED = 19;
		public const uint SC_MARK_CIRCLEMINUS = 20;
		public const uint SC_MARK_CIRCLEMINUSCONNECTED = 21;
		public const uint SC_MARK_BACKGROUND = 22;
		public const uint SC_MARK_DOTDOTDOT = 23;
		public const uint SC_MARK_ARROWS = 24;
		public const uint SC_MARK_PIXMAP = 25;
		public const uint SC_MARK_FULLRECT = 26;
        public const uint SC_MARK_RGBAIMAGE = 30;
		public const uint SC_MARK_CHARACTER = 10000;
		public const int SC_MARKNUM_FOLDEREND = 25;
		public const int SC_MARKNUM_FOLDEROPENMID = 26;
		public const int SC_MARKNUM_FOLDERMIDTAIL = 27;
		public const int SC_MARKNUM_FOLDERTAIL = 28;
		public const int SC_MARKNUM_FOLDERSUB = 29;
		public const int SC_MARKNUM_FOLDER = 30;
		public const int SC_MARKNUM_FOLDEROPEN = 31;
		public const int SC_MASK_FOLDERS = -33554432;
		public const uint SCI_MARKERDEFINE = 2040;
		public const uint SCI_MARKERSETFORE = 2041;
		public const uint SCI_MARKERSETBACK = 2042;
        public const uint SCI_MARKERSETALPHA = 2476;
		public const uint SCI_MARKERADD = 2043;
		public const uint SCI_MARKERDELETE = 2044;
		public const uint SCI_MARKERDELETEALL = 2045;
		public const uint SCI_MARKERGET = 2046;
		public const uint SCI_MARKERNEXT = 2047;
		public const uint SCI_MARKERPREVIOUS = 2048;
		public const uint SCI_MARKERDEFINEPIXMAP = 2049;
        public const uint SCI_MARKERDEFINERGBAIMAGE = 2626;
        public const uint SCI_RGBAIMAGESETWIDTH = 2624;
        public const uint SCI_RGBAIMAGESETHEIGHT = 2625;
		public const uint SCI_MARKERADDSET = 2466;
		public const uint SC_MARGIN_SYMBOL = 0;
		public const uint SC_MARGIN_NUMBER = 1;
		public const uint SCI_SETMARGINTYPEN = 2240;
		public const uint SCI_GETMARGINTYPEN = 2241;
		public const uint SCI_SETMARGINWIDTHN = 2242;
		public const uint SCI_GETMARGINWIDTHN = 2243;
		public const uint SCI_SETMARGINMASKN = 2244;
		public const uint SCI_GETMARGINMASKN = 2245;
		public const uint SCI_SETMARGINSENSITIVEN = 2246;
		public const uint SCI_GETMARGINSENSITIVEN = 2247;
		public const int STYLE_DEFAULT = 32;
		public const int STYLE_LINENUMBER = 33;
		public const int STYLE_BRACELIGHT = 34;
		public const int STYLE_BRACEBAD = 35;
		public const int STYLE_CONTROLCHAR = 36;
		public const int STYLE_INDENTGUIDE = 37;
		public const int STYLE_CALLTIP = 38;
		public const int STYLE_LASTPREDEFINED = 39;
		public const int STYLE_MAX = 127;
		public const int SC_CHARSET_ANSI = 0;
		public const int SC_CHARSET_DEFAULT = 1;
		public const int SC_CHARSET_BALTIC = 186;
		public const int SC_CHARSET_CHINESEBIG5 = 136;
		public const int SC_CHARSET_EASTEUROPE = 238;
		public const int SC_CHARSET_GB2312 = 134;
		public const int SC_CHARSET_GREEK = 161;
		public const int SC_CHARSET_HANGUL = 129;
		public const int SC_CHARSET_MAC = 77;
		public const int SC_CHARSET_OEM = 255;
		public const int SC_CHARSET_RUSSIAN = 204;
		public const int SC_CHARSET_CYRILLIC = 1251;
		public const int SC_CHARSET_SHIFTJIS = 128;
		public const int SC_CHARSET_SYMBOL = 2;
		public const int SC_CHARSET_TURKISH = 162;
		public const int SC_CHARSET_JOHAB = 130;
		public const int SC_CHARSET_HEBREW = 177;
		public const int SC_CHARSET_ARABIC = 178;
		public const int SC_CHARSET_VIETNAMESE = 163;
		public const int SC_CHARSET_THAI = 222;
		public const int SC_CHARSET_8859_15 = 1000;
		public const uint SCI_STYLECLEARALL = 2050;
		public const uint SCI_STYLESETFORE = 2051;
		public const uint SCI_STYLESETBACK = 2052;
		public const uint SCI_STYLESETBOLD = 2053;
		public const uint SCI_STYLESETITALIC = 2054;
		public const uint SCI_STYLESETSIZE = 2055;
		public const uint SCI_STYLESETFONT = 2056;
		public const uint SCI_STYLESETEOLFILLED = 2057;
		public const uint SCI_STYLERESETDEFAULT = 2058;
		public const uint SCI_STYLESETUNDERLINE = 2059;
		public const uint SC_CASE_MIXED = 0;
		public const uint SC_CASE_UPPER = 1;
		public const uint SC_CASE_LOWER = 2;
		public const uint SCI_STYLESETCASE = 2060;
		public const uint SCI_STYLESETCHARACTERSET = 2066;
		public const uint SCI_STYLESETHOTSPOT = 2409;
		public const uint SCI_SETSELFORE = 2067;
		public const uint SCI_SETSELBACK = 2068;
		public const uint SCI_SETCARETFORE = 2069;
		public const uint SCI_ASSIGNCMDKEY = 2070;
		public const uint SCI_CLEARCMDKEY = 2071;
		public const uint SCI_CLEARALLCMDKEYS = 2072;
		public const uint SCI_SETSTYLINGEX = 2073;
		public const uint SCI_STYLESETVISIBLE = 2074;
		public const uint SCI_GETCARETPERIOD = 2075;
		public const uint SCI_SETCARETPERIOD = 2076;
		public const uint SCI_SETWORDCHARS = 2077;
		public const uint SCI_BEGINUNDOACTION = 2078;
		public const uint SCI_ENDUNDOACTION = 2079;
		public const uint INDIC_MAX = 31;
		public const uint INDIC_PLAIN = 0;
		public const uint INDIC_SQUIGGLE = 1;
		public const uint INDIC_TT = 2;
		public const uint INDIC_DIAGONAL = 3;
		public const uint INDIC_STRIKE = 4;
		public const uint INDIC_HIDDEN = 5;
		public const uint INDIC_BOX = 6;
		public const uint INDIC_ROUNDBOX = 7;
		public const int INDIC0_MASK = 0x20;
		public const int INDIC1_MASK = 0x40;
		public const int INDIC2_MASK = 0x80;
		public const int INDICS_MASK = 0xE0;
		public const uint SCI_INDICSETSTYLE = 2080;
		public const uint SCI_INDICGETSTYLE = 2081;
		public const uint SCI_INDICSETFORE = 2082;
		public const uint SCI_INDICGETFORE = 2083;
		public const uint SCI_SETWHITESPACEFORE = 2084;
		public const uint SCI_SETWHITESPACEBACK = 2085;
		public const uint SCI_SETSTYLEBITS = 2090;
		public const uint SCI_GETSTYLEBITS = 2091;
		public const uint SCI_SETLINESTATE = 2092;
		public const uint SCI_GETLINESTATE = 2093;
		public const uint SCI_GETMAXLINESTATE = 2094;
		public const uint SCI_GETCARETLINEVISIBLE = 2095;
		public const uint SCI_SETCARETLINEVISIBLE = 2096;
		public const uint SCI_GETCARETLINEBACK = 2097;
		public const uint SCI_SETCARETLINEBACK = 2098;
		public const uint SCI_STYLESETCHANGEABLE = 2099;
		public const uint SCI_AUTOCSHOW = 2100;
		public const uint SCI_AUTOCCANCEL = 2101;
		public const uint SCI_AUTOCACTIVE = 2102;
		public const uint SCI_AUTOCPOSSTART = 2103;
		public const uint SCI_AUTOCCOMPLETE = 2104;
		public const uint SCI_AUTOCSTOPS = 2105;
		public const uint SCI_AUTOCSETSEPARATOR = 2106;
		public const uint SCI_AUTOCGETSEPARATOR = 2107;
		public const uint SCI_AUTOCSELECT = 2108;
		public const uint SCI_AUTOCSETCANCELATSTART = 2110;
		public const uint SCI_AUTOCGETCANCELATSTART = 2111;
		public const uint SCI_AUTOCSETFILLUPS = 2112;
		public const uint SCI_AUTOCSETCHOOSESINGLE = 2113;
		public const uint SCI_AUTOCGETCHOOSESINGLE = 2114;
		public const uint SCI_AUTOCSETIGNORECASE = 2115;
		public const uint SCI_AUTOCGETIGNORECASE = 2116;
		public const uint SCI_USERLISTSHOW = 2117;
		public const uint SCI_AUTOCSETAUTOHIDE = 2118;
		public const uint SCI_AUTOCGETAUTOHIDE = 2119;
		public const uint SCI_AUTOCSETDROPRESTOFWORD = 2270;
		public const uint SCI_AUTOCGETDROPRESTOFWORD = 2271;
		public const uint SCI_REGISTERIMAGE = 2405;
		public const uint SCI_CLEARREGISTEREDIMAGES = 2408;
		public const uint SCI_AUTOCGETTYPESEPARATOR = 2285;
		public const uint SCI_AUTOCSETTYPESEPARATOR = 2286;
		public const uint SCI_AUTOCSETMAXWIDTH = 2208;
		public const uint SCI_AUTOCGETMAXWIDTH = 2209;
		public const uint SCI_AUTOCSETMAXHEIGHT = 2210;
		public const uint SCI_AUTOCGETMAXHEIGHT = 2211;
		public const uint SCI_SETINDENT = 2122;
		public const uint SCI_GETINDENT = 2123;
		public const uint SCI_SETUSETABS = 2124;
		public const uint SCI_GETUSETABS = 2125;
		public const uint SCI_SETLINEINDENTATION = 2126;
		public const uint SCI_GETLINEINDENTATION = 2127;
		public const uint SCI_GETLINEINDENTPOSITION = 2128;
		public const uint SCI_GETCOLUMN = 2129;
		public const uint SCI_SETHSCROLLBAR = 2130;
		public const uint SCI_GETHSCROLLBAR = 2131;
		public const uint SCI_SETINDENTATIONGUIDES = 2132;
		public const uint SCI_GETINDENTATIONGUIDES = 2133;
		public const uint SCI_SETHIGHLIGHTGUIDE = 2134;
		public const uint SCI_GETHIGHLIGHTGUIDE = 2135;
		public const uint SCI_GETLINEENDPOSITION = 2136;
		public const uint SCI_GETCODEPAGE = 2137;
		public const uint SCI_GETCARETFORE = 2138;
		public const uint SCI_GETUSEPALETTE = 2139;
		public const uint SCI_GETREADONLY = 2140;
		public const uint SCI_SETCURRENTPOS = 2141;
		public const uint SCI_SETSELECTIONSTART = 2142;
		public const uint SCI_GETSELECTIONSTART = 2143;
		public const uint SCI_SETSELECTIONEND = 2144;
		public const uint SCI_GETSELECTIONEND = 2145;
		public const uint SCI_SETPRINTMAGNIFICATION = 2146;
		public const uint SCI_GETPRINTMAGNIFICATION = 2147;
		public const uint SC_PRINT_NORMAL = 0;
		public const uint SC_PRINT_INVERTLIGHT = 1;
		public const uint SC_PRINT_BLACKONWHITE = 2;
		public const uint SC_PRINT_COLOURONWHITE = 3;
		public const uint SC_PRINT_COLOURONWHITEDEFAULTBG = 4;
		public const uint SCI_SETPRINTCOLOURMODE = 2148;
		public const uint SCI_GETPRINTCOLOURMODE = 2149;
		public const uint SCFIND_WHOLEWORD = 2;
		public const uint SCFIND_MATCHCASE = 4;
		public const uint SCFIND_WORDSTART = 0x00100000;
		public const uint SCFIND_REGEXP = 0x00200000;
		public const uint SCFIND_POSIX = 0x00400000;
		public const uint SCI_FINDTEXT = 2150;
		public const uint SCI_FORMATRANGE = 2151;
		public const uint SCI_GETFIRSTVISIBLELINE = 2152;
		public const uint SCI_GETLINE = 2153;
		public const uint SCI_GETLINECOUNT = 2154;
		public const uint SCI_SETMARGINLEFT = 2155;
		public const uint SCI_GETMARGINLEFT = 2156;
		public const uint SCI_SETMARGINRIGHT = 2157;
		public const uint SCI_GETMARGINRIGHT = 2158;
		public const uint SCI_GETMODIFY = 2159;
		public const uint SCI_SETSEL = 2160;
		public const uint SCI_GETSELTEXT = 2161;
		public const uint SCI_GETTEXTRANGE = 2162;
		public const uint SCI_HIDESELECTION = 2163;
		public const uint SCI_POINTXFROMPOSITION = 2164;
		public const uint SCI_POINTYFROMPOSITION = 2165;
		public const uint SCI_LINEFROMPOSITION = 2166;
		public const uint SCI_POSITIONFROMLINE = 2167;
		public const uint SCI_LINESCROLL = 2168;
		public const uint SCI_SCROLLCARET = 2169;
		public const uint SCI_REPLACESEL = 2170;
		public const uint SCI_SETREADONLY = 2171;
		public const uint SCI_NULL = 2172;
		public const uint SCI_CANPASTE = 2173;
		public const uint SCI_CANUNDO = 2174;
		public const uint SCI_EMPTYUNDOBUFFER = 2175;
		public const uint SCI_UNDO = 2176;
		public const uint SCI_CUT = 2177;
		public const uint SCI_COPY = 2178;
		public const uint SCI_PASTE = 2179;
		public const uint SCI_CLEAR = 2180;
		public const uint SCI_SETTEXT = 2181;
		public const uint SCI_GETTEXT = 2182;
		public const uint SCI_GETTEXTLENGTH = 2183;
		public const uint SCI_GETDIRECTFUNCTION = 2184;
		public const uint SCI_GETDIRECTPOINTER = 2185;
		public const uint SCI_SETOVERTYPE = 2186;
		public const uint SCI_GETOVERTYPE = 2187;
		public const uint SCI_SETCARETWIDTH = 2188;
		public const uint SCI_GETCARETWIDTH = 2189;
		public const uint SCI_SETTARGETSTART = 2190;
		public const uint SCI_GETTARGETSTART = 2191;
		public const uint SCI_SETTARGETEND = 2192;
		public const uint SCI_GETTARGETEND = 2193;
		public const uint SCI_REPLACETARGET = 2194;
		public const uint SCI_REPLACETARGETRE = 2195;
		public const uint SCI_SEARCHINTARGET = 2197;
		public const uint SCI_SETSEARCHFLAGS = 2198;
		public const uint SCI_GETSEARCHFLAGS = 2199;
		public const uint SCI_CALLTIPSHOW = 2200;
		public const uint SCI_CALLTIPCANCEL = 2201;
		public const uint SCI_CALLTIPACTIVE = 2202;
		public const uint SCI_CALLTIPPOSSTART = 2203;
		public const uint SCI_CALLTIPSETHLT = 2204;
		public const uint SCI_CALLTIPSETBACK = 2205;
		public const uint SCI_CALLTIPSETFORE = 2206;
		public const uint SCI_CALLTIPSETFOREHLT = 2207;
		public const uint SCI_CALLTIPUSESTYLE = 2212;
		public const uint SCI_VISIBLEFROMDOCLINE = 2220;
		public const uint SCI_DOCLINEFROMVISIBLE = 2221;
		public const uint SCI_WRAPCOUNT = 2235;
		public const uint SC_FOLDLEVELBASE = 0x400;
		public const uint SC_FOLDLEVELWHITEFLAG = 0x1000;
		public const uint SC_FOLDLEVELHEADERFLAG = 0x2000;
		public const uint SC_FOLDLEVELBOXHEADERFLAG = 0x4000;
		public const uint SC_FOLDLEVELBOXFOOTERFLAG = 0x8000;
		public const uint SC_FOLDLEVELCONTRACTED = 0x10000;
		public const uint SC_FOLDLEVELUNINDENT = 0x20000;
		public const uint SC_FOLDLEVELNUMBERMASK = 0x0FFF;
		public const uint SCI_SETFOLDLEVEL = 2222;
		public const uint SCI_GETFOLDLEVEL = 2223;
		public const uint SCI_GETLASTCHILD = 2224;
		public const uint SCI_GETFOLDPARENT = 2225;
		public const uint SCI_SHOWLINES = 2226;
		public const uint SCI_HIDELINES = 2227;
		public const uint SCI_GETLINEVISIBLE = 2228;
		public const uint SCI_SETFOLDEXPANDED = 2229;
		public const uint SCI_GETFOLDEXPANDED = 2230;
		public const uint SCI_TOGGLEFOLD = 2231;
		public const uint SCI_ENSUREVISIBLE = 2232;
		public const uint SC_FOLDFLAG_LINEBEFORE_EXPANDED = 0x0002;
		public const uint SC_FOLDFLAG_LINEBEFORE_CONTRACTED = 0x0004;
		public const uint SC_FOLDFLAG_LINEAFTER_EXPANDED = 0x0008;
		public const uint SC_FOLDFLAG_LINEAFTER_CONTRACTED = 0x0010;
		public const uint SC_FOLDFLAG_LEVELNUMBERS = 0x0040;
		public const uint SC_FOLDFLAG_BOX = 0x0001;
		public const uint SCI_SETFOLDFLAGS = 2233;
		public const uint SCI_ENSUREVISIBLEENFORCEPOLICY = 2234;
		public const uint SCI_SETTABINDENTS = 2260;
		public const uint SCI_GETTABINDENTS = 2261;
		public const uint SCI_SETBACKSPACEUNINDENTS = 2262;
		public const uint SCI_GETBACKSPACEUNINDENTS = 2263;
		public const uint SC_TIME_FOREVER = 10000000;
		public const uint SCI_SETMOUSEDWELLTIME = 2264;
		public const uint SCI_GETMOUSEDWELLTIME = 2265;
		public const uint SCI_WORDSTARTPOSITION = 2266;
		public const uint SCI_WORDENDPOSITION = 2267;
		public const uint SC_WRAP_NONE = 0;
		public const uint SC_WRAP_WORD = 1;
		public const uint SC_WRAP_CHAR = 2;
		public const uint SCI_SETWRAPMODE = 2268;
		public const uint SCI_GETWRAPMODE = 2269;
		public const uint SC_WRAPVISUALFLAG_NONE = 0x0000;
		public const uint SC_WRAPVISUALFLAG_END = 0x0001;
		public const uint SC_WRAPVISUALFLAG_START = 0x0002;
		public const uint SCI_SETWRAPVISUALFLAGS = 2460;
		public const uint SCI_GETWRAPVISUALFLAGS = 2461;
		public const uint SC_WRAPVISUALFLAGLOC_DEFAULT = 0x0000;
		public const uint SC_WRAPVISUALFLAGLOC_END_BY_TEXT = 0x0001;
		public const uint SC_WRAPVISUALFLAGLOC_START_BY_TEXT = 0x0002;
		public const uint SCI_SETWRAPVISUALFLAGSLOCATION = 2462;
		public const uint SCI_GETWRAPVISUALFLAGSLOCATION = 2463;
		public const uint SCI_SETWRAPSTARTINDENT = 2464;
		public const uint SCI_GETWRAPSTARTINDENT = 2465;
		public const uint SC_CACHE_NONE = 0;
		public const uint SC_CACHE_CARET = 1;
		public const uint SC_CACHE_PAGE = 2;
		public const uint SC_CACHE_DOCUMENT = 3;
		public const uint SCI_SETLAYOUTCACHE = 2272;
		public const uint SCI_GETLAYOUTCACHE = 2273;
		public const uint SCI_SETSCROLLWIDTH = 2274;
		public const uint SCI_GETSCROLLWIDTH = 2275;
		public const uint SCI_TEXTWIDTH = 2276;
		public const uint SCI_SETENDATLASTLINE = 2277;
		public const uint SCI_GETENDATLASTLINE = 2278;
		public const uint SCI_TEXTHEIGHT = 2279;
		public const uint SCI_SETVSCROLLBAR = 2280;
		public const uint SCI_GETVSCROLLBAR = 2281;
		public const uint SCI_APPENDTEXT = 2282;
		public const uint SCI_GETTWOPHASEDRAW = 2283;
		public const uint SCI_SETTWOPHASEDRAW = 2284;
		public const uint SCI_TARGETFROMSELECTION = 2287;
		public const uint SCI_LINESJOIN = 2288;
		public const uint SCI_LINESSPLIT = 2289;
		public const uint SCI_SETFOLDMARGINCOLOUR = 2290;
		public const uint SCI_SETFOLDMARGINHICOLOUR = 2291;
		public const uint SCI_LINEDOWN = 2300;
		public const uint SCI_LINEDOWNEXTEND = 2301;
		public const uint SCI_LINEUP = 2302;
		public const uint SCI_LINEUPEXTEND = 2303;
		public const uint SCI_CHARLEFT = 2304;
		public const uint SCI_CHARLEFTEXTEND = 2305;
		public const uint SCI_CHARRIGHT = 2306;
		public const uint SCI_CHARRIGHTEXTEND = 2307;
		public const uint SCI_WORDLEFT = 2308;
		public const uint SCI_WORDLEFTEXTEND = 2309;
		public const uint SCI_WORDRIGHT = 2310;
		public const uint SCI_WORDRIGHTEXTEND = 2311;
		public const uint SCI_HOME = 2312;
		public const uint SCI_HOMEEXTEND = 2313;
		public const uint SCI_LINEEND = 2314;
		public const uint SCI_LINEENDEXTEND = 2315;
		public const uint SCI_DOCUMENTSTART = 2316;
		public const uint SCI_DOCUMENTSTARTEXTEND = 2317;
		public const uint SCI_DOCUMENTEND = 2318;
		public const uint SCI_DOCUMENTENDEXTEND = 2319;
		public const uint SCI_PAGEUP = 2320;
		public const uint SCI_PAGEUPEXTEND = 2321;
		public const uint SCI_PAGEDOWN = 2322;
		public const uint SCI_PAGEDOWNEXTEND = 2323;
		public const uint SCI_EDITTOGGLEOVERTYPE = 2324;
		public const uint SCI_CANCEL = 2325;
		public const uint SCI_DELETEBACK = 2326;
		public const uint SCI_TAB = 2327;
		public const uint SCI_BACKTAB = 2328;
		public const uint SCI_NEWLINE = 2329;
		public const uint SCI_FORMFEED = 2330;
		public const uint SCI_VCHOME = 2331;
		public const uint SCI_VCHOMEEXTEND = 2332;
		public const uint SCI_ZOOMIN = 2333;
		public const uint SCI_ZOOMOUT = 2334;
		public const uint SCI_DELWORDLEFT = 2335;
		public const uint SCI_DELWORDRIGHT = 2336;
		public const uint SCI_LINECUT = 2337;
		public const uint SCI_LINEDELETE = 2338;
		public const uint SCI_LINETRANSPOSE = 2339;
		public const uint SCI_LINEDUPLICATE = 2404;
		public const uint SCI_LOWERCASE = 2340;
		public const uint SCI_UPPERCASE = 2341;
		public const uint SCI_LINESCROLLDOWN = 2342;
		public const uint SCI_LINESCROLLUP = 2343;
		public const uint SCI_DELETEBACKNOTLINE = 2344;
		public const uint SCI_HOMEDISPLAY = 2345;
		public const uint SCI_HOMEDISPLAYEXTEND = 2346;
		public const uint SCI_LINEENDDISPLAY = 2347;
		public const uint SCI_LINEENDDISPLAYEXTEND = 2348;
		public const uint SCI_HOMEWRAP = 2349;
		public const uint SCI_HOMEWRAPEXTEND = 2450;
		public const uint SCI_LINEENDWRAP = 2451;
		public const uint SCI_LINEENDWRAPEXTEND = 2452;
		public const uint SCI_VCHOMEWRAP = 2453;
		public const uint SCI_VCHOMEWRAPEXTEND = 2454;
		public const uint SCI_LINECOPY = 2455;
		public const uint SCI_MOVECARETINSIDEVIEW = 2401;
		public const uint SCI_LINELENGTH = 2350;
		public const uint SCI_BRACEHIGHLIGHT = 2351;
		public const uint SCI_BRACEBADLIGHT = 2352;
		public const uint SCI_BRACEMATCH = 2353;
		public const uint SCI_GETVIEWEOL = 2355;
		public const uint SCI_SETVIEWEOL = 2356;
		public const uint SCI_GETDOCPOINTER = 2357;
		public const uint SCI_SETDOCPOINTER = 2358;
		public const uint SCI_SETMODEVENTMASK = 2359;
		public const uint EDGE_NONE = 0;
		public const uint EDGE_LINE = 1;
		public const uint EDGE_BACKGROUND = 2;
		public const uint SCI_GETEDGECOLUMN = 2360;
		public const uint SCI_SETEDGECOLUMN = 2361;
		public const uint SCI_GETEDGEMODE = 2362;
		public const uint SCI_SETEDGEMODE = 2363;
		public const uint SCI_GETEDGECOLOUR = 2364;
		public const uint SCI_SETEDGECOLOUR = 2365;
		public const uint SCI_SEARCHANCHOR = 2366;
		public const uint SCI_SEARCHNEXT = 2367;
		public const uint SCI_SEARCHPREV = 2368;
		public const uint SCI_LINESONSCREEN = 2370;
		public const uint SCI_USEPOPUP = 2371;
		public const uint SCI_SELECTIONISRECTANGLE = 2372;
		public const uint SCI_SETZOOM = 2373;
		public const uint SCI_GETZOOM = 2374;
		public const uint SCI_CREATEDOCUMENT = 2375;
		public const uint SCI_ADDREFDOCUMENT = 2376;
		public const uint SCI_RELEASEDOCUMENT = 2377;
		public const uint SCI_GETMODEVENTMASK = 2378;
		public const uint SCI_SETFOCUS = 2380;
		public const uint SCI_GETFOCUS = 2381;
		public const uint SCI_SETSTATUS = 2382;
		public const uint SCI_GETSTATUS = 2383;
		public const uint SCI_SETMOUSEDOWNCAPTURES = 2384;
		public const uint SCI_GETMOUSEDOWNCAPTURES = 2385;
		public const int SC_CURSORNORMAL = -1;
		public const int SC_CURSORWAIT = 4;
		public const uint SCI_SETCURSOR = 2386;
		public const uint SCI_GETCURSOR = 2387;
		public const uint SCI_SETCONTROLCHARSYMBOL = 2388;
		public const uint SCI_GETCONTROLCHARSYMBOL = 2389;
		public const uint SCI_WORDPARTLEFT = 2390;
		public const uint SCI_WORDPARTLEFTEXTEND = 2391;
		public const uint SCI_WORDPARTRIGHT = 2392;
		public const uint SCI_WORDPARTRIGHTEXTEND = 2393;
		public const uint VISIBLE_SLOP = 0x01;
		public const uint VISIBLE_STRICT = 0x04;
		public const uint SCI_SETVISIBLEPOLICY = 2394;
		public const uint SCI_DELLINELEFT = 2395;
		public const uint SCI_DELLINERIGHT = 2396;
		public const uint SCI_SETXOFFSET = 2397;
		public const uint SCI_GETXOFFSET = 2398;
		public const uint SCI_CHOOSECARETX = 2399;
		public const uint SCI_GRABFOCUS = 2400;
		public const uint CARET_SLOP = 0x01;
		public const uint CARET_STRICT = 0x04;
		public const uint CARET_JUMPS = 0x10;
		public const uint CARET_EVEN = 0x08;
		public const uint SCI_SETXCARETPOLICY = 2402;
		public const uint SCI_SETYCARETPOLICY = 2403;
		public const uint SCI_SETPRINTWRAPMODE = 2406;
		public const uint SCI_GETPRINTWRAPMODE = 2407;
		public const uint SCI_SETHOTSPOTACTIVEFORE = 2410;
		public const uint SCI_SETHOTSPOTACTIVEBACK = 2411;
		public const uint SCI_SETHOTSPOTACTIVEUNDERLINE = 2412;
		public const uint SCI_SETHOTSPOTSINGLELINE = 2421;
		public const uint SCI_PARADOWN = 2413;
		public const uint SCI_PARADOWNEXTEND = 2414;
		public const uint SCI_PARAUP = 2415;
		public const uint SCI_PARAUPEXTEND = 2416;
		public const uint SCI_POSITIONBEFORE = 2417;
		public const uint SCI_POSITIONAFTER = 2418;
		public const uint SCI_COPYRANGE = 2419;
		public const uint SCI_COPYTEXT = 2420;
		public const uint SC_SEL_STREAM = 0;
		public const uint SC_SEL_RECTANGLE = 1;
		public const uint SC_SEL_LINES = 2;
		public const uint SCI_SETSELECTIONMODE = 2422;
		public const uint SCI_GETSELECTIONMODE = 2423;
		public const uint SCI_GETLINESELSTARTPOSITION = 2424;
		public const uint SCI_GETLINESELENDPOSITION = 2425;
		public const uint SCI_LINEDOWNRECTEXTEND = 2426;
		public const uint SCI_LINEUPRECTEXTEND = 2427;
		public const uint SCI_CHARLEFTRECTEXTEND = 2428;
		public const uint SCI_CHARRIGHTRECTEXTEND = 2429;
		public const uint SCI_HOMERECTEXTEND = 2430;
		public const uint SCI_VCHOMERECTEXTEND = 2431;
		public const uint SCI_LINEENDRECTEXTEND = 2432;
		public const uint SCI_PAGEUPRECTEXTEND = 2433;
		public const uint SCI_PAGEDOWNRECTEXTEND = 2434;
		public const uint SCI_STUTTEREDPAGEUP = 2435;
		public const uint SCI_STUTTEREDPAGEUPEXTEND = 2436;
		public const uint SCI_STUTTEREDPAGEDOWN = 2437;
		public const uint SCI_STUTTEREDPAGEDOWNEXTEND = 2438;
		public const uint SCI_WORDLEFTEND = 2439;
		public const uint SCI_WORDLEFTENDEXTEND = 2440;
		public const uint SCI_WORDRIGHTEND = 2441;
		public const uint SCI_WORDRIGHTENDEXTEND = 2442;
		public const uint SCI_SETWHITESPACECHARS = 2443;
		public const uint SCI_SETCHARSDEFAULT = 2444;
		public const uint SCI_AUTOCGETCURRENT = 2445;
		public const uint SCI_ALLOCATE = 2446;
		public const uint SCI_TARGETASUTF8 = 2447;
		public const uint SCI_SETLENGTHFORENCODE = 2448;
		public const uint SCI_ENCODEDFROMUTF8 = 2449;
		public const uint SCI_FINDCOLUMN = 2456;
		public const uint SCI_GETCARETSTICKY = 2457;
		public const uint SCI_SETCARETSTICKY = 2458;
		public const uint SCI_TOGGLECARETSTICKY = 2459;
		public const uint SCI_SETPASTECONVERTENDINGS = 2467;
		public const uint SCI_GETPASTECONVERTENDINGS = 2468;
		public const uint SCI_SELECTIONDUPLICATE = 2469;
		public const uint SC_ALPHA_TRANSPARENT = 0;
		public const uint SC_ALPHA_OPAQUE = 255;
		public const uint SC_ALPHA_NOALPHA = 256;
		public const uint SCI_SETCARETLINEBACKALPHA = 2470;
		public const uint SCI_GETCARETLINEBACKALPHA = 2471;
		public const uint SCI_STARTRECORD = 3001;
		public const uint SCI_STOPRECORD = 3002;
		public const uint SCI_SETLEXER = 4001;
		public const uint SCI_GETLEXER = 4002;
		public const uint SCI_COLOURISE = 4003;
		public const uint SCI_SETPROPERTY = 4004;
		public const uint KEYWORDSET_MAX = 8;
		public const uint SCI_SETKEYWORDS = 4005;
		public const uint SCI_SETLEXERLANGUAGE = 4006;
		public const uint SCI_LOADLEXERLIBRARY = 4007;
		public const uint SCI_GETPROPERTY = 4008;
		public const uint SCI_GETPROPERTYEXPANDED = 4009;
		public const uint SCI_GETPROPERTYINT = 4010;
		public const uint SCI_GETSTYLEBITSNEEDED = 4011;
		public const uint SC_MOD_INSERTTEXT = 0x1;
		public const uint SC_MOD_DELETETEXT = 0x2;
		public const uint SC_MOD_CHANGESTYLE = 0x4;
		public const uint SC_MOD_CHANGEFOLD = 0x8;
		public const uint SC_PERFORMED_USER = 0x10;
		public const uint SC_PERFORMED_UNDO = 0x20;
		public const uint SC_PERFORMED_REDO = 0x40;
		public const uint SC_MULTISTEPUNDOREDO = 0x80;
		public const uint SC_LASTSTEPINUNDOREDO = 0x100;
		public const uint SC_MOD_CHANGEMARKER = 0x200;
		public const uint SC_MOD_BEFOREINSERT = 0x400;
		public const uint SC_MOD_BEFOREDELETE = 0x800;
		public const uint SC_MULTILINEUNDOREDO = 0x1000;
		public const int SC_MODEVENTMASKALL = 0x6FFF;
		public const uint SCEN_CHANGE = 768;
		public const uint SCEN_SETFOCUS = 512;
		public const uint SCEN_KILLFOCUS = 256;
		public const uint SCK_DOWN = 300;
		public const uint SCK_UP = 301;
		public const uint SCK_LEFT = 302;
		public const uint SCK_RIGHT = 303;
		public const uint SCK_HOME = 304;
		public const uint SCK_END = 305;
		public const uint SCK_PRIOR = 306;
		public const uint SCK_NEXT = 307;
		public const uint SCK_DELETE = 308;
		public const uint SCK_INSERT = 309;
		public const uint SCK_ESCAPE = 7;
		public const uint SCK_BACK = 8;
		public const uint SCK_TAB = 9;
		public const uint SCK_RETURN = 13;
		public const uint SCK_ADD = 310;
		public const uint SCK_SUBTRACT = 311;
		public const uint SCK_DIVIDE = 312;
		public const uint SCMOD_NORM = 0;
		public const uint SCMOD_SHIFT = 1;
		public const uint SCMOD_CTRL = 2;
		public const uint SCMOD_ALT = 4;
		public const uint SCN_STYLENEEDED = 2000;
		public const uint SCN_CHARADDED = 2001;
		public const uint SCN_SAVEPOINTREACHED = 2002;
		public const uint SCN_SAVEPOINTLEFT = 2003;
		public const uint SCN_MODIFYATTEMPTRO = 2004;
		public const uint SCN_KEY = 2005;
		public const uint SCN_DOUBLECLICK = 2006;
		public const uint SCN_UPDATEUI = 2007;
		public const uint SCN_MODIFIED = 2008;
		public const uint SCN_MACRORECORD = 2009;
		public const uint SCN_MARGINCLICK = 2010;
		public const uint SCN_NEEDSHOWN = 2011;
		public const uint SCN_PAINTED = 2013;
		public const uint SCN_USERLISTSELECTION = 2014;
		public const uint SCN_URIDROPPED = 2015;
		public const uint SCN_DWELLSTART = 2016;
		public const uint SCN_DWELLEND = 2017;
		public const uint SCN_ZOOM = 2018;
		public const uint SCN_HOTSPOTCLICK = 2019;
		public const uint SCN_HOTSPOTDOUBLECLICK = 2020;
		public const uint SCN_CALLTIPCLICK = 2021;
		public const uint SCN_AUTOCSELECTION = 2022;
		public const uint SCI_STYLEGETFORE = 2481;
		public const uint SCI_STYLEGETBACK = 2482;
		public const uint SCI_STYLEGETBOLD = 2483;
		public const uint SCI_STYLEGETITALIC = 2484;
		public const uint SCI_STYLEGETSIZE = 2485;
		public const uint SCI_STYLEGETFONT = 2486;
		public const uint SCI_STYLEGETEOLFILLED = 2487;
		public const uint SCI_STYLEGETUNDERLINE = 2488;
		public const uint SCI_STYLEGETCASE = 2489;
		public const uint SCI_STYLEGETCHARACTERSET = 2490;
		public const uint SCI_STYLEGETVISIBLE = 2491;
		public const uint SCI_STYLEGETCHANGEABLE = 2492;
		public const uint SCI_STYLEGETHOTSPOT = 2493;
		public const uint INDIC_CONTAINER = 8;
		public const uint SCI_INDICSETUNDER = 2510;
		public const uint SCI_INDICGETUNDER = 2511;
		public const uint SCI_GETHOTSPOTACTIVEFORE = 2494;
		public const uint SCI_GETHOTSPOTACTIVEBACK = 2495;
		public const uint SCI_GETHOTSPOTACTIVEUNDERLINE = 2496;
		public const uint SCI_GETHOTSPOTSINGLELINE = 2497;
		public const uint CARETSTYLE_INVISIBLE = 0;
		public const uint CARETSTYLE_LINE = 1;
		public const uint CARETSTYLE_BLOCK = 2;
		public const uint SCI_SETCARETSTYLE = 2512;
		public const uint SCI_GETCARETSTYLE = 2513;
		public const uint SCI_SETINDICATORCURRENT = 2500;
		public const uint SCI_GETINDICATORCURRENT = 2501;
		public const uint SCI_SETINDICATORVALUE = 2502;
		public const uint SCI_GETINDICATORVALUE = 2503;
		public const uint SCI_INDICATORFILLRANGE = 2504;
		public const uint SCI_INDICATORCLEARRANGE = 2505;
		public const uint SCI_INDICATORALLONFOR = 2506;
		public const uint SCI_INDICATORVALUEAT = 2507;
		public const uint SCI_INDICATORSTART = 2508;
		public const uint SCI_INDICATOREND = 2509;
		public const uint SCI_SETPOSITIONCACHE = 2514;
		public const uint SCI_GETPOSITIONCACHE = 2515;
		public const uint SC_MOD_CHANGEINDICATOR = 0x4000;
		public const uint SCN_INDICATORCLICK = 2023;
		public const uint SCN_INDICATORRELEASE = 2024;
	}
}
