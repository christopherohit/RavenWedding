Imports System.IO
Imports Telerik.Pivot.Core

Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.LayoutTypes
	Partial Public Class Form1
		Inherits ExamplesForm
		Private radPivotGrid1 As RadPivotGrid


		Public Sub New()
			Me.radPivotGrid1 = New RadPivotGrid()
			Me.radPivotGrid1.Dock = DockStyle.Fill
			Me.Controls.Add(Me.radPivotGrid1)

			Me.InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radPivotGrid1.PivotGridElement.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "OrderDate", .Step = DateTimeStep.Year, .GroupComparer = New GroupNameComparer()})

			Me.radPivotGrid1.PivotGridElement.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "ShipCountry", .GroupComparer = New GrandTotalComparer(), .SortOrder = Pivot.Core.SortOrder.Descending})
			Me.radPivotGrid1.PivotGridElement.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "FirstName", .GroupComparer = New GrandTotalComparer(), .SortOrder = Pivot.Core.SortOrder.Ascending})

			Me.radPivotGrid1.PivotGridElement.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity", .AggregateFunction = AggregateFunctions.Sum})
			Me.radPivotGrid1.PivotGridElement.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "UnitPrice", .AggregateFunction = AggregateFunctions.Max})

			Dim dataset As NorthwindDataSet = New DataSources.NorthwindDataSet()

			Dim adapter As New OrdersViewTableAdapter()

			adapter.Fill(dataset.OrdersView)
			Me.radPivotGrid1.AggregatesPosition = PivotAxis.Columns
			Me.radPivotGrid1.PivotGridElement.DataSource = dataset.OrdersView
		End Sub


		Private Sub radioTabularHeader_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				If sender Is Me.radioTabularColumnHeader Then
					Me.radPivotGrid1.PivotGridElement.ColumnHeadersLayout = PivotLayout.Tabular
				Else
					Me.radPivotGrid1.PivotGridElement.RowHeadersLayout = PivotLayout.Tabular
				End If
			End If
		End Sub

		Private Sub radioCompactHeader_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				If sender Is Me.radioCompactColumnHeader Then
					Me.radPivotGrid1.PivotGridElement.ColumnHeadersLayout = PivotLayout.Compact
				Else
					Me.radPivotGrid1.PivotGridElement.RowHeadersLayout = PivotLayout.Compact
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radioCompactColumnHeader.ToggleStateChanged, AddressOf radioCompactHeader_ToggleStateChanged
			AddHandler radioTabularColumnHeader.ToggleStateChanged, AddressOf radioTabularHeader_ToggleStateChanged
			AddHandler radioCompactRowHeader.ToggleStateChanged, AddressOf radioCompactHeader_ToggleStateChanged
			AddHandler radioTabularRowHeader.ToggleStateChanged, AddressOf radioTabularHeader_ToggleStateChanged
		End Sub
	End Class
End Namespace
