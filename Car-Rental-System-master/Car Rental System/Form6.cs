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
    public partial class Form6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet2.Rental' table. You can move, or remove it, as needed.
            this.rentalTableAdapter.Fill(this.carRentalDataSet2.Rental);
            //This connection is checking database value if it is suitable then go further
            SqlConnection con1 = new SqlConnection(cs);
            con1.Open();
            string query1 = "Select Available from car";
            SqlCommand cmd1 = new SqlCommand(query1, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    string availableValue = reader1["Available"].ToString();
                    if (availableValue == "Yes")
                    {
                        // TODO: This line of code loads data into the 'carRentalDataSet3.Rental' table. You can move, or remove it, as needed.

                        //this.rentalTableAdapter.Fill(this.carRentalDataSet3.Rental);
                        try
                        {
                            SqlConnection con = new SqlConnection(cs);
                            con.Open();
                            string query = "Select RegNo from car";
                            SqlCommand cmd = new SqlCommand(query, con);
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            DataTable car = new DataTable();
                            da.Fill(car);

                            comboBox1.DataSource = car;
                            comboBox1.DisplayMember = "RegNo";


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        try
                        {
                            SqlConnection con = new SqlConnection(cs);
                            con.Open();
                            string query = "Select ID from customer";
                            SqlCommand cmd = new SqlCommand(query, con);
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            DataTable customer = new DataTable();
                            da.Fill(customer);
                            comboBox2.DataSource = customer;
                            comboBox2.DisplayMember = "ID";
                            comboBox2.ValueMember = "ID";

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (availableValue == "No")
                    {
                        MessageBox.Show("Cars are not avalable");
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = "INSERT INTO Rental (RentId, CarReg, CustId, CustName, RentDate, ReturnDate, Fees) " +
                                   "VALUES (@RentId, @CarReg, @CustId, @CustName, @RentDate, @ReturnDate, @Fees)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    if (comboBox2.SelectedItem != null)
                    {
                        DataRowView selectedRow = (DataRowView)comboBox2.SelectedItem;
                        int custId = (int)selectedRow["ID"];
                        cmd.Parameters.AddWithValue("@CustId", custId);
                    }
                    else
                    {
                        // Handle the case where comboBox2.SelectedItem is null
                        // You might want to show an error message or handle it in some way
                        MessageBox.Show("Please select a customer.");
                        return; // Exit the method to avoid further processing
                    }

                    cmd.Parameters.AddWithValue("@Fees", decimal.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@RentId", int.Parse(textBox1.Text)); // Assuming RentId is an integer
                    cmd.Parameters.AddWithValue("@CarReg", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@CustName", textBox4.Text);
                    cmd.Parameters.AddWithValue("@RentDate", DateTime.Parse(dateTimePicker2.Text));
                    cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Parse(dateTimePicker1.Text));

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data inserted");
                    }
                    else
                    {
                        MessageBox.Show("Error occurred");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();

                        string query = "UPDATE Rental SET CarReg = @CarReg, CustId = @CustId, CustName = @CustName, RentDate = @RentDate, ReturnDate = @ReturnDate WHERE RentId = @RentId";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@RentId", int.Parse(textBox1.Text)); // Assuming RentId is an integer
                        cmd.Parameters.AddWithValue("@CarReg", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@CustId", int.Parse(comboBox2.Text)); // Assuming CustId is an integer
                        cmd.Parameters.AddWithValue("@CustName", textBox4.Text);
                        cmd.Parameters.AddWithValue("@RentDate", DateTime.Parse(dateTimePicker2.Text));
                        cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Parse(dateTimePicker1.Text));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Insert Rental ID Number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {

                //This connection is created to develop book mark system and store all the bookmarks in database
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "Delete Rental where RentId = '" + textBox1.Text + "'";
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
