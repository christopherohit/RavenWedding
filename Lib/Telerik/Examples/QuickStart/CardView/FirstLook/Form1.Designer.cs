namespace Telerik.Examples.WinControls.CardView.FirstLook
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
            this.radCardView1 = new Telerik.WinControls.UI.RadCardView();
            this.cardViewItem1 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem10 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem17 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem14 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewGroupItem1 = new Telerik.WinControls.UI.CardViewGroupItem();
            this.cardViewItem5 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem15 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem3 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem2 = new Telerik.WinControls.UI.CardViewItem();
            this.layoutControlTabbedGroup1 = new Telerik.WinControls.UI.LayoutControlTabbedGroup();
            this.cardViewGroupItem2 = new Telerik.WinControls.UI.CardViewGroupItem();
            this.cardViewItem8 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem9 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem11 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem12 = new Telerik.WinControls.UI.CardViewItem();
            this.layoutControlLabelItem1 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.cardViewGroupItem3 = new Telerik.WinControls.UI.CardViewGroupItem();
            this.cardViewItem13 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem16 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem6 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewGroupItem4 = new Telerik.WinControls.UI.CardViewGroupItem();
            this.cardViewItem4 = new Telerik.WinControls.UI.CardViewItem();
            this.cardViewItem7 = new Telerik.WinControls.UI.CardViewItem();
            this.layoutControlLabelItem2 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1.CardTemplate)).BeginInit();
            this.radCardView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1133, 29);
            // 
            // radCardView1
            // 
            this.radCardView1.AllowEdit = false;
            // 
            // radCardView1Template
            // 
            this.radCardView1.CardTemplate.HiddenItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem1,
            this.cardViewItem10,
            this.cardViewItem17,
            this.cardViewItem14});
            this.radCardView1.CardTemplate.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewGroupItem1});
            this.radCardView1.CardTemplate.Location = new System.Drawing.Point(0, 0);
            this.radCardView1.CardTemplate.Name = "radCardView1Template";
            this.radCardView1.CardTemplate.Size = new System.Drawing.Size(500, 250);
            this.radCardView1.CardTemplate.TabIndex = 0;
            this.radCardView1.DataSource = this.employeesBindingSource;
            this.radCardView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCardView1.ItemSize = new System.Drawing.Size(500, 250);
            this.radCardView1.Location = new System.Drawing.Point(0, 0);
            this.radCardView1.Name = "radCardView1";
            this.radCardView1.Size = new System.Drawing.Size(1501, 907);
            this.radCardView1.TabIndex = 2;
            this.radCardView1.Text = "radCardView1";
            ((Telerik.WinControls.UI.RadCardViewElement)(this.radCardView1.GetChildAt(0))).DrawBorder = false;
            // 
            // cardViewItem1
            // 
            this.cardViewItem1.Bounds = new System.Drawing.Rectangle(0, 0, 175, 26);
            this.cardViewItem1.FieldName = "EmployeeID";
            this.cardViewItem1.Name = "cardViewItem1";
            this.cardViewItem1.Text = "EmployeeID";
            // 
            // cardViewItem10
            // 
            this.cardViewItem10.Bounds = new System.Drawing.Rectangle(263, 0, 129, 322);
            this.cardViewItem10.FieldName = "Region";
            this.cardViewItem10.Name = "cardViewItem10";
            this.cardViewItem10.Text = "Region";
            // 
            // cardViewItem17
            // 
            this.cardViewItem17.Bounds = new System.Drawing.Rectangle(0, 94, 191, 47);
            this.cardViewItem17.FieldName = "ReportsTo";
            this.cardViewItem17.Name = "cardViewItem17";
            this.cardViewItem17.Text = "ReportsTo";
            this.cardViewItem17.TextProportionalSize = 0.3F;
            // 
            // cardViewItem14
            // 
            this.cardViewItem14.Bounds = new System.Drawing.Rectangle(0, 26, 265, 26);
            this.cardViewItem14.FieldName = "Extension";
            this.cardViewItem14.Name = "cardViewItem14";
            this.cardViewItem14.Text = "Extension";
            this.cardViewItem14.TextProportionalSize = 0.3F;
            // 
            // cardViewGroupItem1
            // 
            this.cardViewGroupItem1.Bounds = new System.Drawing.Rectangle(0, 0, 500, 250);
            this.cardViewGroupItem1.FieldName = "LastName";
            this.cardViewGroupItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem5,
            this.cardViewItem15,
            this.cardViewItem3,
            this.cardViewItem2,
            this.layoutControlTabbedGroup1});
            this.cardViewGroupItem1.Name = "cardViewGroupItem1";
            // 
            // cardViewItem5
            // 
            this.cardViewItem5.Bounds = new System.Drawing.Rectangle(198, 0, 26, 26);
            this.cardViewItem5.FieldName = "TitleOfCourtesy";
            this.cardViewItem5.MaxSize = new System.Drawing.Size(26, 0);
            this.cardViewItem5.MinSize = new System.Drawing.Size(26, 26);
            this.cardViewItem5.Name = "cardViewItem5";
            this.cardViewItem5.Text = "TitleOfCourtesy";
            this.cardViewItem5.TextProportionalSize = 0F;
            // 
            // cardViewItem15
            // 
            this.cardViewItem15.Bounds = new System.Drawing.Rectangle(0, 0, 198, 222);
            this.cardViewItem15.FieldName = "Photo";
            this.cardViewItem15.Name = "cardViewItem15";
            this.cardViewItem15.Text = "Photo";
            this.cardViewItem15.TextProportionalSize = 0F;
            // 
            // cardViewItem3
            // 
            this.cardViewItem3.Bounds = new System.Drawing.Rectangle(224, 0, 70, 26);
            this.cardViewItem3.FieldName = "FirstName";
            this.cardViewItem3.MaxSize = new System.Drawing.Size(70, 0);
            this.cardViewItem3.Name = "cardViewItem3";
            this.cardViewItem3.Text = "FirstName";
            this.cardViewItem3.TextProportionalSize = 0F;
            // 
            // cardViewItem2
            // 
            this.cardViewItem2.Bounds = new System.Drawing.Rectangle(294, 0, 198, 26);
            this.cardViewItem2.FieldName = "LastName";
            this.cardViewItem2.Name = "cardViewItem2";
            this.cardViewItem2.Text = "LastName";
            this.cardViewItem2.TextProportionalSize = 0F;
            // 
            // layoutControlTabbedGroup1
            // 
            this.layoutControlTabbedGroup1.Bounds = new System.Drawing.Rectangle(198, 26, 294, 196);
            this.layoutControlTabbedGroup1.ItemGroups.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewGroupItem2,
            this.cardViewGroupItem3,
            this.cardViewGroupItem4});
            this.layoutControlTabbedGroup1.Name = "layoutControlTabbedGroup1";
            this.layoutControlTabbedGroup1.SelectedGroup = this.cardViewGroupItem2;
            // 
            // cardViewGroupItem2
            // 
            this.cardViewGroupItem2.Bounds = new System.Drawing.Rectangle(0, 0, 286, 164);
            this.cardViewGroupItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem8,
            this.cardViewItem9,
            this.cardViewItem11,
            this.cardViewItem12,
            this.layoutControlLabelItem1});
            this.cardViewGroupItem2.Name = "cardViewGroupItem2";
            this.cardViewGroupItem2.Text = "Address";
            // 
            // cardViewItem8
            // 
            this.cardViewItem8.Bounds = new System.Drawing.Rectangle(0, 0, 286, 26);
            this.cardViewItem8.FieldName = "Address";
            this.cardViewItem8.Name = "cardViewItem8";
            this.cardViewItem8.Text = "Address";
            this.cardViewItem8.TextProportionalSize = 0.3F;
            this.cardViewItem8.TextWrap = true;
            // 
            // cardViewItem9
            // 
            this.cardViewItem9.Bounds = new System.Drawing.Rectangle(0, 26, 286, 26);
            this.cardViewItem9.FieldName = "City";
            this.cardViewItem9.Name = "cardViewItem9";
            this.cardViewItem9.Text = "City";
            this.cardViewItem9.TextProportionalSize = 0.3F;
            // 
            // cardViewItem11
            // 
            this.cardViewItem11.Bounds = new System.Drawing.Rectangle(0, 52, 286, 26);
            this.cardViewItem11.FieldName = "PostalCode";
            this.cardViewItem11.Name = "cardViewItem11";
            this.cardViewItem11.Text = "PostalCode";
            this.cardViewItem11.TextProportionalSize = 0.3F;
            // 
            // cardViewItem12
            // 
            this.cardViewItem12.Bounds = new System.Drawing.Rectangle(0, 78, 286, 26);
            this.cardViewItem12.FieldName = "Country";
            this.cardViewItem12.Name = "cardViewItem12";
            this.cardViewItem12.Text = "Country";
            this.cardViewItem12.TextProportionalSize = 0.3F;
            // 
            // layoutControlLabelItem1
            // 
            this.layoutControlLabelItem1.Bounds = new System.Drawing.Rectangle(0, 104, 286, 60);
            this.layoutControlLabelItem1.DrawText = false;
            this.layoutControlLabelItem1.Name = "layoutControlLabelItem1";
            // 
            // cardViewGroupItem3
            // 
            this.cardViewGroupItem3.Bounds = new System.Drawing.Rectangle(0, 0, 164, 172);
            this.cardViewGroupItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem13,
            this.cardViewItem16,
            this.cardViewItem6});
            this.cardViewGroupItem3.Name = "cardViewGroupItem3";
            this.cardViewGroupItem3.Text = "Personal";
            // 
            // cardViewItem13
            // 
            this.cardViewItem13.Bounds = new System.Drawing.Rectangle(0, 0, 156, 26);
            this.cardViewItem13.FieldName = "HomePhone";
            this.cardViewItem13.Name = "cardViewItem13";
            this.cardViewItem13.Text = "HomePhone";
            this.cardViewItem13.TextProportionalSize = 0.3F;
            // 
            // cardViewItem16
            // 
            this.cardViewItem16.Bounds = new System.Drawing.Rectangle(0, 52, 156, 112);
            this.cardViewItem16.FieldName = "Notes";
            this.cardViewItem16.Name = "cardViewItem16";
            this.cardViewItem16.Text = "Notes";
            this.cardViewItem16.TextPosition = Telerik.WinControls.UI.LayoutItemTextPosition.Top;
            this.cardViewItem16.TextProportionalSize = 0.2F;
            this.cardViewItem16.TextWrap = true;
            // 
            // cardViewItem6
            // 
            this.cardViewItem6.Bounds = new System.Drawing.Rectangle(0, 26, 156, 26);
            this.cardViewItem6.FieldName = "BirthDate";
            this.cardViewItem6.Name = "cardViewItem6";
            this.cardViewItem6.Text = "BirthDate";
            this.cardViewItem6.TextProportionalSize = 0.3F;
            // 
            // cardViewGroupItem4
            // 
            this.cardViewGroupItem4.Bounds = new System.Drawing.Rectangle(0, 0, 164, 172);
            this.cardViewGroupItem4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem4,
            this.cardViewItem7,
            this.layoutControlLabelItem2});
            this.cardViewGroupItem4.Name = "cardViewGroupItem4";
            this.cardViewGroupItem4.Text = "Job";
            // 
            // cardViewItem4
            // 
            this.cardViewItem4.Bounds = new System.Drawing.Rectangle(0, 0, 156, 26);
            this.cardViewItem4.FieldName = "Title";
            this.cardViewItem4.Name = "cardViewItem4";
            this.cardViewItem4.Text = "Title";
            this.cardViewItem4.TextProportionalSize = 0.3F;
            // 
            // cardViewItem7
            // 
            this.cardViewItem7.Bounds = new System.Drawing.Rectangle(0, 26, 156, 26);
            this.cardViewItem7.FieldName = "HireDate";
            this.cardViewItem7.Name = "cardViewItem7";
            this.cardViewItem7.Text = "HireDate";
            this.cardViewItem7.TextProportionalSize = 0.3F;
            // 
            // layoutControlLabelItem2
            // 
            this.layoutControlLabelItem2.Bounds = new System.Drawing.Rectangle(0, 52, 156, 112);
            this.layoutControlLabelItem2.DrawText = false;
            this.layoutControlLabelItem2.Name = "layoutControlLabelItem2";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.radCardView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1511, 917);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radCardView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1.CardTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCardView1)).EndInit();
            this.radCardView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCardView radCardView1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Telerik.WinControls.UI.CardViewGroupItem cardViewGroupItem1;
        private Telerik.WinControls.UI.CardViewItem cardViewItem1;
        private Telerik.WinControls.UI.CardViewItem cardViewItem2;
        private Telerik.WinControls.UI.CardViewItem cardViewItem3;
        private Telerik.WinControls.UI.CardViewItem cardViewItem4;
        private Telerik.WinControls.UI.CardViewItem cardViewItem5;
        private Telerik.WinControls.UI.CardViewItem cardViewItem6;
        private Telerik.WinControls.UI.CardViewItem cardViewItem7;
        private Telerik.WinControls.UI.CardViewItem cardViewItem8;
        private Telerik.WinControls.UI.CardViewItem cardViewItem9;
        private Telerik.WinControls.UI.CardViewItem cardViewItem10;
        private Telerik.WinControls.UI.CardViewItem cardViewItem11;
        private Telerik.WinControls.UI.CardViewItem cardViewItem12;
        private Telerik.WinControls.UI.CardViewItem cardViewItem13;
        private Telerik.WinControls.UI.CardViewItem cardViewItem14;
        private Telerik.WinControls.UI.CardViewItem cardViewItem15;
        private Telerik.WinControls.UI.CardViewItem cardViewItem16;
        private Telerik.WinControls.UI.CardViewItem cardViewItem17;
        private Telerik.WinControls.UI.LayoutControlTabbedGroup layoutControlTabbedGroup1;
        private Telerik.WinControls.UI.CardViewGroupItem cardViewGroupItem2;
        private Telerik.WinControls.UI.CardViewGroupItem cardViewGroupItem3;
        private Telerik.WinControls.UI.CardViewGroupItem cardViewGroupItem4;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem2;
    }
}