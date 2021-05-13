using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
{
    public class Sale
    {
        public static readonly string[] FieldNames = { "ProductNumber", "Quantity", "Discount", "Total" };

        public int ProductNumber { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int Total { get; set; }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return ProductNumber;
                    case 1: return Quantity;
                    case 2: return Discount;
                    case 3: return Total;
                    default: return null;
                }
            }
        }
    }
}
