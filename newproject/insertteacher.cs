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
    
    public partial class insertteacher : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
        public insertteacher()
        {
            InitializeComponent();
        }
        void Reset()
        {
            tid.Text = "";
            tname.Text = "";
            tnum.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            int td = Convert.ToInt32(tid.Text);
            string name = tname.Text;
            string phone = tnum.Text;
            Connection.Open();
            SqlCommand cmd = new SqlCommand("insert into teacher (id,name,teacher_id) values ('" + td + "', '" + name + "','" + phone + "')", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
            Reset();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form=new Form2();
            form.Show();
        }
    }
}
