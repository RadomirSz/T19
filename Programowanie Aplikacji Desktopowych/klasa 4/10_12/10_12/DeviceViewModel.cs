
using CommunityToolkit.Mvvm.ComponentModel;

namespace _10_12
{
    public partial class DeviceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id;
        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private float temperature;
        [ObservableProperty]
        private float voltage;
        [ObservableProperty]
        private int workHours;

    }
}
