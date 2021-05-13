using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.IndicateErrors
{
    public enum EmployeePosition { VicePresident, SalesManager, SalesRepresentative, Coordinator }

    public class Employee : IDataErrorInfo
    {
        int id;
        string name;
        string email;
        string phone;
        string city;
        EmployeePosition position;

        public Employee()
        { 
        }

        public Employee(int id, string name, string city, string email, string phone, EmployeePosition position)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.email = email;
            this.phone = phone;
            this.position = position;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public EmployeePosition Position
        {
            get { return this.position; }
            set { position = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        #region IDataErrorInfo Members

        [Browsable(false)]
        public string Error
        {
            get
            {
                if (!IsEmailValid() || !IsNameValid() || !IsPhoneValid())
                {
                    return "Please enter valid data in this row!";
                }
                return string.Empty;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Email" && !IsEmailValid())
                {
                    return "This is not a valid email!";
                }
                if (columnName == "Phone" && !IsPhoneValid())
                {
                    return "This is not a valid phone!";
                }
                if (columnName == "Name" && !IsNameValid())
                {
                    return "This is not a valid name!";
                }
                return string.Empty;
            }
        }

        private bool IsEmailValid()
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            return !String.IsNullOrEmpty(email) && re.IsMatch(email);
        }

        private bool IsNameValid()
        {
            return !string.IsNullOrEmpty(name) && char.IsLetter(name[0]) && name.Length > 3;
        }

        private bool IsPhoneValid()
        {
            string strRegex = @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$";
            Regex re = new Regex(strRegex);
            return !String.IsNullOrEmpty(phone) && re.IsMatch(phone);
        }

        #endregion
    }
}
