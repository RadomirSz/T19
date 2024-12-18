using Microsoft.Data.Sqlite;
using System.Text;

namespace sqlite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String cs = "Source Database=baza.db";

            SqliteConnection conn = new SqliteConnection(cs);

            conn.Open();

            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Pracownik (id INTEGER PRIMARY KEY AUTOINCREMENT, Imie TEXT, Nazwisko TEXT, Wiek INTEGER);";
            cmd.ExecuteNonQuery();

            StringBuilder sb = new StringBuilder();


            sb.Append(@"INSERT INTO");


            conn.Close();
        }
    }
}
