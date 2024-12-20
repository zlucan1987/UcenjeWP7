using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06Nizovi
    {

        public static void Izvedi()
        {

            //Console.WriteLine("E06");

            // motivacija treba pohraniti prosječne temperature u 12 mjeseci
            // krivi pristup
            int sijecanj, veljaca, ozujak, /*...*/ prosinac; // NE RADITI 12 VARIJABLI

            // end. Arrays
            // još na HR polja
            // uglata zagrada ALT GR + F, zatvoreno je ALT Gr + G
            //
            // Jednodimentionalni niz

            int[] temp = new int[12]; // glavni problem nizova što u trenutku kreiranja moraš znati koliko elemanata
            // niz ima index i vrijednost
            temp[0] = -1; // siječanj
            temp[1] = 1; // veljača
            //...
            temp[11] = 4; // prosinac

            Console.WriteLine(temp[0]);
            Console.WriteLine(temp);
            // ispisivanje svih elemenata niza
            Console.WriteLine(string.Join(",", temp));

            // dvodimenzionalni niz - tablica
            int[,] tablica =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}

            };
            Console.WriteLine(tablica[1,2]);

            // trodimenzionalni niz
            int[,,] kocka = new int[10, 10, 10];
            kocka[5, 5, 5] = 27; // primjer

            //četverodimenzionalni niz - tesaarect
            //multiverse
            int[,,,,,,,] multiverse;

            // zašto nam je bitan jednodimenzionalni niz
            string grad = "Osijek"; //O=[0], S=[1], i=[2], J=[3], E=[4], K=[5]
            // ispiši slovo j
            // string je niz znakova

            Console.WriteLine(grad[3]);

            char znak = 'A';

            // ispišite zadnji znak

            Console.WriteLine(grad[grad.Length-1]); // na ovaj nacin dobijemo zadnje slovo u nizu od grada "Osijek"
            



        }

    }
}
