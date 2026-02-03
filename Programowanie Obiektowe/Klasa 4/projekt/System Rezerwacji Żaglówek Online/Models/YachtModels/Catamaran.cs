using System;

namespace System_Rezerwacji_Zaglowek_Online.Models
{
    public class Catamaran : Yacht
    {
        public Catamaran()
        {
            Type = YachtType.Katamaran;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║ KATAMARAN - INFORMACJE ║");
            Console.WriteLine("╚════════════════════════╝");
            Console.WriteLine($"Nazwa: {Name}");
            Console.WriteLine($"Typ: {Type}");
            Console.WriteLine($"Pojemność: {Capacity} osób");
            Console.WriteLine($"Cena za dzień: {PricePerDay:C}");
            Console.WriteLine($"Kaucja: {Deposit:C}");
            Console.WriteLine($"Opis: {Description}");
        }
    }
}