using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _16_10
{
    internal class Koszyk
    {
        public List<Produkt> Produkty = new();
        public IZniżkaStrategia ZniżkaStrategia;

        public Koszyk()
        {
            generujPróbki();
        }

        private void generujPróbki()
        {
            Produkty.Add(new ProduktFizyczny("Komputer", 400));
            Produkty.Add(new ProduktFizyczny2("zimbwbwe", 25));
            Produkty.Add(new ProduktFizyczny2("niger", 25));
            Produkty.Add(new ProduktFizyczny2("chad", 25));
        }

        public int obliczWartośćKoszyka()
        {
            int w = 0;
            foreach (var item in Produkty)
            {
                w += item.Cena;
            }
            return w;
        }

        public int obliczWartośćKoszykaPoRabacie(IZniżkaStrategia zniżkaStrategia, int x)
        {
            this.ZniżkaStrategia = zniżkaStrategia;
            int w = obliczWartośćKoszyka();
            return ZniżkaStrategia.obliczZniżkę(w, x);
        }


    }
}