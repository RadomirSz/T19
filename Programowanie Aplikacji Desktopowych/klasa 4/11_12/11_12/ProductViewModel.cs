using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_12
{
    public partial class ProductViewModel: ObservableObject
    {
        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private decimal price;
        [ObservableProperty]
        private int stock;
        [ObservableProperty]
        private bool isAvailable;
        [ObservableProperty]
        private string category;
    }
}
