Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
	Public Class WeatherModel
		Implements INotifyPropertyChanged
		Public Sub New()
		End Sub

		Public Function GetTemperatureData() As IEnumerable(Of WeatherData)
			Return New List(Of WeatherData)() From {New WeatherData(New Date(2011, 1, 1), -14, 12), New WeatherData(New Date(2011, 2, 1), -9, 19), New WeatherData(New Date(2011, 3, 1), -7, 25), New WeatherData(New Date(2011, 4, 1), 2, 28), New WeatherData(New Date(2011, 5, 1), 8, 32), New WeatherData(New Date(2011, 6, 1), 13, 35), New WeatherData(New Date(2011, 7, 1), 17, 40), New WeatherData(New Date(2011, 8, 1), 15, 34), New WeatherData(New Date(2011, 9, 1), 11, 30), New WeatherData(New Date(2011, 10, 1), 1, 29), New WeatherData(New Date(2011, 11, 1), 2, 21), New WeatherData(New Date(2011, 12, 1), -1, 17), New WeatherData(New Date(2012, 1, 1), -11, 17), New WeatherData(New Date(2012, 2, 1), -7, 17), New WeatherData(New Date(2012, 3, 1), -4, 25), New WeatherData(New Date(2012, 4, 1), 3, 31), New WeatherData(New Date(2012, 5, 1), 9, 32), New WeatherData(New Date(2012, 6, 1), 11, 34), New WeatherData(New Date(2012, 7, 1), 16, 38), New WeatherData(New Date(2012, 8, 1), 16, 33), New WeatherData(New Date(2012, 9, 1), 12, 33), New WeatherData(New Date(2012, 10, 1), 3, 26), New WeatherData(New Date(2012, 11, 1), -1, 19), New WeatherData(New Date(2012, 12, 1), -2, 17)}
		End Function

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class

End Namespace
