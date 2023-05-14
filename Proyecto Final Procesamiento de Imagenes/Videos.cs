using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Controls;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;
using FFmpeg.AutoGen;
using Emgu.CV;
using System.Threading.Tasks;
using System.Media;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{

    /*
     ,,,,;;,'..........''',,''',,,'................................''',,;;;;;;,'............''''',;;;::;;;;;,''..'''...............',;;;;;;;;;,.............''.''''.......................';:::::::::;'''''''
,,,,;;;,...........''''''''','................................''',;;;;,,,,'............''''',;;;;;;;;;;''...'''...............',;;;;;;;;;,'..........'''''............... ...........';:::::::::;'......
,,,,,;,,'..........','',,,''........................'''''''...'',,,,,,,;;,'............'''.',;;;;;;;;;;'.......................',;;;;;;;;,'..........''''''...........  .............';::::::::;;'......
,,,,,,,,'.........'','',,,,... .....................'''''''...''',,;;,,,;,'............''..',;;;;;;;;;;'.......................',;;;;;;;,,'.........'''''''.........   .ll. .........';:::::::::;'......
,,;,,,,'..........'''',,,,'.;:.  ...................''''''''''''',,,,,,,;,.................',;;;;:;;;:;,...................'''',;;;;;;;;,'..........''''''''......    .lxx, .........';:::::::::;'......
,;;,,,,'...........',,,,,'.'ldc'   .................''''''''''''',,;,,,,,,'................',;;::;;;;;;,................''''''',;;;;;;;;;,.........'',,,,,''....     .cxOOl. ........',::::::::;;'......
;,,,,,,'...........''',,'..:xxdc'    ...............''''''''.''''',,,,,,,,'................',;;;::;;;;;,'..............'''''''',;;;;;;;;;,'.......'',,,,,,''..   .  .:dk0Kx. ........',;:::::::;;'......
,,,,,,,'...........''',,'.'dOkxdc'     ...................''.''''',,,,,,,,'................',;;;;:;;;;;,'..............'''''''',,;;;;;;;;,'.......''',,,,,'.   ... .;dkOKXO; ........',;::::::::;'......
'',,'''...........'',,,,..:O0Okdoc.     ......................''''','',,,'.................',;;;;;;;;;;,'..............''''''''',,;;;;;;;,'........'',,,'..  ....  ,oxOKXXKc ........',;:::::::;,'......
'''''''............'',,,..l000Okdoc.      ....................''''''''''''.................',;;;;;;;;;;,'.............'''''''''',;;;;;;;;,'......'''','..  .....  'lxOKXXXXo..........,;:::::::;,'......
'''................'',,'..xKK00Okdo:.  ..   .................'''''''''''''.................',;;;;;;;;;;,'..............''''''''',,;,;;;;;,'......',''..  ......  .cxk0KXXXXx. ........';;;::::;;,'......
'..................''',. ,OXKK00Okdo:.  ..    ................''........'.........     ....',;;;;;;;;;;,'.............'''''''''''',,;;,,,'.......''..  .......  .;dkOKXXXXXk. ........',;;;;;;;;,'......
....................'''. ;0XXKK00Oxdo;.  ...   .....'.'''......................  .,:,  .....';;;:;;;;;;,'..............''''''''''''',,''''.........  .........  'oxO0KXXXXNO' ........',;;;::;;;,'......
.....................'.. ;0NXKK00Okxol,   ....   .....'''''...........'.''...  .;looc. ;dl;...',;;;;;;;,'..............'''''''''''..'''''........   ........   .cxkO0KXXXXN0, ........',;;;;;;:;,'......
........................ ;0NXXKK00Okxoc'   .....   ...'''''...........'''..  .:looool. ,k0Oxl,...',;;;;,''.............''''''''........''......   ..........   ,oxO0KKXXXXN0; ........',;;;;;;;;,'......
..........'.........''.. ;0NNXXKK00Okdoc.   ......   ..''''...........''.. .;oddooool' 'x0000Oxl,....',,''.............'''''...........''....   ..........    .cxkO0KXXXXXN0; .........',;;;;;;;,'......
........'''''''.....''.. ,0NNXXXKK00Oxdo;.   .......   ..''...........'.  'ldxddooool' 'x0000000Oxl;'..................'''.................   ............    ,oxk0KKXXXNNN0; .........',,;,,,;;,'......
......''',,,,,''.....'.. 'kNNNNXXKK00kxdl,    .......    .'............  ,oxxddoooool' ,k0000000000OOxl;...............''''..............  ..............    .cdkO0KXXNNNNNO, .........',;,,,,;;,'......
.....',,,;;;;;,'.....'.. .dXNNNXXXK00Okxdc.   .........    ...........  ,oxddddoooooc. :O00000000000000Oko:'..........''''.............  .....'........      ,oxkO0KXXNNNNNk' ..........',,;;;;;,'......
.....';;;;;;;;,'.....''. .lXNNNNXXKK00Okdo:.   ......'...    ........  'oxddddoooooo:..dKK00000000000000000Oxl,........'''''.........  ....''....    ..     .cdxO00KXXXNNNNx............'',,,,,,,.......
....',;;;;;;;;;,....'''.. ;0XNNNXXXK00Okxdl'    .......'...    ...... .:xxddddoooooo;.l0XKK0000000000000000000Okdlc:;;,'...........    .........    ..      ,oxkO00KXXNNNNXo.............''''''''.......
....',;;;;;;;;;,'..''''.. .xXXNNNXXKK00Okdo:.    ............    ...  'oxddddooooool,,xXXXXKK000000000000000000000000Okkdolc::;,,,,,,,;;::ccll:.   ..      .cdxkO0KKXXNNNNK:...............''''.........
....',;;;;;;;;;,'..'''''.  c0XXXNNXXK00Okxdl,    ...............      ;dxddddoooooo:.,OXXXXXXK0000000000000000000000000000KKKK0000000000OOOxc'.  ...       ,ldxkO0KXXNNNNNO,............................
....',;;;;;;;;;,'....'''.. .xXXXXNXXKK0OOkxd:.     ........'''...     ;dxddddoooool,.cKXXXXXXXK0000000000000000000000000000000000OOOkxdol;'.  .....       .:odkkO0KXXNNNNXd.............................
....',;;;;;;;;;,'....'''..  :0XXXXXXXK00Okxdl'     ................   .;oddddooooo:..xXXXXXXXXKKKK0000000000000000000000000000000OOOd:'.    .......       ,ldxkO00KXXNNNNK:.............................
....',;;;;;;;;;,'..''''''.. .dKXXXXXXK00Okkxd:.       ...............   .;looollcc'.l0KKKKKKKKKXXKK000K000000000000000000000000000000ko:'.               .:odxkO00KXNNNNNk..............................
....',;;;;;;;;;,'..........  ,kXXXXXXKK0Okkxdl.         ................  .',''''..:OKK00000KKKKXXKKKKXXKXXK000000000000000000000000KKKK0ko;..           'lodxkO0KXXNNNNKc...'.......'''''''............
....',;;;;;;;;;,'...........  :0XXXXXXK0OOkxdo,            ............  .':ooll:'cOKK000OO0000KKKKKKKKXXXXXXKK0000000000000000000000000KKKK0kl;.       .:oodxkO0KXXNNNNk'..'......''''''''''...........
....',;;;;;;;;;;'............ .l0XXXXKK0OOkxxd:.                 ......;okKNN0d:'cOK00OOkkO00000000000KXXXXXXXK0000KKK000KKK0000000000000KKKKXXKOd:.    .coodxkO0KXXNNNK:...'.....''''''',,,'...........
...'',;;;;;;;;;,'............  .oKKKKKK00Okxxdl.                  .':dOXNNNNXx;.:k00OkxoloO000000OxkOO0KKXXXXXK000KXXXKKXXXKKKKKKKKKK000000KKKXXXXXOd;.  .;ldxkOKXXNNNXd......'..''',,,,,,,,'...........
..''',;;;;;;;;;,'.............  .d0KKKK00Okkxdo,               .,lxKNNNNNNNXk,.:kOOkdc,':dO00000Oxclxk0000KXXXX000KXXXXXXXXXKKKKKXXXXKKKKKKKXXXXXXXXXKkc'  .;dkOKXXXNNk,....'....'',,,,,,,,'''..........
...'',;;;;;;;;;,...............  .d0K0000Okkxxd:.           .'lkKNNNNNNNNNKo'.lkkdc,....cdk0000Oxc.'cokO000KKXK000KXXXXXXXXXKKKKKXXXXXXXXXXXXXXXXXXXXXXX0o,. .ckKXXXNO;...'.......',,,,,,,,,,'..........
...'',;;;;;;;;;,................  .o0000OOkkxxdl.         .:xKNNNNNNNNNNXk;.,loc,...;c,.:dkO000ko' ..;okO0000000000KXXXXXXXXXKK00KXXXXXXXXXXXXXXXXXXXXXXXX0d,. ,xKXXKc..''........'',,,,,,,,,'..........
...'',;;;;;;;;;,'................  .lO00OOOkxxdo'       .cOXNNNNNNNNNNXOc. .'...';codd:.;oxO000x:.',..;oxO0000OO0000K0KKKXXXXK0000KKXXXXXXXXXXXXXXXXXXXXXXXX0o' .l0Kl..''..........'',;;,,,,,'..........
....',;;;;;;;;;,..............'''.. .ckOOOkkkxdd;     .cOXNNNNNNNNNNNNKdc:::cloxkOxdxxl''ldkO0Od,.:lc,.,lxkO00xox00000000KKKXX0OO0000KXXXKKKKXXXKXXXKKXXXXXXXXO:. ,:..'''.........''',,;;;,,,''.........
....'',;;;;;;;;,..............''''.. .;xOOkkkxddc.  .:OXNNNNNNNNNNNNNNNNNNNNXXNNNNKkxkx:.:oxkOko''oxdl'..:dxO0klcx0000000000KK0dok0000000000000000K000KKKKKXXXXKo.  .','''........'',,,;;;,,,''.........
.....',,;;;;;;,'............''''''''.  'okkkxxxdl' 'dKNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKkkkd,.:oxkko''dxxxo,..,lxkkd::xO00000000000x::xkO0000000000000000000000KXXXXKd.  .'''..........',,,;;,,,,'..........
.....'',,,,,,,,'............'',,,'''..  .:xkxxdoc,:ONNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNK0kkd,.:odxo''dkxxxdc...:oddl,;dO0000000000Ol';oxkOOkxdoodxkO000000000000KXXXXx'  .''..........',,;,,,,;,''.'.......
......'''''''''.............'',,''.. .,;..,lddo:,lKNNNNX0kxdookKNNNNNNNNNNNNNNNNNNNNNXKOkd;.,ldo,.lkxxkxxdc..':loc''lxOO00000000k:.,c:,,',;:::cccldxO0000000000KXXXx. ..'...........',,;,,,,,''.....'''.
.......''''''...............''''.  .;oxxo:'':l:.cKNNNKOxdoodoc,,cx0XNNNNNNNNNNNNNNNNNNNX0Oxc..;l:.;xkkkkkxxo;...;cc'.;oxOO0000Okd;.  .';lodkOOOOOkxxO00000000000KXXKo. .'...........'',,,,,,''''''''''''
.............................'.. .:dkkkxxdoc;,..xNNNX00KNNNNNNKxc'':d0XNNNNNNNNNNNNNNNNNNX0Od;..,..lxkkkkkxxxo:...',...:dxkxoc,..... .':lodddxxkOO000000000000000KXX0c. ............',,,'',,,,'''',,,,,,
.............................. .;dkOOkkxxdddo;.:KNNNNNNNNNNNNNNNN0d;..:okKXNNNNNNNNNNNNNNNNXKOo,.. .:okkkkxxxxxdl;...  .','.   .;oko.  ...,:looddxxkOO000000000000KKKx, ............',,,,,,,,,,,,,,,;;,,
.....'......................  .oO0OOOkkkxxddl'.dNNNNNNNNNNNXK0kkkO0Kkc....;ldkkOO000OOKNNNNNNXKOd:...,dkkkxxxdoolc;.        .,cxO00Oo. .'....',:looddxxkOO00000000KK0Ol. ............,,,,,,,,,,,;;;;;;,,
........................... .:kK0000OOkkkxddc.'ONNNNNNNNNKkdollloooodkko:..    ......,kNNNNNNNNNX0kolldxxxxxo,...      ......;codxkOOd,..;:;'.....,:cooddxxOO000000000x' ............',,',,,,,,,;;;;;;,,
.......................... .oKXK00KK0OOOkkxd:.;0NNNNNNXOdllodxxxxxxdlccclolc:;,''..':kXNNNNNNNNNNNNKK0kxxxxxd:.   ..',;cll:'....;codxkd;. .;:c:;'.....,:loodxkO0000000k;  ...........','''',,,,;;;;;;;;,
......................... .dKXXKKKKK00OOkkxd,.cKNNNNXOo:codxxxxxxxxxxddl:;;:clodddxx0NNNNNNNNNNNNNNNNNXKOkxxdol::ccllllc:;;;;,.....,:ldo:. ..,:cllc;,.. ..;clodxO00000O:..............'''''''',;;,,,;;;;
........................ .oKXXXXXXKK00000Okd'.cXNNX0d:;ldxxxxxxxxxxxxxxxxoc;,',,:cllkXNNNNNNNNNNNNNNNNNNNXOxdooolllc:;,,,;;;;;;,,......,::'. .,;:lllll:.  ...;codxkO00O:.;o,...........'''...'',,;;;;;;;
.........................c0XXXXXXXXKKKKKK0ko'.oXNKko;;lddxxxxxxxxxxxxxkkkxdc:;;;,:lokXNNNNNNNNNNNNNNNNNNNNNKOdlllllc:,,;;;::::::;;;,'.......  .',;cllll:. ',...,codxO0O:.:Okl'................,,;;;;;;;;
........................;OXXXXXXXXKKKKKK0Okl..dX0dl;;codxxxxxxxxxxxxxkOOOkxdc:;;,,:lkXNNNNNNNNNNNNNNNNNNNNNNNKxolllc,,;;;::ccllllccc:::;,,'.....',;cllll;..;lc,..,coxOk;.:O00kc'..............',;;;;;;;;
....'..................'xXXXXXXXKKK0KK000Okl.,k0dl:,:oddxxxxxxxxxxxxxxO000Okdc:;;,;lxXNNNNNNNNNNNNNNNNNNNNNNNNKxlll;,,;;:::ccllloooddxxddoolc:;,,;,;clllc' .cool;..;oxx,.cO0000kl,.............,;;;;;;;;
'.'''.................'oKXXXK0K0000000000Okc.;kdlc;;lddxxxxxxxxxxxxxxkO0KKK0kdc:;,;cxKNNNNNNNNNNNNNNNNNNNNNNNNNOolc,,;;;:::ccllooodxkOOOOOOOxdc:;;;,;clll:. ,lollc'.,ol..o0000000Od:'.  .........,,;;;;;
'...................';lOXKK00000000000000Od' ,oolc;:odxxxxxxxxxxxxxxkO000KK00koc;,,:xKNNNNNNNNNNNNNNNNNNNNNNNNN0dl;,,;;;::ccclooddxkOO000000Oxo:;;;,;clllc' .''.:ll,.',.,k0000000000kd:'...     .,,;;;;;
''.......'.........':okKKK0000000000OkkOOd, .lollc:codddddxxxxxxxxkkkOO000000Oxl:;,;oKNNNNNNNNNNNNNNNNNNNNNNNNNKdc;';;;;::cclllodxxkkOOOOkkkxoc;,'...''...    .;lool,. .lO0000000000000Okxo:.  .',;;;;;;
''''''''....''''...,cxOKK00000000000Od;;;. .;l:;,'.........'',,;:clodkOO000OOOkdc;,,l0NNNNNNNNNNNNNNNNNNNNNNNNNKdc,,;;;;::ccclloooolc:;,,'....                'looool' ,x00000000kkkOkkxo:'.  ..',;;;;;;
'''''''''''''.'''..:dkK00000000000000Oo.                            ...';:loxxxdl:;;l0NNNNNNNNNNNNNNNNNNNNNNNNNKd:',;;;;;;;;;,''...                        .. .:oooooc;oO00000000x:'....    ....',;;,,;;
'''''''''''''''...'ok0K00000000000000kc.                                    ..',;;;;cONNNNNNNNNNNNNNNNNNNNNNNNNKx:,,,''...      ..',,,.  ......         ...... .;looodxkO0000000KKk:.  .........',,;,,;;
''''''','''''... .lO0K0000000000000Oo,..','..         .......... .lolcc;.         ..:kXNNNNNNNNNNNNNNNNNNNNNNNNKxc,..  ...     .lO000o............     ........ .'coodxkkO00000KKKK0o.  ........'',,;,,,
'''''',,,''''...'oO00000000000000ko;..',;;;,,:;..    ............'xKKKK0d.     ...  .lKNNNNNNNNNNNNNNNNNNNNNNNNXx;.  ,okOk,    'xXXXKxc:;''''....     .....'''''...'codxkkOO0000KXXXKx,  ........',,,,,,
'''''''',,'....ck000OkkkkO000Oko:'..',;;;;;,'cxo;.    ..'',,,,,,'.:ONNNXXx,   ;k0kl. 'xXNNNNNNNNNNNNNNNNNNNNNNNXx,  .dXXXXx.  .xNWW0xxxdc;;;;;,.    ....,,;;;;;;;,...':oxkkO0000KKXXXKk;  .......''''',,
''''''''....'cxOOkxddoodk00x:'....,;;;;;;;;,..;'.       .,;;;;::;,':ONWMMWKo,c0NWWNo.,ONNNNNNNNNNNNNNNNNNNNNNNNNk,...cKWWMW0l:OWWKd,.,;:;;;;;,.         ..',;;;;;;;,....;lxkOO00KKXXXXXO;  .......''''''
''''.....,:oxkxxdolc::ok000d. ..,;;;;;;;;;,..   .',.     ..,,;;;;;,',ckKNWWWNNMMWWNd..xNNNNNNNNNNNNNNNNNNNNNNNNN0;.,,':kXXXK0OOkl'...........    .........',;;;;;;;;;;,....;lxO00KKKXXXKk'  .......'''''
'''... ..',;,;,,''..,ok0000Ol. ..,,;;;;;;;,'''.'lxo;.       ...........',;:clldxkxl,..cXNNNNNNNNNNNNNNNNNNNNNNNNXd'.....'''''''...............   ....,;;;;;;;;;;;;;;;;;;;'.. .':x00KK0KKKo. ........'''.
'''',,'.........  'lk0000000kc. ...',;;;;;;;;;;'....,;:cllloodddxxkkkkkxxddoolccc:;;;,lKNNNNNNNNNNNNNNNNNNNNNNNNNXkdoodddxxxkOO000KKKKKKKKKK0kd:'.....',;;;;;;;;;;;;,,,''...   ,x0000000Kk,  ...........
'''',,,,,,,,'...'lk00000000Okdc'  ...',,;;;;;;;,'',:oOXNNNNNNNNNNNNNNNNNNNNNNNNNNXXKKKXNNNNNNXXK0OkkxxxdddddxkkOO0XNNNNNNNNNNNNNNNNNNNNNNNNKkl:;;;;;;;;;;;;;,,''''......     .;x000000000O:  ...........
''',,,',,,,'...;k0000000000kxool;. .....',;;;;;;;;;;,:o0XNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKOxoc;,...................':kXNNNNNNNNNNNNNNNNNNNNNXkl:;,',,,,;;;;;;;,,'......     .,oO0000000000Ol. ...........
''',,,,,,,'...lOKKK0000000Oxdooooc'. .....',;;;;;:clodkKNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXx,.    .............'''''..  :KNNNNNNNNNNNNNNNNNNNNNNNNX0kxoll:,',;;;;;;,,,'...   .,lk0000000OkO00Oc. ...........
'''',,,,,,'.'o0KKKKKK0000Oxdooooool:'. ......',,;o0XNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXd.     ..................  .:ONNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKxc,,,,,,''....    .':lxO00000000x:oO0O; ............
'..'',,,,'..o0KXXXKK0000Oxdooooooolc:'.   ......',o0NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXk,                ....  .;xXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKx:,'''......     .,:loodk000000000x',x0d' ............
...'','','.cOXXXXKK0000kxoooooc;,...     .....'''',:xKNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKd,.         ....   .,oOXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN0c,,;,'',,,'....   .;clooxO00000000Kd..lk:..............
....''''..,xKXXKK0000Oxlloool,.  ...'',,,;;;;;;;;;;;;cd0XNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKxc,..      ....,ckXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXOxdl:,,,;;;;;;;,,'.. .':ok000000000Kx' ;c..''...........
....'''...cOKKK00000Od;,cooooc,....',,;;;;;;;;;;;,,;clokXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNX0koc:;,,,;clxOKNNNNNNNNNNNNNNN0o:;:dXNNNNNNNNNNNNNKx:,,;;;;;;;,,,,,,''.   ,d000000000KO, ...,,'...........
.....'....ck000000Okd:..codddddo:'.....',,;;;;;;;,';o0XNNNNNNNNNNNNNNNNNNNNNKkxxOKNNNNNNNNNNNNNNXK0OkkkO0KXNNNNNNNNNNNNNNNXOc';lokXNNNNNNNNNNNXk:'',;,,'''....... ....'';oO0000000KK0:  .,;,''''''......
..........;dkO000Okd:. .cdkkkxxxxdoc,..  ..'',,;;;;,':dKNNNNNNNNNNNNNNNNNNNKl....:OXNNNNNNNNNNNXXKOkkkkkOO0KXXNNNNNNNNNKkl;';dKNNNNNNNNNNNNNN0l'.''''.......   ..';clloooxO000000KKX0c  .,,,'''.........
...........;oxkOOkd:.  .:x000Okkkkxxxdl;.   ...'',,;,,';dKNNNNNNNNNNNNNNNNNX0O00xllloodxkkxxdolccccccllllc::::cloodxxo:'.,lkXNNNNNNNNNNNNNNKd,..........   ..,:loooooooooxO00000KKXX0:  ';,,,'..........
.......... .;odxxdl' .. ;k0KKK0OOkkkkxd:.     ......''''.;d0NNNNNNNNNNNNNNNNNNNNNNX0xc..'..:odxO0KXNNNNNNXX0Okxo:..,'.,dOKNNNNNNNNNNNNNNXKx;.......    .',:loooddddddddolok000KKXXXXO; .,:;;,'..........
..........  .;oooo:. .. .oOKKK00OOOOOkxoc;,..   ...........,lkKNNNNNNNNNNNNNNNNNNNNNNXkoccxXNNNNNNNNNNNNNNNNNNNNX0dlld0NNNNNNNNNNNNNXKOdc,.....    .';:loooodddxxxxxxkxo,;x00KKKXXXKx' .,:;,'...'.......
...........  .;ooo;. ... 'dkO000OOOOOOOOOkkxo:,'..  ..........,:ldxOXNNNNNNNNNNNNNNNNNNNXXNNNNNNNNNNNNNNNNNNNNNNNNNXXNNNNNNNNXXK0Okkdc,...    ..';clooooooddxxxkkkkOOOd,.;x00KKKKKK0l. .;;;;,...........
............  .;lo;  .... 'ldxkOOOOOOOOOOOOOOkxooc;,..   ...',,,,;:ldxkO00KXXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXKK0OOkxxdddddoc,.  ..,:cooddoooooddxkkkkkOO000x:. ;xO0KKKKKKk, .,;;;;,'..........
.............  .,c;  ..... .,coxxkOOOOOOOOOOOOkxdooolc:;'....';coxxxxddoooddxxkkOO00KKKXXXNNNNNNNNNNNNNNNNNXXXKK0OOkkxxddoddddddol:'....,:ldxxxddddddoddxkkkkOOO0000k:.  ,okO000OOk:..';;;,,'...........
..............   .'. ......  .';codxxkkOOOOOOOkkxdool:;cloc:'....';:ldxxxxxddddooooooddddxxxxxkkkkkkkkkkxxxxddooooooodddxxxdoc;'....,:ldxxxxxxxxdddoodxxkkkOOOO0000kc.   ,odkOOOOx;..';;;;,''...........
................      ........  ..';:codddxxxxxddooool,.;odddoc:,......,;clodxdddddoooooollllllllllllllllllloooooddddddlc;'....';codxxkkkkkxxxxdddooodkkOOOOOO0000x;.    ;odxkkkd;..,::;;;;,''..........
..................    ...........    ..',;clloooooooooc..,oxxdoooolc:,'......,;:ccllloooooollllllllllllllllooooooolc:;,'.. .:loddxxxxkkkkkkxxxdolc:coxkOOOOOOOO0Od,  .  .:ooodoc...,;;;;;;;;,''.........
..................... ................    ..';cloooooooc..,oxxdoooodddddlc:,'..........',;;:cllllllllllllloooooolcc:::cc:..:odddxxxxkkxxxxxdoc;'',:oxkOOOOOOOOOxc. ...  'lool:'...,,;;;;;;;;,'.'''''..''
...........................................   ..,:looooo:..,odddl::lddxxxxxxxdoolc::;'  .;::clloooooooooooooooooooooollc' .:ccldxxxxxxxddoc,.. .cooxkOOOOOOOOkl'. ...  .coc;.. ..,,;;;;;;;,,''.'''''''''
.....'.................................',,,,'..   .,clool,  'codo;..;lodxxxxxxxxdddooc. .clooooooooooooooooooooooooooooc.  .  .cdddddol:'.... 'coodkOOOOOOOxl,. ..... .,:'.  ...',;;;;;;,'''''.''''''',,
....................................'',;:::::::;'...';lddl'..,cddo;..,coxxxxkkkkkxxxxd:.,oxxxxxxxkkkkkkkkkkkkkkkkkkkkkxd;''''',cdxxxxoc,,;cc;:dkkkk000K00x:'. ......  ... .....''',,,,,,,,'''..''',,,,;;
...................................,oO0KKKKKXXXKKKKK0KXNNXKKKKXXNNXKKKKXNNNNNNNNWWNNNNNXXNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNNNWWWWNNNNNWNNNWWWWWWWWWWW0c........    .........'',,,,,,,,,''..'',;;;;;;
...................................oXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNWWMMMMMMMMMMMWNNWWNXXWMWNXNWMMMMMMMMMWWNNWMMMMW0:....... .............'','''',,,''''',;;;;;;;
.....................''...........'dWMMMMMMW0xkKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk;c0MMMMWXO0NMW0c;kXo'cXNx;c0WMMMMMMMWOl;,,:xNMMMKc..............'''.....''''.''''''''',;::::::
...............'''''''''..........'dWMMMMMWk'  ,0WMMMWNNNXXNWMMMMWXXXNWMMMWNXXXNWMMWNXXNWMMMMMMMWX00KKXWWOloKWMMWKl.'xKNKolOK: ;KKol0NXKXXK0KNWOodd; .OWMMKc..............'''''..........''''''',;:::::;
..............'',,,,,,,,..........'dWMMMMW0,.,'.:KWMXo,;:;',c0WXd;,,,,l0WXd;,,,:OXkc,,,,ckNMMMMKc'',,,:ONx';OWMMKl.  ':kO;'xK: ;KO,,kKc.,;,..c0WWXx'.cKMMMKc............'''''''.............''',;:::::::
..............'',,,,',,'...........dNMMMMX: ,kx..cXMK; .oOx; ,xc..oOx, ;kc..oOkkKx..ckkc..xWMMWk' .;::oKNd..kWMMWKc .dKNO..oKc ,0x..xK; 'xKd..oNXo.;kNWMMMKc..........'''''''''.............''',;:::::::
..............'',,,,,'''...........dNMMMXl. .;,. .oNK; ,0WXl..l; ;0WXl .o; ,0WWNXo .xNNx..oNMMMNxc:,'..lKd..kMMMMWd..dXWO..oKc ,0x..dK; ;XM0' lNXdlOWMMMMMKc''....'''',,'''''''.............''',;:::::::
..............'',,,,,,''...........dNMMNd..ckOOkc..d0: .,:,..lKk,.':,.'dKk,.';;;dOc..;;..cKWMMM0c,,,'..lKd.'OWMMMW0;..;kk'.dXl.;Kk..xKc.:XM0,.oNK:'dNMMMMMKc''..',,,,,,,,''''''.............''',;;;;::::
...............',,,,,'''...........dNMMNkoxXMMMMXxoO0: 'odox0NWWXOdodkKWMWXkdodkKWN0xoox0NMMMMMNKOxxxk0NWXO0NMMMMMWX0kOXN0OXWKOKNXOOXWKOKWMN0OKWWXKNWMMMMMKc'''',,,,,;;;,,'''''..............''';;::::::
...............',,,,;,,'...........dNMMMMMMMMMMMMMMMXc.:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc'''',,',,,,,,,''................''',;::::::;
...............',,,;;;,,'..........oNMMMMMMMMMMMMMMMWKOKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc.''',,',,,,,,,''................''',,;:::::;
..............'',,,,;;,,'..........c0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWMWWWMWMMMMMWWWWWWWWWWWWWWWWNKd,.'.'',,,,;;,,,'...'.............''',;;::::::
..............'',,,,,,,''...........;oxkkkkkkkkkkkkkkOOOOOOOOkxxOX0xoodddddodOXNXNNN0dlllooooooooooooooooollllccccccccclllllokXOddxxxxxxxddoolllc:::ccllc;'.....',,,,;,,,''...'.............''',;::;::;;
...............',,,,,;,,'.................''.......'';;;::;;;'.'dOd.        .lO00KKKx'                                ..',;;:xKx,,;;;;;;;;;;,,,'.     ..........',,,,;,,,,''................''',;::;;;;;

     */

    public partial class Videos : Form
    {

        string VideoActual = "";
        string NombreVActual = "";
        VideoCapture videoCapture;
        SoundPlayer reproductor;
        bool Reproduciendo = false;
        bool Rep2 = false;
        int framesTotales;
        float framesActualNum;
        Mat frameActual;
        Bitmap bmpRes;
        int FPS;
        int filtro = 9;

        public Videos()
        {
            InitializeComponent();
            
        }

        private void btnCargarVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de video (*.mp4, *.avi, *.mkv, ...)|*.mp4;*.avi;*.mkv;...";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoCapture = new VideoCapture(openFileDialog.FileName);
                framesTotales = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount));
                FPS = Convert.ToInt32(videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps));
                Reproduciendo = true;
                frameActual = new Mat();
                framesActualNum = 0;
                LineaT.Minimum = 0;
                LineaT.Maximum = framesTotales - 1;
                LineaT.Value = 0;
                //reproductor = new SoundPlayer(openFileDialog.FileName);
                //reproductor.Play();
                //VideoEE.playlist.items.clear();
                //VideoEE.playlist.add(@"file:///" + openFileDialog.FileName);
                //VideoEE.playlist.play();
                VideoActual = openFileDialog.FileName;
                NombreVActual = openFileDialog.SafeFileName;
                PlayVideo();
            }
            
        }

        private async void PlayVideo()
        {
            if (videoCapture == null)
            {
                MessageBox.Show("Ingrese un vídeo correctamente.");
                return;
            }

            try
            {
                while (Reproduciendo == true && framesActualNum < framesTotales)
                {
                    videoCapture.Set(Emgu.CV.CvEnum.CapProp.PosFrames, framesActualNum);
                    videoCapture.Read(frameActual);
             
                    switch (filtro)
                    {
                        case 0:
                            bmpRes = InvertirColores(frameActual.ToBitmap());
                            break;

                        case 1:
                            bmpRes = OptimizedTonoSepia(frameActual.ToBitmap());
                            break;

                        case 2:
                            bmpRes = OptimizedGrayScale(frameActual.ToBitmap());
                            break;

                        case 3:
                            bmpRes = Pixelizado(frameActual.ToBitmap());
                            break;

                        case 4:
                            bmpRes = OjodePez(frameActual.ToBitmap());
                            break;

                        default:
                            bmpRes = frameActual.ToBitmap();
                            break;
                    }

                    VideoF2.Image = bmpRes;
                    VideoF2.SizeMode = PictureBoxSizeMode.StretchImage;
                    VideoF1.Image = frameActual.ToBitmap();
                    VideoF1.SizeMode = PictureBoxSizeMode.StretchImage;
                    LineaT.Value = (int)framesActualNum;
                    if (filtro >= 0 && filtro <=4)
                    {
                        framesActualNum += 2.5f;
                    }
                    else 
                    {
                        framesActualNum += 1.95f;
                    }
                    await Task.Delay(1000 / FPS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        unsafe public Bitmap InvertirColores(Bitmap bmap) 
        {
            Bitmap imgOriginal;
            imgOriginal = new Bitmap(bmap);
            BitmapData bmpData = imgOriginal.LockBits(new Rectangle(0, 0, imgOriginal.Width, imgOriginal.Height), ImageLockMode.ReadWrite, imgOriginal.PixelFormat);
            int bytesPerPixel = Bitmap.GetPixelFormatSize(imgOriginal.PixelFormat) / 8;
            int heightInPixels = bmpData.Height;
            int widthInBytes = bmpData.Width * bytesPerPixel;
            byte* PtrFirstPixel = (byte*)bmpData.Scan0;

            VarGau.Visible = false;
            VarGau.Maximum = heightInPixels;
            VarGau.Value = 0;

            for (int y = 0; y < heightInPixels; y++)
            {
                byte* currentLine = PtrFirstPixel + (y * bmpData.Stride);
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    currentLine[x] = (byte)(255 - currentLine[x]); // blue
                    currentLine[x + 1] = (byte)(255 - currentLine[x + 1]); // green
                    currentLine[x + 2] = (byte)(255 - currentLine[x + 2]); // red
                }
                VarGau.Value++;
            }

            imgOriginal.UnlockBits(bmpData);
            VarGau.Visible = false;
            return imgOriginal;
        }

        unsafe private Bitmap OptimizedTonoSepia(Bitmap bmap)
        {
            Bitmap imgOriginal = new Bitmap(bmap);

            int height = imgOriginal.Height;
            int width = imgOriginal.Width;

            VarGau.Visible = false;
            VarGau.Maximum = imgOriginal.Height;
            VarGau.Value = 0;

            BitmapData sourceData = imgOriginal.LockBits(new Rectangle(0, 0, width, height),
                                                  ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte* ptrFirstPixel = (byte*)sourceData.Scan0;

            Parallel.For(0, height, y =>
            {
                byte* currentLine = ptrFirstPixel + (y * sourceData.Stride);
                for (int x = 0; x < width; x++)
                {
                    int index = x * 4;
                    int blue = currentLine[index];
                    int green = currentLine[index + 1];
                    int red = currentLine[index + 2];

                    int sepiaRed = (int)(0.393 * red + 0.769 * green + 0.189 * blue);
                    int sepiaGreen = (int)(0.349 * red + 0.686 * green + 0.168 * blue);
                    int sepiaBlue = (int)(0.272 * red + 0.534 * green + 0.131 * blue);

                    if (sepiaRed > 255)
                    {
                        sepiaRed = 255;
                    }
                    if (sepiaGreen > 255)
                    {
                        sepiaGreen = 255;
                    }
                    if (sepiaBlue > 255)
                    {
                        sepiaBlue = 255;
                    }
                    currentLine[index] = (byte)sepiaBlue;
                    currentLine[index + 1] = (byte)sepiaGreen;
                    currentLine[index + 2] = (byte)sepiaRed;

                }
            });
            imgOriginal.UnlockBits(sourceData);

            VarGau.Visible = false;
            return imgOriginal;
        }

        unsafe private Bitmap OptimizedGrayScale(Bitmap bmap)
        {
            Bitmap imgOriginal = new Bitmap(bmap);

            BitmapData bmData = imgOriginal.LockBits(new Rectangle(0, 0, imgOriginal.Width, imgOriginal.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            IntPtr scan0 = bmData.Scan0;

            int nWidth = imgOriginal.Width;
            int nHeight = imgOriginal.Height;

            VarGau.Visible = false;
            VarGau.Maximum = nHeight;
            VarGau.Value = 0;

            byte* p = (byte*)scan0.ToPointer();

            for (int y = 0; y < nHeight; ++y)
            {
                for (int x = 0; x < nWidth; ++x)
                {
                    int idx = y * stride + x * 3;

                    byte gray = (byte)(0.299 * p[idx + 2] + 0.587 * p[idx + 1] + 0.114 * p[idx]);

                    p[idx + 2] = p[idx + 1] = p[idx] = gray;
                }
                VarGau.Value++;
            }
            imgOriginal.UnlockBits(bmData);

            VarGau.Visible = false;
            return imgOriginal;
        }

        unsafe private static Color GetAverageColor(int* sourcePointer, int x, int y, int blockSize, int width, int height)
        {
            unsafe
            {
                int sumR = 0, sumG = 0, sumB = 0;
                int count = 0;

                for (int i = y; i < y + blockSize && i < height; i++)
                {
                    for (int j = x; j < x + blockSize && j < width; j++)
                    {
                        Color pixel = Color.FromArgb(*(sourcePointer + i * width + j));

                        sumR += pixel.R;
                        sumG += pixel.G;
                        sumB += pixel.B;
                        count++;
                    }
                }

                int avgR = sumR / count;
                int avgG = sumG / count;
                int avgB = sumB / count;

                return Color.FromArgb(avgR, avgG, avgB);
            }
        }

        private Bitmap Pixelizado(Bitmap bmap)
        {
            Bitmap sourceBitmap = new Bitmap(bmap);
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;

            Bitmap resultBitmap = new Bitmap(width, height);

            int blockSize = 10;
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData sourceData = sourceBitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData resultData = resultBitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            unsafe
            {

                VarGau.Visible = false;
                VarGau.Maximum = height;
                VarGau.Value = 0;

                int* sourcePointer = (int*)sourceData.Scan0;
                int* resultPointer = (int*)resultData.Scan0;

                for (int y = 0; y < height; y += blockSize)
                {
                    for (int x = 0; x < width; x += blockSize)
                    {
                        Color avgColor = GetAverageColor(sourcePointer, x, y, blockSize, width, height);

                        for (int i = y; i < y + blockSize && i < height; i++)
                        {
                            for (int j = x; j < x + blockSize && j < width; j++)
                            {
                                *(resultPointer + i * width + j) = avgColor.ToArgb();
                            }
                        }
                    }
                    VarGau.Value++;
                }
            }

            sourceBitmap.UnlockBits(sourceData);
            resultBitmap.UnlockBits(resultData);

            VarGau.Visible = false;
            return resultBitmap;
        }

        unsafe private Bitmap OjodePez(Bitmap bmap)
        {
            Bitmap sourceBitmap = new Bitmap(bmap);

            int inputWidth = bmap.Width;
            int inputHeight = bmap.Height;

            int centerX = inputWidth / 2;
            int centerY = inputHeight / 2;
            float Strength = 2.5f;

            // Radio máximo de la imagen de entrada
            float maxRadius = (float)Math.Sqrt(centerX * centerX + centerY * centerY);

            // Factor de distorsión
            float factor = 2.5f / Strength /*/ maxRadius*/;

            // Imagen de salida
            Bitmap outputImage = new Bitmap(inputWidth, inputHeight, sourceBitmap.PixelFormat);

            // Puntero a la imagen de entrada
            BitmapData inputData = sourceBitmap.LockBits(new Rectangle(0, 0, inputWidth, inputHeight), ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
            byte* inputPtr = (byte*)inputData.Scan0.ToPointer();

            // Puntero a la imagen de salida
            BitmapData outputData = outputImage.LockBits(new Rectangle(0, 0, inputWidth, inputHeight), ImageLockMode.WriteOnly, sourceBitmap.PixelFormat);
            byte* outputPtr = (byte*)outputData.Scan0.ToPointer();

            VarGau.Visible = false;
            VarGau.Maximum = inputHeight;
            VarGau.Value = 0;

            // Distorsión radial de la imagen
            for (int y = 0; y < inputHeight; y++)
            {
                for (int x = 0; x < inputWidth; x++)
                {
                    // Posición del píxel en la imagen de salida
                    int outputIndex = (y * outputData.Stride) + (x * 4);

                    // Vector desde el centro de la imagen hasta el píxel
                    float dx = x - centerX;
                    float dy = y - centerY;

                    // Radio del vector
                    float radius = (float)Math.Sqrt(dx * dx + dy * dy);

                    // Factor de distorsión radial
                    float distortion = factor * radius;

                    // Posición del píxel en la imagen de entrada
                    int inputX = (int)(dx * distortion / maxRadius + centerX);
                    int inputY = (int)(dy * distortion / maxRadius + centerY);

                    // Comprobamos que la posición del píxel de salida esté dentro de la imagen
                    if (inputX >= 0 && inputX < inputWidth && inputY >= 0 && inputY < inputHeight)
                    {
                        // Posición del píxel de salida en la imagen de salida
                        int inputIndex = (inputY * inputData.Stride) + (inputX * 4);

                        // Copiamos el valor del píxel de entrada en la posición del píxel de salida
                        outputPtr[outputIndex] = inputPtr[inputIndex];
                        outputPtr[outputIndex + 1] = inputPtr[inputIndex + 1];
                        outputPtr[outputIndex + 2] = inputPtr[inputIndex + 2];
                        outputPtr[outputIndex + 3] = inputPtr[inputIndex + 3];
                    }
                }
                VarGau.Value++;
            }

            // Liberamos los punteros de memoria
            sourceBitmap.UnlockBits(inputData);
            outputImage.UnlockBits(outputData);

            VarGau.Visible = false;
            return outputImage;
        }

        private void btnAplicarFiltroV_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbFiltrosV.SelectedIndex;
                switch (selectedIndex)
                {
                    case 0: //Invertir colores
                        filtro = 0;
                        break;
                    case 1: //Tono Sepia
                        filtro = 1;
                        break;
                    case 2: //Escala de Grises
                        filtro = 2;
                        break;
                    case 3: //Pixelizado
                        filtro = 3;
                        break;
                    case 4: //
                        filtro = 4;
                        break;
                    default:
                        MessageBox.Show("Por favor seleccione un filtro.");
                        break;
                }
        }

        private void LineaT_Scroll(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                framesActualNum = LineaT.Value;
                //reproductor.
                //VideoEE.playlist.
            }
        }

        private void bntPlay_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                Reproduciendo = true;
                if (!Rep2) 
                {
                    PlayVideo();
                }
                Rep2 = true;
                //VideoEE.playlist.play();
                //reproductor.Play();
            }
            else
            {
                MessageBox.Show("No se cargó un video", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reproduciendo = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproduciendo = false;
            Rep2 = false;
            //reproductor.Stop();
            //VideoEE.playlist.pause();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            if (LineaT.Value >= LineaT.Maximum-1 || (!Reproduciendo && !Rep2)) 
            {
                Reproduciendo = true;
                framesActualNum = 0;
                LineaT.Value = 0;
                PlayVideo();
                Rep2 = true;
            }
            //VideoEE.playlist.play();
        }
    }
}
