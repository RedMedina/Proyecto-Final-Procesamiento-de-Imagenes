using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Proyecto_Final_Procesamiento_de_Imagenes
{

    /*
     ccccccllllcckNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNKKNWWWWWX0KNNXNNX0KWWWWWWWWWWWWWWWWWWWXkdxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdddddddxxddddddddddddddddddxdxKWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWW
lccccllllllco0NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNK0NWWWWWN0KXXXNNNK0NWWWWWWWWWWWWWWWWWWXxdxxxxxxxxxxxxxxxxxddxxxxxxxxxdddddddddddddddddddddddddddddddddddddddddddxoxXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNXK
ollcllllcc:cldKNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWNX0XWWWWWWK0XNXXXNX0XWWWWWWWWWWWWWWWWWWXkdxxxxxxxxxxxxxxxxddddddddddddddddddddddddddddddddddddddddddddddddddddddddddONWWWWWWWWWWWWWWWWWWWWWWWWWWWNK00K
dolllllccccclld0NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNX0KWWWWWMX0KXXNNXXK0NWWWWWWWWWWWWWWWWWXxdddxddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddodKWWWWWWWWWWWWWWWWWWWWWWWWWWNK00KXX
lccllccccllllllokXNNNNNNNNNNNNNNNNNXNNNNNNNNNNNNNNKKNWWWWWWX0XXXXNXX0KWWWWWWWWWWWWWWWWWXxoddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddoxNWWNWWWWWWWWWWWWWWWWWWWWWWXKKKXXXX
cclccccccccccclllokXNNNXXKKKKKKKKKKXNNNNNNNNNNNNNX0XWWWWWWWKKXXNXXNK0NWWWWWWWWWWWWWWWWNkdddxdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddod0NWWWWWWWWWWWWWWWWWWWWNNWX00KXXXXXX
llllllcccc:::ccccccok00KXXNK0XNXXKKK00KKKXNNNNNXX0KNWWWWWWN0KXXXXXX0KWWWWWWWWWWWWWWWWNkodddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddoddookNWWWWWWWWWWWWWWWWWWWWWWNK0KXXXXXXXX
cclccc::::::ccccccc::ckNWWWXKNWWWWWWKKXXKKKKXXXXKOXWWWWWWWN0KXXXXXK0XWWWWWWWWWWWWWWWW0dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddooooooodddddoooooodKWWWWWWWWWWWWWWNWWWWWWNK0KXXXXKXXXX0
::::::::::cloollllcc:l0WWWWWWWWWWWWWXKWWWWNK00XKO0NWWWWWWWN0KXXNXXK0NWWWWWWWWWWWWWWWKdodddddddddddddddddddddddddddddddddoooooooooooooooooooooooooooooooooooooooooookNWWWWWWWWWWWWWWWNWWWWX00XXXXXXXXXX00
:::::::::cloddolooolcckWWWWWWWWWWWWWXKNWWWWWKxdodKWWWWWWWWN0KXXXXX0KWWWWWWWWWWWWWWWNkooddddddddddddddddddddddddddooooooooooooooooooooooooooooooooooooooooooooooooldXWWWWWWWWWWWWWWWWWWWNKOKXXKXXXXXXX00N
c:::::cccclllllooolcccdKWWWWWWWNWWWWWWWWWWWWWOlcxNWWWWWWWWN0KXXXNKOXWWWWWWWWWWWWWWW0oodddddooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo0WWWWWWWWWWWWWWWWWWWXO0XXXXXXXXXXXO0NW
::::::ccccccccccc::::::o0NWWWWWWWWWWWWWWWWWWWNklkWWWWWWWWWN0KXXXXKOXWWWWWWWWWWWWWWXxlodoooooooooooooooooooooodooooooooooooooooooooooooooooooooooooooooooooooooollkNWWWWWWWWWWWWWWWWWN0OKXXKXXXXXXXKO0NWW
;;;::::::cccccllccc::;::cxKNWWWWWWWWWWWWWWWWWWXxOWWWWWWWWWWK0XXXX00WWWWWWWWWWWWWWWOoooooooooooooooooooooooooooooooollooooooooooooooooooooooooooooooooooooooooollxXMWWWWWWWWWWWWWWWWXOOKXXXXXXXXXX0k0NWWW
:::::;;::ccccloddlc:;;::cloxKNWWWWWWWWWWWWWWWWNO0WWWWWWWWWWKOKXXKOKWWWWWWWWWWWWWWXxloooooooooooooooooooooooooolloxOOdllooooooooooooooooooooooooooooooooooolooocdXWWWWWWWWWWWWWWWWWKO0XXXKXXXXXXX0kKWNNWW
:cll::;;:clooddxxdoc:::cclcccoKWWWWWWWWWWWWWWWNOKWWWWWWWWWWXO0XXKOKWWWWWWWWWWWWWWKoloooooooooooooooooooooooolldOKXXXOoloooooooooooooooooooooooooooooooooollooldKWWWWWWWWWWWWWWWWN0OKXXXKXXXKKXKOOXWWWNWW
:clcccc::ccloddxxkxdlcccllll:cOWWWWWWWWWWWWWWWNOKWWWWWWWWWWW0kKXK0XWWWWWWWWWWWWWWOoooooooooooooooooooooooooold0XXXXXXOlloooooooooooooooollllllllllllllllloooloKWWWWWWWWWWWWWWNWN0OKXXXXXKXXKX0k0NWWWWNWW
cllcllooooodddxxkkxocc:::ccc;c0WWWWWWWWWWWWWWWNOKWWWWWWWWWWWXO0XK0NWWWWWWWWWWWWWNxloooooooooollllooollooollolo0XXXXXX0oloooooooolllllllllllllllllllllllllloll0WWNWWWWWWWWWWWWWXOOXKKXXKXKKXKOkKWWNWWWWWW
oooooodxxxxxxxxxxdolccc::::;,lKWWWWWWWWWWWWWWWNO0WNWWWWWWWWWWXO0KKNWWWWWWWWWWWWWNxcoooollllllllllloolllllooollkKXXXKkollllllllllllllllllllllllllllllllllllllOWWNWWWWWWWWWWWWNXOOKXXKKKXXKK0O0NWWWWWWWWWW
loodddddxxxxxxxddolllloolc:;,lXWNXXXNWWWWWWWWWW00WWWWWWWWWWWWWXkk0NWWWWWWWWWWWWWNdcolllllllllllllllollllllllllkKXXOolllllllllllllllllllllllllllllllllllllclONWWWWWWWWWWWWWWWXOOKKXKKKKXX0kOXWWWWWWWWWWWW
llooddddddddddddoollloodolc::dNWK0KKKKKNWWWWWWWX0XWWWWWWWWNWWWWX0XNWWWWWWWWWWWWWNdcllllllllllllllllllllllllldOKXXKdcllllllllllllllllllllllllllllllllllllcl0NWNWWWWWWWWWWWWWXOOKXKKKKXX0kkKWWWWWWWWWWWWWW
llooooodddddddoooollooooollllxNX0XWWWNKKKKNWNWWN0KWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNdcllllllllllllllllllllllcoOKXXXXXOlcllllllllllllllllllllllllllllllllllcl0WWWWNWWWWWWWWWWWNOOXKKKKKKK0k0NWWWWWWWWWWWWWWW
oooooooodooooddooolloollcccllkNK0NWWWWWWNK00KNWWK0XWWWWWWWWWWWWWWNNWWWWWWWWWWWWWNxclllllllllllllllllllllcd0XXKKXXX0lclllllllllllllllllllllllllllcclllccdKWWWWWWWWWWWWWWWWW0kKXKKKXKOk0XWWWWWWWWWWWWWWWWW
llllllllllllloooollllolllllllONKKNWWWWWNNWWX0OKNW00WNWWNWWWWWWWWWWWWWWWWWWWWWWWWWkllllllllllllllllllllccxKKXKXXXXXOlclllllllllllllllllllllllllllllllccdXWWNWWWWWWWWWWWWWWKO0XXXKK0OOXNNWWWWWWWWWWWWWWWWW
lllllllccclllllllllloooooooolOWX0XWWWWWWWWWWWXOOKXOKWWWWWWWWWWWWWKOKWWWWWWWWWWWWW0lcllllllllllllcllcllco0XXKKXXKXKxccllllccclcccllllllllccccllcclclccxXWWWWWWWWWWWWNWWWWNO0XKKKOO0XWWNNWWWWWWWWWWWWWWWWW
ccccccccccccccllllooooooooooo0WX0XWWWWWWWWWWWWWXOkkONWWNWWWWWWWWWXxxO0XWWNWWWWWWWKoclcllcccccclllccllclOXKKKKXKKX0l:cccllccccccccccccccccclcclcccc:lONWNWWWWWWWWWWWWWWWWOkXX0OO0XWWWWWWWWWWWWWWWWWWWWWWW
cccccccccccclllloooooooooooll0WNO0WWWWWWWWWWWWWWNKkdkNWWWWWWWWWWWWNOkOOO0XWWWNWWWNkcclccccccccccccccc:dKXKKKKKKXKd:cccllccccccccccccccccccccccccc:o0NNWWWWWWWWWWWWWWWWWKkO0OOKNWWWWWWWWWWWWWWWWWWWWWWWWW
lcc:::::cllloooooooooooooooll0WNOOWWWWWWWWWWWWWWWNNOdONWWWWWWWWWWWWN0k00OOOKNWWWWWKl:lccccccccccclc:,cOKXKKXXKKXOc:cccccccccccccccccccccccc:clccckXNNWWWWWWWWWWWWWWWWWNOxO0XNWNNWWWWWWWWWWWWWWWWWWWWWWWW
doolc:;::cloollllooooooooooll0WWXOXWNWWWWWWWWWWWWWWWN0OXWWNNWWWWWWNWWXOOKK0kOOKNWWNkcclcccccccccccc:;o0XKKXKKKX0lclcccccccccccccccccccccccccc:cdKWWNNWWWWWWWWWWWWWNWWWWNNWWWWWNWWWWWWWWWWWWWWWWWWWWWWWWW
oooolc:::clollcclllllllllllclOWWNO0NWNNWWWWWWWWWWNWWWWKO0NWWWWWWWNWWWWNKOOKKK0kk0KNXd:cccccccccccccccdKKKKXXKK0o:ccccccccccccccccccccccccclc:o0NWNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
lllooolc:::cccccccccccccccc:cONWWXOKWNWWNWWWWWWWWWNWNNWNOONWKdx0XNWWNNNWXOk0KXKK0kk00dcccccccccccc:coOKKKKKKKKx::cccccccccccccccccccccccc::oOXWNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
llcllollcc::::::::::::::;;;,;kNWWWKOXWNWWWWWWWWWWWNWWWWWNKXW0;.,;lx0NWWNWNKOOKKKXK0OOxc:cccccccccc:cxOXKKKKKKxc:cccccccccccccccccccccccccokXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
ccccclccc::::::::::::;;;,,,',xNWWWN0ONWWWWWWWWWWWWWWWNNNWWWWNd'....,cxKNWWWN0kOKXKKKXKkdlc:ccccccc:ok0XKKKKKkc;ccc::ccccccccc:::c:::ccccdO00OOOOOOOO000k0NNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
:::::c:::;;;;;;;;::;;,,,,,,,,dNWWNWNOONWWWWWWWWWWWWWWWWWWWWWWXl...'...;OWWNNWXOxOKKKXKKK0koc::ccc::xKKKKKKKOl:::cccccc:::::cloodxxxkOO00KKKKKKKKKXX0OkOk0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
:::ccc:::;;;;;;;;;;;,,,'''';,oNWWWNWNO0NNWWWWWWWWWWWWWWWWWNNWW0:......lXWNNWWWNKOkOKKKKKKKK0kolcc::xKKKKKK0o:::cc:::clodxkkO0KKKKKKKKKKKKKKKXXK0OOOO0XNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
ccllollcc::;::;;,;;;;;,,'',;,lXWWWWWWXO0NWWWWWWWWWWWWWWWWWWWWWk,.....:KWWNWWXXXNNKkk0KXKKKKKKK0kdcckKKKKXKd::::cloxkO0KKKKKKKKKKKKKKKKKKKKK0OkOO0KXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
cclloolllcc:::;;;;;;;;;;,,,;;lKWWWWNNWNOONWNWWWWWWWWWWWWWWWWWXl.....,OWWKxl;,,,;cokOOO0KKKKKKKKKK0OKKKKKKx:;coxO0KKKKKKKKKKKKKKKKKKKKK00OO0OOKNNWWWWWWWWWWWWWWWWWWWWWWWWWNNWWNNWWWWWWWWNNXXKK00000KKKK00
cclllllcccccc:;;,,;;::;,,;;;;cOWWNNNNNWNOONWWWWWWWWWWWWNWWWNWXc.....oNXd,.;ldxdl,..,oxkO0XKKKKKKKKKKKKKX0ddO0KKKKKKKKKKKKKKKKKKKKK0OOOO0KXNNNWWWNWWNXKKKKKXXXXXNNWWWWWWWWWNNWWWNNXK00KK0KKKKKK00KKKKKKKK
cccclcc:::::;;;,,,,,;;,,,',,;;xWWWWWWNWWN0OXWWWWWWWWWWWNWWWWWXc....,OO;'ckXNNWWWXOl'.'oOkk0KXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKOOOOOO00XNWWWWWWWWNWNNO;',,,,,,,;;;ckXNNWWWWWNXKKK000KKXXNWWWWWWWWWWWWWWWWW
cccccc::;;;;,''''''''''.....,'lNWWWWWWWWWNKOKNWWWWWWWWWNWWWWWXl....:o,;ONWWNNWWWNWWKo,.:0KOOOKKKKKKKKKKKKKKKKKKKKKKKKKK00OOO0Oxocc:;;;:ldOXWWWWWWWNx'........,:lxKWWWWNXK000KKXNWNNNNNWWWWWWWWNNWWWNNNWW
cccc::::;;,''......'........''cKWWWWWNWWWNWXk0NWWWWNWWWWWWWWNWO,....'oXWWWWWWWWWWWWNN0c.:KWXOkO0KKKKKKKKKXKKXKKK0OOOO0O00KX0d:..';clol:;..;oONNNNWNo......;okKXWWWWXK000KNWWWWNWNNWWWWWWNNWWWWWNWWWWWWWW
::c::;;;,''.......''..........,kWWWNNXXXXKK0OdxXWWWWWNNWWWWWNWNd...'xNWWWWWNWWWWWWWWWWNd'xWNWXdcx0KKKKK00OkOOO0000KKXWNWWKo'.:dOXNWWWWWNKx:..lKNNWK:.....:KWWWWWNK0O0XWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
ccllcc:;'......................oK00K000KKKKKKK00XWWWWWWWWWNNWWWNk;.;0WNWWWWWWWWWWWWWWWWXO0WNNW0:;cooloooc:xKXXNWWWWWNWWKo',o0NWWWWNWWWNNWWXx;.;0WWk'....'kWNWWNKO0XNWNWNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWW
ooooool:,'.'''',,''.........;ld0XXNNWWWWWNNNNNWNNWWWWWWWWNNNWWWNKkc;x0000KKXXNNWWWWWWNNWWWNNWWWk:;:;;;;:lONWNNNWWWNWWN0:,dXNNNWWNNNWWWNNWWNWXl.:KK:....'kNWWWNNXNWNWWNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
ooollllc;,,;;;::::;;;;,'...'dXWWWWNNWWWNWNNWNNWWWWWWWWWWNOKWWNX0OOOOOOO0OOOO00KXNWNWWNNWWNNWWWWNOlcclox0NWNNWNWWWWWWNWKkKWWNWNNWWWWWWWNNWWWNNNo.::....;ONWWWWWWWWWWNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNWWNW
llccllllccclloooolllcc:;;,,',lONWNNNWWNNWNNWWWWWWWWWWWWWKOXWNNKOOO0OOOOOOOO000OO0XNWNNWWWWNNWWWWNkkNWWWWNNNWWWWWWWNWWWWWWNNNWWWWWWNNNNNNNNNWNWX:....,dXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWNNW
:::cllccllloooooollllc::::;;,';lOXNNWWNWWNNNWWWWWWWWWWWWXOXWWNX0OOOOOOOOOOOOOOOOO0XWNNWWWWWWNWWWXk0WNWWWWNNWWWWWWWNWWNNWWNNWWWNXXKK00000000KKOl'.':xXNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNWWWW
:::::ccccllloollcccc:;;;,,;;;;:::dO0XNNWWWWWWWWWWWWWWWWWXkKWNWNK00OOOOOOOOOOOOOO0KNWNWWNNNNWWWWWXkKWWWWWWWWWWWWWWNWWWNNNNNWWNX00OOOOOOOOOO0Oo::cox0XNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNWNNWWN
:::::::ccccllolcc:;;;,'''',;:ccccoO0000XWWWWWWWWWNWWWWNWNk0WNWWNNXKK00OOOOOOO00KXNNNNWNWWWNXKK00OxOKKKKKK00KKK0O0XNWWNWWWNWNK0OOOOOOOOOOOO0OkO0000OOKNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWWNWWNWWWXOl
ccc::::cccclllc::;,,,''',,;:ccccc:kWWX0000KNWWWNNNNWWWWWNOONWWWNNNWNNNXXXXXXXNNNWWWNX0xol::xKK0KKXXNNXNNXXXXKk:.',;cldOKNWWNKO0OOOOOOOOOOOOOOOOOOOOOOKNWNNNNWWWWWWWWWWWWWWWWNNNWWWWWWNNWWWNNWWWNWWN0d:..
cc::::::ccccc:::;,,,',,;:::::cclc:oXWNNNX00000XXNWWWNWWWWKkKWNWNNNWWWWWWWWWWWWWWWNNx;'.....,dKWWWWWWWWWNNWNOo,.........':lx0X0OOOOOOOOOOOOOOOOOOOO0OOXWWNNNNWWWWWWWWWWWWWWNNNWWNWWNNWWWNNWNNNWNKOd:.....
:::;;;;;:::;;;;;,,,,,,;:ccccccc:c::OWWWWNNNWNKKKKK0KXWWWWNOONWWWNWWWWWNWWWWWNNWWWWK;.........;oKNNWWWWWWXkc'...............'oKXK0000OOOOOOOOOOOOOOO0XNWWNNNNWWWWWWWWWWWWWWNNWWWNNWWWNWWWWWX0ko:,........
;;;;;,,,,,,;;;;,,,,,,,,;:cclccccc:;oXWWWWWNNNWWWNNK0KKKKKKOd0WWWWNNWWNWWWWWWWWWWNWO'...........'ckKNWN0d;....................xNWNNXXXKK000K0000KKKXNWWWWWWWWWWWWWWNNWWWNNWWWWWWWNNNNXKOkxdl;'...........
,;;;;,,''',,,,,,,,,,,;;;:ccccccc::,:OWNWWWWNNWWWNWWWWWNNKKKkkKWWNNWWWWWWWWWWWWWNNWO'..............;cl:'......................lXWWWWWWWWWWNNNNNNNNWWWWWWWWWWWWWWWWWNWWNNXKKKKKKKK0Odc;,'',,,,............
,',,,,''''''''',,,,;;;;:::::::::::;,dNWWWWWNNWWWWWWWWWWWWWWN0kXWNNWWWNWWWWWWWWWNNW0'........................'''''............;KWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWWNNNNXXXXXNNNKOxo:,''''............
;;,'',,'''..'''''',,;;;::;;::::::::;c0NNWWWWWWWWWWWNWWWWWNNNN0kKWWWWWNWWWWWWWWWNNWK;...............'',,;;;;;;;;;;;;;;,'......;KWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWNNNWX0xl;....,,,,'....
;;;;,''''.......''',,,;;;::ccc:ccclc:dNWNWWWWWNNWWWWWWWWWWNWWWKkKNWWWWWNWWWWWWWWNWXl...........'',;:::cccclllccclccc::;;;,'..:KWNNNNNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNWNWWNXko;'';;;;'...
;;;;;,'..........'',,,,,;;:cccccclllcc0NNWWNWWWNWWWWWWWWWWWWWWWXO0NWWWNWWWWWWWWNWWWk.........',;:cloooddddddddddddddooc::::;'oXWNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNXko:,;:,''.
;;;;;;,'.......'',,;;;;;;::cc:::cllll:dXWNWWWWNWWWWWWWWWWWWWWWWWN0kONWWWWNNNWWWNNWWKc.......,:cloddddddddddddddddddddddolc:,;ONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWNXkl;,''.
;;;;;;;;,...',,;;;;;::::::::::::lllllccOWWWNNNWWWWWWWWWWWWWNNNWWNNKkkKNWWWNWWWWNNWNWO,.....;clodddddddddddddddddddddddddddc;dXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNNNXOo,'.
;;;;;;;;;;'.,;;;;;;;;;;:::;;;;;:::cccccoKNWWNWNNWWWWWWWWWWWNWWWWWWWWKkOXNWWWWWWWWWWWNx'...;lddddddddddddddddddddddddddodddldXNNNNWWWWWWWNWWNNNWWWWWWWWWWNNNNWWWWNNNWWWWWWWWWWNNWWWWWWWWNNWWWWWWNWWX0d;..
;;;;;;;;;;;,';::;;;;;;;;;;;;;;,;;::::cc:xWWWWWWNWWWWWWWWWWWWWWWNWWWWWNKOOKNWWWWWNNNWWXx'.'lddddddddddddddddddddddddddddddldXWWNNWWWWWWWWWNWWNNWWNWWWNNWWNNNNWWWNNWWWWWNNNWWWWWNNNWWWWWWWWWWWWNX0ko:'....
;;;;;;;;;;;;,,::::;;,,,,,,;,,,',,;;::::;lKWWWWWWWWWWWWWWWWWWWWWWWWWWNWWNKOOKNWWWWNWWWWNk,;dddddddddddddddddddddddddoddoookXNWWWWNWWWWWWWWNWWWNNWNKkxkO00KXNNWWWWWWWWWNNNWWWWWWWWWWWWWWNXK0Oxoc;'........
;;;;;;;;;;;;;,';;;;;,,,,,,,,,,,,,;;;:::;;xNWNWWNWWWWWWWWWWWWWWWWWNWWWNNNNNK0OOKNNWWWNNNN0olodddddddddddddddddddddddddooxKNWNWWNNWWWWWWWWNNWNNWN0koc:ccclodxxxkkOO0000OOOOOOOOkkxxxdllc:;;:cc;,''''''....
;;;;;;;;;;;;;;;'',,,,,,,;,,,,,,,,,,,;::c:c0WWWNWWWWWWWWWWWWWWWWWWWWWWWNNNNWWNK000XWNNWWWWXkoloddddddddddddddddddddoodkKWWWWNWNWWWWWWWNNWNNNNXOdlodddoooddooooolllllllcc::;,'..........',;cllc::c:,......
;;;;;;;;;;;;;;;,'''',,,,,;;;,,,,,,;;;::::;oXWNNWWWWNNNNWWWWWWWWWWWWNNWWNWNWWWWW0:'cx0NWWWWWN0xdolooodddddddddoooloxOXNWWWNNNNNWWWNWWWNNWWNKkoloddddddolc;,;looooooooooooollc:;,'...';cllccclllodo:'.....
;;;;;;;;;;;;;;;;,',,,;,,,,,,,,,,,,,,;;;,;,,xNWWWWWWNNNNWWWWWWWWWWWNNNWWWWNWWNWXc.....;lx0NNNWWNK0OkxxxdoooddxxkO0XNNNWWNNNWWWNNNWWWWNNXKkolcccodddolc;'....;oooodoolooooooddool;'..,:ccllcodxxxdl;'....'
;;;;;;;;;;;;;;;;;,,,,,,,,,,,;;;;;;;;;,,,,;,c0WWWWWWNNNNWWWWWWWWNWWNNNXNWWNWWWNd..........,cok0XNWWWWWNXKKKXXNNWWWNNWWNNNWWWNNNWWWWNKkdl:;:ccccllllc;.......;ooodoooooooooddxxddc,,,,;;;::clxkkkxoc::;;;;
',;;;;;;;;;;;;;;;;,',,,,,,;;;;;,;;;;,,'',,;;lKWWWWWNWWNNWWWWWWWWNNWKc,oKWWNNWO,..............cc:lk0000KXXNNWWWNNNWWWWWWWWWWWNNKOxdl;'.'',,,,;:clc;.........;oooolllooodddddddddoc::;;:cc::coddddololc;,,
',;;;;;;;;;;;;;;;:,'',,,,;;;;;,,,,,;,,,,,;;;;dXWWWWWWWNNWWWWWWWWNWXl...:0WNWNo...............'...:kkkkO0KKKXXXK00000O0Okddolc:,'',,,'.''''''';:;'..........;ooooooloodddddoooooollccclolllllcclcccllc;,'
''';;;;;;;;;;;;;;;;,,,;;;;;;,,,,,,,,,,,,,,;;,;kNWNWWWNWWWWWWWWWNWWk'....;ONW0;...................;OK0KK000000000K00OOOkc::,,;;,'.''''......,;,'............;ooooolllooolllllllcccccclooolllc:;;:;,,;;;,'
'.',;;;;;;;;;;;;;;;;,,;;,,,''',,,,,,,,,,,,,,,';OWWWNWWNNWWWWWWWNWX:......,0Wk'...................;kK0KKK00KK0000K0K00Kkllocccc:,',,........,,..............:ooddddoolcc:::cccccllllloddddoc:cllc;'.''.''
''.',;;;;;;;;;;;;;;;,''',;;,''''''''',,',,,,,,,lKWWWWWNNWWWWWWWWWO'.......:Kd....................;OK00K000KKKK0000K00Kxcooolc::::;'........................cddddoddool:;,,,;;:cllooodooooolclddoc,'''',;
''''',;;;;;;;;;;;;;;;'';:cc:;;,''''',,,,;;;::::;oXNNWWWWNWWWWWNWNd.........ol....................:0K0KKKKKKKKKKKK0000Kxcodoollllc'.......'................,lollcccllc:;''''',:cccloooooooolllllc;,,,;;;:
'''..',;;;;;;;;;;;;;;,;lollllc:,,,,,;;;;;::;;;:;,dNNNWWWNWWWWWNWX:..........'....................lXXKKKKKKK000KKKKKXKXKocoollllc,.........................,c:,,,,,;:;,'....',;::cclllloolccccc:;;;;;;;;:
''..''',;;;;;;;;;;;;;,;collllc;,,'''',,,,;;,,;::;:kNWNWWNWWWWWNW0,...............................dWNNNNNXXXXXXNNNNNWNWWO:'',;::,..........................',......',,,'...,;;;;::cc::ccc:;,;:cccccc:;;;;
...''''',;:;;;;;;;;;;;,:lccc:;,,,;,'',,,,,,;;::::;cONWWWNWWWWWWWO,.............................,:OWNWWWNWWWWWWWWWWNWWNWW0:.........................................',,''..';:::::::;,,;;,',;clooollc::;,
...''''.',;;;;;;;;;;;;,;c:;;;;;;::::::;,,,,,;;;;;;,c0NWWWWWWWWWWk'.........................':d00OKWWWWNNWWWWWWWWWNNWNNWWWXd,........................................',,'''';:::cc:,''',,,,;cllllooll:;,,
...''''''',;;;;;;;;;;;;;::;;:cloooollc:,,''',,;;;;;,lXWWWWWWWWWWx.........................:ONN0kKWWNNWWNWWWWWWWWNWWWWWWWWNO;.........................................''''',;:::;;,'''',,;::cc::cclllc::;
...'''''.'',;;;;;;;;;;;;clllloddddolcc:;,,,,,,,,'''',dNWWNNNWWWWx.........................oNWXXNWWWNNWWNWWWWWWWWNWWNWNNWKo.............................................',;;;;;;,'.',,,'',;::::ccccccc:;,
'...'''.'''',;;;;;;;;;,;loooodddxdolllc;,,,;;;;,'..'.'dXWWNWWWWWx.........................oWWNWNNNNNWWNNWNNWWWWWNWWWWWXx;..............................................',,,,,,,'''.',,'..',;;;::;;;;;,'.
...''''.''''',,;;;;;;;,;llloooddoolllc:,,,,,;;;,'..'..'dNWNNWNWWx.........................oNWWWWWWWWWWWWWWWNNNWWNNWWXk;....................................................'''..''....'...'''','''''''''
,'...'''..'''..',,;;,,';ccllllcc:;;;;,;;;;;;,,,,'''.....dNWNNWWWx.........................lNWNWWWWWWWWWWNNWWWWNWWWNk:.............................................'''''...................',;,,,,'',,;;;
;;,''..'''''''''''''''':c:::;;,,,,,,,,;;;;;;,,,;,........dNWWNNWk'...........'o:..........cXWNWNNNNNNNNNWWNWWNNNNk:.........................,cl:'..................'''''...............'''',;:;,'''',,;;
;;;;,''..'''..'''''...';,,,''''.'',,,,;;;,,,,,,;,'.......'xNWWWWk'..........,kNd..........'OWNWWWWWWNWWWWWWNNWNk:.........................;xKNWNKkl'...............'''''...............'''.',,'.''...',;
;;;;;;;,'..''..''.''..''.......''''''.'',,,,''''..........'kNNWW0,.........,ONWk'..........dNWWWWWNNNWWWWWNWXx:.........................'dXWNNWWNWNOc.............',,''................',,'.''..........
;;;;;;;;;''.'''..''....................'',,,'..............'kNWWK;........:0WWWK;..........;0WNWWNNWWWNNWWKd;..........................:0NWWNNWWWNNWNk;...........',,,'.................''''.',,'.......
,,,''''''''..''..'......................',,,'...............'kNWXc.......cKWNNWNo...........oNWNNNWWNNWN0o,...........................lXNNWWNWNNWWNNNWXo...........''''..................',,'',,'.......
'''.....''....'..........................',;;,...............,kNNx......lXNNWNNW0,..........'kWWWWWWWNOc.............................oXWNWWWWWNWWWWWWWWNx'................................,;,.',,......'
'..'''..'''.............................';::::;,'.............,kNO'....lXWNWWNNWNl...........:XWWNKxo:..................''..........oXNWWWWWWWWWWWWWWWWWWx'................................,;,.''.....,;
'.......'......................','....';cllc:;;;,'.............,kK:...cXWNWNWWNWWO,...........xX0o,....................lOo.........lXNNNWWWWWWWWWWWWNNWWWNo.................................,,,''.....''
'''''''''..'..,,,,,,,,,,,,,,,,,;:::;;;:cloolcc:::;;;,,,'',,,'',';kd..cKWWWNNWWWWWNd...........';....................'l0NNo........:XWNWWWWWWWWWWWWWWWWWWWWK:.,,',,,,,,,,,,,,,,,,,,''',,,,''',;;;,,,'',;,
''''..'''..''';:c::::cc::::::ccccllllllllllollllllllllccccccccccclo,:KWNNWWWNWWWNWK:..............................,o0NWWNd.......,ONNWNWWWWWWWWWWWWWWWWWWWNk:ccclllllllllllllcccccc::::::::::;;::;;;;;;;
;;;,'..''..''.;lllllllllllloooodddxkkkkkkkkkkkkkkkkkkkkkkkkxxxxkxxdoONNNNWWWNNWWNWWk'...........................:xKWWNWWNd.......oNNNNWWWWWWWWWWWWWWWWWWNNWKlloooodddxxxkkxxxxddoooooollllllllccccccccc:
,;,,,,..''.''.ckkkOOOOO00000000KKXXNNNXXXXXXXXXXXXXXXXXXXXXXXXXNXXKO0NWWWWNWWWNNWWWNx........................;o0NWNNWWWWWx'.....;KWWWWNNNWWWWWWWWWWWWWWWWNWNkdkOOOOO00KKKXXXKKK00000OOOOkkkkkkkkkkkkkkkk
,;,,;;'''''.'.lKXXXXXXNNNNNNNNNNNWWWWWNNNNNNNNNNNNNNNNNWWWWWWWWWNWN00NWWWNNWWWNWWNWWXo....................'ckXNWWWWWWWWWWO,.....oWWNNWWWWWWWWWWWWWWWWWWWWWWW0xKXXXXXXXXNNNNNNNNNXXXXXXXKKKKKXXXXXXXXXXXX
;,,;;;,'..'...oXNNWNNNNNNNNNNNNNNNNNWWWNNNNNWWWNNWWWWWWWWWWWWNNNNNNKONWWNNNWWWWWWWNNNKc................':xKWWNNWWNWWWWWWWK:....;0WWWWNWWWWWWWWWWWWWWWWWWWWWW0xKWNWNNWWWWWWWWWWWWNNNNNNNNNNNNNNNNNNNNNNNN
;;;;;;;,..'.'.oNWWWWWWWNNNNNXXXXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXXNNN0OXWNWWWWWWWNWWNWNNK:...........,:cxKNWWNNWWWWWWWWWWWWNd....oNWWWWWWWWWWWWWWWWWWWWWWWWWWWXk0NNNNNNNNNNNNNNNNNNNNNNNNWWWWWWWWWWWWWWWNN
;;;;;;;;'.'.'.lNWWNNWWWWNNNNNNNWWWWWWNNNNNNNNNNNNNNNNNNNNNNNNNNNXXN0kXWNWWWWWWWNWWWWWNWKc......';okXNWWNNWWWWWWWWWWWWWWWWW0,..,OWWWWWWWWWWWWWWWWWWWWWWWWWWWWXO0NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWWWNN
;;;;;;;;,'.'''dNNNNNNNNNNNNNNNNWWWWWWWWWWWWWWWWNNNNNNNNNNNNNNNNXXXNOxXWNWWWWWWWWWWWNWWWWXd::ldOKXWWWWWWNNNNNWWWNWWWWWWWWWWNo..cXWWWWWWWWWWWWWWWWWWWWWWWWWWWWNOONNNNNNNNNNNNNNNNNNNNXXXXXXXXXXXXXXNNNNNNN
;;;;;;;;;,..',kXNNNNXXXNNNNNNNNNNNNNNNNNNNNWWNNNNNNNNNNNWWWWNNNNXXN0xXWNWWWWWWWWWWNWWNNNNWNNWWWNNWWWWWWNNNNWWWNNWWWWWWWWNWWO'.dNWNNNWWWWWWWWWWWWWWWWWWWWWNWWNOkNWNNNNNNNWWWNNNNNNNNNNNNXXXXXXXXXXXXNNNNN

     */


    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            costumizeDesing();
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void costumizeDesing() 
        {
            PanelSubMenuFiltros.Visible = false;
            PanelSubMenuDeteccion.Visible = false;
        }

        private void hideSubMenu() 
        {
            if (PanelSubMenuFiltros.Visible == true) 
            {
                PanelSubMenuFiltros.Visible = false;
            }
            if (PanelSubMenuDeteccion.Visible == true)
            {
                PanelSubMenuDeteccion.Visible = false;
            }
        }

        private void showSubMenu(Panel Submenu) 
        {
            if(Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuFiltros);
        }

        private void btnDeteccion_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuDeteccion);
        }

        private Form ActiveForm = null;
        private void ShowForm(Form childForm) 
        {
            if (ActiveForm != null) 
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(childForm);
            PanelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnImgFiltro_Click(object sender, EventArgs e)
        {
            //Code...
            ShowForm(new Imagenes());
            hideSubMenu();
        }

        private void btnVideoFIltro_Click(object sender, EventArgs e)
        {
            //Code...
            ShowForm(new Videos());
            hideSubMenu();
        }

        private void btnDeteccionP_Click(object sender, EventArgs e)
        {
            //Code...
            ShowForm(new CapturaMovimiento());
            hideSubMenu();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Maximizado = false;
        private void pictureMaximize_Click(object sender, EventArgs e)
        {
            if (Maximizado == false) 
            {
                this.WindowState = FormWindowState.Maximized;
                Maximizado = true;
                pictureMaximize.Image = Properties.Resources.icons8_restore_window_20;
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;
                Maximizado = false;
                pictureMaximize.Image = Properties.Resources.icons8_maximize_window_20;
            }
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFiltros_MouseHover(object sender, EventArgs e)
        {
            btnFiltros.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnFiltros_MouseLeave(object sender, EventArgs e)
        {
            btnFiltros.ResetBackColor();
        }

        private void btnDeteccion_MouseHover(object sender, EventArgs e)
        {
            btnDeteccion.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnDeteccion_MouseLeave(object sender, EventArgs e)
        {
            btnDeteccion.ResetBackColor();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ResetBackColor();
        }
    }
}
