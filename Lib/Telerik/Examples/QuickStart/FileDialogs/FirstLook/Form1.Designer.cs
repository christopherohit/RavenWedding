using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
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
            this.tableLayoutMainPanel = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.scrollableUserControlContainer = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel3 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.btnSelectFolder = new Telerik.WinControls.UI.RadButton();
            this.textBoxFolder = new Telerik.WinControls.UI.RadTextBox();
            this.labelChooseFile = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel4 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.btnUploadFile = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.labelFieSize = new Telerik.WinControls.UI.RadLabel();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.labelSuccess = new Telerik.WinControls.UI.RadLabel();
            this.progressFileUpload = new Telerik.WinControls.UI.RadProgressBar();
            this.tableLayoutPanel2 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.labelUploadFile = new Telerik.WinControls.UI.RadLabel();
            this.labelFilesCount = new Telerik.WinControls.UI.RadLabel();
            this.radOpenFileDialog1 = new Telerik.WinControls.UI.RadOpenFileDialog();
            this.radOpenFolderDialog1 = new Telerik.WinControls.UI.RadOpenFolderDialog();
            this.radSaveFileDialog1 = new Telerik.WinControls.UI.RadSaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            this.tableLayoutMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrollableUserControlContainer)).BeginInit();
            this.scrollableUserControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelChooseFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelFieSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressFileUpload)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelUploadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelFilesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.tableLayoutMainPanel);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(398, 213);
            this.radPanelDemoHolder.Padding = new System.Windows.Forms.Padding(20);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(760, 760);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1668, 22);
            // 
            // tableLayoutMainPanel
            // 
            this.tableLayoutMainPanel.ColumnCount = 1;
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutMainPanel.Controls.Add(this.scrollableUserControlContainer, 0, 4);
            this.tableLayoutMainPanel.Controls.Add(this.radPanel1, 0, 0);
            this.tableLayoutMainPanel.Controls.Add(this.labelChooseFile, 0, 1);
            this.tableLayoutMainPanel.Controls.Add(this.radPanel2, 0, 2);
            this.tableLayoutMainPanel.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutMainPanel.Location = new System.Drawing.Point(30, 30);
            this.tableLayoutMainPanel.Name = "tableLayoutMainPanel";
            this.tableLayoutMainPanel.RowCount = 5;
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutMainPanel.Size = new System.Drawing.Size(700, 250);
            this.tableLayoutMainPanel.TabIndex = 0;
            // 
            // scrollableUserControlContainer
            // 
            this.scrollableUserControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableUserControlContainer.Location = new System.Drawing.Point(3, 238);
            this.scrollableUserControlContainer.Name = "scrollableUserControlContainer";
            // 
            // scrollableUserControlContainer.PanelContainer
            // 
            this.scrollableUserControlContainer.PanelContainer.Size = new System.Drawing.Size(692, 8);
            this.scrollableUserControlContainer.Size = new System.Drawing.Size(694, 10);
            this.scrollableUserControlContainer.TabIndex = 2;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.tableLayoutPanel3);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(3, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.radPanel1.Size = new System.Drawing.Size(694, 65);
            this.radPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 530F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel3.Controls.Add(this.btnSelectFolder, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxFolder, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(674, 45);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectFolder.Location = new System.Drawing.Point(543, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectFolder.Size = new System.Drawing.Size(128, 39);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFolder.Location = new System.Drawing.Point(3, 3);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Padding = new System.Windows.Forms.Padding(10, 12, 10, 8);
            this.textBoxFolder.ReadOnly = true;
            this.textBoxFolder.Size = new System.Drawing.Size(524, 37);
            this.textBoxFolder.TabIndex = 3;
            this.textBoxFolder.Text = "C:\\users\\admin\\desktop";
            // 
            // labelChooseFile
            // 
            this.tableLayoutMainPanel.SetColumnSpan(this.labelChooseFile, 2);
            this.labelChooseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChooseFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelChooseFile.Location = new System.Drawing.Point(3, 74);
            this.labelChooseFile.Name = "labelChooseFile";
            this.labelChooseFile.Size = new System.Drawing.Size(694, 25);
            this.labelChooseFile.TabIndex = 4;
            this.labelChooseFile.Text = "Choose a File to Upload";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.tableLayoutPanel4);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(3, 105);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.radPanel2.Size = new System.Drawing.Size(694, 92);
            this.radPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Controls.Add(this.btnUploadFile, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelFieSize, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClear, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelSuccess, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.progressFileUpload, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(674, 72);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadFile.Location = new System.Drawing.Point(3, 3);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Padding = new System.Windows.Forms.Padding(3);
            this.btnUploadFile.Size = new System.Drawing.Size(94, 28);
            this.btnUploadFile.TabIndex = 0;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(113, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3);
            this.btnCancel.Size = new System.Drawing.Size(74, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelFieSize
            // 
            this.labelFieSize.AutoSize = false;
            this.labelFieSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFieSize.Location = new System.Drawing.Point(543, 3);
            this.labelFieSize.Name = "labelFieSize";
            this.labelFieSize.Size = new System.Drawing.Size(88, 18);
            this.labelFieSize.TabIndex = 2;
            this.labelFieSize.Text = "0 bytes";
            this.labelFieSize.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(637, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "X";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = false;
            this.labelSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSuccess.Location = new System.Drawing.Point(637, 3);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(34, 28);
            this.labelSuccess.TabIndex = 4;
            this.labelSuccess.Text = "✓";
            this.labelSuccess.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labelSuccess.Visible = false;
            // 
            // progressFileUpload
            // 
            this.progressFileUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.progressFileUpload, 5);
            this.progressFileUpload.Enabled = false;
            this.progressFileUpload.Location = new System.Drawing.Point(3, 42);
            this.progressFileUpload.Name = "progressFileUpload";
            this.progressFileUpload.Size = new System.Drawing.Size(628, 22);
            this.progressFileUpload.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0634F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9366F));
            this.tableLayoutPanel2.Controls.Add(this.labelUploadFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelFilesCount, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 29);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // labelUploadFile
            // 
            this.labelUploadFile.AutoSize = false;
            this.labelUploadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUploadFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUploadFile.Location = new System.Drawing.Point(3, 3);
            this.labelUploadFile.Name = "labelUploadFile";
            this.labelUploadFile.Size = new System.Drawing.Size(507, 23);
            this.labelUploadFile.TabIndex = 0;
            this.labelUploadFile.Text = "Uploaded Files";
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.AutoSize = false;
            this.labelFilesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFilesCount.Location = new System.Drawing.Point(516, 3);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.Size = new System.Drawing.Size(175, 23);
            this.labelFilesCount.TabIndex = 1;
            this.labelFilesCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1674, 1130);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            this.tableLayoutMainPanel.ResumeLayout(false);
            this.tableLayoutMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrollableUserControlContainer)).EndInit();
            this.scrollableUserControlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelChooseFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelFieSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressFileUpload)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.labelUploadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelFilesCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DoubleBufferedTableLayoutPanel tableLayoutMainPanel;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private DoubleBufferedTableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton btnSelectFolder;
        private Telerik.WinControls.UI.RadTextBox textBoxFolder;
        private Telerik.WinControls.UI.RadLabel labelChooseFile;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private DoubleBufferedTableLayoutPanel tableLayoutPanel4;
        private Telerik.WinControls.UI.RadButton btnUploadFile;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadLabel labelFieSize;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadLabel labelSuccess;
        private Telerik.WinControls.UI.RadProgressBar progressFileUpload;
        private DoubleBufferedTableLayoutPanel tableLayoutPanel2;
        private RadLabel labelUploadFile;
        private RadLabel labelFilesCount;
        private RadScrollablePanel scrollableUserControlContainer;
        private RadOpenFileDialog radOpenFileDialog1;
        private RadOpenFolderDialog radOpenFolderDialog1;
        private RadSaveFileDialog radSaveFileDialog1;
    }
}