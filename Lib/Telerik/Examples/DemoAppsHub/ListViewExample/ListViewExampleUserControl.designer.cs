namespace DemoAppsHub.ListViewExample
{
    partial class ListViewExampleUserControl
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem10 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem11 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem12 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem13 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem14 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem15 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem16 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem17 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem18 = new Telerik.WinControls.UI.RadListDataItem();
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
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarTextBoxFilter = new Telerik.WinControls.UI.CommandBarTextBox();
            this.carsRatesDataTableTableAdapter = new Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsRatesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sofiaCarRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            this.SuspendLayout();
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
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 20);
            this.radListView1.ItemSize = new System.Drawing.Size(64, 64);
            this.radListView1.Location = new System.Drawing.Point(0, 30);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(919, 462);
            this.radListView1.TabIndex = 0;
            this.radListView1.Text = "radListView1";
            this.radListView1.ValueMember = "CarID";
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.radListView1.VisualItemCreating += new Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(radListView1_VisualItemCreating);
            this.radListView1.BindingCompleted += new System.EventHandler(this.radListView1_BindingCompleted);
            this.radListView1.ItemDataBound += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radListView1_ItemDataBound);
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
            this.radCommandBar1.AutoSize = true;
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(919, 30);
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
            this.commandBarStripElement1.FloatingForm = null;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel1,
            this.commandBarDropDownSort,
            this.commandBarSeparator1,
            this.commandBarLabel2,
            this.commandBarDropDownGroup,
            this.commandBarSeparator2,
            this.commandBarToggleList,
            this.commandBarToggleTiles,
            this.commandBarToggleDetails,
            this.commandBarSeparator3,
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
            this.commandBarLabel1.VisibleInOverflowMenu = true;
            // 
            // commandBarDropDownSort
            // 
            this.commandBarDropDownSort.AccessibleDescription = "None";
            this.commandBarDropDownSort.AccessibleName = "None";
            this.commandBarDropDownSort.DisplayName = "commandBarDropDownList1";
            this.commandBarDropDownSort.DropDownAnimationEnabled = true;
            this.commandBarDropDownSort.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem10.Text = "None";
            radListDataItem10.TextWrap = true;
            radListDataItem11.Text = "Make";
            radListDataItem11.TextWrap = true;
            radListDataItem12.Text = "Model";
            radListDataItem12.TextWrap = true;
            radListDataItem13.Text = "Category";
            radListDataItem13.TextWrap = true;
            radListDataItem14.Text = "Year";
            radListDataItem14.TextWrap = true;
            this.commandBarDropDownSort.Items.Add(radListDataItem10);
            this.commandBarDropDownSort.Items.Add(radListDataItem11);
            this.commandBarDropDownSort.Items.Add(radListDataItem12);
            this.commandBarDropDownSort.Items.Add(radListDataItem13);
            this.commandBarDropDownSort.Items.Add(radListDataItem14);
            this.commandBarDropDownSort.Name = "commandBarDropDownSort";
            this.commandBarDropDownSort.Text = "None";
            this.commandBarDropDownSort.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownSort.VisibleInOverflowMenu = true;
            this.commandBarDropDownSort.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownSort_SelectedIndexChanged);
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
            this.commandBarLabel2.VisibleInOverflowMenu = true;
            // 
            // commandBarDropDownGroup
            // 
            this.commandBarDropDownGroup.DisplayName = "commandBarDropDownList2";
            this.commandBarDropDownGroup.DropDownAnimationEnabled = true;
            this.commandBarDropDownGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem15.Text = "None";
            radListDataItem15.TextWrap = true;
            radListDataItem16.Text = "Make";
            radListDataItem16.TextWrap = true;
            radListDataItem17.Text = "Category";
            radListDataItem17.TextWrap = true;
            radListDataItem18.Text = "Year";
            radListDataItem18.TextWrap = true;
            this.commandBarDropDownGroup.Items.Add(radListDataItem15);
            this.commandBarDropDownGroup.Items.Add(radListDataItem16);
            this.commandBarDropDownGroup.Items.Add(radListDataItem17);
            this.commandBarDropDownGroup.Items.Add(radListDataItem18);
            this.commandBarDropDownGroup.Name = "commandBarDropDownGroup";
            this.commandBarDropDownGroup.Text = "";
            this.commandBarDropDownGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarDropDownGroup.VisibleInOverflowMenu = true;
            this.commandBarDropDownGroup.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.commandBarDropDownGroup_SelectedIndexChanged);
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
            this.commandBarToggleList.Image = global::DemoAppsHub.Properties.Resources.tiles_icon;
            this.commandBarToggleList.Name = "commandBarToggleList";
            this.commandBarToggleList.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commandBarToggleList.Text = "commandBarToggleButton1";
            this.commandBarToggleList.ToolTipText = "ListView";
            this.commandBarToggleList.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleList.VisibleInOverflowMenu = true;
            this.commandBarToggleList.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.viewToggleButton_ToggleStateChanging);
            this.commandBarToggleList.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.viewToggleButton_ToggleStateChanged);
            // 
            // commandBarToggleTiles
            // 
            this.commandBarToggleTiles.AccessibleDescription = "commandBarToggleButton2";
            this.commandBarToggleTiles.AccessibleName = "commandBarToggleButton2";
            this.commandBarToggleTiles.DisplayName = "commandBarToggleButton2";
            this.commandBarToggleTiles.Image = global::DemoAppsHub.Properties.Resources.list_icon;
            this.commandBarToggleTiles.Name = "commandBarToggleTiles";
            this.commandBarToggleTiles.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commandBarToggleTiles.Text = "commandBarToggleButton2";
            this.commandBarToggleTiles.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.commandBarToggleTiles.ToolTipText = "IconsView";
            this.commandBarToggleTiles.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleTiles.VisibleInOverflowMenu = true;
            this.commandBarToggleTiles.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.viewToggleButton_ToggleStateChanging);
            this.commandBarToggleTiles.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.viewToggleButton_ToggleStateChanged);
            // 
            // commandBarToggleDetails
            // 
            this.commandBarToggleDetails.AccessibleDescription = "commandBarToggleButton3";
            this.commandBarToggleDetails.AccessibleName = "commandBarToggleButton3";
            this.commandBarToggleDetails.DisplayName = "commandBarToggleButton3";
            this.commandBarToggleDetails.Image = global::DemoAppsHub.Properties.Resources.details_icon;
            this.commandBarToggleDetails.Name = "commandBarToggleDetails";
            this.commandBarToggleDetails.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.commandBarToggleDetails.Text = "commandBarToggleButton3";
            this.commandBarToggleDetails.ToolTipText = "DetailsView";
            this.commandBarToggleDetails.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarToggleDetails.VisibleInOverflowMenu = true;
            this.commandBarToggleDetails.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.viewToggleButton_ToggleStateChanging);
            this.commandBarToggleDetails.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.viewToggleButton_ToggleStateChanged);
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3.DisplayName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarTextBoxFilter
            // 
            this.commandBarTextBoxFilter.DisplayName = "commandBarTextBox1";
            this.commandBarTextBoxFilter.MinSize = new System.Drawing.Size(200, 0);
            this.commandBarTextBoxFilter.Name = "commandBarTextBoxFilter";
            this.commandBarTextBoxFilter.StretchHorizontally = true;
            this.commandBarTextBoxFilter.Text = "";
            this.commandBarTextBoxFilter.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarTextBoxFilter.VisibleInOverflowMenu = true;
            this.commandBarTextBoxFilter.TextChanged += new System.EventHandler(this.commandBarTextBoxFilter_TextChanged);
             
            // 
            // carsRatesDataTableTableAdapter
            // 
            this.carsRatesDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = false;
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(920,600);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsRatesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sofiaCarRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
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
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleList;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleTiles;
        private Telerik.WinControls.UI.CommandBarToggleButton commandBarToggleDetails;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSet sofiaCarRentalDataSet;
        private System.Windows.Forms.BindingSource carsRatesDataTableBindingSource;
        private Telerik.Examples.WinControls.DataSources.SofiaCarRentalDataSetTableAdapters.CarsRatesDataTableTableAdapter carsRatesDataTableTableAdapter;
    }
}