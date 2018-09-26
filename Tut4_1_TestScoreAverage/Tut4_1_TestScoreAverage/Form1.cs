using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut4_1_TestScoreAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void calcAvgButton_Click(object sender, EventArgs e)
        {
            try
            {
                const double HIGH_SCORE = 95.0;         // High score value
                double test1, test2, test3, average;    // Variable 

                // Get the test scores from the text boxes
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Calculate the average test score
                average = (test1 + test2 + test3) / 3.0;

                // Display the average, rounded to 2 decimal places
                averageTextBox.Text = average.ToString("n1");

                // If the average is a high score, congratulate the user with a message box.
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations! Great job!");
                }
            }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageTextBox.Text = "";

            // Reset the focus to test1
            test1TextBox.Focus();
        }
    }
}
