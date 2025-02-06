using System;
using System.Collections.Generic;
using System.Linq;

using Ucenje.E20KonzolnaAplikacija.Model;

namespace Ucenje.E20KonzolnaAplikacija
{
    internal class ObradaGrupa
    {
        public List<Grupa> Grupe { get; set; }
        private Izbornik Izbornik;

        public ObradaGrupa()
        {
            Grupe = new List<Grupa>();
        }

        public ObradaGrupa(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        public void IspisiUkupanBrojGrupa()
        {
            Console.WriteLine($"Ukupan broj grupa: {Grupe.Count}");
        }

        private void UcitajTestnePodatke()
        {
            var polaznici = new List<Polaznik>();
            polaznici.Add(Izbornik.ObradaPolaznik.Polaznici[0]);
            polaznici.Add(Izbornik.ObradaPolaznik.Polaznici[1]);

            Grupe.Add(new Grupa()
            {
                Naziv = "Grupa 1",
                Smjer = Izbornik.ObradaSmjer.Smjerovi[0],
                Predavac = "Predavac 1",
                VelicinaGrupe = 10,
                Polaznici = polaznici
            });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Brisanje polaznika iz grupe");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiPolaznikaIzGrupe();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        public double IzracunajProsjecanBrojPolaznika()
        {
            if (Grupe == null || Grupe.Count == 0)
            {
                return 0; // Vraćamo 0 ako nema grupa da se izbjegne dijeljenje s nulom
            }

            int ukupnoPolaznika = 0;
            foreach (var grupa in Grupe)
            {
                if (grupa.Polaznici != null) // Provjeravamo liste polaznika
                {
                    ukupnoPolaznika += grupa.Polaznici.Count;
                }
            }

            return (double)ukupnoPolaznika / Grupe.Count;
        }

        private void ObrisiPolaznikaIzGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[Pomocno.UcitajRasponBroja("Odaberi redni broj grupe na kojoj će se brisati polaznici", 1, Grupe.Count) - 1];

            Izbornik.ObradaPolaznik.PrikaziPolaznike();

            var odabrani = g.Polaznici[Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika za brisanje", 1, g.Polaznici.Count) - 1];
            g.Polaznici.Remove(odabrani);
        }

        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupe[Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1];
            if (Pomocno.UcitajBool($"Sigurno obrisati {g.Naziv}? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1];

            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);

            Izbornik.ObradaSmjer.PrikaziSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.VelicinaGrupe = Pomocno.UcitajRasponBroja("Unesi veličinu grupe", 1, 30);

            g.Polaznici = UcitajPolaznike((int)g.VelicinaGrupe);
        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Grupe u aplikaciji");

            for (int i = 0; i < Grupe.Count; i++)
            {
                var g = Grupe[i];
                Console.WriteLine($"{i + 1}. {g.Naziv} ({g.Smjer?.Naziv}), {g.Polaznici.Count} polaznika");
                int rbp = 0;
                g.Polaznici.Sort();
                foreach (var p in g.Polaznici)
                {
                    Console.WriteLine($"\t{++rbp}. {p.Ime} {p.Prezime}");
                }
            }

            Console.WriteLine("*****************************");
        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true)
            };

            Izbornik.ObradaSmjer.PrikaziSmjerove();
            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[Pomocno.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.VelicinaGrupe = Pomocno.UcitajRasponBroja("Unesi veličinu grupe", 1, 30);

            g.Polaznici = UcitajPolaznike((int)g.VelicinaGrupe);

            Grupe.Add(g);
        }

        private List<Polaznik> UcitajPolaznike(int maksimalnoPolaznika)
        {
            List<Polaznik> lista = new List<Polaznik>();
            while (lista.Count < maksimalnoPolaznika && Pomocno.UcitajBool("Za unos polaznika unesi DA", "da"))
            {
                Izbornik.ObradaPolaznik.PrikaziPolaznike();
                Console.WriteLine($"{Izbornik.ObradaPolaznik.Polaznici.Count + 1}. Dodaj novog polaznika");
                var odabranaOpcija = Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika ili zadnji broj za dodavanje novog", 1,
                        Izbornik.ObradaPolaznik.Polaznici.Count + 1);

                if (odabranaOpcija == Izbornik.ObradaPolaznik.Polaznici.Count + 1)
                {
                    Izbornik.ObradaPolaznik.UnosNovogPolaznika();
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici.LastOrDefault());
                }
                else
                {
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici[odabranaOpcija - 1]);
                }
            }

            return lista;
        }
    }
}
