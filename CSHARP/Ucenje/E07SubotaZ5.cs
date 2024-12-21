using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Ucenje
{
    internal class E07SubotaZ5


    {

        public static void Izvedi()
        {

            Console.WriteLine("Unesi cijeli broj od 1 do 7: ");
            string dan = Console.ReadLine();

            switch (dan)
            {
                case "Ponedjeljak":
                    Console.WriteLine("Ponedjeljak");
                    break;
                case "Utorak":
                    Console.WriteLine("Utorak");
                    break;
                case "Srijeda":
                    Console.WriteLine("Srijeda");
                    break;
                case "Četvrtak":
                    Console.WriteLine("Četvrtak");
                    break;
                case "Petak":
                    Console.WriteLine("Petak");
                        break;


            };



        }

        
    }
}
