using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSal
{
    interface IDiscountPolicy
    {
        void ApplyDiscount(decimal price, int hours);
    }
}
