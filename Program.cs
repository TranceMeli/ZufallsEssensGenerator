using System;
using System.Reflection.Metadata.Ecma335;
using MenueGenerieren;

namespace MenueGenerieren
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string Menue = "";
            string userAntwort = "";
            string antwort = "";

            Random random = new Random();

            string[] land = new string[4];
            land[0] = "Land 1";
            land[1] = "Land 2";
            land[2] = "Land 3";
            land[3] = "Land 4";

            string[] hauptMenue = new string[4];
            hauptMenue[0] = "Vorspeise";
            hauptMenue[1] = "Hauptspeise";
            hauptMenue[2] = "Sides";
            hauptMenue[3] = "Dips";

            string[] vorSpeise = new string[4];
            vorSpeise[0] = "Vorspeise 1";
            vorSpeise[1] = "Vorspeise 2";
            vorSpeise[2] = "Vorspeise 3";
            vorSpeise[3] = "Vorspeise 4";

            string[] hauptSpeise = new string[4];
            hauptSpeise[0] = "Hauptspeise 1";
            hauptSpeise[1] = "Hauptspeise 2";
            hauptSpeise[2] = "Hauptspeise 3";
            hauptSpeise[3] = "Hauptspeise 4";

            Essen essen = new Essen();
       
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("Option 3");
            Console.WriteLine("Option 4");
            string hauptMenueWahl = Console.ReadLine();

            switch (hauptMenueWahl)
            {
                case "1":
                    Console.WriteLine("Du hast Option 1 gewählt");
                    Console.WriteLine("Option 1 (Ja/Nein)");
                    antwort = Console.ReadLine().ToUpper();
                    if (antwort == "J" || antwort == "JA")
                    {
                        int vorSpeisenIndex = random.Next(vorSpeise.Length);
                        Console.WriteLine($"Du hast folgende Option gewählt: Vorspeise {vorSpeise[vorSpeisenIndex]}");
                    }
                    break;
                case "2":
                    Console.WriteLine("Du hast Option 2 gewählt");
                    Console.WriteLine("Option 2 (Ja/Nein)");
                    antwort = Console.ReadLine().ToUpper();
                    if (antwort == "J" || antwort == "JA")
                    {
                        int hauptSpeisenIndex = random.Next(hauptSpeise.Length);
                        Console.WriteLine($"Du hast folgende Option gewählt: Hauptspeise {hauptSpeise[hauptSpeisenIndex]}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Du hast Option 3 gewählt");
                    break;
                case "4":
                    Console.WriteLine("Du hast Option 4 gewählt");
                    break;
                default:
                    Console.WriteLine("...");
                    break;
            }
           
        }
    }
}
