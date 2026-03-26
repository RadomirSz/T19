using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RezerwacjaSal
{
    public partial class MainViewModel : ObservableObject
    {
        private ObservableCollection<Room> rooms { get; } = new();

        [ObservableProperty]
        private int hours;

        [ObservableProperty]
        private float price;

        [RelayCommand]
        public void Rezerwuj()
        {
            // TODO
            // ig price * hours
        }
    }
}
