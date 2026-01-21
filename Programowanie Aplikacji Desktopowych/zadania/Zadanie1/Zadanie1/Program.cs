

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {


                int n = getValidInt(3, 20);

                int[] liczby = new int[n];
                for (int i = 0; i < n; i++)
                {
                    liczby[i] = getValidInt(1, 9999);
                }

                Console.Write("Przed sortowaniem: ");
                foreach (var item in liczby) Console.Write(item + " ");

                int[] sumy = new int[n];
                for (int i = 0; i < n; i++)
                {
                    sumy[i] = sumaCyfr(liczby[i]);
                }

                Console.Write("\nLiczby i sumy ich cyfr: ");
                for (int i = 0; i < n; i++) Console.Write($"{liczby[i]}: {sumy[i]}, ");

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sumy[i] > sumy[j])
                        {
                            int temp = sumy[i];
                            sumy[i] = sumy[j];
                            sumy[j] = temp;

                            temp = liczby[i];
                            liczby[i] = liczby[j];
                            liczby[j] = temp;
                        }
                    }
                }

                Console.Write("\nPo sortowaniu: ");
                foreach (var item in liczby) Console.Write(item + " ");

                Console.WriteLine("\nCzy chcesz posortowa¢ kolejną tablicę? (t/n): ");
                string input = Console.ReadLine();
                if (input == "n") run = false;
            }
        }

        private static int sumaCyfr(int v)
        {
            int suma = 0;
            while (v > 0)
            {
                suma += v % 10;
                v = v / 10;
            }
            return suma;
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
