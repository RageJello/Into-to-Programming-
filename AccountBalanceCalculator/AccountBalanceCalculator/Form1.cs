using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBalanceCalculator
{
    public partial class EndingBalance : Form
    {
        public EndingBalance()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the textboxes and the endingBalance control.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceTextBox.Text = "";

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Constant for the monthly interest rate
            const decimal INTEREST_RATE = 0.005m;

            // Local Variables.
            decimal balance;    // The account balance
            int months;         // The number of months
            int count = 1;      // Loop counter, initialized with 1

            // Get the starting balance.
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                // Get the number of months
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    while (count <= months)
                    {
                        // Add the month's interest to the balance
                        balance = balance + (INTEREST_RATE * balance);

                        // Increment the loop counter
                        count = count + 1;
                    }

                    // Display the ending balance
                    endingBalanceTextBox.Text = balance.ToString("c");
                }
                else
                {
                    // Invalid starting balance was entered.
                    MessageBox.Show("Invalid value for starting balance.");
                }
            }
        }
    }
}
