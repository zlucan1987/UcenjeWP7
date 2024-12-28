
namespace Ucenje
{

    // 03. Zbroj elemenata niza: Napisi program koji deklarira niz cijelih brojeva, trazi od korisnika da unese vrijednosti u niz, a zatim izracunava i ispisuje zbroj svih elemenata niza.

    internal class Z03ZimskiZadaci
    {

        public static void Izvedi()
        {
            // Deklaracija varijabli
            int[] niz;                      // Varijabla "niz" je deklarirana kao niz cijelih brojeva u koji ce se pohraniti uneseni elementi
            int n, Zbroj = 0;               // Varijabla "n" je broj elemenata niza
                                            // Varijabla "zbroj" je zbroj elemenata niza koja je po defaultu postavljena na 0="nulu"

            // Unos elemenata niza
            Console.Write("Unesite broj elemenata niza: ");
            n = Convert.ToInt32(Console.ReadLine());        // Zasto koristim Convert.ToInt32?? Ova metoda pretvara tekst(string) i pokusava ga pretvoriti u cijeli broj(int). Ako korisnik unese npr "abc" doci ce do pogreske.

            // Kreiranje niza
            niz = new int[n];

            // Unos elemenata niza
            Console.WriteLine("Unesite elemente niza: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i+1);
                niz[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Izracun zbroja elemenata niza
            foreach (int broj in niz) 
            {

                Zbroj += broj;
            
            }

            // Ispis rezultata
            Console.WriteLine("Zbroj elemenata niza je: " + Zbroj);
        }

    }
}
