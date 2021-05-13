using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataEntry.Validation
{
    public class Person : IEditableObject, INotifyPropertyChanged
    {
        EmployeeData backupEmplData;
        private DateTime startingDate;
        private string firstName;
        private string lastName;
        private int salary;
        private OccupationPositions occupation;
        private string phoneNum;

        public enum OccupationPositions
        {
            Casher,
            Consultant,
            Security,
            Supplies,
            SuppliesManager,
            StaffManager,
            HygieneStaff
        }

        public struct EmployeeData
        {
            internal DateTime startingDate;
            internal string firstName;
            internal string lastName;
            internal int salary;
            internal OccupationPositions occupation;
            internal string phoneNum;
        }

        public Person()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.salary = 1500;
            this.phoneNum = string.Empty;
        }

        public Person(DateTime startingDate, string fName, string lName, OccupationPositions occ, string phoneNum, int sal)
        {
            this.backupEmplData = new EmployeeData();
            this.backupEmplData.startingDate = startingDate;
            this.StartingDate = startingDate;
            this.backupEmplData.salary = sal;
            this.Salary = sal;
            this.backupEmplData.firstName = fName;
            this.FirstName = fName;
            this.backupEmplData.lastName = lName;
            this.LastName = lName;
            this.backupEmplData.occupation = occ;
            this.Occupation = occ;
            this.backupEmplData.phoneNum = phoneNum;
            this.PhoneNumber = phoneNum;
            this.StartingDate = startingDate;
        }

        [DisplayName("First Name")]
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        [DisplayName("Last Name")]
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }

        public OccupationPositions Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                occupation = value;
                NotifyPropertyChanged("Occupation");
            }
        }

        [DisplayName("Starting Date")]
        public DateTime StartingDate
        {
            get
            {
                return startingDate;
            }
            set
            {
                startingDate = value;
                NotifyPropertyChanged("StartingDate");
            }
        }

        [DisplayName("Phone Number")]
        public string PhoneNumber
        {
            get
            {
                return phoneNum;
            }
            set
            {
                phoneNum = value;
                NotifyPropertyChanged("PhoneNumber");
            }
        }

        [RadRange(1500,1700)]
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
                NotifyPropertyChanged("Salary");
            }
        }



        public void BeginEdit()
        {

        }

        public void CancelEdit()
        {
            Salary = this.backupEmplData.salary;
            StartingDate = this.backupEmplData.startingDate;
            FirstName = this.backupEmplData.firstName;
            LastName = this.backupEmplData.lastName;
            Occupation = this.backupEmplData.occupation;
            PhoneNumber = this.backupEmplData.phoneNum;
        }

        public void EndEdit()
        {
            this.backupEmplData.salary = Salary;
            this.backupEmplData.startingDate = StartingDate;
            this.backupEmplData.firstName = FirstName;
            this.backupEmplData.lastName = LastName;
            this.backupEmplData.occupation = Occupation;
            this.backupEmplData.phoneNum = PhoneNumber;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
