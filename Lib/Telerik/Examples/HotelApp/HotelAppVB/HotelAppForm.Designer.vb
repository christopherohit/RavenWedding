Imports CustomControls
Imports Telerik.WinControls.UI

Namespace HotelApp
	Partial Friend Class HotelAppForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tableViewDefinition1 As New Telerik.WinControls.UI.TableViewDefinition()
			Dim schedulerDailyPrintStyle1 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Dim schedulerDailyPrintStyle2 As New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
			Dim tableViewDefinition2 As New Telerik.WinControls.UI.TableViewDefinition()
			Me.materialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
			Me.mainContainer = New Telerik.WinControls.UI.RadPageView()
			Me.OverviewPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.overviewMainContainer = New Telerik.WinControls.UI.RadPanel()
			Me.overviewRoomsView = New Telerik.WinControls.UI.RadListView()
			Me.overviewLeftView = New Telerik.WinControls.UI.RadListView()
			Me.navigationPanelOverview = New Telerik.WinControls.UI.RadPanel()
			Me.searchContainerOverview = New Telerik.WinControls.UI.RadPanel()
			Me.searchTextBoxOverview = New CustomControls.SearchTextBox()
			Me.radPanelEmptyOverview = New Telerik.WinControls.UI.RadPanel()
			Me.dateNavigatorOverview = New CustomControls.DateNavigator()
			Me.BookingsPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.bookingsMainContainer = New Telerik.WinControls.UI.RadPanel()
			Me.bookingsGrid = New Telerik.WinControls.UI.RadGridView()
			Me.labelBookings = New Telerik.WinControls.UI.RadLabel()
			Me.bookingInfoRightPanel = New Telerik.WinControls.UI.RadPanel()
			Me.editGuestInfo_Renamed = New CustomControls.EditGuestInfo()
			Me.bookingInfoUC = New CustomControls.BookingInfo()
			Me.bookingsLeftView = New Telerik.WinControls.UI.RadListView()
			Me.navigationPanelBookings = New Telerik.WinControls.UI.RadPanel()
			Me.searchContainerBookings = New Telerik.WinControls.UI.RadPanel()
			Me.searchTextBoxBookings = New CustomControls.SearchTextBox()
			Me.radPanelEmptyBooking = New Telerik.WinControls.UI.RadPanel()
			Me.dateNavigatorBookings = New CustomControls.DateNavigator()
			Me.SchedulePage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.ScheduleRadScheduler = New Telerik.WinControls.UI.RadScheduler()
			Me.scheduleRadSchedulerHeader = New Telerik.WinControls.UI.RadPanel()
			Me.scheduleBookingPanel = New Telerik.WinControls.UI.RadPanel()
			Me.scheduleBookingInfo = New CustomControls.BookingInfo()
			Me.scheduleEditGuestInfo = New CustomControls.EditGuestInfo()
			Me.scheduleListView = New Telerik.WinControls.UI.RadListView()
			Me.scheduleHeaderPanel = New Telerik.WinControls.UI.RadPanel()
			Me.scheduleWeeklyButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.scheduleMonthlyButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.scheduleDaysButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.scheduleSearchPanel = New Telerik.WinControls.UI.RadPanel()
			Me.scheduleSearchDropDown = New HotelApp.SearchDropDownList()
			Me.scheduleDateNavigator = New CustomControls.DateNavigator()
			Me.HouseKeepingPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.houseKeepingSplitContainer = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
			Me.houseKeepingScheduler = New Telerik.WinControls.UI.RadScheduler()
			Me.houseKeepingSchedulerHeaderLabel = New Telerik.WinControls.UI.RadLabel()
			Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
			Me.notAssignedGridView = New Telerik.WinControls.UI.RadGridView()
			Me.notAssignedLabel = New Telerik.WinControls.UI.RadLabel()
			Me.houseKeepingListView = New Telerik.WinControls.UI.RadListView()
			Me.houseKeepingNavigationPanel = New Telerik.WinControls.UI.RadPanel()
			Me.houseKeepingWeeklyToggleButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.houseKeepingMonthlyToggleButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.houseKeepingDaysToggleButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.houseKeepingDateNavigator = New CustomControls.DateNavigator()
			Me.ReportsPage = New Telerik.WinControls.UI.RadPageViewPage()
			Me.reportsTypePanel = New Telerik.WinControls.UI.RadPanel()
			Me.userControlBookingsByType1 = New HotelApp.UserControlBookingsByType()
			Me.reportsBookingsByTypeLabel = New Telerik.WinControls.UI.RadLabel()
			Me.reportsStatusPanel = New Telerik.WinControls.UI.RadPanel()
			Me.userControlCurrentStatus1 = New HotelApp.UserControlCurrentStatus()
			Me.reportsCurrentStatusLabel = New Telerik.WinControls.UI.RadLabel()
			Me.reportsHeaderPanel = New Telerik.WinControls.UI.RadPanel()
			Me.reportsWeeklyToggleButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.reportsMonthlyToggleButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.reportsDaysToggleButton = New Telerik.WinControls.UI.RadToggleButton()
			Me.reportsDateNavigator = New CustomControls.DateNavigator()
			Me.materialTealTheme1 = New Telerik.WinControls.Themes.MaterialTealTheme()
			Me.materialPinkTheme1 = New Telerik.WinControls.Themes.MaterialPinkTheme()
			Me.materialBlueGreyTheme1 = New Telerik.WinControls.Themes.MaterialBlueGreyTheme()
			CType(Me.mainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mainContainer.SuspendLayout()
			Me.OverviewPage.SuspendLayout()
			CType(Me.overviewMainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.overviewMainContainer.SuspendLayout()
			CType(Me.overviewRoomsView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.overviewLeftView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPanelOverview, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPanelOverview.SuspendLayout()
			CType(Me.searchContainerOverview, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.searchContainerOverview.SuspendLayout()
			CType(Me.searchTextBoxOverview, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelEmptyOverview, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.BookingsPage.SuspendLayout()
			CType(Me.bookingsMainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bookingsMainContainer.SuspendLayout()
			CType(Me.bookingsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingsGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.labelBookings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bookingInfoRightPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bookingInfoRightPanel.SuspendLayout()
			CType(Me.bookingsLeftView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPanelBookings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPanelBookings.SuspendLayout()
			CType(Me.searchContainerBookings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.searchContainerBookings.SuspendLayout()
			CType(Me.searchTextBoxBookings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelEmptyBooking, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SchedulePage.SuspendLayout()
			CType(Me.ScheduleRadScheduler, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scheduleRadSchedulerHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scheduleBookingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.scheduleBookingPanel.SuspendLayout()
			CType(Me.scheduleListView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scheduleHeaderPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.scheduleHeaderPanel.SuspendLayout()
			CType(Me.scheduleWeeklyButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scheduleMonthlyButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scheduleDaysButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scheduleSearchPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.scheduleSearchPanel.SuspendLayout()
			CType(Me.scheduleSearchDropDown, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.HouseKeepingPage.SuspendLayout()
			CType(Me.houseKeepingSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.houseKeepingSplitContainer.SuspendLayout()
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1.SuspendLayout()
			CType(Me.houseKeepingScheduler, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.houseKeepingSchedulerHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2.SuspendLayout()
			CType(Me.notAssignedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.notAssignedGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.notAssignedLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.houseKeepingListView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.houseKeepingNavigationPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.houseKeepingNavigationPanel.SuspendLayout()
			CType(Me.houseKeepingWeeklyToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.houseKeepingMonthlyToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.houseKeepingDaysToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ReportsPage.SuspendLayout()
			CType(Me.reportsTypePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.reportsTypePanel.SuspendLayout()
			CType(Me.reportsBookingsByTypeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.reportsStatusPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.reportsStatusPanel.SuspendLayout()
			CType(Me.reportsCurrentStatusLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.reportsHeaderPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.reportsHeaderPanel.SuspendLayout()
			CType(Me.reportsWeeklyToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.reportsMonthlyToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.reportsDaysToggleButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mainContainer
			' 
			Me.mainContainer.Controls.Add(Me.OverviewPage)
			Me.mainContainer.Controls.Add(Me.BookingsPage)
			Me.mainContainer.Controls.Add(Me.SchedulePage)
			Me.mainContainer.Controls.Add(Me.HouseKeepingPage)
			Me.mainContainer.Controls.Add(Me.ReportsPage)
			Me.mainContainer.Dock = DockStyle.Fill
			Me.mainContainer.Location = New Point(0, 0)
			Me.mainContainer.Name = "mainContainer"
			Me.mainContainer.SelectedPage = Me.OverviewPage
			Me.mainContainer.Size = New Size(1352, 697)
			Me.mainContainer.TabIndex = 0
			Me.mainContainer.Text = "radPageView1"
			' 
			' OverviewPage
			' 
			Me.OverviewPage.Controls.Add(Me.overviewMainContainer)
			Me.OverviewPage.Controls.Add(Me.navigationPanelOverview)
			Me.OverviewPage.ItemSize = New SizeF(71F, 28F)
			Me.OverviewPage.Location = New Point(10, 37)
			Me.OverviewPage.Name = "OverviewPage"
			Me.OverviewPage.Size = New Size(1331, 649)
			Me.OverviewPage.Text = "OVERVIEW"
			' 
			' overviewMainContainer
			' 
			Me.overviewMainContainer.Controls.Add(Me.overviewRoomsView)
			Me.overviewMainContainer.Controls.Add(Me.overviewLeftView)
			Me.overviewMainContainer.Dock = DockStyle.Fill
			Me.overviewMainContainer.Location = New Point(0, 60)
			Me.overviewMainContainer.Margin = New Padding(0)
			Me.overviewMainContainer.Name = "overviewMainContainer"
			Me.overviewMainContainer.Size = New Size(1331, 589)
			Me.overviewMainContainer.TabIndex = 3
			' 
			' overviewRoomsView
			' 
			Me.overviewRoomsView.Dock = DockStyle.Fill
			Me.overviewRoomsView.Location = New Point(269, 0)
			Me.overviewRoomsView.Margin = New Padding(0)
			Me.overviewRoomsView.Name = "overviewRoomsView"
			Me.overviewRoomsView.Size = New Size(1062, 589)
			Me.overviewRoomsView.TabIndex = 2
			Me.overviewRoomsView.Text = "radListView1"
			' 
			' overviewLeftView
			' 
			Me.overviewLeftView.Dock = DockStyle.Left
			Me.overviewLeftView.Location = New Point(0, 0)
			Me.overviewLeftView.Margin = New Padding(0)
			Me.overviewLeftView.Name = "overviewLeftView"
			Me.overviewLeftView.Size = New Size(269, 589)
			Me.overviewLeftView.TabIndex = 1
			Me.overviewLeftView.Text = "radListView1"
			' 
			' navigationPanelOverview
			' 
			Me.navigationPanelOverview.Controls.Add(Me.searchContainerOverview)
			Me.navigationPanelOverview.Controls.Add(Me.dateNavigatorOverview)
			Me.navigationPanelOverview.Dock = DockStyle.Top
			Me.navigationPanelOverview.Location = New Point(0, 0)
			Me.navigationPanelOverview.Margin = New Padding(0)
			Me.navigationPanelOverview.Name = "navigationPanelOverview"
			Me.navigationPanelOverview.Size = New Size(1331, 60)
			Me.navigationPanelOverview.TabIndex = 0
			' 
			' searchContainerOverview
			' 
			Me.searchContainerOverview.Controls.Add(Me.searchTextBoxOverview)
			Me.searchContainerOverview.Controls.Add(Me.radPanelEmptyOverview)
			Me.searchContainerOverview.Dock = DockStyle.Right
			Me.searchContainerOverview.Location = New Point(699, 0)
			Me.searchContainerOverview.Name = "searchContainerOverview"
			Me.searchContainerOverview.Size = New Size(632, 60)
			Me.searchContainerOverview.TabIndex = 1
			' 
			' searchTextBoxOverview
			' 
			Me.searchTextBoxOverview.AutoSize = False
			Me.searchTextBoxOverview.Location = New Point(3, 10)
			Me.searchTextBoxOverview.Name = "searchTextBoxOverview"
			Me.searchTextBoxOverview.NullText = "Search by room# or guest name"
			' 
			' 
			' 
			Me.searchTextBoxOverview.RootElement.CustomFont = "Roboto"
			Me.searchTextBoxOverview.RootElement.CustomFontSize = 8F
			Me.searchTextBoxOverview.Size = New Size(590, 29)
			Me.searchTextBoxOverview.TabIndex = 0
			' 
			' radPanelEmptyOverview
			' 
			Me.radPanelEmptyOverview.BackColor = Color.Transparent
			Me.radPanelEmptyOverview.Dock = DockStyle.Right
			Me.radPanelEmptyOverview.Location = New Point(592, 0)
			Me.radPanelEmptyOverview.Name = "radPanelEmptyOverview"
			Me.radPanelEmptyOverview.Size = New Size(40, 60)
			Me.radPanelEmptyOverview.TabIndex = 1
			' 
			' dateNavigatorOverview
			' 
			Me.dateNavigatorOverview.BackColor = Color.Transparent
			Me.dateNavigatorOverview.Dock = DockStyle.Left
			Me.dateNavigatorOverview.Location = New Point(0, 0)
			Me.dateNavigatorOverview.Name = "dateNavigatorOverview"
			Me.dateNavigatorOverview.Size = New Size(270, 60)
			Me.dateNavigatorOverview.TabIndex = 0
			' 
			' BookingsPage
			' 
			Me.BookingsPage.Controls.Add(Me.bookingsMainContainer)
			Me.BookingsPage.Controls.Add(Me.navigationPanelBookings)
			Me.BookingsPage.ItemSize = New SizeF(72F, 28F)
			Me.BookingsPage.Location = New Point(10, 37)
			Me.BookingsPage.Name = "BookingsPage"
			Me.BookingsPage.Size = New Size(1331, 649)
			Me.BookingsPage.Text = "BOOKINGS"
			' 
			' bookingsMainContainer
			' 
			Me.bookingsMainContainer.Controls.Add(Me.bookingsGrid)
			Me.bookingsMainContainer.Controls.Add(Me.labelBookings)
			Me.bookingsMainContainer.Controls.Add(Me.bookingInfoRightPanel)
			Me.bookingsMainContainer.Controls.Add(Me.bookingsLeftView)
			Me.bookingsMainContainer.Dock = DockStyle.Fill
			Me.bookingsMainContainer.Location = New Point(0, 60)
			Me.bookingsMainContainer.Name = "bookingsMainContainer"
			Me.bookingsMainContainer.Size = New Size(1331, 589)
			Me.bookingsMainContainer.TabIndex = 3
			' 
			' bookingsGrid
			' 
			Me.bookingsGrid.Dock = DockStyle.Fill
			Me.bookingsGrid.Location = New Point(269, 50)
			Me.bookingsGrid.Margin = New Padding(20, 3, 20, 3)
			' 
			' 
			' 
			Me.bookingsGrid.MasterTemplate.ViewDefinition = tableViewDefinition1
			Me.bookingsGrid.Name = "bookingsGrid"
			Me.bookingsGrid.Size = New Size(792, 539)
			Me.bookingsGrid.TabIndex = 5
			Me.bookingsGrid.Text = "radGridView1"
			' 
			' labelBookings
			' 
			Me.labelBookings.AutoSize = False
			Me.labelBookings.Dock = DockStyle.Top
			Me.labelBookings.Location = New Point(269, 0)
			Me.labelBookings.Name = "labelBookings"
			Me.labelBookings.Size = New Size(792, 50)
			Me.labelBookings.TabIndex = 4
			Me.labelBookings.Text = "Occupied by"
			Me.labelBookings.TextAlignment = ContentAlignment.BottomLeft
			' 
			' bookingInfoRightPanel
			' 
			Me.bookingInfoRightPanel.Controls.Add(Me.editGuestInfo_Renamed)
			Me.bookingInfoRightPanel.Controls.Add(Me.bookingInfoUC)
			Me.bookingInfoRightPanel.Dock = DockStyle.Right
			Me.bookingInfoRightPanel.Location = New Point(1061, 0)
			Me.bookingInfoRightPanel.Name = "bookingInfoRightPanel"
			Me.bookingInfoRightPanel.Size = New Size(270, 589)
			Me.bookingInfoRightPanel.TabIndex = 1
			' 
			' editGuestInfo
			' 
			Me.editGuestInfo_Renamed.Dock = DockStyle.Fill
			Me.editGuestInfo_Renamed.Location = New Point(0, 0)
			Me.editGuestInfo_Renamed.Name = "editGuestInfo"
			Me.editGuestInfo_Renamed.Size = New Size(270, 589)
			Me.editGuestInfo_Renamed.TabIndex = 1
			' 
			' bookingInfoUC
			' 
			Me.bookingInfoUC.Booking = Nothing
			Me.bookingInfoUC.Dock = DockStyle.Fill
			Me.bookingInfoUC.Location = New Point(0, 0)
			Me.bookingInfoUC.Name = "bookingInfoUC"
			Me.bookingInfoUC.Room = Nothing
			Me.bookingInfoUC.Size = New Size(270, 589)
			Me.bookingInfoUC.TabIndex = 0
			' 
			' bookingsLeftView
			' 
			Me.bookingsLeftView.Dock = DockStyle.Left
			Me.bookingsLeftView.Location = New Point(0, 0)
			Me.bookingsLeftView.Name = "bookingsLeftView"
			Me.bookingsLeftView.Size = New Size(269, 589)
			Me.bookingsLeftView.TabIndex = 2
			Me.bookingsLeftView.Text = "radListView1"
			' 
			' navigationPanelBookings
			' 
			Me.navigationPanelBookings.Controls.Add(Me.searchContainerBookings)
			Me.navigationPanelBookings.Controls.Add(Me.dateNavigatorBookings)
			Me.navigationPanelBookings.Dock = DockStyle.Top
			Me.navigationPanelBookings.Location = New Point(0, 0)
			Me.navigationPanelBookings.Name = "navigationPanelBookings"
			Me.navigationPanelBookings.Size = New Size(1331, 60)
			Me.navigationPanelBookings.TabIndex = 1
			' 
			' searchContainerBookings
			' 
			Me.searchContainerBookings.Controls.Add(Me.searchTextBoxBookings)
			Me.searchContainerBookings.Controls.Add(Me.radPanelEmptyBooking)
			Me.searchContainerBookings.Dock = DockStyle.Right
			Me.searchContainerBookings.Location = New Point(699, 0)
			Me.searchContainerBookings.Name = "searchContainerBookings"
			Me.searchContainerBookings.Size = New Size(632, 60)
			Me.searchContainerBookings.TabIndex = 1
			' 
			' searchTextBoxBookings
			' 
			Me.searchTextBoxBookings.AutoSize = False
			Me.searchTextBoxBookings.Location = New Point(3, 10)
			Me.searchTextBoxBookings.Name = "searchTextBoxBookings"
			Me.searchTextBoxBookings.NullText = "Search by room# or guest name"
			' 
			' 
			' 
			Me.searchTextBoxBookings.RootElement.CustomFont = "Roboto"
			Me.searchTextBoxBookings.RootElement.CustomFontSize = 8F
			Me.searchTextBoxBookings.Size = New Size(590, 29)
			Me.searchTextBoxBookings.TabIndex = 0
			' 
			' radPanelEmptyBooking
			' 
			Me.radPanelEmptyBooking.Dock = DockStyle.Right
			Me.radPanelEmptyBooking.Location = New Point(592, 0)
			Me.radPanelEmptyBooking.Name = "radPanelEmptyBooking"
			Me.radPanelEmptyBooking.Size = New Size(40, 60)
			Me.radPanelEmptyBooking.TabIndex = 1
			' 
			' dateNavigatorBookings
			' 
			Me.dateNavigatorBookings.BackColor = Color.Transparent
			Me.dateNavigatorBookings.Dock = DockStyle.Left
			Me.dateNavigatorBookings.Location = New Point(0, 0)
			Me.dateNavigatorBookings.Name = "dateNavigatorBookings"
			Me.dateNavigatorBookings.Size = New Size(270, 60)
			Me.dateNavigatorBookings.TabIndex = 0
			' 
			' SchedulePage
			' 
			Me.SchedulePage.Controls.Add(Me.ScheduleRadScheduler)
			Me.SchedulePage.Controls.Add(Me.scheduleRadSchedulerHeader)
			Me.SchedulePage.Controls.Add(Me.scheduleBookingPanel)
			Me.SchedulePage.Controls.Add(Me.scheduleListView)
			Me.SchedulePage.Controls.Add(Me.scheduleHeaderPanel)
			Me.SchedulePage.ItemSize = New SizeF(70F, 28F)
			Me.SchedulePage.Location = New Point(10, 37)
			Me.SchedulePage.Name = "SchedulePage"
			Me.SchedulePage.Size = New Size(1331, 649)
			Me.SchedulePage.Text = "SCHEDULE"
			' 
			' ScheduleRadScheduler
			' 
			Me.ScheduleRadScheduler.Culture = New System.Globalization.CultureInfo("en-US")
			Me.ScheduleRadScheduler.Dock = DockStyle.Fill
			Me.ScheduleRadScheduler.Location = New Point(269, 120)
			Me.ScheduleRadScheduler.Name = "ScheduleRadScheduler"
			schedulerDailyPrintStyle1.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle1.DateEndRange = New Date(2017, 7, 23, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle1.DateStartRange = New Date(2017, 7, 18, 0, 0, 0, 0)
			schedulerDailyPrintStyle1.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.ScheduleRadScheduler.PrintStyle = schedulerDailyPrintStyle1
			Me.ScheduleRadScheduler.Size = New Size(792, 529)
			Me.ScheduleRadScheduler.TabIndex = 4
			Me.ScheduleRadScheduler.Text = "radScheduler1"
			' 
			' scheduleRadSchedulerHeader
			' 
			Me.scheduleRadSchedulerHeader.Dock = DockStyle.Top
			Me.scheduleRadSchedulerHeader.Location = New Point(269, 60)
			Me.scheduleRadSchedulerHeader.Name = "scheduleRadSchedulerHeader"
			Me.scheduleRadSchedulerHeader.Size = New Size(792, 60)
			Me.scheduleRadSchedulerHeader.TabIndex = 3
			' 
			' scheduleBookingPanel
			' 
			Me.scheduleBookingPanel.Controls.Add(Me.scheduleBookingInfo)
			Me.scheduleBookingPanel.Controls.Add(Me.scheduleEditGuestInfo)
			Me.scheduleBookingPanel.Dock = DockStyle.Right
			Me.scheduleBookingPanel.Location = New Point(1061, 60)
			Me.scheduleBookingPanel.Name = "scheduleBookingPanel"
			Me.scheduleBookingPanel.Size = New Size(270, 589)
			Me.scheduleBookingPanel.TabIndex = 2
			' 
			' scheduleBookingInfo
			' 
			Me.scheduleBookingInfo.Booking = Nothing
			Me.scheduleBookingInfo.Dock = DockStyle.Fill
			Me.scheduleBookingInfo.Location = New Point(0, 0)
			Me.scheduleBookingInfo.Name = "scheduleBookingInfo"
			Me.scheduleBookingInfo.Room = Nothing
			Me.scheduleBookingInfo.Size = New Size(270, 589)
			Me.scheduleBookingInfo.TabIndex = 0
			' 
			' scheduleEditGuestInfo
			' 
			Me.scheduleEditGuestInfo.Dock = DockStyle.Fill
			Me.scheduleEditGuestInfo.Location = New Point(0, 0)
			Me.scheduleEditGuestInfo.Name = "scheduleEditGuestInfo"
			Me.scheduleEditGuestInfo.Size = New Size(270, 589)
			Me.scheduleEditGuestInfo.TabIndex = 0
			' 
			' scheduleListView
			' 
			Me.scheduleListView.Dock = DockStyle.Left
			Me.scheduleListView.Location = New Point(0, 60)
			Me.scheduleListView.Name = "scheduleListView"
			Me.scheduleListView.Size = New Size(269, 589)
			Me.scheduleListView.TabIndex = 1
			Me.scheduleListView.Text = "radListView1"
			' 
			' scheduleHeaderPanel
			' 
			Me.scheduleHeaderPanel.Controls.Add(Me.scheduleWeeklyButton)
			Me.scheduleHeaderPanel.Controls.Add(Me.scheduleMonthlyButton)
			Me.scheduleHeaderPanel.Controls.Add(Me.scheduleDaysButton)
			Me.scheduleHeaderPanel.Controls.Add(Me.scheduleSearchPanel)
			Me.scheduleHeaderPanel.Controls.Add(Me.scheduleDateNavigator)
			Me.scheduleHeaderPanel.Dock = DockStyle.Top
			Me.scheduleHeaderPanel.Location = New Point(0, 0)
			Me.scheduleHeaderPanel.Name = "scheduleHeaderPanel"
			Me.scheduleHeaderPanel.Size = New Size(1331, 60)
			Me.scheduleHeaderPanel.TabIndex = 0
			' 
			' scheduleWeeklyButton
			' 
			Me.scheduleWeeklyButton.Location = New Point(392, 12)
			Me.scheduleWeeklyButton.Name = "scheduleWeeklyButton"
			Me.scheduleWeeklyButton.Size = New Size(100, 24)
			Me.scheduleWeeklyButton.TabIndex = 3
			Me.scheduleWeeklyButton.Text = "Weekly"
			' 
			' scheduleMonthlyButton
			' 
			Me.scheduleMonthlyButton.Location = New Point(494, 12)
			Me.scheduleMonthlyButton.Name = "scheduleMonthlyButton"
			Me.scheduleMonthlyButton.Size = New Size(100, 24)
			Me.scheduleMonthlyButton.TabIndex = 4
			Me.scheduleMonthlyButton.Text = "Monthly"
			' 
			' scheduleDaysButton
			' 
			Me.scheduleDaysButton.Location = New Point(290, 12)
			Me.scheduleDaysButton.Name = "scheduleDaysButton"
			Me.scheduleDaysButton.Size = New Size(100, 24)
			Me.scheduleDaysButton.TabIndex = 2
			Me.scheduleDaysButton.Text = "3 Days"
			' 
			' scheduleSearchPanel
			' 
			Me.scheduleSearchPanel.Controls.Add(Me.scheduleSearchDropDown)
			Me.scheduleSearchPanel.Dock = DockStyle.Right
			Me.scheduleSearchPanel.Location = New Point(681, 0)
			Me.scheduleSearchPanel.Name = "scheduleSearchPanel"
			Me.scheduleSearchPanel.Size = New Size(650, 60)
			Me.scheduleSearchPanel.TabIndex = 1
			' 
			' scheduleSearchDropDown
			' 
			Me.scheduleSearchDropDown.Location = New Point(21, 8)
			Me.scheduleSearchDropDown.Name = "scheduleSearchDropDown"
			Me.scheduleSearchDropDown.NullText = "Search by room# or guest name"
			' 
			' 
			' 
			Me.scheduleSearchDropDown.RootElement.EnableElementShadow = False
			Me.scheduleSearchDropDown.Size = New Size(589, 25)
			Me.scheduleSearchDropDown.TabIndex = 0
			' 
			' scheduleDateNavigator
			' 
			Me.scheduleDateNavigator.BackColor = Color.Transparent
			Me.scheduleDateNavigator.Dock = DockStyle.Left
			Me.scheduleDateNavigator.Location = New Point(0, 0)
			Me.scheduleDateNavigator.Name = "scheduleDateNavigator"
			Me.scheduleDateNavigator.Size = New Size(270, 60)
			Me.scheduleDateNavigator.TabIndex = 0
			' 
			' HouseKeepingPage
			' 
			Me.HouseKeepingPage.Controls.Add(Me.houseKeepingSplitContainer)
			Me.HouseKeepingPage.Controls.Add(Me.houseKeepingListView)
			Me.HouseKeepingPage.Controls.Add(Me.houseKeepingNavigationPanel)
			Me.HouseKeepingPage.ItemSize = New SizeF(99F, 28F)
			Me.HouseKeepingPage.Location = New Point(10, 37)
			Me.HouseKeepingPage.Name = "HouseKeepingPage"
			Me.HouseKeepingPage.Size = New Size(1331, 649)
			Me.HouseKeepingPage.Text = "HOUSE KEEPING"
			' 
			' houseKeepingSplitContainer
			' 
			Me.houseKeepingSplitContainer.Controls.Add(Me.splitPanel1)
			Me.houseKeepingSplitContainer.Controls.Add(Me.splitPanel2)
			Me.houseKeepingSplitContainer.Dock = DockStyle.Fill
			Me.houseKeepingSplitContainer.Location = New Point(269, 60)
			Me.houseKeepingSplitContainer.Name = "houseKeepingSplitContainer"
			Me.houseKeepingSplitContainer.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.houseKeepingSplitContainer.RootElement.MinSize = New Size(25, 25)
			Me.houseKeepingSplitContainer.Size = New Size(1062, 589)
			Me.houseKeepingSplitContainer.TabIndex = 6
			Me.houseKeepingSplitContainer.TabStop = False
			' 
			' splitPanel1
			' 
			Me.splitPanel1.Controls.Add(Me.houseKeepingScheduler)
			Me.splitPanel1.Controls.Add(Me.houseKeepingSchedulerHeaderLabel)
			Me.splitPanel1.Location = New Point(0, 0)
			Me.splitPanel1.Name = "splitPanel1"
			' 
			' 
			' 
			Me.splitPanel1.RootElement.MinSize = New Size(25, 25)
			Me.splitPanel1.Size = New Size(1062, 292)
			Me.splitPanel1.TabIndex = 0
			Me.splitPanel1.TabStop = False
			' 
			' houseKeepingScheduler
			' 
			Me.houseKeepingScheduler.Culture = New System.Globalization.CultureInfo("en-US")
			Me.houseKeepingScheduler.Dock = DockStyle.Fill
			Me.houseKeepingScheduler.Location = New Point(0, 60)
			Me.houseKeepingScheduler.Name = "houseKeepingScheduler"
			schedulerDailyPrintStyle2.AppointmentFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			schedulerDailyPrintStyle2.DateEndRange = New Date(2017, 8, 6, 0, 0, 0, 0)
			schedulerDailyPrintStyle2.DateHeadingFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			schedulerDailyPrintStyle2.DateStartRange = New Date(2017, 8, 1, 0, 0, 0, 0)
			schedulerDailyPrintStyle2.PageHeadingFont = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
			Me.houseKeepingScheduler.PrintStyle = schedulerDailyPrintStyle2
			Me.houseKeepingScheduler.Size = New Size(1062, 232)
			Me.houseKeepingScheduler.TabIndex = 5
			Me.houseKeepingScheduler.Text = "radScheduler1"
			' 
			' houseKeepingSchedulerHeaderLabel
			' 
			Me.houseKeepingSchedulerHeaderLabel.AutoSize = False
			Me.houseKeepingSchedulerHeaderLabel.Dock = DockStyle.Top
			Me.houseKeepingSchedulerHeaderLabel.Location = New Point(0, 0)
			Me.houseKeepingSchedulerHeaderLabel.Name = "houseKeepingSchedulerHeaderLabel"
			Me.houseKeepingSchedulerHeaderLabel.Size = New Size(1062, 60)
			Me.houseKeepingSchedulerHeaderLabel.TabIndex = 4
			Me.houseKeepingSchedulerHeaderLabel.Text = "radLabel1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2.Controls.Add(Me.notAssignedGridView)
			Me.splitPanel2.Controls.Add(Me.notAssignedLabel)
			Me.splitPanel2.Location = New Point(0, 296)
			Me.splitPanel2.Name = "splitPanel2"
			' 
			' 
			' 
			Me.splitPanel2.RootElement.MinSize = New Size(25, 25)
			Me.splitPanel2.Size = New Size(1062, 293)
			Me.splitPanel2.TabIndex = 1
			Me.splitPanel2.TabStop = False
			' 
			' notAssignedGridView
			' 
			Me.notAssignedGridView.Dock = DockStyle.Fill
			Me.notAssignedGridView.Location = New Point(0, 30)
			' 
			' 
			' 
			Me.notAssignedGridView.MasterTemplate.ViewDefinition = tableViewDefinition2
			Me.notAssignedGridView.Name = "notAssignedGridView"
			Me.notAssignedGridView.Size = New Size(1062, 263)
			Me.notAssignedGridView.TabIndex = 2
			Me.notAssignedGridView.Text = "radGridView1"
			' 
			' notAssignedLabel
			' 
			Me.notAssignedLabel.AutoSize = False
			Me.notAssignedLabel.Dock = DockStyle.Top
			Me.notAssignedLabel.Location = New Point(0, 0)
			Me.notAssignedLabel.Name = "notAssignedLabel"
			Me.notAssignedLabel.Size = New Size(1062, 30)
			Me.notAssignedLabel.TabIndex = 3
			Me.notAssignedLabel.Text = "Not assigned rooms"
			' 
			' houseKeepingListView
			' 
			Me.houseKeepingListView.Dock = DockStyle.Left
			Me.houseKeepingListView.Location = New Point(0, 60)
			Me.houseKeepingListView.Name = "houseKeepingListView"
			Me.houseKeepingListView.Size = New Size(269, 589)
			Me.houseKeepingListView.TabIndex = 1
			Me.houseKeepingListView.Text = "radListView1"
			' 
			' houseKeepingNavigationPanel
			' 
			Me.houseKeepingNavigationPanel.Controls.Add(Me.houseKeepingWeeklyToggleButton)
			Me.houseKeepingNavigationPanel.Controls.Add(Me.houseKeepingMonthlyToggleButton)
			Me.houseKeepingNavigationPanel.Controls.Add(Me.houseKeepingDaysToggleButton)
			Me.houseKeepingNavigationPanel.Controls.Add(Me.houseKeepingDateNavigator)
			Me.houseKeepingNavigationPanel.Dock = DockStyle.Top
			Me.houseKeepingNavigationPanel.Location = New Point(0, 0)
			Me.houseKeepingNavigationPanel.Name = "houseKeepingNavigationPanel"
			Me.houseKeepingNavigationPanel.Size = New Size(1331, 60)
			Me.houseKeepingNavigationPanel.TabIndex = 0
			' 
			' houseKeepingWeeklyToggleButton
			' 
			Me.houseKeepingWeeklyToggleButton.Location = New Point(392, 12)
			Me.houseKeepingWeeklyToggleButton.Name = "houseKeepingWeeklyToggleButton"
			Me.houseKeepingWeeklyToggleButton.Size = New Size(100, 24)
			Me.houseKeepingWeeklyToggleButton.TabIndex = 6
			Me.houseKeepingWeeklyToggleButton.Text = "Weekly"
			' 
			' houseKeepingMonthlyToggleButton
			' 
			Me.houseKeepingMonthlyToggleButton.Location = New Point(494, 12)
			Me.houseKeepingMonthlyToggleButton.Name = "houseKeepingMonthlyToggleButton"
			Me.houseKeepingMonthlyToggleButton.Size = New Size(100, 24)
			Me.houseKeepingMonthlyToggleButton.TabIndex = 7
			Me.houseKeepingMonthlyToggleButton.Text = "Monthly"
			' 
			' houseKeepingDaysToggleButton
			' 
			Me.houseKeepingDaysToggleButton.Location = New Point(290, 12)
			Me.houseKeepingDaysToggleButton.Name = "houseKeepingDaysToggleButton"
			Me.houseKeepingDaysToggleButton.Size = New Size(100, 24)
			Me.houseKeepingDaysToggleButton.TabIndex = 5
			Me.houseKeepingDaysToggleButton.Text = "3 Days"
			' 
			' houseKeepingDateNavigator
			' 
			Me.houseKeepingDateNavigator.BackColor = Color.Transparent
			Me.houseKeepingDateNavigator.Dock = DockStyle.Left
			Me.houseKeepingDateNavigator.Location = New Point(0, 0)
			Me.houseKeepingDateNavigator.Name = "houseKeepingDateNavigator"
			Me.houseKeepingDateNavigator.Size = New Size(270, 60)
			Me.houseKeepingDateNavigator.TabIndex = 1
			' 
			' ReportsPage
			' 
			Me.ReportsPage.Controls.Add(Me.reportsTypePanel)
			Me.ReportsPage.Controls.Add(Me.reportsStatusPanel)
			Me.ReportsPage.Controls.Add(Me.reportsHeaderPanel)
			Me.ReportsPage.ItemSize = New SizeF(62F, 28F)
			Me.ReportsPage.Location = New Point(10, 37)
			Me.ReportsPage.Name = "ReportsPage"
			Me.ReportsPage.Size = New Size(1331, 649)
			Me.ReportsPage.Text = "REPORTS"
			' 
			' reportsTypePanel
			' 
			Me.reportsTypePanel.Controls.Add(Me.userControlBookingsByType1)
			Me.reportsTypePanel.Controls.Add(Me.reportsBookingsByTypeLabel)
			Me.reportsTypePanel.Dock = DockStyle.Fill
			Me.reportsTypePanel.Location = New Point(0, 450)
			Me.reportsTypePanel.Name = "reportsTypePanel"
			Me.reportsTypePanel.Size = New Size(1331, 199)
			Me.reportsTypePanel.TabIndex = 2
			' 
			' userControlBookingsByType1
			' 
			Me.userControlBookingsByType1.Dock = DockStyle.Fill
			Me.userControlBookingsByType1.Location = New Point(0, 50)
			Me.userControlBookingsByType1.Name = "userControlBookingsByType1"
			Me.userControlBookingsByType1.Size = New Size(1331, 149)
			Me.userControlBookingsByType1.TabIndex = 2
			' 
			' reportsBookingsByTypeLabel
			' 
			Me.reportsBookingsByTypeLabel.AutoSize = False
			Me.reportsBookingsByTypeLabel.Dock = DockStyle.Top
			Me.reportsBookingsByTypeLabel.Location = New Point(0, 0)
			Me.reportsBookingsByTypeLabel.Name = "reportsBookingsByTypeLabel"
			Me.reportsBookingsByTypeLabel.Size = New Size(1331, 50)
			Me.reportsBookingsByTypeLabel.TabIndex = 0
			Me.reportsBookingsByTypeLabel.Text = "Bookings by Type"
			' 
			' reportsStatusPanel
			' 
			Me.reportsStatusPanel.Controls.Add(Me.userControlCurrentStatus1)
			Me.reportsStatusPanel.Controls.Add(Me.reportsCurrentStatusLabel)
			Me.reportsStatusPanel.Dock = DockStyle.Top
			Me.reportsStatusPanel.Location = New Point(0, 60)
			Me.reportsStatusPanel.Name = "reportsStatusPanel"
			Me.reportsStatusPanel.Size = New Size(1331, 390)
			Me.reportsStatusPanel.TabIndex = 1
			' 
			' userControlCurrentStatus1
			' 
			Me.userControlCurrentStatus1.Dock = DockStyle.Fill
			Me.userControlCurrentStatus1.Location = New Point(0, 50)
			Me.userControlCurrentStatus1.Name = "userControlCurrentStatus1"
			Me.userControlCurrentStatus1.Size = New Size(1331, 340)
			Me.userControlCurrentStatus1.TabIndex = 1
			' 
			' reportsCurrentStatusLabel
			' 
			Me.reportsCurrentStatusLabel.AutoSize = False
			Me.reportsCurrentStatusLabel.Dock = DockStyle.Top
			Me.reportsCurrentStatusLabel.Location = New Point(0, 0)
			Me.reportsCurrentStatusLabel.Name = "reportsCurrentStatusLabel"
			Me.reportsCurrentStatusLabel.Size = New Size(1331, 50)
			Me.reportsCurrentStatusLabel.TabIndex = 0
			Me.reportsCurrentStatusLabel.Text = "Current Status"
			' 
			' reportsHeaderPanel
			' 
			Me.reportsHeaderPanel.Controls.Add(Me.reportsWeeklyToggleButton)
			Me.reportsHeaderPanel.Controls.Add(Me.reportsMonthlyToggleButton)
			Me.reportsHeaderPanel.Controls.Add(Me.reportsDaysToggleButton)
			Me.reportsHeaderPanel.Controls.Add(Me.reportsDateNavigator)
			Me.reportsHeaderPanel.Dock = DockStyle.Top
			Me.reportsHeaderPanel.Location = New Point(0, 0)
			Me.reportsHeaderPanel.Name = "reportsHeaderPanel"
			Me.reportsHeaderPanel.Size = New Size(1331, 60)
			Me.reportsHeaderPanel.TabIndex = 0
			' 
			' reportsWeeklyToggleButton
			' 
			Me.reportsWeeklyToggleButton.Location = New Point(392, 12)
			Me.reportsWeeklyToggleButton.Name = "reportsWeeklyToggleButton"
			Me.reportsWeeklyToggleButton.Size = New Size(100, 24)
			Me.reportsWeeklyToggleButton.TabIndex = 9
			Me.reportsWeeklyToggleButton.Text = "Weekly"
			' 
			' reportsMonthlyToggleButton
			' 
			Me.reportsMonthlyToggleButton.Location = New Point(494, 12)
			Me.reportsMonthlyToggleButton.Name = "reportsMonthlyToggleButton"
			Me.reportsMonthlyToggleButton.Size = New Size(100, 24)
			Me.reportsMonthlyToggleButton.TabIndex = 10
			Me.reportsMonthlyToggleButton.Text = "Monthly"
			' 
			' reportsDaysToggleButton
			' 
			Me.reportsDaysToggleButton.Location = New Point(290, 12)
			Me.reportsDaysToggleButton.Name = "reportsDaysToggleButton"
			Me.reportsDaysToggleButton.Size = New Size(100, 24)
			Me.reportsDaysToggleButton.TabIndex = 8
			Me.reportsDaysToggleButton.Text = "3 Days"
			' 
			' reportsDateNavigator
			' 
			Me.reportsDateNavigator.BackColor = Color.Transparent
			Me.reportsDateNavigator.Dock = DockStyle.Left
			Me.reportsDateNavigator.Location = New Point(0, 0)
			Me.reportsDateNavigator.Name = "reportsDateNavigator"
			Me.reportsDateNavigator.Size = New Size(270, 60)
			Me.reportsDateNavigator.TabIndex = 2
			' 
			' HotelAppForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(1352, 697)
			Me.Controls.Add(Me.mainContainer)
			Me.Name = "HotelAppForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.HotelApp_Load)
			CType(Me.mainContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.mainContainer.ResumeLayout(False)
			Me.OverviewPage.ResumeLayout(False)
			CType(Me.overviewMainContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.overviewMainContainer.ResumeLayout(False)
			CType(Me.overviewRoomsView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.overviewLeftView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPanelOverview, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPanelOverview.ResumeLayout(False)
			CType(Me.searchContainerOverview, System.ComponentModel.ISupportInitialize).EndInit()
			Me.searchContainerOverview.ResumeLayout(False)
			CType(Me.searchTextBoxOverview, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelEmptyOverview, System.ComponentModel.ISupportInitialize).EndInit()
			Me.BookingsPage.ResumeLayout(False)
			CType(Me.bookingsMainContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bookingsMainContainer.ResumeLayout(False)
			CType(Me.bookingsGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingsGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.labelBookings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bookingInfoRightPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bookingInfoRightPanel.ResumeLayout(False)
			CType(Me.bookingsLeftView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPanelBookings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPanelBookings.ResumeLayout(False)
			CType(Me.searchContainerBookings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.searchContainerBookings.ResumeLayout(False)
			CType(Me.searchTextBoxBookings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelEmptyBooking, System.ComponentModel.ISupportInitialize).EndInit()
			Me.SchedulePage.ResumeLayout(False)
			CType(Me.ScheduleRadScheduler, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scheduleRadSchedulerHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scheduleBookingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.scheduleBookingPanel.ResumeLayout(False)
			CType(Me.scheduleListView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scheduleHeaderPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.scheduleHeaderPanel.ResumeLayout(False)
			CType(Me.scheduleWeeklyButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scheduleMonthlyButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scheduleDaysButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scheduleSearchPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.scheduleSearchPanel.ResumeLayout(False)
			Me.scheduleSearchPanel.PerformLayout()
			CType(Me.scheduleSearchDropDown, System.ComponentModel.ISupportInitialize).EndInit()
			Me.HouseKeepingPage.ResumeLayout(False)
			CType(Me.houseKeepingSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.houseKeepingSplitContainer.ResumeLayout(False)
			CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1.ResumeLayout(False)
			CType(Me.houseKeepingScheduler, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.houseKeepingSchedulerHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2.ResumeLayout(False)
			CType(Me.notAssignedGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.notAssignedGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.notAssignedLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.houseKeepingListView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.houseKeepingNavigationPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.houseKeepingNavigationPanel.ResumeLayout(False)
			CType(Me.houseKeepingWeeklyToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.houseKeepingMonthlyToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.houseKeepingDaysToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ReportsPage.ResumeLayout(False)
			CType(Me.reportsTypePanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.reportsTypePanel.ResumeLayout(False)
			CType(Me.reportsBookingsByTypeLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.reportsStatusPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.reportsStatusPanel.ResumeLayout(False)
			CType(Me.reportsCurrentStatusLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.reportsHeaderPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.reportsHeaderPanel.ResumeLayout(False)
			CType(Me.reportsWeeklyToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.reportsMonthlyToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.reportsDaysToggleButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private materialTheme1 As Telerik.WinControls.Themes.MaterialTheme
		Private mainContainer As Telerik.WinControls.UI.RadPageView
		Private OverviewPage As Telerik.WinControls.UI.RadPageViewPage
		Private BookingsPage As Telerik.WinControls.UI.RadPageViewPage
		Private SchedulePage As Telerik.WinControls.UI.RadPageViewPage
		Private HouseKeepingPage As Telerik.WinControls.UI.RadPageViewPage
		Private navigationPanelOverview As Telerik.WinControls.UI.RadPanel
		Private overviewLeftView As Telerik.WinControls.UI.RadListView
		Private overviewRoomsView As Telerik.WinControls.UI.RadListView
		Private dateNavigatorOverview As DateNavigator
		Private searchContainerOverview As Telerik.WinControls.UI.RadPanel
		Private searchTextBoxOverview As SearchTextBox
		Private radPanelEmptyOverview As Telerik.WinControls.UI.RadPanel
		Private navigationPanelBookings As Telerik.WinControls.UI.RadPanel
		Private searchContainerBookings As Telerik.WinControls.UI.RadPanel
		Private searchTextBoxBookings As SearchTextBox
		Private radPanelEmptyBooking As Telerik.WinControls.UI.RadPanel
		Private dateNavigatorBookings As DateNavigator
		Private bookingsLeftView As Telerik.WinControls.UI.RadListView
		Private bookingsMainContainer As Telerik.WinControls.UI.RadPanel
		Private bookingsGrid As Telerik.WinControls.UI.RadGridView
		Private labelBookings As Telerik.WinControls.UI.RadLabel
		Private overviewMainContainer As Telerik.WinControls.UI.RadPanel
		Private ReportsPage As Telerik.WinControls.UI.RadPageViewPage
		Private bookingInfoRightPanel As Telerik.WinControls.UI.RadPanel
		Private bookingInfoUC As BookingInfo
'INSTANT VB NOTE: The variable editGuestInfo was renamed since Visual Basic does not handle variables named the same as their type well:
		Private editGuestInfo_Renamed As EditGuestInfo
		Private scheduleHeaderPanel As Telerik.WinControls.UI.RadPanel
		Private scheduleListView As Telerik.WinControls.UI.RadListView
		Private scheduleDateNavigator As DateNavigator
		Private scheduleSearchPanel As Telerik.WinControls.UI.RadPanel
		Private scheduleMonthlyButton As Telerik.WinControls.UI.RadToggleButton
		Private scheduleWeeklyButton As Telerik.WinControls.UI.RadToggleButton
		Private scheduleDaysButton As Telerik.WinControls.UI.RadToggleButton
		Private scheduleBookingPanel As Telerik.WinControls.UI.RadPanel
		Private scheduleBookingInfo As BookingInfo
		Private ScheduleRadScheduler As Telerik.WinControls.UI.RadScheduler
		Private scheduleRadSchedulerHeader As Telerik.WinControls.UI.RadPanel
		Private scheduleEditGuestInfo As EditGuestInfo
		Private scheduleSearchDropDown As SearchDropDownList
		Private notAssignedLabel As Telerik.WinControls.UI.RadLabel
		Private notAssignedGridView As Telerik.WinControls.UI.RadGridView
		Private houseKeepingListView As Telerik.WinControls.UI.RadListView
		Private houseKeepingNavigationPanel As Telerik.WinControls.UI.RadPanel
		Private houseKeepingScheduler As Telerik.WinControls.UI.RadScheduler
		Private houseKeepingSchedulerHeaderLabel As Telerik.WinControls.UI.RadLabel
		Private houseKeepingDateNavigator As DateNavigator
		Private houseKeepingWeeklyToggleButton As Telerik.WinControls.UI.RadToggleButton
		Private houseKeepingMonthlyToggleButton As Telerik.WinControls.UI.RadToggleButton
		Private houseKeepingDaysToggleButton As Telerik.WinControls.UI.RadToggleButton
		Private houseKeepingSplitContainer As RadSplitContainer
		Private splitPanel1 As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2 As Telerik.WinControls.UI.SplitPanel
		Private reportsHeaderPanel As RadPanel
		Private reportsTypePanel As RadPanel
		Private reportsStatusPanel As RadPanel
		Private reportsDateNavigator As DateNavigator
		Private reportsWeeklyToggleButton As RadToggleButton
		Private reportsMonthlyToggleButton As RadToggleButton
		Private reportsDaysToggleButton As RadToggleButton
		Private materialTealTheme1 As Telerik.WinControls.Themes.MaterialTealTheme
		Private materialPinkTheme1 As Telerik.WinControls.Themes.MaterialPinkTheme
		Private materialBlueGreyTheme1 As Telerik.WinControls.Themes.MaterialBlueGreyTheme
		Private reportsBookingsByTypeLabel As RadLabel
		Private userControlCurrentStatus1 As UserControlCurrentStatus
		Private reportsCurrentStatusLabel As RadLabel
		Private userControlBookingsByType1 As UserControlBookingsByType
	End Class
End Namespace