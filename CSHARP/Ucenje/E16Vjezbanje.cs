using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16Vjezbanje
    {

        public static void Izvedi()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dobrodošli u vježbanje srijedom");
            Console.ResetColor();
            Izbornik();
            Console.WriteLine("Doviđenja!");
        }


        private static void Izbornik()
        {
            // OcistiKonzolu(); // Dodajemo poziv na funkciju za čišćenje konzole
            Console.WriteLine();
            Console.WriteLine("1. Za uneseni broj provjeri da li je parni ili ne?");
            Console.WriteLine("2. Riječ unazad");
            Console.WriteLine("3. Provjera sigurnosti lozinke");
            Console.WriteLine("4. Generator Lozinke");
            Console.WriteLine("5. Ljubavni kalkulator");
            Console.WriteLine("0. Izlaz iz aplikacije");
            OdabirOpcijeIzbornika();
        }
        //private static void OcistiKonzolu()
        //{
        //   Console.Clear();
        //}

        private static void OdabirOpcijeIzbornika()
        {
            bool izlazIzPrograma = false;
            while (!izlazIzPrograma)
            {
                switch (E14Metode.UcitajBroj("Odaberi opciju izbornika"))
                {
                    case 1:
                        ParnostBroja();
                        Izbornik();
                        break;
                    case 2:
                        RijecUnazad();
                        Izbornik();
                        break;
                    case 3:
                        ProvjeraSigurnostiLozinke();
                        Izbornik();
                        break;
                    case 4:
                        GeneratorLozinke();
                        Izbornik();
                        break;
                    case 5:
                        LjubavniKalkulator();
                        Izbornik();
                        break;
                    case 0:
                        izlazIzPrograma = true;
                        break;
                    default:
                        Console.WriteLine("Nije opcija izbornika");
                        break;
                }
            }
        }


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





        private static void GeneratorLozinke()
        {
            //1. korak ucitavanje duzine lozinke koju korisnik zeli
            int duzina = E14Metode.UcitajBroj("Unesi željenu dužinu lozinke: ");
            
            //2. korak ucitavanje broja lozinki koje zelimo generirati
            int brojLozinki = E14Metode.UcitajBroj("Unesi broj lozinki za generiranje: "); 
            
            //3. korak Skup znakova (definiranje uvjeta za lozinku i koje sve vrste znakova treba ukljuciti u generiranje)
            bool ukljuciVelikaSlova = true; // itd...
            bool ukljuciMalaSlova = true;
            bool ukljuciBrojevi = true;
            bool ukljuciSpecijalniZnakovi = true;
            
            //4. korak definicija razlicitih skupova znakova koji ce biti ukljuceni u random generiranje
            string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // ukljuci velika slova
            string malaSlova = "abcdefghijklmnopqrstuvwxyz"; // ukljuci mala slova itd...
            string brojevi = "0123456789";
            string specijalniZnakovi = "!@#$%^&*()_-+=[]{}|;:,.<>?";
            
            //5. korak stvori skup znakova na temelju zadanih uvjeta
            string dostupniZnakovi = "";
            if (ukljuciVelikaSlova) dostupniZnakovi += velikaSlova;
            if (ukljuciMalaSlova) dostupniZnakovi += malaSlova;
            if (ukljuciBrojevi) dostupniZnakovi += brojevi;
            if (ukljuciSpecijalniZnakovi) dostupniZnakovi += specijalniZnakovi;

            // 6. korak: Inicijaliziraj generator nasumičnih brojeva.
            Random random = new Random();


            // 7. korak: Generiraj traženi broj lozinki.
            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = ""; // pocetna prazna lozinka
                // 8. korak: Ponavljaj dok lozinka ne zadovolji uvjete.
                while (!ProvjeriLozinku(lozinka, duzina, ukljuciVelikaSlova, ukljuciMalaSlova, ukljuciBrojevi, ukljuciSpecijalniZnakovi))
                {
                    // Generiraj lozinku
                    lozinka = "";
                    // 9. korak dodavanje po jedan znak iz svake od ukljucenih kategorija
                    if (ukljuciVelikaSlova) lozinka += velikaSlova[random.Next(velikaSlova.Length)];
                    if (ukljuciMalaSlova) lozinka += malaSlova[random.Next(malaSlova.Length)];
                    if (ukljuciBrojevi) lozinka += brojevi[random.Next(brojevi.Length)];
                    if (ukljuciSpecijalniZnakovi) lozinka += specijalniZnakovi[random.Next(specijalniZnakovi.Length)];

                    // 10. korak: Popuni ostatak lozinke nasumičnim znakovima dok ne dosegne traženu dužinu.
                    while (lozinka.Length < duzina)
                    {
                        lozinka += dostupniZnakovi[random.Next(dostupniZnakovi.Length)];
                    }

                    // 11. korak: Promiješaj znakove unutar lozinke za dodatnu nasumičnost.
                    lozinka = new string(lozinka.OrderBy(c => random.Next()).ToArray());
                   
                    
                    // koristeno za debug xD 
                    // Console.WriteLine("Generirana lozinka: " + lozinka);
                    // Console.WriteLine("Zadovoljava uvjete: " + ProvjeriLozinku(lozinka, duzina, ukljuciVelikaSlova, ukljuciMalaSlova, ukljuciBrojevi, ukljuciSpecijalniZnakovi));
                }

                // 12. korak ispisuje generiranu lozinku
                Console.WriteLine("Random generirana lozinka: " + lozinka);
            }
        }
       

        private static bool ProvjeriLozinku(string lozinka, int duzina, bool ukljuciVelikaSlova, bool ukljuciMalaSlova, bool ukljuciBrojevi, bool ukljuciSpecijalniZnakovi)
        {
            // Provjera duljine
            if (lozinka.Length < duzina) return false;

            // Provjera svih postavljenih pravila
            if (ukljuciVelikaSlova && !lozinka.Any(char.IsUpper)) return false;
            if (ukljuciMalaSlova && !lozinka.Any(char.IsLower)) return false;
            if (ukljuciBrojevi && !lozinka.Any(char.IsDigit)) return false;
            if (ukljuciSpecijalniZnakovi && !lozinka.Any(c => !char.IsLetterOrDigit(c))) return false;

            // Provjera minimalnog broja različitih tipova znakova
            int brojTipovaZnakova = 0;
            brojTipovaZnakova += Regex.IsMatch(lozinka, "[A-Z]") ? 1 : 0;
            brojTipovaZnakova += Regex.IsMatch(lozinka, "[a-z]") ? 1 : 0;
            brojTipovaZnakova += Regex.IsMatch(lozinka, @"\d") ? 1 : 0;
            brojTipovaZnakova += Regex.IsMatch(lozinka, @"[!@#$%^&*()_+=\[\]{}|;:,.<>?]") ? 1 : 0;
            if (brojTipovaZnakova < 3) return false;

            // Provjera uzastopnih ponavljanja
            int maxPonavljanja = 2;
            char prethodniZnak = '\0';
            int brojPonavljanja = 1;
            foreach (char znak in lozinka)
            {
                if (znak == prethodniZnak)
                {
                    brojPonavljanja++;
                    if (brojPonavljanja > maxPonavljanja)
                        return false;
                }
                else
                {
                    brojPonavljanja = 1;
                }
                prethodniZnak = znak;
            }
            
            return true;
        }

        private static void ProvjeraSigurnostiLozinke()
            {
            NaslovPrograma("Program za unesenu lozinku ispisuje da li je: dobra, loša ili zla");
            string lozinka = E14Metode.UcitajString("Unesi svoju lozinku za provjeru", "Obavezan unos");
            // maskiranje u subotu https://stackoverflow.com/questions/3404421/password-masking-console-application

            int razina = 0;

            if (lozinka.Length >= 8)
            {
                razina++;
            }
            // imaš broj u sebi
            razina += ProvjeraLozinka(lozinka, 48, 57);

            // imaš mali znak u sebi
            razina += ProvjeraLozinka(lozinka, 97, 122);

            // imaš veliki znak u sebi
            razina += ProvjeraLozinka(lozinka, 65, 90);

            // interpukcijski znakovi
            razina += (ProvjeraLozinka(lozinka, 33, 47)
                + ProvjeraLozinka(lozinka, 58, 63)
                + ProvjeraLozinka(lozinka, 123, 126)) > 0 ? 1 : 0;

            Console.WriteLine(razina);

        }

        private static int ProvjeraLozinka(string lozinka, int v1, int v2)
        {
            foreach (char z in lozinka)
            {
                if (z >= v1 && z <= v2)
                {
                    return 1;
                }
            }
            return 0;
        }

        private static void RijecUnazad()
        {
            NaslovPrograma("Program za unesenu riječ ispisuje istu unazad.");
            string unos = E14Metode.UcitajString("Unesi riječ", "Nisi unio riječ");
            for (int i = unos.Length - 1; i >= 0; i--)
            {
                Console.Write(unos[i]);
            }
            Console.WriteLine();
        }

        private static char z = '-';

        private static void NaslovPrograma(string v)
        {
            Linija(v.Length + 6);
            Console.WriteLine("{0}{1} {2} {3}{4}", z, z, v, z, z);
            Linija(v.Length + 6);
        }

        private static void Linija(int v)
        {
            for (int i = 0; i < v; i++)
            {
                Console.Write(z); // ovaj ostaje u istom redu
            }
            Console.WriteLine(); // ovaj ode u novi red
        }

        private static void ParnostBroja()
        {
            NaslovPrograma("Program za uneseni broj ispisuje da li je paran ili ne.");
            int broj = E14Metode.UcitajBroj("Unesi cijeli broj za provjeru", 1, 100);
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je paran", broj);
            }
            else
            {
                Console.WriteLine("Broj {0} je neparan", broj);
            }
            Console.WriteLine("-- Kraj programa provjere parnosti broja --"); // i ovo bi se dalo izvući u metodu
        }
    }
}