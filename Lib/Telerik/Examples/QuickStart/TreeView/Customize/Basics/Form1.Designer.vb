Namespace Telerik.Examples.WinControls.TreeView.Customize.Basics
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
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radCheckBoxShowLines = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxShowRootLines = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxExpandCollapse = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFullRowSelect = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxAlternatingRowColor = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxAutoSizeItems = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorItemHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radButtonAlternatingRowColor = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxAnimations = New Telerik.WinControls.UI.RadCheckBox()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radButtonLineColor = New Telerik.WinControls.UI.RadButton()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorItemSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxShowRootLines, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxExpandCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxFullRowSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAlternatingRowColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxAutoSizeItems, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonAlternatingRowColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radCheckBoxAnimations, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonLineColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Location = New Point(982, 1)
			Me.settingsPanel.Size = New Size(200, 830)

			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.radTreeView1.Location = New Point(67, 17)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New Size(246, 441)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' radCheckBoxShowLines
			' 
			Me.radCheckBoxShowLines.Location = New Point(13, 25)
			Me.radCheckBoxShowLines.Name = "radCheckBoxShowLines"
			Me.radCheckBoxShowLines.Size = New Size(73, 18)
			Me.radCheckBoxShowLines.TabIndex = 1
			Me.radCheckBoxShowLines.Text = "Show lines"

			' 
			' radCheckBoxShowRootLines
			' 
			Me.radCheckBoxShowRootLines.Location = New Point(13, 49)
			Me.radCheckBoxShowRootLines.Name = "radCheckBoxShowRootLines"
			Me.radCheckBoxShowRootLines.Size = New Size(97, 18)
			Me.radCheckBoxShowRootLines.TabIndex = 2
			Me.radCheckBoxShowRootLines.Text = "Show root lines"

			' 
			' radCheckBoxExpandCollapse
			' 
			Me.radCheckBoxExpandCollapse.Location = New Point(13, 74)
			Me.radCheckBoxExpandCollapse.Name = "radCheckBoxExpandCollapse"
			Me.radCheckBoxExpandCollapse.Size = New Size(132, 18)
			Me.radCheckBoxExpandCollapse.TabIndex = 3
			Me.radCheckBoxExpandCollapse.Text = "Show expand/collapse"

			' 
			' radCheckBoxFullRowSelect
			' 
			Me.radCheckBoxFullRowSelect.Location = New Point(13, 99)
			Me.radCheckBoxFullRowSelect.Name = "radCheckBoxFullRowSelect"
			Me.radCheckBoxFullRowSelect.Size = New Size(91, 18)
			Me.radCheckBoxFullRowSelect.TabIndex = 4
			Me.radCheckBoxFullRowSelect.Text = "Full row select"

			' 
			' radCheckBoxAlternatingRowColor
			' 
			Me.radCheckBoxAlternatingRowColor.Location = New Point(14, 23)
			Me.radCheckBoxAlternatingRowColor.Name = "radCheckBoxAlternatingRowColor"
			Me.radCheckBoxAlternatingRowColor.Size = New Size(104, 18)
			Me.radCheckBoxAlternatingRowColor.TabIndex = 5
			Me.radCheckBoxAlternatingRowColor.Text = "Alternating color"

			' 
			' radCheckBoxAutoSizeItems
			' 
			Me.radCheckBoxAutoSizeItems.Location = New Point(8, 23)
			Me.radCheckBoxAutoSizeItems.Name = "radCheckBoxAutoSizeItems"
			Me.radCheckBoxAutoSizeItems.Size = New Size(96, 18)
			Me.radCheckBoxAutoSizeItems.TabIndex = 6
			Me.radCheckBoxAutoSizeItems.Text = "Auto size items"

			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(11, 48)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(66, 18)
			Me.radLabel1.TabIndex = 7
			Me.radLabel1.Text = "Item height:"
			' 
			' radSpinEditorItemHeight
			' 
			Me.radSpinEditorItemHeight.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radSpinEditorItemHeight.Location = New Point(87, 48)
			Me.radSpinEditorItemHeight.Maximum = New Decimal(New Integer() { 60, 0, 0, 0})
			Me.radSpinEditorItemHeight.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight"
			' 
			' 
			' 
			Me.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemHeight.Size = New Size(57, 20)
			Me.radSpinEditorItemHeight.TabIndex = 8
			Me.radSpinEditorItemHeight.TabStop = False
			Me.radSpinEditorItemHeight.Tag = "Right"
			Me.radSpinEditorItemHeight.Value = New Decimal(New Integer() { 10, 0, 0, 0})

			' 
			' radButtonAlternatingRowColor
			' 
			Me.radButtonAlternatingRowColor.Enabled = False
			Me.radButtonAlternatingRowColor.Location = New Point(130, 23)
			Me.radButtonAlternatingRowColor.Name = "radButtonAlternatingRowColor"
			Me.radButtonAlternatingRowColor.Size = New Size(35, 24)
			Me.radButtonAlternatingRowColor.TabIndex = 11
			Me.radButtonAlternatingRowColor.Tag = "Right"

			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowLines)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowRootLines)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxExpandCollapse)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxFullRowSelect)
			Me.radGroupBox1.HeaderText = "General Settings"
			Me.radGroupBox1.Location = New Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 129)
			Me.radGroupBox1.TabIndex = 12
			Me.radGroupBox1.Text = "General Settings"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxAnimations)
			Me.radGroupBox2.Controls.Add(Me.radDropDownList1)
			Me.radGroupBox2.Controls.Add(Me.radLabel4)
			Me.radGroupBox2.Controls.Add(Me.radButtonLineColor)
			Me.radGroupBox2.Controls.Add(Me.radLabel2)
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxAlternatingRowColor)
			Me.radGroupBox2.Controls.Add(Me.radButtonAlternatingRowColor)
			Me.radGroupBox2.HeaderText = "Colors & style"
			Me.radGroupBox2.Location = New Point(10, 172)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(180, 164)
			Me.radGroupBox2.TabIndex = 13
			Me.radGroupBox2.Text = "Colors & style"
			' 
			' radCheckBoxAnimations
			' 
			Me.radCheckBoxAnimations.Location = New Point(17, 139)
			Me.radCheckBoxAnimations.Name = "radCheckBoxAnimations"
			Me.radCheckBoxAnimations.Size = New Size(106, 18)
			Me.radCheckBoxAnimations.TabIndex = 16
			Me.radCheckBoxAnimations.Text = "Allow animations"

			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "Solid"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Dash"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "Dot"
			radListDataItem3.TextWrap = True
			radListDataItem4.Text = "DashDot"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "DashDotDot"
			radListDataItem5.TextWrap = True
			Me.radDropDownList1.Items.Add(radListDataItem1)
			Me.radDropDownList1.Items.Add(radListDataItem2)
			Me.radDropDownList1.Items.Add(radListDataItem3)
			Me.radDropDownList1.Items.Add(radListDataItem4)
			Me.radDropDownList1.Items.Add(radListDataItem5)
			Me.radDropDownList1.Location = New Point(17, 111)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(146, 20)
			Me.radDropDownList1.TabIndex = 15

			' 
			' radLabel4
			' 
			Me.radLabel4.Location = New Point(14, 87)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(55, 18)
			Me.radLabel4.TabIndex = 14
			Me.radLabel4.Text = "Line style:"
			' 
			' radButtonLineColor
			' 
			Me.radButtonLineColor.Enabled = False
			Me.radButtonLineColor.Location = New Point(130, 53)
			Me.radButtonLineColor.Name = "radButtonLineColor"
			Me.radButtonLineColor.Size = New Size(35, 24)
			Me.radButtonLineColor.TabIndex = 13
			Me.radButtonLineColor.Tag = "Right"

			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(14, 53)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(62, 18)
			Me.radLabel2.TabIndex = 12
			Me.radLabel2.Text = "Line colors:"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.radLabel3)
			Me.radGroupBox3.Controls.Add(Me.radSpinEditorItemSpacing)
			Me.radGroupBox3.Controls.Add(Me.radCheckBoxAutoSizeItems)
			Me.radGroupBox3.Controls.Add(Me.radLabel1)
			Me.radGroupBox3.Controls.Add(Me.radSpinEditorItemHeight)
			Me.radGroupBox3.HeaderText = "Item sizing & layout"
			Me.radGroupBox3.Location = New Point(10, 342)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox3.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox3.Size = New Size(180, 106)
			Me.radGroupBox3.TabIndex = 14
			Me.radGroupBox3.Text = "Item sizing & layout"
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(12, 75)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(73, 18)
			Me.radLabel3.TabIndex = 15
			Me.radLabel3.Text = "Item spacing:"
			' 
			' radSpinEditorItemSpacing
			' 
			Me.radSpinEditorItemSpacing.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radSpinEditorItemSpacing.Location = New Point(87, 75)
			Me.radSpinEditorItemSpacing.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditorItemSpacing.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing"
			' 
			' 
			' 
			Me.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemSpacing.Size = New Size(57, 20)
			Me.radSpinEditorItemSpacing.TabIndex = 16
			Me.radSpinEditorItemSpacing.TabStop = False
			Me.radSpinEditorItemSpacing.Tag = "Right"

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New Size(1288, 599)
			Me.Controls.SetChildIndex(Me.radTreeView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowLines, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxShowRootLines, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxExpandCollapse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxFullRowSelect, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAlternatingRowColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxAutoSizeItems, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonAlternatingRowColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radCheckBoxAnimations, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonLineColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radCheckBoxShowLines As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxShowRootLines As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxExpandCollapse As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFullRowSelect As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxAlternatingRowColor As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxAutoSizeItems As Telerik.WinControls.UI.RadCheckBox
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorItemHeight As Telerik.WinControls.UI.RadSpinEditor
		Private radButtonAlternatingRowColor As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorItemSpacing As Telerik.WinControls.UI.RadSpinEditor
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radButtonLineColor As Telerik.WinControls.UI.RadButton
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radCheckBoxAnimations As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace