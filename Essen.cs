using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Menue
{
    public class Essen
    {
        protected static readonly Random random = new Random();

        public string name;
        public string Auswahl { get; set; }
        public decimal Preis { get; set; }

        public override string ToString() => $"{Auswahl}, {Preis:F2} €";

        public Essen() { }
        public Essen(string name) { this.name = name; }
    }

    public class Vorspeise : Essen
    {
        public Gericht Vorspeisenauswahl()
        {
            var alle = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Vorspeisen).ToList();
            var auswahl = alle[random.Next(alle.Count)];
            Console.WriteLine($"Vorspeise:   {auswahl}");
            return auswahl;
        }
    }

    public class Hauptspeise : Essen
    {
        public Gericht Hauptspeisenauswahl()
        {
            var alle = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Hauptspeisen).ToList();
            var auswahl = alle[random.Next(alle.Count)];
            Console.WriteLine($"Hauptspeise: {auswahl}");
            return auswahl;
        }
    }

    public class Beilagen : Essen
    {
        public Gericht Beilagenauswahl()
        {
            var alle = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Beilagen).ToList();
            var auswahl = alle[random.Next(alle.Count)];
            Console.WriteLine($"Beilage:     {auswahl}");
            return auswahl;
        }
    }

    public class Dips : Essen
    {
        public Gericht Dipauswahl()
        {
            var alle = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Dips).ToList();
            var auswahl = alle[random.Next(alle.Count)];
            Console.WriteLine($"Dip:         {auswahl}");
            return auswahl;
        }
    }

    public class ZufallLand : Essen
    {
        public List<Gericht> ZufallLandGenerieren(string land)
        {
            if (!SpeisekartenDaten.Laender.TryGetValue(land, out var s))
            {
                Console.WriteLine($"Keine Speisekarte für '{land}' gefunden.");
                return new List<Gericht>();
            }

            var v = s.Vorspeisen[random.Next(s.Vorspeisen.Count)];
            var h = s.Hauptspeisen[random.Next(s.Hauptspeisen.Count)];
            var b = s.Beilagen[random.Next(s.Beilagen.Count)];
            var d = s.Dips[random.Next(s.Dips.Count)];

            Console.WriteLine($"Deine Wahl fällt auf ({land}):\n"
                + $"  Vorspeise:   {v}\n"
                + $"  Hauptspeise: {h}\n"
                + $"  Beilage:     {b}\n"
                + $"  Dip:         {d}");

            return new List<Gericht> { v, h, b, d };
        }
    }

    public class MenueStruktur : Essen
    {
        private static readonly string[] laender =
            SpeisekartenDaten.Laender.Keys.ToArray();

        private readonly AsciiArt ascii = new AsciiArt();
        private readonly List<Gericht> warenkorb = new List<Gericht>();

        private const string COLOR = "\u001b[42m";
        private const string RESET = "\u001b[0m";

        public MenueStruktur() { }


        private void ZeigeHeader()
        {
            Console.Clear();
            ascii.WillkommenAscii();
            //ascii.Trennlinie();
            Console.ResetColor();
            Console.WriteLine();
        }

        private List<Gericht> MenueZufall()
        {
            var vs = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Vorspeisen).ToList();
            var hs = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Hauptspeisen).ToList();
            var bs = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Beilagen).ToList();
            var ds = SpeisekartenDaten.Laender.SelectMany(l => l.Value.Dips).ToList();

            var result = new List<Gericht>
            {
                vs[random.Next(vs.Count)],
                hs[random.Next(hs.Count)],
                bs[random.Next(bs.Count)],
                ds[random.Next(ds.Count)]
            };

            Console.WriteLine("Der Zufall entscheidet:\n");
            Console.WriteLine($"  Vorspeise:   {result[0]}");
            Console.WriteLine($"  Hauptspeise: {result[1]}");
            Console.WriteLine($"  Beilage:     {result[2]}");
            Console.WriteLine($"  Dip:         {result[3]}");

            return result;
        }

        private void HinzufuegenWarenkorb(Gericht gericht)
            => HinzufuegenWarenkorb(new List<Gericht> { gericht });

        private void HinzufuegenWarenkorb(List<Gericht> gerichte)
        {
            Console.WriteLine("\n[Enter] = In den Warenkorb  |  [Esc] = Abbrechen\n");
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                warenkorb.AddRange(gerichte);
                Console.WriteLine("In den Warenkorb gelegt. ✓");
            }
            else
            {
                Console.WriteLine("Okay, vielleicht etwas anderes.");
            }

            Warte();
        }

        private void Warte()
        {
            Console.WriteLine("\nWeiter mit beliebiger Taste...");
            Console.ReadKey(true);
        }

        // Ladebildschirm-Simulation
        private void Ladebildschirm(string titel)
        {
            ZeigeHeader();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  {titel}\n");
            Console.ResetColor();

            string[] schritte =
            {
                "  Bestellung wird übermittelt   ",
                "  Bestellung bestätigt          "
            };

            int balkenBreite = 30;

            foreach (var schritt in schritte)
            {
                Console.Write(schritt + "  [");
                for (int i = 0; i < balkenBreite; i++)
                {
                    Thread.Sleep(30);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("░");
                    Console.ResetColor();
                }
                Console.WriteLine("]  ✓");
                Thread.Sleep(200);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ╔══════════════════════════════════════╗");
            Console.WriteLine("  ║   Vielen Dank für deine Bestellung!  ║");
            Console.WriteLine("  ║   Dein Essen ist in 30 Min da.       ║");
            Console.WriteLine("  ╚══════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Warte();
        }

        private void LadebildschirmAbholung()
        {
            ZeigeHeader();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  Abholung wird vorbereitet...\n");
            Console.ResetColor();

            string[] schritte =
            {
                "  Bestellung wird übermittelt   ",
                "  Bestellung bestätigt          "
            };

            int balkenBreite = 30;

            foreach (var schritt in schritte)
            {
                Console.Write(schritt + "  [");
                for (int i = 0; i < balkenBreite; i++)
                {
                    Thread.Sleep(30);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("░");
                    Console.ResetColor();
                }
                Console.WriteLine("]  ✓");
                Thread.Sleep(200);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ╔══════════════════════════════════════╗");
            Console.WriteLine("  ║   Bestellung bereit zur Abholung!    ║");
            Console.WriteLine("  ║   Restaurant A — 500m entfernt       ║");
            Console.WriteLine("  ╚══════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Warte();
        }

        public void Sprueche()
        {
            string[] sayings =
            {
                "Willkommen bei Essen 2.0 :)",
                "Bestelle jetzt und erhalte dein Essen in 30 Minuten!",
                "20 % Rabatt bei Abholung!",
                "Führender Testsieger unter den Lieferservices!",
                "Jetzt neu: Lieferung mit Drohne!",
                "Wir sind die Besten.. und ja wir meinen das wirklich so :)",
                "Erste Bestellung 50 % Rabatt!",
                "Punkte bei jeder Bestellung sammeln und Rabatt erhalten!"
            };

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sayings[random.Next(sayings.Length)]);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void Begruessung()
        {
            ZeigeHeader();
            Console.WriteLine("Hallo, wie ist dein Name?");
            name = Console.ReadLine();
            //ascii.Trennlinie();
            Console.ResetColor();
            Console.WriteLine(
                $"\nWillkommen {name} bei Essen 2.0!\n" +
                "Stelle dein Menü nach Zufall zusammen.\n" +
                "Lust auf eine bestimmte Länderküche? Kein Problem!\n" +
                "Oder wähle völligen Zufall für die wildesten Kombinationen!\n");
            //ascii.Trennlinie();
            Console.ResetColor();
            Console.WriteLine();
        }

        public void ExitProgramm() => Environment.Exit(0);

        private string LandAuswaehlen()
        {
            int option = 1;
            int MAX = laender.Length + 1;
            Console.CursorVisible = false;

            while (true)
            {
                ZeigeHeader();
                Console.WriteLine("  Wähle eine Länderküche:\n");
                (int left, int top) = Console.GetCursorPosition();

                while (true)
                {
                    Console.SetCursorPosition(left, top);
                    for (int i = 0; i < laender.Length; i++)
                        Console.WriteLine($"{(option == i + 1 ? COLOR : "")}  {laender[i]}  {RESET}");
                    Console.WriteLine($"{(option == MAX ? COLOR : "")}  Zurück        {RESET}");

                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow) { option = option == MAX ? 1 : option + 1; continue; }
                    if (key.Key == ConsoleKey.UpArrow) { option = option == 1 ? MAX : option - 1; continue; }
                    if (key.Key != ConsoleKey.Enter) continue;

                    if (option == MAX) return null; // Zurück
                    return laender[option - 1];
                }
            }
        }

        public void HauptMenue()
        {
            var zufallLand = new ZufallLand();
            int option = 1;
            const int MAX = 6;
            Console.CursorVisible = false;

            while (true)
            {
                ZeigeHeader();
                Sprueche();
                Console.WriteLine();
                (int left, int top) = Console.GetCursorPosition();

                while (true)
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"{(option == 1 ? COLOR : "")}  Nimm mich an der Hand!  {RESET}");
                    Console.WriteLine($"{(option == 2 ? COLOR : "")}  Zufall nach Land        {RESET}");
                    Console.WriteLine($"{(option == 3 ? COLOR : "")}  Völliger Zufall         {RESET}");
                    Console.WriteLine($"{(option == 4 ? COLOR : "")}  Spezielle Optionen      {RESET}");
                    Console.WriteLine($"{(option == 5 ? COLOR : "")}  Warenkorb               {RESET}");
                    Console.WriteLine($"{(option == 6 ? COLOR : "")}  Exit                    {RESET}");

                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow) { option = option == MAX ? 1 : option + 1; continue; }
                    if (key.Key == ConsoleKey.UpArrow) { option = option == 1 ? MAX : option - 1; continue; }
                    if (key.Key != ConsoleKey.Enter) continue;

                    ZeigeHeader();

                    if (option == 1)
                    {
                        WahlMenue();
                    }
                    else if (option == 2)
                    {
                        string land = LandAuswaehlen();
                        if (land != null)
                        {
                            ZeigeHeader();
                            var gerichte = zufallLand.ZufallLandGenerieren(land);
                            if (gerichte.Count > 0) HinzufuegenWarenkorb(gerichte);
                        }
                    }
                    else if (option == 3)
                    {
                        var gerichte = MenueZufall();
                        HinzufuegenWarenkorb(gerichte);
                    }
                    else if (option == 4)
                    {
                        SpezielleOptionen();
                    }
                    else if (option == 5)
                    {
                        ZeigeWarenkorb();
                    }
                    else
                    {
                        ZeigeHeader();
                        Console.WriteLine("Vielleicht bis bald :)");
                        Thread.Sleep(1500);
                        ExitProgramm();
                    }

                    break;
                }
            }
        }

        private void ZeigeWarenkorb()
        {
            ZeigeHeader();
            Console.ForegroundColor = ConsoleColor.Green;
            ascii.Pizza();
            Console.ResetColor();
            Console.WriteLine("\n─── Dein Warenkorb ───\n");

            if (warenkorb.Count == 0)
            {
                Console.WriteLine("Der Warenkorb ist leer.");
                Warte();
                return;
            }

            decimal gesamt = 0;
            for (int i = 0; i < warenkorb.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {warenkorb[i]}");
                gesamt += warenkorb[i].Preis;
            }

            Console.WriteLine($"\n  Gesamt: {gesamt:F2} €\n");
            Console.WriteLine("Jetzt bestellen oder abholen?\n");
            BestellenAbholen();
        }

        public void WahlMenue()
        {
            int option = 1;
            const int MAX = 5;
            Console.CursorVisible = false;

            while (true)
            {
                ZeigeHeader();
                Sprueche();
                Console.WriteLine();
                (int left, int top) = Console.GetCursorPosition();

                while (true)
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"{(option == 1 ? COLOR : "")}  Vorspeisen    {RESET}");
                    Console.WriteLine($"{(option == 2 ? COLOR : "")}  Hauptspeisen  {RESET}");
                    Console.WriteLine($"{(option == 3 ? COLOR : "")}  Beilagen      {RESET}");
                    Console.WriteLine($"{(option == 4 ? COLOR : "")}  Dips          {RESET}");
                    Console.WriteLine($"{(option == 5 ? COLOR : "")}  Hauptmenü     {RESET}");

                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow) { option = option == MAX ? 1 : option + 1; continue; }
                    if (key.Key == ConsoleKey.UpArrow) { option = option == 1 ? MAX : option - 1; continue; }
                    if (key.Key != ConsoleKey.Enter) continue;

                    if (option == MAX) return;

                    ZeigeHeader();
                    Gericht auswahl = option switch
                    {
                        1 => new Vorspeise().Vorspeisenauswahl(),
                        2 => new Hauptspeise().Hauptspeisenauswahl(),
                        3 => new Beilagen().Beilagenauswahl(),
                        4 => new Dips().Dipauswahl(),
                        _ => null
                    };
                    if (auswahl != null) HinzufuegenWarenkorb(auswahl);
                    break;
                }
            }
        }

        public void SpezielleOptionen()
        {
            int option = 1;
            const int MAX = 4;
            Console.CursorVisible = false;

            while (true)
            {
                ZeigeHeader();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  Spezielle Optionen für spezielle Momente  ");
                Console.ResetColor();
                Console.WriteLine("\n");
                (int left, int top) = Console.GetCursorPosition();

                while (true)
                {
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"{(option == 1 ? COLOR : "")}  Die besten Menüs.. von euch gewählt.  {RESET}");
                    Console.WriteLine($"{(option == 2 ? COLOR : "")}  Scharf schärfer am schärfsten.         {RESET}");
                    Console.WriteLine($"{(option == 3 ? COLOR : "")}  Hilfe die Verwandtschaft kommt.        {RESET}");
                    Console.WriteLine($"{(option == 4 ? COLOR : "")}  Hauptmenü                              {RESET}");

                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.DownArrow) { option = option == MAX ? 1 : option + 1; continue; }
                    if (key.Key == ConsoleKey.UpArrow) { option = option == 1 ? MAX : option - 1; continue; }
                    if (key.Key != ConsoleKey.Enter) continue;

                    if (option == MAX) return;

                    ZeigeHeader();
                    if (option == 1) Console.WriteLine("Die besten Menüs in monatlicher Abstimmung von euch gewählt! :)\n");
                    if (option == 2) Console.WriteLine("Kannst du es mit den schärfsten Menüs aufnehmen?\n");
                    if (option == 3) Console.WriteLine("Nichts zuhause aber Besuch kündigt sich an! Keine Sorge, wir helfen.\n");
                    Warte();
                    break;
                }
            }
        }

        public void BestellenAbholen()
        {
            int option = 1;
            const int MAX = 3;
            Console.CursorVisible = false;
            (int left, int top) = Console.GetCursorPosition();

            while (true)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine($"{(option == 1 ? COLOR : "")}  Bestellen  {RESET}");
                Console.WriteLine($"{(option == 2 ? COLOR : "")}  Abholen    {RESET}");
                Console.WriteLine($"{(option == 3 ? COLOR : "")}  Hauptmenü  {RESET}");

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) { option = option == MAX ? 1 : option + 1; continue; }
                if (key.Key == ConsoleKey.UpArrow) { option = option == 1 ? MAX : option - 1; continue; }
                if (key.Key != ConsoleKey.Enter) continue;

                if (option == 1)
                {
                    warenkorb.Clear();
                    Ladebildschirm("Bestellung wird aufgegeben...");
                }
                else if (option == 2)
                {
                    warenkorb.Clear();
                    LadebildschirmAbholung();
                }
                else
                {
                    return;
                }

                return;
            }
        }
    }
}