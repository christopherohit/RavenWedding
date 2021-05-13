using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ListView.AutoSizeColumnsMode
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;
        }

        void RadListView1_CellFormatting(object sender, ListViewCellFormattingEventArgs e)
        {
            if (e.CellElement is DetailListViewHeaderCellElement)
            {
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local);
            }
        }

        private void RadButtonBestFitColumns_Click(object sender, EventArgs e)
        {
            DetailListViewElement detailView = this.radListView1.ListViewElement.ViewElement as DetailListViewElement;

            if (detailView != null)
            {
                detailView.BestFitColumns(ListViewBestFitColumnMode.AllCells);
            }
        }

        private void RadRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.AutoSizeColumnsMode = this.radRadioButton1.IsChecked ? ListViewAutoSizeColumnsMode.Fill : ListViewAutoSizeColumnsMode.None;
            if (this.radListView1.AutoSizeColumnsMode == ListViewAutoSizeColumnsMode.None)
            {
                foreach (ListViewDetailColumn column in this.radListView1.Columns)
                {
                    column.Width = 50f;
                }
            }

            this.radListView1.ListViewElement.InvalidateMeasure(true);
        }
    }
}