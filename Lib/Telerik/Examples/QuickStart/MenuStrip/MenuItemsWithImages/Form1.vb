Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MenuItemsWithImages
	Partial Public Class Form1
		Inherits ExamplesForm
		Private oldSize As Size = Size.Empty

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub menuHorizontalOrientationItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radMenuDemo.MenuElement.MinSize = oldSize
			Me.radMenuDemo.Orientation = Orientation.Horizontal
		End Sub

		Private Sub menuVerticalOrientationItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			oldSize = Me.radMenuDemo.Size
			Me.radMenuDemo.MenuElement.MinSize = Size.Empty
			Me.radMenuDemo.Orientation = Orientation.Vertical
		End Sub

		Private Sub itemHorizontalOrientationItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radMenuDemo.MenuElement.TextOrientation = Orientation.Horizontal
			Me.radMenuDemo.MenuElement.FlipText = False
		End Sub

		Private Sub itemVerticalOrientationItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radMenuDemo.MenuElement.TextOrientation = Orientation.Vertical
			Me.radMenuDemo.MenuElement.FlipText = True
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace