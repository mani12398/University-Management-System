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
    public partial class teachers : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public teachers()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Visible = true;
            Connection.Open();
            string query = "SELECT id,name,teacher_id as Email FROM teacher";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }
        void reset ()
        {
            tid.Text = "";
            tname.Text = "";
            num.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Update teacher Set id=@CN,name=@City,teacher_id=@Dir where id=@CN", Connection);
            cmd.Parameters.AddWithValue("@CN", Convert.ToInt16(tid.Text));
            cmd.Parameters.AddWithValue("@City", tname.Text);
            cmd.Parameters.AddWithValue("@Dir", num.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Done ! ");
            Connection.Close();
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Connection.Open();
            int id = Convert.ToInt32(delete.Text);
            //  MySqlCommand commamd = new MySqlCommand("DELETE FROM 'student' WHERE id=@st", connection);
            SqlCommand cmd = new SqlCommand("delete from teacher where id='" + id + "'", Connection);
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
            tid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            num.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
    

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();

        }
    }
}
