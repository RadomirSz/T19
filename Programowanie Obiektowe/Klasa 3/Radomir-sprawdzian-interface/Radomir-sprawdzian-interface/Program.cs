using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Radomir_sprawdzian_interface
{
    interface ICar
    {
        void StartEngine();
        void Drive();
    }

    abstract class Car : ICar,IComparable<Car>, IEquatable<Car>
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Owner { get; set; }

        public abstract void Drive();
        public void StartEngine() 
        {
            Console.WriteLine($"{Brand} {Model} uruchamia silnik");
        }

        public int CompareTo(Car other)
        {
            if (other == null) return 1;
            return Year.CompareTo(other.Year);
        }
        public bool Equals(Car other)
        {
            if (this == other) return true;
            return false;
        }
        public override string ToString()
        {
            return $"{Brand} {Model} from {Year} owned by {Owner}";
        }
        public Car(string brand, string model, int year, string owner) 
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Owner = owner;
        }
    }

    class ElectricCar : Car
    {
        public ElectricCar(string brand, string model, int year, string owner) : base(brand, model, year, owner)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Jazda na elektryczności!");
        }
    }

    class GasolineCar : Car
    {
        public GasolineCar(string brand, string model, int year, string owner) : base(brand, model, year, owner)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Jazda na benzynie!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Część 1:");
            ElectricCar EC1 = new ElectricCar("Tesla", "S Plaid", 2022, "Kamala");
            EC1.StartEngine();
            EC1.Drive();
            GasolineCar GC1 = new GasolineCar("Ferrari", "488 Pista",2017,"Donald");
            GC1.StartEngine();
            GC1.Drive();

            Console.WriteLine();
            Console.WriteLine("Część 2:");

            /*1. Sortowanie według Właściciela:
             Posortuj listę cars według właściciela w porządku alfabetycznym i wyświetl posortowaną listę.
            2. Sortowanie według Roku Produkcji:
             Posortuj listę cars według roku produkcji w porządku rosnącym i wyświetl posortowaną listę.
            3. Sortowanie według Marki:
             Posortuj listę cars według marki w porządku alfabetycznym i wyświetl posortowaną listę.
            4. Sortowanie według Modelu:
             Posortuj listę cars według modelu w porządku alfabetycznym i wyświetl posortowaną listę.*/

            ElectricCar EC2 = new ElectricCar("Rimac", "Nevera R", 2024, "Hamilton");
            GasolineCar GC2 = new GasolineCar("Ferrari", "Laferrari", 2018, "Massa");

            List<Car> cars = new List<Car> { EC1,GC1,EC2,GC2};

            Console.WriteLine("\nSortowanie według właściciela: ");
            var sortedByOwner = cars.OrderBy(b => b.Owner);
            foreach (var car in sortedByOwner)
            {
                Console.WriteLine(car.ToString());
            }


            Console.WriteLine("\nSortowanie według roku produkcji: ");
            cars.Sort();
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("\nSortowanie według marki alfabetycznie: ");
            var sortedByBrand = cars.OrderBy(b => b.Brand);
            foreach (var car in sortedByBrand)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("\nSortowanie według modelu alfabetycznie: ");
            var sortedByModel = cars.OrderBy(b => b.Model);
            foreach (var car in sortedByModel)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine();

            Console.WriteLine("Część 3:");

            Console.WriteLine("Wybierz jedną z opcji:");
            Console.WriteLine("1. Sortowanie według właściciela:\n" +
                "2. Sortowanie według roku produkcji:\n" +
                "3. Sortowanie według marki:\n" +
                "4. Sortowanie według modelu:\n" +
                "5. Wyjście:\n");

            int choice = GetValidInt("Wybierz opcję: ");


            switch (choice){
                case 1:
                    Console.WriteLine("\nSortowanie według właściciela: ");
                    foreach (var car in sortedByOwner)
                    {
                        Console.WriteLine(car.ToString());
                    }

                case 2:
                    Console.WriteLine("\nSortowanie według roku produkcji: ");
                    cars.Sort();
                    foreach (var car in cars)
                    {
                        Console.WriteLine(car.ToString());
                    }
                case 3:
                    Console.WriteLine("\nSortowanie według marki alfabetycznie: ");
                    foreach (var car in sortedByBrand)
                    {
                        Console.WriteLine(car.ToString());
                    }
                case 4:
                    Console.WriteLine("\nSortowanie według modelu alfabetycznie: ");
                    foreach (var car in sortedByModel)
                    {
                        Console.WriteLine(car.ToString());
                    }
                case 5:
                    Console.Clear();
                    Console.ReadKey();
                default:
                    Console.WriteLine("alo");
            }



            Console.ReadKey();

            int GetValidInt(string prompt)
            {
                int result;
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 6)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Zła liczba");
                    }
                }
            }
        }
    }
}
