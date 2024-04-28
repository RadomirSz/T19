using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian_RadomirSz_uml
{
    internal class Program{static void Main(string[] args){}}

    //przystanek - fasada


    //z1 (uml -> kod)
    
    interface Robotny
    {
        string Robota { get; set; }

        void planuj();
        void Działaj(Zadanie z);

    }
    class Zadanie
    {
        public string treśćZadania;
    }
    class Rekin : Robotny
    {
        string Robotny.Robota { get; set; }
        private string imie;
        private string nazwisko;
        public void planuj() { }
        public void Działaj(Zadanie z) { }
        protected void dobierzNarzedzia(string Narzędzie) { }
        Klasa k;
    }
    class Leszcz : Robotny
    {
        string Robotny.Robota { get; set; }
        private string imie;
        private string odmiana;
        public void planuj() { }
        public void Działaj(Zadanie z) { }
        protected void wymyślajWymówki() { }
        private void czekaj() { }
        public void udawaj() { }
    }
    class Gracz : Robotny
    {
        string Robotny.Robota { get; set; }
        private string imie;
        private int poziom;
        public void planuj() { }
        public void Działaj(Zadanie z) { }
        protected void ideGrac() { }
        private void jem() { }
        private bool Wydalam() { }
        protected char ZnowIdeGrac() { }
    }

    class Klasa : Robotny
    {
        string Robotny.Robota { get; set; }
        public string numerKlasy;
        protected List<Robotny> lista = new List<Robotny> { };
        public void dodajDoListy() { }
        public void planuj() { }
        public void Działaj(Zadanie z) { }

    }

    class Teknikum : Szkoła
    {
        private string nazwa;
        public string podajNazwę() { return nazwa; }
        Klasa k;
    }
    class Szkoła
    {
        private string Kraj;
        private Szkoła() { } // w teorii nazwa metody ta sama co klasy wiec konstruktor ale nie wiem po co TUTAJ prywatny konstruktor + kłóci się z dziedziczeniem przez teknikum
        public Szkoła stwórzSzkołę() { }
    }



    //zad 2 (tekst -> kod)

    class PunktCentralny
    {
        Przystanek p;
    }

    class Przystanek
    {
        private bool Zadaszenie;
        Biletomat b;
        ListaAutobusów L;

    }
    class Pętla
    { 
        //nie rozumiem tej części zupełnie
    }
    class Biletomat
    { 
        public bool CzyJest;
    }
    class ListaAutobusów 
    { 
        List<int> lista = new List<int>();
    }

}
