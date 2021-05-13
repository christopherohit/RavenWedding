Imports System.ComponentModel
Imports System.Globalization
Imports System.IO

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
	Friend Class ViewModel
		Private dataSet As DataSet

		Public Sub New()
			dataSet = New DataSet()
			dataSet.Tables.Add("public")
			dataSet.Tables.Add("private")

			For Each table As DataTable In Me.dataSet.Tables
				table.Columns.Add("Age", GetType(Integer))
				table.Columns.Add("Wage", GetType(Double))
			Next table

			Me.GetData("..\ChartView\ChartTypes\Scatter\EarningsPublicvsPrivateByAge.csv")
		End Sub

		Public Function GetData() As DataSet
			Return Me.dataSet
		End Function

		Private Sub GetData(ByVal fileName As String)
			Using fileReader As New StreamReader(fileName)
				Me.GetDataCompleted(Me.ParseData(fileReader))
			End Using
		End Sub

		Protected Sub GetDataCompleted(ByVal data As IEnumerable(Of HourlyEarnings))
			For Each entry As HourlyEarnings In data
				Me.dataSet.Tables(entry.Sector).Rows.Add(entry.Age, entry.Wage)
			Next entry
		End Sub

		Protected Function ParseData(ByVal dataReader As TextReader) As IEnumerable(Of HourlyEarnings)
			Dim chartData As New List(Of HourlyEarnings)()
			Dim line As String

			line = dataReader.ReadLine()
			Do While line IsNot Nothing
				If String.IsNullOrEmpty(line) Then
					line = dataReader.ReadLine()
					Continue Do
				End If

				Dim data() As String = line.Split(","c)
				Dim age As Integer = Integer.Parse(data(0), CultureInfo.InvariantCulture)
				Dim wage As Double = Double.Parse(data(1), CultureInfo.InvariantCulture)
				Dim sector As String = data(2)

				Dim hourlyEarningsData As New HourlyEarnings(sector, wage, age)
				chartData.Add(hourlyEarningsData)
				line = dataReader.ReadLine()
			Loop

			Return chartData
		End Function
	End Class
End Namespace
