namespace tida_inf04czerwiec25;
class Program
{
    static void Main(string[] args)
    {
        SzyfrCezara szyfrCezara = new SzyfrCezara();
        Console.WriteLine(szyfrCezara.Szyfruj("abcdefghijklmnoprstuvw",2));
    }
}

class SzyfrCezara
{
    private string alfabet = "abcdefghijklmnopqrstuvwxyz";
    public string Szyfruj(string napis, int klucz)
    {
        string zaszyfrowanyNapis = "";
        foreach (var litera in napis)
            zaszyfrowanyNapis += alfabet[alfabet.IndexOf(litera) + klucz];

        return zaszyfrowanyNapis;
    }
}