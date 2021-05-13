Imports System.Text
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
	Public Class Surface
		Inherits RadControl
		Public Element As SurfaceElement

		Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
			MyBase.CreateChildItems(parent)
			Me.Element = New SurfaceElement()
			parent.Children.Add(Me.Element)
		End Sub
	End Class
End Namespace
