namespace Ucenje
{
    internal class Q10VjezbaPrimjer1
    {
        public static void Main()
        {
            do
            {
                int number = GetPositiveInteger();

                number *= 9;
                Console.WriteLine($"Broj nakon množenja s 9: {number}");

                int steps = 0;

                while (number >= 10)
                {
                    number = SumDigits(number);
                    steps++;
                    Console.WriteLine($"Korak {steps}: Rezultat nakon zbrajanja znamenki: {number}");
                }

                Console.WriteLine($"Konačni broj znamenki je: {number}");
                Console.WriteLine($"Ukupno koraka do jedne znamenke: {steps}");

                if (!AskToContinue())
                    break;

            } while (true);
        }
        private static int GetPositiveInteger()
        {
            while (true)
            {
                Console.Write("Unesite cijeli pozitivan broj: ");

                if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
                {
                    return number;
                }

                Console.WriteLine("Pogrešan unos! Molimo unesite cijeli pozitivan broj.");
            }
        }
        private static int SumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        private static bool AskToContinue()
        {
            Console.WriteLine("Za prekid aplikacije unesite 'Q', za nastavak bilo što drugo.");
            string? option = Console.ReadLine()?.Trim().ToLower();
            return option != "q";
        }
    }
}