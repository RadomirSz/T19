using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSal
{
    class ReservationService(
        IPricingService pricingService, 
        IDiscountPolicy discountPolicy,
        IRoomRepository roomRepo)
    {

    }
}
