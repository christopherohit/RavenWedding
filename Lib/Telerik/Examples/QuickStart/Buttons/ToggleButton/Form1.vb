Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.Buttons.ToggleButton
	''' <summary>
	''' Main class for the toggle button example
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True
        End Sub

		Private Sub radToggleButton6_ToggleStateChanging(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangingEventArgs)
			If Not(radToggleButton6.ToggleState = ToggleState.On) Then
				radToggleButton6.ImageIndex = 4
				label1.Text = "Button Toggled On"
			Else
				radToggleButton6.ImageIndex = 3
				label1.Text = "Button Toggled Off"
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radToggleButton6.ToggleStateChanging, AddressOf radToggleButton6_ToggleStateChanging
		End Sub
	End Class
End Namespace