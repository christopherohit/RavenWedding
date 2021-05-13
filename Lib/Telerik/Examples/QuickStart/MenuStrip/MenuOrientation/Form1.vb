Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MenuOrientation
	Partial Public Class Form1
		Inherits ExamplesForm
		Private oldSize As Size = Size.Empty
		Private oldLocation As New Point(26, 27)

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radMenu1
			Me.WireEvents()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radButton1.ButtonElement.Margin = New Padding(2)
			Me.radButton2.ButtonElement.Margin = New Padding(2)
			Me.radButton2.Font = New Font("Segoe UI", 8)
			Me.radButton1.Font = Me.radButton2.Font
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radMenu1.MenuElement.Orientation = Orientation.Horizontal Then
				oldSize = Me.radMenu1.Size
				Me.radMenu1.MenuElement.MinSize = Size.Empty
				Me.radMenu1.Orientation = Orientation.Vertical
				Me.radMenu1.Location = New Point(3, CInt(150 * Me.radMenu1.RootElement.DpiScaleFactor.Width))
				Me.radButton1.ButtonElement.ImagePrimitiveAngleTransform = 90
			Else
				Me.radMenu1.Location = Me.oldLocation
				Me.radMenu1.MenuElement.MinSize = oldSize
				Me.radMenu1.Orientation = Orientation.Horizontal
				Me.radButton1.ButtonElement.ImagePrimitiveAngleTransform = 0
			End If
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radMenu1.MenuElement.TextOrientation = Orientation.Horizontal Then
				Me.radMenu1.MenuElement.TextOrientation = Orientation.Vertical
				Me.radButton2.ButtonElement.ImagePrimitiveAngleTransform = 90
			Else
				Me.radMenu1.MenuElement.TextOrientation = Orientation.Horizontal
				Me.radButton2.ButtonElement.ImagePrimitiveAngleTransform = 0
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton2.Click, AddressOf radButton2_Click
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace