using System.Threading;
using System;
namespace _7._2_28_11;

class Program
{
    static void Main(string[] args)
    {
        #region code
        int a = WczytajLiczbe();
        int b = WczytajLiczbe();

        int[,] ints = UtworzTablice(a,b);
        WypelnijTablice(ints);
        WyswietlTablice(ints);
        System.Console.WriteLine(ObliczSume(ints));
        
        #endregion

    }
    #region funkcje
    static int WczytajLiczbe()
    {
        while(true){
            System.Console.WriteLine("Podaj liczbę dodatnią całkowitą lub \"q\" jeżeli chcesz zakończyć dzialanie programu.");
            string? liczba = Console.ReadLine();
            if(liczba == "q")
            {
                System.Console.WriteLine("Zakończono program!"); 
                Thread.Sleep(1000); 
                Environment.Exit(0);
            }
            try
            {
                int a = int.Parse(liczba);
                if(a < 0)
                {
                    throw new Exception("Podaj liczbę większą od 0.");
                }
                return a;
            }
            catch (System.Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }

    static int[,] UtworzTablice(int n, int m)
    {
        int[,] T = new int[n,m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                T[i,j] = WczytajLiczbe();
            }
        }
        System.Console.WriteLine("Pomyślnie utworzono Tablicę");
        return T;
    }

    static int[,] WypelnijTablice(int[,] T)
    {
        Random r = new Random();
        System.Console.WriteLine("Podaj minimalną liczbę losową.");
        int a = WczytajLiczbe();
        System.Console.WriteLine("Podaj maksymalną liczbę losową.");
        int b = WczytajLiczbe();

        for (int i = 0; i < T.GetLength(0); i++)
        {
            for (int j = 0; j < T.GetLength(1); j++)
            {
                T[i,j] = r.Next(a,b+1);
            }
        }
        System.Console.WriteLine("Pomyślnie wypełniono Tablicę losowymi liczbami");
        return T;
    }

    static void WyswietlTablice(int[,] T)
    {
        for (int i = 0; i < T.GetLength(0); i++)
        {
            for (int j = 0; j < T.GetLength(1); j++)
            {
                System.Console.Write(T[i,j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    static int ObliczSume(int[,] T)
    {
        int suma = 0;
        for (int i = 0; i < T.GetLength(0); i++)
        {
            for (int j = 0; j < T.GetLength(1); j++)
            {
                if(i==j) suma += T[i,j];
            }
        }
        return suma;
    }
    #endregion
}
