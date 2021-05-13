using System.Drawing;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.GridView.Grouping.Grouping
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioAnimNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioAnimSlide = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioAnimFade = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioAnimWipe = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioAnimAccordion = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radBtnCollapseAll = new Telerik.WinControls.UI.RadButton();
            this.radBtnExpandAll = new Telerik.WinControls.UI.RadButton();
            this.radCheckBoxShowGroupPanel = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioCityCountry = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioDisable = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCountry = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCity = new Telerik.WinControls.UI.RadRadioButton();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimFade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimWipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimAccordion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnCollapseAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnExpandAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowGroupPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCityCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDisable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCity)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox3);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(230, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox3, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            gridViewTextBoxColumn1.FieldName = "ContactName";
            gridViewTextBoxColumn1.HeaderText = "Contact Name";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ContactName";
            gridViewTextBoxColumn1.Width = 314;
            gridViewTextBoxColumn2.FieldName = "CompanyName";
            gridViewTextBoxColumn2.HeaderText = "Company Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "CompanyName";
            gridViewTextBoxColumn2.Width = 314;
            gridViewTextBoxColumn3.FieldName = "City";
            gridViewTextBoxColumn3.HeaderText = "City";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "City";
            gridViewTextBoxColumn3.Width = 314;
            gridViewTextBoxColumn4.FieldName = "Country";
            gridViewTextBoxColumn4.HeaderText = "Country";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Country";
            gridViewTextBoxColumn4.Width = 316;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView1.MasterTemplate.DataSource = this.customersBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1276, 519);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "ControlDefault";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox1.Controls.Add(this.radRadioAnimNone);
            this.radGroupBox1.Controls.Add(this.radRadioAnimSlide);
            this.radGroupBox1.Controls.Add(this.radRadioAnimFade);
            this.radGroupBox1.Controls.Add(this.radRadioAnimWipe);
            this.radGroupBox1.Controls.Add(this.radRadioAnimAccordion);
            this.radGroupBox1.FooterText = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox1.HeaderText = " Animation ";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 299);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(210, 133);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.Text = " Animation ";
            // 
            // radRadioAnimNone
            // 
            this.radRadioAnimNone.Location = new System.Drawing.Point(19, 21);
            this.radRadioAnimNone.Name = "radRadioAnimNone";
            this.radRadioAnimNone.Size = new System.Drawing.Size(48, 18);
            this.radRadioAnimNone.TabIndex = 1;
            this.radRadioAnimNone.Text = "None";
          
            // 
            // radRadioAnimSlide
            // 
            this.radRadioAnimSlide.Location = new System.Drawing.Point(19, 109);
            this.radRadioAnimSlide.Name = "radRadioAnimSlide";
            this.radRadioAnimSlide.Size = new System.Drawing.Size(44, 18);
            this.radRadioAnimSlide.TabIndex = 0;
            this.radRadioAnimSlide.Text = "Slide";
           
            // 
            // radRadioAnimFade
            // 
            this.radRadioAnimFade.Location = new System.Drawing.Point(19, 87);
            this.radRadioAnimFade.Name = "radRadioAnimFade";
            this.radRadioAnimFade.Size = new System.Drawing.Size(44, 18);
            this.radRadioAnimFade.TabIndex = 0;
            this.radRadioAnimFade.Text = "Fade";
           
            // 
            // radRadioAnimWipe
            // 
            this.radRadioAnimWipe.Location = new System.Drawing.Point(19, 65);
            this.radRadioAnimWipe.Name = "radRadioAnimWipe";
            this.radRadioAnimWipe.Size = new System.Drawing.Size(92, 18);
            this.radRadioAnimWipe.TabIndex = 0;
            this.radRadioAnimWipe.Text = "Gradient Wipe";
         
            // 
            // radRadioAnimAccordion
            // 
            this.radRadioAnimAccordion.Location = new System.Drawing.Point(19, 43);
            this.radRadioAnimAccordion.Name = "radRadioAnimAccordion";
            this.radRadioAnimAccordion.Size = new System.Drawing.Size(71, 18);
            this.radRadioAnimAccordion.TabIndex = 0;
            this.radRadioAnimAccordion.Text = "Accordion";
           
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox2.Controls.Add(this.radBtnCollapseAll);
            this.radGroupBox2.Controls.Add(this.radBtnExpandAll);
            this.radGroupBox2.Controls.Add(this.radCheckBoxShowGroupPanel);
            this.radGroupBox2.FooterText = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox2.HeaderText = " Grouping Options ";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(210, 116);
            this.radGroupBox2.TabIndex = 10;
            this.radGroupBox2.Text = " Grouping Options ";
            // 
            // radBtnCollapseAll
            // 
            this.radBtnCollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnCollapseAll.Location = new System.Drawing.Point(19, 26);
            this.radBtnCollapseAll.Name = "radBtnCollapseAll";
            this.radBtnCollapseAll.Size = new System.Drawing.Size(178, 23);
            this.radBtnCollapseAll.TabIndex = 10;
            this.radBtnCollapseAll.Text = "Collapse All";
           
            // 
            // radBtnExpandAll
            // 
            this.radBtnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radBtnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnExpandAll.Location = new System.Drawing.Point(19, 55);
            this.radBtnExpandAll.Name = "radBtnExpandAll";
            this.radBtnExpandAll.Size = new System.Drawing.Size(178, 23);
            this.radBtnExpandAll.TabIndex = 10;
            this.radBtnExpandAll.Text = "Expand All";

            // 
            // radCheckBoxShowGroupPanel
            // 
            this.radCheckBoxShowGroupPanel.Location = new System.Drawing.Point(19, 84);
            this.radCheckBoxShowGroupPanel.Name = "radCheckBoxShowGroupPanel";
            this.radCheckBoxShowGroupPanel.Size = new System.Drawing.Size(128, 18);
            this.radCheckBoxShowGroupPanel.TabIndex = 9;
            this.radCheckBoxShowGroupPanel.Text = "Show Grouping Panel";
          
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox3.Controls.Add(this.radRadioCityCountry);
            this.radGroupBox3.Controls.Add(this.radRadioDisable);
            this.radGroupBox3.Controls.Add(this.radRadioNone);
            this.radGroupBox3.Controls.Add(this.radRadioCountry);
            this.radGroupBox3.Controls.Add(this.radRadioCity);
            this.radGroupBox3.FooterText = "";
            this.radGroupBox3.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox3.HeaderText = " Group By ";
            this.radGroupBox3.Location = new System.Drawing.Point(10, 154);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox3.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox3.Size = new System.Drawing.Size(210, 136);
            this.radGroupBox3.TabIndex = 10;
            this.radGroupBox3.Text = " Group By ";
            // 
            // radRadioCityCountry
            // 
            this.radRadioCityCountry.Location = new System.Drawing.Point(19, 22);
            this.radRadioCityCountry.Name = "radRadioCityCountry";
            this.radRadioCityCountry.Size = new System.Drawing.Size(104, 18);
            this.radRadioCityCountry.TabIndex = 0;
            this.radRadioCityCountry.Text = "Country and City";
          
            // 
            // radRadioDisable
            // 
            this.radRadioDisable.Location = new System.Drawing.Point(19, 110);
            this.radRadioDisable.Name = "radRadioDisable";
            this.radRadioDisable.Size = new System.Drawing.Size(57, 18);
            this.radRadioDisable.TabIndex = 0;
            this.radRadioDisable.Text = "Disable";
          
            // 
            // radRadioNone
            // 
            this.radRadioNone.Location = new System.Drawing.Point(19, 88);
            this.radRadioNone.Name = "radRadioNone";
            this.radRadioNone.Size = new System.Drawing.Size(48, 18);
            this.radRadioNone.TabIndex = 0;
            this.radRadioNone.Text = "None";
           
            // 
            // radRadioCountry
            // 
            this.radRadioCountry.Location = new System.Drawing.Point(19, 66);
            this.radRadioCountry.Name = "radRadioCountry";
            this.radRadioCountry.Size = new System.Drawing.Size(60, 18);
            this.radRadioCountry.TabIndex = 0;
            this.radRadioCountry.Text = "Country";
          
            // 
            // radRadioCity
            // 
            this.radRadioCity.Location = new System.Drawing.Point(19, 44);
            this.radRadioCity.Name = "radRadioCity";
            this.radRadioCity.Size = new System.Drawing.Size(39, 18);
            this.radRadioCity.TabIndex = 0;
            this.radRadioCity.Text = "City";
          
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1276, 519);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimFade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimWipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioAnimAccordion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnCollapseAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnExpandAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowGroupPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCityCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDisable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCity)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowGroupPanel;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadRadioButton radRadioCity;
        private Telerik.WinControls.UI.RadRadioButton radRadioCityCountry;
        private Telerik.WinControls.UI.RadRadioButton radRadioCountry;
        private Telerik.WinControls.UI.RadRadioButton radRadioAnimAccordion;
        private Telerik.WinControls.UI.RadRadioButton radRadioAnimWipe;
        private Telerik.WinControls.UI.RadRadioButton radRadioAnimFade;
        private Telerik.WinControls.UI.RadRadioButton radRadioAnimSlide;
        private Telerik.WinControls.UI.RadButton radBtnExpandAll;
        private Telerik.WinControls.UI.RadButton radBtnCollapseAll;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private Telerik.WinControls.UI.RadRadioButton radRadioNone;
        private BindingSource customersBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Telerik.WinControls.UI.RadRadioButton radRadioAnimNone;
        private Telerik.WinControls.UI.RadRadioButton radRadioDisable;
	}
}
