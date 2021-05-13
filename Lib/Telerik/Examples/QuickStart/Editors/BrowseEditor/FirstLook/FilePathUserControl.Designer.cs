namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
{
    partial class FilePathUserControl
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
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radBrowseEditor1 = new Telerik.WinControls.UI.RadBrowseEditor();
            this.deleteBtn = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHolderPanel = new System.Windows.Forms.Panel();
            this.fileLabel = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            this.labelHolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.33155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.83422F));
            this.tableLayoutPanel1.Controls.Add(this.radBrowseEditor1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radSeparator1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelHolderPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radBrowseEditor1
            // 
            this.radBrowseEditor1.AutoSize = false;
            this.radBrowseEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radBrowseEditor1.Location = new System.Drawing.Point(61, 3);
            this.radBrowseEditor1.Name = "radBrowseEditor1";
            this.radBrowseEditor1.Size = new System.Drawing.Size(335, 24);
            this.radBrowseEditor1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Location = new System.Drawing.Point(402, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(25, 24);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "radButton1";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // radSeparator1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.radSeparator1, 2);
            this.radSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSeparator1.Location = new System.Drawing.Point(61, 41);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(366, 4);
            this.radSeparator1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(61, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 2);
            this.panel2.TabIndex = 5;
            // 
            // labelHolderPanel
            // 
            this.labelHolderPanel.Controls.Add(this.fileLabel);
            this.labelHolderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHolderPanel.Location = new System.Drawing.Point(61, 33);
            this.labelHolderPanel.Name = "labelHolderPanel";
            this.labelHolderPanel.Size = new System.Drawing.Size(335, 2);
            this.labelHolderPanel.TabIndex = 4;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = false;
            this.fileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLabel.Location = new System.Drawing.Point(0, 0);
            this.fileLabel.MinimumSize = new System.Drawing.Size(0, 4);
            this.fileLabel.Name = "fileLabel";
            // 
            // 
            // 
            this.fileLabel.RootElement.MinSize = new System.Drawing.Size(0, 4);
            this.fileLabel.Size = new System.Drawing.Size(335, 4);
            this.fileLabel.TabIndex = 6;
            this.fileLabel.Visible = false;
            // 
            // FilePathUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilePathUserControl";
            this.Size = new System.Drawing.Size(490, 56);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            this.labelHolderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadBrowseEditor radBrowseEditor1;
        private Telerik.WinControls.UI.RadButton deleteBtn;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel labelHolderPanel;
        private Telerik.WinControls.UI.RadLabel fileLabel;
    }
}
