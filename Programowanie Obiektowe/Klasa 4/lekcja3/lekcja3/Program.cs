using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDrukowalny> DList = new List<IDrukowalny>();
            Ksiazka k = new Ksiazka("ksiazka1");

            DList.Add(k);
            DList.Add(new Ksiazka(k));
            DList.Add(new Ksiazka("anmon"));
            DList.Add(new Raport("arman"));

            foreach (var item in DList) 
            {
                item.Drukuj();
            }
        }
    }

    public interface IDrukowalny
    {
        void Drukuj();
    }
    public class Dokument
    {
        protected string Tytul;
        
        public void PokazTytul()
        {
            Console.WriteLine(Tytul);
        }
    }

    public class Ksiazka : Dokument, IDrukowalny
    {
        public Ksiazka(string tytus) { Tytul = tytus; }
        public Ksiazka(Ksiazka kopia)
        {
           Tytul = kopia.Tytul;
        }
        public void Drukuj()
        {
            Console.WriteLine("drukuję książkę " + Tytul);
        }
    }
    public class Raport : Dokument, IDrukowalny
    {
        public Raport(string tytus) { Tytul = tytus; }
        public void Drukuj()
        {
            Console.WriteLine("drukuję raport " + Tytul);
        }
    }
}
