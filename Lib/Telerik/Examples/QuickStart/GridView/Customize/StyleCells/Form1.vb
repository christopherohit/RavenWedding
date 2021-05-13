Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Customize.StyleCells
	Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
		Private Const ROWCOUNT As Integer = 10
		Private Const COLUMNCOUNT As Integer = 10

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.VirtualMode = True
			Me.radGridView1.RowCount = ROWCOUNT
			Me.radGridView1.ColumnCount = COLUMNCOUNT
			Me.radGridView1.BackColor = Color.Transparent
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.TableElement.DrawFill = False
			Me.radGridView1.TableElement.RowHeight = 50
			Me.radGridView1.TableElement.CellSpacing = 0
			Me.radGridView1.TableElement.RowSpacing = 0
			Me.radGridView1.MasterTemplate.ShowRowHeaderColumn = False
			Me.radGridView1.MasterTemplate.ShowColumnHeaders = False
			Me.radGridView1.MasterTemplate.AllowAddNewRow = False

			Me.radSpinEditorRow.Maximum = ROWCOUNT - 1
			Me.radSpinEditorColumn.Maximum = COLUMNCOUNT - 1

			Me.radButtonBackColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid

			ApplyRandomColors()
			UpdateBackColor()
		End Sub

		Private Sub radGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As CurrentCellChangedEventArgs)
			If Me.radGridView1.CurrentCell IsNot Nothing Then
				Me.radSpinEditorRow.Value = Me.radGridView1.CurrentCell.RowInfo.Index
				Me.radSpinEditorColumn.Value = Me.radGridView1.CurrentCell.ColumnInfo.Index
			End If
		End Sub

		Private Sub ApplyRandomColors()
			Dim r As New Random()
			For y As Integer = 0 To Me.radGridView1.RowCount - 1
				For x As Integer = 0 To Me.radGridView1.ColumnCount - 1
					Me.radGridView1.Rows(y).Cells(x).Style.CustomizeFill = True
					Me.radGridView1.Rows(y).Cells(x).Style.DrawFill = True
					Me.radGridView1.Rows(y).Cells(x).Style.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))
				Next x
			Next y
		End Sub

        Private Sub UpdateBackColor()
            Dim row As Integer = CInt(Fix(Me.radSpinEditorRow.Value))
            Dim column As Integer = CInt(Fix(Me.radSpinEditorColumn.Value))
            Dim backColor As Color = Me.radGridView1.Rows(row).Cells(column).Style.BackColor
            Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = backColor
        End Sub

		Private Sub SetCellBackground()
			Dim row As Integer = CInt(Fix(Me.radSpinEditorRow.Value))
			Dim column As Integer = CInt(Fix(Me.radSpinEditorColumn.Value))
            Dim dialog As New RadColorDialog()
            DirectCast(dialog.ColorDialogForm, RadForm).ThemeName = CurrentThemeName
            dialog.SelectedColor = Me.radGridView1.Rows(row).Cells(column).Style.BackColor
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radGridView1.Rows(row).Cells(column).Style.BackColor = dialog.SelectedColor
				Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
			End If
		End Sub

		Private Sub radGridView1_RowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs)
			e.RowElement.DrawBorder = False
			e.RowElement.DrawFill = False
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If e.CellElement.IsCurrent Then
				e.CellElement.DrawBorder = True
				e.CellElement.BorderWidth = 4
				e.CellElement.BorderColor = Color.Yellow
				e.CellElement.BorderBoxStyle = BorderBoxStyle.SingleBorder
			Else
				e.CellElement.DrawBorder = False
				e.CellElement.BorderWidth = 1
			End If
		End Sub

		Private Sub radSpinEditorRow_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.Rows(CInt(Fix(Me.radSpinEditorRow.Value))).IsCurrent = True
			UpdateBackColor()
		End Sub

		Private Sub radSpinEditorColumn_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.Columns(CInt(Fix(Me.radSpinEditorColumn.Value))).IsCurrent = True
			UpdateBackColor()
		End Sub

        Private Sub radButtonRandom_Click(ByVal sender As Object, ByVal e As EventArgs)
            ApplyRandomColors()
        End Sub

		Private Sub radButtonBackColor_Click(ByVal sender As Object, ByVal e As EventArgs)
			SetCellBackground()
		End Sub

		Private Sub radGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			SetCellBackground()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			AddHandler radGridView1.RowFormatting, AddressOf radGridView1_RowFormatting
			AddHandler radGridView1.CellDoubleClick, AddressOf radGridView1_CellDoubleClick
			AddHandler radGridView1.CurrentCellChanged, AddressOf radGridView1_CurrentCellChanged
			AddHandler radButtonRandom.Click, AddressOf radButtonRandom_Click
			AddHandler radSpinEditorRow.ValueChanged, AddressOf radSpinEditorRow_ValueChanged
			AddHandler radSpinEditorColumn.ValueChanged, AddressOf radSpinEditorColumn_ValueChanged
			AddHandler radButtonBackColor.Click, AddressOf radButtonBackColor_Click
		End Sub
	End Class
End Namespace
