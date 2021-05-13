Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
	Public Class Track
		Private id_Renamed As Integer
		Private name_Renamed As String
		Private mediaType_Renamed As String
		Private genre_Renamed As String
		Private size_Renamed As String

		Public Sub New()

		End Sub

		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal mediaType As String, ByVal genre As String, ByVal size As String)
			Me.id_Renamed = id
			Me.name_Renamed = name
			Me.mediaType_Renamed = mediaType
			Me.genre_Renamed = genre
			Me.size_Renamed = size
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

		Public Property MediaType() As String
			Get
				Return mediaType_Renamed
			End Get
			Set(ByVal value As String)
				mediaType_Renamed = value
			End Set
		End Property

		Public Property Genre() As String
			Get
				Return genre_Renamed
			End Get
			Set(ByVal value As String)
				genre_Renamed = value
			End Set
		End Property

		Public Property Size() As String
			Get
				Return size_Renamed
			End Get
			Set(ByVal value As String)
				size_Renamed = value
			End Set
		End Property
	End Class
End Namespace