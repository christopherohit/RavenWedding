Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.StockSeries
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
			Dim dateTimeCategoricalAxis1 As New Telerik.WinControls.UI.DateTimeCategoricalAxis()
			Dim linearAxis1 As New Telerik.WinControls.UI.LinearAxis()
			Dim cartesianArea2 As New Telerik.WinControls.UI.CartesianArea()
			Dim dateTimeCategoricalAxis2 As New Telerik.WinControls.UI.DateTimeCategoricalAxis()
			Dim linearAxis2 As New Telerik.WinControls.UI.LinearAxis()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radChartView2 = New Telerik.WinControls.UI.RadChartView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radDropDownList3 = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(0, 17)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel3)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel1)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownList3)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownList2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownList1)
			Me.settingsPanel.PanelContainer.Size = New Size(274, 834)
			Me.settingsPanel.Size = New Size(274, 834)
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			dateTimeCategoricalAxis1.DateTimeComponent = Telerik.Charting.DateTimeComponent.Ticks
			dateTimeCategoricalAxis1.IsPrimary = True
			dateTimeCategoricalAxis1.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine
			dateTimeCategoricalAxis1.LabelFormat = "{0:dd.MM}"
			dateTimeCategoricalAxis1.MajorTickInterval = 5
			linearAxis1.AxisType = Telerik.Charting.AxisType.Second
			linearAxis1.HorizontalLocation = Telerik.Charting.AxisHorizontalLocation.Right
			linearAxis1.IsPrimary = True
			linearAxis1.MajorStep = 10R
			linearAxis1.Maximum = 100R
			linearAxis1.Minimum = 0R
			linearAxis1.TickOrigin = Nothing
			Me.radChartView1.Axes.AddRange(New Telerik.WinControls.UI.Axis() { dateTimeCategoricalAxis1, linearAxis1})
			Me.radChartView1.Dock = DockStyle.Bottom
			Me.radChartView1.Location = New Point(0, 626)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.Size = New Size(1230, 160)
			Me.radChartView1.TabIndex = 1
			Me.radChartView1.Title = "Chart title"
			' 
			' radChartView2
			' 
			Me.radChartView2.AreaDesign = cartesianArea2
			dateTimeCategoricalAxis2.DateTimeComponent = Telerik.Charting.DateTimeComponent.Ticks
			dateTimeCategoricalAxis2.IsPrimary = True
			dateTimeCategoricalAxis2.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine
			dateTimeCategoricalAxis2.LabelFormat = "{0:dd.MM}"
			dateTimeCategoricalAxis2.MajorTickInterval = 5
			linearAxis2.AxisType = Telerik.Charting.AxisType.Second
			linearAxis2.HorizontalLocation = Telerik.Charting.AxisHorizontalLocation.Right
			linearAxis2.IsPrimary = True
			linearAxis2.MajorStep = 5R
			linearAxis2.Maximum = 80R
			linearAxis2.Minimum = 50R
			linearAxis2.TickOrigin = Nothing
			Me.radChartView2.Axes.AddRange(New Telerik.WinControls.UI.Axis() { dateTimeCategoricalAxis2, linearAxis2})
			Me.radChartView2.Dock = DockStyle.Fill
			Me.radChartView2.Location = New Point(0, 0)
			Me.radChartView2.MinimumSize = New Size(150, 150)
			Me.radChartView2.Name = "radChartView2"
			' 
			' 
			' 
			Me.radChartView2.RootElement.MinSize = New Size(150, 150)
			Me.radChartView2.ShowGrid = False
			Me.radChartView2.ShowTitle = True
			Me.radChartView2.Size = New Size(1230, 626)
			Me.radChartView2.TabIndex = 2
			Me.radChartView2.Title = "Investor Adviser: International Software Company (ISC)"
			CType(Me.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Text = "Investor Adviser: International Software Company (ISC)"
			CType(Me.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.ChartTitleElement).Margin = New Padding(10, 10, 0, 0)
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 31)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(64, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Series Type:"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 93)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(137, 18)
			Me.radLabel2.TabIndex = 0
			Me.radLabel2.Text = "Moving Average indicator:"
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 156)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(98, 18)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "Financial indicator:"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = AnchorStyles.Top
			Me.radDropDownList1.DropDownAnimationEnabled = False
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.Location = New Point(5, 55)
			Me.radDropDownList1.Name = "radDropDownList1"
			Me.radDropDownList1.Size = New Size(264, 20)
			Me.radDropDownList1.TabIndex = 1
			Me.radDropDownList1.Text = "radDropDownList1"
			' 
			' radDropDownList2
			' 
			Me.radDropDownList2.Anchor = AnchorStyles.Top
			Me.radDropDownList2.DropDownAnimationEnabled = False
			Me.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList2.Location = New Point(5, 117)
			Me.radDropDownList2.Name = "radDropDownList2"
			Me.radDropDownList2.Size = New Size(264, 20)
			Me.radDropDownList2.TabIndex = 2
			Me.radDropDownList2.Text = "radDropDownList2"
			' 
			' radDropDownList3
			' 
			Me.radDropDownList3.Anchor = AnchorStyles.Top
			Me.radDropDownList3.DropDownAnimationEnabled = False
			Me.radDropDownList3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList3.Location = New Point(5, 180)
			Me.radDropDownList3.Name = "radDropDownList3"
			Me.radDropDownList3.Size = New Size(264, 20)
			Me.radDropDownList3.TabIndex = 3
			Me.radDropDownList3.Text = "radDropDownList3"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScrollMinSize = New Size(500, 320)
			Me.Controls.Add(Me.radChartView2)
			Me.Controls.Add(Me.radChartView1)
			Me.Name = "Form1"
			Me.Size = New Size(1240, 796)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.Controls.SetChildIndex(Me.radChartView2, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDropDownList3 As Telerik.WinControls.UI.RadDropDownList
		Private radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
		Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radChartView2 As Telerik.WinControls.UI.RadChartView
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace