using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            /*
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            
            && - and
            || - or
            != "nierówne"
            
            Console.ReadKey();
            */

            //zad2
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a < 1000 && a % 17 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            Console.ReadKey();













        }
    }
}
