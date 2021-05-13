Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace DemoAppsHub.ChartViewExample
	Public Partial Class ChartViewZoomScrollExampleUserControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Me.radChartView1.View.Margin = New System.Windows.Forms.Padding(0)

			Dim series As AreaSeries = New AreaSeries()
			series.PointSize = New SizeF()
			series.LegendTitle = "Newspapers"
			series.DataPoints.Add(New CategoricalDataPoint(15, "Jan 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(10, "Feb 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Mar 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Apr 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(13, "May 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Jun 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(10, "Jul 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(20, "Aug 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(16, "Sep 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(10, "Oct 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(7, "Nov 2012"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Dec 2012"))

			series.DataPoints.Add(New CategoricalDataPoint(11, "Jan 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(10, "Feb 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Mar 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(20, "Apr 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(19, "May 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Jun 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(10, "Jul 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(12, "Aug 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(14, "Sep 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(10, "Oct 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(15, "Nov 2013"))
			series.DataPoints.Add(New CategoricalDataPoint(20, "Dec 2013"))

			Me.radChartView1.Series.Add(series)

			Dim series2 As AreaSeries = New AreaSeries()
			series2.PointSize = New SizeF()
			series2.LegendTitle = "Magazines"
			series2.DataPoints.Add(New CategoricalDataPoint(15, "Jan 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(20, "Feb 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(21, "Mar 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(28, "Apr 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(25, "May 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(25, "Jun 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(20, "Jul 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(15, "Aug 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(17, "Sep 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(25, "Oct 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(19, "Nov 2012"))
			series2.DataPoints.Add(New CategoricalDataPoint(22, "Dec 2012"))

			series2.DataPoints.Add(New CategoricalDataPoint(15, "Jan 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(20, "Feb 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(5, "Mar 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(21, "Apr 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(25, "May 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(15, "Jun 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(20, "Jul 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(15, "Aug 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(33, "Sep 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(25, "Oct 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(19, "Nov 2013"))
			series2.DataPoints.Add(New CategoricalDataPoint(18, "Dec 2013"))
			Me.radChartView1.Series.Add(series2)

			Me.radChartView1.Axes(0).LabelFitMode = AxisLabelFitMode.Rotate
			Me.radChartView1.Axes(0).LabelRotationAngle = 45

			Me.radChartView1.ShowLegend = True
			Me.radChartView1.LegendTitle = "Sold copies (x 1K)"

			Me.radChartView1.ShowPanZoom = True
		End Sub
	End Class
End Namespace
