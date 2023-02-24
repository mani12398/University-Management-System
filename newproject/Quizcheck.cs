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
    public partial class Quizcheck : Form
    {
        int n = Convert.ToInt32(Form1.val);
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public Quizcheck()
        {
            string query = "SELECT quiz.course_id,courses.name,quiz.num As Quiz_Num,quiz.omarks as obtained_Marks,quiz.tmarks as Total_Marks from quiz  inner join  student on student.id='"+n+"' and student.id=quiz.student_id inner join courses on courses.id=quiz.course_id;";
            InitializeComponent();
            Display(query);
            InitializeComponent();
        }
        public void Display(string query)
        {

            dataGridView1.Visible = true;
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\student'" + n + "'.txt";
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
