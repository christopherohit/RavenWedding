Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.PropertyGrid.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)
			If Me.radPropertyGrid1 IsNot Nothing Then
				Dim width As Integer = Me.ClientSize.Width
				Dim height As Integer = Me.ClientSize.Height
				Me.radPropertyGrid1.Location =Point.Empty
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.AutoScroll = False

			Me.radPropertyGrid1.HelpVisible = True
			Me.radPropertyGrid1.ToolbarVisible = True
			Me.radPropertyGrid1.KeyboardSearchEnabled = True

			Me.radPropertyGrid1.SelectedObject = New RadPropertyGrid()

			Me.radCheckBoxHelpVisible.IsChecked = Me.radPropertyGrid1.HelpVisible
			Me.radCheckBoxSearchVisible.IsChecked = Me.radPropertyGrid1.ToolbarVisible
			Me.radCheckBoxReadOnly.IsChecked = Me.radPropertyGrid1.ReadOnly
			Me.radCheckBoxAutoExpandGroups.IsChecked = Me.radPropertyGrid1.AutoExpandGroups
			Me.radCheckBoxKeyboardSearch.IsChecked = Me.radPropertyGrid1.KeyboardSearchEnabled
			Me.radSpinEditorItemHeight.Value = Me.radPropertyGrid1.ItemHeight
			Me.radSpinEditorItemIndent.Value = Me.radPropertyGrid1.ItemIndent
			Me.radSpinEditorItemSpacing.Value = Me.radPropertyGrid1.ItemSpacing
			Me.radDropDownListPropertySort.DataSource = System.Enum.GetValues(GetType(PropertySort))
			Me.radDropDownListPropertySort.SelectedValue = Me.radPropertyGrid1.PropertySort

			AddHandler radPropertyGrid1.PropertyGridElement.PropertyChanged, AddressOf Element_PropertyChanged
			AddHandler radPropertyGrid1.PropertyGridElement.SplitElement.PropertyChanged, AddressOf Element_PropertyChanged
			AddHandler radPropertyGrid1.PropertyGridElement.SplitElement.PropertyTableElement.PropertyChanged, AddressOf Element_PropertyChanged

			Me.radPropertyGrid1.PropertySort = PropertySort.CategorizedAlphabetical
			Me.WireEvents()
		End Sub

		Private Sub Element_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "SearchBarVisible" Then
				Me.radCheckBoxSearchVisible.IsChecked = Me.radPropertyGrid1.ToolbarVisible
			ElseIf e.PropertyName = "HelpVisible" Then
				Me.radCheckBoxHelpVisible.IsChecked = Me.radPropertyGrid1.HelpVisible
			ElseIf e.PropertyName = "PropertySort" Then
				Me.radDropDownListPropertySort.SelectedValue = Me.radPropertyGrid1.PropertySort
			End If
		End Sub

		Private Sub radCheckBoxHelpVisible_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radPropertyGrid1.HelpVisible = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxSearchVisible_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radPropertyGrid1.ToolbarVisible = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxReadOnly_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radPropertyGrid1.ReadOnly = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxAutoExpandGroups_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radPropertyGrid1.AutoExpandGroups = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxKeyboardSearch_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxKeyboardSearch.ToggleStateChanged
			Me.radPropertyGrid1.KeyboardSearchEnabled = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radSpinEditorItemHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radPropertyGrid1.ItemHeight = CInt(Fix(Me.radSpinEditorItemHeight.Value))
		End Sub

		Private Sub radSpinEditorItemIndent_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radPropertyGrid1.ItemIndent = CInt(Fix(Me.radSpinEditorItemIndent.Value))
		End Sub

		Private Sub radSpinEditorItemSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radPropertyGrid1.ItemSpacing = CInt(Fix(Me.radSpinEditorItemSpacing.Value))
		End Sub

		Private Sub radDropDownListPropertySort_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radPropertyGrid1.PropertySort = CType(Me.radDropDownListPropertySort.SelectedValue, PropertySort)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radDropDownListPropertySort.SelectedIndexChanged, AddressOf radDropDownListPropertySort_SelectedIndexChanged
			AddHandler radSpinEditorItemSpacing.ValueChanged, AddressOf radSpinEditorItemSpacing_ValueChanged
			AddHandler radSpinEditorItemIndent.ValueChanged, AddressOf radSpinEditorItemIndent_ValueChanged
			AddHandler radSpinEditorItemHeight.ValueChanged, AddressOf radSpinEditorItemHeight_ValueChanged
			AddHandler radCheckBoxAutoExpandGroups.ToggleStateChanged, AddressOf radCheckBoxAutoExpandGroups_ToggleStateChanged
			AddHandler radCheckBoxReadOnly.ToggleStateChanged, AddressOf radCheckBoxReadOnly_ToggleStateChanged
			AddHandler radCheckBoxSearchVisible.ToggleStateChanged, AddressOf radCheckBoxSearchVisible_ToggleStateChanged
			AddHandler radCheckBoxHelpVisible.ToggleStateChanged, AddressOf radCheckBoxHelpVisible_ToggleStateChanged
		End Sub
	End Class
End Namespace
