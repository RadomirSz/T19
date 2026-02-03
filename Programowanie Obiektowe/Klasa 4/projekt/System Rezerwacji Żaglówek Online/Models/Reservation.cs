using System;

namespace System_Rezerwacji_Zaglowek_Online.Models
{
    public class Reservation // jachtu
    {
        public Reservation()
        {
            ReservationId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            ReservationDate = DateTime.Now;
        }

        public string ReservationId { get; set; }
        public User User { get; set; }
        public Yacht Yacht { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime ReservationDate { get; set; }

        public int GetDuration()
        {
            return (EndDate - StartDate).Days;
        }

        public void CalculateTotalCost()
        {
            var days = GetDuration();
            TotalCost = days * Yacht.PricePerDay + Yacht.Deposit;
        }

        public void DisplayReservation()
        {
            Console.WriteLine("\n╔══════════════════════════╗");
            Console.WriteLine("║ POTWIERDZENIE REZERWACJI ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.WriteLine($"\nID Rezerwacji: {ReservationId}");
            Console.WriteLine($"Data rezerwacji: {ReservationDate:dd.MM.yyyy HH:mm}");
            Console.WriteLine("\nDane klienta:");
            Console.WriteLine($"   {User}");
            Console.WriteLine("\nJacht:");
            Console.WriteLine($"   {Yacht}");
            Console.WriteLine($"\nLokalizacja: {Location}");
            Console.WriteLine($"Data rozpoczęcia: {StartDate:dd.MM.yyyy}");
            Console.WriteLine($"Data zakończenia: {EndDate:dd.MM.yyyy}");
            Console.WriteLine($"Długość wynajmu: {GetDuration()} dni");
            Console.WriteLine($"\nKoszt wynajmu: {GetDuration() * Yacht.PricePerDay:C}");
            Console.WriteLine($"Kaucja: {Yacht.Deposit:C}");
            Console.WriteLine("\n╔════════════════════════════╗");
            Console.WriteLine($"║ ŁĄCZNY KOSZT: {TotalCost:C}║");
            Console.WriteLine("╚════════════════════════════╝\n");
        }
    }
}