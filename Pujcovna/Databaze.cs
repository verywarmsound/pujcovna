using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Pujcovna
{
    public static class Databaze
    {
        public static BindingList<Zakaznik> Zakaznici { get; set; } = new BindingList<Zakaznik>();
        public static BindingList<Medium> Sklad { get; set; } = new BindingList<Medium>();

        public static void Inicializuj()
        {
            Zakaznici.Add(new Zakaznik("Pepa", "Novák", "Praha"));
            Zakaznici.Add(new Zakaznik("Franta", "Vomáčka", "Kladno"));
            Zakaznici.Add(new Zakaznik("Karel", "Barel", "Úvaly"));

            Sklad.Add(new CD("Led Zeppelin II", "Led Zeppelin", "rock", 25));
            Sklad.Add(new CD("Plná taška", "Eva a Vašek", "psychedelický hardcore", 15));
            Sklad.Add(new CD("Hybrid Theory", "Linkin Park", "nu metal", 20));
            Sklad.Add(new CD("Loutky", "Škwor", "rock", 20));

            Sklad.Add(new Dvd("Star Wars", "George Lucas", "scifi", 25));
            Sklad.Add(new Dvd("Star Trek", "J.J. Abrams", "scifi", 25));
            Sklad.Add(new Dvd("Avatar", "James Cameron", "scifi", 25));
            Sklad.Add(new Dvd("Kameňák", "Zdeněk Troška", "existenciální drama", 15));
        }
    }
}
