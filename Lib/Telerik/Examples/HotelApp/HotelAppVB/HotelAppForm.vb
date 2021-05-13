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
    Inherits RadForm
        #Region "Fields"

        Private draggedRowInfo As GridViewRowInfo = Nothing
        Private reportsInterval As String
        'INSTANT VB NOTE: The variable rooms was renamed since Visual Basic does not allow class members with the same name:
        Private rooms_Renamed As New BindingList(Of Room)()
        'INSTANT VB NOTE: The variable guests was renamed since Visual Basic does not allow class members with the same name:
        Private guests_Renamed As New BindingList(Of Guest)()
        'INSTANT VB NOTE: The variable bookings was renamed since Visual Basic does not allow class members with the same name:
        Private bookings_Renamed As New BindingList(Of Booking)()
        'INSTANT VB NOTE: The variable houseKeepers was renamed since Visual Basic does not allow class members with the same name:
        Private houseKeepers_Renamed As New BindingList(Of HouseKeeper)()
        'INSTANT VB NOTE: The variable roomDetailsUC was renamed since Visual Basic does not handle variables named the same as their type well:
        Private roomDetailsUC_Renamed As New RoomDetailsUC()
        Private culture As New CultureInfo("en-US")

        #End Region

        #Region "Constructor & Initialization"
        Public Sub New()
            InitializeComponent()

            ThemeResolutionService.ApplicationThemeName = "Material"

            culture.DateTimeFormat.DayNames = New String(6) { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.OverviewPage.Controls.Add(roomDetailsUC_Renamed)
            roomDetailsUC_Renamed.Visible = False
            roomDetailsUC_Renamed.Dock = DockStyle.Fill
            Me.OverviewPage.Controls.SetChildIndex(roomDetailsUC_Renamed, 0)
            Me.navigationPanelOverview.Visible = True

            Dim stripElement As RadPageViewStripElement = TryCast(Me.mainContainer.ViewElement, RadPageViewStripElement)

            Dim themesDropDown As New RadDropDownListElement()
            stripElement.StripButtons = Not StripViewButtons.All
            stripElement.ItemContainer.ButtonsPanel.Children.Add(themesDropDown)
            themesDropDown.MinSize = New Size(200, 40)
            themesDropDown.EnableElementShadow = False
            themesDropDown.FindDescendant(Of FillPrimitive)().BackColor = Color.Transparent
            themesDropDown.DropDownStyle = RadDropDownStyle.DropDownList
            stripElement.ItemContainer.ButtonsPanel.Margin = New Padding(0, 0, 20, 0)
            themesDropDown.Items.AddRange(New RadListDataItem() { New RadListDataItem("Material") With {.Image = My.Resources.default_small}, New RadListDataItem("MaterialPink") With {.Image = My.Resources.pink_blue_small}, New RadListDataItem("MaterialTeal") With {.Image = My.Resources.teal_red_small}, New RadListDataItem("MaterialBlueGrey") With {.Image = My.Resources.blue_grey_green_small} })
            themesDropDown.SelectedIndex = 0
            AddHandler themesDropDown.SelectedIndexChanged, Sub(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
                                                                If e.Position > -1 Then
                                                                    ThemeResolutionService.ApplicationThemeName = themesDropDown.Items(e.Position).Text
                                                                    AdjustMainColor()
                                                                End If
                                                            End Sub

            stripElement.DrawBorder = False
            stripElement.ContentArea.DrawBorder = True
            stripElement.ContentArea.BorderBoxStyle = BorderBoxStyle.FourBorders
            stripElement.ContentArea.BorderLeftColor = Color.FromArgb(232, 232, 232)
            stripElement.ContentArea.BorderTopWidth = 0
            stripElement.ContentArea.BorderBottomWidth = 0
            stripElement.ContentArea.BorderRightWidth = 0

            stripElement.ContentArea.Padding = New Padding(0)
            searchContainerOverview.RootElement.EnableElementShadow = False
            searchContainerBookings.RootElement.EnableElementShadow = False

            Me.WireEvents()
            Me.InitOverviewPage()
            Me.InitBookingsPage()
            Me.InitSchedulePage()
            Me.InitHouseKeepingPage()
            Me.InitReportsPage()
        End Sub

        Private Sub InitOverviewPage()
            '			#Region "OverviewPage"

            Me.overviewMainContainer.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
            Me.navigationPanelOverview.BackgroundImage = My.Resources.fasha_no_borders
            Me.navigationPanelOverview.BackgroundImageLayout = ImageLayout.Stretch
            Me.navigationPanelOverview.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed

            Me.navigationPanelOverview.PanelElement.PanelFill.BackColor = Color.Transparent
            Me.navigationPanelOverview.PanelElement.PanelFill.GradientStyle = GradientStyles.Solid
            Me.searchContainerOverview.PanelElement.PanelFill.BackColor = Color.Transparent
            Me.searchContainerOverview.BackColor = Color.Transparent
            Me.searchContainerOverview.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
            Me.radPanelEmptyOverview.PanelElement.PanelFill.BackColor = Color.Transparent
            Me.radPanelEmptyOverview.BackColor = Color.Transparent
            Me.radPanelEmptyOverview.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed

            Me.overviewLeftView.ShowGroups = True
            Me.overviewLeftView.EnableGrouping = True
            Me.overviewLeftView.EnableCustomGrouping = True
            Me.overviewLeftView.ShowCheckBoxes = True
            Me.overviewLeftView.AllowEdit = False
            Me.overviewLeftView.RootElement.EnableElementShadow = False
            Me.overviewLeftView.HotTracking = False
            Me.bookingsLeftView.HotTracking = False
            Me.overviewLeftView.ListViewElement.Padding = New Padding(0, 16, 0, 0)

            Me.PopulateData()

            Me.overviewRoomsView.ShowGroups = True
            Me.overviewRoomsView.EnableGrouping = True
            Dim groupByValue As New GroupDescriptor(New SortDescriptor() { New SortDescriptor("Type", ListSortDirection.Ascending) })

            Me.overviewRoomsView.GroupDescriptors.Add(groupByValue)

            Me.overviewRoomsView.ViewType = ListViewType.IconsView
            Me.overviewRoomsView.ItemSize = New Size(200, 120)
            Me.overviewRoomsView.ItemSpacing = 10
            Me.overviewRoomsView.AllowEdit = False
            Me.overviewRoomsView.EnableFiltering = True
            Me.overviewRoomsView.HotTracking = False

            Me.overviewRoomsView.RootElement.BackColor = Color.Transparent
            Me.overviewRoomsView.BackColor = Color.Transparent
            Me.overviewRoomsView.ListViewElement.DrawFill = False
            Me.overviewRoomsView.ListViewElement.ViewElement.BackColor = Color.Transparent
            Me.overviewRoomsView.ListViewElement.Padding = New Padding(-9, 0, 0, 0)

            Me.overviewRoomsView.RootElement.EnableElementShadow = False
            Me.overviewMainContainer.BackgroundImage = My.Resources.Background
            Me.overviewMainContainer.BackgroundImageLayout = ImageLayout.Stretch
            Me.overviewMainContainer.PanelElement.PanelFill.Visibility = ElementVisibility.Collapsed
            Me.bookingsMainContainer.PanelElement.PanelFill.Visibility = ElementVisibility.Hidden
            Me.bookingsMainContainer.BackgroundImage = My.Resources.Background
            Me.bookingsMainContainer.BackgroundImageLayout = ImageLayout.Stretch

            Me.radPanelEmptyOverview.RootElement.EnableElementShadow = False
            Me.radPanelEmptyBooking.RootElement.EnableElementShadow = False
            Me.bookingsLeftView.RootElement.EnableElementShadow = False
            Me.overviewRoomsView.GroupItemSize = New Size(0, 45)

            '			#End Region
        End Sub

        Protected Overrides Overloads Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.reportsDaysToggleButton.PerformClick()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            Me.AdjustMainColor()
        End Sub

        Protected Overrides ReadOnly Property CreateParams() As CreateParams
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or &H2000000 ' Turn on WS_EX_COMPOSITED
                Return cp
            End Get
        End Property

        Private Sub WireEvents()
            AddHandler Me.scheduleListView.VisualItemFormatting, AddressOf leftView_VisualItemFormatting
            AddHandler Me.scheduleListView.SelectedItemChanging, AddressOf view_SelectedItemChanging
            AddHandler Me.scheduleListView.VisualItemCreating, AddressOf leftView_VisualItemCreating
            AddHandler Me.scheduleListView.ItemCheckedChanged, AddressOf scheduleListView_ItemCheckedChanged

            AddHandler Me.overviewLeftView.SelectedItemChanging, AddressOf view_SelectedItemChanging
            AddHandler Me.houseKeepingListView.SelectedItemChanging, AddressOf view_SelectedItemChanging
            AddHandler Me.overviewLeftView.GroupExpanding, AddressOf leftView_GroupExpanding
            AddHandler Me.BookingsListView.GroupExpanding, AddressOf leftView_GroupExpanding
            AddHandler Me.houseKeepingListView.GroupExpanding, AddressOf leftView_GroupExpanding
            AddHandler Me.scheduleListView.GroupExpanding, AddressOf leftView_GroupExpanding
            AddHandler Me.overviewLeftView.ItemCheckedChanged, AddressOf leftView_ItemCheckedChanged
            AddHandler Me.overviewLeftView.VisualItemFormatting, AddressOf leftView_VisualItemFormatting
            AddHandler Me.overviewLeftView.VisualItemCreating, AddressOf leftView_VisualItemCreating
            AddHandler Me.overviewRoomsView.VisualItemCreating, AddressOf roomsView_VisualItemCreating
            AddHandler Me.dateNavigatorOverview.LeftNavigationButton.Click, AddressOf navigationButton_Click
            AddHandler Me.dateNavigatorOverview.RightNavigationButton.Click, AddressOf navigationButton_Click
            AddHandler Me.dateNavigatorOverview.DateTimePicker.ValueChanged, AddressOf navigationButton_Click
            AddHandler Me.searchTextBoxOverview.TextChanged, AddressOf searchTextBox_TextChanged

            AddHandler Me.overviewRoomsView.VisualItemFormatting, AddressOf roomsView_VisualItemFormatting
            AddHandler Me.overviewRoomsView.ItemMouseClick, AddressOf roomsView_ItemMouseClick

            AddHandler Me.bookingsLeftView.VisualItemFormatting, AddressOf bookingsLeftView_VisualItemFormatting

            AddHandler Me.bookingsLeftView.SelectedItemChanging, AddressOf view_SelectedItemChanging
            AddHandler Me.overviewRoomsView.GroupExpanding, AddressOf roomsView_GroupExpanding
            AddHandler Me.overviewRoomsView.SelectedItemChanging, AddressOf roomsView_SelectedItemChanging
            AddHandler Me.bookingInfoRightPanel.VisibleChanged, AddressOf bookingInfoRightPanel_VisibleChanged
            AddHandler Me.bookingsGrid.CurrentRowChanged, AddressOf bookingsGrid_CurrentRowChanged
            AddHandler Me.bookingsGrid.CreateCell, AddressOf bookingsGrid_CreateCell
            AddHandler Me.bookingsGrid.ViewCellFormatting, AddressOf bookingsGrid_ViewCellFormatting

            AddHandler Me.bookingsLeftView.VisualItemCreating, AddressOf leftView_VisualItemCreating
            AddHandler Me.bookingsLeftView.ItemCheckedChanged, AddressOf bookingsLeftView_ItemCheckedChanged

            AddHandler Me.dateNavigatorBookings.DateTimePicker.ValueChanged, AddressOf DateTimePicker_ValueChanged

            AddHandler Me.bookingsGrid.CustomFiltering, AddressOf bookingsGrid_CustomFiltering
            AddHandler Me.searchTextBoxBookings.TextChanged, AddressOf searchTextBoxBookings_TextChanged
            AddHandler Me.PageView.SelectedPageChanged, AddressOf PageView_SelectedPageChanged
        End Sub

        #Region "TitleBar"

        Private Sub HotelApp_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim lve As New LightVisualElement()
            lve.Image = My.Resources.stars
            Me.FormElement.TitleBar.Children(2).Children.Insert(0, lve)
            lve.Margin = New Padding(15, 0, 0, 0)
            Me.FormElement.TitleBar.TitlePrimitive.Margin = New Padding(2, 2, 0, 0)
            Me.FormElement.TitleBar.TitlePrimitive.CustomFont = Utils.MainFont
            Me.FormElement.TitleBar.TitlePrimitive.CustomFontSize = 10.5f
            Me.FormElement.TitleBar.TitlePrimitive.TextAlignment = ContentAlignment.MiddleLeft
            Me.Text = "Hotel App"
            Me.Size = New Size(1365, 900)
            Me.Icon = My.Resources.starsIcon
            Me.ShowIcon = True
            Me.FormElement.TitleBar.IconPrimitive.Opacity = 0
            Me.FormElement.TitleBar.TitlePrimitive.PositionOffset = New SizeF(-1 * Me.Icon.Width, 0)


        End Sub
        #End Region

        #End Region

        #Region "Properties"

        Public ReadOnly Property Guests() As BindingList(Of Guest)
            Get
                Return Me.guests_Renamed
            End Get
        End Property

        Public ReadOnly Property BookingsListView() As RadListView
            Get
                Return Me.bookingsLeftView
            End Get
        End Property

        Public ReadOnly Property HouseKeepers() As BindingList(Of HouseKeeper)
            Get
                Return Me.houseKeepers_Renamed
            End Get
        End Property

        Public ReadOnly Property NavigationPanel() As RadPanel
            Get
                Return Me.navigationPanelOverview
            End Get
        End Property

        Public Property OverviewDate() As Date
            Get
                Return Me.dateNavigatorOverview.CurrentDate
            End Get
            Set(ByVal value As Date)
                Me.dateNavigatorOverview.DateTimePicker.Value = value
            End Set
        End Property

        Public Property BookingsDate() As Date
            Get
                Return Me.dateNavigatorBookings.CurrentDate
            End Get
            Set(ByVal value As Date)
                Me.dateNavigatorBookings.DateTimePicker.Value = value
            End Set
        End Property

        Public ReadOnly Property Bookings() As BindingList(Of Booking)
            Get
                Return Me.bookings_Renamed
            End Get
        End Property

        Public ReadOnly Property Rooms() As BindingList(Of Room)
            Get
                Return Me.rooms_Renamed
            End Get
        End Property

        Public ReadOnly Property RoomsListView() As RadListView
            Get
                Return Me.overviewRoomsView
            End Get
        End Property

        Public ReadOnly Property PageView() As RadPageView
            Get
                Return Me.mainContainer
            End Get
        End Property

        Public ReadOnly Property OverviewSearch() As SearchTextBox
            Get
                Return Me.searchTextBoxOverview
            End Get
        End Property

        #End Region
        Private Sub AdjustMainColor()
            Utils.MainThemeColor = Me.FormElement.TitleBar.FillPrimitive.BackColor
            Me.RoomsListView.ListViewElement.SynchronizeVisualItems()
            Me.reportsCurrentStatusLabel.ForeColor = Utils.MainThemeColor
            Me.reportsBookingsByTypeLabel.ForeColor = Utils.MainThemeColor
            Me.labelBookings.ForeColor = Utils.MainThemeColor
            Me.scheduleRadSchedulerHeader.PanelElement.PanelFill.BackColor = Utils.MainThemeColor
            Me.ScheduleRadScheduler.SchedulerElement.RefreshViewElement()
            RefreshView()
            Me.houseKeepingSchedulerHeaderLabel.LabelElement.LabelFill.BackColor = Utils.MainThemeColor
            Me.notAssignedLabel.LabelElement.LabelFill.BackColor = Utils.MainThemeColor
            Dim currentRow As GridViewRowInfo = Me.bookingsGrid.CurrentRow
            Me.bookingsGrid.CurrentRow = Nothing
            Me.bookingsGrid.CurrentRow = currentRow
        End Sub

        Private Sub ActiveView_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            If e.PropertyName = "StartDate" Then
                Me.houseKeepingDateNavigator.DateTimePicker.Value = Me.houseKeepingScheduler.ActiveView.StartDate
            End If
        End Sub

        Private Function ConvertFrom(ByVal item As Object) As Object
            Dim resourceId As EventId = TryCast(item, EventId)
            If item IsNot Nothing AndAlso TypeOf resourceId.KeyValue Is Integer Then
                Return resourceId.KeyValue
            End If

            Return DBNull.Value
        End Function

        Private Function ConvertTo(ByVal item As Object) As Object
            Return New EventId(item)
        End Function

        Private Sub view_SelectedItemChanging(ByVal sender As Object, ByVal e As ListViewItemCancelEventArgs)
            e.Cancel = True
        End Sub

        Private Sub roomsView_SelectedItemChanging(ByVal sender As Object, ByVal e As ListViewItemCancelEventArgs)
            e.Cancel = TypeOf e.Item Is ListViewDataItemGroup
        End Sub

        Private Sub roomsView_GroupExpanding(ByVal sender As Object, ByVal e As ListViewGroupCancelEventArgs)
            e.Cancel = e.Group.Expanded
        End Sub

        Private Sub leftView_ItemCheckedChanged(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
            UpdateRooms()
            Me.overviewLeftView.ListViewElement.SynchronizeVisualItems()
            Me.overviewRoomsView.ListViewElement.SynchronizeVisualItems()
        End Sub

        Private Sub UpdateRooms()
            For Each item As ListViewDataItem In Me.overviewRoomsView.Items
                Dim room_Renamed As Room = TryCast(item.DataBoundItem, Room)
                Dim isRoomItemVisible As Boolean = True
                For Each leftViewItem As ListViewDataItem In overviewLeftView.Items
                    If leftViewItem.Group.Text = "STATUS" Then
                        Dim roomStatus_Renamed As RoomStatus = CType(System.Enum.Parse(GetType(RoomStatus), leftViewItem.Text), RoomStatus)
                        If room_Renamed.GetStatusByBooking(Me.OverviewDate, bookings_Renamed) = roomStatus_Renamed AndAlso leftViewItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                            isRoomItemVisible = False
                            Exit For
                        End If
                    ElseIf leftViewItem.Group.Text = "TYPE" Then
                        Dim roomType_Renamed As RoomType = CType(System.Enum.Parse(GetType(RoomType), leftViewItem.Text), RoomType)
                        If room_Renamed.Type = roomType_Renamed AndAlso leftViewItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                            isRoomItemVisible = False
                            Exit For
                        End If
                    ElseIf leftViewItem.Group.Text = "HOUSE KEEPING" Then
                        If leftViewItem.Text = "Repair" Then
                            If (Not room_Renamed.NeedsRepairs) AndAlso leftViewItem.CheckState = ToggleState.On Then
                                isRoomItemVisible = False
                                Exit For
                            End If
                        Else
                            Dim roomHouseKeepingStatus As HouseKeepingStatus = CType(System.Enum.Parse(GetType(HouseKeepingStatus), leftViewItem.Text), HouseKeepingStatus)
                            If room_Renamed.HouseKeepingStatus = roomHouseKeepingStatus AndAlso leftViewItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                                isRoomItemVisible = False
                                Exit For
                            End If
                        End If
                    End If
                Next leftViewItem
                If isRoomItemVisible = False Then
                    item.Visible = False
                Else
                    item.Visible = True
                End If
            Next item
        End Sub

        Private Function GetBoolValue(ByVal toggleState_Renamed As ToggleState) As Boolean
            Dim value As Boolean = False
            If toggleState_Renamed = ToggleState.On Then
                value = True
            End If
            Return value
        End Function

        Private Sub searchTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.searchTextBoxOverview.Text = String.Empty Then
                Me.overviewRoomsView.FilterPredicate = Nothing
            Else
                Me.overviewRoomsView.FilterPredicate = Nothing
                Me.overviewRoomsView.FilterPredicate = AddressOf FilterRoomsPredicate
            End If
            Me.overviewLeftView.ListViewElement.SynchronizeVisualItems()
            UpdateRooms()
        End Sub

        Private Function FilterRoomsPredicate(ByVal item As ListViewDataItem) As Boolean
            If Me.searchTextBoxOverview.Text <> String.Empty Then
                Dim room_Renamed As Room = TryCast(item.DataBoundItem, Room)
                If room_Renamed.Id.ToString().Contains(Me.searchTextBoxOverview.Text) Then
                    Return True
                End If
                Dim booking_Renamed As Booking = GetBooking(room_Renamed)
                If booking_Renamed IsNot Nothing AndAlso booking_Renamed.Name.ToLower().Contains(Me.searchTextBoxOverview.Text.ToLower()) Then
                    Return True
                End If
                Return False
            End If

            Return True
        End Function

        Public Function GetBooking(ByVal room_Renamed As Room) As Booking
            For Each booking_Renamed As Booking In Me.Bookings
                If booking_Renamed.RoomId = room_Renamed.Id AndAlso booking_Renamed.From <= Me.dateNavigatorOverview.CurrentDate AndAlso booking_Renamed.To >= Me.dateNavigatorOverview.CurrentDate Then
                    Return booking_Renamed
                End If
            Next booking_Renamed

            Return Nothing
        End Function

        Private Sub leftView_GroupExpanding(ByVal sender As Object, ByVal e As ListViewGroupCancelEventArgs)
            e.Cancel = True
        End Sub

        Private Sub scheduleListView_ItemCheckedChanged(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
            UpdateRoomResources(e.Item.Group, e.Item.Text, e.Item.CheckState)
            Me.scheduleListView.ListViewElement.SynchronizeVisualItems()
        End Sub

        Private Sub UpdateRoomResources(ByVal group As ListViewDataItemGroup, ByVal itemText As String, ByVal toggleState_Renamed As ToggleState)
            Dim schedulerSource As SchedulerBindingDataSource = TryCast(Me.ScheduleRadScheduler.DataSource, SchedulerBindingDataSource)
            Dim rooms As BindingList(Of Room) = TryCast(schedulerSource.ResourceProvider.DataSource, BindingList(Of Room))
            Dim toDelete As New List(Of Room)()
            If group.Text = "STATUS" Then
                If toggleState_Renamed = ToggleState.Off Then
                    For Each r As Room In rooms
                        If r.Status.ToString() = itemText Then
                            toDelete.Add(r)
                        End If
                    Next r
                    Do While toDelete.Count > 0
                        rooms.Remove(toDelete(0))
                        toDelete.RemoveAt(0)
                    Loop
                Else
                    For Each r As Room In Me.Rooms
                        If Not RoomExists(rooms, r.Id) Then
                            Dim item As ListViewDataItem = group.Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On AndAlso i.Text = r.Status.ToString())
                            If item IsNot Nothing Then
                                rooms.Add(New Room(r.Id, r.Status, r.Type, r.HouseKeepingStatus, r.NeedsRepairs, r.PricePerDay))
                            End If
                        End If
                    Next r
                End If
            ElseIf group.Text = "TYPE" Then
                If toggleState_Renamed = ToggleState.Off Then
                    For Each r As Room In rooms
                        If r.Type.ToString() = itemText Then
                            toDelete.Add(r)
                        End If
                    Next r
                    Do While toDelete.Count > 0
                        rooms.Remove(toDelete(0))
                        toDelete.RemoveAt(0)
                    Loop
                Else
                    For Each r As Room In Me.Rooms
                        If Not RoomExists(rooms, r.Id) Then
                            Dim item As ListViewDataItem = group.Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On AndAlso i.Text = r.Type.ToString())
                            If item IsNot Nothing Then
                                rooms.Add(New Room(r.Id, r.Status, r.Type, r.HouseKeepingStatus, r.NeedsRepairs, r.PricePerDay))
                            End If
                        End If
                    Next r
                End If
            End If

            Dim sortedResources As New List(Of Room)()
            For Each r As Room In rooms
                sortedResources.Add(r)
            Next r
            sortedResources.Sort(Function(X As Room, Y As Room) X.Id.CompareTo(Y.Id))
            rooms.Clear()
            For Each r As Room In sortedResources
                rooms.Add(r)
            Next r
            For Each r As Resource In Me.ScheduleRadScheduler.Resources
                r.Color = Color.White
            Next r

            If Me.ScheduleRadScheduler.Resources.Count = 0 Then
                Me.ScheduleRadScheduler.GroupType = GroupType.None
            Else
                Me.ScheduleRadScheduler.GroupType = GroupType.Resource
            End If
            Me.ScheduleRadScheduler.SchedulerElement.RefreshViewElement()
            RefreshView()
        End Sub

        Private Function RoomExists(ByVal rooms As BindingList(Of Room), ByVal roomId As Integer) As Boolean
            For Each r As Room In rooms
                If r.Id = roomId Then
                    Return True
                End If
            Next r
            Return False
        End Function

        Private Sub PageView_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.roomDetailsUC_Renamed.Visible = False
            If Me.PageView.SelectedPage Is Me.OverviewPage Then
                navigationPanelOverview.Visible = True
                Me.RoomsListView.ListViewElement.SynchronizeVisualItems()
            ElseIf Me.PageView.SelectedPage IsNot Me.SchedulePage Then
                Me.ScheduleRadScheduler.SelectionBehavior.ResetSelection()
                Me.scheduleBookingPanel.Visible = False
            End If
        End Sub

        Private Sub roomsView_ItemMouseClick(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
            Dim room_Renamed As Room = TryCast(e.Item.DataBoundItem, Room)
            If room_Renamed IsNot Nothing Then
                Dim booking_Renamed As Booking = GetBooking(room_Renamed)
                Me.ShowRoomDetails(room_Renamed, booking_Renamed, "Overview")
            End If
        End Sub

        Private Sub bookingsLeftView_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
            e.VisualItem.Padding = New Padding(10, 0, 0, 0)
            Dim groupItem As SimpleListViewGroupVisualItem = TryCast(e.VisualItem, SimpleListViewGroupVisualItem)
            If groupItem IsNot Nothing Then
                e.VisualItem.CustomFont = Utils.MainFontMedium
                e.VisualItem.CustomFontSize = 10.5f
                e.VisualItem.CustomFontStyle = FontStyle.Regular
                groupItem.ToggleElement.Visibility = ElementVisibility.Collapsed
                e.VisualItem.ShowHorizontalLine = False
            Else
                Dim simpleItem As SimpleListViewVisualItem = TryCast(e.VisualItem, SimpleListViewVisualItem)
                simpleItem.ToggleElement.Margin = New Padding(-20, 0, 0, 0)
                e.VisualItem.CustomFont = Utils.MainFont
                e.VisualItem.CustomFontSize = 10.5f
                e.VisualItem.CustomFontStyle = FontStyle.Regular
                e.VisualItem.ResetValue(LightVisualElement.ShowHorizontalLineProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If
        End Sub

        Private Sub navigationButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.overviewRoomsView.ListViewElement.SynchronizeVisualItems()
            Me.overviewLeftView.ListViewElement.SynchronizeVisualItems()
            Me.UpdateRooms()
        End Sub

        Private Sub leftView_VisualItemCreating(ByVal sender As Object, ByVal e As ListViewVisualItemCreatingEventArgs)
            If TypeOf e.VisualItem Is SimpleListViewVisualItem Then
                e.VisualItem = New OptionsSimpleListViewVisualItem()
            End If
        End Sub

        Private Sub leftView_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
            e.VisualItem.Padding = New Padding(10, 0, 0, 0)
            Dim groupItem As SimpleListViewGroupVisualItem = TryCast(e.VisualItem, SimpleListViewGroupVisualItem)
            If groupItem IsNot Nothing Then
                e.VisualItem.CustomFont = Utils.MainFontMedium
                e.VisualItem.CustomFontSize = 10.5f
                e.VisualItem.CustomFontStyle = FontStyle.Regular

                groupItem.ToggleElement.Visibility = ElementVisibility.Collapsed
                e.VisualItem.ShowHorizontalLine = False
            Else
                e.VisualItem.CustomFont = Utils.MainFont
                e.VisualItem.CustomFontSize = 10.5f
                e.VisualItem.CustomFontStyle = FontStyle.Regular
                e.VisualItem.ResetValue(LightVisualElement.ShowHorizontalLineProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If

            Dim simpleItem As SimpleListViewVisualItem = TryCast(e.VisualItem, SimpleListViewVisualItem)
            If simpleItem IsNot Nothing Then
                If e.VisualItem.Data.Group.Text = "TYPE" Then
                    e.VisualItem.Text = Utils.GetRoomType(CType(e.VisualItem.Data.Value, RoomType))
                ElseIf e.VisualItem.Data.Group.Text = "HOUSE KEEPING" Then
                    If Not e.VisualItem.Text.Contains("Repair") Then
                        e.VisualItem.Text = Utils.GetHouseKeepingStatus(CType(e.VisualItem.Data.Value, HouseKeepingStatus))
                    End If
                End If
                simpleItem.ToggleElement.Margin = New Padding(-20, 0, 0, 0)
            End If
        End Sub

        Private Sub roomsView_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
            Dim groupItem As IconListViewGroupVisualItem = TryCast(e.VisualItem, IconListViewGroupVisualItem)
            If groupItem IsNot Nothing Then
                If groupItem.HasVisibleItems() Then
                    groupItem.Visibility = ElementVisibility.Visible
                Else
                    groupItem.Visibility = ElementVisibility.Collapsed
                End If
                groupItem.Text = Utils.GetRoomType(CType(System.Enum.Parse(GetType(RoomType), groupItem.Text), RoomType))
                e.VisualItem.CustomFont = Utils.MainFont
                e.VisualItem.CustomFontSize = 15
                e.VisualItem.CustomFontStyle = FontStyle.Regular
                groupItem.ToggleElement.Visibility = ElementVisibility.Collapsed
                e.VisualItem.ShowHorizontalLine = False
                e.VisualItem.Padding = New Padding(20, 0, 0, 0)
                e.VisualItem.TextAlignment = ContentAlignment.BottomLeft
                e.VisualItem.EnableElementShadow = False
            Else
                e.VisualItem.EnableElementShadow = True
                e.VisualItem.ShadowDepth = 1
                e.VisualItem.Padding = New Padding(0)
                e.VisualItem.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
            End If
        End Sub

        Private Sub roomsView_VisualItemCreating(ByVal sender As Object, ByVal e As ListViewVisualItemCreatingEventArgs)
            If TypeOf e.VisualItem Is IconListViewVisualItem Then
                e.VisualItem = New RoomIconListViewVisualItem()
            End If
        End Sub

        Public Sub PopulateData()
            houseKeepers_Renamed.Add(New HouseKeeper(1, "Millie", My.Resources.Millie))
            houseKeepers_Renamed.Add(New HouseKeeper(2, "Anna", My.Resources.Anna))
            houseKeepers_Renamed.Add(New HouseKeeper(3, "Bobby", My.Resources.Bobby))

            rooms_Renamed.Add(New Room(101, RoomStatus.Available, RoomType.Single, HouseKeepingStatus.NotClean, True, 50))
            rooms_Renamed.Last().Priority = RoomPriority.Low
            rooms_Renamed.Add(New Room(102, RoomStatus.Occupied, RoomType.Double, HouseKeepingStatus.Clean, False, 100))
            rooms_Renamed.Add(New Room(103, RoomStatus.Occupied, RoomType.Triple, HouseKeepingStatus.NotClean, True, 150))
            rooms_Renamed.Add(New Room(104, RoomStatus.Occupied, RoomType.Triple, HouseKeepingStatus.Clean, False, 150))
            rooms_Renamed.Add(New Room(105, RoomStatus.CheckedOut, RoomType.Single, HouseKeepingStatus.NotClean, False, 50))
            rooms_Renamed.Add(New Room(106, RoomStatus.Reserved, RoomType.Double, HouseKeepingStatus.Clean, True, 100))
            rooms_Renamed.Add(New Room(107, RoomStatus.Available, RoomType.Double, HouseKeepingStatus.Clean, False, 100))
            rooms_Renamed.Add(New Room(108, RoomStatus.Reserved, RoomType.Family, HouseKeepingStatus.Clean, False, 200))
            rooms_Renamed.Add(New Room(109, RoomStatus.Available, RoomType.Single, HouseKeepingStatus.NotClean, False, 50))
            rooms_Renamed.Last().Priority = RoomPriority.High
            rooms_Renamed.Add(New Room(110, RoomStatus.Reserved, RoomType.Single, HouseKeepingStatus.NotClean, False, 50))
            rooms_Renamed.Last().Priority = RoomPriority.Medium
            rooms_Renamed.Add(New Room(111, RoomStatus.Reserved, RoomType.Triple, HouseKeepingStatus.Clean, False, 150))
            rooms_Renamed.Add(New Room(112, RoomStatus.Occupied, RoomType.Triple, HouseKeepingStatus.Clean, False, 150))
            rooms_Renamed.Add(New Room(113, RoomStatus.Reserved, RoomType.Family, HouseKeepingStatus.Clean, False, 200))

            rooms_Renamed.Add(New Room(114, RoomStatus.Available, RoomType.Triple, HouseKeepingStatus.Clean, False, 200))
            rooms_Renamed.Add(New Room(115, RoomStatus.Available, RoomType.Triple, HouseKeepingStatus.Clean, False, 200))

            guests_Renamed.Add(New Guest("1", "Nancy Davolio", "New Balance 5th Avenue Mile 2017", "New York", "615-555-0169", New CreditCard("379683588302311", Date.Now.AddYears(3), 387)))
            guests_Renamed.Add(New Guest("2", "Andrew Fuller", "514 S. Magnolia St. ", "Orlando", "615-555-0169", New CreditCard("346534548327544", Date.Now.AddYears(2), 124)))
            guests_Renamed.Add(New Guest("3", "Janet Leverling", "70 Bowman St. ", "South Windsor", "615-555-0169", New CreditCard("340505947817695", Date.Now.AddYears(6), 547)))
            guests_Renamed.Add(New Guest("4", "Robert King", "123 6th St.", "Melbourne", "615-555-0169", New CreditCard("346205975312347", Date.Now.AddYears(4), 138)))
            guests_Renamed.Add(New Guest("5", "Laura Callahan", "4 Goldfield Rd.", "Honolulu", "615-555-0169", New CreditCard("340434526813746", Date.Now.AddYears(1), 114)))
            guests_Renamed.Add(New Guest("6", "Michael Suyama", "2 Coffee Street ", "Bergenfield", "615-555-0169", New CreditCard("374041199394364", Date.Now.AddYears(3), 864)))

            Dim start As Date = Date.Today
            Dim bookingId As UInteger = 1
            Dim rand As New Random()

            bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 102, start.AddDays(-1), start.AddDays(1), 250, BookingStatus.Actual))
            bookingId += CUInt(1)
            bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 105, start.AddDays(-2), start, 250, BookingStatus.CheckedOut))
            bookingId += CUInt(1)
            bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 112, start, start.AddDays(1), 250, BookingStatus.Actual))
            bookingId += CUInt(1)
            bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 108, start.AddDays(-1), start, 250, BookingStatus.Cancelled))
            bookingId += CUInt(1)

            For i As Integer = 0 To 14
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 103, start.AddDays(i * 3), start.AddDays(i * 3).AddDays(2), 250, BookingStatus.Actual))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 106, start.AddDays(i), start.AddDays(i).AddDays(i + 3), 400, BookingStatus.Actual))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 101, start.AddDays(2).AddDays(i * 3), start.AddDays(2).AddDays(i * 3).AddDays(3), 300, BookingStatus.Reservation))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 113, start.AddDays(1).AddDays(i * 3), start.AddDays(1).AddDays(i * 3).AddDays(1), 300, BookingStatus.Reservation))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 104, start.AddDays(1).AddDays(i * 3), start.AddDays(1).AddDays(i * 3).AddDays(5), 300, BookingStatus.Reservation))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 105, start.AddDays(-i * 3 + 1), start.AddDays(-i * 3 + 1).AddDays(1), 300, BookingStatus.CheckedOut))
                bookingId += CUInt(1)
            Next i

            For i As Integer = 0 To 4
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 110, start.AddDays(1).AddDays(i * 3), start.AddDays(1).AddDays(i * 3).AddDays(1), 300, BookingStatus.Reservation))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 107, start.AddDays(1).AddDays(i * 3), start.AddDays(1).AddDays(i * 3).AddDays(5), 300, BookingStatus.Cancelled))
                bookingId += CUInt(1)
                bookings_Renamed.Add(New Booking(bookingId, guests_Renamed(rand.Next(0, guests_Renamed.Count)), 111, start.AddDays(-i * 3), start.AddDays(-i * 3).AddDays(1), 300, BookingStatus.Reservation))
                bookingId += CUInt(1)
            Next i

            Me.overviewRoomsView.DataSource = Me.rooms_Renamed
            Me.overviewRoomsView.DisplayMember = "Id"

            Dim statusGroup As New ListViewDataItemGroup()
            statusGroup.Text = "STATUS"

            Dim typesGroup As New ListViewDataItemGroup()
            typesGroup.Text = "TYPE"

            Dim houseKeepingGroup As New ListViewDataItemGroup()
            houseKeepingGroup.Text = "HOUSE KEEPING"

            Me.overviewLeftView.Groups.AddRange(New ListViewDataItemGroup() { statusGroup, typesGroup, houseKeepingGroup })

            Dim statusOptions As Array = System.Enum.GetValues(GetType(RoomStatus))
            For Each item As Object In statusOptions
                Dim statusItem As New ListViewDataItem(item.ToString())
                statusItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
                Me.overviewLeftView.Items.Add(statusItem)
                statusItem.Group = statusGroup
            Next item

            Dim roomOptions As Array = System.Enum.GetValues(GetType(RoomType))
            For Each item As Object In roomOptions
                Dim roomTypeItem As New ListViewDataItem(Utils.GetRoomType(CType(item, RoomType)))
                roomTypeItem.Value = CType(item, RoomType)
                roomTypeItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
                roomTypeItem.Group = typesGroup
                Me.overviewLeftView.Items.Add(roomTypeItem)
            Next item

            Dim houseKeepingOptions As Array = System.Enum.GetValues(GetType(HouseKeepingStatus))
            For Each item As Object In houseKeepingOptions
                Dim houseKeepingItem As New ListViewDataItem(Utils.GetHouseKeepingStatus(CType(item, HouseKeepingStatus)))
                houseKeepingItem.Value = CType(item, HouseKeepingStatus)
                houseKeepingItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
                Me.overviewLeftView.Items.Add(houseKeepingItem)
                houseKeepingItem.Group = houseKeepingGroup
            Next item
            Dim needsRepairItem As New ListViewDataItem("Repair")
            needsRepairItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off
            Me.overviewLeftView.Items.Add(needsRepairItem)
            needsRepairItem.Group = houseKeepingGroup
        End Sub

        Friend Function GetItemByRoomId(ByVal roomId As Integer) As ListViewDataItem
            For Each item As ListViewDataItem In Me.overviewRoomsView.Items
                Dim room_Renamed As Room = TryCast(item.DataBoundItem, Room)
                If room_Renamed IsNot Nothing AndAlso room_Renamed.Id = roomId Then
                    Return item
                End If
            Next item
            Return New ListViewDataItem() With {.Visible = False}
        End Function

        Friend Sub ShowRoomDetails(ByVal room_Renamed As Room, ByVal booking_Renamed As Booking, ByVal comingFrom As String)
            Me.mainContainer.SelectedPage = Me.OverviewPage
            Me.roomDetailsUC_Renamed.Visible = True
            roomDetailsUC_Renamed.InitializeData(room_Renamed, booking_Renamed, comingFrom)
            Me.navigationPanelOverview.Visible = False
        End Sub

        Public Sub HideRoomDetails()
            Me.roomDetailsUC_Renamed.Visible = False
            Me.navigationPanelOverview.Visible = True
            Me.RoomsListView.ListViewElement.SynchronizeVisualItems()
        End Sub

    End Class
End Namespace