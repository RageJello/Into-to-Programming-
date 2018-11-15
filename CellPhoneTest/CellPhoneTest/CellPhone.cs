using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneTest
{
    class CellPhone
    {
        // Fields
        private string brand;   // The phone's brand
        private string model;   // The phone's model
        private decimal price;  // Retail price

        // Constructor
        public CellPhone()
        {
            brand = "";
            model = "";
            price = 0m;
        }

        // Brand Property
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Model Property
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Price Property
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
