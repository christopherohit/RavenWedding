namespace Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument
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
            this.radPdfViewerNavigator1 = new Telerik.WinControls.UI.RadPdfViewerNavigator();
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            this.openDocumentButton = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.downloadCertificateButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDocumentButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadCertificateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Size = new System.Drawing.Size(230, 192);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            // 
            // radPdfViewerNavigator1
            // 
            this.radPdfViewerNavigator1.AssociatedViewer = this.radPdfViewer1;
            this.radPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPdfViewerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1";
            this.radPdfViewerNavigator1.Size = new System.Drawing.Size(1295, 38);
            this.radPdfViewerNavigator1.TabIndex = 2;
            this.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1";
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewer1.Location = new System.Drawing.Point(0, 38);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(1295, 991);
            this.radPdfViewer1.TabIndex = 3;
            this.radPdfViewer1.Text = "radPdfViewer1";
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // openDocumentButton
            // 
            this.openDocumentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openDocumentButton.Location = new System.Drawing.Point(5, 26);
            this.openDocumentButton.Name = "openDocumentButton";
            this.openDocumentButton.Size = new System.Drawing.Size(200, 26);
            this.openDocumentButton.TabIndex = 0;
            this.openDocumentButton.Text = "Open your document";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.downloadCertificateButton);
            this.radGroupBox1.Controls.Add(this.openDocumentButton);
            this.radGroupBox1.HeaderText = "Load Document with:";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 89);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Load Document with:";
            // 
            // downloadCertificateButton
            // 
            this.downloadCertificateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.downloadCertificateButton.Location = new System.Drawing.Point(5, 58);
            this.downloadCertificateButton.Name = "downloadCertificateButton";
            this.downloadCertificateButton.Size = new System.Drawing.Size(200, 24);
            this.downloadCertificateButton.TabIndex = 0;
            this.downloadCertificateButton.Text = "Download test certificate";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.AutoSize = false;
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(10, 128);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(210, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Tag = "NotAutoSized";
            this.radLabel1.Text = "Certificate Password: johndoe";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPdfViewer1);
            this.Controls.Add(this.radPdfViewerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1305, 1039);
            this.Controls.SetChildIndex(this.radPdfViewerNavigator1, 0);
            this.Controls.SetChildIndex(this.radPdfViewer1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDocumentButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadCertificateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadPdfViewerNavigator radPdfViewerNavigator1;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton openDocumentButton;
        private Telerik.WinControls.UI.RadButton downloadCertificateButton;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}