namespace Ucenje
{
    // Prosjek ocjena: Napisi program koji od korisnika trazi da unese broj ocjena, a zatim i same ocjene. Program treba izracunati i ispisati prosjek ocjena.

    internal class Z04ZimskiZadaci
    {

        public static void Izvedi()
        {
            // Deklaracija varijabli
            int brojOcjena;
            double zbroj = 0, prosjek;

            // Unos broja ocjena
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Unesite broj ocjena: ");
            brojOcjena = Convert.ToInt32(Console.ReadLine());

            // Provjera dali je broj veci od "0"
            if (brojOcjena <= 0)
            {
                Console.WriteLine("Broj ocjena mora biti veci od 0. ");
                return;

            }

            // Unos ocjena i izracun zbroja
            double[] ocjene = new double[brojOcjena];
            for (int i = 0; i < brojOcjena; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unesite ocjenu {0}:", i +1);
                ocjene[i] = Convert.ToDouble(Console.ReadLine());
                zbroj += ocjene[i];

            }

            // Izracun prosjeka
            prosjek = zbroj / brojOcjena;
            // Ispis rezultata
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Prosjek ocjena je: " + prosjek);




            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Pritisnite 'Q' za izlazak.");

                while (Console.ReadKey().Key != ConsoleKey.Q) ;

                Console.WriteLine("\nProgram je završen.");
            }

        }

    }
}
