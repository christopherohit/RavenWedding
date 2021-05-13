Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bubble
	Public NotInheritable Class DataModel
		Private Sub New()
		End Sub
		Public Shared Function GetData() As DataSet
			Dim result As New DataSet()

			Dim tableEurope As New DataTable("Europe")
			Dim tableNorthAmerica As New DataTable("NorthAmerica")
			Dim tableMiddleEast As New DataTable("MiddleEast")

			tableEurope.Columns.Add("Country", GetType(String))
			tableEurope.Columns.Add("LifeExpectancy", GetType(Double))
			tableEurope.Columns.Add("FertilityRate", GetType(Double))
			tableEurope.Columns.Add("Population", GetType(Integer))

			tableNorthAmerica.Columns.Add("Country", GetType(String))
			tableNorthAmerica.Columns.Add("LifeExpectancy", GetType(Double))
			tableNorthAmerica.Columns.Add("FertilityRate", GetType(Double))
			tableNorthAmerica.Columns.Add("Population", GetType(Integer))

			tableMiddleEast.Columns.Add("Country", GetType(String))
			tableMiddleEast.Columns.Add("LifeExpectancy", GetType(Double))
			tableMiddleEast.Columns.Add("FertilityRate", GetType(Double))
			tableMiddleEast.Columns.Add("Population", GetType(Integer))

			tableEurope.Rows.Add("Russia", 68.6R, 1.54R, 141850000)
			tableEurope.Rows.Add("Danmark", 78.6R, 1.84R, 5523095)
			tableEurope.Rows.Add("Great Britain", 80.05R, 2.0R, 61801570)
			tableEurope.Rows.Add("Germany", 79.84R, 1.36R, 81902307)

			tableNorthAmerica.Rows.Add("USA", 78.09R, 2.05R, 307007000)
			tableNorthAmerica.Rows.Add("Canada", 80.66R, 1.67R, 33739900)

			tableMiddleEast.Rows.Add("Iraq", 68.09R, 4.77R, 31090763)
			tableMiddleEast.Rows.Add("Egypt", 72.73R, 2.78R, 79716203)
			tableMiddleEast.Rows.Add("Iran", 72.49R, 1.7R, 73137148)
			tableMiddleEast.Rows.Add("Israel", 81.55R, 2.96R, 7485600)

			result.Tables.Add(tableEurope)
			result.Tables.Add(tableNorthAmerica)
			result.Tables.Add(tableMiddleEast)

			Return result
		End Function
	End Class
End Namespace
