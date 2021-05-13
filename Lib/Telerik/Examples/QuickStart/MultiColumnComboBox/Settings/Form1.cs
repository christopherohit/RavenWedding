using System;
using System.Drawing;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.Examples.WinControls.DataSources;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Telerik.Examples.WinControls.Editors;

namespace Telerik.Examples.WinControls.MultiColumnComboBox.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        RadMultiColumnComboBoxSelectionExtender extender = new RadMultiColumnComboBoxSelectionExtender();

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radMultiColumnComboBox1;
            this.radMultiColumnComboBox1.AutoSizeDropDownToBestFit = true;

            RadMultiColumnComboBoxElement multiColumnComboElement = this.radMultiColumnComboBox1.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.DropDownMinSize = new Size(420, 300);

            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;

            GridViewTextBoxColumn column = new GridViewTextBoxColumn("CustomerID");
            column.HeaderText = "Customer ID";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("ContactName");
            column.HeaderText = "Contact Name";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("ContactTitle");
            column.HeaderText = "Contact Title";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Country");
            column.HeaderText = "Country";
            multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Phone");
            column.HeaderText = "Phone";
            multiColumnComboElement.Columns.Add(column);

            this.radMultiColumnComboBox1.MultiColumnComboBoxElement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;

        }

        void OnTextBoxItem_Click(object sender, EventArgs e)
        {
            this.radMultiColumnComboBox1.MultiColumnComboBoxElement.ShowPopup();
        }

        protected override void WireEvents()
        {
            this.radCheckRotate.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckRotate_ToggleStateChanged);
            this.radCheckRTL.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckBoxRTL_ToggleStateChanged);
            this.radMultipleSelectionCheckBox.ToggleStateChanged += radMultipleSelectionCheckBox_ToggleStateChanged;
            this.radComboAutoCompl.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboAutoCompl_SelectedIndexChanged);
            this.radComboAutoCompl.SelectedIndex = 3;
        }

        void radMultipleSelectionCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {

            if (this.radMultipleSelectionCheckBox.IsChecked)
            {
                this.radMultiColumnComboBox1.EditorControl.MasterTemplate.Refresh();
                this.extender.AssociatedRadMultiColumnComboBox = this.radMultiColumnComboBox1;
                this.extender.AutoCompleteBoxElement.Text = "ALFKI;ANATR;";
                this.radMultiColumnComboBox1.MultiColumnComboBoxElement.ShowPopup();
                this.radCheckRotate.Enabled = false;
                this.radCheckRTL.Enabled = false;
                this.radComboAutoCompl.Enabled = false;
            }
            else
            {
                this.extender.AssociatedRadMultiColumnComboBox = null;
                this.radMultiColumnComboBox1.Text = string.Empty;
                this.radMultiColumnComboBox1.EditorControl.MasterTemplate.Refresh();
                this.radCheckRotate.Enabled = true;
                this.radCheckRTL.Enabled = true;
                this.radComboAutoCompl.Enabled = true;
            }
        }

        void radComboAutoCompl_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radComboAutoCompl.SelectedIndex)
            {
                case 0:
                    this.radMultiColumnComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
                    break;
                case 1:
                    this.radMultiColumnComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
                    break;
                case 2:
                    this.radMultiColumnComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
                    break;
                case 3:
                    this.radMultiColumnComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    break;
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NorthwindDataSet nwindDataSet = new NorthwindDataSet();
            CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
            customersTableAdapter.Fill(nwindDataSet.Customers);

            this.radMultiColumnComboBox1.DataSource = nwindDataSet.Customers;


            FilterDescriptor descriptor = new FilterDescriptor(this.radMultiColumnComboBox1.DisplayMember, FilterOperator.StartsWith, string.Empty);
            this.radMultiColumnComboBox1.EditorControl.FilterDescriptors.Add(descriptor);
            this.radMultiColumnComboBox1.DropDownStyle = RadDropDownStyle.DropDown;
            // Filtering END
        }

        private void OnCheckBoxRTL_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMultiColumnComboBox1.RightToLeft = this.radCheckRTL.Checked ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
        }

        private void OnCheckRotate_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMultiColumnComboBox1.DblClickRotate = this.radCheckRotate.Checked;
        }
    }

}
