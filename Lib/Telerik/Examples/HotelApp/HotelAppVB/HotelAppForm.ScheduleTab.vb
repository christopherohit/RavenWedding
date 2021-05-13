Imports CustomControls
Imports HotelApp.Data
Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace HotelApp
	Partial Friend Class HotelAppForm
		#Region "Initialization"
		Private Sub InitSchedulePage()
			Me.scheduleRadSchedulerHeader.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.scheduleHeaderPanel.BackgroundImage = My.Resources.fasha_no_borders
			Me.scheduleHeaderPanel.BackgroundImageLayout = ImageLayout.Stretch
			Me.scheduleHeaderPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed

			Me.scheduleHeaderPanel.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.scheduleHeaderPanel.PanelElement.PanelFill.GradientStyle = GradientStyles.Solid
			Me.scheduleSearchPanel.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.scheduleSearchPanel.BackColor = Color.Transparent
			Me.scheduleSearchPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed

			Me.scheduleSearchDropDown.Inialize(Me.Rooms, Me.Bookings)
			Me.scheduleListView.ShowGroups = True
			Me.scheduleListView.EnableGrouping = True
			Me.scheduleListView.EnableCustomGrouping = True
			Me.scheduleListView.ListViewElement.Padding = New Padding(0, 16, 0, 0)
			Dim scheduleStatusGroup As New ListViewDataItemGroup()
			scheduleStatusGroup.Text = "STATUS"
			Dim scheduleTypesGroup As New ListViewDataItemGroup()
			scheduleTypesGroup.Text = "TYPE"
			Me.scheduleListView.ShowCheckBoxes = True
			Me.scheduleListView.Groups.AddRange(New ListViewDataItemGroup() { scheduleStatusGroup, scheduleTypesGroup })

			Dim scheduleStatusOptions As Array = System.Enum.GetValues(GetType(RoomStatus))
			For Each item As Object In scheduleStatusOptions
				Dim statusItem As New ListViewDataItem(item.ToString())
				statusItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
				Me.scheduleListView.Items.Add(statusItem)
				statusItem.Group = scheduleStatusGroup
			Next item

			Dim roomOptions As Array = System.Enum.GetValues(GetType(RoomType))
			For Each item As Object In roomOptions
				Dim roomTypeItem As New ListViewDataItem(Utils.GetRoomType(CType(item, RoomType)))
				roomTypeItem.Value = CType(item, RoomType)
				roomTypeItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
				roomTypeItem.Group = scheduleTypesGroup
				Me.scheduleListView.Items.Add(roomTypeItem)
			Next item

			AddHandler Me.scheduleDateNavigator.DateTimePicker.ValueChanged, AddressOf SchedulerDateTimePicker_ValueChanged
			Me.ScheduleRadScheduler.AppointmentTitleFormat = "{2}"
			Me.ScheduleRadScheduler.ElementProvider = New MyElementProvider(Me.ScheduleRadScheduler)
			Me.scheduleDaysButton.ButtonElement.CustomFont = Utils.MainFontMedium
			Me.scheduleDaysButton.ButtonElement.CustomFontSize = 10.5f
			Me.scheduleWeeklyButton.ButtonElement.CustomFont = Utils.MainFontMedium
			Me.scheduleWeeklyButton.ButtonElement.CustomFontSize = 10.5f
			Me.scheduleMonthlyButton.ButtonElement.CustomFont = Utils.MainFontMedium
			Me.scheduleMonthlyButton.ButtonElement.CustomFontSize = 10.5f

			AddHandler Me.scheduleDaysButton.ToggleStateChanged, AddressOf scheduleDaysButton_ToggleStateChanged
			AddHandler Me.scheduleWeeklyButton.ToggleStateChanged, AddressOf scheduleWeeklyButton_ToggleStateChanged
			AddHandler Me.scheduleMonthlyButton.ToggleStateChanged, AddressOf scheduleMonthlyButton_ToggleStateChanged

			Me.ScheduleRadScheduler.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Timeline, 0)
			Me.scheduleDaysButton.ToggleState = ToggleState.On
			Me.scheduleRadSchedulerHeader.TextAlignment = ContentAlignment.MiddleCenter

			Me.scheduleRadSchedulerHeader.ForeColor = Color.White
			Me.scheduleRadSchedulerHeader.PanelElement.CustomFont = Utils.MainFont
			Me.scheduleRadSchedulerHeader.PanelElement.CustomFontSize = 15f

			Me.scheduleHeaderPanel.RootElement.EnableElementShadow = False
			Me.scheduleSearchPanel.RootElement.EnableElementShadow = False
			Me.scheduleListView.RootElement.EnableElementShadow = False
			Me.ScheduleRadScheduler.RootElement.EnableElementShadow = False
			Me.scheduleBookingPanel.RootElement.EnableElementShadow = False

			Me.scheduleBookingPanel.Visible = False
			AddHandler Me.ScheduleRadScheduler.MouseClick, AddressOf ScheduleRadScheduler_MouseClick

			AddHandler Me.ScheduleRadScheduler.AppointmentFormatting, AddressOf ScheduleRadScheduler_AppointmentFormatting
			AddHandler Me.ScheduleRadScheduler.CellFormatting, AddressOf ScheduleRadScheduler_CellFormatting

			AddHandler Me.ScheduleRadScheduler.AppointmentEditDialogShowing, AddressOf ScheduleRadScheduler_AppointmentEditDialogShowing
			AddHandler Me.ScheduleRadScheduler.AppointmentChanged, AddressOf ScheduleRadScheduler_AppointmentChanged
			Dim scheduleSource As New SchedulerBindingDataSource()
			Dim appointmentMappingInfo_Renamed As New AppointmentMappingInfo()
			appointmentMappingInfo_Renamed.End = "To"
			appointmentMappingInfo_Renamed.Start = "From"
			appointmentMappingInfo_Renamed.Summary = "Name"
			appointmentMappingInfo_Renamed.ResourceId = "RoomId"
			appointmentMappingInfo_Renamed.BackgroundId = "Status"

			appointmentMappingInfo_Renamed.FindBySchedulerProperty("ResourceId").ConvertToScheduler = AddressOf ConvertTo
			appointmentMappingInfo_Renamed.FindBySchedulerProperty("ResourceId").ConvertToDataSource = AddressOf ConvertFrom
			scheduleSource.EventProvider.Mapping = appointmentMappingInfo_Renamed
			scheduleSource.EventProvider.DataSource = Me.Bookings
			Dim resourceMappingInfo_Renamed As New ResourceMappingInfo()
			resourceMappingInfo_Renamed.Id = "Id"
			resourceMappingInfo_Renamed.Name = "Name"
			scheduleSource.ResourceProvider.Mapping = resourceMappingInfo_Renamed

			Dim scheduleRoomsCopy As New BindingList(Of Room)()
			For Each r As Room In Me.Rooms
				scheduleRoomsCopy.Add(New Room(r.Id, r.Status, r.Type, r.HouseKeepingStatus, r.NeedsRepairs, r.PricePerDay))
			Next r
			scheduleSource.ResourceProvider.DataSource = scheduleRoomsCopy

			Me.ScheduleRadScheduler.DataSource = scheduleSource

			Me.ScheduleRadScheduler.Backgrounds.Clear()

			Dim reservationBackgroundInfo As New AppointmentBackgroundInfo(1, "Reservation", Color.Yellow, Color.Yellow)
			reservationBackgroundInfo.ShadowWidth = 0
			Me.ScheduleRadScheduler.Backgrounds.Add(reservationBackgroundInfo)
			Dim actualBackgroundInfo As New AppointmentBackgroundInfo(2, "Actual", Color.Green, Color.Green)
			actualBackgroundInfo.ShadowWidth = 0
			Me.ScheduleRadScheduler.Backgrounds.Add(actualBackgroundInfo)
			Dim cancelledBackgroundInfo As New AppointmentBackgroundInfo(3, "Cancelled", Color.OrangeRed, Color.OrangeRed)
			cancelledBackgroundInfo.ShadowWidth = 0
			Me.ScheduleRadScheduler.Backgrounds.Add(cancelledBackgroundInfo)
			Dim checkedOutBackgroundInfo As New AppointmentBackgroundInfo(4, "CheckedOut", Color.Orange, Color.Orange)
			checkedOutBackgroundInfo.ShadowWidth = 0
			Me.ScheduleRadScheduler.Backgrounds.Add(checkedOutBackgroundInfo)
			Dim noShowBackgroundInfo As New AppointmentBackgroundInfo(5, "NoShow", Utils.MainThemeColor, Utils.MainThemeColor)
			noShowBackgroundInfo.ShadowWidth = 0
			Me.ScheduleRadScheduler.Backgrounds.Add(noShowBackgroundInfo)

			Me.ScheduleRadScheduler.GroupType = GroupType.Resource
			Me.ScheduleRadScheduler.ShowAppointmentStatus = False
			For Each r As Resource In Me.ScheduleRadScheduler.Resources
				r.Color = Color.White
			Next r
			AddHandler Me.ScheduleRadScheduler.ActiveViewChanged, AddressOf ScheduleRadScheduler_ActiveViewChanged
			Me.ScheduleRadScheduler.SchedulerElement.RefreshViewElement()
			Me.ScheduleRadScheduler.ActiveView.ResourcesPerView = 5
			Dim timelineElement As TimelineGroupingByResourcesElement = TryCast(Me.ScheduleRadScheduler.SchedulerElement.ViewElement, TimelineGroupingByResourcesElement)
			For Each timelineViewElement As SchedulerTimelineViewElement In timelineElement.GetChildViewElements()
				timelineViewElement.ViewHeaderHeight = 0
			Next timelineViewElement
			timelineElement.ResourceHeaderWidth = 80
			timelineElement.View.GroupSeparatorWidth = 0
			AddHandler Me.ScheduleRadScheduler.AppointmentAdded, AddressOf ScheduleRadScheduler_AppointmentAdded
			Me.ScheduleRadScheduler.GetTimelineView().GetTimescale(Timescales.Days).Format = "dd MMM"

			Me.ScheduleRadScheduler.Culture = culture
		End Sub
		#End Region

		#Region "Events"
		Private Sub ScheduleRadScheduler_AppointmentChanged(ByVal sender As Object, ByVal e As AppointmentChangedEventArgs)
			Dim b As Booking = TryCast(e.Appointment.DataItem, Booking)
			If b IsNot Nothing Then
				Me.scheduleBookingInfo.LoadBookingInfo(b, Me.Rooms)
			End If
		End Sub

		Private Sub ScheduleRadScheduler_AppointmentAdded(ByVal sender As Object, ByVal e As AppointmentAddedEventArgs)
			Dim guest_Renamed As Guest = TryCast(Me.ScheduleRadScheduler.Tag, Guest)
			Dim b As Booking = TryCast(e.Appointment.DataItem, Booking)
			If b IsNot Nothing Then
				If guest_Renamed IsNot Nothing Then
					Me.ScheduleRadScheduler.Tag = Nothing

					If guest_Renamed IsNot Nothing Then
						b.Guests.Clear()
						b.Guests.Add(guest_Renamed)
						b.Name = guest_Renamed.Name
					End If
				Else
					b.Guests = New List(Of Guest)()
				End If
			End If
		End Sub

		Private Sub ScheduleRadScheduler_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs)
			e.AppointmentEditDialog = New BookingEditAppointmentDialog(Me.Guests)
		End Sub

		Private Sub scheduleSearchDropDown_SelectedIndexChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs)
			If e.Position > -1 Then
				Me.PageView.SelectedPage = Me.OverviewPage
				Me.searchTextBoxOverview.Text = Me.scheduleSearchDropDown.Text
			End If
		End Sub

		Private Sub SchedulerDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.BookingsDate <> Me.scheduleDateNavigator.DateTimePicker.Value AndAlso Me.OverviewDate <> Me.scheduleDateNavigator.DateTimePicker.Value Then
                Me.BookingsDate = Me.scheduleDateNavigator.DateTimePicker.Value
                Me.OverviewDate = Me.scheduleDateNavigator.DateTimePicker.Value
            End If
			Me.ScheduleRadScheduler.FocusedDate = Me.scheduleDateNavigator.CurrentDate
			Me.scheduleListView.ListViewElement.SynchronizeVisualItems()
		End Sub

		Private Sub ScheduleRadScheduler_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			Me.scheduleDateNavigator.DateTimePicker.Value = e.NewView.StartDate
			RefreshView()
		End Sub

		Private Sub ScheduleRadScheduler_AppointmentFormatting(ByVal sender As Object, ByVal e As SchedulerAppointmentEventArgs)
			e.AppointmentElement.BackColor = Color.FromArgb(209, 209, 209)
			e.AppointmentElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			e.AppointmentElement.NumberOfColors = 4
			e.AppointmentElement.BorderColor = Color.FromArgb(209, 209, 209)
			e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
			e.AppointmentElement.ForeColor = Color.Black

			Dim b As Booking = TryCast(e.Appointment.DataItem, Booking)
			If b IsNot Nothing Then
				Dim duration As TimeSpan = b.To.Subtract(b.From)
				e.AppointmentElement.Text = b.Name & " - " & duration.TotalDays & " day"
				If duration.TotalDays > 1 Then
					e.AppointmentElement.Text &= "s"
				End If
				e.AppointmentElement.DisableHTMLRendering = True
				e.AppointmentElement.CustomFont = Utils.MainFont
				e.AppointmentElement.CustomFontSize = 9f
				e.AppointmentElement.TextAlignment = ContentAlignment.MiddleCenter
			End If
		End Sub

		Private Sub RefreshView()
			Dim monthView As SchedulerMonthViewGroupedByResourceElement = TryCast(Me.ScheduleRadScheduler.SchedulerElement.ViewElement, SchedulerMonthViewGroupedByResourceElement)
			Dim timelineElement As TimelineGroupingByResourcesElement = TryCast(Me.ScheduleRadScheduler.SchedulerElement.ViewElement, TimelineGroupingByResourcesElement)
			If monthView Is Nothing AndAlso timelineElement Is Nothing Then
				Return
			End If
			Me.ScheduleRadScheduler.ActiveView.ResourcesPerView = 5
			If monthView IsNot Nothing Then
				monthView.ResourceHeaderHeight = 100
				monthView.DrawBorder = False
				monthView.ResourcesHeader.DrawBorder = False
				Me.ScheduleRadScheduler.ActiveView.ResourcesPerView = 2
				For Each view As RadElement In monthView.Children
					Dim monthViewElement As SchedulerMonthViewElement = TryCast(view, SchedulerMonthViewElement)
					If monthViewElement IsNot Nothing Then
						monthViewElement.VerticalHeader.HeaderWidth = 50
						monthViewElement.Children(3).Visibility = ElementVisibility.Collapsed
						monthViewElement.DrawBorder = False
					End If
				Next view
			ElseIf timelineElement IsNot Nothing Then
				For Each timelineViewElement As SchedulerTimelineViewElement In timelineElement.GetChildViewElements()
					timelineViewElement.ViewHeaderHeight = 0
				Next timelineViewElement
				timelineElement.ResourceHeaderWidth = 80
			End If
		End Sub


		Private Sub ScheduleRadScheduler_CellFormatting(ByVal sender As Object, ByVal e As SchedulerCellEventArgs)
			e.CellElement.ZIndex = 0
			e.CellElement.Visibility = ElementVisibility.Visible
			If e.CellElement.VisualState.Contains("CornerHeaderCell2") Then
				e.CellElement.Visibility = ElementVisibility.Collapsed
			End If
			e.CellElement.Opacity = 1
			If (e.CellElement.VisualState = "ResourceCell" AndAlso e.CellElement.Scheduler.ActiveViewType <> SchedulerViewType.Month) OrElse e.CellElement.VisualState = "MonthViewHeaderCellElement.IsVertical" Then
				e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
				e.CellElement.BorderLeftWidth = 0
				e.CellElement.BorderTopWidth = 1
				e.CellElement.BorderTopColor = Color.FromArgb(209, 209, 209)
				e.CellElement.BorderRightWidth = 1
				e.CellElement.BorderRightColor = Color.FromArgb(209, 209, 209)
				e.CellElement.BorderBottomWidth = 0
				e.CellElement.ForeColor = Color.Black
			Else
				e.CellElement.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderLeftWidthProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderTopWidthProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderTopColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderRightWidthProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderRightColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderBottomWidthProperty, ValueResetFlags.Local)
			End If

			If Not(TypeOf e.CellElement Is SchedulerHeaderCellElement OrElse TypeOf e.CellElement Is SchedulerResourceHeaderCellElement OrElse e.CellElement.Date.Year = 1980) Then
				e.CellElement.BackColor = Color.FromArgb(244, 244, 244)
				e.CellElement.DrawFill = True
				e.CellElement.GradientStyle = GradientStyles.Solid
			Else
				e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Sub scheduleMonthlyButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.scheduleRadSchedulerHeader.Text = "Monthly"
				Me.scheduleDaysButton.ToggleState = ToggleState.Off
				Me.scheduleWeeklyButton.ToggleState = ToggleState.Off
				Me.ScheduleRadScheduler.ActiveViewType = SchedulerViewType.Month
			End If
		End Sub

		Private Sub scheduleWeeklyButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.scheduleRadSchedulerHeader.Text = "Weekly"
				Me.scheduleDaysButton.ToggleState = ToggleState.Off
				Me.scheduleMonthlyButton.ToggleState = ToggleState.Off
				Me.ScheduleRadScheduler.ActiveViewType = SchedulerViewType.Timeline
				Me.ScheduleRadScheduler.GetTimelineView().GetScaling().DisplayedCellsCount = 7
			End If
		End Sub

		Private Sub scheduleDaysButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.scheduleRadSchedulerHeader.Text = "3 Days"
				Me.scheduleWeeklyButton.ToggleState = ToggleState.Off
				Me.scheduleMonthlyButton.ToggleState = ToggleState.Off
				Me.ScheduleRadScheduler.ActiveViewType = SchedulerViewType.Timeline
				Me.ScheduleRadScheduler.GetTimelineView().GetScaling().DisplayedCellsCount = 3
			End If
		End Sub

		Private Sub ScheduleRadScheduler_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim clickedAppointment As AppointmentElement = TryCast(Me.ScheduleRadScheduler.ElementTree.GetElementAtPoint(e.Location), AppointmentElement)

			If clickedAppointment IsNot Nothing Then
				Dim b As Booking = TryCast(clickedAppointment.Appointment.DataItem, Booking)
				If b IsNot Nothing Then
					Me.scheduleBookingInfo.LoadBookingInfo(b, Me.Rooms)
					Me.scheduleBookingPanel.Visible = True
				End If
			End If
		End Sub
		#End Region
	End Class
End Namespace
