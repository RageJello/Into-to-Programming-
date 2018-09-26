using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            //Declare Color variables
            decimal bgColor, firstColor, secondColor;
            bgColor = 0;
            firstColor = 0;
            secondColor = 0;

            // Set the background color of the first group box to the selected color within and set firstColor equal to numeric values for red(1), blue(10), and yellow(100)
            if (firstRedRadioButton.Checked)
            {
                firstColorGroupBox.BackColor = Color.Red;
                firstColor = 1;
            }
            else if (firstBlueRadioButton.Checked)
            {
                firstColorGroupBox.BackColor = Color.Blue;
                firstColor = 10;

            }
            else if (firstYellowRadioButton.Checked)
            {
                firstColorGroupBox.BackColor = Color.Yellow;
                firstColor = 100;
            }

            // Set the background color of the second group box to the color selected within and set secondColor equal to numeric values for red(1), blue(10), and yellow(100)
            if (secondRedRadioButton.Checked)
            {
                secondColorGroupBox.BackColor = Color.Red;
                secondColor = 1;
            }
            else if (secondBlueRadioButton.Checked)
            {
                secondColorGroupBox.BackColor = Color.Blue;
                secondColor = 10;
            }
            else if (secondYellowRadioButton.Checked)
            {
                secondColorGroupBox.BackColor = Color.Yellow;
                secondColor = 100;
            }

            // add first and second color's numeric value to determine mixed color
            bgColor = firstColor + secondColor;
           
            // use switch to set the appropriate background color
            switch (bgColor)
            {
                case 2:
                    this.BackColor = Color.Red;
                    break;
                case 20:
                    this.BackColor = Color.Blue;
                    break;
                case 200:
                    this.BackColor = Color.Yellow;
                    break;
                case 011:
                    this.BackColor = Color.Purple;
                    break;
                case 101:
                    this.BackColor = Color.Orange;
                    break;
                case 110:
                    this.BackColor = Color.Green;
                    break;
                default:
                    MessageBox.Show(bgColor.ToString());
                    break;
            }

        }
    }
}
