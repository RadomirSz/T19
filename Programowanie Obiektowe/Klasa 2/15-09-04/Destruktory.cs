using Destruktory.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destruktory {
	internal class Program {
		static void Main(string[] args) 
		{
			/*Car c1 = new Car("Ferrari", 379.3);
			Car c2 = new Car("Porsche", 307.4);
			Car c3 = new Car("Koenigsegg", 498.8);

			c1.StartRace();
			c2.StartRace();			
			c3.StartRace();
			
			c1 = null;
			GC.Collect();*/


			List<Car> cars = new List<Car>();
			Dictionary<int,Car> carDict = new Dictionary<int,Car>();

			while (true) 
			{
				Console.Clear();
                Console.WriteLine("menu symulatora jazdy samochodem");

				Console.WriteLine("podaj liczbe");
				int ans = int.Parse(Console.ReadLine());
				switch (ans) 
				{
					case 1:
                        Console.WriteLine("daj marke i model");
						string marka = Console.ReadLine();
						string model = Console.ReadLine();
							
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						break;
				}
            }
		}
	}
}
