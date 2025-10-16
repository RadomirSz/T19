using System.Windows;

namespace _16_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Koszyk koszyk;
        public int currentProduct {  get; set; }
        public MainWindow()
        {
            koszyk = new Koszyk();
            InitializeComponent();
            InitializeProductViewer();
            currentProduct = 0;
        }
        

        public void InitializeProductViewer()
        {
            dane.Text = koszyk.Produkty.ElementAt(0).Nazwa;
            cena.Text = koszyk.Produkty.ElementAt(0).Cena.ToString();

            if(currentProduct == 0 ) btnPrev.IsEnabled = false;
            if (currentProduct == koszyk.Produkty.Count - 1) btnNext.IsEnabled = false;
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            btnNext.IsEnabled = true;
            if (currentProduct == 0) btnPrev.IsEnabled = false;

        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            btnPrev.IsEnabled = true;
            if (currentProduct == koszyk.Produkty.Count - 1) btnNext.IsEnabled = false;
        }
    }
}