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

        public void ZufallDeutsch()
        {
            var deutschVorspeise = new List<string> { "DeutschVorspeise1", "DeutschVorspeise2", "DeutschVorspeise3", "DeutschVorspeise4" };
            int index = random.Next(deutschVorspeise.Count);
            var deutschHauptspeise = new List<string> { "DeutschHauptspeise1", "DeutschHauptspeise2", "DeutschHauptspeise3", "DeutschHauptspeise4" };
            int index2 = random.Next(deutschHauptspeise.Count);
            var deutschBeilagen = new List<string> { "DeutschBeilagen1", "DeutschBeilagen2", "DeutschBeilagen3", "DeutschBeilagen4" };
            int index3 = random.Next(deutschBeilagen.Count);
            var deutschDips = new List<string> { "DeutschDips1", "DeutschDips2", "DeutschDips3", "DeutschDips4" };
            int index4 = random.Next(deutschDips.Count);

            var deutschAuswahl = deutschVorspeise[index] + " " + (deutschVorspeise[index2] + " " + (deutschBeilagen[index3] + " " + (deutschDips[index4])));

            Console.WriteLine($"Deine Auswahl.. oh nein der Zufall will es so lautet: {deutschAuswahl}");

        }

        public void ZufallItalienisch()
        {
            var italienischVorspeise = new List<string> { "ItalienischVorspeise1", "ItalienischVorspeise2", "ItalienischVorspeise3", "ItalienischVorspeise4" };
            int index = random.Next(italienischVorspeise.Count);
            var italienischHauptspeise = new List<string> { "ItalienischHauptspeise1", "ItalienischHauptspeise2", "ItalienischHauptspeise3", "ItalienischHauptspeise4" };
            int index2 = random.Next(italienischHauptspeise.Count);
            var italienischBeilagen = new List<string> { "ItalienischBeilagen1", "ItalienischBeilagen2", "ItalienischBeilagen3", "ItalienischBeilagen4" };
            int index3 = random.Next(italienischBeilagen.Count);
            var italienischDips = new List<string> { "ItalienischDips1", "ItalienischDips2", "ItalienischDips3", "ItalienischDips4" };
            int index4 = random.Next(italienischDips.Count);

            var italienischAuswahl = italienischVorspeise[index] + " " + (italienischVorspeise[index2] + " " + (italienischBeilagen[index3] + " " + (italienischDips[index4])));

            Console.WriteLine($"Deine Auswahl.. oh nein der Zufall will es so lautet: {italienischAuswahl}");

        }

        public void ZufallTuerkisch()
        {

        }
        public void ZufallIndisch()
        {

        }

    }
}
