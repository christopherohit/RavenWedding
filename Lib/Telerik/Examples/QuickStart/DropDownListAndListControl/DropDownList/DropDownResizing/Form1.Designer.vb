Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.DropDownResizing
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
			Me.radGroupSizingMode = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioUpDown = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioBottomUpDown = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioRightBottom = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.employeesBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeesTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupSizingMode, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSizingMode.SuspendLayout()
			CType(Me.radRadioUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioBottomUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRightBottom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.MaximumSize = New Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.MaxSize = New Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New Size(362, 100)
			Me.radPanelDemoHolder.Size = New Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupSizingMode)
			Me.settingsPanel.Location = New Point(726, 1)
			Me.settingsPanel.Size = New Size(200, 734)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSizingMode, 0)
			' 
			' radGroupSizingMode
			' 
			Me.radGroupSizingMode.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupSizingMode.Anchor = AnchorStyles.Top
			Me.radGroupSizingMode.Controls.Add(Me.radRadioUpDown)
			Me.radGroupSizingMode.Controls.Add(Me.radRadioBottomUpDown)
			Me.radGroupSizingMode.Controls.Add(Me.radRadioRightBottom)
			Me.radGroupSizingMode.Controls.Add(Me.radRadioNone)
			Me.radGroupSizingMode.FooterText = ""
			Me.radGroupSizingMode.HeaderMargin = New Padding(10, 0, 0, 0)
			Me.radGroupSizingMode.HeaderText = " Sizing Mode "
			Me.radGroupSizingMode.Location = New Point(10, 6)
			Me.radGroupSizingMode.Name = "radGroupSizingMode"
			Me.radGroupSizingMode.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSizingMode.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupSizingMode.Size = New Size(180, 156)
			Me.radGroupSizingMode.TabIndex = 0
			Me.radGroupSizingMode.Text = " Sizing Mode "
			' 
			' radRadioUpDown
			' 
			Me.radRadioUpDown.Location = New Point(10, 105)
			Me.radRadioUpDown.Name = "radRadioUpDown"
			Me.radRadioUpDown.Size = New Size(64, 18)
			Me.radRadioUpDown.TabIndex = 3
			Me.radRadioUpDown.Text = "UpDown"

			' 
			' radRadioBottomUpDown
			' 
			Me.radRadioBottomUpDown.Location = New Point(10, 81)
			Me.radRadioBottomUpDown.Name = "radRadioBottomUpDown"
			Me.radRadioBottomUpDown.Size = New Size(153, 18)
			Me.radRadioBottomUpDown.TabIndex = 2
			Me.radRadioBottomUpDown.Text = "RightBottom and UpDown"

			' 
			' radRadioRightBottom
			' 
			Me.radRadioRightBottom.Location = New Point(10, 57)
			Me.radRadioRightBottom.Name = "radRadioRightBottom"
			Me.radRadioRightBottom.Size = New Size(84, 18)
			Me.radRadioRightBottom.TabIndex = 1
			Me.radRadioRightBottom.Text = "RightBottom"

			' 
			' radRadioNone
			' 
			Me.radRadioNone.Location = New Point(10, 33)
			Me.radRadioNone.Name = "radRadioNone"
			Me.radRadioNone.Size = New Size(48, 18)
			Me.radRadioNone.TabIndex = 0
			Me.radRadioNone.Text = "None"

			' 
			' radComboDemo
			' 
			Me.radComboDemo.AutoCompleteDisplayMember = "LastName"
			Me.radComboDemo.AutoCompleteValueMember = "EmployeeID"
			Me.radComboDemo.DataSource = Me.employeesBindingSource
			Me.radComboDemo.DisplayMember = "LastName"
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.Location = New Point(20, 20)
			Me.radComboDemo.Name = "radComboDemo"
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.Size = New Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.ThemeName = "ControlDefault"
			Me.radComboDemo.ValueMember = "EmployeeID"
			Me.radComboDemo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
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
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Name = "Form1"
			Me.Size = New Size(1142, 516)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGroupSizingMode, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSizingMode.ResumeLayout(False)
			Me.radGroupSizingMode.PerformLayout()
			CType(Me.radRadioUpDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioBottomUpDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioRightBottom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupSizingMode As Telerik.WinControls.UI.RadGroupBox
		Private radRadioUpDown As Telerik.WinControls.UI.RadRadioButton
		Private radRadioBottomUpDown As Telerik.WinControls.UI.RadRadioButton
		Private radRadioRightBottom As Telerik.WinControls.UI.RadRadioButton
		Private radRadioNone As Telerik.WinControls.UI.RadRadioButton
		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private employeesBindingSource As BindingSource
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeesTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter
	End Class
End Namespace
