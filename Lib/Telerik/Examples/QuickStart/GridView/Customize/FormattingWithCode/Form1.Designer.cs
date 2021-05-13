namespace Telerik.Examples.WinControls.GridView.Customize.FormattingWithCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.employeeOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.employeeOrdersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonBackColor = new Telerik.WinControls.UI.RadButton();
            this.radButtonForeColor = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorLess = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorGreater = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorLess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorGreater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(726, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 774);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // employeeOrdersBindingSource
            // 
            this.employeeOrdersBindingSource.DataMember = "EmployeeOrders";
            this.employeeOrdersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeOrdersTableAdapter
            // 
            this.employeeOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radButtonBackColor);
            this.radGroupBox1.Controls.Add(this.radButtonForeColor);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radSpinEditorLess);
            this.radGroupBox1.Controls.Add(this.radSpinEditorGreater);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Set Quantity Condition:";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 56);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 320);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Set Quantity Condition:";
            // 
            // radButtonBackColor
            // 
            this.radButtonBackColor.Location = new System.Drawing.Point(103, 180);
            this.radButtonBackColor.Name = "radButtonBackColor";
            this.radButtonBackColor.Size = new System.Drawing.Size(64, 25);
            this.radButtonBackColor.TabIndex = 9;
        
            // 
            // radButtonForeColor
            // 
            this.radButtonForeColor.Location = new System.Drawing.Point(103, 140);
            this.radButtonForeColor.Name = "radButtonForeColor";
            this.radButtonForeColor.Size = new System.Drawing.Size(64, 25);
            this.radButtonForeColor.TabIndex = 8;
         
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(13, 180);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(60, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Back color:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 140);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(59, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Fore color:";
            // 
            // radSpinEditorLess
            // 
            this.radSpinEditorLess.Location = new System.Drawing.Point(13, 99);
            this.radSpinEditorLess.Name = "radSpinEditorLess";
            // 
            // 
            // 
            this.radSpinEditorLess.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorLess.ShowBorder = true;
            this.radSpinEditorLess.Size = new System.Drawing.Size(154, 20);
            this.radSpinEditorLess.TabIndex = 3;
            this.radSpinEditorLess.TabStop = false;
            this.radSpinEditorLess.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      
            // 
            // radSpinEditorGreater
            // 
            this.radSpinEditorGreater.Location = new System.Drawing.Point(13, 53);
            this.radSpinEditorGreater.Name = "radSpinEditorGreater";
            // 
            // 
            // 
            this.radSpinEditorGreater.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorGreater.ShowBorder = true;
            this.radSpinEditorGreater.Size = new System.Drawing.Size(154, 20);
            this.radSpinEditorGreater.TabIndex = 2;
            this.radSpinEditorGreater.TabStop = false;

            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 79);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(99, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Less than or equal:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(116, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Greater than or equal:";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            gridViewTextBoxColumn1.FieldName = "LastName";
            gridViewTextBoxColumn1.HeaderText = "LastName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "LastName";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "FirstName";
            gridViewTextBoxColumn2.HeaderText = "FirstName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "Title";
            gridViewTextBoxColumn3.HeaderText = "Title";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Title";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.FieldName = "City";
            gridViewTextBoxColumn4.HeaderText = "City";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "City";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "Country";
            gridViewTextBoxColumn5.HeaderText = "Country";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Country";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.FieldName = "ShipName";
            gridViewTextBoxColumn6.HeaderText = "ShipName";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ShipName";
            gridViewTextBoxColumn6.Width = 120;
            gridViewDecimalColumn1.DataType = typeof(short);
            gridViewDecimalColumn1.FieldName = "Quantity";
            gridViewDecimalColumn1.HeaderText = "Quantity";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Quantity";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.employeeOrdersBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(927, 776);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(927, 776);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorLess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorGreater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeeOrdersBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter employeeOrdersTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorLess;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorGreater;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButtonBackColor;
        private Telerik.WinControls.UI.RadButton radButtonForeColor;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
