Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Customize.FormattingWithCode
	Partial Public Class Form1
		Inherits ExamplesForm
'INSTANT VB NOTE: The variable font was renamed since Visual Basic does not allow class members with the same name:
		Private font_Renamed As Font

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radButtonForeColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor = Color.Yellow

			Me.radButtonBackColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = Color.Red

			employeeOrdersTableAdapter.Fill(northwindDataSet.EmployeeOrders)

			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("Title GroupBy Title"))
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If e.CellElement.ColumnInfo.Name = "FirstName" AndAlso TypeOf e.CellElement.RowInfo Is GridViewDataRowInfo Then
				Dim quantity As Integer = -1
				Dim quantityValue As Object = e.CellElement.RowInfo.Cells("Quantity").Value

				If quantityValue IsNot Nothing AndAlso (Not Convert.IsDBNull(quantityValue)) Then
					quantity = CInt(Fix(CShort(Fix(quantityValue))))
				End If

				If quantity >= CInt(Fix(Me.radSpinEditorGreater.Value)) AndAlso quantity <= CInt(Fix(Me.radSpinEditorLess.Value)) Then
					e.CellElement.DrawFill = True
					e.CellElement.GradientStyle = GradientStyles.Solid
					e.CellElement.ForeColor = Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor
					e.CellElement.BackColor = Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor
				Else
					e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
					e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
					e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
					e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				End If
			Else
				e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radGridView1_RowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs)
			If font_Renamed Is Nothing Then
				font_Renamed = New Font(e.RowElement.Font, FontStyle.Bold)
			End If

			Dim quantity As Integer = -1

			Dim quantityValue As Object = e.RowElement.RowInfo.Cells("Quantity").Value

			If quantityValue IsNot Nothing AndAlso (Not Convert.IsDBNull(quantityValue)) Then
				quantity = CInt(Fix(CShort(Fix(quantityValue))))
			End If

			If quantity >= CInt(Fix(Me.radSpinEditorGreater.Value)) AndAlso quantity <= CInt(Fix(Me.radSpinEditorLess.Value)) Then
                e.RowElement.Font = font_Renamed
                e.RowElement.BackColor = Color.FromArgb(190, 190, 190)
                e.RowElement.ForeColor = Color.Black
                e.RowElement.DrawFill = True
                e.RowElement.GradientStyle = GradientStyles.Solid
			Else
                e.RowElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
                e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.RowElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radButtonForeColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As New RadColorDialog()
            DirectCast(dialog.ColorDialogForm, RadForm).ThemeName = CurrentThemeName
			dialog.SelectedColor = Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
			End If
		End Sub

		Private Sub radButtonBackColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As New RadColorDialog()
            DirectCast(dialog.ColorDialogForm, RadForm).ThemeName = CurrentThemeName
            dialog.SelectedColor = Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
			End If
		End Sub

		Private Sub radSpinEditorGreater_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radSpinEditorLess_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButtonBackColor.Click, AddressOf radButtonBackColor_Click
			AddHandler radButtonForeColor.Click, AddressOf radButtonForeColor_Click
			AddHandler radSpinEditorLess.ValueChanged, AddressOf radSpinEditorLess_ValueChanged
			AddHandler radSpinEditorGreater.ValueChanged, AddressOf radSpinEditorGreater_ValueChanged
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			AddHandler radGridView1.RowFormatting, AddressOf radGridView1_RowFormatting
		End Sub
	End Class
End Namespace
