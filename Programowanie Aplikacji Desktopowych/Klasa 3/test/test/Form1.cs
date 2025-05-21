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
            
            

            label1.Text = czysiedzieliprzez7(number).ToString();
        }
        public bool czysiedzieliprzez7(int number)
        {
            string sr = "";
            while (number > 0)
            {
                int kon = number % 100;
                sr = sr + kon % 7;
                number = number / 100;
            }
            int sum = 0;
            foreach (var item in sr)
            {
                sum += item;
            }
            if(sum %7 == 0) return true;
            return false;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
