using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketFinal
{
    public partial class RocketForm : Form
    {
        // **INSERT RELEVENT COMMENT**
        RocketClass rocketClass = new RocketClass();

        public RocketForm()
        {
            InitializeComponent();
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rocketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rocketNumber = rocketListBox.SelectedIndex;
            //MessageBox.Show(rocketClass.LaunchRocketName(rocketNumber));
            rocketNameTextBox.Text = rocketClass.LaunchRocketName(rocketNumber);
            rocketManufacturerTextBox.Text = rocketClass.LaunchRocketManufacturer(rocketNumber);
            rocketStatusTextBox.Text = rocketClass.LaunchRocketStatus(rocketNumber);
            rocketLastLaunchDateTextBox.Text = rocketClass.LaunchRocketLastLaunch(rocketNumber);
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This would have been significantly better had I used a database...")
        }
    }
}
