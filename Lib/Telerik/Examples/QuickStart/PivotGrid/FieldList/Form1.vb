Imports System.IO

Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.Aggregates
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PivotGrid.FieldList
	Partial Public Class Form1
		Inherits RadForm
		Implements ISupportThemeName
		Private orders As New List(Of Order2)()
		Private provider As LocalDataSourceProvider

		Public Sub New()
			InitializeComponent()
			Me.LoadData()

			Me.provider = New LocalDataSourceProvider() With {.ItemsSource = orders}

			provider.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "Date", .Step = DateTimeStep.Year})
			provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Promotion", .GroupComparer = New GroupNameComparer()})

			provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Product", .GroupComparer = New GroupNameComparer(), .SortOrder = Telerik.Pivot.Core.SortOrder.Descending})
			provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Advertisement", .GroupComparer = New GroupNameComparer()})

			provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity", .AggregateFunction = AggregateFunctions.Sum})
			provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Net", .AggregateFunction = AggregateFunctions.Sum})

			provider.AggregatesPosition = PivotAxis.Columns
			provider.AggregatesLevel = 2

			Me.radPivotGrid1.PivotGridElement.DataProvider = provider
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

        Public Sub ApplyTheme(ByVal themeName As String) Implements ISupportThemeName.ApplyTheme
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub
    End Class
End Namespace
