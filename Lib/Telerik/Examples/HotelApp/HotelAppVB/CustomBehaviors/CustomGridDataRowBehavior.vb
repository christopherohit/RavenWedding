Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI

Namespace HotelApp
	Public Class CustomGridDataRowBehavior
		Inherits GridDataRowBehavior
		Protected Overrides Function OnMouseDownLeft(ByVal e As MouseEventArgs) As Boolean
			Dim row As GridDataRowElement = TryCast(Me.GetRowAtPoint(e.Location), GridDataRowElement)
			If row IsNot Nothing Then
				Dim svc As RadGridViewDragDropService = Me.GridViewElement.GetService(Of RadGridViewDragDropService)()
				svc.AllowAutoScrollColumnsWhileDragging = False
				svc.AllowAutoScrollRowsWhileDragging = False
				svc.Start(row)
			End If
			Return MyBase.OnMouseDownLeft(e)
		End Function
	End Class
End Namespace