using System;
namespace sprawdziany;

class Program
{
    static int n1 = 5;
    static int[] pola = new int[n1];
    static int[] obwody = new int[n1];
    
    static void Main(string[] args)
    {
        //dopisz do każdej zmiennej "1"
        
        int[] tablica1 = UtworzTabliceLiczb(n1);
        wyswietlTAB(tablica1);
        
        System.Console.WriteLine();
        
       

        for (int i = 1; i < tablica1.GetLength(0)+1; i++)
        {
            int x = ObliczPole(tablica1[i-1]);
            pola[i-1] = x;
            System.Console.WriteLine("Pole kwadratu utworzonego przy użyciu liczby " + i + " z twojej tablicy to: " + x + "cm\u00B2");
        }

        System.Console.WriteLine();

        for (int i = 1; i < tablica1.GetLength(0)+1; i++)
        {
            int x = ObliczObwod(tablica1[i-1]);
            obwody[i-1] = x;
            System.Console.WriteLine("Obwód kwadratu utworzonego przy użyciu liczby " + i + " z twojej tablicy to: " + x + "cm");
        }

        pokazelement();
    }

    static int dajcyfre()
    {
        System.Console.WriteLine("Podaj liczbę z zakresu 1-10:");
        while(true)
        {
            if(int.TryParse(Console.ReadLine(), out int cyfra1) && cyfra1 > 0 && cyfra1 < 11) return cyfra1;
            System.Console.WriteLine("Nieprawidłowa liczba");
        }
    }

    static int[] UtworzTabliceLiczb(int n)
    {
        int[] T1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            T1[i] = dajcyfre();
        }
        return T1;
    }

    static int ObliczPole(int a1) {return a1*a1;}
    static int ObliczObwod(int a1) {return (4 * a1);}
    
    static void wyswietlTAB(int[] T1)
    {
        System.Console.WriteLine("Oto twoja tablica:");
        foreach(var i in T1) System.Console.WriteLine(i);
    }
    static void pokazelement()
    {
        System.Console.WriteLine("jaki element chcesz zobaczyć?");
        int n11 = 0;
        System.Console.WriteLine("Podaj liczbę z zakresu 1-5:");
        while(n11==0)
        {
            if(int.TryParse(Console.ReadLine(), out int cyfra1) && cyfra1 > 0 && cyfra1 < 6) 
            {
                n11 = cyfra1;
            }
            else
            {
                System.Console.WriteLine("Nieprawidłowa liczba");
            }
        }
        System.Console.WriteLine("Pole kwadratu utworzonego przy użyciu liczby " + n1 + " z twojej tablicy to: " + pola[n11-1] + "cm \u00B2");
        System.Console.WriteLine("Obwód kwadratu utworzonego przy użyciu liczby " + n1 + " z twojej tablicy to: " + obwody[n11-1] + "cm");
    }
}
