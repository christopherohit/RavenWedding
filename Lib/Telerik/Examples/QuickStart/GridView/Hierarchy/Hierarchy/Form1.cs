using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Hierarchy.Hierarchy
{
	public partial class Form1 : ExamplesForm
	{
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ordersTableAdapter.Fill(nwindDataSet.Orders);
            customersTableAdapter.Fill(nwindDataSet.Customers);
            suppliersTableAdapter.Fill(nwindDataSet.Suppliers);
            productsTableAdapter.Fill(nwindDataSet.Products);
            order_DetailsTableAdapter.Fill(nwindDataSet.Order_Details);
            employeesTableAdapter.Fill(nwindDataSet.Employees);

            this.radRadioManuallyUnbound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;    
        }

        private void OnRadioScenarios_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                return;
            }

            if (this.radRadioHierarchyFromDataSet.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.CreateAutoGenerateHierarchy();
                SetupFiltering(radGridView1.MasterTemplate, true);
            }
            else if (this.radRadioButton2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.CreateBoundHierarchy();
                SetupFiltering(radGridView1.MasterTemplate, true);
            }
            else if (this.radRadioManuallyUnbound.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.CreateUnboundHierarchy();
                SetupFiltering(radGridView1.MasterTemplate, false);
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (radCheckBox1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.UseScrollbarsInHierarchy = true;
            }
            else
            {
                this.radGridView1.UseScrollbarsInHierarchy = false;
            }
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                UpdateChildViewCaptionVisibility(true);
            }
            else
            {
                UpdateChildViewCaptionVisibility(false);
            }
        }

        private void UpdateChildViewCaptionVisibility(bool visible)
        {
            GridViewTemplate template = this.radGridView1.MasterTemplate;
            while (true)
            {
                template.ShowChildViewCaptions = visible;
                if (template.Templates.Count == 0)
                {
                    break;
                }
                template = template.Templates[0];
            }    
        }

        #region Create Hierarchy

        private void CreateAutoGenerateHierarchy()
        {
            using (this.radGridView1.DeferRefresh())
            {
                this.radGridView1.MasterTemplate.Reset();

                this.radGridView1.TableElement.RowHeight = 20;
                this.radGridView1.DataMember = "Customers";
                this.radGridView1.DataSource = nwindDataSet;
                this.radGridView1.AutoGenerateHierarchy = true;
                this.SetupMasterForAutoGenerateHierarchy();
            }
        }

        private void CreateBoundHierarchy()
        {            
            using (this.radGridView1.DeferRefresh())
            {
                this.radGridView1.MasterTemplate.Reset();

                this.radGridView1.TableElement.RowHeight = 20;
                this.radGridView1.DataSource = nwindDataSet.Suppliers;
                this.radGridView1.MasterTemplate.Columns["CompanyName"].HeaderText = "Company Name";
                this.radGridView1.MasterTemplate.Columns["ContactName"].HeaderText = "Contact Name";
                this.radGridView1.MasterTemplate.Columns["SupplierID"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["Fax"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["ContactTitle"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["Region"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["City"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["PostalCode"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["HomePage"].IsVisible = false;
                this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

                GridViewTemplate template = new GridViewTemplate();
                template.DataSource = nwindDataSet.Products;
                this.radGridView1.Templates.Add(template);
                template.Columns["ProductName"].HeaderText = "Product Name";
                template.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
                template.Columns["QuantityPerUnit"].TextAlignment = ContentAlignment.MiddleCenter;
                template.Columns["UnitPrice"].HeaderText = "Unit Price";
                template.Columns["UnitPrice"].FormatString = "${0:F2}";
                template.Columns["ProductID"].IsVisible = false;
                template.Columns["SupplierID"].IsVisible = false;
                template.Columns["CategoryID"].IsVisible = false;
                template.Columns["UnitsInStock"].IsVisible = false;
                template.Columns["UnitsOnOrder"].IsVisible = false;
                template.Columns["ReorderLevel"].IsVisible = false;
                template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

                GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate, template);
                relation.RelationName = "SuppliersProducts";
                relation.ParentColumnNames.Add("SupplierID");
                relation.ChildColumnNames.Add("SupplierID");
                this.radGridView1.Relations.Add(relation);
            }
        }

        private void CreateUnboundHierarchy()
        {
            using (this.radGridView1.DeferRefresh())
            {
                this.radGridView1.MasterTemplate.Reset();

                SetupMasterForUnbound();

                GridViewTemplate template = SetupChildForUnbound();
                GridViewRelation relation = new GridViewRelation(this.radGridView1.MasterTemplate, template);
                relation.RelationName = "EmployeesOrders";
                relation.ParentColumnNames.Add("Name");
                relation.ChildColumnNames.Add("Name");
                radGridView1.Relations.Add(relation);
            }

            this.radGridView1.ChildRows[0].IsExpanded = true;
        }

        #endregion

        #region Setup Templates

        private void SetupFiltering(GridViewTemplate template, bool enableFiltering)
        {
            template.EnableFiltering = enableFiltering;

            for (int i = 0; i < template.Templates.Count; i++)
            {
                SetupFiltering(template.Templates[i], enableFiltering);
            }
        }

        private void SetupMasterForAutoGenerateHierarchy()
        {
            this.radGridView1.MasterTemplate.Columns["CompanyName"].HeaderText = "Company Name";
            this.radGridView1.MasterTemplate.Columns["ContactName"].HeaderText = "Contact Name";
            this.radGridView1.MasterTemplate.Columns["CustomerID"].IsVisible = false;
            this.radGridView1.MasterTemplate.Columns["ContactTitle"].IsVisible = false;
            this.radGridView1.MasterTemplate.Columns["Region"].IsVisible = false;
            this.radGridView1.MasterTemplate.Columns["PostalCode"].IsVisible = false;
            this.radGridView1.MasterTemplate.Columns["Country"].IsVisible = false;
            this.radGridView1.MasterTemplate.Columns["Fax"].IsVisible = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewTemplate template = this.radGridView1.MasterTemplate.Templates[0];
            template.Columns["OrderID"].HeaderText = "Order ID";
            template.Columns["ShipAddress"].HeaderText = "Ship Address";
            template.Columns["OrderDate"].HeaderText = "Order Date";
            template.Columns["OrderDate"].TextAlignment = ContentAlignment.MiddleRight;
            template.Columns["OrderDate"].FormatString = "{0: ddd, MM/dd}";
            template.Columns["CustomerID"].IsVisible = false;
            template.Columns["EmployeeID"].IsVisible = false;
            template.Columns["RequiredDate"].IsVisible = false;
            template.Columns["ShippedDate"].IsVisible = false;
            template.Columns["ShipVia"].IsVisible = false;
            template.Columns["ShipName"].IsVisible = false;
            template.Columns["ShipCity"].IsVisible = false;
            template.Columns["ShipRegion"].IsVisible = false;
            template.Columns["ShipPostalCode"].IsVisible = false;
            template.Columns["ShipCity"].IsVisible = false;
            template.Columns["ShipName"].IsVisible = false;
            template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            template = this.radGridView1.MasterTemplate.Templates[0].Templates[0];
            template.Columns["UnitPrice"].FormatString = "${0:F2}";
            template.Columns["Discount"].FormatString = "{0:0.00%;0.00%;none}";
            template.Columns["ProductID"].IsVisible = false;
            template.Columns["OrderID"].HeaderText = "Order ID";
            template.Columns["UnitPrice"].HeaderText = "Unit Price";
            template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private GridViewTemplate SetupChildForUnbound()
        {
            GridViewTemplate template = new GridViewTemplate();
            template.AllowAddNewRow = true;

            GridViewTextBoxColumn textBoxColumn = new GridViewTextBoxColumn("Name");
            textBoxColumn.HeaderText = "Name";
            template.Columns.Add(textBoxColumn);

            GridViewDecimalColumn productNumberColumn = new GridViewDecimalColumn("Product Number");
            productNumberColumn.HeaderText = "Product Number";
            productNumberColumn.DecimalPlaces = 0;
            productNumberColumn.FormatString = "#{0}";
            template.Columns.Add(productNumberColumn);

            GridViewDecimalColumn decimalChildColumn1 = new GridViewDecimalColumn("Quantity");
            decimalChildColumn1.HeaderText = "Quantity";
            template.Columns.Add(decimalChildColumn1);

            GridViewDecimalColumn decimalChildColumn2 = new GridViewDecimalColumn("Discount");
            decimalChildColumn2.HeaderText = "Discount";
            decimalChildColumn2.FormatString = "{0:F2}%";
            template.Columns.Add(decimalChildColumn2);

            GridViewDecimalColumn decimalChildColumn3 = new GridViewDecimalColumn("Total");
            decimalChildColumn3.HeaderText = "Total";
            decimalChildColumn3.FormatString = "${0}";
            template.Columns.Add(decimalChildColumn3);
            this.radGridView1.Templates.Add(template);

            LoadDataForUnbound();
            template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            return template;
        }

        private void SetupMasterForUnbound()
        {
            this.radGridView1.TableElement.RowHeight = 60;

            GridViewImageColumn column = new GridViewImageColumn("Photo");
            column.ImageLayout = ImageLayout.Zoom;
            column.HeaderText = "Photo";
            this.radGridView1.MasterTemplate.Columns.Add(column);

            GridViewTextBoxColumn textColumn1 = new GridViewTextBoxColumn("Name");
            textColumn1.Width = 150;
            textColumn1.HeaderText = "Name";
            this.radGridView1.MasterTemplate.Columns.Add(textColumn1);

            GridViewDecimalColumn decimalColumn = new GridViewDecimalColumn("Salary");
            decimalColumn.HeaderText = "Salary";
            decimalColumn.FormatString = "${0:#,###}";
            this.radGridView1.MasterTemplate.Columns.Add(decimalColumn);

            GridViewDateTimeColumn dateTimeColumn = new GridViewDateTimeColumn("Hire Date");
            dateTimeColumn.Width = 100;
            dateTimeColumn.TextAlignment = ContentAlignment.MiddleRight;
            dateTimeColumn.HeaderText = "Hire Date";
            this.radGridView1.MasterTemplate.Columns.Add(dateTimeColumn);

            GridViewTextBoxColumn textColumn2 = new GridViewTextBoxColumn("Title");
            textColumn2.Width = 150;
            textColumn2.HeaderText = "Title";
            this.radGridView1.MasterTemplate.Columns.Add(textColumn2);

            this.radGridView1.MasterTemplate.Columns.Add(new GridViewCheckBoxColumn("Active"));
        }

        private void LoadDataForUnbound()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            GridViewTemplate template = this.radGridView1.MasterTemplate.Templates[0];

            for (int i = 0; i < nwindDataSet.Employees.Count; i++)
            {
                Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow row = nwindDataSet.Employees[i];
                string name = row.FirstName + " " + row.LastName;

                this.radGridView1.MasterTemplate.Rows.Add(GetImageFromBytes(row.Photo), name, random.Next(45000),
                    row.HireDate, row.Title, (random.Next(100) > 50));

                int rowCount = random.Next(20);
                while (rowCount <= 0)
                {
                    rowCount = random.Next(20);
                }

                for (int j = 0; j < rowCount; j++)
                {                   
                    template.Rows.Add(name, random.Next(1000), random.Next(50), random.Next(100), random.Next(10000));
                }
            }
        }

        private Image GetImageFromBytes(byte[] bytes)
        {
            Image result = null;
            MemoryStream stream = null;

            try
            {
                stream = new MemoryStream(bytes, 78, bytes.Length - 78);
                result = Image.FromStream(stream);
            }
            catch
            {
                try
                {
                    stream = new MemoryStream(bytes, 0, bytes.Length);
                    result = Image.FromStream(stream);
                }
                catch
                {
                    result = null;
                }
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return result;
        }

        #endregion

        protected override void WireEvents()
        {
            this.radRadioHierarchyFromDataSet.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioScenarios_ToggleStateChanged);
            this.radRadioManuallyUnbound.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioScenarios_ToggleStateChanged);
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioScenarios_ToggleStateChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox2_ToggleStateChanged);
        }
    }
}
