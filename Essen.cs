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
    public class Essen
    {
        public List<Essen> essen;
        public List<Warenkorb> warenkorb;

        Random random = new Random();
        public string name;
        public string Auswahl { get; set; }
        public decimal Preis { get; set; }
        public string userEingabe {  get; set; }

        public override string ToString()
        {
            return $" {Auswahl} {Preis}";
        }
        public Essen()
        {

        }
        public Essen(string name)
        {
            this.name = name;
        }

        public Essen(Random random)
        {
            this.random = random;
        }
    }
    public class Vorspeise : Essen
    {

        public Vorspeise()
        {

        }

        public void Vorspeisenauswahl()
        {
            List<Vorspeise> meineVorspeise = new List<Vorspeise>();
            {
                meineVorspeise.Add(new Vorspeise() { Preis = 11.99m, Auswahl = "Vorspeise 1" });
                meineVorspeise.Add(new Vorspeise() { Preis = 11.99m, Auswahl = "Vorspeise 1" });
                meineVorspeise.Add(new Vorspeise() { Preis = 11.99m, Auswahl = "Vorspeise 1" });
                meineVorspeise.Add(new Vorspeise() { Preis = 11.99m, Auswahl = "Vorspeise 1" });
            };

            Random random = new Random();
            int index = random.Next(meineVorspeise.Count);
            Console.WriteLine(meineVorspeise[index]);
        }
    }

    public class Beilagen : Essen
    {
        List<Beilagen> meineBeilagen = new List<Beilagen>();

        public Beilagen()
        {

        }

        public void Beilagenauswahl()
        {
            Random random = new Random();

            meineBeilagen.Add(new Beilagen() { Preis = 12.99m, Auswahl = "Beilage 1" });
            meineBeilagen.Add(new Beilagen() { Preis = 13.99m, Auswahl = "Beilage 2" });
            meineBeilagen.Add(new Beilagen() { Preis = 7.99m, Auswahl = "Beilage 3" });
            meineBeilagen.Add(new Beilagen() { Preis = 8.99m, Auswahl = "Beilage 4" });

            int index = random.Next(meineBeilagen.Count);
            Console.WriteLine(meineBeilagen[index]);    
        }
    }

    public class Hauptspeise : Essen
    {
        List<Hauptspeise> meineHauptspeise = new List<Hauptspeise>();
        public Hauptspeise()
        {

        }
        public void Hauptspeisenauswahl()
        {
            Random random = new Random();

            meineHauptspeise.Add(new Hauptspeise() { Preis = 16.99m, Auswahl = "Hauptspeise 1" });
            meineHauptspeise.Add(new Hauptspeise() { Preis = 19.99m, Auswahl = "Hauptspeise 2" });
            meineHauptspeise.Add(new Hauptspeise() { Preis = 22.99m, Auswahl = "Hauptspeise 3" });
            meineHauptspeise.Add(new Hauptspeise() { Preis = 18.99m, Auswahl = "Hauptspeise 4" });

            int index = random.Next(meineHauptspeise.Count);
            Console.WriteLine(meineHauptspeise[index]);
        }
    }
    public class Dips : Essen
    {
        List<Dips> meineDips = new List<Dips>();

        public Dips()
        {

        }

        public void Dipauswahl()
        {
            Random random = new Random();

            meineDips.Add(new Dips() { Preis = 2.99m, Auswahl = "Dip 1" });
            meineDips.Add(new Dips() { Preis = 1.99m, Auswahl = "Dip 2" });
            meineDips.Add(new Dips() { Preis = 3.99m, Auswahl = "Dip 3" });
            meineDips.Add(new Dips() { Preis = 0.99m, Auswahl = "Dip 4" });

            int index = random.Next(meineDips.Count);
            Console.WriteLine(meineDips[index]);
        }
    }
    public class MenueStruktur : Essen
    {

        public MenueStruktur()
        {

        }

        public void MenueZufall()
        {
            Vorspeise vorspeise = new Vorspeise();
            Hauptspeise hauptspeise = new Hauptspeise();
            Beilagen beilagen = new Beilagen();
            Dips dips = new Dips();
            vorspeise.Vorspeisenauswahl();
            hauptspeise.Hauptspeisenauswahl();
            beilagen.Beilagenauswahl();
            dips.Dipauswahl();
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

        public void Hauptmenueauswahl2()
        {
            Random random = new Random();
            var hauptmenue = new List<string> { "Vorspeise", "Hauptspeise", "Beilagen", "Dips" };
            int index = random.Next(hauptmenue.Count);

            Console.WriteLine("Deine Wahl fällt auf " + hauptmenue[index]);


        }
        public void Vorspeise2()
        {
            Random random = new Random();
            var vorspeisen = new List<string> { "Vorspeise1", "Vorspeise2", "Vorspeise3", "Vorspeise4" };
            int index = random.Next(vorspeisen.Count);

            Console.WriteLine("Deine Wahl fällt auf " + vorspeisen[index]);
        }
        public void Hauptspeise2()
        {
            Random random = new Random();
            var hauptspeisen = new List<string> { "Hauptspeise1", "Hauptspeise2", "Hauptspeise3", "Hauptspeise4" };
            int index = random.Next(hauptspeisen.Count);

            Console.WriteLine("Deine Wahl fällt auf " + hauptspeisen[index]);
        }
        public void Beilagen2()
        {
            Random random = new Random();
            var beilagen = new List<string> { "Beilage1", "Beilage2", "Beilage3", "Beilage4" };
            int index = random.Next(beilagen.Count);

            Console.WriteLine("Deine Wahl fällt auf " + beilagen[index]);
        }
        public void Dips2()
        {
            Random random = new Random();
            var dips = new List<string> { "Dip1", "Dip2", "Dip3", "Dip4" };
            int index = random.Next(dips.Count);

            Console.WriteLine("Deine Wahl fällt auf " + dips[index]);
        }
        private void hinzufuegenWarenkorb()
        {
            Console.WriteLine("Hinzufuegen? Enter fuer JA und Esc fue NEIN um etwas anderes zu waehlen");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {

                Console.WriteLine("Deine Auswahl wurde in den Warenkorb gelegt.");

            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {

                Console.WriteLine("Vielleicht etwas anderes?");
            }
            else
            {
                HauptMenue();
            }
        }
        public void HauptMenue()
        {
            Random random = new Random();
            Zufallsmenue zufallsmenue = new Zufallsmenue();
            Zufallsmenue zufallsmenue1 = new Zufallsmenue();
            Warenkorb warenkorb = new Warenkorb();
            AsciiArt asciiArt2 = new AsciiArt();

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
                Console.WriteLine("Navigiere mit Pfeiltasten 'Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
                Console.WriteLine($"{(option == 1 ? color : "")}Nimm mich an der Hand!\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Zufall nach Land\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Voelliger Zufall\u001b[0m");
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
                                Console.WriteLine("Land 3 Zufall");

                            }
                            else
                            {
                                Console.WriteLine("Land 4 Zufall");
                            }
                        }
                        else if (option == 3)
                        {
                            zufallsmenue1.Zufall();
                            hinzufuegenWarenkorb();

                        }
                        else if (option == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            asciiArt2.Pizza();
                            Console.ResetColor();
                            Console.WriteLine("Diese Produkte wurden in den Warenkorb gelegt...");
                            
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
            WahlMenue();
        }
        public void WahlMenue()
        {
            Vorspeise vorspeise = new Vorspeise();
            Hauptspeise hauptspeise = new Hauptspeise();
            Beilagen beilagen = new Beilagen();
            Dips dips = new Dips();


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
                Console.WriteLine("Navigiere mit Pfeiltasten 'Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
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
                            vorspeise.Vorspeisenauswahl();
                            //Vorspeise2();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 2)
                        {
                            hauptspeise.Hauptspeisenauswahl();
                            //Hauptmenueauswahl2();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 3)
                        {
                            hauptspeise.Hauptspeisenauswahl();
                            Beilagen2();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 4)
                        {
                            dips.Dipauswahl();
                            //Dips2();
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


