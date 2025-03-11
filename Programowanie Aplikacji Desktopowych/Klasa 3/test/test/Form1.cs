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

namespace test
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

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;


            Regex r = new Regex(@"^\d{7,9}$");
            
            if (!int.TryParse(text, out int number) || !r.IsMatch(text)) 
            {
                MessageBox.Show("Zły input");
                return; 
            }
            
            
            if(dziwneModulo7(number))
            {
                label1.Text = "Sigma";
            }
            else
            {
                label1.Text = "Beta";
            }
        }
        public bool dziwneModulo7(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int kon = number % 100;
                sum += mod7(kon);
                number = number / 100;
            }
            return mod7(sum) == 0;
        }
        public int mod7(int number)
        {
            int quotient = number / 7;
            return number - (quotient * 7);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
