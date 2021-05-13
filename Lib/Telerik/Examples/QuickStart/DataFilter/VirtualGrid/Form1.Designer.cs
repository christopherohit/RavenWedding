namespace Telerik.Examples.WinControls.DataFilter.VirtualGrid
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.radDataFilter1 = new Telerik.WinControls.UI.RadDataFilter();
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDataFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1523, 108);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(307, 202);
            this.settingsPanel.Size = new System.Drawing.Size(307, 202);
            // 
            // radDataFilter1
            // 
            this.radDataFilter1.Dock = System.Windows.Forms.DockStyle.Left;        
            this.radDataFilter1.Location = new System.Drawing.Point(0, 0);
            this.radDataFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.radDataFilter1.Name = "radDataFilter1";
            this.radDataFilter1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.radDataFilter1.Size = new System.Drawing.Size(572, 1083);
            this.radDataFilter1.TabIndex = 3;
            this.radDataFilter1.TreeIndent = 26;
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Location = new System.Drawing.Point(572, 0);
            this.radVirtualGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.radVirtualGrid1.MasterViewInfo.ColumnWidth = 164;
            this.radVirtualGrid1.MasterViewInfo.MinColumnWidth = 7;
            this.radVirtualGrid1.MasterViewInfo.MinRowHeight = 7;
            this.radVirtualGrid1.MasterViewInfo.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(1764, 1083);
            this.radVirtualGrid1.TabIndex = 4;
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radChartView1.Location = new System.Drawing.Point(0, 1083);
            this.radChartView1.Margin = new System.Windows.Forms.Padding(4);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(2336, 369);
            this.radChartView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radVirtualGrid1);
            this.Controls.Add(this.radDataFilter1);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2349, 1464);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.radDataFilter1, 0);
            this.Controls.SetChildIndex(this.radVirtualGrid1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDataFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDataFilter radDataFilter1;
        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}