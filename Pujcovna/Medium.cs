using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pujcovna
{
    public abstract class Medium
    {
        public string Nazev { get; set; }
        public int Cena { get; set; }
        public string Zanr { get; set; }

        public Medium(string n, string z, int c)
        {
            Nazev = n;
            Zanr = z;
            Cena = c;
        }

        public abstract string CelyNazev();
    }

    public class CD : Medium
    {
        public string Interpret { get; set; }

        public CD(string n, string i, string z, int c) : base(n, z, c)
        {
            Interpret = i;
        }

        public override string CelyNazev()
        {
            return Interpret + " - " + Nazev;
        }
    }

    public class Dvd : Medium
    {
        public string Reziser { get; set; }

        public Dvd(string n, string r, string z, int c) : base(n, z, c)
        {
            Reziser = r;
        }
        public override string CelyNazev()
        {
            return Reziser + " - " + Nazev;
        }
    }
}
