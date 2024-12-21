using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Q03Vjezba
    {
        // Program od korisnika traži unos broja godinma koje ima korisnik
        // Program ispisuje dali je korisnik punoljetna osoba ili ne

        public static void Izvedi()
        {
            //Console.WriteLine("Q03");

            Console.Write("Unesi broj godina: ");
            int godine = int.Parse(Console.ReadLine());

            if (godine >= 18)
            {
                Console.WriteLine("Korisnik je punoljetna osoba");

            }

            else
            {
                Console.WriteLine("Korisnik nije punoljetna osoba");

            } 
            Console.WriteLine("korisnik {0} punoljetna{1} osoba {1}", godine >= 18 ? "je" : "nije", godine);
        }

    }

}
