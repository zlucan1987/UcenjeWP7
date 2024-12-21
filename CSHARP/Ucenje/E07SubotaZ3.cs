using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ3
    {


        public static void Izvedi()
        {
            //Console.WriteLine("z3");
            // Program od korisnika trazi unos dva cijela broja
            // Program isopisuje manji
            // unos 5 i 2 --> 2
            // unos 3 i 8 --> 3
            // unos 4 i 4 --> Brojevi su jednaki

            Console.WriteLine("Unesi prvi broj: ");
            int pb = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int db = int.Parse(Console.ReadLine());

            Console.WriteLine(pb<db ? pb : db<pb? db: "jednaki su");



            // DZ: isto napraviti za tri broja

        }

    }
}
