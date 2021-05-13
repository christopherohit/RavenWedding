Imports System.Collections
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const COUNT As Integer = 15

		' Fields
        Private counts As Integer = 0
		Private timer As Timer
		Private refreshCount As Integer = 0
		Private refreshInterval As Integer = 15
		Private iterationsPerUpdate As Integer = 3
		Private refreshRateTimer As Timer

		Private dataSource As MockIntegerDataSource = Nothing

		Public Sub New()
			InitializeComponent()

			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AllowCellContextMenu = False
			Me.radGridView1.MasterTemplate.AllowDeleteRow = False
			Me.radGridView1.MasterTemplate.AllowEditRow = False
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.EnableSorting = False
			Me.radGridView1.EnableFiltering = False
			Me.radGridView1.EnableGrouping = False

			Me.SelectedControl = Me.radGridView1
			Me.refreshRateTimer = New Timer(Me.components)
			Me.refreshRateTimer.Interval = 1000
			AddHandler refreshRateTimer.Tick, AddressOf OnRefreshRateTimer_Tick
			Me.refreshRateTimer.Start()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.dataSource = New MockIntegerDataSource(COUNT, COUNT)

			AddHandler radGridView1.CellValueNeeded, AddressOf radGridView1_CellValueNeeded

			radGridView1.VirtualMode = True
			radGridView1.ColumnCount = Me.dataSource.Columns
			Me.radGridView1.RowCount = Me.dataSource.Rows

			For columnIndex As Integer = 0 To COUNT - 1
				Me.radGridView1.Columns(columnIndex).HeaderText = (columnIndex + 1).ToString()
			Next columnIndex

			Me.timer = New Timer(Me.components)
			Me.timer.Interval = refreshInterval
			AddHandler timer.Tick, AddressOf Refresh
			Me.timer.Start()
		End Sub

		Private Sub radGridView1_CellValueNeeded(ByVal sender As Object, ByVal e As GridViewCellValueEventArgs)
			e.Value = Me.dataSource.Source(e.RowIndex).Data(e.ColumnIndex)
		End Sub

		Private Overloads Sub Refresh(ByVal sender As Object, ByVal args As EventArgs)
			' RadGridView data refresh for all cells (virtual mode) 
			For n As Integer = 0 To iterationsPerUpdate - 1
				Me.dataSource.Refresh()
				Me.radGridView1.MasterTemplate.Refresh(Nothing)
				refreshCount += 1
                counts += 1
                Me.radLblRefreshCount.Text = String.Format("Refreshed: {0} times", counts)
			Next n
		End Sub

		Private Sub OnRefreshRateTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radLblAverage.Text = "Refresh rate: " & refreshCount & " refreshes/second"
			refreshCount = 0
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
