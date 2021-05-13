Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Performance.Load50000Rows
	''' <summary>
	''' This example shows the capability of the RadGridView control to handle
	''' 50 000 rows of data.
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private randomGenerator As New Random()
		Private Const ROWS_COUNT As Integer = 50000
		Private randomStrings() As String

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()
			InitializeData()

			Me.radGridViewDemo.MasterView.TableHeaderRow.IsVisible = False
			Me.radGridViewDemo.MasterTemplate.EnableGrouping = False
		End Sub

		#End Region

		#Region "Binding"

		Private Sub InitializeData()
			Me.randomStrings = New String(19){}

			For i As Integer = 0 To Me.randomStrings.Length - 1
				Me.randomStrings(i) = "String " & (i + 1)
			Next i

			Dim integerColumn As New DataColumn("RowIndex", GetType(Integer))
			Dim stringColumn As New DataColumn("StringColumn", GetType(String))
			Dim decimalColumn As New DataColumn("DecimalColumn", GetType(Decimal))
			Dim boolColumn As New DataColumn("BooleanColumn", GetType(Boolean))

			dataTable.Columns.Add(integerColumn)
			dataTable.Columns.Add(stringColumn)
			dataTable.Columns.Add(decimalColumn)
			dataTable.Columns.Add(boolColumn)

			dataTable.BeginLoadData()
			For i As Integer = 0 To ROWS_COUNT - 1
				Dim row As DataRow = dataTable.NewRow()

				row("RowIndex") = i
				row("StringColumn") = Me.randomStrings(randomGenerator.Next(0, Me.randomStrings.Length - 1))
				row("DecimalColumn") = CDec(Math.PI / CSng(i + 1))
				row("BooleanColumn") = (randomGenerator.Next() Mod 2) = 0

				dataTable.Rows.Add(row)
			Next i
			dataTable.EndLoadData()
		End Sub

		#End Region

		#Region "Event handling"

		Private Sub radBtnBind_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridViewDemo.Controls.Remove(Me.radBtnBind)

			Me.radGridViewDemo.EnableFiltering = True
			Me.radGridViewDemo.EnableSorting = True
			Me.radGridViewDemo.EnableGrouping = True
			Me.radGridViewDemo.MasterView.TableHeaderRow.IsVisible = True

			Me.radGridViewDemo.MasterTemplate.BeginUpdate()
			Me.radGridViewDemo.DataSource = Me.dataTable
			TryCast(Me.radGridViewDemo.MasterTemplate.Columns("DecimalColumn"), GridViewDecimalColumn).FormatString = "{0:F6}"
			Me.radGridViewDemo.MasterTemplate.EndUpdate()
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radBtnBind.Click, AddressOf radBtnBind_Click
		End Sub
	End Class
End Namespace
