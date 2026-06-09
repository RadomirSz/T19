import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Kosc {
    public static int Instancje;
    private static final Random _rng = new Random();

    public List<String> NazwyPlikowObrazow;
    public int LiczbaOczek;
    public int IdentyfikatorPliku;
    public boolean Dostepna;

    public Kosc(int wartosc) {
        NazwyPlikowObrazow = new ArrayList<>();
        for (int i = 0; i <= 6; i++)
            NazwyPlikowObrazow.add("kosc" + i + ".png");

        if (!(wartosc >= 1 && wartosc <= 6)) wartosc = 0;

        LiczbaOczek = wartosc;
        IdentyfikatorPliku = wartosc;
        Dostepna = true;
        Instancje++;
    }

    public Kosc() {
        NazwyPlikowObrazow = new ArrayList<>();
        for (int i = 0; i <= 6; i++)
            NazwyPlikowObrazow.add("kosc" + i + ".png");

        LiczbaOczek = _rng.nextInt(6) + 1;
        IdentyfikatorPliku = LiczbaOczek;
        Dostepna = true;
        Instancje++;
    }

    public void Rzut() {
        if (!Dostepna) return;
        LiczbaOczek = _rng.nextInt(6) + 1;
        IdentyfikatorPliku = LiczbaOczek;
    }

    public void Blokuj() {
        Dostepna = false;
    }

    public String PobierzRzutTekst() {
        if (!(LiczbaOczek >= 1 && LiczbaOczek <= 6)) return "nie ustawiono";
        String[] liczbySlownie = {"jeden", "dwa", "trzy", "cztery", "pięć", "sześć"};
        return liczbySlownie[LiczbaOczek - 1];
    }

    public String PobierzNazwePliku() {
        if (IdentyfikatorPliku >= 0 && IdentyfikatorPliku < NazwyPlikowObrazow.size())
            return NazwyPlikowObrazow.get(IdentyfikatorPliku);
        return "";
    }
}
