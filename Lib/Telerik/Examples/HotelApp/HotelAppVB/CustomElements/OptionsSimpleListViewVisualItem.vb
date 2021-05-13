Imports HotelApp.Data
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class OptionsSimpleListViewVisualItem
		Inherits SimpleListViewVisualItem
		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(SimpleListViewVisualItem)
			End Get
		End Property
         
        Private stack As New StackLayoutElement()
        Private countElement As LightVisualElement
        Private countImage As LightVisualElement

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            stack = New StackLayoutElement()
            countElement = New LightVisualElement()
            countImage = New LightVisualElement()
            Me.stack.ShouldHandleMouseInput = False
            Me.countImage.ShouldHandleMouseInput = False
            Me.countElement.NotifyParentOnMouseInput = True
            Me.countElement.ShouldHandleMouseInput = False
            Me.countElement.StretchHorizontally = False
            Me.countElement.Alignment = ContentAlignment.MiddleRight
            countElement.MaxSize = New Size(30, 0)
            Me.countElement.MinSize = countElement.MaxSize
            Me.countImage.ImageLayout = ImageLayout.None
            Me.countImage.ImageAlignment = ContentAlignment.MiddleRight
            Me.countImage.StretchHorizontally = True

            Me.stack.Children.Add(countImage)
            Me.stack.Children.Add(countElement)
            Me.stack.StretchHorizontally = True
            Me.Children.Add(stack)
        End Sub

		Protected Overrides Sub SynchronizeProperties()
			MyBase.SynchronizeProperties()

			Me.DrawText = False
			Me.ToggleElement.Text = Me.Text

			Me.ToggleElement.CustomFont = Utils.MainFont
			Me.ToggleElement.CustomFontSize = 10.5f
			Me.ToggleElement.TextElement.Margin = New Padding(10, 0, 0, 0)

			Me.countElement.CustomFont = Utils.MainFont
			Me.countElement.CustomFontSize = 10.5f
			Me.countElement.CustomFontStyle = FontStyle.Regular

			If Me.Data.Group.Text = "STAFF - SERVICE" Then
				Me.countImage.Image = Nothing
				Me.countElement.Text = GetRoomsByHouseKeeper(Me.dataItem.Text)
			ElseIf Me.Text = "Not assigned rooms" Then
				Me.countImage.Image = Nothing
				Me.countElement.Text = GetNotAssignedRooms()
			Else
				If Me.Text = System.Enum.GetName(GetType(BookingStatus), BookingStatus.Actual) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetBookingByStatus(BookingStatus.Actual)
				ElseIf Me.Text = System.Enum.GetName(GetType(BookingStatus), BookingStatus.Cancelled) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetBookingByStatus(BookingStatus.Cancelled)
				ElseIf Me.Text = System.Enum.GetName(GetType(BookingStatus), BookingStatus.CheckedOut) AndAlso Me.Data.ListView.Name.Contains("Booking") Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetBookingByStatus(BookingStatus.CheckedOut)
				ElseIf Me.Text = System.Enum.GetName(GetType(BookingStatus), BookingStatus.NoShow) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetBookingByStatus(BookingStatus.NoShow)
				ElseIf Me.Text = System.Enum.GetName(GetType(BookingStatus), BookingStatus.Reservation) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetBookingByStatus(BookingStatus.Reservation)
				ElseIf Me.Text = System.Enum.GetName(GetType(HouseKeepingStatus), HouseKeepingStatus.Clean) Then
					Me.countImage.Image = Utils.GetRoomIconByHouseKeepingStatus(HouseKeepingStatus.Clean)
					Me.countElement.Text = GetRoomsByHouseKeepingStatus(HouseKeepingStatus.Clean)
				ElseIf Me.Text = System.Enum.GetName(GetType(HouseKeepingStatus), HouseKeepingStatus.NotClean) Then
					Me.countImage.Image = Utils.GetRoomIconByHouseKeepingStatus(HouseKeepingStatus.NotClean)
					Me.countElement.Text = GetRoomsByHouseKeepingStatus(HouseKeepingStatus.NotClean)
				ElseIf Me.Text = System.Enum.GetName(GetType(HouseKeepingStatus), HouseKeepingStatus.InProgress) Then
					Me.countImage.Image = Utils.GetRoomIconByHouseKeepingStatus(HouseKeepingStatus.InProgress)
					Me.countElement.Text = GetRoomsByHouseKeepingStatus(HouseKeepingStatus.InProgress)
				ElseIf Me.Text = "Repair" Then
					Me.countImage.Image = My.Resources.repair_small
					Me.countElement.Text = GetRoomsToRepair(True)
				ElseIf Me.Text = System.Enum.GetName(GetType(RoomStatus), RoomStatus.Available) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetRoomsByStatus(RoomStatus.Available)
				ElseIf Me.Text = System.Enum.GetName(GetType(RoomStatus), RoomStatus.Occupied) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetRoomsByStatus(RoomStatus.Occupied)
				ElseIf Me.Text = System.Enum.GetName(GetType(RoomStatus), RoomStatus.Reserved) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetRoomsByStatus(RoomStatus.Reserved)
				ElseIf Me.Text = System.Enum.GetName(GetType(RoomStatus), RoomStatus.CheckedOut) Then
					Me.countImage.Image = Nothing
					Me.countElement.Text = GetRoomsByStatus(RoomStatus.CheckedOut)
				ElseIf CType(Me.Data.Value, RoomType) = RoomType.Single Then
					Me.countImage.Image = Utils.GetRoomIconByType(RoomType.Single)
					Me.countElement.Text = GetRoomsByType(RoomType.Single)
				ElseIf CType(Me.Data.Value, RoomType) = RoomType.Double Then
				   Me.countImage.Image = Utils.GetRoomIconByType(RoomType.Double)
				   Me.countElement.Text = GetRoomsByType(RoomType.Double)
				ElseIf CType(Me.Data.Value, RoomType) = RoomType.Triple Then
					Me.countImage.Image = Utils.GetRoomIconByType(RoomType.Triple)
					Me.countElement.Text = GetRoomsByType(RoomType.Triple)
				ElseIf CType(Me.Data.Value, RoomType) = RoomType.Family Then
					Me.countImage.Image = Utils.GetRoomIconByType(RoomType.Family)
					Me.countElement.Text = GetRoomsByType(RoomType.Family)
				End If
			End If
		End Sub

		Private Function GetRoomsByHouseKeeper(ByVal name As String) As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each r As Room In form.Rooms
					If r.HouseKeeperId = Utils.GetHouseKeeperIdByName(name, form.HouseKeepers) Then
						count += 1
					End If
				Next r
			End If
			Return count.ToString()
		End Function

		Private Function GetNotAssignedRooms() As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each r As Room In form.Rooms
					If r.HouseKeeperId Is Nothing AndAlso r.HouseKeepingStatus <> HouseKeepingStatus.Clean Then
						count += 1
					End If
				Next r
			End If
			Return count.ToString()
		End Function

		Private Function GetBookingByStatus(ByVal bookingStatus_Renamed As BookingStatus) As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each booking_Renamed As Booking In form.Bookings
					If booking_Renamed.GetBookingStatusAtDate(form.BookingsDate, booking_Renamed) = bookingStatus_Renamed AndAlso booking_Renamed.From <= form.BookingsDate AndAlso booking_Renamed.To >= form.BookingsDate Then
						count += 1
					End If
				Next booking_Renamed
			End If
			Return count.ToString()
		End Function

		Private Function GetRoomsByType(ByVal roomType_Renamed As RoomType) As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each room_Renamed As Room In form.Rooms
					If room_Renamed.Type = roomType_Renamed AndAlso form.GetItemByRoomId(room_Renamed.Id).Visible Then
						count += 1
					End If
				Next room_Renamed
			End If
			Return count.ToString()
		End Function

		Private Function GetRoomsByStatus(ByVal roomStatus_Renamed As RoomStatus) As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each room_Renamed As Room In form.Rooms
					If room_Renamed.GetStatusByBooking(form.OverviewDate, form.Bookings) = roomStatus_Renamed AndAlso form.GetItemByRoomId(room_Renamed.Id).Visible Then
					'if (room.GetStatusAtDate(form.OverviewDate, form.Bookings) == roomStatus && form.GetItemByRoomId(room.Id).Visible)
						count += 1
					End If
				Next room_Renamed
			End If
			Return count.ToString()
		End Function

		Private Function GetRoomsToRepair(ByVal repair As Boolean) As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each room_Renamed As Room In form.Rooms
					If room_Renamed.NeedsRepairs = repair AndAlso form.GetItemByRoomId(room_Renamed.Id).Visible Then
						count += 1
					End If
				Next room_Renamed
			End If
			Return count.ToString()
		End Function

		Private Function GetRoomsByHouseKeepingStatus(ByVal houseKeepingStatus_Renamed As HouseKeepingStatus) As String
			Dim count As Integer = 0
			Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				For Each room_Renamed As Room In form.Rooms
					If room_Renamed.HouseKeepingStatus = houseKeepingStatus_Renamed AndAlso form.GetItemByRoomId(room_Renamed.Id).Visible Then
						count += 1
					End If
				Next room_Renamed
			End If
			Return count.ToString()
		End Function
	End Class
End Namespace