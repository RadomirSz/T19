using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSal
{
    interface IPricingService
    {
        void CalculatePrice(int hours);
    }
}
