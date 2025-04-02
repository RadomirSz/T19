using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_04
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            int wiek = int.Parse(textBox2.Text);
            var hobby = checkedListBox1.CheckedItems;
            int progres = hScrollBar1.Value;

            string a = "";
            foreach (var item in hobby)
            {
                a += item.ToString() + " ";
            }
            var rodzaj = comboBox1.Text;
            label6.Text = imie + " " + wiek.ToString() + " " + a + progres.ToString() + " " + rodzaj.ToString();

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog
        }

        private void napiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
