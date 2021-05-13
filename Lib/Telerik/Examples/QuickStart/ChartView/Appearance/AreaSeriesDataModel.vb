Namespace Telerik.Examples.WinControls.ChartView.Appearance
	Public Class AreaSeriesDataModel
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

		Public ReadOnly Property S1() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s1_Renamed Is Nothing Then
					Me.s1_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(50, "May"), New LineAreaSeriesData(40, "Jun"), New LineAreaSeriesData(80, "Jul"), New LineAreaSeriesData(30, "Aug"), New LineAreaSeriesData(50, "Sep"), New LineAreaSeriesData(60, "Oct"), New LineAreaSeriesData(90, "Nov"), New LineAreaSeriesData(60, "Dec"), New LineAreaSeriesData(50, "Jan")}
				End If

				Return Me.s1_Renamed
			End Get
		End Property

		Public ReadOnly Property S2() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s2_Renamed Is Nothing Then
					Me.s2_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(150, "May"), New LineAreaSeriesData(90, "Jun"), New LineAreaSeriesData(140, "Jul"), New LineAreaSeriesData(140, "Aug"), New LineAreaSeriesData(160, "Sep"), New LineAreaSeriesData(130, "Oct"), New LineAreaSeriesData(100, "Nov"), New LineAreaSeriesData(140, "Dec"), New LineAreaSeriesData(130, "Jan")}
				End If

				Return Me.s2_Renamed
			End Get
		End Property

		Public ReadOnly Property S3() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s3_Renamed Is Nothing Then
					Me.s3_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(180, "May"), New LineAreaSeriesData(200, "Jun"), New LineAreaSeriesData(190, "Jul"), New LineAreaSeriesData(170, "Aug"), New LineAreaSeriesData(220, "Sep"), New LineAreaSeriesData(180, "Oct"), New LineAreaSeriesData(200, "Nov"), New LineAreaSeriesData(150, "Dec"), New LineAreaSeriesData(160, "Jan")}
				End If

				Return Me.s3_Renamed
			End Get
		End Property

		Public ReadOnly Property S4() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s4_Renamed Is Nothing Then
					Me.s4_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(210, "May"), New LineAreaSeriesData(230, "Jun"), New LineAreaSeriesData(220, "Jul"), New LineAreaSeriesData(270, "Aug"), New LineAreaSeriesData(270, "Sep"), New LineAreaSeriesData(250, "Oct"), New LineAreaSeriesData(230, "Nov"), New LineAreaSeriesData(230, "Dec"), New LineAreaSeriesData(200, "Jan")}
				End If

				Return Me.s4_Renamed
			End Get
		End Property

		Public ReadOnly Property S5() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s5_Renamed Is Nothing Then
					Me.s5_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(310, "May"), New LineAreaSeriesData(300, "Jun"), New LineAreaSeriesData(320, "Jul"), New LineAreaSeriesData(350, "Aug"), New LineAreaSeriesData(320, "Sep"), New LineAreaSeriesData(320, "Oct"), New LineAreaSeriesData(300, "Nov"), New LineAreaSeriesData(330, "Dec"), New LineAreaSeriesData(310, "Jan")}
				End If

				Return Me.s5_Renamed
			End Get
		End Property

		Public ReadOnly Property S6() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s6_Renamed Is Nothing Then
					Me.s6_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(360, "May"), New LineAreaSeriesData(420, "Jun"), New LineAreaSeriesData(370, "Jul"), New LineAreaSeriesData(370, "Aug"), New LineAreaSeriesData(370, "Sep"), New LineAreaSeriesData(360, "Oct"), New LineAreaSeriesData(350, "Nov"), New LineAreaSeriesData(400, "Dec"), New LineAreaSeriesData(380, "Jan")}
				End If

				Return Me.s6_Renamed
			End Get
		End Property

		Public ReadOnly Property S7() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s7_Renamed Is Nothing Then
					Me.s7_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(450, "May"), New LineAreaSeriesData(440, "Jun"), New LineAreaSeriesData(450, "Jul"), New LineAreaSeriesData(440, "Aug"), New LineAreaSeriesData(430, "Sep"), New LineAreaSeriesData(380, "Oct"), New LineAreaSeriesData(400, "Nov"), New LineAreaSeriesData(420, "Dec"), New LineAreaSeriesData(430, "Jan")}
				End If

				Return Me.s7_Renamed
			End Get
		End Property

		Public ReadOnly Property S8() As IEnumerable(Of LineAreaSeriesData)
			Get
				If Me.s8_Renamed Is Nothing Then
					Me.s8_Renamed = New List(Of LineAreaSeriesData)() From {New LineAreaSeriesData(480, "May"), New LineAreaSeriesData(470, "Jun"), New LineAreaSeriesData(470, "Jul"), New LineAreaSeriesData(500, "Aug"), New LineAreaSeriesData(480, "Sep"), New LineAreaSeriesData(480, "Oct"), New LineAreaSeriesData(430, "Nov"), New LineAreaSeriesData(450, "Dec"), New LineAreaSeriesData(480, "Jan")}
				End If

				Return Me.s8_Renamed
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

			Return Nothing
		End Function
	End Class
End Namespace
