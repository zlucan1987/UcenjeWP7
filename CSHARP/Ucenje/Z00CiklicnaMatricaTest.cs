using System;

class Z00CiklicnaMatricaTest
{
    public static void Izvedi()
    {
        int redovi, stupci; // deklariramo broj redova i stupaca
        // unos broj redaka i stupaca sa provjerom 
        do
        {
            Console.Write("Unesite broj redaka (1-20): ");
        } while (!int.TryParse(Console.ReadLine(), out redovi) || redovi < 1 || redovi > 20); // min 1 max 20 redaka

        do
        {
            Console.Write("Unesite broj stupaca (1-20): ");
        } while (!int.TryParse(Console.ReadLine(), out stupci) || stupci < 1 || stupci > 20); // min 1 max 20 stupaca


        // Kreiranje matrice 
        int[,] matrica = new int[redovi, stupci];
        PopuniCiklicno(matrica, redovi, stupci);// poziv na popunjavanje matrice
        IspisMatrice(matrica); // poziv na ispis matrice na cmd
    }


    // Metoda za popunjavanje matrice u spiralnom obliku ili u ovom slucaju ciklicnom obliku
    static void PopuniCiklicno(int[,] matrica, int redaka, int stupaca)
    {
        int num = 1;  // brojac popunjavanja matrice
        int lijevo = 0, desno = stupaca - 1, gore = 0, dolje = redaka - 1; // granice za ciklicno popunjavanje
        int smjer = 0; // 0: lijevo, 1: gore, 2: desno, 3: dolje


        // pocetna pozicija u doljnjem desnom kutu
        int i = dolje, j = desno;
        // Petlja se ne zavrsava dok se sva polja matrice ne popune
        while (num <= redaka * stupaca)
        {
            matrica[i, j] = num++; // ovdje upisuje trenutni broj u matricu


            // objasnjavanje smjera i pozicije
            if (smjer == 0) // lijevo
            {
                if (j > lijevo)
                    j--;
                else
                {
                    smjer = 1; // promjena smjera na gore
                    dolje--;
                    i--;
                }
            }
            else if (smjer == 1) // gore
            {
                if (i > gore)
                    i--;
                else
                {
                    smjer = 2; // promjena smjera na desno
                    lijevo++;
                    j++;
                }
            }
            else if (smjer == 2) // desno
            {
                if (j < desno)
                    j++;
                else
                {
                    smjer = 3; // promjena smjera na dolje
                    gore++;
                    i++;
                }
            }
            else if (smjer == 3) // dolje
            {
                if (i < dolje)
                    i++;
                else
                {
                    smjer = 0; // Promjena smjera na lijevo
                    desno--;
                    j--;
                }
            }
        }
    }

    // Ovu metodu smo istrazili i iskoristili na ovaj nacin. Podsjetnik: Metoda za ispis matrice u cmd
    static void IspisMatrice(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) // iteracija po redovima
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // iteracija po stupcima
            {
                // ispis elemenata matrice sa formiranjem za bolji pregled
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine(); // i klasika, prelazak u novi red nakon svakog reda.
        }
    }
}
