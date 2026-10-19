using System.Windows;
using System.Windows.Media;

namespace inf04czerwiec2025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int R, G, B;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onSliderRValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            R = (int)e.NewValue;
            Rlabel.Content = R;
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            rectangular.Background = new SolidColorBrush(color);
        }


        private void onSliderGValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            G = (int)e.NewValue;
            Glabel.Content = G;
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            rectangular.Background = new SolidColorBrush(color);
        }
        private void onSliderBValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            B = (int)e.NewValue;
            Blabel.Content = B;
            Color color = Color.FromRgb((byte)R, (byte)G, (byte)B);
            rectangular.Background = new SolidColorBrush(color);
        }
        private void ClickOnMyButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RGB: " + R +";"+ G +";"+ B);

        }

    }
}