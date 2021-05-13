namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Radar
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
            Telerik.WinControls.UI.PolarAxis polarAxis1 = new Telerik.WinControls.UI.PolarAxis();
            Telerik.WinControls.UI.PolarAxis polarAxis2 = new Telerik.WinControls.UI.PolarAxis();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorPointRadius = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorLineWidth = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 52);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(238, 284);
            this.settingsPanel.Size = new System.Drawing.Size(238, 284);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Polar;
            polarAxis1.IsPrimary = true;
            polarAxis2.IsPrimary = true;
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            polarAxis1,
            polarAxis2});
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.MinimumSize = new System.Drawing.Size(280, 320);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(280, 320);
            this.radChartView1.Size = new System.Drawing.Size(1230, 786);
            this.radChartView1.TabIndex = 1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radSpinEditorPointRadius);
            this.radGroupBox1.Controls.Add(this.radSpinEditorLineWidth);
            this.radGroupBox1.HeaderText = "Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 44);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(228, 126);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Settings";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 64);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Point size";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Line width";
            // 
            // radSpinEditorPointRadius
            // 
            this.radSpinEditorPointRadius.Location = new System.Drawing.Point(78, 64);
            this.radSpinEditorPointRadius.Name = "radSpinEditorPointRadius";
            this.radSpinEditorPointRadius.NullableValue = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // 
            // 
            this.radSpinEditorPointRadius.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorPointRadius.Size = new System.Drawing.Size(145, 20);
            this.radSpinEditorPointRadius.TabIndex = 0;
            this.radSpinEditorPointRadius.TabStop = false;
            this.radSpinEditorPointRadius.Tag = "Right";
            this.radSpinEditorPointRadius.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // radSpinEditorLineWidth
            // 
            this.radSpinEditorLineWidth.Location = new System.Drawing.Point(78, 22);
            this.radSpinEditorLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorLineWidth.Name = "radSpinEditorLineWidth";
            this.radSpinEditorLineWidth.NullableValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // 
            // 
            this.radSpinEditorLineWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorLineWidth.Size = new System.Drawing.Size(145, 20);
            this.radSpinEditorLineWidth.TabIndex = 0;
            this.radSpinEditorLineWidth.TabStop = false;
            this.radSpinEditorLineWidth.Tag = "Right";
            this.radSpinEditorLineWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(280, 320);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1240, 796);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorLineWidth;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorPointRadius;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}