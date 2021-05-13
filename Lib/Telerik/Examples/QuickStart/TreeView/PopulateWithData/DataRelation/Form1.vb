Imports System.ComponentModel
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports My

Namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.DataRelation
	''' <summary>
	''' RadTreeView example
	''' </summary>
	Partial Public Class Form1
		Inherits TreeExamplesControl
		Private bottomRightBitmap As Bitmap = Resources.TV_music
		Private listAlbumsBindingSource As New BindingSource()
		Private listSongsBindingSource As New BindingSource()
		Private internalUpdate As Boolean = False

		Public Sub New()
			InitializeComponent()
			AddHandler listAlbumsBindingSource.CurrentChanged, AddressOf listAlbumsBindingSource_CurrentChanged
			AddHandler listSongsBindingSource.CurrentChanged, AddressOf listSongsBindingSource_CurrentChanged
			AddHandler radTreeView1.SelectedNodeChanging, AddressOf radTreeView1_SelectedNodeChanging
			AddHandler radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_SelectedNodeChanged
			Me.radTreeView1.AllowDragDrop = True

			Me.SelectedControl = Me.radTreeView1
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radTreeView1.NodeExpandedChanging, AddressOf radTreeView1_NodeExpandedChanging
		End Sub

		Private Sub radTreeView1_SelectedNodeChanging(ByVal sender As Object, ByVal e As RadTreeViewCancelEventArgs)
			e.Cancel = Me.internalUpdate
		End Sub

		Private Sub radTreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			If e.Node.Level = 0 Then
				Return
			End If

			If e.Node.Level = 1 Then
				SyncSecondLevel(e)

				Return
			End If

			SyncThreeLevel(e)
		End Sub

		Private Sub SyncSecondLevel(ByVal e As RadTreeViewEventArgs)
			Me.internalUpdate = True
			Dim artistID As Object = (CType(e.Node.Parent.DataBoundItem, DataRowView))("ArtistID")
			Dim parentIndex As Integer = Me.artistsBindingSource.Find("ArtistID", artistID)
			If parentIndex >= 0 Then
				Me.artistsBindingSource.Position = parentIndex
			End If

			Dim albumID As Object = (CType(e.Node.DataBoundItem, DataRowView))("AlbumID")
			Dim index As Integer = Me.listAlbumsBindingSource.Find("AlbumID", albumID)
			If index >= 0 Then
				Me.listAlbumsBindingSource.Position = index
			End If
			Me.internalUpdate = False
		End Sub

		Private Sub SyncThreeLevel(ByVal e As RadTreeViewEventArgs)
			Me.internalUpdate = True
			Dim artistID As Object = (CType(e.Node.Parent.Parent.DataBoundItem, DataRowView))("ArtistID")
			Dim parentIndex As Integer = Me.artistsBindingSource.Find("ArtistID", artistID)
			If parentIndex >= 0 Then
				Me.artistsBindingSource.Position = parentIndex
			End If

			Dim albumID As Object = (CType(e.Node.Parent.DataBoundItem, DataRowView))("AlbumID")
			Dim index As Integer = Me.listAlbumsBindingSource.Find("AlbumID", albumID)
			If index >= 0 Then
				Me.listAlbumsBindingSource.Position = index
			End If

			Dim songID As Object = (CType(e.Node.DataBoundItem, DataRowView))("SongID")
			Dim songIndex As Integer = Me.listSongsBindingSource.Find("SongID", songID)
			If songIndex >= 0 Then
				Me.listSongsBindingSource.Position = songIndex
			End If
			Me.internalUpdate = False
		End Sub

		Private Sub listAlbumsBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.listAlbumsBindingSource.Current Is Nothing Then
				Return
			End If

			Dim albumID As Object = (CType(Me.listAlbumsBindingSource.Current, DataRowView))("AlbumID")
			Dim index As Integer = Me.albumsBindingSource.Find("AlbumID", albumID)
			If index >= 0 Then
				Me.albumsBindingSource.Position = index
			End If
		End Sub

		Private Sub listSongsBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.listSongsBindingSource.Current Is Nothing Then
				Return
			End If

			Dim songID As Object = (CType(Me.listSongsBindingSource.Current, DataRowView))("SongID")
			Dim index As Integer = Me.songsBindingSource.Find("SongID", songID)
			If index >= 0 Then
				Me.songsBindingSource.Position = index
			End If
		End Sub

		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Music Collection"
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radTreeView1.AllowEdit = False
			Me.radTreeView1.AllowAdd = False
			Me.radTreeView1.AllowRemove = False

			Me.artistsTableAdapter.Fill(musicCollectionDataSet.Artists)
			Me.albumsTableAdapter.Fill(musicCollectionDataSet.Albums)
			Me.songsTableAdapter.Fill(musicCollectionDataSet.Songs)

			Me.listAlbumsBindingSource.DataMember = "ArtistsAlbums"
			Me.listAlbumsBindingSource.DataSource = Me.artistsBindingSource
			Me.radListLevelTwo.DisplayMember = "AlbumName"
			Me.radListLevelTwo.DataSource = Me.listAlbumsBindingSource

			Me.listSongsBindingSource.DataMember = "AlbumsSongs"
			Me.listSongsBindingSource.DataSource = Me.listAlbumsBindingSource
			Me.radListLevelThree.DisplayMember = "SongName"
			Me.radListLevelThree.DataSource = Me.listSongsBindingSource

			Using Me.radTreeView1.DeferRefresh()
				Me.radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID")
				Me.radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID")
				Me.radTreeView1.DisplayMember = "ArtistName"
				Me.radTreeView1.DataSource = artistsBindingSource
			End Using
		End Sub

		Private Sub radTreeView1_NodeExpandedChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTreeViewCancelEventArgs)
			Dim nodes As RadTreeNodeCollection = e.Node.Nodes
			For Each node As RadTreeNode In nodes
				node.ImageIndex = node.Level
			Next node
		End Sub
	End Class
End Namespace

