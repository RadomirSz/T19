using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_12
{
    public partial class CustomerViewModel : ObservableObject
    {
        [ObservableProperty]
        private string firstName;
        [ObservableProperty]
        private string lastName;
        [ObservableProperty]
        private int orderCount;
        [ObservableProperty]
        private decimal totalSpent;
        [ObservableProperty]
        private bool isPremium;


    }
}
