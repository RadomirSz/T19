using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasady_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            plik z1 = new plik();
            z1.nazwa = "foto1";
            plik z2 = new plik();
            z2.nazwa = "foto2";

            Katalog k1 = new Katalog();
            k1.nazwa = "zdjęcia";
            k1.dodaj(z1);
            k1.dodaj(z2);
            Katalog k2 = new Katalog();
            k2.nazwa = "różne";
            Katalog d1 = new Katalog();
            d1.nazwa = "dysk";
            d1.dodaj(k1);
            d1.dodaj(k2);


            d1.wyswietl();




            Console.ReadKey();
        }
        interface Wezel
        {
            string nazwa { get; set; }
            void wyswietl();
        }

        class Katalog : Wezel 
        {
            public string nazwa { get; set; }
            public void wyswietl()
            {
                Console.Write(nazwa);
                foreach (var item in węzełs)
                {
                    Console.Write("\n--");
                    item.wyswietl();
                }
            }
            public void dodaj(Wezel w)
            {
                węzełs.Add(w);
            }

            List<Wezel> węzełs = new List<Wezel>();
        }

        class plik : Wezel
        {
            public string nazwa { get; set; }
            public void wyswietl()
            {
                Console.Write("--" + nazwa);
            }
        }
    }
}
