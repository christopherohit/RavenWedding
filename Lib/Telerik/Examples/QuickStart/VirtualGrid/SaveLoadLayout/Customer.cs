using System;

namespace Telerik.Examples.WinControls.VirtualGrid.SaveLoadLayout
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public Customer(string customerId, string companyName, string contactName, string country, string city)
        {

            this.CustomerId = customerId;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.Country = country;
            this.City = city;
        }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return CustomerId;
                    case 1: return CompanyName;
                    case 2: return ContactName;
                    case 3: return Country;
                    case 4: return City;
                    default: return String.Empty;
                }
            }
        }
    }
}