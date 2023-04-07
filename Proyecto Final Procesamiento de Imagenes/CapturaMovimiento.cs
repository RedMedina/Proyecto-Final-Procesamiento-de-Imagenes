using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Vision.Motion;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Cuda;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

/*
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNocKdoXWWWk..''''',...,'',',dx:'''''''',..ol..,',,'''''''',','......'','','',''',''',,''''''','.:KWWWWXx;..''';lxO0Oxc,'''''''''',,'','..,okOkkkkkkkOKNWWWW
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNNNNWKcdWXOKWNx'.''''''''..','''':do,''''''','.,c..,'''''''',,''',..:lc:;,'....','''',,,',''''''''','.:kOdc;'.',;cokOkxoc;''','','',''','..';oxkkkkkkkk0KNWWWWWW
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNxlXWWWWXl..,''''''',...''''''cd:''''','','....,'''''''',,'',..o00000Okdlc;'..'',,'','''''''''','......',;lxkOxoc;,''',,'''''',','..':lxkkkkkkkkO0XNWWWWWWWW
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNW0ckWWWWK:.'''''''','',...,'''',::,'''',',',.  .,''''',''''','.cO00OOOOOO000kdc,...','''''',,'','....''',cxkdl:,,''',''''''''',,'..;lxkkkkkkkkO0KNWWWWWWWWWWW
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWKldNWWW0;.',''''''''',,'...,''''''''''',,''',. .''''''''''','.;k0OOOOOOO00OOO00Oxl;'..''','','''''',''';clc;,'',',,'''',,,,,'..',cdkOkkOkkkO0XNWWWWWWWWWWWWWW
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN0cdNWWW0,.','''''''''''','..'''''''''''''''''',...',','''''''.;k0OOOO00OOOOOOO000O00ko;..','',,''''''''';;,',,''''''''',,''..,:ldkkkkkkkkO0XNWWWWWWWWWWWWWWWWW
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNW0cdNWWWK;.',''''''''''''',,'..',,,,,,'''''''''''''''',''''',,.'d0OO000OOOOOOOOOOO000OO0Ox:,..',''',,,'','',,,,'',,''''','..,:okOkkkkkkkO0KNWWWWWWWWWWWWWWXKOkdo
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNkcxNWWWNo..,'''''''''''''',''''''''',,''''''''''''''''''',',,..o00O00OOOOOOOOOOOOO0OO0OOOO0Od:..',',,''',,'''',''''',,'..,:okOkkkkkkkO0KNNWWWWWWWWNKOxdoooolllox
NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWKol0WWWWWk'.,''''''''...'''''','','''',,,'''''''''',','''''','..:O0OOO00OOOOOOOOOOOO00OOOOO00O0Ox;..',''''','''''''','..,cdkOkkOkkkkkO0XWWWWWWX0kdoollclodxkOO0KKX
WWWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNkcoXWWWWWNc.',''''''..cc..''''','''''''''''''''''''''''''''','..;k0OOOOOOOOOOOOOOOOOOOOOOOOO0OO0O0Oxc'.','',',''''''..,:okOkkkkkkkkkO0XNNKOkdoollcldxkOOOOOO0KXNWWW
WWWWWWWWWNNNNNNNNNNNNNNNNNNNNNNNNWNkllONWWWWWWO'.,'''','.;x00d,.''''''''''''''''''''''''''''''''',.':x0O0OOOOOOOOOOOOOOOOOOOOOOO0OOO0OOO00x:..',''',,'..':okOkkkkkkkkOkxdddolllllodxkOOOkkOOOO0KXNWWWWWW
NWWWWWWWWWWWWWWNNNNNNNNNNNNNNNNWXxloONWWWWWWWNc.',''',..:k00O0k;.',''''''''''''''''''''''''''''','.lO000OOOOOOOOOOOOOOOOOOOOOOOOOO0000OO000Od,.','''.':okOkkkkkkOkxoc::::cloxkOOOkkkkkOOkOO0KNWWWWWWWWW0
WWWWWWWWWWWWWWWWNNNNNNNNNNWNNNKdlo0WWWWWWWWWWO'.,''','.;k0OO0O0Oc..''''''','''''''''''',,''',''''.,kK0OOOOOOOOOOOOOOOOOOOOOOOOOOO00OO0OO000O0Ol'... 'xOkkkkOOkdc::::codkOOkkkkkkkkkOkkO0KXNWWWWWWWWWWW0c
WWWWWWWWWWWWWWWNNWWWNNNNNNWXkolxKWWWWWWWWWWWWd..,'',,.'x0O00O0O0Od,.''''',,,''''''''''''''',,'',..l0OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO00O0OO0k;..,.:kOkkxl:::coxkOOkkkkkkkkkkkkkkOOKXNWWWWWWWWWWWWW0cd
WWWWWWWWWWWWWWWWWWWWNNNNKxoloONWWWWWWWWWWWWWN:.','',..o0OO00OOO0O0kc..''''',,'''''''''''''''',,'.;O0OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0OO00O0Oddd;.ckOo::lxOOkkkkkkkkkkkkkkkkOOKXNWWWWWWWWWWWWWWWXllN
WWWWWWWWWWWWWNNNWWWWNWWk,.;ldxkOKNWWWWWWWWWWO'.,'','.;O0O0OO00O0O0OOd,.','''',,,''''''''',,'',,.'x0O00OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0kxO0OOO00Ok:.ckkkkkkkkkkkkkkkkkkkkkkO0XNWWWWWWWWWWWWWWWWWNdlKW
WWWWWWWWWWWWWWWWWWWNWWWO:dKOkxdoodddxOKNWWWWd..,','.'d0OOO0OOOO0OO0O0kc..''''',,,,,''''','',','.cOOOOOO0OOOOOOOOOOOOOOOOOOOOOOOO0OOOOOO0Oo;lOOOOO00O0k'.oOkkkkkkkkkkkkkkkkkkOKNWWWWWWWWWWWNK000Oxdoc,dWW
WWWWWWWWWWWWWWWWWWWWWNWX:oWWWWWWWNKOxdoooodx, .,',..l0OOOOOOOOOOO00000Ox;.'''','',,,''''''''',.,x0OOO0OO0OOOOOOOOOOOOOOOOOOOOOOOO00OO0Oo, .d0O0OO00O00d.,xOkkkkkkkOOOOOOO0KXK0Okxddooooooolllc,.';',xXWW
WWWWWWWWWWWWWWWWWWWWWNWXcoWWWWWWWWWWWWWNX0kd' .,',.'k0OO0OOOOOOO0OO00OO0Oo,..',''''''''''''','.c00O000OO0OOOOOOOOOOOOOOOOOOOOOOOO000Od,    ;k0OO0OO00O0o'cOkkkkxolccc:::cllllccccclodxxkkkOOoclkXOlOWWWW
WWWWWWWWWWWWWWWWWWWWWNWXcdWWWWWWWWWWWWWWWWWNc .,,'.:O0OOOOOOOOOO0OOOOO0OO0Oo;..',''''',,'''',.'x0O0OOOO00OOOOOOOOOOOOOOOOOOOOOOOO00x:.      cO0OOOOOOOO0l'oOkdc:::ccccllooxkkOOOOkkOOO0KKX0lcOWMNodWWWWW
WWWWWWWWWWWWWWWWWWWWWWWXcdWWWWWWWWWWWWWWWWWWc .,,..o0O0OOOOOOOO0OO0OOO0OOO00Oxc'..''''''''','.:O0OOO0O0OOOOOOOOOOOOOOOOOOO00OOO00kc';:.     .d0OOOO0O000k;,dOkxkOOOkkOkkkkkkkkOO0KKXNNWWWOcdNMWW0lkWWWWW
WWWWWWWWWWWWWWWWWWWWWWWXcdWWWWWWWWWWWWWWWWWWl .,,.'x0OOOOOOOOOOOOOOOOOOOOOOOO00kl;...','''',.'x0OOOO00000OOOOOOOOOOOOOOO0OO0OO0kl',xNWk.     c0OOOOOOOOO0d.;kkkkkkOkkkkkkkO0KXXNWWWWWWWWkckWMMMMklKWWWWW
WWWWWWWWWWWWWWWWWWWWWWWKcxMWWWWWWWWWWWWWWWWNl .,'.:O00OOOOOOOOOOOOOOOOO0OO00O0OO0Oxc,..'''''.;O0OOO000000OOOOOOOOOOOOOOOOOOO0kl''oKMMMO'     :O0OOOOOOOO0O;,xOkkkkkkkkkO0XNNWWWWWWWWWWWkckWMMMMWddWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWklKMWWWWWWWWXKOxolc:;. .,..o0O000OOOOOOOOOOOOOOOOO0OO0OOOOOO0Oxl;..'..o0OOOOOOOOOOOOOOOOOOOOOOOOOO00kl'.lKWMMMWo      ;OOOOOOOOOOO0c,xOkkkkkkO0XNWWWWWWWWWWWWWW0:xWMMMMMXlxWWWWWW
WWWWWWWWWWWWWWWWWWWWWWXoxWWNX0kxdlc:,''........'..d0OO00OOOOOOOOOOOOOOO00OOOOOOOOOOO0O0Od:,.cO0OOOOOOOOO0OO000OOOOO00OOO0Od'.:0WMMMMWd.      cOOOOOOOOOOO0o.:xxkkkOKNWWWWWWWWWWWWWWWWXllNMMMMMMKlkWWWWWW
WWWWWWWWWWWWWWWWWWWWN0c,llc:;,,'',,;;;,'.......,..d0O000OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO00OkO0OOOOOOOOOOO0OO00OOO0OdoO0Ok:. :XMMMMMWx.      .oOkkkkkkOOOO0k,.:olllodddddxOKNWWWWWWWWWxc0MMMMMMM0ckWWWWWW
WWWWWWWWWWWWWWNXOxdl:,'',,;;:::;;;;;;,,'...... ...o0OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0O0OOOOOOOOO00O0O00kl::oOkl.   .;ldxKWNo.      ;kOkkkkkkkOOOO0c,0WNNNXKKK0kxdddddx0NWWW0cxWMMMMMWMOlOWWWWWW
WWWWWWWWWNKOxoc:,,,;:clodddxkkxdooc;,;,'...... ...o0O00OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0OOOOOOOOOOOOOOOO0O0OO0Ol:dOOo'         .lx:.      ,xkkkkkkkkkOOOOk,;KWWWWWWWWWWWWWNKOdoddxOl:0MMMMMMWMOcOWWWWWW
WWWXOxdolc;,,,;cloxxkOkkxxdoolc:::;;;,,'....... ..o0O0O0OOOO00OOOOOOO000OOOOOOOOOOOOOOOOOOO000OOOOOOOOOO0OO00O0OO0Oo'                    .:xkkkkxxxxxkkOOOo.cNWWWWWWWWWWWWWWWWWWNKkdldXMMMMMMMMKcxWWWWWW
xoc;,',,;;:::;:loolccc::;;;;;;;;;;;;;,,'.......  .l00O000OO0O00OO00OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO00x,             .....  .;dkkkkxxxxxxkkOOOO;.xWWWWWWWWWWWWWWWWWWWWMMMWMMMMMMMMMMNooWWWWWW
',;;;:;;;;;:::;;;;;:;:;::;:;;;;;;;;;;;,'........  c00OO000OO0000000000OOOOOO0000OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO00d;..        .........;okkkxxxxxxxxkkkOOOd.;XWWWWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMWxlXWWWWW
:;;;;;;;;;::::;::;;:::;:::;;;;;;;;;;,,,'........  ;O0O0Ooldk000OOOOOOOOOOOOO0000OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO000Oko.     .......,:lxkkkxddxxxxxkkkOOOOk;.kWWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMM0ckWWWWW
;;;;;;;;;;;::;;;:::::;;;;;;;;,,,'''''............ 'x0O0Od;.';coxkO00000000OO0OdooooooxO0OOO0O00OOOOOOOOOOOOOOOO000O0x.     ..',:ldkOkkxxxdxxxxkkkkkkOOOOc.oXKK00000KKKKKNWWMMMMMMMMMMMMMMMMMMMMMNooNWWWW
;;;:::::;;;;;;;,,,,,,''''........................  c00OO0Oxl.  ..',;:cclodxkkkdlcclccoO000O0000OOOOOOOOOOOOOOOOOOOO0Oo:::cldxOOOOOkkkxxxxxxxxkkkkOOOOOOo.cXKxxxxxxxkkxxxxkkkkxkkOKXWMMMMMMMMMMMMMkc0WWWW
''''''''',,,;;;;;;;;;;:::::::::::::;:;;;;;;:;;;;;;..d0O00O00c             ....'',;;;;::ok00000OOOOOOOOOOOOOOOOOOOO000000000OOOOOkkkkxxxxkkkkkkkOOOOOO0d.:KWWWWWWWWMMWMMMWWWNXK0OkxxxxxxxO0KXWWMMMXlxWWWW
cccllodxxkkOOOOOO0OOO000000000000OOOOOOOOOOOOOOOOOd,'d000000x'             .cooolc:,.  .;xO000OOOOOOOOOOOOOOOOOOOOO00O000OO0OOOOkkkkkkkkkkOOOOOOOOOOOd':KWWWWWWWWWWMMMMMMMMMMMMMMMMWXK0OkxxxxxxxkXx:OWWW
000000OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkkkOOkc,o0OO000l.            .cKWWMMMNKo. ,dO00OO00OO000OOOOOOOOOOO00OO00O0000OOOOOOOkkkOOOOOOOOOOOOOOo'lXWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMMMWNKOk0x,dWWW
OOOOOOOO0OO0OOO0OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkkkkkkOl,o0OOO0O:              .ckKNWMXl.  'x0OO00O0OOOOOO0OOOOOOO00OOOO0OO0OOOOOOOOOOOOOOOOOOOOOOO0Ol;xNWWWWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMMNKxdookXWWW
OOOOOOOO00OOOOOOOOOOOOOOO00OkxoolccccldOOOOOOkkkkkkkkkl'lOOOOOkc.     ......    .:OXo.  .oO0O0000O0000OO0OOOOOOOOOO000OOOOOOOOOOOOOOOOOOOOOOOOOO0x:c0WWWWWWWWWWWWWWWWWWWWMMMMMMMMMMMMMMMMMN0xddkKNWWWWWW
OOOOOO000000KKKKXXXXK0OxolccccccclllodkOOOOOkkkOOkkkkkkl'lOOOOOOd;. ..........    ... .:k000O0000OKXXKOO0OOOOOOOOO0OOOOOOOOOOOOOOOOOOOO0OOOOOO0Ol,oNWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMWWMMMNOxddkXWWWWWWWWWW
KKKXXXXNNWWNXK0OkddoollllodkO00OOOOOOOOOOOOOOkdclxkkkkkkc'lOOOOOOkd:'..........    .':dO0O0OO0OO00kkO00O0000OOOOOO0kco00OOOOOOOOOOOOOO000OO0OOx;,ok0NWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMXxodkXWWWWWWWWWWWWW
WWWWWWNKkdooooloodxkOO000OOOOOOOOOOOOOOOOkdl:::lxkkkkkkkd,.lOkkOkkkOkol:;;,,,',;:coxkO0OOOOOOOOO0Odoxk0O0OO00OOO00k:.l0OOOOOOOOOOOOOOOOOO0000o';0Xkdddx0NWWWWWWWWWWWWWWWWWWWWMMMMMMWOldXWWWWWWWWWWWWWWWW
KOxdoolllodkO0000OOOOOOOOOOOOOOOOOOOOkdl:;:coxOkkkkkkxl:;:',xOkkkkkkkkkOOkkkkkkOOOkOOOOOOOOOOOOO0O0000O000kddddxoc,..cO0OOOOOOOOOOOO0OOOOO0Ol'oXWWWWN0xddxONWWWWWWWWWWWWWWWWWMMMMMNxcOWWWWWWWWWWWWWWWWWW
c,';lxO000OOOOOOOOOOOOOOOOOOOOOOkxoc:::clxOOkkkkOkdl:::lxOl.ckkkkkkkkxxxxxxkxxkkxxkkOOOOOOOOOOOOOO00OO000d'..'.''',:.'x0OOOOOOOOOOOOOOOO00x::kNWWWWWWWWWNOxxx0WWWWWWWWWWWWWWMMMMMNdl0WWWWWWWWWWWWWWWWWWW
NKOxollok00OO0OOOOOOOOOOOO0Oxoc:c:cldxOOkkOkkOkdlcccoxOkkkx;'okkkkkxxxddxxxxxxkxkkkOOOOOOOO0000000Oxodxd:. .;clodooo:.c0OO0OOOOOO0OO0O0Ox:;dXWWWWWWWWWWWWWMNOxdkXWWWMMMMMMMMMMMMXooKWWWWWWWWWWWWWWWWWWWW
WWWWWNOdolldOOOOOOOOOOOkdlcc:cldkOOOkkOOkkOkdlccd0NNX0Okkkkx,,xkkkxxxxxxkxkkkkkkkkkOOOOOOOO0000O00Oo;;::;. .cdddxxdxo';O0OOOOOOO0OO00kolldKWWWWWWWWWWWWWWWWWMWXkdx0WWWMMMMWWMMMNooXWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWKkdlldO00OkdlcccloxkOOOOOOOkkOOxocclx0NWWWWWWXOkkkkl.;xkkkkkkkkkkkkkkkkkkOOOOOOOOOO0000000000000x:''lk0KOxdc'o00O00OOO00OxoodkKWWWWWWWWWWWWWWWWWWWWMMMMNOxdkNMMMMMMWMNdlKWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWXkocccc:'';coxOOOOOOOOkOkdlcloxKWWWWWWWWWWWXOkkkkl',dOkkkkkkkkkkkkkkOOOOOOOOOOOOOOOO00OO00O00OOko::cc:;,,cO000O000OdlodkKWWWWWWWWWWWWWWWWWWWWWWWWMMMMMWKxokNMMMMMWkc0WWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWKdd0KX0OxolccokOOOkdcclxKNWWWWWWWWWWWWWWWXOkkkkx:':dkOkkkkkkOOOOOOOOOOOOOO00000000000OOO00OO000kdlloxOOOO00kdllookXWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMWMWKxdxKWMMKcxWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWKxlcodlclxKWWWWWWWWWWWWWWWWWWWWN0Okkkkd:,;ldkOOOOOOOOOOOOOOOO0OOO000000000OOO0OO0OO0OO000000kdc:cld0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMWMWMMNOxKWWolXWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWWWW0l',OWWWWWWWWWWWWWWWWWWWWWWWWWX0xodkkkoc::::loxOO0000000000000000000000O00OOOOOkkxddoolc;;:okKWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMMMMMMWWM0ckWWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKloXWWWWWWWWWWWWWWWWWWWWWN0xooodO0OkkOkxoc:,,;;;;::c:::cccccllc:;,;::;::;;::ccc:::::coxKNWW0dOWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMMWMMMMMMWdoNWWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXdlKWWWWWWWWWWWWWWWWWKxooodOXWWWWNXXKK0OOOOkxolc::::::;;;;:ccc:.'lodxxkk0KKXNNWWWWWWWWWWWWWOldNWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMWX0OOxdddo;dWWWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNdl0WWWWWWWWWWWWWXkoldOXWWWWWWWWWWWWWWWNNXXKKK0000000KKKKKXXKo;kNWWWWWWWWWWWWWWWWWWWWWWWWWWKolKWWWWWWWWWWWWWWWWWWWWWMMMWWNK0OxdddddddxxOOkkkXWWWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWdlKWWWWWWWWWN0dodONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWxc0WWWWWWWWWWWWWWWWWWWWWWWWWWWWWNxcOWMWWWWWWWWWWWMMMMMWWXkolcc::,.l0XNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXolXWWWWWWNOookNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWOcOWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMWOlxNMMMMMMMMMMMMMMWXxl:;:looddd:;k00000000000000OOOOOOOOOOOO0000OOOOOOOOO
WWWWWWWWWWWWXXXNNNNNWNXNXXXXKXXKKKKKx;xWWWWWNx:xNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXloNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMO:kMMMMMMMMMMMMMWk;':oddooododo',dxdxxdxdxkkkkkkkxxxxxxxkkkOOOOOOOOOOOOO
*/

