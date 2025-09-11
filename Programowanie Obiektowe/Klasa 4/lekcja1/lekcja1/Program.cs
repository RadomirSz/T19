using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lekcja1.Properties;

namespace lekcja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urzadzenie u = new Urzadzenie();
            u.Wlacz();
            Console.WriteLine();

            Telefon t = new Telefon();
            t.Wlacz();
            t.Zadzwon();
            Console.WriteLine();

            Smartfon s = new Smartfon();
            s.Wlacz();
            s.Zadzwon();
            s.PrzegladajInternet();

            Console.ReadKey();
        }
    }
}
