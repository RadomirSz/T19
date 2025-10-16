using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _16_10
{
    internal abstract class Produkt
    {
        public String Nazwa;
        public int Cena;

        protected Produkt(string nazwa, int cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}