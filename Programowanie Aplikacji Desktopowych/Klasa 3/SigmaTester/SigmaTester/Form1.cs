using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Text;
            int suma = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int number;
                bool czyliczba = int.TryParse(Convert.ToString(data[i]), out number);
                suma += number;
            }

            if (czytakiesame(suma))
            {
                label2.Text = "Jesteś sigmom";
            }
            else
            {
                label2.Text = "Nie jesteś sigmom";
            }


            bool czytakiesame(int a)
            {
                string b = Convert.ToString(a);
                foreach (var item in b)
                {
                    if (item != b[0])
                    { 
                        return false;
                    }
                }
                return true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
