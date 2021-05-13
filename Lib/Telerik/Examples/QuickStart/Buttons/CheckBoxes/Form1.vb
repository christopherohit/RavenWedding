Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True
        End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBox3.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.radTextBoxEvents.Text += String.Format("{0} toggled" & Environment.NewLine, (TryCast(sender, RadCheckBox)).Text)
			Me.radTextBoxEvents.SelectionStart = Me.radTextBoxEvents.Text.Length
			Me.radTextBoxEvents.ScrollToCaret()
		End Sub
    End Class
End Namespace