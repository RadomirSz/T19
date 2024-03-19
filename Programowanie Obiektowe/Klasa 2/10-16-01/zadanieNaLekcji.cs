namespace _10_16_01;
class Program
{
    static void Main(){
        int n = ReadInt("daj liczbę osob: ",0,int.MaxValue);

        int[] ages = new int[n];
        string[] names = new string[n];
        for (int i = 0; i < n; i++)
        {
            names[i] = readstring($"daj imie osoby {i+1}: ");
            ages[i] = ReadInt($"daj wiek {i+1}: ",0,150);
        }
        
        System.Console.WriteLine("\nWyświetlenie tablicy imion i wiekow: ");
        PrintArray(names,ages);

        List<string> namestostartwithA = names.Where(e=> e.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();


        System.Console.WriteLine("imiona na a lub A: ");
        PrintList(namestostartwithA);

        Dictionary<string,int> adults = new Dictionary<string, int>();
        for (int i = 0; i < names.Length; i++)
        {
            if(ages[i] >= 18)
            {
                adults.Add(names[i],ages[i]);
            }
        }
        System.Console.WriteLine("dorosli:");
        PrintDictionary(adults);
    }
    private static void PrintArray(string[] names,int[] ages)
    {
        for (int i = 0; i < names.Length; i++)
        {
            System.Console.WriteLine(names[i]+" - "+ ages[i]);
        }
    }
    
    private static void PrintList(List<string> names)
    {
        foreach (var item in names)
        {
            System.Console.WriteLine(item);   
        }
    }
    private static void PrintDictionary(Dictionary<string,int> dictionary)
    {
        foreach (var item in dictionary)
        {
            System.Console.WriteLine(item);   
        }
    }
    
    static int ReadInt(string prompt,int low, int high)
    {
        int result;
        bool valid;
        do
        {
            System.Console.Write(prompt);
            valid = int.TryParse(Console.ReadLine(),out result) && result >= low && result <= high;
            if (!valid)
            {
                System.Console.WriteLine($"podaj liczbę od {low} do {high}: ");
            }
        }while (!valid);
        return result;
    }
    static string readstring(string prompt){
        string? result;
        do
        {
            System.Console.Write(prompt);
            result = Console.ReadLine();
            if (string.IsNullOrEmpty(result))
            {
                System.Console.WriteLine("Podaj nie pusty ciąg znaków");
            }
        }while(string.IsNullOrEmpty(result));
        return result;
    }
}
