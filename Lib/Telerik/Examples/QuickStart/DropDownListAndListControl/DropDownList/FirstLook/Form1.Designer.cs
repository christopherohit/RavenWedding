namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.FirstLook
{
	partial class Form1
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbArtist = new Telerik.WinControls.UI.RadDropDownList();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet();
            this.ArtistsImageList = new System.Windows.Forms.ImageList(this.components);
            this.cmbAlbum = new Telerik.WinControls.UI.RadDropDownList();
            this.artistsAlbumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSong = new Telerik.WinControls.UI.RadDropDownList();
            this.albumsSongsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectedSong = new Telerik.WinControls.UI.RadLabel();
            this.artistsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter();
            this.albumsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            this.songsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ArtistsLargeImageList = new System.Windows.Forms.ImageList(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.buttonSortAscending = new Telerik.WinControls.UI.RadButton();
            this.buttonSortDescending = new Telerik.WinControls.UI.RadButton();
            this.radOffice2007ScreenTip1 = new Telerik.WinControls.UI.RadOffice2007ScreenTip();
            this.radPanelDemoHolder = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableAlbumsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableSongsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsAlbumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsSongsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectedSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSortAscending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSortDescending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1010, 1);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(312, 1130);
            this.settingsPanel.Size = new System.Drawing.Size(312, 1130);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // cmbArtist
            // 
            this.cmbArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArtist.AutoCompleteDisplayMember = "ArtistName";
            this.cmbArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArtist.DataSource = this.artistsBindingSource;
            this.cmbArtist.DisplayMember = "ArtistName";
            this.cmbArtist.DropDownHeight = 166;
            this.cmbArtist.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.cmbArtist.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbArtist.ImageList = this.ArtistsImageList;
            this.cmbArtist.Location = new System.Drawing.Point(5, 32);
            this.cmbArtist.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.NullText = "Select Artist";
            this.cmbArtist.ShowImageInEditorArea = false;
            this.cmbArtist.Size = new System.Drawing.Size(277, 24);
            this.cmbArtist.TabIndex = 1;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.musicCollectionDataSetBindingSource;
            // 
            // musicCollectionDataSetBindingSource
            // 
            this.musicCollectionDataSetBindingSource.DataSource = this.musicCollectionDataSet;
            this.musicCollectionDataSetBindingSource.Position = 0;
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 
            // 
            this.musicCollectionDataSet.TableAlbumsDataTable.TableName = "AlbumsDataTable";
            // 
            // 
            // 
            this.musicCollectionDataSet.TableSongsDataTable.TableName = "SongsDataTable";
            // 
            // ArtistsImageList
            // 
            this.ArtistsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ArtistsImageList.ImageStream")));
            this.ArtistsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ArtistsImageList.Images.SetKeyName(0, "smallSting.jpg");
            this.ArtistsImageList.Images.SetKeyName(1, "smallDepeche.jpg");
            this.ArtistsImageList.Images.SetKeyName(2, "smallSheryl.jpg");
            this.ArtistsImageList.Images.SetKeyName(3, "smallClapton.jpg");
            this.ArtistsImageList.Images.SetKeyName(4, "smallFloyd.jpg");
            this.ArtistsImageList.Images.SetKeyName(5, "smallPurple.jpg");
            this.ArtistsImageList.Images.SetKeyName(6, "smallINXS.jpg");
            this.ArtistsImageList.Images.SetKeyName(7, "smallBadu.jpg");
            this.ArtistsImageList.Images.SetKeyName(8, "smallNada.jpg");
            this.ArtistsImageList.Images.SetKeyName(9, "smallBreeders.jpg");
            this.ArtistsImageList.Images.SetKeyName(10, "smallConchords.jpg");
            this.ArtistsImageList.Images.SetKeyName(11, "smallLeona.jpg");
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlbum.AutoCompleteDisplayMember = "AlbumName";
            this.cmbAlbum.DataSource = this.artistsAlbumsBindingSource;
            this.cmbAlbum.DisplayMember = "AlbumName";
            this.cmbAlbum.DropDownHeight = 166;
            this.cmbAlbum.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.cmbAlbum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbAlbum.Location = new System.Drawing.Point(396, 32);
            this.cmbAlbum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.NullText = "Select Album";
            this.cmbAlbum.Size = new System.Drawing.Size(263, 24);
            this.cmbAlbum.TabIndex = 2;
            // 
            // artistsAlbumsBindingSource
            // 
            this.artistsAlbumsBindingSource.DataMember = "ArtistsAlbums";
            this.artistsAlbumsBindingSource.DataSource = this.artistsBindingSource;
            // 
            // cmbSong
            // 
            this.cmbSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSong.AutoCompleteDisplayMember = "SongName";
            this.cmbSong.DataSource = this.albumsSongsBindingSource;
            this.cmbSong.DisplayMember = "SongName";
            this.cmbSong.DropDownHeight = 166;
            this.cmbSong.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.cmbSong.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbSong.Location = new System.Drawing.Point(669, 32);
            this.cmbSong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbSong.Name = "cmbSong";
            this.cmbSong.NullText = "Select Song";
            this.cmbSong.Size = new System.Drawing.Size(285, 24);
            this.cmbSong.TabIndex = 3;
            // 
            // albumsSongsBindingSource
            // 
            this.albumsSongsBindingSource.DataMember = "AlbumsSongs";
            this.albumsSongsBindingSource.DataSource = this.artistsAlbumsBindingSource;
            // 
            // lblSelectedSong
            // 
            this.lblSelectedSong.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedSong.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSelectedSong.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSelectedSong.Location = new System.Drawing.Point(200, 332);
            this.lblSelectedSong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblSelectedSong.Name = "lblSelectedSong";
            this.lblSelectedSong.Size = new System.Drawing.Size(2, 2);
            this.lblSelectedSong.TabIndex = 5;
            this.lblSelectedSong.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(49, 286);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 130);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // ArtistsLargeImageList
            // 
            this.ArtistsLargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ArtistsLargeImageList.ImageStream")));
            this.ArtistsLargeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ArtistsLargeImageList.Images.SetKeyName(0, "sting.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(1, "depeche.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(2, "sheryl.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(3, "clapton.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(4, "pink_floyd.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(5, "deepurple.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(6, "inxs.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(7, "badu.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(8, "nada_surf.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(9, "breeders.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(10, "concords.jpg");
            this.ArtistsLargeImageList.Images.SetKeyName(11, "leona_lewis.jpg");
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(738, 144);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(35, 28);
            this.radPanel1.TabIndex = 7;
            this.radPanel1.Visible = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // buttonSortAscending
            // 
            this.buttonSortAscending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortAscending.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortAscending.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.buttonSortAscending.ForeColor = System.Drawing.Color.Black;
            this.buttonSortAscending.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortAscending.Image")));
            this.buttonSortAscending.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSortAscending.Location = new System.Drawing.Point(292, 17);
            this.buttonSortAscending.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonSortAscending.MinimumSize = new System.Drawing.Size(0, 54);
            this.buttonSortAscending.Name = "buttonSortAscending";
            // 
            // 
            // 
            this.buttonSortAscending.RootElement.AutoToolTip = true;
            this.buttonSortAscending.RootElement.MinSize = new System.Drawing.Size(0, 54);
            this.buttonSortAscending.Size = new System.Drawing.Size(42, 54);
            this.buttonSortAscending.TabIndex = 8;
            this.buttonSortAscending.Text = "radButton1";
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortAscending.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortAscending.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortAscending.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortAscending.GetChildAt(0))).Text = "radButton1";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortAscending.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortAscending.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortAscending.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortAscending.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.buttonSortAscending.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortDescending.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortDescending.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.buttonSortDescending.ForeColor = System.Drawing.Color.Black;
            this.buttonSortDescending.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortDescending.Image")));
            this.buttonSortDescending.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSortDescending.Location = new System.Drawing.Point(344, 17);
            this.buttonSortDescending.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonSortDescending.MinimumSize = new System.Drawing.Size(0, 54);
            this.buttonSortDescending.Name = "buttonSortDescending";
            // 
            // 
            // 
            this.buttonSortDescending.RootElement.AutoToolTip = true;
            this.buttonSortDescending.RootElement.MinSize = new System.Drawing.Size(0, 54);
            this.buttonSortDescending.RootElement.ScreenTip = this.radOffice2007ScreenTip1.ScreenTipElement;
            this.buttonSortDescending.RootElement.ShouldPaint = true;
            this.buttonSortDescending.Size = new System.Drawing.Size(42, 54);
            this.buttonSortDescending.TabIndex = 9;
            this.buttonSortDescending.Text = "radButton2";
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortDescending.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortDescending.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortDescending.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonSortDescending.GetChildAt(0))).Text = "radButton2";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortDescending.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortDescending.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortDescending.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortDescending.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.buttonSortDescending.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.buttonSortDescending.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radOffice2007ScreenTip1
            // 
            this.radOffice2007ScreenTip1.CaptionVisible = true;
            this.radOffice2007ScreenTip1.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip1.FooterVisible = false;
            this.radOffice2007ScreenTip1.Location = new System.Drawing.Point(0, 0);
            this.radOffice2007ScreenTip1.Name = "radOffice2007ScreenTip1";
            // 
            // 
            // 
            this.radOffice2007ScreenTip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // 
            // 
            this.radOffice2007ScreenTip1.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            this.radOffice2007ScreenTip1.ScreenTipElement.TipSize = new System.Drawing.Size(0, 0);
            this.radOffice2007ScreenTip1.Size = new System.Drawing.Size(107, 43);
            this.radOffice2007ScreenTip1.TabIndex = 0;
            this.radOffice2007ScreenTip1.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "Sort Descending";
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.BackColor = System.Drawing.Color.Transparent;
            this.radPanelDemoHolder.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.ComboFirstLookBG;
            this.radPanelDemoHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPanelDemoHolder.Controls.Add(this.tableLayoutPanel1);
            this.radPanelDemoHolder.Controls.Add(this.radPanel1);
            this.radPanelDemoHolder.Controls.Add(this.lblSelectedSong);
            this.radPanelDemoHolder.Controls.Add(this.pictureBox);
            this.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(0, 0);
            this.radPanelDemoHolder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radPanelDemoHolder.Name = "radPanelDemoHolder";
            this.radPanelDemoHolder.Size = new System.Drawing.Size(1000, 661);
            this.radPanelDemoHolder.TabIndex = 10;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanelDemoHolder.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.95965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.48614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.48614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.55813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50994F));
            this.tableLayoutPanel1.Controls.Add(this.cmbArtist, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSong, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAlbum, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSortDescending, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSortAscending, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 88);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.radPanelDemoHolder);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2653, 1464);
            this.Controls.SetChildIndex(this.radPanelDemoHolder, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableAlbumsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableSongsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsAlbumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsSongsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSelectedSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSortAscending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSortDescending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

        

		#endregion

		private Telerik.WinControls.UI.RadDropDownList cmbArtist;
		private Telerik.WinControls.UI.RadDropDownList cmbAlbum;
        private Telerik.WinControls.UI.RadDropDownList cmbSong;
		private Telerik.WinControls.UI.RadLabel lblSelectedSong;
		private System.Windows.Forms.BindingSource artistsBindingSource;
		private System.Windows.Forms.BindingSource musicCollectionDataSetBindingSource;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet musicCollectionDataSet;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
		private System.Windows.Forms.BindingSource artistsAlbumsBindingSource;
		private System.Windows.Forms.BindingSource albumsSongsBindingSource;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
		private System.Windows.Forms.ImageList ArtistsImageList;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ImageList ArtistsLargeImageList;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton buttonSortAscending;
        private Telerik.WinControls.UI.RadButton buttonSortDescending;
        private Telerik.WinControls.UI.RadOffice2007ScreenTip radOffice2007ScreenTip1;
        private Telerik.WinControls.UI.RadPanel radPanelDemoHolder;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
    }
}
