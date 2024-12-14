using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Menue
{
    internal class Hauptmenue
    {
        Warenkorb warenkorb = new Warenkorb();

        Random random = new Random();
        public string name;
        public string Name { get { return name; } }
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

        public void ZurueckOption()
        {
            Console.WriteLine("Zurueck ins Hauptmenue");
            Console.ReadLine();
            Console.Clear();
        }

        public void Begruessung()
        {
            Console.WriteLine("Hallo, wie ist dein Name?");
            name = Console.ReadLine();
            Console.WriteLine($"Willkommen {name}");
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
        private void hinzufuegenWarenkorb()
        {
  
            Console.WriteLine("Hinzufuegen?");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                
                Console.WriteLine("Deine Auswahl wurde in den Warenkorb gelegt");

            }
            else
            {
                HauptMenue();
            }
        }
        public void HauptMenue()
        {
            Zufallsmenue zufallsmenue = new Zufallsmenue();
            Zufallsmenue zufallsmenue1 = new Zufallsmenue();
            Warenkorb warenkorb = new Warenkorb();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ResetColor();
            Console.WriteLine();

            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[32m";
            Console.CursorVisible = false;
            int landOption;
            landOption = random.Next(1, 5);

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine("Navigiere mit Pfeiltasten Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
                Console.WriteLine($"{(option == 1 ? color : "")}Nimm mich an der Hand!\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Zufall nach Land\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Völliger Zufall\u001b[0m");
                Console.WriteLine($"{(option == 4 ? color : "")}Warenkorb\u001b[0m");
                Console.WriteLine($"{(option == 5 ? color : "")}Exit\u001b[0m");

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 5 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 5 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        if (option == 1)
                        {
                            WahlMenue();
                        }
                        else if (option == 2)
                        {

                            if (landOption == 1)
                            {
                                zufallsmenue.ZufallDeutsch();
                                hinzufuegenWarenkorb();
                                
                            }
                            else if (landOption == 2)
                            {
                                zufallsmenue1.ZufallItalienisch();
                                hinzufuegenWarenkorb();
                                
                            }
                            else if (landOption == 3)
                            {
                                Console.WriteLine("Test3");

                            }
                            else
                            {
                                Console.WriteLine("Test4");
                            }

                        }
                        else if (option == 3)
                        {
                            zufallsmenue1.Zufall();
                            hinzufuegenWarenkorb();
                            
                        }
                        else if (option == 4)
                        {
                            Console.WriteLine("Diese Produkte wurden in den Warenkorb gelegt");
                        }
                        else
                        {
                            Console.WriteLine("Vielleicht bis bald :)");
                        }

                        break;

                        //string[] options = new string[]
                        //{
                        //    "Nimm mich an der Hand",
                        //    "Zufall nach Land",
                        //    "Chaos"
                        //};

                        //for (int i = 0; i < options.Length; i++)
                        //{
                        //    Console.WriteLine(i + 1 + ". " + options[i]);
                        //}
                }
            }
        }
        public void WahlMenue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Willkommen!");
            Console.ResetColor();

            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[32m";
            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine("Navigiere mit Pfeiltasten Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
                Console.WriteLine($"{(option == 1 ? color : "")}Vorspeisen!\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Hauptspeisen\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Beilagen\u001b[0m");
                Console.WriteLine($"{(option == 4 ? color : "")}Dips\u001b[0m");
                Console.WriteLine($"{(option == 5 ? color : "")}Hauptmenue\u001b[0m");
             
                Console.WriteLine();

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 5 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 5 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        if (option == 1)
                        {
                            Vorspeise();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 2)
                        {
                            Hauptspeise();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 3)
                        {
                            Beilagen();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 4)
                        {
                            Dips();
                            hinzufuegenWarenkorb();
                        }
                        else
                        {
                            HauptMenue();
                        }
                        break;
                }  
            }
            WahlMenue();
        }
    }
}
