using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            if (a != b)
            {
                if (suma_dzielnikow_wlasciwych(a) == b && a == suma_dzielnikow_wlasciwych(b))
                {
                    label1.Text = $"Liczby {a},{b} to liczby zaprzyjaźnione.";
                }
                else
                {
                    label1.Text = $"Liczby {a},{b} to nie liczby zaprzyjaźnione.";
                }
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int suma_dzielnikow_wlasciwych(int n)
        {
            int suma = 0;
            for (int i = 1; i < n; i++) if (n % i == 0) suma += i;
            return suma;
        }
    }
}
