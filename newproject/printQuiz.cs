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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace newproject
{
    public partial class printQuiz : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=abc;Integrated Security=True");

        int n = Convert.ToInt32(Form1.val);
        //int n = 001;
        public printQuiz()
        {
            InitializeComponent();
            string query = "Select distinct num as Quiz_number,student_id,course_id,omarks,tmarks from quiz where teacher_id ='" + n + "'";
            display(query);
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
            string text = "SELECT num,student_id,course_id,omarks,tmarks FROM quiz WHERE omarks < All (SELECT avg(omarks) FROM quiz WHERE teacher_id ='"+n+"')";
            display(text);
            radioButton2.Refresh();
            radioButton3.Refresh();
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            string text = "SELECT num,student_id,course_id,omarks,tmarks FROM quiz WHERE omarks < All (SELECT avg(omarks) FROM quiz WHERE teacher_id ='" + n + "')";
            // string query = "Select distinct num,student_id,course_id,omarks,tmarks from quiz where teacher_id ='" + n + "'";
            display(text);
            radioButton2.Refresh();
            radioButton3.Refresh();
        }

        private void radioButton3_MouseLeave(object sender, EventArgs e)
        {
            string text = "Select distinct num as Quiz_number,student_id,course_id,omarks,tmarks FROM quiz WHERE omarks > Any (SELECT avg(omarks) FROM quiz WHERE teacher_id ='" + n + "')";
            display(text);
            radioButton2.Refresh();
            radioButton1.Refresh();

        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Quiz_report.txt";
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
                MessageBox.Show("DATA is EXPORTED");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
