using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Grouping.GroupSummaries
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radGridViewDemo.EnableHotTracking = true;
            this.SelectedControl = this.radGridViewDemo;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.radGridViewDemo.ViewCellFormatting += new CellFormattingEventHandler(radGridView1_ViewCellFormatting);
            this.radGridViewDemo.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radGridViewDemo.TableElement.BeginUpdate();

            this.ordersTableAdapter.Fill(this.nwindDataSetGridView.Orders);

            this.radGridViewDemo.Columns["Freight"].FormatString = "{0:F2}";

            this.LoadFreightSummary();

            this.radGridViewDemo.TableElement.EndUpdate();

            InitComboBoxes();

            base.OnLoad(e);
        }

        private void InitComboBoxes()
        {
            this.radComboFunction.DataSource = Enum.GetValues(typeof(GridAggregateFunction));
            List<string> columns = new List<string>();

            for (int i = 1; i < radGridViewDemo.MasterTemplate.Columns.Count; i++)
            {
                columns.Add(radGridViewDemo.MasterTemplate.Columns[i].FieldName);
            }
            this.radComboColumn.DataSource = columns;

            this.radComboFunction.SelectedIndex = 1;
            this.radComboPosition.SelectedIndex = 0;
            this.radComboBox3.SelectedIndex = 0;
            this.radComboColumn.SelectedIndex = 2;
        }

        private static void RebuildComboBoxItems(RadDropDownList comboBox, int count)
        {
            comboBox.BeginUpdate();

            comboBox.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                comboBox.Items.Add(new RadListDataItem(string.Format("Row {0}", i + 1)));
            }

            comboBox.Items.Add(new RadListDataItem("New Row"));

            comboBox.SelectedIndex = count - 1;

            comboBox.EndUpdate();
        }

        private static GridViewSummaryRowItem CollectionItem(GridViewSummaryRowItemCollection collection, int rowIndex, out bool updated)
        {
            updated = false;
            if (collection == null || rowIndex < 0) return null;

            while (rowIndex >= collection.Count)
            {
                updated = true;
                collection.Add(new GridViewSummaryRowItem());
            }

            return collection[rowIndex];
        }

        #region Event handling

        private void radGridView1_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.DrawBorder = true;
                e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders;
                e.CellElement.BorderLeftWidth = 0;
                e.CellElement.BorderRightWidth = 0;
                e.CellElement.BorderBottomWidth = 0;
                e.CellElement.BorderTopWidth = 1;
                e.CellElement.BorderTopColor = Color.Black;
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
            }
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {           
            if (e.CellElement is GridDateTimeCellElement)
            {
                GridDateTimeCellElement dateTimeCell = e.CellElement as GridDateTimeCellElement;
                e.CellElement.Text = String.Format("{0:ddd, MM/dd}", dateTimeCell.Value);
            }
        }

        private void radComboBox2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radComboPosition.SelectedIndex)
            {
                case 0:
                    this.radComboBox3.Enabled = false;
                    break;
                case 1:
                    RebuildComboBoxItems(radComboBox3, this.radGridViewDemo.MasterTemplate.SummaryRowsTop.Count);
                    this.radComboBox3.Enabled = true;
                    break;
                case 2:
                    RebuildComboBoxItems(radComboBox3, this.radGridViewDemo.MasterTemplate.SummaryRowsBottom.Count);
                    this.radComboBox3.Enabled = true;
                    break;
            }
        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            GridViewSummaryRowItem item = null;
            string formatString = string.Empty;
            bool updated = false;

            switch (this.radComboPosition.SelectedIndex)
            {
                case 0:
                    item = CollectionItem(
                        this.radGridViewDemo.MasterTemplate.SummaryRowGroupHeaders,
                        0, out updated);

                    formatString = string.Format("{2} of {0}: {1}; ",
                        radComboColumn.SelectedItem.Text, "{0}",
                        (GridAggregateFunction)radComboFunction.SelectedIndex);
                    break;

                case 1:
                    item = CollectionItem(
                        this.radGridViewDemo.MasterTemplate.SummaryRowsTop,
                        this.radComboBox3.SelectedIndex,
                        out updated
                        );

                    if (updated)
                        RebuildComboBoxItems(this.radComboBox3, this.radGridViewDemo.MasterTemplate.SummaryRowsTop.Count);

                    formatString = string.Format("{0}: {1}; ",
                        (GridAggregateFunction)radComboFunction.SelectedIndex, "{0}");
                    break;

                case 2:
                    item = CollectionItem(
                        this.radGridViewDemo.MasterTemplate.SummaryRowsBottom,
                        this.radComboBox3.SelectedIndex,
                        out updated
                        );

                    if (updated)
                        RebuildComboBoxItems(this.radComboBox3, this.radGridViewDemo.MasterTemplate.SummaryRowsBottom.Count);

                    formatString = string.Format("{0}: {1}; ",
                        (GridAggregateFunction)radComboFunction.SelectedIndex, "{0}");
                    break;
            }

            if (item == null)
                return;

            string fieldName = radComboColumn.SelectedItem.Text;

            item.Add(new GridViewSummaryItem(
                fieldName,
                formatString,
                (GridAggregateFunction)radComboFunction.SelectedIndex
                ));
        }

        #endregion

        private void LoadFreightSummary()
        {
            this.radGridViewDemo.MasterTemplate.AutoExpandGroups = true;
            this.radGridViewDemo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            this.radGridViewDemo.GroupDescriptors.Clear();
            this.radGridViewDemo.GroupDescriptors.Add(new GridGroupByExpression("CustomerID Group By CustomerID"));

            GridViewSummaryRowItem item1 = new GridViewSummaryRowItem();

            item1.Add(new GridViewSummaryItem("Freight", "Sum: {0:F2}; ", GridAggregateFunction.Sum));

            this.radGridViewDemo.MasterTemplate.SummaryRowsBottom.Add(item1);

            GridViewSummaryRowItem item2 = new GridViewSummaryRowItem();

            item2.Add(new GridViewSummaryItem("Freight", "Min: {0:F2}", GridAggregateFunction.Min));
            this.radGridViewDemo.MasterTemplate.SummaryRowsTop.Add(item2);
        }

        private void radCheckBoxPinRow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (radCheckBoxPinRow.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radGridViewDemo.MasterTemplate.ShowTotals = true;
            }
            else
            {
                radGridViewDemo.MasterTemplate.ShowTotals = false;
            }
        }

        protected override void WireEvents()
        {
            this.radComboPosition.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox2_SelectedIndexChanged);
            this.radButtonAddSummary.Click += new System.EventHandler(this.radButton1_Click);
            this.radCheckBoxPinRow.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxPinRow_ToggleStateChanged);
        }
    }
}
