using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenueGenerieren
{
    internal class Essen
    {
        public Essen()
        {
            string[] land;
            string[] hauptMenue;
            string[] vorSpeise;
            string[] hauptSpeise;
            string[] sides;
            string[] dips;
            int[] price;
        }

        public void Begruessung()
        {
            Console.WriteLine("Wie ist dein Name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hallo {name}! Moechtest du dein Menue erstellen?");
        }

        public void Entscheidung()
        { 

        }
    }
}
