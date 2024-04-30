using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
		public string Brand { get; set; }
		public string Model { get; set; }
		public double Fuel { get; private set; }
		public FuelType FuelType { get; set; }
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
		public byte NumberofDoors { get; set; }
		public int CurrentGear { get; set; }
		public int MaxGear { get; set; }
		public bool isAutomatic { get; set; }
		public override void StartEngine() { Console.WriteLine("silnik auta wystartowal"); }
		public override void StopEngine() { Console.WriteLine("auto stoi"); }


	}
	public class ElectricCar : Car
	{
		public double BatteryCapacity { get; set; }
		public override void StartEngine()
		{
            Console.WriteLine("system włączony");
        }
		public override void StopEngine()
		{
            Console.WriteLine("system wyłączony");
        }
		public void ChargeBattery(double kWh)
		{
			if (kWh <= 0)
			{

			}
            else
            {
				AnimationHelper.ShowProgress();
			}
		}
	}
	public class truck : Vehicle
	{
	public double LoadCapacity {  get; set; }
	}
	class AnimationHelper
	{
		public static void ShowProgress(string prefix,string suffix,int delay,int totalSteps)
		{
            for (int i = 0; i < totalSteps; i++)
            {
                Console.WriteLine($"\r{prefix}[{new string('|',i)}{new string('.',totalSteps-1)}]{suffix} {i*100/totalSteps}%");
				Thread.Sleep(delay);
            }
        }
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Vehicle v = new Vehicle();
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


			Console.ReadKey();*/

			ElectricCar Rimac = new ElectricCar {
				Brand = "Rimac",
			Model = "Nevera",
			NumberofDoors = 4,
			FuelType = FuelType.Electric,
			MaxGear = 1,
			isAutomatic = true,
			BatteryCapacity = 95


		};
		Rimac.StartEngine();
			Rimac.ChargeBattery(10);

		}
	}
}
