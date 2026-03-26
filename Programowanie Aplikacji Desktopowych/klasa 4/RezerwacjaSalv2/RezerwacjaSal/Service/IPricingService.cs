namespace RezerwacjaSal
{
    public interface IPricingService
    {
        decimal CalculatePrice(int hours);
    }

    public class HourlyPricingService : IPricingService
    {
        private readonly decimal _HourlyRate;
        
        public HourlyPricingService(decimal hourlyRate)
        {
            _HourlyRate = hourlyRate;
        }

        public decimal CalculatePrice(int hours)
        {
            if (hours <= 0)
            {
                return 0m;
            }

            return _HourlyRate * hours;
        }
    }
}
