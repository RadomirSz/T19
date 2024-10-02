using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e){Close();}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bay") Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("D"));
            MessageBox.Show(DateTime.Now.ToString("T"));
        }
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void button4_Click(object sender, EventArgs e)
        {   
            string Nwd = tools.nwd(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();
            string Nww = tools.nww(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();
            label2.Text = $"Nwd: {Nwd}, Nww: {Nww}";
        }
        private void label2_Click(object sender, EventArgs e){}
    }
    public static class tools
    {
        public static int nwd(int a, int b)
        {
            while (b > 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public static int nww(int a, int b) { return (a * b) / nwd(a, b); }
    }
}