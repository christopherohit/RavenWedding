Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
	Public Class GridFilteringChildRowElement
		Inherits GridRowElement
		#Region "Fields"

		Private cellElement As GridCellElement
		Private hostedControl As AdvanceFilterControl

		#End Region

		#Region "Initialization"

		Public Sub New()
		End Sub

		Public Overrides Sub Initialize(ByVal rowInfo As GridViewRowInfo)
			MyBase.Initialize(rowInfo)

			rowInfo.SuspendPropertyNotifications()
			rowInfo.Height = Me.hostedControl.Size.Height
			rowInfo.ResumePropertyNotifications()
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.cellElement = New GridCellElement(Nothing, Me)
			Me.cellElement.StretchHorizontally = True
			Me.cellElement.StretchVertically = True
			Me.Children.Add(cellElement)

			Me.hostedControl = New AdvanceFilterControl()
			Dim hostItem As New RadHostItem(Me.hostedControl)
			Me.cellElement.Children.Add(hostItem)
		End Sub

		Protected Overrides Sub OnLoaded()
			MyBase.OnLoaded()
			Dim grid As RadGridView = Me.GridControl
			Me.hostedControl.GridView = grid
		End Sub

		#End Region

		#Region "Methods"

		Public Overrides Function IsCompatible(ByVal data As GridViewRowInfo, ByVal context As Object) As Boolean
			Return TypeOf data Is GridViewFilteringChildRowInfo
		End Function

		#End Region
	End Class
End Namespace
