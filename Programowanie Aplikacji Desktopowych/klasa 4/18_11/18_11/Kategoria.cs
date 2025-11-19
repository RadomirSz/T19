using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public List<Produkt> Produkty { get; set; }
    }
}
