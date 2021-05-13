using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Performance
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radVirtualGrid1.ColumnCount = 0;
            this.radVirtualGrid1.RowCount = 0;
            this.radVirtualGrid1.AllowFiltering = false;
            this.radVirtualGrid1.AllowAddNewRow = false;

            this.radVirtualGrid1.CellValueNeeded += this.radVirtualGrid1_CellValueNeeded;
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radSpinEditorRowSize.ValueChanged += radSpinEditorRowSize_ValueChanged;
            this.radSpinEditorColumnSize.ValueChanged += radSpinEditorColumnSize_ValueChanged;
            this.radButtonLoad.Click += radButtonLoad_Click;
        }

        private void radButtonLoad_Click(object sender, System.EventArgs e)
        {
            this.radVirtualGrid1.Visible = true;

            this.radButtonLoad.Click -= radButtonLoad_Click;
            this.radButtonLoad.Parent.Controls.Remove(this.radButtonLoad);

            this.radVirtualGrid1.BeginUpdate();

            this.radVirtualGrid1.ColumnCount = 1000;
            this.radVirtualGrid1.RowCount = 1000000;

            this.radVirtualGrid1.EndUpdate();
        }

        private void radSpinEditorColumnSize_ValueChanged(object sender, System.EventArgs e)
        {
            this.radVirtualGrid1.BeginUpdate();

            for (int i = 0; i < this.radVirtualGrid1.ColumnCount; i += 2)
            {
                this.radVirtualGrid1.VirtualGridElement.SetColumnWidth(i, (int)this.radSpinEditorColumnSize.Value);
            }

            this.radVirtualGrid1.EndUpdate();
        }

        private void radSpinEditorRowSize_ValueChanged(object sender, System.EventArgs e)
        {
            this.radVirtualGrid1.BeginUpdate();

            for (int i = 0; i < this.radVirtualGrid1.RowCount; i += 10)
            {
                this.radVirtualGrid1.VirtualGridElement.SetRowHeight(i, (int)this.radSpinEditorRowSize.Value);
            }

            this.radVirtualGrid1.EndUpdate();
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = e.ColumnIndex;
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            e.Value = "" + e.RowIndex + " x " + e.ColumnIndex;
        }
    }
}
