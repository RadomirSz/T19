using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            //int intinput = int.Parse(input);
            //List<int> list = ;
            //string output = "";
            //foreach (int i in list) { 
            //    output += i;
            //}
            label1.Text = reverseJ(input);
        }

        public List<int> J(int input)
        {
            List<int> list = new List<int>();
            string bin = toBinary(input);
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    list.Add(i+1);
                }
            }
            return list;
        }
        public string toBinary(int input)
        {
            string output = "";
            while (input > 0) {
                output += input%2;
                input /=2;
            }
            return output;
        }
        public string reverseJ(string input)
        {
            string bin = "";
            int j = 0;
            for (int i = 1; i < input.Length+1; i++)
            {
                if (input[j] == i) 
                {
                    bin = bin + "1";
                    j++;
                }
                else 
                {
                    bin += "0";
                }
            }
            int output = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    output += Pow2(i);
                }
            }
            return output.ToString();
        }
        public int Pow2(int input) {

            int output = 1;
            for (int i = 0; i < input; i++)
            {
                output*=2;
            }
            return output;
        }
    }
}
