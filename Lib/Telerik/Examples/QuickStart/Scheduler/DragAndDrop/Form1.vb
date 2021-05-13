Imports System.Collections
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.DragAndDrop

    Partial Public Class Form1
        Inherits ExamplesForm
#Region "OLE drag & drop"

        Private mouseDownPosition As Point
        Private isDragging As Boolean

        Private Enum AppointmentFields
            Row
            Summary
            Location
            Description
            Start
            [End]
            Background
            Status
        End Enum

        Private Class DragObject
            Private m_status As AppointmentFields
            Private m_values As New Dictionary(Of AppointmentFields, Object)()

            Public Property Status() As AppointmentFields
                Get
                    Return Me.m_status
                End Get
                Set(value As AppointmentFields)
                    Me.m_status = value
                End Set
            End Property

            Public ReadOnly Property Values() As Dictionary(Of AppointmentFields, Object)
                Get
                    Return Me.m_values
                End Get
            End Property
        End Class

        Private Class MyGridBehavior
            Inherits BaseGridBehavior
            Private mouseDownPoint As Point = Point.Empty

            Public Overrides Function OnMouseDown(e As MouseEventArgs) As Boolean
                If e.Button = MouseButtons.Left Then
                    mouseDownPoint = e.Location
                End If

                Return MyBase.OnMouseDown(e)
            End Function

            Public Overrides Function OnMouseMove(e As MouseEventArgs) As Boolean
                If e.Button <> MouseButtons.Left Then
                    Me.mouseDownPoint = Point.Empty
                    Return MyBase.OnMouseMove(e)
                End If

                If Not Me.GridViewElement.IsInEditMode AndAlso Me.ShouldBeginDrag(Me.mouseDownPoint, e.Location) Then
                    Dim element As RadElement = Me.GridControl.ElementTree.GetElementAtPoint(e.Location)

                    Dim cell As GridCellElement = TryCast(element, GridCellElement)

                    If cell IsNot Nothing AndAlso Object.Equals(cell, Me.GridViewElement.CurrentCell) Then
                        Dim dragObject As New DragObject()

                        dragObject.Values.Add(AppointmentFields.Summary, cell.RowInfo.Cells("Summary").Value)
                        dragObject.Values.Add(AppointmentFields.Start, cell.RowInfo.Cells("Start").Value)
                        dragObject.Values.Add(AppointmentFields.[End], cell.RowInfo.Cells("End").Value)
                        dragObject.Values.Add(AppointmentFields.Description, cell.RowInfo.Cells("Description").Value)
                        dragObject.Values.Add(AppointmentFields.Background, cell.RowInfo.Cells("BackgroundID").Value)
                        dragObject.Values.Add(AppointmentFields.Status, cell.RowInfo.Cells("StatusID").Value)
                        dragObject.Values.Add(AppointmentFields.Location, cell.RowInfo.Cells("Location").Value)

                        dragObject.Status = AppointmentFields.Row

                        Me.GridViewElement.ElementTree.Control.DoDragDrop(dragObject, DragDropEffects.Copy)
                        Return True
                    End If
                End If

                Return MyBase.OnMouseMove(e)
            End Function


            Private Function ShouldBeginDrag(current As Point, capture As Point) As Boolean
                Dim dragSize As Size = SystemInformation.DragSize
                Dim dragRect As New Rectangle(CInt(capture.X - dragSize.Width / 2), CInt(capture.Y - dragSize.Height / 2), dragSize.Width, dragSize.Height)
                Return Not dragRect.Contains(current)
            End Function
        End Class

        Private Sub radScheduler1_DragDrop(sender As Object, e As DragEventArgs)
            Dim point As Point = Me.radScheduler1.PointToClient(New Point(e.X, e.Y))

            Dim table As DayViewAppointmentsTable = TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement).DataAreaElement.Table
            Dim schedulerCell As SchedulerCellElement = SchedulerUIHelper.GetCellAtPoint(point, table.Children)
            If schedulerCell Is Nothing Then
                Dim allDay As DayViewAllDayHeader = TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement).AllDayHeaderElement
                schedulerCell = SchedulerUIHelper.GetCellAtPoint(point, allDay.Children)
            End If

            If schedulerCell Is Nothing Then
                Return
            End If

            Dim dragObject As DragObject = TryCast(e.Data.GetData(GetType(DragObject)), DragObject)
            If dragObject IsNot Nothing Then
                Me.radScheduler1.Appointments.BeginUpdate()
                Dim appointment As Appointment = CreateAppointment(schedulerCell.[Date], dragObject)
                Me.radScheduler1.Appointments.Add(appointment)
                Me.radScheduler1.Appointments.EndUpdate()
            End If
        End Sub

        Private Sub radScheduler1_DragEnter(sender As Object, e As DragEventArgs)
            Dim dragObject As DragObject = TryCast(e.Data.GetData(GetType(DragObject)), DragObject)

            e.Effect = If(dragObject Is Nothing, DragDropEffects.None, DragDropEffects.Copy)
        End Sub

        Private Sub radListBox1_MouseUp(sender As Object, e As MouseEventArgs)
            Me.mouseDownPosition = Point.Empty
            Me.isDragging = False
        End Sub

        Private Sub radListBox1_MouseMove(sender As Object, e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then
                Return
            End If

            If Me.isDragging Then
                Return
            End If

            Dim currentPosition As Point = e.Location
            If (Math.Abs(currentPosition.X - Me.mouseDownPosition.X) >= SystemInformation.DragSize.Width) OrElse (Math.Abs(currentPosition.Y - Me.mouseDownPosition.Y) >= SystemInformation.DragSize.Height) Then
                Me.isDragging = True
                Dim dragObject As New DragObject()
                Dim item As RadListVisualItem = TryCast(Me.radListBox1.ElementTree.GetElementAtPoint(e.Location), RadListVisualItem)

                If item IsNot Nothing Then
                    dragObject.Values.Add(AppointmentFields.Summary, item.Text)
                    dragObject.Status = AppointmentFields.Summary

                    TryCast(sender, RadListControl).DoDragDrop(dragObject, DragDropEffects.Copy)
                End If
            End If
        End Sub

        Private Sub radListBox1_MouseDown(sender As Object, e As MouseEventArgs)
            Me.mouseDownPosition = e.Location
            MyBase.OnMouseDown(e)
        End Sub

        Private Function CreateAppointment(currentDate As DateTime, dragObject As DragObject) As Appointment
            Dim appointment As New Appointment()
            Dim startDate As DateTime = currentDate
            Dim endDate As DateTime = currentDate.AddHours(1)
            Select Case dragObject.Status
                Case AppointmentFields.Summary
                    appointment.Summary = TryCast(dragObject.Values(dragObject.Status), String)
                    Exit Select
                Case AppointmentFields.Row
                    appointment.Summary = TryCast(dragObject.Values(AppointmentFields.Summary), String)
                    appointment.Description = TryCast(dragObject.Values(AppointmentFields.Description), String)
                    appointment.BackgroundId = CInt(dragObject.Values(AppointmentFields.Background))
                    appointment.StatusId = CInt(dragObject.Values(AppointmentFields.Status))
                    appointment.Location = TryCast(dragObject.Values(AppointmentFields.Location), String)

                    startDate = DirectCast(dragObject.Values(AppointmentFields.Start), DateTime)
                    endDate = DirectCast(dragObject.Values(AppointmentFields.[End]), DateTime)
                    If Me.radRadioButtonAnywhere.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                        Dim range As TimeSpan = endDate - startDate
                        endDate = currentDate + range
                        startDate = currentDate
                    End If
                    Exit Select
            End Select
            appointment.Start = startDate
            appointment.[End] = endDate
            Return appointment
        End Function

#End Region

#Region "Initialization"

        Public Sub New()
            InitializeComponent()

            FillDataTableByEnum(Me.schedulerDragAndDropDataDataSet.AppointmentStatuses, GetType(AppointmentStatus))

            FillDataTableByEnum(Me.schedulerDragAndDropDataDataSet.AppointmentBackgrounds, GetType(AppointmentBackground))

            Me.radGridView1.GridBehavior = New MyGridBehavior()
            Me.radGridView1.CloseEditorWhenValidationFails = False
            AddHandler Me.radGridView1.CellValidating, AddressOf radGridView1_CellValidating
            AddHandler Me.radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit

            AddHandler Me.radListBox1.MouseMove, AddressOf radListBox1_MouseMove
            AddHandler Me.radListBox1.MouseUp, AddressOf radListBox1_MouseUp

            Me.radScheduler1.ActiveView.StartDate = New DateTime(2010, 1, 25)

            FillSchedulerAppointments()

            Me.radSchedulerNavigator1.TimelineViewButtonVisible = False
            Me.radSchedulerNavigator1.MonthViewButtonVisible = False

            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
        End Sub

        Private Sub FillSchedulerAppointments()
            Me.radScheduler1.Appointments.BeginUpdate()

            Dim dtStart As DateTime = Me.radScheduler1.ActiveView.StartDate
            Dim dtEnd As DateTime = Me.radScheduler1.ActiveView.StartDate

            Dim appointment As New Appointment(dtStart.AddHours(11.0), dtStart.AddHours(12.0), "The Daily Scrum", "One of the most popular Agile project management and development methods, Scrum is starting to be adopted at major corporations and on very large projects. After an quick introduction to the basics of Scrum like: the Scrum Master, team, product owner, and burn down, and of course the daily Scrum, Stephen, Remi, and Joel show many real world applications of the methodology drawn from his own experience as a Scrum Master. Negotiating with the business, estimation, and team dynamics are all discussed as well as how to use Scrum in small organizations, large enterprise environments, and consulting environments. The speakers will also discuss using Scrum with virtual teams and even an offshoring environment. The session will finish with a large Q&A on best practices", "Room 604")
            appointment.RecurrenceRule = New DailyRecurrenceRule(dtStart.AddHours(11.0), 1)
            Me.radScheduler1.Appointments.Add(appointment)

            dtStart = dtStart.AddHours(9)
            dtEnd = dtEnd.AddHours(11)

            appointment = New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
            appointment.BackgroundId = CInt(AppointmentBackground.MustAttend)
            appointment.StatusId = CInt(AppointmentStatus.Unavailable)
            Me.radScheduler1.Appointments.Add(appointment)

            dtStart = dtStart.AddDays(1).AddHours(1)
            dtEnd = dtEnd.AddDays(1).AddHours(1)

            appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
            appointment.BackgroundId = CInt(AppointmentBackground.PhoneCall)
            appointment.StatusId = CInt(AppointmentStatus.Free)
            Me.radScheduler1.Appointments.Add(appointment)

            Me.radScheduler1.Appointments.EndUpdate()
        End Sub

        Private Sub InitListBoxStyle()
            Me.radListBox1.Font = Me.radGridView1.RootElement.FindDescendant(Of GridDataCellElement)().Font

            Me.radListBox1.RootElement.InvalidateMeasure()
            Me.radListBox1.RootElement.UpdateLayout()
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.appointmentsTableAdapter.Fill(Me.schedulerDragAndDropDataDataSet.Appointments)
            Me.radGridView1.MasterTemplate.BestFitColumns()

            InitListBoxStyle()

            Me.radScheduler1.AllowViewNavigationOnDrag = Me.checkBoxChangeView.Checked

            Me.checkBoxExceptionDialog.Checked = Me.radScheduler1.DragDropBehavior.ShowCreateExceptionDialog
            Me.checkBoxValidationDialogs.Checked = Me.radScheduler1.DragDropBehavior.ShowOccurrenceValidationMessages
            Me.checkBoxAutoScroll.Checked = True
            Me.checkBoxCreateExceptions.Checked = True

            AddHandler Me.checkBoxChangeView.ToolTipTextNeeded, Sub(sender As Object, args As ToolTipTextNeededEventArgs) args.ToolTipText = "Check to allow automatically changing the start date of the view when dragging outside the appointments area"
            AddHandler Me.checkBoxExceptionDialog.ToolTipTextNeeded, Sub(sender As Object, args As ToolTipTextNeededEventArgs) args.ToolTipText = "Check to enable the confirmation dialog when you are about to create an occurrence exception via drag & drop"
            AddHandler Me.checkBoxValidationDialogs.ToolTipTextNeeded, Sub(sender As Object, args As ToolTipTextNeededEventArgs) args.ToolTipText = "Check to enable informational dialogs when trying to drag an occurrence to an invalid date"
            AddHandler Me.checkBoxAutoScroll.ToolTipTextNeeded, Sub(sender As Object, args As ToolTipTextNeededEventArgs) args.ToolTipText = "Check to enable automatic vertical scrolling when trying to drag or resize an appointment in day view"
            AddHandler Me.checkBoxCreateExceptions.ToolTipTextNeeded, Sub(sender As Object, args As ToolTipTextNeededEventArgs) args.ToolTipText = "Check to allow creating occurrence exceptions via drag&drop or resize"
        End Sub

        Private Sub FillDataTableByEnum(dt As DataTable, enumType As Type)
            Dim lstNames As New List(Of String)([Enum].GetNames(enumType))
            Dim arrlstValues As New ArrayList([Enum].GetValues(enumType))

            For i As Integer = 0 To lstNames.Count - 1
                dt.Rows.Add(New Object() {arrlstValues(i), lstNames(i)})
            Next
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radScheduler1.DragEnter, AddressOf Me.radScheduler1_DragEnter
            AddHandler Me.radScheduler1.DragDrop, AddressOf Me.radScheduler1_DragDrop
            AddHandler Me.radListBox1.MouseDown, AddressOf Me.radListBox1_MouseDown
            AddHandler Me.radScheduler1.AppointmentResizeStart, AddressOf radScheduler1_AppointmentResizeStart
            AddHandler Me.radScheduler1.AppointmentMoving, AddressOf radScheduler1_AppointmentMoving
        End Sub

#End Region

#Region "Event Handlers"

        Private Sub radGridView1_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs)
            Dim radeditor As RadDateTimeEditor = TryCast(Me.radGridView1.ActiveEditor, RadDateTimeEditor)
            If radeditor IsNot Nothing Then
                radeditor.CustomFormat = "F"
            End If
        End Sub

        Private Sub radGridView1_CellValidating(sender As Object, e As CellValidatingEventArgs)
            Dim column As GridViewDataColumn = DirectCast(e.Column, GridViewDataColumn)

            If column IsNot Nothing AndAlso column.Name = "End" Then
                Dim [date] As DateTime = DirectCast(e.Row.Cells("Start").Value, DateTime)
                Dim newDate As DateTime = DirectCast(e.Value, DateTime)

                If newDate < [date] Then
                    e.Cancel = True
                End If
            End If
        End Sub

        Private Sub checkBoxChangeView_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles checkBoxChangeView.ToggleStateChanged
            Me.radScheduler1.AllowViewNavigationOnDrag = Me.checkBoxChangeView.Checked
        End Sub

        Private Sub checkBoxExceptionDialog_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles checkBoxExceptionDialog.ToggleStateChanged
            Me.radScheduler1.DragDropBehavior.ShowCreateExceptionDialog = Me.checkBoxExceptionDialog.Checked
        End Sub

        Private Sub checkBoxValidationDialogs_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles checkBoxValidationDialogs.ToggleStateChanged
            Me.radScheduler1.DragDropBehavior.ShowOccurrenceValidationMessages = Me.checkBoxValidationDialogs.Checked
        End Sub

        Private Sub checkBoxAutoScroll_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles checkBoxAutoScroll.ToggleStateChanged
            Me.radScheduler1.DragDropBehavior.AutoScrollDayViewOnDrag = Me.checkBoxAutoScroll.Checked
            Me.radScheduler1.ResizeBehavior.AutoScrollDayViewOnResize = Me.checkBoxAutoScroll.Checked
        End Sub

        Private Sub radScheduler1_AppointmentResizeStart(sender As Object, e As SchedulerAppointmentCancelEventArgs)
            If Not Me.checkBoxCreateExceptions.Checked AndAlso e.Appointment.MasterEvent IsNot Nothing Then
                e.Cancel = True
            End If
        End Sub

        Private Sub radScheduler1_AppointmentMoving(sender As Object, e As AppointmentMovingEventArgs)
            If Not Me.checkBoxCreateExceptions.Checked AndAlso e.Appointment.MasterEvent IsNot Nothing Then
                e.Cancel = True
            End If
        End Sub

#End Region

    End Class

End Namespace
