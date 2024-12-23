using System;
using Ucenje;

namespace Ucenje
{           // DZ99DZ (sam sebi zadao zadacu haha)
            // 
    internal class Q09Vjezba
    {

        public static void Izvedi(string[] args)      // Main koristimo u slucaju kada imamo sto "graditi" unutar njega te izvrsavanje programa se vrsi unutar metode "Main"-a
        {

            static int ZbrojZnamenki(int broj) //Ova metoda se jos zove Rekurzivna metoda (poziva se sama na sebe). Napomena, VAZNO je imati uvjet za prekid rekurzije
                                                // kako bi se izbjeglo beskonacno ponavljanje (sto ja,recimo... sam saznao na tezi nacin xD)
            {
                int zbroj = 0;
                while (broj > 0)
                {
                    zbroj += broj % 10;  // ovdje se uzima svaka zadnja znamenka zbroja brojeva te se dodaje zbroju
                    broj /= 10;         // broj se dijeli sa 10 kako bi se uklonila posljednja znamenka
                }
                return zbroj;           // metoda se poziva ponovno sve dok ne ostane niti jedna znamenka
            }


            Console.Write("Unesite pozitivan cijeli broj: ");         // korisnika se poziva da unese pozitivan cijeli broj
            if (int.TryParse(Console.ReadLine(), out int broj))  // "TryParse" provjerava dali je uneseni broj cijeli broj
            {
                if (broj < 0)                                           // Nezovoljava korisniku unos negativnog broja
                {
                    Console.WriteLine("Broj ne moze biti negativan.");  
                }
                else
                {
                    int rezultat = broj * 9;    // ako je unos valjan onda pomnozi sa 9
                    Console.WriteLine("Rezultat množenja s 9 je: " + rezultat); // vraca rezultat mnozenja sa 9 na sucelje 

                    int zbrojZnamenki = ZbrojZnamenki(rezultat); // izracunava se zbroj znamenki rezultata mnozenja
                    Console.WriteLine("Zbroj znamenki rezultata je: " + zbrojZnamenki);

                    while (zbrojZnamenki > 9)
                    {
                        zbrojZnamenki = ZbrojZnamenki(zbrojZnamenki);
                    }

                    Console.WriteLine("Konačni zbroj znamenki je: " + zbrojZnamenki);
                }
            }
                     else // naredba se koristi kako bi iskljucili mogucnost da korisnik unese NE/cijeli broj
                     {
                     Console.WriteLine("Niste unijeli cijeli broj.");
                     }
            Console.ReadLine(); // iskreno, ovo sam dodao samo iz razloga da mi se prozor programa ne minimizira nakon izvodjenja, malo iritira.
        }

    }
}               /* program izvesti iz : 
                 * using Ucenje;
                 * Q09Vjezba.Izvedi(new string[] { }); */