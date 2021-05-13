Imports System.ComponentModel
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Carousel.FirstLook
	Partial Public Class Form1
		Inherits ShapedForm
		Private searchTextIsDirty As Boolean
		Private selectedItemText As New TextPrimitive()

		Public Sub New()
			InitializeComponent()

			WireEvents()

			selectedItemText.AutoSize = False
			selectedItemText.Bounds = New Rectangle(175, 375, 502, 39)
			Me.radCarouselAlbums.CarouselElement.Children.Add(selectedItemText)
			selectedItemText.Font = New Font("Arial Rounded MT Bold", 14.25f)
			selectedItemText.TextAlignment = ContentAlignment.MiddleCenter


			'Prevent the titlebar to acquire a theme.
			Me.radTitleBar1.ThemeName = ""
			Me.radBtnAlbums.ThemeName = "MusicLibrary"
			Me.radBtnDownloads.ThemeName = "MusicLibrary"
			Me.radBtnSongs.ThemeName = "MusicLibrary"
			Me.radBtnArtists.ThemeName = "MusicLibrary"
		End Sub

		Private Sub WireEvents()
			AddHandler radCarouselAlbums.ItemDataBound, AddressOf radCarousel1_ItemDataBound
			AddHandler radCarouselAlbums.SelectedIndexChanged, AddressOf radCarousel1_SelectedIndexChanged
			AddHandler radComboSearch.Validated, AddressOf radComboBox1_Validated
			AddHandler radComboSearch.KeyDown, AddressOf radComboBox1_KeyDown
			AddHandler radComboSearch.TextChanged, AddressOf radComboBox1_TextChanged
		End Sub


		Private Sub ManualTest()
			Me.ShowDialog()
		End Sub

		Private Sub radCarousel1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ItemDataBoundEventArgs)
			Dim carouselItem As RadButtonElement = CType(e.DataBoundItem, RadButtonElement)
			carouselItem.TextImageRelation = TextImageRelation.TextAboveImage
			carouselItem.Font = New Font("Verdana", 10f)
			carouselItem.ForeColor = Color.WhiteSmoke
			'Store data to use later
			carouselItem.Tag = e.DataItem

			Dim image As Image = Me.GetImageFromBytes(EvaluatePropertyValue(e.DataItem, "Image"))

			If image IsNot Nothing Then
				carouselItem.Image = New Bitmap(image, 165, 165)
			End If

			carouselItem.Text = CStr(EvaluatePropertyValue(e.DataItem, "AlbumName"))
		End Sub

		Private Function EvaluatePropertyValue(ByVal dataItem As Object, ByVal [property] As String) As Object
			Return TypeDescriptor.GetProperties(dataItem)([property]).GetValue(dataItem)
		End Function

		Private Function GetImageFromBytes(ByVal data As Object) As Image
			Dim result As Image = Nothing
			Dim stream As MemoryStream = Nothing

			Try
				If data IsNot Nothing AndAlso GetType(Byte()).IsAssignableFrom(data.GetType()) Then
					Dim bytes() As Byte = Nothing
					bytes = CType(data, Byte())
					If bytes.Length > 0 Then
						Dim count As Integer
						Dim start As Integer
						count = bytes.Length
						start = 0


						stream = New MemoryStream(bytes, start, count)
						result = Image.FromStream(stream)
					End If
				End If
			Catch
				result = Nothing
			Finally
				If stream IsNot Nothing Then
					stream.Close()
				End If
			End Try
			Return result
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'musicCollectionDataSet.Albums' table. You can move, or remove it, as needed.
			Me.albumsTableAdapter.Fill(Me.musicCollectionDataSet.Albums)

			If Me.radCarouselAlbums.Items.Count > 3 Then
				Me.radCarouselAlbums.SelectedIndex = 3
			End If
		End Sub

		Private Sub SearchCarouselItems()
			If searchTextIsDirty Then
				If Not String.IsNullOrEmpty(Me.radComboSearch.Text) Then
					Dim carouselItem As RadItem = Me.radCarouselAlbums.CarouselElement.FindItemContaining(Me.radComboSearch.Text)
					If carouselItem IsNot Nothing Then
						If Me.radComboSearch.FindStringExact(Me.radComboSearch.Text) = -1 Then
							Me.radComboSearch.Items.Add(Me.radComboSearch.Text)
						End If

						Me.radCarouselAlbums.SelectedItem = carouselItem
						searchTextIsDirty = False
					End If
				End If
			End If
		End Sub

		Private Sub radComboBox1_Validated(ByVal sender As Object, ByVal e As EventArgs)
			Me.SearchCarouselItems()
		End Sub

		Private Sub radComboBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyData = Keys.Enter Then
				Me.SearchCarouselItems()
			End If
		End Sub

		Private Sub radComboBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			searchTextIsDirty = True
		End Sub

		Private Sub radCarousel1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As RadItem = (TryCast(Me.radCarouselAlbums.SelectedItem, RadItem))
			If item IsNot Nothing AndAlso item.Tag IsNot Nothing Then
				Me.selectedItemText.Text = CStr(EvaluatePropertyValue(item.Tag, "AlbumName"))

				Dim setting As New AnimatedPropertySetting(VisualElement.ForeColorProperty, Color.Transparent, Color.WhiteSmoke, 10, 40)

				setting.ApplyValue(selectedItemText)
			End If
		End Sub

	End Class
End Namespace
