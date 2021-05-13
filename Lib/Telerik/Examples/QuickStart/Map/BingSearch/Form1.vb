Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map
Imports Telerik.WinControls.UI.Map.Bing

Namespace Telerik.Examples.WinControls.Map.BingSearch
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupProviders()
			Me.SetupLayer()
		End Sub

		Private Sub SetupProviders()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.Culture = System.Threading.Thread.CurrentThread.CurrentCulture
			bingProvider.UseSession = True
			bingProvider.BingKey = My.Resources.BingKey
			AddHandler bingProvider.InitializationComplete, Sub(sender As Object, e As EventArgs)
				Me.radMap1.Zoom(6)
				Me.radMap1.MapElement.SearchBarElement.Search("Los Angelis, USA")
			End Sub

			Me.radMap1.MapElement.Providers.Add(bingProvider)

			Me.radMap1.MapElement.SearchBarElement.SearchProvider = bingProvider
			AddHandler bingProvider.SearchCompleted, AddressOf BingProvider_SearchCompleted
			AddHandler bingProvider.SearchError, AddressOf BingProvider_SearchError
		End Sub

		Private Sub BingProvider_SearchCompleted(ByVal sender As Object, ByVal e As SearchCompletedEventArgs)
			Dim allPoints As New RectangleG(Double.MinValue, Double.MaxValue, Double.MaxValue, Double.MinValue)
			Me.radMap1.Layers("Pins").Clear()

			For Each location As Location In e.Locations
				Dim point As New PointG(location.Point.Coordinates(0), location.Point.Coordinates(1))
				Dim pin As New MapPin(point)
				pin.BackColor = Color.FromArgb(11, 195, 197)
				pin.ToolTipText = location.Address.FormattedAddress
				Me.radMap1.MapElement.Layers("Pins").Add(pin)

				Dim callout As New MapCallout(pin)
				callout.Text = location.Name
				Me.radMap1.MapElement.Layers("Pins").Add(callout)

				allPoints.North = Math.Max(allPoints.North, point.Latitude)
				allPoints.South = Math.Min(allPoints.South, point.Latitude)
				allPoints.West = Math.Min(allPoints.West, point.Longitude)
				allPoints.East = Math.Max(allPoints.East, point.Longitude)
			Next location

			If e.Locations.Length > 0 Then
				If e.Locations.Length = 1 Then
					Me.radMap1.BringIntoView(New PointG(e.Locations(0).Point.Coordinates(0), e.Locations(0).Point.Coordinates(1)))
				Else
					Me.radMap1.MapElement.BringIntoView(allPoints)
					Me.radMap1.Zoom(Me.radMap1.MapElement.ZoomLevel - 1)
				End If
			Else
				RadMessageBox.Show("No result found for the provided search query!")
			End If
		End Sub

		Private Sub BingProvider_SearchError(ByVal sender As Object, ByVal e As SearchErrorEventArgs)
			RadMessageBox.ThemeName = Me.CurrentThemeName
			RadMessageBox.Show(e.Error.Message)
		End Sub

		Private Sub SetupLayer()
			Dim pinsLayer As New MapLayer("Pins")
			Me.radMap1.Layers.Add(pinsLayer)
		End Sub
	End Class
End Namespace
