﻿Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
	Public Class RowDetailsViewDefinition
		Inherits TableViewDefinition
		Public Overrides Function CreateViewUIElement(ByVal viewInfo As GridViewInfo) As IRowView
			Dim tableElement As GridTableElement = CType(MyBase.CreateViewUIElement(viewInfo), GridTableElement)
			tableElement.ViewElement.RowLayout = CreateRowLayout()
			Return tableElement
		End Function

		Public Overrides Function CreateRowLayout() As IGridRowLayout
			Return New RowDetailsLayout()
		End Function
	End Class
End Namespace
