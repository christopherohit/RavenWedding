using System;

namespace Telerik.Examples.WinControls.VirtualGrid.FirstLook
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public Customer(string customerId, string companyName, string contactName, string contactTitle, string address, string postalCode)
        {
            this.CustomerId = customerId;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.ContactTitle = contactTitle;
            this.Address = address;
            this.PostalCode = postalCode;
        }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return CompanyName;
                    case 1: return ContactName;
                    case 2: return ContactTitle;
                    case 3: return Address;
                    case 4: return PostalCode;
                    default: return String.Empty;
                }
            }
        }
    }
}