namespace DI_drużyna_sportowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trener trenerA = new TrenerKrajowy();
            Trener trenerB = new TrenerZagraniczny();

            Druzyna Lech = new Druzyna(trenerA);
            Druzyna Reprezentacja = new Druzyna(trenerB);

            Stadion stadion1 = new Stadion();
            Stadion stadion2 = new Stadion();
            Stadion stadion3 = new Stadion();


            DruzynaImpl implementacjonowanaDruzyna = new DruzynaImpl(Reprezentacja);
            implementacjonowanaDruzyna.stadion = stadion1;
        }
    }


    interface Trener
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        int Wiek { get; set; }

    }

    class TrenerKrajowy() : Trener
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public override string ToString()
        {
            return $"Trener krajowy {Imie}{Nazwisko}, wiek {Wiek}";
        }
    }
    class TrenerZagraniczny() : Trener
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public override string ToString()
        {
            return $"Trener zagraniczny {Imie}{Nazwisko}, wiek {Wiek}";
        }
    }


    class Druzyna(Trener trener)
    {
        public string Nazwa;
        public string Miasto;
        public override string ToString()
        {
            return "Drużyna " + Nazwa + " w " + Miasto;
        }
    }

    class Stadion
    {
        public string Miasto;
        public string Adres;
        public override string ToString()
        {
            return Miasto +", "+ Adres;
        }
    }

    class DruzynaImpl(Druzyna druzyna)
    {
        public Stadion stadion { get; set; }
        public override string ToString()
        {
            return "Implementacja druzyny " + druzyna.ToString() + " ze stadionem pod adresem " + stadion.ToString();
        }
    }
}
