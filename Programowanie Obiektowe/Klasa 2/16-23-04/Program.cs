using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_23_04
{
    

    class Zwierze
    {
        public void dajGlos() { }
    }

    class Kot : Zwierze
    {
        public void drapmeble() { }
    }
    class Pers : Kot { }
    class NorweskiLesny
    {
        public void gubsiersc() { }
    }


    class Dawg : Zwierze
    {
        public void gryźkapcie() { }
    }

    class Jamnik : Dawg { }
    class Doberman
    {
        public void gonListonosza() { }
    }
    public enum FuelType
    { 
        Diesel,
        Petrol,
        Electric
    }
    public class Vehicle
    { 
        public string Brand {  get; set; }
        public string Model { get; set; }
        public double Fuel { get; private set; }
        public FuelType FuelType { get; protected set; }
        public ushort Speed { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("jedzie");
        }
        public virtual void StopEngine() { Console.WriteLine("stoi"); }

        public void refuel(double amount)
        {
            Fuel += amount;
            Console.WriteLine($"zatankowano {amount}L paliwa, obecny stan: {Fuel}L");
        }
    }
    public class Car : Vehicle
    { 
        public byte NumberofDoors {  get; set; }
        public int CurrentGear { get; set; }
        public int MaxGear { get; set; }
        public bool isAutomatic {  get; set; }
        public override void StartEngine(){Console.WriteLine("silnik auta wystartowal");}
        public override void StopEngine(){Console.WriteLine("auto stoi");}

       
    }

    internal class Program
    {
        static void Main(string[] args) 
        { 
            Vehicle v = new Vehicle();
            v.Brand = "Maserati";
            Console.WriteLine(v.Brand);
            v.StartEngine();
            v.StopEngine();
            v.refuel(3.2);
            v.refuel(2.3);


            Console.WriteLine();

            Car car = new Car();
            car.Brand = "Holden";
            Console.WriteLine(car.Brand);
            car.StartEngine();
            car.StopEngine();

            // jeszczee zmiana biegów była


            Console.ReadKey();
        }
    }
}
