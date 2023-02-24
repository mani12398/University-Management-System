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
    public partial class addannouncement : Form
    {
        public addannouncement()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            int sm = Convert.ToInt32(ID.Text);
            string pg="";
            if(cs.Checked==true)
            {
                 pg ="cs";
            }
            else if (se.Checked == true)
            {
                 pg = "se";
            }
            else
            {
                MessageBox.Show("Kindly select the department");
            }

            string mg = msg.Text;
            Connection.Open();
            SqlCommand cmd = new SqlCommand("insert into announcement (semester_id,programe,message) values ('" + sm + "','" + pg + "','" + mg + "' )", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
            Connection.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
