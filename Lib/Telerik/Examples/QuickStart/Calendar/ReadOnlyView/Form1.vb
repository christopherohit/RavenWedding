Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.ReadOnlyView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radCalendar1
			Me.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckReadOnly_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radCalendar1.ReadOnly = Me.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckReadOnly.ToggleStateChanged, AddressOf radCheckReadOnly_ToggleStateChanged
		End Sub
	End Class
End Namespace