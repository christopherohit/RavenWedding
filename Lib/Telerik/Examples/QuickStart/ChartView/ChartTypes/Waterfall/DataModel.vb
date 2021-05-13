Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Waterfall
	Public NotInheritable Class DataModel
		Private Sub New()
		End Sub
		Public Shared Function GetData() As DataTable
			Dim data As New DataTable("Europe")

			data.Columns.Add("Value", GetType(Decimal))
			data.Columns.Add("Category", GetType(String))
			data.Columns.Add("Summary", GetType(Boolean))
			data.Columns.Add("Total", GetType(Boolean))

			data.Rows.Add(40000, "Beginning" & vbLf & "Balance", False, False)
			data.Rows.Add(15000, "Jan", False, False)
			data.Rows.Add(14000, "Feb", False, False)
			data.Rows.Add(-5000, "Mar", False, False)
			data.Rows.Add(64000, "Q1", True, False)
			data.Rows.Add(-20000, "Apr", False, False)
			data.Rows.Add(-8000, "May", False, False)
			data.Rows.Add(10000, "Jun", False, False)
			data.Rows.Add(-18000, "Q2", True, False)
			data.Rows.Add(46000, "Ending" & vbLf & "Balance", False, True)

			Return data
		End Function
	End Class
End Namespace
