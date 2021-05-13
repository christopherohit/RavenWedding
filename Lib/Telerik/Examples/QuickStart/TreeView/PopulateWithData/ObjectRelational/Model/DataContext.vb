Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Xml
Imports System.Windows.Forms
Imports System.Collections
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.ChinookDataSetTableAdapters

Namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
	Public Class DataContext
		Private artistDictionary As SortedDictionary(Of Integer, Artist)


		Public Sub New()
			Dim dataSet As New ChinookDataSet()
			Dim artistAdapter As New ArtistTableAdapter()
			artistAdapter.Fill(dataSet.Artist)

			Dim albumAdapter As New AlbumTableAdapter()
			albumAdapter.Fill(dataSet.Album)

			Dim trackAdapter As New TrackTableAdapter()
			trackAdapter.Fill(dataSet.Track)

			Dim mediaAdapter As New MediaTypeTableAdapter()
			mediaAdapter.Fill(dataSet.MediaType)

			Dim genreAdapter As New GenreTableAdapter()
			genreAdapter.Fill(dataSet.Genre)

			'load root level
			Me.artistDictionary = New SortedDictionary(Of Integer, Artist)()
			Dim table As DataTable = dataSet.Artist
			For Each row As DataRow In table.Rows
				Dim artist As New Artist(Convert.ToInt32(row(0)), row(1).ToString())
				artistDictionary.Add(artist.Id, artist)
			Next row

			' map Album data to Artist Album property
			table = dataSet.Album
			Dim tracks As DataTable = dataSet.Track
			For Each row As DataRow In table.Rows
				Dim album As New Album(Convert.ToInt32(row(0)), Convert.ToInt32(row(2)), row(1).ToString())
				Dim artist As Artist = Nothing
				Me.artistDictionary.TryGetValue(album.ArtistId, artist)
				If artist IsNot Nothing Then
					artist.Albums.Add(album)
				End If

				tracks.DefaultView.RowFilter = String.Format("AlbumId = {0}", album.Id)
				For Each rowView As DataRowView In tracks.DefaultView
					Dim track As New Track()
					track.Name = rowView("Name").ToString()

					dataSet.MediaType.DefaultView.RowFilter = String.Format("MediaTypeId = {0}", rowView("MediaTypeId"))
					track.MediaType = dataSet.MediaType.DefaultView(0)("Name").ToString()

					dataSet.Genre.DefaultView.RowFilter = String.Format("GenreId = {0}", rowView("GenreId"))
					track.Genre = dataSet.Genre.DefaultView(0)("Name").ToString()

					album.Tracks.Add(track)
				Next rowView
			Next row
		End Sub

		Public ReadOnly Property Artists() As List(Of Artist)
			Get
				Return New List(Of Artist)(Me.artistDictionary.Values)
			End Get
		End Property
	End Class
End Namespace