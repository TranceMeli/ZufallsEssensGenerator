using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menue
{
    internal class AsciiArt
    {
        public AsciiArt() 
        {
            
        }

        public void WillkommenAscii()

        {
            string willkommen = "\r\n _______  _______  _______  _______  _        _______    _______     _______ \r\n(  ____ \\(  ____ \\(  ____ \\(  ____ \\( (    /|(  ____ \\  / ___   )   (  __   )\r\n| (    \\/| (    \\/| (    \\/| (    \\/|  \\  ( || (    \\/  \\/   )  |   | (  )  |\r\n| (__    | (_____ | (_____ | (__    |   \\ | || (_____       /   )   | | /   |\r\n|  __)   (_____  )(_____  )|  __)   | (\\ \\) |(_____  )    _/   /    | (/ /) |\r\n| (            ) |      ) || (      | | \\   |      ) |   /   _/     |   / | |\r\n| (____/\\/\\____) |/\\____) || (____/\\| )  \\  |/\\____) |  (   (__/\\ _ |  (__) |\r\n(_______/\\_______)\\_______)(_______/|/    )_)\\_______)  \\_______/(_)(_______)\r\n                                                                             \r\n";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(willkommen);
            Console.ResetColor();
        }

        public void BurgerAscii()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\n                _....----\"\"\"----...._\r\n             .-'  o    o    o    o   '-.\r\n            /  o    o    o         o    \\  \r\n         __/__o___o_ _ o___ _ o_ o_ _ _o_\\__\r\n        /                                   \\\r\n        \\___________________________________/\r\n          \\~`-`.__.`-~`._.~`-`~.-~.__.~`-`/\r\n           \\                             /\r\n            `-._______________________.-'\r\n");
            Console.WriteLine();
        }
        public void Pizza()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            string pizza = "    _....._\r\n    _.:`.--|--.`:._\r\n  .: .'\\o  | o /'. '.\r\n // '.  \\ o|  /  o '.\\\r\n//'._o'. \\ |o/ o_.-'o\\\\\r\n|| o '-.'.\\|/.-' o   ||\r\n||--o--o-->|";  
            Console.Write(pizza);
        }
        public void Book()
        {
            string book = "   __________________   __________________\r\n.-/|                  \\ /                  |\\-.\r\n||||                   |                   ||||\r\n||||                   |       ~~*~~       ||||\r\n||||    --==*==--      |                   ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||                   |     --==*==--     ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||__________________ | __________________||||\r\n||/===================\\|/===================\\||\r\n`--------------------~___~-------------------''";
            Console.WriteLine(book);
        }

        public void Divider()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string divider = ":*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:.";
            Console.WriteLine(divider);
        }
    }
}
