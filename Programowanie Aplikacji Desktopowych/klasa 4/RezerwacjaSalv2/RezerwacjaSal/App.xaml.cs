using System.Windows;

namespace RezerwacjaSal
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IRoomRepository roomRepository = new InMemoryRoomRepository();
            IPricingService pricingService = new HourlyPricingService(100m);
            IDiscountPolicy discountPolicy = new LongReservationDiscountPolicy();

            var reservationService = new ReservationService(pricingService, discountPolicy, roomRepository);
            var mainViewModel = new MainViewModel(reservationService, roomRepository);
            var mainWindow = new MainWindow(mainViewModel);
            mainWindow.Show();
        }
    }

}
