namespace Telerik.Examples.WinControls.PivotGrid.Printing
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
            this.buttonPrint = new Telerik.WinControls.UI.RadButton();
            this.buttonPrintPreview = new Telerik.WinControls.UI.RadButton();
            this.buttonPrintSettings = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrintPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrintSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.buttonPrint);
            this.settingsPanel.Controls.Add(this.buttonPrintPreview);
            this.settingsPanel.Controls.Add(this.buttonPrintSettings);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(1107, 0);
            this.settingsPanel.Size = new System.Drawing.Size(286, 831);
            this.settingsPanel.Controls.SetChildIndex(this.buttonPrintSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.buttonPrintPreview, 0);
            this.settingsPanel.Controls.SetChildIndex(this.buttonPrint, 0);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(18, 59);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(130, 24);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Print";
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Location = new System.Drawing.Point(18, 89);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(130, 24);
            this.buttonPrintPreview.TabIndex = 1;
            this.buttonPrintPreview.Text = "Print Preview";
            // 
            // buttonPrintSettings
            // 
            this.buttonPrintSettings.Location = new System.Drawing.Point(18, 119);
            this.buttonPrintSettings.Name = "buttonPrintSettings";
            this.buttonPrintSettings.Size = new System.Drawing.Size(130, 24);
            this.buttonPrintSettings.TabIndex = 1;
            this.buttonPrintSettings.Text = "Print Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1403, 841);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrintPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrintSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton buttonPrint;
        private Telerik.WinControls.UI.RadButton buttonPrintPreview;
        private Telerik.WinControls.UI.RadButton buttonPrintSettings;
    }
}