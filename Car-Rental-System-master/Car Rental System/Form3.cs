using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form4 fp4 = new Form4();
            fp4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fp5 = new Form5();
            fp5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fp6 = new Form6();
            fp6.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 fp7 = new Form7();
            fp7.Show();
            this.Hide();
        }
    }
}
