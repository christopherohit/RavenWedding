Imports System.IO
Imports System.Resources
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map

Namespace Telerik.Examples.WinControls.Map.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupProviders()
			Me.SetupLayers()
			Me.SetupData()

			AddHandler Me.radMap1.MapElement.ViewportChanged, AddressOf MapElement_ViewportChanged
			AddHandler Me.radMap1.Click, AddressOf RadMap1_Click
			Me.radMap1.Zoom(2)
		End Sub

		Private Sub SetupProviders()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.BingKey = My.Resources.BingKey
			bingProvider.UseSession = True

			Me.radMap1.MapElement.Providers.Add(bingProvider)
		End Sub

		Private Sub SetupLayers()
			Dim pathLayer As New MapLayer("Path")
			Me.radMap1.Layers.Add(pathLayer)

			Dim pinsLayer As New MapLayer("Pins")
			Me.radMap1.Layers.Add(pinsLayer)

			Dim labelsLayer As New MapLayer("Labels")
			labelsLayer.IsVisible = False
			Me.radMap1.Layers.Add(labelsLayer)

			Dim calloutLayer As New MapLayer("Callout")
			Me.radMap1.Layers.Add(calloutLayer)
		End Sub

		Private Sub SetupData()
			Dim data As List(Of TripCity) = GetData()

			For i As Integer = 0 To data.Count - 2
				Me.radMap1.Layers("Path").Add(Me.CreateTripSegment(data(i).Location, data(i + 1).Location, data(i).IsFlight))
			Next i

			Me.radMap1.Layers("Path").Add(Me.CreateTripSegment(data(data.Count - 1).Location, New PointG(data(0).Location.Latitude, data(0).Location.Longitude + 360), data(data.Count - 1).IsFlight))

			Dim myManager As New ResourceManager(GetType(Form1))

			For i As Integer = 0 To data.Count - 1
				Dim pin As New MapPin(data(i).Location)
				pin.Tag = data(i)
				pin.ToolTipText = data(i).Name
				pin.BackColor = Color.FromArgb(11, 195, 197)
				Me.radMap1.Layers("Pins").Add(pin)

				Dim label As New MapLabel(data(i).Location, String.Format("{0}. {1}", data(i).TripStop, data(i).Name))
				label.BackColor = Color.FromArgb(180, 11, 195, 197)
				label.BorderColor = Color.White
				label.ForeColor = Color.White
				label.Image = CType(myManager.GetObject(If(data(i).IsFlight, "plane_16", "bus_16")), Image)
				Me.radMap1.Layers("Labels").Add(label)
			Next i
		End Sub

		Private Function GetData() As List(Of TripCity)
			Dim data As New List(Of TripCity)()
			data.Add(New TripCity("Seattle", New PointG(47.6149425, -122.4059451), 1, True))
			data.Add(New TripCity("New York", New PointG(40.7058254, -74.1180854), 2, True))
			data.Add(New TripCity("London", New PointG(51.5287718, -0.2416795), 3, False))
			data.Add(New TripCity("Paris", New PointG(48.8589507, 2.2775177), 4, False))
			data.Add(New TripCity("Berlin", New PointG(52.5076682, 13.286064), 5, True))
			data.Add(New TripCity("Sofia", New PointG(42.688606, 23.416172), 6, True))
			data.Add(New TripCity("Cairo", New PointG(30.0595581, 31.223445), 7, True))
			data.Add(New TripCity("Mumbai", New PointG(19.0830943, 72.741121), 8, False))
			data.Add(New TripCity("New Delhi", New PointG(28.5274228, 77.1389454), 9, True))
			data.Add(New TripCity("Bangkok", New PointG(13.7248945, 100.4930278), 10, False))
			data.Add(New TripCity("Hanoi", New PointG(21.0227358, 105.819454), 11, True))
			data.Add(New TripCity("Tokyo", New PointG(35.6734622, 139.6403485), 12, True))

			Return data
		End Function

		Private Function CreateTripSegment(ByVal start As PointG, ByVal [end] As PointG, ByVal isFlight As Boolean) As MapVisualElement
			If isFlight Then
				Dim airRoute As New MapAirRoute(start, [end])
				airRoute.BorderColor = Color.FromArgb(11, 195, 197)
				airRoute.BorderWidth = 3
				airRoute.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash
				airRoute.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

				Return airRoute
			End If

			Dim landRoute As New MapRoute(start, [end])
			landRoute.BorderColor = Color.FromArgb(11, 195, 197)
			landRoute.BorderWidth = 3
			landRoute.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

			Return landRoute
		End Function

		Private Sub MapElement_ViewportChanged(ByVal sender As Object, ByVal e As ViewportChangedEventArgs)
			If (e.Action And ViewportChangeAction.Zoom) <> 0 Then
				Me.radMap1.Layers("Pins").IsVisible = Me.radMap1.MapElement.ZoomLevel <= 3
				Me.radMap1.Layers("Callout").IsVisible = Me.radMap1.MapElement.ZoomLevel <= 3
				Me.radMap1.Layers("Labels").IsVisible = Me.radMap1.MapElement.ZoomLevel > 3
			End If
		End Sub

		Private Sub RadMap1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim args As MouseEventArgs = TryCast(e, MouseEventArgs)
			Me.radMap1.Layers("Callout").Clear()

			Dim point As New PointL(args.X - Me.radMap1.MapElement.PanOffset.Width, args.Y - Me.radMap1.MapElement.PanOffset.Height)
			Dim pin As MapPin = TryCast(Me.radMap1.Layers.HitTest(point), MapPin)

			If pin IsNot Nothing Then
				Dim tripCity As TripCity = TryCast(pin.Tag, TripCity)
				Dim callout As New MapCallout(pin)
				callout.ForeColor = Color.White
				callout.BackColor = Color.FromArgb(11, 195, 197)
				callout.BorderColor = Color.White
				Dim myManager As New ResourceManager(GetType(Form1))
				callout.Image = CType(myManager.GetObject(If(tripCity.IsFlight, "plane_16", "bus_16")), Image)
				callout.Text = String.Format("Trip stop: {0}" & vbLf & "City: {1}" & vbLf & "Next trip by {2}", tripCity.TripStop, tripCity.Name,If(tripCity.IsFlight, "Plane", "Train"))
				Me.radMap1.Layers("Callout").Add(callout)
			End If
		End Sub
	End Class
End Namespace
