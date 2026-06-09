namespace konsolowa;

public class Kosc
{
    public static int Instancje;

    private static readonly Random _rng = new();

    public List<string> NazwyPlikowObrazow { get; set; }
    public int LiczbaOczek { get; set; }
    public int IdentyfikatorPliku { get; set; }
    public bool Dostepna { get; set; }

    public Kosc(int wartosc)
    {
        NazwyPlikowObrazow = new List<string>();
        for (var i = 0; i <= 6; i++)
            NazwyPlikowObrazow.Add($"kosc{i}.png");

        if (!(wartosc >= 1 && wartosc <= 6)) wartosc = 0;

        LiczbaOczek = wartosc;
        IdentyfikatorPliku = wartosc;
        Dostepna = true;
        Instancje++;
    }

    public Kosc()
    {
        NazwyPlikowObrazow = new List<string>();
        for (var i = 0; i <= 6; i++)
            NazwyPlikowObrazow.Add($"kosc{i}.png");

        LiczbaOczek = _rng.Next(1, 7);
        IdentyfikatorPliku = LiczbaOczek;
        Dostepna = true;
        Instancje++;
    }

    public void Rzut()
    {
        if (!Dostepna)
            return;

        LiczbaOczek = _rng.Next(1, 7);
        IdentyfikatorPliku = LiczbaOczek;
    }

    public void Blokuj()
    {
        Dostepna = false;
    }

    public string PobierzRzutTekst()
    {
        if (!(LiczbaOczek >= 1 && LiczbaOczek <= 6)) return "nie ustawiono";
        string[] liczbySłownie = { "jeden", "dwa", "trzy", "cztery", "pięć", "sześć" };
        return liczbySłownie[LiczbaOczek - 1];
    }

    public string PobierzNazwePliku()
    {
        if (IdentyfikatorPliku >= 0 && IdentyfikatorPliku < NazwyPlikowObrazow.Count)
            return NazwyPlikowObrazow[IdentyfikatorPliku];
        return string.Empty;
    }
}