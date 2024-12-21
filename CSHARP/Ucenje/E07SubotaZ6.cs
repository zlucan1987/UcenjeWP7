using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program unosi ime osobe
    // s najmanjom mogucnoscu greske program ispsiuje dali je osoba muskog ili zenskog spola


    internal class E07SubotaZ6
    {

        public static void Izvedi()
        {

            Console.WriteLine("Unesi ime osobe: ");
            Console.WriteLine(Console.ReadLine().ToLower()[^1] =='a' ? "Žensko" : "Muško");

        }

    }
}
