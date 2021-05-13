namespace Telerik.Examples.WinControls.Map.Shapefile
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
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            this.radGroupBoxOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonReserve = new Telerik.WinControls.UI.RadButton();
            this.radButtonBuyNow = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxOptions)).BeginInit();
            this.radGroupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBuyNow)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBoxOptions);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxOptions, 0);
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(0, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.ShowMiniMap = false;
            this.radMap1.ShowNavigationBar = false;
            this.radMap1.ShowScaleIndicator = false;
            this.radMap1.ShowSearchBar = false;
            this.radMap1.Size = new System.Drawing.Size(1282, 626);
            this.radMap1.TabIndex = 0;
            this.radMap1.Text = "radMap1";
            // 
            // radGroupBoxOptions
            // 
            this.radGroupBoxOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxOptions.Controls.Add(this.radButtonReserve);
            this.radGroupBoxOptions.Controls.Add(this.radButtonBuyNow);
            this.radGroupBoxOptions.HeaderText = "Purchase options";
            this.radGroupBoxOptions.Location = new System.Drawing.Point(10, 33);
            this.radGroupBoxOptions.Name = "radGroupBoxOptions";
            this.radGroupBoxOptions.Size = new System.Drawing.Size(210, 85);
            this.radGroupBoxOptions.TabIndex = 1;
            this.radGroupBoxOptions.Text = "Purchase options";
            // 
            // radButtonReserve
            // 
            this.radButtonReserve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonReserve.Location = new System.Drawing.Point(5, 57);
            this.radButtonReserve.Name = "radButtonReserve";
            this.radButtonReserve.Size = new System.Drawing.Size(200, 24);
            this.radButtonReserve.TabIndex = 0;
            this.radButtonReserve.Text = "Reserve";
            this.radButtonReserve.Click += new System.EventHandler(this.radButtonReserve_Click);
            // 
            // radButtonBuyNow
            // 
            this.radButtonBuyNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonBuyNow.Location = new System.Drawing.Point(5, 29);
            this.radButtonBuyNow.Name = "radButtonBuyNow";
            this.radButtonBuyNow.Size = new System.Drawing.Size(200, 24);
            this.radButtonBuyNow.TabIndex = 0;
            this.radButtonBuyNow.Text = "Buy Now";
            this.radButtonBuyNow.Click += new System.EventHandler(this.radButtonBuyNow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMap1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1292, 636);
            this.Controls.SetChildIndex(this.radMap1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxOptions)).EndInit();
            this.radGroupBoxOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBuyNow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxOptions;
        private Telerik.WinControls.UI.RadButton radButtonReserve;
        private Telerik.WinControls.UI.RadButton radButtonBuyNow;
    }
}