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

namespace FootballStandings
{
    public partial class football : Form
    {
        public football()
        {
            InitializeComponent();
        }

        string divisionFileName = "";
        string teamName = "";
        StreamReader divisionFile;
        StreamWriter standingsFile;

        private void TeamNameFiller(string divisionFileName)
        {
            divisionFile = File.OpenText(divisionFileName);
            teamsTextBox.Text = "";
            while (!divisionFile.EndOfStream)
            {
                teamName = divisionFile.ReadLine();
                teamsTextBox.Text += teamName + Environment.NewLine;
            }
            divisionFile.Close();
        }

            private void DivisionStanding(string divisionHolder)
        {
            switch (divisionHolder)
            {
                case "afcNorth":
                    divisionFileName = "AFC North.txt";
                    break;
                case "afcEast":
                    divisionFileName = "AFC East.txt";
                    break;
                case "afcWest":
                    divisionFileName = "AFC West.txt";
                    break;
                case "afcSouth":
                    divisionFileName = "AFC South.txt";
                    break;
                case "nfcNorth":
                    divisionFileName = "NFC North.txt";
                    break;
                case "nfcEast":
                    divisionFileName = "NFC East.txt";
                    break;
                case "nfcWest":
                    divisionFileName = "NFC West.txt";
                    break;
                case "nfcSouth":
                    divisionFileName = "NFC South.txt";
                    break;
                default:
                    MessageBox.Show("Error: Something is very wrong. You should probably panic.");
                    break;
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void afcEastButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("afcEast");
            TeamNameFiller(divisionFileName);
        }

        private void afcNorthButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("afcNorth");
            TeamNameFiller(divisionFileName);
        }

        private void afcWestButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("afcWest");
            TeamNameFiller(divisionFileName);
        }

        private void afcSouthButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("afcSouth");
            TeamNameFiller(divisionFileName);
        }

        private void nfcNorthButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("nfcNorth");
            TeamNameFiller(divisionFileName);
        }

        private void nfcEastButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("nfcEast");
            TeamNameFiller(divisionFileName);
        }

        private void nfcWestButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("nfcWest");
            TeamNameFiller(divisionFileName);
        }

        private void nfcSouthButton_Click(object sender, EventArgs e)
        {
            DivisionStanding("nfcSouth");
            TeamNameFiller(divisionFileName);
        }

        private void saveStandingsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveStandings = new SaveFileDialog();
            saveStandings.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveStandings.ShowDialog() == DialogResult.OK)
            {
                standingsFile = File.CreateText(saveStandings.FileName);
                standingsFile.WriteLine(teamsTextBox.Text);
                standingsFile.Close();
            }
        }
    }
}
    