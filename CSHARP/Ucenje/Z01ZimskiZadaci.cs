namespace Ucenje // Ovo definira prostor nas program
{
    // 01. Izracun povrsine pravokutnika: Napisi program koji od korisnika trazi da unese duljinu i sirinu pravokutnika, a zatim izracunava i ispisuje povrsinu pravokutnika.

    internal class Z01ZimskiZadaci
    {
        public static void Izvedi(string[] args)
        {
            // Unos varijabli za duljinu, sirinu i povrsinu
            double duljina, sirina, povrsina;                   // varijabla double se koristi za realne brojeve

            // Unos podataka od korisnika
            Console.Write("Unesite duljinu pravokutnika: ");
            duljina= Convert.ToDouble(Console.ReadLine());      // Convert.ToDouble korsitimo kako bi uneseni broj pretvorili u double

            Console.Write("Unesite sirinu pravokutnika: ");
            sirina= Convert.ToDouble(Console.ReadLine());

            // Izracun povrsine
            povrsina = duljina * sirina;

            // Ispis rezultata
            Console.WriteLine("Povrsina pravokutnika je: " + povrsina);
        }
    }
}
