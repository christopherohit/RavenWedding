Namespace Telerik.Examples.WinControls.DataFilter.Settings
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
			Me.radDataFilter1 = New Telerik.WinControls.UI.RadDataFilter()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radButtonLoadXml = New Telerik.WinControls.UI.RadButton()
			Me.radButtonSaveXml = New Telerik.WinControls.UI.RadButton()
			Me.radCheckBoxAllowAdd = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxAllowRemove = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditorTreeIndent = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBoxAllowEdit = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabelTreeIndent = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorNodeSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBoxAllowDragDrop = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxShowLines = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabelNodeSpacing = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBoxSortFieldNames = New Telerik.WinControls.UI.RadCheckBox()
			Me.radDropDownListLineStyle = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelLineColor = New Telerik.WinControls.UI.RadLabel()
			Me.radLabelLineStyle = New Telerik.WinControls.UI.RadLabel()
			Me.radColorBoxLineColor = New Telerik.WinControls.UI.RadColorBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDataFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			CType(Me.radButtonLoadXml, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonSaveXml, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAllowAdd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAllowRemove, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorTreeIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelTreeIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorNodeSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAllowDragDrop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelNodeSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxSortFieldNames, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownListLineStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelLineColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelLineStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radColorBoxLineColor, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1568, 22)
			Me.settingsPanel.Margin = New Padding(4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Margin = New Padding(4)
			Me.settingsPanel.PanelContainer.Size = New Size(316, 589)
			Me.settingsPanel.Size = New Size(316, 589)
			' 
			' radDataFilter1
			' 
			Me.radDataFilter1.ItemHeight = 36
            Me.radDataFilter1.Location = New Point(20, 20)
			Me.radDataFilter1.Name = "radDataFilter1"
			Me.radDataFilter1.Padding = New Padding(7, 5, 7, 5)
			Me.radDataFilter1.Size = New Size(720, 363)
			Me.radDataFilter1.TabIndex = 2
			Me.radDataFilter1.TreeIndent = 26
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.radGroupBox1.HeaderText = "Settings"
			Me.radGroupBox1.Location = New Point(18, 39)
			Me.radGroupBox1.Margin = New Padding(4)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(3, 22, 3, 2)
			Me.radGroupBox1.Size = New Size(280, 524)
			Me.radGroupBox1.TabIndex = 8
			Me.radGroupBox1.Text = "Settings"
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonLoadXml, 0, 11)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBoxAllowAdd, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonSaveXml, 0, 10)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBoxAllowRemove, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radSpinEditorTreeIndent, 1, 9)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBoxAllowEdit, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelTreeIndent, 0, 9)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radSpinEditorNodeSpacing, 1, 8)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBoxAllowDragDrop, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBoxShowLines, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelNodeSpacing, 0, 8)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBoxSortFieldNames, 0, 5)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownListLineStyle, 1, 7)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelLineColor, 0, 6)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabelLineStyle, 0, 7)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radColorBoxLineColor, 1, 6)
			Me.doubleBufferedTableLayoutPanel1.Dock = DockStyle.Fill
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(3, 22)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 12
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(274, 500)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 9
			' 
			' radButtonLoadXml
			' 
			Me.radButtonLoadXml.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radButtonLoadXml, 2)
			Me.radButtonLoadXml.Location = New Point(4, 455)
			Me.radButtonLoadXml.Margin = New Padding(4)
			Me.radButtonLoadXml.Name = "radButtonLoadXml"
			Me.radButtonLoadXml.Size = New Size(266, 30)
			Me.radButtonLoadXml.TabIndex = 16
			Me.radButtonLoadXml.Text = "Load XML File"
