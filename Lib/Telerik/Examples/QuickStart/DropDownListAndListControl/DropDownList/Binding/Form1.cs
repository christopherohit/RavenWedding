using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private Timer showDropDownTimeout;

        public Form1()
        {
            InitializeComponent();            
            this.showDropDownTimeout = new Timer(this.components);
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Interval = 1000;
            
            this.SelectedControl = this.radComboDemo;
        }

        private void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.ShowDropDown();
            this.showDropDownTimeout.Stop();
            this.radComboDemo.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.radRadioArray.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.BindToArray();
            this.showDropDownTimeout.Start();
            base.OnLoad(e);
        }

        #region OLD LOGIC

        private void LoadData()
        {
            try
            {
                employeesTableAdapter2.Fill(this.NorthwindDataSetAccess.Employees);
            }
            catch (Exception exception1)
            {
                string message = "To run this sample, you must have SQL Server with the Northwind database installed.";
                throw new DataException(message, exception1);
            }
        }


        private void UnboundMode()
        {
            this.radComboDemo.DataSource = null;
            this.radComboDemo.Items.Clear();
            Process[] processes = Process.GetProcesses();

            RadListDataItem[] comboItems = new RadListDataItem[processes.Length];
            for (int i = 0; i < processes.Length; ++i)
            {
                comboItems[i] = new RadListDataItem(processes[i].ProcessName);
            }

            this.radComboDemo.Items.AddRange(comboItems);
            this.radComboDemo.SortStyle= Telerik.WinControls.Enumerations.SortStyle.Ascending;
        }

        private void BindToArray()
        {
            this.radComboDemo.DataSource = null;
            this.radComboDemo.Items.Clear();

            DataItem[] result = new DataItem[10];

            result[0] = new DataItem("Belgium", Resources.BE);
            result[1] = new DataItem("Germany", Resources.DE);
            result[2] = new DataItem("India", Resources.IN);
            result[3] = new DataItem("France", Resources.FR);
            result[4] = new DataItem("USA", Resources.US);
            result[5] = new DataItem("Russia", Resources.RU);
            result[6] = new DataItem("Japan", Resources.JP);
            result[7] = new DataItem("China", Resources.CN);
            result[8] = new DataItem("Bulgaria", Resources.BUL);
            result[9] = new DataItem("Switzerland", Resources.CH);

            this.radComboDemo.ItemDataBound += radComboDemo_ItemDataBound;
            this.radComboDemo.DisplayMember = "Text";
            this.radComboDemo.DataSource = result;
            this.radComboDemo.ItemDataBound -= radComboDemo_ItemDataBound;
        }

        private void radComboDemo_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            args.NewItem.Image = ((DataItem)args.NewItem.DataBoundItem).Image;
            args.NewItem.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void BindToDataTable()
        {
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DataTable dt = this.FillFilesTable(myDocumentsPath);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(string.Format("No files found in \"{0}\" ", myDocumentsPath),
                    "No data in the table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.radComboDemo.DataSource = null;
            this.radComboDemo.Items.Clear();
            this.radComboDemo.DataSource = dt;
            this.radComboDemo.DisplayMember = "FileName";
            this.radComboDemo.ValueMember = "Length";
        }


        private void BindToDataSet()
        {
            this.radComboDemo.DataSource = null;
            this.radComboDemo.Items.Clear();
            this.LoadData();
            this.radComboDemo.DataSource = this.NorthwindDataSetAccess.Employees;
            this.radComboDemo.DisplayMember = "LastName";
            this.radComboDemo.ValueMember = "EmployeeID";
            
        }

        private Image GetImageFromData(byte[] imageData)
        {
            const int OleHeaderLength = 78;
            MemoryStream memoryStream = new MemoryStream();
            if (HasOleContainerHeader(imageData))
            {
                memoryStream.Write(imageData, OleHeaderLength, imageData.Length - OleHeaderLength);
            }
            else
            {
                memoryStream.Write(imageData, 0, imageData.Length);
            }
            Bitmap bitmap = new Bitmap(memoryStream);
            return bitmap.GetThumbnailImage(55, 65, null, new IntPtr());
        }

        private bool HasOleContainerHeader(byte[] imageByteArray)
        {
            const byte OleByte0 = 21;
            const byte OleByte1 = 28;
            return (imageByteArray[0] == OleByte0) && (imageByteArray[1] == OleByte1);
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

		private void CustomerBindingSource_AddingNew(object sender, AddingNewEventArgs e)
		{			
			Customer newCustomer = new Customer();
            newCustomer.Id = this.CustomerBindingSource.Count + 1;
			newCustomer.Name = "New customer " + newCustomer.Id.ToString();
			e.NewObject = newCustomer;
        }

        #endregion

        private void OnRadioBinding_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioArray.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.BindToArray();
            }
            else if (this.radRadioDataTable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.BindToDataTable();
            }
            else if (this.radRadioDB.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.BindToDataSet();
            }
            else if (this.radRadioUnbound.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.UnboundMode();
            }
            this.showDropDownTimeout.Start();
        }

        protected override void WireEvents()
        {
            this.CustomerBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.CustomerBindingSource_AddingNew);
            this.radRadioDB.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            this.radRadioArray.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            this.radRadioDataTable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
            this.radRadioUnbound.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioBinding_ToggleStateChanged);
        }
    }

    public class DataItem
    {
        private Image image = null;
        private string text = "";

        public DataItem(string text, Image image)
        {
            this.text = text;
            this.image = image;
        }

        public Image Image
        {
            get
            {
                return this.image;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }
        }
    }
}