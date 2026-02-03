using System;
using System_Rezerwacji_Zaglowek_Online.Models;

namespace System_Rezerwacji_Zaglowek_Online.Patterns
{
    //Budowniczy rezerwacji

    public class ReservationBuilder
    {
        private Reservation _reservation;

        public ReservationBuilder()
        {
            _reservation = new Reservation();
            Logger.Instance.Log("Rozpoczêto tworzenie nowej rezerwacji");
        }

        public ReservationBuilder SetUser(User user)
        {
            _reservation.User = user;
            Logger.Instance.Log($"Dodano u¿ytkownika: {user.FirstName} {user.LastName}");
            return this;
        }

        public ReservationBuilder SetYacht(Yacht yacht)
        {
            _reservation.Yacht = yacht;
            Logger.Instance.Log($"Wybrano jacht: {yacht.Name} ({yacht.Type})");
            return this;
        }

        public ReservationBuilder SetStartDate(DateTime startDate)
        {
            _reservation.StartDate = startDate;
            Logger.Instance.Log($"Data rozpoczêcia: {startDate:dd.MM.yyyy}");
            return this;
        }

        public ReservationBuilder SetEndDate(DateTime endDate)
        {
            _reservation.EndDate = endDate;
            Logger.Instance.Log($"Data zakoñczenia: {endDate:dd.MM.yyyy}");
            return this;
        }


        public ReservationBuilder SetLocation(string location)
        {
            _reservation.Location = location;
            Logger.Instance.Log($"Lokalizacja: {location}");
            return this;
        }


        private bool Validate()
        {
            if (_reservation.User == null)
            {
                Console.WriteLine("? B³¹d: Brak danych u¿ytkownika");
                return false;
            }

            if (_reservation.Yacht == null)
            {
                Console.WriteLine("? B³¹d: Nie wybrano jachtu");
                return false;
            }

            if (_reservation.StartDate == default)
            {
                Console.WriteLine("? B³¹d: Nie ustawiono daty rozpoczêcia");
                return false;
            }

            if (_reservation.EndDate == default)
            {
                Console.WriteLine("? B³¹d: Nie ustawiono daty zakoñczenia");
                return false;
            }

            if (_reservation.StartDate >= _reservation.EndDate)
            {
                Console.WriteLine("? B³¹d: Data rozpoczêcia musi byæ wczeœniejsza ni¿ data zakoñczenia");
                return false;
            }

            if (_reservation.StartDate < DateTime.Now.Date)
            {
                Console.WriteLine("? B³¹d: Data rozpoczêcia nie mo¿e byæ w przesz³oœci");
                return false;
            }

            if (string.IsNullOrWhiteSpace(_reservation.Location))
            {
                Console.WriteLine("? B³¹d: Nie ustawiono lokalizacji");
                return false;
            }

            return true;
        }


        public Reservation Build()
        {
            if (!Validate())
            {
                Logger.Instance.Log("?? Walidacja rezerwacji nie powiod³a siê");
                return null;
            }

            _reservation.CalculateTotalCost();
            Logger.Instance.Log(
                $"? Rezerwacja utworzona pomyœlnie. ID: {_reservation.ReservationId}, Koszt: {_reservation.TotalCost:C}");
            return _reservation;
        }

        public void Reset()
        {
            _reservation = new Reservation();
            Logger.Instance.Log("Builder zresetowany");
        }
    }
}