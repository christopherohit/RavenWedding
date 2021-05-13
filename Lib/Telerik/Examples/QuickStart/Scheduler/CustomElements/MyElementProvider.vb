Imports Telerik.Examples.WinControls.Scheduler.CustomElements
Imports Telerik.WinControls.UI

Public Class MyElementProvider
    Inherits SchedulerElementProvider
    Public Sub New(scheduler As RadScheduler)
        MyBase.New(scheduler)
    End Sub

    Protected Overrides Function CreateElement(Of T As SchedulerVisualElement)(view As SchedulerView, context As Object) As T
        If GetType(T).Equals(GetType(AppointmentElement)) Then
            Return TryCast(New MyAppointmentElement(Me.Scheduler, view, DirectCast(context, IEvent)), T)
        End If
        If GetType(T).Equals(GetType(SchedulerCellElement)) Then
            Return TryCast(New MySchedulerCellElement(Me.Scheduler, view), T)
        End If

        Return MyBase.CreateElement(Of T)(view, context)
    End Function


    Public Overrides Function CreateRulerPrimitive(area As DayViewAppointmentsArea, timeZone As SchedulerTimeZone) As RulerPrimitive
        Return New MyRulerPrimitive(Me.Scheduler, area)
    End Function
End Class
