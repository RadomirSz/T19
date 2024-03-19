using System;

namespace _10_2_16_01
{
    class Address 
    {
        public string City {get;set;}
        public string Street {get;set;}
        public string HouseNumber {get;set;}
        public string PostalCode {get;set;}

        public string getAddress()
        {
            return $"Miasto: {City}, ulica: {Street} {HouseNumber}, kod pocztowy: {PostalCode}";
        }
    }
}