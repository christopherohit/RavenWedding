using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.PinnedItems
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radGridView1;
        }

        #endregion

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.BindGrid();
            this.BindColumnsCombo();
            this.BindSystemRowsPositionCombo();
            this.BindRowsPositionCombo();
            this.BindSystemRowsCombo();
        }

        private void radComboBoxColumns_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            GridViewDataColumn dataColumn = null;

            RadListDataItem radComboBoxItem = this.radComboBoxColumns.SelectedItem as RadListDataItem;
            
            if (radComboBoxItem.Value != null)
            {
                dataColumn = radComboBoxItem.Value as GridViewDataColumn;
            }

            if (dataColumn != null)
            {
                switch(dataColumn.PinPosition)
                {
                    case PinnedColumnPosition.None:
                        this.radRadioButtonColumnPinnedNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                    case PinnedColumnPosition.Left:
                        this.radRadioButtonColumnPinnedLeft.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                    case PinnedColumnPosition.Right:
                        this.radRadioButtonColumnPinnedRight.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                        break;
                }
            }
        }

        private void radRadioButtonColumnPinnedNone_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.SetColumnPinPosition(PinnedColumnPosition.None);
        }

        private void radRadioButtonColumnPinnedLeft_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.SetColumnPinPosition(PinnedColumnPosition.Left);
        }

        private void radRadioButtonColumnPinnedRight_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.SetColumnPinPosition(PinnedColumnPosition.Right);
        }

        private void radComboBoxSystemRows_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem radComboBoxItem = this.radComboBoxSystemRows.SelectedItem as RadListDataItem;

            if (radComboBoxItem == null)
            {
                return;
            }

            GridViewSystemRowInfo systemRow = radComboBoxItem.Value as GridViewSystemRowInfo;

            if (systemRow != null)
            {
                this.radComboBoxRowPinPosition.SelectedValue = systemRow.PinPosition;
                this.radComboBoxSystemRowPosition.SelectedValue = systemRow.RowPosition;
            }
        }

        private void radComboBoxRowPinPosition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem radComboBoxRowPinPositionItem = this.radComboBoxRowPinPosition.SelectedItem as RadListDataItem;

            if (radComboBoxRowPinPositionItem == null)
            {
                return;
            }

            PinnedRowPosition rowPosition = (PinnedRowPosition)radComboBoxRowPinPositionItem.Value;

            RadListDataItem radComboBoxItem = this.radComboBoxSystemRows.SelectedItem as RadListDataItem;

            if (radComboBoxItem == null)
            {
                return;
            }

            GridViewSystemRowInfo systemRow = radComboBoxItem.Value as GridViewSystemRowInfo;

            if (systemRow != null)
            {
                systemRow.PinPosition = rowPosition;

                bool isNone = rowPosition == PinnedRowPosition.None;
                
                this.radLabelSystemRowPosition.Enabled = isNone;
                this.radComboBoxSystemRowPosition.Enabled = isNone;
            }
        }

        private void radComboBoxSystemRowPosition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem radComboBoxSystemRowPositionItem = this.radComboBoxSystemRowPosition.SelectedItem as RadListDataItem;

            if (radComboBoxSystemRowPositionItem == null)
            {
                return;
            }

            SystemRowPosition sysRowPosition = (SystemRowPosition)radComboBoxSystemRowPositionItem.Value;

            RadListDataItem radComboBoxItem = this.radComboBoxSystemRows.SelectedItem as RadListDataItem;

            if (radComboBoxItem == null)
            {
                return;
            }

            GridViewSystemRowInfo systemRow = radComboBoxItem.Value as GridViewSystemRowInfo;

            if (systemRow != null)
            {
                systemRow.RowPosition = sysRowPosition;
            }
        }

        #endregion

        #region Methods

        private void BindGrid()
        {
            this.aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders);
            this.radGridView1.DataSource = this.aggregatesSampleTableBindingSource;

            this.radGridView1.Columns["UnitPrice"].FormatString = "${0:F2}";
            this.radGridView1.Columns["ShipName"].PinPosition = PinnedColumnPosition.Left;
            this.radGridView1.Columns["Quantity"].PinPosition = PinnedColumnPosition.Right;

            foreach (GridViewColumn column in this.radGridView1.Columns)
            {
                column.Width = 120;
            }
        }

        private void BindSystemRowsPositionCombo()
        {
            this.radComboBoxSystemRowPosition.Items.Add(new RadListDataItem("Top", SystemRowPosition.Top));
            this.radComboBoxSystemRowPosition.Items.Add(new RadListDataItem("Bottom", SystemRowPosition.Bottom));
        }

        private void BindRowsPositionCombo()
        {
            this.radComboBoxRowPinPosition.Items.Add(new RadListDataItem("None", PinnedRowPosition.None));
            this.radComboBoxRowPinPosition.Items.Add(new RadListDataItem("Top", PinnedRowPosition.Top));
            this.radComboBoxRowPinPosition.Items.Add(new RadListDataItem("Bottom", PinnedRowPosition.Bottom));
        }

        private void BindSystemRowsCombo()
        {
            this.radComboBoxSystemRows.Items.Add(new RadListDataItem("Table Header", this.radGridView1.MasterView.TableHeaderRow));
            this.radComboBoxSystemRows.Items.Add(new RadListDataItem("Add new row", this.radGridView1.MasterView.TableAddNewRow));

            this.radComboBoxSystemRows.SelectedValue = this.radGridView1.MasterView.SystemRows[0];
        }

        private void BindColumnsCombo()
        {
            foreach (GridViewDataColumn dataColumn in this.radGridView1.Columns)
            {
                this.radComboBoxColumns.Items.Add(new RadListDataItem(dataColumn.Name, dataColumn));
            }

            this.radComboBoxColumns.SelectedValue = this.radGridView1.Columns["ShipName"];
        }

        private void SetColumnPinPosition(PinnedColumnPosition position)
        {
            GridViewDataColumn dataColumn = null;

            RadListDataItem radComboBoxItem = this.radComboBoxColumns.SelectedItem as RadListDataItem;

            if (radComboBoxItem.Value != null)
            {
                dataColumn = radComboBoxItem.Value as GridViewDataColumn;
            }

            if (dataColumn != null)
            {
                dataColumn.PinPosition = position;
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.radRadioButtonColumnPinnedRight.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonColumnPinnedRight_ToggleStateChanged);
            this.radRadioButtonColumnPinnedLeft.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonColumnPinnedLeft_ToggleStateChanged);
            this.radRadioButtonColumnPinnedNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonColumnPinnedNone_ToggleStateChanged);
            this.radComboBoxColumns.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBoxColumns_SelectedIndexChanged);
            this.radComboBoxSystemRows.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBoxSystemRows_SelectedIndexChanged);
            this.radComboBoxRowPinPosition.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBoxRowPinPosition_SelectedIndexChanged);
            this.radComboBoxSystemRowPosition.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBoxSystemRowPosition_SelectedIndexChanged);
        }
    }
}
