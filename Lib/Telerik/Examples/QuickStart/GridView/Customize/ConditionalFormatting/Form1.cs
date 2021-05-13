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

namespace Telerik.Examples.WinControls.GridView.Customize.ConditionalFormatting
{
    public partial class Form1 : ExamplesForm
    {
		public Form1()
        {
            InitializeComponent();
			this.SelectedControl = this.radGridView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.BeginUpdate();

            this.radGridView1.TableElement.EnableHotTracking = false;
            this.radGridView1.TableElement.RowHeight = 30;

            this.BindGrid();
            this.SetConditions();
            this.radGridView1.EnableHotTracking = true;

            this.radGridView1.TableElement.EndUpdate(true);
        }

        private void BindGrid()
        {

            //populate and bind the datasource
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.radGridView1.DataSource = customersBindingSource;

            this.radGridView1.Columns.Remove(this.radGridView1.Columns["CustomerID"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["Region"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["Fax"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["CompanyName"]);

            this.radGridView1.Columns["ContactName"].HeaderText = "Last Name";
            this.radGridView1.Columns["ContactName"].HeaderTextAlignment = ContentAlignment.MiddleLeft;

            this.radGridView1.Columns["ContactTitle"].HeaderText = "Contact Title";
            this.radGridView1.Columns["ContactTitle"].HeaderTextAlignment = ContentAlignment.MiddleLeft;

            this.radGridView1.Columns["PostalCode"].HeaderText = "Postal Code";
            this.radGridView1.Columns["PostalCode"].HeaderTextAlignment = ContentAlignment.MiddleLeft;

            this.radGridView1.Columns["Country"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
            this.radGridView1.Columns["City"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
            this.radGridView1.Columns["Phone"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
            this.radGridView1.Columns["Address"].HeaderTextAlignment = ContentAlignment.MiddleLeft;
            
        }

        private void SetConditions()
        {
			//add a couple of sample formatting objects
			ConditionalFormattingObject c1 = new ConditionalFormattingObject("Orange, applied to entire row", ConditionTypes.Equal, "Germany", "", true);
			c1.RowBackColor = Color.FromArgb(255, 209, 140);
            c1.CellBackColor = Color.FromArgb(255, 209, 140);
			c1.RowForeColor = Color.Black;
            c1.CellForeColor = Color.Black;
			radGridView1.Columns["Country"].ConditionalFormattingObjectList.Add(c1);

			ConditionalFormattingObject c2 = new ConditionalFormattingObject("Green, applied to cells only", ConditionTypes.Equal, "France", "", false);
			c2.RowBackColor = Color.FromArgb(219, 251, 91);
            c2.CellBackColor = Color.FromArgb(219, 251, 91);
            c2.RowForeColor = Color.Black;
            c2.CellForeColor = Color.Black;
			radGridView1.Columns["Country"].ConditionalFormattingObjectList.Add(c2);

			//update the grid view for the conditional formatting to take effect
			//radGridView1.TableElement.Update(false);
        }

		void btnOpenCondFormatting_Click(object sender, System.EventArgs e)
		{
            ConditionalFormattingForm cf = new ConditionalFormattingForm(this.radGridView1.MasterTemplate, null);
            cf.Owner = this.FindForm();
            ThemeResolutionService.ApplyThemeToControlTree(cf, this.radGridView1.ThemeName);
            cf.Show();
        }

        protected override void WireEvents()
        {
            this.btnOpenCondFormatting.Click += new System.EventHandler(this.btnOpenCondFormatting_Click);
        }
    }
}
