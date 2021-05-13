﻿Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
	Public Class RowDetailsRowElement
		Inherits GridDataRowElement
		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridDataRowElement)
			End Get
		End Property

		Public Overrides Sub UpdateInfo()
			If Not Me.RowInfo.IsCurrent Then
				Me.RowInfo.Height = TableElement.RowHeight
			Else
				Me.RowInfo.Height = (CType(Me.GridControl, RowDetailsGrid)).DetailsRowHeight
			End If
			MyBase.UpdateInfo()
		End Sub
	End Class
End Namespace