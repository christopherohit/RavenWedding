using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Carousel.FirstLook
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
            Telerik.WinControls.UI.CarouselBezierPath carouselBezierPath1 = new Telerik.WinControls.UI.CarouselBezierPath();
            Telerik.WinControls.ThemeSource themeSource2 = new Telerik.WinControls.ThemeSource();
            this.radCarouselAlbums = new Telerik.WinControls.UI.RadCarousel();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.albumsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.radBtnDownloads = new Telerik.WinControls.UI.RadButton();
            this.radBtnArtists = new Telerik.WinControls.UI.RadButton();
            this.radBtnAlbums = new Telerik.WinControls.UI.RadButton();
            this.radBtnSongs = new Telerik.WinControls.UI.RadButton();
            this.radComboSearch = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radCarouselAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnDownloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarouselAlbums
            // 
            this.radCarouselAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radCarouselAlbums.BackColor = System.Drawing.Color.Transparent;
            this.radCarouselAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            carouselBezierPath1.CtrlPoint1 = new Telerik.WinControls.UI.Point3D(12.278630460448643, 48.166259168704158, 300);
            carouselBezierPath1.CtrlPoint2 = new Telerik.WinControls.UI.Point3D(87.839433293978743, 47.677261613691932, 300);
            carouselBezierPath1.FirstPoint = new Telerik.WinControls.UI.Point3D(6.3754427390791024, 50.8557457212714, -400);
            carouselBezierPath1.LastPoint = new Telerik.WinControls.UI.Point3D(93.860684769775673, 51.100244498777506, -400);
            carouselBezierPath1.ZScale = 200;
            this.radCarouselAlbums.CarouselPath = carouselBezierPath1;
            this.radCarouselAlbums.DataSource = this.albumsBindingSource;
            this.radCarouselAlbums.ForeColor = System.Drawing.Color.White;
            this.radCarouselAlbums.Location = new System.Drawing.Point(2, 161);
            this.radCarouselAlbums.Name = "radCarouselAlbums";
            this.radCarouselAlbums.NavigationButtonsOffset = new System.Drawing.Size(80, 20);
            // 
            // 
            // 
            this.radCarouselAlbums.RootElement.ForeColor = System.Drawing.Color.White;
            this.radCarouselAlbums.SelectedIndex = -1;
            this.radCarouselAlbums.Size = new System.Drawing.Size(845, 404);
            this.radCarouselAlbums.TabIndex = 0;
            this.radCarouselAlbums.ThemeName = "ControlDefault";
            this.radCarouselAlbums.VisibleItemCount = 7;


            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarouselAlbums.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarouselAlbums.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarouselAlbums.GetChildAt(0).GetChildAt(3))).Image = global::Telerik.Examples.WinControls.Properties.Resources.carousel_leftArrow;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarouselAlbums.GetChildAt(0).GetChildAt(4))).Image = global::Telerik.Examples.WinControls.Properties.Resources.carousel_rightArrow;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // musicCollectionDataSet
            // 
            this.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet";
            this.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radThemeManager1
            // 

            themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource;
            themeSource2.ThemeLocation = Telerik.WinControls.VBExamplesHelper.StripPath("Telerik.Examples.WinControls.Carousel.FirstLook.ButtonMusicLibrary.xml");           
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource2});
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.BackColor = System.Drawing.Color.Transparent;
            this.radTitleBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radTitleBar1.Text = "Music Library Demo";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(2, 2);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(846, 27);
            this.radTitleBar1.TabIndex = 2;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "radTitleBar1";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2))).Text = "Music Library Demo";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2))).Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);            
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Image = global::Telerik.Examples.WinControls.Properties.Resources.FL_min;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, 0, -2, 0);
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Name = "MinimizeButtonFill";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).Image = global::Telerik.Examples.WinControls.Properties.Resources.FL_Max;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0, 0, -2, 0);
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(0))).Name = "MaximizeButtonFill";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3))).Image = global::Telerik.Examples.WinControls.Properties.Resources.FL_Close;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(0))).Name = "CloseButtonFill";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBtnDownloads
            // 
            this.radBtnDownloads.AllowShowFocusCues = true;
            this.radBtnDownloads.BackColor = System.Drawing.Color.Transparent;
            this.radBtnDownloads.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnDownloads.ForeColor = System.Drawing.Color.Black;
            this.radBtnDownloads.Location = new System.Drawing.Point(489, 47);
            this.radBtnDownloads.Name = "radBtnDownloads";
            // 
            // 
            // 
            this.radBtnDownloads.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radBtnDownloads.Size = new System.Drawing.Size(119, 34);
            this.radBtnDownloads.TabIndex = 3;
            this.radBtnDownloads.Text = "Downloads";
            this.radBtnDownloads.ThemeName = "MusicLibrary";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radBtnDownloads.GetChildAt(0))).Text = "Downloads";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radBtnDownloads.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radBtnDownloads.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radBtnDownloads.GetChildAt(0).GetChildAt(3))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radBtnArtists
            // 
            this.radBtnArtists.AllowShowFocusCues = true;
            this.radBtnArtists.BackColor = System.Drawing.Color.Transparent;
            this.radBtnArtists.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnArtists.ForeColor = System.Drawing.Color.Black;
            this.radBtnArtists.Location = new System.Drawing.Point(619, 47);
            this.radBtnArtists.Name = "radBtnArtists";
            // 
            // 
            // 
            this.radBtnArtists.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radBtnArtists.Size = new System.Drawing.Size(77, 34);
            this.radBtnArtists.TabIndex = 3;
            this.radBtnArtists.Text = "Artists";
            this.radBtnArtists.ThemeName = "MusicLibrary";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radBtnArtists.GetChildAt(0))).Text = "Artists";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radBtnArtists.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radBtnAlbums
            // 
            this.radBtnAlbums.AllowShowFocusCues = true;
            this.radBtnAlbums.BackColor = System.Drawing.Color.Transparent;
            this.radBtnAlbums.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnAlbums.ForeColor = System.Drawing.Color.Black;
            this.radBtnAlbums.Location = new System.Drawing.Point(705, 47);
            this.radBtnAlbums.Name = "radBtnAlbums";
            // 
            // 
            // 
            this.radBtnAlbums.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radBtnAlbums.Size = new System.Drawing.Size(77, 34);
            this.radBtnAlbums.TabIndex = 3;
            this.radBtnAlbums.Text = "Albums";
            this.radBtnAlbums.ThemeName = "MusicLibrary";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radBtnAlbums.GetChildAt(0))).Text = "Albums";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radBtnAlbums.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radBtnSongs
            // 
            this.radBtnSongs.AllowShowFocusCues = true;
            this.radBtnSongs.BackColor = System.Drawing.Color.Transparent;
            this.radBtnSongs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnSongs.ForeColor = System.Drawing.Color.Black;
            this.radBtnSongs.Location = new System.Drawing.Point(786, 47);
            this.radBtnSongs.Name = "radBtnSongs";
            // 
            // 
            // 
            this.radBtnSongs.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radBtnSongs.Size = new System.Drawing.Size(67, 34);
            this.radBtnSongs.TabIndex = 3;
            this.radBtnSongs.Text = "Songs";
            this.radBtnSongs.ThemeName = "MusicLibrary";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radBtnSongs.GetChildAt(0))).Text = "Songs";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radBtnSongs.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radComboSearch
            // 
            this.radComboSearch.Location = new System.Drawing.Point(642, 113);
            this.radComboSearch.Name = "radComboSearch";
            this.radComboSearch.NullText = "Search...";
            // 
            // 
            // 
            this.radComboSearch.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboSearch.Size = new System.Drawing.Size(180, 20);
            this.radComboSearch.TabIndex = 4;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.carousel_first_look_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(850, 620);
            this.Controls.Add(this.radComboSearch);
            this.Controls.Add(this.radBtnSongs);
            this.Controls.Add(this.radBtnAlbums);
            this.Controls.Add(this.radBtnArtists);
            this.Controls.Add(this.radBtnDownloads);
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.radCarouselAlbums);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 620);
            this.MinimumSize = new System.Drawing.Size(850, 620);
            this.Name = "Form1";
            this.Shape = this.roundRectShape1;
            this.Text = "Music Library Demo";
            ((System.ComponentModel.ISupportInitialize)(this.radCarouselAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnDownloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarouselAlbums;
        private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet musicCollectionDataSet;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadButton radBtnDownloads;
        private Telerik.WinControls.UI.RadButton radBtnArtists;
        private Telerik.WinControls.UI.RadButton radBtnAlbums;
        private Telerik.WinControls.UI.RadButton radBtnSongs;
        private Telerik.WinControls.UI.RadDropDownList radComboSearch;        
    }
}
