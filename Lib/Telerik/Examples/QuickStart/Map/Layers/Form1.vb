Imports System.IO
Imports System.Reflection
Imports System.Resources
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map
Imports Telerik.WinControls.UI.Map.Bing

Namespace Telerik.Examples.WinControls.Map.Layers
	Partial Public Class Form1
		Inherits ExamplesForm
		Private colors As New Dictionary(Of String, Color)()
		Private calloutFont As Font

		Public Sub New()
			InitializeComponent()

			Me.calloutFont = New Font(Me.radMap1.Font.FontFamily, 10.5f)

			Me.SetupProviders()
			Me.SetupLayers()
			Me.SetupData()
			Me.SetupLegend()
		End Sub

		Private Sub SetupProviders()
			Dim bingProvider As New BingRestMapProvider()
			bingProvider.ImagerySet = ImagerySet.Road
			bingProvider.UseSession = True
			bingProvider.BingKey = My.Resources.BingKey

			AddHandler bingProvider.InitializationComplete, Sub(sender As Object, e As EventArgs) Me.radMap1.BringIntoView(New PointG(40R, -99R), 4)

			Me.radMap1.MapElement.Providers.Add(bingProvider)
		End Sub

		Private Sub SetupLayers()
			Dim nflLayer As New MapLayer("NFL")
			Me.radMap1.Layers.Add(nflLayer)
			Dim nhlLayer As New MapLayer("NHL")
			Me.radMap1.Layers.Add(nhlLayer)
			Dim nbaLayer As New MapLayer("NBA")
			Me.radMap1.Layers.Add(nbaLayer)
			Dim mlbLayer As New MapLayer("MLB")
			Me.radMap1.Layers.Add(mlbLayer)
			Dim calloutLayer As New MapLayer("Callout")
			Me.radMap1.Layers.Add(calloutLayer)
		End Sub

		Private Sub SetupLegend()
			Me.radMap1.MapElement.LegendElement.TitleElement.Text = "Leagues"
			Me.radMap1.MapElement.LegendElement.SubtitleElement.Text = "Click to show or hide"
			Me.radMap1.MapElement.LegendElement.Orientation = Orientation.Horizontal

			For Each teamData As KeyValuePair(Of String, Color) In Me.colors
				Dim legendItem As New MapLegendItemElement(teamData.Key, teamData.Value)
				legendItem.TextElement.DrawText = False
				legendItem.ColorElement.BorderColor = teamData.Value
				legendItem.ColorElement.DrawFill = False
				legendItem.ColorElement.Image = CType(My.Resources.ResourceManager.GetObject(teamData.Key), Bitmap)
				Me.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(legendItem)
			Next teamData
		End Sub

		Private Sub SetupData()
			Me.colors.Add("NFL", Color.FromArgb(0, 160, 23))
			Me.colors.Add("NHL", Color.FromArgb(36, 30, 32))
			Me.colors.Add("NBA", Color.FromArgb(237, 23, 75))
			Me.colors.Add("MLB", Color.FromArgb(0, 69, 132))

			For Each teamInfo As SportTeamInfo In SportTeamsDataModel.GetNflData()
				Dim element As New MapPin(teamInfo.Location)
				element.Text = String.Format("{0} {1}", teamInfo.City, teamInfo.Name)
				element.BackColor = Me.colors("NFL")
				element.Tag = teamInfo
				Me.radMap1.Layers("NFL").Add(element)
			Next teamInfo

			For Each teamInfo As SportTeamInfo In SportTeamsDataModel.GetNhlData()
				Dim element As New MapPin(teamInfo.Location)
				element.Text = String.Format("{0} {1}", teamInfo.City, teamInfo.Name)
				element.BackColor = Me.colors("NHL")
				element.Tag = teamInfo
				Me.radMap1.Layers("NHL").Add(element)
			Next teamInfo

			For Each teamInfo As SportTeamInfo In SportTeamsDataModel.GetNbaData()
				Dim element As New MapPin(teamInfo.Location)
				element.Text = String.Format("{0} {1}", teamInfo.City, teamInfo.Name)
				element.BackColor = Me.colors("NBA")
				element.Tag = teamInfo
				Me.radMap1.Layers("NBA").Add(element)
			Next teamInfo

			For Each teamInfo As SportTeamInfo In SportTeamsDataModel.GetMlbData()
				Dim element As New MapPin(teamInfo.Location)
				element.Text = String.Format("{0} {1}", teamInfo.City, teamInfo.Name)
				element.BackColor = Me.colors("MLB")
				element.Tag = teamInfo
				Me.radMap1.Layers("MLB").Add(element)
			Next teamInfo
		End Sub

        Private Sub radMap1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMap1.Click
            Dim args As MouseEventArgs = TryCast(e, MouseEventArgs)
            Me.radMap1.Layers("Callout").Clear()

            Dim point As New PointL(args.X - Me.radMap1.MapElement.PanOffset.Width, args.Y - Me.radMap1.MapElement.PanOffset.Height)
            Dim pin As MapPin = TryCast(Me.radMap1.Layers.HitTest(point), MapPin)

            If pin IsNot Nothing Then
                Dim teamInfo As SportTeamInfo = TryCast(pin.Tag, SportTeamInfo)
                Dim callout As New MapCallout(pin)
                callout.Font = Me.calloutFont
                callout.ForeColor = Color.FromArgb(68, 68, 68)
                callout.Image = CType(My.Resources.ResourceManager.GetObject(pin.Layer.Name & teamInfo.Name.Replace(" ", "")), Bitmap)
                callout.Text = String.Format("{0} {1}" & vbLf & "{2}" & vbLf & "{3}", teamInfo.City, teamInfo.Name, teamInfo.Arena, pin.Layer.Name)
                Me.radMap1.Layers("Callout").Add(callout)

                Return
            End If

            Dim item As MapLegendItemElement = Me.radMap1.ElementTree.GetElementAtPoint(Of MapLegendItemElement)(args.Location)

            If item IsNot Nothing Then
                Me.radMap1.Layers(item.TextElement.Text).IsVisible = Me.radMap1.Layers(item.TextElement.Text).IsVisible Xor True
                item.Enabled = Me.radMap1.Layers(item.TextElement.Text).IsVisible
            End If
        End Sub
	End Class
End Namespace
