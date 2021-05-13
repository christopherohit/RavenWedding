Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.GridView.PopulateWithData.UnboundMode
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private Const InitialRowsNum As Integer = 5
		Private bitmaps As New List(Of Bitmap)()

		Private columnNum As Integer
		Private columnTypes() As String = { "Text", "NumericText", "Decimal", "DateTime", "Image", "ComboBox", "Command", "CheckBox" }
		Private comboItems() As String = { "Sales Representative", "Owner", "Order Administrator", "Accounting Manager", "Sales Manger" }
		#End Region

		Public Sub New()
			InitializeComponent()
			Me.radGridView1.MasterTemplate.EnableSorting = True
			Me.radGridView1.TableElement.RowHeight = 35

            Dim bmp As New Bitmap(My.Resources.msoffice_menu_blog)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

            bmp = New Bitmap(My.Resources.msoffice_menu_digitalsignature)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

            bmp = New Bitmap(My.Resources.msoffice_menu_documentworkspace)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

            bmp = New Bitmap(My.Resources.msoffice_menu_encryptdocument)
			bmp.MakeTransparent(Color.Magenta)
			bitmaps.Add(bmp)

			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
			For i As Integer = 0 To bitmaps.Count - 1
				bitmaps(i).Dispose()
			Next i

			bitmaps.Clear()

			MyBase.OnHandleDestroyed(e)
		End Sub

		Private Sub InitializeGrid()
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.EnableGrouping = False

			For i As Integer = 0 To Me.columnTypes.Length - 1
				AppendNewColumn(Me.columnTypes(i), False)
			Next i

			Dim [date] As Date = Date.Now
			'add new unbound rows solution I
			Dim rowInfo As GridViewRowInfo = Me.radGridView1.Rows.AddNew()
			rowInfo.Cells(0).Value = "Maria Anders"
			rowInfo.Cells(1).Value = 1000
			rowInfo.Cells(2).Value = 10000.01f
			rowInfo.Cells(3).Value = [date].AddDays(1)
			rowInfo.Cells(4).Value = bitmaps(0)
			rowInfo.Cells(5).Value = "Sales Representative"
			rowInfo.Cells(6).Value = "Command Button 1"
			rowInfo.Cells(7).Value = True

			rowInfo = Me.radGridView1.Rows.AddNew()
			rowInfo.Cells(0).Value = "Hanna Moos"
			rowInfo.Cells(1).Value = 2000
			rowInfo.Cells(2).Value = 20000.02f
			rowInfo.Cells(3).Value = [date].AddDays(2)
			rowInfo.Cells(4).Value = bitmaps(1)
			rowInfo.Cells(5).Value = "Owner"
			rowInfo.Cells(6).Value = "Command Button 2"
			rowInfo.Cells(7).Value = False

			'add new unbound rows solution II
			Me.radGridView1.Rows.Add("Roland Mendel", 3000, 30000.03f, [date].AddDays(3), bitmaps(2), "Order Administrator", "Command Button 3", True)
			Me.radGridView1.Rows.Add("Diego Roel", 4000, 40000.04f, [date].AddDays(4), bitmaps(3), "Accounting Manager", "Command Button 4", False)
			Me.radGridView1.Rows.Add("Janine Labrune", 5000, 50000.05f, [date].AddDays(5), bitmaps(0), "Sales Manger", "Command Button 5", True)

			Me.radGridView1.MasterTemplate.BestFitColumns()

			Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radComboBox1.DataSource = Me.columnTypes
			Me.radComboBox1.SelectedIndex = 0
			InitializeGrid()
			Me.LoadColumnsComboBox()
			AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit
		End Sub

		Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
			If Me.radGridView1.ActiveEditor IsNot Nothing Then
				If TypeOf Me.radGridView1.ActiveEditor Is RadDropDownListEditor Then
					Dim comboboxEditor As RadDropDownListEditor = TryCast(Me.radGridView1.ActiveEditor, RadDropDownListEditor)
					comboboxEditor.EditorElement.Alignment = ContentAlignment.MiddleCenter
					comboboxEditor.EditorElement.StretchVertically = False
					Me.radGridView1.CurrentCell.Alignment = ContentAlignment.MiddleCenter
				ElseIf TypeOf Me.radGridView1.ActiveEditor Is RadDateTimeEditor Then
					Dim comboboxEditor As RadDateTimeEditor = TryCast(Me.radGridView1.ActiveEditor, RadDateTimeEditor)
					comboboxEditor.EditorElement.Alignment = ContentAlignment.MiddleCenter
					comboboxEditor.EditorElement.StretchVertically = False
					Me.radGridView1.CurrentCell.Alignment = ContentAlignment.MiddleCenter
				End If
			End If
		End Sub

		Private Sub LoadColumnsComboBox()
			Me.radComboColumnsRemove.Items.Clear()
			For Each column As GridViewDataColumn In Me.radGridView1.Columns
				Dim comboItem As New RadListDataItem(column.HeaderText)
				comboItem.Tag = column
				Me.radComboColumnsRemove.Items.Add(comboItem)
			Next column

			Me.radComboColumnsRemove.SelectedIndex = Me.radComboColumnsRemove.Items.Count - 1
		End Sub

		#Region "Event Handlers"
		Private Sub btnAddColumn_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim col As GridViewDataColumn = AppendNewColumn(Me.radComboBox1.SelectedItem.Text, True)
			Me.LoadColumnsComboBox()
		End Sub

		Private Sub btnRemoveColumn_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radGridView1.Columns.Count = 0 Then
				Return
			End If

			Dim selectedColumn As GridViewDataColumn = TryCast(Me.radComboColumnsRemove.SelectedItem.Tag, GridViewDataColumn)
			Me.radGridView1.Columns.Remove(selectedColumn)
			Me.LoadColumnsComboBox()
		End Sub

		Private Sub btnAddRow_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.Rows.Add(Nothing, Nothing)
		End Sub

		Private Sub btnRemoveSelectedRows_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedRows(Me.radGridView1.SelectedRows.Count - 1) As GridViewRowInfo
			Me.radGridView1.SelectedRows.CopyTo(selectedRows, 0)

			Me.radGridView1.TableElement.BeginUpdate()
			For i As Integer = 0 To selectedRows.Length - 1
				Me.radGridView1.Rows.Remove(TryCast(selectedRows(i), GridViewDataRowInfo))
			Next i
			Me.radGridView1.TableElement.EndUpdate()
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radGridView1.MasterTemplate.AllowAddNewRow = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radGridView1_RowsChanging(ByVal sender As Object, ByVal e As GridViewCollectionChangingEventArgs)
			Console.WriteLine("Rows changing action:{0}", e.Action)
		End Sub

		Private Sub radGridView1_RowsChanged(ByVal sender As Object, ByVal e As GridViewCollectionChangedEventArgs)
			Console.WriteLine("Rows changed action:{0}", e.Action)
		End Sub

		#End Region ' Event Handlers

		Private Function AppendNewColumn(ByVal columnType As String, ByVal numberInTheHeader As Boolean) As GridViewDataColumn
			Dim newColumn As GridViewDataColumn = Nothing
			Select Case columnType
				Case "Text"
					newColumn = New GridViewTextBoxColumn()
					newColumn.FieldName = "Text"
				Case "NumericText"
					newColumn = New GridViewMaskBoxColumn()
					CType(newColumn, GridViewMaskBoxColumn).Mask = "f"
					newColumn.TextAlignment = ContentAlignment.MiddleLeft
					newColumn.FieldName = "NumericText"
				Case "Decimal"
					newColumn = New GridViewDecimalColumn()
					newColumn.TextAlignment = ContentAlignment.MiddleRight
					newColumn.FieldName = "Decimal"
				Case "DateTime"
					newColumn = New GridViewDateTimeColumn()
					newColumn.FormatString = "{0:MM-dd-yyyy}"
					newColumn.TextAlignment = ContentAlignment.MiddleRight
					newColumn.FieldName = "DateTime"
				Case "Image"
					newColumn = New GridViewImageColumn()
					CType(newColumn, GridViewImageColumn).ImageLayout = ImageLayout.Center
					newColumn.Width = 40
					newColumn.FieldName = "Image"
				Case "ComboBox"
					newColumn = New GridViewComboBoxColumn()
					CType(newColumn, GridViewComboBoxColumn).DataSource = Me.comboItems
					newColumn.Width = 100
					newColumn.FieldName = "ComboBox"
				Case "Command"
					newColumn = New GridViewCommandColumn()
					CType(newColumn, GridViewCommandColumn).TextAlignment = ContentAlignment.MiddleCenter
					newColumn.FieldName = "Command"
				Case "CheckBox"
					newColumn = New GridViewCheckBoxColumn()
					newColumn.Width = 50
					newColumn.FieldName = "CheckBox"
			End Select

			If numberInTheHeader Then
				newColumn.HeaderText = (Me.columnNum).ToString() & " - " & columnType
				Me.columnNum += 1
			Else
				newColumn.HeaderText = columnType
			End If

			Me.radGridView1.Columns.Add(newColumn)
			Return newColumn
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.RowsChanging, AddressOf radGridView1_RowsChanging
			AddHandler radGridView1.RowsChanged, AddressOf radGridView1_RowsChanged
			AddHandler radBtnRmRows.Click, AddressOf btnRemoveSelectedRows_Click
			AddHandler radBtnAddRow.Click, AddressOf btnAddRow_Click
			AddHandler radBtnRmCol.Click, AddressOf btnRemoveColumn_Click
			AddHandler radBtnAddCol.Click, AddressOf btnAddColumn_Click
			AddHandler radCheckShowNewRow.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
		End Sub
	End Class
End Namespace