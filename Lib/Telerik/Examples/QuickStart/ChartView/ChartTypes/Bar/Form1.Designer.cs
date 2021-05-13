namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.showLabelsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.orientationCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLabelsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationCheckBox)).BeginInit();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(228, 883);
            this.settingsPanel.Size = new System.Drawing.Size(228, 883);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea2;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.MinimumSize = new System.Drawing.Size(550, 320);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(550, 320);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.Size = new System.Drawing.Size(1473, 786);
            this.radChartView1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(85, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Combine mode:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 135);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(106, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Change Orientation:";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = false;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem4.Text = "Cluster";
            radListDataItem5.Text = "Stack";
            radListDataItem6.Text = "Stack100";
            this.radDropDownList1.Items.Add(radListDataItem4);
            this.radDropDownList1.Items.Add(radListDataItem5);
            this.radDropDownList1.Items.Add(radListDataItem6);
            this.radDropDownList1.Location = new System.Drawing.Point(3, 47);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(194, 20);
            this.radDropDownList1.TabIndex = 2;
            // 
            // showLabelsCheckBox
            // 
            this.showLabelsCheckBox.Location = new System.Drawing.Point(3, 91);
            this.showLabelsCheckBox.Name = "showLabelsCheckBox";
            this.showLabelsCheckBox.Size = new System.Drawing.Size(82, 18);
            this.showLabelsCheckBox.TabIndex = 3;
            this.showLabelsCheckBox.Text = "Show Labels";
            // 
            // orientationCheckBox
            // 
            this.orientationCheckBox.Location = new System.Drawing.Point(3, 179);
            this.orientationCheckBox.Name = "orientationCheckBox";
            this.orientationCheckBox.Size = new System.Drawing.Size(72, 18);
            this.orientationCheckBox.TabIndex = 4;
            this.orientationCheckBox.Text = "Horizontal";
            // 
            // tableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 1;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radDropDownList1, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.orientationCheckBox, 0, 4);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.showLabelsCheckBox, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLabel2, 0, 3);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(5, 46);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 5;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(218, 223);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScrollMinSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1483, 796);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLabelsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationCheckBox)).EndInit();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox orientationCheckBox;
        private Telerik.WinControls.UI.RadCheckBox showLabelsCheckBox;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
    }
}
