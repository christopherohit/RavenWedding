namespace Telerik.Examples.WinControls.Map.BingSearch
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
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(24, 22);
            this.radMap1.Name = "radMap1";
            this.radMap1.ShowLegend = false;
            this.radMap1.MapElement.NavigationBarLocation = Telerik.WinControls.UI.MapNavigationBarLocation.BottomCenter;
            this.radMap1.Size = new System.Drawing.Size(859, 521);
            this.radMap1.TabIndex = 0;
            this.radMap1.Text = "radMap1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMap1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1530, 1068);
            this.Controls.SetChildIndex(this.radMap1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
    }
}