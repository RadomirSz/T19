using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSal
{
    public class ReservationService
    {
        private readonly IPricingService _pricingService;
        private readonly IDiscountPolicy _discountPolicy;
        private readonly IRoomRepository _roomRepository;

        public ReservationService(
            IPricingService pricingService,
            IDiscountPolicy discountPolicy,
            IRoomRepository roomRepository)
        {
            _pricingService = pricingService;
            _discountPolicy = discountPolicy;
            _roomRepository = roomRepository;
        }

        public decimal CalculateFinalPrice(Room room, int hours)
        {
            if (hours <= 0 || !_roomRepository.Exists(room.Name))
            {
                return 0m;
            }

            var basePrice = _pricingService.CalculatePrice(hours);
            return _discountPolicy.ApplyDiscount(basePrice, hours);
        }
    }
}
