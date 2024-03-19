using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie_konstruktory.Properties;

namespace zadanie_konstruktory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car c1 = new Car();
			c1.DisplayInformation();
			Car c2 = new Car("Mercedes", "G class", 2001);
			c2.DisplayInformation();
			Car c3 = new Car("Mercedes", "G class", 2001, 3.5);
			c3.DisplayInformation();
			Car c4 = new Car("Mercedes", "G class", 2001, 3.5, false);
			c4.DisplayInformation();
			Car c5 = new Car("Mercedes", "G class", 2001, 3.5, false, new DateTime(2001,3,10), Car.CarStatus.New);
			c5.DisplayInformation();
			Console.WriteLine(c5.CalculateAge());
			Console.ReadKey();
		}
	}
}
