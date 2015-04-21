using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ItemsUsed
    {
        private string item;
        private short quantity;

        public ItemsUsed(string item, short quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }

        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public short Quantity
        {
            get { return quantity;  }
            set { quantity = value; }
        }
    }
}
