Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.CustomElements
	Public Class MyRulerPrimitive
		Inherits RulerPrimitive
		Public Sub New(ByVal scheduler As RadScheduler, ByVal area As DayViewAppointmentsArea)
			MyBase.New(scheduler, area)
			Me.RulerRenderer = New MyRullerRender(Me)
			Me.ForeColor = Color.Black
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RulerPrimitive)
			End Get
		End Property
	End Class

	Public Class MyRullerRender
		Inherits RulerRenderer
		Public Sub New(ByVal ruler As RulerPrimitive)
			MyBase.New(ruler)
		End Sub

		Public Overrides Sub RenderHour(ByVal g As Telerik.WinControls.Paint.IGraphics, ByVal hour As Integer, ByVal bounds As RectangleF)
			If hour < 9 OrElse hour > 17 Then
				g.FillRectangle(bounds, ColorTranslator.FromHtml("#EBECE8"))
			Else
				g.FillRectangle(bounds, ColorTranslator.FromHtml("#E6F6A5"))
			End If
			MyBase.RenderHour(g, hour, bounds)
		End Sub

		Public Overrides Sub RenderSubHour(ByVal g As Telerik.WinControls.Paint.IGraphics, ByVal hour As Integer, ByVal sectionIndex As Integer, ByVal bounds As RectangleF)
			If hour < 9 OrElse hour > 17 Then
				g.FillRectangle(bounds, ColorTranslator.FromHtml("#EBECE8"))
			Else
				g.FillRectangle(bounds, ColorTranslator.FromHtml("#E6F6A5"))
			End If
			MyBase.RenderSubHour(g, hour, sectionIndex, bounds)
		End Sub
	End Class
End Namespace