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
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query = "Insert into CarReturn(Id, RegNo, Name, ReturnDate, Delay, Fine) values(@Id, @RegNo, @Name, @ReturnDate, @Delay, @Fine)";

                SqlCommand cmd = new SqlCommand(query, con);

                // Use parameters to avoid SQL injection and format issues
                cmd.Parameters.AddWithValue("@Id", textBox3.Text);
                cmd.Parameters.AddWithValue("@RegNo", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@ReturnDate", dateTimePicker1.Value); // Use Value instead of Text
                cmd.Parameters.AddWithValue("@Delay", textBox4.Text);
                cmd.Parameters.AddWithValue("@Fine", textBox5.Text);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data inserted");
                    }
                    else
                    {
                        MessageBox.Show("Error occurred");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = "UPDATE CarReturn SET RegNo = @RegNo, Name = @Name, ReturnDate = @ReturnDate, Delay = @Delay, Fine = @Fine WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Use parameters to avoid SQL injection and format issues
                    cmd.Parameters.AddWithValue("@RegNo", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ReturnDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Delay", int.Parse(textBox4.Text));
                    cmd.Parameters.AddWithValue("@Fine", int.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@Id", textBox3.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data updated");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Put Registration Number");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox3.Text != " ")
            {
                //This connection is created to develop book mark system and store all the bookmarks in database
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "Delete CarReturn where Id = '" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted");
            }
            else
            {
                MessageBox.Show("Put Return Id Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fp3 = new Form3();
            fp3.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet3.CarReturn' table. You can move, or remove it, as needed.
            this.carReturnTableAdapter.Fill(this.carRentalDataSet3.CarReturn);

        }
    }
}
