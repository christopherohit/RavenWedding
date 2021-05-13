namespace Telerik.Examples.WinControls.ListView.FirstLook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem9 = new Telerik.WinControls.UI.RadListDataItem();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.carsRatesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sofiaCarRentalDataSet = new Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSet();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarDropDownSort = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarLabel2 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarDropDownGroup = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarToggleList = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleTiles = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarToggleDetails = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarTextBoxFilter = new Telerik.WinControls.UI.CommandBarTextBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.carsRatesDataTableTableAdapter = new Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter();
            this.commandBarLabel3 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsRatesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sofiaCarRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1032, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // radListView1
            // 
            this.radListView1.DataSource = this.carsRatesDataTableBindingSource;
            this.radListView1.DisplayMember = "Make";
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.EnableColumnSort = true;
            this.radListView1.EnableSorting = true;
            this.radListView1.FullRowSelect = false;
            this.radListView1.GroupIndent = 0;
            this.radListView1.ItemSize = new System.Drawing.Size(64, 64);
            this.radListView1.Location = new System.Drawing.Point(0, 30);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(1449, 858);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            this.radListView1.ValueMember = "CarID";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.radListView1.ColumnCreating += new Telerik.WinControls.UI.ListViewColumnCreatingEventHandler(this.radListView1_ColumnCreating);
            // 
            // carsRatesDataTableBindingSource
            // 
            this.carsRatesDataTableBindingSource.DataMember = "CarsRatesDataTable";
            this.carsRatesDataTableBindingSource.DataSource = this.sofiaCarRentalDataSet;
            // 
            // sofiaCarRentalDataSet
            // 
            this.sofiaCarRentalDataSet.DataSetName = "SofiaCarRentalDataSet";
            this.sofiaCarRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(1449, 30);
            this.radCommandBar1.TabIndex = 4;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisplayName = null;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.EnableDragging = false;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarToggleList,
            this.commandBarToggleTiles,
            this.commandBarToggleDetails,
            this.commandBarSeparator4,
            this.commandBarLabel1,
            this.commandBarDropDownSort,
            this.commandBarSeparator1,
            this.commandBarLabel2,
            this.commandBarDropDownGroup,
            this.commandBarSeparator2,
            this.commandBarLabel3,
            this.commandBarTextBoxFilter});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.StretchHorizontally = true;
            this.commandBarStripElement1.Text = "";
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.AccessibleDescription = "Sort By:";
            this.commandBarLabel1.AccessibleName = "Sort By:";
            this.commandBarLabel1.DisplayName = "commandBarLabel1";
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "Sort By:";
            this.commandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarDropDownSort
            // 
            this.commandBarDropDownSort.AccessibleDescription = "None";
            this.commandBarDropDownSort.AccessibleName = "None";
            this.commandBarDropDownSort.DisplayName = "commandBarDropDownList1";
            this.commandBarDropDownSort.DropDownAnimationEnabled = true;
            this.commandBarDropDownSort.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "None";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Make";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Model";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Category";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Year";
            radListDataItem5.TextWrap = true;
            this.commandBarDropDownSort.Items.Add(radListDataItem1);
            this.commandBarDropDownSort.Items.Add(radListDataItem2);
            this.commandBarDropDownSort.Items.Add(radListDataItem3);
            this.commandBarDropDownSort.Items.Add(radListDataItem4);
            this.commandBarDropDownSort.Items.Add(radListDataItem5);
            this.commandBarDropDownSort.MaxDropDownItems = 0;
            this.commandBarDropDownSort.Name = "commandBarDropDownSort";
            this.commandBarDropDownSort.Text = "None";
            this.commandBarDropDownSort.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarLabel2
            // 
            this.commandBarLabel2.AccessibleDescription = "Group By:";
            this.commandBarLabel2.AccessibleName = "Group By:";
            this.commandBarLabel2.DisplayName = "commandBarLabel2";
            this.commandBarLabel2.Name = "commandBarLabel2";
            this.commandBarLabel2.Text = "Group By:";
            this.commandBarLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarDropDownGroup
            // 
            this.commandBarDropDownGroup.DisplayName = "commandBarDropDownList2";
            this.commandBarDropDownGroup.DropDownAnimationEnabled = true;
            this.commandBarDropDownGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem6.Text = "None";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "Make";
            radListDataItem7.TextWrap = true;
            radListDataItem8.Text = "Category";
            radListDataItem8.TextWrap = true;
            radListDataItem9.Text = "Year";
            radListDataItem9.TextWrap = true;
            this.commandBarDropDownGroup.Items.Add(radListDataItem6);
            this.commandBarDropDownGroup.Items.Add(radListDataItem7);
            this.commandBarDropDownGroup.Items.Add(radListDataItem8);
            this.commandBarDropDownGroup.Items.Add(radListDataItem9);
            this.commandBarDropDownGroup.MaxDropDownItems = 0;
            this.commandBarDropDownGroup.Name = "commandBarDropDownGroup";
            this.commandBarDropDownGroup.Text = "";
            this.commandBarDropDownGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // commandBarToggleList
            // 
            this.commandBarToggleList.AccessibleDescription = "commandBarToggleButton1";
            this.commandBarToggleList.AccessibleName = "commandBarToggleButton1";
            this.commandBarToggleList.DisplayName = "commandBarToggleButton1";
            this.commandBarToggleList.Image = global::Telerik.Examples.WinControls.Properties.Resources.tiles_icon;
            this.commandBarToggleList.Name = "commandBarToggleList";
            this.commandBarToggleList.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commandBarToggleList.Text = "commandBarToggleButton1";
            this.commandBarToggleList.ToolTipText = "ListView";
            this.commandBarToggleList.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarToggleTiles
            // 
            this.commandBarToggleTiles.AccessibleDescription = "commandBarToggleButton2";
            this.commandBarToggleTiles.AccessibleName = "commandBarToggleButton2";
            this.commandBarToggleTiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commandBarToggleTiles.DisplayName = "commandBarToggleButton2";
            this.commandBarToggleTiles.Image = global::Telerik.Examples.WinControls.Properties.Resources.list_icon;
            this.commandBarToggleTiles.Name = "commandBarToggleTiles";
            this.commandBarToggleTiles.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commandBarToggleTiles.Text = "commandBarToggleButton2";
            this.commandBarToggleTiles.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.commandBarToggleTiles.ToolTipText = "IconsView";
            this.commandBarToggleTiles.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarToggleDetails
            // 
            this.commandBarToggleDetails.AccessibleDescription = "commandBarToggleButton3";
            this.commandBarToggleDetails.AccessibleName = "commandBarToggleButton3";
            this.commandBarToggleDetails.DisplayName = "commandBarToggleButton3";
            this.commandBarToggleDetails.Image = global::Telerik.Examples.WinControls.Properties.Resources.details_icon;
            this.commandBarToggleDetails.Name = "commandBarToggleDetails";
            this.commandBarToggleDetails.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commandBarToggleDetails.Text = "commandBarToggleButton3";
            this.commandBarToggleDetails.ToolTipText = "DetailsView";
            this.commandBarToggleDetails.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarTextBoxFilter
            // 
            this.commandBarTextBoxFilter.DisplayName = "commandBarTextBox1";
            this.commandBarTextBoxFilter.MinSize = new System.Drawing.Size(200, 0);
            this.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter";
            this.commandBarTextBoxFilter.StretchHorizontally = true;
            this.commandBarTextBoxFilter.Text = "";
            this.commandBarTextBoxFilter.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radListView1);
            this.radPanel1.Controls.Add(this.radCommandBar1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1449, 888);
            this.radPanel1.TabIndex = 5;
            this.radPanel1.Text = "radPanel1";
            // 
            // carsRatesDataTableTableAdapter
            // 
            this.carsRatesDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // commandBarLabel3
            // 
            this.commandBarLabel3.AccessibleDescription = "Filter:";
            this.commandBarLabel3.AccessibleName = "Filter:";
            this.commandBarLabel3.DisplayName = "commandBarLabel3";
            this.commandBarLabel3.Name = "commandBarLabel3";
            this.commandBarLabel3.Text = "Filter:";
            this.commandBarLabel3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.AccessibleDescription = "commandBarSeparator4";
            this.commandBarSeparator4.AccessibleName = "commandBarSeparator4";
            this.commandBarSeparator4.DisplayName = "commandBarSeparator4";
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.commandBarSeparator4.Text = "";
            this.commandBarSeparator4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1459, 898);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsRatesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sofiaCarRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownSort;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel2;
        private Telerik.WinControls.UI.CommandBarDropDownList commandBarDropDownGroup;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarTextBox commandBarTextBoxFilter;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleList;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleTiles;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleDetails;
        private DataSources.SofiaCarRentalDataSet sofiaCarRentalDataSet;
        private System.Windows.Forms.BindingSource carsRatesDataTableBindingSource;
        private DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter carsRatesDataTableTableAdapter;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator4;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel3;
    }
}