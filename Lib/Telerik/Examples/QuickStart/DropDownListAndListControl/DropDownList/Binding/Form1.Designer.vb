Imports Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding
Imports System.ComponentModel
Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding
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
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.NorthwindDataSetAccess = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.CustomerBindingSource = New BindingSource(Me.components)
			Me.employeesTableAdapter2 = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.radGroupBindingOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioDB = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioArray = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioDataTable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioUnbound = New Telerik.WinControls.UI.RadRadioButton()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.NorthwindDataSetAccess, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBindingOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBindingOpts.SuspendLayout()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.ForeColor = Color.Black
			Me.radPanelDemoHolder.Size = New Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBindingOpts)
			Me.settingsPanel.Location = New Point(1023, 1)
			Me.settingsPanel.Size = New Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBindingOpts, 0)
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.NorthwindDataSetAccess
			' 
			' NorthwindDataSetAccess
			' 
			Me.NorthwindDataSetAccess.DataSetName = "NwindDataSet"
			Me.NorthwindDataSetAccess.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' CustomerBindingSource
			' 
			Me.CustomerBindingSource.DataSource = GetType(Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding.Customer)

			' 
			' employeesTableAdapter2
			' 
			Me.employeesTableAdapter2.ClearBeforeFill = True
			' 
			' radGroupBindingOpts
			' 
			Me.radGroupBindingOpts.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBindingOpts.Anchor = AnchorStyles.Top
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioDB)
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioArray)
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioDataTable)
			Me.radGroupBindingOpts.Controls.Add(Me.radRadioUnbound)
			Me.radGroupBindingOpts.FooterText = ""
			Me.radGroupBindingOpts.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupBindingOpts.HeaderText = " Binding options "
			Me.radGroupBindingOpts.Location = New Point(10, 6)
			Me.radGroupBindingOpts.Name = "radGroupBindingOpts"
			Me.radGroupBindingOpts.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBindingOpts.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBindingOpts.Size = New Size(180, 131)
			Me.radGroupBindingOpts.TabIndex = 0
			Me.radGroupBindingOpts.Text = " Binding options "
			' 
			' radRadioDB
			' 
			Me.radRadioDB.Location = New Point(33, 96)
			Me.radRadioDB.Name = "radRadioDB"
			Me.radRadioDB.Size = New Size(67, 18)
			Me.radRadioDB.TabIndex = 0
			Me.radRadioDB.Text = "Database"

			' 
			' radRadioArray
			' 
			Me.radRadioArray.Location = New Point(33, 74)
			Me.radRadioArray.Name = "radRadioArray"
			Me.radRadioArray.Size = New Size(47, 18)
			Me.radRadioArray.TabIndex = 0
			Me.radRadioArray.Text = "Array"

			' 
			' radRadioDataTable
			' 
			Me.radRadioDataTable.Location = New Point(33, 52)
			Me.radRadioDataTable.Name = "radRadioDataTable"
			Me.radRadioDataTable.Size = New Size(74, 18)
			Me.radRadioDataTable.TabIndex = 0
			Me.radRadioDataTable.Text = "Data Table"

			' 
			' radRadioUnbound
			' 
			Me.radRadioUnbound.Location = New Point(33, 30)
			Me.radRadioUnbound.Name = "radRadioUnbound"
			Me.radRadioUnbound.Size = New Size(99, 18)
			Me.radRadioUnbound.TabIndex = 0
			Me.radRadioUnbound.Text = "Unbound mode"

			' 
			' radComboDemo
			' 
			Me.radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
			Me.radComboDemo.Location = New Point(20, 20)
			Me.radComboDemo.Name = "radComboDemo"
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.Size = New Size(306, 20)
			Me.radComboDemo.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1144, 489)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.NorthwindDataSetAccess, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBindingOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBindingOpts.ResumeLayout(False)
			Me.radGroupBindingOpts.PerformLayout()
			CType(Me.radRadioDB, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioArray, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioDataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioUnbound, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub



		#End Region

		Private NorthwindDataSetAccess As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter2 As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
		Private CustomerBindingSource As BindingSource
		Private employeesBindingSource As BindingSource
		Private radGroupBindingOpts As Telerik.WinControls.UI.RadGroupBox
		Private radRadioDB As Telerik.WinControls.UI.RadRadioButton
		Private radRadioArray As Telerik.WinControls.UI.RadRadioButton
		Private radRadioDataTable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioUnbound As Telerik.WinControls.UI.RadRadioButton
		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace