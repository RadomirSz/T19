using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int[] arr {  get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
            int a = int.Parse(textBox1.Text);
            arr = new int[a];
            Random r = new Random();
            for (int i = 0; i < a; i++) arr[i] = r.Next(10, 100);
            string b = "";
            foreach (var item in arr)
            {
                b += item.ToString() + " ";
            }
            label1.Text = b;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            string b = "";
            foreach (var item in arr)
            {
                b += item.ToString() + " ";
            }
            label2.Text = b;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int n = arr.Length;



            string b = "";
            foreach (var item in arr)
            {
                b += item.ToString() + " ";
            }
            label2.Text = b;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int n = arr.Length;



            string b = "";
            foreach (var item in arr)
            {
                b += item.ToString() + " ";
            }
            label2.Text = b;
        }
    }
}

