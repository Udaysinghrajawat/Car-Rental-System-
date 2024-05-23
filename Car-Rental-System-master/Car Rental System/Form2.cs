using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class Form2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if password or confirm password is correct then the new password is created 
            if (textBox4.Text == textBox5.Text)
            {
                //This sql connection is done to create new account
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "Insert into login(username,password) values('" + textBox1.Text + "','" + textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("password created");
                }
                else
                {
                    MessageBox.Show("error occured");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please check your password");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fp1 = new Form1();
            fp1.Show();
            this.Hide();
        }
    }
}
