namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.RightToLeft
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
            this.radToggleButtonUseRTL = new Telerik.WinControls.UI.RadToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButtonUseRTL)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radToggleButtonUseRTL);
            this.settingsPanel.Controls.SetChildIndex(this.radToggleButtonUseRTL, 0);
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Location = new System.Drawing.Point(24, 22);
            this.radVirtualGrid1.MasterViewInfo.RowCount = 1000;
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(870, 512);
            this.radVirtualGrid1.TabIndex = 0;
            this.radVirtualGrid1.Text = "radVirtualGrid1";
            this.radVirtualGrid1.CellValueNeeded += new Telerik.WinControls.UI.VirtualGridCellValueNeededEventHandler(this.radVirtualGrid1_CellValueNeeded);
            this.radVirtualGrid1.CellFormatting += new Telerik.WinControls.UI.VirtualGridCellElementEventHandler(this.radVirtualGrid1_CellFormatting);
            this.radVirtualGrid1.SortChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_SortChanged);
            this.radVirtualGrid1.FilterChanged += new Telerik.WinControls.UI.VirtualGridEventHandler(this.radVirtualGrid1_FilterChanged);
            // 
            // radToggleButtonUseRTL
            // 
            this.radToggleButtonUseRTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radToggleButtonUseRTL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radToggleButtonUseRTL.Location = new System.Drawing.Point(10, 33);
            this.radToggleButtonUseRTL.Name = "radToggleButtonUseRTL";
            this.radToggleButtonUseRTL.Size = new System.Drawing.Size(210, 24);
            this.radToggleButtonUseRTL.TabIndex = 1;
            this.radToggleButtonUseRTL.Text = "Use RTL";
            this.radToggleButtonUseRTL.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
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
            ((System.ComponentModel.ISupportInitialize)(this.radToggleButtonUseRTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadToggleButton radToggleButtonUseRTL;
    }
}