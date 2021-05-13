using System;
using System.Collections;
using System.ComponentModel;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.Examples.WinControls.Properties;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls;
using Telerik.Examples.WinControls.DataSources;
using System.Threading;

namespace Telerik.Examples.WinControls.GridView.PopulateWithData.DataBinding
{
    public partial class Form1 : ExamplesForm
    {
        private ArrayList list1 = new ArrayList();
        private BindingList<StudentObject> list2 = new BindingList<StudentObject>();
        private ArrayList list3 = new ArrayList();
        private NorthwindDataSet set;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter adapter;

        public Form1()
        {
            InitializeComponent();
			this.SelectedControl = this.radGridView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetPreferences();
            BindToDataReader();
        }

        private void SetPreferences()
        {
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.EnableHotTracking = true;
            this.radRadioDataReader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void BindToDataReader()
        {
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = true;

            this.radGridView1.TableElement.BeginUpdate();

            using (OleDbCommand command = new OleDbCommand("SELECT CompanyName, ContactName, ContactTitle, Address, PostalCode FROM Customers"))
            {
                command.Connection = new OleDbConnection(Settings.Default.NwindConnectionString);
                command.Connection.Open();
                this.radGridView1.MasterTemplate.LoadFrom(command.ExecuteReader());
                command.Connection.Close();
            }

            for (int i = 0; i < radGridView1.MasterTemplate.Columns.Count; i++)
            {
                this.radGridView1.MasterTemplate.Columns[i].Width = 102;
            }

            this.radGridView1.Columns["ContactName"].HeaderText = "Contact Name";
            this.radGridView1.Columns["CompanyName"].HeaderText = "Company Name";
            this.radGridView1.Columns["ContactTitle"].HeaderText = "Contact Title";
            this.radGridView1.Columns["ContactTitle"].EnableExpressionEditor = true;
            this.radGridView1.Columns["PostalCode"].HeaderText = "Postal Code";
            
            this.radGridView1.TableElement.EndUpdate();
        }

        private void BindToArrayList()
        {
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = true;

            if (list1.Count == 0)
            {
                list1.Add(new ValueType<string>("Asparagus"));
                list1.Add(new ValueType<string>("Broccoli"));
                list1.Add(new ValueType<string>("Cabbage"));
                list1.Add(new ValueType<string>("Carrots"));
                list1.Add(new ValueType<string>("Corn, yellow"));
                list1.Add(new ValueType<string>("Cucumbers"));
                list1.Add(new ValueType<string>("Eggplant"));
                list1.Add(new ValueType<string>("Garlic"));
                list1.Add(new ValueType<string>("Green peas"));
                list1.Add(new ValueType<string>("Mushrooms"));
                list1.Add(new ValueType<string>("Onions"));
                list1.Add(new ValueType<string>("Olives"));
                list1.Add(new ValueType<string>("Potatoes"));
                list1.Add(new ValueType<string>("Spinach"));
                list1.Add(new ValueType<string>("Tomatoes"));
                list1.Add(new ValueType<string>("Yams"));
            }
            
            this.radGridView1.DataSource = list1;

            if (this.radGridView1.Columns.Count > 0)
            {
                this.radGridView1.Columns[0].Width = 200;
                this.radGridView1.Columns[0].HeaderText = "Vegetables";
            }
        }

        private void BindToCustomObjects()
        {
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = true;

            if (list2.Count == 0)
            {
                list2.Add(new StudentObject("Brent", "Allen", 175.4f, 72.0f, 16));
                list2.Add(new StudentObject("Carolina", "Bailey", 160.7f, 46.0f, 18));
                list2.Add(new StudentObject("Whitney", "Barnebey", 157.0f, 40.0f, 15));
                list2.Add(new StudentObject("Sarah", "Beckham", 165.1f, 48.0f, 16));
                list2.Add(new StudentObject("Dun", "Deng", 173.4f, 70.5f, null));
                list2.Add(new StudentObject("Tu-Lin", "Chiu", 150.4f, 40.5f, 12));
                list2.Add(new StudentObject("Alexandra", "Galambos", 152.4f, 42.0f, null));
                list2.Add(new StudentObject("Tammy", "Goss", 175.4f, 75.3f, 18));
                list2.Add(new StudentObject("Iljo", "Ha", 178.4f, 74.0f, 17));
                list2.Add(new StudentObject("Merdith", "Johnson", 180.4f, 68.0f, 17));
                list2.Add(new StudentObject("Yoon", "Jeon", 182.4f, 80.0f, 18));
                list2.Add(new StudentObject("Blake", "Rodgers", 154.4f, 46.0f, 12));
                list2.Add(new StudentObject("Rebecca", "Shields", 175.4f, 60.0f, null));
                list2.Add(new StudentObject("Erica", "Sim", 175.8f, 72.6f, 18));
                list2.Add(new StudentObject("Xiaoyi", "Sun", 167.4f, 53.0f, 16));
            }

            this.radGridView1.DataSource = list2;

            this.radGridView1.Columns["FirstName"].HeaderText = "First Name";
            this.radGridView1.Columns["LastName"].HeaderText = "Last Name";
            this.radGridView1.Columns["Age"].TextAlignment = ContentAlignment.MiddleRight;
            this.radGridView1.Columns["Age"].FormatString = "{0} y/o";
            this.radGridView1.Columns["Weight"].TextAlignment = ContentAlignment.MiddleRight;
            this.radGridView1.Columns["Weight"].FormatString = "{0} kg.";


        }

        private void BindToSubObjects()
        {
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;

            this.radGridView1.DataSource = null;

            this.radGridView1.TableElement.BeginUpdate();
            this.radGridView1.MasterTemplate.Columns.Clear();
            this.radGridView1.MasterTemplate.Columns.Add(new GridViewTextBoxColumn("Name", "CustomerName"));
            this.radGridView1.MasterTemplate.Columns.Add(new GridViewTextBoxColumn("Address.City", "Address.City"));
            this.radGridView1.MasterTemplate.Columns.Add(new GridViewTextBoxColumn("Address.Country", "Address.Country"));
            this.radGridView1.MasterTemplate.Columns.Add(new GridViewTextBoxColumn("Address.ContactDetails.Phone", "Address.ContactDetails.Phone"));

            for (int i = 0; i < radGridView1.MasterTemplate.Columns.Count; i++)
            {
                this.radGridView1.MasterTemplate.Columns[i].Width = 150;
            }
            this.radGridView1.TableElement.EndUpdate(false);

            if (list3.Count == 0)
            {
                list3.Add(new Customer(1, "Maria Anders", "Alfreds Futterkiste", "Germany", "Berlin", "12209", "030-0074321"));
                list3.Add(new Customer(2, "Roland Mendel", "Ernst Handel", "Austria", "Graz", "8010", "7675-3425"));
                list3.Add(new Customer(3, "Thomas Hardy", "Around the Horn", "UK", "London", "WA1 1DP", "(171) 555-7788"));
                list3.Add(new Customer(4, "Laurence Lebihan", "Bon app'", "France", "Marseille", "13008", "91.24.45.40"));
                list3.Add(new Customer(5, "Carine Schmitt", "France restauration", "France", "Nantes", "44000", "40.32.21.21"));
            }

            this.radGridView1.DataSource = list3;
           
            this.radGridView1.Columns[3].Width = 200;
        }

        private void BindToDataSet()
        {
            this.radGridView1.MasterTemplate.AutoGenerateColumns = true;

            if (set == null)
            {
                set = new NorthwindDataSet();
                adapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
                adapter.Fill(set.Employees);
            }
            radGridView1.DataSource = set.Employees;

            radGridView1.Columns["EmployeeID"].IsVisible = false;
            radGridView1.Columns["TitleOfCourtesy"].IsVisible = false;
            radGridView1.Columns["BirthDate"].IsVisible = false;
            radGridView1.Columns["HireDate"].IsVisible = false;
            radGridView1.Columns["Address"].IsVisible = false;
            radGridView1.Columns["Region"].IsVisible = false;
            radGridView1.Columns["HomePhone"].IsVisible = false;
            radGridView1.Columns["Extension"].IsVisible = false;
            radGridView1.Columns["Photo"].IsVisible = false;
            radGridView1.Columns["Notes"].IsVisible = false;
            radGridView1.Columns["ReportsTo"].IsVisible = false;

            radGridView1.Columns["LastName"].HeaderText = "Last Name";
            radGridView1.Columns["FirstName"].HeaderText = "First Name";
            radGridView1.Columns["PostalCode"].HeaderText = "Postal Code";
        }

        public class StudentObject : INotifyPropertyChanged
        {
            private string firstName;
            private string lastName;
            private float height;
            private float weight;
            private int? age;

            public StudentObject(string iFname, string iLname, float iHeight, float iWeight, int? iAge)
            {
                this.firstName = iFname;
                this.lastName = iLname;
                this.height = iHeight;
                this.weight = iWeight;
                this.age = iAge;
            }

            public string FirstName
            {
                get { return this.firstName; }
                set
                {
                    if (this.firstName != value)
                    {
                        this.firstName = value;
                        OnPropertyChanged("FirstName");
                    }
                }
            }

            public string LastName
            {
                get { return this.lastName; }
                set
                {
                    if (this.lastName != value)
                    {
                        this.lastName = value;
                        OnPropertyChanged("LastName");
                    }
                }
            }

            public int? Age
            {
                get { return this.age; }
                set
                {
                    if (this.age != value)
                    {
                        this.age = value;
                        OnPropertyChanged("Age");
                    }
                }
            }
            
			public float Height
            {
                get { return this.height; }
                set
                {
                    if (this.height != value)
                    {
                        this.height = value;
                        OnPropertyChanged("Height");
                    }
                }
            }

            public float Weight
            {
                get { return this.weight; }
                set
                {
                    if (this.weight != value)
                    {
                        this.weight = value;
                        OnPropertyChanged("Weight");
                    }
                }
            }

            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }

            protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, e);
            }

            #endregion
        }

        public class ValueType<T>
        {
            T item;

            public ValueType()
            {

            }

            public ValueType(T item)
            {
                this.item = item;
            }

            public T Item
            {
                get { return this.item; }
                set { this.item = value; }
            }
        }

        public class ContactDetails
        {
            string postalCode;
            string phone;

            public string PostalCode
            {
                get { return postalCode; }
                set { postalCode = value; }
            }

            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            public ContactDetails()
            {
            }

            public ContactDetails(string postalCode, string phone)
            {
                this.postalCode = postalCode;
                this.phone = phone;
            }
        }

        public class Address
        {
            string country;
            string city;
            ContactDetails contactDetails;

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public ContactDetails ContactDetails
            {
                get { return this.contactDetails; }
            }

            public Address()
            {
                this.contactDetails = new ContactDetails();
            }

            public Address(string country, string city, string postalCode, string phone)
            {
                this.country = country;
                this.city = city;
                this.contactDetails = new ContactDetails(postalCode, phone);
            }
        }

        public class Customer
        {
            int id;
            string customerName;
            string companyName;
            Address address;

            public int ID
            {
                get { return this.id; }
                set { this.id = value; }
            }

            public string CustomerName
            {
                get { return this.customerName; }
                set { this.customerName = value; }
            }

            public string CompanyName
            {
                get { return this.companyName; }
                set { this.companyName = value; }
            }

            public Address Address
            {
                get { return this.address; }
            }

            public Customer()
            {
                this.address = new Address();
            }

            public Customer(int id, string customerName, string companyName, string country, string city, string postalCode, string phone)
            {
                this.id = id;
                this.customerName = customerName;
                this.companyName = companyName;
                this.address = new Address(country, city, postalCode, phone);
            }
        }

        private void radRadio_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.Columns.Clear();
            this.radGridView1.GroupDescriptors.Clear();
            this.radGridView1.SortDescriptors.Clear();
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.DataSource = null;

            if (radRadioDataReader.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                BindToDataReader();
            }

            if (radRadioObjects.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                BindToCustomObjects();
            }

            if (radRadioSubObj.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                BindToSubObjects();
            }

            if (radRadioArrLst.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                BindToArrayList();
            }

            if (radRadioDataSet.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                BindToDataSet();
            }
        }

        protected override void WireEvents()
        {
            this.radRadioArrLst.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadio_ToggleStateChanged);
            this.radRadioSubObj.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadio_ToggleStateChanged);
            this.radRadioObjects.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadio_ToggleStateChanged);
            this.radRadioDataReader.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadio_ToggleStateChanged);
        }
    }
}
