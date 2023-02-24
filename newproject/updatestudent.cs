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
    public partial class updatestudent : Form
    {
        public updatestudent()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Visible = true;
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            string query = "SELECT *FROM student";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display();

        }
        void reset()
        {
            ID.Text = " ";
            fname.Text = " ";
            lname.Text = " ";
            email.Text = " ";
            cs.Checked = false;
            se.Checked = false;
            phone.Text = " ";
            semester.Text = " ";
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if(dataGridView1.CurrentRow.Cells[5].Value.ToString()=="cs")
            {
                cs.Checked = true;
                se.Checked = false;
            }
            else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "se")
            {
                cs.Checked = false;
                se.Checked = true;
            }
            phone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            semester.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand("delete from student where id=@st", Connection);
            cmd.Parameters.AddWithValue("@st", Convert.ToInt16(delete.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Recorde is successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string query = "SELECT * FROM student WHERE fName LIKE '%" + search.Text + "%'";
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");


            if (ID.Text == "")
            {
                MessageBox.Show("Missing Information...", "University Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update student Set id=@CN,fname=@City,lname=@Dir,email=@mail,phone=@phn,programe=@dep,semester=@sem where id=@idd", Connection);

                    cmd.Parameters.AddWithValue("@CN", Convert.ToInt16(ID.Text));
                    cmd.Parameters.AddWithValue("@City", fname.Text);
                    cmd.Parameters.AddWithValue("@Dir", lname.Text);
                    cmd.Parameters.AddWithValue("@mail", email.Text);
                    cmd.Parameters.AddWithValue("@phn", phone.Text);
                    string pro = "cs";
                    if (cs.Checked == true)
                    {
                        pro = "cs";
                    }
                    else if (se.Checked == true)
                    {
                        pro = "se";
                    }
                    cmd.Parameters.AddWithValue("@dep", pro);
                    cmd.Parameters.AddWithValue("@sem", Convert.ToInt16(semester.Text));
                    cmd.Parameters.AddWithValue("@idd", Convert.ToInt16(ID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Done ! ");
                    Connection.Close();
                    Display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }

        }
    }
}
