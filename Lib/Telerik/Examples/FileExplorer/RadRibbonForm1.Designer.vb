Namespace FileExplorer
	Partial Public Class RadRibbonForm1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadRibbonForm1))
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.historyButton = New Telerik.WinControls.UI.RadDropDownButton()
            Me.upButton = New Telerik.WinControls.UI.RadButton()
            Me.radTextBox1 = New Telerik.WinControls.UI.RadTextBox()
            Me.refreshButton = New Telerik.WinControls.UI.RadButton()
            Me.radBreadCrumb1 = New Telerik.WinControls.UI.RadBreadCrumb()
            Me.forwardButton = New Telerik.WinControls.UI.RadButton()
            Me.backButton = New Telerik.WinControls.UI.RadButton()
            Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
            Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.splitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.splitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.radListView1 = New Telerik.WinControls.UI.RadListView()
            Me.office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
            Me.office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
            Me.office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
            Me.telerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
            Me.radStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
            Me.directoryInfoLabel = New Telerik.WinControls.UI.RadLabelElement()
            Me.radCommandBarSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.selectedItemInfoLabel = New Telerik.WinControls.UI.RadLabelElement()
            Me.separatorLabel = New Telerik.WinControls.UI.RadLabelElement()
            Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
            Me.ribbonTab1 = New Telerik.WinControls.UI.RibbonTab()
            Me.radRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radDropDownButtonElement1 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.pasteMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.pasteAsShortcutMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radRibbonBarButtonGroup1 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.cutButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.copyButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.copyAsPathButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.newFolderButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.radDropDownButtonElement2 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.radRibbonBarGroup3 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radDropDownButtonElement3 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.deleteSelectionMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.deleteAllMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radRibbonBarButtonGroup2 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.copyToFolderButton = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.renameButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup4 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radGalleryElement1 = New Telerik.WinControls.UI.RadGalleryElement()
            Me.radGalleryItem1 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radGalleryItem2 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radGalleryItem3 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radGalleryItem4 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radGalleryItem5 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radGalleryItem6 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radRibbonBarGroup5 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radDropDownButtonElement5 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.radButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarButtonGroup3 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radDropDownButtonElement6 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.radButtonElement9 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement10 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup6 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.selectAllButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarButtonGroup4 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radButtonElement11 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement12 = New Telerik.WinControls.UI.RadButtonElement()
            Me.ribbonTab2 = New Telerik.WinControls.UI.RibbonTab()
            Me.radRibbonBarGroup7 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radButtonElement13 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement14 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement15 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup8 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radGalleryElement2 = New Telerik.WinControls.UI.RadGalleryElement()
            Me.radGalleryItem7 = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radRibbonBarGroup9 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radRibbonBarButtonGroup5 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radButtonElement16 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement17 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup10 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radDropDownButtonElement7 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.ribbonTab3 = New Telerik.WinControls.UI.RibbonTab()
            Me.radRibbonBarGroup11 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.refreshButtonInRibbon = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup12 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radGalleryElement3 = New Telerik.WinControls.UI.RadGalleryElement()
            Me.extraLargeIconsGaleryItem = New Telerik.WinControls.UI.RadGalleryItem()
            Me.mediumIconsGaleryItem = New Telerik.WinControls.UI.RadGalleryItem()
            Me.listGaleryItem = New Telerik.WinControls.UI.RadGalleryItem()
            Me.largeIconsGaleryItem = New Telerik.WinControls.UI.RadGalleryItem()
            Me.smallIconsGaleryItem = New Telerik.WinControls.UI.RadGalleryItem()
            Me.detailsGaleryItem = New Telerik.WinControls.UI.RadGalleryItem()
            Me.radRibbonBarGroup13 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.sortByButton = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.sortByNameMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.sortByDateModifiedMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.sortByTypeMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.sortBySizeMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radRibbonBarButtonGroup6 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radDropDownButtonElement9 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.radDropDownButtonElement10 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.radButtonElement19 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup14 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radDropDownButtonElement11 = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.radButtonElement20 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radButtonElement21 = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup15 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radRibbonBarButtonGroup7 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radCheckBoxElement1 = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.radCheckBoxElement2 = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.radCheckBoxElement3 = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.radButtonElement22 = New Telerik.WinControls.UI.RadButtonElement()
            Me.RibbonTab4 = New Telerik.WinControls.UI.RibbonTab()
            Me.RadRibbonBarGroup16 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.RadGalleryElement4 = New Telerik.WinControls.UI.RadGalleryElement()
            Me.office2010BlackButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.office2010BlueButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.office2010SilverButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.controlDefaultButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.telerikMetroButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.openNewWindowMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.openCommandPromptMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.addSelectedFolderToFavoritesMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.includeInLibraryMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.mapSelectedFolderAsDriveMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.clearHistoryMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.printMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem4 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.syncMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.folderOptionsMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem6 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.helpMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem7 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.closeMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.frequentPlacesMenuItem = New Telerik.WinControls.UI.RadMenuHeaderItem()
            Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            CType(Me.historyButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.upButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radBreadCrumb1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.forwardButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer1.SuspendLayout()
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel1.SuspendLayout()
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitPanel2.SuspendLayout()
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanel1
            '
            Me.radPanel1.Controls.Add(Me.historyButton)
            Me.radPanel1.Controls.Add(Me.upButton)
            Me.radPanel1.Controls.Add(Me.radTextBox1)
            Me.radPanel1.Controls.Add(Me.refreshButton)
            Me.radPanel1.Controls.Add(Me.radBreadCrumb1)
            Me.radPanel1.Controls.Add(Me.forwardButton)
            Me.radPanel1.Controls.Add(Me.backButton)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radPanel1.Location = New System.Drawing.Point(0, 158)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Size = New System.Drawing.Size(1065, 40)
            Me.radPanel1.TabIndex = 0
            '
            'historyButton
            '
            Me.historyButton.Image = Global.My.Resources.Resources.history
            Me.historyButton.Location = New System.Drawing.Point(79, 12)
            Me.historyButton.Name = "historyButton"
            Me.historyButton.Size = New System.Drawing.Size(16, 16)
            Me.historyButton.TabIndex = 7
            '
            'upButton
            '
            Me.upButton.AutoSize = True
            Me.upButton.Image = Global.My.Resources.Resources.up
            Me.upButton.Location = New System.Drawing.Point(101, 12)
            Me.upButton.Name = "upButton"
            Me.upButton.Size = New System.Drawing.Size(18, 18)
            Me.upButton.TabIndex = 6
            '
            'radTextBox1
            '
            Me.radTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.radTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
            Me.radTextBox1.Location = New System.Drawing.Point(851, 10)
            Me.radTextBox1.Name = "radTextBox1"
            Me.radTextBox1.Size = New System.Drawing.Size(202, 20)
            Me.radTextBox1.TabIndex = 5
            Me.radTextBox1.TabStop = False
            '
            'refreshButton
            '
            Me.refreshButton.AutoSize = True
            Me.refreshButton.Image = Global.My.Resources.Resources.refresh
            Me.refreshButton.Location = New System.Drawing.Point(825, 12)
            Me.refreshButton.Name = "refreshButton"
            Me.refreshButton.Size = New System.Drawing.Size(18, 18)
            Me.refreshButton.TabIndex = 4
            '
            'radBreadCrumb1
            '
            Me.radBreadCrumb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radBreadCrumb1.Location = New System.Drawing.Point(125, 6)
            Me.radBreadCrumb1.Name = "radBreadCrumb1"
            Me.radBreadCrumb1.Size = New System.Drawing.Size(694, 28)
            Me.radBreadCrumb1.TabIndex = 3
            Me.radBreadCrumb1.Text = "radBreadCrumb1"
            Me.radBreadCrumb1.ThemeName = "Office2007Black"
            '
            'forwardButton
            '
            Me.forwardButton.Image = Global.My.Resources.Resources.foward
            Me.forwardButton.Location = New System.Drawing.Point(46, 4)
            Me.forwardButton.Name = "forwardButton"
            Me.forwardButton.Size = New System.Drawing.Size(32, 32)
            Me.forwardButton.TabIndex = 1
            '
            'backButton
            '
            Me.backButton.Image = Global.My.Resources.Resources.back
            Me.backButton.Location = New System.Drawing.Point(12, 4)
            Me.backButton.Name = "backButton"
            Me.backButton.Size = New System.Drawing.Size(32, 32)
            Me.backButton.TabIndex = 0
            '
            'radTreeView1
            '
            Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radTreeView1.Location = New System.Drawing.Point(0, 0)
            Me.radTreeView1.Name = "radTreeView1"
            Me.radTreeView1.Size = New System.Drawing.Size(307, 384)
            Me.radTreeView1.SpacingBetweenNodes = -1
            Me.radTreeView1.TabIndex = 2
            Me.radTreeView1.Text = "radTreeView1"
            '
            'radSplitContainer1
            '
            Me.radSplitContainer1.Controls.Add(Me.splitPanel1)
            Me.radSplitContainer1.Controls.Add(Me.splitPanel2)
            Me.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radSplitContainer1.Location = New System.Drawing.Point(0, 198)
            Me.radSplitContainer1.Name = "radSplitContainer1"
            '
            '
            '
            Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer1.Size = New System.Drawing.Size(1065, 384)
            Me.radSplitContainer1.TabIndex = 4
            Me.radSplitContainer1.TabStop = False
            Me.radSplitContainer1.Text = "radSplitContainer1"
            '
            'splitPanel1
            '
            Me.splitPanel1.Controls.Add(Me.radTreeView1)
            Me.splitPanel1.Location = New System.Drawing.Point(0, 0)
            Me.splitPanel1.Name = "splitPanel1"
            '
            '
            '
            Me.splitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel1.Size = New System.Drawing.Size(307, 384)
            Me.splitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2112583!, 0.0!)
            Me.splitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-160, 0)
            Me.splitPanel1.TabIndex = 0
            Me.splitPanel1.TabStop = False
            Me.splitPanel1.Text = "splitPanel1"
            '
            'splitPanel2
            '
            Me.splitPanel2.Controls.Add(Me.radListView1)
            Me.splitPanel2.Location = New System.Drawing.Point(310, 0)
            Me.splitPanel2.Name = "splitPanel2"
            '
            '
            '
            Me.splitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.splitPanel2.Size = New System.Drawing.Size(755, 384)
            Me.splitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2112583!, 0.0!)
            Me.splitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(160, 0)
            Me.splitPanel2.TabIndex = 1
            Me.splitPanel2.TabStop = False
            Me.splitPanel2.Text = "splitPanel2"
            '
            'radListView1
            '
            Me.radListView1.CurrentColumn = Nothing
            Me.radListView1.CurrentItem = Nothing
            Me.radListView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radListView1.GroupItemSize = New System.Drawing.Size(200, 20)
            Me.radListView1.ItemSize = New System.Drawing.Size(200, 20)
            Me.radListView1.Location = New System.Drawing.Point(0, 0)
            Me.radListView1.Name = "radListView1"
            Me.radListView1.SelectedIndex = -1
            Me.radListView1.SelectedItem = Nothing
            Me.radListView1.Size = New System.Drawing.Size(755, 384)
            Me.radListView1.TabIndex = 0
            Me.radListView1.Text = "radListView1"
            '
            'radStatusStrip1
            '
            Me.radStatusStrip1.AutoSize = True
            Me.radStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.directoryInfoLabel, Me.radCommandBarSeparatorItem1, Me.selectedItemInfoLabel, Me.separatorLabel})
            Me.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack
            Me.radStatusStrip1.Location = New System.Drawing.Point(0, 582)
            Me.radStatusStrip1.Name = "radStatusStrip1"
            Me.radStatusStrip1.Padding = New System.Windows.Forms.Padding(3)
            '
            '
            '
            Me.radStatusStrip1.RootElement.Padding = New System.Windows.Forms.Padding(3)
            Me.radStatusStrip1.Size = New System.Drawing.Size(1065, 28)
            Me.radStatusStrip1.TabIndex = 0
            Me.radStatusStrip1.Text = "radStatusStrip1"
            '
            'directoryInfoLabel
            '
            Me.directoryInfoLabel.Margin = New System.Windows.Forms.Padding(1)
            Me.directoryInfoLabel.Name = "directoryInfoLabel"
            Me.radStatusStrip1.SetSpring(Me.directoryInfoLabel, False)
            Me.directoryInfoLabel.Text = ""
            Me.directoryInfoLabel.TextWrap = True
            Me.directoryInfoLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radToolStripSeparatorItem1
            '
            Me.radCommandBarSeparatorItem1.AccessibleDescription = "radToolStripSeparatorItem1"
            Me.radCommandBarSeparatorItem1.AccessibleName = "radToolStripSeparatorItem1"
            Me.radCommandBarSeparatorItem1.Margin = New System.Windows.Forms.Padding(1)
            Me.radCommandBarSeparatorItem1.Name = "radToolStripSeparatorItem1"
            Me.radStatusStrip1.SetSpring(Me.radCommandBarSeparatorItem1, False)
            Me.radCommandBarSeparatorItem1.Text = "radToolStripSeparatorItem1"
            Me.radCommandBarSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'selectedItemInfoLabel
            '
            Me.selectedItemInfoLabel.Margin = New System.Windows.Forms.Padding(1)
            Me.selectedItemInfoLabel.Name = "selectedItemInfoLabel"
            Me.radStatusStrip1.SetSpring(Me.selectedItemInfoLabel, False)
            Me.selectedItemInfoLabel.Text = ""
            Me.selectedItemInfoLabel.TextWrap = True
            Me.selectedItemInfoLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'separatorLabel
            '
            Me.separatorLabel.Margin = New System.Windows.Forms.Padding(1)
            Me.separatorLabel.Name = "separatorLabel"
            Me.radStatusStrip1.SetSpring(Me.separatorLabel, True)
            Me.separatorLabel.Text = ""
            Me.separatorLabel.TextWrap = True
            Me.separatorLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBar1
            '
            Me.radRibbonBar1.AutoSize = True
            Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.ribbonTab1, Me.ribbonTab2, Me.ribbonTab3, Me.RibbonTab4})
            Me.radRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
            '
            '
            '
            Me.radRibbonBar1.ExitButton.AccessibleDescription = "Exit"
            Me.radRibbonBar1.ExitButton.AccessibleName = "Exit"
            '
            '
            '
            Me.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit"
            Me.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit"
            Me.radRibbonBar1.ExitButton.Text = "Exit"
            Me.radRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.radRibbonBar1.Name = "radRibbonBar1"
            '
            '
            '
            Me.radRibbonBar1.OptionsButton.AccessibleDescription = "Options"
            Me.radRibbonBar1.OptionsButton.AccessibleName = "Options"
            '
            '
            '
            Me.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options"
            Me.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options"
            Me.radRibbonBar1.OptionsButton.Text = "Options"
            Me.radRibbonBar1.Size = New System.Drawing.Size(1065, 158)
            Me.radRibbonBar1.StartButtonImage = CType(resources.GetObject("radRibbonBar1.StartButtonImage"), System.Drawing.Image)
            Me.radRibbonBar1.StartMenuItems.AddRange(New Telerik.WinControls.RadItem() {Me.openNewWindowMenuItem, Me.openCommandPromptMenuItem, Me.radMenuSeparatorItem1, Me.addSelectedFolderToFavoritesMenuItem, Me.includeInLibraryMenuItem, Me.mapSelectedFolderAsDriveMenuItem, Me.radMenuSeparatorItem2, Me.clearHistoryMenuItem, Me.radMenuSeparatorItem3, Me.printMenuItem, Me.radMenuSeparatorItem4, Me.syncMenuItem, Me.radMenuSeparatorItem5, Me.folderOptionsMenuItem, Me.radMenuSeparatorItem6, Me.helpMenuItem, Me.radMenuSeparatorItem7, Me.closeMenuItem})
            Me.radRibbonBar1.StartMenuRightColumnItems.AddRange(New Telerik.WinControls.RadItem() {Me.frequentPlacesMenuItem, Me.radMenuSeparatorItem8})
            Me.radRibbonBar1.TabIndex = 5
            Me.radRibbonBar1.Text = "RadForm1"
            '
            'ribbonTab1
            '
            Me.ribbonTab1.AccessibleDescription = "Home"
            Me.ribbonTab1.AccessibleName = "Home"
            Me.ribbonTab1.Alignment = System.Drawing.ContentAlignment.BottomLeft
            Me.ribbonTab1.Class = "RibbonTab"
            Me.ribbonTab1.IsSelected = True
            Me.ribbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarGroup1, Me.radRibbonBarGroup2, Me.radRibbonBarGroup3, Me.radRibbonBarGroup4, Me.radRibbonBarGroup5, Me.radRibbonBarGroup6})
            Me.ribbonTab1.Name = "ribbonTab1"
            Me.ribbonTab1.StretchHorizontally = False
            Me.ribbonTab1.Text = "Home"
            Me.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup1
            '
            Me.radRibbonBarGroup1.AccessibleDescription = "Clipboard"
            Me.radRibbonBarGroup1.AccessibleName = "Clipboard"
            Me.radRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement1, Me.radRibbonBarButtonGroup1})
            Me.radRibbonBarGroup1.Name = "radRibbonBarGroup1"
            Me.radRibbonBarGroup1.Text = "Clipboard"
            Me.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement1
            '
            Me.radDropDownButtonElement1.AccessibleDescription = "Paste"
            Me.radDropDownButtonElement1.AccessibleName = "Paste"
            Me.radDropDownButtonElement1.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement1.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
            Me.radDropDownButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement1.ExpandArrowButton = False
            Me.radDropDownButtonElement1.Image = Global.My.Resources.Resources._1_paste
            Me.radDropDownButtonElement1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.pasteMenuItem, Me.pasteAsShortcutMenuItem})
            Me.radDropDownButtonElement1.Name = "radDropDownButtonElement1"
            Me.radDropDownButtonElement1.Text = "Paste"
            Me.radDropDownButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radDropDownButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'pasteMenuItem
            '
            Me.pasteMenuItem.AccessibleDescription = "Paste"
            Me.pasteMenuItem.AccessibleName = "Paste"
            Me.pasteMenuItem.Name = "pasteMenuItem"
            Me.pasteMenuItem.Text = "Paste"
            Me.pasteMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'pasteAsShortcutMenuItem
            '
            Me.pasteAsShortcutMenuItem.AccessibleDescription = "Paste as shortcut"
            Me.pasteAsShortcutMenuItem.AccessibleName = "Paste as shortcut"
            Me.pasteAsShortcutMenuItem.Name = "pasteAsShortcutMenuItem"
            Me.pasteAsShortcutMenuItem.Text = "Paste as shortcut"
            Me.pasteAsShortcutMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup1
            '
            Me.radRibbonBarButtonGroup1.AccessibleDescription = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.AccessibleName = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.cutButton, Me.copyButton, Me.copyAsPathButton})
            Me.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup1.StretchVertically = True
            Me.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cutButton
            '
            Me.cutButton.AccessibleDescription = "Cut"
            Me.cutButton.AccessibleName = "Cut"
            Me.cutButton.Class = "ButtonElement"
            Me.cutButton.Image = Global.My.Resources.Resources._1_cut
            Me.cutButton.Name = "cutButton"
            Me.cutButton.ShowBorder = False
            Me.cutButton.Text = "Cut"
            Me.cutButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.cutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.cutButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'copyButton
            '
            Me.copyButton.AccessibleDescription = "Copy"
            Me.copyButton.AccessibleName = "Copy"
            Me.copyButton.Class = "ButtonElement"
            Me.copyButton.Image = Global.My.Resources.Resources._1_copy
            Me.copyButton.Name = "copyButton"
            Me.copyButton.ShowBorder = False
            Me.copyButton.Text = "Copy"
            Me.copyButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.copyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.copyButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'copyAsPathButton
            '
            Me.copyAsPathButton.AccessibleDescription = "Copy as path"
            Me.copyAsPathButton.AccessibleName = "Copy as path"
            Me.copyAsPathButton.Class = "ButtonElement"
            Me.copyAsPathButton.Image = Global.My.Resources.Resources._1_copy_as_path
            Me.copyAsPathButton.Name = "copyAsPathButton"
            Me.copyAsPathButton.ShowBorder = False
            Me.copyAsPathButton.Text = "Copy as path"
            Me.copyAsPathButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.copyAsPathButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.copyAsPathButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup2
            '
            Me.radRibbonBarGroup2.AccessibleDescription = "New"
            Me.radRibbonBarGroup2.AccessibleName = "New"
            Me.radRibbonBarGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.newFolderButton, Me.radDropDownButtonElement2})
            Me.radRibbonBarGroup2.Name = "radRibbonBarGroup2"
            Me.radRibbonBarGroup2.Text = "New"
            Me.radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'newFolderButton
            '
            Me.newFolderButton.AccessibleDescription = "New folder"
            Me.newFolderButton.AccessibleName = "New folder"
            Me.newFolderButton.Class = "RibbonBarButtonElement"
            Me.newFolderButton.Image = Global.My.Resources.Resources._1_new_folder
            Me.newFolderButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.newFolderButton.Name = "newFolderButton"
            Me.newFolderButton.Text = "New folder"
            Me.newFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.newFolderButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement2
            '
            Me.radDropDownButtonElement2.AccessibleDescription = "New items"
            Me.radDropDownButtonElement2.AccessibleName = "New items"
            Me.radDropDownButtonElement2.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement2.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
            Me.radDropDownButtonElement2.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement2.ExpandArrowButton = False
            Me.radDropDownButtonElement2.Image = Global.My.Resources.Resources._1_new_items
            Me.radDropDownButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radDropDownButtonElement2.Name = "radDropDownButtonElement2"
            Me.radDropDownButtonElement2.Text = "New items"
            Me.radDropDownButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radDropDownButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup3
            '
            Me.radRibbonBarGroup3.AccessibleDescription = "Organize"
            Me.radRibbonBarGroup3.AccessibleName = "Organize"
            Me.radRibbonBarGroup3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement3, Me.radRibbonBarButtonGroup2})
            Me.radRibbonBarGroup3.Name = "radRibbonBarGroup3"
            Me.radRibbonBarGroup3.Text = "Organize"
            Me.radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement3
            '
            Me.radDropDownButtonElement3.AccessibleDescription = "Delete"
            Me.radDropDownButtonElement3.AccessibleName = "Delete"
            Me.radDropDownButtonElement3.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement3.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
            Me.radDropDownButtonElement3.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement3.ExpandArrowButton = False
            Me.radDropDownButtonElement3.Image = Global.My.Resources.Resources._1_delete
            Me.radDropDownButtonElement3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radDropDownButtonElement3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.deleteSelectionMenuItem, Me.deleteAllMenuItem})
            Me.radDropDownButtonElement3.Name = "radDropDownButtonElement3"
            Me.radDropDownButtonElement3.Text = "Delete"
            Me.radDropDownButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radDropDownButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'deleteSelectionMenuItem
            '
            Me.deleteSelectionMenuItem.AccessibleDescription = "Delete selection"
            Me.deleteSelectionMenuItem.AccessibleName = "Delete selection"
            Me.deleteSelectionMenuItem.Name = "deleteSelectionMenuItem"
            Me.deleteSelectionMenuItem.Text = "Delete selection"
            Me.deleteSelectionMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'deleteAllMenuItem
            '
            Me.deleteAllMenuItem.AccessibleDescription = "Delete all"
            Me.deleteAllMenuItem.AccessibleName = "Delete all"
            Me.deleteAllMenuItem.Name = "deleteAllMenuItem"
            Me.deleteAllMenuItem.Text = "Delete all"
            Me.deleteAllMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup2
            '
            Me.radRibbonBarButtonGroup2.AccessibleDescription = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.AccessibleName = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.copyToFolderButton, Me.renameButton, Me.radButtonElement6})
            Me.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup2.StretchVertically = True
            Me.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'copyToFolderButton
            '
            Me.copyToFolderButton.AccessibleDescription = "Copy to folder"
            Me.copyToFolderButton.AccessibleName = "Copy to folder"
            Me.copyToFolderButton.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.copyToFolderButton.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.copyToFolderButton.ExpandArrowButton = False
            Me.copyToFolderButton.Image = Global.My.Resources.Resources._1_copy_to_folder
            Me.copyToFolderButton.Name = "copyToFolderButton"
            Me.copyToFolderButton.Text = "Copy to folder"
            Me.copyToFolderButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.copyToFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.copyToFolderButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'renameButton
            '
            Me.renameButton.AccessibleDescription = "Rename"
            Me.renameButton.AccessibleName = "Rename"
            Me.renameButton.Class = "ButtonElement"
            Me.renameButton.Image = Global.My.Resources.Resources._1_rename
            Me.renameButton.Name = "renameButton"
            Me.renameButton.ShowBorder = False
            Me.renameButton.Text = "Rename"
            Me.renameButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.renameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.renameButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement6
            '
            Me.radButtonElement6.AccessibleDescription = "Zip"
            Me.radButtonElement6.AccessibleName = "Zip"
            Me.radButtonElement6.Class = "ButtonElement"
            Me.radButtonElement6.Image = Global.My.Resources.Resources._1_zip
            Me.radButtonElement6.Name = "radButtonElement6"
            Me.radButtonElement6.ShowBorder = False
            Me.radButtonElement6.Text = "Zip"
            Me.radButtonElement6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonElement6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup4
            '
            Me.radRibbonBarGroup4.AccessibleDescription = "Move to folder"
            Me.radRibbonBarGroup4.AccessibleName = "Move to folder"
            Me.radRibbonBarGroup4.AutoSize = True
            Me.radRibbonBarGroup4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radGalleryElement1})
            Me.radRibbonBarGroup4.Margin = New System.Windows.Forms.Padding(0)
            Me.radRibbonBarGroup4.MaxSize = New System.Drawing.Size(0, 0)
            Me.radRibbonBarGroup4.MinSize = New System.Drawing.Size(0, 0)
            Me.radRibbonBarGroup4.Name = "radRibbonBarGroup4"
            Me.radRibbonBarGroup4.Text = "Move to folder"
            Me.radRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryElement1
            '
            Me.radGalleryElement1.AccessibleDescription = "radGalleryElement1"
            Me.radGalleryElement1.AccessibleName = "radGalleryElement1"
            Me.radGalleryElement1.AutoSize = False
            Me.radGalleryElement1.Bounds = New System.Drawing.Rectangle(0, 0, 260, 69)
            Me.radGalleryElement1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radGalleryItem1, Me.radGalleryItem2, Me.radGalleryItem3, Me.radGalleryItem4, Me.radGalleryItem5, Me.radGalleryItem6})
            Me.radGalleryElement1.Name = "radGalleryElement1"
            Me.radGalleryElement1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
            Me.radGalleryElement1.Text = "radGalleryElement1"
            Me.radGalleryElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem1
            '
            Me.radGalleryItem1.AccessibleDescription = "system32"
            Me.radGalleryItem1.AccessibleName = "system32"
            Me.radGalleryItem1.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radGalleryItem1.DescriptionText = ""
            Me.radGalleryItem1.Image = Global.My.Resources.Resources._1_system_32
            Me.radGalleryItem1.Name = "radGalleryItem1"
            Me.radGalleryItem1.StretchHorizontally = False
            Me.radGalleryItem1.StretchVertically = False
            Me.radGalleryItem1.Text = "system32"
            Me.radGalleryItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radGalleryItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radGalleryItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem2
            '
            Me.radGalleryItem2.AccessibleDescription = "Local Disk"
            Me.radGalleryItem2.AccessibleName = "Local Disk"
            Me.radGalleryItem2.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radGalleryItem2.DescriptionText = ""
            Me.radGalleryItem2.Image = Global.My.Resources.Resources._1_local_disc
            Me.radGalleryItem2.Name = "radGalleryItem2"
            Me.radGalleryItem2.StretchHorizontally = False
            Me.radGalleryItem2.StretchVertically = False
            Me.radGalleryItem2.Text = "Local Disk"
            Me.radGalleryItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radGalleryItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radGalleryItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem3
            '
            Me.radGalleryItem3.AccessibleDescription = "Desktop"
            Me.radGalleryItem3.AccessibleName = "Desktop"
            Me.radGalleryItem3.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radGalleryItem3.DescriptionText = ""
            Me.radGalleryItem3.Image = Global.My.Resources.Resources._1_desktop
            Me.radGalleryItem3.Name = "radGalleryItem3"
            Me.radGalleryItem3.StretchHorizontally = False
            Me.radGalleryItem3.StretchVertically = False
            Me.radGalleryItem3.Text = "Desktop"
            Me.radGalleryItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radGalleryItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radGalleryItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem4
            '
            Me.radGalleryItem4.AccessibleDescription = "Downloads"
            Me.radGalleryItem4.AccessibleName = "Downloads"
            Me.radGalleryItem4.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radGalleryItem4.DescriptionText = ""
            Me.radGalleryItem4.Image = Global.My.Resources.Resources._1_downloads
            Me.radGalleryItem4.Name = "radGalleryItem4"
            Me.radGalleryItem4.StretchHorizontally = False
            Me.radGalleryItem4.StretchVertically = False
            Me.radGalleryItem4.Text = "Downloads"
            Me.radGalleryItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radGalleryItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radGalleryItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem5
            '
            Me.radGalleryItem5.AccessibleDescription = "Documents"
            Me.radGalleryItem5.AccessibleName = "Documents"
            Me.radGalleryItem5.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radGalleryItem5.DescriptionText = ""
            Me.radGalleryItem5.Image = Global.My.Resources.Resources._1_documents
            Me.radGalleryItem5.Name = "radGalleryItem5"
            Me.radGalleryItem5.StretchHorizontally = False
            Me.radGalleryItem5.StretchVertically = False
            Me.radGalleryItem5.Text = "Documents"
            Me.radGalleryItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radGalleryItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radGalleryItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem6
            '
            Me.radGalleryItem6.AccessibleDescription = "Music"
            Me.radGalleryItem6.AccessibleName = "Music"
            Me.radGalleryItem6.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radGalleryItem6.DescriptionText = ""
            Me.radGalleryItem6.Image = Global.My.Resources.Resources._1_music
            Me.radGalleryItem6.Name = "radGalleryItem6"
            Me.radGalleryItem6.StretchHorizontally = False
            Me.radGalleryItem6.StretchVertically = False
            Me.radGalleryItem6.Text = "Music"
            Me.radGalleryItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radGalleryItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radGalleryItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup5
            '
            Me.radRibbonBarGroup5.AccessibleDescription = "Open"
            Me.radRibbonBarGroup5.AccessibleName = "Open"
            Me.radRibbonBarGroup5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement5, Me.radButtonElement7, Me.radRibbonBarButtonGroup3})
            Me.radRibbonBarGroup5.Name = "radRibbonBarGroup5"
            Me.radRibbonBarGroup5.Text = "Open"
            Me.radRibbonBarGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement5
            '
            Me.radDropDownButtonElement5.AccessibleDescription = "Properties"
            Me.radDropDownButtonElement5.AccessibleName = "Properties"
            Me.radDropDownButtonElement5.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement5.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
            Me.radDropDownButtonElement5.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement5.ExpandArrowButton = False
            Me.radDropDownButtonElement5.Image = Global.My.Resources.Resources._1_properties
            Me.radDropDownButtonElement5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radDropDownButtonElement5.Name = "radDropDownButtonElement5"
            Me.radDropDownButtonElement5.Text = "Properties"
            Me.radDropDownButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radDropDownButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement7
            '
            Me.radButtonElement7.AccessibleDescription = "Open"
            Me.radButtonElement7.AccessibleName = "Open"
            Me.radButtonElement7.Class = "RibbonBarButtonElement"
            Me.radButtonElement7.Image = Global.My.Resources.Resources._1_open
            Me.radButtonElement7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElement7.Name = "radButtonElement7"
            Me.radButtonElement7.Text = "Open"
            Me.radButtonElement7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup3
            '
            Me.radRibbonBarButtonGroup3.AccessibleDescription = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.AccessibleName = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement6, Me.radButtonElement9, Me.radButtonElement10})
            Me.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup3.StretchVertically = True
            Me.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement6
            '
            Me.radDropDownButtonElement6.AccessibleDescription = "Open with"
            Me.radDropDownButtonElement6.AccessibleName = "Open with"
            Me.radDropDownButtonElement6.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement6.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement6.ExpandArrowButton = False
            Me.radDropDownButtonElement6.Image = Global.My.Resources.Resources._1_open_with
            Me.radDropDownButtonElement6.Name = "radDropDownButtonElement6"
            Me.radDropDownButtonElement6.Text = "Open with"
            Me.radDropDownButtonElement6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radDropDownButtonElement6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radDropDownButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement9
            '
            Me.radButtonElement9.AccessibleDescription = "History"
            Me.radButtonElement9.AccessibleName = "History"
            Me.radButtonElement9.Class = "ButtonElement"
            Me.radButtonElement9.Image = Global.My.Resources.Resources._1_history
            Me.radButtonElement9.Name = "radButtonElement9"
            Me.radButtonElement9.ShowBorder = False
            Me.radButtonElement9.Text = "History"
            Me.radButtonElement9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonElement9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement10
            '
            Me.radButtonElement10.AccessibleDescription = "Edit"
            Me.radButtonElement10.AccessibleName = "Edit"
            Me.radButtonElement10.Class = "ButtonElement"
            Me.radButtonElement10.Image = Global.My.Resources.Resources._1_edit
            Me.radButtonElement10.Name = "radButtonElement10"
            Me.radButtonElement10.ShowBorder = False
            Me.radButtonElement10.Text = "Edit"
            Me.radButtonElement10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonElement10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup6
            '
            Me.radRibbonBarGroup6.AccessibleDescription = "Select"
            Me.radRibbonBarGroup6.AccessibleName = "Select"
            Me.radRibbonBarGroup6.Items.AddRange(New Telerik.WinControls.RadItem() {Me.selectAllButton, Me.radRibbonBarButtonGroup4})
            Me.radRibbonBarGroup6.Name = "radRibbonBarGroup6"
            Me.radRibbonBarGroup6.Text = "Select"
            Me.radRibbonBarGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'selectAllButton
            '
            Me.selectAllButton.AccessibleDescription = "Select all"
            Me.selectAllButton.AccessibleName = "Select all"
            Me.selectAllButton.Class = "RibbonBarButtonElement"
            Me.selectAllButton.Image = Global.My.Resources.Resources._1_select_all
            Me.selectAllButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.selectAllButton.Name = "selectAllButton"
            Me.selectAllButton.Text = "Select all"
            Me.selectAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.selectAllButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup4
            '
            Me.radRibbonBarButtonGroup4.AccessibleDescription = "radRibbonBarButtonGroup4"
            Me.radRibbonBarButtonGroup4.AccessibleName = "radRibbonBarButtonGroup4"
            Me.radRibbonBarButtonGroup4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElement11, Me.radButtonElement12})
            Me.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4"
            Me.radRibbonBarButtonGroup4.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup4.StretchVertically = True
            Me.radRibbonBarButtonGroup4.Text = "radRibbonBarButtonGroup4"
            Me.radRibbonBarButtonGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement11
            '
            Me.radButtonElement11.AccessibleDescription = "Selected none"
            Me.radButtonElement11.AccessibleName = "Selected none"
            Me.radButtonElement11.Class = "ButtonElement"
            Me.radButtonElement11.Image = Global.My.Resources.Resources._1_select_none
            Me.radButtonElement11.Name = "radButtonElement11"
            Me.radButtonElement11.ShowBorder = False
            Me.radButtonElement11.Text = "Selected none"
            Me.radButtonElement11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonElement11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement12
            '
            Me.radButtonElement12.AccessibleDescription = "Invert selection"
            Me.radButtonElement12.AccessibleName = "Invert selection"
            Me.radButtonElement12.Class = "ButtonElement"
            Me.radButtonElement12.Image = Global.My.Resources.Resources._1_invert_selection
            Me.radButtonElement12.Name = "radButtonElement12"
            Me.radButtonElement12.ShowBorder = False
            Me.radButtonElement12.Text = "Invert selection"
            Me.radButtonElement12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonElement12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement12.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ribbonTab2
            '
            Me.ribbonTab2.AccessibleDescription = "Share"
            Me.ribbonTab2.AccessibleName = "Share"
            Me.ribbonTab2.Alignment = System.Drawing.ContentAlignment.BottomLeft
            Me.ribbonTab2.Class = "RibbonTab"
            Me.ribbonTab2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarGroup7, Me.radRibbonBarGroup8, Me.radRibbonBarGroup9, Me.radRibbonBarGroup10})
            Me.ribbonTab2.Name = "ribbonTab2"
            Me.ribbonTab2.StretchHorizontally = False
            Me.ribbonTab2.Text = "Share"
            Me.ribbonTab2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup7
            '
            Me.radRibbonBarGroup7.AccessibleDescription = "Send"
            Me.radRibbonBarGroup7.AccessibleName = "Send"
            Me.radRibbonBarGroup7.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElement13, Me.radButtonElement14, Me.radButtonElement15})
            Me.radRibbonBarGroup7.Name = "radRibbonBarGroup7"
            Me.radRibbonBarGroup7.Text = "Send"
            Me.radRibbonBarGroup7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement13
            '
            Me.radButtonElement13.AccessibleDescription = "Burn"
            Me.radButtonElement13.AccessibleName = "Burn"
            Me.radButtonElement13.Class = "RibbonBarButtonElement"
            Me.radButtonElement13.Image = Global.My.Resources.Resources._2_burn
            Me.radButtonElement13.Name = "radButtonElement13"
            Me.radButtonElement13.Text = "Burn"
            Me.radButtonElement13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement13.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement14
            '
            Me.radButtonElement14.AccessibleDescription = "Email"
            Me.radButtonElement14.AccessibleName = "Email"
            Me.radButtonElement14.Class = "RibbonBarButtonElement"
            Me.radButtonElement14.Image = Global.My.Resources.Resources._2_mail
            Me.radButtonElement14.Name = "radButtonElement14"
            Me.radButtonElement14.Text = "Email"
            Me.radButtonElement14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement14.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement15
            '
            Me.radButtonElement15.AccessibleDescription = "Fax"
            Me.radButtonElement15.AccessibleName = "Fax"
            Me.radButtonElement15.Class = "RibbonBarButtonElement"
            Me.radButtonElement15.Image = Global.My.Resources.Resources._2_fax
            Me.radButtonElement15.Name = "radButtonElement15"
            Me.radButtonElement15.Text = "Fax"
            Me.radButtonElement15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement15.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup8
            '
            Me.radRibbonBarGroup8.AccessibleDescription = "Sharing shortcuts"
            Me.radRibbonBarGroup8.AccessibleName = "Sharing shortcuts"
            Me.radRibbonBarGroup8.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radGalleryElement2})
            Me.radRibbonBarGroup8.Name = "radRibbonBarGroup8"
            Me.radRibbonBarGroup8.Text = "Sharing shortcuts"
            Me.radRibbonBarGroup8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryElement2
            '
            Me.radGalleryElement2.AccessibleDescription = "radGalleryElement2"
            Me.radGalleryElement2.AccessibleName = "radGalleryElement2"
            Me.radGalleryElement2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radGalleryItem7})
            Me.radGalleryElement2.Name = "radGalleryElement2"
            Me.radGalleryElement2.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
            Me.radGalleryElement2.Text = "radGalleryElement2"
            Me.radGalleryElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryItem7
            '
            Me.radGalleryItem7.AccessibleDescription = "Advanced sharing..."
            Me.radGalleryItem7.AccessibleName = "Advanced sharing..."
            Me.radGalleryItem7.Alignment = System.Drawing.ContentAlignment.TopLeft
            Me.radGalleryItem7.DescriptionText = ""
            Me.radGalleryItem7.Name = "radGalleryItem7"
            Me.radGalleryItem7.StretchHorizontally = False
            Me.radGalleryItem7.StretchVertically = False
            Me.radGalleryItem7.Text = "Advanced sharing..."
            Me.radGalleryItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup9
            '
            Me.radRibbonBarGroup9.AccessibleDescription = "Security"
            Me.radRibbonBarGroup9.AccessibleName = "Security"
            Me.radRibbonBarGroup9.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarButtonGroup5})
            Me.radRibbonBarGroup9.Name = "radRibbonBarGroup9"
            Me.radRibbonBarGroup9.Text = "Security"
            Me.radRibbonBarGroup9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup5
            '
            Me.radRibbonBarButtonGroup5.AccessibleDescription = "radRibbonBarButtonGroup5"
            Me.radRibbonBarButtonGroup5.AccessibleName = "radRibbonBarButtonGroup5"
            Me.radRibbonBarButtonGroup5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radButtonElement16, Me.radButtonElement17})
            Me.radRibbonBarButtonGroup5.Name = "radRibbonBarButtonGroup5"
            Me.radRibbonBarButtonGroup5.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup5.StretchVertically = True
            Me.radRibbonBarButtonGroup5.Text = "radRibbonBarButtonGroup5"
            Me.radRibbonBarButtonGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement16
            '
            Me.radButtonElement16.AccessibleDescription = "Share with others"
            Me.radButtonElement16.AccessibleName = "Share with others"
            Me.radButtonElement16.Class = "ButtonElement"
            Me.radButtonElement16.Image = Global.My.Resources.Resources._2_share_with_others
            Me.radButtonElement16.Name = "radButtonElement16"
            Me.radButtonElement16.ShowBorder = False
            Me.radButtonElement16.Text = "Share with others"
            Me.radButtonElement16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement16.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement17
            '
            Me.radButtonElement17.AccessibleDescription = "Advanced Security"
            Me.radButtonElement17.AccessibleName = "Advanced Security"
            Me.radButtonElement17.Class = "ButtonElement"
            Me.radButtonElement17.Image = Global.My.Resources.Resources._2_advanced_security
            Me.radButtonElement17.Name = "radButtonElement17"
            Me.radButtonElement17.ShowBorder = False
            Me.radButtonElement17.Text = "Advanced Security"
            Me.radButtonElement17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement17.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup10
            '
            Me.radRibbonBarGroup10.AccessibleDescription = "Add-ins"
            Me.radRibbonBarGroup10.AccessibleName = "Add-ins"
            Me.radRibbonBarGroup10.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement7})
            Me.radRibbonBarGroup10.Name = "radRibbonBarGroup10"
            Me.radRibbonBarGroup10.Text = "Add-ins"
            Me.radRibbonBarGroup10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement7
            '
            Me.radDropDownButtonElement7.AccessibleDescription = "Web sharing"
            Me.radDropDownButtonElement7.AccessibleName = "Web sharing"
            Me.radDropDownButtonElement7.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement7.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
            Me.radDropDownButtonElement7.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement7.ExpandArrowButton = False
            Me.radDropDownButtonElement7.Image = Global.My.Resources.Resources._2_web_sharing
            Me.radDropDownButtonElement7.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radDropDownButtonElement7.Name = "radDropDownButtonElement7"
            Me.radDropDownButtonElement7.Text = "Web sharing"
            Me.radDropDownButtonElement7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radDropDownButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ribbonTab3
            '
            Me.ribbonTab3.AccessibleDescription = "View"
            Me.ribbonTab3.AccessibleName = "View"
            Me.ribbonTab3.Alignment = System.Drawing.ContentAlignment.BottomLeft
            Me.ribbonTab3.Class = "RibbonTab"
            Me.ribbonTab3.IsSelected = False
            Me.ribbonTab3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarGroup11, Me.radRibbonBarGroup12, Me.radRibbonBarGroup13, Me.radRibbonBarGroup14, Me.radRibbonBarGroup15})
            Me.ribbonTab3.Name = "ribbonTab3"
            Me.ribbonTab3.StretchHorizontally = False
            Me.ribbonTab3.Text = "View"
            Me.ribbonTab3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup11
            '
            Me.radRibbonBarGroup11.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refreshButtonInRibbon})
            Me.radRibbonBarGroup11.Name = "radRibbonBarGroup11"
            Me.radRibbonBarGroup11.Text = ""
            Me.radRibbonBarGroup11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'refreshButtonInRibbon
            '
            Me.refreshButtonInRibbon.AccessibleDescription = "Refresh"
            Me.refreshButtonInRibbon.AccessibleName = "Refresh"
            Me.refreshButtonInRibbon.Class = "RibbonBarButtonElement"
            Me.refreshButtonInRibbon.Image = Global.My.Resources.Resources._3_refresh
            Me.refreshButtonInRibbon.Name = "refreshButtonInRibbon"
            Me.refreshButtonInRibbon.Text = "Refresh"
            Me.refreshButtonInRibbon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.refreshButtonInRibbon.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup12
            '
            Me.radRibbonBarGroup12.AccessibleDescription = "Icon Size"
            Me.radRibbonBarGroup12.AccessibleName = "Icon Size"
            Me.radRibbonBarGroup12.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radGalleryElement3})
            Me.radRibbonBarGroup12.Name = "radRibbonBarGroup12"
            Me.radRibbonBarGroup12.Text = "Icon Size"
            Me.radRibbonBarGroup12.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryElement3
            '
            Me.radGalleryElement3.AccessibleDescription = "radGalleryElement3"
            Me.radGalleryElement3.AccessibleName = "radGalleryElement3"
            Me.radGalleryElement3.AutoSize = False
            Me.radGalleryElement3.Bounds = New System.Drawing.Rectangle(0, 0, 350, 67)
            Me.radGalleryElement3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.extraLargeIconsGaleryItem, Me.mediumIconsGaleryItem, Me.listGaleryItem, Me.largeIconsGaleryItem, Me.smallIconsGaleryItem, Me.detailsGaleryItem})
            Me.radGalleryElement3.Name = "radGalleryElement3"
            Me.radGalleryElement3.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
            Me.radGalleryElement3.Text = "radGalleryElement3"
            Me.radGalleryElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'extraLargeIconsGaleryItem
            '
            Me.extraLargeIconsGaleryItem.AccessibleDescription = "Extra Large Icons"
            Me.extraLargeIconsGaleryItem.AccessibleName = "Extra Large Icons"
            Me.extraLargeIconsGaleryItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.extraLargeIconsGaleryItem.DescriptionText = ""
            Me.extraLargeIconsGaleryItem.Image = Global.My.Resources.Resources._3_extra_large_icons
            Me.extraLargeIconsGaleryItem.Name = "extraLargeIconsGaleryItem"
            Me.extraLargeIconsGaleryItem.StretchHorizontally = False
            Me.extraLargeIconsGaleryItem.StretchVertically = False
            Me.extraLargeIconsGaleryItem.Text = "Extra Large Icons"
            Me.extraLargeIconsGaleryItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.extraLargeIconsGaleryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.extraLargeIconsGaleryItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mediumIconsGaleryItem
            '
            Me.mediumIconsGaleryItem.AccessibleDescription = "Medium Icons"
            Me.mediumIconsGaleryItem.AccessibleName = "Medium Icons"
            Me.mediumIconsGaleryItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.mediumIconsGaleryItem.DescriptionText = ""
            Me.mediumIconsGaleryItem.Image = Global.My.Resources.Resources._3_medium_icons
            Me.mediumIconsGaleryItem.Name = "mediumIconsGaleryItem"
            Me.mediumIconsGaleryItem.StretchHorizontally = False
            Me.mediumIconsGaleryItem.StretchVertically = False
            Me.mediumIconsGaleryItem.Text = "Medium Icons"
            Me.mediumIconsGaleryItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.mediumIconsGaleryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.mediumIconsGaleryItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'listGaleryItem
            '
            Me.listGaleryItem.AccessibleDescription = "List"
            Me.listGaleryItem.AccessibleName = "List"
            Me.listGaleryItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.listGaleryItem.DescriptionText = ""
            Me.listGaleryItem.Image = Global.My.Resources.Resources._3_list
            Me.listGaleryItem.Name = "listGaleryItem"
            Me.listGaleryItem.StretchHorizontally = False
            Me.listGaleryItem.StretchVertically = False
            Me.listGaleryItem.Text = "List"
            Me.listGaleryItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.listGaleryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.listGaleryItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'largeIconsGaleryItem
            '
            Me.largeIconsGaleryItem.AccessibleDescription = "Large Icons"
            Me.largeIconsGaleryItem.AccessibleName = "Large Icons"
            Me.largeIconsGaleryItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.largeIconsGaleryItem.DescriptionText = ""
            Me.largeIconsGaleryItem.Image = Global.My.Resources.Resources._3_large_icons
            Me.largeIconsGaleryItem.Name = "largeIconsGaleryItem"
            Me.largeIconsGaleryItem.StretchHorizontally = False
            Me.largeIconsGaleryItem.StretchVertically = False
            Me.largeIconsGaleryItem.Text = "Large Icons"
            Me.largeIconsGaleryItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.largeIconsGaleryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.largeIconsGaleryItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'smallIconsGaleryItem
            '
            Me.smallIconsGaleryItem.AccessibleDescription = "Small Icons"
            Me.smallIconsGaleryItem.AccessibleName = "Small Icons"
            Me.smallIconsGaleryItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.smallIconsGaleryItem.DescriptionText = ""
            Me.smallIconsGaleryItem.Image = Global.My.Resources.Resources._3_small_cions
            Me.smallIconsGaleryItem.Name = "smallIconsGaleryItem"
            Me.smallIconsGaleryItem.StretchHorizontally = False
            Me.smallIconsGaleryItem.StretchVertically = False
            Me.smallIconsGaleryItem.Text = "Small Icons"
            Me.smallIconsGaleryItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.smallIconsGaleryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.smallIconsGaleryItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'detailsGaleryItem
            '
            Me.detailsGaleryItem.AccessibleDescription = "Details"
            Me.detailsGaleryItem.AccessibleName = "Details"
            Me.detailsGaleryItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.detailsGaleryItem.DescriptionText = ""
            Me.detailsGaleryItem.Image = Global.My.Resources.Resources._3_details
            Me.detailsGaleryItem.Name = "detailsGaleryItem"
            Me.detailsGaleryItem.StretchHorizontally = False
            Me.detailsGaleryItem.StretchVertically = False
            Me.detailsGaleryItem.Text = "Details"
            Me.detailsGaleryItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.detailsGaleryItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.detailsGaleryItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup13
            '
            Me.radRibbonBarGroup13.AccessibleDescription = "Current View"
            Me.radRibbonBarGroup13.AccessibleName = "Current View"
            Me.radRibbonBarGroup13.Items.AddRange(New Telerik.WinControls.RadItem() {Me.sortByButton, Me.radRibbonBarButtonGroup6})
            Me.radRibbonBarGroup13.Name = "radRibbonBarGroup13"
            Me.radRibbonBarGroup13.Text = "Current View"
            Me.radRibbonBarGroup13.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortByButton
            '
            Me.sortByButton.AccessibleDescription = "Sort by"
            Me.sortByButton.AccessibleName = "Sort by"
            Me.sortByButton.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.sortByButton.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.sortByButton.ExpandArrowButton = False
            Me.sortByButton.Items.AddRange(New Telerik.WinControls.RadItem() {Me.sortByNameMenuItem, Me.sortByDateModifiedMenuItem, Me.sortByTypeMenuItem, Me.sortBySizeMenuItem})
            Me.sortByButton.Name = "sortByButton"
            Me.sortByButton.Text = "Sort by"
            Me.sortByButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.sortByButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortByNameMenuItem
            '
            Me.sortByNameMenuItem.AccessibleDescription = "Name"
            Me.sortByNameMenuItem.AccessibleName = "Name"
            Me.sortByNameMenuItem.Name = "sortByNameMenuItem"
            Me.sortByNameMenuItem.Text = "Name"
            Me.sortByNameMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortByDateModifiedMenuItem
            '
            Me.sortByDateModifiedMenuItem.AccessibleDescription = "Date Modified"
            Me.sortByDateModifiedMenuItem.AccessibleName = "Date Modified"
            Me.sortByDateModifiedMenuItem.Name = "sortByDateModifiedMenuItem"
            Me.sortByDateModifiedMenuItem.Text = "Date Modified"
            Me.sortByDateModifiedMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortByTypeMenuItem
            '
            Me.sortByTypeMenuItem.AccessibleDescription = "Type"
            Me.sortByTypeMenuItem.AccessibleName = "Type"
            Me.sortByTypeMenuItem.Name = "sortByTypeMenuItem"
            Me.sortByTypeMenuItem.Text = "Type"
            Me.sortByTypeMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortBySizeMenuItem
            '
            Me.sortBySizeMenuItem.AccessibleDescription = "Size"
            Me.sortBySizeMenuItem.AccessibleName = "Size"
            Me.sortBySizeMenuItem.Name = "sortBySizeMenuItem"
            Me.sortBySizeMenuItem.Text = "Size"
            Me.sortBySizeMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup6
            '
            Me.radRibbonBarButtonGroup6.AccessibleDescription = "radRibbonBarButtonGroup6"
            Me.radRibbonBarButtonGroup6.AccessibleName = "radRibbonBarButtonGroup6"
            Me.radRibbonBarButtonGroup6.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement9, Me.radDropDownButtonElement10, Me.radButtonElement19})
            Me.radRibbonBarButtonGroup6.Name = "radRibbonBarButtonGroup6"
            Me.radRibbonBarButtonGroup6.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup6.StretchVertically = True
            Me.radRibbonBarButtonGroup6.Text = "radRibbonBarButtonGroup6"
            Me.radRibbonBarButtonGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement9
            '
            Me.radDropDownButtonElement9.AccessibleDescription = "Group by"
            Me.radDropDownButtonElement9.AccessibleName = "Group by"
            Me.radDropDownButtonElement9.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement9.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement9.ExpandArrowButton = False
            Me.radDropDownButtonElement9.Image = Global.My.Resources.Resources._3_group_by
            Me.radDropDownButtonElement9.Name = "radDropDownButtonElement9"
            Me.radDropDownButtonElement9.Text = "Group by"
            Me.radDropDownButtonElement9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radDropDownButtonElement9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radDropDownButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement10
            '
            Me.radDropDownButtonElement10.AccessibleDescription = "Add columns"
            Me.radDropDownButtonElement10.AccessibleName = "Add columns"
            Me.radDropDownButtonElement10.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement10.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement10.ExpandArrowButton = False
            Me.radDropDownButtonElement10.Image = Global.My.Resources.Resources._3_add_column
            Me.radDropDownButtonElement10.Name = "radDropDownButtonElement10"
            Me.radDropDownButtonElement10.Text = "Add columns"
            Me.radDropDownButtonElement10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radDropDownButtonElement10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radDropDownButtonElement10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement19
            '
            Me.radButtonElement19.AccessibleDescription = "Size all columns"
            Me.radButtonElement19.AccessibleName = "Size all columns"
            Me.radButtonElement19.Class = "ButtonElement"
            Me.radButtonElement19.Image = Global.My.Resources.Resources._3_size_all_columns
            Me.radButtonElement19.Name = "radButtonElement19"
            Me.radButtonElement19.ShowBorder = False
            Me.radButtonElement19.Text = "Size all columns"
            Me.radButtonElement19.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.radButtonElement19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radButtonElement19.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup14
            '
            Me.radRibbonBarGroup14.AccessibleDescription = "Layout"
            Me.radRibbonBarGroup14.AccessibleName = "Layout"
            Me.radRibbonBarGroup14.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radDropDownButtonElement11, Me.radButtonElement20, Me.radButtonElement21})
            Me.radRibbonBarGroup14.Name = "radRibbonBarGroup14"
            Me.radRibbonBarGroup14.Text = "Layout"
            Me.radRibbonBarGroup14.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radDropDownButtonElement11
            '
            Me.radDropDownButtonElement11.AccessibleDescription = "Navigation pane"
            Me.radDropDownButtonElement11.AccessibleName = "Navigation pane"
            Me.radDropDownButtonElement11.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.radDropDownButtonElement11.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
            Me.radDropDownButtonElement11.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.radDropDownButtonElement11.ExpandArrowButton = False
            Me.radDropDownButtonElement11.Image = Global.My.Resources.Resources._3_navigation_pane
            Me.radDropDownButtonElement11.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radDropDownButtonElement11.Name = "radDropDownButtonElement11"
            Me.radDropDownButtonElement11.Text = "Navigation pane"
            Me.radDropDownButtonElement11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radDropDownButtonElement11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement20
            '
            Me.radButtonElement20.AccessibleDescription = "Show previews"
            Me.radButtonElement20.AccessibleName = "Show previews"
            Me.radButtonElement20.Class = "RibbonBarButtonElement"
            Me.radButtonElement20.Image = Global.My.Resources.Resources._3_preview_pane
            Me.radButtonElement20.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElement20.Name = "radButtonElement20"
            Me.radButtonElement20.Text = "Show previews"
            Me.radButtonElement20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement20.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement21
            '
            Me.radButtonElement21.AccessibleDescription = "Show details"
            Me.radButtonElement21.AccessibleName = "Show details"
            Me.radButtonElement21.Class = "RibbonBarButtonElement"
            Me.radButtonElement21.Image = Global.My.Resources.Resources._3_detail_pane
            Me.radButtonElement21.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElement21.Name = "radButtonElement21"
            Me.radButtonElement21.Text = "Show details"
            Me.radButtonElement21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement21.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarGroup15
            '
            Me.radRibbonBarGroup15.AccessibleDescription = "Show/hide"
            Me.radRibbonBarGroup15.AccessibleName = "Show/hide"
            Me.radRibbonBarGroup15.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarButtonGroup7, Me.radButtonElement22})
            Me.radRibbonBarGroup15.Name = "radRibbonBarGroup15"
            Me.radRibbonBarGroup15.Text = "Show/hide"
            Me.radRibbonBarGroup15.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup7
            '
            Me.radRibbonBarButtonGroup7.AccessibleDescription = "radRibbonBarButtonGroup7"
            Me.radRibbonBarButtonGroup7.AccessibleName = "radRibbonBarButtonGroup7"
            Me.radRibbonBarButtonGroup7.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radCheckBoxElement1, Me.radCheckBoxElement2, Me.radCheckBoxElement3})
            Me.radRibbonBarButtonGroup7.Name = "radRibbonBarButtonGroup7"
            Me.radRibbonBarButtonGroup7.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup7.StretchVertically = True
            Me.radRibbonBarButtonGroup7.Text = "radRibbonBarButtonGroup7"
            Me.radRibbonBarButtonGroup7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radCheckBoxElement1
            '
            Me.radCheckBoxElement1.AccessibleDescription = "Picture names"
            Me.radCheckBoxElement1.AccessibleName = "Picture names"
            Me.radCheckBoxElement1.Checked = False
            Me.radCheckBoxElement1.Name = "radCheckBoxElement1"
            Me.radCheckBoxElement1.Text = "Picture names"
            Me.radCheckBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radCheckBoxElement2
            '
            Me.radCheckBoxElement2.AccessibleDescription = "File extensions"
            Me.radCheckBoxElement2.AccessibleName = "File extensions"
            Me.radCheckBoxElement2.Checked = False
            Me.radCheckBoxElement2.Name = "radCheckBoxElement2"
            Me.radCheckBoxElement2.Text = "File extensions"
            Me.radCheckBoxElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radCheckBoxElement3
            '
            Me.radCheckBoxElement3.AccessibleDescription = "Hidden files"
            Me.radCheckBoxElement3.AccessibleName = "Hidden files"
            Me.radCheckBoxElement3.Checked = False
            Me.radCheckBoxElement3.Name = "radCheckBoxElement3"
            Me.radCheckBoxElement3.Text = "Hidden files"
            Me.radCheckBoxElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radButtonElement22
            '
            Me.radButtonElement22.AccessibleDescription = "Hide selected file"
            Me.radButtonElement22.AccessibleName = "Hide selected file"
            Me.radButtonElement22.Class = "RibbonBarButtonElement"
            Me.radButtonElement22.Image = Global.My.Resources.Resources._3_hide_selected_file
            Me.radButtonElement22.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.radButtonElement22.Name = "radButtonElement22"
            Me.radButtonElement22.Text = "Hide selected file"
            Me.radButtonElement22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.radButtonElement22.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RibbonTab4
            '
            Me.RibbonTab4.AccessibleDescription = "Themes"
            Me.RibbonTab4.AccessibleName = "Themes"
            Me.RibbonTab4.Class = "RibbonTab"
            Me.RibbonTab4.IsSelected = False
            Me.RibbonTab4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup16})
            Me.RibbonTab4.Name = "RibbonTab4"
            Me.RibbonTab4.Text = "Themes"
            Me.RibbonTab4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadRibbonBarGroup16
            '
            Me.RadRibbonBarGroup16.AccessibleDescription = "Themes"
            Me.RadRibbonBarGroup16.AccessibleName = "Themes"
            Me.RadRibbonBarGroup16.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadGalleryElement4})
            Me.RadRibbonBarGroup16.Name = "RadRibbonBarGroup16"
            Me.RadRibbonBarGroup16.Text = "Themes"
            Me.RadRibbonBarGroup16.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadGalleryElement4
            '
            Me.RadGalleryElement4.AccessibleDescription = "RadGalleryElement4"
            Me.RadGalleryElement4.AccessibleName = "RadGalleryElement4"
            Me.RadGalleryElement4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.office2010BlackButton, Me.office2010BlueButton, Me.office2010SilverButton, Me.controlDefaultButton, Me.telerikMetroButton})
            Me.RadGalleryElement4.Name = "RadGalleryElement4"
            Me.RadGalleryElement4.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
            Me.RadGalleryElement4.Text = "RadGalleryElement4"
            Me.RadGalleryElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'office2010BlackButton
            '
            Me.office2010BlackButton.AccessibleDescription = "Office2010Black"
            Me.office2010BlackButton.AccessibleName = "Office2010Black"
            Me.office2010BlackButton.DescriptionText = ""
            Me.office2010BlackButton.Image = Global.My.Resources.Resources.Office2010Black
            Me.office2010BlackButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.office2010BlackButton.Name = "office2010BlackButton"
            Me.office2010BlackButton.StretchHorizontally = False
            Me.office2010BlackButton.StretchVertically = False
            Me.office2010BlackButton.Text = "Office2010Black"
            Me.office2010BlackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.office2010BlackButton.ToolTipText = "Office2010Black"
            Me.office2010BlackButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'office2010BlueButton
            '
            Me.office2010BlueButton.AccessibleDescription = "Office2010Blue"
            Me.office2010BlueButton.AccessibleName = "Office2010Blue"
            Me.office2010BlueButton.DescriptionText = ""
            Me.office2010BlueButton.Image = Global.My.Resources.Resources.Office2010Blue
            Me.office2010BlueButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.office2010BlueButton.Name = "office2010BlueButton"
            Me.office2010BlueButton.StretchHorizontally = False
            Me.office2010BlueButton.StretchVertically = False
            Me.office2010BlueButton.Text = "Office2010Blue"
            Me.office2010BlueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.office2010BlueButton.ToolTipText = "Office2010Blue"
            Me.office2010BlueButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'office2010SilverButton
            '
            Me.office2010SilverButton.AccessibleDescription = "Office2010Silver"
            Me.office2010SilverButton.AccessibleName = "Office2010Silver"
            Me.office2010SilverButton.DescriptionText = ""
            Me.office2010SilverButton.Image = Global.My.Resources.Resources.Office2010Silver
            Me.office2010SilverButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.office2010SilverButton.Name = "office2010SilverButton"
            Me.office2010SilverButton.StretchHorizontally = False
            Me.office2010SilverButton.StretchVertically = False
            Me.office2010SilverButton.Text = "Office2010Silver"
            Me.office2010SilverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.office2010SilverButton.ToolTipText = "Office2010Silver"
            Me.office2010SilverButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'controlDefaultButton
            '
            Me.controlDefaultButton.AccessibleDescription = "ControlDefault"
            Me.controlDefaultButton.AccessibleName = "ControlDefault"
            Me.controlDefaultButton.DescriptionText = ""
            Me.controlDefaultButton.Image = Global.My.Resources.Resources.ControlDefault
            Me.controlDefaultButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.controlDefaultButton.Name = "controlDefaultButton"
            Me.controlDefaultButton.StretchHorizontally = False
            Me.controlDefaultButton.StretchVertically = False
            Me.controlDefaultButton.Text = "ControlDefault"
            Me.controlDefaultButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.controlDefaultButton.ToolTipText = "ControlDefault"
            Me.controlDefaultButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'telerikMetroButton
            '
            Me.telerikMetroButton.AccessibleDescription = "TelerikMetro"
            Me.telerikMetroButton.AccessibleName = "TelerikMetro"
            Me.telerikMetroButton.DescriptionText = ""
            Me.telerikMetroButton.Image = Global.My.Resources.Resources.Telerik
            Me.telerikMetroButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.telerikMetroButton.Name = "telerikMetroButton"
            Me.telerikMetroButton.StretchHorizontally = False
            Me.telerikMetroButton.StretchVertically = False
            Me.telerikMetroButton.Text = "TelerikMetro"
            Me.telerikMetroButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.telerikMetroButton.ToolTipText = "TelerikMetro"
            Me.telerikMetroButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'openNewWindowMenuItem
            '
            Me.openNewWindowMenuItem.AccessibleDescription = "Open New Window"
            Me.openNewWindowMenuItem.AccessibleName = "Open New Window"
            Me.openNewWindowMenuItem.Name = "openNewWindowMenuItem"
            Me.openNewWindowMenuItem.Text = "Open New Window"
            Me.openNewWindowMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'openCommandPromptMenuItem
            '
            Me.openCommandPromptMenuItem.AccessibleDescription = "Open command prompt"
            Me.openCommandPromptMenuItem.AccessibleName = "Open command prompt"
            Me.openCommandPromptMenuItem.Name = "openCommandPromptMenuItem"
            Me.openCommandPromptMenuItem.Text = "Open command prompt"
            Me.openCommandPromptMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem1
            '
            Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'addSelectedFolderToFavoritesMenuItem
            '
            Me.addSelectedFolderToFavoritesMenuItem.AccessibleDescription = "Add selected folder to favorites"
            Me.addSelectedFolderToFavoritesMenuItem.AccessibleName = "Add selected folder to favorites"
            Me.addSelectedFolderToFavoritesMenuItem.Name = "addSelectedFolderToFavoritesMenuItem"
            Me.addSelectedFolderToFavoritesMenuItem.Text = "Add selected folder to favorites"
            Me.addSelectedFolderToFavoritesMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'includeInLibraryMenuItem
            '
            Me.includeInLibraryMenuItem.AccessibleDescription = "Include in library"
            Me.includeInLibraryMenuItem.AccessibleName = "Include in library"
            Me.includeInLibraryMenuItem.Name = "includeInLibraryMenuItem"
            Me.includeInLibraryMenuItem.Text = "Include in library"
            Me.includeInLibraryMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mapSelectedFolderAsDriveMenuItem
            '
            Me.mapSelectedFolderAsDriveMenuItem.AccessibleDescription = "Map selected folder as drive"
            Me.mapSelectedFolderAsDriveMenuItem.AccessibleName = "Map selected folder as drive"
            Me.mapSelectedFolderAsDriveMenuItem.Name = "mapSelectedFolderAsDriveMenuItem"
            Me.mapSelectedFolderAsDriveMenuItem.Text = "Map selected folder as drive"
            Me.mapSelectedFolderAsDriveMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem2
            '
            Me.radMenuSeparatorItem2.AccessibleDescription = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.AccessibleName = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'clearHistoryMenuItem
            '
            Me.clearHistoryMenuItem.AccessibleDescription = "Clear history"
            Me.clearHistoryMenuItem.AccessibleName = "Clear history"
            Me.clearHistoryMenuItem.Name = "clearHistoryMenuItem"
            Me.clearHistoryMenuItem.Text = "Clear history"
            Me.clearHistoryMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem3
            '
            Me.radMenuSeparatorItem3.AccessibleDescription = "radMenuSeparatorItem3"
            Me.radMenuSeparatorItem3.AccessibleName = "radMenuSeparatorItem3"
            Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
            Me.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3"
            Me.radMenuSeparatorItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'printMenuItem
            '
            Me.printMenuItem.AccessibleDescription = "Print"
            Me.printMenuItem.AccessibleName = "Print"
            Me.printMenuItem.Name = "printMenuItem"
            Me.printMenuItem.Text = "Print"
            Me.printMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem4
            '
            Me.radMenuSeparatorItem4.AccessibleDescription = "radMenuSeparatorItem4"
            Me.radMenuSeparatorItem4.AccessibleName = "radMenuSeparatorItem4"
            Me.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4"
            Me.radMenuSeparatorItem4.Text = "radMenuSeparatorItem4"
            Me.radMenuSeparatorItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'syncMenuItem
            '
            Me.syncMenuItem.AccessibleDescription = "Sync"
            Me.syncMenuItem.AccessibleName = "Sync"
            Me.syncMenuItem.Name = "syncMenuItem"
            Me.syncMenuItem.Text = "Sync"
            Me.syncMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem5
            '
            Me.radMenuSeparatorItem5.AccessibleDescription = "radMenuSeparatorItem5"
            Me.radMenuSeparatorItem5.AccessibleName = "radMenuSeparatorItem5"
            Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
            Me.radMenuSeparatorItem5.Text = "radMenuSeparatorItem5"
            Me.radMenuSeparatorItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'folderOptionsMenuItem
            '
            Me.folderOptionsMenuItem.AccessibleDescription = "Folder options"
            Me.folderOptionsMenuItem.AccessibleName = "Folder options"
            Me.folderOptionsMenuItem.Name = "folderOptionsMenuItem"
            Me.folderOptionsMenuItem.Text = "Folder options"
            Me.folderOptionsMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem6
            '
            Me.radMenuSeparatorItem6.AccessibleDescription = "radMenuSeparatorItem6"
            Me.radMenuSeparatorItem6.AccessibleName = "radMenuSeparatorItem6"
            Me.radMenuSeparatorItem6.Name = "radMenuSeparatorItem6"
            Me.radMenuSeparatorItem6.Text = "radMenuSeparatorItem6"
            Me.radMenuSeparatorItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'helpMenuItem
            '
            Me.helpMenuItem.AccessibleDescription = "Help"
            Me.helpMenuItem.AccessibleName = "Help"
            Me.helpMenuItem.Name = "helpMenuItem"
            Me.helpMenuItem.Text = "Help"
            Me.helpMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem7
            '
            Me.radMenuSeparatorItem7.AccessibleDescription = "radMenuSeparatorItem7"
            Me.radMenuSeparatorItem7.AccessibleName = "radMenuSeparatorItem7"
            Me.radMenuSeparatorItem7.Name = "radMenuSeparatorItem7"
            Me.radMenuSeparatorItem7.Text = "radMenuSeparatorItem7"
            Me.radMenuSeparatorItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'closeMenuItem
            '
            Me.closeMenuItem.AccessibleDescription = "Close"
            Me.closeMenuItem.AccessibleName = "Close"
            Me.closeMenuItem.Name = "closeMenuItem"
            Me.closeMenuItem.Text = "Close"
            Me.closeMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'frequentPlacesMenuItem
            '
            Me.frequentPlacesMenuItem.AccessibleDescription = "Frequent Places"
            Me.frequentPlacesMenuItem.AccessibleName = "Frequent Places"
            Me.frequentPlacesMenuItem.Name = "frequentPlacesMenuItem"
            Me.frequentPlacesMenuItem.Text = "Frequent Places"
            Me.frequentPlacesMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem8
            '
            Me.radMenuSeparatorItem8.AccessibleDescription = "radMenuSeparatorItem8"
            Me.radMenuSeparatorItem8.AccessibleName = "radMenuSeparatorItem8"
            Me.radMenuSeparatorItem8.Name = "radMenuSeparatorItem8"
            Me.radMenuSeparatorItem8.Text = "radMenuSeparatorItem8"
            Me.radMenuSeparatorItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadRibbonForm1
            '
            Me.ClientSize = New System.Drawing.Size(1065, 610)
            Me.Controls.Add(Me.radSplitContainer1)
            Me.Controls.Add(Me.radStatusStrip1)
            Me.Controls.Add(Me.radPanel1)
            Me.Controls.Add(Me.radRibbonBar1)
            Me.MainMenuStrip = Nothing
            Me.Name = "RadRibbonForm1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "RadForm1"
            Me.ThemeName = "ControlDefault"
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.radPanel1.PerformLayout()
            CType(Me.historyButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.upButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.refreshButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radBreadCrumb1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.forwardButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer1.ResumeLayout(False)
            CType(Me.splitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel1.ResumeLayout(False)
            CType(Me.splitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitPanel2.ResumeLayout(False)
            CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radTextBox1 As Telerik.WinControls.UI.RadTextBox
		Private WithEvents refreshButton As Telerik.WinControls.UI.RadButton
		Private radBreadCrumb1 As Telerik.WinControls.UI.RadBreadCrumb
		Private WithEvents forwardButton As Telerik.WinControls.UI.RadButton
		Private WithEvents backButton As Telerik.WinControls.UI.RadButton
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Private office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
		Private office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
		Private office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
        Private telerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
		Private radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
		Private ribbonTab1 As Telerik.WinControls.UI.RibbonTab
		Private radRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radDropDownButtonElement1 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radRibbonBarButtonGroup1 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private cutButton As Telerik.WinControls.UI.RadButtonElement
		Private WithEvents copyButton As Telerik.WinControls.UI.RadButtonElement
		Private WithEvents copyAsPathButton As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents newFolderButton As Telerik.WinControls.UI.RadButtonElement
		Private radDropDownButtonElement2 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radRibbonBarGroup3 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radDropDownButtonElement3 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radRibbonBarButtonGroup2 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private WithEvents copyToFolderButton As Telerik.WinControls.UI.RadDropDownButtonElement
		Private WithEvents renameButton As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement6 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup4 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radGalleryElement1 As Telerik.WinControls.UI.RadGalleryElement
		Private radGalleryItem1 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem2 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem3 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem4 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem5 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem6 As Telerik.WinControls.UI.RadGalleryItem
		Private radRibbonBarGroup5 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radDropDownButtonElement5 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement7 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarButtonGroup3 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private radDropDownButtonElement6 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement9 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement10 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup6 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private selectAllButton As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarButtonGroup4 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private radButtonElement11 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement12 As Telerik.WinControls.UI.RadButtonElement
		Private ribbonTab2 As Telerik.WinControls.UI.RibbonTab
		Private ribbonTab3 As Telerik.WinControls.UI.RibbonTab
		Private radRibbonBarGroup7 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radButtonElement13 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement14 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement15 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup8 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radGalleryElement2 As Telerik.WinControls.UI.RadGalleryElement
		Private radGalleryItem7 As Telerik.WinControls.UI.RadGalleryItem
		Private radRibbonBarGroup9 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarButtonGroup5 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private radButtonElement16 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement17 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup10 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radDropDownButtonElement7 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radRibbonBarGroup11 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarGroup12 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarGroup13 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarGroup14 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents refreshButtonInRibbon As Telerik.WinControls.UI.RadButtonElement
		Private radGalleryElement3 As Telerik.WinControls.UI.RadGalleryElement
		Private extraLargeIconsGaleryItem As Telerik.WinControls.UI.RadGalleryItem
		Private WithEvents mediumIconsGaleryItem As Telerik.WinControls.UI.RadGalleryItem
		Private WithEvents listGaleryItem As Telerik.WinControls.UI.RadGalleryItem
		Private largeIconsGaleryItem As Telerik.WinControls.UI.RadGalleryItem
		Private WithEvents smallIconsGaleryItem As Telerik.WinControls.UI.RadGalleryItem
		Private WithEvents detailsGaleryItem As Telerik.WinControls.UI.RadGalleryItem
		Private sortByButton As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radRibbonBarButtonGroup6 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private radDropDownButtonElement9 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radDropDownButtonElement10 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement19 As Telerik.WinControls.UI.RadButtonElement
		Private radDropDownButtonElement11 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement20 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement21 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup15 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarButtonGroup7 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private radCheckBoxElement1 As Telerik.WinControls.UI.RadCheckBoxElement
		Private radCheckBoxElement2 As Telerik.WinControls.UI.RadCheckBoxElement
		Private radCheckBoxElement3 As Telerik.WinControls.UI.RadCheckBoxElement
		Private radButtonElement22 As Telerik.WinControls.UI.RadButtonElement
		Private WithEvents upButton As Telerik.WinControls.UI.RadButton
		Private openNewWindowMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private openCommandPromptMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private addSelectedFolderToFavoritesMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private includeInLibraryMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private mapSelectedFolderAsDriveMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private clearHistoryMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private printMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem4 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private syncMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private folderOptionsMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem6 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private helpMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem7 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private closeMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private frequentPlacesMenuItem As Telerik.WinControls.UI.RadMenuHeaderItem
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private WithEvents historyButton As Telerik.WinControls.UI.RadDropDownButton
		Private radStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
		Private directoryInfoLabel As Telerik.WinControls.UI.RadLabelElement
        Private radCommandBarSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
		Private selectedItemInfoLabel As Telerik.WinControls.UI.RadLabelElement
		Private separatorLabel As Telerik.WinControls.UI.RadLabelElement
		Private radListView1 As Telerik.WinControls.UI.RadListView
		Private pasteMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private pasteAsShortcutMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private deleteSelectionMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private deleteAllMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private folderBrowserDialog1 As FolderBrowserDialog
		Private sortByTypeMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private sortByDateModifiedMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private sortBySizeMenuItem As Telerik.WinControls.UI.RadMenuItem
        Private sortByNameMenuItem As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents RibbonTab4 As Telerik.WinControls.UI.RibbonTab
        Friend WithEvents RadRibbonBarGroup16 As Telerik.WinControls.UI.RadRibbonBarGroup
        Friend WithEvents RadGalleryElement4 As Telerik.WinControls.UI.RadGalleryElement
        Friend WithEvents splitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents splitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents office2010BlackButton As Telerik.WinControls.UI.RadGalleryItem
        Friend WithEvents office2010BlueButton As Telerik.WinControls.UI.RadGalleryItem
        Friend WithEvents office2010SilverButton As Telerik.WinControls.UI.RadGalleryItem
        Friend WithEvents controlDefaultButton As Telerik.WinControls.UI.RadGalleryItem
        Friend WithEvents telerikMetroButton As Telerik.WinControls.UI.RadGalleryItem
	End Class
End Namespace
