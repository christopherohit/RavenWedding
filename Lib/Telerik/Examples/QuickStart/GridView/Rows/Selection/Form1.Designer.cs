using Telerik.WinControls.UI;
using System.Collections.Generic;
namespace Telerik.Examples.WinControls.GridView.Rows.Selection
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
            this.radCheckMulti = new Telerik.WinControls.UI.RadCheckBox();
            this.radComboSelectionMode = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.aggregatesSampleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.aggregatesSampleTableTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter();
            this.radCheckHideSel = new Telerik.WinControls.UI.RadCheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckMulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSelectionMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatesSampleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckHideSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radButton2);
            this.settingsPanel.Controls.Add(this.radButton1);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButton1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radButton2, 0);
            // 
            // radCheckMulti
            // 
            this.radCheckMulti.AutoSize = true;
            this.radCheckMulti.Location = new System.Drawing.Point(21, 85);
            this.radCheckMulti.Name = "radCheckMulti";
            this.radCheckMulti.Size = new System.Drawing.Size(104, 14);
            this.radCheckMulti.TabIndex = 0;
            this.radCheckMulti.Text = "Allow MultiSelect";
            this.radCheckMulti.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radCheckMulti.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radComboSelectionMode
            // 
            this.radComboSelectionMode.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboSelectionMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboSelectionMode.FormatString = "{0}";
            this.radComboSelectionMode.Items.AddRange(new List<RadListDataItem>(new RadListDataItem[] {
            this.radComboBoxItem1,
            this.radComboBoxItem2}));
            this.radComboSelectionMode.Location = new System.Drawing.Point(21, 56);
            this.radComboSelectionMode.MaxDropDownItems = 6;
            this.radComboSelectionMode.Name = "radComboSelectionMode";
            // 
            // 
            // 
            this.radComboSelectionMode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboSelectionMode.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboSelectionMode.Size = new System.Drawing.Size(121, 20);
            this.radComboSelectionMode.TabIndex = 2;
            this.radComboSelectionMode.TabStop = false;
            // 
            // radComboBoxItem1
            // 
            this.radComboBoxItem1.Text = "FullRowSelect";
            // 
            // radComboBoxItem2
            // 
            this.radComboBoxItem2.Text = "CellSelect";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(21, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(87, 16);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Selection Mode:";
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
            // radCheckHideSel
            // 
            this.radCheckHideSel.AutoSize = true;
            this.radCheckHideSel.Location = new System.Drawing.Point(21, 111);
            this.radCheckHideSel.Name = "radCheckHideSel";
            this.radCheckHideSel.Size = new System.Drawing.Size(111, 39);
            this.radCheckHideSel.TabIndex = 6;
            this.radCheckHideSel.Text = "Hide selection of\r\ncurrent row when\r\ncontrol is inactive";
            this.radCheckHideSel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.radCheckHideSel, "Hide selection of current row\r\nwhen the control loses focus");
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(1224, 737);
            this.radGridView1.TabIndex = 4;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radComboSelectionMode);
            this.radGroupBox1.Controls.Add(this.radCheckHideSel);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radCheckMulti);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox1.HeaderText = " Selection Preferences ";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 165);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = " Selection Preferences ";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton1.Location = new System.Drawing.Point(10, 177);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(180, 23);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Select All";           
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButton2.Location = new System.Drawing.Point(10, 206);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(180, 23);
            this.radButton2.TabIndex = 9;
            this.radButton2.Text = "Clear Selection";
    
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
            ((System.ComponentModel.ISupportInitialize)(this.radCheckMulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSelectionMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggregatesSampleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckHideSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadCheckBox radCheckMulti;
		private Telerik.WinControls.UI.RadDropDownList radComboSelectionMode;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadGridView radGridView1;
		private Telerik.WinControls.UI.RadListDataItem radComboBoxItem1;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem2;
		private System.Windows.Forms.BindingSource aggregatesSampleTableBindingSource;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter aggregatesSampleTableTableAdapter;
        private Telerik.WinControls.UI.RadCheckBox radCheckHideSel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
	}
}
