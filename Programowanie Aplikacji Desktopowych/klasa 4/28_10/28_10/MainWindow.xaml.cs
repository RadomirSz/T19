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

namespace _28_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = 0;
        List<Osoba> osoby;
        public MainWindow()
        {
            InitializeComponent();
            wczytajOsoby();
            wyswietl();
            btnPrevious.IsEnabled = false;
        }
        void wczytajOsoby()
        {
            OsobaBiznes biznes = new OsobaBiznes();
            osoby = biznes.pobierzOsoby();
        }
        void wyswietl()
        {
            txtImie.Text = osoby[index].Imie.ToString();
            txtWiek.Text = osoby[index].Wiek.ToString();
            txtHobby.Text = osoby[index].hobby.ToString();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            btnNext.IsEnabled = true;
            index--;
            if (index == 0) btnPrevious.IsEnabled = false;
            wyswietl();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            btnPrevious.IsEnabled = true;
            index++;
            if (index == osoby.Count-1) btnNext.IsEnabled = false;
            wyswietl();
        }
    }
}