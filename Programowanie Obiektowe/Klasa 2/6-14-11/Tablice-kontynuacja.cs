namespace _6_14_11;

class Program
{
    static void Main(string[] args)
    {
        // string[] name = {"Adam","Bartosz","Cezary","Damian","Kacper"};
        // foreach (string i in name) System.Console.Write(i + " ");
        // System.Console.WriteLine();
        // System.Console.WriteLine(name[2]);3
        // System.Console.WriteLine(name[4]);
        int dlugosc;
        while(true)
        {
            System.Console.Write("Podaj długość twojej tabeli: ");
            if(int.TryParse(Console.ReadLine(), out dlugosc))
                break;
        }
        System.Console.Write("Podaj nazwę swojej tabeli: ");
        string nazwa = Console.ReadLine()??"";
        int[] arr = CreateArray(dlugosc,nazwa);
        SetArray(arr);
        DisplayArray(arr);
    }
    public static int[] CreateArray(int liczba, string nazwa)
    {
        System.Console.WriteLine($"Twoja tabela \"{nazwa}\" ma {liczba} miejsc.");
        int[] array = new int[liczba];
        return array;
    }
    public static void SetArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"podaj liczbę {i+1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    public static void DisplayArray(int[] T)
    {
        System.Console.WriteLine("Twoja tabela zawiera te liczby: ");
        foreach (var i in T)
        {
            System.Console.Write(i + " ");
        }
    }
}
