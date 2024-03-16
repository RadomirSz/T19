using System.Security.AccessControl;
using System;
using System.Threading;
namespace _17_10;

class Program
{
    static void Main(string[] args)
    {
        bool czytworza(double a,double b, double c){if(a+b>c && c+b>a && a+c>b) return true;return false;}
        double heron(double a,double b, double c){
            double p = (a+b+c)/2;
            return(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
        }
        double a,b,c;

        do{
        System.Console.WriteLine("daj a w cm");
        
        while(!double.TryParse(Console.ReadLine(),out a) || a <=0) 
            System.Console.WriteLine("wpisz poprawne dane: ");
        System.Console.WriteLine("daj b w cm");
        
        while(!double.TryParse(Console.ReadLine(),out b) || b <=0) 
            System.Console.WriteLine("wpisz poprawne dane: ");

        System.Console.WriteLine("daj c w cm");
        
        while(!double.TryParse(Console.ReadLine(),out c) || c <=0) 
            System.Console.WriteLine("wpisz poprawne dane: ");

        if(!czytworza(a,b,c)){ 
            System.Console.WriteLine("NIE TWORZY TRÓJKĄTA");
            Thread.Sleep(2000);
            Console.Clear();
        }
        
        }
        while(!czytworza(a,b,c));
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine($"pole tego trójkąta (boki: {a},{b},{c}) to ~ {heron(a,b,c):F4}cm\u00B2");       
        Console.OutputEncoding = System.Text.Encoding.Default;
    }
}
