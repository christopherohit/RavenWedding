using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ChartView.InverseAxes
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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea3 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartViewWellsDepth = new Telerik.WinControls.UI.RadChartView();
            this.radCheckBoxDryHoles = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxNaturalGas = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxCrudeOil = new Telerik.WinControls.UI.RadCheckBox();
            this.customTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.customTableLayoutPanel2 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radChartViewAvgVsMaxDepth = new Telerik.WinControls.UI.RadChartView();
            this.radChartViewDepthVsResource = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewWellsDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDryHoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxNaturalGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCrudeOil)).BeginInit();
            this.customTableLayoutPanel1.SuspendLayout();
            this.customTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewAvgVsMaxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewDepthVsResource)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxCrudeOil);
            this.settingsPanel.Controls.Add(this.radCheckBoxNaturalGas);
            this.settingsPanel.Controls.Add(this.radCheckBoxDryHoles);
            this.settingsPanel.Location = new System.Drawing.Point(1564, 3);
            this.settingsPanel.Size = new System.Drawing.Size(304, 832);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxDryHoles, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxNaturalGas, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxCrudeOil, 0);
            // 
            // radChartViewWellsDepth
            // 
            this.radChartViewWellsDepth.AreaDesign = cartesianArea1;
            this.radChartViewWellsDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartViewWellsDepth.Location = new System.Drawing.Point(3, 3);
            this.radChartViewWellsDepth.MinimumSize = new System.Drawing.Size(680, 420);
            this.radChartViewWellsDepth.Name = "radChartViewWellsDepth";
            this.radChartViewWellsDepth.RootElement.MinSize = new System.Drawing.Size(680, 420);
            this.radChartViewWellsDepth.ShowGrid = false;
            this.radChartViewWellsDepth.ShowTitle = true;
            this.radChartViewWellsDepth.Size = new System.Drawing.Size(1865, 754);
            this.radChartViewWellsDepth.TabIndex = 1;
            this.radChartViewWellsDepth.Text = "radChartView1";
            this.radChartViewWellsDepth.Title = "U.S. Average Depth of Wells Drilled";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewWellsDepth.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "U.S. Average Depth of Wells Drilled";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewWellsDepth.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI Light", 20F);
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewWellsDepth.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radCheckBoxDryHoles
            // 
            this.radCheckBoxDryHoles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxDryHoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxDryHoles.Location = new System.Drawing.Point(10, 5);
            this.radCheckBoxDryHoles.Name = "radCheckBoxDryHoles";
            this.radCheckBoxDryHoles.Size = new System.Drawing.Size(69, 18);
            this.radCheckBoxDryHoles.TabIndex = 1;
            this.radCheckBoxDryHoles.Text = "Dry Holes";
            this.radCheckBoxDryHoles.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxDryHoles.ButtonElement.CheckMarkPrimitive.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            // 
            // radCheckBoxNaturalGas
            // 
            this.radCheckBoxNaturalGas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxNaturalGas.Location = new System.Drawing.Point(10, 30);
            this.radCheckBoxNaturalGas.Name = "radCheckBoxNaturalGas";
            this.radCheckBoxNaturalGas.Size = new System.Drawing.Size(79, 18);
            this.radCheckBoxNaturalGas.TabIndex = 2;
            this.radCheckBoxNaturalGas.Text = "Natural Gas";
            this.radCheckBoxNaturalGas.ButtonElement.CheckMarkPrimitive.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            // 
            // radCheckBoxCrudeOil
            // 
            this.radCheckBoxCrudeOil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxCrudeOil.Location = new System.Drawing.Point(10, 55);
            this.radCheckBoxCrudeOil.Name = "radCheckBoxCrudeOil";
            this.radCheckBoxCrudeOil.Size = new System.Drawing.Size(67, 18);
            this.radCheckBoxCrudeOil.TabIndex = 2;
            this.radCheckBoxCrudeOil.Text = "Crude Oil";
            this.radCheckBoxCrudeOil.ButtonElement.CheckMarkPrimitive.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            // 
            // customTableLayoutPanel1
            // 
            this.customTableLayoutPanel1.ColumnCount = 1;
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel1.Controls.Add(this.customTableLayoutPanel2, 0, 1);
            this.customTableLayoutPanel1.Controls.Add(this.radChartViewWellsDepth, 0, 0);
            this.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.customTableLayoutPanel1.Name = "customTableLayoutPanel1";
            this.customTableLayoutPanel1.RowCount = 2;
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.customTableLayoutPanel1.Size = new System.Drawing.Size(1871, 1086);
            this.customTableLayoutPanel1.TabIndex = 2;
            // 
            // customTableLayoutPanel2
            // 
            this.customTableLayoutPanel2.ColumnCount = 2;
            this.customTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customTableLayoutPanel2.Controls.Add(this.radChartViewAvgVsMaxDepth, 0, 0);
            this.customTableLayoutPanel2.Controls.Add(this.radChartViewDepthVsResource, 1, 0);
            this.customTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTableLayoutPanel2.Location = new System.Drawing.Point(3, 763);
            this.customTableLayoutPanel2.Name = "customTableLayoutPanel2";
            this.customTableLayoutPanel2.RowCount = 1;
            this.customTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customTableLayoutPanel2.Size = new System.Drawing.Size(1865, 320);
            this.customTableLayoutPanel2.TabIndex = 0;
            // 
            // radChartViewAvgVsMaxDepth
            // 
            this.radChartViewAvgVsMaxDepth.AreaDesign = cartesianArea2;
            this.radChartViewAvgVsMaxDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartViewAvgVsMaxDepth.Location = new System.Drawing.Point(3, 3);
            this.radChartViewAvgVsMaxDepth.Name = "radChartViewAvgVsMaxDepth";
            this.radChartViewAvgVsMaxDepth.ShowGrid = false;
            this.radChartViewAvgVsMaxDepth.ShowTitle = true;
            this.radChartViewAvgVsMaxDepth.Size = new System.Drawing.Size(926, 314);
            this.radChartViewAvgVsMaxDepth.TabIndex = 0;
            this.radChartViewAvgVsMaxDepth.Text = "radChartView2";
            this.radChartViewAvgVsMaxDepth.Title = "Average vs Maximum Depth Drilled";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewAvgVsMaxDepth.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Average vs Maximum Depth Drilled";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewAvgVsMaxDepth.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI Light", 20F);
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewAvgVsMaxDepth.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radChartViewDepthVsResource
            // 
            this.radChartViewDepthVsResource.AreaDesign = cartesianArea3;
            this.radChartViewDepthVsResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartViewDepthVsResource.Location = new System.Drawing.Point(935, 3);
            this.radChartViewDepthVsResource.Name = "radChartViewDepthVsResource";
            this.radChartViewDepthVsResource.ShowGrid = false;
            this.radChartViewDepthVsResource.ShowTitle = true;
            this.radChartViewDepthVsResource.Size = new System.Drawing.Size(927, 314);
            this.radChartViewDepthVsResource.TabIndex = 1;
            this.radChartViewDepthVsResource.Text = "radChartView3";
            this.radChartViewDepthVsResource.Title = "Depths by Resource Type";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewDepthVsResource.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Depths by Resource Type";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewDepthVsResource.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI Light", 20F);
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartViewDepthVsResource.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.customTableLayoutPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1881, 1096);
            this.Controls.SetChildIndex(this.customTableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewWellsDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDryHoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxNaturalGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCrudeOil)).EndInit();
            this.customTableLayoutPanel1.ResumeLayout(false);
            this.customTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewAvgVsMaxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewDepthVsResource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBox radCheckBoxCrudeOil;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxNaturalGas;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxDryHoles;
        private Telerik.WinControls.UI.RadChartView radChartViewWellsDepth;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel customTableLayoutPanel1;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel customTableLayoutPanel2;
        private RadChartView radChartViewAvgVsMaxDepth;
        private RadChartView radChartViewDepthVsResource;
    }
}