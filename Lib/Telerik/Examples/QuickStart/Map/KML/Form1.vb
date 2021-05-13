Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map

Namespace Telerik.Examples.WinControls.Map.KML
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupLayer()
			Me.SetupData()
			Me.SetupLegend()
			Me.SetupProvider()
		End Sub

		Private Sub SetupProvider()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.BingKey = My.Resources.BingKey
			bingProvider.UseSession = True
			AddHandler bingProvider.InitializationComplete, AddressOf BingProvider_InitializationComplete

			Me.radMap1.Providers.Add(bingProvider)
		End Sub

		Private Sub BingProvider_InitializationComplete(ByVal sender As Object, ByVal e As EventArgs)
			Dim locations As New List(Of PointG)()

			For Each el As MapVisualElement In Me.radMap1.Layers("Slopes").Overlays
				locations.Add(el.Location)
			Next el

			Me.radMap1.BringIntoView(RectangleG.GetBoundingRectangle(locations))
			Me.radMap1.Pan(New SizeL(-200, -50))
		End Sub

		Private Sub SetupLayer()
			Dim slopesLayer As New MapLayer("Slopes")
			Me.radMap1.Layers.Add(slopesLayer)
		End Sub

		Private Sub SetupData()
			Using fs As New FileStream("..\Resources\adelboden.kml", FileMode.Open, FileAccess.Read)
				Dim elements As List(Of MapVisualElement) = KmlReader.Read(fs)
				Me.radMap1.Layers("Slopes").AddRange(elements)
			End Using
		End Sub

		Private Sub SetupLegend()
			Me.radMap1.MapElement.LegendElement.TitleElement.Text = "LEGEND"

			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Lift", Color.Red))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Downhill Easy", Color.Lime))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Downhill Intermediate", Color.Blue))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Downhill Advanced", Color.Black))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Downhill Unrated", Color.Violet))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Walking path ", Color.Brown))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("River", Color.LightBlue))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("Bus route", Color.Yellow))
		End Sub
	End Class
End Namespace
