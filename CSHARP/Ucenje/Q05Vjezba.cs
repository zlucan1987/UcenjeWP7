using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    /*
     * Program učitava od korisnika ime grada. U ovisnosti o imenu grada ispisuje regiju prema sljedečim pravilima: 
     * Osijek - Slavonija
     * Zadar - Dalmacija
     * Čakovec - Međimurje 
     * Pula - Istra
     */
    internal class Q05Vjezba
    {
        public static void Izvedi() 
        {
            Console.Write("Unesi ime grada: ");
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

            }
            // Naprednija switch case sintaksa

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
