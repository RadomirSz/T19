using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reszta
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
            int kwota = int.Parse(textBox1.Text);

            int[] nominaly = new int[6]{1,2,5,10,20,50};
            List<int> reszta = new List<int>();
            while (kwota > 0)
            {
                for (int i = 5; i > 0; i--)
                {
                    if (kwota >= nominaly[i])
                    {
                        reszta.Add(nominaly[i]);
                        kwota -= nominaly[i];
                        break;
                    }
                }
            }

            string output = "";
            foreach (var item in reszta)
            {
                output += item + " ";
            }
            label1.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
