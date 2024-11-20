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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            MessageBox.Show("Person saved: " + name);
            clearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            List<Person> persons = new List<Person>();
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
                ListOut += $"{i+1}. Name: {persons[i].name} Sex: {persons[i].sex} \nDescription:   {persons[i].description}\n";
            }
            MessageBox.Show(ListOut);   
            reader.Close();

            //listview i datagridview

            System.Windows.Forms.ListView listView1 = new ListView();
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
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
