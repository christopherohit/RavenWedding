Imports System.Text

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.IndicateErrors
	Friend Class EmployeePositions
'INSTANT VB NOTE: The variable display was renamed since Visual Basic does not allow class members with the same name:
		Private display_Renamed As String
'INSTANT VB NOTE: The variable position was renamed since Visual Basic does not allow class members with the same name:
		Private position_Renamed As EmployeePosition

		Public Sub New()
		End Sub

		Public Sub New(ByVal display As String, ByVal position As EmployeePosition)
			Me.display_Renamed = display
			Me.position_Renamed = position
		End Sub

		Public Property Display() As String
			Get
				Return display_Renamed
			End Get
			Set(ByVal value As String)
				display_Renamed = value
			End Set
		End Property

		Public Property Position() As EmployeePosition
			Get
				Return position_Renamed
			End Get
			Set(ByVal value As EmployeePosition)
				position_Renamed = value
			End Set
		End Property
	End Class
End Namespace
