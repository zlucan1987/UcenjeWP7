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


            int[] niz = { 2, 3, 4, 5, 3, 2, 2};

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




                for(int j = 0; j<stupaca; j++)
                {
                    Console.Write("{0,4} ", (i+1)*(j+1)); // {0,4} stavljamo da bi napravili razmak izmedju brojeva
                }

                Console.WriteLine();


            }



        }       
    }
}
