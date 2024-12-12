using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Menue
{
    internal class Hauptmenue
    {
        Random random = new Random();
        public string name;
        public Hauptmenue()
        {
            
        }

        public Hauptmenue(string name)
        { 
            this.name = name; 
        }

        public Hauptmenue(Random random)
        { 
            this.random = random; 
        }

        public void printMenue()
        {
            Console.WriteLine("1.Laender");
            Console.WriteLine("2 Vorspeisen");
            Console.WriteLine("3 Hauptspeisen");
            Console.WriteLine("4. Beilagen");
            Console.WriteLine("5. Dips");

            Console.WriteLine("Waehle eine Option");

            bool tryParse = int.TryParse(Console.ReadLine(), out int menueOption);

            if (tryParse)
            {
                Console.WriteLine(menueOption);

                if (menueOption == 1)
                {
                    Laender();
                }
                else if (menueOption == 2)
                {
                    Vorspeise();
                }
                else if (menueOption == 3)
                {
                    Hauptspeise();
                }
                else if (menueOption == 4)
                {
                    Beilagen();
                }
                else if (menueOption == 5)
                {
                    Dips();
                }
                ZurueckOption();
            }
            else
            {
                Console.WriteLine("Inkorrekte Eingabe");
                Console.WriteLine("Drücke enter und versuche es nochmal");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void ZurueckOption()
        {
            Console.WriteLine("Zurueck ins Hauptmenue");
            Console.ReadLine();
            Console.Clear();
            printMenue();
        }

        public void Begruessung()
        {
            Console.WriteLine("Willkommen");
            Console.WriteLine();
            Console.WriteLine("Hallo, wie ist dein Name?");
            name = Console.ReadLine();
            Console.WriteLine($"Willkommen {name}");
        }

        public void Laender() //Auswahl1
        {
            var land = new List<string> { "Land1", "Land2", "Land3", "Land4" };
            foreach (var l in land)
            {
                Console.WriteLine(l);
            }
            int index = random.Next(land.Count);
            Console.WriteLine("Deine Wahl fällt auf " + land[index]);
        }

        public void Hauptmenueauswahl()
        {
            var hauptmenue = new List<string> { "Vorspeise", "Hauptspeise", "Beilagen", "Dips" };
            int index = random.Next(hauptmenue.Count);

            Console.WriteLine("Deine Wahl fällt auf " + hauptmenue[index]);
            

        }
        public void Vorspeise()
        {
            var vorspeisen = new List<string> { "Vorspeise1", "Vorspeise2", "Vorspeise3", "Vorspeise4" };
            int index = random.Next(vorspeisen.Count);

            Console.WriteLine("Deine Wahl fällt auf " + vorspeisen[index]);
        }
        public void Hauptspeise()
        {
            var hauptspeisen = new List<string> { "Hauptspeise1", "Hauptspeise2", "Hauptspeise3", "Hauptspeise4" };
            int index = random.Next(hauptspeisen.Count);

            Console.WriteLine("Deine Wahl fällt auf " + hauptspeisen[index]);
        }
        public void Beilagen()
        {
            var beilagen = new List<string> { "Beilage1", "Beilage2", "Beilage3", "Beilage4" };
            int index = random.Next(beilagen.Count);

            Console.WriteLine("Deine Wahl fällt auf " + beilagen[index]);
        }
        public void Dips()
        {
            var dips = new List<string> { "Dip1", "Dip2", "Dip3", "Dip4" };
            int index = random.Next(dips.Count);

            Console.WriteLine("Deine Wahl fällt auf " + dips.Count);
        }
    }
}
