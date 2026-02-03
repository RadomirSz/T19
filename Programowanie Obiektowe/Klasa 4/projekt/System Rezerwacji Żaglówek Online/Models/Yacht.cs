namespace System_Rezerwacji_Zaglowek_Online.Models
{
    public abstract class Yacht
    {
        public string Name { get; set; }
        public YachtType Type { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal Deposit { get; set; }
        public string Description { get; set; }

        public abstract void DisplayInfo();

        public override string ToString()
        {
            return $"{Name} ({Type}) - {Capacity} osób, {PricePerDay:C}/dzieñ, Kaucja: {Deposit:C}";
        }
    }
}