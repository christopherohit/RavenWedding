Imports System.ComponentModel
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.Grouping
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

			appointment = New Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage")
			appointment.RecurrenceRule = New DailyRecurrenceRule(baseDate.AddHours(11.0), 2)
			Me.radSchedulerDemo.Appointments.Add(appointment)
			Me.radSchedulerDemo.Appointments.EndUpdate()

			Dim colors() As Color = { Color.LightBlue, Color.LightGreen, Color.LightYellow, Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue }

			Dim names() As String = { "Alan Smith", "Anne Dodsworth", "Boyan Mastoni", "Richard Duncan", "Maria Shnaider" }

			For i As Integer = 0 To names.Length - 1
				Dim resource As New Resource()
				resource.Id = New EventId(i)
				resource.Name = names(i)
				resource.Color = colors(i)

				resource.Image = Me.imageList1.Images(i)
				Me.radSchedulerDemo.Resources.Add(resource)
			Next i

			Me.radSchedulerDemo.GetDayView().ResourcesPerView = 2
			Me.radSchedulerDemo.GroupType = GroupType.Resource
			Dim headerElement As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			headerElement.ResourceHeaderHeight = 135

			For i As Integer = 0 To summaries.Length - 1
				appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
				appointment.ResourceId = Me.radSchedulerDemo.Resources(0).Id
				appointment.BackgroundId = CInt(Fix(backgrounds(i)))
				Me.radSchedulerDemo.Appointments.Add(appointment)
			Next i

			Dim dayView As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			dayView.ScrollToWorkHours()

			AddHandler radSchedulerDemo.ActiveViewChanged, AddressOf radSchedulerDemo_ActiveViewChanged
			AddHandler radSchedulerDemo.PropertyChanged, AddressOf radSchedulerDemo_PropertyChanged
			AddHandler radSchedulerDemo.MouseDown, AddressOf radSchedulerDemo_MouseDown

			Me.radSchedulerDemo.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Timeline, 0)

			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radSchedulerDemo
			Me.radSchedulerDemo.SelectionBehavior.SelectDateRange(Date.Now.Date.AddHours(7), Date.Now.Date.AddHours(8), Me.radSchedulerDemo.Resources(0).Id)
		End Sub

		Private Sub radSchedulerDemo_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Me.isSwitchedMonthToWeek Then
				InvalidateScheduler()
				Me.isSwitchedMonthToWeek = False
			End If
		End Sub

		Private Sub radSchedulerDemo_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			InvalidateScheduler()
		End Sub

		Private Sub radSchedulerDemo_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			If e.OldView.ViewType <> e.NewView.ViewType Then
				Select Case e.NewView.ViewType
					Case SchedulerViewType.Month
						Me.radSchedulerDemo.GetMonthView().WeekCount = 5
					Case SchedulerViewType.Day
						Me.radSchedulerDemo.GetDayView().DayCount = 1
				End Select
			End If

			If e.OldView.ViewType = SchedulerViewType.Month AndAlso e.NewView.ViewType = SchedulerViewType.Week Then
				Me.isSwitchedMonthToWeek = True
			End If

			InvalidateScheduler()
		End Sub

		Private isSwitchedMonthToWeek As Boolean = False

		Private Sub InvalidateScheduler()
			Dim dayView As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			Dim monthView As SchedulerMonthViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerMonthViewGroupedByResourceElement)
			Dim timelineElement As TimelineGroupingByResourcesElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, TimelineGroupingByResourcesElement)

			If dayView Is Nothing AndAlso monthView Is Nothing AndAlso timelineElement Is Nothing Then
				Return
			End If

			Dim headerHeight As Integer = 135

			If dayView IsNot Nothing Then
				dayView.ResourceHeaderHeight = headerHeight
				dayView.InvalidateMeasure(True)
			ElseIf monthView IsNot Nothing Then
				monthView.ResourceHeaderHeight = headerHeight
			ElseIf timelineElement IsNot Nothing Then
				timelineElement.ResourceHeaderWidth = headerHeight
			End If

			Me.radSchedulerDemo.PerformLayout()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radSchedulerDemo.GetDayView().DayCount = 1
			Me.radSchedulerDemo.GetDayView().StartDate = Me.radSchedulerDemo.GetDayView().StartDate.AddDays(1)
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub

		Private suspendTrackBar As Boolean = False

		Private Sub radTrackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTrackBar1.ValueChanged
			If radSchedulerDemo.SelectionBehavior.CurrentCellElement IsNot Nothing Then
				Dim viewGroupedByResource As SchedulerViewGroupedByResourceElementBase = TryCast(radSchedulerDemo.ViewElement, SchedulerViewGroupedByResourceElementBase)
				Dim resourceId As Integer = GetResourceIndex(viewGroupedByResource)

				If resourceId >= 0 AndAlso (Not suspendTrackBar) Then
					viewGroupedByResource.SetResourceSize(resourceId, Me.radTrackBar1.Value)
				End If
			End If
		End Sub

		Private Function GetResourceIndex(ByVal viewGroupedByResource As SchedulerViewGroupedByResourceElementBase) As Integer
			Dim cellResource As IResource = radSchedulerDemo.SelectionBehavior.CurrentCellElement.View.GetResource()
			Dim cellResourceIndex As Integer = radSchedulerDemo.Resources.IndexOf(cellResource)

			Dim resourceId As Integer = cellResourceIndex - viewGroupedByResource.ResourceStartIndex
			Return resourceId
		End Function

		Private Sub radSchedulerDemo_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSchedulerDemo.CellSelectionChanged
			suspendTrackBar = True
			Dim viewGroupedByResource As SchedulerViewGroupedByResourceElementBase = TryCast(radSchedulerDemo.ViewElement, SchedulerViewGroupedByResourceElementBase)
			Dim resourceId As Integer = GetResourceIndex(viewGroupedByResource)
			Me.radTrackBar1.Value = viewGroupedByResource.GetResourceSize(resourceId)
			suspendTrackBar = False
		End Sub

		Private Sub radTrackBar1_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles radTrackBar1.ToolTipTextNeeded
			e.ToolTipText = "Resize current resource"
		End Sub
	End Class
End Namespace