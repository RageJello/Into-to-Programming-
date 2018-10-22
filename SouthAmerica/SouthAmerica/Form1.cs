using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SouthAmerica
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold a country name.
                string countryName;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Countries.txt");

                // Clear anything in the ListBox
                countriesListBox.Items.Clear();

                // Read the file's contents
                while (!inputFile.EndOfStream)
                {
                    // Get a country name
                    countryName = inputFile.ReadLine();

                    // Add country name to the ListBox
                    countriesListBox.Items.Add(countryName);

                }
                // Close the file. 
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
