using System.Collections.Generic;

namespace Menue
{
    public class Gericht
    {
        public string Name { get; set; }
        public decimal Preis { get; set; }

        public override string ToString() => $"{Name}, {Preis:F2} €";
    }

    public class LandSpeisekarte
    {
        public List<Gericht> Vorspeisen { get; set; }
        public List<Gericht> Hauptspeisen { get; set; }
        public List<Gericht> Beilagen { get; set; }
        public List<Gericht> Dips { get; set; }
    }

    // Um ein neues Land hinzuzufügen: einfach einen neuen Eintrag im Dictionary anlegen.
    public static class SpeisekartenDaten
    {
        public static readonly Dictionary<string, LandSpeisekarte> Laender = new()
        {
            ["Italien"] = new LandSpeisekarte
            {
                Vorspeisen = new()
                {
                    new() { Name = "Bruschetta al Pomodoro",  Preis = 4.99m  },
                    new() { Name = "Caprese",                 Preis = 6.99m  },
                    new() { Name = "Antipasto Misto",         Preis = 8.99m  },
                    new() { Name = "Focaccia",                Preis = 3.99m  }
                },
                Hauptspeisen = new()
                {
                    new() { Name = "Spaghetti Carbonara",     Preis = 13.99m },
                    new() { Name = "Risotto ai Funghi",       Preis = 14.99m },
                    new() { Name = "Pizza Margherita",        Preis = 11.99m },
                    new() { Name = "Lasagne al Forno",        Preis = 12.99m }
                },
                Beilagen = new()
                {
                    new() { Name = "Insalata Verde",          Preis = 4.99m  },
                    new() { Name = "Panzanella",              Preis = 5.99m  },
                    new() { Name = "Ribollita",               Preis = 6.99m  },
                    new() { Name = "Patate al Forno",         Preis = 3.99m  }
                },
                Dips = new()
                {
                    new() { Name = "Pesto Genovese",          Preis = 2.49m  },
                    new() { Name = "Aioli",                   Preis = 1.99m  },
                    new() { Name = "Salsa Marinara",          Preis = 2.99m  },
                    new() { Name = "Tapenade",                Preis = 2.49m  }
                }
            },

            ["Japan"] = new LandSpeisekarte
            {
                Vorspeisen = new()
                {
                    new() { Name = "Edamame",                 Preis = 3.99m  },
                    new() { Name = "Gyoza (6 Stück)",         Preis = 6.99m  },
                    new() { Name = "Miso-Suppe",              Preis = 4.49m  },
                    new() { Name = "Takoyaki (6 Stück)",      Preis = 5.99m  }
                },
                Hauptspeisen = new()
                {
                    new() { Name = "Tonkotsu Ramen",          Preis = 13.99m },
                    new() { Name = "Sushi-Platte (12 Stück)", Preis = 18.99m },
                    new() { Name = "Chicken Teriyaki",        Preis = 14.99m },
                    new() { Name = "Tonkatsu",                Preis = 15.99m }
                },
                Beilagen = new()
                {
                    new() { Name = "Wakame-Salat",            Preis = 4.99m  },
                    new() { Name = "Onigiri",                 Preis = 3.99m  },
                    new() { Name = "Gemüse-Tempura",          Preis = 7.99m  },
                    new() { Name = "Yasai Itame",             Preis = 5.99m  }
                },
                Dips = new()
                {
                    new() { Name = "Sojasoße",                Preis = 0.99m  },
                    new() { Name = "Wasabi-Mayo",             Preis = 1.99m  },
                    new() { Name = "Teriyaki-Soße",           Preis = 1.49m  },
                    new() { Name = "Ponzu",                   Preis = 1.99m  }
                }
            },

            ["Mexiko"] = new LandSpeisekarte
            {
                Vorspeisen = new()
                {
                    new() { Name = "Guacamole & Chips",       Preis = 5.99m  },
                    new() { Name = "Quesadillas",             Preis = 7.99m  },
                    new() { Name = "Elote (Maiskolben)",      Preis = 4.99m  },
                    new() { Name = "Jalapeño Poppers",        Preis = 6.49m  }
                },
                Hauptspeisen = new()
                {
                    new() { Name = "Tacos al Pastor (3 Stk)", Preis = 12.99m },
                    new() { Name = "Enchiladas",              Preis = 13.99m },
                    new() { Name = "Burrito",                 Preis = 11.99m },
                    new() { Name = "Chili con Carne",         Preis = 10.99m }
                },
                Beilagen = new()
                {
                    new() { Name = "Reis & Bohnen",           Preis = 3.99m  },
                    new() { Name = "Pico de Gallo",           Preis = 2.99m  },
                    new() { Name = "Maissalat",               Preis = 4.49m  },
                    new() { Name = "Tortilla-Chips",          Preis = 2.99m  }
                },
                Dips = new()
                {
                    new() { Name = "Salsa Roja",              Preis = 1.99m  },
                    new() { Name = "Salsa Verde",             Preis = 1.99m  },
                    new() { Name = "Sour Cream",              Preis = 1.49m  },
                    new() { Name = "Chipotle-Mayo",           Preis = 2.49m  }
                }
            },

            ["Griechenland"] = new LandSpeisekarte
            {
                Vorspeisen = new()
                {
                    new() { Name = "Tzatziki & Pita",         Preis = 4.99m  },
                    new() { Name = "Spanakopita",             Preis = 5.99m  },
                    new() { Name = "Dolmades (6 Stück)",      Preis = 6.49m  },
                    new() { Name = "Hummus",                  Preis = 4.49m  }
                },
                Hauptspeisen = new()
                {
                    new() { Name = "Moussaka",                Preis = 13.99m },
                    new() { Name = "Souvlaki vom Grill",      Preis = 12.99m },
                    new() { Name = "Gyros mit Pita",          Preis = 11.99m },
                    new() { Name = "Gemista",                 Preis = 10.99m }
                },
                Beilagen = new()
                {
                    new() { Name = "Griechischer Salat",      Preis = 6.99m  },
                    new() { Name = "Pita-Brot",               Preis = 2.99m  },
                    new() { Name = "Fasolada",                Preis = 4.99m  },
                    new() { Name = "Horiatiki",               Preis = 5.99m  }
                },
                Dips = new()
                {
                    new() { Name = "Tzatziki",                Preis = 2.99m  },
                    new() { Name = "Taramasalata",            Preis = 3.49m  },
                    new() { Name = "Skordalia",               Preis = 2.49m  },
                    new() { Name = "Melitzanosalata",         Preis = 3.99m  }
                }
            }
        };
    }
}