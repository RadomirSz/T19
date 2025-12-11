using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace _11_12
{
    public partial class ShopViewModel : ObservableObject
    {
        public ObservableCollection<CustomerViewModel> Customers { get; } = new();
        public ObservableCollection<ProductViewModel> Products { get; } = new();

        [ObservableProperty]
        private int customerCount;

        [ObservableProperty]
        private decimal wareHouseValue;

        public ShopViewModel()
        {
            Products.Add(new ProductViewModel() { });
            Products.Add(new ProductViewModel() { });
            Products.Add(new ProductViewModel() { });

            Customers.Add(new CustomerViewModel() { });
            Customers.Add(new CustomerViewModel() { });
            Customers.Add(new CustomerViewModel() { });
        }

        [RelayCommand]
        private void CalculateAggregations()
        {
            customerCount = Customers.Count();
            wareHouseValue = Products.Sum(t => t.Price * t.Stock);
        }
    }
}
