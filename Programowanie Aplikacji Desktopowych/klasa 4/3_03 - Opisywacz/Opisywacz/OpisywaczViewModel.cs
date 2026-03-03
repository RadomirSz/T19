using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opisywacz
{
    public partial class OpisywaczViewModel : ObservableObject
    {
        [ObservableProperty]
        private string autor = "ja rs";

        [ObservableProperty]
        private string cecha1 = "";
        [ObservableProperty]
        private string nowaCecha1 = "";

        [ObservableProperty]
        private string cecha2 = "";
        [ObservableProperty]
        private string nowaCecha2 = "";

        [ObservableProperty]
        private string cecha3 = "";
        [ObservableProperty]
        private string nowaCecha3 = "";

        [ObservableProperty]
        private DateTime data;

        [ObservableProperty]
        private string wypisaneCechy;

        public OpisywaczViewModel()
        {
            Data = DateTime.Now;
        }

        [RelayCommand]
        private void WypiszCechy()
        {
            WypisaneCechy = Cecha1 + "\n" + Cecha2 + "\n" + Cecha3;
        }

        [RelayCommand]
        private void AktualizujCecha1()
        {
            Cecha1 = NowaCecha1;
        }

        [RelayCommand]
        private void UsunCeche1()
        {
            Cecha1 = "";
        }
        [RelayCommand]
        private void AktualizujCecha2()
        {
            Cecha2 = NowaCecha2;
        }

        [RelayCommand]
        private void UsunCeche2()
        {
            Cecha2 = "";
        }
        [RelayCommand]
        private void AktualizujCecha3()
        {
            Cecha3 = NowaCecha3;
        }

        [RelayCommand]
        private void UsunCeche3()
        {
            Cecha3 = "";
        }
    }
}
