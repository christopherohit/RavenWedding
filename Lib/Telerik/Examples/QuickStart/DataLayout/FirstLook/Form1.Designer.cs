namespace Telerik.Examples.WinControls.DataLayout.FirstLook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureDataSet = new Telerik.Examples.WinControls.DataSources.FurnitureDataSet();
            this.productsTableAdapter = new Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter();
            this.radBindingNavigator1 = new Telerik.WinControls.UI.RadBindingNavigator();
            this.radBindingNavigator1RowElement = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radBindingNavigator1FirstStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1MoveFirstItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1MovePreviousItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1PositionItem = new Telerik.WinControls.UI.CommandBarTextBox();
            this.radBindingNavigator1CountItem = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1MoveNextItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1MoveLastItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1SecondStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1AddNewItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1DeleteItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radDataLayout1 = new Telerik.WinControls.UI.RadDataLayout();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButtonCustomize = new Telerik.WinControls.UI.RadButton();
            this.radButtonSaveLayout = new Telerik.WinControls.UI.RadButton();
            this.radButtonLoadLayout = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1.LayoutControl)).BeginInit();
            this.radDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCustomize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSaveLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoadLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(755, 107);
            this.settingsPanel.Size = new System.Drawing.Size(230, 253);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Products";
            this.bindingSource1.DataSource = this.furnitureDataSet;
            // 
            // furnitureDataSet
            // 
            this.furnitureDataSet.DataSetName = "FurnitureDataSet";
            this.furnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // radBindingNavigator1
            // 
            this.radBindingNavigator1.BindingSource = this.bindingSource1;
            this.radBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radBindingNavigator1.Name = "radBindingNavigator1";
            this.radBindingNavigator1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.radBindingNavigator1RowElement});
            this.radBindingNavigator1.Size = new System.Drawing.Size(629, 30);
            this.radBindingNavigator1.TabIndex = 1;
            this.radBindingNavigator1.Text = "radBindingNavigator1";
            // 
            // radBindingNavigator1RowElement
            // 
            this.radBindingNavigator1RowElement.MinSize = new System.Drawing.Size(25, 25);
            this.radBindingNavigator1RowElement.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.radBindingNavigator1FirstStrip,
            this.radBindingNavigator1SecondStrip});
            // 
            // radBindingNavigator1FirstStrip
            // 
            this.radBindingNavigator1FirstStrip.DisplayName = "radBindingNavigator1FirstStrip";
            this.radBindingNavigator1FirstStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1FirstStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1MoveFirstItem,
            this.commandBarSeparator1,
            this.radBindingNavigator1MovePreviousItem,
            this.commandBarSeparator2,
            this.radBindingNavigator1PositionItem,
            this.radBindingNavigator1CountItem,
            this.commandBarSeparator3,
            this.radBindingNavigator1MoveNextItem,
            this.commandBarSeparator4,
            this.radBindingNavigator1MoveLastItem});
            this.radBindingNavigator1FirstStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.radBindingNavigator1FirstStrip.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.radBindingNavigator1FirstStrip.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBindingNavigator1MoveFirstItem
            // 
            this.radBindingNavigator1MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveFirstItem.Image")));
            this.radBindingNavigator1MoveFirstItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem";
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1MovePreviousItem
            // 
            this.radBindingNavigator1MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MovePreviousItem.Image")));
            this.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem";
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1PositionItem
            // 
            this.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem";
            this.radBindingNavigator1PositionItem.Text = "0";
            // 
            // radBindingNavigator1CountItem
            // 
            this.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem";
            this.radBindingNavigator1CountItem.Text = "of 0";
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1MoveNextItem
            // 
            this.radBindingNavigator1MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveNextItem.Image")));
            this.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem";
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1MoveLastItem
            // 
            this.radBindingNavigator1MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveLastItem.Image")));
            this.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem";
            // 
            // radBindingNavigator1SecondStrip
            // 
            this.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip";
            this.radBindingNavigator1SecondStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1SecondStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1AddNewItem,
            this.commandBarSeparator5,
            this.radBindingNavigator1DeleteItem});
            this.radBindingNavigator1SecondStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.radBindingNavigator1SecondStrip.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.radBindingNavigator1SecondStrip.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBindingNavigator1AddNewItem
            // 
            this.radBindingNavigator1AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1AddNewItem.Image")));
            this.radBindingNavigator1AddNewItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem";
            // 
            // commandBarSeparator5
            // 
            this.commandBarSeparator5.Name = "commandBarSeparator5";
            this.commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1DeleteItem
            // 
            this.radBindingNavigator1DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1DeleteItem.Image")));
            this.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem";
            // 
            // radDataLayout1
            // 
            this.radDataLayout1.ColumnCount = 2;
            this.radDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDataLayout1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.radDataLayout1.ItemDefaultHeight = 26;
            // 
            // radDataLayout1.LayoutControl
            // 
            this.radDataLayout1.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDataLayout1.LayoutControl.DrawBorder = false;
            this.radDataLayout1.LayoutControl.Location = new System.Drawing.Point(0, 0);
            this.radDataLayout1.LayoutControl.Name = "LayoutControl";
            this.radDataLayout1.LayoutControl.Size = new System.Drawing.Size(627, 470);
            this.radDataLayout1.LayoutControl.TabIndex = 0;
            this.radDataLayout1.Location = new System.Drawing.Point(0, 30);
            this.radDataLayout1.Name = "radDataLayout1";
            this.radDataLayout1.Size = new System.Drawing.Size(629, 472);
            this.radDataLayout1.TabIndex = 2;
            this.radDataLayout1.Text = "radDataLayout1";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radDataLayout1);
            this.radPanel1.Controls.Add(this.radBindingNavigator1);
            this.radPanel1.Location = new System.Drawing.Point(2, 2);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(629, 502);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.Text = "radPanel1";
            // 
            // radButtonCustomize
            // 
            this.radButtonCustomize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonCustomize.Location = new System.Drawing.Point(5, 30);
            this.radButtonCustomize.Name = "radButtonCustomize";
            this.radButtonCustomize.Size = new System.Drawing.Size(200, 24);
            this.radButtonCustomize.TabIndex = 1;
            this.radButtonCustomize.Text = "Customize ...";
            this.radButtonCustomize.Click += new System.EventHandler(this.radButtonCustomize_Click);
            // 
            // radButtonSaveLayout
            // 
            this.radButtonSaveLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonSaveLayout.Location = new System.Drawing.Point(5, 60);
            this.radButtonSaveLayout.Name = "radButtonSaveLayout";
            this.radButtonSaveLayout.Size = new System.Drawing.Size(200, 24);
            this.radButtonSaveLayout.TabIndex = 2;
            this.radButtonSaveLayout.Text = "Save Layout";
            this.radButtonSaveLayout.Click += new System.EventHandler(this.radButtonSaveLayout_Click);
            // 
            // radButtonLoadLayout
            // 
            this.radButtonLoadLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonLoadLayout.Location = new System.Drawing.Point(5, 90);
            this.radButtonLoadLayout.Name = "radButtonLoadLayout";
            this.radButtonLoadLayout.Size = new System.Drawing.Size(200, 24);
            this.radButtonLoadLayout.TabIndex = 3;
            this.radButtonLoadLayout.Text = "Load Layout";
            this.radButtonLoadLayout.Click += new System.EventHandler(this.radButtonLoadLayout_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radButtonLoadLayout);
            this.radGroupBox1.Controls.Add(this.radButtonCustomize);
            this.radGroupBox1.Controls.Add(this.radButtonSaveLayout);
            this.radGroupBox1.HeaderText = "DataLayout Actions";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 130);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "DataLayout Actions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1483, 917);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1.LayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataLayout1)).EndInit();
            this.radDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCustomize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSaveLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLoadLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSources.FurnitureDataSet furnitureDataSet;
        private DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Telerik.WinControls.UI.RadBindingNavigator radBindingNavigator1;
        private Telerik.WinControls.UI.CommandBarRowElement radBindingNavigator1RowElement;
        private Telerik.WinControls.UI.CommandBarStripElement radBindingNavigator1FirstStrip;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveFirstItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MovePreviousItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarTextBox radBindingNavigator1PositionItem;
        private Telerik.WinControls.UI.CommandBarLabel radBindingNavigator1CountItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveNextItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator4;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveLastItem;
        private Telerik.WinControls.UI.CommandBarStripElement radBindingNavigator1SecondStrip;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1AddNewItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator5;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1DeleteItem;
        private Telerik.WinControls.UI.RadDataLayout radDataLayout1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButtonLoadLayout;
        private Telerik.WinControls.UI.RadButton radButtonCustomize;
        private Telerik.WinControls.UI.RadButton radButtonSaveLayout;
    }
}