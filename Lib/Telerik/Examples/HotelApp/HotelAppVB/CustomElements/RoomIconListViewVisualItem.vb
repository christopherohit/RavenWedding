Imports HotelApp.Data
Imports System.Reflection
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class RoomIconListViewVisualItem
		Inherits IconListViewVisualItem
		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(IconListViewVisualItem)
			End Get
		End Property

        Private roomId As LightVisualElement
        Private roomStatus As LightVisualElement
        Private bookingInfo As LightVisualElement
        Private bookingDuration As LightVisualElement
        Private houseKeepingInfo As LightVisualElement
        Private needsRepair As LightVisualElement
        Private verticalContainer As StackLayoutElement
        Private roomHeaderContainer As StackLayoutElement
        Private roomFooterContainer As StackLayoutElement

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
            roomId = New LightVisualElement()
            roomStatus = New LightVisualElement()
            bookingInfo = New LightVisualElement()
            bookingDuration = New LightVisualElement()
            houseKeepingInfo = New LightVisualElement()
            needsRepair = New LightVisualElement()
            verticalContainer = New StackLayoutElement()
            roomHeaderContainer = New StackLayoutElement()
            roomFooterContainer = New StackLayoutElement()
			verticalContainer.Orientation = Orientation.Vertical
			verticalContainer.NotifyParentOnMouseInput = True
			verticalContainer.ShouldHandleMouseInput = False
			verticalContainer.StretchHorizontally = True
			verticalContainer.StretchVertically = True

			roomHeaderContainer.Orientation = Orientation.Horizontal
			roomHeaderContainer.NotifyParentOnMouseInput = True
			roomHeaderContainer.ShouldHandleMouseInput = False
			roomHeaderContainer.Children.Add(roomId)
			roomHeaderContainer.Children.Add(roomStatus)
			roomHeaderContainer.StretchHorizontally = True

			roomId.NotifyParentOnMouseInput = True
			roomId.ShouldHandleMouseInput = False
			roomId.StretchHorizontally = True
			roomId.CustomFont = Utils.MainFont
			roomId.CustomFontSize = 9
			roomId.CustomFontStyle = FontStyle.Bold
			roomId.Margin = New Padding(5, 10, 0, 0)
			roomId.TextAlignment = ContentAlignment.MiddleLeft

			roomStatus.NotifyParentOnMouseInput = True
			roomStatus.ShouldHandleMouseInput = False
			roomStatus.StretchHorizontally = False
			roomStatus.CustomFont = Utils.MainFont
			roomStatus.CustomFontSize = 9
			roomStatus.CustomFontStyle = FontStyle.Regular
			roomStatus.Margin = New Padding(0,5,5,0)

			roomFooterContainer.Orientation = Orientation.Horizontal
			roomFooterContainer.NotifyParentOnMouseInput = True
			roomFooterContainer.ShouldHandleMouseInput = False
			roomFooterContainer.StretchHorizontally = True
			roomFooterContainer.DrawFill = True
			roomFooterContainer.BackColor = Color.White
			roomFooterContainer.GradientStyle = GradientStyles.Solid
			roomFooterContainer.MinSize = New Size(0, 30)

			bookingInfo.TextImageRelation = TextImageRelation.ImageBeforeText
			bookingInfo.StretchHorizontally = False
			bookingInfo.Layout.LeftPart.Padding = New Padding(24, 0, 8, 0)

			bookingInfo.Alignment = ContentAlignment.MiddleCenter
			bookingInfo.NotifyParentOnMouseInput = True
			bookingInfo.ShouldHandleMouseInput = False
			bookingInfo.CustomFont = Utils.MainFont
			bookingInfo.CustomFontSize = 12
			bookingInfo.CustomFontStyle = FontStyle.Regular

			needsRepair.Text = "repair"
			bookingDuration.NotifyParentOnMouseInput = True
			bookingDuration.ShouldHandleMouseInput = False

			bookingDuration.StretchVertically = True
			houseKeepingInfo.StretchVertically = True
			needsRepair.StretchVertically = True
			roomFooterContainer.Children.Add(bookingDuration)
			roomFooterContainer.Children.Add(houseKeepingInfo)
			roomFooterContainer.Children.Add(needsRepair)

			needsRepair.NotifyParentOnMouseInput = True
			needsRepair.ShouldHandleMouseInput = False
			needsRepair.StretchHorizontally = False
			needsRepair.Alignment = ContentAlignment.MiddleRight
			needsRepair.TextImageRelation = TextImageRelation.ImageBeforeText
			needsRepair.CustomFont = Utils.MainFont
			needsRepair.CustomFontSize = 9
			needsRepair.CustomFontStyle = FontStyle.Regular

			houseKeepingInfo.NotifyParentOnMouseInput = True
			houseKeepingInfo.ShouldHandleMouseInput = False
			houseKeepingInfo.StretchHorizontally = False
			houseKeepingInfo.TextImageRelation = TextImageRelation.ImageBeforeText
			houseKeepingInfo.CustomFont = Utils.MainFont
			houseKeepingInfo.CustomFontSize = 9
			houseKeepingInfo.CustomFontStyle = FontStyle.Regular

			bookingDuration.TextImageRelation = TextImageRelation.ImageBeforeText
			bookingDuration.CustomFont = Utils.MainFont
			bookingDuration.CustomFontSize = 9
			bookingDuration.CustomFontStyle = FontStyle.Regular
			bookingDuration.Margin = New Padding(5, 0, 0, 0)
			bookingDuration.StretchHorizontally = False

			verticalContainer.Children.Add(roomHeaderContainer)
			verticalContainer.Children.Add(bookingInfo)
			verticalContainer.Children.Add(roomFooterContainer)

			Me.Children.Add(Me.verticalContainer)
		End Sub

		Protected Overrides Sub SynchronizeProperties()
			MyBase.SynchronizeProperties()
			Me.DrawText = False
			Me.BackColor = Color.White
			Me.DrawFill = True
			Me.DrawBorder = False
			roomId.Margin = New Padding(8,8,0,0)
			bookingInfo.ImageLayout = ImageLayout.None
			bookingInfo.Margin = New Padding(24, 0, 0, 0)

			bookingInfo.Layout.LeftPart.Margin = New Padding(0, 0, 5, 0)
			bookingInfo.StretchHorizontally = True
			bookingInfo.ImageAlignment = ContentAlignment.MiddleLeft
			bookingInfo.TextAlignment = ContentAlignment.MiddleLeft

			bookingDuration.Layout.LeftPart.Margin = New Padding(0, -3, 0, 0)
			bookingDuration.ForeColor = Color.FromArgb(200, 0, 0, 0)
			houseKeepingInfo.ForeColor = Color.FromArgb(200, 0, 0, 0)
			houseKeepingInfo.Layout.LeftPart.Margin = New Padding(0, -3, 0, 0)
			needsRepair.ForeColor = Color.FromArgb(200, 0, 0, 0)
			needsRepair.Layout.LeftPart.Margin = New Padding(0, -3, 0, 0)

			Dim room_Renamed As Room = TryCast(Me.Data.DataBoundItem, Room)
			If room_Renamed IsNot Nothing Then
				Dim form As HotelAppForm = TryCast(Me.ElementTree.Control.FindForm(), HotelAppForm)
				roomId.Text = "Room " & room_Renamed.Id
				Dim roomStatusAtDate As RoomStatus = room_Renamed.GetStatusByBooking(form.OverviewDate, form.Bookings)
				roomStatus.Text = Utils.GetRoomStatus(roomStatusAtDate).ToLower()

				Dim booking_Renamed As Booking = form.GetBooking(room_Renamed)
				If booking_Renamed IsNot Nothing Then
					bookingInfo.Text = booking_Renamed.Name
					bookingInfo.Image = Utils.GetImageByRoomType(room_Renamed.Type)

					bookingDuration.Text = +(booking_Renamed.To - form.OverviewDate).Days + 1 & " days"
                    If roomStatusAtDate = HotelApp.RoomStatus.Occupied OrElse roomStatusAtDate = HotelApp.RoomStatus.CheckedOut Then
                        Me.BackColor = Color.FromArgb(247, 247, 247)
                    Else
                        Me.BackColor = Color.FromArgb(232, 232, 232)
                    End If

					roomId.ForeColor = Color.FromArgb(190, 0, 0, 0)
					roomStatus.ForeColor = Color.Black
					bookingInfo.ForeColor = Color.Black
				Else
					bookingInfo.Text = "Free Room"
					bookingInfo.Image = Utils.GetAvailableImageByTheme()
					bookingDuration.Text = "0 days"
					Me.BackColor = Utils.MainThemeColor
					roomId.ForeColor = Color.White
					roomStatus.ForeColor = Color.White
					bookingInfo.ForeColor = Color.White
				End If
				houseKeepingInfo.Text = "" & Utils.GetHouseKeepingStatus(room_Renamed.HouseKeepingStatus).ToLower()
				needsRepair.Image = My.Resources.GlyphWrench
				bookingDuration.Image = My.Resources.GlyphCalendar_small
				If room_Renamed.HouseKeepingStatus = HouseKeepingStatus.NotClean Then
					houseKeepingInfo.Image = My.Resources.GlyphClose
				Else
					houseKeepingInfo.Image = My.Resources.GlyphCheck_small
				End If
				If room_Renamed.NeedsRepairs Then
					needsRepair.Visibility = Telerik.WinControls.ElementVisibility.Visible
				Else
					needsRepair.Visibility = Telerik.WinControls.ElementVisibility.Hidden
				End If
			End If
		End Sub
	End Class
End Namespace