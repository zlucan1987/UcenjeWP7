using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08ForPetlja
    {

        public static void Izvedi()
        {
            //Na osnovu dosadasnjeg znanja 
            //Ispisite 10 puta jedno ispod drugog Osijek
            // OVO NIJE DOBRA PRAKSA (Best practice)
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            //Bolje rjesenje
            Console.WriteLine("*************");
            for (int i = 0; i < 10; i++) // PAZITI da ovdje ne dodje tocka zarez ; // i=i+1, i+=1
            {
                Console.WriteLine("{0}. Osijek", i);
            }

            // kao i kod if ne moraju biti {} ali se onda petlja odnosi samo na  prvu sljedecu liniju

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Ispisujem {0}. broj.", i);

            }

            // zbroj svih prvih 100 brojeva
            int suma = 0;

            for (int i = 1; i <= 100; i++)
            {

                suma += i;
                //ako zelimo pratiti proces
                Console.WriteLine("{0} + {1} = {2}", suma - i, i, suma);
            }

            // ako zelimo samo rezultat, ispitujemo petlja, nakon}
            Console.WriteLine(suma);

            //petlja moze ici i "unazad"

            for (int i = 10; i > 0; i--)
            {

                Console.WriteLine(i);

            }
            Console.WriteLine("++++++++++++++");
            // petlja ne mora ici za korak 1

            for (int i = 0; i < 10; i += 2)
            {

                Console.WriteLine(i);
            }

            /*int odKuda = 2; doKuda = 20, uvecanje = 3; // simulacija da je unio korisnik

            // ono cemu tezimo u kodu jest kod bez konstanti

            for (int i = odKuda; i < doKuda; i += uvecanje)
            {
                Console.WriteLine(i);

            }*/


            int[] niz = { 2, 3, 4, 5, 3, 2, 2 };

            // ispisite broj 5
            Console.WriteLine(niz[3]);

            Console.WriteLine("+++++++++++++++");
            // u novim linijama ispisi sve elemente niza 

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]); // ovo je slovo i, ne broj 1
            }


            int redaka = 8;
            int stupaca = 6;

            for (int i = 0; i < redaka; i++)
            {

                for (int j = 0; j < stupaca; j++)
                {
                    Console.Write("{0,4} ", (i + 1) * (j + 1)); // {0,4} stavljamo da bi napravili razmak izmedju brojeva
                }

                Console.WriteLine();


            }
            // petlju se moze preskociti - nastaviti
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < 10; i++)
            {

                if (i == 4)// preskoci 5. mjesto
                {
                    continue;// vraca na pocetak petlje

                }
                Console.WriteLine("Rezerviraj {0}. mjesto", i + 1);

            }
            // petlja se moze "nasilno" prekinuti

            for (int i = 0; i < 10; i++)// prirodni kraj je i=10
            {

                if (i == 5)
                {
                    break; // nasilno prekidam
                }

                Console.WriteLine(i);

            }

            // korisnost break-a
            // prim broj, prime number, prosti broj
            // 2,3,5,7,11,13,17,19 etc
            // zasto 4 nije prim broj? Cjelobrojno je djeljiv s 2

            int brojZaProvjeru = 157;
            int brojacIteracija=1;
            bool prim = true; // moja hipoteza je da taj broj je PRIM broj
            for (int i = 2; i < brojZaProvjeru/2; i++) 
            {
                Console.WriteLine("{0}%{1}=={2} ({3})", brojZaProvjeru, i, brojZaProvjeru%i, brojacIteracija++);
                if (brojZaProvjeru % i == 0) 
                {
                    //TO NIJE PRIM BROJ
                    prim = false;
                    break;
                }
            }
            Console.WriteLine("{0} {1} prim broj", brojZaProvjeru, prim ? "JE" : "NIJE");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            // za razbibrigu tijekom dugih zimskih noci https://hr.wikipedia.org/wiki/Eratostenovo_sito

            for (; ; )
            {
                Console.WriteLine(new Random().NextInt64() + "" + new Random().NextInt64() + "" + new Random().NextInt64());
                Thread.Sleep(300);
                break; //ovo maknuti ako hoćemo beskonačni prikaz brojeva
            }



        }

    }
}
