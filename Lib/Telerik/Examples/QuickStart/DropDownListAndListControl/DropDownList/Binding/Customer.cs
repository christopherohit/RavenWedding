using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding
{
    public class Customer
    {
        public Customer() 
        { 
            this.id = -1;
            this.name = String.Empty;
        }
        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //Fields
        private int id;
        private string name;
        //Properties
        public int Id
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }
    }
}
