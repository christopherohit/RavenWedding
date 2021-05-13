﻿Namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDateTimeColumn1 As New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radGridView1 = New Telerik.Examples.WinControls.GridView.Rows.RowDetails.RowDetailsGrid()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(753, 1)
			Me.settingsPanel.Size = New Size(200, 723)
			' 
			' radGridView1
			' 
			Me.radGridView1.BackColor = Color.Transparent
			Me.radGridView1.Cursor = Cursors.Default
			Me.radGridView1.DetailsColumn = Nothing
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Font = New Font("Segoe UI", 8.25F)
			Me.radGridView1.ForeColor = Color.Black
			Me.radGridView1.ImeMode = ImeMode.NoControl
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' masterGridViewTemplate1
			' 
			gridViewTextBoxColumn1.FieldName = "Notes"
			gridViewTextBoxColumn1.HeaderText = "Notes"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "Notes"
			gridViewTextBoxColumn1.WrapText = True
			gridViewTextBoxColumn2.FieldName = "LastName"
			gridViewTextBoxColumn2.HeaderText = "LastName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "LastName"
			gridViewTextBoxColumn2.Width = 100
			gridViewTextBoxColumn3.FieldName = "FirstName"
			gridViewTextBoxColumn3.HeaderText = "FirstName"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "FirstName"
			gridViewTextBoxColumn3.Width = 100
			gridViewTextBoxColumn4.FieldName = "Title"
			gridViewTextBoxColumn4.HeaderText = "Title"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Title"
			gridViewTextBoxColumn4.Width = 150
			gridViewDateTimeColumn1.DataType = GetType(Date)
			gridViewDateTimeColumn1.FieldName = "HireDate"
			gridViewDateTimeColumn1.Format = DateTimePickerFormat.Long
			gridViewDateTimeColumn1.FormatString = "{0:d}"
			gridViewDateTimeColumn1.HeaderText = "HireDate"
			gridViewDateTimeColumn1.IsAutoGenerated = True
			gridViewDateTimeColumn1.Name = "HireDate"
			gridViewDateTimeColumn1.Width = 100
			gridViewTextBoxColumn5.FieldName = "City"
			gridViewTextBoxColumn5.HeaderText = "City"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "City"
			gridViewTextBoxColumn5.Width = 80
			gridViewTextBoxColumn6.FieldName = "Country"
			gridViewTextBoxColumn6.HeaderText = "Country"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "Country"
			gridViewTextBoxColumn6.Width = 80
			gridViewImageColumn1.DataType = GetType(Image)
			gridViewImageColumn1.FieldName = "Photo"
			gridViewImageColumn1.HeaderText = "Photo"
			gridViewImageColumn1.IsAutoGenerated = True
			gridViewImageColumn1.Name = "Photo"
			gridViewTextBoxColumn7.FieldName = "Address"
			gridViewTextBoxColumn7.HeaderText = "Address"
			gridViewTextBoxColumn7.Name = "Address"
			gridViewTextBoxColumn7.Width = 150
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewDateTimeColumn1, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewImageColumn1, gridViewTextBoxColumn7})
			Me.radGridView1.MasterTemplate.DataSource = Me.employeesBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New Size(954, 725)
			Me.radGridView1.TabIndex = 1

			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(954, 725)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As RowDetailsGrid
		Private employeesBindingSource As BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
	End Class
End Namespace
