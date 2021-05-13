namespace Telerik.Examples.WinControls.GridView.PinnedItems
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBoxColumns = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButtonColumnPinnedRight = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonColumnPinnedLeft = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonColumnPinnedNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radComboBoxColumns = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBoxSysRows = new Telerik.WinControls.UI.RadGroupBox();
            this.radComboBoxSystemRows = new Telerik.WinControls.UI.RadDropDownList();
            this.aggregatesSampleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.aggregatesSampleTableTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter();
            this.radLabelRowPinPosition = new Telerik.WinControls.UI.RadLabel();
            this.radComboBoxRowPinPosition = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelSystemRowPosition = new Telerik.WinControls.UI.RadLabel();
            this.radComboBoxSystemRowPosition = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxColumns)).BeginInit();
            this.radGroupBoxColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnPinnedRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnPinnedLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnPinnedNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSysRows)).BeginInit();
            this.radGroupBoxSysRows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSystemRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatesSampleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowPinPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxRowPinPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSystemRowPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSystemRowPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxColumns);
            this.settingsPanel.Controls.Add(this.radGroupBoxSysRows);
            this.settingsPanel.Location = new System.Drawing.Point(738, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 723);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxSysRows, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxColumns, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.CurrentColumn = null;
            this.radGridView1.MasterTemplate.CurrentRow = null;
            this.radGridView1.MasterTemplate.VirtualMode = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowNoDataText = false;
            this.radGridView1.Size = new System.Drawing.Size(939, 725);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGroupBoxColumns
            // 
            this.radGroupBoxColumns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxColumns.Controls.Add(this.radRadioButtonColumnPinnedRight);
            this.radGroupBoxColumns.Controls.Add(this.radRadioButtonColumnPinnedLeft);
            this.radGroupBoxColumns.Controls.Add(this.radRadioButtonColumnPinnedNone);
            this.radGroupBoxColumns.Controls.Add(this.radComboBoxColumns);
            this.radGroupBoxColumns.FooterImageIndex = -1;
            this.radGroupBoxColumns.FooterImageKey = "";
            this.radGroupBoxColumns.HeaderImageIndex = -1;
            this.radGroupBoxColumns.HeaderImageKey = "";
            this.radGroupBoxColumns.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBoxColumns.HeaderText = "Columns Position";
            this.radGroupBoxColumns.Location = new System.Drawing.Point(10, 38);
            this.radGroupBoxColumns.Name = "radGroupBoxColumns";
            this.radGroupBoxColumns.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBoxColumns.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBoxColumns.Size = new System.Drawing.Size(180, 151);
            this.radGroupBoxColumns.TabIndex = 1;
            this.radGroupBoxColumns.Text = "Columns Position";
            // 
            // radRadioButtonColumnPinnedRight
            // 
            this.radRadioButtonColumnPinnedRight.Location = new System.Drawing.Point(13, 118);
            this.radRadioButtonColumnPinnedRight.Name = "radRadioButtonColumnPinnedRight";
            this.radRadioButtonColumnPinnedRight.Size = new System.Drawing.Size(144, 18);
            this.radRadioButtonColumnPinnedRight.TabIndex = 3;
            this.radRadioButtonColumnPinnedRight.Text = "Right Pinned Position";
           
            // 
            // radRadioButtonColumnPinnedLeft
            // 
            this.radRadioButtonColumnPinnedLeft.Location = new System.Drawing.Point(13, 94);
            this.radRadioButtonColumnPinnedLeft.Name = "radRadioButtonColumnPinnedLeft";
            this.radRadioButtonColumnPinnedLeft.Size = new System.Drawing.Size(131, 18);
            this.radRadioButtonColumnPinnedLeft.TabIndex = 2;
            this.radRadioButtonColumnPinnedLeft.Text = "Left Pinned Position";
        
            // 
            // radRadioButtonColumnPinnedNone
            // 
            this.radRadioButtonColumnPinnedNone.Location = new System.Drawing.Point(13, 70);
            this.radRadioButtonColumnPinnedNone.Name = "radRadioButtonColumnPinnedNone";
            this.radRadioButtonColumnPinnedNone.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonColumnPinnedNone.TabIndex = 1;
            this.radRadioButtonColumnPinnedNone.Text = "None";
         
            // 
            // radComboBoxColumns
            // 
            this.radComboBoxColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBoxColumns.Location = new System.Drawing.Point(13, 32);
            this.radComboBoxColumns.Name = "radComboBoxColumns";
            // 
            // 
            // 
            this.radComboBoxColumns.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxColumns.Size = new System.Drawing.Size(154, 20);
            this.radComboBoxColumns.TabIndex = 0;
         
            // 
            // radGroupBoxSysRows
            // 
            this.radGroupBoxSysRows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxSysRows.Controls.Add(this.radComboBoxSystemRowPosition);
            this.radGroupBoxSysRows.Controls.Add(this.radLabelSystemRowPosition);
            this.radGroupBoxSysRows.Controls.Add(this.radComboBoxRowPinPosition);
            this.radGroupBoxSysRows.Controls.Add(this.radLabelRowPinPosition);
            this.radGroupBoxSysRows.Controls.Add(this.radComboBoxSystemRows);
            this.radGroupBoxSysRows.FooterImageIndex = -1;
            this.radGroupBoxSysRows.FooterImageKey = "";
            this.radGroupBoxSysRows.HeaderImageIndex = -1;
            this.radGroupBoxSysRows.HeaderImageKey = "";
            this.radGroupBoxSysRows.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBoxSysRows.HeaderText = "System Rows Position";
            this.radGroupBoxSysRows.Location = new System.Drawing.Point(10, 195);
            this.radGroupBoxSysRows.Name = "radGroupBoxSysRows";
            this.radGroupBoxSysRows.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBoxSysRows.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBoxSysRows.Size = new System.Drawing.Size(180, 162);
            this.radGroupBoxSysRows.TabIndex = 2;
            this.radGroupBoxSysRows.Text = "System Rows Position";
            // 
            // radComboBoxSystemRows
            // 
            this.radComboBoxSystemRows.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBoxSystemRows.Location = new System.Drawing.Point(13, 33);
            this.radComboBoxSystemRows.Name = "radComboBoxSystemRows";
            // 
            // 
            // 
            this.radComboBoxSystemRows.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxSystemRows.Size = new System.Drawing.Size(154, 20);
            this.radComboBoxSystemRows.TabIndex = 0;
           
            // 
            // aggregatesSampleTableBindingSource
            // 
            this.aggregatesSampleTableBindingSource.DataMember = "EmployeeOrders";
            this.aggregatesSampleTableBindingSource.DataSource = this.nwindRadGridView;
            // 
            // nwindRadGridView
            // 
            this.nwindRadGridView.DataSetName = "NwindRadGridView";
            this.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aggregatesSampleTableTableAdapter
            // 
            this.aggregatesSampleTableTableAdapter.ClearBeforeFill = true;
            // 
            // radLabelRowPinPosition
            // 
            this.radLabelRowPinPosition.Location = new System.Drawing.Point(13, 59);
            this.radLabelRowPinPosition.Name = "radLabelRowPinPosition";
            this.radLabelRowPinPosition.Size = new System.Drawing.Size(70, 14);
            this.radLabelRowPinPosition.TabIndex = 1;
            this.radLabelRowPinPosition.Text = "Row Pin Position";
            this.radLabelRowPinPosition.TextWrap = true;
            // 
            // radComboBoxRowPinPosition
            // 
            this.radComboBoxRowPinPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBoxRowPinPosition.Location = new System.Drawing.Point(13, 79);
            this.radComboBoxRowPinPosition.Name = "radComboBoxRowPinPosition";
            // 
            // 
            // 
            this.radComboBoxRowPinPosition.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxRowPinPosition.Size = new System.Drawing.Size(154, 20);
            this.radComboBoxRowPinPosition.TabIndex = 2;
          
            // 
            // radLabelSystemRowPosition
            // 
            this.radLabelSystemRowPosition.Location = new System.Drawing.Point(13, 105);
            this.radLabelSystemRowPosition.Name = "radLabelSystemRowPosition";
            this.radLabelSystemRowPosition.Size = new System.Drawing.Size(111, 14);
            this.radLabelSystemRowPosition.TabIndex = 3;
            this.radLabelSystemRowPosition.Text = "System Row Position";
            this.radLabelSystemRowPosition.TextWrap = true;
            // 
            // radComboBoxSystemRowPosition
            // 
            this.radComboBoxSystemRowPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBoxSystemRowPosition.Location = new System.Drawing.Point(13, 125);
            this.radComboBoxSystemRowPosition.Name = "radComboBoxSystemRowPosition";
            // 
            // 
            // 
            this.radComboBoxSystemRowPosition.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxSystemRowPosition.Size = new System.Drawing.Size(154, 20);
            this.radComboBoxSystemRowPosition.TabIndex = 4;
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(939, 725);
           
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxColumns)).EndInit();
            this.radGroupBoxColumns.ResumeLayout(false);
            this.radGroupBoxColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnPinnedRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnPinnedLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonColumnPinnedNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxSysRows)).EndInit();
            this.radGroupBoxSysRows.ResumeLayout(false);
            this.radGroupBoxSysRows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSystemRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatesSampleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRowPinPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxRowPinPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSystemRowPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSystemRowPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBoxColumns;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxColumns;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonColumnPinnedRight;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonColumnPinnedLeft;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonColumnPinnedNone;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxSysRows;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxSystemRows;
        private System.Windows.Forms.BindingSource aggregatesSampleTableBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter aggregatesSampleTableTableAdapter;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxRowPinPosition;
        private Telerik.WinControls.UI.RadLabel radLabelRowPinPosition;
        private Telerik.WinControls.UI.RadLabel radLabelSystemRowPosition;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxSystemRowPosition;
    }
}
