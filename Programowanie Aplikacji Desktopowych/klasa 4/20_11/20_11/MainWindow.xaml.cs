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

namespace _20_11
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

        private string GetCheckedRadioButton()
        {
            if (redRadioButton.IsChecked == true)
                return "Red";
            else if (greenRadioButton.IsChecked == true)
                return "Green";
            else if (blueRadioButton.IsChecked == true)
                return "Blue";

            return null;
        }
    }
}