using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.Diagnostics;
using System.IO;
using Telerik.WinControls.UI;
using System.Threading;
using Telerik.WinControls;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.ListControl.DataBinding
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

            this.SelectedControl = this.radListBoxDemo;
		}

        protected override void OnLoad(EventArgs e)
        {
            this.BindToArray();
            this.radRadioArray.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            base.OnLoad(e);
        }

        private void UnboundMode()
        {
            this.radListBoxDemo.DataSource = null;
            this.radListBoxDemo.Items.Clear();
            this.radListBoxDemo.Items.AddRange(this.CreateListBoxItems());
            //this.radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
        }

        private RadListDataItem[] CreateListBoxItems()
        {
            RadListDataItem[] result = new RadListDataItem[10];

            result[0] = new RadListDataItem("Belgium");
            result[0].Image = Resources.BE;
            result[0].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[1] = new RadListDataItem("Germany");
            result[1].Image = Resources.DE;
            result[1].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[2] = new RadListDataItem("India");
            result[2].Image = Resources.IN;
            result[2].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[3] = new RadListDataItem("France");
            result[3].Image = Resources.FR;
            result[3].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[4] = new RadListDataItem("USA");
            result[4].Image = Resources.US;
            result[4].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[5] = new RadListDataItem("Russia");
            result[5].Image = Resources.RU;
            result[5].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[6] = new RadListDataItem("Japan");
            result[6].Image = Resources.JP;
            result[6].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[7] = new RadListDataItem("China");
            result[7].Image = Resources.CN;
            result[7].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[8] = new RadListDataItem("Bulgaria");
            result[8].Image = Resources.BUL;
            result[8].TextImageRelation = TextImageRelation.ImageBeforeText;

            result[9] = new RadListDataItem("Switzerland");
            result[9].Image = Resources.CH;
            result[9].TextImageRelation = TextImageRelation.ImageBeforeText;

            return result;
        }

        private void DataTable()
        {
            this.radListBoxDemo.DataSource = null;
            this.radListBoxDemo.Items.Clear();
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DataTable dt = this.FillFilesTable(myDocumentsPath);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(string.Format("No files found in \"{0}\" ", myDocumentsPath),
                    "No data in the table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.radListBoxDemo.DisplayMember = "FileName";
            this.radListBoxDemo.ValueMember = "Length";
            this.radListBoxDemo.DataSource = dt;
        }

        private void Database()
        {
            this.LoadData();
            this.radListBoxDemo.DataSource = null;
            this.radListBoxDemo.Items.Clear();
            this.radListBoxDemo.DisplayMember = "FirstName";
            this.radListBoxDemo.ValueMember = "EmployeeID";
            this.radListBoxDemo.DataSource = this.nwindDataSet.Employees;
            this.radListBoxDemo.SelectedIndex = -1;
        }



        private void BindToArray()
        {
            Process[] processes = Process.GetProcesses();

            this.radListBoxDemo.DataSource = null;
            this.radListBoxDemo.Items.Clear();
            this.radListBoxDemo.DisplayMember = "ProcessName";
            this.radListBoxDemo.DataSource = processes;
        }

		private DataTable FillFilesTable(string path)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("FileName", typeof(string));
			dt.Columns.Add("Length", typeof(long));
			dt.Columns.Add("IsReadOnly", typeof(bool));
			dt.Columns.Add("LastAccessTime", typeof(DateTime));
			foreach (string filePath in Directory.GetFiles(path))
			{
				DataRow dr = dt.NewRow();
				FileInfo fileInfo = new FileInfo(filePath);
				dr["FileName"] = fileInfo.Name;
				dr["Length"] = fileInfo.Length;
				dr["IsReadOnly"] = fileInfo.IsReadOnly;
				dr["LastAccessTime"] = fileInfo.LastAccessTime;
				dt.Rows.Add(dr);
			}
			return dt;
		}


		/// <summary>
		/// Gets a collection of typed Customers. This demonstrates binding to a list of custom objects.
		/// </summary>
		/// <returns>Return a typed list of Customer objects</returns>
		/// <remarks>You could use List(Of T) as well.  BindingList(Of T) provides additional events that may be useful</remarks>
		private BindingList<Customer> GetCustomerList()
		{
			BindingList<Customer> customerList = new BindingList<Customer>();
			customerList.Add(new Customer(1, "Alfreds Futterkiste"));
			customerList.Add(new Customer(2, "Ana Trujillo Emparedados y helados"));
			customerList.Add(new Customer(3, "Antonio Moreno Taquera"));
			customerList.Add(new Customer(4, "Around the Horn"));
			customerList.Add(new Customer(5, "Cactus Comidas para llevar"));
			Customer newCustomer = new Customer();
			newCustomer.Id = 6;
			newCustomer.Name = "Ernst Handel";
			customerList.Add(newCustomer);
			return customerList;
		}

		private void LoadData()
		{
			try
			{
				this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
			}
			catch (Exception exception1)
			{
				string message = "To run this sample, you must have the Northwind database.";
				throw new DataException(message, exception1);
			}
		}

        private void OnRadioOptions_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                return;
            }

            if (this.radRadioArray.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.BindToArray();
            }
            else if (this.radRadioDataTable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.DataTable();
            }
            else if (this.radRadioDB.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.Database();
            }
            else if (this.radRadioUnbound.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.UnboundMode();
            }
        }

        protected override void WireEvents()
        {
            this.radRadioArray.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioOptions_ToggleStateChanged);
            this.radRadioDB.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioOptions_ToggleStateChanged);
            this.radRadioDataTable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioOptions_ToggleStateChanged);
            this.radRadioUnbound.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioOptions_ToggleStateChanged);
        }
	}

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