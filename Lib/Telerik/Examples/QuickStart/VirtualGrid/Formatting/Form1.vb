Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Formatting
	Public Partial Class Form1
		Inherits ExamplesForm
		Private timer As Timer = New Timer()
		Private rnd As Random = New Random()
		Private stocks As DataTable = New DataTable()
		Private changes As Dictionary(Of Integer, Boolean) = New Dictionary(Of Integer, Boolean)()
		Private changeDuration As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)()
		Private secondsToKeepChangesVisible As Integer = 4

		Public Sub New()
			InitializeComponent()

			Me.PrepareData()

			Me.radVirtualGrid1.ColumnCount = Me.stocks.Columns.Count
			Me.radVirtualGrid1.RowCount = Me.stocks.Rows.Count

			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.TableElement.ColumnWidth = 150

			AddHandler Me.radVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded
			AddHandler Me.radVirtualGrid1.CellFormatting, AddressOf radVirtualGrid1_CellFormatting
			AddHandler Me.radVirtualGrid1.RowFormatting, AddressOf radVirtualGrid1_RowFormatting
			AddHandler Me.radVirtualGrid1.EditorRequired, AddressOf radVirtualGrid1_EditorRequired

			timer.Interval = 1000
			timer.Start()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler timer.Tick, AddressOf timer_Tick
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radVirtualGrid1.BeginUpdate()
			Dim numberOfchanges As Integer = Me.rnd.Next(0, 3)

			Dim changesToRemove As List(Of Integer) = New List(Of Integer)()
			Dim changesToIncrement As List(Of Integer) = New List(Of Integer)()

			For Each pair As KeyValuePair(Of Integer, Integer) In Me.changeDuration
				If pair.Value = Me.secondsToKeepChangesVisible Then
					changesToRemove.Add(pair.Key)
				Else
					changesToIncrement.Add(pair.Key)
				End If
			Next pair

			For Each index As Integer In changesToRemove
				Me.changeDuration.Remove(index)
				Me.changes.Remove(index)
			Next index

			For Each index As Integer In changesToIncrement
				Me.changeDuration(index) += 1
			Next index

			Dim i As Integer = 0
			Do While i < numberOfchanges
				Dim stockIndex As Integer = Me.rnd.Next(0, Me.stocks.Rows.Count)

				Dim price As Double = CDbl(Me.stocks.Rows(stockIndex)("Price"))
				Dim change As Double = CDbl(Me.stocks.Rows(stockIndex)("Change"))
				Dim delta As Double = (Me.rnd.NextDouble() - 0.5R) * Me.rnd.Next(1, 4)
				Dim open As Double = CDbl(Me.stocks.Rows(stockIndex)("Open"))

				price += delta

				Me.stocks.Rows(stockIndex)("Price") = price
				Me.stocks.Rows(stockIndex)("Change") = change + delta
				Me.stocks.Rows(stockIndex)("Percentage") = change / open / 100R

				If changes.ContainsKey(stockIndex) Then
					Me.changes(stockIndex) = delta > 0R
				Else
					Me.changes.Add(stockIndex, delta > 0R)
				End If

				If Me.changeDuration.ContainsKey(stockIndex) Then
					Me.changeDuration(stockIndex) = 0
				Else
					Me.changeDuration.Add(stockIndex, 0)
				End If
				i += 1
			Loop

			Me.radVirtualGrid1.EndUpdate()
			Me.radVirtualGrid1.VirtualGridElement.TableElement.SynchronizeRows()
		End Sub

		Private Sub PrepareData()
			Me.stocks.Columns.Add("Symbol")
			Me.stocks.Columns.Add("Price", GetType(Double))
			Me.stocks.Columns.Add("Open", GetType(Double))
			Me.stocks.Columns.Add("High", GetType(Double))
			Me.stocks.Columns.Add("Low", GetType(Double))
			Me.stocks.Columns.Add("Change", GetType(Double))
			Me.stocks.Columns.Add("Percentage", GetType(Double))

			For i As Integer = 0 To 19
                Dim symbol As String = "" & ChrW(65 + Me.rnd.Next(25)) + ChrW(65 + Me.rnd.Next(25)) + ChrW(65 + Me.rnd.Next(25)) + ChrW(65 + Me.rnd.Next(25))
				Dim price As Double = Me.rnd.Next(100, 600) + (Me.rnd.NextDouble() - 0.5R)
				Dim low As Double = CDbl(Me.rnd.Next(80, 95)) / 100R * price
				Dim high As Double = CDbl(Me.rnd.Next(105, 120)) / 100R * price
				Dim open As Double = Me.rnd.Next(CInt(Fix(low + 2R)), CInt(Fix(high - 2R))) + Me.rnd.NextDouble()
				Dim change As Double = price - open
				Dim percentage As Double = change / open / 100R

				Me.stocks.Rows.Add(symbol, price, open, high, low, change, percentage)
			Next i
		End Sub

		Private Sub radVirtualGrid1_EditorRequired(ByVal sender As Object, ByVal e As VirtualGridEditorRequiredEventArgs)
			e.Cancel = True
		End Sub

		Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs)
			If e.CellElement.RowIndex < 0 OrElse e.CellElement.ColumnIndex < 0 Then
				Return
			End If

			Dim columnName As String = Me.stocks.Columns(e.CellElement.ColumnIndex).ColumnName

			Select Case columnName
				Case "Symbol"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
				Case "Price", "Open", "High", "Low", "Close"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
					e.CellElement.Text = String.Format("{0:F2}", Double.Parse(Convert.ToString(e.CellElement.Value)))
				Case "Change"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
					Dim value As Double = Double.Parse(Convert.ToString(e.CellElement.Value))
					Dim raising As Boolean = value >= 0
					If raising Then
                        e.CellElement.Text = String.Format("{0:F2} " & ("▲"), value)
					Else
                        e.CellElement.Text = String.Format("{0:F2} " & ("▼"), value)
					End If

					If Me.changeDuration.ContainsKey(e.CellElement.RowIndex) AndAlso Me.changeDuration(e.CellElement.RowIndex) < 2 Then
						e.CellElement.BorderWidth = 2
						e.CellElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
						e.CellElement.ZIndex = 5

						If Me.changes(e.CellElement.RowIndex) Then
							e.CellElement.BorderColor = Color.FromArgb(250, Color.Green)
						Else
							e.CellElement.BorderColor = Color.FromArgb(250, Color.Red)
						End If
					Else
						e.CellElement.ResetValue(LightVisualElement.BorderColorProperty, Telerik.WinControls.ValueResetFlags.Local)
						e.CellElement.ResetValue(LightVisualElement.BorderWidthProperty, Telerik.WinControls.ValueResetFlags.Local)
						e.CellElement.ResetValue(LightVisualElement.BorderBoxStyleProperty, Telerik.WinControls.ValueResetFlags.Local)
						e.CellElement.ResetValue(LightVisualElement.ZIndexProperty, Telerik.WinControls.ValueResetFlags.Local)
					End If

				Case "Percentage"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
					e.CellElement.Text = String.Format("{0:P2}", Double.Parse(Convert.ToString(e.CellElement.Value)))

			End Select
		End Sub

		Private Sub radVirtualGrid1_RowFormatting(ByVal sender As Object, ByVal e As VirtualGridRowElementEventArgs)
			If e.RowElement.RowIndex < 0 Then
				Return
			End If

			If Me.changeDuration.ContainsKey(e.RowElement.RowIndex) Then
				e.RowElement.DrawFill = True
				e.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid

				If Me.changes(e.RowElement.RowIndex) Then
					e.RowElement.BackColor = Color.FromArgb(50, Color.Green)
				Else
					e.RowElement.BackColor = Color.FromArgb(50, Color.Red)
				End If
			Else
				e.RowElement.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
				e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
				e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, Telerik.WinControls.ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As VirtualGridCellValueNeededEventArgs)
			If e.ColumnIndex < 0 Then
				Return
			End If

			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = Me.stocks.Columns(e.ColumnIndex).ColumnName
			End If

			If e.RowIndex < 0 Then
				Return
			End If

			e.FieldName = Me.stocks.Columns(e.ColumnIndex).ColumnName
			e.Value = Me.stocks.Rows(e.RowIndex)(e.FieldName)
		End Sub
	End Class
End Namespace
