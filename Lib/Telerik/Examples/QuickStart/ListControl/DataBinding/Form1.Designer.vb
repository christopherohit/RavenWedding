Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ListControl.DataBinding
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.radListBoxDemo = New Telerik.WinControls.UI.RadListControl()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.nwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.radGroupOptions = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioArray = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDB = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDataTable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioUnbound = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radListBoxDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupOptions.SuspendLayout()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupOptions)
			Me.settingsPanel.Location = New Point(779, 1)
			Me.settingsPanel.Size = New Size(200, 784)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupOptions, 0)
			' 
			' radListBoxDemo
			' 
			Me.radListBoxDemo.Location = New Point(20, 20)
			Me.radListBoxDemo.Name = "radListBoxDemo"
			Me.radListBoxDemo.Size = New Size(329, 368)
			Me.radListBoxDemo.TabIndex = 6
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "NwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' radGroupOptions
			' 
			Me.radGroupOptions.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupOptions.Controls.Add(Me.radRadioArray)
			Me.radGroupOptions.Controls.Add(Me.radRadioDB)
			Me.radGroupOptions.Controls.Add(Me.radRadioDataTable)
			Me.radGroupOptions.Controls.Add(Me.radRadioUnbound)
			Me.radGroupOptions.FooterText = ""
			Me.radGroupOptions.HeaderText = "Binding Options"
			Me.radGroupOptions.Location = New Point(15, 6)
			Me.radGroupOptions.Name = "radGroupOptions"
			' 
			' 
			' 
			Me.radGroupOptions.RootElement.Padding = New Padding(2, 18, 2, 2)
			Me.radGroupOptions.Size = New Size(162, 126)
			Me.radGroupOptions.TabIndex = 0
			Me.radGroupOptions.Text = "Binding Options"
			' 
			' radRadioArray
			' 
			Me.radRadioArray.Location = New Point(20, 74)
			Me.radRadioArray.Name = "radRadioArray"
			Me.radRadioArray.Size = New Size(47, 18)
			Me.radRadioArray.TabIndex = 0
			Me.radRadioArray.Text = "Array"
			' 
			' radRadioDB
			' 
			Me.radRadioDB.Location = New Point(20, 96)
			Me.radRadioDB.Name = "radRadioDB"
			Me.radRadioDB.Size = New Size(67, 18)
			Me.radRadioDB.TabIndex = 0
			Me.radRadioDB.Text = "Database"
			' 
			' radRadioDataTable
			' 
			Me.radRadioDataTable.Location = New Point(20, 52)
			Me.radRadioDataTable.Name = "radRadioDataTable"
			Me.radRadioDataTable.Size = New Size(74, 18)
			Me.radRadioDataTable.TabIndex = 0
			Me.radRadioDataTable.Text = "Data Table"
			' 
			' radRadioUnbound
			' 
			Me.radRadioUnbound.Location = New Point(20, 30)
			Me.radRadioUnbound.Name = "radRadioUnbound"
			Me.radRadioUnbound.Size = New Size(99, 18)
			Me.radRadioUnbound.TabIndex = 0
			Me.radRadioUnbound.Text = "Unbound mode"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radListBoxDemo)
			Me.Name = "Form1"
			Me.Size = New Size(1142, 516)
			Me.Controls.SetChildIndex(Me.radListBoxDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radListBoxDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupOptions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupOptions.ResumeLayout(False)
			Me.radGroupOptions.PerformLayout()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListBoxDemo As Telerik.WinControls.UI.RadListControl
		Private employeesBindingSource As BindingSource
		Private nwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private radGroupOptions As Telerik.WinControls.UI.RadGroupBox
		Private radRadioArray As Telerik.WinControls.UI.RadRadioButton
		Private radRadioDB As Telerik.WinControls.UI.RadRadioButton
		Private radRadioDataTable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioUnbound As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace