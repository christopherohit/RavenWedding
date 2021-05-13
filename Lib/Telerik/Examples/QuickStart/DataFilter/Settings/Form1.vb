Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.DataFilter.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radDataFilter1.Descriptors.Add(New DataFilterDescriptorItem("TextItem", GetType(String)))
			Me.radDataFilter1.Descriptors.Add(New DataFilterDescriptorItem("IntegerItem", GetType(Integer)))
			Me.radDataFilter1.Descriptors.Add(New DataFilterDescriptorItem("DoubleItem", GetType(Double)))
			Me.radDataFilter1.Descriptors.Add(New DataFilterDescriptorItem("DateItem", GetType(Date)))
			Me.radDataFilter1.Descriptors.Add(New DataFilterDescriptorItem("BoolItem", GetType(Boolean)))

			Me.radDataFilter1.Expression = "[TextItem] LIKE 'f%' AND [IntegerItem] > '10' AND [DoubleItem] < '12' AND [DateItem] < #01/18/2017 00:00:00# AND [BoolItem] = True"

			ExamplesForm.FillComboFromEnum(Me.radDropDownListLineStyle, GetType(TreeLineStyle), TreeLineStyle.Solid)
		End Sub

		Private Sub radCheckBoxAllowAdd_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxAllowAdd.ToggleStateChanged
			Me.radDataFilter1.AllowAdd = Me.radCheckBoxAllowAdd.IsChecked
		End Sub

		Private Sub radCheckBoxAllowRemove_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxAllowRemove.ToggleStateChanged
			Me.radDataFilter1.AllowRemove = Me.radCheckBoxAllowRemove.IsChecked
		End Sub

		Private Sub radCheckBoxAllowDragDrop_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxAllowDragDrop.ToggleStateChanged
			Me.radDataFilter1.AllowDragDrop = Me.radCheckBoxAllowDragDrop.IsChecked
		End Sub

		Private Sub radCheckBoxSortFieldNames_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxSortFieldNames.ToggleStateChanged
			Me.radDataFilter1.SortFieldNames = Me.radCheckBoxSortFieldNames.IsChecked
		End Sub

		Private Sub radColorBoxLineColor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radColorBoxLineColor.ValueChanged
			Me.radDataFilter1.LineColor = Me.radColorBoxLineColor.Value
		End Sub

		Private Sub radDropDownListLineStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownListLineStyle.SelectedIndexChanged
			Me.radDataFilter1.LineStyle = CType(Me.radDropDownListLineStyle.SelectedItem.Value, TreeLineStyle)
		End Sub

		Private Sub radSpinEditorNodeSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorNodeSpacing.ValueChanged
			Me.radDataFilter1.DataFilterElement.NodeSpacing = CInt(Fix(Me.radSpinEditorNodeSpacing.Value))
		End Sub

		Private Sub radSpinEditorTreeIndent_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorTreeIndent.ValueChanged
			Me.radDataFilter1.TreeIndent = CInt(Fix(Me.radSpinEditorTreeIndent.Value))
		End Sub

		Private Sub radCheckBoxShowLines_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxShowLines.ToggleStateChanged
			Me.radDataFilter1.ShowLines = Me.radCheckBoxShowLines.IsChecked
		End Sub

		Private Sub radCheckBoxAllowEdit_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxAllowEdit.ToggleStateChanged
			Dim allowEdit As Boolean = Me.radCheckBoxAllowEdit.IsChecked
			Me.radDataFilter1.AllowEdit = allowEdit
			If allowEdit Then
				Me.radCheckBoxAllowAdd.Enabled = True
			Else
				Me.radCheckBoxAllowAdd.IsChecked = False
				Me.radCheckBoxAllowAdd.Enabled = False
			End If
		End Sub

		Private Sub radButtonLoadXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonLoadXml.Click
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.AddExtension = True
			openFileDialog.DefaultExt = ".xml"
			openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
			openFileDialog.Multiselect = False

			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Me.radDataFilter1.LoadXML(openFileDialog.FileName)
				Me.radSpinEditorTreeIndent.Value = Me.radDataFilter1.TreeIndent
				Me.radSpinEditorNodeSpacing.Value = Me.radDataFilter1.SpacingBetweenNodes
				Me.radDropDownListLineStyle.SelectedValue = Me.radDataFilter1.LineStyle
				Me.radColorBoxLineColor.Value = Me.radDataFilter1.LineColor
				Me.radCheckBoxSortFieldNames.IsChecked = Me.radDataFilter1.SortFieldNames
				Me.radCheckBoxShowLines.IsChecked = Me.radDataFilter1.ShowLines
				Me.radCheckBoxAllowEdit.IsChecked = Me.radDataFilter1.AllowEdit
				Me.radCheckBoxAllowDragDrop.IsChecked = Me.radDataFilter1.AllowDragDrop
				Me.radCheckBoxAllowRemove.IsChecked = Me.radDataFilter1.AllowRemove
				Me.radCheckBoxAllowAdd.IsChecked = Me.radDataFilter1.AllowAdd
			End If
		End Sub

		Private Sub radButtonSaveXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonSaveXml.Click
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.AddExtension = True
			saveFileDialog.DefaultExt = ".xml"
			saveFileDialog.FileName = "DataFilterXml"
			saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"

			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Me.radDataFilter1.SaveXML(saveFileDialog.FileName)
			End If
		End Sub
	End Class
End Namespace
