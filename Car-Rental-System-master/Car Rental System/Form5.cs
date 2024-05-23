using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Form5 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.carRentalDataSet1.customer);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Phone = int.Parse(textBox4.Text);
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "Insert into customer(ID,Name,Address,Phone) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + Phone + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data inserted");
            }
            else
            {
                MessageBox.Show("error occured");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                //This connection is created to develop book mark system and store all the bookmarks in database
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "UPDATE customer SET Name = '" + textBox2.Text + "', Address = '" + textBox3.Text + "',  Phone = '" + textBox4.Text + "' WHERE Id= '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data updated");
            }
            else
            {
                MessageBox.Show("Insert ID Number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {

                //This connection is created to develop book mark system and store all the bookmarks in database
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "Delete customer where Id = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted");
            }
            else
            {
                MessageBox.Show("Insert Id Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fp3 = new Form3();
            fp3.Show();
            this.Hide();
        }
    }
}
