Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Forms.StatusStrip
	''' <summary>
	''' example form
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesRadForm
		Implements ISupportThemeName
		''' <summary>
		''' default constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Me.radSplitButtonElement1.GetChildAt(1).GetChildAt(0).GetChildAt(2).AutoSize = True

			Me.timer1.Start()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButtonElement1.Click, AddressOf radButtonElement1_Click
			AddHandler timer1.Tick, AddressOf timer1_Tick
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radProgressBarElement1.PerformStepValue1()
			If Me.radProgressBarElement1.Value1 >= Me.radProgressBarElement1.Maximum Then
				Me.radProgressBarElement1.Value1 = Me.radProgressBarElement1.Minimum
			End If
		End Sub

		Private Sub radButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Windows.Forms.MessageBox.Show("Thank you for clicking RadButton", "StatusBarClick event", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
	End Class
End Namespace