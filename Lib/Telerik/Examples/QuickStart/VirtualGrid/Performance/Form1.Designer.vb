Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.VirtualGrid.Performance
	Public Partial Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
			Me.radButtonLoad = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinEditorRowSize = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabelRowResize = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinEditorColumnSize = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabelColumnResize = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonLoad, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radSpinEditorRowSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelRowResize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radSpinEditorColumnSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabelColumnResize, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Size = New System.Drawing.Size(230, 536)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' radVirtualGrid1
			' 
			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.AllowFiltering = False
			Me.radVirtualGrid1.AllowSorting = False
			Me.radVirtualGrid1.ColumnCount = 100
			Me.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radVirtualGrid1.Location = New System.Drawing.Point(0, 0)
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.RowCount = 1000
			Me.radVirtualGrid1.Size = New System.Drawing.Size(1871, 1086)
			Me.radVirtualGrid1.StandardTab = False
			Me.radVirtualGrid1.TabIndex = 0
			Me.radVirtualGrid1.Text = "radVirtualGrid1"
			Me.radVirtualGrid1.Visible = False
			' 
			' radButtonLoad
			' 
			Me.radButtonLoad.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radButtonLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radButtonLoad.Location = New System.Drawing.Point(818, 484)
			Me.radButtonLoad.Name = "radButtonLoad"
			Me.radButtonLoad.Size = New System.Drawing.Size(275, 52)
			Me.radButtonLoad.TabIndex = 0
			Me.radButtonLoad.Text = "LOAD 1 BILLION CELLS"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorRowSize)
			Me.radGroupBox1.Controls.Add(Me.radLabelRowResize)
			Me.radGroupBox1.HeaderText = "Resize rows"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New System.Drawing.Size(210, 94)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Resize rows"
			' 
			' radSpinEditorRowSize
			' 
			Me.radSpinEditorRowSize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorRowSize.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.radSpinEditorRowSize.Location = New System.Drawing.Point(5, 61)
			Me.radSpinEditorRowSize.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.radSpinEditorRowSize.Name = "radSpinEditorRowSize"
			Me.radSpinEditorRowSize.Size = New System.Drawing.Size(200, 20)
			Me.radSpinEditorRowSize.TabIndex = 1
			Me.radSpinEditorRowSize.TabStop = False
			Me.radSpinEditorRowSize.Value = New Decimal(New Integer() { 20, 0, 0, 0})
			' 
			' radLabelRowResize
			' 
			Me.radLabelRowResize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabelRowResize.Location = New System.Drawing.Point(5, 22)
			Me.radLabelRowResize.Name = "radLabelRowResize"
			Me.radLabelRowResize.Size = New System.Drawing.Size(141, 33)
			Me.radLabelRowResize.TabIndex = 0
			Me.radLabelRowResize.Text = "Set every 10th row height." & Constants.vbCrLf & "(100 000 in total)"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorColumnSize)
			Me.radGroupBox2.Controls.Add(Me.radLabelColumnResize)
			Me.radGroupBox2.HeaderText = "Resize columns"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 132)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New System.Drawing.Size(210, 95)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Resize columns"
			' 
			' radSpinEditorColumnSize
			' 
			Me.radSpinEditorColumnSize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorColumnSize.Increment = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.radSpinEditorColumnSize.Location = New System.Drawing.Point(5, 61)
			Me.radSpinEditorColumnSize.Maximum = New Decimal(New Integer() { 250, 0, 0, 0})
			Me.radSpinEditorColumnSize.Minimum = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.radSpinEditorColumnSize.Name = "radSpinEditorColumnSize"
			Me.radSpinEditorColumnSize.Size = New System.Drawing.Size(200, 20)
			Me.radSpinEditorColumnSize.TabIndex = 1
			Me.radSpinEditorColumnSize.TabStop = False
			Me.radSpinEditorColumnSize.Value = New Decimal(New Integer() { 100, 0, 0, 0})
			' 
			' radLabelColumnResize
			' 
			Me.radLabelColumnResize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabelColumnResize.Location = New System.Drawing.Point(5, 22)
			Me.radLabelColumnResize.Name = "radLabelColumnResize"
			Me.radLabelColumnResize.Size = New System.Drawing.Size(160, 33)
			Me.radLabelColumnResize.TabIndex = 0
			Me.radLabelColumnResize.Text = "Set every other column width." & Constants.vbCrLf & "(500 in total)"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radVirtualGrid1)
			Me.Controls.Add(Me.radButtonLoad)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1881, 1096)
			Me.Controls.SetChildIndex(Me.radButtonLoad, 0)
			Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonLoad, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radSpinEditorRowSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelRowResize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radSpinEditorColumnSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabelColumnResize, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radSpinEditorColumnSize As Telerik.WinControls.UI.RadSpinEditor
		Private radLabelColumnResize As Telerik.WinControls.UI.RadLabel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radSpinEditorRowSize As Telerik.WinControls.UI.RadSpinEditor
		Private radLabelRowResize As Telerik.WinControls.UI.RadLabel
		Private radButtonLoad As Telerik.WinControls.UI.RadButton
	End Class
End Namespace