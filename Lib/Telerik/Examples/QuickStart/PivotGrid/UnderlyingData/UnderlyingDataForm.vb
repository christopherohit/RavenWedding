Imports System.Collections
Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
	Partial Public Class UnderlyingDataForm
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()

			Dim summaryItemQuantity As New GridViewSummaryItem()
			summaryItemQuantity.Name = "Quantity"
			summaryItemQuantity.Aggregate = GridAggregateFunction.Sum
			Dim summaryItemNet As New GridViewSummaryItem()
			summaryItemNet.Name = "Net"
			summaryItemNet.Aggregate = GridAggregateFunction.Sum

			Dim summaryRowItem As New GridViewSummaryRowItem()
			summaryRowItem.Add(summaryItemQuantity)
			summaryRowItem.Add(summaryItemNet)
			Me.radGridView1.SummaryRowsTop.Add(summaryRowItem)
		End Sub

		Friend Sub DisplayUnderlyingData(ByVal underlyingData As IEnumerable, ByVal owner As IWin32Window)
			Me.radGridView1.DataSource = underlyingData
			Me.ShowDialog(owner)
		End Sub
	End Class
End Namespace
