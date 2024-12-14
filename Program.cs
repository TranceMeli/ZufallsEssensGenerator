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
            Hauptmenue hauptmenue1 = new Hauptmenue();
            Hauptmenue hauptmenue2 = new Hauptmenue();
            Hauptmenue hauptmenue3 = new Hauptmenue();
            Zufallsmenue zufallsmenue1 = new Zufallsmenue();
            Zufallsmenue zufallsmenue2 = new Zufallsmenue();
            AsciiArt asciiArt1 = new AsciiArt();
            Warenkorb warenkorb1 = new Warenkorb();
            Produkt produkt1 = new Produkt { Name = "Pizza1", Preis = 19.99M};  
            Produkt produkt2 = new Produkt { Name = "Pizza2", Preis = 22.99M};
            Produkt produkt3 = new Produkt { Name = "Pizza3", Preis = 21.99M};

            //warenkorb1.hinzufuegenProdukt(produkt1);
            //warenkorb1.hinzufuegenProdukt(produkt2);
            //warenkorb1.hinzufuegenProdukt(produkt3);

            //decimal total = warenkorb1.WarenkorbLeeren();
            //Console.WriteLine("Total: $" + total);

            //warenkorb1.entfernenProdukt(produkt2);

            //total = warenkorb1.WarenkorbLeeren();
            //Console.WriteLine("Updated Total: $" + total);

            asciiArt1.Willkommen();
            asciiArt1.Essen();
            //hauptmenue1.Begruessung();
            hauptmenue1.HauptMenue();


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
