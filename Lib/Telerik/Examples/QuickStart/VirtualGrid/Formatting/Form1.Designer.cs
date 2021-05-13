namespace Telerik.Examples.WinControls.VirtualGrid.Formatting
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
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Size = new System.Drawing.Size(230, 536);
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.AllowFiltering = false;
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.ColumnCount = 0;
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Location = new System.Drawing.Point(0, 0);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.RowCount = 0;
            this.radVirtualGrid1.Size = new System.Drawing.Size(1871, 1086);
            this.radVirtualGrid1.StandardTab = false;
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Text = "radVirtualGrid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1881, 1096);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
    }
}