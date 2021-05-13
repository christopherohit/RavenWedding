Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map
Imports Telerik.WinControls.UI.Map.Bing

Namespace Telerik.Examples.WinControls.Map.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SetupSettingsControls()
			Me.SetupProviders()
			Me.SetupLegend()
		End Sub

		Private Sub SetupProviders()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.Culture = System.Threading.Thread.CurrentThread.CurrentCulture
			bingProvider.ImagerySet = ImagerySet.Road
			bingProvider.UseSession = True
			bingProvider.BingKey = My.Resources.BingKey
			AddHandler bingProvider.InitializationComplete, Sub(sender As Object, e As EventArgs) Me.radMap1.BringIntoView(New PointG(49R, 10R), 5)

			Me.radMap1.MapElement.Providers.Add(bingProvider)
		End Sub

		Private Sub SetupLegend()
			Me.radMap1.MapElement.LegendElement.TitleElement.Text = "Legend"
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("10", Color.FromArgb(227, 242, 253)))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("100", Color.FromArgb(144, 202, 249)))
			Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(New MapLegendItemElement("1000", Color.FromArgb(66, 165, 245)))
		End Sub

		Private Sub radCheckBoxShowSearchBar_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowSearchBar.ToggleStateChanged
			Me.radMap1.ShowSearchBar = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxShowLegend_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowLegend.ToggleStateChanged
			Me.radMap1.ShowLegend = args.ToggleState = ToggleState.On

			Me.radGroupBoxLegendSettings.Enabled = Me.radMap1.ShowLegend
		End Sub

		Private Sub radCheckBoxShowNavigationBar_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowNavigationBar.ToggleStateChanged
			Me.radMap1.ShowNavigationBar = args.ToggleState = ToggleState.On

			Me.radGroupBoxNavigationBarSettings.Enabled = Me.radMap1.ShowNavigationBar
		End Sub

		Private Sub radCheckBoxShowScaleIndicator_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowScaleIndicator.ToggleStateChanged
			Me.radMap1.ShowScaleIndicator = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxShowMiniMap_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowMiniMap.ToggleStateChanged
			Me.radMap1.ShowMiniMap = args.ToggleState = ToggleState.On

			Me.radGroupBoxMinimapSettings.Enabled = Me.radMap1.ShowMiniMap
		End Sub

		Private Sub radRadioButtonVertical_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButtonVertical.ToggleStateChanged
			If args.ToggleState = ToggleState.On Then
				Me.radMap1.MapElement.LegendElement.Orientation = Orientation.Vertical
			Else
				Me.radMap1.MapElement.LegendElement.Orientation = Orientation.Horizontal
			End If
		End Sub

		Private Sub radDropDownListNavBarLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListNavBarLocation.SelectedIndexChanged
			Me.radMap1.MapElement.NavigationBarLocation = CType(Me.radDropDownListNavBarLocation.SelectedItem.Value, MapNavigationBarLocation)
		End Sub

		Private Sub radDropDownListMinimapMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListMinimapMode.SelectedIndexChanged
			Me.radMap1.MapElement.MiniMapElement.MiniMapMode = CType(Me.radDropDownListMinimapMode.SelectedItem.Value, MiniMapMode)
			Me.radSpinEditorZoomOffset.Enabled = Me.radMap1.MapElement.MiniMapElement.MiniMapMode = MiniMapMode.OffsetZoom
		End Sub

		Private Sub radSpinEditorZoomOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorZoomOffset.ValueChanged
			Me.radMap1.MapElement.MiniMapElement.ZoomOffset = CInt(Fix(Me.radSpinEditorZoomOffset.Value))
		End Sub

		Private Sub SetupSettingsControls()
			Me.radDropDownListNavBarLocation.Items.Add(New RadListDataItem("Top right", MapNavigationBarLocation.TopRight))
			Me.radDropDownListNavBarLocation.Items.Add(New RadListDataItem("Top left", MapNavigationBarLocation.TopLeft))
			Me.radDropDownListNavBarLocation.Items.Add(New RadListDataItem("Bottom left", MapNavigationBarLocation.BottomLeft))
			Me.radDropDownListNavBarLocation.Items.Add(New RadListDataItem("Bottom center", MapNavigationBarLocation.BottomCenter))
			Me.radDropDownListNavBarLocation.Items.Add(New RadListDataItem("Bottom right", MapNavigationBarLocation.BottomRight))

			Me.radDropDownListNavBarLocation.SelectedIndex = Me.radDropDownListNavBarLocation.Items.Count - 1

			Me.radDropDownListMinimapMode.Items.Add(New RadListDataItem("Whole world", MiniMapMode.WholeWorld))
			Me.radDropDownListMinimapMode.Items.Add(New RadListDataItem("Static zoom", MiniMapMode.StaticZoom))
			Me.radDropDownListMinimapMode.Items.Add(New RadListDataItem("Offset zoom", MiniMapMode.OffsetZoom))

			Me.radDropDownListMinimapMode.SelectedIndex = 0
		End Sub
	End Class
End Namespace
