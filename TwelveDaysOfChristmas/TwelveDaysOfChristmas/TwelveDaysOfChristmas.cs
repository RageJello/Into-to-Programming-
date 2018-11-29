using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    class TwelveDaysOfChristmas
    {
        // Members 

        private string gift;
        const int SIZE = 12;
        private string[] gifts = new string[SIZE];


        // Constructor
        public TwelveDaysOfChristmas()
        {
            ChristmasGifts();
        }

        // Properties
        public string Gift
        {
            get { return gift; }
            set { gift = value; }
        }

        private void ChristmasGifts()
        {
            //Add gifts to array
            gifts[0]  = "Partidge in a Pear Tree";
            gifts[1]  = "Two Turtle Doves";
            gifts[2]  = "Three French Hens";
            gifts[3]  = "Four Calling Birds";
            gifts[4]  = "Five Gold Rings";
            gifts[5]  = "Six Geese-A-Layin";
            gifts[6]  = "Seven Swans A-Swimming";
            gifts[7]  = "Eight Maids A-Milking";
            gifts[8]  = "Nine Ladies Dancing";
            gifts[9]  = "Ten Lords A-Leaping";
            gifts[10] = "Eleven Pipers Piping";
            gifts[11] = "Twelve Drummers Drumming";
        }

        public string GetChristmasGift(int giftNumber)
        {
            return gifts.GetValue(giftNumber).ToString();
        }

    }
}
