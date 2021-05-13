namespace Telerik.Examples.WinControls.Barcode.FirstLook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radBarcode1 = new Telerik.WinControls.UI.RadBarcode();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBarcode1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1081, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 788);
            this.settingsPanel.Size = new System.Drawing.Size(200, 788);
            // 
            // radBarcode1
            // 
            this.radBarcode1.AutoSize = true;
            this.radBarcode1.Location = new System.Drawing.Point(990, 738);
            this.radBarcode1.Name = "radBarcode1";
            this.radBarcode1.Size = new System.Drawing.Size(2, 2);
            this.radBarcode1.TabIndex = 1;
            this.radBarcode1.Text = "radBarcode1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.radBarcode1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2349, 1464);
            this.Controls.SetChildIndex(this.radBarcode1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBarcode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadBarcode radBarcode1;
    }
}
