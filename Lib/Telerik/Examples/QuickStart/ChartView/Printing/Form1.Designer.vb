Namespace Telerik.Examples.WinControls.ChartView.Printing
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
			Me.buttonPrint = New Telerik.WinControls.UI.RadButton()
			Me.buttonPrintPreview = New Telerik.WinControls.UI.RadButton()
			Me.buttonPrintSettings = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.doubleBufferedTableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radButtonExport = New Telerik.WinControls.UI.RadButton()
			Me.radSpinEditorHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditorWidth = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel2.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Dock = DockStyle.Right
			Me.settingsPanel.Location = New Point(0, 0)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(286, 786)
			Me.settingsPanel.Size = New Size(286, 786)
			' 
			' buttonPrint
			' 
			Me.buttonPrint.Anchor = AnchorStyles.Top
			Me.buttonPrint.Location = New Point(20, 3)
			Me.buttonPrint.Name = "buttonPrint"
			Me.buttonPrint.Size = New Size(216, 24)
			Me.buttonPrint.TabIndex = 1
			Me.buttonPrint.Text = "Print"
			' 
			' buttonPrintPreview
			' 
			Me.buttonPrintPreview.Anchor = AnchorStyles.Top
			Me.buttonPrintPreview.Location = New Point(20, 50)
			Me.buttonPrintPreview.Name = "buttonPrintPreview"
			Me.buttonPrintPreview.Size = New Size(216, 24)
			Me.buttonPrintPreview.TabIndex = 1
			Me.buttonPrintPreview.Text = "Print Preview"
			' 
			' buttonPrintSettings
			' 
			Me.buttonPrintSettings.Anchor = AnchorStyles.Top
			Me.buttonPrintSettings.Location = New Point(20, 97)
			Me.buttonPrintSettings.Name = "buttonPrintSettings"
			Me.buttonPrintSettings.Size = New Size(216, 24)
			Me.buttonPrintSettings.TabIndex = 1
			Me.buttonPrintSettings.Text = "Print Settings"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.doubleBufferedTableLayoutPanel2)
			Me.radGroupBox1.HeaderText = "Printing"
			Me.radGroupBox1.Location = New Point(19, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(266, 186)
			Me.radGroupBox1.TabIndex = 2
			Me.radGroupBox1.Text = "Printing"
			' 
			' tableLayoutPanel2
			' 
			Me.doubleBufferedTableLayoutPanel2.Anchor = AnchorStyles.Top
			Me.doubleBufferedTableLayoutPanel2.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.buttonPrint, 0, 0)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.buttonPrintSettings, 0, 2)
			Me.doubleBufferedTableLayoutPanel2.Controls.Add(Me.buttonPrintPreview, 0, 1)
			Me.doubleBufferedTableLayoutPanel2.Location = New Point(5, 21)
			Me.doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2"
			Me.doubleBufferedTableLayoutPanel2.RowCount = 3
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
			Me.doubleBufferedTableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
			Me.doubleBufferedTableLayoutPanel2.Size = New Size(256, 142)
			Me.doubleBufferedTableLayoutPanel2.TabIndex = 2
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.radGroupBox2.HeaderText = "Export"
			Me.radGroupBox2.Location = New Point(19, 234)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New Size(266, 312)
			Me.radGroupBox2.TabIndex = 3
			Me.radGroupBox2.Text = "Export"
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.Anchor = AnchorStyles.Top
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radButtonExport, 0, 6)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radSpinEditorHeight, 0, 5)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radDropDownList1, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radSpinEditorWidth, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(5, 21)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 7
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.28571F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(256, 272)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 8
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New Point(3, 3)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(73, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Image format"
			' 
			' radButtonExport
			' 
			Me.radButtonExport.Location = New Point(3, 231)
			Me.radButtonExport.Name = "radButtonExport"
			Me.radButtonExport.Size = New Size(216, 24)
			Me.radButtonExport.TabIndex = 6
			Me.radButtonExport.Text = "Export"
			' 
			' radSpinEditorHeight
			' 
			Me.radSpinEditorHeight.Location = New Point(3, 193)
			Me.radSpinEditorHeight.Maximum = New Decimal(New Integer() { 3000, 0, 0, 0})
			Me.radSpinEditorHeight.Minimum = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.radSpinEditorHeight.Name = "radSpinEditorHeight"
			Me.radSpinEditorHeight.NullableValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.radSpinEditorHeight.Size = New Size(194, 20)
			Me.radSpinEditorHeight.TabIndex = 7
			Me.radSpinEditorHeight.TabStop = False
			Me.radSpinEditorHeight.Value = New Decimal(New Integer() { 1000, 0, 0, 0})
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(3, 41)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(194, 20)
			Me.radDropDownList1.TabIndex = 0
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' radSpinEditorWidth
			' 
			Me.radSpinEditorWidth.Location = New Point(3, 117)
			Me.radSpinEditorWidth.Maximum = New Decimal(New Integer() { 3000, 0, 0, 0})
			Me.radSpinEditorWidth.Minimum = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.radSpinEditorWidth.Name = "radSpinEditorWidth"
			Me.radSpinEditorWidth.NullableValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.radSpinEditorWidth.Size = New Size(194, 20)
			Me.radSpinEditorWidth.TabIndex = 7
			Me.radSpinEditorWidth.TabStop = False
			Me.radSpinEditorWidth.Value = New Decimal(New Integer() { 1000, 0, 0, 0})
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New Point(3, 155)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(39, 18)
			Me.radLabel3.TabIndex = 2
			Me.radLabel3.Text = "Height"
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New Point(3, 79)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(35, 18)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Width"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "Form1"
			Me.Size = New Size(1227, 796)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.buttonPrint, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrintPreview, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonPrintSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel2.ResumeLayout(False)
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonExport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorHeight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorWidth, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private buttonPrint As Telerik.WinControls.UI.RadButton
		Private buttonPrintPreview As Telerik.WinControls.UI.RadButton
		Private buttonPrintSettings As Telerik.WinControls.UI.RadButton
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radButtonExport As Telerik.WinControls.UI.RadButton
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radSpinEditorHeight As Telerik.WinControls.UI.RadSpinEditor
		Private radSpinEditorWidth As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
		Private doubleBufferedTableLayoutPanel2 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace