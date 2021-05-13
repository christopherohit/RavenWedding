namespace Telerik.Examples.WinControls.Barcode.DataMatrix
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
            this.radBarcode1 = new Telerik.WinControls.UI.RadBarcode();
            this.encodationLabel = new Telerik.WinControls.UI.RadLabel();
            this.symbolSizeLabel = new Telerik.WinControls.UI.RadLabel();
            this.encodingLabel = new Telerik.WinControls.UI.RadLabel();
            this.symbolSizeDdl = new Telerik.WinControls.UI.RadDropDownList();
            this.encodationDdl = new Telerik.WinControls.UI.RadDropDownList();
            this.encodingDdl = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBarcode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolSizeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolSizeDdl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodationDdl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingDdl)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radBarcode1);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(404, 285);
            this.radPanelDemoHolder.Padding = new System.Windows.Forms.Padding(100);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(506, 412);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.Location = new System.Drawing.Point(1044, 90);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.symbolSizeDdl);
            this.settingsPanel.PanelContainer.Controls.Add(this.encodationDdl);
            this.settingsPanel.PanelContainer.Controls.Add(this.encodingDdl);
            this.settingsPanel.PanelContainer.Controls.Add(this.symbolSizeLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.encodationLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.encodingLabel);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(3, 573);
            // 
            // radBarcode1
            // 
            this.radBarcode1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radBarcode1.Location = new System.Drawing.Point(152, 104);
            this.radBarcode1.Name = "radBarcode1";
            this.radBarcode1.Size = new System.Drawing.Size(203, 203);
            this.radBarcode1.TabIndex = 0;
            this.radBarcode1.Text = "radBarcode1";
            // 
            // encodationLabel
            // 
            this.encodationLabel.Location = new System.Drawing.Point(3, 3);
            this.encodationLabel.Name = "encodationLabel";
            this.encodationLabel.Size = new System.Drawing.Size(65, 18);
            this.encodationLabel.TabIndex = 3;
            this.encodationLabel.Text = "Encodation:";
            // 
            // symbolSizeLabel
            // 
            this.symbolSizeLabel.Location = new System.Drawing.Point(3, 57);
            this.symbolSizeLabel.Name = "symbolSizeLabel";
            this.symbolSizeLabel.Size = new System.Drawing.Size(69, 18);
            this.symbolSizeLabel.TabIndex = 4;
            this.symbolSizeLabel.Text = "Symbol Size:";
            // 
            // encodingLabel
            // 
            this.encodingLabel.Location = new System.Drawing.Point(3, 111);
            this.encodingLabel.Name = "encodingLabel";
            this.encodingLabel.Size = new System.Drawing.Size(55, 18);
            this.encodingLabel.TabIndex = 5;
            this.encodingLabel.Text = "Encoding:";
            // 
            // symbolSizeDdl
            // 
            this.symbolSizeDdl.DropDownAnimationEnabled = false;
            this.symbolSizeDdl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.symbolSizeDdl.Location = new System.Drawing.Point(3, 81);
            this.symbolSizeDdl.Name = "symbolSizeDdl";
            this.symbolSizeDdl.Size = new System.Drawing.Size(194, 20);
            this.symbolSizeDdl.TabIndex = 7;
            this.symbolSizeDdl.Text = "symbolSizeDdl";
            // 
            // encodationDdl
            // 
            this.encodationDdl.DropDownAnimationEnabled = false;
            this.encodationDdl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.encodationDdl.Location = new System.Drawing.Point(3, 27);
            this.encodationDdl.Name = "encodationDdl";
            this.encodationDdl.Size = new System.Drawing.Size(194, 20);
            this.encodationDdl.TabIndex = 6;
            this.encodationDdl.Text = "encodationDdl";
            // 
            // encodingDdl
            // 
            this.encodingDdl.DropDownAnimationEnabled = false;
            this.encodingDdl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.encodingDdl.Location = new System.Drawing.Point(3, 135);
            this.encodingDdl.Name = "encodingDdl";
            this.encodingDdl.Size = new System.Drawing.Size(194, 20);
            this.encodingDdl.TabIndex = 8;
            this.encodingDdl.Text = "encodingDdl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1326, 705);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBarcode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolSizeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolSizeDdl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodationDdl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingDdl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadBarcode radBarcode1;
        private Telerik.WinControls.UI.RadDropDownList encodationDdl;
        private Telerik.WinControls.UI.RadDropDownList symbolSizeDdl;
        private Telerik.WinControls.UI.RadDropDownList encodingDdl;
        private Telerik.WinControls.UI.RadLabel encodationLabel;
        private Telerik.WinControls.UI.RadLabel symbolSizeLabel;
        private Telerik.WinControls.UI.RadLabel encodingLabel;
    }
}