using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Telerik.Data;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;


namespace Telerik.Examples.WinControls.GridView.Filtering.ExcelLikeFiltering
{
    public partial class Form1 : ExamplesForm
    {
        private readonly DateTime endDate = DateTime.Today;
        private readonly int range = 730;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.radGridView1.AutoGenerateColumns = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.BeginUpdate();
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;
            this.radGridView1.TableElement.EndUpdate();
            this.radGridView1.FilterPopupRequired += new FilterPopupRequiredEventHandler(radGridView1_FilterPopupRequired);

            foreach (GridViewRowInfo row in this.radGridView1.Rows)
            {
                row.Cells["Date"].Value = GetRandomDate();
            }

            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        void radGridView1_FilterPopupRequired(object sender, FilterPopupRequiredEventArgs e)
        {
            if (this.radRadioButton4.IsChecked)
            {
                e.FilterPopup = new RadSimpleListFilterPopup(e.Column);
            }
            else if (e.Column.Name == "Date")
            {
                if (this.radRadioButton1.IsChecked)
                {
                    return;
                }
                else if (this.radRadioButton2.IsChecked)
                {
                    e.FilterPopup = new RadListFilterPopup(e.Column);
                }
                else if (this.radRadioButton3.IsChecked)
                {
                    e.FilterPopup = new RadListFilterPopup(e.Column, true);
                }
            }
        }

        private DateTime GetRandomDate()
        {
            return this.endDate.AddDays(-this.random.Next(range));
        }

        protected override void WireEvents()
        {
        }
    }
}
