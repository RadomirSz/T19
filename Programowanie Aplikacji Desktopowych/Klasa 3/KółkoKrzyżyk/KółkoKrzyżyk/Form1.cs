namespace KółkoKrzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] losy = new int[9];
            Random random = new Random();
            string oute = string.Empty;
            losy[0] = random.Next(0, 9);
            for (int i = 1; i < 8; i++)
            {
                int x = random.Next(0, 9);
                while (losy.Contains(x))
                {
                    x = random.Next(0, 9);
                }
                losy[i] = x;
                //MessageBox.Show(losy[i].ToString());
            }
            int[] kolkaikrzyzyki = new int[9];
            for (int i = 0; i < 9; i++)
            {
                if (i < 5) kolkaikrzyzyki[losy[i]] = 1;
                else kolkaikrzyzyki[losy[i]] = 0;
            }
            foreach (var item in kolkaikrzyzyki)
            {
                oute += item;
                //MessageBox.Show(item.ToString());
            }
            //MessageBox.Show(oute);
            for (int i = 0; i < 9; i++)
            {
                setPictureBox(i, kolkaikrzyzyki[i]);
            }


        }
        public void setPictureBox(int box, int which)
        {
            switch (box)
            {
                case 0:
                    if (which == 1) pictureBox1.Image = Image.FromFile("liga.png");
                    else pictureBox1.Image = Image.FromFile("prysznic.png");
                    break;
                case 1:
                    if (which == 1) pictureBox2.Image = Image.FromFile("liga.png");
                    else pictureBox2.Image = Image.FromFile("prysznic.png");
                    break;
                case 2:
                    if (which == 1) pictureBox3.Image = Image.FromFile("liga.png");
                    else pictureBox3.Image = Image.FromFile("prysznic.png");
                    break;
                case 3:
                    if (which == 1) pictureBox4.Image = Image.FromFile("liga.png");
                    else pictureBox4.Image = Image.FromFile("prysznic.png");
                    break;
                case 4:
                    if (which == 1) pictureBox5.Image = Image.FromFile("liga.png");
                    else pictureBox5.Image = Image.FromFile("prysznic.png");
                    break;
                case 5:
                    if (which == 1) pictureBox6.Image = Image.FromFile("liga.png");
                    else pictureBox6.Image = Image.FromFile("prysznic.png");
                    break;
                case 6:
                    if (which == 1) pictureBox7.Image = Image.FromFile("liga.png");
                    else pictureBox7.Image = Image.FromFile("prysznic.png");
                    break;
                case 7:
                    if (which == 1)pictureBox8.Image = Image.FromFile("liga.png");
                    else pictureBox8.Image = Image.FromFile("prysznic.png");
                    break;
                case 8:
                    if (which == 1) pictureBox9.Image = Image.FromFile("liga.png");
                    else pictureBox9.Image = Image.FromFile("prysznic.png");
                    break;
                default:
                    MessageBox.Show("how did we get here?");
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
