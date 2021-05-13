Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Reflection
Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports System.Xml

Namespace Telerik.Examples.WinControls.GanttView.MSProjectImport
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            InitializeGanttView()
            InitializeSources()
        End Sub

        Public Sub InitializeGanttView()
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Id"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("ParentId"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Title"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Start"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("End"))

            Me.radGanttView1.GanttViewElement.Columns(0).Visible = False
            Me.radGanttView1.GanttViewElement.Columns(1).Visible = False
            Me.radGanttView1.GanttViewElement.Columns(2).Width = 250
            Me.radGanttView1.GanttViewElement.Columns(3).Width = 115
            Me.radGanttView1.GanttViewElement.Columns(4).Width = 115

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
        End Sub

        Public Sub InitializeSources()
            Me.radListControlSources.Items.Add(New RadListDataItem("HomeMovePlan.xml", Me.GetResource("HomeMovePlan.xml")))
            Me.radListControlSources.Items.Add(New RadListDataItem("NursingSchedule.xml", Me.GetResource("NursingSchedule.xml")))
            Me.radListControlSources.Items.Add(New RadListDataItem("MarketSchedule.xml", Me.GetResource("MarketSchedule.xml")))
            Me.radListControlSources.Items.Add(New RadListDataItem("WeddingPlanner.xml", Me.GetResource("WeddingPlanner.xml")))
        End Sub

        Private Function GetResource(ByVal resourceName As String) As String
            Dim currentAssembly As Assembly = Assembly.GetAssembly(Me.GetType())
            Dim stream As Stream = currentAssembly.GetManifestResourceStream(resourceName)
            Dim reader As StreamReader = New StreamReader(stream)
            Return reader.ReadToEnd()
        End Function

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()

            AddHandler Me.radListControlSources.SelectedIndexChanged, AddressOf radListControlSources_SelectedIndexChanged
            Me.radListControlSources.SelectedIndex = 0
        End Sub

        Private Sub radListControlSources_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim importer As New MsProjectImporter()
            Dim reader As New StringReader(Me.radListControlSources.Items(e.Position).Value.ToString())
            Dim dataSet As DataSet = importer.GetData(reader)

            Dim minDate As DateTime = DateTime.MaxValue
            Dim maxDate As DateTime = DateTime.MinValue

            For Each row As DataRow In dataSet.Tables("Tasks").Rows
                If DirectCast(row("Start"), DateTime) < minDate Then
                    minDate = DirectCast(row("Start"), DateTime)
                End If

                If DirectCast(row("End"), DateTime) > maxDate Then
                    maxDate = DirectCast(row("End"), DateTime)
                End If
            Next

            Dim span As TimeSpan = Me.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = minDate
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = maxDate
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = span

            Me.radGanttView1.DataSource = dataSet
        End Sub
    End Class
End Namespace

