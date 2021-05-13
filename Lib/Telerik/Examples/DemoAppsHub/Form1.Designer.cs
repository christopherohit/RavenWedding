using Telerik.WinControls.UI;
namespace DemoAppsHub
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.applicationsGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.bugTrackerTile = new Telerik.WinControls.UI.RadTileElement();
            this.fileExplorerTile = new Telerik.WinControls.UI.RadTileElement();
            this.rssReaderTile = new Telerik.WinControls.UI.RadTileElement();
            this.magnifierTile = new Telerik.WinControls.UI.RadTileElement();
            this.photoAlbumTile = new Telerik.WinControls.UI.RadLiveTileElement();
            this.toolsGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.qsfTile = new Telerik.WinControls.UI.RadTileElement();
            this.themeViewerTile = new Telerik.WinControls.UI.RadTileElement();
            this.vsbTile = new Telerik.WinControls.UI.RadTileElement();
            this.controlsGroups = new Telerik.WinControls.UI.TileGroupElement();
            this.gridTile = new Telerik.WinControls.UI.RadTileElement();
            this.listViewTile = new Telerik.WinControls.UI.RadTileElement();
            this.schedulerTile = new Telerik.WinControls.UI.RadTileElement();
            this.treeViewTile = new Telerik.WinControls.UI.RadTileElement();
            this.chartViewRotateTile = new Telerik.WinControls.UI.RadTileElement();
            this.chartViewZoomScrollTile = new Telerik.WinControls.UI.RadTileElement();
            this.linksGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.linkTile1 = new Telerik.WinControls.UI.RadTileElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanorama1
            // 
            this.radPanorama1.AutoArrangeNewTiles = false;
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.applicationsGroup,
            this.toolsGroup,
            this.controlsGroups,
            this.linksGroup});
            this.radPanorama1.Location = new System.Drawing.Point(0, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.PanelImage = ((System.Drawing.Image)(resources.GetObject("radPanorama1.PanelImage")));
            this.radPanorama1.PanelImageSize = new System.Drawing.Size(1024, 768);
            this.radPanorama1.RowsCount = 2;
            this.radPanorama1.ShowGroups = true;
            this.radPanorama1.Size = new System.Drawing.Size(912, 566);
            this.radPanorama1.TabIndex = 0;
            this.radPanorama1.Text = "radTilePanel1";
            ((Telerik.WinControls.UI.RadPanoramaElement)(this.radPanorama1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(117)))));
            // 
            // applicationsGroup
            // 
            this.applicationsGroup.AccessibleDescription = "Applications";
            this.applicationsGroup.AccessibleName = "Applications";
            this.applicationsGroup.CellSize = new System.Drawing.Size(155, 155);
            this.applicationsGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicationsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.applicationsGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bugTrackerTile,
            this.fileExplorerTile,
            this.rssReaderTile,
            this.magnifierTile,
            this.photoAlbumTile});
            this.applicationsGroup.Margin = new System.Windows.Forms.Padding(120, 130, 65, 0);
            this.applicationsGroup.Name = "applicationsGroup";
            this.applicationsGroup.RowsCount = 2;
            this.applicationsGroup.Text = "Applications";
            this.applicationsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // bugTrackerTile
            // 
            this.bugTrackerTile.AccessibleDescription = "radTileElement2";
            this.bugTrackerTile.AccessibleName = "radTileElement2";
            this.bugTrackerTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.bugTrackerTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.bugTrackerTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.bugTrackerTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.bugTrackerTile.Column = 2;
            this.bugTrackerTile.DrawBorder = true;
            this.bugTrackerTile.GradientAngle = 0F;
            this.bugTrackerTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.bugTrackerTile.Image = global::DemoAppsHub.Properties.Resources.bug_tracker_icon;
            this.bugTrackerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.bugTrackerTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bugTrackerTile.Name = "bugTrackerTile";
            this.bugTrackerTile.Padding = new System.Windows.Forms.Padding(15, 15, 0, 10);
            this.bugTrackerTile.Text = "Bug Tracker";
            this.bugTrackerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bugTrackerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bugTrackerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.bugTrackerTile.Click += new System.EventHandler(this.bugTrackerTile_Click);
            // 
            // fileExplorerTile
            // 
            this.fileExplorerTile.AccessibleDescription = "radTileElement3";
            this.fileExplorerTile.AccessibleName = "radTileElement3";
            this.fileExplorerTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.fileExplorerTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.fileExplorerTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.fileExplorerTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.fileExplorerTile.Column = 2;
            this.fileExplorerTile.DrawBorder = true;
            this.fileExplorerTile.GradientAngle = 0F;
            this.fileExplorerTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.fileExplorerTile.Image = global::DemoAppsHub.Properties.Resources.file_explorer_icon;
            this.fileExplorerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.fileExplorerTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileExplorerTile.Name = "fileExplorerTile";
            this.fileExplorerTile.Padding = new System.Windows.Forms.Padding(15, 15, 0, 10);
            this.fileExplorerTile.Row = 1;
            this.fileExplorerTile.Text = "File Explorer";
            this.fileExplorerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.fileExplorerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fileExplorerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.fileExplorerTile.Click += new System.EventHandler(this.fileExplorerTile_Click);
            // 
            // rssReaderTile
            // 
            this.rssReaderTile.AccessibleDescription = "radTileElement4";
            this.rssReaderTile.AccessibleName = "radTileElement4";
            this.rssReaderTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.rssReaderTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.rssReaderTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.rssReaderTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.rssReaderTile.DrawBorder = true;
            this.rssReaderTile.GradientAngle = 0F;
            this.rssReaderTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.rssReaderTile.Image = global::DemoAppsHub.Properties.Resources.Rss_reader_icon;
            this.rssReaderTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.rssReaderTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rssReaderTile.Name = "rssReaderTile";
            this.rssReaderTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.rssReaderTile.Row = 1;
            this.rssReaderTile.Text = "RSS Reader";
            this.rssReaderTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.rssReaderTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rssReaderTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.rssReaderTile.Click += new System.EventHandler(this.rssReaderTile_Click);
            // 
            // magnifierTile
            // 
            this.magnifierTile.AccessibleDescription = "radTileElement5";
            this.magnifierTile.AccessibleName = "radTileElement5";
            this.magnifierTile.BackgroundImage = global::DemoAppsHub.Properties.Resources.magnifier_bg;
            this.magnifierTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(64)))), ((int)(((byte)(172)))));
            this.magnifierTile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(64)))), ((int)(((byte)(172)))));
            this.magnifierTile.BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.magnifierTile.BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.magnifierTile.BorderGradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.magnifierTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.magnifierTile.Column = 1;
            this.magnifierTile.DrawBorder = true;
            this.magnifierTile.Image = global::DemoAppsHub.Properties.Resources.magnifier_icon;
            this.magnifierTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.magnifierTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.magnifierTile.Name = "magnifierTile";
            this.magnifierTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.magnifierTile.Row = 1;
            this.magnifierTile.Text = "Magnifier";
            this.magnifierTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.magnifierTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.magnifierTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.magnifierTile.Click += new System.EventHandler(this.magnifierTile_Click);
            // 
            // photoAlbumTile
            // 
            this.photoAlbumTile.AccessibleDescription = "radTileElement6";
            this.photoAlbumTile.AccessibleName = "radTileElement6";
            this.photoAlbumTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.photoAlbumTile.ColSpan = 2;
            this.photoAlbumTile.Column = 0;
            this.photoAlbumTile.Name = "photoAlbumTile";
            this.photoAlbumTile.Row = 0;
            this.photoAlbumTile.Text = "";
            this.photoAlbumTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.photoAlbumTile.Click += new System.EventHandler(this.photoAlbumTile_Click);
            // 
            // toolsGroup
            // 
            this.toolsGroup.AccessibleDescription = "Tools and Demos";
            this.toolsGroup.AccessibleName = "Tools and Demos";
            this.toolsGroup.CellSize = new System.Drawing.Size(155, 155);
            this.toolsGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.toolsGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.qsfTile,
            this.themeViewerTile,
            this.vsbTile});
            this.toolsGroup.Margin = new System.Windows.Forms.Padding(0, 130, 65, 0);
            this.toolsGroup.Name = "toolsGroup";
            this.toolsGroup.RowsCount = 2;
            this.toolsGroup.Text = "Tools and Demos";
            this.toolsGroup.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // qsfTile
            // 
            this.qsfTile.AccessibleDescription = "radTileElement1";
            this.qsfTile.AccessibleName = "radTileElement1";
            this.qsfTile.BackgroundImage = global::DemoAppsHub.Properties.Resources.qsf_bg;
            this.qsfTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.qsfTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.qsfTile.ColSpan = 2;
            this.qsfTile.DrawBorder = true;
            this.qsfTile.Image = Telerik.WinControls.ResFinder.WinFormsIcon.ToBitmap();
            this.qsfTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.qsfTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.qsfTile.Name = "qsfTile";
            this.qsfTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.qsfTile.Text = "Quick Start Framework";
            this.qsfTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.qsfTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.qsfTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.qsfTile.Click += new System.EventHandler(this.qsfTile_Click);
            // 
            // themeViewerTile
            // 
            this.themeViewerTile.AccessibleDescription = "radTileElement2";
            this.themeViewerTile.AccessibleName = "radTileElement2";
            this.themeViewerTile.BackgroundImage = global::DemoAppsHub.Properties.Resources.ThViewer_bg;
            this.themeViewerTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(126)))), ((int)(((byte)(216)))));
            this.themeViewerTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.themeViewerTile.DrawBorder = true;
            this.themeViewerTile.Image = global::DemoAppsHub.Properties.Resources.ThViewer_icon;
            this.themeViewerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.themeViewerTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.themeViewerTile.Name = "themeViewerTile";
            this.themeViewerTile.Padding = new System.Windows.Forms.Padding(15, 15, 0, 10);
            this.themeViewerTile.Row = 1;
            this.themeViewerTile.Text = "<html>Theme<br>Viewer";
            this.themeViewerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.themeViewerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.themeViewerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.themeViewerTile.Click += new System.EventHandler(this.themeViewerTile_Click);
            // 
            // vsbTile
            // 
            this.vsbTile.AccessibleDescription = "radTileElement3";
            this.vsbTile.AccessibleName = "radTileElement3";
            this.vsbTile.BackgroundImage = global::DemoAppsHub.Properties.Resources.vsb_bg;
            this.vsbTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.vsbTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.vsbTile.Column = 1;
            this.vsbTile.DrawBorder = true;
            this.vsbTile.Image = global::DemoAppsHub.Properties.Resources.vsb_icon;
            this.vsbTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.vsbTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vsbTile.Name = "vsbTile";
            this.vsbTile.Padding = new System.Windows.Forms.Padding(15, 15, 0, 10);
            this.vsbTile.Row = 1;
            this.vsbTile.Text = "<html>Visual Style<br>Builder";
            this.vsbTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vsbTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.vsbTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.vsbTile.Click += new System.EventHandler(this.vsbTile_Click);
            // 
            // controlsGroups
            // 
            this.controlsGroups.AccessibleDescription = "Controls";
            this.controlsGroups.AccessibleName = "Controls";
            this.controlsGroups.CellSize = new System.Drawing.Size(155, 155);
            this.controlsGroups.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlsGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.controlsGroups.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.gridTile,
            this.listViewTile,
            this.schedulerTile,
            this.treeViewTile,
            this.chartViewRotateTile,
            this.chartViewZoomScrollTile});
            this.controlsGroups.Margin = new System.Windows.Forms.Padding(0, 130, 65, 0);
            this.controlsGroups.Name = "controlsGroups";
            this.controlsGroups.RowsCount = 2;
            this.controlsGroups.Text = "Controls";
            this.controlsGroups.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // gridTile
            // 
            this.gridTile.AccessibleDescription = "radTileElement1";
            this.gridTile.AccessibleName = "radTileElement1";
            this.gridTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.gridTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.gridTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.gridTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.gridTile.DrawBorder = true;
            this.gridTile.GradientAngle = 0F;
            this.gridTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.gridTile.Image = global::DemoAppsHub.Properties.Resources.GridView;
            this.gridTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.gridTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridTile.Name = "gridTile";
            this.gridTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.gridTile.Text = "Grid View";
            this.gridTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.gridTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.gridTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.gridTile.Click += new System.EventHandler(this.gridTile_Click);
            // 
            // listViewTile
            // 
            this.listViewTile.AccessibleDescription = "radTileElement2";
            this.listViewTile.AccessibleName = "radTileElement2";
            this.listViewTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.listViewTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.listViewTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.listViewTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.listViewTile.Column = 1;
            this.listViewTile.DrawBorder = true;
            this.listViewTile.GradientAngle = 0F;
            this.listViewTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.listViewTile.Image = global::DemoAppsHub.Properties.Resources.ListView;
            this.listViewTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.listViewTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.listViewTile.Name = "listViewTile";
            this.listViewTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.listViewTile.Text = "List View";
            this.listViewTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.listViewTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.listViewTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.listViewTile.Click += new System.EventHandler(this.listViewTile_Click);
            // 
            // schedulerTile
            // 
            this.schedulerTile.AccessibleDescription = "radTileElement3";
            this.schedulerTile.AccessibleName = "radTileElement3";
            this.schedulerTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.schedulerTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.schedulerTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.schedulerTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.schedulerTile.DrawBorder = true;
            this.schedulerTile.GradientAngle = 0F;
            this.schedulerTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.schedulerTile.Image = global::DemoAppsHub.Properties.Resources.Scheduler;
            this.schedulerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.schedulerTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schedulerTile.Name = "schedulerTile";
            this.schedulerTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.schedulerTile.Row = 1;
            this.schedulerTile.Text = "Scheduler";
            this.schedulerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.schedulerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.schedulerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.schedulerTile.Click += new System.EventHandler(this.schedulerTile_Click);
            // 
            // treeViewTile
            // 
            this.treeViewTile.AccessibleDescription = "radTileElement4";
            this.treeViewTile.AccessibleName = "radTileElement4";
            this.treeViewTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.treeViewTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.treeViewTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.treeViewTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.treeViewTile.Column = 1;
            this.treeViewTile.DrawBorder = true;
            this.treeViewTile.GradientAngle = 0F;
            this.treeViewTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.treeViewTile.Image = global::DemoAppsHub.Properties.Resources.TreeView;
            this.treeViewTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.treeViewTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.treeViewTile.Name = "treeViewTile";
            this.treeViewTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.treeViewTile.Row = 1;
            this.treeViewTile.Text = "Tree View";
            this.treeViewTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.treeViewTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.treeViewTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.treeViewTile.Click += new System.EventHandler(this.treeViewTile_Click);
            // 
            // chartViewRotateTile
            // 
            this.chartViewRotateTile.AccessibleDescription = "ChartView (Rotate)";
            this.chartViewRotateTile.AccessibleName = "ChartView (Rotate)";
            this.chartViewRotateTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.chartViewRotateTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.chartViewRotateTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.chartViewRotateTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.chartViewRotateTile.Column = 2;
            this.chartViewRotateTile.DrawBorder = true;
            this.chartViewRotateTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.chartViewRotateTile.Image = global::DemoAppsHub.Properties.Resources.Chart;
            this.chartViewRotateTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.chartViewRotateTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartViewRotateTile.Name = "chartViewRotateTile";
            this.chartViewRotateTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.chartViewRotateTile.Text = "ChartView (Rotate)";
            this.chartViewRotateTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.chartViewRotateTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chartViewRotateTile.TextWrap = true;
            this.chartViewRotateTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.chartViewRotateTile.Click += new System.EventHandler(this.chartViewRotateTile_Click);
            // 
            // chartViewZoomScrollTile
            // 
            this.chartViewZoomScrollTile.AccessibleDescription = "ChartView (Zoom and Scroll)";
            this.chartViewZoomScrollTile.AccessibleName = "ChartView (Zoom and Scroll)";
            this.chartViewZoomScrollTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.chartViewZoomScrollTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.chartViewZoomScrollTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.chartViewZoomScrollTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.chartViewZoomScrollTile.Column = 2;
            this.chartViewZoomScrollTile.DrawBorder = true;
            this.chartViewZoomScrollTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.chartViewZoomScrollTile.Image = global::DemoAppsHub.Properties.Resources.Chart;
            this.chartViewZoomScrollTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.chartViewZoomScrollTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartViewZoomScrollTile.Name = "chartViewZoomScrollTile";
            this.chartViewZoomScrollTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.chartViewZoomScrollTile.Row = 1;
            this.chartViewZoomScrollTile.Text = "ChartView (Zoom/ Scroll)";
            this.chartViewZoomScrollTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.chartViewZoomScrollTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chartViewZoomScrollTile.TextWrap = true;
            this.chartViewZoomScrollTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.chartViewZoomScrollTile.Click += new System.EventHandler(this.chartViewZoomScrollTile_Click);
            // 
            // linksGroup
            // 
            this.linksGroup.AccessibleDescription = "Links";
            this.linksGroup.AccessibleName = "Links";
            this.linksGroup.CellSize = new System.Drawing.Size(155, 155);
            this.linksGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linksGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(186)))), ((int)(((byte)(15)))));
            this.linksGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linkTile1});
            this.linksGroup.Margin = new System.Windows.Forms.Padding(0, 130, 65, 0);
            this.linksGroup.Name = "linksGroup";
            this.linksGroup.RowsCount = 2;
            this.linksGroup.Text = "Links";
            this.linksGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // linkTile1
            // 
            this.linkTile1.AccessibleDescription = "radTileElement1";
            this.linkTile1.AccessibleName = "radTileElement1";
            this.linkTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(69)))));
            this.linkTile1.CellPadding = new System.Windows.Forms.Padding(5);
            this.linkTile1.Image = global::DemoAppsHub.Properties.Resources.AllTelerikProducts;
            this.linkTile1.Name = "linkTile1";
            this.linkTile1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.linkTile1.RowSpan = 2;
            this.linkTile1.ColSpan = 2;
            this.linkTile1.DrawBorder = false;
            this.linkTile1.BorderColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(912, 566);
            this.Controls.Add(this.radPanorama1);
            this.Icon = global::DemoAppsHub.Properties.Resources.icon;
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Apps Hub";
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadPanorama radPanorama1;
        private TileGroupElement applicationsGroup;
        private TileGroupElement toolsGroup;
        private TileGroupElement controlsGroups;
        private TileGroupElement linksGroup;
        private RadTileElement bugTrackerTile;
        private RadTileElement fileExplorerTile;
        private RadTileElement rssReaderTile;
        private RadTileElement magnifierTile;
        private RadLiveTileElement photoAlbumTile;
        private RadTileElement qsfTile;
        private RadTileElement themeViewerTile;
        private RadTileElement vsbTile;
        private RadTileElement gridTile;
        private RadTileElement listViewTile;
        private RadTileElement schedulerTile;
        private RadTileElement treeViewTile;
        private RadTileElement linkTile1;
        private RadTileElement chartViewRotateTile;
        private RadTileElement chartViewZoomScrollTile;
    }
}