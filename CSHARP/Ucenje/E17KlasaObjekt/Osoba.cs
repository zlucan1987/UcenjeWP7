using System;

namespace Ucenje.E17KlasaObjekt.edunova
{
    // Klasa je opisnik objekta -- Ovo nauciti napamet

    public class Osoba
    {
        private string? _moje;
        public string Moje 
        {
            get { return _moje ?? ""; }
        
        }




        // Klasa sadrži svojstva (properties) i metode (methods)
        // Svojstva su opisnici objekta
        // Svojstva se sastoje od get i set metoda
        // get metoda vraća vrijednost svojstva
        // set metoda postavlja vrijednost svojstva
        // Svojstva se mogu koristiti kao varijable
        // princip ucahurivanja -> najcesce POCO (Plain Old C# Object)
        // Svojstva klase se pisu sa velikim pocetnim slovom

        public int Sifra { get; set; }  
        public string? Ime { get; set; } // ? znaci da moze biti null
        public string Prezime { get; set; } = ""; // = "" ce postaviti prazno, nece biti null
        public DateTime? DatumRodjenja { get; set; }

        // ovo je iz konteksta baze veza 1:n
        public Mjesto Mjesto { get; set; } = new Mjesto();
        // ovo je iz konteksta baze veza n:n
        public Mjest[]? Mjesta { get; set; }

        // Konstruktor je metoda koja se poziva prilikom kreiranja objekta
        // Konstruktor se koristi za postavljanje početnih vrijednosti svojstava
        // Konstruktor nema povratnu vrijednost
        // Konstruktor se zove isto kao i klasa
        // Konstruktor može imati parametre
        // Konstruktor može imati više overload verzija
        // Konstruktor može pozivati druge konstruktore


        //klasa moze sadrzavati metode
        //metoda vidi i upravlja svojstvima klase

        /// <summary>
        /// <returns>String koji sadrzi ime i prezime osobe.</returns>

        public string ImePrezime() // nema static jer static metode se zovu u klasi, a bez static se zovu na objektu

        {
            _moje = "aaa"; // u klasi mogu postaviti // _moje je private, ne moze se koristiti izvana
            NeVidiSeIzvana(); // moze se koristiti metoda koja je private
            return Ime + " " + Prezime; // ovo nije bas najbolje rijesenje - string je imutable
        }

        private string NeVidiSeIzvana()
        {
            return "";
        }

        public static void Hello() // Nju zovemo na klasi, a ne na objektu, Osoba.Hello();
        {
            Console.WriteLine("Hello");
        }


    }

}
