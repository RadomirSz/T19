namespace Zadanie2
{
    internal class Program
    {
        private static Dictionary<int, int[]> fibonacciNumbers = new() { { 0, [0, 0] }, { 1, [1, 0] }};
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                int n = getValidInt(5,30);
                fibonacci(n-1);

                int licznik = 0;
                Console.WriteLine($"Ciąg Fibonacciego ({n} wyrazów):");
                for (int i = 0; i < n; i++)
                {
                    string line = $"F({i}) = {fibonacciNumbers[i][0]}";
                    if(fibonacciNumbers[i][1] == 1)
                    {
                        line += " [PIERWSZA]";
                        licznik++;
                    }
                    Console.WriteLine(line);
                }

                Console.WriteLine("===STATYSTYKI===");
                Console.WriteLine($"Liczb pierwszych: {licznik}/{n} ({(float)licznik/n * 100})%");

                Console.WriteLine("\nCzy chcesz wygenerować kolejny ciąg? (t/n): ");
                string input = Console.ReadLine();
                if (input == "n") run = false;
            }
        }
        private static int fibonacci(int n)
        {
            if (fibonacciNumbers.TryGetValue(n, out var fibonacciNum)) return fibonacciNum[0];
            int a = fibonacci(n - 1) + fibonacci(n - 2);
            fibonacciNumbers[n] = [a,isPrime(a)];
            return a;
        }
        private static int isPrime(int n)
        {
            if (n < 2) return 0;
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0) return 0;
            return 1;
        }
        private static int getValidInt(int v1, int v2)
        {
            while (true)
            {
                Console.WriteLine($"Podaj liczbę z zakresu {v1}-{v2}");
                if (int.TryParse(Console.ReadLine(), out int number) && number >= v1 && number <= v2) return number;
                Console.Write("Błąd! ");
            }
        }
    }
}
