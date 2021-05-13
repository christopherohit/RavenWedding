Namespace Telerik.Examples.WinControls.GridView.Customize.FormattingWithCode
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
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewDecimalColumn1 As New Telerik.WinControls.UI.GridViewDecimalColumn()
			Me.employeeOrdersBindingSource = New BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.employeeOrdersTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonBackColor = New Telerik.WinControls.UI.RadButton()
			Me.radButtonForeColor = New Telerik.WinControls.UI.RadButton()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorLess = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorGreater = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.employeeOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButtonBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorLess, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorGreater, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(726, 1)
			Me.settingsPanel.Size = New Size(200, 774)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' employeeOrdersBindingSource
			' 
			Me.employeeOrdersBindingSource.DataMember = "EmployeeOrders"
			Me.employeeOrdersBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' employeeOrdersTableAdapter
			' 
			Me.employeeOrdersTableAdapter.ClearBeforeFill = True
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radButtonBackColor)
			Me.radGroupBox1.Controls.Add(Me.radButtonForeColor)
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorLess)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorGreater)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Set Quantity Condition:"
			Me.radGroupBox1.Location = New Point(10, 56)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 320)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Set Quantity Condition:"
			' 
			' radButtonBackColor
			' 
			Me.radButtonBackColor.Location = New Point(103, 180)
			Me.radButtonBackColor.Name = "radButtonBackColor"
			Me.radButtonBackColor.Size = New Size(64, 25)
			Me.radButtonBackColor.TabIndex = 9

			' 
			' radButtonForeColor
			' 
			Me.radButtonForeColor.Location = New Point(103, 140)
			Me.radButtonForeColor.Name = "radButtonForeColor"
			Me.radButtonForeColor.Size = New Size(64, 25)
			Me.radButtonForeColor.TabIndex = 8

			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(13, 180)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(60, 18)
			Me.radLabel4.TabIndex = 7
			Me.radLabel4.Text = "Back color:"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(13, 140)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(59, 18)
			Me.radLabel3.TabIndex = 5
			Me.radLabel3.Text = "Fore color:"
			' 
			' radSpinEditorLess
			' 
			Me.radSpinEditorLess.Location = New Point(13, 99)
			Me.radSpinEditorLess.Name = "radSpinEditorLess"
			' 
			' 
			' 
			Me.radSpinEditorLess.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorLess.ShowBorder = True
			Me.radSpinEditorLess.Size = New Size(154, 20)
			Me.radSpinEditorLess.TabIndex = 3
			Me.radSpinEditorLess.TabStop = False
			Me.radSpinEditorLess.Value = New Decimal(New Integer() { 10, 0, 0, 0})

			' 
			' radSpinEditorGreater
			' 
			Me.radSpinEditorGreater.Location = New Point(13, 53)
			Me.radSpinEditorGreater.Name = "radSpinEditorGreater"
			' 
			' 
			' 
			Me.radSpinEditorGreater.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorGreater.ShowBorder = True
			Me.radSpinEditorGreater.Size = New Size(154, 20)
			Me.radSpinEditorGreater.TabIndex = 2
			Me.radSpinEditorGreater.TabStop = False

			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(13, 79)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(99, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "Less than or equal:"
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(13, 33)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(116, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Greater than or equal:"
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			gridViewTextBoxColumn1.FieldName = "LastName"
			gridViewTextBoxColumn1.HeaderText = "LastName"
			gridViewTextBoxColumn1.IsAutoGenerated = True
			gridViewTextBoxColumn1.Name = "LastName"
			gridViewTextBoxColumn1.Width = 100
			gridViewTextBoxColumn2.FieldName = "FirstName"
			gridViewTextBoxColumn2.HeaderText = "FirstName"
			gridViewTextBoxColumn2.IsAutoGenerated = True
			gridViewTextBoxColumn2.Name = "FirstName"
			gridViewTextBoxColumn2.Width = 100
			gridViewTextBoxColumn3.FieldName = "Title"
			gridViewTextBoxColumn3.HeaderText = "Title"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "Title"
			gridViewTextBoxColumn3.Width = 150
			gridViewTextBoxColumn4.FieldName = "City"
			gridViewTextBoxColumn4.HeaderText = "City"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "City"
			gridViewTextBoxColumn4.Width = 100
			gridViewTextBoxColumn5.FieldName = "Country"
			gridViewTextBoxColumn5.HeaderText = "Country"
			gridViewTextBoxColumn5.IsAutoGenerated = True
			gridViewTextBoxColumn5.Name = "Country"
			gridViewTextBoxColumn5.Width = 100
			gridViewTextBoxColumn6.FieldName = "ShipName"
			gridViewTextBoxColumn6.HeaderText = "ShipName"
			gridViewTextBoxColumn6.IsAutoGenerated = True
			gridViewTextBoxColumn6.Name = "ShipName"
			gridViewTextBoxColumn6.Width = 120
			gridViewDecimalColumn1.DataType = GetType(Short)
			gridViewDecimalColumn1.FieldName = "Quantity"
			gridViewDecimalColumn1.HeaderText = "Quantity"
			gridViewDecimalColumn1.IsAutoGenerated = True
			gridViewDecimalColumn1.Name = "Quantity"
			gridViewDecimalColumn1.TextAlignment = ContentAlignment.MiddleRight
			gridViewDecimalColumn1.Width = 100
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewDecimalColumn1})
			Me.radGridView1.MasterTemplate.DataSource = Me.employeeOrdersBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New Size(927, 776)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(927, 776)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.employeeOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radButtonBackColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonForeColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorLess, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorGreater, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private employeeOrdersBindingSource As BindingSource
		Private employeeOrdersTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radSpinEditorLess As Telerik.WinControls.UI.RadSpinEditor
		Private radSpinEditorGreater As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radButtonBackColor As Telerik.WinControls.UI.RadButton
		Private radButtonForeColor As Telerik.WinControls.UI.RadButton
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
