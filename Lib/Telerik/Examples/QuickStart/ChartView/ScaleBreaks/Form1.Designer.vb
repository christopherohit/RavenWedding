Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.ChartView.ScaleBreaks
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
			Dim cartesianArea1 As New Telerik.WinControls.UI.CartesianArea()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownListStyle = New Telerik.WinControls.UI.RadDropDownList()
			Me.radColorBoxBackColor = New Telerik.WinControls.UI.RadColorBox()
			Me.radColorBoxBorderColor = New Telerik.WinControls.UI.RadColorBox()
			Me.radSpinEditorSize = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radButtonScaleBreaks = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radDropDownListStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radColorBoxBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radColorBoxBorderColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonScaleBreaks, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 19)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radButtonScaleBreaks)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(304, 832)
			Me.settingsPanel.Size = New Size(304, 832)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			' 
			' 
			' 
			Me.radChartView1.RootElement.MinSize = New Size(0, 0)
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Size = New Size(1230, 786)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Title = "Sales by Region"
			CType(Me.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Text = "Sales by Region"
			CType(Me.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Font = New Font("Segoe UI Light", 20F)
			CType(Me.radChartView1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Margin = New Padding(10, 0, 0, 0)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radDropDownListStyle)
			Me.radGroupBox1.Controls.Add(Me.radColorBoxBackColor)
			Me.radGroupBox1.Controls.Add(Me.radColorBoxBorderColor)
			Me.radGroupBox1.Controls.Add(Me.radSpinEditorSize)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.HeaderText = "Scale break settings"
			Me.radGroupBox1.Location = New Point(5, 76)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(294, 222)
			Me.radGroupBox1.TabIndex = 2
			Me.radGroupBox1.Text = "Scale break settings"
			' 
			' radDropDownListStyle
			' 
			Me.radDropDownListStyle.Anchor = AnchorStyles.Top
			Me.radDropDownListStyle.DropDownAnimationEnabled = False
			Me.radDropDownListStyle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownListStyle.Location = New Point(5, 40)
			Me.radDropDownListStyle.Name = "radDropDownListStyle"
			Me.radDropDownListStyle.Size = New Size(284, 20)
			Me.radDropDownListStyle.TabIndex = 3
			Me.radDropDownListStyle.Text = "radDropDownList1"
			' 
			' radColorBoxBackColor
			' 
			Me.radColorBoxBackColor.Anchor = AnchorStyles.Top
			Me.radColorBoxBackColor.Location = New Point(5, 190)
			Me.radColorBoxBackColor.Name = "radColorBoxBackColor"
			Me.radColorBoxBackColor.Size = New Size(284, 20)
			Me.radColorBoxBackColor.TabIndex = 2
			' 
			' radColorBoxBorderColor
			' 
			Me.radColorBoxBorderColor.Anchor = AnchorStyles.Top
			Me.radColorBoxBorderColor.Location = New Point(5, 140)
			Me.radColorBoxBorderColor.Name = "radColorBoxBorderColor"
			Me.radColorBoxBorderColor.Size = New Size(284, 20)
			Me.radColorBoxBorderColor.TabIndex = 2
			' 
			' radSpinEditorSize
			' 
			Me.radSpinEditorSize.Anchor = AnchorStyles.Top
			Me.radSpinEditorSize.Location = New Point(5, 90)
			Me.radSpinEditorSize.Name = "radSpinEditorSize"
			Me.radSpinEditorSize.Size = New Size(284, 20)
			Me.radSpinEditorSize.TabIndex = 1
			Me.radSpinEditorSize.TabStop = False
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 171)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(57, 18)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "Back color"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 121)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(67, 18)
			Me.radLabel2.TabIndex = 0
			Me.radLabel2.Text = "Border color"
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(5, 21)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(29, 18)
			Me.radLabel4.TabIndex = 0
			Me.radLabel4.Text = "Style"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 71)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(25, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Size"
			' 
			' radButtonScaleBreaks
			' 
			Me.radButtonScaleBreaks.Anchor = AnchorStyles.Top
			Me.radButtonScaleBreaks.Location = New Point(5, 33)
			Me.radButtonScaleBreaks.Name = "radButtonScaleBreaks"
			Me.radButtonScaleBreaks.Size = New Size(294, 37)
			Me.radButtonScaleBreaks.TabIndex = 3
			Me.radButtonScaleBreaks.Text = "Remove Scale Breaks"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(680, 420)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1240, 796)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radDropDownListStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radColorBoxBackColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radColorBoxBorderColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonScaleBreaks, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radGroupBox1 As RadGroupBox
		Private radDropDownListStyle As RadDropDownList
		Private radColorBoxBackColor As RadColorBox
		Private radColorBoxBorderColor As RadColorBox
		Private radSpinEditorSize As RadSpinEditor
		Private radLabel3 As RadLabel
		Private radLabel2 As RadLabel
		Private radLabel4 As RadLabel
		Private radLabel1 As RadLabel
		Private radButtonScaleBreaks As RadButton
	End Class
End Namespace