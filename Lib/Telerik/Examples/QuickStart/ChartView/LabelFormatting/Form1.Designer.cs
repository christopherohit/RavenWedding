using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
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
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 19);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radCheckBox1);
            this.settingsPanel.PanelContainer.Controls.Add(this.radCheckBox2);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(304, 832);
            this.settingsPanel.Size = new System.Drawing.Size(304, 832);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Size = new System.Drawing.Size(1217, 786);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Title = "Stock Index";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Stock Index";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI Light", 20F);
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 56);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(82, 18);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "Show Labels";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox2.Location = new System.Drawing.Point(10, 96);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(154, 18);
            this.radCheckBox2.TabIndex = 2;
            this.radCheckBox2.Text = "Enable custom appearance";
            this.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1227, 796);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}