Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map

Namespace Telerik.Examples.WinControls.Map.BingElevation
	Public Class ExampleMapInputBehavior
		Inherits MapInputBehavior
		Public Overrides Sub OnDoubleClick(ByVal e As EventArgs)
			Dim args As MouseEventArgs = TryCast(e, MouseEventArgs)

			Dim point As New PointL(args.X - Me.MapElement.PanOffset.Width, args.Y - Me.MapElement.PanOffset.Height)
			Dim location As PointG = MapTileSystemHelper.PixelXYToLatLong(point.X, point.Y, Me.MapElement.ZoomLevel)

            While location.Longitude > 180
                location.Longitude -= 360
            End While

			Dim pin As MapPin = TryCast(Me.MapElement.Layers("Pins").HitTest(location), MapPin)

			If pin IsNot Nothing Then
				Me.MapElement.Layers("Pins").Remove(pin)

				Return
			End If

			pin = New MapPin(location)
			Me.MapElement.Layers("Pins").Add(pin)
		End Sub
	End Class
End Namespace