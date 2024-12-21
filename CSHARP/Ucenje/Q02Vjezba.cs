using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Q02Vjezba
    {

        //Console.WriteLine("Q02");

        // za učitani cijeli broj između 10 i 99 ispiši jediničnu vrijednost
        // 55 -> 6
        // 82 -> 2

        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj između 10 i 99: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj % 10);               //ispisati će samo zadnju unesenu znamenju npr: 25, ispisati će 5...etc

            Console.Write("Ponovi unos: ");
            Console.WriteLine(Console.ReadLine()[1]);
            
            //Console.WriteLine(broj / 10); // a ovako ćemo ispisati prvu znamenku iz int


        }


    }
}
