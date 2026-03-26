using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RezerwacjaSal
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ReservationService _reservationService;

        [ObservableProperty]
        private ObservableCollection<Room> rooms = new();

        [ObservableProperty]
        private Room? selectedRoom;

        [ObservableProperty]
        private int hours;

        [ObservableProperty]
        private decimal price;

        public MainViewModel(ReservationService reservationService, IRoomRepository roomRepository)
        {
            _reservationService = reservationService;
            Rooms = new ObservableCollection<Room>(roomRepository.GetAll());
            SelectedRoom = Rooms.Count > 0 ? Rooms[0] : null;
            Hours = 1;
        }

        [RelayCommand]
        public void Rezerwuj()
        {
            if (SelectedRoom is null)
            {
                Price = 0m;
                return;
            }

            Price = _reservationService.CalculateFinalPrice(SelectedRoom, Hours);
        }
    }
}
