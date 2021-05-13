Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Spreadsheet
	Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
		#Region "Constants"

		Private Const alphabetLength As Integer = 26
		Private Const rowsCount As Integer = 1000
		Private Const columnsCount As Integer = 1000
		Private Const rowBeginIndex As Integer = 2
		Private Const clientColumnIndex As Integer = 1
		Private Const feeColumnIndex As Integer = clientColumnIndex + 1
		Private Const comissionColumnIndex As Integer = feeColumnIndex + 1
		Private Const totalColumnIndex As Integer = comissionColumnIndex + 1

		#End Region

		#Region "Fields"

		Private updatingCombos As Boolean = False

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.radRibbonBarButtonGroup2.ShowBorder = False
			Me.radRibbonBarButtonGroup3.ShowBorder = False
			Me.radRibbonBarButtonGroup9.ShowBorder = False
			Me.radRibbonBarButtonGroup13.ShowBorder = False
			Me.radRibbonBarButtonGroup14.ShowBorder = False
			Me.radButtonElementCut.ShowBorder = False
			Me.radButtonElementCopy.ShowBorder = False
			Me.radButtonElementFormat.ShowBorder = False

			Me.SetGridProperties()

			AddHandler gridView.CellFormatting, AddressOf gridView_CellFormatting
			AddHandler gridView.ViewCellFormatting, AddressOf gridView_ViewCellFormatting
			AddHandler gridView.CreateCell, AddressOf GridView_CreateCell

			AddHandler gridView.CurrentCellChanged, AddressOf gridView_CurrentCellChanged
			AddHandler gridView.ValueChanged, AddressOf gridView_ValueChanged

			AddHandler gridView.RowsChanged, AddressOf gridView_RowsChanged

			Me.SelectedControl = Me.gridView
			Me.radDropDownListElementFont.SelectedItem = Me.radDropDownListElementFont.Items(0)
			Me.radDropDownListElementFontSize.SelectedItem = Me.radDropDownListElementFontSize.Items(0)

			AddHandler radButtonElementBold.Click, AddressOf radButtonElementBold_Click
			AddHandler radButtonElementItalic.Click, AddressOf radButtonElementItalic_Click
			AddHandler radButtonElementUnderline.Click, AddressOf radButtonElementUnderline_Click
			AddHandler radButtonElementColor.Click, AddressOf radButtonElementColor_Click
			AddHandler radButtonElementFontColor.Click, AddressOf radButtonElementFontColor_Click


			AddHandler radDropDownListElementFont.SelectedIndexChanged, AddressOf radDropDownListElementFont_SelectedIndexChanged
			AddHandler radDropDownListElementFontSize.SelectedIndexChanged, AddressOf radDropDownListElementFontSize_SelectedIndexChanged
			AddHandler radButtonElementIncrease.Click, AddressOf radButtonElementIncrease_Click
			AddHandler radButtonElementDecrease.Click, AddressOf radButtonElementDecrease_Click

			AddHandler radTextBoxCellContent.TextChanged, AddressOf radTextBoxCellContent_TextChanged
		End Sub

		#End Region

		#Region "Event Handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			For i As Integer = 0 To Me.gridView.Columns.Count - 1
				Dim dataColumn As GridViewDataColumn = TryCast(Me.gridView.Columns(i), GridViewDataColumn)

				If dataColumn IsNot Nothing Then
					dataColumn.HeaderText = Me.GetColumnName(i)
					dataColumn.Width = 100
				End If
			Next i

			Me.gridView.TableElement.RowHeight = 26
			Me.gridView.TableElement.TableHeaderHeight = 32

			Me.FillGridWithData()
			Me.SetInitialStyles()
		End Sub

		Private Sub gridView_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			Dim columnIndex As Integer = e.CellElement.ColumnIndex
			Dim rowIndex As Integer = e.CellElement.RowIndex
			Dim cell As GridCellElement = e.CellElement
			If rowIndex = rowBeginIndex - 1 Then
				If columnIndex = totalColumnIndex OrElse columnIndex = comissionColumnIndex OrElse columnIndex = feeColumnIndex OrElse columnIndex = clientColumnIndex Then
					If cell.IsSelected Then
						cell.BackColor = Color.FromArgb(162, 207, 223)
					End If
				End If
			ElseIf rowIndex > rowBeginIndex - 1 AndAlso rowIndex < rowBeginIndex + 8 Then
				If columnIndex = totalColumnIndex OrElse columnIndex = comissionColumnIndex OrElse columnIndex = feeColumnIndex OrElse columnIndex = clientColumnIndex Then
					If cell.IsSelected Then
						cell.BackColor = Color.FromArgb(228, 227, 216)
					End If
				End If
			End If

			If IsNumber(e.CellElement.Value) Then
				e.CellElement.Alignment = ContentAlignment.TopRight
			Else
				e.CellElement.Alignment = ContentAlignment.TopLeft
			End If
		End Sub

		Private Sub gridView_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.CellElement Is SpreadsheetGridRowHeaderCellElement Then
				StyleSelectedCell(TryCast(e.CellElement, SpreadsheetGridRowHeaderCellElement))
			ElseIf TypeOf e.CellElement Is GridHeaderCellElement Then
				StyleSelectedCell(TryCast(e.CellElement, GridHeaderCellElement))
			End If
		End Sub

		Private Sub StyleSelectedCell(ByVal cell As SpreadsheetGridRowHeaderCellElement)
			Dim selected As Boolean = False
			Dim current As Boolean = False
			For Each selectedCell As GridViewCellInfo In Me.gridView.SelectedCells
				If cell.RowInfo.Index = selectedCell.RowInfo.Index Then
					If cell.RowInfo Is Me.gridView.CurrentRow Then
						current = True
					Else
						selected = True
					End If
					Exit For
				End If
			Next selectedCell
			If current Then
				cell.NumberOfColors = 2
				cell.BackColor = Color.FromArgb(255, 226, 160)
				cell.BackColor2 = Color.FromArgb(255, 205, 102)
				cell.BorderColor = Color.FromArgb(255, 190, 106)
				cell.BorderInnerColor = Color.FromArgb(255, 245, 162)
			ElseIf selected Then
				cell.NumberOfColors = 1
				cell.BackColor = Color.FromArgb(255, 231, 174)
				cell.BorderColor = Color.FromArgb(209, 225, 245)
				cell.BorderInnerColor = Color.White
			Else
				cell.NumberOfColors = 4
				cell.BackColor = Color.FromArgb(231, 240, 252)
				cell.BackColor2 = Color.FromArgb(218, 233, 251)
				cell.BorderColor = Color.FromArgb(209, 225, 245)
				cell.BorderInnerColor = Color.White
			End If
		End Sub

		Private Sub StyleSelectedCell(ByVal cell As GridHeaderCellElement)
			Dim selected As Boolean = False
			Dim current As Boolean = False
			For Each selectedCell As GridViewCellInfo In Me.gridView.SelectedCells
				If cell.ColumnInfo.Index = selectedCell.ColumnInfo.Index Then
					If cell.ColumnInfo Is Me.gridView.CurrentColumn Then
						current = True
					Else
						selected = True
					End If
					Exit For
				End If
			Next selectedCell
			If current Then
				cell.DrawFill = True
				cell.NumberOfColors = 2
				cell.BackColor = Color.FromArgb(255, 226, 160)
				cell.BackColor2 = Color.FromArgb(255, 205, 102)
				cell.BorderColor = Color.FromArgb(255, 190, 106)
				cell.BorderInnerColor = Color.FromArgb(255, 245, 162)
			ElseIf selected Then
				cell.DrawFill = True
				cell.NumberOfColors = 1
				cell.BackColor = Color.FromArgb(255, 231, 174)
				cell.BorderColor = Color.FromArgb(209, 225, 245)
				cell.BorderInnerColor = Color.White
			Else
				cell.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local)
				cell.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				cell.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
				cell.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
				cell.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local)
				cell.ResetValue(LightVisualElement.BorderInnerColorProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Function IsNumber(ByVal cellValue As Object) As Boolean
			If cellValue Is Nothing Then
				Return False
			End If

			Dim val As String = cellValue.ToString()
			If String.IsNullOrEmpty(val) Then
				Return False
			End If
			For Each item As Char In val
				If (Not Char.IsDigit(item)) AndAlso item <> "$"c AndAlso item <> "."c AndAlso item <> ","c Then
					Return False
				End If
			Next item

			Return True
		End Function

		Private Sub GridView_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridRowHeaderCellElement) AndAlso TypeOf e.Row Is GridDataRowElement Then
				e.CellType = GetType(SpreadsheetGridRowHeaderCellElement)
			End If
		End Sub


		Private Sub radButtonElementBold_Click(ByVal sender As Object, ByVal e As EventArgs)
			For Each cell As GridViewCellInfo In gridView.SelectedCells
				Dim style As GridViewCellStyle = cell.Style
				If style IsNot Nothing Then
					If style.Font IsNot Nothing Then
						If Not style.Font.Bold Then
							style.Font = GetFont(FontStyle.Bold)
						Else
							style.Font = GetFont(FontStyle.Regular)
						End If
					Else
						style.Font = GetFont(FontStyle.Bold)
					End If
				End If
			Next cell
		End Sub

		Private Sub radButtonElementItalic_Click(ByVal sender As Object, ByVal e As EventArgs)
			For Each cell As GridViewCellInfo In gridView.SelectedCells
				Dim style As GridViewCellStyle = cell.Style
				If style IsNot Nothing Then
					If style.Font IsNot Nothing Then
						If Not style.Font.Italic Then
							style.Font = GetFont(FontStyle.Italic)
						Else
							style.Font = GetFont(FontStyle.Regular)
						End If
					Else
						style.Font = GetFont(FontStyle.Italic)
					End If
				End If
			Next cell
		End Sub

		Private Sub radButtonElementUnderline_Click(ByVal sender As Object, ByVal e As EventArgs)
			For Each cell As GridViewCellInfo In gridView.SelectedCells
				Dim style As GridViewCellStyle = cell.Style
				If style IsNot Nothing Then
					If style.Font IsNot Nothing Then
						If Not style.Font.Underline Then
							style.Font = GetFont(FontStyle.Underline)
						Else
							style.Font = GetFont(FontStyle.Regular)
						End If
					Else
						style.Font = GetFont(FontStyle.Underline)
					End If
				End If
			Next cell
		End Sub

		Private Sub radButtonElementColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim radColorDialog As New RadColorDialog()
            DirectCast(radColorDialog.ColorDialogForm, RadForm).ThemeName = Me.CurrentThemeName

			If radColorDialog.ShowDialog() = DialogResult.OK Then
				Dim color As Color = radColorDialog.SelectedColor

				For Each cell As GridViewCellInfo In gridView.SelectedCells
					Dim style As GridViewCellStyle = cell.Style
					If style IsNot Nothing Then
						style.CustomizeFill = True
						style.GradientStyle = GradientStyles.Solid
						style.BackColor = color
					End If
				Next cell
			End If
		End Sub

		Private Sub radButtonElementFontColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim radColorDialog As New RadColorDialog()
            DirectCast(radColorDialog.ColorDialogForm, RadForm).ThemeName = Me.CurrentThemeName

			If radColorDialog.ShowDialog() = DialogResult.OK Then
				Dim color As Color = radColorDialog.SelectedColor

				For Each cell As GridViewCellInfo In gridView.SelectedCells
					Dim style As GridViewCellStyle = cell.Style
					If style IsNot Nothing Then
						style.ForeColor = color
					End If
				Next cell
			End If
		End Sub


		Private Sub radDropDownListElementFont_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If updatingCombos Then
				Return
			End If

			For Each cell As GridViewCellInfo In gridView.SelectedCells
				Dim style As GridViewCellStyle = cell.Style
				If style IsNot Nothing Then
					SetStyle(style)
				End If
			Next cell
		End Sub

		Private Sub radDropDownListElementFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If updatingCombos Then
				Return
			End If

			For Each cell As GridViewCellInfo In gridView.SelectedCells
				Dim style As GridViewCellStyle = cell.Style
				If style IsNot Nothing Then
					SetStyle(style)
				End If
			Next cell
		End Sub

		Private Sub radButtonElementIncrease_Click(ByVal sender As Object, ByVal e As EventArgs)
			If radDropDownListElementFontSize.SelectedItem Is Nothing Then
				Return
			End If

			If radDropDownListElementFontSize.SelectedIndex < radDropDownListElementFontSize.Items.Count - 1 Then
				radDropDownListElementFontSize.SelectedIndex += 1
				radDropDownListElementFontSize_SelectedIndexChanged(Nothing, Nothing)
			End If
		End Sub

		Private Sub radButtonElementDecrease_Click(ByVal sender As Object, ByVal e As EventArgs)
			If radDropDownListElementFontSize.SelectedItem Is Nothing Then
				Return
			End If

			If radDropDownListElementFontSize.SelectedIndex > 0 Then
				radDropDownListElementFontSize.SelectedIndex -= 1
				radDropDownListElementFontSize_SelectedIndexChanged(Nothing, Nothing)
			End If
		End Sub


		Private Sub gridView_CurrentCellChanged(ByVal sender As Object, ByVal e As CurrentCellChangedEventArgs)
			If e.NewCell IsNot Nothing Then
				Dim columnName As String = e.NewCell.ColumnInfo.HeaderText
				Dim rowNumber As String = (e.NewCell.RowInfo.Index + 1).ToString()
				Me.radTextBoxCellNumber.Text = columnName & rowNumber

				If e.NewCell.Value IsNot Nothing Then
					Me.radTextBoxCellContent.Text = e.NewCell.Value.ToString()
				Else
					Me.radTextBoxCellContent.Text = String.Empty
				End If

				Dim style As GridViewCellStyle = e.NewCell.Style
				If style IsNot Nothing Then
					UpdateCombos(style)
				End If
			End If
		End Sub

		Private Sub gridView_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim editor As RadTextBoxEditor = TryCast(sender, RadTextBoxEditor)
			If editor IsNot Nothing Then
				If editor.Value IsNot Nothing Then
					Me.radTextBoxCellContent.Text = editor.Value.ToString()
				Else
					Me.radTextBoxCellContent.Text = String.Empty
				End If
			End If
		End Sub

		Private Sub gridView_RowsChanged(ByVal sender As Object, ByVal e As GridViewCollectionChangedEventArgs)
			Me.gridView.MasterTemplate.Refresh(Me.gridView.Columns(0))
		End Sub

		Private Sub radTextBoxCellContent_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim cell As GridDataCellElement = gridView.CurrentCell
			If cell IsNot Nothing Then
				cell.Value = Me.radTextBoxCellContent.Text
			End If
		End Sub

		#End Region

		#Region "Methods"

		Private Sub SetGridProperties()
			Me.gridView.TableElement.RowHeaderColumnWidth = 42

			Me.gridView.TableElement.CurrentRowHeaderImage = Nothing
			Me.gridView.AllowAddNewRow = False
			Me.gridView.EnableGrouping = False
			Me.gridView.EnableSorting = False
			Me.gridView.EnableFiltering = False

			Me.gridView.ShowRowHeaderColumn = True
			Me.gridView.EnableHotTracking = False

			Me.gridView.RowCount = rowsCount
			Me.gridView.ColumnCount = columnsCount

			Me.gridView.SelectionMode = GridViewSelectionMode.CellSelect
			Me.gridView.MultiSelect = True

			Me.gridView.CurrentRow = Me.gridView.Rows(0)
		End Sub

		Private Sub FillGridWithData()
			Me.InitializeHeaderRow(Me.gridView.Rows(rowBeginIndex - 1))
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex), "John", 500, 50)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 1), "Jim", 550, 55)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 2), "Paul", 750, 75)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 3), "Michael", 2500, 125)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 4), "Tony", 1500, 82)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 5), "Peter", 200, 15)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 6), "Robert", 110, 5)
			Me.InitializeRow(Me.gridView.Rows(rowBeginIndex + 7), "Bill", 710, 35)
		End Sub

		Private Overloads Sub SetStyle(ByVal style As GridViewCellStyle)
			If style.Font IsNot Nothing Then
				If style.Font.Bold Then
					style.Font = GetFont(FontStyle.Bold)
				ElseIf style.Font.Italic Then
					style.Font = GetFont(FontStyle.Italic)
				ElseIf style.Font.Underline Then
					style.Font = GetFont(FontStyle.Underline)
				Else
					style.Font = GetFont(FontStyle.Regular)
				End If
			Else
				style.Font = GetFont(FontStyle.Regular)
			End If
		End Sub

		Private Function GetFont(ByVal fontStyle As FontStyle) As Font
			Dim fontSize As Integer = 8
			Dim fontFamily As String = Me.BaseFont.FontFamily.Name

			If radDropDownListElementFontSize.SelectedItem IsNot Nothing Then
				fontSize = Convert.ToInt16((TryCast(radDropDownListElementFontSize.SelectedItem, RadListDataItem)).Text)
			End If
			If radDropDownListElementFont.SelectedItem IsNot Nothing Then
				fontFamily = Me.radDropDownListElementFont.SelectedText
			End If

			Dim font As New Font(fontFamily, fontSize, fontStyle)
			Return font
		End Function

		Private Sub UpdateCombos(ByVal style As GridViewCellStyle)
			If style.Font Is Nothing Then
				Return
			End If

			updatingCombos = True
			Dim fontFamilyName As String = "Calibri"

			If style.Font.FontFamily IsNot Nothing Then
			End If
			fontFamilyName = style.Font.FontFamily.Name
			For Each item As RadListDataItem In radDropDownListElementFont.Items
				If item.Text = fontFamilyName Then
					radDropDownListElementFont.SelectedItem = item
					Exit For
				End If
			Next item

			Dim fontSize As Single = style.Font.Size
			For Each item As RadListDataItem In radDropDownListElementFontSize.Items
				If Single.Parse(item.Text) = fontSize Then
					radDropDownListElementFontSize.SelectedItem = item
					Exit For
				End If
			Next item

			updatingCombos = False
		End Sub


		Private Sub SetInitialStyles()
			Dim headerRow As GridViewRowInfo = gridView.Rows(rowBeginIndex - 1)
			StyleHeaderCell(headerRow.Cells(gridView.Columns(totalColumnIndex).Name))
			StyleHeaderCell(headerRow.Cells(gridView.Columns(comissionColumnIndex).Name))
			StyleHeaderCell(headerRow.Cells(gridView.Columns(feeColumnIndex).Name))
			StyleHeaderCell(headerRow.Cells(gridView.Columns(clientColumnIndex).Name))

			For i As Integer = rowBeginIndex To rowBeginIndex + 8 - 1
				Dim row As GridViewRowInfo = gridView.Rows(i)
				StyleCell(row.Cells(gridView.Columns(totalColumnIndex).Name))
				StyleCell(row.Cells(gridView.Columns(comissionColumnIndex).Name))
				StyleCell(row.Cells(gridView.Columns(feeColumnIndex).Name))
				StyleCell(row.Cells(gridView.Columns(clientColumnIndex).Name))
			Next i
		End Sub

