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
    public partial class Insertquiz : Form
    {
        int n = Convert.ToInt32(Form1.val);
        public Insertquiz()
        {
            InitializeComponent();
            Display();
        }

        private void Insertquiz_Load(object sender, EventArgs e)
        {

        }
        public void Display()
        {

            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            string query = "Select  student.id as student_id ,courses.teacher_id,student.fname , courses.name,courses.id as course_id ,courses.semester_id from student  Inner join courses on courses.semester_id = student.semester and courses.teacher_id= '" + n + "' order by courses.id";

            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            guna2DataGridView1.DataSource = dt;
            tmarks.Text = "20";
            Connection.Close();


        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void add_Click(object sender, EventArgs e)
        {

            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT into quiz (num,teacher_id,course_id,student_id,omarks,tmarks) values ('" + Convert.ToInt32(quiznum.Text) + "', '" + Convert.ToInt32(teacherid.Text) + "','" + Convert.ToInt32(courseid.Text) + "','" + Convert.ToInt32(studentid.Text) + "','" + Convert.ToInt32(omarks.Text) + "','" + Convert.ToInt32(tmarks.Text) + "')", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
            Connection.Close();
        }

        private void guna2DataGridView1_Click_1(object sender, EventArgs e)
        {
            teacherid.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            studentid.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            courseid.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tid_Click(object sender, EventArgs e)
        {

        }

        private void teacherid_TextChanged(object sender, EventArgs e)
        {

        }

        private void sid_Click(object sender, EventArgs e)
        {

        }

        private void studentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cid_Click(object sender, EventArgs e)
        {

        }

        private void courseid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tmarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void omarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void quiznum_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
