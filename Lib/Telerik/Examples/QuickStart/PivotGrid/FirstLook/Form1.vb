Imports Telerik.Pivot.Core
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Pivot.Core.Aggregates
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PivotGrid.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm
        Private radPivotGrid1 As RadPivotGrid

        Public Sub New()
            Me.radPivotGrid1 = New RadPivotGrid()
            Me.radPivotGrid1.Dock = DockStyle.Fill
            Me.radPivotGrid1.PivotGridElement.ShowFilterArea = True
            Me.radPivotGrid1.PivotGridElement.FilterAreaHeight = 45
            Me.Controls.Add(Me.radPivotGrid1)

            InitializeComponent()

            Me.FillWithData()
        End Sub
        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                Me.radPivotGrid1.PivotGridElement.FilterAreaHeight = 72
            Else
                Me.radPivotGrid1.PivotGridElement.FilterAreaHeight = 42
            End If
        End Sub
        Private Sub FillWithData()
            Me.radPivotGrid1.RowGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "OrderDate", .Step = DateTimeStep.Year, .GroupComparer = New GroupNameComparer()})
            Me.radPivotGrid1.RowGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "OrderDate", .Step = DateTimeStep.Quarter, .GroupComparer = New GroupNameComparer()})
            Me.radPivotGrid1.RowGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "OrderDate", .Step = DateTimeStep.Month, .GroupComparer = New GroupNameComparer()})

            Me.radPivotGrid1.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "FirstName", .GroupComparer = New GrandTotalComparer()})

            Me.radPivotGrid1.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity", .AggregateFunction = AggregateFunctions.Sum})
            Me.radPivotGrid1.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Discount", .AggregateFunction = AggregateFunctions.Average})

            Me.radPivotGrid1.FilterDescriptions.Add(New PropertyFilterDescription() With {.PropertyName = "ShipCountry", .CustomName = "Country"})

            Dim dataset As NorthwindDataSet = New DataSources.NorthwindDataSet()
            Dim adapter As New OrdersViewTableAdapter()
            adapter.Fill(dataset.OrdersView)

            Me.radPivotGrid1.AggregatesPosition = PivotAxis.Columns
            Me.radPivotGrid1.DataSource = dataset.OrdersView
            Me.radPivotGrid1.ErrorString = "Error"
            Me.radPivotGrid1.EmptyValueString = "No Data"
        End Sub
    End Class
End Namespace
