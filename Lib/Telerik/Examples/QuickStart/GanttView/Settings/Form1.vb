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

Namespace Telerik.Examples.WinControls.GanttView.Settings
    Partial Public Class Form1
        Inherits ExamplesForm

        Private id As Integer = 999

        Public Sub New()
            InitializeComponent()

            Me.WireAllEvents()

            Dim telerikWeddingPlanerData As DataSet = New DataSet()
            Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim resourceName As String = "TelerikWeddingPlanner.xml"

            Using xmlStream As Stream = currentAssembly.GetManifestResourceStream(resourceName)
                telerikWeddingPlanerData.ReadXml(xmlStream)
            End Using

            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Title"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Start"))
            Me.radGanttView1.GanttViewElement.Columns.Add(New GanttViewTextViewColumn("Finish"))

            Me.radGanttView1.GanttViewElement.Columns(0).Width = 300
            Me.radGanttView1.GanttViewElement.Columns(1).Width = 80
            Me.radGanttView1.GanttViewElement.Columns(2).Width = 80

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
            Me.radGanttView1.GanttViewElement.DataSource = telerikWeddingPlanerData

            Me.radDateTimePickerElementStart.Value = New DateTime(2006, 8, 19)
            Me.radDateTimePickerElementEnd.Value = New DateTime(2007, 4, 2)
        End Sub

        Private Sub WireAllEvents()
            AddHandler Me.radGanttView1.ItemChildIdNeeded, AddressOf radGanttView1_ItemChildIdNeeded
            AddHandler Me.radButtonElementAddTask.Click, AddressOf radButtonElementAddTask_Click
            AddHandler Me.radButtonElementDeleteTask.Click, AddressOf radButtonElementDeleteTask_Click
            AddHandler Me.radButtonElementAddMilestone.Click, AddressOf radButtonElementAddMilestone_Click
            AddHandler Me.radButtonElementProgress25.Click, AddressOf radButtonElementProgress25_Click
            AddHandler Me.radButtonElementProgress50.Click, AddressOf radButtonElementProgress50_Click
            AddHandler Me.radButtonElementProgress100.Click, AddressOf radButtonElementProgress100_Click
            AddHandler Me.radButtonElementWeek.Click, AddressOf radButtonElementWeek_Click
            AddHandler Me.radButtonElementMonth.Click, AddressOf radButtonElementMonth_Click
            AddHandler Me.radButtonElementYear.Click, AddressOf radButtonElementYear_Click
            AddHandler Me.radDateTimePickerElementStart.ValueChanged, AddressOf radDateTimePickerElementStart_ValueChanged
            AddHandler Me.radDateTimePickerElementEnd.ValueChanged, AddressOf radDateTimePickerElementEnd_ValueChanged
            AddHandler Me.radButtonElementPrevious.Click, AddressOf radButtonElementPrevious_Click
            AddHandler Me.radButtonElementNext.Click, AddressOf radButtonElementNext_Click
            AddHandler Me.radTrackBarElementZoom.ValueChanged, AddressOf radTrackBarElementZoom_ValueChanged
        End Sub

        Private Sub radButtonElementAddTask_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.radGanttView1.GanttViewElement.SelectedItem Is Nothing Then
                Dim newItem As GanttViewDataItem = New GanttViewDataItem()
                newItem.Start = Me.radGanttView1.GanttViewElement.SelectedItem.Start
                newItem.End = Me.radGanttView1.GanttViewElement.SelectedItem.End
                newItem.Title = "<new child>"

                Me.radGanttView1.GanttViewElement.SelectedItem.Items.Insert(0, newItem)
            End If
        End Sub

        Private Sub radButtonElementDeleteTask_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.radGanttView1.GanttViewElement.SelectedItem Is Nothing Then
                Dim children As List(Of GanttViewDataItem) = New List(Of GanttViewDataItem)()
                Dim queue As Queue(Of GanttViewDataItem) = New Queue(Of GanttViewDataItem)()
                queue.Enqueue(Me.radGanttView1.GanttViewElement.SelectedItem)

                Do While queue.Count > 0
                    Dim item As GanttViewDataItem = queue.Dequeue()
                    children.Add(item)

                    If Not item.Items Is Nothing AndAlso item.Items.Count > 0 Then
                        Dim i As Integer = 0
                        Do While i < item.Items.Count
                            queue.Enqueue(item.Items(i))
                            i += 1
                        Loop
                    End If
                Loop

                Dim j As Integer = 0

                Do While j < Me.radGanttView1.GanttViewElement.Links.Count
                    If children.Contains(Me.radGanttView1.GanttViewElement.Links(j).StartItem) OrElse children.Contains(Me.radGanttView1.GanttViewElement.Links(j).EndItem) Then
                        Me.radGanttView1.GanttViewElement.Links.RemoveAt(j)
                    Else
                        j += 1
                    End If
                Loop

                If Me.radGanttView1.GanttViewElement.SelectedItem.Parent Is Nothing Then
                    Me.radGanttView1.GanttViewElement.Items.Remove(Me.radGanttView1.GanttViewElement.SelectedItem)
                Else
                    Me.radGanttView1.GanttViewElement.SelectedItem.Parent.Items.Remove(Me.radGanttView1.GanttViewElement.SelectedItem)
                End If
            End If
        End Sub

        Private Sub radButtonElementAddMilestone_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.radGanttView1.GanttViewElement.SelectedItem Is Nothing Then
                Dim newItem As GanttViewDataItem = New GanttViewDataItem()
                newItem.Start = Me.radGanttView1.GanttViewElement.SelectedItem.Start
                newItem.End = newItem.Start
                newItem.Title = "<new milestone>"

                Me.radGanttView1.GanttViewElement.SelectedItem.Items.Insert(0, newItem)
            End If
        End Sub

        Private Sub radButtonElementProgress25_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.radGanttView1.GanttViewElement.SelectedItem Is Nothing Then
                Me.radGanttView1.GanttViewElement.SelectedItem.Progress = 25D
            End If
        End Sub

        Private Sub radButtonElementProgress50_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.radGanttView1.GanttViewElement.SelectedItem Is Nothing Then
                Me.radGanttView1.GanttViewElement.SelectedItem.Progress = 50D
            End If
        End Sub

        Private Sub radButtonElementProgress100_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.radGanttView1.GanttViewElement.SelectedItem Is Nothing Then
                Me.radGanttView1.GanttViewElement.SelectedItem.Progress = 100D
            End If
        End Sub

        Private Sub radButtonElementWeek_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Week
        End Sub

        Private Sub radButtonElementMonth_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month
        End Sub

        Private Sub radButtonElementYear_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Year
        End Sub

        Private Sub radDateTimePickerElementStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radDateTimePickerElementStart.Value.HasValue Then
                Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = Me.radDateTimePickerElementStart.Value.Value
            End If
        End Sub

        Private Sub radDateTimePickerElementEnd_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radDateTimePickerElementEnd.Value.HasValue Then
                Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = Me.radDateTimePickerElementEnd.Value.Value
            End If
        End Sub

        Private Sub radButtonElementPrevious_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.HorizontalScrollBarElement.PerformLargeDecrement(1)
        End Sub

        Private Sub radButtonElementNext_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.HorizontalScrollBarElement.PerformLargeIncrement(1)
        End Sub

        Private Sub radTrackBarElementZoom_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = New TimeSpan(0, CInt(Fix(Me.radTrackBarElementZoom.Value)), 0)
        End Sub

        Private Sub radGanttView1_ItemChildIdNeeded(sender As Object, e As GanttViewItemChildIdNeededEventArgs)
            Me.id += 1
            e.ChildId = Me.id.ToString()
        End Sub

    End Class
End Namespace

