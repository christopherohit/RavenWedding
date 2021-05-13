namespace Telerik.Examples.WinControls.GridView.PopulateWithData.DataBinding
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
            if (set != null)
            {
                set.Dispose();
                set = null;
            }
            if (adapter != null)
            {
                adapter.Dispose();
                adapter = null;
            }
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
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioDataSet = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioArrLst = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioSubObj = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioObjects = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioDataReader = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioArrLst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioSubObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataReader)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(727, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 608);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.EnableHotTracking = false;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.Caption = null;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
            this.radGridView1.Name = "radGridView1";
            // 
            // 
            // 
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Size = new System.Drawing.Size(928, 610);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "Telerik";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radRadioDataSet);
            this.radGroupBox1.Controls.Add(this.radRadioArrLst);
            this.radGroupBox1.Controls.Add(this.radRadioSubObj);
            this.radGroupBox1.Controls.Add(this.radRadioObjects);
            this.radGroupBox1.Controls.Add(this.radRadioDataReader);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupBox1.HeaderText = "Data Binding Options";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(180, 161);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Data Binding Options";
            // 
            // radRadioDataSet
            // 
            this.radRadioDataSet.AllowShowFocusCues = true;
            this.radRadioDataSet.Location = new System.Drawing.Point(31, 54);
            this.radRadioDataSet.Name = "radRadioDataSet";
            this.radRadioDataSet.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioDataSet.Size = new System.Drawing.Size(64, 16);
            this.radRadioDataSet.TabIndex = 3;
            this.radRadioDataSet.Text = "Data Set";
            // 
            // radRadioArrLst
            // 
            this.radRadioArrLst.AllowShowFocusCues = true;
            this.radRadioArrLst.Location = new System.Drawing.Point(31, 120);
            this.radRadioArrLst.Name = "radRadioArrLst";
            this.radRadioArrLst.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioArrLst.Size = new System.Drawing.Size(68, 16);
            this.radRadioArrLst.TabIndex = 2;
            this.radRadioArrLst.Text = "Array List";
            // 
            // radRadioSubObj
            // 
            this.radRadioSubObj.AllowShowFocusCues = true;
            this.radRadioSubObj.Location = new System.Drawing.Point(31, 98);
            this.radRadioSubObj.Name = "radRadioSubObj";
            this.radRadioSubObj.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioSubObj.Size = new System.Drawing.Size(83, 16);
            this.radRadioSubObj.TabIndex = 2;
            this.radRadioSubObj.Text = "Sub-Objects";
            // 
            // radRadioObjects
            // 
            this.radRadioObjects.AllowShowFocusCues = true;
            this.radRadioObjects.Location = new System.Drawing.Point(31, 76);
            this.radRadioObjects.Name = "radRadioObjects";
            this.radRadioObjects.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioObjects.Size = new System.Drawing.Size(101, 16);
            this.radRadioObjects.TabIndex = 2;
            this.radRadioObjects.Text = "Custom Objects";
            // 
            // radRadioDataReader
            // 
            this.radRadioDataReader.AllowShowFocusCues = true;
            this.radRadioDataReader.Location = new System.Drawing.Point(31, 32);
            this.radRadioDataReader.Name = "radRadioDataReader";
            this.radRadioDataReader.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioDataReader.Size = new System.Drawing.Size(84, 16);
            this.radRadioDataReader.TabIndex = 2;
            this.radRadioDataReader.Text = "Data Reader";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(928, 610);

            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioArrLst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioSubObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioDataReader;
        private Telerik.WinControls.UI.RadRadioButton radRadioArrLst;
        private Telerik.WinControls.UI.RadRadioButton radRadioSubObj;
        private Telerik.WinControls.UI.RadRadioButton radRadioObjects;
        private Telerik.WinControls.UI.RadRadioButton radRadioDataSet;


    }
}
