Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
	Public Class GridViewFilteringChildRowInfo
		Inherits GridViewRowInfo
		#Region "Intialization"

		Public Sub New(ByVal view As GridViewInfo)
			MyBase.New(view)

		End Sub

		#End Region

		#Region "Properties"

		Public Overrides ReadOnly Property AllowedStates() As AllowedGridViewRowInfoStates
			Get
				Return AllowedGridViewRowInfoStates.None
			End Get
		End Property

		Public Overrides ReadOnly Property RowElementType() As Type
			Get
				Return GetType(GridFilteringChildRowElement)
			End Get
		End Property

		#End Region
	End Class
End Namespace
