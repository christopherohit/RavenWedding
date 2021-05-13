Imports System.Collections
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports Telerik.Pivot.Core
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
	Partial Public Class Form1
		Inherits ExamplesForm
		Private provider As LocalDataSourceProvider
		Private underlyingDataForm As New UnderlyingDataForm()
		Private orders As New List(Of Order2)()

		Public Sub New()
			InitializeComponent()

			AddHandler Me.radPivotGrid1.MouseDoubleClick, AddressOf radPivotGrid1_MouseDoubleClick
		End Sub

		Private Sub radPivotGrid1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Dim pivotGrid As RadPivotGrid = CType(sender, RadPivotGrid)
				Dim cell As PivotCellElement = TryCast(pivotGrid.ElementTree.GetElementAtPoint(e.Location), PivotCellElement)
				If cell IsNot Nothing Then
					Dim row As IGroup = cell.Row.Group
					Dim column As IGroup = cell.Column.Group
					Dim localProvider As LocalDataSourceProvider = TryCast(pivotGrid.DataProvider, LocalDataSourceProvider)
					localProvider.GetUnderlyingData(row, column)
				End If
			End If
		End Sub

		Private Sub provider_GetUnderlyingDataCompleted(ByVal sender As Object, ByVal e As Telerik.Pivot.Core.DrillDown.DrillDownCompletedEventArgs)
            Me.BeginInvoke(DirectCast(Sub()
                                          If e.InnerExceptions.Count = 0 Then
                                              ThemeResolutionService.ApplyThemeToControlTree(TryCast(Me.underlyingDataForm, Form), Me.CurrentThemeName)
                                              Me.underlyingDataForm.DisplayUnderlyingData(e.Result, Me)
                                          ElseIf e.InnerExceptions.Count = 1 AndAlso e.InnerExceptions(0).[GetType]() Is GetType(InvalidOperationException) Then
                                              RadMessageBox.ThemeName = Me.CurrentThemeName
                                              RadMessageBox.Show("Please Refresh the Data Provider.")
                                          End If

                                      End Sub, MethodInvoker))
        End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.LoadData()
			Me.SetupPivot()

			Me.radPivotGrid1.DataProvider = provider
			Me.radPivotGrid1.RowsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.Last
		End Sub

		Private Sub SetupPivot()
			Me.provider = New LocalDataSourceProvider() With {.ItemsSource = orders}

			AddHandler Me.provider.GetUnderlyingDataCompleted, AddressOf provider_GetUnderlyingDataCompleted

			Me.provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Product"})

			Me.provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Advertisement"})

			Me.provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Promotion"})

			Me.provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity"})

			Me.provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Net"})
		End Sub

		Private Sub LoadData()
            Dim stream As Stream = System.Reflection.Assembly.GetCallingAssembly().GetManifestResourceStream("PivotData.txt")

            Using streamReader As New StreamReader(stream)
				Do While streamReader.Peek() <> -1
					Dim items() As String = streamReader.ReadLine().Split(ControlChars.Tab)
					Dim o As New Order2() With {.Date = Date.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), .Product = items(1), .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), .Promotion = items(4), .Advertisement = items(5)}

					orders.Add(o)
				Loop
			End Using
		End Sub
	End Class
End Namespace