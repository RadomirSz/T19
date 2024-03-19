using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_konstruktory.Properties
{
	internal class Car
	{
		private string Brand;
		private string Model;
		private int YearOfProduction;
		private double EngineSize;
		private bool isDiesel;
		private DateTime DateOfPurchase;
		private CarStatus Status;
		public enum CarStatus
		{ 
			New,
			Used,
			Antique
		}
		public Car()
		{ 
			Brand = "Unknown";
			Model = "Unknown";
			YearOfProduction = 0;
			EngineSize = 0;
			isDiesel = false;
			DateOfPurchase = DateTime.MinValue;
		}

		public Car(string Brand, string Model, int YearOfProduction) : this()
		{
			this.Brand = Brand;
			this.Model = Model;
			this.YearOfProduction = YearOfProduction; 
		}

		public Car(string Brand, string Model, int YearOfProduction,double EngineSize) : this(Brand,Model,YearOfProduction)
		{
			this.EngineSize = EngineSize;
		}

		public Car(string Brand, string Model, int YearOfProduction, double EngineSize,bool isDiesel) : this(Brand, Model, YearOfProduction,EngineSize)
		{ 
			this.isDiesel = isDiesel;
		}
		public Car(string Brand, string Model, int YearOfProduction, double EngineSize, bool isDiesel, DateTime DateOfPurchase, CarStatus Status) : this(Brand, Model, YearOfProduction, EngineSize, isDiesel)
		{ 
			this.DateOfPurchase = DateOfPurchase;
			this.Status = Status;
		}

		public void DisplayInformation()
		{
            Console.WriteLine("Brand: " + Brand);
			Console.WriteLine("Model: " + Model);
			Console.WriteLine("Year of production: " + YearOfProduction);
			Console.WriteLine("Engine size: " + EngineSize);
			Console.WriteLine("Date of purchase: " + DateOfPurchase);
			Console.WriteLine("Status: " + Status);
        }

		public int CalculateAge()
		{ 
			int Age = DateTime.Now.Year - DateOfPurchase.Year;
			if (DateTime.Now.Month < DateOfPurchase.Month || DateTime.Now.Day < DateOfPurchase.Day && DateTime.Now.Year == DateOfPurchase.Year) Age--;
			return Age;
		}
	}
}
