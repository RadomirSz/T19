using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace _1_12_MVVM
{
    public partial class ViewModel1 : ObservableObject
    {
        [ObservableProperty]
        private int counter;

        [RelayCommand]
        private void IncrementCounter()
        {
            Counter++;
        }

        [RelayCommand]
        private void DecrementCounter()
        {
            Counter--;
        }
    }
}
