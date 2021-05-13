Imports System.IO
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.ViewModels

Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.Settings
	Partial Public Class Form1
		Inherits ExamplesForm
		Private pivot As RadPivotGrid

		Private suspendEvents As Boolean = False
		Private orders As New List(Of Order2)()
		Private provider As LocalDataSourceProvider

		Public Sub New()

			Me.pivot = New RadPivotGrid()
			Me.pivot.Dock = DockStyle.Fill
			Me.Controls.Add(Me.pivot)

			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			 Me.LoadData()

			Me.provider = New LocalDataSourceProvider() With {.ItemsSource = orders}

			provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Product", .GroupComparer = New GroupNameComparer(), .SortOrder = Telerik.Pivot.Core.SortOrder.Descending})
			provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Promotion", .GroupComparer = New GroupNameComparer()})

			provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Advertisement", .GroupComparer = New GroupNameComparer()})
			provider.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "Date", .Step = DateTimeStep.Month})

			provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity", .AggregateFunction = AggregateFunctions.Sum})
			provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Net", .AggregateFunction = AggregateFunctions.Sum})

			provider.AggregatesPosition = PivotAxis.Rows
			provider.AggregatesLevel = 2

			Me.pivot.ColumnGrandTotalsPosition = TotalsPos.First
			Me.pivot.ColumnsSubTotalsPosition = TotalsPos.First

			Me.pivot.RowGrandTotalsPosition = TotalsPos.Last
			Me.pivot.RowsSubTotalsPosition = TotalsPos.First
			AddHandler pivot.PivotGridElement.UpdateCompleted, AddressOf pivotGridElement_DataUpdated
			Me.pivot.PivotGridElement.DataProvider = provider
		End Sub

		Private Sub RowGrandTotalChecked(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If Me.suspendEvents Then
				Return
			End If

			If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
				Me.pivot.RowGrandTotalsPosition = GetPosition(sender)
			End If
		End Sub

		Private Sub RowSubTotalChecked(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If Me.suspendEvents Then
				Return
			End If

			If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
				Me.pivot.RowsSubTotalsPosition = GetPosition(sender)
			End If
		End Sub

		Private Sub ColumnGrandTotalChecked(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If Me.suspendEvents Then
				Return
			End If

			If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
				Me.pivot.ColumnGrandTotalsPosition = GetPosition(sender)
			End If
		End Sub

		Private Sub ColumnSubTotalChecked(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If Me.suspendEvents Then
				Return
			End If

			If pivot IsNot Nothing AndAlso sender IsNot Nothing Then
				Me.pivot.ColumnsSubTotalsPosition = GetPosition(sender)
			End If
		End Sub

		Private Sub AggregatesPositionChecked(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.suspendEvents Then
				Return
			End If

			Me.provider.AggregatesPosition = If(sender Is Me.aggregatePositionRows, PivotAxis.Rows, PivotAxis.Columns)
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.suspendEvents Then
				Return
			End If

			If Me.pivot IsNot Nothing Then
				provider.AggregatesLevel = CInt(Fix(Me.radSpinEditor1.Value))
			End If
		End Sub

		Private Function GetPosition(ByVal sender As Object) As TotalsPos
			If sender Is Me.rowGrandTotalFirst OrElse sender Is Me.columnGrandTotalFirst OrElse sender Is Me.rowSubTotalFirst OrElse sender Is Me.columnSubTotalFirst Then
				Return TotalsPos.First
			End If

			If sender Is Me.rowGrandTotalLast OrElse sender Is Me.columnGrandTotalLast OrElse sender Is Me.rowSubTotalLast OrElse sender Is Me.columnSubTotalLast Then
				Return TotalsPos.Last
			End If

			Return TotalsPos.None
		End Function

		Private Sub pivotGridElement_DataUpdated(ByVal sender As Object, ByVal e As EventArgs)
			Me.Invoke(New MethodInvoker(Sub()
				Me.suspendEvents = True
				Select Case Me.pivot.RowGrandTotalsPosition
					Case TotalsPos.First
						Me.rowGrandTotalFirst.IsChecked = True
						Case TotalsPos.Last
							Me.rowGrandTotalLast.IsChecked = True
							Case TotalsPos.None
								Me.rowGrandTotalNone.IsChecked = True
				End Select
				Select Case Me.pivot.ColumnGrandTotalsPosition
					Case TotalsPos.First
						Me.columnGrandTotalFirst.IsChecked = True
						Case TotalsPos.Last
							Me.columnGrandTotalLast.IsChecked = True
							Case TotalsPos.None
								Me.columnGrandTotalNone.IsChecked = True
				End Select
				Select Case Me.pivot.RowsSubTotalsPosition
					Case TotalsPos.First
						Me.rowSubTotalFirst.IsChecked = True
						Case TotalsPos.Last
							Me.rowSubTotalLast.IsChecked = True
							Case TotalsPos.None
								Me.rowSubTotalNone.IsChecked = True
				End Select
				Select Case Me.pivot.ColumnsSubTotalsPosition
					Case TotalsPos.First
						Me.columnSubTotalFirst.IsChecked = True
						Case TotalsPos.Last
							Me.columnSubTotalLast.IsChecked = True
							Case TotalsPos.None
								Me.columnSubTotalNone.IsChecked = True
				End Select
				Select Case Me.provider.AggregatesPosition
					Case PivotAxis.Columns
						Me.aggregatePositionColumns.IsChecked = True
						Case PivotAxis.Rows
							Me.aggregatePositionRows.IsChecked = True
				End Select
				Me.radSpinEditor1.Value = Me.provider.AggregatesLevel
				Me.suspendEvents = False
			End Sub))
		End Sub

		Private Sub LoadData()
			Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.GetType()).GetManifestResourceStream("PivotData.txt")

			Using streamReader As New StreamReader(stream)
				Do While streamReader.Peek() <> -1
					Dim items() As String = streamReader.ReadLine().Split(ControlChars.Tab)
					Dim o As New Order2() With {.Date = Date.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), .Product = items(1), .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), .Promotion = items(4), .Advertisement = items(5)}
					orders.Add(o)
				Loop
			End Using
		End Sub


		Protected Overrides Sub WireEvents()
			AddHandler rowGrandTotalNone.ToggleStateChanged, AddressOf RowGrandTotalChecked
			AddHandler rowGrandTotalLast.ToggleStateChanged, AddressOf RowGrandTotalChecked
			AddHandler rowGrandTotalFirst.ToggleStateChanged, AddressOf RowGrandTotalChecked
			AddHandler rowSubTotalNone.ToggleStateChanged, AddressOf RowSubTotalChecked
			AddHandler rowSubTotalLast.ToggleStateChanged, AddressOf RowSubTotalChecked
			AddHandler rowSubTotalFirst.ToggleStateChanged, AddressOf RowSubTotalChecked
			AddHandler columnGrandTotalNone.ToggleStateChanged, AddressOf ColumnGrandTotalChecked
			AddHandler columnGrandTotalLast.ToggleStateChanged, AddressOf ColumnGrandTotalChecked
			AddHandler columnGrandTotalFirst.ToggleStateChanged, AddressOf ColumnGrandTotalChecked
			AddHandler columnSubTotalNone.ToggleStateChanged, AddressOf ColumnSubTotalChecked
			AddHandler columnSubTotalLast.ToggleStateChanged, AddressOf ColumnSubTotalChecked
			AddHandler columnSubTotalFirst.ToggleStateChanged, AddressOf ColumnSubTotalChecked
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler aggregatePositionColumns.ToggleStateChanged, AddressOf AggregatesPositionChecked
			AddHandler aggregatePositionRows.ToggleStateChanged, AddressOf AggregatesPositionChecked
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Dim s As String = "default.xml"
			Dim dialog As New SaveFileDialog()
			dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
			dialog.Title = "Select a xml file"
			If dialog.ShowDialog() = DialogResult.OK Then
				s = dialog.FileName
			End If

			Me.pivot.SaveLayout(s)
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Dim s As String = "default.xml"
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
			dialog.Title = "Select a xml file"
			If dialog.ShowDialog() = DialogResult.OK Then
				s = dialog.FileName
			End If

			Me.pivot.LoadLayout(s)
		End Sub
	End Class
End Namespace
