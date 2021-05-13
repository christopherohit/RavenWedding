Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
	Public Class Album
		Private id_Renamed As Integer
		Private artistId_Renamed As Integer
		Private title_Renamed As String
		Private tracks_Renamed As List(Of Track) = New List(Of Track)()

		Public Sub New()

		End Sub

		Public Sub New(ByVal id As Integer, ByVal artistId As Integer, ByVal title As String)
			Me.id_Renamed = id
			Me.artistId_Renamed = artistId
			Me.title_Renamed = title
		End Sub

		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property

		Public Property ArtistId() As Integer
			Get
				Return artistId_Renamed
			End Get
			Set(ByVal value As Integer)
				artistId_Renamed = value
			End Set
		End Property

		Public Property Title() As String
			Get
				Return title_Renamed
			End Get
			Set(ByVal value As String)
				title_Renamed = value
			End Set
		End Property

		Public ReadOnly Property Tracks() As List(Of Track)
			Get
				Return Me.tracks_Renamed
			End Get
		End Property
	End Class
End Namespace