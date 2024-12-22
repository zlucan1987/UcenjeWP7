using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Q07Vjezba
    {

        public static void Izvedi()
        {

            int i = 2, j = 3;
            int k = i + j;
            k = i - j;
            k = i * j;
            double t = k / j;
            bool b = k == j;
            b = k > j;
            b = k != j;
            bool p = true; b = false;
            b = p & b;
            b = p && b;

            Console.WriteLine("i={0}, k={1}", i, k);

        }

    }
}
