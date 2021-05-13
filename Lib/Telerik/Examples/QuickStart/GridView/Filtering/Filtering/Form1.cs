using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Data;

namespace Telerik.Examples.WinControls.GridView.Filtering.Filtering
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
			InitializeComponent();

            this.SelectedControl = this.radGridView1;
            
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.Size = new Size(this.radGridView1.Width, 690);
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);

            this.radGridView1.TableElement.EnableHotTracking = false;
            this.radGridView1.TableElement.RowHeight = 80;
            this.radGridView1.TableElement.FilterRowHeight = 40;
            this.radGridView1.TableElement.Text = "No Data to display";
            this.radGridView1.LoadElementTree();

            this.BindGrid();
        }

        private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            RadDateTimeEditor editor = this.radGridView1.ActiveEditor as RadDateTimeEditor;

            if (editor != null)
            {
                ((RadItem)editor.EditorElement).ToolTipText = "Modify the date to filter the rows in the grid";                
                editor.CustomFormat = "MMMM d, yyyy";
            }
        }

        private void BindGrid()
        {
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            
            this.radGridView1.DataSource = this.northwindDataSet.Employees;

            this.radGridView1.TableElement.BeginUpdate();

            this.radGridView1.Columns["EmployeeID"].IsVisible = false;
            this.radGridView1.Columns["Title"].IsVisible = false;
            this.radGridView1.Columns["TitleOfCourtesy"].IsVisible = false;
            this.radGridView1.Columns["BirthDate"].IsVisible = false;
            this.radGridView1.Columns["Address"].IsVisible = false;
            this.radGridView1.Columns["PostalCode"].IsVisible = false;
            this.radGridView1.Columns["Extension"].IsVisible = false;
            this.radGridView1.Columns["ReportsTo"].IsVisible = false;
            this.radGridView1.Columns["Region"].IsVisible = false;
            this.radGridView1.Columns["City"].IsVisible = false;
            this.radGridView1.Columns["Country"].IsVisible = false;

            int columnWidth = 100;
            this.radGridView1.Columns["LastName"].HeaderText = "Last Name";
            this.radGridView1.Columns["LastName"].HeaderTextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns["LastName"].Width = columnWidth;

            this.radGridView1.Columns["FirstName"].HeaderText = "First Name";
            this.radGridView1.Columns["FirstName"].HeaderTextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns["FirstName"].Width = columnWidth;

            columnWidth = 150;
            this.radGridView1.Columns["HireDate"].HeaderText = "Hire Date";
            this.radGridView1.Columns["HireDate"].HeaderTextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns["HireDate"].TextAlignment = ContentAlignment.MiddleRight;
            this.radGridView1.Columns["HireDate"].FormatString = "{0:MMMM d, yyyy}";
            this.radGridView1.Columns["HireDate"].Width = columnWidth;
            
            this.radGridView1.Columns["HomePhone"].HeaderText = "Home Phone";
            this.radGridView1.Columns["HomePhone"].HeaderTextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns["HomePhone"].Width = columnWidth;

            this.radGridView1.Columns["Notes"].HeaderTextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns["Notes"].WrapText = true;
            this.radGridView1.Columns["Notes"].Width = 380;

            this.radGridView1.Columns["Photo"].HeaderTextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns["Photo"].Width = 69;
            this.radGridView1.Columns["Photo"].MinWidth = 69;
            this.radGridView1.Columns["Photo"].MaxWidth = 69;

            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewImageColumn imageColumn = this.radGridView1.Columns["Photo"] as GridViewImageColumn;
            this.radGridView1.Columns.Move(imageColumn.Index, 0);
            imageColumn.ImageLayout = ImageLayout.Zoom;

            this.radGridView1.Columns.Move(this.radGridView1.Columns["FirstName"].Index, 1);
            this.radGridView1.TableElement.EndUpdate();
        }

        protected override void WireEvents()
        {
        }
    }
}
