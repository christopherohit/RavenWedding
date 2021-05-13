using System.Drawing;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.GridView.Columns.ColumnRowOperations
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
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.chkColAutosize = new Telerik.WinControls.UI.RadCheckBox();
            this.chkColResize = new Telerik.WinControls.UI.RadCheckBox();
            this.chkContextMenu = new Telerik.WinControls.UI.RadCheckBox();
            this.chkColReorder = new Telerik.WinControls.UI.RadCheckBox();
            this.chkColChooser = new Telerik.WinControls.UI.RadCheckBox();
            this.chkRowResize = new Telerik.WinControls.UI.RadCheckBox();
            this.chkFiltering = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColAutosize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkContextMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRowResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFiltering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox3);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(779, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 810);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox3, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSize = false;
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(980, 812);
            this.radGridView1.TabIndex = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindRadGridView;
            // 
            // nwindRadGridView
            // 
            this.nwindRadGridView.DataSetName = "NwindRadGridView";
            this.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // chkColAutosize
            // 
            this.chkColAutosize.Location = new System.Drawing.Point(19, 54);
            this.chkColAutosize.Name = "chkColAutosize";
            // 
            // 
            // 
            this.chkColAutosize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkColAutosize.Size = new System.Drawing.Size(88, 17);
            this.chkColAutosize.TabIndex = 32;
            this.chkColAutosize.Text = "Allow BestFit";
            this.chkColAutosize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkColAutosize.ThemeName = "GridFeaturesBrowser";
            this.chkColAutosize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkColResize
            // 
            this.chkColResize.Location = new System.Drawing.Point(19, 27);
            this.chkColResize.Name = "chkColResize";
            // 
            // 
            // 
            this.chkColResize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkColResize.Size = new System.Drawing.Size(96, 17);
            this.chkColResize.TabIndex = 27;
            this.chkColResize.Text = "Allow Resizing";
            this.chkColResize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkColResize.ThemeName = "GridFeaturesBrowser";
            this.chkColResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkContextMenu
            // 
            this.chkContextMenu.Location = new System.Drawing.Point(19, 107);
            this.chkContextMenu.Name = "chkContextMenu";
            // 
            // 
            // 
            this.chkContextMenu.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkContextMenu.Size = new System.Drawing.Size(123, 17);
            this.chkContextMenu.TabIndex = 25;
            this.chkContextMenu.Text = "Allow Context Menu";
            this.chkContextMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkContextMenu.ThemeName = "GridFeaturesBrowser";
            this.chkContextMenu.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkColReorder
            // 
            this.chkColReorder.Location = new System.Drawing.Point(19, 81);
            this.chkColReorder.Name = "chkColReorder";
            // 
            // 
            // 
            this.chkColReorder.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkColReorder.Size = new System.Drawing.Size(93, 17);
            this.chkColReorder.TabIndex = 29;
            this.chkColReorder.Text = "Allow Reorder";
            this.chkColReorder.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkColReorder.ThemeName = "GridFeaturesBrowser";
            this.chkColReorder.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkColChooser
            // 
            this.chkColChooser.Location = new System.Drawing.Point(19, 134);
            this.chkColChooser.Name = "chkColChooser";
            // 
            // 
            // 
            this.chkColChooser.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkColChooser.Size = new System.Drawing.Size(137, 17);
            this.chkColChooser.TabIndex = 28;
            this.chkColChooser.Text = "Allow Column Chooser";
            this.chkColChooser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkColChooser.ThemeName = "GridFeaturesBrowser";
            this.chkColChooser.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkRowResize
            // 
            this.chkRowResize.Location = new System.Drawing.Point(19, 25);
            this.chkRowResize.Name = "chkRowResize";
            // 
            // 
            // 
            this.chkRowResize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkRowResize.Size = new System.Drawing.Size(122, 17);
            this.chkRowResize.TabIndex = 27;
            this.chkRowResize.Text = "Allow Row Resizing";
            this.chkRowResize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkRowResize.ThemeName = "GridFeaturesBrowser";
            this.chkRowResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // chkFiltering
            // 
            this.chkFiltering.Location = new System.Drawing.Point(19, 26);
            this.chkFiltering.Name = "chkFiltering";
            // 
            // 
            // 
            this.chkFiltering.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.chkFiltering.Size = new System.Drawing.Size(63, 17);
            this.chkFiltering.TabIndex = 33;
            this.chkFiltering.Text = "Filtering";
            this.chkFiltering.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkFiltering.ThemeName = "GridFeaturesBrowser";
            this.chkFiltering.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.chkColResize);
            this.radGroupBox1.Controls.Add(this.chkContextMenu);
            this.radGroupBox1.Controls.Add(this.chkColAutosize);
            this.radGroupBox1.Controls.Add(this.chkColChooser);
            this.radGroupBox1.Controls.Add(this.chkColReorder);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox1.HeaderText = " Column Actions ";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(162, 162);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = " Column Actions ";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Controls.Add(this.chkRowResize);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox2.HeaderText = " Row Actions ";
            this.radGroupBox2.Location = new System.Drawing.Point(15, 176);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(162, 62);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = " Row Actions ";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.Controls.Add(this.chkFiltering);
            this.radGroupBox3.FooterImageIndex = -1;
            this.radGroupBox3.FooterImageKey = "";
            this.radGroupBox3.HeaderImageIndex = -1;
            this.radGroupBox3.HeaderImageKey = "";
            this.radGroupBox3.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox3.HeaderText = "Data";
            this.radGroupBox3.Location = new System.Drawing.Point(15, 244);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(162, 56);
            this.radGroupBox3.TabIndex = 2;
            this.radGroupBox3.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(980, 812);
      
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColAutosize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkContextMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkColChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRowResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFiltering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private BindingSource customersBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadCheckBox chkColAutosize;
        private Telerik.WinControls.UI.RadCheckBox chkColResize;
        private Telerik.WinControls.UI.RadCheckBox chkContextMenu;
        private Telerik.WinControls.UI.RadCheckBox chkColReorder;
        private Telerik.WinControls.UI.RadCheckBox chkColChooser;
        private Telerik.WinControls.UI.RadCheckBox chkRowResize;
        private Telerik.WinControls.UI.RadCheckBox chkFiltering;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
	}
}
