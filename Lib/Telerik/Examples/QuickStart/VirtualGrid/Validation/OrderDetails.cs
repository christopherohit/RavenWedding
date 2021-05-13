using System;

namespace Telerik.Examples.WinControls.VirtualGrid.Validation
{
    public class OrderDetails
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
        public string Discount { get; set; }

        public OrderDetails(string orderId, string productId, string unitPrice, string quantity, string discount)
        {

            this.OrderId = orderId;
            this.ProductId = productId;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.Discount = discount;
        }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return OrderId;
                    case 1: return ProductId;
                    case 2: return UnitPrice;
                    case 3: return Quantity;
                    case 4: return Discount;
                    default: return String.Empty;
                }
            }
            set
            {
                switch (i)
                {
                    case 0: this.OrderId = value;
                        break;
                    case 1: this.ProductId = value;
                        break;
                    case 2: this.UnitPrice = value;
                        break;
                    case 3: this.Quantity = value; 
                        break;
                    case 4: this.Discount = value;
                        break;
                }
            }
        }
    }
}