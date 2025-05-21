using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _2105
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

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (!Regex.IsMatch(text, @"^\d{7,8}$"))
            {
                MessageBox.Show("Z³y input");
                return;
            }
            int parzyste = 0;
            int nieparzyste = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0) parzyste += int.Parse(text[text.Length - i-1].ToString());
                else nieparzyste += int.Parse(text[text.Length - i-1].ToString());
            }
            if (parzyste == nieparzyste) label1.Text = "tak";
            else label1.Text = "nie";

        }
    }
}
