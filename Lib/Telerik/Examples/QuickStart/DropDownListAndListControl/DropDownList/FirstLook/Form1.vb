Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports System.IO

Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.FirstLook
	''' <summary>
	''' RadDropDownList example: Music Collection
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.BackColor = Color.Transparent
			Me.cmbArtist.DropDownAnimationEnabled = False
			Me.cmbArtist.AutoSizeItems = True
			AddHandler cmbArtist.ItemDataBound, AddressOf cmbArtist_ItemDataBound
			Me.cmbArtist.DropDownMinSize = New Size(0, 200)
			AddHandler artistsBindingSource.CurrentItemChanged, AddressOf artistsBindingSource_CurrentItemChanged
			Me.buttonSortAscending.ThemeClassName = String.Empty
			Me.buttonSortDescending.ThemeClassName = String.Empty

			Me.songsTableAdapter.Fill(Me.musicCollectionDataSet.Songs)
			Me.artistsTableAdapter.Fill(Me.musicCollectionDataSet.Artists)
			Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)

			Me.SelectedControl = Me.cmbArtist

			Me.cmbArtist.SelectedIndex = 0
			Me.cmbArtist.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbAlbum.SelectedIndex = 0
			Me.cmbAlbum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbSong.SelectedIndex = 0
			Me.cmbSong.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
		End Sub

		'protected override void OnSizeChanged(EventArgs e)
		'{
		'    if (this.radPanelDemoHolder != null)
		'    {
		'        float xCoord = ((float)(this.Width - this.radPanelDemoHolder.Width)) / 2;
		'        float yCoord = ((float)(this.Height - this.radPanelDemoHolder.Height)) / 2;

		'        this.radPanelDemoHolder.Location = Point.Round(new PointF(xCoord, yCoord));
		'    }

		'    base.OnSizeChanged(e);
		'}		

		Private Sub artistsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim imageIndex As Integer = CInt(Fix((TryCast(Me.artistsBindingSource.Current, DataRowView))("ImageIndex")))

			If imageIndex >= 0 AndAlso imageIndex < Me.ArtistsLargeImageList.Images.Count Then
				Me.pictureBox.Image = Me.ArtistsLargeImageList.Images(imageIndex)
			End If

			Me.cmbAlbum.SelectedIndex = 0
			Me.cmbSong.SelectedIndex = 0
		End Sub

		Private Sub cmbArtist_ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs)
			Dim item As RadListDataItem = args.NewItem
			Dim dataBoundItem As Object = item.DataBoundItem
			item.TextImageRelation = TextImageRelation.ImageBeforeText
			Dim desc As PropertyDescriptor = TypeDescriptor.GetProperties(dataBoundItem).Find("ImageIndex", False)
			item.Image = Me.cmbArtist.ImageList.Images(CInt(Fix(desc.GetValue(dataBoundItem))))
		End Sub

		Private Sub cmbArtist_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Private Sub cmbAlbum_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Private Sub cmbSong_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedSongInfo As New StringBuilder()
			selectedSongInfo.AppendLine(Me.cmbArtist.Text)
			selectedSongInfo.AppendLine(Me.cmbAlbum.Text)
			selectedSongInfo.AppendLine(Me.cmbSong.Text)

			Me.lblSelectedSong.Text = selectedSongInfo.ToString()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.AddSortingButtons()
		End Sub

		Private Sub AddSortingButtons()
			AddHandler buttonSortAscending.ToolTipTextNeeded, AddressOf buttonSortAscending_ToolTipTextNeeded
			AddHandler buttonSortAscending.MouseClick, AddressOf SortAsc
			AddHandler buttonSortDescending.ToolTipTextNeeded, AddressOf buttonSortDescending_ToolTipTextNeeded
			AddHandler buttonSortDescending.MouseClick, AddressOf SortDesc
		End Sub

		Private Sub buttonSortDescending_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
			e.ToolTipText = "Sort Descending"
		End Sub

		Private Sub buttonSortAscending_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
			e.ToolTipText = "Sort Ascending"
		End Sub

		Private Sub SortDesc(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim selectedItem As String = Me.cmbArtist.SelectedItem.ToString()
			Me.artistsBindingSource.Sort = Me.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName & " desc"
			Me.cmbArtist.SelectedIndex = Me.cmbArtist.FindStringExact(selectedItem)
		End Sub

		Private Sub SortAsc(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim selectedItem As String = Me.cmbArtist.SelectedItem.ToString()
			Me.artistsBindingSource.Sort = Me.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName & " asc"
			Me.cmbArtist.SelectedIndex = Me.cmbArtist.FindStringExact(selectedItem)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler cmbArtist.SelectedIndexChanged, AddressOf cmbArtist_SelectedIndexChanged
		End Sub
	End Class
End Namespace
