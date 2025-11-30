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

namespace EgzaminProbnyDesktopowa
{
    /// <summary>
    /// 
    /// nazwa: ConvertValue
    ///     opis funkcji: Konwertuje wartość z jednej jednostki długości na inną
    /// parametry:
    /// value - wartość do konwersji,
    /// wejscie - jednostka wejściowa,
    /// wyjscie - jednostka wyjściowa
    ///     zwracany typ i opis: float - wartość po konwersji
    /// autor: 30
    ///
    /// nazwa: AddToHistory
    /// opis funkcji: Dodaje wpis do historii konwersji
    /// parametry:
    /// input - wartosc przed konwersją,
    /// output - wartosc po kowersji,
    /// wejscie - jednostka wartosci przed konwersją,
    /// wyjscie - jednostka wartosci po konwersji
    /// zwracany typ i opis: void - funkcja nie zwraca wartości, tylko dodaje wpis do historii
    /// autor: 30
    /// 
    /// </summary>
    enum Jednostki
    {
        Centymetr,
        Metry,
        Kilometry,
        Cal,
        Stopa,
        Mila
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Convert
        {
            Jednostki wejscie;
            int wybraneWejscie = ComboBox1.SelectedIndex;
            switch (wybraneWejscie)
            {
                case 1:
                    wejscie = Jednostki.Centymetr;
                    break;
                case 2:
                    wejscie = Jednostki.Metry;
                    break;
                case 3:
                    wejscie = Jednostki.Kilometry;
                    break;
                case 4:
                    wejscie = Jednostki.Cal;
                    break;
                case 5:
                    wejscie = Jednostki.Stopa;
                    break;
                case 6:
                    wejscie = Jednostki.Mila;
                    break;
                default:
                    MessageBox.Show("Wybierz jednostkę wejściową.");
                    return;
            }

            Jednostki wyjscie;
            int wybraneWyjscie = ComboBox2.SelectedIndex;
            switch (wybraneWyjscie)
            {
                case 1:
                    wyjscie = Jednostki.Centymetr;
                    break;
                case 2:
                    wyjscie = Jednostki.Metry;
                    break;
                case 3:
                    wyjscie = Jednostki.Kilometry;
                    break;
                case 4:
                    wyjscie = Jednostki.Cal;
                    break;
                case 5:
                    wyjscie = Jednostki.Stopa;
                    break;
                case 6:
                    wyjscie = Jednostki.Mila;
                    break;
                default:
                    MessageBox.Show("Wybierz jednostkę wyjściową.");
                    return;
            }

            if (!int.TryParse(TextBox1.Text, out int value))
            {
                MessageBox.Show("Podaj poprawną wartość liczbową.");
                return;
            }
            float result = ConvertValue(value, wejscie, wyjscie);

            Label1.Content = result;
            AddToHistory(value,result, wejscie, wyjscie);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "0";
            Label1.Content = "0";
        }
        private float ConvertValue(int value, Jednostki wejscie, Jednostki wyjscie)
        {
            if (wejscie == wyjscie) return value;
            float centimeters;
            switch (wejscie)
            {
                case Jednostki.Centymetr:
                    centimeters = value;
                    break;
                case Jednostki.Metry:
                    centimeters = value * 100f;
                    break;
                case Jednostki.Kilometry:
                    centimeters = value * 100000f;
                    break;
                case Jednostki.Cal:
                    centimeters = InchToCentimeter(value);
                    break;
                case Jednostki.Stopa:
                    centimeters = InchToCentimeter(value * 12);
                    break;
                case Jednostki.Mila:
                    centimeters = InchToCentimeter(value * 12 * 5280);
                    break;
                default:
                    return -1;
            }
            switch (wyjscie)
            {
                case Jednostki.Centymetr:
                    return centimeters;
                case Jednostki.Metry:
                    return CentimeterToMeter(centimeters);
                case Jednostki.Kilometry:
                    return MeterToKilometer(CentimeterToMeter(centimeters));
                case Jednostki.Cal:
                    return CentimeterToInch(centimeters);
                case Jednostki.Stopa:
                    return InchToFeet(CentimeterToInch(centimeters));
                case Jednostki.Mila:
                    return FeetToMile(InchToFeet(CentimeterToInch(centimeters)));
                default:
                    return -1;
            }
        }
        private float InchToCentimeter(float value)
        {
            return value * 2.54f;
        }
        private float CentimeterToMeter(float value)
        {
            return value / 100;
        }
        private float MeterToKilometer(float value)
        {
            return value / 1000;
        }
        private float CentimeterToInch(float value)
        {
            return value / 2.54f;
        }
        private float InchToFeet(float value)
        {
            return value / 12;
        }
        private float FeetToMile(float value)
        {
            return value / 5280;
        }
        private void AddToHistory(float input, float output, Jednostki wejscie, Jednostki wyjscie)
        {
            string log = $"{input} [{wejscie}] = {output} [{wyjscie}]";
            ListBoxHistory.Items.Insert(0,log);
            if(ListBoxHistory.Items.Count > 5) 
            {
                ListBoxHistory.Items.RemoveAt(5);
            }
        }
    }
}