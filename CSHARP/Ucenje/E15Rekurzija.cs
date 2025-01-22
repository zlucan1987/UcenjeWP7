﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15Rekurzija
    {

        public static void Izvedi()
        {

            Console.WriteLine("E15");
            //Rekurzija();

            Console.WriteLine(Zbroji(100));
        }

        // rekurzija je kada metoda zove samu sebe uz uvjet prekida rekurzije

        private static void Rekurzija() // ovo nije primjer rekurzije jer nema uvjeta prekida
        {

            Rekurzija();

        }

        public static int Zbroji(int broj)
        {
            if (broj == 1) // uvjet prekida rekurzije
            {
                return 1;
            }
            return broj + Zbroji(broj - 1); // u rekurziji operacije se odradjuju u povratku (slika ima u materijalima)
            
        }


    }
}
