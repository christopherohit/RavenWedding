using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
{
    public class Product
    {
        public string ProductName { get; set; }
        public string UnitQuantity { get; set; }
        public string UnitPrice { get; set; }
        public string InStock { get; set; }
        public string OrderUnits { get; set; }

        public Product(string productName, string unitQuantity, string unitPrice, string inStock, string orderUnits)
        {

            this.ProductName = productName;
            this.UnitQuantity = unitQuantity;
            this.UnitPrice = unitPrice;
            this.InStock = inStock;
            this.OrderUnits = orderUnits;
        }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return ProductName;
                    case 1: return UnitQuantity;
                    case 2: return UnitPrice;
                    case 3: return InStock;
                    case 4: return OrderUnits;
                    default: return String.Empty;
                }
            }
        }
    }
}