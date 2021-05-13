Imports HotelApp.Data
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class SearchDropDownList
		Inherits RadDropDownList
        Public Overrides Property ThemeClassName As String
            Get
                Return GetType(RadDropDownList).FullName
            End Get
            Set(value As String)
                MyBase.ThemeClassName = value
            End Set
        End Property
		Public Sub Inialize(ByVal rooms As BindingList(Of Room), ByVal bookings As BindingList(Of Booking))
			For Each r As Room In rooms
				Me.Items.Add("Room#" & r.Name)
			Next r
			For Each b As Booking In bookings
				If Not Me.Items.Contains(b.Name) Then
					Me.Items.Add(b.Name)
				End If
			Next b
			Me.AutoCompleteMode = AutoCompleteMode.Suggest
			Me.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains
			AddHandler Me.SelectedIndexChanging, AddressOf scheduleSearchDropDown_SelectedIndexChanging

			Me.DropDownListElement.CustomFont = Utils.MainFont
			Me.DropDownListElement.CustomFontSize = 9f

			Me.DropDownListElement.EditableElement.TextBox.Padding = New Padding(0, 10, 0, 0)
		End Sub

		Protected Overrides Sub CreateChildItems(ByVal parent As Telerik.WinControls.RadElement)
			MyBase.CreateChildItems(parent)
			Dim searchIcon As New LightVisualElement()
			searchIcon.Text = ChrW(&He13E).ToString()
			searchIcon.CustomFont = "TelerikWebUI"
			searchIcon.CustomFontSize = 12
			searchIcon.ForeColor = Color.Gray
			Me.NullText = "Search by room# or guest name"
			Me.RootElement.EnableElementShadow = False
			Dim stackPanel As New StackLayoutElement()
			stackPanel.Orientation = Orientation.Horizontal
			stackPanel.Margin = New Padding(1, 0, 1, 0)
			stackPanel.Children.Add(searchIcon)

			Dim tbItem As RadTextBoxItem = Me.DropDownListElement.TextBox.TextBoxItem
			Me.DropDownListElement.TextBox.Children.Remove(tbItem)
			Dim dockPanel As New DockLayoutPanel()
			dockPanel.Children.Add(stackPanel)
			dockPanel.Children.Add(tbItem)
			DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Left)
			DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right)

			Me.DropDownListElement.TextBox.Children.Add(dockPanel)
			Me.DropDownListElement.ArrowButton.Visibility = ElementVisibility.Collapsed
		End Sub

		Private Sub scheduleSearchDropDown_SelectedIndexChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs)
			If e.Position > -1 Then
				Dim form As HotelAppForm = TryCast(Me.FindForm(), HotelAppForm)

				form.PageView.SelectedPage = form.PageView.Pages(0)
				form.HideRoomDetails()
				form.OverviewSearch.Text = Me.Text
			End If
		End Sub
	End Class
End Namespace