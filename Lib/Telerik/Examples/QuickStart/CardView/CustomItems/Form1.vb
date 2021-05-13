Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.CardView.CustomItems
	Partial Public Class Form1
		Inherits ExamplesForm
		Private features As List(Of String)
		Private makeFont As New Font("Segoe UI Light", 18f)
		Private yearFont As New Font("Segoe UI", 13.5f)
		Private checkBoxFont As New Font("Segoe UI", 10.5f)

		Public Sub New()
			InitializeComponent()

			Dim searchIcon As New ImagePrimitive()
			searchIcon.Image = My.Resources.TV_search
			searchIcon.Alignment = ContentAlignment.MiddleRight
			Me.commandBarTextBoxFilter.TextBoxElement.StretchHorizontally = True
			Me.commandBarTextBoxFilter.TextBoxElement.Alignment = ContentAlignment.MiddleRight
            Me.commandBarTextBoxFilter.TextBoxElement.ButtonsStack.Children.Add(searchIcon)
			Me.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.Alignment = ContentAlignment.MiddleLeft
			AddHandler Me.commandBarTextBoxFilter.TextBoxElement.TextBoxItem.PropertyChanged, AddressOf TextBoxItem_PropertyChanged
			Me.radCardView1.AllowEdit = False
			Me.features = New List(Of String)() From {"AirConditioner", "Mp3Player", "DVDPlayer", "ABS", "ASR", "Navigation"}
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.carsRatesDataTableTableAdapter.Fill(Me.sofiaCarRentalDataSet.CarsRatesDataTable)

			Me.commandBarDropDownGroup.SelectedIndex = 1
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()
			AddHandler Me.radCardView1.CardViewItemCreating, AddressOf radCardView1_CardViewItemCreating
			AddHandler Me.radCardView1.CardViewItemFormatting, AddressOf radCardView1_CardViewItemFormatting
			AddHandler Me.radCardView1.SortDescriptors.CollectionChanged, AddressOf SortDescriptors_CollectionChanged
			AddHandler Me.commandBarTextBoxFilter.TextChanged, AddressOf commandBarTextBoxFilter_TextChanged
			AddHandler Me.commandBarDropDownSort.SelectedIndexChanged, AddressOf commandBarDropDownSort_SelectedIndexChanged
			AddHandler Me.commandBarDropDownGroup.SelectedIndexChanged, AddressOf commandBarDropDownGroup_SelectedIndexChanged
		End Sub

		Private Function ContainsFeature(ByVal item As ListViewDataItem, ByVal feature As String) As Boolean
			Return item(feature) IsNot Nothing AndAlso Convert.ToInt32(item(feature)) <> 0
		End Function

		Private checkBoxItemsFont As New Font("Segoe UI", 10.5f)
		Private Sub radCardView1_CardViewItemCreating(ByVal sender As Object, ByVal e As CardViewItemCreatingEventArgs)
			Dim groupItem As CardViewGroupItem = TryCast(e.NewItem, CardViewGroupItem)
			If groupItem IsNot Nothing Then
				groupItem.DrawText = True
				groupItem.Font = Me.checkBoxItemsFont
				groupItem.Text = "Extras"
			End If

			Dim cardViewItem As CardViewItem = TryCast(e.NewItem, CardViewItem)
			If cardViewItem Is Nothing OrElse String.IsNullOrEmpty(cardViewItem.FieldName) Then
				Return
			End If

			If Me.features.Contains(cardViewItem.FieldName) Then
				Dim checkBoxItem As New CheckBoxCardViewItem()
				checkBoxItem.FieldName = cardViewItem.FieldName
				e.NewItem = checkBoxItem
			End If
		End Sub

		Private Sub radCardView1_CardViewItemFormatting(ByVal sender As Object, ByVal e As CardViewItemFormattingEventArgs)
			Dim cardViewItem As CardViewItem = TryCast(e.Item, CardViewItem)
			If cardViewItem Is Nothing OrElse String.IsNullOrEmpty(cardViewItem.FieldName) Then
				Return
			End If

			If cardViewItem.FieldName = "ImageFileName" Then
				cardViewItem.TextSizeMode = LayoutItemTextSizeMode.Fixed
				cardViewItem.TextFixedSize = 0
				cardViewItem.EditorItem.DrawText = False
				cardViewItem.EditorItem.DrawImage = True
                Dim image As Image = Image.FromFile(Application.StartupPath & "\Resources\CarRentalImages\" & e.VisualItem.Data("ImageFileName").ToString
                                                    )
                Dim factor As Single = 160 / CSng(image.Height)
				Dim resizedImage As New Bitmap(image, New SizeF(factor * image.Width, factor * image.Height).ToSize())
				cardViewItem.EditorItem.Image = resizedImage
			ElseIf cardViewItem.FieldName = "Make" Then
				cardViewItem.EditorItem.Font = makeFont
                cardViewItem.EditorItem.Text = CType(e.VisualItem.Data("Make").ToString & "  " & e.VisualItem.Data("Model").ToString, String)
            ElseIf cardViewItem.FieldName = "CarYear" OrElse cardViewItem.FieldName = "CategoryName" Then
                cardViewItem.EditorItem.Font = yearFont
			End If

			Dim checkBoxItem As CheckBoxCardViewItem = TryCast(e.Item, CheckBoxCardViewItem)
			If checkBoxItem IsNot Nothing Then
				TryCast(checkBoxItem.EditorItem, CheckBoxEditorItem).Font = checkBoxFont
			End If
		End Sub

		Private Sub commandBarDropDownSort_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			RemoveHandler Me.radCardView1.SortDescriptors.CollectionChanged, AddressOf SortDescriptors_CollectionChanged

			Me.radCardView1.SortDescriptors.Clear()
			Select Case Me.commandBarDropDownSort.Text
				Case "Make"
					Me.radCardView1.SortDescriptors.Add(New SortDescriptor("Make", ListSortDirection.Ascending))
					Me.radCardView1.EnableSorting = True
				Case "Model"
					Me.radCardView1.SortDescriptors.Add(New SortDescriptor("Model", ListSortDirection.Ascending))
					Me.radCardView1.EnableSorting = True
				Case "Category"
					Me.radCardView1.SortDescriptors.Add(New SortDescriptor("CategoryName", ListSortDirection.Ascending))
					Me.radCardView1.EnableSorting = True
				Case "Year"
					Me.radCardView1.SortDescriptors.Add(New SortDescriptor("CarYear", ListSortDirection.Ascending))
					Me.radCardView1.EnableSorting = True
			End Select

			AddHandler Me.radCardView1.SortDescriptors.CollectionChanged, AddressOf SortDescriptors_CollectionChanged
		End Sub

		Private Sub commandBarDropDownGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radCardView1.GroupDescriptors.Clear()
			Select Case Me.commandBarDropDownGroup.Text
				Case "None"
					Me.radCardView1.EnableGrouping = False
					Me.radCardView1.ShowGroups = False
				Case "Make"
					Me.radCardView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() { New SortDescriptor("Make", ListSortDirection.Ascending) }))
					Me.radCardView1.EnableGrouping = True
					Me.radCardView1.ShowGroups = True
				Case "Category"
					Me.radCardView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() { New SortDescriptor("CategoryName", ListSortDirection.Ascending) }))
					Me.radCardView1.EnableGrouping = True
					Me.radCardView1.ShowGroups = True
				Case "Year"
					Me.radCardView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor() { New SortDescriptor("CarYear", ListSortDirection.Ascending) }))
					Me.radCardView1.EnableGrouping = True
					Me.radCardView1.ShowGroups = True
			End Select
		End Sub

		Private Sub commandBarTextBoxFilter_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radCardView1.FilterDescriptors.Clear()

			If String.IsNullOrEmpty(Me.commandBarTextBoxFilter.Text) Then
				Me.radCardView1.EnableFiltering = False
			Else
				Me.radCardView1.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or
				Me.radCardView1.FilterDescriptors.Add("Make", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
				Me.radCardView1.FilterDescriptors.Add("Model", FilterOperator.Contains, Me.commandBarTextBoxFilter.Text)
				Me.radCardView1.EnableFiltering = True
			End If
		End Sub

		Private Sub TextBoxItem_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "Bounds" Then
				commandBarTextBoxFilter.TextBoxElement.TextBoxItem.HostedControl.MaximumSize = New Size(CInt(commandBarTextBoxFilter.DesiredSize.Width) - 28, 0)
			End If
		End Sub

		Private Sub SortDescriptors_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			If Me.radCardView1.SortDescriptors.Count = 0 Then
				Me.commandBarDropDownSort.SelectedIndex = 0
				Return
			End If

			Dim columnName As String = Me.radCardView1.Columns(Me.radCardView1.SortDescriptors(0).PropertyName).HeaderText
			If columnName = "Manufactured" Then
				columnName = "Year"
			End If
			Dim item As RadListDataItem = Me.commandBarDropDownSort.ListElement.FindItemExact(columnName, False)
			If item IsNot Nothing Then
				Me.commandBarDropDownSort.SelectedItem = item
			End If
		End Sub
	End Class

	Public Class CheckBoxCardViewItem
		Inherits CardViewItem
		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			Me.TextSizeMode = LayoutItemTextSizeMode.Proportional
			Me.TextProportionalSize = 0
		End Sub

		Protected Overrides Function CreateEditorItem() As CardViewEditorItem
			Return New CheckBoxEditorItem()
		End Function

		Public Overrides Sub Synchronize()
			Dim cardVisualItem As CardListViewVisualItem = Me.FindAncestor(Of CardListViewVisualItem)()
			If Me.CardField Is Nothing OrElse cardVisualItem Is Nothing OrElse cardVisualItem.Data Is Nothing Then
				Return
			End If

			Dim checkBox As RadCheckBoxElement = (TryCast(Me.EditorItem, CheckBoxEditorItem)).Checkbox
			checkBox.Text = Me.CardField.HeaderText
			Dim data As Object = cardVisualItem.Data(Me.CardField)
			checkBox.Checked = Me.ContainsFeature(cardVisualItem.Data, Me.FieldName)
		End Sub

		Private Function ContainsFeature(ByVal item As ListViewDataItem, ByVal feature As String) As Boolean
			Return item(feature) IsNot Nothing AndAlso Convert.ToInt32(item(feature)) <> 0
		End Function
	End Class

	Public Class CheckBoxEditorItem
		Inherits CardViewEditorItem
'INSTANT VB NOTE: The variable checkbox was renamed since Visual Basic does not allow class members with the same name:
		Private checkbox_Renamed As RadCheckBoxElement

		Public Property Checkbox() As RadCheckBoxElement
			Get
				Return Me.checkbox_Renamed
			End Get
			Set(ByVal value As RadCheckBoxElement)
				Me.checkbox_Renamed = value
			End Set
		End Property

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			Me.checkbox_Renamed = New RadCheckBoxElement()
			Me.Children.Add(Me.checkbox_Renamed)
			AddHandler Me.checkbox_Renamed.ToggleStateChanged, AddressOf checkbox_ToggleStateChanged
		End Sub

		Private Sub checkbox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			' on check box value changed we need to change the value in DataSource
		End Sub
	End Class
End Namespace
