using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace _4_12
{
    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        private string firstname = "";
            
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        private string lastname ="";

        public string Fullname => $"{Firstname} {Lastname}";
    }
}
