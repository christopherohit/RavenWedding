using Telerik.WinControls;
namespace Telerik.Examples.WinControls.ChartView.FirstLook
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radChartView2 = new Telerik.WinControls.UI.RadChartView();
            this.radChartView3 = new Telerik.WinControls.UI.RadChartView();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 19);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(0, 0);
            this.settingsPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 4;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radChartView1, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radChartView2, 2, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radChartView3, 0, 4);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radGridView1, 2, 4);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radPanel1, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radPanel2, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radPanel3, 2, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radPanel4, 0, 3);
            this.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 5;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(1207, 786);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 1;
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 75);
            this.radChartView1.Margin = new System.Windows.Forms.Padding(0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(478, 340);
            this.radChartView1.TabIndex = 0;
            // 
            // radChartView2
            // 
            this.radChartView2.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView2.Location = new System.Drawing.Point(578, 75);
            this.radChartView2.Margin = new System.Windows.Forms.Padding(0);
            this.radChartView2.Name = "radChartView2";
            this.radChartView2.ShowGrid = false;
            this.radChartView2.Size = new System.Drawing.Size(478, 340);
            this.radChartView2.TabIndex = 1;
            // 
            // radChartView3
            // 
            this.radChartView3.AreaDesign = cartesianArea2;
            this.radChartView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView3.Location = new System.Drawing.Point(0, 445);
            this.radChartView3.Margin = new System.Windows.Forms.Padding(0);
            this.radChartView3.Name = "radChartView3";
            this.radChartView3.ShowGrid = false;
            this.radChartView3.Size = new System.Drawing.Size(478, 341);
            this.radChartView3.TabIndex = 2;
            // 
            // radGridView1
            // 
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radGridView1, 2);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(578, 445);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowCellContextMenu = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(629, 341);
            this.radGridView1.TabIndex = 0;
            ((Telerik.WinControls.UI.RadGridViewElement)(this.radGridView1.GetChildAt(0))).BorderColor = System.Drawing.Color.White;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radPanel1, 4);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1207, 45);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.White;
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radPanel2, 2);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel2.Location = new System.Drawing.Point(0, 45);
            this.radPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel2.Name = "radPanel2";
            // 
            // 
            // 
            this.radPanel2.RootElement.EnableElementShadow = false;
            this.radPanel2.Size = new System.Drawing.Size(578, 30);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).Text = "Total sales by product";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.White;
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radPanel3, 2);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel3.Location = new System.Drawing.Point(578, 45);
            this.radPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel3.Name = "radPanel3";
            // 
            // 
            // 
            this.radPanel3.RootElement.EnableElementShadow = false;
            this.radPanel3.Size = new System.Drawing.Size(629, 30);
            this.radPanel3.TabIndex = 4;
            this.radPanel3.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel3.GetChildAt(0))).Text = "Sales breakdown by region";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radPanel4
            // 
            this.radPanel4.BackColor = System.Drawing.Color.White;
            this.doubleBufferedTableLayoutPanel1.SetColumnSpan(this.radPanel4, 4);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel4.Location = new System.Drawing.Point(0, 415);
            this.radPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel4.Name = "radPanel4";
            // 
            // 
            // 
            this.radPanel4.RootElement.EnableElementShadow = false;
            this.radPanel4.Size = new System.Drawing.Size(1207, 30);
            this.radPanel4.TabIndex = 4;
            this.radPanel4.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel4.GetChildAt(0))).Text = "Percent of target";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(1148, 610);
            this.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1227, 796);
            this.Controls.SetChildIndex(this.doubleBufferedTableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
        private Telerik.WinControls.UI.RadChartView radChartView3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;                
	}
}
