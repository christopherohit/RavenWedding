Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace  Telerik.Examples.WinControls.GridView.ObjectRelationalHierarchy
	Public Class Artist
		Private id_Renamed As Integer
		Private name_Renamed As String
		Private albums_Renamed As List(Of Album) = New List(Of Album)()

		Public Sub New()

		End Sub

		Public Sub New(ByVal id As Integer, ByVal name As String)
			Me.id_Renamed = id
			Me.name_Renamed = name
		End Sub

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

		Public ReadOnly Property Albums() As List(Of Album)
			Get
				Return albums_Renamed
			End Get
		End Property
	End Class
End Namespace