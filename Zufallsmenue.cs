using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menue
{
    internal class Zufallsmenue
    {
        Random random = new Random();
        public Zufallsmenue() 
        {
            
        }

        public void Zufall()
        {
            var vorspeise = new List<string> { "Vorspeise1", "Vorspeise2", "Vorspeise3", "Vorspeise4" };
            int index = random.Next(vorspeise.Count);

            var hauptspeise = new List<string> { "Hauptspeise1, Hauptspeise2", "Hauptspeise3", "Hauptspeise4" };
            int index2 = random.Next(hauptspeise.Count);

            var beilagen = new List<string> { "Beilage1", "Beilage2", "Beilage3", "Beilage4" };
            int index3 = random.Next(beilagen.Count);

            var dips = new List<string> { "Dip1", "Dip2", "Dip3", "Dip4" };
            int index4 = random.Next(dips.Count);

            var deineAuswahl = vorspeise[index] + " " + (hauptspeise[index2]) + " " + (beilagen[index3]) + " " + (dips[index4]);

            Console.WriteLine($"Deine Auswahl.. oh nein der Zufall will es so lautet: {deineAuswahl}");

            

        }
    }
}
