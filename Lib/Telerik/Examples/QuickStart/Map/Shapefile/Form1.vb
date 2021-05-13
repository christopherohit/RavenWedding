Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map

Namespace Telerik.Examples.WinControls.Map.Shapefile
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private seatsFont As New Font("Arial", 7f, FontStyle.Bold)
		Private selectedSeats As New List(Of MapGeometry)()

		Public Sub New()
			InitializeComponent()

			Me.SetupProvider()
			Me.SetupLayer()
			Me.SetupData()
			Me.SetupColorizerAndLegend()

			AddHandler Me.radMap1.Click, AddressOf radMap1_Click
		End Sub

		Private Sub SetupProvider()
			Dim emptyProvider As New EmptyMapProvider()
			emptyProvider.MinZoomLevel = 16
			emptyProvider.MaxZoomLevel = 16
			AddHandler emptyProvider.InitializationComplete, AddressOf emptyProvider_InitializationComplete

			Me.radMap1.Providers.Add(emptyProvider)
		End Sub

		Private Sub SetupLayer()
			Dim pinsLayer As New MapLayer("Hall Layout")
			Me.radMap1.Layers.Add(pinsLayer)
		End Sub

		Private Sub SetupData()
			Using seatsStream As New MemoryStream(My.Resources.theatre_seats_pol)
			Using seatsDataStream As New MemoryStream(My.Resources.theatre_seats_pol_data)
			Using aisleStream As New MemoryStream(My.Resources.theatre_aisle_labels)
				Dim parameters As New ShapeFileReaderParameters()
				parameters.ShapeStream = seatsStream
				parameters.DbfStream = seatsDataStream
				Dim reader As New ShapeFileReader()
				Dim elements As List(Of MapVisualElement) = reader.Read(parameters)

				For Each element As MapGeometry In elements
					element.Font = Me.seatsFont
					element.ForeColor = Color.White
					element.Text = "$[CAPTION]"
					element.BackColor = Color.FromArgb(Convert.ToInt32(element.ExtendedData.GetValue("RGB0")), Convert.ToInt32(element.ExtendedData.GetValue("RGB1")), Convert.ToInt32(element.ExtendedData.GetValue("RGB2")))
					element.BorderWidth = 0
				Next element

				Me.radMap1.Layers("Hall Layout").AddRange(elements)

				parameters = New ShapeFileReaderParameters()
				parameters.ShapeStream = aisleStream
				elements = reader.Read(parameters)
				Me.radMap1.Layers("Hall Layout").AddRange(elements)
			End Using
			End Using
			End Using
		End Sub

		Private Sub SetupColorizerAndLegend()
			Dim colorizer As New PropertyColorizationStrategy()
			colorizer.Colors = New List(Of Color)() From {Color.FromArgb(96, 57, 19), Color.FromArgb(204, 0, 0), Color.FromArgb(255, 255, 255), Color.FromArgb(204, 204, 204)}

			colorizer.PropertyValues.Add(New PropertyColorizerItem(1.0, "Sold"))
			colorizer.PropertyValues.Add(New PropertyColorizerItem(2.0, "Reserved"))
			colorizer.PropertyValues.Add(New PropertyColorizerItem(-1, "Selected"))
			colorizer.PropertyValues.Add(New PropertyColorizerItem(3.0, "Not Available"))
			colorizer.ValueProvider = New MapGeometryPropertyValueProvider("STATUS")

			Me.radMap1.MapElement.Layers("Hall Layout").ColorizationStrategy = colorizer

			Me.radMap1.MapElement.LegendElement.LegendInfoProvider = colorizer
			CType(Me.radMap1.MapElement.LegendElement.ItemStackElement.Children(2), MapLegendItemElement).ColorElement.BorderWidth = 3
		End Sub

		Private Sub emptyProvider_InitializationComplete(ByVal sender As Object, ByVal e As EventArgs)
			Dim locations As New List(Of PointG)()

			For Each el As MapVisualElement In Me.radMap1.Layers("Hall Layout").Overlays
				locations.Add(el.Location)
			Next el

			Me.radMap1.BringIntoView(RectangleG.GetBoundingRectangle(locations))
			Me.radMap1.Pan(New SizeL(-200, -50))
			Me.radMap1.MapElement.EnableZooming = False
			Me.radMap1.MapElement.EnablePanning = False
		End Sub

		Private Sub radMap1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim args As MouseEventArgs = TryCast(e, MouseEventArgs)

			Dim location As New PointL(args.Location.X - Me.radMap1.MapElement.PanOffset.Width, args.Location.Y - Me.radMap1.MapElement.PanOffset.Height)

			Dim g As MapGeometry = TryCast(Me.radMap1.Layers("Hall Layout").HitTest(location), MapGeometry)

			If g IsNot Nothing Then
				If Me.selectedSeats.Contains(g) Then
					g.BorderWidth = 0
					Me.selectedSeats.Remove(g)
				Else
					Dim status As Double = CDbl(g.ExtendedData.GetValue("STATUS"))

					If status = 0.0 Then
						g.BorderWidth = 3
						g.BorderColor = Color.Black
						Me.selectedSeats.Add(g)
					End If
				End If
			End If
		End Sub

		Private Sub radButtonBuyNow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonBuyNow.Click
			Me.ShowBookingForm(False)
		End Sub

		Private Sub radButtonReserve_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonReserve.Click
			Me.ShowBookingForm(True)
		End Sub

		Private Sub ShowBookingForm(ByVal isReservation As Boolean)
			Dim totalPrice As Integer = 0

			For Each seat As MapGeometry In Me.selectedSeats
				totalPrice += Convert.ToInt32(seat.ExtendedData.GetValue("PRICE"))
			Next seat

			Dim bookingForm As New BookingForm()
			ThemeResolutionService.ApplyThemeToControlTree(bookingForm, Me.CurrentThemeName)

			If bookingForm.ShowForm("Chicago", Me.selectedSeats.Count, totalPrice, isReservation) = DialogResult.OK Then
				Me.radMap1.BeginUpdate()

				For Each geometry As MapGeometry In Me.selectedSeats
					geometry.ExtendedData.SetValue("STATUS",If(isReservation, 2.0, 1.0))
					geometry.BorderWidth = 0
				Next geometry

				Me.selectedSeats.Clear()
				Me.radMap1.EndUpdate()
			End If
		End Sub
	End Class
End Namespace
