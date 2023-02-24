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
    public partial class insertassignment : Form
    {
        int n = Convert.ToInt32(Form1.val);
        public insertassignment()
        {
            InitializeComponent();

            Display();
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

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT into assignmnet (num,teacher_id,course_id,student_id,omarks,tmarks) values ('" + Convert.ToInt32(quiznum.Text) + "', '" + Convert.ToInt32(teacherid.Text) + "','" + Convert.ToInt32(courseid.Text) + "','" + Convert.ToInt32(studentid.Text) + "','" + Convert.ToInt32(omarks.Text) + "','" + Convert.ToInt32(tmarks.Text) + "')", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
            Connection.Close();
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            teacherid.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            studentid.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            courseid.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