'			Me.radButtonLoadXml.Click += New System.EventHandler(Me.radButtonLoadXml_Click)
			' 
			' radButtonSaveXml
			' 
			Me.radButtonSaveXml.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radButtonSaveXml, 2)
			Me.radButtonSaveXml.Location = New Point(4, 414)
			Me.radButtonSaveXml.Margin = New Padding(4)
			Me.radButtonSaveXml.Name = "radButtonSaveXml"
			Me.radButtonSaveXml.Size = New Size(266, 30)
			Me.radButtonSaveXml.TabIndex = 15
			Me.radButtonSaveXml.Text = "Save XML File"
'			Me.radButtonSaveXml.Click += New System.EventHandler(Me.radButtonSaveXml_Click)
			' 
			' radCheckBoxAllowAdd
			' 
			Me.radCheckBoxAllowAdd.CheckState = CheckState.Checked
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCheckBoxAllowAdd, 2)
			Me.radCheckBoxAllowAdd.Location = New Point(4, 4)
			Me.radCheckBoxAllowAdd.Margin = New Padding(4)
			Me.radCheckBoxAllowAdd.Name = "radCheckBoxAllowAdd"
			Me.radCheckBoxAllowAdd.Size = New Size(129, 22)
			Me.radCheckBoxAllowAdd.TabIndex = 1
			Me.radCheckBoxAllowAdd.Text = "Allow Add Expressions"
			Me.radCheckBoxAllowAdd.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxAllowAdd.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAllowAdd_ToggleStateChanged)
			' 
			' radCheckBoxAllowRemove
			' 
			Me.radCheckBoxAllowRemove.CheckState = CheckState.Checked
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCheckBoxAllowRemove, 2)
			Me.radCheckBoxAllowRemove.Location = New Point(4, 45)
			Me.radCheckBoxAllowRemove.Margin = New Padding(4)
			Me.radCheckBoxAllowRemove.Name = "radCheckBoxAllowRemove"
			Me.radCheckBoxAllowRemove.Size = New Size(129, 22)
			Me.radCheckBoxAllowRemove.TabIndex = 2
			Me.radCheckBoxAllowRemove.Text = "Allow Remove Expressions"
			Me.radCheckBoxAllowRemove.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxAllowRemove.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAllowRemove_ToggleStateChanged)
			' 
			' radSpinEditorTreeIndent
			' 
			Me.radSpinEditorTreeIndent.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radSpinEditorTreeIndent.Location = New Point(141, 373)
			Me.radSpinEditorTreeIndent.Margin = New Padding(4)
			Me.radSpinEditorTreeIndent.Name = "radSpinEditorTreeIndent"
			Me.radSpinEditorTreeIndent.NullableValue = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.radSpinEditorTreeIndent.Size = New Size(129, 20)
			Me.radSpinEditorTreeIndent.TabIndex = 13
			Me.radSpinEditorTreeIndent.TabStop = False
			Me.radSpinEditorTreeIndent.Tag = "Right"
			Me.radSpinEditorTreeIndent.Value = New Decimal(New Integer() { 20, 0, 0, 0})
'			Me.radSpinEditorTreeIndent.ValueChanged += New System.EventHandler(Me.radSpinEditorTreeIndent_ValueChanged)
			' 
			' radCheckBoxAllowEdit
			' 
			Me.radCheckBoxAllowEdit.CheckState = CheckState.Checked
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCheckBoxAllowEdit, 2)
			Me.radCheckBoxAllowEdit.Location = New Point(4, 127)
			Me.radCheckBoxAllowEdit.Margin = New Padding(4)
			Me.radCheckBoxAllowEdit.Name = "radCheckBoxAllowEdit"
			Me.radCheckBoxAllowEdit.Size = New Size(129, 22)
			Me.radCheckBoxAllowEdit.TabIndex = 14
			Me.radCheckBoxAllowEdit.Text = "Allow Edit Expressions"
			Me.radCheckBoxAllowEdit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxAllowEdit.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAllowEdit_ToggleStateChanged)
			' 
			' radLabelTreeIndent
			' 
			Me.radLabelTreeIndent.Location = New Point(4, 373)
			Me.radLabelTreeIndent.Margin = New Padding(4)
			Me.radLabelTreeIndent.Name = "radLabelTreeIndent"
			Me.radLabelTreeIndent.Size = New Size(80, 22)
			Me.radLabelTreeIndent.TabIndex = 11
			Me.radLabelTreeIndent.Text = "Tree Indent:"
			' 
			' radSpinEditorNodeSpacing
			' 
			Me.radSpinEditorNodeSpacing.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radSpinEditorNodeSpacing.Location = New Point(141, 332)
			Me.radSpinEditorNodeSpacing.Margin = New Padding(4)
			Me.radSpinEditorNodeSpacing.Maximum = New Decimal(New Integer() { 15, 0, 0, 0})
			Me.radSpinEditorNodeSpacing.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditorNodeSpacing.Name = "radSpinEditorNodeSpacing"
			Me.radSpinEditorNodeSpacing.Size = New Size(129, 20)
			Me.radSpinEditorNodeSpacing.TabIndex = 12
			Me.radSpinEditorNodeSpacing.TabStop = False
			Me.radSpinEditorNodeSpacing.Tag = "Right"
