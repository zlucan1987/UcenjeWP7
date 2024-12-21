using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class yDZ01Zadaca
    {
        // Program od korisnika traži unos tri cijela broja
        // Program ispisuje najmanji broj
        // Unos 6 i 1 i 5 -->  1
        // Unos 2 i 9 i 3 -->  2
        // Unos 5 i 5 i 5 --> Brojevi su jednaki

        public static void Izvedi()
        {

            Console.WriteLine("Unesi prvi broj: ");
            int pb = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int db = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi treći broj: ");
            int tb = int.Parse(Console.ReadLine());

            Console.WriteLine(pb < db ? pb : db < pb ? db : "Brojevi su jednaki");


            int najmanji = pb; // Pretpostavimo li da je prvi broj najmanji
            if (db < najmanji)
            {
                najmanji = db;
            }
            if (tb < najmanji)
            {
                najmanji = tb;
            }
        
             Console.WriteLine("Najmanji unešeni broj je: " + najmanji);

        }


    }
}
