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
           
            Zufallsmenue zufallsmenue1 = new Zufallsmenue();
            Zufallsmenue zufallsmenue2 = new Zufallsmenue();
            AsciiArt asciiArt1 = new AsciiArt();
            Warenkorb warenkorb1 = new Warenkorb();
            //Essen essen = new Essen();
            //Essen essen2 = new Essen();
            Dips dips = new Dips();
            MenueStruktur menueStruktur = new MenueStruktur();
            
            asciiArt1.Willkommen();
            asciiArt1.Essen();
            menueStruktur.HauptMenue();

            //ConsoleKeyInfo cki;

            //Console.WriteLine("Druecke Esc um zu verlassen");
            //do
            //{
            //    hauptmenue2.EnterMenue();
            //    cki = Console.ReadKey();


            //} while (cki.Key != ConsoleKey.Escape);    
        }
    }
}
