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
    public partial class insertcourse : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public insertcourse()
        {
            InitializeComponent();
            fillcombo();
        }
        private void Reset()
        {
            cname.Text = "";

            chr.Text = "";
        }
            private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void fillcombo()
        {
            Connection.Open();
            string query = "SELECT *FROM teacher ";
            SqlCommand cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            teacher.DataSource = dt;
            teacher.DisplayMember = "id";
            teacher.ValueMember = "id";
            Connection.Close();

        }
        private void add_Click(object sender, EventArgs e)
        {
            int tid = Convert.ToInt32(teacher.SelectedValue.ToString());
            string cnae = cname.Text;
            Connection.Open();
            SqlCommand cmd = new SqlCommand("insert into courses (id,name,teacher_id,credit_hour,semester_id) values ('" + Convert.ToInt32(cid.Text) + "', '" + cname + "','" + tid + "','" + Convert.ToInt32(chr.Value) + "','" + Convert.ToInt32(sem.Value) + "')", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
            Reset();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
