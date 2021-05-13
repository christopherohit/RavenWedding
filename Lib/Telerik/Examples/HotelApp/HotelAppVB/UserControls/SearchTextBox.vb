Imports HotelApp.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Namespace CustomControls
	Public Class SearchTextBox
		Inherits RadTextBox
        Public Overrides Property ThemeClassName As String
            Get
                Return GetType(RadTextBox).FullName
            End Get
            Set(value As String)
                MyBase.ThemeClassName = value
            End Set
        End Property

		Protected Overrides Sub OnLoad(ByVal desiredSize As Size)
			MyBase.OnLoad(desiredSize)
			searchButton.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			searchButton.ShowBorder = False
			searchButton.EnableElementShadow = False
			Me.TextBoxElement.Padding = New Padding(0)
		End Sub

		Private searchButton As New RadButtonElement()

		Protected Overrides Sub InitializeTextElement()
            MyBase.InitializeTextElement()
            searchButton = New RadButtonElement()
			Me.TextBoxElement.TextBoxItem.NullText = "Search by room# or guest name"
			AddHandler searchButton.Click, AddressOf button_Click
			searchButton.Margin = New Padding(0, 0, 0, 0)
			Me.TextBoxElement.TextBoxItem.CustomFont = Utils.MainFont
			Me.TextBoxElement.TextBoxItem.CustomFontSize = 9
			searchButton.TextElement.CustomFont = "TelerikWebUI"
			searchButton.TextElement.CustomFontSize = 12
			searchButton.TextElement.ForeColor = Color.Gray
			searchButton.MaxSize = New Size(40, 35)
			searchButton.Text = ChrW(&He13E).ToString()
			Dim stackPanel As New StackLayoutElement()
			stackPanel.Orientation = Orientation.Horizontal
			stackPanel.Margin = New Padding(1, 0, 1, 0)
			stackPanel.Children.Add(searchButton)

			Dim tbItem As RadTextBoxItem = Me.TextBoxElement.TextBoxItem
			Me.TextBoxElement.Children.Remove(tbItem)
			Dim dockPanel As New DockLayoutPanel()
			dockPanel.Children.Add(stackPanel)
			dockPanel.Children.Add(tbItem)
			DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Left)
			DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right)

			Me.TextBoxElement.Children.Add(dockPanel)
		End Sub

		Public Class SearchBoxEventArgs
			Inherits EventArgs
'INSTANT VB NOTE: The variable searchText was renamed since Visual Basic does not allow class members with the same name:
			Private searchText_Renamed As String

			Public Property SearchText() As String
				Get
					Return searchText_Renamed
				End Get
				Set(ByVal value As String)
					searchText_Renamed = value
				End Set
			End Property
		End Class

		Public Event Search As EventHandler(Of SearchBoxEventArgs)

		Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim newEvent As New SearchBoxEventArgs()
			newEvent.SearchText = Me.Text
			SearchEventRaiser(newEvent)
		End Sub

		Private Sub SearchEventRaiser(ByVal e As SearchBoxEventArgs)
			RaiseEvent Search(Me, e)
		End Sub
	End Class
End Namespace