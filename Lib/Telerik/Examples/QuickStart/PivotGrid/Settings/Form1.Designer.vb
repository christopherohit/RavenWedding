Namespace Telerik.Examples.WinControls.PivotGrid.Settings
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.rowGrandTotalNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.rowGrandTotalLast = New Telerik.WinControls.UI.RadRadioButton()
			Me.rowGrandTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.rowSubTotalNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.rowSubTotalLast = New Telerik.WinControls.UI.RadRadioButton()
			Me.rowSubTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.columnGrandTotalNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.columnGrandTotalLast = New Telerik.WinControls.UI.RadRadioButton()
			Me.columnGrandTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
			Me.columnSubTotalNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.columnSubTotalLast = New Telerik.WinControls.UI.RadRadioButton()
			Me.columnSubTotalFirst = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.aggregatePositionColumns = New Telerik.WinControls.UI.RadRadioButton()
			Me.aggregatePositionRows = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.rowGrandTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rowGrandTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rowGrandTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.rowSubTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rowSubTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rowSubTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.columnGrandTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.columnGrandTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.columnGrandTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox4.SuspendLayout()
			CType(Me.columnSubTotalNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.columnSubTotalLast, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.columnSubTotalFirst, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox5.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.aggregatePositionColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.aggregatePositionRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox6.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox6)
			Me.settingsPanel.Controls.Add(Me.radGroupBox5)
			Me.settingsPanel.Controls.Add(Me.radGroupBox4)
			Me.settingsPanel.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Dock = DockStyle.Right
			Me.settingsPanel.Location = New Point(1218, 0)
			Me.settingsPanel.Size = New Size(286, 990)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox4, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox5, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox6, 0)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.rowGrandTotalNone)
			Me.radGroupBox1.Controls.Add(Me.rowGrandTotalLast)
			Me.radGroupBox1.Controls.Add(Me.rowGrandTotalFirst)
			Me.radGroupBox1.HeaderText = "Rows GrandTotals Position"
			Me.radGroupBox1.Location = New Point(10, 7)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(266, 94)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Rows GrandTotals Position"
			' 
			' rowGrandTotalNone
			' 
			Me.rowGrandTotalNone.Anchor = AnchorStyles.Top
			Me.rowGrandTotalNone.Location = New Point(5, 70)
			Me.rowGrandTotalNone.Name = "rowGrandTotalNone"
			Me.rowGrandTotalNone.Size = New Size(48, 18)
			Me.rowGrandTotalNone.TabIndex = 2
			Me.rowGrandTotalNone.Text = "None"
			' 
			' rowGrandTotalLast
			' 
			Me.rowGrandTotalLast.Anchor = AnchorStyles.Top
			Me.rowGrandTotalLast.Location = New Point(5, 46)
			Me.rowGrandTotalLast.Name = "rowGrandTotalLast"
			Me.rowGrandTotalLast.Size = New Size(40, 18)
			Me.rowGrandTotalLast.TabIndex = 1
			Me.rowGrandTotalLast.Text = "Last"
			' 
			' rowGrandTotalFirst
			' 
			Me.rowGrandTotalFirst.Anchor = AnchorStyles.Top
			Me.rowGrandTotalFirst.Location = New Point(5, 22)
			Me.rowGrandTotalFirst.Name = "rowGrandTotalFirst"
			Me.rowGrandTotalFirst.Size = New Size(41, 18)
			Me.rowGrandTotalFirst.TabIndex = 0
			Me.rowGrandTotalFirst.Text = "First"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.rowSubTotalNone)
			Me.radGroupBox2.Controls.Add(Me.rowSubTotalLast)
			Me.radGroupBox2.Controls.Add(Me.rowSubTotalFirst)
			Me.radGroupBox2.HeaderText = "Rows SubTotals Position"
			Me.radGroupBox2.Location = New Point(10, 107)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New Size(266, 93)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = "Rows SubTotals Position"
			' 
			' rowSubTotalNone
			' 
			Me.rowSubTotalNone.Anchor = AnchorStyles.Top
			Me.rowSubTotalNone.Location = New Point(5, 69)
			Me.rowSubTotalNone.Name = "rowSubTotalNone"
			Me.rowSubTotalNone.Size = New Size(48, 18)
			Me.rowSubTotalNone.TabIndex = 5
			Me.rowSubTotalNone.Text = "None"
			' 
			' rowSubTotalLast
			' 
			Me.rowSubTotalLast.Anchor = AnchorStyles.Top
			Me.rowSubTotalLast.Location = New Point(5, 45)
			Me.rowSubTotalLast.Name = "rowSubTotalLast"
			Me.rowSubTotalLast.Size = New Size(40, 18)
			Me.rowSubTotalLast.TabIndex = 4
			Me.rowSubTotalLast.Text = "Last"
			' 
			' rowSubTotalFirst
			' 
			Me.rowSubTotalFirst.Anchor = AnchorStyles.Top
			Me.rowSubTotalFirst.Location = New Point(5, 21)
			Me.rowSubTotalFirst.Name = "rowSubTotalFirst"
			Me.rowSubTotalFirst.Size = New Size(41, 18)
			Me.rowSubTotalFirst.TabIndex = 3
			Me.rowSubTotalFirst.Text = "First"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.columnGrandTotalNone)
			Me.radGroupBox3.Controls.Add(Me.columnGrandTotalLast)
			Me.radGroupBox3.Controls.Add(Me.columnGrandTotalFirst)
			Me.radGroupBox3.HeaderText = "Columns GrandTotals Position"
			Me.radGroupBox3.Location = New Point(10, 206)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Size = New Size(266, 97)
			Me.radGroupBox3.TabIndex = 3
			Me.radGroupBox3.Text = "Columns GrandTotals Position"
			' 
			' columnGrandTotalNone
			' 
			Me.columnGrandTotalNone.Anchor = AnchorStyles.Top
			Me.columnGrandTotalNone.Location = New Point(5, 69)
			Me.columnGrandTotalNone.Name = "columnGrandTotalNone"
			Me.columnGrandTotalNone.Size = New Size(48, 18)
			Me.columnGrandTotalNone.TabIndex = 5
			Me.columnGrandTotalNone.Text = "None"
			' 
			' columnGrandTotalLast
			' 
			Me.columnGrandTotalLast.Anchor = AnchorStyles.Top
			Me.columnGrandTotalLast.Location = New Point(5, 45)
			Me.columnGrandTotalLast.Name = "columnGrandTotalLast"
			Me.columnGrandTotalLast.Size = New Size(40, 18)
			Me.columnGrandTotalLast.TabIndex = 4
			Me.columnGrandTotalLast.Text = "Last"
			' 
			' columnGrandTotalFirst
			' 
			Me.columnGrandTotalFirst.Anchor = AnchorStyles.Top
			Me.columnGrandTotalFirst.Location = New Point(5, 21)
			Me.columnGrandTotalFirst.Name = "columnGrandTotalFirst"
			Me.columnGrandTotalFirst.Size = New Size(41, 18)
			Me.columnGrandTotalFirst.TabIndex = 3
			Me.columnGrandTotalFirst.Text = "First"
			' 
			' radGroupBox4
			' 
			Me.radGroupBox4.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox4.Anchor = AnchorStyles.Top
			Me.radGroupBox4.Controls.Add(Me.columnSubTotalNone)
			Me.radGroupBox4.Controls.Add(Me.columnSubTotalLast)
			Me.radGroupBox4.Controls.Add(Me.columnSubTotalFirst)
			Me.radGroupBox4.HeaderText = "Columns SubTotals Position"
			Me.radGroupBox4.Location = New Point(10, 309)
			Me.radGroupBox4.Name = "radGroupBox4"
			Me.radGroupBox4.Size = New Size(266, 99)
			Me.radGroupBox4.TabIndex = 4
			Me.radGroupBox4.Text = "Columns SubTotals Position"
			' 
			' columnSubTotalNone
			' 
			Me.columnSubTotalNone.Anchor = AnchorStyles.Top
			Me.columnSubTotalNone.Location = New Point(5, 69)
			Me.columnSubTotalNone.Name = "columnSubTotalNone"
			Me.columnSubTotalNone.Size = New Size(48, 18)
			Me.columnSubTotalNone.TabIndex = 5
			Me.columnSubTotalNone.Text = "None"
			' 
			' columnSubTotalLast
			' 
			Me.columnSubTotalLast.Anchor = AnchorStyles.Top
			Me.columnSubTotalLast.Location = New Point(5, 45)
			Me.columnSubTotalLast.Name = "columnSubTotalLast"
			Me.columnSubTotalLast.Size = New Size(40, 18)
			Me.columnSubTotalLast.TabIndex = 4
			Me.columnSubTotalLast.Text = "Last"
			' 
			' columnSubTotalFirst
			' 
			Me.columnSubTotalFirst.Anchor = AnchorStyles.Top
			Me.columnSubTotalFirst.Location = New Point(5, 21)
			Me.columnSubTotalFirst.Name = "columnSubTotalFirst"
			Me.columnSubTotalFirst.Size = New Size(41, 18)
			Me.columnSubTotalFirst.TabIndex = 3
			Me.columnSubTotalFirst.Text = "First"
			' 
			' radGroupBox5
			' 
			Me.radGroupBox5.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox5.Anchor = AnchorStyles.Top
			Me.radGroupBox5.Controls.Add(Me.radLabel1)
			Me.radGroupBox5.Controls.Add(Me.radSpinEditor1)
			Me.radGroupBox5.Controls.Add(Me.aggregatePositionColumns)
			Me.radGroupBox5.Controls.Add(Me.aggregatePositionRows)
			Me.radGroupBox5.HeaderText = "Aggregates Position"
			Me.radGroupBox5.Location = New Point(10, 414)
			Me.radGroupBox5.Name = "radGroupBox5"
			Me.radGroupBox5.Size = New Size(266, 98)
			Me.radGroupBox5.TabIndex = 5
			Me.radGroupBox5.Text = "Aggregates Position"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 70)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(91, 18)
			Me.radLabel1.TabIndex = 6
			Me.radLabel1.Text = "Aggregates level:"
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.Location = New Point(121, 69)
			Me.radSpinEditor1.Name = "radSpinEditor1"
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(140, 20)
			Me.radSpinEditor1.TabIndex = 5
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Tag = "Right"
			' 
			' aggregatePositionColumns
			' 
			Me.aggregatePositionColumns.Anchor = AnchorStyles.Top
			Me.aggregatePositionColumns.Location = New Point(5, 45)
			Me.aggregatePositionColumns.Name = "aggregatePositionColumns"
			Me.aggregatePositionColumns.Size = New Size(64, 18)
			Me.aggregatePositionColumns.TabIndex = 4
			Me.aggregatePositionColumns.Text = "Columns"
			' 
			' aggregatePositionRows
			' 
			Me.aggregatePositionRows.Anchor = AnchorStyles.Top
			Me.aggregatePositionRows.Location = New Point(5, 21)
			Me.aggregatePositionRows.Name = "aggregatePositionRows"
			Me.aggregatePositionRows.Size = New Size(47, 18)
			Me.aggregatePositionRows.TabIndex = 3
			Me.aggregatePositionRows.Text = "Rows"
			' 
			' radGroupBox6
			' 
			Me.radGroupBox6.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox6.Anchor = AnchorStyles.Top
			Me.radGroupBox6.Controls.Add(Me.radButton2)
			Me.radGroupBox6.Controls.Add(Me.radButton1)
			Me.radGroupBox6.HeaderText = "Save/Load Layout"
			Me.radGroupBox6.Location = New Point(10, 519)
			Me.radGroupBox6.Name = "radGroupBox6"
			Me.radGroupBox6.Size = New Size(266, 100)
			Me.radGroupBox6.TabIndex = 6
			Me.radGroupBox6.Text = "Save/Load Layout"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(33, 31)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(205, 24)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "Save"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click)
			' 
			' radButton2
			' 
			Me.radButton2.Location = New Point(33, 61)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(205, 24)
			Me.radButton2.TabIndex = 0
			Me.radButton2.Text = "Load"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "Form1"
			Me.Size = New Size(1514, 1000)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.rowGrandTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rowGrandTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rowGrandTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.rowSubTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rowSubTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rowSubTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.columnGrandTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.columnGrandTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.columnGrandTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox4.ResumeLayout(False)
			Me.radGroupBox4.PerformLayout()
			CType(Me.columnSubTotalNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.columnSubTotalLast, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.columnSubTotalFirst, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox5.ResumeLayout(False)
			Me.radGroupBox5.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.aggregatePositionColumns, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.aggregatePositionRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox6.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox4 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox5 As Telerik.WinControls.UI.RadGroupBox
		Private rowGrandTotalFirst As Telerik.WinControls.UI.RadRadioButton
		Private rowGrandTotalLast As Telerik.WinControls.UI.RadRadioButton
		Private rowGrandTotalNone As Telerik.WinControls.UI.RadRadioButton
		Private rowSubTotalNone As Telerik.WinControls.UI.RadRadioButton
		Private rowSubTotalLast As Telerik.WinControls.UI.RadRadioButton
		Private rowSubTotalFirst As Telerik.WinControls.UI.RadRadioButton
		Private columnGrandTotalNone As Telerik.WinControls.UI.RadRadioButton
		Private columnGrandTotalLast As Telerik.WinControls.UI.RadRadioButton
		Private columnGrandTotalFirst As Telerik.WinControls.UI.RadRadioButton
		Private columnSubTotalNone As Telerik.WinControls.UI.RadRadioButton
		Private columnSubTotalLast As Telerik.WinControls.UI.RadRadioButton
		Private columnSubTotalFirst As Telerik.WinControls.UI.RadRadioButton
		Private aggregatePositionColumns As Telerik.WinControls.UI.RadRadioButton
		Private aggregatePositionRows As Telerik.WinControls.UI.RadRadioButton
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel1 As Telerik.WinControls.UI.RadLabel

		#End Region
		Private radGroupBox6 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace