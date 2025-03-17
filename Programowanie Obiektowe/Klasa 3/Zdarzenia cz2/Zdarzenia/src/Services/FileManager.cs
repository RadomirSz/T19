using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia.src.Services
{

    public class FileManager
    {
        public static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("Zawartość pliku:\n" + content);
            }
            else
            {
                Console.WriteLine("Plik nie istnieje");
            }
        }

        public static void WriteToFile(string filePath)
        {
            Console.Write("Podaj tekst do zapisania w pliku: ");
            string text = Console.ReadLine();
            File.WriteAllText(filePath, text);
            Console.WriteLine("Zapisano do pliku");
        }

        public static void ModifyFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.Write("Podaj tekst, który będzie dopisany do pliku");
                string text = Console.ReadLine();
                File.AppendAllText(filePath, Environment.NewLine + text);
                Console.WriteLine("Zmodyfikowano plik");
            }
            else
            {
                Console.WriteLine("Plik nie istnieje");
            }
        }

        public static void AddNewUser()
        {
            Console.Write("Podaj nazwę użytkownika: ");
            string newUsername = Console.ReadLine();

            Console.Write("Podaj hasło użytkownika: ");
            string newPassword = Console.ReadLine();

            PasswordManager.SavePassword(newUsername, newPassword);
            Console.WriteLine($"Dodano nowego użytkownika: {newUsername}");
        }
    }
}
