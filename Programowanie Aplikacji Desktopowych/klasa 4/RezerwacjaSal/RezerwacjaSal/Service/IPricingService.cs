namespace RezerwacjaSal
{
    public interface IPricingService
    {
        decimal CalculatePrice(int hours);
    }

    public class HourlyPricingService : IPricingService
    {
        private const decimal HourlyRate = 100m;

        public decimal CalculatePrice(int hours)
        {
            if (hours <= 0)
            {
                return 0m;
            }

            return HourlyRate * hours;
        }
    }
}
