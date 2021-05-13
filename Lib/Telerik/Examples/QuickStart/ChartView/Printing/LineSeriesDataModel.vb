Namespace Telerik.Examples.WinControls.ChartView.Printing
	Public Class LineSeriesDataModel
'INSTANT VB NOTE: The variable s1 was renamed since Visual Basic does not allow class members with the same name:
		Private s1_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s2 was renamed since Visual Basic does not allow class members with the same name:
		Private s2_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s3 was renamed since Visual Basic does not allow class members with the same name:
		Private s3_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s4 was renamed since Visual Basic does not allow class members with the same name:
		Private s4_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s5 was renamed since Visual Basic does not allow class members with the same name:
		Private s5_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s6 was renamed since Visual Basic does not allow class members with the same name:
		Private s6_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s7 was renamed since Visual Basic does not allow class members with the same name:
		Private s7_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s8 was renamed since Visual Basic does not allow class members with the same name:
		Private s8_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s9 was renamed since Visual Basic does not allow class members with the same name:
		Private s9_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s10 was renamed since Visual Basic does not allow class members with the same name:
		Private s10_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s11 was renamed since Visual Basic does not allow class members with the same name:
		Private s11_Renamed As IEnumerable(Of LineAreaSeriesData)
'INSTANT VB NOTE: The variable s12 was renamed since Visual Basic does not allow class members with the same name:
		Private s12_Renamed As IEnumerable(Of LineAreaSeriesData)

		Public ReadOnly Property S1() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s1_Renamed Is Nothing Then
					Me.s1_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(30, "May"), New LineAreaSeriesData(20, "Jun"), New LineAreaSeriesData(60, "Jul"), New LineAreaSeriesData(110, "Aug"), New LineAreaSeriesData(150, "Sep"), New LineAreaSeriesData(200, "Oct"), New LineAreaSeriesData(160, "Nov"), New LineAreaSeriesData(150, "Dec"), New LineAreaSeriesData(100, "Jan")}
				End If

				Return Me.s1_Renamed
			End Get
		End Property

		Public ReadOnly Property S2() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s2_Renamed Is Nothing Then
					Me.s2_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(70, "May"), New LineAreaSeriesData(60, "Jun"), New LineAreaSeriesData(100, "Jul"), New LineAreaSeriesData(50, "Aug"), New LineAreaSeriesData(60, "Sep"), New LineAreaSeriesData(80, "Oct"), New LineAreaSeriesData(100, "Nov"), New LineAreaSeriesData(80, "Dec"), New LineAreaSeriesData(50, "Jan")}
				End If

				Return Me.s2_Renamed
			End Get
		End Property

		Public ReadOnly Property S3() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s3_Renamed Is Nothing Then
					Me.s3_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(150, "May"), New LineAreaSeriesData(170, "Jun"), New LineAreaSeriesData(160, "Jul"), New LineAreaSeriesData(110, "Aug"), New LineAreaSeriesData(200, "Sep"), New LineAreaSeriesData(130, "Oct"), New LineAreaSeriesData(210, "Nov"), New LineAreaSeriesData(210, "Dec"), New LineAreaSeriesData(210, "Jan")}
				End If

				Return Me.s3_Renamed
			End Get
		End Property

		Public ReadOnly Property S4() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s4_Renamed Is Nothing Then
					Me.s4_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(190, "May"), New LineAreaSeriesData(210, "Jun"), New LineAreaSeriesData(200, "Jul"), New LineAreaSeriesData(230, "Aug"), New LineAreaSeriesData(230, "Sep"), New LineAreaSeriesData(300, "Oct"), New LineAreaSeriesData(290, "Nov"), New LineAreaSeriesData(280, "Dec"), New LineAreaSeriesData(270, "Jan")}
				End If

				Return Me.s4_Renamed
			End Get
		End Property

		Public ReadOnly Property S5() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s5_Renamed Is Nothing Then
					Me.s5_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(280, "May"), New LineAreaSeriesData(260, "Jun"), New LineAreaSeriesData(270, "Jul"), New LineAreaSeriesData(310, "Aug"), New LineAreaSeriesData(270, "Sep"), New LineAreaSeriesData(260, "Oct"), New LineAreaSeriesData(230, "Nov"), New LineAreaSeriesData(250, "Dec"), New LineAreaSeriesData(260, "Jan")}
				End If

				Return Me.s5_Renamed
			End Get
		End Property

		Public ReadOnly Property S6() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s6_Renamed Is Nothing Then
					Me.s6_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(330, "May"), New LineAreaSeriesData(320, "Jun"), New LineAreaSeriesData(380, "Jul"), New LineAreaSeriesData(330, "Aug"), New LineAreaSeriesData(330, "Sep"), New LineAreaSeriesData(330, "Oct"), New LineAreaSeriesData(350, "Nov"), New LineAreaSeriesData(340, "Dec"), New LineAreaSeriesData(380, "Jan")}
				End If

				Return Me.s6_Renamed
			End Get
		End Property

		Public ReadOnly Property S7() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s7_Renamed Is Nothing Then
					Me.s7_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(420, "May"), New LineAreaSeriesData(410, "Jun"), New LineAreaSeriesData(420, "Jul"), New LineAreaSeriesData(500, "Aug"), New LineAreaSeriesData(450, "Sep"), New LineAreaSeriesData(440, "Oct"), New LineAreaSeriesData(380, "Nov"), New LineAreaSeriesData(420, "Dec"), New LineAreaSeriesData(450, "Jan")}
				End If

				Return Me.s7_Renamed
			End Get
		End Property

		Public ReadOnly Property S8() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s8_Renamed Is Nothing Then
					Me.s8_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(370, "May"), New LineAreaSeriesData(360, "Jun"), New LineAreaSeriesData(350, "Jul"), New LineAreaSeriesData(370, "Aug"), New LineAreaSeriesData(380, "Sep"), New LineAreaSeriesData(340, "Oct"), New LineAreaSeriesData(320, "Nov"), New LineAreaSeriesData(310, "Dec"), New LineAreaSeriesData(310, "Jan")}
				End If

				Return Me.s8_Renamed
			End Get
		End Property

		Public ReadOnly Property S9() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s9_Renamed Is Nothing Then
					Me.s9_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(240, "May"), New LineAreaSeriesData(220, "Jun"), New LineAreaSeriesData(260, "Jul"), New LineAreaSeriesData(280, "Aug"), New LineAreaSeriesData(220, "Sep"), New LineAreaSeriesData(230, "Oct"), New LineAreaSeriesData(250, "Nov"), New LineAreaSeriesData(210, "Dec"), New LineAreaSeriesData(250, "Jan")}
				End If

				Return Me.s9_Renamed
			End Get
		End Property

		Public ReadOnly Property S10() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s10_Renamed Is Nothing Then
					Me.s10_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(250, "May"), New LineAreaSeriesData(240, "Jun"), New LineAreaSeriesData(260, "Jul"), New LineAreaSeriesData(290, "Aug"), New LineAreaSeriesData(320, "Sep"), New LineAreaSeriesData(360, "Oct"), New LineAreaSeriesData(350, "Nov"), New LineAreaSeriesData(320, "Dec"), New LineAreaSeriesData(330, "Jan")}
				End If

				Return Me.s10_Renamed
			End Get
		End Property

		Public ReadOnly Property S11() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s11_Renamed Is Nothing Then
					Me.s11_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(130, "May"), New LineAreaSeriesData(160, "Jun"), New LineAreaSeriesData(170, "Jul"), New LineAreaSeriesData(190, "Aug"), New LineAreaSeriesData(100, "Sep"), New LineAreaSeriesData(60, "Oct"), New LineAreaSeriesData(90, "Nov"), New LineAreaSeriesData(140, "Dec"), New LineAreaSeriesData(110, "Jan")}
				End If

				Return Me.s11_Renamed
			End Get
		End Property

		Public ReadOnly Property S12() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s12_Renamed Is Nothing Then
					Me.s12_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(330, "May"), New LineAreaSeriesData(360, "Jun"), New LineAreaSeriesData(320, "Jul"), New LineAreaSeriesData(370, "Aug"), New LineAreaSeriesData(280, "Sep"), New LineAreaSeriesData(230, "Oct"), New LineAreaSeriesData(290, "Nov"), New LineAreaSeriesData(210, "Dec"), New LineAreaSeriesData(290, "Jan")}
				End If

				Return Me.s12_Renamed
			End Get
		End Property

		Public Function GetData(ByVal index As Integer) As IEnumerable(Of LineAreaSeriesData)
			If index = 0 Then
				Return Me.S1
			End If

			If index = 1 Then
				Return Me.S2
			End If

			If index = 2 Then
				Return Me.S3
			End If

			If index = 3 Then
				Return Me.S4
			End If

			If index = 4 Then
				Return Me.S5
			End If

			If index = 5 Then
				Return Me.S6
			End If

			If index = 6 Then
				Return Me.S7
			End If

			If index = 7 Then
				Return Me.S8
			End If

			If index = 8 Then
				Return Me.S9
			End If

			If index = 9 Then
				Return Me.S10
			End If

			If index = 10 Then
				Return Me.S11
			End If

			If index = 11 Then
				Return Me.S12
			End If

			Return Nothing
		End Function

		Public Function GetLegendText(ByVal index As Integer) As String
			Select Case index
				Case 0
					Return "Bills"
				Case 1
					Return "Car"
				Case 2
					Return "Entertainment"
				Case 3
					Return "Food & Drink"
				Case 4
					Return "Gifts"
				Case 5
					Return "Groceries"
				Case 6
					Return "Hobbies"
				Case 7
					Return "Rent"
				Case 8
					Return "Savings"
				Case 9
					Return "Shopping"
				Case 10
					Return "Travel"
				Case 11
					Return "Utilities"
				Case Else
					Return "Missing product ID"
			End Select
		End Function
	End Class
End Namespace
