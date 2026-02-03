using System_Rezerwacji_Zaglowek_Online.Models;

namespace System_Rezerwacji_Zaglowek_Online.Patterns
{
    public class YachtFactory
    {
        // zamiast enuma powinien byæ interface IYachtbuilder z funkcjami tworz¹cymi jachty ig TODO
        public Yacht CreateYacht(YachtType type)
        {
            Logger.Instance.Log($"Tworzenie jachtu typu: {type}");

            switch (type) 
            {
                case YachtType.Sportowy:
                    return CreateSportYacht();
                case YachtType.Turystyczny:
                    return CreateTouristYacht();
                case YachtType.Katamaran:
                    return CreateCatamaran();
                case YachtType.Trimaran:
                    return CreateTrimaran();
                default:
                    return null;
            }
        }

        private SportYacht CreateSportYacht()
        {
            return new SportYacht
            {
                Name = "Sea Racer 3000",
                Capacity = 4,
                PricePerDay = 800m,
                Deposit = 3000m,
                Description = "Szybki jacht sportowy idealny do regat i sportów wodnych"
            };
        }

        private TouristYacht CreateTouristYacht()
        {
            return new TouristYacht
            {
                Name = "Ocean Cruiser",
                Capacity = 8,
                PricePerDay = 1200m,
                Deposit = 5000m,
                Description = "Komfortowy jacht turystyczny z pe³nym wyposa¿eniem"
            };
        }

        private Catamaran CreateCatamaran()
        {
            return new Catamaran
            {
                Name = "Twin Wave 450",
                Capacity = 10,
                PricePerDay = 1800m,
                Deposit = 8000m,
                Description = "Dwukad³ubowy katamaran zapewniaj¹cy maksymaln¹ stabilnoœæ"
            };
        }

        private Trimaran CreateTrimaran()
        {
            return new Trimaran
            {
                Name = "Triple Storm",
                Capacity = 12,
                PricePerDay = 2200m,
                Deposit = 10000m,
                Description = "Trójkad³ubowy trimaran dla wymagaj¹cych ¿eglarzy"
            };
        }
    }
}