Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.TextBoxControl
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm

		Public Sub New()
			InitializeComponent()
			Me.radPanel1.PanelElement.PanelFill.Visibility = ElementVisibility.Hidden
			Me.radTextBoxControl1.TextBoxElement.BackgroundImageLayout = ImageLayout.Stretch
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.radBtnSetBackgroundImage.Click, AddressOf radBtnSetBackgroundImage_Click
			AddHandler Me.radButtonSearch.Click, AddressOf radButtonSearch_Click
		End Sub

		Private Sub radBtnSetBackgroundImage_Click(ByVal sender As Object, ByVal e As EventArgs)
			Using fileDialog As New OpenFileDialog()
				fileDialog.Multiselect = False
				fileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF;*.PNG;"

				If fileDialog.ShowDialog() = DialogResult.OK Then
					Dim image As Image = Image.FromStream(fileDialog.OpenFile())
					Me.radTextBoxControl1.TextBoxElement.BackgroundImage = image
				End If
			End Using
		End Sub

		Private Sub radButtonSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim text As String = Me.radTextBoxControl1.Text

			If Not TelerikHelper.StringIsNullOrWhiteSpace(text) Then
				Dim query As String = String.Format("http://www.bing.com/search?q={0}", text)
				Process.Start(query)
			End If
		End Sub
	End Class
End Namespace
