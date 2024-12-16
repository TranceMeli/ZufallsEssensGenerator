using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menue
{
    public class Warenkorb
    {
        private List<Produkt> produkte;

        public Warenkorb()
        {
            produkte = new List<Produkt>();

        }
        public void hinzufuegenProdukt(Produkt produkt)
        {
            produkte.Add(produkt);
        }
        public void entfernenProdukt(Produkt produkt)
        {
            produkte.Remove(produkt);
        }
        public decimal WarenkorbLeeren()
        {
            decimal total = 0;
            foreach (var produkt in produkte)
            {
                total += produkt.Preis;
            }
            return total;
        }
        //public decimal WarenkorbLeeren()
        //{
        //    decimal total = 0;
        //    foreach (var v in Warenkorb)
        //    {
        //        total += total + Preis;
        //    }
        //    return total;
        //}

    }
}
