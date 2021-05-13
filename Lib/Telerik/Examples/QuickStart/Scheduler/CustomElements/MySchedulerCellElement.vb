Imports System.Linq
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.CustomElements
	Public Class MySchedulerCellElement
		Inherits SchedulerCellElement
		Private hoverElemnt As LightVisualElement

		Public Sub New(ByVal scheduler As RadScheduler, ByVal view As SchedulerView)
			MyBase.New(scheduler, view)
			AddHandler scheduler.ContextMenuOpening, AddressOf scheduler_ContextMenuOpening
		End Sub

		Private Sub scheduler_ContextMenuOpening(ByVal sender As Object, ByVal e As SchedulerContextMenuOpeningEventArgs)
			If Not(TypeOf e.Element Is AppointmentElement) Then
				e.Cancel = True
			End If
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			hoverElemnt = New LightVisualElement()
			hoverElemnt.ShouldHandleMouseInput = True
			hoverElemnt.NotifyParentOnMouseInput = False
			hoverElemnt.StretchHorizontally = True
			hoverElemnt.Text = ""
			hoverElemnt.TextAlignment = ContentAlignment.MiddleLeft
			hoverElemnt.DrawFill = True
			hoverElemnt.ForeColor = ColorTranslator.FromHtml("#FFB452")
			hoverElemnt.GradientStyle = GradientStyles.Solid

			AddHandler hoverElemnt.MouseEnter, AddressOf buttonElemnt_MouseEnter
			AddHandler hoverElemnt.MouseLeave, AddressOf buttonElemnt_MouseLeave
			AddHandler hoverElemnt.Click, AddressOf hoverElemnt_Click

			Me.Children.Add(hoverElemnt)
		End Sub

		Private Sub hoverElemnt_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim [end] As Date = Me.Date + Me.Duration

			Dim interval As New DateTimeInterval(Me.Date, [end])
			Me.Scheduler.AddNewAppointmentWithDialog(interval, False, Nothing)
		End Sub

		Private Sub buttonElemnt_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			hoverElemnt.BackColor = Color.Transparent
			hoverElemnt.Text = ""
		End Sub

		Private Sub buttonElemnt_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			hoverElemnt.BackColor = ColorTranslator.FromHtml("#FFFBD8")
			hoverElemnt.Text = "Click here to add event"
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(SchedulerCellElement)
			End Get
		End Property
	End Class
End Namespace