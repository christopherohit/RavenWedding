Imports System.Text

Namespace Telerik.Examples.WinControls.GridView.Performance.HighRefresh
	Friend Interface IMockDataSource(Of T)
		ReadOnly Property Source() As List(Of T)
		Sub Refresh()
		ReadOnly Property Rows() As Integer
		ReadOnly Property Columns() As Integer
	End Interface
End Namespace
