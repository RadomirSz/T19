using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace _10_12
{
    public partial class DeviceListViewModel : ObservableObject
    {
        [ObservableProperty]
        private int amount;

        public ObservableCollection<DeviceViewModel> devices { get; } = new();

        public DeviceListViewModel()
        {
            devices.Add(new DeviceViewModel { Id = 1, Name = "Lodówka", Temperature = 6.7f, Voltage = 300f, WorkHours = 24 });
            devices.Add(new DeviceViewModel { Id = 2, Name = "Telewizor", Temperature = 26.7f, Voltage = 400f, WorkHours = 6 });
            devices.Add(new DeviceViewModel { Id = 3, Name = "PC", Temperature = 36.7f, Voltage = 350f, WorkHours = 7 });
            amount = devices.Count();
        }
    }
}
