using _27_02.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person("Janusz");
            Person p4 = new Person("Janusz", "Nowak");

            // Wyświetlenie wartości właściwości
            Console.WriteLine(p1.GetData());
            Console.WriteLine(p2.GetData());
            Console.WriteLine(p3.GetData());



            // wyświetlenie liczby obiektów klasy person
            
            Console.WriteLine("liczba: " + Person.Counter);
            
            Console.ReadKey();
        }
    }
}
