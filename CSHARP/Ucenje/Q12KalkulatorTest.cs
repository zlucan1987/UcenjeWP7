using System;

class Q12KalkulatorTest
{
    public static void Izvedi()
    {
        bool nastavi = true;

        while (nastavi)
        {
            Console.Clear(); // Čisti ekran za svaki novi ciklus
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Odaberite opciju:");
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Oduzimanje");
            Console.WriteLine("3. Množenje");
            Console.WriteLine("4. Dijeljenje");
            Console.WriteLine("5. Izlaz");

            // Provjera odabira korisnika
            int izbor;
            bool ispravanIzbor = int.TryParse(Console.ReadLine(), out izbor);

            if (!ispravanIzbor || izbor < 1 || izbor > 5)
            {
                Console.WriteLine("Nevažeći odabir. Pokušajte ponovo.");
                continue; // Ako je unos neispravan, vraća se na početak
            }

            if (izbor == 5)
            {
                Console.WriteLine("Zadovoljstvo nam je bilo pomoći. Izlazim...");
                break; // Ako korisnik odabere izlaz, izlazimo iz programa
            }

            // Unos dva broja za izabranu operaciju
            int broj1 = UnosBroja("Unesite prvi broj: ");
            int broj2 = UnosBroja("Unesite drugi broj: ");

            // Izvođenje odgovarajuće operacije
            switch (izbor)
            {
                case 1:
                    Console.WriteLine($"Rezultat zbrajanja: {broj1 + broj2}");
                    break;
                case 2:
                    Console.WriteLine($"Rezultat oduzimanja: {broj1 - broj2}");
                    break;
                case 3:
                    Console.WriteLine($"Rezultat množenja: {broj1 * broj2}");
                    break;
                case 4:
                    if (broj2 == 0)
                    {
                        Console.WriteLine("Greška: Dijeljenje s nulom nije dozvoljeno!");
                    }
                    else
                    {
                        Console.WriteLine($"Rezultat dijeljenja: {broj1 / (double)broj2}");
                    }
                    break;
            }

            // Pitanje korisniku želi li nastaviti
            Console.WriteLine("\nŽelite li nastaviti? (da/ne)");
            string odgovor = Console.ReadLine().ToLower();
            if (odgovor != "da")
            {
                nastavi = false; // Ako korisnik ne želi nastaviti, izlazimo iz petlje
            }
        }
    }

    // Metoda za unos broja, koja provjerava je li unos cijeli broj
    static int UnosBroja(string poruka)
    {
        int broj;
        while (true)
        {
            Console.Write(poruka);
            bool ispravanUnos = int.TryParse(Console.ReadLine(), out broj);
            if (ispravanUnos)
            {
                return broj;
            }
            else
            {
                Console.WriteLine("Neispravan unos. Molimo unesite cijeli broj.");
            }
        }
    }
}
