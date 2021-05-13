Imports HotelApp.Data
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace HotelApp
	Partial Friend Class HotelAppForm
		#Region "Initialization"
		Private Sub InitReportsPage()
			Me.reportsHeaderPanel.BackgroundImage = My.Resources.fasha_no_borders_fullsize
			Me.reportsHeaderPanel.BackgroundImageLayout = ImageLayout.Stretch
			Me.reportsHeaderPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.reportsHeaderPanel.PanelElement.Visibility = ElementVisibility.Collapsed

			Me.ReportsPage.BackgroundImage = My.Resources.Background
			Me.ReportsPage.BackgroundImageLayout = ImageLayout.Stretch
			Me.ReportsPage.BackColor = Color.Transparent
			Me.reportsHeaderPanel.RootElement.EnableElementShadow = False
			Me.reportsStatusPanel.RootElement.EnableElementShadow = False
			Me.reportsTypePanel.RootElement.EnableElementShadow = False
			Me.reportsBookingsByTypeLabel.RootElement.EnableElementShadow = False
			Me.reportsCurrentStatusLabel.RootElement.EnableElementShadow = False

			Me.reportsStatusPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.reportsStatusPanel.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.reportsTypePanel.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.reportsTypePanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.reportsCurrentStatusLabel.LabelElement.CustomFont = Utils.MainFont
			Me.reportsCurrentStatusLabel.LabelElement.CustomFontSize = 15f
			Me.reportsCurrentStatusLabel.LabelElement.LabelText.Margin = New Padding(18, 0, 0, 0)
			Me.reportsCurrentStatusLabel.TextAlignment = ContentAlignment.BottomLeft
			Me.reportsBookingsByTypeLabel.LabelElement.CustomFont = Utils.MainFont
			Me.reportsBookingsByTypeLabel.LabelElement.CustomFontSize = 15f
			Me.reportsBookingsByTypeLabel.LabelElement.LabelText.Margin = New Padding(18, 0, 0, 0)
			Me.reportsBookingsByTypeLabel.TextAlignment = ContentAlignment.BottomLeft

			Me.userControlCurrentStatus1.Padding = New Padding(20, 0, 20, 0)
			Me.userControlBookingsByType1.Padding = New Padding(20, 0, 20, 20)

			AddHandler Me.reportsDaysToggleButton.ToggleStateChanged, AddressOf reportsDaysToggleButton_ToggleStateChanged
			AddHandler Me.reportsWeeklyToggleButton.ToggleStateChanged, AddressOf reportsWeeklyToggleButton_ToggleStateChanged
			AddHandler Me.reportsMonthlyToggleButton.ToggleStateChanged, AddressOf reportsMonthlyToggleButton_ToggleStateChanged

			AddHandler Me.reportsDateNavigator.DateTimePicker.ValueChanged, AddressOf ReportsDateTimePicker_ValueChanged
		End Sub

		#End Region

		#Region "Events"
		Private Sub ReportsDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.userControlCurrentStatus1.Initialize(reportsInterval, Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
			Me.userControlBookingsByType1.Initialize(reportsInterval, Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
		End Sub

		Private Sub reportsMonthlyToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				reportsInterval = "Monthly"
				Me.reportsDaysToggleButton.ToggleState = ToggleState.Off
				Me.reportsWeeklyToggleButton.ToggleState = ToggleState.Off
				Me.userControlCurrentStatus1.Initialize("Monthly", Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
				Me.userControlBookingsByType1.Initialize("Monthly", Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
			End If
		End Sub

		Private Sub reportsWeeklyToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				reportsInterval = "Weekly"
				Me.reportsDaysToggleButton.ToggleState = ToggleState.Off
				Me.reportsMonthlyToggleButton.ToggleState = ToggleState.Off
				Me.userControlCurrentStatus1.Initialize("Weekly", Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
				Me.userControlBookingsByType1.Initialize("Weekly", Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
			End If
		End Sub

		Private Sub reportsDaysToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				reportsInterval = "Days"
				Me.reportsWeeklyToggleButton.ToggleState = ToggleState.Off
				Me.reportsMonthlyToggleButton.ToggleState = ToggleState.Off
				Me.userControlCurrentStatus1.Initialize("Days", Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
				Me.userControlBookingsByType1.Initialize("Days", Me.Bookings, Me.Rooms, Me.reportsDateNavigator.CurrentDate)
			End If
		End Sub

		#End Region
	End Class
End Namespace
