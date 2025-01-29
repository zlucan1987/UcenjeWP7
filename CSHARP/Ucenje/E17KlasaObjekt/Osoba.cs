using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    // Klase je opisnik objekta  -> Ovo naučiti napamet
    public class Osoba
    {
        private string? _moje;
        public string Moje
        {
            get { return _moje ?? ""; }
        }



        // klasa sadrži svojstva
        // princip učahurivanja  -> najcesce POCO (Plain Old C# Object)
        //  Svjostva klase se pišu sa velikim početnim slovom
        public int Sifra { get; set; }
        public string? Ime { get; set; } // ? znaci da moze biti null
        public string Prezime { get; set; } = ""; // ="" ce postaviti prazno, nece biti null
        public DateTime? DatumRodenja { get; set; }

        // ovo je iz konteksta baza veza 1:n
        public Mjesto Mjesto { get; set; } = new Mjesto();

        // ovo je iz konteksta baza veza n:n
        public Mjesto[]? Mjesta { get; set; }



        // klasa može sadržavati metode
        // metoda vidi i upravlja svojstvima klase
        /// <summary>
        /// Vraća puno ime i prezime osobe.
        /// </summary>
        /// <returns>String koji sadrži ime i prezime osobe.</returns>
        public string ImePrezime()    // nema static jer static metode se zovu na klasi, a bez static se zovu na objektu
        {
            _moje = "aaa"; // u klasi mogu postavljati
            //Sifra = 1;
            NeVidiSeIzvana();
            return Ime + " " + Prezime; // ovo nije baš dobro rješenje - string je imutable
        }

        private string NeVidiSeIzvana()
        {
            return "";
        }


        public static void Hello() // Nju zovem na klasi, a ne na objektu, Osoba.Hello();
        {
            Console.WriteLine("Hello");
        }
    }
}