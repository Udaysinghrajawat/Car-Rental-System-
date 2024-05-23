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
    public partial class Form4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carRentalDataSet.car);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //This connection is created to develop book mark system and store all the bookmarks in database
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "Insert into car(RegNo,Brand,Model,price,Available) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";
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

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != " ")
            {
                //This connection is created to develop book mark system and store all the bookmarks in database
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "UPDATE car SET Brand = '" + textBox3.Text + "', Model = '" + textBox4.Text + "',  Price = '" + textBox5.Text + "', Available = '" + comboBox1.Text + "' WHERE RegNo= '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data updated");
            }
            else
            {
                MessageBox.Show("Put Registration Number");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != " ")
            {
                //This connection is created to develop book mark system and store all the bookmarks in database
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "Delete car where RegNo = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted");
            }
            else
            {
                MessageBox.Show("Put Registration Number");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form3 fp3 = new Form3();
            fp3.Show();
            this.Hide();
        }
    }
}

