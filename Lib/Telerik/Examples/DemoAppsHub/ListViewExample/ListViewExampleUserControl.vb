Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.Layouts

Namespace DemoAppsHub.ListViewExample
	Public Partial Class ListViewExampleUserControl
		Inherits UserControl
        Private features As List(Of String) = New List(Of String)() From {"AirConditioner", "Mp3Player", "DVDPlayer", "ABS", "ASR", "Navigation"}
		Private updatingToggleState As Boolean = False

		Public Sub New()
			InitializeComponent()

			Me.radCommandBar1.ThemeName = "TelerikMetroBlue"
			Me.radListView1.ThemeName = "TelerikMetroBlue"

			Dim searchIcon As ImagePrimitive = New ImagePrimitive()
			searchIcon.Image = Global.Resources.TV_search
			searchIcon.Alignment = ContentAlignment.MiddleRight

			Me.commandBarTextBoxFilter.TextBoxElement.StretchHorizontally = True
			Me.commandBarTextBoxFilter.TextBoxElement.Alignment = ContentAlignment.MiddleRight
			Me.commandBarTextBoxFilter.TextBoxElement.Children.Add(searchIcon)
			Me.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft
			AddHandler commandBarTextBoxFilter.TextBoxElement.TextBoxItem.PropertyChanged, AddressOf TextBoxItem_PropertyChanged

			AddHandler radListView1.VisualItemFormatting, AddressOf radListView1_VisualItemFormatting
			AddHandler radListView1.ViewTypeChanged, AddressOf radListView1_ViewTypeChanged
			AddHandler radListView1.CellFormatting, AddressOf radListView1_CellFormatting

			Me.radListView1.AllowEdit = False
			Me.radListView1.AllowRemove = False

			Me.radListView1_ViewTypeChanged(Me, EventArgs.Empty)

			Me.commandBarToggleDetails.MinSize = New Size(35, 35)
			Me.commandBarToggleList.MinSize = New Size(35, 35)
			Me.commandBarToggleTiles.MinSize = New Size(35, 35)

			Me.commandBarTextBoxFilter.StretchVertically = True
			Me.commandBarTextBoxFilter.TextBoxElement.StretchVertically = True

			Me.commandBarDropDownGroup.StretchVertically = True
			Me.commandBarDropDownGroup.DropDownListElement.ItemHeight = 35
			Me.commandBarDropDownSort.StretchVertically = True
			Me.commandBarDropDownSort.DropDownListElement.ItemHeight = 35
			Me.commandBarStripElement1.OverflowButton.MinSize = New Size(35, 0)

		End Sub

		Private Sub SetupDetailsView()
			Me.radListView1.ItemSize = New Size(0, 110)
		End Sub

		Private Sub SetupIconsView()
			Me.radListView1.ItemSize = New Size(295, 120)
			Me.radListView1.ItemSpacing = 5
			Me.radListView1.GroupIndent = 0
		End Sub

		Private Sub SetupSimpleListView()
			Me.radListView1.AllowArbitraryItemHeight = True

		End Sub

		Private Function ContainsFeature(ByVal item As ListViewDataItem, ByVal feature As String) As Boolean
			Return Not item(feature) Is Nothing AndAlso Convert.ToInt32(item(feature)) <> 0
		End Function

		Private Function GetFeatures(ByVal item As ListViewDataItem) As String
			Dim featuresString As StringBuilder = New StringBuilder()

			For Each feature As String In Me.features
				If ContainsFeature(item, feature) Then
					featuresString.Append(feature & ", ")
				End If
			Next feature

			If featuresString.Length > 1 Then
				featuresString.Remove(featuresString.Length - 2, 2)
			End If

			Return featuresString.ToString()
		End Function

		#Region "Event handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.carsRatesDataTableTableAdapter.Fill(Me.sofiaCarRentalDataSet.CarsRatesDataTable)

			Me.commandBarDropDownGroup.SelectedIndex = 1
		End Sub

		Private Sub radListView1_BindingCompleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles radListView1.BindingCompleted
			Me.radListView1.Columns("ImageFileName").Width = 180
			Me.radListView1.Columns("ImageFileName").MinWidth = 180
			Me.radListView1.Columns("Make").Width = 90
			Me.radListView1.Columns("Make").MinWidth = 90
			Me.radListView1.Columns("Model").Width = 110
			Me.radListView1.Columns("Model").MinWidth = 110
			Me.radListView1.Columns("CarYear").Width = 90
			Me.radListView1.Columns("CarYear").MinWidth = 90
			Me.radListView1.Columns("CategoryName").Width = 90
			Me.radListView1.Columns("CategoryName").MinWidth = 90

			Dim pictureColumnIndex As Integer = Me.radListView1.Columns.IndexOf("ImageFileName")
			Me.radListView1.Columns.Move(pictureColumnIndex, 0)
		End Sub

		Private Sub radListView1_ColumnCreating(ByVal sender As Object, ByVal e As ListViewColumnCreatingEventArgs) Handles radListView1.ColumnCreating
			If e.Column.FieldName = "CarID" Then
				e.Column.Visible = False
			End If

			If e.Column.FieldName = "ImageFileName" Then
				e.Column.HeaderText = "Picture"
			End If

			If e.Column.FieldName = "CarYear" Then
				e.Column.HeaderText = "Manufactured"
			End If

			If e.Column.FieldName = "CategoryName" Then
				e.Column.HeaderText = "Category"
			End If

			If e.Column.FieldName = "Mp3Player" Then
				e.Column.HeaderText = "MP3"
			End If

			If e.Column.FieldName = "DVDPlayer" Then
				e.Column.HeaderText = "DVD"
			End If

			If e.Column.FieldName = "AirConditioner" Then
				e.Column.HeaderText = "Air Cond."
				e.Column.Width = 90
				e.Column.MinWidth = 90
			End If

			If e.Column.FieldName = "Daily" OrElse e.Column.FieldName = "Weekly" OrElse e.Column.FieldName = "Monthly" OrElse e.Column.FieldName = "Available" Then
				e.Column.Visible = False
			End If

			If features.Contains(e.Column.FieldName) Then
				e.Column.Width = 55
				e.Column.MinWidth = 55
			End If
		End Sub

		Private Sub radListView1_CellFormatting(ByVal sender As Object, ByVal e As ListViewCellFormattingEventArgs)

			If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
				Return
			End If

			If e.CellElement.Data.HeaderText = "Picture" Then
				CType(e.CellElement, DetailListViewDataCellElement).Image = (CType(e.CellElement, DetailListViewDataCellElement)).Row.Image
				e.CellElement.Text = ""
				e.CellElement.ImageAlignment = ContentAlignment.MiddleCenter
				e.CellElement.TextImageRelation = TextImageRelation.Overlay
			Else
				e.CellElement.Image = Nothing
			End If

			If e.CellElement.Data.HeaderText = "Make" OrElse e.CellElement.Data.HeaderText = "Model" Then
				e.CellElement.Text = "<html><span style=""color:#161112;font-size:11.5pt;"">" & e.CellElement.Text & "</span>"
			ElseIf Me.features.Contains(e.CellElement.Data.FieldName) Then
				Dim containsFeature As Boolean = Me.ContainsFeature((CType(e.CellElement, DetailListViewDataCellElement)).Row, e.CellElement.Data.FieldName)
				Dim color As String
				If (containsFeature) Then
					color = "#050F70"
				Else
					color = "#B52822"
				End If
				e.CellElement.ForeColor = CType(New ColorConverter().ConvertFromString(color), Color)
				e.CellElement.Font = New Font(e.CellElement.Font.FontFamily, 10, GraphicsUnit.Point)
				If (containsFeature) Then
					e.CellElement.Text = "YES"
				Else
					e.CellElement.Text = "NO"
				End If
			ElseIf e.CellElement.Data.HeaderText <> "Picture" Then
				e.CellElement.ForeColor = CType(New ColorConverter().ConvertFromString("#050F70"), Color)
				e.CellElement.Font = New Font(e.CellElement.Font.FontFamily, 10, GraphicsUnit.Point)
				e.CellElement.Text = e.CellElement.Text
			End If
		End Sub

		Private Sub radListView1_ViewTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
			Select Case radListView1.ViewType
				Case ListViewType.ListView
					SetupSimpleListView()
				Case ListViewType.IconsView
					SetupIconsView()
				Case ListViewType.DetailsView
					SetupDetailsView()
			End Select
		End Sub

		Private Sub radListView1_VisualItemCreating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs) Handles radListView1.VisualItemCreating
			If Me.radListView1.ViewType = ListViewType.ListView AndAlso Not(TypeOf e.VisualItem Is BaseListViewGroupVisualItem) Then
				e.VisualItem = New CarsListVisualItem()
			End If
		End Sub

		Private Sub radListView1_VisualItemFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemEventArgs)
			If TypeOf e.VisualItem Is BaseListViewGroupVisualItem Then
				Return
			End If

			If Me.radListView1.ViewType = ListViewType.IconsView Then
				e.VisualItem.Font = New System.Drawing.Font("Segoe UI", 12)
				e.VisualItem.ForeColor = Color.Black
                e.VisualItem.Text = "<html>" & "<span style=""color:#040203;font-size:12pt;"">" & String.Format("{0}", e.VisualItem.Data("Make")) & _
                    " " & String.Format("{0}", e.VisualItem.Data("Model")) & "</span>" & "<br><span style=""color:#040203;font-size:9pt;"">" & _
                    String.Format("{0}", e.VisualItem.Data("CarYear")) & ", " & String.Format("{0}", e.VisualItem.Data("CategoryName")) & "</span>" & _
                    "<br><br><span style=""color:#112164;font-size:9pt;"">" & GetFeatures(e.VisualItem.Data) & "</span>"

				e.VisualItem.ImageLayout = ImageLayout.Center
				e.VisualItem.ImageAlignment = ContentAlignment.MiddleCenter
			End If

			If Me.radListView1.ViewType = ListViewType.ListView Then
				e.VisualItem.Padding = New Padding(5, 5, 0, 5)
				e.VisualItem.Layout.LeftPart.Margin = New Padding(0, 0, 5, 0)
			End If
		End Sub

		Private Sub radListView1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles radListView1.ItemDataBound
            e.Item.Image = Image.FromFile(Application.StartupPath & "\CarRentalImages\" & String.Format("{0}", e.Item("ImageFileName")))
		End Sub

		Private Sub viewToggleButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles commandBarToggleList.ToggleStateChanged, commandBarToggleTiles.ToggleStateChanged, commandBarToggleDetails.ToggleStateChanged
			If updatingToggleState Then
				Return
			End If

			Me.updatingToggleState = True

			If Not Me.commandBarToggleDetails Is sender Then
				Me.commandBarToggleDetails.ToggleState = ToggleState.Off
			End If

			If Not Me.commandBarToggleList Is sender Then
				Me.commandBarToggleList.ToggleState = ToggleState.Off
			End If

			If Not Me.commandBarToggleTiles Is sender Then
				Me.commandBarToggleTiles.ToggleState = ToggleState.Off
			End If

			Me.updatingToggleState = False

			If Me.commandBarToggleDetails.ToggleState = ToggleState.On Then
				Me.radListView1.ViewType = ListViewType.DetailsView
			End If

			If Me.commandBarToggleList.ToggleState = ToggleState.On Then
				Me.radListView1.ViewType = ListViewType.ListView
			End If

			If Me.commandBarToggleTiles.ToggleState = ToggleState.On Then
				Me.radListView1.ViewType = ListViewType.IconsView
			End If

		End Sub

		Private Sub viewToggleButton_ToggleStateChanging(ByVal sender As Object, ByVal args As StateChangingEventArgs) Handles commandBarToggleList.ToggleStateChanging, commandBarToggleTiles.ToggleStateChanging, commandBarToggleDetails.ToggleStateChanging
			If (Not updatingToggleState) AndAlso args.OldValue = ToggleState.On Then
				args.Cancel = True
			End If
		End Sub

		Private Sub commandBarDropDownSort_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles commandBarDropDownSort.SelectedIndexChanged
			Me.radListView1.SortDescriptors.Clear()
			Select Case Me.commandBarDropDownSort.Text
				Case "Make"
					Me.radListView1.SortDescriptors.Add(New SortDescriptor("Make", ListSortDirection.Ascending))
					Me.radListView1.EnableSorting = True
				Case "Model"
					Me.radListView1.SortDescriptors.Add(New SortDescriptor("Model", ListSortDirection.Ascending))
					Me.radListView1.EnableSorting = True
				Case "Category"
					Me.radListView1.SortDescriptors.Add(New SortDescriptor("CategoryName", ListSortDirection.Ascending))
					Me.radListView1.EnableSorting = True
				Case "Year"
					Me.radListView1.SortDescriptors.Add(New SortDescriptor("CarYear", ListSortDirection.Ascending))
					Me.radListView1.EnableSorting = True
			End Select
		End Sub

		Private Sub commandBarDropDownGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles commandBarDropDownGroup.SelectedIndexChanged
			Me.radListView1.GroupDescriptors.Clear()
			Select Case Me.commandBarDropDownGroup.Text
				Case "None"
					Me.radListView1.EnableGrouping = False
					Me.radListView1.ShowGroups = False
				Case "Make"
					Me.radListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() { New SortDescriptor("Make", ListSortDirection.Ascending) }))
					Me.radListView1.EnableGrouping = True
					Me.radListView1.ShowGroups = True
				Case "Category"
					Me.radListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() { New SortDescriptor("CategoryName", ListSortDirection.Ascending) }))
					Me.radListView1.EnableGrouping = True
					Me.radListView1.ShowGroups = True
				Case "Year"
					Me.radListView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() { New SortDescriptor("CarYear", ListSortDirection.Ascending) }))
					Me.radListView1.EnableGrouping = True
					Me.radListView1.ShowGroups = True
			End Select
		End Sub

		Private Sub commandBarTextBoxFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles commandBarTextBoxFilter.TextChanged
			Me.radListView1.FilterDescriptors.Clear()

			If String.IsNullOrEmpty(Me.commandBarTextBoxFilter.Text) Then
				Me.radListView1.EnableFiltering = False
			Else
				Me.radListView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or
				Me.radListView1.FilterDescriptors.Add("Make", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
				Me.radListView1.FilterDescriptors.Add("Model", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
				Me.radListView1.EnableFiltering = True
			End If
		End Sub

		Private Sub TextBoxItem_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Bounds" Then
				commandBarTextBoxFilter.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(CInt(Fix(commandBarTextBoxFilter.DesiredSize.Width - 28)), 0)
			End If
		End Sub

		#End Region
	End Class
End Namespace
