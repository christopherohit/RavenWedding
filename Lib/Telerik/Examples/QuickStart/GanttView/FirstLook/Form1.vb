Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Reflection
Imports System.IO

Namespace Telerik.Examples.WinControls.GanttView.FirstLook
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
            Dim startColumn As GanttViewTextViewColumn = New GanttViewTextViewColumn("Start")
            startColumn.DataType = GetType(DateTime)
            startColumn.FormatString = "{0:dd.MM.yyyy}"
            Me.radGanttView1.GanttViewElement.Columns.Add(startColumn)
            Dim endColumn As GanttViewTextViewColumn = New GanttViewTextViewColumn("Finish")
            endColumn.DataType = GetType(DateTime)
            endColumn.FormatString = "{0:dd.MM.yyyy}"
            Me.radGanttView1.GanttViewElement.Columns.Add(endColumn)

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
            Me.radGanttView1.GanttViewElement.EndMember = "Finish"
            Me.radGanttView1.GanttViewElement.ProgressMember = "Progress"
            Me.radGanttView1.GanttViewElement.LinkDataMember = "Links"
            Me.radGanttView1.GanttViewElement.LinkStartMember = "StartId"
            Me.radGanttView1.GanttViewElement.LinkEndMember = "EndId"
            Me.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType"

            Dim telerikWeddingPlanner As New DataSet()
            Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim resourceName As String = "TelerikWeddingPlanner.xml"

            Using resourceStream As Stream = executingAssembly.GetManifestResourceStream(resourceName)
                telerikWeddingPlanner.ReadXml(resourceStream)
            End Using

            Me.radGanttView1.DataSource = telerikWeddingPlanner

            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(2006, 8, 21)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2007, 4, 3)
        End Sub

    End Class
End Namespace

