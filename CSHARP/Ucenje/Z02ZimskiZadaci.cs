namespace Ucenje
{
    // 02. Provjera dali je broj pozitivan, negativan ili nula: Napisi program koji od korisnika trazi da unese broj i ispisuje je li broj pozitivan, negativan ili nula.

    internal class Z02ZimskiZadaci
    {

        public static void Izvedi()
        {
            // Deklaracija varijable za unos broja
            int broj;

            // Unosi podatke od korisnika
            Console.Write("Unesite broj: ");
            broj = Convert.ToInt32(Console.ReadLine());

            // Provjera i ispis rezultata

            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan. ");
            }
            if (broj < 0)
            {

                Console.WriteLine("Broj je negativan. ");
            }
            else
            {           
               Console.WriteLine("Broj je nula. ");
            }



        }

    }
}
