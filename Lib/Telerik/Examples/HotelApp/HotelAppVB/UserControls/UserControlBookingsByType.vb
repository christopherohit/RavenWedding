Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports HotelApp.Data

Namespace HotelApp
	Partial Public Class UserControlBookingsByType
		Inherits UserControl
		Public Bookings As BindingList(Of Booking)
		Public Rooms As BindingList(Of Room)
		Public Shared converter As New ColorConverter()

		Public Sub New()
			InitializeComponent()

			AddHandler Me.bookingsByTypeChartView.LabelFormatting, AddressOf LabelFormatting
			AddHandler Me.bookingsByRoomTypeChartView.LabelFormatting, AddressOf LabelFormatting
			AddHandler Me.availabilityChartView.LabelFormatting, AddressOf availabilityChartView_LabelFormatting
			Me.bookingsByTypeChartView.Area.View.Palette = New BookingTypesPalette()
			Me.bookingsByTypeChartView.ChartElement.CustomFont = Utils.MainFont
			Me.bookingsByTypeChartView.ChartElement.CustomFontSize = 9
			Me.bookingsByRoomTypeChartView.Area.View.Palette = KnownPalette.Rainbow
			Me.bookingsByRoomTypeChartView.ChartElement.CustomFont = Utils.MainFont
			Me.bookingsByRoomTypeChartView.ChartElement.CustomFontSize = 9
			Me.availabilityChartView.Area.View.Palette = New AvailabilityPalette()
			Me.availabilityChartView.ChartElement.CustomFont = Utils.MainFont
			Me.availabilityChartView.ChartElement.CustomFontSize = 9
			Me.averageChartView.Area.View.Palette = KnownPalette.Rainbow

			Me.bookingsByTypeChartView.ChartElement.View.Margin = New Padding(60)
			Me.bookingsByTypeChartView.Title = "BOOKINGS BY TYPE"
			Me.bookingsByTypeChartView.ShowTitle = True
			Me.bookingsByTypeChartView.ChartElement.TitleElement.Margin = New Padding(0, 10, 0, 0)
			Me.bookingsByTypeChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium
			Me.bookingsByTypeChartView.ChartElement.TitleElement.CustomFontSize = 10f
			Me.bookingsByTypeChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter

			Me.bookingsByRoomTypeChartView.ChartElement.View.Margin = New Padding(60)
			Me.bookingsByRoomTypeChartView.Title = "ACTUAL BOOKINGS BY ROOM TYPE"
			Me.bookingsByRoomTypeChartView.ShowTitle = True
			Me.bookingsByRoomTypeChartView.ChartElement.TitleElement.Margin = New Padding(0, 10, 0, 0)
			Me.bookingsByRoomTypeChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium
			Me.bookingsByRoomTypeChartView.ChartElement.TitleElement.CustomFontSize = 10f
			Me.bookingsByRoomTypeChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter

			Me.availabilityChartView.ChartElement.View.Margin = New Padding(60)
			Me.availabilityChartView.Title = "AVAILABILITY"
			Me.availabilityChartView.ShowTitle = True
			Me.availabilityChartView.ChartElement.TitleElement.Margin = New Padding(0, 10, 0, 0)
			Me.availabilityChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium
			Me.availabilityChartView.ChartElement.TitleElement.CustomFontSize = 10f
			Me.availabilityChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter

			Me.averageChartView.Title = "AVERAGE STAY BY ROOM TYPE"
			Me.averageChartView.ShowTitle = True
			Me.averageChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium
			Me.averageChartView.ChartElement.TitleElement.Padding = New Padding(0, 10, 0, 0)
			Me.averageChartView.ChartElement.TitleElement.CustomFontSize = 10f
			Me.averageChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter
			Me.averageChartView.ChartElement.View.Margin = New Padding(0, 20, 10, 10)

			Dim area As CartesianArea = Me.averageChartView.GetArea(Of CartesianArea)()
			area.ShowGrid = True
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalFills = False
			grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot
		End Sub

		Private Sub availabilityChartView_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			Dim dp As PieDataPoint = TryCast(e.LabelElement.DataPoint, PieDataPoint)
			If dp IsNot Nothing Then
				Dim pieLabel As PieLabelElement = TryCast(e.LabelElement, PieLabelElement)

				pieLabel.Text = dp.LegendTitle
				pieLabel.BackColor = Color.Transparent
				pieLabel.BorderColor = pieLabel.DataPointElement.BackColor
				pieLabel.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
				If dp.Value = 0 Then
					pieLabel.IsVisible = False
				Else
					pieLabel.IsVisible = True
				End If
			End If
		End Sub

		Friend Sub Initialize(ByVal reportsInterval As String, ByVal bookings As BindingList(Of Booking), ByVal rooms As BindingList(Of Room), ByVal dateTime As Date)
			Me.Bookings = bookings
			Me.Rooms = rooms

			Me.bookingsByTypeChartView.Series.Clear()
			Me.bookingsByRoomTypeChartView.Series.Clear()
			Me.availabilityChartView.Series.Clear()
			Me.averageChartView.Series.Clear()
			Me.averageChartView.GetArea(Of CartesianArea)().Orientation = Orientation.Vertical
			Me.averageChartView.Axes.Clear()

			Me.bookingsByTypeChartView.AreaType = ChartAreaType.Pie
			Dim series As New PieSeries()
			series.LabelsOffsetFromCenter = 1.05f

			For Each bookingStatus_Renamed As BookingStatus In System.Enum.GetValues(GetType(BookingStatus))
				Dim dataPoint As New PieDataPoint(GetBookingsByType(bookings, bookingStatus_Renamed, dateTime, reportsInterval), Utils.GetBookingTypeByStatus(bookingStatus_Renamed))
				If dataPoint.Value > 0 Then
					series.DataPoints.Add(dataPoint)
				End If
			Next bookingStatus_Renamed

			series.ShowLabels = True
			If series.DataPoints.Count > 0 Then
				Me.bookingsByTypeChartView.Series.Add(series)
			End If

			Me.bookingsByRoomTypeChartView.AreaType = ChartAreaType.Pie
			Dim series2 As New PieSeries()
			series2.LabelsOffsetFromCenter = 1.05f
			For Each roomType_Renamed As RoomType In System.Enum.GetValues(GetType(RoomType))
				Dim dataPoint As New PieDataPoint(GetBookingsByRoomType(bookings, roomType_Renamed, dateTime, reportsInterval), Utils.GetRoomType(roomType_Renamed))
				If dataPoint.Value > 0 Then
					series2.DataPoints.Add(dataPoint)
				End If
			Next roomType_Renamed

			series2.ShowLabels = True
			If series2.DataPoints.Count > 0 Then
				Me.bookingsByRoomTypeChartView.Series.Add(series2)
			End If

			Me.availabilityChartView.AreaType = ChartAreaType.Pie
			Dim series3 As New PieSeries()
			series3.LabelsOffsetFromCenter = 1.05f

			Dim needRepairs As Availability = GetBookingsByRoomRepairs(Me.Bookings, dateTime, reportsInterval)

			If needRepairs.Actual > 0 Then
				series3.DataPoints.Add(New PieDataPoint(needRepairs.Actual, "Actual"))
			End If
			If needRepairs.Maintenance > 0 Then
				series3.DataPoints.Add(New PieDataPoint(needRepairs.Maintenance, "Maintenance"))
			End If

			series3.ShowLabels = True
			If series3.DataPoints.Count > 0 Then
				Me.availabilityChartView.Series.Add(series3)
			End If

			For Each roomType_Renamed As RoomType In System.Enum.GetValues(GetType(RoomType))
				Dim series4 As New BarSeries()
				Dim dataPoint As New CategoricalDataPoint(GetBookingsDurationByRoomType(bookings, roomType_Renamed, dateTime, reportsInterval), Utils.GetRoomType(roomType_Renamed))
				If dataPoint.Value > 0 Then
					series4.DataPoints.Add(dataPoint)
				End If
				If series4.DataPoints.Count > 0 Then
					Me.averageChartView.Series.Add(series4)
				End If
				Dim verticalAxis As LinearAxis = TryCast(series4.VerticalAxis, LinearAxis)
				If verticalAxis IsNot Nothing Then
					verticalAxis.BorderColor = Color.FromArgb(209, 209, 209)
					verticalAxis.CustomFont = Utils.MainFontMedium
					verticalAxis.CustomFontSize = 10f
					verticalAxis.Minimum = 0
					verticalAxis.Maximum = 3
					verticalAxis.LastLabelVisibility = AxisLastLabelVisibility.Hidden
					verticalAxis.LabelFormatProvider = New MyFormatProvider()
					verticalAxis.MajorStep = 1
				End If

				Dim horizontalAxis As CategoricalAxis = TryCast(series4.HorizontalAxis, CategoricalAxis)
				If horizontalAxis IsNot Nothing Then
					horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
					horizontalAxis.GapLength = 0.6
					horizontalAxis.CustomFont = Utils.MainFontMedium
					horizontalAxis.CustomFontSize = 10f
					horizontalAxis.LabelFormat = "{0:dd/MM/yyyy}"
					horizontalAxis.BorderColor = Color.FromArgb(209, 209, 209)
				End If

				Me.averageChartView.ChartElement.InvalidateMeasure(True)
				Me.averageChartView.ChartElement.UpdateLayout()
				RemoveBorderFromAxis(verticalAxis, horizontalAxis)
			Next roomType_Renamed

			Me.averageChartView.GetArea(Of CartesianArea)().Orientation = Orientation.Horizontal
			Me.bookingsByTypeChartView.ChartElement.InvalidateMeasure(True)
			Me.bookingsByTypeChartView.ChartElement.UpdateLayout()
			Me.bookingsByRoomTypeChartView.ChartElement.InvalidateMeasure(True)
			Me.bookingsByRoomTypeChartView.ChartElement.UpdateLayout()
			Me.availabilityChartView.ChartElement.InvalidateMeasure(True)
			Me.availabilityChartView.ChartElement.UpdateLayout()

			Me.bookingsByTypeChartView.ChartElement.Text = If(bookingsByTypeChartView.Series.Count > 0, "", "No available data")
			Me.bookingsByRoomTypeChartView.ChartElement.Text = If(bookingsByTypeChartView.Series.Count > 0, "", "No available data")
			Me.availabilityChartView.ChartElement.Text = If(bookingsByTypeChartView.Series.Count > 0, "", "No available data")
		End Sub

		Private Sub RemoveBorderFromAxis(ByVal verticalAxis As LinearAxis, ByVal horizontalAxis As CategoricalAxis)
			If verticalAxis Is Nothing OrElse horizontalAxis Is Nothing Then
				Return
			End If
			For Each el As UIChartElement In verticalAxis.Children
				Dim label As AxisLabelElement = TryCast(el, AxisLabelElement)
				If label IsNot Nothing Then
					label.BorderWidth = 0
				End If
			Next el
			For Each el As UIChartElement In horizontalAxis.Children
				Dim label As AxisLabelElement = TryCast(el, AxisLabelElement)
				If label IsNot Nothing Then
					label.BorderWidth = 0
				End If
			Next el
		End Sub

		Private Function GetBookingsDurationByRoomType(ByVal bookings As BindingList(Of Booking), ByVal roomType_Renamed As RoomType, ByVal date_Renamed As Date, ByVal reportsInterval As String) As Double
			Dim days As Integer = 0
			If reportsInterval = "Days" Then
				days = 3
			ElseIf reportsInterval = "Weekly" Then
				days = 7
			Else
				days = 30
			End If
			Dim cnt As Integer = 0
			Dim durationInDays As Double = 0
			For Each b As Booking In bookings
				If Utils.GetRoomById(b.RoomId, Me.Rooms).Type = roomType_Renamed AndAlso (b.From >= date_Renamed AndAlso b.From <= date_Renamed.AddDays(days) OrElse b.To >= date_Renamed AndAlso b.To <= date_Renamed.AddDays(days)) Then
					durationInDays = b.To.Subtract(b.From).TotalDays
					cnt += 1
				End If
			Next b
			Return durationInDays / days
		End Function

		Private Function GetBookingsByRoomRepairs(ByVal bookings As BindingList(Of Booking), ByVal date_Renamed As Date, ByVal reportsInterval As String) As Availability
			Dim needRepairs As New Availability(0, 0)
			Dim days As Integer = 0
			If reportsInterval = "Days" Then
				days = 2
			ElseIf reportsInterval = "Weekly" Then
				days = 6
			Else
				days = 29
			End If
			Dim room_Renamed As Room
			For Each booking_Renamed As Booking In bookings
				room_Renamed = Utils.GetRoomById(booking_Renamed.RoomId, Me.Rooms)
				If (booking_Renamed.From >= date_Renamed AndAlso booking_Renamed.From <= date_Renamed.AddDays(days) OrElse booking_Renamed.To >= date_Renamed AndAlso booking_Renamed.To <= date_Renamed.AddDays(days)) Then
					If room_Renamed.NeedsRepairs Then
						needRepairs.Actual += 1
					Else
						needRepairs.Maintenance += 1
					End If
				End If
			Next booking_Renamed
			Return needRepairs
		End Function

		Private Sub LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			Dim dp As PieDataPoint = TryCast(e.LabelElement.DataPoint, PieDataPoint)
			If dp IsNot Nothing Then
				Dim pieLabel As PieLabelElement = TryCast(e.LabelElement, PieLabelElement)

				pieLabel.Text = dp.LegendTitle
				pieLabel.BackColor = Color.Transparent
				pieLabel.BorderColor = pieLabel.DataPointElement.BackColor
				pieLabel.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
				If dp.Value = 0 Then
					pieLabel.IsVisible = False
				Else
					pieLabel.IsVisible = True
				End If
			End If
		End Sub

		Private Function GetBookingsByRoomType(ByVal bookings As BindingList(Of Booking), ByVal roomType_Renamed As RoomType, ByVal date_Renamed As Date, ByVal reportsInterval As String) As Double
			Dim days As Integer = 0
			If reportsInterval = "Days" Then
				days = 2
			ElseIf reportsInterval = "Weekly" Then
				days = 6
			Else
				days = 29
			End If
			Dim cnt As Integer = 0

			For Each b As Booking In bookings
				If Utils.GetRoomById(b.RoomId, Me.Rooms).Type = roomType_Renamed AndAlso (b.From >= date_Renamed AndAlso b.From <= date_Renamed.AddDays(days) OrElse b.To >= date_Renamed AndAlso b.To <= date_Renamed.AddDays(days)) Then
					cnt += 1
				End If
			Next b
			Return cnt
		End Function

		Private Function GetBookingsByType(ByVal bookings As BindingList(Of Booking), ByVal bookingStatus_Renamed As BookingStatus, ByVal date_Renamed As Date, ByVal reportsInterval As String) As Double
			Dim days As Integer = 0
			If reportsInterval = "Days" Then
				days = 2
			ElseIf reportsInterval = "Weekly" Then
				days = 6
			Else
				days = 29
			End If
			Dim cnt As Integer = 0

			For Each b As Booking In bookings
				If b.Status = bookingStatus_Renamed AndAlso (b.From >= date_Renamed AndAlso b.From <= date_Renamed.AddDays(days) OrElse b.To >= date_Renamed AndAlso b.To <= date_Renamed.AddDays(days)) Then
					cnt += 1
				End If
			Next b
			Return cnt
		End Function

		Private Class Availability
			Public Property Actual() As Integer

			Public Property Maintenance() As Integer

			Public Sub New(ByVal actual As Integer, ByVal maintenance As Integer)
				Me.Actual = actual
				Me.Maintenance = maintenance
			End Sub
		End Class

		Public Class BookingTypesPalette
			Inherits ChartPalette
			Public Sub New()
				Dim color1 As Color = CType(converter.ConvertFromString("#FF1171CA"), Color)
				Dim color2 As Color = CType(converter.ConvertFromString("#FF3294DA"), Color)
				Dim color3 As Color = CType(converter.ConvertFromString("#FFE03D0B"), Color)
				Dim color4 As Color = CType(converter.ConvertFromString("#FFF58E13"), Color)

				Me.GlobalEntries.Add(color1, color1)
				Me.GlobalEntries.Add(color2, color2)
				Me.GlobalEntries.Add(color3, color3)
				Me.GlobalEntries.Add(color4, color4)
			End Sub
		End Class

		Public Class AvailabilityPalette
			Inherits ChartPalette
			Public Sub New()
				Dim color1 As Color = CType(converter.ConvertFromString("#FFE3DA20"), Color)
				Dim color2 As Color = CType(converter.ConvertFromString("#FFE03D0B"), Color)

				Me.GlobalEntries.Add(color1, color1)
				Me.GlobalEntries.Add(color2, color2)
			End Sub
		End Class

		Public Class MyFormatProvider
			Implements IFormatProvider, ICustomFormatter
			Public Function GetFormat(ByVal formatType As Type) As Object Implements IFormatProvider.GetFormat
				Return Me
			End Function

'INSTANT VB NOTE: The parameter format was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
			Public Function Format(ByVal format_Renamed As String, ByVal arg As Object, ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
				Dim s As String = arg.ToString()
				Select Case s
					Case "0"
						Return "1 Day"
					Case "1"
						Return "2 Days"
					Case "2"
						Return "3 Days"
					Case Else
						Return "N/A"
				End Select
			End Function
		End Class
	End Class
End Namespace