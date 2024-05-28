using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_dziedziczenie_maszyny.classes
{
    internal class MenuManager
    {
        public void DisplayMenu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Wyświetl wszystkie maszyny");
            Console.WriteLine("2. Uruchom wszystkie maszyny");
            Console.WriteLine("3. Pracuj wszystkimi maszynami");
            Console.WriteLine("4. Zatrzymaj wszystkie maszyny");
            Console.WriteLine("5. Wyświetl status wszystkich maszyn");
            Console.WriteLine("6. Losowe awarie maszyn");
            Console.WriteLine("7. Napraw wszystkie maczyny");
            Console.WriteLine("8. Dodaj nowy typ maszyny");
            Console.WriteLine("9. Wyjdź");
            Console.WriteLine();
        }
        public string getuserinput() 
        {
            string input = Console.ReadLine();
            while(!isValidInput(input,1,9))
            {
                ShowErrorMessage("nieprawidłowa opcja, spróbuj ponownie: ");
            }
            return input;
        }

        private void ShowErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        private bool isValidInput(string input, byte min, byte max)
        {
            return int.TryParse(input,out int number) && number >= min && number <= max;
        }
        public void ExecuteAction
    }
}
