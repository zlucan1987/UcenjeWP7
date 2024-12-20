using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z1
    {

        public static void Izvedi()
        {

            //Console.WriteLine("E04Z1");
            //Program unosi od korisnika cijeli broj.
            //Program ispisuje dali je broj paran ili neparan

            Console.Write("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                Console.WriteLine("Paran");

            }
            else 
            {

                Console.WriteLine("Neparan");
            }
            Console.WriteLine("{0}Paran", broj % 2 == 0 ? "" : "NE");
        }

    }
}
