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

        public void Willkommen()

        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n  _____                          ____    ___  \r\n | ____|___ ___  ___ _ __  ___  |___ \\  / _ \\ \r\n |  _| / __/ __|/ _ \\ '_ \\/ __|   __) || | | |\r\n | |___\\__ \\__ \\  __/ | | \\__ \\  / __/ | |_| |\r\n |_____|___/___/\\___|_| |_|___/ |_____(_)___/ \r\n                                              \r\n");
        }

        public void Essen()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n                _....----\"\"\"----...._\r\n             .-'  o    o    o    o   '-.\r\n            /  o    o    o         o    \\  \r\n         __/__o___o_ _ o___ _ o_ o_ _ _o_\\__\r\n        /                                   \\\r\n        \\___________________________________/\r\n          \\~`-`.__.`-~`._.~`-`~.-~.__.~`-`/\r\n           \\                             /\r\n            `-._______________________.-'\r\n");
        }
        public void Pizza()
        {
            Console.WriteLine("    _....._\r\n    _.:`.--|--.`:._\r\n  .: .'\\o  | o /'. '.\r\n // '.  \\ o|  /  o '.\\\r\n//'._o'. \\ |o/ o_.-'o\\\\\r\n|| o '-.'.\\|/.-' o   ||\r\n||--o--o-->|");
        }
    }
}
