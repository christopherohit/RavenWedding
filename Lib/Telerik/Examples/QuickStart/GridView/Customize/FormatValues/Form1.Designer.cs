using Telerik.Examples.WinControls.DataSources;
namespace Telerik.Examples.WinControls.GridView.Customize.FormatValues
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet1 = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButtonAdd = new Telerik.WinControls.UI.RadButton();
            this.order_DetailsTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.order_DetailsTableAdapter1 = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckPrice = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckID = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckPercent = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.nwindDataSet1;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "NwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource1
            // 
            this.orderDetailsBindingSource1.DataMember = "Order Details";
            this.orderDetailsBindingSource1.DataSource = this.nwindDataSet1;
            // 
            // nwindRadGridView
            // 
            this.nwindRadGridView.DataSetName = "NwindRadGridView";
            this.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(13, 35);
            this.radTextBox1.Name = "radTextBox1";
            // 
            // 
            // 
            this.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTextBox1.Size = new System.Drawing.Size(137, 20);
            this.radTextBox1.TabIndex = 6;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.Text = "{0:$#,###0.00}";
            // 
            // radButtonAdd
            // 
            this.radButtonAdd.Location = new System.Drawing.Point(13, 61);
            this.radButtonAdd.Name = "radButtonAdd";
            this.radButtonAdd.Size = new System.Drawing.Size(123, 21);
            this.radButtonAdd.TabIndex = 5;
            this.radButtonAdd.Text = "Apply to All Columns";
           
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "OrderID";
            gridViewDecimalColumn1.HeaderText = "OrderID";
            gridViewDecimalColumn1.Name = "OrderID";
            gridViewDecimalColumn1.Width = 195;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ProductID";
            gridViewDecimalColumn2.HeaderText = "ProductID";
            gridViewDecimalColumn2.Name = "ProductID";
            gridViewDecimalColumn2.Width = 195;
            gridViewDecimalColumn3.DataType = typeof(decimal);
            gridViewDecimalColumn3.FieldName = "UnitPrice";
            gridViewDecimalColumn3.HeaderText = "UnitPrice";
            gridViewDecimalColumn3.Name = "UnitPrice";
            gridViewDecimalColumn3.Width = 195;
            gridViewDecimalColumn4.DataType = typeof(float);
            gridViewDecimalColumn4.FieldName = "Discount";
            gridViewDecimalColumn4.FormatString = "{0: 0.00;0.00;none}";
            gridViewDecimalColumn4.HeaderText = "Discount";
            gridViewDecimalColumn4.Name = "Discount";
            gridViewDecimalColumn4.Width = 196;
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn1);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn2);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn3);
            this.radGridView1.MasterTemplate.Columns.Add(gridViewDecimalColumn4);
            this.radGridView1.MasterTemplate.DataSource = this.orderDetailsBindingSource;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.Size = new System.Drawing.Size(1224, 737);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radCheckPrice);
            this.radGroupBox1.Controls.Add(this.radCheckID);
            this.radGroupBox1.Controls.Add(this.radCheckPercent);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.FooterText = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox1.HeaderText = "Example Formatting";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 98);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "Example Formatting";
            // 
            // radCheckPrice
            // 
            this.radCheckPrice.Location = new System.Drawing.Point(12, 68);
            this.radCheckPrice.Name = "radCheckPrice";
            this.radCheckPrice.Size = new System.Drawing.Size(153, 17);
            this.radCheckPrice.TabIndex = 8;
            this.radCheckPrice.Text = "Apply \'$\' to UnitPrice";

            // 
            // radCheckID
            // 
            this.radCheckID.Location = new System.Drawing.Point(12, 46);
            this.radCheckID.Name = "radCheckID";
            this.radCheckID.Size = new System.Drawing.Size(153, 17);
            this.radCheckID.TabIndex = 8;
            this.radCheckID.Text = "Apply \'#\' to OrderID";

            // 
            // radCheckPercent
            // 
            this.radCheckPercent.Location = new System.Drawing.Point(12, 24);
            this.radCheckPercent.Name = "radCheckPercent";
            this.radCheckPercent.Size = new System.Drawing.Size(153, 17);
            this.radCheckPercent.TabIndex = 8;
            this.radCheckPercent.Text = "Apply \'%\' to Discount";

            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radTextBox1);
            this.radGroupBox2.Controls.Add(this.radButtonAdd);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.FooterText = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox2.HeaderText = "Custom Format String";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 112);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(180, 100);
            this.radGroupBox2.TabIndex = 8;
            this.radGroupBox2.Text = "Custom Format String";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
           
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCheckPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
		private System.Windows.Forms.BindingSource orderDetailsBindingSource;
		private Telerik.WinControls.UI.RadTextBox radTextBox1;
		private Telerik.WinControls.UI.RadButton radButtonAdd;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
		private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
        private NorthwindDataSet nwindDataSet1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckPrice;
        private Telerik.WinControls.UI.RadCheckBox radCheckID;
        private Telerik.WinControls.UI.RadCheckBox radCheckPercent;
    }
}
