using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using Menue;

namespace Menue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userWahl = "";

            Hauptmenue hauptmenue1 = new Hauptmenue();
            Hauptmenue hauptmenue2 = new Hauptmenue();
            Zufallsmenue zufallsmenue1 = new Zufallsmenue();

            Console.WriteLine("Nimm mich an der Hand!");
            Console.WriteLine("Chaos, Chaos ich will Chaos");
            userWahl = Console.ReadLine();

            if (userWahl == "1")
            {
                hauptmenue1.printMenue();
            }
            else
            {
                zufallsmenue1.Zufall();
            }
        }
    }
}
