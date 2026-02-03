using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System_Rezerwacji_Zaglowek_Online.Models;
using System_Rezerwacji_Zaglowek_Online.Patterns;
using System_Rezerwacji_Zaglowek_Online.Services;

namespace System_Rezerwacji_Zaglowek_Online
{
    internal class Program
    {
        private static readonly Logger logger = Logger.Instance;
        private static readonly ApplicationState appState = ApplicationState.Instance;
        private static readonly YachtFactory yachtFactory = new YachtFactory();

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            logger.Log("Aplikacja została uruchomiona");

            var running = true;
            while (running)
            {
                DisplayMainMenu();
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterNewUser();
                        break;
                    case "2":
                        LoginUser();
                        break;
                    case "3":
                        CreateReservation();
                        break;
                    case "4":
                        DisplayAvailableYachts();
                        break;
                    case "5":
                        DisplayUserReservations();
                        break;
                    case "6":
                        appState.DisplayAllReservations();
                        break;
                    case "7":
                        logger.DisplayAllLogs();
                        break;
                    case "8":
                        DisplayCurrentUser();
                        break;
                    case "9":
                        LogoutUser();
                        break;
                    case "0":
                        running = false;
                        logger.Log("Aplikacja została zamknięta");
                        Console.WriteLine("\nDziękujemy za skorzystanie z systemu. Do zobaczenia!");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║                MENU GŁÓWNE                  ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine("  1. Zarejestruj nowego użytkownika");
            Console.WriteLine("  2. Zaloguj się");
            Console.WriteLine("  3. Utwórz rezerwację");
            Console.WriteLine("  4. Wyświetl dostępne jachty");
            Console.WriteLine("  5. Moje rezerwacje");
            Console.WriteLine("  6. Wszystkie rezerwacje (admin)");
            Console.WriteLine("  7. Wyświetl logi systemowe");
            Console.WriteLine("  8. Informacje o zalogowanym użytkowniku");
            Console.WriteLine("  9. Wyloguj się");
            Console.WriteLine("  0. Wyjście");
            Console.Write("\nWybierz opcję: ");
        }

        private static void RegisterNewUser()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║    REJESTRACJA NOWEGO UŻYTKOWNIKA     ║");
            Console.WriteLine("╚═══════════════════════════════════════╝\n");

            // Walidacja imienia
            string firstName;
            do
            {
                Console.Write("Imię: ");
                firstName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("Imię nie może być puste!");
                }
            } while (string.IsNullOrWhiteSpace(firstName));

