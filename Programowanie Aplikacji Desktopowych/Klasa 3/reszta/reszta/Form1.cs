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
        public FlowLayoutPanel flowLayoutPanel;

        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel = new FlowLayoutPanel
            {
                Size = new Size(1000, 500),
                Location = new Point(10, 150)
            };
            Controls.Add(flowLayoutPanel);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            int kwota = int.Parse(textBox1.Text);

            string[] nominalyZdjecia = {"50.jpg", "20.jpg", "10.jpg", "5.jpg", "2.jpg", "1.jpg"};
            int[] nominaly = new int[6]{50,20,10,5,2,1};
            List<int> reszta = new List<int>();
            while (kwota > 0)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (kwota >= nominaly[i])
                    {
                        Image image = Image.FromFile(nominalyZdjecia[i]);
                        
                        PictureBox pictureBox = new PictureBox();

                        pictureBox.Image = image;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                        flowLayoutPanel.Controls.Add(pictureBox);

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
