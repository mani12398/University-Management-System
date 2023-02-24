using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace newproject
{
    public partial class Classstatus : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");

        int n = Convert.ToInt32( Form1.val);
        public Classstatus()
        {
            InitializeComponent();
            string query = "Select  num as Assignment_num,student_id,course_id,teacher_id,omarks,tmarks from assignmnet where teacher_id  ='" + n + "'";
            Display(query);
            fillcombo();
            average();
        }
        public void Display(string query)
        {
            Connection.Open();
            gridview.Visible = true;
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            gridview.DataSource = dt;
            Connection.Close();


        }
        public void fillcombo()
        {
            Connection.Open();
            string query = "SELECT *FROM courses where teacher_id = '" + n + "'";

            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            courselist.DataSource = dt;
            courselist.DisplayMember = "id";
            courselist.ValueMember = "name";
            Connection.Close();

        }
        public void average()
        {
            string connectionString = "Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string text = "select count(student_id)from assignmnet where omarks<(select avg(omarks) from quiz)";
                using (SqlCommand cmd = new SqlCommand(text, connection))
                {
                    connection.Open();
                    var relt = cmd.ExecuteScalar(); //write the result into a variable
                    quizez.Text = relt.ToString();
                    connection.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            if(radioButton2.Checked==true)
            {
                string query = "Select distinct  quiz.num,student.fname,quiz.course_id,quiz.teacher_id,quiz.omarks,quiz.tmarks from quiz  inner join student  on student.id=quiz.student_id and quiz.teacher_id='" + n + "' inner join courses on quiz.course_id='" + Convert.ToInt32(courselist.Text) + "'";
                Display(query);

            }
            else if(radioButton1.Checked==true)
            {
                string query = "Select distinct  assignmnet.num,student.fname,assignmnet.course_id,assignmnet.teacher_id,assignmnet.omarks,assignmnet.tmarks from assignmnet  inner join student  on student.id=assignmnet.student_id and assignmnet.teacher_id='" + n + "' inner join courses on assignmnet.course_id='" + Convert.ToInt32(courselist.Text) + "' order by assignmnet.num";
                Display(query);

            }
            else
            {
                string query = "Select distinct  assignmnet.num,student.fname,assignmnet.course_id,assignmnet.teacher_id,assignmnet.omarks,assignmnet.tmarks from assignmnet  inner join student  on student.id=assignmnet.student_id and assignmnet.teacher_id='" + n + "' inner join courses on assignmnet.course_id='" + Convert.ToInt32(courselist.Text) + "'order by quiz.num";
                Display(query);
            }
           
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {
            string query = "Select   assignmnet.num,student.fname,assignmnet.course_id,assignmnet.teacher_id,assignmnet.omarks,assignmnet.tmarks from assignmnet  inner join student  on student.id=assignmnet.student_id and assignmnet.teacher_id='" + n + "' order by assignmnet.num";
            Display(query);
           
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            string text = "Select   quiz.num,student.fname,quiz.course_id,quiz.teacher_id,quiz.omarks,quiz.tmarks from quiz  inner join student  on student.id=quiz.student_id and quiz.teacher_id='" + n + "' order by quiz.num";
            Display(text);
            fillcombo();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Class Report.txt";
            using (var write = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);

                }
                string sLine = "";
                for (int r = 0; r <= gridview.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= gridview.Columns.Count - 1; c++)
                    {
                        sLine = sLine + gridview.Rows[r].Cells[c].Value;
                        if (c != gridview.Columns.Count - 1)
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
                MessageBox.Show("DATA is EXPORTED");
            }
        }
    }
}
