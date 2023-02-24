using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace newproject
{
    public partial class updatequiz : Form
    {
        int n = Convert.ToInt32(Form1.val);
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public updatequiz()
        {
            InitializeComponent();
            Display();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Update quiz Set omarks=@om,tmarks=@tm where student_id=@id and course_id=@ci", Connection);
            cmd.Parameters.AddWithValue("@om", Convert.ToInt16(omarks.Text));
            cmd.Parameters.AddWithValue("@tm", Convert.ToInt16(tmarks.Text));
            cmd.Parameters.AddWithValue("@id", Convert.ToInt16(studentid.Text));
            cmd.Parameters.AddWithValue("@ci", Convert.ToInt16(courseid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully !");
            Connection.Close();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                quiznum.Text = "";
                omarks.Text = "";
                studentid.Text = "";
                courseid.Text = "";
                tmarks.Text = "";
            
        }
        public void Display()
        {
            Connection.Open();
            string query = "Select distinct num as Quiz_number,student_id,course_id,omarks,tmarks from quiz where teacher_id ='" + n + "'";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            guna2DataGridView1.DataSource = dt;
            Connection.Close();
        }
        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            quiznum.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            studentid.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            courseid.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            omarks.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
             tmarks.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            string query = "select * from quiz WHERE student_id  LIKE '%" + search.Text + "%'";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            guna2DataGridView1.DataSource = dt;
            Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
