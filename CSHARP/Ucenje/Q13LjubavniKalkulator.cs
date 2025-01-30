using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class Q13LjubavniKalkulator
    {

        private static void LjubavniKalkulator()
        {
            // 1. Unos imena
            Console.Write("Unesite žensko ime: ");
            string zenskoIme = Console.ReadLine();

            Console.Write("Unesite muško ime: ");
            string muskoIme = Console.ReadLine();

            // 2. Kombiniranje slova
            List<char> kombinovanaLista = new List<char>();
            kombinovanaLista.AddRange(zenskoIme);
            kombinovanaLista.AddRange(muskoIme);

            // 3. Brojanje slova u ženskom imenu
            List<(char, int)> brojanaListaZensko = new List<(char, int)>();
            foreach (char slovo in zenskoIme)
            {
                brojanaListaZensko.Add((slovo, kombinovanaLista.Count(c => c == slovo)));
            }

            // 4. Brojanje slova u muškom imenu
            List<(char, int)> brojanaListaMusko = new List<(char, int)>();
            foreach (char slovo in muskoIme)
            {
                brojanaListaMusko.Add((slovo, kombinovanaLista.Count(c => c == slovo)));
            }

            // 5. Kombiniranje prebrojanih slova
            List<(char, int)> kombinovanaBrojanaLista = new List<(char, int)>();
            kombinovanaBrojanaLista.AddRange(brojanaListaZensko);
            kombinovanaBrojanaLista.AddRange(brojanaListaMusko);

            // 6. Zbrajanje vrijednosti (prvi prolaz)
            List<int> zbrojenaLista = new List<int>();
            int i = 0, j = brojanaListaMusko.Count - 1;

            while (i < brojanaListaZensko.Count && j >= 0)
            {
                zbrojenaLista.Add(brojanaListaZensko[i].Item2 + brojanaListaMusko[j].Item2);
                i++;
                j--;
            }

            // Ako postoji neparan broj elemenata, prepisujemo ga
            while (i < brojanaListaZensko.Count)
            {
                zbrojenaLista.Add(brojanaListaZensko[i].Item2);
                i++;
            }

            while (j >= 0)
            {
                zbrojenaLista.Add(brojanaListaMusko[j].Item2);
                j--;
            }

            // 7. Kreiranje nove liste sa zbrojenim vrijednostima zbrojene liste
            List<int> konacnaLista = new List<int>();
            i = 0;
            j = zbrojenaLista.Count - 1;

            while (i <= j) // Petlja ide do sredine liste (uključujući srednji element ako postoji)
            {
                int zbroj = 0;
                if (i == j) // Ako smo na srednjem elementu (neparan broj elemenata)
                {
                    zbroj = zbrojenaLista[i];
                }
                else
                {
                    zbroj = zbrojenaLista[i] + zbrojenaLista[j];
                }

                // Razdvajanje dvoznamenkastih brojeva
                if (zbroj >= 10)
                {
                    string zbrojStr = zbroj.ToString();
                    foreach (char cifra in zbrojStr)
                    {
                        konacnaLista.Add(cifra - '0'); // Pretvaramo char u int
                    }
                }
                else
                {
                    konacnaLista.Add(zbroj);
                }

                i++;
                j--;
            }

            // 8. Konačni rezultat ljubavnog kalkulatora
            List<int> finalnaLista = new List<int>();
            i = 0;
            j = konacnaLista.Count - 1;

            while (i <= j) // Petlja ide do sredine liste (uključujući srednji element ako postoji)
            {
                int zbroj = 0;
                if (i == j) // Ako smo na srednjem elementu (neparan broj elemenata)
                {
                    zbroj = konacnaLista[i];
                }
                else
                {
                    zbroj = konacnaLista[i] + konacnaLista[j];
                }

                // Razdvajanje dvoznamenkastih brojeva
                if (zbroj >= 10)
                {
                    string zbrojStr = zbroj.ToString();
                    foreach (char cifra in zbrojStr)
                    {
                        finalnaLista.Add(cifra - '0'); // Pretvaramo char u int
                    }
                }
                else
                {
                    finalnaLista.Add(zbroj);
                }

                i++;
                j--;
            }

            // 9. Spajanje znamenki konačnog rezultata (ako je dvoznamenkast)
            string ljubavniRezultatString = "";
            foreach (int cifra in finalnaLista)
            {
                ljubavniRezultatString += cifra.ToString();
            }

            int ljubavniRezultat = int.Parse(ljubavniRezultatString);


            // 10. Ispis rezultata
            Console.WriteLine("\nBroj slova iz oba imena (računato u ženskom imenu):");
            foreach (var item in brojanaListaZensko)
            {
                Console.WriteLine($"Slovo '{item.Item1}' pojavljuje se {item.Item2} puta.");
            }

            Console.WriteLine("\nBroj slova iz oba imena (računato u muškom imenu):");
            foreach (var item in brojanaListaMusko)
            {
                Console.WriteLine($"Slovo '{item.Item1}' pojavljuje se {item.Item2} puta.");
            }

            Console.WriteLine("\nKombinovana lista svih prebrojanih slova:");
            foreach (var item in kombinovanaBrojanaLista)
            {
                Console.WriteLine($"Slovo '{item.Item1}' pojavljuje se {item.Item2} puta.");
            }

            Console.WriteLine("\nLista zbrojenih vrijednosti (prvi prolaz):");
            foreach (var value in zbrojenaLista)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nKonačna lista zbrojenih vrijednosti (drugi prolaz):");
            foreach (var value in konacnaLista)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nFinalna lista zbrojenih vrijednosti (treći prolaz):");
            foreach (var value in finalnaLista)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"\nRezultat ljubavnog kalkulatora je: {ljubavniRezultat} %");
        }
    }
}


    

