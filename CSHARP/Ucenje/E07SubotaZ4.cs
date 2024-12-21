using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07SubotaZ4
    {
        /* Program ucitava od korisnika ime Grada. U ovisnosti o imenu grada ispisuje regiju prema sljedecim pravilima:


            Osijek--> Slavonija
            Zadar --> Dalmacija
            Čakovec --> Međimurje
            Pula --> Istra 
            Za ostale unose program ispisuje: Ne znam koja je to regija.


            */
        public static void Izvedi()
        {
            Console.Write("Upiši ime grada: ");
            string grad = Console.ReadLine();


            switch (grad)
            {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
                case "Čakovec":
                    Console.WriteLine("Međimurje");
                    break;
                case "Pula":
                    Console.WriteLine("Istra");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija.");
                    break;
            }


            // naprednija switch case sintaksa
            string regija = grad switch
            {
                "Osijek" => "Slavonija",
                "Zadar" => "Dalmacija",
                "Čakovec" => "Međimurje",
                "Pula" => "Istra",
                _ => "Ne znam koja je to regija."
            };

            Console.WriteLine(regija);

        }


    }
}