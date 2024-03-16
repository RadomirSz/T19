
namespace kartkowka;

class Program
{
    static void Main(string[] args)
    {
        // GRUPA : 2
        // pi r 2
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.WriteLine("\u03C0" + "\u0072" + " \u00B2");
        Console.OutputEncoding = System.Text.Encoding.Default;


        // float  (32 bity 4 bajty) maksymalnie 3.4 * 10^8
        // double (64 bity 8 bajtów) 
        // decimal (128 bitów 16 bajtów) 

        float r = float.Parse(Console.ReadLine());
        float pi = 3.14159265F;
        float suma = pi * (r * r);
        System.Console.WriteLine($"Pole tego koła wynosi: " + suma);


    }
}
