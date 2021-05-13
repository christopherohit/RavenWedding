Imports System.Text
Imports System.ComponentModel
Imports System.Globalization


Namespace Telerik.Examples.WinControls.ChartView.DrillDown
	Public Class DrillDownViewModel
		Implements INotifyPropertyChanged
'INSTANT VB NOTE: The variable data was renamed since Visual Basic does not allow class members with the same name:
		Private data_Renamed As BindingList(Of DrillDownDataInfo)

		Public Sub New()
			data_Renamed = ParseDataByYear()
		End Sub

		Public Property Data() As BindingList(Of DrillDownDataInfo)
			Get
				Return data_Renamed
			End Get
			Set(ByVal value As BindingList(Of DrillDownDataInfo))
				If Me.data_Renamed IsNot value Then
					Me.data_Renamed = value
					Me.OnPropertyChanged("Data")
				End If
			End Set
		End Property

		Friend Shared Function ParseDataByYear() As BindingList(Of DrillDownDataInfo)
			Dim chartData As New BindingList(Of DrillDownDataInfo)()
			Dim separator() As Char = { ControlChars.Cr, ControlChars.Lf }
			Dim fileContents As String = My.Resources.DJIA
			Dim lines() As String = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
			Dim count As Integer = 0
			For Each line As String In lines
				Dim tempVar As boolean = count > 10
				count += 1
				If tempVar Then '/top 10
					Exit For
				End If

				If String.IsNullOrEmpty(line) Then
					Continue For
				End If

				Dim data() As String = line.Split(","c)
				Dim dataItem As New DrillDownDataInfo(Date.Parse(data(0), CultureInfo.InvariantCulture), Double.Parse(data(1), CultureInfo.InvariantCulture))


				chartData.Add(dataItem)
			Next line

			Return chartData
		End Function

		Friend Shared Function ParseDataByMonth(ByVal year As Integer) As BindingList(Of DrillDownDataInfo)
			Dim chartData As New BindingList(Of DrillDownDataInfo)()
			Dim separator() As Char = { ControlChars.Cr, ControlChars.Lf }
			Dim fileContents As String = My.Resources.DJIAM
			Dim lines() As String = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
			For Each line As String In lines
				If String.IsNullOrEmpty(line) Then
					Continue For
				End If

				Dim data() As String = line.Split(","c)
				Dim [date] As Date = Date.Parse(data(0), CultureInfo.InvariantCulture)
				If [date].Year = year Then

					Dim dataItem As New DrillDownDataInfo([date], Double.Parse(data(1), CultureInfo.InvariantCulture))


					chartData.Add(dataItem)
				End If
			Next line

			Return chartData
		End Function

		Friend Shared Function ParseDataByDay(ByVal year As Integer, ByVal month As Integer) As BindingList(Of DrillDownDataInfo)
			Dim chartData As New BindingList(Of DrillDownDataInfo)()
			Dim separator() As Char = { ControlChars.Cr, ControlChars.Lf }
			Dim fileContents As String = My.Resources.DJIAD
			Dim lines() As String = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
			For Each line As String In lines
				If String.IsNullOrEmpty(line) Then
					Continue For
				End If

				Dim data() As String = line.Split(","c)
				Dim [date] As Date = Date.Parse(data(0), CultureInfo.InvariantCulture)
				If [date].Year = year AndAlso [date].Month = month AndAlso (Not String.IsNullOrEmpty(data(1))) Then

					Dim dataItem As New DrillDownDataInfo([date], Double.Parse(data(1), CultureInfo.InvariantCulture))


					chartData.Add(dataItem)
				End If
			Next line

			Return chartData
		End Function

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace
