Namespace HotelApp
	Partial Public Class UserControlCurrentStatus
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
			Dim cartesianArea2 As New Telerik.WinControls.UI.CartesianArea()
			Dim cartesianArea3 As New Telerik.WinControls.UI.CartesianArea()
			Me.occupiedPerDayChartView = New Telerik.WinControls.UI.RadChartView()
			Me.trendsChartView = New Telerik.WinControls.UI.RadChartView()
			Me.trendsRangeSelector = New Telerik.WinControls.UI.RadRangeSelector()
			Me.reportsRangeSelectorPanel = New Telerik.WinControls.UI.RadPanel()
			CType(Me.occupiedPerDayChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trendsChartView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trendsRangeSelector, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.reportsRangeSelectorPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.reportsRangeSelectorPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' occupiedPerDayChartView
			' 
			Me.occupiedPerDayChartView.AreaDesign = cartesianArea2
			Me.occupiedPerDayChartView.Dock = DockStyle.Left
			Me.occupiedPerDayChartView.Location = New Point(0, 0)
			Me.occupiedPerDayChartView.Name = "occupiedPerDayChartView"
			Me.occupiedPerDayChartView.ShowGrid = False
			Me.occupiedPerDayChartView.Size = New Size(518, 340)
			Me.occupiedPerDayChartView.TabIndex = 0
			Me.occupiedPerDayChartView.Text = "radChartView1"
			' 
			' trendsChartView
			' 
			Me.trendsChartView.AreaDesign = cartesianArea3
			Me.trendsChartView.Dock = DockStyle.Top
			Me.trendsChartView.Location = New Point(518, 0)
			Me.trendsChartView.Name = "trendsChartView"
			Me.trendsChartView.ShowGrid = False
			Me.trendsChartView.Size = New Size(802, 200)
			Me.trendsChartView.TabIndex = 1
			Me.trendsChartView.Text = "radChartView2"
			' 
			' trendsRangeSelector
			' 
			Me.trendsRangeSelector.Dock = DockStyle.Fill
			Me.trendsRangeSelector.Location = New Point(0, 0)
			Me.trendsRangeSelector.Name = "trendsRangeSelector"
			Me.trendsRangeSelector.Size = New Size(802, 140)
			Me.trendsRangeSelector.TabIndex = 2
			Me.trendsRangeSelector.Text = "radRangeSelector1"
			' 
			' reportsRangeSelectorPanel
			' 
			Me.reportsRangeSelectorPanel.Controls.Add(Me.trendsRangeSelector)
			Me.reportsRangeSelectorPanel.Dock = DockStyle.Fill
			Me.reportsRangeSelectorPanel.Location = New Point(518, 200)
			Me.reportsRangeSelectorPanel.Name = "reportsRangeSelectorPanel"
			Me.reportsRangeSelectorPanel.Size = New Size(802, 140)
			Me.reportsRangeSelectorPanel.TabIndex = 3
			' 
			' UserControlCurrentStatus
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.reportsRangeSelectorPanel)
			Me.Controls.Add(Me.trendsChartView)
			Me.Controls.Add(Me.occupiedPerDayChartView)
			Me.Name = "UserControlCurrentStatus"
			Me.Size = New Size(1320, 340)
			CType(Me.occupiedPerDayChartView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trendsChartView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trendsRangeSelector, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.reportsRangeSelectorPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.reportsRangeSelectorPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private occupiedPerDayChartView As Telerik.WinControls.UI.RadChartView
		Private trendsChartView As Telerik.WinControls.UI.RadChartView
		Private trendsRangeSelector As Telerik.WinControls.UI.RadRangeSelector
		Private reportsRangeSelectorPanel As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
