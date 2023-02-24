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
    public partial class Student : Form
    {
        int n = Convert.ToInt32(Form1.val);
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public Student()
        {
            InitializeComponent();
            fill();
            Display();
        }
        void fill()
        {
           
            

            Connection.Open();
            SqlCommand cmd = new SqlCommand("select sum(omarks),sum(tmarks)from assignmnet where student_id='" + n + "'", Connection);
            var dr = cmd.ExecuteReader();
            dr.Read();
            int sum = Convert.ToInt32(dr[0]);
            int sum2 = Convert.ToInt32(dr[1]);
            int i;
            bar1.Minimum = 0;
            bar1.Maximum = sum2;

            for (i = 0; i <= sum; i++)
            {
                bar1.Value = i;
            }

            Connection.Close();
            Connection.Open();
            SqlCommand cmdd = new SqlCommand("select sum(omarks),sum(tmarks)from quiz where student_id='" + n + "'", Connection);
            var ddr = cmdd.ExecuteReader();
            ddr.Read();

            int j;
            bar2.Minimum = 0;
            bar2.Maximum = Convert.ToInt32(ddr[1]);

            for (j = 0; j <= Convert.ToInt32(ddr[0]); j++)
            {
                bar2.Value = j;
            }
            Connection.Close();


        }
        public void Display()
        {

            gridview.Visible = true;
            Connection.Open();
            string query = "SELECT announcement.message FROM announcement  inner join  student on id='" + n+"' and student.programe=announcement.programe; ";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            gridview.DataSource = dt;
            Connection.Close();


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assignmnet a = new assignmnet() {Dock=DockStyle.Fill,TopLevel=false,TopMost=true };
            a.AutoScroll = true;
            spanel.BringToFront();
             this.spanel.Controls.Add(a);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quizcheck a = new Quizcheck() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

           
            a.AutoScroll = true;
            spanel.BringToFront();
            this.spanel.Controls.Add(a);
            a.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            name.Text = Form1.teachername;
            ROLLNUM.Text = n.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settingcs a = new settingcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            spanel.BringToFront();
            this.spanel.Controls.Add(a);
            a.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            spanel.SendToBack();
            spanel.ResetText();
        }
    }
}
