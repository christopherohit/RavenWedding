using System.Drawing;

namespace Telerik.Examples.WinControls.VirtualGrid.WebService
{
    public class Product
    {
        public int ProductID { get; set; }
        public Image Image { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return Image;
                    case 1: return ProductName;
                    case 2: return UnitPrice;
                    case 3: return UnitsInStock;
                    case 4: return Discontinued;
                    default: return null;
                }
            }
        }
    }
}