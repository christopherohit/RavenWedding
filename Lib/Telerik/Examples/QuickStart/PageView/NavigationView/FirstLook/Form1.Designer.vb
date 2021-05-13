Namespace Telerik.Examples.WinControls.PageView.NavigationView.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
            Me.ParisPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanoramaParis = New Telerik.WinControls.UI.RadPanorama()
            Me.tileParis01 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis02 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis03 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis04 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis05 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis06 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis07 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.tileParis08 = New Telerik.WinControls.UI.RadLiveTileElement()
            Me.LondonPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanoramaLondon = New Telerik.WinControls.UI.RadPanorama()
            Me.tileLondon01 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon02 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon03 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon04 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon05 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon06 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon07 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon08 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon09 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileLondon10 = New Telerik.WinControls.UI.RadTileElement()
            Me.ViennaPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanoramaVienna = New Telerik.WinControls.UI.RadPanorama()
            Me.tileVienna01 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVienna02 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVienna03 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVienna04 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVienna05 = New Telerik.WinControls.UI.RadTileElement()
            Me.VenicePage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanoramaVenice = New Telerik.WinControls.UI.RadPanorama()
            Me.tileVenice01 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice02 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice03 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice04 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice05 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice06 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice07 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice08 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice09 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileVenice10 = New Telerik.WinControls.UI.RadTileElement()
            Me.FlorencePage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanoramaFlorence = New Telerik.WinControls.UI.RadPanorama()
            Me.tileFlorence01 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileFlorence02 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileFlorence03 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileFlorence04 = New Telerik.WinControls.UI.RadTileElement()
            Me.EdinburghPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.radPanoramaEdinburgh = New Telerik.WinControls.UI.RadPanorama()
            Me.tileEdinburgh01 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh02 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh03 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh04 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh05 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh06 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh07 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh08 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh09 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh10 = New Telerik.WinControls.UI.RadTileElement()
            Me.tileEdinburgh11 = New Telerik.WinControls.UI.RadTileElement()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPageView1.SuspendLayout()
            Me.ParisPage.SuspendLayout()
            CType(Me.radPanoramaParis, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LondonPage.SuspendLayout()
            CType(Me.radPanoramaLondon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ViennaPage.SuspendLayout()
            CType(Me.radPanoramaVienna, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.VenicePage.SuspendLayout()
            CType(Me.radPanoramaVenice, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FlorencePage.SuspendLayout()
            CType(Me.radPanoramaFlorence, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.EdinburghPage.SuspendLayout()
            CType(Me.radPanoramaEdinburgh, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1721, 0)
            '
            'radPageView1
            '
            Me.radPageView1.Controls.Add(Me.ParisPage)
            Me.radPageView1.Controls.Add(Me.LondonPage)
            Me.radPageView1.Controls.Add(Me.ViennaPage)
            Me.radPageView1.Controls.Add(Me.VenicePage)
            Me.radPageView1.Controls.Add(Me.FlorencePage)
            Me.radPageView1.Controls.Add(Me.EdinburghPage)
            Me.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPageView1.Location = New System.Drawing.Point(0, 0)
            Me.radPageView1.Name = "radPageView1"
            Me.radPageView1.SelectedPage = Me.ParisPage
            Me.radPageView1.Size = New System.Drawing.Size(2011, 1157)
            Me.radPageView1.TabIndex = 0
            Me.radPageView1.ThemeName = "Fluent"
            Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView
            '
            'ParisPage
            '
            Me.ParisPage.Controls.Add(Me.radPanoramaParis)
            Me.ParisPage.Image = Global.My.Resources.blue_paris
            Me.ParisPage.ItemSize = New System.Drawing.SizeF(38.0!, 38.0!)
            Me.ParisPage.Location = New System.Drawing.Point(41, 30)
            Me.ParisPage.Name = "ParisPage"
            Me.ParisPage.Size = New System.Drawing.Size(1969, 1126)
            Me.ParisPage.Text = "Paris"
            '
            'radPanoramaParis
            '
            Me.radPanoramaParis.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanoramaParis.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tileParis01, Me.tileParis02, Me.tileParis03, Me.tileParis04, Me.tileParis05, Me.tileParis06, Me.tileParis07, Me.tileParis08})
            Me.radPanoramaParis.Location = New System.Drawing.Point(0, 0)
            Me.radPanoramaParis.Name = "radPanoramaParis"
            Me.radPanoramaParis.RowsCount = 12
            Me.radPanoramaParis.ScrollBarAlignment = Telerik.WinControls.UI.HorizontalScrollAlignment.Bottom
            Me.radPanoramaParis.Size = New System.Drawing.Size(1969, 1126)
            Me.radPanoramaParis.TabIndex = 0
            '
            'tileParis01
            '
            Me.tileParis01.ColSpan = 4
            Me.tileParis01.Image = Global.My.Resources.Paris_04
            Me.tileParis01.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis01.Name = "tileParis01"
            Me.tileParis01.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis01.RowSpan = 6
            Me.tileParis01.Text = "radTileElement1"
            '
            'tileParis02
            '
            Me.tileParis02.ColSpan = 3
            Me.tileParis02.Column = 4
            Me.tileParis02.Image = Global.My.Resources.Paris_01
            Me.tileParis02.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis02.Name = "tileParis02"
            Me.tileParis02.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis02.RowSpan = 2
            Me.tileParis02.Text = "radTileElement2"
            '
            'tileParis03
            '
            Me.tileParis03.ColSpan = 3
            Me.tileParis03.Column = 4
            Me.tileParis03.Image = Global.My.Resources.Paris_02
            Me.tileParis03.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis03.Name = "tileParis03"
            Me.tileParis03.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis03.Row = 2
            Me.tileParis03.RowSpan = 2
            Me.tileParis03.Text = "radTileElement3"
            '
            'tileParis04
            '
            Me.tileParis04.ColSpan = 3
            Me.tileParis04.Column = 4
            Me.tileParis04.Image = Global.My.Resources.Paris_03
            Me.tileParis04.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis04.Name = "tileParis04"
            Me.tileParis04.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis04.Row = 4
            Me.tileParis04.RowSpan = 2
            Me.tileParis04.Text = "radTileElement4"
            '
            'tileParis05
            '
            Me.tileParis05.ColSpan = 3
            Me.tileParis05.Column = 7
            Me.tileParis05.Image = Global.My.Resources.Paris_05
            Me.tileParis05.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis05.Name = "tileParis05"
            Me.tileParis05.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis05.RowSpan = 2
            Me.tileParis05.Text = "radTileElement5"
            '
            'tileParis06
            '
            Me.tileParis06.ColSpan = 3
            Me.tileParis06.Column = 7
            Me.tileParis06.Image = Global.My.Resources.Paris_06
            Me.tileParis06.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis06.Name = "tileParis06"
            Me.tileParis06.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis06.Row = 2
            Me.tileParis06.RowSpan = 2
            Me.tileParis06.Text = "radTileElement6"
            '
            'tileParis07
            '
            Me.tileParis07.ColSpan = 3
            Me.tileParis07.Column = 7
            Me.tileParis07.Image = Global.My.Resources.Paris_09
            Me.tileParis07.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis07.Name = "tileParis07"
            Me.tileParis07.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis07.Row = 4
            Me.tileParis07.RowSpan = 2
            Me.tileParis07.Text = "radTileElement7"
            '
            'tileParis08
            '
            Me.tileParis08.ColSpan = 4
            Me.tileParis08.Column = 10
            Me.tileParis08.Image = Global.My.Resources.Paris_07
            Me.tileParis08.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileParis08.Name = "tileParis08"
            Me.tileParis08.Padding = New System.Windows.Forms.Padding(2)
            Me.tileParis08.RowSpan = 6
            Me.tileParis08.Text = "radTileElement8"
            '
            'LondonPage
            '
            Me.LondonPage.Controls.Add(Me.radPanoramaLondon)
            Me.LondonPage.Image = Global.My.Resources.blue_london_updated
            Me.LondonPage.ItemSize = New System.Drawing.SizeF(38.0!, 36.0!)
            Me.LondonPage.Location = New System.Drawing.Point(41, 30)
            Me.LondonPage.Name = "LondonPage"
            Me.LondonPage.Size = New System.Drawing.Size(1969, 1126)
            Me.LondonPage.Text = "London"
            '
            'radPanoramaLondon
            '
            Me.radPanoramaLondon.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanoramaLondon.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tileLondon01, Me.tileLondon02, Me.tileLondon03, Me.tileLondon04, Me.tileLondon05, Me.tileLondon06, Me.tileLondon07, Me.tileLondon08, Me.tileLondon09, Me.tileLondon10})
            Me.radPanoramaLondon.Location = New System.Drawing.Point(0, 0)
            Me.radPanoramaLondon.Name = "radPanoramaLondon"
            Me.radPanoramaLondon.RowsCount = 12
            Me.radPanoramaLondon.ScrollBarAlignment = Telerik.WinControls.UI.HorizontalScrollAlignment.Bottom
            Me.radPanoramaLondon.Size = New System.Drawing.Size(1969, 1126)
            Me.radPanoramaLondon.TabIndex = 0
            '
            'tileLondon01
            '
            Me.tileLondon01.ColSpan = 3
            Me.tileLondon01.Image = Global.My.Resources.London_01
            Me.tileLondon01.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon01.Name = "tileLondon01"
            Me.tileLondon01.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon01.RowSpan = 2
            Me.tileLondon01.Text = "1"
            '
            'tileLondon02
            '
            Me.tileLondon02.ColSpan = 3
            Me.tileLondon02.Image = Global.My.Resources.London_02
            Me.tileLondon02.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon02.Name = "tileLondon02"
            Me.tileLondon02.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon02.Row = 2
            Me.tileLondon02.RowSpan = 2
            Me.tileLondon02.Text = "2"
            '
            'tileLondon03
            '
            Me.tileLondon03.ColSpan = 3
            Me.tileLondon03.Image = Global.My.Resources.London_03
            Me.tileLondon03.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon03.Name = "tileLondon03"
            Me.tileLondon03.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon03.Row = 4
            Me.tileLondon03.RowSpan = 2
            Me.tileLondon03.Text = "3"
            '
            'tileLondon04
            '
            Me.tileLondon04.ColSpan = 5
            Me.tileLondon04.Column = 3
            Me.tileLondon04.Image = Global.My.Resources.London_04
            Me.tileLondon04.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon04.Name = "tileLondon04"
            Me.tileLondon04.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon04.RowSpan = 6
            Me.tileLondon04.Text = "4"
            '
            'tileLondon05
            '
            Me.tileLondon05.ColSpan = 6
            Me.tileLondon05.Column = 8
            Me.tileLondon05.Image = Global.My.Resources.London_05
            Me.tileLondon05.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon05.Name = "tileLondon05"
            Me.tileLondon05.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon05.RowSpan = 4
            Me.tileLondon05.Text = "5"
            '
            'tileLondon06
            '
            Me.tileLondon06.ColSpan = 3
            Me.tileLondon06.Column = 8
            Me.tileLondon06.Image = Global.My.Resources.London_06
            Me.tileLondon06.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon06.Name = "tileLondon06"
            Me.tileLondon06.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon06.Row = 4
            Me.tileLondon06.RowSpan = 2
            Me.tileLondon06.Text = "6"
            '
            'tileLondon07
            '
            Me.tileLondon07.ColSpan = 4
            Me.tileLondon07.Column = 10
            Me.tileLondon07.Image = Global.My.Resources.London_07
            Me.tileLondon07.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon07.Name = "tileLondon07"
            Me.tileLondon07.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon07.Row = 6
            Me.tileLondon07.RowSpan = 3
            Me.tileLondon07.Text = "7"
            '
            'tileLondon08
            '
            Me.tileLondon08.ColSpan = 3
            Me.tileLondon08.Column = 11
            Me.tileLondon08.Image = Global.My.Resources.London_08
            Me.tileLondon08.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon08.Name = "tileLondon08"
            Me.tileLondon08.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon08.Row = 4
            Me.tileLondon08.RowSpan = 2
            Me.tileLondon08.Text = "8"
            '
            'tileLondon09
            '
            Me.tileLondon09.ColSpan = 4
            Me.tileLondon09.Image = Global.My.Resources.London_09
            Me.tileLondon09.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon09.Name = "tileLondon09"
            Me.tileLondon09.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon09.Row = 6
            Me.tileLondon09.RowSpan = 5
            Me.tileLondon09.Text = "9"
            '
            'tileLondon10
            '
            Me.tileLondon10.ColSpan = 6
            Me.tileLondon10.Column = 4
            Me.tileLondon10.Image = Global.My.Resources.London_10
            Me.tileLondon10.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileLondon10.Name = "tileLondon10"
            Me.tileLondon10.Padding = New System.Windows.Forms.Padding(2)
            Me.tileLondon10.Row = 6
            Me.tileLondon10.RowSpan = 4
            Me.tileLondon10.Text = "10"
            '
            'ViennaPage
            '
            Me.ViennaPage.Controls.Add(Me.radPanoramaVienna)
            Me.ViennaPage.Image = Global.My.Resources.blue_vienna
            Me.ViennaPage.ItemSize = New System.Drawing.SizeF(38.0!, 36.0!)
            Me.ViennaPage.Location = New System.Drawing.Point(41, 30)
            Me.ViennaPage.Name = "ViennaPage"
            Me.ViennaPage.Size = New System.Drawing.Size(1969, 1126)
            Me.ViennaPage.Text = "Vienna"
            '
            'radPanoramaVienna
            '
            Me.radPanoramaVienna.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanoramaVienna.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tileVienna01, Me.tileVienna02, Me.tileVienna03, Me.tileVienna04, Me.tileVienna05})
            Me.radPanoramaVienna.Location = New System.Drawing.Point(0, 0)
            Me.radPanoramaVienna.Name = "radPanoramaVienna"
            Me.radPanoramaVienna.RowsCount = 10
            Me.radPanoramaVienna.ScrollBarAlignment = Telerik.WinControls.UI.HorizontalScrollAlignment.Bottom
            Me.radPanoramaVienna.Size = New System.Drawing.Size(1969, 1126)
            Me.radPanoramaVienna.TabIndex = 0
            '
            'tileVienna01
            '
            Me.tileVienna01.ColSpan = 4
            Me.tileVienna01.Image = Global.My.Resources.Vienna_01
            Me.tileVienna01.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVienna01.Name = "tileVienna01"
            Me.tileVienna01.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVienna01.RowSpan = 6
            Me.tileVienna01.Text = "1"
            '
            'tileVienna02
            '
            Me.tileVienna02.ColSpan = 6
            Me.tileVienna02.Column = 4
            Me.tileVienna02.Image = Global.My.Resources.Vienna_02
            Me.tileVienna02.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVienna02.Name = "tileVienna02"
            Me.tileVienna02.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVienna02.RowSpan = 4
            Me.tileVienna02.Text = "2"
            '
            'tileVienna03
            '
            Me.tileVienna03.ColSpan = 3
            Me.tileVienna03.Column = 4
            Me.tileVienna03.Image = Global.My.Resources.Vienna_03
            Me.tileVienna03.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVienna03.Name = "tileVienna03"
            Me.tileVienna03.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVienna03.Row = 4
            Me.tileVienna03.RowSpan = 2
            Me.tileVienna03.Text = "3"
            '
            'tileVienna04
            '
            Me.tileVienna04.ColSpan = 3
            Me.tileVienna04.Column = 7
            Me.tileVienna04.Image = Global.My.Resources.Vienna_04
            Me.tileVienna04.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVienna04.Name = "tileVienna04"
            Me.tileVienna04.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVienna04.Row = 4
            Me.tileVienna04.RowSpan = 2
            Me.tileVienna04.Text = "4"
            '
            'tileVienna05
            '
            Me.tileVienna05.ColSpan = 4
            Me.tileVienna05.Column = 10
            Me.tileVienna05.Image = Global.My.Resources.Vienna_05
            Me.tileVienna05.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVienna05.Name = "tileVienna05"
            Me.tileVienna05.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVienna05.RowSpan = 6
            Me.tileVienna05.Text = "5"
            '
            'VenicePage
            '
            Me.VenicePage.Controls.Add(Me.radPanoramaVenice)
            Me.VenicePage.Image = Global.My.Resources.blue_venice
            Me.VenicePage.ItemSize = New System.Drawing.SizeF(38.0!, 36.0!)
            Me.VenicePage.Location = New System.Drawing.Point(41, 30)
            Me.VenicePage.Name = "VenicePage"
            Me.VenicePage.Size = New System.Drawing.Size(1969, 1126)
            Me.VenicePage.Text = "Venice"
            '
            'radPanoramaVenice
            '
            Me.radPanoramaVenice.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanoramaVenice.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tileVenice01, Me.tileVenice02, Me.tileVenice03, Me.tileVenice04, Me.tileVenice05, Me.tileVenice06, Me.tileVenice07, Me.tileVenice08, Me.tileVenice09, Me.tileVenice10})
            Me.radPanoramaVenice.Location = New System.Drawing.Point(0, 0)
            Me.radPanoramaVenice.Name = "radPanoramaVenice"
            Me.radPanoramaVenice.RowsCount = 11
            Me.radPanoramaVenice.ScrollBarAlignment = Telerik.WinControls.UI.HorizontalScrollAlignment.Bottom
            Me.radPanoramaVenice.Size = New System.Drawing.Size(1969, 1126)
            Me.radPanoramaVenice.TabIndex = 0
            '
            'tileVenice01
            '
            Me.tileVenice01.ColSpan = 3
            Me.tileVenice01.Image = Global.My.Resources.Venice_01
            Me.tileVenice01.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice01.Name = "tileVenice01"
            Me.tileVenice01.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice01.RowSpan = 2
            Me.tileVenice01.Text = "1"
            '
            'tileVenice02
            '
            Me.tileVenice02.ColSpan = 3
            Me.tileVenice02.Image = Global.My.Resources.Venice_02
            Me.tileVenice02.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice02.Name = "tileVenice02"
            Me.tileVenice02.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice02.Row = 2
            Me.tileVenice02.RowSpan = 2
            Me.tileVenice02.Text = "2"
            '
            'tileVenice03
            '
            Me.tileVenice03.ColSpan = 3
            Me.tileVenice03.Image = Global.My.Resources.Venice_03
            Me.tileVenice03.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice03.Name = "tileVenice03"
            Me.tileVenice03.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice03.Row = 4
            Me.tileVenice03.RowSpan = 2
            Me.tileVenice03.Text = "3"
            '
            'tileVenice04
            '
            Me.tileVenice04.ColSpan = 5
            Me.tileVenice04.Column = 3
            Me.tileVenice04.Image = Global.My.Resources.Venice_04
            Me.tileVenice04.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice04.Name = "tileVenice04"
            Me.tileVenice04.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice04.RowSpan = 6
            Me.tileVenice04.Text = "4"
            '
            'tileVenice05
            '
            Me.tileVenice05.ColSpan = 6
            Me.tileVenice05.Column = 8
            Me.tileVenice05.Image = Global.My.Resources.Venice_05
            Me.tileVenice05.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice05.Name = "tileVenice05"
            Me.tileVenice05.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice05.RowSpan = 4
            Me.tileVenice05.Text = "5"
            '
            'tileVenice06
            '
            Me.tileVenice06.ColSpan = 3
            Me.tileVenice06.Column = 8
            Me.tileVenice06.Image = Global.My.Resources.Venice_06
            Me.tileVenice06.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice06.Name = "tileVenice06"
            Me.tileVenice06.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice06.Row = 4
            Me.tileVenice06.RowSpan = 2
            Me.tileVenice06.Text = "6"
            '
            'tileVenice07
            '
            Me.tileVenice07.ColSpan = 3
            Me.tileVenice07.Column = 11
            Me.tileVenice07.Image = Global.My.Resources.Venice_07
            Me.tileVenice07.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice07.Name = "tileVenice07"
            Me.tileVenice07.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice07.Row = 4
            Me.tileVenice07.RowSpan = 2
            Me.tileVenice07.Text = "7"
            '
            'tileVenice08
            '
            Me.tileVenice08.ColSpan = 3
            Me.tileVenice08.Column = 10
            Me.tileVenice08.Image = Global.My.Resources.Venice_08
            Me.tileVenice08.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice08.Name = "tileVenice08"
            Me.tileVenice08.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice08.Row = 6
            Me.tileVenice08.RowSpan = 2
            Me.tileVenice08.Text = "8"
            '
            'tileVenice09
            '
            Me.tileVenice09.ColSpan = 4
            Me.tileVenice09.Image = Global.My.Resources.Venice_09
            Me.tileVenice09.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice09.Name = "tileVenice09"
            Me.tileVenice09.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice09.Row = 6
            Me.tileVenice09.RowSpan = 5
            Me.tileVenice09.Text = "9"
            '
            'tileVenice10
            '
            Me.tileVenice10.ColSpan = 6
            Me.tileVenice10.Column = 4
            Me.tileVenice10.Image = Global.My.Resources.Venice_10
            Me.tileVenice10.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileVenice10.Name = "tileVenice10"
            Me.tileVenice10.Padding = New System.Windows.Forms.Padding(2)
            Me.tileVenice10.Row = 6
            Me.tileVenice10.RowSpan = 4
            Me.tileVenice10.Text = "10"
            '
            'FlorencePage
            '
            Me.FlorencePage.Controls.Add(Me.radPanoramaFlorence)
            Me.FlorencePage.Image = Global.My.Resources.blue_florence
            Me.FlorencePage.ItemSize = New System.Drawing.SizeF(38.0!, 36.0!)
            Me.FlorencePage.Location = New System.Drawing.Point(41, 30)
            Me.FlorencePage.Name = "FlorencePage"
            Me.FlorencePage.Size = New System.Drawing.Size(1969, 1126)
            Me.FlorencePage.Text = "Florence"
            '
            'radPanoramaFlorence
            '
            Me.radPanoramaFlorence.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanoramaFlorence.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tileFlorence01, Me.tileFlorence02, Me.tileFlorence03, Me.tileFlorence04})
            Me.radPanoramaFlorence.Location = New System.Drawing.Point(0, 0)
            Me.radPanoramaFlorence.Name = "radPanoramaFlorence"
            Me.radPanoramaFlorence.RowsCount = 12
            Me.radPanoramaFlorence.ScrollBarAlignment = Telerik.WinControls.UI.HorizontalScrollAlignment.Bottom
            Me.radPanoramaFlorence.Size = New System.Drawing.Size(1969, 1126)
            Me.radPanoramaFlorence.TabIndex = 0
            '
            'tileFlorence01
            '
            Me.tileFlorence01.ColSpan = 6
            Me.tileFlorence01.Image = Global.My.Resources.Florence_01
            Me.tileFlorence01.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileFlorence01.Name = "tileFlorence01"
            Me.tileFlorence01.Padding = New System.Windows.Forms.Padding(2)
            Me.tileFlorence01.RowSpan = 4
            Me.tileFlorence01.Text = "1"
            '
            'tileFlorence02
            '
            Me.tileFlorence02.ColSpan = 3
            Me.tileFlorence02.Image = Global.My.Resources.Florence_02
            Me.tileFlorence02.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileFlorence02.Name = "tileFlorence02"
            Me.tileFlorence02.Padding = New System.Windows.Forms.Padding(2)
            Me.tileFlorence02.Row = 4
            Me.tileFlorence02.RowSpan = 2
            Me.tileFlorence02.Text = "2"
            '
            'tileFlorence03
            '
            Me.tileFlorence03.ColSpan = 3
            Me.tileFlorence03.Column = 3
            Me.tileFlorence03.Image = Global.My.Resources.Florence_03
            Me.tileFlorence03.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileFlorence03.Name = "tileFlorence03"
            Me.tileFlorence03.Padding = New System.Windows.Forms.Padding(2)
            Me.tileFlorence03.Row = 4
            Me.tileFlorence03.RowSpan = 2
            Me.tileFlorence03.Text = "3"
            '
            'tileFlorence04
            '
            Me.tileFlorence04.ColSpan = 5
            Me.tileFlorence04.Column = 6
            Me.tileFlorence04.Image = Global.My.Resources.Florence_04
            Me.tileFlorence04.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileFlorence04.Name = "tileFlorence04"
            Me.tileFlorence04.Padding = New System.Windows.Forms.Padding(2)
            Me.tileFlorence04.RowSpan = 6
            Me.tileFlorence04.Text = "4"
            '
            'EdinburghPage
            '
            Me.EdinburghPage.Controls.Add(Me.radPanoramaEdinburgh)
            Me.EdinburghPage.Image = Global.My.Resources.blue_edinburgh
            Me.EdinburghPage.ItemSize = New System.Drawing.SizeF(38.0!, 36.0!)
            Me.EdinburghPage.Location = New System.Drawing.Point(41, 30)
            Me.EdinburghPage.Name = "EdinburghPage"
            Me.EdinburghPage.Size = New System.Drawing.Size(1969, 1126)
            Me.EdinburghPage.Text = "Edinburgh"
            '
            'radPanoramaEdinburgh
            '
            Me.radPanoramaEdinburgh.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanoramaEdinburgh.Items.AddRange(New Telerik.WinControls.RadItem() {Me.tileEdinburgh01, Me.tileEdinburgh02, Me.tileEdinburgh03, Me.tileEdinburgh04, Me.tileEdinburgh05, Me.tileEdinburgh06, Me.tileEdinburgh07, Me.tileEdinburgh08, Me.tileEdinburgh09, Me.tileEdinburgh10, Me.tileEdinburgh11})
            Me.radPanoramaEdinburgh.Location = New System.Drawing.Point(0, 0)
            Me.radPanoramaEdinburgh.Name = "radPanoramaEdinburgh"
            Me.radPanoramaEdinburgh.RowsCount = 12
            Me.radPanoramaEdinburgh.ScrollBarAlignment = Telerik.WinControls.UI.HorizontalScrollAlignment.Bottom
            Me.radPanoramaEdinburgh.Size = New System.Drawing.Size(1969, 1126)
            Me.radPanoramaEdinburgh.TabIndex = 0
            '
            'tileEdinburgh01
            '
            Me.tileEdinburgh01.ColSpan = 4
            Me.tileEdinburgh01.Image = Global.My.Resources.Edinburgh_01
            Me.tileEdinburgh01.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh01.Name = "tileEdinburgh01"
            Me.tileEdinburgh01.RowSpan = 6
            Me.tileEdinburgh01.Text = "1"
            '
            'tileEdinburgh02
            '
            Me.tileEdinburgh02.ColSpan = 3
            Me.tileEdinburgh02.Column = 4
            Me.tileEdinburgh02.Image = Global.My.Resources.Edinburgh_02
            Me.tileEdinburgh02.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh02.Name = "tileEdinburgh02"
            Me.tileEdinburgh02.RowSpan = 2
            Me.tileEdinburgh02.Text = "2"
            '
            'tileEdinburgh03
            '
            Me.tileEdinburgh03.ColSpan = 3
            Me.tileEdinburgh03.Column = 4
            Me.tileEdinburgh03.Image = Global.My.Resources.Edinburgh_03
            Me.tileEdinburgh03.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh03.Name = "tileEdinburgh03"
            Me.tileEdinburgh03.Row = 2
            Me.tileEdinburgh03.RowSpan = 2
            Me.tileEdinburgh03.Text = "3"
            '
            'tileEdinburgh04
            '
            Me.tileEdinburgh04.ColSpan = 3
            Me.tileEdinburgh04.Column = 4
            Me.tileEdinburgh04.Image = Global.My.Resources.Edinburgh_04
            Me.tileEdinburgh04.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh04.Name = "tileEdinburgh04"
            Me.tileEdinburgh04.Row = 4
            Me.tileEdinburgh04.RowSpan = 2
            Me.tileEdinburgh04.Text = "4"
            '
            'tileEdinburgh05
            '
            Me.tileEdinburgh05.ClipText = False
            Me.tileEdinburgh05.ColSpan = 3
            Me.tileEdinburgh05.Column = 7
            Me.tileEdinburgh05.Image = Global.My.Resources.Edinburgh_05
            Me.tileEdinburgh05.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh05.Name = "tileEdinburgh05"
            Me.tileEdinburgh05.RowSpan = 2
            Me.tileEdinburgh05.Text = "5"
            '
            'tileEdinburgh06
            '
            Me.tileEdinburgh06.ColSpan = 3
            Me.tileEdinburgh06.Column = 7
            Me.tileEdinburgh06.Image = Global.My.Resources.Edinburgh_06
            Me.tileEdinburgh06.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh06.Name = "tileEdinburgh06"
            Me.tileEdinburgh06.Row = 2
            Me.tileEdinburgh06.RowSpan = 2
            Me.tileEdinburgh06.Text = "6"
            '
            'tileEdinburgh07
            '
            Me.tileEdinburgh07.ColSpan = 3
            Me.tileEdinburgh07.Column = 7
            Me.tileEdinburgh07.Image = Global.My.Resources.Edinburgh_07
            Me.tileEdinburgh07.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh07.Name = "tileEdinburgh07"
            Me.tileEdinburgh07.Row = 4
            Me.tileEdinburgh07.RowSpan = 2
            Me.tileEdinburgh07.Text = "7"
            '
            'tileEdinburgh08
            '
            Me.tileEdinburgh08.ColSpan = 4
            Me.tileEdinburgh08.Column = 10
            Me.tileEdinburgh08.Image = Global.My.Resources.Edinburgh_08
            Me.tileEdinburgh08.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh08.Name = "tileEdinburgh08"
            Me.tileEdinburgh08.RowSpan = 6
            Me.tileEdinburgh08.Text = "8"
            '
            'tileEdinburgh09
            '
            Me.tileEdinburgh09.ColSpan = 3
            Me.tileEdinburgh09.Image = Global.My.Resources.Edinburgh_09
            Me.tileEdinburgh09.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh09.Name = "tileEdinburgh09"
            Me.tileEdinburgh09.Row = 6
            Me.tileEdinburgh09.RowSpan = 2
            Me.tileEdinburgh09.Text = "9"
            '
            'tileEdinburgh10
            '
            Me.tileEdinburgh10.ColSpan = 3
            Me.tileEdinburgh10.Image = Global.My.Resources.Edinburgh_10
            Me.tileEdinburgh10.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh10.Name = "tileEdinburgh10"
            Me.tileEdinburgh10.Row = 8
            Me.tileEdinburgh10.RowSpan = 2
            Me.tileEdinburgh10.Text = "10"
            '
            'tileEdinburgh11
            '
            Me.tileEdinburgh11.ColSpan = 3
            Me.tileEdinburgh11.Column = 3
            Me.tileEdinburgh11.Image = Global.My.Resources.Edinburgh_11
            Me.tileEdinburgh11.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tileEdinburgh11.Name = "tileEdinburgh11"
            Me.tileEdinburgh11.Row = 6
            Me.tileEdinburgh11.RowSpan = 4
            Me.tileEdinburgh11.Text = "11"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPageView1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2011, 1157)
            Me.Controls.SetChildIndex(Me.radPageView1, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPageView1.ResumeLayout(False)
            Me.ParisPage.ResumeLayout(False)
            CType(Me.radPanoramaParis, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LondonPage.ResumeLayout(False)
            CType(Me.radPanoramaLondon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ViennaPage.ResumeLayout(False)
            CType(Me.radPanoramaVienna, System.ComponentModel.ISupportInitialize).EndInit()
            Me.VenicePage.ResumeLayout(False)
            CType(Me.radPanoramaVenice, System.ComponentModel.ISupportInitialize).EndInit()
            Me.FlorencePage.ResumeLayout(False)
            CType(Me.radPanoramaFlorence, System.ComponentModel.ISupportInitialize).EndInit()
            Me.EdinburghPage.ResumeLayout(False)
            CType(Me.radPanoramaEdinburgh, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radPageView1 As Telerik.WinControls.UI.RadPageView
        Private ParisPage As Telerik.WinControls.UI.RadPageViewPage
        Private LondonPage As Telerik.WinControls.UI.RadPageViewPage
        Private ViennaPage As Telerik.WinControls.UI.RadPageViewPage
        Private VenicePage As Telerik.WinControls.UI.RadPageViewPage
        Private FlorencePage As Telerik.WinControls.UI.RadPageViewPage
        Private radPanoramaParis As Telerik.WinControls.UI.RadPanorama
        Private tileParis01 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis02 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis03 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis04 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis05 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis06 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis07 As Telerik.WinControls.UI.RadLiveTileElement
        Private tileParis08 As Telerik.WinControls.UI.RadLiveTileElement
        Private radPanoramaLondon As Telerik.WinControls.UI.RadPanorama
        Private tileLondon01 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon02 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon03 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon04 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon05 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon06 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon07 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon08 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon09 As Telerik.WinControls.UI.RadTileElement
        Private tileLondon10 As Telerik.WinControls.UI.RadTileElement
        Private radPanoramaVienna As Telerik.WinControls.UI.RadPanorama
        Private tileVienna01 As Telerik.WinControls.UI.RadTileElement
        Private tileVienna02 As Telerik.WinControls.UI.RadTileElement
        Private tileVienna03 As Telerik.WinControls.UI.RadTileElement
        Private tileVienna04 As Telerik.WinControls.UI.RadTileElement
        Private tileVienna05 As Telerik.WinControls.UI.RadTileElement
        Private radPanoramaVenice As Telerik.WinControls.UI.RadPanorama
        Private tileVenice01 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice02 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice03 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice04 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice05 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice06 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice07 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice08 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice09 As Telerik.WinControls.UI.RadTileElement
        Private tileVenice10 As Telerik.WinControls.UI.RadTileElement
        Private radPanoramaFlorence As Telerik.WinControls.UI.RadPanorama
        Private tileFlorence01 As Telerik.WinControls.UI.RadTileElement
        Private tileFlorence02 As Telerik.WinControls.UI.RadTileElement
        Private tileFlorence03 As Telerik.WinControls.UI.RadTileElement
        Private tileFlorence04 As Telerik.WinControls.UI.RadTileElement
        Private EdinburghPage As Telerik.WinControls.UI.RadPageViewPage
        Private radPanoramaEdinburgh As Telerik.WinControls.UI.RadPanorama
        Private tileEdinburgh01 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh02 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh03 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh04 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh05 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh06 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh07 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh08 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh09 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh10 As Telerik.WinControls.UI.RadTileElement
        Private tileEdinburgh11 As Telerik.WinControls.UI.RadTileElement
    End Class
End Namespace
