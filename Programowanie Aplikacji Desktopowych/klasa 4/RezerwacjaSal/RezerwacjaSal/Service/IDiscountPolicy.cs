namespace RezerwacjaSal
{
    public interface IDiscountPolicy
    {
        decimal ApplyDiscount(decimal price, int hours);
    }

    public class LongReservationDiscountPolicy : IDiscountPolicy
    {
        public decimal ApplyDiscount(decimal price, int hours)
        {
            if (hours >= 5)
            {
                return price * 0.9m;
            }

            return price;
        }
    }
}
