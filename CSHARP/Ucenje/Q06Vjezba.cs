using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    //Program unosi ime osobe
    //S najmanjom mogučnošću greške program ispisuje da li je osoba muškog ili ženskog spola

    internal class Q06Vjezba
    {

        public static void Izvedi()
        {
            Console.Write("Unesi ime: ");
            string ime= Console.ReadLine();
            ime = ime.ToLower();
            
            if (ime[ ime.Length-1] == 'a')
            {
                Console.WriteLine("Žensko");
            }

            else 
            {
                Console.WriteLine("Muško");
            }


            //Console.WriteLine(Console.ReadLine()[^1]=='a' ? "Žensko" : "Muško");

        }


    }
}
