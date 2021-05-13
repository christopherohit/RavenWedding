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

		Private Sub InitHouseKeepingPage()
'			#Region "HouseKeeping"

			Me.houseKeepingNavigationPanel.BackgroundImage = My.Resources.fasha_no_borders
			Me.houseKeepingNavigationPanel.BackgroundImageLayout = ImageLayout.Stretch
			Me.houseKeepingNavigationPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed
			Me.houseKeepingNavigationPanel.PanelElement.Visibility = ElementVisibility.Collapsed

			Me.houseKeepingSchedulerHeaderLabel.TextAlignment = ContentAlignment.MiddleCenter
			Me.houseKeepingSchedulerHeaderLabel.ForeColor = Color.White
			Me.houseKeepingSchedulerHeaderLabel.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid
			Me.houseKeepingSchedulerHeaderLabel.LabelElement.CustomFont = Utils.MainFont
			Me.houseKeepingSchedulerHeaderLabel.LabelElement.CustomFontSize = 15

			Me.notAssignedLabel.LabelElement.LabelFill.GradientStyle = GradientStyles.Solid
			Me.notAssignedLabel.TextAlignment = ContentAlignment.MiddleCenter
			Me.notAssignedLabel.ForeColor = Color.White
			Me.notAssignedLabel.LabelElement.CustomFont = Utils.MainFont
			Me.notAssignedLabel.LabelElement.CustomFontSize = 15
            Me.notAssignedGridView.DataSource = Me.Rooms.Where(Function(r) r.HouseKeeperId Is Nothing AndAlso r.HouseKeepingStatus <> HouseKeepingStatus.Clean)
			For Each col As GridViewColumn In Me.notAssignedGridView.Columns
				If col.Name <> "Id" AndAlso col.Name <> "HouseKeepingStatus" AndAlso col.Name <> "Priority" Then
					col.IsVisible = False
				End If
			Next col
			Me.notAssignedGridView.Columns("Id").TextAlignment = ContentAlignment.MiddleLeft
			Me.notAssignedGridView.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.notAssignedGridView.EnableGrouping = False
			Me.notAssignedGridView.AllowAddNewRow = False
			Me.notAssignedGridView.EnableFiltering = False
			Me.notAssignedGridView.MasterView.TableHeaderRow.Height = 30
			Me.notAssignedGridView.ReadOnly = True
			Me.notAssignedGridView.TableElement.DrawBorder = True
			Me.notAssignedGridView.TableElement.BorderGradientStyle = GradientStyles.Solid
			Me.notAssignedGridView.TableElement.BorderColor = Color.FromArgb(209, 209, 209)

			Me.houseKeepingNavigationPanel.RootElement.EnableElementShadow = False
			Me.houseKeepingListView.RootElement.EnableElementShadow = False
			Me.houseKeepingScheduler.RootElement.EnableElementShadow = False
			Me.notAssignedGridView.RootElement.EnableElementShadow = False
			Me.notAssignedLabel.RootElement.EnableElementShadow = False
			Me.notAssignedGridView.AllowSearchRow = True
			Dim sortDescriptor_Renamed As New SortDescriptor()
			sortDescriptor_Renamed.PropertyName = "Priority"
			sortDescriptor_Renamed.Direction = ListSortDirection.Descending
			Me.notAssignedGridView.SortDescriptors.Add(sortDescriptor_Renamed)

			Dim gridBehavior As BaseGridBehavior = TryCast(Me.notAssignedGridView.GridBehavior, BaseGridBehavior)
			gridBehavior.UnregisterBehavior(GetType(GridViewDataRowInfo))
			gridBehavior.RegisterBehavior(GetType(GridViewDataRowInfo), New CustomGridDataRowBehavior())

			Dim service As RadDragDropService = Me.notAssignedGridView.GridViewElement.GetDragDropService()
			AddHandler service.PreviewDragStart, AddressOf service_PreviewDragStart
			AddHandler service.PreviewDragOver, AddressOf service_PreviewDragOver
			AddHandler service.PreviewDragDrop, AddressOf service_PreviewDragDrop

			Me.houseKeepingScheduler.AppointmentTitleFormat = "{2}"

			Dim houseKeepingScheduleSource As New SchedulerBindingDataSource()
			Dim houseKeepingAppointmentMappingInfo As New AppointmentMappingInfo()
			houseKeepingAppointmentMappingInfo.Summary = "Name"
			houseKeepingAppointmentMappingInfo.ResourceId = "HouseKeeperId"
			houseKeepingAppointmentMappingInfo.Start = "HouseKeepingStart"
			houseKeepingAppointmentMappingInfo.End = "HouseKeepingEnd"
			houseKeepingAppointmentMappingInfo.StatusId = "HouseKeepingStatus"
			houseKeepingAppointmentMappingInfo.BackgroundId = "Priority"
			houseKeepingAppointmentMappingInfo.Visible = "Visible"

			houseKeepingAppointmentMappingInfo.FindBySchedulerProperty("ResourceId").ConvertToScheduler = AddressOf ConvertTo
			houseKeepingAppointmentMappingInfo.FindBySchedulerProperty("ResourceId").ConvertToDataSource = AddressOf ConvertFrom
			houseKeepingScheduleSource.EventProvider.Mapping = houseKeepingAppointmentMappingInfo
			houseKeepingScheduleSource.EventProvider.DataSource = Me.Rooms
			Dim houseKeepingResourceMappingInfo As New ResourceMappingInfo()
			houseKeepingResourceMappingInfo.Id = "Id"
			houseKeepingResourceMappingInfo.Name = "Name"
			houseKeepingResourceMappingInfo.Image = "Photo"
			Dim houseKeepersCopy As New BindingList(Of HouseKeeper)()
			For Each hk As HouseKeeper In Me.HouseKeepers
				houseKeepersCopy.Add(New HouseKeeper(hk.Id, hk.Name, hk.Photo))
			Next hk
			houseKeepingScheduleSource.ResourceProvider.Mapping = houseKeepingResourceMappingInfo
			houseKeepingScheduleSource.ResourceProvider.DataSource = houseKeepersCopy
			Me.houseKeepingScheduler.DataSource = houseKeepingScheduleSource
			For Each r As Resource In Me.houseKeepingScheduler.Resources
				r.Color = Color.White
			Next r

			AppointmentStatusInfo.DefaultStatusId = -1
			Me.houseKeepingScheduler.Statuses.Clear()
			Me.houseKeepingScheduler.Statuses.Add(New AppointmentStatusInfo(1, "Clean", Color.Green, Color.Transparent, AppointmentStatusFillType.Solid))
			Me.houseKeepingScheduler.Statuses.Add(New AppointmentStatusInfo(2, "NotClean", Color.Red, Color.Transparent, AppointmentStatusFillType.Solid))
			Me.houseKeepingScheduler.Statuses.Add(New AppointmentStatusInfo(3, "InProgress", Color.Yellow, Color.Transparent, AppointmentStatusFillType.Solid))

			Me.houseKeepingScheduler.Backgrounds.Clear()

			Dim lowBackgroundInfo As New AppointmentBackgroundInfo(1, "Low", Color.Wheat, Color.Wheat)
			lowBackgroundInfo.ShadowWidth = 0
			Me.houseKeepingScheduler.Backgrounds.Add(lowBackgroundInfo)

			Dim mediumBackgroundInfo As New AppointmentBackgroundInfo(2, "Medium", Color.Salmon, Color.Salmon)
			mediumBackgroundInfo.ShadowWidth = 0
			Me.houseKeepingScheduler.Backgrounds.Add(mediumBackgroundInfo)

			Dim highBackgroundInfo As New AppointmentBackgroundInfo(3, "High", Color.OrangeRed, Color.OrangeRed)
			highBackgroundInfo.ShadowWidth = 0
			Me.houseKeepingScheduler.Backgrounds.Add(highBackgroundInfo)

			AddHandler Me.houseKeepingScheduler.AppointmentEditDialogShowing, AddressOf houseKeepingScheduler_AppointmentEditDialogShowing
			AddHandler Me.houseKeepingScheduler.AppointmentChanged, AddressOf houseKeepingScheduler_AppointmentChanged
			AddHandler Me.houseKeepingScheduler.ActiveViewChanged, AddressOf houseKeepingScheduler_ActiveViewChanged
			Me.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Timeline
			Me.houseKeepingScheduler.Culture = culture
			AddHandler Me.houseKeepingDateNavigator.DateTimePicker.ValueChanged, AddressOf HouseKeepingNavigatorDateTimePicker_ValueChanged
			AddHandler Me.houseKeepingDaysToggleButton.ToggleStateChanged, AddressOf houseKeepingDaysButton_ToggleStateChanged
			AddHandler Me.houseKeepingWeeklyToggleButton.ToggleStateChanged, AddressOf houseKeepingWeeklyButton_ToggleStateChanged
			AddHandler Me.houseKeepingMonthlyToggleButton.ToggleStateChanged, AddressOf houseKeepingMonthlyButton_ToggleStateChanged

			Me.houseKeepingScheduler.GroupType = GroupType.Resource
			Me.houseKeepingDaysToggleButton.PerformClick()

			Me.houseKeepingScheduler.GetDayView().ShowAllDayArea = False

			Me.houseKeepingListView.ListViewElement.Padding = New Padding(0, 16, 0, 0)
			AddHandler Me.houseKeepingListView.VisualItemCreating, AddressOf houseKeepingListView_VisualItemCreating
			AddHandler Me.houseKeepingListView.VisualItemFormatting, AddressOf leftView_VisualItemFormatting
			Dim houseKeepingGroup As New ListViewDataItemGroup()
			houseKeepingGroup.Text = "HOUSE KEEPING"
			Dim houseKeepersGroup As New ListViewDataItemGroup()
			houseKeepersGroup.Text = "STAFF - SERVICE"
			Dim notAssignedGroup As New ListViewDataItemGroup()
			notAssignedGroup.Text = "Not assigned"

			Me.houseKeepingListView.Groups.AddRange(New ListViewDataItemGroup() { houseKeepingGroup, houseKeepersGroup, notAssignedGroup })
			Me.houseKeepingListView.ShowGroups = True
			Me.houseKeepingListView.EnableCustomGrouping = True
			Me.houseKeepingListView.ShowCheckBoxes = True
			Dim houseKeepingOptions As Array = System.Enum.GetValues(GetType(HouseKeepingStatus))
			For Each item As Object In houseKeepingOptions
				Dim houseKeepingItem As New ListViewDataItem(Utils.GetHouseKeepingStatus(CType(item, HouseKeepingStatus)))
				houseKeepingItem.Value = CType(item, HouseKeepingStatus)
				houseKeepingItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
				Me.houseKeepingListView.Items.Add(houseKeepingItem)
				houseKeepingItem.Group = houseKeepingGroup
			Next item
			For Each r As Resource In Me.houseKeepingScheduler.Resources
				Dim resourceItem As New ListViewDataItem()
				resourceItem.Value = r.Name
				resourceItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
				Me.houseKeepingListView.Items.Add(resourceItem)
				resourceItem.Group = houseKeepersGroup
			Next r
			Dim needsRepairItem As New ListViewDataItem("Repair")
			needsRepairItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.houseKeepingListView.Items.Add(needsRepairItem)
			needsRepairItem.Group = houseKeepingGroup

			Dim notAssignedItem As New ListViewDataItem()
			notAssignedItem.Value = "Not assigned rooms"
			notAssignedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.houseKeepingListView.Items.Add(notAssignedItem)
			notAssignedItem.Group = notAssignedGroup

			AddHandler Me.houseKeepingListView.ItemCheckedChanged, AddressOf houseKeepingListView_ItemCheckedChanged
			Me.houseKeepingListView.AllowEdit = False
			AddHandler Me.houseKeepingListView.SelectedItemChanging, Sub(sender As Object, e As ListViewItemCancelEventArgs) e.Cancel = True
			Me.houseKeepingListView.SelectedIndex = -1

