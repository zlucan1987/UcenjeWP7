using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Q08Vjezba
    {
        public static void Izvedi()
        {
            // 10 puta jedno ispod drugog ispišite Osijek
            // nije dobro riješenje

            // unaprijed
            for (int i = 0; i < 10; i++)
            {
             
                Console.WriteLine("{0}. Osijek iz petlje", i);

            }

            // unazad
            for (int i = 0; i > 0; i--)
            {

                Console.WriteLine("{0}. Unazad", i);

            }

        }
    }
}
