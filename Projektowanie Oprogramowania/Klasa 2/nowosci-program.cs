using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowosci
{
    /*class przyklad
    {
        //pola
        //public dostepny w klasach i obiektach
        //private w tej samej klasie
        //protected w klasie innej dziedziczcej anle nie w obiekciue
        //internal w klasach tego samego namespace'a
        private int wiek;
        public string imię;

        //wlasciwosci

        public int wzrost 
        {
            get {return wzrost + 100; }
            set 
            { 
                if (value > 100) wzrost = 500;
                else wzrost = value;
            } 
        }

        //metody
        public void metoda1()
        {
            Console.WriteLine("cos");
        }
        public int getwiek()
        {
            return wiek;
        }
        public void setter(int wiek)
        {
            this.wiek = wiek;
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /*    class kołozapas { }

        class auto
        {
            kołozapas koło;
            public void setkoło(kołozapas koło)
            {
                this.koło = koło;
            }
        }

        class nauczyciel{}
        class szkola
        {
            nauczyciel nau;
            void zatrudnij(nauczyciel n)
            {
                nau = n;
            }
        }*/



    //// zadanie
    class klient { }
    class produkt{ }
    class dostawa { }
    class zamowienie 
    { 
        klient klient;
        produkt produkt;
        dostawa dostawa;

        public void setklient(klient klient)
        {
            this.klient = klient;
        }
        public void setprodukt(produkt produkt)
        {
            this.produkt = produkt;
        }
        public void przypiszdostawe(dostawa dostawa)
        {
            this.dostawa = dostawa;
        }
    }
}
