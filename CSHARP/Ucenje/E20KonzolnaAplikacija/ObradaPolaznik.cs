using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using Ucenje.E20KonzolnaAplikacija.Model;

namespace Ucenje.E20KonzolnaAplikacija
{
    internal class ObradaPolaznik
    {
        public List<Polaznik> Polaznici { get; set; }

        public ObradaPolaznik()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Polaznici = new List<Polaznik>();

            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            var faker = new Faker();
            for (int i = 0; i < 10; i++)
            {
                Polaznici.Add(new Polaznik
                {
                    Sifra = i + 1,
                    Ime = faker.Name.FirstName(),
                    Prezime = faker.Name.LastName()
                });
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s polaznicima");
            Console.WriteLine("1. Pregled svih polaznika");
            Console.WriteLine("2. Unos novog polaznika");
            Console.WriteLine("3. Promjena podataka postojećeg polaznika");
            Console.WriteLine("4. Brisanje polaznika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            Console.WriteLine("6. Ukupan broj polaznika");
            Console.WriteLine("7. Izračunaj prosječan broj polaznika");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 7))
            {
                case 1:
                    Console.Clear();
                    PrikaziPolaznike(); // Prikaz polaznika
                    PrikaziIzbornik(); // Povratak na izbornik za polaznike
                    break;
                case 2:
                    Console.Clear();
                    UnosNovogPolaznika();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    PromjeniPodatakPolaznika();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.Clear();
                    ObrisiPolaznika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break; // Povratak na glavni izbornik
                case 6:
                    Console.Clear();
                    IspisiUkupanBrojPolaznika();
                    PrikaziIzbornik();
                    break;
                case 7:
                    Console.Clear();
                    // Izračun prosječnog broja polaznika po grupi
                    // ... (kod za izračun prosjeka)
                    PrikaziIzbornik();
                    break;
            }
        }

        public void IspisiUkupanBrojPolaznika()
        {
            if (Polaznici.Count == 0)
            {
                Console.WriteLine("Nema polaznika u sustavu.");
            }
            else
            {
                Console.WriteLine($"Ukupan broj polaznika: {Polaznici.Count}");
            }
        }

        private void ObrisiPolaznika()
        {
            PrikaziPolaznike();
            if (Polaznici.Count == 0)
            {
                Console.WriteLine("Nema polaznika u sustavu.");
                return;
            }

            try
            {
                var odabrani = Polaznici[Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika za brisanje", 1, Polaznici.Count) - 1];

                if (Pomocno.UcitajBool($"Sigurno obrisati {odabrani.Ime} {odabrani.Prezime}? (DA/NE)", "da"))
                {
                    Polaznici.Remove(odabrani);
                    Console.WriteLine("Polaznik uspješno obrisan.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Neispravan unos. Molimo pokušajte ponovno.");
                ObrisiPolaznika(); // Ponovi brisanje
            }
        }

        public void PrikaziPolaznike()
        {
            if (Polaznici.Count == 0)
            {
                Console.WriteLine("Nema unesenih polaznika.");
                return;
            }

            Console.WriteLine("*****************************");
            Console.WriteLine("Popis polaznika u aplikaciji");
            int rb = 0;
            foreach (var p in Polaznici)
            {
                Console.WriteLine($"{++rb}. {p.Ime} {p.Prezime}");
            }
            Console.WriteLine("*****************************");
        }

        public void UnosNovogPolaznika()
        {
            // ... (isti kod kao prije)
        }

        private string PromjeniPolje(string currentValue, string fieldName)
        {
            while (true)
            {
                var newValue = Pomocno.UcitajString($"Unesi novi {fieldName} polaznika (Enter za preskakanje):", 50, false);
                if (string.IsNullOrEmpty(newValue) || !string.IsNullOrWhiteSpace(newValue))
                {
                    return string.IsNullOrEmpty(newValue) ? currentValue : newValue;
                }
                else
                {
                    Console.WriteLine($"Neispravan unos {fieldName}. Molimo pokušajte ponovno.");
                }
            }
        }

        private void PromjeniPodatakPolaznika()
        {
            PrikaziPolaznike();
            if (Polaznici.Count == 0)
            {
                Console.WriteLine("Nema polaznika za promjenu.");
                return;
            }

            try
            {
                var odabrani = Polaznici[Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika za promjenu", 1, Polaznici.Count) - 1];

                odabrani.Ime = PromjeniPolje(odabrani.Ime, "ime");
                odabrani.Prezime = PromjeniPolje(odabrani.Prezime, "prezime");
                odabrani.Email = PromjeniPolje(odabrani.Email, "email");
                odabrani.OIB = PromjeniPolje(odabrani.OIB, "OIB");

                Console.WriteLine("Podaci polaznika uspješno promijenjeni.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Neispravan unos. Molimo pokušajte ponovno.");
                PromjeniPodatakPolaznika(); // Ponovi promjenu
            }
        }
    }
}