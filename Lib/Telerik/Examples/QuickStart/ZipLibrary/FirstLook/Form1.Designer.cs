namespace Telerik.Examples.WinControls.ZipLibrary.FirstLook
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
            Telerik.WinControls.UI.StartsWithFindStringComparer startsWithFindStringComparer1 = new Telerik.WinControls.UI.StartsWithFindStringComparer();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.checkedListView = new Telerik.WinControls.UI.RadListView();
            this.saveZipFileButton = new Telerik.WinControls.UI.RadButton();
            this.readZipFileButton = new Telerik.WinControls.UI.RadButton();
            this.clearZipFileButton = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveZipFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readZipFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearZipFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1141, 75);
            // 
            // checkedListView
            // 
            this.checkedListView.FindStringComparer = startsWithFindStringComparer1;
            this.checkedListView.Location = new System.Drawing.Point(3, 3);
            this.checkedListView.Name = "checkedListView";
            this.checkedListView.ShowCheckBoxes = true;
            this.checkedListView.Size = new System.Drawing.Size(209, 264);
            this.checkedListView.TabIndex = 2;
            this.checkedListView.Text = "radListView1";
            // 
            // saveZipFileButton
            // 
            this.saveZipFileButton.Location = new System.Drawing.Point(3, 273);
            this.saveZipFileButton.Name = "saveZipFileButton";
            this.saveZipFileButton.Size = new System.Drawing.Size(209, 24);
            this.saveZipFileButton.TabIndex = 3;
            this.saveZipFileButton.Text = "Save Zip File";
            this.saveZipFileButton.Click += new System.EventHandler(this.saveZipFileButton_Click);
            // 
            // readZipFileButton
            // 
            this.readZipFileButton.Location = new System.Drawing.Point(512, 270);
            this.readZipFileButton.Name = "readZipFileButton";
            this.readZipFileButton.Size = new System.Drawing.Size(123, 24);
            this.readZipFileButton.TabIndex = 4;
            this.readZipFileButton.Text = "Read Zip File";
            this.readZipFileButton.Click += new System.EventHandler(this.readZipFileButton_Click);
            // 
            // clearZipFileButton
            // 
            this.clearZipFileButton.Location = new System.Drawing.Point(643, 270);
            this.clearZipFileButton.Name = "clearZipFileButton";
            this.clearZipFileButton.Size = new System.Drawing.Size(123, 24);
            this.clearZipFileButton.TabIndex = 4;
            this.clearZipFileButton.Text = "Clear Zip File";
            this.clearZipFileButton.Click += new System.EventHandler(this.clearZipFileButton_Click);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(211, 0);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(22, 297);
            this.radSeparator1.TabIndex = 6;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(235, 0);
            this.radGridView1.GridViewElement.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "File name";
            gridViewTextBoxColumn1.Name = "FileNameInZip";
            gridViewTextBoxColumn1.Width = 171;
            gridViewTextBoxColumn2.FieldName = "Length";
            gridViewTextBoxColumn2.HeaderText = "Uncompressed size";
            gridViewTextBoxColumn2.Name = "Length";
            gridViewTextBoxColumn2.Width = 171;
            gridViewTextBoxColumn3.FieldName = "CompressedLength";
            gridViewTextBoxColumn3.HeaderText = "Compressed size";
            gridViewTextBoxColumn3.Name = "CompressedLength";
            gridViewTextBoxColumn3.Width = 171;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(531, 264);
            this.radGridView1.TabIndex = 7;
            this.radGridView1.Text = "radGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.checkedListView);
            this.Controls.Add(this.saveZipFileButton);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.clearZipFileButton);
            this.Controls.Add(this.readZipFileButton);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1523, 1000);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.readZipFileButton, 0);
            this.Controls.SetChildIndex(this.clearZipFileButton, 0);
            this.Controls.SetChildIndex(this.radSeparator1, 0);
            this.Controls.SetChildIndex(this.saveZipFileButton, 0);
            this.Controls.SetChildIndex(this.checkedListView, 0);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveZipFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readZipFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearZipFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView checkedListView;
        private Telerik.WinControls.UI.RadButton saveZipFileButton;
        private Telerik.WinControls.UI.RadButton readZipFileButton;
        private Telerik.WinControls.UI.RadButton clearZipFileButton;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}