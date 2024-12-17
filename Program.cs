using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using Menue;

namespace Menue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            AsciiArt asciiArt = new AsciiArt();
            Essen essen = new Essen();
            MenueStruktur menueStruktur = new MenueStruktur();

            asciiArt.WillkommenAscii();
            menueStruktur.Begruessung();
            menueStruktur.Sprueche();
            Console.WriteLine();
            menueStruktur.HauptMenue();  
        }
    }
}
