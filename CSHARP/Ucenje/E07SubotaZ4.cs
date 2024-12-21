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
            // Console.WriteLine("z4");

            Console.WriteLine("Upisi ime grada: ");
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
                case "Pula":
                    Console.WriteLine("Istra");
                    break;

                    // naprednija witch case sintaksa
                    string regija = grad switch
                    {

                        "Osijek" => "Slavonija",
                        "Zadar" => "Dalmacija",
                        "Čakovec" => "Međimurje",
                        "Pula" => "Istra",
                        _ => "Ne znam koja je to regija"
                    };

            }


        }


    }
}
