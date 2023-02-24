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
    public partial class Form3 : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");

        
        public static string teachername;
        int n = Convert.ToInt32(Form1.val);
        //string name= Form1.teachername;
        public Form3()
        {
            InitializeComponent();
            tname.Text = Form1.teachername;
            Display();
        }

        public void Display()
        {
            
            Connection.Open();
            string query = "SELECT  t.id,t.name,c.name from teacher t INNER JOIN courses c on t.id ='" + n + "' and t.id=c.teacher_id";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
             Connection.Close();
         
            int num = dt.Rows.Count;
            //course count
         
            numcourse.Text = "" + Convert.ToString(num);

            //student count
            Connection.Open();
            string query1 = "Select  count(student.id) as student_id  from student  Inner join courses on courses.semester_id = student.semester and courses.teacher_id= '"+n+"' group  by teacher_id";
            SqlCommand cmd1 = new SqlCommand(query1, Connection);
            var reader1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(reader);
            Connection.Close();
            int num1 = dt.Rows.Count;
            //course count
            numstudent.Text = "" + Convert.ToString(num1);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Classstatus c= new Classstatus();
            c.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Insertquiz c = new Insertquiz();
            c.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            updatequiz c = new updatequiz();
            c.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            printQuiz c = new printQuiz();
            c.Show();

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            panelone.Size = new Size(204, 41);
            paneltwo.Location = new Point(3, 302);

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            paneltwo.Size = new Size(204, 42);
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            //152, 41
            paneltwo.Size = new Size(204, 95);
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {//204, 42
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //204, 138
            panelone.Size = new Size(204, 138);
            paneltwo.Location = new Point(3, 391);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            addannouncement c = new addannouncement();
            c.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Classstatus a = new Classstatus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            settingcs a = new settingcs() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            insertassignment a = new insertassignment() { Dock = DockStyle.Top, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Updateassignmnet a = new Updateassignmnet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void tpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tpanel.SendToBack();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Insertquiz a = new Insertquiz() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            printQuiz a = new printQuiz() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            updatequiz a = new updatequiz() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }
    }
}
