using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
{
    public class Customer
    {
        public static readonly string[] FieldNames = { "CompanyName", "Country", "City", "ContactName" };

        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ContactName { get; set; }
        public List<Sale> Sales { get; private set; }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return CompanyName;
                    case 1: return Country;
                    case 2: return City;
                    case 3: return ContactName;
                    default: return null;
                }
            }
        }

        public Customer()
        {
            this.Sales = new List<Sale>();
        }
    }
}
