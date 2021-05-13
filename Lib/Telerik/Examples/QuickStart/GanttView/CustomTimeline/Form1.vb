Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GanttView.CustomTimeline
    Public Class Form1
        Sub New()

            InitializeComponent()


            Dim timelineStart As DateTime = New DateTime(1897, 1, 1)
            Dim timelineEnd As DateTime = DateTime.Now.AddYears(1)

            Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineBehavior = New ExampleGanttViewTimelineBehavior()
            Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Custom
            Me.RadGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = New TimeSpan(168, 0, 0)
            Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = timelineStart
            Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = timelineEnd

            Me.RadGanttView1.GanttViewElement.ChildMember = "Title"
            Me.RadGanttView1.GanttViewElement.TitleMember = "Title"
            Me.RadGanttView1.GanttViewElement.StartMember = "Start"
            Me.RadGanttView1.GanttViewElement.EndMember = "End"

            Dim data As WarsData = New WarsData()
            Me.RadGanttView1.GanttViewElement.DataSource = data.Wars
        End Sub

    End Class
End Namespace
