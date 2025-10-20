using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoda_Płatności
{
    // Interfejs produktu (IPlatność)
    public interface IPlatnosc
    {
        void Autoryzuj();
        string PobierzOpis();
    }

    // Konkretne produkty implementujące interfejs IPlatnosc
    public class KartaPlatnicza : IPlatnosc
    {
        public void Autoryzuj()
        {
            Console.WriteLine("KartaPlatnicza: Łączę się z systemem VISA/Mastercard.");
        }

        public string PobierzOpis()
        {
            return "Płatność kartą płatniczą";
        }
    }

    public class PayPal : IPlatnosc
    {
        public void Autoryzuj()
        {
            Console.WriteLine("PayPal: Łączę się z systemem PayPal.");
        }

        public string PobierzOpis()
        {
            return "Płatność przez PayPal";
        }
    }

    // Klasa abstrakcyjna twórcy (Factory)
    public abstract class FabrykaPlatnosci
    {
        // Metoda wytwórcza
        public abstract IPlatnosc UtworzPlatnosc();

        // Metoda biznesowa
        public void ZrealizujTransakcje(decimal kwota)
        {
            Console.WriteLine($"[Transakcja] Kwota: {kwota:F2} PLN.");
            
            // Tworzenie produktu za pomocą metody wytwórczej
            IPlatnosc platnosc = UtworzPlatnosc();
            
            Console.WriteLine("[Transakcja] Rozpoczynam autoryzację...");
            platnosc.Autoryzuj();
            Console.WriteLine("[Transakcja] Płatność zakończona pomyślnie.");
        }
    }

    // Konkretni twórcy
    public class FabrykaKarty : FabrykaPlatnosci
    {
        public override IPlatnosc UtworzPlatnosc()
        {
            return new KartaPlatnicza();
        }
    }

    public class FabrykaPayPal : FabrykaPlatnosci
    {
        public override IPlatnosc UtworzPlatnosc()
        {
            return new PayPal();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Scenariusz symulacji
            Console.WriteLine("Test płatności kartą:");
            FabrykaPlatnosci fabrykaKarty = new FabrykaKarty();
            fabrykaKarty.ZrealizujTransakcje(150.00m);

            Console.WriteLine("\nTest płatności PayPal:");
            FabrykaPlatnosci fabrykaPayPal = new FabrykaPayPal();
            fabrykaPayPal.ZrealizujTransakcje(50.00m);

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
