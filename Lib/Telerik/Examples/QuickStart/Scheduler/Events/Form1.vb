Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.Events
    Partial Public Class Form1
    Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Dim baseDate As Date = Date.Today
            Dim start() As Date = { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) }
            Dim [end]() As Date = { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) }
            Dim summaries() As String = { "Mr. Brown", "Mr. White", "Mrs. Green" }
            Dim descriptions() As String = { "", "", "" }
            Dim locations() As String = { "City", "Out of town", "Service Center" }
            Dim backgrounds() As AppointmentBackground = { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal }

            Me.radSchedulerDemo.Appointments.BeginUpdate()
            Dim appointment As Appointment = Nothing
            For i As Integer = 0 To summaries.Length - 1
                appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
                appointment.BackgroundId = CInt(Fix(backgrounds(i)))
                Me.radSchedulerDemo.Appointments.Add(appointment)
            Next i

            appointment = New Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage")
            appointment.RecurrenceRule = New DailyRecurrenceRule(baseDate.AddHours(11.0), 2)
            Me.radSchedulerDemo.Appointments.Add(appointment)
            Me.radSchedulerDemo.Appointments.EndUpdate()

            Me.radSchedulerDemo.Resources.Add(New Resource(1, "Dell Laptop"))
            Me.radSchedulerDemo.Resources.Add(New Resource(2, "Lenovo Laptop"))
            Me.radSchedulerDemo.Resources.Add(New Resource(3, "Toshiba Laptop"))
            TryCast(Me.radSchedulerDemo.ActiveView, SchedulerDayView).DayCount = 1
            Me.radTxtEventList.ReadOnly = True
        End Sub

        Private Sub radScheduler1_AppointmentMouseDown(ByVal sender As Object, ByVal e As SchedulerAppointmentMouseEventArgs)
            Me.radTxtEventList.Text &= "AppointmentMouseDown" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentMouseUp(ByVal sender As Object, ByVal e As SchedulerAppointmentMouseEventArgs)
            Me.radTxtEventList.Text &= "AppointmentMouseUp" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs)
            Me.radTxtEventList.Text &= "AppointmentEditDialogShowing" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentSelected(ByVal sender As Object, ByVal e As SchedulerAppointmentSelectedEventArgs)
            Me.radTxtEventList.Text &= "AppointmentSelected" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentSelecting(ByVal sender As Object, ByVal e As SchedulerAppointmentCancelEventArgs)
            Me.radTxtEventList.Text &= "AppointmentSelecting" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_CellClick(ByVal sender As Object, ByVal e As SchedulerCellEventArgs)
            Me.radTxtEventList.Text &= "CellClick" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_ActiveViewChanging(ByVal sender As Object, ByVal e As SchedulerViewChangingEventArgs)
            Me.radTxtEventList.Text &= "ActiveViewChanging" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
            Me.radTxtEventList.Text &= "ActiveViewChanged" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radSchedulerDemo_RecurrenceEditDialogShowing(ByVal sender As Object, ByVal e As RecurrenceEditDialogShowingEventArgs)
            Me.radTxtEventList.Text &= "RecurrenceEditDialogShowing" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentDropping(sender As Object, e As AppointmentMovingEventArgs)
            Me.radTxtEventList.Text &= "AppointmentDropping" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentDropped(sender As Object, e As AppointmentMovedEventArgs)
            Me.radTxtEventList.Text &= "AppointmentDropped" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentMoving(sender As Object, e As AppointmentMovingEventArgs)
            Me.radTxtEventList.Text &= "AppointmentMoving" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_CellSelectionChanging(sender As Object, e As SchedulerCellSelectingEventArgs)
            Me.radTxtEventList.Text &= "CellSelectionChanging" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_CellSelectionChanged(sender As Object, e As EventArgs)
            Me.radTxtEventList.Text &= "CellSelectionChanged" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentMoved(sender As Object, e As Telerik.WinControls.UI.AppointmentMovedEventArgs)
            Me.radTxtEventList.Text &= "AppointmentMoved" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentResizeStart(sender As Object, e As Telerik.WinControls.UI.SchedulerAppointmentCancelEventArgs)
            Me.radTxtEventList.Text &= "AppointmentResizeStart" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentResizeEnd(sender As Object, e As Telerik.WinControls.UI.SchedulerAppointmentEventArgs)
            Me.radTxtEventList.Text &= "AppointmentResizeEnd" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub

        Private Sub radScheduler1_AppointmentResized(sender As Object, e As Telerik.WinControls.UI.AppointmentResizedEventArgs)
            Me.radTxtEventList.Text &= "AppointmentResized" & vbCrLf
            Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
            Me.radTxtEventList.ScrollToCaret()
        End Sub
        Protected Overrides Sub WireEvents()
            AddHandler Me.radSchedulerDemo.ActiveViewChanged, AddressOf Me.radScheduler1_ActiveViewChanged
            AddHandler Me.radSchedulerDemo.AppointmentSelected, AddressOf Me.radScheduler1_AppointmentSelected
            AddHandler Me.radSchedulerDemo.RecurrenceEditDialogShowing, AddressOf Me.radSchedulerDemo_RecurrenceEditDialogShowing
            AddHandler Me.radSchedulerDemo.CellClick, AddressOf Me.radScheduler1_CellClick
            AddHandler Me.radSchedulerDemo.AppointmentMouseDown, AddressOf Me.radScheduler1_AppointmentMouseDown
            AddHandler Me.radSchedulerDemo.ActiveViewChanging, AddressOf radScheduler1_ActiveViewChanging
            AddHandler Me.radSchedulerDemo.AppointmentEditDialogShowing, AddressOf Me.radScheduler1_AppointmentEditDialogShowing
            AddHandler Me.radSchedulerDemo.AppointmentMouseUp, AddressOf Me.radScheduler1_AppointmentMouseUp
            AddHandler Me.radSchedulerDemo.AppointmentSelecting, AddressOf radScheduler1_AppointmentSelecting

            AddHandler Me.radSchedulerDemo.AppointmentResized, AddressOf Me.radScheduler1_AppointmentResized
            AddHandler Me.radSchedulerDemo.AppointmentResizeEnd, AddressOf Me.radScheduler1_AppointmentResizeEnd
            AddHandler Me.radSchedulerDemo.AppointmentResizeStart, AddressOf Me.radScheduler1_AppointmentResizeStart

            AddHandler Me.radSchedulerDemo.AppointmentMoving, AddressOf Me.radScheduler1_AppointmentMoving
            AddHandler Me.radSchedulerDemo.AppointmentMoved, AddressOf Me.radScheduler1_AppointmentMoved
            AddHandler Me.radSchedulerDemo.AppointmentDropped, AddressOf Me.radScheduler1_AppointmentDropped
            AddHandler Me.radSchedulerDemo.AppointmentDropping, AddressOf Me.radScheduler1_AppointmentDropping

            AddHandler Me.radSchedulerDemo.CellSelectionChanged, AddressOf Me.radScheduler1_CellSelectionChanged
            AddHandler Me.radSchedulerDemo.CellSelectionChanging, AddressOf Me.radScheduler1_CellSelectionChanging
        End Sub
    End Class
End Namespace
