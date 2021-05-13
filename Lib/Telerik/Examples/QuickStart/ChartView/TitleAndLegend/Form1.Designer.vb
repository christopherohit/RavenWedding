Namespace Telerik.Examples.WinControls.ChartView.TitleAndLegend
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxFlipText = New Telerik.WinControls.UI.RadCheckBox()
			Me.radTextBoxControlTitle = New Telerik.WinControls.UI.RadTextBoxControl()
			Me.radLabelTitle = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListTitlePosition = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelTitleOrientation = New Telerik.WinControls.UI.RadLabel()
			Me.radRadioButtonHorizontalTitle = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButtonVerticalTitle = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButtonEditShape = New Telerik.WinControls.UI.RadButton()
			Me.radDropDownListShapes = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabelMarkerShape = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListLegendPosition = New Telerik.WinControls.UI.RadDropDownList()
			Me.radSpinEditorLegendX = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radRadioButtonVerticalLegend = New Telerik.WinControls.UI.RadRadioButton()
			Me.radSpinEditorLegendY = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radRadioButtonHorizontalLegend = New Telerik.WinControls.UI.RadRadioButton()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
            Me.doubleBufferedFlowLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radCheckBoxFlipText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxControlTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListTitlePosition, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTitleOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHorizontalTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonVerticalTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelMarkerShape, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListLegendPosition, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorLegendX, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonVerticalLegend, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSpinEditorLegendY, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonHorizontalLegend, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedFlowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(835, 45)
            ' 
            ' settingsPanel.PanelContainer
            ' 
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.PanelContainer.Size = New Size(288, 682)
            Me.settingsPanel.Size = New Size(288, 682)
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radCheckBoxFlipText)
            Me.radGroupBox1.Controls.Add(Me.radTextBoxControlTitle)
            Me.radGroupBox1.Controls.Add(Me.radLabelTitle)
            Me.radGroupBox1.Controls.Add(Me.radLabel1)
            Me.radGroupBox1.Controls.Add(Me.radDropDownListTitlePosition)
            Me.radGroupBox1.Controls.Add(Me.radLabelTitleOrientation)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonHorizontalTitle)
            Me.radGroupBox1.Controls.Add(Me.radRadioButtonVerticalTitle)
            Me.radGroupBox1.HeaderText = "Title"
            Me.radGroupBox1.Location = New Point(39, 32)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New Size(224, 194)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Title"
            ' 
            ' radCheckBoxFlipText
            ' 
            Me.radCheckBoxFlipText.Location = New Point(115, 144)
            Me.radCheckBoxFlipText.Name = "radCheckBoxFlipText"
            Me.radCheckBoxFlipText.Size = New Size(60, 18)
            Me.radCheckBoxFlipText.TabIndex = 13
            Me.radCheckBoxFlipText.Tag = "NotTouch"
            Me.radCheckBoxFlipText.Text = "Flip text"
            ' 
            ' radTextBoxControlTitle
            ' 
            Me.radTextBoxControlTitle.Anchor = AnchorStyles.Top
            Me.radTextBoxControlTitle.Location = New Point(5, 44)
            Me.radTextBoxControlTitle.Name = "radTextBoxControlTitle"
            Me.radTextBoxControlTitle.NullText = "Chart title"
            Me.radTextBoxControlTitle.Size = New Size(214, 20)
            Me.radTextBoxControlTitle.TabIndex = 12
            ' 
            ' radLabelTitle
            ' 
            Me.radLabelTitle.Anchor = AnchorStyles.Top
            Me.radLabelTitle.Location = New Point(5, 20)
            Me.radLabelTitle.Name = "radLabelTitle"
            Me.radLabelTitle.Size = New Size(27, 18)
            Me.radLabelTitle.TabIndex = 8
            Me.radLabelTitle.Text = "Title"
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Anchor = AnchorStyles.Top
            Me.radLabel1.Location = New Point(5, 70)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New Size(46, 18)
            Me.radLabel1.TabIndex = 8
            Me.radLabel1.Text = "Position"
            ' 
            ' radDropDownListTitlePosition
            ' 
            Me.radDropDownListTitlePosition.Anchor = AnchorStyles.Top
            Me.radDropDownListTitlePosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListTitlePosition.Location = New Point(5, 94)
            Me.radDropDownListTitlePosition.Name = "radDropDownListTitlePosition"
            Me.radDropDownListTitlePosition.Size = New Size(214, 20)
            Me.radDropDownListTitlePosition.TabIndex = 7
            Me.radDropDownListTitlePosition.Text = "Title position"
            ' 
            ' radLabelTitleOrientation
            ' 
            Me.radLabelTitleOrientation.Anchor = AnchorStyles.Top
            Me.radLabelTitleOrientation.Location = New Point(5, 120)
            Me.radLabelTitleOrientation.Name = "radLabelTitleOrientation"
            Me.radLabelTitleOrientation.Size = New Size(85, 18)
            Me.radLabelTitleOrientation.TabIndex = 9
            Me.radLabelTitleOrientation.Text = "Title orientation"
            ' 
            ' radRadioButtonHorizontalTitle
            ' 
            Me.radRadioButtonHorizontalTitle.Anchor = AnchorStyles.Top
            Me.radRadioButtonHorizontalTitle.CheckState = CheckState.Checked
            Me.radRadioButtonHorizontalTitle.Location = New Point(5, 144)
            Me.radRadioButtonHorizontalTitle.Name = "radRadioButtonHorizontalTitle"
            Me.radRadioButtonHorizontalTitle.Size = New Size(72, 18)
            Me.radRadioButtonHorizontalTitle.TabIndex = 10
            Me.radRadioButtonHorizontalTitle.Text = "Horizontal"
            Me.radRadioButtonHorizontalTitle.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            ' 
            ' radRadioButtonVerticalTitle
            ' 
            Me.radRadioButtonVerticalTitle.Anchor = AnchorStyles.Top
            Me.radRadioButtonVerticalTitle.Location = New Point(5, 168)
            Me.radRadioButtonVerticalTitle.Name = "radRadioButtonVerticalTitle"
            Me.radRadioButtonVerticalTitle.Size = New Size(57, 18)
            Me.radRadioButtonVerticalTitle.TabIndex = 11
            Me.radRadioButtonVerticalTitle.Text = "Vertical"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
            Me.radGroupBox2.Anchor = AnchorStyles.Top
            Me.radGroupBox2.Controls.Add(Me.radButtonEditShape)
            Me.radGroupBox2.Controls.Add(Me.doubleBufferedFlowLayoutPanel1)
            Me.radGroupBox2.Controls.Add(Me.radDropDownListShapes)
            Me.radGroupBox2.Controls.Add(Me.radLabelMarkerShape)
            Me.radGroupBox2.Controls.Add(Me.radLabel5)
            Me.radGroupBox2.Controls.Add(Me.radLabel2)
            Me.radGroupBox2.Controls.Add(Me.radDropDownListLegendPosition)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonVerticalLegend)
            Me.radGroupBox2.Controls.Add(Me.radRadioButtonHorizontalLegend)
            Me.radGroupBox2.HeaderText = "Legend"
            Me.radGroupBox2.Location = New Point(39, 244)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New Size(224, 265)
            Me.radGroupBox2.TabIndex = 8
            Me.radGroupBox2.Text = "Legend"
            ' 
            ' radButtonEditShape
            ' 
            Me.radButtonEditShape.Anchor = AnchorStyles.Top
            Me.radButtonEditShape.Location = New Point(5, 229)
            Me.radButtonEditShape.Name = "radButtonEditShape"
            Me.radButtonEditShape.Size = New Size(214, 24)
            Me.radButtonEditShape.TabIndex = 10
            Me.radButtonEditShape.Text = "Edit shape"
            ' 
            ' radDropDownListShapes
            ' 
            Me.radDropDownListShapes.Anchor = AnchorStyles.Top
            Me.radDropDownListShapes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListShapes.Location = New Point(5, 203)
            Me.radDropDownListShapes.Name = "radDropDownListShapes"
            Me.radDropDownListShapes.Size = New Size(214, 20)
            Me.radDropDownListShapes.TabIndex = 9
            ' 
            ' radLabelMarkerShape
            ' 
            Me.radLabelMarkerShape.Anchor = AnchorStyles.Top
            Me.radLabelMarkerShape.Location = New Point(5, 179)
            Me.radLabelMarkerShape.Name = "radLabelMarkerShape"
            Me.radLabelMarkerShape.Size = New Size(79, 18)
            Me.radLabelMarkerShape.TabIndex = 8
            Me.radLabelMarkerShape.Text = "Markers shape"
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Anchor = AnchorStyles.Top
            Me.radLabel4.Location = New Point(85, 5)
            Me.radLabel4.Margin = New Padding(3, 5, 3, 3)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New Size(12, 18)
            Me.radLabel4.TabIndex = 7
            Me.radLabel4.Tag = "NotTouch"
            Me.radLabel4.Text = "Y"
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Anchor = AnchorStyles.Top
            Me.radLabel3.Location = New Point(3, 5)
            Me.radLabel3.Margin = New Padding(3, 5, 3, 3)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New Size(13, 18)
            Me.radLabel3.TabIndex = 7
            Me.radLabel3.Tag = "NotTouch"
            Me.radLabel3.Text = "X"
            ' 
            ' radLabel5
            ' 
            Me.radLabel5.Anchor = AnchorStyles.Top
            Me.radLabel5.Location = New Point(5, 107)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New Size(92, 18)
            Me.radLabel5.TabIndex = 1
            Me.radLabel5.Text = "Items orientation"
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Anchor = AnchorStyles.Top
            Me.radLabel2.Location = New Point(5, 21)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New Size(46, 18)
            Me.radLabel2.TabIndex = 1
            Me.radLabel2.Text = "Position"
            ' 
            ' radDropDownListLegendPosition
            ' 
            Me.radDropDownListLegendPosition.Anchor = AnchorStyles.Top
            Me.radDropDownListLegendPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListLegendPosition.Location = New Point(5, 45)
            Me.radDropDownListLegendPosition.Name = "radDropDownListLegendPosition"
            Me.radDropDownListLegendPosition.Size = New Size(214, 20)
            Me.radDropDownListLegendPosition.TabIndex = 1
            Me.radDropDownListLegendPosition.Text = "Legend position"
            ' 
            ' radSpinEditorLegendX
            ' 
            Me.radSpinEditorLegendX.Anchor = AnchorStyles.Top
            Me.radSpinEditorLegendX.Location = New Point(22, 3)
            Me.radSpinEditorLegendX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorLegendX.Name = "radSpinEditorLegendX"
            Me.radSpinEditorLegendX.Size = New Size(57, 20)
            Me.radSpinEditorLegendX.TabIndex = 2
            Me.radSpinEditorLegendX.TabStop = False
            Me.radSpinEditorLegendX.Tag = "NotTouch"
            ' 
            ' radRadioButtonVerticalLegend
            ' 
            Me.radRadioButtonVerticalLegend.Anchor = AnchorStyles.Top
            Me.radRadioButtonVerticalLegend.CheckState = CheckState.Checked
            Me.radRadioButtonVerticalLegend.Location = New Point(5, 155)
            Me.radRadioButtonVerticalLegend.Name = "radRadioButtonVerticalLegend"
            Me.radRadioButtonVerticalLegend.Size = New Size(57, 18)
            Me.radRadioButtonVerticalLegend.TabIndex = 6
            Me.radRadioButtonVerticalLegend.Text = "Vertical"
            Me.radRadioButtonVerticalLegend.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            ' 
            ' radSpinEditorLegendY
            ' 
            Me.radSpinEditorLegendY.Anchor = AnchorStyles.Top
            Me.radSpinEditorLegendY.Location = New Point(103, 3)
            Me.radSpinEditorLegendY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.radSpinEditorLegendY.Name = "radSpinEditorLegendY"
            Me.radSpinEditorLegendY.Size = New Size(57, 20)
            Me.radSpinEditorLegendY.TabIndex = 2
            Me.radSpinEditorLegendY.TabStop = False
            Me.radSpinEditorLegendY.Tag = "NotTouch"
            ' 
            ' radRadioButtonHorizontalLegend
            ' 
            Me.radRadioButtonHorizontalLegend.Anchor = AnchorStyles.Top
            Me.radRadioButtonHorizontalLegend.Location = New Point(5, 131)
            Me.radRadioButtonHorizontalLegend.Name = "radRadioButtonHorizontalLegend"
            Me.radRadioButtonHorizontalLegend.Size = New Size(72, 18)
            Me.radRadioButtonHorizontalLegend.TabIndex = 6
            Me.radRadioButtonHorizontalLegend.Text = "Horizontal"
            ' 
            ' radChartView1
            ' 
            Me.radChartView1.AreaDesign = cartesianArea1
            Me.radChartView1.Dock = DockStyle.Fill
            Me.radChartView1.Location = New Point(0, 0)
            Me.radChartView1.MinimumSize = New Size(460, 350)
            Me.radChartView1.Name = "radChartView1"
            ' 
            ' 
            ' 
            Me.radChartView1.RootElement.MinSize = New Size(460, 350)
            Me.radChartView1.ShowGrid = False
            Me.radChartView1.Size = New Size(2072, 1156)
            Me.radChartView1.TabIndex = 1
            Me.radChartView1.Title = "Chart title"
            ' 
            ' flowLayoutPanel1
            ' 
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.radLabel3)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.radSpinEditorLegendX)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.radLabel4)
            Me.doubleBufferedFlowLayoutPanel1.Controls.Add(Me.radSpinEditorLegendY)
            Me.doubleBufferedFlowLayoutPanel1.Location = New Point(5, 74)
            Me.doubleBufferedFlowLayoutPanel1.Name = "doubleBufferedFlowLayoutPanel1"
            Me.doubleBufferedFlowLayoutPanel1.Size = New Size(214, 27)
            Me.doubleBufferedFlowLayoutPanel1.TabIndex = 11
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.AutoScrollMinSize = New Size(460, 350)
            Me.Controls.Add(Me.radChartView1)
            Me.Name = "Form1"
            Me.Size = New Size(2072, 1156)
            Me.Controls.SetChildIndex(Me.radChartView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radCheckBoxFlipText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxControlTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListTitlePosition, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTitleOrientation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHorizontalTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonVerticalTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            Me.radGroupBox2.PerformLayout()
            CType(Me.radButtonEditShape, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListShapes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelMarkerShape, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListLegendPosition, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorLegendX, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonVerticalLegend, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSpinEditorLegendY, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonHorizontalLegend, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedFlowLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedFlowLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radDropDownListLegendPosition As Telerik.WinControls.UI.RadDropDownList
        Private radSpinEditorLegendX As Telerik.WinControls.UI.RadSpinEditor
        Private radRadioButtonVerticalLegend As Telerik.WinControls.UI.RadRadioButton
        Private radSpinEditorLegendY As Telerik.WinControls.UI.RadSpinEditor
        Private radRadioButtonHorizontalLegend As Telerik.WinControls.UI.RadRadioButton
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private radDropDownListTitlePosition As Telerik.WinControls.UI.RadDropDownList
        Private radLabelTitleOrientation As Telerik.WinControls.UI.RadLabel
        Private radRadioButtonHorizontalTitle As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButtonVerticalTitle As Telerik.WinControls.UI.RadRadioButton
        Private radChartView1 As Telerik.WinControls.UI.RadChartView
        Private radDropDownListShapes As Telerik.WinControls.UI.RadDropDownList
        Private radLabelMarkerShape As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxFlipText As Telerik.WinControls.UI.RadCheckBox
        Private radTextBoxControlTitle As Telerik.WinControls.UI.RadTextBoxControl
        Private radLabelTitle As Telerik.WinControls.UI.RadLabel
        Private radButtonEditShape As Telerik.WinControls.UI.RadButton
        Private doubleBufferedFlowLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedFlowLayoutPanel
    End Class
End Namespace