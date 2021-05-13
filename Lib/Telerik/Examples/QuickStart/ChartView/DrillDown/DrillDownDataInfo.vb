Imports System.Linq
Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.DrillDown
	Public Class DrillDownDataInfo
		Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not allow class members with the same name:
		Private value_Renamed As Double
'INSTANT VB NOTE: The variable date was renamed since Visual Basic does not allow class members with the same name:
		Private date_Renamed As Date

		Public Sub New(ByVal [date] As Date, ByVal value As Double)
			Me.date_Renamed = [date]
			Me.value_Renamed = value
		End Sub

		Public Property Value() As Double
			Get
				Return Me.value_Renamed
			End Get
			Set(ByVal value As Double)
				Me.value_Renamed = value
				Me.OnPropertyChanged("Value")
			End Set
		End Property

		Public Property [Date]() As Date
			Get
				Return Me.date_Renamed
			End Get
			Set(ByVal value As Date)
				Me.date_Renamed = value
				Me.OnPropertyChanged("Date")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Public Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace
