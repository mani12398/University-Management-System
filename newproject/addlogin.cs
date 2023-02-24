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
    public partial class addlogin : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public addlogin()
        {
            InitializeComponent();
            string text = "Select  student.id,student.fname,student.email from student;";
            display(text);
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

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            

            string text = "Select * from teacher";
            display(text);
            radioButton2.Checked = false;
            status.Text = "teacher";
        }

        private void radioButton3_MouseLeave(object sender, EventArgs e)
        {
            string text = "Select distinct student.id,student.fname,student.email from student;";
            display(text);
            radioButton3.Checked = false;
            status.Text = "student";
        }

        private void addlogin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            lid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            username.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand("insert into login (email,id,password,status) values ('" + username.Text + "', '" + Convert.ToInt32(lid.Text) + "','" + userpass.Text + "','" + status.Text + "')", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
