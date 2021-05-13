namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureLT2008DataSet = new Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.employeeTableAdapter = new Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxSpline = new Telerik.WinControls.UI.RadCheckBox();
            this.radDropDownListSeriesType = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorPointRadius = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButtonEditShape = new Telerik.WinControls.UI.RadButton();
            this.radDropDownListShapes = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureLT2008DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSpline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSeriesType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEditShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListShapes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 216);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox2);
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(220, 624);
            this.settingsPanel.Size = new System.Drawing.Size(220, 624);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.adventureLT2008DataSet;
            // 
            // adventureLT2008DataSet
            // 
            this.adventureLT2008DataSet.DataSetName = "AdventureLT2008DataSet";
            this.adventureLT2008DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User Business Male.png");
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // radChartView1
            // 
            this.radChartView1.AreaDesign = cartesianArea1;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.ImageList = this.imageList1;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.MinimumSize = new System.Drawing.Size(550, 320);
            this.radChartView1.Name = "radChartView1";
            // 
            // 
            // 
            this.radChartView1.RootElement.MinSize = new System.Drawing.Size(550, 320);
            this.radChartView1.ShowGrid = false;
            this.radChartView1.Size = new System.Drawing.Size(1230, 786);
            this.radChartView1.TabIndex = 1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radCheckBoxSpline);
            this.radGroupBox1.Controls.Add(this.radDropDownListSeriesType);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.HeaderText = "Series";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 43);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 117);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Series";
            // 
            // radCheckBoxSpline
            // 
            this.radCheckBoxSpline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxSpline.Location = new System.Drawing.Point(5, 85);
            this.radCheckBoxSpline.Name = "radCheckBoxSpline";
            this.radCheckBoxSpline.Size = new System.Drawing.Size(51, 18);
            this.radCheckBoxSpline.TabIndex = 5;
            this.radCheckBoxSpline.Text = "Spline";
            // 
            // radDropDownListSeriesType
            // 
            this.radDropDownListSeriesType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListSeriesType.DropDownAnimationEnabled = false;
            this.radDropDownListSeriesType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListSeriesType.Location = new System.Drawing.Point(5, 45);
            this.radDropDownListSeriesType.Name = "radDropDownListSeriesType";
            this.radDropDownListSeriesType.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListSeriesType.TabIndex = 4;
            this.radDropDownListSeriesType.Text = "radDropDownList1";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel4.Location = new System.Drawing.Point(5, 21);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(60, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Series type";
            // 
            // radSpinEditorPointRadius
            // 
            this.radSpinEditorPointRadius.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorPointRadius.Location = new System.Drawing.Point(5, 123);
            this.radSpinEditorPointRadius.Name = "radSpinEditorPointRadius";
            this.radSpinEditorPointRadius.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 
            // 
            this.radSpinEditorPointRadius.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorPointRadius.Size = new System.Drawing.Size(200, 20);
            this.radSpinEditorPointRadius.TabIndex = 3;
            this.radSpinEditorPointRadius.TabStop = false;
            this.radSpinEditorPointRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel3.Location = new System.Drawing.Point(5, 99);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(53, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Point size";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(36, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Shape";
            // 
            // radButtonEditShape
            // 
            this.radButtonEditShape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonEditShape.Location = new System.Drawing.Point(5, 163);
            this.radButtonEditShape.Name = "radButtonEditShape";
            this.radButtonEditShape.Size = new System.Drawing.Size(200, 30);
            this.radButtonEditShape.TabIndex = 1;
            this.radButtonEditShape.Text = "Edit shape";
            // 
            // radDropDownListShapes
            // 
            this.radDropDownListShapes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDropDownListShapes.DropDownAnimationEnabled = false;
            this.radDropDownListShapes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListShapes.Location = new System.Drawing.Point(5, 59);
            this.radDropDownListShapes.Name = "radDropDownListShapes";
            this.radDropDownListShapes.Size = new System.Drawing.Size(200, 20);
            this.radDropDownListShapes.TabIndex = 0;
            this.radDropDownListShapes.Text = "radDropDownList1";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.radDropDownListShapes);
            this.radGroupBox2.Controls.Add(this.radSpinEditorPointRadius);
            this.radGroupBox2.Controls.Add(this.radButtonEditShape);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.HeaderText = "Data points";
            this.radGroupBox2.Location = new System.Drawing.Point(3, 177);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(210, 198);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "Data points";
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureLT2008DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxSpline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSeriesType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEditShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListShapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.AdventureLT2008DataSet adventureLT2008DataSet;
        private DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListShapes;
        private Telerik.WinControls.UI.RadButton radButtonEditShape;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorPointRadius;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxSpline;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListSeriesType;
        private Telerik.WinControls.UI.RadLabel radLabel4;
	}
}
