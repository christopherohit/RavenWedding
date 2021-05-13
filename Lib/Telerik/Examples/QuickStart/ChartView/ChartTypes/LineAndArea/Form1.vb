Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.LineAndArea
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private collection1 As List(Of SalesRevenue), collection2 As List(Of SalesRevenue)
		Private lineCombineModes, areaCombineModes As BindingSource
		Private chartTypes As List(Of String)
		Private selectedChartType As String
		Private selectedCombineMode As ChartSeriesCombineMode
		Private showLabels As Boolean

		Public Sub New()
			InitializeComponent()

			InitializeData()

			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			CType(Me.radChartView1.View.Area, CartesianArea).ShowGrid = True

			Me.radDropDownList1.DataSource = chartTypes
			Me.radDropDownList2.DataSource = lineCombineModes

			Dim i As Integer = 1
			For Each dpe As DataPointElement In Me.radChartView1.Series(0).Children
				dpe.IsVisible = False
				Dim setting As New AnimatedPropertySetting()
				setting.StartValue = False
				setting.EndValue = True
				setting.Property = UIChartElement.IsVisibleProperty
				setting.ApplyDelay = 40 + 40* i
				setting.NumFrames = 2
				setting.ApplyValue(dpe)
				i += 1
			Next dpe

			i = 1
			For Each dpe As DataPointElement In Me.radChartView1.Series(1).Children
				dpe.IsVisible = False
				Dim setting As New AnimatedPropertySetting()
				setting.StartValue = False
				setting.EndValue = True
				setting.Property = UIChartElement.IsVisibleProperty
				setting.ApplyDelay = 60 + 60 * i
				setting.NumFrames = 2
				setting.ApplyValue(dpe)
				i += 1
			Next dpe

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalStripes = True
			grid.DrawVerticalStripes = True
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.radDropDownList1.SelectedItem IsNot Nothing Then
				selectedChartType = Me.radDropDownList1.SelectedItem.Text

				Me.radChartView1.Series.Clear()
				Me.radChartView1.Axes.Clear()

				UpdateCombineModesDropDown()
				GenerateSeries(selectedChartType)
			End If
		End Sub

		Private Sub radDropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.radDropDownList2.SelectedValue IsNot Nothing Then
				selectedCombineMode = CType(Me.radDropDownList2.SelectedValue, ChartSeriesCombineMode)
				UpdateSeriesCombineMode(selectedCombineMode)
			End If
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			showLabels = If(args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, True, False)
			UpdateLabelsVisibility()
		End Sub

		Private Sub GenerateSeries(ByVal seriesType As String)
			Dim horizontalAxis As New CategoricalAxis()
			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second

			For i As Integer = 0 To 1
				Dim series As CartesianSeries = Nothing

				If seriesType = "Area" Then
					series = New AreaSeries()
				ElseIf seriesType = "Line" Then
					series = New LineSeries()
				ElseIf seriesType = "Stepline" Then
					series = New SteplineSeries()
				End If

				series.PointSize = New SizeF(5, 5)
				series.HorizontalAxis = horizontalAxis
				series.VerticalAxis = verticalAxis
				series.BorderWidth = 2
				series.CategoryMember = "Month"
				series.ValueMember = "Revenue"
				series.DataSource = If(i = 0, collection1, collection2)
				series.ShowLabels = showLabels
				series.CombineMode = selectedCombineMode

				Me.radChartView1.Series.Add(series)
			Next i
		End Sub

		Private Sub UpdateCombineModesDropDown()
			If selectedChartType = "Area" Then
				Me.radDropDownList2.DataSource = areaCombineModes
			ElseIf selectedChartType = "Line" Then
				Me.radDropDownList2.DataSource = lineCombineModes
			ElseIf selectedChartType = "Stepline" Then
				Me.radDropDownList2.DataSource = lineCombineModes
			End If
		End Sub

		Private Sub UpdateSeriesCombineMode(ByVal combineMode As ChartSeriesCombineMode)
			For Each series As CartesianSeries In Me.radChartView1.Series
				series.CombineMode = combineMode
			Next series
		End Sub

		Private Sub UpdateLabelsVisibility()
			For Each series As CartesianSeries In Me.radChartView1.Series
				series.ShowLabels = showLabels
			Next series
		End Sub

		Private Sub InitializeData()
			Me.collection1 = New List(Of SalesRevenue)()
			Me.collection1.Add(New SalesRevenue("January", 3.5))
			Me.collection1.Add(New SalesRevenue("February", 2.8))
			Me.collection1.Add(New SalesRevenue("March", 3.4))
			Me.collection1.Add(New SalesRevenue("April", 3.2))
			Me.collection1.Add(New SalesRevenue("May", 3.4))
			Me.collection1.Add(New SalesRevenue("June", 3.7))
			Me.collection1.Add(New SalesRevenue("July", 3.1))
			Me.collection1.Add(New SalesRevenue("August", 2.9))
			Me.collection1.Add(New SalesRevenue("September", 3.3))
			Me.collection1.Add(New SalesRevenue("October", 3.1))
			Me.collection1.Add(New SalesRevenue("November", 3.6))
			Me.collection1.Add(New SalesRevenue("December", 3.7))

			Me.collection2 = New List(Of SalesRevenue)()
			Me.collection2.Add(New SalesRevenue("January", 1.5))
			Me.collection2.Add(New SalesRevenue("February", 1.7))
			Me.collection2.Add(New SalesRevenue("March", 1.4))
			Me.collection2.Add(New SalesRevenue("April", 1.6))
			Me.collection2.Add(New SalesRevenue("May", 1.8))
			Me.collection2.Add(New SalesRevenue("June", 1.5))
			Me.collection2.Add(New SalesRevenue("July", 1.5))
			Me.collection2.Add(New SalesRevenue("August", 1.7))
			Me.collection2.Add(New SalesRevenue("September", 2.1))
			Me.collection2.Add(New SalesRevenue("October", 1.6))
			Me.collection2.Add(New SalesRevenue("November", 2))
			Me.collection2.Add(New SalesRevenue("December", 1.6))

			lineCombineModes = New BindingSource()
			lineCombineModes.Add(ChartSeriesCombineMode.None)
			lineCombineModes.Add(ChartSeriesCombineMode.Stack)

			areaCombineModes = New BindingSource()
			areaCombineModes.Add(ChartSeriesCombineMode.Stack)
			areaCombineModes.Add(ChartSeriesCombineMode.Stack100)

			chartTypes = New List(Of String)()
			chartTypes.Add("Line")
			chartTypes.Add("Stepline")
			chartTypes.Add("Area")

			showLabels = True
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radDropDownList2.SelectedIndexChanged, AddressOf radDropDownList2_SelectedIndexChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
		End Sub
	End Class
End Namespace

