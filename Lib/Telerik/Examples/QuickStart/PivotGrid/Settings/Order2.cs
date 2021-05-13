using System;
using System.Collections.Generic; 
using System.Text;

namespace Telerik.Examples.WinControls.PivotGrid
{
    public class Order2
    {
        private double net;

        public Order2()
        {
        }

        public DateTime Date { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }

        public double Net
        {
            get
            {
                if (this.net == 1025.64)
                {
                    // throw new Exception("Example for error value");
                }
                return this.net;
            }
            set
            {
                this.net = value;
            }
        }

        public string Promotion { get; set; }
        public string Advertisement { get; set; }

        public override string ToString()
        {
            return this.Product + this.Promotion + this.Quantity;
        }
    }
}
