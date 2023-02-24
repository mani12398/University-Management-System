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
    public partial class insertstudent : Form
    {
        public insertstudent()
        {
            InitializeComponent();
        }

        void reset()
        {
            fname.Text = "";
            lname.Text = "";
            email.Text = "";
            phone.Text = "";
            ID.Text = " ";
            semester.Text = " ";
            cs.Checked = false;
            se.Checked = false;
        }
        private void add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            string firstname = fname.Text;
            string lastname = lname.Text;
            string em = email.Text;
            string pro = "cs";
            string sem = semester.Text;
            if(cs.Checked==true)
            {
                 pro = "cs";
            }
            else if(se.Checked==true)
            {
                pro = "se";
            }
            string num = phone.Text;
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-8C4H7LK;Initial Catalog=vpproject;Integrated Security=True");
            Connection.Open();
            SqlCommand cmd = new SqlCommand("insert into student (id,fname,lname,email,phone,programe,semester) values ('" + id + "', '" + firstname + "','" + lastname + "','" + em + "','" + num + "','" + pro + "' ,'" + sem + "')", Connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted sucessfully");
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
