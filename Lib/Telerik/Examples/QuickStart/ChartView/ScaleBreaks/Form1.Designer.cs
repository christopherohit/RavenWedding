using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ChartView.ScaleBreaks
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownListStyle = new Telerik.WinControls.UI.RadDropDownList();
            this.radColorBoxBackColor = new Telerik.WinControls.UI.RadColorBox();
            this.radColorBoxBorderColor = new Telerik.WinControls.UI.RadColorBox();
            this.radSpinEditorSize = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButtonScaleBreaks = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBoxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBoxBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonScaleBreaks)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 19);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radButtonScaleBreaks);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
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
            this.radChartView1.Size = new System.Drawing.Size(1230, 786);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Title = "Sales by Region";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Text = "Sales by Region";
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI Light", 20F);
            ((Telerik.WinControls.UI.ChartTitleElement)(this.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radDropDownListStyle);
            this.radGroupBox1.Controls.Add(this.radColorBoxBackColor);
            this.radGroupBox1.Controls.Add(this.radColorBoxBorderColor);
            this.radGroupBox1.Controls.Add(this.radSpinEditorSize);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Scale break settings";
            this.radGroupBox1.Location = new System.Drawing.Point(5, 76);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(294, 222);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Scale break settings";
            // 
            // radDropDownListStyle
            // 
            this.radDropDownListStyle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListStyle.DropDownAnimationEnabled = false;
            this.radDropDownListStyle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListStyle.Location = new System.Drawing.Point(5, 40);
            this.radDropDownListStyle.Name = "radDropDownListStyle";
            this.radDropDownListStyle.Size = new System.Drawing.Size(284, 20);
            this.radDropDownListStyle.TabIndex = 3;
            this.radDropDownListStyle.Text = "radDropDownList1";
            // 
            // radColorBoxBackColor
            // 
            this.radColorBoxBackColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radColorBoxBackColor.Location = new System.Drawing.Point(5, 190);
            this.radColorBoxBackColor.Name = "radColorBoxBackColor";
            this.radColorBoxBackColor.Size = new System.Drawing.Size(284, 20);
            this.radColorBoxBackColor.TabIndex = 2;
            // 
            // radColorBoxBorderColor
            // 
            this.radColorBoxBorderColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radColorBoxBorderColor.Location = new System.Drawing.Point(5, 140);
            this.radColorBoxBorderColor.Name = "radColorBoxBorderColor";
            this.radColorBoxBorderColor.Size = new System.Drawing.Size(284, 20);
            this.radColorBoxBorderColor.TabIndex = 2;
            // 
            // radSpinEditorSize
            // 
            this.radSpinEditorSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorSize.Location = new System.Drawing.Point(5, 90);
            this.radSpinEditorSize.Name = "radSpinEditorSize";
            this.radSpinEditorSize.Size = new System.Drawing.Size(284, 20);
            this.radSpinEditorSize.TabIndex = 1;
            this.radSpinEditorSize.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel3.Location = new System.Drawing.Point(5, 171);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(57, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Back color";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 121);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(67, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Border color";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel4.Location = new System.Drawing.Point(5, 21);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(29, 18);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Style";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 71);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(25, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Size";
            // 
            // radButtonScaleBreaks
            // 
            this.radButtonScaleBreaks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonScaleBreaks.Location = new System.Drawing.Point(5, 33);
            this.radButtonScaleBreaks.Name = "radButtonScaleBreaks";
            this.radButtonScaleBreaks.Size = new System.Drawing.Size(294, 37);
            this.radButtonScaleBreaks.TabIndex = 3;
            this.radButtonScaleBreaks.Text = "Remove Scale Breaks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(680, 420);
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
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBoxBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radColorBoxBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonScaleBreaks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private RadGroupBox radGroupBox1;
        private RadDropDownList radDropDownListStyle;
        private RadColorBox radColorBoxBackColor;
        private RadColorBox radColorBoxBorderColor;
        private RadSpinEditor radSpinEditorSize;
        private RadLabel radLabel3;
        private RadLabel radLabel2;
        private RadLabel radLabel4;
        private RadLabel radLabel1;
        private RadButton radButtonScaleBreaks;
    }
}