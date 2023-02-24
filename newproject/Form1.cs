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
  
    public partial class Form1 : Form
    {
        public static int val;
        public static string teachername;
        string connectionString = "Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        void getnameformanager(int n)
        {
            string query = "Select name from teacher where id='" + n + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar(); //write the result into a variable
                   string na=result.ToString();
                    teachername = na;
                    this.Hide();
                    Form2 form = new Form2();
                    form.Show();

                }
            }

        }
        void getnameforteacher(int n)
        {
            string query = "Select name from teacher where id='" + n + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar(); //write the result into a variable
                    string na = result.ToString();
                    teachername = na;
                    this.Hide();
                    Form3 form = new Form3();
                    form.Show();

                }
            }

        }
        void getnameforstudent(int n)
        {
            string query = "Select fname+lname from student where id='"+ n +"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar(); //write the result into a variable
                    string na = result.ToString();
                    teachername = na;
                    this.Hide();
                    Student form = new Student();
                    form.Show();

                }
            }

        }
        void getvalue(string query)
        {
           
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar(); //write the result into a variable
                    string num = result.ToString();
                    val = Convert.ToInt32( num);
                    if(management.Checked==true)
                        getnameformanager(val);
                    else if (teacher.Checked == true)
                        getnameforteacher(val);
                    else if (Student.Checked == true)
                        getnameforstudent(val);


                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string pass = password.Text;
            
           if(Student.Checked==true)
            {
                management.Checked = false;
                teacher.Checked = false;
                string query = "select id from login where email='" + name + "' and password='" + pass + "' and status='student'";
                getvalue(query);
            }
           else if( management.Checked==true)
            {
                teacher.Checked = false;
                Student.Checked = false;
                string query = "select id from login where email='" + name + "' and password='" + pass + "' and status='management'";
                getvalue(query);
            }
           else if( teacher.Checked==true)
            {
                string query = "select id from login where email='" + name + "' and password='" + pass + "' and status='teacher'";
                getvalue(query);
                Student.Checked = false;
                management.Checked = false;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username.Text = "iram001@gmail.com";
            password.Text = "fakhar023";
            
        }

       

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";

        }
    }
}
