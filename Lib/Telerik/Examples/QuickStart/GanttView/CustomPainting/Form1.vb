Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GanttView.CustomPainting
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
            InitializeGanttView()
        End Sub

        Public Sub InitializeGanttView()
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Id"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("ParentId"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Title"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Start"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("End"))

            Me.radGanttView1.GanttViewElement.Columns(0).Visible = False
            Me.radGanttView1.GanttViewElement.Columns(1).Visible = False
            Me.radGanttView1.GanttViewElement.Columns(2).Width = 350
            Me.radGanttView1.GanttViewElement.Columns(3).Width = 120
            Me.radGanttView1.GanttViewElement.Columns(4).Width = 120

            Me.radGanttView1.GanttViewElement.TaskDataMember = "Tasks"
            Me.radGanttView1.GanttViewElement.ChildMember = "Id"
            Me.radGanttView1.GanttViewElement.ParentMember = "ParentId"
            Me.radGanttView1.GanttViewElement.TitleMember = "Title"
            Me.radGanttView1.GanttViewElement.StartMember = "Start"
            Me.radGanttView1.GanttViewElement.EndMember = "End"
            Me.radGanttView1.GanttViewElement.ProgressMember = "Progress"
            Me.radGanttView1.GanttViewElement.LinkDataMember = "Links"
            Me.radGanttView1.GanttViewElement.LinkStartMember = "StartId"
            Me.radGanttView1.GanttViewElement.LinkEndMember = "EndId"
            Me.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType"

            Me.radGanttView1.DataSource = Me.GetData()
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(2013, 1, 2)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2013, 1, 30)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month

            Me.radGanttView1.EnableCustomPainting = True
        End Sub

        Private Function GetData() As DataSet
            Dim [set] As New DataSet()
            Dim tasks As New DataTable("Tasks")

            tasks.Columns.Add("Id", GetType(Integer))
            tasks.Columns.Add("ParentId", GetType(Integer))
            tasks.Columns.Add("Title", GetType(String))
            tasks.Columns.Add("Start", GetType(DateTime))
            tasks.Columns.Add("End", GetType(DateTime))
            tasks.Columns.Add("Deadline", GetType(DateTime))

            tasks.Rows.Add(1, 0, "Scope", New DateTime(2013, 1, 3, 8, 0, 0), New DateTime(2013, 1, 6, 0, 0, 0), DBNull.Value)
            tasks.Rows.Add(2, 1, "Determine project scope", New DateTime(2013, 1, 3, 8, 0, 0), New DateTime(2013, 1, 5, 23, 0, 0), New DateTime(2013, 1, 4, 12, 0, 0))
            tasks.Rows.Add(3, 1, "Secure project sponsorship", New DateTime(2013, 1, 3, 16, 0, 0), New DateTime(2013, 1, 4, 15, 0, 0), New DateTime(2013, 1, 6, 10, 0, 0))
            tasks.Rows.Add(4, 1, "Define preliminary resources", New DateTime(2013, 1, 4, 13, 0, 0), New DateTime(2013, 1, 5, 12, 0, 0), New DateTime(2013, 1, 6, 16, 0, 0))
            tasks.Rows.Add(5, 1, "Secure core resources", New DateTime(2013, 1, 5, 13, 0, 0), New DateTime(2013, 1, 6, 0, 0, 0), New DateTime(2013, 1, 8, 0, 0, 0))
            tasks.Rows.Add(6, 1, "Scope complete", New DateTime(2013, 1, 6, 0, 0, 0), New DateTime(2013, 1, 6, 0, 0, 0), DBNull.Value)
            tasks.Rows.Add(7, 0, "Analysis/Software Requirements", New DateTime(2013, 1, 6, 13, 0, 0), New DateTime(2013, 1, 28, 16, 0, 0), DBNull.Value)
            tasks.Rows.Add(8, 7, "Conduct needed analysis", New DateTime(2013, 1, 6, 13, 0, 0), New DateTime(2013, 1, 12, 0, 0, 0), New DateTime(2013, 1, 14, 10, 0, 0))
            tasks.Rows.Add(9, 7, "Draft preliminary software specifications", New DateTime(2013, 1, 13, 13, 0, 0), New DateTime(2013, 1, 18, 0, 0, 0), New DateTime(2013, 1, 16, 0, 0, 0))
            tasks.Rows.Add(10, 7, "Develop preliminary budget", New DateTime(2013, 1, 18, 13, 0, 0), New DateTime(2013, 1, 20, 0, 0, 0), New DateTime(2013, 1, 21, 0, 0, 0))
            tasks.Rows.Add(11, 7, "Review software specifications/budget with team", New DateTime(2013, 1, 21, 5, 0, 0), New DateTime(2013, 1, 21, 17, 0, 0), New DateTime(2013, 1, 21, 23, 0, 0))
            tasks.Rows.Add(12, 7, "Incorporate feedback on software specifications", New DateTime(2013, 1, 21, 12, 0, 0), New DateTime(2013, 1, 21, 23, 0, 0), New DateTime(2013, 1, 22, 12, 0, 0))
            tasks.Rows.Add(13, 7, "Develop delivery time", New DateTime(2013, 1, 24, 6, 0, 0), New DateTime(2013, 1, 24, 16, 0, 0), New DateTime(2013, 1, 24, 20, 0, 0))
            tasks.Rows.Add(14, 7, "Obtain approval to proceed (concept, timeline, budget)", New DateTime(2013, 1, 25, 5, 0, 0), New DateTime(2013, 1, 25, 15, 0, 0), New DateTime(2013, 1, 25, 17, 0, 0))
            tasks.Rows.Add(15, 7, "Secure required resources", New DateTime(2013, 1, 24, 13, 0, 0), New DateTime(2013, 1, 28, 16, 0, 0), New DateTime(2013, 1, 28, 20, 0, 0))
            tasks.Rows.Add(16, 7, "Analysis complete", New DateTime(2013, 1, 26, 0, 0, 0), New DateTime(2013, 1, 26, 0, 0, 0), DBNull.Value)

            Dim links As New DataTable("Links")

            links.Columns.Add("StartId", GetType(Integer))
            links.Columns.Add("EndId", GetType(Integer))
            links.Columns.Add("LinkType", GetType(Integer))

            links.Rows.Add(2, 3, 1)
            links.Rows.Add(3, 4, 1)
            links.Rows.Add(4, 5, 1)
            links.Rows.Add(5, 6, 1)
            links.Rows.Add(8, 9, 1)
            links.Rows.Add(9, 10, 1)
            links.Rows.Add(10, 11, 1)
            links.Rows.Add(11, 12, 1)
            links.Rows.Add(12, 13, 1)
            links.Rows.Add(13, 14, 1)
            links.Rows.Add(14, 15, 1)
            links.Rows.Add(15, 16, 1)

            [set].Tables.Add(tasks)
            [set].Tables.Add(links)

            Return [set]
        End Function

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()

            AddHandler Me.radGanttView1.ItemPaint, AddressOf radGanttView1_ItemPaint
        End Sub

        Private Sub radGanttView1_ItemPaint(sender As Object, e As GanttViewItemPaintEventArgs)
            Dim item As GanttViewDataItem = e.Element.Data
            Dim row As DataRowView = TryCast(item.DataBoundItem, DataRowView)

            Dim deadlineValue As Object = row("Deadline")

            If deadlineValue.Equals(DBNull.Value) Then
                Return
            End If

            Dim deadline As DateTime = CType(deadlineValue, DateTime)
            Dim overdue As Boolean = deadline < item.[End]

            Dim deadlineRect As RectangleF = e.Element.GraphicalViewElement.GetDrawRectangle(item, deadline)
            Dim overdueFlagRect As RectangleF = e.Element.GraphicalViewElement.GetDrawRectangle(item, item.[End].AddHours(2))

            Dim mode As SmoothingMode = e.Graphics.SmoothingMode
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Me.DrawOverdueFlag(e.Graphics, overdueFlagRect, overdue)
            Me.DrawDeadline(e.Graphics, deadlineRect)
            e.Graphics.SmoothingMode = mode
        End Sub

        Private Sub DrawDeadline(graphics As Graphics, rect As RectangleF)
            Dim topBallRect As New RectangleF(rect.X - 2, rect.Y + 1, 4.0F, 4.0F)
            Dim bottomBallRect As New RectangleF(rect.X - 2, rect.Bottom - 2, 4.0F, 4.0F)

            graphics.DrawLine(Pens.Red, New PointF(rect.X, rect.Y + 2), New PointF(rect.X, rect.Bottom))
            graphics.FillEllipse(Brushes.Red, topBallRect)
            graphics.FillEllipse(Brushes.Red, bottomBallRect)
        End Sub

        Private Sub DrawOverdueFlag(graphics As Graphics, rect As RectangleF, overdue As Boolean)
            Dim points As PointF() = New PointF(6) {}
            points(0) = New PointF(rect.X, rect.Y + 2)
            points(1) = New PointF(rect.X + 20, rect.Y + 2)
            points(2) = New PointF(rect.X + 15, rect.Y + 2 + rect.Height / 4.0F)
            points(3) = New PointF(rect.X + 20, rect.Y + 2 + rect.Height / 2.0F)
            points(4) = New PointF(rect.X + 2, rect.Y + 2 + rect.Height / 2.0F)
            points(5) = New PointF(rect.X + 2, rect.Bottom)
            points(6) = New PointF(rect.X, rect.Bottom)


            Dim flagPath As New GraphicsPath()
            flagPath.AddClosedCurve(points, 0.0F)

            If overdue Then
                graphics.FillPath(Brushes.Red, flagPath)
            Else
                graphics.FillPath(Brushes.Green, flagPath)
            End If
        End Sub
    End Class
End Namespace

