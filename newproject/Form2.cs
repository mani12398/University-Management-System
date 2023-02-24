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
    public partial class Form2 : Form
    {
        public static int n;
        public static string name;
        string connectionString = "Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            tpanel.SendToBack();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            //  string n= Form1.teachername.ToString();
            tname.Text = Form1.teachername;
            name = Form1.teachername;
            
            getvalue();



        }
        void getvalue()
        {
            string query = "select count(id) from student";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar(); //write the result into a variable
                    string n = result.ToString();
                    numstudent.Text = result.ToString();
                    connection.Close();

                }
            }
            string query1 = "select count(id) from teacher";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd1 = new SqlCommand(query1, connection))
                {
                    connection.Open();
                    var result = cmd1.ExecuteScalar(); //write the result into a variable
                   
                    numteacher.Text = result.ToString();
                    connection.Close();

                }
            }
            string query2 = "select count(id) from courses";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd2 = new SqlCommand(query2, connection))
                {
                    connection.Open();
                    var result = cmd2.ExecuteScalar(); //write the result into a variable
                    string n = result.ToString();
                    numcourses.Text = result.ToString();
                    connection.Close();

                }
            }
            
        }
        void loadash()
        {
            
          
        }
        private void tname_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            paneldropdown.Size= new Size(180, 145);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            
               // paneldropdown.Size = new Size(167, 33);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

            paneldropdown.Size = new Size(180, 44);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            paneltwo.Size = new Size(180, 145);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            paneltwo.Size= new Size(180, 44);
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            panelthree.Size = new Size(180, 145);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            panelthree.Size = new Size(180, 44);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertstudent a = new insertstudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            updatestudent a = new updatestudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Studentlist a = new Studentlist() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displaycourses a = new displaycourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            insertcourse a = new insertcourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            updatecourse a = new updatecourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            teachers a = new teachers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            insertteacher a = new insertteacher() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loginmanage a = new loginmanage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginmanage a = new loginmanage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            tpanel.SendToBack();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Studentlist a = new Studentlist() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            teachers a = new teachers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            displaycourses a = new displaycourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            loginmanage a = new loginmanage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.AutoScroll = true;
            tpanel.BringToFront();
            this.tpanel.Controls.Add(a);
            a.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
