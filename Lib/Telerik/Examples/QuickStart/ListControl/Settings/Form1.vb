Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.ListControl.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		Private itemsText() As String = { "(NONE)", "(NONE)", "(NONE)", "AAC File", "ASA", "ASAX", "ASCX", "ASPX", "MP3", "MPEG" }
		Private itemsDescriptionText() As String = { "AudioCD", "File Folder", "Help and Support Center protocol", "Quicktime File", "ASA File", "ASP.NET Server Application", "ASP.NET User Control", "ASP.NET Server Page", "Winamp Media File", "Movie Clip" }

		Public Sub New()
			InitializeComponent()

			Me.radListBoxDemo.ItemHeight = 50
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radDropDownList1.SelectedIndex = 0
			Me.radComboSelectionMode.SelectedIndex = 1
			Me.radListBoxDemo.SelectedIndex = 0
			Me.radComboSortStyle.SelectedIndex = 2
		End Sub

		Private Sub ClearSelectedItemControls()
			Me.radComboImageAlign.SelectedItem = Nothing
			Me.radComboTextAlign.SelectedItem = Nothing
			Me.radComboTextImage.SelectedItem = Nothing
			Me.radComboTextOrientation.SelectedItem = Nothing
		End Sub

		Private Sub radListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.UpdateSettingsControls()
		End Sub

        Private Sub UpdateSettingsControls()
            Dim item As RadListDataItem
            For Each item In radListBoxDemo.SelectedItems
                Me.radComboImageAlign.SelectedIndex = Me.radComboImageAlign.ListElement.FindString(item.ImageAlignment.ToString())
                Me.radComboTextAlign.SelectedIndex = Me.radComboTextAlign.ListElement.FindString(item.TextAlignment.ToString())
                Me.radComboTextImage.SelectedIndex = Me.radComboTextImage.ListElement.FindString(item.TextImageRelation.ToString())
                Me.radComboTextOrientation.SelectedIndex = Me.radComboTextOrientation.ListElement.FindString(item.TextOrientation.ToString())
            Next item
        End Sub

		Private Sub comboImageAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadListDataItem = radListBoxDemo.SelectedItem
			If item Is Nothing Then
				Return
			End If

			Dim comboItem As RadListDataItem = Me.radComboImageAlign.SelectedItem
			Select Case comboItem.Text
				Case "TopLeft"
					item.ImageAlignment = ContentAlignment.TopLeft
				Case "TopCenter"
					item.ImageAlignment = ContentAlignment.TopCenter
				Case "TopRight"
					item.ImageAlignment = ContentAlignment.TopRight
				Case "MiddleLeft"
					item.ImageAlignment = ContentAlignment.MiddleLeft
				Case "MiddleCenter"
					item.ImageAlignment = ContentAlignment.MiddleCenter
				Case "MiddleRight"
					item.ImageAlignment = ContentAlignment.MiddleRight
				Case "BottomLeft"
					item.ImageAlignment = ContentAlignment.BottomLeft
				Case "BottomCenter"
					item.ImageAlignment = ContentAlignment.BottomCenter
				Case "BottomRight"
					item.ImageAlignment = ContentAlignment.BottomRight
			End Select
		End Sub

		Private Sub comboTextAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadListDataItem = radListBoxDemo.SelectedItem
			If item Is Nothing Then
				Return
			End If

			Dim comboItem As RadListDataItem = Me.radComboTextAlign.SelectedItem
			Select Case comboItem.Text
				Case "TopLeft"
					item.TextAlignment = ContentAlignment.TopLeft
				Case "TopCenter"
					item.TextAlignment = ContentAlignment.TopCenter
				Case "TopRight"
					item.TextAlignment = ContentAlignment.TopRight
				Case "MiddleLeft"
					item.TextAlignment = ContentAlignment.MiddleLeft
				Case "MiddleCenter"
					item.TextAlignment = ContentAlignment.MiddleCenter
				Case "MiddleRight"
					item.TextAlignment = ContentAlignment.MiddleRight
				Case "BottomLeft"
					item.TextAlignment = ContentAlignment.BottomLeft
				Case "BottomCenter"
					item.TextAlignment = ContentAlignment.BottomCenter
				Case "BottomRight"
					item.TextAlignment = ContentAlignment.BottomRight
			End Select
		End Sub

		Private Sub comboTextImageRel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadListDataItem = radListBoxDemo.SelectedItem
			If item Is Nothing Then
				Return
			End If
			Dim comboItem As RadListDataItem = Me.radComboTextImage.SelectedItem
			Select Case comboItem.Text
				Case "ImageAboveText"
						item.TextImageRelation = TextImageRelation.ImageAboveText
						Exit Select
				Case "ImageBeforeText"
						item.TextImageRelation = TextImageRelation.ImageBeforeText
						Exit Select
				Case "TextAboveImage"
						item.TextImageRelation = TextImageRelation.TextAboveImage
						Exit Select
				Case "TextBeforeImage"
						item.TextImageRelation = TextImageRelation.TextBeforeImage
						Exit Select
				Case "Overlay"
						item.TextImageRelation = TextImageRelation.Overlay
						Exit Select
			End Select
		End Sub

		Private Sub comboTextOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadListDataItem = radListBoxDemo.SelectedItem

			Dim comboItem As RadListDataItem = Me.radComboTextOrientation.SelectedItem
			If item IsNot Nothing Then
				If comboItem.Text = "Vertical" Then
					item.TextOrientation = Orientation.Vertical
				Else
					item.TextOrientation = Orientation.Horizontal
				End If
			End If
		End Sub

		Private Sub comboSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			radListBoxDemo.SelectionMode = CType(Me.radComboSelectionMode.SelectedIndex, SelectionMode)
		End Sub

		Private Sub comboSortStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Select Case Me.radComboSortStyle.SelectedText
				Case "Ascending"
					radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
				Case "Descending"
					radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending
				Case "None"
					radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
				Case Else
			End Select
		End Sub

		Private Sub OnSortStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radComboSortStyle.SelectedItem.Text = SortStyle.Ascending.ToString() Then
				Me.radListBoxDemo.SortStyle = SortStyle.Ascending
			ElseIf Me.radComboSortStyle.SelectedItem.Text = SortStyle.Descending.ToString() Then
				Me.radListBoxDemo.SortStyle = SortStyle.Descending
			Else
				Me.radListBoxDemo.SortStyle = SortStyle.None
			End If
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radListBoxDemo.Items.Clear()
			Dim item As RadListDataItem
			Dim isRadListDataItems As Boolean = Me.radDropDownList1.SelectedItem.Text = "RadListDataItems"

			For i As Integer = 0 To 9
				item = If(isRadListDataItems, New RadListDataItem(), New DescriptionTextListDataItem())
				item.Text = itemsText(i)
				item.Image = imageList1.Images(i)
				If Not isRadListDataItems Then
					CType(item, DescriptionTextListDataItem).DescriptionText = itemsDescriptionText(i)
				End If
				Me.radListBoxDemo.Items.Add(item)
			Next i

			Me.radListBoxDemo.SelectedIndex = 0
			Me.radGroupItem.Enabled = isRadListDataItems
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radListBoxDemo.SelectedIndexChanged, AddressOf radListBox1_SelectedIndexChanged
			AddHandler radComboSortStyle.SelectedIndexChanged, AddressOf OnSortStyle_SelectedIndexChanged
			AddHandler radComboSelectionMode.SelectedIndexChanged, AddressOf comboSelectionMode_SelectedIndexChanged
			AddHandler radComboTextOrientation.SelectedIndexChanged, AddressOf comboTextOrientation_SelectedIndexChanged
			AddHandler radComboTextAlign.SelectedIndexChanged, AddressOf comboTextAlign_SelectedIndexChanged
			AddHandler radComboImageAlign.SelectedIndexChanged, AddressOf comboImageAlign_SelectedIndexChanged
			AddHandler radComboTextImage.SelectedIndexChanged, AddressOf comboTextImageRel_SelectedIndexChanged
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radListBoxDemo.VisualItemFormatting, AddressOf radListBoxDemo_VisualItemFormatting
		End Sub

		Private Sub radListBoxDemo_VisualItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
			Dim descItem As DescriptionTextListVisualItem = TryCast(args.VisualItem, DescriptionTextListVisualItem)
			If descItem IsNot Nothing Then
				descItem.Separator.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			End If
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			radListBoxDemo.EnableAlternatingItemColor = args.ToggleState = ToggleState.On
		End Sub
	End Class
End Namespace