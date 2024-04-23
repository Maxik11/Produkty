using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkty
{
    public class Polozka
    {
        public Polozka(int id, string nazev, int pocet, int cena)
        {
            Id = id;
            Nazev = nazev;
            Cena = cena;
            Pocet = pocet;
        }

        public int? Id { get; set; }
        public string Nazev { get; set; }
        public int Cena { get; set; }

        public int Pocet { get; set; }

        public override string ToString()
        {
            return $"{Nazev} {Cena} {Id}";
        }
    }
}
