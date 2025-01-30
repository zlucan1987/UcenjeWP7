using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ucenje
{
    class Q13LjubavniKalkulator
    {

        public static void Izvedi()
        {
            LjubavniKalkulator();
        }

        private static void ProvjeriRodImena(string ime, string imeVrsta)
        {
            string rod = "Nepoznato";
            if (ime.EndsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                rod = "Ženski";
            }
            else
            {
                rod = "Muški";
            }

            Console.WriteLine($"Ime {imeVrsta} je rod: {rod}");
        }

        private static bool ProvjeraSigurnostiImena(string ime, string imeVrsta)
        {
            string rod = "Nepoznato";

            if (ime.EndsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                rod = "Ženski";
            }
            else
            {
                rod = "Muški";
            }

            Console.WriteLine($"Ime {imeVrsta}: {ime} je prepoznato kao {rod}.");

            while (true)
            {
                Console.Write($"Jeste li sigurni da je ovo {rod} ime? (da/ne): ");
                string odgovor = Console.ReadLine().ToLower();

                if (odgovor == "da")
                {
                    return true;
                }
                else if (odgovor == "ne")
                {
                    Console.WriteLine("Pokušajte ponovo s ispravnim imenom.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite 'da' ili 'ne'.");
                }
            }
        }

        private static void LjubavniKalkulator()
        {
            string zenskoIme, muskoIme;

            while (true)
            {
                Console.Write("Unesite žensko ime (minimalno 3, maksimalno 15 slova): ");
                zenskoIme = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(zenskoIme))
                {
                    Console.WriteLine("Ime ne može biti prazno. Pokušajte ponovo.");
                    continue;
                }

                if (!Regex.IsMatch(zenskoIme, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Ime može sadržavati samo slova (mala i velika). Pokušajte ponovo.");
                    continue;
                }

                if (zenskoIme.Length < 3 || zenskoIme.Length > 15)
                {
                    Console.WriteLine("Ime mora imati između 3 i 15 slova. Pokušajte ponovo.");
                    continue;
                }

                if (!ProvjeraSigurnostiImena(zenskoIme, "žensko"))
                {
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("Unesite muško ime (minimalno 3, maksimalno 15 slova): ");
                muskoIme = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(muskoIme))
                {
                    Console.WriteLine("Ime ne može biti prazno. Pokušajte ponovo.");
                    continue;
                }

                if (!Regex.IsMatch(muskoIme, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Ime može sadržavati samo slova (mala i velika). Pokušajte ponovo.");
                    continue;
                }

                if (muskoIme.Length < 3 || muskoIme.Length > 15)
                {
                    Console.WriteLine("Ime mora imati između 3 i 15 slova. Pokušajte ponovo.");
                    continue;
                }

                if (!ProvjeraSigurnostiImena(muskoIme, "muško"))
                {
                    continue;
                }

                break;
            }

            List<char> kombiniranaLista = new List<char>();
            kombiniranaLista.AddRange(zenskoIme.ToLower());
            kombiniranaLista.AddRange(muskoIme.ToLower());

            List<(char, int)> brojnaListaZensko = new List<(char, int)>();
            foreach (char slovo in zenskoIme.ToLower())
            {
                brojnaListaZensko.Add((slovo, kombiniranaLista.Count(c => c == slovo)));
            }

            List<(char, int)> brojnaListaMusko = new List<(char, int)>();
            foreach (char slovo in muskoIme.ToLower())
            {
                brojnaListaMusko.Add((slovo, kombiniranaLista.Count(c => c == slovo)));
            }

            List<int> zbrojenaLista = new List<int>();
            int i = 0, j = brojnaListaMusko.Count - 1;

            while (i < brojnaListaZensko.Count && j >= 0)
            {
                zbrojenaLista.Add(brojnaListaZensko[i].Item2 + brojnaListaMusko[j].Item2);
                i++;
                j--;
            }

            while (i < brojnaListaZensko.Count)
            {
                zbrojenaLista.Add(brojnaListaZensko[i].Item2);
                i++;
            }

            while (j >= 0)
            {
                zbrojenaLista.Add(brojnaListaMusko[j].Item2);
                j--;
            }

            List<int> konacnaLista = new List<int>();
            i = 0;
            j = zbrojenaLista.Count - 1;

            while (i <= j)
            {
                int zbroj = 0;
                if (i == j)
                {
                    zbroj = zbrojenaLista[i];
                }
                else
                {
                    zbroj = zbrojenaLista[i] + zbrojenaLista[j];
                }

                if (zbroj >= 10)
                {
                    string zbrojStr = zbroj.ToString();
                    foreach (char cifra in zbrojStr)
                    {
                        konacnaLista.Add(cifra - '0');
                    }
                }
                else
                {
                    konacnaLista.Add(zbroj);
                }

                i++;
                j--;
            }

            List<int> finalnaLista = new List<int>();
            i = 0;
            j = konacnaLista.Count - 1;

            while (i <= j)
            {
                int zbroj = 0;
                if (i == j)
                {
                    zbroj = konacnaLista[i];
                }
                else
                {
                    zbroj = konacnaLista[i] + konacnaLista[j];
                }

                if (zbroj >= 10)
                {
                    string zbrojStr = zbroj.ToString();
                    foreach (char cifra in zbrojStr)
                    {
                        finalnaLista.Add(cifra - '0');
                    }
                }
                else
                {
                    finalnaLista.Add(zbroj);
                }

                i++;
                j--;
            }

            Console.WriteLine("Konačni rezultat ljubavnog kalkulatora je:");
            Console.WriteLine(string.Join("", finalnaLista));
        }

    } 
    
}





    

