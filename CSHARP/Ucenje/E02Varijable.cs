using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Varijable
    {

        public static void Izvedi()
        {

            //Console.WriteLine("Unio si: E02");

            // Tipovi podataka

            int cijeliBroj = 1; // ovo je skraćeno kao da smo učitali od korisnika

            bool logickaVrijednost = true; // zadana vrijednost je false

            float decimalniBroj = 4.5f; // ako ne stavis "f" onda on misli da si definirao "double", "double" je duplo veci od "float-a"

            double velikiDecimalniBroj = 3.14;

            decimal decimalniBroj2 = 3.4M;

            char znak = '@'; //char je znak i to samo jedan znak, ako stavimo dva znaka, onda je greška

            string nizZnakova = "abcdefg"; // string je niz znakova a znak je ništa drugo nego broj

            Console.WriteLine("Znak je broj {0}", (int)znak); //(int) je cast, interpretiraj ga u taj broj znaka
            
            cijeliBroj = int.MaxValue;
            Console.WriteLine(cijeliBroj);

            Console.WriteLine(cijeliBroj + 1);
        }


    }
}
