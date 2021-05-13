Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.SingleMonthView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radCalendar1
			Me.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radRadioRows_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If Me.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Horizontal
			End If

			If Me.radRadioCols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Vertical
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioRows.ToggleStateChanged, AddressOf radRadioRows_ToggleStateChanged
			AddHandler radRadioCols.ToggleStateChanged, AddressOf radRadioRows_ToggleStateChanged
		End Sub
	End Class
End Namespace