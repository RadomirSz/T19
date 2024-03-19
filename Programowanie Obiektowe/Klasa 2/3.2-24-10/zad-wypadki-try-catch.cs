using System;
namespace _24_10_zad;

class Program
{
    static void Main(string[] args)
    {
        //użytkownik podaje swoje imię oraz rok urodzenia, dodaj wyjątki i zabezpiecz program
        try
        {
        System.Console.WriteLine("daj imię: ");
        string name = Console.ReadLine();
        System.Console.WriteLine("daj rok urodzenia: ");
        ushort year = ushort.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            ColorChangeError($"podałeś dane w złym formacie");
        }
        catch(OverflowException)
        {
            ColorChangeError($"Podaj poprawny rok urodzenia");
        }
        catch(Exception ex)
        {
            ColorChangeError($"{ex.Message}");
        }
    }

    static void ColorChangeError(string kom)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"błąd: {kom}");
        Console.ResetColor();
    }
}
