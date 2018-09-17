using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekly_Time_Sheet
{
    public partial class weeklyTimeSheet : Form
    {
        public weeklyTimeSheet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double hoursWorked;
            double hourlyRate;
            double grossPay;

            //Get the hours worked from the TextBox
            hoursWorked = double.Parse(hoursWorkedTextBox.Text);
            hourlyRate = double.Parse(hourlyRateTextBox.Text);
            grossPay = hoursWorked * hourlyRate;
            grossPayControlLabel.Text = grossPay.ToString();

        }

        private void weeklyTimeSheet_Load(object sender, EventArgs e)
        {

        }
    }
}
