using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Linq;
using Zdarzenia.src.Services;
using Zdarzenia.src.Models;
using Zdarzenia.src.Enums;

namespace zdarzenia_1
{
    internal class Program
    {
        public delegate void FileOperation(string filePath);

        static void Main(string[] args)
        {
            PasswordManager.PasswordVerified += (username, success) => Console.WriteLine($"Logowanie użytkownika {username}: {(success ? "udane" : "nieudane")}");

            PasswordManager.SavePassword("admin", "pass");
            PasswordManager.SavePassword("manager", "pass");
            PasswordManager.SavePassword("normalUser", "pass");
            PasswordManager.SavePassword("xyz", "pass");

            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.Clear();
                Console.WriteLine("=== System logowania ===");

                Console.Write("\nWprowadź nazwę użytkownika:");
                string username = Console.ReadLine();

                Console.Write("\nWprowadź hasło:");
                string password = Console.ReadLine();

                if (!PasswordManager.VerifyPassword(username, password))
                {
                    Console.WriteLine("Niepoprawna nazwa użytkownika lub hasło");
                    Console.ReadKey();
                    continue;
                }

                var user = new User(username);

                if (username == "admin") user.AddRole(Role.Administrator);
                else if (username == "manager") user.AddRole(Role.Manager);
                else if (username == "normalUser") user.AddRole(Role.User);

                var rbacSystem = new RBAC();
                string filePath = "testFile.txt";

                bool logout = false;
                while (!logout)
                {
                    Console.Clear();
                    Console.WriteLine($"Zalogowano jako: {username}");
                    Console.WriteLine("\nWybierz opcję:");
                    if (rbacSystem.HasPermission(user, Permission.Read))
                        Console.WriteLine("1. Odczytaj plik");
                    if (rbacSystem.HasPermission(user, Permission.Write))
                        Console.WriteLine("2. Zapisz do pliku");
                    if (rbacSystem.HasPermission(user, Permission.Delete))
                        Console.WriteLine("3. Modyfikuj plik");
                    if (rbacSystem.HasPermission(user, Permission.ManageUsers))
                        Console.WriteLine("4. Dodaj nowego użytkownika");
                    Console.WriteLine("5. Wyloguj się");
                    Console.WriteLine("6. Wyjdź z programu");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            FileManager.ReadFile(filePath); break;
                        case 2:
                            if (rbacSystem.HasPermission(user, Permission.Write))
                                FileManager.WriteToFile(filePath);
                            else
                                Console.WriteLine("Nie masz uprawnień");
                            break;
                        case 3:
                            if (rbacSystem.HasPermission(user, Permission.Delete))
                                FileManager.ModifyFile(filePath);
                            else
                                Console.WriteLine("Nie masz uprawnień");
                            break;
                        case 4:
                            if (rbacSystem.HasPermission(user, Permission.ManageUsers))
                                FileManager.AddNewUser();
                            else
                                Console.WriteLine("Nie masz uprawnień");
                            break;
                        case 5:
                            Console.WriteLine("Wylogowano");
                            logout = true;
                            break;
                        case 6:
                            Console.WriteLine("Zamykanie programu");
                            exitProgram = true;
                            return;
                        default:
                            Console.WriteLine("Niepoprawny wybór");
                            break;
                    }

                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Dziękujemy za skorzystanie z programu");









            /*Console.WriteLine("\nSprawdzanie dostępu do różnych zasobów:");
            Console.WriteLine("Read: " + rbacSystem.HasPermission(user, Permission.Read));
            Console.WriteLine("Write: " + rbacSystem.HasPermission(user, Permission.Write));
            Console.WriteLine("Delete: " + rbacSystem.HasPermission(user, Permission.Delete));*/
        }
    }
}




