namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Funnel
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
            this.radLabelNeckRatio = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorNeckRatio = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelSegmentSpacing = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorSegmentSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBoxDynamicSlope = new Telerik.WinControls.UI.RadCheckBox();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radCheckBoxDynamicHeight = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNeckRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorNeckRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSegmentSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSegmentSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDynamicSlope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDynamicHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radLabelNeckRatio);
            this.settingsPanel.Controls.Add(this.radLabelSegmentSpacing);
            this.settingsPanel.Controls.Add(this.radSpinEditorNeckRatio);
            this.settingsPanel.Controls.Add(this.radCheckBoxDynamicHeight);
            this.settingsPanel.Controls.Add(this.radCheckBoxDynamicSlope);
            this.settingsPanel.Controls.Add(this.radSpinEditorSegmentSpacing);
            this.settingsPanel.Location = new System.Drawing.Point(994, 46);
            this.settingsPanel.Size = new System.Drawing.Size(252, 364);
            this.settingsPanel.Controls.SetChildIndex(this.radSpinEditorSegmentSpacing, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxDynamicSlope, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxDynamicHeight, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radSpinEditorNeckRatio, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabelSegmentSpacing, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabelNeckRatio, 0);
            // 
            // radLabelNeckRatio
            // 
            this.radLabelNeckRatio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelNeckRatio.Location = new System.Drawing.Point(10, 35);
            this.radLabelNeckRatio.Name = "radLabelNeckRatio";
            this.radLabelNeckRatio.Size = new System.Drawing.Size(62, 18);
            this.radLabelNeckRatio.TabIndex = 1;
            this.radLabelNeckRatio.Text = "Neck Ratio:";
            // 
            // radSpinEditorNeckRatio
            // 
            this.radSpinEditorNeckRatio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorNeckRatio.DecimalPlaces = 1;
            this.radSpinEditorNeckRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.radSpinEditorNeckRatio.Location = new System.Drawing.Point(10, 56);
            this.radSpinEditorNeckRatio.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.radSpinEditorNeckRatio.Name = "radSpinEditorNeckRatio";
            // 
            // 
            // 
            this.radSpinEditorNeckRatio.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorNeckRatio.Size = new System.Drawing.Size(232, 20);
            this.radSpinEditorNeckRatio.TabIndex = 2;
            this.radSpinEditorNeckRatio.TabStop = false;
            this.radSpinEditorNeckRatio.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // radLabelSegmentSpacing
            // 
            this.radLabelSegmentSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabelSegmentSpacing.Location = new System.Drawing.Point(10, 85);
            this.radLabelSegmentSpacing.Name = "radLabelSegmentSpacing";
            this.radLabelSegmentSpacing.Size = new System.Drawing.Size(95, 18);
            this.radLabelSegmentSpacing.TabIndex = 3;
            this.radLabelSegmentSpacing.Text = "Segment Spacing:";
            // 
            // radSpinEditorSegmentSpacing
            // 
            this.radSpinEditorSegmentSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorSegmentSpacing.Location = new System.Drawing.Point(10, 106);
            this.radSpinEditorSegmentSpacing.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radSpinEditorSegmentSpacing.Name = "radSpinEditorSegmentSpacing";
            // 
            // 
            // 
            this.radSpinEditorSegmentSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorSegmentSpacing.Size = new System.Drawing.Size(232, 20);
            this.radSpinEditorSegmentSpacing.TabIndex = 4;
            this.radSpinEditorSegmentSpacing.TabStop = false;
            this.radSpinEditorSegmentSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radCheckBoxDynamicSlope
            // 
            this.radCheckBoxDynamicSlope.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxDynamicSlope.Location = new System.Drawing.Point(10, 141);
            this.radCheckBoxDynamicSlope.Name = "radCheckBoxDynamicSlope";
            this.radCheckBoxDynamicSlope.Size = new System.Drawing.Size(97, 18);
            this.radCheckBoxDynamicSlope.TabIndex = 5;
            this.radCheckBoxDynamicSlope.Text = "Dynamic Slope:";
            // 
            // radChartView1
            // 
            this.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Funnel;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.MinimumSize = new System.Drawing.Size(280, 320);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(280, 320);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(1871, 1086);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.Title = "Chart title";
            // 
            // radCheckBoxDynamicHeight
            // 
            this.radCheckBoxDynamicHeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxDynamicHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxDynamicHeight.Location = new System.Drawing.Point(10, 174);
            this.radCheckBoxDynamicHeight.Name = "radCheckBoxDynamicHeight";
            this.radCheckBoxDynamicHeight.Size = new System.Drawing.Size(103, 18);
            this.radCheckBoxDynamicHeight.TabIndex = 5;
            this.radCheckBoxDynamicHeight.Text = "Dynamic Height:";
            this.radCheckBoxDynamicHeight.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(280, 320);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1881, 1096);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelNeckRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorNeckRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSegmentSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSegmentSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDynamicSlope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxDynamicHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadLabel radLabelNeckRatio;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorNeckRatio;
        private Telerik.WinControls.UI.RadLabel radLabelSegmentSpacing;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorSegmentSpacing;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxDynamicSlope;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxDynamicHeight;
    }
}