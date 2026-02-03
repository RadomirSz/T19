using System;

namespace System_Rezerwacji_Zaglowek_Online.Models
{
    public class SportYacht : Yacht
    {
        public SportYacht()
        {
            Type = YachtType.Sportowy;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("╔═════════════════════════════╗");
            Console.WriteLine("║ JACHT SPORTOWY - INFORMACJE ║");
            Console.WriteLine("╚═════════════════════════════╝");
            Console.WriteLine($"Nazwa: {Name}");
            Console.WriteLine($"Typ: {Type}");
            Console.WriteLine($"Pojemność: {Capacity} osób");
            Console.WriteLine($"Cena za dzień: {PricePerDay:C}");
            Console.WriteLine($"Kaucja: {Deposit:C}");
            Console.WriteLine($"Opis: {Description}");
        }
    }
}