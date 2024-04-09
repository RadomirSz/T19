using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destruktory.Properties {
	internal class Car {

		/*private string name;
		private double speed;
		public Car(string name, double speed)
		{ 
			this.name = name;
			this.speed = speed;
		}

		~Car()
		{
            Console.WriteLine($"samochód {name} został zniszczony");
        }
		public void StartRace()
		{
			Console.WriteLine($"samochód {name} zaczął wyścig");
		}*/


		public string Model { get; set; }
		public string Brand { get; set; }
		public bool IsDamaged { get; set; }

		public Car(string Model, string Brand) 
		{
			this.Model = Model;
			this.Brand = Brand;
			IsDamaged = false;	
		}

		~Car() 
		{
            Console.WriteLine($"samochód {Brand} {Model} jest zezłomowany");
        }

		public void Drive() 
		{
			if (IsDamaged) 
			{
                Console.WriteLine("not vroom >.<");
            }
			else 
			{
                Console.WriteLine("im a ferrari i go vroom VROOOOM");
            }

		}


	}
}	