'INSTANT VB NOTE: The variable font was renamed since Visual Basic does not allow class members with the same name:
		Private font_Renamed As Font = Nothing

		Private Property BaseFont() As Font
			Get
				If Me.font_Renamed IsNot Nothing Then
					Return Me.font_Renamed
				End If

				Try
					Me.font_Renamed = New Font(New FontFamily("Calibri"), 8.0F, FontStyle.Bold)
				Catch e1 As ArgumentException
					Me.font_Renamed = Control.DefaultFont
				End Try

				Return Me.font_Renamed
			End Get
			Set(ByVal value As Font)
				Me.font_Renamed = value
			End Set
		End Property

		Private Sub StyleHeaderCell(ByVal cell As GridViewCellInfo)
			cell.Style.Font = Me.BaseFont
			cell.Style.CustomizeFill = True
			cell.Style.GradientStyle = GradientStyles.Solid
			cell.Style.BackColor = Color.FromArgb(162, 215, 255)
		End Sub

		Private Sub StyleCell(ByVal cell As GridViewCellInfo)
			cell.Style.Font = Me.BaseFont
			cell.Style.CustomizeFill = True
			cell.Style.GradientStyle = GradientStyles.Solid
			cell.Style.BackColor = Color.FromArgb(228, 236, 247)
		End Sub


		Private Sub InitializeHeaderRow(ByVal row As GridViewRowInfo)
			row.Cells(clientColumnIndex).Value = "Client"
			row.Cells(feeColumnIndex).Value = "Fee"
			row.Cells(comissionColumnIndex).Value = "Comission"
			row.Cells(totalColumnIndex).Value = "Total"
		End Sub

		Private Sub InitializeRow(ByVal row As GridViewRowInfo, ByVal client As String, ByVal fee As Decimal, ByVal comission As Decimal)
			row.Cells(clientColumnIndex).Value = client
			row.Cells(feeColumnIndex).Value = String.Format("{0:C}", fee)
			row.Cells(comissionColumnIndex).Value = String.Format("{0:C}", comission)
			row.Cells(totalColumnIndex).Value = String.Format("{0:C}", fee + comission)
		End Sub

        Private Function GetColumnName(columnIndex As Integer) As String
            Dim result As New StringBuilder()
            Dim cycle As Integer = columnIndex + 1

            While cycle > 0
                Dim letterIndex As Integer = cycle Mod alphabetLength
                If letterIndex = 0 Then
                    letterIndex = alphabetLength
                    cycle -= 1
                End If
                result.Insert(0, ChrW(AscW("A"c) + letterIndex - 1))
                cycle \= alphabetLength
            End While
            Return result.ToString()
        End Function

		#End Region

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
