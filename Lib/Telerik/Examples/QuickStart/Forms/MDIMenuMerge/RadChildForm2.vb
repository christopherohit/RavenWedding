Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
	Partial Public Class RadChildForm2
		Inherits ExamplesRadForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radProgressBarElement1.PerformStepValue1()
			If Me.radProgressBarElement1.Value1 >= Me.radProgressBarElement1.Maximum Then
				Me.radProgressBarElement1.Value1 = Me.radProgressBarElement1.Minimum
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButtonElement1.Click, AddressOf radButtonElement1_Click
			AddHandler timer1.Tick, AddressOf timer1_Tick
		End Sub

		Private Sub radButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Windows.Forms.MessageBox.Show("Thank you for clicking RadButton", "StatusBarClick event", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub
	End Class
End Namespace
