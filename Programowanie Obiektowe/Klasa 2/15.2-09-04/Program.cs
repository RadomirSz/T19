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
			Dictionary<int,Car> carDictionary = new Dictionary<int,Car>();

            while (true)
            {
                DisplayMenu();
                int choice = GetUserInput();

                switch (choice)
                {
                    case 1:
                        AddCar(cars,carDictionary);
                        break;
                    case 2:
                        DisplayCars(carDictionary);
                        break;
                    case 3:
                        DisplayCars(carDictionary);
                        DriveCar(carDictionary);
                        break;
                    case 4:
                        DisplayCars(carDictionary);
                        SimulateDamage(carDictionary);
                        break;
                    case 5:
                        DisplayCars(carDictionary);
                        if (carDictionary.Count != 0)
                        {
                            ScrapCar(cars, carDictionary);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Zamykanie symulatora.");
                        return;
                    default:
                        break;
                }
            }
        }

        private static void ScrapCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            int carNumber = GetUserInput();


            Console.WriteLine($"usunięto {carDictionary[carNumber].Brand} {carDictionary[carNumber].Model}");
            cars.RemoveAt(carNumber - 1);
            carDictionary.Remove(carNumber);

            Console.WriteLine("Naciśnij dowolny klawisz by przejść dalej");
            Console.ReadKey();
        }
        private static void SimulateDamage(Dictionary<int, Car> carDictionary)
        {
            int carNumber = GetUserInput(carDictionary);
            Car carToSimulateDamage = carDictionary[carNumber];
            carToSimulateDamage.SimulateRandomDamage();
            Console.WriteLine("Naciśnij dowolny klawisz by przejść dalej");
            Console.ReadKey();
        }

        private static void DriveCar(Dictionary<int, Car> carDictionary)
        {
            Console.WriteLine();

            int carNumber = GetUserInput(carDictionary);
            Car CarToDrive = carDictionary[carNumber];
            CarToDrive.Drive();
            Console.WriteLine("Naciśnij dowolny klawisz by przejść dalej");
            Console.ReadKey();
        }

        private static void DisplayCars(Dictionary<int, Car> carDictionary)
        {
            Console.WriteLine();
            
            if (carDictionary.Count > 0)
            {
                Console.WriteLine("Lista samochodów:");
                foreach (var carEntry in carDictionary)
                {
                    int key = carEntry.Key;
                    Car car = carEntry.Value;
                    Console.WriteLine($"klucz:{key}, marka: {car.Brand}, model: {car.Model}");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Nie ma jeszcze żadnych aut");
            }
            Console.WriteLine("Naciśnij dowolny klawisz by przejść dalej");
            Console.ReadKey();
        }

        private static void AddCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            Console.Clear();
            Console.Write("Podaj markę samochodu:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model samochodu:");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDictionary[cars.Count] = newCar;
            Console.WriteLine("Samochód dodany pomyślnie");
            Console.WriteLine("Naciśnij dowolny klawisz by przejść dalej");
            Console.ReadKey();
        }

        private static int GetUserInput(Dictionary<int, Car> carDictionary = null)
        {
            int input;
            while (true)
            {
                Console.Write("Podaj wartość(int): ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (carDictionary == null || carDictionary.ContainsKey(input))
                    {
                        return input;
                    }
                    Console.WriteLine("wartość nie istnieje w słowniku");
                }
                else 
                {
                    Console.WriteLine("nieprawidłowy format, spróbuj ponownie");
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu symulatora jazdy samochodem");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl listę samochodów");
            Console.WriteLine("3. Jedź samochodem");
            Console.WriteLine("4. Symuluj losowe uszkodzenie");
            Console.WriteLine("5. Zezłomuj samochód");
            Console.WriteLine("6. Wyjście");
        }
    }
}
