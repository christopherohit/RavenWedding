using System.Drawing;
namespace Telerik.Examples.WinControls.RangeSelector.MultipleAxes
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
            this.radRangeSelector1 = new Telerik.WinControls.UI.RadRangeSelector();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radRangeSelector2 = new Telerik.WinControls.UI.RadRangeSelector();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRangeSelector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRangeSelector2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(860, 16);
            // 
            // radRangeSelector1
            // 
            this.radRangeSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radRangeSelector1.Location = new System.Drawing.Point(0, 0);
            this.radRangeSelector1.Name = "radRangeSelector1";
            this.radRangeSelector1.Size = new System.Drawing.Size(1158, 150);
            this.radRangeSelector1.TabIndex = 0;
            this.radRangeSelector1.Text = "radRangeSelector1";
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 150);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(1158, 390);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            // 
            // radRangeSelector2
            // 
            this.radRangeSelector2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radRangeSelector2.Location = new System.Drawing.Point(0, 540);
            this.radRangeSelector2.Name = "radRangeSelector2";
            this.radRangeSelector2.Size = new System.Drawing.Size(1158, 158);
            this.radRangeSelector2.TabIndex = 0;
            this.radRangeSelector2.Text = "radRangeSelector2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(780, 350);
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.radRangeSelector2);
            this.Controls.Add(this.radRangeSelector1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1168, 708);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radRangeSelector1, 0);
            this.Controls.SetChildIndex(this.radRangeSelector2, 0);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRangeSelector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRangeSelector2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRangeSelector radRangeSelector1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadRangeSelector radRangeSelector2;
    }
}