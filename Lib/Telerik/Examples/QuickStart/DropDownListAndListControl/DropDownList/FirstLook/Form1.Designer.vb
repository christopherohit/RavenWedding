Namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.FirstLook
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.cmbArtist = New Telerik.WinControls.UI.RadDropDownList()
            Me.artistsBindingSource = New BindingSource(Me.components)
            Me.musicCollectionDataSetBindingSource = New BindingSource(Me.components)
            Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
            Me.ArtistsImageList = New ImageList(Me.components)
            Me.cmbAlbum = New Telerik.WinControls.UI.RadDropDownList()
            Me.artistsAlbumsBindingSource = New BindingSource(Me.components)
            Me.cmbSong = New Telerik.WinControls.UI.RadDropDownList()
            Me.albumsSongsBindingSource = New BindingSource(Me.components)
            Me.lblSelectedSong = New Telerik.WinControls.UI.RadLabel()
            Me.artistsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter()
            Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
            Me.songsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter()
            Me.pictureBox = New PictureBox()
            Me.ArtistsLargeImageList = New ImageList(Me.components)
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.buttonSortAscending = New Telerik.WinControls.UI.RadButton()
            Me.buttonSortDescending = New Telerik.WinControls.UI.RadButton()
            Me.radOffice2007ScreenTip1 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
            Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.cmbArtist, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.musicCollectionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.musicCollectionDataSet.AlbumsDataTableProperty, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.musicCollectionDataSet.SongsDataTableProperty, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.artistsAlbumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbSong, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.albumsSongsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblSelectedSong, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonSortAscending, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonSortDescending, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New Point(1010, 1)
            Me.settingsPanel.Margin = New Padding(5, 5, 5, 5)
            ' 
            ' settingsPanel.PanelContainer
            ' 
            Me.settingsPanel.PanelContainer.Margin = New Padding(5, 5, 5, 5)
            Me.settingsPanel.PanelContainer.Size = New Size(312, 1130)
            Me.settingsPanel.Size = New Size(312, 1130)
            Me.settingsPanel.ThemeName = "ControlDefault"
            ' 
            ' cmbArtist
            ' 
            Me.cmbArtist.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.cmbArtist.AutoCompleteDisplayMember = "ArtistName"
            Me.cmbArtist.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbArtist.DataSource = Me.artistsBindingSource
            Me.cmbArtist.DisplayMember = "ArtistName"
            Me.cmbArtist.DropDownHeight = 166
            Me.cmbArtist.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
            Me.cmbArtist.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.cmbArtist.ImageList = Me.ArtistsImageList
            Me.cmbArtist.Location = New Point(5, 32)
            Me.cmbArtist.Margin = New Padding(5, 5, 5, 5)
            Me.cmbArtist.Name = "cmbArtist"
            Me.cmbArtist.NullText = "Select Artist"
            Me.cmbArtist.ShowImageInEditorArea = False
            Me.cmbArtist.Size = New Size(277, 24)
            Me.cmbArtist.TabIndex = 1
            ' 
            ' artistsBindingSource
            ' 
            Me.artistsBindingSource.DataMember = "Artists"
            Me.artistsBindingSource.DataSource = Me.musicCollectionDataSetBindingSource
            ' 
            ' musicCollectionDataSetBindingSource
            ' 
            Me.musicCollectionDataSetBindingSource.DataSource = Me.musicCollectionDataSet
            Me.musicCollectionDataSetBindingSource.Position = 0
            ' 
            ' musicCollectionDataSet
            ' 
            Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
            Me.musicCollectionDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            ' 
            ' 
            ' 
            Me.musicCollectionDataSet.AlbumsDataTableProperty.TableName = "AlbumsDataTable"
            ' 
            ' 
            ' 
            Me.musicCollectionDataSet.SongsDataTableProperty.TableName = "SongsDataTable"
            ' 
            ' ArtistsImageList
            ' 
            Me.ArtistsImageList.ImageStream = (CType(resources.GetObject("ArtistsImageList.ImageStream"), ImageListStreamer))
            Me.ArtistsImageList.TransparentColor = Color.Transparent
            Me.ArtistsImageList.Images.SetKeyName(0, "smallSting.jpg")
            Me.ArtistsImageList.Images.SetKeyName(1, "smallDepeche.jpg")
            Me.ArtistsImageList.Images.SetKeyName(2, "smallSheryl.jpg")
            Me.ArtistsImageList.Images.SetKeyName(3, "smallClapton.jpg")
            Me.ArtistsImageList.Images.SetKeyName(4, "smallFloyd.jpg")
            Me.ArtistsImageList.Images.SetKeyName(5, "smallPurple.jpg")
            Me.ArtistsImageList.Images.SetKeyName(6, "smallINXS.jpg")
            Me.ArtistsImageList.Images.SetKeyName(7, "smallBadu.jpg")
            Me.ArtistsImageList.Images.SetKeyName(8, "smallNada.jpg")
            Me.ArtistsImageList.Images.SetKeyName(9, "smallBreeders.jpg")
            Me.ArtistsImageList.Images.SetKeyName(10, "smallConchords.jpg")
            Me.ArtistsImageList.Images.SetKeyName(11, "smallLeona.jpg")
            ' 
            ' cmbAlbum
            ' 
            Me.cmbAlbum.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.cmbAlbum.AutoCompleteDisplayMember = "AlbumName"
            Me.cmbAlbum.DataSource = Me.artistsAlbumsBindingSource
            Me.cmbAlbum.DisplayMember = "AlbumName"
            Me.cmbAlbum.DropDownHeight = 166
            Me.cmbAlbum.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
            Me.cmbAlbum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.cmbAlbum.Location = New Point(396, 32)
            Me.cmbAlbum.Margin = New Padding(5, 5, 5, 5)
            Me.cmbAlbum.Name = "cmbAlbum"
            Me.cmbAlbum.NullText = "Select Album"
            Me.cmbAlbum.Size = New Size(263, 24)
            Me.cmbAlbum.TabIndex = 2
            ' 
            ' artistsAlbumsBindingSource
            ' 
            Me.artistsAlbumsBindingSource.DataMember = "ArtistsAlbums"
            Me.artistsAlbumsBindingSource.DataSource = Me.artistsBindingSource
            ' 
            ' cmbSong
            ' 
            Me.cmbSong.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.cmbSong.AutoCompleteDisplayMember = "SongName"
            Me.cmbSong.DataSource = Me.albumsSongsBindingSource
            Me.cmbSong.DisplayMember = "SongName"
            Me.cmbSong.DropDownHeight = 166
            Me.cmbSong.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
            Me.cmbSong.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.cmbSong.Location = New Point(669, 32)
            Me.cmbSong.Margin = New Padding(5, 5, 5, 5)
            Me.cmbSong.Name = "cmbSong"
            Me.cmbSong.NullText = "Select Song"
            Me.cmbSong.Size = New Size(285, 24)
            Me.cmbSong.TabIndex = 3
            ' 
            ' albumsSongsBindingSource
            ' 
            Me.albumsSongsBindingSource.DataMember = "AlbumsSongs"
            Me.albumsSongsBindingSource.DataSource = Me.artistsAlbumsBindingSource
            ' 
            ' lblSelectedSong
            ' 
            Me.lblSelectedSong.BackColor = Color.Transparent
            Me.lblSelectedSong.Font = New Font("Arial", 10.0F)
            Me.lblSelectedSong.ForeColor = Color.SteelBlue
            Me.lblSelectedSong.Location = New Point(200, 332)
            Me.lblSelectedSong.Margin = New Padding(5, 5, 5, 5)
            Me.lblSelectedSong.Name = "lblSelectedSong"
            Me.lblSelectedSong.Size = New Size(2, 2)
            Me.lblSelectedSong.TabIndex = 5
            Me.lblSelectedSong.TextAlignment = ContentAlignment.TopLeft
            ' 
            ' artistsTableAdapter
            ' 
            Me.artistsTableAdapter.ClearBeforeFill = True
            ' 
            ' albumsTableAdapter
            ' 
            Me.albumsTableAdapter.ClearBeforeFill = True
            ' 
            ' songsTableAdapter
            ' 
            Me.songsTableAdapter.ClearBeforeFill = True
            ' 
            ' pictureBox
            ' 
            Me.pictureBox.BackColor = Color.Transparent
            Me.pictureBox.Location = New Point(49, 286)
            Me.pictureBox.Margin = New Padding(5, 5, 5, 5)
            Me.pictureBox.Name = "pictureBox"
            Me.pictureBox.Size = New Size(128, 130)
            Me.pictureBox.TabIndex = 6
            Me.pictureBox.TabStop = False
            ' 
            ' ArtistsLargeImageList
            ' 
            Me.ArtistsLargeImageList.ImageStream = (CType(resources.GetObject("ArtistsLargeImageList.ImageStream"), ImageListStreamer))
            Me.ArtistsLargeImageList.TransparentColor = Color.Transparent
            Me.ArtistsLargeImageList.Images.SetKeyName(0, "sting.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(1, "depeche.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(2, "sheryl.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(3, "clapton.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(4, "pink_floyd.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(5, "deepurple.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(6, "inxs.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(7, "badu.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(8, "nada_surf.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(9, "breeders.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(10, "concords.jpg")
            Me.ArtistsLargeImageList.Images.SetKeyName(11, "leona_lewis.jpg")
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.BackColor = Color.Transparent
            Me.radPanel1.ForeColor = Color.Black
            Me.radPanel1.Location = New Point(738, 144)
            Me.radPanel1.Margin = New Padding(0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New Size(35, 28)
            Me.radPanel1.TabIndex = 7
            Me.radPanel1.Visible = False
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' buttonSortAscending
            ' 
            Me.buttonSortAscending.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.buttonSortAscending.BackColor = Color.Transparent
            Me.buttonSortAscending.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.buttonSortAscending.ForeColor = Color.Black
            Me.buttonSortAscending.Image = (CType(resources.GetObject("buttonSortAscending.Image"), Image))
            Me.buttonSortAscending.ImageAlignment = ContentAlignment.MiddleCenter
            Me.buttonSortAscending.Location = New Point(292, 17)
            Me.buttonSortAscending.Margin = New Padding(5, 5, 5, 5)
            Me.buttonSortAscending.MinimumSize = New Size(0, 54)
            Me.buttonSortAscending.Name = "buttonSortAscending"
            ' 
            ' 
            ' 
            Me.buttonSortAscending.RootElement.AutoToolTip = True
            Me.buttonSortAscending.RootElement.MinSize = New Size(0, 54)
            Me.buttonSortAscending.Size = New Size(42, 54)
            Me.buttonSortAscending.TabIndex = 8
            Me.buttonSortAscending.Text = "radButton1"
            CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image"), Image))
            CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = ContentAlignment.MiddleCenter
            CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "radButton1"
            CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.Transparent
            CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = Color.Transparent
            CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = Color.Transparent
            CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.Transparent
            CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' buttonSortDescending
            ' 
            Me.buttonSortDescending.Anchor = (CType((AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles))
            Me.buttonSortDescending.BackColor = Color.Transparent
            Me.buttonSortDescending.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.buttonSortDescending.ForeColor = Color.Black
            Me.buttonSortDescending.Image = (CType(resources.GetObject("buttonSortDescending.Image"), Image))
            Me.buttonSortDescending.ImageAlignment = ContentAlignment.MiddleCenter
            Me.buttonSortDescending.Location = New Point(344, 17)
            Me.buttonSortDescending.Margin = New Padding(5, 5, 5, 5)
            Me.buttonSortDescending.MinimumSize = New Size(0, 54)
            Me.buttonSortDescending.Name = "buttonSortDescending"
            ' 
            ' 
            ' 
            Me.buttonSortDescending.RootElement.AutoToolTip = True
            Me.buttonSortDescending.RootElement.MinSize = New Size(0, 54)
            Me.buttonSortDescending.RootElement.ScreenTip = Me.radOffice2007ScreenTip1.ScreenTipElement
            Me.buttonSortDescending.RootElement.ShouldPaint = True
            Me.buttonSortDescending.Size = New Size(42, 54)
            Me.buttonSortDescending.TabIndex = 9
            Me.buttonSortDescending.Text = "radButton2"
            CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image1"), Image))
            CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = ContentAlignment.MiddleCenter
            CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "radButton2"
            CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = Color.Transparent
            CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = Color.Transparent
            CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = Color.Transparent
            CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = Color.Transparent
            CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radOffice2007ScreenTip1
            ' 
            Me.radOffice2007ScreenTip1.CaptionVisible = True
            Me.radOffice2007ScreenTip1.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
            Me.radOffice2007ScreenTip1.FooterVisible = False
            Me.radOffice2007ScreenTip1.Location = New Point(0, 0)
            Me.radOffice2007ScreenTip1.Name = "radOffice2007ScreenTip1"
            ' 
            ' 
            ' 
            Me.radOffice2007ScreenTip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            ' 
            ' 
            ' 
            Me.radOffice2007ScreenTip1.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
            Me.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
            Me.radOffice2007ScreenTip1.ScreenTipElement.TipSize = New Size(0, 0)
            Me.radOffice2007ScreenTip1.Size = New Size(107, 43)
            Me.radOffice2007ScreenTip1.TabIndex = 0
            Me.radOffice2007ScreenTip1.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
            CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Sort Descending"
            ' 
            ' radPanelDemoHolder
            ' 
            Me.radPanelDemoHolder.BackColor = Color.Transparent
            Me.radPanelDemoHolder.BackgroundImage = My.Resources.ComboFirstLookBG
            Me.radPanelDemoHolder.BackgroundImageLayout = ImageLayout.Stretch
            Me.radPanelDemoHolder.Controls.Add(Me.tableLayoutPanel1)
            Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
            Me.radPanelDemoHolder.Controls.Add(Me.lblSelectedSong)
            Me.radPanelDemoHolder.Controls.Add(Me.pictureBox)
            Me.radPanelDemoHolder.ForeColor = Color.Black
            Me.radPanelDemoHolder.Location = New Point(0, 0)
            Me.radPanelDemoHolder.Margin = New Padding(5, 5, 5, 5)
            Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
            Me.radPanelDemoHolder.Size = New Size(1000, 661)
            Me.radPanelDemoHolder.TabIndex = 10
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 5
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.95965F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5.48614F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5.48614F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.55813F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.50994F))
            Me.tableLayoutPanel1.Controls.Add(Me.cmbArtist, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.cmbSong, 4, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.cmbAlbum, 3, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.buttonSortDescending, 2, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.buttonSortAscending, 1, 0)
            Me.tableLayoutPanel1.Location = New Point(20, 144)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 1
            Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Size = New Size(959, 88)
            Me.tableLayoutPanel1.TabIndex = 10
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.BackColor = Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
            Me.BackgroundImageLayout = ImageLayout.None
            Me.Controls.Add(Me.radPanelDemoHolder)
            Me.Location = New Point(15, 15)
            Me.Name = "Form1"
            Me.Size = New Size(2653, 1464)
            Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.cmbArtist, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.musicCollectionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.musicCollectionDataSet.AlbumsDataTableProperty, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.musicCollectionDataSet.SongsDataTableProperty, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbAlbum, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.artistsAlbumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbSong, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.albumsSongsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblSelectedSong, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonSortAscending, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonSortDescending, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.radPanelDemoHolder.PerformLayout()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub



#End Region

        Private cmbArtist As Telerik.WinControls.UI.RadDropDownList
        Private cmbAlbum As Telerik.WinControls.UI.RadDropDownList
        Private cmbSong As Telerik.WinControls.UI.RadDropDownList
        Private lblSelectedSong As Telerik.WinControls.UI.RadLabel
        Private artistsBindingSource As BindingSource
        Private musicCollectionDataSetBindingSource As BindingSource
        Private musicCollectionDataSet As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet
        Private artistsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
        Private artistsAlbumsBindingSource As BindingSource
        Private albumsSongsBindingSource As BindingSource
        Private albumsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Private songsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter
        Private ArtistsImageList As ImageList
        Private pictureBox As PictureBox
        Private ArtistsLargeImageList As ImageList
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private buttonSortAscending As Telerik.WinControls.UI.RadButton
        Private buttonSortDescending As Telerik.WinControls.UI.RadButton
        Private radOffice2007ScreenTip1 As Telerik.WinControls.UI.RadOffice2007ScreenTip
        Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
    End Class
End Namespace
