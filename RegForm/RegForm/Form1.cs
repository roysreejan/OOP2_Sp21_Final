using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitClick(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string month = cbMonth.SelectedItem.ToString();
            string day = cbDay.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();
            string gender = cbGender.SelectedItem.ToString();

            rtOutput.Text = string.Format("First Name: {0}\nLast Name: {1}\nDate of Birth: {2} {3} {4}\nGender: {5}\n", fname, lname, month, day, year, gender);

           MessageBox.Show("Submit Cliclked");
        }
    }
}
