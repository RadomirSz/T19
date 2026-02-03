using System;
using System.Collections.Generic;
using System_Rezerwacji_Zaglowek_Online.Models;
using System_Rezerwacji_Zaglowek_Online.Services;

namespace System_Rezerwacji_Zaglowek_Online.Patterns
{
    public sealed class ApplicationState
    {
        private static ApplicationState _instance;
        private static readonly object _lock = new object();

        private readonly List<User> _registeredUsers;
        private readonly List<Reservation> _reservations;
        private User _currentUser;

        private ApplicationState()
        {
            _registeredUsers = new List<User>();
            _reservations = new List<Reservation>();
            Logger.Instance.Log("Stan aplikacji zainicjowany");
        }

        public static ApplicationState Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock) // 1 wątek na raz
                    {
                        if (_instance == null) _instance = new ApplicationState();
                    }

                return _instance;
            }
        }

        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                if (value != null) Logger.Instance.Log($"Zalogowano użytkownika: {value.FirstName} {value.LastName}");
            }
        }

        public void RegisterUser(User user)
        {
            _registeredUsers.Add(user);
            Logger.Instance.Log($"Zarejestrowano użytkownika: {user.FirstName} {user.LastName}");
        }

        public User GetUserByEmail(string email)
        {
            return _registeredUsers.Find(u => u.Email.Equals(email));
        }

        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
            Logger.Instance.Log($"Dodano rezerwację: {reservation.ReservationId}");
        }

        public List<Reservation> GetUserReservations(User user)
        {
            return _reservations.FindAll(r => r.User.Email == user.Email);
        }

        public List<Reservation> GetAllReservations() //admin
        {
            return new List<Reservation>(_reservations);
        }

        public void DisplayAllReservations()
        {
            Console.WriteLine("\n╔═══════════════════════════════════╗");
            Console.WriteLine("║       WSZYSTKIE REZERWACJE        ║");
            Console.WriteLine("╚═══════════════════════════════════╝");

            var apiService = new ReservationApiService();
            var task = apiService.GetReservationsAsync();
            task.Wait();
            var reservations = task.Result;

            if (reservations.Count == 0)
                Console.WriteLine("Brak rezerwacji w systemie.");
            else
                foreach (var reservation in reservations)
                {
                    Console.WriteLine($"\nID: {reservation.ReservationId}");
                    Console.WriteLine($"Klient: {reservation.User.FirstName} {reservation.User.LastName}");
                    Console.WriteLine($"Jacht: {reservation.Yacht.Name}");
                    Console.WriteLine($"{reservation.StartDate:dd.MM.yyyy} - {reservation.EndDate:dd.MM.yyyy}");
                    Console.WriteLine($"Koszt: {reservation.TotalCost:C}");
                    Console.WriteLine("───────────────────────────────────");
                }

            Console.WriteLine("═══════════════════════════════════\n");
        }
    }
}