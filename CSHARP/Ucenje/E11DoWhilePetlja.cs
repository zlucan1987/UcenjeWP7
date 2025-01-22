using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11DoWhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E11");

            // do while osigurava izvođenje minimalno jedne iteracije

            do
            {
                Console.WriteLine("Izvede se jednom");
            } while (false);

            // sve ostalo navedeno u for (break i continue) te u while (&& || !) radi jednako i u do while

            // Ispisati sve parne brojeve od 2 do 28 koristeći do while

        }
    }
}