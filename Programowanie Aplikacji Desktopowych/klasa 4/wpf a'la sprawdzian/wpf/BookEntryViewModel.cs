using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace wpf
{
    public partial class BookEntryViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title = "";
        [ObservableProperty]
        public string author = "";
        [ObservableProperty]
        public int year;
        [ObservableProperty]
        public int pages;

        [ObservableProperty]
        public string komunikat = "";

        [RelayCommand]
        public void Zapisz()
        {
            if (string.IsNullOrWhiteSpace(Title) || string.IsNullOrWhiteSpace(Author) || Year < 0 || Year > int.Parse(DateTime.Now.Year.ToString()) || Pages < 0)
            {
                Komunikat = "Złe dane! Spróbuj ponownie.";
                return;
            }
            else
            {
                Komunikat = $"{Author} - {Title}, wydana {Year} roku, stron:{Pages}";
            }
        }
        [RelayCommand]
        public void Wyczysc()
        {
           Title="";
           Author="";
           Year=0;
           Pages=0;
           Komunikat = "";
        }

    }
}
