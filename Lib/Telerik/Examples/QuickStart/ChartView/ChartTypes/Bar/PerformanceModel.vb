Imports System.ComponentModel
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
	Public Class PerformanceModel
		Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable q1 was renamed since Visual Basic does not allow class members with the same name:
		Private q1_Renamed As IEnumerable(Of PerformanceData)
'INSTANT VB NOTE: The variable q2 was renamed since Visual Basic does not allow class members with the same name:
		Private q2_Renamed As IEnumerable(Of PerformanceData)
'INSTANT VB NOTE: The variable q3 was renamed since Visual Basic does not allow class members with the same name:
		Private q3_Renamed As IEnumerable(Of PerformanceData)
'INSTANT VB NOTE: The variable q4 was renamed since Visual Basic does not allow class members with the same name:
		Private q4_Renamed As IEnumerable(Of PerformanceData)

'INSTANT VB NOTE: The variable barCombineMode was renamed since Visual Basic does not allow class members with the same name:
		Private barCombineMode_Renamed As ChartSeriesCombineMode = ChartSeriesCombineMode.Cluster
'INSTANT VB NOTE: The variable chartOrientation was renamed since Visual Basic does not allow class members with the same name:
		Private chartOrientation_Renamed As Orientation = Orientation.Vertical
'INSTANT VB NOTE: The variable isShowLabelsEnabled was renamed since Visual Basic does not allow class members with the same name:
		Private isShowLabelsEnabled_Renamed As Boolean = True
'INSTANT VB NOTE: The variable showLabels was renamed since Visual Basic does not allow class members with the same name:
		Private showLabels_Renamed As Boolean = False

'INSTANT VB NOTE: The variable gapLength was renamed since Visual Basic does not allow class members with the same name:
		Private gapLength_Renamed As Double = 0.2R
'INSTANT VB NOTE: The variable axisMaxValue was renamed since Visual Basic does not allow class members with the same name:
		Private axisMaxValue_Renamed As Double = 20000R
'INSTANT VB NOTE: The variable axisStep was renamed since Visual Basic does not allow class members with the same name:
		Private axisStep_Renamed As Double = 5000R
'INSTANT VB NOTE: The variable axisTitle was renamed since Visual Basic does not allow class members with the same name:
		Private axisTitle_Renamed As String = "PROFIT (USD)"
'INSTANT VB NOTE: The variable axisLabelFormat was renamed since Visual Basic does not allow class members with the same name:
		Private axisLabelFormat_Renamed As String = "N0"

		Public Sub New()
		End Sub

		Public ReadOnly Property Q1() As IEnumerable(Of PerformanceData)
			Get
				If Me.q1_Renamed Is Nothing Then
					Me.q1_Renamed = New List(Of PerformanceData) (New PerformanceData() {New PerformanceData("Jason Harley", "Q1, 2010", 17790), New PerformanceData("Adam White", "Q1, 2010", 12820), New PerformanceData("Barbara Smith", "Q1, 2010", 14350), New PerformanceData("Susan Jones", "Q1, 2010", 11150), New PerformanceData("Tom Marshall", "Q1, 2010", 11800)})
				End If

				Return Me.q1_Renamed
			End Get
		End Property

		Public ReadOnly Property Q2() As IEnumerable(Of PerformanceData)
			Get
				If Me.q2_Renamed Is Nothing Then
					Me.q2_Renamed = New List(Of PerformanceData)(New PerformanceData() {New PerformanceData("Jason Harley", "Q2, 2010", 15320), New PerformanceData("Adam White", "Q2, 2010", 14100), New PerformanceData("Barbara Smith", "Q2, 2010", 13000), New PerformanceData("Susan Jones", "Q2, 2010", 8850), New PerformanceData("Tom Marshall", "Q2, 2010", 10900)})
				End If

				Return Me.q2_Renamed
			End Get
		End Property

		Public ReadOnly Property Q3() As IEnumerable(Of PerformanceData)
			Get
				If Me.q3_Renamed Is Nothing Then
					Me.q3_Renamed = New List(Of PerformanceData)(New PerformanceData() {New PerformanceData("Jason Harley", "Q3, 2010", 13800), New PerformanceData("Adam White", "Q3, 2010", 12300), New PerformanceData("Barbara Smith", "Q3, 2010", 14900), New PerformanceData("Susan Jones", "Q3, 2010", 10100), New PerformanceData("Tom Marshall", "Q3, 2010", 8700)})
				End If

				Return Me.q3_Renamed
			End Get
		End Property

		Public ReadOnly Property Q4() As IEnumerable(Of PerformanceData)
			Get
				If Me.q4_Renamed Is Nothing Then
					Me.q4_Renamed = New List(Of PerformanceData)(New PerformanceData() {New PerformanceData("Jason Harley", "Q4, 2010", 15850), New PerformanceData("Adam White", "Q4, 2010", 11200), New PerformanceData("Barbara Smith", "Q4, 2010", 14000), New PerformanceData("Susan Jones", "Q4, 2010", 7500), New PerformanceData("Tom Marshall", "Q4, 2010", 10000)})
				End If

				Return Me.q4_Renamed
			End Get
		End Property

		Public Function GetData(ByVal index As Integer) As IEnumerable(Of PerformanceData)
			If index = 0 Then
				Return Me.Q1
			End If

			If index = 1 Then
				Return Me.Q2
			End If

			If index = 2 Then
				Return Me.Q3
			End If

			If index = 3 Then
				Return Me.Q4
			End If

			Return Nothing
		End Function

		Public Property BarCombineMode() As ChartSeriesCombineMode
			Get
				Return Me.barCombineMode_Renamed
			End Get
			Set(ByVal value As ChartSeriesCombineMode)
				If Me.barCombineMode_Renamed <> value Then
					Me.barCombineMode_Renamed = value
					Me.OnPropertyChanged("BarCombineMode")

					Me.UpdateLabelsConfiguration(Me.barCombineMode_Renamed)
					Me.UpdateAxisConfiguration(Me.barCombineMode_Renamed)
				End If
			End Set
		End Property

		Public Property ShowLabels() As Boolean
			Get
				Return Me.showLabels_Renamed
			End Get
			Set(ByVal value As Boolean)
				If Me.showLabels_Renamed <> value Then
					Me.showLabels_Renamed = value
					Me.OnPropertyChanged("ShowLabels")
				End If
			End Set
		End Property

		Public Property IsShowLabelsEnabled() As Boolean
			Get
				Return Me.isShowLabelsEnabled_Renamed
			End Get
			Set(ByVal value As Boolean)
				If Me.isShowLabelsEnabled_Renamed <> value Then
					Me.isShowLabelsEnabled_Renamed = value
					Me.OnPropertyChanged("IsShowLabelsEnabled")
				End If
			End Set
		End Property

		Public Property ChartOrientation() As Orientation
			Get
				Return Me.chartOrientation_Renamed
			End Get
			Set(ByVal value As Orientation)
				If Me.chartOrientation_Renamed <> value Then
					Me.chartOrientation_Renamed = value
					Me.OnPropertyChanged("ChartOrientation")
				End If
			End Set
		End Property

		Public Property GapLength() As Double
			Get
				Return Me.gapLength_Renamed
			End Get
			Set(ByVal value As Double)
				If Me.gapLength_Renamed <> value Then
					Me.gapLength_Renamed = value
					Me.OnPropertyChanged("GapLength")
				End If
			End Set
		End Property

		Public Property AxisMaxValue() As Double
			Get
				Return Me.axisMaxValue_Renamed
			End Get
			Set(ByVal value As Double)
				If Me.axisMaxValue_Renamed <> value Then
					Me.axisMaxValue_Renamed = value
					Me.OnPropertyChanged("AxisMaxValue")
				End If
			End Set
		End Property

		Public Property AxisStep() As Double
			Get
				Return Me.axisStep_Renamed
			End Get
			Set(ByVal value As Double)
				If Me.axisStep_Renamed <> value Then
					Me.axisStep_Renamed = value
					Me.OnPropertyChanged("AxisStep")
				End If
			End Set
		End Property

		Public Property AxisTitle() As String
			Get
				Return Me.axisTitle_Renamed
			End Get
			Set(ByVal value As String)
				If Me.axisTitle_Renamed <> value Then
					Me.axisTitle_Renamed = value
					Me.OnPropertyChanged("AxisTitle")
				End If
			End Set
		End Property

		Public Property AxisLabelFormat() As String
			Get
				Return Me.axisLabelFormat_Renamed
			End Get
			Set(ByVal value As String)
				If Me.axisLabelFormat_Renamed <> value Then
					Me.axisLabelFormat_Renamed = value
					Me.OnPropertyChanged("AxisLabelFormat")
				End If
			End Set
		End Property

		Private Sub UpdateLabelsConfiguration(ByVal mode As ChartSeriesCombineMode)
			Me.ShowLabels = False
			Me.IsShowLabelsEnabled = mode = ChartSeriesCombineMode.Cluster
		End Sub

		Private Sub UpdateAxisConfiguration(ByVal mode As ChartSeriesCombineMode)
			If mode = ChartSeriesCombineMode.Cluster Then
				Me.GapLength = 0.2R

				Me.AxisMaxValue = 20000R
				Me.AxisStep = 5000R

				Me.AxisTitle = "PROFIT (USD)"
				Me.AxisLabelFormat = "N0"
			ElseIf mode = ChartSeriesCombineMode.Stack Then
				Me.GapLength = 0.5R

				Me.AxisMaxValue = 70000R
				Me.AxisStep = 16500R

				Me.AxisTitle = "PROFIT (USD)"
				Me.AxisLabelFormat = "N0"
			ElseIf mode = ChartSeriesCombineMode.Stack100 Then
				Me.GapLength = 0.5R

				Me.AxisMaxValue = 1R
				Me.AxisStep = 0.25R

				Me.AxisTitle = "PROFIT (%)"
				Me.AxisLabelFormat = "P0"
			End If
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			If Me.PropertyChangedEvent IsNot Nothing Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class

End Namespace
