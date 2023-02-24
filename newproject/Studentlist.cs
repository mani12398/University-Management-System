using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace newproject
{
    public partial class Studentlist : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");

        public Studentlist()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Visible = true;
            Connection.Open();
            string query = "SELECT *FROM student";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();

        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
           
            Connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student where programe=@prg", Connection);
            string pg = select.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@prg", pg);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\student_list.txt";
            using (var write = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);

                }
                string sLine = "";
                for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + " -  ";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    write.WriteLine(sLine);
                    sLine = "";
                }
                write.Close();
                MessageBox.Show("Data is exported successfully !");
            }
        }

        private void search_MouseClick(object sender, MouseEventArgs e)
        {
            string query = "SELECT * FROM student WHERE fName LIKE '%" + search.Text + "%'";
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
