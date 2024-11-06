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

namespace regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            string email = textBox1.Text;
            string haslo = textBox2.Text;
            string haslo2 = textBox3.Text;

            string p = @".*@.*";
            Regex r = new Regex(p);
            if (r.IsMatch(email))
            {
                label5.Text += $"Witaj {email}!";
            }
            else 
            {
                label5.Text += "Podano złego emaila!";
            }

            if(haslo != haslo2)
            {
                label5.Text += " Podano różne hasła!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
