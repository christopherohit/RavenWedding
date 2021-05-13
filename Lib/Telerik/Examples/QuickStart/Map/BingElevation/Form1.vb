Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map
Imports Telerik.WinControls.UI.Map.Bing

Namespace Telerik.Examples.WinControls.Map.BingElevation
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupLayers()
			Me.SetupProviders()
			Me.SetupSettingsControls()
			Me.radMap1.InputBehavior = New ExampleMapInputBehavior()
		End Sub

		Private Sub SetupLayers()
			Dim pinsLayer As New MapLayer("Pins")
			Me.radMap1.Layers.Add(pinsLayer)

			Dim calloutsLayer As New MapLayer("Callouts")
			Me.radMap1.Layers.Add(calloutsLayer)
		End Sub

		Private Sub SetupProviders()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.UseSession = True
			bingProvider.BingKey = My.Resources.BingKey
			AddHandler bingProvider.InitializationComplete, Sub()
				Me.radMap1.BringIntoView(New RectangleG(65.256706493442579, 15.908203125, 19.890723023996898, 124.365234375))
				Dim request As New ElevationRequest()
				request.ElevationType = ElevationType.List
				request.Points = New List(Of PointG)() From {New PointG(57.390087, 51.447880), New PointG(48.710732, 80.891237), New PointG(29.331682, 81.594362)}

				Me.radMap1.Layers("Pins").Clear()
				Me.radMap1.Layers("Pins").AddRange(New MapPin(request.Points(0)), New MapPin(request.Points(1)), New MapPin(request.Points(2)))

				bingProvider.CalculateElevationAsync(request)
			End Sub

			Me.radMap1.MapElement.Providers.Add(bingProvider)

			AddHandler bingProvider.CalculateElevationCompleted, AddressOf bingProvider_CalculateElevationCompleted
			AddHandler bingProvider.CalculateElevationError, AddressOf bingProvider_CalculateElevationError
		End Sub

		Private Sub SetupSettingsControls()
			Me.radDropDownList1.Items.Add(New RadListDataItem(ElevationType.List.ToString(), ElevationType.List))
			Me.radDropDownList1.Items.Add(New RadListDataItem(ElevationType.Polyline.ToString(), ElevationType.Polyline))
			Me.radDropDownList1.Items.Add(New RadListDataItem(ElevationType.Bounds.ToString(), ElevationType.Bounds))
			Me.radDropDownList1.Items.Add(New RadListDataItem(ElevationType.SeaLevel.ToString(), ElevationType.SeaLevel))
			Me.radDropDownList1.SelectedIndex = 0

			AddHandler Me.radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim elevationType As ElevationType = CType(Me.radDropDownList1.Items(e.Position).Value, ElevationType)

			Select Case elevationType
				Case ElevationType.List, ElevationType.SeaLevel
					Me.radGroupBoxBoundsSettings.Visible = False
					Me.radGroupBoxPolylineSettings.Visible = False
				Case ElevationType.Polyline
					Me.radGroupBoxBoundsSettings.Visible = False
					Me.radGroupBoxPolylineSettings.Visible = True
				Case ElevationType.Bounds
					Me.radGroupBoxBoundsSettings.Visible = True
					Me.radGroupBoxPolylineSettings.Visible = False
				Case Else
			End Select
		End Sub

		Private Sub radButtonCalculateElevations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonCalculateElevations.Click
			Me.radMap1.Layers("Callouts").Clear()
			Dim elevationType As ElevationType = CType(Me.radDropDownList1.Items(Me.radDropDownList1.SelectedIndex).Value, ElevationType)

			Dim points As New List(Of PointG)()

			For Each pin As MapPin In Me.radMap1.Layers("Pins").Overlays
				points.Add(pin.Location)
			Next pin

			If points.Count = 0 Then
				RadMessageBox.ThemeName = Me.CurrentThemeName
				RadMessageBox.Show("You have to place at least one pin on the map to get elevation." & Environment.NewLine & "Double click on the map to place a pin")

				Return
			End If

            If elevationType = elevationType.Bounds Then
                If points.Count < 2 Then
                    RadMessageBox.ThemeName = Me.CurrentThemeName
                    RadMessageBox.Show("You have to place at least two pins in order to define a bounding rectangle." & Environment.NewLine & "Double click on the map to place a pin")

                    Return
                End If
            End If

			Dim request As New ElevationRequest()
			request.ElevationType = elevationType

			Select Case elevationType
				Case ElevationType.List
					request.Points = points
				Case ElevationType.Polyline
					request.Points = points
					request.Samples = CInt(Fix(Me.radSpinEditorSamples.Value))
				Case ElevationType.Bounds
					request.Bounds = RectangleG.GetBoundingRectangle(points)
					request.Rows = CInt(Fix(Me.radSpinEditorRows.Value))
					request.Columns = CInt(Fix(Me.radSpinEditorColumns.Value))
				Case ElevationType.SeaLevel
					request.Points = points
			End Select

			Dim elevationProvider As IMapElevationProvider = TryCast(Me.radMap1.Providers(0), IMapElevationProvider)
			elevationProvider.CalculateElevationAsync(request)
		End Sub

		Private Sub bingProvider_CalculateElevationCompleted(ByVal sender As Object, ByVal e As ElevationCompletedEventArgs)
			If e.Elevations Is Nothing AndAlso e.SeaLevels Is Nothing Then
				RadMessageBox.ThemeName = Me.CurrentThemeName
				RadMessageBox.Show("Could not retrieve elevation data." & Environment.NewLine & " Please, try again.")

				Return
			End If

			Dim elevationType As ElevationType = CType(Me.radDropDownList1.Items(Me.radDropDownList1.SelectedIndex).Value, ElevationType)

			Select Case elevationType
				Case ElevationType.List
					Me.HandleListElevationType(e.Elevations(0))
				Case ElevationType.Polyline
					Me.HandlePolylineElevationType(e.Elevations(0))
				Case ElevationType.Bounds
					Me.HandleBoundsElevationType(e.Elevations(0))
				Case ElevationType.SeaLevel
					Me.HandleSeaLevelElevationType(e.SeaLevels(0))
			End Select
		End Sub

		Private Sub HandleListElevationType(ByVal elevationData As ElevationData)
			For i As Integer = 0 To Me.radMap1.Layers("Pins").Overlays.Count - 1
				Dim pin As MapPin = TryCast(Me.radMap1.Layers("Pins").Overlays(i), MapPin)

				If pin IsNot Nothing Then
					Dim callout As New MapCallout(pin)
					callout.MaxWidth = 50
					callout.Text = elevationData.Elevations(i).ToString() & "m"
					Me.radMap1.Layers("Callouts").Add(callout)
				End If
			Next i
		End Sub

		Private Sub HandlePolylineElevationType(ByVal elevationData As ElevationData)
			Dim points As New List(Of PointG)()

			For i As Integer = 0 To Me.radMap1.Layers("Pins").Overlays.Count - 1
				Dim pin As MapPin = TryCast(Me.radMap1.Layers("Pins").Overlays(i), MapPin)

				If pin IsNot Nothing Then
					points.Add(pin.Location)
				End If
			Next i

			Me.radMap1.Layers("Pins").Clear()

			Dim polyline As New MapPolyline(points)
			Me.radMap1.Layers("Callouts").Add(polyline)

			Dim p As List(Of PointG) = Me.CalculateEquidistantPointsAlongPolyline(polyline, Me.radMap1.MapElement.ZoomLevel, elevationData.Elevations.Length)

			For i As Integer = 0 To p.Count - 1
				Dim point As New MapPoint(p(i))
				Me.radMap1.Layers("Callouts").Add(point)

				Dim callout As New MapCallout(point)
				callout.MaxWidth = 50
				callout.Text = elevationData.Elevations(i).ToString() & "m"
				Me.radMap1.Layers("Callouts").Add(callout)
			Next i
		End Sub

		Private Function CalculateEquidistantPointsAlongPolyline(ByVal polyline As MapPolyline, ByVal zoomLevel As Integer, ByVal numberOfPoints As Integer) As List(Of PointG)
			Dim points As New List(Of PointL)()

			For Each point As PointG In polyline.Points
				points.Add(MapTileSystemHelper.LatLongToPixelXY(point, zoomLevel))
			Next point

			Dim totalDistance As Integer = 0
			Dim distances As New List(Of Double)()

			For i As Integer = 0 To points.Count - 2
				totalDistance += CInt(Fix(Math.Sqrt(Math.Pow(points(i + 1).X - points(i).X, 2) + Math.Pow(points(i + 1).Y - points(i).Y, 2))))
				distances.Add(totalDistance)
			Next i

			Dim equidistantPoints As New List(Of PointL)()
			Dim [step] As Double = CDbl(totalDistance) / (numberOfPoints - 1)
			Dim currentDistance As Double = 0

			Do While currentDistance < totalDistance - 1
				Dim index As Integer = distances.BinarySearch(currentDistance)

				If index < 0 Then
					index = Not index
				End If

				Dim p1 As PointL = points(index)
				Dim p2 As PointL = points(index + 1)
				Dim distance As Double = If(index = 0, distances(index), distances(index) - distances(index - 1))
				Dim dt As Double = If(index = 0, currentDistance, currentDistance - distances(index - 1))

				Dim t As Double = CDbl(dt) / distance
				Dim x As Double = ((1R - t) * p1.X + t * p2.X)
				Dim y As Double = ((1R - t) * p1.Y + t * p2.Y)

				equidistantPoints.Add(New PointL(CLng(Fix(Math.Round(x, MidpointRounding.AwayFromZero))), CLng(Fix(Math.Round(y, MidpointRounding.AwayFromZero)))))
				currentDistance += [step]
			Loop

			equidistantPoints.Add(points(points.Count - 1))

			Dim result As New List(Of PointG)()

			For Each point As PointL In equidistantPoints
				result.Add(MapTileSystemHelper.PixelXYToLatLong(point, zoomLevel))
			Next point

			Return result
		End Function

		Private Sub HandleBoundsElevationType(ByVal elevationData As ElevationData)
			Dim points As New List(Of PointG)()

			For i As Integer = 0 To Me.radMap1.Layers("Pins").Overlays.Count - 1
				Dim pin As MapPin = TryCast(Me.radMap1.Layers("Pins").Overlays(i), MapPin)

				If pin IsNot Nothing Then
					points.Add(pin.Location)
				End If
			Next i

			Me.radMap1.Layers("Pins").Clear()

			Dim rect As RectangleG = RectangleG.GetBoundingRectangle(points)
			Dim p(,) As PointG = Me.CalculateEquidistantPointsInRectangle(rect, Me.radMap1.MapElement.ZoomLevel, CInt(Fix(Me.radSpinEditorRows.Value)), CInt(Fix(Me.radSpinEditorColumns.Value)))

			Dim rows As Integer = p.GetLength(0)
			Dim flatIndex As Integer = 0

			For i As Integer = p.GetLength(0) - 1 To 0 Step -1
				For j As Integer = 0 To p.GetLength(1) - 1
					Dim point As New MapPoint(p(i, j))
					Me.radMap1.Layers("Callouts").Add(point)

					Dim callout As New MapCallout(point)
					callout.MaxWidth = 50
					callout.Text = elevationData.Elevations(flatIndex).ToString() & "m"
					flatIndex += 1
					Me.radMap1.Layers("Callouts").Add(callout)
				Next j
			Next i
		End Sub

		Private Function CalculateEquidistantPointsInRectangle(ByVal rect As RectangleG, ByVal zoomLevel As Integer, ByVal rows As Integer, ByVal columns As Integer) As PointG(,)
			Dim topLeft As PointL = MapTileSystemHelper.LatLongToPixelXY(rect.North, rect.West, zoomLevel)
			Dim bottomRight As PointL = MapTileSystemHelper.LatLongToPixelXY(rect.South, rect.East, zoomLevel)
			Dim rectangle As New RectangleL(topLeft, New SizeL(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y))

			Dim result(rows - 1, columns - 1) As PointG
			Dim xStep As Double = CDbl(rectangle.Width) / (columns - 1)
			Dim yStep As Double = CDbl(rectangle.Height) / (rows - 1)

			For i As Integer = 0 To rows - 1
				For j As Integer = 0 To columns - 1
					Dim point As New PointL(CLng(Fix(Math.Round(rectangle.X + j * xStep, MidpointRounding.AwayFromZero))), CLng(Fix(Math.Round(rectangle.Y + i * yStep, MidpointRounding.AwayFromZero))))
					result(i, j) = MapTileSystemHelper.PixelXYToLatLong(point, zoomLevel)
				Next j
			Next i

			Return result
		End Function

		Private Sub HandleSeaLevelElevationType(ByVal seaLevelData As SeaLevelData)
			For i As Integer = 0 To Me.radMap1.Layers("Pins").Overlays.Count - 1
				Dim pin As MapPin = TryCast(Me.radMap1.Layers("Pins").Overlays(i), MapPin)

				If pin IsNot Nothing Then
					Dim callout As New MapCallout(pin)
					callout.MaxWidth = 35
					callout.Text = seaLevelData.Offsets(i).ToString() & "m"
					Me.radMap1.Layers("Callouts").Add(callout)
				End If
			Next i
		End Sub

		Private Sub bingProvider_CalculateElevationError(ByVal sender As Object, ByVal e As CalculateElevationErrorEventArgs)
			RadMessageBox.ThemeName = Me.CurrentThemeName
			RadMessageBox.Show(e.Error.Message)
		End Sub
	End Class
End Namespace
