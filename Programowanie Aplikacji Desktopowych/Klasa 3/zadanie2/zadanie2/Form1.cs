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
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public int[] arr {  get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label1.Text = " ";
            label2.Text = " ";
            label4.Text = "Posortowane: ";

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // bubble
        {
            if (arr != null)
            {
                Sortowanie.Bubble_Sort(arr);

                string b = "";
                foreach (var item in arr)
                {
                    b += item.ToString() + " ";
                }
                label2.Text = b;
                label4.Text = "Sortowanie Bąbelkowe:";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // hoare
        {
            if (arr != null)
            {
                Sortowanie.QuickSortHoare(arr, 0, arr.Length - 1);

                string b = "";
                foreach (var item in arr)
                {
                    b += item.ToString() + " ";
                }
                label2.Text = b;
                label4.Text = "Sortowanie Hoare:";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // lomuto
        {
            if (arr != null)
            {
                Sortowanie.QuickSortLomuto(arr, 0, arr.Length - 1);

                string b = "";
                foreach (var item in arr)
                {
                    b += item.ToString() + " ";
                }
                label2.Text = b;
                label4.Text = "Sortowanie Lomuto:";
            }
        }
    }
}