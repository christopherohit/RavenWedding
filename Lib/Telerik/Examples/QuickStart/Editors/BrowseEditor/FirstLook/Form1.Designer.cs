namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
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
            this.filesHolderPanel = new Telerik.WinControls.UI.RadPanel();
            this.uploadFilesBtn = new Telerik.WinControls.UI.RadButton();
            this.addNewBtn = new Telerik.WinControls.UI.RadButton();
            this.filePathUserControl3 = new Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook.FilePathUserControl();
            this.filePathUserControl2 = new Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook.FilePathUserControl();
            this.filePathUserControl1 = new Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook.FilePathUserControl();
            this.headerLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesHolderPanel)).BeginInit();
            this.filesHolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadFilesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.filesHolderPanel);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(1634, 1126);
            // 
            // settingsPanel
            // 
            // 
            // filesHolderPanel
            // 
            this.filesHolderPanel.Controls.Add(this.uploadFilesBtn);
            this.filesHolderPanel.Controls.Add(this.addNewBtn);
            this.filesHolderPanel.Controls.Add(this.filePathUserControl3);
            this.filesHolderPanel.Controls.Add(this.filePathUserControl2);
            this.filesHolderPanel.Controls.Add(this.filePathUserControl1);
            this.filesHolderPanel.Controls.Add(this.headerLabel);
            this.filesHolderPanel.Location = new System.Drawing.Point(101, 202);
            this.filesHolderPanel.Name = "filesHolderPanel";
            this.filesHolderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.filesHolderPanel.Size = new System.Drawing.Size(500, 520);
            this.filesHolderPanel.TabIndex = 0;
            // 
            // uploadFilesBtn
            // 
            this.uploadFilesBtn.Enabled = false;
            this.uploadFilesBtn.Location = new System.Drawing.Point(343, 468);
            this.uploadFilesBtn.Name = "uploadFilesBtn";
            this.uploadFilesBtn.Size = new System.Drawing.Size(88, 28);
            this.uploadFilesBtn.TabIndex = 7;
            this.uploadFilesBtn.Text = "Upload files";
            this.uploadFilesBtn.Click += new System.EventHandler(this.UploadFilesBtn_Click);
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(245, 468);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(88, 28);
            this.addNewBtn.TabIndex = 6;
            this.addNewBtn.Tag = "";
            this.addNewBtn.Text = "Add more";
            this.addNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // filePathUserControl3
            // 
            this.filePathUserControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePathUserControl3.Location = new System.Drawing.Point(5, 167);
            this.filePathUserControl3.Name = "filePathUserControl3";
            this.filePathUserControl3.Size = new System.Drawing.Size(490, 56);
            this.filePathUserControl3.TabIndex = 9;
            // 
            // filePathUserControl2
            // 
            this.filePathUserControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePathUserControl2.Location = new System.Drawing.Point(5, 111);
            this.filePathUserControl2.Name = "filePathUserControl2";
            this.filePathUserControl2.Size = new System.Drawing.Size(490, 56);
            this.filePathUserControl2.TabIndex = 8;
            // 
            // filePathUserControl1
            // 
            this.filePathUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePathUserControl1.Location = new System.Drawing.Point(5, 55);
            this.filePathUserControl1.Name = "filePathUserControl1";
            this.filePathUserControl1.Size = new System.Drawing.Size(490, 56);
            this.filePathUserControl1.TabIndex = 4;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = false;
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.headerLabel.Location = new System.Drawing.Point(5, 5);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(490, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Select Files to Upload";
            this.headerLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1634, 1126);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesHolderPanel)).EndInit();
            this.filesHolderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadFilesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel filesHolderPanel;
        private Telerik.WinControls.UI.RadLabel headerLabel;
        private Telerik.WinControls.UI.RadButton uploadFilesBtn;
        private Telerik.WinControls.UI.RadButton addNewBtn;
        private FilePathUserControl filePathUserControl1;
        private FilePathUserControl filePathUserControl2;
        private FilePathUserControl filePathUserControl3;
    }
}