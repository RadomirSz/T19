using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SamochodyRS.Properties
{
    enum TypPaliwa
    {
        Benzyna, 
        Diesel, 
        Elektryczny, 
        Hybrydowy
    }
    internal class Samochod
    {
        static int IloscKol = 4;
        //Statyczne pole IloscKol: Wspólne dla wszystkich obiektów, ustawione na wartość 4.

        private string marka;
        private string model;
        private int rokProdukcji;
        //Prywatne pola: marka, model(typu string) oraz rokProdukcji(typu int).

        private DateTime DataPierwszejRejestracji;
        //Właściwość DataPierwszejRejestracji: Typu DateTime, przechowuje datę pierwszej rejestracji samochodu.

        private float PojemnoscSilnika;

        // Domyślny konstruktor: Nie przyjmuje argumentów, ustawia marka i model na “Nieznany”, rokProdukcji na 0.
        public Samochod()
        {
            marka = "Nieznany";
            model = "Nieznany";
            rokProdukcji = 0;
        }
        //Parametryczny konstruktor: Przyjmuje argumenty dla wszystkich pól i ustawia je odpowiednio.
        public Samochod(string marka, string model, int rokProdukcji, DateTime DataPierwszejRejestracji, float PojemnoscSilnika)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.DataPierwszejRejestracji = DataPierwszejRejestracji;
            this.PojemnoscSilnika = PojemnoscSilnika;
        }


        // Metoda WyswietlInformacje: Wyświetla informacje o samochodzie.

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Samochód marki: {marka}, model: {model}, o pojemności silnika {PojemnoscSilnika}, wyprodukowany w {rokProdukcji} a zarejestrowany {DataPierwszejRejestracji}.");
        }
        //Metoda ObliczWiek: Oblicza wiek samochodu.
        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokProdukcji;
        }
        //Metoda ZmienMarkeIModel: Zmienia markę i model samochodu.
        public void ZmienMarkeIModel(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
        }
        //Metoda CzyKlasyk: Sprawdza, czy wybrany samochód jest klasykiem.
        public bool czyKlasyk()
        {
            if (DateTime.Now.Year - rokProdukcji >= 25) return true;
            return false;
        }
        //Metoda WyswietlInformacjeJSON: Wyświetla informacje o samochodzie w formacie JSON.

        //Metoda ObliczSpalanie: Oblicza spalanie na podstawie przejechanych kilometrów i zużytego paliwa

    }
}
