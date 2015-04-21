using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Items
    {
        private string name;
        private string description;
        private double price;
        public Items(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public string ItemName
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value;  }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
