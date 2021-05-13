namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Polar
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
            Telerik.WinControls.UI.PolarAxis polarAxis3 = new Telerik.WinControls.UI.PolarAxis();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(994, 46);
            this.settingsPanel.Size = new System.Drawing.Size(160, 347);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Polar;
            polarAxis1.IsPrimary = true;
            polarAxis2.IsPrimary = true;
            polarAxis3.IsPrimary = true;
            this.radChartView1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            polarAxis1,
            polarAxis2,
            polarAxis3});
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.MinimumSize = new System.Drawing.Size(280, 320);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(280, 320);
            this.radChartView1.Size = new System.Drawing.Size(1158, 698);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "Line";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Area";
            radListDataItem2.TextWrap = true;
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Location = new System.Drawing.Point(5, 37);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(130, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "Line";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radDropDownList1);
            this.radGroupBox1.HeaderText = "Series type";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 5);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(140, 91);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Series type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(280, 320);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1168, 708);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}