'			Me.radSpinEditorNodeSpacing.ValueChanged += New System.EventHandler(Me.radSpinEditorNodeSpacing_ValueChanged)
			' 
			' radCheckBoxAllowDragDrop
			' 
			Me.radCheckBoxAllowDragDrop.CheckState = CheckState.Checked
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCheckBoxAllowDragDrop, 2)
			Me.radCheckBoxAllowDragDrop.Location = New Point(4, 86)
			Me.radCheckBoxAllowDragDrop.Margin = New Padding(4)
			Me.radCheckBoxAllowDragDrop.Name = "radCheckBoxAllowDragDrop"
			Me.radCheckBoxAllowDragDrop.Size = New Size(129, 22)
			Me.radCheckBoxAllowDragDrop.TabIndex = 3
			Me.radCheckBoxAllowDragDrop.Text = "Allow Drag and Drop"
			Me.radCheckBoxAllowDragDrop.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxAllowDragDrop.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxAllowDragDrop_ToggleStateChanged)
			' 
			' radCheckBoxShowLines
			' 
			Me.radCheckBoxShowLines.CheckState = CheckState.Checked
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCheckBoxShowLines, 2)
			Me.radCheckBoxShowLines.Location = New Point(4, 168)
			Me.radCheckBoxShowLines.Margin = New Padding(4)
			Me.radCheckBoxShowLines.Name = "radCheckBoxShowLines"
			Me.radCheckBoxShowLines.Size = New Size(129, 22)
			Me.radCheckBoxShowLines.TabIndex = 4
			Me.radCheckBoxShowLines.Text = "Show Lines Between Nodes"
			Me.radCheckBoxShowLines.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckBoxShowLines.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxShowLines_ToggleStateChanged)
			' 
			' radLabelNodeSpacing
			' 
			Me.radLabelNodeSpacing.Location = New Point(4, 332)
			Me.radLabelNodeSpacing.Margin = New Padding(4)
			Me.radLabelNodeSpacing.Name = "radLabelNodeSpacing"
			Me.radLabelNodeSpacing.Size = New Size(97, 22)
			Me.radLabelNodeSpacing.TabIndex = 10
			Me.radLabelNodeSpacing.Text = "Node Spacing:"
			' 
			' radCheckBoxSortFieldNames
			' 
			Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.radCheckBoxSortFieldNames, 2)
			Me.radCheckBoxSortFieldNames.Location = New Point(4, 209)
			Me.radCheckBoxSortFieldNames.Margin = New Padding(4)
			Me.radCheckBoxSortFieldNames.Name = "radCheckBoxSortFieldNames"
			Me.radCheckBoxSortFieldNames.Size = New Size(129, 22)
			Me.radCheckBoxSortFieldNames.TabIndex = 5
			Me.radCheckBoxSortFieldNames.Text = "Sort Field Names in drop down"
'			Me.radCheckBoxSortFieldNames.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxSortFieldNames_ToggleStateChanged)
			' 
			' radDropDownListLineStyle
			' 
			Me.radDropDownListLineStyle.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radDropDownListLineStyle.DropDownHeight = 141
			Me.radDropDownListLineStyle.Location = New Point(141, 291)
			Me.radDropDownListLineStyle.Margin = New Padding(4)
			Me.radDropDownListLineStyle.Name = "radDropDownListLineStyle"
			Me.radDropDownListLineStyle.Size = New Size(129, 20)
			Me.radDropDownListLineStyle.TabIndex = 9
			Me.radDropDownListLineStyle.Tag = "Right"
			Me.radDropDownListLineStyle.Text = "Solid"
'			Me.radDropDownListLineStyle.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radDropDownListLineStyle_SelectedIndexChanged)
			' 
			' radLabelLineColor
			' 
			Me.radLabelLineColor.Location = New Point(4, 250)
			Me.radLabelLineColor.Margin = New Padding(4)
			Me.radLabelLineColor.Name = "radLabelLineColor"
			Me.radLabelLineColor.Size = New Size(72, 22)
			Me.radLabelLineColor.TabIndex = 6
			Me.radLabelLineColor.Text = "Line Color:"
			' 
			' radLabelLineStyle
			' 
			Me.radLabelLineStyle.Location = New Point(4, 291)
			Me.radLabelLineStyle.Margin = New Padding(4)
			Me.radLabelLineStyle.Name = "radLabelLineStyle"
			Me.radLabelLineStyle.Size = New Size(69, 22)
			Me.radLabelLineStyle.TabIndex = 8
			Me.radLabelLineStyle.Text = "Line Style:"
			' 
			' radColorBoxLineColor
			' 
			Me.radColorBoxLineColor.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radColorBoxLineColor.Location = New Point(141, 250)
			Me.radColorBoxLineColor.Margin = New Padding(4)
			Me.radColorBoxLineColor.Name = "radColorBoxLineColor"
			Me.radColorBoxLineColor.Size = New Size(129, 20)
			Me.radColorBoxLineColor.TabIndex = 7
			Me.radColorBoxLineColor.Tag = "Right"
			Me.radColorBoxLineColor.Value = Color.FromArgb((CInt((CByte(243)))), (CInt((CByte(243)))), (CInt((CByte(244)))))
'			Me.radColorBoxLineColor.ValueChanged += New System.EventHandler(Me.radColorBoxLineColor_ValueChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radDataFilter1)
			Me.Name = "Form1"
			Me.Size = New Size(2072, 1156)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radDataFilter1, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDataFilter1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.PerformLayout()
			CType(Me.radButtonLoadXml, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonSaveXml, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAllowAdd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAllowRemove, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorTreeIndent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAllowEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelTreeIndent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorNodeSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAllowDragDrop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelNodeSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxSortFieldNames, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownListLineStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelLineColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelLineStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radColorBoxLineColor, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radCheckBoxAllowAdd As Telerik.WinControls.UI.RadCheckBox
		Private radDataFilter1 As Telerik.WinControls.UI.RadDataFilter
		Private WithEvents radCheckBoxAllowDragDrop As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxAllowRemove As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxSortFieldNames As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBoxShowLines As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radColorBoxLineColor As Telerik.WinControls.UI.RadColorBox
		Private radLabelLineColor As Telerik.WinControls.UI.RadLabel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radLabelLineStyle As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDropDownListLineStyle As Telerik.WinControls.UI.RadDropDownList
		Private radLabelTreeIndent As Telerik.WinControls.UI.RadLabel
		Private radLabelNodeSpacing As Telerik.WinControls.UI.RadLabel
		Private WithEvents radSpinEditorNodeSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radSpinEditorTreeIndent As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents radCheckBoxAllowEdit As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radButtonLoadXml As Telerik.WinControls.UI.RadButton
		Private WithEvents radButtonSaveXml As Telerik.WinControls.UI.RadButton
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace