Namespace Telerik.Examples.WinControls.PivotGrid.BindingWithChartView
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
			Me.radPivotGrid1 = New Telerik.WinControls.UI.RadPivotGrid()
			Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.checkBoxRowGrandTotals = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxColumnGrandTotals = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxRowSubTotals = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxColumnSubTotals = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxSelectionOnly = New Telerik.WinControls.UI.RadCheckBox()
			Me.checkBoxDelayUpdates = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioColumns = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioRows = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radioAreaSeries = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioLineSeries = New Telerik.WinControls.UI.RadRadioButton()
			Me.radioBarSeries = New Telerik.WinControls.UI.RadRadioButton()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.checkBoxRowGrandTotals, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxColumnGrandTotals, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxRowSubTotals, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxColumnSubTotals, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxSelectionOnly, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxDelayUpdates, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radioColumns, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox3.SuspendLayout()
			CType(Me.radioAreaSeries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioLineSeries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioBarSeries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Dock = DockStyle.Right
			Me.settingsPanel.Location = New Point(1514, 0)
			Me.settingsPanel.Margin = New Padding(5, 5, 5, 5)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBox3)
			Me.settingsPanel.PanelContainer.Margin = New Padding(5, 5, 5, 5)
			Me.settingsPanel.PanelContainer.Size = New Size(476, 1104)
			Me.settingsPanel.Size = New Size(476, 1104)
			' 
			' optionsLabel
			' 
			Me.optionsLabel.Location = New Point(6, 6)
			Me.optionsLabel.Margin = New Padding(5, 5, 5, 5)
			Me.optionsLabel.Size = New Size(87, 27)
			' 
			' radPivotGrid1
			' 
			Me.radPivotGrid1.AllowContextMenu = False
			Me.radPivotGrid1.AllowFieldsDragDrop = False
			Me.radPivotGrid1.AllowGroupFiltering = False
			Me.radPivotGrid1.AllowHorizontalResize = False
			Me.radPivotGrid1.AllowVerticalResize = False
			Me.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals = True
			Me.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals = True
			Me.radPivotGrid1.ColumnHeaderHeight = 46
			Me.radPivotGrid1.ColumnWidth = 166
			Me.radPivotGrid1.DataMember = Nothing
			Me.radPivotGrid1.Dock = DockStyle.Bottom
			Me.radPivotGrid1.Location = New Point(0, 676)
			Me.radPivotGrid1.Margin = New Padding(5, 5, 5, 5)
			Me.radPivotGrid1.Name = "radPivotGrid1"
			Me.radPivotGrid1.RowHeight = 39
			Me.radPivotGrid1.Size = New Size(1514, 428)
			Me.radPivotGrid1.TabIndex = 1
			' 
			' radChartView1
			' 
			Me.radChartView1.AreaDesign = cartesianArea1
			Me.radChartView1.Dock = DockStyle.Fill
			Me.radChartView1.LegendTitle = "Legend"
			Me.radChartView1.Location = New Point(0, 0)
			Me.radChartView1.Margin = New Padding(5, 5, 5, 5)
			Me.radChartView1.Name = "radChartView1"
			Me.radChartView1.ShowGrid = False
			Me.radChartView1.ShowLegend = True
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Size = New Size(1514, 629)
			Me.radChartView1.TabIndex = 2
			Me.radChartView1.Title = "Pivot Data Visualization"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Controls.Add(Me.checkBoxRowGrandTotals)
			Me.radGroupBox1.Controls.Add(Me.checkBoxColumnGrandTotals)
			Me.radGroupBox1.Controls.Add(Me.checkBoxRowSubTotals)
			Me.radGroupBox1.Controls.Add(Me.checkBoxColumnSubTotals)
			Me.radGroupBox1.Controls.Add(Me.checkBoxSelectionOnly)
			Me.radGroupBox1.Controls.Add(Me.checkBoxDelayUpdates)
			Me.radGroupBox1.HeaderText = "Binding options"
			Me.radGroupBox1.Location = New Point(130, 2)
			Me.radGroupBox1.Margin = New Padding(5, 5, 5, 5)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(4, 28, 4, 2)
			Me.radGroupBox1.Size = New Size(309, 269)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Binding options"
			' 
			' checkBoxRowGrandTotals
			' 
			Me.checkBoxRowGrandTotals.Location = New Point(19, 219)
			Me.checkBoxRowGrandTotals.Margin = New Padding(5, 5, 5, 5)
			Me.checkBoxRowGrandTotals.Name = "checkBoxRowGrandTotals"
			Me.checkBoxRowGrandTotals.Size = New Size(176, 22)
			Me.checkBoxRowGrandTotals.TabIndex = 0
			Me.checkBoxRowGrandTotals.Text = "Include row grand totals"
			' 
			' checkBoxColumnGrandTotals
			' 
			Me.checkBoxColumnGrandTotals.Location = New Point(19, 181)
			Me.checkBoxColumnGrandTotals.Margin = New Padding(5, 5, 5, 5)
			Me.checkBoxColumnGrandTotals.Name = "checkBoxColumnGrandTotals"
			Me.checkBoxColumnGrandTotals.Size = New Size(199, 22)
			Me.checkBoxColumnGrandTotals.TabIndex = 0
			Me.checkBoxColumnGrandTotals.Text = "Include column grand totals"
			' 
			' checkBoxRowSubTotals
			' 
			Me.checkBoxRowSubTotals.Location = New Point(19, 145)
			Me.checkBoxRowSubTotals.Margin = New Padding(5, 5, 5, 5)
			Me.checkBoxRowSubTotals.Name = "checkBoxRowSubTotals"
			Me.checkBoxRowSubTotals.Size = New Size(163, 22)
			Me.checkBoxRowSubTotals.TabIndex = 0
			Me.checkBoxRowSubTotals.Text = "Include row sub-totals"
			' 
			' checkBoxColumnSubTotals
			' 
			Me.checkBoxColumnSubTotals.Location = New Point(19, 108)
			Me.checkBoxColumnSubTotals.Margin = New Padding(5, 5, 5, 5)
			Me.checkBoxColumnSubTotals.Name = "checkBoxColumnSubTotals"
			Me.checkBoxColumnSubTotals.Size = New Size(186, 22)
			Me.checkBoxColumnSubTotals.TabIndex = 0
			Me.checkBoxColumnSubTotals.Text = "Include column sub-totals"
			' 
			' checkBoxSelectionOnly
			' 
			Me.checkBoxSelectionOnly.Location = New Point(19, 71)
			Me.checkBoxSelectionOnly.Margin = New Padding(5, 5, 5, 5)
			Me.checkBoxSelectionOnly.Name = "checkBoxSelectionOnly"
			Me.checkBoxSelectionOnly.Size = New Size(111, 22)
			Me.checkBoxSelectionOnly.TabIndex = 0
			Me.checkBoxSelectionOnly.Text = "Selection only"
			' 
			' checkBoxDelayUpdates
			' 
			Me.checkBoxDelayUpdates.Location = New Point(19, 34)
			Me.checkBoxDelayUpdates.Margin = New Padding(5, 5, 5, 5)
			Me.checkBoxDelayUpdates.Name = "checkBoxDelayUpdates"
			Me.checkBoxDelayUpdates.Size = New Size(107, 22)
			Me.checkBoxDelayUpdates.TabIndex = 0
			Me.checkBoxDelayUpdates.Text = "Delay update"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Controls.Add(Me.radioColumns)
			Me.radGroupBox2.Controls.Add(Me.radioRows)
			Me.radGroupBox2.HeaderText = "Generate series from"
			Me.radGroupBox2.Location = New Point(130, 282)
			Me.radGroupBox2.Margin = New Padding(5, 5, 5, 5)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(4, 28, 4, 2)
			Me.radGroupBox2.Size = New Size(309, 118)
			Me.radGroupBox2.TabIndex = 2
			Me.radGroupBox2.Text = "Generate series from"
			' 
			' radioColumns
			' 
			Me.radioColumns.Location = New Point(19, 71)
			Me.radioColumns.Margin = New Padding(5, 5, 5, 5)
			Me.radioColumns.Name = "radioColumns"
			Me.radioColumns.Size = New Size(79, 22)
			Me.radioColumns.TabIndex = 0
			Me.radioColumns.Text = "Columns"
			' 
			' radioRows
			' 
			Me.radioRows.Location = New Point(19, 34)
			Me.radioRows.Margin = New Padding(5, 5, 5, 5)
			Me.radioRows.Name = "radioRows"
			Me.radioRows.Size = New Size(57, 22)
			Me.radioRows.TabIndex = 0
			Me.radioRows.Text = "Rows"
			' 
			' radGroupBox3
			' 
			Me.radGroupBox3.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox3.Controls.Add(Me.radioAreaSeries)
			Me.radGroupBox3.Controls.Add(Me.radioLineSeries)
			Me.radGroupBox3.Controls.Add(Me.radioBarSeries)
			Me.radGroupBox3.HeaderText = "Generated series type"
			Me.radGroupBox3.Location = New Point(130, 409)
			Me.radGroupBox3.Margin = New Padding(5, 5, 5, 5)
			Me.radGroupBox3.Name = "radGroupBox3"
			Me.radGroupBox3.Padding = New Padding(4, 28, 4, 2)
			Me.radGroupBox3.Size = New Size(309, 148)
			Me.radGroupBox3.TabIndex = 2
			Me.radGroupBox3.Text = "Generated series type"
			' 
			' radioAreaSeries
			' 
			Me.radioAreaSeries.Location = New Point(19, 106)
			Me.radioAreaSeries.Margin = New Padding(5, 5, 5, 5)
			Me.radioAreaSeries.Name = "radioAreaSeries"
			Me.radioAreaSeries.Size = New Size(53, 22)
			Me.radioAreaSeries.TabIndex = 0
			Me.radioAreaSeries.Text = "Area"
			' 
			' radioLineSeries
			' 
			Me.radioLineSeries.Location = New Point(19, 69)
			Me.radioLineSeries.Margin = New Padding(5, 5, 5, 5)
			Me.radioLineSeries.Name = "radioLineSeries"
			Me.radioLineSeries.Size = New Size(50, 22)
			Me.radioLineSeries.TabIndex = 0
			Me.radioLineSeries.Text = "Line"
			' 
			' radioBarSeries
			' 
			Me.radioBarSeries.Location = New Point(19, 32)
			Me.radioBarSeries.Margin = New Padding(5, 5, 5, 5)
			Me.radioBarSeries.Name = "radioBarSeries"
			Me.radioBarSeries.Size = New Size(44, 22)
			Me.radioBarSeries.TabIndex = 0
			Me.radioBarSeries.Text = "Bar"
			' 
			' radPanel1
			' 
			Me.radPanel1.Dock = DockStyle.Bottom
			Me.radPanel1.Location = New Point(0, 629)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New Size(1514, 47)
			Me.radPanel1.TabIndex = 3
			Me.radPanel1.Text = ""
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radChartView1)
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.radPivotGrid1)
			Me.Name = "Form1"
			Me.Size = New Size(1990, 1104)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPivotGrid1, 0)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.radChartView1, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.checkBoxRowGrandTotals, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxColumnGrandTotals, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxRowSubTotals, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxColumnSubTotals, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxSelectionOnly, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxDelayUpdates, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.radioColumns, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox3.ResumeLayout(False)
			Me.radGroupBox3.PerformLayout()
			CType(Me.radioAreaSeries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioLineSeries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioBarSeries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private radPivotGrid1 As Telerik.WinControls.UI.RadPivotGrid
		Private radChartView1 As Telerik.WinControls.UI.RadChartView
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private checkBoxSelectionOnly As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxDelayUpdates As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxRowSubTotals As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxColumnSubTotals As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxColumnGrandTotals As Telerik.WinControls.UI.RadCheckBox
		Private checkBoxRowGrandTotals As Telerik.WinControls.UI.RadCheckBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox3 As Telerik.WinControls.UI.RadGroupBox
		Private radioRows As Telerik.WinControls.UI.RadRadioButton
		Private radioColumns As Telerik.WinControls.UI.RadRadioButton
		Private radioLineSeries As Telerik.WinControls.UI.RadRadioButton
		Private radioBarSeries As Telerik.WinControls.UI.RadRadioButton
		Private radioAreaSeries As Telerik.WinControls.UI.RadRadioButton
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace