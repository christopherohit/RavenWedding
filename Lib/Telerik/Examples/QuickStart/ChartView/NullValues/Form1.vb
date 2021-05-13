Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.NullValues
	Friend Enum SeriesType
		Line
		Bar
		Spline
		Area
		SplineArea
	End Enum

	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private exampleData As ExampleData

		Private group As TileGroupElement
		Private winsTile As RadTileElement
		Private drawsTile As RadTileElement
		Private lossesTile As RadTileElement

		Private segoe21Font As New Font("Segoe UI", 21)

		Public Sub New()
			InitializeComponent()

			exampleData = New ExampleData()

			AddHandler radCheckBox1.CheckStateChanged, AddressOf radCheckBox1_CheckStateChanged

			radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			radDropDownList1.DataSource = System.Enum.GetValues(GetType(SeriesType))

			SetupRadPanorama()
			SetupRadListView()
			SetupButtons()
			SetupRadChartView()
		End Sub

		Private Sub SetupRadChartView()
			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True
			area.GridDesign.DrawVerticalStripes = False

			Dim axis1 As CategoricalAxis = TryCast(radChartView1.Axes(0), CategoricalAxis)
			axis1.LabelFitMode = AxisLabelFitMode.Rotate
			axis1.LabelRotationAngle = 315
			axis1.ClipLabels = False

			radChartView1.Axes(1).Title = "POINTS"
			Me.radChartView1.Area.View.Palette = KnownPalette.Metro
			Me.radChartView1.View.Margin = New Padding(5)
			AddHandler radChartView1.LabelFormatting, AddressOf radChartView1_LabelFormatting
		End Sub

		Private Sub SetupButtons()
			leftButton.ButtonElement.TextOrientation = Orientation.Vertical
			rightButton.ButtonElement.TextOrientation = Orientation.Vertical
			rightButton.ButtonElement.FlipText = True
		End Sub

		Private Sub SetupRadPanorama()
			radPanorama1.ShowGroups = True
			radPanorama1.PanelImage = Nothing
			radPanorama1.AllowDragDrop = False
			radPanorama1.PanoramaElement.BackColor = Color.White
			radPanorama1.PanoramaElement.Padding = New Padding(0, 32, 0, 0)
			radPanorama1.ScrollBarThickness = 15

			group = New TileGroupElement()
			group.CellSize = New Size(120, 120)
			group.Margin = Padding.Empty
			group.Font = segoe21Font
			group.ForeColor = Color.FromArgb(64, 64, 64)
			group.RowsCount = 2
			radPanorama1.Groups.Add(group)

			winsTile = New RadTileElement()
			winsTile.Font = segoe21Font
			winsTile.TextImageRelation = TextImageRelation.ImageBeforeText
			winsTile.ImageLayout = ImageLayout.Zoom
			winsTile.Image = Image.FromFile("..\\Resources\\SoccerTeamsLogos\\football_player.png")
			winsTile.ColSpan = 2
			winsTile.Row = 0
			winsTile.TextAlignment = ContentAlignment.BottomRight
			winsTile.ImageAlignment = ContentAlignment.MiddleLeft
			group.Items.Add(winsTile)

			drawsTile = New RadTileElement()
			drawsTile.Font = segoe21Font
			drawsTile.Row = 1
			drawsTile.TextAlignment = ContentAlignment.BottomRight
			group.Items.Add(drawsTile)

			lossesTile = New RadTileElement()
			lossesTile.Font = segoe21Font
			lossesTile.Row = 1
			lossesTile.Column = 1
			lossesTile.TextAlignment = ContentAlignment.BottomRight
			group.Items.Add(lossesTile)
		End Sub

		Private Sub SetupRadListView()
			AddHandler radListView1.ItemDataBound, AddressOf radListView1_ItemDataBound
			AddHandler radListView1.VisualItemFormatting, AddressOf radListView1_VisualItemFormatting
			AddHandler radListView1.SelectedItemChanged, AddressOf radListView1_SelectedItemChanged
			radListView1.ListViewElement.DrawBorder = False

			radListView1.ViewType = ListViewType.IconsView
			radListView1.ListViewElement.ViewElement.Orientation = Orientation.Horizontal
			radListView1.ItemSize = New Size(170, 170)
			radListView1.AllowEdit = False
			radListView1.ItemSpacing = 15
			radListView1.ListViewElement.ViewElement.HorizontalScrollState = ScrollState.AlwaysHide

			radListView1.DataSource = exampleData.AccumulatedData

			radListView1.SelectedItem = radListView1.Items(2)
		End Sub

		Private Sub UpdateView()
			If radListView1.SelectedItem IsNot Nothing AndAlso radDropDownList1.SelectedValue IsNot Nothing Then
				Dim seriesType As SeriesType = CType(System.Enum.Parse(GetType(SeriesType), radDropDownList1.SelectedValue.ToString()), SeriesType)
				Dim selectedTeam As FootballTeam = CType(radListView1.SelectedItem.DataBoundItem, FootballTeam)

				SetupChartForTeam(selectedTeam.Stats, seriesType)
				SetupPanoramaForTeam(selectedTeam)
			End If
		End Sub

		Private Sub SetupPanoramaForTeam(ByVal selectedTeam As FootballTeam)
			group.Text = selectedTeam.Name
			winsTile.Text = selectedTeam.TotalWins & Environment.NewLine & "wins"
			drawsTile.Text = selectedTeam.TotalDraws & Environment.NewLine & "draws"
			lossesTile.Text = selectedTeam.TotalLosses & Environment.NewLine & "losses"
		End Sub

		Private Sub SetupChartForTeam(ByVal selectedTeamStats As List(Of FootballTeamStats), ByVal seriesType As SeriesType)
			Me.radChartView1.Series.Clear()

			Select Case seriesType
				Case SeriesType.Bar
					Dim barSeries As New BarSeries()
					barSeries.DataSource = selectedTeamStats
					barSeries.ValueMember = "Points"
					barSeries.CategoryMember = "Season"
					barSeries.ShowLabels = radCheckBox1.Checked
					Me.radChartView1.Series.Add(barSeries)

				Case SeriesType.Line
					Dim lineSeries As New LineSeries()
					lineSeries.DataSource = selectedTeamStats
					lineSeries.ValueMember = "Points"
					lineSeries.CategoryMember = "Season"
					lineSeries.ShowLabels = radCheckBox1.Checked
					lineSeries.PointSize = New SizeF(7, 7)
					Me.radChartView1.Series.Add(lineSeries)

				Case SeriesType.Spline
					Dim splineSeries As New LineSeries()
					splineSeries.DataSource = selectedTeamStats
					splineSeries.ValueMember = "Points"
					splineSeries.CategoryMember = "Season"
					splineSeries.Spline = True
					splineSeries.ShowLabels = radCheckBox1.Checked
					splineSeries.PointSize = New SizeF(7, 7)
					Me.radChartView1.Series.Add(splineSeries)

				Case SeriesType.Area
					Dim areaSeries As New AreaSeries()
					areaSeries.DataSource = selectedTeamStats
					areaSeries.ValueMember = "Points"
					areaSeries.CategoryMember = "Season"
					areaSeries.ShowLabels = radCheckBox1.Checked
					Me.radChartView1.Series.Add(areaSeries)

				Case SeriesType.SplineArea
					Dim splineAreaSeries As New AreaSeries()
					splineAreaSeries.DataSource = selectedTeamStats
					splineAreaSeries.ValueMember = "Points"
					splineAreaSeries.CategoryMember = "Season"
					splineAreaSeries.Spline = True
					splineAreaSeries.ShowLabels = radCheckBox1.Checked
					Me.radChartView1.Series.Add(splineAreaSeries)

			End Select
		End Sub

		Private Sub radChartView1_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			e.LabelElement.BackColor = Color.Transparent
			e.LabelElement.BorderWidth = 0
		End Sub

		Private Sub radListView1_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
			e.VisualItem.DrawText = False
			e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter
		End Sub

		Private Sub radListView1_ItemDataBound(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
			e.Item.Image = Image.FromFile((TryCast(e.Item.DataBoundItem, FootballTeam)).LogoPath)
		End Sub

		Private Sub radListView1_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateView()
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			UpdateView()
		End Sub

		Private Sub leftButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles leftButton.Click
			If radListView1.SelectedIndex > 0 Then
				radListView1.ListViewElement.ViewElement.Scroller.ScrollToItem(radListView1.Items(radListView1.SelectedIndex))
				radListView1.SelectedIndex -= 1
			End If
		End Sub

		Private Sub rightButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rightButton.Click
			If radListView1.SelectedIndex < radListView1.Items.Count - 1 Then
				radListView1.ListViewElement.ViewElement.Scroller.ScrollToItem(radListView1.Items(radListView1.SelectedIndex))
				radListView1.SelectedIndex += 1
			End If
		End Sub

		Private Sub radCheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
			radChartView1.Series(0).ShowLabels = radCheckBox1.Checked
		End Sub
	End Class
End Namespace