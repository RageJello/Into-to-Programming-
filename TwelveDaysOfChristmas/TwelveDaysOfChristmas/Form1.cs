using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwelveDaysOfChristmas
{
    public partial class Form1 : Form
    {
        TwelveDaysOfChristmas twelveDaysOfChristmas = new TwelveDaysOfChristmas();
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                //string day = e.Start.ToString();
                DateTime daySelected = e.Start;
                int day = daySelected.Day;
                int giftNumber = day - 1;

                
                MessageBox.Show(twelveDaysOfChristmas.GetChristmasGift(giftNumber));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
