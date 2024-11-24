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
using System.Xml.Linq;

namespace todo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamWriter writer = new StreamWriter(path,false);
            writer.Write("");
            writer.Close();
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

            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine(name);
            writer.WriteLine(sex);
            writer.WriteLine(description);
            writer.WriteLine();
            writer.Close();
            //MessageBox.Show("Person saved: " + name);
            clearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        public List<Person> persons = new List<Person>();
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dataGridView1.Rows.Clear();

            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                Person p = new Person(reader.ReadLine(), reader.ReadLine(),reader.ReadLine());
                reader.ReadLine();
                persons.Add(p);
            }

            string ListOut = "";
            for (int i = 0; i < persons.Count; i++)
            {
                ListOut += $"{i+1}. Name: {persons[i].name} Sex: {persons[i].sex} \nDescription: {persons[i].description}\n";
                
                ListViewItem item = new ListViewItem(persons[i].name);
                item.SubItems.Add(persons[i].sex);
                item.SubItems.Add(persons[i].description);
                listView1.Items.Add(item);


                dataGridView1.Rows.Add(persons[i].name, persons[i].sex, persons[i].description);

            }
            //MessageBox.Show(ListOut);   

            reader.Close();
        }

        

        public void clearFields() 
        {
            textBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            richTextBox1.Text = string.Empty;
            radioButton1.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Person
    {
        public string name;
        public string sex;
        public string description;
        public Person(string name, string sex, string description) 
        { 
            this.name = name;
            this.sex = sex;
            this.description = description;
        }
    }
}
