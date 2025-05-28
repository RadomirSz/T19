namespace _28_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }
        Dictionary<string, int> godziny = new Dictionary<string, int>();
        List<ToDoObcject> lista = new List<ToDoObcject>();
        private void button1_Click(object sender, EventArgs e)
        {

            string data = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            int godzina;
            string opis = richTextBox1.Text;
            if (!int.TryParse(textBox1.Text, out godzina) || godzina < 1 || godzina > 24 || opis=="")
            {
                MessageBox.Show("WprowadŸ poprawn¹ godzinê (1-24) i daj opis");
                return;
            }
            string inputGodzina = $"{data} {godzina}";
            foreach (var item in lista)
            {
                if (item.WyswietlGodzine() == inputGodzina)
                {
                    MessageBox.Show("Godzina ju¿ istnieje. WprowadŸ niepowtarzaj¹c¹ siê godzinê.");
                    return;
                }
            }

            lista.Add(new ToDoObcject(data, godzina, opis));


            label1.Text = "";
            foreach (var item in lista)
            {
                label1.Text += item.ObjToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wrgtertt(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class ToDoObcject
    {
        public int Godzina { get; set; }
        public string Opis { get; set; }
        public string Data { get; set; }

        public ToDoObcject(string data, int godzina, string opis)
        {
            Data = data;
            Godzina = godzina;
            Opis = opis;
        }
        public string ObjToString()
        {
            return $"{Data} - {Godzina} - {Opis}\n";
        }
        public string WyswietlGodzine()
        {
            return $"{Data} {Godzina}";
        }
    }
}
