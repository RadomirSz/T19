using System;
namespace _24_10;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("podaj dwie liczby\n");
            System.Console.Write("podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if(b==0)
            {
                throw new Exception("nie można dzielić przez 0");
            }
            if(b > double.MaxValue || a> double.MaxValue || b < double.MaxValue || a < double.MaxValue)
            {
                throw new Exception("za duża lub za mała liczba");
            }
            double wyn = a/b;
            System.Console.Write($"wynik dzielenia:{a}/{b} = ");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{wyn:F3}");
            Console.ResetColor();
        }
        catch(DivideByZeroException)
        {
            ErrorColorChange("nie można dzielić przez zero");
        }
        catch(FormatException)
        {
            ErrorColorChange("błędny format danych");
        }
        catch(OverflowException)
        {
            ErrorColorChange($"Podana liczba jest błędna, podaj dane z zakresu <{double.MinValue};{double.MaxValue}>");
        }
        catch(Exception ex)
        {
            ErrorColorChange($"{ex.Message}");
        }


    }
    static void ErrorColorChange(string comment)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"\nBłąd: {comment}");
        Console.ResetColor();
    }
}