            // Walidacja nazwiska
            string lastName;
            do
            {
                Console.Write("Nazwisko: ");
                lastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Nazwisko nie może być puste!");
                }
            } while (string.IsNullOrWhiteSpace(lastName));

            // Walidacja emaila
            Regex emailRegex = new Regex("^[A-Za-z0-9]+@[A-Za-z0-9]+\\.[A-Za-z0-9]+$");
            string email;
            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email) || !emailRegex.IsMatch(email))
                {
                    Console.WriteLine("Email musi zawierać @ oraz kropkę po @. Spróbuj ponownie.");
                }
            } while (string.IsNullOrWhiteSpace(email) || !emailRegex.IsMatch(email));

            // Walidacja numeru telefonu
            Regex phoneNumberRegex = new Regex("^\\d{9}$");
            string phone;
            do
            {
                Console.Write("Numer telefonu (9 cyfr): ");
                phone = Console.ReadLine();
                // Usuń spacje przed walidacją
                if (phone != null)
                {
                    phone = phone.Replace(" ", "");
                }
                if (string.IsNullOrWhiteSpace(phone) || !phoneNumberRegex.IsMatch(phone))
                {
                    Console.WriteLine("Numer telefonu musi składać się z dokładnie 9 cyfr. Spróbuj ponownie.");
                }
            } while (string.IsNullOrWhiteSpace(phone) || !phoneNumberRegex.IsMatch(phone));

            var newUser = new User(firstName, lastName, email, phone);
            appState.RegisterUser(newUser);

            Console.WriteLine($"\nUżytkownik {firstName} {lastName} został zarejestrowany pomyślnie!");
        }

        private static void LoginUser()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║          LOGOWANIE           ║");
            Console.WriteLine("╚══════════════════════════════╝\n");

            Console.Write("Podaj email: ");
            var email = Console.ReadLine();

            var user = appState.GetUserByEmail(email);

            if (user != null)
            {
                appState.CurrentUser = user;
                Console.WriteLine($"\nZalogowano pomyślnie! Witaj, {user.FirstName}!");
            }
            else
            {
                Console.WriteLine("\nNie znaleziono użytkownika o podanym adresie email.");
            }
        }

        private static void CreateReservation()
        {
            if (appState.CurrentUser == null)
            {
                Console.WriteLine("\nMusisz być zalogowany, aby utworzyć rezerwację!");
                return;
            }

            Console.Clear();
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║      TWORZENIE REZERWACJI      ║");
            Console.WriteLine("╚════════════════════════════════╝\n");

            // Factory Method
            Console.WriteLine("Wybierz typ jachtu:");
            Console.WriteLine("  1. Sportowy");
            Console.WriteLine("  2. Turystyczny");
            Console.WriteLine("  3. Katamaran");
            Console.WriteLine("  4. Trimaran");
            Console.Write("\nWybór: ");

            var yachtChoice = Console.ReadLine();
            YachtType selectedType;

            switch (yachtChoice)
            {
                case "1":
                    selectedType = YachtType.Sportowy;
                    break;
                case "2":
                    selectedType = YachtType.Turystyczny;
                    break;
                case "3":
                    selectedType = YachtType.Katamaran;
                    break;
                case "4":
                    selectedType = YachtType.Trimaran;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór!");
                    return;
            }

            // Factory Method
            var yacht = yachtFactory.CreateYacht(selectedType);

            Console.Write("\nPodaj lokalizację (np. Gdynia, Sopot, Gdańsk): ");
            var location = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(location))
            {
                Console.Write("Lokalizacja nie może być pusta. Podaj lokalizację: ");
                location = Console.ReadLine();
            }

            Console.Write("\nData rozpoczęcia (dd.MM.yyyy): ");
            DateTime startDate;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null,
                       DateTimeStyles.None, out startDate))
                Console.Write("Nieprawidłowy format. Podaj datę w formacie dd.MM.yyyy: ");


            Console.Write("Data zakończenia (dd.MM.yyyy): ");
            DateTime endDate;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null,
                       DateTimeStyles.None, out endDate))
                Console.Write("Nieprawidłowy format. Podaj datę w formacie dd.MM.yyyy: ");

            // Builder Pattern
            var builder = new ReservationBuilder();
            var reservation = builder
                .SetUser(appState.CurrentUser)
                .SetYacht(yacht)
                .SetLocation(location)
                .SetStartDate(startDate)
                .SetEndDate(endDate)
                .Build();

            if (reservation != null)
            {
                appState.AddReservation(reservation);

                Console.Clear();
                reservation.DisplayReservation();

                // wyslanie do serwera
                var apiService = new ReservationApiService();
                var task = apiService.SendReservationAsync(reservation);
                task.Wait();

                if (task.Result)
                    Console.WriteLine("Rezerwacja wysłana do serwera pomyślnie!");
                else
                    Console.WriteLine("Nie udało się wysłać rezerwacji do serwera.");

                Console.WriteLine("\nRezerwacja utworzona!");
            }
            else
            {
                Console.WriteLine("\nNie udało się utworzyć rezerwacji.");
            }
        }

        private static void DisplayAvailableYachts()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║              DOSTĘPNE JACHTY            ║");
            Console.WriteLine("╚═════════════════════════════════════════╝\n");

            var yachtTypes = new List<YachtType>
            {
                YachtType.Sportowy,
                YachtType.Turystyczny,
                YachtType.Katamaran,
                YachtType.Trimaran
            };

            foreach (var type in yachtTypes)
            {
                var yacht = yachtFactory.CreateYacht(type);
                yacht.DisplayInfo();
                Console.WriteLine();
            }
        }

        private static void DisplayUserReservations()
        {
            logger.Log("Wywołano DisplayUserReservations");

            if (appState.CurrentUser == null)
            {
                Console.WriteLine("\nMusisz być zalogowany, aby zobaczyć swoje rezerwacje!");
                return;
            }

            Console.Clear();
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          MOJE REZERWACJE           ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");

            var apiService = new ReservationApiService();
            var task = apiService.GetUserReservationsAsync(appState.CurrentUser.Email);
            task.Wait();
            var userReservations = task.Result;

            if (userReservations.Count == 0)
                Console.WriteLine("Nie masz jeszcze żadnych rezerwacji.");
            else
                foreach (var reservation in userReservations)
                    reservation.DisplayReservation();
        }

        private static void DisplayCurrentUser()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║   INFORMACJE O UŻYTKOWNIKU    ║");
            Console.WriteLine("╚═══════════════════════════════╝\n");

            if (appState.CurrentUser != null)
            {
                Console.WriteLine("Zalogowany jako:");
                Console.WriteLine($"   {appState.CurrentUser}");
            }
            else
            {
                Console.WriteLine("Brak zalogowanego użytkownika.");
            }
        }

        private static void LogoutUser()
        {
            if (appState.CurrentUser != null)
            {
                var userName = appState.CurrentUser.FirstName;
                appState.CurrentUser = null;
                logger.Log($"Użytkownik {userName} został wylogowany");
                Console.WriteLine($"\nWylogowano pomyślnie. Do zobaczenia, {userName}!");
            }
            else
            {
                Console.WriteLine("\nNie jesteś zalogowany.");
            }
        }
    }
}