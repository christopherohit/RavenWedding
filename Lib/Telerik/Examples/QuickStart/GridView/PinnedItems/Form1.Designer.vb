Namespace Telerik.Examples.WinControls.GridView.PinnedItems
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
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radGroupBoxColumns = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioButtonColumnPinnedRight = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonColumnPinnedLeft = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonColumnPinnedNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radComboBoxColumns = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBoxSysRows = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboBoxSystemRows = New Telerik.WinControls.UI.RadDropDownList()
			Me.aggregatesSampleTableBindingSource = New BindingSource(Me.components)
			Me.nwindRadGridView = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.aggregatesSampleTableTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter()
			Me.radLabelRowPinPosition = New Telerik.WinControls.UI.RadLabel()
			Me.radComboBoxRowPinPosition = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelSystemRowPosition = New Telerik.WinControls.UI.RadLabel()
			Me.radComboBoxSystemRowPosition = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxColumns.SuspendLayout()
			CType(Me.radRadioButtonColumnPinnedRight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonColumnPinnedLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButtonColumnPinnedNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBoxColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBoxSysRows, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxSysRows.SuspendLayout()
			CType(Me.radComboBoxSystemRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.aggregatesSampleTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelRowPinPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBoxRowPinPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelSystemRowPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBoxSystemRowPosition, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxColumns)
			Me.settingsPanel.Controls.Add(Me.radGroupBoxSysRows)
			Me.settingsPanel.Location = New Point(738, 1)
			Me.settingsPanel.Size = New Size(200, 723)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxSysRows, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxColumns, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter
			Me.radGridView1.Dock = DockStyle.Fill
			Me.radGridView1.EnableHotTracking = False
			Me.radGridView1.Location = New Point(0, 0)
			' 
			' 
			' 
			Me.radGridView1.MasterTemplate.Caption = Nothing
			Me.radGridView1.MasterTemplate.CurrentColumn = Nothing
			Me.radGridView1.MasterTemplate.CurrentRow = Nothing
			Me.radGridView1.MasterTemplate.VirtualMode = False
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.ShowNoDataText = False
			Me.radGridView1.Size = New Size(939, 725)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			' 
			' radGroupBoxColumns
			' 
			Me.radGroupBoxColumns.Anchor = AnchorStyles.Top
			Me.radGroupBoxColumns.Controls.Add(Me.radRadioButtonColumnPinnedRight)
			Me.radGroupBoxColumns.Controls.Add(Me.radRadioButtonColumnPinnedLeft)
			Me.radGroupBoxColumns.Controls.Add(Me.radRadioButtonColumnPinnedNone)
			Me.radGroupBoxColumns.Controls.Add(Me.radComboBoxColumns)
			Me.radGroupBoxColumns.FooterImageIndex = -1
			Me.radGroupBoxColumns.FooterImageKey = ""
			Me.radGroupBoxColumns.HeaderImageIndex = -1
			Me.radGroupBoxColumns.HeaderImageKey = ""
			Me.radGroupBoxColumns.HeaderMargin = New Padding(0)
			Me.radGroupBoxColumns.HeaderText = "Columns Position"
			Me.radGroupBoxColumns.Location = New Point(10, 38)
			Me.radGroupBoxColumns.Name = "radGroupBoxColumns"
			Me.radGroupBoxColumns.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBoxColumns.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBoxColumns.Size = New Size(180, 151)
			Me.radGroupBoxColumns.TabIndex = 1
			Me.radGroupBoxColumns.Text = "Columns Position"
			' 
			' radRadioButtonColumnPinnedRight
			' 
			Me.radRadioButtonColumnPinnedRight.Location = New Point(13, 118)
			Me.radRadioButtonColumnPinnedRight.Name = "radRadioButtonColumnPinnedRight"
			Me.radRadioButtonColumnPinnedRight.Size = New Size(144, 18)
			Me.radRadioButtonColumnPinnedRight.TabIndex = 3
			Me.radRadioButtonColumnPinnedRight.Text = "Right Pinned Position"

			' 
			' radRadioButtonColumnPinnedLeft
			' 
			Me.radRadioButtonColumnPinnedLeft.Location = New Point(13, 94)
			Me.radRadioButtonColumnPinnedLeft.Name = "radRadioButtonColumnPinnedLeft"
			Me.radRadioButtonColumnPinnedLeft.Size = New Size(131, 18)
			Me.radRadioButtonColumnPinnedLeft.TabIndex = 2
			Me.radRadioButtonColumnPinnedLeft.Text = "Left Pinned Position"

			' 
			' radRadioButtonColumnPinnedNone
			' 
			Me.radRadioButtonColumnPinnedNone.Location = New Point(13, 70)
			Me.radRadioButtonColumnPinnedNone.Name = "radRadioButtonColumnPinnedNone"
			Me.radRadioButtonColumnPinnedNone.Size = New Size(110, 18)
			Me.radRadioButtonColumnPinnedNone.TabIndex = 1
			Me.radRadioButtonColumnPinnedNone.Text = "None"

			' 
			' radComboBoxColumns
			' 
			Me.radComboBoxColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBoxColumns.Location = New Point(13, 32)
			Me.radComboBoxColumns.Name = "radComboBoxColumns"
			' 
			' 
			' 
			Me.radComboBoxColumns.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBoxColumns.Size = New Size(154, 20)
			Me.radComboBoxColumns.TabIndex = 0

			' 
			' radGroupBoxSysRows
			' 
			Me.radGroupBoxSysRows.Anchor = AnchorStyles.Top
			Me.radGroupBoxSysRows.Controls.Add(Me.radComboBoxSystemRowPosition)
			Me.radGroupBoxSysRows.Controls.Add(Me.radLabelSystemRowPosition)
			Me.radGroupBoxSysRows.Controls.Add(Me.radComboBoxRowPinPosition)
			Me.radGroupBoxSysRows.Controls.Add(Me.radLabelRowPinPosition)
			Me.radGroupBoxSysRows.Controls.Add(Me.radComboBoxSystemRows)
			Me.radGroupBoxSysRows.FooterImageIndex = -1
			Me.radGroupBoxSysRows.FooterImageKey = ""
			Me.radGroupBoxSysRows.HeaderImageIndex = -1
			Me.radGroupBoxSysRows.HeaderImageKey = ""
			Me.radGroupBoxSysRows.HeaderMargin = New Padding(0)
			Me.radGroupBoxSysRows.HeaderText = "System Rows Position"
			Me.radGroupBoxSysRows.Location = New Point(10, 195)
			Me.radGroupBoxSysRows.Name = "radGroupBoxSysRows"
			Me.radGroupBoxSysRows.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBoxSysRows.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBoxSysRows.Size = New Size(180, 162)
			Me.radGroupBoxSysRows.TabIndex = 2
			Me.radGroupBoxSysRows.Text = "System Rows Position"
			' 
			' radComboBoxSystemRows
			' 
			Me.radComboBoxSystemRows.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBoxSystemRows.Location = New Point(13, 33)
			Me.radComboBoxSystemRows.Name = "radComboBoxSystemRows"
			' 
			' 
			' 
			Me.radComboBoxSystemRows.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBoxSystemRows.Size = New Size(154, 20)
			Me.radComboBoxSystemRows.TabIndex = 0

			' 
			' aggregatesSampleTableBindingSource
			' 
			Me.aggregatesSampleTableBindingSource.DataMember = "EmployeeOrders"
			Me.aggregatesSampleTableBindingSource.DataSource = Me.nwindRadGridView
			' 
			' nwindRadGridView
			' 
			Me.nwindRadGridView.DataSetName = "NwindRadGridView"
			Me.nwindRadGridView.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' aggregatesSampleTableTableAdapter
			' 
			Me.aggregatesSampleTableTableAdapter.ClearBeforeFill = True
			' 
			' radLabelRowPinPosition
			' 
			Me.radLabelRowPinPosition.Location = New Point(13, 59)
			Me.radLabelRowPinPosition.Name = "radLabelRowPinPosition"
			Me.radLabelRowPinPosition.Size = New Size(70, 14)
			Me.radLabelRowPinPosition.TabIndex = 1
			Me.radLabelRowPinPosition.Text = "Row Pin Position"
			Me.radLabelRowPinPosition.TextWrap = True
			' 
			' radComboBoxRowPinPosition
			' 
			Me.radComboBoxRowPinPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBoxRowPinPosition.Location = New Point(13, 79)
			Me.radComboBoxRowPinPosition.Name = "radComboBoxRowPinPosition"
			' 
			' 
			' 
			Me.radComboBoxRowPinPosition.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBoxRowPinPosition.Size = New Size(154, 20)
			Me.radComboBoxRowPinPosition.TabIndex = 2

			' 
			' radLabelSystemRowPosition
			' 
			Me.radLabelSystemRowPosition.Location = New Point(13, 105)
			Me.radLabelSystemRowPosition.Name = "radLabelSystemRowPosition"
			Me.radLabelSystemRowPosition.Size = New Size(111, 14)
			Me.radLabelSystemRowPosition.TabIndex = 3
			Me.radLabelSystemRowPosition.Text = "System Row Position"
			Me.radLabelSystemRowPosition.TextWrap = True
			' 
			' radComboBoxSystemRowPosition
			' 
			Me.radComboBoxSystemRowPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBoxSystemRowPosition.Location = New Point(13, 125)
			Me.radComboBoxSystemRowPosition.Name = "radComboBoxSystemRowPosition"
			' 
			' 
			' 
			Me.radComboBoxSystemRowPosition.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBoxSystemRowPosition.Size = New Size(154, 20)
			Me.radComboBoxSystemRowPosition.TabIndex = 4

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Size(939, 725)

			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxColumns, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxColumns.ResumeLayout(False)
			Me.radGroupBoxColumns.PerformLayout()
			CType(Me.radRadioButtonColumnPinnedRight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonColumnPinnedLeft, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButtonColumnPinnedNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBoxColumns, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBoxSysRows, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxSysRows.ResumeLayout(False)
			Me.radGroupBoxSysRows.PerformLayout()
			CType(Me.radComboBoxSystemRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.aggregatesSampleTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindRadGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelRowPinPosition, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBoxRowPinPosition, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelSystemRowPosition, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBoxSystemRowPosition, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBoxColumns As Telerik.WinControls.UI.RadGroupBox
		Private radComboBoxColumns As Telerik.WinControls.UI.RadDropDownList
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radRadioButtonColumnPinnedRight As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonColumnPinnedLeft As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButtonColumnPinnedNone As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBoxSysRows As Telerik.WinControls.UI.RadGroupBox
		Private radComboBoxSystemRows As Telerik.WinControls.UI.RadDropDownList
		Private aggregatesSampleTableBindingSource As BindingSource
		Private nwindRadGridView As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private aggregatesSampleTableTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeeOrdersTableAdapter
		Private radComboBoxRowPinPosition As Telerik.WinControls.UI.RadDropDownList
		Private radLabelRowPinPosition As Telerik.WinControls.UI.RadLabel
		Private radLabelSystemRowPosition As Telerik.WinControls.UI.RadLabel
		Private radComboBoxSystemRowPosition As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace
