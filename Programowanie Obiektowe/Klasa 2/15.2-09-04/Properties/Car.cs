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

		public Car(string Brand, string Model) 
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
				return;
            }
            Console.WriteLine("im a ferrari i go vroom VROOOOM");
			
		}

        public void SimulateRandomDamage()
        {
            Random random = new Random();

            int damageType = random.Next(1, 4); //losuje liczby od 1 do 3

            switch (damageType)
            {
                case 1:
                    Console.WriteLine($"Samochód {Brand} {Model} ma przebitą oponę!");
                    break;
                case 2:
                    Console.WriteLine($"Silnik samochodu {Brand} {Model} jest uszkodzony!");
                    break;
                case 3:
                    Console.WriteLine($"Samochód {Brand} {Model} ma uszkodzone światło!");
                    break;
            }

            IsDamaged = true;

        }
    }
}	
