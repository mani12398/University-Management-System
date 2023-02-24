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
    public partial class updatecourse : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public updatecourse()
        {
            InitializeComponent();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("update courses set teacher_id='" + teacher.SelectedValue.ToString()+"',  credit_hour='" + chours.Text + "' where name='" + cname.Text + "'", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully.");
            Connection.Close();
        }
        public void Display()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Visible = true;
            Connection.Open();
            string query = "SELECT *FROM courses";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            cid.Text = "";
            cname.Text = "";
            chours.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Connection.Open();
            int id = Convert.ToInt32(delete.Text);
            //  MySqlCommand commamd = new MySqlCommand("DELETE FROM 'student' WHERE id=@st", connection);
            SqlCommand cmd = new SqlCommand("delete from courses where id='" + id + "'", Connection);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Course is deleted successfully !");
            Connection.Close();
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            cid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            chr.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            teacher.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
