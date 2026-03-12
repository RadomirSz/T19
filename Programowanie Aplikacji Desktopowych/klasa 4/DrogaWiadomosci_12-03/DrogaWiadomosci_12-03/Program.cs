namespace DrogaWiadomosci_12_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kronikarz wiesiek = new KronikarzKonsolowy();
            Archiwista chiefkeef = new ArchiwistaCachowy();

            ObsłużycielWiadomości sekretarkaAsia = new ObsłużycielWiadomości(znajomyKronikarz: wiesiek, znajomyArchiwista: chiefkeef);

            Console.WriteLine("Przekaz wiadomość do pani Asi:");
            string wiadomosc = Console.ReadLine();
            sekretarkaAsia.obsłużWiadomość(wiadomosc);
        }
    }

    public class ObsłużycielWiadomości(Kronikarz znajomyKronikarz, Archiwista znajomyArchiwista)
    {
        public void obsłużWiadomość(string wiadomosc)
        {
            znajomyKronikarz.zapisz(wiadomosc);
            znajomyArchiwista.zapisz(wiadomosc);
        }
    }

    public interface Kronikarz
    {
        void zapisz(string wiadomosc);
    }
    class KronikarzKonsolowy : Kronikarz
    {
        public void zapisz(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }
    }
    class KronikarzPlikowy : Kronikarz
    {
        public void zapisz(string wiadomosc)
        {
            Console.WriteLine($"zapisuję '{wiadomosc}' do pliku");
        }
    }

    public interface Archiwista
    {
        void zapisz(string wiadomosc);
    }

    public class ArchiwistaBazodanowy : Archiwista
    {
        public void zapisz(string wiadomosc)
        {
            Console.WriteLine($"zapisalem '{wiadomosc}' do bazy danych");
        }
    }

    public class ArchiwistaCachowy : Archiwista
    {
        public void zapisz(string wiadomosc)
        {
            Console.WriteLine($"dodałem '{wiadomosc}' do pamieci podrecznej");
        }
    }
}
