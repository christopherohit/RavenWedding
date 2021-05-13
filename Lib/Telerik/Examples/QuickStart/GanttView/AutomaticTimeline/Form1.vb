Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GanttView.AutomaticTimeline
	Public Partial Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupGanttViews()
			Me.SetupTrackbar()
		End Sub

		Private Sub SetupGanttViews()
			Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(1990, 1, 1)
			Me.radGanttView2.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(1990, 1, 1)

			Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2011, 1, 1)
			Me.radGanttView2.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2011, 1, 1)

			Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.YearHalves
			Me.radGanttView2.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.YearHalves

			Me.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = New TimeSpan(5, 0, 0, 0)
			Me.radGanttView2.GanttViewElement.GraphicalViewElement.OnePixelTime = New TimeSpan(5, 0, 0, 0)

			Me.radGanttView1.GanttViewElement.GraphicalViewElement.AutomaticTimelineTimeRange = False
			Me.radGanttView2.GanttViewElement.GraphicalViewElement.AutomaticTimelineTimeRange = True
		End Sub

		Private Sub SetupTrackbar()
			Me.radTrackBarZoom.LargeTickFrequency = 200
			Me.radTrackBarZoom.SmallTickFrequency = 20
            Me.radTrackBarZoom.Minimum = 0
            Me.radTrackBarZoom.Maximum = 1100
            Me.radTrackBarZoom.Value = 1100

            AddHandler Me.radTrackBarZoom.ValueChanged, AddressOf radTrackBarZoom_ValueChanged
		End Sub

        Private Sub radTrackBarZoom_ValueChanged(sender As Object, e As EventArgs)
            Dim value As Double = 51 + 0.005 * Math.Pow(Me.radTrackBarZoom.Value, 2.0)
            Console.WriteLine(String.Format("{0} - {1}", Me.radTrackBarZoom.Value, value))

            Dim time As New TimeSpan(0, CInt(Math.Truncate(value)), 0)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = time
            Me.radGanttView2.GanttViewElement.GraphicalViewElement.OnePixelTime = time
        End Sub
	End Class
End Namespace
