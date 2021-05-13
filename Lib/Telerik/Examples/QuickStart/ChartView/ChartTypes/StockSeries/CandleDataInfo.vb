Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.StockSeries
	Public Class CandleDataInfo
		Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable date was renamed since Visual Basic does not allow class members with the same name:
		Private date_Renamed As Date
'INSTANT VB NOTE: The variable open was renamed since Visual Basic does not allow class members with the same name:
		Private open_Renamed As Double
'INSTANT VB NOTE: The variable high was renamed since Visual Basic does not allow class members with the same name:
		Private high_Renamed As Double
'INSTANT VB NOTE: The variable low was renamed since Visual Basic does not allow class members with the same name:
		Private low_Renamed As Double
'INSTANT VB NOTE: The variable close was renamed since Visual Basic does not allow class members with the same name:
		Private close_Renamed As Double

		Public Property [Date]() As Date
			Get
				Return Me.date_Renamed
			End Get
			Set(ByVal value As Date)
				Me.date_Renamed = value
				Me.OnPropertyChanged("Date")
			End Set
		End Property

		Public Property Open() As Double
			Get
				Return Me.open_Renamed
			End Get
			Set(ByVal value As Double)
				Me.open_Renamed = value
				Me.OnPropertyChanged("Open")
			End Set
		End Property

		Public Property High() As Double
			Get
				Return Me.high_Renamed
			End Get
			Set(ByVal value As Double)
				Me.high_Renamed = value
				Me.OnPropertyChanged("High")
			End Set
		End Property

		Public Property Low() As Double
			Get
				Return Me.low_Renamed
			End Get
			Set(ByVal value As Double)
				Me.low_Renamed = value
				Me.OnPropertyChanged("Low")
			End Set
		End Property

		Public Property Close() As Double
			Get
				Return Me.close_Renamed
			End Get
			Set(ByVal value As Double)
				Me.close_Renamed = value
				Me.OnPropertyChanged("Close")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

	End Class
End Namespace
