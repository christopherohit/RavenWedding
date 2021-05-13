using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.PropertyGrid.Validation
{
    public enum Gender { Male, Female };

    public class PersonInfo
    {
        string name;
        string family;
        Gender gender;
        int age;
        string city;
        string country;
        string email;
        string phone;

        [Category("Personal Information")]
        [Description("Employee name cannot be blank!")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Category("Personal Information")]
        [Description("Employee family cannot be blank!")]
        public string Family
        {
            get { return family; }
            set { family = value; }
        }

        [Category("Personal Information")]
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [Category("Personal Information")]
        [Description("Employee age can be between 18 and 56 years.")]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        [Category("Address")]
        [Description("This field represents the city where the employee lives and cannot be blank.")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [Category("Address")]
        [Description("This field represents the country where the employee lives and cannot be blank.")]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [Category("Address")]
        [Description("The EMail field should contain a valid email.")]
        public string EMail
        {
            get { return email; }
            set { email = value; }
        }

        [Category("Address")]
        [Description("The Phone field should contain a valid us style phone number.")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
