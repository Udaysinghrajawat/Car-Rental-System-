using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fp2 = new Form2();
            fp2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //This connection is created for checking user name and password is correct or not
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select * from login where username = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                Form3 fp3 = new Form3();
                fp3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong password");
            }
            con.Close();

        }
    }
}
