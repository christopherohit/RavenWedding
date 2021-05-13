Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
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
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxAveragePrice = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxCompanyEvents = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxPriceRange = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radCheckBoxAveragePrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxCompanyEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radCheckBoxPriceRange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 3)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Size = New Size(230, 832)
			Me.settingsPanel.Size = New Size(230, 832)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1473, 786)
			Me.radChartView1.TabIndex = 2
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton4)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton3)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox1.HeaderText = "Top companies in the market"
			Me.radGroupBox1.Location = New Point(5, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(220, 130)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "Top companies in the market"
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Anchor = AnchorStyles.Top
			Me.radRadioButton2.CheckState = CheckState.Checked
			Me.radRadioButton2.Location = New Point(5, 21)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.Size = New Size(77, 18)
			Me.radRadioButton2.TabIndex = 1
			Me.radRadioButton2.Text = "Google Inc."
			Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radRadioButton4
			' 
			Me.radRadioButton4.Anchor = AnchorStyles.Top
			Me.radRadioButton4.Location = New Point(5, 93)
			Me.radRadioButton4.Name = "radRadioButton4"
			Me.radRadioButton4.Size = New Size(117, 18)
			Me.radRadioButton4.TabIndex = 0
			Me.radRadioButton4.TabStop = False
			Me.radRadioButton4.Text = "Adobe Systems Inc."
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.Anchor = AnchorStyles.Top
			Me.radRadioButton3.Location = New Point(5, 69)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.Size = New Size(70, 18)
			Me.radRadioButton3.TabIndex = 0
			Me.radRadioButton3.TabStop = False
			Me.radRadioButton3.Text = "Apple Inc."
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.Anchor = AnchorStyles.Top
			Me.radRadioButton1.Location = New Point(5, 45)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.Size = New Size(131, 18)
			Me.radRadioButton1.TabIndex = 0
			Me.radRadioButton1.TabStop = False
			Me.radRadioButton1.Text = "Microsoft Corporation"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxAveragePrice)
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxCompanyEvents)
			Me.radGroupBox2.Controls.Add(Me.radLabel1)
			Me.radGroupBox2.HeaderText = "Company events"
			Me.radGroupBox2.Location = New Point(5, 180)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Size = New Size(220, 100)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Company events"
			' 
			' radCheckBoxAveragePrice
			' 
			Me.radCheckBoxAveragePrice.Anchor = AnchorStyles.Top
			Me.radCheckBoxAveragePrice.CheckState = CheckState.Checked
			Me.radCheckBoxAveragePrice.Location = New Point(5, 72)
			Me.radCheckBoxAveragePrice.Name = "radCheckBoxAveragePrice"
			Me.radCheckBoxAveragePrice.Size = New Size(118, 18)
			Me.radCheckBoxAveragePrice.TabIndex = 2
			Me.radCheckBoxAveragePrice.Text = "Average stock price"
			Me.radCheckBoxAveragePrice.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxCompanyEvents
			' 
			Me.radCheckBoxCompanyEvents.Anchor = AnchorStyles.Top
			Me.radCheckBoxCompanyEvents.CheckState = CheckState.Checked
			Me.radCheckBoxCompanyEvents.Location = New Point(5, 47)
			Me.radCheckBoxCompanyEvents.Name = "radCheckBoxCompanyEvents"
			Me.radCheckBoxCompanyEvents.Size = New Size(103, 18)
			Me.radCheckBoxCompanyEvents.TabIndex = 1
			Me.radCheckBoxCompanyEvents.Text = "Company events"
			Me.radCheckBoxCompanyEvents.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 22)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(153, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Cartesian grid line annotation"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Anchor = AnchorStyles.Top
			Me.radGroupBox3.Controls.Add(Me.radCheckBoxPriceRange)
			Me.radGroupBox3.Controls.Add(Me.radLabel2)
			Me.radGroupBox3.HeaderText = "Stock price range"
			Me.radGroupBox3.Location = New Point(5, 311)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Size = New Size(220, 76)
			Me.radGroupBox3.TabIndex = 1
			Me.radGroupBox3.Text = "Stock price range"
			' 
			' radCheckBoxPriceRange
			' 
			Me.radCheckBoxPriceRange.Anchor = AnchorStyles.Top
			Me.radCheckBoxPriceRange.CheckState = CheckState.Checked
			Me.radCheckBoxPriceRange.Location = New Point(5, 47)
			Me.radCheckBoxPriceRange.Name = "radCheckBoxPriceRange"
			Me.radCheckBoxPriceRange.Size = New Size(124, 18)
			Me.radCheckBoxPriceRange.TabIndex = 1
			Me.radCheckBoxPriceRange.Text = "Min-max price range"
			Me.radCheckBoxPriceRange.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 22)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(161, 18)
			Me.radLabel2.TabIndex = 0
			Me.radLabel2.Text = "Cartesian plot band annotation"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(680, 420)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1483, 796)
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
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radCheckBoxAveragePrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxCompanyEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.radCheckBoxPriceRange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As RadGroupBox
		Private radChartView1 As RadChartView
		Private radRadioButton2 As RadRadioButton
		Private radRadioButton4 As RadRadioButton
		Private radRadioButton3 As RadRadioButton
		Private radRadioButton1 As RadRadioButton
		Private radGroupBox3 As RadGroupBox
		Private radCheckBoxPriceRange As RadCheckBox
		Private radLabel2 As RadLabel
		Private radGroupBox2 As RadGroupBox
		Private radCheckBoxAveragePrice As RadCheckBox
		Private radCheckBoxCompanyEvents As RadCheckBox
		Private radLabel1 As RadLabel

	End Class
End Namespace