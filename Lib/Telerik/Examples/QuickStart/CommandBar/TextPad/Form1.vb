Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.CommandBar.TextPad
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.panel1

			AddHandler Me.SizeChanged, AddressOf Form1_SizeChanged
		End Sub

		Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			pictureBox1.Width = radCommandBar1.Width + 26
		End Sub

		Private Sub alignment_ToggleStateChanging(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangingEventArgs)
			Dim senderButton As CommandBarToggleButton = (TryCast(sender, CommandBarToggleButton))

			If args.NewValue = Telerik.WinControls.Enumerations.ToggleState.Off Then
				Return
			End If

			If senderButton IsNot radCommandBarToggleButtonItem4 Then
				radCommandBarToggleButtonItem4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If

			If senderButton IsNot radCommandBarToggleButtonItem5 Then
				radCommandBarToggleButtonItem5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If

			If senderButton IsNot radCommandBarToggleButtonItem6 Then
				radCommandBarToggleButtonItem6.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If

			If senderButton IsNot radCommandBarToggleButtonItem7 Then
				radCommandBarToggleButtonItem7.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCommandBarToggleButtonItem4.ToggleStateChanging, AddressOf alignment_ToggleStateChanging
			AddHandler radCommandBarToggleButtonItem5.ToggleStateChanging, AddressOf alignment_ToggleStateChanging
			AddHandler radCommandBarToggleButtonItem6.ToggleStateChanging, AddressOf alignment_ToggleStateChanging
			AddHandler radCommandBarToggleButtonItem7.ToggleStateChanging, AddressOf alignment_ToggleStateChanging
		End Sub

	End Class
End Namespace
