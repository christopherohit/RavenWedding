Imports System.Text

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.Binding
	Public Class Customer
		Public Sub New()
			Me.id_Renamed = -1
			Me.name_Renamed = String.Empty
		End Sub
		Public Sub New(ByVal id As Integer, ByVal name As String)
			Me.id_Renamed = id
			Me.name_Renamed = name
		End Sub
		'Fields
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow class members with the same name:
		Private id_Renamed As Integer
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
		'Properties
		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
	End Class
End Namespace
