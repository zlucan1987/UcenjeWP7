namespace Ucenje
{
    // Ispis Fibonaccijevog niza: Napisi program koji od korisnika trazi da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0,1,1,2,3,5,8...)
    internal class Z05ZimskiZadaci
    {

        public static void Izvedi()
        {

            Console.WriteLine("Unesite broj elemenata Fibonaccijevog niza: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            Console.Write($"{a} {b}");
            for (int i = 2; i < n; i++)
            {
                int c = a + b; Console.Write($" {c} ");
                a = b;
                b = c;
            }
        }
    }
}
