using System;

namespace Ucenje
{
    internal class Q09Vjezba
    {

        public static void Main(string[] args)
        {

            static int ZbrojZnamenki(int broj)
            {
                int zbroj = 0;
                while (broj > 0)
                {
                    zbroj += broj % 10;
                    broj /= 10;
                }
                return zbroj;
            }
            Console.Write("Unesite cijeli broj: ");
            if (int.TryParse(Console.ReadLine(), out int broj))
            {
                int rezultat = broj * 9;
                Console.WriteLine("Rezultat množenja s 9 je: " + rezultat);

                int zbrojZnamenki = ZbrojZnamenki(rezultat);
                Console.WriteLine("Zbroj znamenki rezultata je: " + zbrojZnamenki);

                while (zbrojZnamenki > 9)
                {
                    zbrojZnamenki = ZbrojZnamenki(zbrojZnamenki);
                }

                Console.WriteLine("Konačni zbroj znamenki je: " + zbrojZnamenki);
            }
            else
            {
                Console.WriteLine("Niste unijeli cijeli broj.");
            }
        }
    }
}