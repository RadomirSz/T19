using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public float Cena { get; set; }
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
