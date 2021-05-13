Imports Telerik.WinControls.UI

Namespace DemoAppsHub
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.radPanorama1 = New Telerik.WinControls.UI.RadPanorama()
            Me.applicationsGroup = New Telerik.WinControls.UI.TileGroupElement()
            Me.bugTrackerTile = New Telerik.WinControls.UI.RadTileElement()
            Me.fileExplorerTile = New Telerik.WinControls.UI.RadTileElement()
            Me.rssReaderTile = New Telerik.WinControls.UI.RadTileElement()
            Me.magnifierTile = New Telerik.WinControls.UI.RadTileElement()
            Me.photoAlbumTile = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.toolsGroup = New Telerik.WinControls.UI.TileGroupElement()
            Me.qsfTile = New Telerik.WinControls.UI.RadTileElement()
            Me.themeViewerTile = New Telerik.WinControls.UI.RadTileElement()
            Me.vsbTile = New Telerik.WinControls.UI.RadTileElement()
            Me.controlsGroups = New Telerik.WinControls.UI.TileGroupElement()
            Me.gridTile = New Telerik.WinControls.UI.RadTileElement()
            Me.listViewTile = New Telerik.WinControls.UI.RadTileElement()
            Me.schedulerTile = New Telerik.WinControls.UI.RadTileElement()
            Me.treeViewTile = New Telerik.WinControls.UI.RadTileElement()
            Me.chartViewRotateTile = New Telerik.WinControls.UI.RadTileElement()
            Me.chartViewZoomScrollTile = New Telerik.WinControls.UI.RadTileElement()
            Me.linksGroup = New Telerik.WinControls.UI.TileGroupElement()
            Me.linkTile1 = New Telerik.WinControls.UI.RadTileElement()
            CType((Me.radPanorama1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanorama1.AutoArrangeNewTiles = False
            Me.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanorama1.Groups.AddRange(New Telerik.WinControls.RadItem() {Me.applicationsGroup, Me.toolsGroup, Me.controlsGroups, Me.linksGroup})
            Me.radPanorama1.Location = New System.Drawing.Point(0, 0)
            Me.radPanorama1.Name = "radPanorama1"
            Me.radPanorama1.PanelImage = (CType((resources.GetObject("radPanorama1.PanelImage")), System.Drawing.Image))
            Me.radPanorama1.PanelImageSize = New System.Drawing.Size(1024, 768)
            Me.radPanorama1.RowsCount = 2
            Me.radPanorama1.ShowGroups = True
            Me.radPanorama1.Size = New System.Drawing.Size(912, 566)
            Me.radPanorama1.TabIndex = 0
            Me.radPanorama1.Text = "radTilePanel1"
            CType((Me.radPanorama1.GetChildAt(0)), Telerik.WinControls.UI.RadPanoramaElement).BackColor = System.Drawing.Color.FromArgb(CInt(CByte(1)), CInt(CByte(23)), CInt(CByte(117)))
            Me.applicationsGroup.AccessibleDescription = "Applications"
            Me.applicationsGroup.AccessibleName = "Applications"
            Me.applicationsGroup.CellSize = New System.Drawing.Size(155, 155)
            Me.applicationsGroup.Font = New System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.applicationsGroup.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((71)))))), (CInt(((CByte((172)))))), (CInt(((CByte((255)))))))
            Me.applicationsGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bugTrackerTile, Me.fileExplorerTile, Me.rssReaderTile, Me.magnifierTile, Me.photoAlbumTile})
            Me.applicationsGroup.Margin = New System.Windows.Forms.Padding(120, 130, 65, 0)
            Me.applicationsGroup.Name = "applicationsGroup"
            Me.applicationsGroup.RowsCount = 2
            Me.applicationsGroup.Text = "Applications"
            Me.applicationsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.bugTrackerTile.AccessibleDescription = "radTileElement2"
            Me.bugTrackerTile.AccessibleName = "radTileElement2"
            Me.bugTrackerTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.bugTrackerTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.bugTrackerTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.bugTrackerTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.bugTrackerTile.Column = 2
            Me.bugTrackerTile.DrawBorder = True
            Me.bugTrackerTile.GradientAngle = 0.0F
            Me.bugTrackerTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.bugTrackerTile.Image = Global.Resources.bug_tracker_icon
            Me.bugTrackerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.bugTrackerTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bugTrackerTile.Name = "bugTrackerTile"
            Me.bugTrackerTile.Padding = New System.Windows.Forms.Padding(15, 15, 0, 10)
            Me.bugTrackerTile.Text = "Bug Tracker"
            Me.bugTrackerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.bugTrackerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.bugTrackerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.bugTrackerTile.Click, AddressOf Me.bugTrackerTile_Click
            Me.fileExplorerTile.AccessibleDescription = "radTileElement3"
            Me.fileExplorerTile.AccessibleName = "radTileElement3"
            Me.fileExplorerTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.fileExplorerTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.fileExplorerTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.fileExplorerTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.fileExplorerTile.Column = 2
            Me.fileExplorerTile.DrawBorder = True
            Me.fileExplorerTile.GradientAngle = 0.0F
            Me.fileExplorerTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.fileExplorerTile.Image = Global.Resources.file_explorer_icon
            Me.fileExplorerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.fileExplorerTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.fileExplorerTile.Name = "fileExplorerTile"
            Me.fileExplorerTile.Padding = New System.Windows.Forms.Padding(15, 15, 0, 10)
            Me.fileExplorerTile.Row = 1
            Me.fileExplorerTile.Text = "File Explorer"
            Me.fileExplorerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.fileExplorerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.fileExplorerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.fileExplorerTile.Click, AddressOf Me.fileExplorerTile_Click
            Me.rssReaderTile.AccessibleDescription = "radTileElement4"
            Me.rssReaderTile.AccessibleName = "radTileElement4"
            Me.rssReaderTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.rssReaderTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.rssReaderTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.rssReaderTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.rssReaderTile.DrawBorder = True
            Me.rssReaderTile.GradientAngle = 0.0F
            Me.rssReaderTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.rssReaderTile.Image = Global.Resources.Rss_reader_icon
            Me.rssReaderTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.rssReaderTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.rssReaderTile.Name = "rssReaderTile"
            Me.rssReaderTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.rssReaderTile.Row = 1
            Me.rssReaderTile.Text = "RSS Reader"
            Me.rssReaderTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.rssReaderTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.rssReaderTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.rssReaderTile.Click, AddressOf Me.rssReaderTile_Click
            Me.magnifierTile.AccessibleDescription = "radTileElement5"
            Me.magnifierTile.AccessibleName = "radTileElement5"
            Me.magnifierTile.BackgroundImage = Global.Resources.magnifier_bg
            Me.magnifierTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((76)))))), (CInt(((CByte((64)))))), (CInt(((CByte((172)))))))
            Me.magnifierTile.BorderColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((76)))))), (CInt(((CByte((64)))))), (CInt(((CByte((172)))))))
            Me.magnifierTile.BorderColor3 = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((128)))))), (CInt(((CByte((197)))))))
            Me.magnifierTile.BorderColor4 = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((128)))))), (CInt(((CByte((197)))))))
            Me.magnifierTile.BorderGradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.magnifierTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.magnifierTile.Column = 1
            Me.magnifierTile.DrawBorder = True
            Me.magnifierTile.Image = Global.Resources.magnifier_icon
            Me.magnifierTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.magnifierTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.magnifierTile.Name = "magnifierTile"
            Me.magnifierTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.magnifierTile.Row = 1
            Me.magnifierTile.Text = "Magnifier"
            Me.magnifierTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.magnifierTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.magnifierTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.magnifierTile.Click, AddressOf Me.magnifierTile_Click
            Me.photoAlbumTile.AccessibleDescription = "radTileElement6"
            Me.photoAlbumTile.AccessibleName = "radTileElement6"
            Me.photoAlbumTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.photoAlbumTile.ColSpan = 2
            Me.photoAlbumTile.Column = 0
            Me.photoAlbumTile.Name = "photoAlbumTile"
            Me.photoAlbumTile.Row = 0
            Me.photoAlbumTile.Text = ""
            Me.photoAlbumTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.photoAlbumTile.Click, AddressOf Me.photoAlbumTile_Click
            Me.toolsGroup.AccessibleDescription = "Tools and Demos"
            Me.toolsGroup.AccessibleName = "Tools and Demos"
            Me.toolsGroup.CellSize = New System.Drawing.Size(155, 155)
            Me.toolsGroup.Font = New System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.toolsGroup.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((71)))))), (CInt(((CByte((172)))))), (CInt(((CByte((255)))))))
            Me.toolsGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.qsfTile, Me.themeViewerTile, Me.vsbTile})
            Me.toolsGroup.Margin = New System.Windows.Forms.Padding(0, 130, 65, 0)
            Me.toolsGroup.Name = "toolsGroup"
            Me.toolsGroup.RowsCount = 2
            Me.toolsGroup.Text = "Tools and Demos"
            Me.toolsGroup.TextOrientation = System.Windows.Forms.Orientation.Horizontal
            Me.toolsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.qsfTile.AccessibleDescription = "radTileElement1"
            Me.qsfTile.AccessibleName = "radTileElement1"
            Me.qsfTile.BackgroundImage = Global.Resources.qsf_bg
            Me.qsfTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((57)))))), (CInt(((CByte((129)))))), (CInt(((CByte((190)))))))
            Me.qsfTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.qsfTile.ColSpan = 2
            Me.qsfTile.DrawBorder = True
            Me.qsfTile.Image = Telerik.WinControls.ResFinder.WinFormsIcon.ToBitmap()
            Me.qsfTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.qsfTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.qsfTile.Name = "qsfTile"
            Me.qsfTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.qsfTile.Text = "Quick Start Framework"
            Me.qsfTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.qsfTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.qsfTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.qsfTile.Click, AddressOf Me.qsfTile_Click
            Me.themeViewerTile.AccessibleDescription = "radTileElement2"
            Me.themeViewerTile.AccessibleName = "radTileElement2"
            Me.themeViewerTile.BackgroundImage = Global.Resources.ThViewer_bg
            Me.themeViewerTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((1)))))), (CInt(((CByte((126)))))), (CInt(((CByte((216)))))))
            Me.themeViewerTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.themeViewerTile.DrawBorder = True
            Me.themeViewerTile.Image = Global.Resources.ThViewer_icon
            Me.themeViewerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.themeViewerTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.themeViewerTile.Name = "themeViewerTile"
            Me.themeViewerTile.Padding = New System.Windows.Forms.Padding(15, 15, 0, 10)
            Me.themeViewerTile.Row = 1
            Me.themeViewerTile.Text = "<html>Theme<br>Viewer"
            Me.themeViewerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.themeViewerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.themeViewerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.themeViewerTile.Click, AddressOf Me.themeViewerTile_Click
            Me.vsbTile.AccessibleDescription = "radTileElement3"
            Me.vsbTile.AccessibleName = "radTileElement3"
            Me.vsbTile.BackgroundImage = Global.Resources.vsb_bg
            Me.vsbTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((30)))))), (CInt(((CByte((33)))))))
            Me.vsbTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.vsbTile.Column = 1
            Me.vsbTile.DrawBorder = True
            Me.vsbTile.Image = Global.Resources.vsb_icon
            Me.vsbTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.vsbTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.vsbTile.Name = "vsbTile"
            Me.vsbTile.Padding = New System.Windows.Forms.Padding(15, 15, 0, 10)
            Me.vsbTile.Row = 1
            Me.vsbTile.Text = "<html>Visual Style<br>Builder"
            Me.vsbTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.vsbTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.vsbTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.vsbTile.Click, AddressOf Me.vsbTile_Click
            Me.controlsGroups.AccessibleDescription = "Controls"
            Me.controlsGroups.AccessibleName = "Controls"
            Me.controlsGroups.CellSize = New System.Drawing.Size(155, 155)
            Me.controlsGroups.Font = New System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.controlsGroups.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((71)))))), (CInt(((CByte((172)))))), (CInt(((CByte((255)))))))
            Me.controlsGroups.Items.AddRange(New Telerik.WinControls.RadItem() {Me.gridTile, Me.listViewTile, Me.schedulerTile, Me.treeViewTile, Me.chartViewRotateTile, Me.chartViewZoomScrollTile})
            Me.controlsGroups.Margin = New System.Windows.Forms.Padding(0, 130, 65, 0)
            Me.controlsGroups.Name = "controlsGroups"
            Me.controlsGroups.RowsCount = 2
            Me.controlsGroups.Text = "Controls"
            Me.controlsGroups.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.gridTile.AccessibleDescription = "radTileElement1"
            Me.gridTile.AccessibleName = "radTileElement1"
            Me.gridTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.gridTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((177)))))), (CInt(((CByte((219)))))))
            Me.gridTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.gridTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.gridTile.DrawBorder = True
            Me.gridTile.GradientAngle = 0.0F
            Me.gridTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.gridTile.Image = Global.Resources.GridView
            Me.gridTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.gridTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.gridTile.Name = "gridTile"
            Me.gridTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.gridTile.Text = "Grid View"
            Me.gridTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.gridTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.gridTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.gridTile.Click, AddressOf Me.gridTile_Click
            Me.listViewTile.AccessibleDescription = "radTileElement2"
            Me.listViewTile.AccessibleName = "radTileElement2"
            Me.listViewTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.listViewTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((177)))))), (CInt(((CByte((219)))))))
            Me.listViewTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.listViewTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.listViewTile.Column = 1
            Me.listViewTile.DrawBorder = True
            Me.listViewTile.GradientAngle = 0.0F
            Me.listViewTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.listViewTile.Image = Global.Resources.ListView
            Me.listViewTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.listViewTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.listViewTile.Name = "listViewTile"
            Me.listViewTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.listViewTile.Text = "List View"
            Me.listViewTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.listViewTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.listViewTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.listViewTile.Click, AddressOf Me.listViewTile_Click
            Me.schedulerTile.AccessibleDescription = "radTileElement3"
            Me.schedulerTile.AccessibleName = "radTileElement3"
            Me.schedulerTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.schedulerTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((177)))))), (CInt(((CByte((219)))))))
            Me.schedulerTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.schedulerTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.schedulerTile.DrawBorder = True
            Me.schedulerTile.GradientAngle = 0.0F
            Me.schedulerTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.schedulerTile.Image = Global.Resources.Scheduler
            Me.schedulerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.schedulerTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.schedulerTile.Name = "schedulerTile"
            Me.schedulerTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.schedulerTile.Row = 1
            Me.schedulerTile.Text = "Scheduler"
            Me.schedulerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.schedulerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.schedulerTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.schedulerTile.Click, AddressOf Me.schedulerTile_Click
            Me.treeViewTile.AccessibleDescription = "radTileElement4"
            Me.treeViewTile.AccessibleName = "radTileElement4"
            Me.treeViewTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.treeViewTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((177)))))), (CInt(((CByte((219)))))))
            Me.treeViewTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.treeViewTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.treeViewTile.Column = 1
            Me.treeViewTile.DrawBorder = True
            Me.treeViewTile.GradientAngle = 0.0F
            Me.treeViewTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.treeViewTile.Image = Global.Resources.TreeView
            Me.treeViewTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.treeViewTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.treeViewTile.Name = "treeViewTile"
            Me.treeViewTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.treeViewTile.Row = 1
            Me.treeViewTile.Text = "Tree View"
            Me.treeViewTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.treeViewTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.treeViewTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.treeViewTile.Click, AddressOf Me.treeViewTile_Click
            Me.chartViewRotateTile.AccessibleDescription = "ChartView (Rotate)"
            Me.chartViewRotateTile.AccessibleName = "ChartView (Rotate)"
            Me.chartViewRotateTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.chartViewRotateTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((177)))))), (CInt(((CByte((219)))))))
            Me.chartViewRotateTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.chartViewRotateTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.chartViewRotateTile.Column = 2
            Me.chartViewRotateTile.DrawBorder = True
            Me.chartViewRotateTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.chartViewRotateTile.Image = Global.Resources.Chart
            Me.chartViewRotateTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.chartViewRotateTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.chartViewRotateTile.Name = "chartViewRotateTile"
            Me.chartViewRotateTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.chartViewRotateTile.Text = "ChartView (Rotate)"
            Me.chartViewRotateTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.chartViewRotateTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.chartViewRotateTile.TextWrap = True
            Me.chartViewRotateTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.chartViewRotateTile.Click, AddressOf Me.chartViewRotateTile_Click
            Me.chartViewZoomScrollTile.AccessibleDescription = "ChartView (Zoom and Scroll)"
            Me.chartViewZoomScrollTile.AccessibleName = "ChartView (Zoom and Scroll)"
            Me.chartViewZoomScrollTile.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((21)))))), (CInt(((CByte((161)))))), (CInt(((CByte((209)))))))
            Me.chartViewZoomScrollTile.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((26)))))), (CInt(((CByte((177)))))), (CInt(((CByte((219)))))))
            Me.chartViewZoomScrollTile.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((67)))))), (CInt(((CByte((180)))))), (CInt(((CByte((218)))))))
            Me.chartViewZoomScrollTile.CellPadding = New System.Windows.Forms.Padding(5)
            Me.chartViewZoomScrollTile.Column = 2
            Me.chartViewZoomScrollTile.DrawBorder = True
            Me.chartViewZoomScrollTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear
            Me.chartViewZoomScrollTile.Image = Global.Resources.Chart
            Me.chartViewZoomScrollTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.chartViewZoomScrollTile.ImageLayout = System.Windows.Forms.ImageLayout.None
            Me.chartViewZoomScrollTile.Name = "chartViewZoomScrollTile"
            Me.chartViewZoomScrollTile.Padding = New System.Windows.Forms.Padding(15, 15, 15, 10)
            Me.chartViewZoomScrollTile.Row = 1
            Me.chartViewZoomScrollTile.Text = "ChartView (Zoom/ Scroll)"
            Me.chartViewZoomScrollTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.chartViewZoomScrollTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.chartViewZoomScrollTile.TextWrap = True
            Me.chartViewZoomScrollTile.Visibility = Telerik.WinControls.ElementVisibility.Visible
            AddHandler Me.chartViewZoomScrollTile.Click, AddressOf Me.chartViewZoomScrollTile_Click
            Me.linksGroup.AccessibleDescription = "Links"
            Me.linksGroup.AccessibleName = "Links"
            Me.linksGroup.CellSize = New System.Drawing.Size(155, 155)
            Me.linksGroup.Font = New System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.linksGroup.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((163)))))), (CInt(((CByte((186)))))), (CInt(((CByte((15)))))))
            Me.linksGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linkTile1})
            Me.linksGroup.Margin = New System.Windows.Forms.Padding(0, 130, 65, 0)
            Me.linksGroup.Name = "linksGroup"
            Me.linksGroup.RowsCount = 2
            Me.linksGroup.Text = "Links"
            Me.linksGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.linkTile1.AccessibleDescription = "radTileElement1"
            Me.linkTile1.AccessibleName = "radTileElement1"
            Me.linkTile1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((44)))))), (CInt(((CByte((177)))))), (CInt(((CByte((69)))))))
            Me.linkTile1.CellPadding = New System.Windows.Forms.Padding(5)
            Me.linkTile1.Image = Global.Resources.AllTelerikProducts
            Me.linkTile1.Name = "linkTile1"
            Me.linkTile1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.linkTile1.RowSpan = 2
            Me.linkTile1.ColSpan = 2
            Me.linkTile1.DrawBorder = False
            Me.linkTile1.BorderColor = System.Drawing.Color.Transparent
            Me.ClientSize = New System.Drawing.Size(912, 566)
            Me.Controls.Add(Me.radPanorama1)
            Me.Icon = Global.Resources.icon
            Me.Name = "Form1"
            Me.RootElement.ApplyShapeToControl = True
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Demo Apps Hub"
            CType((Me.radPanorama1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radPanorama1 As RadPanorama
        Private applicationsGroup As TileGroupElement
        Private toolsGroup As TileGroupElement
        Private controlsGroups As TileGroupElement
        Private linksGroup As TileGroupElement
        Private bugTrackerTile As RadTileElement
        Private fileExplorerTile As RadTileElement
        Private rssReaderTile As RadTileElement
        Private magnifierTile As RadTileElement
        Private photoAlbumTile As RadLiveTileElement
        Private qsfTile As RadTileElement
        Private themeViewerTile As RadTileElement
        Private vsbTile As RadTileElement
        Private gridTile As RadTileElement
        Private listViewTile As RadTileElement
        Private schedulerTile As RadTileElement
        Private treeViewTile As RadTileElement
        Private linkTile1 As RadTileElement
        Private chartViewRotateTile As RadTileElement
        Private chartViewZoomScrollTile As RadTileElement
    End Class
End Namespace