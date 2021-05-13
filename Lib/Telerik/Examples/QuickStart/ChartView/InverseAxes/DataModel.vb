Namespace Telerik.Examples.WinControls.ChartView.InverseAxes
	Public Class DataModel
		Public Function GetRawData() As DataSet
			Dim result As New DataSet()

			Dim tableDryHoles As New DataTable("DryHoles")
			Dim tableNaturalGas As New DataTable("NaturalGas")
			Dim tableCrudeOil As New DataTable("CrudeOil")

			tableDryHoles.Columns.Add("Time", GetType(Date))
			tableDryHoles.Columns.Add("Depth", GetType(Double))

			tableNaturalGas.Columns.Add("Time", GetType(Date))
			tableNaturalGas.Columns.Add("Depth", GetType(Double))

			tableCrudeOil.Columns.Add("Time", GetType(Date))
			tableCrudeOil.Columns.Add("Depth", GetType(Double))

			For Each data As WellDrillData In Me.GetDryHolesDrillData()
				tableDryHoles.Rows.Add(data.Date, data.Depth)
			Next data

			For Each data As WellDrillData In Me.GetNaturalGasDrillData()
				tableNaturalGas.Rows.Add(data.Date, data.Depth)
			Next data

			For Each data As WellDrillData In Me.GetCrudeOilDrillData()
				tableCrudeOil.Rows.Add(data.Date, data.Depth)
			Next data

			result.Tables.Add(tableDryHoles)
			result.Tables.Add(tableNaturalGas)
			result.Tables.Add(tableCrudeOil)

			Return result
		End Function

		Public Function GetAggregatedData() As DataTable
			Dim result As New DataTable()

			result.Columns.Add("Name", GetType(String))
			result.Columns.Add("AverageDepth", GetType(Double))
			result.Columns.Add("MaximumDepth", GetType(Double))

			result.Rows.Add("Dry Holes", Average(Me.GetDryHolesDrillData()), Maximum(Me.GetDryHolesDrillData()))
			result.Rows.Add("Natural Gas", Average(Me.GetNaturalGasDrillData()), Maximum(Me.GetNaturalGasDrillData()))
			result.Rows.Add("Crude Oil", Average(Me.GetCrudeOilDrillData()), Maximum(Me.GetCrudeOilDrillData()))

			Return result
		End Function

		Private Function GetDryHolesDrillData() As List(Of WellDrillData)
			Return New List(Of WellDrillData)() From {
				New WellDrillData With {.Date = New Date(1949, 06, 30), .Depth = 3225.0},
				New WellDrillData With {.Date = New Date(1950, 06, 30), .Depth = 3077.0},
				New WellDrillData With {.Date = New Date(1951, 06, 30), .Depth = 3255.0},
				New WellDrillData With {.Date = New Date(1952, 06, 30), .Depth = 3520.0},
				New WellDrillData With {.Date = New Date(1953, 06, 30), .Depth = 3401.0},
				New WellDrillData With {.Date = New Date(1954, 06, 30), .Depth = 3512.0},
				New WellDrillData With {.Date = New Date(1955, 06, 30), .Depth = 3699.0},
				New WellDrillData With {.Date = New Date(1956, 06, 30), .Depth = 3574.0},
				New WellDrillData With {.Date = New Date(1957, 06, 30), .Depth = 3605.0},
				New WellDrillData With {.Date = New Date(1958, 06, 30), .Depth = 3631.0},
				New WellDrillData With {.Date = New Date(1959, 06, 30), .Depth = 3844.0},
				New WellDrillData With {.Date = New Date(1960, 06, 30), .Depth = 3889.0},
				New WellDrillData With {.Date = New Date(1961, 06, 30), .Depth = 3782.0},
				New WellDrillData With {.Date = New Date(1962, 06, 30), .Depth = 4239.0},
				New WellDrillData With {.Date = New Date(1963, 06, 30), .Depth = 4143.0},
				New WellDrillData With {.Date = New Date(1964, 06, 30), .Depth = 4207.0},
				New WellDrillData With {.Date = New Date(1965, 06, 30), .Depth = 4446.0},
				New WellDrillData With {.Date = New Date(1966, 06, 30), .Depth = 3900.0},
				New WellDrillData With {.Date = New Date(1967, 06, 30), .Depth = 3901.0},
				New WellDrillData With {.Date = New Date(1968, 06, 30), .Depth = 4311.0},
				New WellDrillData With {.Date = New Date(1969, 06, 30), .Depth = 4437.0},
				New WellDrillData With {.Date = New Date(1970, 06, 30), .Depth = 4714.0},
				New WellDrillData With {.Date = New Date(1971, 06, 30), .Depth = 4633.0},
				New WellDrillData With {.Date = New Date(1972, 06, 30), .Depth = 4725.0},
				New WellDrillData With {.Date = New Date(1973, 06, 30), .Depth = 4851.0},
				New WellDrillData With {.Date = New Date(1974, 06, 30), .Depth = 4599.0},
				New WellDrillData With {.Date = New Date(1975, 06, 30), .Depth = 4415.0},
				New WellDrillData With {.Date = New Date(1976, 06, 30), .Depth = 4439.0},
				New WellDrillData With {.Date = New Date(1977, 06, 30), .Depth = 4662.0},
				New WellDrillData With {.Date = New Date(1978, 06, 30), .Depth = 4600.0},
				New WellDrillData With {.Date = New Date(1979, 06, 30), .Depth = 4517.0},
				New WellDrillData With {.Date = New Date(1980, 06, 30), .Depth = 4214.0},
				New WellDrillData With {.Date = New Date(1981, 06, 30), .Depth = 4226.0},
				New WellDrillData With {.Date = New Date(1982, 06, 30), .Depth = 4184.0},
				New WellDrillData With {.Date = New Date(1983, 06, 30), .Depth = 3974.0},
				New WellDrillData With {.Date = New Date(1984, 06, 30), .Depth = 4205.0},
				New WellDrillData With {.Date = New Date(1985, 06, 30), .Depth = 4306.0},
				New WellDrillData With {.Date = New Date(1986, 06, 30), .Depth = 4236.0},
				New WellDrillData With {.Date = New Date(1987, 06, 30), .Depth = 4390.0},
				New WellDrillData With {.Date = New Date(1988, 06, 30), .Depth = 4704.0},
				New WellDrillData With {.Date = New Date(1989, 06, 30), .Depth = 4684.0},
				New WellDrillData With {.Date = New Date(1990, 06, 30), .Depth = 4755.0},
				New WellDrillData With {.Date = New Date(1991, 06, 30), .Depth = 4629.0},
				New WellDrillData With {.Date = New Date(1992, 06, 30), .Depth = 4733.0},
				New WellDrillData With {.Date = New Date(1993, 06, 30), .Depth = 4704.0},
				New WellDrillData With {.Date = New Date(1994, 06, 30), .Depth = 5125.0},
				New WellDrillData With {.Date = New Date(1995, 06, 30), .Depth = 5204.0},
				New WellDrillData With {.Date = New Date(1996, 06, 30), .Depth = 5371.0},
				New WellDrillData With {.Date = New Date(1997, 06, 30), .Depth = 5405.0},
				New WellDrillData With {.Date = New Date(1998, 06, 30), .Depth = 5607.0},
				New WellDrillData With {.Date = New Date(1999, 06, 30), .Depth = 5481.0},
				New WellDrillData With {.Date = New Date(2000, 06, 30), .Depth = 5326.0},
				New WellDrillData With {.Date = New Date(2001, 06, 30), .Depth = 5187.0},
				New WellDrillData With {.Date = New Date(2002, 06, 30), .Depth = 5096.0},
				New WellDrillData With {.Date = New Date(2003, 06, 30), .Depth = 5224.0},
				New WellDrillData With {.Date = New Date(2004, 06, 30), .Depth = 5311.0},
				New WellDrillData With {.Date = New Date(2005, 06, 30), .Depth = 4935.0},
				New WellDrillData With {.Date = New Date(2006, 06, 30), .Depth = 4987.0},
				New WellDrillData With {.Date = New Date(2007, 06, 30), .Depth = 5243.0},
				New WellDrillData With {.Date = New Date(2008, 06, 30), .Depth = 5220.0}}
		End Function

		Private Function GetNaturalGasDrillData() As List(Of WellDrillData)
			Return New List(Of WellDrillData)() From {
				New WellDrillData With {.Date = New Date(1949, 06, 30), .Depth = 5682.0},
				New WellDrillData With {.Date = New Date(1950, 06, 30), .Depth = 5466.0},
				New WellDrillData With {.Date = New Date(1951, 06, 30), .Depth = 5497.0},
				New WellDrillData With {.Date = New Date(1952, 06, 30), .Depth = 6071.0},
				New WellDrillData With {.Date = New Date(1953, 06, 30), .Depth = 5654.0},
				New WellDrillData With {.Date = New Date(1954, 06, 30), .Depth = 6059.0},
				New WellDrillData With {.Date = New Date(1955, 06, 30), .Depth = 5964.0},
				New WellDrillData With {.Date = New Date(1956, 06, 30), .Depth = 6301.0},
				New WellDrillData With {.Date = New Date(1957, 06, 30), .Depth = 6898.0},
				New WellDrillData With {.Date = New Date(1958, 06, 30), .Depth = 6657.0},
				New WellDrillData With {.Date = New Date(1959, 06, 30), .Depth = 6613.0},
				New WellDrillData With {.Date = New Date(1960, 06, 30), .Depth = 6298.0},
				New WellDrillData With {.Date = New Date(1961, 06, 30), .Depth = 6457.0},
				New WellDrillData With {.Date = New Date(1962, 06, 30), .Depth = 6728.0},
				New WellDrillData With {.Date = New Date(1963, 06, 30), .Depth = 6370.0},
				New WellDrillData With {.Date = New Date(1964, 06, 30), .Depth = 7547.0},
				New WellDrillData With {.Date = New Date(1965, 06, 30), .Depth = 7295.0},
				New WellDrillData With {.Date = New Date(1966, 06, 30), .Depth = 8321.0},
				New WellDrillData With {.Date = New Date(1967, 06, 30), .Depth = 7478.0},
				New WellDrillData With {.Date = New Date(1968, 06, 30), .Depth = 7697.0},
				New WellDrillData With {.Date = New Date(1969, 06, 30), .Depth = 8092.0},
				New WellDrillData With {.Date = New Date(1970, 06, 30), .Depth = 7695.0},
				New WellDrillData With {.Date = New Date(1971, 06, 30), .Depth = 7649.0},
				New WellDrillData With {.Date = New Date(1972, 06, 30), .Depth = 7400.0},
				New WellDrillData With {.Date = New Date(1973, 06, 30), .Depth = 6596.0},
				New WellDrillData With {.Date = New Date(1974, 06, 30), .Depth = 6456.0},
				New WellDrillData With {.Date = New Date(1975, 06, 30), .Depth = 6748.0},
				New WellDrillData With {.Date = New Date(1976, 06, 30), .Depth = 6777.0},
				New WellDrillData With {.Date = New Date(1977, 06, 30), .Depth = 6625.0},
				New WellDrillData With {.Date = New Date(1978, 06, 30), .Depth = 6662.0},
				New WellDrillData With {.Date = New Date(1979, 06, 30), .Depth = 6630.0},
				New WellDrillData With {.Date = New Date(1980, 06, 30), .Depth = 6604.0},
				New WellDrillData With {.Date = New Date(1981, 06, 30), .Depth = 6772.0},
				New WellDrillData With {.Date = New Date(1982, 06, 30), .Depth = 6921.0},
				New WellDrillData With {.Date = New Date(1983, 06, 30), .Depth = 6395.0},
				New WellDrillData With {.Date = New Date(1984, 06, 30), .Depth = 6502.0},
				New WellDrillData With {.Date = New Date(1985, 06, 30), .Depth = 6787.0},
				New WellDrillData With {.Date = New Date(1986, 06, 30), .Depth = 6777.0},
				New WellDrillData With {.Date = New Date(1987, 06, 30), .Depth = 6698.0},
				New WellDrillData With {.Date = New Date(1988, 06, 30), .Depth = 6683.0},
				New WellDrillData With {.Date = New Date(1989, 06, 30), .Depth = 6606.0},
				New WellDrillData With {.Date = New Date(1990, 06, 30), .Depth = 7100.0},
				New WellDrillData With {.Date = New Date(1991, 06, 30), .Depth = 7122.0},
				New WellDrillData With {.Date = New Date(1992, 06, 30), .Depth = 6907.0},
				New WellDrillData With {.Date = New Date(1993, 06, 30), .Depth = 6482.0},
				New WellDrillData With {.Date = New Date(1994, 06, 30), .Depth = 6564.0},
				New WellDrillData With {.Date = New Date(1995, 06, 30), .Depth = 6264.0},
				New WellDrillData With {.Date = New Date(1996, 06, 30), .Depth = 6773.0},
				New WellDrillData With {.Date = New Date(1997, 06, 30), .Depth = 7188.0},
				New WellDrillData With {.Date = New Date(1998, 06, 30), .Depth = 7230.0},
				New WellDrillData With {.Date = New Date(1999, 06, 30), .Depth = 7015.0},
				New WellDrillData With {.Date = New Date(2000, 06, 30), .Depth = 7347.0},
				New WellDrillData With {.Date = New Date(2001, 06, 30), .Depth = 6990.0},
				New WellDrillData With {.Date = New Date(2002, 06, 30), .Depth = 6796.0},
				New WellDrillData With {.Date = New Date(2003, 06, 30), .Depth = 6589.0},
				New WellDrillData With {.Date = New Date(2004, 06, 30), .Depth = 5948.0},
				New WellDrillData With {.Date = New Date(2005, 06, 30), .Depth = 5732.0},
				New WellDrillData With {.Date = New Date(2006, 06, 30), .Depth = 5770.0},
				New WellDrillData With {.Date = New Date(2007, 06, 30), .Depth = 5901.0},
				New WellDrillData With {.Date = New Date(2008, 06, 30), .Depth = 5899.0}}
		End Function

		Private Function GetCrudeOilDrillData() As List(Of WellDrillData)
			Return New List(Of WellDrillData)() From {
				New WellDrillData With {.Date = New Date(1949, 06, 30), .Depth = 3684.0},
				New WellDrillData With {.Date = New Date(1950, 06, 30), .Depth = 3861.0},
				New WellDrillData With {.Date = New Date(1951, 06, 30), .Depth = 4061.0},
				New WellDrillData With {.Date = New Date(1952, 06, 30), .Depth = 4167.0},
				New WellDrillData With {.Date = New Date(1953, 06, 30), .Depth = 3972.0},
				New WellDrillData With {.Date = New Date(1954, 06, 30), .Depth = 3974.0},
				New WellDrillData With {.Date = New Date(1955, 06, 30), .Depth = 3915.0},
				New WellDrillData With {.Date = New Date(1956, 06, 30), .Depth = 3865.0},
				New WellDrillData With {.Date = New Date(1957, 06, 30), .Depth = 3944.0},
				New WellDrillData With {.Date = New Date(1958, 06, 30), .Depth = 3831.0},
				New WellDrillData With {.Date = New Date(1959, 06, 30), .Depth = 3852.0},
				New WellDrillData With {.Date = New Date(1960, 06, 30), .Depth = 3809.0},
				New WellDrillData With {.Date = New Date(1961, 06, 30), .Depth = 3931.0},
				New WellDrillData With {.Date = New Date(1962, 06, 30), .Depth = 4008.0},
				New WellDrillData With {.Date = New Date(1963, 06, 30), .Depth = 4006.0},
				New WellDrillData With {.Date = New Date(1964, 06, 30), .Depth = 3947.0},
				New WellDrillData With {.Date = New Date(1965, 06, 30), .Depth = 3970.0},
				New WellDrillData With {.Date = New Date(1966, 06, 30), .Depth = 3884.0},
				New WellDrillData With {.Date = New Date(1967, 06, 30), .Depth = 3692.0},
				New WellDrillData With {.Date = New Date(1968, 06, 30), .Depth = 4027.0},
				New WellDrillData With {.Date = New Date(1969, 06, 30), .Depth = 4142.0},
				New WellDrillData With {.Date = New Date(1970, 06, 30), .Depth = 4269.0},
				New WellDrillData With {.Date = New Date(1971, 06, 30), .Depth = 4049.0},
				New WellDrillData With {.Date = New Date(1972, 06, 30), .Depth = 4231.0},
				New WellDrillData With {.Date = New Date(1973, 06, 30), .Depth = 4242.0},
				New WellDrillData With {.Date = New Date(1974, 06, 30), .Depth = 3675.0},
				New WellDrillData With {.Date = New Date(1975, 06, 30), .Depth = 3821.0},
				New WellDrillData With {.Date = New Date(1976, 06, 30), .Depth = 3756.0},
				New WellDrillData With {.Date = New Date(1977, 06, 30), .Depth = 3901.0},
				New WellDrillData With {.Date = New Date(1978, 06, 30), .Depth = 3883.0},
				New WellDrillData With {.Date = New Date(1979, 06, 30), .Depth = 3827.0},
				New WellDrillData With {.Date = New Date(1980, 06, 30), .Depth = 3691.0},
				New WellDrillData With {.Date = New Date(1981, 06, 30), .Depth = 3799.0},
				New WellDrillData With {.Date = New Date(1982, 06, 30), .Depth = 3681.0},
				New WellDrillData With {.Date = New Date(1983, 06, 30), .Depth = 3577.0},
				New WellDrillData With {.Date = New Date(1984, 06, 30), .Depth = 3695.0},
				New WellDrillData With {.Date = New Date(1985, 06, 30), .Depth = 3808.0},
				New WellDrillData With {.Date = New Date(1986, 06, 30), .Depth = 3875.0},
				New WellDrillData With {.Date = New Date(1987, 06, 30), .Depth = 3972.0},
				New WellDrillData With {.Date = New Date(1988, 06, 30), .Depth = 4171.0},
				New WellDrillData With {.Date = New Date(1989, 06, 30), .Depth = 4116.0},
				New WellDrillData With {.Date = New Date(1990, 06, 30), .Depth = 4326.0},
				New WellDrillData With {.Date = New Date(1991, 06, 30), .Depth = 4434.0},
				New WellDrillData With {.Date = New Date(1992, 06, 30), .Depth = 4877.0},
				New WellDrillData With {.Date = New Date(1993, 06, 30), .Depth = 4986.0},
				New WellDrillData With {.Date = New Date(1994, 06, 30), .Depth = 5278.0},
				New WellDrillData With {.Date = New Date(1995, 06, 30), .Depth = 4998.0},
				New WellDrillData With {.Date = New Date(1996, 06, 30), .Depth = 4735.0},
				New WellDrillData With {.Date = New Date(1997, 06, 30), .Depth = 4944.0},
				New WellDrillData With {.Date = New Date(1998, 06, 30), .Depth = 4941.0},
				New WellDrillData With {.Date = New Date(1999, 06, 30), .Depth = 4507.0},
				New WellDrillData With {.Date = New Date(2000, 06, 30), .Depth = 4493.0},
				New WellDrillData With {.Date = New Date(2001, 06, 30), .Depth = 4791.0},
				New WellDrillData With {.Date = New Date(2002, 06, 30), .Depth = 4496.0},
				New WellDrillData With {.Date = New Date(2003, 06, 30), .Depth = 4684.0},
				New WellDrillData With {.Date = New Date(2004, 06, 30), .Depth = 4675.0},
				New WellDrillData With {.Date = New Date(2005, 06, 30), .Depth = 4669.0},
				New WellDrillData With {.Date = New Date(2006, 06, 30), .Depth = 4706.0},
				New WellDrillData With {.Date = New Date(2007, 06, 30), .Depth = 4945.0},
				New WellDrillData With {.Date = New Date(2008, 06, 30), .Depth = 4938.0}}
		End Function

		Private Function Average(ByVal wellData As List(Of WellDrillData)) As Double
			Dim sum As Double = 0R

			For Each well As WellDrillData In wellData
				sum += well.Depth
			Next well

			Return (sum / wellData.Count)
		End Function

		Private Function Maximum(ByVal wellData As List(Of WellDrillData)) As Double
			Dim max As Double = Double.MinValue

			For Each well As WellDrillData In wellData
				If max < well.Depth Then
					max = well.Depth
				End If
			Next well

			Return max
		End Function
	End Class
End Namespace
