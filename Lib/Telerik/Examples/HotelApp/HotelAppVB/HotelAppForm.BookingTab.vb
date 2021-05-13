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

		Private Sub InitBookingsPage()
			Me.bookingsMainContainer.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.navigationPanelBookings.BackgroundImage = My.Resources.fasha_no_borders
			Me.navigationPanelBookings.BackgroundImageLayout = ImageLayout.Stretch
			Me.navigationPanelBookings.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed

			Me.navigationPanelBookings.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.navigationPanelBookings.PanelElement.PanelFill.GradientStyle = GradientStyles.Solid
			Me.searchContainerBookings.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.searchContainerBookings.BackColor = Color.Transparent
			Me.searchContainerBookings.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.radPanelEmptyBooking.PanelElement.PanelFill.BackColor = Color.Transparent
			Me.radPanelEmptyBooking.BackColor = Color.Transparent
			Me.radPanelEmptyBooking.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed

			Me.bookingInfoRightPanel.RootElement.EnableElementShadow = False
			Me.bookingInfoRightPanel.Visible = False
			Me.editGuestInfo_Renamed.Visible = False

			Me.bookingsGrid.MasterTemplate.Tag = Rooms
			Me.bookingsGrid.TableElement.CellSpacing = 10
			Me.bookingsGrid.RootElement.EnableElementShadow = False
			Me.bookingsGrid.GridViewElement.DrawFill = False
			Me.bookingsGrid.TableElement.Margin = New Padding(15, 0, 15, 0)
			Me.bookingsGrid.BackColor = Color.Transparent
			Me.bookingsGrid.GridViewElement.DrawFill = True
			Me.bookingsGrid.AllowAddNewRow = False
			Me.bookingsGrid.EnableGrouping = False

			Me.bookingsGrid.DataSource = GetBookingsByDate(Me.bookings_Renamed, dateNavigatorBookings.CurrentDate)
			Me.bookingsGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.bookingsGrid.Columns("Id").IsVisible = False
			Me.bookingsGrid.Columns("Price").IsVisible = False
			Me.bookingsGrid.Columns("PricePerDay").IsVisible = False
			Me.bookingsGrid.Columns("Status").IsVisible = False
			Me.bookingsGrid.Columns("Guests").IsVisible = False
			Me.bookingsGrid.Columns("FullInfo").IsVisible = False
			Me.bookingsGrid.Columns("Name").Width = 310
			Me.bookingsGrid.Columns("RoomId").Width = 230
			Me.bookingsGrid.Columns("RoomId").HeaderText = "Room"
			Me.bookingsGrid.Columns("RoomId").TextAlignment = ContentAlignment.MiddleLeft
			For Each col As GridViewDataColumn In Me.bookingsGrid.Columns
				col.HeaderTextAlignment = ContentAlignment.MiddleLeft
			Next col

			Dim fromColumn As GridViewDateTimeColumn = TryCast(Me.bookingsGrid.Columns("From"), GridViewDateTimeColumn)
			fromColumn.Format = DateTimePickerFormat.Custom
			fromColumn.CustomFormat = "dd.MM.yyyy"
			fromColumn.FormatString = "{0:dd.MM.yyyy}"
			fromColumn.Width = 220
			fromColumn.TextAlignment = ContentAlignment.MiddleLeft

			Dim toColumn As GridViewDateTimeColumn = TryCast(Me.bookingsGrid.Columns("To"), GridViewDateTimeColumn)
			toColumn.Format = DateTimePickerFormat.Custom
			toColumn.CustomFormat = "dd.MM.yyyy"
			toColumn.FormatString = "{0:dd.MM.yyyy}"
			toColumn.Width = 180
			toColumn.TextAlignment = ContentAlignment.MiddleLeft

			Me.labelBookings.LabelElement.Margin = New Padding(12, 0, 0, 0)
			Me.labelBookings.LabelElement.LabelText.Margin = New Padding(0, 0, 0, 5)
			Me.labelBookings.LabelElement.CustomFont = Utils.MainFont
			Me.labelBookings.LabelElement.CustomFontSize = 15

			bookingsLeftView.ShowGroups = True
			bookingsLeftView.EnableGrouping = True
			bookingsLeftView.EnableCustomGrouping = True
			Dim statusGroup As New ListViewDataItemGroup()
			statusGroup.Text = "STATUS"

			Me.bookingsLeftView.ShowCheckBoxes = True
			Me.bookingsLeftView.Groups.AddRange(New ListViewDataItemGroup() { statusGroup })
			Me.bookingsLeftView.ListViewElement.Padding = New Padding(0, 16, 0, 0)

			Dim statusOptions As Array = System.Enum.GetValues(GetType(BookingStatus))
			For Each item As Object In statusOptions
				Dim statusItem As New ListViewDataItem(item.ToString())
				statusItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
				Me.bookingsLeftView.Items.Add(statusItem)
				statusItem.Group = statusGroup
			Next item

			Me.bookingsGrid.ReadOnly = True
			Me.bookingsGrid.EnableFiltering = True
			Me.bookingsGrid.EnableCustomFiltering = True
			Me.bookingsGrid.ShowFilteringRow = False
		End Sub

		#End Region

		#Region "Events"
		Private Sub bookingInfoRightPanel_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.bookingInfoRightPanel.Visible Then
				Me.bookingsGrid.Columns("Name").Width = 210
				Me.bookingsGrid.Columns("RoomId").Width = 170
				Me.bookingsGrid.Columns("From").Width = 170
				Me.bookingsGrid.Columns("To").Width = 150
			Else
				Me.bookingsGrid.Columns("Name").Width = 310
				Me.bookingsGrid.Columns("RoomId").Width = 230
				Me.bookingsGrid.Columns("From").Width = 210
				Me.bookingsGrid.Columns("To").Width = 210
			End If
		End Sub

		Private Sub bookingsGrid_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			Me.bookingInfoRightPanel.Visible = True
			Me.editGuestInfo_Renamed.Visible = False
			Me.bookingInfoUC.Visible = True
			Me.bookingInfoUC.LoadBookingInfo(TryCast(e.Row.DataBoundItem, Booking), Me.Rooms)
		End Sub

		Private Sub bookingsLeftView_ItemCheckedChanged(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
			Me.bookingsGrid.MasterTemplate.Refresh()
		End Sub

		Private Sub bookingsGrid_CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs)
			e.Handled = True
			Dim status As BookingStatus = CType(e.Row.Cells("Status").Value, BookingStatus)
			e.Row.IsVisible = IsBookingStatusChecked(status)
			If Me.searchTextBoxBookings.Text IsNot Nothing Then
				e.Row.IsVisible = e.Row.IsVisible And e.Row.Cells("Name").Value.ToString().Contains(Me.searchTextBoxBookings.Text) OrElse e.Row.Cells("RoomId").Value.ToString().Contains(Me.searchTextBoxBookings.Text)
			End If
		End Sub

		Private Function IsBookingStatusChecked(ByVal status As BookingStatus) As Boolean
			For Each item As ListViewDataItem In Me.bookingsLeftView.Items
				If item.Text = status.ToString() Then
					If item.CheckState = ToggleState.On Then
						Return True
					Else
						Return False
					End If
				End If
			Next item
			Return False
		End Function

		Private Sub searchTextBoxBookings_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.bookingsGrid.MasterTemplate.Refresh()
		End Sub

		Private Sub DateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.bookingsGrid.DataSource = GetBookingsByDate(Me.bookings_Renamed, dateNavigatorBookings.CurrentDate)
			Me.bookingsLeftView.ListViewElement.SynchronizeVisualItems()
			Me.scheduleDateNavigator.DateTimePicker.Value = Me.BookingsDate
		End Sub

		Private Function GetBookingsByDate(ByVal bookings As BindingList(Of Booking), ByVal date_Renamed As Date) As Object
			Dim dailyBookings As New BindingList(Of Booking)()
			For Each b As Booking In bookings
				If b.From <= date_Renamed AndAlso b.To >= date_Renamed Then
					dailyBookings.Add(b)
				End If
			Next b
			Return dailyBookings
		End Function

		Private Sub bookingsGrid_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If e.Column.Name = "RoomId" AndAlso TypeOf e.Row Is GridViewTableHeaderRowInfo Then
				e.CellElement.Padding = New Padding(15, 0, 0, 0)
			Else
				e.CellElement.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Sub bookingsGrid_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If TypeOf e.Row.RowInfo Is GridViewDataRowInfo Then
				If e.Column.Name = "Name" Then
					e.CellElement = New NameGridDataCellElement(e.Column, e.Row)
				ElseIf e.Column.Name = "RoomId" Then
					e.CellElement = New RoomGridDataCellElement(e.Column, e.Row)
				End If
			End If
		End Sub

		Private Sub bookingsGrid_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs)
			If e.CurrentRow IsNot Nothing Then
				Me.bookingInfoRightPanel.Visible = True
				Me.editGuestInfo_Renamed.Visible = False
				Me.bookingInfoUC.Visible = True
				Me.bookingInfoUC.LoadBookingInfo(TryCast(e.CurrentRow.DataBoundItem, Booking), Me.Rooms)
			End If
		End Sub

		#End Region

	End Class
End Namespace
