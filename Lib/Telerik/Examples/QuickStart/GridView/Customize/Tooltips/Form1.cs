using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Customize.Tooltips
{
    public partial class Form1 : ExamplesForm
    {
		public Form1()
        {
            InitializeComponent();
			this.SelectedControl = this.radGridView1;
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);
        }

        void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (this.radGridView1.ActiveEditor is RadItem)
            {
                (this.radGridView1.ActiveEditor as RadItem).StretchVertically = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            this.radGridView1.TableElement.RowHeight = 80;
            this.radGridView1.Columns["HireDate"].FormatString = "{0:dd/MM/yyyy}";
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

            radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            base.OnLoad(e);
        }

        private void radGridView1_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            GridDataCellElement dataCell = sender as GridDataCellElement;
            if (dataCell != null)
            {
                e.ToolTipText = string.Format("Column: {0}, Row: {1}", dataCell.ColumnIndex, dataCell.RowIndex);
            }
        }

        protected override void WireEvents()
        {
            this.radGridView1.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(this.radGridView1_ToolTipTextNeeded);
        }
    }
}
