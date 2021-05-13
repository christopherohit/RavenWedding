Imports Microsoft.VisualBasic
Imports System
Namespace BugTracker
	Public Partial Class RadRibbonForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
            Me.homeTab = New Telerik.WinControls.UI.RibbonTab()
            Me.databaseGroup = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.loadDatabaseButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.saveDatabaseButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.editGroup = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.addButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.removeButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.editButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.viewGroup = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.sortDropDownButton = New Telerik.WinControls.UI.RadDropDownButtonElement()
            Me.sortNoneMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.sortDateMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.dateAscendingMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.dateDescendingMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.sortStatusMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.statusAscendingMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.statusDescendingMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.sortOwnerMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.ownerAscendingMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.ownerDescendingMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radRibbonBarButtonGroup1 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.radRibbonBarButtonGroup2 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.openCheckBox = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.readyForTestCheckBox = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.doneCheckBox = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.radRibbonBarButtonGroup3 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
            Me.unassignedCheckBox = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.newCheckBox = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.viewTab = New Telerik.WinControls.UI.RibbonTab()
            Me.layoutGroup = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.loadLayoutButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.saveLayoutButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.panelsGroup = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.projectsButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.detailsButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.bugsButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.featuresButton = New Telerik.WinControls.UI.RadButtonElement()
            Me.radRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
            Me.radGalleryElement1 = New Telerik.WinControls.UI.RadGalleryElement()
            Me.office2010BlackButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.office2010BlueButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.office2010SilverButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.controlDefaultButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.telerikButton = New Telerik.WinControls.UI.RadGalleryItem()
            Me.loadDatabaseMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.addMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.removeMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.editMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.aboutMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.exitMenuItem = New Telerik.WinControls.UI.RadMenuItem()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
            Me.projectsToolWindow = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.projectsTreeView = New Telerik.WinControls.UI.RadTreeView()
            Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.documentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
            Me.bugDocumentWindow = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.bugsGrid = New Telerik.WinControls.UI.RadGridView()
            Me.featureDocumentWindow = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.featuresGrid = New Telerik.WinControls.UI.RadGridView()
            Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.detailsToolWindow = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.detailsPageView = New Telerik.WinControls.UI.RadPageView()
            Me.generalPageViewPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.ownerDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.ownerLabel = New Telerik.WinControls.UI.RadLabel()
            Me.idSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.priorityDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.dateDateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.statusDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.titleTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.priorityLabel = New Telerik.WinControls.UI.RadLabel()
            Me.dateLabel = New Telerik.WinControls.UI.RadLabel()
            Me.statusLabel = New Telerik.WinControls.UI.RadLabel()
            Me.titleLabel = New Telerik.WinControls.UI.RadLabel()
            Me.idLabel = New Telerik.WinControls.UI.RadLabel()
            Me.descriptionPageViewPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.descriptionTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.stepsToReproducePageViewPage = New Telerik.WinControls.UI.RadPageViewPage()
            Me.stepsToReproduceTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
            Me.office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
            Me.office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
            Me.telerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
            CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radDock1.SuspendLayout()
            Me.projectsToolWindow.SuspendLayout()
            CType(Me.projectsTreeView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolTabStrip3.SuspendLayout()
            CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radSplitContainer2.SuspendLayout()
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentContainer1.SuspendLayout()
            CType(Me.documentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.documentTabStrip2.SuspendLayout()
            Me.bugDocumentWindow.SuspendLayout()
            CType(Me.bugsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.featureDocumentWindow.SuspendLayout()
            CType(Me.featuresGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolTabStrip2.SuspendLayout()
            Me.detailsToolWindow.SuspendLayout()
            CType(Me.detailsPageView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.detailsPageView.SuspendLayout()
            Me.generalPageViewPage.SuspendLayout()
            CType(Me.ownerDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ownerLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.idSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.priorityDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statusDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.titleTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.priorityLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statusLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.titleLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.idLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.descriptionPageViewPage.SuspendLayout()
            CType(Me.descriptionTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.stepsToReproducePageViewPage.SuspendLayout()
            CType(Me.stepsToReproduceTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radRibbonBar1
            '
            Me.radRibbonBar1.AutoSize = True
            Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.homeTab, Me.viewTab})
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
            Me.radRibbonBar1.ExitButton.ButtonElement.Class = "RadMenuButtonElement"
            Me.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
            Me.radRibbonBar1.OptionsButton.ButtonElement.Class = "RadMenuButtonElement"
            Me.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.radRibbonBar1.OptionsButton.Text = "Options"
            '
            '
            '
            Me.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radRibbonBar1.Size = New System.Drawing.Size(1008, 154)
            Me.radRibbonBar1.StartButtonImage = Nothing
            Me.radRibbonBar1.StartMenuItems.AddRange(New Telerik.WinControls.RadItem() {Me.loadDatabaseMenuItem, Me.radMenuSeparatorItem1, Me.addMenuItem, Me.removeMenuItem, Me.editMenuItem, Me.radMenuSeparatorItem2, Me.aboutMenuItem, Me.exitMenuItem})
            Me.radRibbonBar1.TabIndex = 0
            Me.radRibbonBar1.Text = "Bug Tracker"
            '
            'homeTab
            '
            Me.homeTab.AccessibleDescription = "Home"
            Me.homeTab.AccessibleName = "Home"
            Me.homeTab.Alignment = System.Drawing.ContentAlignment.BottomLeft
            Me.homeTab.Class = "RibbonTab"
            Me.homeTab.IsSelected = True
            Me.homeTab.Items.AddRange(New Telerik.WinControls.RadItem() {Me.databaseGroup, Me.editGroup, Me.viewGroup})
            Me.homeTab.Name = "homeTab"
            Me.homeTab.StretchHorizontally = False
            Me.homeTab.Text = "Home"
            Me.homeTab.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'databaseGroup
            '
            Me.databaseGroup.AccessibleDescription = "Database"
            Me.databaseGroup.AccessibleName = "Database"
            Me.databaseGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.loadDatabaseButton, Me.saveDatabaseButton})
            Me.databaseGroup.Name = "databaseGroup"
            Me.databaseGroup.Text = "Database"
            Me.databaseGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'loadDatabaseButton
            '
            Me.loadDatabaseButton.AccessibleDescription = "Load"
            Me.loadDatabaseButton.AccessibleName = "Load"
            Me.loadDatabaseButton.Class = "RibbonBarButtonElement"
            Me.loadDatabaseButton.Image = Global.Resources.Load
            Me.loadDatabaseButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.loadDatabaseButton.MinSize = New System.Drawing.Size(48, 0)
            Me.loadDatabaseButton.Name = "loadDatabaseButton"
            Me.loadDatabaseButton.Text = "Load"
            Me.loadDatabaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.loadDatabaseButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'saveDatabaseButton
            '
            Me.saveDatabaseButton.AccessibleDescription = "Save"
            Me.saveDatabaseButton.AccessibleName = "Save"
            Me.saveDatabaseButton.Class = "RibbonBarButtonElement"
            Me.saveDatabaseButton.Image = Global.Resources.Save
            Me.saveDatabaseButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.saveDatabaseButton.MinSize = New System.Drawing.Size(48, 0)
            Me.saveDatabaseButton.Name = "saveDatabaseButton"
            Me.saveDatabaseButton.Text = "Save"
            Me.saveDatabaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.saveDatabaseButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'editGroup
            '
            Me.editGroup.AccessibleDescription = "Edit"
            Me.editGroup.AccessibleName = "Edit"
            Me.editGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.addButton, Me.removeButton, Me.editButton})
            Me.editGroup.Name = "editGroup"
            Me.editGroup.Text = "Edit"
            Me.editGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'addButton
            '
            Me.addButton.AccessibleDescription = "Add"
            Me.addButton.AccessibleName = "Add"
            Me.addButton.Class = "RibbonBarButtonElement"
            Me.addButton.Image = Global.Resources.Add
            Me.addButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.addButton.MinSize = New System.Drawing.Size(48, 0)
            Me.addButton.Name = "addButton"
            Me.addButton.Text = "Add"
            Me.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.addButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'removeButton
            '
            Me.removeButton.AccessibleDescription = "Remove"
            Me.removeButton.AccessibleName = "Remove"
            Me.removeButton.Class = "RibbonBarButtonElement"
            Me.removeButton.Image = Global.Resources.Remove
            Me.removeButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.removeButton.MinSize = New System.Drawing.Size(48, 0)
            Me.removeButton.Name = "removeButton"
            Me.removeButton.Text = "Remove"
            Me.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.removeButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'editButton
            '
            Me.editButton.AccessibleDescription = "Edit"
            Me.editButton.AccessibleName = "Edit"
            Me.editButton.Class = "RibbonBarButtonElement"
            Me.editButton.Image = Global.Resources.edit
            Me.editButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.editButton.MinSize = New System.Drawing.Size(48, 0)
            Me.editButton.Name = "editButton"
            Me.editButton.Text = "Edit"
            Me.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.editButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'viewGroup
            '
            Me.viewGroup.AccessibleDescription = "View"
            Me.viewGroup.AccessibleName = "View"
            Me.viewGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.sortDropDownButton, Me.radRibbonBarButtonGroup1})
            Me.viewGroup.Margin = New System.Windows.Forms.Padding(0)
            Me.viewGroup.MaxSize = New System.Drawing.Size(0, 0)
            Me.viewGroup.MinSize = New System.Drawing.Size(0, 0)
            Me.viewGroup.Name = "viewGroup"
            Me.viewGroup.Text = "View"
            Me.viewGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortDropDownButton
            '
            Me.sortDropDownButton.AccessibleDescription = "Sort By"
            Me.sortDropDownButton.AccessibleName = "Sort By"
            Me.sortDropDownButton.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
            Me.sortDropDownButton.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
            Me.sortDropDownButton.ExpandArrowButton = False
            Me.sortDropDownButton.Image = Global.Resources.sort
            Me.sortDropDownButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sortDropDownButton.Items.AddRange(New Telerik.WinControls.RadItem() {Me.sortNoneMenuItem, Me.sortDateMenuItem, Me.sortStatusMenuItem, Me.sortOwnerMenuItem})
            Me.sortDropDownButton.Name = "sortDropDownButton"
            Me.sortDropDownButton.Text = "Sort By"
            Me.sortDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.sortDropDownButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortNoneMenuItem
            '
            Me.sortNoneMenuItem.AccessibleDescription = "None"
            Me.sortNoneMenuItem.AccessibleName = "None"
            Me.sortNoneMenuItem.Name = "sortNoneMenuItem"
            Me.sortNoneMenuItem.Text = "None"
            Me.sortNoneMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortDateMenuItem
            '
            Me.sortDateMenuItem.AccessibleDescription = "Date"
            Me.sortDateMenuItem.AccessibleName = "Date"
            Me.sortDateMenuItem.Items.AddRange(New Telerik.WinControls.RadItem() {Me.dateAscendingMenuItem, Me.dateDescendingMenuItem})
            Me.sortDateMenuItem.Name = "sortDateMenuItem"
            Me.sortDateMenuItem.Text = "Date"
            Me.sortDateMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'dateAscendingMenuItem
            '
            Me.dateAscendingMenuItem.AccessibleDescription = "Ascending"
            Me.dateAscendingMenuItem.AccessibleName = "Ascending"
            Me.dateAscendingMenuItem.Name = "dateAscendingMenuItem"
            Me.dateAscendingMenuItem.Text = "Ascending"
            Me.dateAscendingMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'dateDescendingMenuItem
            '
            Me.dateDescendingMenuItem.AccessibleDescription = "Descending"
            Me.dateDescendingMenuItem.AccessibleName = "Descending"
            Me.dateDescendingMenuItem.Name = "dateDescendingMenuItem"
            Me.dateDescendingMenuItem.Text = "Descending"
            Me.dateDescendingMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortStatusMenuItem
            '
            Me.sortStatusMenuItem.AccessibleDescription = "Status"
            Me.sortStatusMenuItem.AccessibleName = "Status"
            Me.sortStatusMenuItem.Items.AddRange(New Telerik.WinControls.RadItem() {Me.statusAscendingMenuItem, Me.statusDescendingMenuItem})
            Me.sortStatusMenuItem.Name = "sortStatusMenuItem"
            Me.sortStatusMenuItem.Text = "Status"
            Me.sortStatusMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'statusAscendingMenuItem
            '
            Me.statusAscendingMenuItem.AccessibleDescription = "Ascending"
            Me.statusAscendingMenuItem.AccessibleName = "Ascending"
            Me.statusAscendingMenuItem.Name = "statusAscendingMenuItem"
            Me.statusAscendingMenuItem.Text = "Ascending"
            Me.statusAscendingMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'statusDescendingMenuItem
            '
            Me.statusDescendingMenuItem.AccessibleDescription = "Descending"
            Me.statusDescendingMenuItem.AccessibleName = "Descending"
            Me.statusDescendingMenuItem.Name = "statusDescendingMenuItem"
            Me.statusDescendingMenuItem.Text = "Descending"
            Me.statusDescendingMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'sortOwnerMenuItem
            '
            Me.sortOwnerMenuItem.AccessibleDescription = "Owner"
            Me.sortOwnerMenuItem.AccessibleName = "Owner"
            Me.sortOwnerMenuItem.Items.AddRange(New Telerik.WinControls.RadItem() {Me.ownerAscendingMenuItem, Me.ownerDescendingMenuItem})
            Me.sortOwnerMenuItem.Name = "sortOwnerMenuItem"
            Me.sortOwnerMenuItem.Text = "Owner"
            Me.sortOwnerMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ownerAscendingMenuItem
            '
            Me.ownerAscendingMenuItem.AccessibleDescription = "Ascending"
            Me.ownerAscendingMenuItem.AccessibleName = "Ascending"
            Me.ownerAscendingMenuItem.Name = "ownerAscendingMenuItem"
            Me.ownerAscendingMenuItem.Text = "Ascending"
            Me.ownerAscendingMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ownerDescendingMenuItem
            '
            Me.ownerDescendingMenuItem.AccessibleDescription = "Descending"
            Me.ownerDescendingMenuItem.AccessibleName = "Descending"
            Me.ownerDescendingMenuItem.Name = "ownerDescendingMenuItem"
            Me.ownerDescendingMenuItem.Text = "Descending"
            Me.ownerDescendingMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup1
            '
            Me.radRibbonBarButtonGroup1.AccessibleDescription = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.AccessibleName = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.AutoSize = True
            Me.radRibbonBarButtonGroup1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radRibbonBarButtonGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radRibbonBarButtonGroup2, Me.radRibbonBarButtonGroup3})
            Me.radRibbonBarButtonGroup1.MaxSize = New System.Drawing.Size(0, 0)
            Me.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal
            Me.radRibbonBarButtonGroup1.StretchVertically = True
            Me.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1"
            Me.radRibbonBarButtonGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup2
            '
            Me.radRibbonBarButtonGroup2.AccessibleDescription = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.AccessibleName = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.openCheckBox, Me.readyForTestCheckBox, Me.doneCheckBox})
            Me.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup2.StretchVertically = True
            Me.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2"
            Me.radRibbonBarButtonGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'openCheckBox
            '
            Me.openCheckBox.AccessibleDescription = "Open"
            Me.openCheckBox.AccessibleName = "Open"
            Me.openCheckBox.Checked = False
            Me.openCheckBox.Name = "openCheckBox"
            Me.openCheckBox.Text = "Open"
            Me.openCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'readyForTestCheckBox
            '
            Me.readyForTestCheckBox.AccessibleDescription = "Ready For Test"
            Me.readyForTestCheckBox.AccessibleName = "Ready For Test"
            Me.readyForTestCheckBox.Checked = False
            Me.readyForTestCheckBox.Name = "readyForTestCheckBox"
            Me.readyForTestCheckBox.Text = "Ready For Test"
            Me.readyForTestCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'doneCheckBox
            '
            Me.doneCheckBox.AccessibleDescription = "Done"
            Me.doneCheckBox.AccessibleName = "Done"
            Me.doneCheckBox.Checked = False
            Me.doneCheckBox.Name = "doneCheckBox"
            Me.doneCheckBox.Text = "Done"
            Me.doneCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radRibbonBarButtonGroup3
            '
            Me.radRibbonBarButtonGroup3.AccessibleDescription = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.AccessibleName = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.unassignedCheckBox, Me.newCheckBox})
            Me.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.radRibbonBarButtonGroup3.StretchVertically = True
            Me.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3"
            Me.radRibbonBarButtonGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'unassignedCheckBox
            '
            Me.unassignedCheckBox.AccessibleDescription = "Unassigned"
            Me.unassignedCheckBox.AccessibleName = "Unassigned"
            Me.unassignedCheckBox.Checked = False
            Me.unassignedCheckBox.Name = "unassignedCheckBox"
            Me.unassignedCheckBox.Text = "Unassigned"
            Me.unassignedCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'newCheckBox
            '
            Me.newCheckBox.AccessibleDescription = "New"
            Me.newCheckBox.AccessibleName = "New"
            Me.newCheckBox.Checked = False
            Me.newCheckBox.Name = "newCheckBox"
            Me.newCheckBox.Text = "New"
            Me.newCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'viewTab
            '
            Me.viewTab.AccessibleDescription = "View"
            Me.viewTab.AccessibleName = "View"
            Me.viewTab.Alignment = System.Drawing.ContentAlignment.BottomLeft
            Me.viewTab.Class = "RibbonTab"
            Me.viewTab.Items.AddRange(New Telerik.WinControls.RadItem() {Me.layoutGroup, Me.panelsGroup, Me.radRibbonBarGroup1})
            Me.viewTab.Name = "viewTab"
            Me.viewTab.StretchHorizontally = False
            Me.viewTab.Text = "View"
            Me.viewTab.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'layoutGroup
            '
            Me.layoutGroup.AccessibleDescription = "Layout"
            Me.layoutGroup.AccessibleName = "Layout"
            Me.layoutGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.loadLayoutButton, Me.saveLayoutButton})
            Me.layoutGroup.Name = "layoutGroup"
            Me.layoutGroup.Text = "Layout"
            Me.layoutGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'loadLayoutButton
            '
            Me.loadLayoutButton.AccessibleDescription = "Load"
            Me.loadLayoutButton.AccessibleName = "Load"
            Me.loadLayoutButton.Class = "RibbonBarButtonElement"
            Me.loadLayoutButton.Image = Global.Resources.layout_load
            Me.loadLayoutButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.loadLayoutButton.MinSize = New System.Drawing.Size(48, 0)
            Me.loadLayoutButton.Name = "loadLayoutButton"
            Me.loadLayoutButton.Text = "Load"
            Me.loadLayoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.loadLayoutButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'saveLayoutButton
            '
            Me.saveLayoutButton.AccessibleDescription = "Save"
            Me.saveLayoutButton.AccessibleName = "Save"
            Me.saveLayoutButton.Class = "RibbonBarButtonElement"
            Me.saveLayoutButton.Image = Global.Resources.layout_save
            Me.saveLayoutButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.saveLayoutButton.MinSize = New System.Drawing.Size(48, 0)
            Me.saveLayoutButton.Name = "saveLayoutButton"
            Me.saveLayoutButton.Text = "Save"
            Me.saveLayoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.saveLayoutButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'panelsGroup
            '
            Me.panelsGroup.AccessibleDescription = "Panels"
            Me.panelsGroup.AccessibleName = "Panels"
            Me.panelsGroup.Items.AddRange(New Telerik.WinControls.RadItem() {Me.projectsButton, Me.detailsButton, Me.bugsButton, Me.featuresButton})
            Me.panelsGroup.Name = "panelsGroup"
            Me.panelsGroup.Text = "Panels"
            Me.panelsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'projectsButton
            '
            Me.projectsButton.AccessibleDescription = "Projects"
            Me.projectsButton.AccessibleName = "Projects"
            Me.projectsButton.Class = "RibbonBarButtonElement"
            Me.projectsButton.Image = Global.Resources.panels
            Me.projectsButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.projectsButton.MinSize = New System.Drawing.Size(48, 0)
            Me.projectsButton.Name = "projectsButton"
            Me.projectsButton.Text = "Projects"
            Me.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.projectsButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'detailsButton
            '
            Me.detailsButton.AccessibleDescription = "Details"
            Me.detailsButton.AccessibleName = "Details"
            Me.detailsButton.Class = "RibbonBarButtonElement"
            Me.detailsButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.detailsButton.MinSize = New System.Drawing.Size(48, 0)
            Me.detailsButton.Name = "detailsButton"
            Me.detailsButton.Text = "Details"
            Me.detailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.detailsButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.detailsButton.Image = Global.Resources.panels
            '
            'bugsButton
            '
            Me.bugsButton.AccessibleDescription = "Bugs"
            Me.bugsButton.AccessibleName = "Bugs"
            Me.bugsButton.Class = "RibbonBarButtonElement"
            Me.bugsButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.bugsButton.MinSize = New System.Drawing.Size(48, 0)
            Me.bugsButton.Name = "bugsButton"
            Me.bugsButton.Text = "Bugs"
            Me.bugsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.bugsButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.bugsButton.Image = Global.Resources.panels
            '
            'featuresButton
            '
            Me.featuresButton.AccessibleDescription = "Features"
            Me.featuresButton.AccessibleName = "Features"
            Me.featuresButton.Class = "RibbonBarButtonElement"
            Me.featuresButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.featuresButton.MinSize = New System.Drawing.Size(48, 0)
            Me.featuresButton.Name = "featuresButton"
            Me.featuresButton.Text = "Features"
            Me.featuresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.featuresButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.featuresButton.Image = Global.Resources.panels
            '
            'radRibbonBarGroup1
            '
            Me.radRibbonBarGroup1.AccessibleDescription = "Themes"
            Me.radRibbonBarGroup1.AccessibleName = "Themes"
            Me.radRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radGalleryElement1})
            Me.radRibbonBarGroup1.Name = "radRibbonBarGroup1"
            Me.radRibbonBarGroup1.Text = "Themes"
            Me.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radGalleryElement1
            '
            Me.radGalleryElement1.AccessibleDescription = "radGalleryElement1"
            Me.radGalleryElement1.AccessibleName = "radGalleryElement1"
            Me.radGalleryElement1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.office2010BlackButton, Me.office2010BlueButton, Me.office2010SilverButton, Me.controlDefaultButton, Me.telerikButton})
            Me.radGalleryElement1.Name = "radGalleryElement1"
            Me.radGalleryElement1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
            Me.radGalleryElement1.Text = "radGalleryElement1"
            Me.radGalleryElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'office2010BlackButton
            '
            Me.office2010BlackButton.AccessibleDescription = "Office2010Black"
            Me.office2010BlackButton.AccessibleName = "Office2010Black"
            Me.office2010BlackButton.DescriptionText = ""
            Me.office2010BlackButton.Image = Global.Resources.Office2010Black
            Me.office2010BlackButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.office2010BlackButton.Name = "office2010BlackButton"
            Me.office2010BlackButton.StretchHorizontally = False
            Me.office2010BlackButton.StretchVertically = False
            Me.office2010BlackButton.Text = "Office2010Black"
            Me.office2010BlackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.office2010BlackButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'office2010BlueButton
            '
            Me.office2010BlueButton.AccessibleDescription = "Office2010Blue"
            Me.office2010BlueButton.AccessibleName = "Office2010Blue"
            Me.office2010BlueButton.DescriptionText = ""
            Me.office2010BlueButton.Image = Global.Resources.Office2010Blue
            Me.office2010BlueButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.office2010BlueButton.Name = "office2010BlueButton"
            Me.office2010BlueButton.StretchHorizontally = False
            Me.office2010BlueButton.StretchVertically = False
            Me.office2010BlueButton.Text = "Office2010Blue"
            Me.office2010BlueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.office2010BlueButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'office2010SilverButton
            '
            Me.office2010SilverButton.AccessibleDescription = "Office2010Silver"
            Me.office2010SilverButton.AccessibleName = "Office2010Silver"
            Me.office2010SilverButton.DescriptionText = ""
            Me.office2010SilverButton.Image = Global.Resources.Office2010Silver
            Me.office2010SilverButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.office2010SilverButton.Name = "office2010SilverButton"
            Me.office2010SilverButton.StretchHorizontally = False
            Me.office2010SilverButton.StretchVertically = False
            Me.office2010SilverButton.Text = "Office2010Silver"
            Me.office2010SilverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.office2010SilverButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'controlDefaultButton
            '
            Me.controlDefaultButton.AccessibleDescription = "ControlDefault"
            Me.controlDefaultButton.AccessibleName = "ControlDefault"
            Me.controlDefaultButton.DescriptionText = ""
            Me.controlDefaultButton.Image = Global.Resources.ControlDefault
            Me.controlDefaultButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.controlDefaultButton.Name = "controlDefaultButton"
            Me.controlDefaultButton.StretchHorizontally = False
            Me.controlDefaultButton.StretchVertically = False
            Me.controlDefaultButton.Text = "ControlDefault"
            Me.controlDefaultButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.controlDefaultButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'telerikButton
            '
            Me.telerikButton.AccessibleDescription = "TelerikMetro"
            Me.telerikButton.AccessibleName = "TelerikMetro"
            Me.telerikButton.DescriptionText = ""
            Me.telerikButton.Image = Global.Resources.Telerik
            Me.telerikButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.telerikButton.Name = "telerikButton"
            Me.telerikButton.StretchHorizontally = False
            Me.telerikButton.StretchVertically = False
            Me.telerikButton.Text = "TelerikMetro"
            Me.telerikButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.telerikButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'loadDatabaseMenuItem
            '
            Me.loadDatabaseMenuItem.AccessibleDescription = "Load Database"
            Me.loadDatabaseMenuItem.AccessibleName = "Load Database"
            Me.loadDatabaseMenuItem.Name = "loadDatabaseMenuItem"
            Me.loadDatabaseMenuItem.Text = "Load Database"
            Me.loadDatabaseMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem1
            '
            Me.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
            Me.radMenuSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'addMenuItem
            '
            Me.addMenuItem.AccessibleDescription = "Add item"
            Me.addMenuItem.AccessibleName = "Add item"
            Me.addMenuItem.Name = "addMenuItem"
            Me.addMenuItem.Text = "Add item"
            Me.addMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'removeMenuItem
            '
            Me.removeMenuItem.AccessibleDescription = "Remove item"
            Me.removeMenuItem.AccessibleName = "Remove item"
            Me.removeMenuItem.Name = "removeMenuItem"
            Me.removeMenuItem.Text = "Remove item"
            Me.removeMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'editMenuItem
            '
            Me.editMenuItem.AccessibleDescription = "Edit item"
            Me.editMenuItem.AccessibleName = "Edit item"
            Me.editMenuItem.Name = "editMenuItem"
            Me.editMenuItem.Text = "Edit item"
            Me.editMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'radMenuSeparatorItem2
            '
            Me.radMenuSeparatorItem2.AccessibleDescription = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.AccessibleName = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
            Me.radMenuSeparatorItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'aboutMenuItem
            '
            Me.aboutMenuItem.AccessibleDescription = "About"
            Me.aboutMenuItem.AccessibleName = "About"
            Me.aboutMenuItem.Name = "aboutMenuItem"
            Me.aboutMenuItem.Text = "About"
            Me.aboutMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'exitMenuItem
            '
            Me.exitMenuItem.AccessibleDescription = "Exit"
            Me.exitMenuItem.AccessibleName = "Exit"
            Me.exitMenuItem.Name = "exitMenuItem"
            Me.exitMenuItem.Text = "Exit"
            Me.exitMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.radDock1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 154)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1008, 558)
            Me.panel1.TabIndex = 2
            '
            'radDock1
            '
            Me.radDock1.ActiveWindow = Me.projectsToolWindow
            Me.radDock1.CausesValidation = False
            Me.radDock1.Controls.Add(Me.toolTabStrip3)
            Me.radDock1.Controls.Add(Me.radSplitContainer2)
            Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
            Me.radDock1.IsCleanUpTarget = True
            Me.radDock1.Location = New System.Drawing.Point(0, 0)
            Me.radDock1.MainDocumentContainer = Me.documentContainer1
            Me.radDock1.Name = "radDock1"
            Me.radDock1.Padding = New System.Windows.Forms.Padding(5)
            '
            '
            '
            Me.radDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
            Me.radDock1.Size = New System.Drawing.Size(1008, 558)
            Me.radDock1.SplitterWidth = 4
            Me.radDock1.TabIndex = 0
            Me.radDock1.TabStop = False
            Me.radDock1.Text = "radDock1"
            '
            'projectsToolWindow
            '
            Me.projectsToolWindow.Caption = Nothing
            Me.projectsToolWindow.Controls.Add(Me.projectsTreeView)
            Me.projectsToolWindow.Location = New System.Drawing.Point(1, 24)
            Me.projectsToolWindow.Name = "projectsToolWindow"
            Me.projectsToolWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.projectsToolWindow.Size = New System.Drawing.Size(198, 522)
            Me.projectsToolWindow.Text = "Projects"
            '
            'projectsTreeView
            '
            Me.projectsTreeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.projectsTreeView.Location = New System.Drawing.Point(0, 0)
            Me.projectsTreeView.Name = "projectsTreeView"
            Me.projectsTreeView.Size = New System.Drawing.Size(198, 522)
            Me.projectsTreeView.SpacingBetweenNodes = -1
            Me.projectsTreeView.TabIndex = 0
            Me.projectsTreeView.Text = "radTreeView1"
            '
            'toolTabStrip3
            '
            Me.toolTabStrip3.CausesValidation = False
            Me.toolTabStrip3.Controls.Add(Me.projectsToolWindow)
            Me.toolTabStrip3.Location = New System.Drawing.Point(5, 5)
            Me.toolTabStrip3.Name = "toolTabStrip3"
            '
            '
            '
            Me.toolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.toolTabStrip3.SelectedIndex = 0
            Me.toolTabStrip3.Size = New System.Drawing.Size(200, 548)
            Me.toolTabStrip3.TabIndex = 1
            Me.toolTabStrip3.TabStop = False
            '
            'radSplitContainer2
            '
            Me.radSplitContainer2.Controls.Add(Me.documentContainer1)
            Me.radSplitContainer2.Controls.Add(Me.toolTabStrip2)
            Me.radSplitContainer2.IsCleanUpTarget = True
            Me.radSplitContainer2.Location = New System.Drawing.Point(209, 5)
            Me.radSplitContainer2.Name = "radSplitContainer2"
            Me.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            '
            '
            Me.radSplitContainer2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.radSplitContainer2.Size = New System.Drawing.Size(794, 548)
            Me.radSplitContainer2.SplitterWidth = 4
            Me.radSplitContainer2.TabIndex = 0
            Me.radSplitContainer2.TabStop = False
            '
            'documentContainer1
            '
            Me.documentContainer1.Controls.Add(Me.documentTabStrip2)
            Me.documentContainer1.Location = New System.Drawing.Point(0, 0)
            Me.documentContainer1.Name = "documentContainer1"
            '
            '
            '
            Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.documentContainer1.Size = New System.Drawing.Size(794, 383)
            Me.documentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 387)
            Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            Me.documentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 39)
            Me.documentContainer1.SplitterWidth = 4
            Me.documentContainer1.TabIndex = 0
            Me.documentContainer1.TabStop = False
            '
            'documentTabStrip2
            '
            Me.documentTabStrip2.Controls.Add(Me.bugDocumentWindow)
            Me.documentTabStrip2.Controls.Add(Me.featureDocumentWindow)
            Me.documentTabStrip2.Location = New System.Drawing.Point(0, 0)
            Me.documentTabStrip2.Name = "documentTabStrip2"
            '
            '
            '
            Me.documentTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.documentTabStrip2.SelectedIndex = 0
            Me.documentTabStrip2.Size = New System.Drawing.Size(794, 383)
            Me.documentTabStrip2.TabIndex = 0
            Me.documentTabStrip2.TabStop = False
            '
            'bugDocumentWindow
            '
            Me.bugDocumentWindow.Controls.Add(Me.bugsGrid)
            Me.bugDocumentWindow.Location = New System.Drawing.Point(6, 31)
            Me.bugDocumentWindow.Name = "bugDocumentWindow"
            Me.bugDocumentWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
            Me.bugDocumentWindow.Size = New System.Drawing.Size(782, 346)
            Me.bugDocumentWindow.Text = "Bugs"
            '
            'bugsGrid
            '
            Me.bugsGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.bugsGrid.Location = New System.Drawing.Point(0, 0)
            Me.bugsGrid.Name = "bugsGrid"
            Me.bugsGrid.Size = New System.Drawing.Size(782, 346)
            Me.bugsGrid.TabIndex = 0
            Me.bugsGrid.Text = "radGridView1"
            '
            'featureDocumentWindow
            '
            Me.featureDocumentWindow.Controls.Add(Me.featuresGrid)
            Me.featureDocumentWindow.Location = New System.Drawing.Point(6, 30)
            Me.featureDocumentWindow.Name = "featureDocumentWindow"
            Me.featureDocumentWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
            Me.featureDocumentWindow.Size = New System.Drawing.Size(782, 351)
            Me.featureDocumentWindow.Text = "Features"
            '
            'featuresGrid
            '
            Me.featuresGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.featuresGrid.Location = New System.Drawing.Point(0, 0)
            Me.featuresGrid.Name = "featuresGrid"
            Me.featuresGrid.Size = New System.Drawing.Size(782, 351)
            Me.featuresGrid.TabIndex = 0
            Me.featuresGrid.Text = "radGridView1"
            '
            'toolTabStrip2
            '
            Me.toolTabStrip2.Controls.Add(Me.detailsToolWindow)
            Me.toolTabStrip2.Location = New System.Drawing.Point(0, 387)
            Me.toolTabStrip2.Name = "toolTabStrip2"
            '
            '
            '
            Me.toolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.toolTabStrip2.SelectedIndex = 0
            Me.toolTabStrip2.Size = New System.Drawing.Size(794, 161)
            Me.toolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 161)
            Me.toolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -39)
            Me.toolTabStrip2.TabIndex = 1
            Me.toolTabStrip2.TabStop = False
            '
            'detailsToolWindow
            '
            Me.detailsToolWindow.Caption = Nothing
            Me.detailsToolWindow.Controls.Add(Me.detailsPageView)
            Me.detailsToolWindow.Location = New System.Drawing.Point(1, 24)
            Me.detailsToolWindow.Name = "detailsToolWindow"
            Me.detailsToolWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.detailsToolWindow.Size = New System.Drawing.Size(792, 135)
            Me.detailsToolWindow.Text = "Details"
            '
            'detailsPageView
            '
            Me.detailsPageView.Controls.Add(Me.generalPageViewPage)
            Me.detailsPageView.Controls.Add(Me.descriptionPageViewPage)
            Me.detailsPageView.Controls.Add(Me.stepsToReproducePageViewPage)
            Me.detailsPageView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.detailsPageView.Location = New System.Drawing.Point(0, 0)
            Me.detailsPageView.Name = "detailsPageView"
            Me.detailsPageView.SelectedPage = Me.generalPageViewPage
            Me.detailsPageView.Size = New System.Drawing.Size(792, 135)
            Me.detailsPageView.TabIndex = 0
            Me.detailsPageView.Text = "radPageView1"
            CType(Me.detailsPageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
            '
            'generalPageViewPage
            '
            Me.generalPageViewPage.Controls.Add(Me.ownerDropDownList)
            Me.generalPageViewPage.Controls.Add(Me.ownerLabel)
            Me.generalPageViewPage.Controls.Add(Me.idSpinEditor)
            Me.generalPageViewPage.Controls.Add(Me.priorityDropDownList)
            Me.generalPageViewPage.Controls.Add(Me.dateDateTimePicker)
            Me.generalPageViewPage.Controls.Add(Me.statusDropDownList)
            Me.generalPageViewPage.Controls.Add(Me.titleTextBox)
            Me.generalPageViewPage.Controls.Add(Me.priorityLabel)
            Me.generalPageViewPage.Controls.Add(Me.dateLabel)
            Me.generalPageViewPage.Controls.Add(Me.statusLabel)
            Me.generalPageViewPage.Controls.Add(Me.titleLabel)
            Me.generalPageViewPage.Controls.Add(Me.idLabel)
            Me.generalPageViewPage.Location = New System.Drawing.Point(10, 37)
            Me.generalPageViewPage.Name = "generalPageViewPage"
            Me.generalPageViewPage.Size = New System.Drawing.Size(771, 87)
            Me.generalPageViewPage.Text = "General"
            '
            'ownerDropDownList
            '
            Me.ownerDropDownList.DropDownAnimationEnabled = True
            Me.ownerDropDownList.Location = New System.Drawing.Point(441, 58)
            Me.ownerDropDownList.Name = "ownerDropDownList"
            Me.ownerDropDownList.ShowImageInEditorArea = True
            Me.ownerDropDownList.Size = New System.Drawing.Size(323, 20)
            Me.ownerDropDownList.TabIndex = 8
            '
            'ownerLabel
            '
            Me.ownerLabel.Location = New System.Drawing.Point(393, 58)
            Me.ownerLabel.Name = "ownerLabel"
            Me.ownerLabel.Size = New System.Drawing.Size(39, 18)
            Me.ownerLabel.TabIndex = 2
            Me.ownerLabel.Text = "Owner"
            '
            'idSpinEditor
            '
            Me.idSpinEditor.Location = New System.Drawing.Point(51, 29)
            Me.idSpinEditor.Name = "idSpinEditor"
            '
            '
            '
            Me.idSpinEditor.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.idSpinEditor.ShowBorder = True
            Me.idSpinEditor.Size = New System.Drawing.Size(326, 20)
            Me.idSpinEditor.TabIndex = 7
            Me.idSpinEditor.TabStop = False
            '
            'priorityDropDownList
            '
            Me.priorityDropDownList.DropDownAnimationEnabled = True
            Me.priorityDropDownList.Location = New System.Drawing.Point(441, 31)
            Me.priorityDropDownList.Name = "priorityDropDownList"
            Me.priorityDropDownList.ShowImageInEditorArea = True
            Me.priorityDropDownList.Size = New System.Drawing.Size(327, 20)
            Me.priorityDropDownList.TabIndex = 6
            '
            'dateDateTimePicker
            '
            Me.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.dateDateTimePicker.Location = New System.Drawing.Point(441, 3)
            Me.dateDateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.dateDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.dateDateTimePicker.Name = "dateDateTimePicker"
            Me.dateDateTimePicker.NullableValue = New Date(2011, 8, 29, 14, 37, 48, 286)
            Me.dateDateTimePicker.NullDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.dateDateTimePicker.Size = New System.Drawing.Size(326, 20)
            Me.dateDateTimePicker.TabIndex = 5
            Me.dateDateTimePicker.TabStop = False
            Me.dateDateTimePicker.Value = New Date(2011, 8, 29, 14, 37, 48, 286)
            '
            'statusDropDownList
            '
            Me.statusDropDownList.DropDownAnimationEnabled = True
            Me.statusDropDownList.Location = New System.Drawing.Point(51, 58)
            Me.statusDropDownList.Name = "statusDropDownList"
            Me.statusDropDownList.ShowImageInEditorArea = True
            Me.statusDropDownList.Size = New System.Drawing.Size(327, 20)
            Me.statusDropDownList.TabIndex = 4
            '
            'titleTextBox
            '
            Me.titleTextBox.Location = New System.Drawing.Point(51, 3)
            Me.titleTextBox.Name = "titleTextBox"
            Me.titleTextBox.Size = New System.Drawing.Size(326, 20)
            Me.titleTextBox.TabIndex = 3
            Me.titleTextBox.TabStop = False
            '
            'priorityLabel
            '
            Me.priorityLabel.Location = New System.Drawing.Point(393, 31)
            Me.priorityLabel.Name = "priorityLabel"
            Me.priorityLabel.Size = New System.Drawing.Size(42, 18)
            Me.priorityLabel.TabIndex = 1
            Me.priorityLabel.Text = "Priority"
            '
            'dateLabel
            '
            Me.dateLabel.Location = New System.Drawing.Point(393, 5)
            Me.dateLabel.Name = "dateLabel"
            Me.dateLabel.Size = New System.Drawing.Size(30, 18)
            Me.dateLabel.TabIndex = 1
            Me.dateLabel.Text = "Date"
            '
            'statusLabel
            '
            Me.statusLabel.Location = New System.Drawing.Point(3, 58)
            Me.statusLabel.Name = "statusLabel"
            Me.statusLabel.Size = New System.Drawing.Size(37, 18)
            Me.statusLabel.TabIndex = 1
            Me.statusLabel.Text = "Status"
            '
            'titleLabel
            '
            Me.titleLabel.Location = New System.Drawing.Point(3, 3)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(27, 18)
            Me.titleLabel.TabIndex = 1
            Me.titleLabel.Text = "Title"
            '
            'idLabel
            '
            Me.idLabel.Location = New System.Drawing.Point(3, 29)
            Me.idLabel.Name = "idLabel"
            Me.idLabel.Size = New System.Drawing.Size(16, 18)
            Me.idLabel.TabIndex = 0
            Me.idLabel.Text = "Id"
            '
            'descriptionPageViewPage
            '
            Me.descriptionPageViewPage.Controls.Add(Me.descriptionTextBox)
            Me.descriptionPageViewPage.Location = New System.Drawing.Point(10, 37)
            Me.descriptionPageViewPage.Name = "descriptionPageViewPage"
            Me.descriptionPageViewPage.Size = New System.Drawing.Size(771, 79)
            Me.descriptionPageViewPage.Text = "Description"
            '
            'descriptionTextBox
            '
            Me.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.descriptionTextBox.Location = New System.Drawing.Point(0, 0)
            Me.descriptionTextBox.Multiline = True
            Me.descriptionTextBox.Name = "descriptionTextBox"
            '
            '
            '
            Me.descriptionTextBox.RootElement.StretchVertically = True
            Me.descriptionTextBox.Size = New System.Drawing.Size(771, 79)
            Me.descriptionTextBox.TabIndex = 1
            Me.descriptionTextBox.TabStop = False
            '
            'stepsToReproducePageViewPage
            '
            Me.stepsToReproducePageViewPage.Controls.Add(Me.stepsToReproduceTextBox)
            Me.stepsToReproducePageViewPage.Location = New System.Drawing.Point(10, 37)
            Me.stepsToReproducePageViewPage.Name = "stepsToReproducePageViewPage"
            Me.stepsToReproducePageViewPage.Size = New System.Drawing.Size(771, 79)
            Me.stepsToReproducePageViewPage.Text = "Steps to reproduce"
            '
            'stepsToReproduceTextBox
            '
            Me.stepsToReproduceTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.stepsToReproduceTextBox.Location = New System.Drawing.Point(0, 0)
            Me.stepsToReproduceTextBox.Multiline = True
            Me.stepsToReproduceTextBox.Name = "stepsToReproduceTextBox"
            '
            '
            '
            Me.stepsToReproduceTextBox.RootElement.StretchVertically = True
            Me.stepsToReproduceTextBox.Size = New System.Drawing.Size(771, 79)
            Me.stepsToReproduceTextBox.TabIndex = 2
            Me.stepsToReproduceTextBox.TabStop = False
            '
            'RadRibbonForm1
            '
            Me.AllowAero = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1008, 712)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.radRibbonBar1)
            Me.Name = "RadRibbonForm1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Bug Tracker"
            CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radDock1.ResumeLayout(False)
            Me.projectsToolWindow.ResumeLayout(False)
            CType(Me.projectsTreeView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolTabStrip3.ResumeLayout(False)
            CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radSplitContainer2.ResumeLayout(False)
            CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentContainer1.ResumeLayout(False)
            CType(Me.documentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.documentTabStrip2.ResumeLayout(False)
            Me.bugDocumentWindow.ResumeLayout(False)
            CType(Me.bugsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.featureDocumentWindow.ResumeLayout(False)
            CType(Me.featuresGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolTabStrip2.ResumeLayout(False)
            Me.detailsToolWindow.ResumeLayout(False)
            CType(Me.detailsPageView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.detailsPageView.ResumeLayout(False)
            Me.generalPageViewPage.ResumeLayout(False)
            Me.generalPageViewPage.PerformLayout()
            CType(Me.ownerDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ownerLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.idSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.priorityDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.titleTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.priorityLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.titleLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.idLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.descriptionPageViewPage.ResumeLayout(False)
            Me.descriptionPageViewPage.PerformLayout()
            CType(Me.descriptionTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.stepsToReproducePageViewPage.ResumeLayout(False)
            Me.stepsToReproducePageViewPage.PerformLayout()
            CType(Me.stepsToReproduceTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub



		#End Region

		Private radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
		Private panel1 As System.Windows.Forms.Panel
		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private featureDocumentWindow As Telerik.WinControls.UI.Docking.DocumentWindow
        Private projectsToolWindow As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
        Private bugDocumentWindow As Telerik.WinControls.UI.Docking.DocumentWindow
        Private detailsToolWindow As Telerik.WinControls.UI.Docking.ToolWindow
		Private detailsPageView As Telerik.WinControls.UI.RadPageView
		Private generalPageViewPage As Telerik.WinControls.UI.RadPageViewPage
		Private descriptionPageViewPage As Telerik.WinControls.UI.RadPageViewPage
		Private stepsToReproducePageViewPage As Telerik.WinControls.UI.RadPageViewPage
		Private featuresGrid As Telerik.WinControls.UI.RadGridView
		Private projectsTreeView As Telerik.WinControls.UI.RadTreeView
		Private homeTab As Telerik.WinControls.UI.RibbonTab
		Private databaseGroup As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents loadDatabaseButton As Telerik.WinControls.UI.RadButtonElement
		Private editGroup As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents addButton As Telerik.WinControls.UI.RadButtonElement
		Private WithEvents removeButton As Telerik.WinControls.UI.RadButtonElement
		Private WithEvents editButton As Telerik.WinControls.UI.RadButtonElement
		Private viewGroup As Telerik.WinControls.UI.RadRibbonBarGroup
		Private sortDropDownButton As Telerik.WinControls.UI.RadDropDownButtonElement
		Private sortNoneMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private sortDateMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private sortStatusMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private sortOwnerMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private viewTab As Telerik.WinControls.UI.RibbonTab
		Private layoutGroup As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents loadLayoutButton As Telerik.WinControls.UI.RadButtonElement
		Private WithEvents saveLayoutButton As Telerik.WinControls.UI.RadButtonElement
		Private panelsGroup As Telerik.WinControls.UI.RadRibbonBarGroup
		Private bugsGrid As Telerik.WinControls.UI.RadGridView
		Private loadDatabaseMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private addMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private removeMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private editMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private aboutMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private exitMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private descriptionTextBox As Telerik.WinControls.UI.RadTextBox
		Private stepsToReproduceTextBox As Telerik.WinControls.UI.RadTextBox
		Private idSpinEditor As Telerik.WinControls.UI.RadSpinEditor
		Private priorityDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private dateDateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
		Private statusDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private titleTextBox As Telerik.WinControls.UI.RadTextBox
		Private priorityLabel As Telerik.WinControls.UI.RadLabel
		Private dateLabel As Telerik.WinControls.UI.RadLabel
		Private statusLabel As Telerik.WinControls.UI.RadLabel
		Private titleLabel As Telerik.WinControls.UI.RadLabel
		Private idLabel As Telerik.WinControls.UI.RadLabel
		Private WithEvents saveDatabaseButton As Telerik.WinControls.UI.RadButtonElement
		Private office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
		Private office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
		Private office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
        Private telerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
		Private dateAscendingMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private dateDescendingMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private statusAscendingMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private statusDescendingMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private ownerAscendingMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private ownerDescendingMenuItem As Telerik.WinControls.UI.RadMenuItem
		Private projectsButton As Telerik.WinControls.UI.RadButtonElement
		Private detailsButton As Telerik.WinControls.UI.RadButtonElement
		Private bugsButton As Telerik.WinControls.UI.RadButtonElement
		Private featuresButton As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarButtonGroup1 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private ownerDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private ownerLabel As Telerik.WinControls.UI.RadLabel
		Private radRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radGalleryElement1 As Telerik.WinControls.UI.RadGalleryElement
		Private telerikButton As Telerik.WinControls.UI.RadGalleryItem
		Private office2010BlackButton As Telerik.WinControls.UI.RadGalleryItem
		Private office2010BlueButton As Telerik.WinControls.UI.RadGalleryItem
		Private office2010SilverButton As Telerik.WinControls.UI.RadGalleryItem
		Private controlDefaultButton As Telerik.WinControls.UI.RadGalleryItem
		Private radRibbonBarButtonGroup2 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private openCheckBox As Telerik.WinControls.UI.RadCheckBoxElement
		Private readyForTestCheckBox As Telerik.WinControls.UI.RadCheckBoxElement
		Private doneCheckBox As Telerik.WinControls.UI.RadCheckBoxElement
		Private radRibbonBarButtonGroup3 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private unassignedCheckBox As Telerik.WinControls.UI.RadCheckBoxElement
        Private newCheckBox As Telerik.WinControls.UI.RadCheckBoxElement
        Friend WithEvents toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents documentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
        Friend WithEvents toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
	End Class
End Namespace
