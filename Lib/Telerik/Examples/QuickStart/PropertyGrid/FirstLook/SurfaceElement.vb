Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
	Public Class SurfaceElement
		Inherits LightVisualElement
'INSTANT VB NOTE: The variable currentObject was renamed since Visual Basic does not allow class members with the same name:
		Private currentObject_Renamed As SurfaceObject

		Public Event CurrentObjectChanged As EventHandler

		Public Property CurrentObject() As SurfaceObject
			Get
				Return currentObject_Renamed
			End Get
			Set(ByVal value As SurfaceObject)
				If currentObject_Renamed IsNot value Then
					currentObject_Renamed = value
					Me.Children.Remove(currentObject_Renamed)
					Me.Children.Add(currentObject_Renamed)
					RaiseEvent CurrentObjectChanged(Me, EventArgs.Empty)
				End If
			End Set
		End Property

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			For Each element As SurfaceObject In Me.Children
				element.Arrange(New RectangleF(element.Offset.X, element.Offset.Y, element.DesiredSize.Width, element.DesiredSize.Height))
			Next element
			Return finalSize
		End Function
	End Class
End Namespace
