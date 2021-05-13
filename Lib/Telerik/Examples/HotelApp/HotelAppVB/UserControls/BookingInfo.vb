Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports HotelApp
Imports HotelApp.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Namespace CustomControls
	Partial Public Class BookingInfo
		Inherits UserControl
		#Region "Properties"

		Public Property Booking() As Booking

		Public Property Room() As Room

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			AddHandler Me.bookingDatesGrid.ViewCellFormatting, AddressOf bookingDatesGrid_ViewCellFormatting
			AddHandler Me.bookingDatesGrid.ViewRowFormatting, AddressOf bookingDatesGrid_ViewRowFormatting
			Me.bookingDatesGrid.CurrentRow = Nothing
			Me.bookingDatesGrid.EnableSorting = False
			Me.bookingDatesGrid.EnableHotTracking = False
			AddHandler Me.bookingDatesGrid.SelectionChanging, AddressOf bookingDatesGrid_SelectionChanging
			AddHandler Me.bookingDatesGrid.CurrentRowChanging, AddressOf bookingDatesGrid_CurrentRowChanging

			Me.closeButton.RootElement.EnableElementShadow = False
			Me.bookingInfoLabel.RootElement.EnableElementShadow = False
			Me.headerContainer.RootElement.EnableElementShadow = False
			Me.bookingStatusContainer.RootElement.EnableElementShadow = False
			Me.bookingStatusLabel.RootElement.EnableElementShadow = False
			Me.bookingStatusDropDown.RootElement.EnableElementShadow = False
			Me.bookingNameContainer.RootElement.EnableElementShadow = False
			Me.bookingNameLabel.RootElement.EnableElementShadow = False
			Me.bookingRoomTypeIcon.RootElement.EnableElementShadow = False
			Me.manageReservationContainer.RootElement.EnableElementShadow = False
			Me.roomIdLabel.RootElement.EnableElementShadow = False
			Me.manageStatusLabel.RootElement.EnableElementShadow = False
			Me.bookingDatesGrid.RootElement.EnableElementShadow = False

			AddHandler Me.roomIdLabel.Click, AddressOf roomIdLabel_Click

			Me.paymentSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)

			Me.closeButton.ButtonElement.Padding = New Padding(0)
			Me.closeButton.ImageAlignment = ContentAlignment.TopRight
			Me.closeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.closeButton.Image = My.Resources.not_clean

			Me.bookingNameLabel.Image = My.Resources.edit
			Me.bookingNameLabel.TextImageRelation = TextImageRelation.TextBeforeImage
			Me.bookingNameLabel.LabelElement.LabelImage.Padding = New Padding(0, -3, 0, 0)
			Me.bookingNameLabel.LabelElement.Padding = New Padding(5, 0, 0, 0)
			Me.bookingNameLabel.LabelElement.CustomFont = Utils.MainFontMedium
			Me.bookingNameLabel.LabelElement.CustomFontSize = 14f
			AddHandler Me.bookingNameLabel.Click, AddressOf bookingNameLabel_Click
			Me.bookingInfoLabel.LabelElement.CustomFont = Utils.MainFontMedium
			Me.bookingInfoLabel.LabelElement.CustomFontSize = 10.5f
			Me.bookingInfoLabel.LabelElement.LabelText.Margin = New Padding(0, -9, 0, 0)
			Me.bookingStatusLabel.LabelElement.CustomFont = Utils.MainFont
			Me.bookingStatusLabel.LabelElement.CustomFontSize = 10.5f
			Me.bookingStatusLabel.TextAlignment = ContentAlignment.MiddleRight
			Me.roomIdLabel.LabelElement.CustomFont = Utils.MainFont
			Me.roomIdLabel.LabelElement.CustomFontSize = 10.5f

			Me.roomIdLabel.LabelElement.LabelText.Margin = New Padding(5, 0, 0, 0)
			Me.bookingStatusDropDown.DropDownListElement.CustomFont = Utils.MainFont
			Me.bookingStatusDropDown.DropDownListElement.CustomFontSize = 10.5f
			Me.bookingStatusDropDown.DropDownListElement.ArrowButton.Margin = New Padding(0, 0, 25, 0)
			Dim borderPrimitive_Renamed As BorderPrimitive = Me.bookingStatusDropDown.DropDownListElement.FindDescendant(Of BorderPrimitive)()
			If borderPrimitive_Renamed IsNot Nothing Then
				borderPrimitive_Renamed.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
			Me.dropDownSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209)
			Me.manageStatusLabel.LabelElement.CustomFont = Utils.MainFont
			Me.manageStatusLabel.LabelElement.CustomFontSize = 10.5f
			Me.manageStatusLabel.ForeColor = Utils.MainThemeColor
			Me.bookingPriceLabel.LabelElement.CustomFont = Utils.MainFontMedium
			Me.bookingPriceLabel.LabelElement.Padding = New Padding(5, 0, 0, 0)
			Me.bookingNameLabel.LabelElement.CustomFont = Utils.MainFont
			Me.bookingNameLabel.LabelElement.CustomFontSize = 15f

			Me.bookingStatusDropDown.DropDownListElement.EditorElement.Padding = New Padding(0, 2, 0, 0)

			Me.roomImageBox.RootElement.EnableElementShadow = False
			Me.roomImageBox.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			Me.bookingStatusDropDown.DataSource = System.Enum.GetValues(GetType(BookingStatus))
			AddHandler Me.bookingStatusDropDown.SelectedValueChanged, AddressOf bookingStatusDropDown_SelectedValueChanged
		End Sub

		#End Region

		#Region "Events"

		Private Sub bookingStatusDropDown_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.Booking.Status <> CType(Me.bookingStatusDropDown.SelectedValue, BookingStatus) Then
				Me.Booking.Status = CType(Me.bookingStatusDropDown.SelectedValue, BookingStatus)
				Dim form As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
				If form IsNot Nothing Then
					form.BookingsListView.ListViewElement.SynchronizeVisualItems()
				End If
			End If
		End Sub

		Private Sub roomIdLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim form As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
			If form IsNot Nothing Then
				Dim comingFrom As String = "Booking"
				If form.PageView.SelectedPage Is form.PageView.Pages(2) Then
					comingFrom = "Schedule"
				End If
				form.ShowRoomDetails(Me.Room, Me.Booking, comingFrom)
			End If
		End Sub

		Private Sub bookingNameLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Visible = False
			Dim editGuestInfo_Renamed As EditGuestInfo = Nothing
			For Each c As Control In Me.Parent.Controls
				editGuestInfo_Renamed = TryCast(c, EditGuestInfo)
				If editGuestInfo_Renamed IsNot Nothing Then
					Exit For
				End If
			Next c

			If editGuestInfo_Renamed IsNot Nothing Then
				editGuestInfo_Renamed.Visible = True
				editGuestInfo_Renamed.Initialize(Me.Booking.Guests.FirstOrDefault(), Me.Booking)
			End If
		End Sub

		Private Sub bookingDatesGrid_ViewRowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs)
			e.RowElement.DrawBorder = False
		End Sub

		Private Sub bookingDatesGrid_SelectionChanging(ByVal sender As Object, ByVal e As GridViewSelectionCancelEventArgs)
			e.Cancel = True
		End Sub

		Private Sub bookingDatesGrid_CurrentRowChanging(ByVal sender As Object, ByVal e As CurrentRowChangingEventArgs)
			e.Cancel = True
		End Sub

		Private Sub bookingDatesGrid_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			e.CellElement.CustomFont = Utils.MainFont
			e.CellElement.CustomFontSize = 10.5f
			Dim headerCell As GridHeaderCellElement = TryCast(e.CellElement, GridHeaderCellElement)
			If headerCell IsNot Nothing Then
				If e.Column.Name = "Occupied" Then
					headerCell.ImageAlignment = ContentAlignment.MiddleLeft
					headerCell.TextAlignment = ContentAlignment.MiddleLeft
				Else
					headerCell.ImageAlignment = ContentAlignment.MiddleRight
					headerCell.TextAlignment = ContentAlignment.MiddleRight
					headerCell.Padding = New Padding(0, 0, 25, 0)
				End If
			End If
			If e.Column.Name = "Occupied" Then
				e.CellElement.Padding = New Padding(12, 0, 0, 0)
			Else
				e.CellElement.Padding = New Padding(0, 0, 25, 0)
			End If
		End Sub

		Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeButton.Click
			Me.Parent.Visible = False
		End Sub

		Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
			MyBase.OnVisibleChanged(e)
			If Me.Booking IsNot Nothing Then
				Me.bookingNameLabel.Text = Me.Booking.Name
			End If
		End Sub

		Friend Sub LoadBookingInfo(ByVal booking_Renamed As Booking, ByVal rooms As BindingList(Of Room))
			Me.manageStatusLabel.ForeColor = Utils.MainThemeColor
			Me.roomIdLabel.ForeColor = Utils.MainThemeColor
			Me.Booking = booking_Renamed
			Me.bookingInfoLabel.Text = "  BOOKING #" & booking_Renamed.Id

			Dim room_Renamed As Room = Utils.GetRoomById(booking_Renamed.RoomId, rooms)
			Me.Room = room_Renamed
			Me.roomImageBox.BackgroundImage = Utils.GetRoomImageByRoomType(room_Renamed.Type)
			Me.roomImageBox.BackgroundImageLayout = ImageLayout.Zoom
			Me.roomImageBox.PanelElement.PanelBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			Me.bookingNameLabel.Text = booking_Renamed.Name
			Me.bookingRoomTypeIcon.Image = Utils.GetImageByRoomType(room_Renamed.Type)
			Me.bookingStatusDropDown.SelectedValue = Me.Booking.Status
			Me.roomIdLabel.Text = " Room " & room_Renamed.Id
			Me.bookingPriceLabel.Text = "<html><size=15>$" & booking_Renamed.Price & "<size=10.5> Payment"

			Me.bookingDatesGrid.EnableGrouping = False
			Me.bookingDatesGrid.AllowAddNewRow = False
			Me.bookingDatesGrid.ReadOnly = True
			Me.bookingDatesGrid.TableElement.RowHeaderColumnWidth = 0
			Me.bookingDatesGrid.TableElement.TableHeaderHeight = 30
			Me.bookingDatesGrid.TableElement.RowHeight = 40
			Me.bookingDatesGrid.TableElement.VScrollBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			AddHandler Me.bookingDatesGrid.TableElement.VScrollBar.PropertyChanged, AddressOf VScrollBar_PropertyChanged
			If Me.bookingDatesGrid.Columns.Count = 0 Then
				Me.bookingDatesGrid.Columns.Add("Occupied")
				Me.bookingDatesGrid.Columns.Add("Days")

				For Each c As GridViewDataColumn In Me.bookingDatesGrid.Columns
					c.HeaderImage = My.Resources.GlyphCalendar_small
					c.TextImageRelation = TextImageRelation.ImageBeforeText
				Next c
				Me.bookingDatesGrid.Columns("Occupied").TextAlignment = ContentAlignment.MiddleLeft
				Me.bookingDatesGrid.Columns("Days").TextAlignment = ContentAlignment.MiddleRight
				Me.bookingDatesGrid.Columns("Occupied").MaxWidth = 180
				Me.bookingDatesGrid.Columns("Occupied").Width = 180
			End If
			Me.bookingDatesGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			Me.bookingDatesGrid.Rows.Clear()
			Me.bookingDatesGrid.Rows.Add("From: " & booking_Renamed.From.ToString("dd.MM.yyyy") & " " & booking_Renamed.From.DayOfWeek.ToString().Substring(0, 3), (booking_Renamed.To - booking_Renamed.From).Days)
			Me.bookingDatesGrid.Rows.Add("To: " & booking_Renamed.To.ToString("dd.MM.yyyy") & " " & booking_Renamed.To.DayOfWeek.ToString().Substring(0, 3))
			Do While Me.bookingDatesGrid.SelectedRows.Count > 0
				Me.bookingDatesGrid.SelectedRows.First().IsSelected = False
			Loop

			Dim f As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
			If f IsNot Nothing AndAlso f.PageView.SelectedPage Is f.PageView.Pages(2) Then
				Me.manageStatusLabel.Visible = False
			Else
				Me.manageStatusLabel.Visible = True
			End If
		End Sub

		Private Sub VScrollBar_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Visibility" AndAlso Me.bookingDatesGrid.TableElement.VScrollBar.Visibility <> Telerik.WinControls.ElementVisibility.Collapsed Then
				Me.bookingDatesGrid.TableElement.VScrollBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
		End Sub

		Private Sub manageStatusLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles manageStatusLabel.Click
			Dim f As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)
			If f IsNot Nothing AndAlso f.PageView.SelectedPage Is f.PageView.Pages(1) Then
				f.PageView.SelectedPage = f.PageView.Pages(2)
			End If
		End Sub

		#End Region
	End Class
End Namespace