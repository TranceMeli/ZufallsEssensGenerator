using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
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


        Random random = new Random();
        public string name;
        public string Auswahl { get; set; }
        public decimal Preis { get; set; }
        public string userEingabe { get; set; }
        public string sprueche { get; }

        public override string ToString()
        {
            return $"{Auswahl}, {Preis}";
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
                meineVorspeise.Add(new Vorspeise() { Preis = 12.99m, Auswahl = "Vorspeise 1" });
                meineVorspeise.Add(new Vorspeise() { Preis = 11.99m, Auswahl = "Vorspeise 2" });
                meineVorspeise.Add(new Vorspeise() { Preis = 10.99m, Auswahl = "Vorspeise 3" });
                meineVorspeise.Add(new Vorspeise() { Preis = 9.99m, Auswahl = "Vorspeise 4" });
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
        AsciiArt ascii = new AsciiArt();    

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
            Console.WriteLine("Zurück ins Hauptmenü");
            Console.ReadLine();
            Console.Clear();
        }

        public void Begruessung()
        {
            Console.WriteLine("Hallo, wie ist dein Name?");
            name = Console.ReadLine();
            ascii.Trennlinie();
            Console.ResetColor();
            Console.WriteLine($"Willkommen {name} bei Essen 2.0! Du kannst dir dein Menü nach Zufall zusammenstellen.\nSchritt für Schritt um dein Menü nach Wunsch.. ähm Zufall zusammenzustellen.\nLust auf eine bestimmte Länderküche? Kein Problem!\nWähle alles Zufall für die wildesten Kombinationen!\nSonderfälle wie unerwarteter Verwandtschaftsbesuch.. ;)");
            ascii.Trennlinie();
            Console.ResetColor();
            Console.WriteLine();
        }

        private void hinzufuegenWarenkorb()
        {
            Console.WriteLine();
            Console.WriteLine("Hinzufügen? Enter für JA und Esc für NEIN um etwas anderes zu wählen\n");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {

                Console.WriteLine("Deine Auswahl wurde in den Warenkorb gelegt.\n");

            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Vielleicht etwas anderes?\n");
            }
            else
            {
                HauptMenue();
            }
        }
        public void HauptMenue()
        {
            Random random = new Random();
            AsciiArt asciiArt = new AsciiArt();
            ZufallLand zufallLand = new ZufallLand();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();
            Sprueche();
            Console.WriteLine();

            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[42m";
            Console.CursorVisible = false;
            int landOption;
            landOption = random.Next(1, 5);

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine($"{(option == 1 ? color : "")}Nimm mich an der Hand!\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Zufall nach Land\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Völliger Zufall\u001b[0m");
                Console.WriteLine($"{(option == 4 ? color : "")}Spezielle Optionen\u001b[0m");
                Console.WriteLine($"{(option == 5 ? color : "")}Warenkorb\u001b[0m");
                Console.WriteLine($"{(option == 6 ? color : "")}Exit\u001b[0m");
                Console.WriteLine();

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 6 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 6 : option - 1);
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
                                zufallLand.ZufallLand1();
                                hinzufuegenWarenkorb();
                            }
                            else if (landOption == 2)
                            {
                                zufallLand.ZufallLand2();
                                hinzufuegenWarenkorb();
                            }
                            else if (landOption == 3)
                            {
                                zufallLand.ZufallLand3();
                                hinzufuegenWarenkorb();
                            }
                            else
                            {
                                zufallLand.ZufallLand4();
                                hinzufuegenWarenkorb();
                            }
                        HauptMenue();
                        }
                        
                        else if (option == 3)
                        {
                            Console.WriteLine("Deine Auswahl, oh nein der Zufall will es so fällt auf: \n");
                            MenueZufall();
                            hinzufuegenWarenkorb();

                        }
                        else if (option == 4)
                        {
                            SpezielleOptionen();
  
                        }
                        else if (option == 5)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            asciiArt.Pizza();
                            Console.ResetColor();
                            Console.WriteLine("\nDiese Produkte wurden in den Warenkorb gelegt...\n");
                            string[] produkte = new string[]
                            {
                                "Hauptspeise , 20,99 Euro",
                                "Beilage , 11.99 Euro",
                                "Dip , 5.99 Euro",
                            };
                            for (int i = 0; i < produkte.Length; i++)
                            {
                                Console.WriteLine(i + 1 + "."  + produkte[i]);
                            }
                            
                            Console.WriteLine("Jetzt Bestellen oder Abholen? \n");
                            BestellenAbholen();
                        }
                        else
                        {
                            Console.WriteLine("Vielleicht bis bald :)");
                            ExitProgramm();
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
            HauptMenue();
        }
        public void WahlMenue()
        {
            Vorspeise vorspeise = new Vorspeise();
            Hauptspeise hauptspeise = new Hauptspeise();
            Beilagen beilagen = new Beilagen();
            Dips dips = new Dips();

            Sprueche();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ResetColor();

            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[42m";
            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                //Console.WriteLine("Navigiere mit Pfeiltasten 'Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
                Console.WriteLine($"{(option == 1 ? color : "")}Vorspeisen\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Hauptspeisen\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Beilagen\u001b[0m");
                Console.WriteLine($"{(option == 4 ? color : "")}Dips\u001b[0m");
                Console.WriteLine($"{(option == 5 ? color : "")}Hauptmenü\u001b[0m\n");
                

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
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 2)
                        {
                            hauptspeise.Hauptspeisenauswahl();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 3)
                        {
                            beilagen.Beilagenauswahl();
                            hinzufuegenWarenkorb();
                        }
                        else if (option == 4)
                        {
                            dips.Dipauswahl();
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
        public void SpezielleOptionen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Spezielle Optionen für spezielle Momente");
            Console.ResetColor();
            Console.WriteLine();
            //Console.WriteLine("Spezielle Optionen für spezielle Momente");
            Console.WriteLine();

            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[42m";
            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                //Console.WriteLine("Navigiere mit Pfeiltasten 'Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
                Console.WriteLine($"{(option == 1 ? color : "")}Die besten Menüs.. von euch gewählt.\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Scharf schärfer am schärfsten.\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Hilfe die Verwandtschaft kommt.\u001b[0m");
                Console.WriteLine($"{(option == 4 ? color : "")}Hauptmenü\u001b[0m");
                Console.WriteLine();

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 4 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 4 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        if (option == 1)
                        {
                            Console.WriteLine("Die besten Menüs in monatlicher Abstimmung von euch gewählt! :)\n");
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Kannst du es mit den schärfsten Menüs aufnehmen?\n");
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("Nichts zuhause aber Besuch kündigt sich an! Keine Sorge wir helfen.\n");
                        }
                        else
                        {
                            HauptMenue();
                        }
                        break;
                }
            }
            SpezielleOptionen();
        }
        public void BestellenAbholen()
        {
            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "\u001b[42m";
            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                //Console.WriteLine("Navigiere mit Pfeiltasten 'Oben' und 'Unten' \u001b[32mEnter\u001b[0m fuer die Eingabe.");
                Console.WriteLine($"{(option == 1 ? color : "")}Bestellen\u001b[0m");
                Console.WriteLine($"{(option == 2 ? color : "")}Abholen\u001b[0m");
                Console.WriteLine($"{(option == 3 ? color : "")}Hauptmenü\u001b[0m");
                Console.WriteLine();

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 3 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 3 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        if (option == 1)
                        {
                            if (option == 1 || option == 2 || option == 3)
                            {
                                Console.WriteLine("Vielen Dank für deine Bestellung. :) Dein Essen wird in Kürze zu dir geliefert.\n");
                            }
                            else
                            {
                                Console.WriteLine("Vielleicht etwas anderes\n");
                            }    
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Abholung in der Nähe inklusive Routenplanung.\n");

                            string[] restaurants = new string[]
                            {
                                "Restaurant ..",
                                "Restaurant ..",
                                "Restaurant ..\n"
                            };

                            for (int i = 0; i < restaurants.Length; i++)
                            {
                                Console.WriteLine(i + 1 + ". " + restaurants[i]);
                            }

                                Console.WriteLine("Bestellung für Restaurant 1 in die Wege geleitet.. \nKlicke hier um auf dem schnellsten Weg dorthin zu gelangen.\n");                
                        }
                        else
                        {
                            HauptMenue();
                        }
                        break;
                }
            }
        }
        public void Sprueche()
        {
            Random random = new Random();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            string[] sayings = new string[]
            {
                "Willkommen bei Essen 2.0 :)",
                "Bestelle jetzt und erhalte dein Essen in 30 Minuten!",
                "20 % Rabatt bei Abholung!",
                "Führender Testsieger unter den Lieferservices!",
                "Jetzt neu Lieferung mit Drohne!",
                "Wir sind die Besten.. und ja wir meinen das wirklich so :)",
                "Erste Bestellung 50% Rabatt!",
                "Punkte bei jeder Bestellung sammeln und Rabatt erhalten!"
            };

            int index = random.Next(sayings.Length);
            Console.Write(sayings[index]);
            Console.ResetColor();
            Console.WriteLine();
        }
        public void ExitProgramm()
        {
            Environment.Exit(0);
        }
    }
    public class ZufallLand : Essen
    {
        public ZufallLand()
        {


        }

        public void ZufallLand1()
        {
            List<ZufallLand> Vorspeise = new List<ZufallLand>();
            List<ZufallLand> Hauptspeise = new List<ZufallLand>();
            List<ZufallLand> Beilagen = new List<ZufallLand>();
            List<ZufallLand> Dips = new List<ZufallLand>();
            {
                Vorspeise.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 1, Vorspeise 1" });
                Vorspeise.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 1, Vorspeise 2" });
                Vorspeise.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 1, Vorspeise 3" });
                Vorspeise.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 1, Vorspeise 4" });

                Random random = new Random();
                int index = random.Next(Vorspeise.Count);
                //Console.WriteLine(Vorspeise[index]);

                Hauptspeise.Add(new ZufallLand() { Preis = 20.99m, Auswahl = "Land 1, Hauptspeise 1" });
                Hauptspeise.Add(new ZufallLand() { Preis = 19.99m, Auswahl = "Land 1, Hauptspeise 2" });
                Hauptspeise.Add(new ZufallLand() { Preis = 22.99m, Auswahl = "Land 1, Hauptspeise 3" });
                Hauptspeise.Add(new ZufallLand() { Preis = 23.99m, Auswahl = "Land 1, Hauptspeise 4" });

                int index2 = random.Next(Hauptspeise.Count);
                //Console.WriteLine(Hauptspeise[index]);

                Beilagen.Add(new ZufallLand() { Preis = 12.99m, Auswahl = "Land 1, Beilagen 1" });
                Beilagen.Add(new ZufallLand() { Preis = 13.99m, Auswahl = "Land 1, Beilagen 2" });
                Beilagen.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 1, Beilagen 3" });
                Beilagen.Add(new ZufallLand() { Preis = 14.99m, Auswahl = "Land 1, Beilagen 4" });

                int index3 = random.Next(Beilagen.Count);
                
                Dips.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 1, Dip 1" });
                Dips.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 1, Dip 2" });
                Dips.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 1, Dip 3" });
                Dips.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 1, Dip 4" });

                int index4 = random.Next(Dips.Count);
                //Console.WriteLine(Beilagen[index]);

                //var deineAuswahl = Vorspeise[index] + " " + Hauptspeise[index];
                Console.WriteLine("Deine Wahl fällt auf: \n" + Vorspeise[index] + "\n" + Hauptspeise[index2] + "\n" + Beilagen[index3] + "\n" + Dips[index4]);

            }
        }
        public void ZufallLand2()
        {
            List<ZufallLand> Vorspeise = new List<ZufallLand>();
            List<ZufallLand> Hauptspeise = new List<ZufallLand>();
            List<ZufallLand> Beilagen = new List<ZufallLand>();
            List<ZufallLand> Dips = new List<ZufallLand>();
            {
                Vorspeise.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 2, Vorspeise 1" });
                Vorspeise.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 2, Vorspeise 2" });
                Vorspeise.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 2, Vorspeise 3" });
                Vorspeise.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 2, Vorspeise 4" });

                Random random = new Random();
                int index = random.Next(Vorspeise.Count);
                //Console.WriteLine(Vorspeise[index]);

                Hauptspeise.Add(new ZufallLand() { Preis = 20.99m, Auswahl = "Land 2, Hauptspeise 1" });
                Hauptspeise.Add(new ZufallLand() { Preis = 19.99m, Auswahl = "Land 2, Hauptspeise 2" });
                Hauptspeise.Add(new ZufallLand() { Preis = 22.99m, Auswahl = "Land 2, Hauptspeise 3" });
                Hauptspeise.Add(new ZufallLand() { Preis = 23.99m, Auswahl = "Land 2, Hauptspeise 4" });

                int index2 = random.Next(Hauptspeise.Count);
                //Console.WriteLine(Hauptspeise[index]);

                Beilagen.Add(new ZufallLand() { Preis = 12.99m, Auswahl = "Land 2, Beilagen 1" });
                Beilagen.Add(new ZufallLand() { Preis = 13.99m, Auswahl = "Land 2, Beilagen 2" });
                Beilagen.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 2, Beilagen 3" });
                Beilagen.Add(new ZufallLand() { Preis = 14.99m, Auswahl = "Land 2, Beilagen 4" });

                int index3 = random.Next(Beilagen.Count);

                Dips.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 2, Dip 1" });
                Dips.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 2, Dip 2" });
                Dips.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 2, Dip 3" });
                Dips.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 2, Dip 4" });

                int index4 = random.Next(Dips.Count);
                //Console.WriteLine(Beilagen[index]);

                //var deineAuswahl = Vorspeise[index] + " " + Hauptspeise[index];
                Console.WriteLine("Deine Wahl fällt auf: \n" + Vorspeise[index] + "\n" + Hauptspeise[index2] + "\n" + Beilagen[index3] + "\n" + Dips[index4]);
            }
        }
        public void ZufallLand3()
        {

            List<ZufallLand> Vorspeise = new List<ZufallLand>();
            List<ZufallLand> Hauptspeise = new List<ZufallLand>();
            List<ZufallLand> Beilagen = new List<ZufallLand>();
            List<ZufallLand> Dips = new List<ZufallLand>();
            {
                Vorspeise.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 3, Vorspeise 1" });
                Vorspeise.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 3, Vorspeise 2" });
                Vorspeise.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 3, Vorspeise 3" });
                Vorspeise.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 3, Vorspeise 4" });

                Random random = new Random();
                int index = random.Next(Vorspeise.Count);
                //Console.WriteLine(Vorspeise[index]);

                Hauptspeise.Add(new ZufallLand() { Preis = 20.99m, Auswahl = "Land 3, Hauptspeise 1" });
                Hauptspeise.Add(new ZufallLand() { Preis = 19.99m, Auswahl = "Land 3, Hauptspeise 2" });
                Hauptspeise.Add(new ZufallLand() { Preis = 22.99m, Auswahl = "Land 3, Hauptspeise 3" });
                Hauptspeise.Add(new ZufallLand() { Preis = 23.99m, Auswahl = "Land 3, Hauptspeise 4" });

                int index2 = random.Next(Hauptspeise.Count);
                //Console.WriteLine(Hauptspeise[index]);

                Beilagen.Add(new ZufallLand() { Preis = 12.99m, Auswahl = "Land 3, Beilagen 1" });
                Beilagen.Add(new ZufallLand() { Preis = 13.99m, Auswahl = "Land 3, Beilagen 2" });
                Beilagen.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 3, Beilagen 3" });
                Beilagen.Add(new ZufallLand() { Preis = 14.99m, Auswahl = "Land 3, Beilagen 4" });

                int index3 = random.Next(Beilagen.Count);

                Dips.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 3, Dip 1" });
                Dips.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 3, Dip 2" });
                Dips.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 3, Dip 3" });
                Dips.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 3, Dip 4" });

                int index4 = random.Next(Dips.Count);
                //Console.WriteLine(Beilagen[index]);

                //var deineAuswahl = Vorspeise[index] + " " + Hauptspeise[index];
                Console.WriteLine("Deine Wahl fällt auf: \n" + Vorspeise[index] + "\n" + Hauptspeise[index2] + "\n" + Beilagen[index3] + "\n" + Dips[index4]);

            }
        }
        public void ZufallLand4()
        {

            List<ZufallLand> Vorspeise = new List<ZufallLand>();
            List<ZufallLand> Hauptspeise = new List<ZufallLand>();
            List<ZufallLand> Beilagen = new List<ZufallLand>();
            List<ZufallLand> Dips = new List<ZufallLand>();
            {
                Vorspeise.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 4, Vorspeise 1" });
                Vorspeise.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 4, Vorspeise 2" });
                Vorspeise.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 4, Vorspeise 3" });
                Vorspeise.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 4, Vorspeise 4" });

                Random random = new Random();
                int index = random.Next(Vorspeise.Count);
                //Console.WriteLine(Vorspeise[index]);

                Hauptspeise.Add(new ZufallLand() { Preis = 20.99m, Auswahl = "Land 4, Hauptspeise 1" });
                Hauptspeise.Add(new ZufallLand() { Preis = 19.99m, Auswahl = "Land 4, Hauptspeise 2" });
                Hauptspeise.Add(new ZufallLand() { Preis = 22.99m, Auswahl = "Land 4, Hauptspeise 3" });
                Hauptspeise.Add(new ZufallLand() { Preis = 23.99m, Auswahl = "Land 4, Hauptspeise 4" });

                int index2 = random.Next(Hauptspeise.Count);
                //Console.WriteLine(Hauptspeise[index]);

                Beilagen.Add(new ZufallLand() { Preis = 12.99m, Auswahl = "Land 4, Beilagen 1" });
                Beilagen.Add(new ZufallLand() { Preis = 13.99m, Auswahl = "Land 4, Beilagen 2" });
                Beilagen.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 4, Beilagen 3" });
                Beilagen.Add(new ZufallLand() { Preis = 14.99m, Auswahl = "Land 4, Beilagen 4" });

                int index3 = random.Next(Beilagen.Count);

                Dips.Add(new ZufallLand() { Preis = 7.99m, Auswahl = "Land 4, Dip 1" });
                Dips.Add(new ZufallLand() { Preis = 10.99m, Auswahl = "Land 4, Dip 2" });
                Dips.Add(new ZufallLand() { Preis = 9.99m, Auswahl = "Land 4, Dip 3" });
                Dips.Add(new ZufallLand() { Preis = 8.99m, Auswahl = "Land 4, Dip 4" });

                int index4 = random.Next(Dips.Count);
                //Console.WriteLine(Beilagen[index]);

                //var deineAuswahl = Vorspeise[index] + " " + Hauptspeise[index];
                Console.WriteLine("Deine Wahl fällt auf: \n" + Vorspeise[index] + "\n" + Hauptspeise[index2] + "\n" + Beilagen[index3] + "\n" + Dips[index4]);

            }
        }
    }  
}


