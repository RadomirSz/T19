using System;
using System.Data;

const string login="login";
const string haslo = "haslo";

Console.WriteLine("Podaj login:");
string Plogin = Console.ReadLine();
Console.WriteLine("Podaj haslo:");
string Phaslo = Console.ReadLine();

if (haslo == Phaslo && login == Plogin)
{
       if(trzezwosc());
       {
       kalkulator();
       }
}


bool trzezwosc()
{ 
    byte proby = 0;
    bool flaga = false;
    Random r = new Random();

        do{
        int a = r.Next(1, 10);
        int b = r.Next(1, 10);
        int c = r.Next(1, 10);

        int los = r.Next(1,5);
        char x;
        switch(los)
            {
                case 1:
                    x = '+';
                    break;
                case 2:
                    x = '-';
                    break;
                case 3:
                    x = '*';
                    break;
                default:
                    x = '/';
                    break;
            }

        int los2 = r.Next(1,5);
        char y;
        switch(los2)
            {
                case 1:
                    y = '+';
                    break;
                case 2:
                    y = '-';
                    break;
                case 3:
                    y = '*';
                    break;
                default:
                    y = '/';
                    break;
            }
    
        System.Console.WriteLine($"Podaj wynik tego działania: {a}{x}{b}{y}{c}");
        string dzialanie = a.ToString();
        dzialanie += x.ToString();
        dzialanie += b.ToString();
        dzialanie += y.ToString();
        dzialanie += c.ToString();
        Console.WriteLine(dzialanie);
        DataTable dt = new();
        var v = dt.Compute(dzialanie, "");
        double wynik = Convert.ToDouble(v);
        double Pwynik = double.Parse(Console.ReadLine());
        if(wynik == Pwynik)
            {
                flaga = true;
                break;
            }
        proby++;
    }
    while(proby != 3);

    if(!flaga)Console.WriteLine("Jesteś nie trzeźwy!");

    return flaga;
}

static void kalkulator()
{
    bool repeat = true;
    do{
        Console.WriteLine("Podaj działanie które chcesz wykonać:");
        string dzialanie = Console.ReadLine();
        
        DataTable dt = new();
        var wyn = dt.Compute(dzialanie, "");
        decimal wynik = Convert.ToDecimal(wyn);
        Console.WriteLine("Wynik: " + wynik);

        Console.WriteLine("Czy chcesz wykonać kolejne działanie? T - Tak, N - Nie");
        string powtorz = Console.ReadLine();
        if(powtorz != "T" && powtorz != "t") repeat = false;

    }while(repeat);

    Console.WriteLine("Dowidzenia!");
}

