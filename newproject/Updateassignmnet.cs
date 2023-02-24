using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace newproject
{
    public partial class Updateassignmnet : Form
    {
        int n = Convert.ToInt32(Form1.val);
        //int n = 001;
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public Updateassignmnet()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            Connection.Open();
            string query = "Select distinct num as Assignmnet_Num,student_id,course_id,omarks,tmarks from assignmnet where teacher_id ='" + n + "' order by course_id";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            guna2DataGridView1.DataSource = dt;
            Connection.Close();


        }
        private void add_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Update assignmnet Set omarks=@om,tmarks=@tm where student_id=@id and course_id=@ci", Connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Display();
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Quiz_report.txt";
            using (var write = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);

                }
                string sLine = "";
                for (int r = 0; r <= guna2DataGridView1.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= guna2DataGridView1.Columns.Count - 1; c++)
                    {
                        sLine = sLine + guna2DataGridView1.Rows[r].Cells[c].Value;
                        if (c != guna2DataGridView1.Columns.Count - 1)
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
