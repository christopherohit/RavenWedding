namespace Telerik.Examples.WinControls.ZipLibrary.CompressStream
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
            this.uncompressedTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.compressedTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.uncompressedLabel = new Telerik.WinControls.UI.RadLabel();
            this.compressedLabel = new Telerik.WinControls.UI.RadLabel();
            this.compressButton = new Telerik.WinControls.UI.RadButton();
            this.compressionMethodsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncompressedTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressedTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncompressedLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressedLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressionMethodsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.compressionMethodsDropDownList);
            this.settingsPanel.Location = new System.Drawing.Point(1280, 19);
            this.settingsPanel.Controls.SetChildIndex(this.compressionMethodsDropDownList, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            // 
            // uncompressedTextBoxControl
            // 
            this.uncompressedTextBoxControl.Location = new System.Drawing.Point(0, 3);
            this.uncompressedTextBoxControl.Multiline = true;
            this.uncompressedTextBoxControl.Name = "uncompressedTextBoxControl";
            this.uncompressedTextBoxControl.Size = new System.Drawing.Size(400, 200);
            this.uncompressedTextBoxControl.TabIndex = 2;
            // 
            // compressedTextBoxControl
            // 
            this.compressedTextBoxControl.Location = new System.Drawing.Point(0, 253);
            this.compressedTextBoxControl.Multiline = true;
            this.compressedTextBoxControl.Name = "compressedTextBoxControl";
            this.compressedTextBoxControl.Size = new System.Drawing.Size(400, 200);
            this.compressedTextBoxControl.TabIndex = 3;
            // 
            // uncompressedLabel
            // 
            this.uncompressedLabel.Location = new System.Drawing.Point(3, 209);
            this.uncompressedLabel.Name = "uncompressedLabel";
            this.uncompressedLabel.Size = new System.Drawing.Size(114, 18);
            this.uncompressedLabel.TabIndex = 4;
            this.uncompressedLabel.Text = "Uuncompressed size: ";
            // 
            // compressedLabel
            // 
            this.compressedLabel.Location = new System.Drawing.Point(3, 459);
            this.compressedLabel.Name = "compressedLabel";
            this.compressedLabel.Size = new System.Drawing.Size(96, 18);
            this.compressedLabel.TabIndex = 5;
            this.compressedLabel.Text = "Compressed size: ";
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(290, 216);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(110, 24);
            this.compressButton.TabIndex = 6;
            this.compressButton.Text = "Compress";
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // compressionMethodsDropDownList
            // 
            this.compressionMethodsDropDownList.AllowShowFocusCues = false;
            this.compressionMethodsDropDownList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compressionMethodsDropDownList.AutoCompleteDisplayMember = null;
            this.compressionMethodsDropDownList.AutoCompleteValueMember = null;
            this.compressionMethodsDropDownList.DescriptionTextMember = null;
            this.compressionMethodsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.compressionMethodsDropDownList.Location = new System.Drawing.Point(10, 56);
            this.compressionMethodsDropDownList.Name = "compressionMethodsDropDownList";
            this.compressionMethodsDropDownList.Size = new System.Drawing.Size(210, 20);
            this.compressionMethodsDropDownList.TabIndex = 1;
            this.compressionMethodsDropDownList.Text = "radDropDownList1";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(96, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Compression level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.compressedLabel);
            this.Controls.Add(this.uncompressedLabel);
            this.Controls.Add(this.compressedTextBoxControl);
            this.Controls.Add(this.uncompressedTextBoxControl);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1523, 1000);
            this.Controls.SetChildIndex(this.uncompressedTextBoxControl, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.compressedTextBoxControl, 0);
            this.Controls.SetChildIndex(this.uncompressedLabel, 0);
            this.Controls.SetChildIndex(this.compressedLabel, 0);
            this.Controls.SetChildIndex(this.compressButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncompressedTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressedTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncompressedLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressedLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressionMethodsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl uncompressedTextBoxControl;
        private Telerik.WinControls.UI.RadTextBoxControl compressedTextBoxControl;
        private Telerik.WinControls.UI.RadLabel uncompressedLabel;
        private Telerik.WinControls.UI.RadLabel compressedLabel;
        private Telerik.WinControls.UI.RadButton compressButton;
        private Telerik.WinControls.UI.RadDropDownList compressionMethodsDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}