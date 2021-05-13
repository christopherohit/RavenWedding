namespace Telerik.Examples.WinControls.ChartView.DrillDown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.btnSpy = new Telerik.WinControls.UI.RadButton();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataSet = new Telerik.Examples.WinControls.DataSources.ChartDataSet();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 279);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // btnSpy
            // 
            this.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpy.Image = ((System.Drawing.Image)(resources.GetObject("btnSpy.Image")));
            this.btnSpy.Location = new System.Drawing.Point(246, 7);
            this.btnSpy.Name = "btnSpy";
            this.btnSpy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSpy.Size = new System.Drawing.Size(120, 24);
            this.btnSpy.TabIndex = 0;
            this.btnSpy.Text = "RadControl Spy ";
            this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpy.ThemeName = "ControlDefault";
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.MinimumSize = new System.Drawing.Size(450, 350);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 480, 320);
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(450, 350);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(1158, 612);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.chartDataSet;
            this.bindingSource1.Position = 0;
            // 
            // chartDataSet
            // 
            this.chartDataSet.DataSetName = "ChartDataSet";
            this.chartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownList1.Location = new System.Drawing.Point(5, 21);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(170, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "radDropDownList1";
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radDropDownList1);
            this.radGroupBox1.HeaderText = "Drill Navigator Style";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 46);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(180, 58);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Drill Navigator Style";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1168, 622);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;        
        private System.Windows.Forms.BindingSource bindingSource1;
        private Telerik.Examples.WinControls.DataSources.ChartDataSet chartDataSet;       
        private Telerik.WinControls.UI.RadButton btnSpy;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}