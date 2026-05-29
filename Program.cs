using Menue;

namespace Menue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AsciiArt asciiArt = new AsciiArt();
            MenueStruktur menueStruktur = new MenueStruktur();

            asciiArt.WillkommenAscii();
            menueStruktur.Begruessung();
            menueStruktur.Sprueche();
            Console.WriteLine();
            menueStruktur.HauptMenue();
        }
    }
}