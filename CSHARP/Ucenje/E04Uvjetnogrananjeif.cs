using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Uvjetnogrananjeif
    {

        public static void izvedi()
        {

            //Console.WriteLine("E04Uvjetnogrananjeif");

            int broj = 7; // ovo je kao da sam ispisao poruku i da je korisnik unijeo broj 7
            bool uvjet = broj == 7; // operator == provjera jednakosti, on je tipa bool
                                    // if radi sa bool tipom podatka
            if (uvjet)
            {

                Console.WriteLine("broj ima vrijednost 7");

            }

            // u pravilu se if koristi ovako
            if (broj == 7)
            {
                Console.WriteLine("ponovno je jednako 7");
            }

            // if moze i bez {} i zada se odnosi samo na prvu liniju nakon if
            if (broj == 7)
                Console.WriteLine("i bez {} je jednako");
            //Console.WriteLine("i ovo bih da je uz uvjet jednakosti da je broj 7");

            if (broj == 7)
            {

                Console.WriteLine("i opet je 7 ali uz inace");

            }
            else
            {
                Console.WriteLine("Broj NIJE 7");
            }
            //maksimalni oblik if naredbe
            if (broj == 6)
            {
                Console.WriteLine("Sad je 6");
            }
            else if (broj == 7)
            {
                Console.WriteLine("sad je 7");
            } // moze ici koliko god else if zelimo

            else //moze i nemora
            {

                Console.WriteLine("broj nije niti 6 niti 7");
            }

            // if koristi <,>,<=,>= i != razlicito

            // logicki operatori and, or i not

            // and & ili &&

            broj = 1;
            int temp = 2;

            if(broj !=1 & temp < 0)
            {

                Console.WriteLine("hladno je"); // provjervati ce se oba uvjeta
            }

            if (broj != 1 && temp < 0)
            {

                Console.WriteLine("hladno je"); // Ako prvi uvjet nije ispunjen ne provjerava  se drugi
            }

            // or | (AltGr + W) 

            if(broj>0 | temp > 0) // provjerava oba uvjeta
            {

                Console.WriteLine("Toplo je"); 
            }

            if (broj > 0 || temp > 0) // Ako je prvi uvjet zadovoljen ne provjerava se drugi
            {

                Console.WriteLine("Toplo je");
            }

            // not ! 
            if(!(broj > 2 || temp>0))
            {
                Console.WriteLine("ovo je kompliciran izraz");
                    
            }

            // if se moze ugnježđivati
            if (broj > 0)
            {

                if (temp == 0)
                {

                    Console.WriteLine("Ugnježđeno");
                }
            }


            // djelokrug varijable (scope)

            if (broj > 0)
            {

                int t = 8;//ova varijabla živi samo unutar ovog if-a
            }
            //Console.WriteLine(t); // varijabla t nije vidljiva izvan gore definiranog if-a

            string grad = "Osijek";

            if(grad == "Osijek")
            {

                Console.WriteLine("Super");

            }
            else
            {

                Console.WriteLine("Nije super");
            }


            // u slucaju da if i else imaju istu akciju (naredba, metoda) tada se moze koristiti inline if (?: operator)

            Console.WriteLine(grad=="Osijek" ? "Super" : "Nije super"); // postoje ogranicenja, samo u slucaju if i else u istoj naredbi mozemo korisiti ovaj nacin pisanja koda



        }
    }
}
