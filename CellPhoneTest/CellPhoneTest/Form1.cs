using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhoneTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold price
            decimal price;

            // Get the phone's brand
            phone.Brand = brandTextBox.Text;

            // Get the phone's model
            phone.Model = modelTextBox.Text;

            // Get the phone's price
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid Price");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object
            CellPhone myPhone = new CellPhone();

            // Get the phone's data
            GetPhoneData(myPhone);

            // Display the phone data.
            brandPropertiesLabel.Text = myPhone.Brand;
            modelPropertiesLabel.Text = myPhone.Model;
            pricePropertiesLabel.Text = myPhone.Price.ToString("c");
        }

    }
}
