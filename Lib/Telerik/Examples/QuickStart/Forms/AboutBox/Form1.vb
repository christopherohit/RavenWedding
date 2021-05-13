Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Forms.AboutBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
            InitializeComponent()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim aboutBox As New RadAboutBox1()

            aboutBox.ThemeName = Me.CurrentThemeName
			aboutBox.ShowDialog(Me)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace
