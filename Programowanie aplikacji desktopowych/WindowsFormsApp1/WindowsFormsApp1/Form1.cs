using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bye")
            {
                Close();
            }
            else 
            {
                MessageBox.Show(DateTime.Now.ToString("MMMM"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("F"));
            MessageBox.Show(DateTime.Now.ToString("t"));


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nwd(int a, int b)
            {
                while (b > 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }
                return a;
            }
            int o = nwd(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show(o.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nwd(int a, int b)
            {
                while (b > 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }
                return a;
            }
            int nww(int a, int b)
            {
                return a * b / nwd(a, b);
            }

            label1.Text = 
        }
    }
}


