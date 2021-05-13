Imports Microsoft.VisualBasic
Imports System
Namespace DemoAppsHub.GridExample
	Public Partial Class GridExampleUserControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim groupDescriptor1 As Telerik.WinControls.Data.GroupDescriptor = New Telerik.WinControls.Data.GroupDescriptor()
			Dim sortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridExampleUserControl))
            Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.ForeColor = System.Drawing.Color.Black
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' 
			'            
			gridViewTextBoxColumn1.FieldName = "LastName"
			gridViewTextBoxColumn1.FormatString = ""
			gridViewTextBoxColumn1.HeaderText = "LastName"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "LastName"
			gridViewTextBoxColumn1.Width = 80
			gridViewTextBoxColumn2.FieldName = "FirstName"
			gridViewTextBoxColumn2.FormatString = ""
			gridViewTextBoxColumn2.HeaderText = "FirstName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "FirstName"
			gridViewTextBoxColumn2.Width = 80
			gridViewTextBoxColumn3.FieldName = "Title"
			gridViewTextBoxColumn3.FormatString = ""
			gridViewTextBoxColumn3.HeaderText = "Title"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "Title"
			gridViewTextBoxColumn3.Width = 190
			gridViewDateTimeColumn1.FieldName = "HireDate"
			gridViewDateTimeColumn1.FormatString = ""
			gridViewDateTimeColumn1.HeaderText = "HireDate"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "HireDate"
			gridViewDateTimeColumn1.Width = 90
			gridViewDateTimeColumn1.FormatString = "{0:d}"
			gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			gridViewTextBoxColumn4.FieldName = "Country"
			gridViewTextBoxColumn4.FormatString = ""
			gridViewTextBoxColumn4.HeaderText = "Country"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Country"
			gridViewTextBoxColumn4.Width = 80
			gridViewTextBoxColumn5.FieldName = "Address"
			gridViewTextBoxColumn5.FormatString = ""
			gridViewTextBoxColumn5.HeaderText = "Address"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "Address"
			gridViewTextBoxColumn5.Width = 190
			gridViewTextBoxColumn6.FieldName = "City"
			gridViewTextBoxColumn6.FormatString = ""
			gridViewTextBoxColumn6.HeaderText = "City"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "City"
			gridViewImageColumn1.DataType = GetType(Byte() )
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.IsVisible = False
			gridViewImageColumn1.Name = "Photo"
			gridViewTextBoxColumn7.FieldName = "Notes"
			gridViewTextBoxColumn7.HeaderText = "Notes"
			gridViewTextBoxColumn7.IsAutoGenerated = True
			gridViewTextBoxColumn7.IsVisible = False
			gridViewTextBoxColumn7.Name = "Notes"
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewDateTimeColumn1, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewImageColumn1, gridViewTextBoxColumn7})
			Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
			sortDescriptor1.PropertyName = "City"
			groupDescriptor1.GroupNames.AddRange(New Telerik.WinControls.Data.SortDescriptor() { sortDescriptor1})
			Me.radGridView1.MasterTemplate.GroupDescriptors.AddRange(New Telerik.WinControls.Data.GroupDescriptor() { groupDescriptor1})
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.AutoExpandGroups = True
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.ReadOnly = True
			' 
			' 
			' 
			Me.radGridView1.Size = New System.Drawing.Size(1119, 320)
			Me.radGridView1.TabIndex = 1
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(800,600)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
        Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesBindingSource As System.Windows.Forms.BindingSource
        Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
	End Class
End Namespace