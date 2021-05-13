namespace Telerik.Examples.WinControls.ListControl.DataBinding
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
            this.radListBoxDemo = new Telerik.WinControls.UI.RadListControl();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.radGroupOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioArray = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioDB = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioDataTable = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioUnbound = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListBoxDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupOptions)).BeginInit();
            this.radGroupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioUnbound)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupOptions);
            this.settingsPanel.Location = new System.Drawing.Point(779, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 784);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupOptions, 0);
            // 
            // radListBoxDemo
            // 
            this.radListBoxDemo.Location = new System.Drawing.Point(20, 20);
            this.radListBoxDemo.Name = "radListBoxDemo";
            this.radListBoxDemo.Size = new System.Drawing.Size(329, 368);
            this.radListBoxDemo.TabIndex = 6;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "NwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupOptions
            // 
            this.radGroupOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupOptions.Controls.Add(this.radRadioArray);
            this.radGroupOptions.Controls.Add(this.radRadioDB);
            this.radGroupOptions.Controls.Add(this.radRadioDataTable);
            this.radGroupOptions.Controls.Add(this.radRadioUnbound);
            this.radGroupOptions.FooterText = "";
            this.radGroupOptions.HeaderText = "Binding Options";
            this.radGroupOptions.Location = new System.Drawing.Point(15, 6);
            this.radGroupOptions.Name = "radGroupOptions";
            // 
            // 
            // 
            this.radGroupOptions.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupOptions.Size = new System.Drawing.Size(162, 126);
            this.radGroupOptions.TabIndex = 0;
            this.radGroupOptions.Text = "Binding Options";
            // 
            // radRadioArray
            // 
            this.radRadioArray.Location = new System.Drawing.Point(20, 74);
            this.radRadioArray.Name = "radRadioArray";
            this.radRadioArray.Size = new System.Drawing.Size(47, 18);
            this.radRadioArray.TabIndex = 0;
            this.radRadioArray.Text = "Array";
            // 
            // radRadioDB
            // 
            this.radRadioDB.Location = new System.Drawing.Point(20, 96);
            this.radRadioDB.Name = "radRadioDB";
            this.radRadioDB.Size = new System.Drawing.Size(67, 18);
            this.radRadioDB.TabIndex = 0;
            this.radRadioDB.Text = "Database";
            // 
            // radRadioDataTable
            // 
            this.radRadioDataTable.Location = new System.Drawing.Point(20, 52);
            this.radRadioDataTable.Name = "radRadioDataTable";
            this.radRadioDataTable.Size = new System.Drawing.Size(74, 18);
            this.radRadioDataTable.TabIndex = 0;
            this.radRadioDataTable.Text = "Data Table";
            // 
            // radRadioUnbound
            // 
            this.radRadioUnbound.Location = new System.Drawing.Point(20, 30);
            this.radRadioUnbound.Name = "radRadioUnbound";
            this.radRadioUnbound.Size = new System.Drawing.Size(99, 18);
            this.radRadioUnbound.TabIndex = 0;
            this.radRadioUnbound.Text = "Unbound mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radListBoxDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1142, 516);
            this.Controls.SetChildIndex(this.radListBoxDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListBoxDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupOptions)).EndInit();
            this.radGroupOptions.ResumeLayout(false);
            this.radGroupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioUnbound)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadListControl radListBoxDemo;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupOptions;
        private Telerik.WinControls.UI.RadRadioButton radRadioArray;
        private Telerik.WinControls.UI.RadRadioButton radRadioDB;
        private Telerik.WinControls.UI.RadRadioButton radRadioDataTable;
        private Telerik.WinControls.UI.RadRadioButton radRadioUnbound;
	}
}