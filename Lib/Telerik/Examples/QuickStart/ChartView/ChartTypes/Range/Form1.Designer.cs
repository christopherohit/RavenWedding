namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListChartType = new Telerik.WinControls.UI.RadDropDownList();
            this.orientationCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxSpline = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSpline)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radCheckBoxSpline);
            this.settingsPanel.PanelContainer.Controls.Add(this.orientationCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.radDropDownListChartType);
            this.settingsPanel.PanelContainer.Controls.Add(this.radLabel2);
            this.settingsPanel.PanelContainer.Controls.Add(this.radLabel1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(240, 883);
            this.settingsPanel.Size = new System.Drawing.Size(240, 883);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
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
            this.radChartView1.Size = new System.Drawing.Size(1230, 786);
            this.radChartView1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 45);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Series type:";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 148);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(106, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Change Orientation:";
            // 
            // radDropDownListChartType
            // 
            this.radDropDownListChartType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListChartType.DropDownAnimationEnabled = false;
            this.radDropDownListChartType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "Range";
            radListDataItem2.Text = "RangeBar";
            this.radDropDownListChartType.Items.Add(radListDataItem1);
            this.radDropDownListChartType.Items.Add(radListDataItem2);
            this.radDropDownListChartType.Location = new System.Drawing.Point(5, 69);
            this.radDropDownListChartType.Name = "radDropDownListChartType";
            this.radDropDownListChartType.Size = new System.Drawing.Size(230, 20);
            this.radDropDownListChartType.TabIndex = 2;
            // 
            // orientationCheckBox
            // 
            this.orientationCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orientationCheckBox.Location = new System.Drawing.Point(5, 172);
            this.orientationCheckBox.Name = "orientationCheckBox";
            this.orientationCheckBox.Size = new System.Drawing.Size(72, 18);
            this.orientationCheckBox.TabIndex = 4;
            this.orientationCheckBox.Text = "Horizontal";
            // 
            // radCheckBoxSpline
            // 
            this.radCheckBoxSpline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxSpline.Enabled = false;
            this.radCheckBoxSpline.Location = new System.Drawing.Point(5, 114);
            this.radCheckBoxSpline.Name = "radCheckBoxSpline";
            this.radCheckBoxSpline.Size = new System.Drawing.Size(51, 18);
            this.radCheckBoxSpline.TabIndex = 5;
            this.radCheckBoxSpline.Text = "Spline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScrollMinSize = new System.Drawing.Size(550, 320);
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSpline)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox orientationCheckBox;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListChartType;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxSpline;
	}
}
