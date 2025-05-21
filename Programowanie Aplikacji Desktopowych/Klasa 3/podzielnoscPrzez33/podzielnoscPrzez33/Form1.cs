using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace podzielnoscPrzez33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool czyJestBilionowa(string number)
        {
            Regex regex = new Regex(@"^\d{13,15}$");
            return regex.IsMatch(number);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (!czyJestBilionowa(text))
            {
                MessageBox.Show("Zły input");
                return;
            }
            label1.Text = czySieDzieliPrzez33(text).ToString();
        }
        public bool czySieDzieliPrzez33(string number)
        {
            int sum = number[0];
            for (int i = 1; i < number.Length; i++)
            {
                if (i % 2 == 0) sum += number[i];
                else sum -= number[i];
            }

            int sumacyfr = 0;
            foreach (var i in number) {
                sumacyfr += i;
            }

            if (sum % 11 == 0 && sumacyfr % 3 == 0) return true;
            return false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
