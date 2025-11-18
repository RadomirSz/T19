using Microsoft.EntityFrameworkCore;
using System.Linq;
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

namespace _18_11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCategories();
        }

        public void LoadCategories() 
        {
            using (var context = new KoszykContext())
            {
                context.Database.EnsureCreated();
                var categories = context.Kategorie.ToList();
                comboBox1.ItemsSource = categories;
                comboBox1.DisplayMemberPath = "Nazwa";
                comboBox1.SelectedValuePath = "Id";
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int selectedCategoryId = (int)comboBox1.SelectedValue;

            using (var context = new KoszykContext())
            {
                List<Produkt> products;
                if (selectedCategoryId != 1)
                {
                    products = context.Produkty.Where(p => p.KategoriaId == selectedCategoryId)
                        .ToList();
                }
                else
                {
                    products = context.Produkty.ToList();
                }

                listBox1.ItemsSource = products;
                listBox1.DisplayMemberPath = "Nazwa";
            }
        }
    }
}