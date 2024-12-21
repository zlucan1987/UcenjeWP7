using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ2
    {

        // program od korisnika trazi unos broja godina koje ima korsinik
        // program ispisuje dali je korisnik punoljetna osoba ili ne

        // dodatno: ako je unos ispod nula godine ili iznad 112 godina ispisati GRESKA



        public static void Izvedi()
        {

            //Console.WriteLine("Z2");

         
            Console.Write("Unesi broj godina: ");
            int godine=int.Parse(Console.ReadLine());
           if (godine >= 18)
            {

                Console.WriteLine("Korisnik je punoljetna osoba");

            }
            else
            {

                Console.WriteLine("Korisnik nije punoljetna osoba");
            }

            Console.WriteLine("korisnik {0} punoljetna {1} osoba ({1})", godine>=18? "je" : "nije", godine);

        }

    }
}
