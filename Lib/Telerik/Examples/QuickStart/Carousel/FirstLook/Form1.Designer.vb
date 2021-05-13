Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Carousel.FirstLook
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim carouselBezierPath1 As New Telerik.WinControls.UI.CarouselBezierPath()
			Dim themeSource2 As New Telerik.WinControls.ThemeSource()
			Me.radCarouselAlbums = New Telerik.WinControls.UI.RadCarousel()
			Me.albumsBindingSource = New BindingSource(Me.components)
			Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
			Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
			Me.radBtnDownloads = New Telerik.WinControls.UI.RadButton()
			Me.radBtnArtists = New Telerik.WinControls.UI.RadButton()
			Me.radBtnAlbums = New Telerik.WinControls.UI.RadButton()
			Me.radBtnSongs = New Telerik.WinControls.UI.RadButton()
			Me.radComboSearch = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.radCarouselAlbums, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnDownloads, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnArtists, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnAlbums, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnSongs, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboSearch, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radCarouselAlbums
			' 
			Me.radCarouselAlbums.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.radCarouselAlbums.BackColor = Color.Transparent
			Me.radCarouselAlbums.BackgroundImageLayout = ImageLayout.Zoom
			carouselBezierPath1.CtrlPoint1 = New Telerik.WinControls.UI.Point3D(12.278630460448643, 48.166259168704158, 300)
			carouselBezierPath1.CtrlPoint2 = New Telerik.WinControls.UI.Point3D(87.839433293978743, 47.677261613691932, 300)
			carouselBezierPath1.FirstPoint = New Telerik.WinControls.UI.Point3D(6.3754427390791024, 50.8557457212714, -400)
			carouselBezierPath1.LastPoint = New Telerik.WinControls.UI.Point3D(93.860684769775673, 51.100244498777506, -400)
			carouselBezierPath1.ZScale = 200
			Me.radCarouselAlbums.CarouselPath = carouselBezierPath1
			Me.radCarouselAlbums.DataSource = Me.albumsBindingSource
			Me.radCarouselAlbums.ForeColor = Color.White
			Me.radCarouselAlbums.Location = New Point(2, 161)
			Me.radCarouselAlbums.Name = "radCarouselAlbums"
			Me.radCarouselAlbums.NavigationButtonsOffset = New Size(80, 20)
			' 
			' 
			' 
			Me.radCarouselAlbums.RootElement.ForeColor = Color.White
			Me.radCarouselAlbums.SelectedIndex = -1
			Me.radCarouselAlbums.Size = New Size(845, 404)
			Me.radCarouselAlbums.TabIndex = 0
			Me.radCarouselAlbums.ThemeName = "ControlDefault"
			Me.radCarouselAlbums.VisibleItemCount = 7


			CType(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.carousel_leftArrow
			CType(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.carousel_rightArrow
			' 
			' albumsBindingSource
			' 
			Me.albumsBindingSource.DataMember = "Albums"
			Me.albumsBindingSource.DataSource = Me.musicCollectionDataSet
			' 
			' musicCollectionDataSet
			' 
			Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
			Me.musicCollectionDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' radThemeManager1
			' 

			themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource2.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("Telerik.Examples.WinControls.Carousel.FirstLook.ButtonMusicLibrary.xml")
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource2})
			' 
			' albumsTableAdapter
			' 
			Me.albumsTableAdapter.ClearBeforeFill = True
			' 
			' radTitleBar1
			' 
			Me.radTitleBar1.BackColor = Color.Transparent
			Me.radTitleBar1.BackgroundImageLayout = ImageLayout.Stretch
			Me.radTitleBar1.Text = "Music Library Demo"
			Me.radTitleBar1.Dock = DockStyle.Top
			Me.radTitleBar1.Location = New Point(2, 2)
			Me.radTitleBar1.Name = "radTitleBar1"
			Me.radTitleBar1.Size = New Size(846, 27)
			Me.radTitleBar1.TabIndex = 2
			Me.radTitleBar1.TabStop = False
			Me.radTitleBar1.Text = "radTitleBar1"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Margin = New Padding(7, 0, 7, 0)
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Text = "Music Library Demo"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = Color.White
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(178)))
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Margin = New Padding(10, 0, 0, 0)
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.FL_min
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Margin = New Padding(0, 0, -2, 0)
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Name = "MinimizeButtonFill"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.FL_Max
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadImageButtonElement).Margin = New Padding(0, 0, -2, 0)
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadImageButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Name = "MaximizeButtonFill"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.FL_Close
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Name = "CloseButtonFill"
			CType(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' radBtnDownloads
			' 
			Me.radBtnDownloads.AllowShowFocusCues = True
			Me.radBtnDownloads.BackColor = Color.Transparent
			Me.radBtnDownloads.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radBtnDownloads.ForeColor = Color.Black
			Me.radBtnDownloads.Location = New Point(489, 47)
			Me.radBtnDownloads.Name = "radBtnDownloads"
			' 
			' 
			' 
			Me.radBtnDownloads.RootElement.ForeColor = Color.Black
			Me.radBtnDownloads.Size = New Size(119, 34)
			Me.radBtnDownloads.TabIndex = 3
			Me.radBtnDownloads.Text = "Downloads"
			Me.radBtnDownloads.ThemeName = "MusicLibrary"
			CType(Me.radBtnDownloads.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Downloads"
			CType(Me.radBtnDownloads.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).BackColor = Color.Transparent
			CType(Me.radBtnDownloads.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radBtnDownloads.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BackColor = Color.Transparent
			' 
			' radBtnArtists
			' 
			Me.radBtnArtists.AllowShowFocusCues = True
			Me.radBtnArtists.BackColor = Color.Transparent
			Me.radBtnArtists.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radBtnArtists.ForeColor = Color.Black
			Me.radBtnArtists.Location = New Point(619, 47)
			Me.radBtnArtists.Name = "radBtnArtists"
			' 
			' 
			' 
			Me.radBtnArtists.RootElement.ForeColor = Color.Black
			Me.radBtnArtists.Size = New Size(77, 34)
			Me.radBtnArtists.TabIndex = 3
			Me.radBtnArtists.Text = "Artists"
			Me.radBtnArtists.ThemeName = "MusicLibrary"
			CType(Me.radBtnArtists.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Artists"
			CType(Me.radBtnArtists.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radBtnAlbums
			' 
			Me.radBtnAlbums.AllowShowFocusCues = True
			Me.radBtnAlbums.BackColor = Color.Transparent
			Me.radBtnAlbums.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radBtnAlbums.ForeColor = Color.Black
			Me.radBtnAlbums.Location = New Point(705, 47)
			Me.radBtnAlbums.Name = "radBtnAlbums"
			' 
			' 
			' 
			Me.radBtnAlbums.RootElement.ForeColor = Color.Black
			Me.radBtnAlbums.Size = New Size(77, 34)
			Me.radBtnAlbums.TabIndex = 3
			Me.radBtnAlbums.Text = "Albums"
			Me.radBtnAlbums.ThemeName = "MusicLibrary"
			CType(Me.radBtnAlbums.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Albums"
			CType(Me.radBtnAlbums.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radBtnSongs
			' 
			Me.radBtnSongs.AllowShowFocusCues = True
			Me.radBtnSongs.BackColor = Color.Transparent
			Me.radBtnSongs.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.radBtnSongs.ForeColor = Color.Black
			Me.radBtnSongs.Location = New Point(786, 47)
			Me.radBtnSongs.Name = "radBtnSongs"
			' 
			' 
			' 
			Me.radBtnSongs.RootElement.ForeColor = Color.Black
			Me.radBtnSongs.Size = New Size(67, 34)
			Me.radBtnSongs.TabIndex = 3
			Me.radBtnSongs.Text = "Songs"
			Me.radBtnSongs.ThemeName = "MusicLibrary"
			CType(Me.radBtnSongs.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Songs"
			CType(Me.radBtnSongs.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radComboSearch
			' 
			Me.radComboSearch.Location = New Point(642, 113)
			Me.radComboSearch.Name = "radComboSearch"
			Me.radComboSearch.NullText = "Search..."
			' 
			' 
			' 
			Me.radComboSearch.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboSearch.Size = New Size(180, 20)
			Me.radComboSearch.TabIndex = 4

			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.BackgroundImage = My.Resources.carousel_first_look_bg
			Me.BackgroundImageLayout = ImageLayout.Stretch
			Me.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center
			Me.BorderColor = SystemColors.WindowFrame
			Me.ClientSize = New Size(850, 620)
			Me.Controls.Add(Me.radComboSearch)
			Me.Controls.Add(Me.radBtnSongs)
			Me.Controls.Add(Me.radBtnAlbums)
			Me.Controls.Add(Me.radBtnArtists)
			Me.Controls.Add(Me.radBtnDownloads)
			Me.Controls.Add(Me.radTitleBar1)
			Me.Controls.Add(Me.radCarouselAlbums)
			Me.MaximizeBox = False
			Me.MaximumSize = New Size(850, 620)
			Me.MinimumSize = New Size(850, 620)
			Me.Name = "Form1"
			Me.Shape = Me.roundRectShape1
			Me.Text = "Music Library Demo"
			CType(Me.radCarouselAlbums, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnDownloads, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnArtists, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnAlbums, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnSongs, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboSearch, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCarouselAlbums As Telerik.WinControls.UI.RadCarousel
		Private musicCollectionDataSet As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private albumsBindingSource As BindingSource
		Private albumsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
		Private radTitleBar1 As Telerik.WinControls.UI.RadTitleBar
		Private radBtnDownloads As Telerik.WinControls.UI.RadButton
		Private radBtnArtists As Telerik.WinControls.UI.RadButton
		Private radBtnAlbums As Telerik.WinControls.UI.RadButton
		Private radBtnSongs As Telerik.WinControls.UI.RadButton
		Private radComboSearch As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace
