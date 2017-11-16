using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Pujcovna
{
    public class Zakaznik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }
        public BindingList<Medium> Vypujceno { get; private set; } = new BindingList<Medium>();

        public Zakaznik(string j, string p, string a)
        {
            Jmeno = j;
            Prijmeni = p;
            Adresa = a;
        }
    }
}
