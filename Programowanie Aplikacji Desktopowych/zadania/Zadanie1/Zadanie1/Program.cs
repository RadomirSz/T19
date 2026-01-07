

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = getValidInt(3, 20);

            int[] liczby = new int[n];
            for (int i = 0; i < n; i++)
            {
                liczby[i] = getValidInt(1, 9999);
            }

            int[] sumy = new int[n];
            for (int i = 0; i < n; i++)
            {
                sumy[i] = sumaCyfr(liczby[i]);
            }

            foreach (var item in sumy)
            {
                Console.Write(item + " ");
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
            int number;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out number) && number >= v1 && number <= v2) return number;
                else Console.WriteLine($"Podaj liczbę z zakresu {v1}-{v2}");
            }
        }
    }
}
