using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
{
    public class Employee
    {
        public static readonly string[] FieldNames = { "Photo", "Name", "Salary", "HireDate", "Title" };
        public Image Photo { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Title { get; set; }
        public List<Customer> Customers { get; private set; }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return Photo;
                    case 1: return Name;
                    case 2: return Salary;
                    case 3: return HireDate;
                    case 4: return Title;
                    default: return null;
                }
            }
        }

        public Employee()
        {
            this.Customers = new List<Customer>();
        }
    }
}
