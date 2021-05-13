using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
{
    public class Product
    {
        private int productID;
        private string productName;
        private string category;
        private int unitsInStock;
        private double unitPrice;
        private char isOrganic;
        private double deliveryDate;

        public Product(int productID, string productName, string category, double unitPrice, int unitsInStock)
        {
            this.productID = productID;
            this.productName = productName;
            this.category = category;
            this.unitPrice = unitPrice;
            this.unitsInStock = unitsInStock;
        }

        public int ProductID
        {
            get { return this.productID; }
            set { this.productID = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set { this.unitsInStock = value; }
        }

        [TypeConverter(typeof(UnitPriceConverter))]
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        [TypeConverter(typeof(ToggleStateConverter))]
        public char IsOrganic
        {
            get { return this.isOrganic; }
            set { this.isOrganic = value; }
        }

        [TypeConverter(typeof(DateTimeConverter))]
        public double DeliveryDate
        {
            get { return this.deliveryDate; }
            set { this.deliveryDate = value; }
        }

        public static List<Product> Generate()
        {
            List<Product> result = new List<Product>();

            result.Add(new Product(1, "Chai", "Beverages", 18.0000, 39));
            result.Add(new Product(2, "Chang", "Beverages", 19.0000, 17));
            result.Add(new Product(3, "Aniseed Syrup", null, 10.0000, 13));
            result.Add(new Product(4, "Chef Anton's Cajun Seasoning", "Condiments", 22.0000, 53));
            result.Add(new Product(5, "Chef Anton's Gumbo Mix", "Condiments", 21.3500, 0));
            result.Add(new Product(6, "Grandma's Boysenberry Spread", "Condiments", 25.0000, 120));
            result.Add(new Product(7, "Uncle Bob's Organic Dried Pears", "Produce", 30.0000, 15));
            result.Add(new Product(8, "Northwoods Cranberry Sauce", "Condiments", 40.0000, 6));
            result.Add(new Product(9, "Mishi Kobe Niku", "Meat/Poultry", 97.0000, 29));
            result.Add(new Product(10, "Ikura", "Seafood", 31.0000, 31));
            result.Add(new Product(11, "Queso Cabrales", "Dairy Products", 21.0000, 22));
            result.Add(new Product(12, "Queso Manchego La Pastora", null, 38.0000, 86));
            result.Add(new Product(13, "Konbu", "Seafood", 6.0000, 24));
            result.Add(new Product(14, "Tofu", "Produce", 23.2500, 35));
            result.Add(new Product(15, "Genen Shouyu", "Condiments", 15.5000, 39));
            result.Add(new Product(16, "Pavlova", "Confections", 17.4500, 29));
            result.Add(new Product(17, "Alice Mutton", "Meat/Poultry", 39.0000, 0));
            result.Add(new Product(18, "Carnarvon Tigers", "Seafood", 62.5000, 42));
            result.Add(new Product(19, "Teatime Chocolate Biscuits", "Confections", 9.2000, 25));
            result.Add(new Product(20, "Sir Rodney's Marmalade", "Confections", 81.0000, 40));
            result.Add(new Product(21, "Sir Rodney's Scones", null, 10.0000, 3));
            result.Add(new Product(22, "Gustaf's Knäckebröd", "Grains/Cereals", 21.0000, 104));
            result.Add(new Product(23, "Tunnbröd", "Grains/Cereals", 9.0000, 61));
            result.Add(new Product(24, "Guaraná Fantástica", null, 4.5000, 20));
            result.Add(new Product(25, "NuNuCa Nuß-Nougat-Creme", "Confections", 14.0000, 76));
            result.Add(new Product(26, "Gumbär Gummibärchen", "Confections", 31.2300, 15));
            result.Add(new Product(27, "Schoggi Schokolade", "Confections", 43.9000, 49));
            result.Add(new Product(28, "Rössle Sauerkraut", "Produce", 45.6000, 26));
            result.Add(new Product(29, "Thüringer Rostbratwurst", "Meat/Poultry", 123.7900, 0));
            result.Add(new Product(30, "Nord-Ost Matjeshering", "Seafood", 25.8900, 10));
            result.Add(new Product(31, "Gorgonzola Telino", "Dairy Products", 12.5000, 0));
            result.Add(new Product(32, "Mascarpone Fabioli", "Dairy Products", 32.0000, 9));
            result.Add(new Product(33, "Geitost", "Dairy Products", 2.5000, 112));
            result.Add(new Product(34, "Sasquatch Ale", "Beverages", 14.0000, 111));
            result.Add(new Product(35, "Steeleye Stout", "Beverages", 18.0000, 20));
            result.Add(new Product(36, "Inlagd Sill", "Seafood", 19.0000, 112));
            result.Add(new Product(37, "Gravad lax", "Seafood", 26.0000, 11));
            result.Add(new Product(38, "Côte de Blaye", "Beverages", 263.5000, 17));
            result.Add(new Product(39, "Chartreuse verte", null, 18.0000, 69));
            result.Add(new Product(40, "Boston Crab Meat", null, 18.4000, 123));
            result.Add(new Product(41, "Jack's New England Clam Chowder", "Seafood", 9.6500, 85));
            result.Add(new Product(42, "Singaporean Hokkien Fried Mee", "Grains/Cereals", 14.0000, 26));
            result.Add(new Product(43, "Ipoh Coffee", null, 46.0000, 17));
            result.Add(new Product(44, "Gula Malacca", "Condiments", 19.4500, 27));
            result.Add(new Product(45, "Rogede sild", null, 9.5000, 5));
            result.Add(new Product(46, "Spegesild", "Seafood", 12.0000, 95));
            result.Add(new Product(47, "Zaanse koeken", "Confections", 9.5000, 36));
            result.Add(new Product(48, "Chocolade", "Confections", 12.7500, 15));
            result.Add(new Product(49, "Maxilaku", "Confections", 20.0000, 10));
            result.Add(new Product(50, "Valkoinen suklaa", null, 16.2500, 65));
            result.Add(new Product(51, "Manjimup Dried Apples", "Produce", 53.0000, 20));
            result.Add(new Product(52, "Filo Mix", "Grains/Cereals", 7.0000, 38));
            result.Add(new Product(53, "Perth Pasties", "Meat/Poultry", 32.8000, 0));
            result.Add(new Product(54, "Tourtière", "Meat/Poultry", 7.4500, 21));
            result.Add(new Product(55, "Pâté chinois", "Meat/Poultry", 24.0000, 115));
            result.Add(new Product(56, "Gnocchi di nonna Alice", "Grains/Cereals", 38.0000, 21));
            result.Add(new Product(57, "Ravioli Angelo", "Grains/Cereals", 19.5000, 36));
            result.Add(new Product(58, "Escargots de Bourgogne", "Seafood", 13.2500, 62));
            result.Add(new Product(59, "Raclette Courdavault", "Dairy Products", 55.0000, 79));
            result.Add(new Product(60, "Camembert Pierrot", "Dairy Products", 34.0000, 19));
            result.Add(new Product(61, "Sirop d'érable", "Condiments", 28.5000, 113));
            result.Add(new Product(62, "Tarte au sucre", "Confections", 49.3000, 17));
            result.Add(new Product(63, "Vegie-spread", "Condiments", 43.9000, 24));
            result.Add(new Product(64, "Wimmers gute Semmelknödel", "Grains/Cereals", 33.2500, 22));
            result.Add(new Product(65, "Louisiana Fiery Hot Pepper Sauce", "Condiments", 21.0500, 76));
            result.Add(new Product(66, "Louisiana Hot Spiced Okra", "Condiments", 17.0000, 4));
            result.Add(new Product(67, "Laughing Lumberjack Lager", "Beverages", 14.0000, 52));
            result.Add(new Product(68, "Scottish Longbreads", "Confections", 12.5000, 6));
            result.Add(new Product(69, "Gudbrandsdalsost", "Dairy Products", 36.0000, 26));
            result.Add(new Product(70, "Outback Lager", "Beverages", 15.0000, 15));
            result.Add(new Product(71, "Flotemysost", "Dairy Products", 21.5000, 26));
            result.Add(new Product(72, "Mozzarella di Giovanni", "Dairy Products", 34.8000, 14));
            result.Add(new Product(73, "Röd Kaviar", null, 15.0000, 101));
            result.Add(new Product(74, "Longlife Tofu", null, 10.0000, 4));
            result.Add(new Product(75, "Rhönbräu Klosterbier", "Beverages", 7.7500, 125));
            result.Add(new Product(76, "Lakkalikööri", "Beverages", 18.0000, 57));
            result.Add(new Product(77, "Original Frankfurter grüne Soße", "Condiments", 13.0000, 32));


            for (int i = 0; i < result.Count; i++)
            {
                Product product = result[i];
                switch (i % 3)
                {
                    case 0:
                        product.IsOrganic = 'Y';
                        break;
                    case 1:
                        product.IsOrganic = 'N';
                        break;
                    case 2:
                        product.IsOrganic = 'M';
                        break;
                    default:
                        break;
                }

                product.DeliveryDate = DateTime.UtcNow.AddDays(-i * 5).ToOADate();
            }

            return result;
        }
    }
}
