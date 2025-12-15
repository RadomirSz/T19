using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EgzaminProbnyKonsolowa
{
    public class Program
    {
        public static List<Student> Students = new List<Student>();
        public static float[] Grades = new float[] { 2.0f, 3.0f, 3.5f, 4.0f, 4.5f, 5.0f };

        static void Main()
        {
            var running = true;
            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        DisplayStudents();
                        break;
                    case "4":
                        SortStudentsDesc();
                        break;
                    case "5":
                        AverageOfGrades();
                        break;
                    case "6":
                        DisplayChosenStudent();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Do zobaczenia!");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║                MENU GŁÓWNE                  ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("  1. Dodaj studenta");
            Console.WriteLine("  2. Usun studenta");
            Console.WriteLine("  3. Wypisz studentów");
            Console.WriteLine("  4. Sortuj po średniej malejąco");
            Console.WriteLine("  5. Srednia wszystkich studentów");
            Console.WriteLine("  6. Wyszukaj uczniów o danym nazwisku");
            Console.WriteLine("  0. Wyjście");
            Console.Write("\nWybierz opcję: ");
        }
        private static void AddStudent()
        {
            Console.WriteLine("Podaj Id:");
            int id = GetValidId();

            Console.WriteLine("Podaj imie:");
            string name = GetValidString();
            
            Console.WriteLine("Podaj nazwisko:");
            string surname = GetValidString();
            
            Console.WriteLine("Podaj srednią {2,0 / 3,0 / 3,5 / 4,0 / 4,5 / 5,0}:");
            float grade = GetValidGrade();

            Students.Add(new Student(id, name, surname, grade));
        }
        private static void RemoveStudent()
        {
            int Id = GetValidId();
            var student = Students.Find(s => s.Id == Id);
            if (student != null)
            {
                Students.Remove(student);
                Console.WriteLine("Student usunięty pomyślnie.");
                PressToContinue();
            }
            else
            {
                Console.WriteLine("Nie znaleziono studenta o podanym Id.");
                PressToContinue();
            }
        }
        private static void DisplayStudents()
        {
            Console.Clear();
            if (Students.Count == 0)
            {
                Console.WriteLine("Brak studentów do wyświetlenia.");
                return;
            }

            Console.WriteLine(new string('-', 67));
            Console.WriteLine($"| {"Id",-4} | {"Imię",-20} | {"Nazwisko",-20} | {"Średnia",-10} |");
            Console.WriteLine(new string('-', 67));

            foreach (var student in Students)
            {
                Console.WriteLine(
                    $"| {student.Id,-4} | {student.Name,-20} | {student.Surname,-20} | {student.Grade,-10:F1} |");
            }

            Console.WriteLine(new string('-', 67));
            PressToContinue();
        }
        private static void SortStudentsDesc()
        {
            Students = Students.OrderByDescending(s => s.Grade).ToList();
            DisplayStudents();
        }
        private static void AverageOfGrades()
        {
            float suma = Students.Sum(s => s.Grade);
            Console.Clear();
            Console.WriteLine("Srednia srednich: " + suma / Students.Count);
            PressToContinue();
        }
        private static void DisplayChosenStudent()
        {
            Console.WriteLine("Podaj nazwisko");
            string Surname = GetValidString();
            var foundStudents = Students.FindAll(s => s.Surname == Surname);
            foreach (var student in foundStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Imię: {student.Name}, Nazwisko: {student.Surname}, Średnia: {student.Grade}");
            }
            PressToContinue();
        }
        private static float GetValidGrade()
        {
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out float result) && Grades.Contains(result))
                {
                    return result;
                }
                Console.WriteLine("Podaj poprawną srednią");
            }
        }
        private static string GetValidString()
        {
            Regex r = new Regex(@"^[A-ZĄĆĘŁŃÓŚŹŻ][a-ząćęłńóśźż]+$");
            string input;
            while (!r.IsMatch(input = Console.ReadLine()))
                Console.WriteLine("Zacznij od dużej litery i kontynuuj bez spacji małymi literkami");
            
            return input;
        }
        private static int GetValidId()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result) && result >= 0 &&
                    Students.All(s => s.Id != result))
                {
                    return result;
                }

                Console.WriteLine("Podaj inne Id");
            }
        }
        private static void PressToContinue()
        {
            Console.WriteLine("Naciśnij guzik aby kontynuować...");
            Console.ReadKey();
        }
    }
}