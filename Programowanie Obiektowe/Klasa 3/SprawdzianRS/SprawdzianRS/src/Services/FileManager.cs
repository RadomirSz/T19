using System;
using System.IO;

namespace SprawdzianRS.src.Services
{
    public delegate void FileOperation(string filePath);

    public class FileManager
    {
        public static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var content = File.ReadAllText(filePath);
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
            var text = Console.ReadLine();
            File.WriteAllText(filePath, text);
            Console.WriteLine("Zapisano do pliku");
        }

        public static void ModifyFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.Write("Podaj tekst, który będzie dopisany do pliku");
                var text = Console.ReadLine();
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
            var newUsername = Console.ReadLine();
            Console.Write("Podaj hasło użytkownika: ");
            var newPassword = Console.ReadLine();
            PasswordManager.SavePassword(newUsername, newPassword);
            Console.WriteLine($"Dodano nowego użytkownika: {newUsername}");
        }
    }
}