using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.DataRelation
{
	/// <summary>
	/// RadTreeView example
	/// </summary>
    public partial class Form1 : TreeExamplesControl
	{
        private Bitmap bottomRightBitmap = Resources.TV_music;
        private BindingSource listAlbumsBindingSource = new BindingSource();
        private BindingSource listSongsBindingSource = new BindingSource();
        private bool internalUpdate = false;
       
        public Form1()
		{
			InitializeComponent();
            this.listAlbumsBindingSource.CurrentChanged += new EventHandler(listAlbumsBindingSource_CurrentChanged);
            this.listSongsBindingSource.CurrentChanged += new EventHandler(listSongsBindingSource_CurrentChanged);
            this.radTreeView1.SelectedNodeChanging += new RadTreeView.RadTreeViewCancelEventHandler(radTreeView1_SelectedNodeChanging);
            this.radTreeView1.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(radTreeView1_SelectedNodeChanged);
            this.radTreeView1.AllowDragDrop = true;

			this.SelectedControl = this.radTreeView1;
		}

        protected override void WireEvents()
        {
            this.radTreeView1.NodeExpandedChanging += new Telerik.WinControls.UI.RadTreeView.RadTreeViewCancelEventHandler(this.radTreeView1_NodeExpandedChanging);
        }

        void radTreeView1_SelectedNodeChanging(object sender, RadTreeViewCancelEventArgs e)
        {
            e.Cancel = this.internalUpdate;
        }

        void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                return;
            }

            if (e.Node.Level == 1)
            {
                SyncSecondLevel(e);

                return;
            }

            SyncThreeLevel(e);
        }

        private void SyncSecondLevel(RadTreeViewEventArgs e)
        {
            this.internalUpdate = true;
            object artistID = ((DataRowView)e.Node.Parent.DataBoundItem)["ArtistID"];
            int parentIndex = this.artistsBindingSource.Find("ArtistID", artistID);
            if (parentIndex >= 0)
            {
                this.artistsBindingSource.Position = parentIndex;
            }

            object albumID = ((DataRowView)e.Node.DataBoundItem)["AlbumID"];
            int index = this.listAlbumsBindingSource.Find("AlbumID", albumID);
            if (index >= 0)
            {
                this.listAlbumsBindingSource.Position = index;
            }
            this.internalUpdate = false;
        }

        private void SyncThreeLevel(RadTreeViewEventArgs e)
        {
            this.internalUpdate = true;
            object artistID = ((DataRowView)e.Node.Parent.Parent.DataBoundItem)["ArtistID"];
            int parentIndex = this.artistsBindingSource.Find("ArtistID", artistID);
            if (parentIndex >= 0)
            {
                this.artistsBindingSource.Position = parentIndex;
            }

            object albumID = ((DataRowView)e.Node.Parent.DataBoundItem)["AlbumID"];
            int index = this.listAlbumsBindingSource.Find("AlbumID", albumID);
            if (index >= 0)
            {
                this.listAlbumsBindingSource.Position = index;
            }

            object songID = ((DataRowView)e.Node.DataBoundItem)["SongID"];
            int songIndex = this.listSongsBindingSource.Find("SongID", songID);
            if (songIndex >= 0)
            {
                this.listSongsBindingSource.Position = songIndex;
            }
            this.internalUpdate = false;
        }

        void listAlbumsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.listAlbumsBindingSource.Current == null)
            {
                return;
            }

            object albumID = ((DataRowView)this.listAlbumsBindingSource.Current)["AlbumID"];
            int index = this.albumsBindingSource.Find("AlbumID", albumID);
            if (index >= 0)
            {
                this.albumsBindingSource.Position = index;
            }
        }

        void listSongsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.listSongsBindingSource.Current == null)
            {
                return;
            }

            object songID = ((DataRowView)this.listSongsBindingSource.Current)["SongID"];
            int index = this.songsBindingSource.Find("SongID", songID);
            if (index >= 0)
            {
                this.songsBindingSource.Position = index;
            }
        }

        public override RadTreeView TreeControl
        {
            get { return this.radTreeView1; }
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override string HeaderText
        {
            get { return "Music Collection"; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radTreeView1.AllowEdit = false;
            this.radTreeView1.AllowAdd = false;
            this.radTreeView1.AllowRemove = false;

            this.artistsTableAdapter.Fill(musicCollectionDataSet.Artists);
            this.albumsTableAdapter.Fill(musicCollectionDataSet.Albums);
            this.songsTableAdapter.Fill(musicCollectionDataSet.Songs);

            this.listAlbumsBindingSource.DataMember = "ArtistsAlbums";
            this.listAlbumsBindingSource.DataSource = this.artistsBindingSource;
            this.radListLevelTwo.DisplayMember = "AlbumName";
            this.radListLevelTwo.DataSource = this.listAlbumsBindingSource;

            this.listSongsBindingSource.DataMember = "AlbumsSongs";
            this.listSongsBindingSource.DataSource = this.listAlbumsBindingSource;
            this.radListLevelThree.DisplayMember = "SongName";
            this.radListLevelThree.DataSource = this.listSongsBindingSource;

            using (this.radTreeView1.DeferRefresh())
            {
                this.radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID");
                this.radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID");
                this.radTreeView1.DisplayMember = "ArtistName";
                this.radTreeView1.DataSource = artistsBindingSource;
            }
        }

        private void radTreeView1_NodeExpandedChanging(object sender, Telerik.WinControls.UI.RadTreeViewCancelEventArgs e)
        {
            RadTreeNodeCollection nodes = e.Node.Nodes;
            foreach (RadTreeNode node in nodes)
            {
                node.ImageIndex = node.Level;
            }
        }
    }
}

