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
    public partial class settingcs : Form
    {
        int n = Convert.ToInt32(Form1.val);
        public settingcs()
        {
            InitializeComponent();
            get();
        }
        void get()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            
            Connection.Open();
            SqlCommand cmd = new SqlCommand(" Select email,password from login where id='" + n+"'", Connection);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            foreach (DataRow row in dt.Rows)
            {
                username.Text = row["email"].ToString();
                password.Text= row["password"].ToString();

            }
            Connection.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Update login set password='"+newpass.Text+"'where id='"+n+"' ", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password is updated sucessfully");
            Connection.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
