using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktopowka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ulica = TBulica.Text.Trim();
            string numerdomu = TBnumerdomu.Text.Trim();
            string kodpocztowy = TBkodpocztowy.Text.Trim();
            string miasto = TBmiasto.Text.Trim();

            if (ulica == "" || numerdomu == "" || kodpocztowy == "" || miasto == "")
            {
                komunikat.Text = "Pola nie mogą być puste";
                komunikat.Background = new SolidColorBrush(Colors.Red);
                return;
            }
            if (miasto.Length < 3)
            {
                komunikat.Text = "Miasto musi zawierać co najmniej 3 litery";
                komunikat.Background = new SolidColorBrush(Colors.Red);
                return;
            }
            if (kodpocztowy.Length != 6 || !kodpocztowy.Contains("-"))
            {
                komunikat.Text = "Kod pocztowy powinien składać się z 6 znaków i zawierać \"-\"";
                komunikat.Background = new SolidColorBrush(Colors.Red);
                return;
            }
            if(miasto != miasto.ToUpper())
            {
                komunikat.Text = "Miasto powinno być zapisane dużymi literami";
                komunikat.Background = new SolidColorBrush(Colors.Red);
                return;
            }
            komunikat.Text = "Adres poprawny";
            komunikat.Background = new SolidColorBrush(Colors.Green);
        }
    }
}