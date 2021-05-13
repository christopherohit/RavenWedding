namespace Telerik.Examples.WinControls.GridView.Sorting.Sorting
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButtonTitleCountryCity = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonContactTitleCity = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonCountry = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonCity = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonContactTitle = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonContactName = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonPostalCode = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonNone = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonDesc = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonAsc = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabelCol = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonTitleCountryCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonContactTitleCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonContactTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonContactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonAsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCol)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.ForeColor = System.Drawing.Color.White;
            this.settingsPanel.Location = new System.Drawing.Point(779, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.White;
            this.settingsPanel.Size = new System.Drawing.Size(200, 784);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(120, 134);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(740, 547);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Telerik";
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
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radRadioButtonTitleCountryCity);
            this.radGroupBox1.Controls.Add(this.radRadioButtonContactTitleCity);
            this.radGroupBox1.Controls.Add(this.radRadioButtonCountry);
            this.radGroupBox1.Controls.Add(this.radRadioButtonCity);
            this.radGroupBox1.Controls.Add(this.radRadioButtonContactTitle);
            this.radGroupBox1.Controls.Add(this.radRadioButtonContactName);
            this.radGroupBox1.Controls.Add(this.radRadioButtonPostalCode);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox1.HeaderText = "Sort By";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(162, 204);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Sort By";
            // 
            // radRadioButtonTitleCountryCity
            // 
            this.radRadioButtonTitleCountryCity.Location = new System.Drawing.Point(22, 161);
            this.radRadioButtonTitleCountryCity.Name = "radRadioButtonTitleCountryCity";
            this.radRadioButtonTitleCountryCity.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonTitleCountryCity.Size = new System.Drawing.Size(132, 16);
            this.radRadioButtonTitleCountryCity.TabIndex = 5;
            this.radRadioButtonTitleCountryCity.Text = "Title, Country and City";
            // 
            // radRadioButtonContactTitleCity
            // 
            this.radRadioButtonContactTitleCity.Location = new System.Drawing.Point(22, 139);
            this.radRadioButtonContactTitleCity.Name = "radRadioButtonContactTitleCity";
            this.radRadioButtonContactTitleCity.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonContactTitleCity.Size = new System.Drawing.Size(128, 16);
            this.radRadioButtonContactTitleCity.TabIndex = 5;
            this.radRadioButtonContactTitleCity.Text = "Contact Title and City";
            // 
            // radRadioButtonCountry
            // 
            this.radRadioButtonCountry.Location = new System.Drawing.Point(22, 96);
            this.radRadioButtonCountry.Name = "radRadioButtonCountry";
            this.radRadioButtonCountry.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonCountry.Size = new System.Drawing.Size(60, 16);
            this.radRadioButtonCountry.TabIndex = 5;
            this.radRadioButtonCountry.Text = "Country";
            // 
            // radRadioButtonCity
            // 
            this.radRadioButtonCity.Location = new System.Drawing.Point(22, 74);
            this.radRadioButtonCity.Name = "radRadioButtonCity";
            this.radRadioButtonCity.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonCity.Size = new System.Drawing.Size(40, 16);
            this.radRadioButtonCity.TabIndex = 5;
            this.radRadioButtonCity.Text = "City";
            // 
            // radRadioButtonContactTitle
            // 
            this.radRadioButtonContactTitle.Location = new System.Drawing.Point(22, 52);
            this.radRadioButtonContactTitle.Name = "radRadioButtonContactTitle";
            this.radRadioButtonContactTitle.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonContactTitle.Size = new System.Drawing.Size(84, 16);
            this.radRadioButtonContactTitle.TabIndex = 5;
            this.radRadioButtonContactTitle.Text = "Contact Title";
            // 
            // radRadioButtonContactName
            // 
            this.radRadioButtonContactName.Location = new System.Drawing.Point(22, 30);
            this.radRadioButtonContactName.Name = "radRadioButtonContactName";
            this.radRadioButtonContactName.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonContactName.Size = new System.Drawing.Size(92, 16);
            this.radRadioButtonContactName.TabIndex = 5;
            this.radRadioButtonContactName.Text = "Contact Name";
            // 
            // radRadioButtonPostalCode
            // 
            this.radRadioButtonPostalCode.Location = new System.Drawing.Point(22, 118);
            this.radRadioButtonPostalCode.Name = "radRadioButtonPostalCode";
            this.radRadioButtonPostalCode.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonPostalCode.Size = new System.Drawing.Size(82, 16);
            this.radRadioButtonPostalCode.TabIndex = 5;
            this.radRadioButtonPostalCode.Text = "Postal Code";
            // 
            // radRadioButtonNone
            // 
            this.radRadioButtonNone.Location = new System.Drawing.Point(22, 81);
            this.radRadioButtonNone.Name = "radRadioButtonNone";
            this.radRadioButtonNone.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonNone.Size = new System.Drawing.Size(47, 16);
            this.radRadioButtonNone.TabIndex = 7;
            this.radRadioButtonNone.Text = "None";
            // 
            // radRadioButtonDesc
            // 
            this.radRadioButtonDesc.Location = new System.Drawing.Point(22, 59);
            this.radRadioButtonDesc.Name = "radRadioButtonDesc";
            this.radRadioButtonDesc.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonDesc.Size = new System.Drawing.Size(80, 16);
            this.radRadioButtonDesc.TabIndex = 6;
            this.radRadioButtonDesc.Text = "Descending";
          
            // 
            // radRadioButtonAsc
            // 
            this.radRadioButtonAsc.Location = new System.Drawing.Point(22, 36);
            this.radRadioButtonAsc.Name = "radRadioButtonAsc";
            this.radRadioButtonAsc.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonAsc.Size = new System.Drawing.Size(73, 16);
            this.radRadioButtonAsc.TabIndex = 5;
            this.radRadioButtonAsc.Text = "Ascending";
         
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(120, 114);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Size = new System.Drawing.Size(90, 14);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Grid is sorted by:";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Controls.Add(this.radRadioButtonNone);
            this.radGroupBox2.Controls.Add(this.radRadioButtonAsc);
            this.radGroupBox2.Controls.Add(this.radRadioButtonDesc);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox2.HeaderText = "Sort Direction";
            this.radGroupBox2.Location = new System.Drawing.Point(15, 218);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(162, 126);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Sort Direction";
            // 
            // radLabelCol
            // 
            this.radLabelCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabelCol.Location = new System.Drawing.Point(223, 114);
            this.radLabelCol.Name = "radLabelCol";
            this.radLabelCol.Size = new System.Drawing.Size(76, 14);
            this.radLabelCol.TabIndex = 2;
            this.radLabelCol.Text = "Contact Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabelCol);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(980, 786);
      
            this.Controls.SetChildIndex(this.radLabelCol, 0);
            this.Controls.SetChildIndex(this.radLabel1, 0);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonTitleCountryCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonContactTitleCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonContactTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonContactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonAsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonDesc;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonAsc;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonNone;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonCountry;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonCity;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonContactTitle;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonContactName;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonPostalCode;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonTitleCountryCity;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonContactTitleCity;
        private Telerik.WinControls.UI.RadLabel radLabelCol;
    }
}