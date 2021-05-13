namespace Telerik.Examples.WinControls.PdfViewer.DigitalSignatures
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.unknownSignatureRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.invalidSignatureRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.openDocumentButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unknownSignatureRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidSignatureRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDocumentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.openDocumentButton);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Size = new System.Drawing.Size(230, 192);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.openDocumentButton, 0);
            // 
            // radPdfViewerNavigator1
            // 
            this.radPdfViewerNavigator1.AssociatedViewer = this.radPdfViewer1;
            this.radPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPdfViewerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1";
            this.radPdfViewerNavigator1.Size = new System.Drawing.Size(1541, 38);
            this.radPdfViewerNavigator1.TabIndex = 2;
            this.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1";
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewer1.Location = new System.Drawing.Point(0, 38);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(1541, 757);
            this.radPdfViewer1.TabIndex = 3;
            this.radPdfViewer1.Text = "radPdfViewer1";
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.unknownSignatureRadioButton);
            this.radGroupBox1.Controls.Add(this.invalidSignatureRadioButton);
            this.radGroupBox1.HeaderText = "Load Document with:";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 89);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Load Document with:";
            // 
            // unknownSignatureRadioButton
            // 
            this.unknownSignatureRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unknownSignatureRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unknownSignatureRadioButton.Location = new System.Drawing.Point(5, 60);
            this.unknownSignatureRadioButton.Name = "unknownSignatureRadioButton";
            this.unknownSignatureRadioButton.Size = new System.Drawing.Size(118, 18);
            this.unknownSignatureRadioButton.TabIndex = 6;
            this.unknownSignatureRadioButton.Text = "Unknown Signature";
            this.unknownSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // invalidSignatureRadioButton
            // 
            this.invalidSignatureRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invalidSignatureRadioButton.Location = new System.Drawing.Point(5, 32);
            this.invalidSignatureRadioButton.Name = "invalidSignatureRadioButton";
            this.invalidSignatureRadioButton.Size = new System.Drawing.Size(104, 18);
            this.invalidSignatureRadioButton.TabIndex = 5;
            this.invalidSignatureRadioButton.TabStop = false;
            this.invalidSignatureRadioButton.Text = "Invalid Signature";
            // 
            // openDocumentButton
            // 
            this.openDocumentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openDocumentButton.Location = new System.Drawing.Point(10, 127);
            this.openDocumentButton.Name = "openDocumentButton";
            this.openDocumentButton.Size = new System.Drawing.Size(210, 24);
            this.openDocumentButton.TabIndex = 7;
            this.openDocumentButton.Text = "Open your document";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPdfViewer1);
            this.Controls.Add(this.radPdfViewerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1551, 805);
            this.Controls.SetChildIndex(this.radPdfViewerNavigator1, 0);
            this.Controls.SetChildIndex(this.radPdfViewer1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unknownSignatureRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidSignatureRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDocumentButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadPdfViewerNavigator radPdfViewerNavigator1;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton openDocumentButton;
        private Telerik.WinControls.UI.RadRadioButton unknownSignatureRadioButton;
        private Telerik.WinControls.UI.RadRadioButton invalidSignatureRadioButton;
    }
}