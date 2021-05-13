Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports HotelApp.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports CustomControls
Imports Telerik.WinControls

Namespace HotelApp
	Partial Public Class RoomDetailsUC
		Inherits UserControl
		Private comingFrom As String
		Private form As HotelAppForm
'INSTANT VB NOTE: The variable room was renamed since Visual Basic does not handle variables named the same as their type well:
		Private room_Renamed As Room
'INSTANT VB NOTE: The variable editGuestInfo was renamed since Visual Basic does not handle variables named the same as their type well:
		Private editGuestInfo_Renamed As EditGuestInfo
'INSTANT VB NOTE: The variable booking was renamed since Visual Basic does not handle variables named the same as their type well:
		Private booking_Renamed As Booking
		Private selectedGuest As Guest
		Private schedulerBindingDataSource1 As New SchedulerBindingDataSource()
'INSTANT VB NOTE: The variable appointmentMappingInfo was renamed since Visual Basic does not handle variables named the same as their type well:
		Private appointmentMappingInfo_Renamed As New AppointmentMappingInfo()

		Public Sub New()
			InitializeComponent()
			Me.searchPanel.RootElement.EnableElementShadow = False

			Me.backButton.ButtonElement.Text = ""
			Me.backButton.ButtonElement.CustomFont = "TelerikWebUI"
			Me.backButton.ButtonElement.CustomFontSize = 20
			Me.backButton.ButtonElement.ForeColor = Color.Gray
			Me.backButton.RootElement.EnableElementShadow = False
			Me.backButton.ButtonElement.Padding = New Padding(0)
			AddHandler Me.backButton.Click, AddressOf backButton_Click

			Me.roomIdLabel.RootElement.EnableElementShadow = False
			Me.roomIdLabel.LabelElement.CustomFont = Utils.MainFont
			Me.roomIdLabel.LabelElement.CustomFontSize = 15
			Me.roomIdLabel.LabelElement.CustomFontStyle = FontStyle.Regular

			Me.typeLabel.RootElement.EnableElementShadow = False
			Me.typeLabel.LabelElement.CustomFont = Utils.MainFont
			Me.typeLabel.LabelElement.CustomFontSize = 9
			Me.typeLabel.LabelElement.CustomFontStyle = FontStyle.Regular
			Me.typeLabel.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.typeLabel.LabelElement.LabelText.Margin = New Padding(10, 0, 0, 0)

			Me.statusLabel.RootElement.EnableElementShadow = False
			Me.statusLabel.LabelElement.CustomFont = Utils.MainFont
			Me.statusLabel.LabelElement.CustomFontSize = 15
			Me.statusLabel.LabelElement.CustomFontStyle = FontStyle.Regular

			Me.roomsScheduler.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month
			AddHandler Me.roomsScheduler.ActiveViewChanging, AddressOf roomsScheduler_ActiveViewChanging
			Me.roomsSchedulerNavigator.SchedulerNavigatorElement.ViewPanel.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			AddHandler Me.roomsScheduler.AppointmentFormatting, AddressOf radScheduler1_AppointmentFormatting
			AddHandler Me.roomsScheduler.AppointmentEditDialogShowing, AddressOf roomsScheduler_AppointmentEditDialogShowing
			AddHandler Me.roomsScheduler.AppointmentSelected, AddressOf roomsScheduler_AppointmentSelected

			AddHandler Me.roomsScheduler.CellSelectionChanged, AddressOf roomsScheduler_CellSelectionChanged
			Me.roomsScheduler.ShowAppointmentStatus = False
			Dim monthViewElement As SchedulerMonthViewElement = TryCast(Me.roomsScheduler.SchedulerElement.ViewElement, SchedulerMonthViewElement)
			monthViewElement.VerticalHeader.HeaderWidth = 50
			monthViewElement.Children(3).Visibility = ElementVisibility.Collapsed

			Me.guestHeaderPanel.RootElement.EnableElementShadow = False

			Me.closeButton.RootElement.EnableElementShadow = False
			Me.closeButton.ButtonElement.Padding = New Padding(0)
			Me.closeButton.ImageAlignment = ContentAlignment.TopRight
			Me.closeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.closeButton.Image = My.Resources.not_clean
			AddHandler Me.closeButton.Click, AddressOf closeButton_Click
			Me.guestHeaderLabel.RootElement.EnableElementShadow = False
			Me.guestHeaderLabel.LabelElement.CustomFont = Utils.MainFontMedium
			Me.guestHeaderLabel.LabelElement.CustomFontSize = 10.5f
			Me.guestHeaderLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)

			Me.guestNamePanel.RootElement.EnableElementShadow = False
			Me.guestNameLabel.RootElement.EnableElementShadow = False
			Me.roomIconLabel.RootElement.EnableElementShadow = False

			Me.guestNameLabel.LabelElement.CustomFont = Utils.MainFont
			Me.guestNameLabel.LabelElement.CustomFontSize = 15f
			Me.guestNameLabel.Image = My.Resources.edit
			Me.guestNameLabel.TextImageRelation = TextImageRelation.TextBeforeImage
			Me.guestNameLabel.LabelElement.LabelImage.Padding = New Padding(0, -3, 0, 0)
			Me.guestNameLabel.LabelElement.Padding = New Padding(5, 0, 0, 0)
			AddHandler Me.guestNameLabel.Click, AddressOf guestNameLabel_Click
			AddHandler Me.guestNameLabel.TextChanged, AddressOf guestNameLabel_TextChanged

			Me.guestSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.addGuestPanel.RootElement.EnableElementShadow = False
			Me.addGuestButton.RootElement.EnableElementShadow = False
			Me.addGuestLabel.RootElement.EnableElementShadow = False

			Me.addGuestLabel.LabelElement.CustomFont = Utils.MainFont
			Me.addGuestLabel.LabelElement.CustomFontSize = 10.5f
			Me.addGuestLabel.ForeColor = Utils.MainThemeColor
			Me.addGuestButton.Image = My.Resources.plus
			AddHandler Me.addGuestButton.Click, AddressOf addGuestButton_Click
			Me.addGuestButton.ButtonElement.ImagePrimitive.Margin = New Padding(-10, 0, 0, 0)

			Me.houseKeepingHeaderLabel.RootElement.EnableElementShadow = False
			Me.houseKeepingHeaderLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)

			Me.statusHeaderLabel.LabelElement.CustomFont = Utils.MainFont
			Me.statusHeaderLabel.LabelElement.CustomFontSize = 10.5f
			Me.statusHeaderLabel.RootElement.EnableElementShadow = False
			Me.statusHeaderLabel.LabelElement.LabelText.Margin = New Padding(7, 0, 0, 0)
			Me.statusDropDown.RootElement.EnableElementShadow = False
			Me.statusDropDown.DropDownListElement.ArrowButton.Margin = New Padding(0, 0, 20, 0)
			Me.statusDropDown.DropDownListElement.EditableElement.TextBox.Margin = New Padding(-5, 5, 0, 0)

			Me.priorityHeader.RootElement.EnableElementShadow = False
			Me.priorityHeader.LabelElement.LabelText.Margin = New Padding(5, 10, 0, 0)
			Me.priorityHeader.LabelElement.CustomFont = Utils.MainFont
			Me.priorityHeader.LabelElement.CustomFontSize = 10.5f
			Me.priorityHeader.TextAlignment = ContentAlignment.BottomLeft

			Me.priorityDropDown.DropDownListElement.EditableElement.TextBox.Margin = New Padding(-5, 5, 0, 0)
			Me.priorityDropDown.DropDownListElement.ArrowButton.Margin = New Padding(0, 0, 20, 0)
			Me.priorityDropDown.RootElement.EnableElementShadow = False
			Me.needsRepairsCheckBox.RootElement.EnableElementShadow = False
			Me.needsRepairsCheckBox.ButtonElement.Margin = New Padding(10, 0, 0, 0)

			Me.updateButton.Left = 10
			Me.updateButton.Top -= 5

			Me.statusSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.prioritySeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)

			Dim borderPrimitive_Renamed As BorderPrimitive = Me.priorityDropDown.DropDownListElement.FindDescendant(Of BorderPrimitive)()
			If borderPrimitive_Renamed IsNot Nothing Then
				borderPrimitive_Renamed.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
			borderPrimitive_Renamed = Me.statusDropDown.DropDownListElement.FindDescendant(Of BorderPrimitive)()
			If borderPrimitive_Renamed IsNot Nothing Then
				borderPrimitive_Renamed.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If

			AddHandler Me.statusDropDown.VisualListItemFormatting, AddressOf statusDropDown_VisualListItemFormatting
			Me.statusDropDown.DataSource = System.Enum.GetValues(GetType(HouseKeepingStatus))
			Me.priorityDropDown.DataSource = System.Enum.GetValues(GetType(RoomPriority))

			editGuestInfo_Renamed = New EditGuestInfo()
			editGuestInfo_Renamed.Dock = DockStyle.Fill
			AddHandler editGuestInfo_Renamed.VisibleChanged, AddressOf editGuestInfo_VisibleChanged
			Me.guestPanel.Controls.Add(editGuestInfo_Renamed)
			HideEditGuestForm()
		End Sub

		Private Sub roomsScheduler_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.editGuestInfo_Renamed.Visible = False
			Me.guestNameLabel.Text = String.Empty
			Me.addGuestButton.Enabled = True
		End Sub

		Private Sub guestNameLabel_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If String.IsNullOrEmpty(Me.guestNameLabel.Text) Then
				Me.addGuestButton.Visible = True
				Me.addGuestLabel.Visible = True
			Else
				Me.addGuestButton.Visible = False
				Me.addGuestLabel.Visible = False
			End If
		End Sub

		Private Sub roomsScheduler_AppointmentSelected(ByVal sender As Object, ByVal e As SchedulerAppointmentSelectedEventArgs)
			Me.editGuestInfo_Renamed.Visible = False
			If e.Appointment IsNot Nothing Then
				Dim b As Booking = TryCast(e.Appointment.DataItem, Booking)
				If b IsNot Nothing Then
					If b.Guests.Count > 0 Then
						Me.selectedGuest = b.Guests.First()
						Me.guestNameLabel.Text = b.Guests.First().Name
					End If

					Me.guestNamePanel.Visible = True
				Else
					Me.guestNamePanel.Visible = False
				End If
			Else
				Me.guestNameLabel.Text = String.Empty
				Me.addGuestButton.Enabled = True
			End If
		End Sub

		Private Sub roomsScheduler_ActiveViewChanging(ByVal sender As Object, ByVal e As SchedulerViewChangingEventArgs)
			If Not(TypeOf e.NewView Is SchedulerMonthView) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub roomsScheduler_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs)
			e.AppointmentEditDialog = New BookingEditAppointmentDialog(form.Guests)
		End Sub

		Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.guestPanel.Visible = False
		End Sub

		Private Sub guestNameLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
			If booking_Renamed IsNot Nothing Then
				ShowEditGuestForm()
				editGuestInfo_Renamed.Initialize(Me.selectedGuest, booking_Renamed)
			End If
		End Sub

		Private Sub editGuestInfo_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not editGuestInfo_Renamed.Visible Then
				HideEditGuestForm()
				FilterBookings(room_Renamed)
			End If
		End Sub

		Private Sub addGuestButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			ShowEditGuestForm()
			Dim selectedInterval As DateTimeInterval = Me.roomsScheduler.SelectionBehavior.GetSelectedInterval()
			If selectedInterval IsNot DateTimeInterval.Empty Then
				Dim start As Date = selectedInterval.Start
				Dim [end] As Date = selectedInterval.End
				booking_Renamed = New Booking() With {.From = start, .To = [end], .RoomId = Me.room_Renamed.Id}
				booking_Renamed.PricePerDay = Me.room_Renamed.PricePerDay
				booking_Renamed.Status = BookingStatus.Reservation
				editGuestInfo_Renamed.Initialize(New Guest(), booking_Renamed)
			End If
		End Sub

		Private Sub ShowEditGuestForm()
			Me.ManageVisible(False)
			Me.editGuestInfo_Renamed.Visible = True
		End Sub

		Private Sub ManageVisible(ByVal visible As Boolean)
			For Each c As Control In Me.guestPanel.Controls
				If Not(TypeOf c Is EditGuestInfo) Then
					If visible AndAlso booking_Renamed Is Nothing AndAlso c Is Me.guestNamePanel Then
						Continue For
					End If

					c.Visible = visible
				End If
			Next c
		End Sub

		Private Sub HideEditGuestForm()
			ManageVisible(True)
			editGuestInfo_Renamed.Visible = False
			Me.guestNamePanel.Visible = True
			If Me.booking_Renamed IsNot Nothing Then
				Me.selectedGuest = Me.booking_Renamed.Guests.FirstOrDefault()
				Me.guestNameLabel.Text = Me.selectedGuest.Name
			ElseIf editGuestInfo_Renamed.CurrentGuest IsNot Nothing Then
				Me.guestNameLabel.Text = Me.editGuestInfo_Renamed.CurrentGuest.Name
			End If
		End Sub

		Private Sub statusDropDown_VisualListItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
			args.VisualItem.Text = Utils.GetHouseKeepingStatus(CType(args.VisualItem.Data.DataBoundItem, HouseKeepingStatus))
		End Sub

		Private Sub radScheduler1_AppointmentFormatting(ByVal sender As Object, ByVal e As SchedulerAppointmentEventArgs)
			e.AppointmentElement.BackColor = Color.FromArgb(209, 209, 209)
			e.AppointmentElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			e.AppointmentElement.BorderColor = Color.FromArgb(209, 209, 209)
			e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
			e.AppointmentElement.ForeColor = Color.Black
			e.AppointmentElement.CustomFont = Utils.MainFont
			e.AppointmentElement.CustomFontSize = 9f
			e.AppointmentElement.DisableHTMLRendering = False
			e.AppointmentElement.TextAlignment = ContentAlignment.MiddleCenter
		End Sub

		Private Sub backButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Visible = False
			If form IsNot Nothing Then
				If comingFrom = "Booking" Then
					form.PageView.SelectedPage = form.PageView.Pages(1)
				ElseIf comingFrom = "Schedule" Then
					form.PageView.SelectedPage = form.PageView.Pages(2)
				End If
				form.NavigationPanel.Visible = True
				form.RoomsListView.ListViewElement.SynchronizeVisualItems()
			End If
		End Sub

		Friend Sub InitializeData(ByVal room_Renamed As Room, ByVal booking_Renamed As Booking, ByVal comingFrom As String)
			Me.guestPanel.Visible = True
			Me.room_Renamed = room_Renamed
			Me.booking_Renamed = booking_Renamed
			Me.selectedGuest = If(booking_Renamed Is Nothing, Nothing, booking_Renamed.Guests.FirstOrDefault())
			Me.form = TryCast(Me.FindForm(), HotelAppForm)
			Me.roomDetailsSearchDropDown.Inialize(form.Rooms, form.Bookings)
			Me.comingFrom = comingFrom
			Me.roomIdLabel.Text = "Room # " & room_Renamed.Id
			Me.typeLabel.Text = room_Renamed.Type.ToString()
			Me.typeLabel.Image = Utils.GetImageByRoomType(room_Renamed.Type)
			Me.statusLabel.Text = "Status now: " & room_Renamed.Status.ToString()
			Me.roomIconLabel.Image = Me.typeLabel.Image
			Me.roomIconLabel.LabelElement.LabelImage.Margin = New Padding(40, 0, 0, 0)
			Me.statusDropDown.SelectedValue = room_Renamed.HouseKeepingStatus
			Me.priorityDropDown.SelectedValue = room_Renamed.Priority
			Me.needsRepairsCheckBox.Checked = room_Renamed.NeedsRepairs
			If form IsNot Nothing Then
				appointmentMappingInfo_Renamed.End = "To"
				appointmentMappingInfo_Renamed.Start = "From"
				appointmentMappingInfo_Renamed.Summary = "Name"
				appointmentMappingInfo_Renamed.BackgroundId = "Status"
				schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo_Renamed
				schedulerBindingDataSource1.EventProvider.DataSource = form.Bookings

				Me.roomsScheduler.DataSource = schedulerBindingDataSource1
				Me.roomsScheduler.ShowAppointmentStatus = False

				FilterBookings(room_Renamed)

				Me.roomsScheduler.ActiveView.AppointmentTitleFormat = "{2}"

				Me.roomsScheduler.Backgrounds.Clear()

				Dim reservationBackgroundInfo As New AppointmentBackgroundInfo(1, "Reservation", Color.Yellow, Color.Yellow)
				reservationBackgroundInfo.ShadowWidth = 0
				Me.roomsScheduler.Backgrounds.Add(reservationBackgroundInfo)
				Dim actualBackgroundInfo As New AppointmentBackgroundInfo(2, "Actual", Color.Green, Color.Green)
				actualBackgroundInfo.ShadowWidth = 0
				Me.roomsScheduler.Backgrounds.Add(actualBackgroundInfo)
				Dim cancelledBackgroundInfo As New AppointmentBackgroundInfo(3, "Cancelled", Color.OrangeRed, Color.OrangeRed)
				cancelledBackgroundInfo.ShadowWidth = 0
				Me.roomsScheduler.Backgrounds.Add(cancelledBackgroundInfo)
				Dim checkedOutBackgroundInfo As New AppointmentBackgroundInfo(4, "CheckedOut", Color.Orange, Color.Orange)
				checkedOutBackgroundInfo.ShadowWidth = 0
				Me.roomsScheduler.Backgrounds.Add(checkedOutBackgroundInfo)
				Dim noShowBackgroundInfo As New AppointmentBackgroundInfo(5, "NoShow", Utils.MainThemeColor, Utils.MainThemeColor)
				noShowBackgroundInfo.ShadowWidth = 0
				Me.roomsScheduler.Backgrounds.Add(noShowBackgroundInfo)
			End If

			If booking_Renamed IsNot Nothing Then
				If booking_Renamed.Guests.Count > 0 Then
					Me.guestNameLabel.Text = booking_Renamed.Guests.First().Name
				End If

				Me.guestNamePanel.Visible = True
			Else
				Me.guestNamePanel.Visible = False
			End If
			Me.roomsScheduler.SchedulerElement.RefreshViewElement()
		End Sub

		Private Sub FilterBookings(ByVal room_Renamed As Room)
			Me.roomsScheduler.Appointments.BeginUpdate()
			For Each a As Appointment In Me.roomsScheduler.Appointments
				Dim b As Booking = TryCast(a.DataItem, Booking)
				If b Is Nothing Then
					a.Visible = False
					Continue For
				End If
				If b.RoomId <> room_Renamed.Id Then
					a.Visible = False
				Else
					a.Visible = True
				End If
			Next a
			Me.roomsScheduler.Appointments.EndUpdate()
		End Sub

		Private Sub updateButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles updateButton.Click
			Me.room_Renamed.Priority = CType(Me.priorityDropDown.SelectedValue, RoomPriority)
			Me.room_Renamed.HouseKeepingStatus = CType(Me.statusDropDown.SelectedValue, HouseKeepingStatus)

			If Me.booking_Renamed Is Nothing AndAlso Me.editGuestInfo_Renamed.CurrentGuest IsNot Nothing Then
				Dim timeDuration As TimeSpan = Me.roomsScheduler.SelectionBehavior.GetCellDuration()
				Dim form As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
				Dim bookingDuration As New DateTimeInterval(Me.roomsScheduler.SelectionBehavior.SelectionStartDate, Me.roomsScheduler.SelectionBehavior.SelectionEndDate)
				If bookingDuration IsNot DateTimeInterval.Empty Then
					Dim newBooking As New Booking(CUInt(form.Bookings.Count), editGuestInfo_Renamed.CurrentGuest, Me.room_Renamed.Id, Me.roomsScheduler.SelectionBehavior.SelectionStartDate, Me.roomsScheduler.SelectionBehavior.SelectionEndDate.AddDays(1), Me.room_Renamed.PricePerDay * bookingDuration.Duration.Days, BookingStatus.Reservation)
					form.Bookings.Add(newBooking)
				End If
			End If

			If booking_Renamed IsNot Nothing Then
				schedulerBindingDataSource1.EventProvider.DataSource = form.Bookings
				FilterBookings(room_Renamed)
			End If
		End Sub
	End Class
End Namespace