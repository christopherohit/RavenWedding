Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Grouping.GroupSummaries
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.radGridViewDemo.EnableHotTracking = True
			Me.SelectedControl = Me.radGridViewDemo
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			AddHandler radGridViewDemo.ViewCellFormatting, AddressOf radGridView1_ViewCellFormatting
			AddHandler radGridViewDemo.CellFormatting, AddressOf radGridView1_CellFormatting
			Me.radGridViewDemo.TableElement.BeginUpdate()

			Me.ordersTableAdapter.Fill(Me.nwindDataSetGridView.Orders)

			Me.radGridViewDemo.Columns("Freight").FormatString = "{0:F2}"

			Me.LoadFreightSummary()

			Me.radGridViewDemo.TableElement.EndUpdate()

			InitComboBoxes()

			MyBase.OnLoad(e)
		End Sub

		Private Sub InitComboBoxes()
			Me.radComboFunction.DataSource = System.Enum.GetValues(GetType(GridAggregateFunction))
			Dim columns As New List(Of String)()

			For i As Integer = 1 To radGridViewDemo.MasterTemplate.Columns.Count - 1
				columns.Add(radGridViewDemo.MasterTemplate.Columns(i).FieldName)
			Next i
			Me.radComboColumn.DataSource = columns

			Me.radComboFunction.SelectedIndex = 1
			Me.radComboPosition.SelectedIndex = 0
			Me.radComboBox3.SelectedIndex = 0
			Me.radComboColumn.SelectedIndex = 2
		End Sub

		Private Shared Sub RebuildComboBoxItems(ByVal comboBox As RadDropDownList, ByVal count As Integer)
			comboBox.BeginUpdate()

			comboBox.Items.Clear()

			For i As Integer = 0 To count - 1
				comboBox.Items.Add(New RadListDataItem(String.Format("Row {0}", i + 1)))
			Next i

			comboBox.Items.Add(New RadListDataItem("New Row"))

			comboBox.SelectedIndex = count - 1

			comboBox.EndUpdate()
		End Sub

		Private Shared Function CollectionItem(ByVal collection As GridViewSummaryRowItemCollection, ByVal rowIndex As Integer, <System.Runtime.InteropServices.Out()> ByRef updated As Boolean) As GridViewSummaryRowItem
			updated = False
			If collection Is Nothing OrElse rowIndex < 0 Then
				Return Nothing
			End If

			Do While rowIndex >= collection.Count
				updated = True
				collection.Add(New GridViewSummaryRowItem())
			Loop

			Return collection(rowIndex)
		End Function

		#Region "Event handling"

		Private Sub radGridView1_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.CellElement Is GridSummaryCellElement Then
				e.CellElement.DrawBorder = True
				e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
				e.CellElement.BorderLeftWidth = 0
				e.CellElement.BorderRightWidth = 0
				e.CellElement.BorderBottomWidth = 0
				e.CellElement.BorderTopWidth = 1
				e.CellElement.BorderTopColor = Color.Black
				e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
			End If
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.CellElement Is GridDateTimeCellElement Then
				Dim dateTimeCell As GridDateTimeCellElement = TryCast(e.CellElement, GridDateTimeCellElement)
				e.CellElement.Text = String.Format("{0:ddd, MM/dd}", dateTimeCell.Value)
			End If
		End Sub

		Private Sub radComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Select Case Me.radComboPosition.SelectedIndex
				Case 0
					Me.radComboBox3.Enabled = False
				Case 1
					RebuildComboBoxItems(radComboBox3, Me.radGridViewDemo.MasterTemplate.SummaryRowsTop.Count)
					Me.radComboBox3.Enabled = True
				Case 2
					RebuildComboBoxItems(radComboBox3, Me.radGridViewDemo.MasterTemplate.SummaryRowsBottom.Count)
					Me.radComboBox3.Enabled = True
			End Select
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As GridViewSummaryRowItem = Nothing
			Dim formatString As String = String.Empty
			Dim updated As Boolean = False

			Select Case Me.radComboPosition.SelectedIndex
				Case 0
					item = CollectionItem(Me.radGridViewDemo.MasterTemplate.SummaryRowGroupHeaders, 0, updated)

					formatString = String.Format("{2} of {0}: {1}; ", radComboColumn.SelectedItem.Text, "{0}", CType(radComboFunction.SelectedIndex, GridAggregateFunction))

				Case 1
					item = CollectionItem(Me.radGridViewDemo.MasterTemplate.SummaryRowsTop, Me.radComboBox3.SelectedIndex, updated)

					If updated Then
						RebuildComboBoxItems(Me.radComboBox3, Me.radGridViewDemo.MasterTemplate.SummaryRowsTop.Count)
					End If

					formatString = String.Format("{0}: {1}; ", CType(radComboFunction.SelectedIndex, GridAggregateFunction), "{0}")

				Case 2
					item = CollectionItem(Me.radGridViewDemo.MasterTemplate.SummaryRowsBottom, Me.radComboBox3.SelectedIndex, updated)

					If updated Then
						RebuildComboBoxItems(Me.radComboBox3, Me.radGridViewDemo.MasterTemplate.SummaryRowsBottom.Count)
					End If

					formatString = String.Format("{0}: {1}; ", CType(radComboFunction.SelectedIndex, GridAggregateFunction), "{0}")
			End Select

			If item Is Nothing Then
				Return
			End If

			Dim fieldName As String = radComboColumn.SelectedItem.Text

			item.Add(New GridViewSummaryItem(fieldName, formatString, CType(radComboFunction.SelectedIndex, GridAggregateFunction)))
		End Sub

		#End Region

		Private Sub LoadFreightSummary()
			Me.radGridViewDemo.MasterTemplate.AutoExpandGroups = True
			Me.radGridViewDemo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

			Me.radGridViewDemo.GroupDescriptors.Clear()
			Me.radGridViewDemo.GroupDescriptors.Add(New GridGroupByExpression("CustomerID Group By CustomerID"))

			Dim item1 As New GridViewSummaryRowItem()

			item1.Add(New GridViewSummaryItem("Freight", "Sum: {0:F2}; ", GridAggregateFunction.Sum))

			Me.radGridViewDemo.MasterTemplate.SummaryRowsBottom.Add(item1)

			Dim item2 As New GridViewSummaryRowItem()

			item2.Add(New GridViewSummaryItem("Freight", "Min: {0:F2}", GridAggregateFunction.Min))
			Me.radGridViewDemo.MasterTemplate.SummaryRowsTop.Add(item2)
		End Sub

		Private Sub radCheckBoxPinRow_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If radCheckBoxPinRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radGridViewDemo.MasterTemplate.ShowTotals = True
			Else
				radGridViewDemo.MasterTemplate.ShowTotals = False
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radComboPosition.SelectedIndexChanged, AddressOf radComboBox2_SelectedIndexChanged
			AddHandler radButtonAddSummary.Click, AddressOf radButton1_Click
			AddHandler radCheckBoxPinRow.ToggleStateChanged, AddressOf radCheckBoxPinRow_ToggleStateChanged
		End Sub
	End Class
End Namespace