namespace Proyecto_Final_Procesamiento_de_Imagenes
{
    public partial class CapturaMovimiento : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private ComboBox cmbVideoDevices;
        // Create a list to store the rectangles for each frame
        private List<Rectangle> faceRectangles = new List<Rectangle>();
        private bool OpenCamera = true;

        public CapturaMovimiento()
        {
            InitializeComponent();
            cmbVideoDevices = new ComboBox();
            cmbVideoDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVideoDevices.Location = new System.Drawing.Point(12, 12);
            cmbVideoDevices.Name = "cmbVideoDevices";
            cmbVideoDevices.Size = new System.Drawing.Size(260, 21);
            cmbVideoDevices.TabIndex = 0;
            this.Controls.Add(cmbVideoDevices);
        }

        private void btnCameraActiva_Click(object sender, EventArgs e)
        {
            btnCloseCam.Visible = true;
            CantRostros.Visible = true;
            var capture = new VideoCapture(); // Abrir la cámara por defecto
            if (!capture.IsOpened)
            {
                MessageBox.Show("No se encontraron dispositivos de video.");
                return;
            }

            var faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");

            while (OpenCamera)
            {
                using (var frame = capture.QueryFrame().ToImage<Bgr, byte>())
                {
                    if (frame == null)
                        break;

                    var grayFrame = frame.Convert<Gray, byte>();
                    var faces = faceCascade.DetectMultiScale(grayFrame, 1.1, 3, Size.Empty);

                    foreach (var face in faces)
                    {
                        frame.Draw(face, new Bgr(Color.Red), 2);
                    }

                    //CvInvoke.Imshow("Cámara", frame);

                    CameraSalida.Image = frame.ToBitmap();

                    if (CvInvoke.WaitKey(1) >= 0) // Salir si se presiona una tecla
                        break;

                    int faceCount = faces.Length;
                    Console.WriteLine("Se han detectado " + faceCount + " rostros.");
                    CantRostros.Text = "Se han detectado " + faceCount + " rostros.";
                }
            }
            capture.Dispose();
            /*
            // Obtiene la lista de dispositivos de video disponibles
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se encontraron dispositivos de video.");
                return;
            }
            foreach (FilterInfo device in videoDevices)
            {
                cmbVideoDevices.Items.Add(device.Name);
            }
            cmbVideoDevices.SelectedIndex = 0;

            // Crea una nueva instancia de VideoCaptureDevice utilizando el dispositivo de video seleccionado
            videoSource = new VideoCaptureDevice(videoDevices[cmbVideoDevices.SelectedIndex].MonikerString);

            // Asigna un controlador de eventos para el evento NewFrame
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

            // Inicia la transmisión de video
            videoSource.Start();
             btnCloseCam.Visible = true;
            */
        }

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = new Bitmap((Bitmap)eventArgs.Frame.Clone());
            Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);

            // Add the rectangles to the list
            faceRectangles.AddRange(rectangles);

            // Keep only the rectangles from the last 10 frames
            if (faceRectangles.Count > 1)
            {
                faceRectangles.RemoveRange(0, faceRectangles.Count - 1);
            }

            // Calculate the average rectangle
            //Rectangle averageRectangle = GetAverageRectangle(faceRectangles);

            foreach (Rectangle face in faceRectangles)
            {
                using(Graphics graphics = Graphics.FromImage(bitmap)) 
                {
                    using (Pen pen = new Pen(Color.Red, 1)) 
                    {
                        graphics.DrawRectangle(pen,face);
                    }
                }
            }
            // Actualiza el PictureBox con el nuevo frame
            CameraSalida.Image = bitmap;
            // Contar el número de rostros detectados
            int faceCount = rectangles.Length;
            Console.WriteLine("Se han detectado " + faceCount + " rostros.");
        }

        private Rectangle GetAverageRectangle(List<Rectangle> rectangles)
        {
            int left = 0, top = 0, right = 0, bottom = 0;
            int count = rectangles.Count;

            for (int i = 0; i < count; i++)
            {
                left += rectangles[i].Left;
                top += rectangles[i].Top;
                right += rectangles[i].Right;
                bottom += rectangles[i].Bottom;
            }

            left /= count;
            top /= count;
            right /= count;
            bottom /= count;

            return new Rectangle(left, top, right - left, bottom - top);
        }

        private void btnCloseCam_Click(object sender, EventArgs e)
        {
            /*
            // Detiene la transmisión de video
            videoSource.SignalToStop();
            // Libera los recursos
            videoSource.WaitForStop();
            videoSource = null;
            */
            OpenCamera = false;
            CameraSalida.Image = null;
            btnCloseCam.Visible = false;
            CantRostros.Visible = false;
        }
    }
}
