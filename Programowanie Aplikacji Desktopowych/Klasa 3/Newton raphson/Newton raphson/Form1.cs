namespace Newton_raphson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var liczba = double.Parse(textBox1.Text);
            if (liczba < 30 || liczba > 70) Close();
            double a = Math.Sqrt(liczba);
            label1.Text = Math.Round(a, trackBar1.Value).ToString();
            //label1.Text = Math.Sqrt(liczba).ToString();

            //double output = (liczba + liczba / liczba) / 2;
            //for (int i = 1; i < trackBar1.Value; i++)
            //{
            //    output = (output + liczba / output) / 2;
            //}
            //label2.Text = output.ToString();
            label2.Text = NR(liczba, trackBar1.Value).ToString();
        }
        public double NR(double liczba, int dokladnosc)
        {
            var b = liczba;
            var a = liczba / b;
            var k = 1;
            double temp = 0;
            while (k <= dokladnosc)
            {
                temp = (a + b) / 2;
                a = liczba / temp;
                b = temp;
                k++;
            }

            return temp;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
