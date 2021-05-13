using System;
using System.Linq;

namespace Telerik.Examples.WinControls.PdfProcessing.PdfChartIntegration
{
    public class Product
    {
        public Product(string name, params double[] q)
        {
            this.Name = name;
            this.Q = q;
        }

        public string Name { get; set; }
        public double[] Q { get; set; }

        public static Product[] GetProducts()
        {
            return new Product[] { 
                new Product("Product1", 25000, 30000, 15000, 25000), 
                new Product("Product2", 20000, 28000, 12000, 20000), 
                new Product("Product3", 14000, 28000, 8400, 14000), 
                new Product("Product4", 7000, 14000, 4200, 7000), 
                new Product("Product5", 7700, 15400, 4620, 7700), 
                new Product("Product6", 13090, 26180, 7854, 13090) };
        }
    }
}