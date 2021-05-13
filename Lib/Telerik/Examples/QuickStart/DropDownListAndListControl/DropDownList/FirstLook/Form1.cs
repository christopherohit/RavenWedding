using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using System.IO;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.FirstLook
{
    /// <summary>
    /// RadDropDownList example: Music Collection
    /// </summary>
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

			this.BackColor = Color.Transparent;
            this.cmbArtist.DropDownAnimationEnabled = false;
            this.cmbArtist.AutoSizeItems = true;
			this.cmbArtist.ItemDataBound += new ListItemDataBoundEventHandler(cmbArtist_ItemDataBound);
            this.cmbArtist.DropDownMinSize = new Size(0, 200);
			this.artistsBindingSource.CurrentItemChanged += new EventHandler(artistsBindingSource_CurrentItemChanged);
            this.buttonSortAscending.ThemeClassName = String.Empty;
            this.buttonSortDescending.ThemeClassName = String.Empty;
           
			this.songsTableAdapter.Fill(this.musicCollectionDataSet.Songs);
			this.artistsTableAdapter.Fill(this.musicCollectionDataSet.Artists);
			this.albumsTableAdapter.Fill(this.musicCollectionDataSet.Albums);

            this.SelectedControl = this.cmbArtist;

            this.cmbArtist.SelectedIndex = 0;
            this.cmbArtist.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbAlbum.SelectedIndex = 0;
            this.cmbAlbum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbSong.SelectedIndex = 0;
            this.cmbSong.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
		}
       
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    if (this.radPanelDemoHolder != null)
        //    {
        //        float xCoord = ((float)(this.Width - this.radPanelDemoHolder.Width)) / 2;
        //        float yCoord = ((float)(this.Height - this.radPanelDemoHolder.Height)) / 2;

        //        this.radPanelDemoHolder.Location = Point.Round(new PointF(xCoord, yCoord));
        //    }

        //    base.OnSizeChanged(e);
        //}		

        void artistsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            int imageIndex = (int)(this.artistsBindingSource.Current as DataRowView)["ImageIndex"];

            if (imageIndex >= 0 && imageIndex < this.ArtistsLargeImageList.Images.Count)
            {
                this.pictureBox.Image = this.ArtistsLargeImageList.Images[imageIndex];
            }

            this.cmbAlbum.SelectedIndex = 0;
            this.cmbSong.SelectedIndex = 0;
        }

        void cmbArtist_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
		{
            RadListDataItem item = args.NewItem;
            object dataBoundItem = item.DataBoundItem;
            item.TextImageRelation = TextImageRelation.ImageBeforeText;
            PropertyDescriptor desc = TypeDescriptor.GetProperties(dataBoundItem).Find("ImageIndex", false);
            item.Image = this.cmbArtist.ImageList.Images[(int)desc.GetValue(dataBoundItem)];
		}

        void cmbArtist_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            StringBuilder selectedSongInfo = new StringBuilder();
            selectedSongInfo.AppendLine(this.cmbArtist.Text);
            selectedSongInfo.AppendLine(this.cmbAlbum.Text);
            selectedSongInfo.AppendLine(this.cmbSong.Text);

            this.lblSelectedSong.Text = selectedSongInfo.ToString(); 
        }

		private void cmbAlbum_TextChanged(object sender, EventArgs e)
		{
			StringBuilder selectedSongInfo = new StringBuilder();
			selectedSongInfo.AppendLine(this.cmbArtist.Text);
			selectedSongInfo.AppendLine(this.cmbAlbum.Text);
			selectedSongInfo.AppendLine(this.cmbSong.Text);

			this.lblSelectedSong.Text = selectedSongInfo.ToString();
		}

		private void cmbSong_TextChanged(object sender, EventArgs e)
		{
			StringBuilder selectedSongInfo = new StringBuilder();
			selectedSongInfo.AppendLine(this.cmbArtist.Text);
			selectedSongInfo.AppendLine(this.cmbAlbum.Text);
			selectedSongInfo.AppendLine(this.cmbSong.Text);

			this.lblSelectedSong.Text = selectedSongInfo.ToString();
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.AddSortingButtons(); 
        }

        private void AddSortingButtons()
        {
            buttonSortAscending.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(buttonSortAscending_ToolTipTextNeeded);
            buttonSortAscending.MouseClick+=new MouseEventHandler(SortAsc);
            buttonSortDescending.ToolTipTextNeeded += new Telerik.WinControls.ToolTipTextNeededEventHandler(buttonSortDescending_ToolTipTextNeeded);
            buttonSortDescending.MouseClick += new MouseEventHandler( SortDesc );
        }

        void buttonSortDescending_ToolTipTextNeeded(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Sort Descending";
        }

        void buttonSortAscending_ToolTipTextNeeded(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Sort Ascending";
        }

        void SortDesc( object sender, MouseEventArgs e )
        {
            string selectedItem = this.cmbArtist.SelectedItem.ToString();
            this.artistsBindingSource.Sort = this.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName + " desc";
            this.cmbArtist.SelectedIndex = this.cmbArtist.FindStringExact(selectedItem);
        }

        void SortAsc( object sender, MouseEventArgs e )
        {
            string selectedItem = this.cmbArtist.SelectedItem.ToString();
            this.artistsBindingSource.Sort = this.musicCollectionDataSet.Artists.ArtistNameColumn.ColumnName + " asc";
            this.cmbArtist.SelectedIndex = this.cmbArtist.FindStringExact(selectedItem);
        }

        protected override void WireEvents()
        {
            this.cmbArtist.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbArtist_SelectedIndexChanged);
        }
	}
}
