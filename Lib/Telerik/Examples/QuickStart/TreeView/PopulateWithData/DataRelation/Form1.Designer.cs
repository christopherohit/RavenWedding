namespace Telerik.Examples.WinControls.TreeView.PopulateWithData.DataRelation
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
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicCollectionDataSet = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter();
            this.albumsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter();
            this.songsTableAdapter = new Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter();
            this.radListLevelOne = new Telerik.WinControls.UI.RadListControl();
            this.radListLevelTwo = new Telerik.WinControls.UI.RadListControl();
            this.radListLevelThree = new Telerik.WinControls.UI.RadListControl();
            this.radGroupLevelThree = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupLevelTwo = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupLevelOne = new Telerik.WinControls.UI.RadGroupBox();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableAlbumsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableSongsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListLevelOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListLevelTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListLevelThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupLevelThree)).BeginInit();
            this.radGroupLevelThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupLevelTwo)).BeginInit();
            this.radGroupLevelTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupLevelOne)).BeginInit();
            this.radGroupLevelOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupLevelOne);
            this.settingsPanel.Controls.Add(this.radGroupLevelTwo);
            this.settingsPanel.Controls.Add(this.radGroupLevelThree);
            this.settingsPanel.Location = new System.Drawing.Point(1111, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);

            this.settingsPanel.Controls.SetChildIndex(this.radGroupLevelThree, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupLevelTwo, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupLevelOne, 0);
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.musicCollectionDataSet;
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
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicCollectionDataSet;
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.musicCollectionDataSet;
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
            // radListLevelOne
            // 
            this.radListLevelOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radListLevelOne.DataSource = this.artistsBindingSource;
            this.radListLevelOne.DisplayMember = "ArtistName";
            this.radListLevelOne.Location = new System.Drawing.Point(6, 20);
            this.radListLevelOne.Name = "radListLevelOne";
            this.radListLevelOne.Size = new System.Drawing.Size(168, 85);
            this.radListLevelOne.TabIndex = 7;
            // 
            // radListLevelTwo
            // 
            this.radListLevelTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radListLevelTwo.Location = new System.Drawing.Point(6, 20);
            this.radListLevelTwo.Name = "radListLevelTwo";
            this.radListLevelTwo.Size = new System.Drawing.Size(168, 85);
            this.radListLevelTwo.TabIndex = 7;
            // 
            // radListLevelThree
            // 
            this.radListLevelThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radListLevelThree.Location = new System.Drawing.Point(6, 22);
            this.radListLevelThree.Name = "radListLevelThree";
            this.radListLevelThree.Size = new System.Drawing.Size(168, 187);
            this.radListLevelThree.TabIndex = 7;
            // 
            // radGroupLevelThree
            // 
            this.radGroupLevelThree.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupLevelThree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupLevelThree.Controls.Add(this.radListLevelThree);
            this.radGroupLevelThree.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupLevelThree.HeaderText = " Third Level Items ";
            this.radGroupLevelThree.Location = new System.Drawing.Point(10, 265);
            this.radGroupLevelThree.Name = "radGroupLevelThree";
            this.radGroupLevelThree.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupLevelThree.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupLevelThree.Size = new System.Drawing.Size(180, 218);
            this.radGroupLevelThree.TabIndex = 8;
            this.radGroupLevelThree.Text = " Third Level Items ";
            // 
            // radGroupLevelTwo
            // 
            this.radGroupLevelTwo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupLevelTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupLevelTwo.Controls.Add(this.radListLevelTwo);
            this.radGroupLevelTwo.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupLevelTwo.HeaderText = " Second Level Items ";
            this.radGroupLevelTwo.Location = new System.Drawing.Point(10, 138);
            this.radGroupLevelTwo.Name = "radGroupLevelTwo";
            this.radGroupLevelTwo.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupLevelTwo.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupLevelTwo.Size = new System.Drawing.Size(180, 116);
            this.radGroupLevelTwo.TabIndex = 8;
            this.radGroupLevelTwo.Text = " Second Level Items ";
            // 
            // radGroupLevelOne
            // 
            this.radGroupLevelOne.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupLevelOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupLevelOne.Controls.Add(this.radListLevelOne);
            this.radGroupLevelOne.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupLevelOne.HeaderText = " First Level Items ";
            this.radGroupLevelOne.Location = new System.Drawing.Point(10, 6);
            this.radGroupLevelOne.Name = "radGroupLevelOne";
            this.radGroupLevelOne.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupLevelOne.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupLevelOne.Size = new System.Drawing.Size(180, 116);
            this.radGroupLevelOne.TabIndex = 8;
            this.radGroupLevelOne.Text = " First Level Items ";
            // 
            // radTreeView1
            // 
            this.radTreeView1.ImageIndex = 0;
            this.radTreeView1.ImageList = this.imageList1;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(314, 475);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 1;
            this.radTreeView1.Text = "radTreeView1";
         
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user_orange.png");
            this.imageList1.Images.SetKeyName(1, "cd_16.png");
            this.imageList1.Images.SetKeyName(2, "music_16.png");
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Location = new System.Drawing.Point(6, 8);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(368, 30);
            this.radPanel1.TabIndex = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 2;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(233)))));
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel3.Location = new System.Drawing.Point(8, 2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(120, 24);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Music Collection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1334, 671);

            this.Controls.SetChildIndex(this.radTreeView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableAlbumsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet.TableSongsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListLevelOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListLevelTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListLevelThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupLevelThree)).EndInit();
            this.radGroupLevelThree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupLevelTwo)).EndInit();
            this.radGroupLevelTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupLevelOne)).EndInit();
            this.radGroupLevelOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource artistsBindingSource;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet musicCollectionDataSet;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
		private System.Windows.Forms.BindingSource albumsBindingSource;
		private System.Windows.Forms.BindingSource songsBindingSource;
		private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
        private Telerik.WinControls.UI.RadListControl radListLevelOne;
        private Telerik.WinControls.UI.RadListControl radListLevelTwo;
        private Telerik.WinControls.UI.RadListControl radListLevelThree;
        private Telerik.WinControls.UI.RadGroupBox radGroupLevelThree;
        private Telerik.WinControls.UI.RadGroupBox radGroupLevelTwo;
        private Telerik.WinControls.UI.RadGroupBox radGroupLevelOne;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
	}
}