'			#End Region
		End Sub
		#End Region

		#Region "Events"
		Private Sub houseKeepingListView_VisualItemCreating(ByVal sender As Object, ByVal e As ListViewVisualItemCreatingEventArgs)
			If TypeOf e.VisualItem Is SimpleListViewVisualItem Then
				e.VisualItem = New OptionsSimpleListViewVisualItem()
			End If
		End Sub

		Private Sub houseKeepingScheduler_AppointmentChanged(ByVal sender As Object, ByVal e As AppointmentChangedEventArgs)
			If e.PropertyName = "StatusId" Then
				Dim repair As Boolean = False
                Dim item As ListViewDataItem = Me.houseKeepingListView.Groups(0).Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On AndAlso i.Text = "Repair")
				If item IsNot Nothing Then
					repair = True
				End If
				UpdateAppointmentsVisibility(Me.houseKeepingListView.Groups(0), repair)
			End If
			Me.houseKeepingListView.ListViewElement.SynchronizeVisualItems()
		End Sub

		Private Sub houseKeepingScheduler_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs)
			If e.Appointment.DataItem Is Nothing Then
				e.Cancel = True
			End If
			e.AppointmentEditDialog = New HouseKeepingEditAppointmentDialog()

			AddHandler (CType(e.AppointmentEditDialog, RadForm)).FormClosed, AddressOf HotelAppForm_FormClosed
		End Sub

		Private Sub HotelAppForm_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Me.houseKeepingListView.ListViewElement.SynchronizeVisualItems()
		End Sub



		Private Sub service_PreviewDragStart(ByVal sender As Object, ByVal e As PreviewDragStartEventArgs)
			Dim rowElement As GridDataRowElement = TryCast(e.DragInstance, GridDataRowElement)
			If rowElement Is Nothing Then
				e.CanStart = False
				Return
			End If
			e.CanStart = True
			draggedRowInfo = rowElement.RowInfo
		End Sub

		Private Sub service_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
			Dim cell As SchedulerCellElement = TryCast(e.HitTarget, SchedulerCellElement)
			If cell IsNot Nothing AndAlso cell.View.GetResource() IsNot Nothing Then
				e.CanDrop = True
			Else
				e.CanDrop = False
			End If
		End Sub

		Private Sub service_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
			Dim cell As SchedulerCellElement = TryCast(e.HitTarget, SchedulerCellElement)
			Dim draggedRoom As Room = TryCast(draggedRowInfo.DataBoundItem, Room)
			If cell Is Nothing OrElse draggedRowInfo Is Nothing OrElse draggedRowInfo Is Nothing Then
				e.Handled = False
				Return
			End If

			e.Handled = True
			draggedRoom.HouseKeeperId = Integer.Parse(cell.View.GetResource().Id.KeyValue.ToString())
			draggedRoom.HouseKeepingStart = cell.Date
			draggedRoom.HouseKeepingEnd = cell.Date.AddHours(1)
			Dim sbs As SchedulerBindingDataSource = TryCast(Me.houseKeepingScheduler.DataSource, SchedulerBindingDataSource)
			sbs.Rebind()
			Me.Height += 1
			Me.Height -= 1

            Me.notAssignedGridView.DataSource = Me.Rooms.Where(Function(r) r.HouseKeeperId Is Nothing AndAlso r.HouseKeepingStatus <> HouseKeepingStatus.Clean)
			Me.houseKeepingListView.ListViewElement.SynchronizeVisualItems()
		End Sub

		Private Sub houseKeepingDaysButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.houseKeepingSchedulerHeaderLabel.Text = "3 Days"
				Me.houseKeepingWeeklyToggleButton.ToggleState = ToggleState.Off
				Me.houseKeepingMonthlyToggleButton.ToggleState = ToggleState.Off
				Me.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Day
			End If
		End Sub

		Private Sub houseKeepingWeeklyButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.houseKeepingSchedulerHeaderLabel.Text = "Weekly"
				Me.houseKeepingDaysToggleButton.ToggleState = ToggleState.Off
				Me.houseKeepingMonthlyToggleButton.ToggleState = ToggleState.Off
				Me.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Week
			End If
		End Sub

		Private Sub houseKeepingMonthlyButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.houseKeepingSchedulerHeaderLabel.Text = "Monthly"
				Me.houseKeepingDaysToggleButton.ToggleState = ToggleState.Off
				Me.houseKeepingWeeklyToggleButton.ToggleState = ToggleState.Off
				Me.houseKeepingScheduler.ActiveViewType = SchedulerViewType.Month
			End If
		End Sub

		Private Sub HouseKeepingNavigatorDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.houseKeepingScheduler.ActiveView.StartDate = Me.houseKeepingDateNavigator.DateTimePicker.Value
		End Sub

		Private Sub houseKeepingListView_ItemCheckedChanged(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
			If e.Item.Text = "Not assigned rooms" Then
				If e.Item.CheckState = ToggleState.On Then
					Me.splitPanel2.Visible = True
					Me.houseKeepingSplitContainer.RestoreSplitterPosition(Me.houseKeepingSplitContainer.Splitters(0))
				Else
					Me.splitPanel2.Visible = False
					Me.houseKeepingSplitContainer.MoveSplitter(Me.houseKeepingSplitContainer.Splitters(0), RadDirection.Down)
				End If
			End If
			UpdateHouseKeepingResources(e.Item.Group, e.Item.Text, e.Item.CheckState)
		End Sub

		Private Sub UpdateHouseKeepingResources(ByVal group As ListViewDataItemGroup, ByVal itemText As String, ByVal toggleState_Renamed As ToggleState)
			Dim schedulerSource As SchedulerBindingDataSource = TryCast(Me.houseKeepingScheduler.DataSource, SchedulerBindingDataSource)
			Dim houseKeepersSource As BindingList(Of HouseKeeper) = TryCast(schedulerSource.ResourceProvider.DataSource, BindingList(Of HouseKeeper))
			Dim toDelete As New List(Of HouseKeeper)()
			If group.Text = "STAFF - SERVICE" Then
				If toggleState_Renamed = ToggleState.Off Then
					For Each h As HouseKeeper In houseKeepersSource
						If h.Name.ToString() = itemText Then
							toDelete.Add(h)
						End If
					Next h
					Do While toDelete.Count > 0
						houseKeepersSource.Remove(toDelete(0))
						toDelete.RemoveAt(0)
					Loop
				Else
					For Each hk As HouseKeeper In Me.HouseKeepers
						If Not HouseKeeperExists(houseKeepersSource, hk.Id) Then
                            Dim item As ListViewDataItem = group.Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On AndAlso i.Text = hk.Name.ToString())
							If item IsNot Nothing Then
								houseKeepersSource.Add(New HouseKeeper(hk.Id, hk.Name, hk.Photo))
							End If
						End If
					Next hk
				End If
			ElseIf group.Text = "HOUSE KEEPING" Then
				Dim repair As Boolean = False
                Dim item As ListViewDataItem = group.Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On AndAlso i.Text = "Repair")
				If item IsNot Nothing Then
					repair = True
				End If
				UpdateAppointmentsVisibility(group, repair)
			End If

			For Each r As Resource In Me.houseKeepingScheduler.Resources
				r.Color = Color.White
			Next r

			If group.Text = "STAFF - SERVICE" Then
                Dim houseKeepingItem As ListViewDataItem = group.Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On)
				If houseKeepingItem Is Nothing Then
					Me.houseKeepingScheduler.GroupType = GroupType.None
				Else
					Me.houseKeepingScheduler.GroupType = GroupType.Resource
				End If
			End If

			Me.houseKeepingScheduler.SchedulerElement.RefreshViewElement()
			RefreshHouseKeepingScheduler()
		End Sub

		Private Sub UpdateAppointmentsVisibility(ByVal group As ListViewDataItemGroup, ByVal repair As Boolean)
			Dim roomsToHide As New List(Of Room)()
			Dim roomsToShow As New List(Of Room)()
			For Each a As Appointment In Me.houseKeepingScheduler.Appointments
				Dim r As Room = TryCast(a.DataItem, Room)

                Dim item As ListViewDataItem = group.Items.FirstOrDefault(Function(i) i.CheckState = ToggleState.On AndAlso i.Text = r.HouseKeepingStatus.ToString())
				If item IsNot Nothing Then
					If (r.NeedsRepairs AndAlso repair) OrElse (Not repair) Then
						roomsToShow.Add(r)
					Else
						roomsToHide.Add(r)
					End If
				Else
					roomsToHide.Add(r)
				End If
			Next a
			Do While roomsToHide.Count > 0
				roomsToHide.First().Visible = False
				roomsToHide.RemoveAt(0)
			Loop
			Do While roomsToShow.Count > 0
				roomsToShow.First().Visible = True
				roomsToShow.RemoveAt(0)
			Loop
		End Sub

		Private Function HouseKeeperExists(ByVal houseKeepersSource As BindingList(Of HouseKeeper), ByVal id As Integer) As Boolean
			For Each h As HouseKeeper In houseKeepersSource
				If h.Id = id Then
					Return True
				End If
			Next h
			Return False
		End Function

		Private Sub houseKeepingScheduler_RulerTextFormatting(ByVal sender As Object, ByVal e As RulerTextFormattingEventArgs)
			If e.Context = RulerTextFormattingContext.Minute Then
				e.Text = String.Empty
			Else
				e.Text = e.Time.ToString("HH:mm")
			End If
		End Sub

		Private Sub houseKeepingScheduler_CellFormatting(ByVal sender As Object, ByVal e As SchedulerCellEventArgs)
			e.CellElement.Visibility = ElementVisibility.Visible

			If e.CellElement.VisualState.Contains("CornerHeaderCell3") OrElse e.CellElement.VisualState.Contains("CornerHeaderCell2") Then
				e.CellElement.Visibility = ElementVisibility.Collapsed
			End If
			Dim headerCell As SchedulerResourceHeaderCellElement = TryCast(e.CellElement, SchedulerResourceHeaderCellElement)
			If headerCell IsNot Nothing Then
				headerCell.Layout.LeftPart.Margin = New Padding(0, 0, 10, 0)
				headerCell.ImageLayout = ImageLayout.None
				headerCell.ImageAlignment = ContentAlignment.MiddleLeft
				headerCell.TextImageRelation = TextImageRelation.ImageBeforeText
				headerCell.TextAlignment = ContentAlignment.MiddleLeft
				headerCell.CustomFont = Utils.MainFont
				headerCell.CustomFontSize = 10
				headerCell.BorderGradientStyle = GradientStyles.Solid
				headerCell.BorderColor = Color.FromArgb(209, 209, 209)
			ElseIf e.CellElement.VisualState = "MonthViewHeaderCellElement.IsVertical" Then
				e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
				e.CellElement.BorderLeftWidth = 0
				e.CellElement.BorderTopWidth = 1
				e.CellElement.BorderTopColor = Color.FromArgb(209, 209, 209)
				e.CellElement.BorderRightWidth = 1
				e.CellElement.BorderRightColor = Color.FromArgb(209, 209, 209)
				e.CellElement.BorderBottomWidth = 1
				e.CellElement.BorderBottomColor = Color.FromArgb(209, 209, 209)
			Else
				e.CellElement.ResetValue(LightVisualElement.ImageLayoutProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.ImageAlignmentProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.CustomFontProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.CustomFontSizeProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderGradientStyleProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local)
			End If
			If Not(TypeOf e.CellElement Is SchedulerHeaderCellElement) AndAlso e.CellElement.VisualState <> "CornerHeaderCell2" Then
				e.CellElement.BackColor = Color.FromArgb(244, 244, 244)
				e.CellElement.Opacity = 1
			ElseIf e.CellElement.VisualState = "MonthViewHeaderCellElement.IsVertical" Then
				e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
				e.CellElement.BorderLeftWidth = 0
				e.CellElement.BorderTopWidth = 1
				e.CellElement.BorderTopColor = Color.FromArgb(209, 209, 209)
				e.CellElement.BorderRightWidth = 1
				e.CellElement.BorderRightColor = Color.FromArgb(209, 209, 209)
				e.CellElement.BorderBottomWidth = 1
				e.CellElement.BorderBottomColor = Color.FromArgb(209, 209, 209)
			Else
				e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.OpacityProperty, ValueResetFlags.Local)
			End If
			If e.CellElement.Text = "Local" Then
				e.CellElement.Text = String.Empty
			End If
		End Sub

		Private Sub houseKeepingScheduler_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			Me.RefreshHouseKeepingScheduler()
		End Sub

		Private Sub RefreshHouseKeepingScheduler()
			Dim dayView As SchedulerDayViewGroupedByResourceElement = TryCast(Me.houseKeepingScheduler.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			Dim monthView As SchedulerMonthViewGroupedByResourceElement = TryCast(Me.houseKeepingScheduler.SchedulerElement.ViewElement, SchedulerMonthViewGroupedByResourceElement)
			If Me.houseKeepingScheduler.ActiveViewType <> SchedulerViewType.Day Then
				Me.houseKeepingScheduler.ActiveView.ResourcesPerView = 1
			Else
				Me.houseKeepingScheduler.ActiveView.ResourcesPerView = 3
			End If
			If dayView IsNot Nothing Then
				Dim dv As SchedulerDayViewBase = TryCast(Me.houseKeepingScheduler.ActiveView, SchedulerDayViewBase)
				dv.RulerStartScale = 8
				dv.RulerEndScale = 19
				dayView.DrawBorder = False
				dayView.ResourceHeaderHeight = 65
				Dim ruler As RulerPrimitive
				For Each c As RadElement In dayView.Children
					Dim view As SchedulerDayViewElement = TryCast(c, SchedulerDayViewElement)
					If view IsNot Nothing Then
						view.DataAreaElement.Ruler.DefaultSeparatorOffset = 40
						ruler = view.DataAreaElement.Ruler
						ruler.CustomFont = Utils.MainFont
						ruler.CustomFontSize = 10f
						ruler.Border.BoxStyle = BorderBoxStyle.FourBorders
						ruler.Border.LeftWidth = 0
						ruler.Border.TopWidth = 0
						ruler.Border.RightWidth = 1
						ruler.Border.BottomWidth = 0
					End If
				Next c
				Me.houseKeepingScheduler.HeaderFormat = "dd MMM"
			End If

			If monthView IsNot Nothing Then
				monthView.DrawBorder = False
				monthView.ResourceHeaderHeight = 65
				monthView.ResourcesHeader.DrawBorder = False

				For Each view As RadElement In monthView.Children
					Dim monthViewElement As SchedulerMonthViewElement = TryCast(view, SchedulerMonthViewElement)
					If monthViewElement IsNot Nothing Then
						monthViewElement.VerticalHeader.HeaderWidth = 50
						monthViewElement.Children(3).Visibility = ElementVisibility.Collapsed
						monthViewElement.DrawBorder = False
					End If
				Next view
			End If

			If Me.houseKeepingScheduler.GroupType = GroupType.None Then
				Dim dayViewElement As SchedulerDayViewElement = TryCast(Me.houseKeepingScheduler.SchedulerElement.ViewElement, SchedulerDayViewElement)
				If dayViewElement IsNot Nothing Then
					dayViewElement.DataAreaElement.Ruler.DefaultSeparatorOffset = 40
					Dim ruler As RulerPrimitive = dayViewElement.DataAreaElement.Ruler
					ruler.CustomFont = Utils.MainFont
					ruler.CustomFontSize = 10f
					ruler.Border.BoxStyle = BorderBoxStyle.FourBorders
					ruler.Border.LeftWidth = 0
					ruler.Border.TopWidth = 0
					ruler.Border.RightWidth = 1
					ruler.Border.BottomWidth = 0
				End If
			End If
			RemoveHandler Me.houseKeepingScheduler.CellFormatting, AddressOf houseKeepingScheduler_CellFormatting
			RemoveHandler Me.houseKeepingScheduler.RulerTextFormatting, AddressOf houseKeepingScheduler_RulerTextFormatting
			RemoveHandler Me.houseKeepingScheduler.ActiveView.PropertyChanged, AddressOf ActiveView_PropertyChanged
			RemoveHandler Me.houseKeepingScheduler.AppointmentFormatting, AddressOf houseKeepingScheduler_AppointmentFormatting

			AddHandler Me.houseKeepingScheduler.CellFormatting, AddressOf houseKeepingScheduler_CellFormatting
			AddHandler Me.houseKeepingScheduler.RulerTextFormatting, AddressOf houseKeepingScheduler_RulerTextFormatting
			AddHandler Me.houseKeepingScheduler.ActiveView.PropertyChanged, AddressOf ActiveView_PropertyChanged
			AddHandler Me.houseKeepingScheduler.AppointmentFormatting, AddressOf houseKeepingScheduler_AppointmentFormatting
			Me.houseKeepingScheduler.Height -= 1
			Me.houseKeepingScheduler.Height -= 1
		End Sub

		Private Sub houseKeepingScheduler_AppointmentFormatting(ByVal sender As Object, ByVal e As SchedulerAppointmentEventArgs)
			e.AppointmentElement.BackColor = Color.FromArgb(209, 209, 209)
			e.AppointmentElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			e.AppointmentElement.NumberOfColors = 4
			e.AppointmentElement.BorderColor = Color.FromArgb(209, 209, 209)
			e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders

			Dim r As Room = TryCast(e.Appointment.DataItem, Room)
			If r IsNot Nothing Then
                e.AppointmentElement.Text = r.Name & " " & r.HouseKeepingStatus.ToString()
				e.AppointmentElement.ImageAlignment = ContentAlignment.MiddleLeft
				e.AppointmentElement.TextAlignment = ContentAlignment.MiddleRight
				e.AppointmentElement.Image = Utils.GetRoomIconByType(r.Type)
				e.AppointmentElement.TextImageRelation = TextImageRelation.ImageBeforeText
				e.AppointmentElement.DisableHTMLRendering = True
				e.AppointmentElement.CustomFont = Utils.MainFont
				e.AppointmentElement.CustomFontSize = 9f
				e.AppointmentElement.ForeColor = Color.Black
			End If
		End Sub

		#End Region

	End Class
End Namespace
