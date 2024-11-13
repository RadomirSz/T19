using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo2
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string path = "..\\..\\data.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sex;
            if (radioButton1.Checked) sex = "Male";
            else if (radioButton2.Checked) sex = "Female";
            else sex = "Null";
            string description = richTextBox1.Text;

            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(name);
            writer.WriteLine(sex);
            writer.WriteLine(description);
            writer.WriteLine();
            writer.Close();
            MessageBox.Show("Zapisano osobę " + name);
            clearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(path);
            string person = "";
            while (!reader.EndOfStream)
            {
                person += reader.ReadLine();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void clearFields() 
        {
            textBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            richTextBox1.Text = string.Empty;
        }
    }
}
