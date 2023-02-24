using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace newproject
{
    public partial class loginmanage : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public loginmanage()
        {
            InitializeComponent();
            string text = "Select distinct * from login";
            display(text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display(string query)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {
            string text = "Select distinct * from login";
            display(text);
            radioButton2.Refresh();
            radioButton3.Refresh();

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
           

        }

        private void radioButton3_MouseLeave(object sender, EventArgs e)
        {
            string text = "Select distinct * from login where status='student'";
            display(text);
            radioButton1.Refresh();
            radioButton3.Refresh();
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            string text = "Select distinct * from login where status='teacher'";
            display(text);
            radioButton1.Refresh();
            radioButton3.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Select distinct * from login";
            display(text);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addlogin form = new addlogin();
            form.Show();

        }
    }
}
